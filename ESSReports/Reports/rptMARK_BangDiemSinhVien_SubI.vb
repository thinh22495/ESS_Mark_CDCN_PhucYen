Public Class rptMARK_BangDiemSinhVien_SubI
    Private count As Integer = 0
    Public Sub binding()
        TT.DataBindings.Add("Text", DataSource, "TT")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCMH_2Lan.DataBindings.Add("Text", DataSource, "TBCMH_2Lan")
        TBCMH4_2Lan.DataBindings.Add("Text", DataSource, "TBCMH4_2Lan")
        TBCMH_2Lan_DiemChu.DataBindings.Add("Text", DataSource, "TBCMH_2Lan_DiemChu")
    End Sub

    'Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
    '    count = count + 1
    '    TT.Text = count
    'End Sub
End Class