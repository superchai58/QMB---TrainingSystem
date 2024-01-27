Imports System.Data
Imports System.Data.SqlClient
Imports System.Runtime.InteropServices

Module modPara
    Friend ExcelGlobal_definst As New Excel.Global
    Structure ExamData
        Dim Question_Group As String
        Dim Question_Type As String
        Dim Question As String
        Dim A As String
        Dim B As String
        Dim C As String
        Dim D As String
        Dim Answer As String
        Dim CorrectAnswer As String
        Dim PictureName As String
    End Structure
    Structure PracticeExamData
        Dim Question As String
        Dim Score As String
        Dim MaxScore As String
    End Structure
    Structure PhotoExamData
        Dim Question_Group As String
        Dim Question_Type As String
        Dim Question As String
        Dim E1 As String
        Dim E2 As String
        Dim E3 As String
        Dim E4 As String
        Dim E5 As String
        Dim A As String
        Dim B As String
        Dim C As String
        Dim D As String
        Dim Answer As String
        Dim CorrectAnswer As String
    End Structure
    Structure ColPos
        Dim StartPos As Integer
        Dim EndPos As Integer
    End Structure
    Public Declare Function GetPrivateProfileString Lib "kernel32" Alias "GetPrivateProfileStringA" (ByVal lpApplicationName As String, ByVal lpKeyName As String, ByVal lpDefault As String, ByVal lpReturnedString As String, ByVal nSize As Integer, ByVal lpFileName As String) As Integer
    Public ConnStr As String
    Public PhotoPath As String
    Public Conn As New ADODB.Connection
    Public rs As New ADODB.Recordset
    Public StrSql As String
    Public P_UserName As String
    Public P_BU As String   '0001
    Public P_Userright() As String
    Public P_RightLevel As String
    Public RightDept As String
    Public P_FormFlag As String
    Public P_PhotoFlag As Boolean
    Public P_ProhibitProgList As String

    Public Function FunCodeMask(ByVal Source As String) As String
        Dim i As Integer, strDESC As String
        For i = 1 To Len(Source)
            strDESC = strDESC + CStr(Chr(Asc(Mid(Source, i, 1)) Xor 27))
        Next i
        FunCodeMask = strDESC
    End Function
    Public Function ReadIniFile(ByVal strSection As String, ByVal strKey As String, ByVal strFname As String) As String
        Dim strValue As String
        Dim intRet As Integer
        strValue = New String(CChar("     "), 255)

        On Error Resume Next
        intRet = GetPrivateProfileString(strSection, strKey, "", strValue, Len(strValue), strFname)
        ReadIniFile = Left(strValue, intRet)
    End Function
    Public Sub WriteToListview(ByRef lvw As System.Windows.Forms.ListView, ByRef rs As ADODB.Recordset)
        Dim rstemp As New ADODB.Recordset
        Dim nCH As Short
        Dim lst As System.Windows.Forms.ListViewItem
        'clear listview item.
        '        On Error Resume Next
        lvw.Columns.Clear()
        lvw.Items.Clear()
        '------------------
        For nCH = 0 To rs.Fields.Count - 1
            lvw.Columns.Add(rs.Fields(nCH).Name, rs.Fields(nCH).Name)
        Next
        'add Item info.
        While Not rs.EOF
            lst = lvw.Items.Add(Trim(IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)))
            For nCH = 1 To lvw.Columns.Count - 1
                'UPGRADE_WARNING: ���� lst ���������� 1 ����Ϊ 0�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"��
                If lst.SubItems.Count > nCH Then
                    lst.SubItems(nCH).Text = IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)
                Else
                    lst.SubItems.Insert(nCH, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))
                End If
            Next
            rs.MoveNext()
        End While
    End Sub

    Public Function WriteToListviewCheckBOX(ByRef lvw As System.Windows.Forms.ListView, ByRef rs As ADODB.Recordset) As Object
        Dim nCH As Short
        Dim lst As System.Windows.Forms.ListViewItem
        lvw.Columns.Clear()
        lvw.Items.Clear()
        ''''rs.Fields.Count-2��Ŀ���ǲ���enable����ʾ����
        For nCH = 0 To rs.Fields.Count - 2
            lvw.Columns.Add(UCase(rs.Fields(nCH).Name), UCase(rs.Fields(nCH).Name))
        Next
        'add Item info
        While Not rs.EOF
            'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
            lst = lvw.Items.Add(Trim(IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)))
            For nCH = 1 To lvw.Columns.Count - 1
                'UPGRADE_WARNING: ���� lst ���������� 1 ����Ϊ 0�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"��
                'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
                If lst.SubItems.Count > nCH Then
                    lst.SubItems(nCH).Text = CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))
                Else
                    lst.SubItems.Insert(nCH, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))))
                End If
            Next
            If rs.Fields("enable").Value = "True" Then
                lst.Checked = True
                lst.ForeColor = System.Drawing.Color.Red
            End If
            rs.MoveNext()
        End While
    End Function
    Public Function WriteToListviewCheckBOX_CertifyReslut(ByRef lvw As System.Windows.Forms.ListView, ByRef rs As ADODB.Recordset) As Object
        Dim nCH As Short
        Dim lst As System.Windows.Forms.ListViewItem
        lvw.Columns.Clear()
        lvw.Items.Clear()
        ''''rs.Fields.Count-2��Ŀ���ǲ���enable����ʾ����
        For nCH = 0 To rs.Fields.Count - 1
            lvw.Columns.Add(UCase(rs.Fields(nCH).Name), UCase(rs.Fields(nCH).Name))
        Next
        'add Item info
        While Not rs.EOF
            'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
            lst = lvw.Items.Add(Trim(IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)))
            lst.ListView.CheckBoxes = True
            For nCH = 1 To lvw.Columns.Count - 1
                'UPGRADE_WARNING: ���� lst ���������� 1 ����Ϊ 0�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"��
                'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
                If lst.SubItems.Count > nCH Then
                    lst.SubItems(nCH).Text = CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))
                Else
                    lst.SubItems.Insert(nCH, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))))
                End If
            Next
            If UCase(rs.Fields("PracticeResult").Value) = "FAIL" Then
                lst.Checked = True
                lst.ForeColor = System.Drawing.Color.Red
            Else
                lst.Checked = False
            End If
            'lst.Text = "PASS"
            rs.MoveNext()
        End While
    End Function
    Public Function WriteToListviewCheckBOX_C(ByRef lvw As System.Windows.Forms.ListView, ByRef rs As ADODB.Recordset) As Object
        Dim nCH As Short
        Dim lst As System.Windows.Forms.ListViewItem
        lvw.Columns.Clear()
        lvw.Items.Clear()
        ''''rs.Fields.Count-2��Ŀ���ǲ���enable����ʾ����
        For nCH = 0 To rs.Fields.Count - 1
            lvw.Columns.Add(UCase(rs.Fields(nCH).Name), UCase(rs.Fields(nCH).Name))
        Next
        'add Item info
        While Not rs.EOF
            'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
            lst = lvw.Items.Add(Trim(IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)))
            lst.ListView.CheckBoxes = True
            For nCH = 1 To lvw.Columns.Count - 1
                'UPGRADE_WARNING: ���� lst ���������� 1 ����Ϊ 0�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"��
                'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
                If lst.SubItems.Count > nCH Then
                    lst.SubItems(nCH).Text = CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))
                Else
                    lst.SubItems.Insert(nCH, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))))
                End If
            Next
            'lst.Text = "PASS"
            rs.MoveNext()
        End While
    End Function
    Public Function WriteToListviewCheckBOX_UnCeritfy(ByRef lvw As System.Windows.Forms.ListView, ByRef rs As ADODB.Recordset) As Object
        Dim nCH As Short
        Dim lst As System.Windows.Forms.ListViewItem
        lvw.Columns.Clear()
        lvw.Items.Clear()
        ''''rs.Fields.Count-2��Ŀ���ǲ���enable����ʾ����
        For nCH = 0 To rs.Fields.Count - 1
            lvw.Columns.Add(UCase(rs.Fields(nCH).Name), UCase(rs.Fields(nCH).Name))
        Next
        'add Item info
        While Not rs.EOF
            'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
            lst = lvw.Items.Add(Trim(IIf(IsDBNull(rs.Fields(0).Value), "", rs.Fields(0).Value)))
            For nCH = 1 To lvw.Columns.Count - 1
                'UPGRADE_WARNING: ���� lst ���������� 1 ����Ϊ 0�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"��
                'UPGRADE_WARNING: ��⵽ʹ���� Null/IsNull()�� �����Ի�ø�����Ϣ:��ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="2EED02CB-5C0E-4DC1-AE94-4FAA3A30F51A"��
                If lst.SubItems.Count > nCH Then
                    lst.SubItems(nCH).Text = CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))
                Else
                    lst.SubItems.Insert(nCH, New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, CStr(Trim(IIf(IsDBNull(rs.Fields(nCH).Value), "", rs.Fields(nCH).Value)))))
                End If
            Next
            If rs.Fields("NotCertify").Value = "NotCertify" Then
                lst.Checked = True
                lst.ForeColor = System.Drawing.Color.Red
            Else
                lst.Checked = False
                lst.ForeColor = System.Drawing.Color.Black
            End If
            rs.MoveNext()
        End While
    End Function
    Public Function VerifyRight(ByRef User As String, ByRef AppName As String, ByRef Right As String) As Boolean
        ''Dim Rs As New ADODB.Recordset
        Dim str As String
        VerifyRight = False
        str = "select userright from userright where username='" & User & "' and  AppName='" & AppName & "' and  UserRight='" & Right & "'"
        Rs = Conn.Execute(str)
        If Not rs.EOF Then
            VerifyRight = True
        End If
    End Function
End Module
