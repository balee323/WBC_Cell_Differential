Public Class CellViewOptions

    Private _cells As List(Of Cell)
    Private _rebuildCellModules As Action

    Public Sub New(Cells As List(Of Cell), rebuildCellModules As Action)
        _rebuildCellModules = rebuildCellModules

        _cells = Cells

        ' This call is required by the designer.
        InitializeComponent()


        CheckedListBox1.DisplayMember = "CellType"
        CheckedListBox1.ValueMember = "Position"


        For Each cell In _cells
            Dim include = cell.EnableInCounter
            Dim lastAdded = CheckedListBox1.Items.Add(cell, include)
        Next


    End Sub

    Private Sub BtnDone_Click(sender As Object, e As EventArgs) Handles BtnDone.Click

        For location As Integer = 0 To CheckedListBox1.Items.Count - 1
            If CheckedListBox1.GetItemChecked(location) = True Then
                CType(CheckedListBox1.Items.Item(location), Cell).EnableInCounter = True
            Else
                CType(CheckedListBox1.Items.Item(location), Cell).EnableInCounter = False
            End If

        Next


        _rebuildCellModules()
        Me.Close()

    End Sub
End Class