'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, June 01, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class KhenThuong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSSinhVienKhenThuong(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return Connect.SelectTableSP("STU_SinhVienKhenThuong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuong(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_KhenThuongLop_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuongSV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_KhenThuongSV_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuong(ByVal ID_khen_thuong As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.SelectTableSP("STU_KhenThuong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuong_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("sp_KhenThuong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKhenThuong(ByVal obj As ESSKhenThuong) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@So_QD", obj.So_QD)
                para(1) = New SqlParameter("@Ngay_QD", obj.Ngay_QD)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@ID_loai_kt", obj.ID_loai_kt)
                para(5) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                para(6) = New SqlParameter("@ID_cap", obj.ID_cap)
                Return Connect.ExecuteSP("STU_KhenThuong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.ExecuteSP("STU_KhenThuongSinhVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhenThuong(ByVal obj As ESSKhenThuong, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                para(1) = New SqlParameter("@So_QD", obj.So_QD)
                para(2) = New SqlParameter("@Ngay_QD", obj.Ngay_QD)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(5) = New SqlParameter("@ID_loai_kt", obj.ID_loai_kt)
                para(6) = New SqlParameter("@Hinh_thuc", obj.Hinh_thuc)
                para(7) = New SqlParameter("@ID_cap", obj.ID_cap)
                Return Connect.ExecuteSP("STU_KhenThuong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.ExecuteSP("STU_KhenThuongSinhVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhenThuong(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.ExecuteSP("STU_KhenThuong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhenThuongSinhVien(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.ExecuteSP("STU_KhenThuongSinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KhenThuong(ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                Return Connect.ExecuteScalar("STU_KhenThuong_KiemTraTonTai", para)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_KhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_khen_thuong", ID_khen_thuong)
                If Connect.SelectTableSP("STU_KhenThuongSinhVien_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_KhenThuong() As Integer
            Try
                Return Connect.ExecuteScalar("STU_KhenThuong_GetMaxID")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

