Imports Newtonsoft.Json




Public Class Report

    Public Property ReportDate As DateTime

    Public Property PatientName As String

    Public Property PatientDOB As Date

    Public Property PatientID As String

    Public Property FacilityName As String

    Public Property UserName As String
    Public Property GivenName As String

    Public Property ReportDetails As ReportDetails

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

<JsonObject(MemberSerialization.OptIn)>
Public Class CellReportItem

    <JsonProperty>
    Public Property CellType As String

    <JsonProperty>
    Public Property Count As Integer
End Class

