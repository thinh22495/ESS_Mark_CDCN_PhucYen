Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuHocPhiHocKySua
    Private mobjBL As New ESSBienLaiThu
    Private Loader As Boolean = False

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
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadThongTinTaiChinhSinhVien(ByVal ID_sv As Integer)
        Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
        Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
        Dim Ngoai_ngan_sach As Boolean = objSV.Ngoai_ngan_sach
        labHo_ten.Text = objSV.Ho_ten
        labTen_lop.Text = objSV.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
        txtMa_sv.Text = objSV.Ma_sv
        'Edit bien lai
        cmbHoc_ky.SelectedValue = mobjBL.Hoc_ky
        cmbNam_hoc.Text = mobjBL.Nam_hoc
        cmbDot_thu.SelectedIndex = mobjBL.Dot_thu - 1
        cmbLan_thu.SelectedIndex = mobjBL.Lan_thu - 1
        dtpNgay_thu.Value = mobjBL.Ngay_thu
        txtSo_phieu.Text = mobjBL.So_phieu
        cmbLoai_tien.Text = mobjBL.Ngoai_te
        txtNoi_dung.Text = mobjBL.Noi_dung
        txtSo_tien_da_nop.Text = mobjBL.So_tien
        'Load số phiếu
        txtSo_phieu.Text = mobjBL.So_phieu
        'Load thông tin những khoản phải nộp của sinh viên trong học kỳ
        Dim clsBL As New BienLaiThu_Bussines(mobjBL.ID_bien_lai)
        Dim dtKhoanThu As DataTable = clsBL.DanhSach_KhoanNop_HocKy(mobjBL.Hoc_ky, mobjBL.Nam_hoc, ID_sv)
        'Lọc nhưng khoản thu của biên lai khác và các khoản chưa thu
        For i As Integer = 0 To dtKhoanThu.Rows.Count - 1
            If IIf(IsDBNull(dtKhoanThu.Rows(i)("ID_bien_lai")), 0, dtKhoanThu.Rows(i)("ID_bien_lai")) <> mobjBL.ID_bien_lai And dtKhoanThu.Rows(i)("Nop_tien") <> False Then
                dtKhoanThu.Rows(i).Delete()
            End If
        Next
        dtKhoanThu.AcceptChanges()
        Me.grdMonThu.DataSource = dtKhoanThu.DefaultView
        'Hiển thị tổng hợp học phí
        Dim dtTongHop As DataTable = clsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he)
        Dim dv As DataView = dtTongHop.DefaultView
        dv.Sort = "Nam_hoc"
        Me.grdThuChi.DataSource = dv
        HienThiTongHocPhi(dtTongHop)
    End Sub
    Private Function CheckValidate() As Boolean
        If txtSo_tien_da_nop.Text.Trim = "" Then
            Thongbao("Bạn phải nhập số tiền!")
            txtSo_tien_da_nop.Focus()
            Return False
        ElseIf Not IsNumeric(txtSo_tien_da_nop.Text.Trim) Then
            Thongbao("Số tiền nộp bằng số!")
            txtSo_tien_da_nop.Focus()
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
#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetUpDataGridView(grdMonThu)
        LoadComboBox()
        LoadThongTinTaiChinhSinhVien(mobjBL.ID_sv)
    End Sub
    Private Sub frmESS_BienLaiThu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control"
    Private Sub grdMonThu_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdMonThu.CellEndEdit
        Try
            Dim dv As DataView = grdMonThu.DataSource
            Dim Tong_so_tien As Integer
            If Not dv Is Nothing Then
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Nop_tien") And dv.Item(i)("So_tien_da_nop").ToString <> "" Then
                        Tong_so_tien += dv.Item(i)("So_tien_da_nop")
                    End If
                Next
                txtSo_tien_da_nop.Text = Format(Tong_so_tien, "###,###")
                If txtSo_tien_da_nop.Text <> "" Then
                    lblSo_tien_chu_thuc_nop.Text = "(" + ChuyenChu(Tong_so_tien) + " đồng)"
                Else
                    lblSo_tien_chu_thuc_nop.Text = ""
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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
            rMain("So_phieu") = mobjBL.So_phieu
            If mobjBL.Thu_chi = 1 Then
                rMain("Loai_bienlai") = "CHI"
            Else
                rMain("Loai_bienlai") = "THU"
            End If
            rMain("Ngay_thu") = mobjBL.Ngay_thu
            rMain("Ho_ten") = mobjBL.Ho_ten
            rMain("Ma_sv") = mobjBL.Ma_sv
            rMain("Ten_lop") = labTen_lop.Text
            rMain("Noi_dung") = mobjBL.Noi_dung
            rMain("So_tien") = mobjBL.So_tien
            rMain("So_tien_chu") = ChuyenChu(CType("0" & mobjBL.So_tien, Long)) & " đồng."
            rMain("FullName") = mobjBL.Nguoi_thu
            rMain("So_tien_con") = 0 - CType(IIf(lblTong_thua_thieu.Text.Trim = "", 0, lblTong_thua_thieu.Text.Trim), Integer)
            dtMain.Rows.Add(rMain)
            ' Add dũ liệu vào dtSub
            Dim dt As DataTable
            dt = grdMonThu.DataSource.Table
            If dt.Rows.Count > 0 Then
                For Each r As DataRow In dt.Rows
                    rSub = dtSub.NewRow
                    rSub("Ten_thu_chi") = r("Ten_thu_chi")
                    rSub("Tinh_chat") = r("Tinh_chat")
                    rSub("So_tien") = r("So_tien")
                    rSub("So_tien_mien_giam") = r("So_tien_mien_giam")
                    rSub("So_tien_da_nop") = r("So_tien_da_nop")
                    dtSub.Rows.Add(rSub)
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
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            Dim clsBL As New BienLaiThu_Bussines
            'Update biên lai main
            mobjBL.Hoc_ky = cmbHoc_ky.SelectedValue
            mobjBL.Nam_hoc = cmbNam_hoc.Text
            mobjBL.Dot_thu = cmbDot_thu.SelectedIndex + 1
            mobjBL.Lan_thu = cmbLan_thu.SelectedIndex + 1
            mobjBL.Ngay_thu = dtpNgay_thu.Value
            mobjBL.Noi_dung = txtNoi_dung.Text
            mobjBL.So_tien = txtSo_tien_da_nop.Text
            mobjBL.Huy_phieu = False
            clsBL.CapNhat_ESSBienLaiThu(mobjBL, mobjBL.ID_bien_lai)
            'Update biên lai sub
            Dim dv As DataView = grdMonThu.DataSource
            'Remove tất cả các Học phần cũ
            For i As Integer = mobjBL.dsBienLaiChiTiet.Count - 1 To 0 Step -1
                'Delete Database
                clsBL.Xoa_ESSBienLaiThuChiTiet(mobjBL.dsBienLaiChiTiet.BienLaiChiTiet(i).ID_bien_lai_sub)
                'Remove Object
                mobjBL.dsBienLaiChiTiet.Remove(i)
            Next
            'Insert Học phần được chọn
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Nop_tien") Then
                    Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                    objBLChiTiet.ID_bien_lai = mobjBL.ID_bien_lai
                    objBLChiTiet.ID_thu_chi = dv.Item(i)("ID_thu_chi")
                    objBLChiTiet.So_tien = dv.Item(i)("So_tien_da_nop")
                    'Add database
                    Dim ID_bien_lai_sub As Integer = clsBL.ThemMoi_ESSBienLaiThuChiTiet(objBLChiTiet)
                    'Add object
                    objBLChiTiet.ID_bien_lai_sub = ID_bien_lai_sub
                    mobjBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                End If
            Next
            Thongbao("Đã cập nhật thành công !")
            LoadThongTinTaiChinhSinhVien(mobjBL.ID_sv)
        End If

    End Sub
    Private Sub grdMonThu_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdMonThu.DataSourceChanged
        Try
            Dim dv As DataView = grdMonThu.DataSource
            If dv.Count > 0 Then
                Dim So_tien_nop As Integer = 0
                For i As Integer = 0 To dv.Count - 1
                    So_tien_nop += CInt("0" & dv(i)("So_tien_nop"))
                Next
                labTong_so_tien_nop.Text = Format(So_tien_nop, "###,###0") + "đ"
                If So_tien_nop > 0 Then lblSo_tien_chu_phai_nop.Text = "(" + ChuyenChu(So_tien_nop.ToString) + " đồng)"
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub txtSo_tien_da_nop_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_tien_da_nop.TextChanged
        If txtSo_tien_da_nop.Text <> "" Then
            lblSo_tien_chu_thuc_nop.Text = "(" + ChuyenChu(txtSo_tien_da_nop.Text) + " đồng)"
        Else
            lblSo_tien_chu_thuc_nop.Text = ""
        End If
    End Sub
#End Region


    Private Sub chkAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dv As DataView = grdMonThu.DataSource
        For i As Integer = 0 To dv.Count - 1
            dv(i)("Nop_tien") = chkAll.Checked
        Next
        dv.Table.AcceptChanges()
    End Sub
End Class