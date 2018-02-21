Imports DevExpress.XtraReports.UI
Public Class rptSTU_ThongTinDanhBaSinhVien
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
        Me.Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")

        Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Dan_toc.DataBindings.Add("Text", DataSource, "Dan_toc")
        Me.Noi_sinh.DataBindings.Add("Text", DataSource, "Noi_sinh")


        Me.Dia_chi_tt.DataBindings.Add("Text", DataSource, "Dia_chi_tt")
        Me.Ton_giao.DataBindings.Add("Text", DataSource, "Ton_giao")
        Me.Ten_dt.DataBindings.Add("Text", DataSource, "Ten_dt")
        Me.Ten_kv.DataBindings.Add("Text", DataSource, "Ten_kv")
        Me.Ho_ten_cha.DataBindings.Add("Text", DataSource, "Ho_ten_cha")
        Me.Ho_ten_me.DataBindings.Add("Text", DataSource, "Ho_ten_me")

        Me.zTong_so1.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zTong_so2.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zTong_so.DataBindings.Add("Text", DataSource, "Tong_so")
       
    End Sub



    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Khoa_hoc")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub

    Private Sub GroupHeader2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader2.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_khoa")
        GroupHeader2.GroupFields.Add(grFields)

    End Sub
End Class
