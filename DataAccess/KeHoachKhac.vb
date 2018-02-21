'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, December 27, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class KeHoachKhac_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSKeHoachKhac(ByVal ID As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID", ID)
                Return Connect.SelectTableSP("PLAN_KeHoachKhac_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKeHoachKhac_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_KeHoachKhac_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKeHoachKhac_ThongBao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("PLAN_KeHoachKhac_TC_ThongBao_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKeHoachKhac(ByVal obj As ESSKeHoachKhac) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_he", obj.ID_he)
                para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(5) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                para(6) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(7) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(8) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                para(9) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(10) = New SqlParameter("@Hien_thi", obj.Hien_thi)
                Return Connect.ExecuteSP("PLAN_KeHoachKhac_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKeHoachKhac(ByVal obj As ESSKeHoachKhac, ByVal ID As Integer) As Integer
            Try
                Dim para(11) As SqlParameter
                para(0) = New SqlParameter("@ID", ID)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_he", obj.ID_he)
                para(4) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(5) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(6) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                para(7) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(8) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(9) = New SqlParameter("@Den_ngay", obj.Den_ngay)
                para(10) = New SqlParameter("@Ky_hieu", obj.Ky_hieu)
                para(11) = New SqlParameter("@Hien_thi", obj.Hien_thi)
                Return Connect.ExecuteSP("PLAN_KeHoachKhac_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKeHoachKhac(ByVal ID As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID", ID)
                Return Connect.ExecuteSP("PLAN_KeHoachKhac_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KeHoachKhac(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal id_he As Integer, ByVal ky_hieu As String, ByVal tu_ngay As Date, ByVal den_ngay As Date) As Boolean
            Try
                Dim dt As DataTable
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@id_he", id_he)
                para(3) = New SqlParameter("@ky_hieu", ky_hieu)
                para(4) = New SqlParameter("@Tu_ngay", tu_ngay.Date)
                para(5) = New SqlParameter("@Den_ngay", den_ngay.Date)
                dt = Connect.SelectTableSP("PLAN_KeHoachKhac_TC_KiemTraTonTai", para)
                If dt.Rows.Count = 0 Then
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

