Public Class ModularPeripheralCounterForm

    Dim _FlowLayoutPanel As FlowLayoutPanel

    Dim _LeftSideModule As LeftSideModule
    Dim _RightSideModule As RightSideModule
    Dim _CountingControlModule As CountingControlModule
    Dim _countingObject As CountingObject
    Dim _ControlList As New List(Of CellControlModule)


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
        Dim _resetAllUserControls As New Action(AddressOf ResetAllUserControls)
        _CountingControlModule = New CountingControlModule(_countingObject, _resetAllUserControls)
        _CountingControlModule.Margin = New Padding(0)
        _RightSideModule = New RightSideModule()
        _RightSideModule.Margin = New Padding(0)

        Me.Controls.Add(Me._FlowLayoutPanel)

            Me._FlowLayoutPanel.Controls.Add(_LeftSideModule)


            AllCells.PeripheralCells.Add(New Cell("Seg", 47, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Lym", 46, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Mono", 44, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Eos", 109, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Baso", 110, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Band", 98, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Meta", 59, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Myelo", 108, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("ProMyelo", 107, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("Blast", 106, "File", 0))
            AllCells.PeripheralCells.Add(New Cell("NRBC", 104, "File", 0))


            Dim toggleRed As Boolean = True
            For Each cell In AllCells.PeripheralCells
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

        For Each Cell In AllCells.PeripheralCells
            If e.KeyChar = ChrW(Cell.getKeyMap) Then
                My.Computer.Audio.Play(My.Resources.click3,
                AudioPlayMode.Background)

                If Not Cell.getCellType.ToLower().Contains("nrbc") Or _CountingControlModule.ChkBoxIncludeNRBC.Checked Then
                    _countingObject.Total = _countingObject.Total + 1
                    _CountingControlModule.TxtTotal.Text = (_countingObject.Total).ToString()
                End If

                Cell.addToCount()
                _countingObject.UndoList.Push(Cell)
                Exit For
            End If
        Next

        'Lock Controls
        If _countingObject.Total > 0 Then
            _CountingControlModule.ChkBoxIncludeNRBC.Enabled = False
            _CountingControlModule.BtnChangeCount.Enabled = False
        End If

        If _countingObject.Total = _countingObject.Limit Then
            'PlaySound()
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        ResetAllUserControls()

    End Sub

    Private Sub ModularPeripheralCoubterForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        AllCells.PeripheralCells.Clear()
    End Sub

    Public Sub ResetAllUserControls()
        For Each control In _ControlList
            control.ResetState()
        Next
        _CountingControlModule.ResetState()
    End Sub


End Class