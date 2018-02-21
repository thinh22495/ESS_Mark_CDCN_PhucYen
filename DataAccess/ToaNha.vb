'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ToaNha_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSToaNha_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_ToaNha_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSToaNha(ByVal obj As ESSToaNha) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@Ma_nha", obj.Ma_nha)
                para(2) = New SqlParameter("@Ten_nha", obj.Ten_nha)
                Return Connect.ExecuteSP("PLAN_ToaNha_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToaNha(ByVal ID_nha As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_nha", ID_nha)
                Return Connect.ExecuteSP("PLAN_ToaNha_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

