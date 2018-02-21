'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class MonHoc_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function HienThi_ESSMonHoc(ByVal ID_mon As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_MonHoc_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTaoRangBuoc(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTaoRangBuoc_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTaoNhomTuChon(ByVal ID_mon As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_HienThi_Nhom", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonHoc_He_DanhSach(ByVal ID_he As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("MARK_MonHoc_HienThi_He_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonHoc_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_MonHoc_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonHoc_ChungChi_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("MARK_MonHoc_ChungChi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMonHoc_BoMon_DanhSach(ByVal ID_bm As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_bm", ID_bm)
                Return Connect.SelectTableSP("MARK_MonHoc_HienThi_BoMon_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function ThemMoi_ESSMonHoc(ByVal obj As ESSMonHoc) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(1) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                para(2) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                para(3) = New SqlParameter("@ID_bm", obj.ID_bm)
                para(4) = New SqlParameter("@ID_he", obj.ID_he)
                para(5) = New SqlParameter("@ID_nhom_hp", obj.ID_nhom)
                Return Connect.ExecuteSP("MARK_MonHoc_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMonHoc(ByVal obj As ESSMonHoc, ByVal ID_mon As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(2) = New SqlParameter("@Ten_mon", obj.Ten_mon)
                para(3) = New SqlParameter("@Ten_tieng_anh", obj.Ten_tieng_anh)
                para(4) = New SqlParameter("@ID_bm", obj.ID_bm)
                para(5) = New SqlParameter("@ID_he", obj.ID_he)
                para(6) = New SqlParameter("@ID_nhom_hp", obj.ID_nhom)
                Return Connect.ExecuteSP("MARK_MonHoc_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMonHoc(ByVal ID_mon As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.ExecuteSP("MARK_MonHoc_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function MARK_MonHoc_KiemTraTonTai_ky_hieu(ByVal Ky_hieu As String) As Boolean
            Try
                Dim dt As DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ky_hieu", Ky_hieu)
                dt = Connect.SelectTableSP("MARK_MonHoc_KiemTraTonTai_ky_hieu", para)
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

