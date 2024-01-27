Public Class FrmPracticeList

    Private Sub FrmPracticeList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        If P_FormFlag = "PRACTICE" Then
            FrmUserInput.Close()
        End If
        cmbDutyGroup.Items.Clear()
        cmbDutyGroup.Items.Add("")
        txtUserID.Text = P_UserName
        StrSql = "Exec GetUserInfo '" & P_UserName & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            txtUserName.Text = rs.Fields("UserName").Value.ToString
            txtShift.Text = rs.Fields("Shift").Value.ToString
            txtGroup.Text = rs.Fields("Group").Value.ToString
            txtDuty.Text = rs.Fields("Duty").Value.ToString
        End If
        StrSql = "exec GetDutyGroup '" & P_UserName & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbDutyGroup.Items.Add(rs.Fields("DutyGroup").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmbDutyGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDutyGroup.SelectedIndexChanged
        Call GetCertifyDetail(P_UserName, txtGroup.Text.Trim, cmbDutyGroup.Text.Trim)
    End Sub
    Private Sub GetCertifyDetail(ByVal sUserID As String, ByVal sGroup As String, ByVal sDutyGroup As String)
        Dim rs As New ADODB.Recordset
        StrSql = "exec GetCertifyItemNew '" & sUserID & "',N'" & sGroup & "',N'" & sDutyGroup & "','" & P_BU & "'" '0001
        'StrSql = "SELECT 'FAIL' as Certify,userid,[group],deptgroup,dutygroup,CertifyItem,CertifyDetail,Result from CertifyTrace"
        'rs = Conn.Execute(StrSql)
        If rs.State = 1 Then rs.Close()
        rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        rs.Open(StrSql, Conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        Call WriteToListview(lvwItem, rs)
        'Call WriteToListviewCheckBOX_CertifyReslut(lvwItem, rs)
        rs = Nothing
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo Errhandler
        Dim Rs As New ADODB.Recordset
        Dim i As Short
        Dim Result As String
        If lvwItem.Items.Count > 0 Then
            If Rs.State = 1 Then Rs.Close()
            Rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            With lvwItem
                For i = 0 To .Items.Count - 1
                    If .Items.Item(i).Checked Then
                        Result = "FAIL"
                    Else
                        Result = "PASS"
                    End If
                    StrSql = "Update CertifyTrace set result='" & Result & "' where userid='" & txtUserID.Text.Trim & "' and certifyitem=N'" & .Items.Item(i).SubItems(5).Text & "' and certifydetail=N'" & .Items.Item(i).SubItems(6).Text & "' and BU='" & P_BU & "'" '0001
                    Rs.Open(StrSql, Conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
                    'Rs.Close()
                Next i
            End With
            Rs = Nothing
        End If
        Exit Sub
Errhandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        StrSql = "exec GetCertifyItemNew '" & P_UserName & "',N'" & txtGroup.Text.Trim & "',N'" & cmbDutyGroup.Text.Trim & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF Then
            MsgBox("No data")
            Exit Sub
        End If
        Call CopyToExcel(rs)
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
End Class