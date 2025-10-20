Imports System.Data.SqlClient

Public Class Login



    ' This subroutine checks if the UserInformation table is empty.
    Private Sub CheckForInitialSetup()
        Dim userCount As Integer = 0
        Dim query As String = "SELECT COUNT(*) FROM UserInformation"

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then
                Application.Exit()
                Return
            End If

            Using cmd As New SqlCommand(query, conn)
                userCount = CInt(cmd.ExecuteScalar())
            End Using
        End Using

        If userCount = 0 Then
            Me.Hide()
            Dim setupForm As New InitialSetup()
            Dim result As DialogResult = setupForm.ShowDialog()

            If result = DialogResult.OK Then
                Me.Show()
            Else
                Application.Exit()
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogin.Click
        ' 1. Validate input
        If String.IsNullOrWhiteSpace(txtAccountID.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) Then
            MessageBox.Show("Please enter both Account ID and Password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' 2. Prepare to verify credentials
        Dim query As String = "SELECT COUNT(*) FROM UserInformation WHERE username = @username AND password = @password"
        Dim loginSuccessful As Boolean = False
        Dim hashedPassword As String = HashPassword(txtPassword.Text)

        Using conn As SqlConnection = DBConnection.GetConnection()
            If conn Is Nothing Then Return

            Using cmd As New SqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@username", txtAccountID.Text.Trim())
                cmd.Parameters.AddWithValue("@password", hashedPassword)

                Try
                    Dim result As Integer = CInt(cmd.ExecuteScalar())
                    If result = 1 Then
                        loginSuccessful = True
                    End If
                Catch ex As Exception
                    MessageBox.Show("An error occurred during login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End Try
            End Using
        End Using

        ' 3. Handle the login result
        If loginSuccessful Then
            MessageBox.Show("Login successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim mainForm As New Main()
            mainForm.Show()
            Me.Hide()

        Else
            ' First, inform the user why the login failed.
            MessageBox.Show("Invalid Account ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' Then, reset the UI for another attempt.
            txtPassword.Clear()  ' Clear the incorrect password from the textbox.
            txtPassword.Focus()  ' Place the cursor back in the password field for convenience.
        End If
    End Sub

    ' This is the event handler for your "Forgot Password" button.
    Private Sub btnForgotPassword_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnForgotPassword.Click
        ' Create and show the password recovery form.
        Dim forgotPassForm As New ForgotPassword()
        forgotPassForm.ShowDialog()
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel2.Paint

    End Sub
    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class
