'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhHieu_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhHieu_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DanhHieu_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhHieu(ByVal obj As ESSDanhHieu) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Danh_hieu", obj.Danh_hieu)
                para(1) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                para(2) = New SqlParameter("@Den_diem", obj.Den_diem)
                Return Connect.ExecuteSP("STU_DanhHieu_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieu(ByVal obj As ESSDanhHieu, ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_danh_hieu", ID_danh_hieu)
                para(1) = New SqlParameter("@Danh_hieu", obj.Danh_hieu)
                para(2) = New SqlParameter("@Tu_diem", obj.Tu_diem)
                para(3) = New SqlParameter("@Den_diem", obj.Den_diem)
                Return Connect.ExecuteSP("STU_DanhHieu_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieu(ByVal ID_danh_hieu As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_danh_hieu", ID_danh_hieu)
                Return Connect.ExecuteSP("STU_DanhHieu_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

