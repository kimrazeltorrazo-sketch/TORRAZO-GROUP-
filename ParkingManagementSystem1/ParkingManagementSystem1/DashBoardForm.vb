Public Class DashBoardForm

    Private Sub DashBoardForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load the data as soon as the form appears.
        LoadDashboardData()
    End Sub

    ''' <summary>
    ''' This is the main method that fetches all data and updates the labels.
    ''' </summary>
    Private Sub LoadDashboardData()
        Try
            ' Call the highly efficient summary function from the database helper.
            Dim summaryData As DataRow = DatabaseHelper.GetDashboardSummary()

            ' --- Extract each value from the DataRow ---
            Dim parked As Integer = CInt(summaryData("VehiclesParked"))
            Dim departed As Integer = CInt(summaryData("VehiclesDeparted"))
            Dim categories As Integer = CInt(summaryData("ActiveCategories"))
            Dim earnings As Decimal = CDec(summaryData("TotalEarnings"))
            Dim totalRecords As Integer = CInt(summaryData("TotalVehicleRecords"))
            Dim totalCapacity As Integer = CInt(summaryData("TotalCapacity"))

            ' Calculate available slots
            Dim availableSlots As Integer = totalCapacity - parked
            ' Ensure it doesn't show a negative number if something is wrong
            If availableSlots < 0 Then availableSlots = 0

            ' --- Update all the labels on the form ---
            lblVehiclesParked.Text = parked.ToString()
            lblDepartedVehicles.Text = departed.ToString()
            lblAvailableCategory.Text = categories.ToString()
            lblTotalEarning.Text = earnings.ToString("C") ' "C" for currency format
            lblTotalRecords.Text = totalRecords.ToString()
            lblAvailableSlots.Text = availableSlots.ToString()

        Catch ex As Exception
            MessageBox.Show("Failed to load dashboard data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



#Region "Empty Label Click Events"
    ' These event handlers are not typically used for actions, so they can be left empty.
    ' Their purpose is simply to hold the displayed numbers.
    Private Sub lblVehiclesParked_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblVehiclesParked.Click
    End Sub

    Private Sub lblDepartedVehicles_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblDepartedVehicles.Click
    End Sub

    Private Sub lblAvailableCategory_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblAvailableCategory.Click
    End Sub

    Private Sub lblTotalEarning_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTotalEarning.Click
    End Sub

    Private Sub lblTotalRecords_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblTotalRecords.Click
    End Sub

    Private Sub lblAvailableSlots_Click(ByVal sender As Object, ByVal e As EventArgs) Handles lblAvailableSlots.Click
    End Sub
#End Region

End Class