Imports DevExpress.XtraReports.UI
Public Class rptCanhCaoKetQuaHocTap
    Dim count As Integer = 0
    Public Sub New(ByVal dv As DataView, ByVal Tieu_de1 As String, ByVal Tieu_de2 As String)
        InitializeComponent()
        'Me.Tieu_de_ten_bo.Text = gTieu_de_ten_bo
        'Me.Tieu_de_ten_truong.Text = gTieu_de_ten_truong
        Me.Tieu_de_bao_cao1.Text = Tieu_de1
        Me.Tieu_de_bao_cao2.Text = Tieu_de2
        Me.DataSource = dv
        binding()
    End Sub

    Public Sub binding()
        Me.Muc1.DataBindings.Add("Text", DataSource, "Lan1")
        Me.Muc2.DataBindings.Add("Text", DataSource, "Lan2")
        Me.Muc3.DataBindings.Add("Text", DataSource, "Lan3")
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.So_SV.DataBindings.Add("Text", DataSource, "So_SV")
        Me.Tong.DataBindings.Add("Text", DataSource, "Tong")
        Me.Tong_so_sv.DataBindings.Add("Text", DataSource, "So_sv")
        Me.Tong_muc1.DataBindings.Add("Text", DataSource, "Lan1")
        Me.Tong_muc2.DataBindings.Add("Text", DataSource, "Lan2")
        Me.Tong_muc3.DataBindings.Add("Text", DataSource, "Lan3")
        Me.Tong_4.DataBindings.Add("Text", DataSource, "Tong")

    End Sub
End Class