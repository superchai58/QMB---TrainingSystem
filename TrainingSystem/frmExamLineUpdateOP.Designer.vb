<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamLineUpdateOP
    Inherits System.Windows.Forms.Form

    'Form 覆寫 Dispose 以清除元件清單。
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

    '為 Windows Form 設計工具的必要項
    Private components As System.ComponentModel.IContainer

    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtDeptCode = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtLine = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtExamType = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmdUpdate = New System.Windows.Forms.Button()
        Me.cmdDisable = New System.Windows.Forms.Button()
        Me.cmdEnable = New System.Windows.Forms.Button()
        Me.txtActive = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtExamTitle = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDeptCode
        '
        Me.txtDeptCode.Enabled = False
        Me.txtDeptCode.Location = New System.Drawing.Point(560, 98)
        Me.txtDeptCode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDeptCode.Name = "txtDeptCode"
        Me.txtDeptCode.Size = New System.Drawing.Size(162, 23)
        Me.txtDeptCode.TabIndex = 99
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(180, 33)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(162, 23)
        Me.txtUserID.TabIndex = 98
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(22, 67)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 17)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "Exam Title/ชื่อข้อสอบ"
        '
        'cmdQuery
        '
        Me.cmdQuery.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(625, 130)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(73, 42)
        Me.cmdQuery.TabIndex = 86
        Me.cmdQuery.Text = "&Query ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmdExit
        '
        Me.cmdExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(780, 130)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(69, 42)
        Me.cmdExit.TabIndex = 85
        Me.cmdExit.Text = "Exit ออก"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'txtLine
        '
        Me.txtLine.Enabled = False
        Me.txtLine.Location = New System.Drawing.Point(180, 130)
        Me.txtLine.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLine.Name = "txtLine"
        Me.txtLine.Size = New System.Drawing.Size(162, 23)
        Me.txtLine.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UserID/รหัสผู้ใข้"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Line/ไลน์"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtExamType)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmdUpdate)
        Me.GroupBox1.Controls.Add(Me.cmdDisable)
        Me.GroupBox1.Controls.Add(Me.cmdEnable)
        Me.GroupBox1.Controls.Add(Me.txtActive)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtExamTitle)
        Me.GroupBox1.Controls.Add(Me.txtDeptCode)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.cmdQuery)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.txtLine)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(867, 172)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Staff"
        '
        'txtExamType
        '
        Me.txtExamType.Enabled = False
        Me.txtExamType.Location = New System.Drawing.Point(180, 98)
        Me.txtExamType.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtExamType.Name = "txtExamType"
        Me.txtExamType.Size = New System.Drawing.Size(162, 23)
        Me.txtExamType.TabIndex = 109
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(179, 17)
        Me.Label5.TabIndex = 108
        Me.Label5.Text = "Department Code/รหัสแผนก"
        '
        'cmdUpdate
        '
        Me.cmdUpdate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdUpdate.BackColor = System.Drawing.SystemColors.Control
        Me.cmdUpdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdUpdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdUpdate.Location = New System.Drawing.Point(704, 130)
        Me.cmdUpdate.Name = "cmdUpdate"
        Me.cmdUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdUpdate.Size = New System.Drawing.Size(70, 42)
        Me.cmdUpdate.TabIndex = 107
        Me.cmdUpdate.Text = "&Update อัปเดต"
        Me.cmdUpdate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdUpdate.UseVisualStyleBackColor = False
        '
        'cmdDisable
        '
        Me.cmdDisable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdDisable.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDisable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDisable.Enabled = False
        Me.cmdDisable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDisable.Location = New System.Drawing.Point(541, 130)
        Me.cmdDisable.Name = "cmdDisable"
        Me.cmdDisable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDisable.Size = New System.Drawing.Size(78, 42)
        Me.cmdDisable.TabIndex = 106
        Me.cmdDisable.Text = "&Disable ปิดใช้งาน"
        Me.cmdDisable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDisable.UseVisualStyleBackColor = False
        '
        'cmdEnable
        '
        Me.cmdEnable.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdEnable.BackColor = System.Drawing.SystemColors.Control
        Me.cmdEnable.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnable.Enabled = False
        Me.cmdEnable.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnable.Location = New System.Drawing.Point(457, 130)
        Me.cmdEnable.Name = "cmdEnable"
        Me.cmdEnable.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnable.Size = New System.Drawing.Size(78, 42)
        Me.cmdEnable.TabIndex = 105
        Me.cmdEnable.Text = "&Enable เปิดใช้งาน"
        Me.cmdEnable.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdEnable.UseVisualStyleBackColor = False
        '
        'txtActive
        '
        Me.txtActive.Enabled = False
        Me.txtActive.Location = New System.Drawing.Point(560, 65)
        Me.txtActive.Name = "txtActive"
        Me.txtActive.Size = New System.Drawing.Size(162, 23)
        Me.txtActive.TabIndex = 104
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label6.Location = New System.Drawing.Point(376, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 103
        Me.Label6.Text = "Active"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(560, 33)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(162, 23)
        Me.txtUserName.TabIndex = 102
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(376, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 17)
        Me.Label2.TabIndex = 101
        Me.Label2.Text = "UserName/ชื่อผู้ใช้"
        '
        'txtExamTitle
        '
        Me.txtExamTitle.Enabled = False
        Me.txtExamTitle.Location = New System.Drawing.Point(180, 65)
        Me.txtExamTitle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtExamTitle.Name = "txtExamTitle"
        Me.txtExamTitle.Size = New System.Drawing.Size(162, 23)
        Me.txtExamTitle.TabIndex = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGV)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 191)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(1010, 418)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Audit Person Information/ข้อมูลผู้ตรวจสอบ"
        '
        'DataGV
        '
        Me.DataGV.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Location = New System.Drawing.Point(5, 22)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(1000, 391)
        Me.DataGV.TabIndex = 10
        '
        'frmExamLineUpdateOP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 622)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmExamLineUpdateOP"
        Me.Text = "frmExamLineUpdateOP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtDeptCode As System.Windows.Forms.TextBox
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents txtLine As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtExamTitle As System.Windows.Forms.TextBox
    Public WithEvents cmdDisable As System.Windows.Forms.Button
    Public WithEvents cmdEnable As System.Windows.Forms.Button
    Friend WithEvents txtActive As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGV As System.Windows.Forms.DataGridView
    Public WithEvents cmdUpdate As System.Windows.Forms.Button
    Friend WithEvents txtExamType As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
