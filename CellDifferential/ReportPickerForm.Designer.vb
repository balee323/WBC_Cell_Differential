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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ChkBoxUser = New System.Windows.Forms.CheckBox()
        Me.ChkBoxPatientID = New System.Windows.Forms.CheckBox()
        Me.ChkBoxPatientName = New System.Windows.Forms.CheckBox()
        Me.ReportsGroup = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnOpenReport = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.ReportDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportCreatorUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacilityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.ReportsGroup.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox1.Location = New System.Drawing.Point(3, 550)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1002, 117)
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
        'ReportsGroup
        '
        Me.ReportsGroup.Controls.Add(Me.DataGridView1)
        Me.ReportsGroup.Controls.Add(Me.BtnOpenReport)
        Me.ReportsGroup.Location = New System.Drawing.Point(3, 12)
        Me.ReportsGroup.Name = "ReportsGroup"
        Me.ReportsGroup.Size = New System.Drawing.Size(1539, 532)
        Me.ReportsGroup.TabIndex = 3
        Me.ReportsGroup.TabStop = False
        Me.ReportsGroup.Text = "Reports"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReportDate, Me.PatientName, Me.PatientID, Me.PatientDOB, Me.ReportCreatorUserName, Me.GivenName, Me.FacilityName, Me.ReportDetails})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 47
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1503, 507)
        Me.DataGridView1.TabIndex = 2
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
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(1203, 587)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(207, 66)
        Me.BtnOpen.TabIndex = 7
        Me.BtnOpen.Text = "Open Report"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'ReportDate
        '
        Me.ReportDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ReportDate.DataPropertyName = "ReportDate"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.ReportDate.HeaderText = "Report Date"
        Me.ReportDate.MinimumWidth = 6
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.ReadOnly = True
        Me.ReportDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ReportDate.Width = 200
        '
        'PatientName
        '
        Me.PatientName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PatientName.DataPropertyName = "PatientName"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.DefaultCellStyle = DataGridViewCellStyle4
        Me.PatientName.HeaderText = "Patient name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PatientName.Width = 250
        '
        'PatientID
        '
        Me.PatientID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PatientID.DataPropertyName = "PatientID"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientID.DefaultCellStyle = DataGridViewCellStyle5
        Me.PatientID.HeaderText = "Patient ID"
        Me.PatientID.MinimumWidth = 6
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PatientID.Width = 200
        '
        'PatientDOB
        '
        Me.PatientDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.PatientDOB.DataPropertyName = "PatientDOB"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientDOB.DefaultCellStyle = DataGridViewCellStyle6
        Me.PatientDOB.HeaderText = "Patient DOB"
        Me.PatientDOB.MinimumWidth = 6
        Me.PatientDOB.Name = "PatientDOB"
        Me.PatientDOB.ReadOnly = True
        Me.PatientDOB.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.PatientDOB.Width = 200
        '
        'ReportCreatorUserName
        '
        Me.ReportCreatorUserName.DataPropertyName = "UserName"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportCreatorUserName.DefaultCellStyle = DataGridViewCellStyle7
        Me.ReportCreatorUserName.HeaderText = "Report Creator UserName"
        Me.ReportCreatorUserName.MinimumWidth = 6
        Me.ReportCreatorUserName.Name = "ReportCreatorUserName"
        Me.ReportCreatorUserName.ReadOnly = True
        Me.ReportCreatorUserName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.ReportCreatorUserName.Width = 200
        '
        'GivenName
        '
        Me.GivenName.DataPropertyName = "GivenName"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GivenName.DefaultCellStyle = DataGridViewCellStyle8
        Me.GivenName.HeaderText = "Report Creator Name"
        Me.GivenName.MinimumWidth = 6
        Me.GivenName.Name = "GivenName"
        Me.GivenName.ReadOnly = True
        Me.GivenName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.GivenName.Width = 200
        '
        'FacilityName
        '
        Me.FacilityName.DataPropertyName = "FacilityName"
        Me.FacilityName.HeaderText = "Facility Name"
        Me.FacilityName.MinimumWidth = 6
        Me.FacilityName.Name = "FacilityName"
        Me.FacilityName.ReadOnly = True
        Me.FacilityName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic
        Me.FacilityName.Width = 200
        '
        'ReportDetails
        '
        Me.ReportDetails.DataPropertyName = "ReportDetails"
        Me.ReportDetails.HeaderText = "Report Details"
        Me.ReportDetails.MinimumWidth = 6
        Me.ReportDetails.Name = "ReportDetails"
        Me.ReportDetails.ReadOnly = True
        Me.ReportDetails.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.ReportDetails.Visible = False
        Me.ReportDetails.Width = 20
        '
        'ReportPickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1554, 694)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.ReportsGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ReportPickerForm"
        Me.Text = "Report Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ReportsGroup.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ReportsGroup As GroupBox
    Friend WithEvents BtnOpenReport As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnOpen As Button
    Friend WithEvents ReportDate As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOB As DataGridViewTextBoxColumn
    Friend WithEvents ReportCreatorUserName As DataGridViewTextBoxColumn
    Friend WithEvents GivenName As DataGridViewTextBoxColumn
    Friend WithEvents FacilityName As DataGridViewTextBoxColumn
    Friend WithEvents ReportDetails As DataGridViewTextBoxColumn
End Class
