Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSReports
Public Class frmESS_DanhSachSinhVien_KhongDuDieuKienDuThi_LHC
    Private dsID_lop As String = "0"
    Private mdtDanhSachSinhVien As New DataTable

    Private clsDiem As New Diem_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines
    Private clsXet As DanhSachKhongThi_Bussines
    Private MucDiem_Tran As Double

    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsCTDT As ChuongTrinhDaoTao_Bussines


#Region "Functions And Subs"
    Private Sub LoadComboBox()
        Try
            Add_Hocky(cmbHoc_ky)
            Add_Namhoc(cmbNam_hoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub Add_MonHoc()
        Try

            Dim dt As DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                dt = clsCTDT.DanhSachMonHoc(Ky_thu)
                'Load tat ca cac mon hoc trong CTDT khung
                If dt.Rows.Count = 0 Then
                    dt = clsCTDT.DanhSachMonHoc()
                End If
                'Nếu danh sách Học phần không thay đổi thì không phải load lại dữ liệu
                If Not CompareData(dt, cmbID_mon.DataSource) Then
                    FillCombo(cmbID_mon, dt)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CompareData(ByVal dt As DataTable, ByVal dt1 As DataTable) As Boolean
        If dt Is Nothing Or dt1 Is Nothing Then Return False
        If dt.Rows.Count <> dt1.Rows.Count Then Return False
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_mon") <> dt1.Rows(i)("ID_mon") Then
                Return False
            End If
        Next
        Return True
    End Function
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
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TreeViewLop.HienThi_ESSTreeView()
            Loader = True
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
    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not TreeViewLop.ID_lop_list Is Nothing Then
                    dsID_lop = TreeViewLop.ID_lop_list
                    dsID_dt = TreeViewLop.ID_dt_list
                    mNien_khoa = TreeViewLop.Nien_khoa
                    'Load danh sách các Học phần trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, gobjUser.ID_Bomon)
                        'Load Học phần vào Combobox
                        Add_MonHoc()
                    End If
                    'Load danh sách sinh viên
                    Dim objDanhSach As New DanhSachSinhVien_Bussines(dsID_lop)
                    mdtDanhSachSinhVien = objDanhSach.Danh_sach_sinh_vien
                    'Load danh sách điểm
                    cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub optHoc_tap_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optHoc_tap.CheckedChanged, optHoc_phi.CheckedChanged, optDanh_sach.CheckedChanged, optHocPhi_Ky.CheckedChanged
        Try
            If cmbHoc_ky.Text.Trim <> "" And cmbNam_hoc.Text.Trim <> "" And cmbID_mon.Text.Trim <> "" And dsID_lop.Trim <> "0" Then
                cmbMonHoc_SelectedIndexChanged(Nothing, Nothing)
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



    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged
        Try
            Try
                If Loader Then
                    'Load danh sách điểm của sinh viên
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 Then
                        clsXet = New DanhSachKhongThi_Bussines(0, 0, Hoc_ky, Nam_hoc, ID_mon, dsID_lop)
                        Dim dt As DataTable = clsXet.Danh_sach_sinh_vien_no_HocTap
                        labSo_sv.Text = dt.Rows.Count
                        grcDanhSachKDK.DataSource = dt.DefaultView
                        If optHoc_tap.Checked Then
                            'clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, 0, 0, mdtDanhSachSinhVien, False, True)
                            clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                            grcDanhSachThi.DataSource = clsDiem.DanhSachKhongDuDieuKienDuThi(ID_mon, MucDiem_Tran, dt).DefaultView
                        End If

                        If optDanh_sach.Checked Then
                            clsDiem = New Diem_Bussines(ID_dv, Hoc_ky, Nam_hoc, ID_mon, dsID_lop, mdtDanhSachSinhVien, False, True)
                            grcDanhSachThi.DataSource = clsXet.DanhSachKhongDuDieuKienDuThi_LopHC(dt, mdtDanhSachSinhVien).DefaultView
                        End If

                        If optHoc_phi.Checked Then
                            grcDanhSachThi.DataSource = clsXet.DanhSachKhongDuDieuKienDuThi_NoHocPhiMon(0, 0, Hoc_ky, Nam_hoc, ID_mon, dsID_lop).DefaultView
                        End If
                    Else
                        grcDanhSachThi.DataSource = Nothing
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If grvDanhSachThi.RowCount < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSachThi.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New ESSDanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.ID_mon = cmbID_mon.SelectedValue
                    obj.Hoc_ky = cmbHoc_ky.Text.Trim
                    obj.Nam_hoc = cmbNam_hoc.Text.Trim
                    obj.Ly_do = dv.Table.Rows(i).Item("Ly_do")
                    clsXet.ThemMoi_ESSDanhSachKhongThi(obj)
                End If
            Next

            cmbMonHoc_SelectedIndexChanged(sender, e)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If grvDanhSachKDK.RowCount < 0 Then Exit Sub
            Dim dv As DataView = grvDanhSachKDK.DataSource

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon") Then
                    Dim obj As New ESSDanhSachKhongThi
                    obj.ID_sv = dv.Table.Rows(i).Item("ID_SV")
                    obj.ID_mon = cmbID_mon.SelectedValue
                    obj.Hoc_ky = cmbHoc_ky.Text.Trim
                    obj.Nam_hoc = cmbNam_hoc.Text.Trim
                    clsXet.Xoa_ESSDanhSachKhongThi(obj)
                End If
            Next

            cmbMonHoc_SelectedIndexChanged(sender, e)
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
                Tieu_de2 = ("Học kỳ: " & cmbHoc_ky.Text.Trim & " Năm học: " & cmbNam_hoc.Text.Trim & " - Học phần: " & cmbID_mon.Text.Trim).ToUpper
                Tieu_de3 = TreeViewLop.Tieu_de.ToUpper
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_DanhSachSinhVien_KDDK_Thi", dv1, Tieu_de1, Tieu_de2, Tieu_de3)
                f.ShowDialog()
            End If

        Catch ex As Exception
        End Try
    End Sub



    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Me.Close()
    End Sub
End Class