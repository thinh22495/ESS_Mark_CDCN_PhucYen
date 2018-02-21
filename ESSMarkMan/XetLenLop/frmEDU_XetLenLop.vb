Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmEDU_XetLenLop
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
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_DangHoc
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
            If Not grvDanhSach_DaChon.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDevGridViewToExcel(grvDanhSach_DaChon)
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
            Dim dv As DataView = grcDanhSach_DaChon.DataSource
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
            If trvLop.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                mID_dt = trvLop.ID_dt_list
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines()

                Dim objDanhSach1 As New DanhSachSinhVien_Bussines(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach1.Danh_sach_sinh_vien_DangHoc
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, dsID_lop, 0, 0, 0, CType(cmbHoc_ky.Text, Integer), cmbNam_hoc.Text, mID_dt, mdtDanhSachSinhVien)
                Dim dv_chuaxet As DataView

                dv_chuaxet = clsDSXetLenLop.XetLenLop(cmbHoc_ky.Text, cmbNam_hoc.Text, gobjUser.ID_Bomon, 0, optTheo_QuyChe.Checked).DefaultView
                Dim dk As String = "WHERE 1=1"
                If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
                If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
                If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
                If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop
                'Xoa danh sach da xet nhung chua duyet cua lan truoc
                'Them moi cac sinh vien thuoc dien thoi, ngung hoc
                clsDSXetLenLop.Delete_XetLenLop_KhiTongHop_TheoSinhVien(cmbHoc_ky.Text, cmbNam_hoc.Text, "SELECT DISTINCT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk)
                Dim Lan_canh_bao As Integer = 0
                For i As Integer = 0 To dv_chuaxet.Count - 1
                    Dim Ly_do_cac_ky, Ly_do_cac_ky_new As String
                    Ly_do_cac_ky_new = ""
                    Lan_canh_bao = clsDSXetLenLop.getLan_canh_bao(cmbHoc_ky.Text, cmbNam_hoc.Text, dv_chuaxet.Item(i)("ID_SV"), Ly_do_cac_ky)
                    Ly_do_cac_ky_new = Ly_do_cac_ky
                    If dv_chuaxet.Item(i)("Ly_do").ToString.Trim <> "" Then
                        If Ly_do_cac_ky <> "" Then
                            Ly_do_cac_ky_new = cmbHoc_ky.Text & "(" & cmbNam_hoc.Text & "): " & dv_chuaxet.Item(i)("Ly_do") & "| " & Ly_do_cac_ky
                        Else
                            Ly_do_cac_ky_new = cmbHoc_ky.Text & "(" & cmbNam_hoc.Text & "): " & dv_chuaxet.Item(i)("Ly_do")
                        End If
                        Lan_canh_bao = Lan_canh_bao + 1
                    ElseIf Lan_canh_bao = 1 Then
                        Lan_canh_bao = 0
                    ElseIf Lan_canh_bao = 2 Then
                        Lan_canh_bao = 1
                    End If
                    clsDSXetLenLop.Insert_XetLenLop_KhiTongHop(dv_chuaxet.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, Lan_canh_bao, dv_chuaxet.Item(i)("Ly_do"), dv_chuaxet.Item(i)("So_TCTL"), dv_chuaxet.Item(i)("TBCTL"), dv_chuaxet.Item(i)("So_TCHT"), dv_chuaxet.Item(i)("TBCHT_Ky"), 1, dv_chuaxet.Item(i)("Xephang_Nam_daoTao"), Ly_do_cac_ky_new)
                Next

                Dim dv_daxet As DataView = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 1).DefaultView
                dv_daxet.RowFilter = "Ly_do<>''"
                grcDanhSach_DaChon.DataSource = dv_daxet
                grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN: " & grvDanhSach_DaChon.RowCount.ToString
                Thongbao("Xét cảnh báo thôi học thành công !", MsgBoxStyle.Information)
            Else
                Thongbao("Chọn học kỳ và năm học và lần cảnh báo trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint1.ItemClick
        Try
            Dim dv As DataView = grvDanhSach_DaChon.DataSource

            Dim Tieu_de1, Tieu_de2 As String
            If dv.Count > 0 Then
                Tieu_de1 = "DANH SÁCH SINH VIÊN BỊ CẢNH BÁO THÔI HỌC HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                If trvLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de2 = trvLop.Tieu_de_Lop.ToUpper
                Else
                    Tieu_de2 = trvLop.Tieu_de
                End If

                ReportModel.GetReportHeader(gobjUser.ID_dv, gobjUser.UserID)
                ReportModel.Init()

                ReportModel.HeaderTable.Add("STT", New CellReport("STT", 30, ""))
                ReportModel.HeaderTable.Add("Ma_sv", New CellReport("Mã SV", 50, "Ma_sv", , ))
                ReportModel.HeaderTable.Add("Ho_ten", New CellReport("Họ và tên", 100, "Ho_ten", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))
                ReportModel.HeaderTable.Add("Ngay_sinh", New CellReport("Ngày sinh", 50, "Ngay_sinh", "{0:dd/MM/yyyy}", ))
                ReportModel.HeaderTable.Add("Ten_lop", New CellReport("Lớp", 50, "Ten_lop", , ))
                ReportModel.HeaderTable.Add("So_TCHT", New CellReport("Số TCHT", 40, "So_TCHT", , ))
                ReportModel.HeaderTable.Add("TBCHT_Ky", New CellReport("TBCHT", 40, "TBCHT_Ky", , ))
                ReportModel.HeaderTable.Add("TBCTL", New CellReport("TBCTL", 40, "TBCTL", , ))
                ReportModel.HeaderTable.Add("So_TCTL", New CellReport("Số TCTL", 40, "So_TCTL", , ))
                ReportModel.HeaderTable.Add("Lan_canh_bao", New CellReport("Lần", 40, "Lan_canh_bao", , ))
                ReportModel.HeaderTable.Add("Ly_do", New CellReport("Ghi chú", 300, "Ly_do", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))

                Dim rpt As New ThienAn_Report_Complex(Printing.PaperKind.A4, True, New System.Drawing.Printing.Margins(45, 30, 30, 30), 20, Tieu_de1, Tieu_de2, , , , True, 8, 8)
                rpt.DataSource = dv.Table
                ReportModel.PrintXtraReport(rpt)

            End If
        Catch ex As Exception
        End Try


    End Sub

    Private Sub cmdPrint2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint2.ItemClick
        'Try
        '    Dim ID_dts As String = ""
        '    Dim ID_lops As String = ""

        '    If trvLop.ID_chuyen_nganh <= 0 Then
        '        Thongbao("Bạn phải chọn đến ngành đào tạo!")
        '        Exit Sub
        '    End If
        '    trvLop.Get_ID_lops(trvLop.trvLop.SelectedNode, ID_lops, ID_dts)
        '    If ID_dts.Length > 0 Then ID_dts = Mid(ID_dts, 1, Len(ID_dts) - 1)
        '    If ID_lops.Length > 0 Then ID_lops = Mid(ID_lops, 1, Len(ID_lops) - 1)

        '    Dim objdsLop As New Lop_Bussines(ID_lops, 0, 1, -1)
        '    Dim mdtLop As DataTable = objdsLop.Lop()
        '    mdtLop.Columns.Add("So_sv")
        '    mdtLop.Columns.Add("So_sv_len_lop")
        '    mdtLop.Columns.Add("So_sv_thoi_hoc")
        '    'Load danh sách sinh viên
        '    Dim objDanhSach As New DanhSachSinhVien_Bussines(ID_lops)
        '    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
        '    Dim dv As DataView
        '    If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
        '        If mdtDanhSachSinhVien.Rows.Count > 0 Then
        '            clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, ID_lops, 0, 0, 0, 0, "", ID_dts, mdtDanhSachSinhVien)
        '            dv = clsDSXetLenLop.XetLenLop_TongHop(cmbHoc_ky.Text, cmbNam_hoc.Text, 0).DefaultView
        '            Dim iCount As Integer = 0
        '            For i As Integer = 0 To mdtLop.Rows.Count - 1
        '                dv.RowFilter = "Ly_do<>'' AND ID_lop=" + mdtLop.Rows(i).Item("ID_lop").ToString
        '                iCount = dv.Count
        '                mdtLop.Rows(i).Item("So_sv") = objDanhSach.Danh_sach_sinh_vien(mdtLop.Rows(i).Item("ID_lop").ToString).Rows.Count
        '                mdtLop.Rows(i).Item("So_sv_len_lop") = objDanhSach.Danh_sach_sinh_vien(mdtLop.Rows(i).Item("ID_lop").ToString).Rows.Count - iCount
        '                mdtLop.Rows(i).Item("So_sv_thoi_hoc") = iCount
        '                dv.RowFilter = "Ly_do<>''"
        '            Next
        '            Dim Tieu_de1, Tieu_de2 As String
        '            Tieu_de1 = "THÔNG KÊ SỐ SINH VIÊN HỌC TIẾP NGỪNG HỌC, HỌC KỲ " + (cmbHoc_ky.SelectedIndex + 1).ToString + " NĂM HỌC " + cmbNam_hoc.Text
        '            Tieu_de2 = trvLop.Tieu_de

        '            If mdtLop.Rows.Count > 0 Then
        '                Dim frmESS_ As New frmESS_XemBaoCao
        '                frmESS_.ShowDialog("rpThongKe_SinhVien_HocTiep_ThoiHoc", mdtLop, Tieu_de1, Tieu_de2)
        '            End If
        '        End If
        '    Else
        '        Thongbao("Chọn học kỳ và năm học trước khi xét thôi học !", MsgBoxStyle.Information)
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try



        Try
            If trvLop.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If

            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then

                Dim dv As DataView
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
                dv = clsDSXetLenLop.DanhSachDaXet_TongHop(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 1, 1).DefaultView


                Dim Tieu_de1, Tieu_de2 As String
                If dv.Count > 0 Then
                    Tieu_de1 = "DANH SÁCH SINH VIÊN BỊ CẢNH BÁO THÔI HỌC HỌC KỲ " & cmbHoc_ky.Text & " NĂM HỌC " & cmbNam_hoc.Text
                    If trvLop.Tieu_de_Lop <> "" Then 'La Lop
                        Tieu_de2 = trvLop.Tieu_de_Lop.ToUpper
                    Else
                        Tieu_de2 = trvLop.Tieu_de
                    End If

                    ReportModel.GetReportHeader(gobjUser.ID_dv, gobjUser.UserID)
                    ReportModel.Init()

                    ReportModel.HeaderTable.Add("STT", New CellReport("STT", 30, ""))
                    ReportModel.HeaderTable.Add("Ma_sv", New CellReport("Mã SV", 50, "Ma_sv", , ))
                    ReportModel.HeaderTable.Add("Ho_ten", New CellReport("Họ và tên", 100, "Ho_ten", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))
                    ReportModel.HeaderTable.Add("Ngay_sinh", New CellReport("Ngày sinh", 50, "Ngay_sinh", "{0:dd/MM/yyyy}", ))
                    ReportModel.HeaderTable.Add("Ten_lop", New CellReport("Lớp", 50, "Ten_lop", , ))
                    ReportModel.HeaderTable.Add("So_TCTL", New CellReport("Số TCTL", 40, "So_TCTL", , ))
                    ReportModel.HeaderTable.Add("TBCTL", New CellReport("TBCTL", 40, "TBCTL", , ))
                    ReportModel.HeaderTable.Add("TBCHT_Ky", New CellReport("TBCHT Ky", 40, "TBCHT_Ky", , ))
                    ReportModel.HeaderTable.Add("So_TCHT", New CellReport("Số TCHT", 40, "So_TCHT", , ))
                    ReportModel.HeaderTable.Add("Lan_canh_bao", New CellReport("Lần", 40, "Lan_canh_bao", , ))
                    ReportModel.HeaderTable.Add("Ly_do", New CellReport("Lý do", 300, "Ly_do", , DevExpress.XtraPrinting.TextAlignment.MiddleLeft))

                    Dim rpt As New ThienAn_Report_Complex(Printing.PaperKind.A4, True, New System.Drawing.Printing.Margins(45, 30, 30, 30), 20, Tieu_de1, Tieu_de2, , , , True, 8, 8)
                    rpt.DataSource = dv.Table
                    ReportModel.PrintXtraReport(rpt)

                End If

            Else
                Thongbao("Chọn học kỳ và năm học và lần cảnh báo trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub
#End Region


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv_chuachon As DataView = grvDanhSach_DaChon.DataSource
            For i As Integer = dv_chuachon.Count - 1 To 0 Step -1
                If dv_chuachon.Item(i)("Chon") Then
                    clsDSXetLenLop.Update_XetLenLop_KhiDuyet(dv_chuachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, 1)
                End If
            Next

            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 0).DefaultView
            'grcDanhSach.DataSource = dv_chuachon
            'labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 1).DefaultView
            grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN CÁNH BÁO: " & grvDanhSach_DaChon.RowCount.ToString
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv_dachon As DataView = grcDanhSach_DaChon.DataSource
            Dim dv_chuachon As DataView

            For i As Integer = dv_dachon.Count - 1 To 0 Step -1
                If dv_dachon.Item(i)("Chon") Then
                    clsDSXetLenLop.Delete_XetLenLop_DaDuyet(dv_dachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, 1)
                End If
            Next

            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            'dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
            'grcDanhSach.DataSource = dv_chuachon
            'labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 1).DefaultView
            grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN CÁNH BÁO: " & grvDanhSach_DaChon.RowCount.ToString
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

   

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dv As DataView = grcDanhSach_DaChon.DataSource
        If Not dv Is Nothing Then
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub

    Private Sub cmbLan_thu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cmbHoc_ky.Text = "" Or cmbNam_hoc.Text = "" Then Exit Sub
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            'grcDanhSach.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
            'labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao(dsID_lop, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, 1).DefaultView
            grvDanhSach_DaChon.ViewCaption = "DANH SÁCH SINH VIÊN CÁNH BÁO: " & grvDanhSach_DaChon.RowCount.ToString
        Catch ex As Exception
        End Try
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

End Class