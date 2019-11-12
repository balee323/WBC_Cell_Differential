Imports System
Imports System.Drawing
Imports System.Windows

Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.ProgressBar = ProgressBar1
        ToolStripMenuItem6.Text = My.Application.Info.Version.ToString

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        'peripheral counter
        Globals.ProgressBar.Increment(10)

        Dim cells As New List(Of Cell)
        cells.Add(New Cell("NRBC", "j", "File", 0))
        cells.Add(New Cell("Blast", "k", "File", 1))
        cells.Add(New Cell("ProMyelo", "l", "File", 2))
        cells.Add(New Cell("Myelo", ";", "File", 3))
        cells.Add(New Cell("Meta", "'", "File", 4))
        cells.Add(New Cell("Band", "b", "File", 5))
        cells.Add(New Cell("Baso", "n", "File", 6))
        cells.Add(New Cell("Eos", "m", "File", 7))
        cells.Add(New Cell("Mono", ",", "File", 8))
        cells.Add(New Cell("Lym", ".", "File", 9))
        cells.Add(New Cell("Seg", "/", "File", 10))

        Dim modularPeripheralCounterForm As New ModularCounterForm(cells, CounterType.Peripheral)
        Globals.ProgressBar.Increment(10)
        modularPeripheralCounterForm.Show()
        Globals.ProgressBar.Increment(10)

        Globals.ProgressBar.Value = 0
        'Me.Enabled = False

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        'save user data on any open forms

        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Globals.ProgressBar.Increment(5)

        Dim cells As New List(Of Cell)

        cells.Add(New Cell("User2", "o", "File", 0))
        cells.Add(New Cell("User1", "i", "File", 1))
        cells.Add(New Cell("ProNormo", "h", "File", 2))
        cells.Add(New Cell("NormoBlast", "g", "File", 3))
        cells.Add(New Cell("NRBC", "h", "File", 4))
        cells.Add(New Cell("Blast", "k", "File", 5))
        cells.Add(New Cell("ProMyelo", "l", "File", 6))
        cells.Add(New Cell("Myelo", ";", "File", 7))
        cells.Add(New Cell("Meta", "'", "File", 8))
        cells.Add(New Cell("Band", "b", "File", 9))
        cells.Add(New Cell("Baso", "n", "File", 10))
        cells.Add(New Cell("Eos", "m", "File", 11))
        cells.Add(New Cell("Mono", ",", "File", 12))
        cells.Add(New Cell("Plasma", "p", "File", 13))
        cells.Add(New Cell("Lym", ".", "File", 14))
        cells.Add(New Cell("Seg", "/", "File", 15))


        Dim modularBoneMarrowCounterForm As New ModularCounterForm(cells, CounterType.BoneMarrow)
        Globals.ProgressBar.Increment(5)
        modularBoneMarrowCounterForm.Show()

        Globals.ProgressBar.Value = 0

    End Sub

    Private Sub ViewSavedReports_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DeveloperInfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeveloperInfoToolStripMenuItem.Click
        FrmDeveloper.Show()
    End Sub

    Private Sub GetSupportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetSupportToolStripMenuItem.Click

        Process.Start("http://sourceforge.net/projects/celldiff/support")
    End Sub


    Private Sub MenuOptions_Click(sender As Object, e As EventArgs) Handles MenuOptions.Click
        ReportPickerForm.Show()
    End Sub
End Class