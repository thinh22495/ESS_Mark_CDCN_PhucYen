Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiChiHocPhiHocPhan
    Private mID_he As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_thu_chi As Integer = 2
    Private mDot_thu As Integer = 0
    Private mLan_thu As Integer = 0
    Private midx_bl As Integer = -1
    Private mID_bien_lai As Integer
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Private mSave As Boolean = False
    Public mAddNew As Boolean = True
    Private mclsBL As BienLaiThu_Bussines
    Private Ngoai_ngan_sach As Boolean = False
    Private clsKyDangKy As New HocKyDangKy_Bussines
#Region "Functions And Subs"
    Public Overloads Sub ShowDialog(ByVal ID_bien_lai As Integer, ByVal idx_bl As Integer, ByVal Ma_sv As String, ByVal clsBL As BienLaiThu_Bussines, ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_chi As Integer, ByVal Lan_chi As Integer)
        mID_bien_lai = ID_bien_lai
        midx_bl = idx_bl
        mclsBL = clsBL
        mID_he = ID_he
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mDot_thu = Dot_chi
        mLan_thu = Lan_chi
        txtMa_sv.Text = Ma_sv
        Me.ShowDialog()
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            'Load combobox loại thu chi
            dt = clsDM.DanhMuc_Load("ACC_LoaiThuChi", "ID_thu_chi", "Ten_thu_chi")
            FillCombo(cmbID_thu_chi, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadSinhVien(ByVal ID_sv As Integer)

        Dim clsDanhSach As New DanhSachSinhVien_Bussines(0, 0, ID_sv)
        If clsDanhSach.Count > 0 Then
            Dim objDanhSach As ESSDanhSachSinhVien = clsDanhSach.ESSDanhSachSinhVien(0)
            Dim objBL As ESSBienLaiThu
            labHo_ten.Text = objDanhSach.Ho_ten
            Dim clsSV As New ThongTinSinhVien_Bussines(objDanhSach.ID_sv)
            Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
            mID_he = objSV.ID_he
            labTen_lop.Text = objDanhSach.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
            txtMa_sv.Text = objDanhSach.Ma_sv
            'Kiểm tra xem đã tồn tại Đợt thu, Lần thu này chưa
            mclsBL = New BienLaiThu_Bussines
            mID_bien_lai = mclsBL.getID_bien_lai(ID_sv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, mID_thu_chi, 0)

            If mID_bien_lai > 0 Then 'Biên lai đã tồn tại thì sẽ hiện hết các học phần đã đăng ký
                'Load phiếu
                mclsBL = New BienLaiThu_Bussines(mID_bien_lai)
                objBL = mclsBL.ESSBienLaiThu(0)
                midx_bl = mclsBL.Tim_idx(ID_sv)
                LoadBienLai(objBL)
                labTong_so_tien_nop.Text = Format(objBL.So_tien, "###,###")
                txtSo_tien.Text = objBL.So_tien
            Else    'Viết biên lai mới thi lại nhưng Học phần dã thu
                'Load số phiếu
                txtSo_phieu.Text = mclsBL.getSo_phieu()
                'Mặc định nội dung
                txtNoi_dung.Text = "Chi miễn giảm học phí học kỳ " + cmbHoc_ky.Text + " năm học " + cmbNam_hoc.Text
                midx_bl = -1
            End If

            Dim dtMucHocPhi As DataTable = mclsBL.HienThi_ESSMucHocPhiTinChi_DanhSach(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he)
            Ngoai_ngan_sach = objDanhSach.Ngoai_ngan_sach

            Dim dv As DataView = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he).DefaultView
            dv.Sort = "Nam_hoc"
            Dim dtTongHop As DataTable = dv.Table
            grdThuChi.DataSource = dv
            HienThiTongHocPhi(dtTongHop)
        Else
            Thongbao("Bạn không được cấp quyền thu học phí sinh viên này!")
        End If
    End Sub
    Private Sub LoadBienLai(ByVal objBL As ESSBienLaiThu)
        Dim idx As Integer
        cmbHoc_ky.SelectedValue = objBL.Hoc_ky
        cmbNam_hoc.Text = objBL.Nam_hoc
        cmbDot_thu.SelectedIndex = objBL.Dot_thu - 1
        cmbLan_thu.SelectedIndex = objBL.Lan_thu - 1
        idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, mID_thu_chi)
        If idx >= 0 Then
            cmbID_thu_chi.SelectedValue = objBL.dsBienLaiChiTiet.BienLaiChiTiet(idx).ID_thu_chi
        End If
        cmbID_thu_chi.Enabled = False
        dtpNgay_thu.Value = objBL.Ngay_thu
        txtSo_phieu.Text = objBL.So_phieu
        cmbLoai_tien.Text = objBL.Ngoai_te
        txtMa_sv.Text = objBL.Ma_sv
        labHo_ten.Text = objBL.Ho_ten
        If labTen_lop.Text = "" Then
            labTen_lop.Text = objBL.Ten_lop
        End If
        txtNoi_dung.Text = objBL.Noi_dung
        txtSo_tien.Text = objBL.So_tien
        'Me.txtMa_sv.ReadOnly = True
        'Me.btnLoc_sv.Enabled = False
    End Sub
    Private Sub HienThiTongHocPhi(ByVal dtTongHop As DataTable)
        Dim Tong_so_tien_nop, Tong_so_tien_da_nop, Tong_so_tien_thua_thieu, So_tien_phai_chi As Integer
        Tong_so_tien_nop = 0
        Tong_so_tien_da_nop = 0
        Tong_so_tien_thua_thieu = 0
        So_tien_phai_chi = 0
        For i As Integer = 0 To dtTongHop.Rows.Count - 1
            If dtTongHop.Rows(i)("Hoc_ky") = mHoc_ky And dtTongHop.Rows(i)("Nam_hoc") = mNam_hoc Then
                So_tien_phai_chi = 0 - dtTongHop.Rows(i)("Thieu_thua")
            End If
            If dtTongHop.Rows(i)("So_tien_nop").ToString <> "" Then Tong_so_tien_nop += dtTongHop.Rows(i)("So_tien_nop")
            If dtTongHop.Rows(i)("So_tien_da_nop").ToString <> "" Then Tong_so_tien_da_nop += dtTongHop.Rows(i)("So_tien_da_nop")
            If dtTongHop.Rows(i)("Thieu_thua").ToString <> "" Then Tong_so_tien_thua_thieu += dtTongHop.Rows(i)("Thieu_thua")
        Next
        If mID_bien_lai <= 0 Then
            labTong_so_tien_nop.Text = Format(So_tien_phai_chi, "###,###0")
            txtSo_tien.Text = So_tien_phai_chi
        End If
        lblTong_phai_nop.Text = Format(Tong_so_tien_nop, "###,###0") + "đ"
        lblTong_da_nop.Text = Format(Tong_so_tien_da_nop, "###,###0") + "đ"
        lblTong_thua_thieu.Text = Format(Tong_so_tien_thua_thieu, "###,###0")
    End Sub
    Private Function CheckValidate() As Boolean
        If cmbHoc_ky.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn học kỳ")
            cmbHoc_ky.Focus()
            Return False
        End If
        If cmbNam_hoc.Text = "" Then
            Thongbao("Bạn phải chọn năm học")
            cmbNam_hoc.Focus()
            Return False
        End If
        If cmbDot_thu.SelectedIndex = -1 Then
            Thongbao("Bạn phải chọn đợt thu")
            cmbDot_thu.Focus()
            Return False
        End If
        If cmbLan_thu.SelectedIndex = -1 Then
            Thongbao("Bạn phải chọn lần thu")
            cmbLan_thu.Focus()
            Return False
        End If
        If cmbID_thu_chi.SelectedIndex = -1 Then
            Thongbao("Bạn phải chọn loại thu chi")
            cmbID_thu_chi.Focus()
            Return False
        End If
        If cmbLoai_tien.SelectedIndex = -1 Then
            Thongbao("Bạn phải chọn loại tiền")
            cmbLoai_tien.Focus()
            Return False
        End If
        If txtNoi_dung.Text = "" Then
            Thongbao("Bạn phải nhập nội dung")
            txtNoi_dung.Focus()
            Return False
        End If
        Return True
    End Function

