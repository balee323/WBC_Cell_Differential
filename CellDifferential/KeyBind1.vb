Partial Public Class KeyBind1

    Dim Keys As List(Of String)
    Dim savedSettings As Settings

    Private Sub KeyBind_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

        Keys = New List(Of String)


        Me.Label1.Text = AllCells.PeripheralCells(0).getCellType
        Me.Label2.Text = AllCells.PeripheralCells(1).getCellType
        Me.Label3.Text = AllCells.PeripheralCells(2).getCellType
        Me.Label4.Text = AllCells.PeripheralCells(3).getCellType
        Me.Label5.Text = AllCells.PeripheralCells(4).getCellType
        Me.Label6.Text = AllCells.PeripheralCells(5).getCellType
        Me.Label7.Text = AllCells.PeripheralCells(6).getCellType
        Me.Label8.Text = AllCells.PeripheralCells(7).getCellType
        Me.Label9.Text = AllCells.PeripheralCells(8).getCellType
        Me.Label10.Text = AllCells.PeripheralCells(9).getCellType
        Me.Label11.Text = AllCells.PeripheralCells(10).getCellType

        Me.TextBox1.Text = AllCells.PeripheralCells(0).getKeyMapChar()
        Me.TextBox2.Text = AllCells.PeripheralCells(1).getKeyMapChar()
        Me.TextBox3.Text = AllCells.PeripheralCells(2).getKeyMapChar()
        Me.TextBox4.Text = AllCells.PeripheralCells(3).getKeyMapChar()
        Me.TextBox5.Text = AllCells.PeripheralCells(4).getKeyMapChar()
        Me.TextBox6.Text = AllCells.PeripheralCells(5).getKeyMapChar()
        Me.TextBox7.Text = AllCells.PeripheralCells(6).getKeyMapChar()
        Me.TextBox8.Text = AllCells.PeripheralCells(7).getKeyMapChar()
        Me.TextBox9.Text = AllCells.PeripheralCells(8).getKeyMapChar()
        Me.TextBox10.Text = AllCells.PeripheralCells(9).getKeyMapChar()
        Me.TextBox11.Text = AllCells.PeripheralCells(10).getKeyMapChar()



        'for user defined stuff
        If AllCells.PeripheralCells.Count > 11 Then

        End If
        Me.Refresh()

        savedSettings = New Settings()



        ' MessageBox.Show(Settings.Key1)
        ' MessageBox.Show(savedSettings.exists.ToString)


    End Sub








    Private Sub BtnDone_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDone.Click

        savedSettings.CloseRegistry()
        Me.Close()

    End Sub




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Passed As Boolean = True


        Passed = Validation()

        If Passed = False Then
            Return
        End If


        AllCells.PeripheralCells(0).changeKeyMap(TextBox1.Text)
        AllCells.PeripheralCells(1).changeKeyMap(TextBox2.Text)
        AllCells.PeripheralCells(2).changeKeyMap(TextBox3.Text)
        AllCells.PeripheralCells(3).changeKeyMap(TextBox4.Text)
        AllCells.PeripheralCells(4).changeKeyMap(TextBox5.Text)
        AllCells.PeripheralCells(5).changeKeyMap(TextBox6.Text)
        AllCells.PeripheralCells(6).changeKeyMap(TextBox7.Text)
        AllCells.PeripheralCells(7).changeKeyMap(TextBox8.Text)
        AllCells.PeripheralCells(8).changeKeyMap(TextBox9.Text)
        AllCells.PeripheralCells(9).changeKeyMap(TextBox10.Text)
        AllCells.PeripheralCells(10).changeKeyMap(TextBox11.Text)

        savedSettings.SavePeripheralKeyBindings()

        'MessageBox.Show(TextBox1.Text)


        Me.Refresh()

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