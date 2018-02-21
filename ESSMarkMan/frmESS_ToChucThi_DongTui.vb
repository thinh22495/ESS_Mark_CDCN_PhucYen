Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_ToChucThi_DongTui
    Private mID_thi As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mLan_thi As Integer = 0
    Private mDot_thi As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mTen_mon As String = ""
    Private mID_khoa As Integer = 0
    Private mTen_khoa As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""
    Private Loader As Boolean = False
    Private clsTCThi As New TochucThi_Bussines
    Private mdtDanhSachSinhVien As New DataTable
#Region "Form Events"
    Private Sub frmESS_ToChucThiDongTui_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Loader = True
            SetQuyenTruyCap(, cmdLap_phach, , cmdXoa_tui)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ToChucThiDongTui_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        HienThi_ESSDataGridView()
    End Sub

    Private Sub cmbTui_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTui_thi.SelectedIndexChanged
        HienThi_ESSDataGridView()
    End Sub

    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub
    Private Sub chkAll2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll2.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThiChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll2.Checked
            Next
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

#Region "User Functions"
    Private Function CheckValidate() As Boolean
        If txtSo_sv.Text = "" Or txtSo_sv.Text = "0" Then
            Thongbao("Bạn phải bổ sung sinh viên trước")
            Return False
        End If
        If txtSophach_tu.Text = "" Or txtSophach_tu.Text = "0" Then
            Thongbao("Bạn phải xác định số phách bắt đầu")
            txtSophach_tu.Focus()
            Return False
        End If
        Return True
    End Function
