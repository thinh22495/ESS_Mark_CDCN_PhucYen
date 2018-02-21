Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Public Class frmESS_DSHocBongHocPhi
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
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
        fg.Cols("STT").Visible = True
        fg.Cols("STT").Caption = "STT"
        fg.Cols("STT").Width = 30
        fg.Cols("STT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ho_ten").Visible = True
        fg.Cols("Ho_ten").Caption = "Họ và tên"
        fg.Cols("Ho_ten").Width = 160

        fg.Cols("Ma_dt").Visible = True
        fg.Cols("Ma_dt").Caption = "Đối tượng"
        fg.Cols("Ma_dt").TextAlign = TextAlignEnum.CenterCenter
        fg.Cols("Ma_dt").Width = 30

        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHT"
        fg.Cols("TBCHT").Width = 40
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCRL").Visible = True
        fg.Cols("TBCRL").Caption = "TBCRL"
        fg.Cols("TBCRL").Width = 40
        fg.Cols("TBCRL").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ky_luat").Visible = True
        fg.Cols("Ky_luat").Caption = "Vi phạm quy chế"
        fg.Cols("Ky_luat").Width = 80

        fg.Cols("Khen_thuong").Visible = True
        fg.Cols("Khen_thuong").Caption = "Khen"
        fg.Cols("Khen_thuong").Width = 80

        fg.Cols("Hoc_bong").Visible = True
        fg.Cols("Hoc_bong").Caption = "Học bổng"
        fg.Cols("Hoc_bong").Width = 40
        fg.Cols("Hoc_bong").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Hoc_phi").Visible = True
        fg.Cols("Hoc_phi").Caption = "Học phi"
        fg.Cols("Hoc_phi").Width = 40
        fg.Cols("Hoc_phi").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Ghi_chu").Visible = True
        fg.Cols("Ghi_chu").Caption = "Ghi chú"
        fg.Cols("Ghi_chu").Width = 40
        fg.Cols("Ghi_chu").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Caption = "Nợ"
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        'Format các cột Học phần biến động theo số Học phần
        For i As Integer = 0 To clsDiem.ESSMonHoc.Count - 1
            With clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
                'Hiển thị cột điểm
                fg.Cols("M" + .ID_mon.ToString).Visible = True
                'Gán tiêu đề cột điểm
                fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                'Không cho Merging số học trình
                If i Mod 2 > 0 Then
                    fg(1, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString
                Else
                    fg(1, "M" + .ID_mon.ToString) = .So_hoc_trinh.ToString + vbEmpty
                End If
                fg.Cols("M" + .ID_mon.ToString).Width = 30
                fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
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

        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Caption = "TBCHK"
        fg.Cols("TBCHT").Width = 40
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCHK_10").Visible = True
        fg.Cols("TBCHK_10").Caption = "TBCHK Thang điểm10"
        fg.Cols("TBCHK_10").Width = 40
        fg.Cols("TBCHK_10").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCTL").Visible = True
        fg.Cols("TBCTL").Caption = "TBCTL"
        fg.Cols("TBCTL").Width = 40
        fg.Cols("TBCTL").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("So_tc_tichluy").Visible = True
        fg.Cols("So_tc_tichluy").Caption = "Số TC tích luỹ"
        fg.Cols("So_tc_tichluy").Width = 40
        fg.Cols("So_tc_tichluy").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Nam_dao_tao").Visible = True
        fg.Cols("Nam_dao_tao").Caption = "Xếp hạng năm đào tạo"
        fg.Cols("Nam_dao_tao").Width = 40
        fg.Cols("Nam_dao_tao").TextAlign = TextAlignEnum.CenterCenter

        Dim dt_main As DataTable = fgTongHopKy.DataSource
        Dim Tu_cot, Den_cot As Integer
        Tu_cot = 24
        'Format các cột Học phần biến động theo số Học phần
        For i As Integer = 0 To clsDiem.ESSMonHoc.Count - 1
            With clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
                Den_cot = Tu_cot
                'Hiển thị cột điểm
                fg.Cols("M" + .ID_mon.ToString).Visible = True
                'Gán tiêu đề cột điểm
                fg(0, "M" + .ID_mon.ToString) = .Ky_hieu
                fg.Cols("M" + .ID_mon.ToString).Width = 30
                fg.Cols("M" + .ID_mon.ToString).TextAlign = TextAlignEnum.CenterCenter
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
        If cmbHoc_ky.SelectedIndex < 0 Then
            Thongbao("Bạn phải chọn học kỳ trước khi tổng hợp")
            cmbHoc_ky.Focus()
            Return False
        End If
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
        If TreeViewLop.Tieu_de_Lop = "" Then
            Thongbao("Bạn phải chọn đến lớp!")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopHocKy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi thứ
        LoadComboBox()
        Flexgrid_setup(fgTongHopKy)
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.HienThi_ESSTreeView()
        cmbKho_giay.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        SetQuyenTruyCap(, cmdHienThi, , )
    End Sub

    Private Sub frmESS_TongHopHocKy_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHienThi.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If CheckValidate() Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
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
                    'Add Diem
                    clsDiem = New Diem_Bussines(ID_dv, gobjUser.ID_Bomon, Hoc_ky, Nam_hoc, dsID_lop, ID_dt, mdtDanhSachSinhVien)
                    Dim dtTonghop As DataTable = clsDiem.TongHopDiemHocKy_TichLuy(cmbLan_thi.SelectedIndex + 1, Hien_thi_loai_diem, chkGhi_chu.Checked, chkThanh_phan.Checked, Hoc_ky, Nam_hoc)
                    'Add STT & Ghi chu
                    dtTonghop.Columns.Add("STT", GetType(String))
                    dtTonghop.Columns.Add("Ghi_chu", GetType(String))
                    For i As Integer = 0 To dtTonghop.Rows.Count - 1
                        dtTonghop.Rows(i)("STT") = i + 1
                    Next
                    'Add Hoc phi
                    Dim clsHP As New BienLaiThu_Bussines(cmbHoc_ky.Text, cmbNam_hoc.Text, dsID_lop, 1, 1)
                    clsHP.AddHocPhi(dtTonghop)
                    'Add Hoc bong
                    Dim clsHB As New DanhSachHocBong_Bussines(dsID_lop, cmbHoc_ky.Text, cmbNam_hoc.Text)
                    clsHB.AddHocBong(dtTonghop, Hoc_ky, Nam_hoc)
                    'Add Ky luat
                    Dim clsKL As New KyLuat_Bussines(dsID_lop)
                    clsKL.AddKyLuat(dtTonghop, Hoc_ky, Nam_hoc)
                    'Add Khen thuong
                    Dim clsKT As New KhenThuong_Bussines(dsID_lop)
                    clsKT.AddKhenThuong(dtTonghop, Hoc_ky, Nam_hoc)
                    'Add Ren Luyen
                    Dim clsRL As New DiemRenLuyen_Bussines(dsID_lop)
                    clsRL.AddDiemRenLuyen(dtTonghop, Hoc_ky, Nam_hoc)
                    'Add Doi Tuong
                    Dim clsDT As New DoiTuongChinhSach_Bussines(dsID_lop)
                    clsDT.AddDoiTuong(dtTonghop)
                    'Format 
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


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2 As String
                Dim dtMonHoc As DataTable
                Dim mPaperSize As Printing.PaperKind
                Dim mOrientation As C1.Win.C1Report.OrientationEnum
                Tieu_de1 = "BẢNG PHÂN LOẠI KẾT QUẢ HỌC TẬP HỌC KỲ " + (cmbHoc_ky.SelectedIndex + 1).ToString + " NĂM HỌC " + cmbNam_hoc.Text
                Tieu_de2 = TreeViewLop.Tieu_de

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
                Dim dtTonghop As DataTable = fgTongHopKy.DataSource
                Dim dt As DataTable = dtTonghop.Copy
                If dtTonghop.Rows.Count > 0 Then
                    TaoBaoCaoTongHopDiemKy_TichLuy(C1Report1, mPaperSize, mOrientation, Tieu_de1, Tieu_de2, dtMonHoc, txtNguoi_lap.Text, txtChuc_danh.Text, txtNguoi_ky.Text, txtGhi_chu.Text, dtTonghop.Rows(0).Item("Ket_qua_PL"))
                End If
                Dim dtDiemTH As DataTable = fgTongHopKy.DataSource
                C1Report1.DataSource.Recordset = dtDiemTH
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải tổng hợp dữ liệu điểm trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
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
#End Region
End Class