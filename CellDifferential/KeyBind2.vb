Partial Public Class KeyBind2


    Dim Keys As List(Of String)
    Private _cells As List(Of Cell)
    Private _settings As ISettings
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

        Me.Label1.Text = _cells(0).getCellType
        Me.Label2.Text = _cells(1).getCellType
        Me.Label3.Text = _cells(2).getCellType
        Me.Label4.Text = _cells(3).getCellType
        Me.Label5.Text = _cells(4).getCellType
        Me.Label6.Text = _cells(5).getCellType
        Me.Label7.Text = _cells(6).getCellType
        Me.Label8.Text = _cells(7).getCellType
        Me.Label9.Text = _cells(8).getCellType
        Me.Label10.Text = _cells(9).getCellType
        Me.Label11.Text = _cells(10).getCellType
        Me.Label12.Text = _cells(11).getCellType
        Me.Label13.Text = _cells(12).getCellType
        Me.Label14.Text = _cells(13).getCellType
        Me.Label15.Text = _cells(14).getCellType
        Me.Label16.Text = _cells(15).getCellType

        Me.TextBox1.Text = _cells(0).getKeyMapChar()
        Me.TextBox2.Text = _cells(1).getKeyMapChar()
        Me.TextBox3.Text = _cells(2).getKeyMapChar()
        Me.TextBox4.Text = _cells(3).getKeyMapChar()
        Me.TextBox5.Text = _cells(4).getKeyMapChar()
        Me.TextBox6.Text = _cells(5).getKeyMapChar()
        Me.TextBox7.Text = _cells(6).getKeyMapChar()
        Me.TextBox8.Text = _cells(7).getKeyMapChar()
        Me.TextBox9.Text = _cells(8).getKeyMapChar()
        Me.TextBox10.Text = _cells(9).getKeyMapChar()
        Me.TextBox11.Text = _cells(10).getKeyMapChar()
        Me.TextBox12.Text = _cells(11).getKeyMapChar()
        Me.TextBox13.Text = _cells(12).getKeyMapChar()
        Me.TextBox14.Text = _cells(13).getKeyMapChar()
        Me.TextBox15.Text = _cells(14).getKeyMapChar()
        Me.TextBox16.Text = _cells(15).getKeyMapChar()

        Me.Refresh()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'reset cell key maps
        _cells(0).changeKeyMap("h")
        _cells(1).changeKeyMap("y")
        _cells(2).changeKeyMap("i")
        _cells(3).changeKeyMap("o")
        _cells(4).changeKeyMap("p")
        _cells(5).changeKeyMap("j")
        _cells(6).changeKeyMap("k")
        _cells(7).changeKeyMap("l")
        _cells(8).changeKeyMap(";")
        _cells(9).changeKeyMap("'")
        _cells(10).changeKeyMap("b")
        _cells(11).changeKeyMap("n")
        _cells(12).changeKeyMap("m")
        _cells(13).changeKeyMap(",")
        _cells(14).changeKeyMap(".")
        _cells(15).changeKeyMap("/")

        'refresh all textboxes
        Me.TextBox1.Text = _cells(0).getKeyMapChar()
        Me.TextBox2.Text = _cells(1).getKeyMapChar()
        Me.TextBox3.Text = _cells(2).getKeyMapChar()
        Me.TextBox4.Text = _cells(3).getKeyMapChar()
        Me.TextBox5.Text = _cells(4).getKeyMapChar()
        Me.TextBox6.Text = _cells(5).getKeyMapChar()
        Me.TextBox7.Text = _cells(6).getKeyMapChar()
        Me.TextBox8.Text = _cells(7).getKeyMapChar()
        Me.TextBox9.Text = _cells(8).getKeyMapChar()
        Me.TextBox10.Text = _cells(9).getKeyMapChar()
        Me.TextBox11.Text = _cells(10).getKeyMapChar()
        Me.TextBox12.Text = _cells(11).getKeyMapChar()
        Me.TextBox13.Text = _cells(12).getKeyMapChar()
        Me.TextBox14.Text = _cells(13).getKeyMapChar()
        Me.TextBox15.Text = _cells(14).getKeyMapChar()
        Me.TextBox16.Text = _cells(15).getKeyMapChar()

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
        Dim Passed As Boolean = True

        Passed = Validation()

        If Passed = False Then
            Return
        End If

        _cells(0).changeKeyMap(TextBox1.Text)
        _cells(1).changeKeyMap(TextBox2.Text)
        _cells(2).changeKeyMap(TextBox3.Text)
        _cells(3).changeKeyMap(TextBox4.Text)
        _cells(4).changeKeyMap(TextBox5.Text)
        _cells(5).changeKeyMap(TextBox6.Text)
        _cells(6).changeKeyMap(TextBox7.Text)
        _cells(7).changeKeyMap(TextBox8.Text)
        _cells(8).changeKeyMap(TextBox9.Text)
        _cells(9).changeKeyMap(TextBox10.Text)
        _cells(10).changeKeyMap(TextBox11.Text)
        _cells(11).changeKeyMap(TextBox12.Text)
        _cells(12).changeKeyMap(TextBox13.Text)
        _cells(13).changeKeyMap(TextBox14.Text)
        _cells(14).changeKeyMap(TextBox15.Text)
        _cells(15).changeKeyMap(TextBox16.Text)

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
                j = j + 1
            End While
            i = i + 1
        End While


        Return Status
    End Function

End Class