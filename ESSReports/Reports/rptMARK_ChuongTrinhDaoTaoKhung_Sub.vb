Public Class rptMARK_ChuongTrinhDaoTaoKhung_Sub
    Private count As Integer = 0
    Public Sub binding()
        Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Ly_thuyet.DataBindings.Add("Text", DataSource, "Ly_thuyet")
        Thuc_hanh.DataBindings.Add("Text", DataSource, "Thuc_hanh")
        Tu_chon.DataBindings.Add("Checked", DataSource, "Tu_chon")
        Ten_kien_thuc.DataBindings.Add("Text", DataSource, "Ten_kien_thuc")
        BT.DataBindings.Add("Text", DataSource, "bai_tap")
        TL.DataBindings.Add("Text", DataSource, "Bai_tap_lon")
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        stt.Text = count
    End Sub
End Class