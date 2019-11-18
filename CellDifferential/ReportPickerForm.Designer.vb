<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportPickerForm
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtBoxSearch = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioPatientDOB = New System.Windows.Forms.RadioButton()
        Me.RadioPatientID = New System.Windows.Forms.RadioButton()
        Me.RadioPatientName = New System.Windows.Forms.RadioButton()
        Me.RadioTechName = New System.Windows.Forms.RadioButton()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.DateTimePatientDOB = New System.Windows.Forms.DateTimePicker()
        Me.BtnOpen = New System.Windows.Forms.Button()
        Me.BtnRefresh = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReportDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportCreatorUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FacilityName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ChkboxBegin = New System.Windows.Forms.CheckBox()
        Me.DateTimeBegin = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeEnd = New System.Windows.Forms.DateTimePicker()
        Me.ChkboxEnd = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search Term"
        '
        'TxtBoxSearch
        '
        Me.TxtBoxSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBoxSearch.Location = New System.Drawing.Point(10, 138)
        Me.TxtBoxSearch.Name = "TxtBoxSearch"
        Me.TxtBoxSearch.Size = New System.Drawing.Size(331, 28)
        Me.TxtBoxSearch.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DateTimeEnd)
        Me.GroupBox1.Controls.Add(Me.ChkboxEnd)
        Me.GroupBox1.Controls.Add(Me.DateTimeBegin)
        Me.GroupBox1.Controls.Add(Me.ChkboxBegin)
        Me.GroupBox1.Controls.Add(Me.RadioPatientDOB)
        Me.GroupBox1.Controls.Add(Me.RadioPatientID)
        Me.GroupBox1.Controls.Add(Me.RadioPatientName)
        Me.GroupBox1.Controls.Add(Me.RadioTechName)
        Me.GroupBox1.Controls.Add(Me.BtnSearch)
        Me.GroupBox1.Controls.Add(Me.DateTimePatientDOB)
        Me.GroupBox1.Controls.Add(Me.TxtBoxSearch)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 551)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(805, 186)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Search"
        '
        'RadioPatientDOB
        '
        Me.RadioPatientDOB.AutoSize = True
        Me.RadioPatientDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPatientDOB.Location = New System.Drawing.Point(131, 71)
        Me.RadioPatientDOB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioPatientDOB.Name = "RadioPatientDOB"
        Me.RadioPatientDOB.Size = New System.Drawing.Size(116, 24)
        Me.RadioPatientDOB.TabIndex = 10
        Me.RadioPatientDOB.TabStop = True
        Me.RadioPatientDOB.Text = "Patient DOB"
        Me.RadioPatientDOB.UseVisualStyleBackColor = True
        '
        'RadioPatientID
        '
        Me.RadioPatientID.AutoSize = True
        Me.RadioPatientID.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPatientID.Location = New System.Drawing.Point(10, 33)
        Me.RadioPatientID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioPatientID.Name = "RadioPatientID"
        Me.RadioPatientID.Size = New System.Drawing.Size(98, 24)
        Me.RadioPatientID.TabIndex = 9
        Me.RadioPatientID.TabStop = True
        Me.RadioPatientID.Text = "Patient ID"
        Me.RadioPatientID.UseVisualStyleBackColor = True
        '
        'RadioPatientName
        '
        Me.RadioPatientName.AutoSize = True
        Me.RadioPatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioPatientName.Location = New System.Drawing.Point(131, 33)
        Me.RadioPatientName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioPatientName.Name = "RadioPatientName"
        Me.RadioPatientName.Size = New System.Drawing.Size(123, 24)
        Me.RadioPatientName.TabIndex = 8
        Me.RadioPatientName.TabStop = True
        Me.RadioPatientName.Text = "Patient Name"
        Me.RadioPatientName.UseVisualStyleBackColor = True
        '
        'RadioTechName
        '
        Me.RadioTechName.AutoSize = True
        Me.RadioTechName.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioTechName.Location = New System.Drawing.Point(10, 71)
        Me.RadioTechName.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RadioTechName.Name = "RadioTechName"
        Me.RadioTechName.Size = New System.Drawing.Size(108, 24)
        Me.RadioTechName.TabIndex = 7
        Me.RadioTechName.TabStop = True
        Me.RadioTechName.Text = "Tech Name"
        Me.RadioTechName.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(590, 130)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(161, 36)
        Me.BtnSearch.TabIndex = 6
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'DateTimePatientDOB
        '
        Me.DateTimePatientDOB.CustomFormat = "MM/DD/YYYY"
        Me.DateTimePatientDOB.Enabled = False
        Me.DateTimePatientDOB.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePatientDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePatientDOB.Location = New System.Drawing.Point(262, 71)
        Me.DateTimePatientDOB.Name = "DateTimePatientDOB"
        Me.DateTimePatientDOB.Size = New System.Drawing.Size(162, 25)
        Me.DateTimePatientDOB.TabIndex = 5
        Me.DateTimePatientDOB.Value = New Date(2019, 11, 18, 0, 0, 0, 0)
        '
        'BtnOpen
        '
        Me.BtnOpen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpen.Location = New System.Drawing.Point(1011, 552)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(127, 116)
        Me.BtnOpen.TabIndex = 7
        Me.BtnOpen.Text = "Open Report"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'BtnRefresh
        '
        Me.BtnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRefresh.Location = New System.Drawing.Point(843, 561)
        Me.BtnRefresh.Name = "BtnRefresh"
        Me.BtnRefresh.Size = New System.Drawing.Size(127, 116)
        Me.BtnRefresh.TabIndex = 8
        Me.BtnRefresh.Text = "Refresh"
        Me.BtnRefresh.UseVisualStyleBackColor = True
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
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReportDate, Me.ReportType, Me.PatientName, Me.PatientID, Me.PatientDOB, Me.ReportCreatorUserName, Me.GivenName, Me.FacilityName, Me.ReportDetails})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 11)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 20
        Me.DataGridView1.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1128, 507)
        Me.DataGridView1.TabIndex = 2
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
        'ReportType
        '
        Me.ReportType.DataPropertyName = "CounterType"
        Me.ReportType.HeaderText = "Report Type"
        Me.ReportType.MinimumWidth = 6
        Me.ReportType.Name = "ReportType"
        Me.ReportType.ReadOnly = True
        Me.ReportType.Width = 180
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
        Me.PatientID.Width = 160
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
        Me.ReportCreatorUserName.Width = 160
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
        Me.FacilityName.Width = 160
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
        'ChkboxBegin
        '
        Me.ChkboxBegin.AutoSize = True
        Me.ChkboxBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkboxBegin.Location = New System.Drawing.Point(475, 25)
        Me.ChkboxBegin.Name = "ChkboxBegin"
        Me.ChkboxBegin.Size = New System.Drawing.Size(108, 24)
        Me.ChkboxBegin.TabIndex = 11
        Me.ChkboxBegin.Text = "Begin Date"
        Me.ChkboxBegin.UseVisualStyleBackColor = True
        '
        'DateTimeBegin
        '
        Me.DateTimeBegin.CustomFormat = "MM/DD/YYYY"
        Me.DateTimeBegin.Enabled = False
        Me.DateTimeBegin.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeBegin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeBegin.Location = New System.Drawing.Point(589, 25)
        Me.DateTimeBegin.Name = "DateTimeBegin"
        Me.DateTimeBegin.Size = New System.Drawing.Size(162, 25)
        Me.DateTimeBegin.TabIndex = 12
        Me.DateTimeBegin.Value = New Date(2019, 11, 18, 0, 0, 0, 0)
        '
        'DateTimeEnd
        '
        Me.DateTimeEnd.CustomFormat = "MM/DD/YYYY"
        Me.DateTimeEnd.Enabled = False
        Me.DateTimeEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimeEnd.Location = New System.Drawing.Point(589, 71)
        Me.DateTimeEnd.Name = "DateTimeEnd"
        Me.DateTimeEnd.Size = New System.Drawing.Size(162, 25)
        Me.DateTimeEnd.TabIndex = 14
        Me.DateTimeEnd.Value = New Date(2019, 11, 18, 0, 0, 0, 0)
        '
        'ChkboxEnd
        '
        Me.ChkboxEnd.AutoSize = True
        Me.ChkboxEnd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.818182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkboxEnd.Location = New System.Drawing.Point(475, 71)
        Me.ChkboxEnd.Name = "ChkboxEnd"
        Me.ChkboxEnd.Size = New System.Drawing.Size(96, 24)
        Me.ChkboxEnd.TabIndex = 13
        Me.ChkboxEnd.Text = "End Date"
        Me.ChkboxEnd.UseVisualStyleBackColor = True
        '
        'ReportPickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1149, 749)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnRefresh)
        Me.Controls.Add(Me.BtnOpen)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimumSize = New System.Drawing.Size(1130, 658)
        Me.Name = "ReportPickerForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report Selector"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtBoxSearch As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePatientDOB As DateTimePicker
    Friend WithEvents BtnSearch As Button
    Friend WithEvents BtnOpen As Button
    Friend WithEvents BtnRefresh As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ReportDate As DataGridViewTextBoxColumn
    Friend WithEvents ReportType As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOB As DataGridViewTextBoxColumn
    Friend WithEvents ReportCreatorUserName As DataGridViewTextBoxColumn
    Friend WithEvents GivenName As DataGridViewTextBoxColumn
    Friend WithEvents FacilityName As DataGridViewTextBoxColumn
    Friend WithEvents ReportDetails As DataGridViewTextBoxColumn
    Friend WithEvents RadioPatientID As RadioButton
    Friend WithEvents RadioPatientName As RadioButton
    Friend WithEvents RadioTechName As RadioButton
    Friend WithEvents RadioPatientDOB As RadioButton
    Friend WithEvents DateTimeEnd As DateTimePicker
    Friend WithEvents ChkboxEnd As CheckBox
    Friend WithEvents DateTimeBegin As DateTimePicker
    Friend WithEvents ChkboxBegin As CheckBox
End Class
