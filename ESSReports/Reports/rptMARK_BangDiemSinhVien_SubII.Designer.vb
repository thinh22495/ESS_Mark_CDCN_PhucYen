<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMARK_BangDiemSinhVien_SubII
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
        Me.TT2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_mon2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_hoc_trinh2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCMH_2Lan2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCMH4_2Lan2 = New DevExpress.XtraReports.UI.XRTableCell
        Me.TBCMH_2Lan_DiemChu2 = New DevExpress.XtraReports.UI.XRTableCell
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
        Me.XrTable3.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(390.96!, 25.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.TT2, Me.Ten_mon2, Me.So_hoc_trinh2, Me.TBCMH_2Lan2, Me.TBCMH4_2Lan2, Me.TBCMH_2Lan_DiemChu2})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'TT2
        '
        Me.TT2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.TT2.Name = "TT2"
        Me.TT2.StylePriority.UseFont = False
        Me.TT2.Text = "TT2"
        Me.TT2.Weight = 0.10467013029389262
        '
        'Ten_mon2
        '
        Me.Ten_mon2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.Ten_mon2.Name = "Ten_mon2"
        Me.Ten_mon2.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 0, 0, 0, 100.0!)
        Me.Ten_mon2.StylePriority.UseFont = False
        Me.Ten_mon2.StylePriority.UsePadding = False
        Me.Ten_mon2.StylePriority.UseTextAlignment = False
        Me.Ten_mon2.Text = "Tên môn"
        Me.Ten_mon2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.Ten_mon2.Weight = 0.86912105901233838
        '
        'So_hoc_trinh2
        '
        Me.So_hoc_trinh2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.So_hoc_trinh2.Name = "So_hoc_trinh2"
        Me.So_hoc_trinh2.StylePriority.UseFont = False
        Me.So_hoc_trinh2.Text = "So_hoc_trinh2"
        Me.So_hoc_trinh2.Weight = 0.10502984881080528
        '
        'TBCMH_2Lan2
        '
        Me.TBCMH_2Lan2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.TBCMH_2Lan2.Name = "TBCMH_2Lan2"
        Me.TBCMH_2Lan2.StylePriority.UseFont = False
        Me.TBCMH_2Lan2.Text = "TBCMH_2Lan2"
        Me.TBCMH_2Lan2.Weight = 0.12201292369371641
        '
        'TBCMH4_2Lan2
        '
        Me.TBCMH4_2Lan2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.TBCMH4_2Lan2.Name = "TBCMH4_2Lan2"
        Me.TBCMH4_2Lan2.StylePriority.UseFont = False
        Me.TBCMH4_2Lan2.Text = "TBCMH4_2Lan2"
        Me.TBCMH4_2Lan2.Weight = 0.12201292419790902
        '
        'TBCMH_2Lan_DiemChu2
        '
        Me.TBCMH_2Lan_DiemChu2.Font = New System.Drawing.Font("Times New Roman", 8.0!)
        Me.TBCMH_2Lan_DiemChu2.Name = "TBCMH_2Lan_DiemChu2"
        Me.TBCMH_2Lan_DiemChu2.StylePriority.UseFont = False
        Me.TBCMH_2Lan_DiemChu2.Text = "TBCMH_2Lan_DiemChu2"
        Me.TBCMH_2Lan_DiemChu2.Weight = 0.12201297849405728
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
        'rptMARK_BangDiemSinhVien_SubII
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(439, 15, 0, 0)
        Me.Version = "10.1"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents TT2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_mon2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_hoc_trinh2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCMH_2Lan2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCMH4_2Lan2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TBCMH_2Lan_DiemChu2 As DevExpress.XtraReports.UI.XRTableCell
End Class
