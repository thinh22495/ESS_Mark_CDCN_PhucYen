Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class NoKhacKhiXetTotNghiep_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"

        Public Function DanhSachNoKhacKhiXetTotNghiep_HienThi_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_NoKhacKhiXetTotNghiep_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNoKhacKhiXetTotNghiep(ByVal obj As ESSNoKhacKhiXetTotNghiep) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_NoKhacKhiXetTotNghiep_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoKhacKhiXetTotNghiep(ByVal obj As ESSNoKhacKhiXetTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_NoKhacKhiXetTotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNoKhacKhiXetTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_NoKhacKhiXetTotNghiep_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace
