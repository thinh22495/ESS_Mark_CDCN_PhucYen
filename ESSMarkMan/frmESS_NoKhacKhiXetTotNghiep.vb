Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_NoKhacKhiXetTotNghiep
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private mclsDSTT As NoKhacKhiXetTotNghiep_Bussines

#Region "Form Events"
    Private Sub frmESS_NoKhacKhiXetTotNghiep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TreeViewLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewNoKhacXetTotNghiep)
        SetQuyenTruyCap(, btnAdd, , btnDel)
    End Sub

    Private Sub frmESS_NoKhacKhiXetTotNghiep_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
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
        dvDanhSachSinhVien = grdViewNoKhacXetTotNghiep.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub

    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Not TreeViewLop.ID_lop_list Is Nothing Then
                dsID_lop = TreeViewLop.ID_lop_list

                mclsDSTT = New NoKhacKhiXetTotNghiep_Bussines(dsID_lop)
                Dim dt As DataTable = mclsDSTT.DanhSachNoKhacKhiXetTotNghiep()
                grdViewNoKhacXetTotNghiep.DataSource = dt.DefaultView

                Dim ID_svs As String = ""
                If dt.Rows.Count > 0 Then ID_svs = dt.Rows(0).Item("ID_svs").ToString

                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop, ID_svs)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Try
        '    Dim dv As DataView = grdViewNoKhacXetTotNghiep.DataSource
        '    If dv.Count > 0 Then
        '        dv.Table.Columns.Add("Tieu_de_ten_bo")
        '        dv.Table.Columns.Add("Tieu_de_Ten_truong")
        '        dv.Table.Columns.Add("Tieu_de")

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        '        dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
        '        dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong

        '        Dim Tieu_de As String = ""
        '        If trvLop.Tieu_de_Lop <> "" Then 'La Lop
        '            Tieu_de = trvLop.Tieu_de_Lop.ToUpper
        '        Else
        '            Tieu_de = trvLop.Tieu_de
        '        End If
        '        dv.Table.Rows(0).Item("Tieu_de") = Tieu_de

        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog_RFix("DS THOIHOC", dv.Table)
        '    End If
        'Catch ex As Exception
        'End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If txtLy_do.Text.Trim = "" Then
                Thongbao("Bạn phải nhập Lý do cho sinh viên !", MsgBoxStyle.Information)
            Else
                If grdViewDanhSach.CurrentRow Is Nothing Then Exit Sub
                Dim dv As DataView = grdViewDanhSach.DataSource
                Dim dv2 As DataView = grdViewNoKhacXetTotNghiep.DataSource
                For i As Integer = dv.Count - 1 To 0 Step -1
                    If dv.Item(i)("Chon") Then
                        Dim objDSTT As New ESSNoKhacKhiXetTotNghiep
                        objDSTT.Ngay_sinh = dv.Item(i).Item("Ngay_sinh")
                        objDSTT.Ly_do = txtLy_do.Text.Trim
                        objDSTT.ID_sv = dv.Item(i).Item("ID_SV")
                        objDSTT.Ma_sv = dv.Item(i).Item("Ma_sv").ToString
                        objDSTT.Ho_ten = dv.Item(i).Item("Ho_ten").ToString
                        objDSTT.Ten_lop = dv.Item(i).Item("Ten_lop").ToString

                        mclsDSTT.ThemMoi_ESSNoKhacKhiXetTotNghiep(objDSTT)
                        mclsDSTT.Add(objDSTT)
                        grdViewNoKhacXetTotNghiep.DataSource = mclsDSTT.DanhSachNoKhacKhiXetTotNghiep.DefaultView
                        dv.Item(i).Row.Delete()
                    End If
                Next
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv As DataView = grdViewNoKhacXetTotNghiep.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") Then
                    'Day lai danh sach sinh vien
                    Dim dr As DataRow
                    dr = mdtDanhSachSinhVien.NewRow
                    dr.Item("ID_SV") = dv.Item(i).Item("ID_sv")
                    dr.Item("Ma_sv") = dv.Item(i).Item("Ma_sv")
                    dr.Item("Ho_ten") = dv.Item(i).Item("Ho_ten")
                    dr.Item("Ngay_sinh") = dv.Item(i).Item("Ngay_sinh")
                    dr.Item("Ten_lop") = dv.Item(i).Item("Ten_lop")
                    dr.Item("Chon") = False
                    mdtDanhSachSinhVien.Rows.Add(dr)

                    'Xoa ban ghi khoi CSDL va bo nhớ
                    mclsDSTT.Xoa_ESSNoKhacKhiXetTotNghiep(dv.Item(i).Item("ID_sv"))
                    Dim idx As Integer = mclsDSTT.Tim_idx(dv.Item(i).Item("ID_sv"))
                    If idx >= 0 Then
                        mclsDSTT.Remove(idx)
                    End If
                End If
            Next
            grdViewNoKhacXetTotNghiep.DataSource = mclsDSTT.DanhSachNoKhacKhiXetTotNghiep.DefaultView
            grdViewDanhSach.DataSource = mdtDanhSachSinhVien.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewNoKhacXetTotNghiep.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDataGridViewToExcel(grdViewNoKhacXetTotNghiep)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class