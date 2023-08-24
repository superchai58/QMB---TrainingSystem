Public Class FrmUserInput

    Public Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        If P_FormFlag.ToUpper = "OPExam".ToUpper Then

            StrSql = "exec OP_QryExamInfo " & sq(txtUserid.Text.Trim) & "," & sq(P_BU) & "" '0001
            rst = Conn.Execute(StrSql)
            If rst.EOF = False Then
                da.Fill(ds, rst, "ExamContent")

                If ds.Tables(0).Rows(0)("Result").ToString = "0" Then
                    'If frmOPExam.Activate = False Then
                    '    frmOPExam.Close()
                    'End If

                    frmOPExam.mdsExam = ds
                    frmOPExam.mActionType = "Exam"
                    'frmOPExam.MdiParent = frmMain
                    'frmOPExam.Show()
                    Me.WindowState = FormWindowState.Minimized
                    frmOPExam.ShowDialog()
                    Me.WindowState = FormWindowState.Maximized

                Else
                    MsgBox(ds.Tables(0).Rows(0)("Description").ToString.Trim, MsgBoxStyle.Critical, "Prompt")
                End If

                Return
            End If
        End If
        'test
        If Len(Trim(txtUserid.Text)) = 8 Then
            If P_FormFlag = "EXAM" Then
                P_UserName = Trim(txtUserid.Text)
                frmExercise.MdiParent = frmMain
                frmExercise.Show()
            Else
                If P_FormFlag = "PRACTICE" Then
                    P_UserName = Trim(txtUserid.Text)
                    FrmPracticeList.MdiParent = frmMain
                    FrmPracticeList.Show()

                End If
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'frmExercise.MdiParent = frmMain
        'frmExercise.Show()
        If Len(Trim(txtUserid.Text)) = 8 Then
            If P_FormFlag = "EXAM" Then
                frmExercise.MdiParent = frmMain
                frmExercise.Show()
            Else
                If P_FormFlag = "PRACTICE" Then
                    FrmPracticeList.MdiParent = frmMain
                    FrmPracticeList.Show()
                End If
            End If
        End If
    End Sub

    Private Sub FrmUserInput_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim S As System.Windows.Forms.SendKeys
        '  txtUserid.Text = P_UserName
        txtUserid.Select()
        S.Send("{Home}+{End}")
    End Sub
End Class