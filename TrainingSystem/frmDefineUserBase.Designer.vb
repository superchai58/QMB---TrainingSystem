<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDefineUserBase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDefineUserBase))
        Me.lvwUser = New System.Windows.Forms.ListView()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdModify = New System.Windows.Forms.Button()
        Me.cmdAddUser = New System.Windows.Forms.Button()
        Me.cmdRemoveUser = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CboBU = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtExtNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtShift = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDuty = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtMail = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPassWord = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtEnUserName = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwUser
        '
        Me.lvwUser.BackColor = System.Drawing.SystemColors.Window
        Me.lvwUser.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwUser.FullRowSelect = True
        Me.lvwUser.GridLines = True
        Me.lvwUser.HideSelection = False
        Me.lvwUser.Location = New System.Drawing.Point(268, 46)
        Me.lvwUser.Name = "lvwUser"
        Me.lvwUser.Size = New System.Drawing.Size(560, 535)
        Me.lvwUser.TabIndex = 18
        Me.lvwUser.UseCompatibleStateImageBehavior = False
        Me.lvwUser.View = System.Windows.Forms.View.Details
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(205, 523)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(59, 58)
        Me.cmdExit.TabIndex = 26
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdModify
        '
        Me.cmdModify.BackColor = System.Drawing.SystemColors.Control
        Me.cmdModify.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdModify.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdModify.Image = CType(resources.GetObject("cmdModify.Image"), System.Drawing.Image)
        Me.cmdModify.Location = New System.Drawing.Point(77, 523)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModify.Size = New System.Drawing.Size(59, 58)
        Me.cmdModify.TabIndex = 25
        Me.cmdModify.Text = "Modify"
        Me.cmdModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModify.UseVisualStyleBackColor = False
        '
        'cmdAddUser
        '
        Me.cmdAddUser.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAddUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAddUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAddUser.Image = CType(resources.GetObject("cmdAddUser.Image"), System.Drawing.Image)
        Me.cmdAddUser.Location = New System.Drawing.Point(13, 523)
        Me.cmdAddUser.Name = "cmdAddUser"
        Me.cmdAddUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAddUser.Size = New System.Drawing.Size(59, 58)
        Me.cmdAddUser.TabIndex = 24
        Me.cmdAddUser.Text = "&Add"
        Me.cmdAddUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAddUser.UseVisualStyleBackColor = False
        '
        'cmdRemoveUser
        '
        Me.cmdRemoveUser.BackColor = System.Drawing.SystemColors.Control
        Me.cmdRemoveUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdRemoveUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdRemoveUser.Image = CType(resources.GetObject("cmdRemoveUser.Image"), System.Drawing.Image)
        Me.cmdRemoveUser.Location = New System.Drawing.Point(141, 523)
        Me.cmdRemoveUser.Name = "cmdRemoveUser"
        Me.cmdRemoveUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdRemoveUser.Size = New System.Drawing.Size(59, 58)
        Me.cmdRemoveUser.TabIndex = 23
        Me.cmdRemoveUser.Text = "Delete"
        Me.cmdRemoveUser.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdRemoveUser.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(265, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(335, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Personal Total information/ข้อมูลส่วนบุคคล ข้อมูลทั้งหมด"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CboBU)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtExtNo)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtShift)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtDuty)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtPassWord)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtdept)
        Me.GroupBox1.Controls.Add(Me.txtEnUserName)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 38)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 479)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'CboBU
        '
        Me.CboBU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboBU.FormattingEnabled = True
        Me.CboBU.Location = New System.Drawing.Point(61, 443)
        Me.CboBU.Name = "CboBU"
        Me.CboBU.Size = New System.Drawing.Size(168, 21)
        Me.CboBU.TabIndex = 45
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(10, 446)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(22, 13)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "BU"
        '
        'txtExtNo
        '
        Me.txtExtNo.Location = New System.Drawing.Point(63, 354)
        Me.txtExtNo.Name = "txtExtNo"
        Me.txtExtNo.ReadOnly = True
        Me.txtExtNo.Size = New System.Drawing.Size(167, 20)
        Me.txtExtNo.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 355)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Ext."
        '
        'txtShift
        '
        Me.txtShift.Location = New System.Drawing.Point(62, 403)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.ReadOnly = True
        Me.txtShift.Size = New System.Drawing.Size(167, 20)
        Me.txtShift.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(10, 403)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(28, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Shift"
        '
        'txtDuty
        '
        Me.txtDuty.Location = New System.Drawing.Point(63, 259)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.ReadOnly = True
        Me.txtDuty.Size = New System.Drawing.Size(167, 20)
        Me.txtDuty.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 260)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(24, 13)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Job"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(62, 308)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(167, 20)
        Me.txtMail.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 308)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Mail"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(109, 71)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(65290)
        Me.txtPassWord.Size = New System.Drawing.Size(135, 20)
        Me.txtPassWord.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(4, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Password/รหัสผ่าน"
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(62, 212)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.ReadOnly = True
        Me.txtdept.Size = New System.Drawing.Size(167, 20)
        Me.txtdept.TabIndex = 33
        '
        'txtEnUserName
        '
        Me.txtEnUserName.Location = New System.Drawing.Point(62, 166)
        Me.txtEnUserName.Name = "txtEnUserName"
        Me.txtEnUserName.Size = New System.Drawing.Size(167, 20)
        Me.txtEnUserName.TabIndex = 32
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(65, 119)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(167, 20)
        Me.txtUserName.TabIndex = 31
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(109, 29)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(135, 20)
        Me.txtUserID.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(3, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name/ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Eng.Name"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label1.Location = New System.Drawing.Point(5, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(83, 13)
        Me.label1.TabIndex = 22
        Me.label1.Text = "ID/รหัสพนักงาน"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(226, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Personal Information/ข้อมูลส่วนบุคคล"
        '
        'frmDefineUserBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(840, 594)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdModify)
        Me.Controls.Add(Me.cmdAddUser)
        Me.Controls.Add(Me.cmdRemoveUser)
        Me.Controls.Add(Me.lvwUser)
        Me.Name = "frmDefineUserBase"
        Me.Text = "frmDefineUserBase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents lvwUser As System.Windows.Forms.ListView
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdModify As System.Windows.Forms.Button
    Public WithEvents cmdAddUser As System.Windows.Forms.Button
    Public WithEvents cmdRemoveUser As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtEnUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtExtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtShift As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CboBU As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
