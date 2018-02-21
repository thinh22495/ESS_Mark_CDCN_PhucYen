Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_QuyetDinhThoiHoc
    Private dt_sinhvien, dtChon As DataTable
    Private clsDSXetLenLop As DanhSachXetLenLop_Bussines
    Private Loader As Boolean = False

    Public Overloads Sub ShowDialog(ByVal dt_chon As DataTable, ByVal mDanhSachSV As DataTable)
        dtChon = dt_chon
        dt_sinhvien = mDanhSachSV
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_QDThoiHoc_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", 0, 0, 0, 0, "", 0, dt_sinhvien)
        If Not dtChon Is Nothing Then grcDanhSachChon.DataSource = dtChon.DefaultView
        Add_Namhoc(cmbNam_hoc)

        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable = clsDM.DanhMuc_Load("STU_Lop", "Khoa_hoc", "Khoa_hoc")
        FillCombo(cmbKhoa_hoc, dt)
        Loader = True
    End Sub

    Private Sub frmESS_QDThoiHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub



    Private Function CheckData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        If cmbHoc_ky.SelectedValue < 0 Then
            Call SetErrPro(cmbHoc_ky, ErrorProvider1, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedValue < 0 Then
            Call SetErrPro(cmbNam_hoc, ErrorProvider1, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If txtSo_QD.Text.Trim = "" Then
            Call SetErrPro(txtSo_QD, ErrorProvider1, "Bạn hãy nhập số QĐ !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_QD
        End If
        If dtmNgay_qd.Checked = False Then
            Call SetErrPro(dtmNgay_qd, ErrorProvider1, "Bạn hãy chọn ngày QĐ !")
            If CtrlErr Is Nothing Then CtrlErr = dtmNgay_qd
        End If
        If cmbLoai_qd.Text.Trim = "" Then
            Call SetErrPro(cmbLoai_qd, ErrorProvider1, "Bạn hãy chọn Loại quyết định !")
            If CtrlErr Is Nothing Then CtrlErr = cmbLoai_qd
        End If
        If txtLy_do.Text = "" Then
            Call SetErrPro(txtLy_do, ErrorProvider1, "Bạn hãy nhập nội dung của quyết định !")
            If CtrlErr Is Nothing Then CtrlErr = txtLy_do
        End If
        If cmbID_lop.Visible = True AndAlso cmbID_lop.Text.Trim = "" Then
            Call SetErrPro(cmbID_lop, ErrorProvider1, "Bạn hãy chọn lớp học tiếp !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_lop
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckData = False
        CtrlErr.Focus()
    End Function

    Private Sub txtSo_QD_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSo_QD.Leave
        Try
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", 0, 0, 0, 0, "", 0, dt_sinhvien)
            Dim dt_Load As DataTable = clsDSXetLenLop.HienThi_ESSDanhSach_SoQD(txtSo_QD.Text.Trim)
            If dt_Load.Rows.Count > 0 Then
                cmbHoc_ky.SelectedValue = dt_Load.Rows(0).Item("Hoc_ky")
                cmbNam_hoc.Text = dt_Load.Rows(0).Item("Nam_hoc")
                dtmNgay_qd.Checked = True
                dtmNgay_qd.Value = dt_Load.Rows(0).Item("Ngay_QD")
                cmbLoai_qd.SelectedValue = dt_Load.Rows(0).Item("Loai_qd")
                txtLy_do.Text = dt_Load.Rows(0).Item("Ly_do")

                grcDanhSachChon.DataSource = dt_Load.DefaultView
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        If Loader Then
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As DataTable = clsDM.DanhMuc_Load("STU_Lop", "ID_lop", "Ten_lop", "Khoa_hoc", cmbKhoa_hoc.SelectedValue)
            FillCombo(cmbID_lop, dt)
        End If
    End Sub


    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckData() Then Exit Sub
            Dim dv As DataView = grvDanhSachChon.DataSource
            If dv.Count <= 0 Then
                Thongbao("Chưa có sinh viên trên danh sách !", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim obj As New ESSDanhSachXetLenLop
            obj.Hoc_ky = cmbHoc_ky.Text
            obj.Nam_hoc = cmbNam_hoc.Text
            obj.So_qd = txtSo_QD.Text
            obj.Ngay_qd = dtmNgay_qd.Value
            obj.Ly_do = txtLy_do.Text
            obj.Loai_qd = cmbLoai_qd.SelectedValue

            'Check su ton tai cua QD
            Dim dt_Load As New DataTable
            dt_Load = clsDSXetLenLop.HienThi_ESSDanhSach_SoQD(txtSo_QD.Text.Trim)
            If dt_Load.Rows.Count > 0 Then 'Update
                'Update QD
                clsDSXetLenLop.CapNhat_ESSQuyetDinhThoiHoc(obj, dt_Load.Rows(0).Item("ID_QD"))

                'Insert QD chi tiet
                For i As Integer = 0 To dv.Table.Rows.Count - 1
                    Dim dt_check As DataTable = dt_Load.Copy
                    dt_check.DefaultView.RowFilter = "ID_SV=" & dv.Table.Rows(i).Item("ID_SV")
                    If dt_check.DefaultView.Count <= 0 Then
                        Dim objChiTiet As New ESSDanhSachXetLenLop
                        objChiTiet.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                        objChiTiet.ID_lop_cu = dv.Table.Rows(i).Item("ID_lop")
                        objChiTiet.ID_qd = dt_Load.Rows(0).Item("ID_QD")
                        If cmbID_lop.Visible = True Then 'Xet hoc tiep
                            objChiTiet.ID_lop_moi = cmbID_lop.SelectedValue
                            objChiTiet.Loai_qd = 4
                        Else
                            objChiTiet.ID_lop_moi = 0
                            objChiTiet.Loai_qd = cmbLoai_qd.SelectedValue
                        End If
                        clsDSXetLenLop.ThemMoi_ESSQuyetDinhThoiHocChiTiet(objChiTiet)
                    End If
                Next
            Else 'Insert
                'Insert Quyet Dinh
                Dim ID_QD As Integer = clsDSXetLenLop.ThemMoi_ESSQuyetDinhThoiHoc(obj)

                'Insert QD chi tiet
                For i As Integer = 0 To dv.Count - 1

                    Dim dt_check As DataTable = dt_Load.Copy
                    dt_check.DefaultView.RowFilter = "ID_SV=" & dv.Table.Rows(i).Item("ID_SV")

                    If dt_check.DefaultView.Count <= 0 Then
                        Dim objChiTiet As New ESSDanhSachXetLenLop
                        objChiTiet.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                        objChiTiet.ID_lop_cu = dv.Table.Rows(i).Item("ID_lop")
                        objChiTiet.ID_qd = ID_QD
                        If cmbID_lop.Visible = True Then 'Xet hoc tiep
                            objChiTiet.ID_lop_moi = cmbID_lop.SelectedValue
                            objChiTiet.Loai_qd = 4
                        Else
                            objChiTiet.ID_lop_moi = 0
                            objChiTiet.Loai_qd = cmbLoai_qd.SelectedValue
                        End If
                        clsDSXetLenLop.ThemMoi_ESSQuyetDinhThoiHocChiTiet(objChiTiet)
                    End If
                Next
            End If

            Thongbao("Đã cập nhật thành công !", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim dv As DataView = grvDanhSachChon.DataSource
            If dv.Count > 0 Then
                If txtSo_QD.Text.Trim = "" Or cmbLoai_qd.Text.Trim = "" Then
                    Thongbao("Hãy nhập số QĐ và chọn loại QĐ trước khi bớt sinh viên khỏi danh sách !", MsgBoxStyle.Information)
                Else
                    'Check su ton tai cua QD
                    Dim dt_Load As New DataTable
                    dt_Load = clsDSXetLenLop.HienThi_ESSDanhSach_SoQD(txtSo_QD.Text.Trim)
                    If dt_Load.Rows.Count > 0 Then
                        clsDSXetLenLop.Xoa_ESSQuyetDinhThoiHocChiTiet(dt_Load.Rows(0).Item("ID_qd"), dv.Table.Rows(grvDanhSachChon.GetSelectedRows.GetValue(0)).Item("ID_SV"), dv.Table.Rows(grvDanhSachChon.GetSelectedRows.GetValue(0)).Item("ID_lop_cu"), cmbLoai_qd.SelectedIndex)
                    End If
                    dv.Table.Rows(grvDanhSachChon.FocusedRowHandle).Delete()
                    dv.Table.AcceptChanges()
                    grcDanhSachChon.DataSource = dv.Table.DefaultView
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim dv As New DataView
            dv = grvDanhSachChon.DataSource
            Dim dt As New DataTable
            Dim frmESS_ As New frmESS_TimKiemSinhVien
            frmESS_.ShowDialog()
            If frmESS_.Tag = 1 Then ' Nếu chọn được sinh viên
                Dim ID_svs As String = frmESS_.pID_svs
                Dim arrID_sv() As String
                arrID_sv = ID_svs.Split(",")
                Dim obj As New DanhSachSinhVien_Bussines(gobjUser.dsID_lop)
                dt = obj.Danh_sach_sinh_vien(arrID_sv)
                If dv Is Nothing Then
                    dv = dt.DefaultView
                Else
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim dr As DataRow
                        dr = dv.Table.NewRow
                        dr.Item("ID_sv") = dt.Rows(i).Item("ID_SV")
                        dr.Item("Ma_SV") = dt.Rows(i).Item("Ma_SV")
                        dr.Item("Ho_ten") = dt.Rows(i).Item("Ho_ten")
                        dr.Item("Ngay_sinh") = dt.Rows(i).Item("Ngay_sinh")
                        dr.Item("ID_lop") = dt.Rows(i).Item("ID_lop")
                        dr.Item("Ten_lop") = dt.Rows(i).Item("Ten_lop")
                        dr.Item("ID_lop_cu") = 0
                        dv.Table.Rows.Add(dr)
                    Next
                End If

            End If
            grcDanhSachChon.DataSource = dv
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class