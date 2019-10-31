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

    End Sub
    Private Sub LblCellType_Click(sender As Object, e As EventArgs) Handles LblCellType.Click
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "NRBC"


        _cell.ChangeCellType(InputBox(Message, Title, DefaultValue))
        LblCellType.Text = _cell.getCellType()
        LblCellType.Refresh()

        'need to save the celltype to DB

    End Sub

    Public Sub ResetState()
        TxtCellTotal.Text = _cell.getCount().ToString()
        LblCellType.Refresh()
    End Sub

    Private Sub CellControlModule_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
