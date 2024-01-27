<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetPicture
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
        Me.lvwItem = New System.Windows.Forms.ListView()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtExamNo = New System.Windows.Forms.TextBox()
        Me.lblExamNo = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.lvwItem.Location = New System.Drawing.Point(3, 71)
        Me.lvwItem.Name = "lvwItem"
        Me.lvwItem.Size = New System.Drawing.Size(789, 364)
        Me.lvwItem.TabIndex = 98
        Me.lvwItem.UseCompatibleStateImageBehavior = False
        Me.lvwItem.View = System.Windows.Forms.View.Details
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.SystemColors.Control
        Me.btnUp.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnUp.Enabled = False
        Me.btnUp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUp.Location = New System.Drawing.Point(15, 17)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUp.Size = New System.Drawing.Size(87, 24)
        Me.btnUp.TabIndex = 96
        Me.btnUp.Text = "Up/ขึ้น"
        Me.btnUp.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.SystemColors.Control
        Me.btnDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnDown.Enabled = False
        Me.btnDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnDown.Location = New System.Drawing.Point(15, 47)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDown.Size = New System.Drawing.Size(87, 24)
        Me.btnDown.TabIndex = 97
        Me.btnDown.Text = "Down/ลง"
        Me.btnDown.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwItem)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(911, 438)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Maintain Picture Question/ปรับปรุงคำถามเชิงรูปภาพ"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(792, 16)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(116, 419)
        Me.Panel1.TabIndex = 99
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtTitle)
        Me.Panel2.Controls.Add(Me.lblTitle)
        Me.Panel2.Controls.Add(Me.txtExamNo)
        Me.Panel2.Controls.Add(Me.lblExamNo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 16)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(789, 55)
        Me.Panel2.TabIndex = 100
        '
        'txtTitle
        '
        Me.txtTitle.Location = New System.Drawing.Point(420, 17)
        Me.txtTitle.Multiline = True
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.ReadOnly = True
        Me.txtTitle.Size = New System.Drawing.Size(329, 20)
        Me.txtTitle.TabIndex = 89
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(300, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(114, 13)
        Me.lblTitle.TabIndex = 88
        Me.lblTitle.Text = "Exam Subject/วิชาสอบ"
        '
        'txtExamNo
        '
        Me.txtExamNo.Location = New System.Drawing.Point(135, 17)
        Me.txtExamNo.Multiline = True
        Me.txtExamNo.Name = "txtExamNo"
        Me.txtExamNo.ReadOnly = True
        Me.txtExamNo.Size = New System.Drawing.Size(159, 20)
        Me.txtExamNo.TabIndex = 87
        '
        'lblExamNo
        '
        Me.lblExamNo.AutoSize = True
        Me.lblExamNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblExamNo.Location = New System.Drawing.Point(3, 20)
        Me.lblExamNo.Name = "lblExamNo"
        Me.lblExamNo.Size = New System.Drawing.Size(132, 13)
        Me.lblExamNo.TabIndex = 86
        Me.lblExamNo.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'frmSetPicture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(911, 438)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmSetPicture"
        Me.Text = "frmSetPicture[20231112]"
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Public WithEvents lvwItem As ListView
    Public WithEvents btnUp As Button
    Public WithEvents btnDown As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtTitle As TextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents txtExamNo As TextBox
    Friend WithEvents lblExamNo As Label
End Class
