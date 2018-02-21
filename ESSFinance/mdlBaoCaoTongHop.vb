
Imports C1.Win.C1Report
Imports ESS.Bussines
Module mdlBaoCaoTongHop
    Private Const gDonvi_do As Double = 567 '=1 cm . Chuyển đổi từ hệ số đo Twips sang Centimeter
    Private Const gPointToCm As Double = 28.3   '=1 cm. Chuyển đổi từ hệ số đo Point sang Centimeter
    Private Const PageWidthA4 As Double = gDonvi_do * 21
    Private Const PageHeightA4 As Double = gDonvi_do * 29.7
    Private Const PageWidthA3 As Double = gDonvi_do * 29.7
    Private Const PageHeightA3 As Double = gDonvi_do * 42

    Public Sub TaoBaoCaoTongHopDiem(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de_hoc_trinh As String, ByVal dtMonHoc As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = gDonvi_do * 0.5
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de_hoc_trinh = Tieu_de_hoc_trinh
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "TBCHT"
        objBaoCaoChiTiet.FieldName = "TBCHT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 5
        objBaoCaoChiTiet.FieldID = "Xep_loai"
        objBaoCaoChiTiet.FieldName = "Xếp loại"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "So_mon_no"
        objBaoCaoChiTiet.FieldName = "Nợ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        If dtMonHoc.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 1.5 + 1.5 + 0.7 + 1.75) * gDonvi_do) / dtMonHoc.Rows.Count
            'Add các cột điểm
            For i As Integer = 0 To dtMonHoc.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = "M" + dtMonHoc.Rows(i)("ID_mon").ToString
                objBaoCaoChiTiet.FieldName = dtMonHoc.Rows(i)("Ky_hieu")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.So_hoc_trinh = dtMonHoc.Rows(i)("So_hoc_trinh")
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        End If
        objBaocao.TaoBaoCaoTongHopDiem("")
    End Sub

    Public Sub TaoBaoCaoHocBongHocPhi(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de_hoc_trinh As String, ByVal dtMonHoc As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = gDonvi_do * 0.5
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de_hoc_trinh = Tieu_de_hoc_trinh
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "TBCHT"
        objBaoCaoChiTiet.FieldName = "TBCHT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 5
        objBaoCaoChiTiet.FieldID = "Xep_loai"
        objBaoCaoChiTiet.FieldName = "Xếp loại"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "So_mon_no"
        objBaoCaoChiTiet.FieldName = "Nợ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        If dtMonHoc.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 1.5 + 1.5 + 0.7 + 1.75) * gDonvi_do) / dtMonHoc.Rows.Count
            'Add các cột điểm
            For i As Integer = 0 To dtMonHoc.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = "M" + dtMonHoc.Rows(i)("ID_mon").ToString
                objBaoCaoChiTiet.FieldName = dtMonHoc.Rows(i)("Ky_hieu")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.So_hoc_trinh = dtMonHoc.Rows(i)("So_hoc_trinh")
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        End If
        objBaocao.TaoBaoCaoTongHopDiem("")
    End Sub

    Public Sub TaoBaoCaoBangDiemThanhPhan(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal dtTP As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.8
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần thành phần
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 2.2) * gDonvi_do) / dtTP.Rows.Count
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        End If
        objBaocao.TaoBaoCao("")
    End Sub
    Public Sub TaoBaoCaoBangDiemThiHocPhan(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_ten_truong = "KHOA, BỘ MÔN: ........................"
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần thành phần
            FieldWidth = (PageWidth - (0.8 + 2.2 + 4 + 2 + 2.2) * gDonvi_do) / (dtTP.Rows.Count + 4)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        Else
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 2.2) * gDonvi_do) / 4
        End If
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCMH"
        objBaoCaoChiTiet.FieldName = "TBCMH"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Diem_chu"
        objBaoCaoChiTiet.FieldName = "Điểm chữ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao("")
    End Sub

    Public Sub TaoBaoCaoBangDiemThiHocPhan_DSLop_HC(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable, ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_ten_truong = "KHOA, BỘ MÔN: ........................"
            objBaocao.Tieu_de_chuc_danh1 = "1"
            objBaocao.Tieu_de_chuc_danh2 = "2"
            objBaocao.Tieu_de_nguoi_ky1 = "3"
            objBaocao.Tieu_de_nguoi_ky2 = "- Số đã đạt điểm từ 5.0 đến 6.5: "
            objBaocao.Tieu_de_noi_ky = "- Số đã đạt điểm dưới 5.0: "
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần thành phần
            FieldWidth = (PageWidth - (0.8 + 2.2 + 4 + 2 + 2.2) * gDonvi_do) / (dtTP.Rows.Count + 4)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        Else
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 2.2) * gDonvi_do) / 4
        End If
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCMH"
        objBaoCaoChiTiet.FieldName = "TBCMH"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Diem_chu"
        objBaoCaoChiTiet.FieldName = "Điểm chữ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_DiemThi_LopHC(XS, Gioi, Kha, TB, KDat)
    End Sub

    Public Sub TaoBaoCaoBangDiemThiHocPhan_DSLop_HC_DiemChu(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal dtTP As DataTable, ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_ten_truong = "KHOA, BỘ MÔN: ........................"
            objBaocao.Tieu_de_chuc_danh1 = "1"
            objBaocao.Tieu_de_chuc_danh2 = "2"
            objBaocao.Tieu_de_nguoi_ky1 = "3"
            objBaocao.Tieu_de_nguoi_ky2 = "- Số đã đạt điểm từ 5.0 đến 6.5: "
            objBaocao.Tieu_de_noi_ky = "- Số đã đạt điểm dưới 5.0: "
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        'Add các cột điểm thành phần
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần thành phần
            FieldWidth = (PageWidth - (0.8 + 2.2 + 4 + 2 + 2.2 + 0.5 + 1) * gDonvi_do) / (dtTP.Rows.Count + 4)
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ten_thanh_phan")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        Else
            FieldWidth = (PageWidth - (2.2 + 4 + 2 + 2.2) * gDonvi_do) / 4
        End If
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 6
        objBaoCaoChiTiet.FieldID = "Diem_thi"
        objBaoCaoChiTiet.FieldName = "Điểm thi"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "TBCMH"
        objBaoCaoChiTiet.FieldName = "TBCMH"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 7
        objBaoCaoChiTiet.FieldID = "Diem_chu"
        objBaoCaoChiTiet.FieldName = "Điểm chữ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.5 + FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "Ghi_chu"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 0.8 + FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_DiemThi_LopHC(XS, Gioi, Kha, TB, KDat)
    End Sub

    Public Sub TaoBaoCaoDanhSachThi(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal Tieu_de4 As String, ByVal dtTP As DataTable)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        objBaocao.Tieu_de4 = Tieu_de4
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_ten_truong = "KHOA, BỘ MÔN: ........................"
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_SV"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.3
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ngay_sinh"
        objBaoCaoChiTiet.FieldName = "Ngày sinh"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2.1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        'Thiết lập các trường Học phần báo cáo
        'Add các cột điểm thành phần
        Dim width As Double = 0
        If dtTP.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần thành phần
            'width = FieldWidth
            For i As Integer = 0 To dtTP.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 5
                objBaoCaoChiTiet.FieldID = dtTP.Rows(i)("Ky_hieu").ToString
                objBaoCaoChiTiet.FieldName = dtTP.Rows(i)("Ky_hieu")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = 2
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
                'FieldWidth += FieldWidth / gDonvi_do
                FieldWidth = FieldWidth - 2
            Next
        End If

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "So_to"
        objBaoCaoChiTiet.FieldName = "Số tờ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 0
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ky_nop"
        objBaoCaoChiTiet.FieldName = "Ký nộp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 0
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        FieldWidth = PageWidth - (1 + 2.3 + 4 + 2.5 + 5 + dtTP.Rows.Count * 2) * gDonvi_do

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ghi_chu_thi"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        objBaocao.TaoBaoCao_Modify()
    End Sub
    Public Sub TaoBaoCaoXetSVHoc2ChuyenNganh(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3


        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv1"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten1"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        FieldWidth = PageWidth - (0.8 + 2.2 + 4 + 2 + 2.5) * gDonvi_do
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "Ghi chú"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_CongHoaDocLap_Cap3()
    End Sub

    Public Sub TaoBaoCao_PhanThucTap(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal Tieu_de3 As String, ByVal Tieu_de4 As String)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = 0
        objBaocao.DetailHeight = gDonvi_do * 0.45
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de3 = Tieu_de3
        objBaocao.Tieu_de4 = Tieu_de4


        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong.ToUpper
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.8
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "Ma_sv2"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ho_ten2"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ten_lop2"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        FieldWidth = PageWidth - (0.8 + 2.2 + 4 + 2 + 2.5) * gDonvi_do
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 8
        objBaoCaoChiTiet.FieldID = "Noi_thuc_tap"
        objBaoCaoChiTiet.FieldName = "Nơi thực tập"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCao_CongHoaDocLap_Cap4()
    End Sub

    Public Sub TaoBaoCaoTongHopDiemKy_TichLuy(ByVal c1r As C1Report, ByVal mPaperSize As Printing.PaperKind, ByVal mOrientation As C1.Win.C1Report.OrientationEnum, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String, ByVal dtMonHoc As DataTable, ByVal Nguoi_lap As String, ByVal Chuc_danh As String, ByVal Nguoi_ky As String, ByVal Ghi_chu As String, ByVal Ket_qua_PL As String)
        Dim objBaocao As New BaoCao
        Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
        Dim objBaoCaoChiTiet As ESSBaoCaoChiTietTruong
        Dim PageWidth, FieldWidth As Integer
        Select Case mPaperSize
            Case Printing.PaperKind.A4
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA4
                Else
                    PageWidth = PageHeightA4
                End If
            Case Printing.PaperKind.A3
                If mOrientation = OrientationEnum.Portrait Then
                    PageWidth = PageWidthA3
                Else
                    PageWidth = PageHeightA3
                End If
        End Select
        'Thiết lập báo cáo
        objBaocao.c1r = c1r
        objBaocao.HeaderHeight = gDonvi_do * 3
        objBaocao.PageHeaderHeight = gDonvi_do * 1
        objBaocao.PageHeaderHeight1 = gDonvi_do * 0.5
        objBaocao.DetailHeight = gDonvi_do * 0.5
        objBaocao.PageFooterHeight = gDonvi_do * 0.5
        objBaocao.FooterHeight = gDonvi_do * 3
        objBaocao.Orientation = mOrientation
        objBaocao.PaperSize = mPaperSize
        'Gán tiêu đề cho báo cáo
        objBaocao.Tieu_de1 = Tieu_de1
        objBaocao.Tieu_de2 = Tieu_de2
        objBaocao.Tieu_de_hoc_trinh = "Số tín chỉ"
        If objBaoCaoTieuDe.Count > 0 Then
            objBaocao.Tieu_de_ten_bo = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
            objBaocao.Tieu_de_ten_truong = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
            objBaocao.Tieu_de_chuc_danh1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh1
            objBaocao.Tieu_de_chuc_danh2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_chuc_danh2
            objBaocao.Tieu_de_nguoi_ky1 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky1
            objBaocao.Tieu_de_nguoi_ky2 = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_nguoi_ky2
            objBaocao.Tieu_de_noi_ky = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_noi_ky
        Else
            objBaocao.Tieu_de_ten_bo = ""
            objBaocao.Tieu_de_ten_truong = ""
            objBaocao.Tieu_de_chuc_danh1 = ""
            objBaocao.Tieu_de_chuc_danh2 = ""
            objBaocao.Tieu_de_nguoi_ky1 = ""
            objBaocao.Tieu_de_nguoi_ky2 = ""
            objBaocao.Tieu_de_noi_ky = ""
        End If
        'Thiết lập các trường cố định báo cáo
        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 1
        objBaoCaoChiTiet.FieldID = "STT"
        objBaoCaoChiTiet.FieldName = "STT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 0.7
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 2
        objBaoCaoChiTiet.FieldID = "Ma_sv"
        objBaoCaoChiTiet.FieldName = "Mã sinh viên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldSize = 2.1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 3
        objBaoCaoChiTiet.FieldID = "Ho_ten"
        objBaoCaoChiTiet.FieldName = "Họ và tên"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 4
        objBaoCaoChiTiet.FieldAlign = 1
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = 4
        objBaoCaoChiTiet.FieldID = "Ten_lop"
        objBaoCaoChiTiet.FieldName = "Tên lớp"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.7
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
        Dim i As Integer = 0
        'Thiết lập các trường Học phần báo cáo
        If dtMonHoc.Rows.Count > 0 Then
            'Tính độ rộng của cột điểm Học phần
            FieldWidth = (PageWidth - (0.7 + 2.2 + 4 + 1.7 + 2.3 + 1.3 + 1.3 + 1.6 + 2 + 2 + 1.7) * gDonvi_do) / dtMonHoc.Rows.Count
            'Add các cột điểm
            For i = 0 To dtMonHoc.Rows.Count - 1
                objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
                objBaoCaoChiTiet.STT = i + 3
                objBaoCaoChiTiet.FieldID = "M" + dtMonHoc.Rows(i)("ID_mon").ToString
                objBaoCaoChiTiet.FieldName = dtMonHoc.Rows(i)("Ten_mon")
                objBaoCaoChiTiet.FieldType = 1
                objBaoCaoChiTiet.FieldSize = FieldWidth / gDonvi_do
                objBaoCaoChiTiet.FieldAlign = 2
                objBaoCaoChiTiet.FieldObject = 1
                objBaoCaoChiTiet.So_hoc_trinh = dtMonHoc.Rows(i)("So_hoc_trinh")
                objBaoCaoChiTiet.ColFix = False
                objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)
            Next
        End If

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 5
        objBaoCaoChiTiet.FieldID = "TBCHK_10"
        objBaoCaoChiTiet.FieldName = "TBCHK thang điểm 10"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2.3
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 6
        objBaoCaoChiTiet.FieldID = "TBCHT"
        objBaoCaoChiTiet.FieldName = "TBCHK"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.3
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 7
        objBaoCaoChiTiet.FieldID = "TBCTL"
        objBaoCaoChiTiet.FieldName = "TBCTL"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.3
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 8
        objBaoCaoChiTiet.FieldID = "So_tc_tichluy"
        objBaoCaoChiTiet.FieldName = "Số TC tích luỹ"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.4
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 9
        objBaoCaoChiTiet.FieldID = "Nam_dao_tao"
        objBaoCaoChiTiet.FieldName = "Xếp hạng năm ĐT"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 1.6
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaoCaoChiTiet = New ESSBaoCaoChiTietTruong
        objBaoCaoChiTiet.STT = i + 10
        objBaoCaoChiTiet.FieldID = "Xep_hang_HT"
        objBaoCaoChiTiet.FieldName = "Xếp hạng"
        objBaoCaoChiTiet.FieldType = 1
        objBaoCaoChiTiet.FieldSize = 2.1
        objBaoCaoChiTiet.FieldAlign = 2
        objBaoCaoChiTiet.FieldObject = 1
        objBaocao.BaoCaoChiTiet.Add(objBaoCaoChiTiet)

        objBaocao.TaoBaoCaoTongHopDiemKy_Tichluy(Nguoi_lap, Chuc_danh, Nguoi_ky, Ghi_chu, Ket_qua_PL)
    End Sub
End Module