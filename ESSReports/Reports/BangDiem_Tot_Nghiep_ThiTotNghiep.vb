Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class BangDiem_Tot_Nghiep_ThiTotNghiep
    Private subdata As DataView
    Private subdata2 As DataView
    Private mTBCHT As Double = 0
    Private mXep_loai As String = ""

    Private mDem As Integer = 0
    Private mdv_diem As DataView

    Public Sub New(ByVal dv_diem As DataView)
        mdv_diem = dv_diem
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = dv_diem.Item(0)("Tieu_de_ten_bo").ToString
        Me.Tieu_de_ten_truong.Text = dv_diem.Item(0)("Tieu_de_Ten_truong").ToString
        'TieuDe_ChucDanh.Text = dv_diem.Item(0)("Tieu_de_ten_bo").ToString
        'Ten_ChucDanh.Text = dv_diem.Item(0)("Tieu_de_ten_bo").ToString
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & " tháng " & DateTime.Now.Month.ToString() & " năm " & DateTime.Now.Year
        'Dim obj As rptDiem_ToanKhoa_SV_BLL = New rptDiem_ToanKhoa_SV_BLL

        Me.Ma_sv.Text = mdv_diem.Item(0)("Ma_sv").ToString
        Me.Ho_ten.Text = mdv_diem(0)("Ho_ten").ToString
        If mdv_diem(0)("Ngay_sinh").ToString <> "" Then Me.Ngay_sinh.Text = mdv_diem(0)("Ngay_sinh")
        Me.Que_quan.Text = mdv_diem(0)("Ten_tinh").ToString
        Me.Ten_lop.Text = mdv_diem(0)("Ten_lop").ToString
        Me.Nien_khoa.Text = mdv_diem(0)("Nien_khoa").ToString
        Me.Ten_khoa.Text = mdv_diem(0)("Ten_khoa").ToString
        Me.Ten_he.Text = mdv_diem(0)("Ten_he").ToString
        Me.Chuyen_nganh.Text = mdv_diem(0)("Chuyen_nganh").ToString

        mTBCHT = mdv_diem(0)("TBCHT").ToString
        mXep_loai = mdv_diem(0)("XEP_LOAI").ToString

        'mdv_diem.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
        mDem = Math.Round(mdv_diem.Count / 2 - 0.01, 0)
        'If mKhoaLuan_Diem <= 0 Then ' Truong hop sinh vien khong lam khoa luan ma thi Tot nghiep - Mau bang diem khac
        XrSubreport2.Visible = True
        XrSubreport3.Visible = False
        'Else
        'XrSubreport2.Visible = False
        'XrSubreport3.Visible = True
        'End If
    End Sub

    Private Sub XrSubreport1_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport1.BeforePrint
        Dim rpt As BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Left = XrSubreport1.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")

        mdv_diem.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
        'mdv_diem.Sort = "Ten_mon"
        For i As Integer = 0 To mDem + 2
            Dim dr As DataRow
            dr = dt.NewRow
            dr("STT") = i + 1
            dr("TBCHP") = mdv_diem.Item(i)("TBCHP")
            dr("Ten_mon") = mdv_diem.Item(i)("Ten_mon")
            dr("So_hoc_trinh") = mdv_diem.Item(i)("So_hoc_trinh")
            dt.Rows.Add(dr)
        Next
        rpt.DataSource = dt.DefaultView
        rpt.binding()
    End Sub

    Private Sub XrSubreport2_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles XrSubreport2.BeforePrint
        Dim rpt2 As BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Right = XrSubreport2.ReportSource
        Dim dt As New DataTable
        dt.Columns.Add("STT")
        dt.Columns.Add("Ten_mon")
        dt.Columns.Add("So_hoc_trinh")
        dt.Columns.Add("TBCHP")

        mdv_diem.RowFilter = "Khong_tinh_TBCHT=FALSE AND Mon_tot_nghiep=FALSE"
        'mdv_diem.Sort = "Ten_mon"
        For i As Integer = mDem + 3 To mdv_diem.Count - 1
            Dim dr As DataRow
            dr = dt.NewRow
            dr("STT") = i + 1
            dr("TBCHP") = mdv_diem.Item(i)("TBCHP")
            dr("Ten_mon") = mdv_diem.Item(i)("Ten_mon")
            dr("So_hoc_trinh") = mdv_diem.Item(i)("So_hoc_trinh")
            dt.Rows.Add(dr)
        Next
        rpt2.DataSource = dt.DefaultView
        rpt2.binding()
        'rpt2.binding(mTBCHT, mXep_loai)
    End Sub
End Class