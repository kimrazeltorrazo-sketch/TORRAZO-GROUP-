Public Class ForgotPassword

    Private Sub ForgotPassword_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' --- 1. SET INITIAL STATE ON LOAD ---
        ' Only the UserID textbox is active initially.
        txtUserID.Enabled = True

        ' All other controls are disabled.
        txtSecurityQuestion.Enabled = False
        txtAnswer.Enabled = False
        txtNewPassword.Enabled = False
        txtConfirmNewPassword.Enabled = False
        btnResetPassword.Enabled = False
    End Sub

    Private Sub txtUserID_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtUserID.Leave
        ' --- 2. AUTOMATICALLY FETCH QUESTION WHEN USER LEAVES THE TEXTBOX ---
        If String.IsNullOrWhiteSpace(txtUserID.Text) Then Return

        Dim userID As Integer
        If Not Integer.TryParse(txtUserID.Text, userID) Then
            MessageBox.Show("User ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Dim question As String = DatabaseHelper.GetSecurityQuestion(userID)

            If Not String.IsNullOrEmpty(question) Then
                ' --- USER ID IS VALID ---
                txtSecurityQuestion.Text = question
                txtAnswer.Enabled = True
                txtAnswer.Focus() ' Move cursor to the answer box.
            Else
                ' --- USER ID IS INVALID ---
                MessageBox.Show("User ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Reset form to its initial locked state.
                txtSecurityQuestion.Clear()
                txtAnswer.Clear()
                txtAnswer.Enabled = False
                txtNewPassword.Enabled = False
                txtConfirmNewPassword.Enabled = False
                btnResetPassword.Enabled = False
            End If
        Catch ex As Exception
            MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtAnswer_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtAnswer.Leave
        ' --- 3. VERIFY THE ANSWER WHEN USER LEAVES THE TEXTBOX ---
        If String.IsNullOrWhiteSpace(txtAnswer.Text) Then Return

        Dim userID As Integer = Integer.Parse(txtUserID.Text)

        Try
            If DatabaseHelper.VerifySecurityAnswer(userID, txtAnswer.Text) Then
                ' --- ANSWER IS CORRECT ---
                MessageBox.Show("Answer verified.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtNewPassword.Enabled = True
                txtConfirmNewPassword.Enabled = True
                btnResetPassword.Enabled = True
                txtNewPassword.Focus() ' Move cursor to the new password field.
            Else
                ' --- ANSWER IS INCORRECT ---
                MessageBox.Show("Incorrect security answer. Please try again.", "Verification Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
                ' Lock the password fields and force user to re-enter answer.
                txtNewPassword.Enabled = False
                txtConfirmNewPassword.Enabled = False
                btnResetPassword.Enabled = False
                txtAnswer.SelectAll() ' Highlight the wrong answer.
                txtAnswer.Focus()
            End If
        Catch ex As Exception
            MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnResetPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnResetPassword.Click
        ' --- 4. FINALIZE THE PASSWORD RESET ---
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse String.IsNullOrWhiteSpace(txtConfirmNewPassword.Text) Then
            MessageBox.Show("Please enter and confirm your new password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmNewPassword.Text Then
            MessageBox.Show("The new passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim userID As Integer = Integer.Parse(txtUserID.Text)

        Try
            ' The UpdatePassword function provides a final layer of security by re-checking the answer.
            If DatabaseHelper.UpdatePassword(userID, txtAnswer.Text, txtNewPassword.Text) Then
                MessageBox.Show("Password has been reset successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                ' This case should be rare, but it's a good safeguard.
                MessageBox.Show("An unexpected error occurred while updating the password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    '--- These events no longer need custom logic and can be left empty ---
    Private Sub txtUserID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtUserID.TextChanged
    End Sub
    Private Sub txtSecurityQuestion_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSecurityQuestion.TextChanged
    End Sub
    Private Sub txtAnswer_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtAnswer.TextChanged
    End Sub
    Private Sub txtNewPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNewPassword.TextChanged
    End Sub
    Private Sub txtConfirmNewPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtConfirmNewPassword.TextChanged
    End Sub
End Class