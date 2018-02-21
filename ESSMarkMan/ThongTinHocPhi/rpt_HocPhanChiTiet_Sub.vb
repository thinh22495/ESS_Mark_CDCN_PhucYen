Public Class rpt_HocPhanChiTiet_Sub
    Dim i As Integer = 0
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        i += 1
        STT.Text = i
    End Sub
    Public Sub binding()
        Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_tc_nganh1.DataBindings.Add("Text", DataSource, "Nganh_chinh")
        So_tc_nganh2.DataBindings.Add("Text", DataSource, "Nganh_2")
        Don_gia.DataBindings.Add("Text", DataSource, "Don_gia", "{0:###,###}")
        So_phai_nop.DataBindings.Add("Text", DataSource, "So_tien_phai_nop", "{0:###,###}")
        Da_nop.DataBindings.Add("Text", DataSource, "Da_nop")
    End Sub
End Class