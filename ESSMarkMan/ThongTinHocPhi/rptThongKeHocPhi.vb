Imports DevExpress.XtraReports.UI
Public Class rptThongKeHocPhi
    Public Sub New(ByVal dv As DataView, ByVal TongThua As Integer, ByVal TongThieu As Integer, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "")
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        Tieu_de_bao_cao1.Text = Tieu_de1
        Tieu_de_bao_cao2.Text = Tieu_de2
        Tieu_de_noi_ky.Text = "Phúc yên, ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        Tieu_de_nguoi_ky1.Text = gobjUser.FullName

        tONG_tHUA.Text = TongThua
        Tong_Thieu.Text = TongThieu
    End Sub
    Public Sub Binding()
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tien_Thua.DataBindings.Add("Text", DataSource, "Tien_Thua", "{0:###,###}")
        Tien_Thieu.DataBindings.Add("Text", DataSource, "Tien_Thieu", "{0:###,###}")
        Trang_thai.DataBindings.Add("Text", DataSource, "Trang_thai_hoc")
    End Sub
End Class