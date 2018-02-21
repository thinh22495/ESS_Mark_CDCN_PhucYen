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
    Public Class QuyDinhSoTinChiSom_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSQuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChiSom_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSQuyDinhSoTinChiSom_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_QuyDinhSoTinChiSom_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSQuyDinhSoTinChiSom(ByVal obj As ESSQuyDinhSoTinChiSom) As Integer
            Try
                Dim para(16) As SqlParameter
                para(0) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(1) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
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
                para(14) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay) Then
                    para(14).Value = DBNull.Value
                Else
                    para(14).Value = CDate(obj.Tu_ngay)
                End If

                para(15) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay) Then
                    para(15).Value = DBNull.Value
                Else
                    para(15).Value = CDate(obj.Den_ngay)
                End If
                para(16) = New SqlParameter("@id_he", obj.ID_he)
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChiSom_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSQuyDinhSoTinChiSom(ByVal obj As ESSQuyDinhSoTinChiSom) As Integer
            Try
                Dim para(16) As SqlParameter
                para(0) = New SqlParameter("@ID_he", obj.ID_he)
                para(1) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
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
                para(14) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                If IsNothing(obj.Tu_ngay) Then
                    para(14).Value = DBNull.Value
                Else
                    para(14).Value = CDate(obj.Tu_ngay)
                End If

                para(15) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                If IsNothing(obj.Den_ngay) Then
                    para(15).Value = DBNull.Value
                Else
                    para(15).Value = CDate(obj.Den_ngay)
                End If
                para(16) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChiSom_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSQuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.ExecuteSP("PLAN_QuyDinhSoTinChiSom_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyDinhSoTinChiSom(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim dt As DataTable
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", Nam_hoc)
                dt = Connect.SelectTableSP("PLAN_QuyDinhSoTinChiSom_TC_KiemTraTonTai", para)
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

