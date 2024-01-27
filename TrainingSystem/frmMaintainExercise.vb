Public Class frmMaintainExercise

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Dim QuestionGroup As String

        If cmbQuestionGroup.Text.Trim = "������ҵԱ����" Then
            QuestionGroup = "OPExam"
        Else
            QuestionGroup = cmbQuestionGroup.Text.Trim
        End If

        StrSql = "select top 200 * from exercise_Detail where [group] like N'" & cmbGroup.Text.Trim & "%' and question_group like N'" & QuestionGroup & "%'  "
        StrSql = StrSql + "and dutygroup like N'" & cmbDutyGroup.Text.Trim & "%' and BU =" & sq(P_BU) & ""

        If cmbDeptGroup.Text.Trim <> "" Then StrSql = StrSql + " and deptgroup=N'" & cmbDeptGroup.Text.Trim & "' "
        If cmbQuestionNO.Text.Trim <> "" Then StrSql = StrSql + " and question_no='" & cmbQuestionNO.Text.Trim & "' "
        If cmbQuestionType.Text.Trim <> "" Then StrSql = StrSql + " and question_type='" & cmbQuestionType.Text.Trim & "' "
        If cmbMaterial.Text.Trim <> "" Then StrSql = StrSql + " and Material='" & cmbMaterial.Text.Trim & "' "
        StrSql = StrSql & " Order by Question_No "
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            Call WriteToListview(lvwExercise, rs)
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rs As New ADODB.Recordset
        Dim QuestionGroup As String
        If CheckErr() = False Then Exit Sub
        StrSql = "select * from exercise_detail where question_no='" & cmbQuestionNO.Text.Trim & "' and question_group=N'" & cmbQuestionGroup.Text.Trim & "' " & _
                 "and [group]=N'" & cmbGroup.Text.Trim & "' and deptgroup=N'" & cmbDeptGroup.Text.Trim & "' and  dutygroup=N'" & cmbDutyGroup.Text.Trim & "' and BU =" & sq(P_BU) & ""
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            MsgBox("�˱������Ѿ����ڣ�", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        If cmbQuestionGroup.Text.Trim = "������ҵԱ����" Then
            QuestionGroup = "OPExam"
        Else
            QuestionGroup = cmbQuestionGroup.Text.Trim
        End If

        StrSql = "Exec InsertExerciseData_TEST '" & cmbQuestionNO.Text.Trim & "',N'" & QuestionGroup & "',N'" & cmbGroup.Text.Trim & "'," &
                "N'" & cmbDeptGroup.Text.Trim & "',N'" & cmbDutyGroup.Text.Trim & "',N'" & cmbQuestionType.Text.Trim & "',N'" & txtExercise.Text.Trim & "'," &
                "N'" & txtAnswerA.Text.Trim & "',N'" & txtAnswerB.Text.Trim & "',N'" & txtAnswerC.Text.Trim & "',N'" & txtAnswerD.Text.Trim & "'," &
                "N'" & txtCorrectAnswer.Text.Trim & "',N'" & cmbMaterial.Text.Trim & "'," & sq(P_BU)
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            MsgBox("��������ɹ���", MsgBoxStyle.Information, "AddExercise")
        End If
    End Sub
    Private Function CheckErr() As Boolean
        CheckErr = True
        If cmbQuestionNO.Text.Trim = "" Or IsNumeric(cmbQuestionNO.Text.Trim) = False Then
            CheckErr = False
            MsgBox("������δ������߲�������", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cmbQuestionGroup.Text.Trim = "" Then
            CheckErr = False
            MsgBox("����Ⱥ��û��ѡ��", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cmbGroup.Text.Trim = "" Then
            CheckErr = False
            MsgBox("���Ⱥ��û��ѡ��", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cmbDeptGroup.Text.Trim = "" Then
            CheckErr = False
            MsgBox("����Ⱥ��û��ѡ��", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If cmbDutyGroup.Text.Trim = "" Then
            CheckErr = False
            MsgBox("ְ��Ⱥ��û��ѡ��", MsgBoxStyle.Critical, "Error")
        End If
        If cmbQuestionType.Text.Trim = "" Then
            CheckErr = False
            MsgBox("��������û��ѡ��", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If txtExercise.Text.Trim = "" Then
            CheckErr = False
            MsgBox("��������û����д", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If txtAnswerA.Text = "" Then
            CheckErr = False
            MsgBox("��Aû����д", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
        If txtCorrectAnswer.Text.Trim = "" Then
            CheckErr = False
            MsgBox("��ȷ��û����д", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If
    End Function

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rs As New ADODB.Recordset
        StrSql = "Exec DeleteExerciseData '" & cmbQuestionNO.Text.Trim & "',N'" & cmbQuestionGroup.Text.Trim & "',N'" & cmbGroup.Text.Trim & "'," & _
                "N'" & cmbDeptGroup.Text.Trim & "',N'" & cmbDutyGroup.Text.Trim & "," & sq(P_BU) & " "
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            MsgBox("ɾ���ɹ���", MsgBoxStyle.Information, "Delete")
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        StrSql = "select * from exercise_Detail where [group] like N'" & cmbGroup.Text.Trim & "%' and question_group like N'" & cmbQuestionGroup.Text.Trim & "%'and BU =" & sq(P_BU) & "  "
        StrSql = StrSql + "and dutygroup like N'" & cmbDutyGroup.Text.Trim & "%' "
        If cmbDeptGroup.Text.Trim <> "" Then StrSql = StrSql + " and deptgroup=N'" & cmbDeptGroup.Text.Trim & "' "
        If cmbQuestionNO.Text.Trim <> "" Then StrSql = StrSql + " and question_no='" & cmbQuestionNO.Text.Trim & "' "
        If cmbQuestionType.Text.Trim <> "" Then StrSql = StrSql + " and question_type='" & cmbQuestionType.Text.Trim & "' "
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            Call CopyToExcel(rs)
        End If
    End Sub


    Private Sub frmUploadExercise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        cmbQuestionNO.Items.Clear()
        cmbQuestionNO.Items.Add("")
        cmbQuestionGroup.Items.Clear()
        cmbQuestionGroup.Items.Add("")
        cmbGroup.Items.Clear()
        cmbGroup.Items.Add("")
        cmbDutyGroup.Items.Clear()
        cmbDutyGroup.Items.Add("")
        cmbDeptGroup.Items.Clear()
        cmbDeptGroup.Items.Add("")
        cmbQuestionType.Items.Clear()
        cmbQuestionType.Items.Add("")
        StrSql = "exec GetAllGroupList '" & P_BU & "'" '���޸ļ�BU����  0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbQuestionNO.Items.Add(rs.Fields("GroupValue").Value.ToString)
            rs.MoveNext()
        End While
        rs = rs.NextRecordset
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            Select Case rs.Fields("GroupName").Value.ToString
                Case "GROUP"
                    cmbGroup.Items.Add(rs.Fields("GroupValue").Value.ToString)
                Case "QUESTIONGROUP"
                    cmbQuestionGroup.Items.Add(rs.Fields("GroupValue").Value.ToString)
                Case "QUESTIONTYPE"
                    cmbQuestionType.Items.Add(rs.Fields("GroupValue").Value.ToString)
                Case "DUTYGROUP"
                    cmbDutyGroup.Items.Add(rs.Fields("GroupValue").Value.ToString)
                Case "DEPTGROUP"
                    cmbDeptGroup.Items.Add(rs.Fields("GroupValue").Value.ToString)
            End Select
            rs.MoveNext()
        End While
    End Sub

    ''20110712    Denver   Add ������ҵԱ���� ����
    Private Sub cmbQuestionGroup_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuestionGroup.TextChanged
        If cmbQuestionGroup.Text.Trim() = "������ҵԱ����" Then
            cmbGroup.Text = "OPExam"
            cmbDutyGroup.Text = "OPExam"
            cmbMaterial.Text = "OPExam"
            cmbDeptGroup.Text = "OPExam"
        End If
    End Sub
End Class