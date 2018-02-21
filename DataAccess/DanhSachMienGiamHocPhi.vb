'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachMienGiamHocPhi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load các loại giấy tờ cần nộp
        Public Function HienThi_ESSGiayToCanNop() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuongGiayTo_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachMienGiamHocPhi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachMienGiamHocPhi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachMienGiamHocPhi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_DanhSachMienGiamHocPhiSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_DanhSachMienGiamHocPhi(ByVal obj As ESSDanhSachMienGiamHocPhi) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                If Connect.SelectTableSP("STU_DanhSachMienGiamHocPhi_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachMienGiamHocPhi(ByVal obj As ESSDanhSachMienGiamHocPhi) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@Phan_tram", obj.Phan_tram)
                para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachMienGiamHocPhi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachMienGiamHocPhi(ByVal obj As ESSDanhSachMienGiamHocPhi) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Phan_tram", obj.Phan_tram)
                Return Connect.ExecuteSP("STU_DanhSachMienGiamHocPhi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachMienGiamHocPhi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhSachMienGiamHocPhi_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

