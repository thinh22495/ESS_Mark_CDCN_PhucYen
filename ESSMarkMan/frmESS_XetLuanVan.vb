Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XetLuanVan
    Dim dt_ds_lv, dt_ds_thi As DataTable
    Dim clsXet As DanhSachLuanVanThiNoTotNghiep_Bussines
    Private mID_dt As Integer = 0

#Region "Form Events"
    Private Sub frmESS_XetLuanVan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TreeViewLop.HienThi_ESSTreeView()
        Me.TreeViewLop1.HienThi_ESSTreeView()
        Me.TreeViewLop2.HienThi_ESSTreeView()

        SetQuyenTruyCap(, cmdXetLV, cmdChuyenLamLV, cmdChuyenThi)
    End Sub

    Private Sub frmESS_XetLuanVan_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TreeViewLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Not TreeViewLop.ID_lop_list Is Nothing Then
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(TreeViewLop.ID_lop_list)
                dt_ds_lv = objDanhSach.Danh_sach_sinh_vien

                'Load danh sach sinh thuoc dien da xet lam luan van
                If TreeViewLop.ID_chuyen_nganh > 0 Then mID_dt = TreeViewLop.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, TreeViewLop.ID_lop_list, mID_dt, dt_ds_lv)
                Dim dt As DataTable = clsXet.HienThi_ESSDanhSach_LuanVan
                grcLuanVan.DataSource = dt.DefaultView
                labSo_sv.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TreeViewLop1_Select() Handles TreeViewLop1.TreeNodeSelected_
        Try
            If Not TreeViewLop1.ID_lop_list Is Nothing Then
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(TreeViewLop1.ID_lop_list)
                dt_ds_thi = objDanhSach.Danh_sach_sinh_vien

                ' Load danh sach sinh thuoc dien da xet thi TN
                If TreeViewLop1.ID_chuyen_nganh > 0 Then mID_dt = TreeViewLop1.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, TreeViewLop1.ID_lop_list, mID_dt, dt_ds_thi)
                Dim dt As DataTable = clsXet.HienThi_ESSDanhSach_ThiTotNghiep
                grcThiTotNghiep.DataSource = dt.DefaultView
                lblSV_Thi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TreeViewLop2_Select() Handles TreeViewLop2.TreeNodeSelected_
        Try
            If Not TreeViewLop2.ID_lop_list Is Nothing Then
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(TreeViewLop2.ID_lop_list)
                Dim mdtSinhVien_NoTN As DataTable = objDanhSach.Danh_sach_sinh_vien

                'Load danh sach sinh thuoc dien no tot nghiep
                If TreeViewLop2.ID_chuyen_nganh > 0 Then mID_dt = TreeViewLop2.ID_dt_list
                clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, TreeViewLop2.ID_lop_list, mID_dt, mdtSinhVien_NoTN)
                Dim dt As DataTable = clsXet.HienThi_ESSDanhSach_NoTotNghiep
                grcNoTotNghiep.DataSource = dt.DefaultView
                lblNoThi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub txtTBCHT_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTBCHT.KeyPress
        ErrorProvider1.Dispose()
        e.Handled = HandleNumberKey(e.KeyChar, ".")
    End Sub
#End Region

#Region "Functions And Subs"


