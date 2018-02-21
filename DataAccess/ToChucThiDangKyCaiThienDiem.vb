
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ToChucThiDangKyCaiThienDiem_DataAccess
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhsachDangKyCaiThienDiem(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Hinh_thuc As Integer) As DataTable
            Dim para(3) As SqlParameter
            para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
            para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
            para(2) = New SqlParameter("@ID_mon", ID_mon)
            para(3) = New SqlParameter("@Hinh_thuc", Hinh_thuc)
            Return Connect.SelectTableSP("MARK_ToChucThiDangKyCaiThienDiem_TC_TheoMon_HienThi", para)
        End Function


        Public Function ThemMoi_ESSToChucThiDangKyCaiThienDiem(ByVal obj As ESSToChucThiDangKyCaiThienDiem) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(4) = New SqlParameter("@Duyet", obj.Duyet)
                para(5) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                Return Connect.ExecuteSP("MARK_ToChucThiDangKyCaiThienDiem_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSToChucThiDangKyCaiThienDiem(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.ExecuteSP("MARK_ToChucThiDangKyCaiThienDiem_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSToChucThiDangKyCaiThienDiem(ByVal obj As ESSToChucThiDangKyCaiThienDiem) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(4) = New SqlParameter("@Duyet", obj.Duyet)
                para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(6) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                Return Connect.ExecuteSP("MARK_ToChucThiDangKyCaiThienDiem_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region
    End Class
End Namespace


