<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnCloseReport = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnNewReport = New System.Windows.Forms.Button()
        Me.BtnGenPDF = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PatientInputPanel = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePatientDOB = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TxtOtherFindings = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtRBCMorph = New System.Windows.Forms.TextBox()
        Me.TxtPatientId = New System.Windows.Forms.TextBox()
        Me.TxtFacilityName = New System.Windows.Forms.TextBox()
        Me.TxtPatientName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnSaveToDB = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.LblReportSaved = New System.Windows.Forms.Label()
        Me.PatientInputPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnCloseReport
        '
        Me.BtnCloseReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCloseReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseReport.Location = New System.Drawing.Point(858, 499)
        Me.BtnCloseReport.Name = "BtnCloseReport"
        Me.BtnCloseReport.Size = New System.Drawing.Size(92, 70)
        Me.BtnCloseReport.TabIndex = 2
        Me.BtnCloseReport.TabStop = False
        Me.BtnCloseReport.Text = "Close Report"
        Me.BtnCloseReport.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.Location = New System.Drawing.Point(259, 499)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(92, 70)
        Me.BtnPrint.TabIndex = 3
        Me.BtnPrint.TabStop = False
        Me.BtnPrint.Text = "Print "
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnNewReport
        '
        Me.BtnNewReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnNewReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewReport.Location = New System.Drawing.Point(7, 499)
        Me.BtnNewReport.Name = "BtnNewReport"
        Me.BtnNewReport.Size = New System.Drawing.Size(92, 70)
        Me.BtnNewReport.TabIndex = 5
        Me.BtnNewReport.TabStop = False
        Me.BtnNewReport.Text = "New Report"
        Me.BtnNewReport.UseVisualStyleBackColor = False
        '
        'BtnGenPDF
        '
        Me.BtnGenPDF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnGenPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenPDF.Location = New System.Drawing.Point(105, 499)
        Me.BtnGenPDF.Name = "BtnGenPDF"
        Me.BtnGenPDF.Size = New System.Drawing.Size(148, 70)
        Me.BtnGenPDF.TabIndex = 6
        Me.BtnGenPDF.TabStop = False
        Me.BtnGenPDF.Text = "Generate PDF"
        Me.BtnGenPDF.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Courier New", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(938, 481)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'PatientInputPanel
        '
        Me.PatientInputPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.PatientInputPanel.Controls.Add(Me.Label4)
        Me.PatientInputPanel.Controls.Add(Me.DateTimePatientDOB)
        Me.PatientInputPanel.Controls.Add(Me.Button1)
        Me.PatientInputPanel.Controls.Add(Me.TxtOtherFindings)
        Me.PatientInputPanel.Controls.Add(Me.Label3)
        Me.PatientInputPanel.Controls.Add(Me.Label2)
        Me.PatientInputPanel.Controls.Add(Me.TxtRBCMorph)
        Me.PatientInputPanel.Controls.Add(Me.TxtPatientId)
        Me.PatientInputPanel.Controls.Add(Me.TxtFacilityName)
        Me.PatientInputPanel.Controls.Add(Me.TxtPatientName)
        Me.PatientInputPanel.Controls.Add(Me.Label1)
        Me.PatientInputPanel.Location = New System.Drawing.Point(59, 26)
        Me.PatientInputPanel.Name = "PatientInputPanel"
        Me.PatientInputPanel.Size = New System.Drawing.Size(863, 454)
        Me.PatientInputPanel.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 24)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Patient DOB:"
        '
        'DateTimePatientDOB
        '
        Me.DateTimePatientDOB.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePatientDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePatientDOB.Location = New System.Drawing.Point(215, 127)
        Me.DateTimePatientDOB.Name = "DateTimePatientDOB"
        Me.DateTimePatientDOB.Size = New System.Drawing.Size(165, 28)
        Me.DateTimePatientDOB.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(749, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 38)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtOtherFindings
        '
        Me.TxtOtherFindings.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtOtherFindings.Location = New System.Drawing.Point(46, 346)
        Me.TxtOtherFindings.MaxLength = 1000
        Me.TxtOtherFindings.Multiline = True
        Me.TxtOtherFindings.Name = "TxtOtherFindings"
        Me.TxtOtherFindings.Size = New System.Drawing.Size(679, 56)
        Me.TxtOtherFindings.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 319)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 24)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Other Findings"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(188, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Red Cell morphology"
        '
        'TxtRBCMorph
        '
        Me.TxtRBCMorph.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtRBCMorph.Location = New System.Drawing.Point(46, 240)
        Me.TxtRBCMorph.MaxLength = 1000
        Me.TxtRBCMorph.Multiline = True
        Me.TxtRBCMorph.Name = "TxtRBCMorph"
        Me.TxtRBCMorph.Size = New System.Drawing.Size(679, 56)
        Me.TxtRBCMorph.TabIndex = 5
        '
        'TxtPatientId
        '
        Me.TxtPatientId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientId.Location = New System.Drawing.Point(46, 93)
        Me.TxtPatientId.Name = "TxtPatientId"
        Me.TxtPatientId.Size = New System.Drawing.Size(679, 28)
        Me.TxtPatientId.TabIndex = 2
        Me.TxtPatientId.Text = "[Patient Id]"
        '
        'TxtFacilityName
        '
        Me.TxtFacilityName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtFacilityName.Location = New System.Drawing.Point(46, 161)
        Me.TxtFacilityName.Name = "TxtFacilityName"
        Me.TxtFacilityName.Size = New System.Drawing.Size(679, 28)
        Me.TxtFacilityName.TabIndex = 4
        Me.TxtFacilityName.Text = "[Faclility Name]"
        '
        'TxtPatientName
        '
        Me.TxtPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPatientName.Location = New System.Drawing.Point(46, 59)
        Me.TxtPatientName.Name = "TxtPatientName"
        Me.TxtPatientName.Size = New System.Drawing.Size(679, 28)
        Me.TxtPatientName.TabIndex = 1
        Me.TxtPatientName.Text = "[Patient Name]"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(42, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(271, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter report information:"
        '
        'BtnSaveToDB
        '
        Me.BtnSaveToDB.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnSaveToDB.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveToDB.Location = New System.Drawing.Point(357, 499)
        Me.BtnSaveToDB.Name = "BtnSaveToDB"
        Me.BtnSaveToDB.Size = New System.Drawing.Size(241, 46)
        Me.BtnSaveToDB.TabIndex = 9
        Me.BtnSaveToDB.TabStop = False
        Me.BtnSaveToDB.Text = "Save To Database"
        Me.BtnSaveToDB.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(358, 540)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(240, 23)
        Me.ProgressBar1.TabIndex = 10
        '
        'LblReportSaved
        '
        Me.LblReportSaved.AutoSize = True
        Me.LblReportSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReportSaved.ForeColor = System.Drawing.Color.LawnGreen
        Me.LblReportSaved.Location = New System.Drawing.Point(604, 499)
        Me.LblReportSaved.Name = "LblReportSaved"
        Me.LblReportSaved.Size = New System.Drawing.Size(59, 20)
        Me.LblReportSaved.TabIndex = 11
        Me.LblReportSaved.Text = "Saved"
        Me.LblReportSaved.Visible = False
        '
        'ReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 575)
        Me.Controls.Add(Me.LblReportSaved)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.BtnSaveToDB)
        Me.Controls.Add(Me.PatientInputPanel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnGenPDF)
        Me.Controls.Add(Me.BtnNewReport)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnCloseReport)
        Me.Name = "ReportForm"
        Me.Text = "Patient Report"
        Me.PatientInputPanel.ResumeLayout(False)
        Me.PatientInputPanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnCloseReport As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents BtnNewReport As System.Windows.Forms.Button
    Friend WithEvents BtnGenPDF As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PatientInputPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPatientId As TextBox
    Friend WithEvents TxtFacilityName As TextBox
    Friend WithEvents TxtPatientName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtRBCMorph As TextBox
    Friend WithEvents TxtOtherFindings As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnSaveToDB As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents LblReportSaved As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePatientDOB As DateTimePicker
End Class
