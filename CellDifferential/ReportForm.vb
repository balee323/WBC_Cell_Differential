Imports System.Drawing.Printing
Imports System.Text
Imports Newtonsoft.Json
Imports NLog
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout
Imports PdfSharp.Pdf


Public Class ReportForm

    Private _cells As New List(Of Cell)
    Private _settings As ISettings
    Private _countingObject As CountingObject
    Private _excludeUserCell As Boolean = False
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _reportBuilder As StringBuilder

    'need an event to handle print
#Disable Warning IDE1006 ' Naming Styles
    Private WithEvents _docToPrint As New PrintDocument
#Enable Warning IDE1006 ' Naming Styles


    Public Sub New(cells As List(Of Cell), settings As ISettings, counteringObject As CountingObject)

        Me._cells = cells
        Me._settings = settings
        Me._countingObject = counteringObject
        Me._reportBuilder = New StringBuilder()
        ' This call is required by the designer.
        InitializeComponent()

        RichTextBox1.ReadOnly = True
        DisableButtons()

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

    Private Sub GenerateReport()

        RichTextBox1.Clear()
        _reportBuilder.Clear()

        'Set current Date
        Dim Today As String = CStr(DateAndTime.Now)

        Dim FacilityName = TxtFacilityName.Text
        Dim PatientName = TxtPatientName.Text
        Dim PatientID = TxtPatientId.Text
        Dim PatientDOB = TxtPatientDOB.Text

        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine("Patient Information - " + "Name: " + PatientName & " | ID: " & PatientID & " | DOB: " & PatientDOB)
        _reportBuilder.AppendLine("Date: " + Today)
        _reportBuilder.AppendLine("Facility: " + FacilityName)
        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Blood Cell Manual - " & _countingObject.CounterType.ToString())
        _reportBuilder.AppendLine("Total Cells Counted: " & _countingObject.Total)
        _reportBuilder.AppendLine("")


        'Percentages need to be formatted
        'Good Info to Have!!  {column, (- left align)spacing}  
        Dim ColumnSpacing1 As String = "{0, -15}{1, -10}{2, -1}"

        _reportBuilder.AppendFormat(ColumnSpacing1, "Cell Type", "Count", "Percentage")
        _reportBuilder.AppendLine()

        Dim ColumnSpacing2 As String = "{0, -15}{1, -10}{2, -1}{3, -2}"
        'I guess I was excluding these for some reason?
        Dim i As Integer = 0
        While i < _cells.Count
            If Not _cells(i).GetCellType.Contains("User") And _cells(i).EnableInCounter Then
                _reportBuilder.AppendFormat(ColumnSpacing2, _cells(i).GetCellType, _cells(i).GetCount, GetPercent(_cells(i).GetCount), " %")
                _reportBuilder.AppendLine()
            End If
            i += 1
        End While

        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Red Cell morphology:")
        _reportBuilder.AppendLine(TxtRBCMorph.Text)
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Other Findings:")
        _reportBuilder.AppendLine(TxtOtherFindings.Text)
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

            Dim fileName = SaveFileName(document.Info.Title)
            document.Save(fileName)

            Process.Start(fileName)

        Catch ex As Exception
            _logger.Error(ex)
            MessageBox.Show("Couldn't save file, file in use.")
            EnableButtons()
        End Try

    End Sub


    Private Function OpenDirectory() As String
        'Dim fd As OpenFileDialog = New OpenFileDialog()
        Dim fd = New FolderBrowserDialog()
        fd.Description = "Choose or create folder."
        fd.RootFolder = Environment.SpecialFolder.MyComputer

        Dim path As String = ""

        If fd.ShowDialog() = DialogResult.OK Then
            path = fd.SelectedPath
        End If

        Return path

    End Function


    Private Function SaveFileName(suggestedName As String) As String
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

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TxtPatientDOB.Click
        TxtPatientDOB.Clear()
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TxtPatientId.Click
        TxtPatientId.Clear()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TxtPatientName.Click
        TxtPatientName.Clear()
    End Sub

    Private Sub DisableButtons()
        BtnPrint.Enabled = False
        BtnGenPDF.Enabled = False
        BtnNewReport.Enabled = False
    End Sub

    Private Sub EnableButtons()
        BtnPrint.Enabled = True
        BtnGenPDF.Enabled = True
        BtnNewReport.Enabled = True
    End Sub

    Private Sub BtnSaveToDB_Click(sender As Object, e As EventArgs) Handles BtnSaveToDB.Click

        ProgressBar1.Value = 0

        ProgressBar1.Increment(10)

        Dim reportDetails = CreateReportDetails()

        Dim dataRepo As IDataRepo = New SqlLiteManager(_countingObject.CounterType)

        Dim reportDetailsJson = JsonConvert.SerializeObject(reportDetails, Formatting.Indented)

        dataRepo.SaveReports(reportDetailsJson, ProgressBar1, LblReportSaved)


    End Sub

    Private Function CreateReportDetails() As ReportDetails

        Dim reportDetails As New ReportDetails()

        reportDetails.CellMorphology = TxtRBCMorph.Text
        reportDetails.OtherFindings = TxtOtherFindings.Text
        reportDetails.FacilityName = TxtFacilityName.Text
        reportDetails.CountingObject = _countingObject

        reportDetails.CellReportItems = New List(Of CellReportItem)


        For Each cell In _cells
            reportDetails.CellReportItems.Add(New CellReportItem With {.CellType = cell.GetCellType(), .Count = cell.GetCount()})
        Next

        Return reportDetails

    End Function

End Class