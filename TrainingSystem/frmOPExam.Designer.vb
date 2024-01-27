<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOPExam
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
        Me.components = New System.ComponentModel.Container()
        Me.PanelTop = New System.Windows.Forms.Panel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdFinish = New System.Windows.Forms.Button()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.grpBoxEmp = New System.Windows.Forms.GroupBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtEmployeeName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grpBoxExam = New System.Windows.Forms.GroupBox()
        Me.txtExamNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTitle = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SplitH = New System.Windows.Forms.Splitter()
        Me.PanelContent = New System.Windows.Forms.Panel()
        Me.TimerChk = New System.Windows.Forms.Timer(Me.components)
        Me.PanelTop.SuspendLayout()
        Me.grpBoxEmp.SuspendLayout()
        Me.grpBoxExam.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelTop
        '
        Me.PanelTop.Controls.Add(Me.cmdExit)
        Me.PanelTop.Controls.Add(Me.cmdFinish)
        Me.PanelTop.Controls.Add(Me.cmdStart)
        Me.PanelTop.Controls.Add(Me.grpBoxEmp)
        Me.PanelTop.Controls.Add(Me.grpBoxExam)
        Me.PanelTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelTop.Location = New System.Drawing.Point(0, 0)
        Me.PanelTop.Name = "PanelTop"
        Me.PanelTop.Size = New System.Drawing.Size(897, 84)
        Me.PanelTop.TabIndex = 1
        '
        'cmdExit
        '
        Me.cmdExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdExit.Location = New System.Drawing.Point(751, 59)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(134, 25)
        Me.cmdExit.TabIndex = 97
        Me.cmdExit.Text = "Exit/ออก"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdFinish
        '
        Me.cmdFinish.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdFinish.Location = New System.Drawing.Point(751, 32)
        Me.cmdFinish.Name = "cmdFinish"
        Me.cmdFinish.Size = New System.Drawing.Size(134, 25)
        Me.cmdFinish.TabIndex = 96
        Me.cmdFinish.Text = "Finish Test/ทดสอบสำเร็จ"
        Me.cmdFinish.UseVisualStyleBackColor = True
        '
        'cmdStart
        '
        Me.cmdStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmdStart.Location = New System.Drawing.Point(751, 3)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(134, 25)
        Me.cmdStart.TabIndex = 95
        Me.cmdStart.Text = "Start Test/เริ่มทดสอบ"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'grpBoxEmp
        '
        Me.grpBoxEmp.Controls.Add(Me.txtEmployeeID)
        Me.grpBoxEmp.Controls.Add(Me.txtEmployeeName)
        Me.grpBoxEmp.Controls.Add(Me.Label2)
        Me.grpBoxEmp.Controls.Add(Me.Label1)
        Me.grpBoxEmp.Location = New System.Drawing.Point(12, 45)
        Me.grpBoxEmp.Name = "grpBoxEmp"
        Me.grpBoxEmp.Size = New System.Drawing.Size(733, 38)
        Me.grpBoxEmp.TabIndex = 1
        Me.grpBoxEmp.TabStop = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.Enabled = False
        Me.txtEmployeeID.Location = New System.Drawing.Point(143, 10)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(132, 20)
        Me.txtEmployeeID.TabIndex = 94
        '
        'txtEmployeeName
        '
        Me.txtEmployeeName.Enabled = False
        Me.txtEmployeeName.Location = New System.Drawing.Point(418, 10)
        Me.txtEmployeeName.Name = "txtEmployeeName"
        Me.txtEmployeeName.Size = New System.Drawing.Size(132, 20)
        Me.txtEmployeeName.TabIndex = 93
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Name/ชื่อ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "EmployeeID/รหัสพนักงาน"
        '
        'grpBoxExam
        '
        Me.grpBoxExam.Controls.Add(Me.txtExamNo)
        Me.grpBoxExam.Controls.Add(Me.Label3)
        Me.grpBoxExam.Controls.Add(Me.txtTitle)
        Me.grpBoxExam.Controls.Add(Me.Label4)
        Me.grpBoxExam.Location = New System.Drawing.Point(11, 6)
        Me.grpBoxExam.Name = "grpBoxExam"
        Me.grpBoxExam.Size = New System.Drawing.Size(734, 38)
        Me.grpBoxExam.TabIndex = 0
        Me.grpBoxExam.TabStop = False
        '
        'txtExamNo
        '
        Me.txtExamNo.Enabled = False
        Me.txtExamNo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.txtExamNo.Location = New System.Drawing.Point(144, 10)
        Me.txtExamNo.Name = "txtExamNo"
        Me.txtExamNo.Size = New System.Drawing.Size(132, 20)
        Me.txtExamNo.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Exam No./หมายเลขข้อสอบ"
        '
        'txtTitle
        '
        Me.txtTitle.Enabled = False
        Me.txtTitle.Location = New System.Drawing.Point(419, 10)
        Me.txtTitle.Name = "txtTitle"
        Me.txtTitle.Size = New System.Drawing.Size(306, 20)
        Me.txtTitle.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(299, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Exam Subject/วิชาสอบ"
        '
        'SplitH
        '
        Me.SplitH.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitH.Location = New System.Drawing.Point(0, 84)
        Me.SplitH.Name = "SplitH"
        Me.SplitH.Size = New System.Drawing.Size(897, 6)
        Me.SplitH.TabIndex = 3
        Me.SplitH.TabStop = False
        '
        'PanelContent
        '
        Me.PanelContent.AutoScroll = True
        Me.PanelContent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContent.Location = New System.Drawing.Point(0, 90)
        Me.PanelContent.Name = "PanelContent"
        Me.PanelContent.Size = New System.Drawing.Size(897, 336)
        Me.PanelContent.TabIndex = 4
        '
        'TimerChk
        '
        Me.TimerChk.Interval = 1000
        '
        'frmOPExam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 426)
        Me.Controls.Add(Me.PanelContent)
        Me.Controls.Add(Me.SplitH)
        Me.Controls.Add(Me.PanelTop)
        Me.Name = "frmOPExam"
        Me.Text = "frmPOExam [20230824]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelTop.ResumeLayout(False)
        Me.grpBoxEmp.ResumeLayout(False)
        Me.grpBoxEmp.PerformLayout()
        Me.grpBoxExam.ResumeLayout(False)
        Me.grpBoxExam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelTop As System.Windows.Forms.Panel
    Friend WithEvents SplitH As System.Windows.Forms.Splitter
    Friend WithEvents PanelContent As System.Windows.Forms.Panel
    Friend WithEvents grpBoxEmp As System.Windows.Forms.GroupBox
    Friend WithEvents grpBoxExam As System.Windows.Forms.GroupBox
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdFinish As System.Windows.Forms.Button
    Friend WithEvents cmdStart As System.Windows.Forms.Button
    Friend WithEvents txtExamNo As System.Windows.Forms.TextBox
    Friend WithEvents TimerChk As System.Windows.Forms.Timer
End Class
