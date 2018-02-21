Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines

Public Class frmESS_UsersGanVaiTro
#Region "var"
    Private _users As Users_Bussines
    Private _data_load As Boolean
    Private dtVaiTro, dtVaiTroGan As New DataTable
    Private ClsUsers As New Users_Bussines(9, gobjUser.UserName)
#End Region
    Private mUserName As String = ""
#Region "Form Event"
    Public Overloads Sub ShowDialog(ByVal UserName As String, ByVal users As Users_Bussines)
        mUserName = UserName
        _users = users
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_UsersGanVaiTro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_UsersGanVaiTro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdViewQuyen)
        SetUpDataGridView(Me.grdViewQuyenGan)
        HienThi_ESSData()
    End Sub
    Private Sub frmESS_UsersGanVaiTro_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Event"
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        If grdViewQuyen.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyen.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAll.Checked = True Then
            Call CheckBox_All(True, dv, "Chon")
        Else
            Call CheckBox_All(False, dv, "Chon")
        End If
    End Sub

    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        If grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyenGan.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAll1.Checked = True Then
            Call CheckBox_All(True, dv, "Chon")
        Else
            Call CheckBox_All(False, dv, "Chon")
        End If
    End Sub

    ''Thêm vai trò cho User
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If grdViewQuyen.DataSource Is Nothing Or grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim i As Integer
        Try
            Dim dv1 As DataView = Me.grdViewQuyen.DataSource
            Dim dv2 As DataView = Me.grdViewQuyenGan.DataSource
            '
            dv2.AllowNew = True
            dv1.AllowDelete = True
            '
            For i = dv1.Count - 1 To 0 Step -1
                If dv1.Table.Rows(i)("Chon") Then
                    Dim dr As DataRow = dv2.Table.NewRow
                    dr.ItemArray = dv1.Item(i).Row.ItemArray
                    dr.Item("Chon") = False
                    dv2.Table.Rows.Add(dr)
                    dv1.Item(i).Delete()
                End If
            Next
            '
            dv2.AllowNew = False
            dv1.AllowDelete = False
            dv1.Table.AcceptChanges()
            dv2.Table.AcceptChanges()
            Me.grdViewQuyen.DataSource = dv1
            Me.grdViewQuyenGan.DataSource = dv2
            If dv1.Count > 0 Then
                btnAdd.Enabled = True
            Else
                btnAdd.Enabled = False
            End If
            If dv2.Count > 0 Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
            optAll.Checked = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''Bớt vai trò của User
    Private Sub btnXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If grdViewQuyen.DataSource Is Nothing Or grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim i As Integer
        Try
            Dim dv1 As DataView = Me.grdViewQuyen.DataSource
            Dim dv2 As DataView = Me.grdViewQuyenGan.DataSource
            '
            dv1.AllowNew = True
            dv2.AllowDelete = True
            '
            For i = dv2.Count - 1 To 0 Step -1
                If dv2.Table.Rows(i)("Chon") Then
                    Dim dr As DataRow = dv1.Table.NewRow
                    dr.ItemArray = dv2.Item(i).Row.ItemArray
                    dr.Item("Chon") = False
                    dv1.Table.Rows.Add(dr)
                    dv2.Item(i).Delete()
                End If
            Next
            '
            dv1.AllowNew = False
            dv2.AllowDelete = False
            dv1.Table.AcceptChanges()
            dv2.Table.AcceptChanges()
            Me.grdViewQuyen.DataSource = dv1
            Me.grdViewQuyenGan.DataSource = dv2
            If dv1.Count > 0 Then
                btnAdd.Enabled = True
            Else
                btnAdd.Enabled = False
            End If
            If dv2.Count > 0 Then
                btnDelete.Enabled = True
            Else
                btnDelete.Enabled = False
            End If
            optAll1.Checked = False
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    ''Lưu mọi thay đổi
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As DataView = grdViewQuyenGan.DataSource
            Dim dt As DataTable = dv.Table
            Dim i As Integer
            If Thongbao("Bạn thực sự muốn thay đôi chứ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim guser As ESSUsers = _users.Tim_UserName(mUserName)
                '' Remove các quyền của vai tro
                If Not guser.ESSVaiTro Is Nothing Then
                    For i = guser.ESSVaiTro.Count - 1 To 0 Step -1
                        guser.ESSVaiTro.Remove(i)
                    Next
                End If

                _users.Xoa_ESSUserVaiTro(guser.UserID)

                '' Add các vai tro cua User
                For i = 0 To dt.Rows.Count - 1
                    Dim VaiTro As New ESSVaiTro
                    VaiTro.ID_vai_tro = CInt(dt.Rows(i)("ID_vai_tro").ToString)
                    VaiTro.Ten_vai_tro = dt.Rows(i)("Ten_vai_tro").ToString
                    VaiTro.Mo_ta = dt.Rows(i)("Mo_ta").ToString
                    guser.ESSVaiTro.Add(VaiTro)
                Next
                _users.ThemMoi_ESSUserVaiTro(mUserName)
                Thongbao("Đã thay đổi thành công ! ", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region

#Region "User Function"
    Private Sub HienThi_ESSData()
        dtVaiTroGan = _users.HienThi_ESSVaiTroGan(mUserName)
        dtVaiTro = ClsUsers.HienThi_ESSVaiTro(gobjUser, dtVaiTroGan)
        Me.grdViewQuyen.DataSource = dtVaiTro.DefaultView
        Me.grdViewQuyenGan.DataSource = dtVaiTroGan.DefaultView
    End Sub
    Public Sub CheckBox_All(ByVal Status As Boolean, ByVal dv As DataView, ByVal NameCol As String)
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i)(NameCol) = Status
        Next
    End Sub

#End Region
End Class