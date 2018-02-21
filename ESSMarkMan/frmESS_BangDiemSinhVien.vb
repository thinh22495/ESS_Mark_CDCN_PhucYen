Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESSUtility
Imports ESSReports
Public Class frmESS_BangDiemSinhVien
    Private Loader As Boolean = False
    Private dt_bangdiem As DataTable
    Dim obj_Bussines As DiemRenLuyen_Bussines
    Private ID_dt, ID_sv As Integer
    Private dsID_lop As String = "0"

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            For i As Integer = 0 To gobjUser.LopAaccess.Count - 1
                dsID_lop += "," + gobjUser.LopAaccess.UsersLopAcess(i).ToString
            Next
            Dim clsDanhMuc As New DanhMuc_Bussines
            Dim dt As DataTable = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT a.ID_chuyen_nganh,Chuyen_nganh from  STU_Lop a INNER JOIN STU_ChuyenNganh b ON a.ID_chuyen_nganh=b.ID_chuyen_nganh WHERE ID_LOP IN (" & dsID_lop & ")")
            FillCombo(cmbID_chuyen_nganh, dt, "ID_chuyen_nganh", "Chuyen_nganh")
            dt = clsDanhMuc.LoadDanhMuc("SELECT DISTINCT Khoa_hoc,Khoa_hoc AS KhoaHoc from  STU_Lop  WHERE ID_LOP IN (" & dsID_lop & ") ORDER BY Khoa_hoc")
            FillCombo(cmbKhoa_hoc, dt, "Khoa_hoc", "Khoa_hoc")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadBangDiem(ByVal ID_sv As Integer, ByVal ID_dt As Integer)
        Dim Hoc_ky As Integer = 0
        Dim Nam_hoc As String = ""
        'Load bảng điểm sinh viên
        If cmbID_bangdiem.SelectedIndex = 0 Then
            Hoc_ky = cmbHoc_ky.Text
            Nam_hoc = cmbNam_hoc.Text
        End If
        If cmbID_bangdiem.SelectedIndex = 1 Then Nam_hoc = cmbNam_hoc.Text

        Dim clsDiem As New BangDiemCaNhan_Bussines(gobjUser.ID_dv, ID_sv, ID_dt, Hoc_ky, Nam_hoc)
        Dim dtBangDiem As DataTable = clsDiem.BangDiem()
        lblTBC_tich_luy.Text = Format(clsDiem.TBC_tich_luy, "##.00")
        lblXep_loai_hoc_luc.Text = clsDiem.Xep_hang_hoc_luc
        lblSo_hoc_trinh_tich_luy.Text = clsDiem.So_hoc_trinh_tich_luy
        lblSo_mon_cho_diem.Text = clsDiem.So_mon_cho_diem
        lblSo_mon_hoc_lai.Text = clsDiem.So_mon_hoc_lai
        lblSo_mon_thi_lai.Text = clsDiem.So_mon_thi_lai
        TBCHT4.Text = clsDiem.TBCHT4
        TBCHT10.Text = clsDiem.TBCHT10
        Nam_daotao.Text = clsDiem.Nam_thu
        Xep_loai_tn.Text = clsDiem.Xep_loai_TN
        lblXep_loai_hoc_luc_En.Text = clsDiem.Xep_loai_TN_En
        grcDiem.DataSource = dtBangDiem.DefaultView
    End Sub
