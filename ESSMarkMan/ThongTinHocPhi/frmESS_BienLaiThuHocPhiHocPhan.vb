Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuHocPhiHocPhan
    Private mID_he As Integer = 0
    Private mThu_chi As Integer = 1
    Private mGian_thu As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mDot_thu As Integer = 0
    Private mLan_thu As Integer = 0
    Private mID_thu_chi As Integer = 2
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Private mclsBL As BienLaiThu_Bussines
    Private mID_bien_lai As Integer = 0 ' Để biết khi sửa biên lai
    Private Ngoai_ngan_sach As Boolean = False
    Private Lop_chat_luong_cao As Boolean = False
    'Private clsKyDangKy As New HocKyDangKy_BLL
#Region "Function"
    Public Overloads Sub ShowDialog(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mDot_thu = Dot_thu
        mLan_thu = Lan_thu
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
            mKhoa_hoc = objSV.Khoa_hoc
            Dim Kinh_te As Boolean = Not objSV.Ky_thuat
            Dim Kinh_te2 As Boolean = Not objSV.Ky_thuat_Nganh2
            labTen_lop.Text = objDanhSach.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
            txtMa_sv.Text = objDanhSach.Ma_sv
            'Kiểm tra xem đã tồn tại Đợt thu, Lần thu này chưa
            mclsBL = New BienLaiThu_Bussines
            ID_bien_lai = mclsBL.getID_bien_lai(ID_sv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, mID_thu_chi, 1)
            mID_bien_lai = ID_bien_lai
            If ID_bien_lai > 0 Then
                EnableControl(False)
                'Hiển thị các học phần đã nộp
                Dim dtMucHocPhi As DataTable = mclsBL.Load_MucHocPhiTinChi_List(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he, mKhoa_hoc, Kinh_te)
                Dim dtMucHocPhi_Nganh2 As DataTable = mclsBL.Load_MucHocPhiTinChi_List(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he, mKhoa_hoc, Kinh_te2)
                Ngoai_ngan_sach = objDanhSach.Ngoai_ngan_sach
                Lop_chat_luong_cao = objDanhSach.Lop_chat_luong_cao
                Dim dtMonThu As DataTable
                If Kinh_te2 = Kinh_te Then
                    dtMonThu = mclsBL.LoadBienLaiChiTiet(dtMucHocPhi, dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, ID_sv, ID_bien_lai, Lop_chat_luong_cao)
                Else
                    dtMonThu = mclsBL.LoadBienLaiChiTiet(dtMucHocPhi_Nganh2, dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, ID_sv, ID_bien_lai, Lop_chat_luong_cao)
                End If
                Me.grdMonThu.DataSource = dtMonThu.DefaultView
                Dim so_tien_phai_nop As Integer = 0
                Dim so_tien_phai_nop_tru_mien_giam As Integer = 0
                For i As Integer = 0 To dtMonThu.Rows.Count - 1
                    so_tien_phai_nop += CInt(dtMonThu.Rows(i)("so_tien"))
                    so_tien_phai_nop_tru_mien_giam += (CInt(dtMonThu.Rows(i)("so_tien")) - CInt("0" & dtMonThu.Rows(i)("So_tien_mien_giam")))
                Next
                labTong_so_tien_nop.Text = Format(so_tien_phai_nop, "###,###")
                labTong_so_tien_nop_tru_mien_giam.Text = Format(so_tien_phai_nop_tru_mien_giam, "###,###")
                Dim dv As DataView = mclsBL.TongHopHocPhiSinhVien(ID_sv).DefaultView
                dv.Sort = "Nam_hoc"
                Dim dtTongHop As DataTable = dv.Table
                grdThuChi.DataSource = dv
                HienThiTongHocPhi(dtTongHop)
                'Load phiếu
                Dim objBL As ESSBienLaiThu
                mclsBL = New BienLaiThu_Bussines(ID_bien_lai, False)
                objBL = mclsBL.ESSBienLaiThu(0)
                LoadThongTinBienLai(objBL)
            Else
                dtpNgay_thu.Value = Today
                txtSo_phieu.Text = mclsBL.ChuanHoa_SoPhieu(mclsBL.getSo_phieu(mThu_chi, mGian_thu, mID_he))
                txtNoi_dung.Text = "Nộp " + cmbID_thu_chi.Text + " đợt " + cmbLan_thu.Text + " học kỳ " + cmbHoc_ky.Text + " năm học " + cmbNam_hoc.Text
                txtGhi_chu.Text = ""
                Dim dtMucHocPhi_Nganh2 As DataTable = mclsBL.Load_MucHocPhiTinChi_List(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he, mKhoa_hoc, Kinh_te2)
                Dim dtMucHocPhi As DataTable = mclsBL.Load_MucHocPhiTinChi_List(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he, mKhoa_hoc, Kinh_te)
                Ngoai_ngan_sach = objDanhSach.Ngoai_ngan_sach
                Lop_chat_luong_cao = objDanhSach.Lop_chat_luong_cao
                Dim dtMonThu As DataTable
                If Kinh_te2 = Kinh_te Then
                    dtMonThu = mclsBL.DanhSachHocPhanBienLaiThu_(dtMucHocPhi, dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, 0, ID_sv, -1, CInt(cmbLan_thu.Text), Lop_chat_luong_cao)
                Else
                    dtMonThu = mclsBL.DanhSachHocPhanBienLaiThu_(dtMucHocPhi_Nganh2, dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, 0, ID_sv, -1, CInt(cmbLan_thu.Text), Lop_chat_luong_cao)
                End If
                Me.grdMonThu.DataSource = dtMonThu.DefaultView
                Dim so_tien_phai_nop As Integer = 0
                Dim so_tien_phai_nop_tru_mien_giam As Integer = 0
                For i As Integer = 0 To dtMonThu.Rows.Count - 1
                    so_tien_phai_nop += CInt(dtMonThu.Rows(i)("so_tien"))
                    so_tien_phai_nop_tru_mien_giam += (CInt(dtMonThu.Rows(i)("so_tien")) - CInt("0" & dtMonThu.Rows(i)("So_tien_mien_giam")))
                Next
                labTong_so_tien_nop.Text = Format(so_tien_phai_nop, "###,###")
                labTong_so_tien_nop_tru_mien_giam.Text = Format(so_tien_phai_nop_tru_mien_giam, "###,###")
                Dim dv As DataView = mclsBL.TongHopHocPhiSinhVien(ID_sv).DefaultView
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
        txtSo_phieu.Text = mclsBL.ChuanHoa_SoPhieu(objBL.So_phieu)
        cmbLoai_tien.Text = objBL.Ngoai_te
        txtMa_sv.Text = objBL.Ma_sv
        labHo_ten.Text = objBL.Ho_ten
        If labTen_lop.Text = "" Then
            labTen_lop.Text = objBL.Ten_lop
        End If
        txtNoi_dung.Text = objBL.Noi_dung
        txtSo_tien.Text = objBL.So_tien
        txtGhi_chu.Text = objBL.Ghi_chu
    End Sub
    Private Sub HienThiTongHocPhi(ByVal dtTongHop As DataTable)
        Dim Tong_so_tien_nop, Tong_so_tien_da_nop, Tong_so_tien_thua_thieu, Tong_So_du_chuyen_khoan As Integer
        Tong_so_tien_nop = 0
        Tong_so_tien_da_nop = 0
        Tong_so_tien_thua_thieu = 0
        For i As Integer = 0 To dtTongHop.Rows.Count - 1
            If dtTongHop.Rows(i)("So_tien_nop").ToString <> "" Then Tong_so_tien_nop += dtTongHop.Rows(i)("So_tien_nop")
            If dtTongHop.Rows(i)("So_tien_da_nop").ToString <> "" Then Tong_so_tien_da_nop += dtTongHop.Rows(i)("So_tien_da_nop")
            If dtTongHop.Rows(i)("Thieu_thua").ToString <> "" Then Tong_so_tien_thua_thieu += dtTongHop.Rows(i)("Thieu_thua")
            Dim clsck As New ChuyenKhoan_BLL
            Tong_So_du_chuyen_khoan = clsck.ChuyenKhoan_Get_SoDu(mID_sv)
        Next
        lblTong_phai_nop.Text = Format(Tong_so_tien_nop, "###,###0")
        lblTong_da_nop.Text = Format(Tong_so_tien_da_nop, "###,###0")
        lblTong_thua_thieu.Text = Format(Tong_so_tien_thua_thieu, "###,###0")
        lblSo_du_ck.Text = Format(Tong_So_du_chuyen_khoan, "###,###0")
        'DHNT
        labTong_so_tien_nop.Text = Format(Math.Abs(Tong_so_tien_thua_thieu), "###,###0")
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
        If labTong_so_tien_nop.Text = "" Then
            Thongbao("Bạn phải chọn học phần để thu tiền")
            grdMonThu.Focus()
            Return False
        End If
        If Not IsNothing(grdMonThu.DataSource) AndAlso CType(grdMonThu.DataSource, DataView).Count = 0 Then
            Thongbao("Sinh viên chưa đăng ký học phần nào")
            grdMonThu.Focus()
            Return False
        End If
        Return True
    End Function
    Private Sub EnableControl(ByVal Status As Boolean)
        dtpNgay_thu.Enabled = Status
        cmbLoai_tien.Enabled = Status
        txtNoi_dung.Enabled = Status
        txtGhi_chu.Enabled = Status
        txtSo_tien.Enabled = Status
        'grdMonThu.Enabled = Status
        chkSelectAll.Enabled = Status
        cmbGian_thu.Enabled = Status
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
        txtGhi_chu.Text = ""
        cmbGian_thu.SelectedIndex = 0
    End Sub
#End Region

#Region "Forms"
    Private Sub frmBienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetUpDataGridView(grdMonThu)
        LoadComboBox()
        cmbHoc_ky.SelectedValue = mHoc_ky
        cmbNam_hoc.Text = mNam_hoc
        cmbDot_thu.SelectedIndex = 0
        cmbLan_thu.SelectedIndex = 0
        cmbID_thu_chi.SelectedValue = mID_thu_chi
        cmbLoai_tien.SelectedIndex = 0
        cmbGian_thu.SelectedIndex = 0
        txtMa_sv.Focus()
        Loader = True
    End Sub
    Private Sub frmBienLaiThu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmBienLaiThu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
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

    Private Sub txtMa_sv_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtMa_sv.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Enter) Then
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
    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
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
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbGian_thu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbGian_thu.SelectedIndexChanged
        If Loader Then
            mGian_thu = cmbGian_thu.SelectedIndex
        End If
    End Sub
