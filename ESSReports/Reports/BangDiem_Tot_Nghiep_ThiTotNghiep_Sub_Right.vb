Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class BangDiem_Tot_Nghiep_ThiTotNghiep_Sub_Right
    Public mID_sv As Integer
    Dim dt As DataTable
    Dim stt As Integer
    Public Sub binding()
        Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Diem10.DataBindings.Add("Text", DataSource, "TBCMH")
        DiemChu.DataBindings.Add("Text", DataSource, "Diem_chu")
        So_thu_tu.DataBindings.Add("Text", DataSource, "STT")
    End Sub

End Class