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
    Public Class DanhSachSinhVien_DataAccess

#Region "Initialize"
        Public Sub New()

        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachSinhVien_LamThe(ByVal ID_lops As String) As DataTable
            Try
                Try
                    Dim para(0) As SqlParameter
                    para(0) = New SqlParameter("@ID_lops", ID_lops)
                    Return Connect.SelectTableSP("STU_DanhSachSinhVien_LamThe", para)
                Catch ex As Exception
                    Throw ex
                End Try
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật ảnh sinh viên
        Public Sub UpdateImage(ByVal ID_sv As Integer, ByVal ar() As Byte)
            Try
                Dim p(1) As SqlParameter
                p(0) = New SqlParameter("@ID_sv", SqlDbType.Int, 4)
                If Not IsDBNull(ar) Then
                    p(1) = New SqlParameter("@Anh", SqlDbType.Image, ar.Length)
                Else
                    p(1) = New SqlParameter("@Anh", SqlDbType.Image, 16)
                End If
                p(1).Value = ar
                p(0).Value = ID_sv
                Connect.ExecuteSP("STU_CapNhatImage", p)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function DanhSachSinhVienMonHoc_load(ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienMonHoc_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_DanhSach_DanhSachSinhVien_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_DanhSach_DanhSachSinhVien_DanhSach_Full(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_HienThi_DanhSach_Full", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_HienThi_IDSV", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_DanhSach_DanhSachSinhVien_NotIn_DanhSach(ByVal ID_lops As String, ByVal ID_svs As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                para(1) = New SqlParameter("@ID_svs", ID_svs)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_NotIN_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_DanhSach_DanhSachSinhVien_NotIn_DanhSachNganh2(ByVal ID_lops As String, ByVal ID_svs As String, ByVal UserName As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                para(1) = New SqlParameter("@ID_svs", ID_svs)
                para(2) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_NotIN_HienThi_DanhSachNganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_DanhSach_DanhSachSinhVien_DanhSach(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal Ma_sv As String, ByVal SBD As String, ByVal Ho_ten As String, ByVal Ngay_sinh As String, Optional ByVal ID_chuyen_nganh As Integer = 0, Optional ByVal Ma_nganh As String = "") As DataTable
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@Ma_sv", Ma_sv)
                para(4) = New SqlParameter("@SBD", SBD)
                para(5) = New SqlParameter("@Ho_ten", Ho_ten)
                para(6) = New SqlParameter("@Ngay_sinh", Ngay_sinh)
                para(7) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(8) = New SqlParameter("@Ma_nganh", Ma_nganh)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_HeKhoaKhoaHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_DanhSach_DanhSachSinhVien_DanhSach(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Ma_nganh As String) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(4) = New SqlParameter("@Ma_nganh", Ma_nganh)
                Return Connect.SelectTableSP("STU_DanhSachSinhVien_HeKhoaKhoaHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachSinhVien(ByVal obj As ESSDanhSachSinhVien) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", obj.ID_lop)
                para(1) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                para(2) = New SqlParameter("@Active", obj.Active)
                para(3) = New SqlParameter("@Da_tot_nghiep", obj.Da_tot_nghiep)
                Return Connect.ExecuteSP("STU_DanhSach_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSachSinhVien(ByVal obj As ESSDanhSachSinhVien, ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                para(2) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                para(3) = New SqlParameter("@Active", obj.Active)
                para(4) = New SqlParameter("@Da_tot_nghiep", obj.Da_tot_nghiep)
                Return Connect.ExecuteSP("STU_DanhSach_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachSinhVien(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_DanhSach_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSachSinhVien_QuyenTruyCap(ByVal obj As ESSDanhSachSinhVien) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_lop", obj.ID_lop)
                para(2) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                para(3) = New SqlParameter("@Active", obj.Active)
                Return Connect.ExecuteSP("STU_DanhSach_CapQuyenSinhVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSSinhVienBangDiem(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("MARK_BangDiemSinhVienInfor_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSSinhVienNgoaiNganSach(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Ngoai_ngan_sach", Ngoai_ngan_sach)
                Return Connect.ExecuteSP("STU_DanhSachNgoaiNganSach_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

