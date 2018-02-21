'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, July 26, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachTotNghiep_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachTotNghiep_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachTOTNGHIEP_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachTotNghiep_Nganh2_DanhSach(ByVal mID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", mID_dt)
                Return Connect.SelectTableSP("STU_DanhSachTOTNGHIEP_N2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachChuaTotNghiep_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachCHUATOTNGHIEP_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachChuaTotNghiep_Nganh2_DanhSach(ByVal mID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", mID_dt)
                Return Connect.SelectTableSP("STU_DanhSachCHUATOTNGHIEP_N2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachChungChiSinhVienNo(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("MARK_LoaiChungChiTheoSinhVienNo_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhSachNoKhac(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_NoKhacKhiXetTotNghiep_NoXetTotNghiep", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachTotNghiep(ByVal obj As ESSDanhSachTotNghiep) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", obj.ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@TBCHT10", obj.TBCHT10)
                para(7) = New SqlParameter("@PhanTram_ThiLai", obj.PhanTram_ThiLai)
                para(8) = New SqlParameter("@ID_dt", obj.ID_dt)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachTotNghiep(ByVal obj As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@TBCHT10", obj.TBCHT10)
                para(7) = New SqlParameter("@PhanTram_ThiLai", obj.PhanTram_ThiLai)
                para(8) = New SqlParameter("@ID_dt", obj.ID_dt)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachChuaTotNghiep(ByVal obj As ESSDanhSachTotNghiep) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhSachChuaTotNghiep_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachChuaTotNghiep(ByVal obj As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DanhSachChuaTotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachChuaTotNghiep_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_MonBatBuoc_SV_DanhSach1(ByVal ID_SV As Integer, ByVal ID_dv As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", ID_SV)
                para(1) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("STU_DanhSachTotNghiep_TC_KiemTraTonTai_MonBatBuoc_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function Check_MonBatBuoc_SV(ByVal ID_SV As Integer, ByVal ID_dv As String, ByVal KhongKTra_NhungMon_TN As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", ID_SV)
                para(1) = New SqlParameter("@ID_dv", ID_dv)
                para(2) = New SqlParameter("@Ktra_Mon_TN", KhongKTra_NhungMon_TN)
                para(3) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("Mark_DanhSachTotNghiep_Check_MonBatBuoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Check_TotNghiep_SV_DangKy(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_TOTNGHIEP_DANGKY_CHeck", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_QuyetDinh(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_QD", So_QD)
                para(2) = New SqlParameter("@Ngay_QD", Ngay_QD)
                Return Connect.ExecuteSP("QuyetDinh_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_KHoa(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lock", Lock)
                Return Connect.ExecuteSP("TotNghiep_CapNhat_Lock", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_hieu", So_hieu)
                Return Connect.ExecuteSP("SoHieu_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_vao_so", So_vao_so)
                Return Connect.ExecuteSP("SoVaoSo_TotNghiep_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Mark_TotNghiep_ThongKe() As DataTable
            Try
                Return Connect.SelectTableSP("Mark_TotNghiep_ThongKe")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        
        Public Function Xoa_ESSDanhSachTotNghiep_Nganh2(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_N2_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachChuaTotNghiep_Nganh2(ByVal obj As ESSDanhSachTotNghiep) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhSachChuaTotNghiep_N2_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachChuaTotNghiep_Nganh2(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachChuaTotNghiep_N2_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachTotNghiep_Nganh2(ByVal obj As ESSDanhSachTotNghiep) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_SV", obj.ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@TBCHT10", obj.TBCHT10)
                para(7) = New SqlParameter("@PhanTram_ThiLai", obj.PhanTram_ThiLai)
                para(8) = New SqlParameter("@ID_dt", obj.ID_dt)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_Nganh2_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSachTotNghiep_Nganh2(ByVal obj As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lan_thu", obj.Lan_thu)
                para(2) = New SqlParameter("@So_bang", obj.So_bang)
                para(3) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(4) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(6) = New SqlParameter("@TBCHT10", obj.TBCHT10)
                para(7) = New SqlParameter("@PhanTram_ThiLai", obj.PhanTram_ThiLai)
                para(8) = New SqlParameter("@ID_dt", obj.ID_dt)
                Return Connect.ExecuteSP("STU_DanhSachTotNghiep_Nganh2_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_SoVaoSo_Nganh2(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_vao_so", So_vao_so)
                Return Connect.ExecuteSP("SoVaoSo_TotNghiep_Nganh2_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoHieu_Nganh2(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_hieu", So_hieu)
                Return Connect.ExecuteSP("SoHieu_TotNghiep_Nganh2_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_QuyetDinh_Nganh2(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@So_QD", So_QD)
                para(2) = New SqlParameter("@Ngay_QD", Ngay_QD)
                Return Connect.ExecuteSP("QuyetDinh_TotNghiep_Nganh2_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_KHoa_Nganh2(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Lock", Lock)
                Return Connect.ExecuteSP("TotNghiep_CapNhat_Nganh2_Lock", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_DanhSach_XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("MARK_XETLENLOP_HIENTHI_DANHSACH", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
