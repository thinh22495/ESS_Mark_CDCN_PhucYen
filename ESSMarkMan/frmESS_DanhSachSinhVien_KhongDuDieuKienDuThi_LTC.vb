Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LTC
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mLan_thi As Integer = 1
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mTen_lop_tc As String = ""
    Private clsDiem As New Diem_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private clsXet As DanhSachKhongThi_Bussines
    Private MucDiem_Tran As Double


#Region "Functions And Subs"
    Private Sub Doc_tham_so_he_thong()
        Dim cls As New ThamSoHeThong_Bussines
        MucDiem_Tran = cls.Doc_tham_so("Diem_TBCKiemTra_ThanhPhan_Dat")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            SetQuyenTruyCap(, cmdAdd, , cmdDelete)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_DanhSachKhongDuDieuKienThi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLopTinChi_Select() Handles TreeViewLopTinChi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = TreeViewLopTinChi.Hoc_ky
            mNam_hoc = TreeViewLopTinChi.Nam_hoc
            mID_mon_tc = TreeViewLopTinChi.ID_mon_tc
            mID_lop_tc = TreeViewLopTinChi.ID_lop_tc
            mID_mon = TreeViewLopTinChi.ID_mon
            mTen_mon = TreeViewLopTinChi.Ten_mon
            mTen_lop_tc = TreeViewLopTinChi.Ten_lop_tc



            clsXet = New DanhSachKhongThi_Bussines(mID_mon_tc, mID_lop_tc, mHoc_ky, mNam_hoc, mID_mon, "")
            Dim dt As DataTable = clsXet.Danh_sach_sinh_vien_no_HocTap
            grcDanhSachKDK.DataSource = dt.DefaultView
            labSo_sv.Text = dt.DefaultView.Count

            'Da thuoc dien ko du dk du thi
            Dim sender As System.Object
            Dim e As System.EventArgs
            optHoc_tap_CheckedChanged(sender, e)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


#End Region

    Private Sub optHoc_tap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optHoc_tap.CheckedChanged, optHoc_phi.CheckedChanged, optDanh_sach.CheckedChanged, optHocPhi_Ky.CheckedChanged
        Try
            If mID_mon_tc > 0 Then

                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = gobjUser.dsID_lop
                Dim dtDanhSachSinhVien As New DataTable
                'Load dữ liệu về tổ chức thi
                'clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc)
                clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc, gobjUser.UserName, gobjUser.ID_phong)
                dtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien
                Dim dv As DataView = grvDanhSachKDK.DataSource

                'Kiểm tra điểm kiểm tra so với điểm Kiểm tra trong hệ thốgn để lấy ra danh sách sinh viên ko đủ đkdự thi
                If optHoc_tap.Checked Then
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, mID_mon_tc, mID_lop_tc, dtDanhSachSinhVien)
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, False, True, True)
                        'grcDanhSachThi.DataSource = clsDiem.DanhSachKhongDuDieuKienDuThi(mID_mon, MucDiem_Tran, dv.Table).DefaultView
                        grcDanhSachThi.DataSource = clsDiem.DanhSach_KDDKDT_TheoDiemDanh(mID_mon, mID_lop_tc, mHoc_ky, mNam_hoc).DefaultView
                    Else
                        grcDanhSachThi.DataSource = Nothing
                    End If
                End If

                If optHoc_phi.Checked Then
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        grcDanhSachThi.DataSource = clsXet.DanhSachKhongDuDieuKienDuThi_NoHocPhiMon(mID_mon_tc, mID_lop_tc, mHoc_ky, mNam_hoc, mID_mon, "").DefaultView
                    Else
                        grcDanhSachThi.DataSource = Nothing
                    End If
                End If

                If optDanh_sach.Checked Then
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        grcDanhSachThi.DataSource = clsXet.DanhSachKhongDuDieuKienDuThi_DanhSachLopTinChi(dtDanhSachSinhVien, dv).DefaultView
                    Else
                        grcDanhSachThi.DataSource = Nothing
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThi.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub chkAll1_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachKDK.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub



    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If grvDanhSachThi.RowCount < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSachThi.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New ESSDanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.ID_mon = mID_mon
                    obj.Hoc_ky = mHoc_ky
                    obj.Nam_hoc = mNam_hoc
                    obj.Ly_do = dv.Table.Rows(i).Item("Ly_do")
                    clsXet.ThemMoi_ESSDanhSachKhongThi(obj)
                End If
            Next

            trvLopTinChi_Select()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If grvDanhSachKDK.RowCount < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSachKDK.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New ESSDanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.ID_mon = mID_mon
                    obj.Hoc_ky = mHoc_ky
                    obj.Nam_hoc = mNam_hoc
                    clsXet.Xoa_ESSDanhSachKhongThi(obj)
                End If
            Next

            trvLopTinChi_Select()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv1 As DataView = grvDanhSachKDK.DataSource
            Dim Tieu_de1 As String = ""
            Dim Tieu_de2 As String = ""
            Dim Tieu_de3 As String = ""

            If grvDanhSachKDK.RowCount > 0 Then
                Tieu_de1 = "DANH SÁCH SINH VIÊN KHÔNG ĐỦ ĐIỀU KIỆN DỰ THI"
                Tieu_de2 = "HỌC PHẦN :  " & TreeViewLopTinChi.Ten_mon.ToUpper
                If mID_lop_tc > 0 Then
                    Tieu_de3 = "LỚP: " & TreeViewLopTinChi.Ten_lop_tc.ToUpper
                End If
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_DanhSachSinhVien_KDDK_Thi", dv1, Tieu_de1, Tieu_de2, Tieu_de3)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click

    End Sub

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
End Class