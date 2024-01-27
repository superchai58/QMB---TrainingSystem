Public Class frmExamResultUpdate

    Private Sub frmUploadExamResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Dim rst As New ADODB.Recordset
        'StrSql = "select distinct ID from OP_ExamSchedule where  dbo.FormatDate(GETDATE(),'YYYYMMDD') between StartDate and EndDate and BU ='" & P_BU & "' "
        'rst = Conn.Execute(StrSql)
        'If rst.EOF = False Then
        '    While Not rst.EOF
        '        cboExamScheduleID.Items.Add(rst.Fields("ID").Value.ToString())
        '        rst.MoveNext()
        '    End While
        'End If
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        RefreshData(Trim(Me.txtEmployeeID.Text.ToString()))
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StrSql As String
        If ValidData() = False Then Exit Sub

        If DataGV.Columns.Count < 3 Then
            MsgBox("請檢查成績", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrSql = "Exec UpdateExerciseResult"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                'RefreshData(txtEmployeeID.Text.Trim)
                StrSql = "exec OP_GetExerciseResultTemp @BU=" & sq(P_BU) & ""
                rst = Conn.Execute(StrSql)
                da.Fill(ds, rst, "ExerciseResultTemp")
                DataGV.DataSource = ds.Tables("ExerciseResultTemp")

                StrSql = "exec OP_QryExerciseResult"
                rst = Conn.Execute(StrSql)
                da.Fill(ds, rst, "ExerciseResult")
                DataGV2.DataSource = ds.Tables("ExerciseResult")
            End If
        Else
            MsgBox("新增員工考試計劃失敗！", MsgBoxStyle.Information, "OP Exam")
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        Dim strExamOperator As String = txtEmployeeID.Text.Trim
        Dim StrSql As String
        Dim b As Boolean = UCase(strExamOperator).Contains(".XLS")
        If txtEmployeeID.Text.Trim <> "" AndAlso Not b Then

            StrSql = "select distinct [UserID],[UserName],[Group],[DeptGroup],[DutyGroup],CONVERT(varchar,[StartDateTime], 121) as StartDateTime,CONVERT(varchar,[EndDateTime], 121) as EndDateTime,[Score],[Grade],[TestType],[BU],[Title] from Exercise_Result (nolock) where BU =" & sq(P_BU) & " and  UserID like N'%" + strExamOperator + "%' and  DeptGroup like N'%" + ExamScheduleID.Text.Trim + "%' and  Title like N'%" + txtTitle.Text.Trim + "%'  order by UserID "
        Else

            StrSql = "select distinct [UserID],[UserName],[Group],[DeptGroup],[DutyGroup],CONVERT(varchar,[StartDateTime], 121) as StartDateTime,CONVERT(varchar,[EndDateTime], 121) as EndDateTime,[Score],[Grade],[TestType],[BU],[Title] from Exercise_Result (nolock) where BU =" & sq(P_BU) & " and  DeptGroup like N'%" + ExamScheduleID.Text.Trim + "%' and  Title like N'%" + txtTitle.Text.Trim + "%' order by UserID "
        End If

        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            Call CopyToExcel(rs)
        Else
            MsgBox("没有考试人员信息！", MsgBoxStyle.Information, "OP Exam")
        End If

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Function ValidData() As Boolean
        Dim rst As New ADODB.Recordset
        ValidData = False
        If txtEmployeeID.Text.Trim = "" Then
            MsgBox("請上傳文檔並點擊檢查工號！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        ValidData = True
    End Function

    Private Sub RefreshData(ByVal strExamOperator As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StrSql As String
        Dim b As Boolean = UCase(strExamOperator).Contains(".XLS")
        If strExamOperator <> "" AndAlso Not b Then
            StrSql = "select distinct * from Exercise_Result (nolock) where BU=" & sq(P_BU) & " and  UserID like N'%" + strExamOperator + "%' and  DeptGroup like N'%" + ExamScheduleID.Text.Trim + "%' and  Title like N'%" + txtTitle.Text.Trim + "%'  order by UserID"
        Else
            StrSql = "select distinct * from Exercise_Result (nolock) where BU=" & sq(P_BU) & " and  DeptGroup like N'%" + ExamScheduleID.Text.Trim + "%' and  Title like N'%" + txtTitle.Text.Trim + "%' order by UserID"
        End If
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExerciseResult")
            DataGV2.DataSource = ds.Tables("ExerciseResult")
            DataGV2.Refresh()
        Else
            MsgBox("這個計劃沒有考試人員！", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub UpLoadRefresh()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StrSql As String

        StrSql = "select distinct UserID,UserName from Exercise_Result_temp (nolock) where BU =" & sq(P_BU) & ""
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "Exercise_Result_temp")
            DataGV.DataSource = ds.Tables("Exercise_Result_temp")
            DataGV.Refresh()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub
        'StrSql = "Exec OP_SetOperator 'Delete'," & sq(cboExamScheduleID.Text.Trim) & ",N" & sq(txtTitle.Text.Trim) & ",''," & sq(P_UserName) & "," & sq(P_BU)
        'rst = Conn.Execute(StrSql)
        'If rst.EOF = False Then
        '    MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
        '    If rst.Fields("result").Value = 0 Then
        '        RefreshData(txtEmployeeID.Text.Trim, cboExamScheduleID.Text.Trim)
        '    End If
        'Else
        '    MsgBox("删除员工考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        'End If
    End Sub


    Private Sub cmbCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheck.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StrSql As String

        If DataGV.RowCount < 2 Then
            MsgBox("請上傳需要更新或是新增的成績", MsgBoxStyle.Critical)
            Exit Sub
        End If

        StrSql = "exec OP_CheckExerciseResult @BU=" & sq(P_BU) & ""
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            If rst.Fields("result").Value = 1 Then
                MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            Else
                StrSql = "exec OP_GetExerciseResultTemp @BU=" & sq(P_BU) & ""
                rst = Conn.Execute(StrSql)
                da.Fill(ds, rst, "ExerciseResultTemp")
                DataGV.DataSource = ds.Tables("ExerciseResultTemp")

                StrSql = "exec OP_QryExerciseResult"
                rst = Conn.Execute(StrSql)
                da.Fill(ds, rst, "ExerciseResult")
                DataGV2.DataSource = ds.Tables("ExerciseResult")
            End If
        Else
            MsgBox("请检查！", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub cmdFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile.Click
        Dim i As Integer
        On Error GoTo errhnd
        OpenFileDialog1.ShowDialog()
        txtEmployeeID.Text = OpenFileDialog1.FileName
        If txtEmployeeID.Text.Trim <> "" AndAlso UCase(Mid(txtEmployeeID.Text.Trim, Len(txtEmployeeID.Text.Trim) - 3, 4)) <> ".XLS" Then
            MsgBox("文件類型不正確，請選擇表格文件 ", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        ExcelGlobal_definst.Workbooks.Open(txtEmployeeID.Text.Trim)
        ExcelGlobal_definst.Worksheets(1).activate()
        cboSheet.Items.Clear()
        i = 0
        Do
            cboSheet.Items.Add(ExcelGlobal_definst.ActiveSheet.name)
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

    Private Sub Cmd_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Load.Click
        If txtEmployeeID.Text.ToString() = "" Then
            MsgBox("請選擇要上傳的文件", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Trim(cboSheet.Text.ToString() = "") Then
            MsgBox("請選擇要上傳的頁面", MsgBoxStyle.Critical)
            Exit Sub
        End If

        Call UploadExamOperator(txtEmployeeID.Text.Trim, cboSheet.Text.Trim)
        Call UpLoadRefresh()
    End Sub

    Private Sub UploadExamOperator(ByVal FileName As String, ByVal SheetName As String)
        Dim rst As New ADODB.Recordset
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim i
        Dim UserID As String
        Dim UserName As String
        Dim DeptGroup As String
        Dim DutyGroup As String
        Dim Score As String
        Dim TestType As String
        Dim StrSql As String
        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet
        '開始讀取
        UserID = xlapp.Cells(2, 1).value
        UserName = xlapp.Cells(2, 2).value
        DeptGroup = xlapp.Cells(2, 3).value
        DutyGroup = xlapp.Cells(2, 4).value
        Score = xlapp.Cells(2, 5).value
        TestType = xlapp.Cells(2, 6).value
        i = 2
        StrSql = "truncate table Exercise_Result_temp"
        Conn.Execute(StrSql)

        While UserID <> ""
            StrSql = "exec UpdateExerciseResultTemp @UserID=" & sq(UserID) & " ,@UserName=N" & sq(UserName) & " ,@DeptGroup=" & sq(DeptGroup) & " ,@DutyGroup=" & sq(DutyGroup) & " ,@Score=" & sq(Score) & " ,@TestType=N" & sq(TestType) & ""
            rst = Conn.Execute(StrSql)

            If rst.EOF = False And rst.Fields("result").Value = 0 Then
                i = i + 1
                UserID = xlapp.Cells(i, 1).value
                UserName = xlapp.Cells(i, 2).value
                DeptGroup = xlapp.Cells(i, 3).value
                DutyGroup = xlapp.Cells(i, 4).value
                Score = xlapp.Cells(i, 5).value
                TestType = xlapp.Cells(i, 6).value
            Else
                MsgBox(rst.Fields("Desc").Value, MsgBoxStyle.Critical)
                StrSql = "truncate table Exercise_Result_temp"
                rst = Conn.Execute(StrSql)
                xlWs = Nothing
                xlsbook.Close()
                xlapp.Quit()
                Exit Sub
            End If
        End While
        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()
    End Sub

End Class