#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetQuyenTruyCap(cmdSave, , , )
        LoadComboBox()
        'Edit bien lai
        If mID_bien_lai > 0 Then
            Dim objBL As ESSBienLaiThu
            objBL = mclsBL.BienLaiThu_ID_bien_lai(mID_bien_lai)
            cmbHoc_ky.SelectedValue = objBL.Hoc_ky
            cmbNam_hoc.Text = objBL.Nam_hoc
            cmbDot_thu.SelectedIndex = objBL.Dot_thu - 1
            cmbLan_thu.SelectedIndex = objBL.Lan_thu - 1
            mID_sv = objBL.ID_sv
            LoadSinhVien(mID_sv)
        ElseIf txtMa_sv.Text <> "" Then   'Add new bien lai
            'Set default value
            cmbHoc_ky.SelectedValue = mHoc_ky
            cmbNam_hoc.Text = mNam_hoc
            cmbDot_thu.SelectedIndex = mDot_thu - 1
            cmbLan_thu.SelectedIndex = mLan_thu - 1
            cmbID_thu_chi.SelectedValue = mID_thu_chi
            cmbLoai_tien.SelectedIndex = 0
            Dim ID_sv As Integer = 0
            mclsBL = New BienLaiThu_Bussines
            ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
            If ID_sv > 0 Then
                mID_sv = ID_sv
                LoadSinhVien(ID_sv)
            End If
        Else
            'Set default value
            cmbHoc_ky.SelectedValue = mHoc_ky
            cmbNam_hoc.Text = mNam_hoc
            cmbDot_thu.SelectedIndex = mDot_thu - 1
            cmbLan_thu.SelectedIndex = mLan_thu - 1
            cmbID_thu_chi.SelectedValue = mID_thu_chi
            cmbLoai_tien.SelectedIndex = 0
            txtMa_sv.Focus()
        End If
        Loader = True
    End Sub
    Private Sub frmESS_BienLaiThu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_BienLaiThu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Control"
    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        If mAddNew Then
            Dim ID_sv As Integer = 0
            If txtMa_sv.Text.Trim <> "" Then
                mclsBL = New BienLaiThu_Bussines
                ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
                If ID_sv > 0 Then
                    mID_sv = ID_sv
                    LoadSinhVien(ID_sv)
                    mSave = False
                Else
                    mID_sv = 0
                    txtMa_sv.Focus()
                    Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
                End If
            Else
                Me.btnLoc_sv.Focus()
            End If
        End If
    End Sub
    Private Sub txtSo_tien_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSo_tien.TextChanged
        If txtSo_tien.Text <> "" Then
            lblSo_tien_chu_nop.Text = "(" + ChuyenChu(txtSo_tien.Text) + " đồng)"
        Else
            lblSo_tien_chu_nop.Text = ""
        End If
    End Sub
    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbDot_thu.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        If Loader And mID_sv > 0 Then
            LoadSinhVien(mID_sv)
        End If
    End Sub
    Private Sub btnLoc_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoc_sv.Click
        Dim frmESS_ As New frmESS_SearchSinhVien
        frmESS_.ShowDialog()
        If frmESS_.Tag = 1 Then
            mID_sv = frmESS_.mID_sv
            If mID_sv > 0 Then
                LoadSinhVien(mID_sv)
                mSave = False
            Else
                mID_sv = 0
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            Dim ID_bien_lai, ID_bien_lai_sub As Integer
            If mID_bien_lai > 0 Then    'Edit biên lai
                'Update biên lai main
                Dim objBL As New ESSBienLaiThu
                objBL = mclsBL.ESSBienLaiThu(midx_bl)
                objBL.Hoc_ky = cmbHoc_ky.SelectedValue
                objBL.Nam_hoc = cmbNam_hoc.Text
                objBL.Dot_thu = cmbDot_thu.SelectedIndex + 1
                objBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
                objBL.Ngay_thu = dtpNgay_thu.Value
                objBL.Noi_dung = txtNoi_dung.Text
                objBL.So_tien = txtSo_tien.Text
                objBL.So_tien_chu = lblSo_tien_chu_nop.Text
                objBL.Huy_phieu = False
                mclsBL.CapNhat_ESSBienLaiThu(objBL, objBL.ID_bien_lai)
                'Update Học phần được chọn
                objBL.dsBienLaiChiTiet.BienLaiChiTiet(0).So_tien = txtSo_tien.Text
                ID_bien_lai_sub = mclsBL.CapNhat_ESSBienLaiThuChiTiet(objBL.dsBienLaiChiTiet.BienLaiChiTiet(0), objBL.dsBienLaiChiTiet.BienLaiChiTiet(0).ID_bien_lai_sub)
            ElseIf midx_bl = -1 And mID_bien_lai <= 0 Then   'Add New biên lai
                Dim objBL As New ESSBienLaiThu
                objBL.So_phieu = mclsBL.getSo_phieu()
                txtSo_phieu.Text = objBL.So_phieu
                objBL.ID_sv = mID_sv
                objBL.Ma_sv = txtMa_sv.Text
                objBL.Ho_ten = labHo_ten.Text
                objBL.Ten_lop = labTen_lop.Text
                objBL.Hoc_ky = cmbHoc_ky.SelectedValue
                objBL.Nam_hoc = cmbNam_hoc.Text
                objBL.Dot_thu = cmbDot_thu.SelectedIndex + 1
                objBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
                objBL.Ngay_thu = dtpNgay_thu.Value
                objBL.Noi_dung = txtNoi_dung.Text
                objBL.So_tien = txtSo_tien.Text
                objBL.So_tien_chu = lblSo_tien_chu_nop.Text
                objBL.Nguoi_thu = gobjUser.UserName
                objBL.Ngoai_te = cmbLoai_tien.Text
                objBL.Thu_chi = 0
                ID_bien_lai = mclsBL.ThemMoi_ESSBienLaiThu(objBL)
                mID_bien_lai = ID_bien_lai
                'Insert Học phần được chọn
                Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                objBLChiTiet.ID_bien_lai = ID_bien_lai
                objBLChiTiet.ID_thu_chi = cmbID_thu_chi.SelectedValue
                objBLChiTiet.ID_mon_tc = -1
                objBLChiTiet.So_tien = txtSo_tien.Text
                'Add database
                ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
            End If
            mSave = True
            LoadSinhVien(mID_sv)
            'In phiếu
            If chkPrint.Checked Then
                cmdPrint_Click(sender, e)
            End If
            Thongbao("Đã cập nhật thành công !")
        End If
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dtMain As New DataTable
            dtMain.Columns.Add("So_phieu")
            dtMain.Columns.Add("Loai_bienlai")
            dtMain.Columns.Add("Ngay_thu", GetType(Date))
            dtMain.Columns.Add("Ho_ten")
            dtMain.Columns.Add("Ma_sv")
            dtMain.Columns.Add("Ten_lop")
            dtMain.Columns.Add("Noi_dung")
            dtMain.Columns.Add("So_tien", GetType(Double))
            dtMain.Columns.Add("So_tien_chu")
            dtMain.Columns.Add("So_tien_con")
            dtMain.Columns.Add("Hoc_phan")
            dtMain.Columns.Add("FullName")
            Dim drMain As DataRow
            drMain = dtMain.NewRow
            drMain("So_phieu") = txtSo_phieu.Text
            drMain("Loai_bienlai") = "CHI"
            drMain("Ngay_thu") = dtpNgay_thu.Value
            drMain("Ho_ten") = labHo_ten.Text
            drMain("Ma_sv") = txtMa_sv.Text
            drMain("Ten_lop") = labTen_lop.Text
            drMain("Noi_dung") = txtNoi_dung.Text
            If txtSo_tien.Text <> "" Then
                drMain("So_tien") = txtSo_tien.Text
                drMain("So_tien_chu") = ChuyenChu(txtSo_tien.Text) + " đồng"
            End If
            drMain("So_tien_con") = 0 - CType(IIf(lblTong_thua_thieu.Text.Trim = "", 0, lblTong_thua_thieu.Text.Trim), Integer)
            dtMain.Rows.Add(drMain)

            Me.Cursor = Cursors.WaitCursor
            Dim frmESS_ As New frmESS_ReportView
            If chkPrint.Checked Then
                frmESS_.PrintBienLai("BIENLAI_MAIN_CHI", dtMain)
                Me.Cursor = Cursors.Default
            Else
                frmESS_.ShowDialogBienLai("BIENLAI_MAIN_CHI", dtMain)
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Property"
    Public Property Save() As Boolean
        Get
            Return mSave
        End Get
        Set(ByVal Value As Boolean)
            mSave = Value
        End Set
    End Property
    Public Property AddNew() As Boolean
        Get
            Return mAddNew
        End Get
        Set(ByVal Value As Boolean)
            mAddNew = Value
        End Set
    End Property
#End Region
End Class