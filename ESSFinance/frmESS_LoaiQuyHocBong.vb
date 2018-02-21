Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_LoaiQuyHocBong
    Private mEdit As Boolean = False
    Private Loader As Boolean = False
    Private mID_quy As Integer = 0
    Private mIdx As Integer = 0
#Region "Form Event"
    Private Sub frmESS_LoaiQuyHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewLoaiQuy)
        Dim dv As DataView
        Dim clsLoaiQuy As New QuyHocBong_Bussines(True)
        dv = clsLoaiQuy.HienThi_ESSLoaiQuy().DefaultView
        grdViewLoaiQuy.DataSource = dv
        Enabled_Control(False)
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_LoaiQuyHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
                Thongbao("Bạn không có quyền xóa loại học bổng này, Quản trị hệ thống mới được phép xóa !")
                Exit Sub
            End If
            If Thongbao("Bạn có muốn xóa loại học bổng này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            Dim clsLoaiQuy As New QuyHocBong_Bussines(True)
            clsLoaiQuy.Xoa_ESSLoaiQuy(mID_quy)
            clsLoaiQuy.Xoa_ESSObject(mIdx)
            Dim dt As DataTable
            dt = clsLoaiQuy.HienThi_ESSLoaiQuy()
            grdViewLoaiQuy.DataSource = dt.DefaultView
            Thongbao("Bạn đã xóa thành công loại học bổng.")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim clsLoaiQuy As New QuyHocBong_Bussines(True)
            Dim obj As New ESSLoaiQuy
            obj.ID_quy = mID_quy
            obj.Loai_quy = txtLoai_quy.Text.Trim
            obj.Ghi_chu = txtGhi_chu.Text.Trim
            If mEdit Then  ' Nếu sửa
                clsLoaiQuy.CapNhat_ESSLoaiQuy(obj)
                clsLoaiQuy.CapNhat_ESSObjec(obj, mIdx)
            Else
                If Not clsLoaiQuy.CheckExist_svLoaiQuy(obj.Loai_quy) Then
                    Dim ID_quy As Integer = 0
                    ID_quy = clsLoaiQuy.ThemMoi_ESSLoaiQuy(obj)
                    obj.ID_quy = ID_quy
                    clsLoaiQuy.ThemMoi_ESSObject(obj)
                End If
            End If
            Visible_Button(True)
            Enabled_Control(False)
            Dim dt As DataTable
            dt = clsLoaiQuy.HienThi_ESSLoaiQuy()
            grdViewLoaiQuy.DataSource = dt.DefaultView
            Thongbao("Bạn đã cập nhật thành công loại quỹ học bổng !")
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
        If txtLoai_quy.Text.Trim = "" Then
            Call SetErrPro(txtLoai_quy, ErrorProvider1, "Bạn hãy nhập loại quỹ học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtLoai_quy
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
    Private Sub Fill_Data()
        Try
            Dim dv As New DataView
            dv = grdViewLoaiQuy.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdViewLoaiQuy.CurrentRow.Index
            txtLoai_quy.Text = dv.Item(mIdx)("Loai_quy")
            txtGhi_chu.Text = dv.Item(mIdx)("Ghi_chu")
            mID_quy = dv.Item(mIdx)("ID_quy")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtLoai_quy.Enabled = f
        txtGhi_chu.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Visible = f
        cmdEdit.Visible = f
        cmdDelete.Visible = f
        cmdCancel.Visible = Not f
        cmdSave.Visible = Not f
    End Sub
    Private Sub Clear_Control()
        txtLoai_quy.Text = ""
        txtGhi_chu.Text = ""
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewLoaiThuChi_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewLoaiQuy.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class
