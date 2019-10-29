Public Class ModularPeripheralCounterForm

    Dim _FlowLayoutPanel As FlowLayoutPanel

    Dim _LeftSideModule As LeftSideModule
    Dim _RightSideModule As RightSideModule

    Private Sub ModularPeripheralCounterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim btn As New Button()

        _FlowLayoutPanel = New FlowLayoutPanel()
        _FlowLayoutPanel.AutoSize = True
        _LeftSideModule = New LeftSideModule()
        _RightSideModule = New RightSideModule()


        Me.Controls.Add(Me._FlowLayoutPanel)

        Me._FlowLayoutPanel.Controls.Add(_LeftSideModule)


        AllCells.PeripheralCells.Add(New Cell("Seg", 47, "File", 0, Nothing, Nothing))
        'AllCells.PeripheralCells.Add(New Cell("Lym", 46, "File", 0, Nothing, Nothing))
        'AllCells.PeripheralCells.Add(New Cell("Mono", 44, "File", 0, LblMono, TxtMono))
        'AllCells.PeripheralCells.Add(New Cell("Eos", 109, "File", 0, LblEos, TxtEos))
        'AllCells.PeripheralCells.Add(New Cell("Baso", 110, "File", 0, LblBaso, TxtBaso))
        'AllCells.PeripheralCells.Add(New Cell("Band", 98, "File", 0, LblBand, TxtBand))
        'AllCells.PeripheralCells.Add(New Cell("Meta", 59, "File", 0, LblMeta, TxtMeta))
        'AllCells.PeripheralCells.Add(New Cell("Myelo", 108, "File", 0, LblMyelo, Txtmyelo))
        'AllCells.PeripheralCells.Add(New Cell("ProMyelo", 107, "File", 0, LblPro, TxtPromyelo))
        'AllCells.PeripheralCells.Add(New Cell("Blast", 106, "File", 0, LblBlast, TxtBlast))
        'AllCells.PeripheralCells.Add(New Cell("NRBC", 104, "File", 0, LblNRBC, TxtNRBC))

        For Each cell In AllCells.PeripheralCells
            'create a new cell module passing in cell object.
            Me._FlowLayoutPanel.Controls.Add(New CellControlModule())

        Next


        Me._FlowLayoutPanel.Controls.Add(_RightSideModule)



    End Sub
End Class