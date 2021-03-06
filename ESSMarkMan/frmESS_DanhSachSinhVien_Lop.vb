Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESSUtility
Imports ESSReports

Public Class frmESS_DanhSachSinhVien_Lop


#Region "Form Event"
    Private Sub frmESS_DanhSachLop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.trvLop.HienThi_ESSTreeView()
    End Sub
    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        If Not trvLop.ID_lop_list Is Nothing Then
            Dim Nam, Nu As Integer
            Dim ID_lops As String = trvLop.ID_lop_list
            Dim objDanhSach As New DanhSachSinhVien_Bussines(ID_lops)
            Dim dv As DataView = objDanhSach.Danh_sach_sinh_vien.DefaultView

            Nam = objDanhSach.So_sv_nam
            Nu = objDanhSach.So_sv_nu
            grcDanhSach.DataSource = dv
            txtSo_sv.Text = Nam + Nu
            txtNam.Text = Nam
            txtNu.Text = Nu
        End If
    End Sub
    Private Sub frmESS_DanhSachLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Button"
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        Try
            ' Danh sach ID_sv
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Table.Rows.Count = 0 Then Exit Sub
            Dim arrID_sv As New ArrayList
            For i As Integer = 0 To dv.Count - 1
                arrID_sv.Add(dv.Item(i).Item("ID_sv"))
            Next
            Dim idx As Integer = grvDanhSach.GetSelectedRows.GetValue(0)
            Dim ID_lops As String = trvLop.ID_lop_list
            Dim frmESS_ As New frmESS_HoSoSinhVien(arrID_sv, idx, ID_lops)
            frmESS_.MdiParent = frmESS_Main
            frmESS_.StartPosition = FormStartPosition.CenterScreen
            frmESS_.Show()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim dv As DataView = grvDanhSach.DataSource
        If dv.Table.Rows.Count <= 0 Then Exit Sub
        Dim Khoa_hoc As Integer = 0
        Khoa_hoc = trvLop.Khoa_hoc

        Dim ID_he As Integer = 0
        Dim ID_sv As String = ""
        ID_he = trvLop.ID_he
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                ID_sv += dv.Item(i)("ID_sv").ToString & ","
            End If
        Next

        If ID_sv.Length > 0 Then
            ID_sv = ID_sv.Substring(0, ID_sv.Length - 1)
            Dim frmESS_ As New frmESS_ChuyenLop(Khoa_hoc, ID_sv, ID_he)
            frmESS_.ShowDialog()
            trvLop_Select()
        Else
            Thongbao("Bạn hãy chọn sinh viên chuyển lớp !")
        End If
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

            If grvDanhSach.GetSelectedRows.Length = 0 Then Exit Sub
            Dim dvChon As DataView = grvDanhSach.DataSource

            Dim ID_lops As String = trvLop.ID_lop_list
            Dim clsDanhSach As New DanhSach_Bussines(ID_lops)
            Dim dsMasv As String = ""

            Dim iMessaged As Boolean = False
            For i As Integer = 0 To dvChon.Count - 1
                If dvChon.Item(i)("Chon") Then
                    If iMessaged = False AndAlso Thongbao("Bạn có muốn xóa danh sách sinh viên được chọn khỏi lớp không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        iMessaged = True
                    ElseIf iMessaged = False Then
                        Exit Sub
                    End If
                    If clsDanhSach.KiemTra_TruocKhiXoa_SV(dvChon.Item(i)("ID_sv")) = False Then
                        clsDanhSach.Xoa_ESSDanhSach(dvChon.Item(i)("ID_sv"), dvChon.Item(i)("ID_lop"))
                        dsMasv += ", " & dvChon.Item(i)("Ma_sv").ToString
                    End If
                End If
            Next

            If dsMasv.Length > 0 Then
                Dim objDanhSach As New DanhSachSinhVien_Bussines(ID_lops)
                Dim dv As DataView = objDanhSach.Danh_sach_sinh_vien.DefaultView
                Dim Ten_lop As String = ""
                Dim Nam, Nu As Integer
                Nam = objDanhSach.So_sv_nam
                Nu = objDanhSach.So_sv_nu
                grcDanhSach.DataSource = dv
                txtSo_sv.Text = Nam + Nu
                txtNam.Text = Nam
                txtNu.Text = Nu
                Thongbao("Bạn đã xóa thành công danh sách khỏi lớp !")
                ' Ghi log
                Dim Noi_dung As String = ""
                Noi_dung = "Xóa danh sách sinh viên có mã: " & dsMasv
                SaveLog(LoaiSuKien.Xoa, Noi_dung)
            Else
                Thongbao("Bạn hãy chọn danh sách sinh viên cần xóa khỏi lớp !")
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrint_DanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As New DataView
            dv = grvDanhSach.DataSource
            If dv.Count = 0 Then Exit Sub
            dv.Sort = "SBD_order"
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog("RpDanhSachSinhVien2", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_TongDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As New DataView
            dv = grvDanhSach.DataSource
            If dv.Count = 0 Then Exit Sub
            dv.Sort = "SBD_order"
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog("RpDanhSachSinhVien1", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdPrint_DSThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim dv As New DataView
            dv = grvDanhSach.DataSource
            If dv.Count = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor

            Dim dt As DataTable = dv.Table.Copy
            dt.Columns.Add("Tieu_de_Ten_truong")
            Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
            If objBaoCaoTieuDe.Count > 0 Then
                dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            Else
                dt.Rows(0).Item("Tieu_de_Ten_truong") = ""
            End If
            'dt.Rows(0).Item("Tieu_de") = "SINH VIÊN: " & Ho_ten.ToUpper
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog_RFix("RpDanhSachSinhVien_HocTap", dt)

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region



    Private Sub cmdPrint_DSPL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            'Dim dv As New DataView
            'dv = grvDanhSach.DataSource
            'dv.Sort = "SBD"
            'If dv.Count = 0 Then Exit Sub
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable
            Dim str As String = "select hs.SBD,hs.ID_sv,hs.Ma_sv,hs.Ho_ten,hs.Ngay_sinh,gt.Gioi_tinh,h.Ten_huyen + ' ' + t.Ten_tinh as Dia_chi_tt from STU_HoSoSinhVien hs  " & _
                                "inner join STU_DanhSach ds On hs.ID_sv=ds.ID_sv " & _
                                "inner join STU_Lop l on ds.ID_lop=l.ID_lop " & _
                                "left join STU_GioiTinh gt on hs.ID_gioi_tinh=gt.ID_gioi_tinh " & _
                                "left join STU_Tinh t On hs.ID_tinh_tt=t.ID_tinh " & _
                                "left join STU_Huyen h on hs.ID_huyen_tt=h.ID_huyen " & _
                                "where l.ID_lop in (" & trvLop.ID_lop_list & ") Order by hs.SBD ASC"
            dt = cls.LoadDanhMuc(str)
            dt.Columns.Add("SBD_order", GetType(String))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("SBD_order") = IIf(dt.Rows(i)("SBD").ToString.Length = 1, "0000" & dt.Rows(i)("SBD").ToString, IIf(dt.Rows(i)("SBD").ToString.Length = 2, "000" & dt.Rows(i)("SBD").ToString, IIf(dt.Rows(i)("SBD").ToString.Length = 3, "00" & dt.Rows(i)("SBD").ToString, IIf(dt.Rows(i)("SBD").ToString.Length = 4, "0" & dt.Rows(i)("SBD").ToString, dt.Rows(i)("SBD").ToString))))
            Next
            Dim dv As DataView = dt.DefaultView
            dv.Sort = "SBD_order"
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Tieu_de2 = trvLop.Tieu_de
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog("RpDanhSachSinhVien2", dv.Table, , Tieu_de2, , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub


    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            If grvDanhSach.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDevGridViewToExcel(grvDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub cmdPrint_DanhSach1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DanhSach1.ItemClick
        Try
            Dim dv As New DataView
            dv = grvDanhSach.DataSource
            If dv.Count = 0 Then Exit Sub
            dv.Sort = "Ma_sv"
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de1 As String = ""
            Dim Tieu_de2 As String = ""
            Dim Tieu_de3 As String = ""
            Dim Tieu_de4 As String = ""
            Dim Tieu_de5 As String = ""
            Dim Tieu_de6 As String = ""
            Dim Tieu_de7 As String = ""

            Tieu_de1 = "DANH SÁCH BIÊN CHẾ LỚP SINH VIÊN"
            If trvLop.Ten_lop <> "" Then
                Tieu_de2 = "Lớp: " & trvLop.Ten_lop.ToUpper
                If Today.Month >= 9 Or Today.Month <= 1 Then
                    Tieu_de4 = "Học kỳ: 1"
                    Tieu_de5 = "Năm học: " & Today.Year.ToString & "-" & (Today.Year + 1).ToString
                Else
                    Tieu_de4 = "Học kỳ: 2"
                    Tieu_de5 = "Năm học: " & (Today.Year - 1).ToString & "-" & Today.Year.ToString
                End If
            End If
            If trvLop.Nien_khoa <> "" Then
                Tieu_de3 = "Khóa học: " & trvLop.Nien_khoa
            End If
            If trvLop.Ten_he <> "" Then
                Tieu_de6 = "Hệ đào tạo: " & trvLop.Ten_he
            End If


            Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptSTU_DanhSachSinhVien_LopHC", dv, Tieu_de1, Tieu_de2, Tieu_de3, Tieu_de4, Tieu_de5, Tieu_de6, Tieu_de7)
            frmESS_.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_DonXacNhan_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DonXacNhan.ItemClick
        Try
            Dim Tieu_de1 As String = "ĐƠN XIN XÁC NHẬN"
            Dim Tieu_de2 As String = ""

            If Date.Now.Month > 6 Then
                Tieu_de2 += " 30/06/" + (Date.Now.Year + 1).ToString
            Else
                Tieu_de2 += " 30/06/" + (Date.Now.Year).ToString
            End If

            If grvDanhSach.DataSource Is Nothing Then Exit Sub
            Dim objHoSo_Bussines As New HoSo_Bussines
            Me.Cursor = Cursors.WaitCursor
            Dim dt As DataTable
            dt = objHoSo_Bussines.HienThi_ESSHoSo_Report_Load(CInt(grvDanhSach.GetDataRow(grvDanhSach.GetSelectedRows.GetValue(0))("ID_sv")))

            If dt.Rows.Count > 0 Then
                dt.Columns.Add("Den_ngay", GetType(String))
                dt.Rows(0).Item("Den_ngay") = Tieu_de2
                Dim frm As New frmESS_ReportView(gobjUser, "rptSTU_DonXinXacNhan", dt.DefaultView, Tieu_de1)
                frm.ShowDialog()
            End If

            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_GiayXacNhan_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_GiayXacNhan.ItemClick
        Try
            If grvDanhSach.DataSource Is Nothing Then Exit Sub
            Dim objHoSo_Bussines As New HoSo_Bussines
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de1 As String = "GIẤY XÁC NHẬN"
            Dim dt As DataTable
            dt = objHoSo_Bussines.HienThi_ESSHoSo_Report_Load(CInt(grvDanhSach.GetDataRow(grvDanhSach.GetSelectedRows.GetValue(0))("ID_sv")))
            Dim frm As New frmESS_ReportView(gobjUser, "rptSTU_GiayXacNhan", dt.DefaultView, Tieu_de1)
            frm.ShowDialog()
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_DonMienGiamHP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DonMienGiamHP.ItemClick
        Try
            If grvDanhSach.DataSource Is Nothing Then Exit Sub
            Dim objHoSo_Bussines As New HoSo_Bussines
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Dim frm As New frmESS_XemBaoCao
            Dim dt As DataTable
            dt = objHoSo_Bussines.HienThi_ESSHoSo_Report_Load(CInt(grvDanhSach.GetDataRow(grvDanhSach.GetSelectedRows.GetValue(0))("ID_sv")))
            frm.ShowDialog_New("rpDonXinMienGiamHP", dt)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_PhieuXacNhan_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_PhieuXacNhan.ItemClick
        Try
            If grvDanhSach.DataSource Is Nothing Then Exit Sub
            Dim objHoSo_Bussines As New HoSo_Bussines
            Me.Cursor = Cursors.WaitCursor
            Dim Tieu_de2 As String = ""
            Dim frm As New frmESS_XemBaoCao
            Dim dt As DataTable
            dt = objHoSo_Bussines.HienThi_ESSHoSo_Report_Load(CInt(grvDanhSach.GetDataRow(grvDanhSach.GetSelectedRows.GetValue(0))("ID_sv")))
            frm.ShowDialog_New("rpPhieuXacNhan", dt)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class