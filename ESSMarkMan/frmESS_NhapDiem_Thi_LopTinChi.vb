Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_NhapDiem_Thi_LopTinChi
    Private So_lan_thi_lai As Integer = 2
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mLan_thi As Integer = 1
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mTen_lop_tc As String = ""
    Private clsDiem As New Diem_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private mFlag As Boolean = False
    Dim xlsFileName As String = ""
    Private dt As New DataTable
    Private Tong_TP_ThucHanh As Double = 0
    Private Tong_ty_le As Double = 0
#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_LanThi(cmbLan_thi, So_lan_thi_lai)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub FormatDataView(ByVal dtDiemChu As DataTable, ByVal dtKyHieuDiem As DataTable)
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
                .HeaderText = "Mã sinh viên"
                .Width = 100
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
                .Width = 200
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)
            'TBCMH
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "TBCMH"
                .DataPropertyName = "TBCMH"
                .HeaderText = "TBCMH"
                .Width = 60
                .DefaultCellStyle.Format = "N" + Lam_tron_TBCMH.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col4)
            'Điểm chữ
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "Diem_chu"
                .DataPropertyName = "Diem_chu"
                .HeaderText = "Điểm chữ"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col5)
            'Các thành phần điểm
            Tong_ty_le = 0
            Dim sNhom As String = "#"
            For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
                If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                    Dim col As New DataGridViewTextBoxColumn
                    With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                        'col.Name =  .Ky_hieu
                        col.Name = .Ky_hieu
                        'col.DataPropertyName =  .Ky_hieu
                        col.DataPropertyName = .Ky_hieu
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 80
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                        col.ReadOnly = True
                        If Not sNhom.Contains(.Nhom.ToString) Then
                            Tong_ty_le += .Ty_le
                            sNhom += .Nhom.ToString + "#"
                        End If
                        'Tong_ty_le += .Ty_le
                        'If .Ty_le < 10 Then Ty_le_ThucHanh = True
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'Điểm thi
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Diem_thi"
                .DataPropertyName = "Diem_thi"
                Tong_TP_ThucHanh = 100 - Tong_ty_le
                If Tong_TP_ThucHanh = 0 Or Tong_ty_le < 10 Then
                    .HeaderText = "Thi (0)"
                Else
                    .HeaderText = "Thi (" + (100 - Tong_ty_le).ToString + ")"
                End If
                .Width = 60
                .DefaultCellStyle.Format = "N" + Lam_tron_diem_thi.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col6)
            'Ghi chú
            Dim col7 As New DataGridViewComboBoxColumn
            With col7
                .Name = "Ghi_chu"
                .DataPropertyName = "Ghi_chu"
                .HeaderText = "Ghi chú"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .MaxDropDownItems = 20
                .FlatStyle = FlatStyle.Standard
                .DropDownWidth = 80
                .DataSource = dtKyHieuDiem
                .ValueMember = "Ky_hieu"
                .DisplayMember = "Ky_hieu"
            End With
            Me.grdViewDiem.Columns.Add(col7)
            'Locked
            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col8)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub KhoaDuLieu(ByRef Lock_diem As Boolean)
        Try
            Dim dv As DataView = grdViewDiem.DataSource
            Lock_diem = False
            Dim so_locked As Integer = 0
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    so_locked = so_locked + 1
                    If Lock_diem = False Then Lock_diem = True
                    grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Or grdViewDiem.Rows(i).Cells("Ghi_chu").Value.ToString <> "" Then    'Edit
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Edit
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    Else    'Add new
                        Dim CellImage As New DataGridViewImageCell
                        CellImage.Value = My.Resources.Add
                        CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                        grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                    End If
                End If
            Next
            'If Not dv Is Nothing AndAlso dv.Count = so_locked Then
            '    'Nếu tất cả đề locked
            '    Lock_diem = True
            'Else
            '    Lock_diem = False
            'End If

            If so_locked > 0 Then
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
        So_lan_thi_lai = cls.Doc_tham_so("So_lan_thi_lai")
        Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
        Lam_tron_diem_thi = cls.Doc_tham_so("Lam_tron_diem_thi")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            'Load dữ liệu vào ComboBox lần thi
            LoadComboBox()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(cmdLock, cmdSave, , cmdDelete)
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

    Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thi.SelectedIndexChanged
        If Loader Then
            mLan_thi = cmbLan_thi.SelectedValue
            If mLan_thi = 1 Then
                Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(mID_mon, mHoc_ky, mNam_hoc).DefaultView
            Else
                Dim KyHieu As Integer = -1
                If cmbKy_hieu.Text <> "" Then KyHieu = cmbKy_hieu.SelectedIndex
                Dim dv As DataView
                dv = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, KyHieu, mHoc_ky, mNam_hoc).DefaultView
                Dim RowFilter As String = " 1=1 "
                If KyHieu = 1 Then 'Thieu diem TP
                    RowFilter += " AND Ghi_chu='I'"
                ElseIf KyHieu = 2 Then 'Thieu diem Thi
                    RowFilter += " AND Ghi_chu='X'"
                ElseIf KyHieu = 3 Then 'Khong tinh diem TP vao hoc phan
                    RowFilter += " AND Ghi_chu='VC'"
                ElseIf KyHieu = 4 Then 'Bao luu diem
                    RowFilter += " AND Ghi_chu='B'"
                End If
                dv.RowFilter = RowFilter
                Me.grdViewDiem.DataSource = dv
            End If
            Dim Lock_diem As Boolean = False
            KhoaDuLieu(Lock_diem)
            If Lock_diem = True Then
                cmdDelete.Enabled = False
                cmdSave.Enabled = False
            Else
                cmdDelete.Enabled = True
                cmdSave.Enabled = True
            End If
        End If
    End Sub
    Private Sub trvLopTinChi_Select() Handles trvLopTinChi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            If Loader Then
                'Ty_le_ThucHanh = False
                mHoc_ky = trvLopTinChi.Hoc_ky
                mNam_hoc = trvLopTinChi.Nam_hoc
                mID_mon_tc = trvLopTinChi.ID_mon_tc
                mID_lop_tc = trvLopTinChi.ID_lop_tc
                mID_mon = trvLopTinChi.ID_mon
                mTen_mon = trvLopTinChi.Ten_mon
                mTen_lop_tc = trvLopTinChi.Ten_lop_tc
                mTen_lop_tc = trvLopTinChi.So_hoc_trinh
                mLan_thi = cmbLan_thi.Text
                If mID_mon_tc > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = "0"
                    Dim dtDiem_chu, dtDiemKyHieu As DataTable
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc, gobjUser.UserName, gobjUser.ID_phong, optDaDuyet.Checked)
                    dtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien

                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += "," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString
                            End If
                        Next
                        'Load dữ liệu điểm
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True, True, mID_lop_tc, mID_mon_tc)
                        Dim KyHieu As Integer = -1
                        If cmbKy_hieu.Text <> "" Then KyHieu = cmbKy_hieu.SelectedIndex
                        Dim dv As DataView
                        Dim RowFilter As String = " 1=1 "
                        If KyHieu = 1 Then 'Thieu diem TP
                            RowFilter += " AND Ghi_chu='I'"
                        ElseIf KyHieu = 2 Then 'Thieu diem Thi
                            RowFilter += " AND Ghi_chu='X'"
                        ElseIf KyHieu = 3 Then 'Khong tinh diem TP vao hoc phan
                            RowFilter += " AND Ghi_chu='VC'"
                        ElseIf KyHieu = 4 Then 'Bao luu diem
                            RowFilter += " AND Ghi_chu='B'"
                        End If
                        If mLan_thi = 1 Then
                            dv = clsDiem.DanhSachDiemThiLan1(mID_mon, mHoc_ky, mNam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            grdViewDiem.DataSource = dv
                        Else
                            dv = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, KyHieu, mHoc_ky, mNam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            Me.grdViewDiem.DataSource = dv
                        End If
                        lblSo_sv.Text = dv.Count

                        dtDiem_chu = clsDiem.HienThi_ESSDiem_chu
                        dtDiemKyHieu = clsDiem.HienThi_ESSDiemKyHieu_DanhSach
                        FormatDataView(dtDiem_chu, dtDiemKyHieu)
                        Dim Lock_diem As Boolean = False
                        KhoaDuLieu(Lock_diem)
                        If Lock_diem = True Then
                            cmdDelete.Enabled = False
                            cmdSave.Enabled = False
                        Else
                            cmdDelete.Enabled = True
                            cmdSave.Enabled = True
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    SetQuyenTruyCap(cmdLock, cmdSave, , cmdDelete)
                    If gobjUser.ID_Bomon > 0 And mID_mon > 0 Then
                        If Check_Mon_TheoKhoa(gobjUser.ID_Bomon, mID_lop_tc) Then
                            cmdSave.Enabled = True
                            cmdLock.Enabled = True
                        End If
                    End If
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub grdViewDiem_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
        If e.ColumnIndex = grdViewDiem.Columns("Diem_thi").Index Then
            If grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdViewDiem.CurrentCell.Value) Then
                Thongbao("Bạn phải nhập điểm là số !")
                grdViewDiem.CurrentCell.Value = DBNull.Value
            End If
            If grdViewDiem.CurrentCell.Value.ToString <> "" AndAlso (grdViewDiem.CurrentCell.Value < 0 Or grdViewDiem.CurrentCell.Value > 100) Then
                Thongbao("Bạn phải nhập điểm là số từ 0 đến 100 !")
                grdViewDiem.CurrentCell.Value = DBNull.Value
            End If
        End If
    End Sub
