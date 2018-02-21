'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------


Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhMuc_Bussines
        Private clsDM As New DanhMuc_DataAccess

        Public Function GetDateServer() As Date
            Try
                Dim dt As DataTable
                dt = clsDM.DanhMuc_Load("select getDate() as timeserver")
                Return dt.Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Select Tiêu đề báo cáo
        'Public Function TieuDe_BaoCao(ByVal ID_dv As String) As DataTable
        '    Try
        '        Return clsDM.LoadTieuDe_BaoCao(ID_dv)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function TieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As DataTable
            Try
                Return clsDM.LoadTieuDe_BaoCao(ID_dv, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '' Update Tiêu đề báo cáo
        'Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
        '    Try
        '        clsDM.UpdateTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        ' Update Tiêu đề báo cáo
        Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                clsDM.UpdateTieuDe_BaoCao(ID_dv, UserID, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub UpdateTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                clsDM.UpdateTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Nguoi_ky1, Nguoi_ky2, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        '' Insert Tiêu đề báo cáo
        'Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
        '    Try
        '        clsDM.InsertTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Sub

        ' Insert Tiêu đề báo cáo
        Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Chuc_danh3 As String, ByVal Chuc_danh4 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Nguoi_ky3 As String, ByVal Nguoi_ky4 As String, ByVal Noi_ky As String)
            Try
                clsDM.InsertTieuDe_BaoCao(ID_dv, UserID, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Chuc_danh3, Chuc_danh4, Nguoi_ky1, Nguoi_ky2, Nguoi_ky3, Nguoi_ky4, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub InsertTieuDe_BaoCao(ByVal ID_dv As String, ByVal Ten_bo As String, ByVal Ten_truong As String, ByVal Chuc_danh1 As String, ByVal Chuc_danh2 As String, ByVal Nguoi_ky1 As String, ByVal Nguoi_ky2 As String, ByVal Noi_ky As String)
            Try
                clsDM.InsertTieuDe_BaoCao(ID_dv, Ten_bo, Ten_truong, Chuc_danh1, Chuc_danh2, Nguoi_ky1, Nguoi_ky2, Noi_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        '' Check Tiêu đề báo cáo
        'Public Function CheckTieuDe_BaoCao(ByVal ID_dv As String) As Boolean
        '    Try
        '        Return clsDM.CheckTieuDe_BaoCao(ID_dv)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        ' Check Tiêu đề báo cáo
        Public Function CheckTieuDe_BaoCao(ByVal ID_dv As String, ByVal UserID As Integer) As Boolean
            Try
                Return clsDM.CheckTieuDe_BaoCao(ID_dv, UserID)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Sub DanhMuc_Insert(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "")
            Try
                clsDM.DanhMuc_Insert(TableName, FieldName, Value, FieldName1, Value1)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Update(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object, ByVal FieldName As String, ByVal Value As String, Optional ByVal FieldName1 As String = "", Optional ByVal Value1 As String = "")
            Try
                clsDM.DanhMuc_Update(TableName, FieldWhere, ValueWhere, FieldName, Value, FieldName1, Value1)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub DanhMuc_Deletes(ByVal TableName As String, ByVal FieldWhere As String, ByVal ValueWhere As String)
            Try
                clsDM.DanhMuc_Deletes(TableName, FieldWhere, ValueWhere)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub DanhMuc_Delete(ByVal TableName As String, ByVal FieldWhere As Object, ByVal ValueWhere As Object)
            Try
                clsDM.DanhMuc_Delete(TableName, FieldWhere, ValueWhere)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Function DanhMuc_CheckName(ByVal TableName As String, ByVal FieldName As String, ByVal Value As String) As Boolean
            Try
                Return clsDM.DanhMuc_CheckName(TableName, FieldName, Value)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(TableName, ValueMember, DisplayMember)
            Return dt
        End Function

        Function DanhMucSoSanh_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As Integer) As DataTable
            Dim dt As DataTable = clsDM.DanhMucSoSanh_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal strSQL As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(strSQL)
            Return dt
        End Function

        Function DanhMuc_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function DanhMuc_Khoa_Load(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_Khoa_Load(ID_he, Khoa_hoc)
            Return dt
        End Function

        Function DanhMuc_DKKhac_Load(ByVal TableName As String, ByVal ValueMember As String, ByVal DisplayMember As String, ByVal Bien_DieuKien As String, ByVal DieuKien_Input As String) As DataTable
            Dim dt As DataTable = clsDM.DanhMuc_DKKhac_Load(TableName, ValueMember, DisplayMember, Bien_DieuKien, DieuKien_Input)
            Return dt
        End Function

        Function getID_nganh(ByVal ID_chuyen_nganh As Integer) As Integer
            Return clsDM.getID_Nganh_Load(ID_chuyen_nganh)
        End Function
        Function getMa_nganh(ByVal ID_nganh As Integer) As String
            Return clsDM.getMaNganh(ID_nganh)
        End Function
        Function getMa_He(ByVal ID_he As Integer) As String
            Return clsDM.getMaHe(ID_he)
        End Function
        Public Function LoadDanhMuc(ByVal SQL As String) As DataTable
            Return clsDM.LoadDanhMuc(SQL)
        End Function
        ' Load niên khóa của sinh viên 
        Public Function LoadNienKhoa(ByVal ID_sv As Integer) As String
            Return clsDM.LoadNienKhoa(ID_sv)
        End Function
        'Load xep loại hoc bổng
        Public Function LoadXepLoai_HocBong(ByVal ID_xep_loai_hb As Integer) As String
            Return clsDM.Xep_loai_HB(ID_xep_loai_hb)
        End Function
        Public Function GetMaCN(ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Return clsDM.getMaNganh(ID_nganh, ID_chuyen_nganh)
        End Function

        Public Function DanhSachSinhVien_Load(Optional ByVal ID_he As String = "", Optional ByVal Khoa_hoc As String = "", Optional ByVal ID_khoa As String = "", Optional ByVal ID_nganh As String = "", Optional ByVal ID_chuyen_nganh As String = "", Optional ByVal sID_lop As String = "") As DataTable
            Return clsDM.DanhSachSinhVien_Load(ID_he, Khoa_hoc, ID_khoa, ID_nganh, ID_chuyen_nganh, sID_lop)
        End Function
        Public Sub ThemMoi_ESSMsg(ByVal Title As String, ByVal Content As String, ByVal FromUser As String, ByVal ToUser As String)
            clsDM.ThemMoi_ESSMsg(Title, Content, FromUser, ToUser)
        End Sub

        'Public Function CheckVerSion() As Boolean
        '    Return clsDM.CheckVerSion
        'End Function


        Public Sub Execute(ByVal SQL As String)
            clsDM.Execute(SQL)
        End Sub

        Public Function ThemMoi_ESSQuyDinhSoTinChiSom(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim obj As DanhMuc_DataAccess = New DanhMuc_DataAccess
                Return obj.ThemMoi_ESStochucthiquydinhdangky(Hoc_ky, Nam_hoc, Tu_ngay, Den_ngay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#Region "Tim kiem"
        Function LoadFields(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Return clsDM.LoadFields(gID_phan_he, gObjectID, FieldGroup, Lua_chon, FieldSelect)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function LoadFieldsShow(ByVal gID_phan_he As Integer, ByVal gObjectID As Integer, ByVal FieldGroup As Integer, Optional ByVal Lua_chon As Boolean = False, Optional ByVal FieldSelect As Boolean = False) As DataTable
            Try
                Return clsDM.LoadFieldsShow(gID_phan_he, gObjectID, FieldGroup)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
        Sub CapNhatChoTrong_LopTinCHi(ByVal Ky_dang_ky As Integer)
            Try
                Dim dt As DataTable
                Dim SQL As String = "SELECT ID_lop_tc FROM PLAN_LOPTINCHI_TC a INNER JOIN PLAN_MONTINCHI_TC b ON a.ID_mon_tc=b.ID_mon_tc WHERE Ky_dang_ky=" & Ky_dang_ky
                Dim dt_main As DataTable = clsDM.LoadDanhMuc(SQL)
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    dt = clsDM.DanhMuc_Load("SELECT Count(ID_SV) AS So_SV FROM STU_DANHSACHLOPTINCHI WHERE Huy_dang_ky=0 AND Rut_bot_hoc_phan=0 AND ID_lop_tc=" & dt_main.Rows(i)("ID_lop_tc"))
                    If dt.Rows.Count > 0 Then
                        SQL = "UPDATE PLAN_LOPTINCHI_TC SET Cho_Trong=So_sv_max-" & dt.Rows(0)("So_sv") & " WHERE ID_lop_tc=" & dt_main.Rows(i)("ID_lop_tc")
                    Else
                        SQL = "UPDATE PLAN_LOPTINCHI_TC SET Cho_Trong=So_sv_max WHERE ID_lop_tc=" & dt_main.Rows(i)("ID_lop_tc")
                    End If
                    clsDM.Execute(SQL)
                Next

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub Xoa_HP_TienQuyet(ByVal Ky_dang_ky As Integer)
            Try
                Dim SQL As String = "SELECT a.ID_SV,a.ID_lop_tc FROM STU_DANHSACHLOPTINCHI a INNER JOIN PLAN_LOPTINCHI_TC b ON a.ID_lop_tc=b.ID_lop_tc INNER JOIN PLAN_MONTINCHI_TC c ON b.ID_mon_tc=c.ID_mon_tc INNER JOIN STU_DANHSACH d ON a.ID_SV=d.ID_SV INNER JOIN STU_LOP e ON d.ID_lop=e.ID_lop INNER JOIN (SELECT * FROM (SELECT c.ID_MON,ID_SV,a.ID_DT FROM MARK_DIEM_TC a INNER JOIN MARK_DIEMTHI_TC b ON a.ID_diem=b.ID_diem INNER JOIN PLAN_CHUONGTRINHDAOTAORANGBUOC c ON a.ID_mon=c.ID_mon_RB AND a.ID_dt=c.ID_dt WHERE Loai_rang_buoc=1 GROUP BY  ID_SV,c.ID_mon,ID_MON_RB,a.ID_DT Having MAX(TBCMH)<4) a )r ON e.ID_dt=r.ID_dt AND a.ID_SV=r.ID_SV AND c.ID_mon=r.ID_mon WHERE Ky_dang_ky=55 AND Chuyen_nganh2=0"
                Dim dt_main As DataTable = clsDM.LoadDanhMuc(SQL)
                For i As Integer = 0 To dt_main.Rows.Count - 1
                    SQL = "DELETE STU_DANHSACHLOPTINCHI WHERE ID_lop_tc=" & dt_main.Rows(i)("ID_lop_tc") & " AND ID_SV=" & dt_main.Rows(i)("ID_SV")
                    clsDM.Execute(SQL)
                Next

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Function Check_ThoiGianDuyet(ByVal Ky_dang_ky As Integer) As Boolean
            Dim cls As New DanhMuc_DataAccess
            Return cls.Check_ThoiGianDuyet(Ky_dang_ky)
        End Function
        Sub Insert_DM()
            Dim cls As New DanhMuc_DataAccess
            cls.Insert_DangKySai()
        End Sub

        Function Cat_Xau(ByVal str As String, ByVal do_dai As Integer) As String
            Return Right(str.Trim, do_dai).ToString
        End Function


    End Class
End Namespace