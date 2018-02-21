
Imports DevExpress.XtraReports.UI
Imports System.Drawing
Public Class rptESS_BangDiemTongKetHocKy_KTTCTN
    Public dv As DataView
    Dim count As Integer = 0
    Public Sub New(ByVal Tieu_de_ten_bo As String, ByVal Tieu_de_ten_truong As String, ByVal Tieu_de_chuc_danh1 As String, ByVal Tieu_de_chuc_danh2 As String, ByVal Tieu_de_chuc_danh3 As String, ByVal Tieu_de_chuc_danh4 As String, ByVal Tieu_de_nguoi_ky1 As String, ByVal Tieu_de_nguoi_ky2 As String, ByVal Tieu_de_nguoi_ky3 As String, ByVal Tieu_de_nguoi_ky4 As String, ByVal Tieu_de_noi_ky As String, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "", Optional ByVal Tieu_de3 As String = "", Optional ByVal Tieu_de4 As String = "", Optional ByVal Tieu_de5 As String = "", Optional ByVal Tieu_de6 As String = "", Optional ByVal Tieu_de7 As String = "")
        InitializeComponent()
        Me.Tieu_de_ten_bo.Text = Tieu_de_ten_bo
        Me.Tieu_de_ten_truong.Text = Tieu_de_ten_truong
        Me.Tieu_de1.Text = Tieu_de1
        Me.Tieu_de2.Text = Tieu_de2
        Me.Tieu_de3.Text = Tieu_de3
        Me.Tieu_de4.Text = Tieu_de4
        Me.Tieu_de5.Text = Tieu_de5
        Me.Tieu_de6.Text = Tieu_de6
        Me.Tieu_de7.Text = Tieu_de7
        Me.Tieu_de_chuc_danh1.Text = Tieu_de_chuc_danh1
        Me.Tieu_de_chuc_danh2.Text = Tieu_de_chuc_danh2
        Me.Tieu_de_chuc_danh3.Text = Tieu_de_chuc_danh3
        Me.Tieu_de_chuc_danh4.Text = Tieu_de_chuc_danh4

        Me.Tieu_de_nguoi_ky1.Text = Tieu_de_nguoi_ky1
        Me.Tieu_de_nguoi_ky2.Text = Tieu_de_nguoi_ky2
        Me.Tieu_de_nguoi_ky3.Text = Tieu_de_nguoi_ky3
        Me.Tieu_de_nguoi_ky4.Text = Tieu_de_nguoi_ky4
        Me.Tieu_de_noi_ky.Text = Tieu_de_noi_ky
        Me.Tieu_de_ngay_ky.Text = GetReportDate()
    End Sub
    Public Sub setupDynamicControls(ByVal mdv As DataView)
        dv = mdv
        Dim numCol As Integer = dv.Count - 1
        Dim childWidth As Double = tbDynamic.WidthF / (numCol + 1)
        Dim childHeight As Double = 120
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv(i).Row("Ten_mon") & vbCrLf & " (" & dv(i).Row("So_hoc_trinh") & ")"
            lb.WidthF = childWidth
            lb.HeightF = childHeight
            lb.Borders = CType(DevExpress.XtraPrinting.BorderSide.Right, DevExpress.XtraPrinting.BorderSide)
            Dim p As New Point(i * childWidth, 23)
            lb.LocationF = p
            tbDynamic.Controls.Add(lb)
        Next
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = 16
            lb1.Borders = CType(DevExpress.XtraPrinting.BorderSide.Right, DevExpress.XtraPrinting.BorderSide)
            lb1.Font = New System.Drawing.Font("Times New Roman", 8.0!)
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            Kiem_tra_list.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "M" & dv(j).Row("ID_mon"))
        Next
    End Sub
    Public Sub binding()

        Ten_he.DataBindings.Add("Text", DataSource, "Ten_he")
        Chuyen_nganh.DataBindings.Add("Text", DataSource, "Chuyen_nganh")
        Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Tong_hoc_trinh.DataBindings.Add("Text", DataSource, "Tong_so_hoc_trinh")
        Hoc_ky.DataBindings.Add("Text", DataSource, "Hoc_ky")
        Nam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc")

        Tong9.DataBindings.Add("Text", DataSource, "Tong9")
        Tong98.DataBindings.Add("Text", DataSource, "Tong98")
        Tong87.DataBindings.Add("Text", DataSource, "Tong87")
        Tong76.DataBindings.Add("Text", DataSource, "Tong76")
        Tong65.DataBindings.Add("Text", DataSource, "Tong65")
        Tong5.DataBindings.Add("Text", DataSource, "Tong5")

        Ty_le9.DataBindings.Add("Text", DataSource, "Ty_le9")
        Ty_le98.DataBindings.Add("Text", DataSource, "Ty_le98")
        Ty_le87.DataBindings.Add("Text", DataSource, "Ty_le87")
        Ty_le76.DataBindings.Add("Text", DataSource, "Ty_le76")
        Ty_le65.DataBindings.Add("Text", DataSource, "Ty_le65")
        Ty_le5.DataBindings.Add("Text", DataSource, "Ty_le5")


        Ma_sinh_vien.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ten_sinh_vien.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        TBCHT.DataBindings.Add("Text", DataSource, "TBCHT")
        Ghi_chu.DataBindings.Add("Text", DataSource, "Ghi_chu")
    End Sub

    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        STT.Text = count
    End Sub


End Class