Imports System.Data.SQLite
Imports System.Drawing
Imports System.Windows.Forms

Public Module DatabaseHelper

    Public CurrentUserID As Integer = 0

    ' This connection string now dynamically points to the user's AppData folder, which is always writable.
    Private ReadOnly connectionString As String = "Data Source=" & IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ParkingManagementSystem", "parking.sqlite") & ";Version=3;"

    ''' <summary>
    ''' Checks if the database exists in the AppData folder. If not, it copies the master database from the application's startup path.
    ''' This should be run once when the application starts.
    ''' </summary>
    Public Sub CheckAndCreateDatabase()
        ' Define the full path to the database file in the AppData\Roaming\ParkingManagementSystem folder
        Dim appDataFolder As String = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ParkingManagementSystem")
        Dim dbPath As String = IO.Path.Combine(appDataFolder, "parking.sqlite")

        ' If the database file already exists, our work here is done.
        If IO.File.Exists(dbPath) Then
            Return
        End If

        ' If the database does NOT exist, we must create the folder and copy our template file.
        Try
            ' 1. Create the "ParkingManagementSystem" directory in AppData\Roaming
            IO.Directory.CreateDirectory(appDataFolder)

            ' 2. Find the master database template located next to our .exe file
            Dim sourceDbPath As String = IO.Path.Combine(Application.StartupPath, "parking.sqlite")

            ' 3. If the source template exists, copy it to the new AppData location.
            If IO.File.Exists(sourceDbPath) Then
                IO.File.Copy(sourceDbPath, dbPath)
            Else
                MessageBox.Show("Critical Error: The master database file 'parking.sqlite' is missing from the application folder.", "Database Missing", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("An error occurred during the initial database setup: " & ex.Message, "Setup Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function ValidateLogin(ByVal userID As Integer, ByVal password As String) As Boolean
        Dim sqlQuery As String = "SELECT COUNT(1) FROM UserInformation WHERE UserID = @UserID AND Password = @Password;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@Password", password)
                connection.Open()
                Return Convert.ToInt32(command.ExecuteScalar()) = 1
            End Using
        End Using
    End Function

    Public Function GetSecurityQuestion(ByVal userID As Integer) As String
        Dim sqlQuery As String = "SELECT SecurityQuestion FROM UserInformation WHERE UserID = @UserID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                connection.Open()
                Dim result = command.ExecuteScalar()
                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Return result.ToString()
                Else
                    Return String.Empty
                End If
            End Using
        End Using
    End Function

    Public Function VerifySecurityAnswer(ByVal userID As Integer, ByVal securityAnswer As String) As Boolean
        Dim sqlQuery As String = "SELECT COUNT(1) FROM UserInformation WHERE UserID = @UserID AND SecurityAnswer = @SecurityAnswer;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@SecurityAnswer", securityAnswer)
                connection.Open()
                Return Convert.ToInt32(command.ExecuteScalar()) = 1
            End Using
        End Using
    End Function

    Public Function UpdatePassword(ByVal userID As Integer, ByVal securityAnswer As String, ByVal newPassword As String) As Boolean
        Dim sqlQuery As String = "UPDATE UserInformation SET Password = @NewPassword WHERE UserID = @UserID AND SecurityAnswer = @SecurityAnswer;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@NewPassword", newPassword)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@SecurityAnswer", securityAnswer)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetParkingAreas() As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT ParkingAreaID, VehicleType, VehicleLimit, ParkingCharge, Status FROM ParkingAreaInformation;"
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function AddNewParkingArea(ByVal vehicleType As String, ByVal vehicleLimit As Integer, ByVal parkingCharge As Decimal, ByVal status As String) As Boolean
        Dim sqlQuery As String = "INSERT INTO ParkingAreaInformation (VehicleType, VehicleLimit, ParkingCharge, Status) VALUES (@VehicleType, @VehicleLimit, @ParkingCharge, @Status);"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@VehicleType", vehicleType)
                command.Parameters.AddWithValue("@VehicleLimit", vehicleLimit)
                command.Parameters.AddWithValue("@ParkingCharge", parkingCharge)
                command.Parameters.AddWithValue("@Status", status)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateParkingArea(ByVal parkingAreaID As Integer, ByVal vehicleType As String, ByVal vehicleLimit As Integer, ByVal parkingCharge As Decimal) As Boolean
        Dim sqlQuery As String = "UPDATE ParkingAreaInformation SET VehicleType = @VehicleType, VehicleLimit = @VehicleLimit, ParkingCharge = @ParkingCharge WHERE ParkingAreaID = @ParkingAreaID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@ParkingAreaID", parkingAreaID)
                command.Parameters.AddWithValue("@VehicleType", vehicleType)
                command.Parameters.AddWithValue("@VehicleLimit", vehicleLimit)
                command.Parameters.AddWithValue("@ParkingCharge", parkingCharge)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateParkingAreaStatus(ByVal parkingAreaID As Integer, ByVal newStatus As String) As Boolean
        Dim sqlQuery As String = "UPDATE ParkingAreaInformation SET Status = @Status WHERE ParkingAreaID = @ParkingAreaID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@ParkingAreaID", parkingAreaID)
                command.Parameters.AddWithValue("@Status", newStatus)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function DeleteParkingArea(ByVal parkingAreaID As Integer) As Boolean
        Dim sqlQuery As String = "DELETE FROM ParkingAreaInformation WHERE ParkingAreaID = @ParkingAreaID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@ParkingAreaID", parkingAreaID)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetParkingChargeSummary() As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT VehicleType, AVG(ParkingCharge) AS AverageCharge FROM ParkingAreaInformation GROUP BY VehicleType;"
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetDistinctVehicleTypes() As List(Of String)
        Dim vehicleTypes As New List(Of String)()
        Dim sqlQuery As String = "SELECT DISTINCT VehicleType FROM ParkingAreaInformation WHERE Status = 'Active';"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                connection.Open()
                Using reader As SQLiteDataReader = command.ExecuteReader()
                    While reader.Read()
                        vehicleTypes.Add(reader("VehicleType").ToString())
                    End While
                End Using
            End Using
        End Using
        Return vehicleTypes
    End Function

    Public Function GetAvailableParkingAreas(ByVal vehicleType As String) As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT p.ParkingAreaID, p.ParkingCharge FROM ParkingAreaInformation p WHERE p.VehicleType = @VehicleType AND p.Status = 'Active' AND p.VehicleLimit > (SELECT COUNT(*) FROM VehicleInformation v WHERE v.ParkingAreaID = p.ParkingAreaID AND v.Status = 'Parked');"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@VehicleType", vehicleType)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetParkingLimitationSummary() As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT p.ParkingAreaID, p.VehicleType, p.VehicleLimit, (SELECT COUNT(*) FROM VehicleInformation v WHERE v.ParkingAreaID = p.ParkingAreaID AND v.Status = 'Parked') AS CurrentVehicles, p.Status FROM ParkingAreaInformation p;"
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetParkedVehicles() As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT VehicleID, PlateNumber, VehicleType, ParkingAreaID, ArrivalTime, TicketSerialNumber, Status FROM VehicleInformation WHERE Status = 'Parked';"
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function AddNewVehicleEntry(ByVal plateNumber As String, ByVal vehicleType As String, ByVal parkingAreaID As Integer, ByVal ticketSerial As String) As Boolean
        Dim sqlQuery As String = "INSERT INTO VehicleInformation (PlateNumber, VehicleType, ParkingAreaID, ArrivalTime, Status, TicketSerialNumber) VALUES (@PlateNumber, @VehicleType, @ParkingAreaID, @ArrivalTime, 'Parked', @Ticket);"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@PlateNumber", plateNumber)
                command.Parameters.AddWithValue("@VehicleType", vehicleType)
                command.Parameters.AddWithValue("@ParkingAreaID", parkingAreaID)
                command.Parameters.AddWithValue("@ArrivalTime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@Ticket", ticketSerial)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function MarkVehicleAsExited(ByVal vehicleID As Integer) As Boolean
        Dim sqlQuery As String = "UPDATE VehicleInformation SET Status = 'Exited' WHERE VehicleID = @VehicleID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@VehicleID", vehicleID)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetReportData(ByVal startDate As DateTime, ByVal endDate As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT date(v.ArrivalTime) AS ReportDate, SUM(p.ParkingCharge) AS TotalRevenue, COUNT(v.VehicleID) AS VehicleCount FROM VehicleInformation v INNER JOIN ParkingAreaInformation p ON v.ParkingAreaID = p.ParkingAreaID WHERE v.ArrivalTime >= @StartDate AND v.ArrivalTime < @EndDate GROUP BY date(v.ArrivalTime) ORDER BY ReportDate;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"))
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetVehicleTypeBreakdown(ByVal startDate As DateTime, ByVal endDate As DateTime) As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT VehicleType, COUNT(VehicleID) AS TypeCount FROM VehicleInformation WHERE ArrivalTime >= @StartDate AND ArrivalTime < @EndDate GROUP BY VehicleType;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@StartDate", startDate.ToString("yyyy-MM-dd HH:mm:ss"))
                command.Parameters.AddWithValue("@EndDate", endDate.ToString("yyyy-MM-dd HH:mm:ss"))
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function GetAllVehicleEntriesReport() As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT v.VehicleID, v.PlateNumber, v.VehicleType, v.ArrivalTime, p.ParkingCharge, v.Status, v.TicketSerialNumber, v.ParkingAreaID FROM VehicleInformation v INNER JOIN ParkingAreaInformation p ON v.ParkingAreaID = p.ParkingAreaID ORDER BY v.ArrivalTime DESC;"
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt
    End Function

    Public Function GetUserAccountDetails(ByVal userID As Integer) As DataTable
        Dim dt As New DataTable()
        Dim sqlQuery As String = "SELECT UserName, SecurityQuestion, SecurityAnswer FROM UserInformation WHERE UserID = @UserID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                Using adapter As New SQLiteDataAdapter(command)
                    adapter.Fill(dt)
                End Using
            End Using
        End Using
        Return dt
    End Function

    Public Function UpdateUserPassword(ByVal userID As Integer, ByVal currentPassword As String, ByVal newPassword As String) As Boolean
        Dim sqlQuery As String = "UPDATE UserInformation SET Password = @NewPassword WHERE UserID = @UserID AND Password = @CurrentPassword;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@CurrentPassword", currentPassword)
                command.Parameters.AddWithValue("@NewPassword", newPassword)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function UpdateSecurityInfo(ByVal userID As Integer, ByVal newQuestion As String, ByVal newAnswer As String) As Boolean
        Dim sqlQuery As String = "UPDATE UserInformation SET SecurityQuestion = @NewQuestion, SecurityAnswer = @NewAnswer WHERE UserID = @UserID;"
        Using connection As New SQLiteConnection(connectionString)
            Using command As New SQLiteCommand(sqlQuery, connection)
                command.Parameters.AddWithValue("@UserID", userID)
                command.Parameters.AddWithValue("@NewQuestion", newQuestion)
                command.Parameters.AddWithValue("@NewAnswer", newAnswer)
                connection.Open()
                Return command.ExecuteNonQuery() > 0
            End Using
        End Using
    End Function

    Public Function GetDashboardSummary() As DataRow
        Dim sqlQuery As String =
            "SELECT " &
            "(SELECT COUNT(*) FROM VehicleInformation WHERE Status = 'Parked') AS VehiclesParked, " &
            "(SELECT COUNT(*) FROM VehicleInformation WHERE Status = 'Exited') AS VehiclesDeparted, " &
            "(SELECT COUNT(*) FROM ParkingAreaInformation WHERE Status = 'Active') AS ActiveCategories, " &
            "(SELECT IFNULL(SUM(p.ParkingCharge), 0) FROM VehicleInformation v JOIN ParkingAreaInformation p ON v.ParkingAreaID = p.ParkingAreaID) AS TotalEarnings, " &
            "(SELECT COUNT(*) FROM VehicleInformation) AS TotalVehicleRecords, " &
            "(SELECT IFNULL(SUM(VehicleLimit), 0) FROM ParkingAreaInformation WHERE Status = 'Active') AS TotalCapacity"

        Dim dt As New DataTable()
        Using connection As New SQLiteConnection(connectionString)
            Using adapter As New SQLiteDataAdapter(sqlQuery, connection)
                adapter.Fill(dt)
            End Using
        End Using
        Return dt.Rows(0)
    End Function

    Public Sub ApplyModernDGVDarkBlueStyle(ByVal dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.BorderStyle = BorderStyle.None
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.None
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.RowHeadersVisible = False
        Dim headerStyle As New DataGridViewCellStyle()
        headerStyle.BackColor = Color.MidnightBlue
        headerStyle.ForeColor = Color.White
        headerStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Try
            headerStyle.Font = New Font("Poppins", 16, FontStyle.Regular)
        Catch ex As Exception
            headerStyle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        End Try
        dgv.ColumnHeadersDefaultCellStyle = headerStyle
        dgv.ColumnHeadersHeight = 50
        Dim cellStyle As New DataGridViewCellStyle()
        cellStyle.BackColor = Color.White
        cellStyle.ForeColor = Color.Black
        cellStyle.SelectionBackColor = Color.SteelBlue
        cellStyle.SelectionForeColor = Color.White
        Try
            cellStyle.Font = New Font("Poppins", 11, FontStyle.Regular)
        Catch ex As Exception
            cellStyle.Font = New Font("Segoe UI", 11, FontStyle.Regular)
        End Try
        dgv.DefaultCellStyle = cellStyle
        Dim altCellStyle As New DataGridViewCellStyle()
        altCellStyle.BackColor = Color.FromArgb(235, 245, 255)
        dgv.AlternatingRowsDefaultCellStyle = altCellStyle
        dgv.AllowUserToAddRows = False
        dgv.AllowUserToDeleteRows = False
        dgv.ReadOnly = True
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.RowTemplate.Height = 40
    End Sub

End Module