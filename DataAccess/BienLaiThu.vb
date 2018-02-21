'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class BienLaiThu_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachSv(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_DoiTuong_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_Khoa(ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Lop_HienThi_Khoa_hoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSach_ThuChi_DanhSach(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_HienThi_DanhSach_ThuChi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.SelectTableSP("ACC_BienLaiThu_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                para(4) = New SqlParameter("@Thu_chi", Thu_chi)
                Return Connect.SelectTableSP("ACC_BienLaiThu_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiTiet(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.SelectTableSP("ACC_BienLaiThuChiTiet_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiTiet_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                para(4) = New SqlParameter("@Thu_chi", Thu_chi)
                Return Connect.SelectTableSP("ACC_BienLaiThuChiTiet_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhoanNop_HocKy_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_KhoanNop_HocKy_SinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachSinhVienKhoanNop_HocKy_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("ACC_KhoanNop_HocKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_MonDaThu_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                para(3) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                Return Connect.SelectTableSP("ACC_BienLaiThu_MonDangDaThu_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_MonDangKy_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                para(3) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiThu_MonDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_MonDangKyDanhSach_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("ACC_BienLaiThu_MonDangKyDanhSach_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSo_phieu() As Long
            Dim intID_bien_lai As Integer = getMaxID_bien_lai()
            Dim dtdata As New DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", intID_bien_lai)
                dtdata = Connect.SelectTableSP("ACC_BienLaiThu_GetSoPhieu", para)
                If dtdata.Rows.Count > 0 Then
                    Return dtdata.Rows(0).Item(0) + 1
                Else
                    Return 1
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Private Function getMaxID_bien_lai() As Long
            Try
                Dim dtData As New DataTable
                dtData = Connect.SelectTableSP("ACC_BienLaiThu_GetMaxID")
                If dtData.Rows(0).Item(0).ToString = "" Then
                    Return 0
                Else
                    Return dtData.Rows(0).Item(0)
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Public Function getID_sv(ByVal Ma_sv As String) As Long
            Dim dtData As New DataTable
            Dim para(0) As SqlParameter
            para(0) = New SqlParameter("@Ma_sv", Ma_sv)
            dtData = Connect.SelectTableSP("STU_HoSoSinhVien_GetID_SV", para)
            If dtData.Rows.Count > 0 Then
                Return dtData.Rows(0).Item(0)
            Else
                Return 0
            End If
        End Function
        Public Function getID_bien_lai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Dot_thu", Dot_thu)
                para(4) = New SqlParameter("@Lan_thu", Lan_thu)
                para(5) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                para(6) = New SqlParameter("@Thu_chi", Thu_chi)
                Dim dt As DataTable = Connect.SelectTableSP("sp_ACC_BienLaiThu_getID_bien_lai", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBienLaiThu(ByVal obj As ESSBienLaiThu) As Integer
            Try
                Dim para(15) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@Dot_thu", obj.Dot_thu)
                para(3) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(4) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(5) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                para(6) = New SqlParameter("@So_phieu", obj.So_phieu)
                para(7) = New SqlParameter("@Ngay_thu", obj.Ngay_thu)
                para(8) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(9) = New SqlParameter("@So_tien", obj.So_tien)
                para(10) = New SqlParameter("@So_tien_chu", obj.So_tien_chu)
                para(11) = New SqlParameter("@Ngoai_te", obj.Ngoai_te)
                para(12) = New SqlParameter("@Huy_phieu", obj.Huy_phieu)
                para(13) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(14) = New SqlParameter("@Nguoi_thu", obj.Nguoi_thu)
                para(15) = New SqlParameter("@Printed", obj.Printed)
                Dim dt As DataTable = Connect.SelectTableSP("ACC_BienLaiThu_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThu(ByVal obj As ESSBienLaiThu, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim para(16) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Dot_thu", obj.Dot_thu)
                para(4) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(5) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(6) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                para(7) = New SqlParameter("@So_phieu", obj.So_phieu)
                para(8) = New SqlParameter("@Ngay_thu", obj.Ngay_thu)
                para(9) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(10) = New SqlParameter("@So_tien", obj.So_tien)
                para(11) = New SqlParameter("@So_tien_chu", obj.So_tien_chu)
                para(12) = New SqlParameter("@Ngoai_te", obj.Ngoai_te)
                para(13) = New SqlParameter("@Huy_phieu", obj.Huy_phieu)
                para(14) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(15) = New SqlParameter("@Nguoi_thu", obj.Nguoi_thu)
                para(16) = New SqlParameter("@Printed", obj.Printed)
                Return Connect.ExecuteSP("ACC_BienLaiThu_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThu_HuyPhieu(ByVal ID_bien_lai As Integer, ByVal Ly_do As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                para(1) = New SqlParameter("@Ly_do", Ly_do)
                Return Connect.ExecuteSP("ACC_BienLaiThu_HuyPhieu_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThu(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.ExecuteSP("ACC_BienLaiThu_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBienLaiThuChiTiet(ByVal obj As ESSBienLaiThuChiTiet) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", obj.ID_bien_lai)
                para(1) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                para(2) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(3) = New SqlParameter("@So_tien", obj.So_tien)
                Dim dt As DataTable = Connect.SelectTableSP("ACC_BienLaiThuChiTiet_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThuChiTiet(ByVal obj As ESSBienLaiThuChiTiet, ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai_sub", ID_bien_lai_sub)
                para(1) = New SqlParameter("@ID_bien_lai", obj.ID_bien_lai)
                para(2) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(4) = New SqlParameter("@So_tien", obj.So_tien)
                Return Connect.ExecuteSP("ACC_BienLaiThuChiTiet_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThuChiTiet(ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai_sub", ID_bien_lai_sub)
                Return Connect.ExecuteSP("ACC_BienLaiThuChiTiet_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThuChiTiet_IDBienLai(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.ExecuteSP("ACC_BienLaiThuChiTiet_IDBienLai_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMucHocPhiTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("ACC_MucHocPhiTinChi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMucThiLai_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("STU_MucThiLai_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuHocKy(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThuHocKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuMonDangKy(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThuMonDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopDaNopHocPhi(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopDaNopHocPhiTheoMon(ByVal ID_sv As Integer, ByVal id_mon As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@id_mon", id_mon)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopDaNopHocPhiTheoMon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSBienLaiThu_ID_sv(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiThu_HienThi_ID_sv", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Search_BienLai(ByVal dsID_lop As String, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", dsID_lop)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                Return Connect.SelectTableSP("ACC_BienLaiThu_Search", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Search_BienLai_Hoc_ky(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", dsID_lop)
                Return Connect.SelectTableSP("ACC_BienLaiThu_Search_Hoc_ky", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuMonDangKy_New(ByVal TinhDenNgay As Date, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_hieu_lop_tc As String, ByVal ID_mon_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_lops", ID_lops)
                para(4) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                para(5) = New SqlParameter("@ID_sv", ID_sv)
                para(6) = New SqlParameter("@ID_he", ID_he)
                para(7) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(8) = New SqlParameter("@Tinh_Den_ngay", TinhDenNgay)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThuMonDangKy_New", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopThuMonDangKy_New_ToanKhoa(ByVal TinhDenNgay As Date, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_hieu_lop_tc As String, ByVal ID_mon_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_lops", ID_lops)
                para(4) = New SqlParameter("@Ky_hieu_lop_tc", Ky_hieu_lop_tc)
                para(5) = New SqlParameter("@ID_sv", ID_sv)
                para(6) = New SqlParameter("@ID_he", ID_he)
                para(7) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(8) = New SqlParameter("@Tinh_Den_ngay", TinhDenNgay)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThuMonDangKy_New_ToanKhoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocKy_New(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                para(3) = New SqlParameter("@ID_sv", ID_sv)
                para(4) = New SqlParameter("@ID_he", ID_he)
                para(5) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(6) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThu_HocKy_New", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocKy_New_ToanKhoa(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                para(3) = New SqlParameter("@ID_sv", ID_sv)
                para(4) = New SqlParameter("@ID_he", ID_he)
                para(5) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(6) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                Return Connect.SelectTableSP("ACC_BienLaiTongHopThu_HocKy_New_ToanKhoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_BienLai_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiThu_SV_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiThu_SV_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiTiet_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiThuChiTiet_SV_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiTiet_TheoHocKy(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.SelectTableSP("ACC_BienLaiThuChiTiet_HocKy_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

        Public Function TongHopHocPhiSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("sp_ACC_TongHopHocPhiSinhVien_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_BienLaiThu_DanhSach_KhoanThu_TH(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("ACC_BienLaiThu_TongHop_LietKeCacLoaiThu_Load_TH", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_BienLaiThu_DanhSachSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Lops As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_Lops", ID_Lops)
                Return Connect.SelectTableSP("ACC_BienLaiThu_TongHop_LietKeCacLoaiThu_SinhVienList", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_DanhSach_KhoanThu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Lops As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_Lops", ID_Lops)
                Return Connect.SelectTableSP("ACC_BienLaiThu_TongHop_LietKeCacLoaiThu_Load", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_DanhSach_KhoanThuTheoSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Lops As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_Lops", ID_Lops)
                Return Connect.SelectTableSP("ACC_BienLaiThu_TongHop_LietKeCacLoaiThu_TheoSinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopHocPhiSinhVien_SoDuCuoiKy(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("sp_ACC_TongHopHocPhiSinhVien_HienThi_SoDuCuoiKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_MucHocPhiTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Kinh_te As Boolean) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@Kinh_te", Kinh_te)
                Return Connect.SelectTableSP("sp_ACC_MucHocPhiHocPhan_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThuChiTiet(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.SelectTableSP("ACC_BienLaiThuChiTiet_Load_NC", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_BienLaiThu_MonDangKy_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Dot_thu", Dot_thu)
                para(3) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("sp_ACC_BienLaiThu_MonDangKy_DanhSach_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HocPhan_DangKy_SinhVien(ByVal ID_SV As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", ID_SV)
                Return Connect.SelectTableSP("sp_ACC_TongHopHocPhiSinhVien_XemTheoHocPhan", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getSo_phieu(ByVal Thu_chi As Integer, ByVal Gian_thu As Integer, ByVal ID_he As Integer) As Long

            Try
                Dim dtData As New DataTable
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Thu_chi", Thu_chi)
                para(1) = New SqlParameter("@Gian_thu", Gian_thu)
                para(2) = New SqlParameter("@ID_he", ID_he)
                dtData = Connect.SelectTableSP("sp_ACC_BienLaiThu_GetMax_So_phieu", para)
                If dtData.Rows(0).Item(0).ToString = "" Then
                    Return 1
                Else
                    Return dtData.Rows(0).Item(0) + 1
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function
        Public Function Load_BienLaiThu_MonDaThu_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("sp_ACC_BienLaiThu_MonDangDaThu_DanhSach_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_GhiChu_DiemDanh_ToChucThi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemDanh_TC_GhiChu_ToChucThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#Region "Chuyển khoản"
        Public Function CheckExist_ChuyenKhoan(ByVal Ngay_giao_dich As Date) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ngay_giao_dich", Ngay_giao_dich)
                Dim dt As DataTable = Connect.SelectTableSP("sp_ACC_ChuyenKhoan_CheckExist", para)
                If dt.Rows.Count > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Update_svChuyenKhoan(ByVal So_tai_khoan As String, ByVal IDSV As String, ByVal Ngay_giao_dich As Date) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                para(1) = New SqlParameter("@IDSV", IDSV)
                para(2) = New SqlParameter("@Ngay_giao_dich", Ngay_giao_dich)
                Return Connect.ExecuteSP("sp_ACC_ChuyenKhoan_Update", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub getSVInfor_TheoSoTaiKhoan(ByVal So_tai_khoan As String, ByRef ID_SV As Long, ByRef Ngoai_ngan_sach As Integer, ByRef Lop_Chat_Luong_Cao As Integer, ByRef ID_he As Integer, ByRef Khoa_hoc As Integer)
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                Dim dt As DataTable = Connect.SelectTableSP("sp_ACC_GetIDSinhVienTheoSoTaiKhoan", para)
                If dt.Rows.Count > 0 Then
                    ID_SV = dt.Rows(0)("ID_SV")
                    Ngoai_ngan_sach = dt.Rows(0)("Ngoai_ngan_sach")
                    Lop_Chat_Luong_Cao = dt.Rows(0)("Lop_Chat_Luong_Cao")
                    ID_he = dt.Rows(0)("ID_he")
                    Khoa_hoc = dt.Rows(0)("Khoa_hoc")
                Else
                    ID_SV = 0
                    Ngoai_ngan_sach = 0
                    Lop_Chat_Luong_Cao = 0
                    ID_he = 0
                    Khoa_hoc = 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function Insert_ChuyenKhoan(ByVal ID_bien_lai As Long, ByVal So_tai_khoan As String, ByVal Ma_sv As String, ByVal Ngay_giao_dich As Date, ByVal So_tien As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                para(1) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                para(2) = New SqlParameter("@Ma_sv", Ma_sv)
                para(3) = New SqlParameter("@Ngay_giao_dich", Ngay_giao_dich)
                para(4) = New SqlParameter("@So_tien", So_tien)
                Return Connect.ExecuteSP("sp_ACC_ChuyenKhoan_Insert", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_ChuyenKhoanChiTiet_SV(ByVal Tu_ngay As Date, ByVal Den_ngay As Date, ByVal ID_he As String) As DataTable
            Try
                Dim mTu_ngay, mDen_ngay As String
                mTu_ngay = Year(Tu_ngay)
                mDen_ngay = Year(Den_ngay)
                If Month(Tu_ngay).ToString.Length = 2 Then
                    mTu_ngay = mTu_ngay & Month(Tu_ngay)
                Else
                    mTu_ngay = mTu_ngay & "0" & Month(Tu_ngay)
                End If
                If Day(Tu_ngay).ToString.Length = 2 Then
                    mTu_ngay = mTu_ngay & Day(Tu_ngay)
                Else
                    mTu_ngay = mTu_ngay & "0" & Day(Tu_ngay)
                End If

                If Month(Den_ngay).ToString.Length = 2 Then
                    mDen_ngay = mDen_ngay & Month(Den_ngay)
                Else
                    mDen_ngay = mDen_ngay & "0" & Month(Den_ngay)
                End If
                If Day(Den_ngay).ToString.Length = 2 Then
                    mDen_ngay = mDen_ngay & Day(Den_ngay)
                Else
                    mDen_ngay = mDen_ngay & "0" & Day(Den_ngay)
                End If
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Tu_ngay", SqlDbType.Int)
                para(0).Value = mTu_ngay
                para(1) = New SqlParameter("@Den_ngay", SqlDbType.Int)
                para(1).Value = mDen_ngay
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("sp_ACC_ChuyenKhoanChiTiet_Load_List", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function sp_svChuyenKhoan_GetSoTienChuaLapBienLai(ByVal So_tai_khoan As String) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                Dim dt As DataTable = Connect.SelectTableSP("sp_ACC_ChuyenKhoan_GetSoTienChuaLapBienLai", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("so_tien")
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function sp_svChuyenKhoan_Update_Id_bien_lai(ByVal So_tai_khoan As String, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                para(1) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.ExecuteSP("sp_ACC_ChuyenKhoan_Update_Id_bien_lai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function sp_svChuyenKhoan_Update_Id_bien_lai(ByVal So_tai_khoan As String, ByVal Ngay_giao_dich As Date, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@So_tai_khoan", So_tai_khoan)
                para(1) = New SqlParameter("@Ngay_giao_dich", Ngay_giao_dich)
                para(2) = New SqlParameter("@ID_bien_lai", ID_bien_lai)
                Return Connect.ExecuteSP("sp_ACC_ChuyenKhoan_Update_Id_bien_lai2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function sp_svChuyenKhoan_Get_SoDu(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("sp_ACC_ChuyenKhoan_Get_SoDu", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Load_ChuyenKhoan_Loi(ByVal Tu_ngay As Date, ByVal Den_ngay As Date, ByVal ID_he As Integer) As DataTable
            Try
                Dim mTu_ngay, mDen_ngay As String
                mTu_ngay = Year(Tu_ngay)
                mDen_ngay = Year(Den_ngay)
                If Month(Tu_ngay).ToString.Length = 2 Then
                    mTu_ngay = mTu_ngay & Month(Tu_ngay)
                Else
                    mTu_ngay = mTu_ngay & "0" & Month(Tu_ngay)
                End If
                If Day(Tu_ngay).ToString.Length = 2 Then
                    mTu_ngay = mTu_ngay & Day(Tu_ngay)
                Else
                    mTu_ngay = mTu_ngay & "0" & Day(Tu_ngay)
                End If

                If Month(Den_ngay).ToString.Length = 2 Then
                    mDen_ngay = mDen_ngay & Month(Den_ngay)
                Else
                    mDen_ngay = mDen_ngay & "0" & Month(Den_ngay)
                End If
                If Day(Den_ngay).ToString.Length = 2 Then
                    mDen_ngay = mDen_ngay & Day(Den_ngay)
                Else
                    mDen_ngay = mDen_ngay & "0" & Day(Den_ngay)
                End If
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Tu_ngay", SqlDbType.Int)
                para(0).Value = mTu_ngay
                para(1) = New SqlParameter("@Den_ngay", SqlDbType.Int)
                para(1).Value = mDen_ngay
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("sp_ACC_ChuyenKhoan_Loi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace