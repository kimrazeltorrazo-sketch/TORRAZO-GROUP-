' Required for advanced currency formatting
Imports System.Globalization

Public Class CategoryForm

    ' A class-level variable to hold the data for searching and filtering.
    Private parkingDataTable As DataTable

    Private Sub CategoryForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        ' --- CORRECTED ORDER ---
        ' 1. First, add the items to the ComboBox.
        cbSearch.Items.Add("VehicleType")
        cbSearch.Items.Add("Status")

        ' 2. NOW, you can safely select the first item.
        cbSearch.SelectedIndex = 0

        ' Make the Parking Area ID look non-editable
        txtParkingAreaNumber.ReadOnly = True
        txtParkingAreaNumber.BackColor = SystemColors.Control

        ' Load data into both grids.
        LoadGridData()
        LoadDetailsGridData()

        ' Apply the modern style to both DataGridViews.
        DatabaseHelper.ApplyModernDGVDarkBlueStyle(dgvCategory)
        DatabaseHelper.ApplyModernDGVDarkBlueStyle(dgvDetails)

        ' Set the initial state of the form.
        ClearAndLockControls()
    End Sub

#Region "Core Data and Control Methods"

    Private Sub LoadGridData()
        Try
            parkingDataTable = DatabaseHelper.GetParkingAreas()
            dgvCategory.DataSource = parkingDataTable
            dgvCategory.Columns("ParkingAreaID").HeaderText = "Area ID"
            dgvCategory.Columns("ParkingCharge").DefaultCellStyle.Format = "c"
        Catch ex As Exception
            MessageBox.Show("Failed to load category data: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadDetailsGridData()
        Try
            dgvDetails.DataSource = DatabaseHelper.GetParkingChargeSummary()
            dgvDetails.Columns("VehicleType").HeaderText = "Vehicle Type"
            dgvDetails.Columns("AverageCharge").HeaderText = "Average Fee"
            dgvDetails.Columns("AverageCharge").DefaultCellStyle.Format = "c"
        Catch ex As Exception
            MessageBox.Show("Failed to load details summary: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ClearAndLockControls()
        txtParkingAreaNumber.Clear()
        txtVehicleType.Clear()
        txtVehicleLimit.Clear()
        txtParkingCharge.Clear()
        txtSearch.Clear()

        btnUpdate.Enabled = False
        btnDelete.Enabled = False
        btnDeactivate.Enabled = False
        btnDeactivate.Text = "Deactivate"
        btnSubmit.Enabled = True
        dgvCategory.ClearSelection()
    End Sub

#End Region

#Region "CRUD Button Events"
    Private Sub btnCancelEdit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancelEdit.Click
        ClearAndLockControls()
    End Sub

    Private Sub btnSubmit_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSubmit.Click
        If String.IsNullOrWhiteSpace(txtVehicleType.Text) OrElse String.IsNullOrWhiteSpace(txtVehicleLimit.Text) OrElse String.IsNullOrWhiteSpace(txtParkingCharge.Text) Then
            MessageBox.Show("Please fill in all fields.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim vehicleLimit As Integer
        Dim parkingCharge As Decimal
        If Not Integer.TryParse(txtVehicleLimit.Text, vehicleLimit) OrElse Not Decimal.TryParse(txtParkingCharge.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, parkingCharge) Then
            MessageBox.Show("Vehicle Limit must be a whole number and Parking Charge must be a valid number.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If DatabaseHelper.AddNewParkingArea(txtVehicleType.Text, vehicleLimit, parkingCharge, "Active") Then
                MessageBox.Show("New parking area added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGridData()
                LoadDetailsGridData()
                ClearAndLockControls()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnUpdate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnUpdate.Click
        If String.IsNullOrWhiteSpace(txtParkingAreaNumber.Text) Then
            MessageBox.Show("Please select a record from the list to update.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Dim parkingAreaID, vehicleLimit As Integer
        Dim parkingCharge As Decimal
        If Not Integer.TryParse(txtParkingAreaNumber.Text, parkingAreaID) OrElse Not Integer.TryParse(txtVehicleLimit.Text, vehicleLimit) OrElse Not Decimal.TryParse(txtParkingCharge.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, parkingCharge) Then
            MessageBox.Show("Please ensure all fields have valid data.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            If DatabaseHelper.UpdateParkingArea(parkingAreaID, txtVehicleType.Text, vehicleLimit, parkingCharge) Then
                MessageBox.Show("Parking area updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGridData()
                LoadDetailsGridData()
                ClearAndLockControls()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDeactivate_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDeactivate.Click
        If String.IsNullOrWhiteSpace(txtParkingAreaNumber.Text) Then Return

        Dim parkingAreaID As Integer = Integer.Parse(txtParkingAreaNumber.Text)
        Dim newStatus As String
        Dim confirmationMessage As String
        Dim successMessage As String

        If btnDeactivate.Text = "Activate" Then
            newStatus = "Active"
            confirmationMessage = "Are you sure you want to activate this parking area?"
            successMessage = "Parking area has been activated."
        Else
            newStatus = "Inactive"
            confirmationMessage = "Are you sure you want to deactivate this parking area?"
            successMessage = "Parking area has been deactivated."
        End If

        If MessageBox.Show(confirmationMessage, "Confirm Status Change", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        Try
            If DatabaseHelper.UpdateParkingAreaStatus(parkingAreaID, newStatus) Then
                MessageBox.Show(successMessage, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGridData()
                LoadDetailsGridData()
                ClearAndLockControls()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrWhiteSpace(txtParkingAreaNumber.Text) Then Return
        If MessageBox.Show("Are you sure you want to permanently delete this record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then Return
        Dim parkingAreaID As Integer = Integer.Parse(txtParkingAreaNumber.Text)

        Try
            If DatabaseHelper.DeleteParkingArea(parkingAreaID) Then
                MessageBox.Show("Parking area deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadGridData()
                LoadDetailsGridData()
                ClearAndLockControls()
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred: " & ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region

#Region "Grid, Search, and Formatting Events"

    Private Sub dgvCategory_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs) Handles dgvCategory.SelectionChanged
        If dgvCategory.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvCategory.SelectedRows(0)
            txtParkingAreaNumber.Text = selectedRow.Cells("ParkingAreaID").Value.ToString()
            txtVehicleType.Text = selectedRow.Cells("VehicleType").Value.ToString()
            txtVehicleLimit.Text = selectedRow.Cells("VehicleLimit").Value.ToString()

            Dim cellValue = selectedRow.Cells("ParkingCharge").Value
            If IsDBNull(cellValue) OrElse cellValue Is Nothing Then
                txtParkingCharge.Text = ""
            Else
                Dim charge As Decimal = CDec(cellValue)
                txtParkingCharge.Text = charge.ToString("C")
            End If

            Dim status As String = selectedRow.Cells("Status").Value.ToString()
            If status = "Active" Then
                btnDeactivate.Text = "Deactivate"
            Else
                btnDeactivate.Text = "Activate"
            End If

            btnUpdate.Enabled = True
            btnDelete.Enabled = True
            btnDeactivate.Enabled = True
            btnSubmit.Enabled = False
        End If
    End Sub

    Private Sub txtSearch_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtSearch.TextChanged
        If parkingDataTable Is Nothing Then
            Return
        End If
        Try
            Dim searchColumn As String = cbSearch.SelectedItem.ToString()
            Dim filterText As String = txtSearch.Text
            If String.IsNullOrWhiteSpace(filterText) Then
                parkingDataTable.DefaultView.RowFilter = ""
            Else
                parkingDataTable.DefaultView.RowFilter = String.Format("[{0}] LIKE '%{1}%'", searchColumn, filterText.Replace("'", "''"))
            End If
        Catch ex As Exception
            parkingDataTable.DefaultView.RowFilter = ""
        End Try
    End Sub

    Private Sub CategoryForm_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Click
        ClearAndLockControls()
    End Sub

    Private Sub txtParkingCharge_Enter(ByVal sender As Object, ByVal e As EventArgs) Handles txtParkingCharge.Enter
        If Decimal.TryParse(txtParkingCharge.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, Nothing) Then
            txtParkingCharge.Text = Decimal.Parse(txtParkingCharge.Text, NumberStyles.Currency, CultureInfo.CurrentCulture).ToString()
        End If
    End Sub

    Private Sub txtParkingCharge_Leave(ByVal sender As Object, ByVal e As EventArgs) Handles txtParkingCharge.Leave
        Dim charge As Decimal
        If Decimal.TryParse(txtParkingCharge.Text, charge) Then
            txtParkingCharge.Text = charge.ToString("C")
        Else
            txtParkingCharge.Clear()
        End If
    End Sub
#End Region

#Region "Empty Event Handlers"
    Private Sub txtParkingAreaNumber_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParkingAreaNumber.TextChanged
    End Sub
    Private Sub txtVehicleLimit_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVehicleLimit.TextChanged
    End Sub
    Private Sub txtVehicleType_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtVehicleType.TextChanged
    End Sub
    Private Sub txtParkingCharge_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtParkingCharge.TextChanged
    End Sub
    Private Sub dgvDetails_CellContentClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvDetails.CellContentClick
    End Sub
    Private Sub dgvCategory_CellContentClick(ByVal sender As Object, ByVal e As Windows.Forms.DataGridViewCellEventArgs) Handles dgvCategory.CellContentClick
    End Sub
    Private Sub cbSearch_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbSearch.SelectedIndexChanged
        txtSearch_TextChanged(sender, e)
    End Sub
#End Region

End Class