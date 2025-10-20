Imports System.Data.SqlClient

Public Class ExitVehicleModal
    Private ReadOnly _parkingID As Integer

    Public Sub New(ByVal parkingID As Integer)
        InitializeComponent()
        _parkingID = parkingID
    End Sub

    Private Sub ExitVehicleModal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT *, 'Slot ' + CAST(SlotNumber AS VARCHAR) as DisplaySlotName FROM ParkingHistory WHERE parkingID = @id"
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then
                Me.Close()
                Return
            End If
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@id", _parkingID)
                Using reader As SqlDataReader = cmd.ExecuteReader()
                    If reader.Read() Then
                        Me.Text = "Exit Vehicle from " & reader("DisplaySlotName").ToString()
                        txtTimeIn.Text = Convert.ToDateTime(reader("parkingTimeIn")).ToString("yyyy-MM-dd HH:mm:ss")
                        txtVehicleRegistrationNumber.Text = reader("vehicleRegistrationNumber").ToString()
                        txtSecurityQuestion.Text = reader("vehicleMakerModel").ToString()
                        txtBodyType.Text = reader("vehicleBodyType").ToString()
                        txtPrimaryColor.Text = reader("vehiclePrimaryColor").ToString()
                        txtSEcondaryColor.Text = reader("vehicleSecondaryColor").ToString()
                        txtContactNum.Text = reader("contactNumber").ToString()
                    End If
                End Using
            End Using
        End Using
        txtTimeOut.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        txtTimeIn.ReadOnly = True
        txtVehicleRegistrationNumber.ReadOnly = True
        txtSecurityQuestion.ReadOnly = True
        txtBodyType.ReadOnly = True
        txtPrimaryColor.ReadOnly = True
        txtSEcondaryColor.ReadOnly = True
        txtContactNum.ReadOnly = True
    End Sub


    Private Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click
        If String.IsNullOrWhiteSpace(txtVehicleRegistrationNumber.Text) OrElse
           String.IsNullOrWhiteSpace(txtContactNum.Text) OrElse
           String.IsNullOrWhiteSpace(txtSecurityQuestion.Text) OrElse
           String.IsNullOrWhiteSpace(txtBodyType.Text) OrElse
           String.IsNullOrWhiteSpace(txtPrimaryColor.Text) OrElse
           String.IsNullOrWhiteSpace(txtSEcondaryColor.Text) Then

            MessageBox.Show("Please fill in all required fields before submitting.",
                            "Validation Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Return
        End If

        Dim query As String = "UPDATE ParkingHistory SET parkingTimeOut = @timeOut WHERE parkingID = @id"

        Try
            Using conn As SqlConnection = DBConnection.GetConnection()
                ' Check the connection
                If conn Is Nothing Then
                    MessageBox.Show("ERROR: Could not connect to the database.", "Connection Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@timeOut", DateTime.Now)
                    cmd.Parameters.AddWithValue("@id", _parkingID)
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            ' Update the Dashboard if it is open
            Dim dash As Dashboard = TryCast(Application.OpenForms("Dashboard"), Dashboard)
            If dash IsNot Nothing Then
                dash.UpdateDashboard()
                dash.LoadActionHistory()
            End If

            Me.DialogResult = DialogResult.OK
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("ERROR: Hindi na-update ang data." & vbCrLf & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            ' IMPORTANT: If an error happens, we do NOT set DialogResult.OK.
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub btnCancel_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub txtContactNum_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContactNum.TextChanged

    End Sub

    Private Sub txtContactNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNum.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' block the key
        End If
    End Sub

End Class