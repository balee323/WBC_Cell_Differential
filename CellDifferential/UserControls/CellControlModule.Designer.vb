<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellControlModule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.TxtCellTotal = New System.Windows.Forms.TextBox()
        Me.LblCellType = New System.Windows.Forms.Label()
        Me.ButtonPicture = New System.Windows.Forms.PictureBox()
        Me.CellPicture = New System.Windows.Forms.PictureBox()
        Me.LblBindingKey = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.ButtonPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CellPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtCellTotal
        '
        Me.TxtCellTotal.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.TxtCellTotal.BackColor = System.Drawing.Color.White
        Me.TxtCellTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCellTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCellTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtCellTotal.Location = New System.Drawing.Point(4, 108)
        Me.TxtCellTotal.Margin = New System.Windows.Forms.Padding(0)
        Me.TxtCellTotal.Name = "TxtCellTotal"
        Me.TxtCellTotal.ReadOnly = True
        Me.TxtCellTotal.Size = New System.Drawing.Size(71, 28)
        Me.TxtCellTotal.TabIndex = 13
        Me.TxtCellTotal.TabStop = False
        Me.TxtCellTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCellTotal.WordWrap = False
        '
        'LblCellType
        '
        Me.LblCellType.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblCellType.BackColor = System.Drawing.Color.Transparent
        Me.LblCellType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCellType.Location = New System.Drawing.Point(4, 62)
        Me.LblCellType.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblCellType.Name = "LblCellType"
        Me.LblCellType.Size = New System.Drawing.Size(74, 32)
        Me.LblCellType.TabIndex = 14
        Me.LblCellType.Text = "CellType"
        '
        'ButtonPicture
        '
        Me.ButtonPicture.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonPicture.BackColor = System.Drawing.Color.FromArgb(CType(CType(122, Byte), Integer), CType(CType(130, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.ButtonPicture.Image = Global.WBCDifferential.My.Resources.Resources.RedButton
        Me.ButtonPicture.Location = New System.Drawing.Point(0, 220)
        Me.ButtonPicture.Margin = New System.Windows.Forms.Padding(5)
        Me.ButtonPicture.Name = "ButtonPicture"
        Me.ButtonPicture.Size = New System.Drawing.Size(80, 80)
        Me.ButtonPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ButtonPicture.TabIndex = 16
        Me.ButtonPicture.TabStop = False
        '
        'CellPicture
        '
        Me.CellPicture.Dock = System.Windows.Forms.DockStyle.Top
        Me.CellPicture.Location = New System.Drawing.Point(0, 0)
        Me.CellPicture.Name = "CellPicture"
        Me.CellPicture.Size = New System.Drawing.Size(80, 50)
        Me.CellPicture.TabIndex = 15
        Me.CellPicture.TabStop = False
        '
        'LblBindingKey
        '
        Me.LblBindingKey.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LblBindingKey.BackColor = System.Drawing.Color.Transparent
        Me.LblBindingKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBindingKey.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LblBindingKey.Location = New System.Drawing.Point(3, 162)
        Me.LblBindingKey.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBindingKey.Name = "LblBindingKey"
        Me.LblBindingKey.Size = New System.Drawing.Size(75, 42)
        Me.LblBindingKey.TabIndex = 17
        Me.LblBindingKey.Text = "key"
        Me.LblBindingKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 9000
        Me.ToolTip1.InitialDelay = 150
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'CellControlModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Controls.Add(Me.LblBindingKey)
        Me.Controls.Add(Me.ButtonPicture)
        Me.Controls.Add(Me.CellPicture)
        Me.Controls.Add(Me.TxtCellTotal)
        Me.Controls.Add(Me.LblCellType)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CellControlModule"
        Me.Size = New System.Drawing.Size(80, 300)
        Me.ToolTip1.SetToolTip(Me, "testing")
        CType(Me.ButtonPicture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CellPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtCellTotal As TextBox
    Friend WithEvents LblCellType As Label
    Friend WithEvents CellPicture As PictureBox
    Friend WithEvents ButtonPicture As PictureBox
    Friend WithEvents LblBindingKey As Label
    Friend WithEvents ToolTip1 As ToolTip
End Class
