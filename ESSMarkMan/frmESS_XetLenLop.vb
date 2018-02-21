Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XetLenLop
    Private mdtDanhSachSinhVien As New DataTable
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mID_chuyen_nganh As Integer = 0
    Private clsDSXetLenLop As DanhSachXetLenLop_Bussines

#Region "Form Events"
    Private Sub frmESS_XetLenLop_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()

        Add_Namhoc(cmbNam_hoc)
        SetQuyenTruyCap(, cmdZ, cmdAddQD, )
    End Sub

    Private Sub frmESS_XetLenLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        Try
            mID_he = trvLop.ID_he
            mKhoa_hoc = trvLop.Khoa_hoc
            mID_chuyen_nganh = trvLop.ID_chuyen_nganh
            If Not trvLop.ID_lop_list Is Nothing Then
                Dim dk As String = "WHERE 1=1"
                If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
                If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
                If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
                If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

                'Load danh sách sinh viên
                Dim objDanhSach As New DanhSachSinhVien_Bussines("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk)
                mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_DangHoc
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub FillLoai_QD(ByVal cmb As ComboBox)
        Dim dt As New DataTable
        dt.Columns.Add("Loai_QD", GetType(Integer))
        dt.Columns.Add("Ten_loai", GetType(String))

        Dim dr As DataRow
        dr = dt.NewRow
        dr.Item("Loai_QD") = 1
        dr.Item("Ten_loai") = "Ngừng học"
        dt.Rows.Add(dr)
        dr = dt.NewRow
        dr.Item("Loai_QD") = 2
        dr.Item("Ten_loai") = "Thôi học-Xóa tên"
        dt.Rows.Add(dr)

        FillCombo(cmb, dt)
    End Sub


    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grvDanhSach.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDevGridViewToExcel(GridView1)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub


    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdAddQD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddQD.Click
        Try
            'If trvLop.ID_chuyen_nganh <= 0 Then
            '    Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
            '    Exit Sub
            'End If
            Dim dv As DataView = grcDanhSach_DaChon.DataSource
            If Not dv Is Nothing Then
                Dim dk As String = "WHERE 1=1"
                If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
                If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
                If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
                If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

                Dim dt As DataTable = clsDSXetLenLop.Danh_sach_sinh_vien_chon(dv)
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.ShowDialog(dt, mdtDanhSachSinhVien)
                mID_dt = trvLop.ID_dt_list
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, 0, 0, 0, 0, "", mID_dt, mdtDanhSachSinhVien)
                grcDanhSach.DataSource = clsDSXetLenLop.XetLenLop(cmbHoc_ky.Text, cmbNam_hoc.Text, gobjUser.ID_Bomon).DefaultView
                labSo_sv.Text = grvDanhSach.RowCount
            Else
                Dim frmESS_ As New frmESS_QuyetDinhThoiHoc
                FillLoai_QD(frmESS_.cmbLoai_qd)
                frmESS_.ShowDialog(Nothing, mdtDanhSachSinhVien)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdZ_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdZ.Click
        Try
            If trvLop.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến chuyên ngành đào tạo !")
                Exit Sub
            End If
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                Dim dk As String = "WHERE 1=1"
                If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
                If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
                If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
                If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop
              
                mID_dt = trvLop.ID_dt_list
                Dim ID_SVs As String = ""
                clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
                ID_SVs = clsDSXetLenLop.strID_SV(cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, dk)
                If cmbLan_thu.Text = 1 Then
                    Dim objDanhSach As New DanhSachSinhVien_Bussines("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, ID_SVs)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                Else
                    mdtDanhSachSinhVien = clsDSXetLenLop.Load_DanhSachSinhVien_ID_SVs_HenThi_DanhSAch("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, ID_SVs)
                End If

                clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, "SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, 0, 0, 0, CType(cmbHoc_ky.Text, Integer), cmbNam_hoc.Text, mID_dt, mdtDanhSachSinhVien)
                Dim dv_chuaxet As DataView
                dv_chuaxet = clsDSXetLenLop.XetLenLop(cmbHoc_ky.Text, cmbNam_hoc.Text, gobjUser.ID_Bomon, cmbLan_thu.Text).DefaultView

                'Xoa danh sach da xet nhung chua duyet cua lan truoc
                'Them moi cac sinh vien thuoc dien thoi, ngung hoc
                'clsDSXetLenLop.Delete_XetLenLop_KhiTongHop(cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text)
                clsDSXetLenLop.Delete_XetLenLop_KhiTongHop_TheoSinhVien(cmbHoc_ky.Text, cmbNam_hoc.Text, "SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, cmbLan_thu.Text)
                For i As Integer = 0 To dv_chuaxet.Count - 1
                    clsDSXetLenLop.Insert_XetLenLop_KhiTongHop(dv_chuaxet.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, dv_chuaxet.Item(i)("Ly_do"), dv_chuaxet.Item(i)("So_TCTL"), dv_chuaxet.Item(i)("TBCTL"), dv_chuaxet.Item(i)("So_TCHT"), dv_chuaxet.Item(i)("TBCHT_Ky"), 0)
                Next

                grcDanhSach.DataSource = dv_chuaxet
                labSo_sv.Text = grcDanhSach.DataSource.Count
                Thongbao("Danh sách sinh viên thuộc diện thôi học !", MsgBoxStyle.Information)
                grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 1).DefaultView
            Else
                Thongbao("Chọn học kỳ và năm học và lần cảnh báo trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint1_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint1.ItemClick
        Try
            Dim dv As New DataView
            dv = grvDanhSach.DataSource
            If dv.Count > 0 Then
                dv.Table.Columns.Add("Tieu_de_ten_bo")
                dv.Table.Columns.Add("Tieu_de_Ten_truong")
                dv.Table.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                If objBaoCaoTieuDe.Count > 0 Then
                    dv.Table.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                Else
                    dv.Table.Rows(0).Item("Tieu_de_ten_bo") = ""
                    dv.Table.Rows(0).Item("Tieu_de_Ten_truong") = ""
                End If


                Dim Tieu_de As String = ""
                If trvLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de = trvLop.Tieu_de_Lop.ToUpper
                Else
                    Tieu_de = trvLop.Tieu_de
                End If
                For i As Integer = 0 To dv.Table.Rows.Count - 1
                    dv.Table.Rows(i).Item("Tieu_de") = Tieu_de
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("DS THOIHOC", dv.Table)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint2.ItemClick
        Try
            Dim ID_dts As String = ""
            Dim ID_lops As String = ""

            If trvLop.ID_chuyen_nganh <= 0 Then
                Thongbao("Bạn phải chọn đến ngành đào tạo!")
                Exit Sub
            End If
            trvLop.Get_ID_lops(trvLop.trvLop.SelectedNode, ID_lops, ID_dts)
            If ID_dts.Length > 0 Then ID_dts = Mid(ID_dts, 1, Len(ID_dts) - 1)
            If ID_lops.Length > 0 Then ID_lops = Mid(ID_lops, 1, Len(ID_lops) - 1)

            Dim objdsLop As New Lop_Bussines(ID_lops, 0, 1, -1)
            Dim mdtLop As DataTable = objdsLop.Lop()
            mdtLop.Columns.Add("So_sv")
            mdtLop.Columns.Add("So_sv_len_lop")
            mdtLop.Columns.Add("So_sv_thoi_hoc")
            'Load danh sách sinh viên
            Dim objDanhSach As New DanhSachSinhVien_Bussines(ID_lops)
            mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
            Dim dv As DataView
            If cmbNam_hoc.Text.Trim <> "" And cmbHoc_ky.Text.Trim <> "" Then
                If mdtDanhSachSinhVien.Rows.Count > 0 Then
                    clsDSXetLenLop = New DanhSachXetLenLop_Bussines(gobjUser.ID_dv, ID_lops, 0, 0, 0, 0, "", ID_dts, mdtDanhSachSinhVien)
                    dv = clsDSXetLenLop.XetLenLop_TongHop(cmbHoc_ky.Text, cmbNam_hoc.Text, 0).DefaultView
                    Dim iCount As Integer = 0
                    For i As Integer = 0 To mdtLop.Rows.Count - 1
                        dv.RowFilter = "Ly_do<>'' AND ID_lop=" + mdtLop.Rows(i).Item("ID_lop").ToString
                        iCount = dv.Count
                        mdtLop.Rows(i).Item("So_sv") = objDanhSach.Danh_sach_sinh_vien(mdtLop.Rows(i).Item("ID_lop").ToString).Rows.Count
                        mdtLop.Rows(i).Item("So_sv_len_lop") = objDanhSach.Danh_sach_sinh_vien(mdtLop.Rows(i).Item("ID_lop").ToString).Rows.Count - iCount
                        mdtLop.Rows(i).Item("So_sv_thoi_hoc") = iCount
                        dv.RowFilter = "Ly_do<>''"
                    Next
                    Dim Tieu_de1, Tieu_de2 As String
                    Tieu_de1 = "THÔNG KÊ SỐ SINH VIÊN HỌC TIẾP NGỪNG HỌC, HỌC KỲ " + (cmbHoc_ky.SelectedIndex + 1).ToString + " NĂM HỌC " + cmbNam_hoc.Text
                    Tieu_de2 = trvLop.Tieu_de

                    If mdtLop.Rows.Count > 0 Then
                        Dim frmESS_ As New frmESS_XemBaoCao
                        frmESS_.ShowDialog("rpThongKe_SinhVien_HocTiep_ThoiHoc", mdtLop, Tieu_de1, Tieu_de2)
                    End If
                End If
            Else
                Thongbao("Chọn học kỳ và năm học trước khi xét thôi học !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dv_chuachon As DataView = grcDanhSach.DataSource
            For i As Integer = dv_chuachon.Count - 1 To 0 Step -1
                If dv_chuachon.Item(i)("Chon") Then
                    clsDSXetLenLop.Update_XetLenLop_KhiDuyet(dv_chuachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text)
                End If
            Next
            Dim dk As String = "WHERE 1=1"
            If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
            If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
            If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
            If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
            grcDanhSach.DataSource = dv_chuachon
            labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 1).DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            Dim dv_dachon As DataView = grcDanhSach_DaChon.DataSource
            Dim dv_chuachon As DataView

            For i As Integer = dv_dachon.Count - 1 To 0 Step -1
                If dv_dachon.Item(i)("Chon") Then
                    clsDSXetLenLop.Delete_XetLenLop_DaDuyet(dv_dachon.Item(i)("ID_SV"), cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text)
                End If
            Next
            Dim dk As String = "WHERE 1=1"
            If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
            If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
            If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
            If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            dv_chuachon = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
            grcDanhSach.DataSource = dv_chuachon
            labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 1).DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dv As DataView = grcDanhSach.DataSource
        If Not dv Is Nothing Then
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i)("Chon") = optAll1.Checked
            Next
        End If
    End Sub

    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dv As DataView = grcDanhSach_DaChon.DataSource
        If Not dv Is Nothing Then
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub

    Private Sub cmbLan_thu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLan_thu.SelectedIndexChanged
        Try
            If cmbHoc_ky.Text = "" Or cmbNam_hoc.Text = "" Then Exit Sub
            clsDSXetLenLop = New DanhSachXetLenLop_Bussines()
            Dim dk As String = "WHERE 1=1"
            If trvLop.ID_he > 0 Then dk = dk & " AND ID_he=" & trvLop.ID_he
            If trvLop.Khoa_hoc > 0 Then dk = dk & "  AND Khoa_hoc=" & trvLop.Khoa_hoc
            If trvLop.ID_chuyen_nganh > 0 Then dk = dk & "  AND ID_chuyen_nganh=" & trvLop.ID_chuyen_nganh
            If trvLop.ID_Lop > 0 Then dk = dk & " AND a.ID_Lop=" & trvLop.ID_Lop

            grcDanhSach.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 0).DefaultView
            labSo_sv.Text = grcDanhSach.DataSource.Count
            grcDanhSach_DaChon.DataSource = clsDSXetLenLop.DanhSachDaXet_LanCanhBao("SELECT a.ID_lop FROM STU_DANHSACH a INNER JOIN STU_LOP b ON a.ID_lop=b.ID_lop " & dk, mID_he, mKhoa_hoc, mID_chuyen_nganh, cmbHoc_ky.Text, cmbNam_hoc.Text, cmbLan_thu.Text, 1).DefaultView
        Catch ex As Exception
        End Try
    End Sub
End Class