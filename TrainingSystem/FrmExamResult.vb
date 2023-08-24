Public Class FrmExamResult
    Private Sub frmExamResult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim rst As New ADODB.Recordset

        Me.dtpSDate.Value = DateAdd("m", -1, Me.dtpSDate.Value)
        Me.dtpEDate.Value = DateAdd("d", 1, Me.dtpEDate.Value)
    End Sub
    Private Sub cmdQuery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdQuery.Click
        Dim rs As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim StartTime As String '1003
        Dim EndTime As String '1003

        If Checkbytime.Checked = False Then
            'StartTime = "20010101" '1003
            StartTime = Me.dtpSDate.Value.ToString("yyyyMMddHHmmss") '1003        'superchai Add 20230824
            EndTime = Me.dtpEDate.Value.ToString("yyyyMMddHHmmss") '1003
        Else
            StartTime = Me.dtpSDate.Value.ToString("yyyyMMddHHmmss") '1003
            EndTime = Me.dtpEDate.Value.ToString("yyyyMMddHHmmss") '1003
        End If
        'If TxtExamScheduleID.Text.Trim = "" Then
        '    MsgBox("ÇëÊäÈë¿¼ÊÔ¼Æ»®µÄID", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If
        If cmbType.Text.Trim = "" Then
            MsgBox("Please select type/โปรดเลิอกประเภท", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If
        StrSql = "exec  OP_QryExamResult_bytime_TEST'" & txtUserID.Text.Trim & "', '" & cmbType.Text.Trim & "','" & TxtExamScheduleID.Text.Trim & "','" & P_BU & "','" & StartTime & "','" & EndTime & "'" '0001'0003
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            da.Fill(ds, rs, "ExamResult")
            DataGV.DataSource = ds.Tables("ExamResult")
        Else
            MsgBox("No Data£¡", MsgBoxStyle.Critical, "Error")
            DataGV.DataSource = DBNull.Value
            Exit Sub
        End If
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Dim rs As New ADODB.Recordset
        Dim StartTime As String '1003
        Dim EndTime As String '1003
        'If TxtExamScheduleID.Text.Trim = "" Then
        '    MsgBox("ÇëÊäÈë¿¼ÊÔ¼Æ»®µÄID", MsgBoxStyle.Critical, "Error")
        '    Exit Sub
        'End If
        If cmbType.Text.Trim = "" Then
            MsgBox("ÇëÊäÈë¿¼ÊÔÀàÐÍ£¡", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End If

        If Checkbytime.Checked = False Then
            StartTime = Me.dtpSDate.Value.ToString("yyyyMMddHHmmss") '1003        'superchai add 20230824
            EndTime = Me.dtpEDate.Value.ToString("yyyyMMddHHmmss") '1003
        Else
            StartTime = Me.dtpSDate.Value.ToString("yyyyMMddHHmmss") '1003
            EndTime = Me.dtpEDate.Value.ToString("yyyyMMddHHmmss") '1003
        End If

        StrSql = "exec  OP_QryExamResult_bytime_TEST'" & txtUserID.Text.Trim & "', '" & cmbType.Text.Trim & "','" & TxtExamScheduleID.Text.Trim & "','" & P_BU & "','" & StartTime & "','" & EndTime & "'" '0001'0003
        'StrSql = "exec  OP_QryExamResult  '" & txtUserID.Text.Trim & "', '" & cmbType.Text.Trim & "', '" & TxtExamScheduleID.Text.Trim & "','" & P_BU & "'" '0001
        rs = Conn.Execute(StrSql)
        If rs.EOF = False Then
            Call CopyToExcel(rs)
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub dtpEDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpEDate.ValueChanged

    End Sub

    Private Sub dtpSDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpSDate.ValueChanged

    End Sub

    Private Sub TxtExamScheduleID_TextChanged(sender As Object, e As EventArgs) Handles TxtExamScheduleID.TextChanged

    End Sub

    Private Sub cmbType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbType.SelectedIndexChanged

    End Sub

    Private Sub txtUserID_TextChanged(sender As Object, e As EventArgs) Handles txtUserID.TextChanged

    End Sub
End Class