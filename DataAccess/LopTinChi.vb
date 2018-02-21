'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LopTinChi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLopTinChi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLopTinChi_DanhSach(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLopTinChi_DanhSach_TKB(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_TKB_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSLopSinhVienDangKyTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("PLAN_ThongKeSinhVienDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSThongKeSVLopTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("PLAN_ThongKeSVLopTinChi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSThongKeSinhVienDangKyTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("PLAN_MonDangKyTinChiDanhSachSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub CapNhat_ESSHuyLopTinChi(ByVal ID_lop_tc As Integer, ByVal HuyLop As Integer, ByVal Ly_do As String)
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@HuyLop", HuyLop)
                para(2) = New SqlParameter("@Ly_do", Ly_do)
                Connect.ExecuteSP("PLAN_LopTinChi_TCHuyLop_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub CapNhat_ESSHuyDangKySV(ByVal ID_lop_tc As Integer, ByVal ID_sv As Integer, ByVal Ly_do As String)
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Ly_do", Ly_do)
                Connect.ExecuteSP("PLAN_LopTinChi_TCSinhVienHuyDangKy_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function SuKiensLopTinChi(ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_Chon_Lop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function tkb_PhongHoc(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_TKB_PHONGHOC", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function tkb_GiangVien(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_TKB_GIAOVIEN", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

