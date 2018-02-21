'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, May 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class TongHopThongKe_Bussines
        Private mdtNganh As DataTable ' Ngành đào tạo
        Private mdtDSSVKhenThuong As DataTable ' Danh sách sinh viên được khen thưởng   
        Private mdtDSSVNganh As DataTable ' Danh sách sinh viên các ngành

        Private mdtDSSVCoCauXaHoi As DataTable ' Danh sach theo mau 1.1  
        Private mdtDSSV As DataTable  ' Danh sách sinh viên

        Private mdtDSSVNuocNgoai As DataTable ' Danh sách sinh viên nước ngoài mẫu M1.2
#Region "Initialize"
        Public Sub New()
            Try

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ' Khen thưởng sinh viên theo khóa học và các lớp được phân quyền
        Public Sub New(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0)
            Dim obj As New TongHopThongKe_DataAccess
            mdtNganh = obj.NganhDaoTao()
            mdtDSSVKhenThuong = obj.DanhSachSinhVienKhenThuong(dsID_lops, ID_he, ID_khoa, Khoa_hoc)
            mdtDSSVNganh = obj.DanhSachSinhVienNganh(dsID_lops, ID_he, ID_khoa, Khoa_hoc)
        End Sub
#End Region

#Region "Functions And Subs"
        'Tổng hợp Danh sách sinh vien học bổng
        Public Function TongHop_HocBong_ToanKhoa(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal ID_lop As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt As New DataTable
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("So_nguoi")
                dt.Columns.Add("So_tien")
                Dim dtDS As DataTable
                dtDS = obj.HienThi_ESSDSSV_HocBong(ID_he, Khoa_hoc, ID_khoa, ID_lop, Hoc_ky, Nam_hoc)
                Dim dv As DataView = dtDS.DefaultView
                dv.Sort = "ID_lop"
                Dim r As DataRow
                Dim temp As Integer = 0
                For i As Integer = 0 To dv.Count - 1
                    If temp <> dv.Item(i)("ID_lop") Then
                        Dim dv1 As DataView = dtDS.Copy.DefaultView
                        Dim So_nguoi As Integer = 0
                        Dim So_tien As Integer = 0
                        dv1.RowFilter = "ID_lop=" & dv.Item(i)("ID_lop")
                        For j As Integer = 0 To dv1.Count - 1
                            So_nguoi += 1
                            So_tien += dv1.Item(j)("Tong_tien")
                        Next
                        r = dt.NewRow
                        r("Ten_lop") = dv.Item(i)("Ten_lop").ToString
                        r("So_nguoi") = Format(So_nguoi, "###,###")
                        r("So_tien") = Format(So_tien, "###,###")
                        dt.Rows.Add(r)
                    End If
                    temp = dv.Item(i)("ID_lop")
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tổng hợp số liệu để xét học bổng 
        Public Function TongHop_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dvLoaiTC As DataView
                dvLoaiTC = obj.HienThi_ESSLoai_TroCap(Hoc_ky, Nam_hoc).DefaultView
                Dim dtNganh As DataTable = obj.HienThi_ESSDSNganh(ID_he, Khoa_hoc)
                Dim dvLoaiHB As DataView
                dvLoaiHB = obj.HienThi_ESSHocBong().DefaultView
                Dim dtDSSV_nganh As DataTable = obj.HienThi_ESSDSSV_TheoNganh(ID_he, Khoa_hoc)
                Dim dtTH As DataTable = obj.HienThi_ESSTongHop_HocBong(ID_he, Khoa_hoc, Hoc_ky, Nam_hoc)
                Dim dt As New DataTable
                dt.Columns.Add("Ten_nganh")
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Tong_sv_nganh")
                dt.Columns.Add("Tong_sv_HB")
                dt.Columns.Add("Tong_tien_HB", GetType(Double))
                dt.Columns.Add("So_sv_HB_XS")
                dt.Columns.Add("So_sv_HB_Gioi")
                dt.Columns.Add("So_sv_HB_Kha")
                dt.Columns.Add("So_sv_HBCS1")
                dt.Columns.Add("So_sv_HBCS2")
                dt.Columns.Add("So_sv_HBCS3")
                dt.Columns.Add("So_tien_xs", GetType(Double))
                dt.Columns.Add("So_tien_gioi", GetType(Double))
                dt.Columns.Add("So_tien_kha", GetType(Double))
                dt.Columns.Add("So_tien_cs1", GetType(Double))
                dt.Columns.Add("So_tien_cs2", GetType(Double))
                dt.Columns.Add("So_tien_cs3", GetType(Double))
                Dim r As DataRow
                For i As Integer = 0 To dtNganh.Rows.Count - 1
                    r = dt.NewRow
                    r("Ten_nganh") = dtNganh.Rows(i)("Ten_nganh").ToString
                    r("Khoa_hoc") = dtNganh.Rows(i)("Khoa_hoc").ToString
                    ' So tien hoc bong
                    dvLoaiHB.RowFilter = " ID_xep_loai_hb=1"
                    r("So_tien_xs") = Format(dvLoaiHB.Item(0)("HB_HT"), "###,###")
                    dvLoaiHB.RowFilter = " ID_xep_loai_hb=2"
                    r("So_tien_gioi") = Format(dvLoaiHB.Item(0)("HB_HT"), "###,###")
                    dvLoaiHB.RowFilter = " ID_xep_loai_hb=3"
                    r("So_tien_kha") = Format(dvLoaiHB.Item(0)("HB_HT"), "###,###")
                    ' Tong so sinh vien nganh
                    Dim dk As String = "1=1 "
                    dk += " And ID_nganh=" & dtNganh.Rows(i)("ID_nganh") & " And Khoa_hoc=" & dtNganh.Rows(i)("Khoa_hoc")
                    dtDSSV_nganh.DefaultView.RowFilter = dk
                    If dtDSSV_nganh.DefaultView.Count > 0 Then r("Tong_sv_nganh") = dtDSSV_nganh.DefaultView.Count
                    ' Tong so sv duoc huong hoc bong theo nganh
                    dtTH.DefaultView.RowFilter = dk
                    If dtTH.DefaultView.Count > 0 Then r("Tong_sv_HB") = dtTH.DefaultView.Count
                    ' Tong so tien hoc bong
                    Dim Tong_tien_HB As Double = 0
                    For j As Integer = 0 To dtTH.DefaultView.Count - 1
                        Tong_tien_HB += IIf(dtTH.DefaultView.Item(j)("HB_HT").ToString = "", 0, dtTH.DefaultView.Item(j)("HB_HT")) + IIf(dtTH.DefaultView.Item(j)("HB_CS").ToString = "", 0, dtTH.DefaultView.Item(j)("HB_CS"))
                    Next
                    If Tong_tien_HB > 0 Then r("Tong_tien_HB") = Format(Tong_tien_HB, "###,###")
                    ' Dem so sv Xep Loai XS
                    Dim dk_sx As String = ""
                    dk_sx = dk & " And ID_xep_loai_hb=1"
                    dtTH.DefaultView.RowFilter = dk_sx
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HB_XS") = dtTH.DefaultView.Count
                    ' Dem so sv Xep Loai gioi
                    Dim dk_gioi As String = ""
                    dk_gioi = dk & " And ID_xep_loai_hb=2"
                    dtTH.DefaultView.RowFilter = dk_gioi
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HB_Gioi") = dtTH.DefaultView.Count
                    ' Dem so sv Xep Loai kha
                    Dim dk_kha As String = ""
                    dk_kha = dk & " And ID_xep_loai_hb=3"
                    dtTH.DefaultView.RowFilter = dk_kha
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HB_Kha") = dtTH.DefaultView.Count
                    ' Dem so sv duoc tro cap
                    Dim So_tien_cs1 As Double = 0
                    Dim So_tien_cs2 As Double = 0
                    Dim So_tien_cs3 As Double = 0
                    If dvLoaiTC.Count >= 3 Then
                        So_tien_cs1 = dvLoaiTC.Item(0)("Sotien_trocap")
                        So_tien_cs2 = dvLoaiTC.Item(1)("Sotien_trocap")
                        So_tien_cs3 = dvLoaiTC.Item(2)("Sotien_trocap")
                    ElseIf dvLoaiTC.Count >= 2 Then
                        So_tien_cs1 = dvLoaiTC.Item(0)("Sotien_trocap")
                        So_tien_cs2 = dvLoaiTC.Item(1)("Sotien_trocap")
                    ElseIf dvLoaiTC.Count = 2 Then
                        So_tien_cs1 = dvLoaiTC.Item(0)("Sotien_trocap")
                    End If
                    If So_tien_cs1 > 0 Then r("So_tien_cs1") = Format(So_tien_cs1, "###,###")
                    If So_tien_cs2 > 0 Then r("So_tien_cs2") = Format(So_tien_cs2, "###,###")
                    If So_tien_cs3 > 0 Then r("So_tien_cs3") = Format(So_tien_cs3, "###,###")

                    Dim dk_tc As String = ""
                    dk_tc = dk & " And HB_CS=" & So_tien_cs1
                    dtTH.DefaultView.RowFilter = dk_tc
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HBCS1") = dtTH.DefaultView.Count
                    dk_tc = dk & " And HB_CS=" & So_tien_cs2
                    dtTH.DefaultView.RowFilter = dk_tc
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HBCS2") = dtTH.DefaultView.Count
                    dk_tc = dk & " And HB_CS=" & So_tien_cs3
                    dtTH.DefaultView.RowFilter = dk_tc
                    If dtTH.DefaultView.Count > 0 Then r("So_sv_HBCS3") = dtTH.DefaultView.Count
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Tổng hợp Danh sách sinh vien học bổng
        Public Function TongHop_DSSV_HocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal ID_lop As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt, dt1 As New DataTable
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Ma_dt_hb")
                dt.Columns.Add("So_thang")
                dt.Columns.Add("HB_HT")
                dt.Columns.Add("HB_CS")
                dt.Columns.Add("Tong_tien")
                dt.Columns.Add("Tong_HB_HT")
                dt.Columns.Add("Tong_HB_CS")
                dt.Columns.Add("Label_HBCS") ' Nhãn học bổng chính sách 5 tháng 7 tháng
                dt1 = obj.HienThi_ESSDSSV_HocBong(ID_he, Khoa_hoc, ID_khoa, ID_lop, Hoc_ky, Nam_hoc)
                Dim Tong_HB_HT As Double = 0
                Dim Tong_HB_CS As Double = 0
                Dim r As DataRow
                For i As Integer = 0 To dt1.Rows.Count - 1
                    r = dt.NewRow
                    r("ID_sv") = dt1.Rows(i)("ID_sv").ToString
                    r("Ho_ten") = dt1.Rows(i)("Ho_ten").ToString
                    r("ID_lop") = dt1.Rows(i)("ID_lop")
                    r("Ten_lop") = dt1.Rows(i)("Ten_lop").ToString
                    r("Ma_dt_hb") = dt1.Rows(i)("Ma_dt_hb").ToString
                    r("So_thang") = dt1.Rows(i)("So_thang")
                    r("HB_HT") = Format(dt1.Rows(i)("HB_HT"), "###,###")
                    r("HB_CS") = Format(dt1.Rows(i)("HB_CS"), "###,###")
                    r("Tong_tien") = Format(dt1.Rows(i)("Tong_tien"), "###,###")
                    Tong_HB_HT += dt1.Rows(i)("HB_HT")
                    Tong_HB_CS += dt1.Rows(i)("HB_CS")
                    If Hoc_ky = 1 Then
                        r("Label_HBCS") = "( 7 tháng )"
                    Else
                        r("Label_HBCS") = "( 5 tháng )"
                    End If
                    dt.Rows.Add(r)
                Next
                If Tong_HB_HT > 0 Then dt.Rows(dt.Rows.Count - 1)("Tong_HB_HT") = Format(Tong_HB_HT, "###,###")
                If Tong_HB_CS > 0 Then dt.Rows(dt.Rows.Count - 1)("Tong_HB_CS") = Format(Tong_HB_CS, "###,###")
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Tổng hợp số liệu để xét học bổng 
        Public Function TongHop_SoLieu_XetHocBong(ByVal ID_he As Integer, ByVal Khoa_hoc As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dtNganh As DataTable = obj.HienThi_ESSDSNganh(ID_he, Khoa_hoc)
                Dim dtDSSV_nganh As DataTable = obj.HienThi_ESSDSSV_TheoNganh(ID_he, Khoa_hoc)
                Dim dtDS_TC As DataTable = obj.HienThi_ESSDSSV_TroCap(ID_he, Khoa_hoc, Hoc_ky, Nam_hoc)
                Dim dt As New DataTable
                dt.Columns.Add("ID_nganh")
                dt.Columns.Add("Ten_nganh")
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("So_sv")
                dt.Columns.Add("So_sv_tc")
                dt.Columns.Add("So_sv_chia_hb")
                dt.Columns.Add("So_tien_tc")
                Dim r As DataRow
                For i As Integer = 0 To dtNganh.Rows.Count - 1
                    r = dt.NewRow
                    dtDSSV_nganh.DefaultView.RowFilter = " ID_nganh=" & dtNganh.Rows(i)("ID_nganh") & " And Khoa_hoc=" & dtNganh.Rows(i)("Khoa_hoc")
                    Dim So_sv As Integer = dtDSSV_nganh.DefaultView.Count
                    dtDS_TC.DefaultView.RowFilter = " ID_nganh=" & dtNganh.Rows(i)("ID_nganh") & " And Khoa_hoc=" & dtNganh.Rows(i)("Khoa_hoc")
                    Dim So_sv_tc As Integer = dtDS_TC.DefaultView.Count
                    Dim So_sv_chia_hb As Integer = So_sv - So_sv_tc
                    r("ID_nganh") = dtNganh.Rows(i)("ID_nganh")
                    r("Ten_nganh") = dtNganh.Rows(i)("Ten_nganh")
                    r("Khoa_hoc") = dtNganh.Rows(i)("Khoa_hoc")
                    r("So_sv") = So_sv
                    r("So_sv_tc") = So_sv_tc
                    r("So_sv_chia_hb") = So_sv_chia_hb
                    Dim So_tien_tc As Double = 0
                    For j As Integer = 0 To dtDS_TC.DefaultView.Count - 1
                        So_tien_tc += dtDS_TC.DefaultView.Item(j)("Sotien_trocap")
                    Next
                    r("So_tien_tc") = Format(So_tien_tc, "###,###")
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Khoa_Khoa_Hoc() As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Return obj.Khoa_Khoa_Hoc()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thong ke danh sach mien giam hoc phis
        Public Function DanhMuc_DoiTuong_Mien_giam() As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dv As DataView
                dv = obj.HienThi_ESSDanhMuc_DoiTuong().DefaultView
                dv.Sort = "Ma_dt"
                Dim dt As New DataTable
                dt.Columns.Add("Ma_dt")
                dt.Columns.Add("Ten_dt")
                dt.Columns.Add("Phan_tram")
                For i As Integer = 0 To dv.Count - 1
                    Dim r As DataRow
                    r = dt.NewRow
                    r("Ma_dt") = dv.Item(i)("Ma_dt").ToString
                    r("Ten_dt") = dv.Item(i)("Ten_dt").ToString
                    r("Phan_tram") = dv.Item(i)("Phan_tram_mien_giam").ToString
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thong ke danh sach mien giam hoc phis
        Public Function ThongKe_miengiam(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_doi_tuong As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dv As DataView
                dv = obj.HienThi_ESSDS_MienGiam(ID_he, ID_khoa, Khoa_hoc).DefaultView
                Dim dk As String = "1=1"
                If ID_he > 0 Then dk += " And ID_he=" & ID_he
                If ID_khoa > 0 Then dk += " And ID_khoa=" & ID_khoa
                If Khoa_hoc > 0 Then dk += " And Khoa_hoc=" & Khoa_hoc
                If ID_doi_tuong > 0 Then dk += " And ID_doi_tuong_TS=" & ID_doi_tuong
                If Hoc_ky > 0 Then dk += " And Hoc_ky=" & Hoc_ky
                If Nam_hoc.ToString <> "" Then dk += " And Nam_hoc='" & Nam_hoc & "'"
                dv.RowFilter = dk
                dv.Sort = "ID_sv"
                Dim dt As New DataTable
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Ma_dt")
                dt.Columns.Add("Phan_tram")
                dt.Columns.Add("Ten_khoa")
                For i As Integer = 0 To dv.Count - 1
                    Dim r As DataRow
                    r = dt.NewRow
                    r("Ma_sv") = dv.Item(i)("Ma_sv").ToString
                    r("Ho_ten") = dv.Item(i)("Ho_ten").ToString
                    r("Ngay_sinh") = dv.Item(i)("Ngay_sinh").ToString
                    r("Ten_lop") = dv.Item(i)("Ten_lop").ToString
                    r("Ma_dt") = dv.Item(i)("Ma_dt").ToString
                    r("Phan_tram") = dv.Item(i)("Phan_tram_mien_giam").ToString
                    r("Ten_khoa") = dv.Item(i)("Ten_khoa").ToString
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê số lượng sinh viên theo khoa
        Public Function ThongKe_SoLuong_SV(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dv As DataView
                dv = obj.DanhSach_SinhVien().DefaultView
                Dim dt_khoa As DataTable
                dt_khoa = obj.DM_Khoa()
                dt_khoa.Columns.Add("Khoa_hoc")
                dt_khoa.Columns.Add("So_luong")
                For i As Integer = dt_khoa.Rows.Count - 1 To 0 Step -1
                    dv.RowFilter = "ID_he=" & ID_he & " and Khoa_hoc=" & Khoa_hoc & " and ID_khoa=" & dt_khoa.Rows(i)("ID_khoa")
                    If dv.Count = 0 Then
                        dt_khoa.Rows(i).Delete()
                    Else
                        dt_khoa.Rows(i)("Khoa_hoc") = Khoa_hoc
                        dt_khoa.Rows(i)("So_luong") = dv.Count
                    End If
                Next
                dt_khoa.AcceptChanges()
                Return dt_khoa
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên khen thưởng theo ngành đào tạo M3.1
        Public Function ThongKe_SinhVienKhenThuong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Ma_nganh", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("TongSV_Nganh", GetType(String))
                dt.Columns.Add("TongSV_KhenThuong", GetType(String))
                dt.Columns.Add("TongSV_Nam", GetType(String))
                dt.Columns.Add("TongSV_Nu", GetType(String))
                dt.Columns.Add("TongSV_DanToc", GetType(String))
                dt.Columns.Add("TongSV_KT_CBo", GetType(String))
                dt.Columns.Add("TongSV_KT_CTruong", GetType(String))
                dt.Columns.Add("TongSV_KT_CQuanHuyen", GetType(String))
                dt.Columns.Add("TongSV_KT_CThanhPho", GetType(String))
                dt.Columns.Add("TongSV_KT_CQuocGia", GetType(String))
                dt.Columns.Add("TongSV_KT_CQuocGiaTCNN", GetType(String))
                For i As Integer = 0 To mdtNganh.Rows.Count - 1
                    Dim dk As String = "1=1"
                    Dim dv As New DataView
                    dv = mdtDSSVNganh.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    dk += " And Ma_nganh=" & mdtNganh.Rows(i).Item("Ma_nganh").ToString
                    dv.RowFilter = dk
                    Dim row As DataRow
                    row = dt.NewRow
                    row("Ma_nganh") = mdtNganh.Rows(i).Item("Ma_nganh").ToString
                    row("Ten_nganh") = mdtNganh.Rows(i).Item("Ten_nganh").ToString
                    row("TongSV_Nganh") = IIf(dv.Count = 0, "", dv.Count)
                    ' Lọc số sinh viên được khen thưởng theo từng ngành
                    Dim dvKT As New DataView
                    dvKT = mdtDSSVKhenThuong.DefaultView
                    dvKT.RowFilter = dk
                    row("TongSV_KhenThuong") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' Lọc giới tính
                    Dim dkGT As String = ""
                    dkGT = dk & " And Gioi_tinh='Nam'"
                    dvKT.RowFilter = dkGT
                    row("TongSV_Nam") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    dkGT = dk & " And Gioi_tinh='Nữ'"
                    dvKT.RowFilter = dkGT
                    row("TongSV_Nu") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' Lọc dân tộc                    
                    Dim dkDT As String = ""
                    dkDT = dk & " And (Dan_toc<>'Kinh')"
                    dvKT.RowFilter = dkDT
                    row("TongSV_DanToc") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' Lọc theo cấp khen thưởng                     
                    Dim dkCKT As String = ""
                    ' cấp trường
                    dkCKT = dk & " And ID_cap=1"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CTruong") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' cấp bộ
                    dkCKT = dk & " And ID_cap=2"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CBo") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' cấp Quận huyện
                    dkCKT = dk & " And ID_cap=3"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CQuanHuyen") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' cấp Thành phố
                    dkCKT = dk & " And ID_cap=4"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CThanhPho") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' cấp Quốc gia
                    dkCKT = dk & " And ID_cap=5"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CQuocGia") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    ' cấp Quốc gia tổ chức nước ngoài
                    dkCKT = dk & " And ID_cap=6"
                    dvKT.RowFilter = dkCKT
                    row("TongSV_KT_CQuocGiaTCNN") = IIf(dvKT.Count = 0, "", dvKT.Count)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê tập thể được khen thưởng mẫu M3.2
        Public Function ThongKe_TapTheKhenThuong(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dvTT As DataView
                dvTT = obj.TapTheKhenThuong(dsID_lops, ID_he, ID_khoa, Khoa_hoc).DefaultView
                Dim dt As New DataTable
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TongSV_lop", GetType(String))
                dt.Columns.Add("LyDo_CTruong", GetType(String))
                dt.Columns.Add("LyDo_CBo", GetType(String))
                dt.Columns.Add("LyDo_CQuanHuyen", GetType(String))
                dt.Columns.Add("LyDo_CThanhPho", GetType(String))
                dt.Columns.Add("LyDo_CQuocGia", GetType(String))
                dt.Columns.Add("LyDo_CQuocGiaTCNN", GetType(String))
                Dim row As DataRow
                For i As Integer = 0 To dvTT.Count - 1
                    row = dt.NewRow
                    row("Ten_lop") = dvTT.Item(i)("Ten_lop")
                    Dim cls As New DanhSachSinhVien_Bussines(dvTT.Item(i)("ID_lop"))
                    Dim dt_sv As DataTable = cls.Danh_sach_sinh_vien()
                    row("TongSV_lop") = dt_sv.Rows.Count
                    If dvTT.Item(i)("ID_cap") = 1 Then row("LyDo_CTruong") = dvTT.Item(i)("Ly_do")
                    If dvTT.Item(i)("ID_cap") = 2 Then row("LyDo_CBo") = dvTT.Item(i)("Ly_do")
                    If dvTT.Item(i)("ID_cap") = 3 Then row("LyDo_CQuanHuyen") = dvTT.Item(i)("Ly_do")
                    If dvTT.Item(i)("ID_cap") = 4 Then row("LyDo_CThanhPho") = dvTT.Item(i)("Ly_do")
                    If dvTT.Item(i)("ID_cap") = 5 Then row("LyDo_CQuocGia") = dvTT.Item(i)("Ly_do")
                    If dvTT.Item(i)("ID_cap") = 6 Then row("LyDo_CQuocGiaTCNN") = dvTT.Item(i)("Ly_do")
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên bị kỷ luật mẫu M4.1
        Public Function ThongKe_SinhVienKyLuat1(ByVal dsID_lops As String) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dtSVKyLuat As DataTable
                Dim dtHTXuLy As DataTable
                dtSVKyLuat = obj.DanhSachSinhVienKyLuat(dsID_lops)
                dtHTXuLy = obj.HinhThuc_XuLy()

                Dim dt As New DataTable
                dt.Columns.Add("Hinh_thuc_xu_ly", GetType(String))
                dt.Columns.Add("Tong_SV_ViPham", GetType(String))
                dt.Columns.Add("Tong_LienQuan_MT", GetType(String))
                dt.Columns.Add("Tong_SuDung_MT", GetType(String))
                dt.Columns.Add("Tong_CuopCua_GN", GetType(String))
                dt.Columns.Add("Tong_LD_TL", GetType(String))
                dt.Columns.Add("Tong_DNTC_BBHQC", GetType(String))
                dt.Columns.Add("Tong_LGTG", GetType(String))
                dt.Columns.Add("Tong_DuaXe", GetType(String))
                dt.Columns.Add("Tong_ThamGia_MD", GetType(String))
                dt.Columns.Add("Tong_DDMD", GetType(String))
                dt.Columns.Add("Tong_ViPham_Khac", GetType(String))
                For i As Integer = 0 To dtHTXuLy.Rows.Count - 1
                    Dim dk As String = "1=1 "
                    Dim dv As New DataView
                    dv = dtSVKyLuat.DefaultView
                    Dim row As DataRow
                    row = dt.NewRow
                    ' Hình thức xử lý
                    row("Hinh_thuc_xu_ly") = dtHTXuLy.Rows(i).Item("Xu_ly")
                    ' tổng sinh viên vi phạm                    
                    dk += " And ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dv.RowFilter = dk
                    row("Tong_SV_ViPham") = IIf(dv.Count = 0, "", dv.Count)
                    ' Liên quan ma tuy
                    dk += " And Ma_hanh_vi='LQMT'"
                    dv.RowFilter = dk
                    row("Tong_LienQuan_MT") = IIf(dv.Count = 0, "", dv.Count)
                    ' Dùng ma tuy
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='SDMT'"
                    dv.RowFilter = dk
                    row("Tong_SuDung_MT") = IIf(dv.Count = 0, "", dv.Count)
                    ' Cướp của giết người
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='CCGN'"
                    dv.RowFilter = dk
                    row("Tong_CuopCua_GN") = IIf(dv.Count = 0, "", dv.Count)
                    ' Lừa đảo trấn lột
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='LDTL'"
                    dv.RowFilter = dk
                    row("Tong_LD_TL") = IIf(dv.Count = 0, "", dv.Count)
                    ' Đánh nhau trộm cấp bb hàng quốc cấm
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And (Ma_hanh_vi='DN' Or Ma_hanh_vi='TC' Or Ma_hanh_vi='BBHQC')"
                    dv.RowFilter = dk
                    row("Tong_DNTC_BBHQC") = IIf(dv.Count = 0, "", dv.Count)
                    ' Làm giấy tờ giả
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='LGTG'"
                    dv.RowFilter = dk
                    row("Tong_LGTG") = IIf(dv.Count = 0, "", dv.Count)
                    ' Đua xe
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='DX'"
                    dv.RowFilter = dk
                    row("Tong_DuaXe") = IIf(dv.Count = 0, "", dv.Count)
                    ' Tham gia mại dâm
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='TGMD'"
                    dv.RowFilter = dk
                    row("Tong_ThamGia_MD") = IIf(dv.Count = 0, "", dv.Count)
                    ' Dẫn dắt mại dâm
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi='DDMD'"
                    dv.RowFilter = dk
                    row("Tong_DDMD") = IIf(dv.Count = 0, "", dv.Count)
                    ' Dẫn dắt mại dâm
                    dk = "ID_xu_ly=" & dtHTXuLy.Rows(i).Item("ID_xu_ly")
                    dk += " And Ma_hanh_vi <> 'DDMD' AND Ma_hanh_vi <> 'TGMD' AND Ma_hanh_vi <> 'DX' AND Ma_hanh_vi <> 'LGTG' AND Ma_hanh_vi <> 'DN' AND Ma_hanh_vi <> 'TC' AND Ma_hanh_vi <> 'BBHQC' AND Ma_hanh_vi <> 'LDTL' AND Ma_hanh_vi <> 'CCGN' AND Ma_hanh_vi <> 'TGMD' AND Ma_hanh_vi <> 'SDMT' AND Ma_hanh_vi <> 'LQMT'"
                    dv.RowFilter = dk
                    row("Tong_ViPham_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienKyLuat(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dtSVKyLuat As DataTable
                Dim dtHTXuLy As DataTable
                dtSVKyLuat = obj.DanhSachSinhVienKyLuat(dsID_lops, ID_he, ID_khoa, Khoa_hoc)
                dtHTXuLy = obj.HinhThuc_XuLy()
                Dim dt As New DataTable
                dt.Columns.Add("Hinh_thuc_xu_ly", GetType(String))
                dt.Columns.Add("Tong_SV_ViPham", GetType(String))
                dt.Columns.Add("Tong_LienQuan_MT", GetType(String))
                dt.Columns.Add("Tong_SuDung_MT", GetType(String))
                dt.Columns.Add("Tong_CuopCua_GN", GetType(String))
                dt.Columns.Add("Tong_LD_TL", GetType(String))
                dt.Columns.Add("Tong_DNTC_BBHQC", GetType(String))
                dt.Columns.Add("Tong_LGTG", GetType(String))
                dt.Columns.Add("Tong_DuaXe", GetType(String))
                dt.Columns.Add("Tong_ThamGia_MD", GetType(String))
                dt.Columns.Add("Tong_DDMD", GetType(String))
                dt.Columns.Add("Tong_ViPham_Khac", GetType(String))
                For i As Integer = 0 To dtHTXuLy.Rows.Count - 1
                    ' Đếm 
                    Dim Tong_SV_ViPham As Integer = 0
                    Dim Tong_LienQuan_MT As Integer = 0
                    Dim Tong_SuDung_MT As Integer = 0
                    Dim Tong_CuopCua_GN As Integer = 0
                    Dim Tong_LD_TL As Integer = 0
                    Dim Tong_DNTC_BBHQC As Integer = 0
                    Dim Tong_LGTG As Integer = 0
                    Dim Tong_DuaXe As Integer = 0
                    Dim Tong_ThamGia_MD As Integer = 0
                    Dim Tong_DDMD As Integer = 0
                    Dim Tong_ViPham_Khac As Integer = 0
                    Dim r As DataRow
                    For Each r In dtSVKyLuat.Rows
                        If r("ID_xu_ly") = dtHTXuLy.Rows(i).Item("ID_xu_ly") Then
                            Tong_SV_ViPham += 1
                            If r("Ma_hanh_vi").ToString = "LQMT" Then Tong_LienQuan_MT += 1
                            If r("Ma_hanh_vi").ToString = "SDMT" Then Tong_SuDung_MT += 1
                            If r("Ma_hanh_vi").ToString = "CCGN" Then Tong_CuopCua_GN += 1
                            If r("Ma_hanh_vi").ToString = "LDTL" Then Tong_LD_TL += 1
                            If r("Ma_hanh_vi").ToString = "DN" Or r("Ma_hanh_vi").ToString = "TC" Or r("Ma_hanh_vi").ToString = "BBHQC" Then Tong_DNTC_BBHQC += 1
                            If r("Ma_hanh_vi").ToString = "LGTG" Then Tong_LGTG += 1
                            If r("Ma_hanh_vi").ToString = "DX" Then Tong_DuaXe += 1
                            If r("Ma_hanh_vi").ToString = "TGMD" Then Tong_ThamGia_MD += 1
                            If r("Ma_hanh_vi").ToString = "DDMD" Then Tong_DDMD += 1
                            If r("Ma_hanh_vi").ToString <> "DDMD" And r("Ma_hanh_vi").ToString <> "TGMD" And r("Ma_hanh_vi").ToString <> "DX" And r("Ma_hanh_vi").ToString <> "LGTG" And r("Ma_hanh_vi").ToString <> "DN" And r("Ma_hanh_vi").ToString <> "TC" And r("Ma_hanh_vi").ToString <> "BBHQC" And r("Ma_hanh_vi").ToString <> "LDTL" And r("Ma_hanh_vi").ToString <> "CCGN" And r("Ma_hanh_vi").ToString <> "SDMT" And r("Ma_hanh_vi").ToString <> "LQMT" Then Tong_ViPham_Khac += 1
                        End If
                    Next
                    Dim row As DataRow
                    row = dt.NewRow
                    ' Hình thức xử lý
                    row("Hinh_thuc_xu_ly") = dtHTXuLy.Rows(i).Item("Xu_ly")
                    ' tổng sinh viên vi phạm                    
                    row("Tong_SV_ViPham") = IIf(Tong_SV_ViPham = 0, "", Tong_SV_ViPham)
                    ' Liên quan ma tuy
                    row("Tong_LienQuan_MT") = IIf(Tong_LienQuan_MT = 0, "", Tong_LienQuan_MT)
                    ' Dùng ma tuy                    
                    row("Tong_SuDung_MT") = IIf(Tong_SuDung_MT = 0, "", Tong_SuDung_MT)
                    ' Cướp của giết người
                    row("Tong_CuopCua_GN") = IIf(Tong_CuopCua_GN = 0, "", Tong_CuopCua_GN)
                    ' Lùa đảo
                    row("Tong_LD_TL") = IIf(Tong_LD_TL = 0, "", Tong_LD_TL)
                    ' Đánh nhau trộm cấp bb hàng quốc cấm
                    row("Tong_DNTC_BBHQC") = IIf(Tong_DNTC_BBHQC = 0, "", Tong_DNTC_BBHQC)
                    ' Làm giấy tờ giả
                    row("Tong_LGTG") = IIf(Tong_LGTG = 0, "", Tong_LGTG)
                    ' Đua xe
                    row("Tong_DuaXe") = IIf(Tong_DuaXe = 0, "", Tong_DuaXe)
                    ' Tham gia mại dâm
                    row("Tong_ThamGia_MD") = IIf(Tong_ThamGia_MD = 0, "", Tong_ThamGia_MD)
                    ' Dẫn dắt mại dâm
                    row("Tong_DDMD") = IIf(Tong_DDMD = 0, "", Tong_DDMD)
                    ' Dẫn dắt mại dâm
                    row("Tong_ViPham_Khac") = IIf(Tong_ViPham_Khac = 0, "", Tong_ViPham_Khac)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê danh sách sinh viên bị kỷ luật mẫu M4.2
        Public Function ThongKe_DSSinhVienKyLuat(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dtSVKyLuat As DataTable
                dtSVKyLuat = obj.DanhSachSinhVienKyLuat(dsID_lops, ID_he, ID_khoa, Khoa_hoc)
                Dim dt As New DataTable
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Nam", GetType(String))
                dt.Columns.Add("Nu", GetType(String))
                dt.Columns.Add("Dan_toc", GetType(String))
                dt.Columns.Add("Doi_tuong_CS", GetType(String))
                dt.Columns.Add("Que_quan", GetType(String))
                dt.Columns.Add("Nganh_hoc", GetType(String))
                dt.Columns.Add("Noi_dung_vi_pham", GetType(String))
                dt.Columns.Add("Hinh_thuc_xu_ly", GetType(String))
                Dim r As DataRow
                For Each r In dtSVKyLuat.Rows
                    Dim row As DataRow
                    row = dt.NewRow
                    row("Ho_ten") = r("Ho_ten").ToString
                    row("Ngay_sinh") = r("Ngay_sinh")
                    If r("Gioi_tinh") = "Nam" Then
                        row("Nam") = "Nam"
                        row("Nu") = ""
                    Else
                        row("Nu") = "Nữ"
                        row("Nam") = ""
                    End If
                    row("Dan_toc") = r("Dan_toc").ToString
                    row("Doi_tuong_CS") = r("Ten_dt").ToString
                    row("Que_quan") = r("Ten_tinh").ToString
                    row("Nganh_hoc") = r("Ten_nganh").ToString
                    row("Noi_dung_vi_pham") = r("Hanh_vi").ToString
                    row("Hinh_thuc_xu_ly") = r("Xu_ly").ToString
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê DANH SÁCH HỌC SINH, SINH VIÊN LIÊN QUAN ĐẾN TỆ NẠN MA TUÝ mẫu M4.3
        Public Function ThongKe_DSSV_LienQuan_MaTuy(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dVSVKyLuat As DataView
                dVSVKyLuat = obj.DanhSachSinhVienKyLuat(dsID_lops, ID_he, ID_khoa, Khoa_hoc).DefaultView
                ' Lọc sinh viên liên quan đến ma túy
                Dim dk As String = "1=1"
                dk += " And (Ma_hanh_vi='SDMT' OR Ma_hanh_vi='TTMT' OR Ma_hanh_vi='BBMT')"
                dVSVKyLuat.RowFilter = dk
                Dim dt As New DataTable
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Dan_toc", GetType(String))
                dt.Columns.Add("SDMT", GetType(String))
                dt.Columns.Add("TTMT", GetType(String))
                dt.Columns.Add("BBMT", GetType(String))
                dt.Columns.Add("NghiHoc_CaiNghien", GetType(String))
                dt.Columns.Add("Dinh_chi", GetType(String))
                dt.Columns.Add("Thoi_hoc", GetType(String))
                dt.Columns.Add("TruyCuu_HinhSu", GetType(String))
                dt.Columns.Add("Ngay_xu_ly", GetType(Date))
                For i As Integer = 0 To dVSVKyLuat.Count - 1
                    Dim row As DataRow
                    row = dt.NewRow
                    row("Ho_ten") = dVSVKyLuat.Item(i)("Ho_ten").ToString
                    row("Ngay_sinh") = dVSVKyLuat.Item(i)("Ngay_sinh")
                    row("Gioi_tinh") = dVSVKyLuat.Item(i)("Gioi_tinh").ToString
                    row("Dan_toc") = dVSVKyLuat.Item(i)("Dan_toc").ToString
                    If dVSVKyLuat.Item(i)("Ma_hanh_vi").ToString = "SDMT" Then row("SDMT") = "V"
                    If dVSVKyLuat.Item(i)("Ma_hanh_vi").ToString = "TTMT" Then row("TTMT") = "V"
                    If dVSVKyLuat.Item(i)("Ma_hanh_vi").ToString = "BBMT" Then row("BBMT") = "V"
                    If dVSVKyLuat.Item(i)("Xu_ly").ToString = "Nghỉ học cai nghiện" Then row("NghiHoc_CaiNghien") = "V"
                    If dVSVKyLuat.Item(i)("Xu_ly").ToString = "Đình chỉ" Then row("Dinh_chi") = "V"
                    If dVSVKyLuat.Item(i)("Xu_ly").ToString = "Thôi học" Then row("Thoi_hoc") = "V"
                    If dVSVKyLuat.Item(i)("Xu_ly").ToString = "Truy cứu hình sự" Then row("TruyCuu_HinhSu") = "V"
                    row("Ngay_xu_ly") = dVSVKyLuat.Item(i)("Ngay_QD").ToString
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Biến động sinh viên M5.1
        Public Function ThongKe_BienDong_SinhVien_NEW(Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim mdtDSSVThoiHoc As DataTable
                mdtDSSVThoiHoc = obj.DanhSach_SinhVienThoiHoc_NEW(ID_he, ID_khoa, Khoa_hoc) ' Danh sác sv thôi học , ngừng học, nghỉ học, chuyển trường
                ' dt Phân loại biến động
                Dim dtPL As New DataTable
                dtPL.Columns.Add("Phan_loai", GetType(String))
                dtPL.Columns.Add("Ly_do", GetType(String))
                Dim r As DataRow
                r = dtPL.NewRow
                r("Phan_loai") = "Thôi học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Nghỉ học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Ngừng học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Lưu ban"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Chuyển trường"
                dtPL.Rows.Add(r)
                ' dt Thongke biến động
                Dim dt As New DataTable
                dt.Columns.Add("Phan_loai", GetType(String))
                dt.Columns.Add("Tong_HSSV", GetType(String))
                dt.Columns.Add("TongSV_DTCS", GetType(String))
                dt.Columns.Add("TongSV_CongNhan", GetType(String))
                dt.Columns.Add("TongSV_NongDan", GetType(String))
                dt.Columns.Add("TongSV_Khac", GetType(String))
                dt.Columns.Add("TongSV_DanToc", GetType(String))
                dt.Columns.Add("TongSV_KhongTonGiao", GetType(String))
                dt.Columns.Add("TongSV_TonGiao", GetType(String))
                dt.Columns.Add("TongSV_KV1", GetType(String))
                dt.Columns.Add("TongSV_KV2", GetType(String))
                dt.Columns.Add("TongSV_KV2_NT", GetType(String))
                dt.Columns.Add("TongSV_KV3", GetType(String))
                dt.Columns.Add("TongSV_KV135", GetType(String))
                dt.Columns.Add("Ly_do", GetType(String))

                Dim dkNH As String = "Loai_qd=1" ' Lọc sinh viên ngừng học
                Dim dkTH As String = "Loai_qd=2" ' Lọc sinh viên thôi hoc              
                Dim dkNgH As String = "Loai_qd=5" ' Lọc sinh viên nghỉ học               
                Dim dkLB As String = "Loai_qd=4" ' Lọc sinh viên lưu ban
                Dim dkCT As String = "Loai_qd=3" ' Lọc sinh viên chuyển trường
                Dim dk As String = ""

                For i As Integer = 0 To dtPL.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dt.NewRow
                    Dim dv As New DataView
                    dv = mdtDSSVThoiHoc.DefaultView
                    dr("Phan_loai") = dtPL.Rows(i).Item("Phan_loai")
                    ' Tổng sinh viên
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dv.RowFilter = dkNH
                        dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                        If dv.Count > 0 Then dr("Ly_do") = dv.Item(0)("Ly_do").ToString
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dv.RowFilter = dkTH
                        dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                        If dv.Count > 0 Then dr("Ly_do") = dv.Item(0)("Ly_do").ToString
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dv.RowFilter = dkNgH
                        dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                        If dv.Count > 0 Then dr("Ly_do") = dv.Item(0)("Ly_do").ToString
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dv.RowFilter = dkLB
                        dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                        If dv.Count > 0 Then dr("Ly_do") = dv.Item(0)("Ly_do").ToString
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dv.RowFilter = dkCT
                        dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                        If dv.Count > 0 Then dr("Ly_do") = dv.Item(0)("Ly_do").ToString
                    End If
                    ' Tổng sv ĐTCS
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNgH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dk = dkLB + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv thành phần xuất thân
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_CongNhan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNgH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dk = dkLB + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv Dân tộc
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNgH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dk = dkLB + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv Tôn giáo
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNgH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dk = dkLB + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If

                    ' Tổng sv Khu vực
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNgH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dk = dkLB + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkLB + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    dt.Rows.Add(dr)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_BienDong_SinhVien(ByVal dsID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim mdtDSSVThoiHoc As DataTable
                mdtDSSVThoiHoc = obj.DanhSach_SinhVienThoiHoc(dsID_lops, ID_he, ID_khoa, Khoa_hoc) ' Danh sác sv thôi học , ngừng học, nghỉ học, chuyển trường
                Dim mdtDSSVHocTiep As DataTable
                mdtDSSVHocTiep = obj.DanhSach_SinhVienHocTiep(dsID_lops, ID_he, ID_khoa, Khoa_hoc) ' Danh sách sinh viên được xét học tiếp

                ' dt Phân loại biến động
                Dim dtPL As New DataTable
                dtPL.Columns.Add("Phan_loai", GetType(String))
                dtPL.Columns.Add("Ly_do", GetType(String))
                Dim r As DataRow
                r = dtPL.NewRow
                r("Phan_loai") = "Thôi học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Nghỉ học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Ngừng học"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Lưu ban"
                dtPL.Rows.Add(r)
                r = dtPL.NewRow
                r("Phan_loai") = "Chuyển trường"
                dtPL.Rows.Add(r)
                ' dt Thongke biến động
                Dim dt As New DataTable
                dt.Columns.Add("Phan_loai", GetType(String))
                dt.Columns.Add("Tong_HSSV", GetType(String))
                dt.Columns.Add("TongSV_DTCS", GetType(String))
                dt.Columns.Add("TongSV_CongNhan", GetType(String))
                dt.Columns.Add("TongSV_NongDan", GetType(String))
                dt.Columns.Add("TongSV_Khac", GetType(String))
                dt.Columns.Add("TongSV_DanToc", GetType(String))
                dt.Columns.Add("TongSV_KhongTonGiao", GetType(String))
                dt.Columns.Add("TongSV_TonGiao", GetType(String))
                dt.Columns.Add("TongSV_KV1", GetType(String))
                dt.Columns.Add("TongSV_KV2", GetType(String))
                dt.Columns.Add("TongSV_KV2_NT", GetType(String))
                dt.Columns.Add("TongSV_KV3", GetType(String))
                dt.Columns.Add("TongSV_KV135", GetType(String))
                dt.Columns.Add("Ly_do", GetType(String))

                Dim dkTH As String = "Thoi_hoc=1 And Chuyen_truong<>1" ' Lọc sinh viên thôi học
                Dim dkNH As String = "Thoi_hoc=0 And Nghi_hoc=1" ' Lọc sinh viên nghỉ học (ví dụ nghỉ học bảo lưu)                
                Dim dkNgH As String = "Thoi_hoc=0 And Nghi_hoc=0" ' Lọc sinh viên ngừng học (không đủ dk học)                
                Dim dkCT As String = "Thoi_hoc=1 And Chuyen_truong=1" ' Lọc sinh viên chuyển trường
                Dim dkLB As String = "Thoi_hoc=0 And Nghi_hoc=0 And Chuyen_truong<>1" ' Lọc sinh viên lưu ban
                Dim dk As String = ""

                For i As Integer = 0 To dtPL.Rows.Count - 1
                    Dim dr As DataRow
                    dr = dt.NewRow
                    Dim dv As New DataView
                    dv = mdtDSSVThoiHoc.DefaultView
                    dr("Phan_loai") = dtPL.Rows(i).Item("Phan_loai")
                    ' Tổng sinh viên
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then dv.RowFilter = dkTH
                    dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then dv.RowFilter = dkNH
                    dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then dv.RowFilter = dkNgH
                    dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then dv.RowFilter = dkCT
                    dr("Tong_HSSV") = IIf(dv.Count = 0, "", dv.Count)
                    ' Tổng sv ĐTCS
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNgH + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_doi_tuong_TC<>-1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv thành phần xuất thân
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_CongNhan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)

                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNgH + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_thanh_phan_xuat_than=1"
                        dv.RowFilter = dk
                        dr("TongSV_DTCS") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_thanh_phan_xuat_than=2"
                        dv.RowFilter = dk
                        dr("TongSV_NongDan") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dv.RowFilter = dk
                        dr("TongSV_Khac") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv Dân tộc
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNgH + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And Dan_toc<>'Kinh'"
                        dv.RowFilter = dk
                        dr("TongSV_DanToc") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Tổng sv Tôn giáo
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNgH + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dv.RowFilter = dk
                        dr("TongSV_KhongTonGiao") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K'"
                        dv.RowFilter = dk
                        dr("TongSV_TonGiao") = IIf(dv.Count = 0, "", dv.Count)
                    End If

                    ' Tổng sv Khu vực
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then
                        dk = dkTH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkTH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then
                        dk = dkNH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then
                        dk = dkNgH + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkNgH + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then
                        dk = dkCT + " And ID_khu_vuc_TS=1"
                        dv.RowFilter = dk
                        dr("TongSV_KV1") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=2"
                        dv.RowFilter = dk
                        dr("TongSV_KV2") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=3"
                        dv.RowFilter = dk
                        dr("TongSV_KV2_NT") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=4"
                        dv.RowFilter = dk
                        dr("TongSV_KV3") = IIf(dv.Count = 0, "", dv.Count)
                        dk = dkCT + " And ID_khu_vuc_TS=5"
                        dv.RowFilter = dk
                        dr("TongSV_KV135") = IIf(dv.Count = 0, "", dv.Count)
                    End If
                    ' Sinh viên lưu ban
                    Dim dvLB As DataView = mdtDSSVHocTiep.DefaultView
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then
                        dvLB.RowFilter = dkLB
                        ' Tổng số HSSV lưu ban
                        dr("Tong_HSSV") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        ' Tổng số DTTC
                        Dim dkLB_DTTC As String = dkLB + " And ID_doi_tuong_TC<>-1"
                        dvLB.RowFilter = dkLB_DTTC
                        dr("TongSV_DTCS") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        ' Tổng số Thành phần xuất thân
                        Dim dkLB_CN As String = dkLB + " And ID_thanh_phan_xuat_than=1"
                        dvLB.RowFilter = dkLB_CN
                        dr("TongSV_CongNhan") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_ND As String = dkLB + " And ID_thanh_phan_xuat_than=2"
                        dvLB.RowFilter = dkLB_ND
                        dr("TongSV_NongDan") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_K As String = dkLB + " And ID_thanh_phan_xuat_than<>1 And ID_thanh_phan_xuat_than<>2"
                        dvLB.RowFilter = dkLB_K
                        dr("TongSV_Khac") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        ' Tổng số Dan tộc
                        Dim dkLB_DT As String = dkLB + " And Dan_toc<>'Kinh'"
                        dvLB.RowFilter = dkLB_DT
                        dr("TongSV_DanToc") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        ' Tổng số Tôn giáo
                        Dim dkLB_KTG As String = dkLB + " And (Ton_giao='Không' Or Ton_giao='' Or Ton_giao='0' Or Ton_giao='K')"
                        dvLB.RowFilter = dkLB_KTG
                        dr("TongSV_KhongTonGiao") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_TG As String = dkLB + " And Ton_giao<>'Không' And Ton_giao<>'' And Ton_giao<>'0' And Ton_giao<>'K' "
                        dvLB.RowFilter = dkLB_TG
                        dr("TongSV_TonGiao") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        ' Tổng số Khu vực
                        Dim dkLB_KV1 As String = dkLB + " And ID_khu_vuc_TS=1"
                        dvLB.RowFilter = dkLB_KV1
                        dr("TongSV_KV1") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_KV2 As String = dkLB + " And ID_khu_vuc_TS=2"
                        dvLB.RowFilter = dkLB_KV2
                        dr("TongSV_KV2") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_KV2_NT As String = dkLB + " And ID_khu_vuc_TS=3"
                        dvLB.RowFilter = dkLB_KV2_NT
                        dr("TongSV_KV2_NT") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_KV3 As String = dkLB + " And ID_khu_vuc_TS=4"
                        dvLB.RowFilter = dkLB_KV3
                        dr("TongSV_KV3") = IIf(dvLB.Count = 0, "", dvLB.Count)
                        Dim dkLB_KV135 As String = dkLB + " And ID_khu_vuc_TS=5"
                        dvLB.RowFilter = dkLB_KV135
                        dr("TongSV_KV135") = IIf(dvLB.Count = 0, "", dvLB.Count)
                    End If
                    ' Lý do
                    If dtPL.Rows(i).Item("Phan_loai") = "Thôi học" Then dr("Ly_do") = "Sinh viên thôi học"
                    If dtPL.Rows(i).Item("Phan_loai") = "Nghỉ học" Then dr("Ly_do") = "Sinh viên Nghỉ học có lý do"
                    If dtPL.Rows(i).Item("Phan_loai") = "Ngừng học" Then dr("Ly_do") = "Sinh viên buộc ngừng học"
                    If dtPL.Rows(i).Item("Phan_loai") = "Lưu ban" Then dr("Ly_do") = "Lưu ban"
                    If dtPL.Rows(i).Item("Phan_loai") = "Chuyển trường" Then dr("Ly_do") = "Chuyển trường"
                    dt.Rows.Add(dr)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên theo co cấu xã hội mẫu M1.1
        Public Function ThongKe_SinhVienCoCauXaHoi() As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                mdtDSSVCoCauXaHoi = obj.DanhSach_SinhVienCoCauXaHoi()
                mdtDSSV = obj.DanhSach_SinhVien()
                Dim dt As New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ten_he", GetType(String))
                dt.Columns.Add("ID_Nganh", GetType(Integer))
                dt.Columns.Add("Ten_Nganh", GetType(String))
                dt.Columns.Add("Tong_SV_He", GetType(String))
                dt.Columns.Add("Tong_SV_Nganh", GetType(String))
                dt.Columns.Add("Nam_he", GetType(String))
                dt.Columns.Add("Nam_Nganh", GetType(String))
                dt.Columns.Add("Nu_he", GetType(String))
                dt.Columns.Add("Nu_Nganh", GetType(String))
                dt.Columns.Add("CNVC_he", GetType(String))
                dt.Columns.Add("CNVC_Nganh", GetType(String))
                dt.Columns.Add("ND_he", GetType(String))
                dt.Columns.Add("ND_Nganh", GetType(String))
                dt.Columns.Add("Khac_he", GetType(String))
                dt.Columns.Add("Khac_Nganh", GetType(String))
                dt.Columns.Add("Kinh_he", GetType(String))
                dt.Columns.Add("Kinh_Nganh", GetType(String))
                dt.Columns.Add("TieuSo_He", GetType(String))
                dt.Columns.Add("TieuSo_Nganh", GetType(String))
                dt.Columns.Add("Khong_he", GetType(String))
                dt.Columns.Add("Khong_Nganh", GetType(String))
                dt.Columns.Add("Co_he", GetType(String))
                dt.Columns.Add("Co_Nganh", GetType(String))
                dt.Columns.Add("KV1_He", GetType(String))
                dt.Columns.Add("KV1_Nganh", GetType(String))
                dt.Columns.Add("KV2_He", GetType(String))
                dt.Columns.Add("KV2_Nganh", GetType(String))
                dt.Columns.Add("NT_He", GetType(String))
                dt.Columns.Add("NT_Nganh", GetType(String))
                dt.Columns.Add("KV3_He", GetType(String))
                dt.Columns.Add("KV3_Nganh", GetType(String))
                dt.Columns.Add("KK_He", GetType(String))
                dt.Columns.Add("KK_Nganh", GetType(String))
                For i As Integer = 0 To mdtDSSVCoCauXaHoi.Rows.Count - 1
                    Dim Str As String = ""
                    Dim dv As New DataView
                    dv = mdtDSSV.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    Dim row As DataRow
                    row = dt.NewRow
                    row("ID_He") = mdtDSSVCoCauXaHoi.Rows(i).Item("ID_He").ToString
                    row("Ten_he") = mdtDSSVCoCauXaHoi.Rows(i).Item("Ten_he").ToString
                    row("ID_Nganh") = mdtDSSVCoCauXaHoi.Rows(i).Item("ID_Nganh").ToString
                    row("Ten_nganh") = mdtDSSVCoCauXaHoi.Rows(i).Item("Ten_nganh").ToString
                    ' Tong sinh vien theo he
                    Dim strHe As String = "ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe
                    row("Tong_SV_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va nganh
                    Dim strHe_Nganh As String = "ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh
                    row("Tong_SV_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va gioi tinh Nam
                    Dim strHe_GioiTinh_nam As String = " ID_gioi_tinh=0 AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_GioiTinh_nam
                    row("Nam_he") = IIf(dv.Count = 0, "", dv.Count)


                    ' Tong sinh vien theo he va gioi tinh Nu
                    Dim strHe_GioiTinh_Nu As String = "ID_gioi_tinh=1 AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_GioiTinh_Nu
                    row("Nu_he") = IIf(dv.Count = 0, "", dv.Count)


                    ' Tong sinh vien theo he va nganh, Nam
                    Dim strHe_Nganh_GioiTinh_Nam As String = "ID_gioi_tinh=0 AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh_GioiTinh_Nam
                    row("Nam_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va nganh, Nu

                    Dim strHe_Nganh_GioiTinh_Nu As String = "ID_gioi_tinh=1 AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh_GioiTinh_Nu
                    row("Nu_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    'Tong sinh vien theo he va CNVC
                    Dim strHe_CNVC As String = " isnull(Ten_thanh_phan,'')='Công nhân' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_CNVC
                    row("CNVC_he") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Nong dan
                    Dim strHe_NongDan As String = "isnull(Ten_thanh_phan,'')='Nông dân' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_NongDan
                    row("ND_he") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Nong dan
                    Dim strHe_KhacNongDan As String = "isnull(Ten_thanh_phan,'')<>'Nông dân' AND isnull(Ten_thanh_phan,'')<>'Công nhân' And isnull(Ten_thanh_phan,'')<>'' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_KhacNongDan
                    row("Khac_he") = IIf(dv.Count = 0, "", dv.Count)

                    '---------------------------------
                    ' Tong sinh vien theo he va CNVC, Nganh
                    Dim strHe_Nganh_CNVC As String = "isnull(Ten_thanh_phan,'')='Công nhân' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh_CNVC
                    row("CNVC_nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Nong dan
                    Dim strHe_Nganh_NongDan As String = "isnull(Ten_thanh_phan,'')='Nông dân' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh_NongDan
                    row("ND_nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Nong dan
                    Dim strHe_Nganh_KhacNongDan As String = "isnull(Ten_thanh_phan,'')<>'Nông dân' AND isnull(Ten_thanh_phan,'')<>'Công nhân' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = strHe_Nganh_KhacNongDan

                    '-------------------------

                    ' Tong sinh vien theo he va Dan toc
                    Dim strHe_DanToc As String = "isnull(Dan_toc,'')='KINH' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = strHe_DanToc
                    row("Kinh_he") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Thiểu số
                    Str = "isnull(Dan_toc,'')<>'KINH' AND isnull(Dan_toc,'')<>'' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("TieuSo_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Thiểu số
                    Str = "isnull(Dan_toc,'')='KINH' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Kinh_nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Thiểu số, Nganh
                    Str = "isnull(Dan_toc,'')<>'KINH' AND isnull(Dan_toc,'')<>'' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("TieuSo_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va Ton giao
                    Str = "isnull(Ton_giao,'')='KHÔNG' AND isnull(Ton_giao,'')='' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("Khong_he") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va không ton giao
                    Str = "isnull(Ton_giao,'')<>'KHÔNG' AND isnull(Ton_giao,'')<>'' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("Co_he") = IIf(dv.Count = 0, "", dv.Count)


                    ' Tong sinh vien theo he va Ton giao, nganh
                    Str = "isnull(Ton_giao,'')='KHÔNG' AND isnull(Ton_giao,'')='' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Khong_nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va không ton giao, nganh
                    Str = "isnull(Ton_giao,'')<>'KHÔNG' AND isnull(Ton_giao,'')<>'' AND  ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Co_nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 1
                    Str = "isnull(Ma_KV,'')='1' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("KV1_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 2
                    Str = "isnull(Ma_KV,'')='2' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("KV2_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 2-NT
                    Str = "isnull(Ma_KV,'')='2NT' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("NT_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 3
                    Str = "isnull(Ma_KV,'')='3' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("KV3_He") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 3
                    Str = "(isnull(Ma_KV,'')='VC' OR isnull(Ma_KV,'')='KVKK') AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he")
                    dv.RowFilter = Str
                    row("KK_He") = IIf(dv.Count = 0, "", dv.Count)

                    '--------------------------
                    ' Tong sinh vien theo he ngành va khu vuc 1
                    Str = "isnull(Ma_KV,'')='1' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("KV1_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 2
                    Str = "isnull(Ma_KV,'')='2' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("KV2_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 2-NT
                    Str = "isnull(Ma_KV,'')='2NT' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("NT_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 3
                    Str = "isnull(Ma_KV,'')='3' AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("KV3_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va khu vuc 3
                    Str = "(isnull(Ma_KV,'')='VC' OR isnull(Ma_KV,'')='KVKK') AND ID_he=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_he") & " AND ID_nganh=" & mdtDSSVCoCauXaHoi.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("KK_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên theo tỉnh thành
        Public Function ThongKe_SinhVienTinhThanh(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dtTinhThanh As DataTable
                dtTinhThanh = obj.DanhSach_TinhThanh(ID_He, ID_khoa, Khoa_hoc)
                Dim dtDSSV_TinhThanh As DataTable
                dtDSSV_TinhThanh = obj.DanhSachSV_TinhThanh(ID_He, ID_khoa, Khoa_hoc)
                Dim dt As New DataTable
                dt.Columns.Add("Ten_tinh", GetType(String))
                dt.Columns.Add("Tong_so", GetType(String))
                dt.Columns.Add("Tong_nam", GetType(String))
                dt.Columns.Add("Tong_nu", GetType(String))
                For i As Integer = 0 To dtTinhThanh.Rows.Count - 1
                    Dim dv As New DataView
                    dv = dtDSSV_TinhThanh.DefaultView
                    Dim row As DataRow
                    row = dt.NewRow
                    ' Đếm tổng số sinh viên của mỗi tỉnh
                    Dim str1 As String = "ID_tinh_ns='" & dtTinhThanh.Rows(i)("ID_tinh").ToString & "'"
                    dv.RowFilter = str1
                    row("Ten_tinh") = dtTinhThanh.Rows(i)("Ten_tinh").ToString
                    row("Tong_so") = IIf(dv.Count = 0, "", dv.Count)
                    ' Đếm tổng sinh viên nam theo tỉnh
                    str1 += " And ID_gioi_tinh=0"
                    dv = dtDSSV_TinhThanh.DefaultView
                    dv.RowFilter = str1
                    row("Tong_nam") = IIf(dv.Count = 0, "", dv.Count)
                    ' Đếm tổng sinh viên nữ theo tỉnh
                    Dim str2 As String = "ID_tinh_ns='" & dtTinhThanh.Rows(i)("ID_tinh").ToString & "'" & " And ID_gioi_tinh=1"
                    dv = dtDSSV_TinhThanh.DefaultView
                    dv.RowFilter = str2
                    row("Tong_nu") = IIf(dv.Count = 0, "", dv.Count)
                    dt.Rows.Add(row)
                Next
                dt.DefaultView.Sort = "Ten_tinh"
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên nước ngoài theo mẫu M1.2
        Public Function ThongKe_SinhVienNuocNgoai(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                mdtDSSVNuocNgoai = obj.DanhSach_SinhVienNuocNgoai(ID_He, ID_khoa, Khoa_hoc)
                mdtDSSV = obj.DanhSach_SinhVien()
                Dim dt As New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("ID_Nganh", GetType(Integer))
                dt.Columns.Add("Ten_Nganh", GetType(String))
                dt.Columns.Add("ID_quoc_tich", GetType(Integer))
                dt.Columns.Add("Quoc_tich", GetType(String))
                dt.Columns.Add("Tong_QTich", GetType(String))
                dt.Columns.Add("Nam_QT", GetType(String))
                dt.Columns.Add("Nu_QT", GetType(String))
                dt.Columns.Add("Tong_Nganh", GetType(String))
                dt.Columns.Add("Nam_Nganh", GetType(String))
                dt.Columns.Add("Nu_Nganh", GetType(String))
                For i As Integer = 0 To mdtDSSVNuocNgoai.Rows.Count - 1
                    Dim Str As String = ""
                    Dim dv As New DataView
                    dv = mdtDSSV.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    Dim row As DataRow
                    row = dt.NewRow
                    row("ID_He") = ID_He
                    row("ID_Nganh") = mdtDSSVNuocNgoai.Rows(i).Item("ID_Nganh").ToString
                    row("Ten_nganh") = mdtDSSVNuocNgoai.Rows(i).Item("Ten_nganh").ToString
                    row("ID_quoc_tich") = mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich").ToString
                    row("Quoc_tich") = mdtDSSVNuocNgoai.Rows(i).Item("Quoc_tich").ToString

                    Dim str1 As String = " ID_he=" & ID_He
                    If ID_khoa > 0 Then str1 += " And ID_khoa=" & ID_khoa
                    If Khoa_hoc > 0 Then str1 += " And Khoa_hoc=" & Khoa_hoc

                    ' Tong sinh vien theo Quoc Tich
                    Str = str1 & " And ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich")
                    dv.RowFilter = Str
                    row("Tong_QTich") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo Quoc Tich va Gioi Tinh Nam
                    Str = str1 & " And ID_gioi_tinh=0 AND ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich")
                    dv.RowFilter = Str
                    row("Nam_QT") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo he va gioi tinh Nu
                    Str = str1 & " And ID_gioi_tinh=1 AND ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich")
                    dv.RowFilter = Str
                    row("Nu_QT") = IIf(dv.Count = 0, "", dv.Count)


                    ' Tong sinh vien theo nganh va Quoc Tich
                    Str = str1 & " And ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich") & " AND ID_nganh=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Tong_Nganh") = IIf(dv.Count = 0, "", dv.Count)


                    ' Tong sinh vien theo nganh va Quoc Tich, Nam
                    Str = str1 & " And ID_gioi_tinh=0 AND ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich") & " AND ID_nganh=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Nam_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    ' Tong sinh vien theo nganh va Quoc Tich, Nu

                    Str = str1 & " And ID_gioi_tinh=1 AND ID_quoc_tich=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_quoc_tich") & " AND ID_nganh=" & mdtDSSVNuocNgoai.Rows(i).Item("ID_nganh")
                    dv.RowFilter = Str
                    row("Nu_Nganh") = IIf(dv.Count = 0, "", dv.Count)

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê sinh viên thuộc diện ưu đãi và chính sách theo mẫu M1.3
        Public Function ThongKe_SinhVienChinhSach(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim mdtDSSVChinhSach As DataTable = obj.DanhSach_SinhVienChinhSach(ID_He, ID_khoa, Khoa_hoc)
                mdtDSSV = obj.DanhSach_SinhVien()
                Dim dt As New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_dt", GetType(Integer))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("So_SV", GetType(String))
                dt.Columns.Add("Nam", GetType(String))
                dt.Columns.Add("Nu", GetType(String))
                dt.Columns.Add("Kinh", GetType(String))
                dt.Columns.Add("ThieuSo", GetType(String))
                dt.Columns.Add("Khong", GetType(String))
                dt.Columns.Add("Co", GetType(String))
                dt.Columns.Add("KV1", GetType(String))
                dt.Columns.Add("KV2", GetType(String))
                dt.Columns.Add("NT", GetType(String))
                dt.Columns.Add("KV3", GetType(String))
                dt.Columns.Add("KK", GetType(String))
                For i As Integer = 0 To mdtDSSVChinhSach.Rows.Count - 1
                    Dim Str As String = ""
                    Dim dv As New DataView
                    dv = mdtDSSV.DefaultView
                    ' Lọc só sinh viên theo từng đối tượng tuyển sinh
                    Dim row As DataRow
                    row = dt.NewRow
                    row("ID_He") = ID_He
                    row("Ma_dt") = mdtDSSVChinhSach.Rows(i).Item("Ma_dt").ToString
                    row("Ten_dt") = mdtDSSVChinhSach.Rows(i).Item("Ten_dt").ToString
                    ' Điều kiện lọc theo hệ khoa khóa học
                    Dim str1 As String = ""
                    If ID_He > 0 Then str1 += " ID_he=" & ID_He
                    If ID_khoa > 0 Then str1 += " And ID_khoa=" & ID_khoa
                    If Khoa_hoc > 0 Then str1 += " And Khoa_hoc=" & Khoa_hoc
                    ' Tính tổng số sinh viên của mỗi đối tượng
                    Str = str1 & " And ID_doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt")
                    dv.RowFilter = Str
                    row("So_SV") = IIf(dv.Count = 0, "", dv.Count)
                    ' Tính tổng số sinh viên đối tượng theo giới tính
                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND ID_gioi_tinh=0"
                    dv.RowFilter = Str
                    row("Nam") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND ID_gioi_tinh=1"
                    dv.RowFilter = Str
                    row("Nu") = IIf(dv.Count = 0, "", dv.Count)
                    ' Theo dân tộc
                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Dan_toc,'')='KINH'"
                    dv.RowFilter = Str
                    row("Kinh") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Dan_toc,'')<>'KINH' AND isnull(Dan_toc,'')<>''"
                    dv.RowFilter = Str
                    row("ThieuSo") = IIf(dv.Count = 0, "", dv.Count)
                    ' Theo tôn giáo
                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ton_giao,'')='KHÔNG' AND isnull(Ton_giao,'')=''"
                    dv.RowFilter = Str
                    row("Khong") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ton_giao,'')<>'KHÔNG' AND isnull(Ton_giao,'')<>''"
                    dv.RowFilter = Str
                    row("Co") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ma_KV,'')='1'"
                    dv.RowFilter = Str
                    row("KV1") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ma_KV,'')='2'"
                    dv.RowFilter = Str
                    row("KV2") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ma_KV,'')='2NT'"
                    dv.RowFilter = Str
                    row("NT") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ma_KV,'')='3'"
                    dv.RowFilter = Str
                    row("KV3") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TS=" & mdtDSSVChinhSach.Rows(i).Item("Ma_dt") & " AND isnull(Ma_KV,'')<>'KVKK'"
                    row("KK") = IIf(dv.Count = 0, "", dv.Count)

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongKe_SinhVienTroCap(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim mdtDSSVTroCap As DataTable = obj.DanhSach_SinhVienTroCap(ID_He, ID_khoa, Khoa_hoc)
                mdtDSSV = obj.DanhSach_SinhVien()
                Dim dt As New DataTable
                dt.Columns.Add("ID_he", GetType(Integer))
                dt.Columns.Add("Ma_dt_hb", GetType(Integer))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("So_SV", GetType(String))
                dt.Columns.Add("Nam", GetType(String))
                dt.Columns.Add("Nu", GetType(String))
                dt.Columns.Add("Kinh", GetType(String))
                dt.Columns.Add("ThieuSo", GetType(String))
                dt.Columns.Add("Khong", GetType(String))
                dt.Columns.Add("Co", GetType(String))
                dt.Columns.Add("KV1", GetType(String))
                dt.Columns.Add("KV2", GetType(String))
                dt.Columns.Add("NT", GetType(String))
                dt.Columns.Add("KV3", GetType(String))
                dt.Columns.Add("KK", GetType(String))
                For i As Integer = 0 To mdtDSSVTroCap.Rows.Count - 1
                    Dim Str As String = ""
                    Dim dv As New DataView
                    dv = mdtDSSV.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    Dim row As DataRow
                    row = dt.NewRow
                    row("ID_He") = ID_He
                    row("Ma_dt_hb") = mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb").ToString
                    row("Ten_dt") = mdtDSSVTroCap.Rows(i).Item("Ten_dt_hb").ToString

                    ' Điều kiện lọc theo hệ khoa khóa học
                    Dim str1 As String = ""
                    If ID_He > 0 Then str1 += " ID_he=" & ID_He
                    If ID_khoa > 0 Then str1 += " And ID_khoa=" & ID_khoa
                    If Khoa_hoc > 0 Then str1 += " And Khoa_hoc=" & Khoa_hoc
                    ' Tổng sinh viên đối tượng
                    Str = str1 & " And ID_Doi_tuong_TC=" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb")
                    dv.RowFilter = Str
                    row("So_SV") = IIf(dv.Count = 0, "", dv.Count)
                    ' Tổng sinh viên theo đối tương, giới tính
                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND ID_gioi_tinh=0"
                    dv.RowFilter = Str
                    row("Nam") = IIf(dv.Count = 0, "", dv.Count)

                    Str = "ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND ID_gioi_tinh=1"
                    dv.RowFilter = Str
                    row("Nu") = IIf(dv.Count = 0, "", dv.Count)
                    ' Theo dân tộc
                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Dan_toc,'')='KINH'"
                    dv.RowFilter = Str
                    row("Kinh") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Dan_toc,'')<>'KINH' AND isnull(Dan_toc,'')<>''"
                    dv.RowFilter = Str
                    row("ThieuSo") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ton_giao,'')='KHÔNG' AND isnull(Ton_giao,'')=''"
                    dv.RowFilter = Str
                    row("Khong") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ton_giao,'')<>'KHÔNG' AND isnull(Ton_giao,'')<>''"
                    dv.RowFilter = Str
                    row("Co") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ma_KV,'')='1'"

                    dv.RowFilter = Str
                    row("KV1") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ma_KV,'')='2'"
                    dv.RowFilter = Str
                    row("KV2") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ma_KV,'')='2NT'"
                    dv.RowFilter = Str
                    row("NT") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ma_KV,'')='3'"
                    dv.RowFilter = Str
                    row("KV3") = IIf(dv.Count = 0, "", dv.Count)

                    Str = str1 & " And ID_Doi_tuong_TC='" & mdtDSSVTroCap.Rows(i).Item("Ma_dt_hb") & "' AND isnull(Ma_KV,'')='KVKK'"
                    dv.RowFilter = Str
                    row("KK") = IIf(dv.Count = 0, "", dv.Count)

                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê kết quả rèn luyện theo ngành đào tạo M2.1
        Public Function ThongKe_KetQuaRenLuyen(ByVal ID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim objLop As New Lop_Bussines(ID_lops, 0, 1, -1)
                Dim dtLop As DataTable
                dtLop = objLop.Danh_sach_lop_dang_hoc()
                Dim dvLop As DataView
                dvLop = dtLop.DefaultView
                Dim dkLop As String = "1=1"
                If ID_he > 0 Then dkLop += " And ID_he=" & ID_he
                If ID_khoa > 0 Then dkLop += " And ID_khoa=" & ID_khoa
                If Khoa_hoc > 0 Then dkLop += " And Khoa_hoc=" & Khoa_hoc
                dvLop.RowFilter = dkLop
                ' Lấy ra danh sách lớp theo hệ khoa khóa
                Dim dsID_lop As String = "0"
                For j As Integer = 0 To dvLop.Count - 1
                    dsID_lop += "," & dvLop.Item(j)("ID_lop")
                Next
                Dim obj As New DiemRenLuyen_Bussines(dsID_lop)
                Dim dtRL As DataTable
                dtRL = obj.TongHop_DiemRenLuyenKhoa()
                dtRL.Columns.Add("ID_nganh")
                For i As Integer = 0 To dtRL.Rows.Count - 1
                    For j As Integer = 0 To dvLop.Count - 1
                        If dtRL.Rows(i)("ID_lop") = dvLop.Item(j)("ID_lop") Then
                            dtRL.Rows(i)("ID_nganh") = IIf(IsDBNull(dvLop.Item(j)("ID_nganh")), 0, dvLop.Item(j)("ID_nganh"))
                        End If
                    Next
                Next
                Dim dt As New DataTable
                dt.Columns.Add("Ma_nganh", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("TongSV_Nganh", GetType(String))
                dt.Columns.Add("TongSV_XS", GetType(String))
                dt.Columns.Add("TongSV_Gioi", GetType(String))
                dt.Columns.Add("TongSV_Kha", GetType(String))
                dt.Columns.Add("TongSV_TBK", GetType(String))
                dt.Columns.Add("TongSV_TB", GetType(String))
                dt.Columns.Add("TongSV_Yeu", GetType(String))
                dt.Columns.Add("TongSV_Kem", GetType(String))
                For i As Integer = 0 To mdtNganh.Rows.Count - 1
                    Dim dk As String = "1=1"
                    Dim dv As New DataView
                    dv = mdtDSSVNganh.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    dk += " And ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dv.RowFilter = dk
                    Dim row As DataRow
                    row = dt.NewRow
                    row("Ma_nganh") = mdtNganh.Rows(i).Item("Ma_nganh").ToString
                    row("Ten_nganh") = mdtNganh.Rows(i).Item("Ten_nganh").ToString
                    row("TongSV_Nganh") = IIf(dv.Count = 0, "", dv.Count)
                    ' Lọc số sinh viên Xuất sắc theo từng ngành
                    Dim dvRL As New DataView
                    dvRL = dtRL.DefaultView
                    dk += " And ID_xep_loai=1"
                    dvRL.RowFilter = dk
                    row("TongSV_XS") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên giỏi
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=2"
                    dvRL.RowFilter = dk
                    row("TongSV_Gioi") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên Khá
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=3"
                    dvRL.RowFilter = dk
                    row("TongSV_Kha") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên TB khá
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=4"
                    dvRL.RowFilter = dk
                    row("TongSV_TBK") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên TB
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=5"
                    dvRL.RowFilter = dk
                    row("TongSV_TB") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên yếu
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=6"
                    dvRL.RowFilter = dk
                    row("TongSV_Yeu") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    ' Sinh viên kém
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=7"
                    dvRL.RowFilter = dk
                    row("TongSV_Kem") = IIf(dvRL.Count = 0, "", dvRL.Count)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Thống kê kết quả học tập theo ngành đào tạo M2.1
        Public Function ThongKe_KetQuaHocTap(ByVal ID_dv As String, ByVal ID_lops As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim objLop As New Lop_Bussines(ID_lops, 0, 1, -1)
                Dim dtLop As DataTable
                dtLop = objLop.Danh_sach_lop_dang_hoc()
                Dim dvLop As DataView
                dvLop = dtLop.DefaultView
                Dim dkLop As String = "1=1"
                If ID_he > 0 Then dkLop += " And ID_he=" & ID_he
                If ID_khoa > 0 Then dkLop += " And ID_khoa=" & ID_khoa
                If Khoa_hoc > 0 Then dkLop += " And Khoa_hoc=" & Khoa_hoc
                dvLop.RowFilter = dkLop
                ' Lấy ra danh sách lớp theo hệ khoa khóa
                Dim dsID_lop As String = "0"
                For j As Integer = 0 To dvLop.Count - 1
                    dsID_lop += "," & dvLop.Item(j)("ID_lop")
                Next
                Dim objDSSV As New DanhSachSinhVien_Bussines(dsID_lop)
                Dim dtDSSV As DataTable
                dtDSSV = objDSSV.Danh_sach_sinh_vien()
                Dim objDiem As New Diem_Bussines(ID_dv, 0, 0, "", dsID_lop, 0, dtDSSV)
                Dim dtDiem As DataTable
                dtDiem = objDiem.TongHopDiemTinChiTichLuy(False, True)
                ' Add ngành đào tạo cho mỗi sinh viên
                dtDiem.Columns.Add("ID_nganh")
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    For j As Integer = 0 To dvLop.Count - 1
                        If dtDiem.Rows(i)("Ten_lop") = dvLop.Item(j)("Ten_lop") Then
                            dtDiem.Rows(i)("ID_nganh") = IIf(IsDBNull(dvLop.Item(j)("ID_nganh")), 0, dvLop.Item(j)("ID_nganh"))
                        End If
                    Next
                Next
                Dim dt As New DataTable
                dt.Columns.Add("Ma_nganh", GetType(String))
                dt.Columns.Add("Ten_nganh", GetType(String))
                dt.Columns.Add("TongSV_Nganh", GetType(String))
                dt.Columns.Add("TongSV_XS", GetType(String))
                dt.Columns.Add("TongSV_Gioi", GetType(String))
                dt.Columns.Add("TongSV_Kha", GetType(String))
                dt.Columns.Add("TongSV_TBK", GetType(String))
                dt.Columns.Add("TongSV_TB", GetType(String))
                dt.Columns.Add("TongSV_Yeu", GetType(String))
                dt.Columns.Add("TongSV_Kem", GetType(String))
                For i As Integer = 0 To mdtNganh.Rows.Count - 1
                    Dim dk As String = "1=1"
                    Dim dv As New DataView
                    dv = mdtDSSVNganh.DefaultView
                    ' Lọc só sinh viên theo từng ngành
                    dk += " And ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dv.RowFilter = dk
                    Dim row As DataRow
                    row = dt.NewRow
                    row("Ma_nganh") = mdtNganh.Rows(i).Item("Ma_nganh").ToString
                    row("Ten_nganh") = mdtNganh.Rows(i).Item("Ten_nganh").ToString
                    row("TongSV_Nganh") = IIf(dv.Count = 0, "", dv.Count)
                    ' Lọc số sinh viên Xuất sắc theo từng ngành
                    Dim dvDiem As New DataView
                    dvDiem = dtDiem.DefaultView
                    dk += " And ID_xep_loai=1"
                    dvDiem.RowFilter = dk
                    row("TongSV_XS") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên giỏi
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=2"
                    dvDiem.RowFilter = dk
                    row("TongSV_Gioi") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên Khá
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=3"
                    dvDiem.RowFilter = dk
                    row("TongSV_Kha") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên TB khá
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=4"
                    dvDiem.RowFilter = dk
                    row("TongSV_TBK") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên TB
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=5"
                    dvDiem.RowFilter = dk
                    row("TongSV_TB") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên yếu
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=6"
                    dvDiem.RowFilter = dk
                    row("TongSV_Yeu") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    ' Sinh viên kém
                    dk = " ID_nganh=" & mdtNganh.Rows(i).Item("ID_nganh").ToString
                    dk += " And ID_xep_loai=7"
                    dvDiem.RowFilter = dk
                    row("TongSV_Kem") = IIf(dvDiem.Count = 0, "", dvDiem.Count)
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "THỐNG KÊ DHHH"
        Public Function ThongKe_SoLuongSinhVien_TheoLop(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt As New DataTable
                dt = obj.ThongKeSoLuongSinhVien_TheoLop(ID_He, ID_khoa, Khoa_hoc)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKe_SoLuongSinhVien_TheoKhoa(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt As New DataTable
                dt = obj.ThongKe_SoLuongSinhVien_TheoKhoa(ID_He, ID_khoa, Khoa_hoc)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongKe_SoLuongSinhVien_TheoNganh(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt As New DataTable
                dt = obj.ThongKe_SoLuongSinhVien_TheoNganh(ID_He, ID_khoa, Khoa_hoc)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongTinDanhBaSinhVien(Optional ByVal ID_He As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0) As DataTable
            Try
                Dim obj As New TongHopThongKe_DataAccess
                Dim dt As New DataTable
                dt = obj.ThongTinDanhBaSinhVien()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region
    End Class
End Namespace
