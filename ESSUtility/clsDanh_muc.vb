Imports ESSConnect
Public Class clsDanh_muc
    '- Hien thi danh muc voi 2 truong hop
    '           + Kieu du lieu cua truong dieu kien la String
    Function CatalogueLoad(ByVal TableName As String, Optional ByVal CriteriaField As String = "", Optional ByVal CriteriaValue As String = "", Optional ByVal OrderField As String = "") As DataTable
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        Dim dt As DataTable = Nothing
        ' - Xay dung cau truy van
        strSQL = "SELECT  * FROM " & TableName & ""
        If Trim(CriteriaField) <> "" Then strSQL &= " WHERE " & CriteriaField & "='" & Replace(CriteriaValue, "'", "''") & "'"
        If Trim(OrderField) <> "" Then strSQL &= " ORDER BY " & OrderField
        Try
            dt = Connect.SelectTable(strSQL)
            If Not dt Is Nothing Then
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
            End If
        Catch ex As Exception
        End Try
        Return dt
    End Function
    '-Hện thị danh mục, truyền vào câu lệnh SQL
    Function CatalogueLoadSQL(ByVal strSQL As String) As DataTable
        Dim dt As DataTable = Nothing
        Try
            dt = Connect.SelectTable(strSQL)
            If Not dt Is Nothing Then
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
            End If
        Catch ex As Exception
        End Try
        Return dt
    End Function
    '- Xoa danh muc voi 2 truong hop
    '           + Kieu du lieu cua truong dieu kien la Long
    '           + Kieu du lieu cua truong dieu kien la String
    Function CatalogueDelete(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As Long) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Then Return Nothing
        ' vbYes giá trị của VisualBasic.MsgBoxResult
        If Thongbao(msgDELETE, MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = vbYes Then
            Try
                Connect.Execute("DELETE FROM " & TableName & " WHERE " & CriteriaField & "=" & CriteriaValue)
                ThongBaoXoaThanhCong()
            Catch ex As Exception
                Thongbao(msgDelErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Return True
    End Function
    Function CatalogueDelete(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Then Return Nothing
        Dim strSQL As String
        If Thongbao(msgDELETE, MsgBoxStyle.YesNo + MsgBoxStyle.Critical) = vbYes Then
            strSQL = "DELETE FROM " & TableName & " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "'"
            Try
                Connect.Execute(strSQL)
                ThongBaoXoaThanhCong()
            Catch ex As Exception
                Thongbao(msgDelErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
        Return True
    End Function
    Function CatalogueXoa_ESSOptions(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "", Optional ByVal FieldName6 As String = "", Optional ByVal Value6 As String = "") As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "DELETE " & TableName & " WHERE  " & FieldName & "=N'" & Replace(Value, "'", "''") & "' "
        If FieldName1.Trim <> "" Then
            strSQL &= "AND " & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' "
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "AND " & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' "
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "AND " & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "' "
        End If
        If FieldName4.Trim <> "" Then
            strSQL &= "AND " & FieldName4 & "=N'" & Replace(Value4, "'", "''") & "' "
        End If
        If FieldName5.Trim <> "" Then
            strSQL &= "AND " & FieldName5 & "=N'" & Replace(Value5, "'", "''") & "' "
        End If
        If FieldName6.Trim <> "" Then
            strSQL &= "AND " & FieldName6 & "=N'" & Replace(Value6, "'", "''") & "' "
        End If
        Try
            Connect.Execute(strSQL)
            'ThongBaoXoaThanhCong()
        Catch ex As Exception
            Thongbao(msgDelErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    '- Cap nhat danh muc voi 2 truong hop
    '           + Kieu du lieu cua truong dieu kien la Long
    '           + Kieu du lieu cua truong dieu kien la String
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As Long, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "") As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then strSQL &= "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' "
        strSQL &= " WHERE " & CriteriaField & "=" & CriteriaValue
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "") As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then strSQL &= "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' "
        strSQL &= " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "' "
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        If FieldName2.Trim <> "" Then
            strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'" & _
                          "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' " & _
                          "," & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' " & _
                          " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "' "
            Try
                Connect.Execute(strSQL)
                ThongBaoThanhCong()
            Catch ex As Exception
                Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            CatalogueUpdate(TableName, CriteriaField, CriteriaValue, FieldName, Value, FieldName1, Value1)
        End If
        Return True
    End Function
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        If FieldName3.Trim <> "" Then
            strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'" & _
                          "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' " & _
                          "," & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' " & _
                          "," & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "' " & _
                          " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "' "
            Try
                Connect.Execute(strSQL)
                ThongBaoThanhCong()
            Catch ex As Exception
                Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            CatalogueUpdate(TableName, CriteriaField, CriteriaValue, FieldName, Value, FieldName1, Value1, FieldName2, Value2)
        End If
        Return True
    End Function
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String, ByVal FieldName4 As String, ByVal Value4 As String) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        If FieldName4.Trim <> "" Then
            strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'" & _
                          "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' " & _
                          "," & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' " & _
                          "," & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "' " & _
                          "," & FieldName4 & "=N'" & Replace(Value4, "'", "''") & "' " & _
                          " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "' "
            Try
                Connect.Execute(strSQL)
                ThongBaoThanhCong()
            Catch ex As Exception
                Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            CatalogueUpdate(TableName, CriteriaField, CriteriaValue, FieldName, Value, FieldName1, Value1, FieldName2, Value2, FieldName3, Value3)
        End If
        Return True
    End Function
    Function CatalogueUpdate(ByVal TableName As String, ByVal CriteriaField As String, ByVal CriteriaValue As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String, ByVal FieldName4 As String, ByVal Value4 As String, ByVal FieldName5 As String, ByVal Value5 As String) As Boolean
        If TableName.Trim = "" Or CriteriaField.Trim = "" Or FieldName.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        If FieldName4.Trim <> "" Then
            strSQL = "UPDATE " & TableName & " SET " & FieldName & "=N'" & Replace(Value, "'", "''") & "'" & _
                          "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' " & _
                          "," & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' " & _
                          "," & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "' " & _
                          "," & FieldName4 & "=N'" & Replace(Value4, "'", "''") & "' " & _
                          "," & FieldName5 & "=N'" & Replace(Value5, "'", "''") & "' " & _
                          " WHERE " & CriteriaField & "=N'" & Replace(CriteriaValue, "'", "''") & "' "
            Try
                Connect.Execute(strSQL)
                ThongBaoThanhCong()
            Catch ex As Exception
                Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
            End Try
        Else
            CatalogueUpdate(TableName, CriteriaField, CriteriaValue, FieldName, Value, FieldName1, Value1, FieldName2, Value2, FieldName3, Value3)
        End If
        Return True
    End Function
    Function CatalogueCapNhat_ESSOption(ByVal TableName As String, Optional ByVal CriteriaField0 As String = "", Optional ByVal CriteriaValue0 As String = "", Optional ByVal CriteriaField1 As String = "", Optional ByVal CriteriaValue1 As String = "", Optional ByVal CriteriaField2 As String = "", Optional ByVal CriteriaValue2 As String = "", Optional ByVal CriteriaField3 As String = "", Optional ByVal CriteriaValue3 As String = "", Optional ByVal CriteriaField4 As String = "", Optional ByVal CriteriaValue4 As String = "", Optional ByVal CriteriaField5 As String = "", Optional ByVal CriteriaValue5 As String = "", Optional ByVal CriteriaField6 As String = "", Optional ByVal CriteriaValue6 As String = "", Optional ByVal CriteriaField7 As String = "", Optional ByVal CriteriaValue7 As String = "", Optional ByVal CriteriaField8 As String = "", Optional ByVal CriteriaValue8 As String = "", Optional ByVal FieldName0 As String = "", Optional ByVal Value0 As String = "", Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "", Optional ByVal FieldName6 As String = "", Optional ByVal Value6 As String = "", Optional ByVal FieldName7 As String = "", Optional ByVal Value7 As String = "", Optional ByVal FieldName8 As String = "", Optional ByVal Value8 As String = "") As Boolean
        If TableName.Trim = "" Or CriteriaField0.Trim = "" Or FieldName0.Trim = "" Then Return Nothing
        Dim strSQL As String
        '- Xay dung cau truy van
        strSQL = "UPDATE " & TableName & " SET " & FieldName0 & "=N'" & Replace(Value0, "'", "''") & "'"
        If FieldName1 <> "" Then strSQL &= "," & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "' "
        If FieldName2 <> "" Then strSQL &= "," & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "' "
        If FieldName3 <> "" Then strSQL &= "," & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "' "
        If FieldName4 <> "" Then strSQL &= "," & FieldName4 & "=N'" & Replace(Value4, "'", "''") & "' "
        If FieldName5 <> "" Then strSQL &= "," & FieldName5 & "=N'" & Replace(Value5, "'", "''") & "' "
        If FieldName6 <> "" Then strSQL &= "," & FieldName6 & "=N'" & Replace(Value6, "'", "''") & "' "
        If FieldName7 <> "" Then strSQL &= "," & FieldName7 & "=N'" & Replace(Value7, "'", "''") & "' "
        If FieldName8 <> "" Then strSQL &= "," & FieldName8 & "=N'" & Replace(Value8, "'", "''") & "' "
        'Xây dựng các điều kiện
        strSQL &= " WHERE " & CriteriaField0 & "=N'" & Replace(CriteriaValue0, "'", "''") & "' "
        If CriteriaField1 <> "" Then strSQL &= "AND " & CriteriaField1 & "=N'" & Replace(CriteriaValue1, "'", "''") & "' "
        If CriteriaField2 <> "" Then strSQL &= "AND " & CriteriaField2 & "=N'" & Replace(CriteriaValue2, "'", "''") & "' "
        If CriteriaField3 <> "" Then strSQL &= "AND " & CriteriaField3 & "=N'" & Replace(CriteriaValue3, "'", "''") & "' "
        If CriteriaField4 <> "" Then strSQL &= "AND " & CriteriaField4 & "=N'" & Replace(CriteriaValue4, "'", "''") & "' "
        If CriteriaField5 <> "" Then strSQL &= "AND " & CriteriaField5 & "=N'" & Replace(CriteriaValue5, "'", "''") & "' "
        If CriteriaField6 <> "" Then strSQL &= "AND " & CriteriaField6 & "=N'" & Replace(CriteriaValue6, "'", "''") & "' "
        If CriteriaField7 <> "" Then strSQL &= "AND " & CriteriaField7 & "=N'" & Replace(CriteriaValue7, "'", "''") & "' "
        If CriteriaField8 <> "" Then strSQL &= "AND " & CriteriaField8 & "=N'" & Replace(CriteriaValue8, "'", "''") & "' "
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgUpdErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    '- Them moi danh muc voi 2 truong hop
    '           + Kieu du lieu cua truong dieu kien la Long
    '           + Kieu du lieu cua truong dieu kien la String
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ") VALUES(N'" & Replace(Value, "'", "''") & "')"
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String) As Boolean
        If TableName.Trim = "" Then Return Nothing

        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""

        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""
        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "," & FieldName2 & ""
            StrVALUES &= ",N'" & Replace(Value2, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            'ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""
        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "," & FieldName2 & ""
            StrVALUES &= ",N'" & Replace(Value2, "'", "''") & "'"
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "," & FieldName3 & ""
            StrVALUES &= ",N'" & Replace(Value3, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String, ByVal FieldName4 As String, ByVal Value4 As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""
        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "," & FieldName2 & ""
            StrVALUES &= ",N'" & Replace(Value2, "'", "''") & "'"
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "," & FieldName3 & ""
            StrVALUES &= ",N'" & Replace(Value3, "'", "''") & "'"
        End If
        If FieldName4.Trim <> "" Then
            strSQL &= "," & FieldName4 & ""
            StrVALUES &= ",N'" & Replace(Value4, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueInsert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, ByVal FieldName1 As String, ByVal Value1 As String, ByVal FieldName2 As String, ByVal Value2 As String, ByVal FieldName3 As String, ByVal Value3 As String, ByVal FieldName4 As String, ByVal Value4 As String, ByVal FieldName5 As String, ByVal Value5 As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""
        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "," & FieldName2 & ""
            StrVALUES &= ",N'" & Replace(Value2, "'", "''") & "'"
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "," & FieldName3 & ""
            StrVALUES &= ",N'" & Replace(Value3, "'", "''") & "'"
        End If
        If FieldName4.Trim <> "" Then
            strSQL &= "," & FieldName4 & ""
            StrVALUES &= ",N'" & Replace(Value4, "'", "''") & "'"
        End If
        If FieldName5.Trim <> "" Then
            strSQL &= "," & FieldName5 & ""
            StrVALUES &= ",N'" & Replace(Value5, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CatalogueThemMoi_ESSOptions(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "", Optional ByVal FieldName6 As String = "", Optional ByVal Value6 As String = "", Optional ByVal FieldName7 As String = "", Optional ByVal Value7 As String = "", Optional ByVal FieldName8 As String = "", Optional ByVal Value8 As String = "") As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL, StrVALUES As String
        '- Xay dung cau truy van
        strSQL = "INSERT INTO " & TableName & "(" & FieldName & ""
        StrVALUES = " VALUES(N'" & Replace(Value, "'", "''") & "'"
        If FieldName1.Trim <> "" Then
            strSQL &= "," & FieldName1 & ""
            StrVALUES &= ",N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "," & FieldName2 & ""
            StrVALUES &= ",N'" & Replace(Value2, "'", "''") & "'"
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "," & FieldName3 & ""
            StrVALUES &= ",N'" & Replace(Value3, "'", "''") & "'"
        End If
        If FieldName4.Trim <> "" Then
            strSQL &= "," & FieldName4 & ""
            StrVALUES &= ",N'" & Replace(Value4, "'", "''") & "'"
        End If
        If FieldName5.Trim <> "" Then
            strSQL &= "," & FieldName5 & ""
            StrVALUES &= ",N'" & Replace(Value5, "'", "''") & "'"
        End If
        If FieldName6.Trim <> "" Then
            strSQL &= "," & FieldName6 & ""
            StrVALUES &= ",N'" & Replace(Value6, "'", "''") & "'"
        End If
        If FieldName7.Trim <> "" Then
            strSQL &= "," & FieldName7 & ""
            StrVALUES &= ",N'" & Replace(Value7, "'", "''") & "'"
        End If
        If FieldName8.Trim <> "" Then
            strSQL &= "," & FieldName8 & ""
            StrVALUES &= ",N'" & Replace(Value8, "'", "''") & "'"
        End If
        strSQL &= ")"
        StrVALUES &= ")"
        strSQL = strSQL & StrVALUES
        Try
            Connect.Execute(strSQL)
            ThongBaoThanhCong()
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Function CheckExist_Ma(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "SELECT * FROM " & TableName & " WHERE  " & FieldName & "=N'" & Replace(Value, "'", "''") & "'"
        Dim dt As DataTable
        Try
            dt = Connect.SelectTable(strSQL)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Function CheckExist_TiengGiangHeSoTiet(ByVal TableName As String, ByVal FieldNamHoc As String, ByVal ValueNamHoc As String, ByVal FieldTu As String, ByVal ValueTu As Integer, ByVal FieldDen As String, ByVal ValueDen As Integer) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "SELECT * FROM " & TableName & " WHERE  " & FieldNamHoc & "=N'" & Replace(ValueNamHoc, "'", "''") & "' AND ((" & ValueTu & ">=" & FieldTu & " AND " & ValueTu & " <= " & FieldDen & ") OR (" & ValueDen & ">=" & FieldTu & " AND " & ValueDen & " <= " & FieldDen & "))"
        Dim dt As DataTable
        Try
            dt = Connect.SelectTable(strSQL)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
    Function CheckExist_TiengGiangHeSoGiangDay(ByVal TableName As String, ByVal FieldNamHoc As String, ByVal ValueNamHoc As String, ByVal FieldHe As String, ByVal ValueHe As String, ByVal FieldTu As String, ByVal ValueTu As Integer, ByVal FieldDen As String, ByVal ValueDen As Integer) As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "SELECT * FROM " & TableName & " WHERE  " & FieldNamHoc & "=N'" & Replace(ValueNamHoc, "'", "''") & "' AND " & FieldHe & "=N'" & Replace(ValueHe, "'", "''") & "' AND ((" & ValueTu & ">=" & FieldTu & " AND " & ValueTu & " <= " & FieldDen & ") OR (" & ValueDen & ">=" & FieldTu & " AND " & ValueDen & " <= " & FieldDen & "))"
        Dim dt As DataTable
        Try
            dt = Connect.SelectTable(strSQL)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Thongbao(msgInsErr, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function

    Function CheckExist_Options(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "", Optional ByVal FieldName2 As String = "", Optional ByVal Value2 As String = "", Optional ByVal FieldName3 As String = "", Optional ByVal Value3 As String = "", Optional ByVal FieldName4 As String = "", Optional ByVal Value4 As String = "", Optional ByVal FieldName5 As String = "", Optional ByVal Value5 As String = "", Optional ByVal FieldName6 As String = "", Optional ByVal Value6 As String = "") As Boolean
        If TableName.Trim = "" Then Return Nothing
        Dim strSQL As String
        strSQL = "SELECT * FROM " & TableName & " WHERE  " & FieldName & "=N'" & Replace(Value, "'", "''") & "' "
        If FieldName1.Trim <> "" Then
            strSQL &= "AND " & FieldName1 & "=N'" & Replace(Value1, "'", "''") & "'"
        End If
        If FieldName2.Trim <> "" Then
            strSQL &= "AND " & FieldName2 & "=N'" & Replace(Value2, "'", "''") & "'"
        End If
        If FieldName3.Trim <> "" Then
            strSQL &= "AND " & FieldName3 & "=N'" & Replace(Value3, "'", "''") & "'"
        End If
        If FieldName4.Trim <> "" Then
            strSQL &= "AND " & FieldName4 & "=N'" & Replace(Value5, "'", "''") & "'"
        End If
        If FieldName5.Trim <> "" Then
            strSQL &= "AND " & FieldName5 & "=N'" & Replace(Value5, "'", "''") & "'"
        End If
        If FieldName6.Trim <> "" Then
            strSQL &= "AND " & FieldName6 & "=N'" & Replace(Value6, "'", "''") & "'"
        End If
        Dim dt As DataTable
        Try
            dt = Connect.SelectTable(strSQL)
            If dt.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            Thongbao(msgInsErr + ex.Message, MsgBoxStyle.Critical)
        End Try
        Return True
    End Function
End Class