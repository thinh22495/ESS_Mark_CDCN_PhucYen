<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptPlan_ThoiKhoaBieu_PhongHoc1
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
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.txtTen_phong = New DevExpress.XtraReports.UI.XRLabel
        Me.XrSubreport1 = New DevExpress.XtraReports.UI.XRSubreport
        Me.RptMARK_BangDiemSinhVien_SubI1 = New ESSReports.rptPlan_DanhSach_PhongHoc
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.Tieu_de = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.XrControlStyle1 = New DevExpress.XtraReports.UI.XRControlStyle
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RptMARK_BangDiemSinhVien_SubI1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1, Me.XrSubreport1})
        Me.Detail.HeightF = 45.91999!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable1
        '
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0.00001589457!, 0.0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(783.6386!, 22.91667!)
        Me.XrTable1.StylePriority.UseBorders = False
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.txtTen_phong})
        Me.XrTableCell1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.StylePriority.UseTextAlignment = False
        Me.XrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell1.Weight = 2.9877033514577294
        '
        'txtTen_phong
        '
        Me.txtTen_phong.BackColor = System.Drawing.Color.LightCyan
        Me.txtTen_phong.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTen_phong.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.txtTen_phong.Name = "txtTen_phong"
        Me.txtTen_phong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.txtTen_phong.SizeF = New System.Drawing.SizeF(783.64!, 22.92!)
        Me.txtTen_phong.StylePriority.UseBackColor = False
        Me.txtTen_phong.StylePriority.UseBorderColor = False
        Me.txtTen_phong.StylePriority.UseBorders = False
        Me.txtTen_phong.StylePriority.UseFont = False
        Me.txtTen_phong.StylePriority.UseTextAlignment = False
        Me.txtTen_phong.Text = "Ten_phong"
        Me.txtTen_phong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrSubreport1
        '
        Me.XrSubreport1.LocationFloat = New DevExpress.Utils.PointFloat(0.6543557!, 22.91997!)
        Me.XrSubreport1.Name = "XrSubreport1"
        Me.XrSubreport1.ReportSource = Me.RptMARK_BangDiemSinhVien_SubI1
        Me.XrSubreport1.SizeF = New System.Drawing.SizeF(782.9857!, 23.00002!)
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 28.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Tieu_de
        '
        Me.Tieu_de.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 90.20831!)
        Me.Tieu_de.Name = "Tieu_de"
        Me.Tieu_de.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de.SizeF = New System.Drawing.SizeF(762.9999!, 23.0!)
        Me.Tieu_de.StylePriority.UseFont = False
        Me.Tieu_de.StylePriority.UseTextAlignment = False
        Me.Tieu_de.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(9.999998!, 68.20831!)
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(762.9999!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.StylePriority.UseTextAlignment = False
        Me.XrLabel3.Text = "THỜI KHÓA BIỂU THEO PHÒNG HỌC"
        Me.XrLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(114.2708!, 45.45831!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(190.625!, 5.708351!)
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(32.42655!, 24.66666!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(343.292!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.Text = "TRƯỜNG CAO ĐẲNG SƯ PHẠM"
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 1.666657!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(419.1666!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(492.6665!, 35.16666!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(206.25!, 23.0!)
        '
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(429.1665!, 24.66666!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(333.8335!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "Độc lập - Tự do - Hạnh phúc"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLabel1
        '
        Me.XrLabel1.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(429.1665!, 1.666657!)
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(333.8334!, 23.0!)
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrControlStyle1
        '
        Me.XrControlStyle1.Name = "XrControlStyle1"
        Me.XrControlStyle1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel3, Me.Tieu_de, Me.XrLabel2, Me.XrLabel1, Me.XrLine1, Me.Tieu_de_ten_bo, Me.XrLine2, Me.Tieu_de_ten_truong})
        Me.ReportHeader.HeightF = 122.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable2
        '
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0.0001351039!, 0.0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(783.6386!, 46.0!)
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell9, Me.XrTableCell5})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseFont = False
        Me.XrTableCell2.Text = "TT"
        Me.XrTableCell2.Weight = 0.104585815998318
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.Text = "TÊN PHÒNG"
        Me.XrTableCell3.Weight = 0.89817149416302133
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "LỚP TÍN CHỈ"
        Me.XrTableCell9.Weight = 0.74455971628391282
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseFont = False
        Me.XrTableCell5.Text = "THỜI GIAN"
        Me.XrTableCell5.Weight = 1.2360787136533113
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.PageHeader.HeightF = 46.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'rptPlan_ThoiKhoaBieu_PhongHoc
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(38, 23, 28, 0)
        Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() {Me.XrControlStyle1})
        Me.Version = "10.1"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RptMARK_BangDiemSinhVien_SubI1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrControlStyle1 As DevExpress.XtraReports.UI.XRControlStyle
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrSubreport1 As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents txtTen_phong As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents RptMARK_BangDiemSinhVien_SubI1 As ESSReports.rptPlan_DanhSach_PhongHoc
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
End Class
