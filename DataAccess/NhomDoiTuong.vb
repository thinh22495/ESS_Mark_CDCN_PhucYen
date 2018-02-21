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
    Public Class NhomDoiTuong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSNhomDoiTuong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_NhomDoiTuong_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNhomDoiTuong(ByVal ID_nhom_dt As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                Return Connect.SelectTableSP("STU_NhomDoiTuong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNhomDoiTuong(ByVal obj As ESSNhomDoiTuong) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_nhom", obj.Ma_nhom)
                para(1) = New SqlParameter("@Ten_nhom", obj.Ten_nhom)
                Return Connect.ExecuteSP("STU_NhomDoiTuong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNhomDoiTuong(ByVal obj As ESSNhomDoiTuong, ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                para(1) = New SqlParameter("@Ma_nhom", obj.Ma_nhom)
                para(2) = New SqlParameter("@Ten_nhom", obj.Ten_nhom)
                Return Connect.ExecuteSP("STU_NhomDoiTuong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNhomDoiTuong(ByVal ID_nhom_dt As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_nhom_dt", ID_nhom_dt)
                Return Connect.ExecuteSP("STU_NhomDoiTuong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

