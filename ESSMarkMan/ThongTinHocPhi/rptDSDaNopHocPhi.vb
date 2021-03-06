Imports DevExpress.XtraReports.UI
Public Class rptDSDaNopHocPhi
    Public Sub New(Optional ByVal dtMain As DataTable = Nothing, Optional ByVal dtSub As DataTable = Nothing, Optional ByVal Tieu_de1 As String = "", Optional ByVal Tieu_de2 As String = "")
        InitializeComponent()
        Tieu_de_bao_cao1.Text = Tieu_de1
        Tieu_de_bao_cao2.Text = Tieu_de2
        Tieu_de_noi_ky.Text = "Hà nội, ngày " & DateTime.Now.Day.ToString() & "/" & DateTime.Now.Month.ToString() & "/" & DateTime.Now.Year
        Tieu_de_nguoi_ky1.Text = gobjUser.FullName

        Dim dv As DataView = dtSub.DefaultView
        Dim numCol As Integer = dv.Count - 1
        Dim childWidth As Double = HeadRow.WidthF / (numCol + 1)
        For i As Integer = 0 To numCol
            Dim lb As New XRLabel()
            lb.Text = dv(i).Row("Ten_thu_chi")
            lb.WidthF = childWidth
            lb.HeightF = XrTableRow1.HeightF
            Dim p As New Point(i * childWidth, 0)
            lb.LocationF = p
            lb.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            'no border left and right
            lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            HeadRow.Controls.Add(lb)
            If i = numCol Then
                lb.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
        Next
        For j As Integer = 0 To numCol
            Dim lb1 As New XRLabel()
            lb1.WidthF = childWidth
            lb1.HeightF = XrTableRow2.HeightF
            Dim p1 As New Point(j * childWidth, 0)
            lb1.LocationF = p1
            'no border left and right
            lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
            If j = numCol Then
                lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
            End If
            ValueRow.Controls.Add(lb1)
            lb1.DataBindings.Add("Text", DataSource, "T" & dv(j).Row("ID_thu_chi"), "{0:###,###}")
            lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Next
        Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Ngay_sinh.DataBindings.Add("Text", DataSource, "Ngay_sinh", "{0:dd/MM/yyyy}")
        Tong.DataBindings.Add("Text", DataSource, "Tong_tien_thu", "{0:###,###}")
    End Sub
    
End Class