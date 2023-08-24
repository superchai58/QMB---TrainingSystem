<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHRInfo
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
        Me.lvwItem = New System.Windows.Forms.ListView()
        Me.UserGroup = New System.Windows.Forms.GroupBox()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.cmbDept = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDeptCode = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UserGroup.SuspendLayout()
        Me.SuspendLayout()
        '
        'lvwItem
        '
        Me.lvwItem.BackColor = System.Drawing.SystemColors.Window
        Me.lvwItem.Font = New System.Drawing.Font("SimSun", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwItem.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lvwItem.FullRowSelect = True
        Me.lvwItem.GridLines = True
        Me.lvwItem.HideSelection = False
        Me.lvwItem.Location = New System.Drawing.Point(12, 107)
        Me.lvwItem.Name = "lvwItem"
        Me.lvwItem.Size = New System.Drawing.Size(742, 550)
        Me.lvwItem.TabIndex = 66
        Me.lvwItem.UseCompatibleStateImageBehavior = False
        Me.lvwItem.View = System.Windows.Forms.View.Details
        '
        'UserGroup
        '
        Me.UserGroup.Controls.Add(Me.cmdExcel)
        Me.UserGroup.Controls.Add(Me.cmdQuery)
        Me.UserGroup.Controls.Add(Me.cmbDept)
        Me.UserGroup.Controls.Add(Me.Label6)
        Me.UserGroup.Controls.Add(Me.txtUserID)
        Me.UserGroup.Controls.Add(Me.Label7)
        Me.UserGroup.Controls.Add(Me.txtDeptCode)
        Me.UserGroup.Controls.Add(Me.Label10)
        Me.UserGroup.Location = New System.Drawing.Point(12, 6)
        Me.UserGroup.Name = "UserGroup"
        Me.UserGroup.Size = New System.Drawing.Size(742, 94)
        Me.UserGroup.TabIndex = 65
        Me.UserGroup.TabStop = False
        Me.UserGroup.Text = "Employee Infomation/ข้อมูลพนักงาน"
        '
        'cmdExcel
        '
        Me.cmdExcel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExcel.Location = New System.Drawing.Point(665, 52)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExcel.Size = New System.Drawing.Size(71, 36)
        Me.cmdExcel.TabIndex = 104
        Me.cmdExcel.Text = "Excel"
        Me.cmdExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcel.UseVisualStyleBackColor = False
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(589, 52)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(70, 36)
        Me.cmdQuery.TabIndex = 103
        Me.cmdQuery.Text = "&Query ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'cmbDept
        '
        Me.cmbDept.FormattingEnabled = True
        Me.cmbDept.Location = New System.Drawing.Point(133, 21)
        Me.cmbDept.Name = "cmbDept"
        Me.cmbDept.Size = New System.Drawing.Size(587, 21)
        Me.cmbDept.TabIndex = 99
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 13)
        Me.Label6.TabIndex = 86
        Me.Label6.Text = "Department/แผนก"
        '
        'txtUserID
        '
        Me.txtUserID.BackColor = System.Drawing.SystemColors.Window
        Me.txtUserID.Location = New System.Drawing.Point(445, 55)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(121, 20)
        Me.txtUserID.TabIndex = 85
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label7.Location = New System.Drawing.Point(20, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 13)
        Me.Label7.TabIndex = 84
        Me.Label7.Text = "Department Code/รหัสแผนก"
        '
        'txtDeptCode
        '
        Me.txtDeptCode.BackColor = System.Drawing.SystemColors.Window
        Me.txtDeptCode.Location = New System.Drawing.Point(183, 56)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(121, 20)
        Me.txtDeptCode.TabIndex = 82
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label10.Location = New System.Drawing.Point(310, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 80
        Me.Label10.Text = "EmployeeID/รหัสพนักงาน"
        '
        'FrmHRInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(765, 670)
        Me.Controls.Add(Me.lvwItem)
        Me.Controls.Add(Me.UserGroup)
        Me.Name = "FrmHRInfo"
        Me.Text = "FrmHRInfo"
        Me.UserGroup.ResumeLayout(False)
        Me.UserGroup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents lvwItem As System.Windows.Forms.ListView
    Friend WithEvents UserGroup As System.Windows.Forms.GroupBox
    Public WithEvents cmdExcel As System.Windows.Forms.Button
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents cmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
