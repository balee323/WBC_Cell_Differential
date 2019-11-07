
Imports System
Imports System.Drawing
Imports System.Windows

Public Class PeripheralForm

    Private _count As Integer = 100
    Private _total As Integer = 0
    Private _undoList As New Stack(Of String)
    Private _settings As ISettings

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddCells()
        GetKeyMapping()


        Me.Focus()
        Me.KeyPreview = True  'important
        ' Me.TransparencyKey = BackColor
    End Sub

    Public Sub AddCells()


    End Sub



    Public Sub GetKeyMapping()


    End Sub




    'Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

        For Each Cell In AllCells.PeripheralCells
            If e.KeyChar = ChrW(Cell.getKeyMap) Then
                My.Computer.Audio.Play(My.Resources.click3,
                AudioPlayMode.Background)

                If Not Cell.getCellType.ToLower().Contains("nrbc") Or CheckBox1.Checked Then
                    _total = _total + 1
                    TxtTotal.Text = CStr(_total)
                End If


                Cell.addToCount()
                'Cell..Text = CStr(Cell.getCount())
                _undoList.Push(Cell.getCellType)
            End If
        Next


        If _total = _count Then
            PlaySound()
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        If _total > 0 Then
            CheckBox1.Enabled = False
            BtnChangeCount.Enabled = False
        End If

    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        CheckBox1.Enabled = True
        BtnChangeCount.Enabled = True

        _total = 0

        For Each cell In AllCells.PeripheralCells
            cell.ResetCount()

        Next

        'I might add these object references to the cells list later
        TxtSeg.Clear()
        TxtTotal.Clear()
        TxtLym.Clear()
        TxtMono.Clear()
        TxtEos.Clear()
        TxtBaso.Clear()
        TxtBand.Clear()
        TxtMeta.Clear()
        TxtPromyelo.Clear()
        Txtmyelo.Clear()
        TxtBand.Clear()
        TxtNRBC.Clear()
        TxtBlast.Clear()

    End Sub

    Private Sub BtnChangeCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangeCount.Click

        TxtChangeCount.ReadOnly = False

        'MessageBox.Show("Please Enter a new count total below, press Done when finished.")

        TxtChangeCount.Focus()


        'Dim Input As String = ""
        Dim Message As String = "Please enter a count between 20 and 500."
        Dim Title As String = "Change Cell Count"
        Dim DefaultValue As String = "100"


        ' MessageBox.Show("Please enter a count between 20 and 500")

        TxtChangeCount.Text = InputBox(Message, Title, DefaultValue) 'user input box.  File name and .txt is appended to string

        'checks the value of the input
        CheckCountInput()


    End Sub


    Sub CheckCountInput()

        'Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click

        TxtChangeCount.ReadOnly = True
        Dim OK As Boolean = False


        If IsNumeric(TxtChangeCount.Text) Then

            If CInt(TxtChangeCount.Text) <= 500 And CInt(TxtChangeCount.Text) >= 20 Then
                _count = CInt(TxtChangeCount.Text)
                OK = True
            Else
                MessageBox.Show("please enter an Integer Between 20 and 500")
                TxtChangeCount.Text = ("100")

            End If
        Else

            MessageBox.Show("You entered a non-number, please enter an Integer")
            TxtChangeCount.Text = ("100")
        End If





    End Sub


    Private Sub BtnEditKeys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditKeys.Click

        'KeyBind1.Settings = _settings
        'KeyBind1.Cells = AllCells.PeripheralCells

        KeyBind1.Show()
        KeyBind1.Focus()

    End Sub

    Sub PlaySound()


        If RadioButton1.Checked = True Then
            'no sound

        End If


        If RadioButton2.Checked = True Then


            My.Computer.Audio.Play(My.Resources.Regular_Ding,
            AudioPlayMode.Background)

        End If


        If RadioButton3.Checked = True Then

            My.Computer.Audio.Play(My.Resources.Bomb,
            AudioPlayMode.Background)

        End If


        If RadioButton4.Checked = True Then

            My.Computer.Audio.Play(My.Resources.robotic_voice,
            AudioPlayMode.Background)

        End If


    End Sub

    'taken from the google search.

    Private Sub PeripheralForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close Periperhal Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Forms.DialogResult.Yes Then
            e.Cancel = False
            ' Me.Close()

            Dim frm As Form
            For Each frm In My.Application.OpenForms
                frm.Show()
            Next

            MainForm.Show()
        Else
            e.Cancel = True
        End If

    End Sub



    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        CloseProgram()

    End Sub

    Private Sub CloseProgram()
        'see pg. 321 murach's VB 2010
        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close Periperhal Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        'if no is selected then the program ends
        If result = Forms.DialogResult.Yes Then
            Me.Close()

            Dim frm As Form
            For Each frm In My.Application.OpenForms
                frm.Show()
            Next

            MainForm.Show()



        Else
            Return
        End If



    End Sub


    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click

        Dim frm As Form

        For Each frm In My.Application.OpenForms
            If frm.Name = "FrmReport" Then
                FrmReport.Close()
                ' FrmReport.Show()
                '  FrmReport.BtnCreate.PerformClick()
                Exit For
            End If
        Next


        FrmReport.Count = _count  'Still need this!
        FrmReport.DiffType = 1
        FrmReport.Show()
        FrmReport.Focus()
        '   FrmReport.StartReport()

        'clicks the Create Report button on the report Form
        FrmReport.BtnCreate.PerformClick()


    End Sub
    Private Sub Label13_Click(sender As Object, e As EventArgs)
        FrmDeveloper.Show()
    End Sub

    'Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click

    '    Dim LastCountedCell As String

    '    Dim NRBC As Cell = Nothing


    '    'find NRBC

    '    For Each Cell In AllCells.PeripheralCells
    '        If Cell.getCellType.Contains("NRBC") Then
    '            NRBC = Cell
    '        End If
    '    Next

    '    For Each Cell In AllCells.PeripheralCells
    '        If _total > 0 Or NRBC.getCount > 0 Then
    '            LastCountedCell = _undoList.Pop
    '            If Cell.getCellType() = LastCountedCell Then
    '                UndoCount(Cell)
    '            End If
    '        End If

    '    Next


    '    Me.Refresh()





    'End Sub

    'Private Sub UndoCount(cell As Cell)

    '    'NRBC are part of count and will be removed
    '    If CheckBox1.Checked Then
    '        _total = _total - 1
    '        TxtTotal.Text = CStr(_total)
    '        cell.UndoCount()
    '    Else
    '        If cell.getCellType() <> "NRBC" Then
    '            _total = _total - 1
    '            TxtTotal.Text = CStr(_total)
    '            cell.UndoCount()
    '        ElseIf cell.getCellType() = "NRBC" Then
    '            cell.UndoCount() 'removes 1 from NRBC count
    '        End If
    '    End If

    'End Sub


    'Private Sub LblSeg_Click(sender As Object, e As EventArgs) Handles LblSeg.Click
    '    'private Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Seg"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblSeg.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
    '            Exit For
    '        End If
    '    Next


    'End Sub

    'Private Sub LblLym_Click(sender As Object, e As EventArgs) Handles LblLym.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Lym"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblLym.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblMono_Click(sender As Object, e As EventArgs) Handles LblMono.Click

    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Mono"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblMono.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
    '            Exit For
    '        End If
    '    Next

    'End Sub

    'Private Sub LblBand_Click(sender As Object, e As EventArgs) Handles LblBand.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Band"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblBand.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblEos_Click(sender As Object, e As EventArgs) Handles LblEos.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Eos"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblEos.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblBaso_Click(sender As Object, e As EventArgs) Handles LblBaso.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Baso"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblBaso.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblMeta_Click(sender As Object, e As EventArgs) Handles LblMeta.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Meta"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblMeta.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblMyelo_Click(sender As Object, e As EventArgs) Handles LblMyelo.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Myelo"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblMyelo.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblPro_Click(sender As Object, e As EventArgs) Handles LblPro.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Pro"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblPro.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblBlast_Click(sender As Object, e As EventArgs) Handles LblBlast.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "Blast"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblBlast.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub

    'Private Sub LblNRBC_Click(sender As Object, e As EventArgs) Handles LblNRBC.Click
    '    'Dim Input As String = ""
    '    Dim Message As String = "Please enter cell type."
    '    Dim Title As String = "Change cell type"
    '    Dim DefaultValue As String = "NRBC"

    '    For Each cell In AllCells.PeripheralCells
    '        If cell.getCellType().ToLower().Contains(LblNRBC.Name.ToLower()) Then 'label.Name is the only mapping
    '            cell.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string

    '            Exit For
    '        End If
    '    Next
    'End Sub


    Private Sub PeripheralForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.LblActiveCounter1.Visible = False
    End Sub

End Class
