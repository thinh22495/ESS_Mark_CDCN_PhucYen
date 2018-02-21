'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 17, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ChucDanhCanBo_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSChucDanhCanBo(ByVal ID_chuc_danh As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                Return Connect.SelectTableSP("STU_ChucDanh_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChucDanhCanBo_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_ChucDanh_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSChucDanhCanBo(ByVal obj As ESSChucDanhCanBo) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_chuc_danh", obj.Ma_chuc_danh)
                para(1) = New SqlParameter("@Chuc_danh", obj.Chuc_danh)
                Return Connect.ExecuteSP("STU_ChucDanh_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChucDanhCanBo(ByVal obj As ESSChucDanhCanBo, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                para(1) = New SqlParameter("@Ma_chuc_danh", obj.Ma_chuc_danh)
                para(2) = New SqlParameter("@Chuc_danh", obj.Chuc_danh)
                Return Connect.ExecuteSP("STU_ChucDanh_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChucDanhCanBo(ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                Return Connect.ExecuteSP("STU_ChucDanh_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

