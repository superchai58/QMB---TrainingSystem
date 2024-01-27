Public Class frmSearchQuestion
    Public mActionType As String      ''Exam/PreView
    Private Sub frmSearchQuestion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbQuestionGroup.Items.Add("OPExam")
        cmbQuestionType.Items.Clear()
        If mActionType.ToUpper = "Theory_Auto".ToUpper Then
            cmbQuestionType.Items.Add("Theory_Auto")
        ElseIf mActionType.ToUpper = "Practice".ToUpper Then
            cmbQuestionType.Items.Add("Practice")
        Else
            cmbQuestionType.Items.Add("Theory_Auto")
            cmbQuestionType.Items.Add("Practice")
            cmbQuestionType.Items.Add("Picture")
        End If
    End Sub

    Private Sub btnSelQuestion_Click(sender As Object, e As EventArgs) Handles btnSelQuestion.Click
        If txtExamNo.Text.Trim = "" Or txtTitle.Text.Trim = "" Then
            MsgBox("请选择需维护的试题科目！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If cmbQuestionType.Text.Trim.ToUpper() = "Theory_Auto".ToUpper() Then
            frmSelQuestionExam.mExamType = "Theory_Auto"
            frmSelQuestionExam.mExamNo = CInt(Me.txtExamNo.Text.Trim)
            frmSelQuestionExam.mTitle = Me.txtTitle.Text.Trim
            frmSelQuestionExam.ShowDialog()
        ElseIf cmbQuestionType.Text.Trim.ToUpper() = "Picture".ToUpper() Then
            frmSetPicture.mExamType = "Picture"
            frmSetPicture.mExamNo = CInt(Me.txtExamNo.Text.Trim)
            frmSetPicture.mTitle = Me.txtTitle.Text.Trim
            frmSetPicture.ShowDialog()
        Else
            frmSetPractice.mExamNo = CInt(Me.txtExamNo.Text.Trim)
            frmSetPractice.mTitle = Me.txtTitle.Text.Trim
            frmSetPractice.ShowDialog()
        End If
    End Sub

    Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
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

    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        RefreshData()
    End Sub

    Private Sub RefreshData()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        'Request 4 Warinya 20230825
        'StrSql = "Exec OP_QryExamSubject -1,N'', N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) '0001

        '--superchai add 20231021 (B)
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "Exec OP_QryExamSubject_test -1,N" & sq(txtTitle.Text.Trim) & ", N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) & ",N" & sq(txtRemark.Text.Trim) & ", 'OP'" '0001
        Else
            StrSql = "Exec OP_QryExamSubject_test -1,N" & sq(txtTitle.Text.Trim) & ", N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) & ",N" & sq(txtRemark.Text.Trim) & ", 'IDL'" '0001
        End If
        '--superchai add 20231021 (E)

        'StrSql = "Exec OP_QryExamSubject_test -1,N" & sq(txtTitle.Text.Trim) & ", N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) & ",N" & sq(txtRemark.Text.Trim) '0001
        'Request 4 Warinya 20230825

        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamSubject")
            DataGV.DataSource = ds.Tables("ExamSubject")
            DataGV.Refresh()
        Else
            MsgBox("没有理论题目的信息！", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If txtExamNo.Text.Trim = "" Then Exit Sub

        If MsgBox("确定要删除吗！", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "OP Exam") = MsgBoxResult.No Then Exit Sub

        'StrSql = "Exec OP_SetQuestions  @ActionType='Delete',@UserID=" & sq(P_UserName) & ",@ExamNo=" & txtExamNo.Text.Trim & ",@BU=" & sq(P_BU)  '0001
        StrSql = "Exec OP_SetQuestions_TEST  @ActionType='Delete',@UserID=" & sq(P_UserName) & ",@ExamNo=" & txtExamNo.Text.Trim & ",@BU=" & sq(P_BU)  '0001
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

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub DataGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGV.CellDoubleClick
        '------------superchai add 20231004 (B)-------------
        txtExamNo.Text = DataGV.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()
        cmbQuestionGroup.Text = DataGV.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()
        cmbQuestionType.Text = DataGV.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()
        txtTitle.Text = DataGV.Rows(e.RowIndex).Cells(3).Value.ToString().Trim()
        txtTitle.Text = DataGV.Rows(e.RowIndex).Cells(3).Value.ToString().Trim()
        txtRemark.Text = DataGV.Rows(e.RowIndex).Cells(4).Value.ToString().Trim()
        txtQuestionQty.Text = DataGV.Rows(e.RowIndex).Cells(5).Value.ToString().Trim()
        'var dataIndexNo = DataGV.Rows[e.RowIndex].Index.ToString();
        'String cellValue = DataGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        '------------superchai add 20231004 (E)-------------
    End Sub

End Class