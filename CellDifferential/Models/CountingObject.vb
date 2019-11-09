Public Class CountingObject

    Public Property Total As Integer = 0
    Public Property UndoList As New Stack(Of Cell)
    Public Property Limit As Integer = 100

End Class
