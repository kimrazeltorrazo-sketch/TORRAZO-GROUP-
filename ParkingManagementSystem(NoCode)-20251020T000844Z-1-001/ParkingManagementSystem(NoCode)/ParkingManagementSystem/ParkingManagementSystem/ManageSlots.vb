Public Class ManageSlots

    ' A list to hold all your Area forms.
    Private _areaForms As New List(Of Form)()
    ' A variable to track which area is currently shown.
    Private _currentAreaIndex As Integer = 0

    Private Sub ManageSlots_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' --- IMPORTANT ---
        ' Add all your area forms to the list here.
        _areaForms.Add(New Area1())

        
        ' Show the first area by default.
        ShowCurrentArea()
    End Sub

    ' This subroutine displays the correct area form based on the current index.
    Private Sub ShowCurrentArea()
        ' Ensure we have a valid index.
        If _currentAreaIndex < 0 OrElse _currentAreaIndex >= _areaForms.Count Then Return

        ' Load the correct form from our list into the panel.
        LoadFormIntoPanel(_areaForms(_currentAreaIndex))

        ' Update the label to show the current area name.
        lblAreaName.Text = "Area " & (_currentAreaIndex + 1)

        ' --- Logic to enable/disable Previous and Next buttons ---
        ' Disable "Previous" if we are at the first area.
        btnPrevious.Enabled = (_currentAreaIndex > 0)
        ' Disable "Next" if we are at the last area.
        btnNext.Enabled = (_currentAreaIndex < _areaForms.Count - 1)
    End Sub

    Private Sub btnNext_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNext.Click
        ' Move to the next area if possible.
        If _currentAreaIndex < _areaForms.Count - 1 Then
            _currentAreaIndex += 1
            ShowCurrentArea()
        End If
    End Sub

    Private Sub btnPrevious_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnPrevious.Click
        ' Move to the previous area if possible.
        If _currentAreaIndex > 0 Then
            _currentAreaIndex -= 1
            ShowCurrentArea()
        End If
    End Sub

    ' --- Reusable Helper Method to load any Area form into THIS form's panel ---
    Private Sub LoadFormIntoPanel(ByVal formToLoad As Form)
        Me.panelAreaContent.Controls.Clear()
        formToLoad.TopLevel = False
        formToLoad.FormBorderStyle = FormBorderStyle.None
        formToLoad.Dock = DockStyle.Fill
        Me.panelAreaContent.Controls.Add(formToLoad)
        formToLoad.Show()
    End Sub

    Private Sub btnBack_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        ' NOTE: The best way to go "back" is to use the main menu on the Main form.
        ' For example, the user would click the "DASHBOARD" button on the sidebar.
        ' This keeps the navigation logic simple and centralized in the Main form.
        Main.Show()
        Me.Hide()
        Dashboard.UpdateDashboard()
    End Sub

    Private Sub Guna2Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub panelAreaContent_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles panelAreaContent.Paint

    End Sub
End Class






