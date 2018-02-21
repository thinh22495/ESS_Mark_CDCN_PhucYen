'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 21, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class MonTinChi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSMonTinChi_DanhSach(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonTinChi_PhanQuyen_DanhSach(ByVal Ky_dang_ky As Integer, Optional ByVal ID_bomon As Integer = 0, Optional ByVal ID_khoa As Integer = 0) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@ID_bomon", ID_bomon)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TC_PhanQuyen_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSLopTinChi_DanhSach(ByVal Ky_dang_ky As Integer, Optional ByVal ID_bomon As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal User_Name As String = "") As DataTable
            Try
                If User_Name <> "" Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@ID_bomon", ID_bomon)
                    para(3) = New SqlParameter("@User_Name", User_Name)
                    Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DanhSach_User", para)
                Else
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                    para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(2) = New SqlParameter("@ID_bomon", ID_bomon)
                    Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DanhSach", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function HienThi_ESSPhamViDangKy_DanhSach(ByVal Ky_dang_ky As Integer, Optional ByVal ID_bomon As Integer = 0, Optional ByVal ID_khoa As Integer = 0) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@ID_bomon", ID_bomon)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSKeHoachKhac_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("PLAN_KeHoachKhac_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKeHoachKyHieu_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_KeHoachKyHieu_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHocKyDangKy_DanhSach(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSHocKyDangKy_DanhSach(ByVal Dot As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Dot", Dot)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TCDot_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSChuongTrinhDaoTaoChiTietMonTinChi_DanhSach(ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@Kien_thuc", Kien_thuc)
                para(1) = New SqlParameter("@Bat_buoc", Bat_buoc)
                para(2) = New SqlParameter("@Tu_chon", Tu_chon)
                para(3) = New SqlParameter("@ID_he", ID_he)
                para(4) = New SqlParameter("@ID_khoa", ID_khoa)
                para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(7) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(8) = New SqlParameter("@Ky_thu", Ky_thu)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTaoChiTietMonTinChi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSHocKyDangKyQuyDinh_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TCQuyDinh_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSMonTinChi(ByVal obj As ESSMonTinChi) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                para(1) = New SqlParameter("@Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(6) = New SqlParameter("@He_so", obj.He_so)
                para(7) = New SqlParameter("@So_tien", obj.So_tien)
                para(8) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(9) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_MonTinChi_TC_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KhoaMo_MonTinChi(ByVal Lock As Boolean, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@Locked", Lock)
                Return Connect.ExecuteSP("PLAN_MonTinChi_TC_KhoaMo", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSMonTinChi(ByVal obj As ESSMonTinChi, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@Ky_hieu_lop_tc", obj.Ky_hieu_lop_tc)
                para(2) = New SqlParameter("@He_so", obj.He_so)
                Return Connect.ExecuteSP("PLAN_MonTinChi_TC_CapNhat", para)

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSMonTinChi(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                Return Connect.ExecuteSP("PLAN_MonTinChi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_MonTinChi(ByVal Ky_dang_ky As Integer, ByVal ID_mon As Integer, ByVal So_hoc_trinh As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@So_hoc_trinh", So_hoc_trinh)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_MonTinChi_TC_KiemTraMon", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_MonTinChi_Ten(ByVal Ky_dang_ky As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_MonTinChi_TC_KiemTraTen", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_MonTinChi_TenUpdate(ByVal ID_mon_tc As Integer, ByVal Ky_dang_ky As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                para(2) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_MonTinChi_TC_KiemTraTen_CapNhat", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLopTinChi(ByVal obj As ESSLopTinChi) As Integer
            Try
                Dim para(13) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_lt", obj.ID_lop_lt)
                para(1) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(2) = New SqlParameter("@STT_lop", obj.STT_lop)
                para(3) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                para(4) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                para(5) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                para(6) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(7) = New SqlParameter("@ID_cb", obj.ID_cb)
                para(8) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(9) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                para(10) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                para(11) = New SqlParameter("@Huy_lop", obj.Huy_lop)
                para(12) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(13) = New SqlParameter("@Nhom_dang_ky", obj.Nhom_dang_ky)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_LopTinChi_TC_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChiEdit(ByVal obj As ESSLopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                para(2) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                para(3) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                para(4) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(5) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                para(6) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                para(7) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(8) = New SqlParameter("@ID_cb", obj.ID_cb)
                para(9) = New SqlParameter("@STT_lop", obj.STT_lop)

                Return Connect.ExecuteSP("PLAN_LopTinChi_TC_UpdateEdit", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSLopTinChi(ByVal obj As ESSLopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(14) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop_lt", obj.ID_lop_lt)
                para(2) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(3) = New SqlParameter("@STT_lop", obj.STT_lop)
                para(4) = New SqlParameter("@So_sv_min", obj.So_sv_min)
                para(5) = New SqlParameter("@So_sv_max", obj.So_sv_max)
                para(6) = New SqlParameter("@So_tiet_tuan", obj.So_tiet_tuan)
                para(7) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(8) = New SqlParameter("@ID_cb", obj.ID_cb)
                para(9) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(10) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                para(11) = New SqlParameter("@Ca_hoc", obj.Ca_hoc)
                para(12) = New SqlParameter("@Huy_lop", obj.Huy_lop)
                para(13) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(14) = New SqlParameter("@Nhom_dang_ky", obj.Nhom_dang_ky)
                Return Connect.ExecuteSP("PLAN_LopTinChi_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLopTinChi(ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.ExecuteSP("PLAN_LopTinChi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSPhamViDangKy(ByVal obj As ESSPhamViDangKy) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSPhamViDangKy(ByVal obj As ESSPhamViDangKy, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSPhamViDangKy(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyLop_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyLopChon_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCLopChon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyLopPhanBo_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCLopPhanBo_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyHocPhan_DanhSach(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_lop", ID_lop)

                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCHocPhan_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyHocPhanChon_DanhSach(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCHocPhanChon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbPhamViDangKyHocPhanPhanBo_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_PhamViDangKy_TCHocPhanPhanBo_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESStkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TCLop_ThemMoi", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function CheckExist_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim dt As New DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                dt = Connect.SelectTableSP("PLAN_PhamViDangKy_TCLop_KiemTraTonTai", para)
                If dt.Rows.Count = 0 Then Return False Else Return True
            Catch ex As Exception
            End Try
        End Function

        Public Function Xoa_ESStkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TCLop_Xoa", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function ThemMoi_ESStkbPhamViDangKyHocPhan(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TCHocPhan_ThemMoi", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function Xoa_ESStkbPhamViDangKyHocPhan(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_PhamViDangKy_TCHocPhan_Xoa", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function CheckExist_tkbPhamViDangKyHocPhan(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim dt As New DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                dt = Connect.SelectTableSP("PLAN_PhamViDangKy_TCHocPhan_KiemTraTonTai", para)

                If dt.Rows.Count = 0 Then Return False Else Return True
            Catch ex As Exception
            End Try
        End Function
#End Region

        Public Function Load_CapTiet_LopTinChi(ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("PLAN_LOPTINCHI_CapTiet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

