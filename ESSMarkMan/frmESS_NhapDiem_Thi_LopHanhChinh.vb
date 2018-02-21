Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Imports ESSUtility
Imports ESSReports

Public Class frmESS_NhapDiem_Thi_LopHanhChinh
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private So_lan_thi_lai As Integer = 2
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsDiem As New Diem_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private mdtDanhSachSinhVien As New DataTable
    Private mLan_thi As Integer = 1
    Private mFlag As Boolean = False

    Private xlsFileName As String = ""
    Private dt As New DataTable
    Private Tong_ty_le As Double = 0
    Private Tong_TP_ThucHanh As Double = 0

#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            Add_LanThi(cmbLan_thi, So_lan_thi_lai)

            Add_Hocky(cmbHoc_ky_Thi)
            Add_Namhoc(cmbNam_hoc_Thi)
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
                .HeaderText = "Mã SV"
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
                .Width = 80
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
                .Width = 80
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
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TreeViewLop.HienThi_ESSTreeView()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, cmdSave, , cmdDelete)
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



    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not TreeViewLop.ID_lop_list Is Nothing Then
                    dsID_lop = TreeViewLop.ID_lop_list
                    dsID_dt = TreeViewLop.ID_dt_list
                    mNien_khoa = TreeViewLop.Nien_khoa
                    'Load danh sách các Học phần trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        'clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, 0)
                        clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, gobjUser.ID_Bomon)
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
                cmbHoc_ky_Thi.SelectedIndex = cmbHoc_ky.SelectedIndex
                cmbNam_hoc_Thi.SelectedIndex = cmbNam_hoc.SelectedIndex
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged, cmbHoc_ky_Thi.SelectedIndexChanged, cmbNam_hoc_Thi.SelectedIndexChanged, cmbLan_thi.SelectedIndexChanged, cmbLan_thi.SelectedIndexChanged, cmbID_ngoai_ngu.SelectedIndexChanged, cmbKy_hieu.SelectedIndexChanged
        Try
            'Load danh sách điểm của sinh viên
            Try
                If Loader Then
                    'Ty_le_ThucHanh = False
                    Dim Ngoai_ngu As String = ""
                    If cmbID_ngoai_ngu.SelectedIndex <> -1 Then Ngoai_ngu = cmbID_ngoai_ngu.Text.Trim
                    If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
                    If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
                    If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
                    If Ngoai_ngu.ToUpper = "TIẾNG TRUNG" Then Ngoai_ngu = "T"
                    Dim dv As DataView
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky_Thi.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc_Thi.Text
                    Dim Hoc_ky_Main As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc_Main As String = cmbNam_hoc.Text
                    If chkUpdate.Checked Then Exit Sub

                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim dtDiemChu, dtDiemKyHieu As DataTable
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        'clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien)
                        Dim KyHieu As Integer = -1
                        If cmbKy_hieu.Text <> "" Then KyHieu = cmbKy_hieu.SelectedIndex
                        Dim RowFilter As String = " 1=1 "
                        If Ngoai_ngu <> "" Then
                            RowFilter += " AND Ngoai_ngu='" & Ngoai_ngu & "'"
                        End If
                        If KyHieu = 1 Then 'Thieu diem TP
                            RowFilter += " AND Ghi_chu='I'"
                        ElseIf KyHieu = 2 Then 'Thieu diem Thi
                            RowFilter += " AND Ghi_chu='X'"
                        ElseIf KyHieu = 3 Then 'Khong tinh diem TP vao hoc phan
                            RowFilter += " AND Ghi_chu='VC'"
                        End If

                        If cmbLan_thi.SelectedValue = 1 Then
                            clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien)
                            dv = clsDiem.DanhSachDiemThiLan1(ID_mon, Hoc_ky, Nam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            grdViewDiem.DataSource = dv
                        Else
                            clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien)
                            dv = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, KyHieu, Hoc_ky, Nam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            grdViewDiem.DataSource = dv
                        End If

                        'If cmbLan_thi.SelectedValue = 1 Then
                        '    If (Hoc_ky_Main < Hoc_ky And Nam_hoc_Main <= Nam_hoc) Or (Nam_hoc_Main < Nam_hoc) Then ' Voi sinh vien phai hoc lai
                        '        clsDiem = New Diem_Bussines(ID_dv, 0, "", ID_mon, dsID_lop, mdtDanhSachSinhVien)
                        '        grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, KyHieu, Hoc_ky, Nam_hoc).DefaultView
                        '    Else
                        '        clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien)
                        '        grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan1(ID_mon, Hoc_ky, Nam_hoc).DefaultView
                        '    End If
                        'ElseIf cmbLan_thi.SelectedValue > 1 Then
                        '    If (Hoc_ky_Main < Hoc_ky And Nam_hoc_Main <= Nam_hoc) Or (Nam_hoc_Main < Nam_hoc) Then ' Voi sinh vien phai hoc lai
                        '        clsDiem = New Diem_Bussines(ID_dv, 0, "", ID_mon, dsID_lop, mdtDanhSachSinhVien)
                        '        grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, KyHieu, Hoc_ky, Nam_hoc).DefaultView
                        '    Else
                        '        clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien)
                        '        grdViewDiem.DataSource = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, KyHieu, Hoc_ky, Nam_hoc).DefaultView
                        '    End If
                        'End If

                        'If cmbLan_thi.SelectedValue = 1 Then
                        'dv = clsDiem.DanhSachDiemThiLan1(ID_mon).DefaultView
                        '    dv.RowFilter = RowFilter
                        '    grdViewDiem.DataSource = dv
                        'Else
                        '    dv = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, chkNot_show_all.Checked, KyHieu).DefaultView
                        '    dv.RowFilter = RowFilter
                        '    grdViewDiem.DataSource = dv
                        'End If
                        dtDiemChu = clsDiem.HienThi_ESSDiem_chu
                        dtDiemKyHieu = clsDiem.HienThi_ESSDiemKyHieu_DanhSach
                        FormatDataView(dtDiemChu, dtDiemKyHieu)
                        Dim Lock_diem As Boolean = False
                        KhoaDuLieu(Lock_diem)
                        If Lock_diem = True Then
                            cmdDelete.Enabled = False
                            cmdSave.Enabled = False
                            cmdUpdate.Enabled = False
                        Else
                            cmdDelete.Enabled = True
                            cmdSave.Enabled = True
                            cmdUpdate.Enabled = True
                        End If
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    SetQuyenTruyCap(, cmdSave, , cmdDelete)
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    'Private Sub cmbLan_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thi.SelectedIndexChanged
    'If Loader Then
    '    Dim Ngoai_ngu As String = ""
    '    If cmbID_ngoai_ngu.SelectedIndex <> -1 Then
    '        Ngoai_ngu = cmbID_ngoai_ngu.Text.Trim
    '        If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
    '        If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
    '        If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
    '        If Ngoai_ngu.ToUpper = "TIẾNG TRUNG" Then Ngoai_ngu = "T"
    '    End If
    '    Dim ID_mon As Integer = cmbID_mon.SelectedValue
    '    mLan_thi = cmbLan_thi.SelectedValue
    '    Dim dv As DataView
    '    If mLan_thi = 1 Then
    '        dv = clsDiem.DanhSachDiemThiLan1(ID_mon).DefaultView
    '        If Ngoai_ngu <> "" Then
    '            dv.RowFilter = "1=1 AND Ngoai_ngu='" & Ngoai_ngu & "'"
    '        End If
    '        grdViewDiem.DataSource = dv
    '    Else
    '        Dim KyHieu As Integer = -1
    '        If cmbKy_hieu.Text <> "" Then KyHieu = cmbKy_hieu.SelectedIndex
    '        dv = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, chkNot_show_all.Checked, KyHieu).DefaultView
    '        Dim RowFilter As String = " 1=1 "
    '        If Ngoai_ngu <> "" Then
    '            RowFilter += " AND Ngoai_ngu='" & Ngoai_ngu & "'"
    '        End If
    '        If KyHieu = 2 Then 'Thieu diem TP
    '            RowFilter += " AND Ghi_chu='I'"
    '        ElseIf KyHieu = 3 Then 'Thieu diem Thi
    '            RowFilter += " AND Ghi_chu='X'"
    '        ElseIf KyHieu = 4 Then 'Khong tinh diem TP vao hoc phan
    '            RowFilter += " AND Ghi_chu='VC'"
    '        End If
    '        dv.RowFilter = RowFilter
    '        grdViewDiem.DataSource = dv
    '    End If
    '    Dim Lock_diem As Boolean = False
    '    KhoaDuLieu(Lock_diem)
    '    If Lock_diem = True Then
    '        cmdDelete.Enabled = False
    '        cmdSave.Enabled = False
    '    Else
    '        cmdDelete.Enabled = True
    '        cmdSave.Enabled = True
    '    End If
    'End If
    'End Sub

