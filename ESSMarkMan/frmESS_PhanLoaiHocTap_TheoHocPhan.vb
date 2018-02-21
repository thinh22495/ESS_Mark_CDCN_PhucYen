Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Imports C1
Imports C1.Win.C1FlexGrid

Public Class frmESS_PhanLoaiHocTap_TheoHocPhan
    Private mdt As DataTable
    Private mHocKy_NamHoc As String = ""
    Private clsDiem As New Diem_Bussines

    Public Overloads Sub ShowDialog(ByVal dt As DataTable, ByVal HocKy_NamHoc As String)
        mdt = dt
        mHocKy_NamHoc = HocKy_NamHoc
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_PhanLoaiHocTap_mon_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            fgTongHopKy.DataSource = mdt
            FormatFlexgrid(fgTongHopKy)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_PhanLoaiHocTap_mon_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub Format_fix_region(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        fg.Styles.Fixed.BackColor = System.Drawing.Color.DarkSeaGreen
        fg.Styles.Fixed.Font = New Font("Arial", 10, FontStyle.Bold)
        fg.Styles.Fixed.TextAlign = TextAlignEnum.CenterCenter
    End Sub
    Private Sub FormatFlexgrid(ByVal fg As C1.Win.C1FlexGrid.C1FlexGrid)
        Format_fix_region(fg)
        fg.Rows.Fixed = 2

        fg.Rows(0).AllowMerging = True
        fg.Cols(0).AllowMerging = True
        fg.Cols(2).AllowMerging = True
        fg.Cols(3).AllowMerging = True
        fg.AllowMerging = AllowMergingEnum.FixedOnly

        fg.Cols(0).Width = 30
        fg.Cols(1).Width = 0
        fg.Cols(2).Width = 250
        fg.Cols(3).Width = 60
        fg(0, 0) = "STT"
        fg(1, 0) = "STT"
        fg(0, 2) = "Tên học phần"
        fg(1, 2) = "Tên học phần"
        fg(0, 3) = "Tổng số"
        fg(1, 3) = "Tổng số"

        fg.Cols(2).TextAlign = TextAlignEnum.LeftCenter
        fg.Cols(3).TextAlign = TextAlignEnum.CenterCenter

        Dim dt As DataTable
        Dim cls As New PhanLoaiKetQuaHocTap_Bussines
        dt = cls.HienThi_ESSQuyDoiDiem
        For i As Integer = 0 To dt.Rows.Count - 1
            If dt.Rows(i).Item("Xep_loai").ToString <> "" Then
                fg.Cols("SL" + dt.Rows(i)("ID_xep_loai").ToString).Width = 50
                fg.Cols("PT" + dt.Rows(i)("ID_xep_loai").ToString).Width = 50

                fg.Cols("SL" + dt.Rows(i)("ID_xep_loai").ToString).TextAlign = TextAlignEnum.CenterCenter
                fg.Cols("PT" + dt.Rows(i)("ID_xep_loai").ToString).TextAlign = TextAlignEnum.CenterCenter

                fg(0, "SL" + dt.Rows(i)("ID_xep_loai").ToString) = dt.Rows(i)("Xep_loai").ToString
                fg(1, "SL" + dt.Rows(i)("ID_xep_loai").ToString) = "SL"

                fg(0, "PT" + dt.Rows(i)("ID_xep_loai").ToString) = dt.Rows(i)("Xep_loai").ToString
                fg(1, "PT" + dt.Rows(i)("ID_xep_loai").ToString) = "%"
            End If
        Next
        'Gán STT
        For i As Integer = 2 To fg.Rows.Count - 1
            fg(i, 0) = i - 1
        Next
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            If Not fgTongHopKy.DataSource Is Nothing Then
                Dim clsExcel As New ExportCommon
                Dim Tieu_de As String = ""
                clsExcel.ExportFromC1flexgridToExcel(fgTongHopKy)
            Else
                Thongbao("Bạn phải tổng hợp dữ liệu điểm trước")
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim dt As DataTable = fgTongHopKy.DataSource
            Dim dtMain As DataTable = dt.Copy
            If dtMain.Rows.Count > 0 Then
                dtMain.Columns.Add("Tieu_de_ten_bo")
                dtMain.Columns.Add("Tieu_de_Ten_truong")
                dtMain.Columns.Add("Tieu_de1")
                dtMain.Columns.Add("Tieu_de2")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines(gobjUser.ID_dv, gobjUser.UserID)

                For i As Integer = 0 To dtMain.Rows.Count - 1
                    If objBaoCaoTieuDe.Count > 0 Then
                        dtMain.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dtMain.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    Else
                        dtMain.Rows(i).Item("Tieu_de_ten_bo") = ""
                        dtMain.Rows(i).Item("Tieu_de_Ten_truong") = ""
                    End If

                    dtMain.Rows(i).Item("Tieu_de1") = lbl.Text
                    dtMain.Rows(i).Item("Tieu_de2") = mHocKy_NamHoc
                Next

                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("PHANLOAI_KQHT_MON", dtMain)
            End If
        Catch ex As Exception
        End Try
        Me.Cursor = Cursors.Default
    End Sub
End Class