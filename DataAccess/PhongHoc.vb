'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class PhongHoc_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSPhongHoc_ToChucThi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_PhongHoc_ToChucThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhongHoc_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_PhongHoc_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhongHoc_DanhSach_User(ByVal UserID As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("sp_PhongHoc_HienThi_DanhSach_User", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSPhongHoc(ByVal obj As ESSPhongHoc) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@ID_nha", obj.ID_nha)
                para(2) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(3) = New SqlParameter("@So_phong", obj.So_phong)
                para(4) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(5) = New SqlParameter("@So_sv", obj.So_sv)
                para(6) = New SqlParameter("@ID_loai_phong", obj.ID_loai_phong)
                para(7) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                para(8) = New SqlParameter("@Khong_ToChucThi", obj.Khong_ToChucThi)
                Return Connect.ExecuteSP("PLAN_PhongHoc_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSPhongHoc(ByVal obj As ESSPhongHoc, ByVal ID_phong As Integer) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@ID_phong", ID_phong)
                para(2) = New SqlParameter("@ID_nha", obj.ID_nha)
                para(3) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(4) = New SqlParameter("@So_phong", obj.So_phong)
                para(5) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(6) = New SqlParameter("@So_sv", obj.So_sv)
                para(7) = New SqlParameter("@ID_loai_phong", obj.ID_loai_phong)
                para(8) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                para(9) = New SqlParameter("@Khong_ToChucThi", obj.Khong_ToChucThi)
                Return Connect.ExecuteSP("PLAN_PhongHoc_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSPhongHoc(ByVal ID_phong As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_phong", ID_phong)
                Return Connect.ExecuteSP("PLAN_PhongHoc_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_TenPhongHoc(ByVal ID_co_so As Integer, ByVal ID_nha As Integer, ByVal ID_tang As Integer, ByVal So_phong As String) As Boolean
            Try
                Dim dt As DataTable
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", ID_co_so)
                para(1) = New SqlParameter("@ID_nha", ID_nha)
                para(2) = New SqlParameter("@ID_tang", ID_tang)
                para(3) = New SqlParameter("@So_phong", So_phong)
                dt = Connect.SelectTableSP("PLAN_PhongHoc_KiemTraTonTai_Ten", para)
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

