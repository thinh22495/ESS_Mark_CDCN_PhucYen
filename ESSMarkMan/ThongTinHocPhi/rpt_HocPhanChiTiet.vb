Imports DevExpress.XtraReports.UI
Public Class rpt_HocPhanChiTiet
    Dim mdtMain, mdtSub As DataTable
    Public Sub New(ByVal dtMain As DataTable, ByVal dtSub As DataTable, ByVal mSo_du As String)
        InitializeComponent()
        mdtSub = dtSub
        mdtMain = dtMain
        Me.TieuDe_Bo.Text = gTieu_de_ten_bo
        Me.tieude_tentruong.Text = gTieu_de_ten_truong
        Tieu_de_noi_ky.Text = gTieu_de_noi_ki & ", Ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        So_du.Text = mSo_du
        binding()
    End Sub
    Private Sub binding()
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.DataSource = mdtMain.DefaultView
        Hoc_ky.DataBindings.Add("Text", DataSource, "Hoc_ky")
        Nam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc")
        So_tien_da_nop.DataBindings.Add("Text", DataSource, "Hoc_phi", "{0:###,###}")
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rpt_HocPhanChiTiet_Sub = XrSubreport1.ReportSource
        mdtSub.DefaultView.RowFilter = " Hoc_ky= " & Convert.ToInt32(Me.Hoc_ky.Text) & " AND Nam_hoc='" & Nam_hoc.Text.Trim & "' "
        rpt.DataSource = mdtSub.DefaultView
        rpt.binding()
    End Sub
End Class