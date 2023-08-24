<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOpPracScore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpPracScore))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdrefresh = New System.Windows.Forms.Button()
        Me.dtpEDate = New System.Windows.Forms.DateTimePicker()
        Me.dtpSDate = New System.Windows.Forms.DateTimePicker()
        Me.CmdStart = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.txtTeacher = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.txtexamtype = New System.Windows.Forms.TextBox()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.cmbExamNo = New System.Windows.Forms.ComboBox()
        Me.cmbTestNo = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DataGVTester = New System.Windows.Forms.DataGridView()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtTester = New System.Windows.Forms.TextBox()
        Me.PanelContent = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGVTester, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.AutoSize = True
        Me.GroupBox1.Controls.Add(Me.cmdrefresh)
        Me.GroupBox1.Controls.Add(Me.dtpEDate)
        Me.GroupBox1.Controls.Add(Me.CmdStart)
        Me.GroupBox1.Controls.Add(Me.cmdExit)
        Me.GroupBox1.Controls.Add(Me.cmdQuery)
        Me.GroupBox1.Controls.Add(Me.dtpSDate)
        Me.GroupBox1.Controls.Add(Me.txtTeacher)
        Me.GroupBox1.Controls.Add(Me.txtModel)
        Me.GroupBox1.Controls.Add(Me.txtStation)
        Me.GroupBox1.Controls.Add(Me.txtexamtype)
        Me.GroupBox1.Controls.Add(Me.TxtTitle)
        Me.GroupBox1.Controls.Add(Me.cmbExamNo)
        Me.GroupBox1.Controls.Add(Me.cmbTestNo)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(830, 191)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Schedule/ตารางสอบ"
        '
        'cmdrefresh
        '
        Me.cmdrefresh.Location = New System.Drawing.Point(726, 118)
        Me.cmdrefresh.Name = "cmdrefresh"
        Me.cmdrefresh.Size = New System.Drawing.Size(82, 23)
        Me.cmdrefresh.TabIndex = 134
        Me.cmdrefresh.Text = "Refresh"
        Me.cmdrefresh.UseVisualStyleBackColor = True
        '
        'dtpEDate
        '
        Me.dtpEDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEDate.Location = New System.Drawing.Point(516, 91)
        Me.dtpEDate.Name = "dtpEDate"
        Me.dtpEDate.Size = New System.Drawing.Size(93, 21)
        Me.dtpEDate.TabIndex = 133
        '
        'dtpSDate
        '
        Me.dtpSDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpSDate.Location = New System.Drawing.Point(204, 88)
        Me.dtpSDate.Name = "dtpSDate"
        Me.dtpSDate.Size = New System.Drawing.Size(102, 21)
        Me.dtpSDate.TabIndex = 132
        '
        'CmdStart
        '
        Me.CmdStart.Location = New System.Drawing.Point(563, 148)
        Me.CmdStart.Name = "CmdStart"
        Me.CmdStart.Size = New System.Drawing.Size(157, 23)
        Me.CmdStart.TabIndex = 84
        Me.CmdStart.Text = "Start Score/เริ่มคะแนน"
        Me.CmdStart.UseVisualStyleBackColor = True
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(563, 117)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(157, 24)
        Me.cmdQuery.TabIndex = 83
        Me.cmdQuery.Text = "&Query /ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(726, 147)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(82, 24)
        Me.cmdExit.TabIndex = 82
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'txtTeacher
        '
        Me.txtTeacher.Enabled = False
        Me.txtTeacher.Location = New System.Drawing.Point(733, 91)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.Size = New System.Drawing.Size(75, 21)
        Me.txtTeacher.TabIndex = 15
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(525, 56)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.ReadOnly = True
        Me.txtModel.Size = New System.Drawing.Size(194, 21)
        Me.txtModel.TabIndex = 14
        '
        'txtStation
        '
        Me.txtStation.Location = New System.Drawing.Point(360, 56)
        Me.txtStation.Name = "txtStation"
        Me.txtStation.ReadOnly = True
        Me.txtStation.Size = New System.Drawing.Size(91, 21)
        Me.txtStation.TabIndex = 13
        '
        'txtexamtype
        '
        Me.txtexamtype.Location = New System.Drawing.Point(164, 56)
        Me.txtexamtype.Name = "txtexamtype"
        Me.txtexamtype.ReadOnly = True
        Me.txtexamtype.Size = New System.Drawing.Size(103, 21)
        Me.txtexamtype.TabIndex = 12
        '
        'TxtTitle
        '
        Me.TxtTitle.Location = New System.Drawing.Point(671, 25)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.ReadOnly = True
        Me.TxtTitle.Size = New System.Drawing.Size(153, 21)
        Me.TxtTitle.TabIndex = 11
        '
        'cmbExamNo
        '
        Me.cmbExamNo.Location = New System.Drawing.Point(428, 21)
        Me.cmbExamNo.Name = "cmbExamNo"
        Me.cmbExamNo.Size = New System.Drawing.Size(91, 23)
        Me.cmbExamNo.TabIndex = 10
        '
        'cmbTestNo
        '
        Me.cmbTestNo.FormattingEnabled = True
        Me.cmbTestNo.Location = New System.Drawing.Point(164, 22)
        Me.cmbTestNo.Name = "cmbTestNo"
        Me.cmbTestNo.Size = New System.Drawing.Size(103, 23)
        Me.cmbTestNo.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(636, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 15)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Teacher/ผู้สอน"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(324, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(186, 15)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Test End Date/วันที่สิ้นสุดการทดสอบ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(180, 15)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Test Start Date/วันที่เริ่้มการทดสอบ"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(477, 59)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 15)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Model"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(273, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Station/สเตชั่น"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(140, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(538, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Exam Subject/วิชาสอบ"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(273, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(148, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Test Paper No./เลขที่กะดาษ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.cmdSave)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.DataGVTester)
        Me.GroupBox2.Controls.Add(Me.txtTester)
        Me.GroupBox2.Controls.Add(Me.PanelContent)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 188)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(830, 372)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'DataGVTester
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGVTester.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGVTester.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("SimSun", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGVTester.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGVTester.Dock = System.Windows.Forms.DockStyle.Left
        Me.DataGVTester.Location = New System.Drawing.Point(3, 16)
        Me.DataGVTester.Name = "DataGVTester"
        Me.DataGVTester.ReadOnly = True
        Me.DataGVTester.RowTemplate.Height = 23
        Me.DataGVTester.Size = New System.Drawing.Size(303, 353)
        Me.DataGVTester.TabIndex = 43
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(713, 46)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(89, 26)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save Score"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.Control
        Me.txtName.Location = New System.Drawing.Point(713, 20)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(89, 20)
        Me.txtName.TabIndex = 5
        '
        'txtTester
        '
        Me.txtTester.BackColor = System.Drawing.SystemColors.Control
        Me.txtTester.Location = New System.Drawing.Point(459, 18)
        Me.txtTester.Name = "txtTester"
        Me.txtTester.ReadOnly = True
        Me.txtTester.Size = New System.Drawing.Size(99, 20)
        Me.txtTester.TabIndex = 4
        '
        'PanelContent
        '
        Me.PanelContent.AutoSize = True
        Me.PanelContent.Location = New System.Drawing.Point(327, 78)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(493, 275)
        Me.PanelContent.TabIndex = 3
        Me.PanelContent.TabStop = False
        Me.PanelContent.Text = "Score/คะแนน"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(564, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 13)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Employee Name/ชื่อพนักงาน"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(324, 20)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(129, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "EmployeeID/รหัสพนักงาน"
        '
        'frmOpPracScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(854, 495)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmOpPracScore"
        Me.Text = "frmOpPracScroe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGVTester, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTeacher As System.Windows.Forms.TextBox
    Friend WithEvents txtexamtype As System.Windows.Forms.TextBox
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents cmbExamNo As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtTester As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents CmdStart As System.Windows.Forms.Button
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents dtpEDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpSDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents cmbTestNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGVTester As System.Windows.Forms.DataGridView
    Friend WithEvents PanelContent As System.Windows.Forms.GroupBox
    Friend WithEvents cmdrefresh As System.Windows.Forms.Button
End Class
