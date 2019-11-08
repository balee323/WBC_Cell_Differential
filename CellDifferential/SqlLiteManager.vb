
Imports System.Data.SQLite
Imports System.Threading.Tasks
Imports Newtonsoft.Json

Public Class SqlLiteManager : Implements IDataRepo


    Private configDb As String = "WBCDiffSettings.db"
    Private connectionString As String = "Data Source={0};Version=3;"
    Private _counterType As CounterType


    Public Sub New(counterType As CounterType)
        _counterType = counterType

        Task.Run(Sub() CreateDatabase())

        'I need to install NLog
    End Sub

    Private Sub CreateDatabase()

        If Not My.Computer.FileSystem.FileExists(configDb) Then

            Try

                'Task.Run(Sub()

                '             ' Create the SQLite database
                '             SQLiteConnection.CreateFile(configDb)
                '             MessageBox.Show("Database Created...")
                '         End Sub
                ')

                'Create the SQLite database
                SQLiteConnection.CreateFile(configDb)
                MessageBox.Show("Database Created...")

            Catch ex As Exception
                MessageBox.Show("Database Created Failed...")
            End Try

        End If


        CreateUserTable()

    End Sub

    Private Async Sub CreateUserTable()

        Console.WriteLine("Starting CreateTable Sub")

        Dim create_table As String = String.Empty

        create_table &= "CREATE TABLE UserInfo(UserName VarChar(50) NOT NULL PRIMARY KEY, GivenName VarChar(50), PeripheralSettingsJson VarChar(500), BoneMarrowSettingsJson VarChar(500), DateCreated DateTime2(3), DateModified DateTime2(3));"

        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table, con)
                    Dim result = Await cmd.ExecuteNonQueryAsync()
                    result.ToString()
                End Using
            End Using
            'MessageBox.Show("Table created successfully")
        Catch ex As Exception
            ' MessageBox.Show("create table failed")
        End Try

        Console.WriteLine("Starting long pause in CreateTable sub")

        'lets have a long pause
        Await Task.Delay(1000 * 20)

        Console.WriteLine("End of CreateTable Sub")

    End Sub


    Public Sub SaveUserData(cellSettingsJson As String) Implements IDataRepo.SaveUserData

        Dim userSettings As New UserInfo()

        Try

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
            'log error
        End Try

    End Sub

    Public Function LoadUserSettings(userInfo As UserInfo) As Boolean Implements IDataRepo.LoadUserSettings

        ' create table sql statement
        Dim queryStr = $"Select * from UserInfo Where UserName = '{userInfo.UserName}'"

        Dim isUserFound = False

        Try
            Task.Run(Sub()

                         Using con As New SQLiteConnection(connectionString)
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

                     End Sub)


        Catch ex As Exception
            MessageBox.Show("error finding user")
        End Try

        Return isUserFound
    End Function


    Private Sub InsertNewUser(userInfo As UserInfo, cellSettingsJson As String)

        Try
            Using con As New SQLiteConnection(connectionString)
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
            'MessageBox.Show("Insert User Success")

        Catch ex As Exception
            'MessageBox.Show("Insert User Failed")
        End Try
    End Sub


    Private Sub UpdateExisitingUser(userInfo As UserInfo, cellSettingsJson As String)

        Try

            Using con As New SQLiteConnection(connectionString)
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
            'MessageBox.Show("Insert User Success")

        Catch ex As Exception
            'MessageBox.Show("Insert User Failed")
        End Try

    End Sub


    Private Function UserExist(userInfo As UserInfo) As Boolean

        ' create table sql statement
        Dim queryStr = $"Select * from UserInfo Where UserName = '{userInfo.UserName}'"

        Dim isUserFound = False

        Try
            Using con As New SQLiteConnection(connectionString)
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
            '  MessageBox.Show("error finding user")
        End Try

        Return isUserFound
    End Function











End Class
