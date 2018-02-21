Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_UsersList
#Region " Var"
    Private user As New Users_Bussines(gobjUser.UserID, gobjUser.ID_khoa, gobjUser.ID_Bomon, gobjUser.ID_phong)
#End Region
#Region " Form Event"
    Private Sub frmESS_UsersList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call HienThi_ESSdata()
        If gobjUser.UserID <> 1 Then
            cmdAdd.Enabled = False
            cmdEdit.Enabled = False
            cmdDelete.Enabled = False
            cmdGan_lop.Enabled = False
        End If
    End Sub
    Private Sub frmESS_UsersList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region " Control Events"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim frmESS_ As New frmESS_Users
            frmESS_.Tag = 0
            frmESS_.ShowDialog(gobjUser.UserName, user)
            HienThi_ESSdata()
        Catch ex As Exception
            Throw (ex)
        End Try

    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            If dv.Count <= 0 Then Exit Sub
            Dim frmESS_ As New frmESS_Users
            frmESS_.Tag = 1
            frmESS_.ShowDialog(dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("UserName"), user)
            HienThi_ESSdata()
        Catch ex As Exception
            Throw (ex)
        End Try

    End Sub

    Private Sub cmdGan_quyen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGan_quyen.Click
        Dim dv As DataView = GetFilteredDataView(grcDanhSach)
        If dv.Count <= 0 Then Exit Sub
        Dim frmESS_ As New frmESS_UsersGanVaiTro
        frmESS_.ShowDialog(dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("UserName"), user)
    End Sub

    Private Sub cmdGan_lop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGan_lop.Click
        Dim dv As DataView = GetFilteredDataView(grcDanhSach)
        If dv.Count <= 0 Then Exit Sub
        Dim frmESS_ As New frmESS_VaiTroGanLop
        frmESS_.ShowDialog(dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("UserName"), user)
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            If dv.Count <= 0 Then Exit Sub
            'Dim dt As DataTable = Me.grdViewVaiTro.DataSource
            Dim UserID As Integer = dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("UserID")
            If Thongbao("Bãn có chắc chắn muốn xóa người dùng không ?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                If user.KiemTra_UserLop(UserID) Then
                    Thongbao("User này đã được gán lớp rồi không xóa được", MsgBoxStyle.Information)
                    Exit Sub
                End If
                If user.KiemTra_UserVaiTro(UserID) Then
                    Thongbao("User này đã được gán vai trò rồi không xóa được", MsgBoxStyle.Information)
                    Exit Sub
                End If
                user.Xoa_ESSUsers(UserID)
                user.Remove(grvDanhSach.GetSelectedRows().GetValue(0))
                HienThi_ESSdata()
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdCoVan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCoVan.Click
        Try
            Dim dv As DataView = GetFilteredDataView(grcDanhSach)
            If dv.Count <= 0 Then Exit Sub
            Dim frmESS_ As New frmESS_UsersCoVanHocTap
            frmESS_.ShowDialog(dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("UserName"), dv.Item(grvDanhSach.GetSelectedRows().GetValue(0))("FullName"))
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region " User Functions"
    Private Sub HienThi_ESSdata()
        user = New Users_Bussines(gobjUser.UserID, gobjUser.ID_khoa, gobjUser.ID_Bomon, gobjUser.ID_phong)
        grcDanhSach.DataSource = user.HienThi_ESSUsers.DefaultView
    End Sub
#End Region
End Class