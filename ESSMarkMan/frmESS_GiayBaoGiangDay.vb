Imports C1.Win.C1FlexGrid
Imports ESSUtility
Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Public Class frmESS_GiayBaoGiangDay
#Region "variable"
    Private mKy_dang_ky As Integer = 0
    Private rowHeight As Integer = 20, colWidth As Integer = 23
    Private src As New my_Cell
    Private us4 As Scheduling_Bussines
    Private Loader As Boolean = False
#End Region

#Region "Form Events"
    Private Sub frmESS_GiayBaoGiangDay_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_GiayBaoGiangDay_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            fonction.Flexgrid_setup(fg)
            fonction.Format_fix_region(fg)

            'Không cho phép thực hiện các chức năng khi chưa mở TKB
            SetControlForm(False)

            'Doc_tham_so_he_thong()

            LoadComboBox()
            Loader = True
            'Set quyền truy cập chức năng
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_GiayBaoGiangDay_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_GiayBaoGiangDay_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If Not us4 Is Nothing AndAlso us4.TKB_change Then
            If Thongbao("Bạn có lưu lại thời khoá biểu của tuần này không?", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If us4 Is Nothing Then Return
                us4.SaveDB()
                Thongbao("Ghi thành công !!!")
            End If
        End If
    End Sub
#End Region

#Region "ComboBox Events"
    Private Sub Fillter_Lop(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged, cmbID_khoa.SelectedIndexChanged, cmbID_BM.SelectedIndexChanged
        If Loader Then
            Dim dvLop As DataView = Me.fg.DataSource
            If Not dvLop Is Nothing Then
                Dim strFillter As String = "1=1"
                If cmbID_he.SelectedValue > 0 Then strFillter += " AND ID_he=" + cmbID_he.SelectedValue.ToString
                If cmbID_khoa.SelectedValue > 0 Then strFillter += " AND ID_khoa=" + cmbID_khoa.SelectedValue.ToString
                If cmbID_BM.SelectedValue > 0 Then strFillter += " AND ID_bm=" + cmbID_BM.SelectedValue.ToString
                dvLop.RowFilter = strFillter
                show_lop(dvLop.Table, us4.Tu_ngay, us4.Den_ngay)
            End If
        End If
    End Sub
#End Region

#Region "ToolBar, Tab Events"
    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        Try
            Dim frm As New frmESS_MoHocKyDangKy
            frm.ShowDialog()
            If frm.Tag = "1" Then
                mKy_dang_ky = frm.Ky_dang_ky
                Reload()
                SetControlForm(True)
                cmbID_he.SelectedValue = frm.ID_he
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If us4 Is Nothing Then Return
            us4.SaveDB()
            Thongbao("Đã ghi thành công !!!")
            us4 = New Scheduling_Bussines(mKy_dang_ky)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If us4 Is Nothing Then Return
            If Thongbao("Chắc chắn bạn muốn xoá TKB của tuần này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                us4.DeleteDB()
                Thongbao("Đã xoá thành công !!!")
                Reload()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            If Not fg.DataSource Is Nothing Then
                Dim dv As DataView = Me.fg.DataSource
                If dv.Count > 0 Then
                    Dim dt As New DataTable
                    Dim dr As DataRow

                    dt.Columns.Add("Hoc_ky")
                    dt.Columns.Add("Nam_hoc")
                    dt.Columns.Add("TuDen_Ngay")
                    dt.Columns.Add("Ten_mon")
                    dt.Columns.Add("Ten_lop_tc")
                    dt.Columns.Add("So_hoc_trinh")
                    dt.Columns.Add("Giao_vien")
                    dt.Columns.Add("Phong_hoc")
                    dt.Columns.Add("Thoi_gian")

                    dt.Columns.Add("Tieu_de_ten_bo")
                    dt.Columns.Add("Tieu_de_Ten_truong")
                    dt.Columns.Add("Ten_he")
                    dt.Columns.Add("Thong_bao")
                    Dim Ten_he As String = ""
                    If cmbID_he.Text.Trim <> "" Then Ten_he = cmbID_he.Text
                    If cmbID_khoa.Text.Trim <> "" Then Ten_he += " - Khoa " & cmbID_khoa.Text
                    If cmbID_BM.Text.Trim <> "" Then Ten_he += " - Bộ môn " & cmbID_BM.Text
                    Dim Thong_bao As String = ""
                    Dim clsKhk As New KeHoachKhac_Bussines
                    Thong_bao = clsKhk.ThongBaoKeHoachKhac(us4.Hoc_ky, us4.Nam_hoc, cmbID_he.SelectedValue)


                    For i As Integer = 0 To dv.Count - 1
                        dr = dt.NewRow

                        dr("Hoc_ky") = us4.Hoc_ky
                        dr("Nam_hoc") = us4.Nam_hoc
                        dr("TuDen_Ngay") = CDate(dv.Item(i)("Tu_Ngay")).Date & " - " & CDate(dv.Item(i)("Den_Ngay")).Date
                        dr("Ten_mon") = dv.Item(i)("Ten_mon")
                        dr("Ten_lop_tc") = dv.Item(i)("Ten_lop_tc")
                        dr("So_hoc_trinh") = dv.Item(i)("So_hoc_trinh")
                        dr("Giao_vien") = dv.Item(i)("Giao_vien")
                        dr("Phong_hoc") = dv.Item(i)("Phong_hoc")
                        dr("Thoi_gian") = dv.Item(i)("Thoi_gian")

                        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                        If objBaoCaoTieuDe.Count > 0 Then
                            dr("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                            dr("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                        Else
                            dr("Tieu_de_ten_bo") = ""
                            dr("Tieu_de_Ten_truong") = ""
                        End If

                        dr("Ten_he") = Ten_he.Trim
                        dr("Thong_bao") = Thong_bao

                        dt.Rows.Add(dr)
                    Next

                    'Hien thi bao cao
                    Dim frm As New frmESS_XemBaoCao
                    frm.ShowDialog_RFix("PLAN__TRUONG_LOP", dt)
                Else
                    Thongbao("Không có dữ liệu !")
                End If
            Else
                Thongbao("Bạn chọn lớp, giáo viên, phòng học để in  !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExportExcel.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Call Excel_Export()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

#Region "Flexgrid Events"
    Private Sub fg_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            'If rptType = REPORT_TYPE.THEO_SUKIEN And fgSuKien.RowSel >= 0 Then
            '    Dim frm As New frmSuKienThayDoi(us4)
            '    Dim idx_sk As Integer = fgSuKien(fgSuKien.RowSel, "STT")
            '    frm.Data_phong = us4.Danhsach_phong()
            '    frm.Data_giaovien = us4.Danhsach_giaovien
            '    frm.idx_sk = idx_sk
            '    frm.ShowDialog()
            '    If frm.OK_click Then
            '        us4.Set_sukien(idx_sk, frm.cboGiao_vien.SelectedValue, frm.cboGiao_vien.Text, frm.cboPhong_hoc.SelectedValue, frm.cboPhong_hoc.Text, frm.cboCa_hoc.SelectedIndex)
            '        Thongbao("Đã thay đổi xong thông tin về sự kiện này !")
            '    End If
            '    show_sukien(fgSuKien, us4.List_su_kien())
            'End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

#Region "Setting up"
    Private Sub Set_WidHei(ByVal fg As C1FlexGrid)
        Try
            Dim wid As Integer = CInt(txtWid.Text)
            Dim hei As Integer = CInt(txtHei.Text)

            For i As Integer = fg.Rows.Fixed To fg.Rows.Count - 1
                fg.Rows(i).Height = hei
            Next
            For i As Integer = fg.Cols.Fixed To fg.Cols.Count - 1
                fg.Cols(i).Width = wid
            Next
            fg.Cols(0).Width = 70
        Catch ex As Exception
        End Try
    End Sub
    Private Sub Set_Style(ByVal fg As C1FlexGrid)
        Try
            For i As Integer = fg.Rows.Fixed To fg.Rows.Count - 1
                For j As Integer = fg.Cols.Fixed To fg.Cols.Count - 1
                    If fg(i, j).ToString = "H" Then 'Normal_Style
                        fg.SetCellStyle(i, j, fg.Styles("Hoc_Style"))
                    End If
                Next
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Allow_merge(ByVal fg As C1FlexGrid)
        fg.Rows(0).AllowMerging = True
        fg.Rows(1).AllowMerging = True
        fg.Cols(0).AllowMerging = True
        fg.Cols(1).AllowMerging = True
        fg.Rows(0).TextAlign = TextAlignEnum.CenterCenter
        fg.Rows(1).TextAlign = TextAlignEnum.CenterCenter
        fg.Rows(2).TextAlign = TextAlignEnum.CenterCenter
        fg.Cols(0).TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Sub SetControlForm(ByVal flag As Boolean)
        Me.cmdExportExcel.Enabled = flag
        Me.cmdPrint.Enabled = flag
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1FlexGrid)
        For i As Integer = 0 To fg.Rows.Fixed - 1
            For j As Integer = 0 To fg.Cols.Count - 1
                fg.SetCellStyle(i, j, fg.Styles("Fixed_Style"))
            Next
        Next
        For i As Integer = 0 To fg.Rows.Count - 1
            For j As Integer = 0 To fg.Cols.Fixed - 1
                fg.SetCellStyle(i, j, fg.Styles("Fixed_Style"))
            Next
        Next
    End Sub
#End Region

#Region "Method"
    Private Sub LoadComboBox()
        Try
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, 1, -1)
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)

            ''Load combobox khóa học
            'dt = clsLop.Khoa_hoc()
            'FillCombo(cmbKhoa_hoc, dt)

            'Load combobox khoa đào tạo
            dt = clsLop.Khoa()
            FillCombo(cmbID_khoa, dt)

            'Load combobox bo mon
            dt = clsDM.DanhMuc_Load("PLAN_BoMon", "ID_bm", "Bo_mon")
            FillCombo(cmbID_BM, dt)

            'Load combobox khoa đào tạo
            'dt = clsLop.Khoa_hoc()
            'FillCombo(cmbKhoa_hoc, dt)

            ''Load combobox ngành đào tạo
            'dt = clsLop.Nganh_dao_tao()
            'FillCombo(cmbID_BM, dt)

            ''Load combobox chuyên ngành đào tạo
            'dt = clsLop.Chuyen_nganh_dao_tao()
            'FillCombo(cmbID_chuyen_nganh, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Excel_Export()
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fg.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromC1flexgridToExcel(fg)
            Else
                Thongbao("Bạn phải mở kế hoạch trước khi xuất ra Excel")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Set_Cell(ByVal fg As C1FlexGrid, ByVal row As Integer, ByVal col As Integer, ByVal loai As Integer)
        Select Case loai
            Case 0 ' Blank
                fg.SetCellStyle(row, col, fg.Styles("Normal_Style"))
            Case 1 ' Have value 
                fg.SetCellStyle(row, col, fg.Styles("LyThuyet_Style"))
            Case 2 ' Select
                fg.SetCellStyle(row, col, fg.Styles("Chon_Style"))
        End Select
    End Sub
    Private Sub Reload()
        Try
            us4 = New Scheduling_Bussines(mKy_dang_ky)
            show_lop(us4.Baocao_TKB_Lop(), us4.Tu_ngay, us4.Den_ngay)
            'Lọc lớp tín chỉ
            Fillter_Lop(Nothing, Nothing)
            Set_Style(fg)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Private Sub Tudong()
    '    Try
    '        If us4 Is Nothing Then Return
    '        'Dim frm As New frmThoiKhoaBieuXepTuDong
    '        'frm.ShowDialog()
    '        If frm.Save = True Then
    '            Me.Cursor = Cursors.WaitCursor
    '            Dim lop As New ArrayList
    '            Dim dvLop As DataView = fg.DataSource
    '            For i As Integer = 0 To dvLop.Count - 1
    '                lop.Add(dvLop.Item(i)("idx_lop"))
    '            Next
    '            'Xác định thứ và lớp xếp TKB
    '            us4.Thu_xep_TKB = frm.Thu_xep_TKB
    '            us4.Lop_xep_TKB = lop
    '            'Sắp xếp giờ lý thuyết
    '            us4.Xep_tu_dong_ly_thuyet()
    '            'Sắp xếp giờ thực hành
    '            us4.Xep_tu_dong_thuc_hanh()
    '            'Những sự kiện không xếp được sẽ tìm gv, phòng học khác
    '            'us4.Xep_tu_dong3()
    '            show_lop(us4.Baocao_TKB_Lop(), us4.Tu_ngay, us4.Den_ngay)
    '            'Lọc lớp tín chỉ
    '            Fillter_Lop(Nothing, Nothing)
    '            Set_Style(fg)
    '            Me.Cursor = Cursors.Default
    '            Thongbao("Số lượng sự kiện chưa thể xếp lịch là : " _
    '                        + us4.So_su_kien_chua_xep_lich.ToString())
    '        End If
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Sub
    Private Sub show_lop(ByVal dt As DataTable, ByVal Tu_ngay As Date, ByVal Den_ngay As Date)
        Try
            Dim Ngay_dau, Ngay_cuoi As Date
            Dim Tuan_thu, Tuan As Integer
            fg.DataSource = dt.DefaultView
            fg.AllowMerging = AllowMergingEnum.FixedOnly
            fg.Rows.Fixed = 4
            'Set rows width 
            fg.Rows(0).Height = 0
            fg.Rows(1).Height = 20
            fg.Rows(2).Height = 20
            fg.Rows(3).Height = 35
            fg.Rows(1).AllowMerging = True
            fg.Rows(2).AllowMerging = True
            fg.Cols.Fixed = 1
            fg.AllowResizing = AllowResizingEnum.Columns
            'Set cols width
            fg.Cols(0).Width = 30
            fg.Cols(1).Width = 0
            fg.Cols(2).Width = 0
            fg.Cols(3).Width = 0
            fg.Cols(4).Width = 0
            fg.Cols(5).Width = 0
            fg.Cols(6).Width = 0
            fg.Cols(7).Width = 0
            fg.Cols(8).Width = 0
            fg.Cols(9).Width = 0
            fg.Cols(10).Width = 0
            fg.Cols("Ky_hieu").Width = 60
            fg.Cols("Ky_hieu").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Ten_mon").Width = 180
            fg.Cols("So_hoc_trinh").Width = 30
            fg.Cols("So_hoc_trinh").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Ly_thuyet").Width = 40
            fg.Cols("Ly_thuyet").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Thuc_hanh").Width = 40
            fg.Cols("Thuc_hanh").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Ten_lop_tc").Width = 100
            fg.Cols("So_sv_min").Width = 40
            fg.Cols("So_sv_min").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("So_sv_max").Width = 40
            fg.Cols("So_sv_max").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("So_tiet_tuan").Width = 40
            fg.Cols("So_tiet_tuan").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Ca_hoc").Width = 40
            fg.Cols("Ca_hoc").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Giao_vien").Width = 80
            fg.Cols("Phong_hoc").Width = 60
            fg.Cols("Phong_hoc").TextAlign = TextAlignEnum.CenterCenter
            fg.Cols("Thoi_gian").Width = 90
            fg.Cols("Thoi_gian").TextAlign = TextAlignEnum.CenterCenter
            For i As Integer = 0 To 23
                fg.Cols(i).AllowMerging = True
            Next
            'Set Caption
            Dim rg As CellRange = fg.GetCellRange(1, 0, 3, 0)
            rg.Data = "STT"
            Dim rg0 As CellRange = fg.GetCellRange(1, 11, 3, 11)
            rg0.Data = "Mã học phần"
            rg0.StyleDisplay.WordWrap = True
            Dim rg1 As CellRange = fg.GetCellRange(1, 12, 3, 12)
            rg1.Data = "Tên học phần"
            Dim rg2 As CellRange = fg.GetCellRange(1, 13, 3, 13)
            rg2.Data = "Số tín chỉ"
            rg2.StyleDisplay.WordWrap = True
            Dim rg3 As CellRange = fg.GetCellRange(1, 14, 3, 14)
            rg3.Data = "Lý thuyết"
            Dim rg4 As CellRange = fg.GetCellRange(1, 15, 3, 15)
            rg4.Data = "Thực hành"
            Dim rg5 As CellRange = fg.GetCellRange(1, 16, 3, 16)
            rg5.Data = "Tên lớp tín chỉ"
            Dim rg6 As CellRange = fg.GetCellRange(1, 17, 3, 17)
            rg6.Data = "Số sv tối thiểu"
            Dim rg7 As CellRange = fg.GetCellRange(1, 18, 3, 18)
            rg7.Data = "Số sv tối đa"
            Dim rg8 As CellRange = fg.GetCellRange(1, 19, 3, 19)
            rg8.Data = "Số tiết / tuần"
            Dim rg9 As CellRange = fg.GetCellRange(1, 20, 3, 20)
            rg9.Data = "Ca học"
            Dim rg10 As CellRange = fg.GetCellRange(1, 21, 3, 21)
            rg10.Data = "Giáo viên"
            Dim rg11 As CellRange = fg.GetCellRange(1, 22, 3, 22)
            rg11.Data = "Phòng học"
            Dim rg12 As CellRange = fg.GetCellRange(1, 23, 3, 23)
            rg12.Data = "Thời gian"
            Tuan = 1
            Tuan_thu = DatePart(DateInterval.WeekOfYear, Tu_ngay)
            Ngay_dau = Tu_ngay
            Ngay_cuoi = Ngay_dau.AddDays(1)
            Do While Ngay_cuoi <= Den_ngay
                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                    'Gán dữ liệu vào tiêu đề fg
                    fg(1, "T" + Tuan_thu.ToString) = "Tháng " & Ngay_dau.Month 'Tháng
                    fg(2, "T" + Tuan_thu.ToString) = Tuan
                    fg(3, "T" + Tuan_thu.ToString) = Ngay_dau.Day.ToString.PadLeft(2, "0") + " " + Ngay_cuoi.Day.ToString.PadLeft(2, "0")
                    fg.Cols("T" + Tuan_thu.ToString).Width = colWidth
                    fg.Cols("T" + Tuan_thu.ToString).TextAlign = TextAlignEnum.CenterCenter

                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Ngay_dau = Ngay_cuoi
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                    Tuan = Tuan + 1
                End If
                Ngay_cuoi = Ngay_cuoi.AddDays(1)
            Loop
            'STT
            Dim STT As Integer = 1
            For i As Integer = fg.Rows.Fixed To fg.Rows.Count - 1
                fg(i, 0) = STT
                STT += 1
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    'Private Function Lich_lop() As Boolean
    '    If us4 Is Nothing Then Return False
    '    Try
    '        Dim ID_mon_tc As Integer = fg(fg.RowSel, "ID_mon_tc")
    '        Dim frm As New frmThoiKhoaBieuXepThuCong(Me.us4, ID_mon_tc)
    '        frm.ShowDialog()
    '        Return frm.Changed
    '    Catch ex As Exception
    '        Throw ex
    '    End Try
    'End Function
    Private Sub Huy_lich()
        If us4 Is Nothing Then Return
        Try
            us4.Huy_lich()
            'show_sukien(fgSuKien, us4.List_su_kien())
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
#End Region
End Class