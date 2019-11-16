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
        Me.ReportsGroup = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReportDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PatientDOB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportCreatorUserName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GivenName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReportDetails = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnOpenReport = New System.Windows.Forms.Button()
        Me.BtnOpen = New System.Windows.Forms.Button()
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
        Me.ReportsGroup.Size = New System.Drawing.Size(1283, 532)
        Me.ReportsGroup.TabIndex = 3
        Me.ReportsGroup.TabStop = False
        Me.ReportsGroup.Text = "Reports"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReportDate, Me.PatientName, Me.PatientID, Me.PatientDOB, Me.ReportCreatorUserName, Me.GivenName, Me.ReportDetails})
        Me.DataGridView1.Location = New System.Drawing.Point(10, 19)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 47
        Me.DataGridView1.Size = New System.Drawing.Size(1258, 507)
        Me.DataGridView1.TabIndex = 2
        '
        'ReportDate
        '
        Me.ReportDate.DataPropertyName = "ReportDate"
        Me.ReportDate.HeaderText = "Report Date"
        Me.ReportDate.MinimumWidth = 6
        Me.ReportDate.Name = "ReportDate"
        Me.ReportDate.ReadOnly = True
        Me.ReportDate.Width = 115
        '
        'PatientName
        '
        Me.PatientName.DataPropertyName = "PatientName"
        Me.PatientName.HeaderText = "Patient name"
        Me.PatientName.MinimumWidth = 6
        Me.PatientName.Name = "PatientName"
        Me.PatientName.ReadOnly = True
        Me.PatientName.Width = 115
        '
        'PatientID
        '
        Me.PatientID.DataPropertyName = "PatientID"
        Me.PatientID.HeaderText = "Patient ID"
        Me.PatientID.MinimumWidth = 6
        Me.PatientID.Name = "PatientID"
        Me.PatientID.ReadOnly = True
        Me.PatientID.Width = 115
        '
        'PatientDOB
        '
        Me.PatientDOB.DataPropertyName = "PatientDOB"
        Me.PatientDOB.HeaderText = "Patient DOB"
        Me.PatientDOB.MinimumWidth = 6
        Me.PatientDOB.Name = "PatientDOB"
        Me.PatientDOB.ReadOnly = True
        Me.PatientDOB.Width = 115
        '
        'ReportCreatorUserName
        '
        Me.ReportCreatorUserName.DataPropertyName = "UserName"
        Me.ReportCreatorUserName.HeaderText = "Report Creator UserName"
        Me.ReportCreatorUserName.MinimumWidth = 6
        Me.ReportCreatorUserName.Name = "ReportCreatorUserName"
        Me.ReportCreatorUserName.ReadOnly = True
        Me.ReportCreatorUserName.Width = 115
        '
        'GivenName
        '
        Me.GivenName.DataPropertyName = "GivenName"
        Me.GivenName.HeaderText = "Report Creator Name"
        Me.GivenName.MinimumWidth = 6
        Me.GivenName.Name = "GivenName"
        Me.GivenName.ReadOnly = True
        Me.GivenName.Width = 115
        '
        'ReportDetails
        '
        Me.ReportDetails.DataPropertyName = "ReportDetails"
        Me.ReportDetails.HeaderText = "Report Details"
        Me.ReportDetails.MinimumWidth = 6
        Me.ReportDetails.Name = "ReportDetails"
        Me.ReportDetails.ReadOnly = True
        Me.ReportDetails.Visible = False
        Me.ReportDetails.Width = 115
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
        Me.BtnOpen.Location = New System.Drawing.Point(1064, 601)
        Me.BtnOpen.Name = "BtnOpen"
        Me.BtnOpen.Size = New System.Drawing.Size(207, 66)
        Me.BtnOpen.TabIndex = 7
        Me.BtnOpen.Text = "Open Report"
        Me.BtnOpen.UseVisualStyleBackColor = True
        '
        'ReportPickerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1339, 694)
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
    Friend WithEvents ReportDate As DataGridViewTextBoxColumn
    Friend WithEvents PatientName As DataGridViewTextBoxColumn
    Friend WithEvents PatientID As DataGridViewTextBoxColumn
    Friend WithEvents PatientDOB As DataGridViewTextBoxColumn
    Friend WithEvents ReportCreatorUserName As DataGridViewTextBoxColumn
    Friend WithEvents GivenName As DataGridViewTextBoxColumn
    Friend WithEvents ReportDetails As DataGridViewTextBoxColumn
    Friend WithEvents BtnOpen As Button
End Class
