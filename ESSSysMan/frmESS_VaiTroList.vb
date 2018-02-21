Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines

Public Class frmESS_VaiTroList
    Dim clsVaiTro As New VaiTro_Bussines
    Private ClsUsers As New Users_Bussines(9, gobjUser.UserName)

#Region "Form Event"
    Private Sub frmESS_VaiTroList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdViewVaiTro)
        Call HienThi_ESSgrd()
    End Sub
    Private Sub frmESS_VaiTroList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Event Function"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim frmESS_ As New frmESS_VaiTro
        frmESS_.Tag = 0
        frmESS_.dtVaitro = grdViewVaiTro.DataSource
        frmESS_.ShowDialog()
        Call HienThi_ESSgrd()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim frmESS_ As New frmESS_VaiTro
        Dim dt As DataTable = grdViewVaiTro.DataSource
        Dim CurrenIndex As Integer
        If dt.Rows.Count > 0 Then
            CurrenIndex = Me.grdViewVaiTro.CurrentRow.Index
            frmESS_.Tag = 1
            frmESS_.dtVaitro = dt
            frmESS_.ID_Vai_tro = dt.Rows(CurrenIndex)("ID_Vai_Tro")
            frmESS_.Ten_Vai_tro = dt.Rows(CurrenIndex)("Ten_Vai_Tro")
            frmESS_.Mo_ta = dt.Rows(CurrenIndex)("Mo_ta")
            frmESS_.idx_vaitro = CurrenIndex
            frmESS_.ShowDialog()
            Call HienThi_ESSgrd()
        Else
            Thongbao("Không có dữ liệu để sửa", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim dt As DataTable = grdViewVaiTro.DataSource
        Dim CurrenIndex As Integer
        If dt.Rows.Count > 0 Then
            CurrenIndex = Me.grdViewVaiTro.CurrentRow.Index
            If Thongbao("Bạn có muốn xóa vai trò " + dt.Rows(CurrenIndex)("Ten_Vai_Tro") + " không?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                '' Kiểm tra xem vai trò đã đc gán quyền chưa?
                If clsVaiTro.CheckExist_htVaiTroQuyen(dt.Rows(CurrenIndex)("id_Vai_Tro")) Then
                    Thongbao("Vai trò " & dt.Rows(CurrenIndex)("Ten_Vai_Tro") & " đã được gán quyền rồi, nên ko xóa được ", MsgBoxStyle.OkOnly)
                    Exit Sub
                Else
                    clsVaiTro.Xoa_ESSUsersVaitro(gobjUser.UserID, dt.Rows(CurrenIndex)("ID_Vai_Tro"))
                    gobjUser.ESSVaiTro.Remove(CurrenIndex)
                    'clsVaiTro.Xoa_ESSVaiTro(dt.Rows(CurrenIndex)("ID_Vai_Tro"))
                    Thongbao("Đã xóa thành công !", MsgBoxStyle.OkOnly)
                    Call HienThi_ESSgrd()
                End If
            End If
        Else
            Thongbao("Không có dữ liệu để xóa", MsgBoxStyle.OkOnly, "Thông báo")
        End If
    End Sub

    Private Sub cmdGan_quyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGan_quyen.Click
        Dim frmESS_ As New frmESS_VaiTroGanQuyen
        Dim dt As DataTable = grdViewVaiTro.DataSource
        Dim CurrenIndex As Integer
        If dt.Rows.Count > 0 Then
            CurrenIndex = Me.grdViewVaiTro.CurrentRow.Index
            frmESS_.ID_Vai_tro = dt.Rows(CurrenIndex)("ID_Vai_Tro")
            frmESS_.ShowDialog()
        Else
            Thongbao("Không có vai trò nào để gán", MsgBoxStyle.OkOnly, "Thông báo")
        End If
    End Sub
#End Region

#Region "Load Data Function"
    Public Sub HienThi_ESSgrd()
        'clsVaiTro = New VaiTro_Bussines()
        grdViewVaiTro.DataSource = ClsUsers.HienThi_ESSVaiTro(gobjUser)
    End Sub
#End Region
End Class