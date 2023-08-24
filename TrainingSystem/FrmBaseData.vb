Public Class FrmBaseData

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Select Case cmbChoose.Text.Trim
            Case "类别群组"
                StrSql = "select * from DeptCode_Group where 1=1 and BU='" & P_BU & "'"  '0001
                If cmbDutyGroup.Text.Trim <> "" Then
                    StrSql = StrSql + " and DeptCode='" & txtDeptCode.Text.Trim & "' "
                End If
                If cmbGroup2.Text.Trim <> "" Then
                    StrSql = StrSql + " and [Group]='" & cmbGroup2.Text.Trim & "' "
                End If
                If txtQTY.Text.Trim <> "" Then
                    StrSql = StrSql + " and DeptGroup=N'" & txtDeptGroup.Text.Trim & "' "
                End If
                StrSql = StrSql + " order by 1"
            Case "题数定义"
                StrSql = "select * from DutyGroup_QuestionQty where 1=1 and BU='" & P_BU & "'"  '0001
                If cmbGroup.Text.Trim <> "" Then
                    StrSql = StrSql + " and Group=N'" & cmbGroup.Text.Trim & "' "
                End If
                If cmbDutyGroup.Text.Trim <> "" Then
                    StrSql = StrSql + " and DutyGroup=N'" & cmbDutyGroup.Text.Trim & "' "
                End If
                If txtQTY.Text.Trim <> "" Then
                    StrSql = StrSql + " and QTY='" & txtQTY.Text.Trim & "' "
                End If
                If txtQTYAll.Text.Trim <> "" Then
                    StrSql = StrSql + " and QTY_All='" & txtQTYAll.Text.Trim & "' "
                End If
                If txtQGroup.Text.Trim <> "" Then
                    StrSql = StrSql + " and Question_Group=N'" & txtQGroup.Text.Trim & "' "
                End If
                If txtpass.Text.Trim <> "" Then
                    StrSql = StrSql + " and PassScore='" & txtpass.Text.Trim & "' "
                End If
                StrSql = StrSql + " order by 1"
            Case "职务对应关系"
                StrSql = "select * from dutymap WHERE 1=1 and BU='" & P_BU & "'"  '0001
                If txtDuty.Text.Trim <> "" Then
                    StrSql = StrSql + " and Duty=N'" & txtDuty.Text.Trim & "' "
                End If
                If cmbGroup3.Text.Trim <> "" Then
                    StrSql = StrSql + " and [Group]='" & cmbGroup3.Text.Trim & "' "
                End If
                If txtDutyGroup.Text.Trim <> "" Then
                    StrSql = StrSql + " and DutyGroup=N'" & txtDutyGroup.Text.Trim & "' "
                End If
                StrSql = StrSql + " order by 1"
            Case Else
                MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
                Exit Sub
        End Select
        rs = Conn.Execute(StrSql)
        Call WriteToListview(lvwGroup, rs)
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub cmbChoose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChoose.Click
    End Sub

    Private Sub cmbChoose_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChoose.SelectedIndexChanged
        If cmbChoose.Text = "题数定义" Then
            Call DisvisibleGroup()
            Call VisibleGroup(GroupBox1)
        End If
        If cmbChoose.Text = "职务对应关系" Then
            Call DisvisibleGroup()
            Call VisibleGroup(GroupBox4)
        End If
        If cmbChoose.Text = "类别群组" Then
            Call DisvisibleGroup()
            Call VisibleGroup(GroupBox2)
        End If
    End Sub
    Private Sub DisvisibleGroup()
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        lvwGroup.Visible = False
    End Sub
    Private Sub VisibleGroup(ByVal sGroupbox As GroupBox)
        sGroupbox.Visible = True
        sGroupbox.Location = New System.Drawing.Point(12, 36)
        GroupBox3.Visible = True
        lvwGroup.Visible = True
        lvwGroup.Location = New System.Drawing.Point(12, 168)
        lvwGroup.Clear()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rs As New ADODB.Recordset
        Select Case cmbChoose.Text.Trim
            Case "类别群组"
                If txtDeptCode.Text.Trim <> "" And cmbGroup2.Text.Trim <> "" And txtDeptGroup.Text.Trim <> "" Then
                    Conn.Execute("Exec InsertDeptCodeGroup '" & Trim(txtDeptCode.Text.Trim) & "','" & Trim(cmbGroup2.Text.Trim) & "',N'" & Trim(txtDeptGroup.Text.Trim) & "','" & P_BU & "' ")  '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case "题数定义"
                If cmbGroup.Text.Trim <> "" And cmbDutyGroup.Text.Trim <> "" And txtQTYAll.Text.Trim <> "" And txtQTY.Text.Trim <> "" And txtQGroup.Text.Trim <> "" And txtpass.Text.Trim <> "" Then
                    Conn.Execute("Exec InsertQuestionQty '" & Trim(cmbGroup.Text.Trim) & "',N'" & Trim(cmbDutyGroup.Text.Trim) & "','" & Trim(txtQTY.Text.Trim) & "',N'" & Trim(txtQGroup.Text.Trim) & "','" & Trim(txtpass.Text.Trim) & "','" & Trim(txtQTYAll.Text.Trim) & "','" & P_BU & "' ") '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case "职务对应关系"
                If txtDuty.Text.Trim <> "" And cmbGroup3.Text.Trim <> "" And txtDutyGroup.Text.Trim <> "" Then
                    Conn.Execute("Exec InsertDutyMap N'" & Trim(cmbGroup3.Text.Trim) & "',N'" & Trim(txtDuty.Text.Trim) & "',N'" & Trim(txtDutyGroup.Text.Trim) & "' ,'" & P_BU & "'") '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case Else
                MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
                Exit Sub
        End Select

        Call cmdQuery_Click(cmdQuery, New System.EventArgs())
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rs As New ADODB.Recordset
        Select Case cmbChoose.Text.Trim
            Case "类别群组"
                If txtDeptCode.Text.Trim <> "" And cmbGroup2.Text.Trim <> "" And txtDeptGroup.Text.Trim <> "" Then
                    Conn.Execute("delete from DeptCode_Group where deptcode='" & Trim(txtDeptCode.Text.Trim) & "' and DeptGroup=N'" & Trim(txtDeptGroup.Text.Trim) & "' and [Group]= '" & Trim(cmbGroup2.Text.Trim) & "','" & P_BU & "'") '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case "题数定义"
                If cmbGroup.Text.Trim <> "" And cmbDutyGroup.Text.Trim <> "" And txtQTYAll.Text.Trim <> "" And txtQTY.Text.Trim <> "" And txtQGroup.Text.Trim <> "" And txtpass.Text.Trim <> "" Then
                    Conn.Execute("delete from dutygroup_questionqty where [group]='" & Trim(cmbGroup.Text.Trim) & "' and Dutygroup=N'" & Trim(cmbDutyGroup.Text.Trim) & "' and Question_Group=N'" & Trim(txtQGroup.Text.Trim) & "' and qty='" & Trim(txtQTY.Text.Trim) & "' and qty_all= '" & Trim(txtQTYAll.Text.Trim) & "' and passScore='" & Trim(txtpass.Text.Trim) & "','" & P_BU & "'") '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case "职务对应关系"
                If txtDuty.Text.Trim <> "" And cmbGroup3.Text.Trim <> "" And txtDutyGroup.Text.Trim <> "" Then
                    Conn.Execute("delete from DutyMap where [Group]=N'" & Trim(cmbGroup3.Text.Trim) & "' and Duty=N'" & Trim(txtDuty.Text.Trim) & "' and DutyGroupN'" & Trim(txtDutyGroup.Text.Trim) & "','" & P_BU & "'") '0001
                Else
                    MsgBox("请输入资料", MsgBoxStyle.Critical, "Error")
                End If
            Case Else
                MsgBox("请选择正确的群组类别", MsgBoxStyle.Critical, "Error")
                Exit Sub
        End Select

        Call cmdQuery_Click(cmdQuery, New System.EventArgs())
    End Sub

    Private Sub FrmBaseData_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call DisvisibleGroup()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class