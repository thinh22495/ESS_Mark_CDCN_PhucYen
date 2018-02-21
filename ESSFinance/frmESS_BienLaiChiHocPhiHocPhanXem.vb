Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiChiHocPhiHocPhanXem
    Private Loader As Boolean = False
    Private mobjBL As ESSBienLaiThu
    Private mclsBL As BienLaiThu_Bussines
    Private Ngoai_ngan_sach As Boolean = False
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
    Private Sub LoadThongTinTaiChinhSinhVien(ByVal ID_sv As String)
        EnableControl(False)
        Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
        Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien()
        labHo_ten.Text = objSV.Ho_ten
        labTen_lop.Text = objSV.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
        txtMa_sv.Text = objSV.Ma_sv
        Ngoai_ngan_sach = objSV.Ngoai_ngan_sach
        'Kiểm tra xem đã tồn tại Đợt thu, Lần thu này chưa
        LoadBienLai(mobjBL)
        mclsBL = New BienLaiThu_Bussines
        Dim dv As DataView = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he).DefaultView
        dv.Sort = "Nam_hoc"
        Dim dtTongHop As DataTable = dv.Table
        Me.grdThuChi.DataSource = dtTongHop.DefaultView
        HienThiTongHocPhi(dtTongHop)
    End Sub
    Private Sub LoadBienLai(ByVal objBL As ESSBienLaiThu)
        cmbHoc_ky.SelectedValue = objBL.Hoc_ky
        cmbNam_hoc.Text = objBL.Nam_hoc
        cmbDot_thu.SelectedIndex = objBL.Dot_thu - 1
        cmbLan_thu.SelectedIndex = objBL.Lan_thu - 1
        cmbID_thu_chi.SelectedValue = objBL.dsBienLaiChiTiet.BienLaiChiTiet(0).ID_thu_chi
        dtpNgay_thu.Value = objBL.Ngay_thu
        txtSo_phieu.Text = objBL.So_phieu
        cmbLoai_tien.Text = objBL.Ngoai_te
        labHo_ten.Text = objBL.Ho_ten
        If labTen_lop.Text = "" Then
            labTen_lop.Text = objBL.Ten_lop
        End If
        txtNoi_dung.Text = objBL.Noi_dung
        txtSo_tien.Text = Format(objBL.So_tien, "###,###")
        labTong_so_tien_nop.Text = Format(objBL.So_tien, "###,###")
    End Sub
    Private Sub HienThiTongHocPhi(ByVal dtTongHop As DataTable)
        Dim Tong_so_tien_nop, Tong_so_tien_da_nop, Tong_so_tien_thua_thieu, So_tien_phai_chi As Integer
        Tong_so_tien_nop = 0
        Tong_so_tien_da_nop = 0
        Tong_so_tien_thua_thieu = 0
        So_tien_phai_chi = 0
        For i As Integer = 0 To dtTongHop.Rows.Count - 1
            If dtTongHop.Rows(i)("Hoc_ky") = mobjBL.Hoc_ky And dtTongHop.Rows(i)("Nam_hoc") = mobjBL.Nam_hoc Then
                So_tien_phai_chi = 0 - dtTongHop.Rows(i)("Thieu_thua")
            End If
            If dtTongHop.Rows(i)("So_tien_nop").ToString <> "" Then Tong_so_tien_nop += dtTongHop.Rows(i)("So_tien_nop")
            If dtTongHop.Rows(i)("So_tien_da_nop").ToString <> "" Then Tong_so_tien_da_nop += dtTongHop.Rows(i)("So_tien_da_nop")
            If dtTongHop.Rows(i)("Thieu_thua").ToString <> "" Then Tong_so_tien_thua_thieu += dtTongHop.Rows(i)("Thieu_thua")
        Next
        lblTong_phai_nop.Text = Format(Tong_so_tien_nop, "###,###0") + "đ"
        lblTong_da_nop.Text = Format(Tong_so_tien_da_nop, "###,###0") + "đ"
        lblTong_thua_thieu.Text = Format(Tong_so_tien_thua_thieu, "###,###0")
    End Sub
    Private Sub EnableControl(ByVal Status As Boolean)
        cmbHoc_ky.Enabled = Status
        cmbNam_hoc.Enabled = Status
        cmbDot_thu.Enabled = Status
        cmbLan_thu.Enabled = Status
        cmbID_thu_chi.Enabled = Status
        dtpNgay_thu.Enabled = Status
        cmbLoai_tien.Enabled = Status
        txtMa_sv.Enabled = Status
        txtNoi_dung.Enabled = Status
        txtSo_tien.Enabled = Status
    End Sub
#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        LoadComboBox()
        LoadThongTinTaiChinhSinhVien(mobjBL.ID_sv)
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

End Class