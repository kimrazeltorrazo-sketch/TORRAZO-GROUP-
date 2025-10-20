Imports System.Data
Imports System.Data.SqlClient

Public Class ParkingHistory

    Private Sub ParkingHistory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadHistoryData()
    End Sub

    Private Sub LoadHistoryData()
        Dim query As String = "SELECT parkingID, SlotNumber, vehicleRegistrationNumber, vehicleMakerModel, vehicleBodyType, vehiclePrimaryColor, parkingTimeIn, parkingTimeOut " &
                              "FROM ParkingHistory " &
                              "ORDER BY parkingTimeIn DESC"

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                Try
                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)
                    dgvParkingHistory.DataSource = dt
                    StyleHistoryGrid()
                Catch ex As Exception
                    MessageBox.Show("Failed to load parking history." & vbCrLf & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End Using
        End Using
    End Sub

    Private Sub StyleHistoryGrid()
        If dgvParkingHistory.Columns.Count = 0 Then Return

        ' --- Set user-friendly column headers ---
        dgvParkingHistory.Columns("parkingID").HeaderText = "ID"
        dgvParkingHistory.Columns("SlotNumber").HeaderText = "Slot #"
        dgvParkingHistory.Columns("vehicleRegistrationNumber").HeaderText = "Registration #"
        dgvParkingHistory.Columns("vehicleMakerModel").HeaderText = "Make / Model"
        dgvParkingHistory.Columns("vehicleBodyType").HeaderText = "Body Type"
        dgvParkingHistory.Columns("vehiclePrimaryColor").HeaderText = "Color"
        dgvParkingHistory.Columns("parkingTimeIn").HeaderText = "Time In"
        dgvParkingHistory.Columns("parkingTimeOut").HeaderText = "Time Out"

        ' --- Format the date and time columns ---
        dgvParkingHistory.Columns("parkingTimeIn").DefaultCellStyle.Format = "yyyy-MM-dd hh:mm tt"
        dgvParkingHistory.Columns("parkingTimeOut").DefaultCellStyle.Format = "yyyy-MM-dd hh:mm tt"

        ' --- Set column sizing and selection behavior ---
        dgvParkingHistory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        dgvParkingHistory.Columns("vehicleMakerModel").AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvParkingHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvParkingHistory.MultiSelect = False
        dgvParkingHistory.ReadOnly = True

        ' --- THE INCORRECT "For Each" LOOP HAS BEEN REMOVED FROM HERE ---
    End Sub

    ' =========================================================================
    '  NEW CODE: THE CORRECT WAY TO FORMAT CELLS
    ' =========================================================================
    Private Sub dgvParkingHistory_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles dgvParkingHistory.CellFormatting
        ' This event runs for every cell before it is displayed.

        ' 1. Check if we are in the "parkingTimeOut" column.
        If dgvParkingHistory.Columns(e.ColumnIndex).Name = "parkingTimeOut" Then

            ' 2. Check if the underlying cell value is NULL (meaning the car is still parked).
            If e.Value Is Nothing OrElse e.Value Is DBNull.Value Then

                ' 3. Change the DISPLAYED value to our custom text.
                e.Value = "Still Parked"

                ' 4. Apply custom styling.
                e.CellStyle.ForeColor = Color.Green
                e.CellStyle.Font = New Font(dgvParkingHistory.Font, FontStyle.Bold)

                ' 5. Tell the grid we have handled the formatting for this cell.
                e.FormattingApplied = True
            End If
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRefresh.Click
        LoadHistoryData()
    End Sub








    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub dgvParkingHistory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvParkingHistory.CellContentClick

    End Sub
End Class