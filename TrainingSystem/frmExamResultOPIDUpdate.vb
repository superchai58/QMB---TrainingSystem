Public Class frmExamResultOPIDUpdate

    Private Sub btUpdate_Click(sender As Object, e As EventArgs) Handles btUpdate.Click
        Dim rs As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        If txtNewUserName.Text.Trim = "" Then
            MsgBox("请输入新的UserName！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If txtOldUserName.Text.Trim = "" Then
            MsgBox("请输入旧的Username！", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        StrSql = "exec  OP_UpdateExamResultOPID'" & txtOldUserName.Text.Trim & "', '" & txtNewUserName.Text.Trim & "'," & P_BU & ""
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            MsgBox(rs.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
        Else
            MsgBox("No Data！", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class