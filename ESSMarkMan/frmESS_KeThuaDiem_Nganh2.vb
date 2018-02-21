Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_KeThuaDiem_Nganh2
    Private Loader As Boolean = False
    Private dsID_lop As String = "0"
    Private mID_dt As Integer = 0
    Private clsCTDT2 As New DanhSachNganh2_Bussines()

#Region "Form Events"
    Private Sub frmESS_KeThuaDiem_Nganh2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Loader = True
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVien_HocNganh2(0)
            grcDanhSach.DataSource = dt.DefaultView
            Me.TreeViewChuyenNganh_Nganh21.HienThi_ESSTreeView()
            SetQuyenTruyCap(, cmdKeThua_Nganh1, cmdKeThuaDiem_HP_TuongDuong, )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_KeThuaDiem_Nganh2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub TreeViewChuyenNganh_Nganh21op_Select() Handles TreeViewChuyenNganh_Nganh21.TreeNodeSelected_
        Try
            If Loader Then
                If TreeViewChuyenNganh_Nganh21.ID_chuyen_nganh > 0 Then
                    mID_dt = TreeViewChuyenNganh_Nganh21.ID_dt
                    Dim dt As DataTable = clsCTDT2.DanhSachSinhVien_HocNganh2(mID_dt)
                    grcDanhSach.DataSource = dt.DefaultView
                    lblSo_Sv.Text = "Số sinh viên: " & dt.Rows.Count
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub grvDanhSach_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grvDanhSach.SelectionChanged
        Try
            If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
                Dim mclsHocNganh2 As New DanhSachNganh2_Bussines(gobjUser.ID_dv, grvDanhSach.GetFocusedDataRow()("ID_sv"), grvDanhSach.GetFocusedDataRow()("ID_dt2"))
                Dim dt As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2DaChon()
                grcHocPhan.DataSource = dt.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdKeThua_Nganh1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeThua_Nganh1.Click
        Try
            If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
                Dim mID_dt1 As Integer = grvDanhSach.GetFocusedDataRow()("ID_dt1")
                Dim mID_dt2 As Integer = grvDanhSach.GetFocusedDataRow()("ID_dt2")
                Dim mID_sv As Integer = grvDanhSach.GetFocusedDataRow()("ID_sv")

                Dim frmESS_ As New frmESS_KeThuaDiem_DiemNganh1View
                frmESS_.ShowDialog(mID_dt1, mID_dt2, mID_sv)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdKeThuaDiem_HP_TuongDuong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeThuaDiem_HP_TuongDuong.Click
        Try
            If Not grvDanhSach.GetFocusedDataRow Is Nothing Then
                Dim mID_dt1 As Integer = grvDanhSach.GetFocusedDataRow()("ID_dt1")
                Dim mID_dt2 As Integer = grvDanhSach.GetFocusedDataRow()("ID_dt2")
                Dim mID_sv As Integer = grvDanhSach.GetFocusedDataRow()("ID_sv")

                Dim frmESS_ As New frmESS_KeThuaDiem_DiemNganh1_HPTuongDuongView
                frmESS_.ShowDialog(mID_dt1, mID_dt2, mID_sv)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class