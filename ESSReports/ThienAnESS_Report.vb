'Coded By: AnhNT
'Created date: 22/3/2012
'Company: Thien An ESS Co.,Ltd
Imports DevExpress.XtraReports.UI
Imports System.Drawing.Printing
Public Class ThienAnESS_Report
    Inherits DevExpress.XtraReports.UI.XtraReport

#Region "Page Template"
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents label4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ghi_chu_footer As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Ghi_chu_footer1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_bo As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_bao_cao5 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents label3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_ten_truong As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents Tieu_de_nguoi_ky4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_noi_ky As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh4 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky3 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_chuc_danh2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents Tieu_de_nguoi_ky2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PageFooter As DevExpress.XtraReports.UI.PageFooterBand
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
#End Region
#Region "Page Properties User Definition"
    Public _PageKind As System.Drawing.Printing.PaperKind
    Public _LandScape As Boolean = False
    Public _MarginLeft As Integer = 94
    Public _MarginRight As Integer = 40
    Public _MarginTop As Integer = 75
    Public _MarginBottom As Integer = 75
    Public _Margins As System.Drawing.Printing.Margins

    Public _TableHeader As XRTable
    Public _RowHeader As XRTableRow

    Public _TableValue As XRTable
    Public _RowValue As XRTableRow

    Public _Tieu_de1 As String = ""
    Public _Tieu_de2 As String = ""
    Public _Tieu_de3 As String = ""
    Public _Tieu_de4 As String = ""
    Public _Tieu_de5 As String = ""
    Public _Ghi_chu As String = ""
    Public _Ghi_chu1 As String = ""
    Public _Complex As Boolean = True

    Public _HeaderFontSize As Single = 10
    Public _ValueFontSize As Single = 9
#End Region
    Public Sub New(Optional ByVal pageKind As PaperKind = PaperKind.A4 _
                  , Optional ByVal landScape As Boolean = False _
                  , Optional ByVal margin As Margins = Nothing _
                  , Optional ByVal tableHeaderHeight As Single = 20 _
                  , Optional ByVal Tieu_de1 As String = "" _
                  , Optional ByVal Tieu_de2 As String = "" _
                  , Optional ByVal Tieu_de3 As String = "" _
                  , Optional ByVal Tieu_de4 As String = "" _
                  , Optional ByVal Tieu_de5 As String = "" _
                  , Optional ByVal Complex As Boolean = True _
                  , Optional ByVal headerFontSize As Single = 10 _
                  , Optional ByVal valueFontSize As Single = 8 _
                  , Optional ByVal Ghi_chu As String = "" _
                  , Optional ByVal Ghi_chu1 As String = "" _
                   )
        Me._PageKind = pageKind
        Me._LandScape = landScape
        Me._Margins = margin
        Me._Tieu_de1 = Tieu_de1
        Me._Tieu_de2 = Tieu_de2
        Me._Tieu_de3 = Tieu_de3
        Me._Tieu_de4 = Tieu_de4
        Me._Tieu_de5 = Tieu_de5
        Me._Ghi_chu = Ghi_chu
        Me._Ghi_chu1 = Ghi_chu1


        Me._Complex = Complex
        Me._HeaderFontSize = headerFontSize
        Me._ValueFontSize = valueFontSize
        'Initial Components
        InitializeComponent()
        If Not Ghi_chu.Length > 0 Then
            Me.Ghi_chu_footer.HeightF = 0
        End If
        'Check Tieu de
        If Not Tieu_de1.Length > 0 Then
            Me.Tieu_de_bao_cao1.HeightF = 0
        End If
        If Not Tieu_de2.Length > 0 Then
            Me.Tieu_de_bao_cao2.HeightF = 0
        End If
        If Not Tieu_de3.Length > 0 Then
            Me.Tieu_de_bao_cao3.HeightF = 0
        End If
        If Not Tieu_de4.Length > 0 Then
            Me.Tieu_de_bao_cao4.HeightF = 0
        End If
        If Not Tieu_de5.Length > 0 Then
            Me.Tieu_de_bao_cao5.HeightF = 0
        End If
        If Not Ghi_chu.Length > 0 Then
            Me.Ghi_chu_footer.HeightF = 0
        End If
        If Not Ghi_chu1.Length > 0 Then
            Me.Ghi_chu_footer1.HeightF = 0
        End If
        'Dynamic Table Design by User
        SetUpHeaderTable(tableHeaderHeight)
    End Sub
