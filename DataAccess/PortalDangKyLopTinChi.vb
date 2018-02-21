'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Namespace DataAccess
    Public Class PortalDangKyLopTinChi_DataAccess
        Public Function HienThi_ESSQuyDinhSoTinChi_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChi_TC_HienThi_KyDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSky_dang_ky(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSquy_dinh_dang_ky_som(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChiSom_TC_HienThi_KyDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMax_KyDangKy() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TC_Max")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetChon_KyDangKy() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_HocKyDangKy_TC_Chon")
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSDanhSachNhomTuChon_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTaoNhomTuChon_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMucHocPhiTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("ACC_MucHocPhiTinChi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSChuongTrinhDaoTaoDangKy_DanhSach(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTaoDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonDangKy_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                para(3) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_MonDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonTinChiDuocDangKy_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@ID_nganh", ID_nganh)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(6) = New SqlParameter("@ID_dt", ID_dt)
                para(7) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TCDuocDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonTinChiDuocDangKyCuaLopTheoPhamVi_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@ID_nganh", ID_nganh)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(6) = New SqlParameter("@ID_dt", ID_dt)
                para(7) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TCDuocDangKyCuaLopTheoPhamVi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSMonTinChiDuocDangKyCuaLop_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@ID_nganh", ID_nganh)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(6) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TCDuocDangKyCuaLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMonTinChiDaDangKy_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_sv As Integer, ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_MonTinChi_TCDaDangKy_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDuocDangKy_DanhSach(ByVal ID_sv As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DuocDangKy_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDuocDangKyCuaLop_DanhSach(ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DuocDangKyCuaLop_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTKBLopDuocDangKy_DanhSach(ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_Chon_DuocDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDaDangKy_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DaDangKy_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDaDangKy_Nganh1_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DaDangKyNganh1_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDaDangKy_Nganh2_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_DaDangKyNganh2_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopDaDangKyAll_DanhSach(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThiTatCa_DaDangKy_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachLopSoSinhVienDaDangKy_DanhSach(ByVal dsID_lop_tc As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop_tc", dsID_lop_tc)
                Return Connect.SelectTableSP("PLAN_LopTinChi_TC_HienThi_SoSinhvienDangKy_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTKBLopDaDangKy_DanhSach(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@dsID_mon_tc", dsID_mon_tc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_Chon_DaDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTKBLopDaDangKyAll_DanhSach(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_DanhSach_DaDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Get_Tham_So_He_Thong(ByVal ID_tham_so As String) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_tham_so", ID_tham_so)
                Return Connect.SelectTableSP("SYS_Get_Tham_So_He_Thong", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_DaDangKy(ByVal ID_sv As Integer, ByVal Ky_dang_ky As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_KiemTraTonTai_DaDangKy", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
