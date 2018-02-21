Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_TongHop_SinhVienThiLai
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private clsDiem As Diem_Bussines
    Private mdtDanhSachSinhVien As New DataTable

#Region "Form Events"
    Private Sub frmESS_TongHopSinhVienThiLai_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.TreeViewLop.HienThi_ESSTreeView()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
    End Sub

    Private Sub frmESS_TongHopSinhVienThiLai_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TreeViewLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Not TreeViewLop.ID_lop_list Is Nothing Then
                dsID_lop = TreeViewLop.ID_lop_list
                dsID_dt = TreeViewLop.ID_dt_list
                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                Dim Trang_thai As Integer = cmbHienThi.SelectedIndex


                If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And cmbHienThi.Text <> "" And TreeViewLop.ID_chuyen_nganh > 0 And mdtDanhSachSinhVien.Rows.Count > 0 Then
                    'clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                    clsDiem = New Diem_Bussines(gobjUser.ID_dv, 0, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                    grcHocPhan.DataSource = clsDiem.TongHopDiemThiLai(cmbHienThi.SelectedIndex, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim).DefaultView
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbHienThi.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And cmbHienThi.Text <> "" And TreeViewLop.ID_chuyen_nganh > 0 And mdtDanhSachSinhVien.Rows.Count > 0 Then
                'clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, 0, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                grcHocPhan.DataSource = clsDiem.TongHopDiemThiLai(cmbHienThi.SelectedIndex, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text).DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


