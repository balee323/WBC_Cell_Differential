Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class MainForm

  
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveCounters()


        ToolStripMenuItem6.Text = My.Application.Info.Version.ToString


    End Sub




    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click

        Dim cells As New List(Of Cell)

        cells.Add(New Cell("NRBC", 104, "File"))
        cells.Add(New Cell("Blast", 106, "File"))
        cells.Add(New Cell("ProMyelo", 107, "File"))
        cells.Add(New Cell("Myelo", 108, "File"))
        cells.Add(New Cell("Meta", 59, "File"))
        cells.Add(New Cell("Band", 98, "File"))
        cells.Add(New Cell("Baso", 110, "File"))
        cells.Add(New Cell("Eos", 109, "File"))
        cells.Add(New Cell("Mono", 44, "File"))
        cells.Add(New Cell("Lym", 46, "File"))
        cells.Add(New Cell("Seg", 47, "File"))


        Dim modularPeripheralCounterForm As New ModularCounterForm(cells)
        modularPeripheralCounterForm.Show()
        'BoneMarrowForm.Hide()
        ActiveCounters()

    End Sub

    Private Sub MainForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close the program?", "Close program?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Windows.Forms.DialogResult.Yes Then
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem3.Click

        Dim cells As New List(Of Cell)

        cells.Add(New Cell("NRBC", 104, "File"))
        cells.Add(New Cell("Blast", 106, "File"))
        cells.Add(New Cell("ProMyelo", 107, "File"))
        cells.Add(New Cell("Myelo", 108, "File"))
        cells.Add(New Cell("Meta", 59, "File"))
        cells.Add(New Cell("Band", 98, "File"))
        cells.Add(New Cell("Baso", 110, "File"))
        cells.Add(New Cell("Eos", 109, "File"))
        cells.Add(New Cell("Mono", 44, "File"))
        cells.Add(New Cell("Plasma", "p", "File"))
        cells.Add(New Cell("Lym", 46, "File"))
        cells.Add(New Cell("Seg", 47, "File"))




        '    Dim User1 As New Cell("User1", "1", "File", 0)
        '    Dim Meta As New Cell("Meta", "'", "File", 0)

        '    Dim Blast As New Cell("Blast", "k", "File", 0)
        '    Dim ProNormo As New Cell("ProNormo", "h", "File", 0)
        '    Dim NormoBlast As New Cell("NormoBlast", "g", "File", 0)
        '    Dim User2 As New Cell("User2", "2", "File", 0)
        '    Dim User3 As New Cell("User3", "3", "File", 0)


        Dim modularBoneMarrowCounterForm As New ModularCounterForm(cells)
        modularBoneMarrowCounterForm.Show()

        ' BoneMarrowForm.Show()
        ' PeripheralForm.Hide()
        ActiveCounters()
        '  Me.Refresh()
        ' Me.Hide()
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

        'ListView1.Items.Add("test")

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