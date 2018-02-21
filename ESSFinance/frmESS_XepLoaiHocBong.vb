Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_XepLoaiHocBong
    Private mEdit As Boolean = False
    Private mID_xep_loai_hb As Integer = 0
    Private mTen_xep_loai As String = ""
    Private Loader As Boolean = False
    Private mIdx As Integer = 0
    Private clsDanhMuc As New DanhMuc_Bussines
#Region "Form Event"
    Private Sub frmESS_XepLoaiHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewXepLoai)
        Dim dv As DataView
        dv = clsDanhMuc.DanhMuc_Load("STU_XepLoaiHocBong", "ID_xep_loai_hb", "Ten_xep_loai").DefaultView
        grdViewXepLoai.DataSource = dv
        Enabled_Control(False)
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_XepLoaiHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
                Thongbao("Bạn không có quyền xóa, Quản trị hệ thống mới được phép xóa !")
                Exit Sub
            End If
            If Thongbao("Bạn có muốn xóa loại học bổng này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            clsDanhMuc.DanhMuc_Delete("STU_XepLoaiHocBong", "Ten_xep_loai", mTen_xep_loai)
            Dim dt As DataTable
            dt = clsDanhMuc.DanhMuc_Load("STU_XepLoaiHocBong", "ID_xep_loai_hb", "Ten_xep_loai")
            grdViewXepLoai.DataSource = dt.DefaultView
            Thongbao("Bạn đã xóa thành công loại học bổng.")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim Ten_xep_loai As String = txtTen_xep_loai.Text.Trim
            If mEdit Then
                clsDanhMuc.DanhMuc_Update("STU_XepLoaiHocBong", "ID_xep_loai_hb", mID_xep_loai_hb, "Ten_xep_loai", Ten_xep_loai)
            Else
                If Not clsDanhMuc.DanhMuc_CheckName("STU_XepLoaiHocBong", "Ten_xep_loai", Ten_xep_loai) Then
                    clsDanhMuc.DanhMuc_Insert("STU_XepLoaiHocBong", "Ten_xep_loai", Ten_xep_loai)
                End If
            End If
            Dim dt As DataTable
            dt = clsDanhMuc.DanhMuc_Load("STU_XepLoaiHocBong", "ID_xep_loai_hb", "Ten_xep_loai")
            grdViewXepLoai.DataSource = dt.DefaultView
            Visible_Button(True)
            Enabled_Control(False)
            Thongbao("Bạn đã cập nhật thành công loại học bổng !")
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
        If txtTen_xep_loai.Text.Trim = "" Then
            Call SetErrPro(txtTen_xep_loai, ErrorProvider1, "Bạn hãy nhập loại học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_xep_loai
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
            dv = grdViewXepLoai.DataSource
            If dv.Count = 0 Then Exit Sub
            mIdx = grdViewXepLoai.CurrentRow.Index
            txtTen_xep_loai.Text = dv.Item(mIdx)("Ten_xep_loai")
            mID_xep_loai_hb = dv.Item(mIdx)("ID_xep_loai_hb")
            mTen_xep_loai = dv.Item(mIdx)("Ten_xep_loai")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Enabled_Control(ByVal f As Boolean)
        txtTen_xep_loai.Enabled = f
    End Sub
    Private Sub Visible_Button(ByVal f As Boolean)
        cmdAdd.Visible = f
        cmdEdit.Visible = f
        cmdDelete.Visible = f
        cmdCancel.Visible = Not f
        cmdSave.Visible = Not f
    End Sub
    Private Sub Clear_Control()
        txtTen_xep_loai.Text = ""
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewXepLoai_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewXepLoai.CurrentCellChanged
        Try
            If Not Loader Then Exit Sub
            Fill_Data()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
End Class
