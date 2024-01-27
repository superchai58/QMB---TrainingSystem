Public Class frmSetQuestions
    Public mActionType As String      ''Exam/PreView
    Public Exam_NO As Integer
    Public Question_Group As String

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

    'Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    '    Dim rst As New ADODB.Recordset
    '    If ValidData() = False Then Exit Sub
    '    'Request 4 Warinya 20230825
    '    'If cmbQuestionType.Text = "Theory_Auto" Then
    '    '    MsgBox("理论题在上传试理论题库时自动添加了试卷的！", MsgBoxStyle.Information, "OP Exam")
    '    '    Return
    '    'End If
    '    'StrSql = "Exec OP_SetQuestions  'Insert'," & sq(P_UserName) & ",-1, N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
    '    '       sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU)  '0001 

    '    StrSql = "Exec OP_SetQuestions  'Update'," & sq(P_UserName) & "," & txtExamNo.Text.Trim & ",N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
    '           sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU)  '0001
    '    'Request 4 Warinya 20230825

    '    rst = Conn.Execute(StrSql)
    '    If rst.EOF = False Then
    '        MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
    '        If rst.Fields("result").Value = 0 Then
    '            RefreshData()
    '        End If

    '    Else
    '        MsgBox("新增试题失败！", MsgBoxStyle.Information, "OP Exam")

    '    End If


    'End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If txtExamNo.Text.Trim = "" Then Exit Sub

        If MsgBox("确定要删除吗！", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "OP Exam") = MsgBoxResult.No Then Exit Sub

        'StrSql = "Exec OP_SetQuestions  @ActionType='Delete',@UserID=" & sq(P_UserName) & ",@ExamNo=" & txtExamNo.Text.Trim & ",@BU=" & sq(P_BU)  '0001
        StrSql = "Exec OP_SetQuestions_TEST  @ActionType='Delete',@UserID=" & sq(P_UserName) & ",@ExamNo=" & txtExamNo.Text.Trim & ",@BU=" & sq(P_BU) & ", @Comments=" & txtComments.Text.Trim & ", ''"  '0001
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

    Private Sub cmdUpdate_Click_1(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub
        'Request 4 Warinya 20230825
        'If cmbQuestionType.Text = "Theory_Auto" Then
        '    MsgBox("理论题在上传试理论题库时自动添加了试卷的！", MsgBoxStyle.Information, "OP Exam")
        '    Return
        'End If
        'StrSql = "Exec OP_SetQuestions  'Insert'," & sq(P_UserName) & ",-1, N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
        '       sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU)  '0001 

        'StrSql = "Exec OP_SetQuestions  'Update'," & sq(P_UserName) & "," & txtExamNo.Text.Trim & ",N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
        '       sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU) & "," & txtComments.Text.Trim  '0001
        StrSql = "Exec OP_SetQuestions_TEST  'Update'," & sq(P_UserName) & "," & txtExamNo.Text.Trim & ",N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
               sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU) & "," & txtComments.Text.Trim & ", ''"  '0001
        'Request 4 Warinya 20230825

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

    Private Sub cmdFile_Click(sender As Object, e As EventArgs) Handles cmdFile.Click
        Dim i As Integer
        On Error GoTo errhnd
        OpenFileDialog1.ShowDialog()
        txtFileName.Text = OpenFileDialog1.FileName
        If UCase(Mid(txtFileName.Text.Trim, Len(txtFileName.Text.Trim) - 3, 4)) <> ".XLS" Then
            'MsgBox("文件类型不正确，请选择表格文件XLS", MsgBoxStyle.Critical, "Error")
            MsgBox("Incorrect file type, please select table file XLS", MsgBoxStyle.Critical, "Error")
            txtFileName.Text = ""
            Exit Sub
        End If
        ExcelGlobal_definst.Workbooks.Open(txtFileName.Text.Trim)
        ExcelGlobal_definst.Worksheets(1).activate()
        cmbSheet.Items.Clear()
        i = 0
        Do
            cmbSheet.Items.Add(ExcelGlobal_definst.ActiveSheet.name)
            If ExcelGlobal_definst.ActiveSheet.next Is Nothing Then Exit Do
            ExcelGlobal_definst.ActiveSheet.next.select()
            i = i + 1
        Loop
NoData:
        ExcelGlobal_definst.Workbooks.Close()
        GoTo Pass
        Exit Sub
errhnd:
        If Err.Number = 91 Then
            GoTo NoData
        End If
