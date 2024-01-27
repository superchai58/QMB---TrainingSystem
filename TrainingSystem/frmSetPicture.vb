Public Class frmSetPicture
    Public mExamNo As Integer
    Public mTitle As String
    Private dtExamQeustions As DataTable
    Private mQuestionType As String   'provide Text Question Only(Text/Pic)
    Private mExamQty As Integer
    Public mExamType As String
    Dim sortColumn As Integer = -1

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        Dim SelItem As System.Windows.Forms.ListViewItem
        Dim SelIndex As Integer
        Dim iIndex As Integer
        SelIndex = lvwItem.SelectedItems(0).Index
        If SelIndex = 0 Then Exit Sub

        SelItem = lvwItem.SelectedItems(0)
        lvwItem.Items.RemoveAt(SelIndex)
        lvwItem.Items.Insert(SelIndex - 1, SelItem)

        For iIndex = 1 To lvwItem.Items.Count
            lvwItem.Items(iIndex - 1).Text = iIndex
        Next iIndex
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        Dim SelItem As System.Windows.Forms.ListViewItem
        Dim SelIndex As Integer
        Dim iIndex As Integer
        SelIndex = lvwItem.SelectedItems(0).Index
        If SelIndex = lvwItem.Items.Count - 1 Then Exit Sub

        SelItem = lvwItem.SelectedItems(0)
        lvwItem.Items.RemoveAt(SelIndex)
        lvwItem.Items.Insert(SelIndex + 1, SelItem)

        For iIndex = 1 To lvwItem.Items.Count
            lvwItem.Items(iIndex - 1).Text = iIndex
        Next iIndex
    End Sub

    Private Sub lvwItem_ColumnClick(sender As Object, e As ColumnClickEventArgs) Handles lvwItem.ColumnClick
        ' Determine whether the column is the same as the last column clicked.
        If e.Column <> sortColumn Then
            ' Set the sort column to the new column.
            sortColumn = e.Column
            ' Set the sort order to ascending by default.
            lvwItem.Sorting = SortOrder.Ascending
        Else
            ' Determine what the last sort order was and change it.
            If lvwItem.Sorting = SortOrder.Ascending Then
                lvwItem.Sorting = SortOrder.Descending
            Else
                lvwItem.Sorting = SortOrder.Ascending
            End If

        End If

        ' Call the sort method to manually sort.
        lvwItem.Sort()
        ' Set the ListViewItemSorter property to a new ListViewItemComparer
        ' object.

        lvwItem.ListViewItemSorter = New clsLvwItemComparer(e.Column, lvwItem.Sorting)
    End Sub

    Private Sub frmSetPicture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lvwItem.Columns.Clear()
        lvwItem.Items.Clear()

        lvwItem.Columns.Add("No", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Question_No", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Exercise", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("A", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("B", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("C", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("D", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Answer", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Question_Group", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Question_Type", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("DutyGroup", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("TopicPicture", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Version", 10, HorizontalAlignment.Left)

        lvwItem.Columns(0).Width = 100
        lvwItem.Columns(1).Width = 100
        lvwItem.Columns(2).Width = 100
        lvwItem.Columns(3).Width = 100
        lvwItem.Columns(4).Width = 100
        lvwItem.Columns(5).Width = 100
        lvwItem.Columns(6).Width = 100
        lvwItem.Columns(7).Width = 100
        lvwItem.Columns(8).Width = 100
        lvwItem.Columns(9).Width = 100
        lvwItem.Columns(10).Width = 100
        lvwItem.Columns(11).Width = 100
        lvwItem.Columns(12).Width = 100

        txtExamNo.Text = mExamNo
        txtTitle.Text = mTitle
        InitLvwView(mExamNo, "Picture")
    End Sub

    Private Sub InitLvwView(ByVal ExamNo As Integer, ByVal ExamType As String)
        Dim rst As New ADODB.Recordset
        Dim ds As New DataSet
        Dim da As New System.Data.OleDb.OleDbDataAdapter
        Dim lstItem As System.Windows.Forms.ListViewItem

        StrSql = "exec OP_QryExamContent @ExamNo=" & ExamNo & ",@ExamType=" & sq(ExamType) & ",@QuestionType=''" & ",@BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)

        lvwItem.Items.Clear()
        Do While rst.EOF = False
            lstItem = lvwItem.Items.Add(lvwItem.Items.Count + 1)
            lstItem.SubItems.Add(rst("Question_No").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Exercise").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("A").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("B").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("C").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("D").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Answer").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Question_Group").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Question_Type").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("DutyGroup").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("TopicPicture").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Version").Value.ToString.Trim)
            rst.MoveNext()
        Loop

    End Sub
End Class