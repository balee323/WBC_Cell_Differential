Public Class CellControlModule

    Private _cell As Cell
    Public Property IncludeNRBC As Boolean = False
    Public Sub New(cell As Cell)

        Me._cell = cell

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.LblBindingKey.Text = cell.getKeyMapChar()
        Me.LblCellType.Text = cell.getCellType()

        ToolTip1.ToolTipTitle = "Just so you know..."
        ToolTip1.SetToolTip(Me, "Clicking on cell label text will allow you to change the cell type text.")

    End Sub
    Private Sub LblCellType_Click(sender As Object, e As EventArgs) Handles LblCellType.Click
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = ""

        _cell.ChangeCellType(InputBox(Message, Title, DefaultValue))
        LblCellType.Text = _cell.getCellType()
        LblCellType.Refresh()

    End Sub

    Public Sub ResetState()
        TxtCellTotal.Text = _cell.getCount().ToString()
        LblBindingKey.Text = _cell.getKeyMapChar()
        LblCellType.Text = _cell.getCellType()
        LblCellType.Refresh()
        LblBindingKey.Refresh()
    End Sub

    Private Sub CellPicture_Click(sender As Object, e As EventArgs) Handles CellPicture.Click

    End Sub

End Class
