Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_HocPhanTuongDuong
    Private mID_dt As Integer
    Private mID_he As Integer
    Private mdtCTDTChiChiet As DataTable
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines, ByVal ID_dt As Integer, ByVal ID_he As Integer)
        mID_dt = ID_dt
        mID_he = ID_he
        mdtCTDTChiChiet = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt)
        mdtCTDTChiChiet.DefaultView.Sort = "Ten_mon"
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoRangBuocMonHoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_KhungChuongTrinhDaoTao_HocPhanTuongDuong(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grcHocPhan.DataSource = mdtCTDTChiChiet.DefaultView

        'Load dữ liệu vào ComboBox
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable = clsDM.LoadDanhMuc("SELECT ID_mon,Ten_mon FROM MARK_MONHOC WHERE ID_he_dt=" & mID_he & " AND ID_mon   in (SELECT ID_MON FROM PLAN_ChuongTrinhDaoTaoChiTiet WHERE HP_tuong_duong=1 AND ID_dt=" & mID_dt & ") ORDER BY Ten_mon")
        Dim dt2 As DataTable = clsDM.LoadDanhMuc("SELECT ID_mon,Ky_hieu FROM MARK_MONHOC WHERE ID_he_dt=" & mID_he & " AND ID_mon   in (SELECT ID_MON FROM PLAN_ChuongTrinhDaoTaoChiTiet WHERE HP_tuong_duong=1 AND  ID_dt=" & mID_dt & ") ORDER BY Ten_mon")
        FillCombo(cmbID_mon, dt)
        FillCombo(cmbKy_hieu, dt2)

        grcHocPhanRB.DataSource = mclsCTDT.PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(mID_dt).DefaultView
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(, cmdAdd, , cmdRemove)
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoRangBuocMonHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub



    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If cmbID_mon.Text.Trim = "" Then Exit Sub
            If grvHocPhan.RowCount > 0 Then
                Dim row As DataRow = grvHocPhan.GetDataRow(grvHocPhan.GetSelectedRows.GetValue(0))
                If cmbID_mon.Text.Trim = "" Then
                    Thongbao("Hãy chọn học phần để thiết lập !", MsgBoxStyle.Information)
                Else
                    Dim ID_mon As Integer = row("ID_mon")
                    If ID_mon = cmbID_mon.SelectedValue Then
                        Thongbao("Không được thiết lập ràng buộc với chính học phần này !", MsgBoxStyle.Information)
                    Else
                        mclsCTDT.ThemMoi_ESSChuongTrinhDaoTao_MonTuongDuong(mID_dt, row("ID_mon"), cmbID_mon.SelectedValue)
                        grcHocPhanRB.DataSource = mclsCTDT.PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(mID_dt).DefaultView
                    End If
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdRemove_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdRemove.Click
        Try
            If grvHocPhanRB.RowCount > 0 Then
                Dim row As DataRow = grvHocPhanRB.GetDataRow(grvHocPhanRB.GetSelectedRows.GetValue(0))
                Dim ID_tuong_duong As Integer = row("ID_tuong_duong")
                Dim Ten_mon As String = row("Ten_mon1")
                mclsCTDT.Xoa_ESSChuongTrinhDaoTao_MonTuongDuongBuoc(ID_tuong_duong)
                grcHocPhanRB.DataSource = mclsCTDT.PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(mID_dt).DefaultView
                Thongbao("Xoá thành công thuộc tính môn tương đương này !", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView = grvHocPhanRB.DataSource
            Dim dt As DataTable = dv.Table.Copy
            If dt.Rows.Count > 0 Then
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")
                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)
                If objBaoCaoTieuDe.Count > 0 Then
                    dt.Rows(0).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                Else
                    dt.Rows(0).Item("Tieu_de_ten_bo") = ""
                    dt.Rows(0).Item("Tieu_de_Ten_truong") = ""
                End If

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog("RANG BUOC HOC PHAN", dt)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class