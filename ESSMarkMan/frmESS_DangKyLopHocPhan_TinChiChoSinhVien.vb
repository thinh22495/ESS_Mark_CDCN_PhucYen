Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSReports
Public Class frmESS_DangKyLopHocPhan_TinChiChoSinhVien
    Private Loader As Boolean = False
    Private ID_sv As Integer = 0
    Private ID_dt As Integer = 0
    Private Hoc_ky As Integer = 0
    Private Nam_hoc As String = ""
    Private So_hoc_trinh_min As Integer = 0
    Private So_hoc_trinh_max As Integer = 0
    Private So_hoc_trinh_option As Integer = 0
    Private Check_So_hoc_trinh_max As Boolean = False
    Private Check_So_hoc_trinh_min As Boolean = False
    Private Chuyen_nganh_dang_ky As Integer = 1
    Private Phan_tram_MG As Integer = 0
    Private dtLopDuocDK, dtLopDaDK, dtTKBLopDuocDK, dtTKBLopDaDK, dtDiem, dtCTDT, dtNhomTuChon As DataTable
    Private objSV As ESSThongTinSinhVien
    Private mTen_khoa As String = ""
    Private Khong_kiem_tra_rb_mon As Double = 0
    Private Khong_kiem_tra_rb_mon_Active As Boolean = False
    Dim clsHeThong As New ThamSoHeThong_Bussines()

