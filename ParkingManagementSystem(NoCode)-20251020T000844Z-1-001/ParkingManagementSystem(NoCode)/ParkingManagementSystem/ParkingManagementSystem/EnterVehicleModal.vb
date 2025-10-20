Imports System.Data.SqlClient
Imports QRCoder
Imports System.Drawing

Imports ZXing
Imports System.IO

Public Class EnterVehicleModal
    Private filledFromAttach As Boolean = False


    Private ReadOnly _slotNumber As Integer
    Private ReadOnly _slotDisplayName As String


    Public Sub New(ByVal slotNumber As Integer, ByVal slotDisplayName As String)
        InitializeComponent()
        _slotNumber = slotNumber
        _slotDisplayName = slotDisplayName
    End Sub

    Private Sub EnterVehicleModal_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        txtTimeIn.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
        txtTimeOut.Enabled = False
        Me.Text = "Enter Vehicle for " & _slotDisplayName
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

        Dim result As DialogResult = MessageBox.Show("Are you sure?",
                                                     "Confirm",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question)

        If result = DialogResult.No Then
            Return
        End If

        Dim query As String = "INSERT INTO ParkingHistory " &
                              "(parkingTimeIn, vehicleRegistrationNumber, vehicleMakerModel, vehicleBodyType, vehiclePrimaryColor, vehicleSecondaryColor, SlotNumber, contactNumber, isAlertGenerated) " &
                              "VALUES (@timeIn, @regNum, @model, @body, @color1, @color2, @slotNum, @contactNum, @isAlert)"

        Try
            Using conn As SqlConnection = DBConnection.GetConnection()
                If conn Is Nothing Then Return
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@timeIn", DateTime.Now)
                    cmd.Parameters.AddWithValue("@regNum", txtVehicleRegistrationNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@model", txtSecurityQuestion.Text.Trim())
                    cmd.Parameters.AddWithValue("@body", txtBodyType.Text.Trim())
                    cmd.Parameters.AddWithValue("@color1", txtPrimaryColor.Text.Trim())
                    cmd.Parameters.AddWithValue("@color2", txtSEcondaryColor.Text.Trim())
                    cmd.Parameters.AddWithValue("@slotNum", _slotNumber)
                    cmd.Parameters.AddWithValue("@contactNum", txtContactNum.Text.Trim())
                    cmd.Parameters.AddWithValue("@isAlert", 0) ' default = 0 (false)


                    cmd.ExecuteNonQuery()

                    Dim frm As New Dashboard
                    frm.UpdateDashboard()
                    frm.LoadActionHistory()

                    Me.DialogResult = DialogResult.OK
                    Me.Close()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("ERROR: Hindi na-save ang data." & vbCrLf & ex.Message,
                            "Database Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?",
                                                 "Confirm Cancel",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            Me.Close() ' isasara yung current form
        End If
    End Sub

    Private Sub Guna2Panel7_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel7.Paint

    End Sub

    Private Sub Guna2TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtContactNum.TextChanged

    End Sub


    Private Sub btnMaintenance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtBodyType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBodyType.TextChanged

    End Sub

    Private Sub txtContactNum_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtContactNum.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True ' block the key
        End If

    End Sub

    Private Sub btnAttach_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAttach.Click
        Using ofd As New OpenFileDialog()
            ofd.Title = "Select QR Code Image"
            ofd.Filter = "Image Files|*.png;*.jpg;*.jpeg;*.bmp"

            If ofd.ShowDialog() = DialogResult.OK Then
                Try
                    ' load the selected image
                    Dim qrImage As Bitmap = CType(Bitmap.FromFile(ofd.FileName), Bitmap)

                    ' decode the qr
                    Dim reader As New ZXing.BarcodeReader()
                    Dim result = reader.Decode(qrImage)

                    If result IsNot Nothing Then
                        filledFromAttach = True ' mark that form was filled from attach

                        ' the qr text we encoded earlier
                        Dim qrData As String = result.Text
                        Dim lines() As String = qrData.Split({vbCrLf}, StringSplitOptions.None)

                        ' now map back to textboxes
                        txtVehicleRegistrationNumber.Text = lines(0).Replace("Vehicle Reg#: ", "").Trim()
                        txtContactNum.Text = lines(1).Replace("Contact #: ", "").Trim()
                        txtSecurityQuestion.Text = lines(2).Replace("Security Q: ", "").Trim()
                        txtBodyType.Text = lines(3).Replace("Body Type: ", "").Trim()
                        txtPrimaryColor.Text = lines(4).Replace("Primary Color: ", "").Trim()
                        txtSEcondaryColor.Text = lines(5).Replace("Secondary Color: ", "").Trim()

                        ' ⚠️ do not show qr in picQR if using attach
                        picQR.Image = Nothing
                    Else
                        MessageBox.Show("No QR code detected in the image.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                Catch ex As Exception
                    MessageBox.Show("Error reading QR: " & ex.Message, "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End Using
    End Sub
End Class