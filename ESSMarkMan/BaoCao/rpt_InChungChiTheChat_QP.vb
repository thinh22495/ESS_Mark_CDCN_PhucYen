Imports DevExpress.XtraReports.UI
Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESSUtility
Imports ESSReports
Public Class rpt_InChungChiTheChat_QP
    Public Sub New(Optional ByVal dv As DataView = Nothing, Optional ByVal Tu_ngay As Date = Nothing, Optional ByVal Den_ngay As Date = Nothing)
        InitializeComponent()
        Me.DataSource = dv

        Ngay1.Text = Tu_ngay.Day.ToString
        Thang1.Text = Tu_ngay.Month.ToString
        nam1.Text = Tu_ngay.Year.ToString

        Ngay2.Text = Den_ngay.Day.ToString
        Thang2.Text = Den_ngay.Month.ToString
        Nam2.Text = Den_ngay.Year.ToString
        Binding()
    End Sub
    Public Sub Binding()
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd-MM-yyyy}")
        Me.Noi_sinh.DataBindings.Add("Text", DataSource, "Ten_tinh")
        Me.Hoi_dong.DataBindings.Add("Text", DataSource, "Hoi_dong_thi")
        Me.Xep_loai.DataBindings.Add("Text", DataSource, "Xep_hang")
        So_vao_so.DataBindings.Add("Text", DataSource, "So_vao_so")

        Dim cls As New DanhMuc_Bussines
        Ngay.Text = cls.Cat_Xau("00" & DateTime.Now.Day.ToString(), 2)
        Thang.Text = cls.Cat_Xau("00" & DateTime.Now.Month.ToString(), 2)
        Nam.Text = DateTime.Now.Year.ToString()
    End Sub
End Class