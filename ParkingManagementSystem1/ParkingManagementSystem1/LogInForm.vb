Public Class LogInForm

    Private Sub LogInForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This is the first thing that runs when the app starts.
        ' It will ensure the database is in the correct, writable AppData folder before any login is attempted.
        DatabaseHelper.CheckAndCreateDatabase()
    End Sub

    Private Sub txtUserID_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtUserID.TextChanged
        ' This can remain empty. Logic is in the button click.
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.TextChanged
        ' This can remain empty. Logic is in the button click.
    End Sub

    Private Sub btnLogIn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogIn.Click
        ' 1. Validate Input
        If String.IsNullOrWhiteSpace(txtUserID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both User ID and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim userID As Integer
        If Not Integer.TryParse(txtUserID.Text, userID) Then
            MessageBox.Show("User ID must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' 2. Attempt to Log In
        Try
            If DatabaseHelper.ValidateLogin(userID, txtPassword.Text) Then
                ' 3. On Success, Redirect to MainForm
                DatabaseHelper.CurrentUserID = userID ' Remember who just logged in

                MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

                Dim main As New MainForm()
                main.Show()
                Me.Hide()
            Else
                MessageBox.Show("Invalid User ID or Password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            ' Catch any potential database errors
            MessageBox.Show("A database error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnForgotPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForgotPassword.Click
        ' Open the Forgot Password form
        Dim forgotForm As New ForgotPassword()
        forgotForm.ShowDialog()
    End Sub

End Class