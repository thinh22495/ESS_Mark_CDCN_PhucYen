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
    Public Class GiaoVien_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSGiaoVien_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_GiaoVien_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSGiaoVienMonDay_DanhSach(ByVal ID_cb As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.SelectTableSP("PLAN_GiaoVienMonDay_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSGiaoVien(ByVal obj As ESSGiaoVien) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                para(1) = New SqlParameter("@Ten", obj.Ten)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                para(3) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(4) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(6) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                para(7) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                para(8) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                para(9) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                Return Connect.ExecuteSP("PLAN_GiaoVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSGiaoVien(ByVal obj As ESSGiaoVien, ByVal ID_cb As Integer) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                para(1) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                para(2) = New SqlParameter("@Ten", obj.Ten)
                para(3) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                para(4) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(5) = New SqlParameter("@Ngay_sinh", obj.Ngay_sinh)
                para(6) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(7) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                para(8) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                para(9) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                para(10) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                Return Connect.ExecuteSP("PLAN_GiaoVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSGiaoVien(ByVal ID_cb As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.ExecuteSP("PLAN_GiaoVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

