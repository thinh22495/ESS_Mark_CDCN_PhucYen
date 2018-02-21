Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_LoaiThuChi
    Private mEdit As Boolean = False
    Private mID_thu_chi As Integer = 0
    Private Loader As Boolean = False
    Private mIdx As Integer = 0
#Region "Form Event"
    Private Sub frmESS_LoaiThuChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewLoaiThuChi)
        Dim dv As DataView
        Dim clsLoaiThuChi As New LoaiThuChi_Bussines()
        dv = clsLoaiThuChi.HienThi_ESSLoaiThuChi().DefaultView
        grdViewLoaiThuChi.DataSource = dv
        Enabled_Control(False)
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_LapDanhSachThuKhac_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Clear_Control()
            Visible_Button(False)
            Enabled_Control(True)
            mEdit = False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Enabled_Control(True)
            Visible_Button(False)
            mEdit = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If gobjUser.UserGroup <> -1 Then ' Nếu không phải là admin ko có quyển xóa
                Thongbao("Bạn không có quyền xóa loại thu chi này, Quản trị hệ thống mới được phép xóa !")
                Exit Sub
            End If
            If Thongbao("Bạn có muốn xóa loại thu chi này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim clsLoaiThuChi As New LoaiThuChi_Bussines()
            clsLoaiThuChi.Xoa_ESSLoaiThuChi(mID_thu_chi)
            clsLoaiThuChi.Xoa_ESSObject(mIdx)
            Dim dt As DataTable
            dt = clsLoaiThuChi.HienThi_ESSLoaiThuChi()
            grdViewLoaiThuChi.DataSource = dt.DefaultView
            Thongbao("Bạn đã xóa thành công loại thu chi.")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim clsLoaiThuChi As New LoaiThuChi_Bussines
            Dim obj As New ESSLoaiThuChi
            obj.ID_thu_chi = mID_thu_chi
            obj.Ten_thu_chi = txtTen_thu_chi.Text.Trim
            obj.So_tien = txtSo_tien.Text.Trim
            obj.Hoc_phi = chkHoc_phi.Checked
            obj.Theo_nien_khoa = chkThuTheo_NienKhoa.Checked
            obj.Thu_bat_buoc = chkThu_Batbuoc.Checked
            obj.Thu_chi = optThu.Checked
            If mEdit Then ' Nếu update
                clsLoaiThuChi.CapNhat_ESSLoaiThuChi(obj)
                clsLoaiThuChi.CapNhat_ESSObject(obj, mIdx)
            Else ' Nếu thêm mới
                If Not clsLoaiThuChi.CheckExist_LoaiThuChi(obj.Ten_thu_chi) Then
                    Dim ID_thu_chi As Integer = 0
                    ID_thu_chi = clsLoaiThuChi.ThemMoi_ESSLoaiThuChi(obj)
                    obj.ID_thu_chi = ID_thu_chi
                    clsLoaiThuChi.ThemMoi_ESSObject(obj)
                End If
            End If
            Dim dt As DataTable
            dt = clsLoaiThuChi.HienThi_ESSLoaiThuChi()
            grdViewLoaiThuChi.DataSource = dt.DefaultView
            Visible_Button(True)
            Enabled_Control(False)
            Thongbao("Bạn đã cập nhật thành công loại thu chi !")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Visible_Button(True)
            Enabled_Control(False)
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions And Subs"
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng miễn giảm
        If txtTen_thu_chi.Text.Trim = "" Then
            Call SetErrPro(txtTen_thu_chi, ErrorProvider1, "Bạn hãy nhập tên thu chi !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_thu_chi
        End If
        If txtSo_tien.Text.Trim = "" Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập Số tiền !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf Not IsNumeric(txtSo_tien.Text.Trim) Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập Số tiền là kiểu số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf CInt(txtSo_tien.Text.Trim) <= 0 Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập Số tiền > 0 !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub Fill_Data()
        Try
            Dim dv As New DataView
            dv = grdViewLoaiThuChi.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdViewLoaiThuChi.CurrentRow.Index
            txtTen_thu_chi.Text = dv.Item(mIdx)("Ten_thu_chi")
            txtSo_tien.Text = dv.Item(mIdx)("So_tien")
            If dv.Item(mIdx)("Thu_chi") Then
                optThu.Checked = True
                optChi.Checked = False
            Else
                optThu.Checked = False
                optChi.Checked = True
            End If
            If dv.Item(mIdx)("Thu_bat_buoc") Then
                chkThu_Batbuoc.Checked = True
            Else
                chkThu_Batbuoc.Checked = False
            End If
            If dv.Item(mIdx)("Theo_nien_khoa") Then
                chkThuTheo_NienKhoa.Checked = True
            Else
                chkThuTheo_NienKhoa.Checked = False
            End If
            If dv.Item(mIdx)("Hoc_phi") Then
                chkHoc_phi.Checked = True
            Else
                chkHoc_phi.Checked = False
            End If
            mID_thu_chi = dv.Item(mIdx)("ID_thu_chi")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtTen_thu_chi.Enabled = f
        txtSo_tien.Enabled = f
        optThu.Enabled = f
        optChi.Enabled = f
        chkHoc_phi.Enabled = f
        chkThuTheo_NienKhoa.Enabled = f
        chkThu_Batbuoc.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Visible = f
        cmdEdit.Visible = f
        cmdDelete.Visible = f
        cmdCancel.Visible = Not f
        cmdSave.Visible = Not f
    End Sub
    Private Sub Clear_Control()
        txtTen_thu_chi.Text = ""
        txtSo_tien.Text = ""
        optThu.Checked = True
        optChi.Checked = False
        chkHoc_phi.Checked = False
        chkThuTheo_NienKhoa.Checked = False
        chkThu_Batbuoc.Checked = False
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewLoaiThuChi_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewLoaiThuChi.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class
