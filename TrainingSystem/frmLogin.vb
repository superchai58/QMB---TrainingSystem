Public Class frmLogin

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim i As Integer
        Dim rs As New ADODB.Recordset
        If txtUserName.Text.Trim = "" Then
            MsgBox("Please key in user name!", MsgBoxStyle.Critical)
            txtUserName.SelectAll()
            Exit Sub
        End If
        If txtPassWord.Text.Trim = "" Then
            MsgBox("Please key in pass word!", MsgBoxStyle.Critical)
            txtPassWord.SelectAll()
            Exit Sub
        End If
        StrSql = "select * from SMT.dbo.userdetail where username='" & txtUserName.Text.Trim & "' "
        'and BU='" & P_BU & "' "
        rs = Conn.Execute(StrSql)
        If rs.EOF Then
            MsgBox("This user not exist!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If rs.Fields("password").Value <> txtPassWord.Text.Trim Then
            MsgBox("Password error!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        'P_BU = rs.Fields("BU").Value '0001

        StrSql = "select userright from SMT.dbo.userright where username='" & txtUserName.Text.Trim & "' and " & _
                 "appname='Training' "
        'and BU='" & P_BU & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            ReDim P_Userright(rs.RecordCount - 1)
            For i = 0 To UBound(P_Userright)
                P_Userright(i) = rs.Fields("userright").Value
                rs.MoveNext()
            Next i
        Else
            MsgBox("No Right for Training", MsgBoxStyle.Critical)
            Exit Sub
        End If

        
        P_UserName = txtUserName.Text.Trim
        rs = Nothing
        Me.Visible = False
        frmMain.ShowDialog()
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub
End Class
