Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_LapDanhSachMienGiamHocPhi
    Private Loader As Boolean = False
    Private dtSinhVien As DataTable
    Dim dvDM As New DataView

    Private Sub frmESS_LapDanhSachMienGiamHocPhi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_LapDanhSachMienGiamHocPhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewMienGiam)
        ' Load danh mục để lấy phần trăm khi chon combo
        Dim clsDM As New DanhMuc_Bussines()
        dvDM = clsDM.DanhMuc_Load("STU_DoiTuong", "ID_dt", "Phan_tram_mien_giam").DefaultView
        SetQuyenTruyCap(cmdSave, cmdAdd, , cmdRemove)
        Loader = True
    End Sub
    Private Sub frmESS_LapDanhSachMienGiamHocPhi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        If Not trvLop.ID_lop_list Is Nothing Then
            Dim objDanhSach As New DanhSachSinhVien_Bussines(trvLop.ID_lop_list)
            dtSinhVien = objDanhSach.Danh_sach_sinh_vien
            grdViewDanhSach.DataSource = dtSinhVien.DefaultView
            HienThi_ESSData()
        End If
    End Sub
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        'Load combobox doi tuong chinh sach
        Dim clsDM As New DanhMuc_Bussines()
        Dim dt As DataTable
        dt = clsDM.DanhMuc_Load("STU_DoiTuong", "ID_dt", "Ten_dt")
        FillCombo(cmbMa_dt, dt)

        dt = clsDM.DanhMuc_Load("STU_doituonghocbong", "ID_dt_hb", "Ten_dt_hb")
        FillCombo(cmbID_doituong_tc, dt)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng miễn giảm
        If cmbMa_dt.SelectedValue Is Nothing Then
            Call SetErrPro(cmbMa_dt, ErrorProvider1, "Bạn hãy chọn loại đối tượng miễn giảm !")
            If CtrlErr Is Nothing Then CtrlErr = cmbMa_dt
        End If
        If txtPhan_tram.Text = "" Then
            Call SetErrPro(txtPhan_tram, ErrorProvider1, "Bạn hãy nhập vào phần trăm miễn giảm !")
            If CtrlErr Is Nothing Then CtrlErr = txtPhan_tram
        ElseIf Not IsNumeric(txtPhan_tram.Text) Then
            Call SetErrPro(txtPhan_tram, ErrorProvider1, "Phần trăm miễn giảm phải là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtPhan_tram
        ElseIf CDbl(txtPhan_tram.Text) > 100 Then
            Call SetErrPro(txtPhan_tram, ErrorProvider1, "Phần trăm miễn giảm > 100. Bạn không thể thêm được !")
            If CtrlErr Is Nothing Then CtrlErr = txtPhan_tram
        ElseIf CDbl(txtPhan_tram.Text) <= 0 Then
            Call SetErrPro(txtPhan_tram, ErrorProvider1, "Phần trăm miễn giảm > 0. Bạn không thể thêm được !")
            If CtrlErr Is Nothing Then CtrlErr = txtPhan_tram
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    ' Load data
    Public Sub HienThi_ESSData()
        Try
            If cmbMa_dt.SelectedValue Is Nothing Or dtSinhVien Is Nothing Then Exit Sub
            Dim obj As New DanhSachMienGiamHocPhi_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, gobjUser.dsID_lop)
            ' Danh sách sinh viên chưa miễn giảm       
            Dim dvMG As New DataView
            dvMG = obj.DanhSach_ChuaMienGiam(dtSinhVien, cmbMa_dt.SelectedValue, cmbID_doituong_tc.SelectedValue)
            grdViewDanhSach.DataSource = dvMG
            ' Danh sách sinh viên được miễn giảm    
            Dim dv As New DataView
            dv = obj.DanhSach_MienGiam(dtSinhVien, cmbMa_dt.SelectedValue)
            grdViewMienGiam.DataSource = dv
            labSo_miengiam.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim obj As New ESSDanhSachMienGiamHocPhi
            Dim obj_Bussines As New DanhSachMienGiamHocPhi_Bussines
            Dim dv As New DataView
            dv = grdViewMienGiam.DataSource
            If dv Is Nothing Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                obj.ID_sv = dv.Item(i)("ID_sv")
                obj.Hoc_ky = cmbHoc_ky.SelectedValue
                obj.Nam_hoc = cmbNam_hoc.Text
                obj.Phan_tram = dv.Item(i)("Phan_tram")
                If obj_Bussines.KiemTra_DanhSachMienGiamHocPhi(obj) Then
                    obj_Bussines.CapNhat_ESSDanhSachMienGiamHocPhi(obj)
                Else
                    obj_Bussines.ThemMoi_ESSDanhSachMienGiamHocPhi(obj)
                End If
            Next
            Thongbao("Bạn đã lập danh sách miễn giảm học phí thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView
            dv = grdViewMienGiam.DataSource
            If dv Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSachMienGiamHocPhi", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Try
            If grdViewMienGiam.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDataGridViewToExcel(grdViewMienGiam)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim objHoSoNop As New HoSoNop_Bussines(gobjUser.dsID_lop) ' Hồ sơ nộp   
            Dim obj As New DanhSachMienGiamHocPhi_Bussines
            If Not CheckInputData() Then Exit Sub
            Dim dv As New DataView
            Dim dv1 As New DataView
            dv = grdViewDanhSach.DataSource
            dv1 = grdViewMienGiam.DataSource
            If dv Is Nothing Then Exit Sub
            Dim row As DataRow
            Dim msg As String = ""
            Dim msgGT As String = ""
            Dim clsDM As New DanhMuc_Bussines()
            Dim dvDt As DataView
            dvDt = clsDM.DanhMuc_Load("STU_DoiTuong", "Ma_dt", "ID_dt").DefaultView
            Dim Ma_dt As String = ""
            dvDt.RowFilter = "ID_dt=" & cmbMa_dt.SelectedValue
            If dvDt.Count > 0 Then Ma_dt = dvDt.Item(0)("Ma_dt").ToString
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    Dim ms As String = ""
                    Dim dt As DataTable
                    If optGiay_to.Checked Then ' Nếu kiểm tra giấy tờ
                        Dim dtHS_nop As DataTable
                        dtHS_nop = objHoSoNop.HienThi_ESSHoSoNop(dv.Item(i)("ID_sv"))
                        dt = obj.DoiTuong_GiayTo_Thieu(dtHS_nop, Ma_dt)
                        If dt.Rows.Count > 0 Then
                            ms += " " & dv.Item(i)("Ho_ten")
                            For Each r As DataRow In dt.Rows
                                msgGT += " " & r("Ten_giay_to").ToString & ","
                            Next
                            msgGT = msgGT.Substring(0, msgGT.Length - 1)
                        End If
                    Else
                        ms = ""
                    End If
                    If ms = "" Then
                        row = dv1.Table.NewRow
                        row("Chon") = False
                        row("ID_sv") = dv.Item(i)("ID_sv")
                        row("Ma_sv") = dv.Item(i)("Ma_sv")
                        row("Ho_ten") = dv.Item(i)("Ho_ten")
                        row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                        row("Phan_tram") = txtPhan_tram.Text.Trim
                        dv.Item(i).Row.Delete()
                        dv1.Table.Rows.Add(row)
                    End If
                    msg += ms
                End If
            Next
            If msg <> "" Then Thongbao(msg & " Chưa nộp đủ các loại giấy tờ sau : " & msgGT.ToUpper)
            dv.Table.AcceptChanges()
            dv1.Table.AcceptChanges()
            grdViewDanhSach.DataSource = dv
            grdViewMienGiam.DataSource = dv1
            labSo_miengiam.Text = dv1.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim obj_Bussines As New DanhSachMienGiamHocPhi_Bussines
            Dim dv As New DataView
            Dim dv1 As New DataView
            dv = grdViewMienGiam.DataSource
            dv1 = grdViewDanhSach.DataSource
            If dv Is Nothing Then Exit Sub
            Dim row As DataRow
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    row = dv1.Table.NewRow
                    row("Chon") = False
                    row("ID_sv") = dv.Item(i)("ID_sv")
                    row("Ma_sv") = dv.Item(i)("Ma_sv")
                    row("Ho_ten") = dv.Item(i)("Ho_ten")
                    row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                    dv.Item(i).Row.Delete()
                    dv1.Table.Rows.Add(row)
                    ' Xóa trong database
                    obj_Bussines.Xoa_ESSDanhSachMienGiamHocPhi(row("ID_sv"), cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
                End If
            Next
            dv.Table.AcceptChanges()
            dv1.Table.AcceptChanges()
            grdViewDanhSach.DataSource = dv1
            grdViewMienGiam.DataSource = dv
            labSo_miengiam.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMa_dt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMa_dt.SelectedIndexChanged, cmbID_doituong_tc.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            If Not cmbMa_dt.SelectedValue Is Nothing Then
                ' Load phần trăm
                dvDM.RowFilter = "ID_dt=" & cmbMa_dt.SelectedValue
                If dvDM.Count > 0 Then txtPhan_tram.Text = IIf(IsDBNull(dvDM.Item(0)("Phan_tram_mien_giam")), 0, dvDM.Item(0)("Phan_tram_mien_giam"))
                HienThi_ESSData()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        If Not Loader Then Exit Sub
        HienThi_ESSData()
    End Sub
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dv As New DataView
        dv = grdViewDanhSach.DataSource
        If dv.Count = 0 Then Exit Sub
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i).Row.Item("Chon") = optAll.Checked
        Next
        grdViewDanhSach.DataSource = dv
    End Sub

    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dv As New DataView
        dv = grdViewMienGiam.DataSource
        If dv.Count = 0 Then Exit Sub
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i).Row.Item("Chon") = optAll1.Checked
        Next
        grdViewMienGiam.DataSource = dv
    End Sub
#End Region

    Private Sub cmbCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCopy.Click

    End Sub
End Class