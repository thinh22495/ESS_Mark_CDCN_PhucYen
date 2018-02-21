Imports DevExpress.XtraReports.UI
Public Class rptSTU_ThongKeSoLuongSinhVien_KhoaHoc
    Dim count As Integer = 0


    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_chuc_danh4 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_nguoi_ky4 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "", Optional ByVal Tieu_de5 As String = "", Optional ByVal Tieu_de6 As String = "", Optional ByVal Tieu_de7 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de1.Text = Tieu_de1
        Me.Tieu_de2.Text = Tieu_de2
        Me.Tieu_de3.Text = Tieu_de3
        Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Visible = False
        Me.Tieu_de_nguoi_ky1.Text = Tieu_de_nguoi_ky1
        Me.Tieu_de_nguoi_ky2.Text = Tieu_de_nguoi_ky2
        Me.Tieu_de_nguoi_ky3.Text = Tieu_de_nguoi_ky3
        Me.Tieu_de_nguoi_ky4.Visible = False
        Me.Tieu_de_noi_ky.Text = Tieu_de_noi_ky
        Me.Tieu_de_ngay_ky.Text = GetReportDate()
    End Sub

    Public Sub binding()
        Me.Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Me.Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")

        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Tong_so.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.So_sv_nam.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.So_sv_nu.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.So_tam_dung.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.So_dang_hoc.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.So_tot_nghiep.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.So_nghi.DataBindings.Add("Text", DataSource, "So_nghi")

        Me.zTong_so1.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zSo_sv_nam1.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.zSo_sv_nu1.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.zSo_tam_dung1.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.zSo_dang_hoc1.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.zSo_tot_nghiep1.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.zSo_nghi1.DataBindings.Add("Text", DataSource, "So_nghi")

        Me.zTong_so2.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zSo_sv_nam2.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.zSo_sv_nu2.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.zSo_tam_dung2.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.zSo_dang_hoc2.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.zSo_tot_nghiep2.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.zSo_nghi2.DataBindings.Add("Text", DataSource, "So_nghi")



        Me.zTong_so.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zSo_sv_nam.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.zSo_sv_nu.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.zSo_tam_dung.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.zSo_dang_hoc.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.zSo_tot_nghiep.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.zSo_nghi.DataBindings.Add("Text", DataSource, "So_nghi")
    End Sub



    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_khoa")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub

    Private Sub GroupHeader2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader2.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_he")
        GroupHeader2.GroupFields.Add(grFields)
    End Sub
End Class
