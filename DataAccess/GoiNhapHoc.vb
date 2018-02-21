Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class GoiNhaphoc_DataAccess
#Region "Initialize"
        Public Sub New()

        End Sub
#End Region
#Region "Functions And Subs"
        Public Function LoadID_bien_lai(ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_BienLaiID_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan phai nop
        Public Function KhoanNop() As DataTable
            Try
                Return Connect.SelectTableSP("ACC_KhoanNop")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("ACC_KhoanDaNop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("ACC_KhoanDaNopNamHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSGoiNhapHoc_DanhSach(ByVal Da_phan_lop As Integer, ByVal Trang_thai As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Da_phan_lop", Da_phan_lop)
                para(1) = New SqlParameter("@Trang_thai", Trang_thai)
                Return Connect.SelectTableSP("STU_GoiNhapHoc_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật đăng ký học
        Public Sub UpdateDangKyHoc(ByVal objNhapHoc As ESSGoiNhapHoc)
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", objNhapHoc.ID_sv)
                para(1) = New SqlParameter("@UserName_tiep_nhan", objNhapHoc.UserName_tiep_nhan)
                If objNhapHoc.Ngay_nhap_hoc = Nothing Then
                    para(2) = New SqlParameter("@Ngay_nhap_hoc", DBNull.Value)
                Else
                    para(2) = New SqlParameter("@Ngay_nhap_hoc", objNhapHoc.Ngay_nhap_hoc)
                End If
                para(3) = New SqlParameter("@Dang_ky_hoc", objNhapHoc.Dang_ky_hoc)
                para(4) = New SqlParameter("@UserID_tiep_nhan", objNhapHoc.UserID_tiep_nhan)
                para(5) = New SqlParameter("@Lop", objNhapHoc.Lop)
                para(6) = New SqlParameter("@Xep_loai_tot_nghiep", objNhapHoc.Xep_loai_tot_nghiep)
                para(7) = New SqlParameter("@Nganh_tuyen_sinh", objNhapHoc.Nganh_tuyen_sinh)
                para(8) = New SqlParameter("@ID_gioi_tinh", objNhapHoc.ID_gioi_tinh)
                If objNhapHoc.Ngay_sinh = Nothing Then
                    para(9) = New SqlParameter("@Ngay_sinh", DBNull.Value)
                Else
                    para(9) = New SqlParameter("@Ngay_sinh", objNhapHoc.Ngay_sinh)
                End If
                para(10) = New SqlParameter("@Tong_diem", objNhapHoc.Tong_diem)
                Connect.ExecuteSP("STU_CapNhatNhapHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub DeleteDangKyHoc(ByVal objNhapHoc As ESSGoiNhapHoc)
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", objNhapHoc.ID_sv)
                Connect.Execute("STU_XoaNhapHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub DeleteSinhVienDangKyHoc(ByVal ID_sv As Integer)
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Connect.ExecuteSP("STU_HoSoSinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Function GetThongTinLop(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.SelectTableSP("STU_GoiNhapHoc_ThongTinLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function GetSoSinhVien_Lop(ByVal ID_lop As Integer) As Integer
            Dim dtdata As New DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                dtdata = Connect.SelectTableSP("STU_DanhSach_SySo", para)
                If dtdata.Rows.Count > 0 Then
                    Return dtdata.Rows(0).Item(0)
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
        End Function


#End Region

    End Class
End Namespace
