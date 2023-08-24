Public Class FrmHRInfo

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        StrSql = "select * from MIS_HR_Employee where 1=1 and [Department] = N'" & cmbDept.Text.Trim & "'"
        If txtDeptCode.Text.Trim <> "" Then StrSql = StrSql + " and DeptCode=N'" & txtDeptCode.Text.Trim & "' "
        If txtUserID.Text.Trim <> "" Then StrSql = StrSql + " and EmployeeID='" & txtUserID.Text.Trim & "' "
        'If cmbDept.Text.Trim <> "" Then StrSql = StrSql + " and [Department] like N'" & cmbDept.Text.Trim & "%' "
        
        If rs.State = 1 Then rs.Close()
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.Open(StrSql, Conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        Call WriteToListview(lvwItem, rs)
        rs = Nothing
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        StrSql = "select * from MIS_HR_Employee where 1=1 and [Department] = N'" & cmbDept.Text.Trim & "'"
        If txtDeptCode.Text.Trim <> "" Then StrSql = StrSql + " and DeptCode=N'" & txtDeptCode.Text.Trim & "' "
        If txtUserID.Text.Trim <> "" Then StrSql = StrSql + " and EmployeeID='" & txtUserID.Text.Trim & "' "
        'If cmbDept.Text.Trim <> "" Then StrSql = StrSql + " and [Department] like N'" & cmbDept.Text.Trim & "%' "
        rs = Conn.Execute(StrSql)
        If rs.EOF Then
            MsgBox("No data")
            Exit Sub
        End If
        Call CopyToExcel(rs)
    End Sub

    Private Sub FrmHRInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        cmbDept.Items.Clear()
        cmbDept.Items.Add("")
        StrSql = "select distinct Department as Dept from mis_hr_employee order by 1"
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbDept.Items.Add(rs.Fields("Dept").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub txtDeptCode_TextChanged(sender As Object, e As EventArgs) Handles txtDeptCode.TextChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub
End Class