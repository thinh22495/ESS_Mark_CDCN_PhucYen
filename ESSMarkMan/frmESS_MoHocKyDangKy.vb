Imports System.Drawing.Drawing2D
Imports ESS.Bussines

Public Class frmESS_MoHocKyDangKy
    Private Sub LoadComboBox()
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            If cmbID_he.Text.Trim <> "" Then
                strSQL = "SELECT DISTINCT a.Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' AS Ten_dot_dk FROM PLAN_HocKyDangKy_TC a INNER JOIN PLAN_MonTinChi_TC b ON a.Ky_dang_ky=b.Ky_dang_ky " & _
                       "INNER JOIN PLAN_PhamViDangKy_TC c ON b.ID_mon_tc=c.ID_mon_tc " & _
                       "WHERE ID_he=" & cmbID_he.SelectedValue
            Else
                strSQL = "SELECT Ky_dang_ky, N'Đợt '+convert(nvarchar,Dot)+N' (Học kỳ '+ convert(nvarchar,Hoc_ky)+N' năm học ' +Nam_hoc+')' FROM PLAN_HocKyDangKy_TC"
            End If

            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbKy_dang_ky, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_HocKyDangKyOpen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As New DataTable
            Dim strSQL As String
            strSQL = "SELECT ID_he,Ten_he from  STU_He"
            dt = clsDM.DanhMuc_Load(strSQL)
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub frmESS_HocKyDangKyOpen_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = "0"
        Me.Close()
    End Sub
    Private Sub cmdOpen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOpen.Click
        Try
            If cmbKy_dang_ky.SelectedValue > 0 Then
                Me.Tag = "1"
                Me.Close()
            Else
                Thongbao("Bạn hãy chọn học kỳ cần mở ")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public ReadOnly Property Ky_dang_ky() As Integer
        Get
            Return cmbKy_dang_ky.SelectedValue
        End Get
    End Property

    Public ReadOnly Property ID_he() As Integer
        Get
            Return cmbID_he.SelectedValue
        End Get
    End Property

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        LoadComboBox()
    End Sub
End Class