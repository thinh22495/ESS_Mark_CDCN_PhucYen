Public Class rptDSCapPhatChungChiGDTC
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Khoa_hoc As String = "")
        InitializeComponent()
        Me.Tieu_de_chuc_danh1.Text = gTieu_de_chuc_danh1
        Me.Tieu_de_nguoi_ky1.Text = gTieu_de_nguoi_ki1
        Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_noi_ky.Text = gTieu_de_noi_ki + ", ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        Me.Khoa_hoc.Text = Khoa_hoc.ToString
        Me.Ten_lop.Text = dv.Item(0)("Ten_lop").ToString
        Me.Ten_he.Text = dv.Item(0)("Ten_lop").ToString
        Me.Chuyen_nganh.Text = dv.Item(0)("Chuyen_nganh").ToString
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Noi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")
        So_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")
    End Sub
End Class