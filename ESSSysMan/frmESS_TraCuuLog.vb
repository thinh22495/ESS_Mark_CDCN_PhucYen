Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Imports ESSUtility

Public Class frmESS_TraCuuLog
#Region "Var"
    Private ClsSuKienNguoiDung As New SuKienNguoiDung_Bussines()
    Private Loaded As Boolean = False
#End Region
#Region "Form Events"
    Private Sub frmESS_TraCuuLog_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_TraCuuLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdSuKienNguoiDung)
        HienThi_ESSdata()
        Loaded = True
    End Sub
    Private Sub frmESS_TraCuuLog_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region "Control Events"

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If Check_values() = False Then Exit Sub
            Dim Tu_ngay, Den_ngay As Object
            Dim obj As New ESSSuKienNguoiDung
            If Me.cmbPhan_he.Text = "" Then
                obj.ID_phan_he = -1
            Else
                obj.ID_phan_he = Me.cmbPhan_he.SelectedValue
            End If

            If Me.cmbSu_kien.Text = "" Then
                obj.Su_kien = -1
            Else
                obj.Su_kien = Me.cmbSu_kien.SelectedIndex
            End If
            If Me.txtChuc_nang.Text.Trim = "" Then
                obj.Chuc_nang = ""
            Else
                obj.Chuc_nang = txtChuc_nang.Text.Trim
            End If
            If Me.txtMay_tram.Text.Trim = "" Then
                obj.May_tram = ""
            Else
                obj.May_tram = txtMay_tram.Text.Trim
            End If
            If Me.txtNoi_dung.Text.Trim = "" Then
                obj.Noi_dung = ""
            Else
                obj.Noi_dung = txtNoi_dung.Text.Trim
            End If
            If Me.txtUser.Text.Trim = "" Then
                obj.UserName = ""
            Else
                obj.UserName = txtUser.Text.Trim
            End If
            If Me.dtpTu_ngay.Checked = False Then
                Tu_ngay = ""
            Else
                'Tu_ngay = dtpTu_ngay.Text
                Tu_ngay = dtpTu_ngay.Value.ToString("MM/dd/yyyy")
            End If
            If Me.dtpDen_ngay.Checked = False Then
                Den_ngay = ""
            Else
                'Den_ngay = dtpDen_ngay.Text
                Den_ngay = dtpDen_ngay.Value.ToString("MM/dd/yyyy")
            End If
            Me.grdSuKienNguoiDung.DataSource = ClsSuKienNguoiDung.HienThi_ESSSuKienNguoiDung_DanhSach(obj, Tu_ngay, Den_ngay)
        Catch ex As Exception
            Throw (ex)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "User Functions"
    Private Sub HienThi_ESSdata()
        FillCombo(Me.cmbPhan_he, ClsSuKienNguoiDung.Danh_sach_phan_he())
    End Sub

    Private Function Check_values() As Boolean
        Try
            If Me.dtpTu_ngay.Checked And Me.dtpDen_ngay.Checked Then
                If Me.dtpDen_ngay.Value < Me.dtpTu_ngay.Value Then
                    Thongbao("Bạn phải chon đến ngày lớn hơn từ ngày !", MsgBoxStyle.Information)
                    Return False
                End If
            End If
            If Check_text() = False Then
                Thongbao("Bạn cần nhập ít nhất một thông số để tìm kiếm !", MsgBoxStyle.Information)
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
    ''Kiểm tra xem là đã nhập its nhất một thông tin chưa?
    Private Function Check_text() As Boolean
        Try
            Dim i As Integer = 0
            If Me.cmbPhan_he.Text.Trim = "" Then
                i += 1
            End If
            If Me.cmbSu_kien.Text.Trim = "" Then
                i += 1
            End If
            If Me.txtChuc_nang.Text.Trim = "" Then
                i += 1
            End If
            If Me.txtMay_tram.Text.Trim = "" Then
                i += 1
            End If
            If Me.txtNoi_dung.Text.Trim = "" Then
                i += 1
            End If
            If Me.txtUser.Text.Trim = "" Then
                i += 1
            End If
            If Me.dtpTu_ngay.Checked = False Then
                i += 1
            End If
            If Me.dtpDen_ngay.Checked = False Then
                i += 1
            End If
            If i = 8 Then
                Return False
            End If
            Return True
        Catch ex As Exception
            Throw (ex)
        End Try
    End Function
#End Region

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdSuKienNguoiDung.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDataGridViewToExcel(grdSuKienNguoiDung)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class