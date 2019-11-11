<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Report
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
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnGenPDF = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PatientInputPanel = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
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
        Me.BtnPrint.Text = "Print "
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnCreate
        '
        Me.BtnCreate.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnCreate.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(7, 499)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(92, 70)
        Me.BtnCreate.TabIndex = 5
        Me.BtnCreate.Text = "New Report"
        Me.BtnCreate.UseVisualStyleBackColor = False
        '
        'BtnGenPDF
        '
        Me.BtnGenPDF.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnGenPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnGenPDF.Location = New System.Drawing.Point(105, 499)
        Me.BtnGenPDF.Name = "BtnGenPDF"
        Me.BtnGenPDF.Size = New System.Drawing.Size(148, 70)
        Me.BtnGenPDF.TabIndex = 6
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
        Me.PatientInputPanel.Controls.Add(Me.Button1)
        Me.PatientInputPanel.Controls.Add(Me.TextBox6)
        Me.PatientInputPanel.Controls.Add(Me.Label3)
        Me.PatientInputPanel.Controls.Add(Me.Label2)
        Me.PatientInputPanel.Controls.Add(Me.TextBox5)
        Me.PatientInputPanel.Controls.Add(Me.TextBox4)
        Me.PatientInputPanel.Controls.Add(Me.TextBox3)
        Me.PatientInputPanel.Controls.Add(Me.TextBox2)
        Me.PatientInputPanel.Controls.Add(Me.TextBox1)
        Me.PatientInputPanel.Controls.Add(Me.Label1)
        Me.PatientInputPanel.Location = New System.Drawing.Point(59, 26)
        Me.PatientInputPanel.Name = "PatientInputPanel"
        Me.PatientInputPanel.Size = New System.Drawing.Size(863, 454)
        Me.PatientInputPanel.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(749, 401)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 38)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Done"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(46, 346)
        Me.TextBox6.Multiline = True
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(679, 56)
        Me.TextBox6.TabIndex = 8
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
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(46, 240)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(679, 56)
        Me.TextBox5.TabIndex = 5
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(46, 93)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(679, 28)
        Me.TextBox4.TabIndex = 4
        Me.TextBox4.Text = "[Patient Id]"
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(46, 127)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(679, 28)
        Me.TextBox3.TabIndex = 3
        Me.TextBox3.Text = "[Patient DOB]"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(46, 161)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(679, 28)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.Text = "[Faclility Name]"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(46, 59)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(679, 28)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "[Patient Name]"
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
        'Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(962, 575)
        Me.Controls.Add(Me.PatientInputPanel)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.BtnGenPDF)
        Me.Controls.Add(Me.BtnCreate)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnCloseReport)
        Me.Name = "Report"
        Me.Text = "Patient Report"
        Me.PatientInputPanel.ResumeLayout(False)
        Me.PatientInputPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCloseReport As System.Windows.Forms.Button
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents BtnCreate As System.Windows.Forms.Button
    Friend WithEvents BtnGenPDF As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PatientInputPanel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
End Class
