Public Class AccountSettingsvb

    Private Sub AccountSettingsvb_Load(ByVal sender As Object, ByVal e As EventArgs)
        ' Check if a user is actually logged in before allowing any actions.
        If DatabaseHelper.CurrentUserID = 0 Then
            MessageBox.Show("No user is logged in. Please log in again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Disable all controls if no user is logged in.
            For Each ctrl As Control In Me.Controls
                ctrl.Enabled = False
            Next
        End If
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        ' --- 1. VALIDATE ALL INPUTS ---
        If String.IsNullOrWhiteSpace(txtCurrentPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtNewPassword.Text) OrElse
           String.IsNullOrWhiteSpace(txtConfirmNewPassword.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If txtNewPassword.Text <> txtConfirmNewPassword.Text Then
            MessageBox.Show("The new passwords do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' --- 2. ATTEMPT TO UPDATE THE PASSWORD IN THE DATABASE ---
        Try
            ' Call the database helper function, which requires the current password for security.
            If DatabaseHelper.UpdateUserPassword(DatabaseHelper.CurrentUserID, txtCurrentPassword.Text, txtNewPassword.Text) Then
                MessageBox.Show("Password updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Clear all textboxes after a successful update.
                txtCurrentPassword.Clear()
                txtNewPassword.Clear()
                txtConfirmNewPassword.Clear()
            Else
                ' This happens if the UpdateUserPassword function returns False, meaning the current password was wrong.
                MessageBox.Show("The 'Current Password' you entered is incorrect.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating the password: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' --- These TextChanged events can be left empty as no real-time logic is needed ---
    Private Sub txtCurrentPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtCurrentPassword.TextChanged
        ' This event was missing its Handles clause, it has been added.
    End Sub

    Private Sub txtNewPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNewPassword.TextChanged
        ' No action needed here.
    End Sub

    Private Sub txtConfirmNewPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtConfirmNewPassword.TextChanged
        ' No action needed here.
    End Sub

End Class