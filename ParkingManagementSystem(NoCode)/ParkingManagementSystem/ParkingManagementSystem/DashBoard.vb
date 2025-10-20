Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing

Public Class Dashboard

    Private Const TOTAL_PARKING_SLOTS As Integer = 24

    Private Sub Dashboard_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateDashboard()
        tmrAlertChecker.Interval = 1000 ' Check every 15 seconds
        tmrAlertChecker.Start()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub tmrAlertChecker_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles tmrAlertChecker.Tick
        Dim currentTime As DateTime = DateTime.Now
        ' Check if it's 10:00 PM
        If currentTime.Hour = 22 AndAlso currentTime.Minute = 0 Then

            ShowAlertNotification()
        End If
        ' Reset alert flags at midnight to allow new alerts the next day
        If currentTime.Hour = 0 AndAlso currentTime.Minute = 0 Then
            ResetAlertFlags()
        End If
        ' Keep timer running every minute
        tmrAlertChecker.Interval = 60000 ' 1 minute
        tmrAlertChecker.Start()
    End Sub

    Private Sub ShowOverstayingVehicles()
        FlowLayoutPanel1.Controls.Clear()

        Dim query As String =
            "SELECT vehicleRegistrationNumber, SlotNumber, parkingTimeIn " &
            "FROM ParkingHistory " &
            "WHERE parkingTimeOut IS NULL " &
            "AND (CAST(parkingTimeIn AS DATE) < CAST(GETDATE() AS DATE) " &
            "     OR (CAST(parkingTimeIn AS DATE) = CAST(GETDATE() AS DATE) AND DATEPART(HOUR, GETDATE()) >= 22))"

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If Not reader.HasRows Then
                        Dim lbl As New Label()
                        lbl.Text = "No overstaying vehicles."
                        lbl.AutoSize = True
                        FlowLayoutPanel1.Controls.Add(lbl)
                    Else
                        While reader.Read()
                            Dim plate As String = reader("vehicleRegistrationNumber").ToString()
                            Dim slot As String = reader("SlotNumber").ToString()
                            Dim timeIn As DateTime = Convert.ToDateTime(reader("parkingTimeIn"))

                            Dim lbl As New Label()
                            lbl.Text = "Plate: " & plate & " | Slot: " & slot & " | Time In: " & timeIn.ToString("yyyy-MM-dd HH:mm")
                            lbl.AutoSize = True
                            lbl.ForeColor = Color.DarkRed
                            lbl.Font = New Font("Segoe UI", 10, FontStyle.Bold)
                            FlowLayoutPanel1.Controls.Add(lbl)
                        End While
                    End If
                End Using
            End Using
        End Using
    End Sub


    Private Sub ShowAlertNotification()
        FlowLayoutPanel1.Controls.Clear()

        ' lahat ng vehicles na naka-park pa rin pag 10:00pm
        Dim query As String =
            "SELECT parkingID, vehicleRegistrationNumber, SlotNumber, parkingTimeIn " &
            "FROM ParkingHistory " &
            "WHERE parkingTimeOut IS NULL AND isAlertGenerated = 0"

        Try
            Using conn As SqlConnection = DBConnection.GetConnection()
                If conn Is Nothing Then
                    Dim errorLabel As New Label()
                    errorLabel.Text = "Error: Unable to connect to database."
                    errorLabel.AutoSize = True
                    errorLabel.ForeColor = Color.Red
                    FlowLayoutPanel1.Controls.Add(errorLabel)
                    Return
                End If

                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If Not reader.HasRows Then
                            Dim noVehiclesLabel As New Label()
                            noVehiclesLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm") &
                                " - No overstaying vehicles at 10:00 PM."
                            noVehiclesLabel.AutoSize = True
                            noVehiclesLabel.ForeColor = Color.DarkGreen
                            FlowLayoutPanel1.Controls.Add(noVehiclesLabel)
                        Else
                            While reader.Read()
                                Dim parkingID As Integer = Convert.ToInt32(reader("parkingID"))
                                Dim plateNumber As String = reader("vehicleRegistrationNumber").ToString()
                                Dim slotNumber As String = reader("SlotNumber").ToString()
                                Dim timeIn As DateTime = Convert.ToDateTime(reader("parkingTimeIn"))

                                Dim alertMessage As String =
                                    String.Format("ALERT: Vehicle [{0}] in Slot [{1}] still parked since {2:yyyy-MM-dd HH:mm}.",
                                                  plateNumber, slotNumber, timeIn)

                                ' add to panel
                                Dim vehicleLabel As New Label()
                                vehicleLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm") & " - " & alertMessage
                                vehicleLabel.AutoSize = True
                                vehicleLabel.ForeColor = Color.DarkRed
                                vehicleLabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                                vehicleLabel.Margin = New Padding(5)
                                vehicleLabel.MaximumSize = New Size(FlowLayoutPanel1.Width - 20, 0)
                                FlowLayoutPanel1.Controls.Add(vehicleLabel)

                                ' log and flag
                                LogAlertAndFlagVehicle(parkingID, alertMessage)
                            End While
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            Dim errorLabel As New Label()
            errorLabel.Text = "Error: " & ex.Message
            errorLabel.AutoSize = True
            errorLabel.ForeColor = Color.Red
            FlowLayoutPanel1.Controls.Add(errorLabel)
        End Try
    End Sub


    Private Sub ResetAlertFlags()
        ' Reset isAlertGenerated flag for all records to allow new notifications the next day
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Dim query As String = "UPDATE ParkingHistory SET isAlertGenerated = 0"
            Using cmd As New SqlCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    ' Ito ang main function na tumatawag sa lahat ng updates
    Public Sub UpdateDashboard()
        Try
            UpdateCountLabels()
            LoadAlerts()
            LoadActionHistory()
            ShowOverstayingVehicles() ' <<-- idagdag dito
        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard data." & vbCrLf & ex.Message, "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' =========================================================================
    '  ITO ANG NAG-A-UPDATE NG BILANG (AVAILABLE, OCCUPIED, ETC.) - WALANG PAGBABAGO
    ' =========================================================================
    Public Sub UpdateCountLabels()
        Dim occupiedCount As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM ParkingHistory WHERE parkingTimeOut IS NULL"
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                occupiedCount = CInt(cmd.ExecuteScalar())
            End Using
        End Using

        Dim availableCount As Integer = TOTAL_PARKING_SLOTS - occupiedCount
        lblOccupied.Text = occupiedCount.ToString()
        lblAvailable.Text = availableCount.ToString()
        lblTotal.Text = TOTAL_PARKING_SLOTS.ToString()
        lblUnavailable.Text = occupiedCount.ToString()
    End Sub

    ' =========================================================================
    '  *** BINAGO ANG BUONG LOGIC DITO PARA SA 12:00 PM RULE ***
    ' =========================================================================
    Private Sub CheckForOverstayingVehicles()
        ' --- Gumawa ng query para hanapin ang mga overstaying na sasakyan ---
        ' Kukunin nito ang lahat ng sasakyan na:
        '   a. Hindi pa naka-Time Out (parkingTimeOut IS NULL)
        '   b. Hindi pa nag-generate ng alert (isAlertGenerated = 0)
        '   c. Pumasok bago ang araw na ito (CAST(parkingTimeIn AS DATE) < CAST(GETDATE() AS DATE))
        '   Ang logic na ito ay sapat na para sa 12:00 AM rule. Kapag lumagpas na ng hatinggabi,
        '   ang "kahapon" ay magiging "bago ang araw na ito".
        Dim query As String = "SELECT parkingID, vehicleRegistrationNumber, SlotNumber FROM ParkingHistory " &
                              "WHERE parkingTimeOut IS NULL AND isAlertGenerated = 0 AND CAST(parkingTimeIn AS DATE) < CAST(GETDATE() AS DATE)"

        Dim newAlertsFound As Boolean = False
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        newAlertsFound = True
                        Dim parkingID As Integer = Convert.ToInt32(reader("parkingID"))
                        Dim plateNumber As String = reader("vehicleRegistrationNumber").ToString()
                        Dim slotNumber As String = reader("SlotNumber").ToString()

                        ' *** INAYOS ANG ALERT MESSAGE PARA TAMA SA 12 AM RULE ***
                        Dim alertMessage As String = String.Format("ALERT: Vehicle [{0}] in Slot [{1}] is overdue from the previous day.", plateNumber, slotNumber)

                        ' Ipakita yung custom notifier form
                        Dim notifier As New frmAlertNotifier(alertMessage)
                        notifier.Show()

                        ' I-log sa database at i-update ang flag
                        LogAlertAndFlagVehicle(parkingID, alertMessage)
                    End While
                End Using
            End Using
        End Using

        ' I-refresh ang alert panel kung may bago
        If newAlertsFound Then
            LoadAlerts()
        End If
    End Sub

    ' Ito ang naglalagay ng text sa "Alert Notification" panel (FlowLayoutPanel1)
    Private Sub LoadAlerts()
        FlowLayoutPanel1.Controls.Clear()
        Dim query As String = "SELECT TOP 100 AlertMessage, AlertTime FROM AlertHistory ORDER BY AlertTime DESC"
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim alertLabel As New Label()
                        Dim alertTime As DateTime = Convert.ToDateTime(reader("AlertTime"))
                        Dim alertMessage As String = reader("AlertMessage").ToString()
                        alertLabel.Text = alertTime.ToString("yyyy-MM-dd HH:mm") & " - " & alertMessage
                        alertLabel.Font = New Font("Segoe UI", 9, FontStyle.Bold)
                        alertLabel.ForeColor = Color.DarkRed
                        alertLabel.AutoSize = True
                        alertLabel.Margin = New Padding(5)
                        alertLabel.MaximumSize = New Size(FlowLayoutPanel1.Width - 20, 0)
                        FlowLayoutPanel1.Controls.Add(alertLabel)
                    End While
                End Using
            End Using
        End Using
    End Sub

    ' =========================================================================
    '  ITO ANG NAGLALAGAY NG DATA SA "ACTION HISTORY" (flpActionHistory)
    ' =========================================================================
