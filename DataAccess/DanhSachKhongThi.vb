'Thi�n An ESS
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachKhongThi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachKhongDuDKDuThi_HienThi_DanhSach(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(4) = New SqlParameter("@ID_mon", ID_mon)
                para(5) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachKhongThi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachNoHocPhiMon_HienThi_DanhSach(ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lops As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(4) = New SqlParameter("@ID_mon", ID_mon)
                para(5) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachKhongThi_TC_NoHocPhiMon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ThemMoi_ESSDanhSachKhongThi(ByVal obj As ESSDanhSachKhongThi) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DanhSachKhongThi_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachKhongThi_09(ByVal obj As ESSDanhSachKhongThi) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DanhSachKhongThi_TC_ThemMoi_09", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachKhongThi(ByVal obj As ESSDanhSachKhongThi, ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("MARK_DanhSachKhongThi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachKhongThi(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhSachKhongThi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace
