Imports DevExpress.XtraReports.UI
Public Class rptMark_ThongKe_TotNghiep
    Dim count As Integer = 0
    Public Sub New(ByVal dv As DataView)
        InitializeComponent()
        Me.DataSource = dv
        binding()
    End Sub

    Public Sub binding()
        Me.So_sv_TN.DataBindings.Add("Text", DataSource, "So_SV_TN")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Me.Ten_chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.So_SV.DataBindings.Add("Text", DataSource, "So_SV")
        Me.Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub
End Class
