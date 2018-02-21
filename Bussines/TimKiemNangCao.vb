'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class TimKiemNangCao_Bussines
#Region "Var"
        Private mFieldSearch As New ESSTimKiemNangCaoTruongTimKiem
        Private mFieldShow As New TimKiemNangCaoTruongHienThi
#End Region
#Region "Functions And Subs"
        Public Sub AddFieldShow(ByVal ID_hien_thi As Integer, ByVal ID_user As Integer, ByVal ID_phan_he As Integer)
            'Load những trường hiển thị
            Dim cls As New TimKiemNangCao_DataAccess
            Dim dt As DataTable
            dt = cls.HienThi_ESSField_Show(ID_hien_thi, ID_user, ID_phan_he)
            If dt.Rows.Count > 0 Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim Field As New TimKiemNangCaoTruongHienThi
                    With dt.Rows(i)
                        Field.FieldID = .Item("FieldID")
                        Field.FieldGroup = .Item("FieldGroup")
                        Field.ColStatistic = .Item("ColStatistic")
                        Field.FieldName = .Item("FieldName")
                        Field.FieldStatistic = .Item("FieldStatistic")
                        Field.FieldGroupby = .Item("FieldGroupby")
                        Field.FieldSize = .Item("FieldSize")
                        Field.FieldType = .Item("FieldType")
                        Field.DTable = .Item("DTable")
                        Field.LTable = .Item("LTable")
                        Field.MTable = .Item("MTable")
                        Field.M1Table = .Item("M1Table")
                        Field.RTable = .Item("RTable")
                        Field.LField = .Item("LField")
                        Field.MField = .Item("MField")
                        Field.M1Field = .Item("M1Field")
                        Field.M2Field = .Item("M2Field")
                        Field.M3Field = .Item("M3Field")
                        Field.RField = .Item("RField")
                        Field.STT = .Item("STT")
                        Field.Align = .Item("Align")
                    End With
                    mFieldShow.Add(Field)
                Next
            End If
        End Sub

        Public Sub AddFieldSearch(ByVal FieldID As Integer, ByVal FieldOperator As String, ByVal OperatorBoolean As String, ByVal Value1 As Object, ByVal Value2 As Object)
            'Load những trường tìm kiếm
            Dim cls As New TimKiemNangCao_DataAccess
            Dim dt As DataTable
            dt = cls.HienThi_ESSField_Search(FieldID)
            If dt.Rows.Count > 0 Then
                Dim Field As New ESSTimKiemNangCaoTruongTimKiem
                With dt.Rows(0)
                    Field.ID = .Item("ID")
                    Field.FieldGroup = .Item("FieldGroup")
                    Field.STT = .Item("STT")
                    Field.FieldName = .Item("FieldName")
                    Field.FieldStatistic = .Item("FieldStatistic")
                    Field.FieldID = .Item("FieldID")
                    Field.FieldType = .Item("FieldType")
                    Field.DTable = .Item("DTable")
                    Field.DFieldID = .Item("DFieldID")
                    Field.DFieldName = .Item("DFieldName")
                    Field.WTable = .Item("WTable")
                    Field.LTable = .Item("LTable")
                    Field.MTable = .Item("MTable")
                    Field.RTable = .Item("RTable")
                    Field.LField = .Item("LField")
                    Field.MField = .Item("MField")
                    Field.M1Field = .Item("M1Field")
                    Field.RField = .Item("RField")
                    Field.FieldSelect = .Item("FieldSelect")
                    Field.Value1 = Value1
                    Field.Value2 = Value2
                    Field.FieldOperator = FieldOperator
                    Field.FieldOperatorB = OperatorBoolean
                End With
                mFieldSearch.Add(Field)
            End If
        End Sub

        Public Function KetQuaTimKiem(ByVal DbType As Integer, ByVal gTableID_dv As String) As DataTable
            Dim strSQL As String = ""
            Dim SQLSelect, strSQLRelation, strSQLWhere As String
            Dim dt As DataTable
            Dim cls As New TimKiemNangCao_DataAccess
            SQLSelect = GenSQLSelect()
            strSQLRelation = GenSQLRelation(DbType, gTableID_dv)
            strSQLWhere = GenSQLWhere(DbType)
            If SQLSelect <> "" And strSQLRelation <> "" Then
                strSQL = "SELECT " + SQLSelect + " FROM " + strSQLRelation
                If strSQLWhere <> "" Then
                    strSQL += " WHERE " + strSQLWhere
                End If
                dt = cls.KetQuaTimKiem(strSQL)
                Return dt
            Else
                Return Nothing
            End If
        End Function

        Private Function GenSQLSelect() As String
            Dim SQLSelect As String = ""
            For i As Integer = 0 To mFieldShow.Count - 1
                With mFieldShow.FieldShow(i)
                    'Gen cau lenh SELECT
                    SQLSelect = SQLSelect & Space(1) & .FieldID & ", "
                End With
            Next
            If SQLSelect <> "" Then SQLSelect = Left(SQLSelect, Len(SQLSelect) - 2)
            If SQLSelect <> "" Then SQLSelect += ",STU_HoSoSinhVien.ID_sv "
            Return SQLSelect
        End Function

        Private Function GenSQLWhere(ByVal DbType As Integer) As String
            Dim SQLWhere As String = ""
            For i As Integer = 0 To mFieldSearch.Count - 1
                With mFieldSearch.FieldSearch(i)
                    'Gen cau lenh WHERE
                    If SQLWhere.Trim <> "" Then
                        SQLWhere += " " + .FieldOperatorB
                    End If
                    SQLWhere = SQLWhere & Space(1) & AddValue(DbType, .WTable, .FieldID, .FieldType, .FieldOperator, .Value1, .Value2)
                End With
            Next
            Return SQLWhere
        End Function

        Private Function GenSQLRelation(ByVal DbType As Integer, ByVal gTableID_dv As String) As String
            Dim SQLRelation As String = ""
            For i As Integer = 0 To mFieldShow.Count - 1
                With mFieldShow.FieldShow(i)
                    'Gen cau lenh RELATION
                    AddRelation(DbType, gTableID_dv, .LTable, .MTable, .LField, .MField, SQLRelation)
                    AddRelation(DbType, gTableID_dv, .MTable, .M1Table, .M1Field, .M2Field, SQLRelation)
                    AddRelation(DbType, gTableID_dv, .M1Table, .RTable, .M3Field, .RField, SQLRelation)
                End With
            Next
            For i As Integer = 0 To mFieldSearch.Count - 1
                With mFieldSearch.FieldSearch(i)
                    'Gen cau lenh RELATION
                    AddRelation(DbType, gTableID_dv, .LTable, .MTable, .LField, .MField, SQLRelation)
                    AddRelation(DbType, gTableID_dv, .MTable, .RTable, .M1Field, .RField, SQLRelation)
                End With
            Next
            Return SQLRelation
        End Function

        Private Function AddValue(ByVal DbType As Integer, ByVal TableName As String, ByVal FieldID As String, ByVal FieldType As Byte, ByVal [Operator] As String, ByVal Value1 As String, ByVal Value2 As String) As String
            Dim pos As Byte
            pos = InStr(TableName, " AS ")
            If pos Then
                TableName = Right(TableName, Len(TableName) - pos - 3) & "."
            Else
                If TableName.Trim <> "" Then TableName = TableName & "."
            End If
            If InStr(FieldID, "(") > 0 And InStr(FieldID, ")") > 0 Then
                pos = InStrRev(FieldID, "(") + 1
                FieldID.Insert(pos, TableName.Trim)
            Else
                FieldID = TableName.Trim & FieldID.Trim
            End If
            Select Case FieldType
                Case 1      'Text
                    If Value1.Trim = "?)" Then
                        Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & Value1.Trim
                    Else
                        If [Operator].Trim = "LIKE" Then
                            Return "UPPER(" & FieldID.Trim & ")" & Space(1) & [Operator].Trim & Space(1) & " N'%" & Replace(Value1.Trim.ToUpper, "'", "''") & "%'"
                        Else
                            Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & "N'" & Replace(Value1.Trim, "'", "''") & "'"
                        End If
                    End If
                Case 2      'Date
                    If Value2 = "" Then
                        If IsDate(Value1) Then
                            Return FieldID.Trim & Space(1) & [Operator].Trim & SQLDate(Value1.Trim, DbType)
                        Else
                            Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & Value1.Trim
                        End If
                    Else
                        If IsDate(Value2) Then
                            Return FieldID.Trim & Space(1) & [Operator].Trim & SQLDate(Value1.Trim, DbType) & " AND " & SQLDate(Value2.Trim, DbType)
                        Else
                            Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & Value1.Trim & " AND " & Value2.Trim
                        End If
                    End If
                Case 3, 4     'Num
                    Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & Value1.Trim
                Case 5     'Danh muc, kieu text
                    If Value1.Trim = "?)" Then
                        Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & Value1.Trim
                    Else
                        Return FieldID.Trim & Space(1) & [Operator].Trim & Space(1) & "N'" & Replace(Value1.Trim, "'", "''") & "'"
                    End If
            End Select
            Return ""
        End Function

        Private Sub AddRelation(ByVal DbType As Integer, ByVal gTableID_dv As String, ByVal LTable As String, ByVal RTable As String, ByVal LFields As String, ByVal RFields As String, ByRef SQLRelation As String)
            Dim a, b, bd1, bd2, LField(), RField() As String
            Dim pos, i As Byte
            If LTable.Trim <> "" And RFields.Trim <> "" Then
                If DbType = 0 Then
                    pos = InStr(LTable.Trim, " AS ", CompareMethod.Text)
                Else
                    pos = InStr(LTable.Trim, " ", CompareMethod.Text)
                    If pos > 2 Then pos -= 3
                End If
                If pos Then
                    a = LTable.Trim
                    bd1 = Right(LTable.Trim, Len(LTable.Trim) - pos - 3)
                Else
                    a = LTable.Trim
                    bd1 = a
                End If
                If DbType = 0 Then
                    pos = InStr(RTable.Trim, " AS ", CompareMethod.Text)
                Else
                    pos = InStr(RTable.Trim, " ", CompareMethod.Text)
                    If pos > 2 Then pos -= 3
                End If
                If pos Then
                    b = RTable.Trim
                    bd2 = Right(RTable.Trim, Len(RTable.Trim) - pos - 3)
                Else
                    b = RTable.Trim
                    bd2 = b
                End If
                Dim Arr() As String = Split(SQLRelation, " ")
                Dim flag As Boolean = False
                'Kiểm tra xem bảng này đã đựơc join chưa
                For i = 0 To Arr.Length - 1
                    If Arr(i).Trim = a.Trim Then
                        flag = True
                        Exit For
                    End If
                Next
                If Not flag Then
                    If InStr(gTableID_dv, a, CompareMethod.Text) > 0 Then a = "(SELECT * FROM " & a & " WHERE ID_dv='?') " & a
                    If InStr(gTableID_dv, b, CompareMethod.Text) > 0 Then b = "(SELECT * FROM " & b & " WHERE ID_dv='?') " & b
                    LField = Split(LFields, "-")
                    RField = Split(RFields, "-")
                    SQLRelation = SQLRelation & a & " LEFT JOIN " & b & " ON " & bd1 & "." & LField(0) & "=" & bd2 & "." & RField(0)
                    If LField.Length >= 2 Then
                        For i = 1 To LField.Length - 1
                            SQLRelation = SQLRelation & " AND " & bd1 & "." & LField(i) & "=" & bd2 & "." & RField(i)
                        Next
                    End If
                Else
                    flag = False
                    'Kiểm tra xem bảng này đã đựơc join chưa
                    For i = 0 To Arr.Length - 1
                        If Arr(i).Trim = b.Trim Then
                            flag = True
                            Exit For
                        End If
                    Next
                    If Not flag Then
                        If InStr(gTableID_dv, b, CompareMethod.Text) > 0 Then b = "(SELECT * FROM " & b & " WHERE ID_dv='?') " & b
                        LField = Split(LFields, "-")
                        RField = Split(RFields, "-")
                        SQLRelation = SQLRelation & " LEFT JOIN " & b & " ON " & bd1 & "." & LField(0) & "=" & bd2 & "." & RField(0)
                        If LField.Length >= 2 Then
                            For i = 1 To LField.Length - 1
                                SQLRelation = SQLRelation & " AND " & bd1 & "." & LField(i) & "=" & bd2 & "." & RField(i)
                            Next
                        End If
                    End If
                End If
            End If
        End Sub

        Private Function SQLDate(ByVal sDate As Object, ByVal DbType As Integer) As String
            Dim sMonth, sDay, sYear As String
            sDate = CDate(sDate)
            sMonth = FormatNumber(Month(sDate), 0, -1) '-1 sets the IncludeLeadingZero to True
            sDay = FormatNumber(Microsoft.VisualBasic.Day(sDate), 0, -1)
            sYear = Year(sDate)
            SQLDate = sMonth & "/" & sDay & "/" & sYear
            If DbType = 1 Then
                SQLDate = " to_date('" & SQLDate & "','mm/dd/yyyy')"
            Else
                SQLDate = "'" + SQLDate + "'"
            End If
        End Function
        Public Function getFieldSearchID(ByVal FieldID As String, ByVal WTable As String, ByVal FieldGroup As Long) As Long
            Try
                Dim cls As New TimKiemNangCao_DataAccess
                Return cls.getFieldSearchID(FieldID, WTable, FieldGroup)
            Catch ex As Exception
                Throw ex
            End Try

        End Function

        ' Get nhóm trường hiển thị
        Public Function getFieldGroup(ByVal ID_phan_he As Integer) As DataTable
            Dim obj As New TimKiemNangCao_DataAccess
            Return obj.getFieldGroup(ID_phan_he)
        End Function
        ' Get trường tìm kiếm
        Public Function getFieldSeach(ByVal ID_phan_he As Integer) As DataTable
            Dim obj As New TimKiemNangCao_DataAccess
            Return obj.getFieldSeach(ID_phan_he)
        End Function
        ' Get trường tìm kiếm theo FieldGroup
        Public Function getFieldSeach_Group(ByVal FieldGroup As Integer) As DataTable
            Dim obj As New TimKiemNangCao_DataAccess
            Return obj.getFieldSeach_Group(FieldGroup)
        End Function
        ' Get toán tử tìm kếm
        Public Function getOperator(ByVal Kieu_truong As Integer) As DataTable
            Dim obj As New TimKiemNangCao_DataAccess
            Return obj.getOperator(Kieu_truong)
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property FieldShow() As TimKiemNangCaoTruongHienThi
            Get
                Return mFieldShow
            End Get
        End Property
        Public ReadOnly Property FieldSearch() As ESSTimKiemNangCaoTruongTimKiem
            Get
                Return mFieldSearch
            End Get
        End Property
#End Region
    End Class
End Namespace