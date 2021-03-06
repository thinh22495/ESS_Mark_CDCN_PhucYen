﻿Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Public Class frmESS_TongHop_DiemHocTichLuy_NganhHoc2
    Private mID_dt As Integer = 0
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines
    Private clsCTDT2 As New DanhSachNganh2_Bussines()
#Region "Functions And Subs"
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

        fg.Cols("So_mon_no").Visible = True
        fg.Cols("So_mon_no").Width = 30
        fg.Cols("So_mon_no").AllowMerging = True
        fg.Cols("So_mon_no").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("TBCHT10").Visible = True
        fg.Cols("TBCHT10").Width = 40
        fg.Cols("TBCHT10").AllowMerging = True
        fg.Cols("TBCHT10").TextAlign = TextAlignEnum.CenterCenter


        fg.Cols("TBCHT").Visible = True
        fg.Cols("TBCHT").Width = 40
        fg.Cols("TBCHT").AllowMerging = True
        fg.Cols("TBCHT").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Xep_loai").Visible = True
        fg.Cols("Xep_loai").Width = 80
        fg.Cols("Xep_loai").AllowMerging = True

        'fg.Cols("Xep_hang").Visible = True
        'fg.Cols("Xep_hang").Width = 80
        'fg.Cols("Xep_hang").AllowMerging = True

        fg.Cols("So_hoc_trinh").Visible = True
        fg.Cols("So_hoc_trinh").Width = 50
        fg.Cols("So_hoc_trinh").AllowMerging = True
        fg.Cols("So_hoc_trinh").TextAlign = TextAlignEnum.CenterCenter

        fg.Cols("Nam_thu").Visible = True
        fg.Cols("Nam_thu").Width = 40
        fg.Cols("Nam_thu").AllowMerging = True
        fg.Cols("Nam_thu").TextAlign = TextAlignEnum.CenterCenter

        For i As Byte = 0 To 0
            fg(i, "TBCHT") = "TBCTL"
            fg(i, "TBCHT10") = "TBCHT10"
            fg(i, "Xep_loai") = "Xếp loại"
            'fg(i, "Xep_hang") = "Xếp hạng"
            fg(i, "So_hoc_trinh") = "Số.TC TLuỹ"
            fg(i, "Nam_thu") = "Năm thứ"
            fg(i, "So_mon_no") = "Nợ"
        Next

        'Format các cột Học phần biến động theo số Học phần
        For i As Integer = 0 To clsDiem.ESSMonHoc.Count - 1
            With clsDiem.ESSMonHoc.ESSChuongTrinhDaoTaoChiTiet(i)
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
            End With
        Next
        Set_Style(fg)
    End Sub
    Private Sub Allow_merge(ByVal fg As C1FlexGrid)
        fg.AllowMerging = AllowMergingEnum.FixedOnly
        fg.Rows(1).AllowMerging = True
        For i As Integer = 1 To 17
            fg(1, i) = "Số tín chỉ"
        Next
    End Sub
    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = Color.PowderBlue
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
        fg.Styles.Fixed.WordWrap = True
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

#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopToanKhoa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewChuyenNganh_Nganh21.HienThi_ESSTreeView()
        Flexgrid_setup(fgTongHopToanKhoa)
        cmbKho_giay.SelectedIndex = 3
        'SetQuyenTruyCap(, cmdTong, , )
    End Sub

    Private Sub frmESS_TongHopToanKhoa_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLop_Select() Handles TreeViewChuyenNganh_Nganh21.TreeNodeSelected_
        Try
            If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh > 0 Then
                mID_dt = TreeViewChuyenNganh_Nganh21.ID_dt
                'Load danh sách sinh viên
                mdtDanhSachSinhVien = clsCTDT2.DanhSachSinhVien_HocNganh2(mID_dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


#End Region
    Private Sub cmdTong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTong.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim ID_dv As String = gobjUser.ID_dv
            Dim ID_dt As Integer = TreeViewChuyenNganh_Nganh21.ID_dt
            Dim Hien_thi_loai_diem As Integer = 0
            If optDiemChu.Checked Then
                Hien_thi_loai_diem = 0
            ElseIf optDiemSo.Checked Then
                Hien_thi_loai_diem = 1
            Else
                Hien_thi_loai_diem = 2
            End If
            If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh > 0 Then
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    clsDiem = New Diem_Bussines(0, "", 0, mID_dt, mdtDanhSachSinhVien)
                    fgTongHopToanKhoa.DataSource = clsDiem.TongHopDiemTinChiTichLuy(Hien_thi_loai_diem, chkGhi_chu.Checked, IIf(txtTu_diem.Text.Trim = "", -1, txtTu_diem.Text), IIf(txtDen_diem.Text = "", -1, txtDen_diem.Text))
                    FormatFlexGrid(fgTongHopToanKhoa)
                Else
                    fgTongHopToanKhoa.DataSource = Nothing
                End If
            Else
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If Not fgTongHopToanKhoa.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromC1flexgridToExcel(fgTongHopToanKhoa)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdPrint1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint1.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim Tieu_de1, Tieu_de2, Tieu_de_hoc_trinh As String
            Dim dtMonHoc As DataTable
            Dim mPaperSize As Printing.PaperKind
            Dim mOrientation As C1.Win.C1Report.OrientationEnum
            Tieu_de1 = "KẾT QUẢ HỌC TẬP TOÀN KHOÁ "
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
            Dim dtDiemTH As DataTable = fgTongHopToanKhoa.DataSource
            C1Report1.DataSource.Recordset = dtDiemTH
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog(C1Report1)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class