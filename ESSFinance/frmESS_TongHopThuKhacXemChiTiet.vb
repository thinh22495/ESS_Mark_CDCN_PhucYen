Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Public Class frmESS_TongHopThuKhacXemChiTiet
    Private mID_sv As Integer = 0
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mID_thu_chi As Integer = 0
    Private mdsID_lop As String = ""
    Private mToan_khoa As Boolean = False
    Public Sub New(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_thu_chi As Integer, ByVal dsID_lop As String, ByVal Toan_khoa As Boolean)
        mID_sv = ID_sv
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        mID_thu_chi = ID_thu_chi
        mdsID_lop = dsID_lop
        mToan_khoa = Toan_khoa
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub frmESS_TongHopThuKhacXemChiTiet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewBienLai)
        HienThi_ESSData()
    End Sub
    Private Sub frmESS_TongHopThuKhacXemChiTiet_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dt As DataTable
            dt = grdViewBienLai.DataSource.Table
            If dt.Rows.Count = 0 Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim frmESS_ As New frmESS_ReportView
            frmESS_.ShowDialog("RpDanhSachThuKhac_SinhVien", dt, , , , )
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub HienThi_ESSData()
        Try
            Dim clsBienLai As BienLaiThu_Bussines
            If mToan_khoa Then
                clsBienLai = New BienLaiThu_Bussines(0, "", mdsID_lop, mID_thu_chi, 1)
            Else
                clsBienLai = New BienLaiThu_Bussines(mHoc_ky, mNam_hoc, mdsID_lop, mID_thu_chi, 1)
            End If
            Dim dv As DataView
            dv = clsBienLai.DanhSachBienLaiThuHocKy_SinhVien(mID_sv, mHoc_ky, mNam_hoc, mToan_khoa).DefaultView
            dv.Sort = "Nam_hoc"
            grdViewBienLai.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class