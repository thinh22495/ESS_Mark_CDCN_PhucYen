'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, June 06, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class TochucThi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhsachMonThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Ngay_thi As Date) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Ngay_thi", Ngay_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_MonThi_HienThi_DanhSach", para)
            Else
                Dim para(2) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":Ngay_thi", Ngay_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_MonThi_HienThi_DanhSach", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachMonThiDungNgay(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Ngay_thi As Date) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Ngay_thi", Ngay_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_MonThi_HienThi_DanhSach_dungngay", para)
            Else
                Dim para(2) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":Ngay_thi", Ngay_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_MonThi_HienThi_DanhSach_dungngay", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachLopTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ngay_thi As Date) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Ngay_thi", Ngay_thi)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_LopTinChi_HienThi_DanhSach", para)
            Else
                Dim para(3) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":Ngay_thi", Ngay_thi)
                para(3) = New OracleParameter(":ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_LopTinChi_HienThi_DanhSach", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachLopTinChi_dungngay(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ngay_thi As Date) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@Ngay_thi", Ngay_thi)
                para(3) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_LopTinChi_HienThi_DanhSach_dungngay", para)
            Else
                Dim para(3) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":Ngay_thi", Ngay_thi)
                para(3) = New OracleParameter(":ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_LopTinChi_HienThi_DanhSach_dungngay", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachTochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_bm As Integer, Optional ByVal ID_khoa As Integer = 0) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_bm", ID_bm)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_HienThi_DanhSach", para)
            Else
                Dim para(3) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(2) = New OracleParameter(":ID_bm", ID_bm)
                para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_HienThi_DanhSach", para)
            End If
        End Function
        Public Function HienThi_ESSTochucThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_HienThi", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":Hoc_ky", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_HienThi", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachPhongThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThiPhong_TC_HienThi_DanhSach", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThiPhong_TC_HienThi_DanhSach", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachTuiThi(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_TuiThi_HienThi_DanhSach", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThi_TC_TuiThi_HienThi_DanhSach", para)
            End If
        End Function
        Public Function HienThi_ESSDanhsachSinhVien(ByVal ID_thi As Integer) As DataTable
            Dim para(0) As SqlParameter
            para(0) = New SqlParameter("@ID_thi", ID_thi)
            Return Connect.SelectTableSP("MARK_TochucThiChiTiet_TC_HienThi_DanhSach", para)
        End Function

        Public Function HienThi_ESSDanhsachSinhVien_NangDiem(ByVal ID_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_TochucThiChiTiet_TC_NangDiem_HienThi_DanhSach", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_TochucThiChiTiet_TC_NangDiem_HienThi_DanhSach", para)
            End If
        End Function



        Public Function HienThi_ESSDS_dangkyThiLai(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Hinh_thuc As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    'Dim dt As DataTable
                    para(0) = New SqlParameter("@ID_mon", ID_mon)
                    para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(3) = New SqlParameter("@Hinh_thuc", Hinh_thuc)
                    Return Connect.SelectTableSP("MARK_ToChucThiDangKyCaiThienDiem_TC_TheoMon_HienThi", para)
                Else
                    Dim para(2) As OracleParameter
                    'Dim dt As DataTable
                    para(0) = New OracleParameter("@ID_mon", ID_mon)
                    para(1) = New OracleParameter("@Hoc_ky", Hoc_ky)
                    para(2) = New OracleParameter("@Nam_hoc", Nam_hoc)
                    Return Connect.SelectTableSP("MARK_ToChucThiDangKyCaiThienDiem_TC_TheoMon_HienThi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_svTochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Dot_thi As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    'Dim dt As DataTable
                    para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", ID_he)
                    para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                    para(4) = New SqlParameter("@ID_mon", ID_mon)
                    para(5) = New SqlParameter("@Lan_thi", Lan_thi)
                    para(6) = New SqlParameter("@Dot_thi", Dot_thi)
                    Return Connect.SelectTableSP("MARK_ToChucThi_TC_KiemTraTonTai", para)
                    'If dt.Rows.Count > 0 Then
                    '    Return dt.Rows(0).Item("ID_thi")
                    'Else
                    '    Return -1
                    'End If
                Else
                    Dim para(6) As OracleParameter
                    'Dim dt As DataTable
                    para(0) = New OracleParameter(":Hoc_ky", Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", ID_he)
                    para(3) = New OracleParameter(":ID_khoa", ID_khoa)
                    para(4) = New OracleParameter(":ID_mon", ID_mon)
                    para(5) = New OracleParameter(":Lan_thi", Lan_thi)
                    para(6) = New OracleParameter(":Dot_thi", Dot_thi)
                    Return Connect.SelectTableSP("MARK_ToChucThi_TC_KiemTraTonTai", para)
                    'If dt.Rows.Count > 0 Then
                    '    Return dt.Rows(0).Item("ID_thi")
                    'Else
                    '    Return -1
                    'End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckTrungLichThi_SinhVien(ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal dsID_lop_tc As String) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    'Dim dt As DataTable
                    para(0) = New SqlParameter("@Ngay_thi", Ngay_thi)
                    para(1) = New SqlParameter("@Ca_thi", Ca_thi)
                    para(2) = New SqlParameter("@Nhom_tiet", Nhom_tiet)
                    para(3) = New SqlParameter("@dsID_lop_tc", dsID_lop_tc)
                    Return Connect.SelectTableSP("MARK_ToChucThi_TC_CheckTrungLichThi_SinhVien", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":Ngay_thi", Ngay_thi)
                    para(1) = New OracleParameter(":Ca_thi", Ca_thi)
                    para(2) = New OracleParameter(":Nhom_tiet", Nhom_tiet)
                    para(3) = New OracleParameter(":dsID_lop_tc", dsID_lop_tc)
                    Return Connect.SelectTableSP("MARK_ToChucThi_TC_CheckTrungLichThi_SinhVien", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSTochucThi(ByVal obj As ESSTochucThi) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(10) As SqlParameter
                    para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(2) = New SqlParameter("@ID_he", obj.ID_he)
                    para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(4) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(5) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                    para(6) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(7) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(8) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(9) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(10) = New SqlParameter("@Gio_thi", obj.Gio_thi)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_ToChucThi_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(10) As OracleParameter
                    para(0) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(1) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(2) = New OracleParameter(":ID_he", obj.ID_he)
                    para(3) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(4) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(5) = New OracleParameter(":Lan_thi", obj.Lan_thi)
                    para(6) = New OracleParameter(":Dot_thi", obj.Dot_thi)
                    para(7) = New OracleParameter(":Ngay_thi", obj.Ngay_thi)
                    para(8) = New OracleParameter(":Ca_thi", obj.Ca_thi)
                    para(9) = New OracleParameter(":Nhom_tiet", obj.Nhom_tiet)
                    para(10) = New OracleParameter(":Gio_thi", obj.Gio_thi)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_ToChucThi_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThi(ByVal obj As ESSTochucThi, ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(11) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                    para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                    para(3) = New SqlParameter("@ID_he", obj.ID_he)
                    para(4) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                    para(5) = New SqlParameter("@ID_mon", obj.ID_mon)
                    para(6) = New SqlParameter("@Lan_thi", obj.Lan_thi)
                    para(7) = New SqlParameter("@Dot_thi", obj.Dot_thi)
                    para(8) = New SqlParameter("@Ngay_thi", obj.Ngay_thi)
                    para(9) = New SqlParameter("@Ca_thi", obj.Ca_thi)
                    para(10) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet)
                    para(11) = New SqlParameter("@Gio_thi", obj.Gio_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThi_TC_CapNhat", para)
                Else
                    Dim para(11) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    para(1) = New OracleParameter(":Hoc_ky", obj.Hoc_ky)
                    para(2) = New OracleParameter(":Nam_hoc", obj.Nam_hoc)
                    para(3) = New OracleParameter(":ID_he", obj.ID_he)
                    para(4) = New OracleParameter(":ID_khoa", obj.ID_khoa)
                    para(5) = New OracleParameter(":ID_mon", obj.ID_mon)
                    para(6) = New OracleParameter(":Lan_thi", obj.Lan_thi)
                    para(7) = New OracleParameter(":Dot_thi", obj.Dot_thi)
                    para(8) = New OracleParameter(":Ngay_thi", obj.Ngay_thi)
                    para(9) = New OracleParameter(":Ca_thi", obj.Ca_thi)
                    para(10) = New OracleParameter(":Nhom_tiet", obj.Nhom_tiet)
                    para(11) = New OracleParameter(":Gio_thi", obj.Gio_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThi_TC_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Xoa_ESSTochucThi(ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThi_TC_Xoa", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThi_TC_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ThemMoi_ESSToChucThiPhong_(ByVal obj As ESSToChucThiPhong) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(6) As SqlParameter
                    para(0) = New SqlParameter("@Ten_phong", obj.Ten_phong)
                    para(1) = New SqlParameter("@So_sv", obj.So_sv)
                    para(2) = New SqlParameter("@ID_phong", obj.ID_phong)

                    para(3) = New SqlParameter("@Nhom_tiet", obj.Nhom_tiet_phong)
                    para(4) = New SqlParameter("@Ca_thi", obj.Ca_thi_Phong)
                    para(5) = New SqlParameter("@Gio_thi", obj.Gio_thi_Phong)
                    para(6) = New SqlParameter("@Ngay_thi", obj.Ngay_thi_Phong)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_ToChucThiPhong_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":Ten_phong", obj.Ten_phong)
                    para(1) = New OracleParameter(":So_sv", obj.So_sv)
                    para(2) = New OracleParameter(":ID_phong", obj.ID_phong)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_ToChucThiPhong_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhong(ByVal obj As ESSToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(3) As SqlParameter
                    para(0) = New SqlParameter("@ID_phong_thi", ID_phong_thi)
                    para(1) = New SqlParameter("@ID_phong", obj.ID_phong)
                    para(2) = New SqlParameter("@Ten_phong", obj.Ten_phong)
                    para(3) = New SqlParameter("@So_sv", obj.So_sv)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_CapNhat", para)
                Else
                    Dim para(3) As OracleParameter
                    para(0) = New OracleParameter(":ID_phong_thi", ID_phong_thi)
                    para(1) = New OracleParameter(":ID_phong", obj.ID_phong)
                    para(2) = New OracleParameter(":Ten_phong", obj.Ten_phong)
                    para(3) = New OracleParameter(":So_sv", obj.So_sv)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhong(ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_Xoa", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSTochucThiChiTiet(ByVal obj As ESSTochucThiChiTiet) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(7) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", obj.ID_thi)
                    para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(2) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                    para(3) = New SqlParameter("@So_bao_danh", obj.So_bao_danh)
                    para(4) = New SqlParameter("@So_phach", obj.So_phach)
                    para(5) = New SqlParameter("@Tui_so", obj.Tui_so)
                    para(6) = New SqlParameter("@Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(7) = New SqlParameter("@OrderBy", obj.OrderBy)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_TochucThiChiTiet_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                Else
                    Dim para(7) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", obj.ID_thi)
                    para(1) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(2) = New OracleParameter(":ID_phong_thi", obj.ID_phong_thi)
                    para(3) = New OracleParameter(":So_bao_danh", obj.So_bao_danh)
                    para(4) = New OracleParameter(":So_phach", obj.So_phach)
                    para(5) = New OracleParameter(":Tui_so", obj.Tui_so)
                    para(6) = New OracleParameter(":Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(7) = New OracleParameter(":OrderBy", obj.OrderBy)
                    Dim dt As DataTable
                    dt = Connect.SelectTableSP("MARK_TochucThiChiTiet_TC_ThemMoi", para)
                    If dt.Rows.Count > 0 Then
                        Return dt.Rows(0)(0)
                    Else
                        Return -1
                    End If
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThiChiTiet(ByVal obj As ESSTochucThiChiTiet, ByVal ID_ds_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(8) As SqlParameter
                    para(0) = New SqlParameter("@ID_ds_thi", ID_ds_thi)
                    para(1) = New SqlParameter("@ID_thi", obj.ID_thi)
                    para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                    para(3) = New SqlParameter("@ID_phong_thi", obj.ID_phong_thi)
                    para(4) = New SqlParameter("@So_bao_danh", obj.So_bao_danh)
                    para(5) = New SqlParameter("@So_phach", obj.So_phach)
                    para(6) = New SqlParameter("@Tui_so", obj.Tui_so)
                    para(7) = New SqlParameter("@Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(8) = New SqlParameter("@OrderBy", obj.OrderBy)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_CapNhat", para)
                Else
                    Dim para(8) As OracleParameter
                    para(0) = New OracleParameter(":ID_ds_thi", ID_ds_thi)
                    para(1) = New OracleParameter(":ID_thi", obj.ID_thi)
                    para(2) = New OracleParameter(":ID_sv", obj.ID_sv)
                    para(3) = New OracleParameter(":ID_phong_thi", obj.ID_phong_thi)
                    para(4) = New OracleParameter(":So_bao_danh", obj.So_bao_danh)
                    para(5) = New OracleParameter(":So_phach", obj.So_phach)
                    para(6) = New OracleParameter(":Tui_so", obj.Tui_so)
                    para(7) = New OracleParameter(":Ghi_chu_thi", obj.Ghi_chu_thi)
                    para(8) = New OracleParameter(":OrderBy", obj.OrderBy)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThiChiTiet_SBD(ByVal So_bao_danh As String, ByVal ID_ds_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_ds_thi", ID_ds_thi)
                    para(1) = New SqlParameter("@So_bao_danh", So_bao_danh)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_SBD_CapNhat", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_ds_thi", ID_ds_thi)
                    para(1) = New OracleParameter(":So_bao_danh", So_bao_danh)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_SBD_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSTochucThiChiTiet_GhiChu(ByVal Ghi_chu_thi As String, ByVal ID_ds_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_ds_thi", ID_ds_thi)
                    para(1) = New SqlParameter("@Ghi_chu_thi", Ghi_chu_thi)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_GhiChu_CapNhat", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":ID_ds_thi", ID_ds_thi)
                    para(1) = New OracleParameter(":Ghi_chu_thi", Ghi_chu_thi)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_GhiChu_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSTochucThiChiTiet(ByVal ID_thi As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_Xoa", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiTheoPhong(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@ID_phong_thi", ID_phong_this)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_Xoa", para)
                Else
                    Dim para(0) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function Xoa_ESSTochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
        '    Try
        '        If gDBType = DatabaseType.SQLServer Then
        '            Dim para(1) As SqlParameter
        '            para(0) = New SqlParameter("@ID_thi", ID_thi)
        '            para(1) = New SqlParameter("@ID_sv", ID_sv)
        '            Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_Xoa", para)
        '        Else
        '            Dim para(0) As OracleParameter
        '            para(0) = New OracleParameter(":ID_thi", ID_thi)
        '            Return Connect.ExecuteSP("MARK_TochucThiChiTiet_TC_Xoa", para)
        '        End If
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function Xoa_ESSTochucThiChiTiet_SV(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("MARK_ToChucThiChiTiet_TC_Xoa_SV", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSDotThi(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thi As Integer) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(3) = New SqlParameter("@Dot_thi", Dot_thi)
                Return Connect.SelectTableSP("STU_HienThi_ESSLichThiTheoDot_HienThi_DanhSach", para)
            Else
                Dim para(3) As OracleParameter
                para(0) = New OracleParameter(":ID_he", ID_he)
                para(1) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(2) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(3) = New OracleParameter(":Dot_thi", Dot_thi)
                Return Connect.SelectTableSP("STU_HienThi_ESSLichThiTheoDot_HienThi_DanhSach", para)
            End If
        End Function

        Public Function KiemTra_SosvDuTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal SoSV_Max As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_thi", ID_thi)
                    para(1) = New SqlParameter("@Tui_so", Tui_so)
                    para(2) = New SqlParameter("@SoSV_Max", SoSV_Max)
                    Return Connect.SelectTableSP("MARK_TochucThi_SoSVDongTui_KiemTraTonTai", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_thi", ID_thi)
                    para(1) = New OracleParameter(":Tui_so", Tui_so)
                    para(2) = New OracleParameter(":SoSV_Max", SoSV_Max)
                    Return Connect.SelectTableSP("MARK_TochucThi_SoSVDongTui_KiemTraTonTai", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSSinhVien_KDDKDuThi(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            If gDBType = DatabaseType.SQLServer Then
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_mon_tc", 0)
                para(1) = New SqlParameter("@ID_lop_tc", 0)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(4) = New SqlParameter("@ID_mon", ID_mon)
                para(5) = New SqlParameter("@ID_lops", "")
                Return Connect.SelectTableSP("STU_DanhSachKhongThi_TC_HienThi_DanhSach", para)
            Else
                Dim para(0) As OracleParameter
                para(0) = New OracleParameter(":ID_mon_tc", 0)
                para(1) = New OracleParameter(":ID_lop_tc", 0)
                para(2) = New OracleParameter(":Hoc_ky", Hoc_ky)
                para(3) = New OracleParameter(":Nam_hoc", Nam_hoc)
                para(4) = New OracleParameter(":ID_mon", ID_mon)
                para(5) = New OracleParameter(":ID_lops", "")
                Return Connect.SelectTableSP("STU_DanhSachKhongThi_TC_HienThi_DanhSach", para)
            End If
        End Function
#End Region
        Public Function HienThi_ESSToChucThi_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("MARK_TochucThi_TC_TongHop_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDSSV_ChuaToChuc(ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop_tc", ID_lop_tc)
                Return Connect.SelectTableSP("MARK_ToChucThi_DSSV_ChuaToChuc_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_TheoSinhVien_svTochucThi(ByVal ID_thi As Integer, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Ngay_thi As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                Dim dt As DataTable
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                para(1) = New SqlParameter("@Ca_thi", Ca_thi)
                para(2) = New SqlParameter("@Nhom_tiet", Nhom_tiet)
                para(3) = New SqlParameter("@Ngay_thi", Ngay_thi)
                para(4) = New SqlParameter("@ID_sv", ID_sv)
                dt = Connect.SelectTableSP("MARK_TochucThi_TC_TheoSV_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return 1
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhsachTheoPhong(ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim para(3) As SqlParameter
            para(0) = New SqlParameter("@ID_khoa", ID_khoa)
            para(1) = New SqlParameter("@ID_nganh", ID_nganh)
            para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
            para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
            Return Connect.SelectTableSP("MARK_TochucThi_TC_SVTheoPhongThi", para)
        End Function
        Public Function HienThi_ESSThongKeTheoPhong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim para(1) As SqlParameter
            para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
            para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
            Return Connect.SelectTableSP("MARK_TochucThi_TC_ThongKeTheoPhongThi", para)
        End Function
        Public Function HienThi_ESSDanhsachTheoMon(ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim para(3) As SqlParameter
            para(0) = New SqlParameter("@ID_khoa", ID_khoa)
            para(1) = New SqlParameter("@ID_nganh", ID_nganh)
            para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
            para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
            Return Connect.SelectTableSP("MARK_TochucThi_TC_MonTheoPhongThi", para)
        End Function
        Public Function HienThi_ESSDanhsachThi_DiemThi(ByVal ID_thi As Integer, ByVal Lan_thi As Integer) As DataTable
            Dim para(1) As SqlParameter
            para(0) = New SqlParameter("@ID_thi", ID_thi)
            para(1) = New SqlParameter("@Lan_thi", Lan_thi)
            Return Connect.SelectTableSP("MARK_TochucThi_TC_BaoCaoDiemThi", para)
        End Function

#Region "Function PhucKhao"
        Public Function HienThi_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.SelectTableSP("MARK_ToChucThiPhucKhao_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSToChucThiPhucKhao_DanhSach(ByVal ID_thi As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", ID_thi)
                Return Connect.SelectTableSP("MARK_ToChucThiPhucKhao_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSToChucThiPhucKhao_DanhSach_All(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("MARK_ToChucThiPhucKhao_TC_HienThi_DanhSach_All", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSToChucThiPhucKhao(ByVal obj As ESSToChucThiPhucKhao) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", obj.ID_thi)
                para(1) = New SqlParameter("@ID_ds_thi", obj.ID_ds_thi)
                para(2) = New SqlParameter("@Lan", obj.Lan)
                para(3) = New SqlParameter("@Diem1", obj.Diem1)
                para(4) = New SqlParameter("@Diem2", obj.Diem2)
                para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhucKhao(ByVal obj As ESSToChucThiPhucKhao, ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                para(1) = New SqlParameter("@ID_thi", obj.ID_thi)
                para(2) = New SqlParameter("@ID_ds_thi", obj.ID_ds_thi)
                para(3) = New SqlParameter("@Lan", obj.Lan)
                para(4) = New SqlParameter("@Diem1", obj.Diem1)
                para(5) = New SqlParameter("@Diem2", obj.Diem2)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteScalar("MARK_ToChucThiPhucKhao_TC_KiemTraTonTai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_ToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteScalar("MARK_ToChucThiPhucKhao_TC_GetMaxID", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function CapNhat_ESSToChucThiPhong_ThongTin(ByVal ID_phong_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Ca_thi As Integer, ByVal Gio_thi As String, ByVal Ngay_thi As Date, ByVal ID_phong As Integer, ByVal Ten_phong As String) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Nhom_tiet", Nhom_tiet)
                para(1) = New SqlParameter("@Ca_thi", Ca_thi)
                para(2) = New SqlParameter("@Ngay_thi", Ngay_thi)
                para(3) = New SqlParameter("@Gio_thi", Gio_thi)
                para(4) = New SqlParameter("@ID_phong_thi", ID_phong_thi)
                para(5) = New SqlParameter("@ID_phong", ID_phong)
                para(6) = New SqlParameter("@Ten_phong", Ten_phong)
                Return Connect.ExecuteSP("MARK_ToChucThiPhong_TC_CapNhat_TT", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_GhiChuThi(ByVal ID_ds_thi As Integer, ByVal Ghi_chu_thi As String) As DataTable
            Dim para(1) As SqlParameter
            para(0) = New SqlParameter("@ID_ds_thi", ID_ds_thi)
            para(1) = New SqlParameter("@Ghi_chu_thi", Ghi_chu_thi)
            Return Connect.SelectTableSP("MARK_TochucThiChiTiet_CapNhat_GhiChuThi", para)
        End Function
    End Class
End Namespace

