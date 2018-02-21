Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachLuanVanThiNoTotNghiep_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachLuanVan_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachLuanVan_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachThiTotNghiep_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachThiTotNghiep_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachNoTotNghiep_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachNoTotNghiep_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachLuanVan(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(3) = New SqlParameter("@So_tin_chi", obj.So_tin_chi)
                'para(4) = New SqlParameter("@Co_van_duyet", obj.Co_van_duyet)
                'para(5) = New SqlParameter("@Sinh_vien_duyet", obj.Sinh_vien_duyet)
                Return Connect.ExecuteSP("STU_DanhSachLuanVan_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachLuanVan(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachLuanVan_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachThiTotNghiep(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                'para(3) = New SqlParameter("@Co_van_duyet", obj.Co_van_duyet)
                'para(4) = New SqlParameter("@Sinh_vien_duyet", obj.Sinh_vien_duyet)
                Return Connect.ExecuteSP("STU_DanhSachThiTotNghiep_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachThiTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachThiTotNghiep_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachNoTotNghiep(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@TBCHT", obj.TBCHT)
                para(2) = New SqlParameter("@ID_xep_loai", obj.ID_xep_loai)
                para(3) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DanhSachNoTotNghiep_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachNoTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_DanhSachNoTotNghiep_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Public Function CapNhat_ESSDanhSachThiTotNghiep(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
        '    Try
        '        Dim para(2) As SqlParameter
        '        para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
        '        para(1) = New SqlParameter("@Co_van_duyet", obj.Co_van_duyet)
        '        para(2) = New SqlParameter("@Sinh_vien_duyet", obj.Sinh_vien_duyet)
        '        Return Connect.ExecuteSP("STU_DanhSachThiTotNghiep_CapNhat", para)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Public Function CapNhat_ESSDanhSachLuanVan_SangThi(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Co_van_duyet", obj.CoVan_duyet)
                para(2) = New SqlParameter("@Sinh_vien_duyet", obj.SinhVien_duyet)
                Return Connect.ExecuteSP("STU_DanhSachLuanVan_SangThi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_XetTotNghiep_DangKy_Them(ByVal obj As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Co_van_duyet", obj.CoVan_duyet)
                para(2) = New SqlParameter("@Sinh_vien_duyet", obj.SinhVien_duyet)
                Return Connect.ExecuteSP("STU_XetTotNghiep_DangKy_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function HienThi_TotNghiep_DangKy(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_TOTNGHIEP_DANGKY_LOAD", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
