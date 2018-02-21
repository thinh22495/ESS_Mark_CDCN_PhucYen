'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, September 14, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class LopTinChiGanLopHanhChinh_Bussines
        Private arrLopTinChiGanLopHanhChinh As ArrayList
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer) As DataTable
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.HienThi_ESSLopTinChiGanLopHanhChinh(Ky_dang_ky, ID_lop_hc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Dangky_LopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.Dangky_LopTinChiGanLopHanhChinh(Ky_dang_ky, ID_lop_hc, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HuyDangky_LopTinChiGanLopHanhChinh(ByVal Ky_dang_ky As Integer, ByVal ID_lop_hc As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.HuyDangky_LopTinChiGanLopHanhChinh(Ky_dang_ky, ID_lop_hc, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.ThemMoi_ESSLopTinChiGanLopHanhChinh(ID_lop_tc, ID_lop_hc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.CapNhat_ESSLopTinChiGanLopHanhChinh(ID_lop_tc, ID_lop_hc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLopTinChiGanLopHanhChinh(ByVal ID_lop_tc As Integer, ByVal ID_lop_hc As Integer) As Integer
            Try
                Dim obj As LopTinChiGanLopHanhChinh_DataAccess = New LopTinChiGanLopHanhChinh_DataAccess
                Return obj.Xoa_ESSLopTinChiGanLopHanhChinh(ID_lop_tc, ID_lop_hc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
