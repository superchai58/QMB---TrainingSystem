<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamOperator
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboExamScheduleID = New System.Windows.Forms.ComboBox()
        Me.txtTitle = New System.Windows.Forms.ComboBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.cboSheet = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Cmd_Load = New System.Windows.Forms.Button()
        Me.cmdFile = New System.Windows.Forms.Button()
        Me.cmbCheck = New System.Windows.Forms.Button()
        Me.cmdExcel = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.txtTitle1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboExamScheduleID)
        Me.GroupBox1.Controls.Add(Me.txtTitle)
        Me.GroupBox1.Controls.Add(Me.txtEmployeeID)
        Me.GroupBox1.Controls.Add(Me.cboSheet)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Cmd_Load)
        Me.GroupBox1.Controls.Add(Me.cmdFile)
        Me.GroupBox1.Controls.Add(Me.cmbCheck)
        Me.GroupBox1.Controls.Add(Me.cmdExcel)
        Me.GroupBox1.Controls.Add(Me.cmdQuery)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdAdd)
        Me.GroupBox1.Controls.Add(Me.cmdDelete)
        Me.GroupBox1.Controls.Add(Me.txtTitle1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(15, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(869, 172)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Staff"
        '
        'cboExamScheduleID
        '
        Me.cboExamScheduleID.FormattingEnabled = True
        Me.cboExamScheduleID.Location = New System.Drawing.Point(154, 99)
        Me.cboExamScheduleID.Name = "cboExamScheduleID"
        Me.cboExamScheduleID.Size = New System.Drawing.Size(323, 25)
        Me.cboExamScheduleID.TabIndex = 5
        '
        'txtTitle
        '
        Me.txtTitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTitle.FormattingEnabled = True
        Me.txtTitle.Location = New System.Drawing.Point(154, 130)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(323, 25)
        Me.txtTitle.TabIndex = 99
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Location = New System.Drawing.Point(154, 35)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(323, 23)
        Me.txtEmployeeID.TabIndex = 98
        '
        'cboSheet
        '
        Me.cboSheet.FormattingEnabled = True
        Me.cboSheet.Location = New System.Drawing.Point(154, 68)
        Me.cboSheet.Name = "cboSheet"
        Me.cboSheet.Size = New System.Drawing.Size(323, 25)
        Me.cboSheet.TabIndex = 97
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label14.Location = New System.Drawing.Point(20, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(114, 13)
        Me.Label14.TabIndex = 96
        Me.Label14.Text = "Select Page/เลือกหน้า"
        '
        'Cmd_Load
        '
        Me.Cmd_Load.BackColor = System.Drawing.SystemColors.Control
        Me.Cmd_Load.Cursor = System.Windows.Forms.Cursors.Default
        Me.Cmd_Load.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cmd_Load.ForeColor = System.Drawing.Color.Black
        Me.Cmd_Load.Location = New System.Drawing.Point(505, 66)
        Me.Cmd_Load.Name = "Cmd_Load"
        Me.Cmd_Load.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Cmd_Load.Size = New System.Drawing.Size(65, 46)
        Me.Cmd_Load.TabIndex = 95
        Me.Cmd_Load.Text = "Upload อัปโหลด"
        Me.Cmd_Load.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Cmd_Load.UseVisualStyleBackColor = False
        '
        'cmdFile
        '
        Me.cmdFile.Location = New System.Drawing.Point(506, 36)
        Me.cmdFile.Name = "cmdFile"
        Me.cmdFile.Size = New System.Drawing.Size(59, 24)
        Me.cmdFile.TabIndex = 94
        Me.cmdFile.Text = "..."
        Me.cmdFile.UseVisualStyleBackColor = True
        '
        'cmbCheck
        '
        Me.cmbCheck.Location = New System.Drawing.Point(576, 66)
        Me.cmbCheck.Name = "cmbCheck"
        Me.cmbCheck.Size = New System.Drawing.Size(103, 46)
        Me.cmbCheck.TabIndex = 91
        Me.cmbCheck.Text = "Check ID ตรวจสอบรหัส"
        Me.cmbCheck.UseVisualStyleBackColor = True
        '
        'cmdExcel
        '
        Me.cmdExcel.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExcel.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExcel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExcel.Location = New System.Drawing.Point(729, 122)
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExcel.Size = New System.Drawing.Size(59, 44)
        Me.cmdExcel.TabIndex = 87
        Me.cmdExcel.Text = "&Excel"
        Me.cmdExcel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExcel.UseVisualStyleBackColor = False
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(505, 122)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(80, 44)
        Me.cmdQuery.TabIndex = 86
        Me.cmdQuery.Text = "&Query ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Location = New System.Drawing.Point(794, 122)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(69, 44)
        Me.cmdExit.TabIndex = 85
        Me.cmdExit.Text = "Exit ออก"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Location = New System.Drawing.Point(591, 122)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(65, 44)
        Me.cmdAdd.TabIndex = 84
        Me.cmdAdd.Text = "&Add เพิ่ม"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Location = New System.Drawing.Point(662, 122)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(59, 44)
        Me.cmdDelete.TabIndex = 83
        Me.cmdDelete.Text = "&Delete ลบ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'txtTitle1
        '
        Me.txtTitle1.Enabled = False
        Me.txtTitle1.Location = New System.Drawing.Point(316, 99)
        Me.txtTitle1.Name = "txtTitle1"
        Me.txtTitle1.Size = New System.Drawing.Size(323, 23)
        Me.txtTitle1.TabIndex = 7
        Me.txtTitle1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 131)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Exam Subject/วิชาสอบ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exam Plan/แผนข้อสอบ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EmployeeID/รหัสพนักงาน"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'DataGV
        '
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Location = New System.Drawing.Point(15, 191)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(869, 371)
        Me.DataGV.TabIndex = 1
        '
        'frmExamOperator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 574)
        Me.Controls.Add(Me.DataGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmExamOperator"
        Me.Text = "frmExamOperator[20231030]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboExamScheduleID As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle1 As System.Windows.Forms.TextBox
    Public WithEvents cmdExcel As System.Windows.Forms.Button
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents DataGV As System.Windows.Forms.DataGridView
    Friend WithEvents cmbCheck As System.Windows.Forms.Button
    Friend WithEvents cmdFile As System.Windows.Forms.Button
    Public WithEvents Cmd_Load As System.Windows.Forms.Button
    Friend WithEvents cboSheet As System.Windows.Forms.ComboBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtTitle As ComboBox
End Class
