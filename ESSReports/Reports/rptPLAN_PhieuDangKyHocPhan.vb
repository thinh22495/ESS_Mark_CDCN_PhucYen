Public Class rptPLAN_PhieuDangKyHocPhan

    Private count As Integer = 0

    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de1
        Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        'Me.Tieu_de_chuc_danh2.Text = Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Visible = False
        Me.Tieu_de_nguoi_ky1.Text = Tieu_de_nguoi_ky1
        'Me.Tieu_de_nguoi_ky2.Text = Tieu_de_nguoi_ky2
        'Me.Tieu_de_nguoi_ky3.Text = Tieu_de_nguoi_ky3
        'Me.Tieu_de_nguoi_ky4.Visible = False
        Me.Tieu_de_noi_ky.Text = Tieu_de_noi_ky
        Me.Tieu_de_ngay_ky.Text = GetReportDate()
    End Sub


    Public Sub binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten_sv.DataBindings.Add("Text", DataSource, "Ho_ten_sv")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        So_HP.DataBindings.Add("Text", DataSource, "So_HP")
        So_TC.DataBindings.Add("Text", DataSource, "So_TC")
        Hoc_phi.DataBindings.Add("Text", DataSource, "Hoc_phi")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")


        'Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_tin_chi.DataBindings.Add("Text", DataSource, "So_tin_chi")
        Ten_lop_tc.DataBindings.Add("Text", DataSource, "Ten_lop_tc")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Thoi_gian.DataBindings.Add("Text", DataSource, "Thoi_gian")
        Ten_phong.DataBindings.Add("Text", DataSource, "Ten_phong")

        Ho_ten_sv_ky.DataBindings.Add("Text", DataSource, "Ho_ten_sv")
        Rut_HP.DataBindings.Add("Checked", DataSource, "Rut_bot_hoc_phan")
        Duyet.DataBindings.Add("Checked", DataSource, "Duyet")
    End Sub

 

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub
End Class