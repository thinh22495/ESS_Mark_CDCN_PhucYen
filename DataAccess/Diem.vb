'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, May 04, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class Diem_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region
#Region "Functions And Subs"
        Public Function HienThi_ESSXepLoaiHocTap_thangdiem10() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepLoaiHocTapThangdiem10_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSThanhPhanMon() As DataTable
            Try
                Return Connect.SelectTable("MARK_ThanhPhanMon_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSThanhPhanMon(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lops", ID_lops)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                para(4) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_ThanhPhanMon_TCDiem_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSThanhPhanMon_TinChi(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As String, ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(3) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(4) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_ThanhPhanMon_TCTinChiDiem_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSThanhPhanMon_TinChi_New(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As String, ByVal sID_lop_tc As String) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lop_tc", sID_lop_tc)
                para(3) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(4) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_ThanhPhanMon_TCTinChiDiem_New_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDiemThanhPhan(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_DiemThanhPhan_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiem_DanhSach(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_Diem_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiem_TongHop_DanhSach(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0, Optional ByVal ID_dt As Integer = 0) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                para(6) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("MARK_DiemTongHop_TC_HienThi_DanhSach_Lin", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiem_TongHopTinChi_DanhSach(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_lop_tc As Integer, ByVal ID_mon_tc As Integer) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(4) = New SqlParameter("@ID_mon_tc", ID_mon_tc)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemTinChiTongHop_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhongDuDKDuThiDiemTP_DanhSach(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_KhongDuDKDuThiDiemTPTongHop_TC_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemThi_DanhSach(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemThi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemThanhPhan_DanhSach(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                para(4) = New SqlParameter("@dsID_sv", dsID_sv)
                para(5) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemThanhPhan_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemThi(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_DiemThi_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemQuyDoi() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_DiemQuyDoi_TC_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSXepLoaiHocTap() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepLoaiHocTap_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSXepLoaiChungChi() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepLoaiChungChi_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSXepHangHocLuc() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepHangHocLuc_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSXepHangNamDaoTao() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepHangNamDaoTao_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Get_KyTichLuy(ByVal ID_sv As Long) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_DanhSachNganh2_GetKy_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSXepHangTotNghiep() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_XepHangTotNghiep_TC_HienThi_DanhSach_09")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDiem(ByVal obj As ESSDiem) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", obj.ID_dv)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(4) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.SelectTableSP("MARK_Diem_TC_ThemMoi", para).Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Khi chuyen mon tu chuong trinh dao tao nay sang CTDT khac; update lai diem
        Public Function CheckExist_DiemChuyenKy(ByVal obj As ESSDiem) As Integer
            Try
                Dim para(2) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_dv", obj.ID_dv)
                dt = Connect.SelectTableSP("MARK_DiemChuyenKy_TC_KiemTraTonTai", para)
                Return dt.Rows.Count
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemChuyenKy(ByVal obj As ESSDiem) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", obj.ID_dv)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(3) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(4) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.SelectTableSP("MARK_DiemChuyenKy_TC_CapNhat", para).Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiem(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_mon", ID_mon)
                para(3) = New SqlParameter("@ID_dt", ID_dt)
                dt = Connect.SelectTableSP("MARK_Diem_TC_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return CType(dt.Rows(0)("ID_diem").ToString, Integer)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiem(ByVal obj As ESSDiem, ByVal ID_diem As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@ID_dv", obj.ID_dv)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(4) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(5) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(6) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.ExecuteSP("MARK_Diem_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiem(ByVal ID_diem As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                Return Connect.ExecuteSP("MARK_Diem_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemThi(ByVal ID_diem As Integer, ByVal obj As ESSDiemThi) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                para(2) = New SqlParameter("@Diem_thi", obj.Diem_thi)
                para(3) = New SqlParameter("@Diem_chu", obj.Diem_chu)
                para(4) = New SqlParameter("@Hash_code", obj.Hash_code)
                para(5) = New SqlParameter("@Locked", obj.Locked)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(7) = New SqlParameter("@TBCMH", obj.TBCMH)
                para(8) = New SqlParameter("@Hoc_ky_thi", obj.Hoc_ky_thi)
                para(9) = New SqlParameter("@Nam_hoc_thi", obj.Nam_hoc_thi)
                Return Connect.ExecuteSP("MARK_DiemThi_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThi(ByVal obj As ESSDiemThi, ByVal ID_diem As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Diem_thi", obj.Diem_thi)
                para(3) = New SqlParameter("@Diem_chu", obj.Diem_chu)
                para(4) = New SqlParameter("@Hash_code", obj.Hash_code)
                para(5) = New SqlParameter("@Locked", obj.Locked)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(7) = New SqlParameter("@TBCMH", obj.TBCMH)
                para(8) = New SqlParameter("@Hoc_ky_thi", obj.Hoc_ky_thi)
                para(9) = New SqlParameter("@Nam_hoc_thi", obj.Nam_hoc_thi)
                Return Connect.ExecuteSP("MARK_DiemThi_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThiLock(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThiLock_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThiLock_ChuanHoa(ByVal ID_diem As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_thi As String, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Hoc_ky_thi", Hoc_ky_thi)
                para(3) = New SqlParameter("@Nam_hoc_thi", Nam_hoc_thi)
                para(4) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThiLock_TC_CapNhat_ChuanHoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LockDiem(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThiLock_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function Lock_UnLock_Diem(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@Lan_thi", Lan_thi)
                para(3) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemLock_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function UnLockDiem(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThiLock_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemThi(ByVal ID_diem As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_thi As String, ByVal Lan_thi As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_thi", Hoc_ky_thi)
                para(2) = New SqlParameter("@Nam_hoc_thi", Nam_hoc_thi)
                para(3) = New SqlParameter("@Lan_thi", Lan_thi)
                Return Connect.ExecuteSP("MARK_DiemThi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemThi(ByVal ID_diem As Integer, ByVal Lan_thi As Integer, ByVal Hoc_ky_Thi As Integer, ByVal Nam_hoc_thi As String) As Integer
            Try
                Dim para(3) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Lan_thi", Lan_thi)
                para(2) = New SqlParameter("@Hoc_ky_Thi", Hoc_ky_Thi)
                para(3) = New SqlParameter("@Nam_hoc_thi", Nam_hoc_thi)
                dt = Connect.SelectTableSP("MARK_DiemThi_TC_KiemTraTonTai", para)
                Return dt.Rows.Count
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(3) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                para(2) = New SqlParameter("@Hoc_ky_TP", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc_TP", Nam_hoc)
                dt = Connect.SelectTableSP("MARK_DiemThanhPhan_TC_KiemTraTonTai", para)
                Return dt.Rows.Count
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemThanhPhan(ByVal ID_diem As Integer, ByVal obj As ESSDiemThanhPhan) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@ID_thanh_phan", obj.ID_thanh_phan)
                para(2) = New SqlParameter("@Diem", obj.Diem)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(4) = New SqlParameter("@Ty_le", obj.Ty_le)
                para(5) = New SqlParameter("@Hash_code", obj.Hash_code)
                para(6) = New SqlParameter("@Locked_tp", obj.Locked)
                para(7) = New SqlParameter("@Hoc_ky_TP", obj.Hoc_ky_TP)
                para(8) = New SqlParameter("@Nam_hoc_TP", obj.Nam_hoc_TP)
                para(9) = New SqlParameter("@He_so", obj.He_so)
                para(10) = New SqlParameter("@Nhom", obj.Nhom)
                Return Connect.ExecuteSP("MARK_DiemThanhPhan_TC_ThemMoi_", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhan(ByVal obj As ESSDiemThanhPhan, ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                para(2) = New SqlParameter("@Diem", obj.Diem)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(4) = New SqlParameter("@Ty_le", obj.Ty_le)
                para(5) = New SqlParameter("@Hash_code", obj.Hash_code)
                para(6) = New SqlParameter("@Locked_tp", obj.Locked)
                para(7) = New SqlParameter("@Hoc_ky_TP", obj.Hoc_ky_TP)
                para(8) = New SqlParameter("@Nam_hoc_TP", obj.Nam_hoc_TP)
                para(9) = New SqlParameter("@He_so", obj.He_so)
                para(10) = New SqlParameter("@Nhom", obj.Nhom)
                Return Connect.ExecuteSP("MARK_DiemThanhPhan_TC_CapNhat_", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhanLock(ByVal ID_diem As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThanhPhan_TC_Lock_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhanLock_TP(ByVal ID_diem As Integer, ByVal Hoc_ky_tp As Integer, ByVal Nam_hoc_tp As String, ByVal Locked As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_tp", Hoc_ky_tp)
                para(2) = New SqlParameter("@Nam_hoc_tp", Nam_hoc_tp)
                para(3) = New SqlParameter("@Locked", Locked)
                Return Connect.ExecuteSP("MARK_DiemThanhPhan_TC_Lock_CapNhat_TP", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Hoc_ky_TP As Integer, ByVal Nam_hoc_TP As String) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                para(2) = New SqlParameter("@Hoc_ky_TP", Hoc_ky_TP)
                para(3) = New SqlParameter("@Nam_hoc_TP", Nam_hoc_TP)
                Return Connect.ExecuteSP("MARK_DiemThanhPhan_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSinhVienInfor_DiemExcel(ByVal ID_mon As Integer, ByVal Ma_sv As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("STU_GetSinhVienInfor", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDiemThanhPhanSinhVien_DiemExcel(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_thanh_phan As Integer, ByVal ID_dv As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_thanh_phan", ID_thanh_phan)
                para(3) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_DiemThanhPhan_TC_Excel_GetDiemSinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDiemSinhVien_DiemExcel(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dv As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_Diem_TC_Excel_GetDiemSinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_DT2_DiemExcel(ByVal ID_mon As Integer, ByVal Ma_sv As String) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", Ma_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)

                Dim dt As DataTable = Connect.SelectTableSP("PLAN_GetID_DT2", para)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item("ID_dt")
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckMucKyLuat_HaLoaiTotNghiep(ByVal ID_sv As Integer, ByVal Muc_xu_ly As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Muc_xu_ly", Muc_xu_ly)

                Dim dt As DataTable = Connect.SelectTableSP("STU_MucKyLuat_KiemTraTonTai_HaLoaiTotNghiep", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoaLoaiChungChi_DSMon(ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_chung_chi", ID_chung_chi)
                Return Connect.SelectTableSP("MARK_LoaiChungChi_TC_DSMonChungChi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemKyHieu_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_DiemKyHieu_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhanLoaiKetQuaHocTap(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_PhanLoaiKetQuaHocTap_Lop_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTongHopThiLai_DanhSach(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("MARK_TongHopThiLai_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemTP(ByVal ID_diem As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                Return Connect.SelectTableSP("MARK_DiemThanhPhan_TC_Excel_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function SoTinChi_DangKy_TheoKy(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_SOTINCHI_SINHVIEN_HOCKY", para)
                If dt.Rows.Count > 0 Then
                    Return IIf(IsDBNull(dt.Rows(0)("So_tin_chi")), 0, dt.Rows(0)("So_tin_chi"))
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#Region "Diem nganh hoc thu 2"

#End Region
        Public Function HienThi_ThanhPhanMon_NganhHoc2(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_dt As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                para(4) = New SqlParameter("@ID_dv", ID_dv)
                Return Connect.SelectTableSP("MARK_ThanhPhanMonDiem_NganhHoc2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_Diem_TongHop_NganhHoc2(ByVal ID_dv As String, ByVal ID_dt As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_dv", ID_dv)
                para(3) = New SqlParameter("@ID_dt", ID_dt)
                para(4) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemTongHop_NganhHoc2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_DangKy_TheoKy(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Dim dt As DataTable = Connect.SelectTableSP("MARK_DANGKY_SINHVIEN_HOCKY_DUYET", para)
                If dt.Rows.Count > 0 Then
                    If dt.Rows(0)("Huy_dang_ky") = 0 And dt.Rows(0)("Rut_bot_hoc_phan") = 0 And dt.Rows(0)("Duyet") = 1 Then
                        Return 1
                    Else
                        Return 0
                    End If
                Else
                    Return 1
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Update_Diem_ID_dt(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("MARK_Diem_ID_dt_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Check_HocPhan_TuongDuong(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_mon", ID_mon)
                Dim dt As DataTable = Connect.SelectTableSP("MARK_HocPhanTuongDuong_Check", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_DiemDanh(ByVal ID_diem As Integer, ByVal obj As DiemDanh) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_DD", obj.Hoc_ky_DD)
                para(2) = New SqlParameter("@Nam_hoc_DD", obj.Nam_hoc_DD)
                para(3) = New SqlParameter("@So_tiet_nghi_co_phep", obj.So_tiet_nghi_co_phep)
                para(4) = New SqlParameter("@So_tiet_nghi_khong_phep", obj.So_tiet_nghi_khong_phep)
                para(5) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("Mark_DiemDanh_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_DiemDanh(ByVal obj As DiemDanh, ByVal ID_diem As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_DD", obj.Hoc_ky_DD)
                para(2) = New SqlParameter("@Nam_hoc_DD", obj.Nam_hoc_DD)
                para(3) = New SqlParameter("@So_tiet_nghi_co_phep", obj.So_tiet_nghi_co_phep)
                para(4) = New SqlParameter("@So_tiet_nghi_khong_phep", obj.So_tiet_nghi_khong_phep)
                para(5) = New SqlParameter("@Thieu_bai_thuc_hanh", obj.Thieu_bai_thuc_hanh)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("Mark_DiemDanh_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_DiemDanh(ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_DD", Hoc_ky_DD)
                para(2) = New SqlParameter("@Nam_hoc_DD", Nam_hoc_DD)
                Return Connect.ExecuteSP("Mark_DiemDanh_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTraTonTai_DiemDanh(ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            Try
                Dim para(2) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_diem", ID_diem)
                para(1) = New SqlParameter("@Hoc_ky_DD", Hoc_ky_DD)
                para(2) = New SqlParameter("@Nam_hoc_DD", Nam_hoc_DD)
                dt = Connect.SelectTableSP("Mark_DiemDanh_TC_KiemTra_TonTai", para)
                Return dt.Rows.Count
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_KDDKDT_TheoDiemDanh(ByVal ID_mon As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                para(2) = New SqlParameter("@Hoc_ky_DD", Hoc_ky_DD)
                para(3) = New SqlParameter("@Nam_hoc_DD", Nam_hoc_DD)
                Return Connect.SelectTableSP("MARK_DanhSach_DiemDanh_KDDKDT", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace