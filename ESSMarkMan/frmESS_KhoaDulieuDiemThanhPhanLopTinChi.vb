Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_KhoaDulieuDiemThanhPhanLopTinChi
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mTen_lop_tc As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines

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
                .HeaderText = "Mã sinh viên"
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
                        col.Name = .Ky_hieu
                        col.DataPropertyName = .Ky_hieu
                        col.HeaderText = .Ky_hieu + " (" + .Ty_le.ToString + ")"
                        col.ToolTipText = .Ten_thanh_phan
                        col.DefaultCellStyle.WrapMode = DataGridViewTriState.True
                        col.Width = 50
                        col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                        col.DefaultCellStyle.NullValue = ""
                    End With
                    Me.grdViewDiem.Columns.Add(col)
                End If
            Next
            'Locked
            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Locked"
                .DataPropertyName = "Locked"
                .HeaderText = ""
                .Visible = False
            End With
            Me.grdViewDiem.Columns.Add(col4)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub KhoaDuLieu()
        Try
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
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub frmESS_KhoaDulieuDiemThanhPhanLopTinChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, cmdLock, cmdUnLock, )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_KhoaDulieuDiemThanhPhanLopTinChi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub


    Private Sub trvLop_Select() Handles trvLopTinChi.TreeNodeSelected_
        Try
            If Loader Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                mHoc_ky = trvLopTinChi.Hoc_ky
                mNam_hoc = trvLopTinChi.Nam_hoc
                mID_mon_tc = trvLopTinChi.ID_mon_tc
                mID_lop_tc = trvLopTinChi.ID_lop_tc
                mID_mon = trvLopTinChi.ID_mon
                mTen_mon = trvLopTinChi.Ten_mon
                mTen_lop_tc = trvLopTinChi.Ten_lop_tc
                If mID_mon > 0 Then
                    'Load dữ liệu về tổ chức thi
                    'clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc)
                    clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc, gobjUser.UserName, gobjUser.ID_phong)
                    mdtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien
                    'Lấy danh sách các ID_lop
                    For i As Integer = 0 To mdtDanhSachSinhVien.Rows.Count - 1
                        If Not dsID_lop.Contains("," + mdtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                            dsID_lop += mdtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                        End If
                    Next
                    If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                    If mdtDanhSachSinhVien.Rows.Count > 0 And mID_mon > 0 Then
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                        grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(mID_mon, mHoc_ky, mNam_hoc).DefaultView
                    Else
                        grdViewDiem.DataSource = Nothing
                    End If
                    FormatDataView()
                    KhoaDuLieu()
                End If
            End If
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

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdUnLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnLock.Click
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

    Private Sub cmdLock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLock.Click
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
End Class