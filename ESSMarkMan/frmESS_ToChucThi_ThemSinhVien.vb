Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ToChucThi_ThemSinhVien
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mLan_thi As Integer = 0
    Private mID_mon As Integer = 0
    Private Loader As Boolean = False
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private mdv_dachon As New DataView
    Private clsDiem As Diem_Bussines

#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal dv_dachon As DataView, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_thi As Integer, ByVal ID_mon As Integer)
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mLan_thi = Lan_thi
        mID_mon = ID_mon
        mdv_dachon = dv_dachon
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ToChucThiThemSinhVien_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub frmESS_ToChucThiThemSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.TreeViewLop.HienThi_ESSTreeView()
        Me.trvLopTinChi.ID_mon_tc_thi = mID_mon

        cmbLocTheo.SelectedIndex = 3
        Loader = True
        clsDiem = New Diem_Bussines
        grcDanhSachThiChon.DataSource = clsDiem.DanhSach_ToChucThiLai(Nothing).DefaultView
    End Sub
    Private Sub frmESS_ToChucThiThemSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "User Function"
    Private Sub HienThi_ESSsinh_vien()
        Dim dsID_lop As String = TreeViewLop.ID_lop_list
        'Load danh sách sinh viên
        Dim dtDanhSachSinhVien As New DataTable
        Select Case cmbLocTheo.SelectedIndex
            Case 0
                TreeViewLop.SendToBack()
                clsLopTC = New DanhSachLopTinChi_Bussines(trvLopTinChi.ID_mon_tc, trvLopTinChi.ID_lop_tc)
                dtDanhSachSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)

                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 1  'Thi lại, Phai nop tien moi co trong danh sach
                TreeViewLop.SendToBack()
                clsLopTC = New DanhSachLopTinChi_Bussines(trvLopTinChi.ID_mon_tc, trvLopTinChi.ID_lop_tc)
                'dtDanhSachSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text)
                'clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True)
                Dim dt As DataTable = clsLopTC.DanhSachThiLai_ToChucThi(mHoc_ky, mNam_hoc, trvLopTinChi.ID_lop_tc)

                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 2  'Danh sách thi lại lớp hành chính
                trvLopTinChi.SendToBack()
                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_TCThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text, optTheoKhoa.Checked, mID_mon)

                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(mID_mon, False, 0))
                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 3  'Danh sách lớp
                trvLopTinChi.SendToBack()
                If mLan_thi = 1 Then
                    'Load sinh vien theo lớp
                    Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                    dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_TCThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text, optTheoKhoa.Checked, mID_mon)
                    clsDiem = New Diem_Bussines(gobjUser.ID_dv, gobjUser.ID_Bomon, mHoc_ky, mNam_hoc, dsID_lop, CType(TreeViewLop.ID_dt_list, Integer), dtDanhSachSinhVien)
                    Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dtDanhSachSinhVien)

                    grcDanhSachThi.DataSource = dt.DefaultView
                    lblSo_sv.Text = dt.DefaultView.Count
                Else
                    'Load theo danh sách thi lại lần 2
                End If
            Case 4  'Danh sách tốt nghiệp
            Case 5  'Danh sách làm luận văn
            Case 6  ' Danh sách sinh viên nâng điểm theo tín chỉ
                TreeViewLop.SendToBack()
                clsLopTC = New DanhSachLopTinChi_Bussines(trvLopTinChi.ID_mon_tc, trvLopTinChi.ID_lop_tc)
                dtDanhSachSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(mID_mon, False, 6))

                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 7 ' Danh sách sinh viên nâng điểm theo lớp hành chính
                trvLopTinChi.SendToBack()
                Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                dtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien_TCThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text, optTheoKhoa.Checked, mID_mon)

                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, False)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(mID_mon, False, 7))
                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 8  'Danh sách thi cải thiện điểm
                Dim cls As New TochucThi_Bussines
                Dim dt1 As DataTable = cls.HienThi_ESSDS_dangkyThiLai(mID_mon, mHoc_ky, mNam_hoc, 0)
                clsDiem = New Diem_Bussines()
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dt1)
                grcDanhSachThi.DataSource = dt.DefaultView
            Case 9 'Danh sách thi lại
                'Dim cls As New TochucThi_Bussines
                'Dim dt1 As DataTable = cls.HienThi_ESSDS_dangkyThiLai(mID_mon, mHoc_ky, mNam_hoc, 1)
                'clsDiem = New Diem_Bussines()
                'Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(dt1)
                'grcDanhSachThi.DataSource = dt.DefaultView

                TreeViewLop.SendToBack()
                clsLopTC = New DanhSachLopTinChi_Bussines(trvLopTinChi.ID_mon_tc, trvLopTinChi.ID_lop_tc)
                dtDanhSachSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(mID_mon, False, 0))

                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
            Case 10 'Danh sách thi lại <5
                TreeViewLop.SendToBack()
                clsLopTC = New DanhSachLopTinChi_Bussines(trvLopTinChi.ID_mon_tc, trvLopTinChi.ID_lop_tc)
                dtDanhSachSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi(mdv_dachon, cmbID_ngoai_ngu.Text.Trim, txtMa_sv.Text)
                clsDiem = New Diem_Bussines(gobjUser.ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True)
                Dim dt As DataTable = clsDiem.DanhSach_ToChucThiLai(clsDiem.TongHopDiemThiLai_ThieuDiem_SinhVien(mID_mon, False, 10, mHoc_ky, mNam_hoc))

                grcDanhSachThi.DataSource = dt.DefaultView
                lblSo_sv.Text = dt.DefaultView.Count
        End Select
    End Sub
