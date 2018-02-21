'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, August 21, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DuyetDangKySinhVien_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDuyetDangKySinhVien_DanhSach(ByVal UserName As String, ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("STU_DuyetDangKySinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDuyetDangKySinhVien(ByVal obj As ESSDuyetDangKySinhVien) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Duyet", obj.Duyet)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DuyetDangKySinhVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDuyetDangKySinhVien(ByVal obj As ESSDuyetDangKySinhVien, ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Duyet", obj.Duyet)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DuyetDangKySinhVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DuyetDangKySinhVien(ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                dt = Connect.SelectTableSP("STU_DuyetDangKySinhVien_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_DuyetDangKySinhVien(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_khoa As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                Return Connect.SelectTableSP("STU_DuyetDangKySinhVienThongKe_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienDaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("PLAN_ThongKeSinhVienDaDuocPheDuyet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienKhongDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("PLAN_ThongKeSinhVienKhongDuocPheDuyet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienChuaDuocPheDuyet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("PLAN_ThongKeSinhVienChuaPheDuyet", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

