Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Public Class frmESS_TongHopThuKhac
#Region "Form Event"
    Private Sub frmESS_TongHopThuKhac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()
        Fill_Combo()
        SetUpDataGridView(grdDanhSach)
    End Sub
    Private Sub frmESS_TongHopThuKhac_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_TongHopThuKhac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            Dim dsID_lop As String = trvLop.ID_lop_list
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim dv As DataView
            Dim ID_thu_chi As Integer = 0
            If cmbID_thu_chi.SelectedValue > 0 Then ID_thu_chi = cmbID_thu_chi.SelectedValue
            If chkToanKhoa.Checked Then
                dv = clsBienLai.TongHop_DanhSachSv_Nop_HocKy_New_ToanKhoa(trvLop.ID_he, , , , dsID_lop, , ID_thu_chi).DefaultView
            Else
                dv = clsBienLai.TongHop_DanhSachSv_Nop_HocKy_New(trvLop.ID_he, , cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, , ID_thu_chi).DefaultView
            End If
            dv.Sort = "Ma_sv"
            Dim dk As String = "1=1"
            If optNop_du.Checked Then dk += " And Hoan_thanh_nop=1"
            If optNop_thieu.Checked Then dk += " And Hoan_thanh_nop=0"
            dv.RowFilter = dk
            grdDanhSach.DataSource = dv
            Dim So_tien_phai_thu As Double = 0
            Dim So_tien_da_thu As Double = 0
            Dim So_tien_mien_giam As Double = 0
            Dim So_tien_con_lai As Double = 0
            For i As Integer = 0 To dv.Count - 1
                So_tien_phai_thu += dv.Item(i)("So_tien_phai_nop")
                So_tien_da_thu += dv.Item(i)("So_tien_da_nop")
                So_tien_mien_giam += dv.Item(i)("So_tien_mien_giam")
                So_tien_con_lai += dv.Item(i)("So_tien_nop")
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
        '    Dim dv As DataView
        '    If chkToanKhoa.Checked Then
        '        If cmbID_thu_chi.SelectedValue > 0 Then
        '            clsBienLai = New BienLaiThu_Bussines(0, "", dsID_lop, cmbID_thu_chi.SelectedValue, 1)
        '        Else
        '            clsBienLai = New BienLaiThu_Bussines(0, "", dsID_lop, 0, 1)
        '        End If
        '        dv = clsBienLai.TongHop_DanhSachSv_Nop_HocKy(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, chkToanKhoa.Checked, cmbID_thu_chi.SelectedValue).DefaultView
        '    Else
        '        If cmbID_thu_chi.SelectedValue > 0 Then
        '            clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, cmbID_thu_chi.SelectedValue, 1)
        '        Else
        '            clsBienLai = New BienLaiThu_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, 0, 1)
        '        End If
        '        dv = clsBienLai.TongHop_DanhSachSv_Nop_HocKy(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, dsID_lop, False, cmbID_thu_chi.SelectedValue).DefaultView
        '    End If
        '    dv.Sort = "Ma_sv"
        '    Dim dk As String = "1=1"
        '    If optNop_du.Checked Then dk += " And Hoan_thanh_nop=1"
        '    If optNop_thieu.Checked Then dk += " And Hoan_thanh_nop=0"
        '    dv.RowFilter = dk
        '    grdDanhSach.DataSource = dv
        '    Dim So_tien_phai_thu As Integer = 0
        '    Dim So_tien_da_thu As Integer = 0
        '    Dim So_tien_mien_giam As Integer = 0
        '    Dim So_tien_con_lai As Integer = 0
        '    For i As Integer = 0 To dv.Count - 1
        '        So_tien_phai_thu += dv.Item(i)("So_tien")
        '        So_tien_da_thu += dv.Item(i)("So_tien_da_nop")
        '        So_tien_mien_giam += dv.Item(i)("So_tien_mien_giam")
        '        So_tien_con_lai += dv.Item(i)("So_tien_nop")
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
            Dim dv As New DataView
            dv = grdDanhSach.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = grdDanhSach.CurrentRow.Index
            Dim frmESS_ As New frmESS_TongHopThuKhacXemChiTiet(dv.Item(idx)("ID_sv"), cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, cmbID_thu_chi.SelectedValue, trvLop.ID_lop_list, chkToanKhoa.Checked)
            frmESS_.ShowDialog()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView
            dv = grdDanhSach.DataSource
            If dv Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Loai_thu_chi As String = ""
            If Not cmbID_thu_chi.SelectedValue Is Nothing Then Loai_thu_chi = cmbID_thu_chi.Text.Trim
            If chkToanKhoa.Checked Then
                Loai_thu_chi += " Tính từ đầu khóa đến học kỳ :" & cmbHoc_ky.SelectedValue & "-Năm học:" & cmbNam_hoc.Text
            Else
                Loai_thu_chi += " Học kỳ :" & cmbHoc_ky.SelectedValue & "-Năm học:" & cmbNam_hoc.Text
            End If
            Dim Tieu_de3 As String = ""
            Tieu_de3 = trvLop.Tieu_de
            Dim Tieu_de4 As String = ""
            If optNop_du.Checked Then Tieu_de4 = optNop_du.Text
            If optNop_thieu.Checked Then Tieu_de4 = optNop_thieu.Text
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSach_TongHopThuKhac", dv, , Loai_thu_chi, Tieu_de3, Tieu_de4)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
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
            'Load combobox loại thu chi
            Dim dt As DataTable
            Dim clsDm As New DanhMuc_Bussines
            dt = clsDm.DanhMuc_Load("ACC_LoaiThuChi", "ID_thu_chi", "Ten_thu_chi")
            FillCombo(cmbID_thu_chi, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class