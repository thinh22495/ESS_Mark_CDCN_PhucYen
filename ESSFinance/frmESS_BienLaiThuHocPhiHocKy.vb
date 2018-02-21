Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuHocPhiHocKy
    Private mID_he As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mDot_thu As Integer = 0
    Private mLan_thu As Integer = 0
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Private mID_bien_lai As Integer = -1
    Private Ngoai_ngan_sach As Boolean = False
    Private Lop_chat_luong_cao As Boolean = False
    Dim mclsBL As New BienLaiThu_Bussines

#Region "Functions And Subs"
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
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadSinhVien(ByVal ID_sv As Integer)
        Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
        Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
        If Not IsNothing(objSV) Then
            labHo_ten.Text = objSV.Ho_ten
            labTen_lop.Text = objSV.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
            txtMa_sv.Text = objSV.Ma_sv
            mID_he = objSV.ID_he
            Ngoai_ngan_sach = objSV.Ngoai_ngan_sach
            'Kiêm tra đã tồn tại biên lai thu trong đợt này chưa
            mID_bien_lai = mclsBL.getID_bien_lai(ID_sv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, 2, 1)
            If mID_bien_lai > 0 Then
                EnableControl(False)
                'Edit bien lai
                Dim clsBL As BienLaiThu_Bussines = New BienLaiThu_Bussines(mID_bien_lai)
                Dim objBL As ESSBienLaiThu = clsBL.BienLaiThu_ID_bien_lai(mID_bien_lai)
                dtpNgay_thu.Value = objBL.Ngay_thu
                txtSo_phieu.Text = objBL.So_phieu
                cmbLoai_tien.Text = objBL.Ngoai_te
                txtNoi_dung.Text = objBL.Noi_dung
                txtSo_tien_da_nop.Text = objBL.So_tien
                txtSo_phieu.Text = objBL.So_phieu
                'Load thông tin những khoản phải nộp trong học kỳ
                Dim dtKhoanThu As DataTable = clsBL.DanhSach_KhoanNop_HocKy(objBL.Hoc_ky, objBL.Nam_hoc, ID_sv)
                'Lọc nhưng khoản đã nộp có trong biên lai
                For i As Integer = 0 To dtKhoanThu.Rows.Count - 1
                    If IIf(IsDBNull(dtKhoanThu.Rows(i)("ID_bien_lai")), 0, dtKhoanThu.Rows(i)("ID_bien_lai")) <> objBL.ID_bien_lai And dtKhoanThu.Rows(i)("Nop_tien") <> True Then
                        dtKhoanThu.Rows(i).Delete()
                    End If
                Next
                dtKhoanThu.AcceptChanges()
                If dtKhoanThu.Rows.Count = 0 Then Thongbao("Sinh viên chưa được quy định mức học phí hoặc không thu theo niên khóa!", MsgBoxStyle.OkOnly)
                Me.grdMonThu.DataSource = dtKhoanThu.DefaultView

            Else
                EnableControl(True)
                'Load số phiếu
                txtSo_phieu.Text = mclsBL.getSo_phieu()
                'Edit bien lai
                dtpNgay_thu.Value = Today
                txtNoi_dung.Text = "Nộp tiền học phí học kỳ " + cmbHoc_ky.Text + " năm học " + cmbNam_hoc.Text
                txtSo_tien_da_nop.Text = ""
                'Load thông tin những khoản phải nộp trong học kỳ
                Dim dtKhoanThu As DataTable = mclsBL.DanhSach_KhoanNop_HocKy(cmbHoc_ky.Text, cmbNam_hoc.Text, ID_sv)
                'Lọc nhưng khoản chưa nộp
                For i As Integer = 0 To dtKhoanThu.Rows.Count - 1
                    If dtKhoanThu.Rows(i)("Nop_tien") = True Then
                        dtKhoanThu.Rows(i).Delete()
                    Else
                        dtKhoanThu.Rows(i)("So_tien_da_nop") = dtKhoanThu.Rows(i)("So_tien_nop")
                    End If
                Next
                dtKhoanThu.AcceptChanges()
                If dtKhoanThu.Rows.Count = 0 Then Thongbao("Sinh viên chưa được quy định mức học phí hoặc không thu theo niên khóa!", MsgBoxStyle.OkOnly)
                Me.grdMonThu.DataSource = dtKhoanThu.DefaultView
            End If
            'Thổng hợp học phí
            Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he)
            Dim dv As DataView = dtTongHop.DefaultView
            dv.Sort = "Nam_hoc"
            Me.grdThuChi.DataSource = dv
            HienThiTongHocPhi(dtTongHop)
        Else
            Thongbao("Bạn không được cấp quyền thu học phí sinh viên này!")
        End If
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
        If cmbLan_thu.SelectedIndex = -1 Then
            Thongbao("Bạn phải chọn lần thu")
            cmbLan_thu.Focus()
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
            Thongbao("Bạn phải chọn khoản nộp để thu tiền")
            grdMonThu.Focus()
            Return False
        End If
        Return True
    End Function
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
    Private Sub EnableControl(ByVal status As Boolean)
        cmdSave.Enabled = status
        'cmbHoc_ky.Enabled = status
        'cmbNam_hoc.Enabled = status
        'cmbLan_thu.Enabled = status
        cmbLoai_tien.Enabled = status
        dtpNgay_thu.Enabled = status
        txtNoi_dung.Enabled = status
    End Sub