#End Region
#Region "Control Events"
    Private Sub trvLopTinChi_Select() Handles trvLopTinChi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            If mHoc_ky = trvLopTinChi.Hoc_ky And mNam_hoc = trvLopTinChi.Nam_hoc And mID_mon = trvLopTinChi.ID_mon Then
                If trvLopTinChi.ID_mon_tc > 0 Then
                    HienThi_ESSsinh_vien()
                End If
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader = False Then Exit Sub
            If TreeViewLop.ID_lop_list > 0 Then
                HienThi_ESSsinh_vien()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbLocTheo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbLocTheo.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbLocTheo.SelectedIndex >= 0 Then
                HienThi_ESSsinh_vien()
                '    'trvLopTinChi.SendToBack()
                'Else
                'TreeViewLop.SendToBack()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub
    Private Sub chkAll2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll2.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThiChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll2.Checked
            Next
        End If
    End Sub





#End Region
    Private Sub cmbID_ngoai_ngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_ngoai_ngu.SelectedIndexChanged
        Me.Cursor = Cursors.WaitCursor
        Try
            If mID_mon > 0 Then
                HienThi_ESSsinh_vien()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub cmdFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdFind.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If mID_mon > 0 Then
                HienThi_ESSsinh_vien()
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Me.Tag = 1
        Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = 0
        Close()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv As Integer = 0
            dv = grvDanhSachThi.DataSource
            dvChon = grvDanhSachThiChon.DataSource
            If dvChon Is Nothing Then dvChon.Table = dv.Table.Clone
            dvChon.Sort = "ID_sv"
            For i As Integer = dv.Count - 1 To 0 Step -1
                If dv.Item(i)("Chon") AndAlso dvChon.Find(dv.Item(i)("ID_SV")) < 0 Then
                    Dim dr As DataRow
                    dr = dvChon.Table.NewRow
                    dr.ItemArray = dv.Item(i).Row.ItemArray
                    dvChon.Table.Rows.Add(dr)
                    dv.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để thêm ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            Dim dv, dvChon As New DataView
            Dim So_sv As Integer = 0
            dv = grvDanhSachThi.DataSource
            dvChon = grvDanhSachThiChon.DataSource
            If dvChon Is Nothing Then Exit Sub
            For i As Integer = dvChon.Count - 1 To 0 Step -1
                If dvChon.Item(i)("Chon") Then
                    Dim dr As DataRow
                    dr = dv.Table.NewRow
                    dr.ItemArray = dvChon.Item(i).Row.ItemArray
                    dv.Table.Rows.Add(dr)
                    dvChon.Item(i).Row.Delete()
                    So_sv += 1
                End If
            Next
            If So_sv > 0 Then
                dv.Table.AcceptChanges()
                dvChon.Table.AcceptChanges()
                txtSo_sv.Text = dvChon.Count
            Else
                Thongbao("Bạn hãy chọn sinh viên để xoá ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class