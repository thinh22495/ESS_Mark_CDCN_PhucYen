Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ToChucThi
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_he As Integer = 0
    Private mID_khoa As Integer = 0
    Private mLan_thi As Integer = 0
    Private mDot_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mTen_lop_tc As String = ""
    Private mNien_khoa As String = ""
    Private mKhoa_hoc As Integer = 0
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private clsTCThi As New TochucThi_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private dt_phong_chon As DataTable
    Private clsPhongHoc As New PhongHoc_Bussines
    Private So_sv_da_xep As Integer = 0

#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ToChucThiAdd_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
        LoadComboBox()
        'Đặt học kỳ, năm hoc theo giá trị ở form tổ chức thi chính
        cmbHoc_ky.SelectedValue = mHoc_ky
        cmbNam_hoc.Text = mNam_hoc
        cmbOrder.SelectedIndex = 0
        cmbNhom_tiet.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        cmbDot_thi.SelectedIndex = 0
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.HienThi_ESSTreeView()
        Loader = True
    End Sub
    Private Sub frmESS_ToChucThiAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvMonTinChi_Select() Handles trvMonTinChi.TreeNodeSelected_
        dt_phong_chon = Nothing
        cmdSave.Visible = False
        cmdSua.Visible = True
        Me.Cursor = Cursors.WaitCursor
        Try
            If Loader Then
                mHoc_ky = trvMonTinChi.Hoc_ky
                mNam_hoc = trvMonTinChi.Nam_hoc
                mID_mon_tc = trvMonTinChi.ID_mon_tc
                mID_mon = trvMonTinChi.ID_mon
                mTen_mon = trvMonTinChi.Ten_mon
                mID_he = trvMonTinChi.ID_he

                cmbHoc_ky.SelectedValue = mHoc_ky
                cmbNam_hoc.Text = mNam_hoc

                If gobjUser.ID_khoa > 0 Then
                    mID_khoa = gobjUser.ID_khoa
                Else
                    mID_khoa = trvMonTinChi.ID_khoa
                End If

                If mID_mon > 0 Then
                    Dim dtMon As New DataTable
                    dtMon.Columns.Add("ID_mon")
                    dtMon.Columns.Add("Ten_mon")
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_mon") = mID_mon
                    row("Ten_mon") = mTen_mon
                    dtMon.Rows.Add(row)
                    FillCombo(cmbID_mon, dtMon)
                    cmbID_mon.SelectedValue = mID_mon
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub chkHienThiAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkHienThiAll.CheckedChanged
        Add_MonHoc()
    End Sub
    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thi.SelectedIndexChanged, cmbDot_thi.SelectedIndexChanged, cmbID_mon.SelectedIndexChanged
        If Loader And cmdSua.Visible = True Then
            If mHoc_ky > 0 And mNam_hoc <> "" And mID_mon > 0 And cmbLan_thi.SelectedItem > 0 And cmbDot_thi.SelectedItem > 0 And cmbID_mon.SelectedValue > 0 Then
                mLan_thi = cmbLan_thi.SelectedItem
                mDot_thi = cmbDot_thi.SelectedItem
                'Xoa thong tin to chuc thi 
                If clsTCThi.Count > 0 Then
                    For i As Integer = 0 To clsTCThi.Count - 1
                        clsTCThi.Remove(i)
                    Next
                End If
                'Kiểm tra xem Học phần này đã được tổ chức thi chưa?
                Dim ID_thi As Integer
                Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, mID_khoa, mID_mon, mLan_thi, mDot_thi)
                If dt_TTT.Rows.Count > 0 Then
                    ID_thi = dt_TTT.Rows(0).Item("ID_thi")
                Else
                    ID_thi = -1
                End If
                'Học phần này đã tổ chức thi rồi
                If ID_thi > 0 Then
                    'Load lại dữ liệu đã tổ chức thi
                    clsTCThi = New TochucThi_Bussines(ID_thi)
                    grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(0).ID_thi).DefaultView
                    txtSo_sv.Text = grvDanhSachThi.RowCount
                    txtSo_phong.Text = clsTCThi.ToChucThi(0).dsPhongThi.Count
                    dtpNgay_thi.Value = clsTCThi.ToChucThi(0).Ngay_thi
                    cmbCa.SelectedIndex = clsTCThi.ToChucThi(0).Ca_thi
                    cmbNhom_tiet.SelectedIndex = clsTCThi.ToChucThi(0).Nhom_tiet
                    txtGio_thi.Text = clsTCThi.ToChucThi(0).Gio_thi
                    dt_phong_chon = clsPhongHoc.DanhSachPhongThi(clsTCThi, So_sv_da_xep)

                    cmdToChucThi.Enabled = False
                    cmdAdd_sinh_vien.Enabled = False
                    cmdXoa_ESSsinh_vien.Enabled = False
                    cmdLap_so_bao_danh.Enabled = False

                Else
                    Dim objTCThi As New ESSTochucThi
                    objTCThi.Hoc_ky = mHoc_ky
                    objTCThi.Nam_hoc = mNam_hoc
                    objTCThi.ID_he = mID_he
                    objTCThi.ID_khoa = mID_khoa
                    objTCThi.Lan_thi = mLan_thi
                    objTCThi.Dot_thi = mDot_thi
                    objTCThi.ID_mon = mID_mon
                    objTCThi.Ngay_thi = dtpNgay_thi.Value
                    objTCThi.Ca_thi = cmbCa.SelectedIndex
                    objTCThi.Gio_thi = txtGio_thi.Text.Trim
                    objTCThi.Nhom_tiet = cmbNhom_tiet.SelectedIndex
                    clsTCThi.Add(objTCThi)
                    Me.grcDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                    dt_phong_chon = clsPhongHoc.DanhSachPhongThi(clsTCThi, So_sv_da_xep)

                    cmdToChucThi.Enabled = True
                    cmdAdd_sinh_vien.Enabled = True
                    cmdXoa_ESSsinh_vien.Enabled = True
                    cmdLap_so_bao_danh.Enabled = True
                End If
                'End If
            End If
        End If


    End Sub

    Private Sub cmdAdd_sinh_vien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_sinh_vien.Click
        If clsTCThi.Count > 0 Then
            Dim dv As DataView = grvDanhSachThi.DataSource
            Dim frmESS_ As New frmESS_ToChucThi_ThemSinhVien
            frmESS_.ShowDialog(dv, mHoc_ky, mNam_hoc, mLan_thi, mID_mon)
            If frmESS_.Tag = 1 Then
                Dim dtDanhSachSinhVien As New DataTable
                Dim objTCThi As New ESSTochucThi
                dtDanhSachSinhVien = frmESS_.grvDanhSachThiChon.DataSource.Table

                objTCThi = clsTCThi.ToChucThi(0)
                Dim dt_KDDK_duthi As DataTable = clsTCThi.DanhSachKDDK_DuThi(objTCThi.ID_thi)
                dt_KDDK_duthi.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                    If chkDieuKienThi.Checked Then
                        If dt_KDDK_duthi.DefaultView.Find(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 AndAlso objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New ESSTochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    Else
                        If objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dtDanhSachSinhVien.Rows(i)("ID_sv")) < 0 Then
                            Dim objTCThiChiTiet As New ESSTochucThiChiTiet
                            objTCThiChiTiet.ID_sv = dtDanhSachSinhVien.Rows(i)("ID_sv")
                            objTCThiChiTiet.Ma_sv = dtDanhSachSinhVien.Rows(i)("Ma_sv")
                            objTCThiChiTiet.Ho_ten = dtDanhSachSinhVien.Rows(i)("Ho_ten")
                            If dtDanhSachSinhVien.Rows(i)("Ngay_sinh").ToString <> "" Then objTCThiChiTiet.Ngay_sinh = dtDanhSachSinhVien.Rows(i)("Ngay_sinh")
                            objTCThiChiTiet.Ten_lop = dtDanhSachSinhVien.Rows(i)("Ten_lop")
                            For index As Integer = 0 To dt_KDDK_duthi.Rows.Count - 1
                                If dtDanhSachSinhVien.Rows(i)("ID_sv") = dt_KDDK_duthi.Rows(index)("ID_sv") Then
                                    objTCThiChiTiet.Ghi_chu_thi = dt_KDDK_duthi.Rows(index)("Ly_do")
                                End If
                            Next
                            objTCThi.dsChiTietSinhVien.Add(objTCThiChiTiet)
                        End If
                    End If
                Next
                'Load lai danh sach sinh vien
                grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                txtSo_sv.Text = grvDanhSachThi.RowCount
            End If
        Else
            Thongbao("Bạn phải nhập lần thi, đợt thi và Học phần thi để tổ chức thi!")
        End If
    End Sub
    Private Sub cmdXoa_ESSsinh_vien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXoa_ESSsinh_vien.Click
        Try
            Dim dvDanhSachSinhVien As DataView
            dvDanhSachSinhVien = grvDanhSachThi.DataSource
            If Not dvDanhSachSinhVien Is Nothing Then
                Dim So_sv As Integer = 0
                If clsTCThi.Count > 0 Then
                    Dim objTCThi As New ESSTochucThi
                    Dim idx_sv As Integer
                    objTCThi = clsTCThi.ToChucThi(0)
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien.Item(i)("Chon") Then
                            idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv"))
                            If idx_sv >= 0 Then
                                objTCThi.dsChiTietSinhVien.Remove(idx_sv)
                                So_sv += 1
                            End If
                        End If
                    Next
                    'Load lai danh sach sinh vien
                    grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                    txtSo_sv.Text = grvDanhSachThi.RowCount
                End If
                If So_sv > 0 Then
                    Thongbao("Đã xoá khỏi danh sách tổ chức thi " + So_sv.ToString + " sinh viên ")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdLap_so_bao_danh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLap_so_bao_danh.Click
        Try
            If clsTCThi.Count > 0 Then
                Dim So_dau As String
                So_dau = InputBox("Nhập số bắt đầu của số báo danh:", "", 1)
                If IsNumeric(So_dau) Then
                    If So_dau > 0 Then
                        Dim idx_thi As Integer = 0
                        clsTCThi.LapSoBaoDanh(idx_thi, So_dau, cmbOrder.SelectedIndex)
                        'Load lai danh sach sinh vien với số báo danh mới
                        grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                    Else
                        Thongbao("Bạn phải nhập bắt đầu số báo danh lớn hơn 0")
                    End If
                Else
                    Thongbao("Bạn phải nhập số báo danh là chữ số")
                End If
            Else
                Thongbao("Bạn phải có danh sách sinh viên để lập số báo danh")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdToChucThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdToChucThi.Click
        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim ID_thi_tmp As Integer = 0
                    Dim Edit As Boolean = False
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, mID_khoa, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        ID_thi_tmp = dt_TTT.Rows(0).Item("ID_thi")
                        If (txtGio_thi.Text.Trim <> dt_TTT.Rows(0).Item("Gio_thi").ToString) Or (cmbCa.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Ca_thi")), 0, dt_TTT.Rows(0).Item("Ca_thi")) Or cmbNhom_tiet.SelectedIndex <> IIf(IsDBNull(dt_TTT.Rows(0).Item("Nhom_tiet")), 0, dt_TTT.Rows(0).Item("Nhom_tiet")) Or dtpNgay_thi.Value <> dt_TTT.Rows(0).Item("Ngay_thi").ToString) Then
                            Edit = True
                            clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtGio_thi.Text)
                        End If
                    Else
                        clsTCThi.Update(ID_thi_tmp, cmbCa.SelectedIndex, dtpNgay_thi.Value, cmbNhom_tiet.SelectedIndex, txtGio_thi.Text)
                    End If
                    Dim idx_thi As Integer = 0
                    Dim dv As DataView = grvDanhSachThi.DataSource
                    clsTCThi.Fill_GhiChu(dv, ID_thi_tmp)
                    clsTCThi.TocChucThi(idx_thi, dtpNgay_thi.Value, cmbCa.SelectedIndex, cmbNhom_tiet.SelectedIndex, txtGio_thi.Text, txtSo_phong.Text, txtSo_sv.Text, cmbOrder.SelectedIndex, ID_thi_tmp, Edit, dt_phong_chon)
                    'Load lại danh sách sinh viên
                    Me.grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(clsTCThi.ToChucThi(idx_thi).ID_thi).DefaultView
                    Me.Tag = 1
                    Thongbao("Đã tổ chức thi thành công !")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnChon_phongthi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChon_phongthi.Click
        Dim dv As DataView = grvDanhSachThi.DataSource
        If dv Is Nothing Then
            Thongbao("Bạn phải chọn học phần tổ chức thi và bổ sung sinh viên vào danh sách !", MsgBoxStyle.Information)
            Exit Sub
        End If
        If dv.Count = 0 Or clsTCThi.Count = 0 Then
            Thongbao("Bạn phải chọn học phần tổ chức thi và bổ sung sinh viên vào danh sách !", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim frmESS_ As New frmESS_ToChucThi_Phong
        frmESS_.ShowDialog(dt_phong_chon, CType(txtSo_sv.Text, Integer), So_sv_da_xep)
        Dim idx_thi As Integer = 0
        If frmESS_.Tag = 1 Then
            dt_phong_chon = frmESS_.dtPhongHoc
        End If
    End Sub
#End Region

#Region "User Function"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try
            Dim dt As DataTable
            If cmdLopHC.Visible = False Then 'Lớp hành chính
                'Lấy tất cả các Học phần trong chương trình đào tạo khung
                If chkHienThiAll.Checked Then
                    dt = clsCTDT.DanhSachMonHoc()
                    'Nếu danh sách Học phần không thay đổi thì không phải load lại dữ liệu
                    If Not CompareData(dt, cmbID_mon.DataSource) Then
                        FillCombo(cmbID_mon, dt)
                    End If
                Else    'Lấy các Học phần trong chương trình đào tạo khung theo học kỳ, năm học
                    Dim Ky_thu As Integer
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
                    If Ky_thu > 0 Then
                        dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                        'Nếu danh sách Học phần không thay đổi thì không phải load lại dữ liệu
                        If Not CompareData(dt, cmbID_mon.DataSource) Then
                            FillCombo(cmbID_mon, dt)
                        End If
                    End If
                End If
            Else ' Lớp tín chỉ
                cmbID_mon.ValueMember = mID_mon
                cmbID_mon.DisplayMember = mTen_mon
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckValidate() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        If txtSo_sv.Text = "" Or txtSo_sv.Text = "0" Then
            Call SetErrPro(txtSo_sv, ErrorProvider1, "Bạn phải bổ sung sinh viên trước !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_sv
        End If
        If cmbCa.Text.Trim = "" Then
            Call SetErrPro(cmbCa, ErrorProvider1, "Bạn hãy chọn nhập Ca thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbCa
        End If
        If dtpNgay_thi.Checked = False Then
            Call SetErrPro(dtpNgay_thi, ErrorProvider1, "Bạn hãy chọn ngày thi !")
            If CtrlErr Is Nothing Then CtrlErr = dtpNgay_thi
        End If
        If cmbID_mon.Text.Trim = "" Then
            Call SetErrPro(cmbID_mon, ErrorProvider1, "Bạn hãy chọn học phần !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_mon
        End If
        If cmbNhom_tiet.Text = "" Then
            Call SetErrPro(cmbNhom_tiet, ErrorProvider1, "Bạn hãy chọn nhập nhóm tiết thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNhom_tiet
        End If
        If dt_phong_chon Is Nothing Then
            Call SetErrPro(btnChon_phongthi, ErrorProvider1, "Bạn hãy chọn phòng thi !")
            If CtrlErr Is Nothing Then CtrlErr = btnChon_phongthi
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckValidate = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckValidate = False
        CtrlErr.Focus()
    End Function

    Private Function CheckValidate_TheoSinhVIen() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If cmbCa.Text.Trim = "" Then
            Call SetErrPro(cmbCa, ErrorProvider1, "Bạn hãy chọn nhập Ca thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbCa
        End If
        If dtpNgay_thi.Checked = False Then
            Call SetErrPro(dtpNgay_thi, ErrorProvider1, "Bạn hãy chọn ngày thi !")
            If CtrlErr Is Nothing Then CtrlErr = dtpNgay_thi
        End If
        If cmbID_mon.Text.Trim = "" Then
            Call SetErrPro(cmbID_mon, ErrorProvider1, "Bạn hãy chọn học phần !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_mon
        End If
        If cmbNhom_tiet.Text = "" Then
            Call SetErrPro(cmbNhom_tiet, ErrorProvider1, "Bạn hãy chọn nhập nhóm tiết thi !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNhom_tiet
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckValidate_TheoSinhVIen = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckValidate_TheoSinhVIen = False
        CtrlErr.Focus()
    End Function
    Private Function CompareData(ByVal dt As DataTable, ByVal dt1 As DataTable) As Boolean
        If dt Is Nothing Or dt1 Is Nothing Then Return False
        If dt.Rows.Count <> dt1.Rows.Count Then Return False
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_mon") <> dt1.Rows(i)("ID_mon") Then
                Return False
            End If
        Next
        Return True
    End Function
#End Region

    Private Sub cmdLopTinChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLopTinChi.Click
        TreeViewLop.SendToBack()
        cmdLopTinChi.Visible = False
        cmdLopHC.Visible = True
        cmbID_mon.DataSource = Nothing
        chkHienThiAll.Enabled = False

        cmbHoc_ky.Enabled = False
        cmbNam_hoc.Enabled = False
        cmbID_mon.Enabled = False
    End Sub

    Private Sub cmdLopHC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLopHC.Click
        trvMonTinChi.SendToBack()
        cmdLopTinChi.Visible = True
        cmdLopHC.Visible = False
        chkHienThiAll.Enabled = True

        cmbHoc_ky.Enabled = True
        cmbNam_hoc.Enabled = True
        cmbID_mon.Enabled = True
    End Sub

    Private Sub cmdSua_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSua.Click
        cmdSave.Visible = True
        cmdSua.Visible = False
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        cmdSave.Visible = False
        cmdSua.Visible = True

        Try
            If CheckValidate() Then
                If clsTCThi.Count > 0 Then
                    Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, mID_khoa, mID_mon, mLan_thi, mDot_thi)
                    If dt_TTT.Rows.Count > 0 Then
                        clsTCThi.UpdateLai_TochucThi(dtpNgay_thi.Value, cmbDot_thi.Text, cmbCa.SelectedIndex, cmbNhom_tiet.SelectedIndex, txtGio_thi.Text, dt_TTT.Rows(0).Item("ID_thi"))
                        Thongbao("Đã cập nhật thành công thông tin tổ chức thi thành công")
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCheck_Lich_Canhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck_Lich_Canhan.Click
        Dim dv As DataView = grvDanhSachThi.DataSource
        Dim SV_Trung As String = ""
        If CheckValidate_TheoSinhVIen() Then
            If clsTCThi.Count > 0 Then
                Dim dt_TTT As DataTable = clsTCThi.CheckExist_svTochucThi(mHoc_ky, mNam_hoc, mID_he, 0, mID_mon, mLan_thi, mDot_thi)
                If dt_TTT.Rows.Count > 0 Then
                    For i As Integer = 0 To dv.Count - 1
                        If clsTCThi.CheckExist_TheoSinhVien_svTochucThi(dt_TTT.Rows(0).Item("ID_thi"), cmbCa.SelectedIndex, cmbNhom_tiet.SelectedIndex, dtpNgay_thi.Value, dv.Item(i)("ID_SV")) = 1 Then
                            If SV_Trung.Trim = "" Then
                                SV_Trung = dv.Item(i)("Ma_sv").ToString
                            Else
                                SV_Trung += ", " & dv.Item(i)("Ma_sv").ToString
                            End If
                        End If
                    Next
                End If
            End If
        End If
        If SV_Trung.Trim = "" Then
            Thongbao("Đã kiểm tra thành công thông tin tổ chức thi, không có sinh viên trùng lịch thi !")
        Else
            Thongbao("Đã kiểm tra thành công thông tin tổ chức thi, những sinh viên trùng lịch thi:" & SV_Trung.Trim & " !")
        End If
    End Sub

    Private Sub cmdLoaiSVKDDK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoaiSVKDDK.Click
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            Dim So_sv As Integer = 0
            If clsTCThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_sv As Integer
                objTCThi = clsTCThi.ToChucThi(0)
                Dim dt_KDDK_duthi As DataTable = clsTCThi.DanhSachKDDK_DuThi(objTCThi.ID_thi)
                dt_KDDK_duthi.DefaultView.Sort = "ID_SV"
                For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                    If dt_KDDK_duthi.DefaultView.Find(dvDanhSachSinhVien.Item(i)("ID_sv")) >= 0 AndAlso objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) >= 0 Then
                        idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv"))
                        If idx_sv >= 0 Then
                            objTCThi.dsChiTietSinhVien.Remove(idx_sv)
                            So_sv += 1
                        End If
                    End If
                Next
                'Load lai danh sach sinh vien
                Me.grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                txtSo_sv.Text = Me.grvDanhSachThi.RowCount
            End If
            If So_sv > 0 Then
                Thongbao("Đã loại khỏi danh sách sinh viên không đủ điều kiện dự thi " + So_sv.ToString + " sinh viên ")
            End If
        End If



    End Sub
End Class