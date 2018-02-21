'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 21, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class MonTinChi_Bussines
        Private arrMonTinChi As New ArrayList
        Private mKy_dang_ky As Integer = 0
        Private mDot As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTu_ngay As Date
        Private mDen_ngay As Date
        Private mdtKeHoachKhac As New DataTable
#Region "Initialize"
        Sub New()

        End Sub
        Sub New(ByVal Ky_dang_ky As Integer)
            Dim clsDAL As New MonTinChi_DataAccess
            Dim dtMon, dtLop, dtPhamVi, dtKyDangKy As DataTable
            'Load môn tín chỉ đã tạo trong học kỳ
            dtMon = clsDAL.HienThi_ESSMonTinChi_DanhSach(Ky_dang_ky)
            'Load lớp tín chỉ của các môn
            dtLop = clsDAL.HienThi_ESSLopTinChi_DanhSach(Ky_dang_ky)
            'Load phạm vi đăng ký của các môn
            dtPhamVi = clsDAL.HienThi_ESSPhamViDangKy_DanhSach(Ky_dang_ky)
            'Load thời gian trong học kỳ
            dtKyDangKy = clsDAL.HienThi_ESSHocKyDangKy_DanhSach(Ky_dang_ky)
            For idx_mon As Integer = 0 To dtMon.Rows.Count - 1
                If dtMon.Rows(idx_mon)("ID_mon") = 370 Then
                    dtMon.Rows(idx_mon)("ID_mon") = 370
                End If
                Dim objMonTC As New ESSMonTinChi
                objMonTC = MappingMonTinChi(dtMon.Rows(idx_mon))
                'Lọc các lớp theo ID_mon_tc
                dtLop.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                'Add các lớp tín chỉ thuộc môn tín chỉ
                If dtLop.DefaultView.Count > 0 Then
                    'Add các lớp tín chỉ
                    For idx_lop As Integer = 0 To dtLop.DefaultView.Count - 1
                        Dim objLopTC As New ESSLopTinChi
                        objLopTC = MappingLopTinChi(dtLop.DefaultView.Item(idx_lop).Row)
                        objMonTC.dsLopTinChi.Add(objLopTC)
                    Next
                End If
                'Add phạm vi đăng ký của môn tín chỉ
                'Lọc phạm vi đăng ký theo ID_mon_tc
                dtPhamVi.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                If dtPhamVi.Rows.Count > 0 Then
                    For idx_pv As Integer = 0 To dtPhamVi.DefaultView.Count - 1
                        Dim objPhamVi As New ESSPhamViDangKy
                        objPhamVi = MappingPhamViDangKy(dtPhamVi.DefaultView.Item(idx_pv).Row)
                        objMonTC.dsPhamViDangKy.Add(objPhamVi)
                    Next
                End If
                arrMonTinChi.Add(objMonTC)
            Next
            'Thời gian trong học kỳ đăng ký
            mKy_dang_ky = Ky_dang_ky
            If dtKyDangKy.Rows.Count > 0 Then
                Dot = dtKyDangKy.Rows(0)("Dot")
                Hoc_ky = dtKyDangKy.Rows(0)("Hoc_ky")
                Nam_hoc = dtKyDangKy.Rows(0)("Nam_hoc")
                Tu_ngay = dtKyDangKy.Rows(0)("Tu_ngay")
                Den_ngay = dtKyDangKy.Rows(0)("Den_ngay")
                'Load kế hoạch khác
                mdtKeHoachKhac = clsDAL.HienThi_ESSKeHoachKhac_DanhSach(Hoc_ky, Nam_hoc)
            End If
        End Sub

        Sub New(ByVal Ky_dang_ky As Integer, ByVal ID_bomon As Integer, Optional ByVal ID_khoa As Integer = 0, Optional ByVal User_Name As String = "")
            Dim clsDAL As New MonTinChi_DataAccess
            Dim dtMon, dtLop, dtPhamVi, dtKyDangKy As DataTable
            'Load môn tín chỉ đã tạo trong học kỳ
            dtMon = clsDAL.HienThi_ESSMonTinChi_PhanQuyen_DanhSach(Ky_dang_ky, 0, ID_khoa)
            'Load lớp tín chỉ của các môn
            dtLop = clsDAL.HienThi_ESSLopTinChi_DanhSach(Ky_dang_ky, ID_bomon, ID_khoa, User_Name)
            'Load phạm vi đăng ký của các môn
            dtPhamVi = clsDAL.HienThi_ESSPhamViDangKy_DanhSach(Ky_dang_ky, 0, ID_khoa)
            'Load thời gian trong học kỳ
            dtKyDangKy = clsDAL.HienThi_ESSHocKyDangKy_DanhSach(Ky_dang_ky)
            For idx_mon As Integer = 0 To dtMon.Rows.Count - 1
                Dim objMonTC As New ESSMonTinChi
                objMonTC = MappingMonTinChi(dtMon.Rows(idx_mon))
                'Lọc các lớp theo ID_mon_tc
                dtLop.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                'Add các lớp tín chỉ thuộc môn tín chỉ
                If dtLop.DefaultView.Count > 0 Then
                    'Add các lớp tín chỉ
                    For idx_lop As Integer = 0 To dtLop.DefaultView.Count - 1
                        Dim objLopTC As New ESSLopTinChi
                        objLopTC = MappingLopTinChi(dtLop.DefaultView.Item(idx_lop).Row)
                        objMonTC.dsLopTinChi.Add(objLopTC)
                    Next
                End If
                'Add phạm vi đăng ký của môn tín chỉ
                'Lọc phạm vi đăng ký theo ID_mon_tc
                dtPhamVi.DefaultView.RowFilter = "ID_mon_tc=" + objMonTC.ID_mon_tc.ToString
                If dtPhamVi.Rows.Count > 0 Then
                    For idx_pv As Integer = 0 To dtPhamVi.DefaultView.Count - 1
                        Dim objPhamVi As New ESSPhamViDangKy
                        objPhamVi = MappingPhamViDangKy(dtPhamVi.DefaultView.Item(idx_pv).Row)
                        objMonTC.dsPhamViDangKy.Add(objPhamVi)
                    Next
                End If
                arrMonTinChi.Add(objMonTC)
            Next

            'Thời gian trong học kỳ đăng ký
            mKy_dang_ky = Ky_dang_ky
            If dtKyDangKy.Rows.Count > 0 Then
                Dot = dtKyDangKy.Rows(0)("Dot")
                Hoc_ky = dtKyDangKy.Rows(0)("Hoc_ky")
                Nam_hoc = dtKyDangKy.Rows(0)("Nam_hoc")
                Tu_ngay = dtKyDangKy.Rows(0)("Tu_ngay")
                Den_ngay = dtKyDangKy.Rows(0)("Den_ngay")
                'Load kế hoạch khác
                mdtKeHoachKhac = clsDAL.HienThi_ESSKeHoachKhac_DanhSach(Hoc_ky, Nam_hoc)
            End If
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThongKePhanPhongHoc(ByVal Ca_hoc As Integer) As DataTable
            Dim Ngay_dau, Ngay_cuoi As Date
            Dim Tuan_thu As Integer
            Dim phs As New PhongHoc_Bussines()
            Dim dtPhong As New DataTable
            Dim flag As Boolean = False
            dtPhong.Columns.Add("ID_phong", GetType(Integer))
            dtPhong.Columns.Add("Ten_phong", GetType(String))
            'Add các cột tuần trong kỳ đăng ký
            Tuan_thu = DatePart(DateInterval.WeekOfYear, Tu_ngay)
            Ngay_dau = Tu_ngay
            Ngay_cuoi = Ngay_dau.AddDays(1)
            Do While Ngay_cuoi <= Den_ngay
                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                    dtPhong.Columns.Add("T" + Tuan_thu.ToString)
                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Ngay_dau = Ngay_cuoi
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                End If
                Ngay_cuoi = Ngay_cuoi.AddDays(1)
            Loop
            'Duyệt danh sách phòng học
            For p As Integer = 0 To phs.Count - 1
                Dim dr As DataRow = dtPhong.NewRow
                dr("ID_phong") = phs.Phong_hoc(p).ID_phong
                dr("Ten_phong") = phs.Phong_hoc(p).Ten_phong
                'Duyệt danh sách kế hoạch lớp tín chỉ
                flag = False
                For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                    Dim objMonTC As New ESSMonTinChi
                    objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                    For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                        Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                        If phs.Phong_hoc(p).ID_phong = objLopTC.ID_phong And objLopTC.Ca_hoc = Ca_hoc Then
                            'Add thông tin số tiết của phòng học trong tuần
                            Tuan_thu = DatePart(DateInterval.WeekOfYear, objLopTC.Tu_ngay)
                            Ngay_dau = objLopTC.Tu_ngay
                            Ngay_cuoi = Ngay_dau.AddDays(1)
                            Do While Ngay_cuoi <= objLopTC.Den_ngay
                                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                                    If dtPhong.Columns.Contains("T" + Tuan_thu.ToString) Then
                                        If dr("T" + Tuan_thu.ToString).ToString = "" Then
                                            dr("T" + Tuan_thu.ToString) = objLopTC.So_tiet_tuan
                                        Else
                                            dr("T" + Tuan_thu.ToString) = dr("T" + Tuan_thu.ToString) + objLopTC.So_tiet_tuan
                                        End If
                                        flag = True
                                    End If
                                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                                    Ngay_dau = Ngay_cuoi
                                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                                End If
                                Ngay_cuoi = Ngay_cuoi.AddDays(1)
                            Loop
                        End If
                    Next
                Next
                If flag Then dtPhong.Rows.Add(dr)
            Next
            dtPhong.DefaultView.Sort = "Ten_phong"
            Return dtPhong
        End Function
        Public Function DanhSachHocPhan() As DataTable
            Dim dtMon As New DataTable
            Dim Add_new As Boolean = False
            dtMon.Columns.Add("ID_mon", GetType(Integer))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi = CType(arrMonTinChi(i), ESSMonTinChi)
                Add_new = True
                For j As Integer = 0 To dtMon.Rows.Count - 1
                    If dtMon.Rows(j)("ID_mon") = objMonTC.ID_mon Then
                        Add_new = False
                        Exit For
                    End If
                Next
                If Add_new Then
                    Dim dr As DataRow = dtMon.NewRow
                    dr("ID_mon") = objMonTC.ID_mon
                    dr("Ten_mon") = objMonTC.Ten_mon + "(" + objMonTC.Ky_hieu + ")"
                    dtMon.Rows.Add(dr)
                End If
            Next
            Return dtMon
        End Function

        Public Function DanhSachKyHieuLop(ByVal ID_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("Ky_hieu_lop_tc1", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi = CType(arrMonTinChi(i), ESSMonTinChi)
                If objMonTC.ID_mon = ID_mon Then
                    Dim dr As DataRow = dtLop.NewRow
                    dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                    dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                    dtLop.Rows.Add(dr)
                End If
            Next
            Return dtLop
        End Function

        Public Function getKyDangKy(ByVal Dot As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Dim clsDAL As New MonTinChi_DataAccess
            Dim dtKyDangKy As DataTable
            dtKyDangKy = clsDAL.HienThi_ESSHocKyDangKy_DanhSach(Dot, Hoc_ky, Nam_hoc)
            If dtKyDangKy.Rows.Count > 0 Then
                Return dtKyDangKy.Rows(0)(0)
            Else
                Return 0
            End If
        End Function


        Public Function DanhSachMonTinChi() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("Chon", GetType(Boolean))
            dtMon.Columns.Add("idx_mon", GetType(Integer))
            dtMon.Columns.Add("ID_mon_tc", GetType(Integer))
            dtMon.Columns.Add("ID_mon", GetType(Integer))
            dtMon.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            dtMon.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtMon.Columns.Add("Ly_thuyet", GetType(Integer))
            dtMon.Columns.Add("Thuc_hanh", GetType(Integer))
            dtMon.Columns.Add("Bai_tap", GetType(Integer))
            dtMon.Columns.Add("Bai_tap_lon", GetType(Integer))
            dtMon.Columns.Add("So_tiet", GetType(Integer))
            dtMon.Columns.Add("He_so", GetType(Integer))
            dtMon.Columns.Add("So_tien", GetType(Integer))
            dtMon.Columns.Add("Kien_thuc", GetType(Integer))
            dtMon.Columns.Add("Ky_hieu", GetType(String))
            dtMon.Columns.Add("ID_he", GetType(Integer))
            dtMon.Columns.Add("ID_khoa", GetType(Integer))
            dtMon.Columns.Add("Khoa_hoc", GetType(Integer))
            dtMon.Columns.Add("ID_nganh", GetType(Integer))
            dtMon.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtMon.Columns.Add("So_lop_tc", GetType(Integer))
            dtMon.Columns.Add("Locked", GetType(Boolean))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi = CType(arrMonTinChi(i), ESSMonTinChi)
                Dim dr As DataRow = dtMon.NewRow
                dr("Chon") = False
                dr("idx_mon") = i
                dr("ID_mon_tc") = objMonTC.ID_mon_tc
                dr("ID_mon") = objMonTC.ID_mon
                dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                dr("Ten_mon") = objMonTC.Ten_mon
                dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                dr("Ly_thuyet") = objMonTC.Ly_thuyet
                dr("Thuc_hanh") = objMonTC.Thuc_hanh
                dr("Bai_tap") = objMonTC.Bai_tap
                dr("Bai_tap_lon") = objMonTC.Bai_tap_lon
                dr("So_tiet") = objMonTC.Ly_thuyet + objMonTC.Thuc_hanh + objMonTC.Bai_tap + objMonTC.Bai_tap_lon
                dr("He_so") = objMonTC.He_so
                dr("So_tien") = objMonTC.So_tien
                dr("Kien_thuc") = objMonTC.Kien_thuc
                dr("Ky_hieu") = objMonTC.Ky_hieu
                dr("So_lop_tc") = objMonTC.dsLopTinChi.Count
                dr("Locked") = objMonTC.Locked
                For j As Integer = 0 To objMonTC.dsPhamViDangKy.Count - 1
                    Dim objPV As ESSPhamViDangKy = CType(objMonTC.dsPhamViDangKy.ESSPhamViDangKy(j), ESSPhamViDangKy)
                    dr("ID_he") = objPV.ID_he
                    dr("ID_khoa") = objPV.ID_khoa
                    dr("Khoa_hoc") = objPV.Khoa_hoc
                    dr("ID_nganh") = objPV.ID_nganh
                    dr("ID_chuyen_nganh") = objPV.ID_chuyen_nganh
                Next

                dtMon.Rows.Add(dr)
            Next
            Return dtMon
        End Function

        Public Function DanhSachMonTinChiTKB() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon_tc", GetType(Integer))
            dtMon.Columns.Add("Ten_mon", GetType(String))
            For i As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi = CType(arrMonTinChi(i), ESSMonTinChi)
                Dim dr As DataRow = dtMon.NewRow
                dr("ID_mon_tc") = objMonTC.ID_mon_tc
                dr("Ten_mon") = objMonTC.Ten_mon + "(" + objMonTC.Ky_hieu_lop_tc + ")"
                dtMon.Rows.Add(dr)
            Next
            Return dtMon
        End Function

        Public Function DanhSachMonLopTinChi() As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    If objLopTC.ID_lop_tc > 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                        If idx >= 0 Then
                            dr("ID_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_he
                            dr("ID_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_khoa
                            dr("Ten_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_he
                            dr("Ten_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_khoa
                            dr("Khoa_hoc") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Khoa_hoc
                        End If
                        dr("ID_mon_tc") = objMonTC.ID_mon_tc
                        dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                        dr("ID_mon") = objMonTC.ID_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("Ky_hieu") = objMonTC.Ky_hieu
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dr("So_hoc_trinh") = objLopTC.So_hoc_trinh
                        dr("Chon") = False
                        dtLop.Rows.Add(dr)
                    End If
                Next
            Next
            dtLop.DefaultView.Sort = "ID_he,ID_khoa,Ten_mon,Ky_hieu_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachMonLopTinChi(ByVal ID_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                If objMonTC.ID_mon = ID_mon Then
                    For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                        Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                        If objLopTC.ID_lop_tc > 0 Then
                            Dim dr As DataRow = dtLop.NewRow
                            idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                            If idx >= 0 Then
                                dr("ID_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_he
                                dr("ID_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_khoa
                                dr("Ten_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_he
                                dr("Ten_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_khoa
                                dr("Khoa_hoc") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Khoa_hoc
                            End If
                            dr("ID_mon_tc") = objMonTC.ID_mon_tc
                            dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                            dr("ID_mon") = objMonTC.ID_mon
                            dr("Ten_mon") = objMonTC.Ten_mon
                            dr("Ky_hieu") = objMonTC.Ky_hieu
                            dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                            dr("ID_lop_tc") = objLopTC.ID_lop_tc
                            dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                            dtLop.Rows.Add(dr)
                        End If
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "ID_he,ID_khoa,Ten_mon,Ky_hieu_lop_tc"
            Return dtLop
        End Function

        Public Function DanhSachMonLopTinChi_TCT() As DataTable
            Dim dtLop As New DataTable
            Dim idx As Integer
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("ID_mon", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    If objLopTC.ID_lop_tc > 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                        If idx >= 0 Then
                            dr("ID_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_he
                            dr("ID_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_khoa
                            dr("Ten_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_he
                            dr("Ten_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Ten_khoa
                        End If
                        dr("ID_mon_tc") = objMonTC.ID_mon_tc
                        dr("Ky_hieu_lop_tc") = objMonTC.Ky_hieu_lop_tc
                        dr("ID_mon") = objMonTC.ID_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dtLop.Rows.Add(dr)
                    End If
                Next
            Next
            dtLop.DefaultView.Sort = "ID_he,ID_khoa,Ten_mon"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi(ByVal idx_mon As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_CB", GetType(Integer))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            If idx_mon >= 0 Then
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    If objLopTC.ID_lop_tc > 0 Then
                        Dim dr As DataRow = dtLop.NewRow
                        dr("ID") = 0
                        dr("idx_lop") = i
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("STT_lop") = objLopTC.STT_lop
                        dr("So_sv_min") = objLopTC.So_sv_min
                        dr("So_sv_max") = objLopTC.So_sv_max
                        dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("CaID") = objLopTC.Ca_hoc
                        dr("ID_phong") = objLopTC.ID_phong
                        dr("ID_cb") = objLopTC.ID_cb
                        dr("Ho_ten") = objLopTC.Ho_ten_gv
                        dr("Tu_ngay") = objLopTC.Tu_ngay
                        dr("Den_ngay") = objLopTC.Den_ngay
                        dtLop.Rows.Add(dr)
                    End If
                Next
            End If
            dtLop.DefaultView.Sort = "STT_lop"
            Return dtLop
        End Function

        Public Function DanhSachPhanGiaoVien(ByVal ID_bm As Integer) As DataTable
            Dim dtLop As New DataTable
            Dim gvs As New GiaoVien_Bussines()
            Dim idx As Integer
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_cb", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                If objMonTC.ID_bm = ID_bm Or ID_bm = 0 Then
                    For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                        Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                        Dim dr As DataRow = dtLop.NewRow
                        'Thông tin môn
                        dr("idx_mon") = idx_mon
                        dr("Ten_mon") = objMonTC.Ten_mon
                        dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                        'Thông tin lớp
                        dr("idx_lop") = i
                        dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("ID_cb") = objLopTC.ID_cb
                        idx = gvs.Tim_chi_so_theo_ID_cb(objLopTC.ID_cb)
                        If idx >= 0 Then
                            dr("Ho_ten") = gvs.Giaovien(idx).Ho_ten
                        End If
                        dtLop.Rows.Add(dr)
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "Ten_mon"
            Return dtLop
        End Function

        Public Function DanhSachPhanPhongHoc() As DataTable
            Dim dtLop As New DataTable
            Dim phs As New PhongHoc_Bussines()
            Dim idx As Integer
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Ten_phong", GetType(String))
            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    Dim dr As DataRow = dtLop.NewRow
                    'Thông tin môn
                    dr("idx_mon") = idx_mon
                    dr("Ten_mon") = objMonTC.Ten_mon
                    dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                    'Thông tin lớp
                    dr("idx_lop") = i
                    dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                    dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                    dr("ID_phong") = objLopTC.ID_phong
                    idx = phs.Tim_chi_so(objLopTC.ID_phong)
                    If idx >= 0 Then dr("Ten_phong") = phs.Phong_hoc(idx).So_phong
                    dtLop.Rows.Add(dr)
                Next
            Next
            dtLop.DefaultView.Sort = "Ten_mon"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi() As DataTable
            Dim dtLop As New DataTable
            Dim Ngay_dau, Ngay_cuoi As Date
            Dim Ky_hieu As String
            Dim Tuan_thu As Integer
            Dim phs As New PhongHoc_Bussines()
            Dim gvs As New GiaoVien_Bussines()
            Dim idx As Integer
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("idx_mon", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ly_thuyet", GetType(Integer))
            dtLop.Columns.Add("Thuc_hanh", GetType(Integer))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Giao_vien", GetType(String))
            dtLop.Columns.Add("Phong_hoc", GetType(String))
            'Add các cột tuần trong kỳ đăng ký
            Tuan_thu = DatePart(DateInterval.WeekOfYear, Tu_ngay)
            Ngay_dau = Tu_ngay
            Ngay_cuoi = Ngay_dau.AddDays(1)
            Do While Ngay_cuoi <= Den_ngay
                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                    dtLop.Columns.Add("T" + Tuan_thu.ToString)
                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Ngay_dau = Ngay_cuoi
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                End If
                Ngay_cuoi = Ngay_cuoi.AddDays(1)
            Loop

            For idx_mon As Integer = 0 To arrMonTinChi.Count - 1
                Dim objMonTC As New ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    Dim dr As DataRow = dtLop.NewRow
                    'Thông tin môn
                    dr("idx_mon") = idx_mon
                    dr("Ky_hieu") = objMonTC.Ky_hieu
                    dr("Ten_mon") = objMonTC.Ten_mon
                    dr("So_hoc_trinh") = objMonTC.So_hoc_trinh
                    dr("Ly_thuyet") = objMonTC.Ly_thuyet
                    dr("Thuc_hanh") = objMonTC.Thuc_hanh
                    idx = objMonTC.dsPhamViDangKy.Tim_idx(objMonTC.ID_mon_tc)
                    If idx >= 0 Then
                        dr("ID_he") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_he
                        dr("ID_khoa") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_khoa
                        dr("ID_nganh") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_nganh
                        dr("ID_chuyen_nganh") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).ID_chuyen_nganh
                        dr("Khoa_hoc") = objMonTC.dsPhamViDangKy.ESSPhamViDangKy(idx).Khoa_hoc
                    End If
                    'Thông tin lớp
                    dr("idx_lop") = i
                    dr("Ten_lop_tc") = objLopTC.Ten_lop_tc
                    dr("So_sv_min") = objLopTC.So_sv_min
                    dr("So_sv_max") = objLopTC.So_sv_max
                    dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                    dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                    dr("Tu_ngay") = objLopTC.Tu_ngay
                    dr("Den_ngay") = objLopTC.Den_ngay
                    idx = gvs.Tim_chi_so_theo_ID_cb(objLopTC.ID_cb)
                    If idx >= 0 Then dr("Giao_vien") = gvs.Giaovien(idx).Ho_ten
                    idx = phs.Tim_chi_so(objLopTC.ID_phong)
                    If idx >= 0 Then dr("Phong_hoc") = phs.Phong_hoc(idx).So_phong
                    'Add thông tin thời gian học của từng lớp
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, objLopTC.Tu_ngay)
                    Ngay_dau = objLopTC.Tu_ngay
                    Ngay_cuoi = Ngay_dau.AddDays(1)
                    Do While Ngay_cuoi <= objLopTC.Den_ngay
                        If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                            If dtLop.Columns.Contains("T" + Tuan_thu.ToString) Then
                                'Kiểm tra xem tuần này có kế hoạch khác không?
                                Ky_hieu = CheckKeHoachKhac(mdtKeHoachKhac, Tuan_thu, dr("ID_he"), dr("ID_khoa"), dr("Khoa_hoc"), dr("ID_nganh"), dr("ID_chuyen_nganh"))
                                If Ky_hieu <> "" Then
                                    dr("T" + Tuan_thu.ToString) = Ky_hieu
                                Else
                                    dr("T" + Tuan_thu.ToString) = "H"
                                End If
                            End If
                            Ngay_cuoi = Ngay_cuoi.AddDays(1)
                            Ngay_dau = Ngay_cuoi
                            Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                        End If
                        Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Loop
                    dtLop.Rows.Add(dr)
                Next
            Next
            dtLop.DefaultView.Sort = "Ky_hieu"
            Return dtLop
        End Function

        Public Function DanhSachNhomTinChi(ByVal idx_mon As Integer, ByVal ID_lop_lt As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_cb", GetType(Integer))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            If idx_mon >= 0 Then
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsLopTinChi.Count - 1
                    Dim objLopTC As ESSLopTinChi = CType(objMonTC.dsLopTinChi.ESSLopTinChi(i), ESSLopTinChi)
                    If objLopTC.ID_lop_lt = ID_lop_lt Then
                        Dim dr As DataRow = dtLop.NewRow
                        dr("ID") = 0
                        dr("idx_lop") = i
                        dr("ID_lop_tc") = objLopTC.ID_lop_tc
                        dr("STT_lop") = objLopTC.STT_lop
                        dr("So_sv_min") = objLopTC.So_sv_min
                        dr("So_sv_max") = objLopTC.So_sv_max
                        dr("So_tiet_tuan") = objLopTC.So_tiet_tuan
                        dr("So_hoc_trinh") = objLopTC.So_hoc_trinh
                        dr("Ca_hoc") = objLopTC.Ten_ca_hoc
                        dr("CaID") = objLopTC.Ca_hoc
                        dr("ID_phong") = objLopTC.ID_phong
                        dr("ID_cb") = objLopTC.ID_cb
                        dr("Tu_ngay") = objLopTC.Tu_ngay
                        dr("Den_ngay") = objLopTC.Den_ngay
                        dtLop.Rows.Add(dr)
                    End If
                Next
            End If
            dtLop.DefaultView.Sort = "STT_lop"
            Return dtLop
        End Function

        Public Function DanhSachPhamViDangKy(ByVal idx_mon As Integer) As DataTable
            Dim dtPhamVi As New DataTable
            dtPhamVi.Columns.Add("ID_he", GetType(Integer))
            dtPhamVi.Columns.Add("ID_khoa", GetType(Integer))
            dtPhamVi.Columns.Add("Khoa_hoc", GetType(Integer))
            dtPhamVi.Columns.Add("ID_nganh", GetType(Integer))
            dtPhamVi.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            If idx_mon >= 0 Then
                Dim objMonTC As ESSMonTinChi
                objMonTC = CType(arrMonTinChi(idx_mon), ESSMonTinChi)
                For i As Integer = 0 To objMonTC.dsPhamViDangKy.Count - 1
                    Dim objPV As ESSPhamViDangKy = CType(objMonTC.dsPhamViDangKy.ESSPhamViDangKy(i), ESSPhamViDangKy)
                    Dim dr As DataRow = dtPhamVi.NewRow
                    dr("ID_he") = objPV.ID_he
                    dr("ID_khoa") = objPV.ID_khoa
                    dr("Khoa_hoc") = objPV.Khoa_hoc
                    dr("ID_nganh") = objPV.ID_nganh
                    dr("ID_chuyen_nganh") = objPV.ID_chuyen_nganh
                    dtPhamVi.Rows.Add(dr)
                Next
            End If
            Return dtPhamVi
        End Function

        Public Function HienThi_ESSDanhSachMonTinChi(ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.HienThi_ESSChuongTrinhDaoTaoChiTietMonTinChi_DanhSach(Kien_thuc, Ky_thu, Bat_buoc, Tu_chon, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Public Function HienThi_ESSMonTinChi(ByVal ID_mon As Integer, ByVal Kien_thuc As Integer, ByVal Ky_thu As Integer, ByVal Bat_buoc As Integer, ByVal Tu_chon As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Khoa_hoc As Integer) As DataTable
        '    Try
        '        Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
        '        Return obj.HienThi_ESSChuongTrinhDaoTaoChiTietMonTinChi_DanhSach(Kien_thuc, Ky_thu, Bat_buoc, Tu_chon, ID_he, ID_khoa, ID_nganh, ID_chuyen_nganh, Khoa_hoc)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function HienThi_ESStkbHocKyDangKyQuyDinh_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.HienThi_ESSHocKyDangKyQuyDinh_DanhSach(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSMonTinChi(ByVal objMonTinChi As ESSMonTinChi) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.ThemMoi_ESSMonTinChi(objMonTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSMonTinChi(ByVal objMonTinChi As ESSMonTinChi, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CapNhat_ESSMonTinChi(objMonTinChi, ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KhoaMo_MonTinChi(ByVal Lock As Boolean, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.KhoaMo_MonTinChi(Lock, ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSMonTinChi(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.Xoa_ESSMonTinChi(ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_MonTinChi(ByVal Hoc_ky_dk As Integer, ByVal ID_mon As Integer, ByVal So_hoc_trinh As Integer) As Boolean
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.KiemTra_MonTinChi(Hoc_ky_dk, ID_mon, So_hoc_trinh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_MonTinChi_Ten(ByVal Hoc_ky_dk As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.KiemTra_MonTinChi_Ten(Hoc_ky_dk, Ky_hieu_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_MonTinChi_TenUpdate(ByVal ID_mon_tc As Integer, ByVal Hoc_ky_dk As Integer, ByVal Ky_hieu_lop_tc As String) As Boolean
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.KiemTra_MonTinChi_TenUpdate(ID_mon_tc, Hoc_ky_dk, Ky_hieu_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLopTinChi(ByVal objLopTinChi As ESSLopTinChi) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.ThemMoi_ESSLopTinChi(objLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChiEdit(ByVal objLopTinChi As ESSLopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChiEdit(objLopTinChi, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChi(ByVal objLopTinChi As ESSLopTinChi, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChi(objLopTinChi, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLopTinChi(ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.Xoa_ESSLopTinChi(ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSPhamViDangKy(ByVal objPhamViDangKy As ESSPhamViDangKy) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.ThemMoi_ESSPhamViDangKy(objPhamViDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSPhamViDangKy(ByVal objPhamViDangKy As ESSPhamViDangKy, ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CapNhat_ESSPhamViDangKy(objPhamViDangKy, ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSPhamViDangKy(ByVal ID_mon_tc As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.Xoa_ESSPhamViDangKy(ID_mon_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESStkbPhamViDangKyLop_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Return obj.HienThi_ESStkbPhamViDangKyLop_DanhSach(Ky_dang_ky, ID_dt)
        End Function

        Public Function HienThi_ESStkbPhamViDangKyLopChon_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_lop As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Dim dt As New DataTable
            dt = obj.HienThi_ESStkbPhamViDangKyLopChon_DanhSach(Ky_dang_ky, ID_lop)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt

        End Function

        Public Function HienThi_ESStkbPhamViDangKyLopPhanBo_DanhSach(ByVal Ky_dang_ky As Integer, ByVal ID_dt As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Dim dt As New DataTable
            dt = obj.HienThi_ESStkbPhamViDangKyLopPhanBo_DanhSach(Ky_dang_ky, ID_dt)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function

        Public Function HienThi_ESStkbPhamViDangKyHocPhan_DanhSach(ByVal ID_lop As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Dim dt As New DataTable
            dt = obj.HienThi_ESStkbPhamViDangKyHocPhan_DanhSach(ID_lop)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function

        Public Function HienThi_ESStkbPhamViDangKyHocPhanChon_DanhSach(ByVal ID_lop As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Dim dt As New DataTable
            dt = obj.HienThi_ESStkbPhamViDangKyHocPhanChon_DanhSach(ID_lop)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt


        End Function

        Public Function HienThi_ESStkbPhamViDangKyHocPhanPhanBo_DanhSach(ByVal ID_dt As Integer) As DataTable
            Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
            Dim dt As New DataTable
            dt = obj.HienThi_ESStkbPhamViDangKyHocPhanPhanBo_DanhSach(ID_dt)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function

        Public Function ThemMoi_ESStkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.ThemMoi_ESStkbPhamViDangKyLop(ID_lop_tc, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function CheckExist_tkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CheckExist_tkbPhamViDangKyLop(ID_lop_tc, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function Xoa_ESStkbPhamViDangKyLop(ByVal ID_lop_tc As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.Xoa_ESStkbPhamViDangKyLop(ID_lop_tc, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function ThemMoi_ESStkbPhamViDangKyHocPhan(ByVal ID_mon As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.ThemMoi_ESStkbPhamViDangKyHocPhan(ID_mon, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function Xoa_ESStkbPhamViDangKyHocPhan(ByVal ID_Mon As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.Xoa_ESStkbPhamViDangKyHocPhan(ID_Mon, ID_lop)
            Catch ex As Exception
            End Try
        End Function

        Public Function CheckExist_tkbPhamViDangKyHocPhan(ByVal ID_Mon As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.CheckExist_tkbPhamViDangKyHocPhan(ID_Mon, ID_lop)
            Catch ex As Exception
            End Try
        End Function


        Public Function HienThi_ESStkbKeHoachKhac_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.HienThi_ESSKeHoachKhac_DanhSach(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESStkbKeHoachKyHieu_DanhSach() As DataTable
            Try
                Dim obj As MonTinChi_DataAccess = New MonTinChi_DataAccess
                Return obj.HienThi_ESSKeHoachKyHieu_DanhSach()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function CheckKeHoachKhac(ByVal dtKeHoachKhac As DataTable, ByVal Tuan_thu As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Dim Ky_hieu As String = ""
            For i As Integer = 0 To dtKeHoachKhac.Rows.Count - 1
                If (dtKeHoachKhac.Rows(i)("ID_he") = 0 Or (dtKeHoachKhac.Rows(i)("ID_he") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_he") = ID_he)) And _
                    (dtKeHoachKhac.Rows(i)("ID_khoa") = 0 Or (dtKeHoachKhac.Rows(i)("ID_khoa") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_khoa") = ID_khoa)) And _
                    (dtKeHoachKhac.Rows(i)("Khoa_hoc") = 0 Or (dtKeHoachKhac.Rows(i)("Khoa_hoc") > 0 AndAlso dtKeHoachKhac.Rows(i)("Khoa_hoc") = Khoa_hoc)) And _
                    (dtKeHoachKhac.Rows(i)("ID_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_nganh") = ID_nganh)) And _
                    (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = ID_chuyen_nganh)) Then
                    If DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Tu_ngay")) <= Tuan_thu And _
                        DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Den_ngay")) > Tuan_thu Then
                        Ky_hieu = dtKeHoachKhac.Rows(i)("Ky_hieu")
                    End If
                End If
            Next
            Return Ky_hieu
        End Function
        Private Function MappingMonTinChi(ByVal drMonTinChi As DataRow) As ESSMonTinChi
            Dim result As ESSMonTinChi
            Try
                result = New ESSMonTinChi
                If drMonTinChi("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drMonTinChi("ID_mon_tc").ToString(), Integer)
                If drMonTinChi("Ky_dang_ky").ToString() <> "" Then result.Ky_dang_ky = CType(drMonTinChi("Ky_dang_ky").ToString(), Integer)
                result.Ky_hieu_lop_tc = drMonTinChi("Ky_hieu_lop_tc").ToString()
                result.Ky_hieu = drMonTinChi("Ky_hieu").ToString()
                result.Ten_mon = drMonTinChi("Ten_mon").ToString()
                If drMonTinChi("ID_mon").ToString() <> "" Then result.ID_mon = CType(drMonTinChi("ID_mon").ToString(), Integer)
                If drMonTinChi("ID_bm").ToString() <> "" Then result.ID_bm = CType(drMonTinChi("ID_bm").ToString(), Integer)
                If drMonTinChi("So_tin_chi").ToString() <> "" Then result.So_hoc_trinh = CType(drMonTinChi("So_tin_chi").ToString(), Integer)
                If drMonTinChi("Ly_thuyet").ToString() <> "" Then result.Ly_thuyet = CType(drMonTinChi("Ly_thuyet").ToString(), Integer)
                If drMonTinChi("Thuc_hanh").ToString() <> "" Then result.Thuc_hanh = CType(drMonTinChi("Thuc_hanh").ToString(), Integer)
                If drMonTinChi("Bai_tap").ToString() <> "" Then result.Bai_tap = CType(drMonTinChi("Bai_tap").ToString(), Integer)
                If drMonTinChi("Bai_tap_lon").ToString() <> "" Then result.Bai_tap_lon = CType(drMonTinChi("Bai_tap_lon").ToString(), Integer)
                If drMonTinChi("He_so").ToString() <> "" Then result.He_so = CType(drMonTinChi("He_so").ToString(), Integer)
                If drMonTinChi("So_tien").ToString() <> "" Then result.So_tien = CType(drMonTinChi("So_tien").ToString(), Integer)
                If drMonTinChi("Locked").ToString() <> "" Then result.Locked = CType(drMonTinChi("Locked").ToString(), Boolean)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingLopTinChi(ByVal drtkbLopTinChi As DataRow) As ESSLopTinChi
            Dim result As ESSLopTinChi
            Try
                result = New ESSLopTinChi
                If drtkbLopTinChi("So_tin_chi").ToString() <> "" Then result.So_hoc_trinh = CType(drtkbLopTinChi("So_tin_chi").ToString(), Integer)
                If drtkbLopTinChi("ID_lop_tc").ToString() <> "" Then result.ID_lop_tc = CType(drtkbLopTinChi("ID_lop_tc").ToString(), Integer)
                If drtkbLopTinChi("ID_lop_lt").ToString() <> "" Then result.ID_lop_lt = CType(drtkbLopTinChi("ID_lop_lt").ToString(), Integer)
                If drtkbLopTinChi("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drtkbLopTinChi("ID_mon_tc").ToString(), Integer)
                If drtkbLopTinChi("STT_lop").ToString() <> "" Then result.STT_lop = CType(drtkbLopTinChi("STT_lop").ToString(), Integer)
                result.Ky_hieu_lop_tc = drtkbLopTinChi("Ky_hieu_lop_tc").ToString
                If drtkbLopTinChi("STT_lop_lt").ToString() <> "" Then result.STT_lop_lt = CType(drtkbLopTinChi("STT_lop_lt").ToString(), Integer)
                If drtkbLopTinChi("So_sv_min").ToString() <> "" Then result.So_sv_min = CType(drtkbLopTinChi("So_sv_min").ToString(), Integer)
                If drtkbLopTinChi("So_sv_max").ToString() <> "" Then result.So_sv_max = CType(drtkbLopTinChi("So_sv_max").ToString(), Integer)
                If drtkbLopTinChi("Tu_ngay").ToString() <> "" Then result.Tu_ngay = CType(drtkbLopTinChi("Tu_ngay").ToString(), Date)
                If drtkbLopTinChi("Den_ngay").ToString() <> "" Then result.Den_ngay = CType(drtkbLopTinChi("Den_ngay").ToString(), Date)
                If drtkbLopTinChi("Ca_hoc").ToString() <> "" Then result.Ca_hoc = CType(drtkbLopTinChi("Ca_hoc").ToString(), Integer)
                result.Ten_ca_hoc = drtkbLopTinChi("Ten_ca").ToString()
                If drtkbLopTinChi("So_tiet_tuan").ToString() <> "" Then result.So_tiet_tuan = CType(drtkbLopTinChi("So_tiet_tuan").ToString(), Integer)
                If drtkbLopTinChi("ID_phong").ToString() <> "" Then result.ID_phong = CType(drtkbLopTinChi("ID_phong").ToString(), Integer)
                If drtkbLopTinChi("ID_cb").ToString() <> "" Then result.ID_cb = CType(drtkbLopTinChi("ID_cb").ToString(), Integer)
                result.Huy_lop = drtkbLopTinChi("Huy_lop").ToString()
                result.Ly_do = drtkbLopTinChi("Ly_do").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingPhamViDangKy(ByVal drPhamViDangKy As DataRow) As ESSPhamViDangKy
            Dim result As ESSPhamViDangKy
            Try
                result = New ESSPhamViDangKy
                If drPhamViDangKy("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drPhamViDangKy("ID_mon_tc").ToString(), Integer)
                If drPhamViDangKy("ID_he").ToString() <> "" Then result.ID_he = CType(drPhamViDangKy("ID_he").ToString(), Integer)
                result.Ten_he = drPhamViDangKy("Ten_he").ToString()
                If drPhamViDangKy("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drPhamViDangKy("ID_khoa").ToString(), Integer)
                result.Ten_khoa = drPhamViDangKy("Ten_khoa").ToString()
                If drPhamViDangKy("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drPhamViDangKy("Khoa_hoc").ToString(), Integer)
                If drPhamViDangKy("ID_nganh").ToString() <> "" Then result.ID_nganh = CType(drPhamViDangKy("ID_nganh").ToString(), Integer)
                If drPhamViDangKy("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drPhamViDangKy("ID_chuyen_nganh").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
        Public Sub Add(ByVal mon As ESSMonTinChi)
            arrMonTinChi.Add(mon)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrMonTinChi.RemoveAt(idx)
        End Sub

        Public Function Tim_idx(ByVal ID_mon_tc As Integer) As Integer
            For i As Integer = 0 To arrMonTinChi.Count - 1
                If CType(arrMonTinChi(i), ESSMonTinChi).ID_mon_tc = ID_mon_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx(ByVal Ky_hieu As String, ByVal Ky_hieu_lop_tc As String, ByVal So_hoc_trinh As Integer) As Integer
            For i As Integer = 0 To arrMonTinChi.Count - 1
                If CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu = Ky_hieu And _
                CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu_lop_tc = Ky_hieu_lop_tc And _
                CType(arrMonTinChi(i), ESSMonTinChi).So_hoc_trinh = So_hoc_trinh Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Tim_idx(ByVal Ky_hieu As String, ByVal Ky_hieu_lop_tc As String, ByVal So_hoc_trinh As Integer, ByVal ID_he As Integer, ByVal khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal ID_chuyen_nganh As Integer) As Integer
            For i As Integer = 0 To arrMonTinChi.Count - 1
                If CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu = Ky_hieu And _
                CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu_lop_tc = Ky_hieu_lop_tc And _
                CType(arrMonTinChi(i), ESSMonTinChi).So_hoc_trinh = So_hoc_trinh And _
                CType(arrMonTinChi(i), ESSMonTinChi).dsPhamViDangKy().ID_he = ID_he And _
                CType(arrMonTinChi(i), ESSMonTinChi).dsPhamViDangKy().Khoa_hoc = khoa_hoc And _
                CType(arrMonTinChi(i), ESSMonTinChi).dsPhamViDangKy().ID_khoa = ID_khoa And _
                CType(arrMonTinChi(i), ESSMonTinChi).dsPhamViDangKy().ID_chuyen_nganh = ID_chuyen_nganh Then

                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Tim_lop_tc_idx(ByVal idx_mon_tc As String, ByVal STT_lop As Integer) As Integer
            For i As Integer = 0 To CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.Count - 1
                If CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.ESSLopTinChi(i).STT_lop = STT_lop And _
                   CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.ESSLopTinChi(i).ID_lop_lt = 0 Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_lop_tc_idx(ByVal idx_mon_tc As String, ByVal STT_lop As Integer, ByVal ID_lop_lt As Integer) As Integer
            For i As Integer = 0 To CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.Count - 1
                If CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.ESSLopTinChi(i).STT_lop = STT_lop And _
                   CType(arrMonTinChi(idx_mon_tc), ESSMonTinChi).dsLopTinChi.ESSLopTinChi(i).ID_lop_lt = ID_lop_lt Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_lop_idx(ByVal Ky_hieu As String, ByVal Ky_hieu_lop_tc As String) As Integer
            For i As Integer = 0 To arrMonTinChi.Count - 1
                If CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu = Ky_hieu And _
                CType(arrMonTinChi(i), ESSMonTinChi).Ky_hieu_lop_tc = Ky_hieu_lop_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public ReadOnly Property Count() As Integer
            Get
                Return arrMonTinChi.Count
            End Get
        End Property
        Public Property ESSMonTinChi(ByVal idx As Integer) As ESSMonTinChi
            Get
                Return CType(Me.arrMonTinChi(idx), ESSMonTinChi)
            End Get
            Set(ByVal Value As ESSMonTinChi)
                Me.arrMonTinChi(idx) = Value
            End Set
        End Property
        Public Property Ky_dang_ky() As Integer
            Get
                Return mKy_dang_ky
            End Get
            Set(ByVal Value As Integer)
                mKy_dang_ky = Value
            End Set
        End Property
        Public Property Dot() As Integer
            Get
                Return mDot
            End Get
            Set(ByVal Value As Integer)
                mDot = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
            End Set
        End Property
    End Class
End Namespace
