Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_TongHop_HocPhanChungChi
    Private clsDiem As New Diem_Bussines
    Private clsChungChi As LoaiChungChiDanhSachMon_Bussines
    Private dsID_lop As String = "0"

#Region "Form Events"
    Private Sub frmESS_TongHopNoChungChi__Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewChungChiNganh11)
        SetUpDataGridView(grdViewChungChiNganh12)
        LoadComboBox()
        Me.trvLop1.HienThi_ESSTreeView()
        SetQuyenTruyCap(, cmdTongHop, btnThem1, btnXoa1)
    End Sub
    Private Sub frmESS_TongHopNoChungChi__Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable = cls.DanhMuc_Load("MARK_LoaiChungChi_TC", "ID_chung_chi", "Loai_chung_chi")
            FillCombo(cmbID_chung_chi1, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Control Events"
    Private Sub trvLop1_Select() Handles trvLop1.TreeNodeSelected_
        Try
            If Not trvLop1.ID_lop_list Is Nothing Then
                dsID_lop = trvLop1.ID_lop_list
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

#End Region

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewChungChiNganh12.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDataGridViewToExcel(grdViewChungChiNganh12)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPrint.Click
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewChungChiNganh12.DataSource Is Nothing Then
        '        Dim dv As DataView = grdViewChungChiNganh12.DataSource
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4 As String
        '        Tieu_de1 = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        '        Tieu_de2 = "Độc lập - Tự do - Hạnh phúc"
        '        Tieu_de3 = "DANH SÁCH SINH VIÊN ĐƯỢC CẤP CHỨNG CHỈ " & cmbID_chung_chi1.Text.ToUpper
        '        Tieu_de4 = trvLop1.Tieu_de.ToUpper
        '        TaoBaoCao_PhanThucTap(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4)

        '        C1Report1.DataSource.Recordset = dv.Table
        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog(C1Report1)
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbID_chung_chi1.Text.Trim = "" Or cmbLan_xet1.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại chứng chỉ và Lần xét !", MsgBoxStyle.Information)
            Else
                Me.Cursor = Cursors.WaitCursor
                clsChungChi = New LoaiChungChiDanhSachMon_Bussines(dsID_lop)

                Dim ID_dt As Integer = trvLop1.ID_dt_list
                Dim dt As DataTable = clsChungChi.DSSV_ChuaXetTheoLanXet(cmbID_chung_chi1.SelectedValue)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, ID_dt, dt)
                Dim dv As DataView = clsDiem.TongHopDiemMonChungChi(ID_dt, cmbID_chung_chi1.SelectedValue, rGDTC.Checked).DefaultView

                grdViewChungChiNganh11.DataSource = dv
                labSo_sv.Text = dv.Count
                grdViewChungChiNganh12.DataSource = clsChungChi.DSSV_DaXetTheoLanXet(cmbID_chung_chi1.SelectedValue, cmbLan_xet1.Text).DefaultView
                'End If
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optAllNganh11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllNganh11.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewChungChiNganh11.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAllNganh11.Checked
            Next
            grdViewChungChiNganh11.DataSource = dvDanhSachSinhVien
        End If
    End Sub

    Private Sub optAllNganh12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllNganh12.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewChungChiNganh12.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAllNganh12.Checked
            Next
            grdViewChungChiNganh12.DataSource = dvDanhSachSinhVien
        End If
    End Sub

    Private Sub btnThem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThem1.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbID_chung_chi1.Text.Trim = "" Or cmbLan_xet1.Text.Trim = "" Then
                Thongbao("Hãy chọn Loại chứng chỉ và Lần xét !", MsgBoxStyle.Information)
            Else
                Dim dv As DataView = grdViewChungChiNganh11.DataSource
                Dim obj As ESSLoaiChungChiDanhSachMon
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        obj = New ESSLoaiChungChiDanhSachMon
                        obj.ID_sv = dv.Item(i)("ID_sv")
                        obj.ID_dt = trvLop1.ID_dt_list
                        obj.ID_chung_chi = cmbID_chung_chi1.SelectedValue
                        obj.Lan_xet = cmbLan_xet1.Text
                        obj.ID_xep_loai = dv.Item(i)("ID_xep_loai")
                        obj.TBCHT = dv.Item(i)("TBCHT")
                        clsChungChi.ThemMoi_ESSChungChiTheoSinhVien(obj)
                    End If
                Next
                cmbID_chung_chi1_SelectedIndexChanged(sender, e)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnXoa1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXoa1.Click
        Try
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            Dim obj As ESSLoaiChungChiDanhSachMon
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") = True Then
                    obj = New ESSLoaiChungChiDanhSachMon
                    obj.ID_sv = dv.Item(i)("ID_sv")
                    obj.ID_dt = dv.Item(i)("ID_dt")
                    obj.ID_chung_chi = dv.Item(i)("ID_chung_chi")
                    obj.Lan_xet = dv.Item(i)("Lan_xet")
                    clsChungChi.Xoa_ESSChungChiTheoSinhVien(obj)
                End If
            Next
            cmbID_chung_chi1_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_chung_chi1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chung_chi1.SelectedIndexChanged, cmbLan_xet1.SelectedIndexChanged
        Try
            If cmbID_chung_chi1.Text.Trim <> "" And cmbLan_xet1.Text.Trim <> "" And trvLop1.ID_chuyen_nganh > 0 Then
                Dim ID_dt As Integer = trvLop1.ID_dt_list
                clsChungChi = New LoaiChungChiDanhSachMon_Bussines(dsID_lop)
                Dim dt As DataTable = clsChungChi.DSSV_ChuaXetTheoLanXet(cmbID_chung_chi1.SelectedValue)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, 0, "", dsID_lop, ID_dt, dt)
                Dim dv As DataView = clsDiem.TongHopDiemMonChungChi(ID_dt, cmbID_chung_chi1.SelectedValue, rGDTC.Checked).DefaultView

                grdViewChungChiNganh11.DataSource = dv
                labSo_sv.Text = dv.Count
                grdViewChungChiNganh12.DataSource = clsChungChi.DSSV_DaXetTheoLanXet(cmbID_chung_chi1.SelectedValue, cmbLan_xet1.Text).DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub Print_GDTC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Print_GDTC.Click

    End Sub

    Private Sub btnSave_SoVaoSo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave_SoVaoSo.Click
        Try
            clsChungChi = New LoaiChungChiDanhSachMon_Bussines
            If txtDo_dai_So_van_bang.Text = "" Or (txtDo_dai_So_van_bang.Text.Trim <> "" AndAlso Not IsNumeric(txtDo_dai_So_van_bang.Text.Trim)) Or txtTien_to_SoVaoSo.Text.Trim = "" Or txtTu_So_SoVaoSo.Text = "" Or (txtTu_So_SoVaoSo.Text.Trim <> "" AndAlso Not IsNumeric(txtTu_So_SoVaoSo.Text.Trim)) Then
                Thongbao("Hãy nhập tiền tố và số vào sổ bắt đầu !")
                Exit Sub
            End If
            Dim Tu_so As String = txtTu_So_SoVaoSo.Text
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            Dim Do_dai As Integer = txtDo_dai_So_van_bang.Text.Trim
            Dim mSo_vang_bang As String = ""
            Tu_so = Tu_so - 1
            Dim cslToChucThi As New TochucThi_Bussines()
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    Tu_so = Tu_so + 1
                    mSo_vang_bang = "0000" + Tu_so.ToString
                    dr("So_vao_so") = txtTien_to_SoVaoSo.Text.Trim & cslToChucThi.CatSoVanBang(mSo_vang_bang, Do_dai)
                    clsChungChi.CapNhat_SoVaoSo(dr("So_vao_so"), dr("ID_SV"))
                End If
            Next
            grdViewChungChiNganh12.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            clsChungChi = New LoaiChungChiDanhSachMon_Bussines
            If dtmTu_ngay.Checked = False Or dtmDen_ngay.Checked = False Then
                Thongbao("Hãy nhập đầy đủ thông tin để cập nhật  !")
                Exit Sub
            End If
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            For Each dr As DataRowView In dv
                If dr("Chon") Then
                    clsChungChi.CapNhat_ThongTin_ChungChi(dr("ID_SV"), "Trường Cao đẳng Công nghiệp Phúc Yên", dtmTu_ngay.Value, dtmDen_ngay.Value)
                End If
            Next
            Thongbao("Cập nhật thành công !", MsgBoxStyle.Information, "Thông báo !")
            trvLop1_Select()
            grdViewChungChiNganh12.DataSource = dv
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdInChungChi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInChungChi.Click
        Try
            If trvLop1.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            dv.RowFilter = "Chon='True'"
            Dim Tu_ngay As Date = FormatDateTime(dv.Item(0)("Tu_ngay"), DateFormat.ShortDate)
            Dim Den_ngay As Date = FormatDateTime(dv.Item(0)("Den_ngay"), DateFormat.ShortDate)
            Dim rpt As New rpt_InChungChiTheChat_QP(dv, Tu_ngay, Den_ngay)
            PrintXtraReport(rpt)
            optAllNganh12.Checked = False
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdInDS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInDS.Click
        Try
            Dim dv As DataView = grdViewChungChiNganh12.DataSource
            Dim Khoa_hoc As String = trvLop1.Nien_khoa
            If dv.Count > 0 Then
                Dim rpt As New rptDSCapPhatChungChiGDTC(dv, Khoa_hoc)
                PrintXtraReport(rpt)
            Else
                Thongbao("Không có dữ liệu để in !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class