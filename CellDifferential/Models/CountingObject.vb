Public Class CountingObject

    Public Sub New(countertype As CounterType)
        Me.CounterType = countertype
    End Sub

    Public Property Total As Integer = 0
    Public Property UndoList As New Stack(Of Cell)
    Public Property Limit As Integer = 100

    Public Property CounterType As CounterType

End Class
