Imports DevExpress.XtraReports.UI
Imports ESS.Bussines
Public Class rptDanhSachPhatBangTN
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tieu_de As String = "")
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        Me.Ten_lop.Text = dv.Item(0)("Ten_lop").ToString
        Me.Khoa_hoc.Text = dv.Item(0)("Nien_khoa").ToString
        Me.Chuyen_nganh.Text = dv.Item(0)("Chuyen_nganh").ToString
        Me.Ten_he.Text = dv.Item(0)("Ten_he").ToString
        Me.Tieu_de.Text = Tieu_de.ToString.ToUpper
        Me.Tieu_de_ngay_ky.Text = "Vĩnh Phúc, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd-MM-yyyy}")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Noi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.Xep_loai_TN.DataBindings.Add("Text", DataSource, "Xep_hang")
        Me.So_hieu.DataBindings.Add("Text", DataSource, "So_hieu")
        Me.So_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")
    End Sub
End Class