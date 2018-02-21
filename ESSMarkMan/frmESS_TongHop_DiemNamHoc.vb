Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid

Public Class frmESS_TongHop_DiemNamHoc
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub FormatFlexGrid(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Cols.Fixed = 1
        fg.Rows.Fixed = 2
        fg.Rows.DefaultSize = 20

        fg.Rows(0).Height = 40
        fg.Cols(0).Width = 20

        Format_fix_region(fg)
        Allow_merge(fg)
        'Ẩn tất cả các cột
        Dim dt As DataTable = fg.DataSource
        For i As Integer = 0 To dt.Columns.Count - 1
            fg.Cols(dt.Columns(i).ColumnName.ToString).Visible = False
        Next
        'Các cột hiển thị cố định
        fg.Cols("Ma_sv").Visible = True
        fg.Cols("Ma_sv").Caption = "Mã sinh viên"
        fg.Cols("Ma_sv").Width = 80
        fg.Cols("Ma_sv").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ho_ten").Visible = True
        fg.Cols("Ho_ten").Caption = "Họ và tên"
        fg.Cols("Ho_ten").Width = 160

        fg.Cols("Ten_lop").Visible = True
        fg.Cols("Ten_lop").Caption = "Tên lớp"
        fg.Cols("Ten_lop").TextAlign = TextAlignEnum.CenterCenter
        fg.Cols("Ten_lop").Width = 70

        fg.Cols("TBCHT10").Visible = True
        fg.Cols("TBCHT10").Caption = "TBCHT thang điểm 10"
        fg.Cols("TBCHT10").Width = 80
        fg.Cols("TBCHT10").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHT"
        fg.Cols("TBCHT").Width = 40
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai").Visible = True
        fg.Cols("Xep_loai").Caption = "Xếp loại"
        fg.Cols("Xep_loai").Width = 80


        fg.Cols("TC_TichLuy_Nam").Visible = True
        fg.Cols("TC_TichLuy_Nam").Caption = "Số TC năm"
        fg.Cols("TC_TichLuy_Nam").Width = 80
        fg.Cols("TC_TichLuy_Nam").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Caption = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        'Format các cột Học phần biến động theo số Học phần
        For i As Integer = 0 To clsDiem.ESSMonHoc.Count - 1
            With clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
                If clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i).Khong_tinh_TBCHT = False Then
                    'Hiển thị cột điểm
                    fg.Cols("M" + .ID_mon.ToString).Visible = True
                    'Gán tiêu đề cột điểm
                    If chkMonhoc.Checked Then
                        fg(0, "M" + .ID_mon.ToString) = .Ten_mon
                        fg.Cols("M" + .ID_mon.ToString).Width = 30
                        fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                    Else
                        fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                        fg.Cols("M" + .ID_mon.ToString).Width = 30
                        fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                    End If
                    'Không cho Merging số học trình
                    If i Mod 2 > 0 Then
                        fg(1, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString
                    Else
                        fg(1, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString + vbEmpty
                    End If
                    fg.Cols("M" + .ID_mon.ToString).Width = 30
                    fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                End If
            End With
        Next
        Set_Style(fg)
    End Sub
    Private Sub FormatFlexGrid_MainSub(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Cols.Fixed = 1
        fg.Rows.Fixed = 2
        fg.Rows.DefaultSize = 20

        fg.Rows(0).Height = 40
        fg.Cols(0).Width = 20

        Format_fix_region(fg)
        Allow_merge(fg)
        'Ẩn tất cả các cột
        Dim dt As DataTable = fg.DataSource
        For i As Integer = 0 To dt.Columns.Count - 1
            fg.Cols(dt.Columns(i).ColumnName.ToString).Visible = False
        Next
        'Các cột hiển thị cố định
        fg.Cols("Ma_sv").Visible = True
        fg.Cols("Ma_sv").Caption = "Mã sinh viên"
        fg.Cols("Ma_sv").Width = 80
        fg.Cols("Ma_sv").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ho_ten").Visible = True
        fg.Cols("Ho_ten").Caption = "Họ và tên"
        fg.Cols("Ho_ten").Width = 160

        fg.Cols("Ten_lop").Visible = True
        fg.Cols("Ten_lop").Caption = "Tên lớp"
        fg.Cols("Ten_lop").TextAlign = TextAlignEnum.CenterCenter
        fg.Cols("Ten_lop").Width = 70

        fg.Cols("TBCHT10").Visible = True
        fg.Cols("TBCHT10").Caption = "TBCHK thang điểm 10"
        fg.Cols("TBCHT10").Width = 40
        fg.Cols("TBCHT10").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHK"
        fg.Cols("TBCHT").Width = 40
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai").Visible = True
        fg.Cols("Xep_loai").Caption = "Xếp loại"
        fg.Cols("Xep_loai").Width = 80


        fg.Cols("TC_TichLuy_Nam").Visible = True
        fg.Cols("TC_TichLuy_Nam").Caption = "Số TC năm"
        fg.Cols("TC_TichLuy_Nam").Width = 80
        fg.Cols("TC_TichLuy_Nam").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Caption = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        Dim dt_main As DataTable = fgTongHopKy.DataSource
        Dim Tu_cot, Den_cot As Integer
        Tu_cot = 23
        'Format các cột Học phần biến động theo số Học phần
        For i As Integer = 0 To clsDiem.ESSMonHoc.Count - 1
            With clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
                If .Khong_tinh_TBCHT = False Then
                    Den_cot = Tu_cot
                    'Hiển thị cột điểm
                    fg.Cols("M" + .ID_mon.ToString).Visible = True
                    'Gán tiêu đề cột điểm
                    If chkMonhoc.Checked Then
                        fg(0, "M" + .ID_mon.ToString) = .Ten_mon
                        fg.Cols("M" + .ID_mon.ToString).Width = 30
                        fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                    Else
                        fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                        fg.Cols("M" + .ID_mon.ToString).Width = 30
                        fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
                    End If
                    'Mon Sub
                    If chkThanh_phan.Checked Then
                        'Voi diem thi
                        Dim col As New DataColumn("T" + .ID_mon.ToString + "Thi")
                        If dt_main.Columns.Contains(col.ColumnName) Then
                            fg.Cols(col.ColumnName).Visible = True
                            fg(0, col.ColumnName) = "Thi"

                            fg.Cols(col.ColumnName).Width = 30
                            fg.Cols(col.ColumnName).TextAlign = TextAlignEnum.CenterCenter
                            Den_cot += 1
                        End If
                        'Voi diem thanh phan
                        For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                            col = New DataColumn("T" + .ID_mon.ToString + clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan.ToString)
                            If dt_main.Columns.Contains(col.ColumnName) Then
                                fg.Cols(col.ColumnName).Visible = True
                                fg(0, col.ColumnName) = clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu

                                fg.Cols(col.ColumnName).Width = 30
                                fg.Cols(col.ColumnName).TextAlign = TextAlignEnum.CenterCenter
                                Den_cot += 1
                            End If
                        Next
                    End If
                    'Không cho Merging số học trình
                    'If chkThanh_phan.Checked Then
                    If i Mod 2 > 0 Then
                        Allow_merge_HocTrinh(fg, .So_hoc_trinh.ToString, True, Tu_cot, Den_cot)
                    Else
                        Allow_merge_HocTrinh(fg, .So_hoc_trinh.ToString, False, Tu_cot, Den_cot)
                    End If
                    Tu_cot = Den_cot + 1
                End If
            End With
        Next
        Set_Style(fg)
    End Sub
    Private Sub Allow_merge_HocTrinh(ByVal fg As C1FlexGrid, ByVal Noi_dung As String, ByVal Empty As Boolean, ByVal Tu_cot As Integer, ByVal Den_cot As Integer)
        fg.AllowMerging = AllowMergingEnum.FixedOnly
        fg.Rows(1).AllowMerging = True
        If Empty Then
            For i As Integer = Tu_cot To Den_cot
                fg(1, i) = Noi_dung + vbEmpty
            Next
        Else
            For i As Integer = Tu_cot To Den_cot
                fg(1, i) = Noi_dung
            Next
        End If
    End Sub

    Private Sub Allow_merge(ByVal fg As C1FlexGrid)
        fg.AllowMerging = AllowMergingEnum.FixedOnly
        fg.Rows(1).AllowMerging = True
        For i As Integer = 1 To 20
            fg(1, i) = "Số tín chỉ"
        Next
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.PowderBlue
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Sub Set_Style(ByVal fg As C1FlexGrid)
        For i As Integer = fg.Rows.Fixed To fg.Rows.Count - 1
            For j As Integer = 12 To fg.Cols.Count - 1
                If fg(i, j).ToString <> "" AndAlso (fg(i, j).ToString = "F" Or fg(i, j).ToString = "0") Then 'thi lại
                    fg.SetCellStyle(i, j, fg.Styles("ThiLai_Style"))
                End If
            Next
        Next
    End Sub
    Public Shared Sub Flexgrid_setup(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        'Định nghĩa các kiểu để hiển thị      
        Dim Font_ As New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point)
        Dim ThiLai_Style As CellStyle
        'ThucHanh_Style
        ThiLai_Style = fg.Styles.Add("ThiLai_Style")
        ThiLai_Style.BackColor = Color.Gray
        ThiLai_Style.Border.Color = Color.Gray
        ThiLai_Style.ForeColor = Color.Red
        ThiLai_Style.Font = Font_
        ThiLai_Style.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Function CheckValidate() As Boolean
        If cmbNam_hoc.Text = "" Then
            Thongbao("Bạn phải chọn năm học trước khi tổng hợp")
            cmbNam_hoc.Focus()
            Return False
        End If
        If cmbLan_thi.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn lần thi trước khi tổng hợp")
            cmbLan_thi.Focus()
            Return False
        End If
        'If TreeViewLop.ID_chuyen_nganh <= 0 Then
        '    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
        '    Return False
        'End If
        Return True
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopNamHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi thứ
        LoadComboBox()
        Flexgrid_setup(fgTongHopKy)
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.HienThi_ESSTreeView()
        cmbKho_giay.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        'SetQuyenTruyCap(, cmdTong, , )
    End Sub

    Private Sub frmESS_TongHopNamHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Not TreeViewLop.ID_lop_list Is Nothing Then
                dsID_lop = TreeViewLop.ID_lop_list
                dsID_dt = TreeViewLop.ID_dt_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



#End Region

    Private Sub cmdTong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTong.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If CheckValidate() Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Nam_hoc As String = cmbNam_hoc.Text
                Dim ID_dt As Integer = TreeViewLop.ID_dt_list
                Dim Hien_thi_loai_diem As Integer = 0
                If optDiemChu.Checked Then
                    Hien_thi_loai_diem = 0
                ElseIf optDiemSo.Checked Then
                    Hien_thi_loai_diem = 1
                Else
                    Hien_thi_loai_diem = 2
                End If
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    'clsDiem = New Diem_Bussines(ID_dv, gobjUser.ID_Bomon, 0, Nam_hoc, dsID_lop, ID_dt, mdtDanhSachSinhVien)
                    clsDiem = New Diem_Bussines(ID_dv, 0, 0, Nam_hoc, dsID_lop, ID_dt, mdtDanhSachSinhVien)
                    Dim dtTonghop As DataTable = clsDiem.TongHopDiemNamHoc(cmbLan_thi.SelectedIndex + 1, Hien_thi_loai_diem, chkGhi_chu.Checked, chkThanh_phan.Checked, IIf(txtTu_diem.Text.Trim = "", -1, txtTu_diem.Text), IIf(txtDen_diem.Text = "", -1, txtDen_diem.Text))
                    If chkThanh_phan.Checked Then
                        fgTongHopKy.DataSource = dtTonghop
                        FormatFlexGrid_MainSub(fgTongHopKy)
                    Else
                        fgTongHopKy.DataSource = dtTonghop
                        FormatFlexGrid(fgTongHopKy)
                    End If
                Else
                    fgTongHopKy.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromC1flexgridToExcel(fgTongHopKy)
            Else
                Thongbao("Bạn phải tổng hợp dữ liệu điểm trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub



    Private Sub cmdPrint1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint1.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de_hoc_trinh As String
                Dim dtMonHoc As DataTable
                Dim mPaperSize As Printing.PaperKind
                Dim mOrientation As C1.Win.C1Report.OrientationEnum
                Tieu_de1 = "KẾT QUẢ HỌC TẬP NĂM HỌC " + cmbNam_hoc.Text
                Tieu_de2 = TreeViewLop.Tieu_de

                Tieu_de_hoc_trinh = "Số tín chỉ"
                dtMonHoc = clsDiem.DanhSachMonHoc
                'Xác định khổ giấy máy in
                Select Case cmbKho_giay.SelectedIndex
                    Case 0
                        mPaperSize = Printing.PaperKind.A4
                        mOrientation = OrientationEnum.Portrait
                    Case 1
                        mPaperSize = Printing.PaperKind.A4
                        mOrientation = OrientationEnum.Landscape
                    Case 2
                        mPaperSize = Printing.PaperKind.A3
                        mOrientation = OrientationEnum.Portrait
                    Case 3
                        mPaperSize = Printing.PaperKind.A3
                        mOrientation = OrientationEnum.Landscape
                End Select
                TaoBaoCaoTongHopDiem(C1Report1, mPaperSize, mOrientation, Tieu_de1, Tieu_de2, Tieu_de_hoc_trinh, dtMonHoc)
                Dim dtDiemTH As DataTable = fgTongHopKy.DataSource
                C1Report1.DataSource.Recordset = dtDiemTH
                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải tổng hợp dữ liệu điểm trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint2.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If CheckValidate() Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Nam_hoc As String = cmbNam_hoc.Text
                Dim ID_dts As String = ""
                Dim ID_lops As String = ""
                TreeViewLop.Get_ID_lops(TreeViewLop.trvLop.SelectedNode, ID_lops, ID_dts)
                If ID_dts.Length > 0 Then ID_dts = Mid(ID_dts, 1, Len(ID_dts) - 1)
                If ID_lops.Length > 0 Then ID_lops = Mid(ID_lops, 1, Len(ID_lops) - 1)
                Dim Hien_thi_loai_diem As Integer = 0
                If optDiemChu.Checked Then
                    Hien_thi_loai_diem = 0
                ElseIf optDiemSo.Checked Then
                    Hien_thi_loai_diem = 1
                Else
                    Hien_thi_loai_diem = 2
                End If
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(ID_lops)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    'clsDiem = New Diem_Bussines(ID_dv, gobjUser.ID_Bomon, Hoc_ky, Nam_hoc, dsID_lop, ID_dt, mdtDanhSachSinhVien)
                    clsDiem = New Diem_Bussines(ID_dv, 0, 0, Nam_hoc, ID_lops, ID_dts, mdtDanhSachSinhVien)
                    Dim dtTonghop As DataTable = clsDiem.TongHopDiemNamHoc_New(cmbLan_thi.SelectedIndex + 1, Hien_thi_loai_diem, chkGhi_chu.Checked, chkThanh_phan.Checked)

                    Dim Tieu_de1, Tieu_de2 As String
                    Tieu_de1 = "KẾT QUẢ HỌC TẬP NĂM HỌC " + cmbNam_hoc.Text
                    Tieu_de2 = TreeViewLop.Tieu_de

                    If dtTonghop.Rows.Count > 0 Then
                        Dim frmESS_ As New frmESS_XemBaoCao
                        frmESS_.ShowDialog("rpTongHop_Ky_ToanKhoa", dtTonghop, Tieu_de1, Tieu_de2)
                    End If
                Else
                    Thongbao("Bạn hãy chọn khoa để in tổng hợp", MsgBoxStyle.Information)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPhanLoai_Lop_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPhanLoai_Lop.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If dsID_lop.Trim <> "" Then
                If fgTongHopKy.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopKy.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_Lop
                frmESS_.lbl.Text = TreeViewLop.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Lop(dt, dsID_lop)
                frmESS_.ShowDialog(dt_main, "Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPhanLoai_Mon_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPhanLoai_Mon.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If optDiemChu.Checked Then
                Thongbao("Hãy chọn hiển thị theo điếm số và tổng hợp lại kết quả học tập !", MsgBoxStyle.Information)
                Exit Sub
            End If
            If dsID_lop.Trim <> "" Then
                If fgTongHopKy.DataSource Is Nothing Then Exit Sub
                Dim dt_sub, dt_main, dt As DataTable
                dt_sub = fgTongHopKy.DataSource
                dt = dt_sub.Copy
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_TheoHocPhan
                frmESS_.lbl.Text = TreeViewLop.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Mon(dt)
                frmESS_.ShowDialog(dt_main, "Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao("Hãy chọn hiển thị theo điếm số và tổng hợp lại kết quả học tập !", MsgBoxStyle.Information)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class