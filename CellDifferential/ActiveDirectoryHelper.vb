Imports System.DirectoryServices


Public Structure UserInfo
    Dim UserName As String
    Dim GivenName As String
End Structure

Public Module ActiveDirectoryHelper

    Public Function GetUserInfo() As UserInfo

        Dim entry As New DirectoryEntry()

        Dim userName As String = Environment.UserName.ToString

        entry.Username = userName

        Dim dirSearcher = New DirectorySearcher(entry)

        dirSearcher.Filter = "(SAMAccountName=" & userName & ")"

        dirSearcher.PropertiesToLoad.Add("GivenName")
        dirSearcher.PropertiesToLoad.Add("sn")

        Dim sr As SearchResult

        Try
            sr = dirSearcher.FindOne()
        Catch ex As Exception
            'user name not found in active directory
        End Try


        Dim result As String = String.Empty

        If sr Is Nothing Then
            result = userName
        Else
            result = sr.GetDirectoryEntry.Properties("sn").Value.ToString() + ", " + sr.GetDirectoryEntry.Properties("GivenName").Value.ToString()
        End If

        Return New UserInfo()

    End Function


End Module
