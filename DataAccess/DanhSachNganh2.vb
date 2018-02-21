Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSachNganh2_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSChuongTrinhNganh2_DanhSach(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachNganh2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhNganh2_DanhSach(ByVal Ma_sv As String, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_nganh", ID_nganh)
                para(1) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(2) = New SqlParameter("@Ma_sv", Ma_sv)
                Return Connect.SelectTableSP("STU_DanhSachSinhVienNganh2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachMonNganh1TrungNganh2_DanhSach(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt2 As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_dt2", ID_dt2)
                Return Connect.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachMonNganh1TrungNganh2DaChon_DanhSach(ByVal ID_dv As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_DanhSachMonNganh1TrungNganh2DaChon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Get_IDDT(ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer, ByVal ID_he As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(2) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_IDDT_Get_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSsvDanhSachNganh2(ByVal obj As ESSDanhSachNganh2) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_dt", obj.ID_dt2)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@So_QD", obj.So_qd)
                para(5) = New SqlParameter("@Ngay_QD", obj.Ngay_qd)
                para(6) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(7) = New SqlParameter("@Ngung_hoc", obj.Ngung_hoc)
                para(8) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc2)
                para(9) = New SqlParameter("@ID_lop", obj.ID_lop)
                Return Connect.ExecuteSP("STU_DanhSachNganh2_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachNganh2(ByVal obj As ESSDanhSachNganh2, ByVal ID_dt_old As Integer) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_dt_old", ID_dt_old)
                para(2) = New SqlParameter("@ID_dt", obj.ID_dt2)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(5) = New SqlParameter("@So_QD", obj.So_qd)
                para(6) = New SqlParameter("@Ngay_QD", obj.Ngay_qd)
                para(7) = New SqlParameter("@Noi_dung", obj.Noi_dung)
                para(8) = New SqlParameter("@Ngung_hoc", obj.Ngung_hoc)
                para(9) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc2)
                para(10) = New SqlParameter("@ID_lop", obj.ID_lop)
                Return Connect.ExecuteSP("STU_DanhSachNganh2_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSSinhVienNganh2_NgungHoc(ByVal ID_sv As Integer, ByVal ID_dt2 As Integer, ByVal Ngung_Hoc As Boolean) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_dt", ID_dt2)
                para(2) = New SqlParameter("@Ngung_Hoc", Ngung_Hoc)
                Return Connect.ExecuteSP("STU_DanhSachNganh2NgungHoc_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSsvDanhSachNganh2(ByVal ID_sv As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("STU_DanhSachNganh2_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVien_HocNganh2(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("STU_DanhSachNganh2_DanhSach_SinhVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '---------------------MON TUONG DUONG-----------------------
        Public Function HienThi_ESSDanhSachMonNganh1_TuongDuong_Nganh2_ChuaChon(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt2 As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                para(2) = New SqlParameter("@ID_dt2", ID_dt2)
                Return Connect.SelectTableSP("STU_DanhSachMonNganh1_TuongDuong_Nganh2_ChuaChon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSachMonNganh1TrungNganh2_TuongDuong_Nganh2_DaChon(ByVal ID_dv As String, ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dv", ID_dv)
                para(1) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_DanhSachMonNganh1_TuongDuong_Nganh2_DaChon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace