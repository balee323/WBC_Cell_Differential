<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewSavedReports = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrinterSetupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsFileLocationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeveloperInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GetSupportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AppVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LblActiveCounter1 = New System.Windows.Forms.Label()
        Me.LblActiveCounter2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MenuOptions, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(313, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 23)
        Me.ToolStripMenuItem1.Text = "Select Counter Type"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(186, 24)
        Me.ToolStripMenuItem2.Text = "Peripheral Diff"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(186, 24)
        Me.ToolStripMenuItem3.Text = "Bone Marrow Diff"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Enabled = False
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(186, 24)
        Me.ToolStripMenuItem4.Text = "Body Fluid Diff"
        '
        'MenuOptions
        '
        Me.MenuOptions.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewSavedReports, Me.PrinterSetupToolStripMenuItem, Me.ReportsFileLocationToolStripMenuItem})
        Me.MenuOptions.Name = "MenuOptions"
        Me.MenuOptions.Size = New System.Drawing.Size(70, 23)
        Me.MenuOptions.Text = "Options"
        '
        'ViewSavedReports
        '
        Me.ViewSavedReports.Enabled = False
        Me.ViewSavedReports.Name = "ViewSavedReports"
        Me.ViewSavedReports.Size = New System.Drawing.Size(205, 24)
        Me.ViewSavedReports.Text = "View Saved Reports"
        '
        'PrinterSetupToolStripMenuItem
        '
        Me.PrinterSetupToolStripMenuItem.Enabled = False
        Me.PrinterSetupToolStripMenuItem.Name = "PrinterSetupToolStripMenuItem"
        Me.PrinterSetupToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.PrinterSetupToolStripMenuItem.Text = "Printer Setup"
        '
        'ReportsFileLocationToolStripMenuItem
        '
        Me.ReportsFileLocationToolStripMenuItem.Enabled = False
        Me.ReportsFileLocationToolStripMenuItem.Name = "ReportsFileLocationToolStripMenuItem"
        Me.ReportsFileLocationToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.ReportsFileLocationToolStripMenuItem.Text = "Reports File Location"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeveloperInfoToolStripMenuItem, Me.GetSupportToolStripMenuItem, Me.AppVersionToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(59, 23)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'DeveloperInfoToolStripMenuItem
        '
        Me.DeveloperInfoToolStripMenuItem.Name = "DeveloperInfoToolStripMenuItem"
        Me.DeveloperInfoToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.DeveloperInfoToolStripMenuItem.Text = "Developer Info"
        '
        'GetSupportToolStripMenuItem
        '
        Me.GetSupportToolStripMenuItem.Name = "GetSupportToolStripMenuItem"
        Me.GetSupportToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.GetSupportToolStripMenuItem.Text = "Get Support"
        '
        'AppVersionToolStripMenuItem
        '
        Me.AppVersionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem6})
        Me.AppVersionToolStripMenuItem.Name = "AppVersionToolStripMenuItem"
        Me.AppVersionToolStripMenuItem.Size = New System.Drawing.Size(168, 24)
        Me.AppVersionToolStripMenuItem.Text = "App Version"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(119, 24)
        Me.ToolStripMenuItem6.Text = "3.0.0.2"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.LblActiveCounter2)
        Me.GroupBox1.Controls.Add(Me.LblActiveCounter1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 132)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active Counters"
        '
        'LblActiveCounter1
        '
        Me.LblActiveCounter1.AutoSize = True
        Me.LblActiveCounter1.Location = New System.Drawing.Point(10, 26)
        Me.LblActiveCounter1.Name = "LblActiveCounter1"
        Me.LblActiveCounter1.Size = New System.Drawing.Size(39, 13)
        Me.LblActiveCounter1.TabIndex = 0
        Me.LblActiveCounter1.Text = "Label1"
        Me.LblActiveCounter1.Visible = False
        '
        'LblActiveCounter2
        '
        Me.LblActiveCounter2.AutoSize = True
        Me.LblActiveCounter2.Location = New System.Drawing.Point(10, 51)
        Me.LblActiveCounter2.Name = "LblActiveCounter2"
        Me.LblActiveCounter2.Size = New System.Drawing.Size(39, 13)
        Me.LblActiveCounter2.TabIndex = 1
        Me.LblActiveCounter2.Text = "Label2"
        Me.LblActiveCounter2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.890909!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(119, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "* click to open"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 244)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainForm"
        Me.Text = "WBC Differential Launcher"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuOptions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewSavedReports As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrinterSetupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsFileLocationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeveloperInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GetSupportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AppVersionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents LblActiveCounter1 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LblActiveCounter2 As System.Windows.Forms.Label
End Class
