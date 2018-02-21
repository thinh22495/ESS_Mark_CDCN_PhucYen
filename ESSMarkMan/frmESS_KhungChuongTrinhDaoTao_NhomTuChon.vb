Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_NhomTuChon
    Private mID_dt As Integer
    Private flg As Boolean = False
    Private mcls As ChuongTrinhDaoTaoNhomTuChon_Bussines


    Public Overloads Sub ShowDialog(ByVal ID_dt As Integer)
        mID_dt = ID_dt
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoMonChon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        mcls = New ChuongTrinhDaoTaoNhomTuChon_Bussines(mID_dt)
        grcHocPhan.DataSource = mcls.DanhSachNotMonTuChon(0)
        grcHocPhanChon.DataSource = mcls.DanhSachMonTuChon(0)

        Dim clsDM As New DanhMuc_Bussines
        Dim dt As New DataTable
        dt = clsDM.DanhMucSoSanh_Load("PLAN_ChuongTrinhDaoTaoChiTiet", "Nhom_tu_chon", "Nhom_tu_chon", "Nhom_tu_chon", 1)
        FillCombo(cmbNhom_tu_chon, dt)
        flg = True
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(, cmdAdd, , cmdRemove)
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoMonChon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub



    Private Sub cmbNhom_tu_chon_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNhom_tu_chon.SelectedIndexChanged
        Try
            If flg Then
                Dim dt1, dt2 As DataTable
                dt1 = mcls.DanhSachNotMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhan.DataSource = dt1.DefaultView
                dt2 = mcls.DanhSachMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhanChon.DataSource = dt2.DefaultView
                txtSo_mon_tu_chon.Text = IIf(dt1.DefaultView.Count >= dt2.DefaultView.Count, dt1.DefaultView.Count, dt2.DefaultView.Count)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Function CheckData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        If cmbNhom_tu_chon.Text.Trim = "" Then
            Call SetErrPro(cmbNhom_tu_chon, ErrorProvider1, "Bạn hãy chọn nhóm tự chọn !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNhom_tu_chon
        End If
        If txtSo_mon_dang_ky.Text.Trim = "" Then
            Call SetErrPro(txtSo_mon_dang_ky, ErrorProvider1, "Bạn hãy nhập chọn mấy Học phần trong tổng số Học phần này !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_mon_dang_ky
        ElseIf Not IsNumeric(txtSo_mon_dang_ky.Text.Trim) Then
            Call SetErrPro(txtSo_mon_dang_ky, ErrorProvider1, "Bạn hãy nhận số Học phần chọn dạng số nguyên !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_mon_dang_ky
        ElseIf CType(txtSo_mon_dang_ky.Text.Trim, Integer) > CType(txtSo_mon_tu_chon.Text.Trim, Integer) Then
            Call SetErrPro(txtSo_mon_dang_ky, ErrorProvider1, "Bạn hãy nhận số Học phần chọn phải <= tổng số Học phần !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_mon_dang_ky
        End If


        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckData = False
        CtrlErr.Focus()
    End Function

    Private Sub txtSo_mon_dang_ky_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSo_mon_dang_ky.KeyPress, txtSo_mon_tu_chon.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar)
    End Sub

    Private Sub mnuPrint_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub BarButtonItem2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Me.Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If CheckData() Then
                Dim obj As New ESSChuongTrinhDaoTaoNhomTuChon
                obj.ID_dt = mID_dt
                obj.Nhom_tu_chon = cmbNhom_tu_chon.SelectedValue
                obj.So_mon_tu_chon = txtSo_mon_tu_chon.Text
                obj.So_mon_dang_ky = txtSo_mon_dang_ky.Text

                mcls.Xoa_ESSNhomTuChon(mID_dt, cmbNhom_tu_chon.SelectedValue)
                mcls.ThemMoi_ESSNhomTuChon(obj)

                mcls = New ChuongTrinhDaoTaoNhomTuChon_Bussines(mID_dt)
                Dim dt1, dt2 As DataTable
                dt1 = mcls.DanhSachNotMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhan.DataSource = dt1.DefaultView
                dt2 = mcls.DanhSachMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhanChon.DataSource = dt2.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            If cmbNhom_tu_chon.Text.Trim = "" Then
                Thongbao("Hãy chọn nhóm Học phần chọn cần xoá !", MsgBoxStyle.Information)
            Else
                Dim obj As New ESSChuongTrinhDaoTaoNhomTuChon
                obj.ID_dt = mID_dt
                obj.Nhom_tu_chon = cmbNhom_tu_chon.SelectedValue

                mcls.Xoa_ESSNhomTuChon(mID_dt, cmbNhom_tu_chon.SelectedValue)

                mcls = New ChuongTrinhDaoTaoNhomTuChon_Bussines(mID_dt)
                Dim dt1, dt2 As DataTable
                dt1 = mcls.DanhSachNotMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhan.DataSource = dt1.DefaultView
                dt2 = mcls.DanhSachMonTuChon(cmbNhom_tu_chon.SelectedValue)
                grcHocPhanChon.DataSource = dt2.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class