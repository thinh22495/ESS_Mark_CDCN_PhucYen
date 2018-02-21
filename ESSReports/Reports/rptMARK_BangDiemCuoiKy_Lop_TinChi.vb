Imports DevExpress.XtraReports.UI
Imports ESS.Bussines
Public Class rptMARK_BangDiemCuoiKy_Lop_TinChi
    Dim count As Integer = 0
    Dim dv_TP As DataView
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



    Public Sub binding(ByVal clsDiem As Diem_Bussines)
        Me.Ten_lop.DataBindings.Add("Text", DataSource, "Ten_lop")
        Me.Ten_mon.DataBindings.Add("Text", DataSource, "Ten_mon")
        Me.Ky_hieu.DataBindings.Add("Text", DataSource, "Ky_hieu")
        Me.So_hoc_trinh.DataBindings.Add("Text", DataSource, "So_hoc_trinh")
        Me.Hoc_ky.DataBindings.Add("Text", DataSource, "Hoc_ky")
        Me.Nam_hoc.DataBindings.Add("Text", DataSource, "Nam_hoc")

        Me.Ma_sv.DataBindings.Add("Text", DataSource, "Ma_sv")
        Me.Ho_ten.DataBindings.Add("Text", DataSource, "Ho_ten")
        Me.Ten_lop_HC.DataBindings.Add("Text", DataSource, "Ten_lop_HC")

        Me.So_tiet_nghi_co_phep.DataBindings.Add("Text", DataSource, "So_tiet_nghi_co_phep")
        Me.So_tiet_nghi_khong_phep.DataBindings.Add("Text", DataSource, "So_tiet_nghi_khong_phep")
        'Me.Tong_tiet_nghi.DataBindings.Add("Text", DataSource, "Tong_tiet_nghi")

        Me.Diem_chu.DataBindings.Add("Text", DataSource, "Diem_chu")
        Me.TBCMH.DataBindings.Add("Text", DataSource, "TBCMH")
        Me.Diem_thi.DataBindings.Add("Text", DataSource, "Diem_thi")
        'Dim cc As Boolean = False
        'Dim So_TP As Integer = 0
        'For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
        '    If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
        '        With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)

        '            If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Chuyen_can Then
        '                Me.DiemCC.DataBindings.Add("Text", DataSource, .Ky_hieu)
        '                cc = True
        '            Else
        '                So_TP = So_TP + 1
        '                If So_TP = 1 Then Me.KT1.DataBindings.Add("Text", DataSource, .Ky_hieu)
        '                If So_TP = 2 Then Me.KT2.DataBindings.Add("Text", DataSource, .Ky_hieu)
        '                If So_TP = 3 Then Me.KT3.DataBindings.Add("Text", DataSource, .Ky_hieu)
        '                If So_TP = 4 Then Me.KT4.DataBindings.Add("Text", DataSource, .Ky_hieu)
        '            End If
        '        End With
        '    End If
        'Next
        'If So_TP < 4 Then Me.KT4.DataBindings.Add("Text", DataSource, "TX4")
        'If So_TP < 3 Then Me.KT3.DataBindings.Add("Text", DataSource, "TX3")
        'If So_TP < 2 Then Me.KT2.DataBindings.Add("Text", DataSource, "TX2")
        'If cc = False Then Me.DiemCC.DataBindings.Add("Text", DataSource, "CC")
        'Me.TBCBP.DataBindings.Add("Text", DataSource, "TBCBP")
        Dim cc As Boolean = False
        Dim So_TP As Integer = 0
        For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
            If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                    So_TP = So_TP + 1
                End With
            End If
        Next
        Dim STT As Integer = 0
        Dim width As Double = HeadRow.WidthF
        For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
            If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                    Dim lb1 As New XRLabel()
                    lb1.Text = .Ky_hieu & "(" & .Ty_le & ")"
                    lb1.HeightF = XrTableRow1.HeightF
                    Dim p1 As New Point(STT * width / So_TP, 0)
                    lb1.LocationF = p1
                    lb1.WidthF = width / So_TP
                    lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                    'no border left and right
                    lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
                    HeadRow.Controls.Add(lb1)
                    If STT - 1 = So_TP Then
                        lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
                    End If
                    STT = STT + 1
                End With
            End If
        Next
        'Dim width As Double = HeaderRow.WidthF
        STT = 0
        For i As Integer = 0 To clsDiem.ESSThanhPhanDiem.Count - 1
            If clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i).Checked Then
                With clsDiem.ESSThanhPhanDiem.ESSThanhPhanDiem(i)
                    Dim lb1 As New XRLabel()
                    lb1.HeightF = XrTableRow2.HeightF
                    Dim p1 As New Point(STT * width / So_TP, 0)
                    lb1.LocationF = p1
                    lb1.WidthF = width / So_TP
                    'no border left and right
                    lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Right)), DevExpress.XtraPrinting.BorderSide))
                    If STT - 1 = So_TP Then
                        lb1.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.None)), DevExpress.XtraPrinting.BorderSide))
                    End If
                    ValueRow.Controls.Add(lb1)
                    lb1.DataBindings.Add("Text", DataSource, .Ky_hieu)
                    lb1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
                    STT = STT + 1
                End With
            End If
        Next
        Me.Tong_SV.DataBindings.Add("Text", DataSource, "Tong_SV")
        Me.Tong_SV_DuDKT.DataBindings.Add("Text", DataSource, "Tong_SV_DuDKT")
        Me.Tong_SV_KhongDuDKT.DataBindings.Add("Text", DataSource, "Tong_SV_KhongDuDKT")
    End Sub
    Private Sub Detail_BeforePrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles Detail.BeforePrint
        count = count + 1
        TT.Text = count
    End Sub
End Class
