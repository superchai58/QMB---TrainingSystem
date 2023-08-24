Public Class frmExercise
    Dim Group As String
    Dim DeptGroup As String
    Dim DutyGroup As String
    Dim ExerciseData(200) As ExamData
    Dim PageIndex As Integer
    Dim MaxPageID As Integer
    Dim LastPageExerciseQty As Integer
    Dim Exam As Boolean
    Dim sPassScore As String
    Private Sub ClearExamData()
        txtExercise1.Text = ""
        txtAnswerA1.Text = ""
        txtAnswerB1.Text = ""
        txtAnswerC1.Text = ""
        txtAnswerD1.Text = ""
        A1.Checked = False
        B1.Checked = False
        C1.Checked = False
        D1.Checked = False
        txtExercise2.Text = ""
        txtAnswerA2.Text = ""
        txtAnswerB2.Text = ""
        txtAnswerC2.Text = ""
        txtAnswerD2.Text = ""
        A2.Checked = False
        B2.Checked = False
        C2.Checked = False
        D2.Checked = False
        txtExercise3.Text = ""
        txtAnswerA3.Text = ""
        txtAnswerB3.Text = ""
        txtAnswerC3.Text = ""
        txtAnswerD3.Text = ""
        A3.Checked = False
        B3.Checked = False
        C3.Checked = False
        D3.Checked = False
        txtExercise4.Text = ""
        txtAnswerA4.Text = ""
        txtAnswerB4.Text = ""
        txtAnswerC4.Text = ""
        txtAnswerD4.Text = ""
        A4.Checked = False
        B4.Checked = False
        C4.Checked = False
        D4.Checked = False
    End Sub

    Private Sub A1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A1.Click
        If A1.Checked Then
            ExerciseData((PageIndex - 1) * 4).Answer = ExerciseData((PageIndex - 1) * 4).Answer + "A"
        Else
            ExerciseData((PageIndex - 1) * 4).Answer = Replace(ExerciseData((PageIndex - 1) * 4).Answer, "A", "")
        End If
    End Sub

    Private Sub A2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A2.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 2 Then Exit Sub
        If A2.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = ExerciseData((PageIndex - 1) * 4 + 1).Answer + "A"
        Else
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "A", "")
        End If
    End Sub

    Private Sub A3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A3.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 3 Then Exit Sub
        If A3.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = ExerciseData((PageIndex - 1) * 4 + 2).Answer + "A"
        Else
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "A", "")
        End If
    End Sub
    Private Sub A4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles A4.Click
        If PageIndex = MaxPageID And LastPageExerciseQty <> 0 Then Exit Sub
        If A4.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = ExerciseData((PageIndex - 1) * 4 + 3).Answer + "A"
        Else
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "A", "")
        End If
    End Sub
    Private Sub B1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles B1.Click
        If B1.Checked Then
            ExerciseData((PageIndex - 1) * 4).Answer = ExerciseData((PageIndex - 1) * 4).Answer + "B"
        Else
            ExerciseData((PageIndex - 1) * 4).Answer = Replace(ExerciseData((PageIndex - 1) * 4).Answer, "B", "")
        End If
    End Sub

    Private Sub B2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles B2.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 2 Then Exit Sub
        If B2.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = ExerciseData((PageIndex - 1) * 4 + 1).Answer + "B"
        Else
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "B", "")
        End If
    End Sub

    Private Sub B3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles B3.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 3 Then Exit Sub
        If B3.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = ExerciseData((PageIndex - 1) * 4 + 2).Answer + "B"
        Else
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "B", "")
        End If
    End Sub
    Private Sub B4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles B4.Click
        If PageIndex = MaxPageID And LastPageExerciseQty <> 0 Then Exit Sub
        If B4.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = ExerciseData((PageIndex - 1) * 4 + 3).Answer + "B"
        Else
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "B", "")
        End If
    End Sub
    Private Sub C1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1.Click
        If C1.Checked Then
            ExerciseData((PageIndex - 1) * 4).Answer = ExerciseData((PageIndex - 1) * 4).Answer + "C"
        Else
            ExerciseData((PageIndex - 1) * 4).Answer = Replace(ExerciseData((PageIndex - 1) * 4).Answer, "C", "")
        End If
    End Sub

    Private Sub C2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C2.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 2 Then Exit Sub
        If C2.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = ExerciseData((PageIndex - 1) * 4 + 1).Answer + "C"
        Else
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "C", "")
        End If
    End Sub

    Private Sub C3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C3.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 3 Then Exit Sub
        If C3.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = ExerciseData((PageIndex - 1) * 4 + 2).Answer + "C"
        Else
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "C", "")
        End If
    End Sub
    Private Sub C4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles C4.Click
        If PageIndex = MaxPageID And LastPageExerciseQty <> 0 Then Exit Sub
        If C4.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = ExerciseData((PageIndex - 1) * 4 + 3).Answer + "C"
        Else
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "C", "")
        End If
    End Sub
    Private Sub D1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles D1.Click
        If D1.Checked Then
            ExerciseData((PageIndex - 1) * 4).Answer = ExerciseData((PageIndex - 1) * 4).Answer + "D"
        Else
            ExerciseData((PageIndex - 1) * 4).Answer = Replace(ExerciseData((PageIndex - 1) * 4).Answer, "D", "")
        End If
    End Sub

    Private Sub D2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles D2.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 2 Then Exit Sub
        If D2.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = ExerciseData((PageIndex - 1) * 4 + 1).Answer + "D"
        Else
            ExerciseData((PageIndex - 1) * 4 + 1).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "D", "")
        End If
    End Sub

    Private Sub D3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles D3.Click
        If PageIndex = MaxPageID And LastPageExerciseQty < 3 Then Exit Sub
        If D3.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = ExerciseData((PageIndex - 1) * 4 + 2).Answer + "D"
        Else
            ExerciseData((PageIndex - 1) * 4 + 2).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "D", "")
        End If
    End Sub
    Private Sub D4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles D4.Click
        If PageIndex = MaxPageID And LastPageExerciseQty <> 0 Then Exit Sub
        If D4.Checked Then
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = ExerciseData((PageIndex - 1) * 4 + 3).Answer + "D"
        Else
            ExerciseData((PageIndex - 1) * 4 + 3).Answer = Replace(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "D", "")
        End If
    End Sub

    Private Sub cmdLast_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLast.Click
        If PageIndex = 1 Then Exit Sub
        PageIndex = PageIndex - 1
        lblPageIndex.Text = "第" + PageIndex.ToString + "页"
        lbl1.Text = "第" + CStr((PageIndex - 1) * 4 + 1) + "题"
        txtExercise1.Text = ExerciseData((PageIndex - 1) * 4).Question
        txtAnswerA1.Text = ExerciseData((PageIndex - 1) * 4).A
        txtAnswerB1.Text = ExerciseData((PageIndex - 1) * 4).B
        txtAnswerC1.Text = ExerciseData((PageIndex - 1) * 4).C
        txtAnswerD1.Text = ExerciseData((PageIndex - 1) * 4).D
        A1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "A"), True, False)
        B1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "B"), True, False)
        C1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "C"), True, False)
        D1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "D"), True, False)
        lbl2.Text = "第" + CStr((PageIndex - 1) * 4 + 2) + "题"
        txtExercise2.Text = ExerciseData((PageIndex - 1) * 4 + 1).Question
        txtAnswerA2.Text = ExerciseData((PageIndex - 1) * 4 + 1).A
        txtAnswerB2.Text = ExerciseData((PageIndex - 1) * 4 + 1).B
        txtAnswerC2.Text = ExerciseData((PageIndex - 1) * 4 + 1).C
        txtAnswerD2.Text = ExerciseData((PageIndex - 1) * 4 + 1).D
        A2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "A"), True, False)
        B2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "B"), True, False)
        C2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "C"), True, False)
        D2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "D"), True, False)
        lbl3.Text = "第" + CStr((PageIndex - 1) * 4 + 3) + "题"
        txtExercise3.Text = ExerciseData((PageIndex - 1) * 4 + 2).Question
        txtAnswerA3.Text = ExerciseData((PageIndex - 1) * 4 + 2).A
        txtAnswerB3.Text = ExerciseData((PageIndex - 1) * 4 + 2).B
        txtAnswerC3.Text = ExerciseData((PageIndex - 1) * 4 + 2).C
        txtAnswerD3.Text = ExerciseData((PageIndex - 1) * 4 + 2).D
        A3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "A"), True, False)
        B3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "B"), True, False)
        C3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "C"), True, False)
        D3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "D"), True, False)
        lbl4.Text = "第" + CStr((PageIndex - 1) * 4 + 4) + "题"
        txtExercise4.Text = ExerciseData((PageIndex - 1) * 4 + 3).Question
        txtAnswerA4.Text = ExerciseData((PageIndex - 1) * 4 + 3).A
        txtAnswerB4.Text = ExerciseData((PageIndex - 1) * 4 + 3).B
        txtAnswerC4.Text = ExerciseData((PageIndex - 1) * 4 + 3).C
        txtAnswerD4.Text = ExerciseData((PageIndex - 1) * 4 + 3).D
        A4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "A"), True, False)
        B4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "B"), True, False)
        C4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "C"), True, False)
        D4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "D"), True, False)
    End Sub

    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If PageIndex >= MaxPageID Then Exit Sub
        PageIndex = PageIndex + 1
        Call ClearExamData()
        lblPageIndex.Text = "第" + PageIndex.ToString + "页"
        lbl1.Text = (PageIndex - 1) * 4 + 1
        txtExercise1.Text = ExerciseData((PageIndex - 1) * 4).Question
        txtAnswerA1.Text = ExerciseData((PageIndex - 1) * 4).A
        txtAnswerB1.Text = ExerciseData((PageIndex - 1) * 4).B
        txtAnswerC1.Text = ExerciseData((PageIndex - 1) * 4).C
        txtAnswerD1.Text = ExerciseData((PageIndex - 1) * 4).D
        A1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "A"), True, False)
        B1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "B"), True, False)
        C1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "C"), True, False)
        D1.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4).Answer, "D"), True, False)
        If PageIndex >= MaxPageID And LastPageExerciseQty < 2 Then
            lbl4.Text = ""
            lbl3.Text = ""
            lbl2.Text = ""
            Exit Sub
        End If
        lbl2.Text = "第" + CStr((PageIndex - 1) * 4 + 2) + "题"
        txtExercise2.Text = ExerciseData((PageIndex - 1) * 4 + 1).Question
        txtAnswerA2.Text = ExerciseData((PageIndex - 1) * 4 + 1).A
        txtAnswerB2.Text = ExerciseData((PageIndex - 1) * 4 + 1).B
        txtAnswerC2.Text = ExerciseData((PageIndex - 1) * 4 + 1).C
        txtAnswerD2.Text = ExerciseData((PageIndex - 1) * 4 + 1).D
        A2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "A"), True, False)
        B2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "B"), True, False)
        C2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "C"), True, False)
        D2.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 1).Answer, "D"), True, False)
        If PageIndex >= MaxPageID And LastPageExerciseQty < 3 Then
            lbl3.Text = ""
            lbl4.Text = ""
            Exit Sub
        End If
        lbl3.Text = "第" + CStr((PageIndex - 1) * 4 + 3) + "题"
        txtExercise3.Text = ExerciseData((PageIndex - 1) * 4 + 2).Question
        txtAnswerA3.Text = ExerciseData((PageIndex - 1) * 4 + 2).A
        txtAnswerB3.Text = ExerciseData((PageIndex - 1) * 4 + 2).B
        txtAnswerC3.Text = ExerciseData((PageIndex - 1) * 4 + 2).C
        txtAnswerD3.Text = ExerciseData((PageIndex - 1) * 4 + 2).D
        A3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "A"), True, False)
        B3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "B"), True, False)
        C3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "C"), True, False)
        D3.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 2).Answer, "D"), True, False)
        If PageIndex >= MaxPageID And LastPageExerciseQty < 4 Then
            lbl4.Text = ""
            Exit Sub
        End If
        lbl4.Text = "第" + CStr((PageIndex - 1) * 4 + 4) + "题"
        txtExercise4.Text = ExerciseData((PageIndex - 1) * 4 + 3).Question
        txtAnswerA4.Text = ExerciseData((PageIndex - 1) * 4 + 3).A
        txtAnswerB4.Text = ExerciseData((PageIndex - 1) * 4 + 3).B
        txtAnswerC4.Text = ExerciseData((PageIndex - 1) * 4 + 3).C
        txtAnswerD4.Text = ExerciseData((PageIndex - 1) * 4 + 3).D
        A4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "A"), True, False)
        B4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "B"), True, False)
        C4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "C"), True, False)
        D4.Checked = IIf(InStr(ExerciseData((PageIndex - 1) * 4 + 3).Answer, "D"), True, False)
    End Sub

    Private Sub frmExercise_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If cmdStart.Enabled = False And cmdGet.Enabled = False Then
            If MsgBox("答题还未完成，确定要纪录此次答题分数并退出么？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                e.Cancel = True
                Exit Sub
            End If
            Call cmdFinish_Click(cmdFinish, New System.EventArgs())
        End If
    End Sub

    Private Sub frmExercise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        If P_FormFlag = "EXAM" Then
            FrmUserInput.Close()
        End If
        Exam = False
        txtUserID.Text = P_UserName
        cmbDutyGroup.Items.Clear()
        cmbDutyGroup.Items.Add("")
        StrSql = "Exec GetUserInfo '" & P_UserName & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            txtUserName.Text = rs.Fields("UserName").Value.ToString
            txtShift.Text = rs.Fields("Shift").Value.ToString
            txtGroup.Text = rs.Fields("Group").Value.ToString
            'txtDeptGroup.Text = rs.Fields("DeptGroup").Value.ToString
            txtDuty.Text = rs.Fields("Duty").Value.ToString
            Group = rs.Fields("Group").Value.ToString
        End If
        'StrSql = "exec GetAllGroupList"
        'rs = Conn.Execute(StrSql)
        'rs = rs.NextRecordset
        'If rs.EOF = True Then Exit Sub
        'While rs.EOF = False
        '    Select Case rs.Fields("GroupName").Value
        '        Case "DUTYGROUP"
        '            cmbDutyGroup.Items.Add(rs.Fields("GroupValue").Value)
        '        Case Else
        '    End Select
        '    rs.MoveNext()
        'End While

        StrSql = "exec GetDutyGroup '" & P_UserName & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbDutyGroup.Items.Add(rs.Fields("DutyGroup").Value)
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdStart.Enabled = False And cmdGet.Enabled = False Then
            If MsgBox("答题还未完成，确定要纪录此次答题分数并退出么？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                Exit Sub
            End If
            Call cmdFinish_Click(cmdFinish, New System.EventArgs())
        End If
        Me.Close()
    End Sub

    Private Sub cmdGet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGet.Click
        Dim i As Integer
        Dim rs As New ADODB.Recordset
        cmdGet.Enabled = False
        'DeptGroup = txtDeptGroup.Text.Trim()
        DutyGroup = cmbDutyGroup.Text.Trim()
        'StrSql = "Exec GetAllQuestion N'" & Group & "',N'" & DeptGroup & "',N'" & DutyGroup & "'"
        StrSql = "Exec GetAllQuestion_New N'" & Group & "','" & P_UserName & "',N'" & DutyGroup & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        MaxPageID = IIf(rs.RecordCount Mod 4 = 0, rs.RecordCount / 4, rs.RecordCount \ 4 + 1)
        LastPageExerciseQty = rs.RecordCount Mod 4
        ReDim ExerciseData(rs.RecordCount)
        i = 0
        If Not rs.EOF Then
            Exam = True
        Else
            cmdGet.Enabled = True
            cmdStart.Enabled = True
            Exit Sub
        End If
        While Not rs.EOF
            ExerciseData(i).Question_Group = rs.Fields("Question_Group").Value.ToString
            ExerciseData(i).Question_Type = rs.Fields("Question_Type").Value.ToString
            ExerciseData(i).Question = rs.Fields("Exercise").Value.ToString
            ExerciseData(i).A = rs.Fields("A").Value.ToString.Trim
            ExerciseData(i).B = rs.Fields("B").Value.ToString.Trim
            ExerciseData(i).C = rs.Fields("C").Value.ToString.Trim
            ExerciseData(i).D = rs.Fields("D").Value.ToString.Trim
            ExerciseData(i).Answer = ""
            ExerciseData(i).CorrectAnswer = rs.Fields("Answer").Value.ToString.Trim
            i = i + 1
            rs.MoveNext()
        End While
        StrSql = "select isnull(passscore,'0') as passscore from DutyGroup_QuestionQty where [group]= N'" & Group & "' and dutygroup=N'" & DutyGroup & "' and BU='" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If Not rs.EOF Then
            sPassScore = rs.Fields("passscore").Value.ToString
        Else
            sPassScore = "60"
        End If
        MsgBox("抽题完毕，可以开始答题")
        cmdGet.Enabled = True
        cmdStart.Enabled = True
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        cmdGet.Enabled = False
        cmdStart.Enabled = False
        cmdFinish.Enabled = True
        cmbDutyGroup.Enabled = False
        PageIndex = 1
        Timer1.Enabled = True
        Call ClearExamData()
        If Exam = False Then
            MsgBox("没有抽取到试题！")
            cmdGet.Enabled = True
            cmdStart.Enabled = False
            cmdFinish.Enabled = False
            cmbDutyGroup.Enabled = True
            Timer1.Enabled = False
            Exit Sub
        End If
        txtExercise1.Text = ExerciseData(0).Question
        txtAnswerA1.Text = ExerciseData(0).A
        txtAnswerB1.Text = ExerciseData(0).B
        txtAnswerC1.Text = ExerciseData(0).C
        txtAnswerD1.Text = ExerciseData(0).D
        txtExercise2.Text = ExerciseData(1).Question
        txtAnswerA2.Text = ExerciseData(1).A
        txtAnswerB2.Text = ExerciseData(1).B
        txtAnswerC2.Text = ExerciseData(1).C
        txtAnswerD2.Text = ExerciseData(1).D
        txtExercise3.Text = ExerciseData(2).Question
        txtAnswerA3.Text = ExerciseData(2).A
        txtAnswerB3.Text = ExerciseData(2).B
        txtAnswerC3.Text = ExerciseData(2).C
        txtAnswerD3.Text = ExerciseData(2).D
        txtExercise4.Text = ExerciseData(3).Question
        txtAnswerA4.Text = ExerciseData(3).A
        txtAnswerB4.Text = ExerciseData(3).B
        txtAnswerC4.Text = ExerciseData(3).C
        txtAnswerD4.Text = ExerciseData(3).D
        GroupBox1.Visible = True
        ExamGroup.Visible = True
        Conn.Execute("Exec InsertExerciseResult '" & txtUserID.Text.Trim & "',N'" & cmbDutyGroup.Text.Trim & "','Start','Text',0,'" & P_BU & "' ") '0001
    End Sub

    Public Sub cmdFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinish.Click
        Dim i, j, k As Integer
        'Dim Score As Integer
        Dim Score As Decimal
        Dim s As Decimal
        Dim AnswerFlag As Boolean
        Dim Result As String
        Dim rs As New ADODB.Recordset
        cmbDutyGroup.Enabled = True
        cmdGet.Enabled = True
        cmdFinish.Enabled = False
        Score = 0
        k = UBound(ExerciseData)
        StrSql = "exec GetInfo '100','" & UBound(ExerciseData) & "','1'"
        rs = Conn.Execute(StrSql)
        If Not rs.EOF Then
            s = rs.Fields("result").Value.ToString
        Else
            s = "0"
        End If

        's = 100 \ UBound(ExerciseData)
        's = s.ToString.Substring(0, 3)
        's = s.ToString("0." & New String("0", 0))
        For i = 0 To UBound(ExerciseData) - 1
            AnswerFlag = True
            If Len(ExerciseData(i).Answer.Trim) = Len(ExerciseData(i).CorrectAnswer.Trim) Then
                For j = 1 To Len(ExerciseData(i).Answer)
                    If InStr(ExerciseData(i).CorrectAnswer, Mid(ExerciseData(i).Answer, j, 1)) <= 0 Then
                        AnswerFlag = False
                        Exit For
                    End If
                Next
            Else
                AnswerFlag = False
            End If
            If AnswerFlag = True Then Score = Score + s
        Next
        Score = Score.ToString("0." & New String("0", 0))
        If Score < sPassScore Then
            Result = "不合格"
        Else
            Result = "合格"
        End If
        GroupBox1.Visible = False
        ExamGroup.Visible = False
        Conn.Execute("Exec InsertExerciseResult '" & txtUserID.Text.Trim & "',N'" & cmbDutyGroup.Text.Trim & "','End','Text','" & Score.ToString & "','" & P_BU & "'") '0001
        MsgBox("答题完成，您此次答题的得分是" + Score.ToString + ",合格分数是:" + sPassScore + ",考试结果:" + Result, MsgBoxStyle.Information, "Training")
        If MsgBox("文字题答题已经完成，是否要进入图片题答题界面？", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        'FrmExercisePhoto.MdiParent = frmMain
        'FrmExercisePhoto.Show()
        P_FormFlag = "PHO_TEST"
        FrmUserInput.MdiParent = Me
        FrmUserInput.Show()
    End Sub

    Private Sub A2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles A2.CheckedChanged

    End Sub

    Private Sub UserGroup_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UserGroup.Enter

    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Clipboard.Clear()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class