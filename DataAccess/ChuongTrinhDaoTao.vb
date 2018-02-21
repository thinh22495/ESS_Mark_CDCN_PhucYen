'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ChuongTrinhDaoTao_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSMonHocTrongDiem_1(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_dt As String = "") As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_bm", ID_bm)
                para(4) = New SqlParameter("@ID_sv", ID_sv)
                para(5) = New SqlParameter("@ID_dv", ID_dv)
                para(6) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietDiem_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTao_DanhSach(ByVal dsID_dt As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_dt", dsID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTao_Lop_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_HienThi_Lop_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTaoChiTiet_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTiet_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonHocTrongCTDT(ByVal dsID_dt As String, ByVal ID_bm As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@dsID_dt", dsID_dt)
                para(1) = New SqlParameter("@ID_bm", ID_bm)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietMon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTaoMonRangBuoc_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_MonRangBuoc_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonHocTrongDiem(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_dt As Integer = 0) As DataTable
            Try
                Dim sID_dt As String
                If ID_dt = 0 Then sID_dt = "0" Else sID_dt = ID_dt.ToString
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_bm", ID_bm)
                para(4) = New SqlParameter("@ID_sv", ID_sv)
                para(5) = New SqlParameter("@ID_dv", ID_dv)
                para(6) = New SqlParameter("@ID_dt", sID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietDiem_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonHocTrongDiem_ID_Dts(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_dt As String = "0") As DataTable
            Try
                Dim sID_dt As String
                If ID_dt = "0" Then sID_dt = "0" Else sID_dt = ID_dt.ToString
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_bm", ID_bm)
                para(4) = New SqlParameter("@ID_sv", ID_sv)
                para(5) = New SqlParameter("@ID_dv", ID_dv)
                para(6) = New SqlParameter("@ID_dt", sID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietDiem_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTao(ByVal obj As ESSChuongTrinhDaoTao) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", obj.ID_he)
                para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(5) = New SqlParameter("@So_ky_hoc", obj.So_ky_hoc)
                para(6) = New SqlParameter("@So", obj.So)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTao(ByVal obj As ESSChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(4) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(5) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(6) = New SqlParameter("@So_ky_hoc", obj.So_ky_hoc)
                para(7) = New SqlParameter("@So", obj.So)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTao_Lop(ByVal ID_lop As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_CapNhat_Lop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTao(ByVal ID_dt As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@So", So)
                Dim dt As New DataTable
                dt = Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_ChuongTrinhDaoTao_Diem(ByVal ID_dt As Integer, Optional ByVal ID_mon As Integer = 0) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_KiemTraTonTai_Diem", para).Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoChiTiet(ByVal obj As ESSChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim para(18) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@Ky_thu", obj.Ky_thu)
                para(3) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(4) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(5) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(6) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(7) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                para(8) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                para(9) = New SqlParameter("@Tu_chon", obj.Tu_chon)
                para(10) = New SqlParameter("@STT_mon", obj.STT_mon)
                para(11) = New SqlParameter("@He_so", obj.He_so)
                para(12) = New SqlParameter("@Kien_thuc", obj.Kien_thuc)
                para(13) = New SqlParameter("@Khong_tinh_TBCHT", obj.Khong_tinh_TBCHT)
                para(14) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(15) = New SqlParameter("@Tu_hoc", obj.Tu_hoc)
                para(16) = New SqlParameter("@So_hoc_trinh_tien_quyet", obj.So_hoc_trinh_tien_quyet)
                para(17) = New SqlParameter("@Ma_khoa_phu_trach", obj.Ma_khoa_phu_trach)
                para(18) = New SqlParameter("@HP_tuong_duong", obj.HP_tuong_duong)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_ChiTiet_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTaoChiTiet(ByVal obj As ESSChuongTrinhDaoTaoChiTiet, ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim para(24) As SqlParameter
                para(0) = New SqlParameter("@ID_dt_mon", ID_dt_mon)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@Ky_thu", obj.Ky_thu)
                para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(5) = New SqlParameter("@Ly_thuyet", obj.Ly_thuyet)
                para(6) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                para(7) = New SqlParameter("@Bai_tap", obj.Bai_tap)
                para(8) = New SqlParameter("@Bai_tap_lon", obj.Bai_tap_lon)
                para(9) = New SqlParameter("@Thuc_tap", obj.Thuc_tap)
                para(10) = New SqlParameter("@Tu_chon", obj.Tu_chon)
                para(11) = New SqlParameter("@STT_mon", obj.STT_mon)
                para(12) = New SqlParameter("@He_so", obj.He_so)
                para(13) = New SqlParameter("@Kien_thuc", obj.Kien_thuc)
                para(14) = New SqlParameter("@Khong_tinh_TBCHT", obj.Khong_tinh_TBCHT)
                para(15) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(16) = New SqlParameter("@Tu_hoc", obj.Tu_hoc)
                para(17) = New SqlParameter("@So_hoc_trinh_tien_quyet", obj.So_hoc_trinh_tien_quyet)
                para(18) = New SqlParameter("@Ma_khoa_phu_trach", obj.Ma_khoa_phu_trach)
                para(19) = New SqlParameter("@Mon_tot_nghiep", obj.Mon_tot_nghiep)
                para(20) = New SqlParameter("@Ty_le_ly_thuyet", obj.Ty_le_ly_thuyet)
                para(21) = New SqlParameter("@Ty_le_thuc_hanh", obj.Ty_le_thuc_hanh)
                para(22) = New SqlParameter("@HP_tuong_duong", obj.HP_tuong_duong)
                para(23) = New SqlParameter("@So_tien_tai_lieu", obj.So_tien_tai_lieu)
                para(24) = New SqlParameter("@HocPhan_DaiCuong", obj.HocPhan_DaiCuong)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_ChiTiet_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTaoChiTiet(ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt_mon", ID_dt_mon)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_ChiTiet_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSChuongTrinhDaoTaoRangBuoc(ByVal obj As ESSChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_rb", obj.ID_rb)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                para(4) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_RangBuoc_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoRangBuoc(ByVal obj As ESSChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                para(3) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_RangBuoc_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(ByVal obj As ESSChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@ID_mon_rb", obj.ID_mon_rb)
                para(3) = New SqlParameter("@Loai_rang_buoc", obj.Loai_rang_buoc)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_RangBuoc_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Xoa_ESSChuongTrinhDaoTaoRangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_mon_rb", ID_mon_rb)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_RangBuoc_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSChuyenNganh_DanhSach(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal khoa_hoc As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim sID_dt As String = ""
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@khoa_hoc", khoa_hoc)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSChuongTrinhDaoTao_MonTuongDuong(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_tuong_duong As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_mon_tuong_duong", ID_mon_tuong_duong)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TuongDuong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTao_MonTuongDuongBuoc(ByVal ID_tuong_duong As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_tuong_duong", ID_tuong_duong)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TuongDuong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonHocTrongDiem_NganhHoc2(ByVal ID_dv As String, ByVal ID_bm As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_dt As Integer = 0) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_bm", ID_bm)
                para(3) = New SqlParameter("@ID_dv", ID_dv)
                para(4) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietDiem_HienThi_DanhSach_NganhHoc2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

