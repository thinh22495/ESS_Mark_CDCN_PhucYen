'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------


Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachSinhVien_Bussines
        Private arrDanhSach As ArrayList
        Private objSorted As New LapMa_Bussines()

#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal ID_lops As String, Optional ByVal full As Boolean = False)
            Try
                If ID_lops = "" Then ID_lops = "0"
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt As DataTable
                If full Then
                    dt = obj.HienThi_DanhSach_DanhSachSinhVien_DanhSach_Full(ID_lops)
                Else
                    dt = obj.HienThi_DanhSach_DanhSachSinhVien_DanhSach(ID_lops)
                End If
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal Bien_lai As Boolean, ByVal abc As Integer, ByVal ID_sv As Integer)
            Try
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSSinhVien(ID_sv)
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_lops As String, ByVal ID_svs As String)
            Try
                If ID_lops = "" Then ID_lops = "0"
                If ID_svs = "" Then ID_svs = "-1"
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt As DataTable = obj.HienThi_DanhSach_DanhSachSinhVien_NotIn_DanhSach(ID_lops, ID_svs)
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub New(ByVal ID_lops As String, ByVal ID_svs As String, ByVal Nganh2 As Boolean, ByVal Nganh1 As Boolean, ByVal UserName As String)
            Try
                If ID_lops = "" Then ID_lops = "0"
                If ID_svs = "" Then ID_svs = "-1"
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt As DataTable = obj.HienThi_DanhSach_DanhSachSinhVien_NotIn_DanhSachNganh2(ID_lops, ID_svs, UserName)
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping_Nganh2(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Property ESSDanhSachSinhVien(ByVal idx As Integer) As ESSDanhSachSinhVien
            Get
                Return CType(arrDanhSach(idx), ESSDanhSachSinhVien)
            End Get
            Set(ByVal Value As ESSDanhSachSinhVien)
                arrDanhSach(idx) = Value
            End Set
        End Property
        Public ReadOnly Property Count() As Integer
            Get
                Return arrDanhSach.Count
            End Get
        End Property
        ' Cập nhật ảnh sinh viên 
        Public Sub UpdateImage(ByVal ID_sv As Integer, ByVal ar() As Byte)
            Try
                Dim obj As New DanhSachSinhVien_DataAccess
                obj.UpdateImage(ID_sv, ar)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        ' Cập nhật mat khau sinh viên 
        Public Sub CapNhat_ESSDanhSachSinhVien_QuyenTruyCap(ByVal objDanhSachSinhVien As ESSDanhSachSinhVien)
            Try
                Dim obj As New DanhSachSinhVien_DataAccess
                obj.CapNhat_ESSDanhSachSinhVien_QuyenTruyCap(objDanhSachSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub UpdateNgoaiNganSachArr(ByVal ID_SV As Integer, ByVal Ngoai_ngan_sach As Integer)
            Dim idx As Integer = Tim_idx(ID_SV)

            If idx >= 0 Then
                Dim obj As New ESSDanhSachSinhVien
                obj = CType(arrDanhSach(idx), ESSDanhSachSinhVien)
                obj.Ngoai_ngan_sach = Ngoai_ngan_sach

                Dim objDal As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                objDal.CapNhat_ESSSinhVienNgoaiNganSach(ID_SV, Ngoai_ngan_sach)
            End If
        End Sub

        Private Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSach.Count - 1
                If CType(arrDanhSach(i), ESSDanhSachSinhVien).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Danh_sach_sinh_vien_NhapDiem(ByVal Ngoai_ngu As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))

                If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
                If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
                If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"

                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    If Ngoai_ngu <> "" Then
                        If ds.Ngoai_ngu = Ngoai_ngu Then
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("ID_dt") = ds.ID_dt1
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                            row("Gioi_tinh") = ds.Gioi_tinh
                            row("Noi_sinh") = ds.Noi_sinh
                            row("ID_lop") = ds.ID_lop
                            row("Ten_lop") = ds.Ten_lop
                            row("Ten_khoa") = ds.Ten_khoa
                            row("Nien_khoa") = ds.Nien_khoa
                            row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                            row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                            row("Tong_diem") = ds.Tong_diem
                            row("Ngoai_ngu") = ds.Ngoai_ngu
                            row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                            row("SBD") = ds.SBD
                            row("Dia_chi_tt") = ds.Dia_chi_tt
                            row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                            dt.Rows.Add(row)
                        End If
                    Else
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngu") = ds.Ngoai_ngu
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                        dt.Rows.Add(row)
                    End If

                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien_DangHoc() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))
                dt.Columns.Add("Trang_thai_hoc", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    If ds.Trang_thai_hoc.ToUpper.Trim = "ÐANG HOC".ToUpper.Trim Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("ID_dt") = ds.ID_dt1
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                        row("Gioi_tinh") = ds.Gioi_tinh
                        row("Noi_sinh") = ds.Noi_sinh
                        row("ID_lop") = ds.ID_lop
                        row("Ten_lop") = ds.Ten_lop
                        row("Ten_khoa") = ds.Ten_khoa
                        row("Nien_khoa") = ds.Nien_khoa
                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                        row("Tong_diem") = ds.Tong_diem
                        row("Ngoai_ngu") = ds.Ngoai_ngu
                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                        row("SBD") = ds.SBD
                        row("Dia_chi_tt") = ds.Dia_chi_tt
                        row("CMND") = ds.CMND
                        If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                        row("Noi_cap") = ds.Noi_cap
                        row("Trang_thai_hoc") = ds.Trang_thai_hoc

                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                        dt.Rows.Add(row)
                    End If
                Next
                Return objSorted.TableSortHo_ten(dt).ToTable
                'Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_dt2", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ho_Dem", GetType(String))
                dt.Columns.Add("Ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))
                dt.Columns.Add("Trang_thai_hoc", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False

                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("ID_dt2") = ds.ID_dt2
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ho_Dem") = ds.Ho_Dem
                    row("Ten") = ds.Ten
                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    row("Nien_khoa") = ds.Nien_khoa
                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                    row("Tong_diem") = ds.Tong_diem
                    row("Ngoai_ngu") = ds.Ngoai_ngu
                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                    row("SBD") = ds.SBD
                    row("Dia_chi_tt") = ds.Dia_chi_tt
                    row("CMND") = ds.CMND
                    If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                    row("Noi_cap") = ds.Noi_cap
                    row("Trang_thai_hoc") = ds.Trang_thai_hoc

                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                    dt.Rows.Add(row)
                Next
                Return objSorted.TableSortHo_ten(dt).ToTable
                'Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien_Nganh2() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_dt2", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False

                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("ID_dt2") = ds.ID_dt2
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    row("Nien_khoa") = ds.Nien_khoa
                    row("Tong_diem") = ds.Tong_diem
                    row("SBD") = ds.SBD
                    row("Dia_chi_tt") = ds.Dia_chi_tt
                    row("CMND") = ds.CMND
                    If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                    row("Noi_cap") = ds.Noi_cap

                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                    dt.Rows.Add(row)
                Next
                Return objSorted.TableSortHo_ten(dt).ToTable
                'Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien_lap_ma() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    row("Nien_khoa") = ds.Nien_khoa
                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                    row("Tong_diem") = ds.Tong_diem
                    row("Ngoai_ngu") = ds.Ngoai_ngu
                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                    row("SBD") = ds.SBD
                    row("Dia_chi_tt") = ds.Dia_chi_tt
                    row("CMND") = ds.CMND
                    If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                    row("Noi_cap") = ds.Noi_cap

                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                    dt.Rows.Add(row)
                Next
                Return dt

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_TCThi(ByVal dv_dachon As DataView, ByVal Ngoai_ngu As String, ByVal Ma_sv As String, ByVal Theo_hp_tin_chi As Boolean, ByVal ID_mon As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("SBD_order", GetType(String))

                If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
                If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
                If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt_sv_mon As DataTable = obj.DanhSachSinhVienMonHoc_load(ID_mon)
                dt_sv_mon.DefaultView.Sort = "ID_SV"
                If Not dv_dachon Is Nothing Then
                    dv_dachon.Sort = "ID_SV"
                    For i As Integer = 0 To arrDanhSach.Count - 1
                        Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                        If dv_dachon.Find(ds.ID_sv) < 0 Then
                            If Theo_hp_tin_chi Then
                                If dt_sv_mon.DefaultView.Find(ds.ID_sv) >= 0 Then
                                    If Ngoai_ngu.Trim <> "" And Ma_sv <> "" Then
                                        If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                            Dim row As DataRow = dt.NewRow()
                                            row("Chon") = False
                                            row("ID_sv") = ds.ID_sv
                                            row("ID_dt") = ds.ID_dt1
                                            row("Ma_sv") = ds.Ma_sv
                                            row("Ho_ten") = ds.Ho_ten
                                            row("Ngoai_ngu") = ds.Ngoai_ngu
                                            If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                            row("Gioi_tinh") = ds.Gioi_tinh
                                            row("Noi_sinh") = ds.Noi_sinh
                                            row("ID_lop") = ds.ID_lop
                                            row("Ten_lop") = ds.Ten_lop
                                            row("Ten_khoa") = ds.Ten_khoa
                                            row("Nien_khoa") = ds.Nien_khoa
                                            row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                            row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                            row("Tong_diem") = ds.Tong_diem
                                            row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                            row("SBD") = ds.SBD
                                            row("Dia_chi_tt") = ds.Dia_chi_tt
                                            row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                            dt.Rows.Add(row)
                                        End If
                                    ElseIf Ngoai_ngu.Trim <> "" And Ma_sv = "" Then
                                        If ds.Ngoai_ngu = Ngoai_ngu Then
                                            Dim row As DataRow = dt.NewRow()
                                            row("Chon") = False
                                            row("ID_sv") = ds.ID_sv
                                            row("ID_dt") = ds.ID_dt1
                                            row("Ma_sv") = ds.Ma_sv
                                            row("Ho_ten") = ds.Ho_ten
                                            row("Ngoai_ngu") = ds.Ngoai_ngu
                                            If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                            row("Gioi_tinh") = ds.Gioi_tinh
                                            row("Noi_sinh") = ds.Noi_sinh
                                            row("ID_lop") = ds.ID_lop
                                            row("Ten_lop") = ds.Ten_lop
                                            row("Ten_khoa") = ds.Ten_khoa
                                            row("Nien_khoa") = ds.Nien_khoa
                                            row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                            row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                            row("Tong_diem") = ds.Tong_diem
                                            row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                            row("SBD") = ds.SBD
                                            row("Dia_chi_tt") = ds.Dia_chi_tt
                                            row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                            dt.Rows.Add(row)
                                        End If
                                    ElseIf Ngoai_ngu.Trim = "" And Ma_sv <> "" Then
                                        If ds.Ma_sv = Ma_sv Then
                                            Dim row As DataRow = dt.NewRow()
                                            row("Chon") = False
                                            row("ID_sv") = ds.ID_sv
                                            row("ID_dt") = ds.ID_dt1
                                            row("Ma_sv") = ds.Ma_sv
                                            row("Ho_ten") = ds.Ho_ten
                                            row("Ngoai_ngu") = ds.Ngoai_ngu
                                            If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                            row("Gioi_tinh") = ds.Gioi_tinh
                                            row("Noi_sinh") = ds.Noi_sinh
                                            row("ID_lop") = ds.ID_lop
                                            row("Ten_lop") = ds.Ten_lop
                                            row("Ten_khoa") = ds.Ten_khoa
                                            row("Nien_khoa") = ds.Nien_khoa
                                            row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                            row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                            row("Tong_diem") = ds.Tong_diem
                                            row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                            row("SBD") = ds.SBD
                                            row("Dia_chi_tt") = ds.Dia_chi_tt
                                            row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                            dt.Rows.Add(row)
                                        End If
                                    Else
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                End If
                            Else
                                If Ngoai_ngu.Trim <> "" And Ma_sv <> "" Then
                                    If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                ElseIf Ngoai_ngu.Trim <> "" And Ma_sv = "" Then
                                    If ds.Ngoai_ngu = Ngoai_ngu Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                ElseIf Ngoai_ngu.Trim = "" And Ma_sv <> "" Then
                                    If ds.Ma_sv = Ma_sv Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                Else
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("ID_dt") = ds.ID_dt1
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Gioi_tinh") = ds.Gioi_tinh
                                    row("Noi_sinh") = ds.Noi_sinh
                                    row("ID_lop") = ds.ID_lop
                                    row("Ten_lop") = ds.Ten_lop
                                    row("Ten_khoa") = ds.Ten_khoa
                                    row("Nien_khoa") = ds.Nien_khoa
                                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                    row("Tong_diem") = ds.Tong_diem
                                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                    row("SBD") = ds.SBD
                                    row("Dia_chi_tt") = ds.Dia_chi_tt
                                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                    dt.Rows.Add(row)
                                End If
                            End If
                        End If
                    Next
                Else
                    'dv_dachon.Sort = "ID_SV"
                    For i As Integer = 0 To arrDanhSach.Count - 1
                        Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                        If Theo_hp_tin_chi Then
                            If dt_sv_mon.DefaultView.Find(ds.ID_sv) >= 0 Then
                                If Ngoai_ngu.Trim <> "" And Ma_sv <> "" Then
                                    If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                ElseIf Ngoai_ngu.Trim <> "" And Ma_sv = "" Then
                                    If ds.Ngoai_ngu = Ngoai_ngu Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                ElseIf Ngoai_ngu.Trim = "" And Ma_sv <> "" Then
                                    If ds.Ma_sv = Ma_sv Then
                                        Dim row As DataRow = dt.NewRow()
                                        row("Chon") = False
                                        row("ID_sv") = ds.ID_sv
                                        row("ID_dt") = ds.ID_dt1
                                        row("Ma_sv") = ds.Ma_sv
                                        row("Ho_ten") = ds.Ho_ten
                                        row("Ngoai_ngu") = ds.Ngoai_ngu
                                        If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                        row("Gioi_tinh") = ds.Gioi_tinh
                                        row("Noi_sinh") = ds.Noi_sinh
                                        row("ID_lop") = ds.ID_lop
                                        row("Ten_lop") = ds.Ten_lop
                                        row("Ten_khoa") = ds.Ten_khoa
                                        row("Nien_khoa") = ds.Nien_khoa
                                        row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                        row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                        row("Tong_diem") = ds.Tong_diem
                                        row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                        row("SBD") = ds.SBD
                                        row("Dia_chi_tt") = ds.Dia_chi_tt
                                        row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                        dt.Rows.Add(row)
                                    End If
                                Else
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("ID_dt") = ds.ID_dt1
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Gioi_tinh") = ds.Gioi_tinh
                                    row("Noi_sinh") = ds.Noi_sinh
                                    row("ID_lop") = ds.ID_lop
                                    row("Ten_lop") = ds.Ten_lop
                                    row("Ten_khoa") = ds.Ten_khoa
                                    row("Nien_khoa") = ds.Nien_khoa
                                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                    row("Tong_diem") = ds.Tong_diem
                                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                    row("SBD") = ds.SBD
                                    row("Dia_chi_tt") = ds.Dia_chi_tt
                                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                    dt.Rows.Add(row)
                                End If
                            End If
                        Else
                            If Ngoai_ngu.Trim <> "" And Ma_sv <> "" Then
                                If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("ID_dt") = ds.ID_dt1
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Gioi_tinh") = ds.Gioi_tinh
                                    row("Noi_sinh") = ds.Noi_sinh
                                    row("ID_lop") = ds.ID_lop
                                    row("Ten_lop") = ds.Ten_lop
                                    row("Ten_khoa") = ds.Ten_khoa
                                    row("Nien_khoa") = ds.Nien_khoa
                                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                    row("Tong_diem") = ds.Tong_diem
                                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                    row("SBD") = ds.SBD
                                    row("Dia_chi_tt") = ds.Dia_chi_tt
                                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                    dt.Rows.Add(row)
                                End If
                            ElseIf Ngoai_ngu.Trim <> "" And Ma_sv = "" Then
                                If ds.Ngoai_ngu = Ngoai_ngu Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("ID_dt") = ds.ID_dt1
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Gioi_tinh") = ds.Gioi_tinh
                                    row("Noi_sinh") = ds.Noi_sinh
                                    row("ID_lop") = ds.ID_lop
                                    row("Ten_lop") = ds.Ten_lop
                                    row("Ten_khoa") = ds.Ten_khoa
                                    row("Nien_khoa") = ds.Nien_khoa
                                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                    row("Tong_diem") = ds.Tong_diem
                                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                    row("SBD") = ds.SBD
                                    row("Dia_chi_tt") = ds.Dia_chi_tt
                                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                    dt.Rows.Add(row)
                                End If
                            ElseIf Ngoai_ngu.Trim = "" And Ma_sv <> "" Then
                                If ds.Ma_sv = Ma_sv Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("ID_dt") = ds.ID_dt1
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Gioi_tinh") = ds.Gioi_tinh
                                    row("Noi_sinh") = ds.Noi_sinh
                                    row("ID_lop") = ds.ID_lop
                                    row("Ten_lop") = ds.Ten_lop
                                    row("Ten_khoa") = ds.Ten_khoa
                                    row("Nien_khoa") = ds.Nien_khoa
                                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                    row("Tong_diem") = ds.Tong_diem
                                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                    row("SBD") = ds.SBD
                                    row("Dia_chi_tt") = ds.Dia_chi_tt
                                    row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                    dt.Rows.Add(row)
                                End If
                            Else
                                Dim row As DataRow = dt.NewRow()
                                row("Chon") = False
                                row("ID_sv") = ds.ID_sv
                                row("ID_dt") = ds.ID_dt1
                                row("Ma_sv") = ds.Ma_sv
                                row("Ho_ten") = ds.Ho_ten
                                row("Ngoai_ngu") = ds.Ngoai_ngu
                                If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                                row("Gioi_tinh") = ds.Gioi_tinh
                                row("Noi_sinh") = ds.Noi_sinh
                                row("ID_lop") = ds.ID_lop
                                row("Ten_lop") = ds.Ten_lop
                                row("Ten_khoa") = ds.Ten_khoa
                                row("Nien_khoa") = ds.Nien_khoa
                                row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                                row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                                row("Tong_diem") = ds.Tong_diem
                                row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                                row("SBD") = ds.SBD
                                row("Dia_chi_tt") = ds.Dia_chi_tt
                                row("SBD_order") = IIf(ds.SBD.Length = 1, "0000" & ds.SBD, IIf(ds.SBD.Length = 2, "000" & ds.SBD, IIf(ds.SBD.Length = 3, "00" & ds.SBD, IIf(ds.SBD.Length = 4, "0" & ds.SBD, ds.SBD))))
                                dt.Rows.Add(row)
                            End If
                        End If
                    Next
                End If
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_bang_diem(ByVal ID_lops As String) As DataTable
            Dim cls As New DanhSachSinhVien_DataAccess
            Dim dt As DataTable = cls.HienThi_ESSSinhVienBangDiem(ID_lops)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function

        Public Function Danh_sach_sinh_vien(ByVal dt_SVdatontai As DataTable) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt_SVdatontai.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    If dt_SVdatontai.DefaultView.Find(ds.ID_sv) < 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("Chon") = False
                        row("ID_sv") = ds.ID_sv
                        row("Ma_sv") = ds.Ma_sv
                        row("Ho_ten") = ds.Ho_ten
                        row("Ngay_sinh") = ds.Ngay_sinh
                        row("Ten_lop") = ds.Ten_lop
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Danh_sach_sinh_vien(ByVal arrID_sv() As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("ID_lop_cu", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    For j As Integer = 0 To arrID_sv.Length - 1
                        If ds.ID_sv = arrID_sv(j) Then
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = ds.Ngay_sinh
                            row("ID_lop") = ds.ID_lop
                            row("Ten_lop") = ds.Ten_lop
                            row("Ten_khoa") = ds.Ten_khoa
                            row("ID_lop_cu") = 0

                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Danh_sach_sinh_vien_KyLuat(ByVal arrID_sv() As String) As DataTable
            Try
                Dim dt As New DataTable

                dt.Columns.Add("Chon")
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))

                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    For j As Integer = 0 To arrID_sv.Length - 1
                        If ds.ID_sv = arrID_sv(j) Then
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = ds.Ngay_sinh
                            row("ID_lop") = ds.ID_lop
                            row("Ten_lop") = ds.Ten_lop
                            row("Xoa_ky_luat") = False
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        ' Danh sách sinh viên theo một số  ID_sv đã xác định
        Public Function Danh_sach_sinh_vien_can_bo(ByVal arrID_sv As ArrayList) As DataTable
            Try
                Dim obj As New CanBoLop_Bussines
                Dim dtCBL As New DataTable
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(String))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("ID_chuc_danh", GetType(Integer))
                dt.Columns.Add("Chuc_danh", GetType(String))
                dt.Columns.Add("Chuc_danh_kiem", GetType(String))
                dt.Columns.Add("Nam_bat_dau", GetType(Integer))
                dt.Columns.Add("Nam_ket_thuc", GetType(Integer))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    For j As Integer = 0 To arrID_sv.Count - 1
                        Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                        If ds.ID_sv = arrID_sv(j) Then
                            dtCBL = obj.HienThi_ESSCanBoLop_ListID_svs(ds.ID_sv)
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = Format(ds.Ngay_sinh, "dd/MM/yyyy")
                            row("Gioi_tinh") = ds.Gioi_tinh
                            row("Noi_sinh") = ds.Noi_sinh
                            row("Ten_lop") = ds.Ten_lop
                            row("Ten_khoa") = ds.Ten_lop
                            If dtCBL.Rows.Count > 0 Then
                                row("ID_chuc_danh") = IIf(IsDBNull(dtCBL.Rows(0).Item("ID_chuc_danh")), 0, dtCBL.Rows(0).Item("ID_chuc_danh"))
                                row("Chuc_danh") = IIf(IsDBNull(dtCBL.Rows(0).Item("Chuc_danh")), "", dtCBL.Rows(0).Item("Chuc_danh"))
                                row("Chuc_danh_kiem") = IIf(IsDBNull(dtCBL.Rows(0).Item("Chuc_danh_kiem")), "", dtCBL.Rows(0).Item("Chuc_danh_kiem"))
                                row("Nam_bat_dau") = IIf(IsDBNull(dtCBL.Rows(0).Item("Nam_bat_dau")), Year(Now), dtCBL.Rows(0).Item("Nam_bat_dau"))
                                row("Nam_ket_thuc") = IIf(IsDBNull(dtCBL.Rows(0).Item("Nam_ket_thuc")), Year(Now), dtCBL.Rows(0).Item("Nam_ket_thuc"))
                            Else
                                row("ID_chuc_danh") = 0
                                row("Chuc_danh") = ""
                                row("Chuc_danh_kiem") = ""
                                row("Nam_bat_dau") = Year(Now)
                                row("Nam_ket_thuc") = Year(Now)
                            End If
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_TruyCap() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Active", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Mat_khau", GetType(String))
                dt.Columns.Add("Mat_khau_NgaySinh", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Active") = ds.Active
                    row("ID_sv") = ds.ID_sv
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = IIf(ds.Ngay_sinh.Year < 1900, System.DBNull.Value, ds.Ngay_sinh)
                    row("ID_lop") = ds.ID_lop
                    row("Mat_khau") = ds.Mat_khau
                    row("Mat_khau_NgaySinh") = getMat_khau(ds.Ngay_sinh)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachSinhVien_LamThe(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As New DanhSachSinhVien_DataAccess
                Dim dt_ds As DataTable = obj.DanhSachSinhVien_LamThe(ID_lops)
                Dim dt As New DataTable
                dt.Columns.Add("Truong")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Dia_chi_tt")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Noi_tru", GetType(Byte))
                dt.Columns.Add("Ngoai_tru", GetType(Byte))
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Nganh_hoc")
                dt.Columns.Add("CMND")
                dt.Columns.Add("Ngay_cap")
                dt.Columns.Add("Noi_cap")
                dt.Columns.Add("So_the_thu_vien")
                Dim r As DataRow
                For i As Integer = 0 To dt_ds.Rows.Count - 1
                    r = dt.NewRow
                    r("Truong") = ""
                    r("Ho_ten") = dt_ds.Rows(i)("Ho_ten")
                    r("Ngay_sinh") = dt_ds.Rows(i)("Ngay_sinh")
                    r("Dia_chi_tt") = dt_ds.Rows(i)("Dia_chi_tt")
                    r("Ma_sv") = dt_ds.Rows(i)("Ma_sv")
                    If dt_ds.Rows(i)("ID_phong_ktx").ToString <> "" Then r("Noi_tru") = 1
                    If dt_ds.Rows(i)("ID_phong_ktx").ToString = "" Then r("Ngoai_tru") = 1
                    r("Khoa_hoc") = dt_ds.Rows(i)("Khoa_hoc")
                    r("Nganh_hoc") = dt_ds.Rows(i)("Ten_nganh")
                    r("Ten_lop") = dt_ds.Rows(i)("Ten_lop")
                    r("CMND") = dt_ds.Rows(i)("CMND")
                    r("Ngay_cap") = dt_ds.Rows(i)("Ngay_cap")
                    r("Noi_cap") = dt_ds.Rows(i)("Noi_cap")
                    r("So_the_thu_vien") = ""
                    dt.Rows.Add(r)
                Next
                Return objSorted.TableSortHo_ten(dt, False).Table
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function getMat_khau(ByVal Ngay_sinh As Date) As String
            If Ngay_sinh.Year < 1900 Then Return ""
            Dim Ngay, Thang As String
            Ngay = Ngay_sinh.Day
            Thang = Ngay_sinh.Month
            If Ngay.Length <= 1 Then Ngay = "0" & Ngay
            If Thang.Length <= 1 Then Thang = "0" & Thang
            Return Ngay & Thang & Ngay_sinh.Year
        End Function
        'Tính số sinh viên nam
        Public Function So_sv_nam() As Integer
            Dim So_sv As Integer = 0
            Try
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim objDanhSach As ESSDanhSachSinhVien = arrDanhSach(i)
                    If objDanhSach.ID_gioi_tinh = 0 Then
                        So_sv += 1
                    End If
                Next
                Return So_sv
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function So_sv_nu() As Integer
            Dim So_sv As Integer = 0
            Try
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim objDanhSach As ESSDanhSachSinhVien = arrDanhSach(i)
                    If objDanhSach.ID_gioi_tinh = 1 Then
                        So_sv += 1
                    End If
                Next
                Return So_sv
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachSinhVien(ByVal objDanhSachSinhVien As ESSDanhSachSinhVien) As Integer
            Try
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Return obj.ThemMoi_ESSDanhSachSinhVien(objDanhSachSinhVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachSinhVien(ByVal objDanhSachSinhVien As ESSDanhSachSinhVien, ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Return obj.CapNhat_ESSDanhSachSinhVien(objDanhSachSinhVien, ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSsvDanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Return obj.Xoa_ESSDanhSachSinhVien(ID_sv, ID_lop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhSachSinhVien As DataRow) As ESSDanhSachSinhVien
            Dim result As ESSDanhSachSinhVien
            Try
                result = New ESSDanhSachSinhVien
                If drDanhSachSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachSinhVien("ID_sv").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachSinhVien("ID_dt").ToString(), Integer)
                If drDanhSachSinhVien("ID_sv").ToString() = 464249 Then
                    drDanhSachSinhVien("ID_sv") = 464249
                End If
                If drDanhSachSinhVien("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drDanhSachSinhVien("ID_dt2").ToString(), Integer)
                If drDanhSachSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSachSinhVien("ID_lop").ToString(), Integer)
                If drDanhSachSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachSinhVien("ID_gioi_tinh").ToString(), Integer)
                result.Mat_khau = drDanhSachSinhVien("Mat_khau").ToString()
                result.Active = drDanhSachSinhVien("Active").ToString()
                result.Da_tot_nghiep = drDanhSachSinhVien("Da_tot_nghiep").ToString()
                result.Ngoai_ngan_sach = drDanhSachSinhVien("Ngoai_ngan_sach").ToString()
                result.Ten_lop = drDanhSachSinhVien("Ten_lop").ToString()
                result.Ma_sv = drDanhSachSinhVien("Ma_sv").ToString()
                result.Ho_ten = drDanhSachSinhVien("Ho_ten").ToString()
                result.Ho_Dem = drDanhSachSinhVien("Ho_Dem").ToString()
                result.Ten = drDanhSachSinhVien("Ten").ToString()
                result.Ngoai_ngu = drDanhSachSinhVien("Ngoai_ngu").ToString()
                If drDanhSachSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachSinhVien("Ngay_sinh").ToString(), Date)
                result.Gioi_tinh = drDanhSachSinhVien("Gioi_tinh").ToString()
                result.Noi_sinh = drDanhSachSinhVien("Noi_sinh").ToString()
                result.Nien_khoa = drDanhSachSinhVien("Nien_khoa").ToString()
                result.ID_doi_tuong_TC = IIf(drDanhSachSinhVien("ID_doi_tuong_TC").ToString() = "", 0, drDanhSachSinhVien("ID_doi_tuong_TC"))
                result.ID_doi_tuong_TS = IIf(drDanhSachSinhVien("ID_doi_tuong_TS").ToString() = "", 0, drDanhSachSinhVien("ID_doi_tuong_TS"))
                result.Tong_diem = IIf(drDanhSachSinhVien("Tong_diem").ToString() = "", 0, drDanhSachSinhVien("Tong_diem"))
                result.SBD = drDanhSachSinhVien("SBD").ToString()
                result.Dia_chi_tt = drDanhSachSinhVien("Dia_chi_tt").ToString()
                result.Ten_khoa = drDanhSachSinhVien("Ten_khoa").ToString()
                result.CMND = drDanhSachSinhVien("CMND").ToString()
                result.Noi_cap = drDanhSachSinhVien("Noi_cap").ToString()
                If drDanhSachSinhVien("Ngay_cap").ToString() <> "" Then result.Ngay_cap = CType(drDanhSachSinhVien("Ngay_cap").ToString(), Date)
                result.Trang_thai_hoc = drDanhSachSinhVien("Trang_thai_hoc").ToString()
                result.ID_he = IIf(drDanhSachSinhVien("ID_he").ToString() = "", 0, drDanhSachSinhVien("ID_he"))
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Mapping_Nganh2(ByVal drDanhSachSinhVien As DataRow) As ESSDanhSachSinhVien
            Dim result As ESSDanhSachSinhVien
            Try
                result = New ESSDanhSachSinhVien
                If drDanhSachSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachSinhVien("ID_sv").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachSinhVien("ID_dt").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drDanhSachSinhVien("ID_dt2").ToString(), Integer)
                If drDanhSachSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSachSinhVien("ID_lop").ToString(), Integer)
                If drDanhSachSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachSinhVien("ID_gioi_tinh").ToString(), Integer)
                result.Ten_lop = drDanhSachSinhVien("Ten_lop").ToString()
                result.Ma_sv = drDanhSachSinhVien("Ma_sv").ToString()
                result.Ho_ten = drDanhSachSinhVien("Ho_ten").ToString()
                If drDanhSachSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachSinhVien("Ngay_sinh").ToString(), Date)
                result.Gioi_tinh = drDanhSachSinhVien("Gioi_tinh").ToString()
                result.Noi_sinh = drDanhSachSinhVien("Noi_sinh").ToString()
                result.Nien_khoa = drDanhSachSinhVien("Nien_khoa").ToString()
                result.Tong_diem = IIf(drDanhSachSinhVien("Tong_diem").ToString() = "", 0, drDanhSachSinhVien("Tong_diem"))
                result.SBD = drDanhSachSinhVien("SBD").ToString()
                result.Dia_chi_tt = drDanhSachSinhVien("Dia_chi_tt").ToString()
                result.Ten_khoa = drDanhSachSinhVien("Ten_khoa").ToString()
                result.CMND = drDanhSachSinhVien("CMND").ToString()
                result.Noi_cap = drDanhSachSinhVien("Noi_cap").ToString()
                If drDanhSachSinhVien("Ngay_cap").ToString() <> "" Then result.Ngay_cap = CType(drDanhSachSinhVien("Ngay_cap").ToString(), Date)
                result.ID_he = IIf(drDanhSachSinhVien("ID_he").ToString() = "", 0, drDanhSachSinhVien("ID_he"))
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

        ' Danh sách sinh viên không qua convert
        Public Function Danh_sach_sinh_vien(ByVal ID_lops As String) As DataTable
            Try
                If ID_lops = "" Then ID_lops = "0"
                Dim obj As DanhSachSinhVien_DataAccess = New DanhSachSinhVien_DataAccess
                Dim dt As DataTable = obj.HienThi_DanhSach_DanhSachSinhVien_DanhSach(ID_lops)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Danh_sach_sinh_vien_TongHop_HocPhi() As DataTable
            Try
                Dim dt As New DataTable
                Dim Ngay_nhap_hoc, Ngay_ra_truong As String
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("Nien_khoa", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("ID_doi_tuong_TS", GetType(Integer))
                dt.Columns.Add("Tong_diem", GetType(Double))
                dt.Columns.Add("Ngoai_ngan_sach", GetType(Boolean))
                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Chuyen_nganh", GetType(String))
                dt.Columns.Add("Quy_che", GetType(Integer))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Nam_thu", GetType(Integer))
                dt.Columns.Add("Ngay_cap", GetType(Date))
                dt.Columns.Add("Ngay_nhap_hoc", GetType(String))
                dt.Columns.Add("Ngay_ra_truong", GetType(String))
                dt.Columns.Add("Noi_cap", GetType(String))
                dt.Columns.Add("CMND", GetType(String))
                dt.Columns.Add("ID_tinh_TT", GetType(String))
                dt.Columns.Add("Tien_Thua", GetType(Integer))
                dt.Columns.Add("Tien_Thieu", GetType(Integer))
                dt.Columns.Add("Trang_thai_hoc", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("Tien_Thua") = 0
                    row("Tien_Thieu") = 0
                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    If ds.Ngay_sinh <> Nothing Then row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    row("Nien_khoa") = ds.Nien_khoa
                    row("Nam_thu") = ds.Nam_thu
                    row("ID_he") = ds.ID_he
                    row("ID_doi_tuong_TC") = ds.ID_doi_tuong_TC
                    row("ID_doi_tuong_TS") = ds.ID_doi_tuong_TS
                    row("Tong_diem") = ds.Tong_diem
                    row("Ngoai_ngan_sach") = ds.Ngoai_ngan_sach
                    row("SBD") = ds.SBD
                    row("Quy_che") = ds.Quy_che
                    row("Dia_chi_tt") = ds.Dia_chi_tt
                    row("Khoa_hoc") = ds.Khoa_hoc
                    row("Ten_he") = ds.Ten_he
                    row("Ten_nganh") = ds.Ten_nganh
                    row("Chuyen_nganh") = ds.Chuyen_nganh
                    row("CMND") = ds.CMND
                    row("ID_tinh_TT") = ds.ID_tinh_TT
                    row("Trang_thai_hoc") = ds.Trang_thai_hoc
                    If ds.Ngay_cap <> Nothing Then row("Ngay_cap") = ds.Ngay_cap
                    row("Noi_cap") = ds.Noi_cap
                    Try
                        Ngay_nhap_hoc = ds.Nien_khoa.Substring(0, 4)
                        Ngay_ra_truong = ds.Nien_khoa.Substring(5, 4)
                    Catch ex As Exception
                        Ngay_nhap_hoc = ""
                        Ngay_ra_truong = ""
                    End Try
                    row("Ngay_nhap_hoc") = "09/" & Ngay_nhap_hoc
                    row("Ngay_ra_truong") = "08/" & Ngay_ra_truong
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TongHopHocPhiSinhVien_SoDuCuoiKy(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Dim dt As DataTable = obj.TongHopHocPhiSinhVien_SoDuCuoiKy(ID_sv)
                If dt.Rows.Count > 0 Then
                    Return IIf(dt.Rows(0)("So_tien").ToString = "", 0, dt.Rows(0)("So_tien"))
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace