Public Class frmUserConfig

    Private Sub frmUserConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        StrSql = "select isnull(a.username,'') as username,a.enname,b.employeename,b.deptcode,b.department," & _
                 "b.duty,b.phone,b.mail,b.shift from mis_hr_employee b left join userdetail a on " & _
                 "b.employeeid=a.username where b.employeeid='" & P_UserName & "'"
        txtUserID.Text = P_UserName
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            If rs.Fields("username").Value = "" Then
                MsgBox("This user ID was not exists in training system!", MsgBoxStyle.Critical)
            Else
                txtEnUserName.Text = rs.Fields("enname").Value
                txtPassWord.Text = "00000000"
            End If
            txtUserName.Text = rs.Fields("employeename").Value
            txtdept.Text = rs.Fields("deptcode").Value + "--" + rs.Fields("department").Value
            txtDuty.Text = rs.Fields("duty").Value
            txtExtNo.Text = rs.Fields("phone").Value
            txtMail.Text = rs.Fields("mail").Value
            txtShift.Text = rs.Fields("shift").Value
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim rs As New ADODB.Recordset
        StrSql = "update userdetail set password='" & txtPassWord.Text.Trim & "',enname='" & txtEnUserName.Text.Trim & "' " & _
                 "where username='" & txtUserID.Text.Trim & "' and BU=" & sq(P_BU)
        rs = Conn.Execute(StrSql)
        MsgBox("Update ok!", MsgBoxStyle.Information)
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class