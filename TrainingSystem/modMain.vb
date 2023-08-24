Module modMain
    Public TStation As String      'superchai add 20230824
    Public FullLine As String      'superchai add 20230824
    Public Sub main()
        Try
            '-----------------------superchai add station from mainmenu 20230824 (B)--------------------------------
            If My.Application.Info.Title <> Application.ExecutablePath Then
                If Command() = "" Then
                    If ConnStr = "" Then
                        MsgBox("Please Use MainMenu")
                        End
                    End If
                Else
                    If InStr(1, Command, "<LINE=", vbTextCompare) > 0 Then
                        FullLine = Mid(Mid(Command, InStr(1, Command, "<LINE=", vbTextCompare) + Len("<LINE="), Len(Command)), 1, InStr(1, Mid(Command, InStr(1, Command, "<LINE=", vbTextCompare) + Len("<LINE="), Len(Command)), ">") - 1)

                    End If
                    If InStr(1, Command, "<STATION=", vbTextCompare) > 0 Then
                        TStation = Mid(Mid(Command, InStr(1, Command, "<Station=", vbTextCompare) + Len("<Station="), Len(Command)), 1, InStr(1, Mid(Command, InStr(1, Command, "<STATION=", vbTextCompare) + Len("<STATION="), Len(Command)), ">") - 1)
                    End If

                    ConnStr = "PROVIDER=SQLOLEDB;SERVER=10.94.7.11;UID=MunSFUser;PWD=is6<2g;DATABASE=Training"
                    'ConnStr = ReadIniFile("Training", "ConnStr", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                    P_ProhibitProgList = ReadIniFile("Training", "ProhibitProgList", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                    P_BU = ReadIniFile("Training", "BU", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                    PhotoPath = ReadIniFile("Training", "PhotoPath", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                    If PhotoPath.Trim = "" Then
                    Else
                        If Mid(PhotoPath.Trim, Len(PhotoPath.Trim), 1) <> "\" Then
                            PhotoPath = PhotoPath & "\"
                        End If
                    End If
                End If
            Else
                'On Error GoTo ErrHdl
                'ConnStr = ReadIniFile("Training", "Connection", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                'ConnStr = "PROVIDER=SQLOLEDB;SERVER=172.26.6.6;UID=sa;PWD=pqms#9vd;DATABASE=Training"
                'ConnStr = "PROVIDER=SQLOLEDB;SERVER=192.168.20.39;UID=MunSFUser;PWD=is6<2g;DATABASE=Training"
                ConnStr = "PROVIDER=SQLOLEDB;SERVER=10.94.7.11;UID=MunSFUser;PWD=is6<2g;DATABASE=Training"
                'ConnStr = ReadIniFile("Training", "ConnStr", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                P_ProhibitProgList = ReadIniFile("Training", "ProhibitProgList", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                P_BU = ReadIniFile("Training", "BU", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                PhotoPath = ReadIniFile("Training", "PhotoPath", System.Windows.Forms.Application.StartupPath() & "\set.ini")
                If PhotoPath.Trim = "" Then
                Else
                    If Mid(PhotoPath.Trim, Len(PhotoPath.Trim), 1) <> "\" Then
                        PhotoPath = PhotoPath & "\"
                    End If
                End If
            End If
            '-----------------------superchai add station from mainmenu 20230824 (E)--------------------------------

            '-----------Old code (B)-----------
            ''On Error GoTo ErrHdl
            ''ConnStr = ReadIniFile("Training", "Connection", System.Windows.Forms.Application.StartupPath() & "\set.ini")
            ''ConnStr = "PROVIDER=SQLOLEDB;SERVER=172.26.6.6;UID=sa;PWD=pqms#9vd;DATABASE=Training"
            ''ConnStr = "PROVIDER=SQLOLEDB;SERVER=192.168.20.39;UID=MunSFUser;PWD=is6<2g;DATABASE=Training"
            'ConnStr = "PROVIDER=SQLOLEDB;SERVER=10.94.7.11;UID=MunSFUser;PWD=is6<2g;DATABASE=Training"
            ''ConnStr = ReadIniFile("Training", "ConnStr", System.Windows.Forms.Application.StartupPath() & "\set.ini")
            'P_ProhibitProgList = ReadIniFile("Training", "ProhibitProgList", System.Windows.Forms.Application.StartupPath() & "\set.ini")
            'P_BU = ReadIniFile("Training", "BU", System.Windows.Forms.Application.StartupPath() & "\set.ini")
            'PhotoPath = ReadIniFile("Training", "PhotoPath", System.Windows.Forms.Application.StartupPath() & "\set.ini")
            'If PhotoPath.Trim = "" Then
            'Else
            '    If Mid(PhotoPath.Trim, Len(PhotoPath.Trim), 1) <> "\" Then
            '        PhotoPath = PhotoPath & "\"
            '    End If
            'End If
            '-----------Old code (E)-----------

            Conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            Conn.Open(ConnStr)
            frmLogin.ShowDialog()

            Exit Sub
ErrHdl:
            MsgBox("Connection Error " & (Err.Description))
            End
        Catch ex As Exception
            MsgBox("Connection Error " & (Err.Description))
        End Try
    End Sub


    Public Function sq(ByVal Field As String) As String
        Field = Replace(Replace(Trim(Field), Chr(13), ""), Chr(10), "")
        sq = "'" & Field & "'"
    End Function

    Public Function DataFilter(ByVal tblSource As DataTable, ByVal colKey As String, ByVal colValue As String) As DataTable
        On Error GoTo ErrHandler
        Dim dtTemp As DataTable
        Dim dtFilter As DataTable
        Dim myDataRow As DataRow
        Dim intColCount As Integer
        Dim drList() As DataRow
        Dim iRow As Integer
        Dim iCol As Integer
        Dim mydataType As String

        dtTemp = tblSource
        mydataType = dtTemp.Columns(colKey).DataType.ToString
        If mydataType = "System.Int32" Or mydataType = "System.Int16" Or mydataType = "System.Int64" Then
            drList = dtTemp.Select(colKey + " = " + colValue.Trim())
        Else
            drList = dtTemp.Select(colKey + " like  '" + colValue.Trim() + "%'")
        End If

        dtFilter = dtTemp.Clone()

        intColCount = dtTemp.Columns.Count
        For iRow = 0 To drList.Length - 1
            myDataRow = dtFilter.NewRow()
            For iCol = 0 To intColCount - 1
                myDataRow(iCol) = drList(iRow)(iCol).ToString()
            Next
            dtFilter.Rows.Add(myDataRow)
        Next

        DataFilter = dtFilter

        Exit Function
ErrHandler:

        Err.Clear()
    End Function


End Module
