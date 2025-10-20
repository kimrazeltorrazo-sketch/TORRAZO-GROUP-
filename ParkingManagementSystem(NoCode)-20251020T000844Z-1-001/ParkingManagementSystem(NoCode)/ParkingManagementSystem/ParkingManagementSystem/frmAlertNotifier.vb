Public Class frmAlertNotifier

    ' This custom constructor allows the Dashboard to send the message to this form.
    Public Sub New(ByVal message As String)
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Set the text of the label to the message we received.
        lblAlertMessage.Text = message
    End Sub

    Private Sub frmAlertNotifier_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' This code makes the alert pop up in the bottom-right corner of the screen.
        Dim screenWidth As Integer = Screen.PrimaryScreen.WorkingArea.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.WorkingArea.Height
        Me.Location = New Point(screenWidth - Me.Width, screenHeight - Me.Height)
    End Sub

    Private Sub btnClose_Click(ByVal sender As Object, ByVal e As EventArgs)

        ' Simply close this pop-up form.
        Me.Close()
    End Sub

End Class