#Region "User function"



    Private Sub XoaHocPhanTichLuy(ByVal dtDiem As DataTable, ByVal dtHPDuocDK As DataTable)
        Try
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                For j As Integer = dtHPDuocDK.Rows.Count - 1 To 0 Step -1
                    If dtDiem.Rows(i)("ID_mon") = dtHPDuocDK.Rows(j)("ID_mon") Then
                        '+++++++++++++++Cho đăng ký tẹt ga - Tùngnk+++++++++++
                        'If dtDiem.Rows(i)("Tich_luy") Thenr
                        '    dtHPDuocDK.Rows(j).Delete()
                        '    dtHPDuocDK.AcceptChanges()
                        'Else
                        If dtDiem.Rows(i)("Hoc_lai") Then dtHPDuocDK.Rows(j)("Hoc_lai") = "X"
                        'End If
                    End If
                Next
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TinhHocPhanDangKy(ByVal dt As DataTable)
        Try
            Dim Tong_so_tien, Tong_So_hoc_trinh As Integer
            Dim So_mon As Integer = 0
            Dim Ky_hieu As String = ""
            Dim So_tien_mien_giam As Integer
            dt.DefaultView.Sort = "Ky_hieu"
            If Not dt Is Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("So_tien").ToString <> "" Then
                        If dt.Rows(i)("Hoc_lai").ToString = "" Then
                            So_tien_mien_giam = dt.Rows(i)("So_tien") * Phan_tram_MG / 100
                        Else
                            So_tien_mien_giam = 0
                        End If
                        Tong_so_tien += dt.Rows(i)("So_tien") - So_tien_mien_giam
                    End If
                    ' Kiểm tra trong trường hợp học phần tín chỉ có cả lớp LT và TH
                    If dt.Rows(i)("Ky_hieu") <> Ky_hieu Then
                        If dt.Rows(i)("So_tin_chi").ToString <> "" Then
                            Tong_So_hoc_trinh += dt.Rows(i)("So_tin_chi").ToString
                            Ky_hieu = dt.Rows(i)("Ky_hieu")
                        End If
                        So_mon += 1
                    Else
                        Ky_hieu = ""
                    End If
                Next
                lblSo_mon.Text = So_mon.ToString
                lblSo_tien_nop.Text = Format(Tong_so_tien, "###,###")
                lblSo_hoc_trinh.Text = Tong_So_hoc_trinh.ToString
                lblSo_hoc_trinh_min.Text = So_hoc_trinh_min
                lblSo_hoc_trinh_max.Text = So_hoc_trinh_max
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub UpdateHocPhanHocLai(ByVal dtDiem As DataTable, ByVal dtHPDuocDK As DataTable)
        Try
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                For j As Integer = dtHPDuocDK.Rows.Count - 1 To 0 Step -1
                    If dtDiem.Rows(i)("ID_mon") = dtHPDuocDK.Rows(j)("ID_mon") Then
                        If dtDiem.Rows(i)("Hoc_lai") Then dtHPDuocDK.Rows(j)("Hoc_lai") = "X"
                    End If
                Next
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Function KiemTraTKB(ByVal ID_lop_tc As Integer, ByVal dtTKBLopDuocDK As DataTable, ByVal dtTKBLopDaDK As DataTable) As Boolean
        Try
            Dim thu, thu1, tiet, tiet1, So_tiet, So_tiet1 As Integer
            Dim Tu_ngay, Den_ngay, Tu_ngay1, Den_ngay1 As Date
            For i As Integer = 0 To dtTKBLopDuocDK.Rows.Count - 1
                If dtTKBLopDuocDK.Rows(i)("ID_lop_tc") = ID_lop_tc Then
                    thu = dtTKBLopDuocDK.Rows(i)("thu")
                    tiet = dtTKBLopDuocDK.Rows(i)("tiet")
                    Tu_ngay = dtTKBLopDuocDK.Rows(i)("Tu_ngay")
                    Den_ngay = dtTKBLopDuocDK.Rows(i)("Den_ngay")
                    So_tiet = dtTKBLopDuocDK.Rows(i)("So_tiet")
                    For j As Integer = 0 To dtTKBLopDaDK.Rows.Count - 1
                        'dtLopDaDK.DefaultView.RowFilter = "ID_lop_tc=" & dtTKBLopDaDK.Rows(j)("ID_lop_tc")
                        'If dtLopDaDK.DefaultView.Count > 0 Then


                        'End If
                        'If dtTKBLopDaDK.Rows(j)("Rut_bot_hoc_phan") = False Then
                        If dtTKBLopDaDK.Rows(j)("Rut_bot_hoc_phan").ToString = "" Or (dtTKBLopDaDK.Rows(j)("Rut_bot_hoc_phan").ToString <> "" AndAlso dtTKBLopDaDK.Rows(j)("Rut_bot_hoc_phan") = False) Then
                            thu1 = dtTKBLopDaDK.Rows(j)("thu")
                            tiet1 = dtTKBLopDaDK.Rows(j)("tiet")
                            Tu_ngay1 = dtTKBLopDaDK.Rows(j)("Tu_ngay")
                            Den_ngay1 = dtTKBLopDaDK.Rows(j)("Den_ngay")
                            So_tiet1 = dtTKBLopDaDK.Rows(j)("So_tiet")
                            'Kiểm tra trùng thứ
                            If thu = thu1 And thu >= 0 And thu1 >= 0 Then
                                'Kiểm tra trùng tiết
                                If (tiet >= tiet1 And tiet <= tiet1 + So_tiet1 - 1) Or (tiet1 >= tiet And tiet1 <= tiet + So_tiet - 1) Then
                                    'Kiểm tra trùng ngày
                                    If (Tu_ngay >= Tu_ngay1 And Tu_ngay <= Den_ngay1) Or (Den_ngay >= Tu_ngay1 And Den_ngay <= Den_ngay1) _
                                        Or (Tu_ngay1 >= Tu_ngay And Tu_ngay1 <= Den_ngay) Or (Den_ngay1 >= Tu_ngay And Den_ngay1 <= Den_ngay) Then
                                        Return False
                                    End If
                                End If
                            End If
                        End If
                    Next
                End If
            Next
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function KiemTraTrungMon(ByVal ID_mon As Integer, ByVal ID_lop_lt As Integer, ByVal dtLopDaDK As DataTable) As Boolean
        Try
            For i As Integer = 0 To dtLopDaDK.Rows.Count - 1
                If dtLopDaDK.Rows(i)("ID_mon") = ID_mon And CInt("0" + dtLopDaDK.Rows(i)("ID_lop_lt").ToString) = ID_lop_lt Then
                    Thongbao("Học phần này đã đăng ký lớp rồi, không đăng ký được nữa")
                    Return False
                End If
            Next
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function

    Private Function KiemTraDangKyToiDa(ByVal So_hoc_trinh_max As Integer, ByVal So_hoc_trinh_dk As Integer, ByVal dtMonDK As DataTable) As Boolean
        Try
            If Check_So_hoc_trinh_max Then
                Dim So_hoc_trinh As Integer
                For i As Integer = 0 To dtMonDK.Rows.Count - 1
                    So_hoc_trinh += dtMonDK.Rows(i)("So_tin_chi")
                Next
                If So_hoc_trinh + So_hoc_trinh_dk > So_hoc_trinh_max Then
                    Thongbao("Bạn đăng ký vượt số tín chỉ tối đa cho php là: " + So_hoc_trinh_max.ToString)
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function KiemTraDangKyToiThieu(ByVal So_hoc_trinh_min As Integer, ByVal dtMonDK As DataTable) As Boolean
        Try
            If Check_So_hoc_trinh_min Then
                Dim So_hoc_trinh As Integer
                For i As Integer = 0 To dtMonDK.Rows.Count - 1
                    So_hoc_trinh += dtMonDK.Rows(i)("So_tin_chi")
                Next
                If So_hoc_trinh < So_hoc_trinh_min Then
                    Thongbao("Bạn chưa đăng ký đủ số tín chỉ tối thiểu là: " + So_hoc_trinh_min.ToString)
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function KiemTraRangBuoc(ByVal ID_mon As Integer, ByVal dtDiem As DataTable, ByVal dtCTDT As DataTable, ByVal dtMonDK As DataTable) As Boolean
        Try
            Dim ID_mon_rb, Loai_rang_buoc As Integer
            Dim Hoc_phan_rb As String = ""
            'Số tín chỉ tối đa
            'Kiểm tra logic Học phần: Tiên quyết, học trước, xong hành
            For i As Integer = 0 To dtCTDT.Rows.Count - 1
                If dtCTDT.Rows(i)("ID_mon") = ID_mon Then
                    ID_mon_rb = CInt("0" + dtCTDT.Rows(i)("ID_mon_rb").ToString)
                    Loai_rang_buoc = CInt("0" + dtCTDT.Rows(i)("Loai_rang_buoc").ToString)
                    Hoc_phan_rb = dtCTDT.Rows(i)("Ten_mon_rb").ToString
                    Exit For
                End If
            Next
            If ID_mon_rb > 0 Then

                Select Case Loai_rang_buoc
                    Case 1  'Tiên quyết
                        If DiemMonRangBuoc(ID_mon_rb, dtDiem) < 4 Then
                            Thongbao("Điều kiện Tiên quyết: Để đăng ký được học phần này, bạn phải đăng ký học phần " + Hoc_phan_rb + " và có điểm TBCMH >=4")
                            Return False
                        End If
                    Case 2  'Học trước
                        If DiemMonRangBuoc(ID_mon_rb, dtDiem) = -1 Then
                            Thongbao("Điều kiện học trước: Để đăng ký được học phần này, bạn phải đăng ký học phần " + Hoc_phan_rb + " có điểm TBCMH>=0")
                            Return False
                        End If
                    Case 3  'Song hành
                        If Not ExistMonSongHanh(ID_mon_rb, dtMonDK) Then
                            Thongbao("Điều kiện song hành: Để đăng ký được học phần này, bạn phải đăng ký học phần " + Hoc_phan_rb)
                            Return False
                        End If
                End Select
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function KiemTraNhomTuChon(ByVal Nhom_tu_chon As Integer, ByVal dtNhomTuChon As DataTable, ByVal dtMonDK As DataTable) As Boolean
        Try
            If Nhom_tu_chon > 0 Then
                Dim So_mon_dang_ky As Integer = 0
                Dim So_mon_da_dang_ky As Integer = 0
                Dim So_mon_tu_chon As Integer = 0
                For i As Integer = 0 To dtNhomTuChon.Rows.Count - 1
                    If dtNhomTuChon.Rows(i)("Nhom_tu_chon") = Nhom_tu_chon Then
                        So_mon_dang_ky = dtNhomTuChon.Rows(i)("So_mon_dang_ky")
                        So_mon_tu_chon = dtNhomTuChon.Rows(i)("So_mon_tu_chon")
                        Exit For
                    End If
                Next
                'Tinh so mon sv da dang ky thuoc nhom
                For i As Integer = 0 To dtMonDK.Rows.Count - 1
                    If dtMonDK.Rows(i)("Nhom_tu_chon") = Nhom_tu_chon Then
                        So_mon_da_dang_ky += 1
                    End If
                Next
                If So_mon_da_dang_ky > 0 And So_mon_dang_ky > 0 And So_mon_da_dang_ky >= So_mon_dang_ky Then
                    Thongbao("Bạn chỉ được đăng ký " + So_mon_dang_ky.ToString + " Học phần trong tổng số " + So_mon_tu_chon.ToString + " tự chọn")
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function DiemMonRangBuoc(ByVal ID_mon_rb As Integer, ByVal dtDiem As DataTable) As Integer
        Try
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("ID_mon") = ID_mon_rb Then
                    Return dtDiem.Rows(i)("TBCMH")
                End If
            Next
            Return -1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function ExistMonSongHanh(ByVal ID_mon As Integer, ByVal dtMonDK As DataTable) As Boolean
        Try
            For i As Integer = 0 To dtMonDK.Rows.Count - 1
                If dtMonDK.Rows(i)("ID_mon") = ID_mon Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Sub UpDateThoiGian(ByVal dtLop As DataTable, ByVal dtTKB As DataTable)
        Try
            Dim Thoi_gian As String = ""
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Thoi_gian", GetType(String))
            For i As Integer = 0 To dtLop.Rows.Count - 1
                If dtLop.Rows(i)("ID_lop_lt") = 0 Then
                    dtLop.Rows(i)("Ten_lop_tc") = dtLop.Rows(i)("Ky_hieu_lop_tc") + "." + dtLop.Rows(i)("STT_lop").ToString + "_LT"
                Else
                    dtLop.Rows(i)("Ten_lop_tc") = dtLop.Rows(i)("Ky_hieu_lop_tc") + "." + dtLop.Rows(i)("STT_lop").ToString + "_TH" + "." + dtLop.Rows(i)("STT_lop_lt").ToString
                End If
                Thoi_gian = ""
                For j As Integer = 0 To dtTKB.Rows.Count - 1
                    If dtLop.Rows(i)("ID_lop_tc") = dtTKB.Rows(j)("ID_lop_tc") Then
                        If dtTKB.Rows(j)("tiet") >= 0 Then
                            If Thoi_gian = "" Then
                                Thoi_gian = Format(dtTKB.Rows(j)("Tu_ngay"), "dd/MM/yy").ToString + "-" + Format(dtTKB.Rows(j)("Den_ngay"), "dd/MM/yy").ToString + "-"
                            End If
                            If dtTKB.Rows(j)("thu") <= 5 Then
                                Thoi_gian += "Thứ " + (dtTKB.Rows(j)("thu") + 2).ToString + "(T" + (dtTKB.Rows(j)("tiet") + 1).ToString + "-" + (dtTKB.Rows(j)("tiet") + dtTKB.Rows(j)("So_tiet")).ToString + ")"
                            Else
                                Thoi_gian += "Chủ nhật" + "(T" + (dtTKB.Rows(j)("tiet") + 1).ToString + "-" + (dtTKB.Rows(j)("tiet") + dtTKB.Rows(j)("So_tiet")).ToString + ")"
                            End If
                        End If
                    End If
                Next
                dtLop.Rows(i)("Thoi_gian") = Thoi_gian
            Next
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub UpDateTableTKB(ByVal ID_lop_tc As Integer, ByVal dtTKB1 As DataTable, ByVal dtTKB2 As DataTable)
        Try
            For i As Integer = dtTKB1.Rows.Count - 1 To 0 Step -1
                If dtTKB1.Rows(i)("ID_lop_tc") = ID_lop_tc Then
                    Dim dr As DataRow = dtTKB2.NewRow
                    dr.ItemArray = dtTKB1.Rows(i).ItemArray
                    dtTKB2.Rows.Add(dr)
                    dtTKB1.Rows.RemoveAt(i)
                End If
            Next
            dtTKB1.AcceptChanges()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadDangKy()
        Try
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            Dim dsID_mon_tc As String = ""
            Dim dtHPDuocDK As DataTable

            Dim clsDiem As New BangDiemCaNhan_Bussines("P1", ID_sv, ID_dt, 0, "", True) 'Load bang diem sinh vien
            Dim ID_xep_hang_hoc_luc As Integer
            'Bảng điểm của sinh viên để kiểm tra điều kiện tiên quyết, học trước
            dtDiem = clsDiem.BangDiem()
            'Xếp hạng học lực để áp dụng số tín chỉ đăng ký hạng bình thường và hạng yếu
            ID_xep_hang_hoc_luc = clsDiem.ID_xep_hang_hoc_luc
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            Dim clsDK As New PortalDangKyLopTinChi_Bussines
            Dim dtKyDK As DataTable = clsDK.ThongTinQuyDinhSoTinChiDangKy(EssToolBarTC1.Ky_dang_ky, objSV.ID_he, objSV.ID_khoa, objSV.Khoa_hoc)
            If dtKyDK.Rows.Count > 0 Then
                If ID_xep_hang_hoc_luc = 1 Then
                    So_hoc_trinh_min = dtKyDK.Rows(0)("So_hoc_trinh_min_yeu")
                    So_hoc_trinh_max = dtKyDK.Rows(0)("So_hoc_trinh_max_yeu")
                    So_hoc_trinh_option = dtKyDK.Rows(0)("So_hoc_trinh_option_yeu")
                    Check_So_hoc_trinh_min = dtKyDK.Rows(0)("Check_So_hoc_trinh_min_yeu")
                    Check_So_hoc_trinh_max = dtKyDK.Rows(0)("Check_So_hoc_trinh_max_yeu")
                Else
                    So_hoc_trinh_min = dtKyDK.Rows(0)("So_hoc_trinh_min_bt")
                    So_hoc_trinh_max = dtKyDK.Rows(0)("So_hoc_trinh_max_bt")
                    So_hoc_trinh_option = dtKyDK.Rows(0)("So_hoc_trinh_option_bt")
                    Check_So_hoc_trinh_min = dtKyDK.Rows(0)("Check_So_hoc_trinh_min_bt")
                    Check_So_hoc_trinh_max = dtKyDK.Rows(0)("Check_So_hoc_trinh_max_bt")
                End If
            End If
            'If Chuyen_nganh_dang_ky = 1 Then
            '    ID_dt = objSV.ID_dt
            'Else
            '    ID_dt = objSV.ID_dt2
            'End If
            clsDK = New PortalDangKyLopTinChi_Bussines(ID_sv, ID_dt, objSV.ID_he, objSV.ID_khoa, objSV.ID_nganh, objSV.ID_chuyen_nganh, objSV.Khoa_hoc)
            'Chương trình đào tạo để kiểm tra Logic Học phần
            dtCTDT = clsDK.ESSChuongTrinhDaoTao()
            'Load danh sách các học phần sinh viên được đăng ký
            dtHPDuocDK = clsDK.DanhSachHocPhanDuocDangKy(EssToolBarTC1.Ky_dang_ky)
            'Load nhóm đào tạo
            dtNhomTuChon = clsDK.DanhSachNhomTuChon()
            'Xoá các học phần đã tích luỹ
            XoaHocPhanTichLuy(dtDiem, dtHPDuocDK)
            'Xoá các học phần không được phân bổ cho lớp
            XoaHocPhanKhacPhamViLop(dtHPDuocDK)
            For i As Integer = 0 To dtHPDuocDK.Rows.Count - 1
                dsID_mon_tc += dtHPDuocDK.Rows(i)("ID_mon_tc").ToString + ","
            Next
            dsID_mon_tc &= "0,"
            If dsID_mon_tc <> "" Then
                dsID_mon_tc = Mid(dsID_mon_tc, 1, Len(dsID_mon_tc) - 1)
                'Load danh sách các lớp sinh viên được đăng ký
                dtLopDuocDK = clsDK.DanhSachLopDuocDangKy(ID_sv, dsID_mon_tc)
                'Load thời khoá biểu lớp được đăng ký
                dtTKBLopDuocDK = clsDK.TKBLopDuocDangKy(dsID_mon_tc)
                'Update thoi gian TKB
                UpDateThoiGian(dtLopDuocDK, dtTKBLopDuocDK)
                UpdateHocPhanHocLai(dtDiem, dtLopDuocDK)
                dtLopDuocDK.Columns.Add("Chon", GetType(Boolean))
                For i As Integer = 0 To dtLopDuocDK.Rows.Count - 1
                    dtLopDuocDK.Rows(i)("Chon") = False
                Next

                grcHocPhan.DataSource = dtLopDuocDK.DefaultView
            Else
                grcHocPhan.DataSource = Nothing
            End If
            'Load danh sách các lớp sinh viên đã đăng ký
            dtLopDaDK = clsDK.DanhSachLopDaDangKy(ID_sv, EssToolBarTC1.Ky_dang_ky, "")
            'Load thời khoá biểu lớp sinh viên đã đăng ký
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, EssToolBarTC1.Ky_dang_ky, "")
            'Update thoi gian TKB
            UpDateThoiGian(dtLopDaDK, dtTKBLopDaDK)

            dtLopDaDK.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dtLopDaDK.Rows.Count - 1
                dtLopDaDK.Rows(i)("Chon") = False
            Next

            Me.grcHocPhanDangKy.DataSource = dtLopDaDK.DefaultView
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub frmESS_DangKyLopTinChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Khong_kiem_tra_rb_mon = clsHeThong.Doc_tham_so("Khong_kiem_tra_rb_mon")
            Khong_kiem_tra_rb_mon_Active = clsHeThong.Doc_tham_so_Active("Khong_kiem_tra_rb_mon")
            'Set quyền truy cập chức năng
            SetQuyenTruyCap(cmdSave, cmdDangKy, , cmdHuyDangKy)
            Loader = True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_DangKyLopTinChi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub


    Private Sub txtMa_sv_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave, txtMa_sv.TextChanged
        Try
            If txtMa_sv.Text <> "" Then
                Dim clsDS As New HoSo_Bussines()
                ID_sv = clsDS.GetID_SV(txtMa_sv.Text)
                If EssToolBarTC1.Ky_dang_ky > 0 And ID_sv > 0 Then
                    objSV = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
                    lblHo_ten.Text = objSV.Ho_ten
                    mTen_khoa = objSV.Ten_khoa
                    ID_dt = objSV.ID_dt
                    lblLop.Text = objSV.Ten_lop
                    If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then
                        ID_dt = objSV.ID_dt2
                        Dim obj As New ThongTinSinhVien_Bussines
                        Dim dt_nganh2 As DataTable = obj.ThongTinSinhVienNganh2(ID_sv)
                        If dt_nganh2.Rows.Count > 0 Then
                            objSV.ID_nganh = dt_nganh2.Rows(0)("ID_nganh")
                            objSV.ID_chuyen_nganh = dt_nganh2.Rows(0)("ID_chuyen_nganh")
                            objSV.Khoa_hoc = dt_nganh2.Rows(0)("Khoa_hoc")
                            objSV.ID_he = dt_nganh2.Rows(0)("ID_he")
                            objSV.ID_khoa = dt_nganh2.Rows(0)("ID_khoa")
                        End If
                    End If
                    LoadDangKy()
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub XoaHocPhanKhacPhamViLop(ByVal dtHPDuocDK As DataTable)
        Dim clsMonTC As New MonTinChi_Bussines
        Dim Check As Boolean = False
        Dim dt As DataTable = clsMonTC.HienThi_ESStkbPhamViDangKyLop_DanhSach(EssToolBarTC1.Ky_dang_ky, ID_dt)
        If dt.Rows.Count > 0 Then
            For i As Integer = dtHPDuocDK.Rows.Count - 1 To 0 Step -1
                Check = False
                For j As Integer = 0 To dt.Rows.Count - 1
                    If dtHPDuocDK.Rows(i)("ID_mon_tc") = dt.Rows(j)("ID_mon_tc") Then
                        Check = True
                    End If
                Next
                If Not Check Then
                    dtHPDuocDK.Rows(i).Delete()
                    dtHPDuocDK.AcceptChanges()
                End If
            Next
        End If
    End Sub


    Private Sub cmdDangKy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDangKy.Click
        Try
            Dim mySelectedRow As Integer
            For mySelectedRow = dtLopDuocDK.Rows.Count - 1 To 0 Step -1
                If dtLopDuocDK.Rows(mySelectedRow)("Chon").ToString <> "" AndAlso dtLopDuocDK.Rows(mySelectedRow)("Chon") Then
                    Dim ID_lop_tc As Integer = dtLopDuocDK.Rows(mySelectedRow)("ID_lop_tc")
                    Dim ID_mon_tc As Integer = dtLopDuocDK.Rows(mySelectedRow)("ID_mon_tc")
                    Dim ID_mon As Integer = dtLopDuocDK.Rows(mySelectedRow)("ID_mon")
                    Dim ID_lop_lt As Integer = CInt("0" + dtLopDuocDK.Rows(mySelectedRow)("ID_lop_lt").ToString)
                    Dim So_hoc_trinh_dk As Integer = dtLopDuocDK.Rows(mySelectedRow)("So_tin_chi")
                    Dim So_sv_con_trong As Integer = CInt("0" + dtLopDuocDK.Rows(mySelectedRow)("Con_trong").ToString)
                    If So_sv_con_trong > 0 Then
                        'Kiểm tra số tín chỉ tối đa
                        If KiemTraDangKyToiDa(So_hoc_trinh_max, So_hoc_trinh_dk, dtLopDaDK) Then
                            'Kiểm tra ràng buộc Học phần và ràng buộc nhóm tự chọn
                            If KiemTraRangBuoc(ID_mon, dtDiem, dtCTDT, dtLopDaDK) Then
                                If Khong_kiem_tra_rb_mon_Active AndAlso Khong_kiem_tra_rb_mon = 0 AndAlso KiemTraTrungMon(ID_mon, ID_lop_lt, dtLopDaDK) Then
                                    If (dtLopDuocDK.Rows(mySelectedRow)("Rut_bot_hoc_phan").ToString = "" AndAlso KiemTraTKB(ID_lop_tc, dtTKBLopDuocDK, dtTKBLopDaDK)) Or (Not KiemTraTKB(ID_lop_tc, dtTKBLopDuocDK, dtTKBLopDaDK) AndAlso dtLopDuocDK.Rows(mySelectedRow)("Rut_bot_hoc_phan").ToString <> "") Then
                                        Dim dr As DataRow = dtLopDaDK.NewRow
                                        If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then
                                            dtLopDuocDK.Rows(mySelectedRow)("Chuyen_nganh2") = True
                                        End If
                                        dr.ItemArray = dtLopDuocDK.Rows(mySelectedRow).ItemArray
                                        dr("Duyet") = False
                                        dtLopDaDK.Rows.Add(dr)
                                        UpDateTableTKB(ID_lop_tc, dtTKBLopDuocDK, dtTKBLopDaDK)
                                        dtLopDuocDK.Rows.RemoveAt(mySelectedRow)
                                        dtLopDuocDK.AcceptChanges()
                                    Else
                                        Thongbao("Trùng thời khoá biểu với lớp đã học ở dưới")
                                    End If
                                End If
                            End If
                        End If
                    Else
                        Thongbao("Lớp học này đã đăng ký hết, bạn đăng ký học lớp khác")
                    End If
                End If
            Next
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdHuyDangKy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHuyDangKy.Click
        Try
            Dim mySelectedRow As Integer
            For mySelectedRow = dtLopDaDK.Rows.Count - 1 To 0 Step -1
                If dtLopDaDK.Rows(mySelectedRow)("Chon").ToString <> "" AndAlso dtLopDaDK.Rows(mySelectedRow)("Chon") Then
                    Dim ID_lop_tc As Integer = dtLopDaDK.Rows(mySelectedRow)("ID_lop_tc")
                    'Kiểm tra số tín chỉ tối thiểu
                    If KiemTraDangKyToiThieu(So_hoc_trinh_min, dtLopDaDK) Then
                        'Kiểm tra ràng buộc Học phần và ràng buộc nhóm tự chọn
                        Dim dr As DataRow = dtLopDuocDK.NewRow
                        dr.ItemArray = dtLopDaDK.Rows(mySelectedRow).ItemArray
                        dtLopDuocDK.Rows.Add(dr)
                        UpDateTableTKB(ID_lop_tc, dtTKBLopDuocDK, dtTKBLopDaDK)
                        dtLopDaDK.Rows.RemoveAt(mySelectedRow)
                    End If
                End If
            Next
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If EssToolBarTC1.cmbKy_dang_ky.ComboBox.Text <> "" And txtMa_sv.Text.Trim <> "" Then
                'Kiểm tra đăng ký tối thiểu
                If KiemTraDangKyToiThieu(So_hoc_trinh_min, dtLopDaDK) Then
                    'Lưu kết quả đăng ký
                    Dim clsLTC As New DanhSachLopTinChi_Bussines()
                    'Xoá lớp đã đăng ký
                    If dtLopDuocDK.Rows.Count > 0 Then
                        'If dtLopDuocDK.Rows(i).Item("Rut_bot_hoc_phan").ToString = "" Then clsLTC.Xoa_ESSDanhSachLopTinChi(ID_sv, dtLopDuocDK.Rows(i).Item("ID_lop_tc") )
                        'If IIf(IsDBNull(dtLopDuocDK.Rows(i).Item("Rut_bot_hoc_phan")), False, dtLopDuocDK.Rows(i).Item("Rut_bot_hoc_phan")) = False Then
                        'End If
                        If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then 'Nganh2
                            clsLTC.Xoa_ESSDanhSachLopTinChi_Nganh2(ID_sv, dtLopDuocDK.Rows(0).Item("Ky_dang_ky"))
                        Else
                            clsLTC.Xoa_ESSDanhSachLopTinChi_Nganh1(ID_sv, dtLopDuocDK.Rows(0).Item("Ky_dang_ky"))
                        End If

                        'If dtLopDuocDK.Rows(i).Item("Chon") Then clsLTC.Xoa_ESSDanhSachLopTinChi_Mon(ID_sv, dtLopDuocDK.Rows(i).Item("ID_lop_tc"))
                    End If
                    For i As Integer = 0 To dtLopDaDK.Rows.Count - 1
                        'If IIf(IsDBNull(dtLopDaDK.Rows(i).Item("Rut_bot_hoc_phan")), False, dtLopDaDK.Rows(i).Item("Rut_bot_hoc_phan")) = False Then
                        Dim objDanhSachTC As New ESSDanhSachLopTinChi
                        objDanhSachTC.ID_sv = ID_sv
                        objDanhSachTC.ID_lop_tc = dtLopDaDK.Rows(i)("ID_lop_tc")
                        If dtLopDaDK.Rows(i)("Hoc_lai").ToString <> "" Then
                            objDanhSachTC.Hoc_lai = 1
                        Else
                            objDanhSachTC.Hoc_lai = 0
                        End If
                        objDanhSachTC.Huy_dang_ky = 0
                        objDanhSachTC.Ly_do = ""
                        objDanhSachTC.Rut_bot_hoc_phan = IIf(IsDBNull(dtLopDaDK.Rows(i).Item("Rut_bot_hoc_phan")), False, dtLopDaDK.Rows(i).Item("Rut_bot_hoc_phan"))
                        If dtLopDaDK.Rows(i).Item("Duyet") = False Then
                            If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then 'Nganh2
                                If dtLopDaDK.Rows(i).Item("Chuyen_nganh2") Then
                                    objDanhSachTC.Chuyen_nganh2 = True
                                    clsLTC.ThemMoi_ESSDanhSachLopTinChi_Nganh2(objDanhSachTC)
                                End If
                            Else
                                If dtLopDaDK.Rows(i).Item("Chuyen_nganh2") = 0 Then
                                    objDanhSachTC.Chuyen_nganh2 = False
                                    clsLTC.ThemMoi_ESSDanhSachLopTinChi(objDanhSachTC)
                                End If
                            End If
                        End If
                        'Else
                        '    clsLTC.CapNhat_ESSLopTinChi_SinhVien(ID_sv, dtLopDaDK.Rows(i).Item("ID_lop_tc"), dtLopDaDK.Rows(i).Item("Rut_bot_hoc_phan"))
                        'End If
                    Next
                    Thongbao("Đã lưu thành công !")
                Else
                    Thongbao("Bạn chưa đăng ký đủ số tín chỉ tối thiểu là: " + So_hoc_trinh_min.ToString)
                End If
            Else
                Thongbao("Bạn chưa chọn kỳ đăng ký và sinh viên đăng ký")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvHocPhan.RowCount < 0 Then Exit Sub
            Dim dv As DataView = grvHocPhanDangKy.DataSource
            Dim Tieu_de1 As String = ""
            Tieu_de1 = "KỲ ĐĂNG KÝ: " & EssToolBarTC1.cmbKy_dang_ky.ComboBox.Text.ToUpper
            Dim dt_main As DataTable = dv.Table
            If dt_main.Rows.Count > 0 Then
                Dim dt As DataTable = dt_main.Copy

                dt.Columns.Add("Ho_ten_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Chuyen_nganh")
                dt.Columns.Add("Ten_khoa")
                dt.Columns.Add("So_HP")
                dt.Columns.Add("So_TC")
                dt.Columns.Add("Hoc_phi")
                dt.Columns.Add("Ten_lop")

                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ho_ten_sv") = lblHo_ten.Text
                    dt.Rows(i).Item("Ma_sv") = txtMa_sv.Text
                    dt.Rows(i).Item("Chuyen_nganh") = EssToolBarTC1.cmbID_chuyen_nganh.ComboBox.Text.Trim
                    dt.Rows(i).Item("Ten_khoa") = mTen_khoa
                    dt.Rows(i).Item("So_HP") = lblSo_mon.Text
                    dt.Rows(i).Item("So_TC") = lblSo_hoc_trinh.Text
                    dt.Rows(i).Item("Hoc_phi") = lblSo_tien_nop.Text
                    dt.Rows(i).Item("Ten_lop") = lblLop.Text
                Next

                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptPLAN_PhieuDangKyHocPhan", dt.DefaultView, Tieu_de1)
                frmESS_.ShowDialog(False)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Try
            Dim frmESS_ As New frmESS_TimKiemSinhVien
            frmESS_.ShowDialog()
            If frmESS_.Tag = 1 Then
                ID_sv = frmESS_.mID_sv
                If ID_sv > 0 Then
                    objSV = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
                    txtMa_sv.Text = objSV.Ma_sv
                    lblHo_ten.Text = objSV.Ho_ten
                    mTen_khoa = objSV.Ten_khoa
                    lblLop.Text = objSV.Ten_lop
                    LoadDangKy()
                Else
                    Thongbao("Không tìm thấy sinh viên này, nhập lại mã khác")
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub EssToolBarTC1_ToolBarSelected_()
        Try
            If Loader Then
                If ID_sv > 0 And EssToolBarTC1.Ky_dang_ky > 0 Then
                    objSV = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
                    LoadDangKy()
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

   
    Private Sub cmdRut_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRut_HP.Click
        Try
            Dim clsLTC As New DanhSachLopTinChi_Bussines()
            For i As Integer = 0 To dtLopDaDK.Rows.Count - 1
                clsLTC.CapNhat_ESSLopTinChi_SinhVien(ID_sv, dtLopDaDK.Rows(i).Item("ID_lop_tc"), dtLopDaDK.Rows(i)("Rut_bot_hoc_phan"))
            Next
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim dt As DataTable
        Dim clsDM As New DanhMuc_Bussines
        Dim SQL As String = "SELECT DISTINCT ID_SV,ID_sv_ FROM STU_HOSOSINHVIEN"
        dt = clsDM.LoadDanhMuc(SQL)
        For i As Integer = 0 To dt.Rows.Count - 1
            Try
                Try
                    clsDM.Execute("UPDATE ACC_BienLaiThu_TMP SET ID_SV=" & dt.Rows(i)("ID_SV_") & " WHERE ID_SV=" & dt.Rows(i)("ID_SV"))
                Catch ex As Exception
                End Try
            Catch ex As Exception
            End Try
        Next
        Thongbao("Chuẩn hóa dữ liệu điểm Ngành 2 thành công !", MsgBoxStyle.Information)
    End Sub
End Class