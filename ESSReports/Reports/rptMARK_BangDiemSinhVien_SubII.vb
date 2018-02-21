Public Class rptMARK_BangDiemSinhVien_SubII
    Private count As Integer = 0
    Public Sub binding()
        TT2.DataBindings.Add("Text", DataSource, "TT")
        Ten_mon2.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh2.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        TBCMH_2Lan2.DataBindings.Add("Text", DataSource, "TBCMH_2Lan")
        TBCMH4_2Lan2.DataBindings.Add("Text", DataSource, "TBCMH4_2Lan")
        TBCMH_2Lan_DiemChu2.DataBindings.Add("Text", DataSource, "TBCMH_2Lan_DiemChu")
    End Sub

    'Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
    '    count = count + 1
    '    TT2.Text = count
    'End Sub
End Class