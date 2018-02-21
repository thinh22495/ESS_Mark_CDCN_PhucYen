Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_LapDanhSachThi_CaiThienDiem
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mNien_khoa As String = ""
    Private Lam_tron_TBCMH As Integer = 0
    Private Lam_tron_diem_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsTCTDangKyThiCaiThien As New ToChucThiDangKyCaiThienDiem_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private mdtDanhSachSinhVien As New DataTable

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

            Dim dt As New DataTable
            Dim Ky_thu As Integer
            Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
            Dim Nam_hoc As String = cmbNam_hoc.Text
            Ky_thu = Ky2to10(Hoc_ky, Nam_hoc, mNien_khoa)
            If Ky_thu > 0 Then
                'dt = clsCTDT.DanhSachMonHoc(Ky_thu)
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
        Lam_tron_TBCMH = cls.Doc_tham_so("Lam_tron_TBCMH")
        Lam_tron_diem_thi = cls.Doc_tham_so("Lam_tron_diem_thi")
    End Sub
#End Region

#Region "Form Events"
    Private Sub frmESS_NhapDiemThi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            'Load các giá trị tham số hệ thống
            Doc_tham_so_he_thong()
            'Load dữ liệu vào ComboBox học kỳ, năm học, lần thi
            LoadComboBox()
            'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
            Me.TreeViewLop.HienThi_ESSTreeView()
            Loader = True
            SetQuyenTruyCap(, cmdThem, , cmdXoa)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_NhapDiemThiLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim frmESS_ As New frmESS_LapDanhSachThi_ThiLai
        frmESS_.ShowDialog()
    End Sub


    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSachThiChon)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub trvLop_Select() Handles TreeViewLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not TreeViewLop.ID_lop_list Is Nothing Then
                    dsID_lop = TreeViewLop.ID_lop_list
                    dsID_dt = TreeViewLop.ID_dt_list
                    mNien_khoa = TreeViewLop.Nien_khoa
                    'Load danh sách các Học phần trong chương trình đào tạo khung
                    If dsID_dt <> "" Then
                        'clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, gobjUser.ID_Bomon)
                        clsCTDT = New ChuongTrinhDaoTao_Bussines(dsID_dt, 0)
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
    Private Sub cmbHocKy_NamHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged
        Try
            If Loader Then
                Add_MonHoc()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmbMonHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_mon.SelectedIndexChanged, cmbLoaiDSThi.SelectedIndexChanged
        Try
            Try
                If Loader Then
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim Hinh_thuc As Integer = cmbLoaiDSThi.SelectedIndex
                    If mdtDanhSachSinhVien.Rows.Count > 0 And ID_mon > 0 And Hinh_thuc >= 0 Then
                        clsTCTDangKyThiCaiThien = New ToChucThiDangKyCaiThienDiem_Bussines(Hoc_ky, Nam_hoc, ID_mon, Hinh_thuc)
                        Dim dtDSCaiThien As New DataTable
                        Dim dtDSSinhVienNotCaiThien As DataTable = mdtDanhSachSinhVien.Copy
                        dtDSCaiThien = clsTCTDangKyThiCaiThien.DanhSachSinhVienHocCaiThi(Hoc_ky, Nam_hoc, ID_mon)
                        For i As Integer = mdtDanhSachSinhVien.Rows.Count - 1 To 0 Step -1
                            For j As Integer = 0 To dtDSCaiThien.Rows.Count - 1
                                If mdtDanhSachSinhVien.Rows(i)("ID_sv") = dtDSCaiThien.Rows(j)("ID_sv") Then
                                    dtDSSinhVienNotCaiThien.Rows.RemoveAt(i)
                                    dtDSSinhVienNotCaiThien.AcceptChanges()
                                    Exit For
                                End If
                            Next
                        Next
                        grcDanhSachThi.DataSource = dtDSSinhVienNotCaiThien.DefaultView
                        grcDanhSachThiChon.DataSource = dtDSCaiThien.DefaultView
                    Else
                        grcDanhSachThi.DataSource = Nothing
                        grcDanhSachThiChon.DataSource = Nothing
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




    Private Sub cmdPrint_Diem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDiem.DataSource Is Nothing Then
        '        Dim Tieu_de1, Tieu_de2 As String
        '        Dim dtTP As DataTable
        '        Tieu_de1 = "BẢNG ĐIỂM THÀNH PHẦN"
        '        Tieu_de2 = "HỌC PHẦN: " + cmbID_mon.Text.ToUpper + ", " + TreeViewLop.Tieu_de.ToUpper
        '        dtTP = clsDiem.DanhSachThanhPhanChon

        '        TaoBaoCaoBangDiemThanhPhan(C1Report1, Printing.PaperKind.A4, C1.Win.C1Report.OrientationEnum.Portrait, Tieu_de1, Tieu_de2, "", dtTP)
        '        Dim dtDiemTH As DataTable = grdViewDiem.DataSource.Table
        '        C1Report1.DataSource.Recordset = dtDiemTH
        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog(C1Report1)
        '    Else
        '        Thongbao("Bạn phải chọn học phần trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_DanhSach_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try

        '    Dim dt As DataTable = grdViewDiem.DataSource.Table
        '    Dim dt_Main As DataTable = dt.Copy
        '    If dt_Main.Rows.Count > 0 Then
        '        dt_Main.Columns.Add("Tieu_de_Ten_truong")
        '        dt_Main.Columns.Add("Ten_mon")
        '        'dt_Main.Columns.Add("Hoc_ky")
        '        'dt_Main.Columns.Add("Nam_hoc")

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)

        '        For i As Integer = 0 To dt_Main.Rows.Count - 1
        '            If objBaoCaoTieuDe.Count > 0 Then
        '                dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
        '            Else
        '                dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = ""
        '            End If

        '            dt_Main.Rows(i).Item("Ten_mon") = "Học phần: " & cmbID_mon.Text
        '            dt_Main.Rows(i).Item("Hoc_ky") = cmbHoc_ky.Text
        '            dt_Main.Rows(i).Item("Nam_hoc") = cmbNam_hoc.Text
        '        Next

        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog("BangDiem_KiemTraHocPhan", dt_Main)
        '    End If
        'Catch ex As Exception
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdDSDiemDanh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    Dim dt As DataTable = grdViewDiem.DataSource.Table
        '    Dim dt_Main As DataTable = dt.Copy
        '    If dt_Main.Rows.Count > 0 Then
        '        dt_Main.Columns.Add("Tieu_de_Ten_truong")
        '        dt_Main.Columns.Add("Tieu_de1")
        '        dt_Main.Columns.Add("Tieu_de2")
        '        'dt_Main.Columns.Add("Nam_hoc")

        '        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)

        '        For i As Integer = 0 To dt_Main.Rows.Count - 1
        '            If objBaoCaoTieuDe.Count > 0 Then
        '                dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
        '            Else
        '                dt_Main.Rows(i).Item("Tieu_de_Ten_truong") = ""
        '            End If

        '            dt_Main.Rows(i).Item("Tieu_de1") = "BẢNG ĐIỂM DANH"
        '            dt_Main.Rows(i).Item("Tieu_de2") = "HỌC PHẦN: " & cmbID_mon.Text.ToUpper & ", " & TreeViewLop.Tieu_de.ToUpper
        '        Next

        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog("rpDanhSachDiemDanhLopTC", dt_Main)
        '    End If
        'Catch ex As Exception
        'End Try
        'Me.Cursor = Cursors.Default
    End Sub


    Private Sub grdViewDiem_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        Try

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdThem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThem.Click
        Try
            Try
                If Loader Then
                    If cmbLoaiDSThi.SelectedIndex = -1 Then Exit Sub
                    If grvDanhSachThi.GetFocusedDataRow Is Nothing Then Exit Sub
                    Dim dvDSNotCaiThien As DataView = grvDanhSachThi.DataSource
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim isCheck As Boolean = False
                    If ID_mon > 0 Then
                        For i As Integer = 0 To dvDSNotCaiThien.Count - 1
                            If dvDSNotCaiThien.Item(i)("Chon") Then
                                Dim obj As New ESSToChucThiDangKyCaiThienDiem
                                obj.ID_sv = dvDSNotCaiThien.Item(i)("ID_sv")
                                obj.Hoc_ky = Hoc_ky
                                obj.Nam_hoc = Nam_hoc
                                obj.ID_mon = ID_mon
                                obj.Hinh_thuc = cmbLoaiDSThi.SelectedIndex
                                obj.Duyet = 0
                                clsTCTDangKyThiCaiThien.ThemMoi_ESSToChucThiDangKyCaiThienDiem(obj)
                                isCheck = True
                            End If
                        Next
                        If Not isCheck Then
                            Thongbao("Bạn hãy chọn sinh viên để đăng ký thi cải thiện", MsgBoxStyle.Exclamation)
                        Else
                            cmbMonHoc_SelectedIndexChanged(sender, e)
                        End If
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXoa.Click
        Try
            Try
                If Loader Then
                    If grvDanhSachThiChon.GetFocusedDataRow Is Nothing Then Exit Sub
                    Dim dvDSCaiThien As DataView = grvDanhSachThiChon.DataSource
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim isCheck As Boolean = False
                    If ID_mon > 0 Then
                        For i As Integer = 0 To dvDSCaiThien.Count - 1
                            If dvDSCaiThien.Item(i)("Chon") Then
                                clsTCTDangKyThiCaiThien.Xoa_ESSToChucThiDangKyCaiThienDiem(dvDSCaiThien.Item(i)("ID_sv"), Hoc_ky, Nam_hoc, ID_mon)
                                isCheck = True
                            End If
                        Next
                        If Not isCheck Then
                            Thongbao("Bạn hãy chọn sinh viên để xóa đăng ký thi cải thiện", MsgBoxStyle.Exclamation)
                        Else
                            cmbMonHoc_SelectedIndexChanged(sender, e)
                        End If
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
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

    Private Sub chkAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grvDanhSachThiChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = chkAll1.Checked
            Next
        End If
    End Sub

    Private Sub cmdDuyet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Try
                If Loader Then
                    If grvDanhSachThiChon.GetFocusedDataRow Is Nothing Then Exit Sub
                    Dim dvDSCaiThien As DataView = grvDanhSachThiChon.DataSource
                    Dim Hoc_ky As Integer = cmbHoc_ky.SelectedValue
                    Dim Nam_hoc As String = cmbNam_hoc.Text
                    Dim ID_mon As Integer = cmbID_mon.SelectedValue
                    Dim isCheck As Boolean = False
                    If ID_mon > 0 Then
                        For i As Integer = 0 To dvDSCaiThien.Count - 1
                            Dim obj As New ESSToChucThiDangKyCaiThienDiem
                            obj.ID_sv = dvDSCaiThien.Item(i)("ID_sv")
                            obj.Hoc_ky = Hoc_ky
                            obj.Nam_hoc = Nam_hoc
                            obj.ID_mon = ID_mon
                            obj.Duyet = IIf(dvDSCaiThien.Item(i)("Duyet"), 1, 0)
                            obj.Ghi_chu = dvDSCaiThien.Item(i)("Ghi_chu").ToString
                            obj.Hinh_thuc = dvDSCaiThien.Item(i)("Hinh_thuc").ToString
                            clsTCTDangKyThiCaiThien.CapNhat_ESSToChucThiDangKyCaiThienDiem(obj)
                            isCheck = True
                        Next
                        If isCheck Then
                            Thongbao("Duyệt đăng ký thi cải thiện thành công", MsgBoxStyle.Exclamation)
                            cmbMonHoc_SelectedIndexChanged(sender, e)
                        End If
                    End If
                End If
            Catch ex As Exception
                Thongbao(ex.Message)
            End Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


End Class