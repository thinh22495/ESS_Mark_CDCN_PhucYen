Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_UserSinhVien
    Private Loader As Boolean = False
    Private dsID_lop As String = ""
    Private mdt As DataTable
    Private objDanhSach As DanhSachSinhVien_Bussines

#Region "Form Events"
    Private Sub frmESS_UserSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.trvLop.HienThi_ESSTreeView()
        SetUpDataGridView(grdDanhSachSinhVien)
        Loader = True

    End Sub

    Private Sub frmESS_UserSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region

    Private Sub trvLop_Select() Handles trvLop.TreeNodeSelected_
        Try
            If Loader Then
                If Not trvLop.ID_lop_list Is Nothing Then
                    dsID_lop = trvLop.ID_lop_list
                    'Load danh sách sinh viên
                    objDanhSach = New DanhSachSinhVien_Bussines(dsID_lop, True)
                    mdt = objDanhSach.Danh_sach_sinh_vien_TruyCap
                    grdDanhSachSinhVien.DataSource = mdt.DefaultView
                    txtMa_sv_Leave(Nothing, Nothing)
                    txtHo_ten_Leave(Nothing, Nothing)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Dim dv As DataView = grdDanhSachSinhVien.DataSource
        If Not dv Is Nothing Then
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i)("Active") = chkAll.Checked
            Next
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreate.Click
        Try
            Dim dv As DataView = grdDanhSachSinhVien.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Active") Then
                    If chkMa_sv.Checked And chkNgay_sinh.Checked Then
                        dv.Item(i)("Mat_khau") = dv.Item(i)("Ma_sv") & dv.Item(i)("Mat_khau_NgaySinh")
                    End If
                    If chkMa_sv.Checked And chkNgay_sinh.Checked = False Then
                        dv.Item(i)("Mat_khau") = dv.Item(i)("Ma_sv")
                    End If
                    If chkMa_sv.Checked = False And chkNgay_sinh.Checked Then
                        dv.Item(i)("Mat_khau") = dv.Item(i)("Mat_khau_NgaySinh")
                    End If
                    If chkMa_sv.Checked = False And chkNgay_sinh.Checked = False Then
                        dv.Item(i)("Mat_khau") = ""
                    End If
                End If
            Next
            txtMa_sv_Leave(sender, e)
            txtHo_ten_Leave(sender, e)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As DataView = grdDanhSachSinhVien.DataSource
            For i As Integer = 0 To dv.Count - 1
                Dim obj As New ESSDanhSachSinhVien
                obj.ID_sv = dv.Item(i)("ID_SV")
                obj.ID_lop = dv.Item(i)("ID_lop")
                obj.Mat_khau = dv.Item(i)("Mat_khau")
                obj.Active = dv.Item(i)("Active")
                objDanhSach.CapNhat_ESSDanhSachSinhVien_QuyenTruyCap(obj)
            Next
            Thongbao("Cập nhật thành công mật khẩu và trạng thái kích hoạt mật khẩu sinh viên !", MsgBoxStyle.Information)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub txtMa_sv_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        If grdDanhSachSinhVien.CurrentRow Is Nothing Then Exit Sub
        Dim dv As DataView = grdDanhSachSinhVien.DataSource
        dv.RowFilter = ""
        Dim dk As String = "1=1"
        If txtMa_sv.Text.Trim <> "" Then dk += " AND Ma_sv like '%" & txtMa_sv.Text.Trim & "%'"
        If txtHo_ten.Text.Trim <> "" Then dk += " AND Ho_ten like '%" & txtHo_ten.Text.Trim & "%'"
        dv.RowFilter = dk
        grdDanhSachSinhVien.DataSource = dv
    End Sub

    Private Sub txtHo_ten_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHo_ten.Leave
        If grdDanhSachSinhVien.CurrentRow Is Nothing Then Exit Sub
        Dim dv As DataView = grdDanhSachSinhVien.DataSource
        dv.RowFilter = ""
        Dim dk As String = "1=1"
        If txtMa_sv.Text.Trim <> "" Then dk += " AND Ma_sv like '%" & txtMa_sv.Text.Trim & "%'"
        If txtHo_ten.Text.Trim <> "" Then dk += " AND Ho_ten like '%" & txtHo_ten.Text.Trim & "%'"
        dv.RowFilter = dk
        grdDanhSachSinhVien.DataSource = dv
    End Sub
End Class