#End Region





    Private Sub cmdPrint2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView = grvHocPhan.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")
                dt.Columns.Add("ThiHoc_Lai")
                Dim ThiHoc_Lai As String = ""
                If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại"
                If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại"
                If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
                If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    dt.Rows(i).Item("Tieu_de") = TreeViewLop.Tieu_de.ToUpper
                    dt.Rows(i).Item("ThiHoc_Lai") = ThiHoc_Lai.ToUpper
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DanhSachThiHocLai_Mon", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de1")
                dt.Columns.Add("Tieu_de2")
                dt.Columns.Add("ThiHoc_Lai")
                Dim ThiHoc_Lai As String = ""
                If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại"
                If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại"
                If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
                If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                Dim dvMon As DataView = grvHocPhan.DataSource
                Dim Ten_mon As String = ""
                If dvMon.Count > 0 Then
                    'Ten_mon = dvMon.Item(0)("Ten_mon").ToString
                    Ten_mon = dvMon(grvHocPhan.FocusedRowHandle)("Ten_mon").ToString
                End If
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    dt.Rows(i).Item("Tieu_de1") = TreeViewLop.Tieu_de.ToUpper
                    If Ten_mon.Trim <> "" Then dt.Rows(i).Item("Tieu_de2") = "HỌC PHẦN: " & Ten_mon.ToUpper
                    dt.Rows(i).Item("ThiHoc_Lai") = ThiHoc_Lai.ToUpper
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("DanhSachThiHocLai", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdExport2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grvHocPhan)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdExport1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub


    Private Sub grvHocPhan_SelectionChanged(ByVal sender As Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvHocPhan.SelectionChanged
        Try

            Me.Cursor = Cursors.WaitCursor
            Try
                If grvHocPhan.FocusedRowHandle >= 0 Then
                    'clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                    clsDiem = New Diem_Bussines(gobjUser.ID_dv, 0, CType(cmbHoc_ky.Text.Trim, Integer), cmbNam_hoc.Text.Trim, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), mdtDanhSachSinhVien)
                    grcDanhSach.DataSource = clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(grvHocPhan.GetFocusedDataRow()("ID_mon"), grvHocPhan.GetFocusedDataRow()("Khong_tinh_TBCHT"), cmbHienThi.SelectedIndex, CType(cmbHoc_ky.Text, Integer), cmbNam_hoc.Text).DefaultView
                Else
                    grcDanhSach.DataSource = Nothing
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
            Me.Cursor = Cursors.Default
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DSHP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSHP.ItemClick

        Try
            Dim dv As DataView = grvHocPhan.DataSource
            Dim Tieu_de1 As String = ""
            Dim Tieu_de2 As String = ""
            Dim Tieu_de3 As String = ""
            Dim ThiHoc_Lai As String = ""
            If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại"
            If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại"
            If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
            If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"
            If grvDanhSach.RowCount > 0 Then
                Dim row As DataRow = grvHocPhan.GetFocusedDataRow()
                Tieu_de2 = TreeViewLop.Tieu_de.ToUpper
                Tieu_de3 = "HỌC PHẦN: " & row("Ten_mon").ToString.ToUpper
                Tieu_de1 = "DANH SÁCH HỌC PHẦN " & ThiHoc_Lai.ToUpper
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_DanhSachHocPhanThiLai", dv, Tieu_de1, Tieu_de2, Tieu_de3)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try


    End Sub

    Private Sub cmdPrint_DSSV_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSSV.ItemClick

        Try
            Dim dv1 As DataView = grvDanhSach.DataSource
            Dim Tieu_de1 As String = ""
            Dim Tieu_de2 As String = ""
            Dim Tieu_de3 As String = ""
            Dim ThiHoc_Lai As String = ""
            If cmbHienThi.SelectedIndex = 0 Then ThiHoc_Lai = "Thi lại"
            If cmbHienThi.SelectedIndex = 1 Then ThiHoc_Lai = "Học lại"
            If cmbHienThi.SelectedIndex = 2 Then ThiHoc_Lai = "Thiếu điểm thi"
            If cmbHienThi.SelectedIndex = 3 Then ThiHoc_Lai = "Thiếu điểm thành phần"
            If grvDanhSach.RowCount > 0 Then
                Dim row As DataRow = grvHocPhan.GetFocusedDataRow()
                Tieu_de2 = TreeViewLop.Tieu_de.ToUpper
                Tieu_de3 = "HỌC PHẦN: " & row("Ten_mon").ToString.ToUpper
                Tieu_de1 = "DANH SÁCH SINH VIÊN " & ThiHoc_Lai.ToUpper
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_DanhSachThiSinhThiLaiTheoMonHoc", dv1, Tieu_de1, Tieu_de2, Tieu_de3)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdExport_HP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExport_HP.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grvHocPhan)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdExport_SV_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdExport_SV.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_DSThi_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi.ItemClick
        Try
            Dim dv1 As DataView = grvDanhSach.DataSource
            Dim Tieu_de1 As String = ""
           
            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                Dim row As DataRow = grvHocPhan.GetFocusedDataRow()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Hoc_ky") = cmbHoc_ky.Text
                    dt.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
                    dt.Rows(i).Item("Ten_mon") = row("Ten_mon").ToString
                    dt.Rows(i).Item("So_hoc_trinh") = row("So_hoc_trinh")
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Viết"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next

                Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_Viet", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_DSThi2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi2.ItemClick
        Try
            Dim dv1 As DataView = grvDanhSach.DataSource
            Dim Tieu_de1 As String = ""

            If dv1.Count > 0 Then
                Dim dt As DataTable = dv1.Table.Copy
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ten_mon", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(String))
                dt.Columns.Add("Ten_phong", GetType(String))
                dt.Columns.Add("Ngay_thi", GetType(String))
                dt.Columns.Add("Ca_thi", GetType(String))
                dt.Columns.Add("Nhom_tiet", GetType(String))
                dt.Columns.Add("Gio_thi", GetType(String))
                dt.Columns.Add("Hinh_thuc_thi", GetType(String))
                dt.Columns.Add("So_sv")
                Dim row As DataRow = grvHocPhan.GetFocusedDataRow()
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Hoc_ky") = cmbHoc_ky.Text
                    dt.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
                    dt.Rows(i).Item("Ten_mon") = row("Ten_mon").ToString
                    dt.Rows(i).Item("So_hoc_trinh") = row("So_hoc_trinh")
                    dt.Rows(i).Item("Ten_phong") = ""
                    dt.Rows(i).Item("Ngay_thi") = ""
                    dt.Rows(i).Item("Ca_thi") = ""
                    dt.Rows(i).Item("Nhom_tiet") = ""
                    dt.Rows(i).Item("Gio_thi") = ""
                    dt.Rows(i).Item("Hinh_thuc_thi") = "Vấn đáp"
                    dt.Rows(i).Item("So_sv") = dt.Rows.Count
                Next

                Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_VanDap", dt.DefaultView, Tieu_de1)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub
End Class