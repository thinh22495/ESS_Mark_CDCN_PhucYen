Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DoiTuongHocBong
    Private mEdit As Boolean = False
    Private Loader As Boolean = False
    Private mID_dt_hb As Integer = 0
    Private mIdx As Integer = 0
#Region "Form Event"
    Private Sub frmESS_DoiTuongHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewDoiTuongHB)
        Dim dv As DataView
        Dim cls As New DoiTuongTroCap_Bussines
        dv = cls.DanhSach_DoiTuong_HocBong().DefaultView
        grdViewDoiTuongHB.DataSource = dv
        Enabled_Control(False)
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_DoiTuongHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
                Thongbao("Bạn không có quyền xóa , Quản trị hệ thống mới được phép xóa !")
                Exit Sub
            End If
            If Thongbao("Bạn có muốn xóa loại học bổng này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim cls As New DoiTuongTroCap_Bussines
            cls.Xoa_ESSDoiTuongTroCap(mID_dt_hb)
            cls.Xoa_ESSDoiTuongTroCap_Object(mIdx)
            Dim dt As DataTable
            dt = cls.DanhSach_DoiTuong_HocBong()
            grdViewDoiTuongHB.DataSource = dt.DefaultView
            Thongbao("Bạn đã xóa thành công Đối tượng học bổng.")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim cls As New DoiTuongTroCap_Bussines
            Dim obj As New ESSDoiTuongTroCap
            obj.ID_dt_hb = mID_dt_hb
            obj.Ma_dt_hb = txtMa_dt_hb.Text.Trim
            obj.Ten_dt_hb = txtTen_dt_hb.Text.Trim
            obj.Sotien_trocap = txtSotien_trocap.Text.Trim
            If mEdit Then  ' Nếu sửa
                cls.CapNhat_ESSDoiTuongTroCap(obj, obj.ID_dt_hb)
                cls.CapNhat_ESSDoiTuongTroCap_Object(obj, mIdx)
            Else
                If Not cls.KiemTra_DoiTuongTroCap(obj.Ma_dt_hb) Then
                    Dim ID_dt_hb As Integer = 0
                    ID_dt_hb = cls.ThemMoi_ESSDoiTuongTroCap(obj)
                    obj.ID_dt_hb = ID_dt_hb
                    cls.ThemMoi_ESSDoiTuongTroCap_Object(obj)
                End If
            End If
            Visible_Button(True)
            Enabled_Control(False)
            Dim dt As DataTable
            dt = cls.DanhSach_DoiTuong_HocBong()
            grdViewDoiTuongHB.DataSource = dt.DefaultView
            Thongbao("Bạn đã cập nhật thành công đối tượng học bổng !")
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
        If txtMa_dt_hb.Text.Trim = "" Then
            Call SetErrPro(txtMa_dt_hb, ErrorProvider1, "Bạn hãy nhập mã đối tượng học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtMa_dt_hb
        End If
        If txtTen_dt_hb.Text.Trim = "" Then
            Call SetErrPro(txtTen_dt_hb, ErrorProvider1, "Bạn hãy nhập Tên đối tượng học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_dt_hb
        End If
        If txtSotien_trocap.Text.Trim = "" Then
            Call SetErrPro(txtSotien_trocap, ErrorProvider1, "Bạn hãy nhập Số tiền trợ cấp !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_trocap
        ElseIf Not IsNumeric(txtSotien_trocap.Text.Trim) Then
            Call SetErrPro(txtSotien_trocap, ErrorProvider1, "Bạn hãy nhập Số tiền trợ cấp là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_trocap
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
            dv = grdViewDoiTuongHB.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdViewDoiTuongHB.CurrentRow.Index
            txtMa_dt_hb.Text = dv.Item(mIdx)("Ma_dt_hb")
            txtTen_dt_hb.Text = dv.Item(mIdx)("Ten_dt_hb")
            txtSotien_trocap.Text = dv.Item(mIdx)("Sotien_trocap")
            mID_dt_hb = dv.Item(mIdx)("ID_dt_hb")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtMa_dt_hb.Enabled = f
        txtTen_dt_hb.Enabled = f
        txtSotien_trocap.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Visible = f
        cmdEdit.Visible = f
        cmdDelete.Visible = f
        cmdCancel.Visible = Not f
        cmdSave.Visible = Not f
    End Sub
    Private Sub Clear_Control()
        txtMa_dt_hb.Text = ""
        txtTen_dt_hb.Text = ""
        txtSotien_trocap.Text = ""
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewDoiTuongHB_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewDoiTuongHB.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class
