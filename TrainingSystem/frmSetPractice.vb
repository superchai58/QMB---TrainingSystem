Public Class frmSetPractice
    Public mExamNo As Integer
    Public mTitle As String
    Private mQuestionType As String
    Dim sortColumn As Integer = -1

    'AddHandler lvwItem.ColumnClick, AddressOf Me.lvwItem_ColumnClick
    'lvwItem.ListViewItemSorter = New clsLvwItemComparer(e.Column)

    Private Sub frmSetPractice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbQuestionGroup.Items.Add("OPExam")
        cmbQuestionGroup.SelectedIndex = 0
        lvwItem.Columns.Clear()
        lvwItem.Items.Clear()

        lvwItem.Columns.Add("编号", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("SubID", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("实作子项", 50, HorizontalAlignment.Left)
        lvwItem.Columns.Add("分值", 10, HorizontalAlignment.Left)
        lvwItem.Columns.Add("Version", 10, HorizontalAlignment.Left)

        lvwItem.Columns(0).Width = 50
        lvwItem.Columns(1).Width = 50
        lvwItem.Columns(2).Width = 390
        lvwItem.Columns(3).Width = 80
        lvwItem.Columns(4).Width = 50
        txtExamNo.Text = mExamNo
        txtTitle.Text = mTitle
        InitLvwView(mExamNo, "Practice")

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim lstItem As System.Windows.Forms.ListViewItem
        If txtSubItem.Text.Trim = "" Or IsNumeric(txtRateScore.Text.Trim) = False Then
            MsgBox("请输入实作子项及正确的所占分值！", MsgBoxStyle.Critical, "Error")
            Exit Sub

        End If

        lstItem = lvwItem.Items.Add(lvwItem.Items.Count + 1)
        lstItem.SubItems.Add(txtSubItem.Text.Trim)
        lstItem.SubItems.Add(txtRateScore.Text.Trim)

        txtSubItem.Text = ""
        txtRateScore.Text = ""
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim iIndex As Integer
        If lvwItem.SelectedItems.Count > 0 Then
            lvwItem.Items.RemoveAt(lvwItem.SelectedItems(0).Index)
        End If

        For iIndex = 1 To lvwItem.Items.Count
            lvwItem.Items(iIndex - 1).Text = iIndex
        Next iIndex

    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
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

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
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

    Private Sub cmdConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfirm.Click
        Dim ItemList As String
        Dim rst As ADODB.Recordset

        If ValidData() = False Then Exit Sub
        ItemList = GetItemList()

        StrSql = "exec OP_SetExamPractice @ActionType='Insert',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(cmbQuestionGroup.Text.Trim) & ",@ItemList=N" & sq(ItemList) & ",@BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            If rst("Result").Value.ToString.Trim <> "0" Then
                MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
                Exit Sub
            End If
        Else
            MsgBox(" OP SetExamContent Ins fail！", MsgBoxStyle.Critical, "OP Exam")
            Exit Sub
        End If

        MsgBox(" 保存成功！", MsgBoxStyle.Critical, "OP Exam")
    End Sub

    Private Function ValidData() As Boolean
        Dim iRow As Integer
        Dim iRowScore As Integer
        Dim TotalScore As Integer

        ValidData = False
        For iRow = 0 To lvwItem.Items.Count - 1
            iRowScore = CInt(lvwItem.Items(iRow).SubItems(2).Text.Trim)
            TotalScore = TotalScore + iRowScore
        Next

        If TotalScore <> 100 Then
            MsgBox("你所设定的分数满分需为：100 ", MsgBoxStyle.Critical, "OP Exam")
            Exit Function
        End If

        ValidData = True
    End Function

    Private Function GetItemList() As String
        Dim iRow As Integer
        Dim iRowItem As String
        Dim ItemList As String

        ItemList = String.Empty
        For iRow = 0 To lvwItem.Items.Count - 1
            ''编号-分值-实作子项
            iRowItem = lvwItem.Items(iRow).SubItems(0).Text.Trim & "," & lvwItem.Items(iRow).SubItems(1).Text.Trim & "," & lvwItem.Items(iRow).SubItems(2).Text.Trim

            ItemList = ItemList & iRowItem & "@@"
        Next

        GetItemList = ItemList.Substring(0, ItemList.Length - "@@".Length)
    End Function


    Private Sub lvwItem_ColumnClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles lvwItem.ColumnClick
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

    Private Sub btnDelAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelAll.Click
        Dim ItemList As String
        Dim rst As ADODB.Recordset

        If MsgBox("确定要删除吗！", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "OP Exam") = MsgBoxResult.No Then Exit Sub
        ItemList = GetItemList()

        StrSql = "exec OP_SetExamPractice @ActionType='Delete',@UserID= " & sq(P_UserName) & ",@ExamNo=" & mExamNo & ",@QuestionGroup=N" & sq(cmbQuestionGroup.Text.Trim) & ",@ItemList=N" & sq(ItemList) & ",@BU=" & sq(P_BU)
        rst = Conn.Execute(StrSql)
        If rst.EOF = False Then
            If rst("Result").Value.ToString.Trim <> "0" Then
                MsgBox(rst("Description").Value.ToString.Trim, MsgBoxStyle.Critical, "OP Exam")
                Exit Sub
            End If
        Else
            MsgBox(" OP SetExamContent Ins fail！", MsgBoxStyle.Critical, "OP Exam")
            Exit Sub
        End If

        MsgBox(" 删除成功！", MsgBoxStyle.Critical, "OP Exam")
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
            lstItem.SubItems.Add(rst("SubID").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("SubItem").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("RateScore").Value.ToString.Trim)
            lstItem.SubItems.Add(rst("Version").Value.ToString.Trim)

            rst.MoveNext()
        Loop

    End Sub

End Class