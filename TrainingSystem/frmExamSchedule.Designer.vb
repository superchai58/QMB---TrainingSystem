<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExamSchedule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmExamSchedule))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dtpStart = New System.Windows.Forms.DateTimePicker()
        Me.txtTeacher = New System.Windows.Forms.TextBox()
        Me.dtpEnd = New System.Windows.Forms.DateTimePicker()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboExamNoPratice = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboExamTypePratice = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtStationPractice = New System.Windows.Forms.TextBox()
        Me.txtModelPractice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboExamNoPicture = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cboExamTypePicture = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtStationPicture = New System.Windows.Forms.TextBox()
        Me.txtModelPicture = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboExamNo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboExamType = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtStation = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboScheduleID = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.ChkPratice = New System.Windows.Forms.CheckBox()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdEnd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdQuery = New System.Windows.Forms.Button()
        Me.DataGV = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Panel5)
        Me.GroupBox1.Controls.Add(Me.Panel2)
        Me.GroupBox1.Controls.Add(Me.Panel1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1053, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Exam Schedule/ตารางสอบ"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Panel4)
        Me.Panel5.Controls.Add(Me.Panel7)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Controls.Add(Me.Panel3)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 66)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(823, 353)
        Me.Panel5.TabIndex = 99
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.dtpStart)
        Me.Panel4.Controls.Add(Me.txtTeacher)
        Me.Panel4.Controls.Add(Me.dtpEnd)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(0, 312)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(823, 41)
        Me.Panel4.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(177, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Test Start Date/วันที่เริ่มต้นทดสอบ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(601, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 15)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Teacher/ผู้สอน"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(299, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(186, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Test End Date/วันที่สิ้นสุดการทดสอบ"
        '
        'dtpStart
        '
        Me.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpStart.Location = New System.Drawing.Point(196, 9)
        Me.dtpStart.Name = "dtpStart"
        Me.dtpStart.Size = New System.Drawing.Size(97, 21)
        Me.dtpStart.TabIndex = 11
        '
        'txtTeacher
        '
        Me.txtTeacher.Location = New System.Drawing.Point(689, 9)
        Me.txtTeacher.Name = "txtTeacher"
        Me.txtTeacher.Size = New System.Drawing.Size(121, 21)
        Me.txtTeacher.TabIndex = 13
        '
        'dtpEnd
        '
        Me.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnd.Location = New System.Drawing.Point(491, 9)
        Me.dtpEnd.Name = "dtpEnd"
        Me.dtpEnd.Size = New System.Drawing.Size(104, 21)
        Me.dtpEnd.TabIndex = 12
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Label13)
        Me.Panel7.Controls.Add(Me.cboExamNoPratice)
        Me.Panel7.Controls.Add(Me.Label14)
        Me.Panel7.Controls.Add(Me.cboExamTypePratice)
        Me.Panel7.Controls.Add(Me.Label15)
        Me.Panel7.Controls.Add(Me.txtStationPractice)
        Me.Panel7.Controls.Add(Me.txtModelPractice)
        Me.Panel7.Controls.Add(Me.Label16)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 208)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(823, 104)
        Me.Panel7.TabIndex = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(19, 45)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(206, 15)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Test Paper No./กระดาษทดสอบหมายเลข"
        '
        'cboExamNoPratice
        '
        Me.cboExamNoPratice.Enabled = False
        Me.cboExamNoPratice.FormattingEnabled = True
        Me.cboExamNoPratice.Location = New System.Drawing.Point(231, 42)
        Me.cboExamNoPratice.Name = "cboExamNoPratice"
        Me.cboExamNoPratice.Size = New System.Drawing.Size(287, 23)
        Me.cboExamNoPratice.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(85, 14)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 15)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'cboExamTypePratice
        '
        Me.cboExamTypePratice.Enabled = False
        Me.cboExamTypePratice.FormattingEnabled = True
        Me.cboExamTypePratice.Location = New System.Drawing.Point(231, 11)
        Me.cboExamTypePratice.Name = "cboExamTypePratice"
        Me.cboExamTypePratice.Size = New System.Drawing.Size(287, 23)
        Me.cboExamTypePratice.TabIndex = 8
        Me.cboExamTypePratice.Text = "Practice"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(527, 15)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(81, 15)
        Me.Label15.TabIndex = 83
        Me.Label15.Text = "Station/สเตชั่น"
        '
        'txtStationPractice
        '
        Me.txtStationPractice.Enabled = False
        Me.txtStationPractice.Location = New System.Drawing.Point(610, 11)
        Me.txtStationPractice.Name = "txtStationPractice"
        Me.txtStationPractice.Size = New System.Drawing.Size(121, 21)
        Me.txtStationPractice.TabIndex = 4
        '
        'txtModelPractice
        '
        Me.txtModelPractice.Enabled = False
        Me.txtModelPractice.Location = New System.Drawing.Point(231, 71)
        Me.txtModelPractice.Name = "txtModelPractice"
        Me.txtModelPractice.Size = New System.Drawing.Size(287, 21)
        Me.txtModelPractice.TabIndex = 10
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(150, 74)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 15)
        Me.Label16.TabIndex = 85
        Me.Label16.Text = "Model/โมเดล"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.cboExamNoPicture)
        Me.Panel6.Controls.Add(Me.Label10)
        Me.Panel6.Controls.Add(Me.cboExamTypePicture)
        Me.Panel6.Controls.Add(Me.Label11)
        Me.Panel6.Controls.Add(Me.txtStationPicture)
        Me.Panel6.Controls.Add(Me.txtModelPicture)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 104)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(823, 104)
        Me.Panel6.TabIndex = 99
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(206, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Test Paper No./กระดาษทดสอบหมายเลข"
        '
        'cboExamNoPicture
        '
        Me.cboExamNoPicture.FormattingEnabled = True
        Me.cboExamNoPicture.Location = New System.Drawing.Point(231, 42)
        Me.cboExamNoPicture.Name = "cboExamNoPicture"
        Me.cboExamNoPicture.Size = New System.Drawing.Size(287, 23)
        Me.cboExamNoPicture.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(85, 14)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(140, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'cboExamTypePicture
        '
        Me.cboExamTypePicture.Enabled = False
        Me.cboExamTypePicture.FormattingEnabled = True
        Me.cboExamTypePicture.Location = New System.Drawing.Point(231, 11)
        Me.cboExamTypePicture.Name = "cboExamTypePicture"
        Me.cboExamTypePicture.Size = New System.Drawing.Size(287, 23)
        Me.cboExamTypePicture.TabIndex = 5
        Me.cboExamTypePicture.Text = "Picture"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(527, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 15)
        Me.Label11.TabIndex = 83
        Me.Label11.Text = "Station/สเตชั่น"
        '
        'txtStationPicture
        '
        Me.txtStationPicture.Enabled = False
        Me.txtStationPicture.Location = New System.Drawing.Point(610, 11)
        Me.txtStationPicture.Name = "txtStationPicture"
        Me.txtStationPicture.Size = New System.Drawing.Size(121, 21)
        Me.txtStationPicture.TabIndex = 4
        '
        'txtModelPicture
        '
        Me.txtModelPicture.Location = New System.Drawing.Point(231, 71)
        Me.txtModelPicture.Name = "txtModelPicture"
        Me.txtModelPicture.Size = New System.Drawing.Size(287, 21)
        Me.txtModelPicture.TabIndex = 7
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 74)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(75, 15)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Model/โมเดล"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.cboExamNo)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.cboExamType)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtStation)
        Me.Panel3.Controls.Add(Me.txtModel)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(823, 104)
        Me.Panel3.TabIndex = 97
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(206, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Test Paper No./กระดาษทดสอบหมายเลข"
        '
        'cboExamNo
        '
        Me.cboExamNo.FormattingEnabled = True
        Me.cboExamNo.Location = New System.Drawing.Point(231, 42)
        Me.cboExamNo.Name = "cboExamNo"
        Me.cboExamNo.Size = New System.Drawing.Size(287, 23)
        Me.cboExamNo.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(85, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Exam Type/ประเภทข้อสอบ"
        '
        'cboExamType
        '
        Me.cboExamType.Enabled = False
        Me.cboExamType.FormattingEnabled = True
        Me.cboExamType.Location = New System.Drawing.Point(231, 11)
        Me.cboExamType.Name = "cboExamType"
        Me.cboExamType.Size = New System.Drawing.Size(287, 23)
        Me.cboExamType.TabIndex = 2
        Me.cboExamType.Text = "Theory_Auto"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(527, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 15)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Station/สเตชั่น"
        '
        'txtStation
        '
        Me.txtStation.Enabled = False
        Me.txtStation.Location = New System.Drawing.Point(610, 11)
        Me.txtStation.Name = "txtStation"
        Me.txtStation.Size = New System.Drawing.Size(121, 21)
        Me.txtStation.TabIndex = 4
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(231, 71)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(287, 21)
        Me.txtModel.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(150, 74)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 15)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Model/โมเดล"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cboScheduleID)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 49)
        Me.Panel2.TabIndex = 96
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Schedule No./เลขที่ข้อสอบ"
        '
        'cboScheduleID
        '
        Me.cboScheduleID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboScheduleID.FormattingEnabled = True
        Me.cboScheduleID.Location = New System.Drawing.Point(168, 13)
        Me.cboScheduleID.Name = "cboScheduleID"
        Me.cboScheduleID.Size = New System.Drawing.Size(642, 23)
        Me.cboScheduleID.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmdStart)
        Me.Panel1.Controls.Add(Me.ChkPratice)
        Me.Panel1.Controls.Add(Me.cmdDelete)
        Me.Panel1.Controls.Add(Me.cmdAdd)
        Me.Panel1.Controls.Add(Me.cmdEnd)
        Me.Panel1.Controls.Add(Me.cmdExit)
        Me.Panel1.Controls.Add(Me.cmdQuery)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(826, 17)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(224, 402)
        Me.Panel1.TabIndex = 95
        '
        'cmdStart
        '
        Me.cmdStart.Location = New System.Drawing.Point(15, 13)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(56, 47)
        Me.cmdStart.TabIndex = 14
        Me.cmdStart.Text = "Start เริ่ม"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'ChkPratice
        '
        Me.ChkPratice.AutoSize = True
        Me.ChkPratice.Location = New System.Drawing.Point(15, 123)
        Me.ChkPratice.Name = "ChkPratice"
        Me.ChkPratice.Size = New System.Drawing.Size(64, 19)
        Me.ChkPratice.TabIndex = 94
        Me.ChkPratice.Text = "Pratice"
        Me.ChkPratice.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDelete.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDelete.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDelete.Image = CType(resources.GetObject("cmdDelete.Image"), System.Drawing.Image)
        Me.cmdDelete.Location = New System.Drawing.Point(142, 13)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDelete.Size = New System.Drawing.Size(70, 47)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "&Delete ลบ"
        Me.cmdDelete.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdDelete.UseVisualStyleBackColor = False
        '
        'cmdAdd
        '
        Me.cmdAdd.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAdd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAdd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAdd.Image = CType(resources.GetObject("cmdAdd.Image"), System.Drawing.Image)
        Me.cmdAdd.Location = New System.Drawing.Point(77, 63)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAdd.Size = New System.Drawing.Size(59, 50)
        Me.cmdAdd.TabIndex = 18
        Me.cmdAdd.Text = "&Add/เพิ่ม"
        Me.cmdAdd.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdAdd.UseCompatibleTextRendering = True
        Me.cmdAdd.UseVisualStyleBackColor = False
        '
        'cmdEnd
        '
        Me.cmdEnd.Location = New System.Drawing.Point(15, 63)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.Size = New System.Drawing.Size(56, 50)
        Me.cmdEnd.TabIndex = 17
        Me.cmdEnd.Text = "End   สิ้นสุด"
        Me.cmdEnd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.BackColor = System.Drawing.SystemColors.Control
        Me.cmdExit.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdExit.Image = CType(resources.GetObject("cmdExit.Image"), System.Drawing.Image)
        Me.cmdExit.Location = New System.Drawing.Point(142, 63)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdExit.Size = New System.Drawing.Size(70, 50)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "Exit/ออก"
        Me.cmdExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdExit.UseVisualStyleBackColor = False
        '
        'cmdQuery
        '
        Me.cmdQuery.BackColor = System.Drawing.SystemColors.Control
        Me.cmdQuery.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdQuery.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdQuery.Location = New System.Drawing.Point(77, 13)
        Me.cmdQuery.Name = "cmdQuery"
        Me.cmdQuery.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdQuery.Size = New System.Drawing.Size(59, 47)
        Me.cmdQuery.TabIndex = 15
        Me.cmdQuery.Text = "&Query ตรวจสอบ"
        Me.cmdQuery.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdQuery.UseVisualStyleBackColor = False
        '
        'DataGV
        '
        Me.DataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGV.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGV.Location = New System.Drawing.Point(0, 422)
        Me.DataGV.Name = "DataGV"
        Me.DataGV.RowTemplate.Height = 23
        Me.DataGV.Size = New System.Drawing.Size(1053, 329)
        Me.DataGV.TabIndex = 1
        '
        'frmExamSchedule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 751)
        Me.Controls.Add(Me.DataGV)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmExamSchedule"
        Me.Text = "frmExamSchedule [20231028]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cboExamNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGV As System.Windows.Forms.DataGridView
    Friend WithEvents dtpEnd As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpStart As System.Windows.Forms.DateTimePicker
    Public WithEvents cmdQuery As System.Windows.Forms.Button
    Public WithEvents cmdExit As System.Windows.Forms.Button
    Public WithEvents cmdAdd As System.Windows.Forms.Button
    Public WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtStation As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtModel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTeacher As System.Windows.Forms.TextBox
    Friend WithEvents cmdEnd As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents cboExamType As System.Windows.Forms.ComboBox
    Friend WithEvents cboScheduleID As System.Windows.Forms.ComboBox
    Friend WithEvents ChkPratice As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents cboExamNoPratice As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cboExamTypePratice As ComboBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtStationPractice As TextBox
    Friend WithEvents txtModelPractice As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents cboExamNoPicture As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cboExamTypePicture As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents txtStationPicture As TextBox
    Friend WithEvents txtModelPicture As TextBox
    Friend WithEvents Label12 As Label
End Class
