Imports DevExpress.XtraReports.UI
Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESSUtility
Imports ESSReports
Public Class rptGiayChungNhan_HoanThanhChuongTrinhHoc_TatCa
    Private mCaoDang As Boolean = False
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.DataSource = dv
        If dv.Count > 0 Then
            If dv.Item(0)("ID_he") = 2 Then
                mCaoDang = True
            Else
                mCaoDang = False
            End If
        End If
        Binding()
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki & ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh3
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki3
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Me.Noi_sinh.DataBindings.Add("Text", DataSource, "Noi_sinh")
        Me.Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Trinh_do.DataBindings.Add("Text", DataSource, "Cao đẳng")
        If mCaoDang Then
            Me.Ten_he.DataBindings.Add("Text", DataSource, "Chính quy")
        Else
            Me.Ten_he.DataBindings.Add("Text", DataSource, "Liên thông")
        End If
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        'Me.Tieu_de_ten_bo.DataBindings.Add("Text", DataSource, "Tieu_de_ten_bo")
        'Me.Tieu_de_ten_truong.DataBindings.Add("Text", DataSource, "Tieu_de_ten_truong")
        'Me.Tieu_de_chuc_danh1.DataBindings.Add("Text", DataSource, "Tieu_de_chuc_danh3")
        'Me.Tieu_de_nguoi_ky1.DataBindings.Add("Text", DataSource, "Tieu_de_nguoi_ky3")
    End Sub
End Class