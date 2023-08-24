Public Class frmExamOperatorUpdateName

    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Dim UserID As String = txtUserID.Text.Trim
        Dim NewName As String
        cmdUpdate.Enabled = False
        txtNewName.Text = ""
        ExamResultGV.DataSource = DBNull.Value
        ExamOperatorGV.DataSource = DBNull.Value
        ExamPracticeGV.DataSource = DBNull.Value

        If UserID = "" Then
            MsgBox("請輸入工號", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        StrSql = "exec Training_Operate @OPItem='QueryName',@UserID=N'" & UserID & "',@UID='" & P_UserName & "'"

        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            NewName = rs.Fields("EmployeeName").Value
            txtNewName.Text = NewName

            If NewName <> "" Then
                UpdateGV(UserID, NewName, True)
            End If
        Else
            MsgBox("No Data！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        rs = Nothing
    End Sub

    Private Sub UpdateGV(UserID As String, Name As String, UpdateFlag As Boolean)
        Dim rs As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        '清空
        ExamResultGV.DataSource = DBNull.Value
        ExamOperatorGV.DataSource = DBNull.Value
        ExamPracticeGV.DataSource = DBNull.Value
        '1.1 檢查考試成績
        StrSql = "SELECT * FROM Exercise_Result A WITH (NOLOCK) where UserID='" & UserID & "' and UserName<>N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "ExamResult")
            ExamResultGV.DataSource = ds.Tables("ExamResult")

            If UpdateFlag And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If
        '1.2 檢查人員報名
        StrSql = "SELECT * FROM OP_ExamOperator A WITH (NOLOCK) where EmployeeID='" & UserID & "' and EmployeeName<>N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "ExamOperator")
            ExamOperatorGV.DataSource = ds.Tables("ExamOperator")
            
            If UpdateFlag And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If
        '1.3 檢查實作成績
        StrSql = "SELECT * FROM OP_PracScore A WITH (NOLOCK) where EmployeeID='" & UserID & "' and EmployeeName<>N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "PracticeGV")
            ExamPracticeGV.DataSource = ds.Tables("PracticeGV")
            
            If UpdateFlag And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        cmdUpdate.Enabled = False
        Dim rs As New ADODB.Recordset
        Dim UserID As String = txtUserID.Text.Trim
        Dim NewName As String = txtNewName.Text.Trim
        If UserID = "" Then
            MsgBox("請輸入工號", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If NewName = "" Then
            MsgBox("姓名查無，請重新查詢，再進行修改", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        
        StrSql = "exec Training_Operate @OPItem='UpdateName',@UserID=N'" & UserID & "',@UID='" & P_UserName & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            If NewName <> "" Then
                UpdateGV(UserID, NewName, False)
                MsgBox("更新完成", MsgBoxStyle.Critical, "Error")
            Else
                ExamResultGV.DataSource = DBNull.Value
                ExamOperatorGV.DataSource = DBNull.Value
                ExamPracticeGV.DataSource = DBNull.Value
            End If
        Else
        MsgBox("No Data！", MsgBoxStyle.Critical, "Error")
        ExamResultGV.DataSource = DBNull.Value
        Exit Sub
        End If
        rs = Nothing

    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class