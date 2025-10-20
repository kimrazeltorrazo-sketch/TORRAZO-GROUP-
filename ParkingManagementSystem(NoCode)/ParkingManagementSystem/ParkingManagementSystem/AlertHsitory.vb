Imports System.Data.SqlClient

Public Class AlertHistory

    Private ConnectionString As String = "SERVER=DESKTOP-UIBSC90\SQLEXPRESS;Database=ParkingManagementSystem;Trusted_Connection=True;"

    Private Sub AlertHistory_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        LoadAlertHistory()
    End Sub

    Private Sub LoadAlertHistory()
        Dim query As String =
            "SELECT parkingID, vehicleRegistrationNumber, SlotNumber, parkingTimeIn, parkingTimeOut " &
            "FROM ParkingHistory " &
            "WHERE parkingTimeOut IS NULL " &
            "AND parkingTimeIn < CAST(GETDATE() AS DATE)"

        Using con As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, con)
                Using adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    dgvAlertHistory.DataSource = Nothing ' clear old data
                    dgvAlertHistory.DataSource = dt
                End Using
            End Using
        End Using
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        Main.Show()
        Me.Hide()
    End Sub

    Private Sub dgvAlertHistory_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAlertHistory.CellContentClick

    End Sub
End Class
