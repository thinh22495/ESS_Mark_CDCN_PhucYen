Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XetTotNghiep_DangKy123
    Dim clsXet As DanhSachLuanVanThiNoTotNghiep_Bussines

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub frmESS_XetTotNghiep_DangKy_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TreeViewLop.HienThi_ESSTreeView()
        SetQuyenTruyCap(, cmdDuyet, , )
    End Sub

    Private Sub frmESS_XetTotNghiep_DangKy_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub TreeViewLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            Dim dk As String = "SELECT ID_lop FROM STU_LOP WHERE 1=1"
            If TreeViewLop.ID_he > 0 Then dk = dk & " AND ID_he=" & TreeViewLop.ID_he
            If TreeViewLop.Khoa_hoc > 0 Then dk = dk & " AND Khoa_hoc=" & TreeViewLop.Khoa_hoc
            If TreeViewLop.ID_chuyen_nganh > 0 Then dk = dk & " AND ID_chuyen_nganh=" & TreeViewLop.ID_chuyen_nganh
            If TreeViewLop.ID_lop_list <> "" And TreeViewLop.ID_lop_list <> "0" Then dk = dk & " AND ID_lop in (" & TreeViewLop.ID_lop_list & ")"
            'Load danh sách sinh viên
            clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines()
            Dim dt As DataTable = clsXet.Load_TotNghiep_DangKy_Load(dk)
            grcLuanVan.DataSource = dt.DefaultView

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class