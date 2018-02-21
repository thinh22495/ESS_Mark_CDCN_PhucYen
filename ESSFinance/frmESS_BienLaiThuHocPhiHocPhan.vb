Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuHocPhiHocPhan
    Private mID_he As Integer = 0
    Private mID_lops As String = ""
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mDot_thu As Integer = 0
    Private mLan_thu As Integer = 0
    Private mID_thu_chi As Integer = 0
    Private midx_bl As Integer = -1
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Public mAddNew As Boolean = True
    Private mclsBL As BienLaiThu_Bussines
    Private mID_bien_lai As Integer = 0 ' Để biết khi sửa biên lai
    Private Ngoai_ngan_sach As Boolean = False
    Private clsKyDangKy As New HocKyDangKy_Bussines
#Region "Functions And Subs"
    Public Overloads Sub ShowDialog(ByVal ID_bien_lai As Integer, ByVal idx_bl As Integer, ByVal clsBL As BienLaiThu_Bussines, ByVal ID_he As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer, ByVal ID_thu_chi As Integer)
        mID_bien_lai = ID_bien_lai
        midx_bl = idx_bl
        mclsBL = clsBL
        mID_he = ID_he
        mID_lops = ID_lops
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mDot_thu = Dot_thu
        mLan_thu = Lan_thu
        mID_thu_chi = ID_thu_chi
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
    Private Sub LoadThongTinTaiChinhSinhVien(ByVal ID_sv As Integer)
        grdMonThu.Enabled = True
        chkSelectAll.Enabled = True
        EnableControl(True)

        Dim clsDanhSach As New DanhSachSinhVien_Bussines(0, 0, ID_sv)
        If clsDanhSach.Count > 0 Then
            Dim objDanhSach As ESSDanhSachSinhVien = clsDanhSach.ESSDanhSachSinhVien(0)
            Dim ID_bien_lai As Integer
            labHo_ten.Text = objDanhSach.Ho_ten
            Dim clsSV As New ThongTinSinhVien_Bussines(objDanhSach.ID_sv)
            Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
            mID_he = objSV.ID_he
            labTen_lop.Text = objDanhSach.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
            txtMa_sv.Text = objDanhSach.Ma_sv
            'Kiểm tra xem đã tồn tại Đợt thu, Lần thu này chưa
            mclsBL = New BienLaiThu_Bussines
            ID_bien_lai = mclsBL.getID_bien_lai(ID_sv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, mID_thu_chi, 1)

            If ID_bien_lai > 0 Then
                'Nếu đang chọn thêm mới mà laod được phiếu đã tồn tại thì khong cho sửa
                If mAddNew Then EnableControl(False)
                'Hiển thị các học phần đã nộp
                Dim dtMucHocPhi As DataTable = mclsBL.HienThi_ESSMucHocPhiTinChi_DanhSach(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he)
                Ngoai_ngan_sach = objDanhSach.Ngoai_ngan_sach
                Dim dtMonThu As DataTable
                If AddNew Then
                    'Nếu là đang thêm mới thì chỉ hiện các học phần trong biên lai
                    dtMonThu = mclsBL.LoadBienLaiChiTiet(dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, ID_sv, ID_bien_lai)
                Else
                    'Nếu là sửa thì hiện thêm cả học phần chưa đóng
                    mclsBL = New BienLaiThu_Bussines(ID_bien_lai)
                    dtMonThu = mclsBL.DanhSachHocPhanBienLaiThu(dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, 0, ID_sv, cmbID_thu_chi.SelectedValue, 0, CInt(cmbLan_thu.Text))
                End If
                If dtMonThu.Rows.Count = 0 Then Thongbao("Sinh viên không thu theo tin chỉ, hoặc đăng ký chưa được duyệt!", MsgBoxStyle.OkOnly)
                Me.grdMonThu.DataSource = dtMonThu.DefaultView
                Dim so_tien_phai_nop As Integer = 0
                Dim so_tien_phai_nop_tru_mien_giam As Integer = 0
                For i As Integer = 0 To dtMonThu.Rows.Count - 1
                    so_tien_phai_nop += CInt(dtMonThu.Rows(i)("so_tien"))
                    so_tien_phai_nop_tru_mien_giam += (CInt(dtMonThu.Rows(i)("so_tien")) - CInt("0" & dtMonThu.Rows(i)("So_tien_mien_giam")))
                Next
                labTong_so_tien_nop.Text = Format(so_tien_phai_nop, "###,###")
                labTong_so_tien_nop_tru_mien_giam.Text = Format(so_tien_phai_nop_tru_mien_giam, "###,###")
                '                Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi_New(, , , , , , , ID_sv)
                Dim dv As DataView = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he).DefaultView
                dv.Sort = "Nam_hoc"
                Dim dtTongHop As DataTable = dv.Table
                grdThuChi.DataSource = dv
                HienThiTongHocPhi(dtTongHop)
                'Load phiếu
                Dim objBL As ESSBienLaiThu
                mclsBL = New BienLaiThu_Bussines(ID_bien_lai)
                objBL = mclsBL.ESSBienLaiThu(0)
                LoadThongTinBienLai(objBL)
            Else    'Viết biên lai mới thì loại những Học phần dã thu
                dtpNgay_thu.Value = Today
                midx_bl = -1
                'Load số phiếu
                txtSo_phieu.Text = mclsBL.getSo_phieu()
                'Mặc định nội dung
                txtNoi_dung.Text = "Nộp " + cmbID_thu_chi.Text + " đợt " + cmbLan_thu.Text + " học kỳ " + cmbHoc_ky.Text + " năm học " + cmbNam_hoc.Text
                '
                Dim dtMucHocPhi As DataTable = mclsBL.HienThi_ESSMucHocPhiTinChi_DanhSach(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he)
                Ngoai_ngan_sach = objDanhSach.Ngoai_ngan_sach
                'Load thông tin những Học phần sinh viên đăng ký trong học kỳ
                Dim dtMonThu As DataTable = mclsBL.DanhSachHocPhanBienLaiThu(dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, 0, ID_sv, cmbID_thu_chi.SelectedValue, midx_bl, CInt(cmbLan_thu.Text))
                If dtMonThu.Rows.Count = 0 Then Thongbao("Sinh viên không thu theo tin chỉ, hoặc đăng ký chưa được duyệt!", MsgBoxStyle.OkOnly)
                Me.grdMonThu.DataSource = dtMonThu.DefaultView
                Dim so_tien_phai_nop As Integer = 0
                Dim so_tien_phai_nop_tru_mien_giam As Integer = 0
                For i As Integer = 0 To dtMonThu.Rows.Count - 1
                    so_tien_phai_nop += CInt(dtMonThu.Rows(i)("so_tien"))
                    so_tien_phai_nop_tru_mien_giam += (CInt(dtMonThu.Rows(i)("so_tien")) - CInt("0" & dtMonThu.Rows(i)("So_tien_mien_giam")))
                Next
                labTong_so_tien_nop.Text = Format(so_tien_phai_nop, "###,###")
                labTong_so_tien_nop_tru_mien_giam.Text = Format(so_tien_phai_nop_tru_mien_giam, "###,###")
                'Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi_New(, , , , , , , ID_sv)
                Dim dv As DataView = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he).DefaultView
                dv.Sort = "Nam_hoc"
                Dim dtTongHop As DataTable = dv.Table
                grdThuChi.DataSource = dv
                HienThiTongHocPhi(dtTongHop)
            End If
        Else
            Thongbao("Bạn không được cấp quyền thu học phí sinh viên này!")
        End If
    End Sub
    Private Sub LoadThongTinBienLai(ByVal objBL As ESSBienLaiThu)
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
        Dim Tong_so_tien_nop, Tong_so_tien_da_nop, Tong_so_tien_thua_thieu As Integer
        Tong_so_tien_nop = 0
        Tong_so_tien_da_nop = 0
        Tong_so_tien_thua_thieu = 0
        For i As Integer = 0 To dtTongHop.Rows.Count - 1
            If dtTongHop.Rows(i)("So_tien_nop").ToString <> "" Then Tong_so_tien_nop += dtTongHop.Rows(i)("So_tien_nop")
            If dtTongHop.Rows(i)("So_tien_da_nop").ToString <> "" Then Tong_so_tien_da_nop += dtTongHop.Rows(i)("So_tien_da_nop")
            If dtTongHop.Rows(i)("Thieu_thua").ToString <> "" Then Tong_so_tien_thua_thieu += dtTongHop.Rows(i)("Thieu_thua")
        Next
        lblTong_phai_nop.Text = Format(Tong_so_tien_nop, "###,###0") + "đ"
        lblTong_da_nop.Text = Format(Tong_so_tien_da_nop, "###,###0") + "đ"
        lblTong_thua_thieu.Text = Format(Tong_so_tien_thua_thieu, "###,###0")
    End Sub
    Private Function CheckValidate() As Boolean
        If txtSo_tien.Text.Trim = "" Then
            Thongbao("Bạn phải chọn học phần sinh viên nộp học phí để hệ thống tinh s số tiền nộp !")
            txtSo_tien.Focus()
            Return False
        ElseIf Not IsNumeric(txtSo_tien.Text.Trim) Then
            Thongbao("Số tiền nộp bằng số !")
            txtSo_tien.Focus()
            Return False
        End If
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
        If labTong_so_tien_nop.Text = "" Or labTong_so_tien_nop.Text = "0" Then
            Thongbao("Bạn phải chọn học phần để thu tiền")
            grdMonThu.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub EnableControl(ByVal Status As Boolean)
        dtpNgay_thu.Enabled = Status
        cmbLoai_tien.Enabled = Status
        txtNoi_dung.Enabled = Status
        txtSo_tien.Enabled = Status
        grdMonThu.Enabled = Status
        chkSelectAll.Enabled = Status
        cmdSave.Enabled = Status
    End Sub
    Private Sub ClearControl()
        lblSo_tien_chu_nop.Text = ""
        lblSo_tien_chu_phai_nop.Text = ""
        lblTong_da_nop.Text = ""
        lblTong_thua_thieu.Text = ""
        grdMonThu.DataSource = Nothing
        grdThuChi.DataSource = Nothing
        txtMa_sv.Text = ""
        txtSo_phieu.Text = ""
        txtSo_tien.Text = ""
        txtNoi_dung.Text = ""
        chkSelectAll.Checked = False
    End Sub
