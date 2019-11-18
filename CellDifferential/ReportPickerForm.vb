Imports System.ComponentModel
Imports Newtonsoft.Json
Imports NLog

Public Class ReportPickerForm

    Private _reports As New List(Of Report)
    Private _sortOrder As Integer = 0
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()

    Private Sub ReportPickerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'testing
            LoadInitialReports() 'Maybe Load last 15 reports?

        Catch ex As Exception
            _logger.Error(ex)
        End Try


    End Sub

    Private Sub LoadInitialReports()
        Dim repo As IDataRepo = New SqlLiteManager()
        Dim reportsStr = repo.LoadReports(Nothing)

        ParseAndLoadReports(reportsStr)

        DataGridView1.MultiSelect = False
        DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.ReportDate).ToList()

    End Sub

    Private Sub ParseAndLoadReports(reportsStr As List(Of String))

        _reports.Clear()

        For Each reportStr In reportsStr

            Dim parts = reportStr.Split("|"c)

            Dim report = New Report()

            report.UserName = parts(1)
            report.GivenName = parts(2)

            report.PatientID = parts(3)
            report.PatientName = parts(4)
            report.PatientDOB = (CType(parts(5), Date)).Date
            report.FacilityName = parts(6)
            report.CounterType.TryParse(parts(7), ignoreCase:=True, report.CounterType)
            report.ReportDetails = JsonConvert.DeserializeObject(Of ReportDetails)(parts(8))
            report.ReportDate = CType(parts(9), DateTime)

            '0 ReportID UNIQUEIDENTIFIER Not NULL PRIMARY KEY,
            '1 UserName VarChar(50), 
            '2 GivenName VarChar(50), 
            '3 PatientID VarChar(50), 
            '4 PatientName VarChar(100), 
            '5 PatientDOB DateTime2(2), 
            '6 FacilityName VarChar(50),
            '7 CounterType VarChar(50),
            '8 ReportDetailsJson VarChar(5000), 
            '9 DateCreated DateTime2(3),
            '10 DateModified DateTime2(3)


            _reports.Add(report)
        Next
    End Sub



    Private Sub BtnOpen_Click(sender As Object, e As EventArgs) Handles BtnOpen.Click

        If DataGridView1.SelectedRows.Count > 0 Then
            Dim report = CType(DataGridView1.CurrentRow.DataBoundItem, Report)

            Dim reportForm As New ReportForm(report)
            reportForm.Show()
            Me.Close()

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

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        LoadInitialReports()
    End Sub

    Private Sub BtnOpenReport_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ChkBoxIncludeDate_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

        'run search on Database, return results and set new datasource value

        Dim searchFilter = New SearchFilter()

        If RadioPatientID.Checked Then
            searchFilter.SearchPatientID = True
            searchFilter.Report.PatientID = TxtBoxSearch.Text
        ElseIf RadioPatientName.Checked Then
            searchFilter.SearchPatientName = True
            searchFilter.Report.PatientName = TxtBoxSearch.Text
        ElseIf RadioPatientDOB.Checked Then
            searchFilter.SearchPatientDOB = True
            searchFilter.Report.PatientDOB = DateTimePatientDOB.Value.Date
        ElseIf RadioTechName.Checked Then
            searchFilter.SearchUserName = True
            searchFilter.UserInfo.UserName = TxtBoxSearch.Text
            searchFilter.UserInfo.GivenName = TxtBoxSearch.Text
        ElseIf ChkboxBegin.Checked Then
            searchFilter.SearchBeginDate = True
            searchFilter.BeginDate = DateTimeBegin.Value.Date
        ElseIf ChkboxEnd.Checked Then
            searchFilter.SearchEndDate = True
            searchFilter.EndDate = DateTimeEnd.Value.Date
        End If


        'validations
        If (searchFilter.BeginDate > DateTime.Today) Or (searchFilter.EndDate > DateTime.Today) Then
            MessageBox.Show("Search Dates cannot be in the future.")
            Return
        End If

        'validations
        If (searchFilter.Report.PatientDOB > DateTime.Today) Then
            MessageBox.Show("This person hasn't been born yet!.")
            Return
        End If



        'Validations
        If ChkboxBegin.Checked And ChkboxEnd.Checked Then
            If searchFilter.EndDate < searchFilter.BeginDate Then
                MessageBox.Show("End Date cannot be less than begin date.")
                Return
                'ElseIf searchFilter.BeginDate > searchFilter.EndDate Then
                '    MessageBox.Show("Begin Date cannot be greater than end date.")
                '    Return
            End If
        End If




        Dim repo As IDataRepo = New SqlLiteManager()
        Dim reportsStr = repo.LoadReports(searchFilter)
        ParseAndLoadReports(reportsStr)

        DataGridView1.MultiSelect = False
        DataGridView1.DataSource = _reports.OrderByDescending(Function(s) s.ReportDate).ToList()

    End Sub

    Private Sub RadioPatientDOB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioPatientDOB.CheckedChanged

        If RadioPatientDOB.Checked Then
            DateTimePatientDOB.Enabled = True
        Else
            DateTimePatientDOB.Enabled = False
        End If


    End Sub

    Private Sub ChkboxBegin_CheckedChanged(sender As Object, e As EventArgs) Handles ChkboxBegin.CheckedChanged

        If ChkboxBegin.Checked Then
            DateTimeBegin.Enabled = True
        Else
            DateTimeBegin.Enabled = False
        End If

    End Sub

    Private Sub ChkboxEnd_CheckedChanged(sender As Object, e As EventArgs) Handles ChkboxEnd.CheckedChanged

        If ChkboxEnd.Checked Then
            DateTimeEnd.Enabled = True
        Else
            DateTimeEnd.Enabled = False
        End If

    End Sub
End Class