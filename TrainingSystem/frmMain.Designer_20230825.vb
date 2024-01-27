<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DefBaseMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.defUserBasic = New System.Windows.Forms.ToolStripMenuItem()
        Me.defUserRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.DefUserConfig = New System.Windows.Forms.ToolStripMenuItem()
        Me.MainTainMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateExamResult = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateOPName = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateOPID = New System.Windows.Forms.ToolStripMenuItem()
        Me.UploadExamLineOperator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOnlineTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetQuestions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetPracticeQuestions = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSetPictureQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQueryQuestion = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamShechudle = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExamOperator = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOperatorTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPracScore = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExamResult = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alarm_Lv1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Alarm_Exam = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DefBaseMenu, Me.MainTainMenu, Me.mnuOnlineTest, Me.ExamToolStripMenuItem, Me.MailMenuItem, Me.ExitMenu})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(871, 24)
        Me.MenuStrip1.TabIndex = 9
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DefBaseMenu
        '
        Me.DefBaseMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.defUserBasic, Me.defUserRight, Me.DefUserConfig})
        Me.DefBaseMenu.Name = "DefBaseMenu"
        Me.DefBaseMenu.Size = New System.Drawing.Size(165, 20)
        Me.DefBaseMenu.Text = "Basic Setting/การตั้งค่าพื้นฐาน"
        '
        'defUserBasic
        '
        Me.defUserBasic.Enabled = False
        Me.defUserBasic.Name = "defUserBasic"
        Me.defUserBasic.Size = New System.Drawing.Size(249, 22)
        Me.defUserBasic.Text = "User Manage/จัดการผู้ใช้"
        '
        'defUserRight
        '
        Me.defUserRight.Enabled = False
        Me.defUserRight.Name = "defUserRight"
        Me.defUserRight.Size = New System.Drawing.Size(249, 22)
        Me.defUserRight.Text = "Permission Manage/การจัดการสิทธิ์"
        '
        'DefUserConfig
        '
        Me.DefUserConfig.Enabled = False
        Me.DefUserConfig.Name = "DefUserConfig"
        Me.DefUserConfig.Size = New System.Drawing.Size(249, 22)
        Me.DefUserConfig.Text = "Personal Setting/ตั้งค่าส่วนตัว"
        '
        'MainTainMenu
        '
        Me.MainTainMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UploadDate, Me.UpdateExamResult, Me.UpdateOPName, Me.UpdateOPID, Me.UploadExamLineOperator})
        Me.MainTainMenu.Name = "MainTainMenu"
        Me.MainTainMenu.Size = New System.Drawing.Size(189, 20)
        Me.MainTainMenu.Text = "Message Manage/การจัดการข้อมูล"
        '
        'UploadDate
        '
        Me.UploadDate.Enabled = False
        Me.UploadDate.Name = "UploadDate"
        Me.UploadDate.Size = New System.Drawing.Size(322, 22)
        Me.UploadDate.Text = "Upload data/อัปโหลดข้อมูล"
        '
        'UpdateExamResult
        '
        Me.UpdateExamResult.Enabled = False
        Me.UpdateExamResult.Name = "UpdateExamResult"
        Me.UpdateExamResult.Size = New System.Drawing.Size(322, 22)
        Me.UpdateExamResult.Text = "Upload Test Score/อัปโหลดผลคะแนน"
        '
        'UpdateOPName
        '
        Me.UpdateOPName.Enabled = False
        Me.UpdateOPName.Name = "UpdateOPName"
        Me.UpdateOPName.Size = New System.Drawing.Size(322, 22)
        Me.UpdateOPName.Text = "Update Employee Name/อัปโหลดขื่อพนักงาน"
        '
        'UpdateOPID
        '
        Me.UpdateOPID.Enabled = False
        Me.UpdateOPID.Name = "UpdateOPID"
        Me.UpdateOPID.Size = New System.Drawing.Size(322, 22)
        Me.UpdateOPID.Text = "Update Employee ID/อัปโหลดรหัสพนักงาน"
        '
        'UploadExamLineOperator
        '
        Me.UploadExamLineOperator.Enabled = False
        Me.UploadExamLineOperator.Name = "UploadExamLineOperator"
        Me.UploadExamLineOperator.Size = New System.Drawing.Size(322, 22)
        Me.UploadExamLineOperator.Text = "Maintain Line Audit User/ปรับปรุงไลน์ตรวจสอบผู้ใช้"
        '
        'mnuOnlineTest
        '
        Me.mnuOnlineTest.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSetQuestions, Me.mnuSetPracticeQuestions, Me.mnuSetPictureQuestion, Me.mnuQueryQuestion, Me.mnuExamShechudle, Me.mnuExamOperator, Me.mnuOperatorTest, Me.mnuPracScore})
        Me.mnuOnlineTest.Name = "mnuOnlineTest"
        Me.mnuOnlineTest.Size = New System.Drawing.Size(162, 20)
        Me.mnuOnlineTest.Text = "Online Exam/การสอบออนไลน์"
        '
        'mnuSetQuestions
        '
        Me.mnuSetQuestions.Enabled = False
        Me.mnuSetQuestions.Name = "mnuSetQuestions"
        Me.mnuSetQuestions.Size = New System.Drawing.Size(360, 22)
        Me.mnuSetQuestions.Text = "Theoretical Questions Manage/การจัดการคำถามเชิงทฤษฎี"
        '
        'mnuSetPracticeQuestions
        '
        Me.mnuSetPracticeQuestions.Enabled = False
        Me.mnuSetPracticeQuestions.Name = "mnuSetPracticeQuestions"
        Me.mnuSetPracticeQuestions.Size = New System.Drawing.Size(360, 22)
        Me.mnuSetPracticeQuestions.Text = "Practical Questions Manage/การจัดการคำถามเชิงปฏิบัติ"
        '
        'mnuSetPictureQuestion
        '
        Me.mnuSetPictureQuestion.Enabled = False
        Me.mnuSetPictureQuestion.Name = "mnuSetPictureQuestion"
        Me.mnuSetPictureQuestion.Size = New System.Drawing.Size(360, 22)
        Me.mnuSetPictureQuestion.Text = "Picture Questions Manage/การจัดการคำถามเชิงรูปภาพ"
        '
        'mnuQueryQuestion
        '
        Me.mnuQueryQuestion.Enabled = False
        Me.mnuQueryQuestion.Name = "mnuQueryQuestion"
        Me.mnuQueryQuestion.Size = New System.Drawing.Size(360, 22)
        Me.mnuQueryQuestion.Text = "Exam Search/ค้นหาข้อสอบ"
        '
        'mnuExamShechudle
        '
        Me.mnuExamShechudle.Enabled = False
        Me.mnuExamShechudle.Name = "mnuExamShechudle"
        Me.mnuExamShechudle.Size = New System.Drawing.Size(360, 22)
        Me.mnuExamShechudle.Text = "Exam Schedule/ตารางสอบ"
        '
        'mnuExamOperator
        '
        Me.mnuExamOperator.Enabled = False
        Me.mnuExamOperator.Name = "mnuExamOperator"
        Me.mnuExamOperator.Size = New System.Drawing.Size(360, 22)
        Me.mnuExamOperator.Text = "Register for an Exam/ลงทะเบียนสอบ"
        '
        'mnuOperatorTest
        '
        Me.mnuOperatorTest.Enabled = False
        Me.mnuOperatorTest.Name = "mnuOperatorTest"
        Me.mnuOperatorTest.Size = New System.Drawing.Size(360, 22)
        Me.mnuOperatorTest.Text = "OP Test/OP ทดสอบ"
        '
        'mnuPracScore
        '
        Me.mnuPracScore.Enabled = False
        Me.mnuPracScore.Name = "mnuPracScore"
        Me.mnuPracScore.Size = New System.Drawing.Size(360, 22)
        Me.mnuPracScore.Text = "Result Evaluation/การประเมินผล"
        '
        'ExamToolStripMenuItem
        '
        Me.ExamToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExamResult})
        Me.ExamToolStripMenuItem.Name = "ExamToolStripMenuItem"
        Me.ExamToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.ExamToolStripMenuItem.Text = "Test/การทดสอบ"
        '
        'ExamResult
        '
        Me.ExamResult.Name = "ExamResult"
        Me.ExamResult.Size = New System.Drawing.Size(261, 22)
        Me.ExamResult.Text = "Search Test Result/ค้นหาผลการทดสอบ"
        '
        'MailMenuItem
        '
        Me.MailMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Alarm_Lv1, Me.Alarm_Exam})
        Me.MailMenuItem.Name = "MailMenuItem"
        Me.MailMenuItem.Size = New System.Drawing.Size(162, 20)
        Me.MailMenuItem.Text = "Mail Manage/การจัดการอีเมล"
        '
        'Alarm_Lv1
        '
        Me.Alarm_Lv1.Name = "Alarm_Lv1"
        Me.Alarm_Lv1.Size = New System.Drawing.Size(342, 22)
        Me.Alarm_Lv1.Text = "Lv1 Alarm Mail/Lv1 การแจ้งเตือนเมล"
        '
        'Alarm_Exam
        '
        Me.Alarm_Exam.Name = "Alarm_Exam"
        Me.Alarm_Exam.Size = New System.Drawing.Size(342, 22)
        Me.Alarm_Exam.Text = "Monthly Audit Alarm Mail/การตรวจสอบเมลประจำเดือน"
        '
        'ExitMenu
        '
        Me.ExitMenu.Name = "ExitMenu"
        Me.ExitMenu.Size = New System.Drawing.Size(120, 20)
        Me.ExitMenu.Text = "Exit/ออกจากโปรแกรม"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 453)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "frmMain"
        Me.Text = "QMB Training System [20220818]"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DefBaseMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MainTainMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents defUserBasic As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents defUserRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DefUserConfig As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadDate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExamResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOnlineTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetQuestions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetPracticeQuestions As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQueryQuestion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOperatorTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExamShechudle As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExamOperator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuPracScore As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSetPictureQuestion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateOPName As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateExamResult As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateOPID As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UploadExamLineOperator As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MailMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alarm_Lv1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Alarm_Exam As System.Windows.Forms.ToolStripMenuItem

End Class
