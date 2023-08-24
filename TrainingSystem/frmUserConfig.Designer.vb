<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUserConfig
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUserConfig))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdModify = New System.Windows.Forms.Button()
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
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdModify)
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
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(711, 415)
        Me.GroupBox1.TabIndex = 31
        Me.GroupBox1.TabStop = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(603, 244)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(59, 58)
        Me.cmdExit.TabIndex = 45
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
        Me.cmdModify.Location = New System.Drawing.Point(522, 244)
        Me.cmdModify.Name = "cmdModify"
        Me.cmdModify.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdModify.Size = New System.Drawing.Size(59, 58)
        Me.cmdModify.TabIndex = 44
        Me.cmdModify.Text = "Modify"
        Me.cmdModify.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdModify.UseVisualStyleBackColor = False
        '
        'txtExtNo
        '
        Me.txtExtNo.Location = New System.Drawing.Point(495, 124)
        Me.txtExtNo.Name = "txtExtNo"
        Me.txtExtNo.ReadOnly = True
        Me.txtExtNo.Size = New System.Drawing.Size(167, 20)
        Me.txtExtNo.TabIndex = 43
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(406, 124)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 14)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Ext./วันหมดอายุ"
        '
        'txtShift
        '
        Me.txtShift.Location = New System.Drawing.Point(495, 172)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.ReadOnly = True
        Me.txtShift.Size = New System.Drawing.Size(167, 20)
        Me.txtShift.TabIndex = 41
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label11.Location = New System.Drawing.Point(430, 172)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 14)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Shift/กะ"
        '
        'txtDuty
        '
        Me.txtDuty.Location = New System.Drawing.Point(495, 72)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.ReadOnly = True
        Me.txtDuty.Size = New System.Drawing.Size(167, 20)
        Me.txtDuty.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label9.Location = New System.Drawing.Point(439, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 14)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "Job/งาน"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(176, 212)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.ReadOnly = True
        Me.txtMail.Size = New System.Drawing.Size(242, 20)
        Me.txtMail.TabIndex = 37
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(24, 214)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 14)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Mail/เมล"
        '
        'txtPassWord
        '
        Me.txtPassWord.Location = New System.Drawing.Point(176, 72)
        Me.txtPassWord.Name = "txtPassWord"
        Me.txtPassWord.PasswordChar = Global.Microsoft.VisualBasic.ChrW(65290)
        Me.txtPassWord.Size = New System.Drawing.Size(167, 20)
        Me.txtPassWord.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(24, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 14)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Password/รหัสผ่าน"
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(495, 27)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.ReadOnly = True
        Me.txtdept.Size = New System.Drawing.Size(167, 20)
        Me.txtdept.TabIndex = 33
        '
        'txtEnUserName
        '
        Me.txtEnUserName.Location = New System.Drawing.Point(176, 167)
        Me.txtEnUserName.Name = "txtEnUserName"
        Me.txtEnUserName.Size = New System.Drawing.Size(167, 20)
        Me.txtEnUserName.TabIndex = 32
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(176, 118)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(167, 20)
        Me.txtUserName.TabIndex = 31
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(176, 27)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(167, 20)
        Me.txtUserID.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(385, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Department/แผนก"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 14)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name/ชื่อ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Eng. Name/ชื่อภาษาอังกฤษ"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("SimSun", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.label1.Location = New System.Drawing.Point(24, 29)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(133, 14)
        Me.label1.TabIndex = 22
        Me.label1.Text = "EmployeeID/รหัสพนักงาน"
        '
        'frmUserConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 498)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmUserConfig"
        Me.Text = "Training User config"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExtNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtShift As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPassWord As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtEnUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents label1 As System.Windows.Forms.Label
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdModify As System.Windows.Forms.Button
End Class
