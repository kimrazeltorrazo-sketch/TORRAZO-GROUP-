Imports System.Globalization

Public Class VehicleEntryForm

    Private parkedVehiclesDataTable As DataTable

    Private Sub VehicleEntryForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' Load vehicle types into the first ComboBox
        cbVehicleType.DataSource = DatabaseHelper.GetDistinctVehicleTypes()
        ' Setup search options
        cbSearch.Items.Add("PlateNumber")
        cbSearch.Items.Add("VehicleType")
        cbSearch.SelectedIndex = 0
        ' Load both grids and clear controls
        RefreshDataAndControls()
    End Sub

#Region "Core Data and Control Methods"

    Private Sub RefreshDataAndControls()
        ' This is a central method to update all data on the form.
        LoadParkingLimitationsGrid()
        LoadReceiptsGrid()
        ClearInputControls()
    End Sub

    Private Sub LoadParkingLimitationsGrid()
        Try
            dgvParkingLimitations.DataSource = DatabaseHelper.GetParkingLimitationSummary()
            dgvParkingLimitations.Columns("ParkingAreaID").HeaderText = "Area ID"
            dgvParkingLimitations.Columns("VehicleType").HeaderText = "Vehicle Type"
            dgvParkingLimitations.Columns("VehicleLimit").HeaderText = "Capacity"
            dgvParkingLimitations.Columns("CurrentVehicles").HeaderText = "Current"

            ' --- APPLY MODERN STYLE ---
            DatabaseHelper.ApplyModernDGVDarkBlueStyle(dgvParkingLimitations)

        Catch ex As Exception
            MessageBox.Show("Failed to load parking limitations: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadReceiptsGrid()
        Try
            parkedVehiclesDataTable = DatabaseHelper.GetParkedVehicles()
            dgvReceipts.DataSource = parkedVehiclesDataTable
            dgvReceipts.Columns("VehicleID").Visible = False ' Hide the ID column

            ' --- ADD THIS LINE TO DISPLAY THE STATUS COLUMN ---
            dgvReceipts.Columns("Status").HeaderText = "Status"

            ' Apply the modern style
            DatabaseHelper.ApplyModernDGVDarkBlueStyle(dgvReceipts)

        Catch ex As Exception
            MessageBox.Show("Failed to load parked vehicles: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearInputControls()
        txtRegistrationPlate.Clear()
        cbVehicleType.SelectedIndex = -1
        cbParkingArea.DataSource = Nothing
        txtParkingCharge.Clear()
    End Sub

#End Region

#Region "Input Control Events"

    Private Sub cbVehicleType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbVehicleType.SelectedIndexChanged
        If cbVehicleType.SelectedItem IsNot Nothing Then
            Dim selectedType As String = cbVehicleType.SelectedItem.ToString()
            ' Get available parking spots for the selected vehicle type
            Dim availableAreas As DataTable = DatabaseHelper.GetAvailableParkingAreas(selectedType)

            If availableAreas.Rows.Count > 0 Then
                ' Populate the Parking Area ComboBox
                cbParkingArea.DisplayMember = "ParkingAreaID"
                cbParkingArea.ValueMember = "ParkingCharge" ' Store the charge in the value
                cbParkingArea.DataSource = availableAreas
            Else
                ' No spots available
                cbParkingArea.DataSource = Nothing
                cbParkingArea.Items.Clear()
                cbParkingArea.Text = "No Spots Available"
                txtParkingCharge.Clear()
            End If
        End If
    End Sub

    Private Sub cbParkingArea_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbParkingArea.SelectedIndexChanged
        If cbParkingArea.SelectedValue IsNot Nothing AndAlso IsNumeric(cbParkingArea.SelectedValue) Then
            ' Update the charge textbox when a parking area is selected
            Dim charge As Decimal = CDec(cbParkingArea.SelectedValue)
            txtParkingCharge.Text = charge.ToString("C")
        End If
    End Sub

#End Region

#Region "Main Button Events"

    Private Sub btnAddVehicle_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddVehicle.Click
        ' --- VALIDATE INPUTS ---
        If String.IsNullOrWhiteSpace(txtRegistrationPlate.Text) OrElse cbVehicleType.SelectedItem Is Nothing OrElse cbParkingArea.SelectedItem Is Nothing Then
            MessageBox.Show("Please provide a plate number and select a vehicle type and parking area.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- PREPARE DATA ---
        Dim plateNumber As String = txtRegistrationPlate.Text
        Dim vehicleType As String = cbVehicleType.SelectedItem.ToString()
        Dim parkingAreaID As Integer = CInt(CType(cbParkingArea.SelectedItem, DataRowView)("ParkingAreaID"))
        ' Generate a unique ticket serial number
        Dim ticketSerial As String = "TICKET-" & DateTime.Now.ToString("yyyyMMddHHmmss")

        ' --- ADD VEHICLE TO DATABASE ---
        Try
            If DatabaseHelper.AddNewVehicleEntry(plateNumber, vehicleType, parkingAreaID, ticketSerial) Then
                MessageBox.Show("Vehicle added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataAndControls() ' Refresh everything
            Else
                MessageBox.Show("Failed to add vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDone_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDone.Click
        ' --- VALIDATE SELECTION ---
        If dgvReceipts.SelectedRows.Count = 0 Then
            MessageBox.Show("Please select a vehicle from the list to mark as done.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' --- GET VEHICLE ID AND MARK AS EXITED ---
        Dim selectedRow As DataGridViewRow = dgvReceipts.SelectedRows(0)
        Dim vehicleID As Integer = CInt(selectedRow.Cells("VehicleID").Value)

        Try
            If DatabaseHelper.MarkVehicleAsExited(vehicleID) Then
                MessageBox.Show("Vehicle marked as exited.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                RefreshDataAndControls() ' Refresh everything
            Else
                MessageBox.Show("Failed to update vehicle status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#End Region

#Region "Search and Empty Handlers"

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        If parkedVehiclesDataTable Is Nothing Then Return
        Try
            Dim searchColumn As String = cbSearch.SelectedItem.ToString()
            Dim filterText As String = txtSearch.Text
            If String.IsNullOrWhiteSpace(filterText) Then
                parkedVehiclesDataTable.DefaultView.RowFilter = ""
            Else
                parkedVehiclesDataTable.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", searchColumn, filterText.Replace("'", "''"))
            End If
        Catch ex As Exception
            parkedVehiclesDataTable.DefaultView.RowFilter = ""
        End Try
    End Sub

    Private Sub cbSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSearch.SelectedIndexChanged
        txtSearch_TextChanged(sender, e)
    End Sub

    '--- These handlers can be left empty ---
    Private Sub txtRegistrationPlate_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtRegistrationPlate.TextChanged
    End Sub
    Private Sub txtParkingCharge_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParkingCharge.TextChanged
    End Sub
    Private Sub dgvParkingLimitations_CellContentClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvParkingLimitations.CellContentClick
    End Sub
    Private Sub dgvReceipts_CellContentClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvReceipts.CellContentClick
    End Sub

#End Region

End Class