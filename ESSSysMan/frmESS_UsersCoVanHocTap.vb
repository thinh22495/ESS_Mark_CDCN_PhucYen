Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_UsersCoVanHocTap
    Private mUserName As String = ""
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private mcls As CoVanHocTap_Bussines

#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal UserName As String, ByVal FullName As String)
        lblCoVan.Text = "Cố vấn học tập: " & FullName
        mUserName = UserName
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_CoVan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính 
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewChonDanhSach)
    End Sub

    Private Sub frmESS_CoVan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"
    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll1.Checked
            Next
        End If
    End Sub
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewChonDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub

    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        Try
            If Not trvLop.ID_lop_list Is Nothing Then
                dsID_lop = trvLop.ID_lop_list

                'Danh sách sinh viên thực tập
                mcls = New CoVanHocTap_Bussines(mUserName)
                Dim dt As DataTable = mcls.DanhSachSVCoVanHocTap()
                grdViewChonDanhSach.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.Rows.Count

                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien(dt)
                grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If grdViewDanhSach.CurrentRow Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDanhSach.DataSource
            Dim dv2 As DataView = grdViewChonDanhSach.DataSource
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") Then
                    Dim objDSTT As New ESSCoVanHocTap
                    If dv.Item(i).Item("Ngay_sinh").ToString <> "" Then
                        objDSTT.Ngay_sinh = CDate(dv.Item(i).Item("Ngay_sinh").ToString)
                    End If
                    objDSTT.UserName = mUserName
                    objDSTT.ID_sv = dv.Item(i).Item("ID_SV")
                    objDSTT.Ma_sv = dv.Item(i).Item("Ma_sv").ToString
                    objDSTT.Ho_ten = dv.Item(i).Item("Ho_ten").ToString
                    objDSTT.Ten_lop = dv.Item(i).Item("Ten_lop").ToString

                    mcls.ThemMoi_ESSCoVanHocTap(objDSTT)
                    mcls.Add(objDSTT)
                    grdViewChonDanhSach.DataSource = mcls.DanhSachSVCoVanHocTap().DefaultView
                    dv.Item(i).Row.Delete()
                End If
            Next
            lblSo_sv.Text = grdViewChonDanhSach.DataSource.count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv As DataView = grdViewChonDanhSach.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") Then
                    'Day lai danh sach sinh vien
                    Dim dr As DataRow
                    dr = mdtDanhSachSinhVien.NewRow
                    dr.ItemArray = dv.Item(i).Row.ItemArray
                    dr.Item("Chon") = False
                    mdtDanhSachSinhVien.Rows.Add(dr)

                    'Xoa ban ghi khoi CSDL va bo nhớ
                    mcls.Xoa_ESSCoVanHocTap(dv.Item(i).Item("Ma_sv"), mUserName)
                    Dim idx As Integer = mcls.Tim_idx(dv.Item(i).Item("ID_sv"))
                    If idx >= 0 Then
                        mcls.Remove(idx)
                    End If
                End If
            Next
            grdViewChonDanhSach.DataSource = mcls.DanhSachSVCoVanHocTap().DefaultView
            grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
            lblSo_sv.Text = grdViewChonDanhSach.DataSource.count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewChonDanhSach.DataSource Is Nothing Then
                Dim dv As DataView = grdViewChonDanhSach.DataSource

            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
#End Region
End Class