#Region "Fixed Items"
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
    '<System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand
        Me.label4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_bo = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ghi_chu_footer = New DevExpress.XtraReports.UI.XRLabel
        Me.Ghi_chu_footer1 = New DevExpress.XtraReports.UI.XRLabel
        Me.label3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_ten_truong = New DevExpress.XtraReports.UI.XRLabel
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand
        Me.Tieu_de_nguoi_ky4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_noi_ky = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky3 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky1 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_chuc_danh2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_nguoi_ky2 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao4 = New DevExpress.XtraReports.UI.XRLabel
        Me.Tieu_de_bao_cao5 = New DevExpress.XtraReports.UI.XRLabel
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand
        Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo
        '
        'CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()

        '
        'Report
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader, Me.ReportFooter, Me.PageHeader, Me.PageFooter})
        If Not Me._Margins Is Nothing Then
            Me._MarginLeft = _Margins.Left
            Me._MarginBottom = _Margins.Bottom
            Me._MarginTop = _Margins.Top
            Me._MarginRight = _Margins.Right
            Me.Margins = _Margins
        Else
            Me.Margins = _Margins
        End If
        Me.DefaultPrinterSettingsUsing.UsePaperKind = False
        Me.PaperKind = _PageKind
        Me.Landscape = _LandScape
        Me.Version = "10.1"

        '
        'Detail
        '
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'TopMargin
        '
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
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.label4, Me.Tieu_de_bao_cao5, Me.Tieu_de_bao_cao4, Me.Tieu_de_bao_cao3, Me.Tieu_de_bao_cao2, Me.Tieu_de_ten_bo, Me.Tieu_de_bao_cao1, Me.label3, Me.Tieu_de_ten_truong})
        Me.ReportHeader.Name = "ReportHeader"
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Ghi_chu_footer, Me.Ghi_chu_footer1, Me.Tieu_de_nguoi_ky4, Me.Tieu_de_chuc_danh3, Me.Tieu_de_noi_ky, Me.Tieu_de_chuc_danh4, Me.Tieu_de_nguoi_ky3, Me.Tieu_de_chuc_danh1, Me.Tieu_de_nguoi_ky1, Me.Tieu_de_chuc_danh2, Me.Tieu_de_nguoi_ky2})
        Me.ReportFooter.Name = "ReportFooter"
        '
        '
        'PageHeader
        '
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        ' Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1})
        Me.PageFooter.Name = "PageFooter"
        'CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        '
        'Quoc hieu
        '
        Me.label4.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.label4.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 25.25!)
        Me.label4.Name = "label4"
        Me.label4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label4.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 31.25!)
        Me.label4.StylePriority.UseFont = False
        Me.label4.StylePriority.UseTextAlignment = False
        Me.label4.Text = "Độc Lập - Tự Do - Hạnh Phúc"
        Me.label4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.label4.Borders = DevExpress.XtraPrinting.BorderSide.All

        '
        'Tieu_de_ten_bo
        '
        Me.Tieu_de_ten_bo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular)
        Me.Tieu_de_ten_bo.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        Me.Tieu_de_ten_bo.Name = "Tieu_de_ten_bo"
        Me.Tieu_de_ten_bo.Text = ReportModel.Tieu_de_ten_bo
        Me.Tieu_de_ten_bo.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_bo.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 31.25!)
        Me.Tieu_de_ten_bo.StylePriority.UseFont = False
        Me.Tieu_de_ten_bo.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_bo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_ten_bo.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_bao_cao1
        '
        Me.Tieu_de_bao_cao1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 87.5!)
        Me.Tieu_de_bao_cao1.Name = "Tieu_de_bao_cao1"
        Me.Tieu_de_bao_cao1.Text = _Tieu_de1
        Me.Tieu_de_bao_cao1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao1.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 23.0!)
        Me.Tieu_de_bao_cao1.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_bao_cao1.Borders = DevExpress.XtraPrinting.BorderSide.All

        'Tieu_de_bao_cao2
        '
        Me.Tieu_de_bao_cao2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 112.5!)
        Me.Tieu_de_bao_cao2.Name = "Tieu_de_bao_cao2"
        Me.Tieu_de_bao_cao2.Text = _Tieu_de2
        Me.Tieu_de_bao_cao2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao2.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 23.0!)
        Me.Tieu_de_bao_cao2.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_bao_cao2.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_bao_cao3
        '
        Me.Tieu_de_bao_cao3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_bao_cao3.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 137.5!)
        Me.Tieu_de_bao_cao3.Name = "Tieu_de_bao_cao3"
        Me.Tieu_de_bao_cao3.Text = _Tieu_de3
        Me.Tieu_de_bao_cao3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_bao_cao3.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 23.0!)
        Me.Tieu_de_bao_cao3.StylePriority.UseFont = False
        Me.Tieu_de_bao_cao3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_bao_cao3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        'Me.Tieu_de_bao_cao3.Borders = DevExpress.XtraPrinting.BorderSide.All
        '

        ''Tieu_de_bao_cao4
        ''
        'Me.Tieu_de_bao_cao4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        'Me.Tieu_de_bao_cao4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 162.5!)
        'Me.Tieu_de_bao_cao4.Name = "Tieu_de_bao_cao4"
        'Me.Tieu_de_bao_cao4.Text = _Tieu_de4
        'Me.Tieu_de_bao_cao4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        'Me.Tieu_de_bao_cao4.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 23.0!)
        'Me.Tieu_de_bao_cao4.StylePriority.UseFont = False
        'Me.Tieu_de_bao_cao4.StylePriority.UseTextAlignment = False
        'Me.Tieu_de_bao_cao4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ''Me.Tieu_de_bao_cao3.Borders = DevExpress.XtraPrinting.BorderSide.All

        ''Tieu_de_bao_cao5
        ''
        'Me.Tieu_de_bao_cao5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold)
        'Me.Tieu_de_bao_cao5.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 187.5!)
        'Me.Tieu_de_bao_cao5.Name = "Tieu_de_bao_cao5"
        'Me.Tieu_de_bao_cao5.Text = _Tieu_de5
        'Me.Tieu_de_bao_cao5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        'Me.Tieu_de_bao_cao5.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 23.0!)
        'Me.Tieu_de_bao_cao5.StylePriority.UseFont = False
        'Me.Tieu_de_bao_cao5.StylePriority.UseTextAlignment = False
        'Me.Tieu_de_bao_cao5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        ''Me.Tieu_de_bao_cao5.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'label3
        '
        Me.label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular)
        Me.label3.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 0.0!)
        Me.label3.Name = "label3"
        Me.label3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.label3.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 31.25!)
        Me.label3.StylePriority.UseFont = False
        Me.label3.StylePriority.UseTextAlignment = False
        Me.label3.Text = "CỘNG HÒA XÃ HỘI CHỦ NGHĨA VIỆT NAM"
        Me.label3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.label3.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_ten_truong
        '
        Me.Tieu_de_ten_truong.Font = New System.Drawing.Font("Arial", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Tieu_de_ten_truong.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.25!)
        Me.Tieu_de_ten_truong.Name = "Tieu_de_ten_truong"
        Me.Tieu_de_ten_truong.Text = ReportModel.Tieu_de_ten_truong
        Me.Tieu_de_ten_truong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_ten_truong.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 31.25!)
        Me.Tieu_de_ten_truong.StylePriority.UseFont = False
        Me.Tieu_de_ten_truong.StylePriority.UseTextAlignment = False
        Me.Tieu_de_ten_truong.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

        'Me.Tieu_de_ten_truong.Borders = DevExpress.XtraPrinting.BorderSide.All

        '
        'Ghi_chu_footer
        '
        Me.Ghi_chu_footer.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular)
        Me.Ghi_chu_footer.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 10.25!)
        Me.Ghi_chu_footer.Name = "Ghi_chu_footer"
        Me.Ghi_chu_footer.Text = _Ghi_chu
        Me.Ghi_chu_footer.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ghi_chu_footer.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight), 31.25!)
        Me.Ghi_chu_footer.StylePriority.UseFont = False
        Me.Ghi_chu_footer.StylePriority.UseTextAlignment = False
        Me.Ghi_chu_footer.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        'Me.Tieu_de_nguoi_ky4.Borders = DevExpress.XtraPrinting.BorderSide.All

        '
        'Ghi_chu_footer1
        '
        Me.Ghi_chu_footer1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular)
        Me.Ghi_chu_footer1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 30.25!)
        Me.Ghi_chu_footer1.Name = "Ghi_chu_footer1"
        Me.Ghi_chu_footer1.Text = _Ghi_chu1
        Me.Ghi_chu_footer1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ghi_chu_footer1.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight), 31.25!)
        Me.Ghi_chu_footer1.StylePriority.UseFont = False
        Me.Ghi_chu_footer1.StylePriority.UseTextAlignment = False
        Me.Ghi_chu_footer1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        'Me.Tieu_de_nguoi_ky4.Borders = DevExpress.XtraPrinting.BorderSide.All


        '
        'Tieu_de_nguoi_ky4
        '
        Me.Tieu_de_nguoi_ky4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky4.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 3 / 4, Me.Ghi_chu_footer.HeightF + 100.0!)
        Me.Tieu_de_nguoi_ky4.Name = "Tieu_de_nguoi_ky4"
        Me.Tieu_de_nguoi_ky4.Text = ReportModel.Tieu_de_nguoi_ki4
        Me.Tieu_de_nguoi_ky4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky4.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_nguoi_ky4.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_nguoi_ky4.Visible = False
        'Me.Tieu_de_nguoi_ky4.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_chuc_danh3
        '
        Me.Tieu_de_chuc_danh3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh3.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 3 / 4, Me.Ghi_chu_footer.HeightF + 30.0!)
        Me.Tieu_de_chuc_danh3.Name = "Tieu_de_chuc_danh3"
        Me.Tieu_de_chuc_danh3.Text = ReportModel.Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh3.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_chuc_danh3.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_chuc_danh3.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_noi_ky
        '
        Me.Tieu_de_noi_ky.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic)
        Me.Tieu_de_noi_ky.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 2.5 / 4, Me.Ghi_chu_footer.HeightF + 15.0!)
        Me.Tieu_de_noi_ky.Name = "Tieu_de_noi_ky"
        Me.Tieu_de_noi_ky.Text = ReportModel.Tieu_de_noi_ki + GetReportDate()
        Me.Tieu_de_noi_ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_noi_ky.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) * 1 / 3, 23.0!)
        Me.Tieu_de_noi_ky.StylePriority.UseTextAlignment = False
        Me.Tieu_de_noi_ky.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
        'Me.Tieu_de_noi_ky.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_chuc_danh4
        '
        Me.Tieu_de_chuc_danh4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh4.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 3 / 4, Me.Ghi_chu_footer.HeightF + 30.0!)
        Me.Tieu_de_chuc_danh4.Name = "Tieu_de_chuc_danh4"
        Me.Tieu_de_chuc_danh4.Text = ReportModel.Tieu_de_chuc_danh4
        Me.Tieu_de_chuc_danh4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh4.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_chuc_danh4.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh4.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.Tieu_de_chuc_danh4.Visible = False
        'Me.Tieu_de_chuc_danh4.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_nguoi_ky3
        '
        Me.Tieu_de_nguoi_ky3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky3.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 3 / 4, Me.Ghi_chu_footer.HeightF + 100.0!)
        Me.Tieu_de_nguoi_ky3.Name = "Tieu_de_nguoi_ky3"
        Me.Tieu_de_nguoi_ky3.Text = ReportModel.Tieu_de_nguoi_ki3
        Me.Tieu_de_nguoi_ky3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky3.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_nguoi_ky3.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky3.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_nguoi_ky3.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_chuc_danh1
        '
        Me.Tieu_de_chuc_danh1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_chuc_danh1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, Me.Ghi_chu_footer.HeightF + 30.0!)
        Me.Tieu_de_chuc_danh1.Name = "Tieu_de_chuc_danh1"
        Me.Tieu_de_chuc_danh1.Text = ReportModel.Tieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh1.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.0!)
        Me.Tieu_de_chuc_danh1.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_chuc_danh1.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_nguoi_ky1
        '
        Me.Tieu_de_nguoi_ky1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, Me.Ghi_chu_footer.HeightF + 100.0!)
        Me.Tieu_de_nguoi_ky1.Name = "Tieu_de_nguoi_ky1"
        Me.Tieu_de_nguoi_ky1.Text = ReportModel.Tieu_de_nguoi_ki1
        Me.Tieu_de_nguoi_ky1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky1.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.0!)
        Me.Tieu_de_nguoi_ky1.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky1.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_nguoi_ky1.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_chuc_danh2
        '
        Me.Tieu_de_chuc_danh2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        'Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 1 / 4, Me.Ghi_chu_footer.HeightF + 30.0!)
        Me.Tieu_de_chuc_danh2.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 1.5 / 4, Me.Ghi_chu_footer.HeightF + 30.0!)
        Me.Tieu_de_chuc_danh2.Name = "Tieu_de_chuc_danh2"
        Me.Tieu_de_chuc_danh2.Text = ReportModel.Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_chuc_danh2.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_chuc_danh2.StylePriority.UseFont = False
        Me.Tieu_de_chuc_danh2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_chuc_danh2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_chuc_danh2.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'Tieu_de_nguoi_ky2
        '
        Me.Tieu_de_nguoi_ky2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Tieu_de_nguoi_ky2.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) * 1.5 / 4, Me.Ghi_chu_footer.HeightF + 100.0!)
        Me.Tieu_de_nguoi_ky2.Name = "Tieu_de_nguoi_ky2"
        Me.Tieu_de_nguoi_ky2.Text = ReportModel.Tieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Tieu_de_nguoi_ky2.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 4, 23.00002!)
        Me.Tieu_de_nguoi_ky2.StylePriority.UseFont = False
        Me.Tieu_de_nguoi_ky2.StylePriority.UseTextAlignment = False
        Me.Tieu_de_nguoi_ky2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        'Me.Tieu_de_nguoi_ky2.Borders = DevExpress.XtraPrinting.BorderSide.All
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 0.0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF((Me.PageWidth - _MarginLeft - _MarginRight) / 2, 10.0!)
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.StylePriority.UseTextAlignment = False
        Me.XrPageInfo1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
    End Sub
#End Region
#Region "Dynamic Items"
    Public Overridable Sub SetUpHeaderTable(Optional ByVal tableHeight As Single = 40)

        ''Define Table Header
        'Me._TableHeader = New XRTable()
        'Me._TableHeader.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        'Me._TableHeader.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, tableHeight)
        'Me._TableHeader.StylePriority.UseBorders = False
        'Me._TableHeader.Borders = DevExpress.XtraPrinting.BorderSide.All
        'Me._TableHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        ''Define Row Header
        '_RowHeader = New XRTableRow
        '_RowHeader.HeightF = tableHeight
        ''Define Table Value
        'Me._TableValue = New XRTable()
        'Me._TableValue.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
        'Me._TableValue.SizeF = New System.Drawing.SizeF(Me.PageWidth - _MarginLeft - _MarginRight, 20)
        'Me._TableValue.StylePriority.UseBorders = False
        'Me._TableValue.Borders = DevExpress.XtraPrinting.BorderSide.All
        'Me._TableValue.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        ''Define Row Header
        '_RowValue = New XRTableRow
        '_RowValue.HeightF = 20 ' Default for table value
        '_RowValue.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
        '    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)

        'Dim pair As KeyValuePair(Of String, CellReport)
        'For Each pair In ReportModel.HeaderTable
        '    If Not pair.Key.StartsWith("_dynamic") Then
        '        'Define header cell and add to TableHeader
        '        Dim cell As New XRTableCell()
        '        cell.Text = pair.Value.Text
        '        cell.Name = pair.Key
        '        cell.WidthF = pair.Value.Width
        '        'If pair.Value.DataBinding.Length > 0 Then
        '        '    cell.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
        '        'End If
        '        _RowHeader.Cells.Add(cell)

        '        'Define header cell and add to TableHeader
        '        Dim cellValue As New XRTableCell()
        '        cellValue.Name = pair.Key + "Val"
        '        cellValue.WidthF = pair.Value.Width
        '        cellValue.TextAlignment = pair.Value.TextAlignment
        '        If pair.Value.DataBinding.Length > 0 Then
        '            cellValue.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
        '        End If
        '        _RowValue.Cells.Add(cellValue)
        '    Else
        '        Dim index As Integer = Convert.ToInt32(pair.Key.Substring(8, 1))
        '        Select Case index
        '            Case 1
        '                Dim cell As New XRTableCell()
        '                cell.WidthF = Me.PageWidth - _MarginLeft - _MarginRight - CountFixedCell()
        '                Dim dynamicTable1 As XRTable = Me.CreateTableHeaderDynamic(cell.WidthF, tableHeight, pair.Value.Text, 20)
        '                cell.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {dynamicTable1})
        '                _RowHeader.Cells.Add(cell)
        '                'Add dynamic Cell Value
        '                CreateDynamicCellValue((Me.PageWidth - _MarginLeft - _MarginRight - CountFixedCell()) / ReportModel.HeaderDynamicTable1.Count)
        '                Exit Select
        '            Case 2
        '                Exit Select
        '        End Select
        '    End If
        'Next
        ''Add header Table
        'Me._TableHeader.Rows.Add(_RowHeader)
        'Me.PageHeader.HeightF = _TableHeader.HeightF
        'Me.PageHeader.Controls.Add(_TableHeader)
        ''Add Value Table
        'Me._TableValue.Rows.Add(_RowValue)
        'Me.Detail.Controls.Add(_TableValue)
        'Me.Detail.HeightF = _RowValue.HeightF
    End Sub
    Public Overridable Function CreateTableHeaderDynamic(Optional ByVal width As Single = 0, Optional ByVal height As Single = 0, Optional ByVal headerFirstRow As String = "", Optional ByVal heightFirstRow As Single = 0, Optional ByVal dict As Dictionary(Of String, CellReport) = Nothing) As XRTable
        'Dim TableHeaderDynamic = New XRTable()
        'TableHeaderDynamic.Borders = DevExpress.XtraPrinting.BorderSide.All
        'TableHeaderDynamic.SizeF = New System.Drawing.SizeF(width, height)
        ''Add first row
        'Dim row1 As New XRTableRow
        'row1.HeightF = heightFirstRow
        'Dim cellFirst As New XRTableCell
        'cellFirst.Text = headerFirstRow
        ''No border left
        'cellFirst.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
        '    Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        'row1.Cells.Add(cellFirst)
        'TableHeaderDynamic.Rows.Add(row1)

        ''Add second row
        'Dim row2 As New XRTableRow
        'row2.HeightF = height - heightFirstRow
        'Dim pair As KeyValuePair(Of String, CellReport)

        'Dim index As Integer = 0
        'For Each pair In ReportModel.HeaderDynamicTable1
        '    'Define the header dynamic table cell
        '    Dim cell As New XRTableCell()
        '    If index = 0 Then
        '        'No border left
        '        cell.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
        '            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        '    End If
        '    cell.Text = pair.Value.Text
        '    cell.Name = pair.Key
        '    cell.WidthF = pair.Value.Width
        '    cell.Multiline = True
        '    'If pair.Value.DataBinding.Length > 0 Then
        '    '    cell.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
        '    'End If
        '    row2.Cells.Add(cell)
        '    'Plus index
        '    index = index + 1
        'Next
        'TableHeaderDynamic.Rows.Add(row2)
        'Return TableHeaderDynamic
    End Function
    Public Overridable Sub CreateDynamicCellValue(Optional ByVal cellValueWidth As Single = 0, Optional ByVal dict As Dictionary(Of String, CellReport) = Nothing)
        'Dim pair As KeyValuePair(Of String, CellReport)
        'For Each pair In ReportModel.HeaderDynamicTable1
        '    'Define the value dynamic table cell
        '    Dim cellValue As New XRTableCell()
        '    cellValue.Text = pair.Value.Text
        '    cellValue.Name = pair.Key
        '    cellValue.WidthF = cellValueWidth
        '    If pair.Value.DataBinding.Length > 0 Then
        '        cellValue.DataBindings.Add("Text", DataSource, pair.Value.DataBinding)
        '    End If
        '    _RowValue.Cells.Add(cellValue)
        'Next
    End Sub
    Public Overridable Function CountFixedCell() As Single
        Dim WidthCount As Single = 0
        Dim pair As KeyValuePair(Of String, CellReport)
        If ReportModel.HeaderTable.Count > 0 Then
            For Each pair In ReportModel.HeaderTable
                If Not pair.Key.StartsWith("_dynamic") Then
                    'Plus WidthCount
                    WidthCount = WidthCount + pair.Value.Width
                End If
            Next
        End If
        Return WidthCount
    End Function
#End Region
#Region "Utilities"
    Public Function GetReportDate() As String
        Return ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Function
#End Region
End Class
