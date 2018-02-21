'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, October 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LoaiChungChiDanhSachMon_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDSSinhVienChungChi(ByVal ID_lops As String) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("MARK_LoaiChungChi_TC_DSSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLoaiChungChiDanhSachMon(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("MARK_LoaiChungChiDanhSachMon_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal id_mon As Integer, ByVal id_dt As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                para(1) = New SqlParameter("@ID_mon", id_mon)
                para(2) = New SqlParameter("@ID_dt", id_dt)
                Connect.ExecuteSP("MARK_LoaiChungChiDanhSachMon_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiChungChiDanhSachMon(ByVal ID_chung_chi As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                Connect.ExecuteSP("MARK_LoaiChungChiDanhSachMon_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChungChiTheoSinhVien(ByVal obj As ESSLoaiChungChiDanhSachMon) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(2) = New SqlParameter("@ID_chung_chi", obj.ID_chung_chi)
                para(3) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@TBCHT", obj.TBCHT)
                Connect.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChungChiTheoSinhVien(ByVal obj As ESSLoaiChungChiDanhSachMon) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(2) = New SqlParameter("@ID_chung_chi", obj.ID_chung_chi)
                para(3) = New SqlParameter("@Lan_xet", obj.Lan_xet)
                Connect.ExecuteSP("MARK_LoaiChungChiTheoSinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_vao_so", So_vao_so)
                Return Connect.ExecuteSP("SoVaoSo_ChungChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ThongTin_ChungChi(ByVal ID_SV As Integer, ByVal Hoi_dong_thi As String, ByVal Tu_ngay As Date, ByVal Den_ngay As Date) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoi_dong_thi", Hoi_dong_thi)
                para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                para(2) = New SqlParameter("@Den_ngay", Den_ngay)
                para(3) = New SqlParameter("@ID_SV", ID_SV)
                Return Connect.ExecuteSP("ThongTin_ChungChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

