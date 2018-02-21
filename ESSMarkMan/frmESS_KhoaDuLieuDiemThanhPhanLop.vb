Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_KhoaDuLieuDiemThanhPhanLop
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsDiem As New Diem_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private mdtDanhSachSinhVien As New DataTable

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
                        'col.Name =  .Ky_hieu
                        col.Name = .Ky_hieu
                        'col.DataPropertyName =  .Ky_hieu
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

    Private Sub frmESS_KhoaDuLieuDiemThanhPhanLop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TreeViewLop.HienThi_ESSTreeView()
            SetUpDataGridView(grdViewDiem)
            Loader = True
            SetQuyenTruyCap(, cmdLock, cmdUnLock, )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_KhoaDuLieuDiemThanhPhanLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
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
                If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                    clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                    grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Hoc_ky, Nam_hoc).DefaultView
                Else
                    grdViewDiem.DataSource = Nothing
                End If
                FormatDataView()
                Dim Lock_diem As Boolean = False
                KhoaDuLieu()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

        'Try
        '    Try
        '        If Loader Then
        '            'Load danh sách điểm của sinh viên
        '            Dim ID_dv As String = gobjUser.ID_dv
        '            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
        '            Dim Nam_hoc As String = cmbNam_hoc.Text
        '            Dim ID_mon As Integer = cmbID_mon.SelectedValue
        '            If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
        '                clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
        '                grdViewDiem.DataSource = clsDiem.DanhSachDiemThanhPhan(ID_mon, Hoc_ky, Nam_hoc).DefaultView
        '            Else
        '                grdViewDiem.DataSource = Nothing
        '            End If
        '            FormatDataView()
        '            KhoaDuLieu()
        '        End If
        '    Catch ex As Exception
        '        Thongbao(ex.Message)
        '    End Try
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub




    Private Sub grdViewDiem_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdViewDiem.DataError
        Try

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
            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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
            cmbMonHoc_SelectedIndexChanged(sender, e)
            Thongbao("Đã mở khoá điểm thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class