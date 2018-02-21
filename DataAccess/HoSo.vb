'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, April 17, 2010 me cha thang duc ga 
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports System.IO
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class HoSo_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
#Region "FunctionSub"
        Public Function HienThi_ESSHoSoXoa_DanhSach() As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Return Connect.SelectTableSP("STU_HoSoSinhVienXoa_HienThi_DanhSach")
                Else
                    Return Connect.SelectTableSP("STU_HoSoSinhVienXoa_HienThi_DanhSach")
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load hồ sơ sub
        Public Function LoadHoSoSub(ByVal ID_sv As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return Connect.SelectTableSP("STU_HoSoSinhVienSub_HienThi", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return Connect.SelectTableSP("STU_HoSoSinhVienSub_HienThi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New SqlParameter("@Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New SqlParameter("@So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New SqlParameter("@Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New SqlParameter("@Fax", dt.Rows(0)("Fax"))
                    para(5) = New SqlParameter("@Email", dt.Rows(0)("Email"))
                    para(6) = New SqlParameter("@ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New SqlParameter("@ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New SqlParameter("@Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New SqlParameter("@ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_ThemMoi", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New OracleParameter(":Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New OracleParameter(":So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New OracleParameter(":Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New OracleParameter(":Fax", dt.Rows(0)("Fax"))
                    para(5) = New OracleParameter(":Email", dt.Rows(0)("Email"))
                    para(6) = New OracleParameter(":ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New OracleParameter(":ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New OracleParameter(":Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New OracleParameter(":ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_ThemMoi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(9) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New SqlParameter("@Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New SqlParameter("@So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New SqlParameter("@Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New SqlParameter("@Fax", dt.Rows(0)("Fax"))
                    para(5) = New SqlParameter("@Email", dt.Rows(0)("Email"))
                    para(6) = New SqlParameter("@ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New SqlParameter("@ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New SqlParameter("@Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New SqlParameter("@ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_CapNhat", para)
                Else
                    Dim para(9) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", dt.Rows(0)("ID_sv"))
                    para(1) = New OracleParameter(":Dia_chi_day_du", dt.Rows(0)("Dia_chi_day_du"))
                    para(2) = New OracleParameter(":So_dien_thoai", dt.Rows(0)("So_dien_thoai"))
                    para(3) = New OracleParameter(":Di_dong", dt.Rows(0)("Di_dong"))
                    para(4) = New OracleParameter(":Fax", dt.Rows(0)("Fax"))
                    para(5) = New OracleParameter(":Email", dt.Rows(0)("Email"))
                    para(6) = New OracleParameter(":ID_co_quan_lam_viec", dt.Rows(0)("ID_co_quan_lam_viec"))
                    para(7) = New OracleParameter(":ID_tinh_chat_cong_viec", dt.Rows(0)("ID_tinh_chat_cong_viec"))
                    para(8) = New OracleParameter(":Muc_thu_nhap_thang", dt.Rows(0)("Muc_thu_nhap_thang"))
                    para(9) = New OracleParameter(":ID_noi_lam_viec", dt.Rows(0)("ID_noi_lam_viec"))
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoSinhVienSub(ByVal ID_sv As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_Xoa", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    Return Connect.ExecuteSP("STU_HoSoSinhVienSub_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoSoSinhVienSub(ByVal ID_sv As Integer) As Boolean
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_sv", ID_sv)
                    If Connect.SelectTableSP("STU_HoSoSinhVienSub_KiemTraTonTai", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_sv", ID_sv)
                    If Connect.SelectTableSP("STU_HoSoSinhVienSub_KiemTraTonTai", para).Rows.Count > 0 Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
        Public Function LoadID_dt_nganh2(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_HoSoSinhVien_HienThi_ID_dt_nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoSo_DanhSach(ByVal dsID_sv As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_sv", dsID_sv)
                Return Connect.SelectTableSP("STU_HoSoSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaSinhVien(ByVal Ma_sv As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                para(0).Value = Ma_sv
                If Connect.SelectTableSP("STU_HoSoSinhVien_KiemTraTonTai_MaSV", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetID_SV(ByVal Ma_sv As String) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                para(0).Value = Ma_sv
                Dim dt As DataTable = Connect.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item(0)
                Else
                    Return -1
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetImage(ByVal Ma_sv As String) As Byte()
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", SqlDbType.NVarChar)
                para(0).Value = Ma_sv
                Dim dt As DataTable = Connect.SelectTableSP("STU_HoSoSinhVien_GetImage", para)
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0).Item("Anh").ToString <> "" Then Return CType(dt.Rows(0).Item("Anh"), Byte())
                End If
                Return Nothing
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSo(ByVal obj As ESSHoSo) As Integer
            Try
                Dim para(76) As SqlParameter
                para(0) = New SqlParameter("@Anh", obj.Anh)
                para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                If obj.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                If obj.Ngay_vao_doan = Nothing Then
                    para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                Else
                    para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                End If
                If obj.Ngay_vao_dang = Nothing Then
                    para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                Else
                    para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                End If
                para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                para(24) = New SqlParameter("@Diem1", obj.Diem1)
                para(25) = New SqlParameter("@Diem2", obj.Diem2)
                para(26) = New SqlParameter("@Diem3", obj.Diem3)
                para(27) = New SqlParameter("@Diem4", obj.Diem4)
                para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                para(29) = New SqlParameter("@SBD", obj.SBD)
                para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                para(62) = New SqlParameter("@Lop", obj.Lop)
                para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                para(64) = New SqlParameter("@UserID", obj.UserID)
                para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                If obj.Ngay_nhap_hoc = Nothing Then
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                End If
                para(68) = New SqlParameter("@CMND", obj.CMND)
                para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                para(70) = New SqlParameter("@Email", obj.Email)
                para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                para(74) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                If obj.Ngay_cap = Nothing Then
                    para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                Else
                    para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                End If
                para(76) = New SqlParameter("@IDCard", obj.IDCard)

                Return Connect.ExecuteSP("STU_HoSoSinhVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSo_KhoiPhuc(ByVal obj As ESSHoSo) As Integer
            Try
                Dim para(76) As SqlParameter
                para(0) = New SqlParameter("@Anh", obj.Anh)
                para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                If obj.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                If obj.Ngay_vao_doan = Nothing Then
                    para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                Else
                    para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                End If
                If obj.Ngay_vao_dang = Nothing Then
                    para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                Else
                    para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                End If
                para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                para(24) = New SqlParameter("@Diem1", obj.Diem1)
                para(25) = New SqlParameter("@Diem2", obj.Diem2)
                para(26) = New SqlParameter("@Diem3", obj.Diem3)
                para(27) = New SqlParameter("@Diem4", obj.Diem4)
                para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                para(29) = New SqlParameter("@SBD", obj.SBD)
                para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                para(62) = New SqlParameter("@Lop", obj.Lop)
                para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                para(64) = New SqlParameter("@UserID", obj.UserID)
                para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                If obj.Ngay_nhap_hoc = Nothing Then
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                End If
                para(68) = New SqlParameter("@CMND", obj.CMND)
                para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                para(70) = New SqlParameter("@Email", obj.Email)
                para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                para(74) = New SqlParameter("@ID_sv", obj.ID_sv)
                If obj.Ngay_cap = Nothing Or Not IsDate(obj.Ngay_cap) Then
                    para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                Else
                    para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                End If
                para(76) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                para(77) = New SqlParameter("@IDCard", obj.IDCard)
                Return Connect.ExecuteSP("STU_HoSoSinhVien_KhoiPhuc_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoTemp(ByVal obj As ESSHoSo) As Integer
            Try
                Dim para(76) As SqlParameter
                para(0) = New SqlParameter("@Anh", obj.Anh)
                para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                If obj.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                If obj.Ngay_vao_doan = Nothing Then
                    para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                Else
                    para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                End If
                If obj.Ngay_vao_dang = Nothing Then
                    para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                Else
                    para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                End If
                para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                para(24) = New SqlParameter("@Diem1", obj.Diem1)
                para(25) = New SqlParameter("@Diem2", obj.Diem2)
                para(26) = New SqlParameter("@Diem3", obj.Diem3)
                para(27) = New SqlParameter("@Diem4", obj.Diem4)
                para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                para(29) = New SqlParameter("@SBD", obj.SBD)
                para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                para(62) = New SqlParameter("@Lop", obj.Lop)
                para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                para(64) = New SqlParameter("@UserID", obj.UserID)
                para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                If obj.Ngay_nhap_hoc = Nothing Then
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                End If
                para(68) = New SqlParameter("@CMND", obj.CMND)
                para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                para(70) = New SqlParameter("@Email", obj.Email)
                para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                para(74) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                If obj.Ngay_cap = Nothing Then
                    para(75) = New SqlParameter("@Ngay_cap", DBNull.Value)
                Else
                    para(75) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                End If
                para(76) = New SqlParameter("@IDCard", obj.IDCard)

                Return Connect.ExecuteSP("STU_HoSoSinhVienTemp_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoXoa(ByVal obj As ESSHoSo) As Integer
            Try
                Dim para(77) As SqlParameter
                para(0) = New SqlParameter("@Anh", obj.Anh)
                para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                If obj.Ngay_sinh = Nothing Then
                    para(3) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(3) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                End If
                para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(5) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                para(6) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                para(7) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                para(8) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                If obj.Ngay_vao_doan = Nothing Then
                    para(9) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                Else
                    para(9) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                End If
                If obj.Ngay_vao_dang = Nothing Then
                    para(10) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                Else
                    para(10) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                End If
                para(11) = New SqlParameter("@Que_quan", obj.Que_quan)
                para(12) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                para(13) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                para(14) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                para(15) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                para(16) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                para(17) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                para(18) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                para(19) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                para(20) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                para(21) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                para(22) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                para(23) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                para(24) = New SqlParameter("@Diem1", obj.Diem1)
                para(25) = New SqlParameter("@Diem2", obj.Diem2)
                para(26) = New SqlParameter("@Diem3", obj.Diem3)
                para(27) = New SqlParameter("@Diem4", obj.Diem4)
                para(28) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                para(29) = New SqlParameter("@SBD", obj.SBD)
                para(30) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                para(31) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                para(32) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                para(33) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                para(34) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                para(35) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                para(36) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                para(37) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                para(38) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                para(39) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                para(40) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                para(41) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                para(42) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                para(43) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                para(44) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                para(45) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                para(46) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                para(47) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                para(48) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                para(49) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                para(50) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                para(51) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                para(52) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                para(53) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                para(54) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                para(55) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                para(56) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                para(57) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                para(58) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                para(59) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                para(60) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                para(61) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                para(62) = New SqlParameter("@Lop", obj.Lop)
                para(63) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                para(64) = New SqlParameter("@UserID", obj.UserID)
                para(65) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                para(66) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                If obj.Ngay_nhap_hoc = Nothing Then
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(67) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                End If
                para(68) = New SqlParameter("@CMND", obj.CMND)
                para(69) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                para(70) = New SqlParameter("@Email", obj.Email)
                para(71) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                para(72) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                para(73) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                para(74) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(75) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                If obj.Ngay_cap = Nothing Then
                    para(76) = New SqlParameter("@Ngay_cap", DBNull.Value)
                Else
                    para(76) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                End If
                para(77) = New SqlParameter("@IDCard", obj.IDCard)

                Return Connect.ExecuteSP("STU_HoSoSinhVienXoa_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSo(ByVal obj As ESSHoSo, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(77) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Anh", obj.Anh)
                para(2) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(3) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                If obj.Ngay_sinh = Nothing Then
                    para(4) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(4) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                End If
                para(5) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(6) = New SqlParameter("@ID_dan_toc", obj.ID_dan_toc)
                para(7) = New SqlParameter("@ID_quoc_tich", obj.ID_quoc_tich)
                para(8) = New SqlParameter("@Ton_giao", obj.Ton_giao)
                para(9) = New SqlParameter("@ID_thanh_phan_xuat_than", obj.ID_thanh_phan_xuat_than)
                If obj.Ngay_vao_doan = Nothing Then
                    para(10) = New SqlParameter("@Ngay_vao_doan", DBNull.Value)
                Else
                    para(10) = New SqlParameter("@Ngay_vao_doan", obj.Ngay_vao_doan)
                End If
                If obj.Ngay_vao_dang = Nothing Then
                    para(11) = New SqlParameter("@Ngay_vao_dang", DBNull.Value)
                Else
                    para(11) = New SqlParameter("@Ngay_vao_dang", obj.Ngay_vao_dang)
                End If
                para(12) = New SqlParameter("@Que_quan", obj.Que_quan)
                para(13) = New SqlParameter("@ID_tinh_ns", obj.ID_tinh_ns)
                para(14) = New SqlParameter("@Dia_chi_tt", obj.Dia_chi_tt)
                para(15) = New SqlParameter("@Xa_phuong_tt", obj.Xa_phuong_tt)
                para(16) = New SqlParameter("@ID_huyen_tt", obj.ID_huyen_tt)
                para(17) = New SqlParameter("@ID_tinh_tt", obj.ID_tinh_tt)
                para(18) = New SqlParameter("@ID_doi_tuong_TC", obj.ID_doi_tuong_TC)
                para(19) = New SqlParameter("@ID_doi_tuong_TS", obj.ID_doi_tuong_TS)
                para(20) = New SqlParameter("@Dien_thoai_NR", obj.Dien_thoai_NR)
                para(21) = New SqlParameter("@ID_nhom_doi_tuong", obj.ID_nhom_doi_tuong)
                para(22) = New SqlParameter("@Dia_chi_bao_tin", obj.Dia_chi_bao_tin)
                para(23) = New SqlParameter("@ID_khu_vuc_TS", obj.ID_khu_vuc_TS)
                para(24) = New SqlParameter("@Doi_tuong_du_thi", obj.Doi_tuong_du_thi)
                para(25) = New SqlParameter("@Diem1", obj.Diem1)
                para(26) = New SqlParameter("@Diem2", obj.Diem2)
                para(27) = New SqlParameter("@Diem3", obj.Diem3)
                para(28) = New SqlParameter("@Diem4", obj.Diem4)
                para(29) = New SqlParameter("@Tong_diem", obj.Tong_diem)
                para(30) = New SqlParameter("@SBD", obj.SBD)
                para(31) = New SqlParameter("@Nganh_tuyen_sinh", obj.Nganh_tuyen_sinh)
                para(32) = New SqlParameter("@Khoi_thi", obj.Khoi_thi)
                para(33) = New SqlParameter("@Xep_loai_hoc_tap", obj.Xep_loai_hoc_tap)
                para(34) = New SqlParameter("@Xep_loai_hanh_kiem", obj.Xep_loai_hanh_kiem)
                para(35) = New SqlParameter("@Xep_loai_tot_nghiep", obj.Xep_loai_tot_nghiep)
                para(36) = New SqlParameter("@Nam_tot_nghiep", obj.Nam_tot_nghiep)
                para(37) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                para(38) = New SqlParameter("@Ly_do_thuong_diem", obj.Ly_do_thuong_diem)
                para(39) = New SqlParameter("@Khen_thuong_ky_luat", obj.Khen_thuong_ky_luat)
                para(40) = New SqlParameter("@Qua_trinh_HT_LD", obj.Qua_trinh_HT_LD)
                para(41) = New SqlParameter("@Ho_ten_cha", obj.Ho_ten_cha)
                para(42) = New SqlParameter("@ID_quoc_tich_cha", obj.ID_quoc_tich_cha)
                para(43) = New SqlParameter("@ID_dan_toc_cha", obj.ID_dan_toc_cha)
                para(44) = New SqlParameter("@Ton_giao_cha", obj.Ton_giao_cha)
                para(45) = New SqlParameter("@Ho_khau_TT_cha", obj.Ho_khau_TT_cha)
                para(46) = New SqlParameter("@Hoat_dong_XH_CT_cha", obj.Hoat_dong_XH_CT_cha)
                para(47) = New SqlParameter("@Ho_ten_me", obj.Ho_ten_me)
                para(48) = New SqlParameter("@ID_quoc_tich_me", obj.ID_quoc_tich_me)
                para(49) = New SqlParameter("@ID_dan_toc_me", obj.ID_dan_toc_me)
                para(50) = New SqlParameter("@Ton_giao_me", obj.Ton_giao_me)
                para(51) = New SqlParameter("@Ho_khau_TT_me", obj.Ho_khau_TT_me)
                para(52) = New SqlParameter("@Hoat_dong_XH_CT_me", obj.Hoat_dong_XH_CT_me)
                para(53) = New SqlParameter("@Ho_ten_vo_chong", obj.Ho_ten_vo_chong)
                para(54) = New SqlParameter("@ID_quoc_tich_vo_chong", obj.ID_quoc_tich_vo_chong)
                para(55) = New SqlParameter("@ID_dan_toc_vo_chong", obj.ID_dan_toc_vo_chong)
                para(56) = New SqlParameter("@Ton_giao_vo_chong", obj.Ton_giao_vo_chong)
                para(57) = New SqlParameter("@Ho_khau_TT_vo_chong", obj.Ho_khau_TT_vo_chong)
                para(58) = New SqlParameter("@Hoat_dong_XH_CT_vo_chong", obj.Hoat_dong_XH_CT_vo_chong)
                para(59) = New SqlParameter("@Ho_ten_nghe_nghiep_anh_em", obj.Ho_ten_nghe_nghiep_anh_em)
                para(60) = New SqlParameter("@Dang_ky_hoc", obj.Dang_ky_hoc)
                para(61) = New SqlParameter("@Hoten_Order", obj.Hoten_Order)
                para(62) = New SqlParameter("@Chuyen_nganh_dang_ky", obj.Chuyen_nganh_dang_ky)
                para(63) = New SqlParameter("@Lop", obj.Lop)
                para(64) = New SqlParameter("@Ngoai_ngu", obj.Ngoai_ngu)
                para(65) = New SqlParameter("@UserID", obj.UserID)
                para(66) = New SqlParameter("@UserName_tiep_nhan", obj.UserName_tiep_nhan)
                para(67) = New SqlParameter("@UserID_tiep_nhan", obj.UserID_tiep_nhan)
                If obj.Ngay_nhap_hoc = Nothing Then
                    para(68) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(68) = New SqlParameter("@Ngay_nhap_hoc", obj.Ngay_nhap_hoc)
                End If
                para(69) = New SqlParameter("@CMND", obj.CMND)
                para(70) = New SqlParameter("@Dienthoai_canhan", obj.Dienthoai_canhan)
                para(71) = New SqlParameter("@Email", obj.Email)
                para(72) = New SqlParameter("@NoiO_hiennay", obj.NoiO_hiennay)
                para(73) = New SqlParameter("@Namsinh_cha", obj.Namsinh_cha)
                para(74) = New SqlParameter("@Namsinh_me", obj.Namsinh_me)
                para(75) = New SqlParameter("@Noi_cap", obj.Noi_cap)
                If obj.Ngay_cap = Nothing Then
                    para(76) = New SqlParameter("@Ngay_cap", DBNull.Value)
                Else
                    para(76) = New SqlParameter("@Ngay_cap", obj.Ngay_cap)
                End If
                para(77) = New SqlParameter("@IDCard", obj.IDCard)
                Return Connect.ExecuteSP("STU_HoSoSinhVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSo(ByVal strUpdate As String) As Integer
            Try
                Return Connect.Execute(strUpdate)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoDTChinhSanh(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("STU_HoSoDTChinhSach_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoDTTroCap(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("STU_HoSoDTTroCap_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoXoa(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_HoSoSinhVienXoa_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSo(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_HoSoSinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoTemp(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_HoSoSinhVienTemp_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoTempMa_sv(ByVal Ma_sv As String) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                Return Connect.ExecuteSP("STU_HoSoSinhVienTempMasv_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSHoSo_Report_Load(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_ThongTinSinhVien_Report_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSHoSo_Report_Load1(ByVal Ma_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                Return Connect.SelectTableSP("STU_ThongTinSinhVien_Report_By_MaSV_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace

