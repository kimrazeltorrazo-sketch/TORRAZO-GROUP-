Public Class Main


    Private Sub btnManageSlots_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnManageSlots.Click
        ManageSlots.Show()
        Dashboard.Close()
    End Sub




    Private Sub btnParkingHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnParkingHistory.Click

        ParkingHistory.Show()
        Dashboard.Close()
    End Sub


    Private Sub btnAlertHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlertHistory.Click
        AlertHistory.Show()
        Dashboard.Close()
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogOut.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to log out?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' dito ilagay yung logout code mo
            Me.Hide()
            Dim login As New Login()
            login.Show()
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        lblTimeAndDate.Text = DateTime.Now.ToString("MMMM dd, yyyy - hh:mm:ss tt")

    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panelMainContent.Controls.Clear()

        Dim dash As New Dashboard()
        dash.TopLevel = False
        dash.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        dash.Dock = DockStyle.Fill

        panelMainContent.Controls.Add(dash)
        dash.Show()
    End Sub

    Private Sub btnDashboard_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDashboard.Click

    End Sub

    Private Sub btnCustomer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCustomer.Click
        REGISTER.Show()
        Dashboard.Close()
    End Sub
End Class