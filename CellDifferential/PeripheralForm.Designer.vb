<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PeripheralForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PeripheralForm))
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnChangeCount = New System.Windows.Forms.Button()
        Me.TxtChangeCount = New System.Windows.Forms.TextBox()
        Me.BtnEditKeys = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.BtnReport = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtSeg = New System.Windows.Forms.TextBox()
        Me.TxtBand = New System.Windows.Forms.TextBox()
        Me.TxtBaso = New System.Windows.Forms.TextBox()
        Me.TxtMono = New System.Windows.Forms.TextBox()
        Me.TxtLym = New System.Windows.Forms.TextBox()
        Me.TxtNRBC = New System.Windows.Forms.TextBox()
        Me.LblSeg = New System.Windows.Forms.Label()
        Me.LblBand = New System.Windows.Forms.Label()
        Me.LblBaso = New System.Windows.Forms.Label()
        Me.LblMono = New System.Windows.Forms.Label()
        Me.LblLym = New System.Windows.Forms.Label()
        Me.LblNRBC = New System.Windows.Forms.Label()
        Me.TxtEos = New System.Windows.Forms.TextBox()
        Me.LblEos = New System.Windows.Forms.Label()
        Me.TxtMeta = New System.Windows.Forms.TextBox()
        Me.Txtmyelo = New System.Windows.Forms.TextBox()
        Me.TxtPromyelo = New System.Windows.Forms.TextBox()
        Me.TxtBlast = New System.Windows.Forms.TextBox()
        Me.LblPro = New System.Windows.Forms.Label()
        Me.LblMyelo = New System.Windows.Forms.Label()
        Me.LblMeta = New System.Windows.Forms.Label()
        Me.LblBlast = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BtnUndo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(129, 16)
        Me.BtnClear.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(70, 45)
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
        Me.BtnChangeCount.Location = New System.Drawing.Point(206, 16)
        Me.BtnChangeCount.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnChangeCount.Name = "BtnChangeCount"
        Me.BtnChangeCount.Size = New System.Drawing.Size(114, 24)
        Me.BtnChangeCount.TabIndex = 29
        Me.BtnChangeCount.TabStop = False
        Me.BtnChangeCount.Text = "Change Count"
        Me.BtnChangeCount.UseVisualStyleBackColor = False
        '
        'TxtChangeCount
        '
        Me.TxtChangeCount.BackColor = System.Drawing.Color.White
        Me.TxtChangeCount.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtChangeCount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.18868!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChangeCount.ForeColor = System.Drawing.Color.Black
        Me.TxtChangeCount.Location = New System.Drawing.Point(260, 47)
        Me.TxtChangeCount.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtChangeCount.Name = "TxtChangeCount"
        Me.TxtChangeCount.ReadOnly = True
        Me.TxtChangeCount.Size = New System.Drawing.Size(55, 25)
        Me.TxtChangeCount.TabIndex = 30
        Me.TxtChangeCount.TabStop = False
        Me.TxtChangeCount.Text = "100"
        Me.TxtChangeCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BtnEditKeys
        '
        Me.BtnEditKeys.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnEditKeys.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditKeys.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditKeys.Location = New System.Drawing.Point(299, 129)
        Me.BtnEditKeys.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnEditKeys.Name = "BtnEditKeys"
        Me.BtnEditKeys.Size = New System.Drawing.Size(75, 43)
        Me.BtnEditKeys.TabIndex = 32
        Me.BtnEditKeys.TabStop = False
        Me.BtnEditKeys.Text = "See Key Bindings"
        Me.BtnEditKeys.UseVisualStyleBackColor = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(5, 20)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(93, 20)
        Me.RadioButton1.TabIndex = 34
        Me.RadioButton1.Text = "Sound Off"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(5, 41)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(58, 20)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Ding"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(71, 41)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(94, 20)
        Me.RadioButton3.TabIndex = 36
        Me.RadioButton3.Text = "Explosion"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(97, 20)
        Me.RadioButton4.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(66, 20)
        Me.RadioButton4.TabIndex = 37
        Me.RadioButton4.Text = "Voice"
        Me.RadioButton4.UseVisualStyleBackColor = False
        '
        'BtnReport
        '
        Me.BtnReport.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnReport.Location = New System.Drawing.Point(386, 129)
        Me.BtnReport.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnReport.Name = "BtnReport"
        Me.BtnReport.Size = New System.Drawing.Size(84, 44)
        Me.BtnReport.TabIndex = 38
        Me.BtnReport.TabStop = False
        Me.BtnReport.Text = "Create Report"
        Me.BtnReport.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Controls.Add(Me.RadioButton4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(103, 120)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(187, 71)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Alert Sound Options"
        '
        'TxtTotal
        '
        Me.TxtTotal.BackColor = System.Drawing.Color.White
        Me.TxtTotal.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.ForeColor = System.Drawing.Color.Black
        Me.TxtTotal.Location = New System.Drawing.Point(860, 84)
        Me.TxtTotal.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.ReadOnly = True
        Me.TxtTotal.Size = New System.Drawing.Size(57, 28)
        Me.TxtTotal.TabIndex = 9
        Me.TxtTotal.TabStop = False
        Me.TxtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(852, 36)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 17)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "TOTAL"
        '
        'TxtSeg
        '
        Me.TxtSeg.BackColor = System.Drawing.Color.White
        Me.TxtSeg.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSeg.ForeColor = System.Drawing.Color.Black
        Me.TxtSeg.Location = New System.Drawing.Point(792, 84)
        Me.TxtSeg.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtSeg.Name = "TxtSeg"
        Me.TxtSeg.ReadOnly = True
        Me.TxtSeg.Size = New System.Drawing.Size(57, 28)
        Me.TxtSeg.TabIndex = 1
        Me.TxtSeg.TabStop = False
        Me.TxtSeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBand
        '
        Me.TxtBand.BackColor = System.Drawing.Color.White
        Me.TxtBand.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBand.ForeColor = System.Drawing.Color.Black
        Me.TxtBand.Location = New System.Drawing.Point(592, 84)
        Me.TxtBand.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtBand.Name = "TxtBand"
        Me.TxtBand.ReadOnly = True
        Me.TxtBand.Size = New System.Drawing.Size(57, 28)
        Me.TxtBand.TabIndex = 2
        Me.TxtBand.TabStop = False
        Me.TxtBand.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBaso
        '
        Me.TxtBaso.BackColor = System.Drawing.Color.White
        Me.TxtBaso.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtBaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBaso.ForeColor = System.Drawing.Color.Black
        Me.TxtBaso.Location = New System.Drawing.Point(463, 84)
        Me.TxtBaso.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtBaso.Name = "TxtBaso"
        Me.TxtBaso.ReadOnly = True
        Me.TxtBaso.Size = New System.Drawing.Size(57, 28)
        Me.TxtBaso.TabIndex = 3
        Me.TxtBaso.TabStop = False
        Me.TxtBaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtMono
        '
        Me.TxtMono.BackColor = System.Drawing.Color.White
        Me.TxtMono.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtMono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMono.ForeColor = System.Drawing.Color.Black
        Me.TxtMono.Location = New System.Drawing.Point(658, 84)
        Me.TxtMono.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtMono.Name = "TxtMono"
        Me.TxtMono.ReadOnly = True
        Me.TxtMono.Size = New System.Drawing.Size(57, 28)
        Me.TxtMono.TabIndex = 4
        Me.TxtMono.TabStop = False
        Me.TxtMono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtLym
        '
        Me.TxtLym.BackColor = System.Drawing.Color.White
        Me.TxtLym.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtLym.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtLym.ForeColor = System.Drawing.Color.Black
        Me.TxtLym.Location = New System.Drawing.Point(726, 84)
        Me.TxtLym.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtLym.Name = "TxtLym"
        Me.TxtLym.ReadOnly = True
        Me.TxtLym.Size = New System.Drawing.Size(57, 28)
        Me.TxtLym.TabIndex = 5
        Me.TxtLym.TabStop = False
        Me.TxtLym.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtNRBC
        '
        Me.TxtNRBC.BackColor = System.Drawing.Color.White
        Me.TxtNRBC.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtNRBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNRBC.ForeColor = System.Drawing.Color.Black
        Me.TxtNRBC.Location = New System.Drawing.Point(132, 82)
        Me.TxtNRBC.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtNRBC.Name = "TxtNRBC"
        Me.TxtNRBC.ReadOnly = True
        Me.TxtNRBC.Size = New System.Drawing.Size(57, 28)
        Me.TxtNRBC.TabIndex = 6
        Me.TxtNRBC.TabStop = False
        Me.TxtNRBC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblSeg
        '
        Me.LblSeg.AutoSize = True
        Me.LblSeg.BackColor = System.Drawing.Color.Transparent
        Me.LblSeg.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSeg.Location = New System.Drawing.Point(794, 36)
        Me.LblSeg.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblSeg.Name = "LblSeg"
        Me.LblSeg.Size = New System.Drawing.Size(40, 17)
        Me.LblSeg.TabIndex = 12
        Me.LblSeg.Text = "SEG"
        '
        'LblBand
        '
        Me.LblBand.AutoSize = True
        Me.LblBand.BackColor = System.Drawing.Color.Transparent
        Me.LblBand.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBand.Location = New System.Drawing.Point(591, 36)
        Me.LblBand.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBand.Name = "LblBand"
        Me.LblBand.Size = New System.Drawing.Size(50, 17)
        Me.LblBand.TabIndex = 13
        Me.LblBand.Text = "BAND"
        '
        'LblBaso
        '
        Me.LblBaso.AutoSize = True
        Me.LblBaso.BackColor = System.Drawing.Color.Transparent
        Me.LblBaso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBaso.Location = New System.Drawing.Point(465, 36)
        Me.LblBaso.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBaso.Name = "LblBaso"
        Me.LblBaso.Size = New System.Drawing.Size(50, 17)
        Me.LblBaso.TabIndex = 14
        Me.LblBaso.Text = "BASO"
        '
        'LblMono
        '
        Me.LblMono.AutoSize = True
        Me.LblMono.BackColor = System.Drawing.Color.Transparent
        Me.LblMono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMono.Location = New System.Drawing.Point(662, 36)
        Me.LblMono.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMono.Name = "LblMono"
        Me.LblMono.Size = New System.Drawing.Size(43, 17)
        Me.LblMono.TabIndex = 15
        Me.LblMono.Text = "MON"
        '
        'LblLym
        '
        Me.LblLym.AutoSize = True
        Me.LblLym.BackColor = System.Drawing.Color.Transparent
        Me.LblLym.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLym.Location = New System.Drawing.Point(728, 36)
        Me.LblLym.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblLym.Name = "LblLym"
        Me.LblLym.Size = New System.Drawing.Size(39, 17)
        Me.LblLym.TabIndex = 16
        Me.LblLym.Text = "LYM"
        '
        'LblNRBC
        '
        Me.LblNRBC.AutoSize = True
        Me.LblNRBC.BackColor = System.Drawing.Color.Transparent
        Me.LblNRBC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNRBC.Location = New System.Drawing.Point(137, 36)
        Me.LblNRBC.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblNRBC.Name = "LblNRBC"
        Me.LblNRBC.Size = New System.Drawing.Size(50, 17)
        Me.LblNRBC.TabIndex = 17
        Me.LblNRBC.Text = "NRBC"
        '
        'TxtEos
        '
        Me.TxtEos.BackColor = System.Drawing.Color.White
        Me.TxtEos.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtEos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEos.ForeColor = System.Drawing.Color.Black
        Me.TxtEos.Location = New System.Drawing.Point(529, 84)
        Me.TxtEos.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtEos.Name = "TxtEos"
        Me.TxtEos.ReadOnly = True
        Me.TxtEos.Size = New System.Drawing.Size(57, 28)
        Me.TxtEos.TabIndex = 19
        Me.TxtEos.TabStop = False
        Me.TxtEos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblEos
        '
        Me.LblEos.AutoSize = True
        Me.LblEos.BackColor = System.Drawing.Color.Transparent
        Me.LblEos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEos.Location = New System.Drawing.Point(537, 36)
        Me.LblEos.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblEos.Name = "LblEos"
        Me.LblEos.Size = New System.Drawing.Size(40, 17)
        Me.LblEos.TabIndex = 20
        Me.LblEos.Text = "EOS"
        '
        'TxtMeta
        '
        Me.TxtMeta.BackColor = System.Drawing.Color.White
        Me.TxtMeta.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtMeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMeta.ForeColor = System.Drawing.Color.Black
        Me.TxtMeta.Location = New System.Drawing.Point(396, 83)
        Me.TxtMeta.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtMeta.Name = "TxtMeta"
        Me.TxtMeta.ReadOnly = True
        Me.TxtMeta.Size = New System.Drawing.Size(57, 28)
        Me.TxtMeta.TabIndex = 21
        Me.TxtMeta.TabStop = False
        Me.TxtMeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Txtmyelo
        '
        Me.Txtmyelo.BackColor = System.Drawing.Color.White
        Me.Txtmyelo.Cursor = System.Windows.Forms.Cursors.No
        Me.Txtmyelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Txtmyelo.ForeColor = System.Drawing.Color.Black
        Me.Txtmyelo.Location = New System.Drawing.Point(329, 83)
        Me.Txtmyelo.Margin = New System.Windows.Forms.Padding(10)
        Me.Txtmyelo.Name = "Txtmyelo"
        Me.Txtmyelo.ReadOnly = True
        Me.Txtmyelo.Size = New System.Drawing.Size(57, 28)
        Me.Txtmyelo.TabIndex = 22
        Me.Txtmyelo.TabStop = False
        Me.Txtmyelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtPromyelo
        '
        Me.TxtPromyelo.BackColor = System.Drawing.Color.White
        Me.TxtPromyelo.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtPromyelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPromyelo.ForeColor = System.Drawing.Color.Black
        Me.TxtPromyelo.Location = New System.Drawing.Point(263, 82)
        Me.TxtPromyelo.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtPromyelo.Name = "TxtPromyelo"
        Me.TxtPromyelo.ReadOnly = True
        Me.TxtPromyelo.Size = New System.Drawing.Size(57, 28)
        Me.TxtPromyelo.TabIndex = 23
        Me.TxtPromyelo.TabStop = False
        Me.TxtPromyelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TxtBlast
        '
        Me.TxtBlast.BackColor = System.Drawing.Color.White
        Me.TxtBlast.Cursor = System.Windows.Forms.Cursors.No
        Me.TxtBlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBlast.ForeColor = System.Drawing.Color.Black
        Me.TxtBlast.Location = New System.Drawing.Point(199, 82)
        Me.TxtBlast.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtBlast.Name = "TxtBlast"
        Me.TxtBlast.ReadOnly = True
        Me.TxtBlast.Size = New System.Drawing.Size(57, 28)
        Me.TxtBlast.TabIndex = 24
        Me.TxtBlast.TabStop = False
        Me.TxtBlast.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LblPro
        '
        Me.LblPro.AutoSize = True
        Me.LblPro.BackColor = System.Drawing.Color.Transparent
        Me.LblPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPro.Location = New System.Drawing.Point(272, 36)
        Me.LblPro.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblPro.Name = "LblPro"
        Me.LblPro.Size = New System.Drawing.Size(41, 17)
        Me.LblPro.TabIndex = 25
        Me.LblPro.Text = "PRO"
        '
        'LblMyelo
        '
        Me.LblMyelo.AutoSize = True
        Me.LblMyelo.BackColor = System.Drawing.Color.Transparent
        Me.LblMyelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMyelo.Location = New System.Drawing.Point(321, 36)
        Me.LblMyelo.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMyelo.Name = "LblMyelo"
        Me.LblMyelo.Size = New System.Drawing.Size(61, 17)
        Me.LblMyelo.TabIndex = 26
        Me.LblMyelo.Text = "MYELO"
        '
        'LblMeta
        '
        Me.LblMeta.AutoSize = True
        Me.LblMeta.BackColor = System.Drawing.Color.Transparent
        Me.LblMeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMeta.Location = New System.Drawing.Point(398, 36)
        Me.LblMeta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblMeta.Name = "LblMeta"
        Me.LblMeta.Size = New System.Drawing.Size(50, 17)
        Me.LblMeta.TabIndex = 27
        Me.LblMeta.Text = "META"
        '
        'LblBlast
        '
        Me.LblBlast.AutoSize = True
        Me.LblBlast.BackColor = System.Drawing.Color.Transparent
        Me.LblBlast.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlast.Location = New System.Drawing.Point(199, 36)
        Me.LblBlast.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.LblBlast.Name = "LblBlast"
        Me.LblBlast.Size = New System.Drawing.Size(57, 17)
        Me.LblBlast.TabIndex = 28
        Me.LblBlast.Text = "BLAST"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 19)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(106, 17)
        Me.CheckBox1.TabIndex = 42
        Me.CheckBox1.Text = "Include NRBC"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BtnUndo)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.BtnClear)
        Me.GroupBox2.Controls.Add(Me.BtnChangeCount)
        Me.GroupBox2.Controls.Add(Me.TxtChangeCount)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(605, 120)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(324, 80)
        Me.GroupBox2.TabIndex = 43
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Counting Options"
        '
        'BtnUndo
        '
        Me.BtnUndo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.BtnUndo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUndo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.150944!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUndo.Location = New System.Drawing.Point(46, 38)
        Me.BtnUndo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.BtnUndo.Name = "BtnUndo"
        Me.BtnUndo.Size = New System.Drawing.Size(71, 23)
        Me.BtnUndo.TabIndex = 43
        Me.BtnUndo.TabStop = False
        Me.BtnUndo.Text = "Undo"
        Me.BtnUndo.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.830189!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(559, 334)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(445, 17)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "*Click on Channel labels to Change (i.e. SEG -> plasma cell)"
        '
        'PeripheralForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImage = Global.WBCDifferential.My.Resources.Resources.DiffCounter4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 360)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtBaso)
        Me.Controls.Add(Me.LblBaso)
        Me.Controls.Add(Me.TxtPromyelo)
        Me.Controls.Add(Me.LblPro)
        Me.Controls.Add(Me.TxtEos)
        Me.Controls.Add(Me.LblEos)
        Me.Controls.Add(Me.LblMyelo)
        Me.Controls.Add(Me.LblMeta)
        Me.Controls.Add(Me.LblBlast)
        Me.Controls.Add(Me.LblBand)
        Me.Controls.Add(Me.TxtBand)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Txtmyelo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TxtMeta)
        Me.Controls.Add(Me.TxtBlast)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnReport)
        Me.Controls.Add(Me.BtnEditKeys)
        Me.Controls.Add(Me.LblMono)
        Me.Controls.Add(Me.LblLym)
        Me.Controls.Add(Me.TxtMono)
        Me.Controls.Add(Me.TxtLym)
        Me.Controls.Add(Me.LblNRBC)
        Me.Controls.Add(Me.TxtNRBC)
        Me.Controls.Add(Me.TxtSeg)
        Me.Controls.Add(Me.LblSeg)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.MaximizeBox = False
        Me.Name = "PeripheralForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peripheral Counter"
        Me.TransparencyKey = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnChangeCount As System.Windows.Forms.Button
    Friend WithEvents TxtChangeCount As System.Windows.Forms.TextBox
    Friend WithEvents BtnEditKeys As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents BtnReport As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtSeg As System.Windows.Forms.TextBox
    Friend WithEvents TxtBand As System.Windows.Forms.TextBox
    Friend WithEvents TxtBaso As System.Windows.Forms.TextBox
    Friend WithEvents TxtMono As System.Windows.Forms.TextBox
    Friend WithEvents TxtLym As System.Windows.Forms.TextBox
    Friend WithEvents TxtNRBC As System.Windows.Forms.TextBox
    Friend WithEvents LblSeg As System.Windows.Forms.Label
    Friend WithEvents LblBand As System.Windows.Forms.Label
    Friend WithEvents LblBaso As System.Windows.Forms.Label
    Friend WithEvents LblMono As System.Windows.Forms.Label
    Friend WithEvents LblLym As System.Windows.Forms.Label
    Friend WithEvents LblNRBC As System.Windows.Forms.Label
    Friend WithEvents TxtEos As System.Windows.Forms.TextBox
    Friend WithEvents LblEos As System.Windows.Forms.Label
    Friend WithEvents TxtMeta As System.Windows.Forms.TextBox
    Friend WithEvents Txtmyelo As System.Windows.Forms.TextBox
    Friend WithEvents TxtPromyelo As System.Windows.Forms.TextBox
    Friend WithEvents TxtBlast As System.Windows.Forms.TextBox
    Friend WithEvents LblPro As System.Windows.Forms.Label
    Friend WithEvents LblMyelo As System.Windows.Forms.Label
    Friend WithEvents LblMeta As System.Windows.Forms.Label
    Friend WithEvents LblBlast As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnUndo As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
