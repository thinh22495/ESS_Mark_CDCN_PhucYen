<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDonXacNhan
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
        Me.Khoa_Hoc = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel14 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_Lop = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel12 = New DevExpress.XtraReports.UI.XRLabel
        Me.Hoc_Ki = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel11 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel16 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel18 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel13 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ten_Khoa = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel17 = New DevExpress.XtraReports.UI.XRLabel
        Me.TieuDe_TenTruong = New DevExpress.XtraReports.UI.XRLabel
        Me.TieuDe_TenPhong = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel6 = New DevExpress.XtraReports.UI.XRLabel
        Me.Nam_Thu = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel
        Me.Bac_Hoc = New DevExpress.XtraReports.UI.XRLabel
        Me.Ho_ten = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel10 = New DevExpress.XtraReports.UI.XRLabel
        Me.Ngay_Sinh = New DevExpress.XtraReports.UI.XRLabel
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand
        Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine
        Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand
        Me.GroupHeader1 = New DevExpress.XtraReports.UI.GroupHeaderBand
        Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel
        Me.TieuDe_Noi_Ky = New DevExpress.XtraReports.UI.XRLabel
        Me.GroupFooter1 = New DevExpress.XtraReports.UI.GroupFooterBand
        Me.xrLabel22 = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel21 = New DevExpress.XtraReports.UI.XRLabel
        Me.TieuDe_NoiKy = New DevExpress.XtraReports.UI.XRLabel
        Me.xrLabel19 = New DevExpress.XtraReports.UI.XRLabel
        Me.TieuDe_NgayKi = New DevExpress.XtraReports.UI.XRLabel
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.Khoa_Hoc, Me.xrLabel14, Me.Ten_Lop, Me.xrLabel12, Me.Hoc_Ki, Me.xrLabel11, Me.xrLabel16, Me.xrLabel7, Me.xrLabel18, Me.xrLabel13, Me.Ten_Khoa, Me.xrLabel17, Me.TieuDe_TenTruong, Me.TieuDe_TenPhong, Me.xrLabel8, Me.xrLabel2, Me.xrLabel5, Me.xrLabel6, Me.Nam_Thu, Me.xrLabel9, Me.Bac_Hoc, Me.Ho_ten, Me.xrLabel10, Me.Ngay_Sinh})
        Me.Detail.HeightF = 327.0!
        Me.Detail.Name = "Detail"
        Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'Khoa_Hoc
        '
        Me.Khoa_Hoc.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Khoa_Hoc.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 137.5!)
        Me.Khoa_Hoc.Multiline = True
        Me.Khoa_Hoc.Name = "Khoa_Hoc"
        Me.Khoa_Hoc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Khoa_Hoc.SizeF = New System.Drawing.SizeF(222.0833!, 23.00002!)
        Me.Khoa_Hoc.StylePriority.UseFont = False
        Me.Khoa_Hoc.Text = "Khoa_Hoc"
        '
        'xrLabel14
        '
        Me.xrLabel14.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel14.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 137.5!)
        Me.xrLabel14.Name = "xrLabel14"
        Me.xrLabel14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel14.SizeF = New System.Drawing.SizeF(94.16666!, 23.0!)
        Me.xrLabel14.StylePriority.UseFont = False
        Me.xrLabel14.Text = "Khóa học:"
        '
        'Ten_Lop
        '
        Me.Ten_Lop.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ten_Lop.LocationFloat = New DevExpress.Utils.PointFloat(87.5!, 162.5!)
        Me.Ten_Lop.Name = "Ten_Lop"
        Me.Ten_Lop.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_Lop.SizeF = New System.Drawing.SizeF(235.4166!, 23.00002!)
        Me.Ten_Lop.StylePriority.UseFont = False
        Me.Ten_Lop.Text = "Ten_Lop"
        '
        'xrLabel12
        '
        Me.xrLabel12.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel12.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 112.5!)
        Me.xrLabel12.Name = "xrLabel12"
        Me.xrLabel12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel12.SizeF = New System.Drawing.SizeF(87.49997!, 23.0!)
        Me.xrLabel12.StylePriority.UseFont = False
        Me.xrLabel12.Text = "Bậc:"
        '
        'Hoc_Ki
        '
        Me.Hoc_Ki.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Hoc_Ki.LocationFloat = New DevExpress.Utils.PointFloat(87.5!, 137.5!)
        Me.Hoc_Ki.Name = "Hoc_Ki"
        Me.Hoc_Ki.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Hoc_Ki.SizeF = New System.Drawing.SizeF(235.4167!, 23.0!)
        Me.Hoc_Ki.StylePriority.UseFont = False
        Me.Hoc_Ki.Text = "Hoc_ki"
        '
        'xrLabel11
        '
        Me.xrLabel11.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel11.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 137.5!)
        Me.xrLabel11.Name = "xrLabel11"
        Me.xrLabel11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel11.SizeF = New System.Drawing.SizeF(80.20833!, 23.0!)
        Me.xrLabel11.StylePriority.UseFont = False
        Me.xrLabel11.Text = "Học kì:"
        '
        'xrLabel16
        '
        Me.xrLabel16.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel16.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 250.0!)
        Me.xrLabel16.Multiline = True
        Me.xrLabel16.Name = "xrLabel16"
        Me.xrLabel16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel16.SizeF = New System.Drawing.SizeF(647.0833!, 25.0834!)
        Me.xrLabel16.StylePriority.UseFont = False
        Me.xrLabel16.Text = "Lý do xin xác nhận: ............................................................." & _
            "............................................"
        '
        'xrLabel7
        '
        Me.xrLabel7.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 277.0!)
        Me.xrLabel7.Multiline = True
        Me.xrLabel7.Name = "xrLabel7"
        Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel7.SizeF = New System.Drawing.SizeF(648.3334!, 25.08336!)
        Me.xrLabel7.StylePriority.UseFont = False
        Me.xrLabel7.Text = "................................................................................." & _
            "................................................"
        '
        'xrLabel18
        '
        Me.xrLabel18.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel18.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 304.0!)
        Me.xrLabel18.Name = "xrLabel18"
        Me.xrLabel18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel18.SizeF = New System.Drawing.SizeF(191.6667!, 22.99997!)
        Me.xrLabel18.StylePriority.UseFont = False
        Me.xrLabel18.Text = "Xin trân trọng cảm ơn!"
        '
        'xrLabel13
        '
        Me.xrLabel13.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel13.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 162.5!)
        Me.xrLabel13.Name = "xrLabel13"
        Me.xrLabel13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel13.SizeF = New System.Drawing.SizeF(80.20833!, 23.0!)
        Me.xrLabel13.StylePriority.UseFont = False
        Me.xrLabel13.Text = "Lớp:"
        '
        'Ten_Khoa
        '
        Me.Ten_Khoa.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ten_Khoa.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 162.5!)
        Me.Ten_Khoa.Multiline = True
        Me.Ten_Khoa.Name = "Ten_Khoa"
        Me.Ten_Khoa.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ten_Khoa.SizeF = New System.Drawing.SizeF(222.0833!, 23.00002!)
        Me.Ten_Khoa.StylePriority.UseFont = False
        Me.Ten_Khoa.Text = "Ten_Khoa"
        '
        'xrLabel17
        '
        Me.xrLabel17.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel17.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 162.5!)
        Me.xrLabel17.Name = "xrLabel17"
        Me.xrLabel17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel17.SizeF = New System.Drawing.SizeF(87.49997!, 23.0!)
        Me.xrLabel17.StylePriority.UseFont = False
        Me.xrLabel17.Text = "Khoa:"
        '
        'TieuDe_TenTruong
        '
        Me.TieuDe_TenTruong.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TieuDe_TenTruong.LocationFloat = New DevExpress.Utils.PointFloat(217.7084!, 0.0!)
        Me.TieuDe_TenTruong.Name = "TieuDe_TenTruong"
        Me.TieuDe_TenTruong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TieuDe_TenTruong.SizeF = New System.Drawing.SizeF(430.625!, 22.99999!)
        Me.TieuDe_TenTruong.StylePriority.UseFont = False
        Me.TieuDe_TenTruong.Text = "TieuDe_TenTruong"
        '
        'TieuDe_TenPhong
        '
        Me.TieuDe_TenPhong.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.TieuDe_TenPhong.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 28.0!)
        Me.TieuDe_TenPhong.Name = "TieuDe_TenPhong"
        Me.TieuDe_TenPhong.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TieuDe_TenPhong.SizeF = New System.Drawing.SizeF(494.1666!, 22.99999!)
        Me.TieuDe_TenPhong.StylePriority.UseFont = False
        Me.TieuDe_TenPhong.Text = "PHÒNG ĐÀO TẠO VÀ CÔNG TÁC HỌC SINH SINH VIÊN"
        '
        'xrLabel8
        '
        Me.xrLabel8.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 87.5!)
        Me.xrLabel8.Name = "xrLabel8"
        Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel8.SizeF = New System.Drawing.SizeF(80.20833!, 23.0!)
        Me.xrLabel8.StylePriority.UseFont = False
        Me.xrLabel8.Text = "Tên tôi là:"
        '
        'xrLabel2
        '
        Me.xrLabel2.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 200.0!)
        Me.xrLabel2.Name = "xrLabel2"
        Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel2.SizeF = New System.Drawing.SizeF(647.2916!, 45.91669!)
        Me.xrLabel2.StylePriority.UseFont = False
        Me.xrLabel2.Text = "Nay tôi làm đơn này gửi đến Ban giám hiệu và Phòng ĐT&CTHSSV xin xác nhận là học " & _
            "sinh/sinh viên đang học tại Trường."
        '
        'xrLabel5
        '
        Me.xrLabel5.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(25.0!, 0.0!)
        Me.xrLabel5.Name = "xrLabel5"
        Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel5.SizeF = New System.Drawing.SizeF(75.0!, 23.0!)
        Me.xrLabel5.StylePriority.UseFont = False
        Me.xrLabel5.Text = "Kính gửi:"
        '
        'xrLabel6
        '
        Me.xrLabel6.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel6.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 0.0!)
        Me.xrLabel6.Name = "xrLabel6"
        Me.xrLabel6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel6.SizeF = New System.Drawing.SizeF(116.6667!, 23.0!)
        Me.xrLabel6.StylePriority.UseFont = False
        Me.xrLabel6.Text = "BAN GIÁM HIỆU "
        '
        'Nam_Thu
        '
        Me.Nam_Thu.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Nam_Thu.LocationFloat = New DevExpress.Utils.PointFloat(231.875!, 112.5!)
        Me.Nam_Thu.Name = "Nam_Thu"
        Me.Nam_Thu.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Nam_Thu.SizeF = New System.Drawing.SizeF(93.12503!, 22.99998!)
        Me.Nam_Thu.StylePriority.UseFont = False
        Me.Nam_Thu.Text = "Nam_Thu"
        '
        'xrLabel9
        '
        Me.xrLabel9.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 112.5!)
        Me.xrLabel9.Name = "xrLabel9"
        Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel9.SizeF = New System.Drawing.SizeF(229.1666!, 22.99998!)
        Me.xrLabel9.StylePriority.UseFont = False
        Me.xrLabel9.Text = "Là học sinh/sinh viên năm thứ:"
        '
        'Bac_Hoc
        '
        Me.Bac_Hoc.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Bac_Hoc.LocationFloat = New DevExpress.Utils.PointFloat(412.5!, 112.5!)
        Me.Bac_Hoc.Name = "Bac_Hoc"
        Me.Bac_Hoc.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Bac_Hoc.SizeF = New System.Drawing.SizeF(235.4167!, 23.0!)
        Me.Bac_Hoc.StylePriority.UseFont = False
        Me.Bac_Hoc.Text = "Bac_hoc"
        '
        'Ho_ten
        '
        Me.Ho_ten.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ho_ten.LocationFloat = New DevExpress.Utils.PointFloat(87.5!, 87.5!)
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ho_ten.SizeF = New System.Drawing.SizeF(235.4167!, 23.0!)
        Me.Ho_ten.StylePriority.UseFont = False
        Me.Ho_ten.Text = "Ho_ten"
        '
        'xrLabel10
        '
        Me.xrLabel10.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel10.LocationFloat = New DevExpress.Utils.PointFloat(325.0!, 87.5!)
        Me.xrLabel10.Name = "xrLabel10"
        Me.xrLabel10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel10.SizeF = New System.Drawing.SizeF(94.16669!, 23.00002!)
        Me.xrLabel10.StylePriority.UseFont = False
        Me.xrLabel10.Text = "Ngày sinh:"
        '
        'Ngay_Sinh
        '
        Me.Ngay_Sinh.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Ngay_Sinh.LocationFloat = New DevExpress.Utils.PointFloat(425.0!, 87.5!)
        Me.Ngay_Sinh.Name = "Ngay_Sinh"
        Me.Ngay_Sinh.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.Ngay_Sinh.SizeF = New System.Drawing.SizeF(220.8333!, 23.00002!)
        Me.Ngay_Sinh.StylePriority.UseFont = False
        Me.Ngay_Sinh.Text = "Ngay_Sinh"
        '
        'TopMargin
        '
        Me.TopMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLine1, Me.xrLabel1})
        Me.TopMargin.Name = "TopMargin"
        Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'xrLine1
        '
        Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(237.5!, 62.5!)
        Me.xrLine1.Name = "xrLine1"
        Me.xrLine1.SizeF = New System.Drawing.SizeF(171.875!, 23.00001!)
        '
        'xrLabel1
        '
        Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 25.0!)
        Me.xrLabel1.Multiline = True
        Me.xrLabel1.Name = "xrLabel1"
        Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel1.SizeF = New System.Drawing.SizeF(647.0833!, 52.16666!)
        Me.xrLabel1.StylePriority.UseFont = False
        Me.xrLabel1.StylePriority.UseTextAlignment = False
        Me.xrLabel1.Text = "CỘNG HOÀ XÃ HỘI CHỦ NGHĨA VIỆT NAM" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Độc lập - Tự do - Hạnh phúc" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'BottomMargin
        '
        Me.BottomMargin.Name = "BottomMargin"
        Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
        Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel3, Me.xrLabel4, Me.TieuDe_Noi_Ky})
        Me.GroupHeader1.HeightF = 111.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'xrLabel3
        '
        Me.xrLabel3.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(421.25!, 10.0!)
        Me.xrLabel3.Name = "xrLabel3"
        Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel3.SizeF = New System.Drawing.SizeF(224.5833!, 18.83335!)
        Me.xrLabel3.StylePriority.UseFont = False
        Me.xrLabel3.Text = ", ngày … tháng … năm 201..."
        '
        'xrLabel4
        '
        Me.xrLabel4.Font = New System.Drawing.Font("Times New Roman", 15.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 60.00001!)
        Me.xrLabel4.Name = "xrLabel4"
        Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel4.SizeF = New System.Drawing.SizeF(648.3334!, 23.0!)
        Me.xrLabel4.StylePriority.UseFont = False
        Me.xrLabel4.StylePriority.UseTextAlignment = False
        Me.xrLabel4.Text = "ĐƠN XIN XÁC NHẬN"
        Me.xrLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TieuDe_Noi_Ky
        '
        Me.TieuDe_Noi_Ky.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.TieuDe_Noi_Ky.LocationFloat = New DevExpress.Utils.PointFloat(279.5834!, 10.0!)
        Me.TieuDe_Noi_Ky.Name = "TieuDe_Noi_Ky"
        Me.TieuDe_Noi_Ky.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TieuDe_Noi_Ky.SizeF = New System.Drawing.SizeF(139.5833!, 18.83334!)
        Me.TieuDe_Noi_Ky.StylePriority.UseFont = False
        Me.TieuDe_Noi_Ky.Text = "TieuDe_Noi_Ky"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel22, Me.xrLabel21, Me.TieuDe_NoiKy, Me.xrLabel19, Me.TieuDe_NgayKi})
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'xrLabel22
        '
        Me.xrLabel22.Font = New System.Drawing.Font("Times New Roman", 13.0!)
        Me.xrLabel22.LocationFloat = New DevExpress.Utils.PointFloat(437.5!, 62.5!)
        Me.xrLabel22.Name = "xrLabel22"
        Me.xrLabel22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel22.SizeF = New System.Drawing.SizeF(201.6666!, 22.99995!)
        Me.xrLabel22.StylePriority.UseFont = False
        Me.xrLabel22.StylePriority.UseTextAlignment = False
        Me.xrLabel22.Text = "(Ký tên, ghi rõ họ tên)"
        Me.xrLabel22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'xrLabel21
        '
        Me.xrLabel21.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel21.LocationFloat = New DevExpress.Utils.PointFloat(437.5!, 37.5!)
        Me.xrLabel21.Name = "xrLabel21"
        Me.xrLabel21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel21.SizeF = New System.Drawing.SizeF(201.6667!, 23.00002!)
        Me.xrLabel21.StylePriority.UseFont = False
        Me.xrLabel21.StylePriority.UseTextAlignment = False
        Me.xrLabel21.Text = "NGƯỜI LÀM ĐƠN"
        Me.xrLabel21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TieuDe_NoiKy
        '
        Me.TieuDe_NoiKy.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.TieuDe_NoiKy.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 12.5!)
        Me.TieuDe_NoiKy.Name = "TieuDe_NoiKy"
        Me.TieuDe_NoiKy.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TieuDe_NoiKy.SizeF = New System.Drawing.SizeF(139.5833!, 18.83334!)
        Me.TieuDe_NoiKy.StylePriority.UseFont = False
        Me.TieuDe_NoiKy.Text = "TieuDe_Noi_Ky"
        '
        'xrLabel19
        '
        Me.xrLabel19.Font = New System.Drawing.Font("Times New Roman", 11.0!, System.Drawing.FontStyle.Bold)
        Me.xrLabel19.LocationFloat = New DevExpress.Utils.PointFloat(50.0!, 37.5!)
        Me.xrLabel19.Name = "xrLabel19"
        Me.xrLabel19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.xrLabel19.SizeF = New System.Drawing.SizeF(201.6667!, 23.00002!)
        Me.xrLabel19.StylePriority.UseFont = False
        Me.xrLabel19.StylePriority.UseTextAlignment = False
        Me.xrLabel19.Text = "XÁC NHẬN CỦA TRƯỜNG"
        Me.xrLabel19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        '
        'TieuDe_NgayKi
        '
        Me.TieuDe_NgayKi.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Italic)
        Me.TieuDe_NgayKi.LocationFloat = New DevExpress.Utils.PointFloat(137.5!, 12.5!)
        Me.TieuDe_NgayKi.Name = "TieuDe_NgayKi"
        Me.TieuDe_NgayKi.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.TieuDe_NgayKi.SizeF = New System.Drawing.SizeF(232.7083!, 18.83335!)
        Me.TieuDe_NgayKi.StylePriority.UseFont = False
        Me.TieuDe_NgayKi.Text = ", ngày …  tháng … năm 201..."
        '
        'rptDonXacNhan
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.TopMargin, Me.BottomMargin, Me.GroupHeader1, Me.GroupFooter1})
        Me.Version = "10.1"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents GroupHeader1 As DevExpress.XtraReports.UI.GroupHeaderBand
    Friend WithEvents GroupFooter1 As DevExpress.XtraReports.UI.GroupFooterBand
    Private WithEvents xrLabel3 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel4 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents TieuDe_Noi_Ky As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Khoa_Hoc As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel14 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Ten_Lop As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel12 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Hoc_Ki As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel11 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel16 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel18 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel13 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Ten_Khoa As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel17 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents TieuDe_TenTruong As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents TieuDe_TenPhong As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel8 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel5 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel6 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Nam_Thu As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel9 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Bac_Hoc As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Ho_ten As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel10 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents Ngay_Sinh As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel22 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel21 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents TieuDe_NoiKy As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLabel19 As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents TieuDe_NgayKi As DevExpress.XtraReports.UI.XRLabel
    Private WithEvents xrLine1 As DevExpress.XtraReports.UI.XRLine
    Private WithEvents xrLabel1 As DevExpress.XtraReports.UI.XRLabel
End Class
