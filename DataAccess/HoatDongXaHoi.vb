'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, 11 June, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class HoatDongXaHoi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function HienThi_ESSHoatDongXaHoi(Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal ID_lop As Integer = 0) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_lop", ID_lop)
                para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_HoatDongXaHoi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoatDongXaHoiSv(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_HoatDongXaHoi_LoadSV", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoatDongXaHoi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("sp_HoatDongXaHoi_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoatDongXaHoi(ByVal obj As ESSHoatDongXaHoi) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Ngay_thang", obj.Ngay_thang)
                para(4) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(5) = New SqlParameter("@Ket_qua", obj.Ket_qua)
                para(6) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                Return Connect.ExecuteSP("STU_HoatDongXaHoi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoatDongXaHoi(ByVal obj As ESSHoatDongXaHoi) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_hd_xh", obj.ID_hd_xh)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@Ngay_thang", obj.Ngay_thang)
                para(5) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(6) = New SqlParameter("@Ket_qua", obj.Ket_qua)
                para(7) = New SqlParameter("@Diem_thuong", obj.Diem_thuong)
                Return Connect.ExecuteSP("STU_HoatDongXaHoi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoatDongXaHoi(ByVal ID_hd_xh As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_hd_xh", ID_hd_xh)
                Return Connect.ExecuteSP("STU_HoatDongXaHoi_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoatDongXaHoi(ByVal obj As ESSHoatDongXaHoi) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                If Connect.SelectTableSP("STU_HoatDongXaHoi_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

