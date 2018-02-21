'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, June 21, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class BaoCaoTieuDe_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSBaoCaoTieuDe(ByVal ID_dv As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("SYS_BaoCaoTieuDe_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSBaoCaoTieuDe(ByVal ID_dv As String, ByVal UserID As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("SYS_BaoCaoTieuDe_ByUser_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBaoCaoTieuDe(ByVal obj As ESSBaoCaoTieuDe) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@Tieu_de_ten_bo", obj.Tieu_de_ten_bo)
                para(1) = New SqlParameter("@Tieu_de_Ten_truong", obj.Tieu_de_Ten_truong)
                para(2) = New SqlParameter("@Tieu_de_chuc_danh1", obj.Tieu_de_chuc_danh1)
                para(3) = New SqlParameter("@Tieu_de_chuc_danh2", obj.Tieu_de_chuc_danh2)
                para(4) = New SqlParameter("@Tieu_de_chuc_danh3", obj.Tieu_de_chuc_danh3)
                para(5) = New SqlParameter("@Tieu_de_chuc_danh4", obj.Tieu_de_chuc_danh4)
                para(6) = New SqlParameter("@Tieu_de_nguoi_ky1", obj.Tieu_de_nguoi_ky1)
                para(7) = New SqlParameter("@Tieu_de_nguoi_ky2", obj.Tieu_de_nguoi_ky2)
                para(8) = New SqlParameter("@Tieu_de_nguoi_ky3", obj.Tieu_de_nguoi_ky3)
                para(9) = New SqlParameter("@Tieu_de_nguoi_ky4", obj.Tieu_de_nguoi_ky4)
                para(10) = New SqlParameter("@Tieu_de_noi_ky", obj.Tieu_de_noi_ky)
                Return Connect.ExecuteSP("SYS_BaoCaoTieuDe_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBaoCaoTieuDe(ByVal obj As ESSBaoCaoTieuDe, ByVal ID_dv As String) As Integer
            Try
                Dim para(11) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@Tieu_de_ten_bo", obj.Tieu_de_ten_bo)
                para(2) = New SqlParameter("@Tieu_de_Ten_truong", obj.Tieu_de_Ten_truong)
                para(3) = New SqlParameter("@Tieu_de_chuc_danh1", obj.Tieu_de_chuc_danh1)
                para(4) = New SqlParameter("@Tieu_de_chuc_danh2", obj.Tieu_de_chuc_danh2)
                para(5) = New SqlParameter("@Tieu_de_chuc_danh3", obj.Tieu_de_chuc_danh3)
                para(6) = New SqlParameter("@Tieu_de_chuc_danh4", obj.Tieu_de_chuc_danh4)
                para(7) = New SqlParameter("@Tieu_de_nguoi_ky1", obj.Tieu_de_nguoi_ky1)
                para(8) = New SqlParameter("@Tieu_de_nguoi_ky2", obj.Tieu_de_nguoi_ky2)
                para(9) = New SqlParameter("@Tieu_de_nguoi_ky3", obj.Tieu_de_nguoi_ky3)
                para(10) = New SqlParameter("@Tieu_de_nguoi_ky4", obj.Tieu_de_nguoi_ky4)
                para(11) = New SqlParameter("@Tieu_de_noi_ky", obj.Tieu_de_noi_ky)
                Return Connect.ExecuteSP("SYS_BaoCaoTieuDe_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBaoCaoTieuDe(ByVal ID_dv As String) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.ExecuteSP("SYS_BaoCaoTieuDe_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BaoCaoTieuDe(ByVal ID_dv As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.ExecuteScalar("SYS_BaoCaoTieuDe_KiemTraTonTai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

