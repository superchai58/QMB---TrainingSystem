Public Class frmExamOperatorUpdateOPID


    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Dim NewOPID As String = txtNewOPID.Text.Trim
        Dim OldOPID As String
        Dim OPName As String
        Dim StrSql As String
        cmdUpdate.Enabled = False

        If NewOPID = "" Then
            MsgBox("請輸入工號", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        txtUserName.Text = ""
        txtOldOPID.Text = ""
        ExamResultGV.DataSource = DBNull.Value
        ExamOperatorGV.DataSource = DBNull.Value
        ExamPracticeGV.DataSource = DBNull.Value
        InvesGV.DataSource = DBNull.Value
        StrSql = "exec Training_Operate @OPItem='QueryOPID',@UserID=N'" & NewOPID & "',@UID='" & P_UserName & "'"

        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            If FieldExists(rs, "Result") Then
                MsgBox(rs.Fields("Description").Value, MsgBoxStyle.Critical, "Error")
                Return
            End If

            OPName = rs.Fields("EmployeeName").Value
            txtUserName.Text = OPName
            OldOPID = rs.Fields("OldOPID").Value
            txtOldOPID.Text = OldOPID

            If OldOPID <> "" And OPName <> "" And NewOPID <> OldOPID Then
                UpdateGV(OldOPID, OPName, True)
            End If
        Else
            MsgBox("No Data！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        rs = Nothing
    End Sub

    Public Function FieldExists(ByVal rs As ADODB.Recordset, ByVal fieldName As String) As Boolean

        On Error GoTo merr

        FieldExists = rs.Fields(fieldName).name <> ""
        Exit Function

merr:
        FieldExists = False

    End Function

    Private Sub UpdateGV(UserID As String, Name As String, UpdateFlag As Boolean)
        Dim rs As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StrSql As String

        '清空
        ExamResultGV.DataSource = DBNull.Value
        ExamOperatorGV.DataSource = DBNull.Value
        ExamPracticeGV.DataSource = DBNull.Value
        '1.1 檢查考試成績
        StrSql = "SELECT * FROM Exercise_Result A WITH (NOLOCK) where UserID='" & UserID & "' and UserName=N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "ExamResult")
            ExamResultGV.DataSource = ds.Tables("ExamResult")

            If UpdateFlag And UserID <> "" And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If
        '1.2 檢查人員報名
        StrSql = "SELECT * FROM OP_ExamOperator A WITH (NOLOCK) where EmployeeID='" & UserID & "' and EmployeeName=N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "ExamOperator")
            ExamOperatorGV.DataSource = ds.Tables("ExamOperator")

            If UpdateFlag And UserID <> "" And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If
        '1.3 檢查實作成績
        StrSql = "SELECT * FROM OP_PracScore A WITH (NOLOCK) where EmployeeID='" & UserID & "' and EmployeeName=N'" & Name & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "PracticeGV")
            ExamPracticeGV.DataSource = ds.Tables("PracticeGV")

            If UpdateFlag And UserID <> "" And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If
        '1.4 檢查問卷調查
        StrSql = "SELECT * FROM Inves_Result A WITH (NOLOCK) where Examinees='" & UserID & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "InvesGV")
            InvesGV.DataSource = ds.Tables("InvesGV")

            If UpdateFlag And UserID <> "" And Name <> "" Then
                cmdUpdate.Enabled = True
            End If
        End If

    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        cmdUpdate.Enabled = False
        Dim rs As New ADODB.Recordset
        Dim UserID As String = txtNewOPID.Text.Trim
        Dim OPName As String = txtUserName.Text.Trim
        Dim StrSql As String

        If OPName = "" Or UserID = "" Then
            MsgBox("姓名查無，請重新查詢", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        StrSql = "exec Training_Operate @OPItem='UpdateOPID',@UserID=N'" & UserID & "',@UID='" & P_UserName & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            If OPName <> "" Then
                UpdateGV(UserID, OPName, False)
                MsgBox("更新完成", MsgBoxStyle.Critical, "Error")
            Else
                ExamResultGV.DataSource = DBNull.Value
                ExamOperatorGV.DataSource = DBNull.Value
                ExamPracticeGV.DataSource = DBNull.Value
                InvesGV.DataSource = DBNull.Value
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtNewOPID_TextChanged(sender As Object, e As EventArgs) Handles txtNewOPID.TextChanged

    End Sub

    Private Sub txtOldOPID_TextChanged(sender As Object, e As EventArgs) Handles txtOldOPID.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class