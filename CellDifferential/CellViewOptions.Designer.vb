<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CellViewOptions
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
        Me.BtnDone = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.78182!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(319, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select which cells to view on counter"
        '
        'BtnDone
        '
        Me.BtnDone.Location = New System.Drawing.Point(16, 407)
        Me.BtnDone.Name = "BtnDone"
        Me.BtnDone.Size = New System.Drawing.Size(158, 35)
        Me.BtnDone.TabIndex = 3
        Me.BtnDone.Text = "Done"
        Me.BtnDone.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(17, 86)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(269, 304)
        Me.CheckedListBox1.TabIndex = 4
        '
        'CellViewOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 454)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.BtnDone)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CellViewOptions"
        Me.Text = "CellViewOptions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDone As Button
    Friend WithEvents CheckedListBox1 As CheckedListBox
End Class
