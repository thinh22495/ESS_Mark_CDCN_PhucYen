'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 07, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class QuyDinhSoTinChi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSQuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChi_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSQuyDinhSoTinChi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChi_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSQuyDinhSoTinChi(ByVal obj As ESSQuyDinhSoTinChi) As Integer
            Try
                Dim para(17) As SqlParameter
                para(0) = New SqlParameter("@ID_he", obj.ID_he)
                para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                para(4) = New SqlParameter("@So_hoc_trinh_min_bt", obj.So_hoc_trinh_min_bt)
                para(5) = New SqlParameter("@So_hoc_trinh_max_bt", obj.So_hoc_trinh_max_bt)
                para(6) = New SqlParameter("@So_hoc_trinh_option_bt", obj.So_hoc_trinh_option_bt)
                para(7) = New SqlParameter("@Check_So_hoc_trinh_min_bt", obj.KiemTra_So_hoc_trinh_min_bt)
                para(8) = New SqlParameter("@Check_So_hoc_trinh_max_bt", obj.KiemTra_So_hoc_trinh_max_bt)
                para(9) = New SqlParameter("@So_hoc_trinh_min_yeu", obj.So_hoc_trinh_min_yeu)
                para(10) = New SqlParameter("@So_hoc_trinh_max_yeu", obj.So_hoc_trinh_max_yeu)
                para(11) = New SqlParameter("@So_hoc_trinh_option_yeu", obj.So_hoc_trinh_option_yeu)
                para(12) = New SqlParameter("@Check_So_hoc_trinh_min_yeu", obj.KiemTra_So_hoc_trinh_min_yeu)
                para(13) = New SqlParameter("@Check_So_hoc_trinh_max_yeu", obj.KiemTra_So_hoc_trinh_max_yeu)
                para(14) = New SqlParameter("@Tu_ngay1", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay1) Then
                    para(14).Value = DBNull.Value
                Else
                    para(14).Value = CDate(obj.Tu_ngay1)
                End If

                para(15) = New SqlParameter("@Den_ngay1", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay1) Then
                    para(15).Value = DBNull.Value
                Else
                    para(15).Value = CDate(obj.Den_ngay1)
                End If

                para(16) = New SqlParameter("@Tu_ngay2", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay2) Then
                    para(16).Value = DBNull.Value
                Else
                    para(16).Value = CDate(obj.Tu_ngay2)
                End If

                para(17) = New SqlParameter("@Den_ngay2", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay2) Then
                    para(17).Value = DBNull.Value
                Else
                    para(17).Value = CDate(obj.Den_ngay2)
                End If
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChi_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyDinhSoTinChi(ByVal obj As ESSQuyDinhSoTinChi) As Integer
            Try
                Dim para(17) As SqlParameter
                para(0) = New SqlParameter("@ID_he", obj.ID_he)
                para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", obj.Ky_dang_ky)
                para(4) = New SqlParameter("@So_hoc_trinh_min_bt", obj.So_hoc_trinh_min_bt)
                para(5) = New SqlParameter("@So_hoc_trinh_max_bt", obj.So_hoc_trinh_max_bt)
                para(6) = New SqlParameter("@So_hoc_trinh_option_bt", obj.So_hoc_trinh_option_bt)
                para(7) = New SqlParameter("@Check_So_hoc_trinh_min_bt", obj.KiemTra_So_hoc_trinh_min_bt)
                para(8) = New SqlParameter("@Check_So_hoc_trinh_max_bt", obj.KiemTra_So_hoc_trinh_max_bt)
                para(9) = New SqlParameter("@So_hoc_trinh_min_yeu", obj.So_hoc_trinh_min_yeu)
                para(10) = New SqlParameter("@So_hoc_trinh_max_yeu", obj.So_hoc_trinh_max_yeu)
                para(11) = New SqlParameter("@So_hoc_trinh_option_yeu", obj.So_hoc_trinh_option_yeu)
                para(12) = New SqlParameter("@Check_So_hoc_trinh_min_yeu", obj.KiemTra_So_hoc_trinh_min_yeu)
                para(13) = New SqlParameter("@Check_So_hoc_trinh_max_yeu", obj.KiemTra_So_hoc_trinh_max_yeu)
                para(14) = New SqlParameter("@Tu_ngay1", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay1) Then
                    para(14).Value = DBNull.Value
                Else
                    para(14).Value = obj.Tu_ngay1
                End If

                para(15) = New SqlParameter("@Den_ngay1", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay1) Then
                    para(15).Value = DBNull.Value
                Else
                    para(15).Value = obj.Den_ngay1
                End If

                para(16) = New SqlParameter("@Tu_ngay2", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay2) Then
                    para(16).Value = DBNull.Value
                Else
                    para(16).Value = obj.Tu_ngay2
                End If

                para(17) = New SqlParameter("@Den_ngay2", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay2) Then
                    para(17).Value = DBNull.Value
                Else
                    para(17).Value = obj.Den_ngay2
                End If
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChi_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSChonDotDangKy(ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("PLAN_HocKyDangKy_TCChonKyDangKy_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChi_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChi(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ky_dang_ky As Integer) As Boolean
            Try
                Dim dt As DataTable
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ky_dang_ky", Ky_dang_ky)
                dt = Connect.SelectTableSP("PLAN_QuyDinhSoTinChi_TC_KiemTraTonTai", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

