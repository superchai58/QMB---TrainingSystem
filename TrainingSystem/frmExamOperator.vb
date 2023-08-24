Public Class frmExamOperator

    Private Sub frmExamOperator_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rst As New ADODB.Recordset
        StrSql = "select distinct ID    from OP_ExamSchedule where  dbo.FormatDate(GETDATE(),'YYYYMMDD') between StartDate and EndDate and BU ='" & P_BU & "' "
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamScheduleID.Items.Add(rst.Fields("ID").Value.ToString())
                rst.MoveNext()
            End While
        End If
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        RefreshData(Trim(Me.txtEmployeeID.Text.ToString()), cboExamScheduleID.Text.ToString())
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub

        StrSql = "Exec OP_SetOperator 'Insert'," & sq(cboExamScheduleID.Text.Trim) & ",N" & sq(txtTitle.Text.Trim) & ",''," & sq(P_UserName) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData(txtEmployeeID.Text.Trim, cboExamScheduleID.Text.Trim)
            End If
        Else
            MsgBox("新增员工考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If ValidData() = False Then Exit Sub

        StrSql = "Exec OP_SetOperator 'Delete'," & sq(cboExamScheduleID.Text.Trim) & ",N" & sq(txtTitle.Text.Trim) & ",''," & sq(P_UserName) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData(txtEmployeeID.Text.Trim, cboExamScheduleID.Text.Trim)
            End If
        Else
            MsgBox("删除员工考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        StrSql = "select * from OP_ExamOperator  where ExamScheduleID like '" + cboExamScheduleID.Text.Trim + "%'and BU =" & sq(P_BU) & "  order by EmployeeID "
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
            MsgBox("请上传文档并点击检查工号！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        If cboExamScheduleID.Text.Trim = "" Or txtTitle.Text.Trim = "" Then
            MsgBox("请选择考试计划！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        StrSql = "select * from OP_ExamOperator_temp where flag='N' and BU=" & sq(P_BU) & " "
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox("点击击检查工号！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        ValidData = True
    End Function

    Private Sub RefreshData(ByVal strExamOperator As String, ByVal ExamScheduleID As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "select * from OP_ExamOperator  where ExamScheduleID like '" + ExamScheduleID + "%'and  BU=" & sq(P_BU) & "  order by EmployeeID"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamOperator")
            DataGV.DataSource = ds.Tables("ExamOperator")
            DataGV.Refresh()
        Else
            MsgBox("这个计划没有考试人员！", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
    Private Sub UpLoadRefresh()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "select Operator  from OP_ExamOperator_temp where BU =" & sq(P_BU) & ""
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "Operator")
            DataGV.DataSource = ds.Tables("Operator")
            DataGV.Refresh()
        End If
    End Sub

    Private Sub cmbCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCheck.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "exec OP_CheckOperator @BU=" & sq(P_BU) & ""
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            If rst.Fields("result").Value = 1 Then
                MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            Else
                StrSql = "select Operator ,EmployeeName ,CardID from OP_ExamOperator_temp where BU =" & sq(P_BU)
                rst = Conn.Execute(StrSql)
                da.Fill(ds, rst, "Operator")
                DataGV.DataSource = ds.Tables("Operator")
            End If
        Else
            MsgBox("请检查！", MsgBoxStyle.Critical, "Error")
        End If

    End Sub

    Private Sub cboExamScheduleID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExamScheduleID.SelectedIndexChanged
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        StrSql = "OP_GetExamScheduleInfo @ExamScheduleID=" & sq(cboExamScheduleID.Text.Trim) & ",@BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            txtTitle.Text = rst.Fields("Title").Value
        End If
    End Sub

    Private Sub cmdFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile.Click
        Dim i As Integer
        On Error GoTo errhnd
        OpenFileDialog1.ShowDialog()
        txtEmployeeID.Text = OpenFileDialog1.FileName
        If UCase(Mid(txtEmployeeID.Text.Trim, Len(txtEmployeeID.Text.Trim) - 3, 4)) <> ".XLS" Then
            MsgBox("文件类型不正确，请选择表格文件 ", MsgBoxStyle.Critical, "Error")
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
            MsgBox("请选择要上传的文件", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If Trim(cboSheet.Text.ToString() = "") Then
            MsgBox("请选择要上传的页面", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Call UploadExamOperator(txtEmployeeID.Text.Trim, cboSheet.Text.Trim)
        Call UpLoadRefresh()
    End Sub
    Private Sub UploadExamOperator(ByVal FileName As String, ByVal SheetName As String)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim i
        Dim OPID As String
        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet
        OPID = xlapp.Cells(2, 1).value
        i = 2
        StrSql = "delete from  OP_ExamOperator_temp where BU=" & sq(P_BU)
        Conn.Execute(StrSql)
        While OPID <> ""
            StrSql = "exec InsertExamOperator @Operator='" + OPID + "',@BU=" & sq(P_BU) & " "
            Conn.Execute(StrSql)
            i = i + 1
            OPID = xlapp.Cells(i, 1).value
        End While
        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()
    End Sub

End Class