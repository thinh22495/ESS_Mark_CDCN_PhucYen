Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class PhongHocKyTucXa_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSPhongKyTucXa_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_PhongKyTucXa_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhongHoc_DanhSachUser(ByVal UserID As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("STU_PhongKyTucXa_HienThi_DanhSach_User", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSPhongKyTucXa(ByVal obj As ESSPhongKyTucXa) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@ID_nha_ktx", obj.ID_nha_ktx)
                para(2) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(3) = New SqlParameter("@So_phong_ktx", obj.So_phong_ktx)
                para(4) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(5) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                Return Connect.ExecuteSP("STU_PhongKyTucXa_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSPhongKyTucXa(ByVal obj As ESSPhongKyTucXa, ByVal ID_phong_ktx As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", obj.ID_co_so)
                para(1) = New SqlParameter("@ID_phong_ktx", ID_phong_ktx)
                para(2) = New SqlParameter("@ID_nha_ktx", obj.ID_nha_ktx)
                para(3) = New SqlParameter("@ID_tang", obj.ID_tang)
                para(4) = New SqlParameter("@So_phong_ktx", obj.So_phong_ktx)
                para(5) = New SqlParameter("@Suc_chua", obj.Suc_chua)
                para(6) = New SqlParameter("@Thiet_bi", obj.Thiet_bi)
                Return Connect.ExecuteSP("STU_PhongKyTucXa_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSPhongKyTucXa(ByVal ID_phong_ktx As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_phong_ktx", ID_phong_ktx)
                Return Connect.ExecuteSP("STU_PhongKyTucXa_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_TenPhongKyTucXa(ByVal ID_co_so As Integer, ByVal ID_nha As Integer, ByVal ID_tang As Integer, ByVal So_phong As String) As Boolean
            Try
                Dim dt As DataTable
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_co_so", ID_co_so)
                para(1) = New SqlParameter("@ID_nha_ktx", ID_nha)
                para(2) = New SqlParameter("@ID_tang", ID_tang)
                para(3) = New SqlParameter("@So_phong_ktx", So_phong)
                dt = Connect.SelectTableSP("STU_PhongKyTucXa_KiemTraTonTai_Ten", para)
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


