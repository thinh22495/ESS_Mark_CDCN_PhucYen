'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, August 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class HocKyDangKy_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHocKyDangKy_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TC_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_HocKyDangKy(ByVal obj As ESSHocKyDangKy) As Boolean
            Try
                Dim dt As DataTable
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Dot", obj.Dot)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                dt = Connect.SelectTableSP("PLAN_HocKyDangKy_TC_KiemTraTonTai", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSHocKyDangKy(ByVal obj As ESSHocKyDangKy) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Dot", obj.Dot)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(4) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                Return Connect.ExecuteSP("PLAN_HocKyDangKy_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocKyDangKy(ByVal obj As ESSHocKyDangKy) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Dot", obj.Dot)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(4) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                Return Connect.ExecuteSP("PLAN_HocKyDangKy_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocKyDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("PLAN_HocKyDangKy_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSHocKyDangKy_DaTonTai(ByVal obj As ESSHocKyDangKy) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Dot", obj.Dot)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.ExecuteSP("PLAN_KyDangKy_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_HocKyDangKy_TonTai(ByVal obj As ESSHocKyDangKy) As Boolean
            Try
                Dim dt As DataTable
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Dot", obj.Dot)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                dt = Connect.SelectTableSP("PLAN_KiemTraMonTinChiTonTai_HienThi_DanhSach", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

