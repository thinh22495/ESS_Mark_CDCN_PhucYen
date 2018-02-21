Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Imports ESSConnect

Public Class frmESS_NhapDiem_ThanhPhan_LopTinChi
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mTen_lop_tc As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private dsID_lop As String = ""
    Private sID_lop_tc As String = ""
    Private dsID_lop_tc As String = ""
    Private Loader As Boolean = False
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines
    Private clsXet As DanhSachKhongThi_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private xlsFileName As String = ""
    Private dt As New DataTable

#Region "Functions And Subs"
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

            'Số tiết nghỉ
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "So_tiet_nghi_co_phep"
                .DataPropertyName = "So_tiet_nghi_co_phep"
                .HeaderText = "Số tiết nghỉ có phép"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col4)
            'Số tiết nghỉ
            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "So_tiet_nghi_khong_phep"
                .DataPropertyName = "So_tiet_nghi_khong_phep"
                .HeaderText = "Số tiết nghỉ không phép"
                .Width = 80
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col5)

            'Thiếu bài thực hành
            Dim col6 As New DataGridViewCheckBoxColumn
            With col6
                .Name = "Thieu_bai_thuc_hanh"
                .DataPropertyName = "Thieu_bai_thuc_hanh"
                .HeaderText = "Thiếu bài TH"
                .Width = 70
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                '.DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDiem.Columns.Add(col6)

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
            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "TBCBP"
                .DataPropertyName = "TBCBP"
                .HeaderText = "TBCBP"
                .Width = 80
                .DefaultCellStyle.Format = "N" + Lam_tron_TBCMH.ToString
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
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
                        'If Not grdViewDiem.Rows(i).Cells("TP" + clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan.ToString).Value Is Nothing _
                        'AndAlso grdViewDiem.Rows(i).Cells("TP" + clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan.ToString).Value.ToString <> "" Then
                        '    Checked = True
                        '    Exit For
                        'End If

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
        Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
        Lam_tron_diem_thi = cls.Doc_tham_so("Lam_tron_diem_thi")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(cmdLock, cmdSave, cmdDiemThanhPhan, cmdDelete)

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
    Private Sub trvLop_Select() Handles trvLopTinChi.TreeNodeSelected_
        Try
            If Loader Then
                Dim ID_dv As String = gobjUser.ID_dv
                'Dim dsID_lop As String = ""
                mHoc_ky = trvLopTinChi.Hoc_ky
                mNam_hoc = trvLopTinChi.Nam_hoc
                mID_mon_tc = trvLopTinChi.ID_mon_tc
                mID_lop_tc = trvLopTinChi.ID_lop_tc
                dsID_lop_tc = trvLopTinChi.dsID_lop_tc
                mID_mon = trvLopTinChi.ID_mon
                mTen_mon = trvLopTinChi.Ten_mon
                mTen_lop_tc = trvLopTinChi.Ten_lop_tc
                dsID_lop = ""
                sID_lop_tc = ""
                If mID_mon > 0 Then
                    'chkDefault.Visible = True
                    'Load dữ liệu về tổ chức thi
                    'clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc)
                    clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc, gobjUser.UserName, gobjUser.ID_phong, optDaDuyet.Checked)
                    mdtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien
                    'Lấy danh sách các ID_lop_tc
                    If dsID_lop_tc <> "" Then dsID_lop_tc = Mid(dsID_lop_tc, 1, Len(dsID_lop_tc) - 1)
                    For i As Integer = 0 To dsID_lop_tc.Split(",").Length - 1 Step 2
                        If sID_lop_tc.Trim = "" Then
                            sID_lop_tc = dsID_lop_tc.Split(",").GetValue(i).ToString
                        Else
                            sID_lop_tc += "," + dsID_lop_tc.Split(",").GetValue(i).ToString
                        End If
                    Next
                    For i As Integer = 0 To mdtDanhSachSinhVien.Rows.Count - 1
                        If Not dsID_lop.Contains("," + mdtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                            If dsID_lop.Trim = "" Then
                                dsID_lop = mdtDanhSachSinhVien.Rows(i)("ID_lop").ToString
                            Else
                                dsID_lop += "," + mdtDanhSachSinhVien.Rows(i)("ID_lop").ToString
                            End If
                        End If
                    Next
                    If mdtDanhSachSinhVien.Rows.Count > 0 And mID_mon > 0 Then
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, mdtDanhSachSinhVien, False, True, True, sID_lop_tc, mID_mon_tc)
                        'clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                        'clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, mID_mon_tc, mID_lop_tc, mdtDanhSachSinhVien)
                        Dim dv_diem As DataView = clsDiem.DanhSachDiemThanhPhan(mID_mon, mHoc_ky, mNam_hoc).DefaultView
                        grdViewDiem.DataSource = dv_diem
                        lblSo_sv.Text = dv_diem.Count
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    FormatDataView()
                    Dim Lock_diem As Boolean = False
                    KhoaDuLieu(Lock_diem)
                    If Lock_diem = True Then
                        cmdDelete.Enabled = False
                        cmdSave.Enabled = False
                        cmdDiemThanhPhan.Enabled = False
                        btnCap_nhap_ghi_chu.Enabled = True
                    Else
                        cmdDelete.Enabled = True
                        cmdSave.Enabled = True
                        cmdDiemThanhPhan.Enabled = True
                        btnCap_nhap_ghi_chu.Enabled = False
                    End If
                    SetQuyenTruyCap(cmdLock, cmdSave, cmdDiemThanhPhan, cmdDelete)

                    If gobjUser.ID_Bomon > 0 And mID_mon > 0 Then
                        If Check_Mon_TheoKhoa(gobjUser.ID_Bomon, mID_lop_tc) Then
                            cmdSave.Enabled = True
                            cmdLock.Enabled = True
                        End If
                    End If
                Else
                    'chkDefault.Visible = False
                End If
            End If
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

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dtDiem As DataTable = grdViewDiem.DataSource.Table
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("ID_diem").ToString <> "" Then
                    clsDiem.CapNhat_ESSDiemThanhPhanLock(dtDiem.Rows(i)("ID_diem"), 1)
                End If
            Next
            'Load lại dữ liệu điểm
            Call trvLop_Select()
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
            Call trvLop_Select()
            Thongbao("Đã mở khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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

    Private Sub cmdPrintOne_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim dt_thongtinLopTC As DataTable = clsLopTC.ThongTnLopTInChi_Select(trvLopTinChi.ID_lop_tc)
                Dim Tieu_de1, Tieu_de2, Tieu_de3, Giang_duong, Tu_ngay, Den_ngay As String

                If dt_thongtinLopTC.Rows.Count > 0 Then
                    Giang_duong = dt_thongtinLopTC.Rows(0).Item("So_phong").ToString
                    Tu_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Tu_ngay").ToString, Date), "dd/MM/yyyy")
                    Den_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Den_ngay").ToString, Date), "dd/MM/yyyy")
                End If

                Dim dtTP As DataTable
                Tieu_de1 = "DANH SÁCH LỚP:  " & trvLopTinChi.Ten_lop_tc
                Tieu_de2 = "HỌC PHẦN:  " & trvLopTinChi.Ten_mon.ToUpper
                Tieu_de3 = "Giảng đường: " & Giang_duong & ", Thời gian học Từ ngày: " & Tu_ngay & " đến ngày: " & Den_ngay
                dtTP = clsDiem.DanhSachThanhPhanChon

                TaoBaoCaoBangDiemThanhPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP)
                Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table


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

    Private Sub CmdPrintAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                If dsID_lop_tc <> "" Then
                    Dim frmESS_ As New frmESS_XemBaoCao
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Tieu_de1 As String = ""
                    Dim Tieu_de2 As String = ""
                    Dim Tieu_de3 As String = ""
                    Dim Tu_ngay As String = ""
                    Dim Giang_duong As String = ""
                    Dim Den_ngay As String = ""
                    Dim arrID_lop_tc As String() = dsID_lop_tc.Split(",")
                    For i As Integer = 0 To arrID_lop_tc.Length - 1 Step 2
                        Dim dt_thongtinLopTC As DataTable = clsLopTC.ThongTnLopTInChi_Select(arrID_lop_tc.GetValue(i))
                        If dt_thongtinLopTC.Rows.Count > 0 Then
                            Giang_duong = dt_thongtinLopTC.Rows(0).Item("So_phong").ToString
                            Tu_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Tu_ngay").ToString, Date), "dd/MM/yyyy")
                            Den_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Den_ngay").ToString, Date), "dd/MM/yyyy")
                        End If

                        'Load dữ liệu về tổ chức thi của từng lớp
                        Dim dtDiemTH As DataTable = New DataTable
                        'clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, arrID_lop_tc.GetValue(i))
                        clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, arrID_lop_tc.GetValue(i), gobjUser.UserName, gobjUser.ID_phong)
                        mdtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien
                        'Lấy danh sách các ID_lop_tc
                        dsID_lop = "0"
                        For j As Integer = 0 To mdtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + mdtDanhSachSinhVien.Rows(j)("ID_lop").ToString + ",") Then
                                dsID_lop += "," + mdtDanhSachSinhVien.Rows(j)("ID_lop").ToString
                            End If
                        Next
                        If mdtDanhSachSinhVien.Rows.Count > 0 And mID_mon > 0 Then
                            clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                            dtDiemTH = clsDiem.DanhSachDiemThanhPhan(mID_mon, mHoc_ky, mNam_hoc)
                        End If
                        Dim dtTP As DataTable
                        Tieu_de1 = "DANH SÁCH LỚP:  " & arrID_lop_tc.GetValue(i + 1)
                        Tieu_de2 = "HỌC PHẦN:  " & trvLopTinChi.Ten_mon.ToUpper
                        Tieu_de3 = "Giảng đường: " & Giang_duong & ", Thời gian học Từ ngày: " & Tu_ngay & " đến ngày: " & Den_ngay
                        dtTP = clsDiem.DanhSachThanhPhanChon

                        TaoBaoCaoBangDiemThanhPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, Tieu_de3, dtTP)

                        C1Report1.DataSource.Recordset = dtDiemTH
                        frmESS_.ShowDialog_Print(C1Report1)
                    Next
                End If
            Else
                Thongbao("Bạn phải chọn học phần trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub grdViewDiem_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdViewDiem.DataError
        Try

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
                                    clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, ID_thanh_phan, mHoc_ky, mNam_hoc)
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            grdViewDiem.EndEdit()
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
                    objDiem.Hoc_ky = mHoc_ky
                    objDiem.Nam_hoc = mNam_hoc
                    objDiem.ID_mon = mID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")
                    ID_diem = clsDiem.CheckExist_svDiem(objDiem.ID_dv, objDiem.ID_sv, objDiem.ID_mon, objDiem.ID_dt)
                    If ID_diem > 0 Then
                        dtDiem.Rows(i)("ID_diem") = ID_diem
                    Else
                        ID_diem = clsDiem.ThemMoi_ESSDiem(objDiem)
                        dtDiem.Rows(i)("ID_diem") = ID_diem
                    End If
                Else
                    objDiem.Hoc_ky = IIf(IsDBNull(dtDiem.Rows(i)("Hoc_ky")), mHoc_ky, dtDiem.Rows(i)("Hoc_ky")) ' mHoc_ky
                    objDiem.Nam_hoc = IIf(IsDBNull(dtDiem.Rows(i)("Nam_hoc")), mNam_hoc, dtDiem.Rows(i)("Nam_hoc")) ' mNam_hoc
                    objDiem.ID_mon = mID_mon
                    objDiem.ID_dt = dtDiem.Rows(i)("ID_dt")
                    objDiem.ID_dv = gobjUser.ID_dv
                    objDiem.ID_sv = dtDiem.Rows(i)("ID_sv")

                    clsDiem.CapNhat_ESSDiem(objDiem, ID_diem)
                End If
                Noi_dung_Add += vbCrLf & " -ID_sv:" & dtDiem.Rows(i)("ID_sv") & " -Ma_SV:" & dtDiem.Rows(i)("Ma_sv").ToString

                'Cap nhat diem danh
                objDiemDanh.Hoc_ky_DD = mHoc_ky
                objDiemDanh.Nam_hoc_DD = mNam_hoc
                objDiemDanh.So_tiet_nghi_co_phep = IIf(dtDiem.Rows(i)("So_tiet_nghi_co_phep").ToString = "", 0, dtDiem.Rows(i)("So_tiet_nghi_co_phep"))
                objDiemDanh.So_tiet_nghi_khong_phep = IIf(dtDiem.Rows(i)("So_tiet_nghi_khong_phep").ToString = "", 0, dtDiem.Rows(i)("So_tiet_nghi_khong_phep"))
                objDiemDanh.Thieu_bai_thuc_hanh = IIf(dtDiem.Rows(i)("Thieu_bai_thuc_hanh").ToString = "", 0, dtDiem.Rows(i)("Thieu_bai_thuc_hanh"))
                objDiemDanh.Ghi_chu = dtDiem.Rows(i)("Ghi_chu").ToString
                clsDiem.Xoa_DiemDanh(ID_diem, mHoc_ky, mNam_hoc)
                If clsDiem.KiemTraTonTai_DiemDanh(ID_diem, mHoc_ky, mNam_hoc) > 0 Then
                    clsDiem.CapNhat_DiemDanh(objDiemDanh, ID_diem, mHoc_ky, mNam_hoc)
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
                                objDiemTP.Hoc_ky_TP = mHoc_ky
                                objDiemTP.Nam_hoc_TP = mNam_hoc
                                objDiemTP.Diem = dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu)
                                'Hash code dữ liệu điểm để chống sửa dữ liệu từ Database
                                objDiemTP.Hash_code = (ID_diem.ToString + "-" + objDiemTP.ID_thanh_phan.ToString + "-" + objDiemTP.Diem.ToString).ToString.GetHashCode
                                objDiemTP.Locked = dtDiem.Rows(i)("Locked")

                                'Update
                                If clsDiem.CheckExist_svDiemThanhPhan(ID_diem, .ID_thanh_phan, mHoc_ky, mNam_hoc) > 0 Then
                                    If dtDiem.Rows(i)("Locked") = 0 Then
                                        clsDiem.CapNhat_ESSDiemThanhPhan(objDiemTP, ID_diem, .ID_thanh_phan)
                                    End If
                                Else    'Insert
                                    clsDiem.ThemMoi_ESSDiemThanhPhan(ID_diem, objDiemTP)
                                End If
                                NoiDung += " TP: " & .Ky_hieu & "-Điểm: " & dtDiem.Rows(i)(clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).Ky_hieu)
                            Else
                                'Xoá điểm thành phần
                                clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, .ID_thanh_phan, mHoc_ky, mNam_hoc)
                            End If
                        End With
                    Else
                        'Xoá điểm thành phần không chọn
                        clsDiem.Xoa_ESSDiemThanhPhan(ID_diem, clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(j).ID_thanh_phan, mHoc_ky, mNam_hoc)
                    End If
                    If NoiDung.Trim <> "" Then Noi_dung_Add += NoiDung
                Next
            Next

            'Save Log 
            If Noi_dung_Add.Trim <> "" Then
                Noi_dung_Add = "Cập nhật điểm thành phần Học phần: " & mTen_mon & " -Học kỳ " & mHoc_ky & " -Năm học " & mNam_hoc & Noi_dung_Add
                SaveLog(LoaiSuKien.Them, Noi_dung_Add)
            End If
            trvLop_Select()
            Thongbao("Đã lưu điểm thành công")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDiem.DataSource Is Nothing Then
                Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
                Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

                Tieu_de1 = "ĐIỂM KIỂM TRA MÔN HỌC, MÔ ĐUN"
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
                dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
                dtDiemTH.Columns.Add("Danh_gia", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
                dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
                dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_DuDKT", GetType(String))
                dtDiemTH.Columns.Add("Tong_SV_KhongDuDKT", GetType(String))


                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i)("Khoa_hoc") = trvLopTinChi.Khoa_hoc.ToString
                    dtDiemTH.Rows(i)("Ten_mon") = trvLopTinChi.Ten_mon.Split("|").GetValue(0)
                    dtDiemTH.Rows(i)("Ky_hieu") = trvLopTinChi.Ten_mon.Split("|").GetValue(1)
                    dtDiemTH.Rows(i)("So_hoc_trinh") = trvLopTinChi.Ten_mon.Split("|").GetValue(2)
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
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
        '        Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

        '        Dim dt_thongtinLopTC As DataTable = clsLopTC.ThongTnLopTInChi_Select(trvLopTinChi.ID_lop_tc)
        '        Dim Giang_duong, Tu_ngay, Den_ngay As String

        '        If dt_thongtinLopTC.Rows.Count > 0 Then
        '            Giang_duong = dt_thongtinLopTC.Rows(0).Item("So_phong").ToString
        '            Tu_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Tu_ngay").ToString, Date), "dd/MM/yyyy")
        '            Den_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Den_ngay").ToString, Date), "dd/MM/yyyy")
        '        End If

        '        Tieu_de1 = "BẢNG ĐIỂM QUÁ TRÌNH"
        '        Tieu_de2 = ""
        '        Tieu_de3 = ""
        '        Tieu_de4 = ""
        '        Tieu_de5 = ""
        '        Tieu_de6 = ""
        '        Tieu_de7 = ""

        '        Dim dtDiemTH As DataTable
        '        Dim dt As DataTable = grdViewDiem.DataSource.Table
        '        dtDiemTH = dt.Copy
        '        dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
        '        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
        '        dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
        '        dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV_DuDKT", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV_KhongDuDKT", GetType(String))

        '        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
        '            dtDiemTH.Rows(i)("Ten_lop") = trvLopTinChi.Ten_lop_tc
        '            dtDiemTH.Rows(i)("Khoa_hoc") = trvLopTinChi.Khoa_hoc.ToString
        '            dtDiemTH.Rows(i)("Ten_mon") = trvLopTinChi.Ten_mon.Split("|").GetValue(0)
        '            dtDiemTH.Rows(i)("Ky_hieu") = trvLopTinChi.Ten_mon.Split("|").GetValue(1)
        '            dtDiemTH.Rows(i)("So_hoc_trinh") = trvLopTinChi.Ten_mon.Split("|").GetValue(2)
        '            dtDiemTH.Rows(i)("Tong_tiet") = ""
        '            dtDiemTH.Rows(i)("Tong_SV_DuDKT") = "Đủ điều kiện thi HP: "
        '            dtDiemTH.Rows(i)("Tong_SV_KhongDuDKT") = "Không đủ điều kiện thi HP:"
        '            dtDiemTH.Rows(i)("Tong_SV") = "Tổng số sinh viên: " & dtDiemTH.Rows.Count.ToString
        '        Next
        '        Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptMARK_BangDiemKiemTraHocPhan_Lop_TinChi", dtDiemTH.DefaultView, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
        '        frmESS_.ShowDialog(clsDiem)

        '    Else
        '        Thongbao("Bạn phải chọn học phần trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default

        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2, Tieu_de3 As String
        '        Dim Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7 As String

        '        Dim dt_thongtinLopTC As DataTable = clsLopTC.ThongTnLopTInChi_Select(trvLopTinChi.ID_lop_tc)
        '        Dim Giang_duong, Tu_ngay, Den_ngay As String

        '        If dt_thongtinLopTC.Rows.Count > 0 Then
        '            Giang_duong = dt_thongtinLopTC.Rows(0).Item("So_phong").ToString
        '            Tu_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Tu_ngay").ToString, Date), "dd/MM/yyyy")
        '            Den_ngay = Format(CType(dt_thongtinLopTC.Rows(0).Item("Den_ngay").ToString, Date), "dd/MM/yyyy")
        '        End If

        '        Tieu_de1 = "ĐIỂM KIỂM TRA HỌC PHẦN"
        '        Tieu_de2 = ""
        '        Tieu_de3 = ""
        '        Tieu_de4 = ""
        '        Tieu_de5 = ""
        '        Tieu_de6 = ""
        '        Tieu_de7 = ""

        '        Dim dtDiemTH As DataTable
        '        Dim dt As DataTable = grdViewDiem.DataSource.Table
        '        dtDiemTH = dt.Copy
        '        dtDiemTH.Columns.Add("Khoa_hoc", GetType(String))
        '        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
        '        dtDiemTH.Columns.Add("Ky_hieu", GetType(String))
        '        dtDiemTH.Columns.Add("So_hoc_trinh", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_tiet", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV_DuDKT", GetType(String))
        '        dtDiemTH.Columns.Add("Tong_SV_KhongDuDKT", GetType(String))

        '        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
        '            dtDiemTH.Rows(i)("Ten_lop") = trvLopTinChi.Ten_lop_tc
        '            dtDiemTH.Rows(i)("Khoa_hoc") = trvLopTinChi.Khoa_hoc.ToString
        '            dtDiemTH.Rows(i)("Ten_mon") = trvLopTinChi.Ten_mon.Split("|").GetValue(0)
        '            dtDiemTH.Rows(i)("Ky_hieu") = trvLopTinChi.Ten_mon.Split("|").GetValue(1)
        '            dtDiemTH.Rows(i)("So_hoc_trinh") = trvLopTinChi.Ten_mon.Split("|").GetValue(2)
        '            dtDiemTH.Rows(i)("Tong_tiet") = ""
        '            dtDiemTH.Rows(i)("Tong_SV_DuDKT") = "Đủ điều kiện thi HP: "
        '            dtDiemTH.Rows(i)("Tong_SV_KhongDuDKT") = "Không đủ điều kiện thi HP:"
        '            dtDiemTH.Rows(i)("Tong_SV") = "Tổng số sinh viên: " & dtDiemTH.Rows.Count.ToString
        '        Next
        '        Dim dtTP As DataTable = clsDiem.DanhSachThanhPhan
        '        Dim frm As New rptMARK_BangDiemKiemTraHocPhan_Lop_TinChi_Dynamic(dtDiemTH, dtTP)
        '        frm.DataSource = dtDiemTH
        '        PrintXtraReport(frm)


        '    Else
        '        Thongbao("Bạn phải chọn học phần trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
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
                Me.grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(mID_mon, mHoc_ky, mNam_hoc).DefaultView
                FormatDataView()
                Dim Lock_diem As Boolean = False
                KhoaDuLieu(Lock_diem)
                If Lock_diem = True Then
                    cmdDelete.Enabled = False
                    cmdSave.Enabled = False
                    cmdDiemThanhPhan.Enabled = False
                Else
                    cmdDelete.Enabled = True
                    cmdSave.Enabled = True
                    cmdDiemThanhPhan.Enabled = True
                End If
            End If
        Else
            Thongbao("Bạn phải chọn học phần để xác định các thành phần cho học phần")
        End If
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

    Private Sub cmdLock_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
        Dim dv As DataView = grdViewDiem.DataSource
        Dim clsDiem As New Diem_Bussines()
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("ID_diem").ToString <> "" Then clsDiem.CapNhat_ESSDiemThanhPhanLock_TP(dv.Item(i)("ID_diem"), mHoc_ky, mNam_hoc, 1)
        Next
        trvLop_Select()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT * FROM STU_DANHSACH1")
            For i As Integer = 0 To dt.Rows.Count - 1
                Connect.Execute("UPDATE STU_DANHSACH SET ID_lop=" & dt.Rows(i)("ID_lop") & " WHERE ID_SV=" & dt.Rows(i)("ID_sv"))
            Next
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnCap_nhap_ghi_chu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCap_nhap_ghi_chu.Click
        Try
            Dim dv As DataView
            dv = grdViewDiem.DataSource
            dv.RowFilter = "Ghi_chu <> ''"
            For i As Integer = 0 To dv.Count - 1
                Dim para(4) As SqlClient.SqlParameter
                para(0) = New SqlClient.SqlParameter("@ID_sv", dv.Item(i).Item("ID_SV"))
                para(1) = New SqlClient.SqlParameter("@ID_mon", mID_mon)
                para(2) = New SqlClient.SqlParameter("@Hoc_ky", mHoc_ky)
                para(3) = New SqlClient.SqlParameter("@Nam_hoc", mNam_hoc)
                para(4) = New SqlClient.SqlParameter("@Ly_do", dv.Item(i).Item("Ghi_chu"))
                ESSConnect.Connect.ExecuteSP("STU_DanhSachKhongThi_TC_ThemMoi_09", para)
            Next
            trvLop_Select()
            Thongbao("Cập nhập thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class