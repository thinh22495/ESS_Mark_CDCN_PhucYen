Public Class rptmark_BangDiemSinhVien
    Private subdata1 As DataView
    Private subdata2 As DataView
    Public Sub SetupDatasource(ByVal dv1 As DataView, ByVal dv2 As DataView)
        Me.subdata1 = dv1
        Me.subdata2 = dv2
    End Sub
    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_chuc_danh4 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_nguoi_ky4 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de.Text = Tieu_de1
        Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Text = Tieu_de_chuc_danh4
        Me.Tieu_de_chuc_danh4.Visible = True
        Me.Tieu_de_nguoi_ky1.Text = Tieu_de_nguoi_ky1
        Me.Tieu_de_nguoi_ky2.Text = Tieu_de_nguoi_ky2
        Me.Tieu_de_nguoi_ky3.Text = Tieu_de_nguoi_ky3
        Me.Tieu_de_nguoi_ky4.Text = Tieu_de_nguoi_ky4
        Me.Tieu_de_nguoi_ky4.Visible = False
        Me.Tieu_de_noi_ky.Text = Tieu_de_noi_ky
        Me.Tieu_de_ngay_ky.Text = GetReportDate()
    End Sub
    Public Sub binding()
        Nam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc")
    End Sub
    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As rptPlan_DanhSach_PhongHoc = XrSubreport1.ReportSource
        subdata1.RowFilter = ""
        subdata1.RowFilter = " Nam_hoc = '" & Nam_hoc.Text & "'"
        rpt.DataSource = subdata1
        rpt.binding()
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim rpt As rptMARK_BangDiemSinhVien_SubII = XrSubreport2.ReportSource
        subdata2.RowFilter = ""
        subdata2.RowFilter = " Nam_hoc= '" & Nam_hoc.Text & "'"
        rpt.DataSource = subdata2
        rpt.binding()
    End Sub


End Class