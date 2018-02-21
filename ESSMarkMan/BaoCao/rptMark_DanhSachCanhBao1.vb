Imports DevExpress.XtraReports.UI
Public Class rptMark_DanhSachCanhBao1
    Dim count As Integer = 0
    Public Sub New(ByVal dv As DataView)
        InitializeComponent()
        Me.DataSource = dv
        binding()
    End Sub

    Public Sub binding()
        Me.Ly_do_cac_ky.DataBindings.Add("Text", DataSource, "Ly_do_cac_ky")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Ly_do.DataBindings.Add("Text", DataSource, "Ly_do")
        Me.Ma_SV.DataBindings.Add("Text", DataSource, "Ma_SV")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub
End Class
