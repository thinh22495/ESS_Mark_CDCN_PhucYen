Public Class rptPlan_ThoiKhoaBieu_PhongHoc1
    Private subdata1 As DataView
    Public Sub SetupDatasource(ByVal dv1 As DataView)
        Me.subdata1 = dv1
    End Sub
    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_chuc_danh4 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_nguoi_ky4 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de1
    End Sub
    Public Sub binding()
        txtTen_phong.DataBindings.Add("Text", DataSource, "Ten_phong")
    End Sub
    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptPlan_DanhSach_PhongHoc = XrSubreport1.ReportSource
        subdata1.RowFilter = ""
        subdata1.RowFilter = " Ten_phong = '" & txtTen_phong.Text & "'"
        rpt.DataSource = subdata1
        rpt.binding()
    End Sub


End Class