Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Imports ESSUtility
Imports ESSReports
Public Class frmESS_NhapDiem_ThanhPhan_LopHanhChinh
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsDiem As New Diem_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private mdtDanhSachSinhVien As New DataTable

    Private xlsFileName As String = ""
    Private dt As New DataTable

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)

            Add_Hocky(cmbHoc_ky_TP)
            Add_Namhoc(cmbNam_hoc_TP)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try

            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                ''Load tat ca cac mon hoc trong CTDT khung
                'If dt.Rows.Count = 0 Then
                '    dt = clsCTDT.DanhSachMonHoc()
                'End If
                'Nếu danh sách Học phần không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CompareData(ByVal dt As DataTable, ByVal dt1 As DataTable) As Boolean
        If dt Is Nothing Or dt1 Is Nothing Then Return False
        If dt.Rows.Count <> dt1.Rows.Count Then Return False
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_mon") <> dt1.Rows(i)("ID_mon") Then
                Return False
            End If
        Next
        Return True
    End Function
    Private Sub FormatDataView()
        Try
            grdViewDiem.Columns.Clear()
            'Trạng thái
            Dim col1 As New DataGridViewImageColumn
            With col1
                .Name = "imgLock"
                .HeaderText = "TT"
                .Width = 30
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col1)
            'Mã sinh viên
            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã SV"
                .Width = 90
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col2)
            'Họ và tên
            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 180
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)
            'Các thành phần điểm
            For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    Dim col As New DataGridViewTextBoxColumn
                    With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                        'col.Name = "TP" + .ID_thanh_phan.ToString
                        col.Name = .Ky_hieu
                        'col.DataPropertyName = "TP" + .ID_thanh_phan.ToString
                        col.DataPropertyName = .Ky_hieu
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 80
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'Diem TBCBP
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "TBCBP"
                .DataPropertyName = "TBCBP"
                .HeaderText = "TBCBP"
                .Width = 80
                .DefaultCellStyle.Format = "N" + Lam_tron_TBCMH.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'Locked
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col4)
            'Số tiết nghỉ
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "So_tiet_nghi_co_phep"
                .DataPropertyName = "So_tiet_nghi_co_phep"
                .HeaderText = "Số tiết nghỉ có phép"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col7)
            'Số tiết nghỉ
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "So_tiet_nghi_khong_phep"
                .DataPropertyName = "So_tiet_nghi_khong_phep"
                .HeaderText = "Số tiết nghỉ không phép"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col8)
            'Ghi chú
            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Không đủ đk dự thi"
                .Width = 170
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col9)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub KhoaDuLieu(ByRef Lock_diem As Boolean)
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            Lock_diem = False
            Dim so_locked As Integer = 0
            Dim Checked As Boolean = False
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                Checked = False
                For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                    If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Checked Then
                        If Not grdViewDiem.Rows(i).Cells(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).Value Is Nothing _
                        AndAlso grdViewDiem.Rows(i).Cells(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).Value.ToString <> "" Then
                            Checked = True
                            Exit For
                        End If
                    End If
                Next
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    so_locked = so_locked + 1
                    If Lock_diem = False Then Lock_diem = True
                    'ReadOnly toan bo diem thanh phan bi khoa
                    For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                        If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Checked AndAlso grdViewDiem.Rows(i).Cells("Locked").Value = True Then grdViewDiem.Rows(i).Cells(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).ReadOnly = True
                    Next
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If Checked Then 'Edit
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Edit
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    Else    'Add New
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Add
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    End If
                End If
            Next
            If Not dv Is Nothing AndAlso dv.Count = so_locked Then
                'Nếu tất cả đề locked
                Lock_diem = True
            Else
                Lock_diem = False
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Doc_tham_so_he_thong()
        Dim cls As New ThamSoHeThong_Bussines
        Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
        Lam_tron_diem_thi = cls.Doc_tham_so("Lam_tron_diem_thi")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TreeViewLop.HienThi_ESSTreeView()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(cmdDiemThanhPhan, cmdSave, , cmdDelete)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemThiLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"



    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not TreeViewLop.ID_lop_list Is Nothing Then
                    dsID_lop = TreeViewLop.ID_lop_list
                    dsID_dt = TreeViewLop.ID_dt_list
                    mNien_khoa = TreeViewLop.Nien_khoa
                    'Load danh sách các Học phần trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, gobjUser.ID_Bomon)
                        'clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, 0)
                        'Load Học phần vào Combobox
                        Add_MonHoc()
                    End If
                    'Load danh sách sinh viên
                    Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    'Load danh sách điểm
                    cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
                cmbHoc_ky_TP.SelectedIndex = cmbHoc_ky.SelectedIndex
                cmbNam_hoc_TP.SelectedIndex = cmbNam_hoc.SelectedIndex
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged, cmbHoc_ky_TP.SelectedIndexChanged, cmbNam_hoc_TP.SelectedIndexChanged
        Try
            If Loader Then
                'Load danh sách điểm của sinh viên
                Dim ID_dv As String = gobjUser.ID_dv
                Dim Hoc_ky As Integer = cmbHoc_ky_TP.SelectedValue
                Dim Nam_hoc As String = cmbNam_hoc_TP.Text

                Dim Hoc_ky_main As Integer = cmbHoc_ky.SelectedValue
                Dim Nam_hoc_main As String = cmbNam_hoc.Text
                Dim ID_mon As Integer = cmbID_mon.SelectedValue
                'If chkUpdate.Checked Then Exit Sub

                If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                    'chkDefault.Visible = True
                    clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                    grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Hoc_ky, Nam_hoc).DefaultView
                Else
                    'chkDefault.Visible = False
                    grdViewDiem.DataSource = Nothing
                End If
                FormatDataView()
                Dim Lock_diem As Boolean = False
                KhoaDuLieu(Lock_diem)
                If Lock_diem = True Then
                    cmdDelete.Enabled = False
                    cmdSave.Enabled = False
                    cmdDiemThanhPhan.Enabled = False
                    btn_Cap_nhap_ly_do.Enabled = True
                Else
                    cmdDelete.Enabled = True
                    cmdSave.Enabled = True
                    cmdDiemThanhPhan.Enabled = True
                    btn_Cap_nhap_ly_do.Enabled = False
                End If
            End If
            SetQuyenTruyCap(cmdDiemThanhPhan, cmdSave, , cmdDelete)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub grdViewDiem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
        Try
            For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    If e.ColumnIndex = grdViewDiem.Columns(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu).Index Then
                        If Not grdViewDiem.CurrentCell.Value Is Nothing AndAlso grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewDiem.CurrentCell.Value) Then
                            Thongbao("Bạn phải nhập điểm là số !")
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        End If
                        If Not grdViewDiem.CurrentCell.Value Is Nothing AndAlso grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso (grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentCell.Value > 100) Then
                            Thongbao("Bạn phải nhập điểm là số từ 0 đến 100 !")
                            grdViewDiem.CurrentCell.Value = DBNull.Value
                        End If
                    End If
                End If
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdLocked_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKhoa_Diem.Click
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("ID_diem").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThanhPhanLock(dtDiem.Rows(i)("ID_diem"), 1)
                End If
            Next
            'Load lại dữ liệu điểm
            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("ID_diem").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThanhPhanLock(dtDiem.Rows(i)("ID_diem"), 0)
                End If
            Next
            'Load lại dữ liệu điểm
            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã mở khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2 As String
        '        Dim dtTP As DataTable
        '        Tieu_de1 = "BẢNG ĐIỂM THÀNH PHẦN"
        '        Tieu_de2 = "HỌC PHẦN: " + cmbID_mon.Text.ToUpper + ", " + TreeViewLop.Tieu_de.ToUpper
        '        dtTP = clsDiem.DanhSachThanhPhanChon

        '        TaoBaoCaoBangDiemThanhPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, "", dtTP)
        '        Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
        '        C1Report1.DataSource.Recordset = dtDiemTH
        '        Dim frmESS_ As New frmESS_XemBaoCao
        '        frmESS_.ShowDialog(C1Report1)
        '    Else
        '        Thongbao("Bạn phải chọn học phần trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_DanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try

            Dim dt As DataTable = grdViewDiem.DataSource.Table
            Dim dt_Main As DataTable = dt.Copy
            If dt_Main.Rows.Count > 0 Then
                dt_Main.Columns.Add("Tieu_de_Ten_truong")
                dt_Main.Columns.Add("Ten_mon")
                'dt_Main.Columns.Add("Hoc_ky")
                'dt_Main.Columns.Add("Nam_hoc")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)

                For i As Integer = 0 To dt_Main.Rows.Count - 1
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = ""
                    End If

                    dt_Main.Rows(i).Item("Ten_mon") = "Học phần: " & cmbID_mon.Text
                    dt_Main.Rows(i).Item("Hoc_ky") = cmbHoc_ky.Text
                    dt_Main.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("BangDiem_KiemTraHocPhan", dt_Main)
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdDSDiemDanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dt As DataTable = grdViewDiem.DataSource.Table
            Dim dt_Main As DataTable = dt.Copy
            If dt_Main.Rows.Count > 0 Then
                dt_Main.Columns.Add("Tieu_de_Ten_truong")
                dt_Main.Columns.Add("Tieu_de1")
                dt_Main.Columns.Add("Tieu_de2")
                'dt_Main.Columns.Add("Nam_hoc")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)

                For i As Integer = 0 To dt_Main.Rows.Count - 1
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = ""
                    End If

                    dt_Main.Rows(i).Item("Tieu_de1") = "BẢNG ĐIỂM DANH"
                    dt_Main.Rows(i).Item("Tieu_de2") = "HỌC PHẦN: " & cmbID_mon.Text.ToUpper & ", " & TreeViewLop.Tieu_de.ToUpper
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("rpDanhSachDiemDanhLopTC", dt_Main)
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chkDefault_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkDefault.CheckedChanged
        Try
            If grdViewDiem.CurrentRow Is Nothing Then Exit Sub
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim ID_thanh_phan As Integer = 0
            For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can Then
                        ID_thanh_phan = clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).ID_thanh_phan
                        For j As Integer = 0 To dtDiem.Rows.Count - 1
                            If chkDefault.Checked Then
                                dtDiem.Rows(j)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = 10
                            Else
                                dtDiem.Rows(j)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Ky_hieu) = ""
                            End If
                        Next
                    End If
                End If
            Next
            grdViewDiem.DataSource = dtDiem.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub grdViewDiem_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdViewDiem.DataError
        Try

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDiemThanhPhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDiemThanhPhan.Click
        Dim frmESS_ As New frmESS_ThayDoiThanhPhan
        Dim dtTP As DataTable = clsDiem.DanhSachThanhPhan
        If dtTP.Rows.Count > 0 Then
            frmESS_.ShowDialog(dtTP)
            'Update lai cac thanh phan
            If frmESS_.Tag = 1 Then
                dtTP = frmESS_.grvThanhPhan.DataSource.Table
                For i As Integer = 0 To dtTP.Rows.Count - 1
                    Dim objTP As New ESSThanhPhanDiem
                    objTP.Checked = dtTP.Rows(i)("Chon")
                    objTP.ID_thanh_phan = dtTP.Rows(i)("ID_thanh_phan")
                    objTP.STT = dtTP.Rows(i)("STT")
                    objTP.Ky_hieu = dtTP.Rows(i)("Ky_hieu")
                    objTP.Ten_thanh_phan = dtTP.Rows(i)("Ten_thanh_phan")
                    objTP.Ty_le = dtTP.Rows(i)("Ty_le")
                    objTP.He_so = dtTP.Rows(i)("He_so")
                    objTP.Nhom = dtTP.Rows(i)("Nhom")
                    objTP.Chuyen_can = dtTP.Rows(i)("Chuyen_can")
                    clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i) = objTP
                Next
                'Load lai cac thanh phan
                Dim ID_mon As Integer = cmbID_mon.SelectedValue
                FormatDataView()
                Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, cmbHoc_ky_TP.Text, cmbNam_hoc_TP.Text).DefaultView

                Dim Lock_diem As Boolean = False
                KhoaDuLieu(Lock_diem)
                If Lock_diem = True Then
                    cmdDelete.Enabled = False
                    cmdUpdate.Enabled = False
                    cmdSave.Enabled = False
                    cmdDiemThanhPhan.Enabled = False
                Else
                    cmdDelete.Enabled = True
                    cmdUpdate.Enabled = True
                    cmdSave.Enabled = True
                    cmdDiemThanhPhan.Enabled = True
                End If
            End If
        Else
            Thongbao("Bạn phải chọn học phần để xác định các thành phần cho học phần")
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            grdViewDiem.EndEdit()
            Dim Hoc_ky As Integer = cmbHoc_ky_TP.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc_TP.Text
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim ID_dt As Integer = 0
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim ID_diem As Integer
            Dim Noi_dung_Add As String = ""

            For i As Integer = 0 To dtDiem.Rows.Count - 1
                Dim objDiemDanh As New DiemDanh
                ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                Dim objDiem As New ESSDiem
                Dim objDiemTP As New ESSDiemThanhPhan
                'Nếu chưa có điểm thì insert vào bảng điểm Học phần
                If ID_diem = 0 Then
                    Dim flg As Boolean = False
                    For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                        If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Checked Then
                            With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j)
                                If dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).ToString <> "" Then
                                    flg = True
                                    Exit For
                                End If
                            End With
                        End If
                    Next

                    If flg Then
                        objDiem.Hoc_ky = Hoc_ky
                        objDiem.Nam_hoc = Nam_hoc
                        objDiem.ID_mon = ID_mon
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                        objDiem.ID_dv = gobjUser.ID_dv
                        objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")

                        ID_diem = clsDiem.ThemMoi_ESSDiem(objDiem)
                        dtDiem.Rows(i)("ID_diem") = ID_diem
                    End If

                Else
                    'objDiem.Hoc_ky = Hoc_ky
                    'objDiem.Nam_hoc = Nam_hoc
                    objDiem.ID_mon = ID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")

                    clsDiem.CapNhat_ESSDiem(objDiem, ID_diem)
                End If
                Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString
                'Cap nhat diem danh
                objDiemDanh.Hoc_ky_DD = Hoc_ky
                objDiemDanh.Nam_hoc_DD = Nam_hoc
                objDiemDanh.So_tiet_nghi_co_phep = IIf(dtDiem.Rows(i)("So_tiet_nghi_co_phep").ToString = "", 0, dtDiem.Rows(i)("So_tiet_nghi_co_phep"))
                objDiemDanh.So_tiet_nghi_khong_phep = IIf(dtDiem.Rows(i)("So_tiet_nghi_khong_phep").ToString = "", 0, dtDiem.Rows(i)("So_tiet_nghi_khong_phep"))
                objDiemDanh.Thieu_bai_thuc_hanh = IIf(dtDiem.Rows(i)("Thieu_bai_thuc_hanh").ToString = "", 0, dtDiem.Rows(i)("Thieu_bai_thuc_hanh"))
                objDiemDanh.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                clsDiem.Xoa_DiemDanh(ID_diem, Hoc_ky, Nam_hoc)
                If clsDiem.KiemTraTonTai_DiemDanh(ID_diem, Hoc_ky, Nam_hoc) > 0 Then
                    clsDiem.CapNhat_DiemDanh(objDiemDanh, ID_diem, Hoc_ky, Nam_hoc)
                ElseIf objDiemDanh.So_tiet_nghi_co_phep > 0 Or objDiemDanh.So_tiet_nghi_khong_phep > 0 Or objDiemDanh.Thieu_bai_thuc_hanh Then    'Insert
                    clsDiem.ThemMoi_DiemDanh(ID_diem, objDiemDanh)
                End If

                'Duyệt các điểm thành phần
                For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                    Dim NoiDung As String = ""
                    If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Checked Then
                        With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j)
                            If dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).ToString <> "" Then
                                objDiemTP.ID_thanh_phan = .ID_thanh_phan
                                objDiemTP.Ty_le = .Ty_le
                                objDiemTP.Nhom = .Nhom
                                objDiemTP.He_so = .He_so
                                objDiemTP.Hoc_ky_TP = Hoc_ky
                                objDiemTP.Nam_hoc_TP = Nam_hoc
                                objDiemTP.Diem = dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu)
                                'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                                objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                                objDiemTP.Locked = dtDiem.Rows(i)("Locked")
                                'Update
                                If clsDiem.CheckExist_svDiemThanhPhan(ID_diem, .ID_thanh_phan, Hoc_ky, Nam_hoc) > 0 Then
                                    clsDiem.CapNhat_ESSDiemThanhPhan(objDiemTP, ID_diem, .ID_thanh_phan)
                                Else    'Insert
                                    clsDiem.ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                                End If
                                NoiDung += " TP: " & .Ky_hieu & "-Điểm: " & dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu)
                            Else
                                'Xoá điểm thành phần
                                clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, .ID_thanh_phan, Hoc_ky, Nam_hoc)
                            End If
                        End With
                    Else
                        'Xoá điểm thành phần không chọn
                        clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan, Hoc_ky, Nam_hoc)
                    End If
                    If NoiDung.Trim <> "" Then Noi_dung_Add += NoiDung
                Next
            Next

            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Cập nhật điểm thành phần Học phần: " & cmbID_mon.Text.Trim & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If

            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub




    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDataGridViewToExcel(grdViewDiem, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim ID_diem As Integer
                Dim ID_thanh_phan As Integer
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                    If ID_diem > 0 Then
                        'Xoá các thành phần điểm
                        For j As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                            If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Checked Then
                                ID_thanh_phan = clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan
                                If dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu).ToString <> "" Then
                                    clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, ID_thanh_phan, cmbHoc_ky_TP.Text, cmbNam_hoc_TP.Text)
                                    dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu) = DBNull.Value
                                End If
                            End If
                        Next
                    End If
                Next
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_BDT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_BDT.ItemClick
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
        '        Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

        '        Tieu_de1 = "BẢNG ĐIỂM KIỂM TRA GIỮA KỲ HỌC PHẦN " + " -LỚP : " + TreeViewLop.Ten_lop
        '        Tieu_de2 = "Học phần: " + cmbID_mon.Text
        '        Tieu_de3 = "Học ky: " + cmbHoc_ky_TP.Text + " - Năm học: " + cmbNam_hoc_TP.Text
        '        Tieu_de4 = "Trình độ đào tạo: " + TreeViewLop.Ten_he
        '        Tieu_de5 = "Khóa học: " & TreeViewLop.Khoa_hoc
        '        Tieu_de6 = ""
        '        Tieu_de7 = ""

        '        Dim dtDiemTH As DataTable
        '        Dim dt As DataTable = grdViewDiem.DataSource.Table
        '        dtDiemTH = dt.Copy
        '        dtDiemTH.Columns.Add("Diem_chu")
        '        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
        '            dtDiemTH.Rows(i)("Diem_chu") = Doc_so(dtDiemTH.Rows(i)("TBCBP").ToString)
        '        Next
        '        Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemKiemTraHocPhan", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
        '        frmESS_.ShowDialog()

        '    Else
        '        Thongbao("Bạn phải chọn học phần trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default

        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

                Tieu_de1 = "ĐIỂM KIỂM TRA HỌC PHẦN"
                Tieu_de2 = ""
                Tieu_de3 = ""
                Tieu_de4 = ""
                Tieu_de5 = ""
                Tieu_de6 = ""
                Tieu_de7 = ""

                Dim dtDiemTH As DataTable
                Dim dt As DataTable = grdViewDiem.DataSource.Table
                dtDiemTH = dt.Copy
                dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_DuDKT", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_KhongDuDKT", GetType(String))

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Khoa_hoc") = TreeViewLop.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = cmbID_mon.Text.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = cmbID_mon.Text.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = cmbID_mon.Text.Split("|").GetValue(2)
                    dtDiemTH.Rows(i)("Tong_tiet") = ""
                    dtDiemTH.Rows(i)("Tong_SV_DuDKT") = "Đủ điều kiện thi HP: "
                    dtDiemTH.Rows(i)("Tong_SV_KhongDuDKT") = "Không đủ điều kiện thi HP:"
                    dtDiemTH.Rows(i)("Tong_SV") = "Tổng số sinh viên: " & dtDiemTH.Rows.Count.ToString
                Next
                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemKiemTraHocPhan_HVCS", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
                frmESS_.ShowDialog()

            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdPrint_PhieuDanhGia_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_PhieuDanhGia.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1 As String = ""
                Dim Tieu_de2 As String = ""

                Tieu_de1 = "PHIẾU ĐÁNH GIÁ ĐIỂM QUÁ TRÌNH BẬC CAO ĐẲNG (TÍN CHỈ)"


                Dim dtDiemTH As DataTable
                Dim dt As DataTable = grdViewDiem.DataSource.Table
                dtDiemTH = dt.Copy

                If dtDiemTH.Rows.Count > 0 Then
                    Tieu_de2 = "Lớp: " & TreeViewLop.Ten_lop & " Học kỳ: " & cmbHoc_ky_TP.Text & " Năm học: " & cmbNam_hoc_TP.Text & " Học phần: " & cmbID_mon.Text & "  Giảng viên: .......................... Khoa:............................."
                    Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_PhieuDanhGiaQuaTrinhHocPhan_CD", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2)
                    frmESS_.ShowDialog()
                End If

            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chkUpdate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkUpdate.CheckedChanged
        If chkUpdate.Checked Then
            cmdUpdate.Visible = True
            cmdSave.Visible = False
        Else
            cmdUpdate.Visible = False
            cmdSave.Visible = True
        End If
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            Dim dv As DataView = grdViewDiem.DataSource
            If TreeViewLop.ID_Lop > 0 AndAlso TreeViewLop.ID_dt > 0 Then
                Dim SQL_Del1 As String = ""
                Dim SQL_Del2 As String = ""
                Dim SQL_Del As String = ""
                Dim SQL As String = ""
                Dim SQL1 As String = ""
                Dim SQL2 As String = ""

                Dim ID_dt As Integer = TreeViewLop.ID_dt
                Dim ID_lop As Integer = TreeViewLop.ID_Lop
                Dim mNien_khoa As String = TreeViewLop.Nien_khoa

                Dim mHoc_ky As Integer = cmbHoc_ky_TP.Text.Trim
                Dim mNam_hoc As String = cmbNam_hoc_TP.Text.Trim

                If mHoc_ky > 0 And mNam_hoc <> "" Then
                    SQL_Del1 = "DELETE MARK_DiemThanhPhan_TC WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                     " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    'SQL_Del2 = "DELETE MARK_DiemThi_TC WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    '" AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    SQL_Del = "DELETE MARK_Diem_TC WHERE ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & ")" & " AND Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "'"

                    SQL = "UPDATE MARK_Diem_TC SET Hoc_ky=" & mHoc_ky & ", Nam_hoc='" & mNam_hoc & "' WHERE ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & ")"


                    SQL1 = "UPDATE MARK_DiemThanhPhan_TC SET Hoc_ky_TP=" & mHoc_ky & ", Nam_hoc_TP='" & mNam_hoc & "' WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"


                    'SQL2 = "UPDATE MARK_DiemThi_TC SET Hoc_ky_thi=" & mHoc_ky & ", Nam_hoc_thi='" & mNam_hoc & "' WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    '" AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    Try
                        Connect.Execute(SQL)
                        Connect.Execute(SQL1)
                        'Connect.Execute(SQL2)
                    Catch ex As Exception
                        'Thongbao("Kiểm tra lại dữ liệu !" & ex.Message & " - " & ID_dt & "-" & ID_lop & "-" & cmbID_mon.SelectedValue, MsgBoxStyle.Information)
                        If Thongbao("Đã tồn tại điểm của sinh viên theo học kỳ đã chọn, bạn hãy xóa trước khi cập nhật điểm." & vbCrLf & "Bạn có muốn xóa không?", MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            Connect.Execute(SQL_Del1)
                            'Connect.Execute(SQL_Del2)
                            Connect.Execute(SQL_Del)
                        Else
                            Exit Sub
                        End If

                    End Try
                End If
                chkUpdate.Checked = False
                cmbMonHoc_SelectedIndexChanged(sender, e)
                Thongbao("Cập nhật thành công !", MsgBoxStyle.Information)
            Else
                Thongbao("Bạn hãy chọn đến lớp hành chính", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Exit Sub
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBrowse.Click
        With dlgOpenFile
            .InitialDirectory = Application.StartupPath
            .Filter = "Tệp Excel|*.xls"
            .FilterIndex = 1
        End With
        If dlgOpenFile.ShowDialog() = DialogResult.OK Then
            Me.Cursor = Cursors.WaitCursor
            xlsFileName = dlgOpenFile.FileName
            Dim xlsFile As String = xlsFileName.Trim.ToLower.Substring(xlsFileName.Trim.Length - 3, 3)
            If xlsFile = "xls" Then
                Try
                    cmbChonFile.Items.Clear()
                    Dim conADO As New ADODB.Connection
                    Dim myrs As New ADODB.Recordset
                    conADO.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    myrs = conADO.OpenSchema(ADODB.SchemaEnum.adSchemaTables)
                    While Not myrs.EOF
                        If myrs.Fields("TABLE_NAME").Value.ToString.Length > 0 Then
                            If myrs.Fields("TABLE_NAME").Value.ToString.Substring(myrs.Fields("TABLE_NAME").Value.ToString.Length - 1, 1) = "$" Then
                                cmbChonFile.Items.Add(myrs.Fields("TABLE_NAME").Value)
                            End If
                        End If
                        myrs.MoveNext()
                    End While
                    myrs.Close()
                    If cmbChonFile.Items.Count > 0 Then
                        cmbChonFile.SelectedIndex = 0
                    End If
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmbChonFile_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbChonFile.SelectedIndexChanged
        If cmbChonFile.SelectedIndex >= 0 Then
            Me.Cursor = Cursors.WaitCursor
            If xlsFileName.Trim <> "" Then
                Try
                    dt = New DataTable
                    Dim oleCnn As New OleDb.OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & xlsFileName & ";Extended Properties=""Excel 8.0;HDR=YES;""")
                    Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [" & cmbChonFile.Text & "]", oleCnn)
                    da.Fill(dt)
                    Dim dt_tp, dt_tp_excel, dt_maSV As New DataTable
                    dt_tp_excel.Columns.Add("ID_TP_E", GetType(Integer))
                    dt_tp_excel.Columns.Add("Ten_TP_E", GetType(String))
                    If dt.Columns.Count > 0 Then
                        For j As Integer = 0 To dt.Columns.Count - 1
                            Dim dr As DataRow = dt_tp_excel.NewRow
                            dr("ID_TP_E") = j
                            dr("Ten_TP_E") = dt.Columns(j).ColumnName
                            dt_tp_excel.Rows.Add(dr)
                        Next
                    End If
                    FillCombo(cmbCot_diem, dt_tp_excel)
                    dt_maSV = dt_tp_excel.Copy
                    FillCombo(cmbMa_sv, dt_maSV)

                    dt_tp.Columns.Add("ID_TP", GetType(Integer))
                    dt_tp.Columns.Add("Ten_TP", GetType(String))

                    For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                        If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                            Dim col As New DataGridViewTextBoxColumn
                            With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                                Dim dr As DataRow = dt_tp.NewRow
                                dr("ID_tp") = .ID_thanh_phan
                                dr("Ten_TP") = .Ky_hieu
                                dt_tp.Rows.Add(dr)
                            End With
                        End If
                    Next
                    FillCombo(cmbThanh_phan, dt_tp)
                Catch
                End Try
            End If
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub cmdDongBo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongBo.Click
        If cmbMa_sv.Text.Trim = "" Or cmbThanh_phan.Text.Trim = "" Or cmbCot_diem.Text.Trim = "" Then
            Thongbao("Bạn hãy chọn đây đủ các trường thông tin", MsgBoxStyle.Critical)
            Exit Sub
        End If
        Dim dv As DataView = grdViewDiem.DataSource
        For i As Integer = 0 To dv.Count - 1
            Dim dk As String = "[" & cmbMa_sv.Text.Trim & "]=" & "'" & dv.Item(i)("Ma_sv").ToString & "'"

            dt.DefaultView.RowFilter = dk
            If dt.DefaultView.Count > 0 Then
                dv.Item(i)(cmbThanh_phan.Text) = dt.DefaultView.Item(0)(cmbCot_diem.Text.Trim)
            End If
        Next
    End Sub

    Private Sub cmdHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHelp.Click
        Dim str As String = "Các bước nhập điểm thành phần qua Excel: "
        str = str + vbCrLf
        str = str + "1. Chọn biểu tượng folder để mở file excel" + vbCrLf
        str = str + "2. Chọn Sheet của file excel" + vbCrLf
        str = str + "3. Chọn cột Mã sinh viên" + vbCrLf
        str = str + "4. Người dùng lần lượt chọn Thành Phần môn của file excel tương ứng với Thành Phần điểm" + vbCrLf
        str = str + "5. Chọn Đồng bộ dữ liệu từ Excel" + vbCrLf
        Thongbao(str, MsgBoxStyle.Information)
    End Sub

    Private Sub btnBangDiemThanhPhan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBangDiemThanhPhan.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

                Tieu_de1 = "ĐIỂM KIỂM TRA MÔN HỌC, MÔ ĐUN "
                Tieu_de2 = ""
                Tieu_de3 = ""
                Tieu_de4 = ""
                Tieu_de5 = ""
                Tieu_de6 = ""
                Tieu_de7 = ""

                Dim dtTP As DataTable
                Dim a As Integer = 0
                Dim b As Integer = 0
                dtTP = clsDiem.DanhSachThanhPhanChon '' 
                For i As Integer = 0 To dtTP.Rows.Count - 1
                    If dtTP.Rows(i)("He_so") = 1 Then
                        a = a + 1
                        dtTP.Rows(i)("Ten_thanh_phan") = "Đ" & a
                    ElseIf dtTP.Rows(i)("He_so") = 2 Then
                        b = b + 1
                        dtTP.Rows(i)("Ten_thanh_phan") = "Đ" & b
                    End If
                Next
                Dim dtDiemTH As DataTable
                Dim dt As DataTable = grdViewDiem.DataSource.Table
                dtDiemTH = dt.Copy
                dtDiemTH.Columns.Add("Danh_gia", GetType(String))
                dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_DuDKT", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_KhongDuDKT", GetType(String))

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Khoa_hoc") = TreeViewLop.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = cmbID_mon.Text.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = cmbID_mon.Text.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = cmbID_mon.Text.Split("|").GetValue(2)
                    dtDiemTH.Rows(i)("Tong_tiet") = ""
                    dtDiemTH.Rows(i)("Tong_SV_DuDKT") = "Đủ điều kiện thi MH/MĐ:"
                    dtDiemTH.Rows(i)("Tong_SV_KhongDuDKT") = "Không đủ điều kiện thi MH/MĐ:"
                    dtDiemTH.Rows(i)("Tong_SV") = "Tổng số sinh viên: " & dtDiemTH.Rows.Count.ToString
                    If IsDBNull(dtDiemTH.Rows(i)("Ghi_chu")) = False Then
                        If dtDiemTH.Rows(i)("Ghi_chu") <> "" Then
                            dtDiemTH.Rows(i)("Danh_gia") = "X"
                        End If
                    End If
                Next
                'Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemKiemTraHocPhan_HVCS_09", dtDiemTH.DefaultView, dtTP, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
                'frmESS_.ShowDialog()
                Dim rpt As New rptMARK_BangDiemKiemTraHocPhan_HVCS_09(dtDiemTH.DefaultView, dtTP, Tieu_de1)
                PrintXtraReport(rpt)

            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cap_nhap_ly_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cap_nhap_ly_do.Click
        Try
            Dim dv As DataView
            dv = grdViewDiem.DataSource
            dv.RowFilter = "Ghi_chu <> ''"
            For i As Integer = 0 To dv.Count - 1
                Dim para(4) As SqlClient.SqlParameter
                para(0) = New SqlClient.SqlParameter("@ID_sv", dv.Item(i).Item("ID_SV"))
                para(1) = New SqlClient.SqlParameter("@ID_mon", cmbID_mon.SelectedValue)
                para(2) = New SqlClient.SqlParameter("@Hoc_ky", cmbHoc_ky.SelectedValue)
                para(3) = New SqlClient.SqlParameter("@Nam_hoc", cmbNam_hoc.Text)
                para(4) = New SqlClient.SqlParameter("@Ly_do", dv.Item(i).Item("Ghi_chu"))
                ESSConnect.Connect.ExecuteSP("STU_DanhSachKhongThi_TC_ThemMoi_09", para)
            Next
            trvLop_Select()
            Thongbao("Cập nhập thành công!")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

End Class