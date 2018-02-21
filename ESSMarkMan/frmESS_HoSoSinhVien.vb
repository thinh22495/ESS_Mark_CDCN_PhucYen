Imports System.IO
Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_HoSoSinhVien
    Public midx As Integer = 0
    Public marrID_sv As New ArrayList
    Public mID_lops As String
    Public mMa_sv As String = ""
    ' Cờ sửa thông tin mặc định là sửa còn thì là thêm mới hồ sơ sinh viên 
    Public Edit As Boolean = True
    Private Loader As Boolean = False
    Sub New()

        ' This call is required by the Windows Form Designer. wefw.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(ByVal arrID_sv As ArrayList, ByVal idx As Integer, ByVal ID_lops As String)
        midx = idx
        marrID_sv = arrID_sv
        mID_lops = ID_lops
        ' This call is required by the Windows Form Designer. 
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

    End Sub
#Region "Form Event"
    Private Sub frmESS_HoSoSinhVien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_HoSoSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Load du lieu vao cac combobox
        LoadCombos()
        'Load sinh vien hien hanh
        Call HienThi_ESSHoSo_SinhVien()
        Loader = True
    End Sub
    Private Sub frmESS_HoSoSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub txt_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtM1.KeyPress, txtM2.KeyPress, txtM3.KeyPress, txtTong_diem.KeyPress, txtDiem_thuong.KeyPress, txtNam_TN.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar, ".")
    End Sub
