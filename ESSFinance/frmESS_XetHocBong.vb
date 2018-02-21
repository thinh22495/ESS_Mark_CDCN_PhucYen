Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XetHocBong
    Private Loader As Boolean = False
    Private Filled_CmbID_phan_bo As Boolean = False
    Private mQuy_hb As New ESSQuyHocBong
    Private dsID_lop As String = ""
    Private dtDiem As DataTable
    Private dtChuaXet As DataTable
    Private dtDaXet As DataTable
    Private dtDSSV As DataTable
#Region "Form Event"
    Private Sub frmESS_XetHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdView)
        Fill_Combo()
        SetQuyenTruyCap(cmdProcess, , , )
        Loader = True
    End Sub
    Private Sub frmESS_XetHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_XetHocBong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdProcess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProcess.Click
        Try
            If Not CheckInputData() Then Exit Sub
            If optDa_xet.Checked Then Exit Sub
            '''''''''''''''Nhồi dữ liệu về điểm , điểm rèn luyện vào danh sách và lọc ra danh sách sinh viên đủ điều kiện xét học bổng
            Dim dt As New DataTable
            ' Danh sách kỷ luật
            Dim objKL As New KyLuat_Bussines(dsID_lop)
            Dim dtKL As DataTable
            dtKL = objKL.HienThi_ESSKyLuat(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            ' Danh sách Điểm rèn luyện
            Dim objRL As New DiemRenLuyen_Bussines(dsID_lop)
            Dim dtRL As DataTable
            dtRL = objRL.TongHop_DiemRenLuyenKy(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            ' Danh sách Sinh viên được xét   
            Dim TongTien_HB_CS As Integer = 0
            Dim clsXetHocBong As New DanhSachHocBong_Bussines(dsID_lop, cmbHoc_ky.Text, cmbNam_hoc.Text)
            dt = clsXetHocBong.DanhSachSV_XetHocBong(dtDSSV, dtDiem, dtKL, dtRL, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, TongTien_HB_CS) ' Danh sách viên đủ điều kiện xét học bổng            
            '''''''''''''''
            Dim obj As New ESSDanhSachHocBong
            Dim dtXet As DataTable
            Dim So_tien_da_xet As Integer = 0
            Dim So_tien_xet As Integer = CInt(txtTong_sotien.Text) ' Số tiền còn lại để xét
            Dim dtLoaHB As DataTable
            Dim clsLoaiHB As New LoaiHocBong_Bussines()
            dtLoaHB = clsLoaiHB.HienThi_ESSLoaiHocBong()
            dtXet = clsXetHocBong.XetHocBong(cmbID_he.SelectedValue, dt, dtLoaHB, So_tien_da_xet, So_tien_xet) ' Xét học bổng cho danh sách sv đủ điều kiện xét (dt)
            txtSotien_chi.Text = Format(So_tien_da_xet, "###,###")
            txtSotien_con.Text = Format(So_tien_xet - (So_tien_da_xet), "###,###")
            ' Ghi lại 
            ' Xóa xét cũ
            clsXetHocBong.Xoa_ESSDanhSachHocBong(cmbID_phan_bo.SelectedValue)
            For Each r As DataRow In dtXet.Rows ' Cập nhật danh sách sinh viên đã được xét
                obj.ID_sv = r("ID_sv")
                obj.ID_phan_bo = cmbID_phan_bo.SelectedValue
                obj.ID_xep_loai_hb = r("ID_xep_loai_hb")
                obj.HB_HT = IIf(r("HB_HT").ToString = "", 0, r("HB_HT"))
                obj.HB_CS = IIf(r("HB_CS").ToString = "", 0, r("HB_CS"))
                clsXetHocBong.ThemMoi_ESSDanhSachHocBong(obj)
            Next

            cmbID_phan_bo_SelectedIndexChanged(sender, e)
            optDa_xet_CheckedChanged(sender, e)
            txtSo_sv.Text = dtXet.Rows.Count
            lblNum_sv.Text = dtXet.Rows.Count
            optDa_xet.Checked = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_ds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_ds.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dv As New DataView
            dv = grdView.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim Tieu_de1 As String = ""
            If optChua_xet.Checked Then Tieu_de1 = "DANH SÁCH SINH VIÊN CHƯA XÉT HỌC BỔNG"
            If optDa_xet.Checked Then Tieu_de1 = "DANH SÁCH SINH VIÊN ĐÃ XÉT HỌC BỔNG"
            Dim Tieu_de2 As String = ""
            Tieu_de2 = "Học kỳ : " & cmbHoc_ky.SelectedValue + 1 & " Năm học : " & cmbNam_hoc.Text & ")"
            Dim Tieu_de3 As String = ""
            If Not cmbID_phan_bo.SelectedValue Is Nothing Then Tieu_de3 = cmbID_phan_bo.Text.Trim
            Dim frmESS_ As New frmESS_ReportView
            If optChua_xet.Checked Then
                frmESS_.ShowDialog("RpDanhSach_ChuaXet_HocBong_A4ngang", dv.Table, Tieu_de1, Tieu_de2, Tieu_de3, )
            Else
                frmESS_.ShowDialog("RpDanhSachHocBong_A4ngang", dv.Table, Tieu_de1, Tieu_de2, Tieu_de3, )
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_HBHT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_HBHT.Click
        Try
            If optDa_xet.Checked = False Then Exit Sub
            Dim dt As DataTable
            Dim clsXetHB As New DanhSachHocBong_Bussines
            Dim dv As New DataView
            dv = grdView.DataSource
            If dv Is Nothing Then Exit Sub
            dt = clsXetHB.BaoCao_TongHop(dv.Table, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            Dim dtSub As New DataTable
            dtSub.Columns.Add("Ten_phan_bo")
            dtSub.Columns.Add("So_tien_duoc_phan")
            dtSub.Columns.Add("HBCS")
            dtSub.Columns.Add("HBHT")
            dtSub.Columns.Add("So_tien_con_lai")
            Dim r As DataRow
            r = dtSub.NewRow
            r("Ten_phan_bo") = cmbID_phan_bo.Text.Trim
            r("So_tien_duoc_phan") = txtTong_sotien.Text.Trim
            r("HBCS") = txtTien_trocap.Text.Trim
            r("HBHT") = txtSotien_chi.Text.Trim
            r("So_tien_con_lai") = txtSotien_con.Text.Trim
            dtSub.Rows.Add(r)
            If dt.Rows.Count = 0 Or dtSub.Rows.Count = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpTongHopXetHocBong", dt, "RpTongHopXetHocBongSub", dtSub, "RptSub")
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Thongbao("Bạn có muốn xóa sinh viên khỏi danh sách học bổng không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            If Not Me.optDa_xet.Checked Then Exit Sub
            Dim dv As DataView
            dv = grdView.DataSource
            dv.AllowDelete = True
            If dv Is Nothing Or dv.Count = 0 Then Exit Sub
            Dim idx As Integer = grdView.CurrentRow.Index
            Dim HB_HT As Double = IIf(dv.Item(idx)("HB_HT").ToString = "", 0, dv.Item(idx)("HB_HT"))
            Dim cls As New DanhSachHocBong_Bussines
            cls.Xoa_ESSDanhSachHocBong_SinhVien(cmbID_phan_bo.SelectedValue, dv.Item(idx)("ID_sv"))
            dv.Item(idx).Delete()
            dv.Table.AcceptChanges()
            grdView.DataSource = dv
            ' Tinh lại số tiền            
            Dim Tien_HBHT As Double = 0
            If txtSotien_chi.Text.ToString() <> "" Then Tien_HBHT = txtSotien_chi.Text.Trim - HB_HT
            Dim So_tien_con As Double = IIf(txtSotien_con.Text.Trim.ToString = "", 0, txtSotien_con.Text.Trim) + HB_HT
            Dim So_sv As Integer = txtSo_sv.Text - 1
            txtSotien_chi.Text = Format(Tien_HBHT, "###,###")
            txtSotien_con.Text = Format(So_tien_con, "###,###")
            txtSo_sv.Text = So_sv
            lblNum_sv.Text = So_sv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable
        dt = clsDM.DanhMuc_Load("ACC_LoaiQuy", "ID_quy", "Loai_quy")
        FillCombo(cmbID_quy, dt)
        Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        dt = clsLop.He_dao_tao()
        FillCombo(cmbID_he, dt)
    End Sub
    Private Function LoadDS_SinhVien() As DataTable
        Try
            If Not Loader Then Return Nothing
            If cmbID_phan_bo.SelectedValue <= 0 Then Return Nothing
            Dim objPb As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
            Dim objQ As New ESSQuyHocBongPhanBo
            objQ = objPb.HienThi_ESSQuyHocBongPhanBo(cmbID_phan_bo.SelectedValue)
            dsID_lop = objPb.Lop_Phan_Bo(cmbID_phan_bo.SelectedValue)

            ' Danh sách sinh viên            
            Dim objDSSV As New DanhSachSinhVien_Bussines(dsID_lop)
            dtDSSV = objDSSV.Danh_sach_sinh_vien()
            ' Diểm            
            Dim objDiem As New Diem_Bussines("P1", 0, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, dsID_lop, 0, dtDSSV)
            dtDiem = objDiem.TongHopDiemHocKy_XetHocBong(1, 2, False, False, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)

            '''''''''''''''Nhồi dữ liệu về điểm , điểm rèn luyện vào danh sách và lọc ra danh sách sinh viên đủ điều kiện xét học bổng
            Dim dt As New DataTable
            ' Danh sách kỷ luật
            Dim objKL As New KyLuat_Bussines(dsID_lop)
            Dim dtKL As DataTable
            dtKL = objKL.HienThi_ESSKyLuat(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            ' Danh sách Điểm rèn luyện
            Dim objRL As New DiemRenLuyen_Bussines(dsID_lop)
            Dim dtRL As DataTable
            dtRL = objRL.TongHop_DiemRenLuyenKy(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            ' Danh sách Sinh viên được xét   
            Dim TongTien_HB_CS As Integer = 0
            Dim obj As New DanhSachHocBong_Bussines(dsID_lop, cmbHoc_ky.Text, cmbNam_hoc.Text)
            dt = obj.DanhSachSV_XetHocBong(dtDSSV, dtDiem, dtKL, dtRL, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, TongTien_HB_CS)
            '''''''''''''''
            txtSotien_chi.Text = 0
            txtSo_sv.Text = 0
            objQ = objPb.HienThi_ESSQuyHocBongPhanBo(cmbID_phan_bo.SelectedValue)
            txtTong_sotien.Text = Format(objQ.So_tien + CInt(txtTien_trocap.Text), "###,###")
            ' Load danh sách chưa xét                            
            txtSotien_con.Text = Format(CInt(txtTong_sotien.Text), "###,###")
            Dim dt1 As DataTable
            dt1 = dt.Copy
            Dim So_tien_da_xet As Int32 = 0
            Dim So_tien_tro_cap As Int32 = 0
            dtDaXet = obj.DanhSachSV_DaXet(dt1, cmbID_phan_bo.SelectedValue, So_tien_da_xet, So_tien_tro_cap)
            dtChuaXet = obj.DanhSachSV_Chua_XetHocBong(dt1, dtDaXet)
            lblNum_sv.Text = dtChuaXet.Rows.Count
            If So_tien_da_xet > 0 Then txtSotien_chi.Text = Format(So_tien_da_xet, "###,###")
            txtSotien_con.Text = Format(CInt(txtTong_sotien.Text) - (So_tien_da_xet), "###,###")
            Return dt
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra phân bổ quỹ theo đối tượng gì
        If cmbID_phan_bo.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_phan_bo, ErrorProvider1, "Bạn hãy chọn đối phân bổ học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_phan_bo
        ElseIf cmbID_phan_bo.SelectedValue < 0 Then
            Call SetErrPro(cmbID_phan_bo, ErrorProvider1, "Bạn hãy chọn đối phân bổ học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_phan_bo
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
#End Region
#Region "Change"
    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged, cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_quy.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            ' Load dữ liệu quỹ học bổng            
            Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            mQuy_hb = obj.HienThi_ESSQuyHocBong(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbID_he.SelectedValue, cmbID_quy.SelectedValue)
            Dim dt As New DataTable
            dt.Columns.Add("ID_phan_bo")
            dt.Columns.Add("Ten_phan_bo")
            Dim objPb As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
            Dim dt1 As DataTable
            dt1 = objPb.DanhSach_QuyHocBongPhanBo()
            Dim dr As DataRow
            For Each r As DataRow In dt1.Rows
                dr = dt.NewRow
                dr("ID_phan_bo") = r("ID_phan_bo")
                dr("Ten_phan_bo") = r("Ten_phan_bo")
                dt.Rows.Add(dr)
            Next
            dt.AcceptChanges()
            Filled_CmbID_phan_bo = False
            FillCombo(cmbID_phan_bo, dt)
            Filled_CmbID_phan_bo = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbID_phan_bo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_phan_bo.SelectedIndexChanged
        Try
            If Not Filled_CmbID_phan_bo Then Exit Sub
            Dim dv As DataView = LoadDS_SinhVien.DefaultView
            dv.Sort = "ID_xep_loai_hb ASC,TBCHT10 DESC,Tong_diem_rl DESC"
            grdView.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub optChua_xet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optChua_xet.CheckedChanged
        Try
            If Not Loader Then Exit Sub
            If cmbID_phan_bo.SelectedValue Is Nothing Then Exit Sub
            Dim objPb As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
            Dim objQ As New ESSQuyHocBongPhanBo
            objQ = objPb.HienThi_ESSQuyHocBongPhanBo(cmbID_phan_bo.SelectedValue)
            dsID_lop = objPb.Lop_Phan_Bo(cmbID_phan_bo.SelectedValue)
            txtTong_sotien.Text = Format(objQ.So_tien, "###,###")
            txtSo_sv.Text = dtChuaXet.Rows.Count
            lblNum_sv.Text = dtChuaXet.Rows.Count
            grdView.DataSource = dtChuaXet.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub optDa_xet_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optDa_xet.CheckedChanged
        Try
            If Not Loader Then Exit Sub
            If cmbID_phan_bo.SelectedValue Is Nothing Then Exit Sub
            txtSotien_con.Text = Format(CInt(txtTong_sotien.Text) - (CInt("0" & txtSotien_chi.Text)), "###,###")
            txtSo_sv.Text = dtDaXet.Rows.Count
            lblNum_sv.Text = dtDaXet.Rows.Count
            If dtDaXet.Rows.Count > 0 Then
                dtDaXet.DefaultView.Sort = "ID_xep_loai_hb ASC,TBCHT10 DESC,Tong_diem_rl DESC"
                'dtDaXet.DefaultView.Sort = "ID_xep_loai_hb"
            End If
            grdView.DataSource = dtDaXet.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdView.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim titles As New ArrayList
                Dim title As XlsCommon
                If optDa_xet.Checked Then
                    title = New XlsCommon("B1", "F1", "DANH SÁCH SINH VIÊN ĐƯỢC HỌC BỔNG", New Font("Arial", 14, FontStyle.Regular), Color.Black)
                Else
                    title = New XlsCommon("B1", "F1", "DANH SÁCH SINH VIÊN KHÔNG ĐƯỢC HỌC BỔNG", New Font("Arial", 14, FontStyle.Regular), Color.Black)
                End If
                titles.Add(title)
                Dim title1 As New XlsCommon("B2", "F2", cmbID_phan_bo.Text, New Font("Arial", 12, FontStyle.Regular), Color.Black)
                titles.Add(title1)
                clsExcel.ExportFromDataGridViewToExcel(grdView, titles, 4)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
#End Region

 
End Class