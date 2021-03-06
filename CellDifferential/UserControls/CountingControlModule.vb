﻿Imports NLog

Public Class CountingControlModule

    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _countingObject As CountingObject
    Private _resetCellCounts As Action
    Private _refreshCellModules As Action
    Private _cells As List(Of Cell)
    Private _settings As ISettings
    Public Sub New(countingObject As CountingObject, refreshCellModules As Action, resetCellCounts As Action, cells As List(Of Cell), settings As ISettings)

        Me._countingObject = countingObject
        Me._refreshCellModules = refreshCellModules
        Me._resetCellCounts = resetCellCounts
        Me._cells = cells
        Me._settings = settings

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
            If lastCountedCell.GetCellType.Contains("NRBC") Then
                NRBC = lastCountedCell
            End If

            If _countingObject.Total > 0 Or NRBC IsNot Nothing Then
                UndoCount(lastCountedCell)
            End If

        Catch ex As Exception
            'need to lock out button
        End Try

        _refreshCellModules()
        Me.Refresh()

    End Sub

    Private Sub UndoCount(cell As Cell)

        'NRBC are part of count and will be removed
        If ChkBoxIncludeNRBC.Checked Then
            _countingObject.Total -= 1
            TxtTotal.Text = CStr(_countingObject.Total)
            cell.UndoCount()
        Else
            If cell.GetCellType() <> "NRBC" Then
                _countingObject.Total -= 1
                TxtTotal.Text = CStr(_countingObject.Total)
                cell.UndoCount()
            ElseIf cell.GetCellType() = "NRBC" Then
                cell.UndoCount() 'removes 1 from NRBC count
            End If
        End If

        If _countingObject.Total < 1 Then
            ChkBoxIncludeNRBC.Enabled = True
            BtnChangeCount.Enabled = True
        End If

    End Sub

    Public Sub RefreshCountingModuleState()
        'Lock Controls
        If _countingObject.Total > 0 Then
            ChkBoxIncludeNRBC.Enabled = False
            BtnChangeCount.Enabled = False
        End If
        TxtTotal.Text = _countingObject.Total.ToString()
    End Sub



    Private Sub BtnChangeCount_Click(sender As Object, e As EventArgs) Handles BtnChangeCount.Click
        TxtCountLimit.ReadOnly = True

        'TxtCountLimit.Focus()

        Dim Message As String = "Please enter a count between 20 and 500."
        Dim Title As String = "Change Cell Count"
        Dim DefaultValue As String = "100"

        'checks the value of the input
        CheckCountInput(InputBox(Message, Title, DefaultValue))
        TxtCountLimit.Refresh()

    End Sub

    Private Sub CheckCountInput(inputValue As String)

        'TxtCountLimit.ReadOnly = True

        If String.IsNullOrEmpty(inputValue) Then
            Return
        End If

        If IsNumeric(inputValue) Then
            Dim newLimit = CInt(inputValue)
            If (newLimit) <= 500 And (newLimit) >= 20 Then
                _countingObject.Limit = newLimit
                TxtCountLimit.Text = newLimit.ToString()
            Else
                MessageBox.Show("please enter an Integer Between 20 and 500")
                TxtCountLimit.Text = ("100")

            End If
        Else
            MessageBox.Show("You entered a non-number, please enter an Integer")
            TxtCountLimit.Text = ("100")
        End If

    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        ClearCountingModule()
    End Sub

    Public Sub ClearCountingModule()
        _resetCellCounts()
        _refreshCellModules()
        _countingObject.Total = 0
        ChkBoxIncludeNRBC.Enabled = True
        BtnChangeCount.Enabled = True
        RefreshCountingModuleState()
    End Sub

    Private Sub BtnEditKeys_Click(sender As Object, e As EventArgs) Handles BtnEditKeys.Click

        Try
            If _countingObject.CounterType = CounterType.Peripheral Then
                Dim keybind As New KeyBind(_cells, _settings, _refreshCellModules)
                keybind.Show()

            ElseIf _countingObject.CounterType = CounterType.BoneMarrow Then
                Dim keybind As New KeyBind2(_cells, _settings, _refreshCellModules)
                keybind.Show()
            End If
        Catch ex As Exception
            _logger.Error(ex, "Error displaying keybind window.  Keytype not property not set.")
        End Try

    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click

        ' Dim _reportCells As IEnumerable(Of IReportCell)
        '_reportCells = _cells

        Dim report = New ReportForm(_cells, _settings, _countingObject)
        report.Show()
    End Sub
End Class
