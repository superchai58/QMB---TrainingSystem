Public Class frmGroupList

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Select Case cmbGroup.Text.Trim
            Case "类别群组"
                StrSql = "select * from Group_Detail where BU='" & P_BU & "' " '0001
                If cmbGroupName.Text.Trim <> "" Then
                    StrSql = StrSql + "and [group]=N'" & cmbGroupName.Text.Trim & "' "
                End If
                StrSql = StrSql + "order by 1"
            Case "部门群组"
                StrSql = "select * from DeptGroup_Detail where BU='" & P_BU & "'" '0001
                If cmbGroupName.Text.Trim <> "" Then
                    StrSql = StrSql + "and Deptgroup=N'" & cmbGroupName.Text.Trim & "' "
                End If
                StrSql = StrSql + "order by 1"
            Case "试题群组"
                StrSql = "select * from Question_Group_Detail where BU='" & P_BU & "' " '0001
                If cmbGroupName.Text.Trim <> "" Then
                    StrSql = StrSql + "and Question_Group=N'" & cmbGroupName.Text.Trim & "' "
                End If
                StrSql = StrSql + "order by 1"
            Case "职务群组"
                StrSql = "select * from DutyGroup_Detail where BU='" & P_BU & "'"  '0001
                If cmbGroupName.Text.Trim <> "" Then
                    StrSql = StrSql + "and DutyGroup=N'" & cmbGroupName.Text.Trim & "' "
                End If
                StrSql = StrSql + "order by 1"
            Case Else
                MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
                Exit Sub
        End Select
        rs = Conn.Execute(StrSql)
        Call WriteToListview(lvwGroup, rs)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rs As New ADODB.Recordset
        If cmbGroup.Text.Trim = "" Then
            MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        StrSql = "Exec InsertGroupList N'" & cmbGroup.Text.Trim & "',N'" & cmbGroupName.Text.Trim & "',N'" & txtGroupDesc.Text.Trim & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        Call cmdQuery_Click(cmdQuery, New System.EventArgs())
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rs As New ADODB.Recordset
        If cmbGroup.Text.Trim = "" Then
            MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        StrSql = "Exec DeleteGroupList N'" & cmbGroup.Text.Trim & "',N'" & cmbGroupName.Text.Trim & "','" & P_BU & "' " '0001
        rs = Conn.Execute(StrSql)
        Call cmdQuery_Click(cmdQuery, New System.EventArgs())
    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub cmbGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroup.SelectedIndexChanged

    End Sub

    Private Sub cmbGroupName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGroupName.SelectedIndexChanged

    End Sub

    Private Sub lvwGroup_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwGroup.SelectedIndexChanged

    End Sub

    Private Sub txtGroupDesc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtGroupDesc.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class