Imports System.Data.SqlClient

Public Class ForgotPassword

    ' This variable will store the username after the account is found,
    ' so we can use it to update the password later.
    Private currentUsername As String = ""

    Private Sub ForgotPassword_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' When the form opens, the user should only be able to find their account.
        ' We disable the other parts to guide them through the process.
        txtSecurityQuestion.Text = "" ' Start with an empty question
        txtSecurityQuestionAnswer.Enabled = False
        txtNewPassword.Enabled = False
        txtConfirmNewPassword.Enabled = False
        btnConfirm.Enabled = False
    End Sub

    ' This button finds the account and displays the security question

    ' This is your main "CONFIRM" button.
    Private Sub btnConfirm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click
        ' --- 1. Validation ---
        If String.IsNullOrWhiteSpace(txtSecurityQuestionAnswer.Text) OrElse String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            MessageBox.Show("Please provide a security answer and a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmNewPassword.Text Then

            Return
        End If

        ' --- 2. Verify Security Answer ---
        Dim queryVerify As String = "SELECT COUNT(*) FROM UserInformation WHERE username = @username AND securityAnswer = @secAnswer"
        Dim isAnswerCorrect As Boolean = False
        ' IMPORTANT: We must hash the user's answer to compare it with the hashed answer in the database.
        Dim hashedAnswer As String = HashPassword(txtSecurityQuestionAnswer.Text)

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(queryVerify, conn)
                cmd.Parameters.AddWithValue("@username", currentUsername)
                cmd.Parameters.AddWithValue("@secAnswer", hashedAnswer)
                If CInt(cmd.ExecuteScalar()) = 1 Then
                    isAnswerCorrect = True
                End If
            End Using
        End Using

        ' If the answer is wrong, stop the process.
        If Not isAnswerCorrect Then
            MessageBox.Show("The security answer is incorrect.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- 3. Update the Password (only if the answer was correct) ---
        Dim queryUpdate As String = "UPDATE UserInformation SET password = @newPassword WHERE username = @username"
        ' IMPORTANT: We must hash the new password before saving it.
        Dim newHashedPassword As String = HashPassword(txtNewPassword.Text)

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(queryUpdate, conn)
                cmd.Parameters.AddWithValue("@newPassword", newHashedPassword)
                cmd.Parameters.AddWithValue("@username", currentUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using


        Me.Close() ' Close the form and return to the login screen.
    End Sub


    Private Sub Guna2Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub

    Private Sub txtAccountID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAccountID.TextChanged
        If String.IsNullOrWhiteSpace(txtAccountID.Text) Then

            Return
        End If

        Dim query As String = "SELECT securityQuestion FROM UserInformation WHERE username = @username"
        Dim securityQuestion As String = ""

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtAccountID.Text.Trim())

                ' ExecuteScalar is perfect for getting a single value from the database.
                Dim result = cmd.ExecuteScalar()

                ' Check if a result was actually returned.
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    securityQuestion = result.ToString()
                End If
            End Using
        End Using

        ' If we found a security question, the account exists.
        If Not String.IsNullOrEmpty(securityQuestion) Then
            ' --- ACCOUNT FOUND ---
            MessageBox.Show("Account found. Please answer your security question to reset your password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Display the question from the database.
            txtSecurityQuestion.Text = securityQuestion
            currentUsername = txtAccountID.Text.Trim()

            ' Lock the "Find Account" section and enable the "Reset Password" section.
            txtAccountID.Enabled = False
            btnConfirm.Enabled = False
            txtSecurityQuestionAnswer.Enabled = True
            txtNewPassword.Enabled = True
            txtConfirmNewPassword.Enabled = True
            btnConfirm.Enabled = True
        Else
            ' --- ACCOUNT NOT FOUND ---

        End If
    End Sub

    ' This is your main "CONFIRM" button.
    Private Sub btnResetPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConfirm.Click
        ' --- 1. Validation ---
        If String.IsNullOrWhiteSpace(txtSecurityQuestionAnswer.Text) OrElse String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            MessageBox.Show("Please provide a security answer and a new password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmNewPassword.Text Then
            MessageBox.Show("The new passwords do not match.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- 2. Verify Security Answer ---
        Dim queryVerify As String = "SELECT COUNT(*) FROM UserInformation WHERE username = @username AND securityAnswer = @secAnswer"
        Dim isAnswerCorrect As Boolean = False
        ' IMPORTANT: We must hash the user's answer to compare it with the hashed answer in the database.
        Dim hashedAnswer As String = HashPassword(txtSecurityQuestionAnswer.Text)

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(queryVerify, conn)
                cmd.Parameters.AddWithValue("@username", currentUsername)
                cmd.Parameters.AddWithValue("@secAnswer", hashedAnswer)
                If CInt(cmd.ExecuteScalar()) = 1 Then
                    isAnswerCorrect = True
                End If
            End Using
        End Using

        ' If the answer is wrong, stop the process.
        If Not isAnswerCorrect Then

            Return
        End If

        ' --- 3. Update the Password (only if the answer was correct) ---
        Dim queryUpdate As String = "UPDATE UserInformation SET password = @newPassword WHERE username = @username"
        ' IMPORTANT: We must hash the new password before saving it.
        Dim newHashedPassword As String = HashPassword(txtNewPassword.Text)

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return
            Using cmd As New SqlCommand(queryUpdate, conn)
                cmd.Parameters.AddWithValue("@newPassword", newHashedPassword)
                cmd.Parameters.AddWithValue("@username", currentUsername)
                cmd.ExecuteNonQuery()
            End Using
        End Using

        MessageBox.Show("Your password has been reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close() ' Close the form and return to the login screen.
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub btnForgotPassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnForgotPassword.Click
        Login.Show()
        Me.Hide()
    End Sub
End Class