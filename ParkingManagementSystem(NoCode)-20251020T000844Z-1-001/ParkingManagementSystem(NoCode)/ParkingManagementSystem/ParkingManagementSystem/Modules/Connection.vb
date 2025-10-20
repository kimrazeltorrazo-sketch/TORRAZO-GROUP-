Imports System.Data.SqlClient

Public Module DBConnection

    ' Define your connection string here. This is the ONLY place you'll need to change it.
    Private ReadOnly ConnectionString As String = "SERVER=DESKTOP-UIBSC90\SQLEXPRESS;Database=ParkingManagementSystem;Trusted_Connection=True;"

    ' This function will be called from your forms to get an open database connection.
    Public Function GetConnection() As SqlConnection
        Try
            Dim conn As New SqlConnection(ConnectionString)
            conn.Open()
            Return conn
        Catch ex As Exception
            ' If the connection fails, show an error and return Nothing.
            MessageBox.Show("Failed to connect to the database." & vbCrLf & "Error: " & ex.Message, "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    Function Connection() As SqlConnection
        Throw New NotImplementedException
    End Function

End Module