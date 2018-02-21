'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, 25 May, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class NoiNgoaiTru_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                Return Connect.SelectTableSP("STU_NoiNgoaiTru_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhongKyTucXa() As DataTable
            Try
                Return Connect.SelectTableSP("STU_PhongKyTucXa_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNoiNgoaiTru(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_NoiNgoaiTru_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNoiNgoaiTruSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_NoiNgoaiTruSV_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNoiNgoaiTru_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("sp_NoiNgoaiTru_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNgoaiTru(ByVal obj As ESSNoiNgoaiTru) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(1) = New SqlParameter("@Dia_chi", obj.Dia_chi)
                para(2) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                para(3) = New SqlParameter("@Ten_chu_ho", obj.Ten_chu_ho)
                para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(5) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(6) = New SqlParameter("@Trang_thai", obj.Trang_thai)
                para(7) = New SqlParameter("@ID_phuong", obj.ID_phuong)
                Return Connect.ExecuteSP("STU_NgoaiTru_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSNoiTru(ByVal obj As ESSNoiNgoaiTru) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Tu_ngay", obj.Tu_ngay)
                para(1) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(2) = New SqlParameter("@ID_phong_ktx", obj.ID_phong_ktx)
                para(3) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_NoiTru_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru(ByVal obj As ESSNoiNgoaiTru, ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                para(2) = New SqlParameter("@Den_ngay", SqlDbType.DateTime)
                If obj.Den_ngay.ToString = "" Then
                    para(2).Value = DBNull.Value
                Else
                    para(2).Value = CDate(obj.Den_ngay)
                End If
                para(3) = New SqlParameter("@ID_phong_ktx", obj.ID_phong_ktx)
                para(4) = New SqlParameter("@Dia_chi", obj.Dia_chi)
                para(5) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                para(6) = New SqlParameter("@Ten_chu_ho", obj.Ten_chu_ho)
                para(7) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                para(8) = New SqlParameter("@Trang_thai", obj.Trang_thai)
                para(9) = New SqlParameter("@ID_phuong", obj.ID_phuong)
                Return Connect.ExecuteSP("STU_NoiNgoaiTru_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_TrangThaiAll(ByVal ID_sv As Integer, ByVal Trang_thai As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Trang_thai", Trang_thai)
                Return Connect.ExecuteSP("STU_NoiNgoaiTru_TrangThaiAll_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_TrangThai(ByVal ID_sv As Integer, ByVal Tu_ngay As Date, ByVal Trang_thai As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Trang_thai", Trang_thai)
                para(2) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                para(2).Value = Tu_ngay
                Return Connect.ExecuteSP("STU_NoiNgoaiTru_TrangThai_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSNoiNgoaiTru_DenNgay(ByVal ID_sv As Integer, ByVal Den_ngay As Date) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Den_ngay", Den_ngay)
                Return Connect.ExecuteSP("STU_NoiNgoaiTru_DenNgay_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSNoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Tu_ngay", SqlDbType.DateTime)
                para(1).Value = Tu_ngay
                Return Connect.ExecuteSP("STU_NoiNgoaiTru_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                Dim dt As DataTable = Connect.SelectTableSP("STU_NoiNgoaiTru_KiemTraTonTai", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_NoiNgoaiTru(ByVal ID_sv As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Dim dt As DataTable = Connect.SelectTableSP("STU_NoiNgoaiTru_KiemTraTonTaiKhac", para)
                If dt.Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_NoiNgoaiTru(ByVal ID_sv As Integer, ByVal Tu_ngay As Date) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Tu_ngay", Tu_ngay)
                Return Connect.ExecuteScalar("STU_NoiNgoaiTru_GetMaxID", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

