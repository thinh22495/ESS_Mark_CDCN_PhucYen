<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMARK_ChuongTrinhDaoTaoKhung_Sub1
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
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.STT = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ky_hieu = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_hoc_phan = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ky_thu = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_tc = New DevExpress.XtraReports.UI.XRTableCell
        Me.He_so = New DevExpress.XtraReports.UI.XRTableCell
        Me.LT = New DevExpress.XtraReports.UI.XRTableCell
        Me.TH = New DevExpress.XtraReports.UI.XRTableCell
        Me.BT = New DevExpress.XtraReports.UI.XRTableCell
        Me.TL = New DevExpress.XtraReports.UI.XRTableCell
        Me.XRTableCell = New DevExpress.XtraReports.UI.XRTableCell
        Me.Tu_chon = New DevExpress.XtraReports.UI.XRCheckBox
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 25.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(760.9999!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.STT, Me.Ky_hieu, Me.Ten_hoc_phan, Me.Ky_thu, Me.So_tc, Me.He_so, Me.LT, Me.TH, Me.BT, Me.TL, Me.XRTableCell})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'STT
        '
        Me.STT.Name = "STT"
        Me.STT.Text = "STT"
        Me.STT.Weight = 0.14651826286713032
        '
        'Ky_hieu
        '
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.Text = "Ky_hieu"
        Me.Ky_hieu.Weight = 0.28203039137974995
        '
        'Ten_hoc_phan
        '
        Me.Ten_hoc_phan.Name = "Ten_hoc_phan"
        Me.Ten_hoc_phan.Text = "Ten_hoc_phan"
        Me.Ten_hoc_phan.Weight = 1.3657596545634449
        '
        'Ky_thu
        '
        Me.Ky_thu.Name = "Ky_thu"
        Me.Ky_thu.Text = "Ky_thu"
        Me.Ky_thu.Weight = 0.1478722398933674
        '
        'So_tc
        '
        Me.So_tc.Name = "So_tc"
        Me.So_tc.Text = "So_tc"
        Me.So_tc.Weight = 0.131571789039224
        '
        'He_so
        '
        Me.He_so.Name = "He_so"
        Me.He_so.Text = "He_so"
        Me.He_so.Weight = 0.19534276882319157
        '
        'LT
        '
        Me.LT.Name = "LT"
        Me.LT.Text = "LT"
        Me.LT.Weight = 0.12729934342387844
        '
        'TH
        '
        Me.TH.Name = "TH"
        Me.TH.Text = "TH"
        Me.TH.Weight = 0.12799741396839392
        '
        'BT
        '
        Me.BT.Name = "BT"
        Me.BT.Text = "BT"
        Me.BT.Weight = 0.12799723147321196
        '
        'TL
        '
        Me.TL.Name = "TL"
        Me.TL.Text = "TL"
        Me.TL.Weight = 0.15111673393195746
        '
        'XRTableCell
        '
        Me.XRTableCell.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tu_chon})
        Me.XRTableCell.Name = "XRTableCell"
        Me.XRTableCell.Weight = 0.19649417063645014
        '
        'Tu_chon
        '
        Me.Tu_chon.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Tu_chon.LocationFloat = New DevExpress.Utils.PointFloat(19.00004!, 4.0!)
        Me.Tu_chon.Name = "Tu_chon"
        Me.Tu_chon.SizeF = New System.Drawing.SizeF(23.375!, 15.625!)
        Me.Tu_chon.StylePriority.UseBorders = False
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0.0!
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.0!
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'rptMARK_ChuongTrinhDaoTaoKhung_Sub1
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(51, 38, 0, 0)
        Me.Version = "10.1"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents STT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ky_hieu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_hoc_phan As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ky_thu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_tc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents He_so As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents LT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TH As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TL As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XRTableCell As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tu_chon As DevExpress.XtraReports.UI.XRCheckBox
End Class
