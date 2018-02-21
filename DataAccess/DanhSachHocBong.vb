'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, August 09, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachHocBong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHocBongSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_HocBongSinhVien_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachHocBong_DanhSach(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachHocBong_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDoiTuongHocBong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuongHocBong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachTroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachTroCap_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachHocBong(ByVal obj As ESSDanhSachHocBong) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", obj.ID_phan_bo)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                para(4) = New SqlParameter("@HB_CS", obj.HB_CS)
                Return Connect.ExecuteSP("STU_DanhSachHocBong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachHocBong(ByVal obj As ESSDanhSachHocBong, ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                para(4) = New SqlParameter("@HB_CS", obj.HB_CS)
                Return Connect.ExecuteSP("STU_DanhSachHocBong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachHocBong(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                Return Connect.ExecuteSP("STU_DanhSachHocBong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachHocBong_SinhVien(ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachHocBong_SinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

