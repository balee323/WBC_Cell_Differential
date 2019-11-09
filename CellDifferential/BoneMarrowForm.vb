
'Imports System
'Imports System.Drawing
'Imports System.Windows.Forms

'Public Class BoneMarrowForm

'    'global variables


'    Dim Count As Integer = 100


'    Dim Seg As New Cell("Seg", "/", "File", 0)
'    Dim Lym As New Cell("Lym", ".", "File", 0)
'    Dim Plasma As New Cell("Plasma", "p", "File", 0)
'    Dim Mono As New Cell("Mono", ",", "File", 0)
'    Dim Eos As New Cell("Eos", "m", "File", 0)
'    Dim Baso As New Cell("Baso", "n", "File", 0)
'    Dim Band As New Cell("Band", "b", "File", 0)
'    Dim User1 As New Cell("User1", "1", "File", 0)
'    Dim Meta As New Cell("Meta", "'", "File", 0)
'    Dim Myelo As New Cell("Myelo", ";", "File", 0)
'    Dim ProMyelo As New Cell("ProMyelo", "l", "File", 0)
'    Dim Blast As New Cell("Blast", "k", "File", 0)
'    Dim ProNormo As New Cell("ProNormo", "h", "File", 0)
'    Dim NormoBlast As New Cell("NormoBlast", "g", "File", 0)
'    Dim User2 As New Cell("User2", "2", "File", 0)
'    Dim User3 As New Cell("User3", "3", "File", 0)







'    Dim Total As Integer = 0
'    Public UndoList As New Stack(Of String)
'    Dim settings As Settings

'    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

'        AddCells()

'        GetKeyMapping()
'        SetCountChannelLabels()



'        ' TxtInput.Text = ""
'        ' TxtInput.Focus()
'        'TxtInput.Visible = False
'        Me.Focus()
'        Me.KeyPreview = True  'important
'        ' Me.TransparencyKey = BackColor
'    End Sub

'    Public Sub AddCells()
'        AllCells.BoneMarrowCells.Add(Seg)
'        AllCells.BoneMarrowCells.Add(Lym)
'        AllCells.BoneMarrowCells.Add(Plasma)
'        AllCells.BoneMarrowCells.Add(Mono)
'        AllCells.BoneMarrowCells.Add(Eos)
'        AllCells.BoneMarrowCells.Add(Baso)
'        AllCells.BoneMarrowCells.Add(Band)
'        AllCells.BoneMarrowCells.Add(User1)
'        AllCells.BoneMarrowCells.Add(Meta)
'        AllCells.BoneMarrowCells.Add(Myelo)
'        AllCells.BoneMarrowCells.Add(ProMyelo)
'        AllCells.BoneMarrowCells.Add(Blast)
'        AllCells.BoneMarrowCells.Add(ProNormo)
'        AllCells.BoneMarrowCells.Add(NormoBlast)
'        AllCells.BoneMarrowCells.Add(User2)
'        AllCells.BoneMarrowCells.Add(User3)

'    End Sub


'    Public Sub GetKeyMapping()

'        settings = New Settings()

'        If settings.KeyExists(Settings.RegistryKeyName.BoneMarrowKeys) Then
'            settings.LoadBoneMarrowKeyBindings()

'            Seg.changeKeyMap(Settings.Key1)
'            Lym.changeKeyMap(Settings.Key2)
'            Plasma.changeKeyMap(Settings.Key3)
'            Mono.changeKeyMap(Settings.Key4)
'            Eos.changeKeyMap(Settings.Key5)
'            Baso.changeKeyMap(Settings.Key6)
'            Band.changeKeyMap(Settings.Key7)
'            User1.changeKeyMap(Settings.Key8)
'            Meta.changeKeyMap(Settings.Key9)
'            Myelo.changeKeyMap(Settings.Key10)
'            ProMyelo.changeKeyMap(Settings.Key11)
'            Blast.changeKeyMap(Settings.Key12)
'            ProNormo.changeKeyMap(Settings.Key13)
'            NormoBlast.changeKeyMap(Settings.Key14)
'            User2.changeKeyMap(Settings.Key15)
'            User3.changeKeyMap(Settings.Key16)