#End Region

    Private Sub cmdBangDiem_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String
                Dim dtTP As DataTable
                If trvLopTinChi.ID_lop_tc.ToString <> "" Then 'La Lop
                    Tieu_de1 = "BẢNG ĐIỂM TỔNG KẾT HỌC PHẦN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "HỌC PHẦN: " + trvLopTinChi.Ten_mon.ToUpper
                    Tieu_de3 = "HỌC KỲ: " + trvLopTinChi.Hoc_ky + " NĂM HỌC: " + trvLopTinChi.Nam_hoc
                    Tieu_de4 = "Trình độ đào tạo: " + trvLopTinChi.Ten_mon
                    Tieu_de5 = "Lớp: " & trvLopTinChi.Ten_lop_tc.ToUpper
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                Else
                    Tieu_de1 = "BẢNG ĐIỂM TỔNG KẾT HỌC PHẦN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "HỌC PHẦN: " + trvLopTinChi.Ten_mon
                    Tieu_de3 = "HỌC KỲ: " + trvLopTinChi.Hoc_ky + " NĂM HỌC: " + trvLopTinChi.Nam_hoc
                    Tieu_de4 = "Trình độ đào tạo: " + trvLopTinChi.Ten_mon.ToUpper
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                End If
                dtTP = clsDiem.DanhSachThanhPhanChon
                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
                Dim dt As DataTable = dtDiemTH.Copy
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Diem_chu") = Doc_so(dt.Rows(i).Item("TBCMH").ToString)
                Next

                'TaoBaoCaoBangDiemThiHocPhan_DSLop_HC_DiemChu(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP, dt.Rows.Count, 2, 3, 4, 5)
                'C1Report1.DataSource.Recordset = dt
                'Dim frmESS_ As New frmESS_XemBaoCao
                'frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Function Diem_chu(ByVal str As String) As String
        Dim Arr(11) As String
        Arr(0) = "không"
        Arr(1) = "một"
        Arr(2) = "hai"
        Arr(3) = "ba"
        Arr(4) = "bốn"
        Arr(5) = "năm"
        Arr(6) = "sáu"
        Arr(7) = "bảy"
        Arr(8) = "tám"
        Arr(9) = "chín"
        Arr(10) = "mười"
        If str <> "" Then
            For i As Integer = 0 To 10
                str = Replace(str, i.ToString, Arr(i))
            Next
            str = Replace(str, ".", ", ")
            If str.Length >= 2 Then
                str = Mid(str, 1, 1).ToUpper + Mid(str, 2)
            End If
        End If
        Return str
    End Function

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("TBCMH").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThiLock(dtDiem.Rows(i)("ID_diem"), 1, mLan_thi)
                End If
            Next
            'Load lại dữ liệu điểm
            Call trvLopTinChi_Select()
            Thongbao("Đã khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("TBCMH").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThiLock(dtDiem.Rows(i)("ID_diem"), 0, mLan_thi)
                End If
            Next
            'Load lại dữ liệu điểm
            Call trvLopTinChi_Select()
            Thongbao("Đã mở khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKy_hieu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKy_hieu.SelectedIndexChanged
        trvLopTinChi_Select()
    End Sub

    Private Sub cmdBienBanThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                If trvLopTinChi.ID_lop_tc.ToString <> "" Then 'La Lop
                    Tieu_de1 = "BIÊN BẢN THI LẦN: " + cmbLan_thi.Text + ", LỚP TÍN CHỈ: " + trvLopTinChi.Ten_lop_tc
                    Tieu_de2 = "Học kỳ: " + trvLopTinChi.Hoc_ky.ToString + ", Năm học: " + trvLopTinChi.Nam_hoc
                    Tieu_de3 = "Học phần: " + trvLopTinChi.Ten_mon
                Else
                    Thongbao("Bạn phải chọn đến lớp học")
                    Exit Sub
                End If
                Dim dt As DataTable = grdViewDiem.DataSource.Table
                If dt.Rows.Count > 0 Then
                    Dim dt_Main As DataTable = dt.Copy
                    dt_Main.Columns.Add("Tieu_de_ten_bo")
                    dt_Main.Columns.Add("Tieu_de_Ten_truong")
                    dt_Main.Columns.Add("Tieu_de1")
                    dt_Main.Columns.Add("Tieu_de2")
                    dt_Main.Columns.Add("Tieu_de3")

                    Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt_Main.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt_Main.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dt_Main.Rows(0).Item("Tieu_de_ten_bo") = ""
                        dt_Main.Rows(0).Item("Tieu_de_Ten_truong") = ""
                    End If


                    dt_Main.Rows(0).Item("Tieu_de1") = Tieu_de1
                    dt_Main.Rows(0).Item("Tieu_de2") = Tieu_de2
                    dt_Main.Rows(0).Item("Tieu_de3") = Tieu_de3

                    Dim frmESS_ As New frmESS_XemBaoCao
                    frmESS_.ShowDialog("rpBienBanThi", dt_Main, Tieu_de1, Tieu_de2, Tieu_de3)
                End If
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Function Doc_so(ByVal str As String) As String
        Select Case str
            Case "0" : Return "Không"
            Case "0.1" : Return "Không, một"
            Case "0.2" : Return "Không, hai"
            Case "0.3" : Return "Không, ba"
            Case "0.4" : Return "Không, bốn"
            Case "0.5" : Return "Không, năm"
            Case "0.6" : Return "Không, sáu"
            Case "0.7" : Return "Không, bảy"
            Case "0.8" : Return "Không, tám"
            Case "0.9" : Return "Không, chín"

            Case "1" : Return "Một"
            Case "1.1" : Return "Một, một"
            Case "1.2" : Return "Một, hai"
            Case "1.3" : Return "Một, ba"
            Case "1.4" : Return "Một, bốn"
            Case "1.5" : Return "Một, năm"
            Case "1.6" : Return "Một, sáu"
            Case "1.7" : Return "Một, bảy"
            Case "1.8" : Return "Một, tám"
            Case "1.9" : Return "Một, chín"

            Case "2" : Return "Hai"
            Case "2.1" : Return "Hai, một"
            Case "2.2" : Return "Hai, hai"
            Case "2.3" : Return "Hai, ba"
            Case "2.4" : Return "Hai, bốn"
            Case "2.5" : Return "Hai, năm"
            Case "2.6" : Return "Hai, sáu"
            Case "2.7" : Return "Hai, bảy"
            Case "2.8" : Return "Hai, tám"
            Case "2.9" : Return "Hai, chín"

            Case "3" : Return "Ba"
            Case "3.1" : Return "Ba, một"
            Case "3.2" : Return "Ba, hai"
            Case "3.3" : Return "Ba, ba"
            Case "3.4" : Return "Ba, bốn"
            Case "3.5" : Return "Ba, năm"
            Case "3.6" : Return "Ba, sáu"
            Case "3.7" : Return "Ba, bảy"
            Case "3.8" : Return "Ba, tám"
            Case "3.9" : Return "Ba, chín"

            Case "4" : Return "Bốn"
            Case "4.1" : Return "Bốn, một"
            Case "4.2" : Return "Bốn, hai"
            Case "4.3" : Return "Bốn, ba"
            Case "4.4" : Return "Bốn, bốn"
            Case "4.5" : Return "Bốn, năm"
            Case "4.6" : Return "Bốn, sáu"
            Case "4.7" : Return "Bốn, bảy"
            Case "4.8" : Return "Bốn, tám"
            Case "4.9" : Return "Bốn, chín"

            Case "5" : Return "Năm"
            Case "5.1" : Return "Năm, một"
            Case "5.2" : Return "Năm, hai"
            Case "5.3" : Return "Năm, ba"
            Case "5.4" : Return "Năm, bốn"
            Case "5.5" : Return "Năm, năm"
            Case "5.6" : Return "Năm, sáu"
            Case "5.7" : Return "Năm, bảy"
            Case "5.8" : Return "Năm, tám"
            Case "5.9" : Return "Năm, chín"

            Case "6" : Return "Sáu"
            Case "6.1" : Return "Sáu, một"
            Case "6.2" : Return "Sáu, hai"
            Case "6.3" : Return "Sáu, ba"
            Case "6.4" : Return "Sáu, bốn"
            Case "6.5" : Return "Sáu, năm"
            Case "6.6" : Return "Sáu, sáu"
            Case "6.7" : Return "Sáu, bảy"
            Case "6.8" : Return "Sáu, tám"
            Case "6.9" : Return "Sáu, chín"

            Case "7" : Return "Bẩy"
            Case "7.1" : Return "Bẩy, một"
            Case "7.2" : Return "Bẩy, hai"
            Case "7.3" : Return "Bẩy, ba"
            Case "7.4" : Return "Bẩy, bốn"
            Case "7.5" : Return "Bẩy, năm"
            Case "7.6" : Return "Bẩy, sáu"
            Case "7.7" : Return "Bẩy, bảy"
            Case "7.8" : Return "Bẩy, tám"
            Case "7.9" : Return "Bẩy, chín"

            Case "8" : Return "Tám"
            Case "8.1" : Return "Tám, một"
            Case "8.2" : Return "Tám, hai"
            Case "8.3" : Return "Tám, ba"
            Case "8.4" : Return "Tám, bốn"
            Case "8.5" : Return "Tám, năm"
            Case "8.6" : Return "Tám, sáu"
            Case "8.7" : Return "Tám, bảy"
            Case "8.8" : Return "Tám, tám"
            Case "8.9" : Return "Tám, chín"

            Case "9" : Return "Chín"
            Case "9.1" : Return "Chín, một"
            Case "9.2" : Return "Chín, hai"
            Case "9.3" : Return "Chín, ba"
            Case "9.4" : Return "Chín, bốn"
            Case "9.5" : Return "Chín, năm"
            Case "9.6" : Return "Chín, sáu"
            Case "9.7" : Return "Chín, bảy"
            Case "9.8" : Return "Chín, tám"
            Case "9.9" : Return "Chín, chín"

            Case "10" : Return "Mười"
        End Select
        Return ""
    End Function

    Private Sub grdViewDiem_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdViewDiem.Leave
        'If mFlag AndAlso cmdSave.Enabled = True Then
        '    If Thongbao("Bạn vừa nhập mới hoặc thay đổi điểm thi, bạn có muốn lưu lại không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        cmdSave_Click(sender, e)
        '        mFlag = False
        '    Else
        '        trvLopTinChi_Select()
        '        mFlag = False
        '    End If
        'End If
    End Sub

    Private Sub grdViewDiem_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellValueChanged
        If e.ColumnIndex = grdViewDiem.Columns("Diem_thi").Index Then
            If grdViewDiem.CurrentCell.State = DataGridViewElementStates.Selected Then
                mFlag = True
            End If
        End If
    End Sub

    Private Sub grdViewDiem_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdViewDiem.DataError
        Try

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            grdViewDiem.EndEdit()
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""
            Dim dv As DataView = grdViewDiem.DataSource

            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                If Tong_TP_ThucHanh = 0 Or (Tong_ty_le > 0 And Tong_ty_le < 10) Then
                    dtDiem.Rows(i)("Diem_thi") = 0
                End If
                If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Or dtDiem.Rows(i)("Ghi_chu").ToString = "K" Then
                    Dim objDiem As New ESSDiem
                    Dim objDiemThi As New ESSDiemThi
                    'Nếu chưa có Học phần này thì insert thêm vào object điểm
                    If idx_diem = -1 Then
                        objDiem.Hoc_ky = mHoc_ky
                        objDiem.Nam_hoc = mNam_hoc
                        objDiem.ID_mon = mID_mon
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                        objDiem.ID_dv = gobjUser.ID_dv
                        objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                        clsDiem.Add(objDiem)
                    Else
                        objDiem = clsDiem.ESSDiem(idx_diem)
                        objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    End If
                    'Nếu là nhập mới điểm thi thì insert thêm object điểm thi mới
                    If idx_diem_thi = -1 Then
                        objDiemThi.Lan_thi = mLan_thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Diem_chu = dtDiem.Rows(i)("Diem_chu").ToString
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiemThi.Hoc_ky_thi = mHoc_ky
                        objDiemThi.Nam_hoc_thi = mNam_hoc

                        objDiem.dsDiemThi.Add(objDiemThi)
                        Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    Else
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                            objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_chu = dtDiem.Rows(i)("Diem_chu")
                        objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        Noi_dung_Edit += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    End If
                Else
                    If idx_diem >= 0 And idx_diem_thi >= 0 Then
                        clsDiem.ESSDiem(idx_diem).dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_thi = -1
                    End If
                End If
            Next

            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Bổ sung điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            If Noi_dung_Edit.Trim <> "" Then
                Noi_dung_Edit = "Sửa điểm thi học phần " & mTen_mon & " -Lần thi " & mLan_thi & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Edit
                SaveLog(LoaiSuKien.Sua, Noi_dung_Edit)
            End If
            'Lưu điểm thi
            clsDiem.LuuDiemThi(mLan_thi, mHoc_ky, mNam_hoc, dv)
            'Load lại dữ liệu điểm
            Call trvLopTinChi_Select()
            mFlag = False
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim ID_diem As Integer
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("Diem_thi").ToString <> "" Then
                        ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                        clsDiem.Xoa_ESSDiemThi(ID_diem, mHoc_ky, mNam_hoc, mLan_thi)
                        dtDiem.Rows(i)("Diem_thi") = DBNull.Value
                        dtDiem.Rows(i)("TBCMH") = DBNull.Value
                    End If
                Next
                'Load lại dữ liệu điểm
                Call trvLopTinChi_Select()
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
        '        Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String
        '        Dim dtTP As DataTable
        '        If trvLopTinChi.ID_lop_tc.ToString <> "" Then 'La Lop
        '            Tieu_de1 = "BẢNG ĐIỂM TỔNG KẾT HỌC PHẦN LẦN " + cmbLan_thi.Text
        '            Tieu_de2 = "Học phần: " + trvLopTinChi.Ten_mon
        '            Tieu_de3 = "Học ky: " + trvLopTinChi.Hoc_ky.ToString + " - Năm học: " + trvLopTinChi.Nam_hoc
        '            Tieu_de4 = "Trình độ đào tạo: " + trvLopTinChi.Ten_he
        '            Tieu_de5 = "Lớp: " & trvLopTinChi.Ten_lop_tc.ToUpper
        '            Tieu_de6 = ""
        '            Tieu_de7 = ""
        '        Else
        '            Tieu_de1 = "BẢNG ĐIỂM TỔNG KẾT HỌC PHẦN LẦN " + cmbLan_thi.Text
        '            Tieu_de2 = "HỌC PHẦN: " + trvLopTinChi.Ten_mon
        '            Tieu_de3 = "HỌC KỲ: " + trvLopTinChi.Hoc_ky.ToString + " NĂM HỌC: " + trvLopTinChi.Nam_hoc
        '            Tieu_de4 = "Trình độ đào tạo: " + trvLopTinChi.Ten_he
        '            Tieu_de5 = ""
        '            Tieu_de6 = ""
        '            Tieu_de7 = ""
        '        End If
        '        dtTP = clsDiem.DanhSachThanhPhanChon

        '        Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
        '        'Dim dt As DataTable = dtDiemTH.Copy
        '        Dim XS, Gioi, Kha, TB, Duoi5 As Integer
        '        dtDiemTH.DefaultView.RowFilter = "TBCMH >= 9"
        '        XS = dtDiemTH.DefaultView.Count
        '        dtDiemTH.DefaultView.RowFilter = "TBCMH >= 8 AND TBCMH < 9"
        '        Gioi = dtDiemTH.DefaultView.Count
        '        dtDiemTH.DefaultView.RowFilter = "TBCMH >= 7 AND TBCMH < 8"
        '        Kha = dtDiemTH.DefaultView.Count
        '        dtDiemTH.DefaultView.RowFilter = "TBCMH >= 5 AND TBCMH < 7"
        '        TB = dtDiemTH.DefaultView.Count
        '        dtDiemTH.DefaultView.RowFilter = "TBCMH < 5 "
        '        Duoi5 = dtDiemTH.DefaultView.Count

        '        dtDiemTH.DefaultView.RowFilter = ""

        '        Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemTongKetHocPhan", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
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
                If trvLopTinChi.ID_lop_tc.ToString <> "" Then 'La Lop
                    Tieu_de1 = "ĐIỂM MÔN HỌC, MÔ ĐUN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + trvLopTinChi.Hoc_ky.ToString + " - Năm học: " + trvLopTinChi.Nam_hoc
                    Tieu_de3 = ""
                    Tieu_de4 = ""
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                Else
                    Tieu_de1 = "ĐIỂM MÔN HỌC, MÔ ĐUN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + trvLopTinChi.Hoc_ky.ToString + " - Năm học: " + trvLopTinChi.Nam_hoc
                    Tieu_de3 = ""
                    Tieu_de4 = ""
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                End If
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
                dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_lop_HC", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Ten_phong", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Ngay_cham", GetType(String))

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Ten_lop_HC") = dtDiemTH.Rows(i)("Ten_lop")
                    dtDiemTH.Rows(i)("Ten_lop") = trvLopTinChi.Ten_lop_tc
                    dtDiemTH.Rows(i)("Khoa_hoc") = trvLopTinChi.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = trvLopTinChi.Ten_mon.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = trvLopTinChi.Ten_mon.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = trvLopTinChi.Ten_mon.Split("|").GetValue(2)
                    dtDiemTH.Rows(i)("Ten_phong") = ""
                    dtDiemTH.Rows(i)("Ngay_thi") = ""
                    dtDiemTH.Rows(i)("Tong_tiet") = ""
                    dtDiemTH.Rows(i)("Ngay_cham") = ""
                    dtDiemTH.Rows(i)("Tong_SV") = "Tổng số sinh viên: " & dtDiemTH.Rows.Count.ToString
                Next

                Dim XS, Gioi, Kha, TB, Duoi5 As Integer
                dtDiemTH.DefaultView.RowFilter = "TBCMH >= 9"
                XS = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCMH >= 8 AND TBCMH < 9"
                Gioi = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCMH >= 7 AND TBCMH < 8"
                Kha = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCMH >= 5 AND TBCMH < 7"
                TB = dtDiemTH.DefaultView.Count
                dtDiemTH.DefaultView.RowFilter = "TBCMH < 5 "
                Duoi5 = dtDiemTH.DefaultView.Count

                dtDiemTH.DefaultView.RowFilter = ""
                'Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemCuoiKy_Lop_TinChi", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
                'frmESS_.ShowDialog1(clsDiem)
                Dim rpt As New rptMARK_BangDiemTongKetHocPhan_HVCS_09(dtDiemTH.DefaultView, dtTP, Tieu_de1)
                PrintXtraReport(rpt)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

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

    Private Sub cmdGhiChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGhiChu.Click
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
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

                    Dim dr1 As DataRow = dt_tp.NewRow
                    dr1("ID_tp") = 1
                    dr1("Ten_TP") = "Điểm thi"
                    dt_tp.Rows.Add(dr1)
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
                dv.Item(i)("Diem_thi") = dt.DefaultView.Item(0)(cmbCot_diem.Text)
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

    Private Sub cmdLock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Dim dv As DataView = grdViewDiem.DataSource
        Dim clsDiem As New Diem_Bussines()
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("ID_diem").ToString <> "" Then clsDiem.CapNhat_ESSDiemThiLock_ChuanHoa(dv.Item(i)("ID_diem"), mHoc_ky, mNam_hoc, 1, mLan_thi)
        Next
        trvLopTinChi_Select()
    End Sub
End Class