'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, September 14, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LopTinChiGanLopHanhChinh_DataAccess

#Region "Initialize"
        Public Sub New()

        End Sub
#End Region
#Region "Functions And Subs"
        Public Function HienThi_ESSLopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                Return Connect.SelectTableSP("PLAN_LopTinChiGanLopHanhChinh_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Dangky_LopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                para(2) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.ExecuteSP("PLAN_LopTinChiGanLopHanhChinh_TC_Dangky", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HuyDangky_LopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                para(2) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.ExecuteSP("PLAN_LopTinChiGanLopHanhChinh_TC_HuyDangky", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                Return Connect.ExecuteSP("PLAN_LopTinChiGanLopHanhChinh_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                Return Connect.ExecuteSP("PLAN_LopTinChiGanLopHanhChinh_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(1) = New SqlParameter("@ID_lop_hc", ID_lop_hc)
                Return Connect.ExecuteSP("PLAN_LopTinChiGanLopHanhChinh_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

