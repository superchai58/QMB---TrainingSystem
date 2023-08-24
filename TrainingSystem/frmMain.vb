Imports System.Windows.Forms

Public Class frmMain
    Private Sub initMenu()
        Dim i As Integer
      
        If P_UserName = "Tester" Then
            mnuSetQuestions.Enabled = False
            mnuSetPracticeQuestions.Enabled = False
            mnuQueryQuestion.Enabled = False
            mnuExamShechudle.Enabled = False
            mnuExamOperator.Enabled = False
            mnuPracScore.Enabled = False
            mnuOperatorTest.Enabled = True
            ExamResult.Enabled = False
            mnuSetPictureQuestion.Enabled = False
            Alarm_Lv1.Enabled = False
            Alarm_Exam.Enabled = False
        Else
            For i = 0 To UBound(P_Userright)
                Select Case UCase(P_Userright(i))
                    Case "DEFUSERBASIC"
                        Me.defUserBasic.Enabled = True
                    Case "DEFUSERRIGHT"
                        Me.defUserRight.Enabled = True
                    Case "DEFUSERCONFIG"
                        Me.DefUserConfig.Enabled = True
                    Case "UPLOADDATA"
                        Me.UploadDate.Enabled = True
                    Case "UPDATEEXAMRESULT"
                        Me.UpdateExamResult.Enabled = True
                        Me.UpdateOPName.Enabled = True
                        Me.UpdateOPID.Enabled = True
                        Me.UploadExamLineOperator.Enabled = True
                        Me.Alarm_Lv1.Enabled = True
                        Me.Alarm_Exam.Enabled = True
                    Case "PRACTICE"
                        Me.mnuPracScore.Enabled = True
                    Case "OPERATOREXAM"
                        Me.mnuOperatorTest.Enabled = True
                    Case "MAINTAINEXAMDATA"
                        Me.mnuSetQuestions.Enabled = True
                        Me.mnuSetPracticeQuestions.Enabled = True
                        Me.mnuQueryQuestion.Enabled = True
                        Me.mnuExamShechudle.Enabled = True
                        Me.mnuExamOperator.Enabled = True
                        Me.mnuSetPictureQuestion.Enabled = True
                    Case Else
                End Select
            Next
        End If

    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If frmExercise.cmdStart.Enabled = False And frmExercise.cmdGet.Enabled = False Then
            If MsgBox("答题还未完成，确定要纪录此次答题分数并退出么？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                e.Cancel = True
                Exit Sub
            End If
            Call frmExercise.cmdFinish_Click(frmExercise.cmdFinish, New System.EventArgs())
        End If
    End Sub
    Private Sub frmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If P_BU = "" Then
            MsgBox("请在set.ini 中定义 所属 BU。", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Call initMenu()
    End Sub

    Private Sub defUserRight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defUserRight.Click
        frmUserRight.MdiParent = Me
        frmUserRight.Show()
    End Sub

    Private Sub ExitMenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub


    Private Sub defUserBasic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles defUserBasic.Click
        frmDefineUserBase.MdiParent = Me
        frmDefineUserBase.Show()
    End Sub

    Private Sub DefUserConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DefUserConfig.Click
        frmUserConfig.MdiParent = Me
        frmUserConfig.Show()
    End Sub

    Private Sub ExamToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'frmExercise.MdiParent = Me
        'frmExercise.Show()
        P_FormFlag = "EXAM"
        FrmUserInput.MdiParent = Me
        FrmUserInput.Show()
    End Sub

    Private Sub ExerciseDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmMaintainExercise.MdiParent = Me
        frmMaintainExercise.Show()
    End Sub

    Private Sub GroupListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmGroupList.MdiParent = Me
        frmGroupList.Show()
    End Sub

    Private Sub ScoreDetailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UploadDate.Click
        frmUploadData.MdiParent = Me
        frmUploadData.Show()
    End Sub

    Private Sub BaseDataToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmBaseData.MdiParent = Me
        FrmBaseData.Show()
    End Sub

    Private Sub ExitMenu_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitMenu.Click
        Me.Close()
    End Sub

    Private Sub PracticeListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmPracticeList.MdiParent = Me
        'FrmPracticeList.Show()
        P_FormFlag = "PRACTICE"
        FrmUserInput.MdiParent = Me
        FrmUserInput.Show()
    End Sub

    Private Sub MaintainPhotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmMaintainPhoto.MdiParent = Me
        FrmMaintainPhoto.Show()
    End Sub

    Private Sub PictureExamToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'FrmExercisePhoto.MdiParent = Me
        'FrmExercisePhoto.Show()
        P_FormFlag = "PHO_TEST"
        FrmUserInput.MdiParent = Me
        FrmUserInput.Show()
    End Sub

    Private Sub ExamResult_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExamResult.Click
        FrmExamResult.MdiParent = Me
        FrmExamResult.Show()
    End Sub

    Private Sub HRInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        FrmHRInfo.MdiParent = Me
        FrmHRInfo.Show()
    End Sub

    Private Sub mnuSetQuestions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetQuestions.Click
        frmSetQuestions.mActionType = "Theory_Auto"
        frmSetQuestions.MdiParent = Me
        frmSetQuestions.Show()
    End Sub

    Private Sub mnuSetPracticeQuestions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetPracticeQuestions.Click
        frmSetQuestions.mActionType = "Practice"
        frmSetQuestions.MdiParent = Me
        frmSetQuestions.Show()
    End Sub

    Private Sub mnuQueryQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQueryQuestion.Click
        frmSetQuestions.mActionType = "Query"
        frmSetQuestions.MdiParent = Me
        frmSetQuestions.Show()
    End Sub

    Private Sub mnuExamShechudle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExamShechudle.Click
        frmExamSchedule.MdiParent = Me
        frmExamSchedule.Show()
    End Sub

    Private Sub mnuExamOperator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExamOperator.Click
        frmExamOperator.MdiParent = Me
        frmExamOperator.Show()
    End Sub

    Private Sub mnuOperatorTest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuOperatorTest.Click
        P_FormFlag = "OPExam"
        FrmUserInput.ShowDialog()
    End Sub

    Private Sub mnuPracScore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPracScore.Click

        frmOpPracScore.MdiParent = Me
        frmOpPracScore.Show()
    End Sub

    Private Sub mnuSetPictureQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSetPictureQuestion.Click
        FrmMaintainPhoto.MdiParent = Me
        FrmMaintainPhoto.Show()
    End Sub


    Private Sub UpdateExamResult_Click(sender As Object, e As EventArgs) Handles UpdateExamResult.Click
        frmExamResultUpdate.MdiParent = Me
        frmExamResultUpdate.Show()
    End Sub

    Private Sub CheckHRInformation_Click(sender As Object, e As EventArgs)
        FrmHRInfo.MdiParent = Me
        FrmHRInfo.Show()
    End Sub

    Private Sub UpdateOPID_Click(sender As Object, e As EventArgs) Handles UpdateOPID.Click
        frmExamOperatorUpdateOPID.MdiParent = Me
        frmExamOperatorUpdateOPID.Show()

    End Sub

    Private Sub UpdateOPName_Click(sender As Object, e As EventArgs) Handles UpdateOPName.Click
        frmExamOperatorUpdateName.MdiParent = Me
        frmExamOperatorUpdateName.Show()

    End Sub

    Private Sub UploadExamLineOperator_Click(sender As Object, e As EventArgs) Handles UploadExamLineOperator.Click
        frmExamLineUpdateOP.MdiParent = Me
        frmExamLineUpdateOP.Show()

    End Sub

    Private Sub Alarm_Lv1_Click(sender As Object, e As EventArgs) Handles Alarm_Lv1.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        StrSql = "exec SMT.dbo.AlarmMail_CheckLv1"
        rst = Conn.Execute(StrSql)
        MsgBox("Lv1警報信，發信完成!")
    End Sub

    Private Sub Alarm_Exam_Click(sender As Object, e As EventArgs) Handles Alarm_Exam.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        StrSql = "exec SMT.dbo.AlarmMail_CheckDeadLine"
        rst = Conn.Execute(StrSql)
        MsgBox("稽核月份警報信，發信完成!")
    End Sub
End Class
