'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports C1.Win.C1Report
Imports System.Drawing
Namespace Bussines
    Public Class BaoCao
#Region "Const"
        Private Const gDonvi_do As Double = 567 '=1 cm . Chuyen doi tu Twips sang Centimeter
        Private Const gPointToCm As Double = 28.3   '=1 cm. Chuyen doi tu Point sang Centimeter
        Private Const WidthA4 As Double = gDonvi_do * 21
        Private Const HeightA4 As Double = gDonvi_do * 29.7
        Private Const WidthA3 As Double = gDonvi_do * 29.7
        Private Const HeightA3 As Double = gDonvi_do * 42
#End Region

#Region "Variable"
        Private mc1r As C1Report
        Private mPaperSize As Printing.PaperKind
        Private mOrientation As OrientationEnum
        Private mHeaderHeight As Integer
        Private mPageHeaderHeight As Integer
        Private mPageHeaderHeight1 As Integer
        Private mDetailHeight As Integer
        Private mPageFooterHeight As Integer
        Private mFooterHeight As Integer

        Private mTieu_de1 As String
        Private mTieu_de2 As String
        Private mTieu_de3 As String
        Private mTieu_de4 As String
        Private mTieu_de_hoc_trinh As String
        Private mTieu_de_ten_bo As String
        Private mTieu_de_Ten_truong As String
        Private mTieu_de_chuc_danh1 As String
        Private mTieu_de_chuc_danh2 As String
        Private mTieu_de_chuc_danh3 As String
        Private mTieu_de_chuc_danh4 As String
        Private mTieu_de_nguoi_ky1 As String
        Private mTieu_de_nguoi_ky2 As String
        Private mTieu_de_nguoi_ky3 As String
        Private mTieu_de_nguoi_ky4 As String
        Private mTieu_de_noi_ky As String
        Private mBaoCaoChiTiet As New ESSBaoCaoChiTietTruong
#End Region

