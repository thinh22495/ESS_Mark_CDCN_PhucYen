Imports DevExpress.XtraReports.UI
Public Class rptSTU_BangDiemRenLuyen_ToanKhoa
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

        Me.Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")


        Me.Ma_sinh_vien.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Tong_diem_nam1.DataBindings.Add("Text", DataSource, "Tong_diem_nam1")
        Me.Tong_diem_nam2.DataBindings.Add("Text", DataSource, "Tong_diem_nam2")
        Me.Tong_diem_nam3.DataBindings.Add("Text", DataSource, "Tong_diem_nam3")
        Me.Tong_diem_nam4.DataBindings.Add("Text", DataSource, "Tong_diem_nam4")
        Me.Tong_diem.DataBindings.Add("Text", DataSource, "Tong_diem")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_loai")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub
End Class
