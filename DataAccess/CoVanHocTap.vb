Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class CoVanHocTap_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function DanhSachSVCoVanHocTap_HienThi_DanhSach(ByVal UserName As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("STU_DanhSachCoVanSV_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachSVCoVanHocTap(ByVal obj As ESSCoVanHocTap) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(1) = New SqlParameter("@UserName", obj.UserName)
                Return Connect.ExecuteSP("SYS_NguoiDungCoVanHocTap_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachSVCoVanHocTap(ByVal obj As ESSCoVanHocTap) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserName", obj.UserName)
                para(1) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                Return Connect.ExecuteSP("SYS_NguoiDungCoVanHocTap_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachSVCoVanHocTap(ByVal Ma_sv As String, ByVal UserName As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                para(1) = New SqlParameter("@Ma_sv", Ma_sv)
                Return Connect.ExecuteSP("SYS_NguoiDungCoVanHocTap_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace
