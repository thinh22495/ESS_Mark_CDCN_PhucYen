<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptMARK_ChuongTrinhDaoTaoKhung_Sub
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow
        Me.stt = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ky_hieu = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ten_mon = New DevExpress.XtraReports.UI.XRTableCell
        Me.So_hoc_trinh = New DevExpress.XtraReports.UI.XRTableCell
        Me.Ly_thuyet = New DevExpress.XtraReports.UI.XRTableCell
        Me.Thuc_hanh = New DevExpress.XtraReports.UI.XRTableCell
        Me.BT = New DevExpress.XtraReports.UI.XRTableCell
        Me.TL = New DevExpress.XtraReports.UI.XRTableCell
        Me.colunmsa = New DevExpress.XtraReports.UI.XRTableCell
        Me.Tu_chon = New DevExpress.XtraReports.UI.XRCheckBox
        Me.Ten_kien_thuc = New DevExpress.XtraReports.UI.XRTableCell
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable3})
        Me.Detail.Font = New System.Drawing.Font("Times New Roman", 9.75!)
        Me.Detail.HeightF = 36.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.StylePriority.UseFont = False
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
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
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
                    Or DevExpress.XtraPrinting.BorderSide.Right) _
                    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(772.9999!, 36.0!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.stt, Me.Ky_hieu, Me.Ten_mon, Me.So_hoc_trinh, Me.Ly_thuyet, Me.Thuc_hanh, Me.BT, Me.TL, Me.colunmsa, Me.Ten_kien_thuc})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.Weight = 1
        '
        'stt
        '
        Me.stt.Name = "stt"
        Me.stt.Text = "STT"
        Me.stt.Weight = 0.14424319157856835
        '
        'Ky_hieu
        '
        Me.Ky_hieu.Name = "Ky_hieu"
        Me.Ky_hieu.Text = "Kí hiệu"
        Me.Ky_hieu.Weight = 0.2776521279796097
        '
        'Ten_mon
        '
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.Text = "Tên môn"
        Me.Ten_mon.Weight = 1.0727690383526665
        '
        'So_hoc_trinh
        '
        Me.So_hoc_trinh.Name = "So_hoc_trinh"
        Me.So_hoc_trinh.Text = "So_hoc_trinh"
        Me.So_hoc_trinh.Weight = 0.1709240076653219
        '
        'Ly_thuyet
        '
        Me.Ly_thuyet.Name = "Ly_thuyet"
        Me.Ly_thuyet.Text = "Ly_thuyet"
        Me.Ly_thuyet.Weight = 0.1253235140147953
        '
        'Thuc_hanh
        '
        Me.Thuc_hanh.Name = "Thuc_hanh"
        Me.Thuc_hanh.Text = "thuc_hanh"
        Me.Thuc_hanh.Weight = 0.12601057416483283
        '
        'BT
        '
        Me.BT.Name = "BT"
        Me.BT.Text = "BT"
        Me.BT.Weight = 0.12601045572660666
        '
        'TL
        '
        Me.TL.Name = "TL"
        Me.TL.Text = "TL"
        Me.TL.Weight = 0.14877149949900628
        '
        'colunmsa
        '
        Me.colunmsa.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Tu_chon})
        Me.colunmsa.Name = "colunmsa"
        Me.colunmsa.Weight = 0.13745656278055052
        '
        'Tu_chon
        '
        Me.Tu_chon.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.Tu_chon.LocationFloat = New DevExpress.Utils.PointFloat(7.740967!, 6.000011!)
        Me.Tu_chon.Name = "Tu_chon"
        Me.Tu_chon.SizeF = New System.Drawing.SizeF(17.677!, 22.99999!)
        Me.Tu_chon.StylePriority.UseBorders = False
        Me.Tu_chon.StylePriority.UseTextAlignment = False
        Me.Tu_chon.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'Ten_kien_thuc
        '
        Me.Ten_kien_thuc.Name = "Ten_kien_thuc"
        Me.Ten_kien_thuc.Text = "Kiến thức"
        Me.Ten_kien_thuc.Weight = 0.67083902823804176
        '
        'rptMARK_ChuongTrinhDaoTaoKhung_Sub
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin})
        Me.Margins = New System.Drawing.Printing.Margins(51, 25, 0, 0)
        Me.Version = "10.1"
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents stt As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ky_hieu As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ten_mon As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents So_hoc_trinh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Ly_thuyet As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Thuc_hanh As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BT As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents TL As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents colunmsa As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents Tu_chon As DevExpress.XtraReports.UI.XRCheckBox
    Friend WithEvents Ten_kien_thuc As DevExpress.XtraReports.UI.XRTableCell
End Class
