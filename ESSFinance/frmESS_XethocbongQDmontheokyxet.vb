Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_XethocbongQDmontheokyxet
    Private dsID_lop As String = "0"
    Private mclsDSSV As DanhSachSinhVien_Bussines

#Region "Form Events"
    Private Sub frmESS_XethocbongQDmontheokyxet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdViewDanhSach)
        SetUpDataGridView(grdViewMonDaChon)
        SetQuyenTruyCap(, btnAdd, , btnDel)
    End Sub

    Private Sub frmESS_XethocbongQDmontheokyxet_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub optAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewDanhSach.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll.Checked
            Next
        End If
    End Sub
    Private Sub optAll1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAll1.CheckedChanged
        Dim dvDanhSachSinhVien As DataView
        dvDanhSachSinhVien = grdViewMonDaChon.DataSource
        If Not dvDanhSachSinhVien Is Nothing Then
            For i As Integer = 0 To dvDanhSachSinhVien.Count - 1
                dvDanhSachSinhVien.Item(i)("Chon") = optAll1.Checked
            Next
        End If
    End Sub

    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        Try
            If Not trvLop.ID_lop_list Is Nothing Then
                dsID_lop = trvLop.ID_lop_list

                'Danh sách sinh viên thực tập
                mclsDSSV = New DanhSachSinhVien_Bussines(dsID_lop)
                Dim dt1, dt2 As DataTable
                dt1 = mclsDSSV.Danh_sach_sinh_vien()
                dt1.DefaultView.RowFilter = "Ngoai_ngan_sach=0"
                grdViewDanhSach.DataSource = dt1.DefaultView

                dt2 = dt1.Copy
                dt2.DefaultView.RowFilter = "1=1"
                dt2.DefaultView.RowFilter = "Ngoai_ngan_sach=1"
                grdViewMonDaChon.DataSource = dt2.DefaultView
                labSoSv_thu.Text = dt2.DefaultView.Count

            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Try
            If grdViewDanhSach.CurrentRow Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDanhSach.DataSource
            Dim dv2 As DataView = grdViewMonDaChon.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") Then
                    mclsDSSV.UpdateNgoaiNganSachArr(dv.Item(i)("ID_SV"), 1)
                End If
            Next

            Dim dt1, dt2 As DataTable
            dt1 = mclsDSSV.Danh_sach_sinh_vien()
            dt1.DefaultView.RowFilter = "Ngoai_ngan_sach=0"
            grdViewDanhSach.DataSource = dt1.DefaultView

            dt2 = dt1.Copy
            dt2.DefaultView.RowFilter = "1=1"
            dt2.DefaultView.RowFilter = "Ngoai_ngan_sach=1"
            grdViewMonDaChon.DataSource = dt2.DefaultView
            labSoSv_thu.Text = dt2.DefaultView.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Try
            If grdViewDanhSach.CurrentRow Is Nothing Then Exit Sub
            Dim dv As DataView = grdViewDanhSach.DataSource
            Dim dv2 As DataView = grdViewMonDaChon.DataSource
            For i As Integer = 0 To dv2.Count - 1
                If dv2.Item(i)("Chon") Then
                    mclsDSSV.UpdateNgoaiNganSachArr(dv2.Item(i)("ID_SV"), 0)
                End If
            Next

            Dim dt1, dt2 As DataTable
            dt1 = mclsDSSV.Danh_sach_sinh_vien()
            dt1.DefaultView.RowFilter = "Ngoai_ngan_sach=0"
            grdViewDanhSach.DataSource = dt1.DefaultView

            dt2 = dt1.Copy
            dt2.DefaultView.RowFilter = "1=1"
            dt2.DefaultView.RowFilter = "Ngoai_ngan_sach=1"
            grdViewMonDaChon.DataSource = dt2.DefaultView
            labSoSv_thu.Text = dt2.DefaultView.Count
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not grdViewMonDaChon.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromDataGridViewToExcel(grdViewMonDaChon)
            Else
                Thongbao("Chưa có dữ liệu !")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dv1 As DataView = grdViewMonDaChon.DataSource
            Dim dt As New DataTable
            If dv1.Count > 0 Then
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                dt.Columns.Add("Tieu_de")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                Dim Tieu_de As String = ""
                If trvLop.Tieu_de_Lop <> "" Then 'La Lop
                    Tieu_de = trvLop.Tieu_de_Lop.ToUpper
                Else
                    Tieu_de = trvLop.Tieu_de
                End If

                Dim dr As DataRow
                For i As Integer = 0 To dv1.Count - 1
                    dr = dt.NewRow
                    dr("Tieu_de") = Tieu_de
                    dr("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dr("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    dr("Ma_sv") = dv1.Item(i)("Ma_sv")
                    dr("Ho_ten") = dv1.Item(i)("Ho_ten")
                    dr("Ngay_sinh") = dv1.Item(i)("Ngay_sinh")
                    dr("Ten_lop") = dv1.Item(i)("Ten_lop")
                    dt.Rows.Add(dr)
                Next

                Dim frmESS_ As New frmESS_ReportView
                frmESS_.ShowDialog_RFix("DS HeNgoaiNganSach", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub
#End Region
End Class