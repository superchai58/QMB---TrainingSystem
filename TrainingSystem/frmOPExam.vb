Imports System.IO

Public Class frmOPExam

    Dim ExerciseData(200000) As ExamData
    Public mActionType As String      ''Exam/PreView
    Public mHasSubmit As Boolean
    Public mExamSTime As DateTime
    Public mExamLength As Integer     '60 Minutes
    Public mPassScore As Decimal
    Public ExamType As String

    Public mExamNo As Integer
    Public mScheduleID As Integer
    Public mdsExam As DataSet
    Public mdsInvestigationExam As DataSet
    Dim pageQCnt As Integer
    Dim anwserCnt As Integer
    Dim ListQuestion As New ArrayList '
    Dim ListAnwser As New ArrayList '
    Dim QHeight As Integer
    Dim AnwserHeight As Integer
    Dim SpaceHeight As Integer             '试题与答案间距

    Dim Space2Height As Integer            '答案间距
    Dim Space3Height As Integer            '试题与试题间距

    Dim SpaceOneContent As Integer         '一道试题所占间距


    Private Sub frmOPExam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mExamLength = 60         '答题时间
        mPassScore = 80          '及格分数

        pageQCnt = 25
        anwserCnt = 4

        QHeight = 60
        AnwserHeight = 26
        SpaceHeight = 18          '试题与答案间距

        Space2Height = 6         '答案间距
        Space3Height = 40         '试题与试题间距

        SpaceOneContent = QHeight + SpaceHeight + Space2Height * (anwserCnt - 1) + AnwserHeight * anwserCnt
        ListAnwser.Clear()
        ListQuestion.Clear()
        IniExamInfo()

    End Sub

    ''for test control location set
    Private Sub IniQuestionCtrl(ByVal pageIndex As Integer)
        Dim indexQ As Integer
        Dim indexA As Integer
        Dim indexQCurPage As Integer
        Dim indexACurQuestion As Integer

        Me.PanelContent.Controls.Clear()
        For indexQCurPage = 1 To pageQCnt

            Dim FirstLabel As New Label             '定义文本框对象

            Dim FirstTextBox As New TextBox            '定义文本框对象

            Dim FirstGroupBox As New GroupBox
            FirstLabel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstTextBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstGroupBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))

            indexQ = (pageIndex - 1) * pageQCnt + indexQCurPage

            Me.PanelContent.Controls.Add(FirstLabel)
            Me.PanelContent.Controls.Add(FirstTextBox)
            Me.PanelContent.Controls.Add(FirstGroupBox)

            FirstLabel.Tag = "试题" & indexQ.ToString
            FirstLabel.Text = "试题" & indexQ.ToString
            FirstLabel.Width = 60

            FirstLabel.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            FirstLabel.Left = 10

            FirstGroupBox.Text = "试题" & indexQ.ToString & " 答案："
            FirstGroupBox.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + QHeight + SpaceHeight
            FirstGroupBox.Left = 100
            FirstGroupBox.Width = 3000
            FirstGroupBox.Height = AnwserHeight * anwserCnt + Space2Height * (anwserCnt - 1) + 15

            ListQuestion.Add(FirstTextBox)
            ListQuestion.Item(indexQ - 1).top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            ListQuestion.Item(indexQ - 1).left = 100
            ListQuestion.Item(indexQ - 1).Width = 3000
            ListQuestion.Item(indexQ - 1).Height = QHeight
            ListQuestion.Item(indexQ - 1).MultiLine = True
            'ListQuestion.Item(indexQ - 1).readonly = True
            FirstTextBox.TabIndex = indexQ
            ListQuestion.Item(indexQ - 1).Text = "试题" & indexQ.ToString & "  具体内容"

            For indexACurQuestion = 1 To anwserCnt
                'Dim FirstCheckBox As New CheckBox          '定义复选框对象
                Dim FirstRadioButton As New RadioButton           '定义复选框对象

                indexA = (indexQ - 1) * anwserCnt + indexACurQuestion
                FirstGroupBox.Controls.Add(FirstRadioButton)

                ListAnwser.Add(FirstRadioButton)
                'ListAnwser.Item(indexA - 1).top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + Space2Height * (indexACurQuestion - 1) + SpaceHeight
                ListAnwser.Item(indexA - 1).top = (AnwserHeight + Space2Height) * (indexACurQuestion - 1) + 15
                ListAnwser.Item(indexA - 1).left = 20
                FirstTextBox.TabIndex = indexQ + indexA
                ListAnwser.Item(indexA - 1).Text = "试题" & indexQ.ToString & "，答案" & indexACurQuestion.ToString
                AddHandler FirstRadioButton.Click, AddressOf RadioCtrlArrayClick          '给这组动态控件定义click事件的触发函数LblControlArrayClick 。


            Next indexACurQuestion
        Next indexQCurPage

    End Sub
    Private Sub InPracticeQuestionCtrl(ByVal dtExamContent As DataTable)
        Dim indexQ As Integer
        Dim indexQCurPage As Integer
        Dim AnswerItem As String

        AnswerItem = ""
        pageQCnt = dtExamContent.Rows.Count
        Me.PanelContent.Controls.Clear()
        For indexQCurPage = 1 To pageQCnt

            Dim FirstLabel As New Label             '定义文本框对象
            Dim FirstTextBox As New TextBox            '定义文本框对象
            Dim FirstGroupBox As New GroupBox
            FirstLabel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstTextBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstGroupBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            indexQ = indexQCurPage

            Call InPracticeExamQuestion(indexQ - 1, dtExamContent.Rows(indexQ - 1))
            Me.PanelContent.Controls.Add(FirstLabel)
            Me.PanelContent.Controls.Add(FirstTextBox)
            Me.PanelContent.Controls.Add(FirstGroupBox)


            FirstLabel.Tag = "试题" & indexQ.ToString
            FirstLabel.Text = "试题" & indexQ.ToString
            FirstLabel.Width = 60

            FirstLabel.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            FirstLabel.Left = 10
            FirstGroupBox.Text = "试题" & indexQ.ToString & " 答案："
            FirstGroupBox.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + QHeight + SpaceHeight
            FirstGroupBox.Left = 100
            FirstGroupBox.Width = 3000
            FirstGroupBox.Height = AnwserHeight * anwserCnt + Space2Height * (anwserCnt - 1) + 15

            ListQuestion.Add(FirstTextBox)
            ListQuestion.Item(indexQ - 1).top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            ListQuestion.Item(indexQ - 1).left = 100
            ListQuestion.Item(indexQ - 1).Width = 3000
            ListQuestion.Item(indexQ - 1).Height = QHeight
            ListQuestion.Item(indexQ - 1).MultiLine = True
            'ListQuestion.Item(indexQ - 1).readonly = True
            FirstTextBox.TabIndex = indexQ
            'ListQuestion.Item(indexQ - 1).Text = "试题" & indexQ.ToString & "  具体内容"
            ListQuestion.Item(indexQ - 1).Text = ExerciseData(indexQ - 1).Question
            ListAnwser.Add(FirstGroupBox)

        Next indexQCurPage

    End Sub

    Private Sub IniQuestionCtrl(ByVal dtExamContent As DataTable)
        Dim indexQ As Integer
        Dim indexA As Integer
        Dim indexQCurPage As Integer
        Dim indexACurQuestion As Integer
        Dim AnswerItem As String

        AnswerItem = ""
        pageQCnt = dtExamContent.Rows.Count
        Me.PanelContent.Controls.Clear()
        For indexQCurPage = 1 To pageQCnt

            Dim FirstLabel As New Label             '定义文本框对象
            Dim FirstTextBox As New TextBox            '定义文本框对象
            Dim FirstGroupBox As New GroupBox
            Dim FirstPicture As New PictureBox
            Dim FirstButton As New Button
            FirstLabel.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstTextBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
            FirstGroupBox.Font = New System.Drawing.Font("宋体", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))

            indexQ = indexQCurPage

            Call IniExamQuestion(indexQ - 1, dtExamContent.Rows(indexQ - 1))


            Me.PanelContent.Controls.Add(FirstLabel)
            Me.PanelContent.Controls.Add(FirstTextBox)
            Me.PanelContent.Controls.Add(FirstGroupBox)
            Me.PanelContent.Controls.Add(FirstPicture)
            Me.PanelContent.Controls.Add(FirstButton)

            FirstLabel.Tag = "试题" & indexQ.ToString
            FirstLabel.Text = "试题" & indexQ.ToString
            FirstLabel.Width = 60
            If ExerciseData(indexQ - 1).PictureName <> "" Then
                SpaceHeight = 40

                FirstPicture.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + SpaceHeight + 20
                FirstPicture.Left = 100
                FirstPicture.Height = 80
                FirstPicture.Width = 80

                Dim inputBytes() As Byte = System.Convert.FromBase64String(ExerciseData(indexQ - 1).PictureName)
                Dim ms As MemoryStream = New MemoryStream(inputBytes)
                ms.Position = 0
                Dim img As Image = Image.FromStream(ms)
                ms.Close()
                '   FirstPicture.Image = Image.FromFile(PhotoPath & ExerciseData(indexQ - 1).PictureName)
                FirstPicture.Image = img
                FirstPicture.SizeMode = "3"

                FirstButton.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + SpaceHeight + 20
                FirstButton.Left = 200
                FirstButton.Height = 40
                FirstButton.Width = 40
                FirstButton.Text = "显示全图"
                FirstButton.Name = "Button" & indexQ.ToString
                AddHandler FirstButton.Click, AddressOf ButtonCtrlArrayClick          '给这组动态控件定义click事件的触发函数LblControlArrayClick 。

            End If
            FirstLabel.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            FirstLabel.Left = 10


            FirstGroupBox.Text = "试题" & indexQ.ToString & " 答案："
            FirstGroupBox.Top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + QHeight + SpaceHeight
            FirstGroupBox.Left = 100
            FirstGroupBox.Width = 3000
            FirstGroupBox.Height = AnwserHeight * anwserCnt + Space2Height * (anwserCnt - 1) + 15

            ListQuestion.Add(FirstTextBox)
            ListQuestion.Item(indexQ - 1).top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + 1
            ListQuestion.Item(indexQ - 1).left = 110
            ListQuestion.Item(indexQ - 1).Width = 3000
            ListQuestion.Item(indexQ - 1).Height = QHeight
            ListQuestion.Item(indexQ - 1).MultiLine = True
            'ListQuestion.Item(indexQ - 1).readonly = True
            FirstTextBox.TabIndex = indexQ
            'ListQuestion.Item(indexQ - 1).Text = "试题" & indexQ.ToString & "  具体内容"
            ListQuestion.Item(indexQ - 1).Text = ExerciseData(indexQ - 1).Question

            For indexACurQuestion = 1 To anwserCnt
                Dim FirstRadioButton As New RadioButton           '定义复选框对象

                indexA = (indexQ - 1) * anwserCnt + indexACurQuestion
                FirstGroupBox.Controls.Add(FirstRadioButton)

                ListAnwser.Add(FirstRadioButton)
                'ListAnwser.Item(indexA - 1).top = (indexQCurPage - 1) * SpaceOneContent + Space3Height * (indexQCurPage - 1) + Space2Height * (indexACurQuestion - 1) + SpaceHeight
                ListAnwser.Item(indexA - 1).top = (AnwserHeight + Space2Height) * (indexACurQuestion - 1) + 15
                ListAnwser.Item(indexA - 1).left = 10
                ListAnwser.Item(indexA - 1).Width = 2900
                ListAnwser.Item(indexA - 1).TabIndex = indexQ + indexA
                ListAnwser.Item(indexA - 1).Tag = indexQ.ToString + "-" + indexACurQuestion.ToString
                'ListAnwser.Item(indexA - 1).Text = "试题" & indexQ.ToString & "，答案" & indexACurQuestion.ToString
                Select Case indexACurQuestion
                    Case 1
                        AnswerItem = ExerciseData(indexQ - 1).A
                    Case 2
                        AnswerItem = ExerciseData(indexQ - 1).B
                    Case 3
                        AnswerItem = ExerciseData(indexQ - 1).C
                    Case 4
                        AnswerItem = ExerciseData(indexQ - 1).D
                End Select
                ListAnwser.Item(indexA - 1).Text = AnswerItem
                AddHandler FirstRadioButton.Click, AddressOf RadioCtrlArrayClick          '给这组动态控件定义click事件的触发函数LblControlArrayClick 。

            Next indexACurQuestion
        Next indexQCurPage

    End Sub

    Private Sub IniExamQuestion(ByVal i As Integer, ByVal myRow As DataRow)
        ExerciseData(i).Question_Group = myRow("Question_Group").ToString.Trim
        ExerciseData(i).Question_Type = myRow("Question_Type").ToString.Trim
        ExerciseData(i).Question = myRow("Exercise").ToString.Trim
        ExerciseData(i).A = myRow("A").ToString.Trim
        ExerciseData(i).B = myRow("B").ToString.Trim
        ExerciseData(i).C = myRow("C").ToString.Trim
        ExerciseData(i).D = myRow("D").ToString.Trim
        ExerciseData(i).Answer = ""
        ExerciseData(i).CorrectAnswer = myRow("Answer").ToString.Trim
        If myRow("Question_Type").ToString.Trim = "Picture" Then
            ExerciseData(i).PictureName = myRow("PictureData").ToString.Trim
        End If

    End Sub
    Private Sub IniPictureExamQuestion(ByVal i As Integer, ByVal myRow As DataRow)
        ExerciseData(i).Question_Group = myRow("Question_Group").ToString.Trim
        ExerciseData(i).Question_Type = myRow("Question_Type").ToString.Trim
        ExerciseData(i).Question = myRow("Exercise").ToString.Trim
        ExerciseData(i).A = myRow("A").ToString.Trim
        ExerciseData(i).B = myRow("B").ToString.Trim
        ExerciseData(i).C = myRow("C").ToString.Trim
        ExerciseData(i).D = myRow("D").ToString.Trim
        ExerciseData(i).Answer = ""
        ExerciseData(i).CorrectAnswer = myRow("Answer").ToString.Trim
        ExerciseData(i).PictureName = myRow("PictureData").ToString.Trim
    End Sub
    Private Sub InPracticeExamQuestion(ByVal i As Integer, ByVal myRow As DataRow)
        ExerciseData(i).Question_Group = myRow("Question_Group").ToString.Trim
        ExerciseData(i).Question_Type = myRow("Question_Type").ToString.Trim
        ExerciseData(i).Question = myRow("SubItem").ToString.Trim
        ExerciseData(i).Answer = ""
        ExerciseData(i).CorrectAnswer = myRow("Answer").ToString.Trim
    End Sub

    Private Sub ButtonCtrlArrayClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim ATag As String
        Dim indexQ As Integer
        Dim BoxText As String
        Dim box As New PictureBox '= CType(sender, PictureBox)
        Dim sfrm As Form = New Form

        BoxText = CType(sender, Button).Name       '这里CType就是将触发事件的对象还原为Label对象，
        If BoxText.Length = 8 Then
            ATag = BoxText.Substring(BoxText.Length - 2, 2)
        Else
            ATag = BoxText.Substring(BoxText.Length - 1, 1)
        End If


        indexQ = Convert.ToInt16(ATag)
        sfrm.Controls.Add(box)
        sfrm.Height = 600
        sfrm.Width = 600
        box.Height = 550
        box.Width = 550
        box.Location = New System.Drawing.Point(10, 10)

        Dim inputBytes() As Byte = System.Convert.FromBase64String(ExerciseData(indexQ - 1).PictureName)
        Dim ms As MemoryStream = New MemoryStream(inputBytes)
        ms.Position = 0
        Dim img As Image = Image.FromStream(ms)
        ms.Close()
        '   FirstPicture.Image = Image.FromFile(PhotoPath & ExerciseData(indexQ - 1).PictureName)
        'FirstPicture.Image = img
        box.Image = img
        sfrm.Show()
    End Sub
    Private Sub RadioCtrlArrayClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim ATag As String
        Dim AItem As String
        Dim indexQ As Integer
        Dim indexA As Integer
        Dim radioBoxText As String

        AItem = ""
        radioBoxText = CType(sender, RadioButton).Text       '这里CType就是将触发事件的对象还原为Label对象，
        ATag = CType(sender, RadioButton).Tag
        indexQ = Convert.ToInt16(ATag.Substring(0, ATag.IndexOf("-")))
        indexA = Convert.ToInt16(ATag.Substring(ATag.IndexOf("-") + 1, 1))
        Select Case indexA
            Case 1
                AItem = "A"
            Case 2
                AItem = "B"
            Case 3
                AItem = "C"
            Case 4
                AItem = "D"
        End Select

        ExerciseData(indexQ - 1).Answer = AItem
        'MsgBox("所电击的动态控件的文字是：" & radioBoxText & ",Question：" & indexQ & ",答案：" & AItem)

    End Sub

    Private Sub IniExamInfo()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        If mActionType.ToUpper() = "Exam".ToUpper() Then
            If mdsExam.Tables(1).Rows.Count > 0 Then
                mExamNo = mdsExam.Tables(1).Rows(0)("Exam_No").ToString.Trim
                mScheduleID = mdsExam.Tables(1).Rows(0)("ExamScheduleID").ToString.Trim

                txtExamNo.Text = mdsExam.Tables(1).Rows(0)("Exam_No").ToString.Trim
                txtTitle.Text = mdsExam.Tables(1).Rows(0)("Title").ToString.Trim
                txtEmployeeID.Text = mdsExam.Tables(1).Rows(0)("EmployeeID").ToString.Trim
                txtEmployeeName.Text = mdsExam.Tables(1).Rows(0)("EmployeeName").ToString.Trim
                ExamType = mdsExam.Tables(1).Rows(0)("ExamType").ToString.Trim
                grpBoxEmp.Visible = True
            End If

            mHasSubmit = False
            PanelContent.Enabled = False
            'cmdStart.Enabled = True
            'cmdFinish.Enabled = False

            cmdStart.Visible = True
            cmdFinish.Visible = True
            'MsgBox("请在答题前关闭所有非Training 考试的程式！", MsgBoxStyle.Exclamation, "OP Exam")
            MsgBox("Please close all non-training exam programs before answering!/กรุณาปิดโปรแกรมสอบที่ไม่ใช่การฝึกอบรมทั้งหมดก่อนตอบ!", MsgBoxStyle.Exclamation, "OP Exam")
            ChkProcess()
        Else
            PanelContent.Enabled = True
            grpBoxEmp.Visible = False
            cmdStart.Visible = False
            cmdFinish.Visible = False
            If mdsExam.Tables(0).Rows.Count > 0 Then
                If mdsExam.Tables(0).Rows(0)("Question_Type").ToString.Trim = "Practice" Then
                    InPracticeQuestionCtrl(mdsExam.Tables(0))
                Else
                    IniQuestionCtrl(mdsExam.Tables(0))
                End If
            End If
        End If
        TimerChk.Enabled = False

    End Sub

    Public Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Try
            If mActionType.ToUpper() = "Exam".ToUpper() And mHasSubmit = False Then
                If (MsgBox("Please click the button [Complete the answer] and close the window in the normal way!", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Prompt")) = MsgBoxResult.Yes Then
                    Me.Close()
                    mHasSubmit = True    ''Cancel
                End If
            Else

                Me.Close()
            End If
        Catch
            Me.Close()
        End Try
    End Sub

    Private Sub frmOPExam_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If mActionType.ToUpper() = "Exam".ToUpper() And mHasSubmit = False Then
            MsgBox("Please click the button [Complete the answer] and close the window in the normal way!", MsgBoxStyle.Exclamation, "OP Exam")
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStart.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim i As Integer

        '----------------------------superchai comments 20220718 (Begin)---------------------------------------------
        'If cmdStart.Text = "Start Test/เริ่มทดสอบ" Then
        '    StrSql = "Exec OP_QryExamContent '','investigation' ,'Text','','" & P_BU & "'" '0001
        '    rst = Conn.Execute(StrSql)
        '    da.Fill(ds, rst, "InvestigationExamContent")
        '    mdsInvestigationExam = ds

        '    IniQuestionCtrl(mdsInvestigationExam.Tables(0))


        '    cmdStart.Text = "下一页"
        '    PanelContent.Enabled = True
        '    cmdStart.Enabled = True
        '    cmdFinish.Enabled = False
        '    TimerChk.Enabled = False
        '    '   MsgBox("答题开始，请注意时间！", MsgBoxStyle.Information, "OP Exam")

        '    StrSql = "Exec OP_InsInves_Result " & mScheduleID & "," & sq(txtEmployeeID.Text.Trim) & ",'OPExam','Start','',0," & sq(P_BU) & ""
        '    rst = Conn.Execute(StrSql)

        '    Exit Sub
        'End If
        'For i = 0 To pageQCnt - 1
        '    If ExerciseData(i).Answer = "" Then
        '        MsgBox("还有第" & (i + 1) & "请将题目写完！", MsgBoxStyle.Information, "OP Exam")
        '        Exit Sub
        '    End If

        '    StrSql = "Exec OP_InsInves_Result " & mScheduleID & "," & sq(txtEmployeeID.Text.Trim) & ",'OPExam','End','" & ExerciseData(i).Answer & "','" & (i + 1) & "'," & sq(P_BU)
        '    '            StrSql = "Update inves_Result set Answer='" & ExerciseData(i).Answer & "' , endDateTime = dbo.FormatDate(GETDATE(),'YYYYMMDDHHNNSS') where Question_No= " & i & " and ScheduleID = " & mScheduleID & " and Examinees =" & sq(txtEmployeeID.Text.Trim) & ""
        '    Conn.Execute(StrSql)
        'Next
        '----------------------------superchai comments 20220718 (End)---------------------------------------------

        ListAnwser.Clear()
        ListQuestion.Clear()


        StrSql = "Exec OP_QryExamContent " & mExamNo.ToString & ",'" & ExamType.ToString & "','Text',N" & sq(txtTitle.Text.Trim) & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        da.Fill(ds, rst, "ExamContent")
        mdsExam = ds

        '-------------------------superchai     check condition to next paper   20220718    (Begin)-------------------------------------
        If mdsExam.Tables(0).Rows.Count > 0 Then
            IniQuestionCtrl(mdsExam.Tables(0))
        Else
            Call cmdExit_Click(frmExercise.cmdExit, New System.EventArgs())
            Return
        End If
        '-------------------------superchai     check condition to next paper   20220718    (End)-------------------------------------

        StrSql = "Exec OP_InsExamResult " & sq(txtEmployeeID.Text.Trim) & ",N" & sq(txtEmployeeName.Text.Trim) & "," & mScheduleID & "," & mExamNo & ",N" & sq(txtTitle.Text.Trim) & ",'Start'," & sq(ExamType.ToString) & ",0," & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst("Result").Value.ToString = "0" Then
            rst = rst.NextRecordset
            mExamSTime = rst("STime").Value             ' Now.ToString("yyyy-MM-dd HH:mm:ss")

            PanelContent.Enabled = True
            cmdStart.Enabled = False
            cmdFinish.Enabled = True
            TimerChk.Enabled = True
            TimerChk.Interval = 60000     '一分钟
            'MsgBox("答题开始，请注意时间！", MsgBoxStyle.Information, "OP Exam")
            MsgBox("The answer begins, please pay attention to the time!/คำตอบเริ่มต้น โปรดใส่ใจกับเวลา!", MsgBoxStyle.Information, "OP Exam")
        Else

            MsgBox("run OP_InsExamResult fail,err:" & rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
        End If
    End Sub

    Private Sub cmdFinish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFinish.Click
        Dim decScore As Decimal
        Dim curTScore As Decimal
        Dim Result As String
        Dim rst As New ADODB.Recordset
        Dim i As Integer

        'cmdFinish.Enabled = False

        If pageQCnt = "0" Then
            Exit Sub
        End If
        decScore = 100.0 / pageQCnt

        For i = 0 To pageQCnt - 1
            If ExerciseData(i).CorrectAnswer = ExerciseData(i).Answer Then
                curTScore = curTScore + decScore
            End If
            If ExerciseData(i).Answer = "" Then
                'MsgBox("还有第" & (i + 1) & "请将题目写完！", MsgBoxStyle.Information, "OP Exam")
                MsgBox("And the first " & (i + 1) & " please complete the topic!/ข้อที่ " & (i + 1) & " โปรดใส่คำตอบให้ครบถ้วน!", MsgBoxStyle.Information, "OP Exam")
                Exit Sub
            End If
        Next

        If curTScore < mPassScore Then
            Result = "Fail"
        Else
            Result = "Pass"
        End If

        StrSql = "Exec OP_InsExamResult " & sq(txtEmployeeID.Text.Trim) & ",N" & sq(txtEmployeeName.Text.Trim) & "," & mScheduleID & "," & mExamNo & ",N" & sq(txtTitle.Text.Trim) & ",'End'," & sq(ExamType.ToString) & "," & curTScore & "," & sq(P_BU)
        rst = Conn.Execute(StrSql)

        If rst("Result").Value.ToString = "0" And rst("Grade").Value.ToString = "Pass" Then
            'rst = rst.NextRecordset
            'mExamSTime = rst("STime").Value             ' Now.ToString("yyyy-MM-dd HH:mm:ss")

            PanelContent.Enabled = True
            Me.PanelContent.Controls.Clear()

            mHasSubmit = True
            'MsgBox("答题完成，您此次答题的得分:" + curTScore.ToString + ",合格分数:" + mPassScore.ToString + ",考试结果:" + Result, MsgBoxStyle.Information, "Training")
            MsgBox("After answering the question, your score for this answer: " + curTScore.ToString + ", passing score: " + mPassScore.ToString + ", exam results: " + Result + "/หลังจากตอบคำถาม คะแนนของคุณสำหรับคำตอบนี้: " + curTScore.ToString + ", คะแนนผ่าน: " + mPassScore.ToString + ", ผลสอบ: " + Result, MsgBoxStyle.Information, "Training")

            '-----------------superchai     Change condition next new peaper    20220718 (Begin)------------------------------            
            'Call FrmUserInput.btnOK_Click(Nothing, Nothing)
            Dim ds As New DataSet
            Dim da As New System.Data.OleDb.OleDbDataAdapter

            If P_FormFlag.ToUpper = "OPExam".ToUpper Then

                StrSql = "exec OP_QryExamInfo " & sq(txtEmployeeID.Text.Trim) & "," & sq(P_BU) & "" '0001
                rst = Conn.Execute(StrSql)
                If rst.EOF = False Then
                    da.Fill(ds, rst, "ExamContent")

                    If ds.Tables(0).Rows(0)("Result").ToString = "0" Then
                        'If frmOPExam.Activate = False Then
                        '    frmOPExam.Close()
                        'End If                        

                        Dim frmOPExamTmp As New frmOPExam()

                        frmOPExamTmp.mdsExam = ds
                        frmOPExamTmp.mActionType = "Exam"
                        'frmOPExam.MdiParent = frmMain
                        'frmOPExam.Show()

                        Me.Close()
                        Me.WindowState = FormWindowState.Minimized


                        ' Display frm2 as a modal dialog
                        frmOPExamTmp.ShowDialog()
                        frmOPExamTmp.WindowState = FormWindowState.Maximized

                    Else
                        MsgBox(ds.Tables(0).Rows(0)("Description").ToString.Trim, MsgBoxStyle.Critical, "Prompt")
                        Call cmdExit_Click(frmExercise.cmdExit, New System.EventArgs())
                    End If

                    Return
                End If
            End If
            'test
            If Len(Trim(txtEmployeeID.Text)) = 8 Then
                If P_FormFlag = "EXAM" Then
                    P_UserName = Trim(txtEmployeeID.Text)
                    frmExercise.MdiParent = frmMain
                    frmExercise.Show()
                Else
                    If P_FormFlag = "PRACTICE" Then
                        P_UserName = Trim(txtEmployeeID.Text)
                        FrmPracticeList.MdiParent = frmMain
                        FrmPracticeList.Show()

                    End If
                End If
            End If
            '-----------------superchai     Change condition next new peaper    20220718 (End)------------------------------

            'cmdStart.Text = "开始答题"
            'cmdStart.Enabled = True
            'cmdFinish.Enabled = False

            'Call cmdExit_Click(frmExercise.cmdExit, New System.EventArgs())
        ElseIf rst("Result").Value.ToString = "0" And rst("Grade").Value.ToString = "Fail" Then
            PanelContent.Enabled = True
            Me.PanelContent.Controls.Clear()

            mHasSubmit = True
            'MsgBox("答题完成，您此次答题的得分:" + curTScore.ToString + ",合格分数:" + mPassScore.ToString + ",考试结果:" + Result, MsgBoxStyle.Information, "Training")
            MsgBox("After answering the question, your score for this answer: " + curTScore.ToString + ", passing score: " + mPassScore.ToString + ", exam results: " + Result + "/หลังจากตอบคำถาม คะแนนของคุณสำหรับคำตอบนี้: " + curTScore.ToString + ", คะแนนผ่าน: " + mPassScore.ToString + ", ผลสอบ: " + Result, MsgBoxStyle.Information, "Training")

            'cmdStart.Text = "开始答题"
            cmdStart.Enabled = True
            cmdFinish.Enabled = False

            Call cmdExit_Click(frmExercise.cmdExit, New System.EventArgs())
        Else
            cmdFinish.Enabled = True
            MsgBox("run OP_InsExamResult fail,err:" & rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
        End If
    End Sub

    Private Sub TimerChk_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimerChk.Tick
        Dim rst As New ADODB.Recordset
        Dim curTime As DateTime
        Static Cnt As Integer

        'mExamLength
        StrSql = "select getdate() as CurTime"
        rst = Conn.Execute(StrSql)
        curTime = rst("CurTime").Value
        If curTime > DateAdd(DateInterval.Minute, mExamLength, mExamSTime) Then
            PanelContent.Enabled = False
            MsgBox("答题时间结束，请点击【答题完毕】提交！", MsgBoxStyle.Exclamation, "OP Exam")
            TimerChk.Enabled = False
        End If

        If Cnt > 2 Then
            Cnt = 0
            ''考试时不允许开启IE，Notepad,Wordpad etc.
            ChkProcess()
        Else
            Cnt = Cnt + 1
        End If


    End Sub

    Private Sub ChkProcess()
        'Dim myProcesses() As System.Diagnostics.Process
        'Dim oneProcess As System.Diagnostics.Process

        'myProcesses = myProcesses.GetProcesses()
        'For Each oneProcess In myProcesses

        '    Debug.Print(oneProcess.Id.ToString & Space(5) & oneProcess.ProcessName())
        'Next
        Dim i As Integer
        Dim ProhibitProgList() As String

        Dim sProcesses() As System.Diagnostics.Process
        Dim sProcess As System.Diagnostics.Process
        Dim s As String
        On Error GoTo ErrorHandler

        ProhibitProgList = P_ProhibitProgList.Split(",")
        sProcesses = System.Diagnostics.Process.GetProcesses()

        s = "Procss Info: " & vbCrLf

        For Each sProcess In sProcesses
            's = s & sProcess.Id & Space(5) & sProcess.ProcessName() & vbCrLf
            For i = 0 To UBound(ProhibitProgList)
                If sProcess.ProcessName.ToString.Trim.ToUpper = ProhibitProgList(i).Trim.ToUpper.Replace(".EXE", "") Then
                    sProcess.Kill()
                    Exit For
                End If
            Next

        Next

        Exit Sub
ErrorHandler:
        Err.Clear()
    End Sub
End Class