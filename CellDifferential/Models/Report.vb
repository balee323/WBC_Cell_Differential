Imports Newtonsoft.Json
Imports WBCDifferential

Public Class Report

    Public Property ReportDate As DateTime

    Public Property PatientName As String

    Public Property PatientDOB As Date

    Public Property PatientID As String

    Public Property FacilityName As String

    Public Property UserName As String

    Public Property GivenName As String

    Public Property ReportDetails As ReportDetails

    Public Property CounterType As CounterType

End Class


<JsonObject(MemberSerialization.OptIn)>
Public Class ReportDetails

    <JsonProperty>
    Public Property CountingObject As CountingObject

    <JsonProperty>
    Public Property CellReportItems As List(Of ReportCell)

    <JsonProperty>
    Public Property CellMorphology As String

    <JsonProperty>
    Public Property OtherFindings As String

End Class

<JsonObject(MemberSerialization.OptIn)>
Public Class ReportCell : Implements IReportCell

    <JsonProperty>
    Public Property CellType As String Implements IReportCell.CellType

    <JsonProperty>
    Public Property Count As Integer Implements IReportCell.Count

    <JsonProperty>
    Public Property EncludeInReport As Boolean Implements IReportCell.EncludeInReport


End Class

