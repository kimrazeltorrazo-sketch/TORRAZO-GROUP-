Public Class MainForm

    ' This reusable sub will handle opening all your forms inside the panel.
    Private Sub OpenChildForm(ByVal childForm As Form)
        ' Clear any existing control from the panel.
        Me.panelMainContent.Controls.Clear()

        ' Set the child form's properties to be embedded.
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill

        ' Add the child form to the panel's controls.
        Me.panelMainContent.Controls.Add(childForm)
        childForm.Show()
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Open the Dashboard form by default when the main form loads.
        btnDashBoard.PerformClick()
    End Sub

    Private Sub btnDashBoard_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDashBoard.Click
        OpenChildForm(New DashBoardForm())
    End Sub

    Private Sub btnCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCategory.Click
        OpenChildForm(New CategoryForm())
    End Sub

    Private Sub btnVehicleEntry_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnVehicleEntry.Click
        OpenChildForm(New VehicleEntryForm())
    End Sub

    Private Sub btnManageVehicle_Click(ByVal sender As Object, ByVal e As EventArgs)
        OpenChildForm(New ManageVehicleForm())
    End Sub

    Private Sub btnReport_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReport.Click
        OpenChildForm(New ReportFormvb())
    End Sub

    Private Sub btnAccountSetting_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAccountSetting.Click
        OpenChildForm(New AccountSettingsvb())
    End Sub

    Private Sub btnLogOut_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLogOut.Click
        ' Ask the user for confirmation before logging out.
        DatabaseHelper.CurrentUserID = 0 ' Forget the user on logout

        If MessageBox.Show("Are you sure you want to log out?", "Confirm Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            ' --- THIS IS THE CORRECTED LINE ---
            ' The class name is LogInForm, even if the file is named Form1.vb
            Dim loginForm As New LogInForm()
            loginForm.Show()

            ' Close this MainForm.
            Me.Close()
        End If
    End Sub

    Private Sub panelMainContent_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles panelMainContent.Paint
        ' This sub can be left empty.
    End Sub
End Class