Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports C1.Win.C1Report
Imports C1.Win.C1FlexGrid
Public Class frmESS_TongHop_ThiLai
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
        For i As Integer = 0 To dt.Rows.Count - 1
            fg.Cols(dt.Columns(i).ColumnName.ToString).Visible = False
            'fg.Cols(dv.Item(0)(i)).Visible = False
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
        If TreeViewLop.ID_chuyen_nganh <= 0 Then
            Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
            Return False
        End If
        Return True
    End Function
#End Region

#Region "Form Events"
    Private Sub frmESS_TongHopThiLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi thứ
        LoadComboBox()
        Flexgrid_setup(fgTongHopKy)
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.HienThi_ESSTreeView()
        cmbKho_giay.SelectedIndex = 0
        cmbLan_thi.SelectedIndex = 0
        SetQuyenTruyCap(, cmdTongHop, cmdPhanLoaiHocTap_mon, )
    End Sub

    Private Sub frmESS_TongHopThiLai_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If CheckValidate() Then
        '        Dim ID_dv As String = gobjUser.ID_dv
        '        Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
        '        Dim Nam_hoc As String = cmbNam_hoc.Text
        '        Dim ID_dt As Integer = TreeViewLop.ID_dt_list
        '        Dim Hien_thi_loai_diem As Integer = 0
        '        If optDiemChu.Checked Then
        '            Hien_thi_loai_diem = 0
        '        ElseIf optDiemChu.Checked Then
        '            Hien_thi_loai_diem = 1
        '        Else
        '            Hien_thi_loai_diem = 2
        '        End If
        '        If mdtDanhSachSinhVien.Rows.Count > 0 Then
        '            clsDiem = New Diem_Bussines(ID_dv, gobjUser.ID_Bomon, Hoc_ky, Nam_hoc, dsID_lop, ID_dt, mdtDanhSachSinhVien)
        '            Dim dt As DataTable = clsDiem.TongHopThiLaiHocKy()
        '            'dt.DefaultView.RowFilter = "So_mon_thi_lai>0"
        '            fgTongHopKy.DataSource = dt
        '            FormatFlexGrid(fgTongHopKy)
        '        Else
        '            fgTongHopKy.DataSource = Nothing
        '        End If
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdPhanLoai_Lop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhanLoai_Lop.Click
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
                frmESS_.ShowDialog(dt_main, "Học kỳ :" & cmbHoc_ky.Text & " Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPhanLoaiHocTap_mon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPhanLoaiHocTap_mon.Click
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
                Dim frmESS_ As New frmESS_PhanLoaiHocTap_mon
                frmESS_.lbl.Text = TreeViewLop.Tieu_de

                dt_main = clsDiem.PhanLoaiHocTap_Mon(dt)
                frmESS_.ShowDialog(dt_main, "Học kỳ :" & cmbHoc_ky.Text & " Năm học: " & cmbNam_hoc.Text)
            Else
                Thongbao("Hãy chọn tổng hợp điểm !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao("Hãy chọn hiển thị theo điếm số và tổng hợp lại kết quả học tập !", MsgBoxStyle.Information)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de_hoc_trinh As String
                Dim dtMonHoc As DataTable
                Dim mPaperSize As Printing.PaperKind
                Dim mOrientation As C1.Win.C1Report.OrientationEnum
                Tieu_de1 = "KẾT QUẢ HỌC TẬP HỌC KỲ " + (cmbHoc_ky.SelectedIndex + 1).ToString + " NĂM HỌC " + cmbNam_hoc.Text
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