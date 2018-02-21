Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility
Public Class frmESS_ChuyenDiemNganh1SangNganh2
    Private Loader As Boolean = False
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private clsCTDT2 As DanhSachNganh2_Bussines


#Region "Form Events"
    Private Sub frmESS_ChuyenDiemNganh1SangNganh2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            SetUpDataGridView(grdViewDanhsachMon)
            SetUpDataGridView(grdViewHocChuongTrinh2)
            Dim clsDM As New DanhMuc_Bussines
            FillCombo(cmbID_nganh, clsDM.DanhMuc_Load("STU_Nganh", "ID_nganh", "Ten_nganh"))
            Loader = True

            clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2_ChuyenDiem
            grdViewHocChuongTrinh2.DataSource = dt.DefaultView
            SetQuyenTruyCap(, cmdKeThuaDiem, , )
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_ChuyenDiemNganh1SangNganh2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"
    Private Sub cmdKeThuaDiem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdKeThuaDiem.Click
        Try
            Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
            If dv.Count > 0 Then
                Dim mID_dt1 As Integer = dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index).Item("ID_dt")
                Dim mID_dt2 As Integer = dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index).Item("ID_dt2")
                Dim mID_sv As Integer = dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index).Item("ID_sv")

                Dim frmESS_ As New frmESS_DiemNganh1View
                frmESS_.ShowDialog(mID_dt1, mID_dt2, mID_sv)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExcel.Click
        Me.Cursor = Cursors.WaitCursor
        Try
            Dim clsExcel As New ExportCommon
            Dim Tieu_de As String = "DANH SÁCH CÁC Học phần CHUYỂN ĐIỂM TỪ NGÀNH CHÍNH SANG NGÀNH 2 CỦA SINH VIÊN: "
            clsExcel.ExportFromDataGridViewToExcel(grdViewDanhsachMon, Nothing)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged
        Try
            If Loader Then
                clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
                Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2_ChuyenDiem
                grdViewHocChuongTrinh2.DataSource = dt.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nganh.SelectedIndexChanged
        Try
            Dim clsDM As New DanhMuc_Bussines
            FillCombo(cmbID_chuyen_nganh, clsDM.DanhMuc_Load("STU_ChuyenNganh", "ID_chuyen_nganh", "Chuyen_nganh", "ID_nganh", cmbID_nganh.SelectedValue))

            clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2_ChuyenDiem
            grdViewHocChuongTrinh2.DataSource = dt.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region


    Private Sub grdViewHocChuongTrinh2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewHocChuongTrinh2.Click, grdViewHocChuongTrinh2.CurrentCellChanged
        Try
            Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
            If dv.Count > 0 AndAlso Not grdViewHocChuongTrinh2.CurrentRow Is Nothing Then
                Dim mclsHocNganh2 As New DanhSachNganh2_Bussines(gobjUser.ID_dv, dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index).Item("ID_sv"), dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index).Item("ID_dt2"))
                Dim dt As DataTable = mclsHocNganh2.DanhSachMonSinhVienNganh1TrungNganh2DaChon()
                grdViewDanhsachMon.DataSource = dt.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Try
            Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
            If dv.Count > 0 Then
                Dim Ho_Ten As String = dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index)("Ho_ten").ToString
                Dim dv2 As DataView = grdViewDanhsachMon.DataSource
                If dv2.Count > 0 Then
                    Dim dt As DataTable = dv2.Table.Copy
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
                    dt.Rows(0).Item("Tieu_de") = "SINH VIÊN: " & Ho_Ten.ToUpper

                    Dim frmESS_ As New frmESS_XemBaoCao
                    frmESS_.ShowDialog_RFix("DSMon NganhChinh ChuyenNganh2", dt)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class