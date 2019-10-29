Imports System.Windows.Forms.Form


Public Class Cell
    Private _CellType As String = ""
    Private _KeyMap As Integer = 0


    Private _ImageFile As String = ""
    Private _Count As Integer = 0
    '  Private isLastCounted As Boolean = False  'not sure if implementing this here is a smart idea
    Private _Position As Integer = 0

    Private _CellFormLabel As System.Windows.Forms.Label
    Private _CellFormTextBox As System.Windows.Forms.TextBox
    Private _UniqueID As Guid


    'constuctor
    Public Sub New(CellType As String, KeyMap As Integer, ImageFile As String, Position As Integer, CellFormLabel As System.Windows.Forms.Label, CellFormTextBox As System.Windows.Forms.TextBox)
        Me._CellType = CellType 'Seg, Lym, etc..
        Me._KeyMap = KeyMap
        Me._ImageFile = ImageFile
        Me._Position = Position 'sets position of the Cell on the counter
        Me._CellFormLabel = CellFormLabel
        Me._CellFormLabel.Name = CellType
        Me._CellFormTextBox = CellFormTextBox
        Me._UniqueID = New Guid()
    End Sub

    'constuctor
    'Public Sub New(CellType As String, KeyMap As String, ImageFile As String, Position As Integer)
    '    Me.CellType = CellType 'Seg, Lym, etc..
    '    Me.KeyMap = Asc(KeyMap) 'string to Ascii number
    '    Me.ImageFile = ImageFile
    '    Me.Position = Position 'sets position of the Cell on the counter
    'End Sub

    Public Function getCellType() As String
        Return _CellType
    End Function

    Public Function getCount() As Integer
        Return _Count
    End Function


    Public Function getKeyMap() As Integer
        Return _KeyMap
    End Function


    Public Function getKeyMapChar() As String
        Return ChrW(_KeyMap)
    End Function

    Public Function getPostion() As Integer
        Return _Position
    End Function


    Public Sub addToCount()
        _Count = _Count + 1
        _CellFormTextBox.Text = _Count.ToString()

    End Sub

    Public Sub UndoCount()
        _Count = _Count - 1
    End Sub


    Public Sub ResetCount()
        _Count = 0
    End Sub


    Public Sub changeKeyMap(Key As String)
        _KeyMap = Asc(Key)

    End Sub

    Public Sub changeKeyMap(Key As Integer)
        _KeyMap = Key

    End Sub


    Public Sub changeImage(ImageFile As String)
        Me._ImageFile = ImageFile
    End Sub

    Public Sub ChangeCellType(celltype As String)

        If celltype <> "" Then
            Me._CellType = celltype
            Me._CellFormLabel.Name = celltype
        Else
            MessageBox.Show("Cell Type cannot be blank")
            Return
        End If

    End Sub

    Public Sub SetLabelText()
        _CellFormLabel.Text = getCellType()
    End Sub

    Public Sub SetTextBoxValue()
        _CellFormTextBox.Text = getCount().ToString()
    End Sub

End Class
