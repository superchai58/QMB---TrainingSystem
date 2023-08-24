
' Implements the manual sorting of items by column.
Class clsLvwItemComparer
    Implements IComparer
    Private order As SortOrder
    Private col As Integer

    Public Sub New()
        col = 0
    End Sub

    Public Sub New(ByVal column As Integer)
        col = column
    End Sub

    Public Sub New(ByVal column As Integer, ByVal order As SortOrder)
        col = column
        Me.order = order
    End Sub

    Public Function Compare(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim returnVal As Integer = -1

        returnVal = [String].Compare(CType(x, ListViewItem).SubItems(col).Text, CType(y, ListViewItem).SubItems(col).Text)
        Return returnVal

    End Function

End Class

'//C#

'// Implements the manual sorting of items by column.

'class ListViewItemComparer : IComparer {

'private int col;

'public ListViewItemComparer() {

'col=0;

'}

'public ListViewItemComparer(int column) 

'{

'col=column;

'}

'public int Compare(object x, object y) 

'{

'int returnVal = -1;

'returnVal = String.Compare(((ListViewItem)x).SubItems[col].Text,

'((ListViewItem)y).SubItems[col].Text);

'return returnVal;

'}

'}
