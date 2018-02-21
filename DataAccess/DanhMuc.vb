'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhMuc_DataAccess
        Function LoadTieuDe_BaoCao(ByVal ID_dv As String) As DataTable
            Try
                Dim strSQl As String
                strSQl = "Select * from SYS_BaoCaoTieuDe where ID_dv=N'" & ID_dv & "'"
                Return Connect.SelectTable(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function LoadTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As DataTable
            Try
                Dim strSQl As String
                strSQl = "Select * from SYS_BaoCaoTieuDe where ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                Return Connect.SelectTable(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_chuc_danh3=N'" & Chuc_danh3 & "'," & _
                         " Tieu_de_chuc_danh4=N'" & Chuc_danh4 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_nguoi_ky3=N'" & Nguoi_ky3 & "'," & _
                         " Tieu_de_nguoi_ky4=N'" & Nguoi_ky4 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "'"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_chuc_danh3=N'" & Chuc_danh3 & "'," & _
                         " Tieu_de_chuc_danh4=N'" & Chuc_danh4 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_nguoi_ky3=N'" & Nguoi_ky3 & "'," & _
                         " Tieu_de_nguoi_ky4=N'" & Nguoi_ky4 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "UPDATE SYS_BaoCaoTieuDe Set " & _
                         " Tieu_de_ten_bo=N'" & Ten_bo & "'," & _
                         " Tieu_de_Ten_truong=N'" & Ten_truong & "'," & _
                         " Tieu_de_chuc_danh1=N'" & Chuc_danh1 & "'," & _
                         " Tieu_de_chuc_danh2=N'" & Chuc_danh2 & "'," & _
                         " Tieu_de_nguoi_ky1=N'" & Nguoi_ky1 & "'," & _
                         " Tieu_de_nguoi_ky2=N'" & Nguoi_ky2 & "'," & _
                         " Tieu_de_noi_ky=N'" & Noi_ky & "'" & _
                         " WHERE ID_dv=N'" & ID_dv & "'"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_chuc_danh4,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_nguoi_ky4,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Chuc_danh3 & "'," & _
                         " N'" & Chuc_danh4 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Nguoi_ky3 & "'," & _
                         " N'" & Nguoi_ky4 & "'," & _
                         " N'" & Noi_ky & "')"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,UserID,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_chuc_danh4,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_nguoi_ky4,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " " & UserID & "," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Chuc_danh3 & "'," & _
                         " N'" & Chuc_danh4 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Nguoi_ky3 & "'," & _
                         " N'" & Nguoi_ky4 & "'," & _
                         " N'" & Noi_ky & "')"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                Dim strSQl As String
                strSQl = "INSERT INTO SYS_BaoCaoTieuDe(ID_dv,Tieu_de_ten_bo,Tieu_de_Ten_truong,Tieu_de_chuc_danh1,Tieu_de_chuc_danh2,Tieu_de_chuc_danh3,Tieu_de_nguoi_ky1,Tieu_de_nguoi_ky2,Tieu_de_nguoi_ky3,Tieu_de_noi_ky) Values(" & _
                         " N'" & ID_dv & "'," & _
                         " N'" & Ten_bo & "'," & _
                         " N'" & Ten_truong & "'," & _
                         " N'" & Chuc_danh1 & "'," & _
                         " N'" & Chuc_danh2 & "'," & _
                         " N'" & Nguoi_ky1 & "'," & _
                         " N'" & Nguoi_ky2 & "'," & _
                         " N'" & Noi_ky & "')"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Function CheckTieuDe_BaoCao(ByVal ID_dv As String) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM SYS_BaoCaoTieuDe WHERE ID_dv=N'" & ID_dv & "'"
                If Connect.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function CheckTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM SYS_BaoCaoTieuDe WHERE ID_dv=N'" & ID_dv & "' AND UserID=" & UserID
                If Connect.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Sub DanhMuc_Insert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "")
            Try
                Dim strField As String = FieldName
                If FieldName1 <> "" Then strField += "," & FieldName1
                Dim strValue As String = "N'" & Value & "'"
                If Value1 <> "" Then strValue += ",N'" & Value1 & "'"
                Dim strSQl As String
                strSQl = "INSERT INTO " & TableName & "(" & strField & ") VALUES(" & strValue & ")"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Update(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "")
            Try
                Dim strField As String = ""
                strField += FieldName & "=N'" & Value & "'"
                If FieldName1 <> "" Then strField += "," & FieldName1 & "=N'" & Value1 & "'"
                Dim strSQl As String
                strSQl = "UPDATE " & TableName & " SET " & strField & " WHERE " & FieldWhere & "=N'" & ValueWhere & "'"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Delete(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object)
            Try
                Dim strSQl As String
                strSQl = "DELETE " & TableName & " WHERE " & FieldWhere & "=N'" & ValueWhere & "'"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub DanhMuc_Deletes(ByVal TableName As String, ByVal FieldWhere As String, ByVal ValueWhere As String)
            Try
                Dim strSQl As String
                strSQl = "DELETE " & TableName & " WHERE " & FieldWhere & "=N'" & ValueWhere & "'"
                Connect.Execute(strSQl)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Function DanhMuc_CheckName(ByVal TableName As String, ByVal FieldName As String, ByVal ValueName As String) As Boolean
            Try
                Dim strSQl As String
                strSQl = "SELECT * FROM " & TableName & " WHERE " & FieldName & "=N'" & ValueName & "'"
                If Connect.SelectTable(strSQl).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMucSoSanh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKienNhoHon_Input As Integer) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " & ValueMember & "," & DisplayMember & " FROM " & TableName & " WHERE " & Bien_DieuKien & ">=" & DieuKienNhoHon_Input
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal strSQL As String) As DataTable
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName + " WHERE " + Bien_DieuKien + "=N'" + DieuKien_Input + "'"
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_DKKhac_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim strSQL As String = "SELECT DISTINCT " + ValueMember + "," + DisplayMember + " FROM " + TableName + " WHERE " + Bien_DieuKien + " not in (" + DieuKien_Input + ")"
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function DanhMuc_Khoa_Load(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim strSQL As String = "SELECT DISTINCT a.ID_khoa,Ten_khoa FROM STU_Khoa a INNER JOIN STU_Lop b ON a.ID_khoa=b.ID_khoa WHERE 1=1 "
            If ID_he > 0 Then strSQL += " AND ID_he=" & ID_he
            If Khoa_hoc > 0 Then strSQL += " AND Khoa_hoc=" & Khoa_hoc
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Function getID_Nganh_Load(ByVal ID_chuyen_nganh As Integer) As Integer
            Dim strSQL As String = "SELECT DISTINCT ID_nganh FROM STU_ChuyenNganh WHERE ID_chuyen_nganh=" & ID_chuyen_nganh & ""
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("ID_nganh")
            Else
                Return 0
            End If
        End Function
        Function getMaNganh(ByVal ID_nganh As Integer) As String
            Dim strSQL As String = "SELECT DISTINCT Ma_nganh FROM STU_Nganh WHERE ID_nganh=" & ID_nganh & ""
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ma_nganh")
            Else
                Return "000"
            End If
        End Function
        Function getMaHe(ByVal ID_he As Integer) As String
            Dim strSQL As String = "SELECT DISTINCT Ma_he FROM STU_He WHERE ID_he=" & ID_he & ""
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ma_he")
            Else
                Return "0"
            End If
        End Function
        Public Function LoadDanhMuc(ByVal SQL As String) As DataTable
            Return Connect.SelectTable(SQL)
        End Function
        Public Function LoadNienKhoa(ByVal ID_sv As Integer) As String
            Dim sql As String = " select Nien_khoa FROM STU_Lop l " & _
                                " inner JOIN STU_DanhSach ds On l.ID_lop = ds.ID_lop " & _
                                " where ds.ID_sv=" & ID_sv
            Dim dt As DataTable = Connect.SelectTable(sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0).ToString
            Else
                Return ""
            End If
        End Function
        Public Function Xep_loai_HB(ByVal ID_xep_loai_hb As Integer) As String
            Dim sql As String = " select * FROM STU_XepLoaiHocBong " & _
                                " where ID_xep_loai_hb=" & ID_xep_loai_hb
            Dim dt As DataTable = Connect.SelectTable(sql)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item("Ten_xep_loai").ToString
            Else
                Return ""
            End If
        End Function
        Public Function GetMaNganh(ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Dim SQL As String = " select Ma_nganh FROM STU_Nganh where ID_nganh=" & ID_nganh
            If ID_chuyen_nganh > 0 Then
                SQL = " select Ma_chuyen_nganh FROM STU_ChuyenNganh where ID_chuyen_nganh=" & ID_chuyen_nganh
            End If
            Dim dt As DataTable = Connect.SelectTable(SQL)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0).Item(0).ToString
            Else
                Return ""
            End If
        End Function
        Function CheckVerSion() As Boolean
            Dim SQL As String
            Dim dt As DataTable
            SQL = "SELECT ID_sv FROM STU_Danhsachsv"
            dt = Connect.SelectTable(SQL)
            Dim ID_sv As Integer = dt.Rows(0).Item(0)

            If ID_sv = 3 Then
                Return True
            Else
                'Update ID_sv neu dung la ngay cuoi
                SQL = "SELECT getdate()"
                dt = Connect.SelectTable(SQL)
                If Format(dt.Rows(0).Item(0), "dd/MM/yyyy") = "18/08/2010" Then
                    SQL = "UPDATE STU_Danhsachsv set ID_sv=3"
                    Connect.Execute(SQL)
                End If
            End If
            Return False
        End Function

        Function DanhSachSinhVien_Load(Optional ByVal ID_he As String = "", Optional ByVal Khoa_hoc As String = "", Optional ByVal ID_khoa As String = "", Optional ByVal ID_nganh As String = "", Optional ByVal ID_chuyen_nganh As String = "", Optional ByVal sID_lop As String = "") As DataTable
            Dim strSQL As String = ""
            strSQL = "SELECT DISTINCT Ma_sv FROM STU_HoSoSinhVien hs " & _
                "INNER JOIN STU_DanhSach ds ON ds.id_sv=hs.id_sv " & _
                "INNER JOIN STU_Lop l ON l.id_lop=ds.ID_lop " & _
                "INNER JOIN STU_ChuyenNganh cn ON cn.id_chuyen_nganh=l.ID_chuyen_nganh " & _
                "INNER JOIN STU_Nganh n ON n.id_nganh=cn.id_nganh WHERE 1=1"
            If ID_he <> "" Then strSQL &= " AND l.ID_he=" & ID_he
            If Khoa_hoc <> "" Then strSQL &= " AND l.khoa_hoc=" & Khoa_hoc
            If ID_khoa <> "" Then strSQL &= " AND l.ID_khoa=" & ID_khoa
            If ID_nganh <> "" Then strSQL &= " AND n.ID_nganh=" & ID_nganh
            If ID_chuyen_nganh <> "" Then strSQL &= " AND l.ID_chuyen_nganh=" & ID_chuyen_nganh
            If sID_lop <> "" Then strSQL &= " AND l.ID_lop in(" & sID_lop & ")"
            Dim dt As DataTable = Connect.SelectTable(strSQL)
            Return dt
        End Function

        Sub ThemMoi_ESSMsg(ByVal Title As String, ByVal Content As String, ByVal FromUser As String, ByVal ToUser As String)
            Try
                Dim strSQl As String = "INSERT INTO FORUM_Message (Title, Content, FromUser, ToUser, SendDate, Viewed)  VALUES (N'" & Title & "',N'" & Content & "','" & FromUser & "','" & ToUser & "',getdate(),0)"
                Connect.Execute(strSQl)
            Catch ex As Exception
            End Try
        End Sub

        Public Sub Execute(ByVal SQL As String)
            Try
                Connect.Execute(SQL)
            Catch ex As Exception
            End Try
        End Sub

        Public Function ThemMoi_ESStochucthiquydinhdangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                    If IsNothing(Tu_ngay) Then
                        para(2).Value = DBNull.Value
                    Else
                        para(2).Value = CDate(Tu_ngay)
                    End If
                    para(3) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                    If IsNothing(Den_ngay) Then
                        para(3).Value = DBNull.Value
                    Else
                        para(3).Value = CDate(Den_ngay)
                    End If
                    Return Connect.ExecuteSP("MARK_ToChucThiQuyDinhDangKy_TC_ThemMoi", para)
                Else

                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#Region "Tim kiem"
        ' Load truong tim kiem
        Function LoadFields(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Dim strSQL As String, strSQLWHERE As String = ""
                If InStr(FieldGroup.ToString, "00") = 0 Then
                    strSQLWHERE = " WHERE FieldGroup=" & FieldGroup
                End If
                strSQL = "SELECT ID, FieldName, FieldID, FieldGroup, FieldType, DTable, DFieldID, DFieldName, WTable, LTable, MTable, RTable, LField, MField, M1Field, RField " & _
                              "FROM SYS_TimKiemTruong" & strSQLWHERE
                If FieldSelect Then strSQL += " AND FieldSelect=1"
                strSQL += " ORDER BY FieldGroup, STT"
                Return Connect.SelectTable(strSQL)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load truong hien thi
        Function LoadFieldsShow(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer) As DataTable
            Try
                Dim strSQL As String, strSQLWHERE As String = ""
                If InStr(FieldGroup.ToString, "00") = 0 Then
                    strSQLWHERE = " WHERE FieldGroup=" & FieldGroup
                End If
                strSQL = "SELECT FieldName, FieldID " & _
                              "FROM SYS_HienThiTruong" & strSQLWHERE
                strSQL += " ORDER BY FieldGroup, STT"
                Return Connect.SelectTable(strSQL)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

        Function Check_ThoiGianDuyet(ByVal Ky_dang_ky As Integer) As Boolean
            Dim f As Boolean = False
            Dim Sql As String = "SELECT getdate()"
            Dim dt As DataTable = Connect.SelectTable(Sql)
            Sql = "SELECT Ngay_het_han_duyet FROM PLAN_HocKyDangKy_TC WHERE Ky_dang_ky=" & Ky_dang_ky
            Dim dt_main As DataTable = Connect.SelectTable(Sql)
            Dim Ngay1, Ngay2, Thang1, Thang2, Nam1, Nam2 As Integer
            If dt_main.Rows.Count > 0 Then
                If dt_main.Rows(0)("Ngay_het_han_duyet").ToString.Trim <> "" Then
                    Ngay1 = dt.Rows(0).Item(0).day
                    Thang1 = dt.Rows(0).Item(0).month
                    Nam1 = dt.Rows(0).Item(0).year

                    Ngay2 = dt_main.Rows(0).Item("Ngay_het_han_duyet").day
                    Thang2 = dt_main.Rows(0).Item("Ngay_het_han_duyet").month
                    Nam2 = dt_main.Rows(0).Item("Ngay_het_han_duyet").year

                    Dim NgayThang1 As String = Ngay1 & "/" & Thang1 & "/" & Nam1
                    Dim NgayThang2 As String = Ngay2 & "/" & Thang2 & "/" & Nam2

                    If CType(NgayThang1, Date) > CType(NgayThang2, Date) Then
                        f = True
                    End If
                End If
            End If
            Return f
        End Function

        Public Sub Insert_DangKySai()
            Dim f As Boolean = False
            Dim Sql As String = "SELECT DISTINCT ID_SV,c.ID_mon_tc FROM STU_DANHSACHLOPTINCHI a " & _
                                "INNER JOIN PLAN_LOPTINCHI_TC b ON a.ID_lop_tc=b.ID_lop_tc " & _
                                "INNER JOIN PLAN_MONTINCHI_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                                "WHERE Ky_dang_ky in (56,58,59,60,61) " & _
                                ""
            Dim dt As DataTable = Connect.SelectTable(Sql)
            For i As Integer = 0 To dt.Rows.Count - 1
                Sql = "SELECT DISTINCT ID_SV,a.ID_lop_tc FROM STU_DANHSACHLOPTINCHI a " & _
                "INNER JOIN PLAN_LOPTINCHI_TC b ON a.ID_lop_tc=b.ID_lop_tc " & _
                "INNER JOIN PLAN_MONTINCHI_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                "INNER JOIN PLAN_HOCKYDANGKY_TC d ON c.Ky_dang_ky=d.Ky_dang_ky " & _
                "WHERE d.Ky_dang_ky in (56,58,59,60,61) AND ID_lop_lt=0 AND ID_SV=" & dt.Rows(i)("ID_SV") & " AND c.ID_mon_tc=" & dt.Rows(i)("ID_mon_tc")
                Dim dt_main As DataTable = Connect.SelectTable(Sql)
                If dt_main.Rows.Count > 1 Then
                    'Insert vao 
                    Connect.Execute("INSERT INTO PLAN_DANHSACHLOPTINCHI_THUA (ID_SV,ID_mon_tc) VALUES (" & dt.Rows(i)("ID_SV") & "," & dt.Rows(i)("ID_mon_tc") & ")")
                End If
            Next
        End Sub
    End Class
End Namespace

