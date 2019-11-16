Imports Newtonsoft.Json

Public Class ReportPickerForm

    Private _reports As New List(Of Report)

    Private Sub LoadReports()
        Dim repo As IDataRepo = New SqlLiteManager()
        Dim reportsStr = repo.LoadReports(Nothing)

        For Each reportStr In reportsStr

            Dim parts = reportStr.Split("|"c)

            Dim report = New Report()

            report.UserName = parts(1)
            report.GivenName = parts(2)

            report.PatientID = parts(3)
            report.PatientName = parts(4)
            report.PatientDOB = (CType(parts(5), Date)).Date
            report.ReportDate = CType(parts(7), DateTime)

            report.ReportDetails = JsonConvert.DeserializeObject(Of ReportDetails)(parts(6))

            '0 ReportID UNIQUEIDENTIFIER Not NULL PRIMARY KEY,
            '1 UserName VarChar(50), 
            '2 GivenName VarChar(50), 
            '3 PatientID VarChar(50), 
            '4 PatientName VarChar(100), 
            '5 PatientDOB DateTime2(2), 
            '6 ReportDetailsJson VarChar(5000), 
            '7 DateCreated DateTime2(3),
            '8 DateModified DateTime2(3)

            _reports.Add(report)
        Next


    End Sub

    Private Sub ReportPickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'testing
        LoadReports()

        DataGridView1.MultiSelect = False
        DataGridView1.DataSource = _reports

    End Sub


    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim report = CType(DataGridView1.CurrentRow.DataBoundItem, Report)

            Dim reportForm As New ReportForm()
            reportForm.Show()
            Me.Hide()

        End If

    End Sub
End Class