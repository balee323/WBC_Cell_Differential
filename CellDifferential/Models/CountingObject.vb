Imports Newtonsoft.Json

<JsonObject(MemberSerialization.OptIn)>
Public Class CountingObject

    Public Sub New(countertype As CounterType)
        Me.CounterType = countertype
    End Sub

    <JsonProperty>
    Public Property Total As Integer


    Public Property UndoList As New Stack(Of Cell)

    <JsonProperty>
    Public Property Limit As Integer = 100


    <JsonProperty>
    Public Property CounterType As CounterType

End Class
