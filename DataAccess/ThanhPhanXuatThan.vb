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
    Public Class ThanhPhanXuatThan_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function HienThi_ESSThanhPhanXuatThan() As DataTable
            Try
                Return Connect.SelectTableSP("STU_ThanhPhanXuatThan_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSThanhPhanXuatThan(ByVal obj As ESSThanhPhanXuatThan) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ten_thanh_phan", obj.Ten_thanh_phan)
                Return Connect.ExecuteSP("STU_ThanhPhanXuatThan_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSThanhPhanXuatThan(ByVal obj As ESSThanhPhanXuatThan) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_thanh_phan", obj.ID_thanh_phan)
                para(1) = New SqlParameter("@Ten_thanh_phan", obj.Ten_thanh_phan)
                Return Connect.ExecuteSP("STU_ThanhPhanXuatThan_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSThanhPhanXuatThan(ByVal obj As ESSThanhPhanXuatThan) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_tinh", obj.ID_thanh_phan)
                Return Connect.ExecuteSP("STU_Tinh_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