#End Region


    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        Select Case sender.SelectedIndex.ToString
            Case 0
                cmdDuyet.Visible = True
                cmdChuyenThi.Visible = True
                cmdChuyenLamLV.Visible = False
                cmdXetLV.Visible = True
                cmdXet_BoSung.Visible = False
            Case 1
                cmdDuyet.Visible = False
                cmdChuyenThi.Visible = False
                cmdChuyenLamLV.Visible = True
                cmdXetLV.Visible = False
                cmdXet_BoSung.Visible = True
        End Select
    End Sub




    Private Sub cmdPrint_DS_luanvan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_luanvan.ItemClick
        Try
            Dim dv As DataView = grcLuanVan.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dt.Rows(0).Item("Tieu_de") = TreeViewLop.Tieu_de

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DS LuanVan", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DS_totnghiep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_totnghiep.ItemClick
        Try
            Dim dv As DataView = grcThiTotNghiep.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dt.Rows(0).Item("Tieu_de") = TreeViewLop.Tieu_de

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DS ThiTotNghiep", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DS_nototnghiep_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DS_nototnghiep.ItemClick
        Try
            Dim dv As DataView = grcNoTotNghiep.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                dt.Rows(0).Item("Tieu_de") = TreeViewLop.Tieu_de

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DS NoTotNghiep", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdXetLV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXetLV.Click
        Try
            If txtTBCHT.Text.Trim = "" And txtSo_tin_chi.Text.Trim = "" Then
                Thongbao("Hãy nhập điểm tích luỹ cần xét !", MsgBoxStyle.Information)
                Call SetErrPro(txtTBCHT, ErrorProvider1, "Nhập điểm tích luỹ cần xét !")
                txtTBCHT.Focus()
            ElseIf IsNumeric(txtTBCHT.Text.Trim) Then
                If TreeViewLop.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If
                Dim dt_luanvan, dt_Thi, dt_NoThi As DataTable
                clsXet.XetLuanVan(txtTBCHT.Text.Trim, txtSo_tin_chi.Text.Trim, dt_luanvan, dt_Thi, dt_NoThi)
                'grdViewLuanVan.DataSource = dt_luanvan.DefaultView
                grcLuanVan.DataSource = dt_luanvan.DefaultView
                labSo_sv.Text = dt_luanvan.DefaultView.Count

                grcThiTotNghiep.DataSource = dt_Thi.DefaultView
                lblSV_Thi.Text = dt_Thi.Rows.Count
                grcNoTotNghiep.DataSource = dt_NoThi.DefaultView
                lblNoThi.Text = dt_NoThi.Rows.Count
            End If
            labSo_sv.Text = grcLuanVan.DataSource.Count
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cmdChuyenLamLV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChuyenLamLV.Click
        Try
            'Xoá danh sách Thi tốt nghiệp rồi Insert vào danh sách luận văn
            Dim dv As DataView = grcThiTotNghiep.DataSource
            If dv.Count > 0 Then
                clsXet.ChuyenLamLuanVan(dv)
                'Load danh sach sinh thuoc dien da xet thi TN
                clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, TreeViewLop1.ID_lop_list, 0, dt_ds_thi)
                Dim dt As DataTable = clsXet.HienThi_ESSDanhSach_ThiTotNghiep
                grcThiTotNghiep.DataSource = dt.DefaultView
                lblSV_Thi.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdChuyenThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChuyenThi.Click
        Try
            'Xoá danh sách luận văn rồi Insert vào danh sách Thi tốt nghiệp
            Dim dv As DataView = grcLuanVan.DataSource
            If dv.Count > 0 Then
                clsXet.ChuyenThiTotNghiep(dv)
                'Load danh sach sinh thuoc dien da xet lam luan van
                clsXet = New DanhSachLuanVanThiNoTotNghiep_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, TreeViewLop.ID_lop_list, 0, dt_ds_lv)
                Dim dt As DataTable = clsXet.HienThi_ESSDanhSach_LuanVan
                grcLuanVan.DataSource = dt.DefaultView
                labSo_sv.Text = dt.DefaultView.Count
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Select Case TabControl1.SelectedIndex.ToString
                Case 0
                    If Not grcLuanVan.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvLanVan)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 1
                    If Not grcThiTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvThiTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
                Case 2
                    If Not grvThiTotNghiep.DataSource Is Nothing Then
                        Dim clsExcel As New ExportCommon
                        Dim Tieu_de As String = ""
                        clsExcel.ExportFromDevGridViewToExcel(grvNoTotNghiep)
                    Else
                        Thongbao("Chưa có dữ liệu !")
                    End If
            End Select
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdDuyet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDuyet.Click
        Dim cls As New DanhSachLuanVanThiNoTotNghiep_Bussines()
        Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
        Dim dv As DataView
        Select Case TabControl1.SelectedIndex
            Case 0
                dv = grcLuanVan.DataSource
                For i As Integer = 0 To dv.Count - 1
                    obj.ID_sv = dv.Item(i)("ID_SV")
                    obj.CoVan_duyet = dv.Item(i)("CoVan_duyet")
                    obj.SinhVien_duyet = dv.Item(i)("SinhVien_duyet")
                    cls.CapNhat_ESSDanhSachLuanVan_SangThi(obj)
                Next
                'Case 1
                '    dv = grcThiTotNghiep.DataSource
                '    For i As Integer = 0 To dv.Count - 1
                '        obj.ID_sv = dv.Item(i)("ID_SV")
                '        obj.CoVan_duyet = dv.Item(i)("CoVan_duyet")
                '        obj.SinhVien_duyet = dv.Item(i)("SinhVien_duyet")
                '        cls.CapNhat_ESSDanhSachThiTotNghiep(obj)
                '    Next
        End Select
    End Sub

    Private Sub cmdXet_BoSung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXet_BoSung.Click
        Try
            If txtSo_tin_chi.Text.Trim = "" Then
                Thongbao("Hãy nhập điểm tích luỹ cần xét !", MsgBoxStyle.Information)
                Call SetErrPro(txtSo_tin_chi, ErrorProvider1, "Hãy nhập điểm tích luỹ cần xét !")
                txtSo_tin_chi.Focus()
            ElseIf IsNumeric(txtSo_tin_chi.Text.Trim) Then
                If TreeViewLop.ID_chuyen_nganh <= 0 Then
                    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                    Exit Sub
                End If
                Dim dt_Thi, dt_NoThi As DataTable
                Dim dv_luanvan As DataView
                dv_luanvan = grvLanVan.DataSource
                clsXet.XetThiTotNghiep_BoSung(txtSo_tin_chi.Text.Trim, dv_luanvan.Table, dt_Thi, dt_NoThi)

                grcThiTotNghiep.DataSource = dt_Thi.DefaultView
                lblSV_Thi.Text = dt_Thi.Rows.Count
                grcNoTotNghiep.DataSource = dt_NoThi.DefaultView
                lblNoThi.Text = dt_NoThi.Rows.Count
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class