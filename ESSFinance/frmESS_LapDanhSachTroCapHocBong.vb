Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_LapDanhSachTroCapHocBong
    Private Loader As Boolean = False
    Private dtSinhVien As DataTable
    Dim dvDM As New DataView
    Private Sub frmESS_LapDanhSachMienGiamHocPhi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewTroCap)
        ' Load danh mục để lấy phần trăm khi chon combo
        Dim clsDM As New DanhMuc_Bussines()
        dvDM = clsDM.DanhMuc_Load("STU_DoiTuongHocBong", "ID_dt_hb", "Sotien_trocap").DefaultView
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
        dt = clsDM.DanhMuc_Load("STU_DoiTuongHocBong", "ID_dt_hb", "Ten_dt_hb")
        FillCombo(cmbID_dt_hb, dt)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng miễn giảm
        If cmbID_dt_hb.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_dt_hb, ErrorProvider1, "Bạn hãy chọn loại đối tượng trợ cấp !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_dt_hb
        End If
        If txtSotien_trocap.Text = "" Then
            Call SetErrPro(txtSotien_trocap, ErrorProvider1, "Bạn hãy nhập vào số tiền trợ cấp !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_trocap
        ElseIf Not IsNumeric(txtSotien_trocap.Text) Then
            Call SetErrPro(txtSotien_trocap, ErrorProvider1, "Số tiền trợ cấp phải là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_trocap
        ElseIf CDbl(txtSotien_trocap.Text) <= 0 Then
            Call SetErrPro(txtSotien_trocap, ErrorProvider1, "Số tiền trợ cấp > 0. Bạn không thể thêm được !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_trocap
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
            If cmbID_dt_hb.SelectedValue Is Nothing Or dtSinhVien Is Nothing Then Exit Sub
            Dim obj As New DoiTuongTroCap_Bussines(gobjUser.dsID_lop, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
            ' Danh sách sinh viên chưa xác định tiền trợ cấp      
            Dim dvDT As New DataView
            dvDT = obj.DanhSachSVDT(dtSinhVien)
            dvDT.RowFilter = "ID_dt_hb=" & cmbID_dt_hb.SelectedValue ' Sinh viên đã xác dịnh đối tượng
            Dim dtTC As DataTable
            dtTC = obj.DanhSach_TroCap(dvDT) ' Danh sách sinh viên đã xác định tiền trợ cập            
            grdViewDanhSach.DataSource = obj.DanhSach_ChuaXacDinh_TroCap(dvDT, dtTC)
            grdViewTroCap.DataSource = dtTC.DefaultView
            labSo_miengiam.Text = dtTC.Rows.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim obj As New ESSDanhSachTroCap
            Dim obj_Bussines As New DoiTuongTroCap_Bussines
            Dim dv As New DataView
            dv = grdViewTroCap.DataSource
            If dv Is Nothing Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                obj.ID_sv = dv.Item(i)("ID_sv")
                obj.Hoc_ky = cmbHoc_ky.SelectedValue
                obj.Nam_hoc = cmbNam_hoc.Text
                obj.Sotien_trocap = dv.Item(i)("Sotien_trocap")
                If obj_Bussines.KiemTra_DanhSachTroCap(obj) Then
                    obj_Bussines.CapNhat_ESSDanhSachTroCap(obj)
                Else
                    obj_Bussines.ThemMoi_ESSDanhSachTroCap(obj)
                End If
            Next
            Thongbao("Bạn đã lập danh sách trợ cấp thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView
            dv = grdViewTroCap.DataSource
            If dv Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSachTroCap", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Try
            If grdViewTroCap.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDataGridViewToExcel(grdViewTroCap)
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
            dv1 = grdViewTroCap.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim row As DataRow
            Dim msg As String = ""
            Dim msgGT As String = ""
            Dim clsDM As New DanhMuc_Bussines()
            Dim dvDt As DataView
            dvDt = clsDM.DanhMuc_Load("STU_DoiTuongHocBong", "Ma_dt_hb", "ID_dt_hb").DefaultView
            Dim Ma_dt As String = ""
            dvDt.RowFilter = "ID_dt_hb=" & cmbID_dt_hb.SelectedValue
            If dvDt.Count > 0 Then Ma_dt = dvDt.Item(0)("Ma_dt_hb").ToString
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    Dim ms As String = ""
                    Dim dt As DataTable
                    If optGiay_to.Checked Then ' Nếu kiểm tra giấy tờ
                        Dim dtHS_nop As DataTable
                        dtHS_nop = objHoSoNop.HienThi_ESSHoSoNop(dv.Item(i)("ID_sv"))
                        dt = obj.DoiTuong_GiayTo_Thieu(dtHS_nop, Ma_dt) ' Giấy tờ còn thiếu
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
                        row("Sotien_trocap") = txtSotien_trocap.Text.Trim
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
            grdViewTroCap.DataSource = dv1
            labSo_miengiam.Text = dv1.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim obj_Bussines As New DoiTuongTroCap_Bussines
            Dim dv As New DataView
            Dim dv1 As New DataView
            dv = grdViewTroCap.DataSource
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
                    row("Sotien_trocap") = 0
                    dv.Item(i).Row.Delete()
                    dv1.Table.Rows.Add(row)
                    ' Xóa trong database
                    obj_Bussines.Xoa_ESSDanhSachTroCap(row("ID_sv"), cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
                End If
            Next
            dv.Table.AcceptChanges()
            dv1.Table.AcceptChanges()
            grdViewDanhSach.DataSource = dv1
            grdViewTroCap.DataSource = dv
            labSo_miengiam.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMa_dt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_dt_hb.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            If Not cmbID_dt_hb.SelectedValue Is Nothing Then
                ' Load phần trăm
                dvDM.RowFilter = "ID_dt_hb=" & cmbID_dt_hb.SelectedValue
                If dvDM.Count > 0 Then txtSotien_trocap.Text = IIf(IsDBNull(dvDM.Item(0)("Sotien_trocap")), 0, dvDM.Item(0)("Sotien_trocap"))
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
            dv.Item(i).Item("Chon") = optAll.Checked
        Next
        grdViewDanhSach.DataSource = dv
    End Sub

    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dv As New DataView
        dv = grdViewTroCap.DataSource
        If dv.Count = 0 Then Exit Sub
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i).Item("Chon") = optAll1.Checked
        Next
        grdViewTroCap.DataSource = dv
    End Sub
#End Region
End Class