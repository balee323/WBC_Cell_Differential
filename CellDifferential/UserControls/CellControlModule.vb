Public Class CellControlModule

    Private _cell As Cell
    Public Property IncludeNRBC As Boolean = False
    Public Sub New(cell As Cell)

        Me._cell = cell

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.LblBindingKey.Text = cell.getKeyMapChar()

    End Sub
    Private Sub LblSeg_Click(sender As Object, e As EventArgs) Handles LblSeg.Click

    End Sub

    Private Sub CellControlModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Public Sub ResetState()
        TxtCellTotal.Text = _cell.getCount().ToString()
    End Sub


End Class
