Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_frmESS_KhungChuongTrinhDaoTao_ThietLapMonChungChi
    Private mID_dt As Integer
    Private mID_chung_chi As Integer
    Private mID_mon As Integer
    Private mLoader As Boolean = False
    Dim dtMonChungChi As DataTable
    Private mcls As New LoaiChungChiDanhSachMon_Bussines

    Public Overloads Sub ShowDialog(ByVal ID_dt As Integer)
        mID_dt = ID_dt
        Me.ShowDialog()
    End Sub
    Private Sub frmESS_ThietLapMonChungChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ShowGridView()
        mLoader = True
    End Sub


    Private Sub ShowGridView()
        dtMonChungChi = mcls.HienThi_ESSLoaiChungChiDanhSachMon(mID_dt)
        If dtMonChungChi.Rows.Count = 0 Then Exit Sub
        Dim para(2) As String
        para(0) = "ID_chung_chi"
        para(1) = "Ky_hieu_cc"
        para(2) = "Loai_chung_chi"
        Dim dtLoaiChungChi As DataTable = SelectDistinct(dtMonChungChi, para)
        grcLoaiChungChi.DataSource = dtLoaiChungChi.DefaultView
        ShowGridViewMonChungChi()
    End Sub
    Private Sub ShowGridViewMonChungChi()
        If CheckSelectedGridViewLoaiChungChi() Then
            Dim dv As DataView = dtMonChungChi.DefaultView
            dv.RowFilter = "ID_chung_chi=" & mID_chung_chi
            grcMonChungChi.DataSource = dv
        End If
    End Sub
    Private Function CheckSelectedGridViewLoaiChungChi() As Boolean
        Dim rowCurr As DataRow = grvLoaiChungChi.GetDataRow(grvLoaiChungChi.GetSelectedRows.GetValue(0))

        If Not rowCurr Is Nothing Then
            mID_chung_chi = rowCurr("ID_chung_chi")
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function


    Private Function CheckSelectedGridViewMonChungChi() As Boolean

        Dim rowCurr As DataRow = grvMonChungChi.GetDataRow(grvMonChungChi.GetSelectedRows.GetValue(0))
        If Not rowCurr Is Nothing Then
            mID_mon = rowCurr("ID_mon")
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function


    Private Sub cmdChonMon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChonMon.Click
        Dim frmESS_ As New frmESS_ChonHocPhanChungChi
        frmESS_.ID_dt = mID_dt
        frmESS_.ShowDialog()
        If frmESS_.Thoat = False Then
            mID_chung_chi = frmESS_.ID_chung_chi
            For i As Integer = 0 To frmESS_.MonHoc.Count - 1
                mcls.ThemMoi_ESSLoaiChungChiDanhSachMon(mID_chung_chi, CType(frmESS_.MonHoc(i), ESSMonHoc).ID_mon, mID_dt)
            Next
            ShowGridView()
        End If
    End Sub

    Private Sub cmdHuyMon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHuyMon.Click
        If CheckSelectedGridViewMonChungChi() Then
            mcls.Xoa_ESSLoaiChungChiDanhSachMon(mID_chung_chi, mID_mon, mID_dt)
            ShowGridView()
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub grvLoaiChungChi_SelectionChanged(ByVal sender As System.Object, ByVal e As DevExpress.Data.SelectionChangedEventArgs) Handles grvLoaiChungChi.SelectionChanged
        If mLoader Then
            ShowGridViewMonChungChi()
        End If
    End Sub
End Class