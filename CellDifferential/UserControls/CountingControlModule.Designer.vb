<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CountingControlModule
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.BtnEditKeys = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnUndo = New System.Windows.Forms.Button()
        Me.ChkBoxIncludeNRBC = New System.Windows.Forms.CheckBox()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnChangeCount = New System.Windows.Forms.Button()
        Me.TxtCountLimit = New System.Windows.Forms.TextBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnReport
        '
        Me.BtnReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.Location = New System.Drawing.Point(115, 220)
        Me.BtnReport.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(70, 40)
        Me.BtnReport.TabIndex = 40
        Me.BtnReport.TabStop = False
        Me.BtnReport.Text = "Create Report"
        Me.BtnReport.UseVisualStyleBackColor = False
        '
        'BtnEditKeys
        '
        Me.BtnEditKeys.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnEditKeys.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditKeys.Location = New System.Drawing.Point(11, 221)
        Me.BtnEditKeys.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnEditKeys.Name = "BtnEditKeys"
        Me.BtnEditKeys.Size = New System.Drawing.Size(70, 40)
        Me.BtnEditKeys.TabIndex = 39
        Me.BtnEditKeys.TabStop = False
        Me.BtnEditKeys.Text = "See Key Bindings"
        Me.BtnEditKeys.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnUndo)
        Me.GroupBox2.Controls.Add(Me.ChkBoxIncludeNRBC)
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnChangeCount)
        Me.GroupBox2.Controls.Add(Me.TxtCountLimit)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 61)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(174, 155)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Counting Options"
        '
        'BtnUndo
        '
        Me.BtnUndo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUndo.Location = New System.Drawing.Point(6, 75)
        Me.BtnUndo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(149, 30)
        Me.BtnUndo.TabIndex = 43
        Me.BtnUndo.TabStop = False
        Me.BtnUndo.Text = "Undo"
        Me.BtnUndo.UseVisualStyleBackColor = False
        '
        'ChkBoxIncludeNRBC
        '
        Me.ChkBoxIncludeNRBC.AutoSize = True
        Me.ChkBoxIncludeNRBC.Location = New System.Drawing.Point(6, 17)
        Me.ChkBoxIncludeNRBC.Name = "ChkBoxIncludeNRBC"
        Me.ChkBoxIncludeNRBC.Size = New System.Drawing.Size(103, 17)
        Me.ChkBoxIncludeNRBC.TabIndex = 42
        Me.ChkBoxIncludeNRBC.Text = "Include NRBC"
        Me.ChkBoxIncludeNRBC.UseVisualStyleBackColor = True
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(6, 115)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(149, 30)
        Me.BtnClear.TabIndex = 11
        Me.BtnClear.TabStop = False
        Me.BtnClear.Text = "Clear Counter"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnChangeCount
        '
        Me.BtnChangeCount.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnChangeCount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChangeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChangeCount.Location = New System.Drawing.Point(52, 39)
        Me.BtnChangeCount.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnChangeCount.Name = "BtnChangeCount"
        Me.BtnChangeCount.Size = New System.Drawing.Size(103, 30)
        Me.BtnChangeCount.TabIndex = 29
        Me.BtnChangeCount.TabStop = False
        Me.BtnChangeCount.Text = "Change Count"
        Me.BtnChangeCount.UseVisualStyleBackColor = False
        '
        'TxtCountLimit
        '
        Me.TxtCountLimit.BackColor = System.Drawing.Color.White
        Me.TxtCountLimit.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtCountLimit.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCountLimit.ForeColor = System.Drawing.Color.Black
        Me.TxtCountLimit.Location = New System.Drawing.Point(6, 42)
        Me.TxtCountLimit.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtCountLimit.Name = "TxtCountLimit"
        Me.TxtCountLimit.ReadOnly = True
        Me.TxtCountLimit.Size = New System.Drawing.Size(43, 23)
        Me.TxtCountLimit.TabIndex = 30
        Me.TxtCountLimit.TabStop = False
        Me.TxtCountLimit.Text = "100"
        Me.TxtCountLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtTotal.Location = New System.Drawing.Point(97, 17)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(88, 32)
        Me.TxtTotal.TabIndex = 44
        Me.TxtTotal.TabStop = False
        Me.TxtTotal.Text = "100"
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 26)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Total"
        '
        'CountingControlModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(140, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnEditKeys)
        Me.Margin = New System.Windows.Forms.Padding(0)
        Me.Name = "CountingControlModule"
        Me.Size = New System.Drawing.Size(195, 300)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnReport As Button
    Friend WithEvents BtnEditKeys As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BtnUndo As Button
    Friend WithEvents ChkBoxIncludeNRBC As CheckBox
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnChangeCount As Button
    Friend WithEvents TxtCountLimit As TextBox
    Friend WithEvents TxtTotal As TextBox
    Friend WithEvents Label1 As Label
End Class
