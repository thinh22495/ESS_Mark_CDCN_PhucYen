Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSConnect
Public Class frmTongHopThuKhac
    Private loader As Boolean = False
    Private mdv As DataView ' dv Tong hop
#Region "Form Event"
    Private Sub frmTongHopThuKhac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào TreeView, mặc định ban đầu là Lớp hành chính
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdDanhSach)
        SetUpDataGridView(grdDanhSach_View)
        loader = True
    End Sub
    Private Sub frmTongHopThuKhac_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmTongHopThuKhac_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#End Region
    Private Sub btnThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnThoat.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            grdDanhSach_View.Visible = True
            grdDanhSach.Visible = False
            Dim cls As New DanhSachSinhVien_Bussines(trvLop.ID_lop_list)
            Dim dtSv As DataTable = cls.Danh_sach_sinh_vien_TongHop_HocPhi
            dtSv.Columns.Add("So_tien", GetType(Integer))
            Dim clsBienLai As New BienLaiThu_Bussines
            Me.ProgressBar.Visible = True
            ProgressBar.Minimum = 0
            ProgressBar.Maximum = dtSv.Rows.Count - 1
            ProgressBar.Step = 1
            ProgressBar.Value = 0

            For i As Integer = dtSv.Rows.Count - 1 To 0 Step -1
                ProgressBar.Value = i
                'For i As Integer = 1 To 0 Step -1
                dtSv.Rows(i)("So_tien") = clsBienLai.TongHopHocPhiSinhVien_SoDuCuoiKy(dtSv.Rows(i)("ID_SV"))
                If dtSv.Rows(i)("So_tien").ToString = "" Or dtSv.Rows(i)("So_tien").ToString = 0 Then
                    dtSv.Rows(i).Delete()
                    dtSv.AcceptChanges()
                Else
                    If dtSv.Rows(i)("So_tien") < 0 Then
                        dtSv.Rows(i)("Tien_Thieu") = 0 - dtSv.Rows(i)("So_tien")
                    Else
                        dtSv.Rows(i)("Tien_Thua") = dtSv.Rows(i)("So_tien")
                    End If
                End If
            Next
            lblSo_SV.Text = dtSv.Rows.Count
            dtSv.DefaultView.Sort = "Ten_lop,Ma_sv"
            grdDanhSach_View.DataSource = dtSv.DefaultView
            Me.ProgressBar.Visible = False
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdIn_No_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIn_No_HP.Click
        Try
            Dim Tieu_de1, Tieu_de2 As String
            Me.Cursor = Cursors.WaitCursor

            Dim dv As DataView = grdDanhSach_View.DataSource
            Tieu_de1 = "DANH SÁCH SINH VIÊN THỪA HOẶC THIẾU TIỀN HỌC PHÍ"
            Tieu_de2 = trvLop.Tieu_de_Lop.ToUpper
            Dim Tien_Thua As Integer = 0
            Dim Tien_Thieu As Integer = 0
            For i As Integer = 0 To dv.Count - 1
                Tien_Thieu = Tien_Thieu + dv.Item(i)("Tien_thieu")
                Tien_Thua = Tien_Thua + dv.Item(i)("Tien_thua")
            Next
            Dim frm As New rptThongKeHocPhi(dv, Tien_Thua, Tien_Thieu, Tieu_de1, Tieu_de2)
            PrintXtraReport(frm)
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_TongHop_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_TongHop_HP.Click
        Try
            Dim frm As New frmTongHop_No_HP_HeKhoaKhoaHoc
            frm.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnView_TT_HP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnView_TT_HP.Click
        Try
            If trvLop.ID_he > 0 Then
                Dim frm As New frmESS_BienLaiThuHocPhiHocPhan
                frm.ShowDialog(1, "2009-2010", 1, 1)
            Else
                Thongbao("Bạn phải chọn hệ đào tạo")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class