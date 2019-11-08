Imports System
Imports System.Drawing
Imports System.Windows

Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveCounters()


        ToolStripMenuItem6.Text = My.Application.Info.Version.ToString


    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Dim cells As New List(Of Cell)

        cells.Add(New Cell("NRBC", 104, "File", 0))
        cells.Add(New Cell("Blast", 106, "File", 1))
        cells.Add(New Cell("ProMyelo", 107, "File", 2))
        cells.Add(New Cell("Myelo", 108, "File", 3))
        cells.Add(New Cell("Meta", 59, "File", 4))
        cells.Add(New Cell("Band", 98, "File", 5))
        cells.Add(New Cell("Baso", 110, "File", 6))
        cells.Add(New Cell("Eos", 109, "File", 7))
        cells.Add(New Cell("Mono", 44, "File", 8))
        cells.Add(New Cell("Lym", 46, "File", 9))
        cells.Add(New Cell("Seg", 47, "File", 10))


        Dim modularPeripheralCounterForm As New ModularCounterForm(cells, CounterType.Peripheral)
        modularPeripheralCounterForm.Show()
        ActiveCounters()

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Dim cells As New List(Of Cell)

        cells.Add(New Cell("NRBC", 104, "File", 0))
        cells.Add(New Cell("Blast", 106, "File", 1))
        cells.Add(New Cell("ProMyelo", 107, "File", 2))
        cells.Add(New Cell("Myelo", 108, "File", 3))
        cells.Add(New Cell("Meta", 59, "File", 4))
        cells.Add(New Cell("Band", 98, "File", 5))
        cells.Add(New Cell("Baso", 110, "File", 6))
        cells.Add(New Cell("Eos", 109, "File", 7))
        cells.Add(New Cell("Mono", 44, "File", 8))
        cells.Add(New Cell("Plasma", "p", "File", 9))
        cells.Add(New Cell("Lym", 46, "File", 11))
        cells.Add(New Cell("Seg", 47, "File", 12))




        '    Dim User1 As New Cell("User1", "1", "File", 0)
        '    Dim Meta As New Cell("Meta", "'", "File", 0)

        '    Dim Blast As New Cell("Blast", "k", "File", 0)
        '    Dim ProNormo As New Cell("ProNormo", "h", "File", 0)
        '    Dim NormoBlast As New Cell("NormoBlast", "g", "File", 0)
        '    Dim User2 As New Cell("User2", "2", "File", 0)
        '    Dim User3 As New Cell("User3", "3", "File", 0)


        Dim modularBoneMarrowCounterForm As New ModularCounterForm(cells, CounterType.BoneMarrow)
        modularBoneMarrowCounterForm.Show()

        ActiveCounters()

    End Sub

    Private Sub ViewSavedReports_Click(sender As Object, e As EventArgs) Handles ViewSavedReports.Click

    End Sub

    Private Sub DeveloperInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperInfoToolStripMenuItem.Click
        FrmDeveloper.Show()
    End Sub

    Private Sub GetSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetSupportToolStripMenuItem.Click

        Process.Start("http://sourceforge.net/projects/celldiff/support")
    End Sub

    Private Sub ActiveCounters()

        'this will probably go away...
        Dim frm As Form

        For Each frm In My.Application.OpenForms

            If frm.Equals(PeripheralForm) Then
                LblActiveCounter1.Visible = True
                LblActiveCounter1.Text = (frm.Text.ToString())
            End If

            If frm.Equals(BoneMarrowForm) Then
                LblActiveCounter2.Visible = True
                LblActiveCounter2.Text = (frm.Text.ToString())
            End If

        Next
        Me.Refresh()

    End Sub





    Private Sub LblActiveCounter1_Click(sender As Object, e As EventArgs) Handles LblActiveCounter1.Click
        PeripheralForm.Show()
        BoneMarrowForm.Hide()
    End Sub

    Private Sub LblActiveCounter2_Click(sender As Object, e As EventArgs) Handles LblActiveCounter2.Click
        BoneMarrowForm.Show()
        PeripheralForm.Hide()
    End Sub
End Class