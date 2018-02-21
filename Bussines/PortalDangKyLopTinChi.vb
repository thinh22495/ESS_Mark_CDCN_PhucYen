'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class PortalDangKyLopTinChi_Bussines
        Private ID_sv As Integer
        Private ID_dt As Integer
        Private ID_he As Integer = 0
        Private ID_khoa As Integer = 0
        Private ID_nganh As Integer = 0
        Private ID_chuyen_nganh As Integer = 0
        Private Khoa_hoc As Integer = 0
        Sub New()

        End Sub
        Sub New(ByVal mID_sv As Integer, ByVal mID_dt As Integer, ByVal mID_he As Integer, ByVal mID_khoa As Integer, ByVal mID_nganh As Integer, ByVal mID_chuyen_nganh As Integer, ByVal mKhoa_hoc As Integer)
            ID_sv = mID_sv
            ID_dt = mID_dt
            ID_he = mID_he
            Khoa_hoc = mKhoa_hoc
            ID_khoa = mID_khoa
            ID_nganh = mID_nganh
            ID_chuyen_nganh = mID_chuyen_nganh
        End Sub

        Public Function ESSChuongTrinhDaotao() As DataTable
            Dim clsCTDT As New ChuongTrinhDaoTao_Bussines(ID_dt)
            clsCTDT.HienThi_ESSCTDTChiTiet(ID_dt)
            Return clsCTDT.ESSChuongTrinhDaoTaoChiTietDangKy(ID_dt)
        End Function

        Public Function ESSChuongTrinhDaotao(ByVal ID_dt As Integer) As DataTable
            Dim clsCTDT As New ChuongTrinhDaoTao_Bussines(ID_dt)
            clsCTDT.HienThi_ESSCTDTChiTiet(ID_dt)
            Return clsCTDT.ESSChuongTrinhDaoTaoChiTietDangKy(ID_dt)
        End Function

        Public Function HienThi_ESSky_dang_ky(ByVal Ky_dang_ky As Integer) As DataTable
            Dim clsKyDK As New PortalDangKyLopTinChi_DataAccess
            Return clsKyDK.HienThi_ESSky_dang_ky(Ky_dang_ky)
        End Function

        Public Function HienThi_ESSquy_dinh_dang_ky_som(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim clsKyDK As New PortalDangKyLopTinChi_DataAccess
            Return clsKyDK.HienThi_ESSquy_dinh_dang_ky_som(ID_he, ID_khoa, Khoa_hoc)
        End Function

        Public Function Get_KyDangKy() As Integer
            Dim cls As New PortalDangKyLopTinChi_DataAccess
            Dim dt As DataTable
            dt = cls.GetChon_KyDangKy()
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)(0)
            Else
                dt = cls.GetMax_KyDangKy()
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)(0)
                Else
                    Return 0
                End If
            End If
        End Function
        Public Function Get_dsKyDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim clsDAL As New MonTinChi_DataAccess
            Dim dtKyDangKy As DataTable
            Dim dsKy_dang_ky As String = ""
            dtKyDangKy = clsDAL.HienThi_ESSHocKyDangKy_DanhSach(0, Hoc_ky, Nam_hoc)
            For i As Integer = 0 To dtKyDangKy.Rows.Count - 1
                dsKy_dang_ky += dtKyDangKy.Rows(i)("Ky_dang_ky").ToString + ","
            Next
            If dsKy_dang_ky <> "" Then dsKy_dang_ky = Left(dsKy_dang_ky, Len(dsKy_dang_ky) - 1)
            Return dsKy_dang_ky
        End Function

        Public Function ThongTinQuyDinhSoTinChiDangKy(ByVal Ky_dang_ky As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSQuyDinhSoTinChi_DanhSach(Ky_dang_ky, ID_he, ID_khoa, Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachNhomTuChon() As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSDanhSachNhomTuChon_DanhSach(ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSMucHocPhiTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSMucHocPhiTinChi_DanhSach(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachHocPhanDuocDangKy(ByVal dsKy_dang_ky As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtHP As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtHP = cls.HienThi_ESSMonTinChiDuocDangKy_DanhSach(ID_sv, Arr(0), ID_dt, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
                    dtHP.Merge(cls.HienThi_ESSMonTinChiDuocDangKyCuaLopTheoPhamVi_DanhSach(ID_sv, Arr(0), ID_dt, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc))

                    For i As Integer = 1 To Arr.Length - 1
                        dtHP.Merge(cls.HienThi_ESSMonTinChiDuocDangKy_DanhSach(ID_sv, Arr(i), ID_dt, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc))
                        dtHP.Merge(cls.HienThi_ESSMonTinChiDuocDangKyCuaLopTheoPhamVi_DanhSach(ID_sv, Arr(i), ID_dt, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc))
                    Next
                End If
                Return dtHP
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachHocPhanDuocDangKyCuaLop(ByVal Ky_dang_ky As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtHP As New DataTable
                dtHP = cls.HienThi_ESSMonTinChiDuocDangKyCuaLop_DanhSach(Ky_dang_ky, ID_dt, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
                Return dtHP
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachHocPhanDaDangKy(ByVal dsKy_dang_ky As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtHP As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtHP = cls.HienThi_ESSMonTinChiDaDangKy_DanhSach(Arr(0), ID_sv, ID_dt)
                    For i As Integer = 1 To Arr.Length - 1
                        dtHP.Merge(cls.HienThi_ESSMonTinChiDaDangKy_DanhSach(Arr(i), ID_sv, ID_dt))
                    Next
                End If
                Return dtHP
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonChuongTrinhDaoTaoDangKy() As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSChuongTrinhDaoTaoDangKy_DanhSach(ID_dt, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachMonDaDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSMonDangKy_DanhSach(Hoc_ky, Nam_hoc, ID_sv, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachLopDuocDangKy(ByVal ID_sv As Integer, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSDanhSachLopDuocDangKy_DanhSach(ID_sv, dsID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopDuocDangKyCuaLop(ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSDanhSachLopDuocDangKyCuaLop_DanhSach(dsID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TKBLopDuocDangKy(ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSTKBLopDuocDangKy_DanhSach(dsID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopDaDangKy(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtLop As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtLop = cls.HienThi_ESSDanhSachLopDaDangKy_DanhSach(ID_sv, Arr(0), dsID_mon_tc)
                    For i As Integer = 1 To Arr.Length - 1
                        dtLop.Merge(cls.HienThi_ESSDanhSachLopDaDangKy_DanhSach(ID_sv, Arr(i), dsID_mon_tc))
                    Next
                End If
                Return dtLop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopDaDangKy_Nganh1(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtLop As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtLop = cls.HienThi_ESSDanhSachLopDaDangKy_Nganh1_DanhSach(ID_sv, Arr(0), dsID_mon_tc)
                    For i As Integer = 1 To Arr.Length - 1
                        dtLop.Merge(cls.HienThi_ESSDanhSachLopDaDangKy_Nganh1_DanhSach(ID_sv, Arr(i), dsID_mon_tc))
                    Next
                End If
                Return dtLop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopDaDangKy_Nganh2(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtLop As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtLop = cls.HienThi_ESSDanhSachLopDaDangKy_Nganh2_DanhSach(ID_sv, Arr(0), dsID_mon_tc)
                    For i As Integer = 1 To Arr.Length - 1
                        dtLop.Merge(cls.HienThi_ESSDanhSachLopDaDangKy_Nganh2_DanhSach(ID_sv, Arr(i), dsID_mon_tc))
                    Next
                End If
                Return dtLop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopDaDangKyAll(ByVal ID_sv As Integer) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtLop As New DataTable
                dtLop = cls.HienThi_ESSDanhSachLopDaDangKyAll_DanhSach(ID_sv)
                Return dtLop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachLopSoSinhVienDaDangKy(ByVal dsID_lop_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Return cls.HienThi_ESSDanhSachLopSoSinhVienDaDangKy_DanhSach(dsID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TKBLopDaDangKy(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String, ByVal dsID_mon_tc As String) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtTKB As New DataTable
                Dim Arr() As String = Split(dsKy_dang_ky.Trim, ",")
                If Arr.Length >= 1 Then
                    dtTKB = cls.HienThi_ESSTKBLopDaDangKy_DanhSach(ID_sv, Arr(0), dsID_mon_tc)
                    For i As Integer = 1 To Arr.Length - 1
                        dtTKB.Merge(cls.HienThi_ESSTKBLopDaDangKy_DanhSach(ID_sv, Arr(i), dsID_mon_tc))
                    Next
                End If
                Return dtTKB
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TKBLopDaDangKyAll(ByVal ID_sv As Integer) As DataTable
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dtTKB As New DataTable
                dtTKB = cls.HienThi_ESSTKBLopDaDangKyAll_DanhSach(ID_sv)
                Return dtTKB
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetThamSoHeThong(ByVal ID_tham_so As String) As String
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dt As New DataTable
                dt = cls.Get_Tham_So_He_Thong(ID_tham_so)
                If dt.Rows.Count = 0 Then Return 0
                Return dt.Rows(0)(0).ToString
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckDaDangKy(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer) As String
            Try
                Dim cls As New PortalDangKyLopTinChi_DataAccess
                Dim dt As New DataTable
                dt = cls.KiemTra_DaDangKy(ID_sv, Ky_dang_ky)
                If dt.Rows.Count > 0 Then Return True
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
