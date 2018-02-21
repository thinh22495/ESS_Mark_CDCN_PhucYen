Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmToChucThiPhong_Sua
    Private mID_phong_thi As Integer = 0
    Private Loader As Boolean = False

    Public Overloads Sub ShowDialog(ByVal ID_phong_thi As Integer, ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Gio_thi As String)
        mID_phong_thi = ID_phong_thi
        dtpNgay_thi.Value = Ngay_thi
        cmbNhom_tiet.SelectedValue = Nhom_tiet
        cmbCa.SelectedIndex = Ca_thi
        txtGio_thi.Text = Gio_thi
        Me.ShowDialog()
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If txtGio_thi.Text = "" Or cmbCa.Text = "" Or cmbID_phong.Text = "" Then
            Thongbao("Phải nhập đầy đủ thông tin cho phòng thi !")
            Exit Sub
        End If
        Dim obj As New TochucThi_Bussines()
        obj.CapNhat_ESSToChucThiPhong_ThongTin(mID_phong_thi, cmbNhom_tiet.SelectedIndex, cmbCa.SelectedIndex, txtGio_thi.Text, dtpNgay_thi.Value, cmbID_phong.SelectedValue, cmbID_phong.Text)
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmToChucThiPhong_Sua_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub frmToChucThiPhong_Sua_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT ID_co_so,Ten_co_so FROM PLAN_COSODAOTAO ORDER BY Ten_co_so ")
        FillCombo(cmbID_co_so, dt)
        Loader = True
    End Sub

    Private Sub cmbID_nha_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nha.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbID_nha.Text = "" Or cmbID_co_so.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt_2 As DataTable = clsDM.LoadDanhMuc("SELECT ID_phong,So_phong FROM PLAN_PhongHoc WHERE ID_nha=" & cmbID_nha.SelectedValue & " AND ID_co_so=" & cmbID_co_so.SelectedValue)
            FillCombo(cmbID_phong, dt_2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmbID_co_so_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_co_so.SelectedIndexChanged
        Try
            If Loader = False Then Exit Sub
            If cmbID_co_so.Text = "" Then Exit Sub
            Dim clsDM As New DanhMuc_Bussines
            Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT DISTINCT a.ID_nha,Ten_nha FROM PLAN_PhongHoc a INNER JOIN PLAN_ToaNha b ON a.ID_nha=b.ID_nha WHERE a.ID_co_so=" & cmbID_co_so.SelectedValue & " ORDER BY Ten_nha")
            FillCombo(cmbID_nha, dt)
        Catch ex As Exception
        End Try
    End Sub
End Class