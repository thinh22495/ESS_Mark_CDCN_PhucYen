Imports DevExpress.XtraReports.UI
Public Class rptESS_DanhSachDiemThiTungMonTheoLop
    Public dv As DataView
    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_bao_cao As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_nguoi_ki1 As String, ByVal Tieu_de_noi_ki As String)
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de_bao_cao.Text = Tieu_de_bao_cao
        'Me.Tieu_de_ngay_ki.Text = GetReportDate()
        'Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        'Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        'Me.Tieu_de_nguoi_ki3.Text = Tieu_de_nguoi_ki3
        'Me.Tieu_de_nguoi_ki1.Text = Tieu_de_nguoi_ki1
        'Me.Tieu_de_noi_ki.Text = Tieu_de_noi_ki
    End Sub
    Public Sub setupDynamicControls()
        Dim numCol As Integer = dv.Count - 1
        Dim childWidth As Double = (XrTableCell6.WidthF - TBC.WidthF) / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv(i).Row("Ten_thanh_phan") & " (" & dv(i)("Ty_le") & "%)"
            lb.WidthF = childWidth
            lb.HeightF = 23
            Dim p As New Point(i * childWidth, 23)
            lb.LocationF = p
            XrTableCell6.Controls.Add(lb)
        Next
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = 23
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            Kiem_tra_list.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "TP" & dv(j).Row("ID_thanh_phan"))
        Next
    End Sub
    Public Sub binding()
        Ma_sinh_vien.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ten_sinh_vien.DataBindings.Add("Text", DataSource, "Ho_ten")
        Diem_thi.DataBindings.Add("Text", DataSource, "Diem_thi")
        TBCHP.DataBindings.Add("Text", DataSource, "TBCHP")
        TBC.DataBindings.Add("Text", DataSource, "TBCBP")
    End Sub
    

End Class