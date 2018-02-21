Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_XetHocNganh2
    Private mID_sv As Integer = 0
    Private mID_dt_old As Integer = 0
    Private clsNganh2 As DanhSachNganh2_Bussines
    Dim TBCHT As Double = 0
    Private mID_he As Integer
    Private Loadder As Boolean = False
    Private mID_cn1 As Integer = 0
    Private Sub frmESS_XetHocNganh2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_XetHocNganh2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            SetQuyenTruyCap(, cmdSave, , )

            Dim clsDanhMuc As New DanhMuc_Bussines
            Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT Khoa_hoc,Khoa_hoc AS KhoaHoc from  STU_Lop ORDER BY Khoa_hoc")
            FillCombo(cmbKhoa_hoc, dt, "Khoa_hoc", "Khoa_hoc")

            Loadder = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_XetHocNganh2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        Try
            mID_sv = 0
            mID_dt_old = 0
            TBCHT = 0
            mID_he = 0
            If txtMa_sv.Text.Trim <> "" Then
                clsNganh2 = New DanhSachNganh2_Bussines(0, 0, txtMa_sv.Text.Trim)

                Dim dt As DataTable = clsNganh2.SinhVienChuongTrinh2()

                If dt.Rows.Count > 0 Then
                    Dim clsDiem As New Diem_Bussines(gobjUser.ID_dv, dt.Rows(0).Item("ID_SV"), dt.Rows(0).Item("ID_dt1"))
                    Dim dt_SinhVien As DataTable = clsDiem.XetHoc2ChuongTrinh(dt)
                    If dt_SinhVien.Rows.Count > 0 Then
                        mID_sv = dt_SinhVien.Rows(0).Item("ID_sv")
                        mID_he = dt_SinhVien.Rows(0).Item("ID_he")
                        lblChuyen_nganh.Text = dt_SinhVien.Rows(0).Item("Chuyen_nganh").ToString
                        lblTen_nganh.Text = dt_SinhVien.Rows(0).Item("Ten_nganh").ToString
                        lblXep_hang_hoc_luc.Text = dt_SinhVien.Rows(0).Item("Xep_loai").ToString
                        lblHo_ten.Text = dt_SinhVien.Rows(0).Item("Ho_ten").ToString
                        lblSo_ky_tich_luy.Text = dt_SinhVien.Rows(0).Item("Ky_tich_luy").ToString
                        TBCHT = IIf(IsDBNull(dt_SinhVien.Rows(0).Item("TBCHT")), 0, dt_SinhVien.Rows(0).Item("TBCHT"))

                        'Neu cac gia tri duoi ko NULL thi se Load ra va co the Update
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("Hoc_ky")) Then cmbHoc_ky.Text = dt_SinhVien.Rows(0).Item("Hoc_ky")
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("Nam_hoc")) Then cmbNam_hoc.Text = dt_SinhVien.Rows(0).Item("Nam_hoc")
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("So_QD")) Then txtSo_QD.Text = dt_SinhVien.Rows(0).Item("So_QD").ToString
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("ID_cn1")) Then
                            mID_cn1 = dt_SinhVien.Rows(0).Item("ID_cn1")
                            '    Dim clsDM As New DanhMuc_Bussines
                            '    FillCombo(cmbID_chuyen_nganh, clsDM.DanhMuc_DKKhac_Load("STU_ChuyenNganh", "ID_chuyen_nganh", "Chuyen_nganh", " ID_chuyen_nganh IN (SELECT ID_chuyen_nganh from  PLAN_ChuongTrinhDaoTao WHERE ID_he=" & mID_he & " AND Khoa_hoc=" & CType(cmbKhoa_hoc.Text, Integer) & ") AND ID_nganh", "SELECT ID_nganh from  STU_ChuyenNganh WHERE ID_chuyen_nganh=" & dt_SinhVien.Rows(0).Item("ID_cn1")))
                        End If
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("Ngay_QD")) Then
                            dtmNgay_qd.Checked = True
                            dtmNgay_qd.Value = dt_SinhVien.Rows(0).Item("Ngay_QD")

                            'Luu vao bien de lay khi update
                            mID_dt_old = dt_SinhVien.Rows(0).Item("ID_dt2")
                        End If
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("Noi_dung")) Then txtLy_do.Text = dt_SinhVien.Rows(0).Item("Noi_dung").ToString
                        If Not IsDBNull(dt_SinhVien.Rows(0).Item("ID_cn2")) Then
                            cmbID_chuyen_nganh.SelectedValue = dt_SinhVien.Rows(0).Item("ID_cn2")
                        End If
                    End If
                Else
                    cmbHoc_ky.SelectedIndex = -1
                    cmbNam_hoc.SelectedIndex = -1
                    txtSo_QD.Text = ""
                    cmbID_chuyen_nganh.SelectedIndex = -1
                    mID_dt_old = 0
                    dtmNgay_qd.Checked = False
                    txtLy_do.Text = ""
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If cmbKhoa_hoc.Text = "" Then
                Thongbao("Hãy chọn Khóa học theo ngành 2!")
                Exit Sub
            End If
            If (lblSo_ky_tich_luy.Text.Trim <> "" AndAlso CType(lblSo_ky_tich_luy.Text.Trim, Integer) > 0) And (lblXep_hang_hoc_luc.Text.Trim <> "" AndAlso TBCHT > 2) Then
                If CheckData() Then
                    Dim obj As New ESSDanhSachNganh2
                    obj.ID_sv = mID_sv
                    obj.ID_dt2 = clsNganh2.Get_CTDT(cmbID_chuyen_nganh.SelectedValue, CType(cmbKhoa_hoc.Text, Integer), mID_he)
                    obj.Hoc_ky = cmbHoc_ky.Text
                    obj.Nam_hoc = cmbNam_hoc.Text
                    obj.So_qd = txtSo_QD.Text
                    obj.Ngay_qd = dtmNgay_qd.Value
                    obj.Noi_dung = txtLy_do.Text
                    obj.Ngung_hoc = 0
                    obj.Khoa_hoc2 = cmbKhoa_hoc.Text
                    obj.ID_lop = cmbID_lop.SelectedValue

                    If mID_dt_old > 0 Then 'Update
                        clsNganh2.CapNhat_ESSsvDanhSachNganh2(obj, mID_dt_old)
                    Else 'Insert
                        mID_dt_old = cmbID_chuyen_nganh.SelectedValue
                        clsNganh2.ThemMoi_ESSsvDanhSachNganh2(obj)
                    End If
                End If
            ElseIf Thongbao("Số kỳ>0 hoặc xếp hạng học tập Bình thường, sinh viên này chưa đủ tiêu chuẩn xét học Ngành 2 bạn có tiếp tục ?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If CheckData() Then
                    Dim obj As New ESSDanhSachNganh2
                    obj.ID_sv = mID_sv
                    obj.ID_dt2 = clsNganh2.Get_CTDT(cmbID_chuyen_nganh.SelectedValue, CType(cmbKhoa_hoc.Text, Integer), mID_he)
                    obj.Hoc_ky = cmbHoc_ky.Text
                    obj.Nam_hoc = cmbNam_hoc.Text
                    obj.So_qd = txtSo_QD.Text
                    obj.Ngay_qd = dtmNgay_qd.Value
                    obj.Noi_dung = txtLy_do.Text
                    obj.Ngung_hoc = 0
                    obj.Khoa_hoc2 = cmbKhoa_hoc.Text
                    obj.ID_lop = cmbID_lop.SelectedValue

                    If mID_dt_old > 0 Then 'Update
                        clsNganh2.CapNhat_ESSsvDanhSachNganh2(obj, mID_dt_old)
                    Else 'Insert
                        mID_dt_old = cmbID_chuyen_nganh.SelectedValue
                        clsNganh2.ThemMoi_ESSsvDanhSachNganh2(obj)
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Function CheckData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        If txtSo_QD.Text.Trim = "" Then
            Call SetErrPro(txtSo_QD, ErrorProvider1, "Bạn hãy nhập số quyết định !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_QD
        End If
        If txtMa_sv.Text.Trim = "" Then
            Call SetErrPro(txtMa_sv, ErrorProvider1, "Bạn hãy nhập mã sinh viên !")
            If CtrlErr Is Nothing Then CtrlErr = txtMa_sv
        End If
        If cmbHoc_ky.Text.Trim = "" Then
            Call SetErrPro(cmbHoc_ky, ErrorProvider1, "Bạn hãy nhập học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.Text.Trim = "" Then
            Call SetErrPro(cmbNam_hoc, ErrorProvider1, "Bạn hãy nhập năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbID_chuyen_nganh.Text.Trim = "" Then
            Call SetErrPro(cmbID_chuyen_nganh, ErrorProvider1, "Bạn hãy nhập chuyên ngành !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_chuyen_nganh
        End If
        If dtmNgay_qd.Checked = False Then
            Call SetErrPro(dtmNgay_qd, ErrorProvider1, "Bạn hãy nhập ngày QĐ học ngành 2 !")
            If CtrlErr Is Nothing Then CtrlErr = dtmNgay_qd
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckData = False
        CtrlErr.Focus()
    End Function

    Private Sub cmdTimSV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTimSV.Click
        Try
            Dim frmESS_ As New frmESS_TimKiemSinhVien
            frmESS_.ShowDialog()
            If frmESS_.Tag = 1 Then
                txtMa_sv.Text = frmESS_.mMa_sv.Trim
                If txtMa_sv.Text.Trim <> "" Then
                    txtMa_sv.Focus()
                    txtSo_QD.Focus()
                Else
                    Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Loadder = False Then Exit Sub
            If cmbKhoa_hoc.Text = "" Then Exit Sub

            Dim clsDM As New DanhMuc_Bussines
            FillCombo(cmbID_chuyen_nganh, clsDM.DanhMuc_DKKhac_Load("STU_ChuyenNganh", "ID_chuyen_nganh", "Chuyen_nganh", " ID_chuyen_nganh IN (SELECT ID_chuyen_nganh from  PLAN_ChuongTrinhDaoTao WHERE ID_he=" & mID_he & " AND Khoa_hoc=" & CType(cmbKhoa_hoc.Text, Integer) & ") AND ID_nganh", "SELECT ID_nganh from  STU_ChuyenNganh WHERE ID_chuyen_nganh=" & mID_cn1))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loadder = False Then Exit Sub
            If cmbKhoa_hoc.Text = "" Or cmbID_chuyen_nganh.Text = "" Then Exit Sub

            Dim clsDanhMuc As New DanhMuc_Bussines
            Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT ID_lop,Ten_lop from  STU_Lop WHERE Khoa_hoc=" & cmbKhoa_hoc.Text & " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue & " ORDER BY Khoa_hoc,Ten_lop")
            FillCombo(cmbID_lop, dt, "ID_lop", "Ten_lop")
        Catch ex As Exception
        End Try
    End Sub
End Class
