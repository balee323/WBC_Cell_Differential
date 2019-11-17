Imports System.ComponentModel
Imports Newtonsoft.Json

Public Class ReportPickerForm

    Private _reports As New List(Of Report)
    Private _sortOrder As Integer = 0

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
            report.FacilityName = parts(6)
            report.ReportDetails = JsonConvert.DeserializeObject(Of ReportDetails)(parts(7))
            report.ReportDate = CType(parts(8), DateTime)

            '0 ReportID UNIQUEIDENTIFIER Not NULL PRIMARY KEY,
            '1 UserName VarChar(50), 
            '2 GivenName VarChar(50), 
            '3 PatientID VarChar(50), 
            '4 PatientName VarChar(100), 
            '5 PatientDOB DateTime2(2), 
            '6 FacilityName VarChar(50),
            '7 ReportDetailsJson VarChar(5000), 
            '8 DateCreated DateTime2(3),
            '9 DateModified DateTime2(3)


            _reports.Add(report)
        Next


    End Sub

    Private Sub ReportPickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'testing
        LoadReports()

        DataGridView1.MultiSelect = False
        DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.ReportDate).ToList()



    End Sub


    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim report = CType(DataGridView1.CurrentRow.DataBoundItem, Report)

            Dim reportForm As New ReportForm()
            reportForm.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.ColumnHeaderMouseClick

        Dim gridView = CType(sender, System.Windows.Forms.DataGridView)

        Dim column As DataGridViewColumn = DataGridView1.Columns(e.ColumnIndex)
        ' Dim oldColumn As DataGridViewColumn = DataGridView1.SortedColumn

        If (_sortOrder = 1) Then
            If (column.DataPropertyName = "ReportDate") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.ReportDate).ToList()
            ElseIf (column.DataPropertyName = "PatientName") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.PatientName).ToList()
            ElseIf (column.DataPropertyName = "PatientDOB") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.PatientDOB).ToList()
            ElseIf (column.DataPropertyName = "PatientID") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.PatientID).ToList()
            ElseIf (column.DataPropertyName = "UserName") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.UserName).ToList()
            ElseIf (column.DataPropertyName = "FacilityName") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.FacilityName).ToList()
            ElseIf (column.DataPropertyName = "GivenName") Then
                DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.GivenName).ToList()
            End If

            _sortOrder = 2
        Else

            If (column.DataPropertyName = "ReportDate") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.ReportDate).ToList()
            ElseIf (column.DataPropertyName = "PatientName") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.PatientName).ToList()
            ElseIf (column.DataPropertyName = "PatientDOB") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.PatientDOB).ToList()
            ElseIf (column.DataPropertyName = "PatientID") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.PatientID).ToList()
            ElseIf (column.DataPropertyName = "UserName") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.UserName).ToList()
            ElseIf (column.DataPropertyName = "FacilityName") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.FacilityName).ToList()
            ElseIf (column.DataPropertyName = "GivenName") Then
                DataGridView1.DataSource = _reports.OrderBy(Function(s) s.GivenName).ToList()
            End If

            _sortOrder = 1
        End If

    End Sub

End Class