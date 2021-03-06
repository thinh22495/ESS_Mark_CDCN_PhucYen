Imports DevExpress.XtraReports.UI
Imports ESS.Bussines
Public Class rptBangTotNghiep
    Public Sub New(Optional ByVal dv As DataView = Nothing)
        InitializeComponent()
        Me.DataSource = dv
        Binding()
    End Sub
    Public Sub Binding()
        Me.Ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh_chuan")
        Me.Gioi_tinh.DataBindings.Add("Text", DataSource, "Gioi_tinh")
        Me.Nganh_dao_tao.DataBindings.Add("Text", DataSource, "Ten_nganh")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")
        Hinh_thuc.Text = "Chính quy"
        Ten_he_en.Text = "Full-time"

        Nganh_dao_tao_en.DataBindings.Add("Text", DataSource, "Ten_nganh_En")
        Xep_loai_en.DataBindings.Add("Text", DataSource, "Xep_hang_En")
        Me.So_hieu.DataBindings.Add("Text", DataSource, "So_hieu")
        Me.txtSo_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")
        Me.txtSo_vao_so_En.DataBindings.Add("Text", DataSource, "So_vao_so")
        Ngay.Text = DateTime.Now.Day.ToString()
        Thang.Text = DateTime.Now.Month.ToString()
        Nam.Text = DateTime.Now.Year.ToString()
        Ngay_tieng_anh.Text = "Vinh Phuc   " & Format(Date.Now(), "dd MMMM yyyy")

        Me.Ten_en.DataBindings.Add("Text", DataSource, "Ho_ten_En")
        Me.Ngay_sinh_en.DataBindings.Add("Text", DataSource, "Ngay_sinh_En")
    End Sub

    'Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
    '    Dim a As String = Ngay_sinh.Text.ToString
    '    Dim Ngay_sinh_bind As DateTime = Convert.ToDateTime(Ngay_sinh.Text)
    '    If Ngay_sinh_bind.Month > 3 Then
    '        Ngay_sinh_en_chuan.Text = FormatDateTime(Ngay_sinh_bind, ("dd/M/yyyy"))
    '    Else
    '        Ngay_sinh_en_chuan.Text = FormatDateTime(Ngay_sinh_bind, ("dd/MM/yyyy"))
    '    End If

    'End Sub
End Class