#End Region
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim SQL As String = "SELECT DISTINCT Ho_ten + ' ('+Ma_sv+')' AS Ho_ten,Ten_lop,Hoc_ky,Nam_hoc,Sum(So_tien) AS Hoc_phi FROM STU_HOSOSINHVIEN a " & _
                                "INNER JOIN ACC_BIENLAITHU b ON a.ID_SV=b.ID_SV INNER JOIN STU_DANHSACH c ON a.ID_SV=c.ID_SV " & _
                                "INNER JOIN STU_LOP d ON c.ID_lop=d.ID_lop WHERE a.Ma_SV='" & txtMa_sv.Text.Trim & "' GROUP BY Nam_hoc,Hoc_ky,Ho_ten,Ten_lop,Ma_sv ORDER BY Nam_hoc,Hoc_ky"
            Dim dtMain As DataTable = clsDM.LoadDanhMuc(SQL)

            mclsBL = New BienLaiThu_Bussines
            Dim dt_sub As DataTable = mclsBL.HocPhan_DangKy_SinhVien(mID_sv)

            Me.Cursor = Cursors.WaitCursor

            Dim frm As New rpt_HocPhanChiTiet(dtMain, dt_sub, lblTong_thua_thieu.Text)
            PrintXtraReport(frm)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
End Class