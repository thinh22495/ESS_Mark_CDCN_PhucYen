Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_LapDanhSachThuKhac
    Private Loader As Boolean = False
    Private dtSinhVien As DataTable
    Dim dvDM As New DataView
    Private TH_ThiLai As Boolean = False
    Private Sub frmESS_LapDanhSachThuKhac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewThuKhac)
        ' Load danh mục để lấy số tiền khi chon combo
        Dim clsDM As New DanhMuc_Bussines()
        dvDM = clsDM.DanhMuc_Load("ACC_LoaiThuChi", "ID_thu_chi", "So_tien").DefaultView
        SetQuyenTruyCap(cmdSave, cmdAdd, , cmdRemove)
        FormatDataView_ChuaChon()
        Loader = True
    End Sub
    Private Sub frmESS_LapDanhSachThuKhac_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_LapDanhSachThuKhac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        If Not trvLop.ID_lop_list Is Nothing Then
            Dim objDanhSach As New DanhSachSinhVien_Bussines(trvLop.ID_lop_list)
            dtSinhVien = objDanhSach.Danh_sach_sinh_vien
            grdViewDanhSach.DataSource = dtSinhVien.DefaultView
            HienThi_ESSData()
        End If
    End Sub
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim obj As New ESSMucThuKhacSinhVien
            Dim obj_Bussines As New MucThuKhacSinhVien_Bussines
            Dim dv As New DataView
            dv = grdViewThuKhac.DataSource
            If dv Is Nothing Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                obj.ID_sv = dv.Item(i)("ID_sv")
                obj.Hoc_ky = dv.Item(i)("Hoc_ky")
                obj.Nam_hoc = dv.Item(i)("Nam_hoc")
                obj.ID_thu_chi = dv.Item(i)("ID_thu_chi")
                obj.So_tien = dv.Item(i)("So_tien")
                If obj_Bussines.CheckExist_svMucThuKhacSinhVien(obj) Then
                    obj_Bussines.CapNhat_ESSMucThuKhacSinhVien(obj)
                Else
                    obj_Bussines.ThemMoi_ESSMucThuKhacSinhVien(obj)
                End If
            Next
            Thongbao("Bạn đã lập danh sách thu thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView
            dv = grdViewThuKhac.DataSource
            If dv Is Nothing Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSachThuKhac", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Try
            If grdViewThuKhac.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDataGridViewToExcel(grdViewThuKhac)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim obj As New MucThuKhacSinhVien_Bussines
            If Not CheckInputData() Then Exit Sub
            Dim dv As New DataView
            Dim dv1 As New DataView
            dv = grdViewDanhSach.DataSource
            dv1 = grdViewThuKhac.DataSource
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
                    row("Hoc_ky") = cmbHoc_ky.SelectedValue
                    row("Nam_hoc") = cmbNam_hoc.Text
                    row("Ten_thu_chi") = cmbID_thu_chi.Text
                    row("ID_thu_chi") = cmbID_thu_chi.SelectedValue
                    If TH_ThiLai AndAlso dv.Item(i)("So_sv").ToString <> "" Then
                        row("So_tien") = Format(dv.Item(i)("So_sv") * CDbl(txtSo_tien.Text.Trim), "###,##0")
                    Else
                        row("So_tien") = Format(CDbl(txtSo_tien.Text.Trim), "###,##0")
                    End If
                    dv.Item(i).Row.Delete()
                    dv1.Table.Rows.Add(row)
                End If
            Next
            dv.Table.AcceptChanges()
            dv1.Table.AcceptChanges()
            labSoSv_thu.Text = dv1.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim obj_Bussines As New MucThuKhacSinhVien_Bussines
            Dim obj As New ESSMucThuKhacSinhVien
            Dim dv As New DataView
            Dim dv1 As New DataView
            dv = grdViewThuKhac.DataSource
            dv1 = grdViewDanhSach.DataSource
            If dv Is Nothing Then Exit Sub
            Dim row As DataRow
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    obj.ID_sv = dv.Item(i)("ID_sv")
                    obj.Hoc_ky = dv.Item(i)("Hoc_ky")
                    obj.Nam_hoc = dv.Item(i)("Nam_hoc")
                    obj.ID_thu_chi = dv.Item(i)("ID_thu_chi")
                    row = dv1.Table.NewRow
                    row("Chon") = False
                    row("ID_sv") = dv.Item(i)("ID_sv")
                    row("Ma_sv") = dv.Item(i)("Ma_sv")
                    row("Ho_ten") = dv.Item(i)("Ho_ten")
                    row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                    row("Hoc_ky") = cmbHoc_ky.SelectedValue
                    row("Nam_hoc") = cmbNam_hoc.Text
                    row("Ten_thu_chi") = ""
                    row("ID_thu_chi") = 0
                    row("So_tien") = 0
                    dv.Item(i).Row.Delete()
                    dv1.Table.Rows.Add(row)
                    ' Xóa trong database
                    obj_Bussines.Xoa_ESSMucThuKhacSinhVien(obj)
                End If
            Next
            dv.Table.AcceptChanges()
            dv1.Table.AcceptChanges()
            grdViewDanhSach.DataSource = dv1
            grdViewThuKhac.DataSource = dv
            labSoSv_thu.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_thu_chi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_thu_chi.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            If Not cmbID_thu_chi.SelectedValue Is Nothing Then
                ' Load phần trăm
                dvDM.RowFilter = "ID_thu_chi=" & cmbID_thu_chi.SelectedValue
                If dvDM.Count > 0 Then txtSo_tien.Text = IIf(IsDBNull(dvDM.Item(0)("So_tien")), 0, dvDM.Item(0)("So_tien"))
                HienThi_ESSData()
                FormatDataView_ChuaChon()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        If Not Loader Then Exit Sub
        HienThi_ESSData()
        FormatDataView_ChuaChon()
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
        dv = grdViewThuKhac.DataSource
        If dv.Count = 0 Then Exit Sub
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i).Row.Item("Chon") = optAll1.Checked
        Next
        grdViewThuKhac.DataSource = dv
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        'Load combobox Loại thu chi
        Dim clsDM As New DanhMuc_Bussines()
        Dim dt As DataTable
        dt = clsDM.DanhMuc_Load("ACC_LoaiThuChi", "ID_thu_chi", "Ten_thu_chi")
        FillCombo(cmbID_thu_chi, dt)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng miễn giảm
        If cmbID_thu_chi.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_thu_chi, ErrorProvider1, "Bạn hãy chọn khoản nộp !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_thu_chi
        End If
        If txtSo_tien.Text = "" Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập vào số tiền nộp !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf Not IsNumeric(txtSo_tien.Text) Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Số tiền nộp phải là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf CInt(txtSo_tien.Text) <= 0 Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Số tiền nộp phải > 0 !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
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
            TH_ThiLai = False
            Dim obj As New MucThuKhacSinhVien_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, gobjUser.dsID_lop)
            If dtSinhVien Is Nothing Then Exit Sub
            grdViewDanhSach.DataSource = obj.DanhSach_ChuaXacDinh_Thu(dtSinhVien, cmbID_thu_chi.SelectedValue).DefaultView

            Dim dv As New DataView
            dv = obj.DanhSach_Thu(dtSinhVien, cmbID_thu_chi.SelectedValue).DefaultView
            grdViewThuKhac.DataSource = dv
            labSoSv_thu.Text = dv.Count
            FormatDataView_ChuaChon()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Sub HienThi_ESSData_TongHopThiLai()
        Try
            Dim obj As New MucThuKhacSinhVien_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, gobjUser.dsID_lop)
            If dtSinhVien Is Nothing Then Exit Sub
            Dim dt_sv As DataTable = obj.DanhSach_ChuaXacDinh_Thu(dtSinhVien, cmbID_thu_chi.SelectedValue)

            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines()
            grdViewDanhSach.DataSource = clsDiem.TongHop_ThiLai(gobjUser.ID_dv, trvLop.ID_lop_list, cmbHoc_ky.Text, cmbNam_hoc.Text).DefaultView

            Dim dv As New DataView
            dv = obj.DanhSach_Thu(dtSinhVien, cmbID_thu_chi.SelectedValue).DefaultView
            grdViewThuKhac.DataSource = dv
            labSoSv_thu.Text = dv.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub FormatDataView_ChuaChon()
        Try
            grdViewDanhSach.Columns.Clear()
            Dim col1 As New DataGridViewCheckBoxColumn
            With col1
                .Name = "Chon"
                .DataPropertyName = "Chon"
                .HeaderText = "Chọn"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDanhSach.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sv"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSach.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 200
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSach.Columns.Add(col3)
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ngay_sinh"
                .DataPropertyName = "Ngay_sinh"
                .HeaderText = "Ngày sinh"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDanhSach.Columns.Add(col4)

            If TH_ThiLai Then
                Dim col5 As New DataGridViewTextBoxColumn
                With col5
                    .Name = "So_SV"
                    .DataPropertyName = "So_SV"
                    .HeaderText = "Số học phần"
                    .Width = 80
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .DefaultCellStyle.NullValue = ""
                End With
                Me.grdViewDanhSach.Columns.Add(col5)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdTongHop_ThiLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop_ThiLai.Click
        Try
            TH_ThiLai = True
            'SetUpDataGridView(grdViewDanhSach)
            FormatDataView_ChuaChon()
            HienThi_ESSData_TongHopThiLai()
        Catch ex As Exception
        End Try
    End Sub
End Class