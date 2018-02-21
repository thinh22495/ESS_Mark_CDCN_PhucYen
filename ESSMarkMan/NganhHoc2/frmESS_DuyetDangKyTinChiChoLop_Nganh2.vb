Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSReports
Public Class frmESS_DuyetDangKyTinChiChoLop_Nganh2
    Private Loader As Boolean = False
    Private Hoc_ky As Integer = 0
    Private Nam_hoc As String = ""
    Private Ky_dang_ky As Integer = 0
    Private So_hoc_trinh_min As Integer = 0
    Private So_hoc_trinh_max As Integer = 0
    Private So_hoc_trinh_option As Integer = 0
    Private Check_So_hoc_trinh_max As Boolean = False
    Private Check_So_hoc_trinh_min As Boolean = False
    Private Chuyen_nganh_dang_ky As Integer = 1
    Private dtLopDuocDK, dtLopDaDK, dtTKBLopDuocDK, dtTKBLopDaDK, dtDiem, dtCTDT, dtNhomTuChon As DataTable
    Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, 1, -1)

#Region "User function"

    Private Sub XoaHocPhanTichLuy(ByVal dtDiem As DataTable, ByVal dtHPDuocDK As DataTable)
        Try
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                For j As Integer = dtHPDuocDK.Rows.Count - 1 To 0 Step -1
                    If dtDiem.Rows(i)("ID_mon") = dtHPDuocDK.Rows(j)("ID_mon") Then
                        If dtDiem.Rows(i)("Tich_luy") Then
                            dtHPDuocDK.Rows(j).Delete()
                            dtHPDuocDK.AcceptChanges()
                        Else
                            If dtDiem.Rows(i)("Hoc_lai") Then dtHPDuocDK.Rows(j)("Hoc_lai") = "X"
                        End If
                    End If
                Next
            Next
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
            If IsNothing(dtLopDaDK) Then Return True
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

    Private Function KiemTraDangKyToiDa(ByVal So_hoc_trinh_max As Integer, ByVal So_hoc_trinh_dk As Integer) As Boolean
        Try
            If Check_So_hoc_trinh_max Then
                If So_hoc_trinh_dk > So_hoc_trinh_max Then
                    'Thongbao("Bạn đăng ký vượt số tín chỉ tối đa cho php là: " + So_hoc_trinh_max.ToString)
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
                    'Thongbao("Bạn chưa đăng ký đủ số tín chỉ tối thiểu là: " + So_hoc_trinh_min.ToString)
                    Return False
                End If
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
    Private Function KiemTraRangBuoc(ByVal dtLopDaDK As DataTable, ByVal dtDiem As DataTable, ByVal dtCTDT As DataTable, ByVal dtMonDK As DataTable, ByRef sHoc_phan As String) As Boolean
        Try
            For m As Integer = 0 To dtLopDaDK.Rows.Count - 1
                Dim ID_mon_rb, Loai_rang_buoc As Integer
                Dim Hoc_phan_bi_rb As String = ""
                Dim Hoc_phan_rb As String = ""
                Dim ID_mon As Integer = dtLopDaDK.Rows(m)("ID_mon")
                'Số tín chỉ tối đa
                'Kiểm tra logic Học phần: Tiên quyết, học trước, xong hành
                For i As Integer = 0 To dtCTDT.Rows.Count - 1
                    If dtCTDT.Rows(i)("ID_mon") = ID_mon Then
                        ID_mon_rb = CInt("0" + dtCTDT.Rows(i)("ID_mon_rb").ToString)
                        Loai_rang_buoc = CInt("0" + dtCTDT.Rows(i)("Loai_rang_buoc").ToString)
                        Hoc_phan_bi_rb = dtCTDT.Rows(i)("Ten_mon").ToString
                        Hoc_phan_rb = dtCTDT.Rows(i)("Ten_mon_rb").ToString
                        Exit For
                    End If
                Next
                If ID_mon_rb > 0 Then
                    Select Case Loai_rang_buoc
                        Case 1  'Tiên quyết
                            Dim clsThamSo As New ThamSoHeThong_Bussines()
                            Dim TBCMH_Min As Double = CType(clsThamSo.Doc_tham_so("TBCMH_Min_dang_ky"), Double)
                            Dim TBCMH_Min_Active As Boolean = clsThamSo.Doc_tham_so_Active("TBCMH_Min_dang_ky")
                            If TBCMH_Min_Active AndAlso DiemMonRangBuoc(ID_mon_rb, dtDiem) < TBCMH_Min Then
                                'Thongbao("Điều kiện Tiên quyết: Để đăng ký được học phần này, bạn phải đăng ký học phần " + Hoc_phan_rb + " và có điểm TBCMH >=" + TBCMH_Min.ToString)
                                sHoc_phan += Hoc_phan_bi_rb + "- Có học phần " + Hoc_phan_rb + " - chưa đạt " + ", "
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
            Next
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
                    Thongbao("Bạn chỉ được đăng ký " + So_mon_dang_ky.ToString + " học phần trong tổng số " + So_mon_tu_chon.ToString + " tự chọn")
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
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("Thoi_gian", GetType(String))
            For i As Integer = 0 To dtLop.Rows.Count - 1
                dtLop.Rows(i)("Chon") = False
                If dtLop.Rows(i)("ID_lop_lt") = 0 Then
                    dtLop.Rows(i)("Ten_lop_tc") = dtLop.Rows(i)("Ky_hieu_lop_tc") + ".LT-" + dtLop.Rows(i)("STT_lop").ToString

                    'Ky_hieu_lop_tc + ".LT-" + STT_lop.ToString
                    'Ky_hieu_lop_tc + ".LT-" + STT_lop_lt.ToString + ".TH-" + STT_lop.ToString

                Else
                    dtLop.Rows(i)("Ten_lop_tc") = dtLop.Rows(i)("Ky_hieu_lop_tc") + ".LT-" + dtLop.Rows(i)("STT_lop_lt").ToString + ".TH-" + dtLop.Rows(i)("STT_lop").ToString
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
    Private Sub LoadDangKy(ByVal ID_sv As Integer, ByVal id_dt As Integer)
        Try
            Dim dsID_mon_tc As String = ""
            Dim objSV As ESSThongTinSinhVien = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
            Dim clsDK As New PortalDangKyLopTinChi_Bussines(ID_sv, id_dt, objSV.ID_he, objSV.ID_khoa, objSV.ID_nganh, objSV.ID_chuyen_nganh, objSV.Khoa_hoc)
            'Load danh sách các lớp sinh viên đã đăng ký
            dtLopDaDK = clsDK.DanhSachLopDaDangKy(ID_sv, Ky_dang_ky, "")
            'Load thời khoá biểu lớp sinh viên đã đăng ký
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, Ky_dang_ky, "")
            Dim clsDiem As New Diem_Bussines("P1", ID_sv, id_dt) 'Load bang diem sinh vien
            'Bảng điểm của sinh viên để kiểm tra điều kiện học lại
            dtDiem = clsDiem.BangDiemSinhVien(ID_sv, Hoc_ky, Nam_hoc)
            'Update thoi gian TKB
            UpDateThoiGian(dtLopDaDK, dtTKBLopDaDK)
            grcHocPhanDangKy.DataSource = dtLopDaDK.DefaultView

            'Load danh sách các học phần sinh viên được đăng ký
            Dim dtHPDuocDK As DataTable = clsDK.DanhSachHocPhanDuocDangKy(Ky_dang_ky)
            'Xoá các học phần đã tích luỹ
            XoaHocPhanTichLuy(dtDiem, dtHPDuocDK)
            'Xoá các học phần không được phân bổ cho lớp
            'XoaHocPhanKhacPhamViLop(dtHPDuocDK, objSV.ID_lop)
            For i As Integer = 0 To dtHPDuocDK.Rows.Count - 1
                dsID_mon_tc += dtHPDuocDK.Rows(i)("ID_mon_tc").ToString + ","
            Next
            dsID_mon_tc &= "0,"
            If dsID_mon_tc <> "" Then
                dsID_mon_tc = Mid(dsID_mon_tc, 1, Len(dsID_mon_tc) - 1)
                'Load danh sách các lớp sinh viên được đăng ký
                dtLopDuocDK = clsDK.DanhSachLopDuocDangKy(ID_sv, dsID_mon_tc)
                'Xoá các học phần không được phân bổ cho lớp
                'XoaLopKhacPhamViLop(dtLopDuocDK, Ky_dang_ky, cmbID_lop.SelectedValue)
                'Load thời khoá biểu lớp được đăng ký
                dtTKBLopDuocDK = clsDK.TKBLopDuocDangKy(dsID_mon_tc)
                'Update thoi gian TKB
                UpDateThoiGian(dtLopDuocDK, dtTKBLopDuocDK)
                UpdateHocPhanHocLai(dtDiem, dtLopDuocDK)
            End If
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadDangKy_Nganh1(ByVal ID_sv As Integer, ByVal id_dt As Integer)
        Try
            Dim dsID_mon_tc As String = ""
            Dim objSV As ESSThongTinSinhVien = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
            Dim clsDK As New PortalDangKyLopTinChi_Bussines(ID_sv, id_dt, objSV.ID_he, objSV.ID_khoa, objSV.ID_nganh, objSV.ID_chuyen_nganh, objSV.Khoa_hoc)
            'Load danh sách các lớp sinh viên đã đăng ký
            dtLopDaDK = clsDK.DanhSachLopDaDangKy_Nganh1(ID_sv, Ky_dang_ky, "")
            'Load thời khoá biểu lớp sinh viên đã đăng ký
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, Ky_dang_ky, "")
            Dim clsDiem As New Diem_Bussines("P1", ID_sv, id_dt) 'Load bang diem sinh vien
            'Bảng điểm của sinh viên để kiểm tra điều kiện học lại
            dtDiem = clsDiem.BangDiemSinhVien(ID_sv, Hoc_ky, Nam_hoc)
            'Update thoi gian TKB
            UpDateThoiGian(dtLopDaDK, dtTKBLopDaDK)
            grcHocPhanDangKy.DataSource = dtLopDaDK.DefaultView

            'Load danh sách các học phần sinh viên được đăng ký
            Dim dtHPDuocDK As DataTable = clsDK.DanhSachHocPhanDuocDangKy(Ky_dang_ky)
            'Xoá các học phần đã tích luỹ
            XoaHocPhanTichLuy(dtDiem, dtHPDuocDK)
            'Xoá các học phần không được phân bổ cho lớp
            'XoaHocPhanKhacPhamViLop(dtHPDuocDK, objSV.ID_lop)
            For i As Integer = 0 To dtHPDuocDK.Rows.Count - 1
                dsID_mon_tc += dtHPDuocDK.Rows(i)("ID_mon_tc").ToString + ","
            Next
            dsID_mon_tc &= "0,"
            If dsID_mon_tc <> "" Then
                dsID_mon_tc = Mid(dsID_mon_tc, 1, Len(dsID_mon_tc) - 1)
                'Load danh sách các lớp sinh viên được đăng ký
                dtLopDuocDK = clsDK.DanhSachLopDuocDangKy(ID_sv, dsID_mon_tc)
                'Xoá các học phần không được phân bổ cho lớp
                'XoaLopKhacPhamViLop(dtLopDuocDK, Ky_dang_ky, cmbID_lop.SelectedValue)
                'Load thời khoá biểu lớp được đăng ký
                dtTKBLopDuocDK = clsDK.TKBLopDuocDangKy(dsID_mon_tc)
                'Update thoi gian TKB
                UpDateThoiGian(dtLopDuocDK, dtTKBLopDuocDK)
                UpdateHocPhanHocLai(dtDiem, dtLopDuocDK)
            End If
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub LoadDangKy_Nganh2(ByVal ID_sv As Integer, ByVal id_dt As Integer)
        Try
            Dim dsID_mon_tc As String = ""
            Dim objSV As ESSThongTinSinhVien = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
            Dim clsDK As New PortalDangKyLopTinChi_Bussines(ID_sv, id_dt, objSV.ID_he, objSV.ID_khoa, objSV.ID_nganh, objSV.ID_chuyen_nganh, objSV.Khoa_hoc)
            'Load danh sách các lớp sinh viên đã đăng ký
            dtLopDaDK = clsDK.DanhSachLopDaDangKy_Nganh2(ID_sv, Ky_dang_ky, "")
            'Load thời khoá biểu lớp sinh viên đã đăng ký
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, Ky_dang_ky, "")
            Dim clsDiem As New Diem_Bussines("P1", ID_sv, id_dt) 'Load bang diem sinh vien
            'Bảng điểm của sinh viên để kiểm tra điều kiện học lại
            dtDiem = clsDiem.BangDiemSinhVien(ID_sv, Hoc_ky, Nam_hoc)
            'Update thoi gian TKB
            UpDateThoiGian(dtLopDaDK, dtTKBLopDaDK)
            grcHocPhanDangKy.DataSource = dtLopDaDK.DefaultView

            'Load danh sách các học phần sinh viên được đăng ký
            Dim dtHPDuocDK As DataTable = clsDK.DanhSachHocPhanDuocDangKy(Ky_dang_ky)
            'Xoá các học phần đã tích luỹ
            XoaHocPhanTichLuy(dtDiem, dtHPDuocDK)
            'Xoá các học phần không được phân bổ cho lớp
            'XoaHocPhanKhacPhamViLop(dtHPDuocDK, objSV.ID_lop)
            For i As Integer = 0 To dtHPDuocDK.Rows.Count - 1
                dsID_mon_tc += dtHPDuocDK.Rows(i)("ID_mon_tc").ToString + ","
            Next
            dsID_mon_tc &= "0,"
            If dsID_mon_tc <> "" Then
                dsID_mon_tc = Mid(dsID_mon_tc, 1, Len(dsID_mon_tc) - 1)
                'Load danh sách các lớp sinh viên được đăng ký
                dtLopDuocDK = clsDK.DanhSachLopDuocDangKy(ID_sv, dsID_mon_tc)
                'Xoá các học phần không được phân bổ cho lớp
                'XoaLopKhacPhamViLop(dtLopDuocDK, Ky_dang_ky, cmbID_lop.SelectedValue)
                'Load thời khoá biểu lớp được đăng ký
                dtTKBLopDuocDK = clsDK.TKBLopDuocDangKy(dsID_mon_tc)
                'Update thoi gian TKB
                UpDateThoiGian(dtLopDuocDK, dtTKBLopDuocDK)
                UpdateHocPhanHocLai(dtDiem, dtLopDuocDK)
            End If
            Call TinhHocPhanDangKy(dtLopDaDK)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub TinhHocPhanDangKy(ByVal dt As DataTable)
        Try
            Dim Tong_So_hoc_trinh As Integer = 0
            Dim So_mon As Integer = 0
            Dim Ky_hieu As String = ""
            dt.DefaultView.Sort = "Ky_hieu"
            If Not dt Is Nothing Then
                For i As Integer = 0 To dt.Rows.Count - 1
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
                lblSo_hoc_trinh.Text = Tong_So_hoc_trinh.ToString
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub LoadDangKy_NoFill(ByVal ID_sv As Integer, ByVal id_dt As Integer)
        Try
            Dim dsID_mon_tc As String = ""
            Dim objSV As ESSThongTinSinhVien = New ThongTinSinhVien_Bussines(ID_sv, False).ESSThongTinSinhVien
            Dim clsDK As New PortalDangKyLopTinChi_Bussines(ID_sv, id_dt, objSV.ID_he, objSV.ID_khoa, objSV.ID_nganh, objSV.ID_chuyen_nganh, objSV.Khoa_hoc)
            'Load danh sách các lớp sinh viên đã đăng ký
            dtLopDaDK = clsDK.DanhSachLopDaDangKy(ID_sv, Ky_dang_ky, "")
            'Load thời khoá biểu lớp sinh viên đã đăng ký
            dtTKBLopDaDK = clsDK.TKBLopDaDangKy(ID_sv, Ky_dang_ky, "")
            Dim clsDiem As New Diem_Bussines("P1", ID_sv, id_dt) 'Load bang diem sinh vien
            'Bảng điểm của sinh viên để kiểm tra điều kiện học lại
            dtDiem = clsDiem.BangDiemSinhVien(ID_sv, Hoc_ky, Nam_hoc)
            'Update thoi gian TKB
            UpDateThoiGian(dtLopDaDK, dtTKBLopDaDK)

            'Load danh sách các học phần sinh viên được đăng ký
            Dim dtHPDuocDK As DataTable = clsDK.DanhSachHocPhanDuocDangKy(Ky_dang_ky)
            'Xoá các học phần đã tích luỹ
            XoaHocPhanTichLuy(dtDiem, dtHPDuocDK)
            'Xoá các học phần không được phân bổ cho lớp
            'XoaHocPhanKhacPhamViLop(dtHPDuocDK, id_dt)
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
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub XoaHocPhanKhacPhamViLop(ByVal dtHPDuocDK As DataTable, ByVal Id_lop As Integer)
        Dim clsMonTC As New MonTinChi_Bussines
        Dim Check As Boolean = False
        Dim dt As DataTable = clsMonTC.HienThi_ESStkbPhamViDangKyLopChon_DanhSach(Ky_dang_ky, Id_lop)
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
    Private Sub XoaLopKhacPhamViLop(ByVal dtLopDuocDK As DataTable, ByVal Ky_dang_ky As Integer, ByVal id_lop As Integer)
        Dim clsMonTC As New MonTinChi_Bussines
        Dim Check As Boolean = False
        Dim dt As DataTable = clsMonTC.HienThi_ESStkbPhamViDangKyLopChon_DanhSach(Ky_dang_ky, ID_lop)
        If dt.Rows.Count > 0 Then
            For i As Integer = dtLopDuocDK.Rows.Count - 1 To 0 Step -1
                Check = False
                For j As Integer = 0 To dt.Rows.Count - 1
                    If dtLopDuocDK.Rows(i)("ID_lop_tc") = dt.Rows(j)("ID_lop_tc") Then
                        Check = True
                    End If
                Next
                If Not Check Then
                    dtLopDuocDK.Rows(i).Delete()
                    dtLopDuocDK.AcceptChanges()
                End If
            Next
        End If
    End Sub

