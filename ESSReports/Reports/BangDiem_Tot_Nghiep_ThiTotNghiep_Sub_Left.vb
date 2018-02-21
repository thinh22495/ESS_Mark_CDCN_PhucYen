Public Class BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Left
    'Dim stt As Integer
    Public Sub binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Diem10.DataBindings.Add("Text", DataSource, "TBCMH")
        DiemChu.DataBindings.Add("Text", DataSource, "Diem_chu")
    End Sub
    'Private Sub So_thu_tu_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs)
    '    stt = stt + 1
    '    Me.So_thu_tu.Text = stt
    'End Sub
End Class