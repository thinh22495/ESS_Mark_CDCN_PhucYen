Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports ESSConnect
Imports ESSReports


Public Class frmESS_ToChucThi_DanhSach
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_mon As Integer = 0
    Private mID_thi As Integer = 0
    Private mTen_mon As String = ""
    Private mID_khoa As Integer = 0
    Private mTen_khoa As String = ""
    Private mPhong_thi As String = ""
    Private mNgay_thi As String = ""
    Private mLan_thi As Integer = 0
    Private mID_phong_thi As Integer = 0
    Private Loader As Boolean = False
    Private clsTCThi As New TochucThi_Bussines
    Private clsDiem As New Diem_Bussines
    Private mdtDanhSachSinhVien As New DataTable
#Region "Form Events"

    Private Sub frmESS_ToChucThiList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_ToChucThiList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            'trvPhongThi.Load_Treeview()


            cmbOrder.SelectedIndex = 0
            cmbHinhthuc.SelectedIndex = 0
            Loader = True
            SetQuyenTruyCap(cmdAdd_TCT, cmdAdd_SV, cmdDelete_TCT, cmdList_SV)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_ToChucThiList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvPhongThi_Select() Handles trvPhongThi.TreeNodeSelected_
        Try
            If Loader Then
                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi
                mID_khoa = trvPhongThi.ID_khoa
                mTen_khoa = trvPhongThi.Ten_khoa
                mTen_mon = trvPhongThi.Ten_mon
                mPhong_thi = trvPhongThi.Phong_thi
                If mID_thi > 0 Then
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        Me.grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi).DefaultView
                    Else    'Load tất cả sinh viên của tổ chức thi
                        Me.grcDanhSachThi.DataSource = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi).DefaultView
                    End If
                    txtSo_sv.Text = Me.grvDanhSachThi.RowCount
                Else
                    Me.grcDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                End If
            End If
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




    Private Sub menuPrintPhongThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Me.Cursor = Cursors.WaitCursor
        'Try
        '    If Not grdViewDanhSachThi.DataSource Is Nothing Then
        '        Dim dtDiemTH As DataTable
        '        Dim mCa_thi, mNhom_tiet, mGio_thi As String

        '        mHoc_ky = trvPhongThi.Hoc_ky
        '        mNam_hoc = trvPhongThi.Nam_hoc
        '        mID_mon = trvPhongThi.ID_mon
        '        mLan_thi = trvPhongThi.Lan_thi
        '        mID_thi = trvPhongThi.ID_thi
        '        mID_phong_thi = trvPhongThi.ID_phong_thi
        '        If mID_thi > 0 Then
        '            Dim ID_dv As String = gobjUser.ID_dv
        '            Dim dsID_lop As String = ""
        '            Dim dtDanhSachSinhVien As DataTable
        '            'Load dữ liệu về tổ chức thi
        '            clsTCThi = New TochucThi_BLL(mID_thi)
        '            Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
        '            If dt.Rows.Count > 0 Then
        '                mNgay_thi = dt.Rows(0).Item("Ngay_thi")
        '                mCa_thi = dt.Rows(0).Item("Ca_thi")
        '                mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
        '                mGio_thi = dt.Rows(0).Item("Gio_thi")
        '            End If
        '            If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
        '                dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
        '            Else    'Load tất cả sinh viên của tổ chức thi
        '                dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
        '            End If
        '            If dtDanhSachSinhVien.Rows.Count > 0 Then
        '                'Lấy danh sách các ID_lop
        '                For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
        '                    If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
        '                        dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
        '                    End If
        '                Next
        '                If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
        '                'Load dữ liệu điểm
        '                clsDiem = New Diem_BLL(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
        '                'If mLan_thi = 1 Then
        '                dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon)
        '                'Else
        '                '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
        '                'End If
        '            End If
        '        End If
        '        If mCa_thi = "0" Then mCa_thi = "Sáng"
        '        If mCa_thi = "1" Then mCa_thi = "Chiều"
        '        If mCa_thi = "2" Then mCa_thi = "Tối"
        '        If mNhom_tiet = 0 Then
        '            mNhom_tiet = 1
        '        ElseIf mNhom_tiet = 1 Then
        '            mNhom_tiet = 2
        '        ElseIf mNhom_tiet = 2 Then
        '            mNhom_tiet = 3
        '        End If

        '        dtDiemTH.Columns.Add("Tieu_de", GetType(String))
        '        dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
        '        dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
        '        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
        '        dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
        '        dtDiemTH.Columns.Add("Ca_thi", GetType(String))
        '        dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
        '        dtDiemTH.Columns.Add("Gio_thi", GetType(String))
        '        dtDiemTH.Columns.Add("Tieu_de_ten_bo")
        '        dtDiemTH.Columns.Add("Tieu_de_Ten_truong")

        '        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
        '            dtDiemTH.Rows(i).Item("Tieu_de") = "DANH SÁCH DỰ THI LẦN " & mLan_thi
        '            dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
        '            dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
        '            dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
        '            dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
        '            dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
        '            dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
        '            dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
        '            dtDiemTH.Rows(i).Item("Gio_thi") = mGio_thi
        '        Next
        '        Dim dv As DataView = dtDiemTH.DefaultView
        '        dv.Sort = "So_bao_danh"
        '        Dim frmESS_ As New frmESS_ReportView
        '        frmESS_.ShowDialog_RFix("DS THI THEO PHONG", dv.Table)
        '    Else
        '        Thongbao("Bạn phải chọn học phần tổ chức thi trước")
        '    End If
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
        'Me.Cursor = Cursors.Default
        'Dim frmESS_ As New frmESS_BaoCaoToChucThi
        'frmESS_.ShowDialog()
    End Sub
