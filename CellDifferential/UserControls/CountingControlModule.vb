Public Class CountingControlModule

    Private _countingObject As CountingObject
    Private _resetCellCounts As Action
    Public Sub New(countingObject As CountingObject, resetCellCounts As Action)

        Me._countingObject = countingObject
        Me._resetCellCounts = resetCellCounts

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub SetState()

        TxtTotal.Text = _countingObject.Total.ToString()

    End Sub

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click

        Try
            Dim lastCountedCell = _countingObject.UndoList.Pop
            'find NRBC
            Dim NRBC As Cell = Nothing
            If lastCountedCell.getCellType.Contains("NRBC") Then
                NRBC = lastCountedCell
            End If

            If _countingObject.Total > 0 Or NRBC IsNot Nothing Then
                UndoCount(lastCountedCell)
            End If

        Catch ex As Exception
            'need to lock out button
        End Try




        _resetCellCounts()
        Me.Refresh()
    End Sub

    Private Sub UndoCount(cell As Cell)

        'NRBC are part of count and will be removed
        If ChkBoxIncludeNRBC.Checked Then
            _countingObject.Total = _countingObject.Total - 1
            TxtTotal.Text = CStr(_countingObject.Total)
            cell.UndoCount()
        Else
            If cell.getCellType() <> "NRBC" Then
                _countingObject.Total = _countingObject.Total - 1
                TxtTotal.Text = CStr(_countingObject.Total)
                cell.UndoCount()
            ElseIf cell.getCellType() = "NRBC" Then
                cell.UndoCount() 'removes 1 from NRBC count
            End If
        End If

    End Sub

    Public Sub ResetState()
        TxtTotal.Text = _countingObject.Total.ToString()
    End Sub

End Class
