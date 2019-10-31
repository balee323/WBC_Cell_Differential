Public Class ModularCounterForm

    Dim _FlowLayoutPanel As FlowLayoutPanel

    Dim _LeftSideModule As LeftSideModule
    Dim _RightSideModule As RightSideModule
    Dim _CountingControlModule As CountingControlModule
    Dim _countingObject As CountingObject
    Dim _ControlList As New List(Of CellControlModule)
    Dim _cells As New List(Of Cell)


    Public Sub New(cells As List(Of Cell))

        Me._cells = cells
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub ModularPeripheralCounterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Focus()
        Me.KeyPreview = True  'important

        Me.AutoSize = True
        Me._countingObject = New CountingObject()

        _FlowLayoutPanel = New FlowLayoutPanel()
        _FlowLayoutPanel.AutoSize = True
        _FlowLayoutPanel.WrapContents = False
        _FlowLayoutPanel.Padding = New Padding(0)
        _FlowLayoutPanel.Margin = New Padding(0)
        _LeftSideModule = New LeftSideModule()
        _LeftSideModule.Margin = New Padding(0)
        Dim _refreshCellCounts As New Action(AddressOf RefreshCellCounts)
        Dim _resetCellCounts As New Action(AddressOf ResetCellCounts)
        _CountingControlModule = New CountingControlModule(_countingObject, _refreshCellCounts, _resetCellCounts)
        _CountingControlModule.Margin = New Padding(0)
        _RightSideModule = New RightSideModule()
        _RightSideModule.Margin = New Padding(0)

        Me.Controls.Add(Me._FlowLayoutPanel)

        Me._FlowLayoutPanel.Controls.Add(_LeftSideModule)


        Dim toggleRed As Boolean = True
        For Each cell In _cells
            'create a new cell module passing in cell object.
            Dim cellControlModule As New CellControlModule(cell)
            cellControlModule.Margin = New Padding(0)

            If (toggleRed) Then
                toggleRed = False
                cellControlModule.ButtonPicture.Image = CType(My.Resources.ResourceManager.GetObject("RedButton"), Image)
            Else
                cellControlModule.ButtonPicture.Image = CType(My.Resources.ResourceManager.GetObject("WhiteButton"), Image)
                toggleRed = True
            End If

            _ControlList.Add(cellControlModule)
            Me._FlowLayoutPanel.Controls.Add(cellControlModule)

        Next

        Me._FlowLayoutPanel.Controls.Add(_CountingControlModule)
        Me._FlowLayoutPanel.Controls.Add(_RightSideModule)

    End Sub


    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        For Each Cell In _cells
            If e.KeyChar = ChrW(Cell.getKeyMap) Then
                My.Computer.Audio.Play(My.Resources.click3,
                AudioPlayMode.Background)

                If Not Cell.getCellType.ToLower().Contains("nrbc") Or _CountingControlModule.ChkBoxIncludeNRBC.Checked Then
                    _countingObject.Total = _countingObject.Total + 1
                End If

                Cell.addToCount()
                _countingObject.UndoList.Push(Cell)
                Exit For
            End If
        Next



        If _countingObject.Total = _countingObject.Limit Then
            'PlaySound()
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        _CountingControlModule.RefreshCountingModuleState()
        RefreshCellCounts()

    End Sub

    Private Sub ModularPeripheralCoubterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        _cells.Clear()
    End Sub

    Public Sub RefreshCellCounts()
        For Each control In _ControlList
            control.ResetState()
        Next
    End Sub

    Public Sub ResetCellCounts()
        For Each cell In _cells
            cell.ResetCount()
        Next
    End Sub

End Class