#End Region
    Private Sub cmdPrint_DiemSoChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_DiemSoChu.Click
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If
                Dim dv As DataView = grvDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy  '= clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1)
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Lan_thi")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_mon")
                dt.Columns.Add("Ngay_thi")

                If dt.Rows.Count > 0 Then
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                    dt.Rows(0).Item("Lan_thi") = mLan_thi
                    dt.Rows(0).Item("Ten_khoa") = mTen_khoa
                    dt.Rows(0).Item("Hoc_ky") = mHoc_ky
                    dt.Rows(0).Item("Nam_hoc") = mNam_hoc
                    dt.Rows(0).Item("Ten_mon") = mTen_mon
                    dt.Rows(0).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("PhachSinhVien_KiemTra1", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrin_HoiPhach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrin_HoiPhach.Click
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                Dim dv As DataView = grvDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy
                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("PhachSinhVien_KiemTra2", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_Full_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_Full.Click
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If
                Dim dv As DataView = grvDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Lan_thi")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_mon")
                dt.Columns.Add("Ngay_thi")

                If dt.Rows.Count > 0 Then
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                    dt.Rows(0).Item("Lan_thi") = mLan_thi
                    dt.Rows(0).Item("Ten_khoa") = mTen_khoa
                    dt.Rows(0).Item("Hoc_ky") = mHoc_ky
                    dt.Rows(0).Item("Nam_hoc") = mNam_hoc
                    dt.Rows(0).Item("Ten_mon") = mTen_mon
                    dt.Rows(0).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("PhachSinhVien_KiemTra", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DoiChieu_PhachSBD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_DoiChieu_PhachSBD.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Phach")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_DoiChieu_PhachSBDDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_DoiChieu_PhachSBDDiem.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Phach_Diem")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_SBDDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_SBDDiem.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "SoBD_Diem")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub txtSophach_tu_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSophach_tu.Leave
        HienThi_ESSDataGridView()
    End Sub

    Private Sub HienThi_ESSDataGridView()
        If Loader Then
            mID_thi = trvPhongThi.ID_thi
            mID_phong_thi = trvPhongThi.ID_phong_thi
            mLan_thi = trvPhongThi.Lan_thi
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mTen_mon = trvPhongThi.Ten_mon
            mTen_phong = trvPhongThi.Phong_thi
            mTen_khoa = trvPhongThi.Ten_khoa
            mID_khoa = trvPhongThi.ID_khoa
            If cmbTui_thi.SelectedIndex >= 0 Then
                'Load danh sach sinh vien chua dong tui
                grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienChuaDongTui(mID_thi, mID_phong_thi).DefaultView
            End If
        End If

        If mID_thi > 0 Then
            'Load dữ liệu về tổ chức thi
            clsTCThi = New TochucThi_Bussines(mID_thi)
            If cmbTui_thi.SelectedIndex >= 0 Then   'Load sinh viên theo từng túi
                grcDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                txtSo_sv.Text = grvDanhSachThiChon.RowCount
            Else
                grcDanhSachThiChon.DataSource = Nothing
                txtSo_sv.Text = 0
            End If
        Else
            grcDanhSachThiChon.DataSource = Nothing
            txtSo_sv.Text = 0
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv, ID_sv As Integer
            dv = grvDanhSachThi.DataSource
            dvChon = grvDanhSachThiChon.DataSource
            If dvChon Is Nothing Then dvChon.Table = dv.Table.Clone
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    Dim dr As DataRow
                    ID_sv = dv(i)("ID_sv")
                    clsTCThi.GanTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1, ID_sv)
                    If IsNothing(dvChon) Then
                        dr = dv.Table.NewRow
                    Else
                        dr = dvChon.Table.NewRow
                    End If
                    dr("Chon") = dv(i)("Chon")
                    dr("ID_sv") = dv(i)("ID_sv")
                    dr("ID_dt") = dv(i)("ID_dt")
                    dr("So_bao_danh") = dv(i)("So_bao_danh")
                    dr("Ma_sv") = dv(i)("Ma_sv")
                    dr("Ho_ten") = dv(i)("Ho_ten")
                    dr("Ngay_sinh") = dv(i)("Ngay_sinh")
                    dr("ID_lop") = dv(i)("ID_lop")
                    dr("Ten_lop") = dv(i)("Ten_lop")
                    dr("Ten_phong") = dv(i)("Ten_phong")
                    dr("Ghi_chu_thi") = dv(i)("Ghi_chu_thi")
                    dr("OrderBy") = dv(i)("OrderBy")
                    dr("ID_ds_thi") = dv(i)("ID_ds_thi")
                    dr("ID_phong_thi") = dv(i)("ID_phong_thi")
                    dr("Tui_so") = dv(i)("Tui_so")
                    dr("So_phach") = 0
                    dvChon.Table.Rows.Add(dr)
                    dv.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để thêm ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv, ID_sv As Integer
            dv = grvDanhSachThi.DataSource
            dvChon = grvDanhSachThiChon.DataSource
            If dvChon Is Nothing Then Exit Sub
            For i As Integer = dvChon.Count - 1 To 0 Step -1
                If dvChon.Item(i)("Chon") Then
                    Dim dr As DataRow
                    ID_sv = dvChon(i)("ID_sv")
                    clsTCThi.GanTuiThi(mID_thi, 0, ID_sv)
                    If IsNothing(dv) Then
                        dr = dvChon.Table.NewRow
                    Else
                        dr = dv.Table.NewRow
                    End If
                    dr("Chon") = dvChon(i)("Chon")
                    dr("ID_sv") = dvChon(i)("ID_sv")
                    dr("ID_dt") = dvChon(i)("ID_dt")
                    dr("So_bao_danh") = dvChon(i)("So_bao_danh")
                    dr("Ma_sv") = dvChon(i)("Ma_sv")
                    dr("Ho_ten") = dvChon(i)("Ho_ten")
                    dr("Ngay_sinh") = dvChon(i)("Ngay_sinh")
                    dr("ID_lop") = dvChon(i)("ID_lop")
                    dr("Ten_lop") = dvChon(i)("Ten_lop")
                    dr("Ten_phong") = dvChon(i)("Ten_phong")
                    dr("Ghi_chu_thi") = dvChon(i)("Ghi_chu_thi")
                    dr("OrderBy") = dvChon(i)("OrderBy")
                    dr("ID_ds_thi") = dvChon(i)("ID_ds_thi")
                    dr("ID_phong_thi") = dvChon(i)("ID_phong_thi")
                    dr("Tui_so") = 0
                    dr("So_phach") = 0
                    dv.Table.Rows.Add(dr)
                    dvChon.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để xoá ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If CheckValidate() Then
                If cmbTui_thi.SelectedIndex >= 0 Then
                    If clsTCThi.KiemTraSoPhach(mID_thi, txtSophach_tu.Text, txtSo_sv.Text) Then
                        clsTCThi.LapSoPhach(mID_thi, cmbTui_thi.SelectedIndex + 1, txtSophach_tu.Text)
                        'Load lai danh sach
                        grcDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                        txtSo_sv.Text = grvDanhSachThiChon.RowCount
                        Thongbao("Đã lập xong số phách ")
                    Else
                        Thongbao("Giải phách này đã bị trùng với túi thi khác, bạn nhập lại số phách bắt đầu bằng số khác !")
                        txtSophach_tu.Focus()
                    End If
                Else
                    Thongbao("Bạn phải chọn túi để đánh số phách ")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If cmbTui_thi.SelectedIndex >= 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá túi thi này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    clsTCThi.XoaTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1)
                    'Load lai danh sach
                    grcDanhSachThiChon.DataSource = clsTCThi.DanhSachSinhVienTheoTuiThi(mID_thi, cmbTui_thi.SelectedIndex + 1).DefaultView
                    txtSo_sv.Text = grvDanhSachThiChon.RowCount
                    Thongbao("Đã xoá xong túi thi")
                End If
            Else
                Thongbao("Bạn phải chọn túi để xoá sinh viên ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If cmbTui_thi.SelectedIndex >= 0 AndAlso mID_thi > 0 Then
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If
                Dim dv As DataView = grvDanhSachThiChon.DataSource

                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Lan_thi")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Hoc_ky")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_mon")
                dt.Columns.Add("Ngay_thi")

                If dt.Rows.Count > 0 Then
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                    dt.Rows(0).Item("Lan_thi") = mLan_thi
                    dt.Rows(0).Item("Ten_khoa") = mTen_khoa
                    dt.Rows(0).Item("Hoc_ky") = mHoc_ky
                    dt.Rows(0).Item("Nam_hoc") = mNam_hoc
                    dt.Rows(0).Item("Ten_mon") = mTen_mon
                    dt.Rows(0).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("PhachSinhVien_KiemTra", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
End Class