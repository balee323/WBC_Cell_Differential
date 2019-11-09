Partial Public Class KeyBind

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


    Private Sub KeyBind_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

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



        'for user defined stuff
        If _cells.Count > 11 Then

        End If
        Me.Refresh()

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

        _settings.SaveSettings()

        'MessageBox.Show(TextBox1.Text)


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
        End If


        Dim i As Integer = 0
        While i < Keys.Count
            Dim j As Integer = 1
            While j < Keys.Count
                ' MessageBox.Show(Keys(i) & " " & Keys(j))
                If Keys(i).Equals(Keys(j)) And i <> j Then
                    MessageBox.Show("Duplicate Key Assignments Found")
                    Status = False
                    Return Status
                    ' Exit Function
                End If
                j = j + 1
            End While
            i = i + 1
        End While


        Return Status
    End Function


End Class