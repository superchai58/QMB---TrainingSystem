﻿Imports System.IO

Public Class FrmMaintainPhoto
    Private FileName1 As String
    Private sFilename As String
    Private ClickFlag As String
    Public SheetNameChk As String


    Private Sub cmdU1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdU1.Click
        Dim Message As String
        If cmbQuestionGroup.Text.Trim = "" Then
            MsgBox("ÇëÏÈÑ¡ÔñGroup£¡")
            Exit Sub
        End If
        Message = SavePhoto(txtP1, Lbl11)
        If UCase(Message).Trim <> "OK" Then
            MsgBox(Message)
            Exit Sub
        End If
        If Lbl11.Text.Trim = "ÓÐÍ¼Æ¬" Then

            AddHandler Lbl11.Click, AddressOf Lbl11_Click
        End If
    End Sub
    Private Function SavePhoto(ByVal txtPath As TextBox, ByVal lblFlag As Label) As String
        Dim fileName As String
        Dim fileStream As FileStream
        SavePhoto = "OK"
        If txtPath.Text.Trim = "" Then
            SavePhoto = "ÇëÑ¡ÔñÍ¼Æ¬"
            Exit Function
        End If
        Dim t As Integer
        Dim a As String = txtPath.Text
        Dim i As Integer = a.LastIndexOf(".")
      
        t = a.LastIndexOf("\")
        If t < 0 Then
            SavePhoto = "Â·¾¶´íÎó"
            Exit Function
        End If

        sFilename = a.Substring(t + 1, a.Length - t - 1)
        Dim ex As String = a.Substring(i, a.Length - i)      '//È¡µÃÎÄ¼þÀ©Õ¹Ãû
        'PB11.Image.FromFile("C:\test.jpg")
        Select Case UCase(ex)
            Case ".BMP", ".JPG", ".JPEG", ".GIF", ".PNG"
            Case Else
                SavePhoto = "Picture Format must be [.bmp .jpg .jpeg .gif.png]"
                Exit Function
        End Select
        lblFlag.Text = "ÓÐÍ¼Æ¬"
        lblFlag.ForeColor = Color.Blue
        ' FileCopy(a, PhotoPath & sFilename)
        '½«ÎÄµµ×ª»»³Ébyte£¨£©
        fileName = a
        fileStream = New IO.FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)

        '¶ÁÈ¡ÎÄ¼þµÄ byte()

        Dim bData() As Byte = New Byte(fileStream.Length) {}

        fileStream.Read(bData, 0, bData.Length)

        fileStream.Close()


        '°Ñ byte()×ª»»³É Stream

        Dim ms As MemoryStream = New MemoryStream(bData)

        ms.Position = 0

        Dim img As Image = Image.FromStream(ms)

        ms.Close()

        Picture1.Image = img


    End Function

    Private Sub ShowPhoto(ByVal nFileName As String)
        Dim box As New PictureBox '= CType(sender, PictureBox)
        Dim sfrm As Form = New Form
        If P_PhotoFlag = True Then
            P_PhotoFlag = False
            Exit Sub
        End If
        sfrm.Controls.Add(box)
        sfrm.Height = 800
        sfrm.Width = 800

        box.Height = 750
        box.Width = 750
        box.Location = New System.Drawing.Point(10, 10)
        box.Image = Image.FromFile(PhotoPath & nFileName)
        'box.SizeMode = PictureBoxSizeMode.StretchImage      'superchai add 20230824
        'box.Size = box.Image.Size       'superchai add 20230825
        sfrm.Show()
        P_PhotoFlag = True

    End Sub

    Private Sub FrmMaintainPhoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rs As New ADODB.Recordset
        cmbMaterial.Text = "Picture"
        StrSql = "select distinct [group] from Exercise_Detail where Material ='Picture' and BU='" & P_BU & "' " '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = True Then Exit Sub
        While rs.EOF = False
            cmbQuestionGroup.Items.Add(rs.Fields("group").Value.ToString)
            rs.MoveNext()
        End While
        rs = Nothing
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private Sub FrmMaintainPhoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click
        Dim pen As New Drawing.Pen(System.Drawing.Color.Red, 1)
        Me.CreateGraphics.DrawEllipse(pen, 0, 0, 100, 100)
        pen.Dispose()
    End Sub

    Private Sub cmdFile1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile1.Click
        OpenFileDialog1.ShowDialog()
        txtP1.Text = OpenFileDialog1.FileName
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim Rs As New ADODB.Recordset

        If txtExercise.Text.Trim = "" Or txtCorrectAnswer.Text.Trim = "" Then
            MsgBox("Please enter complete data/กรุณากรอกข้อมูลให้ครบถ้วน")
            Exit Sub
        End If
        If TxtA.Text.Trim = "" Or TxtB.Text.Trim = "" Or txtC.Text.Trim = "" Or txtD.Text.Trim = "" Then
            MsgBox("Please enter complete data/กรุณากรอกข้อมูลให้ครบถ้วน")
            Exit Sub
        End If
        If cmbQuestionNO.Text.Trim = "" Or cmbQuestionGroup.Text.Trim = "" Or cmbMaterial.Text.Trim = "" Then
            MsgBox("Please enter complete data/กรุณากรอกข้อมูลให้ครบถ้วน")
            Exit Sub
        End If
        If cmbQuestionGroup.Text.Trim.Substring(0, 3) <> "Pic" Then
            MsgBox("Group must start with Pic of Picture!/Group ต้องขึ้นต้นด้วย Pic ของรูปภาพ!")
            Exit Sub
        End If
        If sFilename = "" Then
            MsgBox("Please upload picture/กรุณาอัพโหลดรูปภาพ")
            Exit Sub
        End If
        StrSql = "select * from Picture_File where pictureName ='" & Trim(sFilename) & "' "
        Rs = Conn.Execute(StrSql)
        If Rs.EOF = False Then
            MsgBox("Picture already exists, please re-enter!/รูปภาพมีอยู่แล้ว โปรดป้อนใหม่!")
            Exit Sub
        End If

        Dim fileName As String
        Dim fileStream As FileStream
        fileName = txtP1.Text
        fileStream = New IO.FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)

        '¶ÁÈ¡ÎÄ¼þµÄ byte()

        Dim bData() As Byte = New Byte(FileStream.Length) {}

        FileStream.Read(bData, 0, bData.Length)

        fileStream.Close()
      
        Dim inputString As String = System.Convert.ToBase64String(bData)

        sFilename = cmbQuestionGroup.Text.Trim & "_" & cmbQuestionNO.Text.Trim

        StrSql = "Exec InsertPictureExercise '" & Trim(cmbQuestionNO.Text.Trim) & "',N'" & Trim(cmbQuestionGroup.Text.Trim) & "',N'" & Trim(txtExercise.Text.Trim) & "'," & _
                                    "N'" & Trim(TxtA.Text) & "',N'" & Trim(TxtB.Text) & "',N'" & Trim(txtC.Text) & "',N'" & Trim(txtD.Text) & "'," & _
                                    "N'" & Trim(txtCorrectAnswer.Text.Trim) & "',N'" & Trim(cmbMaterial.Text.Trim) & "', N'" & Trim(sFilename) & "','" & P_BU & "','" & Trim(inputString) & "'"
        Conn.Execute(StrSql)
        ClearPhotoExamData()
        MsgBox("Êý¾Ý±£´æPASS£¡")
    End Sub
    Private Sub Lbl11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Lbl11.Text.Trim = "ÏÔÊ¾Í¼Æ¬×î´ó»¯" Then
            Call ShowPhoto(sFilename)
        End If
    End Sub

    Private Sub ClearPhotoExamData()

        txtExercise.Text = ""
        Lbl11.Text = "¿Õ°×"
        TxtA.Text = ""
        TxtB.Text = ""
        txtC.Text = ""
        txtD.Text = ""
        txtCorrectAnswer.Text = ""
        cmbQuestionNO.Text = ""
        cmbQuestionGroup.Text = ""

    End Sub

    Private Sub cmbQuestionNO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbQuestionNO.Click
        Dim rs As New ADODB.Recordset
        Dim a As Integer
        cmbQuestionNO.Items.Clear()

        a = 0
        StrSql = "select Question_NO from Exercise_Detail where  [Group] =N'" & Trim(cmbQuestionGroup.Text) & "'and  Material ='Picture' and BU='" & P_BU & "' order by Question_NO " '0001
        rs = Conn.Execute(StrSql)
        While rs.EOF = False
            cmbQuestionNO.Items.Add(rs.Fields("Question_NO").Value.ToString)
            a = rs.Fields("Question_NO").Value.ToString
            rs.MoveNext()
        End While
        cmbQuestionNO.Text = a + 1
        rs = Nothing

    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If cmbQuestionNO.Text.Trim = "" Or cmbQuestionGroup.Text.Trim = "" Or cmbMaterial.Text.Trim = "" Then
            MsgBox("ÇëÊäÈëÍêÕûÊý¾Ý")
            Exit Sub
        End If
        StrSql = "DeletePictureExercise N'" & Trim(cmbQuestionGroup.Text) & "','" & Trim(cmbQuestionNO.Text) & "','" & P_BU & "'" '0001
        Conn.Execute(StrSql)
        MsgBox("Êý¾ÝÉ¾³ýOK£¡")
    End Sub

    Private Sub cmdFile_Click(sender As Object, e As EventArgs) Handles cmdFile.Click
        Dim i As Integer
        On Error GoTo errhnd
        OpenFileDialog1.ShowDialog()
        txtFileName.Text = OpenFileDialog1.FileName
        If UCase(Mid(txtFileName.Text.Trim, Len(txtFileName.Text.Trim) - 3, 4)) <> ".XLS" Then
            MsgBox("The file type is incorrect, please select the table file XLS", MsgBoxStyle.Critical, "Error")
            txtFileName.Text = ""
            Exit Sub
        End If
        ExcelGlobal_definst.Workbooks.Open(txtFileName.Text.Trim)
        ExcelGlobal_definst.Worksheets(1).activate()

        'superchai add 20230828 (B)
        SheetNameChk = ExcelGlobal_definst.ActiveSheet.name
        ExcelGlobal_definst.ActiveSheet.next.select()
        'superchai add 20230828 (E)

        '-----------superchai comments 20230828 (B)--------------------
        'cmbSheet.Items.Clear()
        'i = 0
        'Do
        '    cmbSheet.Items.Add(ExcelGlobal_definst.ActiveSheet.name)
        '    If ExcelGlobal_definst.ActiveSheet.next Is Nothing Then Exit Do
        '    ExcelGlobal_definst.ActiveSheet.next.select()
        '    i = i + 1
        'Loop
        '-----------superchai comments 20230828 (E)--------------------
