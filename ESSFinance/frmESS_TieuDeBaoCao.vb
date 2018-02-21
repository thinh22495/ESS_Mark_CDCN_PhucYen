Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_TieuDeBaoCao
    Private mEdit As Boolean = False
#Region "Form Event"
    Private Sub frmESS_LoaiQuyHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Enabled_Control(False)
            Dim clsDanhMuc As New DanhMuc_Bussines
            Dim dt As DataTable
            dt = clsDanhMuc.TieuDe_BaoCao(gobjUser.ID_dv, gobjUser.UserID)
            If dt.Rows.Count > 0 Then
                txtTieu_de_ten_bo.Text = dt.Rows(0)("Tieu_de_ten_bo").ToString
                txtTieu_de_ten_truong.Text = dt.Rows(0)("Tieu_de_ten_truong").ToString
                txtTieu_de_cd1.Text = dt.Rows(0)("Tieu_de_chuc_danh1").ToString
                txtTieu_de_cd2.Text = dt.Rows(0)("Tieu_de_chuc_danh2").ToString
                txtTieu_de_cd3.Text = dt.Rows(0)("Tieu_de_chuc_danh3").ToString
                txtTieu_de_cd4.Text = dt.Rows(0)("Tieu_de_chuc_danh4").ToString
                txtTen_nguoi_ky1.Text = dt.Rows(0)("Tieu_de_nguoi_ky1").ToString
                txtTen_nguoi_ky2.Text = dt.Rows(0)("Tieu_de_nguoi_ky2").ToString
                txtTen_nguoi_ky3.Text = dt.Rows(0)("Tieu_de_nguoi_ky3").ToString
                txtTen_nguoi_ky4.Text = dt.Rows(0)("Tieu_de_nguoi_ky4").ToString
                txtTieu_de_noi_ky.Text = dt.Rows(0)("Tieu_de_noi_ky").ToString
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_LoaiQuyHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim clsDanhMuc As New DanhMuc_Bussines
            If mEdit Then ' Nếu Sửa
                clsDanhMuc.UpdateTieuDe_BaoCao(gobjUser.ID_dv, gobjUser.UserID, txtTieu_de_ten_bo.Text.Trim, txtTieu_de_ten_truong.Text.Trim, txtTieu_de_cd1.Text.Trim, txtTieu_de_cd2.Text.Trim, txtTieu_de_cd3.Text.Trim, txtTieu_de_cd4.Text.Trim, txtTen_nguoi_ky1.Text.Trim, txtTen_nguoi_ky2.Text.Trim, txtTen_nguoi_ky3.Text.Trim, txtTen_nguoi_ky4.Text.Trim, txtTieu_de_noi_ky.Text.Trim)
            Else ' Nếu thêm mới
                If clsDanhMuc.CheckTieuDe_BaoCao(gobjUser.ID_dv, gobjUser.UserID) Then
                    Thongbao("Tiêu đề báo cáo đã tồn tại bạn không thể thêm mới !")
                    Exit Sub
                Else
                    clsDanhMuc.InsertTieuDe_BaoCao(gobjUser.ID_dv, gobjUser.UserID, txtTieu_de_ten_bo.Text.Trim, txtTieu_de_ten_truong.Text.Trim, txtTieu_de_cd1.Text.Trim, txtTieu_de_cd2.Text.Trim, txtTieu_de_cd3.Text.Trim, txtTieu_de_cd4.Text.Trim, txtTen_nguoi_ky1.Text.Trim, txtTen_nguoi_ky2.Text.Trim, txtTen_nguoi_ky3.Text.Trim, txtTen_nguoi_ky4.Text.Trim, txtTieu_de_noi_ky.Text.Trim)
                End If
            End If
            Thongbao("Bạn đã cập nhật thành công !")
            Visible_Button(True)
            Enabled_Control(False)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
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
                Thongbao("Bạn không có quyền xóa các loại tiêu đề này, Quản trị hệ thống mới được phép xóa !")
                Exit Sub
            End If
            If Thongbao("Bạn có muốn xóa các loại tiêu đề này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            Thongbao("Bạn đã xóa thành công các loại tiêu đề này.")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Try
            Visible_Button(True)
            Enabled_Control(False)
            Enabled_Control(False)
            Dim clsDanhMuc As New DanhMuc_Bussines
            Dim dt As DataTable
            dt = clsDanhMuc.TieuDe_BaoCao(gobjUser.ID_dv, gobjUser.UserID)
            If dt.Rows.Count > 0 Then
                txtTieu_de_ten_bo.Text = dt.Rows(0)("Tieu_de_ten_bo").ToString
                txtTieu_de_ten_truong.Text = dt.Rows(0)("Tieu_de_ten_truong").ToString
                txtTieu_de_cd1.Text = dt.Rows(0)("Tieu_de_chuc_danh1").ToString
                txtTieu_de_cd2.Text = dt.Rows(0)("Tieu_de_chuc_danh2").ToString
                txtTieu_de_cd3.Text = dt.Rows(0)("Tieu_de_chuc_danh3").ToString
                txtTieu_de_cd4.Text = dt.Rows(0)("Tieu_de_chuc_danh4").ToString
                txtTen_nguoi_ky1.Text = dt.Rows(0)("Tieu_de_nguoi_ky1").ToString
                txtTen_nguoi_ky2.Text = dt.Rows(0)("Tieu_de_nguoi_ky2").ToString
                txtTen_nguoi_ky3.Text = dt.Rows(0)("Tieu_de_nguoi_ky3").ToString
                txtTen_nguoi_ky4.Text = dt.Rows(0)("Tieu_de_nguoi_ky4").ToString
                txtTieu_de_noi_ky.Text = dt.Rows(0)("Tieu_de_noi_ky").ToString
            End If
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
        If txtTieu_de_ten_bo.Text.Trim = "" Then
            Call SetErrPro(txtTieu_de_ten_bo, ErrorProvider1, "Bạn hãy nhập loại quỹ học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtTieu_de_ten_bo
        End If
        'If txtGhi_chu.Text.Trim = "" Then
        '    Call SetErrPro(txtGhi_chu, ErrorProvider1, "Bạn hãy nhập Ghi chú !")
        '    If CtrlErr Is Nothing Then CtrlErr = txtGhi_chu
        'End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub Clear_Control()
        Try
            txtTieu_de_ten_bo.Text = ""
            txtTieu_de_ten_truong.Text = ""
            txtTieu_de_cd1.Text = ""
            txtTieu_de_cd2.Text = ""
            txtTieu_de_cd3.Text = ""
            txtTieu_de_cd4.Text = ""
            txtTen_nguoi_ky1.Text = ""
            txtTen_nguoi_ky2.Text = ""
            txtTen_nguoi_ky3.Text = ""
            txtTen_nguoi_ky4.Text = ""
            txtTieu_de_noi_ky.Text = ""
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtTieu_de_ten_bo.Enabled = f
        txtTieu_de_ten_truong.Enabled = f
        txtTieu_de_cd1.Enabled = f
        txtTieu_de_cd2.Enabled = f
        txtTieu_de_cd3.Enabled = f
        txtTieu_de_cd4.Enabled = f
        txtTen_nguoi_ky1.Enabled = f
        txtTen_nguoi_ky2.Enabled = f
        txtTen_nguoi_ky3.Enabled = f
        txtTen_nguoi_ky4.Enabled = f
        txtTieu_de_noi_ky.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Visible = f
        cmdEdit.Visible = f
        cmdDelete.Visible = False
        cmdCancel.Visible = Not f
        cmdSave.Visible = Not f
    End Sub
#End Region

End Class