#End Region
    Private Sub frmESS_BangDiemChiTietSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadComboBox()
        cmdChuyenNganh.SelectedIndex = 0
        Loader = True
    End Sub
    Private Sub frmESS_BangDiemChiTietSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmbID_lop_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_lop.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_bangdiem.SelectedIndexChanged
        If cmbID_lop.SelectedValue > 0 And Loader Then
            Dim clsDS As New DanhSachSinhVien_Bussines(cmbID_lop.SelectedValue)
            Dim dtSinhVien As DataTable = clsDS.Danh_sach_sinh_vien_bang_diem(cmbID_lop.SelectedValue)
            grcDanhSach.DataSource = dtSinhVien.DefaultView

            obj_Bussines = New DiemRenLuyen_Bussines(cmbID_lop.SelectedValue)
        End If
    End Sub

    Private Sub cmdChuyenNganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChuyenNganh.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_bangdiem.SelectedIndexChanged
        If Loader Then
            Call grvDanhSach_FocusedRowChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub cmbID_chuyen_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged, cmbKhoa_hoc.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_bangdiem.SelectedIndexChanged
        Try
            If Loader Then
                Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
                Dim dtLop As DataTable = clsLop.Danh_sach_lop_dang_hoc()
                Dim dk As String = "1=1"
                If cmbKhoa_hoc.Text.Trim <> "" Then dk += " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
                If cmbID_chuyen_nganh.Text.Trim <> "" Then dk += " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
                dtLop.DefaultView.RowFilter = dk
                FillCombo(cmbID_lop, dtLop.DefaultView.Table, "ID_lop", "Ten_lop")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub



    Private Sub cmbID_bangdiem_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_bangdiem.SelectedIndexChanged
        If cmbID_bangdiem.SelectedIndex = 0 Then
            cmbHoc_ky.Enabled = True
            cmbNam_hoc.Enabled = True

        End If
        If cmbID_bangdiem.SelectedIndex = 1 Then
            cmbHoc_ky.Enabled = False
            cmbNam_hoc.Enabled = True

        End If
        If cmbID_bangdiem.SelectedIndex = 2 Then
            cmbHoc_ky.Enabled = False
            cmbNam_hoc.Enabled = False

        End If
    End Sub

    Private Sub cmdPrintEn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim objBaocao As New BaoCao
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim ReportNam As String = "BangDiem_ToanKhoa_ENG"
                Dim dt_diemRL As DataTable

                If cmbID_bangdiem.SelectedIndex > 1 Then
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKhoa
                End If
                If cmbID_bangdiem.SelectedIndex <= 1 Then
                    Thongbao("Chọn in bảng điểm toàn khoá !", MsgBoxStyle.Information)
                    Exit Sub
                End If

                Dim clsDiem As Diem_Bussines
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, ID_sv, ID_dt)
                Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa(ID_sv, Hoc_ky, Nam_hoc)

                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")

                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_he_En")
                dt.Columns.Add("Ten_khoa_En")
                dt.Columns.Add("Khoa_hoc")
                dt.Columns.Add("Ten_nganh_En")
                dt.Columns.Add("Chuyen_nganh_En")
                dt.Columns.Add("Ten_tinh_En")
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("Nien_khoa")

                dt.Columns.Add("TBCHT10")
                dt.Columns.Add("TBCHT4")
                dt.Columns.Add("TBCHT")
                dt.Columns.Add("XEP_LOAI")
                dt.Columns.Add("XEP_LOAI_TN")
                dt.Columns.Add("XEP_LOAI_TN_En")
                dt.Columns.Add("Nam_daotao")
                dt.Columns.Add("So_TC_Tichluy")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")
                dt.Columns.Add("Hoc_ky_show")
                dt.Columns.Add("Nam_hoc_show")

                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = grvDanhSach.GetFocusedDataRow()("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dt.Rows(i).Item("Tieu_de_ten_bo") = ""
                        dt.Rows(i).Item("Tieu_de_Ten_truong") = ""
                    End If


                    dt.Rows(i).Item("Ma_sv") = grvDanhSach.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Ho_ten") = grvDanhSach.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ngay_sinh") = IIf(grvDanhSach.GetFocusedDataRow()("Ngay_sinh").ToString.Trim <> "", CType(grvDanhSach.GetFocusedDataRow()("Ngay_sinh"), Date), "")
                    dt.Rows(i).Item("Ten_he_En") = grvDanhSach.GetFocusedDataRow()("Ten_he_En").ToString
                    dt.Rows(i).Item("Ten_khoa_En") = grvDanhSach.GetFocusedDataRow()("Ten_khoa_En").ToString
                    dt.Rows(i).Item("Khoa_hoc") = grvDanhSach.GetFocusedDataRow()("Khoa_hoc").ToString
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        dt.Rows(i).Item("Ten_nganh_En") = grvDanhSach.GetFocusedDataRow()("Ten_nganh_En").ToString
                        dt.Rows(i).Item("Chuyen_nganh_En") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh_En").ToString
                    Else
                        dt.Rows(i).Item("Ten_nganh_En") = grvDanhSach.GetFocusedDataRow()("Ten_nganh2_En").ToString
                        dt.Rows(i).Item("Chuyen_nganh_En") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh2_En").ToString
                    End If
                    dt.Rows(i).Item("Ten_tinh_En") = grvDanhSach.GetFocusedDataRow()("Ten_tinh_En").ToString
                    dt.Rows(i).Item("Ten_lop") = grvDanhSach.GetFocusedDataRow()("Ten_lop").ToString
                    dt.Rows(i).Item("Nien_khoa") = grvDanhSach.GetFocusedDataRow()("Nien_khoa").ToString

                    dt.Rows(i).Item("TBCHT10") = TBCHT10.Text
                    dt.Rows(i).Item("TBCHT4") = TBCHT4.Text
                    dt.Rows(i).Item("Nam_daotao") = Nam_daotao.Text
                    dt.Rows(i).Item("So_TC_Tichluy") = lblSo_hoc_trinh_tich_luy.Text
                    dt.Rows(i).Item("TBCHT") = lblTBC_tich_luy.Text
                    dt.Rows(i).Item("XEP_LOAI") = lblXep_loai_hoc_luc.Text
                    dt.Rows(i).Item("TBC_RL") = TongDiemRL
                    dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    dt.Rows(i).Item("Hoc_ky_show") = cmbHoc_ky.Text
                    dt.Rows(i).Item("Nam_hoc_show") = cmbNam_hoc.Text
                    dt.Rows(i).Item("XEP_LOAI_TN") = Xep_loai_tn.Text
                    dt.Rows(i).Item("XEP_LOAI_TN_En") = lblXep_loai_hoc_luc_En.Text
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix(ReportNam, dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdInTatCa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dv As DataView = grvDanhSach.DataSource
            dv.RowFilter = "Chon=1"
            If dv.Count = 0 Then
                Me.Cursor = Cursors.Default
                Thongbao("Bạn phải chọn HSSV trên danh sách !", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim Hoc_ky As Integer = 0
            Dim Nam_hoc As String = ""
            Dim ReportNam As String = "BangDiem_ToanKhoa_TamThoi"
            Dim dt_diemRL As DataTable = Nothing

            If cmbID_bangdiem.SelectedIndex > 1 Then
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKhoa
            End If
            If cmbID_bangdiem.SelectedIndex = 0 Then
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                ReportNam = "BangDiem_Ky"
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
            End If
            If cmbID_bangdiem.SelectedIndex = 1 Then
                ReportNam = "BangDiem_Nam"
                Nam_hoc = cmbNam_hoc.Text
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenNam(Nam_hoc)
            End If
            Dim clsDiem As Diem_Bussines
            Dim frmESS_ As New frmESS_XemBaoCao
            For i As Integer = 0 To dv.Count - 1
                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""
                Dim dt As DataTable = New DataTable

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dv.Item(i)("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                        'clsDiem = New Diem_Bussines(gobjUser.ID_dv, dv.Item(i)("ID_SV"), ID_dt)
                        'dt = clsDiem.BangDiemSinhVienToanKhoa(dv.Item(i)("ID_SV"), Hoc_ky, Nam_hoc)
                        'dt.Columns.Add("Tieu_de_ten_bo")
                        'dt.Columns.Add("Tieu_de_Ten_truong")
                        Exit For
                    End If
                Next

                clsDiem = New Diem_Bussines(gobjUser.ID_dv, dv.Item(i)("ID_SV"), ID_dt)
                dt = clsDiem.BangDiemSinhVienToanKhoa(dv.Item(i)("ID_SV"), Hoc_ky, Nam_hoc)
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de_chuc_danh1")
                dt.Columns.Add("Tieu_de_nguoi_ky1")
                dt.Columns.Add("Tieu_de_chuc_danh2")
                dt.Columns.Add("Tieu_de_nguoi_ky2")
                dt.Columns.Add("Tieu_de_noi_ky")

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

                dt.Columns.Add("TBCHT10")
                dt.Columns.Add("TBCHT4")
                dt.Columns.Add("TBCHT")
                dt.Columns.Add("XEP_LOAI")
                dt.Columns.Add("XEP_LOAI_TN")
                dt.Columns.Add("Nam_daotao")
                dt.Columns.Add("So_TC_Tichluy")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")
                dt.Columns.Add("Hoc_ky_show")
                dt.Columns.Add("Nam_hoc_show")

                For k As Integer = 0 To dt.Rows.Count - 1
                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt.Rows(k).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt.Rows(k).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dt.Rows(k).Item("Tieu_de_ten_bo") = ""
                        dt.Rows(k).Item("Tieu_de_Ten_truong") = ""
                    End If

                    dt.Rows(k).Item("Tieu_de_chuc_danh1") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
                    dt.Rows(k).Item("Tieu_de_nguoi_ky1") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
                    dt.Rows(k).Item("Tieu_de_chuc_danh2") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
                    dt.Rows(k).Item("Tieu_de_nguoi_ky2") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
                    dt.Rows(k).Item("Tieu_de_noi_ky") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky

                    dt.Rows(k).Item("Ma_sv") = dv.Item(i)("Ma_sv").ToString
                    dt.Rows(k).Item("Ho_ten") = dv.Item(i)("Ho_ten").ToString
                    dt.Rows(k).Item("Ngay_sinh") = IIf(dv.Item(i)("Ngay_sinh").ToString.Trim <> "", dv.Item(i)("Ngay_sinh").ToString, "")
                    dt.Rows(k).Item("Ten_he") = dv.Item(i)("Ten_he").ToString
                    dt.Rows(k).Item("Ten_khoa") = dv.Item(i)("Ten_khoa").ToString
                    dt.Rows(k).Item("Khoa_hoc") = dv.Item(i)("Khoa_hoc").ToString
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        dt.Rows(k).Item("Ten_nganh") = dv.Item(i)("Ten_nganh").ToString
                        dt.Rows(k).Item("Chuyen_nganh") = dv.Item(i)("Chuyen_nganh").ToString
                    Else
                        dt.Rows(k).Item("Ten_nganh") = dv.Item(i)("Ten_nganh2").ToString
                        dt.Rows(k).Item("Chuyen_nganh") = dv.Item(i)("Chuyen_nganh2").ToString
                    End If
                    dt.Rows(k).Item("Ten_tinh") = dv.Item(i)("Ten_tinh").ToString
                    dt.Rows(k).Item("Ten_lop") = dv.Item(i)("Ten_lop").ToString
                    dt.Rows(k).Item("Nien_khoa") = dv.Item(i)("Nien_khoa").ToString

                    dt.Rows(k).Item("TBCHT10") = TBCHT10.Text
                    dt.Rows(k).Item("TBCHT4") = TBCHT4.Text
                    dt.Rows(k).Item("Nam_daotao") = Nam_daotao.Text
                    dt.Rows(k).Item("So_TC_Tichluy") = lblSo_hoc_trinh_tich_luy.Text
                    dt.Rows(k).Item("TBCHT") = lblTBC_tich_luy.Text
                    dt.Rows(k).Item("XEP_LOAI") = lblXep_loai_hoc_luc.Text
                    dt.Rows(k).Item("TBC_RL") = TongDiemRL
                    dt.Rows(k).Item("Xep_loai_RL") = XepLoai_RL
                    dt.Rows(k).Item("Hoc_ky_show") = cmbHoc_ky.Text
                    dt.Rows(k).Item("Nam_hoc_show") = cmbNam_hoc.Text
                    dt.Rows(k).Item("XEP_LOAI_TN") = Xep_loai_tn.Text
                Next
                frmESS_.ShowDialog_RFix_Print(ReportNam, dt)
            Next
        Catch ex As Exception
            Thongbao("Lỗi khi in bảng điểm sinh viên, thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try


    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grvDiem.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDevGridViewToExcel(grvDiem)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_KetQuaHT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            Dim objBaocao As New BaoCao
            If grvDanhSach.FocusedRowHandle < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim ReportNam As String = "rpKetQuaHocTap"
                Dim dt_diemRL As DataTable

                If cmbID_bangdiem.SelectedIndex > 1 Then
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKhoa
                End If
                If cmbID_bangdiem.SelectedIndex = 0 Then
                    Hoc_ky = cmbHoc_ky.Text
                    Nam_hoc = cmbNam_hoc.Text
                    ReportNam = "BangDiem_Ky"
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
                End If
                If cmbID_bangdiem.SelectedIndex = 1 Then
                    ReportNam = "BangDiem_Nam"
                    Nam_hoc = cmbNam_hoc.Text
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenNam(Nam_hoc)
                End If

                Dim clsDiem As Diem_Bussines
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, ID_sv, ID_dt)
                Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa(ID_sv, Hoc_ky, Nam_hoc)

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

                dt.Columns.Add("TBCHT10")
                dt.Columns.Add("TBCHT4")
                dt.Columns.Add("TBCHT")
                dt.Columns.Add("XEP_LOAI")
                dt.Columns.Add("XEP_LOAI_TN")
                dt.Columns.Add("Nam_daotao")
                dt.Columns.Add("So_TC_Tichluy")
                dt.Columns.Add("TBC_RL")
                dt.Columns.Add("Xep_loai_RL")
                dt.Columns.Add("Hoc_ky_show")
                dt.Columns.Add("Nam_hoc_show")

                dt.Columns.Add("DTTN1")
                dt.Columns.Add("DTTN2")
                dt.Columns.Add("DTTN3")
                dt.Columns.Add("TBCTTN")
                dt.Columns.Add("TBCTN")


                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = grvDanhSach.GetFocusedDataRow()("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                For i As Integer = 0 To dt.Rows.Count - 1

                    dt.Rows(i).Item("Ma_sv") = grvDanhSach.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Ho_ten") = grvDanhSach.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ngay_sinh") = IIf(grvDanhSach.GetFocusedDataRow()("Ngay_sinh").ToString.Trim <> "", grvDanhSach.GetFocusedDataRow()("Ngay_sinh").ToString, "")
                    dt.Rows(i).Item("Ten_he") = grvDanhSach.GetFocusedDataRow()("Ten_he").ToString
                    dt.Rows(i).Item("Ten_khoa") = grvDanhSach.GetFocusedDataRow()("Ten_khoa").ToString
                    dt.Rows(i).Item("Khoa_hoc") = grvDanhSach.GetFocusedDataRow()("Khoa_hoc").ToString
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        dt.Rows(i).Item("Ten_nganh") = grvDanhSach.GetFocusedDataRow()("Ten_nganh").ToString
                        dt.Rows(i).Item("Chuyen_nganh") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh").ToString
                    Else
                        dt.Rows(i).Item("Ten_nganh") = grvDanhSach.GetFocusedDataRow()("Ten_nganh2").ToString
                        dt.Rows(i).Item("Chuyen_nganh") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh2").ToString
                    End If
                    dt.Rows(i).Item("Ten_tinh") = grvDanhSach.GetFocusedDataRow()("Ten_tinh").ToString
                    dt.Rows(i).Item("Ten_lop") = grvDanhSach.GetFocusedDataRow()("Ten_lop").ToString
                    dt.Rows(i).Item("Nien_khoa") = grvDanhSach.GetFocusedDataRow()("Nien_khoa").ToString

                    dt.Rows(i).Item("TBCHT10") = TBCHT10.Text
                    dt.Rows(i).Item("TBCHT4") = TBCHT4.Text
                    dt.Rows(i).Item("Nam_daotao") = Nam_daotao.Text
                    dt.Rows(i).Item("So_TC_Tichluy") = lblSo_hoc_trinh_tich_luy.Text
                    dt.Rows(i).Item("TBCHT") = lblTBC_tich_luy.Text
                    dt.Rows(i).Item("XEP_LOAI") = lblXep_loai_hoc_luc.Text
                    dt.Rows(i).Item("TBC_RL") = TongDiemRL
                    dt.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    dt.Rows(i).Item("Hoc_ky_show") = cmbHoc_ky.Text
                    dt.Rows(i).Item("Nam_hoc_show") = cmbNam_hoc.Text
                    dt.Rows(i).Item("XEP_LOAI_TN") = Xep_loai_tn.Text

                    dt.Rows(i).Item("DTTN1") = Xep_loai_tn.Text
                    dt.Rows(i).Item("DTTN2") = Xep_loai_tn.Text
                    dt.Rows(i).Item("DTTN3") = Xep_loai_tn.Text
                    dt.Rows(i).Item("TBCTTN") = Xep_loai_tn.Text
                    dt.Rows(i).Item("TBCTN") = Xep_loai_tn.Text
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_New(ReportNam, dt)
            End If
        Catch ex As Exception
            Thongbao("Lỗi khi in bảng điểm sinh viên, thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub cmdPrint_BD_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_BD.ItemClick
        Try
            Dim objBaocao As New BaoCao
            If grvDanhSach.FocusedRowHandle < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim ReportNam As String = "BangDiem_ToanKhoa_TamThoi"
                Dim dt_diemRL As New DataTable

                If cmbID_bangdiem.SelectedIndex > 1 Then
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKhoa
                End If
                If cmbID_bangdiem.SelectedIndex = 0 Then
                    Hoc_ky = cmbHoc_ky.Text
                    Nam_hoc = cmbNam_hoc.Text
                    ReportNam = "BangDiem_Ky"
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
                End If
                If cmbID_bangdiem.SelectedIndex = 1 Then
                    ReportNam = "BangDiem_Nam"
                    Nam_hoc = cmbNam_hoc.Text
                    dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenNam(Nam_hoc)
                End If

                Dim clsDiem As Diem_Bussines
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, ID_sv, ID_dt)
                Dim dt As DataTable = clsDiem.BangDiemSinhVienToanKhoa(ID_sv, Hoc_ky, Nam_hoc)


                Dim dvBD As DataView = dt.DefaultView
                dvBD.Sort = "Nam_hoc,Hoc_ky"
                Dim dtCopy As DataTable = dvBD.ToTable()


                dtCopy.Columns.Add("TT", GetType(Integer))
                dtCopy.Columns.Add("Ma_sv")
                dtCopy.Columns.Add("Ho_ten")
                dtCopy.Columns.Add("Ngay_sinh")
                dtCopy.Columns.Add("Ten_he")
                dtCopy.Columns.Add("Ten_khoa")
                dtCopy.Columns.Add("Khoa_hoc")
                dtCopy.Columns.Add("Ten_nganh")
                dtCopy.Columns.Add("Chuyen_nganh")
                dtCopy.Columns.Add("Ten_tinh")
                dtCopy.Columns.Add("Ten_lop")
                dtCopy.Columns.Add("Nien_khoa")

                dtCopy.Columns.Add("TBCHT10")
                dtCopy.Columns.Add("TBCHT4")
                dtCopy.Columns.Add("TBCHT")
                dtCopy.Columns.Add("XEP_LOAI")
                dtCopy.Columns.Add("XEP_LOAI_TN")
                dtCopy.Columns.Add("Nam_daotao")
                dtCopy.Columns.Add("So_TC_Tichluy")
                dtCopy.Columns.Add("TBC_RL")
                dtCopy.Columns.Add("Xep_loai_RL")
                dtCopy.Columns.Add("Hoc_ky_show")
                dtCopy.Columns.Add("Nam_hoc_show")

                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = grvDanhSach.GetFocusedDataRow()("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                    End If
                Next
                For i As Integer = 0 To dt.Rows.Count - 1
                    dtCopy.Rows(i).Item("TT") = i + 1
                    dtCopy.Rows(i).Item("Ma_sv") = grvDanhSach.GetFocusedDataRow()("Ma_sv").ToString
                    dtCopy.Rows(i).Item("Ho_ten") = grvDanhSach.GetFocusedDataRow()("Ho_ten").ToString
                    dtCopy.Rows(i).Item("Ngay_sinh") = IIf(grvDanhSach.GetFocusedDataRow()("Ngay_sinh").ToString.Trim <> "", FormatDateTime(grvDanhSach.GetFocusedDataRow()("Ngay_sinh").ToString, DateFormat.ShortDate), "")
                    dtCopy.Rows(i).Item("Ten_he") = grvDanhSach.GetFocusedDataRow()("Ten_he").ToString
                    dtCopy.Rows(i).Item("Ten_khoa") = grvDanhSach.GetFocusedDataRow()("Ten_khoa").ToString
                    dtCopy.Rows(i).Item("Khoa_hoc") = grvDanhSach.GetFocusedDataRow()("Khoa_hoc").ToString
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        dtCopy.Rows(i).Item("Ten_nganh") = grvDanhSach.GetFocusedDataRow()("Ten_nganh").ToString
                        dtCopy.Rows(i).Item("Chuyen_nganh") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh").ToString
                    Else
                        dtCopy.Rows(i).Item("Ten_nganh") = grvDanhSach.GetFocusedDataRow()("Ten_nganh2").ToString
                        dtCopy.Rows(i).Item("Chuyen_nganh") = grvDanhSach.GetFocusedDataRow()("Chuyen_nganh2").ToString
                    End If
                    dtCopy.Rows(i).Item("Ten_tinh") = grvDanhSach.GetFocusedDataRow()("Ten_tinh").ToString
                    dtCopy.Rows(i).Item("Ten_lop") = grvDanhSach.GetFocusedDataRow()("Ten_lop").ToString
                    dtCopy.Rows(i).Item("Nien_khoa") = grvDanhSach.GetFocusedDataRow()("Nien_khoa").ToString

                    dtCopy.Rows(i).Item("TBCHT10") = TBCHT10.Text
                    dtCopy.Rows(i).Item("TBCHT4") = TBCHT4.Text
                    dtCopy.Rows(i).Item("Nam_daotao") = Nam_daotao.Text
                    dtCopy.Rows(i).Item("So_TC_Tichluy") = lblSo_hoc_trinh_tich_luy.Text
                    dtCopy.Rows(i).Item("TBCHT") = lblTBC_tich_luy.Text
                    dtCopy.Rows(i).Item("XEP_LOAI") = lblXep_loai_hoc_luc.Text
                    dtCopy.Rows(i).Item("TBC_RL") = TongDiemRL
                    dtCopy.Rows(i).Item("Xep_loai_RL") = XepLoai_RL
                    dtCopy.Rows(i).Item("Hoc_ky_show") = cmbHoc_ky.Text
                    dtCopy.Rows(i).Item("Nam_hoc_show") = cmbNam_hoc.Text
                    dtCopy.Rows(i).Item("XEP_LOAI_TN") = Xep_loai_tn.Text
                Next

                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemSinhVien", dtCopy.DefaultView)
                frmESS_.ShowDialog()
            End If
        Catch ex As Exception
            Thongbao("Lỗi khi in bảng điểm sinh viên, thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdPrint_DBC_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DBC.ItemClick
        Try
            Me.Cursor = Cursors.WaitCursor
            If grvDanhSach.FocusedRowHandle < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSach.DataSource
            dv.RowFilter = "Chon=1"
            If dv.Count = 0 Then
                Me.Cursor = Cursors.Default
                Thongbao("Bạn phải chọn HSSV trên danh sách !", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim Hoc_ky As Integer = 0
            Dim Nam_hoc As String = ""
            Dim ReportNam As String = "BangDiem_ToanKhoa_TamThoi"
            Dim dt_diemRL As DataTable = Nothing

            If cmbID_bangdiem.SelectedIndex > 1 Then
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKhoa
            End If
            If cmbID_bangdiem.SelectedIndex = 0 Then
                Hoc_ky = cmbHoc_ky.Text
                Nam_hoc = cmbNam_hoc.Text
                ReportNam = "BangDiem_Ky"
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenKy(Hoc_ky, Nam_hoc)
            End If
            If cmbID_bangdiem.SelectedIndex = 1 Then
                ReportNam = "BangDiem_Nam"
                Nam_hoc = cmbNam_hoc.Text
                dt_diemRL = obj_Bussines.TongHop_DiemRenLuyenNam(Nam_hoc)
            End If
            Dim clsDiem As Diem_Bussines
            'Dim frmESS_ As New frmESS_XemBaoCao
            For i As Integer = 0 To dv.Count - 1
                Dim TongDiemRL As Integer = 0
                Dim XepLoai_RL As String = ""
                Dim dt As DataTable = New DataTable

                For j As Integer = 0 To dt_diemRL.Rows.Count - 1
                    If dt_diemRL.Rows(j).Item("ID_SV") = dv.Item(i)("ID_SV") Then
                        TongDiemRL = dt_diemRL.Rows(j).Item("Tong_diem")
                        XepLoai_RL = dt_diemRL.Rows(j).Item("Xep_loai")
                        Exit For
                    End If
                Next

                clsDiem = New Diem_Bussines(gobjUser.ID_dv, dv.Item(i)("ID_SV"), ID_dt)
                dt = clsDiem.BangDiemSinhVienToanKhoa(dv.Item(i)("ID_SV"), Hoc_ky, Nam_hoc)

                Dim dvBD As DataView = dt.DefaultView
                dvBD.Sort = "Nam_hoc,Hoc_ky"
                Dim dtCopy As DataTable = dvBD.ToTable()

                dtCopy.Columns.Add("TT", GetType(Integer))
                dtCopy.Columns.Add("Ma_sv")
                dtCopy.Columns.Add("Ho_ten")
                dtCopy.Columns.Add("Ngay_sinh")
                dtCopy.Columns.Add("Ten_he")
                dtCopy.Columns.Add("Ten_khoa")
                dtCopy.Columns.Add("Khoa_hoc")
                dtCopy.Columns.Add("Ten_nganh")
                dtCopy.Columns.Add("Chuyen_nganh")
                dtCopy.Columns.Add("Ten_tinh")
                dtCopy.Columns.Add("Ten_lop")
                dtCopy.Columns.Add("Nien_khoa")

                dtCopy.Columns.Add("TBCHT10")
                dtCopy.Columns.Add("TBCHT4")
                dtCopy.Columns.Add("TBCHT")
                dtCopy.Columns.Add("XEP_LOAI")
                dtCopy.Columns.Add("XEP_LOAI_TN")
                dtCopy.Columns.Add("Nam_daotao")
                dtCopy.Columns.Add("So_TC_Tichluy")
                dtCopy.Columns.Add("TBC_RL")
                dtCopy.Columns.Add("Xep_loai_RL")
                dtCopy.Columns.Add("Hoc_ky_show")
                dtCopy.Columns.Add("Nam_hoc_show")

                For k As Integer = 0 To dtCopy.Rows.Count - 1

                    dtCopy.Rows(k).Item("TT") = i + 1
                    dtCopy.Rows(k).Item("Ma_sv") = dv.Item(i)("Ma_sv").ToString
                    dtCopy.Rows(k).Item("Ho_ten") = dv.Item(i)("Ho_ten").ToString
                    dtCopy.Rows(k).Item("Ngay_sinh") = IIf(dv.Item(i)("Ngay_sinh").ToString.Trim <> "", dv.Item(i)("Ngay_sinh").ToString, "")
                    dtCopy.Rows(k).Item("Ten_he") = dv.Item(i)("Ten_he").ToString
                    dtCopy.Rows(k).Item("Ten_khoa") = dv.Item(i)("Ten_khoa").ToString
                    dtCopy.Rows(k).Item("Khoa_hoc") = dv.Item(i)("Khoa_hoc").ToString
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        dtCopy.Rows(k).Item("Ten_nganh") = dv.Item(i)("Ten_nganh").ToString
                        dtCopy.Rows(k).Item("Chuyen_nganh") = dv.Item(i)("Chuyen_nganh").ToString
                    Else
                        dtCopy.Rows(k).Item("Ten_nganh") = dv.Item(i)("Ten_nganh2").ToString
                        dtCopy.Rows(k).Item("Chuyen_nganh") = dv.Item(i)("Chuyen_nganh2").ToString
                    End If
                    dtCopy.Rows(k).Item("Ten_tinh") = dv.Item(i)("Ten_tinh").ToString
                    dtCopy.Rows(k).Item("Ten_lop") = dv.Item(i)("Ten_lop").ToString
                    dtCopy.Rows(k).Item("Nien_khoa") = dv.Item(i)("Nien_khoa").ToString

                    dtCopy.Rows(k).Item("TBCHT10") = TBCHT10.Text
                    dtCopy.Rows(k).Item("TBCHT4") = TBCHT4.Text
                    dtCopy.Rows(k).Item("Nam_daotao") = Nam_daotao.Text
                    dtCopy.Rows(k).Item("So_TC_Tichluy") = lblSo_hoc_trinh_tich_luy.Text
                    dtCopy.Rows(k).Item("TBCHT") = lblTBC_tich_luy.Text
                    dtCopy.Rows(k).Item("XEP_LOAI") = lblXep_loai_hoc_luc.Text
                    dtCopy.Rows(k).Item("TBC_RL") = TongDiemRL
                    dtCopy.Rows(k).Item("Xep_loai_RL") = XepLoai_RL
                    dtCopy.Rows(k).Item("Hoc_ky_show") = cmbHoc_ky.Text
                    dtCopy.Rows(k).Item("Nam_hoc_show") = cmbNam_hoc.Text
                    dtCopy.Rows(k).Item("XEP_LOAI_TN") = Xep_loai_tn.Text
                Next
                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemSinhVien", dtCopy.DefaultView)
                frmESS_.ShowDialog(True)

                'frmESS_.ShowDialog_PrintAll(ReportNam, dtCopy)
            Next
        Catch ex As Exception
            Thongbao("Lỗi khi in bảng điểm sinh viên, thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            Me.Cursor = Cursors.Default
        End Try

    End Sub

    Private Sub grvDanhSach_FocusedRowChanged(ByVal sender As System.Object, ByVal e As DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs) Handles grvDanhSach.FocusedRowChanged
        Try
            If Loader Then
                If grvDanhSach.DataSource Is Nothing Then Exit Sub
                Dim dv As DataView = grvDanhSach.DataSource
                If grvDanhSach.FocusedRowHandle >= 0 Then
                    Dim row As DataRow = grvDanhSach.GetFocusedDataRow()
                    'ID_sv = dv.Item(grvDanhSach.FocusedRowHandle).Item("ID_sv")
                    ID_sv = row("ID_sv")
                    If cmdChuyenNganh.SelectedIndex = 0 Then
                        'ID_dt = dv.Item(grvDanhSach.FocusedRowHandle).Item("ID_dt").ToString
                        ID_dt = row("ID_dt").ToString
                    Else
                        'ID_dt = IIf(dv.Item(grvDanhSach.FocusedRowHandle).Item("ID_dt2").ToString = "", 1, dv.Item(grvDanhSach.FocusedRowHandle).Item("ID_dt2").ToString)
                        ID_dt = IIf(row("ID_dt2").ToString = "", 1, row("ID_dt2").ToString)
                    End If
                    LoadBangDiem(ID_sv, ID_dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub
End Class