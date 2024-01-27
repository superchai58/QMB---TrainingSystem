Public Class frmExamSchedule

    Private Sub frmExamSchedule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rst As New ADODB.Recordset

        'StrSql = "select distinct Question_Type  from OP_ExamSubject where BU=" & sq(P_BU) & " AND Question_Type <> 'Practice'"     'superchai add 20230825
        StrSql = "select distinct Question_Type  from OP_ExamSubject where BU=" & sq(P_BU)     'superchai add 20230825
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamType.Items.Add(rst.Fields("Question_Type").Value.ToString())
                rst.MoveNext()
            End While
        End If

        '---------------superchai add 20230920 (B)--------------------
        StrSql = ""
        If TStation.ToUpper() = "TRAINING" Then
            'StrSql = "select distinct ID  from OP_ExamSchedule where BU=" & sq(P_BU) & " order by ID  desc"
            'StrSql = "select distinct ID  from OP_ExamSchedule where BU=" & sq(P_BU) & " AND Station LIKE 'OP%'"
            StrSql = "Select distinct A.ID  from OP_ExamSchedule As A With(nolock) inner join OP_ExamSubject As B With(nolock) On A.Exam_No = B.Exam_NO And A.BU = B.BU where A.BU=" & sq(P_BU) & " AND B.Exam_Type = 'OP'"
        Else
            'StrSql = "Select distinct ID  from OP_ExamSchedule where BU=" & sq(P_BU) & " order by ID  desc"
            StrSql = "Select distinct A.ID  from OP_ExamSchedule As A With(nolock) inner join OP_ExamSubject As B With(nolock) On A.Exam_No = B.Exam_NO And A.BU = B.BU where A.BU=" & sq(P_BU) & " AND B.Exam_Type = 'IDL'"
        End If
        '---------------superchai add 20230920 (E)--------------------

        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboScheduleID.Items.Add(rst.Fields("ID").Value.ToString())
                rst.MoveNext()
            End While
        End If
        cmdAdd.Enabled = False
        cmdEnd.Enabled = False

        'superchai add 20231114 (B)
        cboExamType_SelectedIndexChanged(cboExamType, New EventArgs())
        cboExamTypePicture_SelectedIndexChanged(cboExamTypePicture, New EventArgs())
        cboExamTypePratice_SelectedIndexChanged(cboExamTypePratice, New EventArgs())
        'superchai add 20231114 (E)
    End Sub

    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        RefreshData(Me.cboScheduleID.Text.Trim)
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim rst As New ADODB.Recordset
        Dim StartTime As String
        Dim EndTime As String

        StartTime = Me.dtpStart.Value.ToString("yyyyMMdd")
        EndTime = Me.dtpEnd.Value.ToString("yyyyMMdd")
        If ValidData() = False Then Exit Sub

        '------------------superchai add 20230825 (B)-------------------
        If cboExamNo.Text.Trim() <> "" Then
            If ChkPratice.Checked = True Then
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStation.Text.Trim) & ",N" & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStation.Text.Trim) & ",N" & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------
            Else
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                sq(txtStation.Text.Trim) & ",N" & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                sq(txtStation.Text.Trim) & ",N" & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------
            End If

            rst = Conn.Execute(StrSql)

            If rst.EOF = False Then
                MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
                If rst.Fields("result").Value = 0 Then
                    'RefreshData("")
                End If

            Else
                MsgBox("Failed to add test plan!", MsgBoxStyle.Information, "OP Exam")
            End If
        End If
        If cboExamNoPicture.Text.Trim() <> "" Then
            If ChkPratice.Checked = True Then
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPicture.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPicture.Text.Trim) & ",N" & sq(txtModelPicture.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePicture.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPicture.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPicture.Text.Trim) & ",N" & sq(txtModelPicture.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePicture.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------
            Else
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPicture.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPicture.Text.Trim) & ",N" & sq(txtModelPicture.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePicture.Text.Trim) & "," & sq(P_BU) & ", 'N', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPicture.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                sq(txtStationPicture.Text.Trim) & ",N" & sq(txtModelPicture.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePicture.Text.Trim) & "," & sq(P_BU) & ", 'N', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------
            End If
            rst = Conn.Execute(StrSql)

            If rst.EOF = False Then
                MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
                If rst.Fields("result").Value = 0 Then
                    'RefreshData("")
                End If

            Else
                MsgBox("Failed to add test plan!", MsgBoxStyle.Information, "OP Exam")
            End If
        End If
        If cboExamNoPratice.Text.Trim() <> "" Then
            If ChkPratice.Checked = True Then
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPratice.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPractice.Text.Trim) & ",N" & sq(txtModelPractice.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePratice.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPratice.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPractice.Text.Trim) & ",N" & sq(txtModelPractice.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePratice.Text.Trim) & "," & sq(P_BU) & ", 'Y', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------
            Else
                '-----------superchai add 20231028 (B)-------------
                If TStation.ToUpper() = "TRAINING" Then
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPratice.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                    sq(txtStationPractice.Text.Trim) & ",N" & sq(txtModelPractice.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePratice.Text.Trim) & "," & sq(P_BU) & ", 'N', 'OP'"
                Else
                    StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNoPratice.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & ",N" &
                sq(txtStationPractice.Text.Trim) & ",N" & sq(txtModelPractice.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamTypePratice.Text.Trim) & "," & sq(P_BU) & ", 'N', 'IDL'"
                End If
                '-----------superchai add 20231028 (E)-------------                
            End If
            rst = Conn.Execute(StrSql)

            If rst.EOF = False Then
                MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
                If rst.Fields("result").Value = 0 Then
                End If

            Else
                MsgBox("Failed to add test plan!", MsgBoxStyle.Information, "OP Exam")
            End If
        End If
        RefreshData("")
        '------------------superchai add 20230825 (E)-------------------

        'superchai comment
        'StrSql = "Exec OP_SetSchedule_TEST  'Insert'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(StartTime) & "," & sq(EndTime) & "," &
        '    sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y'"


        'Set Default (B)
        cboScheduleID.Text = ""
        'cboExamType.Text = ""
        txtStation.Text = ""
        cboExamNo.Text = ""
        txtModel.Text = ""

        'cboExamTypePicture.Text = ""
        txtStationPicture.Text = ""
        cboExamNoPicture.Text = ""
        txtModelPicture.Text = ""

        'cboExamTypePratice.Text = ""
        txtStationPractice.Text = ""
        cboExamNoPratice.Text = ""
        txtModelPractice.Text = ""

        txtTeacher.Text = ""
        'Set Default (E)

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim rst As New ADODB.Recordset
        If cboScheduleID.Text.Trim = "" Then Exit Sub

        '------------------superchai add 20230825 (B)-------------------
        If cboExamNo.Text.Trim() <> "" Then
            Dim name As String = cboExamNo.Text.Trim()
            Dim nameParts As String() = name.Split(">")
            Dim nameExamNo As String = nameParts(0)

            If ChkPratice.Checked = True Then
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', ''"
            Else
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', ''"
            End If
        End If
        If cboExamNoPicture.Text.Trim() <> "" Then
            Dim name As String = cboExamNoPicture.Text.Trim()
            Dim nameParts As String() = name.Split(">")
            Dim nameExamNo As String = nameParts(0)

            If ChkPratice.Checked = True Then
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', ''"
            Else
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', ''"
            End If
        End If
        If cboExamNoPratice.Text.Trim() <> "" Then
            Dim name As String = cboExamNoPratice.Text.Trim()
            Dim nameParts As String() = name.Split(">")
            Dim nameExamNo As String = nameParts(0)

            If ChkPratice.Checked = True Then
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', ''"
            Else
                StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & ",'" & nameExamNo.Trim() & "',N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
                sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', ''"
            End If
        End If
        '------------------superchai add 20230825 (E)-------------------

        'superchai comments
        'StrSql = "Exec OP_SetSchedule_TEST  'Delete'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
        '    sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)

        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MsgBox(rst.Fields("Description").Value, MsgBoxStyle.Information, "OP Exam")
            If rst.Fields("result").Value = 0 Then
                RefreshData("")
            End If
        Else
            MsgBox("删除考试计划失败！", MsgBoxStyle.Information, "OP Exam")
        End If

    End Sub

    Private Function ValidData() As Boolean
        Dim StartTime As String
        Dim EndTime As String

        ValidData = False

        StartTime = Me.dtpStart.Value.ToString("yyyyMMdd")
        EndTime = Me.dtpEnd.Value.ToString("yyyyMMdd")

        If StartTime.ToString >= EndTime.ToString Then
            MsgBox("请设置正确的考试计划有效时间！", MsgBoxStyle.Information, "Error")
            Exit Function
        End If
        If cboScheduleID.Text.Trim = "" Then
            MsgBox("请首先选择考试编号！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        If ChkPratice.Checked = False Then
            If cboExamType.Text.Trim = "" And cboExamTypePicture.Text.Trim = "" Then
                MsgBox("请首先选择试卷类型！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If
            If cboExamNo.Text.Trim = "" And cboExamNoPicture.Text.Trim = "" Then
                MsgBox("请首先选择试卷编号！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If

            If txtStation.Text.Trim = "" And txtStationPicture.Text.Trim = "" Then
                MsgBox("请输入Station！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If
        ElseIf ChkPratice.Checked = True Then
            If cboExamType.Text.Trim = "" And cboExamTypePicture.Text.Trim = "" And cboExamTypePratice.Text.Trim = "" Then
                MsgBox("请首先选择试卷类型！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If
            If cboExamNo.Text.Trim = "" And cboExamNoPicture.Text.Trim = "" And cboExamNoPratice.Text.Trim = "" Then
                MsgBox("请首先选择试卷编号！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If

            If txtStation.Text.Trim = "" And txtStationPicture.Text.Trim = "" And txtStationPractice.Text.Trim = "" Then
                MsgBox("请输入Station！", MsgBoxStyle.Critical, "Error")
                Exit Function
            End If
        End If

        If txtTeacher.Text.Trim = "" Then
            MsgBox("请输入讲师！", MsgBoxStyle.Critical, "Error")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Sub RefreshData(ByVal strExamScheduleID As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        'StrSql = "Exec OP_GetExamScheduleInfo " & sq(strExamScheduleID) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)
        'trSql = "Exec OP_GetExamScheduleInfo_Test " & sq(strExamScheduleID) & "," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & "," & sq(TStation.ToUpper())       'superchai add 20230920

        '-----------superchai add 20230824 (B)-------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "Exec OP_GetExamScheduleInfo_Test " & sq(strExamScheduleID) & ", '', " & sq(P_BU) & ", 'OP'"       'superchai add 20230920
        Else
            StrSql = "Exec OP_GetExamScheduleInfo_Test " & sq(strExamScheduleID) & ", '', " & sq(P_BU) & ", 'IDL'"       'superchai add 20230920
        End If
        '-----------superchai add 20230824 (E)-------------

        'StrSql = "Exec OP_GetExamScheduleInfo_Test " & sq(strExamScheduleID) & ", '', " & sq(P_BU) & "," & sq(TStation.ToUpper())       'superchai add 20230920
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamScheduleInfo")
            DataGV.DataSource = ds.Tables("ExamScheduleInfo")
            DataGV.Refresh()
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If cmdEnd.Enabled = True Then
            MsgBox("请先点击End", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Me.Close()
    End Sub

    Private Sub cboExamType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboExamType.SelectedIndexChanged
        Dim rst As New ADODB.Recordset
        cboExamNo.Items.Clear()
        cboExamNo.Text = ""
        '-----------superchai add 20230824 (B)-------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'OP' order by Exam_No"
        Else
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'IDL' order by Exam_No"
        End If
        '-----------superchai add 20230824 (E)-------------

        'StrSql = "select * from OP_ExamSubject where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " order by Exam_No"       superchai commnents
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamNo.Items.Add(rst.Fields("Title").Value.ToString() + ">" + rst.Fields("Exam_No").Value.ToString())
                rst.MoveNext()
            End While
        End If

        '-----------superchai test (B)------------
        'StrSql = "select " & "'" & TStation.ToUpper() & "'"
        'rst = Conn.Execute(StrSql)
        '-----------superchai test (E)------------
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Dim rst As New ADODB.Recordset
        Dim MaxID As String
        MaxID = 1

        '---------------superchai add 20230920 (B)-------------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "select isnull(Max(A.ID),0) as MaxID  from OP_ExamSchedule AS A With(nolock) inner join OP_ExamSubject AS B With(nolock) ON A.Exam_No = B.Exam_NO And A.BU = B.BU where A.BU=" & sq(P_BU) & " AND B.Exam_Type = 'OP'"      'superchai add 20231021
            'StrSql = "select isnull(Max(ID),0) as MaxID  from OP_ExamSchedule where BU=" & sq(P_BU) & " AND Station LIKE 'OP%'"
        Else
            StrSql = "select isnull(Max(A.ID),0) as MaxID  from OP_ExamSchedule AS A With(nolock) inner join OP_ExamSubject AS B With(nolock) ON A.Exam_No = B.Exam_NO And A.BU = B.BU where A.BU=" & sq(P_BU) & " AND B.Exam_Type = 'IDL'"      'superchai add 20231021
            'StrSql = "select isnull(Max(ID),0) as MaxID  from OP_ExamSchedule where BU=" & sq(P_BU) & " AND Station LIKE 'IDL%' AND TransDT > '20230905090501'"
        End If
        '---------------superchai add 20230920 (E)-------------------

        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            MaxID = rst.Fields("MaxID").Value.ToString()
            MaxID = CInt(MaxID) + 1
        End If
        '    If MaxID = "" Then
        'MaxID = "1"
        'End If
        cboScheduleID.Items.Add(MaxID)
        cmdAdd.Enabled = True
        cmdDelete.Enabled = False
        cmdExit.Enabled = False
        cmdEnd.Enabled = True
        cmdQuery.Enabled = False
        cmdStart.Enabled = False
        MsgBox("请Add之后记得要End方能生效！", MsgBoxStyle.Critical, "Error")
    End Sub

    Private Sub cmdEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEnd.Click
        Dim rst As New ADODB.Recordset
        cmdAdd.Enabled = False
        cmdDelete.Enabled = True
        cmdExit.Enabled = True
        cmdEnd.Enabled = False
        cmdQuery.Enabled = True
        cmdStart.Enabled = True

        '------------------superchai add 20230825 (B)-------------------
        If ChkPratice.Checked = True Then
            StrSql = "Exec OP_SetSchedule_TEST  'End'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
            sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & " ," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'Y', ''"
        Else
            StrSql = "Exec OP_SetSchedule_TEST  'End'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
            sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & " ," & sq(cboExamType.Text.Trim) & "," & sq(P_BU) & ", 'N', ''"
        End If
        '------------------superchai add 20230825 (E)-------------------

        'superchai comments
        'StrSql = "Exec OP_SetSchedule_TEST  'End'," & sq(cboScheduleID.Text.Trim) & "," & sq(cboExamNo.Text.Trim) & ",N" & sq(txtTeacher.Text.Trim) & "," & sq(dtpStart.Value.ToString("yyyyMMdd")) & "," & sq(dtpEnd.Value.ToString("yyyyMMdd")) & "," &
        '    sq(txtStation.Text.Trim) & "," & sq(txtModel.Text.Trim) & "," & sq(P_UserName) & " ," & sq(cboExamType.Text.Trim) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
    End Sub

    Private Sub DataGV_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGV.DoubleClick
        FillTextCtrl(DataGV)
    End Sub
    Private Sub FillTextCtrl(ByVal DataGV As DataGridView)
        If DataGV.RowCount > 0 And DataGV.CurrentRow.Index >= 0 Then
            With DataGV
                cboScheduleID.Text = .Item("ID", .CurrentRow.Index).Value.ToString()
                'cboExamType.Text = .Item("Question_type", .CurrentRow.Index).Value.ToString()
                If .Item("Question_type", .CurrentRow.Index).Value.ToString() = "Theory_Auto" Then
                    cboExamNo.Text = .Item("Exam_No", .CurrentRow.Index).Value.ToString() + ">"
                    txtStation.Text = .Item("Station", .CurrentRow.Index).Value.ToString()
                    txtModel.Text = .Item("Category", .CurrentRow.Index).Value.ToString()
                ElseIf .Item("Question_type", .CurrentRow.Index).Value.ToString() = "Picture" Then
                    cboExamNoPicture.Text = .Item("Exam_No", .CurrentRow.Index).Value.ToString() + ">"
                    txtStationPicture.Text = .Item("Station", .CurrentRow.Index).Value.ToString()
                    txtModelPicture.Text = .Item("Category", .CurrentRow.Index).Value.ToString()
                ElseIf .Item("Question_type", .CurrentRow.Index).Value.ToString() = "Practice" Then
                    cboExamNoPratice.Text = .Item("Exam_No", .CurrentRow.Index).Value.ToString() + ">"
                    txtStationPractice.Text = .Item("Station", .CurrentRow.Index).Value.ToString()
                    txtModelPractice.Text = .Item("Category", .CurrentRow.Index).Value.ToString()
                End If

                txtTeacher.Text = .Item("Teacher", .CurrentRow.Index).Value.ToString()
            End With
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cboScheduleID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboScheduleID.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtStation_TextChanged(sender As Object, e As EventArgs) Handles txtStation.TextChanged

    End Sub

    Private Sub cboExamTypePicture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamTypePicture.SelectedIndexChanged
        Dim rst As New ADODB.Recordset
        cboExamNoPicture.Items.Clear()
        cboExamNoPicture.Text = ""
        '-----------superchai add 20230824 (B)-------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamTypePicture.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'OP' order by Exam_No"
        Else
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamTypePicture.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'IDL' order by Exam_No"
        End If
        '-----------superchai add 20230824 (E)-------------

        'StrSql = "select * from OP_ExamSubject where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " order by Exam_No"       superchai commnents
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamNoPicture.Items.Add(rst.Fields("Title").Value.ToString() + ">" + rst.Fields("Exam_No").Value.ToString())
                rst.MoveNext()
            End While
        End If

        '-----------superchai test (B)------------
        'StrSql = "select " & "'" & TStation.ToUpper() & "'"
        'rst = Conn.Execute(StrSql)
        '-----------superchai test (E)------------
    End Sub

    Private Sub cboExamTypePratice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamTypePratice.SelectedIndexChanged
        Dim rst As New ADODB.Recordset
        cboExamNoPratice.Items.Clear()
        cboExamNoPratice.Text = ""
        '-----------superchai add 20230824 (B)-------------
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamTypePratice.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'OP' order by Exam_No"
        Else
            StrSql = "select * from OP_ExamSubject WITH(NOLOCK) where Question_Type = " & sq(cboExamTypePratice.Text.Trim) & " and BU=" & sq(P_BU) & " AND Exam_Type = 'IDL' order by Exam_No"
        End If
        '-----------superchai add 20230824 (E)-------------

        'StrSql = "select * from OP_ExamSubject where Question_Type = " & sq(cboExamType.Text.Trim) & " and BU=" & sq(P_BU) & " order by Exam_No"       superchai commnents
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            While Not rst.EOF
                cboExamNoPratice.Items.Add(rst.Fields("Title").Value.ToString() + ">" + rst.Fields("Exam_No").Value.ToString())
                rst.MoveNext()
            End While
        End If

        '-----------superchai test (B)------------
        'StrSql = "select " & "'" & TStation.ToUpper() & "'"
        'rst = Conn.Execute(StrSql)
        '-----------superchai test (E)------------
    End Sub

    Private Sub cboExamNo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamNo.SelectedIndexChanged
        Dim name As String = cboExamNo.Text.Trim()
        Dim nameParts As String() = name.Split(">")
        txtStation.Text = nameParts(0) ' + "-" + nameParts(1)
    End Sub

    Private Sub cboExamNoPicture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamNoPicture.SelectedIndexChanged
        Dim name1 As String = cboExamNoPicture.Text.Trim()
        Dim nameParts1 As String() = name1.Split(">")
        txtStationPicture.Text = nameParts1(0) '+ "-" + nameParts1(1)
    End Sub

    Private Sub cboExamNoPratice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboExamNoPratice.SelectedIndexChanged
        Dim name2 As String = cboExamNoPratice.Text.Trim()
        Dim nameParts2 As String() = name2.Split(">")
        txtStationPractice.Text = nameParts2(0) '+ "-" + nameParts2(1)
    End Sub

    Private Sub ChkPratice_CheckedChanged(sender As Object, e As EventArgs) Handles ChkPratice.CheckedChanged
        If ChkPratice.Checked = True Then
            cboExamNoPratice.Enabled = True
            txtModelPractice.Enabled = True
        Else
            cboExamNoPratice.Enabled = False
            txtModelPractice.Enabled = False
        End If

    End Sub
End Class

