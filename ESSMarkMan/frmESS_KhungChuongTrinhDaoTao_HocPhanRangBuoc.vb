Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_KhungChuongTrinhDaoTao_HocPhanRangBuoc
    Private mID_dt As Integer
    Private mID_mon As Integer
    Private mdtCTDTChiChiet As DataTable
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines, ByVal ID_dt As Integer)
        mID_dt = ID_dt
        mdtCTDTChiChiet = clsCTDT.DanhSachChuongTrinhDaoTaoChiTiet(mID_dt)
        mdtCTDTChiChiet.DefaultView.Sort = "Ten_mon"
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoRangBuocMonHoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_ChuongTrinhDaoTaoRangBuocMonHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        grcHocPhan.DataSource = mdtCTDTChiChiet.DefaultView

        'Load dữ liệu vào ComboBox
        FillCombo(cmbID_mon, mdtCTDTChiChiet, "ID_mon", "Ten_mon")
        FillCombo(cmbKy_hieu, mdtCTDTChiChiet, "ID_mon", "Ky_hieu")

        'LoadComboBox()
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As New DataTable
        dt = clsDM.DanhMuc_Load("PLAN_LoaiRangBuoc", "Loai_rang_buoc", "Ten_rang_buoc")
        FillCombo(cmbLoai_rang_buoc, dt)
        grcHocPhanRB.DataSource = mclsCTDT.DanhSach_MonRangBuoc(mID_dt).DefaultView
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(, cmdAdd, , cmdRemove)
    End Sub

    Private Sub frmESS_ChuongTrinhDaoTaoRangBuocMonHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub



    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            If grvHocPhan.RowCount > 0 Then
                Dim row As DataRow = grvHocPhan.GetDataRow(grvHocPhan.GetSelectedRows.GetValue(0))

                If cmbID_mon.Text.Trim = "" Or cmbLoai_rang_buoc.Text.Trim = "" Then
                    Thongbao("Hãy chọn học phần và loại ràng buộc để thiết lập !", MsgBoxStyle.Information)
                Else
                    Dim ID_mon As Integer = row("ID_mon")
                    Dim Ky_hieu As String = row("Ky_hieu").ToString
                    Dim Ten_mon As String = row("Ten_mon").ToString
                    If ID_mon = cmbID_mon.SelectedValue Then
                        Thongbao("Không được thiết lập ràng buộc với chính học phần này !", MsgBoxStyle.Information)
                    Else
                        mclsCTDT.GanMonRangBuoc(mID_dt, ID_mon, cmbID_mon.SelectedValue, cmbLoai_rang_buoc.SelectedValue, Ky_hieu, Ten_mon, cmbID_mon.Text, cmbLoai_rang_buoc.Text)
                        grcHocPhanRB.DataSource = mclsCTDT.DanhSach_MonRangBuoc(mID_dt).DefaultView
                        'Save Log 
                        Dim Noi_dung As String
                        Dim idx As Integer = mclsCTDT.Tim_idx(mID_dt)
                        If idx >= 0 Then
                            Noi_dung = "Thêm ràng buộc học phần " + Ten_mon
                            Noi_dung += " của chương trình đào tạo"
                            Noi_dung += " Hệ " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_he
                            Noi_dung += " Khoa " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_khoa
                            Noi_dung += " Khoá " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                            Noi_dung += " Chuyên ngành " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Chuyen_nganh
                            SaveLog(LoaiSuKien.Xoa, Noi_dung)
                        End If
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
                Dim ID_mon As Integer = row("ID_mon")
                Dim ID_mon_rb As Integer = row("ID_mon_rb")
                Dim Ten_mon As String = row("Ten_mon1")
                mclsCTDT.XoaMonRangBuoc(mID_dt, ID_mon, ID_mon_rb)
                grcHocPhanRB.DataSource = mclsCTDT.DanhSach_MonRangBuoc(mID_dt).DefaultView
                'Save Log 
                Dim Noi_dung As String
                Dim idx As Integer = mclsCTDT.Tim_idx(mID_dt)
                If idx >= 0 Then
                    Noi_dung = "Xoá ràng buộc học phần " + Ten_mon
                    Noi_dung += " của chương trình đào tạo"
                    Noi_dung += " Hệ " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_he
                    Noi_dung += " Khoa " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Ten_khoa
                    Noi_dung += " Khoá " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Khoa_hoc.ToString
                    Noi_dung += " Chuyên ngành " + mclsCTDT.ESSChuongTrinhDaoTao(idx).Chuyen_nganh
                    SaveLog(LoaiSuKien.Xoa, Noi_dung)
                End If
                Thongbao("Xoá thành công ràng buộc này !", MsgBoxStyle.Information)
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