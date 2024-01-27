<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserRight
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserRight))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lvwUser = New System.Windows.Forms.ListView()
        Me.lvwRight = New System.Windows.Forms.ListView()
        Me.lvwUser1 = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboRight = New System.Windows.Forms.ComboBox()
        Me.cboAppname = New System.Windows.Forms.ComboBox()
        Me.FrameRightCopy = New System.Windows.Forms.GroupBox()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        Me.cmdRightCopy = New System.Windows.Forms.Button()
        Me.txtSourceID = New System.Windows.Forms.TextBox()
        Me.txtTargetID = New System.Windows.Forms.TextBox()
        Me.lblSourceID = New System.Windows.Forms.Label()
        Me.lblTargetID = New System.Windows.Forms.Label()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.FrameRightCopy.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lvwUser)
        Me.GroupBox1.Controls.Add(Me.lvwRight)
        Me.GroupBox1.Controls.Add(Me.lvwUser1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cboRight)
        Me.GroupBox1.Controls.Add(Me.cboAppname)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(904, 453)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'lvwUser
        '
        Me.lvwUser.BackColor = System.Drawing.SystemColors.Window
        Me.lvwUser.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwUser.FullRowSelect = True
        Me.lvwUser.GridLines = True
        Me.lvwUser.HideSelection = False
        Me.lvwUser.Location = New System.Drawing.Point(211, 31)
        Me.lvwUser.Name = "lvwUser"
        Me.lvwUser.Size = New System.Drawing.Size(311, 401)
        Me.lvwUser.TabIndex = 16
        Me.lvwUser.UseCompatibleStateImageBehavior = False
        Me.lvwUser.View = System.Windows.Forms.View.Details
        '
        'lvwRight
        '
        Me.lvwRight.BackColor = System.Drawing.SystemColors.Window
        Me.lvwRight.CheckBoxes = True
        Me.lvwRight.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwRight.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwRight.FullRowSelect = True
        Me.lvwRight.GridLines = True
        Me.lvwRight.HideSelection = False
        Me.lvwRight.Location = New System.Drawing.Point(539, 31)
        Me.lvwRight.Name = "lvwRight"
        Me.lvwRight.Size = New System.Drawing.Size(349, 401)
        Me.lvwRight.TabIndex = 17
        Me.lvwRight.UseCompatibleStateImageBehavior = False
        Me.lvwRight.View = System.Windows.Forms.View.Details
        '
        'lvwUser1
        '
        Me.lvwUser1.BackColor = System.Drawing.SystemColors.Window
        Me.lvwUser1.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUser1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwUser1.FullRowSelect = True
        Me.lvwUser1.GridLines = True
        Me.lvwUser1.HideSelection = False
        Me.lvwUser1.Location = New System.Drawing.Point(19, 103)
        Me.lvwUser1.Name = "lvwUser1"
        Me.lvwUser1.Size = New System.Drawing.Size(175, 329)
        Me.lvwUser1.TabIndex = 18
        Me.lvwUser1.UseCompatibleStateImageBehavior = False
        Me.lvwUser1.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "All person owen one right"
        '
        'cboRight
        '
        Me.cboRight.FormattingEnabled = True
        Me.cboRight.Location = New System.Drawing.Point(19, 76)
        Me.cboRight.Name = "cboRight"
        Me.cboRight.Size = New System.Drawing.Size(159, 21)
        Me.cboRight.TabIndex = 2
        '
        'cboAppname
        '
        Me.cboAppname.FormattingEnabled = True
        Me.cboAppname.Location = New System.Drawing.Point(19, 49)
        Me.cboAppname.Name = "cboAppname"
        Me.cboAppname.Size = New System.Drawing.Size(159, 21)
        Me.cboAppname.TabIndex = 1
        '
        'FrameRightCopy
        '
        Me.FrameRightCopy.BackColor = System.Drawing.SystemColors.Control
        Me.FrameRightCopy.Controls.Add(Me.txtDesc)
        Me.FrameRightCopy.Controls.Add(Me.cmdRightCopy)
        Me.FrameRightCopy.Controls.Add(Me.txtSourceID)
        Me.FrameRightCopy.Controls.Add(Me.txtTargetID)
        Me.FrameRightCopy.Controls.Add(Me.lblSourceID)
        Me.FrameRightCopy.Controls.Add(Me.lblTargetID)
        Me.FrameRightCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FrameRightCopy.Location = New System.Drawing.Point(24, 480)
        Me.FrameRightCopy.Name = "FrameRightCopy"
        Me.FrameRightCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.FrameRightCopy.Size = New System.Drawing.Size(758, 89)
        Me.FrameRightCopy.TabIndex = 6
        Me.FrameRightCopy.TabStop = False
        '
        'txtDesc
        '
        Me.txtDesc.AcceptsReturn = True
        Me.txtDesc.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.txtDesc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtDesc.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtDesc.Location = New System.Drawing.Point(84, 18)
        Me.txtDesc.MaxLength = 0
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.ReadOnly = True
        Me.txtDesc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtDesc.Size = New System.Drawing.Size(527, 20)
        Me.txtDesc.TabIndex = 7
        Me.txtDesc.Text = "Copy Right Permission from One User to Another/การอนุญาตสิทธิ์จากผู้ใช้รายหนึ่งไป" &
    "ยังอีกรายหนึ่ง"
        Me.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdRightCopy
        '
        Me.cmdRightCopy.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRightCopy.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRightCopy.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRightCopy.Location = New System.Drawing.Point(653, 39)
        Me.cmdRightCopy.Name = "cmdRightCopy"
        Me.cmdRightCopy.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRightCopy.Size = New System.Drawing.Size(71, 29)
        Me.cmdRightCopy.TabIndex = 6
        Me.cmdRightCopy.Text = "Copy"
        Me.cmdRightCopy.UseVisualStyleBackColor = False
        '
        'txtSourceID
        '
        Me.txtSourceID.AcceptsReturn = True
        Me.txtSourceID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSourceID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtSourceID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSourceID.Location = New System.Drawing.Point(170, 48)
        Me.txtSourceID.MaxLength = 0
        Me.txtSourceID.Name = "txtSourceID"
        Me.txtSourceID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSourceID.Size = New System.Drawing.Size(107, 20)
        Me.txtSourceID.TabIndex = 5
        '
        'txtTargetID
        '
        Me.txtTargetID.AcceptsReturn = True
        Me.txtTargetID.BackColor = System.Drawing.SystemColors.Window
        Me.txtTargetID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTargetID.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtTargetID.Location = New System.Drawing.Point(513, 44)
        Me.txtTargetID.MaxLength = 0
        Me.txtTargetID.Name = "txtTargetID"
        Me.txtTargetID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtTargetID.Size = New System.Drawing.Size(115, 20)
        Me.txtTargetID.TabIndex = 4
        '
        'lblSourceID
        '
        Me.lblSourceID.BackColor = System.Drawing.SystemColors.Control
        Me.lblSourceID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblSourceID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblSourceID.Location = New System.Drawing.Point(6, 52)
        Me.lblSourceID.Name = "lblSourceID"
        Me.lblSourceID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblSourceID.Size = New System.Drawing.Size(188, 16)
        Me.lblSourceID.TabIndex = 9
        Me.lblSourceID.Text = "Source User ID/รหัสผู้ใช้ต้นทาง"
        '
        'lblTargetID
        '
        Me.lblTargetID.BackColor = System.Drawing.SystemColors.Control
        Me.lblTargetID.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblTargetID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblTargetID.Location = New System.Drawing.Point(341, 48)
        Me.lblTargetID.Name = "lblTargetID"
        Me.lblTargetID.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblTargetID.Size = New System.Drawing.Size(181, 16)
        Me.lblTargetID.TabIndex = 8
        Me.lblTargetID.Text = "Target User ID/รหัสผู้ใช้ปลายทาง"
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(860, 502)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(65, 55)
        Me.cmdExit.TabIndex = 5
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdSave
        '
        Me.cmdSave.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSave.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSave.Image = CType(resources.GetObject("cmdSave.Image"), System.Drawing.Image)
        Me.cmdSave.Location = New System.Drawing.Point(788, 502)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSave.Size = New System.Drawing.Size(65, 55)
        Me.cmdSave.TabIndex = 4
        Me.cmdSave.Text = "Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.UseVisualStyleBackColor = False
        '
        'frmUserRight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 602)
        Me.Controls.Add(Me.FrameRightCopy)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUserRight"
        Me.Text = "Training UserRight"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FrameRightCopy.ResumeLayout(False)
        Me.FrameRightCopy.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboRight As System.Windows.Forms.ComboBox
    Friend WithEvents cboAppname As System.Windows.Forms.ComboBox
    Public WithEvents lvwUser As System.Windows.Forms.ListView
    Public WithEvents lvwRight As System.Windows.Forms.ListView
    Public WithEvents lvwUser1 As System.Windows.Forms.ListView
    Public WithEvents FrameRightCopy As System.Windows.Forms.GroupBox
    Public WithEvents txtDesc As System.Windows.Forms.TextBox
    Public WithEvents cmdRightCopy As System.Windows.Forms.Button
    Public WithEvents txtSourceID As System.Windows.Forms.TextBox
    Public WithEvents txtTargetID As System.Windows.Forms.TextBox
    Public WithEvents lblSourceID As System.Windows.Forms.Label
    Public WithEvents lblTargetID As System.Windows.Forms.Label
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdSave As System.Windows.Forms.Button

End Class
