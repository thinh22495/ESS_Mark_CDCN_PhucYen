Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DanhSachSinhVien_QuyetDinh_DanhSach
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDSXetLenLop As DanhSachXetLenLop_Bussines
    Dim flg As Boolean = False
    Dim clsDM As New DanhMuc_Bussines
    Dim dt As New DataTable

#Region "Form Events"
    Private Sub frmESS_QuyetDinhNgungThoiHocList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_Namhoc(cmbNam_hoc)

        dt = clsDM.DanhMuc_Load("STU_He", "ID_he", "Ten_he")
        FillCombo(cmbID_he, dt)
        flg = True
        SetQuyenTruyCap(cmdAdd_NgungHoc, cmdAdd_HocTiep, cmdAdd_ChuyenTruong, )
        SetQuyenTruyCap(, , , cmdXoa_ESSQD)
    End Sub

    Private Sub frmESS_QuyetDinhNgungThoiHocList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmbLoai_QD_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLoai_QD.SelectedIndexChanged
        Try
            ErrorProvider1.Dispose()
            grcDanhSachSV.DataSource = Nothing
            If cmbLoai_QD.SelectedIndex = 1 Then
                cmdAdd_NgungHoc.Enabled = True
                cmdAdd_HocTiep.Enabled = True
                cmdAdd_ChuyenTruong.Enabled = False
                Dim dt As DataTable = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex)
                grcDanhSachQuyetDinh.DataSource = dt.DefaultView
            ElseIf cmbLoai_QD.SelectedIndex = 3 Then
                cmdAdd_ChuyenTruong.Enabled = True
                cmdAdd_NgungHoc.Enabled = False
                cmdAdd_HocTiep.Enabled = False
            ElseIf cmbLoai_QD.SelectedIndex = 0 Then
                cmdAdd_NgungHoc.Enabled = True
                cmdAdd_ChuyenTruong.Enabled = False
                cmdAdd_HocTiep.Enabled = False
            Else
                cmdAdd_ChuyenTruong.Enabled = False
                cmdAdd_NgungHoc.Enabled = False
                cmdAdd_HocTiep.Enabled = False
            End If
            If flg Then
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            Else
                grcDanhSachQuyetDinh.DataSource = Nothing
                grcDanhSachSV.DataSource = Nothing
            End If
            If grvDanhSachQuyetDinh.RowCount <= 0 Then
                grcDanhSachSV.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        Try
            If flg Then
                flg = False
                dt = clsDM.DanhMuc_Load("STU_Lop", "Khoa_hoc", "Khoa_hoc", "ID_he", cmbID_he.SelectedValue)
                FillCombo(cmbKhoa_hoc, dt)

                dt = clsDM.DanhMuc_Khoa_Load(cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue)
                FillCombo(cmbID_khoa, dt)
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, 0, 0, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                flg = True
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If flg Then
                flg = False
                dt = clsDM.DanhMuc_Khoa_Load(cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue)
                FillCombo(cmbID_khoa, dt)
                flg = True

                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If flg Then
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            Else
                grcDanhSachQuyetDinh.DataSource = Nothing
                grcDanhSachSV.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If flg Then
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            Else
                grcDanhSachQuyetDinh.DataSource = Nothing
                grcDanhSachSV.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grdViewQuyetDinh_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Try
            Dim dv As DataView = grvDanhSachQuyetDinh.DataSource
            If dv.Count > 0 Then
                grcDanhSachSV.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_SoQD(dv.Table.Rows(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0)).Item("So_QD")).DefaultView
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FillLoai_QD(ByVal cmb As ComboBox)
        Dim dt As New DataTable
        dt.Columns.Add("Loai_QD", GetType(Integer))
        dt.Columns.Add("Ten_loai", GetType(String))

        Dim dr As DataRow
        dr = dt.NewRow
        dr.Item("Loai_QD") = 1
        dr.Item("Ten_loai") = "Ngừng học"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("Loai_QD") = 2
        dr.Item("Ten_loai") = "Thôi học-Xóa tên"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("Loai_QD") = 3
        dr.Item("Ten_loai") = "Chuyển trường"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("Loai_QD") = 4
        dr.Item("Ten_loai") = "Xét học tiếp"
        dt.Rows.Add(dr)

        FillCombo(cmb, dt)
    End Sub

    Private Sub frmESS_QuyetDinhThoiHocList_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub


    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Try
            Dim frmESS_Search_QuyetDinh As New frmESS_DanhSachSinhVien_QuyetDinh_Tim
            frmESS_Search_QuyetDinh.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_QD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_QD.Click
        Dim dt As New DataTable
        dt.Columns.Add("Tieu_de_ten_bo")
        dt.Columns.Add("Tieu_de_Ten_truong")
        dt.Columns.Add("Tieu_de_chuc_danh1")
        dt.Columns.Add("Tieu_de_nguoi_ky1")
        dt.Columns.Add("Tieu_de_noi_ky")
        dt.Columns.Add("Ho_ten")
        dt.Columns.Add("Ten_lop")
        dt.Columns.Add("Ten_khoa")
        dt.Columns.Add("Ly_do")
        dt.Columns.Add("So_QD")
        dt.Columns.Add("Ngay_QD")
        dt.Columns.Add("Nam_hoc")
        dt.Columns.Add("Ngay_xet")

        Dim dr As DataRow = dt.NewRow
        If grvDanhSachQuyetDinh.RowCount <= 0 Then Exit Sub

        Dim dv_QD As DataView = grvDanhSachQuyetDinh.DataSource
        Dim dv_SV As DataView = grvDanhSachSV.DataSource
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        dr("Ngay_xet") = Format(dtmNgay_xet.Value, "dd/MM/yyyy")
        If objBaoCaoTieuDe.Count > 0 Then
            dr("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            dr("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            dr("Tieu_de_chuc_danh1") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            dr("Tieu_de_nguoi_ky1") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            dr("Tieu_de_noi_ky") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            dr("Tieu_de_ten_bo") = ""
            dr("Tieu_de_Ten_truong") = ""
            dr("Tieu_de_chuc_danh1") = ""
            dr("Tieu_de_nguoi_ky1") = ""
            dr("Tieu_de_noi_ky") = ""
        End If

        If dv_QD.Count > 0 Then
            dr("So_QD") = dv_QD.Item(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0))("So_QD").ToString
            dr("Ngay_QD") = Format(dv_QD.Item(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0))("Ngay_QD"), "dd/MM/yyyy")
            dr("Ly_do") = dv_QD.Item(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0))("Ly_do").ToString
            dr("Nam_hoc") = dv_QD.Item(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0))("Nam_hoc").ToString
        End If
        If dv_SV.Count > 0 Then
            dr("Ho_ten") = dv_SV.Item(grvDanhSachSV.GetSelectedRows.GetValue(0))("Ho_ten").ToString
            dr("Ten_lop") = dv_SV.Item(grvDanhSachSV.GetSelectedRows.GetValue(0))("Ten_lop").ToString
            dr("Ten_khoa") = dv_SV.Item(grvDanhSachSV.GetSelectedRows.GetValue(0))("Ten_khoa").ToString
        End If
        dt.Rows.Add(dr)

        Dim frmESS_ As New frmESS_XemBaoCao
        frmESS_.ShowDialog_RFix("QuyetDinhThoiHoc", dt)
    End Sub

    Private Sub cmdXoa_ESSQD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXoa_ESSQD.Click
        Try
            If grvDanhSachQuyetDinh.RowCount <= 0 Then Exit Sub
            Dim dv As DataView = grvDanhSachQuyetDinh.DataSource
            If cmbLoai_QD.Text.Trim <> "" AndAlso dv.Count > 0 Then
                If Thongbao("Bạn có muốn xóa quyết định này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim ID_QD As Integer = dv.Item(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0))("ID_QD")
                    Dim dv_sub As DataView = grvDanhSachSV.DataSource
                    'Xoa danh sach chi tiet
                    For i As Integer = 0 To dv_sub.Count - 1
                        clsDSXetLenLop.Xoa_ESSQuyetDinhThoiHocChiTiet(ID_QD, dv_sub.Item(i)("ID_SV"), dv_sub.Item(i)("ID_lop_cu"), cmbLoai_QD.SelectedIndex)
                    Next
                    'Xoa QD Main
                    clsDSXetLenLop.Xoa_ESSQuyetDinhThoiHoc(ID_QD)
                    cmbLoai_QD_SelectedIndexChanged(sender, e)
                    Thongbao("Xoá thành công !", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAdd_HocTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_HocTiep.Click
        Try
            If cmbLoai_QD.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại quyết định !", MsgBoxStyle.Information)
                Call SetErrPro(cmbLoai_QD, ErrorProvider1, "Bạn hãy chọn Loại quyết định !")
            Else
                Dim dv As DataView = grvDanhSachSV.DataSource
                Dim dt As DataTable = dv.Table.Clone
                Dim dr As DataRow
                dt.Columns.Add("ID_lop", GetType(Integer))
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        dr = dt.NewRow
                        dr.ItemArray = dv.Item(i).Row.ItemArray
                        dr.Item("ID_lop") = IIf(IsDBNull(dr.Item("ID_lop_cu")), 0, dr.Item("ID_lop_cu"))
                        dr.Item("Chon") = False
                        dt.Rows.Add(dr)
                    End If
                Next
                If dt.Rows.Count > 0 Then
                    Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                    FillLoai_QD(frmESS_.cmbLoai_qd)
                    frmESS_.cmbLoai_qd.SelectedValue = 4
                    frmESS_.cmbLoai_qd.Enabled = False
                    frmESS_.cmdAdd.Visible = False
                    frmESS_.cmbID_lop.Visible = True
                    frmESS_.lblLop.Visible = True
                    frmESS_.cmbKhoa_hoc.Visible = True
                    frmESS_.lblKhoaHoc.Visible = True
                    frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)

                    clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                    grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAdd_NgungHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_NgungHoc.Click
        Try

            If grvDanhSachQuyetDinh.RowCount > 0 Then
                Dim dv As DataView = grvDanhSachSV.DataSource
                Dim dt As DataTable = dv.Table.Clone
                Dim dr As DataRow
                dt.Columns.Add("ID_lop", GetType(Integer))
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        dr = dt.NewRow
                        dr.ItemArray = dv.Item(i).Row.ItemArray
                        dr.Item("ID_lop") = IIf(IsDBNull(dr.Item("ID_lop_cu")), 0, dr.Item("ID_lop_cu"))
                        dr.Item("Chon") = False
                        dt.Rows.Add(dr)
                    End If
                Next
                If dt.Rows.Count > 0 Then
                    Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                    FillLoai_QD(frmESS_.cmbLoai_qd)
                    frmESS_.cmbLoai_qd.SelectedValue = 2
                    frmESS_.cmbLoai_qd.Enabled = False
                    frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)

                    clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                    grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
                End If
            Else
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.ShowDialog(Nothing, mdtDanhSachSinhVien)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdAdd_ChuyenTruong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_ChuyenTruong.Click
        Try
            If cmbLoai_QD.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại quyết định !", MsgBoxStyle.Information)
                Call SetErrPro(cmbLoai_QD, ErrorProvider1, "Bạn hãy chọn Loại quyết định !")
            Else
                Dim dt As DataTable = Nothing
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.cmbLoai_qd.SelectedValue = 3
                frmESS_.cmbLoai_qd.Enabled = False
                frmESS_.cmdRemove.Visible = False
                frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)

                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "", cmbID_he.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_khoa.SelectedValue, IIf(cmbHoc_ky.Text.Trim = "", 0, cmbHoc_ky.Text), cmbNam_hoc.Text, 0, mdtDanhSachSinhVien)
                grcDanhSachQuyetDinh.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_QD_TrangThaiHoc(cmbLoai_QD.SelectedIndex).DefaultView
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub grvDanhSachQuyetDinh_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvDanhSachQuyetDinh.SelectionChanged
        Try
            If grvDanhSachQuyetDinh.RowCount > 0 Then
                Dim dv As DataView = grvDanhSachQuyetDinh.DataSource
                If dv.Count > 0 Then
                    grcDanhSachSV.DataSource = clsDSXetLenLop.HienThi_ESSDanhSach_SoQD(dv.Table.Rows(grvDanhSachQuyetDinh.GetSelectedRows.GetValue(0)).Item("So_QD")).DefaultView
                Else
                    grcDanhSachSV.DataSource = Nothing
                End If
            Else
                grcDanhSachSV.DataSource = Nothing
            End If

        Catch ex As Exception
        End Try
    End Sub

#End Region



End Class