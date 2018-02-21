Imports DevExpress.XtraReports.UI
Public Class rptTongHopKetQuaCanhBao_ChiTiet_TheoLop
    Dim count As Integer = 0
    Public Sub New(ByVal dv As DataView, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String)
        InitializeComponent()
        Me.Tieu_de_bao_cao1.Text = Tieu_de1
        Me.Tieu_de_bao_cao2.Text = Tieu_de2
        Me.DataSource = dv
        binding()
    End Sub

    Public Sub binding()
        Me.Muc1_SL.DataBindings.Add("Text", DataSource, "Lan1")
        Me.Muc1_TL.DataBindings.Add("Text", DataSource, "Ty_le1", "{0:n2}")
        Me.Muc2_SL.DataBindings.Add("Text", DataSource, "Lan2")
        Me.Muc2_TL.DataBindings.Add("Text", DataSource, "Ty_le2", "{0:n2}")
        Me.Muc3_SL.DataBindings.Add("Text", DataSource, "Lan3")
        Me.Muc3_TL.DataBindings.Add("Text", DataSource, "Ty_le3", "{0:n2}")
        Me.Si_so.DataBindings.Add("Text", DataSource, "So_SV")
        Me.Tong_SL.DataBindings.Add("Text", DataSource, "Tong")
        Me.Tong_TL.DataBindings.Add("Text", DataSource, "Ty_le_tong", "{0:n2}")

        Me.Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Me.Khoa_hoc.DataBindings.Add("Text", DataSource, "Khoa_hoc")
        Ten_lop_group.DataBindings.Add("Text", DataSource, "Ten_lop")
    End Sub
    Private Sub GroupHeader1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader1.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_lop")
        GroupHeader1.GroupFields.Add(grFields)
    End Sub
    Private Sub GroupHeader2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader2.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Khoa_hoc")
        GroupHeader2.GroupFields.Add(grFields)
    End Sub

    Private Sub GroupHeader3_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles GroupHeader3.BeforePrint
        Dim grFields As New DevExpress.XtraReports.UI.GroupField("Ten_khoa")
        GroupHeader3.GroupFields.Add(grFields)
    End Sub
End Class