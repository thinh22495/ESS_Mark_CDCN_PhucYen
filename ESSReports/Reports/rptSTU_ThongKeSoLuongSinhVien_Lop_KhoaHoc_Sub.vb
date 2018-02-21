Public Class rptSTU_ThongKeSoLuongSinhVien_Lop_KhoaHoc_Sub
    Private count As Integer = 0

    Public Sub binding()
        Me.Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Tong_so.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.So_sv_nam.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.So_sv_nu.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.So_tam_dung.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.So_dang_hoc.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.So_tot_nghiep.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.So_nghi.DataBindings.Add("Text", DataSource, "So_nghi")

        Me.zTong_so.DataBindings.Add("Text", DataSource, "Tong_so")
        Me.zSo_sv_nam.DataBindings.Add("Text", DataSource, "So_sv_nam")
        Me.zSo_sv_nu.DataBindings.Add("Text", DataSource, "So_sv_nu")

        Me.zSo_tam_dung.DataBindings.Add("Text", DataSource, "So_tam_dung")
        Me.zSo_dang_hoc.DataBindings.Add("Text", DataSource, "So_dang_hoc")
        Me.zSo_tot_nghiep.DataBindings.Add("Text", DataSource, "So_tot_nghiep")
        Me.zSo_nghi.DataBindings.Add("Text", DataSource, "So_nghi")

    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub


    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_khoa")
        GroupHeader1.GroupFields.Add(grFields)

    End Sub

  
End Class