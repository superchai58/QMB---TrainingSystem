Public Class frmUserRight
    Dim sortColumn As Integer = -1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Rs As New ADODB.Recordset
        StrSql = "select a.Username,a.Enname,b.employeename from UserDetail a,MIS_HR_Employee b where a.username=b.employeeid and a.BU='" & P_BU & "'" '0001
        If Rs.State = 1 Then Rs.Close()
        Rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs = Conn.Execute(StrSql)

        WriteToListview(lvwUser, Rs)
        Rs = Nothing
        StrSql = "select distinct appname from rightdetail"
        Rs = Conn.Execute(StrSql)
        While Not Rs.EOF
            cboAppname.Items.Add(Rs.Fields("appname").Value)
            Rs.MoveNext()
        End While

    End Sub

    Private Sub cboAppname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAppname.SelectedIndexChanged
        Dim Rs As New ADODB.Recordset
        cboRight.Items.Clear()
        StrSql = "select userright from rightdetail where appname='" & cboAppname.Text & "'"
        Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs = Conn.Execute(StrSql)
        Conn.Execute(StrSql)
        While Not Rs.EOF
            cboRight.Items.Add(Rs.Fields("userright").Value)
            Rs.MoveNext()
        End While
        Rs = Nothing
    End Sub

    Private Sub cboRight_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboRight.SelectedIndexChanged
        Dim Rs As New ADODB.Recordset
        StrSql = "select distinct b.username,isnull(c.employeename,a.username) as ChName from UserRight a left outer join UserDetail b on a.username=b.username " & _
                 " left join MIS_HR_Employee c on b.username=c.employeeid where a.userright='" & Trim(cboRight.Text) & "' and appname='" & Trim(cboAppname.Text) & "' and a.BU='" & P_BU & "'" '0001
        Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs = Conn.Execute(StrSql)
        '    If rs.RecordCount > 0 Then
        Call WriteToListview(lvwUser1, Rs)
        '    End If
        Rs = Nothing
    End Sub
    Private Sub cmdRightCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRightCopy.Click
        Dim Rs As New ADODB.Recordset
        If MsgBox("This action will delete " & txtTargetID.Text.Trim & " old right.Are you sure to do it?", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
            Exit Sub
        End If
        StrSql = "Delete UserRight where username='" & txtTargetID.Text & "'and BU='" & P_BU & "'"  '0001
        Conn.Execute(StrSql)
        StrSql = "insert into UserRight (UserName,UserRight,appName,BU) select replace(username,'" & Trim(txtSourceID.Text) & "','" & Trim(txtTargetID.Text) & "'),userright,appname,BU from UserRight where username='" & txtSourceID.Text & "' and BU='" & P_BU & "'"  '0001
        Conn.Execute(StrSql)
    End Sub

    Private Sub lvwUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lvwUser.Click
        Dim Rs As New ADODB.Recordset
        StrSql = "select userright,[appname],comment," & "(case when userright+[appname] in(select userright+[appname] from userright where BU=" & sq(P_BU) & " and username='" & lvwUser.FocusedItem.Text & "') then 'True' else 'False' end) as [enable]" & "From rightdetail where rightlevel>='" & P_RightLevel & "'"
        If Rs.State = 1 Then Rs.Close()
        Rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Rs.Open(StrSql, Conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        WriteToListviewCheckBOX(lvwRight, Rs)
        Rs = Nothing
    End Sub

    Private Sub lvwUser_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwUser.ColumnClick
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            lvwUser.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lvwUser.Sorting = SortOrder.Ascending Then
                lvwUser.Sorting = SortOrder.Descending
            Else
                lvwUser.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lvwUser.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        lvwUser.ListViewItemSorter = New ListViewItemComparer(e.Column, lvwUser.Sorting)

    End Sub

    Private Sub lvwRight_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwRight.ColumnClick
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            lvwRight.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lvwRight.Sorting = SortOrder.Ascending Then
                lvwRight.Sorting = SortOrder.Descending
            Else
                lvwRight.Sorting = SortOrder.Ascending
            End If
        End If
        ' Call the sort method to manually sort.
        lvwRight.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.
        lvwRight.ListViewItemSorter = New ListViewItemComparer(e.Column, lvwRight.Sorting)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        On Error GoTo Errhandler
        Dim Rs As New ADODB.Recordset
        Dim i As Short
        If lvwRight.Items.Count > 0 Then
            If Rs.State = 1 Then Rs.Close()
            Rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            With lvwRight
                For i = 0 To .Items.Count - 1
                    StrSql = "select * from UserRight where username='" & lvwUser.FocusedItem.Text & "' and userright='" & .Items.Item(i).Text & "' and appname='" & .Items.Item(i).SubItems(1).Text & "'and BU =" & sq(P_BU) & ""
                    Rs.Open(StrSql, Conn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
                    If .Items.Item(i).Checked Then
                        If Rs.EOF Then
                            Rs.AddNew()
                            Rs.Fields("UserName").Value = lvwUser.FocusedItem.Text
                            Rs.Fields("appname").Value = lvwRight.Items.Item(i).SubItems(1).Text
                            Rs.Fields("userright").Value = lvwRight.Items.Item(i).Text
                            Rs.Fields("BU").Value = P_BU
                            Rs.Update()
                        End If
                    Else
                        If Not Rs.EOF Then
                            Rs.Delete(ADODB.AffectEnum.adAffectCurrent)
                            Rs.Update()
                        End If
                    End If
                    Rs.Close()
                Next i
            End With
            Rs = Nothing
        End If
        MsgBox("Right Save OK!", MsgBoxStyle.Information)
        Exit Sub
Errhandler:
        MsgBox(Err.Description)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub lvwUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lvwUser.SelectedIndexChanged

    End Sub
End Class
Class ListViewItemComparer
    Implements IComparer
    Private col As Integer
    Private order As SortOrder
    Public Sub New()
        col = 0
        order = SortOrder.Ascending
    End Sub
    Public Sub New(ByVal column As Integer, ByVal order As SortOrder)
        col = column
        Me.order = order
    End Sub
    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer _
                        Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1
        returnVal = [String].Compare(CType(x, _
                        ListViewItem).SubItems(col).Text, _
                        CType(y, ListViewItem).SubItems(col).Text)
        ' Determine whether the sort order is descending.
        If order = SortOrder.Descending Then
            ' Invert the value returned by String.Compare.
            returnVal *= -1
        End If
        Return returnVal
    End Function
End Class