#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetUpDataGridView(grdMonThu)
        SetQuyenTruyCap(cmdSave, , , )
        LoadComboBox()
        If mID_bien_lai > 0 Then    ' Edit biên lai
            Dim objBL As ESSBienLaiThu
            objBL = mclsBL.BienLaiThu_ID_bien_lai(mID_bien_lai)
            cmbHoc_ky.SelectedValue = objBL.Hoc_ky
            cmbNam_hoc.Text = objBL.Nam_hoc
            cmbDot_thu.SelectedIndex = objBL.Dot_thu - 1
            cmbLan_thu.SelectedIndex = objBL.Lan_thu - 1
            mID_sv = objBL.ID_sv
            LoadThongTinTaiChinhSinhVien(mID_sv)
            txtMa_sv.Enabled = False     'Chỉ được sửa số phiếu này thôi
            cmbHoc_ky.Enabled = False
            cmbNam_hoc.Enabled = False
            cmbDot_thu.Enabled = False
            cmbLan_thu.Enabled = False
        Else    'Add new biên lai, set default value
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
        If e.KeyCode = Keys.Enter Then Call txtMa_sv_Leave(sender, e)
    End Sub
#End Region
#Region "Control"

    Private Sub grdMonThu_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMonThu.Click
        grdMonThu.EndEdit()
        If grdMonThu.Enabled = False Then
            Thongbao("Phiếu đã lưu không thể sửa lại trong khi thêm mới. Nếu bạn muốn sửa bạn phải sử dụng chức năng: Sửa phiểu", MsgBoxStyle.OkOnly)
        End If
        Try
            Dim dv As DataView = grdMonThu.DataSource
            Dim Tong_so_tien As Integer
            If Not dv Is Nothing Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") And dv.Item(i)("So_tien_nop").ToString <> "" Then
                        Tong_so_tien += dv.Item(i)("So_tien_nop")
                    End If
                Next
                'labTong_so_tien_nop.Text = Format(Tong_so_tien, "###,###")
                txtSo_tien.Text = Format(Tong_so_tien, "###,###")
                If labTong_so_tien_nop.Text <> "" Then
                    lblSo_tien_chu_phai_nop.Text = "(" + ChuyenChu(labTong_so_tien_nop.Text) + " đồng)"
                Else
                    lblSo_tien_chu_phai_nop.Text = ""
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub grdMonThu_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMonThu.CurrentCellChanged, grdMonThu.DataSourceChanged
        Try
            Dim dv As DataView = grdMonThu.DataSource
            Dim Tong_so_tien As Integer
            If Not dv Is Nothing Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") And dv.Item(i)("So_tien_nop").ToString <> "" Then
                        Tong_so_tien += dv.Item(i)("So_tien_nop")
                    End If
                Next
                'labTong_so_tien_nop.Text = Format(Tong_so_tien, "###,###")
                txtSo_tien.Text = Format(Tong_so_tien, "###,###")
                If labTong_so_tien_nop.Text <> "" Then
                    lblSo_tien_chu_phai_nop.Text = "(" + ChuyenChu(labTong_so_tien_nop.Text) + " đồng)"
                Else
                    lblSo_tien_chu_phai_nop.Text = ""
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        If mAddNew Then
            Dim ID_sv As Integer = 0
            If txtMa_sv.Text.Trim <> "" Then
                mclsBL = New BienLaiThu_Bussines
                ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
                If ID_sv > 0 Then
                    mID_sv = ID_sv
                    LoadThongTinTaiChinhSinhVien(ID_sv)
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
    Private Sub chkSelectAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSelectAll.CheckedChanged
        If Not IsNothing(grdMonThu.DataSource) Then
            Dim dvHP As DataView = grdMonThu.DataSource
            For i As Integer = 0 To dvHP.Count - 1
                dvHP.Item(i)("Chon") = chkSelectAll.Checked
            Next
            dvHP.Table.AcceptChanges()
        End If
    End Sub
    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbDot_thu.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        If Loader And mID_sv > 0 Then
            LoadThongTinTaiChinhSinhVien(mID_sv)
        End If
    End Sub
    Private Sub btnLoc_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoc_sv.Click
        Dim frmESS_ As New frmESS_SearchSinhVien
        frmESS_.ShowDialog()
        If frmESS_.Tag = 1 Then
            mID_sv = frmESS_.mID_sv
            If mID_sv > 0 Then
                LoadThongTinTaiChinhSinhVien(mID_sv)
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
                objBL = mclsBL.BienLaiThu_ID_bien_lai(mID_bien_lai)
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
                'Update biên lai sub
                Dim dv As DataView = grdMonThu.DataSource
                'Remove tất cả các Học phần cũ
                For i As Integer = objBL.dsBienLaiChiTiet.Count - 1 To 0 Step -1
                    'Delete Database
                    mclsBL.Xoa_ESSBienLaiThuChiTiet(objBL.dsBienLaiChiTiet.BienLaiChiTiet(i).ID_bien_lai_sub)
                    'Remove Object
                    objBL.dsBienLaiChiTiet.Remove(i)
                Next
                'Insert Học phần được chọn
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") Then
                        Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                        objBLChiTiet.ID_bien_lai = objBL.ID_bien_lai
                        objBLChiTiet.ID_thu_chi = cmbID_thu_chi.SelectedValue
                        objBLChiTiet.ID_mon_tc = dv.Item(i)("ID_mon_tc")
                        objBLChiTiet.So_tien = dv.Item(i)("So_tien_nop")
                        'Add database
                        ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
                        'Add object
                        objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he)
                Me.grdThuChi.DataSource = dtTongHop.DefaultView
                HienThiTongHocPhi(dtTongHop)
                grdMonThu.Enabled = False
            ElseIf mAddNew Then   'Add New biên lai
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
                objBL.Thu_chi = 1
                ID_bien_lai = mclsBL.ThemMoi_ESSBienLaiThu(objBL)
                'Insert Học phần được chọn
                Dim dv As DataView = grdMonThu.DataSource
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") Then
                        Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                        objBLChiTiet.ID_bien_lai = ID_bien_lai
                        objBLChiTiet.ID_thu_chi = cmbID_thu_chi.SelectedValue
                        objBLChiTiet.ID_mon_tc = dv.Item(i)("ID_mon_tc")
                        objBLChiTiet.So_tien = dv.Item(i)("So_tien_nop")
                        'Add database
                        ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
                        'Add object
                        objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he)
                Me.grdThuChi.DataSource = dtTongHop.DefaultView
                HienThiTongHocPhi(dtTongHop)
                'In phiếu
                If chkPrint.Checked Then
                    cmdPrint_Click(sender, e)
                End If
                ClearControl()
            End If
            Thongbao("Đã cập nhật thành công !")
        End If
        'If CheckValidate() Then
        '    Dim ID_bien_lai, ID_bien_lai_sub As Integer
        '    If midx_bl >= 0 Then    'Edit biên lai
        '        'Update biên lai main
        '        Dim objBL As New ESSBienLaiThu
        '        objBL = mclsBL.ESSBienLaiThu(0)
        '        objBL.Hoc_ky = cmbHoc_ky.SelectedValue
        '        objBL.Nam_hoc = cmbNam_hoc.Text
        '        objBL.Dot_thu = cmbDot_thu.SelectedIndex + 1
        '        objBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
        '        objBL.Ngay_thu = dtpNgay_thu.Value
        '        objBL.Noi_dung = txtNoi_dung.Text
        '        objBL.So_tien = txtSo_tien.Text
        '        objBL.So_tien_chu = lblSo_tien_chu_nop.Text
        '        objBL.Huy_phieu = False
        '        mclsBL.CapNhat_ESSBienLaiThu(objBL, objBL.ID_bien_lai)
        '        'Update biên lai sub
        '        Dim dv As DataView = grdMonThu.DataSource
        '        'Remove tất cả các Học phần cũ
        '        For i As Integer = objBL.dsBienLaiChiTiet.Count - 1 To 0 Step -1
        '            'Delete Database
        '            mclsBL.Xoa_ESSBienLaiThuChiTiet(objBL.dsBienLaiChiTiet.BienLaiChiTiet(i).ID_bien_lai_sub)
        '            'Remove Object
        '            objBL.dsBienLaiChiTiet.Remove(i)
        '        Next
        '        'Insert Học phần được chọn
        '        For i As Integer = 0 To dv.Count - 1
        '            If dv.Item(i)("Chon") Then
        '                Dim objBLChiTiet As New ESSBienLaiThuChiTiet
        '                objBLChiTiet.ID_bien_lai = objBL.ID_bien_lai
        '                objBLChiTiet.ID_thu_chi = cmbID_thu_chi.SelectedValue
        '                objBLChiTiet.ID_mon_tc = dv.Item(i)("ID_mon_tc")
        '                objBLChiTiet.So_tien = dv.Item(i)("So_tien_nop")
        '                'Add database
        '                ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
        '                'Add object
        '                objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
        '                objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
        '            End If
        '        Next
        '        Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he)
        '        Me.grdThuChi.DataSource = dtTongHop.DefaultView
        '        HienThiTongHocPhi(dtTongHop)
        '        grdMonThu.Enabled = False
        '    ElseIf mAddNew Then   'Add New biên lai
        '        Dim objBL As New ESSBienLaiThu
        '        objBL.So_phieu = mclsBL.getSo_phieu()
        '        txtSo_phieu.Text = objBL.So_phieu
        '        objBL.ID_sv = mID_sv
        '        objBL.Ma_sv = txtMa_sv.Text
        '        objBL.Ho_ten = labHo_ten.Text
        '        objBL.Ten_lop = labTen_lop.Text
        '        objBL.Hoc_ky = cmbHoc_ky.SelectedValue
        '        objBL.Nam_hoc = cmbNam_hoc.Text
        '        objBL.Dot_thu = cmbDot_thu.SelectedIndex + 1
        '        objBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
        '        objBL.Ngay_thu = dtpNgay_thu.Value
        '        objBL.Noi_dung = txtNoi_dung.Text
        '        objBL.So_tien = txtSo_tien.Text
        '        objBL.So_tien_chu = lblSo_tien_chu_nop.Text
        '        objBL.Nguoi_thu = gobjUser.UserName
        '        objBL.Ngoai_te = cmbLoai_tien.Text
        '        objBL.Thu_chi = 1
        '        ID_bien_lai = mclsBL.ThemMoi_ESSBienLaiThu(objBL)
        '        'Insert Học phần được chọn
        '        Dim dv As DataView = grdMonThu.DataSource
        '        For i As Integer = 0 To dv.Count - 1
        '            If dv.Item(i)("Chon") Then
        '                Dim objBLChiTiet As New ESSBienLaiThuChiTiet
        '                objBLChiTiet.ID_bien_lai = ID_bien_lai
        '                objBLChiTiet.ID_thu_chi = cmbID_thu_chi.SelectedValue
        '                objBLChiTiet.ID_mon_tc = dv.Item(i)("ID_mon_tc")
        '                objBLChiTiet.So_tien = dv.Item(i)("So_tien_nop")
        '                'Add database
        '                ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
        '                'Add object
        '                objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
        '                objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
        '            End If
        '        Next
        '        Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he)
        '        Me.grdThuChi.DataSource = dtTongHop.DefaultView
        '        HienThiTongHocPhi(dtTongHop)
        '        'In phiếu
        '        If chkPrint.Checked Then
        '            cmdPrint_Click(sender, e)
        '        End If
        '        ClearControl()
        '    End If
        '    Thongbao("Đã cập nhật thành công !")
        'End If

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
            drMain("Loai_bienlai") = "THU"
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
            Dim Hoc_phan As String = ""
            Dim dv As DataView = grdMonThu.DataSource
            For i As Integer = 0 To dv.Count - 1
                If Not dv.Item(i)("Chon") Then
                    If Hoc_phan.Trim = "" Then
                        Hoc_phan = dv.Item(i)("Ten_mon")
                    Else
                        Hoc_phan += "," & dv.Item(i)("Ten_mon")
                    End If
                End If
            Next
            drMain("Hoc_phan") = Hoc_phan
            drMain("FullName") = gobjUser.FullName
            dtMain.Rows.Add(drMain)
            Dim dtSub As DataTable = grdMonThu.DataSource.Table
            Dim dtSub1 As DataTable = dtSub.Copy
            dtSub1.Columns.Add("STT", GetType(Integer))
            dtSub1.Columns.Add("Thuc_nop", GetType(String))
            For i As Integer = 0 To dtSub1.Rows.Count - 1
                dtSub1.Rows(i)("STT") = i + 1
                If dtSub1.Rows(i)("Chon") = True Then
                    dtSub1.Rows(i)("Thuc_nop") = dtSub1.Rows(i)("So_tien_nop")
                End If
            Next
            Me.Cursor = Cursors.WaitCursor
            Dim frmESS_ As New frmESS_ReportView
            If chkPrint.Checked Then
                frmESS_.PrintBienLai("BIENLAI_MAIN", dtMain, "BIENLAI_SUB", dtSub1, "Subreport1", "Subreport2")
                Me.Cursor = Cursors.Default
            Else
                frmESS_.ShowDialogBienLai("BIENLAI_MAIN", dtMain, "BIENLAI_SUB", dtSub1, "Subreport1", "Subreport2")
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
    Public Property AddNew() As Boolean
        Get
            Return mAddNew
        End Get
        Set(ByVal Value As Boolean)
            mAddNew = Value
        End Set
    End Property
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim rowCurr As DataGridViewRow = grdThuChi.CurrentRow
        Dim Hoc_ky As Integer
        Dim Nam_hoc As String
        If Not rowCurr Is Nothing Then
            Hoc_ky = rowCurr.Cells("Hoc_ky").Value
            Nam_hoc = rowCurr.Cells("Nam_hoc").Value
        Else
            Hoc_ky = mHoc_ky
            Nam_hoc = mNam_hoc
        End If
        Dim frmESS_ As New frmESS_BienLaiChiHocPhiHocPhan
        frmESS_.ShowDialog(-1, -1, txtMa_sv.Text, mclsBL, mID_he, Hoc_ky, Nam_hoc, mDot_thu, mLan_thu)
    End Sub
End Class