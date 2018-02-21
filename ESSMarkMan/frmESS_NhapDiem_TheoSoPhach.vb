Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility

Public Class frmESS_NhapDiem_TheoSoPhach
    Private So_diem_thi As Integer = 0
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mHoc_ky_thi As Integer = 0
    Private mNam_hoc_thi As String = ""

    Private mID_thi As Integer = 0
    Private mLan_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mID_khoa As Integer = 0
    Private mTen_khoa As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""


    Private clsDiem As New Diem_Bussines
    Private clsTCThi As TochucThi_Bussines
#Region "Functions And Subs"
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

            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "So_phach"
                .DataPropertyName = "So_phach"
                .HeaderText = "Số phách"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDiem.Columns.Add(col3)
            'TBCMH
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "TBCMH"
                .DataPropertyName = "TBCMH"
                .HeaderText = "TBC MH"
                .Width = 50
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
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
            End With
            Me.grdViewDiem.Columns.Add(col5)
            'Các thành phần điểm
            Dim Tong_ty_le As Integer = 0
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
                        col.Width = 40
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                        col.ReadOnly = True
                        Tong_ty_le += .Ty_le
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'Điểm thi
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Diem_thi"
                .DataPropertyName = "Diem_thi"
                .HeaderText = "Thi (" + (100 - Tong_ty_le).ToString + ")"
                .Width = 50
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
            Lock_diem = False
            For i As Integer = 0 To grdViewDiem.RowCount - 1
                If grdViewDiem.Rows(i).Cells("Locked").Value = True Then    'Locked
                    If Lock_diem = False Then Lock_diem = True
                    grdViewDiem.Rows(i).Cells("Diem_thi").ReadOnly = True
                    Dim CellImage As New DataGridViewImageCell
                    CellImage.Value = My.Resources.Locked
                    CellImage.ImageLayout = DataGridViewImageCellLayout.Normal
                    grdViewDiem.Rows(i).Cells("imgLock") = CellImage
                Else
                    If grdViewDiem.Rows(i).Cells("Diem_thi").Value.ToString <> "" Then    'Edit
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
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Doc_tham_so_he_thong()
        Dim cls As New ThamSoHeThong_Bussines
        So_diem_thi = cls.Doc_tham_so("So_diem_thi")
        Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
        Lam_tron_diem_thi = cls.Doc_tham_so("Lam_tron_diem_thi")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemSoPhach_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, cmdSave, , cmdDelete)
            'UsersChucNangAcess(cmdSave, cmdDelete, cmdLock)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemSoPhach_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            Dim idx_diem, idx_diem_thi As Integer
            Dim Noi_dung_Add As String = ""
            Dim Noi_dung_Edit As String = ""
            Dim dv As DataView = grdViewDiem.DataSource

            'Gán các điểm thi vào object điểm, điểm thi
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                idx_diem = dtDiem.Rows(i)("idx_diem")
                idx_diem_thi = dtDiem.Rows(i)("idx_diem_thi")
                If dtDiem.Rows(i)("Diem_thi").ToString <> "" Or dtDiem.Rows(i)("Ghi_chu").ToString = "X" Then
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
            Call trvPhongThi_Select()
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As Object, ByVal e As System.EventArgs)
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
                Call trvPhongThi_Select()
                Thongbao("Đã xoá điểm thành công")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

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

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            If Loader Then
                Dim Ngoai_ngu As String = ""
                If cmbID_ngoai_ngu.SelectedIndex <> -1 Then
                    Ngoai_ngu = cmbID_ngoai_ngu.Text.Trim
                    If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
                    If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
                    If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
                    If Ngoai_ngu.ToUpper = "TIẾNG TRUNG" Then Ngoai_ngu = "T"
                End If

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                mTen_mon = trvPhongThi.Ten_mon
                mTen_phong = trvPhongThi.Phong_thi
                mTen_khoa = trvPhongThi.Ten_khoa
                mID_khoa = trvPhongThi.ID_khoa
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDiem_chu, dtDiemKyHieu As DataTable
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                        Dim dv As DataView
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
                        If mLan_thi = 1 Then
                            dv = clsDiem.DanhSachDiemThiLan1(mID_mon, mHoc_ky, mNam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            dv.Sort = "So_phach"
                            grdViewDiem.DataSource = dv
                        Else
                            dv = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, KyHieu, mHoc_ky, mNam_hoc).DefaultView
                            dv.RowFilter = RowFilter
                            dv.Sort = "So_phach"
                            grdViewDiem.DataSource = dv
                        End If
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

    Private Sub cmdPrint_sochu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If

                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim dtTP As DataTable
                Tieu_de1 = "KẾT QUẢ HỌC TẬP " & mTen_mon.ToUpper
                Tieu_de2 = "Lần thi: " & mLan_thi & " Học kỳ:" & mHoc_ky & " Năm học: " & mNam_hoc
                Tieu_de3 = mTen_phong & vbTab & "Ngày thi: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")

                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
                Dim dt As DataTable = dtDiemTH.Copy
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Diem_chu") = Diem_chu(dt.Rows(i).Item("TBCMH").ToString)
                Next

                Dim XS, Gioi, Kha, TB, Duoi5 As Integer
                dt.DefaultView.RowFilter = "TBCMH >= 9"
                XS = dt.DefaultView.Count
                dt.DefaultView.RowFilter = "TBCMH >= 8 AND TBCMH < 9"
                Gioi = dt.DefaultView.Count
                dt.DefaultView.RowFilter = "TBCMH >= 7 AND TBCMH < 8"
                Kha = dt.DefaultView.Count
                dt.DefaultView.RowFilter = "TBCMH >= 5 AND TBCMH < 7"
                TB = dt.DefaultView.Count
                dt.DefaultView.RowFilter = "TBCMH < 5 "
                Duoi5 = dt.DefaultView.Count

                dt.DefaultView.RowFilter = ""
                dtTP = clsDiem.DanhSachThanhPhanChon
                TaoBaoCaoBangDiemThiHocPhan_DSLop_HC(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP, XS, Gioi, Kha, TB, Duoi5)
                C1Report1.DataSource.Recordset = dt
                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_tinchi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dt_ngay As DataTable = clsTCThi.DanhSachMonToChucThi()
                If dt_ngay.Rows.Count > 0 Then
                    mNgay_thi = dt_ngay.Rows(0).Item("Ngay_thi")
                End If

                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim dtTP As DataTable
                Tieu_de1 = "KẾT QUẢ HỌC TẬP " & mTen_mon.ToUpper
                Tieu_de2 = "Lần thi: " & mLan_thi & " Học kỳ:" & mHoc_ky & " Năm học: " & mNam_hoc
                Tieu_de3 = mTen_phong & vbTab & "Ngày thi: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")

                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
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
                dtTP = clsDiem.DanhSachThanhPhanChon
                TaoBaoCaoBangDiemThiHocPhan_DSLop_HC(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP, XS, Gioi, Kha, TB, Duoi5)
                C1Report1.DataSource.Recordset = dtDiemTH
                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog(C1Report1)
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Print_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdGhiChuKyHieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmESS_ As New frmESS_DMDiemKyHieu
        frmESS_.ShowDialog()
    End Sub

    Private Sub cmbID_ngoai_ngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_ngoai_ngu.SelectedIndexChanged
        If cmbID_ngoai_ngu.SelectedIndex = -1 Then Exit Sub
        trvPhongThi_Select()
    End Sub

    Private Sub frmESS_NhapDiemSoPhach_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub cmbKy_hieu_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKy_hieu.SelectedIndexChanged
        trvPhongThi_Select()
    End Sub
End Class