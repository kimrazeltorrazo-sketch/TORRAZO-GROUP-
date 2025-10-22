Public Class ReportFormvb

    ' A class-level variable to hold the report data for filtering.
    Private reportDataTable As DataTable

    Private Sub ReportForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Populate the search ComboBox with the columns we can search.
        cbSearch.Items.Add("PlateNumber")
        cbSearch.Items.Add("VehicleType")
        cbSearch.Items.Add("Status")
        cbSearch.SelectedIndex = 0 ' Default to searching by PlateNumber

        ' Load the report data into the grid.
        LoadReportData()
    End Sub

    ''' <summary>
    ''' Fetches the data from the database and populates the DataGridView.
    ''' </summary>
   Private Sub LoadReportData()
        Try
            reportDataTable = DatabaseHelper.GetAllVehicleEntriesReport()
            dgvReports.DataSource = reportDataTable

            ' (Your column formatting code here...)

            ' --- ADD THIS LINE ---
            DatabaseHelper.ApplyModernDGVDarkBlueStyle(dgvReports)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        ' This sub filters the grid as the user types in the search box.

        ' First, check if the data has been loaded. If not, exit to prevent a crash.
        If reportDataTable Is Nothing Then Return

        Try
            Dim searchColumn As String = cbSearch.SelectedItem.ToString()
            Dim filterText As String = txtSearch.Text

            If String.IsNullOrWhiteSpace(filterText) Then
                ' If the search box is empty, clear the filter to show all records.
                reportDataTable.DefaultView.RowFilter = ""
            Else
                ' Apply a filter to the data. The % are wildcards for "contains".
                ' The filterText is escaped to handle special characters like apostrophes.
                reportDataTable.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", searchColumn, filterText.Replace("'", "''"))
            End If
        Catch ex As Exception
            ' If there's an error in the filter (rare), just clear it.
            reportDataTable.DefaultView.RowFilter = ""
        End Try
    End Sub

    Private Sub cbSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSearch.SelectedIndexChanged
        ' When the user changes the search category (e.g., from PlateNumber to Status),
        ' we should re-apply the filter immediately. The easiest way is to just call
        ' the txtSearch_TextChanged event handler.
        txtSearch_TextChanged(sender, e)
    End Sub

    ' This can be left empty as no action is needed when a cell is clicked.
    Private Sub dgvReports_CellContentClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvReports.CellContentClick
    End Sub

End Class