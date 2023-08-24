Public Class frmSelQuestionExam

    Public mExamNo As Integer
    Public mTitle As String
    Private dtExamQeustions As DataTable
    Private mQuestionType As String   'provide Text Question Only(Text/Pic)
    Private mExamQty As Integer
    Public mExamType As String

    Private Sub frmSelQuestionExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbQuestionGroup.Items.Add("OPExam")
        cmbQuestionType.Items.Add("Text")     'it need text question only


        'cmbQuestionType.Items.Add("Pic")     
        cmbQuestionGroup.SelectedIndex = 0
        cmbQuestionType.SelectedIndex = 0

        cmbType.Items.Add("Question_Type")
        cmbType.Items.Add("Exercise")
        cmbType.Items.Add("DutyGroup")
        cmbType.Items.Add("Group")

        txtExamNo.Text = mExamNo
        txtTitle.Text = mTitle
        mQuestionType = "Text"
        GrpBoxTextQ.Visible = True
        GrpBoxPicQ.Visible = False

        InitDataGVSelQ(mExamNo, mExamType, "Text")

        mExamQty = 25     ''要求每套题25小题

    End Sub

    Private Sub btnQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuery.Click
        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub
        RefreshQuestionData()

    End Sub

    Private Sub RefreshQuestionData()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "Select  Question_No,Exercise,A,B,C,D,Answer,Question_Group,Question_Type,DutyGroup,[Group] from Exercise_Detail Where Question_Group =N" & sq(cmbQuestionGroup.Text.Trim) & " and [Group]=N" & sq(txtTitle.Text.Trim) & " and  Question_Type=N" & sq(cmbQuestionType.Text.Trim)
        'StrSql = "Select top 100  Question_No,Exercise,A,B,C,D,Answer,Question_Group,Question_Type from Exercise_Detail "
        rst = Conn.Execute(StrSql)

        da.Fill(ds, rst, "ExamQeustions")
        dtExamQeustions = ds.Tables("ExamQeustions")
        DataGVQuestions.DataSource = dtExamQeustions
        DataGVQuestions.Refresh()

    End Sub

    Private Sub DataGVQuestions_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGVQuestions.DoubleClick
        FillTextCtrl(DataGVQuestions, cmbQuestionType.Text.Trim)
    End Sub

    Private Sub DataGVSelQ_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGVSelQ.DoubleClick
        FillTextCtrl(DataGVSelQ, cmbQuestionType.Text.Trim)
    End Sub

    Private Sub FillTextCtrl(ByVal myDataGV As DataGridView, ByVal questionType As String)
        If myDataGV.RowCount > 0 And myDataGV.CurrentRow.Index >= 0 Then
            With myDataGV
                If questionType.ToUpper = "Text".ToUpper Then
                    txtAnswerA.Text = .Item("A", .CurrentRow.Index).Value.ToString()
                    txtAnswerB.Text = .Item("B", .CurrentRow.Index).Value.ToString()
                    txtAnswerC.Text = .Item("C", .CurrentRow.Index).Value.ToString()
                    txtAnswerD.Text = .Item("D", .CurrentRow.Index).Value.ToString()
                    txtExercise.Text = .Item("Exercise", .CurrentRow.Index).Value.ToString()
                    txtCorrectAnswer.Text = .Item("Answer", .CurrentRow.Index).Value.ToString()
                    cmbQuestionNO.Text = .Item("Question_No", .CurrentRow.Index).Value.ToString()
                    cmbQuestionGroup.Text = .Item("Question_Group", .CurrentRow.Index).Value.ToString()
                    cmbQuestionType.Text = .Item("Question_Type", .CurrentRow.Index).Value.ToString()
                    cmbDutyGroup.Text = .Item("DutyGroup", .CurrentRow.Index).Value.ToString()
                Else
                    'txtAnswerA.Text = .Item("A", .CurrentRow.Index).Value.ToString()
                    'txtAnswerB.Text = .Item("B", .CurrentRow.Index).Value.ToString()
                    'txtAnswerC.Text = .Item("C", .CurrentRow.Index).Value.ToString()
                    'txtAnswerD.Text = .Item("D", .CurrentRow.Index).Value.ToString()
                    'txtExercise.Text = .Item("Exercise", .CurrentRow.Index).Value.ToString()
                    'txtCorrectAnswer.Text = .Item("Answer", .CurrentRow.Index).Value.ToString()
                    'cmbQuestionNO.Text = .Item("Question_No", .CurrentRow.Index).Value.ToString()
                    'cmbQuestionGroup.Text = .Item("Question_Group", .CurrentRow.Index).Value.ToString()
                    'cmbQuestionType.Text = .Item("Question_Type", .CurrentRow.Index).Value.ToString()
                End If
            End With
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If ValidData("Add") = False Then Exit Sub
        'Add New Row at first row.
        DataGVSelQ.Rows.Insert(0, 1)

        DataGVSelQ.Item("A", 0).Value = DataGVQuestions.Item("A", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("B", 0).Value = DataGVQuestions.Item("B", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("C", 0).Value = DataGVQuestions.Item("C", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("D", 0).Value = DataGVQuestions.Item("D", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("Exercise", 0).Value = DataGVQuestions.Item("Exercise", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("Answer", 0).Value = DataGVQuestions.Item("Answer", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("Question_No", 0).Value = DataGVQuestions.Item("Question_No", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("Question_Group", 0).Value = DataGVQuestions.Item("Question_Group", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("Question_Type", 0).Value = DataGVQuestions.Item("Question_Type", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVSelQ.Item("DutyGroup", 0).Value = DataGVQuestions.Item("DutyGroup", DataGVQuestions.CurrentRow.Index).Value.ToString()
        DataGVQuestions.Rows.RemoveAt(DataGVQuestions.CurrentRow.Index)
    End Sub

    Private Function ValidData() As Boolean
        ValidData = False
        If cmbQuestionGroup.Text.Trim = "" Or cmbQuestionType.Text.Trim = "" Then
            MsgBox("请首先选择试题组及类型！", MsgBoxStyle.Exclamation, "OP Exam")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Function ValidData(ByVal sType As String) As Boolean
        Dim iRow As Integer
        Dim QNo As Integer
        Dim QGroup As String
        Dim QType As String

        ValidData = False
        If cmbQuestionNO.Text.Trim = "" Or cmbQuestionGroup.Text.Trim = "" Or cmbQuestionType.Text.Trim = "" Then
            MsgBox("请首先点击选择试题！", MsgBoxStyle.Critical, "OP Exam")
            Exit Function
        End If

        If sType = "Add" Then
            If DataGVSelQ.Rows.Count - 1 >= mExamQty Then
                MsgBox("你已经选足题目(每套题" & mExamQty & "小题),请保存设置！", MsgBoxStyle.Exclamation, "OP Exam")
                Exit Function
            End If
            QNo = DataGVQuestions.Item("Question_No", DataGVQuestions.CurrentRow.Index).Value.ToString().Trim
            QGroup = DataGVQuestions.Item("Question_Group", DataGVQuestions.CurrentRow.Index).Value.ToString().Trim
            QType = DataGVQuestions.Item("Question_Type", DataGVQuestions.CurrentRow.Index).Value.ToString().Trim
        Else
            QNo = DataGVSelQ.Item("Question_No", DataGVSelQ.CurrentRow.Index).Value.ToString().Trim
            QGroup = DataGVSelQ.Item("Question_Group", DataGVSelQ.CurrentRow.Index).Value.ToString().Trim
            QType = DataGVSelQ.Item("Question_Type", DataGVSelQ.CurrentRow.Index).Value.ToString().Trim
        End If

        If sType = "Add" Then
            If DataGVSelQ.Rows.Count = 1 Then
                If DataGVSelQ.Item("Question_No", 0).Value Is Nothing Then
                    ValidData = True
                    Exit Function
                End If
            ElseIf DataGVSelQ.Rows.Count < 1 Then
                ValidData = True
                Exit Function
            End If

            '最后一行(DataGVSelQ.Rows.Count - 1) 为*****，不处理
            For iRow = 0 To DataGVSelQ.Rows.Count - 2
                If DataGVSelQ.Item("Question_No", iRow).Value <> Nothing Then
                    If QNo = DataGVSelQ.Item("Question_No", iRow).Value.ToString.Trim And _
                        QGroup = DataGVSelQ.Item("Question_Group", iRow).Value.ToString.Trim And _
                        QType = DataGVSelQ.Item("Question_Type", iRow).Value.ToString.Trim Then

                        MsgBox("该试题已经选中！", MsgBoxStyle.Exclamation, "OP Exam")
                        Exit Function
                    End If
                End If
            Next
        Else
            For iRow = 0 To DataGVSelQ.Rows.Count - 2
                If QNo = DataGVSelQ.Item("Question_No", iRow).Value.ToString.Trim And _
                    QGroup = DataGVSelQ.Item("Question_Group", iRow).Value.ToString.Trim And _
                    QType = DataGVSelQ.Item("Question_Type", iRow).Value.ToString.Trim Then
                    Exit For
                End If
            Next
            If iRow > DataGVSelQ.Rows.Count - 2 Then
                MsgBox("该试题未被选中，无法移除！", MsgBoxStyle.Exclamation, "OP Exam")
                Exit Function
            End If

        End If

        ValidData = True
    End Function

    Private Function ValidData(ByVal examQty As Integer) As Boolean
        ValidData = False
        If DataGVSelQ.Rows.Count - 1 < examQty Then
            MsgBox("你未选足题目(每套题" & examQty & "小题),请继续选题！", MsgBoxStyle.Exclamation, "OP Exam")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If ValidData("Delete") = False Then Exit Sub

        'No need add the row in DataGVQuestions,it can get data by click Query
        'DataGVQuestions.Rows.Add()
        'DataGVQuestions.Item("A", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("A", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("B", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("B", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("C", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("C", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("D", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("D", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("Exercise", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("Exercise", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("Answer", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("Answer", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("Question_No", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("Question_No", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("Question_Group", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("Question_Group", DataGVSelQ.CurrentRow.Index).Value.ToString()
        'DataGVQuestions.Item("Question_Type", DataGVQuestions.Rows.Count - 1).Value = DataGVSelQ.Item("Question_Type", DataGVSelQ.CurrentRow.Index).Value.ToString()

        DataGVSelQ.Rows.RemoveAt(DataGVSelQ.CurrentRow.Index)
    End Sub

    Private Sub cmbQuestionType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuestionType.SelectedIndexChanged
        'it need text question only(有多个QuestionType 时，需要处理此情况)
        If mQuestionType <> cmbQuestionType.Text.Trim And DataGVSelQ.Rows.Count > 0 Then
            If (MsgBox("先保存该类型试题后，再选择另一题型！" & Chr(13) & "请确认是否已保存？", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "OP Exam")) = MsgBoxResult.Yes Then
                mQuestionType = cmbQuestionType.Text.Trim
            Else
                cmbQuestionType.Text = mQuestionType
                Exit Sub
            End If
        Else
            mQuestionType = cmbQuestionType.Text.Trim
        End If

        If mQuestionType = "Text" Then
            GrpBoxTextQ.Visible = True
            GrpBoxPicQ.Visible = False
        Else
            GrpBoxTextQ.Visible = False
            GrpBoxPicQ.Visible = True
        End If
        InitDataGVSelQ(mExamNo, mExamType, mQuestionType)

    End Sub

    Private Sub InitDataGVSelQ(ByVal ExamNo As Integer, ByVal ExamType As String, ByVal QuestionType As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        'StrSql = "Select * from Exercise_Detail Where Question_Group =N" & sq(cmbQuestionGroup.Text.Trim) & " and  Question_Type=N" & sq(cmbQuestionType.Text.Trim)
        StrSql = "exec OP_QryExamContent @ExamNo=" & ExamNo & ",@ExamType=" & sq(ExamType) & ",@QuestionType=" & sq(QuestionType) & ",@Title='',@BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)

        FillDataGV(rst, DataGVSelQ)
        'da.Fill(ds, rst, "ExamContent")
        'DataGVSelQ.DataSource = ds.Tables("ExamContent")
        'DataGVSelQ.Refresh()
    End Sub

    Private Sub FillDataGV(ByVal rst As ADODB.Recordset, ByVal myDataGV As DataGridView)
        Dim iCol As Integer
        'Dim iRow As Integer
        With myDataGV
            .Columns.Clear()
            .Rows.Clear()
            For iCol = 0 To rst.Fields.Count - 1
                .Columns.Add(rst.Fields(iCol).Name.ToString.Trim, rst.Fields(iCol).Name.ToString.Trim)
            Next
            'iRow = 0

            Do While rst.EOF = False
                .Rows.Insert(0, 1)
                For iCol = 0 To rst.Fields.Count - 1
                    .Item(iCol, 0).Value = (rst.Fields(iCol).Value.ToString.Trim)
                Next
                rst.MoveNext()
            Loop

        End With

    End Sub

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim iRow As Integer
        Dim QNo As Integer
        Dim QGroup As String
        Dim QType As String
        Dim DutyGroup As String
        Dim rst As New ADODB.Recordset

        If ValidData(mExamQty) = False Then Exit Sub
         
        '@ActionType varchar(20),@UserID varchar(20), @ExamNo int,@QuestionGroup nvarchar(10),@QuestionType varchar(20),
        StrSql = "exec OP_SetExamContent @ActionType='InsChk',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(cmbQuestionGroup.Text.Trim) & ",@QuestionType=" & sq(mExamType) & ",@DutyGroup=N" & sq(cmbDutyGroup.Text.Trim)
        rst = Conn.Execute(StrSql)
        If ChkSetContentResult(rst, "InsChk") = False Then Exit Sub
        '最后一行(DataGVSelQ.Rows.Count - 1) 为*****，不处理
        For iRow = 0 To DataGVSelQ.Rows.Count - 2
            If DataGVSelQ.Item("Question_No", iRow).Value <> Nothing Then
                QNo = DataGVSelQ.Item("Question_No", iRow).Value.ToString.Trim
                QGroup = DataGVSelQ.Item("Question_Group", iRow).Value.ToString.Trim
                QType = DataGVSelQ.Item("Question_Type", iRow).Value.ToString.Trim
                DutyGroup = DataGVSelQ.Item("DutyGroup", iRow).Value.ToString.Trim
                StrSql = "exec OP_SetExamContent @ActionType='Insert',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(QGroup) & ",@QuestionType=" & sq(QType) & ",@QuestionNo=" & QNo & ",@DutyGroup=N" & sq(DutyGroup)
                rst = Conn.Execute(StrSql)
                If ChkSetContentResult(rst, "Insert") = False Then Exit Sub

            End If

        Next

        StrSql = "exec OP_SetExamContent @ActionType='InsEnd',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(cmbQuestionGroup.Text.Trim) & ",@QuestionType=" & sq(mExamType) & ",@DutyGroup=N" & sq(cmbDutyGroup.Text.Trim)
        rst = Conn.Execute(StrSql)
        If ChkSetContentResult(rst, "InsEnd") = False Then Exit Sub
        MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Information, "OP Exam")

    End Sub

    Private Function ChkSetContentResult(ByVal rst As ADODB.Recordset, ByVal sCallType As String) As Boolean
        ChkSetContentResult = False
        If rst.EOF = False Then
            If rst("Result").Value.ToString.trim <> "0" Then
                MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
                Exit Function
            End If
        Else
            MsgBox(" OP SetExamContent " & sCallType & " fail！", MsgBoxStyle.Critical, "OP Exam")
            Exit Function
        End If

        ChkSetContentResult = True
    End Function


    Private Sub txtFilter_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtFilter.KeyPress
        Dim dtQuestion As DataTable
        If e.KeyChar = Chr(Keys.Enter) And txtFilter.Text.Trim <> "" Then
            dtQuestion = DataFilter(dtExamQeustions, cmbType.Text.Trim, txtFilter.Text.Trim)
            DataGVQuestions.DataSource = dtQuestion
            DataGVQuestions.Refresh()
            txtFilter.Text = ""
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub btnDellAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDellAll.Click
        'Dim iRow As Integer
        'Dim QNo As Integer
        'Dim QGroup As String
        'Dim QType As String
        Dim rst As New ADODB.Recordset

        If MsgBox("确定要删除该试卷科目下所有试题吗！", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "OP Exam") = MsgBoxResult.No Then Exit Sub

        '@ActionType varchar(20),@UserID varchar(20), @ExamNo int,@QuestionGroup nvarchar(10),@QuestionType varchar(20),
        StrSql = "exec OP_SetExamContent @ActionType='Delete',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(cmbQuestionGroup.Text.Trim) & ",@QuestionType=" & sq(mExamType) & ",@DutyGroup=N" & sq(cmbDutyGroup.Text.Trim)
        rst = Conn.Execute(StrSql)
        If ChkSetContentResult(rst, "Del") = False Then Exit Sub
        MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Information, "OP Exam")

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class