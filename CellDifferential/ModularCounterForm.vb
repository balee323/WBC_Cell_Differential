Imports System.Threading.Tasks
Imports System.Windows
Imports NLog

Public Class ModularCounterForm

    Dim _CountingControlModule As CountingControlModule
    Dim _countingObject As CountingObject
    Dim _ControlList As New List(Of CellControlModule)
    Private _cells As New List(Of Cell)
    Private _settings As ISettings
    Private _counterType As CounterType
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _FlowLayoutPanel As FlowLayoutPanel


    Public Sub New(cells As List(Of Cell), counterType As CounterType)

        Me._cells = cells
        Me._counterType = counterType
        ' This call is required by the designer.

        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        If (_counterType = CounterType.Peripheral) Then
            Me.Name = "Peripheral Counter"
            Me.Text = "Peripheral Counter"
            Me.Icon = My.Resources.RedCell
        ElseIf (_counterType = CounterType.BoneMarrow) Then
            Me.Name = "BoneMarrow Counter"
            Me.Text = "BoneMarrow Counter"
            Me.Icon = My.Resources.BoneMarrow
        End If

        Globals.ProgressBar.Increment(10)

    End Sub

    Private Sub ModularPeripheralCounterForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _settings = New Settings(_cells, _counterType)

        Me.Focus()
        Me.KeyPreview = True  'important

        Me.AutoSize = True
        Me._countingObject = New CountingObject(_counterType)

        LoadSettings()

        BuildCounter()

        Globals.ProgressBar.Increment(5)



    End Sub

    Private Sub BuildCounter()

        _FlowLayoutPanel = New FlowLayoutPanel()
        _FlowLayoutPanel.AutoSize = True
        _FlowLayoutPanel.WrapContents = False
        _FlowLayoutPanel.Padding = New Padding(0)
        _FlowLayoutPanel.Margin = New Padding(0)
        Dim _refreshCellModules As New Action(AddressOf RefreshCellModules)
        Dim _resetCellCounts As New Action(AddressOf ResetCellCounts)
        Dim _rebuildCellModules As New Action(AddressOf RebuildCellModules)
        Dim _LeftSideModule = New LeftSideModule(_cells, _rebuildCellModules, _resetCellCounts)
        _LeftSideModule.Margin = New Padding(0)
        _CountingControlModule = New CountingControlModule(_countingObject, _refreshCellModules, _resetCellCounts, _cells, _settings)
        _CountingControlModule.Margin = New Padding(0)
        Dim _RightSideModule = New RightSideModule()
        _RightSideModule.Margin = New Padding(0)

        Me.Controls.Add(_FlowLayoutPanel)

        _FlowLayoutPanel.Controls.Add(_LeftSideModule)

        Globals.ProgressBar.Increment(5)

        Dim toggleRed As Boolean = True
        For Each cell In _cells
            'create a new cell module passing in cell object.
            Dim cellControlModule As New CellControlModule(cell)
            cellControlModule.Margin = New Padding(0)

            If cell.EnableInCounter = False Then
                Continue For 'skip adding
            End If

            If (toggleRed) Then
                toggleRed = False
                cellControlModule.ButtonPicture.Image = CType(My.Resources.ResourceManager.GetObject("RedButton"), Image)
            Else
                cellControlModule.ButtonPicture.Image = CType(My.Resources.ResourceManager.GetObject("WhiteButton"), Image)
                toggleRed = True
            End If

            _ControlList.Add(cellControlModule)
            _FlowLayoutPanel.Controls.Add(cellControlModule)

        Next

        _FlowLayoutPanel.Controls.Add(_CountingControlModule)
        _FlowLayoutPanel.Controls.Add(_RightSideModule)
    End Sub

    Public Sub LoadSettings()

        Try
            _settings.LoadSettings()
            Globals.ProgressBar.Increment(5)
            RefreshCellModules()

        Catch ex As Exception
            _logger.Error(ex)
        End Try

    End Sub

    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        For Each cell In _cells
            If e.KeyChar = ChrW(cell.GetKeyMap) Then

                If (cell.EnableInCounter = False) Then
                    Continue For
                End If

                Task.Run(Sub()
                             My.Computer.Audio.Play(My.Resources.click3,
                              AudioPlayMode.Background)
                         End Sub)

                _CountingControlModule.ChkBoxIncludeNRBC.Enabled = True 'this is a stupid as fuck hack.  Disabled checked boxes return as false.



                If (Not cell.GetCellType.ToLower() = ("nrbc")) Then
                    _countingObject.Total += 1
                ElseIf (_CountingControlModule.ChkBoxIncludeNRBC.Checked) Then
                    _countingObject.Total += 1
                End If

                _CountingControlModule.ChkBoxIncludeNRBC.Enabled = False

                cell.AddToCount()
                _countingObject.UndoList.Push(cell)

                Exit For

            End If
        Next

        If _countingObject.Total = _countingObject.Limit Then
            My.Computer.Audio.Play(My.Resources.Regular_Ding, AudioPlayMode.Background)
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

        _CountingControlModule.RefreshCountingModuleState()
        RefreshCellModules()

    End Sub



    Private Sub ModularPeripheralCoubterForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        _settings.SaveSettings()
        _cells.Clear()


        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close Periperhal Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Forms.DialogResult.Yes Then
            e.Cancel = False

            Dim frm As Form
            For Each frm In My.Application.OpenForms
                frm.Show()
            Next

            MainForm.Show()
        Else
            e.Cancel = True
        End If

        MainForm.Enabled = True



    End Sub


    Public Sub RefreshCellModules()

        For Each control In _ControlList
            control.ResetState()
        Next

        Me.Focus()

    End Sub

    Public Sub ResetCellCounts()

        For Each cell In _cells
            cell.ResetCount()
        Next

    End Sub



    Private Sub RebuildCellModules()

        ' MessageBox.Show("Rebuilding Counter")

        For Each control In _ControlList
            control.Dispose()
        Next

        _ControlList.Clear()
        _FlowLayoutPanel.Dispose()
        _CountingControlModule.ClearCountingModule()
        BuildCounter()

    End Sub

End Class