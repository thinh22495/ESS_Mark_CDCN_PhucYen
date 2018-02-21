Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XetLenLop_NganhThu2
    Private clsDSXetLenLop As DanhSachXetLenLop_Bussines

#Region "Form Events"
    Private Sub frmESS_XetLenLop_NganhThu2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewDanhSachSinhVien)
        FormatDataViewCa2NganhHoc()
        Add_Namhoc(cmbNam_hoc)
        Dim cls As New DanhMuc_Bussines
        Dim dt_dm As DataTable = cls.LoadDanhMuc("SELECT ID_nganh,Ten_nganh from  STU_Nganh")
        FillCombo(cmbID_nganh, dt_dm)
        SetQuyenTruyCap(, cmdTongHop, cmdNhapQuyetDinh, )
    End Sub

    Private Sub frmESS_XetLenLop_NganhThu2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"

#End Region

    Private Sub cmdTongHop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop.Click
        Try
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                FormatDataViewNganh2NgungHoc()
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, cmbID_nganh.SelectedValue)
                grdViewDanhSachSinhVien.DataSource = clsDSXetLenLop.XetLenLop_nganh2(gobjUser.ID_dv, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbID_nganh.SelectedValue).DefaultView
                labSo_sv.Text = grdViewDanhSachSinhVien.DataSource.Count
                Thongbao("Danh sách sinh viên đang học ngành thứ 2 thuộc diện ngừng học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewDanhSachSinhVien.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDataGridViewToExcel(grdViewDanhSachSinhVien)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdNhapQuyetDinh_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNhapQuyetDinh.Click
        Try
            If Thongbao("Bạn có muốn nhập ngừng học cho sinh viên này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
                Dim clsCTDT2 As New DanhSachNganh2_Bussines(gobjUser.ID_dv, 0, 0)
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        clsCTDT2.CapNhat_ESSsvSinhVienNganh2_NgungHoc(dv.Item(i)("ID_sv"), dv.Item(i)("ID_dt2"), True)
                    End If
                Next
                cmdTongHop_Click(sender, e)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdTonghopAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTonghopAll.Click
        Try
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                'SetUpDataGridView(grdViewDanhSachSinhVien)
                grdViewDanhSachSinhVien.DataSource = Nothing
                FormatDataViewCa2NganhHoc()
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text.Trim, cmbID_nganh.SelectedValue)
                grdViewDanhSachSinhVien.DataSource = clsDSXetLenLop.XetLenLop_Load2nganh(gobjUser.ID_dv, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbID_nganh.SelectedValue).DefaultView
                labSo_sv.Text = grdViewDanhSachSinhVien.DataSource.Count
                Thongbao("Danh sách sinh viên đang học ngành thứ 2 !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub FormatDataViewNganh2NgungHoc()
        Try
            grdViewDanhSachSinhVien.Columns.Clear()
            grdViewDanhSachSinhVien.AllowUserToOrderColumns = False

            Dim col0 As New DataGridViewCheckBoxColumn
            With col0
                .Name = "Chon"
                .DataPropertyName = "Chon"
                .HeaderText = "Chọn"
                .Width = 50
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = False
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col0)

            Dim col1 As New DataGridViewTextBoxColumn
            With col1
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sinh viên"
                .Width = 130
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col1)

            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 250
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col2)

            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ngay_sinh"
                .DataPropertyName = "Ngay_sinh"
                .HeaderText = "Ngày sinh"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col3)

            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ten_lop"
                .DataPropertyName = "Ten_lop"
                .HeaderText = "Tên lớp"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col4)

            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "Ly_do"
                .DataPropertyName = "Ly_do"
                .HeaderText = "Lý do"
                .Width = 300
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col5)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub FormatDataViewCa2NganhHoc()
        Try
            grdViewDanhSachSinhVien.Columns.Clear()
            grdViewDanhSachSinhVien.AllowUserToOrderColumns = False

            Dim col0 As New DataGridViewCheckBoxColumn
            With col0
                .Name = "Ngung_hoc"
                .DataPropertyName = "Ngung_hoc"
                .HeaderText = "Ngừng học"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = False
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col0)

            Dim col1 As New DataGridViewTextBoxColumn
            With col1
                .Name = "Ma_sv"
                .DataPropertyName = "Ma_sv"
                .HeaderText = "Mã sinh viên"
                .Width = 120
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col1)

            Dim col2 As New DataGridViewTextBoxColumn
            With col2
                .Name = "Ho_ten"
                .DataPropertyName = "Ho_ten"
                .HeaderText = "Họ và tên"
                .Width = 180
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col2)

            Dim col3 As New DataGridViewTextBoxColumn
            With col3
                .Name = "Ngay_sinh"
                .DataPropertyName = "Ngay_sinh"
                .HeaderText = "Ngày sinh"
                .Width = 95
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col3)

            Dim col4 As New DataGridViewTextBoxColumn
            With col4
                .Name = "Ten_lop"
                .DataPropertyName = "Ten_lop"
                .HeaderText = "Tên lớp"
                .Width = 85
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col4)

            Dim col5 As New DataGridViewTextBoxColumn
            With col5
                .Name = "TBCHT1"
                .DataPropertyName = "TBCHT1"
                .HeaderText = "TBCHT1"
                .Width = 70
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = 0
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col5)
            Dim col6 As New DataGridViewTextBoxColumn
            With col6
                .Name = "Xep_loai1"
                .DataPropertyName = "Xep_loai1"
                .HeaderText = "Xếp loại1"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col6)

            Dim col7 As New DataGridViewTextBoxColumn
            With col7
                .Name = "TBCHT2"
                .DataPropertyName = "TBCHT2"
                .HeaderText = "TBCHT2"
                .Width = 70
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = 0
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col7)

            Dim col8 As New DataGridViewTextBoxColumn
            With col8
                .Name = "Xep_loai2"
                .DataPropertyName = "Xep_loai2"
                .HeaderText = "Xếp loại2"
                .Width = 100
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col8)

            Dim col9 As New DataGridViewTextBoxColumn
            With col9
                .Name = "So_ky"
                .DataPropertyName = "So_ky"
                .HeaderText = "SốKỳ TL/Kỳ tốiđa"
                .Width = 150
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .DefaultCellStyle.NullValue = ""
                .ReadOnly = True
            End With
            Me.grdViewDanhSachSinhVien.Columns.Add(col9)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint2Nganh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint2Nganh.Click
        Try
            Dim dv As DataView = grdViewDanhSachSinhVien.DataSource
            If dv.Count > 0 Then
                dv.Table.Columns.Add("Tieu_de_ten_bo")
                dv.Table.Columns.Add("Tieu_de_Ten_truong")
                dv.Table.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

                Dim Tieu_de As String = "HỌC KỲ: " & cmbHoc_ky.Text & " NĂM HỌC: " & cmbNam_hoc.Text
                If cmbID_nganh.Text.Trim <> "" Then Tieu_de += " - NGÀNH HỌC THỨ 2: " & cmbID_nganh.Text.ToUpper

                dv.Table.Rows(0).Item("Tieu_de") = Tieu_de

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("KQHT2NganhHoc", dv.Table)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class