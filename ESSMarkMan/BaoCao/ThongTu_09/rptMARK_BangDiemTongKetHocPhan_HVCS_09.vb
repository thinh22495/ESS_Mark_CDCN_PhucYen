Imports DevExpress.XtraReports.UI
Public Class rptMARK_BangDiemTongKetHocPhan_HVCS_09
    Dim count As Integer = 0
    Public Sub New(ByVal dv As DataView, ByVal dtTP As DataTable, ByVal Tieu_de As String)
        InitializeComponent()
        Me.DataSource = dv
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de1.Text = Tieu_de

        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = gTieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Text = gTieu_de_chuc_danh4

        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_nguoi_ky2.Text = gTieu_de_nguoi_ki2
        Me.Tieu_de_nguoi_ky3.Text = gTieu_de_nguoi_ki3
        Me.Tieu_de_nguoi_ky4.Text = gTieu_de_nguoi_ki4
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki
        Me.Tieu_de_ngay_ky.Text = GetReportDate()

        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        Me.Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Me.So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Me.Ten_phong.DataBindings.Add("Text", DataSource, "Ten_phong")
        Me.Ngay_thi.DataBindings.Add("Text", DataSource, "Ngay_thi")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Ngay_cham.DataBindings.Add("Text", DataSource, "Ngay_cham")
        Me.Tong_tiet.DataBindings.Add("Text", DataSource, "Tong_tiet")

        Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        ''Điểm thường xuyên
        Dim dt_ As DataView
        dt_ = dtTP.Copy.DefaultView
        dt_.RowFilter = "He_so = 1"
        Dim numCol As Integer = dt_.Count - 1
        Dim childWidth As Double = TX.WidthF / (numCol + 1)
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            TX.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, dt_.Item(j)("Ky_hieu"), "{0:n1}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

            ''Tieu đề
            Dim lb As New XRLabel()
            lb.Text = dt_.Item(j)("Ten_thanh_phan")
            lb.WidthF = childWidth
            lb.HeightF = TX_.HeightF
            Dim p As New Point(j * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            TX_.Controls.Add(lb)
            If j = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        ''Điểm định kì
        Dim dv_ As DataView
        dv_ = dtTP.DefaultView
        dv_.RowFilter = "He_so = 2"
        Dim numCol_ As Integer = dv_.Count - 1
        Dim childWidth_ As Double = DK.WidthF / (numCol_ + 1)
        For j As Integer = 0 To numCol_
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth_
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth_, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol_ Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            DK.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, dv_.Item(j)("Ky_hieu"), "{0:n1}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter

            ''Tieu đề
            Dim lb As New XRLabel()
            lb.Text = dv_.Item(j)("Ten_thanh_phan")
            lb.WidthF = childWidth_
            lb.HeightF = DK_.HeightF
            Dim p As New Point(j * childWidth_, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            DK_.Controls.Add(lb)
            If j = numCol_ Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next

        Me.TBCBP.DataBindings.Add("Text", DataSource, "TBCBP")
        Me.TBCMH.DataBindings.Add("Text", DataSource, "TBCMH")
        Me.Diem_so.DataBindings.Add("Text", DataSource, "Diem_so")
        Me.Diem_thi.DataBindings.Add("Text", DataSource, "Diem_thi")
        Me.Diem_chu.DataBindings.Add("Text", DataSource, "Diem_chu")

        Me.Tong_SV_Du_DKDT.DataBindings.Add("Text", DataSource, "Tong_SV_Du_DKDT")
        Me.Tong_SV_KoDu_DKDT.DataBindings.Add("Text", DataSource, "Tong_SV_KoDu_DKDT")
        Me.Tong_SV.DataBindings.Add("Text", DataSource, "Tong_sinh_vien")
        Me.Tong_SV_Dat.DataBindings.Add("Text", DataSource, "Tong_SV_Dat")
        Me.Tong_SV_KhongDat.DataBindings.Add("Text", DataSource, "Tong_SV_KhongDat")
        Me.Tong_SV_X.DataBindings.Add("Text", DataSource, "Tong_SV_X")
        Me.Tong_SV.DataBindings.Add("Text", DataSource, "Tong_SV")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        TT.Text = count
    End Sub
End Class
