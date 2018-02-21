'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class Scheduling_DLL
        Public Sub New()

        End Sub
        Public Function SuKiensTinChi_Count(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_SuKienLopTinChi_Count", para).Rows(0).Item(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub SuKiensTinChi_InsertDB(ByVal sks As ESSSu_kien)
            Try
                Dim p(8) As SqlParameter
                p(0) = New SqlParameter("@ID_lop_tc", sks.ID_lop_tc)
                p(1) = New SqlParameter("@ID_phong", sks.ID_phong)
                p(2) = New SqlParameter("@ID_cb", sks.ID_cb)
                p(3) = New SqlParameter("@Ca_hoc", sks.Ca_hoc)
                p(4) = New SqlParameter("@Thu", sks.Thu)
                p(5) = New SqlParameter("@Tiet", sks.Tiet)
                p(6) = New SqlParameter("@So_tiet", sks.So_tiet)
                p(7) = New SqlParameter("@Loai_tiet", sks.Loai_tiet)
                p(8) = New SqlParameter("@Da_xep_lich", sks.Da_xep_lich)
                Connect.ExecuteSP("PLAN_SukiensTinChi_TC_ThemMoi", p)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub SuKiensTinChi_UpdateDB(ByVal sks As ESSSu_kien)
            Try
                Dim p(9) As SqlParameter
                p(0) = New SqlParameter("@ID", sks.ID)
                p(1) = New SqlParameter("@ID_lop_tc", sks.ID_lop_tc)
                p(2) = New SqlParameter("@ID_phong", sks.ID_phong)
                p(3) = New SqlParameter("@ID_cb", sks.ID_cb)
                p(4) = New SqlParameter("@Ca_hoc", sks.Ca_hoc)
                p(5) = New SqlParameter("@Thu", sks.Thu)
                p(6) = New SqlParameter("@Tiet", sks.Tiet)
                p(7) = New SqlParameter("@So_tiet", sks.So_tiet)
                p(8) = New SqlParameter("@Loai_tiet", sks.Loai_tiet)
                p(9) = New SqlParameter("@Da_xep_lich", sks.Da_xep_lich)
                Connect.ExecuteSP("PLAN_SukiensTinChi_TC_CapNhat", p)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function SuKiensTinChi_Check(ByVal sks As ESSSu_kien) As Integer
            Try
                Dim dt As DataTable
                Dim p(4) As SqlParameter
                p(0) = New SqlParameter("@ID_lop_tc", sks.ID_lop_tc)
                p(1) = New SqlParameter("@Thu", sks.Thu)
                p(2) = New SqlParameter("@Tiet", sks.Tiet)
                p(3) = New SqlParameter("@So_tiet", sks.So_tiet)
                p(4) = New SqlParameter("@Loai_tiet", sks.Loai_tiet)
                dt = Connect.SelectTableSP("PLAN_SukiensTinChi_TC_KiemTraTonTai", p)
                If dt.Rows.Count > 0 Then
                    Return 1
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub SuKiensTinChi_DeleteDB(ByVal Ky_dang_ky As Integer)
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Connect.ExecuteSP("PLAN_SukiensTinChi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function SuKiensTinChi_Read_from_KHM(ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_Chon_Kehoach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKiensTinChi_Read_from_sukien(ByVal Ky_dang_ky As Byte) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_SukiensTinChi_TC_Chon_SuKien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacLopTinChi(ByVal Ky_dang_ky As Byte) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_SukiensKhacLopTinChi_Chon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function SuKienKhacPhongTinChi() As DataTable
            Return Connect.SelectTableSP("PLAN_SukiensKhacPhongTinChi_Chon")
        End Function
        Public Function SuKienKhacGiaoVienTinChi() As DataTable
            Return Connect.SelectTableSP("PLAN_SukiensKhacGiaoVienTinChi_Chon")
        End Function
        Public Sub SuKiensKhacGiaoVienTinChi_Save(ByVal skk As ESSSukien_gv)
            If skk.ID = -1 Then
                If skk.Mo_ta.Trim() <> "" Then
                    Dim p(4) As SqlParameter
                    p(0) = New SqlParameter("@ID_cb", skk.ID_cb)
                    p(1) = New SqlParameter("@Thu", skk.Thu)
                    p(2) = New SqlParameter("@Tiet", skk.Tiet)
                    p(3) = New SqlParameter("@So_tiet", skk.So_tiet)
                    p(4) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacGiaoVienTinChi_TC_ThemMoi", p)
                End If
            Else
                If skk.Mo_ta.Trim() = "" Then
                    Dim p As New SqlParameter("@ID", skk.ID)
                    Connect.ExecuteSP("PLAN_SuKienKhacGiaoVienTinChi_TC_Xoa", p)
                Else
                    Dim p(1) As SqlParameter
                    p(0) = New SqlParameter("@ID", skk.ID)
                    p(1) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacGiaoVienTinChi_TC_CapNhat", p)
                End If
            End If
        End Sub
        Public Sub SuKiensKhacPhongTinChi_Save(ByVal skk As ESSSukien_phong)
            If skk.ID = -1 Then
                If skk.Mo_ta.Trim() <> "" Then
                    Dim p(4) As SqlParameter
                    p(0) = New SqlParameter("@ID_phong", skk.ID_phong)
                    p(1) = New SqlParameter("@Thu", skk.Thu)
                    p(2) = New SqlParameter("@Tiet", skk.Tiet)
                    p(3) = New SqlParameter("@So_tiet", skk.So_tiet)
                    p(4) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacPhongTinChi_TC_ThemMoi", p)
                End If
            Else ' delete or update
                If skk.Mo_ta.Trim() = "" Then
                    Dim p As New SqlParameter("@ID", skk.ID)
                    Connect.ExecuteSP("PLAN_SuKienKhacPhongTinChi_TC_Xoa", p)
                Else
                    Dim p(1) As SqlParameter
                    p(0) = New SqlParameter("@ID", skk.ID)
                    p(1) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacPhongTinChi_CapNhat", p)
                End If
            End If
        End Sub
        Public Sub SuKiensKhacLopTinChi_Save(ByVal skk As ESSSukien_lop)
            If skk.ID = -1 Then
                If skk.Mo_ta.Trim() <> "" Then
                    Dim p(4) As SqlParameter
                    p(0) = New SqlParameter("@ID_lop_tc", skk.ID_lop_tc)
                    p(1) = New SqlParameter("@Thu", skk.Thu)
                    p(2) = New SqlParameter("@Tiet", skk.Tiet)
                    p(3) = New SqlParameter("@So_tiet", skk.So_tiet)
                    p(4) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacLopTinChi_TC_ThemMoi", p)
                End If
            Else ' delete or update
                If skk.Mo_ta.Trim() = "" Then
                    Dim p As New SqlParameter("@ID", skk.ID)
                    Connect.ExecuteSP("PLAN_SuKienKhacLopTinChi_TC_Xoa", p)
                Else
                    Dim p(1) As SqlParameter
                    p(0) = New SqlParameter("@ID", skk.ID)
                    p(1) = New SqlParameter("@Mo_ta", skk.Mo_ta)
                    Connect.ExecuteSP("PLAN_SuKienKhacLopTinChi_CapNhat", p)
                End If
            End If
        End Sub

        Public Sub SuKiensTinChi_Delete(ByVal ID As Integer)
            Dim p As New SqlParameter("@ID", ID)
            Connect.ExecuteSP("PLAN_SuKienTinChi_TC_Xoa", p)
        End Sub


    End Class
End Namespace
