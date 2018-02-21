Public Class rptMARK_ChuongTrinhDaoTaoKhung_Sub1
    Private count As Integer = 0
    Public Sub binding()
        Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Ten_hoc_phan.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_tc.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        LT.DataBindings.Add("Text", DataSource, "Ly_thuyet")
        TH.DataBindings.Add("Text", DataSource, "Thuc_hanh")
        Tu_chon.DataBindings.Add("Checked", DataSource, "Tu_chon")
        'Ten_kien_thuc.DataBindings.Add("Text", DataSource, "Ten_kien_thuc")
        BT.DataBindings.Add("Text", DataSource, "bai_tap")
        TL.DataBindings.Add("Text", DataSource, "Bai_tap_lon")
        Ky_thu.DataBindings.Add("Text", DataSource, "Ky_thu")
        He_so.DataBindings.Add("Text", DataSource, "He_so")
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        stt.Text = count
    End Sub
End Class