Pass:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Cmd_Load_Click(sender As Object, e As EventArgs) Handles Cmd_Load.Click
        If txtFileName.Text.Trim = "" Or cmbSheet.Text.Trim = "" Or cmbFunGroup.Text.Trim = "" Then
            'MsgBox("请选择要导入的文件,页面和组别", MsgBoxStyle.Critical, "Error")
            MsgBox("Please select the files, pages and groups to import.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Select Case cmbFunGroup.Text.Trim
            Case "Theory"
                Call UploadExerciseDataHearder(txtFileName.Text.Trim, "Header")
                Call UploadExerciseDataDetail(txtFileName.Text.Trim, "Detail")
                'MsgBox("试题上传成功", MsgBoxStyle.Information, "Training")
                'MsgBox("Test questions uploaded successfully.", MsgBoxStyle.Information, "Training")
            Case Else

                'MsgBox("�����ϴ��ɹ�", MsgBoxStyle.Information, "Training")
                MsgBox("Not support error type" + cmbFunGroup.Text.Trim, MsgBoxStyle.Information, "Training")
        End Select
    End Sub

    Private Sub UploadExerciseDataHearder(ByVal FileName As String, ByVal SheetName As String)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim rst As New ADODB.Recordset

        Dim i As Integer
        Dim chkResult As Integer
        Dim message As String

        'Dim Exam_NO As Integer
        Exam_NO = 0
        'Dim Question_Group As String
        Question_Group = ""
        Dim Question_Type As String
        Dim Title As String
        Dim Remark As String
        Dim QuestionQty As Integer

        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet

        i = 2
        If xlapp.Cells(i, 1).value >= 1 Then
            Exam_NO = xlapp.Cells(i, 1).value
            Question_Group = xlapp.Cells(i, 2).value
            Question_Type = xlapp.Cells(i, 3).value
            Title = xlapp.Cells(i, 4).value
            Remark = xlapp.Cells(i, 5).value
            QuestionQty = xlapp.Cells(i, 6).value

            'Request 4 Warinya 20230825
            'If cmbQuestionType.Text = "Theory_Auto" Then
            '    MsgBox("理论题在上传试理论题库时自动添加了试卷的！", MsgBoxStyle.Information, "OP Exam")
            '    Return
            'End If
            'StrSql = "Exec OP_SetQuestions  'Insert'," & sq(P_UserName) & ",-1, N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & ",N" &
            '       sq(txtTitle.Text.Trim) & ",N" & sq(txtRemark.Text.Trim) & "," & sq(P_BU)  '0001 

            'StrSql = "Exec OP_SetQuestions  'Update'," & sq(P_UserName) & ",'" & Exam_NO & "',N'" & Question_Group & "',N'" & Question_Type & "',N'" &
            '   Title & "',N'" & Remark & "'," & sq(P_BU) & ""  '0001      'superchai add 20231006

            '--superchai add 20231021 (B)
            If TStation.ToUpper() = "TRAINING" Then
                StrSql = "Exec OP_SetQuestions_TEST  'Insert'," & sq(P_UserName) & ",'" & Exam_NO & "',N'" & Question_Group & "',N'" & Question_Type & "',N'" &
               Title & "',N'" & Remark & "'," & sq(P_BU) & ",N'" & txtComments.Text.Trim & "', 'OP'"  '0001      'superchai add 20231006
            Else
                StrSql = "Exec OP_SetQuestions_TEST  'Insert'," & sq(P_UserName) & ",'" & Exam_NO & "',N'" & Question_Group & "',N'" & Question_Type & "',N'" &
               Title & "',N'" & Remark & "'," & sq(P_BU) & ",N'" & txtComments.Text.Trim & "', 'IDL'"  '0001      'superchai add 20231006
            End If
            '--superchai add 20231021 (E)

            'StrSql = "Exec OP_SetQuestions_TEST  'Insert'," & sq(P_UserName) & ",'" & Exam_NO & "',N'" & Question_Group & "',N'" & Question_Type & "',N'" &
            '   Title & "',N'" & Remark & "'," & sq(P_BU) & ",N'" & txtComments.Text.Trim & "'"  '0001      'superchai add 20231006


            'Request 4 Warinya 20230825

            rst = Conn.Execute(StrSql)
            If rst.EOF = False Then
                chkResult = 1
                message = rst.Fields("Description").Value
                'MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
                'If rst.Fields("result").Value = 0 Then
                '    RefreshData()
                'End If

            Else
                chkResult = 0
                'MsgBox("新增试题失败！", MsgBoxStyle.Information, "OP Exam")

            End If

            'i = i + 1
        End If

        If chkResult = 1 Then
            MsgBox(message.Trim(), MsgBoxStyle.Information, "OP Exam")
        Else
            MsgBox("Failed to add test question！", MsgBoxStyle.Critical, "OP Exam")
        End If

        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()
    End Sub

    Private Sub UploadExerciseDataDetail(ByVal FileName As String, ByVal SheetName As String)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim rst As New ADODB.Recordset
        Dim i As Integer

        '编号  分值	实作子项
        Dim SN As String
        Dim Point As String
        Dim ImplementationChild As String

        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet

        i = 2
        While xlapp.Cells(i, 1).value >= 1
            Dim ItemList As String

            SN = xlapp.Cells(i, 1).value.ToString().Trim()
            Point = xlapp.Cells(i, 2).value.ToString().Trim()
            ImplementationChild = xlapp.Cells(i, 3).value.ToString().Trim()

            'If ValidData() = False Then Exit Sub
            ItemList = SN & "," & Point & "," & ImplementationChild

            StrSql = "exec OP_SetExamPractice @ActionType='Insert',@UserID= " & sq(P_UserName) & ",@ExamNo=" & Exam_NO & ",@QuestionGroup=" & Question_Group & ",@ItemList=N" & sq(ItemList) & ",@BU=" & sq(P_BU)
            rst = Conn.Execute(StrSql)
            If rst.EOF = False Then
                If rst("Result").Value.ToString.Trim <> "0" Then
                    MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
                    Exit Sub
                End If
            Else
                MsgBox(" OP SetExamContent Ins fail！", MsgBoxStyle.Critical, "OP Exam")
                Exit Sub
            End If

            i = i + 1
        End While
        MsgBox("Saved successfully！", MsgBoxStyle.Information, "OP Exam")

        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()

        txtFileName.Text = ""
        cmbSheet.Text = ""
        cmbFunGroup.Text = ""
        txtComments.Text = ""
    End Sub
End Class

