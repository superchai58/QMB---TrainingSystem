Public Class frmSetQuestions
    Public mActionType As String      ''Exam/PreView

    Private Sub frmSetQuestions_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbQuestionGroup.Items.Add("OPExam")
        cmbQuestionType.Items.Clear()
        If mActionType.ToUpper = "Theory_Auto".ToUpper Then
            cmbQuestionType.Items.Add("Theory_Auto")
        ElseIf mActionType.ToUpper = "Practice".ToUpper Then
            cmbQuestionType.Items.Add("Practice")
        Else
            cmbQuestionType.Items.Add("Theory_Auto")
            cmbQuestionType.Items.Add("Practice")
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub
        If cmbQuestionType.Text = "Theory_Auto" Then
            MsgBox("理论题在上传试理论题库时自动添加了试卷的！", MsgBoxStyle.Information, "OP Exam")
            Return
        End If
        StrSql = "Exec OP_SetQuestions  'Insert'," & sq(P_UserName) & ",-1, N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" & _
               sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU)  '0001
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData()
            End If

        Else
            MsgBox("新增试题失败！", MsgBoxStyle.Information, "OP Exam")

        End If


    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If txtExamNo.Text.Trim = "" Then Exit Sub

        If MsgBox("确定要删除吗！", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "OP Exam") = MsgBoxResult.No Then Exit Sub

        StrSql = "Exec OP_SetQuestions  'Delete'," & sq(P_UserName) & "," & txtExamNo.Text.Trim & "," & sq(P_BU)  '0001
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData()
            End If

        Else
            MsgBox("新增试题失败！", MsgBoxStyle.Information, "OP Exam")

        End If
    End Sub

    Private Function ValidData() As Boolean
        ValidData = False
        If cmbQuestionGroup.Text.Trim = "" Or cmbQuestionType.Text.Trim = "" Then
            MsgBox("请首先选择试题组及类型！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        If txtTitle.Text.Trim = "" Then
            MsgBox("请输入试题科目信息！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Sub RefreshData()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "Exec OP_QryExamSubject -1,N'', N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) '0001
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamSubject")
            DataGV.DataSource = ds.Tables("ExamSubject")
            DataGV.Refresh()
        Else
            MsgBox("没有理论题目的信息！", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        RefreshData()
    End Sub

    Private Sub btnSelQuestion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelQuestion.Click

        If txtExamNo.Text.Trim = "" Or txtTitle.Text.Trim = "" Then
            MsgBox("请选择需维护的试题科目！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If cmbQuestionType.Text.Trim.ToUpper() = "Theory_Auto".ToUpper() Then
            frmSelQuestionExam.mExamType = "Theory_Auto"
            frmSelQuestionExam.mExamNo = CInt(Me.txtExamNo.Text.Trim)
            frmSelQuestionExam.mTitle = Me.txtTitle.Text.Trim
            frmSelQuestionExam.ShowDialog()
        Else

            frmSetPractice.mExamNo = CInt(Me.txtExamNo.Text.Trim)
            frmSetPractice.mTitle = Me.txtTitle.Text.Trim
            frmSetPractice.ShowDialog()
        End If
    End Sub

    Private Sub DataGV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGV.DoubleClick
        FillTextCtrl(DataGV)
    End Sub

    Private Sub FillTextCtrl(ByVal myDataGV As DataGridView)
        If myDataGV.RowCount > 0 And myDataGV.CurrentRow.Index >= 0 Then
            With myDataGV
                txtExamNo.Text = .Item("Exam_No", .CurrentRow.Index).Value.ToString()
                cmbQuestionGroup.Text = .Item("Question_Group", .CurrentRow.Index).Value.ToString()
                cmbQuestionType.Text = .Item("Question_Type", .CurrentRow.Index).Value.ToString()
                txtTitle.Text = .Item("Title", .CurrentRow.Index).Value.ToString()
                txtRemark.Text = .Item("Remark", .CurrentRow.Index).Value.ToString()

            End With
        End If
    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        If txtExamNo.Text.Trim = "" Or txtTitle.Text.Trim = "" Then
            MsgBox("请选择需预览的试题科目！", MsgBoxStyle.Critical, "Prompt")
            Exit Sub
        End If

        frmOPExam.mExamNo = txtExamNo.Text.Trim
        frmOPExam.mActionType = "Preview"
        frmOPExam.txtExamNo.Text = txtExamNo.Text.Trim
        frmOPExam.txtTitle.Text = txtTitle.Text.Trim

        StrSql = "Exec OP_QryExamContent " & CInt(txtExamNo.Text.Trim) & "," & sq(cmbQuestionType.Text.Trim) & " ,'Text',N" & sq(txtTitle.Text.Trim) & "," & sq(P_BU) '0001
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamContent")
            frmOPExam.mdsExam = ds
            frmOPExam.ShowDialog()
        End If
    End Sub


End Class

