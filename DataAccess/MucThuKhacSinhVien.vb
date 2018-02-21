'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class MucThuKhacSinhVien_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSMucThuKhacSinhVien_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("ACC_MucThuKhacSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSMucThuKhacSinhVien(ByVal obj As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                para(4) = New SqlParameter("@So_tien", obj.So_tien)
                para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("ACC_MucThuKhacSinhVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMucThuKhacSinhVien(ByVal obj As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                para(4) = New SqlParameter("@So_tien", obj.So_tien)
                para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("ACC_MucThuKhacSinhVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", objMucThuKhacSinhVien.ID_sv)
                para(3) = New SqlParameter("@ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                Return Connect.ExecuteSP("ACC_MucThuKhacSinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MucThuKhacSinhVien(ByVal objMucThuKhacSinhVien As ESSMucThuKhacSinhVien) As Boolean
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", objMucThuKhacSinhVien.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", objMucThuKhacSinhVien.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", objMucThuKhacSinhVien.ID_sv)
                para(3) = New SqlParameter("@ID_thu_chi", objMucThuKhacSinhVien.ID_thu_chi)
                If Connect.SelectTableSP("ACC_MucThuKhacSinhVien_KiemTraTonTai", para).Rows.Count > 0 Then
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

