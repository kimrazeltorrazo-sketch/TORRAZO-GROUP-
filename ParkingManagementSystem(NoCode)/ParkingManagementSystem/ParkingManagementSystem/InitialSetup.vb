Imports System.Data.SqlClient

Public Class InitialSetup

    Private Sub InitialSetup_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This code runs when the form opens.
        ' It populates the dropdown list.
        txtRole.Items.Add("Administrator")
        txtRole.Items.Add("Staff")
        txtRole.SelectedIndex = 0 ' Default the selection to "Administrator"
    End Sub

    ' THIS IS THE BUTTON THAT TRIGGERS THE RETURN TO LOGIN.VB
    Private Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click
        ' --- 1. Validation (Check if all textboxes are filled, etc.) ---
        If String.IsNullOrWhiteSpace(txtLastName.Text) OrElse String.IsNullOrWhiteSpace(txtFirstName.Text) OrElse String.IsNullOrWhiteSpace(txtAccountID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse String.IsNullOrWhiteSpace(txtSecurityQuestion.Text) OrElse String.IsNullOrWhiteSpace(txtSecurityAnswer.Text) Then
            MessageBox.Show("Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        If txtPassword.Text <> txtConfirmPassword.Text Then
            MessageBox.Show("Passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. Save Data to the Database ---
        Dim query As String = "INSERT INTO UserInformation (username, accountLastName, accountFirstName, accountMiddleName, accountRole, password, securityQuestion, securityAnswer) " &
                              "VALUES (@username, @lastName, @firstName, @middleName, @role, @password, @secQuestion, @secAnswer)"
        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtAccountID.Text.Trim())
                cmd.Parameters.AddWithValue("@lastName", txtLastName.Text.Trim())
                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text.Trim())
                cmd.Parameters.AddWithValue("@middleName", txtMiddleName.Text.Trim())
                cmd.Parameters.AddWithValue("@role", txtRole.SelectedItem.ToString())
                cmd.Parameters.AddWithValue("@password", HashPassword(txtPassword.Text))
                cmd.Parameters.AddWithValue("@secQuestion", txtSecurityQuestion.Text.Trim())
                cmd.Parameters.AddWithValue("@secAnswer", HashPassword(txtSecurityAnswer.Text))

                Try
                    cmd.ExecuteNonQuery()

                    ' --- 3. Show the Success Message Box ---
                    MessageBox.Show("Account created successfully. You can now proceed to login.", "Setup Complete", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' =========================================================================
                    '  THIS IS THE MAGIC THAT MAKES IT "GO TO LOGIN.VB"
                    ' =========================================================================
                    ' First, we set the form's result to OK. This is like raising a "Success" flag
                    ' that the waiting Login.vb form can see.
                    Login.Show()

                    ' Second, we close this InitialSetup form.
                    Me.Hide()


                    ' =========================================================================

                Catch ex As SqlException
                    ' (Error handling code...)
                    If ex.Number = 2627 Then
                        MessageBox.Show("This Account ID (username) is already taken.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Else
                        MessageBox.Show("Database error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End Try
            End Using
        End Using
    End Sub

    Private Sub btnForgotPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForgotPassword.Click
        ' During initial setup, this button acts as a "Cancel" button.
        If MessageBox.Show("Are you sure you want to cancel setup? The application will exit.", "Confirm Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub txtAccountID_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtAccountID.KeyPress
        ' Allow only numbers and backspace
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Guna2Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Guna2Button1.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub txtMiddleName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMiddleName.TextChanged

    End Sub
End Class