<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMARK_DanhSachThiSinhThiLaiTheoMonHoc
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.STT = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ma_sinh_vien = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_sinh_vien = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ngay_sinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_lop = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ghi_chu = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Tieu_de3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ngay_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel
        Me.FormattingRule1 = New DevExpress.XtraReports.UI.FormattingRule
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(772.9999!, 25.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.STT, Me.Ma_sinh_vien, Me.Ten_sinh_vien, Me.Ngay_sinh, Me.Ten_lop, Me.Ghi_chu})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'STT
        '
        Me.STT.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.STT.Name = "STT"
        Me.STT.StylePriority.UseFont = False
        Me.STT.Text = "STT"
        Me.STT.Weight = 0.5
        '
        'Ma_sinh_vien
        '
        Me.Ma_sinh_vien.Name = "Ma_sinh_vien"
        Me.Ma_sinh_vien.Text = "Mã sinh viên"
        Me.Ma_sinh_vien.Weight = 1.5
        '
        'Ten_sinh_vien
        '
        Me.Ten_sinh_vien.Name = "Ten_sinh_vien"
        Me.Ten_sinh_vien.Text = "Họ và tên"
        Me.Ten_sinh_vien.Weight = 2.1916662201217108
        '
        'Ngay_sinh
        '
        Me.Ngay_sinh.Name = "Ngay_sinh"
        Me.Ngay_sinh.Text = "Ngày sinh"
        Me.Ngay_sinh.Weight = 1.0776049016004594
        Me.Ngay_sinh.XlsxFormatString = "{0:dd/MM/yyy}"
        '
        'Ten_lop
        '
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.Text = "Tên lớp"
        Me.Ten_lop.Weight = 0.98072821548439459
        '
        'Ghi_chu
        '
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.Text = "Ghi chú"
        Me.Ghi_chu.Weight = 1.4800000524418733
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 17.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 49.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de3, Me.Tieu_de2, Me.Tieu_de1, Me.XrLabel2, Me.XrLabel1, Me.XrLine1, Me.Tieu_de_ten_bo, Me.Tieu_de_ten_truong, Me.XrLine2})
        Me.ReportHeader.HeightF = 206.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Tieu_de3
        '
        Me.Tieu_de3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 169.7917!)
        Me.Tieu_de3.Name = "Tieu_de3"
        Me.Tieu_de3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de3.SizeF = New System.Drawing.SizeF(773.0!, 28.20833!)
        Me.Tieu_de3.StylePriority.UseFont = False
        Me.Tieu_de3.StylePriority.UseTextAlignment = False
        Me.Tieu_de3.Text = "Tieu_de3"
        Me.Tieu_de3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de2
        '
        Me.Tieu_de2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de2.LocationFloat = New DevExpress.Utils.PointFloat(0.00002384186!, 138.0833!)
        Me.Tieu_de2.Name = "Tieu_de2"
        Me.Tieu_de2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de2.SizeF = New System.Drawing.SizeF(773.0!, 28.20833!)
        Me.Tieu_de2.StylePriority.UseFont = False
        Me.Tieu_de2.StylePriority.UseTextAlignment = False
        Me.Tieu_de2.Text = "Tieu_de2"
        Me.Tieu_de2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de1
        '
        Me.Tieu_de1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 107.875!)
        Me.Tieu_de1.Name = "Tieu_de1"
        Me.Tieu_de1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de1.SizeF = New System.Drawing.SizeF(773.0!, 28.20833!)
        Me.Tieu_de1.StylePriority.UseFont = False
        Me.Tieu_de1.StylePriority.UseTextAlignment = False
        Me.Tieu_de1.Text = "Tieu_de1"
        Me.Tieu_de1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(437.5!, 50.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(333.8335!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ĐỘC LẬP - TỰ DO - HẠNH PHÚC"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(437.5!, 25.0!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(333.8334!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 62.5!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(206.25!, 23.0!)
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(419.1666!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 50.0!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(419.1666!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(87.5!, 62.5!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(259.375!, 23.0!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.PageHeader.HeightF = 25.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(772.9999!, 25.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell6, Me.XrTableCell5})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "STT"
        Me.XrTableCell1.Weight = 0.5
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "Mã sinh viên"
        Me.XrTableCell2.Weight = 1.5
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Họ và tên"
        Me.XrTableCell3.Weight = 2.1916662201217108
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "Ngày sinh"
        Me.XrTableCell4.Weight = 1.0776053593641672
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "Tên lớp"
        Me.XrTableCell6.Weight = 0.98072821548439437
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Ghi chú"
        Me.XrTableCell5.Weight = 1.4799995946781652
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_noi_ky, Me.Tieu_de_nguoi_ky2, Me.Tieu_de_chuc_danh3, Me.Tieu_de_nguoi_ky1, Me.Tieu_de_nguoi_ky3, Me.Tieu_de_chuc_danh2, Me.Tieu_de_ngay_ky, Me.Tieu_de_nguoi_ky4, Me.Tieu_de_chuc_danh4, Me.Tieu_de_chuc_danh1})
        Me.ReportFooter.HeightF = 175.9999!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat(455.2709!, 0.0!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF(119.7291!, 22.99999!)
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.Text = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        '
        'Tieu_de_nguoi_ky2
        '
        Me.Tieu_de_nguoi_ky2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky2.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 150.0!)
        Me.Tieu_de_nguoi_ky2.Name = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky2.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_nguoi_ky2.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky2.Text = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_nguoi_ky2.Visible = False
        '
        'Tieu_de_chuc_danh3
        '
        Me.Tieu_de_chuc_danh3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh3.LocationFloat = New DevExpress.Utils.PointFloat(512.5!, 37.5!)
        Me.Tieu_de_chuc_danh3.Name = "Tieu_de_chuc_danh3"
        Me.Tieu_de_chuc_danh3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh3.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_chuc_danh3.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh3.Text = "Tieu_de_chuc_danh3"
        Me.Tieu_de_chuc_danh3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 150.0!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.Text = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_nguoi_ky3
        '
        Me.Tieu_de_nguoi_ky3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky3.LocationFloat = New DevExpress.Utils.PointFloat(512.5!, 150.0!)
        Me.Tieu_de_nguoi_ky3.Name = "Tieu_de_nguoi_ky3"
        Me.Tieu_de_nguoi_ky3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky3.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_nguoi_ky3.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky3.Text = "Tieu_de_nguoi_ky3"
        Me.Tieu_de_nguoi_ky3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat(262.5!, 37.5!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.Text = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_chuc_danh2.Visible = False
        '
        'Tieu_de_ngay_ky
        '
        Me.Tieu_de_ngay_ky.LocationFloat = New DevExpress.Utils.PointFloat(575.0!, 0.0!)
        Me.Tieu_de_ngay_ky.Name = "Tieu_de_ngay_ky"
        Me.Tieu_de_ngay_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ngay_ky.SizeF = New System.Drawing.SizeF(182.2292!, 22.99999!)
        Me.Tieu_de_ngay_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ngay_ky.Text = "Tieu_de_ngay_ky"
        Me.Tieu_de_ngay_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'Tieu_de_nguoi_ky4
        '
        Me.Tieu_de_nguoi_ky4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky4.LocationFloat = New DevExpress.Utils.PointFloat(512.5!, 150.0!)
        Me.Tieu_de_nguoi_ky4.Name = "Tieu_de_nguoi_ky4"
        Me.Tieu_de_nguoi_ky4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky4.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_nguoi_ky4.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky4.Text = "Tieu_de_nguoi_ky4"
        Me.Tieu_de_nguoi_ky4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_nguoi_ky4.Visible = False
        '
        'Tieu_de_chuc_danh4
        '
        Me.Tieu_de_chuc_danh4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh4.LocationFloat = New DevExpress.Utils.PointFloat(512.5!, 37.5!)
        Me.Tieu_de_chuc_danh4.Name = "Tieu_de_chuc_danh4"
        Me.Tieu_de_chuc_danh4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh4.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_chuc_danh4.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh4.Text = "Tieu_de_chuc_danh4"
        Me.Tieu_de_chuc_danh4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_chuc_danh4.Visible = False
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 37.5!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF(208.2708!, 22.99999!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.Text = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'FormattingRule1
        '
        Me.FormattingRule1.Name = "FormattingRule1"
        '
        'rptMARK_DanhSachThiSinhThiLaiTheoMonHoc
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader, Me.ReportFooter})
        Me.FormattingRuleSheet.AddRange(New DevExpress.XtraReports.UI.FormattingRule() {Me.FormattingRule1})
        Me.Margins = New System.Drawing.Printing.Margins(36, 39, 17, 49)
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents STT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ma_sinh_vien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_sinh_vien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ngay_sinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ghi_chu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_lop As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents FormattingRule1 As DevExpress.XtraReports.UI.FormattingRule
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ngay_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de2 As DevExpress.XtraReports.UI.XRLabel
End Class
