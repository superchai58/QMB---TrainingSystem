Public Class frmQuerySkillCardResult
    Private Sub RefreshData()
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter

        'Request 4 Warinya 20230825
        'StrSql = "Exec OP_QryExamSubject -1,N'', N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) '0001

        'StrSql = "Exec OP_QryExamSubject_test -1,N" & sq(txtTitle.Text.Trim) & ", N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) & ",N" & sq(txtRemark.Text.Trim) '0001
        'Request 4 Warinya 20230825
        StrSql = "Exec OP_QuerySkillCardResult"
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            da.Fill(ds, rst, "Table1")
            DataGV.DataSource = ds.Tables("Table1")
            DataGV.Refresh()

            ClearDefault()
        Else
            MsgBox("There is no information!", MsgBoxStyle.Critical, "Error")

            ds = New DataSet()
            DataGV.DataSource = ds.Tables("Table1")
            DataGV.Refresh()

            ClearDefault()
        End If
    End Sub

    Private Sub cmdQuery_Click(sender As Object, e As EventArgs) Handles cmdQuery.Click
        RefreshData()
    End Sub

    Private Sub btnClearDefault_Click(sender As Object, e As EventArgs) Handles btnClearDefault.Click
        ClearDefault()
    End Sub

    Private Sub ClearDefault()
        txtName.Text = ""
        txtOPID.Text = ""
        txtPicture.Text = ""
        txtPractice.Text = ""
        txtResult.Text = ""
        txtScheduleID.Text = ""
        txtTheory.Text = ""
        txtValiddate.Text = ""
    End Sub

    Private Sub DataGV_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGV.CellDoubleClick
        '------------superchai add 20231004 (B)-------------
        txtOPID.Text = DataGV.Rows(e.RowIndex).Cells(0).Value.ToString().Trim()
        txtName.Text = DataGV.Rows(e.RowIndex).Cells(1).Value.ToString().Trim()
        txtScheduleID.Text = DataGV.Rows(e.RowIndex).Cells(2).Value.ToString().Trim()
        txtTheory.Text = DataGV.Rows(e.RowIndex).Cells(3).Value.ToString().Trim()
        txtPicture.Text = DataGV.Rows(e.RowIndex).Cells(4).Value.ToString().Trim()
        txtPractice.Text = DataGV.Rows(e.RowIndex).Cells(5).Value.ToString().Trim()
        txtResult.Text = DataGV.Rows(e.RowIndex).Cells(6).Value.ToString().Trim()
        txtValiddate.Text = DataGV.Rows(e.RowIndex).Cells(7).Value.ToString().Trim()
        'var dataIndexNo = DataGV.Rows[e.RowIndex].Index.ToString();
        'String cellValue = DataGV.Rows[e.RowIndex].Cells[1].Value.ToString();
        '------------superchai add 20231004 (E)-------------
    End Sub

    Private Sub btnSkillCard_Click(sender As Object, e As EventArgs) Handles btnSkillCard.Click
        If txtOPID.Text.Trim() = "" And txtValiddate.Text.Trim() = "" Then
            MsgBox("There is no information! Please select information first.", MsgBoxStyle.Critical, "Error")
        Else
            Dim rst As New ADODB.Recordset
            Dim ds As New DataSet
            Dim da As New System.Data.OleDb.OleDbDataAdapter

            'Request 4 Warinya 20230825
            'StrSql = "Exec OP_QryExamSubject -1,N'', N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) '0001

            'StrSql = "Exec OP_QryExamSubject_test -1,N" & sq(txtTitle.Text.Trim) & ", N" & sq(cmbQuestionGroup.Text.Trim) & ",N" & sq(cmbQuestionType.Text.Trim) & "," & sq(P_BU) & ",N" & sq(txtRemark.Text.Trim) '0001
            'Request 4 Warinya 20230825
            StrSql = "Exec OP_DeleteSkillCardResult '" & txtOPID.Text.Trim() & "', '" & txtValiddate.Text.Trim() & "'"
            rst = Conn.Execute(StrSql)
            If rst.EOF = False Then
                If rst.Fields("Msg").Value = "OK" Then
                    MsgBox("Deleted OK!", MsgBoxStyle.Information, "Information")
                    RefreshData()
                Else
                    MsgBox("There is no information! Deleted error!", MsgBoxStyle.Critical, "Error")
                End If
            Else
                MsgBox("There is no information! Deleted error!", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
End Class