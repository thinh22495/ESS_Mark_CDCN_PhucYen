Imports DevExpress.XtraReports.UI
Public Class rptMARK_BangDiemKiemTraHocPhan_HVCS
    Dim count As Integer = 0
    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_chuc_danh4 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_nguoi_ky4 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "", Optional ByVal Tieu_de5 As String = "", Optional ByVal Tieu_de6 As String = "", Optional ByVal Tieu_de7 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de1.Text = Tieu_de1
        Me.Tieu_de2.Text = Tieu_de2
        Me.Tieu_de3.Text = Tieu_de3
        Me.Tieu_de4.Text = Tieu_de4
        Me.Tieu_de5.Text = Tieu_de5
        Me.Tieu_de6.Text = Tieu_de6
        Me.Tieu_de7.Text = Tieu_de7
        Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Text = Tieu_de_chuc_danh4

        Me.Tieu_de_nguoi_ky1.Text = Tieu_de_nguoi_ky1
        Me.Tieu_de_nguoi_ky2.Text = Tieu_de_nguoi_ky2
        Me.Tieu_de_nguoi_ky3.Text = Tieu_de_nguoi_ky3
        Me.Tieu_de_nguoi_ky4.Text = Tieu_de_nguoi_ky4
        Me.Tieu_de_noi_ky.Text = Tieu_de_noi_ky
        Me.Tieu_de_ngay_ky.Text = GetReportDate()
    End Sub



    Public Sub binding()
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        Me.Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Me.So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Me.Hoc_ky.DataBindings.Add("Text", DataSource, "Hoc_ky")
        Me.Nam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Tong_tiet.DataBindings.Add("Text", DataSource, "Tong_tiet")

        Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")

        Me.So_lan_vi_pham.DataBindings.Add("Text", DataSource, "So_lan_vi_pham")
        Me.So_tiet_nghi_co_phep.DataBindings.Add("Text", DataSource, "So_tiet_nghi_co_phep")
        Me.So_tiet_nghi_khong_phep.DataBindings.Add("Text", DataSource, "So_tiet_nghi_khong_phep")
        Me.Tong_tiet_nghi.DataBindings.Add("Text", DataSource, "Tong_tiet_nghi")

        Me.DiemCC.DataBindings.Add("Text", DataSource, "DiemCC")
        Me.KT1.DataBindings.Add("Text", DataSource, "TX1")
        Me.KT2.DataBindings.Add("Text", DataSource, "TX2")
        Me.KT3.DataBindings.Add("Text", DataSource, "TX3")
        Me.KT4.DataBindings.Add("Text", DataSource, "TX4")
        Me.TBCBP.DataBindings.Add("Text", DataSource, "TBCBP")


        Me.Tong_SV.DataBindings.Add("Text", DataSource, "Tong_SV")
        Me.Tong_SV_DuDKT.DataBindings.Add("Text", DataSource, "Tong_SV_DuDKT")
        Me.Tong_SV_KhongDuDKT.DataBindings.Add("Text", DataSource, "Tong_SV_KhongDuDKT")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        TT.Text = count
    End Sub
End Class