#End Region
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
    End Function

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("TBCMH").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThiLock(dtDiem.Rows(i)("ID_diem"), 1, cmbLan_thi.SelectedValue)
                End If
            Next
            'Load lại dữ liệu điểm
            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    'Private Sub cmbID_ngoai_ngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_ngoai_ngu.SelectedIndexChanged, cmbKy_hieu.SelectedIndexChanged
    '    Try
    '        'Load danh sách điểm của sinh viên
    '        Try
    '            If Loader Then
    '                Dim Ngoai_ngu As String = ""
    '                If cmbID_ngoai_ngu.SelectedIndex <> -1 Then
    '                    Ngoai_ngu = cmbID_ngoai_ngu.Text.Trim
    '                    If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
    '                    If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
    '                    If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
    '                    If Ngoai_ngu.ToUpper = "TIẾNG TRUNG" Then Ngoai_ngu = "T"
    '                End If
    '                Dim ID_dv As String = gobjUser.ID_dv
    '                Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
    '                Dim Nam_hoc As String = cmbNam_hoc.Text
    '                Dim ID_mon As Integer = cmbID_mon.SelectedValue
    '                Dim dtDiemChu, dtDiemKyHieu As DataTable
    '                If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
    '                    Dim dv As DataView
    '                    Dim KyHieu As Integer = -1
    '                    If cmbKy_hieu.Text <> "" Then KyHieu = cmbKy_hieu.SelectedIndex
    '                    Dim RowFilter As String = " 1=1 "
    '                    If Ngoai_ngu <> "" Then
    '                        RowFilter += " AND Ngoai_ngu='" & Ngoai_ngu & "'"
    '                    End If
    '                    If KyHieu = 1 Then 'Thieu diem TP
    '                        RowFilter += " AND Ghi_chu='I'"
    '                    ElseIf KyHieu = 2 Then 'Thieu diem Thi
    '                        RowFilter += " AND Ghi_chu='X'"
    '                    ElseIf KyHieu = 3 Then 'Khong tinh diem TP vao hoc phan
    '                        RowFilter += " AND Ghi_chu='VC'"
    '                    ElseIf KyHieu = 4 Then 'Bao lu
    '                        RowFilter += " AND Ghi_chu='B'"
    '                    End If
    '                    If cmbLan_thi.SelectedValue = 1 Then
    '                        dv = clsDiem.DanhSachDiemThiLan1(ID_mon).DefaultView
    '                        dv.RowFilter = RowFilter
    '                        grdViewDiem.DataSource = dv
    '                    Else
    '                        dv = clsDiem.DanhSachDiemThiLan(cmbLan_thi.SelectedValue, ID_mon, chkNot_show_all.Checked, KyHieu).DefaultView
    '                        dv.RowFilter = RowFilter
    '                        grdViewDiem.DataSource = dv
    '                    End If
    '                    dtDiemChu = clsDiem.HienThi_ESSDiem_chu
    '                    dtDiemKyHieu = clsDiem.HienThi_ESSDiemKyHieu_List
    '                    FormatDataView(dtDiemChu, dtDiemKyHieu)
    '                    Dim Lock_diem As Boolean = False
    '                    KhoaDuLieu(Lock_diem)
    '                    If Lock_diem = True Then
    '                        cmdDelete.Enabled = False
    '                        cmdSave.Enabled = False
    '                    Else
    '                        cmdDelete.Enabled = True
    '                        cmdSave.Enabled = True
    '                    End If
    '                Else
    '                    grdViewDiem.DataSource = Nothing
    '                End If
    '            End If
    '        Catch ex As Exception
    '            Thongbao(ex.Message)
    '        End Try
    '    Catch ex As Exception
    '        Thongbao(ex.Message)
    '    End Try
    'End Sub

    Private Sub frmESS_NhapDiemThiLop_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub cmdPrintBienBanThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim dtTP As DataTable
                If TreeViewLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de1 = "BIÊN BẢN THI LẦN: " + cmbLan_thi.Text + " " + TreeViewLop.Tieu_de_Lop.ToUpper
                    Tieu_de2 = "Học kỳ: " + cmbHoc_ky.Text + " Năm học: " + cmbNam_hoc.Text
                    Tieu_de3 = "Học phần: " + cmbID_mon.Text
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

    Private Sub grdViewDiem_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdViewDiem.CellEndEdit
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

    Private Sub grdViewDiem_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdViewDiem.Leave
        'If mFlag Then
        '    If Thongbao("Bạn vừa nhập mới hoặc thay đổi điểm thi, bạn có muốn lưu lại không?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '        cmdSave_Click(sender, e)
        '        mFlag = False
        '    Else
        '        mFlag = False
        '        cmbMonHoc_SelectedIndexChanged(sender, e)
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
        Me.Cursor = Cursors.WaitCursor
        Try
            grdViewDiem.EndEdit()
            Dim Hoc_ky_Thi As Integer = cmbHoc_ky_Thi.SelectedValue
            Dim Nam_hoc_Thi As String = cmbNam_hoc_Thi.Text
            Dim dv As DataView = grdViewDiem.DataSource

            Dim Hoc_ky_Main As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc_Main As String = cmbNam_hoc.Text

            Dim Lan_thi As Integer = cmbLan_thi.SelectedValue
            Dim ID_mon As Integer = cmbID_mon.SelectedValue
            Dim ID_dt As Integer = 0
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""

            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                'If Tong_TP_ThucHanh = 0 Or Ty_le_ThucHanh Then
                '    dtDiem.Rows(i)("Diem_thi") = 0
                'End If
                'If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Or dtDiem.Rows(i)("Ghi_chu").ToString = "K" Or dtDiem.Rows(i)("Ghi_chu").ToString = "P" Then
                If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Or dtDiem.Rows(i)("Ghi_chu").ToString = "K" Then
                    Dim objDiem As New ESSDiem
                    Dim objDiemThi As New ESSDiemThi
                    objDiem.ID_mon = ID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                    'Nếu chưa có Học phần này thì insert thêm vào object điểm
                    If idx_diem = -1 Then
                        objDiem.Hoc_ky = Hoc_ky_Thi
                        objDiem.Nam_hoc = Nam_hoc_Thi
                        clsDiem.Add(objDiem)
                    Else
                        objDiem.Hoc_ky = dtDiem.Rows(i)("hoc_ky")
                        objDiem.Nam_hoc = dtDiem.Rows(i)("Nam_hoc")
                        clsDiem.CapNhat_ESSDiem(objDiem, dtDiem.Rows(i)("ID_diem"))
                        objDiem = clsDiem.ESSDiem(idx_diem)
                    End If
                    'Nếu là nhập mới điểm thi thì insert thêm object điểm thi mới
                    If idx_diem_thi = -1 Then
                        objDiemThi.Hoc_ky_thi = Hoc_ky_Thi
                        objDiemThi.Nam_hoc_thi = Nam_hoc_Thi
                        objDiemThi.Lan_thi = Lan_thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Diem_chu = dtDiem.Rows(i)("Diem_chu").ToString
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiemThi.Hash_code = (Lan_thi.ToString + "-" + dtDiem.Rows(i)("Diem_thi").ToString + "-" + dtDiem.Rows(i)("Diem_chu").ToString + "-" + dtDiem.Rows(i)("Ghi_chu").ToString).ToString.GetHashCode
                        objDiem.dsDiemThi.Add(objDiemThi)
                        Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString & " Điểm thi:" & dtDiem.Rows(i)("Diem_thi").ToString
                    Else
                        objDiemThi.Lan_thi = Lan_thi
                        objDiemThi.Hoc_ky_thi = Hoc_ky_Thi
                        objDiemThi.Nam_hoc_thi = Nam_hoc_Thi
                        If dtDiem.Rows(i)("Diem_thi").ToString = "" Then
                            objDiemThi.Diem_thi = -1
                        Else
                            objDiemThi.Diem_thi = dtDiem.Rows(i)("Diem_thi")
                            objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_chu = dtDiem.Rows(i)("Diem_chu")
                            objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_thi = dtDiem.Rows(i)("Diem_thi")
                        End If
                        objDiemThi.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        'objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Diem_chu = dtDiem.Rows(i)("Diem_chu")

                        objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                        objDiem.dsDiemThi.ESSDiemThi(idx_diem_thi).Hash_code = (Lan_thi.ToString + "-" + dtDiem.Rows(i)("Diem_thi").ToString + "-" + dtDiem.Rows(i)("Diem_chu").ToString + "-" + dtDiem.Rows(i)("Ghi_chu").ToString).ToString.GetHashCode
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
                Noi_dung_Add = "Bổ sung điểm thi học phần Học phần: " & cmbID_mon.Text.Trim & " -Lần thi " & cmbLan_thi.Text & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            If Noi_dung_Edit.Trim <> "" Then
                Noi_dung_Edit = "Sửa điểm thi học phần Học phần: " & cmbID_mon.Text.Trim & " -Lần thi " & cmbLan_thi.Text & " -Học kỳ " & cmbHoc_ky.Text.Trim & " -Năm học " & cmbNam_hoc.Text.Trim & Noi_dung_Edit
                SaveLog(LoaiSuKien.Sua, Noi_dung_Edit)
            End If
            'Lưu điểm thi
            clsDiem.LuuDiemThi(Lan_thi, Hoc_ky_Thi, Nam_hoc_Thi, dv)
            'Load lại dữ liệu điểm
            Call cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
            mFlag = False
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If Thongbao("Chắc chắn bạn muốn xoá điểm của tất cả các sinh viên không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
                Dim Hoc_ky_Thi As Integer = cmbHoc_ky_Thi.SelectedValue
                Dim Nam_hoc_Thi As String = cmbNam_hoc_Thi.Text
                Dim Lan_thi As Integer = cmbLan_thi.SelectedValue
                Dim ID_diem As Integer
                For i As Integer = 0 To dtDiem.Rows.Count - 1
                    If dtDiem.Rows(i)("Diem_thi").ToString <> "" Then
                        ID_diem = CInt("0" + dtDiem.Rows(i)("ID_diem").ToString)
                        clsDiem.Xoa_ESSDiemThi(ID_diem, Hoc_ky_Thi, Nam_hoc_Thi, Lan_thi)
                        dtDiem.Rows(i)("Diem_thi") = DBNull.Value
                        dtDiem.Rows(i)("TBCMH") = DBNull.Value
                    End If
                Next
                'Load lại dữ liệu điểm
                Call cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                Thongbao("Đã xoá điểm thành công")
            End If
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


    Private Sub cmdGhiChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGhiChu.Click
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
    End Sub

    Private Sub cmdPrint_BDT_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_BDT.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String
                Dim dtTP As DataTable
                If TreeViewLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de1 = "ĐIỂM HỌC PHẦN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + cmbHoc_ky.Text + " - Năm học: " + cmbNam_hoc.Text
                    Tieu_de3 = ""
                    Tieu_de4 = ""
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                Else
                    Tieu_de1 = "ĐIỂM HỌC PHẦN LẦN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + cmbHoc_ky.Text + " - Năm học: " + cmbNam_hoc.Text
                    Tieu_de3 = ""
                    Tieu_de4 = ""
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                End If
                dtTP = clsDiem.DanhSachThanhPhanChon
                Dim dtDiemTH As DataTable

                Dim dt As DataTable = grdViewDiem.DataSource.Table
                dtDiemTH = dt.Copy
                dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Ten_phong", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Ngay_cham", GetType(String))

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Khoa_hoc") = TreeViewLop.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = cmbID_mon.Text.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = cmbID_mon.Text.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = cmbID_mon.Text.Split("|").GetValue(2)
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
                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemTongKetHocPhan_HVCS", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
                frmESS_.ShowDialog()

            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub cmdPrint_DSThi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi.ItemClick
        Try
            Dim dv1 As DataView = grdViewDiem.DataSource
            Dim Tieu_de1 As String = ""

            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Lan_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ten_mon") = cmbID_mon.Text
                    dt.Rows(i).Item("So_hoc_trinh") = ""
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Lan_thi") = cmbLan_thi.Text
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Viết"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next

                Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_Viet", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DSThi2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi2.ItemClick
        Try
            Dim dv1 As DataView = grdViewDiem.DataSource
            Dim Tieu_de1 As String = ""

            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Lan_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ten_mon") = cmbID_mon.Text
                    dt.Rows(i).Item("So_hoc_trinh") = ""
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Lan_thi") = cmbLan_thi.Text
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Vấn đáp"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next

                Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_VanDap", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
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

                Dim mHoc_ky As Integer = cmbHoc_ky_Thi.Text.Trim
                Dim mNam_hoc As String = cmbNam_hoc_Thi.Text.Trim

                If mHoc_ky > 0 And mNam_hoc <> "" Then
                    SQL_Del1 = "DELETE MARK_DiemThanhPhan_TC WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                     " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    SQL_Del2 = "DELETE MARK_DiemThi_TC WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    SQL_Del = "DELETE MARK_Diem_TC WHERE ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & ")" & " AND Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "'"

                    SQL = "UPDATE MARK_Diem_TC SET Hoc_ky=" & mHoc_ky & ", Nam_hoc='" & mNam_hoc & "' WHERE ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & ")"


                    SQL1 = "UPDATE MARK_DiemThanhPhan_TC SET Hoc_ky_TP=" & mHoc_ky & ", Nam_hoc_TP='" & mNam_hoc & "' WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"


                    SQL2 = "UPDATE MARK_DiemThi_TC SET Hoc_ky_thi=" & mHoc_ky & ", Nam_hoc_thi='" & mNam_hoc & "' WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE Hoc_ky=" & mHoc_ky & " AND Nam_hoc='" & mNam_hoc & "' AND ID_dt=" & ID_dt & _
                    " AND ID_mon =" & cmbID_mon.SelectedValue & " AND ID_sv in (SELECT DISTINCT Id_sv FROM STU_DANHSACH WHERE Id_lop=" & ID_lop & "))"

                    Try
                        Connect.Execute(SQL)
                        Connect.Execute(SQL1)
                        Connect.Execute(SQL2)
                    Catch ex As Exception
                        'Thongbao("Kiểm tra lại dữ liệu !" & ex.Message & " - " & ID_dt & "-" & ID_lop & "-" & cmbID_mon.SelectedValue, MsgBoxStyle.Information)
                        If Thongbao("Đã tồn tại điểm của sinh viên theo học kỳ đã chọn, bạn hãy xóa trước khi cập nhật điểm." & vbCrLf & "Bạn có muốn xóa không?", MsgBoxStyle.Question) = MsgBoxResult.Yes Then
                            Connect.Execute(SQL_Del1)
                            Connect.Execute(SQL_Del2)
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

    Private Sub cmdImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImport.Click
        Dim frm As New frmESS_HoTroNhapDiemTuExcel
        frm.ShowDialog()
    End Sub

    Private Sub btnBang_diem_thi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles btnBang_diem_thi.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String
                If TreeViewLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de1 = "ĐIỂM MÔN HỌC, MÔ ĐUN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + cmbHoc_ky.Text + " - Năm học: " + cmbNam_hoc.Text
                    Tieu_de3 = ""
                    Tieu_de4 = ""
                    Tieu_de5 = ""
                    Tieu_de6 = ""
                    Tieu_de7 = ""
                Else
                    Tieu_de1 = "ĐIỂM MÔN HỌC, MÔ ĐUN PHẦN LẦN LẦN " + cmbLan_thi.Text
                    Tieu_de2 = "Học ky: " + cmbHoc_ky.Text + " - Năm học: " + cmbNam_hoc.Text
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
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Ten_phong", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Ngay_cham", GetType(String))

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Khoa_hoc") = TreeViewLop.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = cmbID_mon.Text.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = cmbID_mon.Text.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = cmbID_mon.Text.Split("|").GetValue(2)
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
                Dim rpt As New rptMARK_BangDiemTongKetHocPhan_HVCS_09(dtDiemTH.DefaultView, dtTP, Tieu_de1)
                PrintXtraReport(rpt)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class