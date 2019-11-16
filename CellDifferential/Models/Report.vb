Imports Newtonsoft.Json


Public Class ReportHeader

    Public Property ReportDate As DateTime

    Public Property PatientName As String

    Public Property PatientDOB As DateTime

    Public Property PatientID As String

    Public Property FacilityName As String

End Class


<JsonObject(MemberSerialization.OptIn)>
Public Class ReportDetails

    <JsonProperty>
    Public Property CountingObject As CountingObject

    <JsonProperty>
    Public Property CellReportItems As List(Of CellReportItem)

    <JsonProperty>
    Public Property CellMorphology As String

    <JsonProperty>
    Public Property OtherFindings As String

End Class

Public Class CellReportItem
    Public Property CellType As String
    Public Property Count As Integer
End Class

