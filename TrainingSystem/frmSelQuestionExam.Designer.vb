<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSelQuestionExam
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSelQuestionExam))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbDutyGroup = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnDellAll = New System.Windows.Forms.Button()
        Me.GrpBoxTextQ = New System.Windows.Forms.GroupBox()
        Me.txtAnswerA = New System.Windows.Forms.TextBox()
        Me.txtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAnswerD = New System.Windows.Forms.TextBox()
        Me.txtAnswerC = New System.Windows.Forms.TextBox()
        Me.txtAnswerB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExercise = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GrpBoxPicQ = New System.Windows.Forms.GroupBox()
        Me.Lbl1D = New System.Windows.Forms.Label()
        Me.Lbl1C = New System.Windows.Forms.Label()
        Me.Lbl1B = New System.Windows.Forms.Label()
        Me.Lbl1A = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Lbl15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Lbl14 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Lbl13 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lbl12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Lbl11 = New System.Windows.Forms.Label()
        Me.D1 = New System.Windows.Forms.CheckBox()
        Me.B1 = New System.Windows.Forms.CheckBox()
        Me.C1 = New System.Windows.Forms.CheckBox()
        Me.A1 = New System.Windows.Forms.CheckBox()
        Me.txtPicQuestion = New System.Windows.Forms.TextBox()
        Me.btnQuery = New System.Windows.Forms.Button()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtExamNo = New System.Windows.Forms.TextBox()
        Me.lblExamNo = New System.Windows.Forms.Label()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmbQuestionType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbQuestionNO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbQuestionGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGVSelQ = New System.Windows.Forms.DataGridView()
        Me.SplitV = New System.Windows.Forms.Splitter()
        Me.DataGVQuestions = New System.Windows.Forms.DataGridView()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrpBoxTextQ.SuspendLayout()
        Me.GrpBoxPicQ.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGVSelQ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGVQuestions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnExcel)
        Me.GroupBox1.Controls.Add(Me.cmbDutyGroup)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnDellAll)
        Me.GroupBox1.Controls.Add(Me.GrpBoxTextQ)
        Me.GroupBox1.Controls.Add(Me.GrpBoxPicQ)
        Me.GroupBox1.Controls.Add(Me.btnQuery)
        Me.GroupBox1.Controls.Add(Me.cmbType)
        Me.GroupBox1.Controls.Add(Me.txtFilter)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Controls.Add(Me.txtExamNo)
        Me.GroupBox1.Controls.Add(Me.lblExamNo)
        Me.GroupBox1.Controls.Add(Me.cmdConfirm)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionNO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionGroup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1064, 262)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain Question/ปรับปรุงคำถาม"
        '
        'cmbDutyGroup
        '
        Me.cmbDutyGroup.FormattingEnabled = True
        Me.cmbDutyGroup.Location = New System.Drawing.Point(918, 38)
        Me.cmbDutyGroup.Name = "cmbDutyGroup"
        Me.cmbDutyGroup.Size = New System.Drawing.Size(70, 23)
        Me.cmbDutyGroup.TabIndex = 91
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(818, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "DutyGroup/กลุ่มงาน"
        '
        'btnDellAll
        '
        Me.btnDellAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDellAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDellAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDellAll.Location = New System.Drawing.Point(825, 220)
        Me.btnDellAll.Name = "btnDellAll"
        Me.btnDellAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDellAll.Size = New System.Drawing.Size(75, 39)
        Me.btnDellAll.TabIndex = 89
        Me.btnDellAll.Text = "Delete All ลบทั้งหมด"
        Me.btnDellAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDellAll.UseVisualStyleBackColor = False
        '
        'GrpBoxTextQ
        '
        Me.GrpBoxTextQ.Controls.Add(Me.txtAnswerA)
        Me.GrpBoxTextQ.Controls.Add(Me.txtCorrectAnswer)
        Me.GrpBoxTextQ.Controls.Add(Me.Label12)
        Me.GrpBoxTextQ.Controls.Add(Me.txtAnswerD)
        Me.GrpBoxTextQ.Controls.Add(Me.txtAnswerC)
        Me.GrpBoxTextQ.Controls.Add(Me.txtAnswerB)
        Me.GrpBoxTextQ.Controls.Add(Me.Label10)
        Me.GrpBoxTextQ.Controls.Add(Me.Label9)
        Me.GrpBoxTextQ.Controls.Add(Me.Label8)
        Me.GrpBoxTextQ.Controls.Add(Me.Label7)
        Me.GrpBoxTextQ.Controls.Add(Me.txtExercise)
        Me.GrpBoxTextQ.Controls.Add(Me.Label5)
        Me.GrpBoxTextQ.Location = New System.Drawing.Point(21, 69)
        Me.GrpBoxTextQ.Name = "GrpBoxTextQ"
        Me.GrpBoxTextQ.Size = New System.Drawing.Size(891, 142)
        Me.GrpBoxTextQ.TabIndex = 86
        Me.GrpBoxTextQ.TabStop = False
        Me.GrpBoxTextQ.Text = "Text Question/ข้อความคำถาม"
        '
        'txtAnswerA
        '
        Me.txtAnswerA.Location = New System.Drawing.Point(128, 70)
        Me.txtAnswerA.Multiline = True
        Me.txtAnswerA.Name = "txtAnswerA"
        Me.txtAnswerA.ReadOnly = True
        Me.txtAnswerA.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerA.TabIndex = 83
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(782, 19)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.ReadOnly = True
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(97, 21)
        Me.txtCorrectAnswer.TabIndex = 82
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(622, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 13)
        Me.Label12.TabIndex = 81
        Me.Label12.Text = "Correct Answer/คำตอบที่ถูกต้อง"
        '
        'txtAnswerD
        '
        Me.txtAnswerD.Location = New System.Drawing.Point(526, 108)
        Me.txtAnswerD.Multiline = True
        Me.txtAnswerD.Name = "txtAnswerD"
        Me.txtAnswerD.ReadOnly = True
        Me.txtAnswerD.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerD.TabIndex = 80
        '
        'txtAnswerC
        '
        Me.txtAnswerC.Location = New System.Drawing.Point(128, 106)
        Me.txtAnswerC.Multiline = True
        Me.txtAnswerC.Name = "txtAnswerC"
        Me.txtAnswerC.ReadOnly = True
        Me.txtAnswerC.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerC.TabIndex = 79
        '
        'txtAnswerB
        '
        Me.txtAnswerB.Location = New System.Drawing.Point(526, 72)
        Me.txtAnswerB.Multiline = True
        Me.txtAnswerB.Name = "txtAnswerB"
        Me.txtAnswerB.ReadOnly = True
        Me.txtAnswerB.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerB.TabIndex = 78
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(507, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 14)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(90, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 14)
        Me.Label9.TabIndex = 76
        Me.Label9.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(507, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 14)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 14)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "A"
        '
        'txtExercise
        '
        Me.txtExercise.Location = New System.Drawing.Point(128, 20)
        Me.txtExercise.Multiline = True
        Me.txtExercise.Name = "txtExercise"
        Me.txtExercise.ReadOnly = True
        Me.txtExercise.Size = New System.Drawing.Size(477, 45)
        Me.txtExercise.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(24, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Question/คำถาม"
        '
        'GrpBoxPicQ
        '
        Me.GrpBoxPicQ.Controls.Add(Me.Lbl1D)
        Me.GrpBoxPicQ.Controls.Add(Me.Lbl1C)
        Me.GrpBoxPicQ.Controls.Add(Me.Lbl1B)
        Me.GrpBoxPicQ.Controls.Add(Me.Lbl1A)
        Me.GrpBoxPicQ.Controls.Add(Me.GroupBox5)
        Me.GrpBoxPicQ.Controls.Add(Me.GroupBox3)
        Me.GrpBoxPicQ.Controls.Add(Me.GroupBox4)
        Me.GrpBoxPicQ.Controls.Add(Me.GroupBox2)
        Me.GrpBoxPicQ.Controls.Add(Me.GroupBox6)
        Me.GrpBoxPicQ.Controls.Add(Me.D1)
        Me.GrpBoxPicQ.Controls.Add(Me.B1)
        Me.GrpBoxPicQ.Controls.Add(Me.C1)
        Me.GrpBoxPicQ.Controls.Add(Me.A1)
        Me.GrpBoxPicQ.Controls.Add(Me.txtPicQuestion)
        Me.GrpBoxPicQ.Location = New System.Drawing.Point(20, 67)
        Me.GrpBoxPicQ.Name = "GrpBoxPicQ"
        Me.GrpBoxPicQ.Size = New System.Drawing.Size(891, 156)
        Me.GrpBoxPicQ.TabIndex = 88
        Me.GrpBoxPicQ.TabStop = False
        Me.GrpBoxPicQ.Text = "Picture Question"
        '
        'Lbl1D
        '
        Me.Lbl1D.AutoSize = True
        Me.Lbl1D.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl1D.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl1D.Location = New System.Drawing.Point(703, 116)
        Me.Lbl1D.Name = "Lbl1D"
        Me.Lbl1D.Size = New System.Drawing.Size(40, 16)
        Me.Lbl1D.TabIndex = 205
        Me.Lbl1D.Text = "空白"
        '
        'Lbl1C
        '
        Me.Lbl1C.AutoSize = True
        Me.Lbl1C.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl1C.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl1C.Location = New System.Drawing.Point(528, 116)
        Me.Lbl1C.Name = "Lbl1C"
        Me.Lbl1C.Size = New System.Drawing.Size(40, 16)
        Me.Lbl1C.TabIndex = 204
        Me.Lbl1C.Text = "空白"
        '
        'Lbl1B
        '
        Me.Lbl1B.AutoSize = True
        Me.Lbl1B.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl1B.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl1B.Location = New System.Drawing.Point(703, 48)
        Me.Lbl1B.Name = "Lbl1B"
        Me.Lbl1B.Size = New System.Drawing.Size(40, 16)
        Me.Lbl1B.TabIndex = 203
        Me.Lbl1B.Text = "空白"
        '
        'Lbl1A
        '
        Me.Lbl1A.AutoSize = True
        Me.Lbl1A.Font = New System.Drawing.Font("SimSun", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Lbl1A.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Lbl1A.Location = New System.Drawing.Point(527, 48)
        Me.Lbl1A.Name = "Lbl1A"
        Me.Lbl1A.Size = New System.Drawing.Size(40, 16)
        Me.Lbl1A.TabIndex = 202
        Me.Lbl1A.Text = "空白"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Lbl15)
        Me.GroupBox5.Location = New System.Drawing.Point(283, 78)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(58, 56)
        Me.GroupBox5.TabIndex = 201
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "5"
        '
        'Lbl15
        '
        Me.Lbl15.AutoSize = True
        Me.Lbl15.Location = New System.Drawing.Point(15, 22)
        Me.Lbl15.Name = "Lbl15"
        Me.Lbl15.Size = New System.Drawing.Size(31, 15)
        Me.Lbl15.TabIndex = 187
        Me.Lbl15.Text = "空白"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Lbl14)
        Me.GroupBox3.Location = New System.Drawing.Point(219, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(58, 56)
        Me.GroupBox3.TabIndex = 200
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "4"
        '
        'Lbl14
        '
        Me.Lbl14.AutoSize = True
        Me.Lbl14.Location = New System.Drawing.Point(15, 22)
        Me.Lbl14.Name = "Lbl14"
        Me.Lbl14.Size = New System.Drawing.Size(31, 15)
        Me.Lbl14.TabIndex = 187
        Me.Lbl14.Text = "空白"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Lbl13)
        Me.GroupBox4.Location = New System.Drawing.Point(155, 78)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(58, 56)
        Me.GroupBox4.TabIndex = 199
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "3"
        '
        'Lbl13
        '
        Me.Lbl13.AutoSize = True
        Me.Lbl13.Location = New System.Drawing.Point(15, 22)
        Me.Lbl13.Name = "Lbl13"
        Me.Lbl13.Size = New System.Drawing.Size(31, 15)
        Me.Lbl13.TabIndex = 187
        Me.Lbl13.Text = "空白"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lbl12)
        Me.GroupBox2.Location = New System.Drawing.Point(91, 78)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(58, 56)
        Me.GroupBox2.TabIndex = 198
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "2"
        '
        'Lbl12
        '
        Me.Lbl12.AutoSize = True
        Me.Lbl12.Location = New System.Drawing.Point(15, 22)
        Me.Lbl12.Name = "Lbl12"
        Me.Lbl12.Size = New System.Drawing.Size(31, 15)
        Me.Lbl12.TabIndex = 187
        Me.Lbl12.Text = "空白"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Lbl11)
        Me.GroupBox6.Location = New System.Drawing.Point(27, 78)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(58, 56)
        Me.GroupBox6.TabIndex = 197
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "1"
        '
        'Lbl11
        '
        Me.Lbl11.AccessibleName = ""
        Me.Lbl11.AutoSize = True
        Me.Lbl11.Location = New System.Drawing.Point(15, 22)
        Me.Lbl11.Name = "Lbl11"
        Me.Lbl11.Size = New System.Drawing.Size(31, 15)
        Me.Lbl11.TabIndex = 186
        Me.Lbl11.Text = "空白"
        '
        'D1
        '
        Me.D1.AutoSize = True
        Me.D1.Location = New System.Drawing.Point(658, 112)
        Me.D1.Name = "D1"
        Me.D1.Size = New System.Drawing.Size(35, 19)
        Me.D1.TabIndex = 196
        Me.D1.Text = "D"
        Me.D1.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.AutoSize = True
        Me.B1.Location = New System.Drawing.Point(658, 44)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(34, 19)
        Me.B1.TabIndex = 195
        Me.B1.Text = "B"
        Me.B1.UseVisualStyleBackColor = True
        '
        'C1
        '
        Me.C1.AutoSize = True
        Me.C1.Location = New System.Drawing.Point(475, 112)
        Me.C1.Name = "C1"
        Me.C1.Size = New System.Drawing.Size(34, 19)
        Me.C1.TabIndex = 194
        Me.C1.Text = "C"
        Me.C1.UseVisualStyleBackColor = True
        '
        'A1
        '
        Me.A1.AutoSize = True
        Me.A1.Location = New System.Drawing.Point(474, 44)
        Me.A1.Name = "A1"
        Me.A1.Size = New System.Drawing.Size(33, 19)
        Me.A1.TabIndex = 193
        Me.A1.Text = "A"
        Me.A1.UseVisualStyleBackColor = True
        '
        'txtPicQuestion
        '
        Me.txtPicQuestion.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.txtPicQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPicQuestion.Location = New System.Drawing.Point(27, 26)
        Me.txtPicQuestion.Multiline = True
        Me.txtPicQuestion.Name = "txtPicQuestion"
        Me.txtPicQuestion.Size = New System.Drawing.Size(437, 42)
        Me.txtPicQuestion.TabIndex = 192
        Me.txtPicQuestion.Text = "PicQuestion"
        '
        'btnQuery
        '
        Me.btnQuery.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnQuery.Location = New System.Drawing.Point(542, 217)
        Me.btnQuery.Name = "btnQuery"
        Me.btnQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnQuery.Size = New System.Drawing.Size(77, 42)
        Me.btnQuery.TabIndex = 85
        Me.btnQuery.Text = "Query  ตรวจสอบ"
        Me.btnQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnQuery.UseVisualStyleBackColor = False
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(68, 233)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(140, 23)
        Me.cmbType.TabIndex = 84
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(213, 234)
        Me.txtFilter.Multiline = True
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(321, 20)
        Me.txtFilter.TabIndex = 83
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 235)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "Filter"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(466, 14)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(498, 20)
        Me.txtTitle.TabIndex = 81
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(346, 17)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 13)
        Me.lblTitle.TabIndex = 80
        Me.lblTitle.Text = "Exam Subject/วิชาสอบ"
        '
        'txtExamNo
        '
        Me.txtExamNo.Location = New System.Drawing.Point(172, 14)
        Me.txtExamNo.Multiline = True
        Me.txtExamNo.Name = "txtExamNo"
        Me.txtExamNo.ReadOnly = True
        Me.txtExamNo.Size = New System.Drawing.Size(159, 20)
        Me.txtExamNo.TabIndex = 79
        '
        'lblExamNo
        '
        Me.lblExamNo.AutoSize = True
        Me.lblExamNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblExamNo.Location = New System.Drawing.Point(18, 19)
        Me.lblExamNo.Name = "lblExamNo"
        Me.lblExamNo.Size = New System.Drawing.Size(132, 13)
        Me.lblExamNo.TabIndex = 78
        Me.lblExamNo.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConfirm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConfirm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConfirm.Location = New System.Drawing.Point(755, 218)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConfirm.Size = New System.Drawing.Size(64, 41)
        Me.cmdConfirm.TabIndex = 77
        Me.cmdConfirm.Text = "Save บันทึก"
        Me.cmdConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdConfirm.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(971, 220)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(59, 39)
        Me.cmdExit.TabIndex = 75
        Me.cmdExit.Text = "Cacel"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(625, 217)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(59, 42)
        Me.cmdAdd.TabIndex = 73
        Me.cmdAdd.Text = "Select  เลือก"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Location = New System.Drawing.Point(690, 218)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(59, 41)
        Me.cmdDelete.TabIndex = 72
        Me.cmdDelete.Text = "Delete  ลบ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmbQuestionType
        '
        Me.cmbQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionType.FormattingEnabled = True
        Me.cmbQuestionType.Location = New System.Drawing.Point(706, 38)
        Me.cmbQuestionType.Name = "cmbQuestionType"
        Me.cmbQuestionType.Size = New System.Drawing.Size(95, 23)
        Me.cmbQuestionType.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(576, 44)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'cmbQuestionNO
        '
        Me.cmbQuestionNO.FormattingEnabled = True
        Me.cmbQuestionNO.Location = New System.Drawing.Point(172, 39)
        Me.cmbQuestionNO.Name = "cmbQuestionNO"
        Me.cmbQuestionNO.Size = New System.Drawing.Size(159, 23)
        Me.cmbQuestionNO.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Question No./หมายเลขคำถาม"
        '
        'cmbQuestionGroup
        '
        Me.cmbQuestionGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionGroup.FormattingEnabled = True
        Me.cmbQuestionGroup.Location = New System.Drawing.Point(466, 40)
        Me.cmbQuestionGroup.Name = "cmbQuestionGroup"
        Me.cmbQuestionGroup.Size = New System.Drawing.Size(104, 23)
        Me.cmbQuestionGroup.TabIndex = 49
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(346, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Exam Group/กลุ่มข้อสอบ"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGVSelQ)
        Me.Panel1.Controls.Add(Me.SplitV)
        Me.Panel1.Controls.Add(Me.DataGVQuestions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 262)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1064, 451)
        Me.Panel1.TabIndex = 42
        '
        'DataGVSelQ
        '
        Me.DataGVSelQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGVSelQ.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGVSelQ.Location = New System.Drawing.Point(536, 0)
        Me.DataGVSelQ.Name = "DataGVSelQ"
        Me.DataGVSelQ.Size = New System.Drawing.Size(528, 451)
        Me.DataGVSelQ.TabIndex = 46
        '
        'SplitV
        '
        Me.SplitV.BackColor = System.Drawing.Color.RoyalBlue
        Me.SplitV.Location = New System.Drawing.Point(530, 0)
        Me.SplitV.Name = "SplitV"
        Me.SplitV.Size = New System.Drawing.Size(6, 451)
        Me.SplitV.TabIndex = 45
        Me.SplitV.TabStop = False
        '
        'DataGVQuestions
        '
        Me.DataGVQuestions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGVQuestions.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGVQuestions.Location = New System.Drawing.Point(0, 0)
        Me.DataGVQuestions.Name = "DataGVQuestions"
        Me.DataGVQuestions.Size = New System.Drawing.Size(530, 451)
        Me.DataGVQuestions.TabIndex = 42
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.SystemColors.Control
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExcel.Location = New System.Drawing.Point(906, 220)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnExcel.Size = New System.Drawing.Size(59, 39)
        Me.btnExcel.TabIndex = 92
        Me.btnExcel.Text = "Export Excel"
        Me.btnExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnExcel.UseVisualStyleBackColor = False
        '
        'frmSelQuestionExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1064, 713)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSelQuestionExam"
        Me.Text = "frmSelQuestionExam[20231207]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpBoxTextQ.ResumeLayout(False)
        Me.GrpBoxTextQ.PerformLayout()
        Me.GrpBoxPicQ.ResumeLayout(False)
        Me.GrpBoxPicQ.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGVSelQ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGVQuestions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdConfirm As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmbQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbQuestionNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbQuestionGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtExamNo As System.Windows.Forms.TextBox
    Friend WithEvents lblExamNo As System.Windows.Forms.Label
    Friend WithEvents txtFilter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Public WithEvents btnQuery As System.Windows.Forms.Button
    Friend WithEvents GrpBoxTextQ As System.Windows.Forms.GroupBox
    Friend WithEvents txtAnswerA As System.Windows.Forms.TextBox
    Friend WithEvents txtCorrectAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerD As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtExercise As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GrpBoxPicQ As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl1D As System.Windows.Forms.Label
    Friend WithEvents Lbl1C As System.Windows.Forms.Label
    Friend WithEvents Lbl1B As System.Windows.Forms.Label
    Friend WithEvents Lbl1A As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl13 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl11 As System.Windows.Forms.Label
    Friend WithEvents D1 As System.Windows.Forms.CheckBox
    Friend WithEvents B1 As System.Windows.Forms.CheckBox
    Friend WithEvents C1 As System.Windows.Forms.CheckBox
    Friend WithEvents A1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtPicQuestion As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DataGVQuestions As System.Windows.Forms.DataGridView
    Friend WithEvents DataGVSelQ As System.Windows.Forms.DataGridView
    Friend WithEvents SplitV As System.Windows.Forms.Splitter
    Public WithEvents btnDellAll As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbDutyGroup As System.Windows.Forms.ComboBox
    Public WithEvents btnExcel As Button
End Class
