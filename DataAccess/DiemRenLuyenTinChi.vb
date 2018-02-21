'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, November 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DiemRenLuyenTinChi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDiemRenLuyenTinChi(ByVal ID_diem_rl As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                Return Connect.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemRenLuyenTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                Return Connect.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemRenLuyenTinChi(ByVal obj As ESSDiemRenLuyenTinChi) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(4) = New SqlParameter("@Diem", obj.Diem)
                Return Connect.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemRenLuyenTinChi(ByVal obj As ESSDiemRenLuyenTinChi) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_mon_tc", obj.ID_mon_tc)
                para(4) = New SqlParameter("@Diem", obj.Diem)
                Return Connect.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemRenLuyenTinChi(ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                Return Connect.ExecuteSP("MARK_DiemRenLuyenTinChi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemRenLuyenTinChi(ByVal obj As ESSDiemRenLuyenTinChi) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                If Connect.SelectTableSP("MARK_DiemRenLuyenTinChi_TC_KiemTraTonTai", para).Rows.Count > 0 Then
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

