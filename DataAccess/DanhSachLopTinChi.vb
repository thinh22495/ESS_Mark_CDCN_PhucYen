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
    Public Class DanhSachSinhVienLopTinChi_DataAccess

#Region "Initialize"
        Public Sub New()

        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach_All(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienLopTinChi_HienThi_DanhSach_ChuaVaDaDuyet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach_All(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal UserName As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienLopTinChi_HienThi_DanhSach_ChuaVaDaDuyet_USER", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienLopTinChi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal UserName As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienLopTinChi_HienThi_DanhSach_USER", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachSinhVienLopTinChi_HuyRut_HienThi_DanhSach(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienLopTinChi_HuyRut_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi(ByVal obj As ESSDanhSachLopTinChi) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", obj.ID_lop_tc)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Hoc_lai", obj.Hoc_lai)
                para(3) = New SqlParameter("@Huy_dang_ky", obj.Huy_dang_ky)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(5) = New SqlParameter("@Rut_bot_hoc_phan", obj.Rut_bot_hoc_phan)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi_Nganh2(ByVal obj As ESSDanhSachLopTinChi) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", obj.ID_lop_tc)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Hoc_lai", obj.Hoc_lai)
                para(3) = New SqlParameter("@Huy_dang_ky", obj.Huy_dang_ky)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(5) = New SqlParameter("@Rut_bot_hoc_phan", obj.Rut_bot_hoc_phan)
                para(6) = New SqlParameter("@Chuyen_nganh2", obj.Chuyen_nganh2)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_ThemMoi_Nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi_Import(ByVal obj As ESSDanhSachLopTinChi) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", obj.ID_lop_tc)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Hoc_lai", obj.Hoc_lai)
                para(3) = New SqlParameter("@Huy_dang_ky", obj.Huy_dang_ky)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(5) = New SqlParameter("@Rut_bot_hoc_phan", obj.Rut_bot_hoc_phan)
                para(6) = New SqlParameter("@Chuyen_nganh2", obj.Chuyen_nganh2)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_ThemMoi_Import", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachLopTinChi(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal Duyet As Boolean) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(2) = New SqlParameter("@Duyet", Duyet)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChi_SinhVien(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Rut_huy As Boolean) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@Rut_bot_hoc_phan", Rut_huy)
                Return Connect.ExecuteSP("PLAN_LopTinChi_SinhVien_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChi_Chuyen(ByVal ID_sv As Integer, ByVal ID_lop_tc_tu As Integer, ByVal ID_lop_tc_den As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop_tc_tu", ID_lop_tc_tu)
                para(2) = New SqlParameter("@ID_lop_tc_den", ID_lop_tc_den)
                Return Connect.ExecuteSP("PLAN_LopTinChi_TC_Chuyen_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachLopTinChi(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@dsKy_dang_ky", dsKy_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachLopTinChi_Nganh1(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@dsKy_dang_ky", dsKy_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_Xoa_Nganh1", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachLopTinChi_Nganh2(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@dsKy_dang_ky", dsKy_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_Xoa_Nganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachLopTinChi_Mon(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_Mon_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDuyetDK(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_CapNhat_DuyetDK", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDuyetDK_ChoNhieu(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Id_khoa As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_CapNhat_DuyetDK_ChoNhieu", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSHuyDuyetDK_ChoNhieu(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Id_khoa As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Id_khoa", Id_khoa)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("STU_DanhSachLopTinChi_CapNhat_HuyDuyetDK_ChoNhieu", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function ThongTnLopTInChi_Select(ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("PLAN_ThongTnLopTInChi_Chon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSLopTinChi_SinhVien_Duyet(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Duyet As Boolean) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@Duyet", Duyet)
                Return Connect.ExecuteSP("PLAN_LopTinChi_SinhVien_DUYET", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachThiLai_ToChucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("Mark_ToChucThi_ThiLai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

