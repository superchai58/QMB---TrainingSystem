<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPractice
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDelAll = New System.Windows.Forms.Button()
        Me.cmdConfirm = New System.Windows.Forms.Button()
        Me.cmbQuestionGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.txtRateScore = New System.Windows.Forms.TextBox()
        Me.lblRateScore = New System.Windows.Forms.Label()
        Me.txtSubItem = New System.Windows.Forms.TextBox()
        Me.lblSubItem = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtExamNo = New System.Windows.Forms.TextBox()
        Me.lblExamNo = New System.Windows.Forms.Label()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.lvwItem = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDelAll)
        Me.GroupBox1.Controls.Add(Me.cmdConfirm)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionGroup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.txtRateScore)
        Me.GroupBox1.Controls.Add(Me.lblRateScore)
        Me.GroupBox1.Controls.Add(Me.txtSubItem)
        Me.GroupBox1.Controls.Add(Me.lblSubItem)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.lblTitle)
        Me.GroupBox1.Controls.Add(Me.txtExamNo)
        Me.GroupBox1.Controls.Add(Me.lblExamNo)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 134)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain Practical Question/ปรับปรุงคำถามเชิงปฏิบัติ"
        '
        'btnDelAll
        '
        Me.btnDelAll.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelAll.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelAll.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelAll.Location = New System.Drawing.Point(795, 94)
        Me.btnDelAll.Name = "btnDelAll"
        Me.btnDelAll.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelAll.Size = New System.Drawing.Size(91, 38)
        Me.btnDelAll.TabIndex = 95
        Me.btnDelAll.Text = "Delete Subitem ลบ"
        Me.btnDelAll.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelAll.UseVisualStyleBackColor = False
        '
        'cmdConfirm
        '
        Me.cmdConfirm.BackColor = System.Drawing.SystemColors.Control
        Me.cmdConfirm.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConfirm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConfirm.Location = New System.Drawing.Point(652, 94)
        Me.cmdConfirm.Name = "cmdConfirm"
        Me.cmdConfirm.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConfirm.Size = New System.Drawing.Size(72, 38)
        Me.cmdConfirm.TabIndex = 94
        Me.cmdConfirm.Text = "Save  บันทึก"
        Me.cmdConfirm.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdConfirm.UseVisualStyleBackColor = False
        Me.cmdConfirm.Visible = False
        '
        'cmbQuestionGroup
        '
        Me.cmbQuestionGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionGroup.FormattingEnabled = True
        Me.cmbQuestionGroup.Location = New System.Drawing.Point(400, 105)
        Me.cmbQuestionGroup.Name = "cmbQuestionGroup"
        Me.cmbQuestionGroup.Size = New System.Drawing.Size(156, 21)
        Me.cmbQuestionGroup.TabIndex = 93
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(256, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Exam Group/ประเภทข้อสอบ"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.SystemColors.Control
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDelete.Location = New System.Drawing.Point(730, 95)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDelete.Size = New System.Drawing.Size(59, 37)
        Me.btnDelete.TabIndex = 91
        Me.btnDelete.Text = "Delete  ลบ"
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(587, 94)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(59, 37)
        Me.cmdAdd.TabIndex = 90
        Me.cmdAdd.Text = "Add  เพิ่ม"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = False
        Me.cmdAdd.Visible = False
        '
        'txtRateScore
        '
        Me.txtRateScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRateScore.Location = New System.Drawing.Point(91, 102)
        Me.txtRateScore.Name = "txtRateScore"
        Me.txtRateScore.Size = New System.Drawing.Size(159, 21)
        Me.txtRateScore.TabIndex = 89
        '
        'lblRateScore
        '
        Me.lblRateScore.AutoSize = True
        Me.lblRateScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRateScore.Location = New System.Drawing.Point(9, 104)
        Me.lblRateScore.Name = "lblRateScore"
        Me.lblRateScore.Size = New System.Drawing.Size(76, 13)
        Me.lblRateScore.TabIndex = 88
        Me.lblRateScore.Text = "Score/คะแนน"
        '
        'txtSubItem
        '
        Me.txtSubItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubItem.Location = New System.Drawing.Point(199, 49)
        Me.txtSubItem.Multiline = True
        Me.txtSubItem.Name = "txtSubItem"
        Me.txtSubItem.Size = New System.Drawing.Size(680, 39)
        Me.txtSubItem.TabIndex = 87
        '
        'lblSubItem
        '
        Me.lblSubItem.AutoSize = True
        Me.lblSubItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblSubItem.Location = New System.Drawing.Point(9, 55)
        Me.lblSubItem.Name = "lblSubItem"
        Me.lblSubItem.Size = New System.Drawing.Size(184, 13)
        Me.lblSubItem.TabIndex = 86
        Me.lblSubItem.Text = "Practical Subitem/หัวข้อย่อยเชิงปฏิบัติ"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(436, 15)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(443, 20)
        Me.txtTitle.TabIndex = 85
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(316, 19)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 13)
        Me.lblTitle.TabIndex = 84
        Me.lblTitle.Text = "Exam Subject/วิชาสอบ"
        '
        'txtExamNo
        '
        Me.txtExamNo.Location = New System.Drawing.Point(147, 23)
        Me.txtExamNo.Multiline = True
        Me.txtExamNo.Name = "txtExamNo"
        Me.txtExamNo.ReadOnly = True
        Me.txtExamNo.Size = New System.Drawing.Size(159, 20)
        Me.txtExamNo.TabIndex = 83
        '
        'lblExamNo
        '
        Me.lblExamNo.AutoSize = True
        Me.lblExamNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblExamNo.Location = New System.Drawing.Point(9, 26)
        Me.lblExamNo.Name = "lblExamNo"
        Me.lblExamNo.Size = New System.Drawing.Size(132, 13)
        Me.lblExamNo.TabIndex = 82
        Me.lblExamNo.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.Control
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUp.Location = New System.Drawing.Point(15, 12)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUp.Size = New System.Drawing.Size(87, 24)
        Me.btnUp.TabIndex = 92
        Me.btnUp.Text = "Up/ขึ้น"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.SystemColors.Control
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDown.Location = New System.Drawing.Point(15, 42)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDown.Size = New System.Drawing.Size(87, 24)
        Me.btnDown.TabIndex = 93
        Me.btnDown.Text = "Down/ลง"
        Me.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'lvwItem
        '
        Me.lvwItem.BackColor = System.Drawing.SystemColors.Window
        Me.lvwItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvwItem.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwItem.FullRowSelect = True
        Me.lvwItem.GridLines = True
        Me.lvwItem.HideSelection = False
        Me.lvwItem.Location = New System.Drawing.Point(0, 0)
        Me.lvwItem.Name = "lvwItem"
        Me.lvwItem.Size = New System.Drawing.Size(795, 304)
        Me.lvwItem.TabIndex = 94
        Me.lvwItem.UseCompatibleStateImageBehavior = False
        Me.lvwItem.View = System.Windows.Forms.View.Details
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lvwItem)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 134)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 304)
        Me.Panel1.TabIndex = 95
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnUp)
        Me.Panel2.Controls.Add(Me.btnDown)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(795, 134)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(116, 304)
        Me.Panel2.TabIndex = 96
        '
        'frmSetPractice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 438)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSetPractice"
        Me.Text = "Maintain Practical Questions[20231114]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtExamNo As System.Windows.Forms.TextBox
    Friend WithEvents lblExamNo As System.Windows.Forms.Label
    Friend WithEvents txtRateScore As System.Windows.Forms.TextBox
    Friend WithEvents lblRateScore As System.Windows.Forms.Label
    Friend WithEvents txtSubItem As System.Windows.Forms.TextBox
    Friend WithEvents lblSubItem As System.Windows.Forms.Label
    Public WithEvents btnDelete As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents btnUp As System.Windows.Forms.Button
    Public WithEvents btnDown As System.Windows.Forms.Button
    Public WithEvents lvwItem As System.Windows.Forms.ListView
    Friend WithEvents cmbQuestionGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Public WithEvents cmdConfirm As System.Windows.Forms.Button
    Public WithEvents btnDelAll As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
