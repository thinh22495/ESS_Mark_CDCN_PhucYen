Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Diem_Bussines
        Private arrDiem As New ArrayList
        Private objSorted As New LapMa_Bussines
        Private mdtDanhSachSinhVien As DataTable
        Private dsMonHoc As New ESSChuongTrinhDaoTaoChiTiet
        Private dsThanhPhanDiem As New ESSThanhPhanDiem
        Private So_thanh_phan_chon As Integer = 0
        Private dsDiemQuyDoi As New ESSDiemQuyDoi
        Private dsXepLoaiHocTap As New ESSXepLoaiHocTap
        Private dsXepLoaiHocTap_thangdiem10 As New ESSXeploaihoctap_thangdiem10
        Private dsXepLoaiChungChi As New ESSXepLoaiChungChi
        Private dsXepHangHocLuc As New ESSXepHangHocLuc
        Private dsXepHangNamDaoTao As New ESSXepHangNamDaoTao
        Private dsXepHangTotNghiep As New ESSXepHangTotNghiep
        Private mID_dv As String = ""

        Private MucXuLy_KyLuat_HaLoaiTotNghiep As Integer = 0
        Private MucXuLy_KyLuat_HaLoaiTotNghiep_Active As Boolean = False
        Private PtramTCithilai_hatotnghiep As Integer = 5
        Private PtramTCithilai_hatotnghiep_Active As Boolean = False

        Private NamXet_TBCHT As Double = 1.0
        Private NamXet_TBCHT_Active As Boolean = False

        Private KyDau_TBCTL As Double = 0.8
        Private KyDau_TBCTL_Active As Boolean = False
        Private KyBatKy_TBCTL As Double = 1.0
        Private KyBatKy_TBCTL_Active As Boolean = False
        Private HaiKyLienTiep_TBCTL As Double = 1.0
        Private HaiKyLienTiep_TBCTL_Active As Boolean = False
        Private NamDau_TBCTL As Double = 1.0
        Private NamDau_TBCTL_Active As Boolean = False
        Private NamThu2_TBCTL As Double = 1.0
        Private NamThu2_TBCTL_Active As Boolean = False
        Private NamThu3_TBCTL As Double = 1.0
        Private NamThu3_TBCTL_Active As Boolean = False
        Private TuNamThu4_TBCTL As Double = 1.0
        Private TuNamThu4_TBCTL_Active As Boolean = False
        Private Lam_tron_TBCMH As Double = 0
        Private TCTL_Active As Boolean = False
        Private TCTL As Double = 24

        Private LamTron_Diem_TongHop As Integer = 2
        Private So_lan_thi_lai As Double = 2

        Private Diem_chuyen_can_dat As Double = 5.0
        Private Diem_chuyen_can_dat_Active As Boolean = False
        Private Diem_kiem_tra_bo_phan_dat As Double = 3.0
        Private Diem_kiem_tra_bo_phan_dat_Active As Boolean = False
        Private TBCBP_khong_dat As Double = 5

        '---THAM SO AP DUNG CHO TINH ESSDiem TBCMH---'
        ' QuyCheTinChi_CHUNG=0 --- Ap dung chung
        ' QuyCheTinChi_CHUNG=1 --- Ap dung cho HVCS
        ' QuyCheTinChi_CHUNG=2 --- Ap dung cho ....
        Private QuyCheTinChi_CHUNG As Integer = 0





#Region "Initialize"
        Sub New()
            'Load ESSDiem quy doi
            HienThi_ESSDiemQuyDoi()
        End Sub
        'Load phan loai KQHT
        Sub New(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal dsID_lop As String, ByVal dtDanhSachSinhVien As DataTable, Optional ByVal PhongThi As Boolean = False, Optional ByVal Chon_mac_dinh_tp As Boolean = False, Optional ByVal lop_tc As Boolean = False, Optional ByVal dsID_lop_tc As String = "", Optional ByVal ID_mon_tc As Integer = 0, Optional ByVal NangDiem As Boolean = False)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien
            'Load ESSDiem quy doi
            HienThi_ESSDiemQuyDoi()
            'Load các thành phần
            If Not NangDiem Then
                HienThi_ESSThanhPhanMon(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, Chon_mac_dinh_tp, lop_tc, dsID_lop_tc, ID_mon_tc)
            End If

            'Load xếp hạng năm đào tạo
            HienThi_ESSXepHangNamDaoTao()
            'Load dữ liệu điểm môn học
            If PhongThi Then
                Dim dsID_sv As String = ""
                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                    dsID_sv += mdtDanhSachSinhVien.Rows(i)("ID_sv").ToString + ","
                Next
                If dsID_sv <> "" Then
                    'Load dữ liệu điểm của danh sách sinh viên vào arrDiem
                    dsID_sv = Left(dsID_sv, Len(dsID_sv) - 1)
                    HienThi_ESSDiem(ID_dv, "", Hoc_ky, Nam_hoc, dsID_sv, ID_mon)
                End If
            Else
                'HienThi_ESSDiem(ID_dv, dsID_lop, 0, "", "", ID_mon)
                HienThi_ESSDiem(ID_dv, dsID_lop, Hoc_ky, Nam_hoc, "", ID_mon)
            End If
        End Sub
        'Load điểm để tổng hợp học kỳ, năm học và toàn khoá
        Sub New(ByVal ID_dv As String, ByVal ID_bm_chinh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_dt As Integer, ByVal dtDanhSachSinhVien As DataTable)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien

            'HienThi_ESSThanhPhanMon(ID_dv, 0, "", 0, dsID_lop, False)
            HienThi_ESSThanhPhanMon(ID_dv, Hoc_ky, Nam_hoc, 0, dsID_lop, False)
            'Load ESSDiem quy doi
            HienThi_ESSDiemQuyDoi()
            'Load xếp loại học tập
            HienThi_ESSXepLoaiHocTap()
            HienThi_ESSXepLoaiChungChi()
            'Load xếp hạng học lực
            HienThi_ESSXepHangHocLuc()
            HienThi_ESSXepLoaiHocTap_Thangdiem10()
            'Load xếp hạng năm đào tạo
            HienThi_ESSXepHangNamDaoTao()
            'Load xếp hạng tốt nghiệp
            HienThi_ESSXepHangTotNghiep()
            'Load danh sách các môn học
            HienThi_ESSMonHocTrongDiem(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, 0, ID_dt)
            'Load các môn học có trong bảng điểm
            HienThi_ESSDiem(ID_dv, dsID_lop, Hoc_ky, Nam_hoc)
        End Sub
        Sub New(ByVal ID_dv As String, ByVal ID_bm_chinh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_dt As String, ByVal dtDanhSachSinhVien As DataTable)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien

            HienThi_ESSThanhPhanMon(ID_dv, 0, "", 0, dsID_lop, False)
            'Load ESSDiem quy doi
            HienThi_ESSDiemQuyDoi()
            'Load xếp loại học tập
            HienThi_ESSXepLoaiHocTap()
            HienThi_ESSXepLoaiChungChi()
            'Load xếp hạng học lực
            HienThi_ESSXepHangHocLuc()
            HienThi_ESSXepLoaiHocTap_Thangdiem10()
            'Load xếp hạng năm đào tạo
            HienThi_ESSXepHangNamDaoTao()
            'Load xếp hạng tốt nghiệp
            HienThi_ESSXepHangTotNghiep()
            'Load danh sách các môn học
            HienThi_ESSMonHocTrongDiem_ID_Dts(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, 0, ID_dt)
            'Load các môn học có trong bảng điểm
            HienThi_ESSDiem(ID_dv, dsID_lop, Hoc_ky, Nam_hoc)
        End Sub
        Sub New(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_dt As Integer)
            mID_dv = ID_dv
            HienThi_ESSXepHangNamDaoTao()
            'Load ESSDiem quy doi
            HienThi_ESSDiemQuyDoi()
            HienThi_ESSXepLoaiHocTap()
            HienThi_ESSXepLoaiHocTap_Thangdiem10()
            'Load xếp hạng năm đào tạo
            HienThi_ESSXepHangHocLuc()
            'Load xếp hạng tốt nghiệp
            HienThi_ESSXepHangTotNghiep()
            'Load danh sách các môn học
            HienThi_ESSMonHocTrongDiem(ID_dv, "", 0, 0, "", ID_sv, ID_dt)
            'Load các môn học có trong bảng điểm
            HienThi_ESSDiem(ID_dv, "", 0, "", ID_sv.ToString, 0, ID_dt)
        End Sub
        Sub New(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer, ByVal dtDanhSachSinhVien As DataTable)
            mID_dv = ID_dv
            mdtDanhSachSinhVien = dtDanhSachSinhVien
            'Load các thành phần
            HienThi_ESSThanhPhanMonTinChi(ID_dv, Hoc_ky, Nam_hoc, ID_mon_tc, ID_lop_tc)
            'Load dữ liệu điểm môn học
            HienThi_ESSDiem_ThanhPhan(ID_dv, Hoc_ky, Nam_hoc, ID_mon, ID_mon_tc, ID_lop_tc)
        End Sub

        'Chuong trinh dao tao 2
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_dt As Integer, ByVal dtDanhSachSinhVien As DataTable)
            mID_dv = "P1"
            mdtDanhSachSinhVien = dtDanhSachSinhVien
            HienThi_ESSXepHangNamDaoTao()
            'Load xếp hạng tốt nghiệp
            HienThi_ESSXepHangTotNghiep()
            HienThi_ESSDiemQuyDoi()
            HienThi_ESSThanhPhanMon_NganhHoc2(mID_dv, Hoc_ky, Nam_hoc, ID_mon, ID_dt)
            HienThi_ESSMonHocTrongDiem_NganhHoc2(mID_dv, 0, Hoc_ky, Nam_hoc, ID_dt)
            HienThi_Diem_NganhHoc2(mID_dv, ID_dt, Hoc_ky, Nam_hoc, ID_mon)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrDiem.Count
            End Get
        End Property
        Public Sub Add(ByVal ESSDiem As ESSDiem)
            arrDiem.Add(ESSDiem)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrDiem.RemoveAt(idx)
        End Sub
        Public Property ESSDiem(ByVal idx As Integer) As ESSDiem
            Get
                Return CType(arrDiem(idx), ESSDiem)
            End Get
            Set(ByVal Value As ESSDiem)
                arrDiem(idx) = Value
            End Set
        End Property
        Public ReadOnly Property ESSMonHoc() As ESSChuongTrinhDaoTaoChiTiet
            Get
                Return dsMonHoc
            End Get
        End Property
        Public ReadOnly Property ESSThanhPhanDiem() As ESSThanhPhanDiem
            Get
                Return dsThanhPhanDiem
            End Get
        End Property
#End Region
#Region "Functions And Subs"
        Private Sub HienThi_ESSXepLoaiHocTap_Thangdiem10()
            Dim dtXepLoaiHocTap_Thangdiem10 As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepLoaiHocTap_Thangdiem10 = clsDAL.HienThi_ESSXepLoaiHocTap_thangdiem10()
            For i As Integer = 0 To dtXepLoaiHocTap_Thangdiem10.Rows.Count - 1
                Dim objXepLoaiHocTap As New ESSXeploaihoctap_thangdiem10
                objXepLoaiHocTap.ID_xep_loai = dtXepLoaiHocTap_Thangdiem10.Rows(i)("ID_xep_loai")
                objXepLoaiHocTap.Tu_diem = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Tu_diem")
                objXepLoaiHocTap.Den_diem = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Den_diem")
                objXepLoaiHocTap.Xep_loai = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Xep_loai")
                dsXepLoaiHocTap_thangdiem10.Add(objXepLoaiHocTap)
            Next
        End Sub

        Private Function MappingDiem(ByVal dr As DataRow) As ESSDiem
            Dim objDiem As New ESSDiem
            objDiem.ID_diem = dr("ID_diem")
            objDiem.ID_dv = dr("ID_dv")
            objDiem.ID_sv = dr("ID_sv")
            objDiem.ID_mon = dr("ID_mon")
            objDiem.ID_dt = dr("ID_dt")
            objDiem.Hoc_ky = dr("Hoc_ky")
            objDiem.Nam_hoc = dr("Nam_hoc")
            objDiem.Tinh_tich_luy = dr("Tinh_tich_luy")
            objDiem.Duyet = dr("Duyet")
            objDiem.So_tiet = IIf(dr("Ly_thuyet").ToString = "", 0, dr("Ly_thuyet")) + IIf(dr("Thuc_hanh").ToString = "", 0, dr("Thuc_hanh"))
            Return objDiem
        End Function
        Private Function MappingDiemThanhPhan(ByVal dr As DataRow) As ESSDiemThanhPhan
            Dim objDiemTP As New ESSDiemThanhPhan
            objDiemTP.ID_thanh_phan = dr("ID_thanh_phan")
            objDiemTP.Ty_le = dr("Ty_le")
            objDiemTP.He_so = IIf(IsDBNull(dr("He_so")), 1, dr("He_so"))
            objDiemTP.Nhom = IIf(IsDBNull(dr("Nhom")), 1, dr("Nhom"))
            objDiemTP.Diem = dr("Diem")
            objDiemTP.Ly_do = dr("Ly_do")
            objDiemTP.Locked = dr("Locked_tp")
            objDiemTP.Hoc_ky_TP = dr("Hoc_ky_TP")
            objDiemTP.Nam_hoc_TP = dr("Nam_hoc_TP")
            objDiemTP.ID_diem = dr("ID_diem")
            Return objDiemTP
        End Function
        Private Function MappingDiemThi(ByVal dr As DataRow) As ESSDiemThi
            Dim objDiemThi As New ESSDiemThi
            objDiemThi.ID_diem = dr("ID_diem")
            objDiemThi.Lan_thi = dr("Lan_thi")
            objDiemThi.Diem_thi = dr("Diem_thi")
            objDiemThi.TBCMH = dr("TBCMH")
            objDiemThi.Diem_chu = dr("Diem_chu").ToString.Trim
            If dr("Diem_so").ToString <> "" Then objDiemThi.Diem_so = dr("Diem_so").ToString
            objDiemThi.Ghi_chu = dr("Ghi_chu").ToString
            objDiemThi.Locked = dr("Locked")
            objDiemThi.Hoc_ky_thi = dr("Hoc_ky_thi")
            objDiemThi.Nam_hoc_thi = dr("Nam_hoc_thi")
            Return objDiemThi
        End Function
        Private Sub HienThi_ESSDiem(ByVal ID_dv As String, ByVal dsID_lop As String, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal dsID_sv As String = "", Optional ByVal ID_mon As Integer = 0, Optional ByVal ID_dt As Integer = 0)
            Dim clsDAL As New Diem_DataAccess
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            Dim objDiem As New ESSDiem
            'Lấy dữ liệu điểm thành phần và điểm thi
            dtDiem = clsDAL.HienThi_ESSDiem_TongHop_DanhSach(ID_dv, dsID_lop, Hoc_ky, Nam_hoc, dsID_sv, ID_mon, ID_dt)
            If dtDiem.Rows.Count > 0 Then
                For idx_diem As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(idx_diem).Item("ID_SV") = 465111 Then
                        dtDiem.Rows(idx_diem).Item("ID_SV") = 465111
                    End If
                    If ID_diem <> dtDiem.Rows(idx_diem)("ID_diem") Then
                        If idx_diem > 0 Then arrDiem.Add(objDiem)
                        objDiem = New ESSDiem
                        objDiem = MappingDiem(dtDiem.Rows(idx_diem))
                        GoTo Add_diem
                    Else
