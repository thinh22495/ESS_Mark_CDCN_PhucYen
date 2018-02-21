Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Imports ESSReports

Public Class frmESS_KhungChuongTrinhDaoTao_DanhSach
    Private mID_dt As Integer = 0
    Private mID_he As Integer = 0
    Private Loader As Boolean = False
    Private clsDM As New DanhMuc_Bussines
    Private clsCTDT As ChuongTrinhDaoTao_Bussines
    Private dtKienThuc1 As DataTable
    Private clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, 1, -1)
#Region "User Function"

    Private Sub HienThi_ESSData_CTDT()
        'Load chương trình đào tạo
        clsCTDT = New ChuongTrinhDaoTao_Bussines(gobjUser.dsID_dt)
        grcCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
        grvChuongTrinhDaoTaoList.ExpandAllGroups()

    End Sub
#End Region
#Region "Form Events"
    Private Sub frmESS_ChuongTrinhDaoTaoList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            dtKienThuc1 = clsDM.DanhMuc_Load("PLAN_ChuongTrinhDaoTaoKienThuc", "ID_kien_thuc", "Ten_kien_thuc")
            Me.HienThi_ESSData_CTDT()
            SetQuyenTruyCap(cmdLuu, cmdAdd_CT, cmdCopy, cmdXoa_ESSCT)
            SetQuyenTruyCap(cmdUpdate_Diem, cmdAdd_HP, cmdImport, cmdRemove_HP)
            Loader = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoList_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoList_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
    Private Sub grvChuongTrinhDaoTaoList_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvChuongTrinhDaoTaoList.SelectionChanged
        Try
            If Loader Then
                If Not grvChuongTrinhDaoTaoList.GetFocusedDataRow Is Nothing Then
                    mID_dt = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("ID_dt")
                    mID_he = grvChuongTrinhDaoTaoList.GetFocusedDataRow()("ID_he")
                    'Load chương trình đào tạo chi tiết
                    clsCTDT.HienThi_ESSCTDTChiTiet(mID_dt)
                    'Hiển thị các học phần
                    grcCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt).DefaultView
                    lueKhoiKienThuc.DataSource = dtKienThuc1
                Else
                    grcCTDTChiTiet.DataSource = Nothing
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdLuu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLuu.Click
        Try

            Dim dvCTDT As DataView = grvChuongTrinhDaoTaoList.DataSource
            ''Update số tín chỉ ở chương trình đào tạo main

            Dim idx As Integer = 0
            For i As Integer = 0 To dvCTDT.Count - 1
                If dvCTDT.Item(i).Row.RowState = DataRowState.Modified Then
                    'Tìm chương trình đào tạo trên
                    idx = clsCTDT.Tim_idx(dvCTDT.Item(i)("ID_dt"))
                    If idx >= 0 Then
                        Dim objCTDT As New ESSChuongTrinhDaoTao
                        objCTDT = clsCTDT.ESSChuongTrinhDaoTao(idx)
                        'Gán số tín chỉ thay đổi trên DataGridView
                        objCTDT.So_hoc_trinh = dvCTDT.Item(i)("So_hoc_trinh")
                        objCTDT.So_ky_hoc = dvCTDT.Item(i)("So_Ky_hoc")
                        'Update vào database
                        clsCTDT.CapNhat_ESSChuongTrinhDaoTao(objCTDT, dvCTDT.Item(i)("ID_dt"))
                    End If
                End If
            Next
            'Update dữ liệu học phần ở chương trình đào tạo chi tiết
            'Dim dvCTDTChiTiet As DataView = grdViewCTDTChiTiet.DataSource
            Dim dvCTDTChiTiet As DataView = grvCTDTChiTiet.DataSource
            Dim idx1 As Integer = 0
            For i As Integer = 0 To dvCTDTChiTiet.Count - 1
                If dvCTDTChiTiet.Item(i).Row.RowState = DataRowState.Modified Then
                    'Tìm chương trình đào tạo
                    idx = clsCTDT.Tim_idx(dvCTDTChiTiet.Item(i)("ID_dt"))
                    If idx >= 0 Then
                        'Tìm Học phần
                        idx1 = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.Tim_idx(dvCTDTChiTiet.Item(i)("ID_mon"))
                        If idx1 >= 0 Then
                            Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
                            objCTDTChiTiet = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(idx1)
                            'Gán các dữ liệu thay đổi trên DataGridView vào đối tượng
                            objCTDTChiTiet.STT_mon = dvCTDTChiTiet.Item(i)("STT_mon")
                            objCTDTChiTiet.So_hoc_trinh = dvCTDTChiTiet.Item(i)("So_hoc_trinh")
                            objCTDTChiTiet.Ky_thu = dvCTDTChiTiet.Item(i)("Ky_thu")
                            objCTDTChiTiet.He_so = dvCTDTChiTiet.Item(i)("He_so")
                            objCTDTChiTiet.Ly_thuyet = dvCTDTChiTiet.Item(i)("Ly_thuyet")
                            objCTDTChiTiet.Thuc_hanh = dvCTDTChiTiet.Item(i)("Thuc_hanh")
                            objCTDTChiTiet.Bai_tap = dvCTDTChiTiet.Item(i)("Bai_tap")
                            objCTDTChiTiet.Bai_tap_lon = dvCTDTChiTiet.Item(i)("Bai_tap_lon")
                            objCTDTChiTiet.Tu_hoc = dvCTDTChiTiet.Item(i)("Tu_hoc")
                            objCTDTChiTiet.Tu_chon = dvCTDTChiTiet.Item(i)("Tu_chon")
                            objCTDTChiTiet.Khong_tinh_TBCHT = dvCTDTChiTiet.Item(i)("Khong_tinh_TBCHT")
                            objCTDTChiTiet.Kien_thuc = dvCTDTChiTiet.Item(i)("Kien_thuc")
                            objCTDTChiTiet.Nhom_tu_chon = dvCTDTChiTiet.Item(i)("Nhom_tu_chon")
                            objCTDTChiTiet.So_hoc_trinh_tien_quyet = dvCTDTChiTiet.Item(i)("So_hoc_trinh_tien_quyet")
                            objCTDTChiTiet.Ty_le_ly_thuyet = dvCTDTChiTiet.Item(i)("Ty_le_ly_thuyet")
                            objCTDTChiTiet.Ty_le_thuc_hanh = dvCTDTChiTiet.Item(i)("Ty_le_thuc_hanh")
                            objCTDTChiTiet.HP_tuong_duong = dvCTDTChiTiet.Item(i)("HP_tuong_duong")
                            objCTDTChiTiet.So_tien_tai_lieu = dvCTDTChiTiet.Item(i)("So_tien_tai_lieu")
                            objCTDTChiTiet.HocPhan_DaiCuong = dvCTDTChiTiet.Item(i)("HocPhan_DaiCuong")
                            'Update vào database
                            clsCTDT.CapNhat_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet, dvCTDTChiTiet.Item(i)("ID_dt_mon"))
                        End If
                    End If
                End If
            Next
            'Me.HienThi_ESSData_CTDT()
            Thongbao("Cập nhật thành công")


        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdAdd_CT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd_CT.ItemClick
        Try
            Dim frmESS_ As New frmESS_KhungChuongTrinhDaotao
            frmESS_.ShowDialog(clsCTDT)
            If frmESS_.Tag = "1" Then
                'Load lại chương trình đào tạo
                Me.grcCTDT.DataSource = clsCTDT.DanhSachChuongTrinhDaoTao.DefaultView
                'Thêm Học phần mới
                Dim frmESS_1 As New frmESS_KhungChuongTrinhDaoTao_ChonHocPhan
                Dim dtCTDTChiTiet As DataTable = grvCTDTChiTiet.DataSource.Table
                Dim ID_he, ID_dt_new As Integer
                ID_he = frmESS_.ID_he
                ID_dt_new = frmESS_.ID_dt_new
                frmESS_1.ShowDialog(clsCTDT, ID_he, ID_dt_new, dtCTDTChiTiet)
                If frmESS_1.Tag = "1" Then
                    'Hiển thị các học phần
                    grcCTDTChiTiet.DataSource = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(ID_dt_new).DefaultView
                    txtTong_so_mon.Text = grvCTDTChiTiet.DataSource.Count
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSCT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdXoa_ESSCT.ItemClick
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                If Thongbao("Chắc chắn bạn muốn xoá chương trình đào tạo này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(grvChuongTrinhDaoTaoList.GetSelectedRows.GetValue(0))
                    Dim ID_dt As Integer = row("ID_dt")
                    Dim idx As Integer
                    'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                    If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt) > 0 Then
                        idx = clsCTDT.Tim_idx(ID_dt)
                        If idx >= 0 Then
                            'Xoá các Học phần trong chương trình đào tạo khung
                            For i As Integer = 0 To clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.Count - 1
                                Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
                                objCTDTChiTiet = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(i)
                                clsCTDT.Xoa_ESSChuongTrinhDaoTaoChiTiet(objCTDTChiTiet.ID_dt_mon)
                            Next
                            'Xóa ràng buộc Học phần
                            For i As Integer = clsCTDT.ESSChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoRangBuoc.Count - 1 To 0 Step -1
                                Dim objCTDTRangBuoc As New ESSChuongTrinhDaoTaoMonHocRangBuoc
                                objCTDTRangBuoc = clsCTDT.ESSChuongTrinhDaoTao(idx).ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i)
                                clsCTDT.XoaMonRangBuoc(objCTDTRangBuoc.ID_dt, objCTDTRangBuoc.ID_mon, objCTDTRangBuoc.ID_mon_rb)
                            Next
                            ' Xóa nhóm tự chọn
                            For i As Integer = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoNhomTuChon.Count - 1 To 0 Step -1
                                Dim objCTDTNhomTuChon As New ESSChuongTrinhDaoTaoNhomTuChon
                                objCTDTNhomTuChon = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoNhomTuChon.ESSChuongTrinhDaoTaoNhomTuChon(i)
                                clsCTDT.XoaNhomTuChon(objCTDTNhomTuChon.ID_dt, objCTDTNhomTuChon.Nhom_tu_chon)
                            Next
                            'Save Log 
                            Dim Noi_dung As String
                            Noi_dung = "Xoá chương trình đào tạo"
                            Noi_dung += " Hệ " + clsCTDT.ESSChuongTrinhDaoTao(idx).Ten_he
                            Noi_dung += " Khoa " + clsCTDT.ESSChuongTrinhDaoTao(idx).Ten_khoa
                            Noi_dung += " Khoá " + clsCTDT.ESSChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                            Noi_dung += " Chuyên ngành " + clsCTDT.ESSChuongTrinhDaoTao(idx).Chuyen_nganh
                            SaveLog(LoaiSuKien.Xoa, Noi_dung)
                            'Xoá chương trình đào tạo
                            clsCTDT.Xoa_ESSChuongTrinhDaoTao(clsCTDT.ESSChuongTrinhDaoTao(idx).ID_dt)
                            'Xoá khỏi object
                            clsCTDT.Remove(idx)
                            HienThi_ESSData_CTDT()
                            Thongbao("Xoá chương trình đào tạo thành công")
                        End If
                    Else
                        Thongbao("Chương trình đào tạo này đã nhập điểm, bạn không thể xoá được")
                    End If
                End If
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để xoá")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdCopy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdCopy.ItemClick
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_KhungChuongTrinhDaotao_SaoChep

                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(grvChuongTrinhDaoTaoList.GetSelectedRows.GetValue(0))

                Dim dv As DataView = grvChuongTrinhDaoTaoList.DataSource
                Dim ID_he As Integer = row("ID_he")
                Dim ID_khoa As Integer = row("ID_khoa")
                Dim Khoa_hoc As Integer = row("Khoa_hoc")
                Dim ID_chuyen_nganh As Integer = row("ID_chuyen_nganh")
                Dim So As Integer = row("So")
                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_dt, So)
                'Load lại chương trình đào tạo mới tạo
                If frmESS_.Tag = "1" Then
                    Me.HienThi_ESSData_CTDT()
                    Thongbao("Đã sao chép thành công chương trình đào tạo")
                End If
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để sao chép")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdImport_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdImport.ItemClick
        Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_NhapKhau
        frmESS_.ShowDialog(clsCTDT)
        'Load lại chương trình đào tạo đã Imports
        If frmESS_.Tag = "1" Then
            Me.HienThi_ESSData_CTDT()
        End If
    End Sub

    Private Sub cmdAdd_HP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdAdd_HP.ItemClick
        Try
            Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_ChonHocPhan

            'Dim rowIndex As Integer = -1
            'rowIndex = grvCTDTChiTiet.GetSelectedRows.GetValue(0)
            'If rowIndex < 0 Then Exit Sub


            Dim dtCTDTChiTiet As DataTable = grvCTDTChiTiet.DataSource.Table
            frmESS_.ShowDialog(clsCTDT, mID_he, mID_dt, dtCTDTChiTiet)
            If frmESS_.Tag = "1" Then
                Me.HienThi_ESSData_CTDT()
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_HP_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdRemove_HP.ItemClick
        Try
            If (Not grvCTDTChiTiet.GetFocusedDataRow Is Nothing) AndAlso Thongbao("Chắc chắn bạn muốn xoá học phần này không?", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                
                Dim row As DataRow = grvCTDTChiTiet.GetFocusedDataRow()
                Dim ID_dt As Integer = row("ID_dt")
                Dim ID_mon As Integer = row("ID_mon")
                Dim Ten_mon As String = row("Ten_mon").ToString
                Dim ID_dt_mon As Integer = row("ID_dt_mon")
                Dim idx, idx1 As Integer
                'Kiểm tra xem chương trình đào tạo này đã nhập điểm chưa, nếu nhập rồi thì không cho xoá
                If Not clsCTDT.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt, ID_mon) > 0 Then
                    'Xoá trong CSDL
                    clsCTDT.Xoa_ESSChuongTrinhDaoTaoChiTiet(ID_dt_mon)
                    'Xoá object
                    idx = clsCTDT.Tim_idx(ID_dt)
                    If idx >= 0 Then
                        idx1 = clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.Tim_idx(ID_mon)
                        If idx1 >= 0 Then
                            clsCTDT.ESSChuongTrinhDaoTao(idx).ESSChuongTrinhDaoTaoChiTiet.Remove(idx1)
                        End If
                    End If
                    'Save Log 
                    Dim Noi_dung As String
                    Noi_dung = "Xoá học phần " + Ten_mon + " trong chương trình đào tạo"
                    Noi_dung += " Hệ " + clsCTDT.ESSChuongTrinhDaoTao(idx).Ten_he
                    Noi_dung += " Khoa " + clsCTDT.ESSChuongTrinhDaoTao(idx).Ten_khoa
                    Noi_dung += " Khoá " + clsCTDT.ESSChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                    Noi_dung += " Chuyên ngành " + clsCTDT.ESSChuongTrinhDaoTao(idx).Chuyen_nganh
                    SaveLog(LoaiSuKien.Xoa, Noi_dung)
                    'Xoa DataGridView
                    grvCTDTChiTiet.DeleteRow(grvCTDTChiTiet.FocusedRowHandle)
                    Thongbao("Xoá học phần thành công")
                Else
                    Thongbao("Học phần này đã nhập điểm, bạn không thể xoá được")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_TheoKy_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_TheoKy.ItemClick
        Try
            Dim dv1 As DataView = grvCTDTChiTiet.DataSource
            Dim Tieu_de1 As String = ""
            If grvCTDTChiTiet.RowCount > 0 Then
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetFocusedDataRow()
                Tieu_de1 = "HỆ: " & row("Ten_he").ToString.ToUpper & "  KHOÁ: " & row("Khoa_hoc").ToString.ToUpper & "  CHUYÊN NGÀNH: " & row("Ten_chuyen_nganh").ToString.ToUpper
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ChuongTrinhDaoTaoKhung1", dv1, Tieu_de1)
                f.ShowDialog()
            End If
         
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdPrint_TheoKhoiKT_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_TheoKhoiKT.ItemClick
        Try
            Dim dv1 As DataView = grvCTDTChiTiet.DataSource
            Dim Tieu_de1 As String = ""
            If grvCTDTChiTiet.RowCount > 0 Then
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetFocusedDataRow()
                Tieu_de1 = "HỆ: " & row("Ten_he").ToString.ToUpper & "  KHOÁ: " & row("Khoa_hoc").ToString.ToUpper & "  CHUYÊN NGÀNH: " & row("Ten_chuyen_nganh").ToString.ToUpper
                Dim f As New frmESS_ReportView(gobjUser, "rptMARK_ChuongTrinhDaoTaoKhung", dv1, Tieu_de1)
                f.ShowDialog()
            End If
           
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdNhomTuChon_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdNhomTuChon.Click
        Try
            Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_NhomTuChon

            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)

                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập nhóm Học phần tự chọn !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Try
            Dim frm As New frmESS_frmESS_KhungChuongTrinhDaoTao_ThietLapMonChungChi
            If Not grvCTDTChiTiet.GetFocusedDataRow Is Nothing Then
                Dim ID_dt As Integer = grvCTDTChiTiet.GetFocusedDataRow()("ID_dt")
                frm.ShowDialog(ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập nhóm môn tự chọn !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdGanLop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGanLop.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_GanLop
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)
                Dim ID_he As Integer = row("ID_he")
                Dim ID_khoa As Integer = row("ID_khoa")
                Dim Khoa_hoc As Integer = row("Khoa_hoc")
                Dim ID_chuyen_nganh As Integer = row("ID_chuyen_nganh")
                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để gán lớp")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRangBuoc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRangBuoc.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_HocPhanRangBuoc
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)

                Dim ID_dt As Integer = row("ID_dt")
                frmESS_.ShowDialog(clsCTDT, ID_dt)
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập các ràng buộc !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        'Me.HienThi_ESSData_CTDT()
        Dim frm As New frmESS_TongHop_MonNhapDiem_ThanhPhan_LopTinChi
        frm.ShowDialog()
    End Sub

    Private Sub cmdHP_TuongDuong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHP_TuongDuong.Click
        Try
            If grvChuongTrinhDaoTaoList.RowCount > 0 Then
                Dim frmESS_ As New frmESS_KhungChuongTrinhDaoTao_HocPhanTuongDuong
                Dim rowIndex As Integer = -1
                rowIndex = grvChuongTrinhDaoTaoList.GetSelectedRows().GetValue(0)
                Dim row As DataRow = grvChuongTrinhDaoTaoList.GetDataRow(rowIndex)

                Dim ID_dt As Integer = row("ID_dt")

                frmESS_.ShowDialog(clsCTDT, ID_dt, row("ID_he"))
            Else
                Thongbao("Bạn hãy chọn 1 chương trình đào tạo để thiết lập các ràng buộc !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_ID_DT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave_ID_DT.Click
        Dim dt As DataTable
        Dim clsDiem As New Diem_Bussines
        Dim clsDM As New DanhMuc_Bussines
        Dim SQL As String = "SELECT DISTINCT d.ID_SV,ID_dt,c.ID_mon FROM STU_DanhSachLopTinCHi a " & _
                            "INNER JOIN PLAN_LopTinCHi_TC b ON a.ID_lop_tc=b.ID_lop_tc " & _
                            "INNER JOIN PLAN_MonTinChi_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                            "INNER JOIN STU_DanhSachNganh2 d ON a.ID_SV=d.ID_SV WHERE Chuyen_nganh2=1 "
        dt = clsDM.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                Try
                    clsDiem.Update_Diem_ID_dt(dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_mon"), dt.Rows(i).Item("ID_dt"))
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Next
        Thongbao("Chuẩn hóa dữ liệu điểm Ngành 2 thành công !", MsgBoxStyle.Information)
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        'Dim dt As DataTable
        'Dim clsDiem As New Diem_Bussines
        'Dim clsDM As New DanhMuc_Bussines
        'Dim SQL As String = "SELECT DISTINCT ID_SV,ID_sv_ FROM STU_HOSOSINHVIEN"
        'dt = clsDM.LoadDanhMuc(SQL)
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    Try
        '        Try
        '            clsDM.Execute("UPDATE ACC_BienLaiThu_TMP SET ID_SV=" & dt.Rows(i)("ID_SV_") & " WHERE ID_SV=" & dt.Rows(i)("ID_SV"))
        '        Catch ex As Exception
        '        End Try
        '    Catch ex As Exception
        '    End Try
        'Next
        'Thongbao("Chuẩn hóa dữ liệu điểm Ngành 2 thành công !", MsgBoxStyle.Information)

        Dim dt1 As DataTable
        Dim clsDiem As New Diem_Bussines
        Dim clsDM As New DanhMuc_Bussines
        Dim SQL As String = ""

        Dim dt2 As DataTable = clsDM.LoadDanhMuc("SELECT ID_sv,ID_dt FROM STU_DanhSachNganh2")
        For i As Integer = 0 To dt2.Rows.Count - 1
            dt1 = clsDM.LoadDanhMuc("SELECT ID_dt FROM STU_DanhSach a INNER JOIN STU_Lop b ON a.ID_lop=b.ID_lop WHERE Lop_chuyen_nganh=1 AND ID_sv=" & dt2.Rows(i)("ID_SV"))
            If dt1.Rows.Count > 0 Then
                SQL = "SELECT ID_SV,a.ID_diem,Hoc_ky_thi,Nam_hoc_thi,ID_mon FROM MARK_Diem_TC a INNER JOIN MARK_DiemThi_TC b ON a.ID_diem=b.ID_diem " & _
                        "WHERE ID_SV =" & dt2.Rows(i)("ID_SV") & _
                        " AND ID_mon not in (SELECT ID_mon FROM PLAN_ChuongTrinhDaoTaoChiTiet WHERE ID_dt=" & dt1.Rows(0)("ID_dt") & ")"

                Dim dt_diem As DataTable = clsDM.LoadDanhMuc(SQL) ' Loc tat ca cac hoc phan khong thuoc nganh 1 cho nganh 2 update
                For d As Integer = 0 To dt_diem.Rows.Count - 1
                    Dim dt_TP As DataTable = clsDM.LoadDanhMuc("SELECT ID_diem FROM MARK_DiemThanhPhan_TC WHERE ID_diem =" & dt_diem.Rows(d)("ID_diem"))
                    Dim dt_Thi As DataTable = clsDM.LoadDanhMuc("SELECT ID_diem FROM MARK_DiemThi_TC WHERE ID_diem =" & dt_diem.Rows(d)("ID_diem"))
                    'Xoa du lieu diem thua de update ID_dt cho nganh2
                    If dt_TP.Rows.Count = 0 And dt_Thi.Rows.Count = 0 Then Connect.Execute("DELETE MARK_Diem_TC WHERE ID_diem=" & dt_diem.Rows(d)("ID_diem"))
                    'Loc cac HP lop tin chi de Update trang thai nganh 2
                    SQL = "SELECT a.ID_lop_tc,ID_SV FROM PLAN_LopTinChi_TC a " & _
                            "INNER JOIN PLAN_MonTinChi_TC b ON a.ID_mon_tc=b.ID_mon_tc " & _
                            "INNER JOIN PLAN_HocKyDangKy_TC c ON b.Ky_dang_ky=c.Ky_dang_ky " & _
                            "INNER JOIN STU_DanhSachlopTinChi d ON a.ID_lop_tc=d.ID_lop_tc " & _
                            "WHERE ID_SV=" & dt_diem.Rows(d)("ID_SV") & " AND ID_mon=" & dt_diem.Rows(d)("ID_mon") & " AND Hoc_ky=" & dt_diem.Rows(d)("Hoc_ky_thi") & " AND Nam_hoc='" & dt_diem.Rows(d)("Nam_hoc_thi") & "'"
                    Dim dt_lop_nganh2 As DataTable = clsDM.LoadDanhMuc(SQL)
                    For l As Integer = 0 To dt_lop_nganh2.Rows.Count - 1
                        Try
                            Try
                                'Update Nganh hoc 2
                                Connect.Execute("UPDATE STU_DanhSachlopTinChi SET Chuyen_Nganh2=1 WHERE ID_SV=" & dt_lop_nganh2.Rows(l).Item("ID_SV") & " AND ID_lop_tc=" & dt_lop_nganh2.Rows(l)("ID_lop_tc"))
                                'Update diem nganh 2
                                clsDiem.Update_Diem_ID_dt(dt_diem.Rows(d).Item("ID_SV"), dt_diem.Rows(d).Item("ID_mon"), dt2.Rows(i).Item("ID_dt"))
                            Catch ex As Exception
                            End Try
                        Catch ex As Exception
                        End Try
                    Next
                Next
            End If
        Next
        Thongbao("Chuẩn hóa dữ liệu điểm Ngành 2 thành công !", MsgBoxStyle.Information)
    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click
        Dim dt As DataTable
        Dim clsDiem As New Diem_Bussines
        Dim clsDM As New DanhMuc_Bussines
        Dim SQL As String = "SELECT ID_diem,Tinh_tich_luy FROM ESS_CDCN_PhucYen_New.DBO.MARK_Diem_TC"
        dt = clsDM.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                Try
                    SQL = "UPDATE MARK_Diem_TC SET Tinh_tich_luy=" & IIf(dt.Rows(i)("Tinh_tich_luy"), 1, 0) & " WHERE ID_diem=" & dt.Rows(i)("ID_diem")
                    clsDM.Execute(SQL)
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Next
        Thongbao("Chuẩn hóa dữ liệu điểm Ngành 2 thành công !", MsgBoxStyle.Information)
    End Sub

    Private Sub SimpleButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton3.Click
        Dim dt As DataTable
        Dim clsDiem As New Diem_Bussines
        Dim clsDM As New DanhMuc_Bussines
        Dim SQL As String = "SELECT * FROM MARK_Diem_TC WHERE ID_mon=1043 AND Hoc_ky=2 AND Nam_hoc='2012-2013'"
        dt = clsDM.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i)("ID_SV") = 464276 Then
                dt.Rows(i)("ID_SV") = 464276
            End If
            Try
                SQL = "SELECT ID_diem,ID_sv,ID_mon,ID_dt FROM MARK_Diem_TC WHERE ID_mon=" & dt.Rows(i)("ID_mon") & " AND ID_sv=" & dt.Rows(i)("ID_SV")
                Dim dt_sub As DataTable = clsDM.LoadDanhMuc(SQL)
                Try
                    If dt_sub.Rows.Count > 0 Then
                        SQL = "UPDATE MARK_DiemThi_TC SET ID_Diem=" & dt_sub.Rows(0)("ID_Diem") & " WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE ID_mon=" & dt_sub.Rows(0)("ID_mon") & " AND ID_sv= " & dt_sub.Rows(0)("ID_sv") & " AND ID_dt=" & dt_sub.Rows(0)("ID_dt") & ")"
                        clsDM.Execute(SQL)
                        SQL = "UPDATE MARK_DiemThanhPhan_TC SET ID_Diem=" & dt_sub.Rows(0)("ID_Diem") & " WHERE ID_diem in (SELECT ID_diem FROM MARK_Diem_TC WHERE ID_mon=" & dt_sub.Rows(0)("ID_mon") & " AND ID_sv= " & dt_sub.Rows(0)("ID_sv") & " AND ID_dt=" & dt_sub.Rows(0)("ID_dt") & ")"
                        clsDM.Execute(SQL)
                    End If
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Next
        Thongbao("Chuẩn hóa dữ liệu thành công !", MsgBoxStyle.Information)
    End Sub
End Class