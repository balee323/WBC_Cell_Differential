
Imports System
Imports System.Drawing
Imports System.Windows.Forms

Public Class PeripheralForm


    'global variables


    Dim Count As Integer = 100

    ' Dim Seg As Integer = 0

    Dim Seg As New Cell("Seg", 47, "File", 0)
    Dim Lym As New Cell("Lym", 46, "File", 0)
    Dim Mono As New Cell("Mono", 44, "File", 0)
    Dim Eos As New Cell("Eos", 109, "File", 0)
    Dim Baso As New Cell("Baso", 110, "File", 0)
    Dim Band As New Cell("Band", 98, "File", 0)
    Dim Meta As New Cell("Meta", 59, "File", 0)
    Dim Myelo As New Cell("Myelo", 108, "File", 0)
    Dim ProMyelo As New Cell("ProMyelo", 107, "File", 0)
    Dim Blast As New Cell("Blast", 106, "File", 0)
    Dim NRBC As New Cell("NRBC", 104, "File", 0)

    'Dim Lym As Integer = 0
    'Dim Mono As Integer = 0
    'Dim Eos As Integer = 0
    'Dim Baso As Integer = 0
    'Dim Band As Integer = 0
    'Dim Meta As Integer = 0
    'Dim Myelo As Integer = 0
    'Dim Promyelo As Integer = 0
    'Dim Blast As Integer = 0
    'Dim NRBC As Integer = 0

    Dim Total As Integer = 0
    Public UndoList As New Stack(Of String)
    Dim settings As Settings

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        AddCells()
        GetKeyMapping()
        SetCountChannelLabels()



        ' TxtInput.Text = ""
        ' TxtInput.Focus()
        'TxtInput.Visible = False
        Me.Focus()
        Me.KeyPreview = True  'important
        ' Me.TransparencyKey = BackColor
    End Sub

    Public Sub AddCells()
        AllCells.PeripheralCells.Add(Seg)
        AllCells.PeripheralCells.Add(Lym)
        AllCells.PeripheralCells.Add(Mono)
        AllCells.PeripheralCells.Add(Eos)
        AllCells.PeripheralCells.Add(Baso)
        AllCells.PeripheralCells.Add(Band)
        AllCells.PeripheralCells.Add(Meta)
        AllCells.PeripheralCells.Add(Myelo)
        AllCells.PeripheralCells.Add(ProMyelo)
        AllCells.PeripheralCells.Add(Blast)
        AllCells.PeripheralCells.Add(NRBC)





    End Sub



    Public Sub GetKeyMapping()

        settings = New Settings()

        If settings.exists(Settings.RegistryKeyName.PeriheralKeys) Then
            settings.LoadSettings1()

            Seg.changeKeyMap(Settings.Key1)
            Lym.changeKeyMap(Settings.Key2)
            Mono.changeKeyMap(Settings.Key3)
            Eos.changeKeyMap(Settings.Key4)
            Baso.changeKeyMap(Settings.Key5)
            Band.changeKeyMap(Settings.Key6)
            Meta.changeKeyMap(Settings.Key7)
            Myelo.changeKeyMap(Settings.Key8)
            ProMyelo.changeKeyMap(Settings.Key9)
            Blast.changeKeyMap(Settings.Key10)
            NRBC.changeKeyMap(Settings.Key11)



        Else
            Seg.changeKeyMap(47)
            Lym.changeKeyMap(46)
            Mono.changeKeyMap(44)
            Eos.changeKeyMap(109)
            Baso.changeKeyMap(110)
            Band.changeKeyMap(98)
            Meta.changeKeyMap(59)
            Myelo.changeKeyMap(108)
            ProMyelo.changeKeyMap(107)
            Blast.changeKeyMap(106)
            NRBC.changeKeyMap(104)

            settings.SavePeripheralKeyBindings()

        End If


    End Sub


    Private Sub SetCountChannelLabels()

        LblSeg.Text = Seg.getCellType()
        LblLym.Text = Lym.getCellType()
        LblMono.Text = Mono.getCellType()
        LblEos.Text = Eos.getCellType()
        LblBaso.Text = Baso.getCellType()
        LblBand.Text = Band.getCellType()
        LblMeta.Text = Meta.getCellType()
        LblMyelo.Text = Myelo.getCellType()
        LblPro.Text = Mid(ProMyelo.getCellType(), 1, 3)
        LblBlast.Text = Blast.getCellType()
        LblNRBC.Text = NRBC.getCellType()

        Me.Refresh()

    End Sub


    'Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress




        ' If e.KeyChar = ChrW(47) Then
        If e.KeyChar = ChrW(Seg.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
            AudioPlayMode.Background)
            'MessageBox.Show("You pressed '/'  = seg ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            'Seg = Seg + 1
            Seg.addToCount()
            'TxtSeg.Text = CStr(Seg)
            TxtSeg.Text = CStr(Seg.getCount())
            UndoList.Push(Seg.getCellType)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(Lym.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed '.' = lym ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Lym.addToCount()
            TxtLym.Text = CStr(Lym.getCount())
            UndoList.Push(Lym.getCellType)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(Mono.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed ',' = mono ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Mono.addToCount()
            TxtMono.Text = CStr(Mono.getCount())
            UndoList.Push(Mono.getCellType)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(Eos.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'm' = Eos")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Eos.addToCount()
            TxtEos.Text = CStr(Eos.getCount())
            UndoList.Push(Eos.getCellType)
            ' TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(Baso.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'n' = Baso ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Baso.addToCount()
            TxtBaso.Text = CStr(Baso.getCount)
            UndoList.Push(Baso.getCellType)
            'TxtInput.Text = ""
        End If


        If e.KeyChar = ChrW(Band.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'b' = band ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Band.addToCount()
            TxtBand.Text = CStr(Band.getCount)
            UndoList.Push(Band.getCellType)
            'TxtInput.Text = ""
        End If


        If e.KeyChar = ChrW(NRBC.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            ' MessageBox.Show("You pressed ';' = NRBC ")
            If CheckBox1.Checked Then
                Total = Total + 1
            End If
            'Total = Total + 1  'not counted in total
            TxtTotal.Text = CStr(Total)
            NRBC.addToCount()
            TxtNRBC.Text = CStr(NRBC.getCount)
            UndoList.Push(NRBC.getCellType)
            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(Meta.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            ' MessageBox.Show("You pressed 'l' = metamyelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Meta.addToCount()
            TxtMeta.Text = CStr(Meta.getCount)
            UndoList.Push(Meta.getCellType)

            'TxtInput.Text = ""
        End If



        If e.KeyChar = ChrW(Myelo.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'k' = myelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Myelo.addToCount()
            Txtmyelo.Text = CStr(Myelo.getCount)
            UndoList.Push(Myelo.getCellType)

            'TxtInput.Text = ""
        End If

        If e.KeyChar = ChrW(ProMyelo.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'j' = Promyelocyte ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            ProMyelo.addToCount()
            TxtPromyelo.Text = CStr(ProMyelo.getCount)
            UndoList.Push(ProMyelo.getCellType)
            'TxtInput.Text = ""
        End If



        If e.KeyChar = ChrW(Blast.getKeyMap) Then
            My.Computer.Audio.Play(My.Resources.click3, _
           AudioPlayMode.Background)
            'MessageBox.Show("You pressed 'h' = Blast Cell ")
            Total = Total + 1
            TxtTotal.Text = CStr(Total)
            Blast.addToCount()
            TxtBlast.Text = CStr(Blast.getCount)
            UndoList.Push(Blast.getCellType)
            'TxtInput.Text = ""
        End If




        If Total = Count Then
            PlaySound()
            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


        If Total > 0 Then
            CheckBox1.Enabled = False
            BtnChangeCount.Enabled = False
        End If




        'Count(TxtInput.Text)


    End Sub






    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click

        CheckBox1.Enabled = True
        BtnChangeCount.Enabled = True

        Total = 0
        'Seg = 0

        Seg.ResetCount()
        Lym.ResetCount()
        Mono.ResetCount()
        Eos.ResetCount()
        Baso.ResetCount()
        Band.ResetCount()
        NRBC.ResetCount()
        Meta.ResetCount()
        Myelo.ResetCount()
        ProMyelo.ResetCount()
        Blast.ResetCount()


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
                Count = CInt(TxtChangeCount.Text)
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

        KeyBind1.Show()
        KeyBind1.Focus()



    End Sub



    Sub PlaySound()


        If RadioButton1.Checked = True Then
            'no sound

        End If


        If RadioButton2.Checked = True Then


            My.Computer.Audio.Play(My.Resources.Regular_Ding, _
            AudioPlayMode.Background)

        End If


        If RadioButton3.Checked = True Then

            My.Computer.Audio.Play(My.Resources.Bomb, _
            AudioPlayMode.Background)

        End If


        If RadioButton4.Checked = True Then

            My.Computer.Audio.Play(My.Resources.robotic_voice, _
            AudioPlayMode.Background)

        End If





        'My.Computer.Audio.Play(My.Resources.Regular_Ding, _
        ' AudioPlayMode.Background)


    End Sub

    'taken from the google search.

    Private Sub PeripheralForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


        Dim result As DialogResult

        result = MessageBox.Show("Are you sure you wish to close Periperhal Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If result = Windows.Forms.DialogResult.Yes Then
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
        If result = Windows.Forms.DialogResult.Yes Then
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

        'had to set all the variables on FrmReport to public

        'FrmReport.Seg = Seg.getCount()
        'FrmReport.Lym = Lym.getCount()
        'FrmReport.Mono = Mono.getCount()
        'FrmReport.Baso = Baso.getCount()
        'FrmReport.Eos = Eos.getCount()
        'FrmReport.Band = Band.getCount()
        'FrmReport.Meta = Meta.getCount()
        'FrmReport.Myelo = Myelo.getCount()
        'FrmReport.Promyelo = ProMyelo.getCount()
        'FrmReport.Blast = Blast.getCount()
        'FrmReport.NRBC = NRBC.getCount()


        Dim frm As Form

        For Each frm In My.Application.OpenForms
            If frm.Name = "FrmReport" Then
                FrmReport.Close()
                ' FrmReport.Show()
                '  FrmReport.BtnCreate.PerformClick()
                Exit For
            End If
        Next



        FrmReport.Count = Count  'Still need this!
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

    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click

        Dim LastCountedCell As String


        If Total > 0 Or NRBC.getCount > 0 Then
            LastCountedCell = UndoList.Pop
            If Seg.getCellType() = LastCountedCell Then
                UndoCount(Seg)
                TxtSeg.Text = CStr(Seg.getCount())
            ElseIf Lym.getCellType() = LastCountedCell Then
                UndoCount(Lym)
                TxtLym.Text = CStr(Lym.getCount())
            ElseIf Mono.getCellType() = LastCountedCell Then
                UndoCount(Mono)
                TxtMono.Text = CStr(Mono.getCount())
            ElseIf Eos.getCellType() = LastCountedCell Then
                UndoCount(Eos)
                TxtEos.Text = CStr(Eos.getCount())
            ElseIf Baso.getCellType() = LastCountedCell Then
                UndoCount(Baso)
                TxtBaso.Text = CStr(Baso.getCount())
            ElseIf Band.getCellType() = LastCountedCell Then
                UndoCount(Band)
                TxtBand.Text = CStr(Band.getCount())
            ElseIf Meta.getCellType() = LastCountedCell Then
                UndoCount(Meta)
                TxtMeta.Text = CStr(Meta.getCount())
            ElseIf Myelo.getCellType() = LastCountedCell Then
                UndoCount(Myelo)
                Txtmyelo.Text = CStr(Myelo.getCount())
            ElseIf ProMyelo.getCellType() = LastCountedCell Then
                UndoCount(ProMyelo)
                TxtPromyelo.Text = CStr(ProMyelo.getCount())
            ElseIf Blast.getCellType() = LastCountedCell Then
                UndoCount(Blast)
                TxtBlast.Text = CStr(Blast.getCount())
            ElseIf NRBC.getCellType() = LastCountedCell Then
                UndoCount(NRBC)
                TxtNRBC.Text = CStr(NRBC.getCount())
            End If


        End If


        Me.Refresh()





    End Sub

    Private Sub UndoCount(cell As Cell)

        'NRBC are part of count and will be removed
        If CheckBox1.Checked Then
            Total = Total - 1
            TxtTotal.Text = CStr(Total)
            cell.UndoCount()
        Else
            If cell.getCellType() <> "NRBC" Then
                Total = Total - 1
                TxtTotal.Text = CStr(Total)
                cell.UndoCount()
            ElseIf cell.getCellType() = "NRBC" Then
                cell.UndoCount() 'removes 1 from NRBC count
            End If
        End If

    End Sub




    Private Sub LblSeg_Click(sender As Object, e As EventArgs) Handles LblSeg.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Seg"

        Seg.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblLym_Click(sender As Object, e As EventArgs) Handles LblLym.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Lym"

        Lym.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblMono_Click(sender As Object, e As EventArgs) Handles LblMono.Click

        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Mono"

        Mono.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()

    End Sub

    Private Sub LblBand_Click(sender As Object, e As EventArgs) Handles LblBand.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Band"

        Band.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblEos_Click(sender As Object, e As EventArgs) Handles LblEos.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Eos"

        Eos.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblBaso_Click(sender As Object, e As EventArgs) Handles LblBaso.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Baso"

        Baso.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblMeta_Click(sender As Object, e As EventArgs) Handles LblMeta.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Meta"

        Meta.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblMyelo_Click(sender As Object, e As EventArgs) Handles LblMyelo.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Myelo"

        Myelo.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblPro_Click(sender As Object, e As EventArgs) Handles LblPro.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Pro"

        ProMyelo.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblBlast_Click(sender As Object, e As EventArgs) Handles LblBlast.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "Blast"

        Blast.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub

    Private Sub LblNRBC_Click(sender As Object, e As EventArgs) Handles LblNRBC.Click
        'Dim Input As String = ""
        Dim Message As String = "Please enter cell type."
        Dim Title As String = "Change cell type"
        Dim DefaultValue As String = "NRBC"

        NRBC.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
        SetCountChannelLabels()
    End Sub



    Private Sub PeripheralForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        MainForm.LblActiveCounter1.Visible = False
    End Sub
End Class
