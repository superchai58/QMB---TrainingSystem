<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintainPhoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMaintainPhoto))
        Me.cmbMaterial = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtCorrectAnswer = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.txtC = New System.Windows.Forms.TextBox()
        Me.TxtA = New System.Windows.Forms.TextBox()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.TxtB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Lbl11 = New System.Windows.Forms.Label()
        Me.Picture1 = New System.Windows.Forms.PictureBox()
        Me.cmdU1 = New System.Windows.Forms.Button()
        Me.cmdFile1 = New System.Windows.Forms.Button()
        Me.txtP1 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtExercise = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbQuestionNO = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbQuestionGroup = New System.Windows.Forms.ComboBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMaterial
        '
        Me.cmbMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmbMaterial.Enabled = False
        Me.cmbMaterial.FormattingEnabled = True
        Me.cmbMaterial.Location = New System.Drawing.Point(424, 20)
        Me.cmbMaterial.Name = "cmbMaterial"
        Me.cmbMaterial.Size = New System.Drawing.Size(159, 21)
        Me.cmbMaterial.TabIndex = 79
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(353, 23)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(68, 13)
        Me.Label13.TabIndex = 78
        Me.Label13.Text = "Material/วัสดุ"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(777, 28)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(65, 49)
        Me.cmdExit.TabIndex = 75
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(700, 28)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(71, 49)
        Me.cmdAdd.TabIndex = 73
        Me.cmdAdd.Text = "&Save บันทึก"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(623, 28)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(71, 49)
        Me.cmdDelete.TabIndex = 72
        Me.cmdDelete.Text = "Delete ลบ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'txtCorrectAnswer
        '
        Me.txtCorrectAnswer.Location = New System.Drawing.Point(176, 491)
        Me.txtCorrectAnswer.Name = "txtCorrectAnswer"
        Me.txtCorrectAnswer.Size = New System.Drawing.Size(159, 21)
        Me.txtCorrectAnswer.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 491)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(155, 13)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Correct Answer/คำตอบที่ถูกต้อง"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Exam Group/กลุ่มข้อสอบ"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.GroupBox8)
        Me.GroupBox1.Controls.Add(Me.GroupBox7)
        Me.GroupBox1.Controls.Add(Me.cmbMaterial)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtCorrectAnswer)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionNO)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionGroup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(866, 539)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain Picture Exam Question/ปรับปรุงข้อสอบคำถามเชิงรูปภาพ"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.txtC)
        Me.GroupBox8.Controls.Add(Me.TxtA)
        Me.GroupBox8.Controls.Add(Me.txtD)
        Me.GroupBox8.Controls.Add(Me.TxtB)
        Me.GroupBox8.Controls.Add(Me.Label10)
        Me.GroupBox8.Controls.Add(Me.Label9)
        Me.GroupBox8.Controls.Add(Me.Label8)
        Me.GroupBox8.Controls.Add(Me.Label7)
        Me.GroupBox8.Location = New System.Drawing.Point(18, 349)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(574, 136)
        Me.GroupBox8.TabIndex = 157
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Options"
        '
        'txtC
        '
        Me.txtC.Location = New System.Drawing.Point(60, 98)
        Me.txtC.Name = "txtC"
        Me.txtC.Size = New System.Drawing.Size(224, 21)
        Me.txtC.TabIndex = 77
        '
        'TxtA
        '
        Me.TxtA.Location = New System.Drawing.Point(61, 29)
        Me.TxtA.Name = "TxtA"
        Me.TxtA.Size = New System.Drawing.Size(223, 21)
        Me.TxtA.TabIndex = 76
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(338, 98)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(222, 21)
        Me.txtD.TabIndex = 75
        '
        'TxtB
        '
        Me.TxtB.Location = New System.Drawing.Point(338, 28)
        Me.TxtB.Name = "TxtB"
        Me.TxtB.Size = New System.Drawing.Size(222, 21)
        Me.TxtB.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(317, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(14, 14)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "D"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(41, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 14)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "C"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(317, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 14)
        Me.Label8.TabIndex = 71
        Me.Label8.Text = "B"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(42, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 14)
        Me.Label7.TabIndex = 70
        Me.Label7.Text = "A"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Lbl11)
        Me.GroupBox7.Controls.Add(Me.Picture1)
        Me.GroupBox7.Controls.Add(Me.cmdU1)
        Me.GroupBox7.Controls.Add(Me.cmdFile1)
        Me.GroupBox7.Controls.Add(Me.txtP1)
        Me.GroupBox7.Controls.Add(Me.Label14)
        Me.GroupBox7.Controls.Add(Me.txtExercise)
        Me.GroupBox7.Controls.Add(Me.Label5)
        Me.GroupBox7.Location = New System.Drawing.Point(17, 101)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(566, 246)
        Me.GroupBox7.TabIndex = 156
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Exam Question/คำถามข้อสอบ"
        '
        'Lbl11
        '
        Me.Lbl11.Location = New System.Drawing.Point(60, 108)
        Me.Lbl11.Name = "Lbl11"
        Me.Lbl11.Size = New System.Drawing.Size(102, 20)
        Me.Lbl11.TabIndex = 181
        Me.Lbl11.Text = "Label1"
        '
        'Picture1
        '
        Me.Picture1.Location = New System.Drawing.Point(58, 131)
        Me.Picture1.Name = "Picture1"
        Me.Picture1.Size = New System.Drawing.Size(170, 110)
        Me.Picture1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.Picture1.TabIndex = 180
        Me.Picture1.TabStop = False
        '
        'cmdU1
        '
        Me.cmdU1.Location = New System.Drawing.Point(505, 62)
        Me.cmdU1.Name = "cmdU1"
        Me.cmdU1.Size = New System.Drawing.Size(56, 45)
        Me.cmdU1.TabIndex = 179
        Me.cmdU1.Text = "Upload  อัปโหลด"
        Me.cmdU1.UseVisualStyleBackColor = True
        '
        'cmdFile1
        '
        Me.cmdFile1.Location = New System.Drawing.Point(466, 84)
        Me.cmdFile1.Name = "cmdFile1"
        Me.cmdFile1.Size = New System.Drawing.Size(32, 23)
        Me.cmdFile1.TabIndex = 166
        Me.cmdFile1.Text = "..."
        Me.cmdFile1.UseVisualStyleBackColor = True
        '
        'txtP1
        '
        Me.txtP1.Location = New System.Drawing.Point(104, 85)
        Me.txtP1.Name = "txtP1"
        Me.txtP1.ReadOnly = True
        Me.txtP1.Size = New System.Drawing.Size(359, 21)
        Me.txtP1.TabIndex = 165
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(13, 84)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(78, 13)
        Me.Label14.TabIndex = 164
        Me.Label14.Text = "Picture/รูปภาพ"
        '
        'txtExercise
        '
        Me.txtExercise.Location = New System.Drawing.Point(104, 30)
        Me.txtExercise.Multiline = True
        Me.txtExercise.Name = "txtExercise"
        Me.txtExercise.Size = New System.Drawing.Size(359, 45)
        Me.txtExercise.TabIndex = 157
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 13)
        Me.Label5.TabIndex = 156
        Me.Label5.Text = "Question/คำถาม"
        '
        'cmbQuestionNO
        '
        Me.cmbQuestionNO.FormattingEnabled = True
        Me.cmbQuestionNO.Location = New System.Drawing.Point(164, 56)
        Me.cmbQuestionNO.Name = "cmbQuestionNO"
        Me.cmbQuestionNO.Size = New System.Drawing.Size(159, 23)
        Me.cmbQuestionNO.TabIndex = 54
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(30, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'cmbQuestionGroup
        '
        Me.cmbQuestionGroup.FormattingEnabled = True
        Me.cmbQuestionGroup.Location = New System.Drawing.Point(164, 23)
        Me.cmbQuestionGroup.Name = "cmbQuestionGroup"
        Me.cmbQuestionGroup.Size = New System.Drawing.Size(159, 23)
        Me.cmbQuestionGroup.TabIndex = 49
        '
        'FrmMaintainPhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(885, 565)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "FrmMaintainPhoto"
        Me.Text = "FrmMaintainPhoto"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.Picture1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbMaterial As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtCorrectAnswer As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbQuestionNO As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbQuestionGroup As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExercise As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmdFile1 As System.Windows.Forms.Button
    Friend WithEvents txtP1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmdU1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtC As System.Windows.Forms.TextBox
    Friend WithEvents TxtA As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents TxtB As System.Windows.Forms.TextBox
    Friend WithEvents Picture1 As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl11 As System.Windows.Forms.Label
End Class
