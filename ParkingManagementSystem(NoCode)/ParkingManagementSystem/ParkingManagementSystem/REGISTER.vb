Imports System.Data.SqlClient
Imports QRCoder
Imports System.Drawing

Public Class REGISTER

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtSecurityQuestion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSecurityQuestion.TextChanged

    End Sub
    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
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

        Dim query As String = "INSERT INTO customers " &
                              "(vehicleregistrationnumber, vehiclemakermodel, vehiclebodytype, vehicleprimarycolor, vehiclesecondarycolor, qr, contactnum) " &
                              "VALUES (@regNum, @model, @body, @color1, @color2, @qrImage, @num)"

        Try
            Using conn As SqlConnection = DBConnection.GetConnection()
                If conn Is Nothing Then Return
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@regNum", txtVehicleRegistrationNumber.Text.Trim())
                    cmd.Parameters.AddWithValue("@model", txtSecurityQuestion.Text.Trim())
                    cmd.Parameters.AddWithValue("@body", txtBodyType.Text.Trim())
                    cmd.Parameters.AddWithValue("@color1", txtPrimaryColor.Text.Trim())
                    cmd.Parameters.AddWithValue("@color2", txtSEcondaryColor.Text.Trim())
                    cmd.Parameters.AddWithValue("@num", txtContactNum.Text.Trim())

                    ' === QR Code Handling ===
                    If picQR IsNot Nothing AndAlso picQR.Image IsNot Nothing Then
                        Dim qrBytes As Byte()
                        Using ms As New IO.MemoryStream()
                            picQR.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
                            qrBytes = ms.ToArray()
                        End Using
                        cmd.Parameters.Add("@qrImage", SqlDbType.VarBinary).Value = qrBytes

                        ' === Save QR code as image to device ===
                        Dim sfd As New SaveFileDialog()
                        sfd.Filter = "PNG Image|*.png"
                        sfd.Title = "Save QR Code"
                        sfd.FileName = "QRCode_" & txtVehicleRegistrationNumber.Text & ".png"

                        If sfd.ShowDialog() = DialogResult.OK Then
                            picQR.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png)
                            MessageBox.Show("QR code saved successfully at: " & sfd.FileName,
                                            "Saved",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information)
                        End If
                    Else
                        ' Kung walang QR image, save NULL
                        cmd.Parameters.Add("@qrImage", SqlDbType.VarBinary).Value = DBNull.Value
                    End If
                    ' ==========================

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
    Private Sub AnyTextBox_TextChanged(ByVal sender As Object, ByVal e As EventArgs) _
    Handles txtVehicleRegistrationNumber.TextChanged,
            txtContactNum.TextChanged,
            txtSecurityQuestion.TextChanged,
            txtBodyType.TextChanged,
            txtPrimaryColor.TextChanged,
            txtSEcondaryColor.TextChanged

        ' Check if all fields have values
        If txtVehicleRegistrationNumber.Text.Trim() <> "" AndAlso
           txtContactNum.Text.Trim() <> "" AndAlso
           txtSecurityQuestion.Text.Trim() <> "" AndAlso
           txtBodyType.Text.Trim() <> "" AndAlso
           txtPrimaryColor.Text.Trim() <> "" AndAlso
           txtSecondaryColor.Text.Trim() <> "" Then

            ' Concatenate all data
            Dim qrData As String = "Vehicle Reg#: " & txtVehicleRegistrationNumber.Text & vbCrLf &
                                   "Contact #: " & txtContactNum.Text & vbCrLf &
                                   "Security Q: " & txtSecurityQuestion.Text & vbCrLf &
                                   "Body Type: " & txtBodyType.Text & vbCrLf &
                                   "Primary Color: " & txtPrimaryColor.Text & vbCrLf &
                                   "Secondary Color: " & txtSecondaryColor.Text

            ' Generate QR
            Dim qrGenerator As New QRCodeGenerator()
            Dim qrCodeData = qrGenerator.CreateQrCode(qrData, QRCodeGenerator.ECCLevel.Q)
            Dim qrCode As New QRCode(qrCodeData)
            picQR.Image = qrCode.GetGraphic(6)

        End If
    End Sub


End Class