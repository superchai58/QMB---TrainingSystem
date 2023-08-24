Module modExcel
    Public Sub CopyToExcel(ByVal rst As ADODB.Recordset)
        Dim xlapp As Excel.Application
        Dim xlsbook As Excel.Workbook
        Dim xlWs As Object
        Dim recArray As Object
        'Dim strDB As String
        Dim fldCount As Integer
        Dim recCount As Integer
        Dim iCol As Integer
        Dim iRow As Integer

        xlapp = CreateObject("Excel.Application")
        xlsbook = xlapp.Workbooks.Add
        xlapp.DisplayAlerts = False
        xlWs = xlapp.Worksheets(1)
        xlapp.UserControl = True
        fldCount = rst.Fields.Count
        For iCol = 1 To fldCount
            xlWs.Cells.Select()
            xlWs.Cells.NumberFormatLocal = "@"
            xlWs.Cells(1, iCol).Value = rst.Fields(iCol - 1).Name
        Next
        If Val(Left(xlapp.Version, 1)) > 8 Then
            xlWs.Cells.Select()
            xlWs.Cells.NumberFormatLocal = "@"
            xlWs.Cells(2, 1).CopyFromRecordset(rst)
        Else
            recArray = rst.GetRows
            recCount = UBound(recArray, 2) + 1 '+ 1 since 0-based array
            For iCol = 0 To fldCount - 1
                For iRow = 0 To recCount - 1


                    'If IsDate(recArray(iCol, iRow)) Then
                    '    recArray(iCol, iRow) = VB6.Format(recArray(iCol, iRow))
                    'ElseIf IsArray(recArray(iCol, iRow)) Then

                    If IsArray(recArray(iCol, iRow)) Then
                        recArray(iCol, iRow) = "Array Field"
                    End If
                Next iRow 'next record
            Next iCol 'next field
            xlWs.Cells.Select()
            xlWs.Cells.NumberFormatLocal = "@"
            xlWs.Cells(2, 1).Resize(recCount, fldCount).Value = TransposeDim(recArray)
        End If
        xlapp.Selection.CurrentRegion.Columns.AutoFit()
        xlapp.Selection.CurrentRegion.Rows.AutoFit()
        xlapp.Visible = True
        rst.Close()
        rst = Nothing
        xlapp = Nothing
        xlsbook = Nothing
    End Sub
    Function TransposeDim(ByRef v As Object) As Object
        Dim Xupper, X, Y, Yupper As Integer
        Dim tempArray As Object
        Xupper = UBound(v, 2)
        Yupper = UBound(v, 1)
        ReDim tempArray(Xupper, Yupper)
        For X = 0 To Xupper
            For Y = 0 To Yupper
                tempArray(X, Y) = v(Y, X)
            Next Y
        Next X
        TransposeDim = tempArray
    End Function
End Module
