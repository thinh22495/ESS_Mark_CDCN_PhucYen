Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DanhSachSinhVien_DangKyNganh2
    Private dsID_lop As String = "0"
    Private dsID_dt As String = "0"
    Private mdtDanhSachSinhVien As New DataTable
    Private clsDiem As New Diem_Bussines
    Dim clsCTDT2 As DanhSachNganh2_Bussines
    Dim clsCTDT As ChuongTrinhDaoTao_Bussines
    Dim ID_sv As String
    Dim ID_he, ID_khoa, Khoa_hoc As Integer
    Dim Loader As Boolean = False

#Region "Form Events"
    Private Sub frmESS_DanhSachSinhVienNganh2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewHocChuongTrinh2)
        Dim clsDM As New DanhMuc_Bussines
        FillCombo(cmbID_nganh, clsDM.DanhMuc_Load("STU_Nganh", "ID_nganh", "Ten_nganh"))
        Loader = True

        SetQuyenTruyCap(cmdXet, cmdNgungHoc, cmdHocTiep, cmdDelete)
    End Sub
    Private Sub frmESS_DanhSachSinhVienNganh2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

#Region "Control Events"

#End Region

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_chuyen_nganh.SelectedIndexChanged, optDangHoc.CheckedChanged, optNgungHoc.CheckedChanged
        Try
            If Loader Then
                clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
                Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
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
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
            grdViewHocChuongTrinh2.DataSource = dt.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXet.Click
        Try
            Dim frmESS_ As New frmESS_XetHocNganh2
            frmESS_.ShowDialog()

            clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
            grdViewHocChuongTrinh2.DataSource = dt.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdNgungHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNgungHoc.Click
        Try
            If Thongbao("Bạn có muốn nhập ngừng học cho sinh viên này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        clsCTDT2.CapNhat_ESSsvSinhVienNganh2_NgungHoc(dv.Item(i)("ID_sv"), dv.Item(i)("ID_dt2"), True)
                    End If
                Next
                clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
                Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
                grdViewHocChuongTrinh2.DataSource = dt.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdHocTiep_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHocTiep.Click
        Try
            If Thongbao("Bạn có muốn nhập học tiếp cho sinh viên này không ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") = True Then
                        clsCTDT2.CapNhat_ESSsvSinhVienNganh2_NgungHoc(dv.Item(i)("ID_sv"), dv.Item(i)("ID_dt2"), False)
                    End If
                Next
                clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
                Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
                grdViewHocChuongTrinh2.DataSource = dt.DefaultView
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") = True Then
                    clsCTDT2.Xoa_ESSsvDanhSachNganh2(dv.Item(i)("ID_sv"), dv.Item(i)("ID_dt2"))
                End If
            Next
            clsCTDT2 = New DanhSachNganh2_Bussines(cmbID_nganh.SelectedValue, cmbID_chuyen_nganh.SelectedValue, "")
            Dim dt As DataTable = clsCTDT2.DanhSachSinhVienChuongTrinh2(optNgungHoc.Checked)
            grdViewHocChuongTrinh2.DataSource = dt.DefaultView
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdIn_ds_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdIn_ds.Click
        Try
            Dim dv1 As DataView = grdViewHocChuongTrinh2.DataSource
            Dim dt As DataTable = dv1.Table.Copy
            If dt.Rows.Count > 0 Then
                dt.Columns.Add("Tieu_de")
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
                Dim TieuDe As String = ""
                If cmbID_nganh.Text.Trim <> "" Then TieuDe += "  NGÀNH: " & cmbID_nganh.Text
                If cmbID_chuyen_nganh.Text.Trim <> "" Then TieuDe += "  CHUYÊN NGÀNH: " & cmbID_chuyen_nganh.Text

                dt.Rows(0).Item("Tieu_de") = TieuDe.ToUpper


                Dim frmESS_ As New frmESS_XemBaoCao
                frmESS_.ShowDialog_RFix("Danhsach Nganh2", dt)
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdNganh2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSuaNganh2.Click
        Try
            Dim dv As DataView = grdViewHocChuongTrinh2.DataSource
            Dim frm As New frmSua_Nganh2
            frm.ShowDialog(dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index)("ID_he"), dv.Item(grdViewHocChuongTrinh2.CurrentRow.Index)("ID_SV"))

            cmbHoc_ky_SelectedIndexChanged(sender, e)
        Catch ex As Exception
        End Try
    End Sub
End Class