Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class GoiNhapHoc_Bussines
        Private arrSinhVien As New ArrayList
        Private dtKhoanNop As DataTable
        Private dtKhoanDaNop As DataTable
        Private dtBienLai As DataTable ' Luu giữ bảng ID_bien_lai

#Region "Initialize"
        Public Sub New()

        End Sub

        Public Sub New(ByVal Da_phan_lop As Integer, ByVal Trang_thai As Integer)
            Try
                Dim obj As GoiNhaphoc_DataAccess = New GoiNhaphoc_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSGoiNhapHoc_DanhSach(Da_phan_lop, Trang_thai)
                Dim objGoiNhapHoc As ESSGoiNhapHoc = Nothing
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objGoiNhapHoc = Mapping(dr)
                    arrSinhVien.Add(objGoiNhapHoc)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal Nam_hoc As String, ByVal ID_sv As Integer)
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                dtKhoanNop = obj.KhoanNop()
                dtKhoanDaNop = obj.KhoanDaNop(Nam_hoc, ID_sv)
                dtBienLai = obj.LoadID_bien_lai(Nam_hoc, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

#Region "Functions And Subs"
        ' Tìm ID_bien lai theo sinh viên
        Public Function GetID_bien_lai(ByVal ID_sv As Integer) As Integer
            Try
                Dim ID_bien_lai As Integer = 0
                For i As Integer = 0 To dtBienLai.Rows.Count - 1
                    If dtBienLai.Rows(i)("ID_sv") = ID_sv Then
                        ID_bien_lai = dtBienLai.Rows(i)("ID_bien_lai")
                    End If
                Next
                Return ID_bien_lai
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load khoan nop
        Public Function KhoanNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                Dim dtDaNop As DataTable = KhoanDaNop(ID_sv)
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_thu_chi", GetType(String))
                dt.Columns.Add("Ten_thu_chi", GetType(String))
                dt.Columns.Add("So_tien", GetType(Integer))
                For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    If dtDaNop Is Nothing Then
                        row("Chon") = False
                    Else
                        Dim dk As String = "ID_thu_chi=" & dtKhoanNop.Rows(i).Item("ID_thu_chi")
                        dtDaNop.DefaultView.RowFilter = dk
                        If dtDaNop.DefaultView.Count > 0 Then
                            row("Chon") = True
                        Else
                            row("Chon") = False
                        End If
                    End If
                    row("ID_thu_chi") = dtKhoanNop.Rows(i).Item("ID_thu_chi")
                    row("Ten_thu_chi") = dtKhoanNop.Rows(i).Item("Ten_thu_chi")
                    row("So_tien") = dtKhoanNop.Rows(i).Item("So_tien")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan da nop cua sinh vien 
        Public Function KhoanDaNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_thu_chi", GetType(String))
                dt.Columns.Add("Ten_thu_chi", GetType(String))
                dt.Columns.Add("So_tien", GetType(Integer))
                For i As Integer = 0 To dtKhoanDaNop.Rows.Count - 1
                    If dtKhoanDaNop.Rows(i).Item("ID_sv") = ID_sv Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = dtKhoanDaNop.Rows(i).Item("ID_sv")
                        row("ID_thu_chi") = dtKhoanDaNop.Rows(i).Item("ID_thu_chi")
                        row("Ten_thu_chi") = dtKhoanDaNop.Rows(i).Item("Ten_thu_chi")
                        row("So_tien") = dtKhoanDaNop.Rows(i).Item("So_tien")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cac khoan chua nộp
        Public Function KhoanChuaNop(ByVal ID_sv As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dtDaNop As DataTable = KhoanDaNop(ID_sv)
                ' Cac khoan phải nộp
                Dim dtNop As DataTable = dtKhoanNop
                For i As Integer = 0 To dtDaNop.Rows.Count - 1
                    Dim idx As Integer = dtNop.Rows.Count - 1
                    For j As Integer = 0 To idx
                        If j > idx Then Exit For
                        If dtDaNop.Rows(i).Item("ID_thu_chi") = dtNop.Rows(j).Item("ID_thu_chi") Then
                            dtNop.Rows(j).Delete()
                            dtNop.AcceptChanges()
                            idx -= 1
                        End If
                    Next
                Next
                Return dtNop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien đã gọi nhập học
        Public Function DanhSachSv_DaGoi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Integer))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As ESSGoiNhapHoc = CType(arrSinhVien(i), ESSGoiNhapHoc)
                    If nh.Dang_ky_hoc = 1 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Dang_ky_hoc") = nh.Dang_ky_hoc
                        row("ID_sv") = nh.ID_sv
                        row("SBD") = nh.SBD
                        row("Ho_ten") = nh.Ho_ten
                        If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                        row("Tong_diem") = nh.Tong_diem
                        If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                        row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                        row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                        row("Khoi_thi") = nh.Khoi_thi
                        row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien chưa gọi nhập học
        Public Function DanhSachSv_ChuaGoi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As ESSGoiNhapHoc = CType(arrSinhVien(i), ESSGoiNhapHoc)
                    If nh.UserName_tiep_nhan = "" Then
                        Dim row As DataRow = dt.NewRow()
                        row("Dang_ky_hoc") = False
                        row("ID_sv") = nh.ID_sv
                        row("SBD") = nh.SBD
                        row("Ho_ten") = nh.Ho_ten
                        If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                        row("Tong_diem") = nh.Tong_diem
                        If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                        row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                        row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                        row("Khoi_thi") = nh.Khoi_thi
                        row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Nhung sinh vien chua goi và đã gọi nhập học
        Public Function DanhSachSv() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ChonSv", GetType(Boolean))
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("ID_gioi_tinh", GetType(Integer))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("ID_khoa", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("ID_chuyen_nganh", GetType(Integer))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Lop", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("So_tien", GetType(String))
                dt.Columns.Add("Nguoi_thu", GetType(String))
                dt.Columns.Add("Xep_loai_tot_nghiep", GetType(String))
                dt.Columns.Add("Ten_tinh", GetType(String))
                dt.Columns.Add("Ten_huyen", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As ESSGoiNhapHoc = CType(arrSinhVien(i), ESSGoiNhapHoc)
                    Dim row As DataRow = dt.NewRow()
                    row("ChonSv") = False
                    If nh.UserName_tiep_nhan = "" Then
                        row("Dang_ky_hoc") = False
                    Else
                        row("Dang_ky_hoc") = True
                    End If
                    row("ID_sv") = nh.ID_sv
                    row("SBD") = nh.SBD
                    row("Ma_sv") = nh.Ma_sv
                    row("Ho_ten") = nh.Ho_ten
                    row("ID_gioi_tinh") = nh.ID_gioi_tinh
                    If row("ID_gioi_tinh") = 0 Then
                        row("Gioi_tinh") = "Nam"
                    Else
                        row("Gioi_tinh") = "Nữ"
                    End If
                    If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                    row("Tong_diem") = nh.Tong_diem
                    If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                    row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                    row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                    row("Khoi_thi") = nh.Khoi_thi
                    row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                    row("ID_he") = nh.ID_he
                    row("ID_khoa") = nh.ID_khoa
                    row("Khoa_hoc") = nh.Khoa_hoc
                    row("ID_chuyen_nganh") = nh.ID_chuyen_nganh
                    row("ID_lop") = nh.ID_lop
                    row("Lop") = nh.Lop
                    row("Nam_hoc") = nh.Nam_hoc
                    row("So_tien") = nh.So_tien
                    row("Nguoi_thu") = nh.Nguoi_thu
                    row("Xep_loai_tot_nghiep") = nh.Xep_loai_tot_nghiep
                    row("Ten_tinh") = nh.Ten_tinh
                    row("Ten_huyen") = nh.TenHuyen
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetThongTinLop(ByVal ID_lop As Integer) As DataTable
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                Return obj.GetThongTinLop(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetSoSinhVien_Lop(ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                Return obj.GetSoSinhVien_Lop(ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function UpdateTable(ByVal objNH As ESSGoiNhapHoc) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Dang_ky_hoc", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Tong_diem", GetType(Integer))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(Date))
                dt.Columns.Add("UserName_tiep_nhan", GetType(String))
                dt.Columns.Add("UserID_tiep_nhan", GetType(Integer))
                dt.Columns.Add("Khoi_thi", GetType(String))
                dt.Columns.Add("Nganh_tuyen_sinh", GetType(String))
                For i As Integer = 0 To arrSinhVien.Count - 1
                    Dim nh As ESSGoiNhapHoc = CType(arrSinhVien(i), ESSGoiNhapHoc)
                    If nh.ID_sv = objNH.ID_sv Then nh = objNH ' Cập nhật mới                    
                    Dim row As DataRow = dt.NewRow()
                    If nh.UserName_tiep_nhan = "" Then
                        row("Dang_ky_hoc") = False
                    Else
                        row("Dang_ky_hoc") = True
                    End If
                    row("ID_sv") = nh.ID_sv
                    row("SBD") = nh.SBD
                    row("Ho_ten") = nh.Ho_ten
                    If nh.Ngay_sinh <> Nothing Then row("Ngay_sinh") = nh.Ngay_sinh
                    row("Tong_diem") = nh.Tong_diem
                    If nh.Ngay_nhap_hoc <> Nothing Then row("Ngay_nhap_hoc") = nh.Ngay_nhap_hoc
                    row("UserName_tiep_nhan") = nh.UserName_tiep_nhan
                    row("UserID_tiep_nhan") = nh.UserID_tiep_nhan
                    row("Khoi_thi") = nh.Khoi_thi
                    row("Nganh_tuyen_sinh") = nh.Nganh_tuyen_sinh
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Cập nhật đăng ký học
        Public Sub UpdateDangKyHoc(ByVal objNhapHoc As ESSGoiNhapHoc)
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                obj.UpdateDangKyHoc(objNhapHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ' Xóa đăng ký học
        Public Sub DeleteDangKyHoc(ByVal objNhapHoc As ESSGoiNhapHoc)
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                obj.DeleteDangKyHoc(objNhapHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' Xóa sv nhập học
        Public Sub DeleteSinhVienDangKyHoc(ByVal ID_sv As Integer)
            Try
                Dim obj As New GoiNhaphoc_DataAccess
                obj.DeleteSinhVienDangKyHoc(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Private Function Mapping(ByVal drGoiNhapHoc As DataRow) As ESSGoiNhapHoc
            Dim result As ESSGoiNhapHoc
            Try
                result = New ESSGoiNhapHoc
                If drGoiNhapHoc("ID_sv").ToString() <> "" Then result.ID_sv = CType(drGoiNhapHoc("ID_sv").ToString(), Integer)
                result.Dang_ky_hoc = CType(drGoiNhapHoc("Dang_ky_hoc"), Integer)
                result.Ma_sv = drGoiNhapHoc("Ma_sv").ToString()
                result.Ho_ten = drGoiNhapHoc("Ho_ten").ToString()
                If drGoiNhapHoc("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drGoiNhapHoc("ID_gioi_tinh").ToString(), Integer)
                If drGoiNhapHoc("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drGoiNhapHoc("Ngay_sinh").ToString(), Date)
                If drGoiNhapHoc("Tong_diem").ToString() <> "" Then result.Tong_diem = CType(drGoiNhapHoc("Tong_diem").ToString(), Single)
                If drGoiNhapHoc("Ngay_nhap_hoc").ToString() <> "" Then result.Ngay_nhap_hoc = CType(drGoiNhapHoc("Ngay_nhap_hoc").ToString(), Date)
                If drGoiNhapHoc("UserName_tiep_nhan").ToString() <> "" Then result.UserName_tiep_nhan = CType(drGoiNhapHoc("UserName_tiep_nhan").ToString(), String)
                result.Khoi_thi = drGoiNhapHoc("Khoi_thi").ToString()
                result.Nganh_tuyen_sinh = drGoiNhapHoc("Nganh_tuyen_sinh").ToString()
                result.SBD = drGoiNhapHoc("SBD").ToString()
                If drGoiNhapHoc("UserID_tiep_nhan").ToString() <> "" Then result.UserID_tiep_nhan = CType(drGoiNhapHoc("UserID_tiep_nhan").ToString(), Integer)
                If drGoiNhapHoc("ID_he").ToString() <> "" Then result.ID_he = CType(drGoiNhapHoc("ID_he").ToString(), Integer)
                If drGoiNhapHoc("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drGoiNhapHoc("ID_khoa").ToString(), Integer)
                If drGoiNhapHoc("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drGoiNhapHoc("Khoa_hoc").ToString(), Integer)
                If drGoiNhapHoc("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drGoiNhapHoc("ID_chuyen_nganh").ToString(), Integer)
                If drGoiNhapHoc("ID_lop").ToString() <> "" Then result.ID_lop = CType(drGoiNhapHoc("ID_lop").ToString(), Integer)
                result.Lop = drGoiNhapHoc("Lop").ToString()
                If drGoiNhapHoc("Ngay_nhap_hoc").ToString() <> "" Then result.Nam_hoc = CType(Year(drGoiNhapHoc("Ngay_nhap_hoc")), String)

                If drGoiNhapHoc("So_tien").ToString() <> "" Then result.So_tien = CType(drGoiNhapHoc("So_tien").ToString(), Integer)
                result.Nguoi_thu = drGoiNhapHoc("Nguoi_thu").ToString()
                result.Xep_loai_tot_nghiep = drGoiNhapHoc("Xep_loai_tot_nghiep").ToString()
                result.Ten_tinh = drGoiNhapHoc("Ten_tinh").ToString()
                result.TenHuyen = drGoiNhapHoc("Ten_huyen").ToString()


            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region

#End Region
    End Class
End Namespace
