<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptESS_DanhSachDiemThiTungMonTheoLop
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
        Me.Kiem_tra_list = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBC = New DevExpress.XtraReports.UI.XRTableCell
        Me.Diem_thi = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCHP = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ghi_chu = New DevExpress.XtraReports.UI.XRTableCell
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.Tieu_de_bao_cao = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell
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
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.STT, Me.Ma_sinh_vien, Me.Ten_sinh_vien, Me.Kiem_tra_list, Me.TBC, Me.Diem_thi, Me.TBCHP, Me.Ghi_chu})
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
        Me.Ma_sinh_vien.Weight = 1.3541668586023761
        '
        'Ten_sinh_vien
        '
        Me.Ten_sinh_vien.Name = "Ten_sinh_vien"
        Me.Ten_sinh_vien.Text = "Họ và tên"
        Me.Ten_sinh_vien.Weight = 1.6145833498489019
        '
        'Kiem_tra_list
        '
        Me.Kiem_tra_list.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Kiem_tra_list.Name = "Kiem_tra_list"
        Me.Kiem_tra_list.StylePriority.UseFont = False
        Me.Kiem_tra_list.Weight = 1.6562488987055175
        '
        'TBC
        '
        Me.TBC.Name = "TBC"
        Me.TBC.Text = "TBC"
        Me.TBC.Weight = 0.42708315223798854
        '
        'Diem_thi
        '
        Me.Diem_thi.Name = "Diem_thi"
        Me.Diem_thi.Text = "Diem_thi"
        Me.Diem_thi.Weight = 0.54968878614857786
        '
        'TBCHP
        '
        Me.TBCHP.Name = "TBCHP"
        Me.TBCHP.Text = "TBCHP"
        Me.TBCHP.Weight = 0.65385291790841016
        '
        'Ghi_chu
        '
        Me.Ghi_chu.Name = "Ghi_chu"
        Me.Ghi_chu.Text = "Ghi chú"
        Me.Ghi_chu.Weight = 0.97437542619666617
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
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tieu_de_bao_cao, Me.Tieu_de_ten_truong, Me.XrLabel1, Me.XrLabel2, Me.Tieu_de_ten_bo, Me.XrLine1, Me.XrLine2})
        Me.ReportHeader.HeightF = 253.0!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'Tieu_de_bao_cao
        '
        Me.Tieu_de_bao_cao.Font = New System.Drawing.Font("Times New Roman", 15.0!)
        Me.Tieu_de_bao_cao.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 139.5!)
        Me.Tieu_de_bao_cao.Multiline = True
        Me.Tieu_de_bao_cao.Name = "Tieu_de_bao_cao"
        Me.Tieu_de_bao_cao.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao.SizeF = New System.Drawing.SizeF(771.3334!, 86.54169!)
        Me.Tieu_de_bao_cao.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao.Text = "KẾT QUẢ HỌC TẬP LẦN 1 HỌC KỲ 2 NĂM HỌC 2010-2011" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " CHUYÊN NGÀNH CN PHẦN MỀM, LỚP " & _
            "2T PM - K7" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " MÔN HỌC: BẢO MẬT THÔNG TIN (3đvht)"
        Me.Tieu_de_bao_cao.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 50.0!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF(419.1666!, 23.0!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        'XrLabel2
        '
        Me.XrLabel2.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(430.1665!, 50.0!)
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(333.8335!, 23.0!)
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.StylePriority.UseTextAlignment = False
        Me.XrLabel2.Text = "ĐỘC LẬP - TỰ DO - HẠNH PHÚC"
        Me.XrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Times New Roman", 11.0!)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(12.5!, 25.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF(419.1666!, 23.0!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(500.0!, 62.5!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(206.25!, 23.0!)
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
        Me.PageHeader.HeightF = 46.0!
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
        Me.XrTable1.SizeF = New System.Drawing.SizeF(772.9999!, 46.0!)
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell4, Me.XrTableCell5})
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
        Me.XrTableCell2.Weight = 1.3541667060144733
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "Họ và tên"
        Me.XrTableCell3.Weight = 1.6145836550247072
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel6, Me.XrLabel4})
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Weight = 2.0833319365025789
        '
        'XrLabel6
        '
        Me.XrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(165.6249!, 22.99995!)
        Me.XrLabel6.Name = "XrLabel6"
        Me.XrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel6.SizeF = New System.Drawing.SizeF(42.70825!, 23.00002!)
        Me.XrLabel6.Text = "TBC"
        '
        'XrLabel4
        '
        Me.XrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrLabel4.Name = "XrLabel4"
        Me.XrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrLabel4.SizeF = New System.Drawing.SizeF(208.3331!, 23.00002!)
        Me.XrLabel4.Text = "Điểm thành phần"
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "Điểm thi"
        Me.XrTableCell7.Weight = 0.54968813764999147
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "TBCHT"
        Me.XrTableCell4.Weight = 0.65385383343582615
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "Ghi chú"
        Me.XrTableCell5.Weight = 0.97437512102086077
        '
        'rptESS_DanhSachDiemThiTungMonTheoLop
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.PageHeader})
        Me.Margins = New System.Drawing.Printing.Margins(38, 38, 17, 100)
        Me.Version = "10.1"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents Tieu_de_bao_cao As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents STT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ma_sinh_vien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_sinh_vien As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBC As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ghi_chu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Diem_thi As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCHP As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Kiem_tra_list As DevExpress.XtraReports.UI.XRTableCell
End Class
