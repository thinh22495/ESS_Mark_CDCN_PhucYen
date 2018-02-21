Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_ToChucThi_DongTuiThi
    Private mID_thi As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private mLan_thi As Integer = 0
    Private mDot_thi As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mTen_mon As String = ""
    Private mID_khoa As Integer = 0
    Private mTen_khoa As String = ""
    Private mNgay_thi As String = ""
    Private mTen_phong As String = ""
    Private Loader As Boolean = False
    Private clsTCThi As New TochucThi_Bussines
    Private mdtDanhSachSinhVien As New DataTable
    Private SoSV_LanChia_TuiThi As Integer = 10

#Region "Form Events"
    Private Sub frmESS_DongTuiThi_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then
            cmbTui_thi.SelectedIndex = -1
            cmbTui_thi.SelectedIndex = -1
        End If
    End Sub
    Private Sub frmESS_DongTuiThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetUpDataGridView(grdViewDanhSach)
            Loader = True
            SetQuyenTruyCap(, cmdDongTui, , cmdXoa_tui)
            Doc_thamso_hethong()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_DongTuiThi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Try
            If Loader Then
                mID_phong_thi = trvPhongThi.ID_phong_thi
                mID_thi = trvPhongThi.ID_thi
                mLan_thi = trvPhongThi.Lan_thi
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mTen_mon = trvPhongThi.Ten_mon
                mTen_phong = trvPhongThi.Phong_thi
                mTen_khoa = trvPhongThi.Ten_khoa
                mID_khoa = trvPhongThi.ID_khoa
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachSinhVienDongTuiThi(mID_thi)
                dt.DefaultView.Sort = "Tui_so"
                grdViewDanhSach.DataSource = dt.DefaultView
                txtSo_sv.Text = dt.DefaultView.Count
                Dim dt_tuithi As DataTable = clsTCThi.DanhSachTuiThi(mID_thi)
                FillCombo(cmbTui_thi, dt_tuithi)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Doc_thamso_hethong()
        Try
            Dim cls As New ThamSoHeThong_Bussines
            SoSV_LanChia_TuiThi = cls.Doc_tham_so("SoSV_LanChia_TuiThi")
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbDongTui_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDongTui.Click
        Try
            If txtSo_sinhvien_Max.Text.Trim = "" Or txtSophach_tu.Text.Trim = "" Then
                Thongbao("Hãy nhập số sinh viên tối đa cho túi thi và số phách là số nguyên được bắt đầu !", MsgBoxStyle.Information)
                Exit Sub
            ElseIf Not IsNumeric(txtSophach_tu.Text.Trim) Or Not IsNumeric(txtSo_sinhvien_Max.Text.Trim) Then
                Thongbao("Hãy nhập số sinh viên tối đa cho túi thi và số phách là số nguyên được bắt đầu !", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim dt_dsthi As DataTable = clsTCThi.DanhSachSinhVienDongTuiThi(mID_thi)
            Dim dt_phong As DataTable = clsTCThi.DanhSachPhongThi(mID_thi)
            clsTCThi.DongTuiThi(dt_phong, dt_dsthi, mID_thi, CType(txtSo_sinhvien_Max.Text.Trim, Integer), SoSV_LanChia_TuiThi, txtSophach_tu.Text.Trim)
            clsTCThi = New TochucThi_Bussines(mID_thi)
            Dim dt As DataTable = clsTCThi.DanhSachSinhVienDongTuiThi(mID_thi)
            dt.DefaultView.Sort = "Tui_so"
            grdViewDanhSach.DataSource = dt.DefaultView
            Thongbao("Đã lập xong số phách ")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbTui_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTui_thi.SelectedIndexChanged
        Try
            If grdViewDanhSach.DataSource Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDanhSach.DataSource
            dv.RowFilter = "1=1"
            If cmbTui_thi.Text.Trim <> "" Then
                dv.RowFilter = "Tui_so=" & cmbTui_thi.Text.Trim
            End If
            grdViewDanhSach.DataSource = dv
            txtSo_sv.Text = dv.Count
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_DoiChieu_PhachSBD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint_DoiChieu_PhachSBD.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            'mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_Tuithi(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "SoBD_Phach_Main", "Phach_SBD")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_HD_dontui_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint_HD_dontui.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            'mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_Tuithi_HuongDan(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "PhongThi_SBD_Main", "PhongThi_SBD")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_Phach_DiemSoChu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_Phach_DiemSoChu.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            mLan_thi = trvPhongThi.Lan_thi
            mID_thi = trvPhongThi.ID_thi
            'mID_phong_thi = trvPhongThi.ID_phong_thi
            If mID_thi > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                'Load dữ liệu về tổ chức thi
                clsTCThi = New TochucThi_Bussines(mID_thi)
                Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_ca", GetType(String))

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_Tuithi_HuongDan(dt, mID_thi, clsTCThi, mHoc_ky, mNam_hoc, "Phach_DiemSoChu_Main", "Phach_DiemSoChu")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class