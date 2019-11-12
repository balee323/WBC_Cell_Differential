
Imports System.Data.SQLite
Imports System.Threading.Tasks
Imports Newtonsoft.Json
Imports NLog

Public Class SqlLiteManager : Implements IDataRepo

    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _configDb As String = "WBCDiffSettings.db"
    Private _connectionString As String = "Data Source={0};Version=3;"
    Private _counterType As CounterType


    Public Sub New(counterType As CounterType)

        _counterType = counterType
        Task.Run(Sub() CreateDatabase())

    End Sub

    Private Sub CreateDatabase()

        If Not My.Computer.FileSystem.FileExists(_configDb) Then

            Try
                SQLiteConnection.CreateFile(_configDb)
            Catch ex As Exception
                _logger.Error(ex, "Database Created Failed...")
                Return
            End Try

        End If

        CreateUserTable()

    End Sub

    Private Async Sub CreateUserTable()

        Dim create_table = "CREATE TABLE UserInfo(UserName VarChar(50) NOT NULL PRIMARY KEY, GivenName VarChar(50), PeripheralSettingsJson VarChar(500), BoneMarrowSettingsJson VarChar(500), DateCreated DateTime2(3), DateModified DateTime2(3));"

        Try
            Using con As New SQLiteConnection(_connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table, con)
                    Dim result = Await cmd.ExecuteNonQueryAsync()
                    result.ToString()
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

        ' create table sql statement
        Dim queryStr As String = String.Empty

        If (_counterType = CounterType.Peripheral) Then
            queryStr = $"Select PeripheralSettingsJson from UserInfo Where UserName = '{userInfo.UserName}'"
        ElseIf (_counterType = CounterType.BoneMarrow) Then
            queryStr = $"Select BoneMarrowSettingsJson from UserInfo Where UserName = '{userInfo.UserName}'"
        End If

        Dim result As String = String.Empty

        Try
            Task.Run(Sub()

                         Using con As New SQLiteConnection(_connectionString)
                             con.Open()
                             Dim transaction As SQLiteTransaction = con.BeginTransaction()
                             Using transaction
                                 Using cmd As New SQLiteCommand(con)
                                     cmd.Transaction = transaction
                                     cmd.CommandText = queryStr
                                     result = cmd.ExecuteScalar().ToString()
                                     'cmd.Dispose()
                                 End Using
                                 transaction.Commit()
                             End Using
                         End Using

                     End Sub).Wait()

        Catch ex As Exception
            _logger.Error(ex, "error finding user...")
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
                        Dim Sql As String
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
                        Dim Sql As String
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

End Class
