Public Class frmOpPracScore

    Dim ExerciseData(200) As PracticeExamData
    Dim A(20) As TextBox
    Dim total As Integer

    Private Sub frmOpPracScore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtTeacher.Text = frmLogin.txtUserName.Text

    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim StrSQL As String
        Dim rst As New ADODB.Recordset
        Dim StartTime As String
        Dim EndTime As String

        StartTime = Me.dtpSDate.Value.ToString("yyyyMMdd")
        EndTime = Me.dtpEDate.Value.ToString("yyyyMMdd")

        StrSQL = "OP_QryExamPractice  " & sq(txtTeacher.Text) & "," & sq(P_BU) '0001
        rs = Conn.Execute(StrSQL)
        If rs.EOF = True Then
            MsgBox("请检查是否有考试安排！", MsgBoxStyle.Exclamation, "Practice Exam")
            Exit Sub
        End If
        While rs.EOF = False
            cmbTestNo.Items.Add(rs.Fields("ID").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmbExamNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbExamNo.SelectedIndexChanged
        Dim StrSQL As String
        If cmbTestNo.Text.Trim <> "" And cmbExamNo.Text.Trim <> "" Then
            StrSQL = "select Question_Type ,Title ,Station ,Category  from OP_ExamSubject a,OP_ExamSchedule b where a.Exam_NO =b.Exam_No and a.bu=b.bu and a.Exam_NO = " & sq(cmbExamNo.Text.Trim) & " and b.ID=" & sq(cmbTestNo.Text.Trim) & " and A.bu=" & sq(P_BU)  '0001
            rs = Conn.Execute(StrSQL)
            If rs.EOF = True Then Exit Sub
            txtexamtype.Text = rs.Fields("Question_Type").Value
            TxtTitle.Text = rs.Fields("Title").Value
            txtModel.Text = rs.Fields("Category").Value
            txtStation.Text = rs.Fields("Station").Value
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub CmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdStart.Click
        Dim StrSQL As String
        Dim ds As New DataSet
        Dim dtExamTester As DataTable
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        If cmbExamNo.Text.Trim() = "" Then
            MsgBox("考试编号不能为空！！！", MsgBoxStyle.Exclamation, "Practice Exam")
            Exit Sub
        End If

        '(0002)
        StrSQL = "select 0  from OP_ExamSchedule where ID =" & sq(cmbTestNo.Text.Trim) & " and Exam_NO = " & sq(cmbExamNo.Text.Trim) & "   and BU=" & sq(P_BU)
        rs = Conn.Execute(StrSQL)
        If rs.EOF = True Then
            MsgBox("请检查考试编号和试卷编号，它们不存在或者不匹配！", MsgBoxStyle.Exclamation, "Practice Exam")
            Exit Sub
        End If
        '(0002)

        StrSQL = "select ExamScheduleID ,EmployeeID ,EmployeeName  from OP_ExamOperator where ExamScheduleID =" & sq(cmbTestNo.Text.Trim) & " and BU=" & sq(P_BU) '0001
        rs = Conn.Execute(StrSQL)
        If rs.EOF = True Then Exit Sub
        da.Fill(ds, rs, "ExamTester")
        dtExamTester = ds.Tables("ExamTester")
        DataGVTester.DataSource = dtExamTester

        cmbTestNo.Enabled = False
        cmbExamNo.Enabled = False


    End Sub

    Private Sub DataGV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGVTester.DoubleClick
        FillTextCtrl(DataGVTester)
    End Sub
    Private Sub FillTextCtrl(ByVal DataGV As DataGridView)
        Dim StrSQL As String
        Dim i As Integer, j As Integer
        i = 1
        Me.PanelContent.Controls.Clear()
        If DataGV.RowCount > 0 And DataGV.CurrentRow.Index >= 0 Then
            With DataGV
                txtTester.Text = .Item("EmployeeID", .CurrentRow.Index).Value.ToString()
                txtName.Text = .Item("EmployeeName", .CurrentRow.Index).Value.ToString()
            End With
        End If
        StrSQL = "exec OP_QryPracDetail" & sq(cmbExamNo.Text.Trim) & "," & sq(txtTester.Text.Trim) & "," & sq(cmbTestNo.Text.Trim) & "," & sq(P_BU) '0001
        rs = Conn.Execute(StrSQL)
        If rs.EOF = True Then Exit Sub
        j = 10
        While rs.EOF = False
            Dim FirstLabel As New Label             '定义文本框对象
            Dim FirstTextBox As New TextBox            '定义文本框对象

            Me.PanelContent.Controls.Add(FirstLabel)
            Me.PanelContent.Controls.Add(FirstTextBox)
            FirstLabel.Tag = rs.Fields("SubID").Value & "、" & rs.Fields("SubItem").Value
            FirstLabel.Text = rs.Fields("SubID").Value & "、" & rs.Fields("SubItem").Value
            FirstTextBox.Text = rs.Fields("Score").Value
            ExerciseData(i).Question = FirstLabel.Text
            ExerciseData(i).MaxScore = rs.Fields("RateScore").Value
            A(i) = FirstTextBox
            ExerciseData(i).Score = FirstTextBox.Name
            FirstLabel.Height = 20
            FirstLabel.Width = 300
            FirstLabel.Top = j
            FirstLabel.Left = 10        
            FirstTextBox.Left = 320
            FirstTextBox.Top = j
            j = j + 30
            i = i + 1
            rs.MoveNext()
        End While
        total = i
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim StrSQL As String
        Dim rst As New ADODB.Recordset
        Dim TransDateTime As String, TotalScore As Integer
        Dim i As Integer
        Dim j As Integer

        'superchai add 20231102 (B)
        StrSQL = "exec OP_QryCheckTheoryAndPictureByPractice" & sq(cmbTestNo.Text.Trim) & "" '0001
        rst = Conn.Execute(StrSQL)
        If rst.Fields("Result").Value <> "OK" Then
            'MsgBox("该EmployeeID已经评过分数了！", MsgBoxStyle.Exclamation, "Practice Exam")
            MsgBox("The scheduleID: " & cmbTestNo.Text.Trim & ".There are subjects that employees have not yet taken or passed. Please pass all subject tests first !!", MsgBoxStyle.Critical, "Practice Exam")
            Exit Sub
        End If
        'superchai add 20231102 (E)

        StrSQL = "Select  dbo.FormatDate(GETDATE(),'YYYYMMDDHHNNSS') as TransDateTime"
        rst = Conn.Execute(StrSQL)
        TransDateTime = rst.Fields("TransDateTime").Value
        i = 1
        j = 1
        TotalScore = 0
        For j = 1 To total - 1
            If A(j).Text = "" Then
                'MsgBox("必须全部给予评分，请检查！", MsgBoxStyle.Exclamation, "Practice Exam")
                MsgBox("All must be rated, please check!", MsgBoxStyle.Exclamation, "Practice Exam")
                Exit Sub
            End If
            ExerciseData(j).Score = A(j).Text
            If Int(ExerciseData(j).Score) > Int(ExerciseData(j).MaxScore) Then
                'MsgBox("所得分数大于定义的分数了，请检查！", MsgBoxStyle.Exclamation, "Practice Exam")
                MsgBox("The obtained score is greater than the defined score, please check!", MsgBoxStyle.Exclamation, "Practice Exam")
                Exit Sub
            End If
            TotalScore = TotalScore + ExerciseData(j).Score
        Next j
        '(1002)
        If txtTester.Text = "" Or txtName.Text = "" Then
            'MsgBox("保存数据时考生工号姓名都不可为空，请检查！", MsgBoxStyle.Exclamation, "Practice Exam")
            MsgBox("When saving data, the candidate's work number and name cannot be empty, please check!", MsgBoxStyle.Exclamation, "Practice Exam")
            Exit Sub
        End If
        '(1002)
        StrSQL = "exec OP_QryCheckPractice" & sq(cmbExamNo.Text.Trim) & "," & sq(txtTester.Text) & "," & sq(cmbTestNo.Text.Trim) & "," & sq(P_BU) & "" '0001
        rst = Conn.Execute(StrSQL)
        If rst.Fields("Result").Value <> "PASS" Then
            'MsgBox("该EmployeeID已经评过分数了！", MsgBoxStyle.Exclamation, "Practice Exam")
            MsgBox("This EmployeeID has already been scored!", MsgBoxStyle.Exclamation, "Practice Exam")
            Exit Sub
        End If

        StrSQL = "select SubID ,SubItem  from OP_PracticeDetail   where Exam_NO =" & sq(cmbExamNo.Text.Trim) & " and BU=" & sq(P_BU) & ""
        rst = Conn.Execute(StrSQL)
        If rst.EOF = True Then Exit Sub
        While i < total
            StrSQL = "insert into OP_PracScore (ScheduleID ,EmployeeID ,EmployeeName ,ExamScheduleID ,SubID ,SubItem ,Score ,UserID ,TransDT,BU ) select  " & sq(cmbTestNo.Text.Trim) & "," & sq(txtTester.Text) & ",N" & sq(txtName.Text) & ", " & sq(cmbExamNo.Text.Trim) & ",'" & i & "',N'" & ExerciseData(i).Question & "' ," & ExerciseData(i).Score & "," & sq(txtTeacher.Text) & "," & sq(TransDateTime) & "," & sq(P_BU) & "" '0001
            rs = Conn.Execute(StrSQL)
            i = i + 1
        End While
        'StrSQL = "exec OP_SavePracResult" & sq(txtTester.Text) & ",N" & sq(txtName.Text) & "," & sq(cmbTestNo.Text.Trim) & "," & sq(cmbExamNo.Text.Trim) & "," & TotalScore & "," & sq(P_BU) '0001
        StrSQL = "exec OP_SavePracResult_Test" & sq(txtTester.Text) & ",N" & sq(txtName.Text) & "," & sq(cmbTestNo.Text.Trim) & "," & sq(cmbExamNo.Text.Trim) & "," & TotalScore & "," & sq(P_BU) '0001
        rst = Conn.Execute(StrSQL)
        'MsgBox("数据保存OK！注：该考试编号的考生成绩全部维护完之后请点击刷新", MsgBoxStyle.Exclamation, "Practice Exam")
        MsgBox("Data saving OK! Note: Please click Refresh after all candidates’ scores for this exam number have been maintained.", MsgBoxStyle.Exclamation, "Practice Exam")

    End Sub


    Private Sub cmbTestNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTestNo.SelectedIndexChanged
        StrSql = " select distinct Exam_NO   from OP_PracticeDetail where Exam_NO in( select Exam_No  from OP_ExamSchedule  where  ID =" & sq(cmbTestNo.Text.Trim) & ") and BU=" & sq(P_BU) & "" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbExamNo.Items.Add(rs.Fields("Exam_NO").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdrefresh_Click(sender As Object, e As EventArgs) Handles cmdrefresh.Click
        cmbTestNo.Enabled = True
        cmbExamNo.Enabled = True
        txtTester.Text = ""
        txtName.Text = ""
        DataGVTester.DataSource = ""
    End Sub
End Class