#End Region
#Region "Functions And Subs"
    ' Load thông tin về điểm rèn luyện
    Private Sub LoadDiemRenLuyen()
        Try
            ' Load niên khóa
            SetUpDataGridView(grdViewRenLuyen)
            Dim objDM As New DanhMuc_Bussines
            Dim Nien_khoa As String = objDM.LoadNienKhoa(marrID_sv(midx))
            If Nien_khoa = "" Then Exit Sub
            Dim arrNam(1) As String
            arrNam = Nien_khoa.Split("-")
            Dim SoNam As Integer = arrNam(1) - arrNam(0)
            Dim arrNam1(SoNam) As String
            Dim Nam1, Nam2, Nam3, Nam4 As String
            Dim Nam5 As String = ""
            Nam1 = arrNam(0) & "-" & arrNam(0) + 1
            arrNam1(0) = Nam1
            Nam2 = arrNam(0) + 1 & "-" & arrNam(0) + 2
            arrNam1(1) = Nam2
            Nam3 = arrNam(0) + 2 & "-" & arrNam(0) + 3
            arrNam1(2) = Nam3
            Nam4 = arrNam(0) + 3 & "-" & arrNam(0) + 4
            arrNam1(3) = Nam4
            If SoNam = 5 Then
                Nam5 = arrNam(0) + 4 & "-" & arrNam(0) + 5
                arrNam1(4) = Nam5
            End If
            ' Điểm rèn luyện của tùng năm
            Dim obj As New DiemRenLuyen_Bussines(mID_lops)
            Dim dt As DataTable
            Dim data As New DataTable
            data.Columns.Add("Nam_hoc", GetType(String))
            data.Columns.Add("Hoc_ky1", GetType(String))
            data.Columns.Add("Hoc_ky2", GetType(String))
            data.Columns.Add("Ca_nam", GetType(String))
            data.Columns.Add("Xep_loai", GetType(String))
            For i As Integer = 0 To SoNam - 1
                dt = obj.DiemRenLuyenSinhVien(arrNam1(i), marrID_sv(midx))
                If dt.Rows.Count > 0 Then
                    Dim row As DataRow = data.NewRow
                    row("Nam_hoc") = dt.Rows(0).Item("Nam_hoc")
                    row("Hoc_ky1") = dt.Rows(0).Item("Tong_diem_ky1")
                    row("Hoc_ky2") = dt.Rows(0).Item("Tong_diem_ky2")
                    row("Ca_nam") = dt.Rows(0).Item("Tong_diem")
                    row("Xep_loai") = dt.Rows(0).Item("Xep_loai")
                    data.Rows.Add(row)
                End If
            Next
            grdViewRenLuyen.DataSource = data
            Dim dtTK As DataTable
            dtTK = obj.DiemRenLuyenKhoaSinhVien(marrID_sv(midx))
            If dtTK.Rows.Count > 0 Then
                labTong_diem.Text = dtTK.Rows(0).Item("Tong_diem")
                labXep_loai.Text = dtTK.Rows(0).Item("Xep_loai")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadDanhHieuCaNhan()
        Try
            SetUpDataGridView(grdViewDanhHieuThiDua)
            Dim obj As New DanhHieuThiDuaCaNhan_Bussines(gobjUser.dsID_lop)
            Dim dt As DataTable
            dt = obj.DanhHieuCaNhan(marrID_sv(midx))
            grdViewDanhHieuThiDua.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadKhenThuong()
        Try
            SetUpDataGridView(grdViewKhenThuong)
            Dim obj As New KhenThuong_Bussines(CType(marrID_sv(midx), Integer))
            Dim dt As DataTable
            dt = obj.HienThi_ESSQDKhenThuong()
            dt.DefaultView.AllowEdit = False
            grdViewKhenThuong.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadKyLuat()
        Try
            SetUpDataGridView(grdViewKyLuat)
            Dim obj As New KyLuat_Bussines(CType(marrID_sv(midx), Integer))
            Dim dt As DataTable
            dt = obj.LoadKyLuatSinhVien()
            dt.DefaultView.AllowEdit = False
            grdViewKyLuat.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Can bo lop 
    Private Sub LoadCanBoLop()
        Try
            SetUpDataGridView(grdViewCanBoLop)
            Dim obj As New CanBoLop_Bussines
            Dim dt As DataTable
            dt = obj.HienThi_ESSCanBoLop_ListID_svs(marrID_sv(midx))
            dt.DefaultView.AllowEdit = False
            grdViewCanBoLop.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Giay to
    Private Sub LoadGiayToNop()
        Try
            SetUpDataGridView(grdViewGiayToNop)
            Dim obj As New HoSoNop_Bussines(gobjUser.dsID_lop)
            Dim dt As DataTable
            dt = obj.HienThi_ESSHoSoNop(marrID_sv(midx))
            dt.DefaultView.AllowEdit = False
            grdViewGiayToNop.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Hoat dong xa hoi
    Private Sub LoadHoatDongXaHoi()
        Try
            SetUpDataGridView(grdViewHoatDongDoanThe)
            Dim obj As New HoatDongXaHoi_Bussines(marrID_sv(midx))
            Dim dt As DataTable
            dt = obj.HienThi_ESSHoatDongXaHoiSV()
            dt.DefaultView.AllowEdit = False
            grdViewHoatDongDoanThe.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Noi ngoai tru
    Private Sub LoadNoiNgoaiTru()
        Try
            SetUpDataGridView(grdViewNoiNgoaiTru)
            Dim obj As New NoiNgoaiTru_Bussines(CType(marrID_sv(midx), Integer))
            Dim dt As DataTable
            dt = obj.HienThi_ESSNoiNgoaiTruSV()
            dt.DefaultView.AllowEdit = False
            grdViewNoiNgoaiTru.DataSource = dt
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Tai chinh
    Private Sub LoadTaiChinh()
        Try
            SetUpDataGridView(grdViewHocBong)
            SetUpDataGridView(grdViewHocPhi)
            SetUpDataGridView(grdViewThuKhac)
            Dim dtHB As DataTable
            Dim obj As New DanhSachHocBong_Bussines(CType(marrID_sv(midx), Integer))
            dtHB = obj.HocBongSinhVien()
            dtHB.DefaultView.AllowEdit = False
            grdViewHocBong.DataSource = dtHB

            'Dim dtThuChi As DataTable
            'Dim objTC As New BienLaiThu_Bussines(CType(marrID_sv(midx), Integer), True)
            'dtThuChi = objTC.DanhSach_ThuChi()
            'grdViewThuKhac.DataSource = dtThuChi
            Dim objTC As New BienLaiThu_Bussines()
            Dim dtThuChi As DataTable
            dtThuChi = objTC.DanhSach_BienLai_SV(CType(marrID_sv(midx), Integer))
            grdViewThuKhac.DataSource = dtThuChi

            Dim dt As DataTable
            'dt = objTC.TongHop_HocPhi_New(Now.Date, , , , , , , , CType(marrID_sv(midx), Integer))
            Dim mclsBL As New BienLaiThu_Bussines
            dt = mclsBL.TongHopHocPhiSinhVien(CType(marrID_sv(midx), Integer))
            
            dt.DefaultView.Sort = "Nam_hoc,Hoc_ky"
            grdViewHocPhi.DataSource = dt.DefaultView

            Dim So_tien_phai_nop As Double = 0
            Dim So_tien_giam As Double = 0
            Dim So_tien_da_nop As Double = 0
            Dim So_tien_hoan_tra As Double = 0
            Dim So_tien_con_no As Double = 0
            If dt.Rows.Count > 0 Then
                dt.Columns.Add("So_tien_hoan_tra")
                dt.Columns.Add("So_tien_con_no")
                For i As Integer = 0 To dt.Rows.Count - 1
                    So_tien_phai_nop += IIf(dt.Rows(i)("So_tien_nop").ToString = "", 0, dt.Rows(i)("So_tien_nop"))
                    So_tien_giam += IIf(dt.Rows(i)("So_tien_mien_giam").ToString = "", 0, dt.Rows(i)("So_tien_mien_giam"))
                    So_tien_da_nop += IIf(dt.Rows(i)("So_tien_da_nop").ToString = "", 0, dt.Rows(i)("So_tien_da_nop"))
                    Dim So_tien_chi As Double = 0
                    'So_tien_chi = IIf(dt.Rows(i)("So_tien_chi").ToString = "", 0, dt.Rows(i)("So_tien_chi"))
                    So_tien_hoan_tra += So_tien_chi
                    Dim So_tien_no As Double = 0
                    So_tien_no = IIf(dt.Rows(i)("So_tien_nop").ToString = "", 0, dt.Rows(i)("So_tien_nop")) - IIf(dt.Rows(i)("So_tien_da_nop").ToString = "", 0, dt.Rows(i)("So_tien_da_nop"))
                    So_tien_con_no += So_tien_no
                    dt.Rows(i)("So_tien_con_no") = So_tien_no
                    dt.Rows(i)("So_tien_hoan_tra") = So_tien_chi
                Next
            End If
            lblSo_tien_phai_nop.Text = Format(So_tien_phai_nop, "###,###")
            lblSo_tien_giam.Text = Format(So_tien_giam, "###,###")
            lblSo_tien_da_nop.Text = Format(So_tien_da_nop, "###,###")
            lblSo_tien_hoan_tra.Text = Format(So_tien_hoan_tra, "###,###")
            lblSo_tien_con_no.Text = Format(So_tien_con_no, "###,###")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        'Try
        '    SetUpDataGridView(grdViewHocBong)
        '    SetUpDataGridView(grdViewHocPhi)
        '    SetUpDataGridView(grdViewThuKhac)
        '    Dim dtHB As DataTable
        '    Dim obj As New DanhSachHocBong_Bussines(CType(marrID_sv(midx), Integer))
        '    dtHB = obj.HocBongSinhVien()
        '    dtHB.DefaultView.AllowEdit = False
        '    grdViewHocBong.DataSource = dtHB
        '    Dim dtThuChi As DataTable
        '    Dim objTC As New BienLaiThu_Bussines(CType(marrID_sv(midx), Integer), True)
        '    dtThuChi = objTC.DanhSach_ThuChi()
        '    grdViewThuKhac.DataSource = dtThuChi
        '    Dim dtHP As DataTable
        '    dtHP = objTC.DanhSachHocPhi(CType(marrID_sv(midx), Integer))
        '    grdViewHocPhi.DataSource = dtHP
        '    Dim So_tien_phai_nop As Integer = 0
        '    Dim So_tien_giam As Double = 0
        '    Dim So_tien_da_nop As Double = 0
        '    Dim So_tien_hoan_tra As Double = 0
        '    Dim So_tien_con_no As Double = 0
        '    For Each r As DataRow In dtHP.Rows
        '        So_tien_phai_nop += r("So_tien_nop")
        '        So_tien_giam += r("So_tien_giam")
        '        So_tien_da_nop += r("So_tien_da_nop")
        '        So_tien_hoan_tra += r("So_tien_hoan_tra")
        '        So_tien_con_no += r("So_tien_con_no")
        '    Next
        '    lblSo_tien_phai_nop.Text = Format(So_tien_phai_nop, "###,###")
        '    lblSo_tien_giam.Text = Format(So_tien_giam, "###,###")
        '    lblSo_tien_da_nop.Text = Format(So_tien_da_nop, "###,###")
        '    lblSo_tien_hoan_tra.Text = Format(So_tien_hoan_tra, "###,###")
        '    lblSo_tien_con_no.Text = Format(So_tien_con_no, "###,###")
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try        
    End Sub
    ' Load Hoc Tap 
    Private Sub LoadHocTap()
        Try
            'Load bảng điểm sinh viên 
            SetUpDataGridView(grdViewDiem)
            Dim ID_sv As Integer = CType(marrID_sv(midx), Integer)
            Dim objDSSV As New DanhSachSinhVien_Bussines(True, 0, ID_sv)
            Dim dtSv As DataTable = objDSSV.Danh_sach_sinh_vien()
            Dim ID_dt As Integer = 0
            If cmdChuyenNganh.SelectedIndex = 0 Then ' Neu chon nganh 1
                ID_dt = dtSv.Rows(0)("ID_dt")
            Else ' Neu chon nganh 2
                Dim cls As New HoSo_Bussines
                ID_dt = cls.LoadID_dt_nganh2(ID_sv)
            End If
            Dim clsDiem As New BangDiemCaNhan_Bussines("P1", ID_sv, ID_dt, 0, "")
            Dim dtBangDiem As DataTable = clsDiem.BangDiem()
            lblTBC_tich_luy.Text = Format(clsDiem.TBC_tich_luy, "##.00")
            lblXep_loai_hoc_luc.Text = clsDiem.Xep_hang_hoc_luc
            lblSo_hoc_trinh_tich_luy.Text = clsDiem.So_hoc_trinh_tich_luy
            lblSo_mon_cho_diem.Text = clsDiem.So_mon_cho_diem
            lblSo_mon_hoc_lai.Text = clsDiem.So_mon_hoc_lai
            lblSo_mon_thi_lai.Text = clsDiem.So_mon_thi_lai
            Me.grdViewDiem.DataSource = dtBangDiem.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Thong tin sinh vien tốt nghiệp
    Private Sub LoadTotNghiep()
        Try
            Dim cls As New HoSo_Bussines
            Dim dt As DataTable
            dt = cls.LoadHoSoSub(CType(marrID_sv(midx), Integer))
            If dt.Rows.Count = 0 Then
                txtDia_chi_day_du.Text = ""
                txtSo_dien_thoai.Text = ""
                txtDi_dong.Text = ""
                txtFax.Text = ""
                txtEmail.Text = ""
                cmbID_co_quan_lam_viec.SelectedIndex = -1
                cmbID_tinh_chat_cong_viec.SelectedIndex = -1
                txtMuc_thu_nhap_thang.Text = ""
                cmbID_noi_lam_viec.SelectedIndex = -1
            Else
                txtDia_chi_day_du.Text = dt.Rows(0)("Dia_chi_day_du").ToString
                txtSo_dien_thoai.Text = dt.Rows(0)("So_dien_thoai").ToString
                txtDi_dong.Text = dt.Rows(0)("Di_dong").ToString
                txtFax.Text = dt.Rows(0)("Fax").ToString
                txtEmail.Text = dt.Rows(0)("Email").ToString
                cmbID_co_quan_lam_viec.SelectedIndex = IIf(dt.Rows(0)("ID_co_quan_lam_viec").ToString = "", -1, dt.Rows(0)("ID_co_quan_lam_viec"))
                cmbID_tinh_chat_cong_viec.SelectedIndex = IIf(dt.Rows(0)("ID_tinh_chat_cong_viec").ToString = "", -1, dt.Rows(0)("ID_tinh_chat_cong_viec"))
                txtMuc_thu_nhap_thang.Text = dt.Rows(0)("Muc_thu_nhap_thang").ToString
                cmbID_noi_lam_viec.SelectedIndex = IIf(dt.Rows(0)("ID_noi_lam_viec").ToString = "", -1, dt.Rows(0)("ID_noi_lam_viec"))
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    ' Load Combo
    Private Sub LoadCombos()
        'Load combobox 
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As New DataTable
        dt = clsDM.DanhMuc_Load("STU_Tinh", "ID_tinh", "Ten_tinh")
        FillCombo(cmbID_Noi_sinh, dt)
        'FillCombo(cmbID_noi_cap, dt.Copy)

        Dim dtT As DataTable
        dtT = clsDM.DanhMuc_Load("STU_Tinh", "ID_tinh", "Ten_tinh")
        FillCombo(cmbID_tinh, dtT)

        dt = clsDM.DanhMuc_Load("STU_QuocTich", "ID_quoc_tich", "Quoc_tich")
        FillCombo(cmbID_quoc_tich, dt)
        FillCombo(cmbQuoc_tich_cha, dt.Copy)
        FillCombo(cmbQuoc_tich_me, dt.Copy)
        FillCombo(cmbQuoc_tich_vo_chong, dt.Copy)

        dt = clsDM.DanhMuc_Load("STU_DanToc", "ID_dan_toc", "Dan_toc")
        FillCombo(cmbID_dan_toc, dt)
        FillCombo(cmbDan_toc_cha, dt.Copy)
        FillCombo(cmbDan_toc_me, dt.Copy)
        FillCombo(cmbDan_toc_vo_chong, dt.Copy)

        dt = clsDM.DanhMuc_Load("STU_ThanhPhanXuatThan", "ID_thanh_phan_xuat_than", "Ten_thanh_phan")
        FillCombo(cmbID_thanh_phan, dt)

        dt = clsDM.DanhMuc_Load("STU_KhuVuc", "ID_kv", "Ten_kv")
        FillCombo(cmbMa_kv, dt)

        dt = clsDM.DanhMuc_Load("STU_DoiTuong", "ID_dt", "Ten_dt")
        FillCombo(cmbID_doi_tuong_cs, dt)

        dt = clsDM.DanhMuc_Load("STU_DoiTuongHocBong", "ID_dt_hb", "Ten_dt_hb")
        FillCombo(cmbID_doi_tuong_hb, dt)

        dt = clsDM.DanhMuc_Load("STU_NhomDoiTuong", "ID_nhom_dt", "Ten_nhom")
        FillCombo(cmbID_nhom_dt, dt)

    End Sub
    ' Hiển thị thông tin về lý lịch bổ xung
    Private Sub Fill_ly_lich_bo_xung(ByVal hs As ESSHoSo)
        txtXep_loai_hoc_tap.Text = hs.Xep_loai_hoc_tap
        txtXep_loai_hanh_kiem.Text = hs.Xep_loai_hanh_kiem
        txtXep_loai_tot_nghiep.Text = hs.Xep_loai_tot_nghiep
        txtNam_TN.Text = hs.Nam_tot_nghiep
        txtDiem_thuong.Text = hs.Diem_thuong
        txtLy_do_thuong.Text = hs.Ly_do_thuong_diem
        txtKhen_thuong.Text = hs.Khen_thuong_ky_luat
        txtQua_trinh.Text = hs.Qua_trinh_HT_LD

        txtHo_ten_cha.Text = hs.Ho_ten_cha
        cmbQuoc_tich_cha.SelectedValue = hs.ID_quoc_tich_cha
        cmbDan_toc_cha.SelectedValue = hs.ID_dan_toc_cha
        txtTon_giao_cha.Text = hs.Ton_giao_cha
        txtHo_khau_TT_cha.Text = hs.Ho_khau_TT_cha
        txtHoat_dong_XHCT_cha.Text = hs.Hoat_dong_XH_CT_cha

        txtHo_ten_me.Text = hs.Ho_ten_me
        cmbQuoc_tich_me.SelectedValue = hs.ID_quoc_tich_me
        cmbDan_toc_me.SelectedValue = hs.ID_dan_toc_me
        txtTon_giao_me.Text = hs.Ton_giao_me
        txtHo_khau_TT_me.Text = hs.Ho_khau_TT_me
        txtHoat_dong_XHCT_me.Text = hs.Hoat_dong_XH_CT_me

        txtHo_ten_vo_chong.Text = hs.Ho_ten_vo_chong
        cmbQuoc_tich_vo_chong.SelectedValue = hs.ID_quoc_tich_vo_chong
        cmbDan_toc_vo_chong.SelectedValue = hs.ID_dan_toc_vo_chong
        txtton_giao_vo_chong.Text = hs.Ton_giao_vo_chong
        txtHo_khau_TT_vo_chong.Text = hs.Ho_khau_TT_vo_chong
        txtHoat_dong_XHCT_vo_chong.Text = hs.Hoat_dong_XH_CT_vo_chong

        txtAnh_chi_em.Text = hs.Ho_ten_nghe_nghiep_anh_em
        txtNamSinhCha.Text = hs.Namsinh_cha
        txtNamSinhMe.Text = hs.Namsinh_me

    End Sub
    Private Sub Get_ly_lich_bo_xung(ByRef hs As ESSHoSo)
        hs.Xep_loai_hoc_tap = txtXep_loai_hoc_tap.Text
        hs.Xep_loai_hanh_kiem = txtXep_loai_hanh_kiem.Text
        hs.Xep_loai_tot_nghiep = txtXep_loai_tot_nghiep.Text
        hs.Nam_tot_nghiep = txtNam_TN.Text
        hs.Diem_thuong = CDbl(IIf(txtDiem_thuong.Text.ToString = "", 0, txtDiem_thuong.Text))
        hs.Ly_do_thuong_diem = txtLy_do_thuong.Text
        hs.Khen_thuong_ky_luat = txtKhen_thuong.Text
        hs.Qua_trinh_HT_LD = txtQua_trinh.Text

        hs.Ho_ten_cha = txtHo_ten_cha.Text
        hs.ID_quoc_tich_cha = cmbQuoc_tich_cha.SelectedValue
        hs.ID_dan_toc_cha = cmbDan_toc_cha.SelectedValue
        hs.Ton_giao_cha = txtTon_giao_cha.Text
        hs.Ho_khau_TT_cha = txtHo_khau_TT_cha.Text
        hs.Hoat_dong_XH_CT_cha = txtHoat_dong_XHCT_cha.Text

        hs.Ho_ten_me = txtHo_ten_me.Text
        hs.ID_quoc_tich_me = cmbQuoc_tich_me.SelectedValue
        hs.ID_dan_toc_me = cmbDan_toc_me.SelectedValue
        hs.Ton_giao_me = txtTon_giao_me.Text
        hs.Ho_khau_TT_me = txtHo_khau_TT_me.Text
        hs.Hoat_dong_XH_CT_me = txtHoat_dong_XHCT_me.Text

        hs.Ho_ten_vo_chong = txtHo_ten_vo_chong.Text
        hs.ID_quoc_tich_vo_chong = cmbQuoc_tich_vo_chong.SelectedValue
        hs.ID_dan_toc_vo_chong = cmbDan_toc_vo_chong.SelectedValue
        hs.Ton_giao_vo_chong = txtton_giao_vo_chong.Text
        hs.Ho_khau_TT_vo_chong = txtHo_khau_TT_vo_chong.Text
        hs.Hoat_dong_XH_CT_vo_chong = txtHoat_dong_XHCT_vo_chong.Text

        hs.Ho_ten_nghe_nghiep_anh_em = txtAnh_chi_em.Text
        hs.Namsinh_cha = txtNamSinhCha.Text
        hs.Namsinh_me = txtNamSinhMe.Text

    End Sub
    ' Hiển thị thông tin lý lịch sinh viên vào form
    Private Sub Fill_ly_lich(ByVal hs As ESSHoSo)
        '==========Hiển thị bản ghi nao===============

        txtMa_sv.Text = hs.Ma_sv
        txtHo_ten.Text = hs.Ho_ten
        txtCMND.Text = hs.CMND

        txtNoiCap.Text = hs.Noi_cap
        If hs.Ngay_cap <> Nothing Then
            dtmNgay_cap.Checked = True
            dtmNgay_cap.Value = hs.Ngay_cap
        Else
            dtmNgay_cap.Checked = False
        End If

        '=======Hiển thị ảnh==============
        If Not hs.Anh Is Nothing AndAlso (hs.Anh.Length > 0) Then
            Dim arrPicture() As Byte = CType(hs.Anh, Byte())
            Dim ms As New System.IO.MemoryStream(arrPicture)
            With picAnh
                .Image = Image.FromStream(ms)
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
            ms = Nothing
        Else
            With picAnh
                .Image = Nothing
                .SizeMode = PictureBoxSizeMode.StretchImage
                .BorderStyle = BorderStyle.Fixed3D
            End With
        End If
        OPDMo_tep.FileName = ""
        '=======Hiển thị ảnh==============        
        If hs.Ngay_sinh <> Nothing Then
            dtmNgay_sinh.Checked = True
            dtmNgay_sinh.Value = hs.Ngay_sinh
        Else
            dtmNgay_sinh.Checked = False
        End If
        If hs.ID_gioi_tinh = 0 Then
            optNam.Checked = True
            optNu.Checked = False
        Else
            optNam.Checked = False
            optNu.Checked = True
        End If
        Dim ID_tinh_ns As String = ""
        If hs.ID_tinh_ns.ToString.Length = 1 Then
            ID_tinh_ns = "0" & hs.ID_tinh_ns
        Else
            ID_tinh_ns = hs.ID_tinh_ns
        End If
        cmbID_Noi_sinh.SelectedValue = ID_tinh_ns
        txtQue_quan.Text = hs.Que_quan
        cmbID_quoc_tich.SelectedValue = hs.ID_quoc_tich
        cmbID_dan_toc.SelectedValue = hs.ID_dan_toc
        txtTon_giao.Text = hs.Ton_giao
        cmbID_thanh_phan.SelectedValue = hs.ID_thanh_phan_xuat_than

        If hs.Ngay_vao_doan <> Nothing Then
            dtmNgay_vao_doan.Checked = True
            dtmNgay_vao_doan.Value = hs.Ngay_vao_doan
        Else
            dtmNgay_vao_doan.Checked = False
        End If
        If hs.Ngay_vao_dang <> Nothing Then
            dtmNgay_vao_dang.Checked = True
            dtmNgay_vao_dang.Value = hs.Ngay_vao_dang
        Else
            dtmNgay_vao_dang.Checked = False
        End If
        txtDia_chi.Text = hs.Dia_chi_tt
        txtPhuong.Text = hs.Xa_phuong_tt
        Dim ID_tinh_tt As String = ""
        If hs.ID_tinh_tt.ToString.Length = 1 Then
            ID_tinh_tt = "0" & hs.ID_tinh_tt
        Else
            ID_tinh_tt = hs.ID_tinh_tt
        End If
        cmbID_tinh.SelectedValue = ID_tinh_tt
        cmbID_huyen.SelectedValue = hs.ID_huyen_tt
        cmbID_doi_tuong_cs.SelectedValue = hs.ID_doi_tuong_TS
        cmbID_doi_tuong_hb.SelectedValue = hs.ID_doi_tuong_TC
        txtDien_thoai_NR.Text = hs.Dien_thoai_NR
        cmbID_nhom_dt.SelectedValue = hs.ID_nhom_doi_tuong
        txtDia_chi_Bao_tin.Text = hs.Dia_chi_bao_tin
        cmbMa_kv.SelectedValue = hs.ID_khu_vuc_TS
        txtDoi_tuong_du_thi.Text = hs.Doi_tuong_du_thi
        txtM1.Text = hs.Diem1
        txtM2.Text = hs.Diem2
        txtM3.Text = hs.Diem3
        txtTong_diem.Text = hs.Tong_diem
        Select Case hs.Ngoai_ngu
            Case "A"
                cmbNgoaiNgu.SelectedIndex = 0
            Case "P"
                cmbNgoaiNgu.SelectedIndex = 1
            Case "N"
                cmbNgoaiNgu.SelectedIndex = 2
            Case "T"
                cmbNgoaiNgu.SelectedIndex = 3
            Case "Nh"
                cmbNgoaiNgu.SelectedIndex = 4
            Case ""
                cmbNgoaiNgu.SelectedIndex = -1
        End Select
        txtSo_bao_danh.Text = hs.SBD
        txtNganh_tuyen_sinh.Text = hs.Nganh_tuyen_sinh
        txtKhoi_thi.Text = hs.Khoi_thi
        txtDienThoaiCaNhan.Text = hs.Dienthoai_canhan
        txtEmail.Text = hs.Email
        txtNoiO_hiennay.Text = hs.NoiO_hiennay
        txtNoCard.Text = hs.IDCard
    End Sub
    ' Lấy thông tin về lý lịch sinh viên trên form
    Private Function Get_ly_lich() As ESSHoSo
        Dim hs As New ESSHoSo
        hs.ID_sv = marrID_sv(midx)
        hs.Ma_sv = txtMa_sv.Text
        hs.Ho_ten = txtHo_ten.Text
        hs.Ngay_sinh = dtmNgay_sinh.Value
        If optNam.Checked Then
            hs.ID_gioi_tinh = 0
        Else
            hs.ID_gioi_tinh = 1
        End If
        ' Xử lý anh đưa về dữ liệu kiểm byte
        Dim ms As New MemoryStream
        If Not picAnh.Image Is Nothing Then
            picAnh.Image.Save(ms, picAnh.Image.RawFormat.Bmp)
            Dim arrImage() As Byte = ms.GetBuffer
            ms.Close()
            hs.Anh = arrImage
        Else
            Dim arrPicture() As Byte = CType(hs.Anh, Byte())
            hs.Anh = ms.GetBuffer
        End If

        If dtmNgay_vao_dang.Checked Then
            hs.Ngay_vao_dang = dtmNgay_vao_dang.Value
        End If
        If dtmNgay_vao_doan.Checked Then
            hs.Ngay_vao_doan = dtmNgay_vao_doan.Value
        End If

        hs.ID_tinh_ns = cmbID_Noi_sinh.SelectedValue
        hs.Que_quan = txtQue_quan.Text
        hs.ID_quoc_tich = cmbID_quoc_tich.SelectedValue
        hs.ID_dan_toc = cmbID_dan_toc.SelectedValue
        hs.Ton_giao = txtTon_giao.Text
        hs.ID_thanh_phan_xuat_than = cmbID_thanh_phan.SelectedValue
        hs.Dia_chi_tt = txtDia_chi.Text
        hs.Xa_phuong_tt = txtPhuong.Text
        hs.ID_tinh_tt = cmbID_tinh.SelectedValue
        hs.ID_huyen_tt = cmbID_huyen.SelectedValue
        hs.ID_doi_tuong_TS = cmbID_doi_tuong_cs.SelectedValue
        hs.ID_doi_tuong_TC = cmbID_doi_tuong_hb.SelectedValue
        hs.Dien_thoai_NR = txtDien_thoai_NR.Text
        hs.ID_nhom_doi_tuong = cmbID_nhom_dt.SelectedValue
        hs.Dia_chi_bao_tin = txtDia_chi_Bao_tin.Text
        hs.ID_khu_vuc_TS = cmbMa_kv.SelectedValue
        hs.Doi_tuong_du_thi = txtDoi_tuong_du_thi.Text
        If txtM1.Text <> "" Then hs.Diem1 = CType(txtM1.Text, Double)
        If txtM2.Text <> "" Then hs.Diem2 = CType(txtM2.Text, Double)
        If txtM3.Text <> "" Then hs.Diem3 = CType(txtM3.Text, Double)
        If txtTong_diem.Text <> "" Then hs.Tong_diem = CType(txtTong_diem.Text.ToString, Double)

        Select Case cmbNgoaiNgu.SelectedIndex
            Case -1
                hs.Ngoai_ngu = ""
            Case 0
                hs.Ngoai_ngu = "A"
            Case 1
                hs.Ngoai_ngu = "P"
            Case 2
                hs.Ngoai_ngu = "N"
            Case 3
                hs.Ngoai_ngu = "T"
            Case 4
                hs.Ngoai_ngu = "Nh"
        End Select
        hs.SBD = txtSo_bao_danh.Text
        hs.Nganh_tuyen_sinh = txtNganh_tuyen_sinh.Text
        hs.Khoi_thi = txtKhoi_thi.Text
        hs.CMND = txtCMND.Text
        hs.Noi_cap = txtNoiCap.Text
        If dtmNgay_cap.Checked Then
            hs.Ngay_cap = dtmNgay_cap.Value
        End If
        hs.Dienthoai_canhan = txtDienThoaiCaNhan.Text
        hs.Email = txtEmail.Text
        hs.NoiO_hiennay = txtNoiO_hiennay.Text
        hs.IDCard = txtNoCard.Text
        ' Gan lý lịch bổ xung
        Get_ly_lich_bo_xung(hs)
        Return hs
    End Function
    ' Check input data    
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        Dim objHoSo_Bussines As New HoSo_Bussines
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra Masv
        If txtMa_sv.Text.Trim = "" Then
            Call SetErrPro(txtMa_sv, ErrorProvider1, "Bạn hãy nhập mã sinh viên !")
            If CtrlErr Is Nothing Then CtrlErr = txtMa_sv
        Else
            If Edit = False AndAlso objHoSo_Bussines.CheckExist_MaSinhVien(txtMa_sv.Text) Then
                Call SetErrPro(txtMa_sv, ErrorProvider1, "Bạn hãy nhập lại mã sinh viên,mã này đã tồn tại!")
                If CtrlErr Is Nothing Then CtrlErr = txtMa_sv
            End If
        End If
        ' Kiểm tra Họ tên
        If txtHo_ten.Text.Trim = "" Then
            Call SetErrPro(txtHo_ten, ErrorProvider1, "Bạn hãy nhập họ tên sinh viên !")
            If CtrlErr Is Nothing Then CtrlErr = txtHo_ten
        End If
        ' Kiểm tra Ngày sinh
        If dtmNgay_sinh.Checked = False Then
            Call SetErrPro(dtmNgay_sinh, ErrorProvider1, "Bạn hãy nhập ngày sinh của sinh viên !")
            If CtrlErr Is Nothing Then CtrlErr = dtmNgay_sinh
        End If


        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub HienThi_ESSHoSo_SinhVien()
        If marrID_sv.Count = 0 Then Exit Sub
        Dim objHoSo_Bussines As New HoSo_Bussines
        objHoSo_Bussines = New HoSo_Bussines(marrID_sv(midx))
        If gobjUser.UserName.ToUpper = "ADMIN" Then
            txtMa_sv.Enabled = True
            txtHo_ten.Enabled = True
        Else
            txtMa_sv.Enabled = False
            txtHo_ten.Enabled = False
        End If
        If Edit = True Then ' Nếu là sửa thông tin sinh viên
            Dim hs As ESSHoSo = objHoSo_Bussines.HoSo_SinhVien_Index(0)
            Fill_ly_lich(hs)
            Fill_ly_lich_bo_xung(hs)
            mMa_sv = hs.Ma_sv
        End If
    End Sub
