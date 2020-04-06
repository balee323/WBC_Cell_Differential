
Imports System.Data.SQLite
Imports System.Threading.Tasks
Imports NLog

Public Class SqlLiteManager : Implements IDataRepo

    Private _logger As Logger = LogManager.GetCurrentClassLogger()
    Private _configDb As String = "WBCDiff.db"
    Private Shared _connectionString As String = "Data Source=WBCDiff.db;"
    Private _counterType As CounterType = CounterType.Peripheral 'default
    Private WithEvents _timer1 As Threading.Timer


    Public Sub New(counterType As CounterType)

        _counterType = counterType
        Task.Run(Sub() CreateDatabase())

    End Sub

    Public Sub New(counterType As CounterType?)

        Task.Run(Sub() CreateDatabase())

    End Sub

    Public Sub New()
    End Sub

    Private Sub CreateDatabase()

        If Not My.Computer.FileSystem.FileExists(_configDb) Then

            Try
                SQLiteConnection.CreateFile(_configDb)
            Catch ex As Exception
                _logger.Error(ex, "Database Created Failed...")
            End Try

        End If

        CreateUserTable()
        CreateReportsTable()

    End Sub

    Private Async Sub CreateUserTable()

        Dim create_table = "CREATE TABLE IF NOT EXISTS UserInfo(UserName VarChar(50) NOT NULL PRIMARY KEY, GivenName VarChar(50), PeripheralSettingsJson VarChar(500), BoneMarrowSettingsJson VarChar(500), DateCreated DateTime2(3), DateModified DateTime2(3));"

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(create_table, con)
                        Dim result = Await cmd.ExecuteNonQueryAsync()
                        result.ToString()
                    End Using
                    transaction.Commit()
                End Using
            End Using

        Catch ex As Exception
            _logger.Error(ex, "Table creation failed...")
        End Try

    End Sub

    Private Async Sub CreateReportsTable()

        Dim create_table = "CREATE TABLE IF NOT EXISTS Reports(ReportID UNIQUEIDENTIFIER NOT NULL PRIMARY KEY, UserName VarChar(50), GivenName VarChar(50), PatientID VarChar(50), PatientName VarChar(100), PatientDOB DateTime2(2), FacilityName VarChar(50), CounterType VarChar(50), ReportDetailsJson VarChar(5000), DateCreated DateTime2(3), DateModified DateTime2(3));"

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(create_table, con)
                        Dim result = Await cmd.ExecuteNonQueryAsync()
                        result.ToString()
                    End Using
                    transaction.Commit()
                End Using
            End Using

        Catch ex As Exception
            _logger.Error(ex, "Table creation failed...")
        End Try

    End Sub


    Public Sub SaveUserData(cellSettingsJson As String) Implements IDataRepo.SaveUserData

        Dim userSettings As New UserInfo()

        Try
            'this task is fine as we don't need to wait on it.
            Task.Run(Sub()

                         userSettings = ActiveDirectoryHelper.GetUserInfo()

                         If (UserExist(userSettings)) Then
                             UpdateExisitingUser(userSettings, cellSettingsJson)
                         Else
                             InsertNewUser(userSettings, cellSettingsJson)
                         End If
                     End Sub
            )

        Catch ex As Exception
            _logger.Error(ex)
        End Try

    End Sub

    Public Function LoadUserSettings() As String Implements IDataRepo.LoadUserSettings

        Dim userInfo = ActiveDirectoryHelper.GetUserInfo()

        If UserExist(userInfo) = False Then
            Return Nothing
        End If

        ' create table sql statement
        Dim queryStr As String = String.Empty

        If (_counterType = CounterType.Peripheral) Then
            queryStr = $"Select PeripheralSettingsJson from UserInfo Where UserName = '{userInfo.UserName}'"
        ElseIf (_counterType = CounterType.BoneMarrow) Then
            queryStr = $"Select BoneMarrowSettingsJson from UserInfo Where UserName = '{userInfo.UserName}'"
        End If

        Dim result As String = String.Empty

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        cmd.CommandText = queryStr
                        result = cmd.ExecuteScalar().ToString()
                    End Using
                    transaction.Commit()
                End Using
            End Using

        Catch ex As Exception
            _logger.Error(ex, "error finding user...")
            Return Nothing
        End Try
        Globals.ProgressBar.Increment(10)

        Return result

    End Function


    Private Sub InsertNewUser(userInfo As UserInfo, cellSettingsJson As String)

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        Dim Sql As String = ""
                        ' create the SQL statement

                        If (_counterType = CounterType.Peripheral) Then
                            Sql &= "INSERT INTO UserInfo (UserName, GivenName, PeripheralSettingsJson, DateCreated) VALUES "
                            Sql &= $"('{userInfo.UserName}', '{userInfo.GivenName}', '{cellSettingsJson}','{DateTime.Now}') "
                        ElseIf (_counterType = CounterType.BoneMarrow) Then
                            Sql &= "INSERT INTO UserInfo (UserName, GivenName, BoneMarrowSettingsJson, DateCreated) VALUES "
                            Sql &= $"('{userInfo.UserName}', '{userInfo.GivenName}', '{cellSettingsJson}','{DateTime.Now}') "
                        End If

                        cmd.CommandText = Sql
                        cmd.ExecuteNonQuery()

                    End Using
                    transaction.Commit()
                End Using
            End Using


        Catch ex As Exception
            _logger.Error(ex)
        End Try
    End Sub


    Private Sub UpdateExisitingUser(userInfo As UserInfo, cellSettingsJson As String)

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        Dim Sql As String = ""
                        ' create the SQL statement
                        Sql &= "Update UserInfo "
                        If (_counterType = CounterType.Peripheral) Then
                            Sql &= $"Set PeripheralSettingsJson = '{cellSettingsJson}', DateModified = '{DateTime.Now}' "
                        ElseIf (_counterType = CounterType.BoneMarrow) Then
                            Sql &= $"Set BoneMarrowSettingsJson = '{cellSettingsJson}', DateModified = '{DateTime.Now}' "
                        End If

                        Sql &= $"where UserName = '{userInfo.UserName}'"

                        cmd.CommandText = Sql
                        cmd.ExecuteNonQuery()

                    End Using
                    transaction.Commit()
                End Using
            End Using
            Console.WriteLine("Insert User Success")

        Catch ex As Exception
            _logger.Error(ex)
        End Try

    End Sub


    Private Function UserExist(userInfo As UserInfo) As Boolean

        ' create table sql statement
        Dim queryStr = $"Select * from UserInfo Where UserName = '{userInfo.UserName}'"
        Dim isUserFound = False

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        cmd.CommandText = queryStr
                        Dim reader = cmd.ExecuteReader()
                        isUserFound = reader.HasRows()
                        reader.Close() 'close the reader
                    End Using
                    transaction.Commit()
                End Using
            End Using

        Catch ex As Exception
            _logger.Error(ex)
        End Try

        Return isUserFound
    End Function


    Public Async Sub SaveReport(report As Report, reportDetailsJson As String, progressBar As ProgressBar, saveCompleted As Label) Implements IDataRepo.SaveReport


        saveCompleted.Visible = False

        Dim userSettings As New UserInfo()
        progressBar.Increment(15)

        Try

            Await Task.Run(Sub()

                               userSettings = ActiveDirectoryHelper.GetUserInfo()

                               'I should just pass in the action from the report form.  
                               progressBar.Invoke(Sub() progressBar.Value = 100)
                               saveCompleted.Invoke(Sub() saveCompleted.Visible = True)

                               InsertNewReport(userSettings, report, reportDetailsJson)

                           End Sub
            )

            _timer1 = New System.Threading.Timer(New Threading.TimerCallback(Sub() VerifySafeAndUpdateControl(saveCompleted)), Nothing, TimeSpan.FromSeconds(2), TimeSpan.FromSeconds(0))
        Catch ex As Exception
            _logger.Error(ex)
        End Try

    End Sub


    Private Sub VerifySafeAndUpdateControl(saveCompleted As Label)
        If (CType(saveCompleted, Control).Created) Then
            saveCompleted.Invoke(Sub() saveCompleted.Visible = False)
        End If

    End Sub

    Private Sub InsertNewReport(userInfo As UserInfo, report As Report, reportDetailsJson As String)

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        Dim Sql As String = ""
                        ' create the SQL statement

                        Sql &= "INSERT INTO Reports (ReportID, UserName, GivenName, PatientID, PatientName, PatientDOB, FacilityName, CounterType, ReportDetailsJson, DateCreated) VALUES "
                        Sql &= $"('{Guid.NewGuid().ToString()}', '{userInfo.UserName}', '{userInfo.GivenName}', '{report.PatientID}', '{report.PatientName}',"
                        Sql &= $" '{report.PatientDOB}', '{report.FacilityName}', '{report.CounterType.ToString()}', '{reportDetailsJson}', '{report.ReportDate}') "

                        cmd.CommandText = Sql
                        Dim result = cmd.ExecuteNonQuery()
                        result.ToString()

                    End Using
                    transaction.Commit()
                End Using
            End Using
            Console.WriteLine("Insert Report Success")

        Catch ex As Exception
            _logger.Error(ex)
        End Try
    End Sub

    Private Sub UpdateExisitingReport(userSettings As UserInfo, reportDetailsJson As String)
        Throw New NotImplementedException()
    End Sub


    Public Function LoadReports(searchFilter As SearchFilter) As List(Of String) Implements IDataRepo.LoadReports
        ' create table sql statement


        Dim queryStr = BuildSearchQueryString(searchFilter)

        Dim reportsStr As New List(Of String)

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction
                        cmd.CommandText = queryStr
                        Dim reader = cmd.ExecuteReader()

                        While reader.Read()

                            If reader.HasRows Then
                                Dim collection = reader.GetValues()
                                Dim keys = collection.AllKeys

                                Dim data As String = String.Empty

                                For Each key In keys
                                    data += collection.Get(key) + "|"
                                Next

                                reportsStr.Add(data)
                            End If

                        End While

                        reader.Close() 'close the reader
                    End Using
                    transaction.Commit()
                End Using
            End Using

        Catch ex As Exception
            _logger.Error(ex)
        End Try

        Return reportsStr

    End Function

    Private Function BuildSearchQueryString(searchFilter As SearchFilter) As String
        Dim queryStr = $"Select * from Reports order by DateCreated desc Limit 15"

        If searchFilter Is Nothing Then
            Return queryStr
        Else
            If searchFilter.SearchPatientID Then
                queryStr = $"Select * from Reports where PatientID Like '%{searchFilter.Report.PatientID}%'"
            ElseIf searchFilter.SearchPatientName Then
                queryStr = $"Select * from Reports where PatientName like '%{searchFilter.Report.PatientName.ToLower()}%'"
            ElseIf searchFilter.SearchPatientDOB Then
                queryStr = $"Select * from Reports where PatientDOB like '%{searchFilter.Report.PatientDOB.ToShortDateString}%'"
            ElseIf searchFilter.SearchUserName Then
                queryStr = $"Select * from Reports where UserName like '%{searchFilter.UserInfo.UserName.ToLower()}%' or GivenName like '%{searchFilter.UserInfo.GivenName.ToLower()}%' "
            Else
                queryStr = $"Select * from Reports where 1=1 " 'to use for dates only filter
            End If
        End If

        'add dates
        If searchFilter.SearchBeginDate Then
            queryStr += $" and DateCreated >= '{searchFilter.BeginDate}'"
        ElseIf searchFilter.SearchEndDate Then
            queryStr += $" and DateCreated <= '{searchFilter.EndDate}'"
        ElseIf searchFilter.SearchEndDate And searchFilter.SearchBeginDate Then
            queryStr += $" and between '{searchFilter.BeginDate}' and '{searchFilter.EndDate}'"
        End If

        Return queryStr

    End Function


    Public Shared Sub DeleteOldRecords()

        Task.Run(Sub() DeleteRecords())

    End Sub


    Private Shared Sub DeleteRecords()

        Dim logger As Logger = NLog.LogManager.GetCurrentClassLogger()

        Try
            While (True)

                Using con As New SQLiteConnection(_connectionString)
                    con.Open()
                    Dim transaction As SQLiteTransaction = con.BeginTransaction()
                    Using transaction
                        Using cmd As New SQLiteCommand(con)
                            cmd.Transaction = transaction
                            Dim Sql As String = ""
                            ' create the SQL statement
                            Sql &= "Delete From Reports Where DateCreated <= Date('now', '-90 day')"

                            cmd.CommandText = Sql
                            cmd.ExecuteNonQuery()

                        End Using
                        transaction.Commit()
                    End Using
                End Using

                Console.WriteLine("Delete Success")
                Task.Delay(1000 * 60).Wait() 'one hour delay

            End While

        Catch ex As Exception
            logger.Error(ex)
        End Try

    End Sub



End Class
