Public Class frmDefineUserBase
    Private Sub RefreshUser()
        Dim rs As New ADODB.Recordset
        StrSql = "select a.username as 用户名,a.enname as 英文名,b.employeename as 姓名,b.deptcode as 部门代码," & _
                 "b.department as 部门,b.duty as 职务,b.phone as 分机,b.mail as 邮件,b.shift as 班别,a.BU as 所属BU " & _
                 "from userdetail a,mis_hr_employee b where a.username=b.employeeid and a.bu='" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        Call WriteToListview(lvwUser, rs)
    End Sub
    Private Sub frmDefineUserBase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        Call RefreshUser()
        CboBU.Items.Add(Trim(P_BU))
    End Sub

    Private Sub lvwUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwUser.Click
        txtUserID.Text = lvwUser.FocusedItem.Text
        txtEnUserName.Text = lvwUser.FocusedItem.SubItems(1).Text
        txtPassWord.Text = "00000000"
        txtUserName.Text = lvwUser.FocusedItem.SubItems(2).Text
        txtdept.Text = lvwUser.FocusedItem.SubItems(3).Text + "--" + lvwUser.FocusedItem.SubItems(4).Text
        txtDuty.Text = lvwUser.FocusedItem.SubItems(5).Text
        txtExtNo.Text = lvwUser.FocusedItem.SubItems(6).Text
        txtMail.Text = lvwUser.FocusedItem.SubItems(7).Text
        txtShift.Text = lvwUser.FocusedItem.SubItems(8).Text
    End Sub

    Private Sub cmdAddUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddUser.Click
        Dim rs As New ADODB.Recordset
        If Trim(txtUserID.Text) = "" Or Len(txtUserID.Text.Trim) <> 8 Or Trim(CboBU.Text) = "" Or Trim(txtPassWord.Text) = "" Then   'add BU by Alawn 0001
            MsgBox("User ID format error or BU is null or PassWord is Null!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If CboBU.Text.Trim = "" Then
            MsgBox("Please choose correct BU!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrSql = "select isnull(a.username,'') as username,a.enname,b.employeename,b.deptcode,b.department," & _
                 "b.duty,b.phone,b.mail,b.shift from mis_hr_employee b left join userdetail a on " & _
                 "b.employeeid=a.username where b.employeeid='" & txtUserID.Text.Trim & "'and A.Bu=" & sq(P_BU) & ""
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            MsgBox("This user ID was already exists in training system!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrSql = "Insert into userdetail(Username,EnName,Password,BU) values('" & txtUserID.Text.Trim & "','" & txtEnUserName.Text.Trim & "','" & txtPassWord.Text & "','" & CboBU.Text & "')"
        Conn.Execute(StrSql)
        MsgBox("Insert OK!", MsgBoxStyle.Information)
        Call RefreshUser()
    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        Dim rs As New ADODB.Recordset
        If Asc(e.KeyChar) <> 13 Then Exit Sub
        If Trim(txtUserID.Text) = "" Or Len(txtUserID.Text.Trim) <> 8 Then
            MsgBox("User ID format error!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrSql = "select b.employeeid,b.employeename,b.deptcode,b.department," & _
                 "b.duty,b.phone,b.mail,b.shift from mis_hr_employee b where b.employeeid='" & txtUserID.Text.Trim & "'"
        rs = Conn.Execute(StrSql)
        If rs.EOF Then
            MsgBox("Can not found user ID from HR system!", MsgBoxStyle.Critical)
            Exit Sub
        Else
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

    Private Sub cmdRemoveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemoveUser.Click
        Dim rs As New ADODB.Recordset
        If txtUserID.Text.Trim = "" Or Len(txtUserID.Text.Trim) <> 8 Then
            MsgBox("Please choose correct user ID!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If CboBU.Text.Trim = "" Then
            MsgBox("Please choose correct BU!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If MsgBox("Are you sure to delete this user?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            StrSql = "delete from userdetail where username='" & txtUserID.Text.Trim & "' and BU='" & P_BU & "'" '0001
            rs = Conn.Execute(StrSql)
            MsgBox("Delete OK!", MsgBoxStyle.Information)
            Call RefreshUser()
        End If
    End Sub

    Private Sub cmdModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdModify.Click
        Dim rs As New ADODB.Recordset
        If txtUserID.Text.Trim = "" Or Len(txtUserID.Text.Trim) <> 8 Then
            MsgBox("Please choose correct user ID!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If CboBU.Text.Trim = "" Then
            MsgBox("Please choose correct BU!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        StrSql = "update userdetail set enname='" & txtEnUserName.Text.Trim & "' " & _
                 "where username='" & txtUserID.Text.Trim & "'and BU =" & sq(P_BU)
        rs = Conn.Execute(StrSql)
        MsgBox("Update EnName ok!", MsgBoxStyle.Information)
        Call RefreshUser()
    End Sub

End Class