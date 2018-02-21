Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuHocPhiHocPhanXem
    Private Loader As Boolean = False
    Private mobjBL As ESSBienLaiThu
    Private Ngoai_ngan_sach As Boolean = False
    Private clsKyDangKy As New HocKyDangKy_Bussines
#Region "Functions And Subs"
    Public Overloads Sub ShowDialog(ByVal objBL As ESSBienLaiThu)
        mobjBL = objBL
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
        Dim mclsBL As New BienLaiThu_Bussines
        Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
        Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
        Dim ID_bien_lai As Integer = mobjBL.ID_bien_lai
        labHo_ten.Text = objSV.Ho_ten
        Dim mID_he As Integer = objSV.ID_he
        labTen_lop.Text = objSV.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
        txtMa_sv.Text = objSV.Ma_sv
        'Load thông tin biên lai
        Dim dtMucHocPhi As DataTable = mclsBL.HienThi_ESSMucHocPhiTinChi_DanhSach(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, mID_he)
        Ngoai_ngan_sach = objSV.Ngoai_ngan_sach
        'Nếu là đang thêm mới thì chỉ hiện các học phần trong biên lai
        Dim dtMonThu As DataTable = mclsBL.LoadBienLaiChiTiet(dtMucHocPhi, Ngoai_ngan_sach, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, ID_sv, ID_bien_lai)
        'Load phiếu
        LoadThongTinBienLai(mobjBL)
        Me.grdMonThu.DataSource = dtMonThu.DefaultView
        Dim so_tien_phai_nop As Integer = 0
        Dim so_tien_phai_nop_tru_mien_giam As Integer = 0
        For i As Integer = 0 To dtMonThu.Rows.Count - 1
            so_tien_phai_nop += CInt(dtMonThu.Rows(i)("so_tien"))
            so_tien_phai_nop_tru_mien_giam += (CInt(dtMonThu.Rows(i)("so_tien")) - CInt("0" & dtMonThu.Rows(i)("So_tien_mien_giam")))
        Next
        labTong_so_tien_nop.Text = Format(so_tien_phai_nop, "###,###")
        labTong_so_tien_nop_tru_mien_giam.Text = Format(so_tien_phai_nop_tru_mien_giam, "###,###")
        Dim dv As DataView = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he).DefaultView
        dv.Sort = "Nam_hoc"
        Dim dtTongHop As DataTable = dv.Table
        grdThuChi.DataSource = dv
        HienThiTongHocPhi(dtTongHop)
    End Sub
    Private Sub LoadThongTinBienLai(ByVal objBL As ESSBienLaiThu)
        Dim idx As Integer
        cmbHoc_ky.SelectedValue = objBL.Hoc_ky
        cmbNam_hoc.Text = objBL.Nam_hoc
        cmbDot_thu.SelectedIndex = objBL.Dot_thu - 1
        cmbLan_thu.SelectedIndex = objBL.Lan_thu - 1
        cmbID_thu_chi.SelectedValue = objBL.dsBienLaiChiTiet.BienLaiChiTiet(idx).ID_thu_chi
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
    Private Sub EnableControl(ByVal Status As Boolean)
        dtpNgay_thu.Enabled = Status
        cmbLoai_tien.Enabled = Status
        txtNoi_dung.Enabled = Status
        txtSo_tien.Enabled = Status
        grdMonThu.Enabled = Status
        chkSelectAll.Enabled = Status
        txtMa_sv.Enabled = Status
        cmbHoc_ky.Enabled = Status
        cmbNam_hoc.Enabled = Status
        cmbDot_thu.Enabled = Status
        cmbLan_thu.Enabled = Status
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
        LoadComboBox()
        cmbHoc_ky.SelectedValue = mobjBL.Hoc_ky
        cmbNam_hoc.Text = mobjBL.Nam_hoc
        cmbDot_thu.SelectedIndex = mobjBL.Dot_thu - 1
        cmbLan_thu.SelectedIndex = mobjBL.Lan_thu - 1
        LoadThongTinTaiChinhSinhVien(mobjBL.ID_sv)
        EnableControl(False)
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

End Class