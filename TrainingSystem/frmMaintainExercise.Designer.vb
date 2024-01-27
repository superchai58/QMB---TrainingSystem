<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintainExercise
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintainExercise))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAnswerD = New System.Windows.Forms.TextBox()
        Me.txtAnswerC = New System.Windows.Forms.TextBox()
        Me.txtAnswerB = New System.Windows.Forms.TextBox()
        Me.cmbQuestionType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAnswerA = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExercise = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbQuestionNO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbDutyGroup = New System.Windows.Forms.ComboBox()
        Me.cmbDeptGroup = New System.Windows.Forms.ComboBox()
        Me.cmbGroup = New System.Windows.Forms.ComboBox()
        Me.cmbQuestionGroup = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.lvwExercise = New System.Windows.Forms.ListView()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMaterial)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmdExcel)
        Me.GroupBox1.Controls.Add(Me.cmdQuery)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.cmdModify)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtCorrectAnswer)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtAnswerD)
        Me.GroupBox1.Controls.Add(Me.txtAnswerC)
        Me.GroupBox1.Controls.Add(Me.txtAnswerB)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtAnswerA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtExercise)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionNO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbDutyGroup)
        Me.GroupBox1.Controls.Add(Me.cmbDeptGroup)
        Me.GroupBox1.Controls.Add(Me.cmbGroup)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionGroup)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(918, 247)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain Test Question/ปรับปรุงผลคำถาม"
        '
        'cmbMaterial
        '
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(716, 79)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(159, 21)
        Me.cmbMaterial.TabIndex = 79
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(642, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Material/วัสดุ"
        '
        'cmdExcel
        '
        Me.cmdExcel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExcel.Location = New System.Drawing.Point(759, 210)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExcel.Size = New System.Drawing.Size(59, 37)
        Me.cmdExcel.TabIndex = 77
        Me.cmdExcel.Text = "&Excel"
        Me.cmdExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcel.UseVisualStyleBackColor = False
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(564, 209)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(59, 38)
        Me.cmdQuery.TabIndex = 76
        Me.cmdQuery.Text = "&Query ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(824, 210)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(64, 37)
        Me.cmdExit.TabIndex = 75
        Me.cmdExit.Text = "Exit ออก"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(629, 210)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(59, 37)
        Me.cmdAdd.TabIndex = 73
        Me.cmdAdd.Text = "&Add เพิ่ม"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdModify
        '
        Me.cmdModify.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModify.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModify.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModify.Image = CType(resources.GetObject("cmdModify.Image"), System.Drawing.Image)
        Me.cmdModify.Location = New System.Drawing.Point(342, 210)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModify.Size = New System.Drawing.Size(59, 37)
        Me.cmdModify.TabIndex = 74
        Me.cmdModify.Text = "Modify แก้ไข"
        Me.cmdModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModify.UseVisualStyleBackColor = False
        Me.cmdModify.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(694, 210)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(59, 37)
        Me.cmdDelete.TabIndex = 72
        Me.cmdDelete.Text = "Delete ลบ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(202, 210)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(134, 20)
        Me.txtCorrectAnswer.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(6, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(190, 17)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Correct Answer/คำตอบที่ถูกต้อง"
        '
        'txtAnswerD
        '
        Me.txtAnswerD.Location = New System.Drawing.Point(535, 171)
        Me.txtAnswerD.Multiline = True
        Me.txtAnswerD.Name = "txtAnswerD"
        Me.txtAnswerD.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerD.TabIndex = 69
        '
        'txtAnswerC
        '
        Me.txtAnswerC.Location = New System.Drawing.Point(100, 171)
        Me.txtAnswerC.Multiline = True
        Me.txtAnswerC.Name = "txtAnswerC"
        Me.txtAnswerC.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerC.TabIndex = 68
        '
        'txtAnswerB
        '
        Me.txtAnswerB.Location = New System.Drawing.Point(535, 135)
        Me.txtAnswerB.Multiline = True
        Me.txtAnswerB.Name = "txtAnswerB"
        Me.txtAnswerB.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerB.TabIndex = 67
        '
        'cmbQuestionType
        '
        Me.cmbQuestionType.FormattingEnabled = True
        Me.cmbQuestionType.Location = New System.Drawing.Point(774, 52)
        Me.cmbQuestionType.Name = "cmbQuestionType"
        Me.cmbQuestionType.Size = New System.Drawing.Size(139, 21)
        Me.cmbQuestionType.TabIndex = 66
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(642, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'txtAnswerA
        '
        Me.txtAnswerA.Location = New System.Drawing.Point(100, 133)
        Me.txtAnswerA.Multiline = True
        Me.txtAnswerA.Name = "txtAnswerA"
        Me.txtAnswerA.Size = New System.Drawing.Size(353, 32)
        Me.txtAnswerA.TabIndex = 61
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(516, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 14)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(81, 171)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 14)
        Me.Label9.TabIndex = 59
        Me.Label9.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(516, 136)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 14)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(81, 133)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 14)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "A"
        '
        'txtExercise
        '
        Me.txtExercise.Location = New System.Drawing.Point(171, 78)
        Me.txtExercise.Multiline = True
        Me.txtExercise.Name = "txtExercise"
        Me.txtExercise.Size = New System.Drawing.Size(452, 49)
        Me.txtExercise.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Test Question/คำถามทดสอบ"
        '
        'cmbQuestionNO
        '
        Me.cmbQuestionNO.FormattingEnabled = True
        Me.cmbQuestionNO.Location = New System.Drawing.Point(171, 23)
        Me.cmbQuestionNO.Name = "cmbQuestionNO"
        Me.cmbQuestionNO.Size = New System.Drawing.Size(159, 21)
        Me.cmbQuestionNO.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'cmbDutyGroup
        '
        Me.cmbDutyGroup.FormattingEnabled = True
        Me.cmbDutyGroup.Location = New System.Drawing.Point(463, 49)
        Me.cmbDutyGroup.Name = "cmbDutyGroup"
        Me.cmbDutyGroup.Size = New System.Drawing.Size(159, 21)
        Me.cmbDutyGroup.TabIndex = 52
        '
        'cmbDeptGroup
        '
        Me.cmbDeptGroup.FormattingEnabled = True
        Me.cmbDeptGroup.Location = New System.Drawing.Point(171, 51)
        Me.cmbDeptGroup.Name = "cmbDeptGroup"
        Me.cmbDeptGroup.Size = New System.Drawing.Size(121, 21)
        Me.cmbDeptGroup.TabIndex = 51
        '
        'cmbGroup
        '
        Me.cmbGroup.FormattingEnabled = True
        Me.cmbGroup.Location = New System.Drawing.Point(774, 23)
        Me.cmbGroup.Name = "cmbGroup"
        Me.cmbGroup.Size = New System.Drawing.Size(139, 21)
        Me.cmbGroup.TabIndex = 50
        '
        'cmbQuestionGroup
        '
        Me.cmbQuestionGroup.FormattingEnabled = True
        Me.cmbQuestionGroup.Location = New System.Drawing.Point(463, 22)
        Me.cmbQuestionGroup.Name = "cmbQuestionGroup"
        Me.cmbQuestionGroup.Size = New System.Drawing.Size(159, 21)
        Me.cmbQuestionGroup.TabIndex = 49
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(18, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 13)
        Me.Label4.TabIndex = 48
        Me.Label4.Text = "Department Group/กลุ่มแผนก"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(336, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Exam Group/กลุ่มข้อสอบ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(336, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Job Group/งานกลุ่ม"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label1.Location = New System.Drawing.Point(642, 25)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(125, 13)
        Me.label1.TabIndex = 22
        Me.label1.Text = "Type Group/ประเภทกลุ่ม"
        '
        'lvwExercise
        '
        Me.lvwExercise.BackColor = System.Drawing.SystemColors.Window
        Me.lvwExercise.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwExercise.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwExercise.FullRowSelect = True
        Me.lvwExercise.GridLines = True
        Me.lvwExercise.HideSelection = False
        Me.lvwExercise.Location = New System.Drawing.Point(24, 290)
        Me.lvwExercise.Name = "lvwExercise"
        Me.lvwExercise.Size = New System.Drawing.Size(918, 297)
        Me.lvwExercise.TabIndex = 52
        Me.lvwExercise.UseCompatibleStateImageBehavior = False
        Me.lvwExercise.View = System.Windows.Forms.View.Details
        '
        'frmMaintainExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(968, 698)
        Me.Controls.Add(Me.lvwExercise)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmMaintainExercise"
        Me.Text = "Training Maintain Exercise"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbDeptGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGroup As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuestionGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents cmbQuestionNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtExercise As System.Windows.Forms.TextBox
    Friend WithEvents cmbQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerA As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbDutyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCorrectAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAnswerD As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerC As System.Windows.Forms.TextBox
    Friend WithEvents txtAnswerB As System.Windows.Forms.TextBox
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents cmdModify As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Public WithEvents lvwExercise As System.Windows.Forms.ListView
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Public WithEvents cmdExcel As System.Windows.Forms.Button
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
End Class
