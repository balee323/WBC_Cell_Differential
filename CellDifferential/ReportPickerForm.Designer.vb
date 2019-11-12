<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportPickerForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChkBoxUser = New System.Windows.Forms.CheckBox()
        Me.ChkBoxPatientID = New System.Windows.Forms.CheckBox()
        Me.ChkBoxPatientName = New System.Windows.Forms.CheckBox()
        Me.Reports = New System.Windows.Forms.GroupBox()
        Me.BtnOpenReport = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.GroupBox1.SuspendLayout()
        Me.Reports.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Term"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(6, 75)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(331, 28)
        Me.TextBox1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.ChkBoxUser)
        Me.GroupBox1.Controls.Add(Me.ChkBoxPatientID)
        Me.GroupBox1.Controls.Add(Me.ChkBoxPatientName)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 435)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(827, 117)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(635, 71)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(161, 36)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(525, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(271, 25)
        Me.DateTimePicker1.TabIndex = 5
        '
        'ChkBoxUser
        '
        Me.ChkBoxUser.AutoSize = True
        Me.ChkBoxUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxUser.Location = New System.Drawing.Point(353, 81)
        Me.ChkBoxUser.Name = "ChkBoxUser"
        Me.ChkBoxUser.Size = New System.Drawing.Size(109, 24)
        Me.ChkBoxUser.TabIndex = 4
        Me.ChkBoxUser.Text = "Tech Name"
        Me.ChkBoxUser.UseVisualStyleBackColor = True
        '
        'ChkBoxPatientID
        '
        Me.ChkBoxPatientID.AutoSize = True
        Me.ChkBoxPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxPatientID.Location = New System.Drawing.Point(353, 19)
        Me.ChkBoxPatientID.Name = "ChkBoxPatientID"
        Me.ChkBoxPatientID.Size = New System.Drawing.Size(99, 24)
        Me.ChkBoxPatientID.TabIndex = 3
        Me.ChkBoxPatientID.Text = "Patient ID"
        Me.ChkBoxPatientID.UseVisualStyleBackColor = True
        '
        'ChkBoxPatientName
        '
        Me.ChkBoxPatientName.AutoSize = True
        Me.ChkBoxPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkBoxPatientName.Location = New System.Drawing.Point(353, 49)
        Me.ChkBoxPatientName.Name = "ChkBoxPatientName"
        Me.ChkBoxPatientName.Size = New System.Drawing.Size(124, 24)
        Me.ChkBoxPatientName.TabIndex = 2
        Me.ChkBoxPatientName.Text = "Patient Name"
        Me.ChkBoxPatientName.UseVisualStyleBackColor = True
        '
        'Reports
        '
        Me.Reports.Controls.Add(Me.BtnOpenReport)
        Me.Reports.Controls.Add(Me.CheckedListBox1)
        Me.Reports.Location = New System.Drawing.Point(3, 12)
        Me.Reports.Name = "Reports"
        Me.Reports.Size = New System.Drawing.Size(827, 412)
        Me.Reports.TabIndex = 3
        Me.Reports.TabStop = False
        Me.Reports.Text = "GroupBox2"
        '
        'BtnOpenReport
        '
        Me.BtnOpenReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenReport.Location = New System.Drawing.Point(18, 362)
        Me.BtnOpenReport.Name = "BtnOpenReport"
        Me.BtnOpenReport.Size = New System.Drawing.Size(124, 39)
        Me.BtnOpenReport.TabIndex = 1
        Me.BtnOpenReport.Text = "Open Report"
        Me.BtnOpenReport.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Doe, John | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (Bl" &
                "ee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Lee, Kelly | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee (B" &
                "lee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)", "Williams, Ed | 12345 | DOB: |  ReportDate:   | Type: Periperal | Tech: Brian Lee " &
                "(Blee)"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(18, 29)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(795, 327)
        Me.CheckedListBox1.Sorted = True
        Me.CheckedListBox1.TabIndex = 0
        Me.CheckedListBox1.ThreeDCheckBoxes = True
        '
        'ReportPickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(850, 554)
        Me.Controls.Add(Me.Reports)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportPickerForm"
        Me.Text = "Report Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Reports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ChkBoxUser As CheckBox
    Friend WithEvents ChkBoxPatientID As CheckBox
    Friend WithEvents ChkBoxPatientName As CheckBox
    Friend WithEvents BtnSearch As Button
    Friend WithEvents Reports As GroupBox
    Friend WithEvents BtnOpenReport As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
