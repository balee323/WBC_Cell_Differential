Partial Public Class KeyBind2


    Dim Keys As List(Of String)
    Private _cells As List(Of Cell)
#Disable Warning IDE0044 ' Add readonly modifier
    Private _settings As ISettings
#Enable Warning IDE0044 ' Add readonly modifier
    Private _refreshCellModules As Action


    Public Sub New(cells As List(Of Cell), settings As ISettings, refreshCellModules As Action)

        _cells = cells
        _settings = settings
        _refreshCellModules = refreshCellModules

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub KeyBind2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Keys = New List(Of String)

        Me.Label1.Text = _cells(0).GetCellType
        Me.Label2.Text = _cells(1).GetCellType
        Me.Label3.Text = _cells(2).GetCellType
        Me.Label4.Text = _cells(3).GetCellType
        Me.Label5.Text = _cells(4).GetCellType
        Me.Label6.Text = _cells(5).GetCellType
        Me.Label7.Text = _cells(6).GetCellType
        Me.Label8.Text = _cells(7).GetCellType
        Me.Label9.Text = _cells(8).GetCellType
        Me.Label10.Text = _cells(9).GetCellType
        Me.Label11.Text = _cells(10).GetCellType
        Me.Label12.Text = _cells(11).GetCellType
        Me.Label13.Text = _cells(12).GetCellType
        Me.Label14.Text = _cells(13).GetCellType
        Me.Label15.Text = _cells(14).GetCellType
        Me.Label16.Text = _cells(15).GetCellType

        Me.TextBox1.Text = _cells(0).GetKeyMapChar()
        Me.TextBox2.Text = _cells(1).GetKeyMapChar()
        Me.TextBox3.Text = _cells(2).GetKeyMapChar()
        Me.TextBox4.Text = _cells(3).GetKeyMapChar()
        Me.TextBox5.Text = _cells(4).GetKeyMapChar()
        Me.TextBox6.Text = _cells(5).GetKeyMapChar()
        Me.TextBox7.Text = _cells(6).GetKeyMapChar()
        Me.TextBox8.Text = _cells(7).GetKeyMapChar()
        Me.TextBox9.Text = _cells(8).GetKeyMapChar()
        Me.TextBox10.Text = _cells(9).GetKeyMapChar()
        Me.TextBox11.Text = _cells(10).GetKeyMapChar()
        Me.TextBox12.Text = _cells(11).GetKeyMapChar()
        Me.TextBox13.Text = _cells(12).GetKeyMapChar()
        Me.TextBox14.Text = _cells(13).GetKeyMapChar()
        Me.TextBox15.Text = _cells(14).GetKeyMapChar()
        Me.TextBox16.Text = _cells(15).GetKeyMapChar()

        Me.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'reset cell key maps
        _cells(0).ChangeKeyMap("h")
        _cells(1).ChangeKeyMap("y")
        _cells(2).ChangeKeyMap("i")
        _cells(3).ChangeKeyMap("o")
        _cells(4).ChangeKeyMap("p")
        _cells(5).ChangeKeyMap("j")
        _cells(6).ChangeKeyMap("k")
        _cells(7).ChangeKeyMap("l")
        _cells(8).ChangeKeyMap(";")
        _cells(9).ChangeKeyMap("'")
        _cells(10).ChangeKeyMap("b")
        _cells(11).ChangeKeyMap("n")
        _cells(12).ChangeKeyMap("m")
        _cells(13).ChangeKeyMap(",")
        _cells(14).ChangeKeyMap(".")
        _cells(15).ChangeKeyMap("/")

        'refresh all textboxes
        Me.TextBox1.Text = _cells(0).GetKeyMapChar()
        Me.TextBox2.Text = _cells(1).GetKeyMapChar()
        Me.TextBox3.Text = _cells(2).GetKeyMapChar()
        Me.TextBox4.Text = _cells(3).GetKeyMapChar()
        Me.TextBox5.Text = _cells(4).GetKeyMapChar()
        Me.TextBox6.Text = _cells(5).GetKeyMapChar()
        Me.TextBox7.Text = _cells(6).GetKeyMapChar()
        Me.TextBox8.Text = _cells(7).GetKeyMapChar()
        Me.TextBox9.Text = _cells(8).GetKeyMapChar()
        Me.TextBox10.Text = _cells(9).GetKeyMapChar()
        Me.TextBox11.Text = _cells(10).GetKeyMapChar()
        Me.TextBox12.Text = _cells(11).GetKeyMapChar()
        Me.TextBox13.Text = _cells(12).GetKeyMapChar()
        Me.TextBox14.Text = _cells(13).GetKeyMapChar()
        Me.TextBox15.Text = _cells(14).GetKeyMapChar()
        Me.TextBox16.Text = _cells(15).GetKeyMapChar()

        _settings.SaveSettings()

        Me.Refresh()
        _refreshCellModules()
        Me.Focus()

    End Sub



    Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click

        _refreshCellModules()
        Me.Focus()
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim Passed = Validation()

        If Passed = False Then
            Return
        End If

        _cells(0).ChangeKeyMap(TextBox1.Text)
        _cells(1).ChangeKeyMap(TextBox2.Text)
        _cells(2).ChangeKeyMap(TextBox3.Text)
        _cells(3).ChangeKeyMap(TextBox4.Text)
        _cells(4).ChangeKeyMap(TextBox5.Text)
        _cells(5).ChangeKeyMap(TextBox6.Text)
        _cells(6).ChangeKeyMap(TextBox7.Text)
        _cells(7).ChangeKeyMap(TextBox8.Text)
        _cells(8).ChangeKeyMap(TextBox9.Text)
        _cells(9).ChangeKeyMap(TextBox10.Text)
        _cells(10).ChangeKeyMap(TextBox11.Text)
        _cells(11).ChangeKeyMap(TextBox12.Text)
        _cells(12).ChangeKeyMap(TextBox13.Text)
        _cells(13).ChangeKeyMap(TextBox14.Text)
        _cells(14).ChangeKeyMap(TextBox15.Text)
        _cells(15).ChangeKeyMap(TextBox16.Text)

        _settings.SaveSettings()

        Me.Refresh()
        _refreshCellModules()
        Me.Focus()

    End Sub

    Private Function Validation() As Boolean

        Keys.Clear()

        Keys.Add(TextBox1.Text)
        Keys.Add(TextBox2.Text)
        Keys.Add(TextBox3.Text)
        Keys.Add(TextBox4.Text)
        Keys.Add(TextBox5.Text)
        Keys.Add(TextBox6.Text)
        Keys.Add(TextBox7.Text)
        Keys.Add(TextBox8.Text)
        Keys.Add(TextBox9.Text)
        Keys.Add(TextBox10.Text)
        Keys.Add(TextBox11.Text)
        Keys.Add(TextBox12.Text)
        Keys.Add(TextBox13.Text)
        Keys.Add(TextBox14.Text)
        Keys.Add(TextBox15.Text)
        Keys.Add(TextBox16.Text)

        Dim Status As Boolean = True

        If TextBox1.Text.Length < 1 Or TextBox1.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox2.Text.Length < 1 Or TextBox2.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox3.Text.Length < 1 Or TextBox3.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox4.Text.Length < 1 Or TextBox4.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox5.Text.Length < 1 Or TextBox5.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox6.Text.Length < 1 Or TextBox6.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox7.Text.Length < 1 Or TextBox7.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox8.Text.Length < 1 Or TextBox8.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox9.Text.Length < 1 Or TextBox9.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox10.Text.Length < 1 Or TextBox10.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox11.Text.Length < 1 Or TextBox11.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox12.Text.Length < 1 Or TextBox12.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox13.Text.Length < 1 Or TextBox13.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox14.Text.Length < 1 Or TextBox14.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox15.Text.Length < 1 Or TextBox15.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        ElseIf TextBox16.Text.Length < 1 Or TextBox16.Text.Length > 1 Then
            MessageBox.Show("You can only Enter 1 character and cannot be null.")
            Status = False
        End If


        Dim i As Integer = 0
        While i < Keys.Count
            Dim j As Integer = 1
            While j < Keys.Count
                If Keys(i).Equals(Keys(j)) And i <> j Then
                    MessageBox.Show("Duplicate Key Assignments Found")
                    Status = False
                    Return Status
                    'exit while (exit inner while)
                End If
                j += 1
            End While
            i += 1
        End While


        Return Status
    End Function

End Class