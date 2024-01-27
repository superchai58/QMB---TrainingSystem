Imports System.IO

Public Class FrmMaintainPhoto
    Private FileName1 As String
    Private sFilename As String
    Private ClickFlag As String
    Private Sub cmdU1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdU1.Click
        Dim Message As String
        If cmbQuestionGroup.Text.Trim = "" Then
            MsgBox("请先选择Group！")
            Exit Sub
        End If
        Message = SavePhoto(txtP1, Lbl11)
        If UCase(Message).Trim <> "OK" Then
            MsgBox(Message)
            Exit Sub
        End If
        If Lbl11.Text.Trim = "有图片" Then

            AddHandler Lbl11.Click, AddressOf Lbl11_Click
        End If
    End Sub
    Private Function SavePhoto(ByVal txtPath As TextBox, ByVal lblFlag As Label) As String
        Dim fileName As String
        Dim fileStream As FileStream
        SavePhoto = "OK"
        If txtPath.Text.Trim = "" Then
            SavePhoto = "请选择图片"
            Exit Function
        End If
        Dim t As Integer
        Dim a As String = txtPath.Text
        Dim i As Integer = a.LastIndexOf(".")
      
        t = a.LastIndexOf("\")
        If t < 0 Then
            SavePhoto = "路径错误"
            Exit Function
        End If

        sFilename = a.Substring(t + 1, a.Length - t - 1)
        Dim ex As String = a.Substring(i, a.Length - i)      '//取得文件扩展名
        'PB11.Image.FromFile("C:\test.jpg")
        Select Case UCase(ex)
            Case ".BMP", ".JPG", ".JPEG", ".GIF", ".PNG"
            Case Else
                SavePhoto = "Picture Format must be [.bmp .jpg .jpeg .gif.png]"
                Exit Function
        End Select
        lblFlag.Text = "有图片"
        lblFlag.ForeColor = Color.Blue
        ' FileCopy(a, PhotoPath & sFilename)
        '将文档转换成byte（）
        fileName = a
        fileStream = New IO.FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)

        '读取文件的 byte()

        Dim bData() As Byte = New Byte(fileStream.Length) {}

        fileStream.Read(bData, 0, bData.Length)

        fileStream.Close()


        '把 byte()转换成 Stream

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
            MsgBox("请输入完整数据")
            Exit Sub
        End If
        If TxtA.Text.Trim = "" Or TxtB.Text.Trim = "" Or txtC.Text.Trim = "" Or txtD.Text.Trim = "" Then
            MsgBox("请输入完整数据")
            Exit Sub
        End If
        If cmbQuestionNO.Text.Trim = "" Or cmbQuestionGroup.Text.Trim = "" Or cmbMaterial.Text.Trim = "" Then
            MsgBox("请输入完整数据")
            Exit Sub
        End If
        If cmbQuestionGroup.Text.Trim.Substring(0, 3) <> "Pic" Then
            MsgBox("Group 必须以Picture的Pic 开头！")
            Exit Sub
        End If
        If sFilename = "" Then
            MsgBox("请Upload 图片")
            Exit Sub
        End If
        StrSql = "select * from Picture_File where pictureName ='" & Trim(sFilename) & "' "
        Rs = Conn.Execute(StrSql)
        If Rs.EOF = False Then
            MsgBox("已经存在Picture 了，请重新输入！")
            Exit Sub
        End If

        Dim fileName As String
        Dim fileStream As FileStream
        fileName = txtP1.Text
        fileStream = New IO.FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read)

        '读取文件的 byte()

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
        MsgBox("数据保存PASS！")
    End Sub
    Private Sub Lbl11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Lbl11.Text.Trim = "显示图片最大化" Then
            Call ShowPhoto(sFilename)
        End If
    End Sub

    Private Sub ClearPhotoExamData()

        txtExercise.Text = ""
        Lbl11.Text = "空白"
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
            MsgBox("请输入完整数据")
            Exit Sub
        End If
        StrSql = "DeletePictureExercise N'" & Trim(cmbQuestionGroup.Text) & "','" & Trim(cmbQuestionNO.Text) & "','" & P_BU & "'" '0001
        Conn.Execute(StrSql)
        MsgBox("数据删除OK！")
    End Sub

End Class