#End Region
#Region "Button.click"
    ' Cập nhật thông tin sinh viên
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim objHoSo_Bussines As New HoSo_Bussines
        If tabHoSoSinhVien.SelectedTab.Name = "tabLy_lich" Or tabHoSoSinhVien.SelectedTab.Name = "tabLy_lich_bo_sung" Then
            If Not CheckInputData() Then Exit Sub
            Dim _hoso As ESSHoSo = Get_ly_lich()
            If Edit = True Then ' Sửa thông tin hồ sơ sinh viên 
                If mMa_sv <> txtMa_sv.Text Then
                    If objHoSo_Bussines.CheckExist_MaSinhVien(txtMa_sv.Text) Then
                        Thongbao("Mã sinh viên đã tồn tại bạn phải nhập lại mã sinh viên !")
                        txtMa_sv.Focus()
                        Exit Sub
                    End If
                End If
                objHoSo_Bussines.CapNhat_ESSHoSo(_hoso, marrID_sv(midx))
                Dim Noi_dung As String = ""
                Noi_dung = "Sửa sinh viên có mã " & txtMa_sv.Text.Trim
                SaveLog(LoaiSuKien.Sua, Noi_dung)
                Thongbao("Đã cập nhật hồ sơ thành công !")
            Else
                ' Thêm mới thông tin hồ sơ sinh viên vào database  
                Dim ID_sv As Integer
                ID_sv = objHoSo_Bussines.ThemMoi_ESSHoSo(_hoso)
                midx += 1
                marrID_sv.Add(ID_sv)

                ' Thêm vào danh sách lớp
                Dim objDSLop As New ESSDanhSach
                objDSLop.ID_lop = gID_lop
                objDSLop.ID_sv = objHoSo_Bussines.GetID_SV(_hoso.Ma_sv)
                Dim objDanhSachLop As New DanhSach_Bussines
                objDanhSachLop.ThemMoi_ESSDanhSach(objDSLop)
                ' Trả lại trang thái Sửa thông tin
                Edit = True
            End If
        End If
        If tabHoSoSinhVien.SelectedTab.Name = "TabTotNghiep" Then
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv")
            dt.Columns.Add("Dia_chi_day_du")
            dt.Columns.Add("So_dien_thoai")
            dt.Columns.Add("Di_dong")
            dt.Columns.Add("Fax")
            dt.Columns.Add("Email")
            dt.Columns.Add("ID_co_quan_lam_viec")
            dt.Columns.Add("ID_tinh_chat_cong_viec")
            dt.Columns.Add("Muc_thu_nhap_thang")
            dt.Columns.Add("ID_noi_lam_viec")
            Dim r As DataRow
            r = dt.NewRow
            r("ID_sv") = marrID_sv(midx)
            r("Dia_chi_day_du") = txtDia_chi_day_du.Text.Trim
            r("So_dien_thoai") = txtSo_dien_thoai.Text.Trim
            r("Di_dong") = txtDi_dong.Text.Trim
            r("Fax") = txtFax.Text.Trim
            r("Email") = txtEmail.Text.Trim
            r("ID_co_quan_lam_viec") = cmbID_co_quan_lam_viec.SelectedIndex
            r("ID_tinh_chat_cong_viec") = cmbID_tinh_chat_cong_viec.SelectedIndex
            r("Muc_thu_nhap_thang") = txtMuc_thu_nhap_thang.Text.Trim
            r("ID_noi_lam_viec") = cmbID_noi_lam_viec.SelectedIndex
            dt.Rows.Add(r)
            ' Cập nhật
            If objHoSo_Bussines.CheckExist_svHoSoSinhVienSub(marrID_sv(midx)) Then
                objHoSo_Bussines.CapNhat_ESSHoSoSinhVienSub(dt)
            Else ' Thêm mới
                objHoSo_Bussines.ThemMoi_ESSHoSoSinhVienSub(dt)
            End If
            Thongbao("Bạn đã lưu thông tin tốt nghiệp thành công !")
        End If
    End Sub

    Private Sub picAnh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAnh.Click
        With OPDMo_tep
            .InitialDirectory = Application.StartupPath
            .Filter = "Bitmaps|*.bmp|GIFs|*.gif|JPEGs|*.jpg"
            .FilterIndex = 1
        End With
        If OPDMo_tep.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim FileAnh As String = OPDMo_tep.FileName.Trim.ToLower.Substring(OPDMo_tep.FileName.Trim.Length - 3, 3)
            If FileAnh = "bmp" Or FileAnh = "gif" Or FileAnh = "jpg" Then
                FileAnh = "bmp"
                With Me.picAnh
                    .Image = Image.FromFile(OPDMo_tep.FileName)
                    .SizeMode = PictureBoxSizeMode.StretchImage
                    .BorderStyle = BorderStyle.Fixed3D
                    '.Image.PropertyItems = 1
                End With
            End If
        End If
    End Sub

    Private Sub cmbID_tinh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_tinh.SelectedIndexChanged
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dv As DataView
            dv = clsDM.LoadDanhMuc("select ID_huyen,Ten_huyen,ID_tinh from  STU_Huyen").DefaultView
            Dim dk As String = "1=1"
            If Not cmbID_tinh.SelectedValue Is Nothing Then dk += " And ID_tinh='" & cmbID_tinh.SelectedValue & "'"
            dv.RowFilter = dk
            FillCombo(cmbID_huyen, dv)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdChuyenNganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChuyenNganh.SelectedIndexChanged
        If Loader Then
            LoadHocTap()
        End If
    End Sub
