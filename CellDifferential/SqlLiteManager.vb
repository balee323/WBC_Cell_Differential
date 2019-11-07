
Imports System.Data.SQLite





Public Class SqlLiteManager
    Dim configDb As String = "WBCDiffSettings.db"
    Dim connectionString As String = "Data Source={0};Version=3;"


    Public Sub create_sqlite_database()

        If Not My.Computer.FileSystem.FileExists(configDb) Then

            Try
                ' Create the SQLite database

                SQLiteConnection.CreateFile(configDb)

                MessageBox.Show("Database Created...")



            Catch ex As Exception
                MessageBox.Show("Database Created Failed...")
            End Try

        End If

        CreateUserSettingsTable()
        InsertUser()
        ViewData()


    End Sub


    Public Sub CreateUserSettingsTable()
        Dim create_table As String = String.Empty

        ' create table sql statement
        create_table &= "CREATE TABLE MyTable(UserID INTEGER PRIMARY KEY ASC, FirstName VARCHAR(25), LastName VARCHAR(25));"


        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(create_table, con)
                    Dim result = cmd.ExecuteNonQuery()
                    result.ToString()
                End Using
            End Using
            MessageBox.Show("Table created successfully")
        Catch ex As Exception
            MessageBox.Show("create table failed")
        End Try

    End Sub

    Public Sub InsertUser()
        Dim dt As New DataTable
        Dim SQL As String = String.Empty



        Dim userName As String = String.Empty

        Try
            userName = Environment.UserName.ToString()
        Catch ex As Exception

        End Try


        Try

            'insert the records into the database table

            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Dim transaction As SQLiteTransaction = con.BeginTransaction()
                Using transaction
                    Using cmd As New SQLiteCommand(con)
                        cmd.Transaction = transaction

                        ' create the SQL statement
                        SQL &= "INSERT INTO UserInfo (UserName, DateCreated) VALUES "
                        SQL &= $"{userName}, {Date.Now.ToString()}"

                        cmd.CommandText = SQL
                        cmd.ExecuteNonQuery()

                    End Using
                    transaction.Commit()
                End Using
            End Using
            MessageBox.Show("Insert User Success")

        Catch ex As Exception
            MessageBox.Show("Insert User Failed")
        End Try

    End Sub


    'Public Sub insert_config_data()
    '    Dim dt As New DataTable
    '    Dim SQL As String = String.Empty

    '    ' create datatable
    '    dt.Columns.Add(New DataColumn("UserID"))
    '    dt.Columns.Add(New DataColumn("FirstName"))

    '    ' add default setting records
    '    dt.Rows.Add({"1234", "Brian"})
    '    dt.Rows.Add({"444444", "Connor"})


    '    Try

    '        'insert the records into the database table

    '        Using con As New SQLiteConnection(connectionString)
    '            con.Open()
    '            Dim transaction As SQLiteTransaction = con.BeginTransaction()
    '            Using transaction
    '                Using cmd As New SQLiteCommand(con)
    '                    cmd.Transaction = transaction
    '                    For Each row As DataRow In dt.Rows
    '                        ' create the SQL statement
    '                        SQL = ""
    '                        SQL &= "INSERT INTO MyTable (CustomerId, FirstName) VALUES "
    '                        SQL &= String.Format("('{0}','{1}')", row("CustomerId"), row("FirstName"))

    '                        cmd.CommandText = SQL
    '                        cmd.ExecuteNonQuery()

    '                    Next
    '                End Using
    '                transaction.Commit()
    '            End Using
    '        End Using
    '        MessageBox.Show("Insert Default Setting Success")

    '    Catch ex As Exception
    '        MessageBox.Show("Insert Default Setting Failed")
    '    End Try

    'End Sub

    Public Sub ViewData()


        ' create table sql statement
        Dim queryStr = "Select * from UserInfo"


        Try
            Using con As New SQLiteConnection(connectionString)
                con.Open()
                Using cmd As New SQLiteCommand(queryStr, con)
                    Dim result = cmd.ExecuteReader()
                    result.ToString()
                End Using
            End Using
            MessageBox.Show("view data successful")
        Catch ex As Exception
            MessageBox.Show("error viewing table data")
        End Try

    End Sub

End Class
