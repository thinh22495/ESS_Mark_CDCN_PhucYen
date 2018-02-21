Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines

Public Class frmESS_VaiTroGanQuyen

#Region "Var"
    Public ID_Vai_tro As Integer = 0
    Public idx_vaitro As Integer
    Dim objVaiTro As ESSVaiTro '= clsVaiTro.ESSVaiTro(idx)
    Dim clsVaiTro As VaiTro_Bussines
    Dim loaded As Boolean = False
    Dim dtQuyen, dtGanQuyen As DataTable
#End Region

#Region "Form Load"
    Private Sub frmESS_VaiTroGanQuyen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_VaiTroGanQuyen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdViewQuyen)
        SetUpDataGridView(Me.grdViewQuyenGan)
        clsVaiTro = New VaiTro_Bussines(ID_Vai_tro)
        objVaiTro = CType(clsVaiTro.aVaiTro(0), ESSVaiTro)
        Call HienThi_ESSData()
        loaded = True
    End Sub
    Private Sub frmESS_VaiTroGanQuyen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Function"

    Private Sub cmbPhan_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPhan_he.SelectedIndexChanged
        If loaded = False Then Exit Sub
        dtQuyen.DefaultView.RowFilter = "ID_ph=" & cmbPhan_he.SelectedValue
        dtGanQuyen.DefaultView.RowFilter = "ID_ph=" & cmbPhan_he.SelectedValue
        grdViewQuyen.DataSource = dtQuyen.DefaultView
        grdViewQuyenGan.DataSource = dtGanQuyen.DefaultView
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Or grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim i As Integer
        Try
            Dim dv1 As DataView = Me.grdViewQuyen.DataSource
            Dim dv2 As DataView = Me.grdViewQuyenGan.DataSource
            '

            dv2.AllowNew = True
            dv1.AllowDelete = True
            '
            For i = dv1.Count - 1 To 0 Step -1
                If dv1.Item(i)("Chon") Then
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
            If Not cmbPhan_he.SelectedValue Is Nothing Then
                dv2.RowFilter = "ID_ph=" & cmbPhan_he.SelectedValue
            End If
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
            loaded = False : optAll.Checked = False : optAllIns.Checked = False : optAllUpd.Checked = False : optAllDel.Checked = False : loaded = True
        Catch ex As Exception
            Throw ex
        End Try

    End Sub

    Private Sub btnXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Or grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim i As Integer
        Try
            Dim dv1 As DataView = Me.grdViewQuyen.DataSource
            Dim dv2 As DataView = Me.grdViewQuyenGan.DataSource
            '
            dv1.AllowNew = True
            dv2.AllowDelete = True
            '
            For i = dv2.Count - 1 To 0 Step -1
                If dv2.Item(i)("Chon") Then
                    Dim dr As DataRow = dv1.Table.NewRow
                    dr.ItemArray = dv2.Item(i).Row.ItemArray
                    dr.Item("Chon") = False
                    dr.Item("Them") = False
                    dr.Item("Sua") = False
                    dr.Item("Xoa") = False
                    dv1.Table.Rows.Add(dr)
                    dv2.Item(i).Delete()
                End If
            Next
            '
            dv1.AllowNew = False
            dv2.AllowDelete = False
            dv1.Table.AcceptChanges()
            dv2.Table.AcceptChanges()
            If Not cmbPhan_he.SelectedValue Is Nothing Then
                dv1.RowFilter = "ID_ph=" & cmbPhan_he.SelectedValue
            End If
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
            loaded = False : optAll1.Checked = False : loaded = True
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As DataView = grdViewQuyenGan.DataSource
            If ID_Vai_tro = 1 Then
                Thongbao("Bạn không được sửa vai trò quản trị hệ thống.", MsgBoxStyle.OkOnly)
                Exit Sub
            End If
            Dim dt As DataTable = dv.Table
            Dim i As Integer
            If Thongbao("Bạn thực sự muốn thay đôi chứ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                '' Remove các quyền của vai tro
                If Not objVaiTro Is Nothing Then
                    For i = objVaiTro.ESSVaiTroQuyen.Count - 1 To 0 Step -1
                        objVaiTro.ESSVaiTroQuyen.Remove(i)
                        'gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro).VaiTroQuyen.Remove(i)
                    Next
                End If

                clsVaiTro.Xoa_ESSVaiTroQuyen(ID_Vai_tro)

                '' Add các quyền của vai tro
                For i = 0 To dt.Rows.Count - 1
                    Dim objVaiTroQuyen As New ESSVaiTroQuyen
                    objVaiTroQuyen.ID_quyen = CInt(dt.Rows(i)("ID_Quyen"))
                    objVaiTroQuyen.Them = CovertingBoolToInt(dt.Rows(i)("Them"))
                    objVaiTroQuyen.Sua = CovertingBoolToInt(dt.Rows(i)("Sua"))
                    objVaiTroQuyen.Xoa = CovertingBoolToInt(dt.Rows(i)("Xoa"))
                    objVaiTro.ESSVaiTroQuyen.Add(objVaiTroQuyen)
                    gobjUser.ESSVaiTro.ESSVaiTro(idx_vaitro).ESSVaiTroQuyen.Add(objVaiTroQuyen)
                Next
                objVaiTro.ID_vai_tro = ID_Vai_tro
                clsVaiTro.ThemMoi_ESSVaiTroQuyen(0)
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

#Region "Check Event"

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyen.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAll.Checked = True Then
            Call CheckBox_All(True, dv, "Chon")
        Else
            Call CheckBox_All(False, dv, "Chon")
        End If
    End Sub

    Private Sub optAllUpd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllUpd.CheckedChanged
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyen.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAllUpd.Checked = True Then
            Call CheckBox_All(True, dv, "Sua")
        Else
            Call CheckBox_All(False, dv, "Sua")
        End If
    End Sub

    Private Sub optAllIns_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllIns.CheckedChanged
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyen.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAllIns.Checked = True Then
            Call CheckBox_All(True, dv, "Them")
        Else
            Call CheckBox_All(False, dv, "Them")
        End If
    End Sub

    Private Sub optAllDel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAllDel.CheckedChanged
        If Not loaded Or grdViewQuyen.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyen.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAllDel.Checked = True Then
            Call CheckBox_All(True, dv, "Xoa")
        Else
            Call CheckBox_All(False, dv, "Xoa")
        End If
    End Sub

    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        If Not loaded Or grdViewQuyenGan.DataSource Is Nothing Then Exit Sub
        Dim dv As DataView = grdViewQuyenGan.DataSource
        If dv.Count <= 0 Then Exit Sub
        If optAll1.Checked = True Then
            Call CheckBox_All(True, dv, "Chon")
        Else
            Call CheckBox_All(False, dv, "Chon")
        End If
    End Sub

#End Region

#Region "User Function"

    Private Sub HienThi_ESSData()
        FillCombo(cmbPhan_he, clsVaiTro.HienThi_ESSPhanHe_DanhSach(gobjUser))
        dtQuyen = clsVaiTro.HienThi_ESSUsersQuyen_DanhSach(gobjUser, ID_Vai_tro)
        dtGanQuyen = clsVaiTro.HienThi_ESSVaiTroQuyenGan_DanhSach
        grdViewQuyen.DataSource = dtQuyen.DefaultView
        grdViewQuyenGan.DataSource = dtGanQuyen.DefaultView
    End Sub

    Public Sub CheckBox_All(ByVal Status As Boolean, ByVal dv As DataView, ByVal NameCol As String)
        For i As Integer = 0 To dv.Count - 1
            dv.Item(i)(NameCol) = Status
        Next
    End Sub

    Public Function CovertingBoolToInt(ByVal Int As Boolean) As Integer
        If Int Then
            Return 1
        Else
            Return 0
        End If
    End Function

#End Region
End Class