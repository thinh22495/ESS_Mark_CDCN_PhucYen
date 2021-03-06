Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
'Imports ESSUtility
Public Class rpt_BangDiemTotNghiep
    Private subdata As DataView
    Public ID_sv As Integer
    Public Sub SetupDatasource(ByVal dv As DataView)
        Me.subdata = dv
    End Sub
    Public Sub New(Optional ByVal Tieu_de_bao_cao As String = "", Optional ByVal dtMain As DataTable = Nothing)
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = dtMain.Rows(0).Item("Tieu_de_ten_bo").ToString
        Me.Tieu_de_ten_truong.Text = dtMain.Rows(0).Item("Tieu_de_ten_truong").ToString
        Tieu_de_noi_ky.Text = "Phúc Yên, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year

        'Me.Ma_sv.Text = dtMain.Rows(0).Item("Ma_sv").ToString
        Me.Ho_ten.Text = dtMain.Rows(0).Item("Ho_ten").ToString
        Me.Ngay_sinh.Text = FormatDateTime(dtMain.Rows(0).Item("Ngay_sinh"), DateFormat.ShortDate)
        'Me.Que_quan.Text = dtMain.Rows(0).Item("Ten_tinh").ToString
        Me.Nien_khoa.Text = dtMain.Rows(0).Item("Nien_khoa").ToString
        Me.Ten_nganh.Text = dtMain.Rows(0).Item("Ten_nganh").ToString
        Me.Ten_he.Text = dtMain.Rows(0).Item("Ten_he").ToString
        Me.Chuyen_nganh.Text = dtMain.Rows(0).Item("Chuyen_nganh").ToString
        Me.TBCHT.Text = "- TBCHT (thang điểm 10)  : " & dtMain.Rows(0).Item("TBCHT_10").ToString
        Me.TBCHT4.Text = "- TBCHT (thang điểm 4)    : " & dtMain.Rows(0).Item("TBCHT").ToString
        Me.Tong_tc.Text = "- Số tín chỉ tích lũy               : " & dtMain.Rows(0).Item("Tong_so_TC").ToString
        Me.Xep_loai.Text = "- Xếp loại tốt nghiệp            : " & dtMain.Rows(0).Item("Xep_loai").ToString
        Me.lblTongDiem_RL.Text = "- Tổng điểm rèn luyện         : " & dtMain.Rows(0).Item("TBC_RL").ToString
        Me.lblXepLoai_RL.Text = "- Xếp loại rèn luyện            : " & dtMain.Rows(0).Item("Xep_loai_RL").ToString
        Me.Tieu_de_chuc_danh3.Text = dtMain.Rows(0).Item("Tieu_de_chuc_danh3").ToString
        Me.Tieu_de_chuc_danh4.Text = dtMain.Rows(0).Item("Tieu_de_chuc_danh4").ToString
        Me.Tieu_de_nguoi_ky3.Text = dtMain.Rows(0).Item("Tieu_de_nguoi_ky3").ToString
        Me.Tieu_de_nguoi_ky4.Text = dtMain.Rows(0).Item("Tieu_de_nguoi_ky4").ToString
    End Sub
    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Left = XrSubreport1.ReportSource
        Dim dv1 As DataView = Me.subdata
        Dim dt_sub1 As New DataTable
        dt_sub1.Columns.Add("Ten_mon")
        dt_sub1.Columns.Add("So_hoc_trinh")
        dt_sub1.Columns.Add("TBCMH")
        dt_sub1.Columns.Add("Diem_chu")
        Dim tong As Integer = dv1.Count
        Dim dem As Integer = Math.Round(tong / 2, 1)
        If dv1.Count > 0 Then
            For i As Integer = 0 To dem - 1
                Dim dr As DataRow
                dr = dt_sub1.NewRow
                dr("Ten_mon") = dv1.Item(i)("Ten_mon")
                dr("So_hoc_trinh") = dv1.Item(i)("So_hoc_trinh")
                dr("TBCMH") = dv1.Item(i)("TBCMH")
                dr("Diem_chu") = dv1.Item(i)("Diem_chu")
                dt_sub1.Rows.Add(dr)
            Next
        End If
        rpt.DataSource = dt_sub1.DefaultView
        rpt.binding()
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim rpt2 As BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Right = XrSubreport2.ReportSource
        Dim dv2 As DataView = Me.subdata
        Dim dt_sub2 As New DataTable
        dt_sub2.Columns.Add("stt")
        dt_sub2.Columns.Add("Ten_mon")
        dt_sub2.Columns.Add("So_hoc_trinh")
        dt_sub2.Columns.Add("TBCMH")
        dt_sub2.Columns.Add("Diem_chu")
        Dim tong As Integer = dv2.Count
        Dim dem As Integer = Math.Round(tong / 2, 1)
        If dv2.Count > 0 Then
            For i As Integer = dem To tong - 1
                Dim dr As DataRow
                dr = dt_sub2.NewRow
                dr("stt") = dv2.Item(i)("stt")
                dr("Ten_mon") = dv2.Item(i)("Ten_mon")
                dr("So_hoc_trinh") = dv2.Item(i)("So_hoc_trinh")
                dr("TBCMH") = dv2.Item(i)("TBCMH")
                dr("Diem_chu") = dv2.Item(i)("Diem_chu")
                dt_sub2.Rows.Add(dr)
            Next
        End If
        rpt2.DataSource = dt_sub2.DefaultView
        rpt2.binding()
    End Sub
End Class