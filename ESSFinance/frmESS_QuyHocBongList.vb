Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_QuyHocBongList
    Private Loader As Boolean = False
    Private Sub frmESS_QuyHocBongList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        SetUpDataGridView(grdViewQuyHocBong)
        Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        Dim dt As DataTable
        dt = obj.DanhSach_QuyHocBong()
        grdViewQuyHocBong.DataSource = dt.DefaultView
        SetQuyenTruyCap(, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_QuyHocBongList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Button"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim frmESS_ As New frmESS_QuyHocBong(False, 0, 0, "")
        frmESS_.ShowDialog()
        Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        Dim dt As DataTable
        dt = obj.DanhSach_QuyHocBong()
        grdViewQuyHocBong.DataSource = dt.DefaultView
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Dim dv As New DataView
        dv = grdViewQuyHocBong.DataSource
        If dv.Count = 0 Then Exit Sub
        Dim idx As Integer = 0
        idx = grdViewQuyHocBong.CurrentRow.Index
        Dim frmESS_ As New frmESS_QuyHocBong(True, idx, cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        frmESS_.ShowDialog()
        Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        Dim dt As DataTable
        dt = obj.DanhSach_QuyHocBong()
        grdViewQuyHocBong.DataSource = dt.DefaultView
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim dv As New DataView
        dv = grdViewQuyHocBong.DataSource
        If dv.Count = 0 Then Exit Sub
        If Thongbao("Bạn có muốn xóa quỹ học bổng không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim obj As New QuyHocBong_Bussines()
        Dim idx As Integer = 0
        idx = grdViewQuyHocBong.CurrentRow.Index
        obj.Xoa_ESSQuyHocBong(dv.Item(idx)("ID_hb"))
        dv.Item(idx).Delete()
        dv.Table.AcceptChanges()
        grdViewQuyHocBong.DataSource = dv
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        If Not Loader Then Exit Sub
        Dim obj_Bussines As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        Dim dt As DataTable
        dt = obj_Bussines.DanhSach_QuyHocBong()
        grdViewQuyHocBong.DataSource = dt.DefaultView
    End Sub
#End Region

End Class