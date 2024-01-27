<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetQuestions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetQuestions))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnPreview = New System.Windows.Forms.Button()
        Me.btnSelQuestion = New System.Windows.Forms.Button()
        Me.txtExamNo = New System.Windows.Forms.TextBox()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtQuestionQty = New System.Windows.Forms.TextBox()
        Me.cmbQuestionType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtRemark = New System.Windows.Forms.TextBox()
        Me.lblQuestionQty = New System.Windows.Forms.Label()
        Me.lblRemark = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTilte = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbQuestionGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtComments = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmbFunGroup = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PB1 = New System.Windows.Forms.ProgressBar()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.Cmd_Load = New System.Windows.Forms.Button()
        Me.cmbSheet = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFileName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPreview)
        Me.GroupBox1.Controls.Add(Me.btnSelQuestion)
        Me.GroupBox1.Controls.Add(Me.txtExamNo)
        Me.GroupBox1.Controls.Add(Me.cmdQuery)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtQuestionQty)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionType)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtRemark)
        Me.GroupBox1.Controls.Add(Me.lblQuestionQty)
        Me.GroupBox1.Controls.Add(Me.lblRemark)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.lblTilte)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbQuestionGroup)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 244)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Query Exam Question/ค้นหาคำถามข้อสอบ"
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.SystemColors.Control
        Me.btnPreview.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnPreview.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreview.Location = New System.Drawing.Point(814, 148)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPreview.Size = New System.Drawing.Size(60, 38)
        Me.btnPreview.TabIndex = 9
        Me.btnPreview.Text = "Preview ดูตัวอย่าง"
        Me.btnPreview.UseVisualStyleBackColor = False
        Me.btnPreview.Visible = False
        '
        'btnSelQuestion
        '
        Me.btnSelQuestion.BackColor = System.Drawing.SystemColors.Control
        Me.btnSelQuestion.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnSelQuestion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSelQuestion.Location = New System.Drawing.Point(684, 148)
        Me.btnSelQuestion.Name = "btnSelQuestion"
        Me.btnSelQuestion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSelQuestion.Size = New System.Drawing.Size(124, 38)
        Me.btnSelQuestion.TabIndex = 8
        Me.btnSelQuestion.Text = "Select Question เลือกคำถาม"
        Me.btnSelQuestion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelQuestion.UseVisualStyleBackColor = False
        Me.btnSelQuestion.Visible = False
        '
        'txtExamNo
        '
        Me.txtExamNo.Location = New System.Drawing.Point(145, 20)
        Me.txtExamNo.Multiline = True
        Me.txtExamNo.Name = "txtExamNo"
        Me.txtExamNo.ReadOnly = True
        Me.txtExamNo.Size = New System.Drawing.Size(159, 23)
        Me.txtExamNo.TabIndex = 78
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(684, 190)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(59, 44)
        Me.cmdQuery.TabIndex = 5
        Me.cmdQuery.Text = "&Query  ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(814, 188)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(59, 46)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdUpdate
        '
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Image = CType(resources.GetObject("cmdUpdate.Image"), System.Drawing.Image)
        Me.cmdUpdate.Location = New System.Drawing.Point(608, 189)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUpdate.Size = New System.Drawing.Size(59, 45)
        Me.cmdUpdate.TabIndex = 73
        Me.cmdUpdate.Text = "&Update"
        Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUpdate.UseVisualStyleBackColor = False
        Me.cmdUpdate.Visible = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(749, 189)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(59, 45)
        Me.cmdDelete.TabIndex = 6
        Me.cmdDelete.Text = "Delete"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'txtQuestionQty
        '
        Me.txtQuestionQty.Location = New System.Drawing.Point(175, 146)
        Me.txtQuestionQty.Multiline = True
        Me.txtQuestionQty.Name = "txtQuestionQty"
        Me.txtQuestionQty.ReadOnly = True
        Me.txtQuestionQty.Size = New System.Drawing.Size(159, 23)
        Me.txtQuestionQty.TabIndex = 68
        '
        'cmbQuestionType
        '
        Me.cmbQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionType.FormattingEnabled = True
        Me.cmbQuestionType.Location = New System.Drawing.Point(781, 19)
        Me.cmbQuestionType.Name = "cmbQuestionType"
        Me.cmbQuestionType.Size = New System.Drawing.Size(129, 23)
        Me.cmbQuestionType.TabIndex = 2
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(642, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(133, 13)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'txtRemark
        '
        Me.txtRemark.Location = New System.Drawing.Point(145, 88)
        Me.txtRemark.Multiline = True
        Me.txtRemark.Name = "txtRemark"
        Me.txtRemark.Size = New System.Drawing.Size(679, 53)
        Me.txtRemark.TabIndex = 4
        '
        'lblQuestionQty
        '
        Me.lblQuestionQty.AutoSize = True
        Me.lblQuestionQty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblQuestionQty.Location = New System.Drawing.Point(6, 147)
        Me.lblQuestionQty.Name = "lblQuestionQty"
        Me.lblQuestionQty.Size = New System.Drawing.Size(163, 13)
        Me.lblQuestionQty.TabIndex = 59
        Me.lblQuestionQty.Text = "Questions quantity/จำนวนคำถาม"
        '
        'lblRemark
        '
        Me.lblRemark.AutoSize = True
        Me.lblRemark.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblRemark.Location = New System.Drawing.Point(7, 89)
        Me.lblRemark.Name = "lblRemark"
        Me.lblRemark.Size = New System.Drawing.Size(91, 13)
        Me.lblRemark.TabIndex = 57
        Me.lblRemark.Text = "Remark/ข้อสังเกต"
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(145, 50)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(679, 32)
        Me.txtTitle.TabIndex = 3
        '
        'lblTilte
        '
        Me.lblTilte.AutoSize = True
        Me.lblTilte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTilte.Location = New System.Drawing.Point(7, 50)
        Me.lblTilte.Name = "lblTilte"
        Me.lblTilte.Size = New System.Drawing.Size(114, 13)
        Me.lblTilte.TabIndex = 55
        Me.lblTilte.Text = "Exam Subject/วืชาสอบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'cmbQuestionGroup
        '
        Me.cmbQuestionGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbQuestionGroup.FormattingEnabled = True
        Me.cmbQuestionGroup.Location = New System.Drawing.Point(454, 19)
        Me.cmbQuestionGroup.Name = "cmbQuestionGroup"
        Me.cmbQuestionGroup.Size = New System.Drawing.Size(159, 23)
        Me.cmbQuestionGroup.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Exam Group/กลุ่มข้อสอบ"
        '
        'DataGV
        '
        Me.DataGV.AllowUserToAddRows = False
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGV.Location = New System.Drawing.Point(0, 244)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(963, 241)
        Me.DataGV.TabIndex = 39
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGV)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(963, 485)
        Me.Panel1.TabIndex = 40
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComments)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.cmbFunGroup)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PB1)
        Me.GroupBox2.Controls.Add(Me.cmdFile)
        Me.GroupBox2.Controls.Add(Me.Cmd_Load)
        Me.GroupBox2.Controls.Add(Me.cmbSheet)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtFileName)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(0, 485)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 209)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Upload Exam Question/อัพโหลดคำถามข้อสอบ"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(177, 82)
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(450, 21)
        Me.txtComments.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(158, 13)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "Input comments/ใส่ความคิดเห็น"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(604, 130)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(60, 63)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Exit"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = False
        '
        'cmbFunGroup
        '
        Me.cmbFunGroup.FormattingEnabled = True
        Me.cmbFunGroup.Items.AddRange(New Object() {"Theory"})
        Me.cmbFunGroup.Location = New System.Drawing.Point(502, 51)
        Me.cmbFunGroup.Name = "cmbFunGroup"
        Me.cmbFunGroup.Size = New System.Drawing.Size(125, 23)
        Me.cmbFunGroup.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 78
        Me.Label1.Text = "Select Group/เลือกกลุ่ม"
        '
        'PB1
        '
        Me.PB1.Location = New System.Drawing.Point(14, 109)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(650, 15)
        Me.PB1.TabIndex = 77
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(632, 23)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(32, 23)
        Me.cmdFile.TabIndex = 11
        Me.cmdFile.Text = "..."
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'Cmd_Load
        '
        Me.Cmd_Load.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_Load.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Load.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Load.Image = CType(resources.GetObject("Cmd_Load.Image"), System.Drawing.Image)
        Me.Cmd_Load.Location = New System.Drawing.Point(539, 130)
        Me.Cmd_Load.Name = "Cmd_Load"
        Me.Cmd_Load.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Load.Size = New System.Drawing.Size(58, 63)
        Me.Cmd_Load.TabIndex = 15
        Me.Cmd_Load.Text = "Upload"
        Me.Cmd_Load.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Load.UseVisualStyleBackColor = False
        '
        'cmbSheet
        '
        Me.cmbSheet.FormattingEnabled = True
        Me.cmbSheet.Location = New System.Drawing.Point(177, 53)
        Me.cmbSheet.Name = "cmbSheet"
        Me.cmbSheet.Size = New System.Drawing.Size(125, 23)
        Me.cmbSheet.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(57, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Select Page/เลือกหน้า"
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(177, 25)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(448, 21)
        Me.txtFileName.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label13.Location = New System.Drawing.Point(18, 25)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(153, 13)
        Me.Label13.TabIndex = 49
        Me.Label13.Text = "Select Document/เลือกเอกสาร"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmSetQuestions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(963, 694)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSetQuestions"
        Me.Text = "frmSetQuestions [20231110]"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdUpdate As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtQuestionQty As System.Windows.Forms.TextBox
    Friend WithEvents cmbQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtRemark As System.Windows.Forms.TextBox
    Friend WithEvents lblQuestionQty As System.Windows.Forms.Label
    Friend WithEvents lblRemark As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents lblTilte As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbQuestionGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGV As System.Windows.Forms.DataGridView
    Friend WithEvents txtExamNo As System.Windows.Forms.TextBox
    Public WithEvents btnSelQuestion As System.Windows.Forms.Button
    Public WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
    Public WithEvents Button1 As Button
    Friend WithEvents cmbFunGroup As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PB1 As ProgressBar
    Friend WithEvents cmdFile As Button
    Public WithEvents Cmd_Load As Button
    Friend WithEvents cmbSheet As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtFileName As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents txtComments As TextBox
    Friend WithEvents Label3 As Label
End Class