NoData:
        ExcelGlobal_definst.Workbooks.Close()
        GoTo Pass
        Exit Sub
errhnd:
        If Err.Number = 91 Then
            GoTo NoData
        End If
Pass:
    End Sub

    Private Sub Cmd_Load_Click(sender As Object, e As EventArgs) Handles Cmd_Load.Click
        If txtFileName.Text.Trim = "" Then
            MsgBox("Please select the file, page and group to import.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        Call UploadExerciseData(txtFileName.Text.Trim, SheetNameChk.Trim())
        MsgBox("Questions uploaded successfully.", MsgBoxStyle.Information, "Training")

        '-----------superchai comments 20230828 (B)-------------
        'Select Case cmbFunGroup.Text.Trim
        '    Case "Theory"
        '        Call UploadExerciseData(txtFileName.Text.Trim, cmbSheet.Text.Trim)
        '        MsgBox("试题上传成功", MsgBoxStyle.Information, "Training")
        '    Case Else

        '        'MsgBox("�����ϴ��ɹ�", MsgBoxStyle.Information, "Training")
        '        MsgBox("Not support error type" + cmbFunGroup.Text.Trim, MsgBoxStyle.Information, "Training")
        'End Select
        '-----------superchai comments 20230828 (E)-------------
    End Sub

    Private Sub UploadExerciseData(ByVal FileName As String, ByVal SheetName As String)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        'Dim xlsSheet As Excel.Worksheet
        Dim xlWs As Object

        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet

        '----------superchai add 20230828 (B)---------------
        Dim numrows As Integer
        Dim xRng As Excel.Range
        numrows = xlsbook.Sheets("PIC").UsedRange.Rows.Count

        'Add DataType of column picture (B)
        Dim Question_NO(numrows) As String
        Dim Question_Group(numrows) As String
        Dim Group(numrows) As String
        Dim DeptGroup(numrows) As String
        Dim Exercise(numrows) As String
        Dim A(numrows) As String
        Dim B(numrows) As String
        Dim C(numrows) As String
        Dim D(numrows) As String
        Dim Answer(numrows) As String
        Dim Question_Type(numrows) As String
        Dim Material(numrows) As String
        Dim TopicPicture(numrows) As String
        'Add DataType of column picture (E)

        xlWs = xlsbook.Worksheets(1)
        'xlWs = xlsbook.Sheets.Add
        'xlWs.Name = "PIC"

        Dim currentRow As Long
        For currentRow = 2 To numrows Step 1
            'xlWs.Cells(currentRow, 0).ToString()
            xRng = CType(xlWs.Cells(currentRow, 1), Excel.Range)
            If IsNothing(xRng.Value()) = False Then
                MessageBox.Show(xRng.Value().ToString())
            End If

            'xlWs.Cells(currentRow, 1).ToString()
            xRng = CType(xlWs.Cells(currentRow, 2), Excel.Range)
            If IsNothing(xRng.Value()) = False Then
                MessageBox.Show(xRng.Value().ToString())
            End If

            'xlWs.Cells(currentRow, 2).ToString()
            xRng = CType(xlWs.Cells(currentRow, 3), Excel.Range)
            If IsNothing(xRng.Value()) = False Then
                MessageBox.Show(xRng.Value().ToString())
            End If
        Next

        '----------superchai add 20230828 (E)---------------

        '-----------superchai comment 20230828 (B)---------------
        'For i = 1 To 100
        '    DeptGroup2 = UCase(xlapp.Cells(1, i).value)
        '    Select Case UCase(xlapp.Cells(1, i).value)
        '        Case "部門群組"
        '            If DeptGroupPos.StartPos = 0 Then
        '                DeptGroupPos.StartPos = i
        '            End If
        '            DeptGroupPos.EndPos = i
        '        Case "DeptGroup"
        '            If DeptGroupPos.StartPos = 0 Then
        '                DeptGroupPos.StartPos = i
        '            End If
        '            DeptGroupPos.EndPos = i
        '        Case "ANSWER"
        '            DutyGroupPos.StartPos = i 'superchai    Modify count from i+1 is i    20220705
        '        Case Else
        '    End Select
        '    If xlapp.Cells(1, i).value <> "" Then
        '        DutyGroupPos.EndPos = i
        '    End If
        'Next

        'TempGroup = xlapp.Cells(2, 2).value
        'i = 2
        'While xlapp.Cells(i, 1).value >= 1
        '    PB1.Maximum = DeptGroupPos.EndPos - DeptGroupPos.StartPos + 2
        '    PB1.Value = 1
        '    QuestionNO = xlapp.Cells(i, 1).value
        '    If i = 1 Then
        '        If QuestionNO <> "1" Then
        '            MsgBox("上传的理论题的第一题QuestionNO为1", MsgBoxStyle.Critical, "Error")
        '        End If
        '    End If
        '    Group = xlapp.Cells(i, 2).value
        '    QuestionType = xlapp.Cells(i, 3).value
        '    Material = xlapp.Cells(i, 4).value
        '    QuestionGroup = xlapp.Cells(i, DeptGroupPos.EndPos + 1).value

        '    Exercise = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 2).value, "'", "''")
        '    A = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 4).value, "'", "''")
        '    B = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 6).value, "'", "''")
        '    C = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 8).value, "'", "''")
        '    D = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 10).value, "'", "''")
        '    Answer = xlapp.Cells(i, DeptGroupPos.EndPos + 11).value
        '    If Material <> "theory" Then
        '        MsgBox("上传的理论题的Material栏位必须是Theory", MsgBoxStyle.Critical, "Error")
        '        xlWs = Nothing
        '        xlsbook.Close()
        '        xlapp.Quit()
        '        Return
        '    End If
        '    For j = DeptGroupPos.StartPos To DeptGroupPos.EndPos
        '        DeptGroup = xlapp.Cells(i, j).value
        '        If Trim(DeptGroup) <> "" Then
        '            For k = DutyGroupPos.StartPos To DutyGroupPos.EndPos
        '                DutyGroup = xlapp.Cells(1, k).value
        '                If xlapp.Cells(i, k + 1).value = "V" Then   'superchai  Modify count K is K+1   20220705
        '                    StrSql = "Exec InsertExerciseData '" & Trim(QuestionNO) & "',N'" & Trim(QuestionGroup) & "',N'" & Trim(Group) & "'," &
        '                            "N'" & Trim(DeptGroup) & "',N'" & Trim(DutyGroup) & "',N'" & Trim(QuestionType) & "',N'" & Trim(Exercise.Replace("'", "��")) & "'," &
        '                            "N'" & Trim(A) & "',N'" & Trim(B) & "',N'" & Trim(C) & "',N'" & Trim(D) & "'," &
        '                            "N'" & Trim(Answer) & "',N'" & Trim(Material) & "','" & P_BU & "' " '0001
        '                    Conn.Execute(StrSql)
        '                End If
        '            Next
        '        End If
        '        PB1.Value = PB1.Value + 1
        '    Next
        '    i = i + 1
        'End While
        '-----------superchai comment 20230828 (E)---------------

        'StrSql = "exec InsertExamSubject N'" & Trim(TempGroup) & "','" & P_BU & "'" '0001
        'Conn.Execute(StrSql)

        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()
    End Sub
End Class