#End Region



    Private Sub cmdPhanPhongThi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim frmESS_ As New frmESS_ToChucThi_PhanPhong
            If mID_thi > 0 Then
                clsTCThi = New TochucThi_Bussines(trvPhongThi.Hoc_ky, trvPhongThi.Nam_hoc, gobjUser.ID_Bomon)
                frmESS_.ShowDialog(mID_thi, clsTCThi)
                If frmESS_.Save = True Then
                    'Load lại danh sách phòng thi
                End If
            Else
                Thongbao("Bạn hãy chọn phòng thi", MsgBoxStyle.OkOnly)
            End If
        Catch ex As Exception
            Thongbao(ex.Message, MsgBoxStyle.OkOnly)
        End Try
    End Sub



    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim SQL As String = ""
        Dim dt As DataTable
        dt = Connect.SelectTableSP("sp_tkbPhongHoc_Load_List")
        For i As Integer = 0 To dt.Rows.Count - 1
            SQL = "UPDATE svToChucThiPhong SET ID_phong=" & dt.Rows(i)("ID_phong") & " WHERE Ten_phong=N'" & dt.Rows(i)("Ten_nha").ToString & "-" & dt.Rows(i)("So_phong").ToString & "'"
            Connect.Execute(SQL)
        Next
    End Sub



    Private Sub cmdPhucKhao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If mID_thi > 0 Then

                If grvDanhSachThi.RowCount > 0 Then
                    Dim dv As DataView = grvDanhSachThi.DataSource
                    Dim So_sv As Integer = 0
                    If clsTCThi.Count > 0 Then
                        Dim objTCThi As New ESSTochucThi
                        objTCThi = clsTCThi.ToChucThi(0)
                        Dim dtPhucKhao As DataTable = clsTCThi.DanhSachSinhVienPhucKhao(mID_thi)
                        For i As Integer = 0 To dv.Count - 1
                            If dv.Item(i)("Chon") AndAlso objTCThi.dsPhucKhao.Tim_idx(dv.Item(i)("ID_ds_thi")) < 0 Then
                                Dim dr As DataRow
                                dr = dtPhucKhao.NewRow
                                dr("ID_sv") = False
                                dr("ID_sv") = dv.Item(i)("ID_sv")
                                dr("So_bao_danh") = dv.Item(i)("So_bao_danh")
                                dr("Ma_sv") = dv.Item(i)("Ma_sv")
                                dr("Ho_ten") = dv.Item(i)("Ho_ten")
                                dr("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                                'dr("ID_he") = dv.Item(i)("ID_he")
                                'dr("Ten_he") = dv.Item(i)("Ten_he")
                                dr("ID_khoa") = mID_khoa
                                dr("Ten_khoa") = dv.Item(i)("Ten_khoa")
                                'dr("ID_lop") = dv.Item(i)("ID_lop")
                                dr("Ten_lop") = dv.Item(i)("Ten_lop")
                                dr("ID_mon") = mID_mon
                                'dr("Ky_hieu") = dv.Item(i)("Ky_hieu")
                                dr("Ten_mon") = mTen_mon
                                dr("ID_phuc_khao") = 0
                                dr("ID_thi") = mID_thi
                                dr("ID_ds_thi") = dv.Item(i)("ID_ds_thi")
                                dr("Diem1") = 0
                                dr("Diem2") = 0
                                dr("Ghi_chu") = ""
                                dtPhucKhao.Rows.Add(dr)
                            End If
                        Next
                        dtPhucKhao.DefaultView.Sort = "So_bao_danh"
                        Dim frmESS_PhucKhao As New frmESS_ToChucThi_PhucKhao(dtPhucKhao, clsTCThi)
                        frmESS_PhucKhao.ShowDialog()
                        If frmESS_PhucKhao.Tag = 1 Then
                            trvPhongThi_Select()
                        End If

                    End If
                End If

            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDanhsachPK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If mHoc_ky <> 0 And mNam_hoc <> "" Then
                Dim dtPhucKhao As DataTable = clsTCThi.HienThi_ESSToChucThiPhucKhao_DanhSach_All(mHoc_ky, mNam_hoc)
                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("DS PHUC KHAO THI TAT CA", dtPhucKhao, "KẾT QUẢ PHÚC KHẢO THI", "THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc)
            Else
                Thongbao("Bạn phải chọn học kỳ đăng ký")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub mnuAdd_SV_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
        Try
            If mID_phong_thi > 0 Then

                Dim dv As DataView = grvDanhSachThi.DataSource
                Dim frmESS_ As New frmESS_ToChucThi_ThemSinhVien
                frmESS_.ShowDialog(dv, mHoc_ky, mNam_hoc, 1, mID_mon)
                If frmESS_.Tag = 1 Then
                    Dim dvDanhSachSinhVien As DataView
                    dvDanhSachSinhVien = frmESS_.grvDanhSachThiChon.DataSource
                    If Not dvDanhSachSinhVien Is Nothing AndAlso dvDanhSachSinhVien.Count > 0 Then
                        Dim So_sv As Integer = 0
                        For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                            If clsTCThi.ToChucThi(0).dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) < 0 Then
                                Dim objThiChiTiet As New ESSTochucThiChiTiet
                                objThiChiTiet.ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                                objThiChiTiet.ID_thi = mID_thi
                                objThiChiTiet.ID_phong_thi = mID_phong_thi
                                objThiChiTiet.OrderBy = "ZZZ"   'Đưa sinh viên vào cuối danh sách
                                clsTCThi.ThemMoi_ESSTochucThiChiTiet(objThiChiTiet)
                                So_sv += 1
                            End If
                        Next
                        If So_sv > 0 Then
                            'Load lại danh sách sinh viên
                            Call trvPhongThi_Select()
                            Thongbao("Đã thêm thành công " + So_sv.ToString + " sinh viên vào danh sách thi !")
                        Else
                            Thongbao("Những sinh viên này đã có trong danh sách thi !")
                        End If
                    End If
                End If
            Else
                Thongbao("Bạn phải chọn đến phòng thi để thêm sinh viên !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub mnuDelete_SV_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub cmdAdd_TCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd_TCT.Click
        Try
            Dim frmESS_ As New frmESS_ToChucThi
            mHoc_ky = trvPhongThi.Hoc_ky
            mNam_hoc = trvPhongThi.Nam_hoc
            frmESS_.ShowDialog(mHoc_ky, mNam_hoc)
            If frmESS_.Tag = 1 Then
                trvPhongThi.ReLoad()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdDelete_TCT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete_TCT.Click
        Try
            If mID_thi > 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá tổ chức thi không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    'Xoá sinh viên
                    clsTCThi.Xoa_ESSTochucThiChiTiet(mID_thi)
                    'Xoá phòng thi
                    clsTCThi.Xoa_ESSToChucThiTheoPhong(mID_thi, 0)
                    'Xoá tổ chức thi
                    clsTCThi.Xoa_ESSTochucThi(mID_thi)
                    'Load lại cây tổ chức thi
                    trvPhongThi.ReLoad()
                    'Load lại danh sách sinh viên
                    grcDanhSachThi.DataSource = Nothing
                    txtSo_sv.Text = 0
                    Thongbao("Đã xoá xong tổ chức thi !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try


    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = ""
            clsExcel.ExportFromDevGridViewToExcel(grvDanhSachThi, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdAdd_SV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd_SV.ItemClick
        Try
            If mID_phong_thi > 0 Then

                Dim dv As DataView = grvDanhSachThi.DataSource
                Dim frmESS_ As New frmESS_ToChucThi_ThemSinhVien
                frmESS_.ShowDialog(dv, mHoc_ky, mNam_hoc, 1, mID_mon)
                If frmESS_.Tag = 1 Then
                    Dim dvDanhSachSinhVien As DataView
                    dvDanhSachSinhVien = frmESS_.grvDanhSachThiChon.DataSource
                    If Not dvDanhSachSinhVien Is Nothing AndAlso dvDanhSachSinhVien.Count > 0 Then
                        Dim So_sv As Integer = 0
                        For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                            If clsTCThi.ToChucThi(0).dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) < 0 Then
                                Dim objThiChiTiet As New ESSTochucThiChiTiet
                                objThiChiTiet.ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                                objThiChiTiet.ID_thi = mID_thi
                                objThiChiTiet.ID_phong_thi = mID_phong_thi
                                objThiChiTiet.OrderBy = "ZZZ"   'Đưa sinh viên vào cuối danh sách
                                clsTCThi.ThemMoi_ESSTochucThiChiTiet(objThiChiTiet)
                                So_sv += 1
                            End If
                        Next
                        If So_sv > 0 Then
                            'Load lại danh sách sinh viên
                            Call trvPhongThi_Select()
                            Thongbao("Đã thêm thành công " + So_sv.ToString + " sinh viên vào danh sách thi !")
                        Else
                            Thongbao("Những sinh viên này đã có trong danh sách thi !")
                        End If
                    End If
                End If
            Else
                Thongbao("Bạn phải chọn đến phòng thi để thêm sinh viên !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_SV_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRemove_SV.ItemClick
        Try
            If mID_thi > 0 Then
                Dim dvDanhSachSinhVien As DataView
                Dim ID_sv As Integer, So_sv As Integer
                dvDanhSachSinhVien = grvDanhSachThi.DataSource
                If Not dvDanhSachSinhVien Is Nothing Then
                    So_sv = 0
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dvDanhSachSinhVien(i)("Chon") Then
                            ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                            clsTCThi.Xoa_ESSTochucThiChiTiet_SV(mID_thi, ID_sv)
                            So_sv += 1
                        End If
                    Next
                End If
                If So_sv > 0 Then
                    'Load lại danh sách sinh viên
                    Call trvPhongThi_Select()
                    Thongbao("Đã xoá thành công " + So_sv.ToString + " sinh viên ra khỏi danh sách thi !")
                Else
                    Thongbao("Bạn hãy chọn sinh viên để xoá !")
                End If
            Else
                Thongbao("Hãy chọn đợt tổ chức thi để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_DSThi1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi1.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSachThi.RowCount > 0 Then
                Dim dtDiemTH As New DataTable
                Dim mCa_thi As String = ""
                Dim mNhom_tiet As String = ""
                Dim mGio_thi As String = ""

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                mNgay_thi = trvPhongThi.Ngay_thi_Phong
                mCa_thi = trvPhongThi.Ca_thi_Phong
                mNhom_tiet = trvPhongThi.Nhom_tiet_phong
                mGio_thi = trvPhongThi.Gio_thi_Phong

                If mID_phong_thi <= 0 Then Exit Sub
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi")
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                    '    mGio_thi = dt.Rows(0).Item("Gio_thi")
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)
                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, mHoc_ky, mNam_hoc)
                       
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If


                Dim dv As DataView = dtDiemTH.DefaultView
                dv.Sort = "So_bao_danh"
                Dim Tieu_de1 As String = ""
                Dim Tieu_de2 As String = ""
                Dim Tieu_de3 As String = ""

                Tieu_de1 = "DANH SÁCH SINH VIÊN THI LẦN " & mLan_thi & " HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                Tieu_de2 = mTen_mon.ToUpper
                Tieu_de3 = "NGÀY THI: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy") & " - CA THI: " & mCa_thi.ToUpper & " - THỜI GIAN: " & mGio_thi & " - " & mPhong_thi.ToUpper

                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachTheoPhong", dv, Tieu_de1, Tieu_de2, Tieu_de3)
                f.ShowDialog()
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdRemove_SVDK_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRemove_SVDK.ItemClick
        If mID_thi > 0 Then
            Dim dvDanhSachSinhVien As DataView
            dvDanhSachSinhVien = grvDanhSachThi.DataSource
            If Not dvDanhSachSinhVien Is Nothing Then
                Dim So_sv As Integer = 0
                If clsTCThi.Count > 0 Then
                    Dim objTCThi As New ESSTochucThi
                    Dim idx_sv As Integer
                    objTCThi = clsTCThi.ToChucThi(0)
                    Dim dt_KDDK_duthi As DataTable = clsTCThi.DanhSachKDDK_DuThi(objTCThi.ID_thi)
                    dt_KDDK_duthi.DefaultView.Sort = "ID_SV"
                    Dim ID_sv As Integer = 0
                    For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                        If dt_KDDK_duthi.DefaultView.Find(dvDanhSachSinhVien.Item(i)("ID_sv")) >= 0 AndAlso objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv")) >= 0 Then
                            idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(dvDanhSachSinhVien.Item(i)("ID_sv"))
                            If idx_sv >= 0 Then
                                ID_sv = dvDanhSachSinhVien(i)("ID_sv")
                                clsTCThi.Xoa_ESSTochucThiChiTiet_SV(mID_thi, ID_sv)
                                So_sv += 1
                            End If
                        End If
                    Next

                End If
                If So_sv > 0 Then
                    Call trvPhongThi_Select()
                    txtSo_sv.Text = grvDanhSachThi.RowCount
                    Thongbao("Đã loại khỏi danh sách sinh viên không đủ điều kiện dự thi " + So_sv.ToString + " sinh viên ")
                End If
            End If

        End If
    End Sub

    Private Sub cmdPrint_All_DSThi2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_All_DSThi2.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSachThi.RowCount > 0 Then
                Dim mCa_thi, mNhom_tiet, mGio_thi As String
                mCa_thi = ""
                mNhom_tiet = ""
                mGio_thi = ""

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                        mGio_thi = dt.Rows(0).Item("Gio_thi")
                    End If
                    Dim dt_dsPhong As DataTable = clsTCThi.DanhSachPhongThi(mID_thi)
                    '
                    If mCa_thi = "0" Then mCa_thi = "Sáng"
                    If mCa_thi = "1" Then mCa_thi = "Chiều"
                    If mCa_thi = "2" Then mCa_thi = "Tối"
                    If mNhom_tiet = 0 Then
                        mNhom_tiet = 1
                    ElseIf mNhom_tiet = 1 Then
                        mNhom_tiet = 2
                    ElseIf mNhom_tiet = 2 Then
                        mNhom_tiet = 3
                    End If
                    '
                    For r As Integer = 0 To dt_dsPhong.Rows.Count - 1
                        Dim dtDiemTH As DataTable
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, dt_dsPhong.Rows(r).Item("ID_phong_thi"))
                        mPhong_thi = dt_dsPhong.Rows(r).Item("Ten_phong").ToString
                        dsID_lop = ""
                        If dtDanhSachSinhVien.Rows.Count > 0 Then
                            'Lấy danh sách các ID_lop
                            For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                                If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                    dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                End If
                            Next
                            If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                            'Load dữ liệu điểm
                            clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                            dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, mHoc_ky, mNam_hoc)
                        End If

                        dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                        dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                        dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                        dtDiemTH.Columns.Add("Lan_thi", GetType(String))
                        dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                        dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                        dtDiemTH.Columns.Add("Gio_thi", GetType(String))
                        dtDiemTH.Columns.Add("Hinh_thuc_thi", GetType(String))
                        dtDiemTH.Columns.Add("So_sv")

                        For i As Integer = 0 To dtDiemTH.Rows.Count - 1

                            dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                            dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                            dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon.Substring(mTen_mon.LastIndexOf(":") + 1)
                            dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                            dtDiemTH.Rows(i).Item("Ngay_thi") = mGio_thi & "-" & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                            dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                            dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                            dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                            dtDiemTH.Rows(i).Item("Gio_thi") = mGio_thi
                            dtDiemTH.Rows(i).Item("Hinh_thuc_thi") = cmbHinhthuc.Text
                            dtDiemTH.Rows(i).Item("So_sv") = dtDiemTH.Rows.Count
                        Next
                        Dim dv As DataView = dtDiemTH.DefaultView
                        dv.Sort = "So_bao_danh"

                        Dim Tieu_de1 As String = ""
                        Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                        If cmbHinhthuc.SelectedIndex = 0 Then
                            Dim frm As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_Viet", dtDiemTH.DefaultView, Tieu_de1)
                            frm.ShowDialog(True)
                        Else
                            Dim frm As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_VanDap", dtDiemTH.DefaultView, Tieu_de1)
                            frm.ShowDialog(True)
                        End If

                    Next
                End If
                Thongbao("Đã in xong danh sách đợt thi !")
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_All_DSThi1_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_All_DSThi1.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSachThi.RowCount > 0 Then
                Dim mCa_thi, mNhom_tiet, mGio_thi As String
                mCa_thi = ""
                mNhom_tiet = ""
                mGio_thi = ""

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    If dt.Rows.Count > 0 Then
                        mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                        mCa_thi = dt.Rows(0).Item("Ca_thi")
                        mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                        mGio_thi = dt.Rows(0).Item("Gio_thi")
                    End If
                    Dim dt_dsPhong As DataTable = clsTCThi.DanhSachPhongThi(mID_thi)
                    '
                    If mCa_thi = "0" Then mCa_thi = "Sáng"
                    If mCa_thi = "1" Then mCa_thi = "Chiều"
                    If mCa_thi = "2" Then mCa_thi = "Tối"
                    If mNhom_tiet = 0 Then
                        mNhom_tiet = 1
                    ElseIf mNhom_tiet = 1 Then
                        mNhom_tiet = 2
                    ElseIf mNhom_tiet = 2 Then
                        mNhom_tiet = 3
                    End If
                    '
                    For r As Integer = 0 To dt_dsPhong.Rows.Count - 1
                        Dim dtDiemTH As DataTable
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, dt_dsPhong.Rows(r).Item("ID_phong_thi"))
                        mPhong_thi = "Phòng thi: " & dt_dsPhong.Rows(r).Item("Ten_phong").ToString
                        dsID_lop = ""
                        If dtDanhSachSinhVien.Rows.Count > 0 Then
                            'Lấy danh sách các ID_lop
                            For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                                If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                    dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                                End If
                            Next
                            If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                            'Load dữ liệu điểm
                            clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                            dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, mHoc_ky, mNam_hoc)
                        End If

                        dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                        dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                        dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                        dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                        dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                        dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                        dtDiemTH.Columns.Add("Gio_thi", GetType(String))
                        dtDiemTH.Columns.Add("So_sv")

                        For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                            dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                            dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                            dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                            dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                            dtDiemTH.Rows(i).Item("Ngay_thi") = Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                            dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                            dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                            dtDiemTH.Rows(i).Item("Gio_thi") = mGio_thi
                            dtDiemTH.Rows(i).Item("So_sv") = dtDiemTH.Rows.Count
                        Next
                        Dim dv As DataView = dtDiemTH.DefaultView
                        dv.Sort = "So_bao_danh"

                        Dim Tieu_de1 As String = ""
                        Dim Tieu_de2 As String = ""
                        Dim Tieu_de3 As String = ""

                        Tieu_de1 = "DANH SÁCH SINH VIÊN THI HỌC KỲ " & mHoc_ky & " NĂM HỌC " & mNam_hoc
                        Tieu_de2 = mTen_mon.ToUpper
                        Tieu_de3 = "NGÀY THI: " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy") & " - CA THI: " & mCa_thi.ToUpper & " - THỜI GIAN: " & mGio_thi & " - PHÒNG THI: " & mPhong_thi.ToUpper

                        Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachTheoPhong", dv, Tieu_de1, Tieu_de2, Tieu_de3)
                        f.ShowDialog(True)

                    Next
                End If
                Thongbao("Đã in xong danh sách đợt thi !")
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdUpdate_SBD_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUpdate_SBD.ItemClick
        If grvDanhSachThi.RowCount < 0 Then Exit Sub
        Dim dv As DataView = grvDanhSachThi.DataSource
        If dv Is Nothing Then Exit Sub
        If dv.Count <= 0 Then Exit Sub
        Dim So_bao_danh As String = ""
        Dim ID_ds_thi As Integer = 0
        Dim sSo_bao_danh_trung As String = ""
        Dim sID_ds_thi As String = ""

        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                So_bao_danh = dv.Item(i)("So_bao_danh").ToString
                ID_ds_thi = dv.Item(i)("ID_ds_thi")
                If clsTCThi.CheckTrungSBDSinhVienTheoPhongThi(So_bao_danh, ID_ds_thi, mID_thi) = 1 Then
                    sSo_bao_danh_trung += " - " & So_bao_danh
                Else
                    clsTCThi.CapNhat_ESSTochucThiChiTiet_SBD(So_bao_danh, ID_ds_thi)
                End If
                sID_ds_thi += " - " & ID_ds_thi
            End If
        Next
        If sID_ds_thi.Length = 0 Then
            Thongbao("Bạn phải tích chọn sinh viên cần sửa SBD !", MsgBoxStyle.Information)
            Exit Sub
        End If

        If sSo_bao_danh_trung.Length > 0 Then
            Thongbao("Danh sách số báo danh " & sSo_bao_danh_trung & " trùng với số báo danh của sinh viên trong đợt thi", MsgBoxStyle.Information)
            Exit Sub
        Else
            Thongbao("Cập nhật thành công số báo danh của sinh viên !", MsgBoxStyle.Information)
        End If
    End Sub


    Private Sub cmdUpdate_GhiChu_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdUpdate_GhiChu.ItemClick

        If grvDanhSachThi.RowCount < 0 Then Exit Sub
        Dim dv As DataView = grvDanhSachThi.DataSource
        Dim f As Boolean = False
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then
                clsTCThi.CapNhat_ESSTochucThiChiTiet_GhiChu(dv.Item(i)("Ghi_chu_thi").ToString, dv.Item(i)("ID_ds_thi"))
                f = True
            End If
        Next
        If f = False Then
            Thongbao("Bạn phải tích chọn sinh viên cần sửa ghi chú !", MsgBoxStyle.Information)
            Exit Sub
        End If
        Thongbao("Cập nhật thành công số báo danh của sinh viên !", MsgBoxStyle.Information)
    End Sub

    Private Sub cmdPrint_DSThi2_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSThi2.ItemClick
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSachThi.RowCount > 0 Then
                Dim dtDiemTH As DataTable
                Dim mCa_thi, mNhom_tiet, mGio_thi As String
                mCa_thi = ""
                mNhom_tiet = ""
                mGio_thi = ""

                mHoc_ky = trvPhongThi.Hoc_ky
                mNam_hoc = trvPhongThi.Nam_hoc
                mID_mon = trvPhongThi.ID_mon
                mLan_thi = trvPhongThi.Lan_thi
                mID_thi = trvPhongThi.ID_thi
                mID_phong_thi = trvPhongThi.ID_phong_thi

                mNgay_thi = trvPhongThi.Ngay_thi_Phong
                mCa_thi = trvPhongThi.Ca_thi_Phong
                mNhom_tiet = trvPhongThi.Nhom_tiet_phong
                mGio_thi = trvPhongThi.Gio_thi_Phong

                mPhong_thi = trvPhongThi.Phong_thi.Substring(trvPhongThi.Phong_thi.LastIndexOf(":") + 1)
                If mID_thi > 0 Then
                    Dim ID_dv As String = gobjUser.ID_dv
                    Dim dsID_lop As String = ""
                    Dim dtDanhSachSinhVien As DataTable
                    'Load dữ liệu về tổ chức thi
                    clsTCThi = New TochucThi_Bussines(mID_thi)
                    'Dim dt As DataTable = clsTCThi.DanhSachMonToChucThi()
                    'If dt.Rows.Count > 0 Then
                    '    mNgay_thi = dt.Rows(0).Item("Ngay_thi")
                    '    mCa_thi = dt.Rows(0).Item("Ca_thi")
                    '    mNhom_tiet = dt.Rows(0).Item("Nhom_tiet")
                    '    mGio_thi = dt.Rows(0).Item("Gio_thi")
                    'End If
                    If mID_phong_thi > 0 Then   'Load sinh viên theo từng phòng thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoPhongThi(mID_thi, mID_phong_thi)

                    Else    'Load tất cả sinh viên của tổ chức thi
                        dtDanhSachSinhVien = clsTCThi.DanhSachSinhVienTheoDotThi(mID_thi)
                    End If
                    If dtDanhSachSinhVien.Rows.Count > 0 Then
                        'Lấy danh sách các ID_lop
                        For i As Integer = 0 To dtDanhSachSinhVien.Rows.Count - 1
                            If Not dsID_lop.Contains("," + dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ",") Then
                                dsID_lop += dtDanhSachSinhVien.Rows(i)("ID_lop").ToString + ","
                            End If
                        Next
                        If dsID_lop <> "" Then dsID_lop = Mid(dsID_lop, 1, Len(dsID_lop) - 1)
                        'Load dữ liệu điểm
                        clsDiem = New Diem_Bussines(ID_dv, mHoc_ky, mNam_hoc, mID_mon, dsID_lop, dtDanhSachSinhVien, True)
                        'If mLan_thi = 1 Then
                        dtDiemTH = clsDiem.DanhSachDiemThiLan1_ToChucThi(mID_mon, mHoc_ky, mNam_hoc)
                        'Else
                        '    dtDiemTH = clsDiem.DanhSachDiemThiLan(mLan_thi, mID_mon, True)
                        'End If
                    End If
                End If
                If mCa_thi = "0" Then mCa_thi = "Sáng"
                If mCa_thi = "1" Then mCa_thi = "Chiều"
                If mCa_thi = "2" Then mCa_thi = "Tối"
                If mNhom_tiet = 0 Then
                    mNhom_tiet = 1
                ElseIf mNhom_tiet = 1 Then
                    mNhom_tiet = 2
                ElseIf mNhom_tiet = 2 Then
                    mNhom_tiet = 3
                End If

                dtDiemTH.Columns.Add("Hoc_ky", GetType(String))
                dtDiemTH.Columns.Add("Nam_hoc", GetType(String))
                dtDiemTH.Columns.Add("Ten_mon", GetType(String))
                dtDiemTH.Columns.Add("Ngay_thi", GetType(String))
                dtDiemTH.Columns.Add("Lan_thi", GetType(String))
                dtDiemTH.Columns.Add("Ca_thi", GetType(String))
                dtDiemTH.Columns.Add("Nhom_tiet", GetType(String))
                dtDiemTH.Columns.Add("Gio_thi", GetType(String))
                dtDiemTH.Columns.Add("Hinh_thuc_thi", GetType(String))
                dtDiemTH.Columns.Add("So_sv")

                For i As Integer = 0 To dtDiemTH.Rows.Count - 1
                    dtDiemTH.Rows(i).Item("Hoc_ky") = mHoc_ky
                    dtDiemTH.Rows(i).Item("Nam_hoc") = mNam_hoc
                    dtDiemTH.Rows(i).Item("Ten_mon") = mTen_mon
                    dtDiemTH.Rows(i).Item("Ten_phong") = mPhong_thi
                    dtDiemTH.Rows(i).Item("Ngay_thi") = mGio_thi & " - " & Format(CType(mNgay_thi, Date), "dd/MM/yyyy")
                    dtDiemTH.Rows(i).Item("Lan_thi") = mLan_thi
                    dtDiemTH.Rows(i).Item("Ca_thi") = mCa_thi
                    dtDiemTH.Rows(i).Item("Nhom_tiet") = mNhom_tiet
                    dtDiemTH.Rows(i).Item("Gio_thi") = mGio_thi
                    dtDiemTH.Rows(i).Item("Hinh_thuc_thi") = cmbHinhthuc.Text
                    dtDiemTH.Rows(i).Item("So_sv") = dtDiemTH.Rows.Count
                Next
                Dim dv As DataView = dtDiemTH.DefaultView
                dv.Sort = "So_bao_danh"
                Dim Tieu_de1 As String = ""
                Tieu_de1 = "DANH SÁCH THI VÀ ĐIỂM THI KẾT THÚC HỌC PHẦN"
                If cmbHinhthuc.SelectedIndex = 0 Then
                    Dim frm As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_Viet", dtDiemTH.DefaultView, Tieu_de1)
                    frm.ShowDialog()
                Else
                    Dim frm As New frmESS_ReportView(gobjUser, "rptMARK_ToChucThi_DanhSachThi_VanDap", dtDiemTH.DefaultView, Tieu_de1)
                    frm.ShowDialog()
                End If
            Else
                Thongbao("Bạn phải chọn học phần tổ chức thi trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub BarButtonItem3_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdEdit_TT_PhongThi.ItemClick
        If mID_phong_thi <= 0 Then Exit Sub
        Dim frm As New frmToChucThiPhong_Sua
        'Dim obj As New TochucThi_Bussines
        mID_phong_thi = trvPhongThi.ID_phong_thi

        mNgay_thi = trvPhongThi.Ngay_thi_Phong
        Dim mCa_thi As Integer = trvPhongThi.Ca_thi_Phong
        Dim mNhom_tiet As Integer = trvPhongThi.Nhom_tiet_phong
        Dim mGio_thi As String = trvPhongThi.Gio_thi_Phong
        frm.ShowDialog(mID_phong_thi, mNgay_thi, mCa_thi, mNhom_tiet, mGio_thi)
    End Sub

    Private Sub cmdTongHop_NoHP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTongHop_NoHP.Click
        Try
            Dim dv As DataView = grcDanhSachThi.DataSource
            Dim clsBienLai As New BienLaiThu_Bussines
            Me.Cursor = Cursors.WaitCursor
            For i As Integer = 0 To dv.Count - 1
                Dim Ghi_chu As String = clsBienLai.TongHop_GhiChu_DiemDanh_ToChucThi(dv.Item(i)("ID_SV"), mHoc_ky, mNam_hoc, mID_mon).ToString.Trim
                If Ghi_chu.Trim <> "" Then
                    Ghi_chu = "KĐĐK (" & Ghi_chu & ")"
                End If

                Dim SoDu As Integer = clsBienLai.TongHopHocPhiSinhVien_SoDuCuoiKy(dv.Item(i)("ID_SV"))
                If SoDu < 0 Then
                    SoDu = 0 - SoDu
                    Ghi_chu = Ghi_chu & " Nợ HP (" & SoDu & ")"
                    'dv.Item(i)("Ghi_chu_thi") = "Nợ HP (" & SoDu & ")"
                    'clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), "Nợ HP (" & SoDu & ")")
                    'Else
                    '    dv.Item(i)("Ghi_chu_thi") = ""
                    '    clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), "")
                End If

                'If Ghi_chu.Trim = "" Then
                dv.Item(i)("Ghi_chu_thi") = Ghi_chu
                clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), Ghi_chu)
                'Else
                'dv.Item(i)("Ghi_chu_thi") = ""
                'clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), "")
                'End If
            Next
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
        trvPhongThi_Select()
    End Sub

    'Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
    '    Try
    '        Dim dv As DataView = grcDanhSachThi.DataSource
    '        Dim clsBienLai As New BienLaiThu_Bussines
    '        Me.Cursor = Cursors.WaitCursor
    '        For i As Integer = 0 To dv.Count - 1
    '            'If dv.Item(i)("ID_SV") = 468918 Then
    '            '    dv.Item(i)("ID_SV") = 468918
    '            'End If
    '            Dim Ghi_chu As String = clsBienLai.TongHop_GhiChu_DiemDanh_ToChucThi(dv.Item(i)("ID_SV"), mHoc_ky, mNam_hoc, mID_mon).ToString.Trim
    '            If Ghi_chu.Trim = "" Then
    '                clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), "")
    '            Else
    '                clsTCThi.CapNhat_GhiChu_NoHP(dv.Item(i)("ID_ds_thi"), "KĐĐK (" & clsBienLai.TongHop_GhiChu_DiemDanh_ToChucThi(dv.Item(i)("ID_SV"), mHoc_ky, mNam_hoc, mID_mon).ToString.Trim & ")")
    '            End If
    '        Next
    '    Catch ex As Exception
    '    End Try
    '    Me.Cursor = Cursors.Default
    '    trvPhongThi_Select()
    'End Sub
End Class