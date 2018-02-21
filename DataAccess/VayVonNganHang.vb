Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class VayVonNganHang_DataAccess
        Private arrVayVonNganHang As New ArrayList
        Private dtSinhVienVayVon As DataTable

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region
#Region "Functions And Subs"

        Public Function GetMaxID_svVayVonNganHang() As Integer
            Try
                Return Connect.ExecuteScalar("STU_VayVonNganHang_GetMaxID")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSSinhVienVayVonNganHang(ByVal dsID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_SinhVienVayVonNganHang_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSSinhVienVayVonNganHang(ByVal ID_vay_von As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_vay_von", ID_vay_von)
                Return Connect.ExecuteSP("STU_SinhVienVayVonNganHang_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSSinhVienVayVonNganHang(ByVal obj As ESSVayVonNganHang, ByVal ID_vay_von As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_vay_von", ID_vay_von)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@ID_Ngan_hang", obj.ID_Ngan_hang)
                para(5) = New SqlParameter("@Ngay_vay", obj.Ngay_vay)
                para(6) = New SqlParameter("@So_tien", obj.So_tien)
                Return Connect.ExecuteSP("STU_SinhVienVayVonNganHang_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSSinhVienVayVonNganHang(ByVal obj As ESSVayVonNganHang) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_Ngan_hang", obj.ID_Ngan_hang)
                para(4) = New SqlParameter("@Ngay_vay", obj.Ngay_vay)
                para(5) = New SqlParameter("@So_tien", obj.So_tien)
                Return Connect.ExecuteSP("STU_SinhVienVayVonNganHang_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_SinhVienVayVonNganHang(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                If Connect.SelectTableSP("STU_SinhVienVayVonNganHang_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region


    End Class
End Namespace