#End Region
    Private Sub frmESS_DangKyLopTinChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetQuyenTruyCap(btnDuyet, , , )
            Dim str As String = "SELECT DISTINCT ID_Lop FROM SYS_NguoiDungCoVanHocTap a INNER JOIN STU_HOSOSINHVIEN b ON a.Ma_sv=b.Ma_sv " & _
                                "INNER JOIN STU_DANHSACHNGANH2 d ON b.ID_SV=d.ID_SV " & _
                                "WHERE UserName=N'" & gobjUser.UserName.Trim & "'"
            'If btnDuyet.Enabled = True And gobjUser.ID_phong = 0 And gobjUser.UserName.ToUpper <> "ADMIN" Then
            Me.TreeViewLop_ChuanHoa1.HienThi_ESSTreeViewNganh2_TheoCoVanHocTap(str)
            'Else
            'Me.TreeViewLop_ChuanHoa1.HienThi_ESSTreeView()
            'End If

            'Set quyền truy cập chức năng
            Loader = True
            EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex = 1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_DangKyLopTinChi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDuyet.Click
        Try
            Dim dvSV As DataView = grvDanhSach.DataSource
            If dvSV.Count = 0 Then Exit Sub
            Dim clsLTC As New DanhSachLopTinChi_Bussines()
            Dim dv_HP As DataView = grvHocPhanDangKy.DataSource
            Dim ID_sv As Integer = grvDanhSach.GetFocusedDataRow("ID_sv")
            Dim ID_dt As Integer = grvDanhSach.GetFocusedDataRow("ID_dt")
            For i As Integer = 0 To dv_HP.Count - 1
                clsLTC.CapNhat_ESSLopTinChi_SinhVien_Duyet(ID_sv, dv_HP.Item(i)("ID_lop_tc"), dv_HP.Item(i)("Duyet"))
            Next
            TreeViewLop_ChuanHoa1_TreeNodeSelected_()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub cmbNgoai_ngu_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNgoai_ngu.SelectedIndexChanged
        Try
            TreeViewLop_ChuanHoa1_TreeNodeSelected_()
        Catch ex As Exception

        End Try
    End Sub
    Private Sub LoadDangKy_SinhVienChon()
        Try
            If Loader Then
                If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
                    Ky_dang_ky = EssToolBarTC1.cmbKy_dang_ky.ComboBox.SelectedValue
                    If Ky_dang_ky > 0 AndAlso (Not grvDanhSach.GetFocusedDataRow Is Nothing) Then
                        Dim ID_sv As Integer = grvDanhSach.GetFocusedDataRow("ID_sv")
                        Dim ID_dt As Integer = grvDanhSach.GetFocusedDataRow("ID_dt")
                        If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then
                            ID_dt = grvDanhSach.GetFocusedDataRow("ID_dt2")
                            LoadDangKy_Nganh2(ID_sv, ID_dt)
                        Else
                            LoadDangKy_Nganh1(ID_sv, ID_dt)
                        End If
                        '
                        Dim dtSV As DataTable = grvDanhSach.DataSource.Table.Copy

                        Dim so_sv As Integer = 0
                        If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
                            dtSV.DefaultView.RowFilter = "Chon=True"
                            so_sv += dtSV.DefaultView.Count
                        End If
                    End If

                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cbChon_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbChon.CheckedChanged
        Dim dvSV As DataView = grvHocPhanDangKy.DataSource
        If Not grvHocPhanDangKy.DataSource Is Nothing Then
            For i As Integer = 0 To dvSV.Count - 1
                dvSV(i)("Duyet") = cbChon.Checked
            Next
        End If
    End Sub

    Private Sub dgvSinhVien_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim dtSV As DataTable = CType(grvDanhSach.DataSource, DataView).Table.Copy
        Dim so_sv As Integer = 0
        If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
            dtSV.DefaultView.RowFilter = "Chon=True"
            so_sv += dtSV.DefaultView.Count
        End If
    End Sub

    Private Sub cbAll_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        TreeViewLop_ChuanHoa1_TreeNodeSelected_()
    End Sub



    Private Sub frmESS_DangKyLopTinChiChoNhieu_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub

    Private Sub TreeViewLop_ChuanHoa1_TreeNodeSelected_() Handles TreeViewLop_ChuanHoa1.TreeNodeSelected_, cmbTrang_thai_duyet.SelectedIndexChanged

        Try
            If Not TreeViewLop_ChuanHoa1.ID_lop_list Is Nothing AndAlso EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then

                Dim clsDM As New DanhMuc_Bussines
                If clsDM.Check_ThoiGianDuyet(Ky_dang_ky) Then
                    btnDuyet.Enabled = False
                Else
                    btnDuyet.Enabled = True
                End If

                Dim ID_lops As String = TreeViewLop_ChuanHoa1.ID_lop_list
                Dim objDanhSach As New DanhSachSinhVien_Bussines()
                objDanhSach = New DanhSachSinhVien_Bussines(ID_lops, "SELECT ID_SV FROM STU_DANHSACH WHERE Trang_thai<>0", False, False, gobjUser.UserName)
                Dim dv As DataView = objDanhSach.Danh_sach_sinh_vien_Nganh2.DefaultView

                If cmbTrang_thai_duyet.Text.Trim <> "" Then
                    Dim sql As String = ""
                    Dim dt As DataTable
                    If cmbTrang_thai_duyet.Text = "Đã duyệt" Then
                        sql = "SELECT DISTINCT a.ID_SV FROM STU_DANHSACHLOPTINCHI a INNER JOIN PLAN_LOPTINCHI_TC b ON a.ID_lop_tc=b.ID_lop_tc INNER JOIN PLAN_MONtINCHI_TC c ON b.ID_mon_tc=c.ID_mon_tc INNER JOIN STU_DANHSACHNGANH2 d ON a.ID_SV=d.ID_SV WHERE  Rut_bot_hoc_phan=0 AND Huy_dang_ky=0 AND Ky_dang_ky=" & EssToolBarTC1.Ky_dang_ky & " AND ID_lop in (" & ID_lops & ") AND a.Duyet=1 AND Chuyen_nganh2=1"
                    Else
                        sql = "SELECT DISTINCT a.ID_SV FROM STU_DANHSACHLOPTINCHI a INNER JOIN PLAN_LOPTINCHI_TC b ON a.ID_lop_tc=b.ID_lop_tc INNER JOIN PLAN_MONtINCHI_TC c ON b.ID_mon_tc=c.ID_mon_tc INNER JOIN STU_DANHSACHNGANH2 d ON a.ID_SV=d.ID_SV WHERE Rut_bot_hoc_phan=0 AND Huy_dang_ky=0 AND Ky_dang_ky=" & EssToolBarTC1.Ky_dang_ky & " AND ID_lop in (" & ID_lops & ") AND a.Duyet=0 AND Chuyen_nganh2=1"
                    End If

                    dt = clsDM.LoadDanhMuc(sql)
                    If dt.Rows.Count > 0 Then
                        dt.DefaultView.Sort = "ID_SV"
                        For j As Integer = dv.Count - 1 To 0 Step -1
                            dt.DefaultView.RowFilter = "ID_SV=" & dv.Item(j)("ID_SV")
                            If dt.DefaultView.Count = 0 Then
                                dv.Item(j).Delete()
                            End If
                        Next
                    Else
                        dv = Nothing
                    End If
                End If

                grcDanhSach.DataSource = dv
                lblSo_sv.Text = "Số sinh viên: " & dv.Count
            End If
        Catch ex As Exception
            'Thongbao("Chưa có sinh viên được duyệt")
        End Try

    End Sub


    Private Sub EssToolBarTC1_ToolBarSelected_()
        Try
            If Loader Then
                If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then
                    Ky_dang_ky = EssToolBarTC1.Ky_dang_ky
                    If Ky_dang_ky > 0 AndAlso (Not grvDanhSach.GetFocusedDataRow Is Nothing) Then
                        Dim ID_sv As Integer = grvDanhSach.GetFocusedDataRow("ID_sv")
                        Dim ID_dt As Integer = grvDanhSach.GetFocusedDataRow("ID_dt")

                        LoadDangKy(ID_sv, ID_dt)
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



    Private Sub grvDanhSach_DataSourceChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grvDanhSach.DataSourceChanged
        Dim dtSV As DataTable = grvDanhSach.DataSource.Table.Copy
        Dim so_sv As Integer = 0
        If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
            dtSV.DefaultView.RowFilter = "Chon=True"
            so_sv += dtSV.DefaultView.Count
        End If
    End Sub

    Private Sub grvDanhSach_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvDanhSach.SelectionChanged
        If Loader = False Then Exit Sub
        Dim clsDM As New DanhMuc_Bussines
        If clsDM.Check_ThoiGianDuyet(Ky_dang_ky) Then
            btnDuyet.Enabled = False
            cmdDelete.Enabled = False
        Else
            btnDuyet.Enabled = True
            cmdDelete.Enabled = True
        End If
        If EssToolBarTC1.cmbID_chuyen_nganh.SelectedIndex > 0 Then
            LoadDangKy_SinhVienChon()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSach.RowCount < 0 Then Exit Sub
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

                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ho_ten_sv") = grvDanhSach.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ma_sv") = grvDanhSach.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Chuyen_nganh") = EssToolBarTC1.cmbID_chuyen_nganh.ComboBox.Text.Trim
                    dt.Rows(i).Item("Ten_khoa") = grvDanhSach.GetFocusedDataRow()("Ten_khoa")
                    dt.Rows(i).Item("So_HP") = lblSo_mon.Text
                    dt.Rows(i).Item("So_TC") = lblSo_hoc_trinh.Text
                    'dt.Rows(i).Item("Hoc_phi") = lblSo_tien_nop.Text
                Next

                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptPLAN_PhieuDangKyHocPhan", dt.DefaultView, Tieu_de1)
                frmESS_.ShowDialog(False)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_All_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_All.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If grvDanhSach.RowCount < 0 Then Exit Sub
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

                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Ho_ten_sv") = grvDanhSach.GetFocusedDataRow()("Ho_ten").ToString
                    dt.Rows(i).Item("Ma_sv") = grvDanhSach.GetFocusedDataRow()("Ma_sv").ToString
                    dt.Rows(i).Item("Chuyen_nganh") = EssToolBarTC1.cmbID_chuyen_nganh.ComboBox.Text.Trim
                    dt.Rows(i).Item("Ten_khoa") = grvDanhSach.GetFocusedDataRow()("Ten_khoa")
                    dt.Rows(i).Item("So_HP") = lblSo_mon.Text
                    dt.Rows(i).Item("So_TC") = lblSo_hoc_trinh.Text
                    'dt.Rows(i).Item("Hoc_phi") = lblSo_tien_nop.Text
                Next

                Dim frmESS_ As New frmESS_ReportView(gobjUser, "rptPLAN_PhieuDangKyHocPhan", dt.DefaultView, Tieu_de1)
                frmESS_.ShowDialog(False)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Dim clsDM As New DanhMuc_Bussines
        clsDM.Insert_DM()

        'Dim clsDM As New DanhMuc_Bussines
        'Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT ID_SV FROM MARK_DANHSACHTOTNGHIEP")
        'Dim dt2 As DataTable = clsDM.LoadDanhMuc("SELECT ID_SV FROM MARK_DANHSACHTOTNGHIEP")
        'For i As Integer = 0 To dt.Rows.Count - 1
        '    dt2.DefaultView.RowFilter = "ID_SV=" & dt.Rows(i)("ID_SV")
        '    If dt2.DefaultView.Count > 1 Then
        '        Dim dt3 As DataTable = clsDM.LoadDanhMuc("SELECT ID_SV FROM MARK_DANHSACHTOTNGHIEP_TMP WHERE ID_SV=" & dt.Rows(i)("ID_SV"))
        '        If dt3.Rows.Count = 0 Then
        '            clsDM.Execute("INSERT INTO MARK_DANHSACHTOTNGHIEP_TMP (ID_SV) VALUES(" & dt.Rows(i)("ID_SV") & ")")
        '        End If
        '    End If
        'Next
    End Sub
End Class