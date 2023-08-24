<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExercise
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPageIndex = New System.Windows.Forms.Label()
        Me.cmdLast = New System.Windows.Forms.Button()
        Me.cmdNext = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ExamGroup = New System.Windows.Forms.GroupBox()
        Me.txtAnswerD4 = New System.Windows.Forms.TextBox()
        Me.txtAnswerC4 = New System.Windows.Forms.TextBox()
        Me.txtAnswerB4 = New System.Windows.Forms.TextBox()
        Me.txtAnswerA4 = New System.Windows.Forms.TextBox()
        Me.D4 = New System.Windows.Forms.CheckBox()
        Me.B4 = New System.Windows.Forms.CheckBox()
        Me.C4 = New System.Windows.Forms.CheckBox()
        Me.A4 = New System.Windows.Forms.CheckBox()
        Me.txtExercise4 = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtAnswerD2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerC2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerB2 = New System.Windows.Forms.TextBox()
        Me.txtAnswerA2 = New System.Windows.Forms.TextBox()
        Me.D2 = New System.Windows.Forms.CheckBox()
        Me.B2 = New System.Windows.Forms.CheckBox()
        Me.C2 = New System.Windows.Forms.CheckBox()
        Me.A2 = New System.Windows.Forms.CheckBox()
        Me.txtExercise2 = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtAnswerD3 = New System.Windows.Forms.TextBox()
        Me.txtAnswerC3 = New System.Windows.Forms.TextBox()
        Me.txtAnswerB3 = New System.Windows.Forms.TextBox()
        Me.txtAnswerA3 = New System.Windows.Forms.TextBox()
        Me.D3 = New System.Windows.Forms.CheckBox()
        Me.B3 = New System.Windows.Forms.CheckBox()
        Me.C3 = New System.Windows.Forms.CheckBox()
        Me.A3 = New System.Windows.Forms.CheckBox()
        Me.txtExercise3 = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtAnswerD1 = New System.Windows.Forms.TextBox()
        Me.txtAnswerC1 = New System.Windows.Forms.TextBox()
        Me.txtAnswerB1 = New System.Windows.Forms.TextBox()
        Me.txtAnswerA1 = New System.Windows.Forms.TextBox()
        Me.D1 = New System.Windows.Forms.CheckBox()
        Me.B1 = New System.Windows.Forms.CheckBox()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.A1 = New System.Windows.Forms.CheckBox()
        Me.txtExercise1 = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.UserGroup = New System.Windows.Forms.GroupBox()
        Me.txtDuty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.cmdGet = New System.Windows.Forms.Button()
        Me.cmbDutyGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShift = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.ExamGroup.SuspendLayout()
        Me.UserGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblPageIndex
        '
        Me.lblPageIndex.AutoSize = True
        Me.lblPageIndex.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblPageIndex.Location = New System.Drawing.Point(116, 20)
        Me.lblPageIndex.Name = "lblPageIndex"
        Me.lblPageIndex.Size = New System.Drawing.Size(116, 14)
        Me.lblPageIndex.TabIndex = 53
        Me.lblPageIndex.Text = "First Page/หน้าแรก"
        '
        'cmdLast
        '
        Me.cmdLast.Location = New System.Drawing.Point(34, 9)
        Me.cmdLast.Name = "cmdLast"
        Me.cmdLast.Size = New System.Drawing.Size(76, 37)
        Me.cmdLast.TabIndex = 54
        Me.cmdLast.Text = "Previous ก่อนหน้า"
        Me.cmdLast.UseVisualStyleBackColor = True
        '
        'cmdNext
        '
        Me.cmdNext.Location = New System.Drawing.Point(238, 9)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(73, 37)
        Me.cmdNext.TabIndex = 55
        Me.cmdNext.Text = "Next ถัดไป"
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdLast)
        Me.GroupBox1.Controls.Add(Me.cmdNext)
        Me.GroupBox1.Controls.Add(Me.lblPageIndex)
        Me.GroupBox1.Location = New System.Drawing.Point(319, 116)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 52)
        Me.GroupBox1.TabIndex = 57
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Visible = False
        '
        'ExamGroup
        '
        Me.ExamGroup.Controls.Add(Me.txtAnswerD4)
        Me.ExamGroup.Controls.Add(Me.txtAnswerC4)
        Me.ExamGroup.Controls.Add(Me.txtAnswerB4)
        Me.ExamGroup.Controls.Add(Me.txtAnswerA4)
        Me.ExamGroup.Controls.Add(Me.D4)
        Me.ExamGroup.Controls.Add(Me.B4)
        Me.ExamGroup.Controls.Add(Me.C4)
        Me.ExamGroup.Controls.Add(Me.A4)
        Me.ExamGroup.Controls.Add(Me.txtExercise4)
        Me.ExamGroup.Controls.Add(Me.lbl4)
        Me.ExamGroup.Controls.Add(Me.txtAnswerD2)
        Me.ExamGroup.Controls.Add(Me.txtAnswerC2)
        Me.ExamGroup.Controls.Add(Me.txtAnswerB2)
        Me.ExamGroup.Controls.Add(Me.txtAnswerA2)
        Me.ExamGroup.Controls.Add(Me.D2)
        Me.ExamGroup.Controls.Add(Me.B2)
        Me.ExamGroup.Controls.Add(Me.C2)
        Me.ExamGroup.Controls.Add(Me.A2)
        Me.ExamGroup.Controls.Add(Me.txtExercise2)
        Me.ExamGroup.Controls.Add(Me.lbl2)
        Me.ExamGroup.Controls.Add(Me.txtAnswerD3)
        Me.ExamGroup.Controls.Add(Me.txtAnswerC3)
        Me.ExamGroup.Controls.Add(Me.txtAnswerB3)
        Me.ExamGroup.Controls.Add(Me.txtAnswerA3)
        Me.ExamGroup.Controls.Add(Me.D3)
        Me.ExamGroup.Controls.Add(Me.B3)
        Me.ExamGroup.Controls.Add(Me.C3)
        Me.ExamGroup.Controls.Add(Me.A3)
        Me.ExamGroup.Controls.Add(Me.txtExercise3)
        Me.ExamGroup.Controls.Add(Me.lbl3)
        Me.ExamGroup.Controls.Add(Me.txtAnswerD1)
        Me.ExamGroup.Controls.Add(Me.txtAnswerC1)
        Me.ExamGroup.Controls.Add(Me.txtAnswerB1)
        Me.ExamGroup.Controls.Add(Me.txtAnswerA1)
        Me.ExamGroup.Controls.Add(Me.D1)
        Me.ExamGroup.Controls.Add(Me.B1)
        Me.ExamGroup.Controls.Add(Me.C1)
        Me.ExamGroup.Controls.Add(Me.A1)
        Me.ExamGroup.Controls.Add(Me.txtExercise1)
        Me.ExamGroup.Controls.Add(Me.lbl1)
        Me.ExamGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.ExamGroup.Location = New System.Drawing.Point(24, 175)
        Me.ExamGroup.Name = "ExamGroup"
        Me.ExamGroup.Size = New System.Drawing.Size(979, 526)
        Me.ExamGroup.TabIndex = 58
        Me.ExamGroup.TabStop = False
        Me.ExamGroup.Text = "Question"
        Me.ExamGroup.Visible = False
        '
        'txtAnswerD4
        '
        Me.txtAnswerD4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerD4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerD4.Location = New System.Drawing.Point(538, 482)
        Me.txtAnswerD4.Multiline = True
        Me.txtAnswerD4.Name = "txtAnswerD4"
        Me.txtAnswerD4.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerD4.TabIndex = 133
        '
        'txtAnswerC4
        '
        Me.txtAnswerC4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerC4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerC4.Location = New System.Drawing.Point(538, 446)
        Me.txtAnswerC4.Multiline = True
        Me.txtAnswerC4.Name = "txtAnswerC4"
        Me.txtAnswerC4.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerC4.TabIndex = 132
        '
        'txtAnswerB4
        '
        Me.txtAnswerB4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerB4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerB4.Location = New System.Drawing.Point(538, 410)
        Me.txtAnswerB4.Multiline = True
        Me.txtAnswerB4.Name = "txtAnswerB4"
        Me.txtAnswerB4.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerB4.TabIndex = 131
        '
        'txtAnswerA4
        '
        Me.txtAnswerA4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerA4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerA4.Location = New System.Drawing.Point(538, 375)
        Me.txtAnswerA4.Multiline = True
        Me.txtAnswerA4.Name = "txtAnswerA4"
        Me.txtAnswerA4.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerA4.TabIndex = 130
        '
        'D4
        '
        Me.D4.AutoSize = True
        Me.D4.Location = New System.Drawing.Point(506, 480)
        Me.D4.Name = "D4"
        Me.D4.Size = New System.Drawing.Size(35, 19)
        Me.D4.TabIndex = 129
        Me.D4.Text = "D"
        Me.D4.UseVisualStyleBackColor = True
        '
        'B4
        '
        Me.B4.AutoSize = True
        Me.B4.Location = New System.Drawing.Point(507, 409)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(34, 19)
        Me.B4.TabIndex = 128
        Me.B4.Text = "B"
        Me.B4.UseVisualStyleBackColor = True
        '
        'C4
        '
        Me.C4.AutoSize = True
        Me.C4.Location = New System.Drawing.Point(506, 444)
        Me.C4.Name = "C4"
        Me.C4.Size = New System.Drawing.Size(34, 19)
        Me.C4.TabIndex = 127
        Me.C4.Text = "C"
        Me.C4.UseVisualStyleBackColor = True
        '
        'A4
        '
        Me.A4.AutoSize = True
        Me.A4.Location = New System.Drawing.Point(507, 374)
        Me.A4.Name = "A4"
        Me.A4.Size = New System.Drawing.Size(33, 19)
        Me.A4.TabIndex = 126
        Me.A4.Text = "A"
        Me.A4.UseVisualStyleBackColor = True
        '
        'txtExercise4
        '
        Me.txtExercise4.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtExercise4.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExercise4.Location = New System.Drawing.Point(506, 290)
        Me.txtExercise4.Multiline = True
        Me.txtExercise4.Name = "txtExercise4"
        Me.txtExercise4.Size = New System.Drawing.Size(450, 77)
        Me.txtExercise4.TabIndex = 125
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl4.Location = New System.Drawing.Point(501, 269)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(116, 13)
        Me.lbl4.TabIndex = 124
        Me.lbl4.Text = "4th Question/คำถามที่4"
        '
        'txtAnswerD2
        '
        Me.txtAnswerD2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerD2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerD2.Location = New System.Drawing.Point(545, 232)
        Me.txtAnswerD2.Multiline = True
        Me.txtAnswerD2.Name = "txtAnswerD2"
        Me.txtAnswerD2.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerD2.TabIndex = 123
        '
        'txtAnswerC2
        '
        Me.txtAnswerC2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerC2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerC2.Location = New System.Drawing.Point(545, 196)
        Me.txtAnswerC2.Multiline = True
        Me.txtAnswerC2.Name = "txtAnswerC2"
        Me.txtAnswerC2.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerC2.TabIndex = 122
        '
        'txtAnswerB2
        '
        Me.txtAnswerB2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerB2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerB2.Location = New System.Drawing.Point(545, 160)
        Me.txtAnswerB2.Multiline = True
        Me.txtAnswerB2.Name = "txtAnswerB2"
        Me.txtAnswerB2.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerB2.TabIndex = 121
        '
        'txtAnswerA2
        '
        Me.txtAnswerA2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerA2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerA2.Location = New System.Drawing.Point(545, 124)
        Me.txtAnswerA2.Multiline = True
        Me.txtAnswerA2.Name = "txtAnswerA2"
        Me.txtAnswerA2.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerA2.TabIndex = 120
        '
        'D2
        '
        Me.D2.AutoSize = True
        Me.D2.Location = New System.Drawing.Point(508, 230)
        Me.D2.Name = "D2"
        Me.D2.Size = New System.Drawing.Size(35, 19)
        Me.D2.TabIndex = 119
        Me.D2.Text = "D"
        Me.D2.UseVisualStyleBackColor = True
        '
        'B2
        '
        Me.B2.AutoSize = True
        Me.B2.Location = New System.Drawing.Point(509, 158)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(34, 19)
        Me.B2.TabIndex = 118
        Me.B2.Text = "B"
        Me.B2.UseVisualStyleBackColor = True
        '
        'C2
        '
        Me.C2.AutoSize = True
        Me.C2.Location = New System.Drawing.Point(508, 194)
        Me.C2.Name = "C2"
        Me.C2.Size = New System.Drawing.Size(34, 19)
        Me.C2.TabIndex = 117
        Me.C2.Text = "C"
        Me.C2.UseVisualStyleBackColor = True
        '
        'A2
        '
        Me.A2.AutoSize = True
        Me.A2.Location = New System.Drawing.Point(509, 124)
        Me.A2.Name = "A2"
        Me.A2.Size = New System.Drawing.Size(33, 19)
        Me.A2.TabIndex = 116
        Me.A2.Text = "A"
        Me.A2.UseVisualStyleBackColor = True
        '
        'txtExercise2
        '
        Me.txtExercise2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtExercise2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExercise2.Location = New System.Drawing.Point(508, 40)
        Me.txtExercise2.Multiline = True
        Me.txtExercise2.Name = "txtExercise2"
        Me.txtExercise2.Size = New System.Drawing.Size(450, 77)
        Me.txtExercise2.TabIndex = 115
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl2.Location = New System.Drawing.Point(503, 19)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(119, 13)
        Me.lbl2.TabIndex = 114
        Me.lbl2.Text = "2nd Question/คำถามที่2"
        '
        'txtAnswerD3
        '
        Me.txtAnswerD3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerD3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerD3.Location = New System.Drawing.Point(50, 482)
        Me.txtAnswerD3.Multiline = True
        Me.txtAnswerD3.Name = "txtAnswerD3"
        Me.txtAnswerD3.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerD3.TabIndex = 113
        '
        'txtAnswerC3
        '
        Me.txtAnswerC3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerC3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerC3.Location = New System.Drawing.Point(50, 446)
        Me.txtAnswerC3.Multiline = True
        Me.txtAnswerC3.Name = "txtAnswerC3"
        Me.txtAnswerC3.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerC3.TabIndex = 112
        '
        'txtAnswerB3
        '
        Me.txtAnswerB3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerB3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerB3.Location = New System.Drawing.Point(50, 410)
        Me.txtAnswerB3.Multiline = True
        Me.txtAnswerB3.Name = "txtAnswerB3"
        Me.txtAnswerB3.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerB3.TabIndex = 111
        '
        'txtAnswerA3
        '
        Me.txtAnswerA3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerA3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerA3.Location = New System.Drawing.Point(50, 375)
        Me.txtAnswerA3.Multiline = True
        Me.txtAnswerA3.Name = "txtAnswerA3"
        Me.txtAnswerA3.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerA3.TabIndex = 110
        '
        'D3
        '
        Me.D3.AutoSize = True
        Me.D3.Location = New System.Drawing.Point(13, 480)
        Me.D3.Name = "D3"
        Me.D3.Size = New System.Drawing.Size(35, 19)
        Me.D3.TabIndex = 109
        Me.D3.Text = "D"
        Me.D3.UseVisualStyleBackColor = True
        '
        'B3
        '
        Me.B3.AutoSize = True
        Me.B3.Location = New System.Drawing.Point(14, 409)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(34, 19)
        Me.B3.TabIndex = 108
        Me.B3.Text = "B"
        Me.B3.UseVisualStyleBackColor = True
        '
        'C3
        '
        Me.C3.AutoSize = True
        Me.C3.Location = New System.Drawing.Point(13, 444)
        Me.C3.Name = "C3"
        Me.C3.Size = New System.Drawing.Size(34, 19)
        Me.C3.TabIndex = 107
        Me.C3.Text = "C"
        Me.C3.UseVisualStyleBackColor = True
        '
        'A3
        '
        Me.A3.AutoSize = True
        Me.A3.Location = New System.Drawing.Point(14, 374)
        Me.A3.Name = "A3"
        Me.A3.Size = New System.Drawing.Size(33, 19)
        Me.A3.TabIndex = 106
        Me.A3.Text = "A"
        Me.A3.UseVisualStyleBackColor = True
        '
        'txtExercise3
        '
        Me.txtExercise3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtExercise3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExercise3.Location = New System.Drawing.Point(13, 290)
        Me.txtExercise3.Multiline = True
        Me.txtExercise3.Name = "txtExercise3"
        Me.txtExercise3.Size = New System.Drawing.Size(450, 77)
        Me.txtExercise3.TabIndex = 105
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl3.Location = New System.Drawing.Point(8, 269)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(116, 13)
        Me.lbl3.TabIndex = 104
        Me.lbl3.Text = "3rd Question/คำถามที่3"
        '
        'txtAnswerD1
        '
        Me.txtAnswerD1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerD1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerD1.Location = New System.Drawing.Point(50, 232)
        Me.txtAnswerD1.Multiline = True
        Me.txtAnswerD1.Name = "txtAnswerD1"
        Me.txtAnswerD1.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerD1.TabIndex = 103
        '
        'txtAnswerC1
        '
        Me.txtAnswerC1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerC1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerC1.Location = New System.Drawing.Point(50, 196)
        Me.txtAnswerC1.Multiline = True
        Me.txtAnswerC1.Name = "txtAnswerC1"
        Me.txtAnswerC1.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerC1.TabIndex = 102
        '
        'txtAnswerB1
        '
        Me.txtAnswerB1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerB1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerB1.Location = New System.Drawing.Point(50, 160)
        Me.txtAnswerB1.Multiline = True
        Me.txtAnswerB1.Name = "txtAnswerB1"
        Me.txtAnswerB1.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerB1.TabIndex = 101
        '
        'txtAnswerA1
        '
        Me.txtAnswerA1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtAnswerA1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAnswerA1.Location = New System.Drawing.Point(50, 124)
        Me.txtAnswerA1.Multiline = True
        Me.txtAnswerA1.Name = "txtAnswerA1"
        Me.txtAnswerA1.ReadOnly = True
        Me.txtAnswerA1.Size = New System.Drawing.Size(413, 26)
        Me.txtAnswerA1.TabIndex = 100
        '
        'D1
        '
        Me.D1.AutoSize = True
        Me.D1.Location = New System.Drawing.Point(15, 230)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(35, 19)
        Me.D1.TabIndex = 99
        Me.D1.Text = "D"
        Me.D1.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Location = New System.Drawing.Point(16, 158)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(34, 19)
        Me.B1.TabIndex = 98
        Me.B1.Text = "B"
        Me.B1.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(15, 194)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(34, 19)
        Me.C1.TabIndex = 97
        Me.C1.Text = "C"
        Me.C1.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(16, 124)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(33, 19)
        Me.A1.TabIndex = 96
        Me.A1.Text = "A"
        Me.A1.UseVisualStyleBackColor = True
        '
        'txtExercise1
        '
        Me.txtExercise1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtExercise1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtExercise1.Location = New System.Drawing.Point(15, 40)
        Me.txtExercise1.Multiline = True
        Me.txtExercise1.Name = "txtExercise1"
        Me.txtExercise1.Size = New System.Drawing.Size(450, 77)
        Me.txtExercise1.TabIndex = 95
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lbl1.Location = New System.Drawing.Point(10, 19)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(115, 13)
        Me.lbl1.TabIndex = 94
        Me.lbl1.Text = "1st Question/คำถามที่1"
        '
        'UserGroup
        '
        Me.UserGroup.Controls.Add(Me.txtDuty)
        Me.UserGroup.Controls.Add(Me.Label1)
        Me.UserGroup.Controls.Add(Me.txtGroup)
        Me.UserGroup.Controls.Add(Me.cmdExit)
        Me.UserGroup.Controls.Add(Me.cmdFinish)
        Me.UserGroup.Controls.Add(Me.cmdStart)
        Me.UserGroup.Controls.Add(Me.cmdGet)
        Me.UserGroup.Controls.Add(Me.cmbDutyGroup)
        Me.UserGroup.Controls.Add(Me.Label6)
        Me.UserGroup.Controls.Add(Me.txtShift)
        Me.UserGroup.Controls.Add(Me.Label7)
        Me.UserGroup.Controls.Add(Me.Label8)
        Me.UserGroup.Controls.Add(Me.txtUserName)
        Me.UserGroup.Controls.Add(Me.txtUserID)
        Me.UserGroup.Controls.Add(Me.Label10)
        Me.UserGroup.Controls.Add(Me.Label12)
        Me.UserGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UserGroup.Location = New System.Drawing.Point(24, 12)
        Me.UserGroup.Name = "UserGroup"
        Me.UserGroup.Size = New System.Drawing.Size(979, 114)
        Me.UserGroup.TabIndex = 59
        Me.UserGroup.TabStop = False
        Me.UserGroup.Text = "Staff Information/ข้อมูลพนักงาน"
        '
        'txtDuty
        '
        Me.txtDuty.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuty.Location = New System.Drawing.Point(375, 56)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.ReadOnly = True
        Me.txtDuty.Size = New System.Drawing.Size(104, 21)
        Me.txtDuty.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(278, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Job Title/หัวข้องาน"
        '
        'txtGroup
        '
        Me.txtGroup.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroup.Location = New System.Drawing.Point(168, 56)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.ReadOnly = True
        Me.txtGroup.Size = New System.Drawing.Size(104, 21)
        Me.txtGroup.TabIndex = 95
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(855, 65)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(96, 49)
        Me.cmdExit.TabIndex = 94
        Me.cmdExit.Text = "Exit ออก"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdFinish
        '
        Me.cmdFinish.Enabled = False
        Me.cmdFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFinish.Location = New System.Drawing.Point(751, 65)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(98, 49)
        Me.cmdFinish.TabIndex = 93
        Me.cmdFinish.Text = "Finish Answer ตอบเสร็จสิ้น"
        Me.cmdFinish.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.Enabled = False
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStart.Location = New System.Drawing.Point(855, 7)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(96, 52)
        Me.cmdStart.TabIndex = 92
        Me.cmdStart.Text = "Start Answer เริ่มตอบ"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'cmdGet
        '
        Me.cmdGet.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdGet.Location = New System.Drawing.Point(751, 7)
        Me.cmdGet.Name = "cmdGet"
        Me.cmdGet.Size = New System.Drawing.Size(98, 52)
        Me.cmdGet.TabIndex = 91
        Me.cmdGet.Text = "Get Test Item รับไอเทมทดสอบ"
        Me.cmdGet.UseVisualStyleBackColor = True
        '
        'cmbDutyGroup
        '
        Me.cmbDutyGroup.FormattingEnabled = True
        Me.cmbDutyGroup.Location = New System.Drawing.Point(615, 56)
        Me.cmbDutyGroup.Name = "cmbDutyGroup"
        Me.cmbDutyGroup.Size = New System.Drawing.Size(104, 23)
        Me.cmbDutyGroup.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Type Group/ประเถทกลุ่ม"
        '
        'txtShift
        '
        Me.txtShift.BackColor = System.Drawing.SystemColors.Window
        Me.txtShift.Location = New System.Drawing.Point(615, 23)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.ReadOnly = True
        Me.txtShift.Size = New System.Drawing.Size(104, 21)
        Me.txtShift.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(564, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Shift/กะ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(510, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Job Group/กลุ่มงาน"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Location = New System.Drawing.Point(375, 22)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(104, 21)
        Me.txtUserName.TabIndex = 82
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Location = New System.Drawing.Point(168, 23)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(104, 21)
        Me.txtUserID.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(316, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Name/ชื่อ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(33, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "EmployeeID/รหัสพนักงาน"
        '
        'Timer1
        '
        '
        'frmExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 724)
        Me.Controls.Add(Me.UserGroup)
        Me.Controls.Add(Me.ExamGroup)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmExercise"
        Me.Text = "frmExercise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ExamGroup.ResumeLayout(False)
        Me.ExamGroup.PerformLayout()
        Me.UserGroup.ResumeLayout(False)
        Me.UserGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblPageIndex As System.Windows.Forms.Label
    Friend WithEvents cmdLast As System.Windows.Forms.Button
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents ExamGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnswerD4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB4 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerA4 As System.Windows.Forms.TextBox
    Friend WithEvents D4 As System.Windows.Forms.CheckBox
    Friend WithEvents B4 As System.Windows.Forms.CheckBox
    Friend WithEvents C4 As System.Windows.Forms.CheckBox
    Friend WithEvents A4 As System.Windows.Forms.CheckBox
    Friend WithEvents txtExercise4 As System.Windows.Forms.TextBox
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerD2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB2 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerA2 As System.Windows.Forms.TextBox
    Friend WithEvents D2 As System.Windows.Forms.CheckBox
    Friend WithEvents B2 As System.Windows.Forms.CheckBox
    Friend WithEvents C2 As System.Windows.Forms.CheckBox
    Friend WithEvents A2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtExercise2 As System.Windows.Forms.TextBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerD3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB3 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerA3 As System.Windows.Forms.TextBox
    Friend WithEvents D3 As System.Windows.Forms.CheckBox
    Friend WithEvents B3 As System.Windows.Forms.CheckBox
    Friend WithEvents C3 As System.Windows.Forms.CheckBox
    Friend WithEvents A3 As System.Windows.Forms.CheckBox
    Friend WithEvents txtExercise3 As System.Windows.Forms.TextBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerD1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerA1 As System.Windows.Forms.TextBox
    Friend WithEvents D1 As System.Windows.Forms.CheckBox
    Friend WithEvents B1 As System.Windows.Forms.CheckBox
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents A1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtExercise1 As System.Windows.Forms.TextBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents UserGroup As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cmdGet As System.Windows.Forms.Button
    Friend WithEvents cmbDutyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShift As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDuty As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
