

Imports Newtonsoft.Json

Public Class UserInfo

    Public Property UserName As String
    Public Property GivenName As String


End Class

<JsonObject(MemberSerialization.OptIn)>
Public Class UserCounterSettings

    <JsonProperty>
    Public Property PeripheralCells As List(Of CellSetting)

    <JsonProperty>
    Public Property BoneMarrowCells As List(Of CellSetting)

End Class

<JsonObject(MemberSerialization.OptIn)>
Public Class CellSetting

    <JsonProperty>
    Public Property CellType As String

    <JsonProperty>
    Public Property KeyMap As Integer

    <JsonProperty>
    Public Property Position As Integer

    <JsonProperty>
    Public Property File As String

    <JsonProperty>
    Public Property EnableInCounter As Boolean


End Class