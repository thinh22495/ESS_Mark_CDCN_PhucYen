Imports DevExpress.XtraReports.UI
Public Class rptTongHopKetQuaCanhBao_Khoa
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
        Me.Ten_khoa.DataBindings.Add("Text", DataSource, "Ten_khoa")
        Me.Si_so.DataBindings.Add("Text", DataSource, "So_SV")
        Me.Tong_SL.DataBindings.Add("Text", DataSource, "Tong")
        Me.Tong_TL.DataBindings.Add("Text", DataSource, "Ty_le_tong", "{0:n2}")

    End Sub
End Class