Add_diem:
                        If (CInt("0" & dtDiem.Rows.Item(idx_diem).Item("ID_diem_danh").ToString) > 0) Then
                            Dim objDiemDanh As New DiemDanh
                            objDiemDanh = Me.ConvertDiemDanh(dtDiem.Rows.Item(idx_diem))
                            If (objDiem.dsDiemDanh.Tim_idx(objDiemDanh.ID_diem, objDiemDanh.Hoc_ky_DD, objDiemDanh.Nam_hoc_DD) = -1) Then
                                objDiem.dsDiemDanh.Add(objDiemDanh)
                            End If
                        End If
                        If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_tp").ToString) > 0 Then
                            'Add các điểm thành phần vào object Điểm thành phần
                            Dim objDiemTP As New ESSDiemThanhPhan
                            objDiemTP = MappingDiemThanhPhan(dtDiem.Rows(idx_diem))
                            If objDiem.dsDiemThanhPhan.Tim_idx(objDiemTP.ID_thanh_phan, objDiemTP.Hoc_ky_TP, objDiemTP.Nam_hoc_TP) = -1 Then
                                objDiem.dsDiemThanhPhan.Add(objDiemTP)
                            End If
                        End If
                        If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_thi").ToString) > 0 Then
                            'Add các điểm thi vào object Điểm thi
                            Dim objDiemThi As New ESSDiemThi
                            objDiemThi = MappingDiemThi(dtDiem.Rows(idx_diem))
                            If objDiem.dsDiemThi.idx_diem_thi(objDiemThi.Hoc_ky_thi, objDiemThi.Nam_hoc_thi, objDiemThi.Lan_thi) = -1 Then
                                objDiem.dsDiemThi.Add(objDiemThi)
                            End If
                        End If
                    End If
                    ID_diem = dtDiem.Rows(idx_diem)("ID_diem")
                Next
                If ID_diem > 0 Then
                    arrDiem.Add(objDiem)
                End If
            End If
            ''Cập nhật thông tin về không đủ đk dự thi, học lại, thi lại
            'For i As Integer = 0 To arrDiem.Count - 1
            '    objDiem = CType(arrDiem(i), ESSDiem)
            '    CapNhatThongTinDiem(dsThanhPhanDiem, objDiem, Hoc_ky, Nam_hoc)
            'Next
        End Sub

        Private Sub HienThi_ESSDiem_TinChi(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer)
            Dim clsDAL As New Diem_DataAccess
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            'Lấy dữ liệu điểm thành phần và điểm thi
            dtDiem = clsDAL.HienThi_ESSDiem_TongHopTinChi_DanhSach(ID_dv, Hoc_ky, Nam_hoc, ID_mon, ID_lop_tc, ID_mon_tc)
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                Dim objDiem As New ESSDiem
                objDiem.ID_mon = dtDiem.Rows(i).Item("ID_mon")
                objDiem.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                objDiem.dsDiemThanhPhan.Diem = dtDiem.Rows(i).Item("Diem")
                objDiem.dsDiemThanhPhan.Ty_le = dtDiem.Rows(i).Item("Ty_le")
                objDiem.Hoc_ky = dtDiem.Rows(i).Item("Hoc_ky")
                objDiem.Nam_hoc = dtDiem.Rows(i).Item("Nam_hoc")
                arrDiem.Add(objDiem)
            Next
        End Sub

        Private Sub HienThi_ESSMonHocTrongCTDT(ByVal dsID_dt As String, ByVal ID_bm_chinh As Integer)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.HienThi_ESSMonHocTrongCTDT(dsID_dt, ID_bm_chinh)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ESSChuongTrinhDaoTaoChiTiet
                objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                objCTDT.Nhom_tu_chon = dtMon.Rows(i)("Nhom_tu_chon")
                objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                dsMonHoc.Add(objCTDT)
            Next
        End Sub
        Private Sub HienThi_ESSMonHocTrongDiem(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm_chinh As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_dt As Integer = 0)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
            Dim fAdd As Boolean = False
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.HienThi_ESSMonHocTrongDiem(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, ID_sv, ID_dt)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ESSChuongTrinhDaoTaoChiTiet
                'Kiểm tra xem có trùng môn không?
                fAdd = True
                For j As Integer = 0 To dsMonHoc.Count - 1
                    If dtMon.Rows(i)("ID_mon").ToString = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(j).ID_mon.ToString Then
                        fAdd = False
                    End If
                Next
                If fAdd Then
                    objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                    objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                    objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                    objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                    objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                    objCTDT.Nhom_tu_chon = dtMon.Rows(i)("Nhom_tu_chon")
                    objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                    dsMonHoc.Add(objCTDT)
                End If
            Next
        End Sub

        Private Sub HienThi_ESSMonHocTrongDiem_ID_Dts(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_bm_chinh As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_dt As String = "")
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
            Dim fAdd As Boolean = False
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.HienThi_ESSMonHocTrongDiem_ID_Dts(ID_dv, dsID_lop, ID_bm_chinh, Hoc_ky, Nam_hoc, ID_sv, ID_dt)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ESSChuongTrinhDaoTaoChiTiet
                'Kiểm tra xem có trùng môn không?
                fAdd = True
                For j As Integer = 0 To dsMonHoc.Count - 1
                    If dtMon.Rows(i)("ID_mon").ToString = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(j).ID_mon.ToString Then
                        fAdd = False
                    End If
                Next
                If fAdd Then
                    objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                    objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                    objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                    objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                    objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                    objCTDT.Nhom_tu_chon = dtMon.Rows(i)("Nhom_tu_chon")
                    objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                    dsMonHoc.Add(objCTDT)
                End If
            Next
        End Sub

        Private Sub HienThi_ESSDiemQuyDoi()
            Dim dtDiemQuyDoi As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtDiemQuyDoi = clsDAL.HienThi_ESSDiemQuyDoi()
            For i As Integer = 0 To dtDiemQuyDoi.Rows.Count - 1
                Dim objDiemQD As New ESSDiemQuyDoi
                objDiemQD.ID_xep_loai = dtDiemQuyDoi.Rows(i)("ID_xep_loai")
                objDiemQD.Xep_loai = dtDiemQuyDoi.Rows(i)("Xep_loai")
                objDiemQD.Diem_chu = dtDiemQuyDoi.Rows(i)("Diem_chu")
                objDiemQD.Diem_chu = dtDiemQuyDoi.Rows(i)("Diem_chu")
                objDiemQD.Tu_diem = dtDiemQuyDoi.Rows(i)("Tu_diem")
                objDiemQD.Den_diem = dtDiemQuyDoi.Rows(i)("Den_diem")
                objDiemQD.Tich_luy = dtDiemQuyDoi.Rows(i)("Tich_luy")
                objDiemQD.Diem_so = dtDiemQuyDoi.Rows(i)("Diem_so")
                dsDiemQuyDoi.Add(objDiemQD)
            Next
        End Sub
        Private Sub HienThi_ESSXepLoaiHocTap()
            Dim dtXepLoaiHocTap As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepLoaiHocTap = clsDAL.HienThi_ESSXepLoaiHocTap()
            For i As Integer = 0 To dtXepLoaiHocTap.Rows.Count - 1
                Dim objXepLoaiHocTap As New ESSXepLoaiHocTap
                objXepLoaiHocTap.ID_xep_loai = dtXepLoaiHocTap.Rows(i)("ID_xep_loai")
                objXepLoaiHocTap.Tu_diem = Math.Round(dtXepLoaiHocTap.Rows(i)("Tu_diem"), 2)
                objXepLoaiHocTap.Den_diem = Math.Round(dtXepLoaiHocTap.Rows(i)("Den_diem"), 2)
                objXepLoaiHocTap.Xep_loai = dtXepLoaiHocTap.Rows(i)("Xep_loai")
                dsXepLoaiHocTap.Add(objXepLoaiHocTap)
            Next
        End Sub

        Private Sub HienThi_ESSXepLoaiChungChi()
            Dim dtXepLoaiChungChi As DataTable
            Dim clsDAL As New Diem_DataAccess
            dtXepLoaiChungChi = clsDAL.HienThi_ESSXepLoaiChungChi()
            For i As Integer = 0 To dtXepLoaiChungChi.Rows.Count - 1
                Dim objXepLoaiChungChi As New ESSXepLoaiChungChi
                objXepLoaiChungChi.ID_xep_loai = dtXepLoaiChungChi.Rows(i)("ID_xep_hang")
                objXepLoaiChungChi.Tu_diem = dtXepLoaiChungChi.Rows(i)("Tu_diem")
                objXepLoaiChungChi.Den_diem = dtXepLoaiChungChi.Rows(i)("Den_diem")
                objXepLoaiChungChi.Xep_loai = dtXepLoaiChungChi.Rows(i)("Xep_hang")
                dsXepLoaiChungChi.Add(objXepLoaiChungChi)
            Next
        End Sub
        Private Sub HienThi_ESSXepHangHocLuc()
            Dim dtXepHangHocLuc As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepHangHocLuc = clsDAL.HienThi_ESSXepHangHocLuc()
            For i As Integer = 0 To dtXepHangHocLuc.Rows.Count - 1
                Dim objXepHangHocLuc As New ESSXepHangHocLuc
                objXepHangHocLuc.ID_xep_hang = dtXepHangHocLuc.Rows(i)("ID_xep_hang")
                objXepHangHocLuc.Tu_diem = dtXepHangHocLuc.Rows(i)("Tu_diem")
                objXepHangHocLuc.Den_diem = dtXepHangHocLuc.Rows(i)("Den_diem")
                objXepHangHocLuc.Xep_hang = dtXepHangHocLuc.Rows(i)("Xep_hang")
                dsXepHangHocLuc.Add(objXepHangHocLuc)
            Next
        End Sub
        Private Sub HienThi_ESSXepHangNamDaoTao()
            Dim dtXepHangNamDaoTao As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepHangNamDaoTao = clsDAL.HienThi_ESSXepHangNamDaoTao()
            For i As Integer = 0 To dtXepHangNamDaoTao.Rows.Count - 1
                Dim objXepHangNamDaoTao As New ESSXepHangNamDaoTao
                objXepHangNamDaoTao.ID_xep_hang = dtXepHangNamDaoTao.Rows(i)("ID_xep_hang")
                objXepHangNamDaoTao.Tu_tin_chi = dtXepHangNamDaoTao.Rows(i)("Tu_tin_chi")
                objXepHangNamDaoTao.Den_tin_chi = dtXepHangNamDaoTao.Rows(i)("Den_tin_chi")
                objXepHangNamDaoTao.Nam_thu = dtXepHangNamDaoTao.Rows(i)("Nam_thu")
                dsXepHangNamDaoTao.Add(objXepHangNamDaoTao)
            Next
        End Sub
        Private Sub HienThi_ESSXepHangTotNghiep()
            Dim dtXepHangTotNghiep As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepHangTotNghiep = clsDAL.HienThi_ESSXepHangTotNghiep()
            For i As Integer = 0 To dtXepHangTotNghiep.Rows.Count - 1
                Dim objXepHangTotNghiep As New ESSXepHangTotNghiep
                objXepHangTotNghiep.ID_xep_hang = dtXepHangTotNghiep.Rows(i)("ID_xep_hang")
                objXepHangTotNghiep.Tu_diem = dtXepHangTotNghiep.Rows(i)("Tu_diem")
                objXepHangTotNghiep.Den_diem = dtXepHangTotNghiep.Rows(i)("Den_diem")
                objXepHangTotNghiep.Xep_hang = dtXepHangTotNghiep.Rows(i)("Xep_hang")
                dsXepHangTotNghiep.Add(objXepHangTotNghiep)
            Next
        End Sub
        Private Sub HienThi_ESSThanhPhanMon(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal dsID_lop As String, ByVal Chon_mac_dinh_tp As Boolean, Optional ByVal Lop_tc As Boolean = False, Optional ByVal dsID_lop_tc As String = "", Optional ByVal ID_mon_tc As Integer = 0)
            Dim dtThanhPhan As DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim idx As Integer
            'Load các thành phần
            dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon()
            For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                Dim objThanhPhan As New ESSThanhPhanDiem
                objThanhPhan.ID_thanh_phan = dtThanhPhan.Rows(i)("ID_thanh_phan")
                objThanhPhan.STT = dtThanhPhan.Rows(i)("STT")
                objThanhPhan.Ky_hieu = dtThanhPhan.Rows(i)("Ky_hieu")
                objThanhPhan.Ten_thanh_phan = dtThanhPhan.Rows(i)("Ten_thanh_phan")
                objThanhPhan.Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                objThanhPhan.He_so = dtThanhPhan.Rows(i)("He_so")
                objThanhPhan.Nhom = dtThanhPhan.Rows(i)("Nhom")
                If Chon_mac_dinh_tp = True Then objThanhPhan.Checked = dtThanhPhan.Rows(i)("Chon_mac_dinh")
                'objThanhPhan.Checked = dtThanhPhan.Rows(i)("Chon_mac_dinh")
                objThanhPhan.Chuyen_can = dtThanhPhan.Rows(i)("Chuyen_can")
                dsThanhPhanDiem.Add(objThanhPhan)
            Next
            'Update lại các thành phần theo tỷ lệ đã chọn
            If Lop_tc Then
                dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon_TinChi_New(ID_dv, Hoc_ky, Nam_hoc, ID_mon_tc, dsID_lop_tc)
            Else
                dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon(ID_dv, Hoc_ky, Nam_hoc, dsID_lop, ID_mon)
            End If

            If dtThanhPhan.Rows.Count > 0 Then
                'Bỏ chọn mặc định
                For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                    dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked = False
                Next
                'Check chọn theo thành phần đã chọn
                So_thanh_phan_chon = 0
                For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                    idx = dsThanhPhanDiem.Tim_idx(dtThanhPhan.Rows(i)("ID_thanh_phan"))
                    If idx >= 0 Then
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Ty_le = IIf(IsDBNull(dtThanhPhan.Rows(i)("Ty_le")), 1, dtThanhPhan.Rows(i)("Ty_le"))
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).He_so = IIf(IsDBNull(dtThanhPhan.Rows(i)("He_so")), 1, dtThanhPhan.Rows(i)("He_so"))
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Nhom = IIf(IsDBNull(dtThanhPhan.Rows(i)("Nhom")), 1, dtThanhPhan.Rows(i)("Nhom"))
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Checked = True
                        So_thanh_phan_chon += 1
                    End If
                Next
            End If
        End Sub

        Private Sub HienThi_ESSThanhPhanMonTinChi(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer)
            Dim dtThanhPhan As DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim idx As Integer
            'Load các thành phần
            dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon()
            For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                Dim objThanhPhan As New ESSThanhPhanDiem
                objThanhPhan.ID_thanh_phan = dtThanhPhan.Rows(i)("ID_thanh_phan")
                objThanhPhan.STT = dtThanhPhan.Rows(i)("STT")
                objThanhPhan.Ky_hieu = dtThanhPhan.Rows(i)("Ky_hieu")
                objThanhPhan.Ten_thanh_phan = dtThanhPhan.Rows(i)("Ten_thanh_phan")
                objThanhPhan.Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                objThanhPhan.Checked = dtThanhPhan.Rows(i)("Chon_mac_dinh")
                objThanhPhan.Chuyen_can = dtThanhPhan.Rows(i)("Chuyen_can")
                dsThanhPhanDiem.Add(objThanhPhan)
            Next
            'Update lại các thành phần theo tỷ lệ đã chọn
            dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon_TinChi(ID_dv, Hoc_ky, Nam_hoc, ID_mon_tc, ID_lop_tc)
            If dtThanhPhan.Rows.Count > 0 Then
                'Bỏ chọn mặc định
                For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                    dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked = False
                Next
                'Check chọn theo thành phần đã chọn
                So_thanh_phan_chon = 0
                For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                    idx = dsThanhPhanDiem.Tim_idx(dtThanhPhan.Rows(i)("ID_thanh_phan"))
                    If idx >= 0 Then
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Checked = True
                        So_thanh_phan_chon += 1
                    End If
                Next
            End If
        End Sub

        Public Function DanhSachDiemThiLan1(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1
            Dim Tong_SV_Du_DKDT, Tong_SV_KoDu_DKDT, Tong_SV_VangThi_CoPhep, Tong_SV_VangThi_KoPhep, Tong_SV_X, Tong_SV, Tong_SV_Dat, Tong_SV_KhongDat As Integer
            Tong_SV_Du_DKDT = 0
            Tong_SV_KoDu_DKDT = 0
            Tong_SV_VangThi_CoPhep = 0
            Tong_SV_VangThi_KoPhep = 0
            Tong_SV = 0
            Tong_SV_Dat = 0
            Tong_SV_KhongDat = 0
            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    'dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
                    dtDiem.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem")
            dtDiem.Columns.Add("idx_diem_thi")
            dtDiem.Columns.Add("ID_diem")
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("Diem_chu")
            dtDiem.Columns.Add("Diem_so", GetType(Double))
            dtDiem.Columns.Add("DiemCC", GetType(Double))
            dtDiem.Columns.Add("TBCBP", GetType(Double))
            dtDiem.Columns.Add("TBCMH", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            dtDiem.Columns.Add("Tong_SV_Du_DKDT")
            dtDiem.Columns.Add("Tong_SV_KoDu_DKDT")
            dtDiem.Columns.Add("Tong_SV_VangThi_CoPhep")
            dtDiem.Columns.Add("Tong_SV_VangThi_KoPhep")
            dtDiem.Columns.Add("Tong_SV")
            dtDiem.Columns.Add("Tong_SV_Dat")
            dtDiem.Columns.Add("Tong_SV_KhongDat")
            dtDiem.Columns.Add("Tong_SV_X")


            dtDiem.Columns.Add("Hoc_ky")
            dtDiem.Columns.Add("Nam_hoc")

            'Gán dữ liệu vào bảng danh sách sinh viên
            Doc_tham_so_he_thong()
            For Each dr In dtDiem.Rows
                If dr("ID_sv") = 465111 Then
                    dr("ID_sv") = 465111
                End If

                idx = Tim_idx_Thi_ky(dr("ID_sv"), ID_mon, Hoc_ky, Nam_hoc, 1)
                If idx < 0 Then
                    idx = Tim_idx(dr("ID_sv"), ID_mon)
                End If
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                Dim ZTBCBP As Double = 0
                Dim ZTBCC As Double = 0
                Dim ZKT As Integer = 0
                Dim ZCC As Integer = 0
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                    'If objDiem.ID_sv = 465111 Then
                    '    objDiem.ID_sv = 465111
                    'End If
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                    'dr.Item("TP" + ID_thanh_phan.ToString) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    dr.Item(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))

                                    If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False Then
                                        ZTBCBP += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                        ZKT += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                    Else
                                        ZTBCC += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                        ZCC += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                    End If
                                End If

                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, 1)
                    'Gán vị trí của điểm thi trên mảng
                    dr("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Hoc_ky, Nam_hoc, 1)
                    dr("Hoc_ky") = objDiem.Hoc_ky
                    dr("Nam_hoc") = objDiem.Nam_hoc
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = Math.Round(Diem_thi, CType(Lam_tron_TBCMH, Integer))
                    Else
                        dr("Diem_thi") = DBNull.Value
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    dr("Diem_chu") = objDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                    dr("Diem_so") = objDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc)
                    If objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) >= 0 Then
                        dr("TBCMH") = Math.Round(objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                        dr("Diem_so") = Math.Round(objDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                    End If
                    If ZKT > 0 Then dr("TBCBP") = Math.Round(ZTBCBP / ZKT, CType(Lam_tron_TBCMH, Integer))
                    If ZCC > 0 Then dr("DiemCC") = Math.Round(ZTBCC / ZCC, 0)

                    dr("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                    dr("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(1, Hoc_ky, Nam_hoc)
                    If dr("Diem_chu").ToString = "F" Or dr("Diem_chu").ToString = "F+" Then Tong_SV_KhongDat += 1
                    '-------Cac ghi chu dang duoc Fix---------------------------
                    If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "K" And objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "P" And objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "V" Then Tong_SV_Du_DKDT = Tong_SV_Du_DKDT + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "K" Then Tong_SV_KoDu_DKDT = Tong_SV_KoDu_DKDT + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "P" Then Tong_SV_VangThi_CoPhep = Tong_SV_VangThi_CoPhep + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "V" Then Tong_SV_VangThi_KoPhep = Tong_SV_VangThi_KoPhep + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "X" Then Tong_SV_X = Tong_SV_X + 1
                    '----------------------------------------
                Else
                    dr("Diem_chu") = ""
                End If
            Next
            If dtDiem.Rows.Count > 0 Then
                Tong_SV = dtDiem.Rows.Count
                Tong_SV_Dat = Tong_SV - Tong_SV_KhongDat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Du_DKDT") = Tong_SV_Du_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KoDu_DKDT") = Tong_SV_KoDu_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_CoPhep") = Tong_SV_VangThi_CoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_KoPhep") = Tong_SV_VangThi_KoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV") = Tong_SV
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Dat") = Tong_SV_Dat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KhongDat") = Tong_SV_KhongDat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_X") = Tong_SV_X
            End If
            Return dtDiem
            'Return objSorted.TableSortHo_ten(dtDiem).Table
        End Function

        Public Function DanhSachDiemThiCaiThien(ByVal ID_mon As Integer) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1
            Dim Tong_SV_Du_DKDT, Tong_SV_KoDu_DKDT, Tong_SV_VangThi_CoPhep, Tong_SV_VangThi_KoPhep As Integer
            Tong_SV_Du_DKDT = 0
            Tong_SV_KoDu_DKDT = 0
            Tong_SV_VangThi_CoPhep = 0
            Tong_SV_VangThi_KoPhep = 0

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    'dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
                    dtDiem.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem")
            dtDiem.Columns.Add("idx_diem_thi")
            dtDiem.Columns.Add("ID_diem")
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("Diem_chu")
            dtDiem.Columns.Add("TBCMH", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            dtDiem.Columns.Add("Tong_SV_Du_DKDT")
            dtDiem.Columns.Add("Tong_SV_KoDu_DKDT")
            dtDiem.Columns.Add("Tong_SV_VangThi_CoPhep")
            dtDiem.Columns.Add("Tong_SV_VangThi_KoPhep")
            dtDiem.Columns.Add("Hoc_ky")
            dtDiem.Columns.Add("Nam_hoc")

            'Gán dữ liệu vào bảng danh sách sinh viên
            Doc_tham_so_he_thong()
            For Each dr In dtDiem.Rows
                idx = Tim_idx(dr("ID_sv"), ID_mon)
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, objDiem.Hoc_ky, objDiem.Nam_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                    'dr.Item("TP" + ID_thanh_phan.ToString) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    dr.Item(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                End If
                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(objDiem.Hoc_ky, objDiem.Nam_hoc, 2)
                    'Gán vị trí của điểm thi trên mảng
                    dr("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(objDiem.Hoc_ky, objDiem.Nam_hoc, 2)
                    dr("Hoc_ky") = objDiem.Hoc_ky
                    dr("Nam_hoc") = objDiem.Nam_hoc
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = Diem_thi
                    Else
                        dr("Diem_thi") = DBNull.Value
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    dr("Diem_chu") = objDiem.dsDiemThi.Diem_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc)
                    If objDiem.dsDiemThi.TBCMH_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc) >= 0 Then dr("TBCMH") = Math.Round(objDiem.dsDiemThi.TBCMH_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc), CType(Lam_tron_TBCMH, Integer))

                    dr("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc)
                    dr("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(2, objDiem.Hoc_ky, objDiem.Nam_hoc)

                    '-------Cac ghi chu dang duoc Fix---------------------------
                    If objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper <> "K" And objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper <> "P" And objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper <> "V" Then Tong_SV_Du_DKDT = Tong_SV_Du_DKDT + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper = "K" Then Tong_SV_KoDu_DKDT = Tong_SV_KoDu_DKDT + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper = "P" Then Tong_SV_VangThi_CoPhep = Tong_SV_VangThi_CoPhep + 1
                    If objDiem.dsDiemThi.Ghi_chu_lan(2, objDiem.Hoc_ky, objDiem.Nam_hoc).ToUpper = "V" Then Tong_SV_VangThi_KoPhep = Tong_SV_VangThi_KoPhep + 1
                    '----------------------------------------

                Else
                    dr("Diem_chu") = ""
                End If
            Next
            If dtDiem.Rows.Count > 0 Then
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Du_DKDT") = Tong_SV_Du_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KoDu_DKDT") = Tong_SV_KoDu_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_CoPhep") = Tong_SV_VangThi_CoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_KoPhep") = Tong_SV_VangThi_KoPhep
            End If
            Return dtDiem
            'Return objSorted.TableSortHo_ten(dtDiem).Table
        End Function


        Public Function DanhSachDiemThiLan1_ToChucThi(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                'If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                'dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
                dtDiem.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                'End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem")
            dtDiem.Columns.Add("idx_diem_thi")
            dtDiem.Columns.Add("ID_diem")
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("Diem_chu")
            dtDiem.Columns.Add("TBCMH", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            'Dim a As Double
            'Gán dữ liệu vào bảng danh sách sinh viên
            Doc_tham_so_he_thong()
            For Each dr In dtDiem.Rows
                idx = Tim_idx(dr("ID_sv"), ID_mon)
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                    'dr.Item("TP" + ID_thanh_phan.ToString) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    dr.Item(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    'Else
                                    '    dr.Item("TP" + ID_thanh_phan.ToString) = ""
                                End If
                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, 1)
                    'Gán vị trí của điểm thi trên mảng
                    dr("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Hoc_ky, Nam_hoc, 1)
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = Diem_thi
                    Else
                        dr("Diem_thi") = DBNull.Value
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    dr("Diem_chu") = objDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                    If objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) >= 0 Then dr("TBCMH") = Math.Round(objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))

                    dr("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                    dr("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(1, Hoc_ky, Nam_hoc)
                Else
                    dr("Diem_chu") = ""
                End If
            Next
            Return dtDiem
        End Function

        Public Function DanhSachDiemThiLan1_Sai(ByVal ID_mon As Integer, ByVal ESSDiemThi As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtDiem_check As New DataTable
            Dim dtSV As DataTable = mdtDanhSachSinhVien.Copy
            Dim dr As DataRow
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    'dtDiem_check.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
                    dtDiem_check.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem_check.Columns.Add("idx_diem")
            dtDiem_check.Columns.Add("idx_diem_thi")
            dtDiem_check.Columns.Add("ID_sv")
            dtDiem_check.Columns.Add("Ho_ten")
            dtDiem_check.Columns.Add("Ma_sv")
            dtDiem_check.Columns.Add("ID_diem")
            dtDiem_check.Columns.Add("Diem_thi", GetType(Double))
            dtDiem_check.Columns.Add("Diem_chu")
            dtDiem_check.Columns.Add("TBCMH", GetType(Double))
            dtDiem_check.Columns.Add("imgLock")
            dtDiem_check.Columns.Add("Locked")
            dtDiem_check.Columns.Add("Ghi_chu")
            'Gán dữ liệu vào bảng danh sách sinh viên
            Doc_tham_so_he_thong()
            For d As Integer = 0 To dtSV.Rows.Count - 1
                dr = dtDiem_check.NewRow
                idx = Tim_idx(dtSV.Rows(d).Item("ID_sv"), ID_mon)
                dr("Locked") = 0
                dr("idx_diem") = -1
                dr("idx_diem_thi") = -1
                If idx >= 0 Then
                    'Lấy 1 Object điểm
                    Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                    'Gán vị trí của điểm trên mảng
                    dr("idx_diem") = idx
                    dr("ID_diem") = objDiem.ID_diem
                    If idx_mon >= 0 Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                    dr.Item(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                End If
                            End If
                        Next
                    End If
                    'Gán dữ liệu điểm thi
                    Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, 1)
                    'Gán vị trí của điểm thi trên mảng
                    dr("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Hoc_ky, Nam_hoc, 1)
                    If Diem_thi >= 0 Then
                        dr("Diem_thi") = Diem_thi
                    Else
                        dr("Diem_thi") = DBNull.Value
                    End If
                    dr("ID_diem") = objDiem.ID_diem
                    dr("Diem_chu") = objDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                    If objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) >= 0 Then dr("TBCMH") = Math.Round(objDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))

                    dr("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                    dr("Locked") = objDiem.dsDiemThi.Diem_thi_lan_Locked(1, Hoc_ky, Nam_hoc)
                Else
                    dr("Diem_chu") = ""
                End If
            Next
            Return dtDiem_check
            'Return objSorted.TableSortHo_ten(dtDiem_check).Table
        End Function
        ''Lam tron ESSDiem 0.25
        'Function Round_Mark(ByVal Diem_TBCMH As Double) As Double
        '    Diem_TBCMH = Math.Round(Diem_TBCMH, 2)
        '    If Diem_TBCMH > 0 Then
        '        'Lấy điểm nguyên từ điểm ban đầu
        '        Dim ESSDiem As Double = Math.Truncate(Diem_TBCMH)
        '        'Lấy điểm lẻ để so sánh làm tròn theo quy chế
        '        Dim Diem_le As Double = Diem_TBCMH - ESSDiem

        '        If Diem_le > 0.25 And Diem_le <= 0.75 Then ESSDiem = ESSDiem + 0.5
        '        If Diem_le > 0.75 Then ESSDiem = ESSDiem + 1
        '        Return ESSDiem
        '    Else
        '        Return 0
        '    End If
        'End Function

        'Function Round_Mark_Str(ByVal Diem_TBCMH As Double) As String
        '    Diem_TBCMH = Math.Round(Diem_TBCMH, 2)
        '    If Diem_TBCMH > 0 Then
        '        'Lấy điểm nguyên từ điểm ban đầu
        '        Dim ESSDiem As Double = Math.Truncate(Diem_TBCMH)
        '        'Lấy điểm lẻ để so sánh làm tròn theo quy chế
        '        Dim Diem_le As Double = Diem_TBCMH - ESSDiem

        '        If Diem_le > 0.25 And Diem_le <= 0.75 Then ESSDiem = ESSDiem + 0.5
        '        If Diem_le > 0.75 Then ESSDiem = ESSDiem + 1
        '        Return ESSDiem.ToString
        '    Else
        '        Return ""
        '    End If
        'End Function

        Public Function DanhSachDiemThiLan(ByVal Lan_thi As Integer, ByVal ID_mon As Integer, ByVal Fill_KyHieuDiem As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy
            Dim idx As Integer = -1, idx1 As Integer = -1
            Dim ID_thanh_phan As Integer, DiemTP As Double
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            Dim Diem_thi As Double = -1

            Dim Tong_SV_Du_DKDT, Tong_SV_KoDu_DKDT, Tong_SV_VangThi_CoPhep, Tong_SV_VangThi_KoPhep, Tong_SV_X, Tong_SV, Tong_SV_Dat, Tong_SV_KhongDat As Integer
            Tong_SV_Du_DKDT = 0
            Tong_SV_KoDu_DKDT = 0
            Tong_SV_VangThi_CoPhep = 0
            Tong_SV_VangThi_KoPhep = 0
            Tong_SV = 0
            Tong_SV_Dat = 0
            Tong_SV_KhongDat = 0

            'Add các cột điểm thành phần
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    'dtDiem.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
                    dtDiem.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                End If
            Next
            'Thêm các cột điểm thi
            dtDiem.Columns.Add("idx_diem")
            dtDiem.Columns.Add("idx_diem_thi")
            dtDiem.Columns.Add("ID_diem")
            dtDiem.Columns.Add("Diem_thi", GetType(Double))
            dtDiem.Columns.Add("Diem_chu")
            dtDiem.Columns.Add("Diem_so", GetType(Double))
            dtDiem.Columns.Add("TBCBP", GetType(Double))
            dtDiem.Columns.Add("DiemCC", GetType(Double))
            dtDiem.Columns.Add("TBCMH", GetType(Double))
            dtDiem.Columns.Add("imgLock")
            dtDiem.Columns.Add("Locked")
            dtDiem.Columns.Add("Ghi_chu")
            dtDiem.Columns.Add("Hoc_ky")
            dtDiem.Columns.Add("Nam_hoc")

            dtDiem.Columns.Add("Tong_SV_Du_DKDT")
            dtDiem.Columns.Add("Tong_SV_KoDu_DKDT")
            dtDiem.Columns.Add("Tong_SV_VangThi_CoPhep")
            dtDiem.Columns.Add("Tong_SV_VangThi_KoPhep")
            dtDiem.Columns.Add("Tong_SV")
            dtDiem.Columns.Add("Tong_SV_Dat")
            dtDiem.Columns.Add("Tong_SV_KhongDat")
            dtDiem.Columns.Add("Tong_SV_X")
            'Gán dữ liệu vào bảng danh sách sinh viên
            Doc_tham_so_he_thong()
            For i As Integer = dtDiem.Rows.Count - 1 To 0 Step -1
                'If dtDiem.Rows(i).Item("Ma_SV") = "C08.817" Then
                '    dtDiem.Rows(i).Item("Ma_SV") = "C08.817"
                'End If
                idx = Tim_idx_Diem_Max (dtDiem.Rows(i)("ID_sv"), ID_mon)
                dtDiem.Rows(i)("Locked") = 0
                dtDiem.Rows(i)("idx_diem") = -1
                dtDiem.Rows(i)("idx_diem_thi") = -1
                If idx >= 0 Then
                    Dim ZTBCBP As Double = 0
                    Dim ZTBCC As Double = 0
                    Dim ZKT As Integer = 0
                    Dim ZCC As Integer = 0
                    'Lấy 1 Object điểm
                    Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                    'If objDiem.ID_sv = 215 And objDiem.ID_mon = 106 Then
                    '    objDiem.ID_sv = 215
                    'End If

                    dtDiem.Rows(i)("idx_diem") = idx
                    'Nếu lần thi từ 2 trở lên thì chỉ đưa ra những sinh viên có điểm trước đó nhỏ hơn gDiem_thi_lai
                    Dim ThiLai As Boolean = False
                    If Fill_KyHieuDiem = -1 Then
                        ThiLai = objDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, Lan_thi)
                    ElseIf Fill_KyHieuDiem = 0 Then
                        'ThiLai = objDiem.Thi_lai_SauLan1_FD(Hoc_ky, Nam_hoc, Lan_thi)
                        ThiLai = objDiem.Thi_lai_SauLan1_F_D_C(Hoc_ky, Nam_hoc, Lan_thi)
                    End If
                    If Lan_thi > 1 AndAlso ((objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi - 1) >= 0 _
                                        And ThiLai) Or (objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi - 1, Hoc_ky, Nam_hoc) = "" And objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi) >= 0)) _
                                        Or (objDiem.Hoc_ky = Hoc_ky And objDiem.Nam_hoc = Nam_hoc And ThiLai) _
                                        Or (objDiem.Hoc_ky = Hoc_ky And objDiem.Nam_hoc = Nam_hoc And Lan_thi = 1) Or objDiem.dsDiemThi.Diem_chu_Min(Hoc_ky, Nam_hoc) = "F" Then
                        If idx_mon >= 0 Then
                            'Gán các điểm thành phần vào cột điểm

                            For j As Integer = 0 To dsThanhPhanDiem.Count - 1
                                If dsThanhPhanDiem.ESSThanhPhanDiem(j).Checked Then
                                    ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan
                                    'Tìm thành phần điểm theo ID_thanh_phan
                                    idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                                    'Lấy điểm thành phần theo ID_thanh_phan
                                    If idx1 >= 0 Then
                                        DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                        'dtDiem.Rows(i).Item("TP" + ID_thanh_phan.ToString) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                        dtDiem.Rows(i).Item(dsThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))

                                        If dsThanhPhanDiem.ESSThanhPhanDiem(j).Chuyen_can = False Then
                                            ZTBCBP += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                                            ZKT += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                                        Else
                                            ZTBCC += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                                            ZCC += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                                        End If
                                    End If


                                End If
                            Next
                        End If
                        'Gán dữ liệu điểm thi
                        Diem_thi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi)
                        dtDiem.Rows(i)("Hoc_ky") = objDiem.Hoc_ky
                        dtDiem.Rows(i)("Nam_hoc") = objDiem.Nam_hoc
                        If Diem_thi >= 0 Then
                            dtDiem.Rows(i)("Diem_thi") = Diem_thi
                        Else
                            dtDiem.Rows(i)("Diem_thi") = DBNull.Value
                        End If
                        'Kiểm tra điểm thi lần này đã khoá chưa?
                        If objDiem.dsDiemThi.Diem_thi_lan_Locked(Lan_thi, Hoc_ky, Nam_hoc) Then
                            dtDiem.Rows(i)("Locked") = 1
                        End If
                        If objDiem.dsDiemThi.TBCMH_lan(Lan_thi, Hoc_ky, Nam_hoc) >= 0 Then
                            dtDiem.Rows(i)("TBCMH") = Math.Round(objDiem.dsDiemThi.TBCMH_lan(Lan_thi, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                            dtDiem.Rows(i)("Diem_so") = Math.Round(objDiem.dsDiemThi.Diem_so_lan(Lan_thi, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                        End If
                        If ZKT > 0 Then dtDiem.Rows(i)("TBCBP") = Math.Round(ZTBCBP / ZKT, 0)
                        If ZCC > 0 Then dtDiem.Rows(i)("DiemCC") = Math.Round(ZTBCC / ZCC, 0)
                        dtDiem.Rows(i)("idx_diem_thi") = objDiem.dsDiemThi.idx_diem_thi(Hoc_ky, Nam_hoc, Lan_thi)
                        dtDiem.Rows(i)("ID_diem") = objDiem.ID_diem
                        dtDiem.Rows(i)("Diem_chu") = objDiem.dsDiemThi.Diem_chu_lan(Lan_thi, Hoc_ky, Nam_hoc)
                        dtDiem.Rows(i)("Diem_so") = objDiem.dsDiemThi.Diem_so_lan(Lan_thi, Hoc_ky, Nam_hoc)
                        dtDiem.Rows(i)("Ghi_chu") = objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc)

                        If dtDiem.Rows(i)("Diem_chu").ToString = "F" Or dtDiem.Rows(i)("Diem_chu").ToString = "F+" Then Tong_SV_KhongDat += 1
                        '-------Cac ghi chu dang duoc Fix---------------------------
                        If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "K" And objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "P" And objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper <> "V" Then Tong_SV_Du_DKDT = Tong_SV_Du_DKDT + 1
                        If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "K" Then Tong_SV_KoDu_DKDT = Tong_SV_KoDu_DKDT + 1
                        If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "P" Then Tong_SV_VangThi_CoPhep = Tong_SV_VangThi_CoPhep + 1
                        If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "V" Then Tong_SV_VangThi_KoPhep = Tong_SV_VangThi_KoPhep + 1
                        If objDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc).ToUpper = "X" Then Tong_SV_X = Tong_SV_X + 1

                    Else
                        dtDiem.Rows(i).Delete()
                    End If
                ElseIf Lan_thi > 1 Then
                    dtDiem.Rows(i).Delete()
                Else
                    dtDiem.Rows(i)("Diem_chu") = ""
                End If
            Next
            dtDiem.AcceptChanges()
            If dtDiem.Rows.Count > 0 Then
                Tong_SV = dtDiem.Rows.Count
                Tong_SV_Dat = Tong_SV - Tong_SV_KhongDat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Du_DKDT") = Tong_SV_Du_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KoDu_DKDT") = Tong_SV_KoDu_DKDT
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_CoPhep") = Tong_SV_VangThi_CoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_VangThi_KoPhep") = Tong_SV_VangThi_KoPhep
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV") = Tong_SV
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_Dat") = Tong_SV_Dat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_KhongDat") = Tong_SV_KhongDat
                dtDiem.Rows(dtDiem.Rows.Count - 1).Item("Tong_SV_X") = Tong_SV_X
            End If
            Return dtDiem
            'Return objSorted.TableSortHo_ten(dtDiem).Table
        End Function
        Public Function DanhSachDiemThanhPhan(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtDiemTP As DataTable = mdtDanhSachSinhVien.Copy
            Dim idx As Integer = -1, idx1 As Integer = -1, DiemTP As Double, ID_thanh_phan As Integer
            Dim zDiemBP As Double = 0
            Dim zTyLeBP As Integer = 0
            Dim zDiemCC As Double = 0
            Dim zTyLeCC As Integer = 0
            Dim idx_mon As Integer = Tim_idx(ID_mon)
            ''tt09 24/01/2018
            Dim mdtNhom As New DataTable
            mdtNhom.Columns.Add("Nhom", GetType(Integer))
            mdtNhom.Columns.Add("Ty_le_nhom", GetType(Integer))
            mdtNhom.Columns.Add("He_so_nhom", GetType(Integer))
            Dim dvNhom As DataView = mdtNhom.DefaultView
            Dim clsDM As New DanhMuc_Bussines

            'Add các cột điểm thành phần
            For i As Integer = 0 To Me.dsThanhPhanDiem.Count - 1
                If Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    If Not dtDiemTP.Columns.Contains(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) Then
                        dtDiemTP.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
                        dtDiemTP.Columns(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu).DefaultValue = ""
                        dvNhom.RowFilter = "Nhom=" & dsThanhPhanDiem.ESSThanhPhanDiem(i).Nhom.ToString
                        If dvNhom.Count = 1 Then
                            dvNhom.Item(0)("He_so_nhom") = Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).He_so
                            dvNhom.Item(0)("Ty_le_nhom") = Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).Ty_le
                        ElseIf Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).Nhom > 0 Then
                            Dim dr As DataRow = mdtNhom.NewRow
                            dr.Item("Nhom") = Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).Nhom
                            dr.Item("Ty_le_nhom") = Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).Ty_le
                            dr.Item("He_so_nhom") = Me.dsThanhPhanDiem.ESSThanhPhanDiem(i).He_so
                            mdtNhom.Rows.Add(dr)
                            mdtNhom.AcceptChanges()
                        End If
                    End If

                End If
            Next

            'For i As Integer = 0 To dsThanhPhanDiem.Count - 1
            '    If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
            '        'dtDiemTP.Columns.Add("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString)
            '        dtDiemTP.Columns.Add(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu)
            '        'dtDiemTP.Columns("TP" + dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan.ToString).DefaultValue = ""
            '        dtDiemTP.Columns(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu).DefaultValue = ""
            '    End If
            'Next

            dtDiemTP.Columns.Add("So_tiet_nghi_co_phep", GetType(Integer))
            dtDiemTP.Columns.Add("So_tiet_nghi_khong_phep", GetType(Integer))
            dtDiemTP.Columns.Add("Thieu_bai_thuc_hanh", GetType(Byte))
            dtDiemTP.Columns.Add("Ty_le_so_tiet_nghi", GetType(Integer))
            dtDiemTP.Columns.Add("Ghi_chu", GetType(String))

            Doc_tham_so_he_thong()
            'Thêm các cột điểm thi
            dtDiemTP.Columns.Add("ID_diem")
            dtDiemTP.Columns.Add("Locked")
            dtDiemTP.Columns.Add("Hoc_ky")
            dtDiemTP.Columns.Add("Nam_hoc")
            dtDiemTP.Columns.Add("DiemCC")
            dtDiemTP.Columns.Add("TBCBP")
            Dim Diem_CC_KhongDat As Boolean = False
            Dim Diem_KT_KhongDat As Boolean = False
            For r As Integer = dtDiemTP.Rows.Count - 1 To 0 Step -1
                'If dtDiemTP.Rows(r)("ID_sv") = 57581 Then
                '    dtDiemTP.Rows(r)("ID_sv") = 57581
                'End If
                dtDiemTP.Rows(r)("Ghi_chu") = ""
                If dtDiemTP.Rows(r)("ID_sv") = 488456 Then
                    dtDiemTP.Rows(r)("ID_sv") = 488456
                End If
                idx = Tim_idx_TP_ky(dtDiemTP.Rows(r)("ID_sv"), ID_mon, Hoc_ky, Nam_hoc)
                If idx < 0 Then idx = Tim_idx(dtDiemTP.Rows(r)("ID_sv"), ID_mon)
                If idx >= 0 Then
                    If idx_mon >= 0 Then
                        'Lấy 1 Object điểm
                        Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                        Dim idx_diemdanh As Integer = objDiem.dsDiemDanh.Tim_idx(objDiem.ID_diem, Hoc_ky, Nam_hoc)
                        If idx_diemdanh >= 0 Then
                            If objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_co_phep > 0 Then
                                dtDiemTP.Rows(r)("So_tiet_nghi_co_phep") = objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_co_phep
                            Else
                                dtDiemTP.Rows(r)("So_tiet_nghi_co_phep") = 0
                            End If

                            If objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_khong_phep > 0 Then
                                dtDiemTP.Rows(r)("So_tiet_nghi_khong_phep") = objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_khong_phep
                            Else
                                dtDiemTP.Rows(r)("So_tiet_nghi_khong_phep") = 0
                            End If
                            dtDiemTP.Rows(r)("Thieu_bai_thuc_hanh") = objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).Thieu_bai_thuc_hanh
                            If objDiem.So_tiet > 0 AndAlso (objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_co_phep > 0 Or objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_khong_phep > 0) Then
                                dtDiemTP.Rows(r)("Ty_le_so_tiet_nghi") = ((objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_co_phep + objDiem.dsDiemDanh.DiemDanh(idx_diemdanh).So_tiet_nghi_khong_phep) / objDiem.So_tiet) * 100
                            Else
                                dtDiemTP.Rows(r)("Ty_le_so_tiet_nghi") = 0
                            End If
                            If dtDiemTP.Rows(r)("Ty_le_so_tiet_nghi") > 30 Then
                                dtDiemTP.Rows(r)("Ghi_chu") = "Nghỉ " & dtDiemTP.Rows(r)("Ty_le_so_tiet_nghi") & " % số tiết"
                            End If
                            If dtDiemTP.Rows(r)("Thieu_bai_thuc_hanh") Then
                                If dtDiemTP.Rows(r)("Ghi_chu").ToString.Trim <> "" Then
                                    dtDiemTP.Rows(r)("Ghi_chu") = dtDiemTP.Rows(r)("Ghi_chu") & ", Nợ thực hành"
                                Else
                                    dtDiemTP.Rows(r)("Ghi_chu") = "Nợ thực hành"
                                End If
                            End If
                        End If

                        Dim Locked_tp As Integer = 0
                        dtDiemTP.Rows(r)("Locked") = 0
                        dtDiemTP.Rows(r)("ID_diem") = objDiem.ID_diem
                        zDiemBP = 0
                        zTyLeBP = 0
                        zDiemCC = 0
                        zTyLeCC = 0

                        'If objDiem.Hoc_ky = Hoc_ky And objDiem.Nam_hoc = Nam_hoc Or objDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "F" Or objDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "F+" Or objDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "D" or objDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "F" Then
                        'Gán các điểm thành phần vào cột điểm
                        For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                                ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                                'Tìm thành phần điểm theo ID_thanh_phan
                                idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                                'Lấy điểm thành phần theo ID_thanh_phan
                                If idx1 >= 0 Then
                                    DiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem
                                    If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can AndAlso Diem_chuyen_can_dat_Active AndAlso DiemTP < Diem_chuyen_can_dat Then
                                        Diem_CC_KhongDat = True
                                    ElseIf Diem_kiem_tra_bo_phan_dat_Active AndAlso dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False AndAlso DiemTP < Diem_kiem_tra_bo_phan_dat Then
                                        Diem_KT_KhongDat = True
                                    End If
                                    'dtDiemTP.Rows(r).Item("TP" + ID_thanh_phan.ToString) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    dtDiemTP.Rows(r).Item(dsThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = Math.Round(DiemTP, CType(Lam_tron_TBCMH, Integer))
                                    Locked_tp = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Locked
                                    If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False Then
                                        zDiemBP += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                        zTyLeBP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                    Else
                                        zDiemCC += DiemTP * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                        zTyLeCC += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                    End If

                                End If
                            End If
                        Next
                        'dtDiemTP.Rows(r).Item("Ghi_chu") = objDiem.dsDiemKhongDuDKThi.Ly_do_khong_du_dieu_kien_thi_lan(Hoc_ky, Nam_hoc)
                        dtDiemTP.Rows(r)("ID_diem") = objDiem.ID_diem
                        dtDiemTP.Rows(r)("Locked") = Locked_tp
                        dtDiemTP.Rows(r)("Hoc_ky") = objDiem.Hoc_ky
                        dtDiemTP.Rows(r)("Nam_hoc") = objDiem.Nam_hoc
                        If zTyLeBP > 0 Then dtDiemTP.Rows(r)("TBCBP") = Math.Round(zDiemBP / zTyLeBP, CType(Lam_tron_TBCMH, Integer))
                        If zTyLeCC > 0 Then dtDiemTP.Rows(r)("DiemCC") = Math.Round(zDiemCC / zTyLeCC, 0)

                        If IsDBNull(dtDiemTP.Rows(r)("TBCBP")) = False Then
                            If dtDiemTP.Rows(r)("TBCBP") < TBCBP_khong_dat Then
                                If dtDiemTP.Rows(r).Item("Ghi_chu") <> "" Then
                                    dtDiemTP.Rows(r).Item("Ghi_chu") += " ,TBCBP không đạt"
                                Else
                                    dtDiemTP.Rows(r).Item("Ghi_chu") = "TBCBP không đạt"
                                End If
                            End If
                        End If              
                        'ElseIf objDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc).Trim <> "" Then
                        '    dtDiemTP.Rows(r).Delete()
                        'End If
                    End If
                Else
                    dtDiemTP.Rows(r)("Locked") = 0
                End If
            Next
            Return dtDiemTP
            'Return objSorted.TableSortHo_ten(dtDiemTP).Table
        End Function
        Public Function Tinh_TBCBP(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal objDiemTP As ESSDiemThanhPhan, ByVal dvNhom As DataView) As Double
            Dim ZTy_le As Integer = 0
            Dim ZTy_le_nhom As Integer = 0
            Dim ZDiem_tp As Double = -1
            Dim ZTBCBP As Double = -1
            Dim ZDiem_tp1 As Double = -1

            Dim j As Integer = 0
            Do While (j <= dvNhom.Count - 1)
                If (ZDiem_tp = -1) Then
                    ZDiem_tp = 0
                End If
                ZDiem_tp1 = -1
                Dim ZTy_le1 As Integer = 0
                Dim ZTy_le_nhom1 As Integer = 0

                Dim i As Integer = 0
                Do While (i <= objDiemTP.Count - 1)
                    If dvNhom.Item(j).Item("Nhom") = objDiemTP.Nhom Then
                        Dim idx As Integer = objDiemTP.Tim_idx(objDiemTP.ID_thanh_phan, Hoc_ky, Nam_hoc)
                        If (idx >= 0) Then
                            If (ZDiem_tp1 = -1) Then
                                ZDiem_tp1 = 0
                            End If
                            ZDiem_tp1 = (ZDiem_tp1 + (objDiemTP.ESSDiemThanhPhan(idx).Diem * objDiemTP.ESSDiemThanhPhan(idx).Ty_le))
                            ZTy_le1 = (ZTy_le1 + objDiemTP.ESSDiemThanhPhan(idx).Ty_le)
                            'Else
                            '    ZTy_le1 = (ZTy_le1 + dsThanhPhan.ESSThanhPhanDiem(i).Ty_le)
                        End If
                    End If
                    i += 1
                Loop
                ZTy_le_nhom1 = dvNhom.Item(j)("Ty_le_nhom")
                ZTy_le_nhom = ZTy_le_nhom + ZTy_le_nhom1
                If ZTy_le1 > 0 Then ZDiem_tp = ZDiem_tp + (ZDiem_tp1 / CDbl(ZTy_le1)) * ZTy_le_nhom1

                j += 1
            Loop
            If ((ZTy_le_nhom > 0) And (ZDiem_tp >= 0)) Then
                ZTBCBP = (ZDiem_tp / CDbl(ZTy_le_nhom))
                Return Math.Round(CDbl((ZTBCBP + 0.0000001)), 1)
            End If
            Return -1
        End Function
        Public Function DanhSachThanhPhan() As DataTable
            Dim dtTP As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtTP.Columns.Add("Chon", GetType(Boolean))
            dtTP.Columns.Add("ID_thanh_phan", GetType(Integer))
            dtTP.Columns.Add("STT", GetType(Integer))
            dtTP.Columns.Add("Ky_hieu", GetType(String))
            dtTP.Columns.Add("Ten_thanh_phan", GetType(String))
            dtTP.Columns.Add("Ty_le", GetType(Integer))
            dtTP.Columns.Add("He_so", GetType(Integer))
            dtTP.Columns.Add("Nhom", GetType(Integer))
            dtTP.Columns.Add("Chuyen_can", GetType(Boolean))
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                Dim dr As DataRow
                dr = dtTP.NewRow
                With dsThanhPhanDiem.ESSThanhPhanDiem(i)
                    If .Checked Then
                        dr("Chon") = 1
                        Tong_ty_le += .Ty_le
                    Else
                        dr("Chon") = 0
                    End If
                    dr("ID_thanh_phan") = .ID_thanh_phan
                    dr("STT") = .STT
                    dr("Ky_hieu") = .Ky_hieu
                    dr("Ten_thanh_phan") = .Ten_thanh_phan
                    dr("Ty_le") = .Ty_le
                    dr("He_so") = .He_so
                    dr("Nhom") = .Nhom
                    dr("Chuyen_can") = .Chuyen_can
                End With
                dtTP.Rows.Add(dr)
            Next
            Return dtTP
        End Function
        Public Function DanhSachThanhPhanChon() As DataTable
            Dim dtTP As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtTP.Columns.Add("Chon", GetType(Boolean))
            dtTP.Columns.Add("ID_thanh_phan", GetType(Integer))
            dtTP.Columns.Add("STT", GetType(Integer))
            dtTP.Columns.Add("Ky_hieu", GetType(String))
            dtTP.Columns.Add("Ten_thanh_phan", GetType(String))
            dtTP.Columns.Add("Ty_le", GetType(Integer))
            dtTP.Columns.Add("He_so", GetType(Integer))
            dtTP.Columns.Add("Nhom", GetType(Integer))
            dtTP.Columns.Add("Chuyen_can", GetType(Boolean))
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                With dsThanhPhanDiem.ESSThanhPhanDiem(i)
                    If .Checked Then
                        Dim dr As DataRow
                        dr = dtTP.NewRow
                        dr("Chon") = 1
                        Tong_ty_le += .Ty_le
                        dr("ID_thanh_phan") = .ID_thanh_phan
                        dr("STT") = .STT
                        dr("Ky_hieu") = .Ky_hieu
                        dr("Ten_thanh_phan") = .Ten_thanh_phan
                        dr("Ty_le") = .Ty_le
                        dr("He_so") = .He_so
                        dr("Nhom") = .Nhom
                        dr("Chuyen_can") = .Chuyen_can
                        dtTP.Rows.Add(dr)
                    End If
                End With
            Next
            Return dtTP
        End Function
        Public Function DanhSachMonHoc() As DataTable
            Dim dtMonHoc As New DataTable
            Dim Tong_ty_le As Integer = 0
            dtMonHoc.Columns.Add("ID_mon", GetType(Integer))
            dtMonHoc.Columns.Add("Ky_hieu", GetType(String))
            dtMonHoc.Columns.Add("Ten_mon", GetType(String))
            dtMonHoc.Columns.Add("So_hoc_trinh", GetType(Integer))
            For i As Integer = 0 To dsMonHoc.Count - 1
                Dim dr As DataRow
                dr = dtMonHoc.NewRow
                With dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
                    dr("ID_mon") = .ID_mon
                    dr("Ky_hieu") = .Ky_hieu
                    dr("Ten_mon") = .Ten_mon
                    dr("So_hoc_trinh") = .So_hoc_trinh
                End With
                dtMonHoc.Rows.Add(dr)
            Next
            Return dtMonHoc
        End Function
        Public Function HienThi_ESSDiem_chu() As DataTable
            Try
                Dim dtDiem_chu As New DataTable
                dtDiem_chu.Columns.Add("Diem_chu")
                dtDiem_chu.Columns.Add("Diem_chu1")
                'Add một bản ghi trắng
                Dim dr1 As DataRow
                dr1 = dtDiem_chu.NewRow
                dr1("Diem_chu") = ""
                dr1("Diem_chu1") = ""
                dtDiem_chu.Rows.Add(dr1)
                For i As Integer = 0 To dsDiemQuyDoi.Count - 1
                    Dim dr As DataRow
                    dr = dtDiem_chu.NewRow
                    With dsDiemQuyDoi.ESSDiemQuyDoi(i)
                        dr("Diem_chu") = .Diem_chu
                        dr("Diem_chu1") = .Diem_chu
                    End With
                    dtDiem_chu.Rows.Add(dr)
                Next
                Return dtDiem_chu
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function PhanLoaiHocTap_Lop(ByVal dt_kqht As DataTable, ByVal ID_lops As String) As DataTable
            'Dinh nghia cac truong du lieu
            Dim clsDAL As New Diem_DataAccess
            Dim dt As DataTable = clsDAL.HienThi_ESSPhanLoaiKetQuaHocTap(ID_lops)

            Dim dtXepLoaiHocTap As DataTable = clsDAL.HienThi_ESSXepLoaiHocTap()
            For i As Integer = 0 To dtXepLoaiHocTap.Rows.Count - 1
                dt.Columns.Add("SL" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString, GetType(String))
                dt.Columns.Add("PT" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString, GetType(String))
            Next

            'Gan du lieu cho cac truong du lieu
            For j As Integer = 0 To dt.Rows.Count - 1
                For i As Integer = 0 To dtXepLoaiHocTap.Rows.Count - 1
                    dt_kqht.DefaultView.RowFilter = "1=1"
                    dt_kqht.DefaultView.RowFilter = "TBCHT<>'' AND ID_lop=" & dt.Rows(j).Item("ID_lop") & " AND ID_xep_loai=" & dtXepLoaiHocTap.Rows(i)("ID_xep_loai")

                    dt.Rows(j).Item("SL" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString) = IIf(dt_kqht.DefaultView.Count > 0, dt_kqht.DefaultView.Count, "")
                    dt.Rows(j).Item("PT" + dtXepLoaiHocTap.Rows(i)("ID_xep_loai").ToString) = IIf(dt_kqht.DefaultView.Count > 0, Format(dt_kqht.DefaultView.Count * 100 / dt.Rows(j).Item("Tong_so"), "##0"), "")
                Next
            Next

            Return dt
        End Function
        Function PhanLoaiHocTap_Mon(ByVal dt_kqht As DataTable) As DataTable
            'Dinh nghia cac truong du lieu
            Dim clsDAL As New Diem_DataAccess
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Tong_so", GetType(String))
            Dim dtDiemQuyDoi As DataTable = clsDAL.HienThi_ESSDiemQuyDoi
            For i As Integer = 0 To dtDiemQuyDoi.Rows.Count - 1
                If dtDiemQuyDoi.Rows(i).Item("Xep_loai").ToString <> "" Then
                    dt.Columns.Add("SL" + dtDiemQuyDoi.Rows(i)("ID_xep_loai").ToString, GetType(String))
                    dt.Columns.Add("PT" + dtDiemQuyDoi.Rows(i)("ID_xep_loai").ToString, GetType(String))
                End If
            Next

            Dim dr As DataRow
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    dr = dt.NewRow
                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString
                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon.ToString
                    dt.Rows.Add(dr)
                End If
            Next

            'Gan du lieu cho cac truong du lieu
            For j As Integer = 0 To dt.Rows.Count - 1
                Dim Tong_so As Integer
                For i As Integer = 0 To dtDiemQuyDoi.Rows.Count - 1
                    If dtDiemQuyDoi.Rows(i).Item("Xep_loai").ToString <> "" Then
                        Dim Tong_xep_loai As Integer
                        Tong_so = 0
                        Tong_xep_loai = 0
                        For m As Integer = 0 To dt_kqht.Rows.Count - 1
                            If dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon")).ToString <> "" Then
                                Tong_so += 1
                                If dsDiemQuyDoi.IDXepLoaiDiemQuyDoiDiemSo(dt_kqht.Rows(m).Item("M" & dt.Rows(j).Item("ID_mon"))) = dtDiemQuyDoi.Rows(i)("ID_xep_loai") Then Tong_xep_loai += 1
                            End If
                        Next
                        If Tong_so = 0 Then Tong_so = 1
                        dt.Rows(j).Item("SL" + dtDiemQuyDoi.Rows(i)("ID_xep_loai").ToString) = IIf(Tong_xep_loai > 0, Tong_xep_loai, "")
                        dt.Rows(j).Item("PT" + dtDiemQuyDoi.Rows(i)("ID_xep_loai").ToString) = IIf(Tong_xep_loai > 0, Format(Tong_xep_loai * 100 / Tong_so, "##0"), "")
                    End If
                Next
                dt.Rows(j).Item("Tong_so") = Tong_so
            Next

            Return dt
        End Function
        Public Function TongHopDiemHocKy(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal Tu_diem As Double = -1, Optional ByVal Den_diem As Double = -1) As DataTable
            Try
                Doc_thamso_hethong()
                Dim dtTongHop As New DataTable
                Dim Diem_chu, Ghi_chu As String
                Dim idx_diem As Integer, ID_mon As Integer
                Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Double, Tong_so_hoc_trinh_TL As Double
                Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer
                Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
                dtTongHop = mdtDanhSachSinhVien.Copy
                dtTongHop.Columns.Add("TBCHT", GetType(String))
                dtTongHop.Columns.Add("TBCHT10", GetType(String))
                dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
                dtTongHop.Columns.Add("Xep_loai", GetType(String))
                dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
                dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
                dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
                dtTongHop.Columns.Add("So_tin_chi_dang_ky_ky", GetType(Double))
                dtTongHop.Columns.Add("So_tin_chi_tich_luy_ky", GetType(Double))
                'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
                Dim clsDAL As New Diem_DataAccess
                For r As Integer = dtTongHop.Rows.Count - 1 To 0 Step -1
                    So_mon_no = 0
                    Tong_diem = 0
                    Tong_diem10 = 0
                    Tong_so_hoc_trinh = 0
                    Tong_so_hoc_trinh_TL = 0
                    So_mon_hoc_lai = 0
                    So_mon_thi_lai = 0
                    Ghi_chu = ""
                    If dtTongHop.Rows(r)("ID_sv") = 472139 Then
                        dtTongHop.Rows(r)("ID_sv") = 472139
                    End If
                    'Duyet cac mon hoc
                    For i As Integer = 0 To dsMonHoc.Count - 1
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        If dtTongHop.Rows(r)("ID_SV") = 464018 And ID_mon = 929 Then
                            dtTongHop.Rows(r)("ID_SV") = 464018

                        End If
                        'If dtTongHop.Rows(r)("ID_sv") = 469532 Then
                        '    dtTongHop.Rows(r)("ID_sv") = 469532
                        'End If

                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx_Thi_ky(dtTongHop.Rows(r)("ID_sv"), ID_mon, Hoc_ky, Nam_hoc, Lan_thi)

                        If clsDAL.Check_DangKy_TheoKy(dtTongHop.Rows(r)("ID_sv"), ID_mon, Hoc_ky, Nam_hoc) > 0 AndAlso clsDAL.Check_HocPhan_TuongDuong(ID_mon, dtTongHop.Rows(r)("ID_dt"), dtTongHop.Rows(r)("ID_sv")) = False Then
                            'Nếu sinh viên có điểm môn học này thì tính điểm
                            If idx_diem >= 0 Then
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                'If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                                'Else
                                If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                                If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, Lan_thi) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(Hoc_ky, Nam_hoc, Lan_thi)) Then So_mon_thi_lai += 1
                                If Lan_thi = 1 Then
                                    Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                                    TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                                Else
                                    Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop(Hoc_ky, Nam_hoc)
                                    TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                                End If
                                If Diem_so >= 0 Then
                                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                        Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        If Diem_so = 0 Then So_mon_no += 1
                                    End If
                                End If
                                If Diem_so > 0 Then
                                    Tong_so_hoc_trinh_TL = Tong_so_hoc_trinh_TL + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                '---------Add column----------------
                                If Hien_thi_diem_TP Then
                                    Dim col As New DataColumn()
                                    'Voi ESSDiem thanh phan
                                    For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                                        col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                                        If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                        If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                                    Next
                                    'Voi ESSDiem thi
                                    col = New DataColumn("T" + ID_mon.ToString + "Thi")
                                    If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                    If Lan_thi = 1 Then
                                        If ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi).ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Else
                                        If ESSDiem.dsDiemThi.Diem_thi_max(Hoc_ky, Nam_hoc).ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    End If
                                End If
                                If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("M" + ID_mon.ToString)
                                End If

                                If dtTongHop.Columns.IndexOf("MI" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("MI" + ID_mon.ToString)
                                End If

                                If dtTongHop.Columns.IndexOf("MI" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("MI" + ID_mon.ToString)
                                End If
                                If dtTongHop.Columns.IndexOf("MC" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("MC" + ID_mon.ToString)

                                End If
                                If dtTongHop.Columns.IndexOf("MS" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("MS" + ID_mon.ToString)
                                End If

                                '------------------End Column----------------------

                                If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                                    dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_chu
                                ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                                    If Diem_so >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_so
                                Else    'Hiển thị điểm số thang điểm 10
                                    If TBCMH >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = TBCMH
                                End If
                                'Hiển thị ghi chú cạnh cột điểm
                                If Hien_thi_ghi_chu Then
                                    If dtTongHop.Rows(r)("M" + ID_mon.ToString).ToString = "" Then
                                        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += Ghi_chu
                                    Else
                                        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                                    End If
                                End If

                                If TBCMH >= 0 Then dtTongHop.Rows(r)("MI" + ID_mon.ToString) = TBCMH
                                dtTongHop.Rows(r)("MC" + ID_mon.ToString) = Diem_chu
                                If Diem_so >= 0 Then dtTongHop.Rows(r)("MS" + ID_mon.ToString) = Diem_so
                                'End If
                            End If
                        End If
                    Next
                    'Tính điểm TBCHT và xếp loại
                    If Tong_so_hoc_trinh > 0 Then
                        TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                        TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                        dtTongHop.Rows(r)("So_tin_chi_tich_luy_ky") = Tong_so_hoc_trinh_TL
                        dtTongHop.Rows(r)("So_tin_chi_dang_ky_ky") = clsDAL.SoTinChi_DangKy_TheoKy(dtTongHop.Rows(r)("ID_sv"), Hoc_ky, Nam_hoc)
                    Else
                        TBCHT = -1
                        TBCHT10 = -1
                    End If
                    If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT") = TBCHT
                    If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT10") = TBCHT10
                    dtTongHop.Rows(r)("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                    dtTongHop.Rows(r)("Xep_loai") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT)



                    If So_mon_no > 0 Then dtTongHop.Rows(r)("So_mon_no") = So_mon_no
                    If So_mon_thi_lai > 0 Then dtTongHop.Rows(r)("So_mon_thi_lai") = So_mon_thi_lai
                    If So_mon_hoc_lai > 0 Then dtTongHop.Rows(r)("So_mon_hoc_lai") = So_mon_hoc_lai

                    If Tu_diem >= 0 And Den_diem >= 0 Then
                        If TBCHT10 < Tu_diem Or TBCHT10 >= Den_diem Then
                            dtTongHop.Rows(r).Delete()
                        End If
                    ElseIf Tu_diem >= 0 And Den_diem < 0 Then
                        If TBCHT10 < Tu_diem Then
                            dtTongHop.Rows(r).Delete()
                        End If
                    ElseIf Tu_diem < 0 And Den_diem >= 0 Then
                        If TBCHT10 >= Den_diem Then
                            dtTongHop.Rows(r).Delete()
                        End If
                    End If
                Next
                dtTongHop.AcceptChanges()
                Return dtTongHop
            Catch ex As Exception
            End Try
        End Function

        Public Function TongHopDiemHocKy_New(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal Tu_diem As Double = -1, Optional ByVal Den_diem As Double = -1) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            'For Each dr In dtTongHop.Rows
            For r As Integer = dtTongHop.Rows.Count - 1 To 0 Step -1
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Ghi_chu = ""
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1

                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                        If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, Lan_thi) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(Hoc_ky, Nam_hoc, Lan_thi)) Then So_mon_thi_lai += 1
                        If Lan_thi = 1 Then
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                            TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        Else
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                            TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        End If
                        If Diem_so >= 0 Then
                            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            If Diem_so = 0 Then So_mon_no += 1
                        End If

                        ''---------Add column----------------
                        'If Hien_thi_diem_TP Then
                        '    Dim col As New DataColumn()
                        '    'Voi ESSDiem thanh phan
                        '    For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                        '        col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                        '        If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                        '        If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dr("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                        '    Next
                        '    'Voi ESSDiem thi
                        '    col = New DataColumn("T" + ID_mon.ToString + "Thi")
                        '    If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                        '    If Lan_thi = 1 Then
                        '        If ESSDiem.dsDiemThi.Diem_thi_lan(Lan_thi).ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        '    Else
                        '        If ESSDiem.dsDiemThi.Diem_thi_max.ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        '    End If
                        'End If
                        'If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                        '    dtTongHop.Columns.Add("M" + ID_mon.ToString)
                        'End If
                        '------------------End Column----------------------

                        'If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                        '    dr("M" + ID_mon.ToString) = Diem_chu
                        'ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                        '    If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so
                        'Else    'Hiển thị điểm số thang điểm 10
                        '    If TBCMH >= 0 Then dr("M" + ID_mon.ToString) = TBCMH
                        'End If
                        ''Hiển thị ghi chú cạnh cột điểm
                        'If Hien_thi_ghi_chu Then
                        '    If dr("M" + ID_mon.ToString).ToString = "" Then
                        '        If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += Ghi_chu
                        '    Else
                        '        If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                        '    End If
                        'End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT = -1
                    TBCHT10 = -1
                End If
                If TBCHT >= 0 Then dr("TBCHT") = TBCHT
                If TBCHT >= 0 Then dr("TBCHT10") = TBCHT10
                'dr("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                'dr("Xep_loai") = dsXepHangHocLuc.ESSXepHangHocLuc(TBCHT)

                dr("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                dr("Xep_loai") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT)
                If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                If So_mon_thi_lai > 0 Then dr("So_mon_thi_lai") = So_mon_thi_lai
                If So_mon_hoc_lai > 0 Then dr("So_mon_hoc_lai") = So_mon_hoc_lai


                If Tu_diem >= 0 And Den_diem >= 0 Then
                    If TBCHT10 < Tu_diem Or TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem >= 0 And Den_diem < 0 Then
                    If TBCHT10 < Tu_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem < 0 And Den_diem >= 0 Then
                    If TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                End If

            Next
            dtTongHop.AcceptChanges()
            Return dtTongHop
        End Function

        Public Function TongHopDiemNamHoc(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, Optional ByVal Tu_diem As Double = -1, Optional ByVal Den_diem As Double = -1) As DataTable
            Doc_thamso_hethong()
            Dim clsDAL As New Diem_DataAccess
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
            'Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("TC_TichLuy_Nam", GetType(Integer))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For r As Integer = dtTongHop.Rows.Count - 1 To 0 Step -1

                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Ghi_chu = ""
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx(dtTongHop.Rows(r)("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, dtTongHop.Rows(r)("ID_dt"), dtTongHop.Rows(r)("ID_sv")) = False Then
                                If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                                If ESSDiem.Thi_lai_SauLan1(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, Lan_thi) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(Lan_thi, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)) Then So_mon_thi_lai += 1
                                If Lan_thi = 1 Then
                                    Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                    TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                Else
                                    Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop(0, ESSDiem.Nam_hoc)
                                    TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max(0, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                End If
                                If Diem_so >= 0 Then
                                    Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                    Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    If Diem_so = 0 Then So_mon_no += 1
                                End If
                                If Diem_so > 0 Then So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                '---------Add column----------------
                                If Hien_thi_diem_TP Then
                                    Dim col As New DataColumn()
                                    'Voi ESSDiem thanh phan
                                    For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                                        col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                                        If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                        If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                                    Next
                                    'Voi ESSDiem thi
                                    col = New DataColumn("T" + ID_mon.ToString + "Thi")
                                    If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                    If Lan_thi = 1 Then
                                        If ESSDiem.dsDiemThi.Diem_thi_lan(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, Lan_thi).ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Else
                                        If ESSDiem.dsDiemThi.Diem_thi_max.ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    End If
                                End If
                                If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                                    dtTongHop.Columns.Add("M" + ID_mon.ToString)
                                End If
                                '------------------End Column----------------------

                                If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                                    dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_chu
                                ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                                    If Diem_so >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_so
                                Else    'Hiển thị điểm số thang điểm 10
                                    If TBCMH >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = TBCMH
                                End If
                                'Hiển thị ghi chú cạnh cột điểm
                                If Hien_thi_ghi_chu Then
                                    If dtTongHop.Rows(r)("M" + ID_mon.ToString).ToString = "" Then
                                        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += Ghi_chu
                                    Else
                                        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT = -1
                    TBCHT10 = -1
                End If
                If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT") = TBCHT
                If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT10") = TBCHT10
                dtTongHop.Rows(r)("TC_TichLuy_Nam") = So_hoc_trinh

                dtTongHop.Rows(r)("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                dtTongHop.Rows(r)("Xep_loai") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT)

                If So_mon_no > 0 Then dtTongHop.Rows(r)("So_mon_no") = So_mon_no
                If So_mon_thi_lai > 0 Then dtTongHop.Rows(r)("So_mon_thi_lai") = So_mon_thi_lai
                If So_mon_hoc_lai > 0 Then dtTongHop.Rows(r)("So_mon_hoc_lai") = So_mon_hoc_lai

                If Tu_diem >= 0 And Den_diem >= 0 Then
                    If TBCHT10 < Tu_diem Or TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem >= 0 And Den_diem < 0 Then
                    If TBCHT10 < Tu_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem < 0 And Den_diem >= 0 Then
                    If TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                End If

            Next
            dtTongHop.AcceptChanges()
            Return dtTongHop
        End Function

        Public Function TongHopDiemNamHoc_New(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, Optional ByVal Tu_diem As Double = -1, Optional ByVal Den_diem As Double = -1) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
            'Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("TC_TichLuy_Nam", GetType(Integer))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            'For Each dr In dtTongHop.Rows
            For r As Integer = dtTongHop.Rows.Count - 1 To 0 Step -1
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Ghi_chu = ""
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx(dtTongHop.Rows(r)("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                            If ESSDiem.Thi_lai_SauLan1(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, Lan_thi) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, Lan_thi)) Then So_mon_thi_lai += 1
                            If Lan_thi = 1 Then
                                Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                            Else
                                Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                            End If
                            If Diem_so >= 0 Then
                                Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                If Diem_so = 0 Then So_mon_no += 1
                            End If
                            So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            ''---------Add column----------------
                            'If Hien_thi_diem_TP Then
                            '    Dim col As New DataColumn()
                            '    'Voi ESSDiem thanh phan
                            '    For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                            '        col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                            '        If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                            '        If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                            '    Next
                            '    'Voi ESSDiem thi
                            '    col = New DataColumn("T" + ID_mon.ToString + "Thi")
                            '    If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                            '    If Lan_thi = 1 Then
                            '        If ESSDiem.dsDiemThi.Diem_thi_lan(Lan_thi).ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            '    Else
                            '        If ESSDiem.dsDiemThi.Diem_thi_max.ToString <> "" Then dtTongHop.Rows(r)("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            '    End If
                            'End If
                            'If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                            '    dtTongHop.Columns.Add("M" + ID_mon.ToString)
                            'End If
                            ''------------------End Column----------------------

                            'If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                            '    dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_chu
                            'ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                            '    If Diem_so >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_so
                            'Else    'Hiển thị điểm số thang điểm 10
                            '    If TBCMH >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = TBCMH
                            'End If
                            ''Hiển thị ghi chú cạnh cột điểm
                            'If Hien_thi_ghi_chu Then
                            '    If dtTongHop.Rows(r)("M" + ID_mon.ToString).ToString = "" Then
                            '        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += Ghi_chu
                            '    Else
                            '        If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                            '    End If
                            'End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT = -1
                    TBCHT10 = -1
                End If
                If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT") = TBCHT
                If TBCHT >= 0 Then dtTongHop.Rows(r)("TBCHT10") = TBCHT10
                dtTongHop.Rows(r)("TC_TichLuy_Nam") = So_hoc_trinh
                'dtTongHop.Rows(r)("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                dtTongHop.Rows(r)("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                dtTongHop.Rows(r)("Xep_loai") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT)

                If So_mon_no > 0 Then dtTongHop.Rows(r)("So_mon_no") = So_mon_no
                If So_mon_thi_lai > 0 Then dtTongHop.Rows(r)("So_mon_thi_lai") = So_mon_thi_lai
                If So_mon_hoc_lai > 0 Then dtTongHop.Rows(r)("So_mon_hoc_lai") = So_mon_hoc_lai

                If Tu_diem >= 0 And Den_diem >= 0 Then
                    If TBCHT10 < Tu_diem Or TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem >= 0 And Den_diem < 0 Then
                    If TBCHT10 < Tu_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem < 0 And Den_diem >= 0 Then
                    If TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                End If
            Next
            dtTongHop.AcceptChanges()
            Return dtTongHop
        End Function

        Public Function TongHopDiemTinChiTichLuy(ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, Optional ByVal Tu_diem As Double = -1, Optional ByVal Den_diem As Double = -1) As DataTable
            Doc_thamso_hethong()
            Dim clsDAL As New Diem_DataAccess
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            'Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Nam_thu", GetType(Integer))
            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            'For Each dtTongHop.Rows(r) In dtTongHop.Rows
            Dim So_lan As Integer = 0
            For r As Integer = dtTongHop.Rows.Count - 1 To 0 Step -1
                If dtTongHop.Rows(r)("ID_SV") = 57113 Then
                    dtTongHop.Rows(r)("ID_SV") = 57113
                End If
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                So_lan = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'If dtTongHop.Rows(r)("ID_sv") = 157025 Then
                    '    dtTongHop.Rows(r)("ID_sv") = 157025
                    'End If
                    'Tim ESSDiem cua sinh vien nay
                    '================Neu vơi TH tich luy can tinh Mark ko co no se dung lai vi tri lai diem
                    'idx_diem = Tim_idx(dtTongHop.Rows(r)("ID_sv"), ID_mon)
                    idx_diem = Tim_idx_Diem_Max(dtTongHop.Rows(r)("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ESSDiem.Tinh_tich_luy = False
                        ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, dtTongHop.Rows(r)("ID_dt"), dtTongHop.Rows(r)("ID_sv")) = False Then
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                            TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                            'Tính điểm tích luỹ
                            If dsDiemQuyDoi.TichLuy(Diem_chu) Then

                                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                    'Tính số tín chỉ tích luỹ
                                    If Diem_so > 0 Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                        Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                End If
                            Else
                                So_lan = So_lan + 1
                            End If
                            'Tính số môn nợ
                            If Diem_so = 0 Then So_mon_no += 1
                            If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                                dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_chu
                            ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                                If Diem_so >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = Diem_so.ToString
                            Else    'Hiển thị điểm số thang điểm 10
                                If TBCMH >= 0 Then dtTongHop.Rows(r)("M" + ID_mon.ToString) = TBCMH.ToString
                            End If
                            'Hiển thị ghi chú cạnh cột điểm
                            If Hien_thi_ghi_chu Then
                                If dtTongHop.Rows(r)("M" + ID_mon.ToString).ToString = "" Then
                                    If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += Ghi_chu
                                Else
                                    If Ghi_chu.Trim <> "" Then dtTongHop.Rows(r)("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                                End If
                            End If
                        End If
                    End If
                Next
                'If dtTongHop.Rows(r)("ID_SV") = 157025 Then
                '    MsgBox(So_lan)
                'End If
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    dtTongHop.Rows(r)("TBCHT") = Format(TBCHT, "##.00")
                    dtTongHop.Rows(r)("TBCHT10") = Format(TBCHT10, "##.00")
                    dtTongHop.Rows(r)("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                    dtTongHop.Rows(r)("Xep_loai") = dsXepHangHocLuc.ESSXepHangHocLuc(TBCHT)
                    dtTongHop.Rows(r)("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh)
                    If So_mon_no > 0 Then dtTongHop.Rows(r)("So_mon_no") = So_mon_no
                    dtTongHop.Rows(r)("So_hoc_trinh") = So_hoc_trinh
                End If

                If Tu_diem >= 0 And Den_diem >= 0 Then
                    If TBCHT10 < Tu_diem Or TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem >= 0 And Den_diem < 0 Then
                    If TBCHT10 < Tu_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                ElseIf Tu_diem < 0 And Den_diem >= 0 Then
                    If TBCHT10 >= Den_diem Then
                        dtTongHop.Rows(r).Delete()
                    End If
                End If
            Next
            dtTongHop.AcceptChanges()
            Return dtTongHop
        End Function

        Public Function TongHopDiemTinChiTichLuy_New(ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Nam_thu", GetType(Integer))
            ''Add cac cot ESSDiem cua cac mon hoc
            'For i As Integer = 0 To dsMonHoc.Count - 1
            '    If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
            '        dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
            '    End If
            'Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows

                If dr("ID_sv") = 157719 Then
                    dr("ID_sv") = 157719
                End If
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                        TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                        'Tính điểm tích luỹ
                        If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                            'Tính số tín chỉ tích luỹ
                            If Diem_so > 0 Then
                                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                    Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                            End If
                        End If
                        'Tính số môn nợ
                        If Diem_so = 0 Then So_mon_no += 1
                        'If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                        '    dr("M" + ID_mon.ToString) = Diem_chu
                        'ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                        '    If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so.ToString
                        'Else    'Hiển thị điểm số thang điểm 10
                        '    If TBCMH >= 0 Then dr("M" + ID_mon.ToString) = TBCMH.ToString
                        'End If
                        'Hiển thị ghi chú cạnh cột điểm
                        'If Hien_thi_ghi_chu Then
                        '    If dr("M" + ID_mon.ToString).ToString = "" Then
                        '        If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += Ghi_chu
                        '    Else
                        '        If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                        '    End If
                        'End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("TBCHT10") = Format(TBCHT10, "##.00")
                    dr("ID_xep_loai") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                    dr("Xep_loai") = dsXepHangHocLuc.ESSXepHangHocLuc(TBCHT)
                    dr("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh)
                    If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                    dr("So_hoc_trinh") = So_hoc_trinh
                End If
            Next
            Return dtTongHop
        End Function


        Public Function TongHopDiemMonChungChi(ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer, ByVal GDTC As Boolean) As DataTable
            Dim dtTongHop As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim TBCHT, TBCMH As Double
            Dim dr As DataRow
            Doc_thamso_hethong()
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Dim Ly_do As String = ""

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)

                    'Check mon thuoc ID_dt va cugn Loai chung chi moi tong hop
                    If idx_diem >= 0 AndAlso Tim_idx_MonChungChi(ID_mon, ID_dt, ID_chung_chi) >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        Tong_diem += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        'Kiem tra cac mon trong ds mon cua chung chi voi chung chi GDQP
                        If GDTC = False AndAlso TBCMH < 5 Then Ly_do = "No mon"
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepLoaiChungChi.IDXepLoaiChungChi(TBCHT)
                    dr("Xep_hang") = dsXepLoaiChungChi.ESSXepLoaiChungChi(TBCHT)
                End If
                dr("Chon") = False
                dr("Ly_do") = Ly_do.Trim
            Next
            dtTongHop.DefaultView.RowFilter = "Ly_do='' AND TBCHT>=5"
            Return dtTongHop
        End Function

        Private Sub Doc_tham_so_he_thong()
            Try
                Dim cls As New ThamSoHeThong_Bussines
                MucXuLy_KyLuat_HaLoaiTotNghiep = cls.Doc_tham_so("MucXuLy_KyLuat_HaLoaiTotNghiep")
                MucXuLy_KyLuat_HaLoaiTotNghiep_Active = cls.Doc_tham_so_Active("MucXuLy_KyLuat_HaLoaiTotNghiep")
                PtramTCithilai_hatotnghiep = cls.Doc_tham_so("PtramTCithilai_hatotnghiep")
                PtramTCithilai_hatotnghiep_Active = cls.Doc_tham_so_Active("PtramTCithilai_hatotnghiep")

                NamXet_TBCHT = cls.Doc_tham_so("NamXet_TBCHT")
                NamXet_TBCHT_Active = cls.Doc_tham_so_Active("NamXet_TBCHT")

                KyDau_TBCTL = cls.Doc_tham_so("KyDau_TBCTL")
                KyDau_TBCTL_Active = cls.Doc_tham_so_Active("KyDau_TBCTL")
                KyBatKy_TBCTL = cls.Doc_tham_so("KyBatKy_TBCTL")
                KyBatKy_TBCTL_Active = cls.Doc_tham_so_Active("KyBatKy_TBCTL")
                HaiKyLienTiep_TBCTL = cls.Doc_tham_so("2KyLienTiep_TBCTL")
                HaiKyLienTiep_TBCTL_Active = cls.Doc_tham_so_Active("2KyLienTiep_TBCTL")
                NamDau_TBCTL = cls.Doc_tham_so("NamDau_TBCTL")
                NamDau_TBCTL_Active = cls.Doc_tham_so_Active("NamDau_TBCTL")
                NamThu2_TBCTL = cls.Doc_tham_so("NamThu2_TBCTL")
                NamThu2_TBCTL_Active = cls.Doc_tham_so_Active("NamThu2_TBCTL")
                NamThu3_TBCTL = cls.Doc_tham_so("NamThu3_TBCTL")
                NamThu3_TBCTL_Active = cls.Doc_tham_so_Active("NamThu3_TBCTL")
                TuNamThu4_TBCTL = cls.Doc_tham_so("TuNamThu4_TBCTL")
                TuNamThu4_TBCTL_Active = cls.Doc_tham_so_Active("TuNamThu4_TBCTL")

                Diem_chuyen_can_dat = cls.Doc_tham_so("Diem_chuyen_can_dat")
                Diem_chuyen_can_dat_Active = cls.Doc_tham_so_Active("Diem_chuyen_can_dat_Active")
                Diem_kiem_tra_bo_phan_dat = cls.Doc_tham_so("Diem_kiem_tra_bo_phan_dat")
                Diem_kiem_tra_bo_phan_dat_Active = cls.Doc_tham_so_Active("Diem_kiem_tra_bo_phan_dat_Active")

                Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
                LamTron_Diem_TongHop = cls.Doc_tham_so("LamTron_Diem_TongHop")

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function TongHopDiemTinChiTichLuy_XetTotNghiep() As DataTable
            Doc_tham_so_he_thong()
            Doc_thamso_hethong()
            Dim clsDAL As New Diem_DataAccess
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_diem10 As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double, So_hoc_trinh As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("TBCHT10", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Nam_thu", GetType(Integer))
            dtTongHop.Columns.Add("LyDo_no_mon", GetType(String))
            dtTongHop.Columns.Add("LyDo_mon_batbuoc", GetType(String))
            dtTongHop.Columns.Add("LyDo_TBCHT_TL", GetType(String))
            dtTongHop.Columns.Add("So_tinchi_tichluy", GetType(String))
            dtTongHop.Columns.Add("HaBac_TotNghiep", GetType(String))
            dtTongHop.Columns.Add("PhanTram_ThiLai", GetType(Double))

            Dim LyDo_no_mon As String = ""
            Dim LyDo_mon_batbuoc As String = ""
            Dim ID_dt As Integer
            Dim So_hoc_trinh_all As Double = 0

            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Dim TBCMH As Double = 0
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                If dr("ID_sv") = 157210 Then
                    dr("ID_sv") = 157210
                End If
                'TBCMH = 0
                So_hoc_trinh_all = 0
                LyDo_no_mon = ""
                LyDo_mon_batbuoc = ""
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                ID_dt = dr.Item("ID_dt")
                Dim So_TC_ThiLai As Double = 0

                Dim clsXetTN As New DanhSachTotNghiep_DataAccess
                Dim dt_LyDo_mon_batbuoc As DataTable = clsXetTN.Check_MonBatBuoc_SV(dr("ID_SV"), mID_dv, 0, ID_dt)
                For j As Integer = 0 To dt_LyDo_mon_batbuoc.Rows.Count - 1
                    If LyDo_mon_batbuoc.Trim = "" Then
                        LyDo_mon_batbuoc = dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu").ToString.Trim
                    ElseIf dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu").ToString.Trim <> "" Then
                        LyDo_mon_batbuoc += ", " & dt_LyDo_mon_batbuoc.Rows(j).Item("Ky_hieu")
                    End If
                Next
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx_Diem_Max(dr("ID_sv"), ID_mon)

                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                        ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                            'TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            ''Tính điểm tích luỹ
                            'If dsDiemQuyDoi.TichLuy(Diem_chu) Then

                            '    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                            '    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                            '        'Tính số tín chỉ tích luỹ
                            '        If Diem_so > 0 Then
                            '            Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            '            So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                            '            Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            '            Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            '        End If
                            '    End If
                            'Else
                            '    So_lan = So_lan + 1
                            'End If
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                            If ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) = "F" Then So_TC_ThiLai += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            So_hoc_trinh_all = So_hoc_trinh_all + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            'Tính điểm tích luỹ
                            If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                'Tính số tín chỉ tích luỹ
                                If Diem_so > 0 Then
                                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_diem10 += Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                End If
                            Else
                                If Diem_so <= 0 And Diem_chu <= "F" Then
                                    If LyDo_no_mon.Trim = "" Then
                                        LyDo_no_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Diem_chu 'Nếu điểm F,I,X -> Nợ môn
                                    Else
                                        LyDo_no_mon += ", " & dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu & ":" & Diem_chu 'Nếu điểm F,I,X -> Nợ môn
                                    End If
                                End If
                            End If
                        End If
                    End If

                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, 2)
                    Tong_diem10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, 2)
                    dr("LyDo_no_mon") = LyDo_no_mon
                    dr("LyDo_mon_batbuoc") = LyDo_mon_batbuoc
                    If TBCHT < 2 Then dr("LyDo_TBCHT_TL") = "TBCHT tích luỹ <2"
                    dr("TBCHT") = TBCHT
                    dr("TBCHT10") = Tong_diem10
                    dr("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh)
                    dr("So_hoc_trinh") = So_hoc_trinh

                    'Check so tin chi tich luy so voi chuong trinh dao tao
                    Dim cls As New ChuongTrinhDaoTao_Bussines(ID_dt)
                    Dim dt_dt As DataTable = cls.DanhSachChuongTrinhDaoTao()
                    dt_dt.DefaultView.RowFilter = "ID_dt=" & ID_dt
                    Dim So_tc_YC As Integer = 0
                    If dt_dt.DefaultView.Count > 0 And Not IsDBNull(dt_dt.DefaultView.Item(0)("So_hoc_trinh")) Then So_tc_YC = dt_dt.DefaultView.Item(0)("So_hoc_trinh")
                    If So_hoc_trinh < So_tc_YC Then dr("So_tinchi_tichluy") = "Phải tích luỹ >=" & So_tc_YC & " tín chỉ, mới được " & So_hoc_trinh & " TC"


                    'Hạ một mức tốt nghiệp cho loại Xuất sắc và Giỏi nếu dơi vào 
                    'Nếu bị kỷ luật trên mức cảnh cáo
                    'Nếu bị thi lại quá số % cho phép so với số tín chỉ tích luỹ
                    If So_hoc_trinh_all <> 0 Then
                        So_TC_ThiLai = Math.Round(So_TC_ThiLai * 100 / So_hoc_trinh_all, LamTron_Diem_TongHop)
                    Else
                        So_TC_ThiLai = 0
                    End If
                    If So_TC_ThiLai > PtramTCithilai_hatotnghiep Or clsDAL.CheckMucKyLuat_HaLoaiTotNghiep(dr.Item("ID_SV"), MucXuLy_KyLuat_HaLoaiTotNghiep) Then
                        dr("Xep_loai") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCHT, True)
                        dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, True)
                        If So_TC_ThiLai > PtramTCithilai_hatotnghiep Then
                            dr("HaBac_TotNghiep") = "Hạ bậc tốt nghiệp do số tín chỉ thi lại vượt quá số cho phép"
                        Else
                            dr("HaBac_TotNghiep") = "Vi phạm kỷ luật từ cảnh cáo trở lên"
                        End If
                        dr("PhanTram_ThiLai") = So_TC_ThiLai
                    Else
                        dr("Xep_loai") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCHT, False)
                        dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                        dr("PhanTram_ThiLai") = So_TC_ThiLai
                    End If
                Else
                    dr("LyDo_TBCHT_TL") = "Chưa có TBCHT tích luỹ"
                    dr("TBCHT") = 0
                    dr("ID_xep_loai") = 0
                    dr("Xep_loai") = ""
                    dr("So_hoc_trinh") = 0
                End If
            Next
            Return dtTongHop
        End Function
        Public Function BangTongKetDiemSinhVien_TotNghiep(ByVal ID_sv As Integer) As DataTable
            Doc_thamso_hethong()
            Dim dtTongKet As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Diem_chu As String
            Dim Tong_diem, TBC_tich_luy As Double
            Dim So_mon_hoc_lai, So_mon_thi_lai, So_mon_cho_diem, So_hoc_trinh_tich_luy As Integer
            dtTongKet.Columns.Add("ID_xep_hang_hoc_luc", GetType(Integer))
            dtTongKet.Columns.Add("Xep_hang_hoc_luc", GetType(String))
            dtTongKet.Columns.Add("TBC_tich_luy", GetType(Double))
            dtTongKet.Columns.Add("So_hoc_trinh_tich_luy", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_cho_diem", GetType(Integer))
            dtTongKet.Columns.Add("Nam_thu", GetType(Integer))
            Dim dr As DataRow = dtTongKet.NewRow
            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi)
                        'Tính điểm tích luỹ
                        If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                            'Tính số tín chỉ tích luỹ
                            Tong_diem += ESSDiem.dsDiemThi.Diem_so_max * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            So_hoc_trinh_tich_luy += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        End If
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                        If ESSDiem.Thi_lai_SauLan1(ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi, 2) Then So_mon_thi_lai += 1
                        If ESSDiem.dsDiemThi.TBCMH_max = -1 Or _
                           ESSDiem.dsDiemThi.Diem_chu_max(0, "") = "X" Or _
                           ESSDiem.dsDiemThi.Diem_chu_max(0, "") = "I" Then
                            So_mon_cho_diem += 1
                        End If
                    End If
                Else
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                End If
            Next
            'Tính điểm TBCHT và xếp loại
            If So_hoc_trinh_tich_luy > 0 Then
                TBC_tich_luy = Math.Round(Tong_diem / So_hoc_trinh_tich_luy, LamTron_Diem_TongHop)
                dr("TBC_tich_luy") = TBC_tich_luy
                dr("ID_xep_hang_hoc_luc") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBC_tich_luy, False)
                dr("Xep_hang_hoc_luc") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBC_tich_luy, False)
                dr("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh_tich_luy)
                dr("So_hoc_trinh_tich_luy") = So_hoc_trinh_tich_luy
            Else
                dr("TBC_tich_luy") = 0
                dr("ID_xep_hang_hoc_luc") = 0
                dr("Xep_hang_hoc_luc") = -1
                dr("Nam_thu") = 1
                dr("So_hoc_trinh_tich_luy") = 0
            End If
            dr("So_mon_hoc_lai") = So_mon_hoc_lai
            dr("So_mon_thi_lai") = So_mon_thi_lai
            dr("So_mon_cho_diem") = So_mon_cho_diem
            dtTongKet.Rows.Add(dr)
            Return dtTongKet
        End Function

        Public Function BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_Hoc As String) As DataTable
            Dim clsDAL As New Diem_DataAccess
            Doc_thamso_hethong()
            Dim dtTongKet As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem4, Tong_diem10, Tong_diem_TL As Double, Tong_so_hoc_trinh As Integer
            Dim So_mon_hoc_lai, So_mon_thi_lai, So_mon_cho_diem, So_hoc_trinh_tich_luy As Integer
            Dim TBCHT4, TBCTL, TBCHT10, TBCMH, Diem_so As Double


            dtTongKet.Columns.Add("ID_xep_hang_hoc_luc", GetType(Integer))
            dtTongKet.Columns.Add("Xep_hang_hoc_luc", GetType(String))
            dtTongKet.Columns.Add("Xep_hang_hoc_tap", GetType(String))
            dtTongKet.Columns.Add("TBC_tich_luy", GetType(Double))
            dtTongKet.Columns.Add("So_hoc_trinh_tich_luy", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_cho_diem", GetType(Integer))
            dtTongKet.Columns.Add("Nam_thu", GetType(Integer))

            dtTongKet.Columns.Add("TBCHT10", GetType(Double))
            dtTongKet.Columns.Add("TBCHT4", GetType(Double))
            dtTongKet.Columns.Add("Xep_loai_TN", GetType(String))
            dtTongKet.Columns.Add("Xep_loai_TN_En", GetType(String))
            Dim dr As DataRow = dtTongKet.NewRow
            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx_Diem_Max(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        'Toan khoa - Bang ESSDiem tam thoi
                        If Hoc_ky = 0 And Nam_Hoc = "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                Diem_so = ESSDiem.dsDiemThi.Diem_so_max_TongHop
                                TBCMH = ESSDiem.dsDiemThi.TBCMH_max_TongHop

                                If Diem_so >= 0 Then 'Hoc tap hoc ky
                                    Tong_diem4 += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                If Diem_so > 0 Then 'Tich luy
                                    Tong_diem_TL += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    So_hoc_trinh_tich_luy += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If

                                If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                                If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_Hoc, 2) Then So_mon_thi_lai += 1
                                If ESSDiem.dsDiemThi.TBCMH_max = -1 Or _
                                   ESSDiem.dsDiemThi.Diem_chu_max(0, "") = "X" Or _
                                   ESSDiem.dsDiemThi.Diem_chu_max(0, "") = "I" Then
                                    So_mon_cho_diem += 1
                                End If
                            End If
                        End If

                        'Bang ESSDiem theo nam hoc
                        If Hoc_ky = 0 And Nam_Hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                If ESSDiem.Nam_hoc = Nam_Hoc Then
                                    'Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max()
                                    Diem_so = ESSDiem.dsDiemThi.Diem_so_max
                                    TBCMH = ESSDiem.dsDiemThi.TBCMH_max

                                    If Diem_so >= 0 Then 'Hoc tap hoc ky
                                        Tong_diem4 += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    If Diem_so > 0 Then 'Tich luy
                                        Tong_diem_TL += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_hoc_trinh_tich_luy += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If

                                    If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                                    If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_Hoc, 2) Then So_mon_thi_lai += 1
                                    If ESSDiem.dsDiemThi.TBCMH_max = -1 Or _
                                       ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_Hoc) = "X" Or _
                                       ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_Hoc) = "I" Then
                                        So_mon_cho_diem += 1
                                    End If
                                End If
                            End If
                        End If

                        'Bang ESSDiem theo Ky
                        If Hoc_ky > 0 And Nam_Hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                If ESSDiem.Hoc_ky = Hoc_ky And ESSDiem.Nam_hoc = Nam_Hoc Then
                                    'Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max()
                                    Diem_so = ESSDiem.dsDiemThi.Diem_so_max
                                    TBCMH = ESSDiem.dsDiemThi.TBCMH_max

                                    If Diem_so >= 0 Then 'Hoc tap hoc ky
                                        Tong_diem4 += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    If Diem_so > 0 Then 'Tich luy
                                        Tong_diem_TL += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_hoc_trinh_tich_luy += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If

                                    If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                                    If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_Hoc, 2) Then So_mon_thi_lai += 1
                                    If ESSDiem.dsDiemThi.TBCMH_max = -1 Or _
                                       ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_Hoc) = "X" Or _
                                       ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_Hoc) = "I" Then
                                        So_mon_cho_diem += 1
                                    End If
                                End If
                            End If
                        End If
                    End If
                Else
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                End If
            Next
            'Tính điểm TBCHT và xếp loại
            If Tong_so_hoc_trinh > 0 Then
                TBCHT4 = Math.Round(Tong_diem4 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                dr("TBCHT10") = TBCHT10
                dr("TBCHT4") = TBCHT4
            Else
                TBCHT4 = 0
                TBCHT10 = 0
            End If

            If So_hoc_trinh_tich_luy > 0 Then
                TBCTL = Math.Round(Tong_diem_TL / So_hoc_trinh_tich_luy, LamTron_Diem_TongHop)
                dr("TBC_tich_luy") = TBCTL
                dr("ID_xep_hang_hoc_luc") = dsXepHangHocLuc.IDXepHangHocLuc(TBCTL)
                dr("Xep_hang_hoc_luc") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCTL)
                dr("Xep_hang_hoc_tap") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCTL)
                'dr("Xep_hang_hoc_tap") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT10)
                dr("Xep_loai_TN") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCTL, False)
                dr("Xep_loai_TN_En") = dsXepHangTotNghiep.XepHangTotNghiep_En(TBCTL, False)
                dr("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh_tich_luy)
                dr("So_hoc_trinh_tich_luy") = So_hoc_trinh_tich_luy
            Else
                dr("TBC_tich_luy") = 0
                dr("ID_xep_hang_hoc_luc") = 0
                dr("Xep_hang_hoc_luc") = -1
                dr("Xep_hang_hoc_tap") = ""
                dr("Xep_loai_TN") = -1
                dr("Nam_thu") = 1
                dr("So_hoc_trinh_tich_luy") = 0
            End If
            dr("So_mon_hoc_lai") = So_mon_hoc_lai
            dr("So_mon_thi_lai") = So_mon_thi_lai
            dr("So_mon_cho_diem") = So_mon_cho_diem
            dtTongKet.Rows.Add(dr)
            Return dtTongKet
        End Function
        Private Sub HienThi_ESSDiem_ThanhPhan(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_mon_tc As Integer, ByVal ID_lop_tc As Integer)
            Dim clsDAL As New Diem_DataAccess
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            'Lấy dữ liệu điểm thành phần và điểm thi
            If ID_mon_tc = 0 And ID_lop_tc = 0 Then 'ESSLop hanh chinh
                dtDiem = clsDAL.HienThi_ESSKhongDuDKDuThiDiemTP_DanhSach(ID_dv, Hoc_ky, Nam_hoc, ID_mon)
            Else 'ESSLop tin chi
                dtDiem = clsDAL.HienThi_ESSDiem_TongHopTinChi_DanhSach(ID_dv, Hoc_ky, Nam_hoc, ID_mon, ID_lop_tc, ID_mon_tc)
            End If

            For i As Integer = 0 To dtDiem.Rows.Count - 1
                Dim objDiem As New ESSDiem
                objDiem.ID_mon = dtDiem.Rows(i).Item("ID_mon")
                objDiem.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                objDiem.dsDiemThanhPhan.Diem = dtDiem.Rows(i).Item("Diem")
                objDiem.dsDiemThanhPhan.Ty_le = dtDiem.Rows(i).Item("Ty_le")
                objDiem.Hoc_ky = dtDiem.Rows(i).Item("Hoc_ky")
                objDiem.Nam_hoc = dtDiem.Rows(i).Item("Nam_hoc")
                arrDiem.Add(objDiem)
            Next
        End Sub
        Public Function DanhSachKhongDuDieuKienDuThi(ByVal ID_mon As Integer, ByVal MucDiem_Tran As Double, ByVal dt_DaNo As DataTable) As DataTable
            Doc_tham_so_he_thong()
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))
            'Gán dữ liệu vào bảng danh sách sinh viên
            Dim TBCMTP As Double
            Dim TP As Integer

            For j As Integer = 0 To dtDiem.Rows.Count - 1
                Dim row As DataRow = dt.NewRow()
                TBCMTP = 0
                TP = 0
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                'Dim f As Boolean = False
                Dim idx As Integer = Tim_idx(dtDiem.Rows(j).Item("ID_sv"), ID_mon)
                If idx < 0 Then Continue For
                Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                'For i As Integer = 0 To arrDiem.Count - 1
                '    If CType(arrDiem(i), ESSDiem).ID_sv = dtDiem.Rows(j).Item("ID_SV") And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                '        f = True
                '        TBCMTP += CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Diem * CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Ty_le
                '        TP += CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Ty_le
                '        Hoc_ky = CType(arrDiem(i), ESSDiem).Hoc_ky
                '        Nam_hoc = CType(arrDiem(i), ESSDiem).Nam_hoc
                '    End If
                'Next
                If TP = 0 Then TP = 1
                TBCMTP = Math.Round(TBCMTP / TP, 2)
                dt_DaNo.DefaultView.Sort = "ID_sv"
                Dim DiemBoPhan_KhongDat As Boolean = False
                Dim ChuyenCan_KhongDat As Boolean = False
                Dim ID_thanh_phan As Integer = 0
                Dim idx1 As Integer = 0
                Dim TBCBP As Double = 0
                Dim TyLe As Integer = 0
                Dim str As String = ""
                Dim CoDiem As Boolean = False

                For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                    If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                        ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                        'Tìm thành phần điểm theo ID_thanh_phan
                        idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, Hoc_ky, Nam_hoc)
                        'Lấy điểm thành phần theo ID_thanh_phan
                        If idx1 >= 0 Then
                            CoDiem = True
                            If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False Then
                                TBCBP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                TyLe += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                If Diem_kiem_tra_bo_phan_dat_Active AndAlso objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem < Diem_kiem_tra_bo_phan_dat Then DiemBoPhan_KhongDat = True
                                If str = "" Then
                                    str = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem & "*" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                Else
                                    str += "+" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem & "*" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).He_so
                                End If
                            ElseIf (Diem_chuyen_can_dat_Active AndAlso objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem < Diem_chuyen_can_dat) Then
                                ChuyenCan_KhongDat = True
                            End If
                        End If
                    End If
                Next

                If TyLe > 0 Then TBCBP = Math.Round(TBCBP / TyLe, 1)

                Dim LyDo As String = ""
                If QuyCheTinChi_CHUNG = 1 Then ' AP DUNG CHO HVCS
                    If (Diem_kiem_tra_bo_phan_dat_Active AndAlso DiemBoPhan_KhongDat) Then LyDo = "Điểm kiểm tra bộ phận không đạt: " & TBCBP & " chi tiết: " & str
                Else ' ÁP DỤNG CHO CÁC TRƯỜNG
                    If (Diem_kiem_tra_bo_phan_dat_Active AndAlso TBCBP < Diem_kiem_tra_bo_phan_dat) Then LyDo = "Điểm kiểm tra bộ phận không đạt: " & TBCBP & " chi tiết: " & str
                End If
                If ChuyenCan_KhongDat Then
                    If LyDo = "" Then
                        LyDo = "Điểm chuyên cần không đạt"
                    Else
                        LyDo = "1.Điểm chuyên cần không đạt - 2." & LyDo
                    End If
                End If

                dt_DaNo.DefaultView.Sort = "ID_SV"
                If dt_DaNo.DefaultView.Find(dtDiem.Rows(j).Item("ID_SV")) < 0 AndAlso CoDiem And LyDo <> "" Then
                    row("Chon") = False
                    row("ID_SV") = dtDiem.Rows(j).Item("ID_SV")
                    row("Ma_sv") = dtDiem.Rows(j).Item("Ma_sv")
                    row("Ho_ten") = dtDiem.Rows(j).Item("Ho_ten")
                    row("Ngay_sinh") = dtDiem.Rows(j).Item("Ngay_sinh")
                    row("Ten_lop") = dtDiem.Rows(j).Item("Ten_lop")
                    row("ID_mon") = ID_mon
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    row("Ly_do") = LyDo
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = "Ly_do<>''"
            Return dt


        End Function





        ' Bảng điểm tổng kết điểm sinh viên theo kỳ (Dùng load hồ sơ sinh viên)
        Public Function BangTongKetDiemSinhVien(ByVal ID_sv As Integer, ByVal Ky_thu As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Doc_thamso_hethong()
            Dim dtTongKet As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Diem_chu As String
            Dim Tong_diem, TBC_tich_luy As Double
            Dim So_mon_hoc_lai, So_mon_thi_lai, So_mon_cho_diem, So_hoc_trinh_tich_luy As Integer
            dtTongKet.Columns.Add("ID_xep_hang_hoc_luc", GetType(Integer))
            dtTongKet.Columns.Add("Xep_hang_hoc_luc", GetType(String))
            dtTongKet.Columns.Add("TBC_tich_luy", GetType(Double))
            dtTongKet.Columns.Add("So_hoc_trinh_tich_luy", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongKet.Columns.Add("So_mon_cho_diem", GetType(Integer))
            dtTongKet.Columns.Add("Nam_thu", GetType(Integer))
            Dim dr As DataRow = dtTongKet.NewRow
            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False And dsMonHoc.Ky_thu <= Ky_thu Then ' Tính đến kỳ được chọn
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                        'Tính điểm tích luỹ
                        If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                            'Tính số tín chỉ tích luỹ
                            Tong_diem += ESSDiem.dsDiemThi.Diem_so_max * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            So_hoc_trinh_tich_luy += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        End If
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                        If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, 2) Then So_mon_thi_lai += 1
                        If ESSDiem.dsDiemThi.TBCMH_max = -1 Or _
                           ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "X" Or _
                           ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc) = "I" Then
                            So_mon_cho_diem += 1
                        End If
                    End If
                End If
            Next
            'Tính điểm TBCHT và xếp loại
            If So_hoc_trinh_tich_luy > 0 Then
                TBC_tich_luy = Math.Round(Tong_diem / So_hoc_trinh_tich_luy, LamTron_Diem_TongHop)
                dr("TBC_tich_luy") = TBC_tich_luy
                dr("ID_xep_hang_hoc_luc") = dsXepHangHocLuc.IDXepHangHocLuc(TBC_tich_luy)
                dr("Xep_hang_hoc_luc") = dsXepHangHocLuc.ESSXepHangHocLuc(TBC_tich_luy)
                dr("Nam_thu") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_hoc_trinh_tich_luy)
                dr("So_hoc_trinh_tich_luy") = So_hoc_trinh_tich_luy
            Else
                dr("TBC_tich_luy") = 0
                dr("ID_xep_hang_hoc_luc") = 0
                dr("Xep_hang_hoc_luc") = -1
                dr("Nam_thu") = 1
                dr("So_hoc_trinh_tich_luy") = 0
            End If
            dr("So_mon_hoc_lai") = So_mon_hoc_lai
            dr("So_mon_thi_lai") = So_mon_thi_lai
            dr("So_mon_cho_diem") = So_mon_cho_diem
            dtTongKet.Rows.Add(dr)
            Return dtTongKet
        End Function
        Public Function BangDiemSinhVien_CacMon_Full(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Doc_thamso_hethong()
                Dim dtBangDiem As New DataTable
                Dim idx_diem As Integer, ID_mon As Integer
                Dim Diem_chu As String
                dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
                dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
                dtBangDiem.Columns.Add("Ten_mon", GetType(String))
                dtBangDiem.Columns.Add("So_hoc_trinh", GetType(Integer))
                dtBangDiem.Columns.Add("TBCMH1", GetType(Double))
                dtBangDiem.Columns.Add("TBCMH_2Lan", GetType(String))
                dtBangDiem.Columns.Add("TBCMH_2Lan_DiemChu", GetType(String))
                dtBangDiem.Columns.Add("TBCMH", GetType(Double))
                dtBangDiem.Columns.Add("Diem_chu", GetType(String))
                dtBangDiem.Columns.Add("Hoc_lai", GetType(Boolean))
                dtBangDiem.Columns.Add("Tich_luy", GetType(Boolean))
                Doc_tham_so_he_thong()
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx_Diem_Max(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    dtBangDiem.DefaultView.Sort = "ID_mon"
                    If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                        'Toan khoa - Bang ESSDiem tam thoi
                        If Hoc_ky = 0 And Nam_hoc = "" Then
                            If ID_mon = 835 Then
                                ID_mon = 835
                            End If
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                            Dim dr As DataRow = dtBangDiem.NewRow
                            dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                            dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                            dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                            dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lanthu(1) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            'dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                            'dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                            'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                            'dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) <> Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                            'dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) <> Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))

                            dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                            dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_chu_max_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop)
                            dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))


                            dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            dr("Diem_chu") = Diem_chu
                            dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                            dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                            'Add môn học vào bảng điểm
                            dtBangDiem.Rows.Add(dr)
                        End If
                        'Bang ESSDiem theo nam hoc
                        If Hoc_ky = 0 And Nam_hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Nam_hoc = Nam_hoc Then
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                Dim dr As DataRow = dtBangDiem.NewRow
                                dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                'dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))


                                dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                dr("Diem_chu") = Diem_chu
                                dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                                dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                                'Add môn học vào bảng điểm
                                dtBangDiem.Rows.Add(dr)
                            End If
                        End If
                        'Bang ESSDiem theo ky
                        If Hoc_ky <> 0 And Nam_hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Nam_hoc = Nam_hoc And ESSDiem.Hoc_ky = Hoc_ky Then
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                Dim dr As DataRow = dtBangDiem.NewRow
                                dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                                dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                dr("Diem_chu") = Diem_chu
                                dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                                dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                                'Add môn học vào bảng điểm
                                dtBangDiem.Rows.Add(dr)
                            End If
                        End If
                    End If
                Next
                dtBangDiem.DefaultView.AllowDelete = False
                dtBangDiem.DefaultView.AllowEdit = False
                dtBangDiem.DefaultView.AllowNew = False
                Return dtBangDiem
            Catch ex As Exception
            End Try
        End Function
        Public Function BangDiemSinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Doc_thamso_hethong()
                Dim dtBangDiem As New DataTable
                Dim idx_diem As Integer, ID_mon As Integer
                Dim Diem_chu As String
                dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
                dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
                dtBangDiem.Columns.Add("Ten_mon", GetType(String))
                dtBangDiem.Columns.Add("So_hoc_trinh", GetType(Integer))
                dtBangDiem.Columns.Add("TBCMH1", GetType(Double))
                dtBangDiem.Columns.Add("TBCMH_2Lan", GetType(String))
                dtBangDiem.Columns.Add("TBCMH_2Lan_DiemChu", GetType(String))
                dtBangDiem.Columns.Add("TBCMH", GetType(Double))
                dtBangDiem.Columns.Add("Diem_chu", GetType(String))
                dtBangDiem.Columns.Add("Hoc_lai", GetType(Boolean))
                dtBangDiem.Columns.Add("Tich_luy", GetType(Boolean))
                Doc_tham_so_he_thong()
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx_Diem_Max(ID_sv, ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        dtBangDiem.DefaultView.Sort = "ID_mon"
                        If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                            'Toan khoa - Bang ESSDiem tam thoi
                            If Hoc_ky = 0 And Nam_hoc = "" Then
                                If ID_mon = 835 Then
                                    ID_mon = 835
                                End If
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                                Dim dr As DataRow = dtBangDiem.NewRow
                                dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lanthu(1) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                'dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) <> Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                'dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) <> Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))

                                dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_chu_max_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop)
                                dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))


                                dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                dr("Diem_chu") = Diem_chu
                                dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                                dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                                'Add môn học vào bảng điểm
                                dtBangDiem.Rows.Add(dr)
                            End If
                            'Bang ESSDiem theo nam hoc
                            If Hoc_ky = 0 And Nam_hoc <> "" Then
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                If ESSDiem.Nam_hoc = Nam_hoc Then
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                    Dim dr As DataRow = dtBangDiem.NewRow
                                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                    dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                    dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                                    'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                    'dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    'dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))


                                    dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    dr("Diem_chu") = Diem_chu
                                    dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                                    dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                                    'Add môn học vào bảng điểm
                                    dtBangDiem.Rows.Add(dr)
                                End If
                            End If
                            'Bang ESSDiem theo ky
                            If Hoc_ky <> 0 And Nam_hoc <> "" Then
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                If ESSDiem.Nam_hoc = Nam_hoc And ESSDiem.Hoc_ky = Hoc_ky Then
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                    Dim dr As DataRow = dtBangDiem.NewRow
                                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                    dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))

                                    dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    dr("Diem_chu") = Diem_chu
                                    dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                                    dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                                    'Add môn học vào bảng điểm
                                    dtBangDiem.Rows.Add(dr)
                                End If
                            End If

                        End If
                    End If
                Next
                dtBangDiem.DefaultView.AllowDelete = False
                dtBangDiem.DefaultView.AllowEdit = False
                dtBangDiem.DefaultView.AllowNew = False
                Return dtBangDiem
            Catch ex As Exception
            End Try
        End Function

        Public Function BangDiemSinhVienFull(ByVal ID_sv As Integer) As DataTable
            Doc_thamso_hethong()
            Dim dtBangDiem As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Diem_chu As String
            dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
            dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
            dtBangDiem.Columns.Add("Ten_mon", GetType(String))
            dtBangDiem.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtBangDiem.Columns.Add("TBCMH1", GetType(Double))
            dtBangDiem.Columns.Add("TBCMH", GetType(Double))
            dtBangDiem.Columns.Add("Diem_chu", GetType(String))
            dtBangDiem.Columns.Add("Hoc_lai", GetType(Boolean))
            dtBangDiem.Columns.Add("Tich_luy", GetType(Boolean))
            Doc_tham_so_he_thong()
            For i As Integer = 0 To dsMonHoc.Count - 1
                ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                'Tim ESSDiem cua sinh vien nay
                idx_diem = Tim_idx(ID_sv, ID_mon)
                'Nếu sinh viên có điểm môn học này thì tính điểm
                dtBangDiem.DefaultView.Sort = "ID_mon"
                If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                    Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                    Dim dr As DataRow = dtBangDiem.NewRow
                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                    dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                    dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                    dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                    dr("Diem_chu") = Diem_chu
                    dr("Hoc_lai") = ESSDiem.Hoc_lai(So_lan_thi_lai)
                    dr("Tich_luy") = dsDiemQuyDoi.TichLuy(Diem_chu)
                    'Add môn học vào bảng điểm
                    dtBangDiem.Rows.Add(dr)
                End If
            Next
            dtBangDiem.DefaultView.AllowDelete = False
            dtBangDiem.DefaultView.AllowEdit = False
            dtBangDiem.DefaultView.AllowNew = False
            Return dtBangDiem
        End Function

        Public Function BangDiemSinhVienToanKhoa_TotNghiep(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtBangDiem As New DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Diem_chu As String
            Dim Tong_so_TC As Double
            Dim Tong_Diem As Double
            dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
            dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
            dtBangDiem.Columns.Add("Ten_mon", GetType(String))
            dtBangDiem.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtBangDiem.Columns.Add("TBCMH", GetType(String))
            dtBangDiem.Columns.Add("TBCMH_2Lan", GetType(String))
            dtBangDiem.Columns.Add("TBCMH4_2Lan", GetType(String))
            dtBangDiem.Columns.Add("TBCMH_2Lan_DiemChu", GetType(String))
            dtBangDiem.Columns.Add("TBCMH1", GetType(String))
            dtBangDiem.Columns.Add("Diem_chu", GetType(String))
            dtBangDiem.Columns.Add("Hoc_ky", GetType(String))
            dtBangDiem.Columns.Add("Nam_hoc", GetType(String))
            dtBangDiem.Columns.Add("Tong_so_TC", GetType(Double))
            dtBangDiem.Columns.Add("TBCHT_10", GetType(Double))
            dtBangDiem.Columns.Add("STT", GetType(String))
            Doc_tham_so_he_thong()
            Dim Dem As Integer = 0
            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx_Diem_Max(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    dtBangDiem.DefaultView.Sort = "ID_mon"
                    If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                        ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                            Dem = Dem + 1
                            'Toan khoa - Bang ESSDiem tam thoi
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                            Dim dr As DataRow = dtBangDiem.NewRow
                            dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                            dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                            dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                            dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            Tong_so_TC = Tong_so_TC + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            Tong_Diem = Tong_Diem + Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop, CType(Lam_tron_TBCMH, Integer))
                            'dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                            'dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))
                            'dr("TBCMH4_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_so_max(), ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))
                            dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop > ESSDiem.dsDiemThi.TBCMH_min_TongHop, Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                            dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop > ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_chu_max_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop)
                            dr("TBCMH4_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop > ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_so_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_so_max_TongHop, ESSDiem.dsDiemThi.Diem_so_min_TongHop)
                            dr("Hoc_ky") = ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi
                            dr("Nam_hoc") = ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi
                            If ESSDiem.dsDiemThi.TBCMH_max_TongHop >= 0 Then dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            dr("Diem_chu") = Diem_chu
                            dr("STT") = Dem
                            dtBangDiem.Rows.Add(dr)
                        End If
                    End If
                End If
            Next
            If dtBangDiem.DefaultView.Count > 0 AndAlso Tong_so_TC > 0 Then
                dtBangDiem.Rows(0)("TBCHT_10") = Math.Round(Tong_Diem / Tong_so_TC, 2)
                dtBangDiem.Rows(0)("Tong_so_TC") = Tong_so_TC
            End If
            dtBangDiem.DefaultView.AllowDelete = False
            dtBangDiem.DefaultView.AllowEdit = False
            dtBangDiem.DefaultView.AllowNew = False
            Return dtBangDiem
        End Function

        Public Function BangDiemSinhVienToanKhoa(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim dtBangDiem As New DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Diem_chu As String
            dtBangDiem.Columns.Add("ID_mon", GetType(Integer))
            dtBangDiem.Columns.Add("Ky_hieu", GetType(String))
            dtBangDiem.Columns.Add("Ten_mon", GetType(String))
            dtBangDiem.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtBangDiem.Columns.Add("TBCMH", GetType(String))
            dtBangDiem.Columns.Add("TBCMH_2Lan", GetType(String))
            dtBangDiem.Columns.Add("TBCMH4_2Lan", GetType(String))
            dtBangDiem.Columns.Add("TBCMH_2Lan_DiemChu", GetType(String))
            dtBangDiem.Columns.Add("TBCMH1", GetType(String))
            dtBangDiem.Columns.Add("Diem_chu", GetType(String))
            dtBangDiem.Columns.Add("Hoc_ky", GetType(String))
            dtBangDiem.Columns.Add("Nam_hoc", GetType(String))
            dtBangDiem.Columns.Add("STT", GetType(String))
            Doc_tham_so_he_thong()

            For i As Integer = 0 To dsMonHoc.Count - 1
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx_Diem_Max(ID_sv, ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    dtBangDiem.DefaultView.Sort = "ID_mon"
                    If idx_diem >= 0 AndAlso dtBangDiem.DefaultView.Find(ID_mon) < 0 Then
                        'Toan khoa - Bang ESSDiem tam thoi
                        If ID_mon = 144 And ID_sv = 458131 Then
                            ID_mon = 144
                        End If
                        If Hoc_ky = 0 And Nam_hoc = "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                                Dim dr As DataRow = dtBangDiem.NewRow
                                dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                'dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, ESSDiem.dsDiemThi.ESSDiemThi(1).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(1).Nam_hoc_thi) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(1).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(1).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, ESSDiem.dsDiemThi.ESSDiemThi(1).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(1).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(1).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(1).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))

                                'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_chu_max_TongHop, ESSDiem.dsDiemThi.Diem_chu_min_TongHop)
                                dr("TBCMH4_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_max_TongHop <> ESSDiem.dsDiemThi.TBCMH_min_TongHop, ESSDiem.dsDiemThi.Diem_so_min_TongHop & "-" & ESSDiem.dsDiemThi.Diem_so_max_TongHop, ESSDiem.dsDiemThi.Diem_so_min_TongHop)
                                dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_min_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))

                                dr("Hoc_ky") = ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi
                                dr("Nam_hoc") = ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi
                                If ESSDiem.dsDiemThi.TBCMH_max_TongHop >= 0 Then dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max_TongHop, CType(Lam_tron_TBCMH, Integer))
                                dr("Diem_chu") = Diem_chu
                                'Add môn học vào bảng điểm
                                dtBangDiem.Rows.Add(dr)
                            End If
                        End If

                        'Bang ESSDiem theo nam hoc
                        If Hoc_ky = 0 And Nam_hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                If ESSDiem.Nam_hoc = Nam_hoc Then
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                                    Dim dr As DataRow = dtBangDiem.NewRow

                                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                    dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    'dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                    'dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    'dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi))

                                    dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi), CType(Lam_tron_TBCMH, Integer))
                                    dr("TBCMH_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    dr("TBCMH_2Lan_DiemChu") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_chu_max(0, ""), ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))
                                    dr("TBCMH4_2Lan") = IIf(Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) > Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer)), ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi) & "-" & ESSDiem.dsDiemThi.Diem_so_max(), ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi, ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi))
                                    dr("Hoc_ky") = ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi
                                    dr("Nam_hoc") = ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi
                                    If ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) >= 0 Then dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                                    dr("Diem_chu") = Diem_chu
                                    'Add môn học vào bảng điểm
                                    dtBangDiem.Rows.Add(dr)
                                End If
                            End If
                        End If

                        'Bang ESSDiem theo ky
                        If Hoc_ky <> 0 And Nam_hoc <> "" Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                If ESSDiem.Nam_hoc = Nam_hoc And ESSDiem.Hoc_ky = Hoc_ky Then
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                    Dim dr As DataRow = dtBangDiem.NewRow

                                    dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                                    dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr("TBCMH1") = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                                    dr("TBCMH_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)) & "-" & Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)), Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer)))
                                    dr("TBCMH_2Lan_DiemChu") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_chu_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc))
                                    dr("TBCMH4_2Lan") = IIf(ESSDiem.dsDiemThi.TBCMH_lan(2, Hoc_ky, Nam_hoc) > 0, ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc) & "-" & ESSDiem.dsDiemThi.Diem_so_lan(2, Hoc_ky, Nam_hoc), ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc))

                                    dr("Hoc_ky") = ESSDiem.dsDiemThi.ESSDiemThi(0).Hoc_ky_thi
                                    dr("Nam_hoc") = ESSDiem.dsDiemThi.ESSDiemThi(0).Nam_hoc_thi
                                    If ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc) >= 0 Then dr("TBCMH") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max(Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                                    dr("Diem_chu") = Diem_chu
                                    'Add môn học vào bảng điểm
                                    dtBangDiem.Rows.Add(dr)
                                End If
                            End If
                        End If
                    End If
                End If
            Next
            dtBangDiem.DefaultView.AllowDelete = False
            dtBangDiem.DefaultView.AllowEdit = False
            dtBangDiem.DefaultView.AllowNew = False
            Return dtBangDiem
        End Function
        Private Function DiemHienThiTinChi(ByVal ESSDiem As ESSDiem) As String
            Dim Diem_hien_thi As String = ""
            For Lan_thi As Integer = 0 To ESSDiem.dsDiemThi.Count - 1
                Diem_hien_thi += ESSDiem.dsDiemThi.Diem_chu_lan(Lan_thi, ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi).ToString + "-"
            Next
            If Diem_hien_thi <> "" Then Diem_hien_thi = Left(Diem_hien_thi, Len(Diem_hien_thi) - 1)
            Return Diem_hien_thi
        End Function
        Public Function Tim_idx(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        'Public Function Tim_idx_ky(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
        '    For i As Integer = 0 To arrDiem.Count - 1
        '        If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
        '            Return i
        '        End If
        '    Next
        '    Return -1
        'End Function

        Public Function Tim_idx_TP_ky(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky_Thi As Integer, ByVal Nam_hoc_Thi As String) As Integer
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    If CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Tim_idx_diem_TP(CType(arrDiem(i), ESSDiem).ID_diem, Hoc_ky_Thi, Nam_hoc_Thi) Then
                        Return i
                    End If
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx_Thi_ky(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky_Thi As Integer, ByVal Nam_hoc_Thi As String, ByVal Lan_thi As Integer) As Integer
            'For i As Integer = 0 To arrDiem.Count - 1
            '    If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon And CType(arrDiem(i), ESSDiem).dsDiemThi.Hoc_ky_thi = Hoc_ky_Thi And CType(arrDiem(i), ESSDiem).dsDiemThi.Nam_hoc_thi = Nam_hoc_Thi Then
            '        Return i
            '    End If
            'Next
            'Return -1
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    If CType(arrDiem(i), ESSDiem).dsDiemThi.Tim_idx_diem_Thi(CType(arrDiem(i), ESSDiem).ID_diem, Hoc_ky_Thi, Nam_hoc_Thi, Lan_thi) Then
                        Return i
                    ElseIf CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Tim_idx_diem_TP(CType(arrDiem(i), ESSDiem).ID_diem, Hoc_ky_Thi, Nam_hoc_Thi) Then
                        Return i
                    End If
                End If
            Next
            Return -1
        End Function
        
        Public Function Tim_idx_Diem_Max(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Integer
            'Xac dinh Index cua diem cai thien, hoc lai thi lai
            Dim Diem_Max As Double = 0
            Dim mHoc_ky As Integer = 0
            Dim mNam_hoc As String = "2000-2001"
            Dim mHoc_ky_thi As Integer = 0
            Dim mNam_hoc_thi As String = "2000-2001"
            Dim ViTri As Integer = -1
            If ID_sv = 57581 And ID_mon = 4 Then
                ID_sv = 57581 And ID_mon = 4
            End If
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    If CType(arrDiem(i), ESSDiem).dsDiemThi.Diem_TBCMH_max_KyNam(mHoc_ky_thi, mNam_hoc_thi) = 0 Then
                        If mNam_hoc_thi = mNam_hoc Then
                            If mHoc_ky_thi > mHoc_ky Then
                                mHoc_ky = mHoc_ky_thi
                                mNam_hoc = mNam_hoc_thi
                                Diem_Max = CType(arrDiem(i), ESSDiem).dsDiemThi.TBCMH_max(mHoc_ky_thi, mNam_hoc_thi)
                                ViTri = i
                            ElseIf mHoc_ky_thi = mHoc_ky Then
                                mHoc_ky = mHoc_ky_thi
                                mNam_hoc = mNam_hoc_thi
                                If CType(arrDiem(i), ESSDiem).dsDiemThi.TBCMH_max(mHoc_ky_thi, mNam_hoc_thi) > Diem_Max Then
                                    Diem_Max = CType(arrDiem(i), ESSDiem).dsDiemThi.TBCMH_max(mHoc_ky_thi, mNam_hoc_thi)
                                    ViTri = i
                                End If
                            End If
                        ElseIf mNam_hoc_thi > mNam_hoc Then
                            mHoc_ky = mHoc_ky_thi
                            mNam_hoc = mNam_hoc_thi
                            Diem_Max = CType(arrDiem(i), ESSDiem).dsDiemThi.TBCMH_max(mHoc_ky_thi, mNam_hoc_thi)
                            ViTri = i
                        End If
                    End If
                End If
            Next
            Return ViTri
        End Function
        Public Function Tim_idx_MonChungChi(ByVal ID_mon As Integer, ByVal ID_dt As Integer, ByVal ID_chung_chi As Integer) As Integer
            Dim clsDAL As New Diem_DataAccess
            Dim dt As DataTable = clsDAL.LoaLoaiChungChi_DSMon(ID_dt, ID_chung_chi)
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("ID_mon") = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx(ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Sub LuuDiemThi(ByVal Lan_thi As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_Thi As String, ByVal dv As DataView)
            Try
                Doc_tham_so_he_thong()
                For i As Integer = 0 To arrDiem.Count - 1
                    Dim objDiem As New ESSDiem
                    Dim objDiemThi As New ESSDiemThi
                    Dim ID_diem, idx_diem_thi As Integer
                    objDiem = CType(arrDiem(i), ESSDiem)
                    dv.RowFilter = "ID_sv=" & objDiem.ID_sv
                    If dv.Count > 0 Then
                        'If objDiem.ID_sv = 3386 Then
                        '    objDiem.ID_sv = 3386
                        'End If
                        idx_diem_thi = objDiem.dsDiemThi.idx_diem_thi(Hoc_ky_thi, Nam_hoc_Thi, Lan_thi)
                        If idx_diem_thi >= 0 Then
                            objDiemThi = objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi)
                        Else
                            objDiemThi.Lan_thi = Lan_thi
                            objDiemThi.Diem_thi = -1
                        End If
                        'Nếu chưa có môn học này thì insert
                        If objDiem.ID_diem <= 0 Then
                            ID_diem = ThemMoi_ESSDiem(objDiem)
                            objDiem.ID_diem = ID_diem
                        Else
                            ID_diem = objDiem.ID_diem
                            CapNhat_ESSDiem(objDiem, ID_diem)
                        End If
                        'Nếu không có điểm thành phần và điểm thì thì xoá điểm môn học
                        If objDiem.dsDiemThanhPhan.Count = 0 And objDiem.dsDiemThi.Count = 0 Then
                            'Khong duoc xoa, vi no khoi tao theo ID_diem
                            'Xoa_ESSDiem(objDiem.ID_diem)
                        Else
                            'Quy đổi điểm chữ
                            Dim Diem_chu As String
                            Diem_chu = DiemChu(objDiem, Lan_thi, Hoc_ky_thi, Nam_hoc_Thi)

                            If Diem_chu = "X" Or Diem_chu = "I" Then
                                objDiemThi.Ghi_chu = Diem_chu
                                objDiemThi.Diem_chu = ""
                            ElseIf Diem_chu = "K" Then
                                objDiemThi.Ghi_chu = Diem_chu
                                objDiemThi.Diem_chu = "F"
                            Else
                                objDiemThi.Diem_chu = Diem_chu
                                If objDiemThi.Ghi_chu = "X" Or objDiemThi.Ghi_chu = "I" Then objDiemThi.Ghi_chu = ""
                            End If

                            'Tính điểm TBCMH
                            Dim TBCMH As Double = 0
                            If objDiemThi.Ghi_chu = "VC" Or objDiemThi.Ghi_chu = "B" Then
                                TBCMH = objDiemThi.Diem_thi
                            ElseIf objDiemThi.Ghi_chu = "K" Then
                                TBCMH = 0
                            ElseIf objDiemThi.Ghi_chu = "NC" Then
                                TBCMH = Math.Round(TinhTBCMH_CaiThien(objDiem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                                Diem_chu = dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
                                objDiemThi.Diem_chu = Diem_chu
                            ElseIf QuyCheTinChi_CHUNG = 1 Then
                                TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, Hoc_ky_thi, Nam_hoc_Thi), CType(Lam_tron_TBCMH, Integer))
                            Else
                                TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, Hoc_ky_thi, Nam_hoc_Thi), CType(Lam_tron_TBCMH, Integer))
                            End If
                            objDiemThi.TBCMH = TBCMH
                            objDiemThi.Hoc_ky_thi = Hoc_ky_thi
                            objDiemThi.Nam_hoc_thi = Nam_hoc_Thi
                            If objDiemThi.Diem_chu = "" And objDiemThi.Diem_thi = -1 And objDiemThi.Ghi_chu = "" Then
                                Xoa_ESSDiemThi(ID_diem, Hoc_ky_thi, Nam_hoc_Thi, Lan_thi)
                            Else
                                'Update điểm thi
                                If CheckExist_svDiemThi(ID_diem, Lan_thi, Hoc_ky_thi, Nam_hoc_Thi) > 0 Then
                                    If objDiem.dsDiemThi.Locked = 0 Then
                                        CapNhat_ESSDiemThi(objDiemThi, ID_diem, Lan_thi)
                                    End If
                                Else    'Insert điểm thi mới
                                    ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                                End If
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub LuuDiemThi_CaiThien(ByVal Lan_thi As Integer, ByVal dv As DataView)
            Try
                Doc_tham_so_he_thong()
                For i As Integer = 0 To arrDiem.Count - 1
                    Dim objDiem As New ESSDiem
                    Dim objDiemThi As New ESSDiemThi
                    Dim ID_diem, idx_diem_thi As Integer
                    objDiem = CType(arrDiem(i), ESSDiem)
                    dv.RowFilter = "ID_sv=" & objDiem.ID_sv
                    If dv.Count > 0 Then
                        idx_diem_thi = objDiem.dsDiemThi.idx_diem_thi(objDiem.Hoc_ky, objDiem.Nam_hoc, Lan_thi)
                        If idx_diem_thi >= 0 Then
                            objDiemThi = objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi)
                        Else
                            objDiemThi.Lan_thi = Lan_thi
                            objDiemThi.Diem_thi = -1
                        End If
                        'Nếu chưa có môn học này thì insert
                        If objDiem.ID_diem <= 0 Then
                            ID_diem = ThemMoi_ESSDiem(objDiem)
                            objDiem.ID_diem = ID_diem
                        Else
                            ID_diem = objDiem.ID_diem
                        End If
                        'Nếu không có điểm thành phần và điểm thì thì xoá điểm môn học
                        If objDiem.dsDiemThanhPhan.Count = 0 And objDiem.dsDiemThi.Count = 0 Then
                            Xoa_ESSDiem(objDiem.ID_diem)
                        Else
                            'Quy đổi điểm chữ
                            Dim Diem_chu As String
                            Diem_chu = DiemChu(objDiem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc)

                            If Diem_chu = "X" Or Diem_chu = "I" Then
                                objDiemThi.Ghi_chu = Diem_chu
                                objDiemThi.Diem_chu = ""
                            ElseIf Diem_chu = "K" Then
                                objDiemThi.Ghi_chu = Diem_chu
                                objDiemThi.Diem_chu = "F"
                                'ElseIf Diem_chu = "P" Then
                                '    objDiemThi.Ghi_chu = Diem_chu
                                '    objDiemThi.Diem_chu = ""
                            ElseIf Diem_chu <> "NC" Then
                                objDiemThi.Diem_chu = Diem_chu
                                If objDiemThi.Ghi_chu = "X" Or objDiemThi.Ghi_chu = "I" Then objDiemThi.Ghi_chu = ""
                            End If

                            'Tính điểm TBCMH
                            Dim TBCMH As Double = 0
                            If objDiemThi.Ghi_chu = "VC" Or objDiemThi.Ghi_chu = "B" Then
                                TBCMH = objDiemThi.Diem_thi
                            ElseIf objDiemThi.Ghi_chu = "K" Then
                                TBCMH = 0
                            ElseIf objDiemThi.Ghi_chu = "NC" Then
                                TBCMH = Math.Round(TinhTBCMH_CaiThien(objDiem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                                Diem_chu = dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
                                objDiemThi.Diem_chu = Diem_chu
                            ElseIf QuyCheTinChi_CHUNG = 1 Then
                                TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                            Else
                                TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                            End If
                            objDiemThi.TBCMH = TBCMH
                            objDiemThi.Hoc_ky_thi = objDiem.Hoc_ky
                            objDiemThi.Nam_hoc_thi = objDiem.Nam_hoc
                            If objDiemThi.Diem_chu = "" And objDiemThi.Diem_thi = -1 And objDiemThi.Ghi_chu = "" Then
                                Xoa_ESSDiemThi(ID_diem, objDiem.Hoc_ky, objDiem.Nam_hoc, Lan_thi)
                            Else
                                'Update điểm thi
                                If CheckExist_svDiemThi(ID_diem, Lan_thi, objDiem.Hoc_ky, objDiem.Nam_hoc) > 0 Then
                                    CapNhat_ESSDiemThi(objDiemThi, ID_diem, Lan_thi)
                                Else    'Insert điểm thi mới
                                    ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                                End If
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub LuuDiemThi_ImportExcel(ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                Doc_tham_so_he_thong()
                For i As Integer = 0 To arrDiem.Count - 1
                    Dim objDiem As New ESSDiem
                    Dim objDiemThi As New ESSDiemThi
                    Dim ID_diem, idx_diem_thi As Integer
                    objDiem = CType(arrDiem(i), ESSDiem)
                    idx_diem_thi = objDiem.dsDiemThi.idx_diem_thi(Lan_thi, Hoc_ky, Nam_hoc)
                    If idx_diem_thi >= 0 Then
                        objDiemThi = objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi)
                    Else
                        objDiemThi.Lan_thi = Lan_thi
                        objDiemThi.Diem_thi = -1
                    End If
                    'Nếu chưa có môn học này thì insert
                    If objDiem.ID_diem <= 0 Then
                        ID_diem = ThemMoi_ESSDiem(objDiem)
                        objDiem.ID_diem = ID_diem
                    Else
                        ID_diem = objDiem.ID_diem
                    End If
                    'Nếu không có điểm thành phần và điểm thì thì xoá điểm môn học
                    If objDiem.dsDiemThanhPhan.Count = 0 And objDiem.dsDiemThi.Count = 0 Then
                        Xoa_ESSDiem(objDiem.ID_diem)
                    Else
                        'Quy đổi điểm chữ
                        If objDiemThi.Diem_chu <> "R" Then  'Nếu không phải là điểm R thì tính lại điểm chữ
                            objDiemThi.Diem_chu = DiemChu(objDiem, Lan_thi, Hoc_ky, Nam_hoc)
                        End If
                        'Tính điểm TBCMH
                        Dim TBCMH As Double = -1
                        If QuyCheTinChi_CHUNG = 1 Then
                            TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                        Else
                            TBCMH = Math.Round(TinhTBCMH(objDiem, Lan_thi, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                        End If

                        objDiemThi.TBCMH = TBCMH
                        objDiemThi.Hoc_ky_thi = Hoc_ky
                        objDiemThi.Nam_hoc_thi = Nam_hoc
                        If objDiemThi.Diem_chu = "" And objDiemThi.Diem_thi = -1 Then
                            Xoa_ESSDiemThi(ID_diem, Hoc_ky, Nam_hoc, Lan_thi)
                        Else
                            'Update điểm thi
                            If CheckExist_svDiemThi(ID_diem, Lan_thi, Hoc_ky, Nam_hoc) > 0 Then
                                CapNhat_ESSDiemThi(objDiemThi, ID_diem, Lan_thi)
                            Else    'Insert điểm thi mới
                                ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                            End If
                        End If
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Function TinhTBCMH(ByVal objDiem As ESSDiem, ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            Dim TongdiemTP As Double = 0
            Dim ZHe_so_nhom As Integer = 0
            Dim TongPhanTramTP As Integer = 0
            Dim ESSDiemThi As Double = -1
            Dim So_thanh_phan As Integer = 0

            Dim dtNhomTP As New DataTable
            dtNhomTP.Columns.Add("Nhom", GetType(Integer))
            dtNhomTP.Columns.Add("Ty_le", GetType(Integer))
            dtNhomTP.Columns.Add("Tong_diem_nhom", GetType(Double))
            dtNhomTP.Columns.Add("He_so", GetType(Double))
            dtNhomTP.Columns.Add("So_tp", GetType(Double))
            Dim dvNhomTP As DataView = dtNhomTP.DefaultView
            For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Hoc_ky_TP = Hoc_ky And objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nam_hoc_TP = Nam_hoc Then
                    'TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                    'TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    So_thanh_phan += 1
                    If (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom > 0) Then
                        dvNhomTP.RowFilter = "Nhom=" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom.ToString
                        If (dvNhomTP.Count = 1) Then
                            dvNhomTP.Item(0)("So_tp") = dvNhomTP.Item(0)("So_tp") + 1
                            dvNhomTP.Item(0).Item("Ty_le") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dvNhomTP.Item(0)("He_so") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                            dvNhomTP.Item(0)("Tong_diem_nhom") = dvNhomTP.Item(0)("Tong_diem_nhom") + (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so)
                        Else
                            Dim dr As DataRow = dtNhomTP.NewRow
                            dr.Item("Nhom") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom
                            dr.Item("Ty_le") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dr.Item("Tong_diem_nhom") = (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so)
                            dr.Item("He_so") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                            dr.Item("So_tp") = 1
                            'TongPhanTramTP = TongPhanTramTP + objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dtNhomTP.Rows.Add(dr)
                            dtNhomTP.AcceptChanges()
                        End If
                    End If
                End If
            Next
            For a As Integer = 0 To dtNhomTP.Rows.Count - 1
                TongdiemTP = TongdiemTP + (dtNhomTP.Rows(a)("Tong_diem_nhom"))
                ZHe_so_nhom = ZHe_so_nhom + dtNhomTP.Rows(a)("He_so") * dtNhomTP.Rows(a)("So_tp")
                TongPhanTramTP = TongPhanTramTP + dtNhomTP.Rows(a)("Ty_le")
            Next
            'For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
            '    If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Hoc_ky_TP = Hoc_ky And objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nam_hoc_TP = Nam_hoc Then
            '        TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '        TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '        So_thanh_phan += 1
            '    End If
            'Next



            If Lan_thi >= 1 Then
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi)
            Else
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_max
            End If
            If TongPhanTramTP >= 0 And ESSDiemThi >= 0 And So_thanh_phan >= So_thanh_phan_chon Then
                If TongPhanTramTP < 10 And TongPhanTramTP > 0 Or (100 - TongPhanTramTP) = 0 Then
                    Return (TongdiemTP) / (TongPhanTramTP * 10) + 0.000001
                Else
                    Return (TongdiemTP / ZHe_so_nhom * TongPhanTramTP + ESSDiemThi * (100 - TongPhanTramTP)) / 100 + 0.00001
                End If
            Else
                If TongPhanTramTP >= 0 And So_thanh_phan >= So_thanh_phan_chon And (TongPhanTramTP < 10 And TongPhanTramTP > 0 Or (100 - TongPhanTramTP) = 0) Then
                    Return (TongdiemTP) / (TongPhanTramTP * 10) + 0.000001
                Else
                    Return -1
                End If
            End If
        End Function

        'Private Function TinhTBCMH_HVCS(ByVal objDiem As ESSDiem, ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
        '    Dim TongdiemTP As Double = 0
        '    Dim TongdiemCC As Double = 0
        '    Dim TongPhanTramTP As Integer = 0
        '    Dim TongPhanTramCC As Integer = 0
        '    Dim ESSDiemThi As Double = -1
        '    Dim So_thanh_phan_TP As Integer = 0
        '    Dim So_thanh_phan_CC As Integer = 0
        '    Dim TBCBP As Double = 0
        '    Dim TBCCC As Double = 0
        '    Dim idx As Integer
        '    'Duyệt các thành phần điểm
        '    For i As Integer = 0 To dsThanhPhanDiem.Count - 1
        '        If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
        '            idx = objDiem.dsDiemThanhPhan.Tim_idx(dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan, Hoc_ky, Nam_hoc)
        '            If idx >= 0 Then
        '                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False Then
        '                    TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx).Diem
        '                    TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx).Ty_le
        '                    So_thanh_phan_TP += 1
        '                Else
        '                    TongdiemCC += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx).Diem
        '                    TongPhanTramCC += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx).Ty_le
        '                    So_thanh_phan_CC += 1
        '                End If
        '            End If
        '        End If
        '    Next

        '    If Lan_thi >= 1 Then
        '        ESSDiemThi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi)
        '    Else
        '        ESSDiemThi = objDiem.dsDiemThi.Diem_thi_max
        '    End If
        '    If So_thanh_phan_TP > 0 Then
        '        TBCBP = Math.Round(TongdiemTP / So_thanh_phan_TP, 0)
        '    End If
        '    If So_thanh_phan_CC > 0 Then
        '        TBCCC = Math.Round(TongdiemCC / So_thanh_phan_CC, 0)
        '    End If

        '    If ESSDiemThi >= 0 And (So_thanh_phan_TP + So_thanh_phan_CC <= So_thanh_phan_chon) Then
        '        If (So_thanh_phan_TP + So_thanh_phan_CC > 0) Then
        '            Return (TBCCC * 10 + TBCBP * 30 + ESSDiemThi * 60) / 1000 + 0.00001
        '        Else
        '            Return ESSDiemThi
        '        End If

        '    Else
        '        Return -1
        '    End If
        'End Function

        Private Function TinhTBCMH_CaiThien(ByVal objDiem As ESSDiem, ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Double
            Dim TongdiemTP As Double = 0
            Dim TongPhanTramTP As Integer = 0
            Dim DiemThi1 As Double = -1
            Dim DiemThi2 As Double = -1
            Dim So_thanh_phan As Integer = 0
            For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Hoc_ky_TP = Hoc_ky And objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nam_hoc_TP = Nam_hoc Then
                    TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    So_thanh_phan += 1
                End If
            Next
            If Lan_thi >= 1 Then
                DiemThi1 = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, 1)
                DiemThi2 = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, 2)
            Else
                DiemThi1 = objDiem.dsDiemThi.Diem_thi_max
            End If

            If TongPhanTramTP >= 0 And DiemThi1 >= 0 And DiemThi2 >= 0 And So_thanh_phan >= So_thanh_phan_chon Then
                If DiemThi2 >= DiemThi1 Then
                    Return (TongdiemTP + DiemThi2 * (100 - TongPhanTramTP)) / 1000 + 0.00001
                Else
                    Return (TongdiemTP + ((DiemThi1 + DiemThi2) / 2) * (100 - TongPhanTramTP)) / 1000 + 0.00001
                End If
            Else
                Return -1
            End If
        End Function

        Private Function DiemChu(ByVal objDiem As ESSDiem, ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim TBCBP, Z1, ZHe_so_nhom As Double
            Dim TBCMH As Double
            Dim TongdiemTP As Double = 0
            Dim Tongdiem As Double = 0
            Dim TongPhanTramTP As Integer = 0
            Dim ESSDiemThi As Double
            Dim So_thanh_phan As Integer = 0
            Dim dtNhomTP As New DataTable
            dtNhomTP.Columns.Add("Nhom", GetType(Integer))
            dtNhomTP.Columns.Add("Ty_le", GetType(Integer))
            dtNhomTP.Columns.Add("Tong_diem_nhom", GetType(Double))
            dtNhomTP.Columns.Add("He_so", GetType(Double))
            dtNhomTP.Columns.Add("So_tp", GetType(Double))
            Dim dvNhomTP As DataView = dtNhomTP.DefaultView
            For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Hoc_ky_TP = Hoc_ky And objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nam_hoc_TP = Nam_hoc Then
                    'TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                    'TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    So_thanh_phan += 1
                    If (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom > 0) Then
                        dvNhomTP.RowFilter = "Nhom=" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom.ToString
                        If (dvNhomTP.Count = 1) Then
                            dvNhomTP.Item(0)("So_tp") = dvNhomTP.Item(0)("So_tp") + 1
                            dvNhomTP.Item(0).Item("Ty_le") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dvNhomTP.Item(0)("He_so") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                            dvNhomTP.Item(0)("Tong_diem_nhom") = dvNhomTP.Item(0)("Tong_diem_nhom") + (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so)
                        Else
                            Dim dr As DataRow = dtNhomTP.NewRow
                            dr.Item("Nhom") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nhom
                            dr.Item("Ty_le") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dr.Item("Tong_diem_nhom") = (objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so)
                            dr.Item("He_so") = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).He_so
                            dr.Item("So_tp") = 1
                            'TongPhanTramTP = TongPhanTramTP + objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                            dtNhomTP.Rows.Add(dr)
                            dtNhomTP.AcceptChanges()
                        End If
                    End If
                End If
            Next
            For a As Integer = 0 To dtNhomTP.Rows.Count - 1
                TongdiemTP = TongdiemTP + dtNhomTP.Rows(a)("Tong_diem_nhom")
                ZHe_so_nhom = ZHe_so_nhom + dtNhomTP.Rows(a)("He_so") * dtNhomTP.Rows(a)("So_tp")
                TongPhanTramTP = TongPhanTramTP + dtNhomTP.Rows(a)("Ty_le")
            Next
            'TBCBP = Tinh_TBCBP(Hoc_ky, Nam_hoc, objDiem.dsDiemThanhPhan, dtNhomTP.DefaultView)
            If Lan_thi >= 1 Then
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi)
            Else
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_max
            End If

            If QuyCheTinChi_CHUNG = 1 Then
                '-----------------------------------DUNG CHO HVCS ------------------------
                If TongPhanTramTP >= 0 And ESSDiemThi >= 0 And So_thanh_phan <= So_thanh_phan_chon Then
                    TBCMH = (TongdiemTP + ESSDiemThi * (100 - TongPhanTramTP)) / 1000 + 0.000001
                    'TBCMH = Math.Round(TinhTBCMH_HVCS(objDiem, Lan_thi, Hoc_ky, Nam_hoc), CType(Lam_tron_TBCMH, Integer))
                    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "VC" Or objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "B" Then
                    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(ESSDiemThi, CType(Lam_tron_TBCMH, Integer)))
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "K" Then
                    Return "K"
                    'ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi) = "P" Then
                    '    Return "P"
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "NC" Then
                    Return "NC"
                Else
                    If ESSDiemThi >= 0 Then
                        Return "I"  'Chưa đủ dữ liệu đánh giá, thiếu điểm thành phần
                    Else
                        If TongPhanTramTP > 0 Then
                            Return "X"  'Chưa có điểm thi
                        Else
                            Return ""
                        End If
                    End If
                End If
            Else
                '------ QUY CHE CHUNG ------------------
                If TongPhanTramTP >= 0 And ESSDiemThi >= 0 And So_thanh_phan = So_thanh_phan_chon Then
                    If (TongPhanTramTP < 10 And TongPhanTramTP > 0 Or (100 - TongPhanTramTP) = 0) Then
                        TBCMH = (TongdiemTP + ESSDiemThi) / (TongPhanTramTP * 10) + 0.000001
                    Else
                        TBCMH = (TongdiemTP / ZHe_so_nhom * TongPhanTramTP + ESSDiemThi * (100 - TongPhanTramTP)) / 100 + 0.000001
                    End If
                    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
                ElseIf TongPhanTramTP >= 0 And So_thanh_phan = So_thanh_phan_chon And (TongPhanTramTP < 10 And TongPhanTramTP > 0 Or (100 - TongPhanTramTP) = 0) Then
                    ESSDiemThi = 0
                    TBCMH = (TongdiemTP + ESSDiemThi) / (TongPhanTramTP * 10) + 0.000001
                    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "VC" Or objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "B" Then
                    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(ESSDiemThi, CType(Lam_tron_TBCMH, Integer)))
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "K" Then
                    Return "K"
                    'ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi) = "P" Then
                    '    Return "P"
                ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi, Hoc_ky, Nam_hoc) = "NC" Then
                    Return "NC"
                Else
                    If ESSDiemThi >= 0 Then
                        Return "I"  'Chưa đủ dữ liệu đánh giá, thiếu điểm thành phần
                    Else
                        If TongPhanTramTP > 0 Then
                            Return "X"  'Chưa có điểm thi
                        Else
                            Return ""
                        End If
                    End If
                End If
            End If
            'Dim TongdiemTP As Double = 0
            'Dim TongPhanTramTP As Integer = 0
            'Dim ESSDiemThi, TBCMH As Double

            'Dim TBKT, DCC As Double
            'Dim TongDiemKT As Double = 0
            'Dim TongPhanTramTP_KT As Integer = 0

            'Dim dkDK As Boolean = False
            'Dim So_thanh_phan As Integer = 0
            'For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
            '    TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '    TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '    So_thanh_phan += 1
            '    If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le = 10 Then
            '        DCC = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem
            '    Else
            '        TongDiemKT += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '        TongPhanTramTP_KT += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
            '    End If

            'Next
            'TBKT = TongDiemKT / TongPhanTramTP_KT

            'If Lan_thi >= 1 Then
            '    ESSDiemThi = objDiem.dsDiemThi.Diem_thi_lan(Lan_thi)
            'Else
            '    ESSDiemThi = objDiem.dsDiemThi.Diem_thi_max
            'End If

            'If TongPhanTramTP >= 0 And ESSDiemThi >= 0 And So_thanh_phan = So_thanh_phan_chon Then
            '    If TBKT < 3 Or DCC <> 10 Then
            '        Return "K"
            '    Else
            '        TBCMH = (TongdiemTP + ESSDiemThi * (100 - TongPhanTramTP)) / 100 + 0.000001
            '        Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
            '    End If
            'ElseIf objDiem.dsDiemThi.Ghi_chu_lan(Lan_thi) = "VC" Then
            '    Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(ESSDiemThi, CType(Lam_tron_TBCMH, Integer)))
            'Else
            '    If ESSDiemThi >= 0 Then
            '        Return "I"  'Chưa đủ dữ liệu đánh giá, thiếu điểm thành phần
            '    Else
            '        If TongPhanTramTP > 0 Then
            '            If TBKT < 3 Or DCC <> 10 Then
            '                Return "K"
            '            Else
            '                Return "X"  'Chưa có điểm thi
            '            End If
            '        Else
            '            Return ""
            '        End If
            '    End If
            'End If
        End Function


        Private Function DiemChu_KeThua(ByVal objDiem As ESSDiem, ByVal Lan_thi As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            Dim TongdiemTP As Double = 0
            Dim TongPhanTramTP As Integer = 0
            Dim ESSDiemThi, TBCMH As Double
            Dim So_thanh_phan As Integer = 0
            For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                If objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Hoc_ky_TP = Hoc_ky And objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Nam_hoc_TP = Nam_hoc Then
                    TongdiemTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    TongPhanTramTP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).Ty_le
                    So_thanh_phan += 1
                End If
            Next
            If Lan_thi >= 1 Then
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi)
            Else
                ESSDiemThi = objDiem.dsDiemThi.Diem_thi_max
            End If

            If TongPhanTramTP >= 0 And ESSDiemThi >= 0 Then
                TBCMH = (TongdiemTP + ESSDiemThi * (100 - TongPhanTramTP)) / 100 + 0.000001
                Return dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH, CType(Lam_tron_TBCMH, Integer)))
            Else
                If ESSDiemThi >= 0 Then
                    Return "I"  'Chưa đủ dữ liệu đánh giá, thiếu điểm thành phần
                Else
                    If TongPhanTramTP > 0 Then
                        Return "X"  'Chưa có điểm thi
                    Else
                        Return ""
                    End If
                End If
            End If
        End Function

        Public Function QuyDoiDiemChu(ByVal TBCMH As Double) As String
            If TBCMH >= 0 Then
                Return dsDiemQuyDoi.QuyDoiDiemChu(TBCMH)
            Else
                Return ""
            End If
        End Function

        Public Function CheckExist_svDiem(ByVal ID_dv As String, ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CheckExist_svDiem(ID_dv, ID_sv, ID_mon, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDiem(ByVal objDiem As ESSDiem) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.ThemMoi_ESSDiem(objDiem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiem(ByVal objDiem As ESSDiem, ByVal ID_diem As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiem(objDiem, ID_diem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiem(ByVal ID_diem As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.Xoa_ESSDiem(ID_diem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemThi(ByVal ID_diem As Integer, ByVal objDiemThi As ESSDiemThi) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThi(ByVal objDiemThi As ESSDiemThi, ByVal ID_diem As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThi(objDiemThi, ID_diem, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThiLock(ByVal ID_diem As Integer, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThiLock(ID_diem, Locked, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Lock_UnLock_Diem(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.Lock_UnLock_Diem(ID_sv, ID_mon, Lan_thi, Locked)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemThi(ByVal ID_diem As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_thi As String, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.Xoa_ESSDiemThi(ID_diem, Hoc_ky_thi, Nam_hoc_thi, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemThi(ByVal ID_diem As Integer, ByVal Lan_thi As Integer, ByVal Hoc_ky_Thi As Integer, ByVal Nam_hoc_thi As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CheckExist_DiemThi(ID_diem, Lan_thi, Hoc_ky_Thi, Nam_hoc_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CheckExist_DiemThanhPhan(ID_diem, ID_thanh_phan, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemThanhPhan(ByVal ID_diem As Integer, ByVal objDiemThanhPhan As ESSDiemThanhPhan) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemThanhPhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhan(ByVal objDiemThanhPhan As ESSDiemThanhPhan, ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThanhPhan(objDiemThanhPhan, ID_diem, ID_thanh_phan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhanLock(ByVal ID_diem As Integer, ByVal Locked As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThanhPhanLock(ID_diem, Locked)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThanhPhanLock_TP(ByVal ID_diem As Integer, ByVal Hoc_ky_tp As Integer, ByVal Nam_hoc_tp As String, ByVal Locked As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThanhPhanLock_TP(ID_diem, Hoc_ky_tp, Nam_hoc_tp, Locked)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDiemThiLock_ChuanHoa(ByVal ID_diem As Integer, ByVal Hoc_ky_thi As Integer, ByVal Nam_hoc_thi As String, ByVal Locked As Integer, ByVal Lan_thi As Integer) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_ESSDiemThiLock_ChuanHoa(ID_diem, Hoc_ky_thi, Nam_hoc_thi, Locked, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemThanhPhan(ByVal ID_diem As Integer, ByVal ID_thanh_phan As Integer, ByVal Hoc_ky_TP As Integer, ByVal Nam_hoc_TP As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.Xoa_ESSDiemThanhPhan(ID_diem, ID_thanh_phan, Hoc_ky_TP, Nam_hoc_TP)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DiemSinhVienToanKhoa_Nganh1TrungNganh2(ByVal ID_sv As Integer, ByVal dt_MonTrung As DataTable) As DataTable
            Dim dtDiem, mdt_MonTrung As New DataTable
            mdt_MonTrung = dt_MonTrung.Copy
            Dim idx_diem As Integer
            Dim Diem_chu As String

            dtDiem = dt_MonTrung.Clone
            dtDiem.Columns.Add("Chon", GetType(Boolean))
            dtDiem.Columns.Add("idx_diem", GetType(Integer))
            dtDiem.Columns.Add("TBCM", GetType(String))
            dtDiem.Columns.Add("Diem_chu", GetType(String))
            Doc_tham_so_he_thong()
            For i As Integer = 0 To dsMonHoc.Count - 1
                dt_MonTrung.DefaultView.Sort = "ID_mon"
                'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                If dt_MonTrung.DefaultView.Find(dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon) >= 0 Then
                    'ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(ID_sv, dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(ESSDiem.dsDiemThi.Hoc_ky_thi, ESSDiem.dsDiemThi.Nam_hoc_thi)
                        Dim dr As DataRow = dtDiem.NewRow
                        dr("idx_diem") = idx_diem
                        dr("ID_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        dr("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                        dr("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                        dr("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                        dr("Hoc_ky") = ESSDiem.Hoc_ky
                        dr("Nam_hoc") = ESSDiem.Nam_hoc
                        If ESSDiem.dsDiemThi.TBCMH_max() >= 0 Then dr("TBCM") = Math.Round(ESSDiem.dsDiemThi.TBCMH_max(), CType(Lam_tron_TBCMH, Integer))
                        dr("Diem_chu") = Diem_chu
                        dr("Chon") = False

                        'Add môn học vào bảng điểm
                        dtDiem.Rows.Add(dr)
                    End If
                End If
            Next

            Return dtDiem
        End Function
        Public Function XetHoc2ChuongTrinh(ByVal dt As DataTable) As DataTable
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double
            Dim dr As DataRow
            dtTongHop = dt.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("Ky_tich_luy", GetType(Integer))

            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            Diem_so = ESSDiem.dsDiemThi.Diem_so_max()
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                            'Tính điểm tích luỹ
                            If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                'Tính số tín chỉ tích luỹ
                                If Diem_so > 0 Then
                                    Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem / Tong_so_hoc_trinh
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("Xep_loai") = dsXepHangHocLuc.ESSXepHangHocLuc(TBCHT)
                    'Get_KyTichLuy
                    Dim clsDAL As New Diem_DataAccess
                    dr("Ky_tich_luy") = clsDAL.Get_KyTichLuy(dr("ID_sv")).Rows.Count
                    dr("Chon") = False
                End If
            Next
            'dtTongHop.DefaultView.RowFilter = "TBCHT>2 AND Ky_tich_luy>0"
            Return dtTongHop
        End Function

        'Public Function XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
        '    Dim clsDAL As New Diem_DataAccess
        '    Doc_thamso_hethong()
        '    Doc_tham_so_he_thong()
        '    Dim dtTongHop As New DataTable
        '    Dim Diem_chu As String
        '    Dim idx_diem As Integer, ID_mon As Integer
        '    Dim Tong_diem As Double, So_TCTL As Integer
        '    Dim Diem_so As Double, TBCTL, TBC_TatCa As Double, So_TC_DiemF As Double
        '    Dim Tong_diem_ht As Double = 0
        '    Dim Tong_so_tin_chi As Integer = 0
        '    Dim TBCHT As Double = 0
        '    Dim dr As DataRow
        '    dtTongHop = mdtDanhSachSinhVien.Copy
        '    dtTongHop.Columns.Add("So_TCTL", GetType(Integer))
        '    dtTongHop.Columns.Add("TBCTL", GetType(String))
        '    dtTongHop.Columns.Add("TBCHT_Ky", GetType(String))
        '    dtTongHop.Columns.Add("So_TCHT", GetType(Integer))
        '    dtTongHop.Columns.Add("Ly_do", GetType(String))
        '    Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

        '    'Add cac cot ESSDiem cua cac mon hoc
        '    For i As Integer = 0 To dsMonHoc.Count - 1
        '        If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
        '            dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
        '        End If
        '    Next
        '    'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
        '    For Each dr In dtTongHop.Rows
        '        'If dr("ID_SV") = 472139 Then
        '        '    dr("ID_SV") = 472139
        '        'End If
        '        'Add cac hoc ky va nam hoc
        '        Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
        '        Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
        '        Dim dt_ky As New DataTable
        '        dt_ky.Columns.Add("Hoc_ky", GetType(Integer))
        '        dt_ky.Columns.Add("Nam_hoc", GetType(String))
        '        dt_ky.Columns.Add("TBCHT_Ky", GetType(Double))
        '        For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
        '            Dim dr_kh As DataRow
        '            dr_kh = dt_ky.NewRow

        '            If Nam_hoc = i & "-" & i + 1 Then
        '                'Den nam va hoc ky xet thi exit
        '                dr_kh("Hoc_ky") = 1
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '                If Hoc_ky = 2 Then
        '                    dr_kh = dt_ky.NewRow
        '                    dr_kh("Hoc_ky") = 2
        '                    dr_kh("Nam_hoc") = i & "-" & i + 1
        '                    dt_ky.Rows.Add(dr_kh)
        '                End If
        '                Exit For
        '            Else
        '                dr_kh("Hoc_ky") = 1
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '                dr_kh = dt_ky.NewRow
        '                dr_kh("Hoc_ky") = 2
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '            End If
        '        Next

        '        'Tao dt de luu ESSDiem theo ky
        '        Dim dt_LuuDiemKy As New DataTable
        '        dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
        '        dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
        '        dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
        '        dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))


        '        Tong_diem = 0
        '        So_TCTL = 0
        '        Tong_so_tin_chi = 0
        '        TBCTL = 0
        '        TBCHT = 0
        '        Tong_diem_ht = 0
        '        TBC_TatCa = 0
        '        Dim ID_dt As Integer = 0
        '        So_TC_DiemF = 0

        '        'Duyet cac mon hoc
        '        For i As Integer = 0 To dsMonHoc.Count - 1
        '            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
        '            ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
        '            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
        '                ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
        '                'Tim ESSDiem cua sinh vien nay
        '                'idx_diem = Tim_idx_Thi_ky(dr("ID_sv"), ID_mon, Hoc_ky, Nam_hoc, dr("Lan_thi"))
        '                idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
        '                'Nếu sinh viên có điểm môn học này thì tính điểm
        '                If idx_diem >= 0 Then
        '                    Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
        '                    '==============================
        '                    If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
        '                        ESSDiem.Tinh_tich_luy = False
        '                    ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, dtTongHop.Rows(i)("ID_dt"), dtTongHop.Rows(i)("ID_sv")) = False Then
        '                        'Chỉ tổng hợp những năm hiện tại
        '                        If ESSDiem.Nam_hoc <= Nam_hoc Then
        '                            Diem_so = ESSDiem.dsDiemThi.Diem_so_max()
        '                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
        '                            'Tính số tín chỉ tích luỹ
        '                            If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so > 0 Then
        '                                Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                                So_TCTL += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            End If

        '                            '************************
        '                            'Luu vao dt nay de sau nay tinh ESSDiem Tich luy ky 
        '                            If Diem_so >= 0 Then
        '                                Tong_so_tin_chi += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                                Tong_diem_ht += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

        '                                Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
        '                                dr_CheckKy("Hoc_ky") = ESSDiem.Hoc_ky
        '                                dr_CheckKy("Nam_hoc") = ESSDiem.Nam_hoc
        '                                dr_CheckKy("Diem") = Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                                dr_CheckKy("So_TC") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                                dt_LuuDiemKy.Rows.Add(dr_CheckKy)
        '                            End If
        '                            If ESSDiem.dsDiemThi.Diem_chu_max_TongHop = "F" Then
        '                                So_TC_DiemF = So_TC_DiemF + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            End If
        '                        End If
        '                    End If
        '                End If
        '            End If
        '        Next


        '        ' Tinh ESSDiem TBCHT ky
        '        For j As Integer = 0 To dt_ky.Rows.Count - 1
        '            Dim TBTL_Ky As Double = 0
        '            Dim So_TC As Integer = 0
        '            dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_ky.Rows(j).Item("Hoc_ky") & " And Nam_hoc='" & dt_ky.Rows(j).Item("Nam_hoc") & "'"
        '            For i As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
        '                If dt_LuuDiemKy.DefaultView.Item(i)("Diem") > 0 Then
        '                    TBTL_Ky += dt_LuuDiemKy.DefaultView.Item(i)("Diem")
        '                    So_TC += dt_LuuDiemKy.DefaultView.Item(i)("So_TC")
        '                End If
        '            Next

        '            If So_TC > 0 Then
        '                TBTL_Ky = Math.Round(TBTL_Ky / So_TC, LamTron_Diem_TongHop)
        '                dt_ky.Rows(j).Item("TBCHT_Ky") = TBTL_Ky
        '            Else
        '                dt_ky.Rows(j).Item("TBCHT_Ky") = 0
        '            End If
        '        Next

        '        'Check thời gian hoàn thành chương trình đào tạo
        '        Dim Ly_do As String = ""
        '        Dim cls As ChuongTrinhDaoTao_Bussines
        '        cls = New ChuongTrinhDaoTao_Bussines(dr("ID_dt"))
        '        Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
        '        Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
        '        If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1

        '        If So_ky_ToiDa < So_ky_hienTai Then Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa

        '        'Check Học kỳ
        '        For i As Integer = 0 To dt_ky.Rows.Count - 1
        '            '-	Học kỳ đầu TBCTL < 0.8
        '            Dim NamHoc As Integer = CType(Left(dt_ky.Rows(i).Item("Nam_hoc"), 4), Integer)
        '            If (NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 1) AndAlso KyDau_TBCTL_Active AndAlso dt_ky.Rows(i).Item("TBCHT_Ky") < KyDau_TBCTL Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Học kỳ đầu khoá có TBCHT kỳ < " & KyDau_TBCTL.ToString
        '                Else
        '                    Ly_do = "Học kỳ đầu khoá học có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyDau_TBCTL.ToString
        '                End If
        '            End If

        '            If KyBatKy_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < KyBatKy_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Học kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ")có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & KyBatKy_TBCTL.ToString
        '                Else
        '                    Ly_do = "Học kỳ bất kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyBatKy_TBCTL
        '                End If
        '            End If

        '            ''-	2 Học kỳ liên tiếp TBCTL < 1.1
        '            'If HaiKyLienTiep_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
        '            '    If i > 0 AndAlso dt_ky.Rows(i - 1).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL Then
        '            '        If Ly_do.Trim <> "" Then
        '            '            Ly_do += ",2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
        '            '        Else
        '            '            Ly_do = "2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
        '            '        End If
        '            '    End If
        '            'End If
        '        Next

        '        'Tính điểm TBC tich luy và xếp loại
        '        Dim Xephang_Namdaotao As Integer = 0
        '        Xephang_Namdaotao = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_TCTL)
        '        If So_TCTL > 0 Then
        '            TBCTL = Math.Round(Tong_diem / So_TCTL, LamTron_Diem_TongHop)
        '            TBC_TatCa = Math.Round(Tong_diem / Tong_so_tin_chi, LamTron_Diem_TongHop)

        '            If NamXet_TBCHT_Active AndAlso TBC_TatCa < NamXet_TBCHT Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ", Năm xét có TBCHT là " & TBC_TatCa & "< " & NamXet_TBCHT.ToString
        '                Else
        '                    Ly_do = " Năm xét có TBCHT là " & TBC_TatCa & "< " & NamXet_TBCHT.ToString
        '                End If
        '            End If

        '            'Với năm học
        '            If (Xephang_Namdaotao = 1 AndAlso NamDau_TBCTL_Active AndAlso TBCTL < NamDau_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
        '                End If
        '            End If
        '            If (Xephang_Namdaotao = 2 AndAlso NamThu2_TBCTL_Active AndAlso TBCTL < NamThu2_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
        '                End If
        '            End If
        '            If (Xephang_Namdaotao = 3 AndAlso NamThu3_TBCTL_Active AndAlso TBCTL < NamThu3_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
        '                End If
        '            End If

        '            If (Xephang_Namdaotao >= 4 AndAlso TuNamThu4_TBCTL_Active AndAlso TBCTL < TuNamThu4_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
        '                Else
        '                    Ly_do = "từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
        '                End If
        '            End If

        '            If So_TC_DiemF > 24 Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ", HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép" & vbCrLf
        '                Else
        '                    Ly_do = " HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép" & vbCrLf
        '                End If
        '            End If
        '        Else
        '            Ly_do = "TBC tích luỹ là 0"
        '        End If
        '        If Tong_diem_ht > 0 Then
        '            TBCHT = Math.Round(Tong_diem_ht / Tong_so_tin_chi + 0.00001, LamTron_Diem_TongHop)
        '        End If
        '        dr("So_TCTL") = So_TCTL
        '        dr("TBCTL") = TBCTL
        '        dr("TBCHT_Ky") = TBCHT
        '        dr("So_TCHT") = Tong_so_tin_chi
        '        dr("Ly_do") = Ly_do
        '    Next
        '    dtTongHop.DefaultView.RowFilter = "Ly_do<>''"
        '    Return dtTongHop
        'End Function

        'Public Function XetLenLop_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
        '    Doc_thamso_hethong()
        '    Doc_tham_so_he_thong()
        '    Dim dtTongHop As New DataTable
        '    Dim Diem_chu As String
        '    Dim idx_diem As Integer, ID_mon As Integer
        '    Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
        '    Dim Diem_so As Double, TBCTL As Double
        '    Dim Tong_diem_ht As Double = 0
        '    Dim Tong_so_tin_chi As Integer = 0
        '    Dim TBCHT As Double = 0
        '    Dim dr As DataRow
        '    dtTongHop = mdtDanhSachSinhVien.Copy
        '    dtTongHop.Columns.Add("Tong_so_hoc_trinh", GetType(Integer))
        '    dtTongHop.Columns.Add("TBCTL", GetType(String))
        '    dtTongHop.Columns.Add("TBCHT", GetType(String))
        '    dtTongHop.Columns.Add("Tong_so_tin_chi", GetType(Integer))
        '    dtTongHop.Columns.Add("Ly_do", GetType(String))
        '    Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

        '    'Add cac cot ESSDiem cua cac mon hoc
        '    For i As Integer = 0 To dsMonHoc.Count - 1
        '        If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
        '            dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
        '        End If
        '    Next
        '    'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
        '    For Each dr In dtTongHop.Rows
        '        'If dr("ID_SV") = 2528 Then
        '        '    dr("ID_SV") = 2528
        '        'End If
        '        'Add cac hoc ky va nam hoc
        '        Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
        '        Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
        '        Dim dt_ky As New DataTable
        '        dt_ky.Columns.Add("Hoc_ky", GetType(Integer))
        '        dt_ky.Columns.Add("Nam_hoc", GetType(String))
        '        dt_ky.Columns.Add("TBCHT_Ky", GetType(Double))
        '        For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
        '            Dim dr_kh As DataRow
        '            dr_kh = dt_ky.NewRow

        '            If Nam_hoc = i & "-" & i + 1 Then
        '                'Den nam va hoc ky xet thi exit
        '                dr_kh("Hoc_ky") = 1
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '                If Hoc_ky = 2 Then
        '                    dr_kh = dt_ky.NewRow
        '                    dr_kh("Hoc_ky") = 2
        '                    dr_kh("Nam_hoc") = i & "-" & i + 1
        '                    dt_ky.Rows.Add(dr_kh)
        '                End If
        '                Exit For
        '            Else
        '                dr_kh("Hoc_ky") = 1
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '                dr_kh = dt_ky.NewRow
        '                dr_kh("Hoc_ky") = 2
        '                dr_kh("Nam_hoc") = i & "-" & i + 1
        '                dt_ky.Rows.Add(dr_kh)
        '            End If
        '        Next

        '        'Tao dt de luu ESSDiem theo ky
        '        Dim dt_LuuDiemKy As New DataTable
        '        dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
        '        dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
        '        dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
        '        dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))


        '        Tong_diem = 0
        '        Tong_so_hoc_trinh = 0
        '        Tong_so_tin_chi = 0
        '        TBCTL = 0
        '        TBCHT = 0
        '        Tong_diem_ht = 0
        '        Dim ID_dt As Integer = 0

        '        'Duyet cac mon hoc
        '        For i As Integer = 0 To dsMonHoc.Count - 1
        '            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
        '            ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
        '            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
        '                ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
        '                'Tim ESSDiem cua sinh vien nay
        '                idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
        '                'Nếu sinh viên có điểm môn học này thì tính điểm
        '                If idx_diem >= 0 Then
        '                    Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
        '                    'Chỉ tổng hợp những năm hiện tại
        '                    If ESSDiem.Nam_hoc <= Nam_hoc Then
        '                        Diem_so = ESSDiem.dsDiemThi.Diem_so_max()
        '                        Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
        '                        'Tính điểm tích luỹ
        '                        'If dsDiemQuyDoi.TichLuy(Diem_chu) Then
        '                        'Tính số tín chỉ tích luỹ
        '                        If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so >= 0 Then
        '                            Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                        End If


        '                        '************************
        '                        'Luu vao dt nay de sau nay tinh ESSDiem Tich luy ky 
        '                        If Diem_so >= 0 Then
        '                            Tong_so_tin_chi += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            Tong_diem_ht += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

        '                            Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
        '                            dr_CheckKy("Hoc_ky") = ESSDiem.Hoc_ky
        '                            dr_CheckKy("Nam_hoc") = ESSDiem.Nam_hoc
        '                            dr_CheckKy("Diem") = Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            dr_CheckKy("So_TC") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
        '                            dt_LuuDiemKy.Rows.Add(dr_CheckKy)
        '                        End If


        '                        'End If
        '                    End If
        '                End If
        '            End If
        '        Next


        '        ' Tinh ESSDiem TBCHT ky
        '        For j As Integer = 0 To dt_ky.Rows.Count - 1
        '            Dim TBTL_Ky As Double = 0
        '            Dim So_TC As Integer = 0
        '            dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_ky.Rows(j).Item("Hoc_ky") & " And Nam_hoc='" & dt_ky.Rows(j).Item("Nam_hoc") & "'"
        '            For i As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
        '                TBTL_Ky += dt_LuuDiemKy.DefaultView.Item(i)("Diem")
        '                So_TC += dt_LuuDiemKy.DefaultView.Item(i)("So_TC")
        '            Next

        '            If So_TC > 0 Then
        '                TBTL_Ky = Math.Round(TBTL_Ky / So_TC, LamTron_Diem_TongHop)
        '                dt_ky.Rows(j).Item("TBCHT_Ky") = TBTL_Ky
        '            Else
        '                dt_ky.Rows(j).Item("TBCHT_Ky") = 0
        '            End If
        '        Next

        '        'Check thời gian hoàn thành chương trình đào tạo
        '        Dim Ly_do As String = ""
        '        Dim cls As ChuongTrinhDaoTao_Bussines
        '        cls = New ChuongTrinhDaoTao_Bussines(dr("ID_dt"))
        '        Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
        '        Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
        '        If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1

        '        If So_ky_ToiDa < So_ky_hienTai Then Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa


        '        'Check Học kỳ
        '        For i As Integer = 0 To dt_ky.Rows.Count - 1
        '            '-	Học kỳ đầu TBCTL < 0.8
        '            Dim NamHoc As Integer = CType(Left(dt_ky.Rows(i).Item("Nam_hoc"), 4), Integer)
        '            If (NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 1) AndAlso KyDau_TBCTL_Active AndAlso dt_ky.Rows(i).Item("TBCHT_Ky") < KyDau_TBCTL Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Học kỳ đầu khoá có TBCHT kỳ < " & KyDau_TBCTL.ToString
        '                Else
        '                    Ly_do = "Học kỳ đầu khoá học có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyDau_TBCTL.ToString
        '                End If
        '            End If

        '            If KyBatKy_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < KyBatKy_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Học kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ")có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & KyBatKy_TBCTL.ToString
        '                Else
        '                    Ly_do = "Học kỳ bất kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyBatKy_TBCTL
        '                End If
        '            End If

        '            '-	2 Học kỳ liên tiếp TBCTL < 1.1
        '            If HaiKyLienTiep_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
        '                If i > 0 AndAlso dt_ky.Rows(i - 1).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL Then
        '                    If Ly_do.Trim <> "" Then
        '                        Ly_do += ",2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
        '                    Else
        '                        Ly_do = "2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
        '                    End If
        '                End If
        '            End If
        '        Next

        '        'Tính điểm TBC tich luy và xếp loại
        '        Dim Xephang_Namdaotao As Integer = 0
        '        Xephang_Namdaotao = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(Tong_so_hoc_trinh)
        '        If Tong_so_hoc_trinh > 0 Then
        '            TBCTL = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
        '            'Với năm học
        '            If (Xephang_Namdaotao = 1 AndAlso NamDau_TBCTL_Active AndAlso TBCTL < NamDau_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
        '                End If
        '            End If
        '            If (Xephang_Namdaotao = 2 AndAlso NamThu2_TBCTL_Active AndAlso TBCTL < NamThu2_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
        '                End If
        '            End If
        '            If (Xephang_Namdaotao = 3 AndAlso NamThu3_TBCTL_Active AndAlso TBCTL < NamThu3_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
        '                Else
        '                    Ly_do = "Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
        '                End If
        '            End If

        '            If (Xephang_Namdaotao >= 4 AndAlso TuNamThu4_TBCTL_Active AndAlso TBCTL < TuNamThu4_TBCTL) Then
        '                If Ly_do.Trim <> "" Then
        '                    Ly_do += ",từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
        '                Else
        '                    Ly_do = "từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
        '                End If
        '            End If
        '        Else
        '            Ly_do = "TBC tích luỹ là 0"
        '        End If
        '        If Tong_diem_ht > 0 Then
        '            TBCHT = Math.Round(Tong_diem_ht / Tong_so_tin_chi + 0.00001, LamTron_Diem_TongHop)
        '        End If
        '        dr("Tong_so_hoc_trinh") = Tong_so_hoc_trinh
        '        dr("TBCTL") = TBCTL
        '        dr("TBCHT") = TBCHT
        '        dr("Tong_so_tin_chi") = Tong_so_tin_chi
        '        dr("Ly_do") = Ly_do
        '    Next
        '    dtTongHop.DefaultView.RowFilter = "Ly_do<>''"
        '    Return dtTongHop
        'End Function

        Function XetLuanVan(ByVal TBCTL As Double, ByVal So_tin_chi_TL As Double) As DataTable
            Dim clsXetMon As New DanhSachTotNghiep_DataAccess
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("Chon1", GetType(Boolean))
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_tin_chi", GetType(Double))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            dtTongHop.Columns.Add("Sinh_vien_duyet", GetType(Boolean))
            dtTongHop.Columns.Add("Co_van_duyet", GetType(Boolean))
            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                dr("Chon1") = False

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Mon_tot_nghiep = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx_Diem_Max(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            Else
                                Diem_so = ESSDiem.dsDiemThi.Diem_so_max_TongHop()
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                                'Diem_so = ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                'Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                                'Tính điểm tích luỹ
                                If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                    'Tính số tín chỉ tích luỹ
                                    If Diem_so > 0 Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                'Tính số môn nợ
                                If Diem_so = 0 Then
                                    So_mon_no += 1
                                End If
                                If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so.ToString
                            End If
                        End If
                    End If
                Next
                'Kiem tra cac hoc phan bat buoc da hoc (Tru cac hoc phan thi TN)

                Dim dt_check_mon As DataTable = clsXetMon.Check_MonBatBuoc_SV(dr("ID_SV"), mID_dv, 0, dr("ID_dt"))
                Dim Ly_do As String = ""
                For j As Integer = 0 To dt_check_mon.Rows.Count - 1
                    If Ly_do.Trim = "" Then
                        Ly_do = dt_check_mon.Rows(j).Item("Ten_mon").ToString
                    Else
                        Ly_do += ", " & dt_check_mon.Rows(j).Item("Ten_mon").ToString
                    End If
                Next
                dr("Ly_do") = ""
                If Ly_do.Trim <> "" Then dr("Ly_do") = "Chưa có điểm môn bắt buộc: " & Ly_do.Trim
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem / Tong_so_hoc_trinh
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr("Xep_hang") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCHT, False)
                    dr("So_mon_no") = So_mon_no

                    dr("So_tin_chi") = So_hoc_trinh
                End If
            Next
            dtTongHop.DefaultView.RowFilter = "TBCHT>=" & TBCTL & " AND So_mon_no=0 AND So_tin_chi>=" & So_tin_chi_TL
            Return dtTongHop
        End Function

        Function TongHop_XetThiNoThiTotNghiep() As DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            Dim Ly_do As String = ""

            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            'For Each dr In dtTongHop.Rows
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                Ly_do = ""

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Mon_tot_nghiep = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx_Diem_Max(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                            ElseIf clsDAL.Check_HocPhan_TuongDuong(ID_mon, ESSDiem.ID_dt, ESSDiem.ID_sv) = False Then
                                'Diem_so = ESSDiem.dsDiemThi.Diem_so_max
                                Diem_so = ESSDiem.dsDiemThi.Diem_so_max_TongHop()
                                'Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop
                                'Tính điểm tích luỹ
                                If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                    'Tính số tín chỉ tích luỹ
                                    If Diem_so > 0 Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                'Tính số môn nợ
                                If Diem_so = 0 Then
                                    So_mon_no += 1
                                    If Diem_chu = "F" Then
                                        If Ly_do.Trim = "" Then
                                            Ly_do = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon & "(" & Diem_chu & ")"
                                        Else
                                            Ly_do += "," & dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon & "(" & Diem_chu & ")"
                                        End If
                                    End If
                                End If

                                If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so.ToString
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem / Tong_so_hoc_trinh
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr("Xep_hang") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCHT, False)
                    If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                    dr("So_hoc_trinh") = So_hoc_trinh
                Else
                    dr("So_hoc_trinh") = 0
                    If Ly_do.Trim = "" Then
                        Ly_do = "Chưa có điểm TBCHT"
                    Else
                        Ly_do += "- Chưa có điểm TBCHT"
                    End If
                End If
                If Ly_do.Trim <> "" Then dr("Ly_do") = Ly_do
            Next
            Return dtTongHop
        End Function

        Function ChuyenThi_LuanVan(ByVal ID_SV As Integer) As DataTable
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCHT As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(Double))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang", GetType(String))
            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                So_hoc_trinh = 0
                dr("Chon1") = False

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            Diem_so = ESSDiem.dsDiemThi.Diem_so_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, ESSDiem.Hoc_ky, ESSDiem.Nam_hoc)
                            'Tính điểm tích luỹ
                            If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                'Tính số tín chỉ tích luỹ
                                If Diem_so > 0 Then
                                    Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If
                                So_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            'Tính số môn nợ
                            If Diem_so = 0 Then
                                So_mon_no += 1
                            End If
                            If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so.ToString
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Tong_diem / Tong_so_hoc_trinh
                    dr("TBCHT") = Format(TBCHT, "##.00")
                    dr("ID_xep_loai") = dsXepHangTotNghiep.ID_XepHangTotNghiep(TBCHT, False)
                    dr("Xep_hang") = dsXepHangTotNghiep.ESSXepHangTotNghiep(TBCHT, False)
                    dr("So_mon_no") = So_mon_no

                    dr("So_hoc_trinh") = So_hoc_trinh
                End If
            Next
            dtTongHop.DefaultView.RowFilter = "ID_SV=" & ID_SV
            Return dtTongHop
        End Function

        Public Function DanhSachKhongDuDieuKienDuThi(ByVal ID_mon As Integer, ByVal MucDiem_Tran As Double) As DataTable
            Dim dtDiem As DataTable = mdtDanhSachSinhVien.Copy

            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))
            'Gán dữ liệu vào bảng danh sách sinh viên
            Dim TBCMTP As Double
            Dim TP As Integer

            For j As Integer = 0 To dtDiem.Rows.Count - 1
                Dim row As DataRow = dt.NewRow()
                TBCMTP = 0
                TP = 0
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim f As Boolean = False
                For i As Integer = 0 To arrDiem.Count - 1
                    If CType(arrDiem(i), ESSDiem).ID_sv = dtDiem.Rows(j).Item("ID_SV") And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                        f = True
                        TBCMTP += CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Diem * CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Ty_le
                        TP += CType(arrDiem(i), ESSDiem).dsDiemThanhPhan.Ty_le
                        Hoc_ky = CType(arrDiem(i), ESSDiem).Hoc_ky
                        Nam_hoc = CType(arrDiem(i), ESSDiem).Nam_hoc
                    End If
                Next
                If TP = 0 Then TP = 1
                TBCMTP = Math.Round(TBCMTP / TP, 2)
                If f AndAlso TBCMTP < MucDiem_Tran Then
                    row("Chon") = False
                    row("ID_SV") = dtDiem.Rows(j).Item("ID_SV")
                    row("Ma_sv") = dtDiem.Rows(j).Item("Ma_sv")
                    row("Ho_ten") = dtDiem.Rows(j).Item("Ho_ten")
                    row("Ngay_sinh") = dtDiem.Rows(j).Item("Ngay_sinh")
                    row("Ten_lop") = dtDiem.Rows(j).Item("Ten_lop")
                    row("ID_mon") = ID_mon
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    row("Ly_do") = "Do điểm kiểm tra " & TBCMTP

                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.RowFilter = "Ly_do<>''"
            Return dt
        End Function

        Public Sub KeThuaDiemNganh1ChoNganh2(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal ID_diem As Integer)
            Dim idx As Integer = -1
            idx = Tim_idx(ID_sv, ID_mon)
            If idx >= 0 Then
                Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                    Dim objDiemTP As New ESSDiemThanhPhan
                    objDiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i)
                    ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                Next
                For i As Integer = 0 To objDiem.dsDiemThi.Count - 1
                    If objDiem.dsDiemThi.ESSDiemThi(i).Diem_so >= 0 Then
                        Dim objDiemThi As New ESSDiemThi
                        objDiem.dsDiemThi.ESSDiemThi(i).Ghi_chu = "R"
                        objDiemThi = objDiem.dsDiemThi.ESSDiemThi(i)
                        ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                    End If
                Next
            End If
        End Sub

        Public Sub KeThuaDiemNganh1ChoNganh2_MonTuongDuong(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal ID_diem As Integer)
            Dim idx As Integer = -1
            idx = Tim_idx(ID_sv, ID_mon)
            If idx >= 0 Then
                Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                    Dim objDiemTP As New ESSDiemThanhPhan
                    objDiemTP = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i)
                    ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                Next
                For i As Integer = 0 To objDiem.dsDiemThi.Count - 1
                    If objDiem.dsDiemThi.ESSDiemThi(i).Diem_so >= 0 Then
                        Dim objDiemThi As New ESSDiemThi
                        objDiem.dsDiemThi.ESSDiemThi(i).Ghi_chu = "R2"
                        objDiemThi = objDiem.dsDiemThi.ESSDiemThi(i)
                        ThemMoi_ESSDiemThi(ID_diem, objDiemThi)
                    End If
                Next
            End If
        End Sub

        Public Sub XoaDiemKeThuaDiemNganh1ChoNganh2(ByVal ID_mon As Integer, ByVal ID_sv As Integer, ByVal ID_diem As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Dim idx As Integer = -1
            idx = Tim_idx(ID_sv, ID_mon)
            If idx >= 0 Then
                Dim objDiem As ESSDiem = CType(arrDiem(idx), ESSDiem)
                For i As Integer = 0 To objDiem.dsDiemThanhPhan.Count - 1
                    Xoa_ESSDiemThanhPhan(ID_diem, objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(i).ID_thanh_phan, Hoc_ky, Nam_hoc)
                Next
                For i As Integer = 0 To objDiem.dsDiemThi.Count - 1
                    Xoa_ESSDiemThi(ID_diem, Hoc_ky, Nam_hoc, objDiem.dsDiemThi.ESSDiemThi(i).Lan_thi)
                Next
            End If
        End Sub

        Public Function TongHopDiemHocKy_TichLuy(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem_10, Tong_diem_TL As Double, Tong_so_hoc_trinh, Tong_so_hoc_trinh_TL As Integer
            Dim Diem_so As Double, TBCHT, TBCTL, TBCHT10, TBCMH As Double, So_mon_no As Integer, So_hoc_trinh As Integer
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))

            dtTongHop.Columns.Add("TBCHK_10", GetType(String))
            dtTongHop.Columns.Add("TBCTL", GetType(String))
            dtTongHop.Columns.Add("So_tc_tichluy", GetType(Integer))
            dtTongHop.Columns.Add("Nam_dao_tao", GetType(Integer))
            dtTongHop.Columns.Add("ID_Xephang_hocluc", GetType(Integer))
            dtTongHop.Columns.Add("Xep_hang_hocluc", GetType(String))
            dtTongHop.Columns.Add("Ket_qua_PL", GetType(String))
            dtTongHop.Columns.Add("Xep_hang_HT", GetType(String))

            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))

            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Tong_diem_10 = 0
                Tong_diem_TL = 0
                Tong_so_hoc_trinh_TL = 0
                So_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                Ghi_chu = ""
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon

                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                        If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, 2) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(Hoc_ky, Nam_hoc, 2)) Then So_mon_thi_lai += 1
                        If Lan_thi = 1 Then
                            Diem_so = ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc)
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                            TBCMH = ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc)
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        Else
                            Diem_so = ESSDiem.dsDiemThi.Diem_so_max
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                            TBCMH = ESSDiem.dsDiemThi.TBCMH_max
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        End If
                        If Diem_so >= 0 Then 'Hoc tap hoc ky
                            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                Tong_diem_10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            If Diem_so = 0 Then So_mon_no += 1
                        End If
                        If Diem_so > 0 Then 'Tich luy
                            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                Tong_diem_TL += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh_TL += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                        End If

                        '---------Add column----------------
                        If Hien_thi_diem_TP Then
                            Dim col As New DataColumn()
                            'Voi ESSDiem thanh phan
                            For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                                col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                                If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dr("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                            Next
                            'Voi ESSDiem thi
                            col = New DataColumn("T" + ID_mon.ToString + "Thi")
                            If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                            If Lan_thi = 1 Then
                                If ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi).ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Else
                                If ESSDiem.dsDiemThi.Diem_thi_max.ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            End If
                        End If
                        If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                            dtTongHop.Columns.Add("M" + ID_mon.ToString)
                        End If
                        '------------------End Column----------------------


                        If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                            dr("M" + ID_mon.ToString) = Diem_chu
                        ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                            If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Math.Round(Diem_so + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        Else    'Hiển thị điểm số thang điểm 10
                            If TBCMH >= 0 Then dr("M" + ID_mon.ToString) = Math.Round(TBCMH + 0.00001, CType(Lam_tron_TBCMH, Integer))
                        End If
                        'Hiển thị ghi chú cạnh cột điểm
                        If Hien_thi_ghi_chu Then
                            If dr("M" + ID_mon.ToString).ToString = "" Then
                                If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += Ghi_chu
                            Else
                                If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT = -1
                End If
                If Tong_so_hoc_trinh_TL > 0 Then
                    TBCTL = Math.Round(Tong_diem_TL / Tong_so_hoc_trinh_TL, LamTron_Diem_TongHop)
                Else
                    TBCTL = -1
                End If
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT10 = Math.Round(Tong_diem_10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT10 = -1
                End If
                If TBCHT >= 0 Then dr("TBCHT") = TBCHT
                If TBCHT10 >= 0 Then dr("TBCHK_10") = TBCHT10
                If TBCTL >= 0 Then dr("TBCTL") = TBCTL
                dr("ID_xep_loai") = dsXepLoaiHocTap_thangdiem10.IDXepLoaiHocTap_thangdiem10(TBCHT10)
                dr("Xep_loai") = dsXepLoaiHocTap_thangdiem10.ESSXeploaihoctap_thangdiem10(TBCHT10)



                dr("ID_Xephang_hocluc") = dsXepLoaiHocTap.IDXepLoaiHocTap(TBCHT)
                dr("Xep_hang_hocluc") = dsXepLoaiHocTap.ESSXepLoaiHocTap(TBCHT)
                dr("Xep_hang_HT") = dsXepHangHocLuc.ESSXepHangHocLuc(TBCTL)
                If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                If So_mon_thi_lai > 0 Then dr("So_mon_thi_lai") = So_mon_thi_lai
                If So_mon_hoc_lai > 0 Then dr("So_mon_hoc_lai") = So_mon_hoc_lai
                If Tong_so_hoc_trinh_TL > 0 Then dr("So_tc_tichluy") = Tong_so_hoc_trinh_TL
                dr("Nam_dao_tao") = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(Tong_so_hoc_trinh_TL)
            Next
            Dim dt As DataTable = dtTongHop.Copy
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                dtTongHop.Rows(i).Item("Ket_qua_PL") = dsXepLoaiHocTap_thangdiem10.PhantramXeploaihoctap(dt)
            Next
            Return dtTongHop
        End Function

        Public Function TongHopDiemHocKy_XetHocBong(ByVal Lan_thi As Byte, ByVal Hien_thi_diem As Integer, ByVal Hien_thi_ghi_chu As Boolean, ByVal Hien_thi_diem_TP As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu, Ghi_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem, Tong_diem10 As Double, Tong_so_hoc_trinh, Tong_so_hoc_trinh_TL As Integer
            Dim Diem_so As Double, TBCHT, TBCHT10, TBCMH As Double, So_mon_no, So_mon_no_xet_hoc_bong As Integer, So_hoc_trinh As Integer
            Dim So_mon_hoc_lai As Integer, So_mon_thi_lai As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT10", GetType(String))
            dtTongHop.Columns.Add("ID_xep_loai", GetType(Integer))
            dtTongHop.Columns.Add("Xep_loai", GetType(String))
            dtTongHop.Columns.Add("So_mon_no", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_no_xet_hoc_bong", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_thi_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_mon_hoc_lai", GetType(Integer))
            dtTongHop.Columns.Add("So_tc_tichluy", GetType(Integer))
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                So_mon_no = 0
                Tong_diem = 0
                Tong_diem10 = 0
                Tong_so_hoc_trinh = 0
                Tong_so_hoc_trinh_TL = 0
                So_hoc_trinh = 0
                So_mon_hoc_lai = 0
                So_mon_thi_lai = 0
                So_mon_no_xet_hoc_bong = 0
                Ghi_chu = ""
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    'Tim ESSDiem cua sinh vien nay
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    'Nếu sinh viên có điểm môn học này thì tính điểm
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Then So_mon_hoc_lai += 1
                        If ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, Lan_thi) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(Hoc_ky, Nam_hoc, Lan_thi)) Then So_mon_thi_lai += 1
                        If Lan_thi = 1 Then
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_lan(1, Hoc_ky, Nam_hoc)
                            TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_lan(1, Hoc_ky, Nam_hoc) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        Else
                            Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                            TBCMH = Math.Round(ESSDiem.dsDiemThi.TBCMH_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Ghi_chu = ESSDiem.dsDiemThi.Ghi_chu_lan(1, Hoc_ky, Nam_hoc)
                        End If
                        If Diem_so >= 0 Then
                            'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                            If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                                Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_diem10 += TBCMH * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                Tong_so_hoc_trinh_TL += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                            End If
                            If Diem_so = 0 Then
                                So_mon_no += 1
                                So_mon_no_xet_hoc_bong += 1
                            End If
                        End If

                        '---------Add column----------------
                        If Hien_thi_diem_TP Then
                            Dim col As New DataColumn()
                            'Voi ESSDiem thanh phan
                            For j As Integer = 0 To ESSDiem.dsDiemThanhPhan.Count - 1
                                col = New DataColumn("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString)
                                If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                                If ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem.ToString <> "" Then dr("T" + ID_mon.ToString + ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).ID_thanh_phan.ToString) = Math.Round(ESSDiem.dsDiemThanhPhan.ESSDiemThanhPhan(j).Diem, CType(Lam_tron_TBCMH, Integer))
                            Next
                            'Voi ESSDiem thi
                            col = New DataColumn("T" + ID_mon.ToString + "Thi")
                            If Not dtTongHop.Columns.Contains(col.ColumnName) Then dtTongHop.Columns.Add(col)
                            If Lan_thi = 1 Then
                                If ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi).ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_lan(Hoc_ky, Nam_hoc, Lan_thi) + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            Else
                                If ESSDiem.dsDiemThi.Diem_thi_max.ToString <> "" Then dr("T" + ID_mon.ToString + "Thi") = Math.Round(ESSDiem.dsDiemThi.Diem_thi_max + 0.00001, CType(Lam_tron_TBCMH, Integer))
                            End If
                        End If
                        If dtTongHop.Columns.IndexOf("M" + ID_mon.ToString) = -1 Then
                            dtTongHop.Columns.Add("M" + ID_mon.ToString)
                        End If
                        '------------------End Column----------------------

                        If Hien_thi_diem = 0 Then   'Hiển thị điểm chữ A,B,C,D,F
                            dr("M" + ID_mon.ToString) = Diem_chu
                        ElseIf Hien_thi_diem = 1 Then   'Hiển thị điểm số thang điểm 4: 0,1,2,3,4
                            If Diem_so >= 0 Then dr("M" + ID_mon.ToString) = Diem_so
                        Else    'Hiển thị điểm số thang điểm 10
                            If TBCMH >= 0 Then dr("M" + ID_mon.ToString) = TBCMH
                        End If
                        'Hiển thị ghi chú cạnh cột điểm
                        If Hien_thi_ghi_chu Then
                            If dr("M" + ID_mon.ToString).ToString = "" Then
                                If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += Ghi_chu
                            Else
                                If Ghi_chu.Trim <> "" Then dr("M" + ID_mon.ToString) += "(" & Ghi_chu & ")"
                            End If
                        End If
                    End If
                Next
                'Tính điểm TBCHT và xếp loại
                If Tong_so_hoc_trinh > 0 Then
                    TBCHT = Math.Round(Tong_diem / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                    TBCHT10 = Math.Round(Tong_diem10 / Tong_so_hoc_trinh, LamTron_Diem_TongHop)
                Else
                    TBCHT = -1
                    TBCHT10 = -1
                End If
                If TBCHT >= 0 Then dr("TBCHT") = TBCHT
                If TBCHT10 >= 0 Then dr("TBCHT10") = TBCHT10
                dr("ID_xep_loai") = dsXepLoaiHocTap_thangdiem10.IDXepLoaiHocTap_thangdiem10(TBCHT10)
                dr("Xep_loai") = dsXepLoaiHocTap_thangdiem10.ESSXeploaihoctap_thangdiem10(TBCHT10)
                If So_mon_no > 0 Then dr("So_mon_no") = So_mon_no
                If So_mon_no_xet_hoc_bong > 0 Then dr("So_mon_no_xet_hoc_bong") = So_mon_no_xet_hoc_bong
                If So_mon_thi_lai > 0 Then dr("So_mon_thi_lai") = So_mon_thi_lai
                If So_mon_hoc_lai > 0 Then dr("So_mon_hoc_lai") = So_mon_hoc_lai
                If Tong_so_hoc_trinh_TL > 0 Then dr("So_tc_tichluy") = Tong_so_hoc_trinh_TL
            Next
            Return dtTongHop
        End Function
#End Region

#Region "Nhập điểm từ Excel"
        Private Function NewTable() As DataTable
            Dim dt As New DataTable
            Dim Col1 As New DataColumn("ID_sv", GetType(String))
            Dim Col2 As New DataColumn("Ma_sv", GetType(String))
            Dim Col3 As New DataColumn("Hoc_ky", GetType(Long))
            Dim Col4 As New DataColumn("Nam_hoc", GetType(String))
            Dim Col5 As New DataColumn("Lan_thi", GetType(Long))
            Dim Col6 As New DataColumn("ID_dv", GetType(String))
            Dim Col7 As New DataColumn("ID_mon", GetType(Long))
            Dim Col8 As New DataColumn("ID_thanh_phan", GetType(Long))
            Dim Col9 As New DataColumn("Ty_le", GetType(Long))
            Dim Col10 As New DataColumn("Diem", GetType(String))
            Dim Col11 As New DataColumn("Ghi_chu", GetType(String))
            Dim Col12 As New DataColumn("ID_dt", GetType(String))
            Dim Col13 As New DataColumn("Ho_ten", GetType(String))
            Dim Col14 As New DataColumn("Ten_lop", GetType(String))
            Dim Col15 As New DataColumn("Hoten_Order", GetType(String))
            Dim Col16 As New DataColumn("Locked", GetType(Byte))
            Dim Col17 As New DataColumn("ID_diem", GetType(Long))
            Dim Col18 As New DataColumn("ID_diem_main", GetType(Long))
            Dim Col19 As New DataColumn("Hoc_ky_TP", GetType(Long))
            Dim Col20 As New DataColumn("Nam_hoc_TP", GetType(String))
            Dim Col21 As New DataColumn("Hoc_ky_thi", GetType(Long))
            Dim Col22 As New DataColumn("Nam_hoc_thi", GetType(String))

            dt.Columns.Add(Col1)
            dt.Columns.Add(Col2)
            dt.Columns.Add(Col3)
            dt.Columns.Add(Col4)
            dt.Columns.Add(Col5)
            dt.Columns.Add(Col6)
            dt.Columns.Add(Col7)
            dt.Columns.Add(Col8)
            dt.Columns.Add(Col9)
            dt.Columns.Add(Col10)
            dt.Columns.Add(Col11)
            dt.Columns.Add(Col12)
            dt.Columns.Add(Col13)
            dt.Columns.Add(Col14)
            dt.Columns.Add(Col15)
            dt.Columns.Add(Col16)
            dt.Columns.Add(Col17)
            dt.Columns.Add(Col18)
            dt.Columns.Add(Col19)
            dt.Columns.Add(Col20)
            dt.Columns.Add(Col21)
            dt.Columns.Add(Col22)
            Return dt
        End Function

        Private Sub getThongtin_sinhvien(ByVal Ma_sv As String, ByVal ID_mon As Integer, ByRef ID_sv As String, ByRef Ho_ten As String, ByRef ID_dt As String, ByRef Ten_lop As String)
            Dim clsDAL As New Diem_DataAccess
            Dim dt As DataTable = clsDAL.getSinhVienInfor_DiemExcel(ID_mon, Ma_sv)

            If dt Is Nothing Then Exit Sub
            If dt.Rows.Count > 0 Then
                ID_sv = dt.Rows(0).Item("ID_sv")
                Ho_ten = IIf(IsDBNull(dt.Rows(0).Item("Ho_ten")), "", dt.Rows(0).Item("Ho_ten"))
                ID_dt = IIf(IsDBNull(dt.Rows(0).Item("ID_dt")), "", dt.Rows(0).Item("ID_dt"))
                Ten_lop = IIf(IsDBNull(dt.Rows(0).Item("Ten_lop")), "", dt.Rows(0).Item("Ten_lop"))
            Else
                ID_sv = ""
                Ho_ten = ""
                ID_dt = ""
                Ten_lop = ""
            End If

            ''Get theo thông tin ngành 2
            'If ID_dt = "0" Or ID_dt = "" Then ID_dt = clsDAL.getID_DT2_DiemExcel(ID_mon, Ma_sv)
            If ID_dt = "0" Then ID_dt = ""
        End Sub
        Private Sub AddRowTable(ByRef dt As DataTable, ByVal ID_sv As String, ByVal Ma_sv As String, ByVal Hoc_ky As Byte, ByVal Nam_hoc As String, ByVal Lan_thi As Byte, ByVal ID_dv As String, ByVal ID_mon As Long, ByVal ID_thanh_phan As Long, ByVal Ty_le As Byte, ByVal ESSDiem As String, ByVal Ghi_chu As String, ByVal ID_dt As String, ByVal Ho_ten As String, ByVal Ten_lop As String, ByVal Locked As Byte, ByVal ID_diem As Long, ByVal ID_diem_main As Long)
            dt.DefaultView.Sort = "ID_sv"
            If dt.DefaultView.Find(ID_sv) < 0 Then
                Dim dr As DataRow
                dr = dt.NewRow
                dr.Item("ID_sv") = ID_sv
                dr.Item("Ma_sv") = Ma_sv
                dr.Item("Hoc_ky") = Hoc_ky
                dr.Item("Nam_hoc") = Nam_hoc
                dr.Item("Lan_thi") = Lan_thi
                dr.Item("ID_dv") = ID_dv
                dr.Item("ID_mon") = ID_mon
                dr.Item("ID_thanh_phan") = ID_thanh_phan
                dr.Item("Ty_le") = Ty_le
                dr.Item("Diem") = ESSDiem
                dr.Item("Ghi_chu") = Ghi_chu
                dr.Item("ID_dt") = ID_dt
                dr.Item("Ho_ten") = Ho_ten
                dr.Item("Hoten_Order") = "" 'MappingToNumber(strUnicode, Ho_ten)
                dr.Item("Ten_lop") = Ten_lop
                dr.Item("Locked") = Locked
                dr.Item("ID_diem") = ID_diem
                dr.Item("ID_diem_main") = ID_diem_main
                dr.Item("Hoc_ky_TP") = Hoc_ky
                dr.Item("Nam_hoc_TP") = Nam_hoc
                dr.Item("Hoc_ky_thi") = Hoc_ky
                dr.Item("Nam_hoc_thi") = Nam_hoc


                dt.Rows.Add(dr)
                dt.AcceptChanges()
            End If
        End Sub

        Private Function getDiem_Sinhvien(ByVal ID_dv As String, ByVal ID_sv As Long, ByVal ID_mon As Long) As DataTable
            Dim cls As New Diem_DataAccess
            Return cls.getDiemSinhVien_DiemExcel(ID_sv, ID_mon, ID_dv)
        End Function
        Function getDiemTP_Sinhvien(ByVal ID_dv As String, ByVal ID_sv As Long, ByVal ID_mon As Long, ByVal ID_thanh_phan As Integer) As DataTable
            Dim cls As New Diem_DataAccess
            Return cls.getDiemThanhPhanSinhVien_DiemExcel(ID_sv, ID_mon, ID_thanh_phan, ID_dv)
        End Function
        Public Function HienThi_ESSDiemKyHieu_DanhSach() As DataTable
            Try
                Dim cls As New Diem_DataAccess
                Dim dt As DataTable = cls.HienThi_ESSDiemKyHieu_DanhSach
                'Bổ sung thêm một dòng trắng
                Dim dr As DataRow
                dr = dt.NewRow
                dr("Ky_hieu") = ""
                dt.Rows.Add(dr)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Check_DiemLanThi(ByVal Lan_thi As Integer, ByVal dt As DataTable) As String
            Dim Ly_do As String = ""
            For i As Integer = 0 To dt.Rows.Count - 1
                If Lan_thi = 2 Then
                    If dt.Rows(i).Item("Lan_thi") = 1 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then Ly_do = "Chưa có điểm thi lần 1"
                End If
                If Lan_thi = 3 Then
                    If dt.Rows(i).Item("Lan_thi") = 1 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then Ly_do = "Chưa có điểm thi lần 1"
                    If dt.Rows(i).Item("Lan_thi") = 2 AndAlso dt.Rows(i).Item("Diem_thi").ToString.Trim = "" Then
                        If Ly_do.Trim = "" Then
                            Ly_do = "Chưa có điểm thi lần 1"
                        Else
                            Ly_do = "Chưa có điểm thi lần 1 và lần 2"
                        End If
                    End If
                End If
            Next
            Return Ly_do
        End Function
        Public Sub CapNhat_ESSdata_Diem_SBD(ByVal dt_thi As DataTable, ByVal dt As DataTable, ByVal ID_dv As String, ByVal Hoc_ky As String, ByVal Nam_hoc As String, ByVal Lan_thi As Byte, _
                                                  ByVal ID_mon As Long, ByVal Field_SBD As String, ByVal FieldDiem As String, _
                                                  ByRef dtDiem_TonTai As DataTable, ByRef dtDiem_MoiTonTai As DataTable, ByRef dtDiem_Sai As DataTable, ByRef dtDiem_MoiChuan As DataTable, _
                                                   Optional ByVal ID_thanh_phan As Long = 0, Optional ByVal Ty_le As Long = 0)
            Dim i As Long
            Dim ID_sv_SBD, Ma_sv_SBD, Ho_ten_SBD, Ten_lop_SBD, ID_dt_SBD As String
            dtDiem_TonTai = NewTable()
            dtDiem_MoiTonTai = dtDiem_TonTai.Clone
            dtDiem_Sai = dtDiem_TonTai.Clone
            dtDiem_MoiChuan = dtDiem_TonTai.Clone
            dt.Columns.Add("Ma_sv_sbd", GetType(String))
            dt.Columns.Add("ID_dt_sbd", GetType(Integer))
            dt.Columns.Add("ID_sv_sbd", GetType(Integer))
            dt.Columns.Add("Ho_ten_sbd", GetType(String))
            dt.Columns.Add("Ten_lop_sbd", GetType(String))

            For t As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(t)(Field_SBD).ToString <> "" Then
                    dt_thi.DefaultView.RowFilter = "So_bao_danh=" & dt.Rows(t)(Field_SBD)
                    If dt_thi.DefaultView.Count > 0 Then
                        dt.Rows(t)("Ma_sv_sbd") = dt_thi.DefaultView.Item(0)("Ma_sv")
                        dt.Rows(t)("ID_dt_sbd") = dt_thi.DefaultView.Item(0)("ID_dt")
                        dt.Rows(t)("ID_sv_sbd") = dt_thi.DefaultView.Item(0)("ID_sv")
                        dt.Rows(t)("Ho_ten_sbd") = dt_thi.DefaultView.Item(0)("Ho_ten").ToString
                        dt.Rows(t)("Ten_lop_sbd") = dt_thi.DefaultView.Item(0)("Ten_lop").ToString
                    End If
                End If
            Next

            For i = 0 To dt.Rows.Count - 1
                With dt.Rows(i)
                    Ma_sv_SBD = .Item("Ma_sv_sbd").ToString
                    If Trim(Ma_sv_SBD) <> "" Then
                        ID_sv_SBD = .Item("ID_sv_sbd").ToString
                        ID_dt_SBD = .Item("ID_dt_sbd").ToString
                        Ho_ten_SBD = .Item("Ho_ten_sbd").ToString
                        Ten_lop_SBD = .Item("Ten_lop_sbd").ToString
                        If Trim(ID_sv_SBD) <> "" Then
                            Dim ESSDiem As String = IIf(IsDBNull(.Item(FieldDiem)), "", .Item(FieldDiem))
                            If Trim(ESSDiem) = "" Then 'Du lieu ESSDiem khong hop le, do chưa có điểm
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Chưa có điểm", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                End If
                            ElseIf Not IsNumeric(ESSDiem) Then 'Du lieu ESSDiem khong hop le do sai định dạng
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm phải là giá trị số", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                End If
                            ElseIf CType(ESSDiem, Double) > 10 Or CType(ESSDiem, Double) < 0 Then 'Du lieu ESSDiem khong hop le do sai khung điểm chuẩn
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm phải >=0 và <=10", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                End If
                            ElseIf ID_dt_SBD = "" Then 'Du lieu ESSDiem môn này không có trong CTrĐT của sinh viên
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Môn học này chưa có trong Chương trình đào tạo của sinh viên", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                End If
                            Else 'Du lieu ESSDiem hop le theo điểm thành phần
                                If ID_thanh_phan = 0 Then 'Khong co ESSDiem thanh phan
                                    Dim dt_checkDulieu_Tontai As DataTable = getDiem_Sinhvien(ID_dv, CType(ID_sv_SBD, Long), ID_mon)
                                    Dim f As Boolean = False
                                    For c As Integer = 0 To dt_checkDulieu_Tontai.Rows.Count - 1
                                        'Load tat ca cac lan ESSDiem; Co the chi ton tai ESSDiem Main con ESSDiem thi thi chua va nguoc lai
                                        If dt_checkDulieu_Tontai.Rows(c).Item("ID_diem").ToString.Trim <> "" Then f = True
                                    Next
                                    If dt_checkDulieu_Tontai.Rows.Count > 0 AndAlso f Then  'Đã tồn tại dữ liệu
                                        If Lan_thi = 2 Then
                                            'Kiem tra import ESSDiem Lan 2 ma chua co ESSDiem lan 1 thi canh bao => du lieu sai
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count = 0 Then 'Chua co ESSDiem thi Lan 1
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                    Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Chưa có điểm thi lần 1", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                                End If
                                            Else 'Dữ liệu ton tai hợp lý
                                                'dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                'dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=2"
                                                'If dt_checkDulieu_Tontai.DefaultView.Count > 0 AndAlso dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString.Trim <> "" Then
                                                '    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                '    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                '        Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                '        'Hien thi du lieu da co vao trong dtDiem_TonTai
                                                '        Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem_thi").ToString, "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                '    End If
                                                'End If

                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                                Dim ID_diem_main As Integer = 0
                                                If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then ID_diem_main = dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main")
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=2"
                                                If ID_diem_main > 0 Then 'Moi ton tai ESSDiem Main hoac ESSDiem Thanh phan chu' chua co ESSDiem thi
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, ID_diem_main)
                                                    End If
                                                Else 'Nhap moi hoan toan
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                                    End If
                                                End If
                                            End If
                                        ElseIf Lan_thi = 3 Then
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            'If drGoal.Item("Diem1").ToString.Trim = "" Or drGoal.Item("Diem2").ToString.Trim = "" Then
                                            '    'Kiem tra import ESSDiem Lan 3 ma chua co ESSDiem lan 1 va 2 thi canh bao => du lieu sai
                                            '    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Phải chuyển về điểm lần thi 1", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'Else 'Co ESSDiem lan 1 va ESSDiem lan 2
                                            '    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '        'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            '        Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, drGoal.Item("Diem_thi"), "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'End If
                                        ElseIf Lan_thi = 1 Then
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count > 0 AndAlso dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString.Trim <> "" Then
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiTonTai, ID_sv_SBD, Ma_sv_SBD, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                    'Hien thi du lieu da co vao trong dtDiem_TonTai
                                                    Call AddRowTable(dtDiem_TonTai, ID_sv_SBD, Ma_sv_SBD, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem_thi").ToString, "Dữ liệu điểm trong CSDL", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            End If
                                        End If

                                    Else 'Du lieu thanh cong
                                        If Lan_thi = 1 Then
                                            If dt_checkDulieu_Tontai.Rows.Count > 0 Then 'Moi ton tai ESSDiem Main hoac ESSDiem Thanh phan chu' chua co ESSDiem thi
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            Else 'Nhap moi hoan toan
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                                End If
                                            End If
                                        Else 'Vi du lieu chua ton tai ma lai chuyen vao ESSDiem lan 2 thi la du lieu Sai
                                            dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            If dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                                Call AddRowTable(dtDiem_Sai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Phải chuyển về điểm lần thi 1", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                            End If
                                        End If
                                    End If
                                Else 'Với điem thành phần
                                    Dim dt_checkDulieu_Tontai As DataTable
                                    dt_checkDulieu_Tontai = getDiemTP_Sinhvien(ID_dv, CType(ID_sv_SBD, Long), ID_mon, 0)
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "ID_thanh_phan=" & ID_thanh_phan
                                    If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then 'Điểm Main va thanh phan đã tồn tại trong CSDL
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv_SBD) < 0 Then
                                            Call AddRowTable(dtDiem_MoiTonTai, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                            'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            Call AddRowTable(dtDiem_TonTai, ID_sv_SBD, Ma_sv_SBD, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc"), Lan_thi, ID_dv, ID_mon, ID_thanh_phan, dt_checkDulieu_Tontai.DefaultView.Item(0)("Ty_le"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem"), "Dữ liệu điểm trong CSDL", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked_TP").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                        End If
                                    ElseIf dt_checkDulieu_Tontai.Rows.Count > 0 Then
                                        'Moi chi co ESSDiem thi hoac ESSDiem Main chu chua co ESSDiem thanh phan
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, dt_checkDulieu_Tontai.Rows(0).Item("ID_diem_main").ToString)
                                        End If
                                    Else 'Nhap moi
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv_SBD) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv_SBD) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv_SBD, Ma_sv_SBD, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt_SBD, Ho_ten_SBD, Ten_lop_SBD, 0, 0, 0)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End With
            Next
        End Sub

        Public Sub CapNhat_ESSdata(ByVal dt As DataTable, ByVal ID_dv As String, ByVal Hoc_ky As String, ByVal Nam_hoc As String, ByVal Lan_thi As Byte, _
                                              ByVal ID_mon As Long, ByVal FieldMa As String, ByVal FieldDiem As String, _
                                              ByRef dtDiem_TonTai As DataTable, ByRef dtDiem_MoiTonTai As DataTable, ByRef dtDiem_Sai As DataTable, ByRef dtDiem_MoiChuan As DataTable, _
                                               Optional ByVal ID_thanh_phan As Long = 0, Optional ByVal Ty_le As Long = 0)
            Dim i As Long
            Dim ID_sv, Ma_sv, Ho_ten, Ten_lop, ID_dt As String
            dtDiem_TonTai = NewTable()
            dtDiem_MoiTonTai = dtDiem_TonTai.Clone
            dtDiem_Sai = dtDiem_TonTai.Clone
            dtDiem_MoiChuan = dtDiem_TonTai.Clone

            For i = 0 To dt.Rows.Count - 1
                With dt.Rows(i)
                    Ma_sv = IIf(IsDBNull(.Item(FieldMa)), "", .Item(FieldMa))
                    If Trim(Ma_sv) <> "" Then
                        getThongtin_sinhvien(Ma_sv, ID_mon, ID_sv, Ho_ten, ID_dt, Ten_lop)
                        If Trim(ID_sv) <> "" Then
                            Dim ESSDiem As String = IIf(IsDBNull(.Item(FieldDiem)), "", .Item(FieldDiem))
                            If Trim(ESSDiem) = "" Then 'Du lieu ESSDiem khong hop le, do chưa có điểm
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Chưa có điểm", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf Not IsNumeric(ESSDiem) Then 'Du lieu ESSDiem khong hop le do sai định dạng
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm phải là giá trị số", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf CType(ESSDiem, Double) > 10 Or CType(ESSDiem, Double) < 0 Then 'Du lieu ESSDiem khong hop le do sai khung điểm chuẩn
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm phải >=0 và <=10", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            ElseIf ID_dt = "" Then 'Du lieu ESSDiem môn này không có trong CTrĐT của sinh viên
                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Môn học này chưa có trong Chương trình đào tạo của sinh viên", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                End If
                            Else 'Du lieu ESSDiem hop le theo điểm thành phần
                                If ID_thanh_phan = 0 Then 'Khong co ESSDiem thanh phan
                                    Dim dt_checkDulieu_Tontai As DataTable = getDiem_Sinhvien(ID_dv, CType(ID_sv, Long), ID_mon)
                                    Dim f As Boolean = False
                                    For c As Integer = 0 To dt_checkDulieu_Tontai.Rows.Count - 1
                                        'Load tat ca cac lan ESSDiem; Co the chi ton tai ESSDiem Main con ESSDiem thi thi chua va nguoc lai
                                        If dt_checkDulieu_Tontai.Rows(c).Item("ID_diem").ToString.Trim <> "" Then f = True
                                    Next
                                    If dt_checkDulieu_Tontai.Rows.Count > 0 AndAlso f Then  'Đã tồn tại dữ liệu
                                        If Lan_thi = 2 Then
                                            'Kiem tra import ESSDiem Lan 2 ma chua co ESSDiem lan 1 thi canh bao => du lieu sai
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count = 0 Then 'Chua co ESSDiem thi Lan 1
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Chưa có điểm thi lần 1", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                End If
                                            Else 'Dữ liệu ton tai hợp lý
                                                'dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                'dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=2"
                                                'If dt_checkDulieu_Tontai.DefaultView.Count > 0 AndAlso dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString.Trim <> "" Then
                                                '    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                '    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                '        Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                '        'Hien thi du lieu da co vao trong dtDiem_TonTai
                                                '        Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem_thi").ToString, "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                '    End If
                                                'End If

                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                                Dim ID_diem_main As Integer = 0
                                                If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then ID_diem_main = dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main")
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                                dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=2"
                                                If ID_diem_main > 0 Then 'Moi ton tai ESSDiem Main hoac ESSDiem Thanh phan chu' chua co ESSDiem thi
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, ID_diem_main)
                                                    End If
                                                Else 'Nhap moi hoan toan
                                                    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                        Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                    End If
                                                End If
                                            End If
                                        ElseIf Lan_thi = 3 Then
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            'dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            'If drGoal.Item("Diem1").ToString.Trim = "" Or drGoal.Item("Diem2").ToString.Trim = "" Then
                                            '    'Kiem tra import ESSDiem Lan 3 ma chua co ESSDiem lan 1 va 2 thi canh bao => du lieu sai
                                            '    dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Phải chuyển về điểm lần thi 1", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'Else 'Co ESSDiem lan 1 va ESSDiem lan 2
                                            '    dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                            '    dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            '    If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            '        Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '        'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            '        Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, 0, "", Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, drGoal.Item("Diem_thi"), "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop)
                                            '    End If
                                            'End If
                                        ElseIf Lan_thi = 1 Then
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                            dt_checkDulieu_Tontai.DefaultView.RowFilter = "Lan_thi=1"
                                            If dt_checkDulieu_Tontai.DefaultView.Count > 0 AndAlso dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString.Trim <> "" Then
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                    'Hien thi du lieu da co vao trong dtDiem_TonTai
                                                    Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc").ToString, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem_thi").ToString, "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            End If
                                        End If

                                    Else 'Du lieu thanh cong
                                        If Lan_thi = 1 Then
                                            If dt_checkDulieu_Tontai.Rows.Count > 0 Then 'Moi ton tai ESSDiem Main hoac ESSDiem Thanh phan chu' chua co ESSDiem thi
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                                End If
                                            Else 'Nhap moi hoan toan
                                                dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                                dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                                If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                                    Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                                End If
                                            End If
                                        Else 'Vi du lieu chua ton tai ma lai chuyen vao ESSDiem lan 2 thi la du lieu Sai
                                            dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                            dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                            If dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                                Call AddRowTable(dtDiem_Sai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Phải chuyển về điểm lần thi 1", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                            End If
                                        End If
                                    End If
                                Else 'Với điem thành phần
                                    Dim dt_checkDulieu_Tontai As DataTable
                                    dt_checkDulieu_Tontai = getDiemTP_Sinhvien(ID_dv, CType(ID_sv, Long), ID_mon, 0)
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "1=1"
                                    dt_checkDulieu_Tontai.DefaultView.RowFilter = "ID_thanh_phan=" & ID_thanh_phan
                                    If dt_checkDulieu_Tontai.DefaultView.Count > 0 Then 'Điểm Main va thanh phan đã tồn tại trong CSDL
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiChuan.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiChuan.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiTonTai, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu điểm đã có trong CSDL", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                            'Hien thi du lieu da co vao trong dtDiem_TonTai
                                            Call AddRowTable(dtDiem_TonTai, ID_sv, Ma_sv, dt_checkDulieu_Tontai.DefaultView.Item(0)("Hoc_ky"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Nam_hoc"), Lan_thi, ID_dv, ID_mon, ID_thanh_phan, dt_checkDulieu_Tontai.DefaultView.Item(0)("Ty_le"), dt_checkDulieu_Tontai.DefaultView.Item(0)("Diem"), "Dữ liệu điểm trong CSDL", ID_dt, Ho_ten, Ten_lop, dt_checkDulieu_Tontai.DefaultView.Item(0)("Locked_TP").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem").ToString, dt_checkDulieu_Tontai.DefaultView.Item(0)("ID_diem_main").ToString)
                                        End If
                                    ElseIf dt_checkDulieu_Tontai.Rows.Count > 0 Then
                                        'Moi chi co ESSDiem thi hoac ESSDiem Main chu chua co ESSDiem thanh phan
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, dt_checkDulieu_Tontai.Rows(0).Item("ID_diem_main").ToString)
                                        End If
                                    Else 'Nhap moi
                                        dtDiem_Sai.DefaultView.Sort = "ID_sv"
                                        dtDiem_MoiTonTai.DefaultView.Sort = "ID_sv"
                                        If dtDiem_Sai.DefaultView.Find(ID_sv) < 0 And dtDiem_MoiTonTai.DefaultView.Find(ID_sv) < 0 Then
                                            Call AddRowTable(dtDiem_MoiChuan, ID_sv, Ma_sv, Hoc_ky, Nam_hoc, Lan_thi, ID_dv, ID_mon, ID_thanh_phan, Ty_le, ESSDiem, "Dữ liệu phù hợp", ID_dt, Ho_ten, Ten_lop, 0, 0, 0)
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End With
            Next
        End Sub

        Public Sub TinhTBCMH_DiemChu(ByVal ID_diem As Integer, ByVal ESSDiemThi As Double, ByRef TBCMH As Double, ByRef Diem_chu As String)
            HienThi_ESSDiemQuyDoi()
            If ID_diem > 0 Then
                Dim clsDAL As New Diem_DataAccess
                Dim dt As DataTable = clsDAL.HienThi_ESSDiemTP(ID_diem)
                If dt.Rows.Count > 0 Then
                    Dim Tong_TyLe As Integer = 0
                    Dim TongDiem As Double = 0
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Tong_TyLe += dt.Rows(i).Item("Ty_le")
                        If dt.Rows(i).Item("Diem").ToString <> "" Then TongDiem += dt.Rows(i).Item("Ty_le") * dt.Rows(i).Item("Diem")
                    Next
                    TongDiem += ESSDiemThi * (100 - Tong_TyLe)
                    If TongDiem > 0 Then TBCMH = Math.Round(TongDiem / 100, 2)
                Else
                    TBCMH = Math.Round(ESSDiemThi, 2)
                End If
            Else
                TBCMH = Math.Round(ESSDiemThi, 2)
            End If
            Diem_chu = dsDiemQuyDoi.QuyDoiDiemChu(Math.Round(TBCMH + 0.00001, 2))
        End Sub
#End Region

#Region "Tổng hợp thi lại, học lại"
        Private Sub Doc_thamso_hethong()
            Try
                Dim cls As New ThamSoHeThong_Bussines
                LamTron_Diem_TongHop = cls.Doc_tham_so("LamTron_Diem_TongHop")
                Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
                So_lan_thi_lai = cls.Doc_tham_so("So_lan_thi_lai")
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Function DanhSach_ToChucThiLai(ByVal dtSub As DataTable) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            If dtSub Is Nothing Then
                Return dt
            Else
                Dim dr As DataRow
                For i As Integer = 0 To dtSub.DefaultView.Count - 1
                    dr = dt.NewRow
                    dr("ID_sv") = dtSub.DefaultView.Item(i)("ID_sv")
                    dr("Ma_sv") = dtSub.DefaultView.Item(i)("Ma_sv")
                    dr("Ho_ten") = dtSub.DefaultView.Item(i)("Ho_ten")
                    dr("Ngay_sinh") = dtSub.DefaultView.Item(i)("Ngay_sinh")
                    dr("Ten_lop") = dtSub.DefaultView.Item(i)("Ten_lop")
                    dr("Chon") = False
                    dt.Rows.Add(dr)
                Next
                Return dt
            End If
        End Function
        Function TongHopDiemThiLai(ByVal Trang_thai As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As DataTable
            Dim dt As DataTable = TongHopDiemThiLai_mon(Trang_thai)
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i).Item("So_sv") = TongHopDiemThiLai_ThieuDiem_SinhVien(dt.Rows(i).Item("ID_mon"), dt.Rows(i).Item("Khong_tinh_TBCHT"), Trang_thai, Hoc_ky, Nam_hoc).Rows.Count
            Next
            Return dt
        End Function




        Function TongHopDiemThiLai_ThieuDiem_SinhVien(ByVal ID_mon As Integer, ByVal ChungChi As Boolean, ByVal Trang_thai As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "") As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop, dt As New DataTable
            Dim idx_diem As Integer
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy

            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                idx_diem = Tim_idx(dtTongHop.Rows(i).Item("ID_sv"), ID_mon)
                If idx_diem >= 0 Then
                    Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                    Dim Diem_chu As String = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                    If Trang_thai = 0 Then
                        'If (ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, 2) And Check_KhongDuocThi(ESSDiem) = False) Or (ChungChi = True And ESSDiem.Thi_lai_monchungchi_SauLan1(Hoc_ky, Nam_hoc, 2)) Then
                        If (ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, 2) And Check_KhongDuocThi(ESSDiem) = False) Or (ChungChi = True And ESSDiem.Thi_lai_SauLan1(Hoc_ky, Nam_hoc, 2)) Then
                            dr = dt.NewRow()
                            dr("Chon") = False
                            dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                            dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                            dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                            If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                            dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                            dt.Rows.Add(dr)
                        End If
                    ElseIf Trang_thai = 1 Then 'Hoc lai
                        If ESSDiem.Hoc_lai(So_lan_thi_lai) Or (ChungChi = True And ESSDiem.Hoc_lai_monchungchi(So_lan_thi_lai)) Then 'Hoc lai
                            dr = dt.NewRow()
                            dr("Chon") = False
                            dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                            dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                            dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                            If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                            dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                            dt.Rows.Add(dr)
                        End If
                    ElseIf Trang_thai = 2 AndAlso ESSDiem.GhiChu_X(Hoc_ky, Nam_hoc) Then 'X- Thieu ESSDiem thi
                        dr = dt.NewRow()
                        dr("Chon") = False
                        dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                        dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                        dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                        If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                        dt.Rows.Add(dr)
                    ElseIf Trang_thai = 3 AndAlso ESSDiem.GhiChu_I(Hoc_ky, Nam_hoc) Then 'I- Thieu ESSDiem thanh phan
                        dr = dt.NewRow()
                        dr("Chon") = False
                        dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                        dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                        dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                        If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                        dt.Rows.Add(dr)
                    ElseIf Trang_thai = 4 AndAlso ESSDiem.GhiChu_R Then 'R- ESSDiem chuyen
                        dr = dt.NewRow()
                        dr("Chon") = False
                        dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                        dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                        dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                        If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                        dt.Rows.Add(dr)
                    ElseIf (Trang_thai = 6 Or Trang_thai = 7) AndAlso ESSDiem.Thi_nang_diem_SauLan1(Hoc_ky, Nam_hoc, 2) Then ' D - ESSDiem Sinh vien duoc thi nang ESSDiem
                        dr = dt.NewRow()
                        dr("Chon") = False
                        dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                        dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                        dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                        If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                        dt.Rows.Add(dr)
                    ElseIf Trang_thai = 10 Then
                        If (ESSDiem.Thi_lai_SauLan1_DiemDuoi5(Hoc_ky, Nam_hoc, 2) And Check_KhongDuocThi(ESSDiem) = False) Or (ChungChi = True And ESSDiem.Thi_lai_SauLan1_DiemDuoi5(Hoc_ky, Nam_hoc, 2)) Then
                            dr = dt.NewRow()
                            dr("Chon") = False
                            dr("ID_sv") = dtTongHop.Rows(i).Item("ID_sv")
                            dr("Ma_sv") = dtTongHop.Rows(i).Item("Ma_sv")
                            dr("Ho_ten") = dtTongHop.Rows(i).Item("Ho_ten")
                            If dtTongHop.Rows(i).Item("Ngay_sinh").ToString <> "" Then dr("Ngay_sinh") = dtTongHop.Rows(i).Item("Ngay_sinh")
                            dr("Ten_lop") = dtTongHop.Rows(i).Item("Ten_lop")
                            dt.Rows.Add(dr)
                        End If
                    End If
                End If
            Next
            Return dt
        End Function

        Private Function Check_KhongDuocThi(ByVal objDiem As ESSDiem, Optional ByVal Lan_thi As Integer = 0) As Boolean

            Dim ChuyenCan As Boolean = False
            Dim ID_thanh_phan As Integer = 0
            Dim idx1 As Integer = 0
            Dim TBCBP As Double = 0
            Dim TyLe As Integer = 0
            Dim str As String = ""
            Dim CoDiem As Boolean = False
            For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                If dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    ID_thanh_phan = dsThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                    'Tìm thành phần điểm theo ID_thanh_phan
                    idx1 = objDiem.dsDiemThanhPhan.Tim_idx(ID_thanh_phan, objDiem.Hoc_ky, objDiem.Nam_hoc)
                    'Lấy điểm thành phần theo ID_thanh_phan
                    If idx1 >= 0 Then
                        CoDiem = True
                        If dsThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can = False Then
                            TBCBP += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem * objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                            TyLe += objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                            If str = "" Then
                                str = objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem & "*" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                            Else
                                str += "+" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem & "*" & objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Ty_le
                            End If
                        ElseIf objDiem.dsDiemThanhPhan.ESSDiemThanhPhan(idx1).Diem = 0 Then
                            ChuyenCan = True
                        End If
                    End If
                End If
            Next
            If (TBCBP < 3 And CoDiem) Or ChuyenCan Then
                Return True
            Else
                Return False
            End If
        End Function

        Private Function TongHopDiemThiLai_mon(ByVal Trang_thai As Integer) As DataTable
            Doc_thamso_hethong()
            Dim dtTongHop, dt_mon As New DataTable
            Dim idx_diem As Integer, ID_mon As Integer
            Dim dr, dr_mon As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy

            dt_mon.Columns.Add("ID_mon", GetType(Integer))
            dt_mon.Columns.Add("Ten_mon", GetType(String))
            dt_mon.Columns.Add("Ky_hieu", GetType(String))
            dt_mon.Columns.Add("So_SV", GetType(Integer))
            dt_mon.Columns.Add("So_hoc_trinh", GetType(Integer))
            dt_mon.Columns.Add("Khong_tinh_TBCHT", GetType(Boolean))

            For Each dr In dtTongHop.Rows
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                    idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                    If idx_diem >= 0 Then
                        Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                        Dim Diem_chu As String = ESSDiem.dsDiemThi.Diem_chu_max(0, "")
                        If Trang_thai = 0 Then
                            If ESSDiem.Thi_lai_SauLan1(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, 2) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT AndAlso ESSDiem.Thi_lai_monchungchi_SauLan1(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc, 2)) Then
                                dt_mon.DefaultView.Sort = "ID_mon"
                                If dt_mon.DefaultView.Find(ID_mon) < 0 Then
                                    dr_mon = dt_mon.NewRow
                                    dr_mon("ID_mon") = ID_mon
                                    dr_mon("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr_mon("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr_mon("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr_mon("Khong_tinh_TBCHT") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT
                                    dt_mon.Rows.Add(dr_mon)
                                End If
                            End If
                        ElseIf Trang_thai = 1 Then
                            If ESSDiem.Hoc_lai(So_lan_thi_lai) Or (dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT And ESSDiem.Hoc_lai_monchungchi(So_lan_thi_lai)) Then 'Hoc lai
                                dt_mon.DefaultView.Sort = "ID_mon"
                                If dt_mon.DefaultView.Find(ID_mon) < 0 Then
                                    dr_mon = dt_mon.NewRow
                                    dr_mon("ID_mon") = ID_mon
                                    dr_mon("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                    dr_mon("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                    dr_mon("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr_mon("Khong_tinh_TBCHT") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT
                                    dt_mon.Rows.Add(dr_mon)
                                End If
                            End If
                        ElseIf Trang_thai = 2 AndAlso ESSDiem.GhiChu_X(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) Then 'X- Thieu ESSDiem thi
                            dt_mon.DefaultView.Sort = "ID_mon"
                            If dt_mon.DefaultView.Find(ID_mon) < 0 Then
                                dr_mon = dt_mon.NewRow
                                dr_mon("ID_mon") = ID_mon
                                dr_mon("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr_mon("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr_mon("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dr_mon("Khong_tinh_TBCHT") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT
                                dt_mon.Rows.Add(dr_mon)
                            End If
                        ElseIf Trang_thai = 3 AndAlso ESSDiem.GhiChu_I(ESSDiem.Hoc_ky, ESSDiem.Nam_hoc) Then 'I- Thieu ESSDiem thanh phan
                            dt_mon.DefaultView.Sort = "ID_mon"
                            If dt_mon.DefaultView.Find(ID_mon) < 0 Then
                                dr_mon = dt_mon.NewRow
                                dr_mon("ID_mon") = ID_mon
                                dr_mon("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr_mon("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr_mon("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dr_mon("Khong_tinh_TBCHT") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT
                                dt_mon.Rows.Add(dr_mon)
                            End If
                        ElseIf Trang_thai = 4 AndAlso ESSDiem.GhiChu_R() Then 'R- ESSDiem chuyen
                            dt_mon.DefaultView.Sort = "ID_mon"
                            If dt_mon.DefaultView.Find(ID_mon) < 0 Then
                                dr_mon = dt_mon.NewRow
                                dr_mon("ID_mon") = ID_mon
                                dr_mon("Ky_hieu") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ky_hieu
                                dr_mon("Ten_mon") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Ten_mon
                                dr_mon("So_hoc_trinh") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                dr_mon("Khong_tinh_TBCHT") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT
                                dt_mon.Rows.Add(dr_mon)
                            End If
                        End If
                    End If
                Next
            Next
            Return dt_mon
        End Function

        Function TongHop_ThiLai(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim dt As DataTable = clsDAL.HienThi_ESSTongHopThiLai_DanhSach(ID_dv, dsID_lop, Hoc_ky, Nam_hoc)
            Return dt
        End Function
#End Region

#Region "Diem nganh hoc thu 2"
        Private Sub HienThi_ESSThanhPhanMon_NganhHoc2(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal ID_dt As Integer)
            Dim dtThanhPhan As DataTable
            Dim clsDAL As New Diem_DataAccess
            Dim idx As Integer
            'Load các thành phần
            dtThanhPhan = clsDAL.HienThi_ESSThanhPhanMon()
            For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                Dim objThanhPhan As New ESSThanhPhanDiem
                objThanhPhan.ID_thanh_phan = dtThanhPhan.Rows(i)("ID_thanh_phan")
                objThanhPhan.STT = dtThanhPhan.Rows(i)("STT")
                objThanhPhan.Ky_hieu = dtThanhPhan.Rows(i)("Ky_hieu")
                objThanhPhan.Ten_thanh_phan = dtThanhPhan.Rows(i)("Ten_thanh_phan")
                objThanhPhan.Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                objThanhPhan.Chuyen_can = dtThanhPhan.Rows(i)("Chuyen_can")
                dsThanhPhanDiem.Add(objThanhPhan)
            Next
            dtThanhPhan = clsDAL.HienThi_ThanhPhanMon_NganhHoc2(ID_dv, Hoc_ky, Nam_hoc, ID_dt, ID_mon)

            If dtThanhPhan.Rows.Count > 0 Then
                'Bỏ chọn mặc định
                For i As Integer = 0 To dsThanhPhanDiem.Count - 1
                    dsThanhPhanDiem.ESSThanhPhanDiem(i).Checked = False
                Next
                'Check chọn theo thành phần đã chọn
                So_thanh_phan_chon = 0
                For i As Integer = 0 To dtThanhPhan.Rows.Count - 1
                    idx = dsThanhPhanDiem.Tim_idx(dtThanhPhan.Rows(i)("ID_thanh_phan"))
                    If idx >= 0 Then
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Ty_le = dtThanhPhan.Rows(i)("Ty_le")
                        dsThanhPhanDiem.ESSThanhPhanDiem(idx).Checked = True
                        So_thanh_phan_chon += 1
                    End If
                Next
            End If
        End Sub

        Private Sub HienThi_Diem_NganhHoc2(ByVal ID_dv As String, ByVal ID_dt As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_mon As Integer = 0)
            Dim clsDAL As New Diem_DataAccess 
            Dim dtDiem As DataTable
            Dim ID_diem As Integer = 0
            Dim objDiem As New ESSDiem
            'Lấy dữ liệu điểm thành phần và điểm thi
            dtDiem = clsDAL.HienThi_Diem_TongHop_NganhHoc2(ID_dv, ID_dt, Hoc_ky, Nam_hoc, ID_mon)
            If dtDiem.Rows.Count > 0 Then
                For idx_diem As Integer = 0 To dtDiem.Rows.Count - 1
                    If ID_diem <> dtDiem.Rows(idx_diem)("ID_diem") Then
                        If idx_diem > 0 Then arrDiem.Add(objDiem)
                        objDiem = New ESSDiem
                        objDiem = MappingDiem(dtDiem.Rows(idx_diem))
                        GoTo Add_diem
                    Else
Add_diem:
                        If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_tp").ToString) > 0 Then
                            'Add các điểm thành phần vào object Điểm thành phần
                            Dim objDiemTP As New ESSDiemThanhPhan
                            objDiemTP = MappingDiemThanhPhan(dtDiem.Rows(idx_diem))
                            If objDiem.dsDiemThanhPhan.Tim_idx(objDiemTP.ID_thanh_phan, objDiemTP.Hoc_ky_TP, objDiemTP.Nam_hoc_TP) = -1 Then
                                objDiem.dsDiemThanhPhan.Add(objDiemTP)
                            End If
                        End If
                        If CInt("0" + dtDiem.Rows(idx_diem)("ID_diem_thi").ToString) > 0 Then
                            'Add các điểm thi vào object Điểm thi
                            Dim objDiemThi As New ESSDiemThi
                            objDiemThi = MappingDiemThi(dtDiem.Rows(idx_diem))
                            If objDiem.dsDiemThi.idx_diem_thi(objDiemThi.Hoc_ky_thi, objDiemThi.Nam_hoc_thi, objDiemThi.Lan_thi) = -1 Then
                                objDiem.dsDiemThi.Add(objDiemThi)
                            End If
                        End If
                    End If
                    ID_diem = dtDiem.Rows(idx_diem)("ID_diem")
                Next
                If ID_diem > 0 Then
                    arrDiem.Add(objDiem)
                End If
            End If
        End Sub
#End Region
        Private Sub HienThi_ESSMonHocTrongDiem_NganhHoc2(ByVal ID_dv As String, ByVal ID_bm_chinh As Integer, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_dt As Integer = 0)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
            Dim fAdd As Boolean = False
            'Load các học phần thuộc các chương trình đào tạo
            dtMon = clsDAL.HienThi_ESSMonHocTrongDiem_NganhHoc2(ID_dv, ID_bm_chinh, Hoc_ky, Nam_hoc, ID_dt)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ESSChuongTrinhDaoTaoChiTiet
                'Kiểm tra xem có trùng môn không?
                fAdd = True
                For j As Integer = 0 To dsMonHoc.Count - 1
                    If dtMon.Rows(i)("ID_mon").ToString = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(j).ID_mon.ToString Then
                        fAdd = False
                    End If
                Next
                If fAdd Then
                    objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                    objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                    objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                    objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                    objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                    objCTDT.Nhom_tu_chon = dtMon.Rows(i)("Nhom_tu_chon")
                    objCTDT.Khong_tinh_TBCHT = dtMon.Rows(i)("Khong_tinh_TBCHT")
                    dsMonHoc.Add(objCTDT)
                End If
            Next
        End Sub

        Function Check_SinhVien_DangKy_TotNghiep(ByVal ID_lops As String) As DataTable
            Dim cls As New DanhSachTotNghiep_DataAccess
            Dim dt As DataTable = cls.Check_TotNghiep_SV_DangKy(ID_lops)
            Return dt
        End Function

        Public Function Update_Diem_ID_dt(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal ID_dt As Integer) As Integer
            Dim cls As New Diem_DataAccess
            Return cls.Update_Diem_ID_dt(ID_sv, ID_mon, ID_dt)
        End Function

        Private Function ConvertDiemDanh(ByVal dr As DataRow) As DiemDanh
            Dim objDiemDanh As New DiemDanh
            objDiemDanh.ID_diem = dr.Item("ID_diem")
            objDiemDanh.Hoc_ky_DD = dr.Item("Hoc_ky_DD")
            objDiemDanh.Nam_hoc_DD = dr.Item("Nam_hoc_DD")
            objDiemDanh.So_tiet_nghi_co_phep = dr.Item("So_tiet_nghi_co_phep")
            objDiemDanh.So_tiet_nghi_khong_phep = dr.Item("So_tiet_nghi_khong_phep")
            objDiemDanh.Thieu_bai_thuc_hanh = IIf(dr.Item("Thieu_bai_thuc_hanh").ToString = "", 0, dr.Item("Thieu_bai_thuc_hanh"))
            objDiemDanh.Ghi_chu = dr.Item("Ghi_chu").ToString
            objDiemDanh.Locked_dd = dr.Item("Locked_dd")
            Return objDiemDanh
        End Function

        Public Function ThemMoi_DiemDanh(ByVal ID_diem As Integer, ByVal objDiemDanh As DiemDanh) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.ThemMoi_DiemDanh(ID_diem, objDiemDanh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_DiemDanh(ByVal objDiemDanh As DiemDanh, ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.CapNhat_DiemDanh(objDiemDanh, ID_diem)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_DiemDanh(ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.Xoa_DiemDanh(ID_diem, Hoc_ky_DD, Nam_hoc_DD)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTraTonTai_DiemDanh(ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Return obj.KiemTraTonTai_DiemDanh(ID_diem, Hoc_ky_DD, Nam_hoc_DD)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSach_KDDKDT_TheoDiemDanh(ByVal ID_mon As Integer, ByVal ID_lop_tc As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As DataTable
            Try
                Dim obj As Diem_DataAccess = New Diem_DataAccess
                Dim dt As New DataTable
                dt = obj.DanhSach_KDDKDT_TheoDiemDanh(ID_mon, ID_lop_tc, Hoc_ky_DD, Nam_hoc_DD)
                dt.Columns.Add("Chon", GetType(Boolean))
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i)("Chon") = False
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        '-------------NEW---------------------
        Public Function XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Doc_thamso_hethong()
            Doc_tham_so_he_thong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem_TL As Double, So_TCTL_ToanKhoa As Double, So_TCTL_Ky As Double, So_TC_DiemF As Double
            Dim Diem_so As Double, TBCTL As Double ', TBC_TatCa
            Dim Tong_diem_ht As Double = 0
            Dim Tong_so_tin_chi_HT As Double = 0
            Dim So_TCN As Double = 0
            Dim TBCHT As Double = 0
            Dim TBHT_Ky_xet As Double = 0
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("So_TCTL", GetType(Integer))
            dtTongHop.Columns.Add("TBCTL", GetType(String))
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("TBCHT_Ky", GetType(String))
            dtTongHop.Columns.Add("So_TCHT", GetType(Integer))
            dtTongHop.Columns.Add("So_TCN", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            dtTongHop.Columns.Add("Ly_do_cac_ky", GetType(String))
            dtTongHop.Columns.Add("Xephang_Nam_daoTao", GetType(String))
            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                If dr("ID_SV") = 471861 Then
                    dr("ID_SV") = 471861
                End If
                'Add cac hoc ky va nam hoc
                Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
                Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
                Dim dt_ky As New DataTable
                dt_ky.Columns.Add("Hoc_ky", GetType(Integer))
                dt_ky.Columns.Add("Nam_hoc", GetType(String))
                dt_ky.Columns.Add("TBCHT_Ky", GetType(Double))
                For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
                    Dim dr_kh As DataRow
                    dr_kh = dt_ky.NewRow

                    If Nam_hoc = i & "-" & i + 1 Then
                        'Den nam va hoc ky xet thi exit
                        dr_kh("Hoc_ky") = 1
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                        If Hoc_ky = 2 Then
                            dr_kh = dt_ky.NewRow
                            dr_kh("Hoc_ky") = 2
                            dr_kh("Nam_hoc") = i & "-" & i + 1
                            dt_ky.Rows.Add(dr_kh)
                        End If
                        Exit For
                    Else
                        dr_kh("Hoc_ky") = 1
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                        dr_kh = dt_ky.NewRow
                        dr_kh("Hoc_ky") = 2
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                    End If
                Next

                'Tao dt de luu ESSDiem theo ky
                Dim dt_LuuDiemKy As New DataTable
                dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
                dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
                dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
                dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))

                '-------------------Tinh diem Toan khoa-------------------------
                TBCTL = 0
                Tong_diem_TL = 0
                So_TCTL_ToanKhoa = 0
                Tong_diem_ht = 0
                Tong_so_tin_chi_HT = 0
                So_TC_DiemF = 0

                Dim ID_dt As Integer = 0
                So_TC_DiemF = 0
                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon

                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx_hoc_ky(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            If ESSDiem.Tinh_tich_luy = False And dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Nhom_tu_chon > 0 Then
                                ESSDiem.Tinh_tich_luy = False
                            Else
                                'Chỉ tổng hợp những năm hiện tại
                                If ESSDiem.Nam_hoc <= Nam_hoc Then
                                    Diem_so = Math.Round(ESSDiem.dsDiemThi.Diem_so_max_TongHop + 0.00001, CType(Lam_tron_TBCMH, Integer))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_TongHop

                                    If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so > 0 Then
                                        Tong_diem_TL += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_TCTL_ToanKhoa += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    If Diem_so >= 0 Then
                                        Tong_so_tin_chi_HT += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_diem_ht += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    If ESSDiem.dsDiemThi.Diem_chu_max_TongHop = "F" Then
                                        So_TC_DiemF = So_TC_DiemF + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                End If
                            End If
                        End If
                    End If
                Next

                '----------------------- Tinh ESSDiem TBCHT ky-------------------------
                For j As Integer = 0 To dt_ky.Rows.Count - 1
                    'So_TCTL_Ky = 0
                    'Duyet cac mon hoc
                    For i As Integer = 0 To dsMonHoc.Count - 1
                        'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                        ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
                        If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                            ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                            'Tim ESSDiem cua sinh vien nay
                            idx_diem = Tim_idx_hoc_ky_XetLenLop(dr("ID_sv"), ID_mon, dt_ky.Rows(j)("Hoc_ky"), dt_ky.Rows(j)("Nam_hoc"))
                            'Nếu sinh viên có điểm môn học này thì tính điểm
                            If idx_diem >= 0 Then
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                'Chỉ tổng hợp những năm hiện tại
                                If ESSDiem.Nam_hoc <= Nam_hoc Then
                                    Diem_so = ESSDiem.dsDiemThi.Diem_So_max_KyNam(dt_ky.Rows(j)("Hoc_ky"), dt_ky.Rows(j)("Nam_hoc"))
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max_KyNam(dt_ky.Rows(j)("Hoc_ky"), dt_ky.Rows(j)("Nam_hoc"))

                                    'If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so > 0 Then
                                    '    So_TCTL_Ky += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    'End If

                                    'Luu vao dt nay de sau nay tinh ESSDiem Tich luy ky 
                                    If Diem_so > 0 Then
                                        Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
                                        dr_CheckKy("Hoc_ky") = dt_ky.Rows(j)("Hoc_ky")
                                        dr_CheckKy("Nam_hoc") = dt_ky.Rows(j)("Nam_hoc")
                                        dr_CheckKy("Diem") = Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        dr_CheckKy("So_TC") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        dt_LuuDiemKy.Rows.Add(dr_CheckKy)
                                    End If
                                End If
                            End If
                        End If
                    Next

                    Dim TBTL_Ky As Double = 0
                    Dim So_TC As Integer = 0
                    dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_ky.Rows(j).Item("Hoc_ky") & " And Nam_hoc='" & dt_ky.Rows(j).Item("Nam_hoc") & "'"
                    For i As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
                        TBTL_Ky += dt_LuuDiemKy.DefaultView.Item(i)("Diem")
                        So_TC += dt_LuuDiemKy.DefaultView.Item(i)("So_TC")
                    Next
                    If So_TC > 0 Then
                        TBTL_Ky = Math.Round(TBTL_Ky / So_TC + 0.000001, LamTron_Diem_TongHop)
                        dt_ky.Rows(j).Item("TBCHT_Ky") = TBTL_Ky
                        If dt_ky.Rows(j).Item("Hoc_ky") = Hoc_ky And dt_ky.Rows(j).Item("Nam_hoc") = Nam_hoc Then
                            TBHT_Ky_xet = TBTL_Ky
                        End If
                    Else
                        dt_ky.Rows(j).Item("TBCHT_Ky") = 0
                        TBHT_Ky_xet = 0
                    End If
                Next

                'Check thời gian hoàn thành chương trình đào tạo
                Dim Ly_do As String = ""
                Dim Ly_do_cac_ky As String = ""
                Dim cls As ChuongTrinhDaoTao_Bussines
                cls = New ChuongTrinhDaoTao_Bussines(dr("ID_dt"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1

                If So_ky_ToiDa < So_ky_hienTai Then Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa & vbCrLf
                'Check Học kỳ
                For i As Integer = 0 To dt_ky.Rows.Count - 1
                    '-	Học kỳ đầu TBCTL < 0.8
                    Dim NamHoc As Integer = CType(Left(dt_ky.Rows(i).Item("Nam_hoc"), 4), Integer)
                    If (NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 1) AndAlso KyDau_TBCTL_Active AndAlso dt_ky.Rows(i).Item("TBCHT_Ky") < KyDau_TBCTL AndAlso ((Left(Nam_hoc, 4) = NienKhoa_Dau And Hoc_ky = 1)) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",HK đầu khoá có TBCHT kỳ < " & KyDau_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "HK đầu khoá học có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyDau_TBCTL.ToString & vbCrLf
                        End If
                    End If
                    If dt_ky.Rows(i).Item("Hoc_ky") = Hoc_ky And dt_ky.Rows(i).Item("Nam_Hoc") = Nam_hoc And dt_ky.Rows(i).Item("TBCHT_Ky") < 1 Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",HK " & dt_ky.Rows(i).Item("Nam_hoc").ToString.Substring(2, 2) & "." & dt_ky.Rows(i).Item("Hoc_Ky") & " có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & KyBatKy_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "HK bất kỳ " & dt_ky.Rows(i).Item("Nam_hoc").ToString.Substring(2, 2) & "." & dt_ky.Rows(i).Item("Hoc_Ky") & " có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyBatKy_TBCTL & vbCrLf
                        End If
                    End If
                Next
                'Tính điểm TBC tich luy và xếp loại
                Dim Xephang_Namdaotao As Integer = 0
                Xephang_Namdaotao = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_TCTL_ToanKhoa)
                If So_TCTL_ToanKhoa > 0 Then
                    TBCTL = Math.Round(Tong_diem_TL / So_TCTL_ToanKhoa + 0.000001, LamTron_Diem_TongHop)
                    'TBC_TatCa = Math.Round(Tong_diem_TL / Tong_so_tin_chi + 0.000001, LamTron_Diem_TongHop)

                    If NamXet_TBCHT_Active AndAlso TBCTL < NamXet_TBCHT Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ", Năm xét có TBCHT là " & TBCTL & "< " & NamXet_TBCHT.ToString & vbCrLf
                        Else
                            Ly_do = " Năm xét có TBCHT là " & TBCTL & "< " & NamXet_TBCHT.ToString & vbCrLf
                        End If
                    End If
                    'Với năm học
                    If (Xephang_Namdaotao = 1 AndAlso NamDau_TBCTL_Active AndAlso TBCTL < NamDau_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString & vbCrLf
                        End If
                    End If
                    If (Xephang_Namdaotao = 2 AndAlso NamThu2_TBCTL_Active AndAlso TBCTL < NamThu2_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString & vbCrLf
                        End If
                    End If
                    If (Xephang_Namdaotao = 3 AndAlso NamThu3_TBCTL_Active AndAlso TBCTL < NamThu3_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString & vbCrLf
                        End If
                    End If
                    If (Xephang_Namdaotao >= 4 AndAlso TuNamThu4_TBCTL_Active AndAlso TBCTL < TuNamThu4_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString & vbCrLf
                        Else
                            Ly_do = "từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString & vbCrLf
                        End If
                    End If
                    If So_TC_DiemF > 24 Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ", HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép" & vbCrLf
                        Else
                            Ly_do = " HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép" & vbCrLf
                        End If
                    End If
                Else
                    Ly_do = "TBC tích luỹ là 0"
                End If
                If Tong_diem_ht > 0 Then
                    TBCHT = Math.Round(Tong_diem_ht / Tong_so_tin_chi_HT + 0.00001, LamTron_Diem_TongHop)
                End If
                dr("So_TCTL") = So_TCTL_ToanKhoa
                dr("TBCTL") = TBCTL
                dr("TBCHT_Ky") = TBHT_Ky_xet
                dr("TBCHT") = TBCHT
                dr("So_TCHT") = Tong_so_tin_chi_HT
                dr("Ly_do") = Ly_do
                dr("So_TCN") = So_TC_DiemF
                dr("Xephang_Nam_daoTao") = Xephang_Namdaotao
            Next
            'dtTongHop.DefaultView.RowFilter = "Ly_do<>''"
            Return dtTongHop
        End Function
        
        Public Sub XetLenLop_TongHop_DanhSach(ByRef mdt_canhbao1 As DataTable, ByRef mdt_canhbao2 As DataTable, ByRef mdt_canhbao3 As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer)
            Dim cls As New DanhSachXetLenLop_Bussines
            Dim dt_danhsach As DataTable = cls.DanhSach_DaXetThoiHoc(ID_he, Khoa_hoc, ID_chuyen_nganh)
            Dim dt_CanhBao1, dt_CanhBao2, dt_CanhBao3 As New DataTable
            dt_CanhBao3.Columns.Add("Chon", GetType(Boolean))
            dt_CanhBao3.Columns.Add("ID_SV", GetType(Integer))
            dt_CanhBao3.Columns.Add("Ma_sv", GetType(String))
            dt_CanhBao3.Columns.Add("Ho_ten", GetType(String))
            dt_CanhBao3.Columns.Add("Ten_lop", GetType(String))
            dt_CanhBao3.Columns.Add("Hoc_ky1", GetType(Integer))
            dt_CanhBao3.Columns.Add("Nam_hoc1", GetType(String))
            dt_CanhBao3.Columns.Add("Ly_do1", GetType(String))
            dt_CanhBao3.Columns.Add("Hoc_ky2", GetType(Integer))
            dt_CanhBao3.Columns.Add("Nam_hoc2", GetType(String))
            dt_CanhBao3.Columns.Add("Ly_do2", GetType(String))
            dt_CanhBao3.Columns.Add("Hoc_ky3", GetType(Integer))
            dt_CanhBao3.Columns.Add("Nam_hoc3", GetType(String))
            dt_CanhBao3.Columns.Add("Ly_do3", GetType(String))
            dt_CanhBao1 = dt_CanhBao3.Clone
            dt_CanhBao2 = dt_CanhBao3.Clone
            Dim Ma_sv, Ho_ten, Ten_lop As String
            Dim Ly_do1, Ly_do2, Ly_do3 As String
            Dim Hoc_ky1, Hoc_ky2, Hoc_ky3 As Integer
            Dim Nam_hoc1, Nam_hoc2, Nam_hoc3 As String
            Dim ID_SV As Integer = 0

            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            For i As Integer = 0 To dt_danhsach.Rows.Count - 1
                Dim dt_sv As DataTable = cls.DanhSach_CacLanCanhBao_SinhVien(dt_danhsach.Rows(i)("ID_SV"), Nam_hoc)
                If dt_sv.Rows.Count > 0 Then
                    Dim CanhBao1 As Boolean = False
                    Dim CanhBao2 As Boolean = False
                    Dim CanhBao3 As Boolean = False
                    ID_SV = dt_sv.Rows(0)("ID_SV")
                    If ID_SV = 18226 Then
                        ID_SV = 18226
                    End If
                    ID_SV = dt_sv.Rows(0)("ID_SV")
                    Ma_sv = dt_sv.Rows(0)("Ma_SV")
                    Ho_ten = dt_sv.Rows(0)("Ho_ten")
                    Ten_lop = dt_sv.Rows(0)("Ten_lop")

                    If dt_sv.Rows.Count > 3 Then
                        'Neu 3 ky lien nhau deu bi thi Thoi hoc
                        If CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam Then
                            If Hoc_ky = 2 Then
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                    CanhBao1 = True
                                    Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                    Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                    Ly_do1 = dt_sv.Rows(0)("Ly_do")
                                End If
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 1 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If
                                    End If
                                End If
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 2 Then
                                        If CanhBao2 And CanhBao1 Then
                                            CanhBao3 = True
                                            Hoc_ky3 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc3 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do3 = dt_sv.Rows(2)("Ly_do")
                                        ElseIf CanhBao1 Or CanhBao2 Then
                                            CanhBao1 = True
                                            Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                        End If
                                    End If
                                End If
                                If CType(Left(dt_sv.Rows(3)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(3)("Hoc_ky") = 1 Then
                                        If CanhBao1 = False And CanhBao3 = False Then
                                            CanhBao2 = False
                                        End If
                                    End If
                                End If
                            Else 'La ky 1
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                    CanhBao1 = True
                                    Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                    Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                    Ly_do1 = dt_sv.Rows(0)("Ly_do")
                                End If
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If
                                    End If
                                End If
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 1 Then
                                        If CanhBao2 And CanhBao1 Then
                                            CanhBao3 = True
                                            Hoc_ky3 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc3 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do3 = dt_sv.Rows(2)("Ly_do")
                                        ElseIf CanhBao1 Or CanhBao2 Then
                                            CanhBao1 = True
                                            Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                        End If
                                    End If
                                End If
                                If CType(Left(dt_sv.Rows(3)("Nam_hoc"), 4), Integer) = Nam - 2 Then
                                    If dt_sv.Rows(3)("Hoc_ky") = 2 Then
                                        If CanhBao1 = False And CanhBao3 = False Then CanhBao2 = False
                                    End If
                                End If
                            End If
                        ElseIf CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                            If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 1 Then
                                        CanhBao1 = True
                                        Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                        Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                        Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                    End If
                                    If CType(Left(dt_sv.Rows(3)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                        If dt_sv.Rows(3)("Hoc_ky") = 2 Then
                                            If CanhBao1 Then CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(3)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(3)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(3)("Ly_do")
                                        End If
                                    End If
                                End If
                            ElseIf dt_sv.Rows(1)("Hoc_ky") = 1 Then
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 2 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 2 Then
                                        CanhBao1 = True
                                        Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                        Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                        Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                    End If
                                    If CType(Left(dt_sv.Rows(3)("Nam_hoc"), 4), Integer) = Nam - 2 Then
                                        If dt_sv.Rows(3)("Hoc_ky") = 1 Then
                                            If CanhBao1 Then CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(3)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(3)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(3)("Ly_do")
                                        End If
                                    End If
                                End If
                            End If
                        End If
                        'Neu trong 3 ky lien ma co 1 ky ko bi thi Canh cao lan 1
                    ElseIf dt_sv.Rows.Count = 3 Then
                        If CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam Then
                            If Hoc_ky = 2 Then
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                    CanhBao1 = True
                                    Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                    Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                    Ly_do1 = dt_sv.Rows(0)("Ly_do")
                                End If
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 1 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If
                                    End If
                                ElseIf CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        Else
                                            CanhBao1 = True
                                        End If
                                    Else
                                        If CanhBao1 Then
                                            CanhBao1 = False
                                        End If
                                    End If
                                End If

                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 2 Then
                                        If CanhBao2 And CanhBao1 Then
                                            CanhBao3 = True
                                            Hoc_ky3 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc3 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do3 = dt_sv.Rows(2)("Ly_do")
                                        ElseIf CanhBao1 Or CanhBao2 Then
                                            CanhBao1 = True
                                        End If
                                    Else
                                        If CanhBao1 Then
                                            CanhBao1 = False
                                        End If
                                    End If
                                End If
                            Else 'La ky 1
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then CanhBao1 = True
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If
                                    End If
                                End If
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 1 Then
                                        If CanhBao2 And CanhBao1 Then
                                            CanhBao3 = True
                                            Hoc_ky3 = dt_sv.Rows(2)("Hoc_ky")
                                            Nam_hoc3 = dt_sv.Rows(2)("Nam_hoc")
                                            Ly_do3 = dt_sv.Rows(2)("Ly_do")
                                        ElseIf CanhBao1 Or CanhBao2 Then
                                            CanhBao1 = True
                                        End If
                                    End If
                                End If
                            End If
                        ElseIf CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                            If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 1 Then
                                        CanhBao1 = True
                                        Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                        Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                        Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                    End If
                                End If
                            ElseIf dt_sv.Rows(1)("Hoc_ky") = 1 Then
                                If CType(Left(dt_sv.Rows(2)("Nam_hoc"), 4), Integer) = Nam - 2 Then
                                    If dt_sv.Rows(2)("Hoc_ky") = 2 Then
                                        CanhBao1 = True
                                        Hoc_ky1 = dt_sv.Rows(2)("Hoc_ky")
                                        Nam_hoc1 = dt_sv.Rows(2)("Nam_hoc")
                                        Ly_do1 = dt_sv.Rows(2)("Ly_do")
                                    End If
                                End If
                            End If
                        End If
                    ElseIf dt_sv.Rows.Count = 2 Then
                        If CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam Then
                            If Hoc_ky = 2 Then
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                    CanhBao1 = True
                                    Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                    Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                    Ly_do1 = dt_sv.Rows(0)("Ly_do")
                                End If
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 1 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If
                                    End If
                                End If
                            Else 'La ky 1
                                If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                    CanhBao1 = True
                                    Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                    Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                    Ly_do1 = dt_sv.Rows(0)("Ly_do")
                                End If
                                If CType(Left(dt_sv.Rows(1)("Nam_hoc"), 4), Integer) = Nam - 1 Then
                                    If dt_sv.Rows(1)("Hoc_ky") = 2 Then
                                        If CanhBao1 Then
                                            CanhBao2 = True
                                            Hoc_ky2 = dt_sv.Rows(1)("Hoc_ky")
                                            Nam_hoc2 = dt_sv.Rows(1)("Nam_hoc")
                                            Ly_do2 = dt_sv.Rows(1)("Ly_do")
                                        End If

                                    End If
                                End If
                            End If
                        End If
                    ElseIf dt_sv.Rows.Count = 1 Then
                        If CType(Left(dt_sv.Rows(0)("Nam_hoc"), 4), Integer) = Nam Then
                            If dt_sv.Rows(0)("Hoc_ky") = Hoc_ky Then
                                CanhBao1 = True
                                Hoc_ky1 = dt_sv.Rows(0)("Hoc_ky")
                                Nam_hoc1 = dt_sv.Rows(0)("Nam_hoc")
                                Ly_do1 = dt_sv.Rows(0)("Ly_do")
                            End If
                        End If
                    End If

                    Dim dr As DataRow

                    If CanhBao3 Then
                        dr = dt_CanhBao3.NewRow
                        dr("Chon") = False
                        dr("ID_SV") = ID_SV
                        dr("Ma_sv") = Ma_sv
                        dr("Ho_ten") = Ho_ten
                        dr("Ten_lop") = Ten_lop
                        dr("Ly_do1") = Ly_do1
                        dr("Hoc_ky1") = Hoc_ky1
                        dr("Nam_hoc1") = Nam_hoc1

                        dr("Ly_do2") = Ly_do2
                        dr("Hoc_ky2") = Hoc_ky2
                        dr("Nam_hoc2") = Nam_hoc2

                        dr("Ly_do3") = Ly_do3
                        dr("Hoc_ky3") = Hoc_ky3
                        dr("Nam_hoc3") = Nam_hoc3
                        dt_CanhBao3.Rows.Add(dr)
                    ElseIf CanhBao2 Then
                        dr = dt_CanhBao2.NewRow
                        dr("Chon") = False
                        dr("ID_SV") = ID_SV
                        dr("Ma_sv") = Ma_sv
                        dr("Ho_ten") = Ho_ten
                        dr("Ten_lop") = Ten_lop
                        dr("Ly_do1") = Ly_do1
                        dr("Hoc_ky1") = Hoc_ky1
                        dr("Nam_hoc1") = Nam_hoc1

                        dr("Ly_do2") = Ly_do2
                        dr("Hoc_ky2") = Hoc_ky2
                        dr("Nam_hoc2") = Nam_hoc2
                        dt_CanhBao2.Rows.Add(dr)
                    ElseIf CanhBao1 Then
                        dr = dt_CanhBao1.NewRow
                        dr("Chon") = False
                        dr("ID_SV") = ID_SV
                        dr("Ma_sv") = Ma_sv
                        dr("Ho_ten") = Ho_ten
                        dr("Ten_lop") = Ten_lop
                        dr("Ly_do1") = Ly_do1
                        dr("Hoc_ky1") = Hoc_ky1
                        dr("Nam_hoc1") = Nam_hoc1
                        dt_CanhBao1.Rows.Add(dr)
                    End If
                End If
            Next

            mdt_canhbao1 = dt_CanhBao1.Copy
            mdt_canhbao2 = dt_CanhBao2.Copy
            mdt_canhbao3 = dt_CanhBao3.Copy
        End Sub

        Public Function XetLenLop_ThoiHoc(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal mID_lops As String) As DataTable
            Dim DM As New DanhMuc_Bussines
            Dim dt_daXet As DataTable = DM.LoadDanhMuc("SELECT ID_SV FROM Mark_XetLenLop WHERE Lan_canh_bao=" & Lan_canh_bao & " AND ID_sv in (SELECT ID_sv FROM STU_DanhSach WHERE ID_lop in (" & mID_lops & "))")

            Doc_thamso_hethong()
            Doc_tham_so_he_thong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, So_TCTL As Double, So_TC_DiemF As Double
            Dim Diem_so As Double, TBCTL, TBC_TatCa As Double
            Dim Tong_diem_ht As Double = 0
            Dim Tong_so_tin_chi As Integer = 0
            Dim TBCHT As Double = 0
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("So_TCTL", GetType(Integer))
            dtTongHop.Columns.Add("TBCTL", GetType(String))
            dtTongHop.Columns.Add("TBCHT_Ky", GetType(String))
            dtTongHop.Columns.Add("So_TCHT", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            dtTongHop.Columns.Add("Xephang_Nam_daoTao", GetType(String))
            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                dt_daXet.DefaultView.RowFilter = "ID_SV" = dr("ID_SV")
                If dt_daXet.DefaultView.Count > 0 Then
                    'Add cac hoc ky va nam hoc
                    Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
                    Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
                    Dim dt_ky As New DataTable
                    dt_ky.Columns.Add("Hoc_ky", GetType(Integer))
                    dt_ky.Columns.Add("Nam_hoc", GetType(String))
                    dt_ky.Columns.Add("TBCHT_Ky", GetType(Double))
                    For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
                        Dim dr_kh As DataRow
                        dr_kh = dt_ky.NewRow

                        If Nam_hoc = i & "-" & i + 1 Then
                            'Den nam va hoc ky xet thi exit
                            dr_kh("Hoc_ky") = 1
                            dr_kh("Nam_hoc") = i & "-" & i + 1
                            dt_ky.Rows.Add(dr_kh)
                            If Hoc_ky = 2 Then
                                dr_kh = dt_ky.NewRow
                                dr_kh("Hoc_ky") = 2
                                dr_kh("Nam_hoc") = i & "-" & i + 1
                                dt_ky.Rows.Add(dr_kh)
                            End If
                            Exit For
                        Else
                            dr_kh("Hoc_ky") = 1
                            dr_kh("Nam_hoc") = i & "-" & i + 1
                            dt_ky.Rows.Add(dr_kh)
                            dr_kh = dt_ky.NewRow
                            dr_kh("Hoc_ky") = 2
                            dr_kh("Nam_hoc") = i & "-" & i + 1
                            dt_ky.Rows.Add(dr_kh)
                        End If
                    Next

                    'Tao dt de luu ESSDiem theo ky
                    Dim dt_LuuDiemKy As New DataTable
                    dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
                    dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
                    dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
                    dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))


                    Tong_diem = 0
                    So_TCTL = 0
                    Tong_so_tin_chi = 0
                    TBCTL = 0
                    TBCHT = 0
                    Tong_diem_ht = 0
                    TBC_TatCa = 0
                    Dim ID_dt As Integer = 0
                    So_TC_DiemF = 0
                    'Duyet cac mon hoc
                    For i As Integer = 0 To dsMonHoc.Count - 1
                        'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                        ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
                        If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                            ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                            'Tim ESSDiem cua sinh vien nay
                            idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                            'Nếu sinh viên có điểm môn học này thì tính điểm
                            If idx_diem >= 0 Then
                                Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                                'Chỉ tổng hợp những năm hiện tại
                                If ESSDiem.Nam_hoc <= Nam_hoc Then
                                    Diem_so = ESSDiem.dsDiemThi.Diem_so_max()
                                    Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                    'Tính điểm tích luỹ
                                    'Tính số tín chỉ tích luỹ
                                    If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so >= 0 Then
                                        Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        So_TCTL += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If

                                    '************************
                                    'Luu vao dt nay de sau nay tinh ESSDiem Tich luy ky 
                                    If Diem_so >= 0 Then
                                        Tong_so_tin_chi += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        Tong_diem_ht += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                        Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
                                        dr_CheckKy("Hoc_ky") = ESSDiem.Hoc_ky
                                        dr_CheckKy("Nam_hoc") = ESSDiem.Nam_hoc
                                        dr_CheckKy("Diem") = Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        dr_CheckKy("So_TC") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                        dt_LuuDiemKy.Rows.Add(dr_CheckKy)
                                    End If
                                    If ESSDiem.dsDiemThi.Diem_chu_max_TongHop = "F" Then
                                        So_TC_DiemF = So_TC_DiemF + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    End If
                                    'End If
                                End If
                            End If
                        End If
                    Next


                    ' Tinh ESSDiem TBCHT ky
                    For j As Integer = 0 To dt_ky.Rows.Count - 1
                        Dim TBTL_Ky As Double = 0
                        Dim So_TC As Integer = 0
                        dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_ky.Rows(j).Item("Hoc_ky") & " And Nam_hoc='" & dt_ky.Rows(j).Item("Nam_hoc") & "'"
                        For i As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
                            TBTL_Ky += dt_LuuDiemKy.DefaultView.Item(i)("Diem")
                            So_TC += dt_LuuDiemKy.DefaultView.Item(i)("So_TC")
                        Next

                        If So_TC > 0 Then
                            TBTL_Ky = Math.Round(TBTL_Ky / So_TC + 0.000001, LamTron_Diem_TongHop)
                            dt_ky.Rows(j).Item("TBCHT_Ky") = TBTL_Ky
                        Else
                            dt_ky.Rows(j).Item("TBCHT_Ky") = 0
                        End If
                    Next

                    'Check thời gian hoàn thành chương trình đào tạo
                    Dim Ly_do As String = ""
                    Dim cls As ChuongTrinhDaoTao_Bussines
                    cls = New ChuongTrinhDaoTao_Bussines(dr("ID_dt"))
                    Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
                    Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                    If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1

                    If So_ky_ToiDa < So_ky_hienTai Then Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa

                    'Check Học kỳ
                    For i As Integer = 0 To dt_ky.Rows.Count - 1
                        '-	Học kỳ đầu TBCTL < 0.8
                        Dim NamHoc As Integer = CType(Left(dt_ky.Rows(i).Item("Nam_hoc"), 4), Integer)
                        If (NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 1) AndAlso KyDau_TBCTL_Active AndAlso dt_ky.Rows(i).Item("TBCHT_Ky") < KyDau_TBCTL Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",HK đầu khoá có TBCHT kỳ < " & KyDau_TBCTL.ToString
                            Else
                                Ly_do = "HK đầu khoá học có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyDau_TBCTL.ToString
                            End If
                        End If

                        'Kiem tra Ky bat ky <1
                        If KyBatKy_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < KyBatKy_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",HK " & dt_ky.Rows(i).Item("Nam_hoc").ToString.Substring(2, 2) & "." & dt_ky.Rows(i).Item("Hoc_Ky") & " có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & KyBatKy_TBCTL.ToString
                            Else
                                Ly_do = "HK bất kỳ " & dt_ky.Rows(i).Item("Nam_hoc").ToString.Substring(2, 2) & "." & dt_ky.Rows(i).Item("Hoc_Ky") & " có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyBatKy_TBCTL
                            End If
                        End If
                    Next

                    'Tính điểm TBC tich luy và xếp loại
                    Dim Xephang_Namdaotao As Integer = 0
                    Xephang_Namdaotao = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(So_TCTL)
                    If So_TCTL > 0 Then
                        TBCTL = Math.Round(Tong_diem / So_TCTL + 0.000001, LamTron_Diem_TongHop)
                        TBC_TatCa = Math.Round(Tong_diem / Tong_so_tin_chi + 0.000001, LamTron_Diem_TongHop)

                        If NamXet_TBCHT_Active AndAlso TBC_TatCa < NamXet_TBCHT Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ", Năm xét có TBCHT là " & TBC_TatCa & "< " & NamXet_TBCHT.ToString
                            Else
                                Ly_do = " Năm xét có TBCHT là " & TBC_TatCa & "< " & NamXet_TBCHT.ToString
                            End If
                        End If

                        'Với năm học
                        If (Xephang_Namdaotao = 1 AndAlso NamDau_TBCTL_Active AndAlso TBCTL < NamDau_TBCTL) Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
                            Else
                                Ly_do = "Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
                            End If
                        End If
                        If (Xephang_Namdaotao = 2 AndAlso NamThu2_TBCTL_Active AndAlso TBCTL < NamThu2_TBCTL) Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
                            Else
                                Ly_do = "Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
                            End If
                        End If
                        If (Xephang_Namdaotao = 3 AndAlso NamThu3_TBCTL_Active AndAlso TBCTL < NamThu3_TBCTL) Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
                            Else
                                Ly_do = "Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
                            End If
                        End If

                        If (Xephang_Namdaotao >= 4 AndAlso TuNamThu4_TBCTL_Active AndAlso TBCTL < TuNamThu4_TBCTL) Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
                            Else
                                Ly_do = "từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
                            End If
                        End If

                        If So_TC_DiemF > 24 Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ", HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép"
                            Else
                                Ly_do = " HP bị điểm F tồn đọng " & So_TC_DiemF & ">24 Tín chỉ cho phép"
                            End If
                        End If
                    Else
                        Ly_do = "TBC tích luỹ là 0"
                    End If
                    If Tong_diem_ht > 0 Then
                        TBCHT = Math.Round(Tong_diem_ht / Tong_so_tin_chi + 0.00001, LamTron_Diem_TongHop)
                    End If
                    dr("So_TCTL") = So_TCTL
                    dr("TBCTL") = TBCTL
                    dr("TBCHT_Ky") = TBCHT
                    dr("So_TCHT") = Tong_so_tin_chi
                    dr("Ly_do") = Ly_do
                    dr("Xephang_Nam_daoTao") = Xephang_Namdaotao
                End If
            Next
            dtTongHop.DefaultView.RowFilter = "Ly_do<>''"
            Return dtTongHop
        End Function

        Public Function XetLenLop_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Doc_thamso_hethong()
            Doc_tham_so_he_thong()
            Dim dtTongHop As New DataTable
            Dim Diem_chu As String
            Dim idx_diem As Integer, ID_mon As Integer
            Dim Tong_diem As Double, Tong_so_hoc_trinh As Integer
            Dim Diem_so As Double, TBCTL As Double
            Dim Tong_diem_ht As Double = 0
            Dim Tong_so_tin_chi As Integer = 0
            Dim TBCHT As Double = 0
            Dim dr As DataRow
            dtTongHop = mdtDanhSachSinhVien.Copy
            dtTongHop.Columns.Add("Tong_so_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("TBCTL", GetType(String))
            dtTongHop.Columns.Add("TBCHT", GetType(String))
            dtTongHop.Columns.Add("Tong_so_tin_chi", GetType(Integer))
            dtTongHop.Columns.Add("Ly_do", GetType(String))
            Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)

            'Add cac cot ESSDiem cua cac mon hoc
            For i As Integer = 0 To dsMonHoc.Count - 1
                If dtTongHop.Columns.IndexOf("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString) = -1 Then
                    dtTongHop.Columns.Add("M" + dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon.ToString)
                End If
            Next
            'Gan cac ESSDiem chi tiet tung mon hoc cua sinh vien va tinh ESSDiem TBCHT, Xep Loai
            For Each dr In dtTongHop.Rows
                'If dr("ID_SV") = 2528 Then
                '    dr("ID_SV") = 2528
                'End If
                'Add cac hoc ky va nam hoc
                Dim NienKhoa_Dau As Integer = CType(Left(dr("Nien_khoa"), 4), Integer)
                Dim NienKhoa_Cuoi As Integer = CType(Right(dr("Nien_khoa"), 4), Integer)
                Dim dt_ky As New DataTable
                dt_ky.Columns.Add("Hoc_ky", GetType(Integer))
                dt_ky.Columns.Add("Nam_hoc", GetType(String))
                dt_ky.Columns.Add("TBCHT_Ky", GetType(Double))
                For i As Integer = NienKhoa_Dau To NienKhoa_Cuoi - 1
                    Dim dr_kh As DataRow
                    dr_kh = dt_ky.NewRow

                    If Nam_hoc = i & "-" & i + 1 Then
                        'Den nam va hoc ky xet thi exit
                        dr_kh("Hoc_ky") = 1
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                        If Hoc_ky = 2 Then
                            dr_kh = dt_ky.NewRow
                            dr_kh("Hoc_ky") = 2
                            dr_kh("Nam_hoc") = i & "-" & i + 1
                            dt_ky.Rows.Add(dr_kh)
                        End If
                        Exit For
                    Else
                        dr_kh("Hoc_ky") = 1
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                        dr_kh = dt_ky.NewRow
                        dr_kh("Hoc_ky") = 2
                        dr_kh("Nam_hoc") = i & "-" & i + 1
                        dt_ky.Rows.Add(dr_kh)
                    End If
                Next

                'Tao dt de luu ESSDiem theo ky
                Dim dt_LuuDiemKy As New DataTable
                dt_LuuDiemKy.Columns.Add("Hoc_ky", GetType(Integer))
                dt_LuuDiemKy.Columns.Add("Nam_hoc", GetType(String))
                dt_LuuDiemKy.Columns.Add("Diem", GetType(Double))
                dt_LuuDiemKy.Columns.Add("So_tc", GetType(Double))


                Tong_diem = 0
                Tong_so_hoc_trinh = 0
                Tong_so_tin_chi = 0
                TBCTL = 0
                TBCHT = 0
                Tong_diem_ht = 0
                Dim ID_dt As Integer = 0

                'Duyet cac mon hoc
                For i As Integer = 0 To dsMonHoc.Count - 1
                    'Nếu môn này được đưa vào tính điểm thì TBCHT thì mới tính
                    ID_dt = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_dt
                    If dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                        ID_mon = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).ID_mon
                        'Tim ESSDiem cua sinh vien nay
                        idx_diem = Tim_idx(dr("ID_sv"), ID_mon)
                        'Nếu sinh viên có điểm môn học này thì tính điểm
                        If idx_diem >= 0 Then
                            Dim ESSDiem As ESSDiem = arrDiem(idx_diem)
                            'Chỉ tổng hợp những năm hiện tại
                            If ESSDiem.Nam_hoc <= Nam_hoc Then
                                Diem_so = ESSDiem.dsDiemThi.Diem_so_max()
                                Diem_chu = ESSDiem.dsDiemThi.Diem_chu_max(Hoc_ky, Nam_hoc)
                                'Tính điểm tích luỹ
                                'If dsDiemQuyDoi.TichLuy(Diem_chu) Then
                                'Tính số tín chỉ tích luỹ
                                If Diem_chu.ToUpper <> "I" And Diem_chu.ToUpper <> "X" And Diem_chu.ToUpper <> "F" And Diem_so >= 0 Then
                                    Tong_diem += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_so_hoc_trinh += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                End If


                                '************************
                                'Luu vao dt nay de sau nay tinh ESSDiem Tich luy ky 
                                If Diem_so >= 0 Then
                                    Tong_so_tin_chi += dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    Tong_diem_ht += Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh

                                    Dim dr_CheckKy As DataRow = dt_LuuDiemKy.NewRow
                                    dr_CheckKy("Hoc_ky") = ESSDiem.Hoc_ky
                                    dr_CheckKy("Nam_hoc") = ESSDiem.Nam_hoc
                                    dr_CheckKy("Diem") = Diem_so * dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dr_CheckKy("So_TC") = dsMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).So_hoc_trinh
                                    dt_LuuDiemKy.Rows.Add(dr_CheckKy)
                                End If


                                'End If
                            End If
                        End If
                    End If
                Next


                ' Tinh ESSDiem TBCHT ky
                For j As Integer = 0 To dt_ky.Rows.Count - 1
                    Dim TBTL_Ky As Double = 0
                    Dim So_TC As Integer = 0
                    dt_LuuDiemKy.DefaultView.RowFilter = "Hoc_ky=" & dt_ky.Rows(j).Item("Hoc_ky") & " And Nam_hoc='" & dt_ky.Rows(j).Item("Nam_hoc") & "'"
                    For i As Integer = 0 To dt_LuuDiemKy.DefaultView.Count - 1
                        TBTL_Ky += dt_LuuDiemKy.DefaultView.Item(i)("Diem")
                        So_TC += dt_LuuDiemKy.DefaultView.Item(i)("So_TC")
                    Next

                    If So_TC > 0 Then
                        TBTL_Ky = Math.Round(TBTL_Ky / So_TC + 0.000001, LamTron_Diem_TongHop)
                        dt_ky.Rows(j).Item("TBCHT_Ky") = TBTL_Ky
                    Else
                        dt_ky.Rows(j).Item("TBCHT_Ky") = 0
                    End If
                Next

                'Check thời gian hoàn thành chương trình đào tạo
                Dim Ly_do As String = ""
                Dim cls As ChuongTrinhDaoTao_Bussines
                cls = New ChuongTrinhDaoTao_Bussines(dr("ID_dt"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dr("ID_dt"))
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1

                If So_ky_ToiDa < So_ky_hienTai Then Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa


                'Check Học kỳ
                For i As Integer = 0 To dt_ky.Rows.Count - 1
                    '-	Học kỳ đầu TBCTL < 0.8
                    Dim NamHoc As Integer = CType(Left(dt_ky.Rows(i).Item("Nam_hoc"), 4), Integer)
                    If (NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 1) AndAlso KyDau_TBCTL_Active AndAlso dt_ky.Rows(i).Item("TBCHT_Ky") < KyDau_TBCTL Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Học kỳ đầu khoá có TBCHT kỳ < " & KyDau_TBCTL.ToString
                        Else
                            Ly_do = "Học kỳ đầu khoá học có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyDau_TBCTL.ToString
                        End If
                    End If

                    If KyBatKy_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < KyBatKy_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Học kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ")có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & KyBatKy_TBCTL.ToString
                        Else
                            Ly_do = "Học kỳ bất kỳ " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ " & dt_ky.Rows(i).Item("TBCHT_Ky") & " < " & KyBatKy_TBCTL
                        End If
                    End If

                    '-	2 Học kỳ liên tiếp TBCTL < 1.0
                    If HaiKyLienTiep_TBCTL_Active And dt_ky.Rows(i).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL And ((NamHoc = NienKhoa_Dau And dt_ky.Rows(i).Item("Hoc_ky") = 2) Or NamHoc <> NienKhoa_Dau) Then
                        If i > 0 AndAlso dt_ky.Rows(i - 1).Item("TBCHT_Ky") < HaiKyLienTiep_TBCTL Then
                            If Ly_do.Trim <> "" Then
                                Ly_do += ",2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
                            Else
                                Ly_do = "2 học kỳ liên tiếp " & dt_ky.Rows(i - 1).Item("Hoc_Ky") & "(" & dt_ky.Rows(i - 1).Item("Nam_hoc") & ") và " & dt_ky.Rows(i).Item("Hoc_Ky") & "(" & dt_ky.Rows(i).Item("Nam_hoc") & ") có TBCHT kỳ là " & dt_ky.Rows(i - 1).Item("TBCHT_Ky") & " và " & dt_ky.Rows(i).Item("TBCHT_Ky") & "< " & HaiKyLienTiep_TBCTL.ToString
                            End If
                        End If
                    End If
                Next

                'Tính điểm TBC tich luy và xếp loại
                Dim Xephang_Namdaotao As Integer = 0
                Xephang_Namdaotao = dsXepHangNamDaoTao.ESSXepHangNamDaoTao(Tong_so_hoc_trinh)
                If Tong_so_hoc_trinh > 0 Then
                    TBCTL = Math.Round(Tong_diem / Tong_so_hoc_trinh + 0.000001, LamTron_Diem_TongHop)
                    'Với năm học
                    If (Xephang_Namdaotao = 1 AndAlso NamDau_TBCTL_Active AndAlso TBCTL < NamDau_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
                        Else
                            Ly_do = "Năm thứ 1 có TBCTL là " & TBCTL & "< " & NamDau_TBCTL.ToString
                        End If
                    End If
                    If (Xephang_Namdaotao = 2 AndAlso NamThu2_TBCTL_Active AndAlso TBCTL < NamThu2_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
                        Else
                            Ly_do = "Năm thứ 2 có TBCTL là " & TBCTL & "< " & NamThu2_TBCTL.ToString
                        End If
                    End If
                    If (Xephang_Namdaotao = 3 AndAlso NamThu3_TBCTL_Active AndAlso TBCTL < NamThu3_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
                        Else
                            Ly_do = "Năm thứ 3 có TBCTL là " & TBCTL & "< " & NamThu3_TBCTL.ToString
                        End If
                    End If

                    If (Xephang_Namdaotao >= 4 AndAlso TuNamThu4_TBCTL_Active AndAlso TBCTL < TuNamThu4_TBCTL) Then
                        If Ly_do.Trim <> "" Then
                            Ly_do += ",từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
                        Else
                            Ly_do = "từ năm thứ " & Xephang_Namdaotao & " có TBCTL là " & TBCTL & "< " & TuNamThu4_TBCTL.ToString
                        End If
                    End If
                Else
                    Ly_do = "TBC tích luỹ là 0"
                End If
                If Tong_diem_ht > 0 Then
                    TBCHT = Math.Round(Tong_diem_ht / Tong_so_tin_chi + 0.00001, LamTron_Diem_TongHop)
                End If
                dr("Tong_so_hoc_trinh") = Tong_so_hoc_trinh
                dr("TBCTL") = TBCTL
                dr("TBCHT") = TBCHT
                dr("Tong_so_tin_chi") = Tong_so_tin_chi
                dr("Ly_do") = Ly_do
            Next
            dtTongHop.DefaultView.RowFilter = "Ly_do<>''"
            Return dtTongHop
        End Function

        Public Function Tim_idx_hoc_ky(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As Integer
            Dim Diem_Max As Double = -1
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    If CType(arrDiem(i), ESSDiem).ID_diem > 0 Then
                        Return i
                    End If
                    'Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx_hoc_ky_XetLenLop(ByVal ID_sv As Integer, ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Dim Diem_Max As Double = -1
            For i As Integer = 0 To arrDiem.Count - 1
                If CType(arrDiem(i), ESSDiem).ID_sv = ID_sv And CType(arrDiem(i), ESSDiem).ID_mon = ID_mon Then
                    For j As Integer = 0 To CType(arrDiem(i), ESSDiem).dsDiemThi.Count - 1
                        If CType(arrDiem(i), ESSDiem).dsDiemThi.ESSDiemThi(j).Hoc_ky_thi = Hoc_ky And CType(arrDiem(i), ESSDiem).dsDiemThi.ESSDiemThi(j).Nam_hoc_thi = Nam_hoc Then
                            Return i
                        End If
                    Next
                End If
            Next
            Return -1
        End Function

        Function HienThi_DanhSach_XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String) As DataTable
            Dim cls As New DanhSachTotNghiep_DataAccess
            Return cls.HienThi_DanhSach_XetLenLop(Hoc_ky, Nam_hoc, ID_lops)
        End Function
    End Class
End Namespace