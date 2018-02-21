Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmEDU_XetLenLop_TongHop
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mID_chuyen_nganh As Integer = 0
    Private clsDSXetLenLop As DanhSachXetLenLop_Bussines

#Region "Form Events"
    Private Sub frmESS_XetLenLop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        SetQuyenTruyCap(, cmdZ, cmdAddQD, )
    End Sub

    Private Sub frmESS_XetLenLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        Try
            mID_he = trvLop.ID_he
            mKhoa_hoc = trvLop.Khoa_hoc
            mID_chuyen_nganh = trvLop.ID_chuyen_nganh
            If Not trvLop.ID_lop_list Is Nothing Then
                dsID_lop = trvLop.ID_lop_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
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

        FillCombo(cmb, dt)
    End Sub


    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grvDanhSach_CB1.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDevGridViewToExcel(grvDanhSach_CB1)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddQD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddQD.Click
        Try
            'If trvLop.ID_chuyen_nganh <= 0 Then
            '    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
            '    Exit Sub
            'End If
            Dim dv As DataView = grcDanhSach_Lan1.DataSource
            If Not dv Is Nothing Then
                Dim dt As DataTable = clsDSXetLenLop.Danh_sach_sinh_vien_chon(dv)
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)
                mID_dt = trvLop.ID_dt_list
                'clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, dsID_lop, 0, 0, 0, 0, "", mID_dt, mdtDanhSachSinhVien)
                'grcDanhSach.DataSource = clsDSXetLenLop.XetLenLop(cmbHoc_ky.Text, cmbNam_hoc.Text, gobjUser.ID_Bomon).DefaultView
                'labSo_sv.Text = grvDanhSach.RowCount
            Else
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.ShowDialog(Nothing, mdtDanhSachSinhVien)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZ.Click
        Try
            If trvLop.ID_he <= 0 Then
                Thongbao("Bạn phải chọn đến hệ đào tạo !")
                Exit Sub
            End If
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                Dim mdt_CanhBao1, mdt_CanhBao2, mdt_Canhbao3 As New DataTable
                Dim cls As New Diem_Bussines
                Dim dk As String = "WHERE 1=1"
                If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
                If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
                If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
                If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

                Dim dt As DataTable = cls.HienThi_DanhSach_XetLenLop(cmbHoc_ky.Text, cmbNam_hoc.Text, "SELECT DISTINCT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk)
                dt.Columns.Add("Chon", GetType(Boolean))
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i)("Chon") = False
                Next
                mdt_CanhBao1 = dt.Copy
                mdt_CanhBao2 = dt.Copy
                mdt_Canhbao3 = dt.Copy

                mdt_CanhBao1.DefaultView.Sort = "Lan_canh_bao"
                mdt_CanhBao1.DefaultView.RowFilter = "Lan_canh_bao=1"

                mdt_CanhBao2.DefaultView.Sort = "Lan_canh_bao"
                mdt_CanhBao2.DefaultView.RowFilter = "Lan_canh_bao=2"

                mdt_Canhbao3.DefaultView.Sort = "Lan_canh_bao"
                mdt_Canhbao3.DefaultView.RowFilter = "Lan_canh_bao=3"

                grcDanhSach_Lan1.DataSource = mdt_CanhBao1.DefaultView
                grcDanhSach_Lan2.DataSource = mdt_CanhBao2.DefaultView
                grcDanhSach_Lan3.DataSource = mdt_Canhbao3.DefaultView

                Thongbao("Danh sách sinh viên thôi học và cảnh báo thôi học !", MsgBoxStyle.Information)
            Else
                Thongbao("Chọn học kỳ và năm học và lần cảnh báo trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_CanhBao3.ItemClick
        Try
            Try
                If grvDanhSach_CB3.GetSelectedRows.Length = 0 Then Exit Sub
                Dim dv As DataView = grvDanhSach_CB3.DataSource
                Dim rpt As New rptMark_DanhSach_ThoiHoc(dv)
                PrintXtraReport(rpt)
            Catch ex As Exception
            End Try
            'Dim Tieu_de1, Tieu_de2 As String
            'If dv.Count > 0 Then
            '    Tieu_de1 = "DANH SÁCH SINH VIÊN BỊ CẢNH BÁO THÔI HỌC " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
            '    If trvLop.Tieu_de_Lop <> "" Then 'La Lop
            '        Tieu_de2 = trvLop.Tieu_de_Lop.ToUpper
            '    Else
            '        Tieu_de2 = trvLop.Tieu_de
            '    End If

            '    ReportModel.GetReportHeader(gobjUser.ID_dv, gobjUser.UserID)
            '    ReportModel.Init()

            '    ReportModel.HeaderTable.Add("STT", New CellReport("STT", 30, ""))
            '    ReportModel.HeaderTable.Add("Ma_sv", New CellReport("Mã SV", 50, "Ma_sv", , ))
            '    ReportModel.HeaderTable.Add("Ho_ten", New CellReport("Họ và tên", 100, "Ho_ten", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))
            '    ReportModel.HeaderTable.Add("Ngay_sinh", New CellReport("Ngày sinh", 50, "Ngay_sinh", "{0:dd/MM/yyyy}", ))
            '    ReportModel.HeaderTable.Add("Ten_lop", New CellReport("Lớp", 50, "Ten_lop", , ))
            '    ReportModel.HeaderTable.Add("So_TCHT", New CellReport("Số TCHT", 40, "So_TCHT", , ))
            '    ReportModel.HeaderTable.Add("TBCHT_Ky", New CellReport("TBCHT", 40, "TBCHT_Ky", , ))
            '    ReportModel.HeaderTable.Add("TBCTL", New CellReport("TBCTL", 40, "TBCTL", , ))
            '    ReportModel.HeaderTable.Add("So_TCTL", New CellReport("Số TCTL", 40, "So_TCTL", , ))
            '    ReportModel.HeaderTable.Add("Lan_canh_bao", New CellReport("Lần", 40, "Lan_canh_bao", , ))
            '    ReportModel.HeaderTable.Add("Ly_do", New CellReport("Ghi chú", 300, "Ly_do", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))

            '    Dim rpt As New ThienAn_Report_Complex(Printing.PaperKind.A4, True, New System.Drawing.Printing.Margins(45, 30, 30, 30), 20, Tieu_de1, Tieu_de2, , , , True, 8, 8)
            '    rpt.DataSource = dv.Table
            '    ReportModel.PrintXtraReport(rpt)

            'End If
        Catch ex As Exception
        End Try


    End Sub

    'Private Sub cmdPrint2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint2.ItemClick
    '    Dim mHoc_ky As Integer = cmbHoc_ky.Text
    '    Dim mNam_hoc As String = cmbNam_hoc.Text
    '    clsDSXetLenLop = New DanhSachXetLenLop_Bussines
    '    Dim dv As DataView = clsDSXetLenLop.TongHop_LanCanhBao(mHoc_ky, mNam_hoc, "1=1").DefaultView
    '    Dim rpt As New rptCanhCaoKetQuaHocTap(dv, "HỌC KỲ " & mHoc_ky & "  NĂM HỌC " & mNam_hoc)
    '    PrintXtraReport(rpt)
    'End Sub
#End Region


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim dv_chuachon As DataView = grvDanhSach_DaChon.DataSource
        '    For i As Integer = dv_chuachon.Count - 1 To 0 Step -1
        '        If dv_chuachon.Item(i)("Chon") Then
        '            clsDSXetLenLop.Update_XetLenLop_KhiDuyet(dv_chuachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text)
        '        End If
        '    Next

        '    clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
        '    dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, IIf(cmbLan_thu.Text <> "", cmbLan_thu.Text, 0), 0).DefaultView
        '    'grcDanhSach.DataSource = dv_chuachon
        '    'labSo_sv.Text = grcDanhSach.DataSource.Count
        '    grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, IIf(cmbLan_thu.Text <> "", cmbLan_thu.Text, 0), 1).DefaultView
        '    grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN CÁNH BÁO: " & grvDanhSach_DaChon.RowCount.ToString
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        '    Dim dv_dachon As DataView = grcDanhSach_DaChon.DataSource
        '    Dim dv_chuachon As DataView

        '    For i As Integer = dv_dachon.Count - 1 To 0 Step -1
        '        If dv_dachon.Item(i)("Chon") Then
        '            clsDSXetLenLop.Delete_XetLenLop_DaDuyet(dv_dachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text)
        '        End If
        '    Next

        '    clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
        '    'dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
        '    'grcDanhSach.DataSource = dv_chuachon
        '    'labSo_sv.Text = grcDanhSach.DataSource.Count
        '    grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, IIf(cmbLan_thu.Text <> "", cmbLan_thu.Text, 0), 1).DefaultView
        '    grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN CÁNH BÁO: " & grvDanhSach_DaChon.RowCount.ToString
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub



    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dv As DataView = grcDanhSach_Lan3.DataSource
        If Not dv Is Nothing Then
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub

    Private Sub frmEDU_XetLenLop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    'Private Sub cmdNoiDung_CB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNoiDung_CB.Click
    '    Try
    '        Dim frm As New frmEDU_NoiDung_CanhBao
    '        frm.ShowDialog()
    '    Catch ex As Exception
    '    End Try
    'End Sub

    Private Sub btnPrint_CanhBao1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint_CanhBao1.ItemClick
        Try
            If grvDanhSach_CB1.GetSelectedRows.Length = 0 Then Exit Sub
            Dim dv As DataView = grvDanhSach_CB1.DataSource
            Dim rpt As New rptMark_DanhSachCanhBao1(dv)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnPrint_CanhBao2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnPrint_CanhBao2.ItemClick
        Try
            If grvDanhSach_CB2.GetSelectedRows.Length = 0 Then Exit Sub
            Dim dv As DataView = grvDanhSach_CB2.DataSource
            Dim rpt As New rptMark_DanhSachCanhBao2(dv)
            PrintXtraReport(rpt)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdInTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInTongHop.Click
        Dim frm As New frmEDU_InTongHop
        frm.ShowDialog(cmbHoc_ky.Text, cmbNam_hoc.Text)
    End Sub
End Class