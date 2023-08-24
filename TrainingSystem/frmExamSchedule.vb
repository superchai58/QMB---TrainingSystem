Public Class frmExamSchedule

    Private Sub frmExamSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rst As New ADODB.Recordset
       
        StrSql = "select distinct Question_Type  from OP_ExamSubject where BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamType.Items.Add(rst.Fields("Question_Type").Value.ToString())
                rst.MoveNext()
            End While
        End If

        StrSql = "select distinct ID  from OP_ExamSchedule where BU=" & sq(P_BU) & " order by ID  desc"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboScheduleID.Items.Add(rst.Fields("ID").Value.ToString())
                rst.MoveNext()
            End While
        End If
        cmdAdd.Enabled = False
        cmdEnd.Enabled = False
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        RefreshData(Me.cboScheduleID.Text.Trim)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rst As New ADODB.Recordset
        Dim StartTime As String
        Dim EndTime As String

        StartTime = Me.dtpStart.Value.ToString("yyyyMMdd")
        EndTime = Me.dtpEnd.Value.ToString("yyyyMMdd")
        If ValidData() = False Then Exit Sub

        StrSql = "Exec OP_SetSchedule  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & "," & _
            sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ""
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData("")
            End If

        Else
            MsgBox("新增考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        End If

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If cboScheduleID.Text.Trim = "" Then Exit Sub

        StrSql = "Exec OP_SetSchedule  'Delete'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," & _
            sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData("")
            End If
        Else
            MsgBox("删除考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        End If

    End Sub

    Private Function ValidData() As Boolean
        Dim StartTime As String
        Dim EndTime As String

        ValidData = False

        StartTime = Me.dtpStart.Value.ToString("yyyyMMdd")
        EndTime = Me.dtpEnd.Value.ToString("yyyyMMdd")

        If StartTime.ToString >= EndTime.ToString Then
            MsgBox("请设置正确的考试计划有效时间！", MsgBoxStyle.Information, "Error")
            Exit Function
        End If
        If cboScheduleID.Text.Trim = "" Then
            MsgBox("请首先选择考试编号！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cboExamType.Text.Trim = "" Then
            MsgBox("请首先选择试卷类型！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cboExamNo.Text.Trim = "" Then
            MsgBox("请首先选择试卷编号！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        If txtStation.Text.Trim = "" Then
            MsgBox("请输入Station！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        If txtTeacher.Text.Trim = "" Then
            MsgBox("请输入讲师！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Sub RefreshData(ByVal strExamScheduleID As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "Exec OP_GetExamScheduleInfo " & sq(strExamScheduleID) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamScheduleInfo")
            DataGV.DataSource = ds.Tables("ExamScheduleInfo")
            DataGV.Refresh()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdEnd.Enabled = True Then
            MsgBox("请先点击End", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub cboExamType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExamType.SelectedIndexChanged
        Dim rst As New ADODB.Recordset
        cboExamNo.Items.Clear()
        cboExamNo.Text = ""
        '-----------superchai add 20230824 (B)-------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " AND Title LIKE 'OP%' order by Exam_No"
        Else
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " AND Title LIKE 'IDL%' order by Exam_No"
        End If
        '-----------superchai add 20230824 (E)-------------

        'StrSql = "select * from OP_ExamSubject where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " order by Exam_No"       superchai commnents
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamNo.Items.Add(rst.Fields("Title").Value.ToString() + "-->" + rst.Fields("Exam_No").Value.ToString())
                rst.MoveNext()
            End While
        End If

        '-----------superchai test (B)------------
        'StrSql = "select " & "'" & TStation.ToUpper() & "'"
        'rst = Conn.Execute(StrSql)
        '-----------superchai test (E)------------
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Dim rst As New ADODB.Recordset
        Dim MaxID As String
        MaxID = 1
        StrSql = "select isnull(Max(ID),0) as MaxID  from OP_ExamSchedule where BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MaxID = rst.Fields("MaxID").Value.ToString()
            MaxID = CInt(MaxID) + 1
        End If
        '    If MaxID = "" Then
        'MaxID = "1"
        'End If
        cboScheduleID.Items.Add(MaxID)
        cmdAdd.Enabled = True
        cmdDelete.Enabled = False
        cmdExit.Enabled = False
        cmdEnd.Enabled = True
        cmdQuery.Enabled = False
        cmdStart.Enabled = False
        MsgBox("请Add之后记得要End方能生效！", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        Dim rst As New ADODB.Recordset
        cmdAdd.Enabled = False
        cmdDelete.Enabled = True
        cmdExit.Enabled = True
        cmdEnd.Enabled = False
        cmdQuery.Enabled = True
        cmdStart.Enabled = True

        StrSql = "Exec OP_SetSchedule  'End'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," & _
            sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & " ," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
    End Sub

    Private Sub DataGV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGV.DoubleClick
        FillTextCtrl(DataGV)
    End Sub
    Private Sub FillTextCtrl(ByVal DataGV As DataGridView)
        If DataGV.RowCount > 0 And DataGV.CurrentRow.Index >= 0 Then
            With DataGV
                cboScheduleID.Text = .Item("ID", .CurrentRow.Index).Value.ToString()
                cboExamType.Text = .Item("Question_type", .CurrentRow.Index).Value.ToString()
                cboExamNo.Text = .Item("Exam_No", .CurrentRow.Index).Value.ToString() + "-->"
                txtStation.Text = .Item("Station", .CurrentRow.Index).Value.ToString()
                txtModel.Text = .Item("Category", .CurrentRow.Index).Value.ToString()
                txtTeacher.Text = .Item("Teacher", .CurrentRow.Index).Value.ToString()
            End With
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboScheduleID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScheduleID.SelectedIndexChanged

    End Sub
End Class

