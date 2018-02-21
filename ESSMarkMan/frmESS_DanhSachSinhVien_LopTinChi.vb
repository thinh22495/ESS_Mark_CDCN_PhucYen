Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_DanhSachSinhVien_LopTinChi
    Private Loader As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mLan_thi As Integer = 1
    Private mID_mon_tc As Integer = 0
    Private mID_lop_tc As Integer = 0
    Private mID_mon As Integer = 0
    Private mTen_mon As String = ""
    Private mSo_tc As Integer = 0
    Private mTen_lop_tc As String = ""
    Private mPhong_hoc As String = ""
    Private clsDiem As New Diem_Bussines
    Private clsLopTC As DanhSachLopTinChi_Bussines

#Region "Form Events"
    Private Sub frmESS_DanhSachSinhVienLopTinChi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub

    Private Sub frmESS_DanhSachSinhVienLopTinChi_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub trvLopTinChi_Select() Handles trvLopTinChi.TreeNodeSelected_
        Me.Cursor = Cursors.WaitCursor
        Try
            mHoc_ky = trvLopTinChi.Hoc_ky
            mNam_hoc = trvLopTinChi.Nam_hoc
            mID_mon_tc = trvLopTinChi.ID_mon_tc
            mID_lop_tc = trvLopTinChi.ID_lop_tc
            mTen_mon = trvLopTinChi.Ten_mon
            mTen_lop_tc = trvLopTinChi.Ten_lop_tc
            mSo_tc = trvLopTinChi.So_hoc_trinh
            mPhong_hoc = trvLopTinChi.Phong_hoc
            If mID_mon_tc > 0 Then
                Dim ID_dv As String = gobjUser.ID_dv
                Dim dsID_lop As String = ""
                Dim dtDanhSachSinhVien As DataTable
                'clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc)
                clsLopTC = New DanhSachLopTinChi_Bussines(mID_mon_tc, mID_lop_tc, gobjUser.UserName, gobjUser.ID_phong)
                dtDanhSachSinhVien = clsLopTC.Danh_sach_sinh_vien

                grcDanhSach.DataSource = dtDanhSachSinhVien.DefaultView
            End If
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



    Private Sub cmdPrint_DanhSach_ItemClick(ByVal sender As System.Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DanhSach.ItemClick
        Try
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                If objBaoCaoTieuDe.Count > 0 Then
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                Else
                    dt.Rows(0).Item("Tieu_de_ten_bo") = ""
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = ""
                End If

                If mID_lop_tc > 0 Then
                    dt.Rows(0).Item("Tieu_de") = "LỚP TÍN CHỈ: " & trvLopTinChi.Ten_lop_tc.ToUpper
                Else
                    dt.Rows(0).Item("Tieu_de") = "Học phần TÍN CHỈ: " & trvLopTinChi.Ten_mon.ToUpper
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("DS sinhvien LopTC", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_DSDiemDanh_ItemDoubleClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles cmdPrint_DSDiemDanh.ItemDoubleClick
        Try
            Dim dv As DataView = grvDanhSach.DataSource
            If dv.Count > 0 Then
                Dim dt As DataTable = dv.Table.Copy
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de1")
                dt.Columns.Add("Tieu_de2")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                If objBaoCaoTieuDe.Count > 0 Then
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                Else
                    dt.Rows(0).Item("Tieu_de_ten_bo") = ""
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = ""
                End If
                If mID_lop_tc > 0 Then
                    dt.Rows(0).Item("Tieu_de1") = "DANH SÁCH ĐIỂM DANH LỚP TÍN CHỈ: " & trvLopTinChi.Ten_lop_tc.ToUpper
                Else
                    dt.Rows(0).Item("Tieu_de2") = "Học phần TÍN CHỈ: " & trvLopTinChi.Ten_mon.ToUpper
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("rpDanhSachDiemDanhLopTC", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grvDanhSach.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim titles As New ArrayList
                Dim title As New XlsCommon("B1", "F1", "DANH SÁCH SINH VIÊN LỚP TÍN CHỈ", New Font("Arial", 14, FontStyle.Regular), Color.Black)
                titles.Add(title)
                Dim title1 As New XlsCommon("B2", "F2", "TÊN Học phần :" & mTen_mon, New Font("Arial", 12, FontStyle.Regular), Color.Black)
                titles.Add(title1)
                Dim title2 As New XlsCommon("B3", "F3", "Tên Lớp tín chỉ :" & trvLopTinChi.Ten_lop_tc, New Font("Arial", 12, FontStyle.Regular), Color.Black)
                titles.Add(title2)
                clsExcel.ExportFromDevGridViewToExcel(grvDanhSach, titles, 4)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

#End Region




End Class