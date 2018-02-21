'---------------------------------------------------------------------------
' Author : Ð? Van L?c
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, 03 June, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class SuKienNguoiDung_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSSuKienNguoiDung(ByVal obj As ESSSuKienNguoiDung, Optional ByVal Tu_ngay As String = "", Optional ByVal Den_ngay As String = "") As DataTable ', Optional ByVal ID_Phan_he As Integer = 0, Optional ByVal Su_kien As Integer = 0, Optional ByVal UserName As String = "", Optional ByVal Chuc_nang As String = "", Optional ByVal Noi_dung As String = "", Optional ByVal May_tram As String = "") As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_Phan_he", obj.ID_phan_he)
                para(1) = New SqlParameter("@Su_kien", obj.Su_kien)
                para(2) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                para(3) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(4) = New SqlParameter("@May_tram", obj.May_tram)
                para(5) = New SqlParameter("@Tu_ngay", Tu_ngay)
                para(6) = New SqlParameter("@Den_ngay", Den_ngay)
                para(7) = New SqlParameter("@UserName", obj.UserName)
                Return Connect.SelectTableSP("SYS_SuKienNguoiDung_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSSuKienNguoiDung(ByVal obj As ESSSuKienNguoiDung) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_he", obj.ID_phan_he)
                para(1) = New SqlParameter("@Su_kien", obj.Su_kien)
                para(2) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                para(3) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(4) = New SqlParameter("@Thoi_diem", obj.Thoi_diem)
                para(5) = New SqlParameter("@May_tram", obj.May_tram)
                para(6) = New SqlParameter("@UserName", obj.UserName)
                Return Connect.ExecuteSP("SYS_SuKienNguoiDung_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSSuKienNguoiDung(ByVal obj As ESSSuKienNguoiDung, ByVal ID_su_kien As Integer) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_su_kien", ID_su_kien)
                para(1) = New SqlParameter("@ID_phan_he", obj.ID_phan_he)
                para(2) = New SqlParameter("@Su_kien", obj.Su_kien)
                para(3) = New SqlParameter("@Chuc_nang", obj.Chuc_nang)
                para(4) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(5) = New SqlParameter("@Thoi_diem", obj.Thoi_diem)
                para(6) = New SqlParameter("@May_tram", obj.May_tram)
                para(7) = New SqlParameter("@UserName", obj.UserName)
                Return Connect.ExecuteSP("sp_htSuKienNguoiDung_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSSuKienNguoiDung(ByVal ID_su_kien As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_su_kien", ID_su_kien)
                Return Connect.ExecuteSP("sp_htSuKienNguoiDung_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

