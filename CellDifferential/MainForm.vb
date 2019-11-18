Imports System
Imports System.Drawing
Imports System.Windows

Public Class MainForm


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Globals.ProgressBar = ProgressBar1
        ToolStripMenuItem6.Text = My.Application.Info.Version.ToString

        'run a loop that deletes 90 day old records once per hour (if people keep the counter open)
        SqlLiteManager.DeleteOldRecords()

    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        'peripheral counter
        Globals.ProgressBar.Increment(10)

        Dim cells As New List(Of Cell) From {
            New Cell("NRBC", "j", "File", 0),
            New Cell("Blast", "k", "File", 1),
            New Cell("ProMyelo", "l", "File", 2),
            New Cell("Myelo", ";", "File", 3),
            New Cell("Meta", "'", "File", 4),
            New Cell("Band", "b", "File", 5),
            New Cell("Baso", "n", "File", 6),
            New Cell("Eos", "m", "File", 7),
            New Cell("Mono", ",", "File", 8),
            New Cell("Lym", ".", "File", 9),
            New Cell("Seg", "/", "File", 10)
        }

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

        Dim cells As New List(Of Cell) From {
            New Cell("User2", "o", "File", 0),
            New Cell("User1", "i", "File", 1),
            New Cell("ProNormo", "h", "File", 2),
            New Cell("NormoBlast", "g", "File", 3),
            New Cell("NRBC", "h", "File", 4),
            New Cell("Blast", "k", "File", 5),
            New Cell("ProMyelo", "l", "File", 6),
            New Cell("Myelo", ";", "File", 7),
            New Cell("Meta", "'", "File", 8),
            New Cell("Band", "b", "File", 9),
            New Cell("Baso", "n", "File", 10),
            New Cell("Eos", "m", "File", 11),
            New Cell("Mono", ",", "File", 12),
            New Cell("Plasma", "p", "File", 13),
            New Cell("Lym", ".", "File", 14),
            New Cell("Seg", "/", "File", 15)
        }


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