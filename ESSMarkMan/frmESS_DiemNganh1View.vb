Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_DiemNganh1View
    Private mclsDiem As Diem_Bussines
    Private mclsHocNganh2 As DanhSachNganh2_Bussines
    Private mID_dt1 As Integer = 0
    Private mID_dt2 As Integer = 0
    Private mID_sv As Integer = 0

#Region "Form Events"
    Public Overloads Sub ShowDialog(ByVal ID_dt1 As Integer, ByVal ID_dt2 As Integer, ByVal ID_sv As Integer)
        Try
            SetUpDataGridView(grdViewMonTrung)
            SetUpDataGridView(grdViewMonChon)
            mID_sv = ID_sv
            mID_dt2 = ID_dt2
            mID_dt1 = ID_dt1
            mclsHocNganh2 = New DanhSachNganh2_Bussines(gobjUser.ID_dv, mID_sv, mID_dt2)
            Dim dt As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2()
            Dim dt_dacapnhat As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2DaChon()

            mclsDiem = New Diem_Bussines(gobjUser.ID_dv, mID_sv, mID_dt1)
            If dt.Rows.Count > 0 Then
                dt = mclsDiem.DiemSinhVienToanKhoa_Nganh1TrungNganh2(mID_sv, dt)
            End If

            grdViewMonTrung.DataSource = dt.DefaultView
            grdViewMonChon.DataSource = dt_dacapnhat.DefaultView
            lblSo_mon.Text = dt_dacapnhat.Rows.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_DiemNganh1View_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_DiemNganh1View_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

#End Region
    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            Dim dv As DataView = grdViewMonTrung.DataSource
            Dim ID_diem As Long = 0
            Dim idx_diem As Integer = -1
            For i As Integer = 0 To dv.Count - 1
                ID_diem = 0
                If dv.Item(i)("Chon") Then
                    Dim objDiem As New ESSDiem
                    idx_diem = dv.Item(i)("idx_diem")
                    objDiem = mclsDiem.ESSDiem(idx_diem)
                    objDiem.ID_dt = mID_dt2
                    'Insert Diem main
                    ID_diem = mclsDiem.ThemMoi_ESSDiem(objDiem)
                    'Insert Diem thi, Diem thanh phan
                    mclsDiem.KeThuaDiemNganh1ChoNganh2(dv.Item(i)("ID_mon"), mID_sv, ID_diem)
                End If
            Next

            mclsHocNganh2 = New DanhSachNganh2_Bussines(gobjUser.ID_dv, mID_sv, mID_dt2)
            Dim dt As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2()
            Dim dt_dacapnhat As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2DaChon()
            If dt.Rows.Count > 0 Then
                mclsDiem = New Diem_Bussines(gobjUser.ID_dv, mID_sv, mID_dt1)
                dt = mclsDiem.DiemSinhVienToanKhoa_Nganh1TrungNganh2(mID_sv, dt)
            End If
            grdViewMonTrung.DataSource = dt.DefaultView
            grdViewMonChon.DataSource = dt_dacapnhat.DefaultView
            lblSo_mon.Text = dt_dacapnhat.Rows.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub btnXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Try
            Dim dv As DataView = grdViewMonChon.DataSource
            'For i As Integer = 0 To dv.Count - 1
            '    If dv.Item(i)("Chon") Then
            '        mclsDiem.Xoa_ESSDiem(dv.Item(i)("ID_diem"))
            '        mclsDiem.XoaDiemKeThuaDiemNganh1ChoNganh2(dv.Item(i)("ID_mon"), mID_sv, dv.Item(i)("ID_diem"), , )
            '    End If
            'Next
            mclsHocNganh2 = New DanhSachNganh2_Bussines(gobjUser.ID_dv, mID_sv, mID_dt2)
            Dim dt As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2()
            Dim dt_dacapnhat As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2DaChon()
            If dt.Rows.Count > 0 Then
                mclsDiem = New Diem_Bussines(gobjUser.ID_dv, mID_sv, mID_dt1)
                dt = mclsDiem.DiemSinhVienToanKhoa_Nganh1TrungNganh2(mID_sv, dt)
            End If
            grdViewMonTrung.DataSource = dt.DefaultView
            grdViewMonChon.DataSource = dt_dacapnhat.DefaultView
            lblSo_mon.Text = dt_dacapnhat.Rows.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class