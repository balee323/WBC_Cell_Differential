Imports System.Drawing.Printing
Imports System.Text
Imports NLog
Imports PdfSharp
Imports PdfSharp.Drawing
Imports PdfSharp.Drawing.Layout
Imports PdfSharp.Pdf


Public Class Report


    'all values brought in from CellDiffMain
    Private _cells As New List(Of Cell)
    Private _settings As ISettings
    Private _countingObject As CountingObject
    Private _excludeUserCell As Boolean = False
    Private WithEvents docToPrint As New PrintDocument
    Private _logger As Logger = NLog.LogManager.GetCurrentClassLogger()
    Private _reportBuilder As StringBuilder




    Public Sub New(cells As List(Of Cell), settings As ISettings, counteringObject As CountingObject)

        Me._cells = cells
        Me._settings = settings
        Me._countingObject = counteringObject
        Me._reportBuilder = New StringBuilder()
        ' This call is required by the designer.
        InitializeComponent()

        RichTextBox1.ReadOnly = True

        ' Add any initialization after the InitializeComponent() call.

    End Sub


    Private Sub BtnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click

        docToPrint.Print()

    End Sub



    'for setting up the document for printing, since I only want to print the listbox
    Private Sub PrintedPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docToPrint.PrintPage

        'Dim printFont As New Font("Courier New", 12, System.Drawing.FontStyle.Regular)


        'Dim YPosition As Integer = 25

        'For Each ThingToPrint As String In LstReport.Items

        '    e.Graphics.DrawString(ThingToPrint, printFont, System.Drawing.Brushes.Black, 25, YPosition)


        '    YPosition += 25

        'Next



    End Sub


    Private Sub BtnCloseReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseReport.Click

        Me.Close()

    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click
        GenerateReport()

    End Sub

    Private Sub GenerateReport()

        RichTextBox1.Clear()


        Dim PatientName As String = ""
        Dim PatientID As String = ""
        Dim PatientDOB As String = ""
        Dim FacilityName As String = ""

        'Set current Date
        Dim Today As String = CStr(DateAndTime.Now)

        'FacilityName = InputBox("Please Enter Name of facility. I.E. General Hospital Pathology Laboratory. ")
        'PatientName = InputBox("Please Enter Patient Name as Last, First ")
        'PatientID = InputBox("Please Enter Patient ID number ")
        'PatientDOB = InputBox("Please Enter Patient DOB as MM/DD/YYYY")




        _reportBuilder.AppendLine("===================================================================")

        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine(FacilityName)
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine("===================================================================")
        _reportBuilder.AppendLine("Hematology Report")
        _reportBuilder.AppendLine(Today)
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Patient Information")
        _reportBuilder.AppendLine(PatientName & " | " & PatientID & " | " & PatientDOB)
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Blood Cell Manual" & "  " & _countingObject.CounterType.ToString())
        _reportBuilder.AppendLine("Total Cells Counted: " & _countingObject.Total)
        _reportBuilder.AppendLine("")


        'Percentages need to be formatted
        '{column, (- left align)spacing}  
        Dim ColumnSpacing1 As String = "{0, -15}{1, -10}{2, -1}"

        _reportBuilder.AppendFormat(ColumnSpacing1, "Cell Type", "Count", "Percentage")
        _reportBuilder.AppendLine()

        Dim ColumnSpacing2 As String = "{0, -15}{1, -10}{2, -1}{3, -2}"
        'I guess I was excluding these for some reason?
        Dim i As Integer = 0
        While i < _cells.Count
            If Not _cells(i).getCellType.Contains("User") Then
                _reportBuilder.AppendFormat(ColumnSpacing2, _cells(i).getCellType, _cells(i).getCount, getPercent(_cells(i).getCount), " %")
                _reportBuilder.AppendLine()
            End If
            i = i + 1
        End While

        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Red Cell morphology")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("Other findings")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("")
        _reportBuilder.AppendLine("===================================================================")

        RichTextBox1.Text = _reportBuilder.ToString()

    End Sub

    Private Function getPercent(number As Integer) As Double
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

            Dim rect = New XRect(40, 100, 250, 800)


            tf.DrawString(reportStr, font, XBrushes.Black, rect, XStringFormats.TopLeft)

            Dim fileName = SaveFileName(document.Info.Title)

            document.Save(fileName)

            Process.Start(fileName)

        Catch ex As Exception
            _logger.Error(ex)
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
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        TextBox2.Clear()
    End Sub

    Private Sub TextBox3_Click(sender As Object, e As EventArgs) Handles TextBox3.Click
        TextBox3.Clear()
    End Sub
    Private Sub TextBox4_Click(sender As Object, e As EventArgs) Handles TextBox4.Click
        TextBox4.Clear()
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        TextBox1.Clear()
    End Sub
End Class