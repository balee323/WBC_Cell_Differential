Imports System.Drawing.Printing
Imports System.Text
Imports Newtonsoft.Json
Imports NLog
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout
Imports PdfSharp.Pdf


Public Class ReportForm

    Private _reportCells As List(Of IReportCell)
    Private _settings As ISettings
    Private _countingObject As CountingObject
    Private _excludeUserCell As Boolean = False
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _reportBuilder As New StringBuilder()
    Private _report As Report
    Private _isLoadedReport As Boolean = False

    'need an event to handle print
#Disable Warning IDE1006 ' Naming Styles
    Private WithEvents _docToPrint As New PrintDocument
#Enable Warning IDE1006 ' Naming Styles


    Public Sub New(cells As List(Of Cell), settings As ISettings, counteringObject As CountingObject)


        Dim reportCells As IEnumerable(Of IReportCell)
        reportCells = cells

        Me._reportCells = reportCells.ToList
        Me._settings = settings
        Me._countingObject = counteringObject
        Me._reportBuilder = New StringBuilder()


        ' This call is required by the designer.
        InitializeComponent()

        RichTextBox1.ReadOnly = True
        DisableButtons()
        PatientInputPanel.Show()


        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Public Sub New(report As Report)

        Me._isLoadedReport = True
        Me._report = report
        Dim tempIenum As IEnumerable(Of IReportCell) = report.ReportDetails.CellReportItems
        _reportCells = tempIenum.ToList()
        Me._countingObject = report.ReportDetails.CountingObject


        InitializeComponent()

        DisableButtons()
        PatientInputPanel.Hide()

        RichTextBox1.ReadOnly = True
        GenerateReport(True)



        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub BtnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        DisableButtons()

        Try

            Dim printDialog = New PrintDialog()
            printDialog.Document = _docToPrint
            printDialog.AllowSomePages = True

            If printDialog.ShowDialog = DialogResult.OK Then
                _docToPrint.PrinterSettings = printDialog.PrinterSettings
                _docToPrint.DefaultPageSettings.Margins = New Margins(20, 10, 10, 20)
                _docToPrint.Print() 'creates print event
            End If

        Catch ex As Exception
            _logger.Error(ex)
            MessageBox.Show("Couldn't save file, file in use.")
            EnableButtons()
        End Try

        EnableButtons()

    End Sub


    'Handles Print Event
    Private Sub PrintEventHandler(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles _docToPrint.PrintPage

        Dim printFont As Font = New Font("Courier New", 11, GraphicsUnit.Point)
        'Dim printFont As New Font("Courier New", 10, System.Drawing.FontStyle.Regular)

        e.Graphics.DrawString(_reportBuilder.ToString(), printFont, Brushes.Black, e.MarginBounds)

        EnableButtons()

    End Sub


    Private Sub BtnCloseReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseReport.Click
        Me.Close()
    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReport.Click
        DisableButtons()
        PatientInputPanel.Show()

    End Sub

    Private Sub GenerateReport(Optional loadedReport As Boolean = False)

        RichTextBox1.Clear()
        _reportBuilder.Clear()

        'Set current Date
        Dim Today As String = CStr(DateAndTime.Now)

        Dim facilityName, patientName, patientID, otherfindings, rBCMorph As String
        Dim patientDOB As Date


        If (loadedReport) Then
            facilityName = _report.FacilityName
            patientName = _report.PatientName
            patientID = _report.PatientID
            patientDOB = _report.PatientDOB
            otherfindings = _report.ReportDetails.OtherFindings
            rBCMorph = _report.ReportDetails.CellMorphology
        Else
            facilityName = TxtFacilityName.Text
            patientName = TxtPatientName.Text
            patientID = TxtPatientId.Text
            patientDOB = DateTimePatientDOB.Value.Date
            otherfindings = TxtOtherFindings.Text
            rBCMorph = TxtRBCMorph.Text
        End If

        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine("Patient Information - " + "Name: " + patientName & " | ID: " & patientID & " | DOB: " & patientDOB)
        _reportBuilder.AppendLine("Date: " + Today)
        _reportBuilder.AppendLine("Facility: " + facilityName)
        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Blood Cell Manual - " & _countingObject?.CounterType.ToString())
        _reportBuilder.AppendLine("Total Cells Counted: " & _countingObject?.Total)
        _reportBuilder.AppendLine("")


        'Percentages need to be formatted
        'Good Info to Have!!  {column, (- left align)spacing}  
        Dim ColumnSpacing1 As String = "{0, -15}{1, -10}{2, -1}"

        _reportBuilder.AppendFormat(ColumnSpacing1, "Cell Type", "Count", "Percentage")
        _reportBuilder.AppendLine()

        Dim ColumnSpacing2 As String = "{0, -15}{1, -10}{2, -1}{3, -2}"
        'I guess I was excluding these for some reason?
        Dim i As Integer = 0

        While i < _reportCells?.Count
                If Not _reportCells(i).CellType.Contains("User") And _reportCells(i).EncludeInReport Then
                    _reportBuilder.AppendFormat(ColumnSpacing2, _reportCells(i).CellType, _reportCells(i).Count, GetPercent(_reportCells(i).Count), " %")
                    _reportBuilder.AppendLine()
                End If
                i += 1
            End While

        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Red Cell morphology:")
        _reportBuilder.AppendLine(rBCMorph)
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Other Findings:")
        _reportBuilder.AppendLine(otherfindings)
        _reportBuilder.AppendLine("===================================================================")

        RichTextBox1.Text = _reportBuilder.ToString()

        EnableButtons()

    End Sub

    Private Function GetPercent(number As Integer) As Double
        Dim percent As Double

        If (number < 1) Then
            Return 0.0
        End If
        percent = number / _countingObject.Total * 100

        Return percent

    End Function


    Private Sub BtnGenPDF_Click(sender As Object, e As EventArgs) Handles BtnGenPDF.Click

        Try

            Dim reportStr = _reportBuilder.ToString()


            If (String.IsNullOrWhiteSpace(reportStr)) Then
                MessageBox.Show("Empty report, please generate a report.", "PDF Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If


            Dim document As PdfDocument = New PdfDocument()
            document.Info.Title = $"Patient_Report_{DateTime.Now.ToString("MMddyyyy_hhmmsssss")}"

            Dim page As PdfPage = document.AddPage()

            Dim gfx = XGraphics.FromPdfPage(page)
            Dim font = New XFont("Courier New", 10, XFontStyle.Bold)
            Dim tf As XTextFormatter = New XTextFormatter(gfx)
            Dim rect = New XRect(20, 20, 500, 1000)

            tf.DrawString(reportStr, font, XBrushes.Black, rect, XStringFormats.TopLeft)

            Dim fileName = GetPDFSaveFileName(document.Info.Title)

            If (String.IsNullOrWhiteSpace(fileName)) Then
                Return
            End If

            document.Save(fileName)

            Process.Start(fileName)

        Catch ex As Exception
            _logger.Error(ex)
            If ex.Message.ToLower().Contains("open") Then
                MessageBox.Show("Couldn't save file, file in use.")
            End If


            EnableButtons()
        End Try

    End Sub


    Private Function GetPDFSaveFileName(suggestedName As String) As String
        Dim fd As SaveFileDialog = New SaveFileDialog()
        Dim strFileName As String = ""

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) 'look at _userSettings to see what the common used location is
        fd.Filter = "(*.pdf)|*.pdf"
        fd.FileName = suggestedName
        fd.FilterIndex = 1
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            strFileName = fd.FileName
        End If

        Return strFileName

    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PatientInputPanel.Hide()
        GenerateReport()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TxtFacilityName.Click
        TxtFacilityName.Clear()
    End Sub

    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TxtPatientId.Click
        TxtPatientId.Clear()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TxtPatientName.Click
        TxtPatientName.Clear()
    End Sub

    Private Sub DisableButtons()

        BtnSaveToDB.BackColor = SystemColors.GrayText
        BtnPrint.BackColor = SystemColors.GrayText
        BtnGenPDF.BackColor = SystemColors.GrayText
        BtnNewReport.BackColor = SystemColors.GrayText

        BtnPrint.Enabled = False
        BtnGenPDF.Enabled = False
        BtnNewReport.Enabled = False
        BtnSaveToDB.Enabled = False


    End Sub

    Private Sub EnableButtons()

        If _isLoadedReport Then
            BtnPrint.BackColor = System.Drawing.Color.LightSteelBlue
            BtnGenPDF.BackColor = System.Drawing.Color.LightSteelBlue
            BtnPrint.Enabled = True
            BtnGenPDF.Enabled = True
        Else
            BtnSaveToDB.BackColor = System.Drawing.Color.LightSteelBlue
            BtnPrint.BackColor = System.Drawing.Color.LightSteelBlue
            BtnGenPDF.BackColor = System.Drawing.Color.LightSteelBlue
            BtnNewReport.BackColor = System.Drawing.Color.LightSteelBlue
            BtnPrint.Enabled = True
            BtnGenPDF.Enabled = True
            BtnNewReport.Enabled = True
            BtnSaveToDB.Enabled = True
        End If

    End Sub

    Private Sub BtnSaveToDB_Click(sender As Object, e As EventArgs) Handles BtnSaveToDB.Click

        ProgressBar1.Value = 0

        ProgressBar1.Increment(10)

        Dim reportHeader = CreateSaveReportHeader()
        Dim reportDetails = CreateSaveReportDetails()

        Dim dataRepo As IDataRepo = New SqlLiteManager(_countingObject?.CounterType)

        Dim reportDetailsJson = JsonConvert.SerializeObject(reportDetails, Formatting.Indented)

        dataRepo.SaveReport(reportHeader, reportDetailsJson, ProgressBar1, LblReportSaved)


    End Sub

    Private Function CreateSaveReportHeader() As Report

        Dim report As New Report()

        report.PatientName = TxtPatientName.Text
        report.PatientID = TxtPatientId.Text
        report.PatientDOB = DateTimePatientDOB.Value
        report.FacilityName = TxtFacilityName.Text
        report.ReportDate = DateTime.Now()
        report.CounterType = _countingObject.CounterType

        Return report

    End Function

    Private Function CreateSaveReportDetails() As ReportDetails

        Dim reportDetails As New ReportDetails()

        reportDetails.CellMorphology = TxtRBCMorph.Text
        reportDetails.OtherFindings = TxtOtherFindings.Text
        reportDetails.CountingObject = _countingObject
        reportDetails.CellReportItems = New List(Of ReportCell)

        For Each reportcell In _reportCells
            reportDetails.CellReportItems.Add(New ReportCell With {.CellType = reportcell.CellType, .Count = reportcell.Count, .EncludeInReport = reportcell.EncludeInReport})
        Next

        Return reportDetails

    End Function

End Class