Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_BienLaiThuList
    Private Loader As Boolean = False
    Private clsBL As BienLaiThu_Bussines
    Private clsMonTC As New MonTinChi_Bussines
#Region "Functions And Subs"
    Private Sub LoadHocPhanTinChi()
        Dim KyDangKy As Integer = clsMonTC.getKyDangKy(cmbDot_thu.SelectedIndex + 1, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        clsMonTC = New MonTinChi_Bussines(KyDangKy)
        Dim dt As DataTable
        dt = clsMonTC.DanhSachHocPhan
        dt.DefaultView.Sort = "Ten_mon"
        FillCombo(cmbID_mon, dt, "ID_mon", "Ten_mon")
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
    Private Sub HienThi_ESSBienLai()
        If Loader Then
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Dim dsID_lop As String = trvLop.ID_lop_list
            Dim ID_thu_chi As Integer = cmbID_thu_chi.SelectedValue
            Dim Thu_chi As Integer = 0
            If optPhieu_thu.Checked Then Thu_chi = 1
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim Ky_hieu_lop_tc As String = cmbKy_hieu_lop.Text
            clsBL = New BienLaiThu_Bussines(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            Me.grdViewBienLai.DataSource = clsBL.DanhSachBienLaiThuHocPhan(ID_thu_chi, ID_mon, Ky_hieu_lop_tc, chkPhieu_huy.Checked).DefaultView
            'Fillter dữ liệu theo các điều kiện chọn
            Fillter_BienLai()
        End If
    End Sub
    Private Sub Fillter_BienLai()
        If Loader Then
            Dim dv As DataView = grdViewBienLai.DataSource
            Dim strFillter As String = "1=1"
            If cmbDot_thu.SelectedIndex >= 0 Then strFillter += " AND Dot_thu=" + (cmbDot_thu.SelectedIndex + 1).ToString
            If cmbLan_thu.SelectedIndex >= 0 Then strFillter += " AND Lan_thu=" + (cmbLan_thu.SelectedIndex + 1).ToString
            If txtNguoi_thu.Text <> "" Then strFillter += " AND Nguoi_thu='" + txtNguoi_thu.Text + "'"
            If dtpTu_ngay.Checked Then strFillter += " AND Ngay_thu_search>='" + ConvertDateSearch(dtpTu_ngay.Value) + "'"
            If dtpDen_ngay.Checked Then strFillter += " AND Ngay_thu_search<='" + ConvertDateSearch(dtpDen_ngay.Value) + "'"
            If chkPhieu_huy.Checked Then
                strFillter += " AND Huy_phieu=1"
            Else
                strFillter += " AND Huy_phieu=0"
            End If
            If txtTu_so.Text <> "" Then strFillter += " AND So_phieu>=" + txtTu_so.Text
            If txtDen_so.Text <> "" Then strFillter += " AND So_phieu<=" + txtDen_so.Text
            If cmbHoc_ky.SelectedValue > 0 Then strFillter += " AND Hoc_ky=" + cmbHoc_ky.SelectedValue.ToString
            If cmbNam_hoc.Text <> "" Then strFillter += " AND Nam_hoc='" + cmbNam_hoc.Text.ToString + "'"
            If cmbID_thu_chi.SelectedValue > 0 Then strFillter += " AND ID_thu_chi=" + cmbID_thu_chi.SelectedValue.ToString
            Dim Thu_chi As Integer = 0
            If optPhieu_thu.Checked Then Thu_chi = 1
            strFillter += " AND Thu_chi=" + Thu_chi.ToString
            If txtMa_sv.Text <> "" Then strFillter += " AND Ma_sv='" + txtMa_sv.Text + "'"
            If txtHo_ten.Text <> "" Then strFillter += " AND Ho_ten='" + txtHo_ten.Text + "'"
            dv.RowFilter = strFillter
            lblSo_phieu.Text = dv.Count
            'Tính tổng số tiền
            Dim So_tien_VND, So_tien_USD As Double
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Ngoai_te") = "VND" Then
                    So_tien_VND += dv.Item(i)("So_tien")
                Else
                    So_tien_USD += dv.Item(i)("So_tien")
                End If
            Next
            lblVND.Text = Format(So_tien_VND, "###,###")
        End If
    End Sub
    Private Function ConvertDateSearch(ByVal d As Date) As String
        Return Year(d).ToString & IIf(Month(d).ToString.Length = 1, "0" & Month(d).ToString, Month(d).ToString) & IIf(DateAndTime.Day(d).ToString.Length = 1, "0" & DateAndTime.Day(d).ToString, DateAndTime.Day(d).ToString)
    End Function
#End Region
#Region "Form Events"
    Private Sub frmESS_BienLaiThuList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
        LoadComboBox()
        'Set default value
        txtNguoi_thu.Text = gobjUser.UserName
        cmbDot_thu.SelectedIndex = 0
        cmbLan_thu.SelectedIndex = 0
        cmbID_thu_chi.SelectedIndex = 0
        cmbID_thu_chi.Enabled = False
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewBienLai)
        SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdCancel)
        Loader = True
        LoadHocPhanTinChi()
    End Sub
    Private Sub frmESS_BienLaiThuList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_BienLaiThuList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Control Events"
    Private Sub LoadHocPhanTinChi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                LoadHocPhanTinChi()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbID_mon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged
        Try
            Dim dt As DataTable
            dt = clsMonTC.DanhSachKyHieuLop(cmbID_mon.SelectedValue)
            FillCombo(cmbKy_hieu_lop, dt, "Ky_hieu_lop_tc", "Ky_hieu_lop_tc")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdList.Click
        Try
            Dim cls As New BienLaiThu_Bussines
            Dim dv As DataView
            Dim ID_mon As Integer = 0
            Dim Ky_hieu_lop_tc As String = ""
            If cmbID_mon.SelectedValue > 0 Then ID_mon = cmbID_mon.SelectedValue
            If cmbKy_hieu_lop.Text <> "" Then Ky_hieu_lop_tc = cmbKy_hieu_lop.Text
            dv = cls.Search_BienLai(trvLop.ID_lop_list, ID_mon, Ky_hieu_lop_tc).DefaultView
            Me.grdViewBienLai.DataSource = dv
            Fillter_BienLai()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If trvLop.ID_he > 0 Then
                Dim frmESS_ As New frmESS_BienLaiThuHocPhiHocPhan
                frmESS_.ShowDialog(-1, -1, clsBL, trvLop.ID_he, trvLop.ID_lop_list, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, cmbID_thu_chi.SelectedValue)
                cmdList_Click(sender, e)
            Else
                Thongbao("Bạn phải chọn hệ đào tạo")
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If optPhieu_thu.Checked Then
                Dim frmESS_ As New frmESS_BienLaiThuHocPhiHocPhan
                Dim idx_bl As Integer = -1
                Dim dv As DataView = grdViewBienLai.DataSource
                If Not grdViewBienLai.CurrentRow Is Nothing Then
                    'idx_bl = dv.Item(grdViewBienLai.CurrentRow.Index).Item("idx_bl")
                    Dim ID_bien_lai As Integer = dv.Item(grdViewBienLai.CurrentRow.Index).Item("ID_bien_lai")
                    frmESS_.AddNew = False
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim dsID_lop As String = trvLop.ID_lop_list
                    Dim ID_thu_chi As Integer = cmbID_thu_chi.SelectedValue
                    Dim Thu_chi As Integer = 0
                    If optPhieu_thu.Checked Then Thu_chi = 1
                    clsBL = New BienLaiThu_Bussines(ID_bien_lai)
                    frmESS_.ShowDialog(ID_bien_lai, idx_bl, clsBL, trvLop.ID_he, trvLop.ID_lop_list, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1, cmbID_thu_chi.SelectedValue)
                    cmdList_Click(sender, e)
                Else
                    Thongbao("Bạn phải chọn biên lai để sửa !")
                End If
            Else
                Dim idx_bl As Integer = -1
                Dim dv As DataView = grdViewBienLai.DataSource
                If Not grdViewBienLai.CurrentRow Is Nothing Then
                    'idx_bl = dv.Item(grdViewBienLai.CurrentRow.Index).Item("idx_bl")
                    Dim ID_bien_lai As Integer = dv.Item(grdViewBienLai.CurrentRow.Index).Item("ID_bien_lai")
                    Dim frmESS_ As New frmESS_BienLaiChiHocPhiHocPhan
                    frmESS_.AddNew = False
                    clsBL = New BienLaiThu_Bussines(ID_bien_lai)
                    frmESS_.ShowDialog(ID_bien_lai, idx_bl, "", clsBL, trvLop.ID_he, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbDot_thu.SelectedIndex + 1, cmbLan_thu.SelectedIndex + 1)
                    If frmESS_.Save Then
                        cmdList_Click(sender, e)
                    End If
                Else
                    Thongbao("Bạn phải chọn biên lai để sửa !")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            If Thongbao("Bạn có muốn hủy phiếu không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim ID_bien_lai As Integer
            Dim dv As DataView = grdViewBienLai.DataSource
            If Not grdViewBienLai.CurrentRow Is Nothing Then
                Dim Ly_do As String = InputBox("Bạn hãy nhập lý do huỷ phiếu:", "Lý do huỷ phiếu").Replace("'", "''").Trim
                If Ly_do <> "" Then
                    If Ly_do.Length > 100 Then
                        Ly_do = Mid(Ly_do, 1, 100)
                    End If
                End If
                ID_bien_lai = dv.Item(grdViewBienLai.CurrentRow.Index)("ID_bien_lai")
                clsBienLai.CapNhat_ESSBienLaiThu_HuyPhieu(ID_bien_lai, Ly_do)
                Dim Noi_dung As String = ""
                Noi_dung = "Hủy biên lai : " & dv.Item(grdViewBienLai.CurrentRow.Index)("So_phieu").ToString
                SaveLog(LoaiSuKien.Xoa, Noi_dung)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView
            dv = CType(grdViewBienLai.DataSource, DataView)
            For i As Integer = 0 To dv.Count - 1
                dv(i)("Noi_dung") = cmbID_thu_chi.Text
            Next
            If dv Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de1 As String = "", Tieu_de2 As String = "", Tieu_de3 As String = "", Tieu_de4 As String = ""
            Tieu_de1 = "DANH SÁCH BIÊN LAI ĐỢT " & cmbLan_thu.Text & " HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
            If Not cmbID_thu_chi.SelectedValue Is Nothing Then Tieu_de2 = cmbID_thu_chi.Text.Trim
            If dtpTu_ngay.Checked And dtpDen_ngay.Checked Then
                Tieu_de2 &= " (Từ ngày " & dtpTu_ngay.Text & " đến ngày " & dtpDen_ngay.Text & ")"
            End If
            Tieu_de3 = trvLop.Tieu_de
            Tieu_de4 = lblVND.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSachBienLaiThu", dv, Tieu_de1, Tieu_de2, Tieu_de3, )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Try
            If grdViewBienLai.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDataGridViewToExcel(grdViewBienLai)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmdXemBienLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXemBienLai.Click
        Dim dv As DataView = grdViewBienLai.DataSource
        If Not grdViewBienLai.CurrentRow Is Nothing Then
            'Dim idx_bl As Integer = dv.Item(grdViewBienLai.CurrentRow.Index).Item("idx_bl")
            Dim ID_bien_lai As Integer = dv.Item(grdViewBienLai.CurrentRow.Index).Item("ID_bien_lai")
            Dim cls As New BienLaiThu_Bussines(ID_bien_lai)
            Dim objBL As ESSBienLaiThu = cls.BienLaiThu_ID_bien_lai(ID_bien_lai)
            If objBL.Thu_chi = True Then
                Dim frmESS_ As New frmESS_BienLaiThuHocPhiHocPhanXem
                frmESS_.ShowDialog(objBL)
            Else
                Dim frmESS_ As New frmESS_BienLaiChiHocPhiHocPhanXem
                frmESS_.ShowDialog(objBL)
            End If
        End If
    End Sub
End Class