Imports System.DirectoryServices

Public Module ActiveDirectoryHelper

    'I will be using this to populate the full user name once reports get stored in DB
    Public Function GetUserInfo() As UserInfo

        Dim entry As New DirectoryEntry()
        Dim userName As String = Environment.UserName.ToString
        entry.Username = userName

        Dim dirSearcher = New DirectorySearcher(entry)
        dirSearcher.Filter = "(SAMAccountName=" & userName & ")"
        dirSearcher.PropertiesToLoad.Add("GivenName")
        dirSearcher.PropertiesToLoad.Add("sn")

        Dim sr As SearchResult = Nothing

        Try
            sr = dirSearcher.FindOne()
        Catch ex As Exception
            'user name not found in active directory
        End Try

        Dim userSettings As New UserInfo()
        userSettings.UserName = userName
        userSettings.GivenName = "Not Found"

        If sr IsNot Nothing Then
            userSettings.GivenName = sr.GetDirectoryEntry.Properties("GivenName").Value.ToString()
        End If

        Return userSettings

    End Function


End Module
