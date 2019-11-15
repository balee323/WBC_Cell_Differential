Imports Newtonsoft.Json

Public Class ReportPickerForm
    Private Sub CheckedListBox1_ItemChecked(sender As Object, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck

        For location As Integer = 0 To CheckedListBox1.Items.Count - 1
            If (e.Index <> location) Then
                CheckedListBox1.SetItemChecked(location, False)
            End If
        Next


    End Sub


    Private Sub DisplayReports()

    End Sub

    Public Sub LoadReports()

    End Sub






End Class