Public Class frmUploadData
    Dim DeptGroupPos As ColPos
    Dim DutyGroupPos As ColPos
    Dim CertifyDutyGroupPos As ColPos
    Private Sub cmdFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFile.Click
        Dim i As Integer
        On Error GoTo errhnd
        OpenFileDialog1.ShowDialog()
        txtFileName.Text = OpenFileDialog1.FileName
        If UCase(Mid(txtFileName.Text.Trim, Len(txtFileName.Text.Trim) - 3, 4)) <> ".XLS" Then
            MsgBox("文件类型不正确，请选择表格文件XLS", MsgBoxStyle.Critical, "Error")
            txtFileName.Text = ""
            Exit Sub
        End If
        ExcelGlobal_definst.Workbooks.Open(txtFileName.Text.Trim)
        ExcelGlobal_definst.Worksheets(1).activate()
        cmbSheet.Items.Clear()
        i = 0
        Do
            cmbSheet.Items.Add(ExcelGlobal_definst.ActiveSheet.name)
            If ExcelGlobal_definst.ActiveSheet.next Is Nothing Then Exit Do
            ExcelGlobal_definst.ActiveSheet.next.select()
            i = i + 1
        Loop
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
    Private Sub UploadExerciseData(ByVal FileName As String, ByVal SheetName As String)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim i, j, k As Integer
        Dim QuestionNO As String
        Dim QuestionType As String
        Dim Group As String
        Dim TempGroup As String
        Dim DeptGroup As String
        Dim QuestionGroup As String
        Dim Material As String
        Dim Exercise As String
        Dim A, B, C, D As String
        Dim Answer As String
        Dim DutyGroup As String
        Dim DeptGroup2 As String
        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Open(FileName)
        xlapp.Worksheets(SheetName).activate()
        xlWs = xlapp.ActiveSheet
        For i = 1 To 100
            DeptGroup2 = UCase(xlapp.Cells(1, i).value)
            Select Case UCase(xlapp.Cells(1, i).value)
                Case "部門群組"
                    If DeptGroupPos.StartPos = 0 Then
                        DeptGroupPos.StartPos = i
                    End If
                    DeptGroupPos.EndPos = i
                Case "DeptGroup"
                    If DeptGroupPos.StartPos = 0 Then
                        DeptGroupPos.StartPos = i
                    End If
                    DeptGroupPos.EndPos = i
                Case "ANSWER"
                    DutyGroupPos.StartPos = i 'superchai    Modify count from i+1 is i    20220705
                Case Else
            End Select
            If xlapp.Cells(1, i).value <> "" Then
                DutyGroupPos.EndPos = i
            End If
        Next
        TempGroup = xlapp.Cells(2, 2).value
        i = 2

        While xlapp.Cells(i, 1).value >= 1
            PB1.Maximum = DeptGroupPos.EndPos - DeptGroupPos.StartPos + 2
            PB1.Value = 1
            QuestionNO = xlapp.Cells(i, 1).value
            If i = 1 Then
                If QuestionNO <> "1" Then
                    MsgBox("上传的理论题的第一题QuestionNO为1", MsgBoxStyle.Critical, "Error")
                End If
            End If
            Group = xlapp.Cells(i, 2).value
            QuestionType = xlapp.Cells(i, 3).value
            Material = xlapp.Cells(i, 4).value
            QuestionGroup = xlapp.Cells(i, DeptGroupPos.EndPos + 1).value

            Exercise = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 2).value, "'", "''")
            A = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 4).value, "'", "''")
            B = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 6).value, "'", "''")
            C = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 8).value, "'", "''")
            D = Replace(xlapp.Cells(i, DeptGroupPos.EndPos + 10).value, "'", "''")
            Answer = xlapp.Cells(i, DeptGroupPos.EndPos + 11).value
            If Material <> "theory" Then
                MsgBox("上传的理论题的Material栏位必须是Theory", MsgBoxStyle.Critical, "Error")
                xlWs = Nothing
                xlsbook.Close()
                xlapp.Quit()
                Return
            End If
            For j = DeptGroupPos.StartPos To DeptGroupPos.EndPos
                DeptGroup = xlapp.Cells(i, j).value
                If Trim(DeptGroup) <> "" Then
                    For k = DutyGroupPos.StartPos To DutyGroupPos.EndPos
                        DutyGroup = xlapp.Cells(1, k).value
                        If xlapp.Cells(i, k + 1).value = "V" Then   'superchai  Modify count K is K+1   20220705
                            StrSql = "Exec InsertExerciseData_TEST '" & Trim(QuestionNO) & "',N'" & Trim(QuestionGroup) & "',N'" & Trim(Group) & "'," &
                                    "N'" & Trim(DeptGroup) & "',N'" & Trim(DutyGroup) & "',N'" & Trim(QuestionType) & "',N'" & Trim(Exercise.Replace("'", "��")) & "'," &
                                    "N'" & Trim(A) & "',N'" & Trim(B) & "',N'" & Trim(C) & "',N'" & Trim(D) & "'," &
                                    "N'" & Trim(Answer) & "',N'" & Trim(Material) & "','" & P_BU & "'" '0001
                            '"N'" & Trim(txtComment.Text) & "' " '0001
                            Conn.Execute(StrSql)
                        End If
                    Next
                End If
                PB1.Value = PB1.Value + 1
            Next
            i = i + 1
        End While

        '--superchai add 20231021 (B)
        If TStation.ToUpper() = "TRAINING" Then
            StrSql = "exec InsertExamSubject_TEST N'" & Trim(TempGroup) & "','" & P_BU & "', N'" & Trim(txtComment.Text) & "', 'OP'" '0001        'superchai add 20231011
        Else
            StrSql = "exec InsertExamSubject_TEST N'" & Trim(TempGroup) & "','" & P_BU & "', N'" & Trim(txtComment.Text) & "', 'IDL'" '0001        'superchai add 20231011
        End If
        '--superchai add 20231021 (E)

        'StrSql = "exec InsertExamSubject_TEST N'" & Trim(TempGroup) & "','" & P_BU & "', N'" & Trim(txtComment.Text) & "'" '0001        'superchai add 20231011
        Conn.Execute(StrSql)

        xlWs = Nothing
        xlsbook.Close()
        xlapp.Quit()
    End Sub
   
    Private Sub Cmd_Load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmd_Load.Click
        If txtFileName.Text.Trim = "" Or cmbSheet.Text.Trim = "" Or cmbFunGroup.Text.Trim = "" Then
            MsgBox("请选择要导入的文件,页面和组别", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        Select Case cmbFunGroup.Text.Trim
            Case "Theory"
                Call UploadExerciseData(txtFileName.Text.Trim, cmbSheet.Text.Trim)
                MsgBox("试题上传成功", MsgBoxStyle.Information, "Training")
            Case Else

                'MsgBox("�����ϴ��ɹ�", MsgBoxStyle.Information, "Training")
                MsgBox("Not support error type" + cmbFunGroup.Text.Trim, MsgBoxStyle.Information, "Training")
        End Select

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
 
End Class