Public Sub LoadActionHistory()
        ' clear old items
        ListBox1.Items.Clear()

        ' *** KINOREK ANG COLUMN NAME MULA "Slot" AY GINAWANG "SlotNumber" ***
        Dim query As String = "SELECT TOP 100 * FROM (" &
                              "    SELECT 'IN' as ActionType, parkingTimeIn as ActionTime, vehicleRegistrationNumber, SlotNumber FROM ParkingHistory WHERE parkingTimeIn IS NOT NULL " &
                              "    UNION ALL " &
                              "    SELECT 'OUT' as ActionType, parkingTimeOut as ActionTime, vehicleRegistrationNumber, SlotNumber FROM ParkingHistory WHERE parkingTimeOut IS NOT NULL " &
                              ") AS History WHERE ActionTime IS NOT NULL ORDER BY ActionTime DESC"

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    While reader.Read()
                        Dim actionType As String = reader("ActionType").ToString()
                        Dim actionTime As DateTime = Convert.ToDateTime(reader("ActionTime"))
                        Dim regNum As String = reader("vehicleRegistrationNumber").ToString()
                        Dim slot As String = If(reader("SlotNumber") Is DBNull.Value, "",
                                                " (Slot " & reader("SlotNumber").ToString() & ")").ToString()

                        Dim line As String = String.Format("{0:HH:mm} - {1}: {2}{3}",
                                                           actionTime, actionType, regNum, slot)

                        ' add to ListBox
                        ListBox1.Items.Add(line)
                    End While
                End Using
            End Using
        End Using
    End Sub


    ' --- WALANG PAGBABAGO SA MGA SUMUSUNOD NA CODE ---

    Private Sub LogAlertAndFlagVehicle(ByVal parkingID As Integer, ByVal alertMessage As String)
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Dim queryInsert As String = "INSERT INTO AlertHistory (parkingID, AlertMessage, AlertTime) VALUES (@parkingID, @message, @time)"
            Using cmdInsert As New SqlCommand(queryInsert, conn)
                cmdInsert.Parameters.AddWithValue("@parkingID", parkingID)
                cmdInsert.Parameters.AddWithValue("@message", alertMessage)
                cmdInsert.Parameters.AddWithValue("@time", DateTime.Now)
                cmdInsert.ExecuteNonQuery()
            End Using
            Dim queryUpdate As String = "UPDATE ParkingHistory SET isAlertGenerated = 1 WHERE parkingID = @parkingID"
            Using cmdUpdate As New SqlCommand(queryUpdate, conn)
                cmdUpdate.Parameters.AddWithValue("@parkingID", parkingID)
                cmdUpdate.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Dashboard_FormClosed(ByVal sender As Object, ByVal e As FormClosedEventArgs) Handles Me.FormClosed
        Application.Exit()
    End Sub





    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Main.Show()
        Me.Hide()
    End Sub

    Public Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UpdateDashboard()
    End Sub

    Sub ReloadForm()
        ' close the current instance
        Me.Close()

        ' create a new instance and show it again
        Dim newForm As New Dashboard()
        newForm.Show()
    End Sub

    Private Sub lblUnavailable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblUnavailable.Click

    End Sub

    Private Sub flpActionHIstory_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles flpActionHIstory.Paint

    End Sub

    Private Sub btnRefresh_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        UpdateDashboard()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub
End Class

