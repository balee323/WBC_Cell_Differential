Imports System.Drawing.Printing

Public Class FrmReport


    'all values brought in from CellDiffMain
    Public Count As Integer = 0
    Public DiffType As Integer = 0

    Dim reportType As String = ""

    Private cellCollection As List(Of Cell)

    Private WithEvents docToPrint As New PrintDocument


    Public Sub StartReport()

        'good diagnotic tool!!!  'let me know that the collection was not set up correctly

        'MessageBox.Show("form Loaded")

        'If DiffType = 1 Then
        '    cellCollection.AddRange(AllCells.PeripheralCells)
        'ElseIf DiffType = 2 Then
        '    cellCollection.AddRange(AllCells.BoneMarrowCells)
        'ElseIf DiffType = 3 Then

        'End If

        'MessageBox.Show("cellCount :" & cellCollection.Count)
    End Sub



    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cellCollection = New List(Of Cell)


        ' MessageBox.Show("form Loaded")

        If DiffType = 1 Then
            cellCollection.AddRange(AllCells.PeripheralCells)
            reportType = "Peripheral Differential"
        ElseIf DiffType = 2 Then
            cellCollection.AddRange(AllCells.BoneMarrowCells)
            reportType = "Bone Marrow Differential"
        ElseIf DiffType = 3 Then

        End If

        ' MessageBox.Show("cellCount :" & cellCollection.Count)


    End Sub



    'Public Seg As Integer = 0
    'Public Lym As Integer = 0
    'Public Mono As Integer = 0
    'Public Eos As Integer = 0
    'Public Baso As Integer = 0
    'Public Band As Integer = 0
    'Public Meta As Integer = 0
    'Public Myelo As Integer = 0
    'Public Promyelo As Integer = 0
    'Public Blast As Integer = 0
    'Public NRBC As Integer = 0

  


    Private Sub BtnPrint_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click


        'PrintDocument1.Print()
        docToPrint.Print()


    End Sub



    'for setting up the document for printing, since I only want to print the listbox
    Private Sub PrintedPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles docToPrint.PrintPage

        Dim printFont As New Font("Courier New", 12, System.Drawing.FontStyle.Regular)


        Dim YPosition As Integer = 25

        For Each ThingToPrint As String In LstReport.Items

            e.Graphics.DrawString(ThingToPrint, printFont, System.Drawing.Brushes.Black, 25, YPosition)


            YPosition += 25

        Next



    End Sub






    Private Sub BtnCloseReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCloseReport.Click

        Me.Close()

    End Sub

    Private Sub BtnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCreate.Click

        LstReport.Items.Clear()


        Dim PatientName As String = ""
        Dim PatientID As String = ""
        Dim PatientDOB As String = ""
        Dim FacilityName As String = ""

        'Set current Date
        Dim Today As String = CStr(DateAndTime.Now)

        FacilityName = InputBox("Please Enter Name of facility. I.E. General Hospital Pathology Laboratory. ")
        PatientName = InputBox("Please Enter Patient Name as Last, First ")
        PatientID = InputBox("Please Enter Patient ID number ")
        PatientDOB = InputBox("Please Enter Patient DOB as MM/DD/YYYY")

        'Percentages need to be formatted
        Dim ColumnSpacing As String = "{0, -25}{1, 1}{2, 10}{3, 30}{4, 2}" 'column(s) and spacing
        Dim ColumnSpacing2 As String = "{0, -25}{1, 1}{2, 10}" 'column(s) and spacing


        LstReport.Items.Add("===================================================================")
        LstReport.Items.Add(FacilityName)
        LstReport.Items.Add("Hematology Report")
        LstReport.Items.Add("===================================================================")
        LstReport.Items.Add("Hematology Report")
        LstReport.Items.Add(Today)
        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("Patient Information")
        LstReport.Items.Add(PatientName & " | " & PatientID & " | " & PatientDOB)
        LstReport.Items.Add("")
        LstReport.Items.Add("Blood Cell Manual" & "  " & reportType)
        LstReport.Items.Add("Total Cells Counted: " & Count)
        LstReport.Items.Add("")



        Dim i As Integer = 0
        While i < cellCollection.Count
            If Not cellCollection(i).getCellType.Contains("User") Then
                LstReport.Items.Add(String.Format(ColumnSpacing, cellCollection(i).getCellType, "", cellCollection(i).getCount, getPercent(cellCollection(i).getCount), " %"))
            End If

            i = i + 1
        End While

        'LstReport.Items.Add(String.Format(ColumnSpacing, "Segmented Neutrophils:", "", CStr(Seg), CStr(Seg / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Lymphocytes:", " ", CStr(Lym), CStr(Lym / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Monocytes:", " ", CStr(Mono), CStr(Mono / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Eosinophils:", " ", CStr(Eos), CStr(Eos / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Basophils:", " ", CStr(Baso), CStr(Baso / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Banded Neutrophils:", " ", CStr(Band), CStr(Band / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Metamyeloyctes:", " ", CStr(Meta), CStr(Meta / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Myelocytes:", " ", CStr(Myelo), CStr(Myelo / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Promyelocytes:", " ", CStr(Promyelo), CStr(Promyelo / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing, "Blast Cells:", " ", CStr(Blast), CStr(Blast / Count * 100), " %"))
        'LstReport.Items.Add(String.Format(ColumnSpacing2, "Nucleated Red Cells:", " ", CStr(NRBC)))


        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("Red Cell morphology")
        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("Other findings")
        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("")
        LstReport.Items.Add("===================================================================")


    End Sub


    Private Function getPercent(number As Integer) As Double
        Dim percent As Double

        percent = number / Count * 100

        Return percent

    End Function


    Private Sub LstReport_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LstReport.SelectedIndexChanged


    End Sub

    
End Class