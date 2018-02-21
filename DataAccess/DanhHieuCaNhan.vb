'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, July 11, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhHieuThiDuaCaNhan_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDSSV_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienQuocTich_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSXepLoaiHocTap() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepLoaiHocTap_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSXLRenLuyen() As DataTable
            Try
                Return Connect.SelectTableSP("STU_XLRenLuyen_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhHieuThiDuaCaNhan_DanhSach(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return Connect.SelectTableSP("STU_DanhHieuThiDuaCaNhan_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhHieuThiDuaCaNhan(ByVal obj As ESSDanhHieuThiDuaCaNhan) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@DRL", obj.DRL)
                para(5) = New SqlParameter("@TBCMR", obj.TBCMR)
                para(6) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaCaNhan_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieuThiDuaCaNhan(ByVal obj As ESSDanhHieuThiDuaCaNhan) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@DRL", obj.DRL)
                para(5) = New SqlParameter("@TBCMR", obj.TBCMR)
                para(6) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaCaNhan_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaCaNhan_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                If Connect.SelectTableSP("STU_DanhHieuThiDuaCaNhan_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhHieuThiDua(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_danh_hieu As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(4) = New SqlParameter("@ID_danh_hieu", ID_danh_hieu)
                Return Connect.SelectTableSP("STU_DanhHieuThiDuaCaNhan_BaoCao", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

