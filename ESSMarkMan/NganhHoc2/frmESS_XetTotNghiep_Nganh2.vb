Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_XetTotNghiep_Nganh2
    Private mdtDanhSachSinhVien_TN As New DataTable
    Private mdtDanhSachSinhVien_ChuaTN As New DataTable
    Private clsDSXetTN As DanhSachTotNghiep_Bussines
    Private clsCTDT2 As New DanhSachNganh2_Bussines()
    Private mID_dt_TN As Integer = 0
    Private mID_dt_chua_TN As Integer = 0
    Dim flag As Boolean = False

#Region "Form Events"
    Private Sub frmESS_XetTotNghiep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewChuyenNganh_Nganh21.HienThi_ESSTreeView()
        Me.TreeViewChuyenNganh_Nganh22.HienThi_ESSTreeView()

        Add_Namhoc(cmbNam_hoc)
        Add_Namhoc(cmbNam_hoc_CTN)
        flag = True
        SetQuyenTruyCap(, cmdXetTN, cmdLapSB, )
    End Sub
    Private Sub frmESS_XetTotNghiep_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"
    Private Sub TreeViewChuyenNganh_Nganh21_Select() Handles TreeViewChuyenNganh_Nganh21.TreeNodeSelected_
        Try
            If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh > 0 Then
                mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt
                mdtDanhSachSinhVien_TN = clsCTDT2.DanhSachSinhVien_HocNganh2(mID_dt_TN)

                clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, 0, mdtDanhSachSinhVien_TN, 1, mID_dt_TN, True)
                If cmbNam_hoc.Text.Trim <> "" Then
                    Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim).DefaultView
                    grcTotNghiep.DataSource = dv
                    If dv.Count > 0 Then
                        Dim dt As DataTable = dv.Table.Copy
                        Dim clsDM As New DanhMuc_Bussines
                        Dim dt_XepHang As DataTable = clsDM.LoadDanhMuc("SELECT ID_xep_hang,Xep_hang FROM MARK_XepHangTotNghiep_TC")
                        Dim str As String = ""
                        For i As Integer = 0 To dt_XepHang.Rows.Count - 1
                            dt.DefaultView.RowFilter = "ID_xep_loai=" & dt_XepHang.Rows(i)("ID_xep_hang")
                            If dt.DefaultView.Count > 0 Then str = str + "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%"
                        Next
                        lblXet_TN.Text = str
                    End If
                End If
                labSo_sv.Text = grcTotNghiep.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub TreeViewChuyenNganh_Nganh22_Select() Handles TreeViewChuyenNganh_Nganh22.TreeNodeSelected_
        Try
            If TreeViewChuyenNganh_Nganh22.ID_dt > 0 Then
                'Load danh sách sinh viên
                mID_dt_chua_TN = TreeViewChuyenNganh_Nganh21.ID_dt
                mdtDanhSachSinhVien_ChuaTN = clsCTDT2.DanhSachSinhVien_HocNganh2(mID_dt_chua_TN)

                clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, 0, mdtDanhSachSinhVien_ChuaTN, 0, mID_dt_chua_TN, True)
                If cmbNam_hoc.Text.Trim <> "" Then
                    Dim dv As DataView = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                    grcNoTotNghiep.DataSource = dv
                End If
                lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub cmbNam_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNam_hoc.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        If flag Then
            If cmbNam_hoc.Text.Trim <> "" Then
                If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh > 0 Then
                    mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt
                    clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, 0, mdtDanhSachSinhVien_TN, 1, mID_dt_TN, True)
                    Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim).DefaultView
                    grcTotNghiep.DataSource = dv
                    labSo_sv.Text = grcTotNghiep.DataSource.Count
                End If
            End If
        End If
    End Sub

    Private Sub cmbNam_hoc_CTN_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbNam_hoc_CTN.SelectedIndexChanged
        If flag Then
            If cmbNam_hoc_CTN.Text.Trim <> "" Then
                If TreeViewChuyenNganh_Nganh22.ID_chuyen_nganh > 0 Then
                    mID_dt_chua_TN = TreeViewChuyenNganh_Nganh22.ID_dt

                    clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, 0, mdtDanhSachSinhVien_ChuaTN, 0, mID_dt_chua_TN, True)
                    Dim dv As DataView = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                    grcNoTotNghiep.DataSource = dv

                    lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count
                End If
            End If
        End If
    End Sub





    Private Sub cmbLapSo_VB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbNam_hoc.Text.Trim <> "" And (txtTu_so_so_hieu.Text.Trim <> "" AndAlso IsNumeric(txtTu_so_so_hieu.Text.Trim)) Then
                Dim dv As DataView = grcTotNghiep.DataSource
                If dv.Count > 0 Then
                    clsDSXetTN.CapNhat_ESSSoVB_Nganh2(dv, txtTu_so_so_hieu.Text)
                    If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh <= 0 Then
                        Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                        Exit Sub
                    End If
                    mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt

                    clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, 0, mdtDanhSachSinhVien_TN, 1, mID_dt_TN, True)
                    dv = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim).DefaultView
                    grcTotNghiep.DataSource = dv
                End If
            Else
                Thongbao("Hãy chọn năm học và đánh số bắt đầu lập văn bằng dạng số nguyên !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub txtTu_so_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTu_so_so_hieu.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar)
    End Sub
    Private Sub cmdPrint_DS_nototnghiep_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_nototnghiep.ItemClick
        Try
            Dim dv As DataView = grcNoTotNghiep.DataSource
            If dv.Count > 0 Then
                dv.Table.Columns.Add("Tieu_de_ten_bo")
                dv.Table.Columns.Add("Tieu_de_Ten_truong")
                dv.Table.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                Dim Tieu_de As String = "DANH SÁCH SINH VIÊN CHƯA TỐT NGHIỆP NGÀNH HỌC THỨ 2"

                dv.Table.Rows(0).Item("Tieu_de") = Tieu_de

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DS CHUA TOT NGHIEP", dv.Table)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_QD_totnghiep_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_QD_totnghiep.ItemClick
        Try
            If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
            Dim dv As DataView = grvTotNghiep.DataSource
            dv.RowFilter = "Chon='True'"
            Dim rpt As New rptGiayChungNhan_TotNghiep(dv)
            PrintXtraReport(rpt)
            cbChon.Checked = False

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_BD_toankhoa_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_BD_toankhoa.ItemClick
        Try
            Dim objBaocao As New BaoCao
            Dim dv As DataView = grcTotNghiep.DataSource
            If dv.Count > 0 Then

                If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If
                mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt

                Dim clsDiem As Diem_Bussines
                clsDiem = New Diem_Bussines(0, "", 0, mID_dt_TN, mdtDanhSachSinhVien_TN)
                Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(grvTotNghiep.GetFocusedDataRow()("ID_SV"), 0, "")

                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de_chuc_danh3")
                dt.Columns.Add("Tieu_de_chuc_danh4")
                dt.Columns.Add("Tieu_de_nguoi_ky3")
                dt.Columns.Add("Tieu_de_nguoi_ky4")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Ten_he")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Ten_nganh")
                dt.Columns.Add("Chuyen_nganh")
                dt.Columns.Add("Ten_tinh")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Nien_khoa")

                dt.Columns.Add("TBCHT")
                dt.Columns.Add("XEP_LOAI")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")
                 

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                    dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
                    dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
                    dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
                    dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


                    dt.Rows(i).Item("Ma_sv") = grvTotNghiep.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Ho_ten") = grvTotNghiep.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ngay_sinh") = grvTotNghiep.GetFocusedDataRow()("Ngay_sinh").ToString.Trim
                    dt.Rows(i).Item("Ten_he") = grvTotNghiep.GetFocusedDataRow()("Ten_he").ToString
                    dt.Rows(i).Item("Ten_khoa") = grvTotNghiep.GetFocusedDataRow()("Ten_khoa").ToString
                    dt.Rows(i).Item("Khoa_hoc") = grvTotNghiep.GetFocusedDataRow()("Khoa_hoc").ToString
                    dt.Rows(i).Item("Ten_nganh") = grvTotNghiep.GetFocusedDataRow()("Ten_nganh").ToString
                    dt.Rows(i).Item("Chuyen_nganh") = grvTotNghiep.GetFocusedDataRow()("Chuyen_nganh").ToString
                    dt.Rows(i).Item("Ten_tinh") = grvTotNghiep.GetFocusedDataRow()("Ten_tinh").ToString
                    dt.Rows(i).Item("Ten_lop") = grvTotNghiep.GetFocusedDataRow()("Ten_lop").ToString
                    dt.Rows(i).Item("Nien_khoa") = grvTotNghiep.GetFocusedDataRow()("Nien_khoa").ToString

                    dt.Rows(i).Item("TBCHT") = grvTotNghiep.GetFocusedDataRow()("TBCHT").ToString
                    dt.Rows(i).Item("XEP_LOAI") = grvTotNghiep.GetFocusedDataRow()("XEP_hang").ToString
                    'dt.Rows(i).Item("TBC_RL") = TongDiemRL
                    'dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                Next
                Dim dvMain As DataView = dt.DefaultView
                Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
                Dim frm As New rpt_BangDiemTotNghiep(tieu_de, dt)
                frm.SetupDatasource(dvMain)
                PrintXtraReport(frm)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdXetTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXetTN.Click
        If cmbNam_hoc.Text.Trim <> "" And cmbLan_thu.Text.Trim <> "" Then
            If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt

            clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, "0", mdtDanhSachSinhVien_TN, 1, mID_dt_TN, True)
            clsDSXetTN.XetTotNghiep_Nganh2(cmbNam_hoc.Text, cmbLan_thu.Text, gobjUser.ID_Bomon, mID_dt_TN)

            Dim dv As DataView = clsDSXetTN.dtDanhSachTotNghiep(IIf(cmbLan_thu.Text.Trim = "", 0, cmbLan_thu.Text), cmbNam_hoc.Text.Trim).DefaultView
            grcTotNghiep.DataSource = dv
            labSo_sv.Text = grcTotNghiep.DataSource.Count

            clsDSXetTN = New DanhSachTotNghiep_Bussines(gobjUser.ID_dv, "0", mdtDanhSachSinhVien_ChuaTN, 0, mID_dt_chua_TN, True)
            If cmbNam_hoc.Text.Trim <> "" Then
                dv = clsDSXetTN.dtDanhSachChuaTotNghiep(cmbNam_hoc_CTN.Text.Trim).DefaultView
                grcNoTotNghiep.DataSource = dv
            End If
            lblSV_CTN.Text = grcNoTotNghiep.DataSource.Count

            Thongbao("Xét tốt nghiệp thành công !", MsgBoxStyle.Information)
        Else
            Thongbao("Bạn phải chọn Năm học và Lần xét khi xét tốt nghiệp !", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Select Case TabControl1.SelectedIndex.ToString
                Case 0
                    If Not grcTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 1
                    If Not grcNoTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvNoTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub BarButtonItem1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem1.ItemClick
        Try
            Dim objBaocao As New BaoCao
            Dim dv As DataView = grcTotNghiep.DataSource
            If dv.Count > 0 Then

                If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If
                mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt

                Dim clsDiem As Diem_Bussines
                clsDiem = New Diem_Bussines(0, "", 0, mID_dt_TN, mdtDanhSachSinhVien_TN)
                Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(grvTotNghiep.GetFocusedDataRow()("ID_SV"), 0, "")

                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de_chuc_danh3")
                dt.Columns.Add("Tieu_de_chuc_danh4")
                dt.Columns.Add("Tieu_de_nguoi_ky3")
                dt.Columns.Add("Tieu_de_nguoi_ky4")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh")
                dt.Columns.Add("Ten_he")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Ten_nganh")
                dt.Columns.Add("Chuyen_nganh")
                dt.Columns.Add("Ten_tinh")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Nien_khoa")

                dt.Columns.Add("TBCHT")
                dt.Columns.Add("XEP_LOAI")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")


                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                    dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
                    dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
                    dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
                    dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


                    dt.Rows(i).Item("Ma_sv") = grvTotNghiep.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Ho_ten") = grvTotNghiep.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ngay_sinh") = grvTotNghiep.GetFocusedDataRow()("Ngay_sinh").ToString.Trim
                    dt.Rows(i).Item("Ten_he") = grvTotNghiep.GetFocusedDataRow()("Ten_he").ToString
                    dt.Rows(i).Item("Ten_khoa") = grvTotNghiep.GetFocusedDataRow()("Ten_khoa").ToString
                    dt.Rows(i).Item("Khoa_hoc") = grvTotNghiep.GetFocusedDataRow()("Khoa_hoc").ToString
                    dt.Rows(i).Item("Ten_nganh") = grvTotNghiep.GetFocusedDataRow()("Ten_nganh").ToString
                    dt.Rows(i).Item("Chuyen_nganh") = grvTotNghiep.GetFocusedDataRow()("Chuyen_nganh").ToString
                    dt.Rows(i).Item("Ten_tinh") = grvTotNghiep.GetFocusedDataRow()("Ten_tinh").ToString
                    dt.Rows(i).Item("Ten_lop") = grvTotNghiep.GetFocusedDataRow()("Ten_lop").ToString
                    dt.Rows(i).Item("Nien_khoa") = grvTotNghiep.GetFocusedDataRow()("Nien_khoa").ToString

                    dt.Rows(i).Item("TBCHT") = grvTotNghiep.GetFocusedDataRow()("TBCHT").ToString
                    dt.Rows(i).Item("XEP_LOAI") = grvTotNghiep.GetFocusedDataRow()("XEP_hang").ToString
                    'dt.Rows(i).Item("TBC_RL") = TongDiemRL
                    'dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                Next
                Dim dvMain As DataView = dt.DefaultView
                Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
                Dim frm As New rpt_BangDiemTotNghiep_Full(tieu_de, dt)
                frm.SetupDatasource(dvMain)
                PrintXtraReport(frm)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DS_totnghiep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_totnghiep.ItemClick
       
        Try
            Dim dv As DataView = grcTotNghiep.DataSource
            If dv.Count = 0 Then Exit Sub
            dv.Sort = "Ma_sv"
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de1 As String = ""
            Dim Tieu_de2 As String = ""
            Dim Tieu_de3 As String = ""

            Tieu_de1 = "DANH SÁCH TỐT NGHIỆP NGÀNH HỌC THỨ 2"
            If TreeViewChuyenNganh_Nganh21.Khoa_hoc Then
                Tieu_de1 = Tieu_de1 + " KHÓA: " & TreeViewChuyenNganh_Nganh21.Khoa_hoc
            End If
            Tieu_de2 = "(Kèm theo quyết định Công nhận tốt nghiệp số ................."
            Tieu_de3 = "ngày ............... của Hiệu trưởng Trường Cao Đẳng Công Nghiệp Phúc Yêu)"

            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                Dim clsDM As New DanhMuc_Bussines
                Dim dt_XepHang As DataTable = clsDM.LoadDanhMuc("SELECT ID_xep_hang,Xep_hang FROM MARK_XepHangTotNghiep_TC")
                Dim str As String = ""
                For i As Integer = 0 To dt_XepHang.Rows.Count - 1
                    dt.DefaultView.RowFilter = "ID_xep_loai=" & dt_XepHang.Rows(i)("ID_xep_hang")
                    If dt.DefaultView.Count > 0 Then
                        If str.Trim = "" Then
                            str = "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & dt.DefaultView.Count & " sv (" & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%)"
                        Else
                            str = str + vbCrLf & "   -   " & dt_XepHang.Rows(i)("Xep_hang") & " : " & dt.DefaultView.Count & " sv (" & Math.Round(dt.DefaultView.Count * 100 / dv.Count, 2) & "%)"
                        End If
                    End If
                Next
                lblXet_TN.Text = str
                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMark_DanhSachSinhVien_TotNghiep", dv, Tieu_de1, Tieu_de2, Tieu_de3, str)
                frmESS_.ShowDialog()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cbChon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbChon.CheckedChanged
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        For Each dr As DataRowView In dv
            dr("Chon") = cbChon.Checked
        Next
    End Sub

    Private Sub cmdSave_QD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_QD.Click
        Try
            If txtSo_QD.Text.Trim = "" Or dtmNgay_QD.Checked = False Then
                Thongbao("Hãy chọn ngày QĐ và số QĐ !")
                Exit Sub
            End If
            Dim dv As DataView = grvTotNghiep.DataSource
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    dr("So_QD") = txtSo_QD.Text.Trim
                    dr("Ngay_QD") = dtmNgay_QD.Value
                    clsDSXetTN.CapNhat_QuyetDinh_Nganh2(dr("So_QD"), dr("Ngay_QD"), dr("ID_SV"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem3.ItemClick
        Try
            If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            Dim objBaocao As New BaoCao
            Dim dv As DataView = grcTotNghiep.DataSource
            'If dv.Count > 0 Then
            For r As Integer = 0 To dv.Count - 1
                Dim clsDiem As Diem_Bussines
                mID_dt_TN = TreeViewChuyenNganh_Nganh21.ID_dt
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", "0", mID_dt_TN, mdtDanhSachSinhVien_TN)
                If dv.Item(r)("Chon") Then
                    Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa_TotNghiep(dv.Item(r)("ID_SV"), 0, "")

                    dt.Columns.Add("Tieu_de_ten_bo")
                    dt.Columns.Add("Tieu_de_Ten_truong")
                    dt.Columns.Add("Tieu_de_chuc_danh3")
                    dt.Columns.Add("Tieu_de_chuc_danh4")
                    dt.Columns.Add("Tieu_de_nguoi_ky3")
                    dt.Columns.Add("Tieu_de_nguoi_ky4")
                    dt.Columns.Add("Ma_sv")
                    dt.Columns.Add("Ho_ten")
                    dt.Columns.Add("Ngay_sinh")
                    dt.Columns.Add("Ten_he")
                    dt.Columns.Add("Ten_khoa")
                    dt.Columns.Add("Khoa_hoc")
                    dt.Columns.Add("Ten_nganh")
                    dt.Columns.Add("Chuyen_nganh")
                    dt.Columns.Add("Ten_tinh")
                    dt.Columns.Add("Ten_lop")
                    dt.Columns.Add("Nien_khoa")

                    dt.Columns.Add("TBCHT")
                    dt.Columns.Add("XEP_LOAI")
                    dt.Columns.Add("TBC_RL")
                    dt.Columns.Add("Xep_loai_RL")

                    'Dim obj_Bussines As DiemRenLuyen_Bussines
                    'obj_Bussines = New DiemRenLuyen_Bussines(trvLop1.ID_lop_list)
                    'Dim dt_diemRL As DataTable = obj_Bussines.TongHop_DiemRenLuyenKhoa
                    'Dim TongDiemRL As Integer = 0
                    'Dim XepLoai_RL As String = ""
                    'For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    '    If dt_diemRL.Rows(j).Item("ID_SV") = dv.Item(r)("ID_SV") Then
                    '        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                    '        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    '    End If
                    'Next

                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    For i As Integer = 0 To dt.Rows.Count - 1
                        dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                        dt.Rows(i).Item("Tieu_de_chuc_danh3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh3
                        dt.Rows(i).Item("Tieu_de_chuc_danh4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh4
                        dt.Rows(i).Item("Tieu_de_nguoi_ky3") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky3
                        dt.Rows(i).Item("Tieu_de_nguoi_ky4") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky4


                        dt.Rows(i).Item("Ma_sv") = dv.Item(r)("Ma_sv").ToString
                        dt.Rows(i).Item("Ho_ten") = dv.Item(r)("Ho_ten").ToString
                        dt.Rows(i).Item("Ngay_sinh") = dv.Item(r)("Ngay_sinh").ToString.Trim
                        dt.Rows(i).Item("Ten_he") = dv.Item(r)("Ten_he").ToString
                        dt.Rows(i).Item("Ten_khoa") = dv.Item(r)("Ten_khoa").ToString
                        dt.Rows(i).Item("Khoa_hoc") = dv.Item(r)("Khoa_hoc").ToString
                        dt.Rows(i).Item("Ten_nganh") = dv.Item(r)("Ten_nganh").ToString
                        dt.Rows(i).Item("Chuyen_nganh") = dv.Item(r)("Chuyen_nganh").ToString
                        dt.Rows(i).Item("Ten_tinh") = dv.Item(r)("Ten_tinh").ToString
                        dt.Rows(i).Item("Ten_lop") = dv.Item(r)("Ten_lop").ToString
                        dt.Rows(i).Item("Nien_khoa") = dv.Item(r)("Nien_khoa").ToString

                        dt.Rows(i).Item("TBCHT") = dv.Item(r)("TBCHT").ToString
                        dt.Rows(i).Item("XEP_LOAI") = dv.Item(r)("XEP_hang").ToString
                        'dt.Rows(i).Item("TBC_RL") = TongDiemRL
                        'dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    Next
                    Dim dvMain As DataView = dt.DefaultView
                    Dim tieu_de As String = "BẢNG ĐIỂM TOÀN KHÓA"
                    Dim f As New rpt_BangDiemTotNghiep_Full(tieu_de, dt)
                    f.SetupDatasource(dvMain)
                    Hide_PrintXtraReport(f)
                    f.Print()
                End If
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnInBang_TN_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnInBang_TN.ItemClick
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        dv.RowFilter = "Chon='True'"
        If dv.Count = 0 Then Exit Sub
        Dim rpt As New rptBangTotNghiep_All(dv)
        PrintXtraReport(rpt)
    End Sub
 

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        If grvTotNghiep.GetSelectedRows.Length = 0 Then Exit Sub
        Dim dv As DataView = grvTotNghiep.DataSource
        dv.RowFilter = "Chon='True'"
        If dv.Count = 0 Then Exit Sub
        Dim rpt As New rptBangTotNghiep_VIEW(dv)
        PrintXtraReport(rpt)
    End Sub

    Private Sub btnLap_so_vb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLap_so_SoHieu.Click
        Try
            If txtDo_dai_So_hieu.Text = "" Or (txtDo_dai_So_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_hieu.Text.Trim)) Or txtTienTo_SoHieu.Text.Trim = "" Or txtTu_so_so_hieu.Text = "" Or (txtTu_so_so_hieu.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_so_so_hieu.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số hiệu bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_so_so_hieu.Text
            Dim Do_dai As Integer = txtDo_dai_So_hieu.Text.Trim
            Dim dv As DataView = grvTotNghiep.DataSource
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_Bussines()
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_hieu") = txtTienTo_SoHieu.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    clsDSXetTN.CapNhat_SoHieu_Nganh2(dr("So_hieu"), dr("ID_SV"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_SoVaoSo.Click
        Try
            If txtDo_dai_So_van_bang.Text = "" Or (txtDo_dai_So_van_bang.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_van_bang.Text.Trim)) Or txtTien_to_SoVaoSo.Text.Trim = "" Or txtTu_So_SoVaoSo.Text = "" Or (txtTu_So_SoVaoSo.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_So_SoVaoSo.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số vào sổ bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_So_SoVaoSo.Text
            Dim dv As DataView = grvTotNghiep.DataSource
            Dim Do_dai As Integer = txtDo_dai_So_van_bang.Text.Trim
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_Bussines()
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_vao_so") = txtTien_to_SoVaoSo.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    clsDSXetTN.CapNhat_SoVaoSo_Nganh2(dr("So_vao_so"), dr("ID_SV"))
                    'Tu_so = Tu_so + 1
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BarButtonItem4_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Try
            If grcTotNghiep.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grcTotNghiep.DataSource
            Dim tieu_de As String = "DANH SÁCH CẤP PHÁT BẰNG"
            Dim rpt As New rptDanhSachPhatBangTN(dv, tieu_de)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdLapSB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLapSB.Click

    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Try
            Dim dv As DataView = grvTotNghiep.DataSource
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    clsDSXetTN.CapNhat_KHoa_Nganh2(dr("ID_SV"), dr("Lock"))
                End If
            Next
            grcTotNghiep.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub
End Class