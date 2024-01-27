<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUploadData
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUploadData))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New System.Windows.Forms.Button()
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
        Me.txtComment = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtComment)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmdExit)
        Me.GroupBox2.Controls.Add(Me.cmbFunGroup)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.PB1)
        Me.GroupBox2.Controls.Add(Me.cmdFile)
        Me.GroupBox2.Controls.Add(Me.Cmd_Load)
        Me.GroupBox2.Controls.Add(Me.cmbSheet)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.txtFileName)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(686, 215)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Document Upload/อัปโหลดเอกสาร"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(604, 140)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(60, 63)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmbFunGroup
        '
        Me.cmbFunGroup.FormattingEnabled = True
        Me.cmbFunGroup.Items.AddRange(New Object() {"Theory"})
        Me.cmbFunGroup.Location = New System.Drawing.Point(502, 51)
        Me.cmbFunGroup.Name = "cmbFunGroup"
        Me.cmbFunGroup.Size = New System.Drawing.Size(123, 23)
        Me.cmbFunGroup.TabIndex = 4
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
        Me.PB1.Location = New System.Drawing.Point(16, 112)
        Me.PB1.Name = "PB1"
        Me.PB1.Size = New System.Drawing.Size(648, 20)
        Me.PB1.TabIndex = 77
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(632, 23)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(32, 23)
        Me.cmdFile.TabIndex = 2
        Me.cmdFile.Text = "..."
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'Cmd_Load
        '
        Me.Cmd_Load.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_Load.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Load.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Cmd_Load.Image = CType(resources.GetObject("Cmd_Load.Image"), System.Drawing.Image)
        Me.Cmd_Load.Location = New System.Drawing.Point(539, 140)
        Me.Cmd_Load.Name = "Cmd_Load"
        Me.Cmd_Load.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Load.Size = New System.Drawing.Size(58, 63)
        Me.Cmd_Load.TabIndex = 6
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
        Me.cmbSheet.TabIndex = 3
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
        Me.txtFileName.TabIndex = 1
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
        'txtComment
        '
        Me.txtComment.Location = New System.Drawing.Point(177, 83)
        Me.txtComment.Name = "txtComment"
        Me.txtComment.Size = New System.Drawing.Size(448, 21)
        Me.txtComment.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 13)
        Me.Label2.TabIndex = 81
        Me.Label2.Text = "Input comments/ใส่ความคิดเห็น"
        '
        'frmUploadData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 262)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmUploadData"
        Me.Text = "frmScore_Base[20231011]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PB1 As System.Windows.Forms.ProgressBar
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Public WithEvents Cmd_Load As System.Windows.Forms.Button
    Friend WithEvents cmbSheet As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFileName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbFunGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtComment As TextBox
    Friend WithEvents Label2 As Label
End Class
