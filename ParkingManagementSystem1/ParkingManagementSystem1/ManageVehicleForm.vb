Imports System.Data.SQLite

Public Class ManageVehicleForm
    Private Sub ManageVehicleForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Try
            ' Path of the database file
            Dim dbPath As String = "Data Source=TestDatabase.db;Version=3;"

            ' Create a connection
            Using conn As New SQLiteConnection(dbPath)
                conn.Open()
                MessageBox.Show("SQLite connection successful!", "Connection Test", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Create a simple table if it doesn't exist
                Dim createTableQuery As String = "CREATE TABLE IF NOT EXISTS TestTable (ID INTEGER PRIMARY KEY AUTOINCREMENT, Name TEXT)"
                Using cmd As New SQLiteCommand(createTableQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Insert sample data
                Dim insertQuery As String = "INSERT INTO TestTable (Name) VALUES ('Hello SQLite!')"
                Using cmd As New SQLiteCommand(insertQuery, conn)
                    cmd.ExecuteNonQuery()
                End Using

                ' Read data
                Dim selectQuery As String = "SELECT * FROM TestTable"
                Using cmd As New SQLiteCommand(selectQuery, conn)
                    Using reader As SQLiteDataReader = cmd.ExecuteReader()
                        Dim result As String = "Data in TestTable:" & vbCrLf
                        While reader.Read()
                            result &= reader("ID").ToString() & " - " & reader("Name").ToString() & vbCrLf
                        End While
                        MessageBox.Show(result, "SQLite Data")
                    End Using
                End Using

                conn.Close()
            End Using

        Catch ex As Exception
            MessageBox.Show("SQLite test failed: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class