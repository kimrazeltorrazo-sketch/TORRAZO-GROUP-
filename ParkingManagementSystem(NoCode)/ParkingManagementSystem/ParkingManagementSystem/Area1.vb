Imports System.Data.SqlClient
Imports System.Drawing
Imports Guna.UI2.WinForms

Public Class Area1
    Private Sub Area1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        UpdateAllSlotStatuses()
    End Sub

    ' Ito ay hindi na kailangang baguhin. Tama na ito.
    Private Sub Slot_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSlot1.Click, btnSlot2.Click, btnSlot3.Click, btnSlot4.Click, btnSlot5.Click, btnSlot6.Click, btnSlot7.Click, btnSlot8.Click, btnSlot9.Click, btnSlot10.Click, btnSlot11.Click, btnSlot12.Click, btnSlot13.Click, btnSlot14.Click, btnSlot15.Click, btnSlot15.Click, btnSlot16.Click, btnSlot17.Click, btnSlot18.Click, btnSlot19.Click,
            btnSlot20.Click, btnSlot21.Click, btnSlot22.Click, btnSlot23.Click, btnSlot24.Click
        Dim clickedButton As Guna2Button = CType(sender, Guna2Button)



        If clickedButton.Tag IsNot Nothing AndAlso TypeOf clickedButton.Tag Is Integer Then
            Dim parkingID As Integer = CInt(clickedButton.Tag)
            Using exitModal As New ExitVehicleModal(parkingID)
                If exitModal.ShowDialog() = DialogResult.OK Then
                    UpdateAllSlotStatuses()
                End If
            End Using
        Else
            Dim slotDisplayName As String = clickedButton.Text
            Dim slotNumber As Integer = 0
            Try
                slotNumber = Integer.Parse(slotDisplayName.Replace("Slot ", ""))
            Catch ex As Exception
                MessageBox.Show("Button text is not in the correct 'Slot #' format.", "Button Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End Try

            Using enterModal As New EnterVehicleModal(slotNumber, slotDisplayName)
                If enterModal.ShowDialog() = DialogResult.OK Then
                    UpdateAllSlotStatuses()
                End If
            End Using
        End If
    End Sub

    ' Ito ang master function na nagbabasa ng database at nagse-set ng kulay.
    Public Sub UpdateAllSlotStatuses()
        Dim occupiedSlots As New Dictionary(Of Integer, Integer)
        Dim query As String = "SELECT parkingID, SlotNumber FROM ParkingHistory WHERE parkingTimeOut IS NULL"
        Try
            Using conn As SqlConnection = DBConnection.GetConnection()
                If conn Is Nothing Then Return
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            If Not reader.IsDBNull(reader.GetOrdinal("SlotNumber")) Then
                                occupiedSlots(Convert.ToInt32(reader("SlotNumber"))) = Convert.ToInt32(reader("parkingID"))
                            End If
                        End While
                    End Using
                End Using
            End Using

            ' =========================================================================
            '  ITO ANG PAGBABAGO AT SOLUSYON!
            '  Naghahanap na tayo ngayon sa loob ng 'area1panel.Controls'.
            ' =========================================================================
            ' I-loop ang lahat ng controls SA LOOB ng panel.
            For Each ctrl As Control In area1panel.Controls
                If TypeOf ctrl Is Guna2Button Then
                    Dim slotButton As Guna2Button = CType(ctrl, Guna2Button)
                    If slotButton.Text.StartsWith("Slot ") Then
                        Dim slotNumber As Integer = Integer.Parse(slotButton.Text.Replace("Slot ", ""))
                        If occupiedSlots.ContainsKey(slotNumber) Then
                            slotButton.FillColor = Color.IndianRed ' Occupied = YELLOW
                            slotButton.Tag = occupiedSlots(slotNumber)
                        Else
                            slotButton.FillColor = Color.MediumSeaGreen ' Available = GREEN
                            slotButton.Tag = Nothing
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("A critical error occurred while updating slot statuses." & vbCrLf & vbCrLf & "Error: " & ex.Message, "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub area1panel_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles area1panel.Paint

    End Sub

    Private Sub btnPress_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnBack.Click
        Dim frm As New Dashboard
        frm.UpdateDashboard()
        frm.LoadActionHistory()


        Me.Close()
    End Sub
    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click

    End Sub


End Class