#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetUpDataGridView(grdMonThu)
        SetQuyenTruyCap(cmdSave, , , )
        LoadComboBox()
        cmbHoc_ky.SelectedValue = mHoc_ky
        cmbNam_hoc.Text = mNam_hoc
        cmbDot_thu.SelectedIndex = mDot_thu - 1
        cmbLan_thu.SelectedIndex = mLan_thu - 1
        cmbLoai_tien.SelectedIndex = 0
        txtMa_sv.Focus()
        Loader = True
    End Sub
    Private Sub frmESS_BienLaiThu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control"
    Private Sub grdMonThu_CellClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMonThu.Click, grdMonThu.CurrentCellChanged, grdMonThu.DataSourceChanged
        Try
            Dim dv As DataView = grdMonThu.DataSource
            Dim Tong_so_tien_nop As Integer
            Dim Tong_so_tien_phai_nop As Integer
            If Not dv Is Nothing Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Nop_tien") And dv.Item(i)("So_tien_da_nop").ToString <> "" Then
                        Tong_so_tien_nop += dv.Item(i)("So_tien_da_nop")
                        Tong_so_tien_phai_nop += dv.Item(i)("So_tien")
                    End If
                Next
                txtSo_tien_da_nop.Text = Format(Tong_so_tien_nop, "###,###")
                labTong_so_tien_nop.Text = Format(Tong_so_tien_phai_nop, "###,###")
                If txtSo_tien_da_nop.Text <> "" Then
                    lblSo_tien_chu_thuc_nop.Text = "(" + ChuyenChu(Tong_so_tien_nop) + " đồng)"
                Else
                    lblSo_tien_chu_thuc_nop.Text = ""
                End If
                If labTong_so_tien_nop.Text <> "" Then
                    lblSo_tien_chu_phai_nop.Text = "(" + ChuyenChu(Tong_so_tien_phai_nop) + " đồng)"
                Else
                    lblSo_tien_chu_phai_nop.Text = ""
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        Dim ID_sv As Integer = 0
        If txtMa_sv.Text.Trim <> "" Then
            mclsBL = New BienLaiThu_Bussines
            ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
            If ID_sv > 0 Then
                mID_sv = ID_sv
                LoadSinhVien(ID_sv)
            Else
                mID_sv = 0
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        Else
            Me.btnLoc_sv.Focus()
        End If
    End Sub
    Private Sub cmb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        Dim ID_sv As Integer = 0
        If txtMa_sv.Text.Trim <> "" Then
            mclsBL = New BienLaiThu_Bussines
            ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
            If ID_sv > 0 Then
                mID_sv = ID_sv
                LoadSinhVien(ID_sv)
            Else
                mID_sv = 0
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        Else
            Me.btnLoc_sv.Focus()
        End If
    End Sub
    Private Sub btnLoc_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoc_sv.Click
        Dim frmESS_ As New frmESS_SearchSinhVien
        frmESS_.ShowDialog()
        If frmESS_.Tag = 1 Then
            mID_sv = frmESS_.mID_sv
            If mID_sv > 0 Then
                LoadSinhVien(mID_sv)
            Else
                mID_sv = 0
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            Dim ID_bien_lai, ID_bien_lai_sub As Integer
            Dim objBL As New ESSBienLaiThu
            txtSo_phieu.Text = mclsBL.getSo_phieu()
            objBL.So_phieu = txtSo_phieu.Text
            objBL.ID_sv = mID_sv
            objBL.Ma_sv = txtMa_sv.Text
            objBL.Ho_ten = labHo_ten.Text
            objBL.Ten_lop = labTen_lop.Text
            objBL.Hoc_ky = cmbHoc_ky.SelectedValue
            objBL.Nam_hoc = cmbNam_hoc.Text
            objBL.Dot_thu = 1 'fix
            objBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
            objBL.Ngay_thu = dtpNgay_thu.Value
            objBL.Noi_dung = txtNoi_dung.Text
            objBL.So_tien = labTong_so_tien_nop.Text
            objBL.Nguoi_thu = gobjUser.FullName
            objBL.Ngoai_te = cmbLoai_tien.Text
            objBL.Thu_chi = 1
            ID_bien_lai = mclsBL.ThemMoi_ESSBienLaiThu(objBL)
            mID_bien_lai = ID_bien_lai
            'Insert Học phần được chọn
            Dim dv As DataView = grdMonThu.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Nop_tien") Then
                    Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                    objBLChiTiet.ID_bien_lai = ID_bien_lai
                    objBLChiTiet.ID_thu_chi = dv.Item(i)("ID_thu_chi")
                    objBLChiTiet.ID_mon_tc = 0
                    objBLChiTiet.So_tien = dv.Item(i)("So_tien_da_nop")
                    'Add database
                    ID_bien_lai_sub = mclsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
                    'Add object
                    objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
                    objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                End If
            Next
            ' Tổng hợp lại
            mclsBL = New BienLaiThu_Bussines(mID_bien_lai)
            Me.grdThuChi.DataSource = mclsBL.TongHop_HocPhi(mID_sv, Ngoai_ngan_sach, mID_he).DefaultView
            Thongbao("Đã cập nhật thành công !")
            LoadSinhVien(mID_sv)
            'In phiếu
            If chkPrint.Checked Then
                cmdPrint_Click(sender, e)
            End If
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
            dtMain.Columns.Add("FullName")
            dtMain.Columns.Add("So_tien_con")
            'Lấy thông tin biên lai
            Dim clsBL As New BienLaiThu_Bussines(mID_bien_lai)
            Dim objBL As ESSBienLaiThu = clsBL.BienLaiThu_ID_bien_lai(mID_bien_lai)
            Dim so_phieu As String = ""
            If objBL.Printed Then
                so_phieu = objBL.So_phieu.ToString
            Else
                so_phieu = objBL.So_phieu.ToString
                objBL.Printed = True
                clsBL.CapNhat_ESSBienLaiThu(objBL, objBL.ID_bien_lai)
            End If
            '
            Dim rMain As DataRow
            Dim dtSub As New DataTable
            dtSub.Columns.Add("Ten_thu_chi")
            dtSub.Columns.Add("Tinh_chat")
            dtSub.Columns.Add("So_tien", GetType(Double))
            dtSub.Columns.Add("So_tien_mien_giam", GetType(Double))
            dtSub.Columns.Add("So_tien_da_nop", GetType(Double))
            Dim rSub As DataRow
            ' Add dũ liệu vào dtMain
            rMain = dtMain.NewRow
            rMain("So_phieu") = so_phieu
            rMain("Loai_bienlai") = "THU"
            rMain("Ngay_thu") = dtpNgay_thu.Value
            rMain("Ho_ten") = labHo_ten.Text
            rMain("Ma_sv") = txtMa_sv.Text
            rMain("Ten_lop") = labTen_lop.Text
            rMain("Noi_dung") = txtNoi_dung.Text.Trim
            rMain("So_tien") = CDbl(txtSo_tien_da_nop.Text.Trim)
            rMain("So_tien_chu") = ChuyenChu(CType("0" & labTong_so_tien_nop.Text.Trim, Long)) & " đồng."
            rMain("FullName") = objBL.Nguoi_thu
            rMain("So_tien_con") = 0 - CType(IIf(lblTong_thua_thieu.Text.Trim = "", 0, lblTong_thua_thieu.Text.Trim), Integer)
            dtMain.Rows.Add(rMain)
            ' Add dũ liệu vào dtSub
            Dim dt As DataTable
            dt = grdMonThu.DataSource.Table
            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    If r("Nop_tien") Then
                        rSub = dtSub.NewRow
                        rSub("Ten_thu_chi") = r("Ten_thu_chi")
                        rSub("Tinh_chat") = r("Tinh_chat")
                        rSub("So_tien") = r("So_tien")
                        rSub("So_tien_mien_giam") = r("So_tien_mien_giam")
                        rSub("So_tien_da_nop") = r("So_tien_da_nop")
                        dtSub.Rows.Add(rSub)
                    End If
                Next
            End If
            If dtMain.Rows.Count = 0 Or dtSub.Rows.Count = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim frmESS_ As New frmESS_ReportView
            If chkPrint.Checked Then
                frmESS_.PrintBienLai("BIENLAIHOCKY_MAIN", dtMain, "BIENLAIHOCKY_SUB", dtSub, "Subreport1", "Subreport2")
            Else
                frmESS_.ShowDialogBienLai("BIENLAIHOCKY_MAIN", dtMain, "BIENLAIHOCKY_SUB", dtSub, "Subreport1", "Subreport2")
            End If
            Me.Cursor = Cursors.Default
            '
            txtMa_sv.Text = ""
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub grdMonThu_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMonThu.CellEndEdit
        Try
            If e.ColumnIndex = Me.grdMonThu.Columns("So_tien_da_nop").Index Then
                If Not IsDBNull(Me.grdMonThu.Rows(grdMonThu.CurrentRow.Index).Cells("So_tien_da_nop").Value) And Not IsNumeric(Me.grdMonThu.Rows(grdMonThu.CurrentRow.Index).Cells("So_tien_da_nop").Value) Then
                    Thongbao("Bạn phải nhập giá trị là chữ số !", MsgBoxStyle.Information)
                    Me.grdMonThu.Rows(grdMonThu.CurrentRow.Index).Cells("So_tien_da_nop").Value = 0
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dv As DataView = grdMonThu.DataSource
        For i As Integer = 0 To dv.Count - 1
            dv(i)("Nop_tien") = chkAll.Checked
        Next
        dv.Table.AcceptChanges()
    End Sub
#End Region


End Class