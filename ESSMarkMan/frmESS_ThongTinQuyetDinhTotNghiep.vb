Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ThongTinQuyetDinhTotNghiep
    Private mdt_sv As DataTable
    Private QD_ThoiHoc As Boolean = True

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Public Overloads Sub ShowDialog(ByVal dt_danhsach As DataTable, ByVal dt_sv As DataTable)
        Try
            mdt_sv = dt_sv.Copy
            Me.ShowDialog()
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_NoiDungQDTotNghiep_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdPrint_One_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint_One.Click
        For i As Integer = 0 To mdt_sv.Rows.Count - 1
            mdt_sv.Rows(i).Item("So_QD") = txtSo_QD.Text.Trim
            mdt_sv.Rows(i).Item("Bien_ban_hop_ngay") = Format(dtmNgay_hop.Value, "dd/MM/yyyy")
        Next
        Dim frmESS_ As New frmESS_XemBaoCao
        frmESS_.ShowDialog_RFix("QuyetDinh_CongNhan_TotNghiep", mdt_sv)
    End Sub
End Class