#End Region
#Region "Tab Click"
    Private Sub tabHoSoSinhVien_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabHoSoSinhVien.Click
        Try
            If tabHoSoSinhVien.SelectedTab.Name = "tabRen_luyen" Then
                LoadDiemRenLuyen()
                LoadKhenThuong()
                LoadKyLuat()
                LoadDanhHieuCaNhan()
            End If
            If tabHoSoSinhVien.SelectedTab.Name = "tabKhac" Then
                LoadCanBoLop()
                LoadGiayToNop()
                LoadHoatDongXaHoi()
                LoadNoiNgoaiTru()
            End If
            If tabHoSoSinhVien.SelectedTab.Name = "tabLy_lich_bo_sung" Or tabHoSoSinhVien.SelectedTab.Name = "tabLy_lich" Then
            End If
            If tabHoSoSinhVien.SelectedTab.Name = "tabTai_chinh" Then
                LoadTaiChinh()
            End If
            If tabHoSoSinhVien.SelectedTab.Name = "tabHoc_tap" Then
                LoadHocTap()
            End If
            If tabHoSoSinhVien.SelectedTab.Name = "TabTotNghiep" Then
                LoadTotNghiep()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim cls As New DanhMuc_Bussines
            Dim ID_sv As Integer = marrID_sv(midx)
            Dim dt As DataTable
            Dim str As String = "select distinct ID_sv,ID_he,Khoa_hoc from  STU_DanhSach ds inner join STU_Lop l on ds.ID_lop=l.ID_lop where ds.ID_sv=" & ID_sv
            dt = cls.LoadDanhMuc(str)
            If dt.Rows.Count = 0 Then Exit Sub

            Dim Khoa_hoc As Integer = 0
            Dim ID_he As Integer = 0
            Khoa_hoc = IIf(dt.Rows(0)("Khoa_hoc").ToString = "", 0, dt.Rows(0)("Khoa_hoc"))
            ID_he = IIf(dt.Rows(0)("ID_he").ToString = "", 0, dt.Rows(0)("ID_he"))
            If ID_he = 0 Or Khoa_hoc = 0 Then
                Thongbao("Sinh viên chưa phân lớp !")
                Exit Sub
            End If
            Dim frmESS_ As New frmESS_ChuyenLop(Khoa_hoc, ID_sv, ID_he)
            frmESS_.ShowDialog()
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class