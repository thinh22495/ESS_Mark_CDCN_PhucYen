Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ThongTinTaiChinhSinhVien
    Private Loader As Boolean = False
    Private mID_sv As Integer = 0
    Private mclsBL As BienLaiThu_Bussines
    Private Ngoai_ngan_sach As Boolean = False
    Private clsKyDangKy As New HocKyDangKy_Bussines
#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
            'Load combobox loại thu chi
            dt = clsDM.DanhMuc_Load("ACC_LoaiThuChi", "ID_thu_chi", "Ten_thu_chi")
            FillCombo(cmbID_thu_chi, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadThongTinTaiChinhSinhVien(ByVal ID_sv As Integer)
        grdThuChi.Enabled = False
        Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
        Dim objSV As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
        labHo_ten.Text = objSV.Ho_ten
        If txtMa_sv.Text = "" Then txtMa_sv.Text = objSV.Ma_sv
        labTen_lop.Text = objSV.Ten_lop & " (" & objSV.Ten_he & " - K" & objSV.Khoa_hoc & ")"
        mclsBL = New BienLaiThu_Bussines
        'Load bien lai
        grdViewBienLai.DataSource = mclsBL.LoadBienLaiTheoID_SV(ID_sv).DefaultView
        'Kiểm tra xem đã tồn tại Đợt thu, Lần thu này chưa
        Dim dtTongHop As DataTable = mclsBL.TongHop_HocPhi(ID_sv, Ngoai_ngan_sach, objSV.ID_he)
        Me.grdThuChi.DataSource = dtTongHop.DefaultView
        HienThiTongHocPhi(dtTongHop)
    End Sub
    Private Sub HienThiTongHocPhi(ByVal dtTongHop As DataTable)
        Dim Tong_so_tien_nop, Tong_so_tien_da_nop, Tong_so_tien_thua_thieu As Integer
        Tong_so_tien_nop = 0
        Tong_so_tien_da_nop = 0
        Tong_so_tien_thua_thieu = 0
        For i As Integer = 0 To dtTongHop.Rows.Count - 1
            If dtTongHop.Rows(i)("So_tien_nop").ToString <> "" Then Tong_so_tien_nop += dtTongHop.Rows(i)("So_tien_nop")
            If dtTongHop.Rows(i)("So_tien_da_nop").ToString <> "" Then Tong_so_tien_da_nop += dtTongHop.Rows(i)("So_tien_da_nop")
            If dtTongHop.Rows(i)("Thieu_thua").ToString <> "" Then Tong_so_tien_thua_thieu += dtTongHop.Rows(i)("Thieu_thua")
        Next
        lblTong_phai_nop.Text = Format(Tong_so_tien_nop, "###,###0") + "đ"
        lblTong_da_nop.Text = Format(Tong_so_tien_da_nop, "###,###0") + "đ"
        lblTong_thua_thieu.Text = Format(Tong_so_tien_thua_thieu, "###,###0")
    End Sub
#End Region

#Region "Forms"
    Private Sub frmESS_BienLaiThu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdThuChi)
        SetUpDataGridView(grdViewBienLai)
        LoadComboBox()
        Loader = True
    End Sub
    Private Sub frmESS_BienLaiThu_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_BienLaiThu_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
        If e.KeyCode = Keys.Enter Then Call txtMa_sv_Leave(sender, e)
    End Sub
#End Region
#Region "Control"
    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        Dim ID_sv As Integer = 0
        If txtMa_sv.Text.Trim <> "" Then
            mclsBL = New BienLaiThu_Bussines
            ID_sv = mclsBL.getID_sv(txtMa_sv.Text)
            If ID_sv > 0 Then
                mID_sv = ID_sv
                LoadThongTinTaiChinhSinhVien(ID_sv)
            Else
                mID_sv = 0
                txtMa_sv.Focus()
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        Else
            Me.btnLoc_sv.Focus()
        End If
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbLan_thu.SelectedIndexChanged
        If Loader And mID_sv > 0 Then
            LoadThongTinTaiChinhSinhVien(mID_sv)
        End If
    End Sub
    Private Sub btnLoc_sv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoc_sv.Click
        Dim frmESS_ As New frmESS_SearchSinhVien
        frmESS_.ShowDialog()
        If frmESS_.Tag = 1 Then
            mID_sv = frmESS_.mID_sv
            If mID_sv > 0 Then
                LoadThongTinTaiChinhSinhVien(mID_sv)
            Else
                mID_sv = 0
                Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

    Private Sub cmdXemBienLai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXemBienLai.Click
        Dim dv As DataView = grdViewBienLai.DataSource
        If Not grdViewBienLai.CurrentRow Is Nothing Then
            Dim ID_bien_lai As Integer = dv.Item(grdViewBienLai.CurrentRow.Index).Item("ID_bien_lai")
            Dim clsBL As New BienLaiThu_Bussines(ID_bien_lai)
            Dim objBL As ESSBienLaiThu = clsBL.ESSBienLaiThu(0)
            If objBL.Thu_chi = True Then
                Dim frmESS_ As New frmESS_BienLaiThuHocPhiHocPhanXem
                frmESS_.ShowDialog(objBL)
            Else
                Dim frmESS_ As New frmESS_BienLaiChiHocPhiHocPhanXem
                frmESS_.ShowDialog(objBL)
            End If

        End If
    End Sub
End Class