Imports DevExpress.XtraReports.UI
Public Class rptThongKeHocPhi_TheoHe_KhoaHoc_Khoa
    Public Sub New(ByVal dv As DataView, ByVal mTong_tien As Integer, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "")
        InitializeComponent()
        Me.DataSource = dv
        Binding()
        Tieu_de_bao_cao1.Text = Tieu_de1
        Tieu_de_bao_cao2.Text = Tieu_de2
        Tieu_de_noi_ky.Text = "Ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        Tieu_de_nguoi_ky1.Text = gobjUser.FullName
        Tong_tien.Text = Format(mTong_tien, "###,###")
    End Sub
    Public Sub Binding()
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tong_so_sv.DataBindings.Add("Text", DataSource, "Tong_so_sv")
        Tong_so_sv_NoHP.DataBindings.Add("Text", DataSource, "Tong_so_sv_NoHP")
        So_tien_No.DataBindings.Add("Text", DataSource, "So_tien_No", "{0:###,###}")
        No_HP_BinhQuan.DataBindings.Add("Text", DataSource, "No_HP_BinhQuan", "{0:###,###}")
        Ho_ten_gv.DataBindings.Add("Text", DataSource, "Ho_ten_gv")
    End Sub
End Class