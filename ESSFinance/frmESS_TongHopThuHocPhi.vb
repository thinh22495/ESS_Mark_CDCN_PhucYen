Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Public Class frmESS_TongHopThuHocPhi
    Private clsMonTC As New MonTinChi_Bussines
    Private Loader As Boolean = False
    Dim dv As New DataView

#Region "Form Event"
    Private Sub frmESS_TongHopThuHocPhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()
        Fill_Combo()
        LoadHocPhanTinChi()
        SetUpDataGridView(grdDanhSach)
        Loader = True
    End Sub
    Private Sub frmESS_TongHopThuHocPhi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_TongHopThuHocPhi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            Dim dsID_lop As String = trvLop.ID_lop_list
            Dim clsBienLai As BienLaiThu_Bussines
            Dim id_mon_tc As Integer = 0
            If cmbID_mon_tc.SelectedValue > 0 Then id_mon_tc = cmbID_mon_tc.SelectedValue
            If chkToanKhoa.Checked Then
                clsBienLai = New BienLaiThu_Bussines()
                dv = clsBienLai.TongHop_HocPhi_New_ToanKhoa(dtpTinhDenNgay.Value, trvLop.ID_he, , 0, "", , , trvLop.ID_lop_list).DefaultView
            Else
                clsBienLai = New BienLaiThu_Bussines()
                dv = clsBienLai.TongHop_HocPhi_New(dtpTinhDenNgay.Value, trvLop.ID_he, , id_mon_tc, "", cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, trvLop.ID_lop_list).DefaultView
            End If
            dv.Sort = "Ma_sv"
            Dim dk As String = "1=1"
            If optNop_du.Checked Then dk += " And Hoan_thanh_nop =1"
            If optNop_thieu.Checked Then dk += " And Hoan_thanh_nop=0"
            If chkRemove.Checked Then dk += " And So_tien_nop<>0"
            dv.RowFilter = dk
            grdDanhSach.DataSource = dv
            Dim So_tien_phai_thu As Double = 0
            Dim So_tien_da_thu As Double = 0
            Dim So_tien_mien_giam As Double = 0
            Dim So_tien_con_lai As Double = 0
            For i As Integer = 0 To dv.Count - 1
                So_tien_phai_thu += IIf(dv.Item(i)("So_tien_phai_nop").ToString = "", 0, dv.Item(i)("So_tien_phai_nop"))
                So_tien_da_thu += IIf(dv.Item(i)("So_tien_da_nop").ToString = "", 0, dv.Item(i)("So_tien_da_nop"))
                So_tien_mien_giam += IIf(dv.Item(i)("So_tien_mien_giam").ToString = "", 0, dv.Item(i)("So_tien_mien_giam"))
                So_tien_con_lai += IIf(dv.Item(i)("So_tien_nop").ToString = "", 0, dv.Item(i)("So_tien_nop"))
            Next
            lblSo_tien_phai_thu.Text = Format(So_tien_phai_thu, "###,###")
            lblSo_tien_da_thu.Text = Format(So_tien_da_thu, "###,###")
            lblSo_tien_mien_giam.Text = Format(So_tien_mien_giam, "###,###")
            lblSo_tien_con_lai.Text = Format(So_tien_con_lai, "###,###")
            lblSo_SV.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        'Try
        '    Dim dsID_lop As String = trvLop.ID_lop_list
        '    Dim clsBienLai As BienLaiThu_Bussines
        '    Dim cls As New DanhSachSinhVien_Bussines()
        '    Dim dtsv As DataTable = cls.Danh_sach_sinh_vien(dsID_lop)
        '    Dim id_mon As Integer = 0
        '    If cmbID_mon.SelectedValue > 0 Then id_mon = cmbID_mon.SelectedValue
        '    If chkToanKhoa.Checked Then
        '        clsBienLai = New BienLaiThu_Bussines()
        '        dv = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_2(dtsv, trvLop.ID_he).DefaultView
        '    Else
        '        clsBienLai = New BienLaiThu_Bussines()
        '        dv = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_1(dtsv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he, id_mon).DefaultView
        '    End If

        '    dv.Sort = "Ma_sv"
        '    Dim dk As String = "1=1"
        '    If optNop_du.Checked Then dk += " And Hoan_thanh_nop =1"
        '    If optNop_thieu.Checked Then dk += " And Hoan_thanh_nop=0"
        '    If chkRemove.Checked Then dk += " And So_tien_nop<>0"
        '    dv.RowFilter = dk
        '    grdDanhSach.DataSource = dv
        '    Dim So_tien_phai_thu As Double = 0
        '    Dim So_tien_da_thu As Double = 0
        '    Dim So_tien_mien_giam As Double = 0
        '    Dim So_tien_con_lai As Double = 0
        '    For i As Integer = 0 To dv.Count - 1
        '        So_tien_phai_thu += IIf(dv.Item(i)("So_tien").ToString = "", 0, dv.Item(i)("So_tien"))
        '        So_tien_da_thu += IIf(dv.Item(i)("So_tien_da_nop").ToString = "", 0, dv.Item(i)("So_tien_da_nop"))
        '        So_tien_mien_giam += IIf(dv.Item(i)("So_tien_mien_giam").ToString = "", 0, dv.Item(i)("So_tien_mien_giam"))
        '        So_tien_con_lai += IIf(dv.Item(i)("So_tien_nop").ToString = "", 0, dv.Item(i)("So_tien_nop"))
        '    Next
        '    lblSo_tien_phai_thu.Text = Format(So_tien_phai_thu, "###,###")
        '    lblSo_tien_da_thu.Text = Format(So_tien_da_thu, "###,###")
        '    lblSo_tien_mien_giam.Text = Format(So_tien_mien_giam, "###,###")
        '    lblSo_tien_con_lai.Text = Format(So_tien_con_lai, "###,###")
        '    lblSo_SV.Text = dv.Count
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub cmdViewChiTiet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdViewChiTiet.Click
        Try
            Dim dv1 As New DataView
            dv1 = grdDanhSach.DataSource
            If dv1.Count = 0 Then Exit Sub
            Dim idx As Integer = grdDanhSach.CurrentRow.Index
            Dim ID_mon As Integer = 0
            If Not cmbID_mon_tc.SelectedValue Is Nothing Then ID_mon = cmbID_mon_tc.SelectedValue
            Dim frmESS_ As New frmESS_TongHopThuHocPhiXemChiTiet(dv1.Item(idx)("ID_sv"), cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, ID_mon, cmbKy_hieu_lop.Text.Trim, trvLop.ID_lop_list, chkToanKhoa.Checked)
            frmESS_.ShowDialog()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Try
            If grdDanhSach.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDataGridViewToExcel(grdDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Try
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadHocPhanTinChi()
        Dim KyDangKy As Integer = clsMonTC.getKyDangKy(0, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        clsMonTC = New MonTinChi_Bussines(KyDangKy)
        Dim dt As DataTable
        dt = clsMonTC.DanhSachHocPhan
        FillCombo(cmbID_mon_tc, dt, "ID_mon", "Ten_mon")
    End Sub
#End Region
#Region "Change"
    Private Sub LoadHocPhanTinChi(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                LoadHocPhanTinChi()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmbID_mon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon_tc.SelectedIndexChanged
        Try
            Dim dt As DataTable
            dt = clsMonTC.DanhSachKyHieuLop(cmbID_mon_tc.SelectedValue)
            FillCombo(cmbKy_hieu_lop, dt, "Ky_hieu_lop_tc", "Ky_hieu_lop_tc")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub cmdPrintM1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If trvLop.Khoa_hoc = 0 Then
                Thongbao("Bạn phải chọn đến khóa học trên cây quản lý lớp !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim dsID_lop As String = "0"
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim dtLop As DataTable = clsBienLai.HienThi_ESSLop_Khoa(trvLop.Khoa_hoc)
            For i As Integer = 0 To dtLop.Rows.Count - 1
                dsID_lop += "," & dtLop.Rows(i)("ID_lop")
            Next
            Dim dtTH As DataTable
            Dim cls As New DanhSachSinhVien_Bussines()
            Dim dtsv As DataTable = cls.Danh_sach_sinh_vien(dsID_lop)
            clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, 2, 1) ' 2 thu học phí : tam thòi gán la 2            
            dtTH = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_1(dtsv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he, cmbID_mon_tc.SelectedValue)
            Dim dt As New DataTable
            dt.Columns.Add("ID_lop")
            dt.Columns.Add("Ten_lop")
            dt.Columns.Add("ID_khoa")
            dt.Columns.Add("Ten_khoa")
            dt.Columns.Add("So_sv")
            dt.Columns.Add("So_sv_mien")
            dt.Columns.Add("So_sv_nop100")
            dt.Columns.Add("So_sv_nop50")
            dt.Columns.Add("So_sv_da_nop100")
            dt.Columns.Add("So_sv_da_nop50")
            dt.Columns.Add("So_sv_chua_nop100")
            dt.Columns.Add("So_sv_chua_nop50")
            dt.Columns.Add("So_tien_nop100", GetType(Double))
            dt.Columns.Add("So_tien_nop50", GetType(Double))
            dt.Columns.Add("So_tien_da_nop100", GetType(Double))
            dt.Columns.Add("So_tien_da_nop50", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop100", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop50", GetType(Double))
            dt.Columns.Add("Tong_tien_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_da_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_chua_nop", GetType(Double))
            Dim r As DataRow
            For i As Integer = 0 To dtLop.Rows.Count - 1
                r = dt.NewRow
                r("ID_lop") = dtLop.Rows(i)("ID_lop")
                r("Ten_lop") = dtLop.Rows(i)("Ten_lop")
                r("ID_khoa") = dtLop.Rows(i)("ID_khoa")
                r("Ten_khoa") = dtLop.Rows(i)("Ten_khoa")
                ' Tong so sinh vien
                Dim dk As String = "1=1"
                dk += " And ID_lop=" & dtLop.Rows(i)("ID_lop")
                dtTH.DefaultView.RowFilter = dk
                If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
                ' Dem so sv mien 100
                Dim dk1 As String = dk & " And So_tien_nop=0"
                dtTH.DefaultView.RowFilter = dk1
                If dtTH.DefaultView.Count > 0 Then r("So_sv_mien") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 100                
                Dim dk2 As String = dk & " And So_tien_mien_giam=0"
                dtTH.DefaultView.RowFilter = dk2
                Dim So_tien_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop100 > 0 Then r("So_tien_nop100") = So_tien_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 50 
                Dim dk3 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 "
                dtTH.DefaultView.RowFilter = dk3
                Dim So_tien_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop50 > 0 Then r("So_tien_nop50") = So_tien_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop50") = dtTH.DefaultView.Count
                If So_tien_nop100 + So_tien_nop50 > 0 Then r("Tong_tien_nop") = So_tien_nop100 + So_tien_nop50

                ' Dem so sinh vien da nop 100                
                Dim dk4 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk4
                Dim So_tien_da_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop100 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop100 > 0 Then r("So_tien_da_nop100") = So_tien_da_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien da nop 50 
                Dim dk5 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk5
                Dim So_tien_da_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop50 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop50 > 0 Then r("So_tien_da_nop50") = So_tien_da_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop50") = dtTH.DefaultView.Count
                If So_tien_da_nop100 + So_tien_da_nop50 > 0 Then r("Tong_tien_da_nop") = So_tien_da_nop100 + So_tien_da_nop50

                ' Dem so sinh vien chua nop 100                
                Dim dk6 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk6
                Dim So_tien_chua_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop100 > 0 Then r("So_tien_chua_nop100") = So_tien_chua_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien chua nop 50 
                Dim dk7 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk7
                Dim So_tien_chua_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop50 > 0 Then r("So_tien_chua_nop50") = So_tien_chua_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop50") = dtTH.DefaultView.Count
                If So_tien_chua_nop100 + So_tien_chua_nop50 > 0 Then r("Tong_tien_chua_nop") = So_tien_chua_nop100 + So_tien_chua_nop50
                dt.Rows.Add(r)
            Next
            Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ KHÓA : " & trvLop.Khoa_hoc.ToString.ToUpper
            Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa", dt, tieu_de1, tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrintM2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If trvLop.Khoa_hoc = 0 Then
                Thongbao("Bạn phải chọn đến khóa học trên cây quản lý lớp !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim dsID_lop As String = "0"
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim dtLop As DataTable = clsBienLai.HienThi_ESSLop_Khoa(trvLop.Khoa_hoc)
            For i As Integer = 0 To dtLop.Rows.Count - 1
                dsID_lop += "," & dtLop.Rows(i)("ID_lop")
            Next
            Dim dtTH As DataTable
            Dim cls As New DanhSachSinhVien_Bussines()
            Dim dtsv As DataTable = cls.Danh_sach_sinh_vien(dsID_lop)
            clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, 2, 1) ' 2 thu học phí : tam thòi gán la 2            
            dtTH = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_1(dtsv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he, cmbID_mon_tc.SelectedValue)
            Dim dt As New DataTable
            dt.Columns.Add("ID_lop")
            dt.Columns.Add("Ten_lop")
            dt.Columns.Add("ID_khoa")
            dt.Columns.Add("Ten_khoa")
            dt.Columns.Add("So_sv")
            dt.Columns.Add("So_sv_mien100")
            dt.Columns.Add("So_sv_phai_nop")
            dt.Columns.Add("So_sv_da_nop")
            dt.Columns.Add("So_sv_chua_nop")
            dt.Columns.Add("So_tien_phai_nop", GetType(Double))
            dt.Columns.Add("So_tien_da_nop", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop", GetType(Double))
            Dim r As DataRow
            For i As Integer = 0 To dtLop.Rows.Count - 1
                r = dt.NewRow
                r("ID_lop") = dtLop.Rows(i)("ID_lop")
                r("Ten_lop") = dtLop.Rows(i)("Ten_lop")
                r("ID_khoa") = dtLop.Rows(i)("ID_khoa")
                r("Ten_khoa") = dtLop.Rows(i)("Ten_khoa")

                ' Tong so sinh vien phải nộp học phí
                Dim dk As String = "1=1"
                dk += " And ID_lop=" & dtLop.Rows(i)("ID_lop")
                dtTH.DefaultView.RowFilter = dk
                If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
                ' Tong so sinh vien mien 100
                Dim dkmien = dk & " And So_tien_nop=0"
                dtTH.DefaultView.RowFilter = dkmien
                If dtTH.DefaultView.Count > 0 Then r("So_sv_mien100") = dtTH.DefaultView.Count
                ' Số sinh viên phải nộp
                Dim So_sv_phai_nop As Integer = 0
                So_sv_phai_nop = IIf(r("So_sv").ToString = "", 0, r("So_sv")) - IIf(r("So_sv_mien100").ToString = "", 0, r("So_sv_mien100"))
                If So_sv_phai_nop > 0 Then r("So_sv_phai_nop") = So_sv_phai_nop
                ' Đếm số tiền phải nộp
                Dim dknop = dk & " And So_tien_nop<>0"
                dtTH.DefaultView.RowFilter = dknop
                Dim So_tien_phai_nop As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_phai_nop += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_phai_nop > 0 Then r("So_tien_phai_nop") = So_tien_phai_nop
                If dtTH.DefaultView.Count > 0 Then r("So_sv_phai_nop") = dtTH.DefaultView.Count

                ' Dem so sinh vien da nop                
                Dim dk1 As String = dk & " And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk1
                Dim So_tien_da_nop As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop > 0 Then r("So_tien_da_nop") = So_tien_da_nop
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop") = dtTH.DefaultView.Count

                ' Dem so sinh vien chua nop                
                Dim dk2 As String = dk & " And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk2
                Dim So_tien_chua_nop As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop > 0 Then r("So_tien_chua_nop") = So_tien_chua_nop
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop") = dtTH.DefaultView.Count
                dt.Rows.Add(r)
            Next
            Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ KHÓA : " & trvLop.Khoa_hoc.ToString.ToUpper
            Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa_M2", dt, tieu_de1, tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Try
            Dim dv1 As DataView
            dv1 = grdDanhSach.DataSource
            If dv1 Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Ten_mon As String = ""
            If Not cmbID_mon_tc.SelectedValue Is Nothing Then Ten_mon = " Học phần : " & cmbID_mon_tc.Text.Trim
            If chkToanKhoa.Checked Then
                Ten_mon += " Tính từ đầu khóa đến học kỳ :" & cmbHoc_ky.SelectedValue & "-Năm học:" & cmbNam_hoc.Text
            Else
                Ten_mon += " Học kỳ :" & cmbHoc_ky.SelectedValue & "-Năm học:" & cmbNam_hoc.Text
            End If
            Dim Tieu_de3 As String = ""
            Tieu_de3 = trvLop.Tieu_de
            Dim Tieu_de4 As String = ""
            If optNop_du.Checked Then Tieu_de4 = optNop_du.Text & " (Tính đến ngày " & dtpTinhDenNgay.Text & ")"
            If optNop_thieu.Checked Then Tieu_de4 = optNop_thieu.Text & " (Tính đến ngày " & dtpTinhDenNgay.Text & ")"
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSach_TongHopThuKhac", dv1, , Ten_mon, Tieu_de3, Tieu_de4)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrintLop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Try
                If trvLop.Tieu_de_Lop = "" Then
                    Thongbao("Bạn phải chọn đến lớp học trên cây danh sách lớp")
                    Exit Sub
                End If
                Me.Cursor = Cursors.WaitCursor
                Dim dt As DataTable
                Dim cls As New BienLaiThu_Bussines
                cls = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_lop_list, 2, 1)
                dt = cls.TongHop_DanhSachSv_Nop_HocPhi_TheoLop(trvLop.ID_lop_list, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he)
                Dim tieu_de1 As String = "DANH SÁCH SINH VIÊN NỘP HỌC PHÍ"
                Dim tieu_de2 As String = "LỚP :" & dt.Rows(0)("Ten_lop").ToString
                Dim tieu_de3 As String = "KHOA :" & dt.Rows(0)("Ten_khoa").ToString
                Dim tieu_de4 As String = "HỌC KỲ :" & dt.Rows(0)("Hoc_ky").ToString & " - NĂM HỌC : " & dt.Rows(0)("Nam_hoc").ToString
                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog("RpDanhSachSV_NopHocPhi_Lop", dt, tieu_de1, tieu_de2, tieu_de3, tieu_de4)
                Me.Cursor = Cursors.Default
            Catch ex As Exception
                Me.Cursor = Cursors.Default
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrintTH_HV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrintTH_HV.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            If trvLop.Khoa_hoc = 0 Then
                Thongbao("Bạn phải chọn đến khóa học trên cây quản lý lớp !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim dtTH As DataTable
            dtTH = clsBienLai.TongHop_HocPhi_New(trvLop.ID_he, trvLop.Khoa_hoc)
            Dim clsTH As New TongHopThongKe_Bussines
            Dim dvKhoa As DataView = clsTH.Khoa_Khoa_Hoc().DefaultView
            dvKhoa.RowFilter = " Khoa_hoc=" & trvLop.Khoa_hoc
            Dim dt As New DataTable
            dt.Columns.Add("Ten_khoa")
            dt.Columns.Add("Khoa_hoc")
            dt.Columns.Add("So_sv")
            dt.Columns.Add("So_sv_mien")
            dt.Columns.Add("So_sv_nop100")
            dt.Columns.Add("So_sv_nop50")
            dt.Columns.Add("So_sv_da_nop100")
            dt.Columns.Add("So_sv_da_nop50")
            dt.Columns.Add("So_sv_chua_nop100")
            dt.Columns.Add("So_sv_chua_nop50")
            dt.Columns.Add("So_tien_nop100", GetType(Double))
            dt.Columns.Add("So_tien_nop50", GetType(Double))
            dt.Columns.Add("So_tien_da_nop100", GetType(Double))
            dt.Columns.Add("So_tien_da_nop50", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop100", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop50", GetType(Double))
            dt.Columns.Add("Tong_tien_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_da_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_chua_nop", GetType(Double))
            Dim r As DataRow
            For i As Integer = 0 To dvKhoa.Count - 1
                r = dt.NewRow
                r("Ten_khoa") = dvKhoa.Item(i)("Ten_khoa")
                r("Khoa_hoc") = dvKhoa.Item(i)("Khoa_hoc")
                ' Tong so sinh vien
                Dim dk As String = "1=1"
                dk += " And Ten_khoa='" & dvKhoa.Item(i)("Ten_khoa") & "' And Khoa_hoc=" & dvKhoa.Item(i)("Khoa_hoc")
                dtTH.DefaultView.RowFilter = dk
                If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
                ' Dem so sv mien 100
                Dim dk1 As String = dk & " And So_tien_nop=0"
                dtTH.DefaultView.RowFilter = dk1
                If dtTH.DefaultView.Count > 0 Then r("So_sv_mien") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 100                
                Dim dk2 As String = dk & " And So_tien_mien_giam=0"
                dtTH.DefaultView.RowFilter = dk2
                Dim So_tien_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop100 > 0 Then r("So_tien_nop100") = So_tien_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 50 
                Dim dk3 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 "
                dtTH.DefaultView.RowFilter = dk3
                Dim So_tien_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop50 > 0 Then r("So_tien_nop50") = So_tien_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop50") = dtTH.DefaultView.Count
                If So_tien_nop100 + So_tien_nop50 > 0 Then r("Tong_tien_nop") = So_tien_nop100 + So_tien_nop50

                ' Dem so sinh vien da nop 100                
                Dim dk4 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk4
                Dim So_tien_da_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop100 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop100 > 0 Then r("So_tien_da_nop100") = So_tien_da_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien da nop 50 
                Dim dk5 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk5
                Dim So_tien_da_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop50 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop50 > 0 Then r("So_tien_da_nop50") = So_tien_da_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop50") = dtTH.DefaultView.Count
                If So_tien_da_nop100 + So_tien_da_nop50 > 0 Then r("Tong_tien_da_nop") = So_tien_da_nop100 + So_tien_da_nop50

                ' Dem so sinh vien chua nop 100                
                Dim dk6 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk6
                Dim So_tien_chua_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop100 > 0 Then r("So_tien_chua_nop100") = So_tien_chua_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien chua nop 50 
                Dim dk7 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk7
                Dim So_tien_chua_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop50 > 0 Then r("So_tien_chua_nop50") = So_tien_chua_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop50") = dtTH.DefaultView.Count
                If So_tien_chua_nop100 + So_tien_chua_nop50 > 0 Then r("Tong_tien_chua_nop") = So_tien_chua_nop100 + So_tien_chua_nop50
                dt.Rows.Add(r)
            Next
            Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ TOÀN HỌC VIỆN "
            Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa_KhoaHoc", dt, tieu_de1, tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
        'Try
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim dsID_lop As String = "0"
        '    Dim clsBienLai As New BienLaiThu_Bussines
        '    Dim dtLop As DataTable = clsBienLai.HienThi_ESSLop_Khoa(46)
        '    For i As Integer = 0 To dtLop.Rows.Count - 1
        '        dsID_lop += "," & dtLop.Rows(i)("ID_lop")
        '    Next
        '    Dim dtTH As DataTable
        '    Dim cls As New DanhSachSinhVien_Bussines()
        '    Dim dtsv As DataTable = cls.Danh_sach_sinh_vien(dsID_lop)
        '    clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, 2, 1) ' 2 thu học phí : tam thòi gán la 2            
        '    dtTH = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_1(dtsv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he, cmbID_mon.SelectedValue)
        '    Dim clsTH As New TongHopThongKe_Bussines
        '    Dim dvKhoa As DataView = clsTH.Khoa_Khoa_Hoc().DefaultView
        '    dvKhoa.RowFilter = " Khoa_hoc=46"
        '    Dim dt As New DataTable
        '    dt.Columns.Add("Ten_khoa")
        '    dt.Columns.Add("Khoa_hoc")
        '    dt.Columns.Add("So_sv")
        '    dt.Columns.Add("So_sv_mien")
        '    dt.Columns.Add("So_sv_nop100")
        '    dt.Columns.Add("So_sv_nop50")
        '    dt.Columns.Add("So_sv_da_nop100")
        '    dt.Columns.Add("So_sv_da_nop50")
        '    dt.Columns.Add("So_sv_chua_nop100")
        '    dt.Columns.Add("So_sv_chua_nop50")
        '    dt.Columns.Add("So_tien_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_nop50", GetType(Double))
        '    dt.Columns.Add("So_tien_da_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_da_nop50", GetType(Double))
        '    dt.Columns.Add("So_tien_chua_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_chua_nop50", GetType(Double))
        '    dt.Columns.Add("Tong_tien_nop", GetType(Double))
        '    dt.Columns.Add("Tong_tien_da_nop", GetType(Double))
        '    dt.Columns.Add("Tong_tien_chua_nop", GetType(Double))
        '    Dim r As DataRow
        '    For i As Integer = 0 To dvKhoa.Count - 1
        '        r = dt.NewRow
        '        r("Ten_khoa") = dvKhoa.Item(i)("Ten_khoa")
        '        r("Khoa_hoc") = dvKhoa.Item(i)("Khoa_hoc")
        '        ' Tong so sinh vien
        '        Dim dk As String = "1=1"
        '        dk += " And Ten_khoa='" & dvKhoa.Item(i)("Ten_khoa") & "' And Khoa_hoc=" & dvKhoa.Item(i)("Khoa_hoc")
        '        dtTH.DefaultView.RowFilter = dk
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
        '        ' Dem so sv mien 100
        '        Dim dk1 As String = dk & " And So_tien_nop=0"
        '        dtTH.DefaultView.RowFilter = dk1
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_mien") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien phai nop 100                
        '        Dim dk2 As String = dk & " And So_tien_mien_giam=0"
        '        dtTH.DefaultView.RowFilter = dk2
        '        Dim So_tien_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_nop100 > 0 Then r("So_tien_nop100") = So_tien_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien phai nop 50 
        '        Dim dk3 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 "
        '        dtTH.DefaultView.RowFilter = dk3
        '        Dim So_tien_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_nop50 > 0 Then r("So_tien_nop50") = So_tien_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_nop50") = dtTH.DefaultView.Count
        '        If So_tien_nop100 + So_tien_nop50 > 0 Then r("Tong_tien_nop") = So_tien_nop100 + So_tien_nop50

        '        ' Dem so sinh vien da nop 100                
        '        Dim dk4 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop <> 0"
        '        dtTH.DefaultView.RowFilter = dk4
        '        Dim So_tien_da_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_da_nop100 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
        '        Next
        '        If So_tien_da_nop100 > 0 Then r("So_tien_da_nop100") = So_tien_da_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien da nop 50 
        '        Dim dk5 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop <> 0"
        '        dtTH.DefaultView.RowFilter = dk5
        '        Dim So_tien_da_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_da_nop50 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
        '        Next
        '        If So_tien_da_nop50 > 0 Then r("So_tien_da_nop50") = So_tien_da_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop50") = dtTH.DefaultView.Count
        '        If So_tien_da_nop100 + So_tien_da_nop50 > 0 Then r("Tong_tien_da_nop") = So_tien_da_nop100 + So_tien_da_nop50

        '        ' Dem so sinh vien chua nop 100                
        '        Dim dk6 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop = 0"
        '        dtTH.DefaultView.RowFilter = dk6
        '        Dim So_tien_chua_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_chua_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_chua_nop100 > 0 Then r("So_tien_chua_nop100") = So_tien_chua_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien chua nop 50 
        '        Dim dk7 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop = 0"
        '        dtTH.DefaultView.RowFilter = dk7
        '        Dim So_tien_chua_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_chua_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_chua_nop50 > 0 Then r("So_tien_chua_nop50") = So_tien_chua_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop50") = dtTH.DefaultView.Count
        '        If So_tien_chua_nop100 + So_tien_chua_nop50 > 0 Then r("Tong_tien_chua_nop") = So_tien_chua_nop100 + So_tien_chua_nop50
        '        dt.Rows.Add(r)
        '    Next
        '    Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ TOÀN HỌC VIỆN "
        '    Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
        '    Dim frmESS_ As New frmESS_ReportView
        '    frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa_KhoaHoc", dt, tieu_de1, tieu_de2, , )
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub optNop_du_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles optNop_du.CheckedChanged
        Try
            If Not Loader Then Exit Sub
            dv.Sort = "Ma_sv"
            Dim dk As String = "1=1"
            If optNop_du.Checked Then dk += " And Hoan_thanh_nop =1"
            If optNop_thieu.Checked Then dk += " And Hoan_thanh_nop=0"
            If chkRemove.Checked Then dk += " And So_tien_nop<>0"
            dv.RowFilter = dk
            grdDanhSach.DataSource = dv
            Dim So_tien_phai_thu As Double = 0
            Dim So_tien_da_thu As Double = 0
            Dim So_tien_mien_giam As Double = 0
            Dim So_tien_con_lai As Double = 0
            For i As Integer = 0 To dv.Count - 1
                So_tien_phai_thu += IIf(dv.Item(i)("So_tien_phai_nop").ToString = "", 0, dv.Item(i)("So_tien_phai_nop"))
                So_tien_da_thu += IIf(dv.Item(i)("So_tien_da_nop").ToString = "", 0, dv.Item(i)("So_tien_da_nop"))
                So_tien_mien_giam += IIf(dv.Item(i)("So_tien_mien_giam").ToString = "", 0, dv.Item(i)("So_tien_mien_giam"))
                So_tien_con_lai += IIf(dv.Item(i)("So_tien_nop").ToString = "", 0, dv.Item(i)("So_tien_nop"))
            Next
            lblSo_tien_phai_thu.Text = Format(So_tien_phai_thu, "###,###")
            lblSo_tien_da_thu.Text = Format(So_tien_da_thu, "###,###")
            lblSo_tien_mien_giam.Text = Format(So_tien_mien_giam, "###,###")
            lblSo_tien_con_lai.Text = Format(So_tien_con_lai, "###,###")
            lblSo_SV.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButton1_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Try
            If trvLop.Khoa_hoc = 0 Then
                Thongbao("Bạn phải chọn đến khóa học trên cây quản lý lớp !")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim dtLop As DataTable = clsBienLai.HienThi_ESSLop_Khoa(trvLop.Khoa_hoc)
            Dim dtTH As DataTable
            dtTH = clsBienLai.TongHop_HocPhi_New(trvLop.ID_he, trvLop.Khoa_hoc)
            Dim dt As New DataTable
            dt.Columns.Add("ID_lop")
            dt.Columns.Add("Ten_lop")
            dt.Columns.Add("ID_khoa")
            dt.Columns.Add("Ten_khoa")
            dt.Columns.Add("So_sv")
            dt.Columns.Add("So_sv_mien")
            dt.Columns.Add("So_sv_nop100")
            dt.Columns.Add("So_sv_nop50")
            dt.Columns.Add("So_sv_da_nop100")
            dt.Columns.Add("So_sv_da_nop50")
            dt.Columns.Add("So_sv_chua_nop100")
            dt.Columns.Add("So_sv_chua_nop50")
            dt.Columns.Add("So_tien_nop100", GetType(Double))
            dt.Columns.Add("So_tien_nop50", GetType(Double))
            dt.Columns.Add("So_tien_da_nop100", GetType(Double))
            dt.Columns.Add("So_tien_da_nop50", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop100", GetType(Double))
            dt.Columns.Add("So_tien_chua_nop50", GetType(Double))
            dt.Columns.Add("Tong_tien_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_da_nop", GetType(Double))
            dt.Columns.Add("Tong_tien_chua_nop", GetType(Double))
            Dim r As DataRow
            For i As Integer = 0 To dtLop.Rows.Count - 1
                r = dt.NewRow
                r("ID_lop") = dtLop.Rows(i)("ID_lop")
                r("Ten_lop") = dtLop.Rows(i)("Ten_lop")
                r("ID_khoa") = dtLop.Rows(i)("ID_khoa")
                r("Ten_khoa") = dtLop.Rows(i)("Ten_khoa")
                ' Tong so sinh vien
                Dim dk As String = "1=1"
                dk += " And ID_lop=" & dtLop.Rows(i)("ID_lop")
                dtTH.DefaultView.RowFilter = dk
                If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
                ' Dem so sv mien 100
                Dim dk1 As String = dk & " And So_tien_nop=0"
                dtTH.DefaultView.RowFilter = dk1
                If dtTH.DefaultView.Count > 0 Then r("So_sv_mien") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 100                
                Dim dk2 As String = dk & " And So_tien_mien_giam=0"
                dtTH.DefaultView.RowFilter = dk2
                Dim So_tien_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop100 > 0 Then r("So_tien_nop100") = So_tien_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien phai nop 50 
                Dim dk3 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 "
                dtTH.DefaultView.RowFilter = dk3
                Dim So_tien_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_nop50 > 0 Then r("So_tien_nop50") = So_tien_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_nop50") = dtTH.DefaultView.Count
                If So_tien_nop100 + So_tien_nop50 > 0 Then r("Tong_tien_nop") = So_tien_nop100 + So_tien_nop50

                ' Dem so sinh vien da nop 100                
                Dim dk4 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk4
                Dim So_tien_da_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop100 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop100 > 0 Then r("So_tien_da_nop100") = So_tien_da_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien da nop 50 
                Dim dk5 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop <> 0"
                dtTH.DefaultView.RowFilter = dk5
                Dim So_tien_da_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_da_nop50 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
                Next
                If So_tien_da_nop50 > 0 Then r("So_tien_da_nop50") = So_tien_da_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop50") = dtTH.DefaultView.Count
                If So_tien_da_nop100 + So_tien_da_nop50 > 0 Then r("Tong_tien_da_nop") = So_tien_da_nop100 + So_tien_da_nop50

                ' Dem so sinh vien chua nop 100                
                Dim dk6 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk6
                Dim So_tien_chua_nop100 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop100 > 0 Then r("So_tien_chua_nop100") = So_tien_chua_nop100
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop100") = dtTH.DefaultView.Count
                ' Dem so sinh vien chua nop 50 
                Dim dk7 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop = 0"
                dtTH.DefaultView.RowFilter = dk7
                Dim So_tien_chua_nop50 As Double = 0
                For j As Integer = 0 To dtTH.DefaultView.Count - 1
                    So_tien_chua_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
                Next
                If So_tien_chua_nop50 > 0 Then r("So_tien_chua_nop50") = So_tien_chua_nop50
                If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop50") = dtTH.DefaultView.Count
                If So_tien_chua_nop100 + So_tien_chua_nop50 > 0 Then r("Tong_tien_chua_nop") = So_tien_chua_nop100 + So_tien_chua_nop50
                dt.Rows.Add(r)
            Next
            Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ KHÓA : " & trvLop.Khoa_hoc.ToString.ToUpper
            Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa", dt, tieu_de1, tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
        'Try
        '    If trvLop.Khoa_hoc = 0 Then
        '        Thongbao("Bạn phải chọn đến khóa học trên cây quản lý lớp !")
        '        Exit Sub
        '    End If
        '    Me.Cursor = Cursors.WaitCursor
        '    Dim dsID_lop As String = "0"
        '    Dim clsBienLai As New BienLaiThu_Bussines
        '    Dim dtLop As DataTable = clsBienLai.HienThi_ESSLop_Khoa(trvLop.Khoa_hoc)
        '    For i As Integer = 0 To dtLop.Rows.Count - 1
        '        dsID_lop += "," & dtLop.Rows(i)("ID_lop")
        '    Next
        '    Dim dtTH As DataTable
        '    Dim cls As New DanhSachSinhVien_Bussines()
        '    Dim dtsv As DataTable = cls.Danh_sach_sinh_vien(dsID_lop)
        '    clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, 2, 1) ' 2 thu học phí : tam thòi gán la 2            
        '    dtTH = clsBienLai.TongHop_DanhSachSv_Nop_HocPhi_1(dtsv, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, trvLop.ID_he, cmbID_mon.SelectedValue)
        '    Dim dt As New DataTable
        '    dt.Columns.Add("ID_lop")
        '    dt.Columns.Add("Ten_lop")
        '    dt.Columns.Add("ID_khoa")
        '    dt.Columns.Add("Ten_khoa")
        '    dt.Columns.Add("So_sv")
        '    dt.Columns.Add("So_sv_mien")
        '    dt.Columns.Add("So_sv_nop100")
        '    dt.Columns.Add("So_sv_nop50")
        '    dt.Columns.Add("So_sv_da_nop100")
        '    dt.Columns.Add("So_sv_da_nop50")
        '    dt.Columns.Add("So_sv_chua_nop100")
        '    dt.Columns.Add("So_sv_chua_nop50")
        '    dt.Columns.Add("So_tien_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_nop50", GetType(Double))
        '    dt.Columns.Add("So_tien_da_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_da_nop50", GetType(Double))
        '    dt.Columns.Add("So_tien_chua_nop100", GetType(Double))
        '    dt.Columns.Add("So_tien_chua_nop50", GetType(Double))
        '    dt.Columns.Add("Tong_tien_nop", GetType(Double))
        '    dt.Columns.Add("Tong_tien_da_nop", GetType(Double))
        '    dt.Columns.Add("Tong_tien_chua_nop", GetType(Double))
        '    Dim r As DataRow
        '    For i As Integer = 0 To dtLop.Rows.Count - 1
        '        r = dt.NewRow
        '        r("ID_lop") = dtLop.Rows(i)("ID_lop")
        '        r("Ten_lop") = dtLop.Rows(i)("Ten_lop")
        '        r("ID_khoa") = dtLop.Rows(i)("ID_khoa")
        '        r("Ten_khoa") = dtLop.Rows(i)("Ten_khoa")
        '        ' Tong so sinh vien
        '        Dim dk As String = "1=1"
        '        dk += " And ID_lop=" & dtLop.Rows(i)("ID_lop")
        '        dtTH.DefaultView.RowFilter = dk
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv") = dtTH.DefaultView.Count
        '        ' Dem so sv mien 100
        '        Dim dk1 As String = dk & " And So_tien_nop=0"
        '        dtTH.DefaultView.RowFilter = dk1
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_mien") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien phai nop 100                
        '        Dim dk2 As String = dk & " And So_tien_mien_giam=0"
        '        dtTH.DefaultView.RowFilter = dk2
        '        Dim So_tien_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_nop100 > 0 Then r("So_tien_nop100") = So_tien_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien phai nop 50 
        '        Dim dk3 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 "
        '        dtTH.DefaultView.RowFilter = dk3
        '        Dim So_tien_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_nop50 > 0 Then r("So_tien_nop50") = So_tien_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_nop50") = dtTH.DefaultView.Count
        '        If So_tien_nop100 + So_tien_nop50 > 0 Then r("Tong_tien_nop") = So_tien_nop100 + So_tien_nop50

        '        ' Dem so sinh vien da nop 100                
        '        Dim dk4 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop <> 0"
        '        dtTH.DefaultView.RowFilter = dk4
        '        Dim So_tien_da_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_da_nop100 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
        '        Next
        '        If So_tien_da_nop100 > 0 Then r("So_tien_da_nop100") = So_tien_da_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien da nop 50 
        '        Dim dk5 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop <> 0"
        '        dtTH.DefaultView.RowFilter = dk5
        '        Dim So_tien_da_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_da_nop50 += dtTH.DefaultView.Item(j)("So_tien_da_nop")
        '        Next
        '        If So_tien_da_nop50 > 0 Then r("So_tien_da_nop50") = So_tien_da_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_da_nop50") = dtTH.DefaultView.Count
        '        If So_tien_da_nop100 + So_tien_da_nop50 > 0 Then r("Tong_tien_da_nop") = So_tien_da_nop100 + So_tien_da_nop50

        '        ' Dem so sinh vien chua nop 100                
        '        Dim dk6 As String = dk & " And So_tien_mien_giam=0 And So_tien_da_nop = 0"
        '        dtTH.DefaultView.RowFilter = dk6
        '        Dim So_tien_chua_nop100 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_chua_nop100 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_chua_nop100 > 0 Then r("So_tien_chua_nop100") = So_tien_chua_nop100
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop100") = dtTH.DefaultView.Count
        '        ' Dem so sinh vien chua nop 50 
        '        Dim dk7 As String = dk & " And So_tien_mien_giam <> 0 And So_tien_nop <> 0 And So_tien_da_nop = 0"
        '        dtTH.DefaultView.RowFilter = dk7
        '        Dim So_tien_chua_nop50 As Double = 0
        '        For j As Integer = 0 To dtTH.DefaultView.Count - 1
        '            So_tien_chua_nop50 += dtTH.DefaultView.Item(j)("So_tien_nop")
        '        Next
        '        If So_tien_chua_nop50 > 0 Then r("So_tien_chua_nop50") = So_tien_chua_nop50
        '        If dtTH.DefaultView.Count > 0 Then r("So_sv_chua_nop50") = dtTH.DefaultView.Count
        '        If So_tien_chua_nop100 + So_tien_chua_nop50 > 0 Then r("Tong_tien_chua_nop") = So_tien_chua_nop100 + So_tien_chua_nop50
        '        dt.Rows.Add(r)
        '    Next
        '    Dim tieu_de1 As String = "TỔNG HỢP TÌNH HÌNH THU HỌC PHÍ KHÓA : " & trvLop.Khoa_hoc.ToString.ToUpper
        '    Dim tieu_de2 As String = "HỌC KỲ :" & cmbHoc_ky.SelectedValue & " NĂM HỌC : " & cmbNam_hoc.Text
        '    Dim frmESS_ As New frmESS_ReportView
        '    frmESS_.ShowDialog("RpThongKeKetQua_ThuHocPhi_TheoKhoa", dt, tieu_de1, tieu_de2, , )
        '    Me.Cursor = Cursors.Default
        'Catch ex As Exception
        '    Me.Cursor = Cursors.Default
        '    Thongbao(ex.Message)
        'End Try
    End Sub

    Private Sub trvLop_TreeNodeSelected_() Handles trvLop.TreeNodeSelected_
        If Loader Then
            Dim ID_he As Integer = trvLop.ID_he
            Dim clsDM As New DanhMuc_Bussines
            Dim strSQL As String
            If ID_he > 0 Then
                strSQL = "SELECT DISTINCT a.Ky_dang_ky,Dot,Hoc_ky,Nam_hoc FROM PLAN_HocKyDangKy_TC a INNER JOIN PLAN_HocKyDangKy_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "WHERE ID_he=" & ID_he
                Dim dv As DataView = clsDM.DanhMuc_Load(strSQL).DefaultView
                Dim str_Filter As String = "Hoc_ky=" & cmbHoc_ky.Text & " AND Nam_hoc ='" & cmbNam_hoc.Text & "'"
                dv.RowFilter = str_Filter
                FillCombo(cmbDot, dv.Table)
            End If
        End If
    End Sub

    Private Sub cmbDot_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbDot.SelectedIndexChanged
        If Loader Then
            Dim clsMonTinChi As New MonTinChi_Bussines(cmbDot.SelectedValue)
            Dim dv As DataView = clsMonTinChi.DanhSachMonTinChi.DefaultView
            dv.Sort = "Ten_mon"
            Dim dtMonTinChi As New DataTable
            dtMonTinChi.Columns.Add("ID_mon_tc", GetType(Integer))
            dtMonTinChi.Columns.Add("Ten_mon_tc", GetType(String))
            For i As Integer = 0 To dv.Count - 1
                Dim r As DataRow = dtMonTinChi.NewRow
                r("ID_mon_tc") = dv(i)("ID_mon_tc")
                r("Ten_mon_tc") = "(" & dv(i)("Ky_hieu_lop_tc") & ") " & dv(i)("Ten_mon")
                dtMonTinChi.Rows.Add(r)
            Next
            FillCombo(cmbID_mon_tc, dtMonTinChi)
        End If
    End Sub
End Class