Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Imports System.IO
Namespace DataAccess
    Public Class TongHopThongKe_DataAccess
        Public Sub New()

        End Sub

#Region "Functions And Subs"
        Public Function HienThi_ESSDSSV_TroCap(ByVal ID_he As Integer, ByVal Khoa_hoc As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSV_TroCap", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDSSV_TheoNganh(ByVal ID_he As Integer, ByVal Khoa_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSV_TheoNganh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDSNganh(ByVal ID_he As Integer, ByVal Khoa_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DS_Nganh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDSSV_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal ID_lop As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@ID_lop", ID_lop)
                para(4) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(5) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSV_HocBong", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLoai_TroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_TK_Loai_TroCap", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHocBong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_LoaiHocBong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTongHop_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_TK_TongHop_HocBong", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhMuc_DoiTuong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuong_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDS_MienGiam(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DanhSachSinhVienMienGiam_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DM_Khoa() As DataTable
            Try
                Return Connect.SelectTableSP("STU_Khoa_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Khoa của khóa học
        Public Function Khoa_Khoa_Hoc() As DataTable
            Try
                Return Connect.SelectTableSP("STU_TK_Khoa_Khoa_Hoc")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVienKhenThuong(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVKhenThuong", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachSinhVienNganh(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVNganh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function NganhDaoTao() As DataTable
            Try
                Return Connect.SelectTableSP("STU_TK_NganhDT")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TapTheKhenThuong(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DanhHieuThiDuaTapThe", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVienKyLuat(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVKyLuat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HinhThuc_XuLy() As DataTable
            Try
                Return Connect.SelectTableSP("STU_TK_HinhThuc_XuLy")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_SinhVienThoiHoc_NEW(Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVThoiHoc_NEW", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_SinhVienThoiHoc(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVThoiHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_SinhVienHocTiep(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_khoa", ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSVHocTiep", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_SinhVienCoCauXaHoi() As DataTable
            Try
                Return Connect.SelectTableSP("STU_Mau11")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_SinhVien() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DanhSachSinhVien")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_SinhVienNuocNgoai(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Mau12", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_SinhVienChinhSach(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Mau13", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function DanhSach_SinhVienTroCap(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Mau131", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKe_DiemHSSV(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Mau21", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_TinhThanh(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_TinhThanh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachSV_TinhThanh(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_DSSV_TinhThanh", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



#End Region

#Region "THỐNG KÊ ĐHHH"
        Public Function ThongKeSoLuongSinhVien_TheoLop(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_SoLuongSinhVienTheoLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKe_SoLuongSinhVien_TheoKhoa(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_SoLuongSinhVienTheoKhoaDaoTao", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKe_SoLuongSinhVien_TheoNganh(ByVal ID_He As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_He)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_TK_SoLuongSinhVienTheoNganhHoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongTinDanhBaSinhVien() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DanhSachSinhVien")
            Catch ex As Exception
                Throw ex
            End Try
        End Function




#End Region





    End Class
End Namespace