#Region "Functions"
        Public Sub TaoBaoCaoTongHopDiemKy_Tichluy(ByVal Nguoi_lap As String, ByVal Chuc_danh As String, ByVal Nguoi_ky As String, ByVal Ghi_chu As String, ByVal Ket_qua_PL As String)
            'Tạo báo cáo
            TaoBaoCaoKy_TichLuy(Nguoi_lap, Chuc_danh, Nguoi_ky, Ghi_chu, Ket_qua_PL)
            'So hoc trinh
            AddRowSoHocTrinh()
        End Sub

        Public Sub TaoBaoCaoKy_TichLuy(ByVal Nguoi_lap As String, ByVal Chuc_danh As String, ByVal Nguoi_ky As String, ByVal Ghi_chu As String, ByVal Ket_qua_PL As String)
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 0, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 250, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 0, 600, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 16, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 0, 1100, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Ket_qua_PL", Ket_qua_PL, 0, 100, PageWidth / 2, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                If Ghi_chu.Trim <> "" Then Ghi_chu = "Ghi chú:  " & Ghi_chu
                f = .Fields.Add("Ghi_chu", Ghi_chu, 0, 500, PageWidth - 500, 300)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Ngay_ky", """" + Tieu_de_noi_ky + """" + " & Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2, 1200, PageWidth / 2, 300)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Tieu_de_nguoi_ky1", "Người lập biểu", 0, 1800, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Nguoi_lap, 0, 3000, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", "TL.GIÁM ĐỐC", PageWidth / 2, 1500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Chuc_danh, PageWidth / 2, 1800, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Nguoi_ky, PageWidth / 2, 3000, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCaoTongHopDiem(ByVal sGhi_chu As String)
            'Tạo báo cáo
            TaoBaoCao(sGhi_chu)
            'So hoc trinh
            AddRowSoHocTrinh()
        End Sub

        Public Sub TaoBaoCao(ByVal sGhi_chu As String)
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 0, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 250, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 0, 600, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 16, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 0, 1100, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Ghi_chu", sGhi_chu, 0, 100, PageWidth, gDonvi_do * 1)
                f.CanGrow = True
                f.CanShrink = True
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle
                f.Calculated = True



                f = .Fields.Add("Tieu_de_noi_ky", """" + Tieu_de_noi_ky + " Ngày """ + " & Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2, 1600, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Tieu_de_chuc_danh1", Tieu_de_chuc_danh1, 0, 2000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, 0, 3200, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_chuc_danh2", Tieu_de_chuc_danh2, PageWidth / 4, 2000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky2", Tieu_de_nguoi_ky2, PageWidth / 4, 3200, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_chuc_danh3", Tieu_de_chuc_danh3, PageWidth / 2, 2000, PageWidth / 3 + 100, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky3", Tieu_de_nguoi_ky3, PageWidth / 2, 3200, PageWidth / 3 + 100, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCao_DiemThanhPhan()
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 0, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 250, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 0, 500, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 16, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 0, 1000, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de3", Tieu_de3, 0, 1400, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Tieu_de_noi_ky", """" + Tieu_de_noi_ky + " """ + " & Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2, 150, PageWidth / 2, 300)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Tieu_de_chuc_danh1", Tieu_de_chuc_danh1, PageWidth / 2 + 100, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, PageWidth / 2 + 100, 1200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_chuc_danh2", Tieu_de_chuc_danh2, PageWidth / 4 + 100, 500, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky2", Tieu_de_nguoi_ky2, PageWidth / 4 + 100, 1200, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle


                f = .Fields.Add("Tieu_de_chuc_danh1", Tieu_de_chuc_danh1, 100, 500, PageWidth / 4, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, 100, 1200, PageWidth / 4, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCao_CongHoaDocLap_Cap3()
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 150, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 500, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 600, 0, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 13, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 600, 500, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de3", Tieu_de3, 600, 900, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Ngay_ky", """" + Tieu_de_noi_ky + """" + "& Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2, 150, PageWidth / 2, 300)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_chuc_danh1, 0, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, 0, 2200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_chuc_danh2, PageWidth / 2, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky2, PageWidth / 2, 2200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCao_CongHoaDocLap_Cap4()
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 150, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 500, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 600, 0, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 13, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 600, 500, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de3", Tieu_de3, 600, 900, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 13, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de4", Tieu_de4, 0, 1300, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 11, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Ngay_ky", """" + Tieu_de_noi_ky + """" + "& Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2, 150, PageWidth / 2, 300)
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle
                f.Calculated = True

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_chuc_danh1, 0, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, 0, 2200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_chuc_danh2, PageWidth / 2, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky2, PageWidth / 2, 2200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCao_DiemThi_LopHC(ByVal XS As Integer, ByVal Gioi As Integer, ByVal Kha As Integer, ByVal TB As Integer, ByVal KDat As Integer)
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 150, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 500, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 600, 0, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 13, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 600, 500, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de3", Tieu_de3, 600, 900, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle
                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With
            Dim TongSV As Integer = XS + Gioi + Kha + TB + KDat
            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Ghi_chu", "- Số đã đạt điểm từ 9.0 đến 10:   " & XS.ToString & vbTab & "Tỷ lệ: " & CType(Math.Round(XS / TongSV, 4) * 100, String) & " %", 0, 250, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle
                f = .Fields.Add("Ghi_chu", "- Số đã đạt điểm từ 8.0 đến 8.5:  " & Gioi & vbTab & "Tỷ lệ: " & Math.Round(Gioi / TongSV, 4) * 100 & " %", 0, 500, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle
                f = .Fields.Add("Ghi_chu", "- Số đã đạt điểm từ 7.0 đến 7.5:  " & Kha & vbTab & "Tỷ lệ: " & Math.Round(Kha / TongSV, 4) * 100 & " %", 0, 750, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle
                f = .Fields.Add("Ghi_chu", "- Số đã đạt điểm từ 5.0 đến 6.5:  " & TB & vbTab & "Tỷ lệ: " & Math.Round(TB / TongSV, 4) * 100 & " %", 0, 1000, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle
                f = .Fields.Add("Ghi_chu", "- Số đã đạt điểm dưới 5.0:          " & KDat & vbTab & "Tỷ lệ: " & Math.Round(KDat / TongSV, 4) * 100 & " %", 0, 1250, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle


                f = .Fields.Add("Tieu_de_chuc_danh1", Tieu_de_chuc_danh1, 0, 2000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", Tieu_de_nguoi_ky1, 0, 3000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle


                f = .Fields.Add("Tieu_de_chuc_danh2", Tieu_de_chuc_danh2, PageWidth / 4, 2000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky2", Tieu_de_nguoi_ky2, PageWidth / 4, 3000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_noi_ky", """" + Tieu_de_noi_ky + """" + "& Day(Now) & " + """ tháng """ + " & month(now) & " + """ năm """ + " & year(now)", PageWidth / 2 + 500, 1600, PageWidth / 3, gDonvi_do * 0.5)
                f.Calculated = True
                f.Font = New Font("Arial", 10, FontStyle.Italic)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_chuc_danh3", Tieu_de_chuc_danh3, PageWidth / 2 + 500, 2000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky3", Tieu_de_nguoi_ky3, PageWidth / 2 + 500, 3000, PageWidth / 3, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub

        Public Sub TaoBaoCao_Modify()
            Dim PageWidth As Integer
            Dim f As Field
            With c1r
                .Clear()
                .Font.Name = "Arial"
                .Font.Size = 10
            End With
            'Thiết lập trang in
            With c1r.Layout
                .Orientation = Orientation
                .PaperSize = PaperSize
                .MarginLeft = 1.27 * gDonvi_do
                .MarginRight = 0.5 * gDonvi_do
                .MarginTop = 1 * gDonvi_do
                .MarginBottom = 0.5 * gDonvi_do
                If PaperSize = Printing.PaperKind.A4 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA4
                    Else
                        .Width = HeightA4
                    End If
                ElseIf PaperSize = Printing.PaperKind.A3 Then
                    If Orientation = OrientationEnum.Portrait Then
                        .Width = WidthA3
                    Else
                        .Width = HeightA3
                    End If
                End If
                PageWidth = .Width
            End With
            'Add thông tin tiêu đề báo cáo Header
            With c1r.Sections(SectionTypeEnum.Header)
                f = .Fields.Add("Tieu_de_ten_bo", Tieu_de_ten_bo, 0, 150, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_ten_truong", Tieu_de_ten_truong, 0, 500, PageWidth / 3, 250)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de1", Tieu_de1, 600, 0, PageWidth, gDonvi_do)
                f.Font = New Font("Arial", 13, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de2", Tieu_de2, 600, 500, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de3", Tieu_de3, 600, 800, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de4", Tieu_de4, 0, 1300, PageWidth, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 12, FontStyle.Bold)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = HeaderHeight
                .Visible = True
            End With

            'Add thông tin Page Header, Detail
            AddFieldToReport()
            'Add thông tin Page Footer
            With c1r.Sections(SectionTypeEnum.PageFooter)
                f = .Fields.Add("Trang", """Trang: """ + "& [Page] & " + """ / """ + "& [Pages]", 0, 50, PageWidth - 1100, 300)
                f.Font = New Font("Arial", 10, FontStyle.Bold)
                f.Align = FieldAlignEnum.RightMiddle
                f.Calculated = True
                .Height = PageFooterHeight
                .Visible = True
            End With

            'Add thông tin cuối báo cáo Footer
            With c1r.Sections(SectionTypeEnum.Footer)
                f = .Fields.Add("Tieu_de_nguoi_ky1", "Tổng số bài: ....", 0, 200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", "Cán bộ coi thi 1: ..................................", 0, 600, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.LeftMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", "Tổng số tờ:....", PageWidth / 5, 200, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.CenterMiddle

                f = .Fields.Add("Tieu_de_nguoi_ky1", "Cán bộ coi thi 2: ..................................", PageWidth / 3, 600, PageWidth / 2, gDonvi_do * 0.5)
                f.Font = New Font("Arial", 10, FontStyle.Regular)
                f.Align = FieldAlignEnum.CenterMiddle

                .Height = FooterHeight
                .Visible = True
            End With
        End Sub
        Private Sub AddFieldToReport()
            Dim f As Field
            Dim FieldTop, FieldLeft, FieldWidth, PageWidth As Double
            Dim i As Integer
            c1r.Sections(SectionTypeEnum.Detail).Visible = True
            c1r.Sections(SectionTypeEnum.PageHeader).Visible = True
            'Chiều cao phần Detail
            c1r.Sections(SectionTypeEnum.Detail).Height = DetailHeight
            'Chiều cao phần PageHeader
            c1r.Sections(SectionTypeEnum.PageHeader).Height = PageHeaderHeight + PageHeaderHeight1
            'Add First Line to Page header
            AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L00", 0, 0, 2, PageHeaderHeight + PageHeaderHeight1 + 20, Color.Black)
            'Add First Line to Detail
            AddLineToReport(c1r, SectionTypeEnum.Detail, "1L00", 0, 0, 2, DetailHeight + 15, Color.Black)
            'Add Fields to Pageheader and Detail
            For i = 0 To mBaoCaoChiTiet.Count - 1
                Dim Field As ESSBaoCaoChiTietTruong = mBaoCaoChiTiet.ESSBaoCaoChiTietTruong(i)
                FieldWidth = Field.FieldSize * gDonvi_do
                PageWidth = PageWidth + FieldWidth

                'Fields Detail
                With c1r.Sections(SectionTypeEnum.Detail)
                    If Field.FieldID.Trim.ToUpper = "STT" Then
                        f = .Fields.Add("1" & Field.FieldID, "=1", FieldLeft + 30, FieldTop, FieldWidth, DetailHeight)
                        f.RunningSum = RunningSumEnum.SumOverAll
                    Else
                        If Field.FieldObject = 0 Then 'Trường rỗng không có giá trị
                            f = .Fields.Add("1" & Field.FieldID, "", FieldLeft + 30, FieldTop, FieldWidth, DetailHeight)
                        Else
                            f = .Fields.Add("1" & Field.FieldID, Field.FieldID, FieldLeft + 30, FieldTop, FieldWidth, DetailHeight)
                        End If
                    End If
                    f.WordWrap = True
                    f.Calculated = True
                    'Align Field
                    If Field.FieldAlign = 1 Then
                        f.Align = FieldAlignEnum.LeftMiddle
                    ElseIf Field.FieldAlign = 2 Then
                        f.Align = FieldAlignEnum.CenterMiddle
                    Else
                        f.Align = FieldAlignEnum.RightMiddle
                    End If
                    'Format Field Type Date
                    If Not IsDBNull(Field.FieldType) Then
                        If Field.FieldType = 2 Then f.Format = "dd/MM/yyyy"
                    End If
                End With
                'Fields PageHeader
                With c1r.Sections(SectionTypeEnum.PageHeader)
                    f = .Fields.Add("2" & Field.FieldID, Field.FieldName, FieldLeft + 30, FieldTop, FieldWidth, PageHeaderHeight)
                    f.Align = FieldAlignEnum.CenterMiddle
                End With
                'ESSTang toa do trai	ve duong thang dung
                FieldLeft = FieldLeft + FieldWidth
                'Add line to detail
                AddLineToReport(c1r, SectionTypeEnum.Detail, "1L" & Field.FieldID, FieldLeft, 0, 0, DetailHeight + 15, Color.Black)
                'Add line to Page Header
                With c1r.Sections(SectionTypeEnum.PageHeader)
                    'Add line to page header
                    If Field.ColFix Then
                        AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L" & Field.FieldID, FieldLeft, 0, 0, PageHeaderHeight, Color.Black)
                    Else
                        AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L" & Field.FieldID, FieldLeft, 0, 0, PageHeaderHeight + PageHeaderHeight1 + 20, Color.Black)
                    End If
                End With
            Next
            'Add line H to detail
            AddLineToReport(c1r, SectionTypeEnum.Detail, "1L01", 0, DetailHeight + 10, PageWidth, 0, Color.Red, 1)
            'Add line1 H to page header
            AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L01", 0, 0, PageWidth, 0, Color.Black, 30)
            'Add line2 H to page header
            AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L02", 0, PageHeaderHeight + 10, PageWidth, 0, Color.Black, 1)
            c1r.Layout.Width = PageWidth
            c1r.Sections(SectionTypeEnum.PageHeader).BackColor = Color.Gainsboro
        End Sub
        Private Sub AddRowSoHocTrinh()
            Dim f As Field
            Dim FieldTop, FieldLeft, FieldWidth, PageWidth As Double
            Dim i As Integer, Possition As Long = -1
            'Add dòng số học trình
            FieldWidth = 0
            FieldWidth = 0
            FieldLeft = 0
            FieldTop = PageHeaderHeight
            For i = 0 To mBaoCaoChiTiet.Count - 1
                Dim Field As ESSBaoCaoChiTietTruong = mBaoCaoChiTiet.ESSBaoCaoChiTietTruong(i)
                FieldWidth = Field.FieldSize * gDonvi_do
                PageWidth = PageWidth + FieldWidth
                If Field.ColFix Then
                    FieldLeft += Field.FieldSize * gDonvi_do
                Else
                    If Possition = -1 Then
                        'Add tiêu đề số học trình
                        With c1r.Sections(SectionTypeEnum.PageHeader)
                            f = .Fields.Add("DonViHocTrinh", Tieu_de_hoc_trinh, 30, FieldTop, PageWidth, PageHeaderHeight1)
                            f.Align = FieldAlignEnum.CenterMiddle
                            'Add line to page header
                            AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L" & Field.FieldID, FieldLeft, 0, 0, PageHeaderHeight + PageHeaderHeight1 + 20, Color.Black)
                        End With
                        'Add các cột số học trình
                        With c1r.Sections(SectionTypeEnum.PageHeader)
                            f = .Fields.Add("21" & Field.FieldID, Field.So_hoc_trinh, FieldLeft + 30, FieldTop, FieldWidth, PageHeaderHeight1)
                            f.Align = FieldAlignEnum.CenterMiddle
                        End With
                        Possition = 0
                        FieldWidth = 0
                    Else
                        'Add các cột số học trình
                        FieldLeft += FieldWidth
                        With c1r.Sections(SectionTypeEnum.PageHeader)
                            f = .Fields.Add("21" & Field.FieldID, Field.So_hoc_trinh, FieldLeft + 30, FieldTop, FieldWidth, PageHeaderHeight1)
                            f.Align = FieldAlignEnum.CenterMiddle
                        End With
                    End If
                End If
            Next
            'Add line3 H to page header
            AddLineToReport(c1r, SectionTypeEnum.PageHeader, "2L02", 0, PageHeaderHeight + PageHeaderHeight1 + 10, PageWidth, 0, Color.Black, 30)
        End Sub
        Private Sub AddLineToReport(ByVal c1r As C1Report, ByVal Section As SectionTypeEnum, ByVal FieldName As String, _
            ByVal FieldLeft As Double, ByVal FieldTop As Double, ByVal FieldWidth As Double, ByVal FieldHeight As Double, _
            ByVal LineColor As Color, Optional ByVal LineWidth As Byte = 5, Optional ByVal LineStyle As LineSlantEnum = LineSlantEnum.NoSlant, _
            Optional ByVal LineBorder As BorderStyleEnum = BorderStyleEnum.Solid)
            Dim f As Field
            With c1r.Sections(Section)
                'Ke duong thang dung dau tien
                f = .Fields.Add(FieldName, "", FieldLeft, FieldTop, FieldWidth, FieldHeight)
                f.LineSlant = LineStyle
                f.LineWidth = LineWidth
                f.BorderStyle = LineBorder
                f.BorderColor = LineColor
            End With
        End Sub
#End Region

#Region "Property"
        Public Property c1r() As C1Report
            Get
                Return mc1r
            End Get
            Set(ByVal Value As C1Report)
                mc1r = Value
            End Set
        End Property
        Public Property PaperSize() As Printing.PaperKind
            Get
                Return mPaperSize
            End Get
            Set(ByVal Value As Printing.PaperKind)
                mPaperSize = Value
            End Set
        End Property
        Public Property Orientation() As OrientationEnum
            Get
                Return mOrientation
            End Get
            Set(ByVal Value As OrientationEnum)
                mOrientation = Value
            End Set
        End Property
        Public Property HeaderHeight() As Integer
            Get
                Return mHeaderHeight
            End Get
            Set(ByVal Value As Integer)
                mHeaderHeight = Value
            End Set
        End Property
        Public Property PageHeaderHeight() As Integer
            Get
                Return mPageHeaderHeight
            End Get
            Set(ByVal Value As Integer)
                mPageHeaderHeight = Value
            End Set
        End Property
        Public Property PageHeaderHeight1() As Integer
            Get
                Return mPageHeaderHeight1
            End Get
            Set(ByVal Value As Integer)
                mPageHeaderHeight1 = Value
            End Set
        End Property
        Public Property DetailHeight() As Integer
            Get
                Return mDetailHeight
            End Get
            Set(ByVal Value As Integer)
                mDetailHeight = Value
            End Set
        End Property
        Public Property PageFooterHeight() As Integer
            Get
                Return mPageFooterHeight
            End Get
            Set(ByVal Value As Integer)
                mPageFooterHeight = Value
            End Set
        End Property
        Public Property FooterHeight() As Integer
            Get
                Return mFooterHeight
            End Get
            Set(ByVal Value As Integer)
                mFooterHeight = Value
            End Set
        End Property
        Public Property Tieu_de1() As String
            Get
                Return mTieu_de1
            End Get
            Set(ByVal Value As String)
                mTieu_de1 = Value
            End Set
        End Property
        Public Property Tieu_de2() As String
            Get
                Return mTieu_de2
            End Get
            Set(ByVal Value As String)
                mTieu_de2 = Value
            End Set
        End Property
        Public Property Tieu_de3() As String
            Get
                Return mTieu_de3
            End Get
            Set(ByVal Value As String)
                mTieu_de3 = Value
            End Set
        End Property
        Public Property Tieu_de4() As String
            Get
                Return mTieu_de4
            End Get
            Set(ByVal Value As String)
                mTieu_de4 = Value
            End Set
        End Property
        Public Property Tieu_de_hoc_trinh() As String
            Get
                Return mTieu_de_hoc_trinh
            End Get
            Set(ByVal Value As String)
                mTieu_de_hoc_trinh = Value
            End Set
        End Property
        Public Property Tieu_de_ten_bo() As String
            Get
                Return mTieu_de_ten_bo
            End Get
            Set(ByVal Value As String)
                mTieu_de_ten_bo = Value
            End Set
        End Property
        Public Property Tieu_de_ten_truong() As String
            Get
                Return mTieu_de_Ten_truong
            End Get
            Set(ByVal Value As String)
                mTieu_de_Ten_truong = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh1() As String
            Get
                Return mTieu_de_chuc_danh1
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh1 = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh2() As String
            Get
                Return mTieu_de_chuc_danh2
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh2 = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh3() As String
            Get
                Return mTieu_de_chuc_danh3
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh3 = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh4() As String
            Get
                Return mTieu_de_chuc_danh4
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh4 = Value
            End Set
        End Property

        Public Property Tieu_de_nguoi_ky1() As String
            Get
                Return mTieu_de_nguoi_ky1
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky1 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky2() As String
            Get
                Return mTieu_de_nguoi_ky2
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky2 = Value
            End Set
        End Property

        Public Property Tieu_de_nguoi_ky3() As String
            Get
                Return mTieu_de_nguoi_ky3
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky3 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky4() As String
            Get
                Return mTieu_de_nguoi_ky4
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky4 = Value
            End Set
        End Property

        Public Property Tieu_de_noi_ky() As String
            Get
                Return mTieu_de_noi_ky
            End Get
            Set(ByVal Value As String)
                mTieu_de_noi_ky = Value
            End Set
        End Property
        Public Property BaoCaoChiTiet() As ESSBaoCaoChiTietTruong
            Get
                Return mBaoCaoChiTiet
            End Get
            Set(ByVal Value As ESSBaoCaoChiTietTruong)
                mBaoCaoChiTiet = Value
            End Set
        End Property
#End Region
    End Class
End Namespace