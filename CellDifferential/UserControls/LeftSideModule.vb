Public Class LeftSideModule

#Disable Warning IDE0044 ' Add readonly modifier
    Private _cells As List(Of Cell)
#Enable Warning IDE0044 ' Add readonly modifier
#Disable Warning IDE0044 ' Add readonly modifier
    Private _rebuildCellModules As Action
#Enable Warning IDE0044 ' Add readonly modifier
    Private _resetCellCounts As Action
    Public Sub New(cells As List(Of Cell), rebuildCellModules As Action, resetCellCounts As Action)
        Me._cells = cells
        Me._rebuildCellModules = rebuildCellModules
        Me._resetCellCounts = resetCellCounts
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        _resetCellCounts()
        Dim cellViewOptions = New CellViewOptions(_cells, _rebuildCellModules)
        cellViewOptions.Show()

    End Sub

End Class
