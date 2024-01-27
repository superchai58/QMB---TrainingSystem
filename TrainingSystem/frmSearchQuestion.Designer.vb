<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearchQuestion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSearchQuestion))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DataGV = New System.Windows.Forms.DataGridView()
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
        Me.Panel1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DataGV)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1167, 636)
        Me.Panel1.TabIndex = 41
        '
        'DataGV
        '
        Me.DataGV.AllowUserToAddRows = False
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGV.Location = New System.Drawing.Point(0, 244)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(1167, 392)
        Me.DataGV.TabIndex = 39
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
        Me.GroupBox1.Size = New System.Drawing.Size(1167, 244)
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
        Me.btnPreview.TabIndex = 80
        Me.btnPreview.Text = "Preview ดูตัวอย่าง"
        Me.btnPreview.UseVisualStyleBackColor = False
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
        Me.btnSelQuestion.TabIndex = 79
        Me.btnSelQuestion.Text = "Select Question เลือกคำถาม"
        Me.btnSelQuestion.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSelQuestion.UseVisualStyleBackColor = False
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
        Me.cmdQuery.TabIndex = 76
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
        Me.cmdExit.TabIndex = 75
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
        Me.cmdDelete.TabIndex = 72
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
        Me.cmbQuestionType.TabIndex = 66
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
        Me.txtRemark.TabIndex = 61
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
        Me.txtTitle.TabIndex = 56
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
        Me.cmbQuestionGroup.TabIndex = 49
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
        'frmSearchQuestion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 636)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmSearchQuestion"
        Me.Text = "frmSearchQuestion[20231004]"
        Me.Panel1.ResumeLayout(False)
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGV As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Public WithEvents btnPreview As Button
    Public WithEvents btnSelQuestion As Button
    Friend WithEvents txtExamNo As TextBox
    Public WithEvents cmdQuery As Button
    Public WithEvents cmdExit As Button
    Public WithEvents cmdUpdate As Button
    Public WithEvents cmdDelete As Button
    Friend WithEvents txtQuestionQty As TextBox
    Friend WithEvents cmbQuestionType As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtRemark As TextBox
    Friend WithEvents lblQuestionQty As Label
    Friend WithEvents lblRemark As Label
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTilte As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbQuestionGroup As ComboBox
    Friend WithEvents Label6 As Label
End Class
