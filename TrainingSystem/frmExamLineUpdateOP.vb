Public Class frmExamLineUpdateOP
    Dim OPID As String

    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        UpLoadRefresh(Trim(Me.txtUserID.Text.ToString()))
    End Sub

    Private Sub frmExamLineUpdateOP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpLoadRefresh("")
    End Sub

    Private Sub cmdUpdate_Click(sender As Object, e As EventArgs) Handles cmdUpdate.Click
        txtUserID.Text = ""
        UpLoadRefresh("")
    End Sub

    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub UpLoadRefresh(UserID As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        txtExamTitle.Text = ""
        txtDeptCode.Text = ""
        txtExamType.Text = ""
        txtLine.Text = ""
        txtUserName.Text = ""
        txtActive.Text = ""
        cmdEnable.Enabled = False
        cmdDisable.Enabled = False

        StrSql = "exec Training_Operate @OPItem='QueryExamUsers',@UserID=" & sq(UserID) & ",@UID='" & P_UserName & "'"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "ExamUsers")
            DataGV.DataSource = ds.Tables("ExamUsers")
            DataGV.Refresh()
        End If
    End Sub

    Private Sub DataGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGV.CellClick
        If DataGV.Rows.Count > 0 And e.RowIndex >= 0 Then
            txtUserID.Text = DataGV.Rows(e.RowIndex).Cells("UserID").Value.ToString()
            OPID = txtUserID.Text
            txtUserName.Text = DataGV.Rows(e.RowIndex).Cells("UserName").Value.ToString()
            txtDeptCode.Text = DataGV.Rows(e.RowIndex).Cells("DeptCode").Value.ToString()
            txtExamTitle.Text = DataGV.Rows(e.RowIndex).Cells("Title").Value.ToString()
            txtExamType.Text = DataGV.Rows(e.RowIndex).Cells("ExamType").Value.ToString()
            txtLine.Text = DataGV.Rows(e.RowIndex).Cells("Line").Value.ToString()
            txtActive.Text = DataGV.Rows(e.RowIndex).Cells("Active").Value.ToString()

            If txtUserID.Text = "" Then
                cmdEnable.Enabled = False
                cmdDisable.Enabled = False
            ElseIf txtActive.Text = "Y" Then
                cmdEnable.Enabled = False
                cmdDisable.Enabled = True
            Else
                cmdEnable.Enabled = True
                cmdDisable.Enabled = False
            End If
        End If
    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged
        If txtUserID.Text = "" Or txtUserID.Text <> OPID Then
            cmdEnable.Enabled = False
            cmdDisable.Enabled = False
        ElseIf txtActive.Text = "Y" Then
            cmdEnable.Enabled = False
            cmdDisable.Enabled = True
        Else
            cmdEnable.Enabled = True
            cmdDisable.Enabled = False
        End If
    End Sub

    Private Sub cmdEnable_Click(sender As Object, e As EventArgs) Handles cmdEnable.Click
        UploadExamOperator(txtUserID.Text, txtExamTitle.Text, txtExamType.Text, "Y")
    End Sub

    Private Sub cmdDisable_Click(sender As Object, e As EventArgs) Handles cmdDisable.Click
        UploadExamOperator(txtUserID.Text,txtExamTitle.Text,txtExamType.Text,"N")
    End Sub


    Private Sub UploadExamOperator(UserID As String, ExamTitle As String, ExamType As String, Active As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        StrSql = "exec Training_Operate @OPItem='UpdateExamUsers',@UserID=" & sq(UserID) & ",@ExamTitle=" & sq(ExamTitle) & ",@ExamType=" & sq(ExamType) & ",@Active=" & sq(Active) & ",@UID='" & P_UserName & "'"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            UpLoadRefresh(Trim(Me.txtUserID.Text.ToString()))
            MessageBox.Show("更新成功!")
        Else
            MessageBox.Show("更新失敗!")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub txtActive_TextChanged(sender As Object, e As EventArgs) Handles txtActive.TextChanged

    End Sub

    Private Sub txtUserName_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged

    End Sub

    Private Sub txtDeptCode_TextChanged(sender As Object, e As EventArgs) Handles txtDeptCode.TextChanged

    End Sub

    Private Sub txtExamType_TextChanged(sender As Object, e As EventArgs) Handles txtExamType.TextChanged

    End Sub

    Private Sub txtExamTitle_TextChanged(sender As Object, e As EventArgs) Handles txtExamTitle.TextChanged

    End Sub

    Private Sub txtLine_TextChanged(sender As Object, e As EventArgs) Handles txtLine.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class