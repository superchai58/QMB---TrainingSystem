<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPracticeList
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
        Me.UserGroup = New System.Windows.Forms.GroupBox()
        Me.txtDuty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtGroup = New System.Windows.Forms.TextBox()
        Me.cmbDutyGroup = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtShift = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lvwItem = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.UserGroup.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UserGroup
        '
        Me.UserGroup.Controls.Add(Me.txtDuty)
        Me.UserGroup.Controls.Add(Me.Label1)
        Me.UserGroup.Controls.Add(Me.txtGroup)
        Me.UserGroup.Controls.Add(Me.cmbDutyGroup)
        Me.UserGroup.Controls.Add(Me.Label6)
        Me.UserGroup.Controls.Add(Me.txtShift)
        Me.UserGroup.Controls.Add(Me.Label7)
        Me.UserGroup.Controls.Add(Me.Label8)
        Me.UserGroup.Controls.Add(Me.txtUserName)
        Me.UserGroup.Controls.Add(Me.txtUserID)
        Me.UserGroup.Controls.Add(Me.Label10)
        Me.UserGroup.Controls.Add(Me.Label12)
        Me.UserGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.UserGroup.Location = New System.Drawing.Point(12, 13)
        Me.UserGroup.Name = "UserGroup"
        Me.UserGroup.Size = New System.Drawing.Size(662, 98)
        Me.UserGroup.TabIndex = 60
        Me.UserGroup.TabStop = False
        Me.UserGroup.Text = "Personal Information/ข้อมูลส่วนตัว"
        '
        'txtDuty
        '
        Me.txtDuty.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuty.Location = New System.Drawing.Point(370, 52)
        Me.txtDuty.Name = "txtDuty"
        Me.txtDuty.ReadOnly = True
        Me.txtDuty.Size = New System.Drawing.Size(104, 21)
        Me.txtDuty.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(273, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Job Title/หัวข้องาน"
        '
        'txtGroup
        '
        Me.txtGroup.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroup.Location = New System.Drawing.Point(156, 52)
        Me.txtGroup.Name = "txtGroup"
        Me.txtGroup.ReadOnly = True
        Me.txtGroup.Size = New System.Drawing.Size(104, 21)
        Me.txtGroup.TabIndex = 95
        '
        'cmbDutyGroup
        '
        Me.cmbDutyGroup.FormattingEnabled = True
        Me.cmbDutyGroup.Location = New System.Drawing.Point(583, 52)
        Me.cmbDutyGroup.Name = "cmbDutyGroup"
        Me.cmbDutyGroup.Size = New System.Drawing.Size(79, 23)
        Me.cmbDutyGroup.TabIndex = 90
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Type Group/ประเถทกลุ่ม"
        '
        'txtShift
        '
        Me.txtShift.BackColor = System.Drawing.SystemColors.Window
        Me.txtShift.Location = New System.Drawing.Point(497, 18)
        Me.txtShift.Name = "txtShift"
        Me.txtShift.ReadOnly = True
        Me.txtShift.Size = New System.Drawing.Size(104, 21)
        Me.txtShift.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(446, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Shift/กะ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label8.Location = New System.Drawing.Point(482, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 13)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Job Group/กลุ่มงาน"
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserName.Location = New System.Drawing.Point(336, 20)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(104, 21)
        Me.txtUserName.TabIndex = 82
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Location = New System.Drawing.Point(156, 20)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.ReadOnly = True
        Me.txtUserID.Size = New System.Drawing.Size(104, 21)
        Me.txtUserID.TabIndex = 81
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(273, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "Name/ชื่อ"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(129, 13)
        Me.Label12.TabIndex = 79
        Me.Label12.Text = "EmployeeID/รหัสพนักงาน"
        '
        'lvwItem
        '
        Me.lvwItem.BackColor = System.Drawing.SystemColors.Window
        Me.lvwItem.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwItem.FullRowSelect = True
        Me.lvwItem.GridLines = True
        Me.lvwItem.HideSelection = False
        Me.lvwItem.Location = New System.Drawing.Point(12, 117)
        Me.lvwItem.Name = "lvwItem"
        Me.lvwItem.Size = New System.Drawing.Size(742, 507)
        Me.lvwItem.TabIndex = 61
        Me.lvwItem.UseCompatibleStateImageBehavior = False
        Me.lvwItem.View = System.Windows.Forms.View.Details
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdExcel)
        Me.GroupBox1.Location = New System.Drawing.Point(680, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(74, 98)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Action"
        '
        'cmdExcel
        '
        Me.cmdExcel.Location = New System.Drawing.Point(12, 40)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(56, 25)
        Me.cmdExcel.TabIndex = 0
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.UseVisualStyleBackColor = True
        '
        'FrmPracticeList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 637)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lvwItem)
        Me.Controls.Add(Me.UserGroup)
        Me.Name = "FrmPracticeList"
        Me.Text = "FrmPracticeList"
        Me.UserGroup.ResumeLayout(False)
        Me.UserGroup.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents UserGroup As System.Windows.Forms.GroupBox
    Friend WithEvents txtDuty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtGroup As System.Windows.Forms.TextBox
    Friend WithEvents cmbDutyGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtShift As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Public WithEvents lvwItem As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdExcel As System.Windows.Forms.Button
End Class