'        Else
'            Seg.changeKeyMap("/")
'            Lym.changeKeyMap(".")
'            Plasma.changeKeyMap("p")
'            Mono.changeKeyMap(",")
'            Eos.changeKeyMap("m")
'            Baso.changeKeyMap("n")
'            Band.changeKeyMap("b")
'            User1.changeKeyMap("1")
'            Meta.changeKeyMap("'")
'            Myelo.changeKeyMap(";")
'            ProMyelo.changeKeyMap("l")
'            Blast.changeKeyMap("k")
'            ProNormo.changeKeyMap("h")
'            NormoBlast.changeKeyMap("g")
'            User2.changeKeyMap("2")
'            User3.changeKeyMap("3")

'            settings.SaveBoneMarrowKeyBindings()

'        End If

'    End Sub


'    'Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As KeyPressEventArgs) Handles Me.KeyPress
'    Sub Control_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress




'        ' If e.KeyChar = ChrW(47) Then
'        If e.KeyChar = ChrW(Seg.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'            AudioPlayMode.Background)
'            'MessageBox.Show("You pressed '/'  = seg ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            'Seg = Seg + 1
'            Seg.addToCount()
'            'TxtSeg.Text = CStr(Seg)
'            TxtSeg.Text = CStr(Seg.getCount())
'            UndoList.Push(Seg.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(Lym.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3,
'           AudioPlayMode.Background)
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Lym.addToCount()
'            TxtLym.Text = CStr(Lym.getCount())
'            UndoList.Push(Lym.getCellType)
'        End If

'        If e.KeyChar = ChrW(Plasma.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3,
'           AudioPlayMode.Background)
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Plasma.addToCount()
'            TxtPlasma.Text = CStr(Plasma.getCount())
'            UndoList.Push(Plasma.getCellType)
'        End If


'        If e.KeyChar = ChrW(Mono.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed ',' = mono ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Mono.addToCount()
'            TxtMono.Text = CStr(Mono.getCount())
'            UndoList.Push(Mono.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(Eos.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'm' = Eos")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Eos.addToCount()
'            TxtEos.Text = CStr(Eos.getCount())
'            UndoList.Push(Eos.getCellType)
'            ' TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(Baso.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'n' = Baso ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Baso.addToCount()
'            TxtBaso.Text = CStr(Baso.getCount)
'            UndoList.Push(Baso.getCellType)
'            'TxtInput.Text = ""
'        End If


'        If e.KeyChar = ChrW(Band.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'b' = band ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Band.addToCount()
'            TxtBand.Text = CStr(Band.getCount)
'            UndoList.Push(Band.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(User1.getKeyMap) And User1.getCellType <> "User1" Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'b' = band ")
'            Total = Total + 1
'            TxtUser1.Text = CStr(Total)
'            User1.addToCount()
'            TxtUser1.Text = CStr(User1.getCount)
'            UndoList.Push(User1.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(Meta.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            ' MessageBox.Show("You pressed 'l' = metamyelocyte ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Meta.addToCount()
'            TxtMeta.Text = CStr(Meta.getCount)
'            UndoList.Push(Meta.getCellType)

'            'TxtInput.Text = ""
'        End If



'        If e.KeyChar = ChrW(Myelo.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'k' = myelocyte ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Myelo.addToCount()
'            Txtmyelo.Text = CStr(Myelo.getCount)
'            UndoList.Push(Myelo.getCellType)

'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(ProMyelo.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'j' = Promyelocyte ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            ProMyelo.addToCount()
'            TxtPromyelo.Text = CStr(ProMyelo.getCount)
'            UndoList.Push(ProMyelo.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(Blast.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'h' = Blast Cell ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            Blast.addToCount()
'            TxtBlast.Text = CStr(Blast.getCount)
'            UndoList.Push(Blast.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(ProNormo.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3,
'            AudioPlayMode.Background)
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            ProNormo.addToCount()
'            TxtProNormo.Text = CStr(ProNormo.getCount())
'            UndoList.Push(ProNormo.getCellType)
'        End If

'        If e.KeyChar = ChrW(NormoBlast.getKeyMap) Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'            AudioPlayMode.Background)
'            'MessageBox.Show("You pressed '/'  = seg ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            'Seg = Seg + 1
'            NormoBlast.addToCount()
'            'TxtSeg.Text = CStr(Seg)
'            TxtNormoBlast.Text = CStr(NormoBlast.getCount())
'            UndoList.Push(NormoBlast.getCellType)
'            'TxtInput.Text = ""
'        End If


'        If e.KeyChar = ChrW(User2.getKeyMap) And User2.getCellType <> "User2" Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'b' = band ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            User2.addToCount()
'            TxtUser2.Text = CStr(User2.getCount)
'            UndoList.Push(User2.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If e.KeyChar = ChrW(User3.getKeyMap) And User3.getCellType <> "User3" Then
'            My.Computer.Audio.Play(My.Resources.click3, _
'           AudioPlayMode.Background)
'            'MessageBox.Show("You pressed 'b' = band ")
'            Total = Total + 1
'            TxtTotal.Text = CStr(Total)
'            User3.addToCount()
'            TxtUser3.Text = CStr(User3.getCount)
'            UndoList.Push(User3.getCellType)
'            'TxtInput.Text = ""
'        End If

'        If Total = Count Then
'            PlaySound()
'            MessageBox.Show("Complete", "Total Count", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
'        End If


'        If Total > 0 Then

'            BtnChangeCount.Enabled = False
'        End If




'        'Count(TxtInput.Text)


'    End Sub






'    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click


'        BtnChangeCount.Enabled = True

'        Total = 0
'        'Seg = 0



'        Seg.ResetCount()
'        Lym.ResetCount()
'        Plasma.ResetCount()
'        Mono.ResetCount()
'        Eos.ResetCount()
'        Baso.ResetCount()
'        Band.ResetCount()
'        User1.ResetCount()
'        Meta.ResetCount()
'        Myelo.ResetCount()
'        ProMyelo.ResetCount()
'        Blast.ResetCount()
'        ProNormo.ResetCount()
'        NormoBlast.ResetCount()
'        User2.ResetCount()
'        User3.ResetCount()


'        TxtSeg.Clear()
'        TxtTotal.Clear()
'        TxtLym.Clear()
'        TxtPlasma.Clear()
'        TxtBand.Clear()
'        TxtEos.Clear()
'        TxtMono.Clear()
'        TxtBaso.Clear()
'        TxtMeta.Clear()
'        TxtPromyelo.Clear()
'        Txtmyelo.Clear()
'        TxtMono.Clear()
'        TxtBlast.Clear()
'        TxtUser1.Clear()
'        TxtUser2.Clear()
'        TxtUser3.Clear()
'        TxtProNormo.Clear()
'        TxtNormoBlast.Clear()




'    End Sub

'    Private Sub BtnChangeCount_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnChangeCount.Click

'        TxtChangeCount.ReadOnly = False

'        'MessageBox.Show("Please Enter a new count total below, press Done when finished.")

'        TxtChangeCount.Focus()



'        'Dim Input As String = ""
'        Dim Message As String = "Please enter a count between 20 and 500."
'        Dim Title As String = "Change Cell Count"
'        Dim DefaultValue As String = "100"


'        ' MessageBox.Show("Please enter a count between 20 and 500")

'        TxtChangeCount.Text = InputBox(Message, Title, DefaultValue) 'user input box.  File name and .txt is appended to string

'        'checks the value of the input
'        CheckCountInput()


'    End Sub


'    Sub CheckCountInput()

'        'Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click

'        TxtChangeCount.ReadOnly = True
'        Dim OK As Boolean = False


'        If IsNumeric(TxtChangeCount.Text) Then

'            If CInt(TxtChangeCount.Text) <= 500 And CInt(TxtChangeCount.Text) >= 20 Then
'                Count = CInt(TxtChangeCount.Text)
'                OK = True
'            Else
'                MessageBox.Show("please enter an Integer Between 20 and 500")
'                TxtChangeCount.Text = ("100")

'            End If
'        Else

'            MessageBox.Show("You entered a non-number, please enter an Integer")
'            TxtChangeCount.Text = ("100")
'        End If





'    End Sub


'    Private Sub BtnEditKeys_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditKeys.Click

'        KeyBind2.Show()
'        KeyBind2.Focus()



'    End Sub



'    Sub PlaySound()


'        If RadioButton1.Checked = True Then
'            'no sound

'        End If


'        If RadioButton2.Checked = True Then


'            My.Computer.Audio.Play(My.Resources.Regular_Ding, _
'            AudioPlayMode.Background)

'        End If


'        If RadioButton3.Checked = True Then

'            My.Computer.Audio.Play(My.Resources.Bomb, _
'            AudioPlayMode.Background)

'        End If


'        If RadioButton4.Checked = True Then

'            My.Computer.Audio.Play(My.Resources.robotic_voice, _
'            AudioPlayMode.Background)

'        End If





'        'My.Computer.Audio.Play(My.Resources.Regular_Ding, _
'        ' AudioPlayMode.Background)


'    End Sub

'    'taken from the google search.

'    Private Sub PeripheralForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


'        Dim result As DialogResult

'        result = MessageBox.Show("Are you sure you wish to close Bone Marrow Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

'        If result = Windows.Forms.DialogResult.Yes Then
'            e.Cancel = False
'            ' Me.Close()

'            Dim frm As Form
'            For Each frm In My.Application.OpenForms
'                frm.Show()
'            Next

'            MainForm.Show()
'        Else
'            e.Cancel = True
'        End If

'    End Sub



'    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

'        CloseProgram()

'    End Sub

'    Private Sub CloseProgram()
'        'see pg. 321 murach's VB 2010
'        Dim result As DialogResult

'        result = MessageBox.Show("Are you sure you wish to close Bone Marrow Counter?", "Close?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

'        'if no is selected then the program ends
'        If result = Windows.Forms.DialogResult.Yes Then
'            Me.Close()
'            MainForm.Show()

'            Dim frm As Form

'            For Each frm In My.Application.OpenForms
'                frm.Show()
'            Next


'        Else
'            Return
'        End If



'    End Sub


'    Private Sub BtnReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnReport.Click

'        Dim frm As Form

'        For Each frm In My.Application.OpenForms
'            If frm.Name = "FrmReport" Then
'                FrmReport.Close()
'                ' FrmReport.Show()
'                '  FrmReport.BtnCreate.PerformClick()
'                Exit For
'            End If
'        Next



'        FrmReport.Count = Count  'Still need this!
'        FrmReport.DiffType = 2
'        FrmReport.Show()
'        FrmReport.Focus()
'        '   FrmReport.StartReport()

'        'clicks the Create Report button on the report Form
'        FrmReport.BtnCreate.PerformClick()




'    End Sub



'    Private Sub Label13_Click(sender As Object, e As EventArgs)
'        FrmDeveloper.Show()
'    End Sub

'    Private Sub BtnUndo_Click(sender As Object, e As EventArgs) Handles BtnUndo.Click

'        Dim LastCountedCell As String


'        If Total > 0 Then
'            LastCountedCell = UndoList.Pop
'            If Seg.getCellType() = LastCountedCell Then
'                UndoCount(Seg)
'                TxtSeg.Text = CStr(Seg.getCount())
'            ElseIf Lym.getCellType() = LastCountedCell Then
'                UndoCount(Lym)
'                TxtLym.Text = CStr(Lym.getCount())
'            ElseIf Mono.getCellType() = LastCountedCell Then
'                UndoCount(Mono)
'                TxtPlasma.Text = CStr(Mono.getCount())
'            ElseIf Eos.getCellType() = LastCountedCell Then
'                UndoCount(Eos)
'                TxtBand.Text = CStr(Eos.getCount())
'            ElseIf Baso.getCellType() = LastCountedCell Then
'                UndoCount(Baso)
'                TxtEos.Text = CStr(Baso.getCount())
'            ElseIf Band.getCellType() = LastCountedCell Then
'                UndoCount(Band)
'                TxtMono.Text = CStr(Band.getCount())
'            ElseIf Meta.getCellType() = LastCountedCell Then
'                UndoCount(Meta)
'                TxtBaso.Text = CStr(Meta.getCount())
'            ElseIf Myelo.getCellType() = LastCountedCell Then
'                UndoCount(Myelo)
'                TxtMyelo.Text = CStr(Myelo.getCount())
'            ElseIf ProMyelo.getCellType() = LastCountedCell Then
'                UndoCount(ProMyelo)
'                TxtProMyelo.Text = CStr(ProMyelo.getCount())
'            ElseIf Blast.getCellType() = LastCountedCell Then
'                UndoCount(Blast)
'                TxtBlast.Text = CStr(Blast.getCount())
'            End If


'        End If


'        Me.Refresh()





'    End Sub

'    Private Sub UndoCount(cell As Cell)

'            Total = Total - 1
'            TxtTotal.Text = CStr(Total)
'            cell.UndoCount()


'    End Sub

'    Private Sub SetCountChannelLabels()

'        LblSeg.Text = Seg.getCellType()
'        LblLym.Text = Lym.getCellType()
'        LblPlasma.Text = Plasma.getCellType()
'        LblMono.Text = Mono.getCellType()
'        LblEos.Text = Eos.getCellType()
'        LblBaso.Text = Baso.getCellType()
'        LblBand.Text = Band.getCellType()
'        LblUser1.Text = User1.getCellType()
'        LblMeta.Text = Meta.getCellType()
'        LblMyelo.Text = Myelo.getCellType()
'        LblProMyelo.Text = Mid(ProMyelo.getCellType(), 1, 3)
'        LblBlast.Text = Blast.getCellType()
'        LblProNormo.Text = ProNormo.getCellType()
'        LblNormoBlast.Text = NormoBlast.getCellType()
'        LblUser2.Text = User2.getCellType()
'        LblUser3.Text = User3.getCellType()


'        Me.Refresh()

'    End Sub



'    Private Sub BoneMarrowForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
'        MainForm.LblActiveCounter2.Visible = False
'    End Sub

'    Private Sub LblSeg_Click(sender As Object, e As EventArgs) Handles LblSeg.Click
'        'Dim Input As String = ""
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Seg"

'        Seg.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblLym_Click(sender As Object, e As EventArgs) Handles LblLym.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Lym"

'        Lym.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblPlasma_Click(sender As Object, e As EventArgs) Handles LblPlasma.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Plasma"

'        Plasma.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblMono_Click(sender As Object, e As EventArgs) Handles LblMono.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Mono"

'        Mono.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblEos_Click(sender As Object, e As EventArgs) Handles LblEos.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Eos"

'        Eos.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblBaso_Click(sender As Object, e As EventArgs) Handles LblBaso.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Baso"

'        Baso.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblBand_Click(sender As Object, e As EventArgs) Handles LblBand.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Band"

'        Band.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblUser1_Click(sender As Object, e As EventArgs) Handles LblUser1.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "User1"

'        User1.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblMeta_Click(sender As Object, e As EventArgs) Handles LblMeta.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Meta"

'        Meta.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblMyelo_Click(sender As Object, e As EventArgs) Handles LblMyelo.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Myelo"

'        Myelo.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblProMyelo_Click(sender As Object, e As EventArgs) Handles LblProMyelo.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Pro"

'        ProMyelo.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblBlast_Click(sender As Object, e As EventArgs) Handles LblBlast.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "Blast"

'        Blast.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblProNormo_Click(sender As Object, e As EventArgs) Handles LblProNormo.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "ProNormo"

'        ProNormo.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblNormoBlast_Click(sender As Object, e As EventArgs) Handles LblNormoBlast.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "NormoBlast"

'        NormoBlast.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblUser2_Click(sender As Object, e As EventArgs) Handles LblUser2.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "User2"

'        User2.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub

'    Private Sub LblUser3_Click(sender As Object, e As EventArgs) Handles LblUser3.Click
'        Dim Message As String = "Please enter cell type."
'        Dim Title As String = "Change cell type"
'        Dim DefaultValue As String = "User3"

'        User3.ChangeCellType(InputBox(Message, Title, DefaultValue)) 'user input box.  File name and .txt is appended to string
'        SetCountChannelLabels()
'    End Sub
'End Class
