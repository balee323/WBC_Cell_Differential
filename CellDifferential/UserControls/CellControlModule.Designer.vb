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
        Me.TxtSeg = New System.Windows.Forms.TextBox()
        Me.LblSeg = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtSeg
        '
        Me.TxtSeg.BackColor = System.Drawing.Color.White
        Me.TxtSeg.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeg.ForeColor = System.Drawing.Color.Black
        Me.TxtSeg.Location = New System.Drawing.Point(19, 78)
        Me.TxtSeg.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtSeg.Name = "TxtSeg"
        Me.TxtSeg.ReadOnly = True
        Me.TxtSeg.Size = New System.Drawing.Size(57, 26)
        Me.TxtSeg.TabIndex = 13
        Me.TxtSeg.TabStop = False
        Me.TxtSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSeg
        '
        Me.LblSeg.AutoSize = True
        Me.LblSeg.BackColor = System.Drawing.Color.Transparent
        Me.LblSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeg.Location = New System.Drawing.Point(16, 25)
        Me.LblSeg.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblSeg.Name = "LblSeg"
        Me.LblSeg.Size = New System.Drawing.Size(62, 15)
        Me.LblSeg.TabIndex = 14
        Me.LblSeg.Text = "CellType"
        '
        'CellControlModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.TxtSeg)
        Me.Controls.Add(Me.LblSeg)
        Me.Name = "CellControlModule"
        Me.Size = New System.Drawing.Size(339, 303)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtSeg As TextBox
    Friend WithEvents LblSeg As Label
End Class
