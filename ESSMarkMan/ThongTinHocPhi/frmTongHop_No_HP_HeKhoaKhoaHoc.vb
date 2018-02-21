Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Public Class frmTongHop_No_HP_HeKhoaKhoaHoc

    Private Sub frmTongHop_No_HP_HeKhoaKhoaHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dt_he As DataTable = Connect.SelectTable("SELECT ID_he,Ten_he FROM STU_HE")
        FillCombo(cmbID_he, dt_he)
        Dim dt_Khoa_hoc As DataTable = Connect.SelectTable("SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_LOP")
        FillCombo(cmbKhoa_hoc1, dt_Khoa_hoc)
        Dim dt_Khoa As DataTable = Connect.SelectTable("SELECT DISTINCT ID_Khoa,Ten_khoa FROM STU_KHOA")
        FillCombo(cmbID_khoa, dt_Khoa)
    End Sub

    Private Sub frmTongHop_No_HP_HeKhoaKhoaHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmdPrint_TongHop_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_TongHop_HP.Click
        Try
            If cmbID_he.Text = "" Or cmbKhoa_hoc1.Text.Trim = "" Or cmbID_khoa.Text.Trim = "" Then
                Thongbao("Hãy nhập đủ thông tin khi Tổng hợp")
                Exit Sub
            End If
            Me.Cursor = Cursors.WaitCursor
            Dim dt_lop As DataTable = Connect.SelectTable("SELECT ID_LOP,Ten_lop,0 AS Tong_so_sv, 0 AS Tong_so_sv_NoHP,0 AS So_tien_no,0 AS No_HP_BinhQuan,Ho_ten_gv,0 AS Tong_tien FROM STU_LOP WHERE ID_he=" & cmbID_he.SelectedValue & " AND Khoa_hoc=" & cmbKhoa_hoc1.SelectedValue & " AND ID_khoa=" & cmbID_khoa.SelectedValue)
            Dim clsBienLai As New BienLaiThu_Bussines
            Dim Tong_tien As Integer = 0
            For l As Integer = 0 To dt_lop.Rows.Count - 1
                Dim dt As DataTable = Connect.SelectTable("SELECT ID_SV FROM STU_DANHSACH WHERE Trang_thai=0 AND ID_lop=" & dt_lop.Rows(l)("ID_lop"))
                dt_lop.Rows(l)("Tong_so_sv") = dt.Rows.Count
                Dim So_tien_no As Integer = 0
                Dim Tong_so_sv_NoHP As Integer = 0
                Dim So_tien As Integer = 0
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    So_tien = clsBienLai.TongHopHocPhiSinhVien_SoDuCuoiKy(dt.Rows(i)("ID_SV"))
                    If So_tien < 0 Then
                        Tong_tien = Tong_tien - So_tien
                        So_tien_no = So_tien_no - So_tien
                        Tong_so_sv_NoHP = Tong_so_sv_NoHP + 1
                    End If
                Next
                dt_lop.Rows(l)("Tong_so_sv_NoHP") = Tong_so_sv_NoHP
                dt_lop.Rows(l)("So_tien_no") = So_tien_no
                If Tong_so_sv_NoHP > 0 Then dt_lop.Rows(l)("No_HP_BinhQuan") = So_tien_no / Tong_so_sv_NoHP
            Next
            

            Dim Tieu_de1, Tieu_de2 As String

            Tieu_de1 = "DANH SÁCH TỔNG HỢP HỌC PHÍ"
            Tieu_de2 = "HỆ: " & cmbID_he.Text.ToUpper & " - KHÓA HỌC: " & cmbID_khoa.Text.ToUpper & " - KHÓA: " & cmbKhoa_hoc1.Text
            
            Dim frm As New rptThongKeHocPhi_TheoHe_KhoaHoc_Khoa(dt_lop.DefaultView, Tong_tien, Tieu_de1, Tieu_de2)
            PrintXtraReport(frm)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub
End Class