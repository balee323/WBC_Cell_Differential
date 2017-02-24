Public Class Cell
    Private CellType As String = ""
    Private KeyMap As Integer = 0

    
    Private ImageFile As String = ""
    Private Count As Integer = 0
    '  Private isLastCounted As Boolean = False  'not sure if implementing this here is a smart idea
    Private Position As Integer = 0

    'constuctor
    Public Sub New(CellType As String, KeyMap As Integer, ImageFile As String, Position As Integer)
        Me.CellType = CellType 'Seg, Lym, etc..
        Me.KeyMap = KeyMap
        Me.ImageFile = ImageFile
        Me.Position = Position 'sets position of the Cell on the counter
    End Sub

    'constuctor
    Public Sub New(CellType As String, KeyMap As String, ImageFile As String, Position As Integer)
        Me.CellType = CellType 'Seg, Lym, etc..
        Me.KeyMap = Asc(KeyMap) 'string to Ascii number
        Me.ImageFile = ImageFile
        Me.Position = Position 'sets position of the Cell on the counter
    End Sub

    Public Function getCellType() As String
        Return CellType
    End Function

    Public Function getCount() As Integer
        Return Count
    End Function


    Public Function getKeyMap() As Integer
        Return KeyMap
    End Function


    Public Function getKeyMapChar() As String
        Return ChrW(KeyMap)
    End Function

    Public Function getPostion() As Integer
        Return Position
    End Function


    Public Sub addToCount()
        Count = Count + 1
    End Sub

    Public Sub UndoCount()
        Count = Count - 1
    End Sub


    Public Sub ResetCount()
        Count = 0
    End Sub


    Public Sub changeKeyMap(Key As String)
        KeyMap = Asc(Key)

    End Sub

    Public Sub changeKeyMap(Key As Integer)
        KeyMap = Key

    End Sub


    Public Sub changeImage(ImageFile As String)
        Me.ImageFile = ImageFile
    End Sub

    Public Sub ChangeCellType(celltype As String)

        If celltype <> "" Then
            Me.CellType = celltype
        Else
            MessageBox.Show("Cell Type cannot be blank")
            Return
        End If

    End Sub

End Class
