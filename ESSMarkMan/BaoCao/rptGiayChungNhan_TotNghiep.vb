Imports DevExpress.XtraReports.UI
Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESSUtility
Imports ESSReports
Public Class rptGiayChungNhan_TotNghiep
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki3
        Me.Ten_he.Text = "Chính quy"
        If dv.Count > 0 Then
            If dv.Item(0)("So_QD").ToString <> "" Then So_quyet_dinh.Text = dv.Item(0)("So_QD").ToString & "  ngày " & FormatDateTime(dv.Item(0)("Ngay_QD"), DateFormat.ShortDate)
        End If
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Noi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.Nganh_hoc.DataBindings.Add("Text", DataSource, "Ten_nganh")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Trinh_do.DataBindings.Add("Text", DataSource, "Ten_he")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Nien_khoa")
        Me.Diem_4.DataBindings.Add("Text", DataSource, "TBCHT")
        Me.Diem_10.DataBindings.Add("Text", DataSource, "TBCHT10")
        Me.Diem_10.DataBindings.Add("Text", DataSource, "TBCHT10")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")

        'Me.Tieu_de_ten_bo.DataBindings.Add("Text", DataSource, "Tieu_de_ten_bo")
        'Me.Tieu_de_ten_truong.DataBindings.Add("Text", DataSource, "Tieu_de_ten_truong")
        'Me.Tieu_de_chuc_danh1.DataBindings.Add("Text", DataSource, "Tieu_de_chuc_danh3")
        'Me.Tieu_de_nguoi_ky1.DataBindings.Add("Text", DataSource, "Tieu_de_nguoi_ky3")
    End Sub
End Class