'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ThongKeSoLieuDuBao_DataAccess
        'Public Function ThongKeSoLieuDuBao() As DataTable
        '    Try
        '        Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_HienThi")
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function ThongKeSoLieuDuBao(ByVal ID_he As Integer, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Tu_khoa", Tu_khoa)
                para(1) = New SqlParameter("@Den_khoa", Den_khoa)
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_CTrDT", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeSoLieuDuBao_ChuyenNganh(ByVal ID_he As Integer, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Tu_khoa", Tu_khoa)
                para(1) = New SqlParameter("@Den_khoa", Den_khoa)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_ChuyenNganh_CTrDT", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVienHoc_TCDT_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh1", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DaTichLuy_Nganh1(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh1", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVienHoc_TCDT_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DaTichLuy_Nganh2(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DaTichLuy_Nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DangKySom_Nganh1(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh1", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SoSinhVien_DangKySom_Nganh2(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_nganh", ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_DangKySom_Nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function SoSinhVienHoc_TCDT_Nganh1(ByVal Ky_thu As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Ky_thu", Ky_thu)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_nganh", ID_nganh)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_TCDT_Nganh1", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongkeTheoHocLai_HocCaiThien(ByVal ID_dv As String, ByVal ID_lops As String, ByVal Khoa_hoc1 As Integer, ByVal Khoa_hoc2 As Integer, ByVal ID_he As Integer, ByVal ID_mons As String, ByVal Diem As Double) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_DV", ID_dv)
                para(1) = New SqlParameter("@ID_lops", ID_lops)
                para(2) = New SqlParameter("@Khoa_hoc1", Khoa_hoc1)
                para(3) = New SqlParameter("@Khoa_hoc2", Khoa_hoc2)
                para(4) = New SqlParameter("@ID_he", ID_he)
                para(5) = New SqlParameter("@ID_mons", ID_mons)
                para(6) = New SqlParameter("@Diem", Diem)
                Return Connect.SelectTableSP("PLAN_ThongKe_SL_DuBao_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKeSoLieuDuBao_DangKySom(ByVal ID_he As Integer, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Tu_khoa", Tu_khoa)
                para(1) = New SqlParameter("@Den_khoa", Den_khoa)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_ChuyenNganh_DangKySom", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeSoLieuDuBao_DangKySom_ChiTiet(ByVal ID_he As Integer, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Tu_khoa", Tu_khoa)
                para(1) = New SqlParameter("@Den_khoa", Den_khoa)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_ChuyenNganh_DangKySom_ChiTiet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKeSoLieuDuBao_DangKySom_KhoaHoc(ByVal ID_he As Integer, ByVal Tu_khoa As Integer, ByVal Den_khoa As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Tu_khoa", Tu_khoa)
                para(1) = New SqlParameter("@Den_khoa", Den_khoa)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ThongKeSoLieuDuBao_ChuyenNganh_DangKySom_KhoaHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
