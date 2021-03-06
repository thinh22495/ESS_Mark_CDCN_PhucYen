Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports ESSUtility

Public Class frmESS_ToChucThi_PhucKhao
    Private mdtPhucKhao As New DataTable
    Private mclsTCThi As TochucThi_Bussines
    Private Loader As Boolean = False

    Public Sub New(ByVal dt As DataTable, ByVal clsTCThi As TochucThi_Bussines)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        mclsTCThi = clsTCThi
        mdtPhucKhao = dt

    End Sub

    Private Sub frmESS_ToChucThiPhucKhao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdPhucKhaoThi)
        Dim dt_dm As DataTable
        Dim cls As New DanhMuc_Bussines
        dt_dm = cls.DanhMuc_Load("STU_Khoa", "ID_khoa", "Ten_khoa")
        FillCombo(cmbID_khoa, dt_dm)

        If mdtPhucKhao.Rows.Count > 0 Then
            Dim objToChucThi As ESSTochucThi = mclsTCThi.ToChucThi(0)
            lblMonThi.Text = "DANH SÁCH PHÚC KHẢO Học phần THI: " & objToChucThi.Ten_mon.ToUpper
            lblHocKy.Text = " LẦN THI: " & objToChucThi.Lan_thi & ", ĐỢT: " & objToChucThi.Dot_thi & ", HỌC KỲ " & objToChucThi.Hoc_ky & ", NĂM HỌC " & objToChucThi.Nam_hoc
            grdPhucKhaoThi.DataSource = mdtPhucKhao.DefaultView
            txtSo_sv.Text = "Số sinh viên: " + mdtPhucKhao.DefaultView.Count.ToString
        End If
    End Sub

    Private Sub frmESS_ToChucThiPhucKhao_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If grdPhucKhaoThi.CurrentRow Is Nothing Then Exit Sub
            Dim dv As DataView = grdPhucKhaoThi.DataSource
            For i As Integer = 0 To dv.Count - 1
                Dim objPK As New ESSToChucThiPhucKhao
                objPK.ID_thi = dv.Item(i)("ID_thi")
                objPK.ID_ds_thi = dv.Item(i)("ID_ds_thi")
                objPK.Lan = 1
                objPK.Diem1 = IIf(dv.Item(i)("Diem1").ToString <> "", dv.Item(i)("Diem1"), 0)
                objPK.Diem2 = IIf(dv.Item(i)("Diem2").ToString <> "", dv.Item(i)("Diem2"), 0)
                objPK.Ghi_chu = IIf(objPK.Diem1 <> objPK.Diem2, "PK " & objPK.Diem1.ToString & "->" & objPK.Diem2, "Không thay đổi điểm")
                If dv.Item(i)("ID_phuc_khao") <> 0 Then
                    objPK.ID_phuc_khao = dv.Item(i)("ID_ds_thi")
                    mclsTCThi.CapNhat_ESSToChucThiPhucKhao(objPK, dv.Item(i)("ID_phuc_khao"))
                Else
                    mclsTCThi.ThemMoi_ESSToChucThiPhucKhao(objPK)
                End If
            Next
            Thongbao("Cập nhật danh sách phúc khảo thành công", MsgBoxStyle.Information)
            Me.Tag = 1
            Me.Close()
        Catch ex As Exception
            Thongbao("Lỗi cập nhật danh sách phúc khảo. Thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If grdPhucKhaoThi.CurrentRow Is Nothing Then Exit Sub
            Dim dv As DataView = grdPhucKhaoThi.DataSource
            For i As Integer = 0 To dv.Count - 1
                If dv.Item(i)("Chon") AndAlso dv.Item(i)("ID_phuc_khao") Then
                    mclsTCThi.Xoa_ESSToChucThiPhucKhao(dv.Item(i)("ID_phuc_khao"))
                End If
            Next
            Thongbao("Xóa danh sách phúc khảo thành công", MsgBoxStyle.Information)
        Catch ex As Exception
            Thongbao("Lỗi xóa danh sách phúc khảo. Thông tin lỗi: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = 0
        Me.Close()
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If Not grdPhucKhaoThi.CurrentRow Is Nothing Then
            Dim dv As DataView = grdPhucKhaoThi.DataSource
            'dv.Sort = "So_bao_danh"
            Dim frmESS_ As New frmESS_XemBaoCao
            frmESS_.ShowDialog("DS PHUC KHAO THI", dv.Table, lblMonThi.Text, lblHocKy.Text)
        Else
            Thongbao("Bạn hãy lập danh sách sinh viên phúc khảo")
        End If
    End Sub

    Private Sub txtMa_sv_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMa_sv.Leave
        Try
            Dim dv As DataView
            If grdPhucKhaoThi.DataSource Is Nothing Then Exit Sub
            dv = grdPhucKhaoThi.DataSource
            Dim dk As String = ""
            dk = "1=1"
            If cmbID_khoa.Text.Trim <> "" Then dk += " AND ID_khoa= " & cmbID_khoa.SelectedValue
            If txtMa_sv.Text.Trim <> "" Then dk += " AND Ma_sv like'%" & txtMa_sv.Text.Trim & "%'"
            If txtHo_ten.Text.Trim <> "" Then dk += " AND Ho_ten like'%" & txtHo_ten.Text.Trim & "%'"
            dv.RowFilter = dk
            grdPhucKhaoThi.DataSource = dv
            txtSo_sv.Text = "Số sinh viên: " + dv.Count.ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub txtHo_ten_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHo_ten.Leave
        Try
            Dim dv As DataView
            If grdPhucKhaoThi.DataSource Is Nothing Then Exit Sub
            dv = grdPhucKhaoThi.DataSource
            Dim dk As String = ""
            dk = "1=1"
            If cmbID_khoa.Text.Trim <> "" Then dk += " AND ID_khoa= " & cmbID_khoa.SelectedValue
            If txtMa_sv.Text.Trim <> "" Then dk += " AND Ma_sv like'%" & txtMa_sv.Text.Trim & "%'"
            If txtHo_ten.Text.Trim <> "" Then dk += " AND Ho_ten like'%" & txtHo_ten.Text.Trim & "%'"
            dv.RowFilter = dk
            grdPhucKhaoThi.DataSource = dv
            txtSo_sv.Text = "Số sinh viên: " + dv.Count.ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            Dim dv As DataView
            If grdPhucKhaoThi.DataSource Is Nothing Then Exit Sub
            dv = grdPhucKhaoThi.DataSource
            Dim dk As String = ""
            dk = "1=1"
            If cmbID_khoa.Text.Trim <> "" Then dk += " AND ID_khoa= " & cmbID_khoa.SelectedValue
            If txtMa_sv.Text.Trim <> "" Then dk += " AND Ma_sv like'%" & txtMa_sv.Text.Trim & "%'"
            If txtHo_ten.Text.Trim <> "" Then dk += " AND Ho_ten like'%" & txtHo_ten.Text.Trim & "%'"
            dv.RowFilter = dk
            grdPhucKhaoThi.DataSource = dv
            txtSo_sv.Text = "Số sinh viên: " + dv.Count.ToString
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub grdPhucKhaoThi_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdPhucKhaoThi.CellEndEdit
        If e.ColumnIndex = grdPhucKhaoThi.Columns("Diem1").Index Then
            If grdPhucKhaoThi.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdPhucKhaoThi.CurrentCell.Value) Then
                Thongbao("Bạn phải nhập điểm cũlà số !")
                grdPhucKhaoThi.CurrentCell.Value = DBNull.Value
            End If
            If grdPhucKhaoThi.CurrentCell.Value.ToString <> "" AndAlso (grdPhucKhaoThi.CurrentCell.Value < 0 Or grdPhucKhaoThi.CurrentCell.Value > 100) Then
                Thongbao("Bạn phải nhập điểm cũ là số từ 0 đến 100 !")
                grdPhucKhaoThi.CurrentCell.Value = DBNull.Value
            End If
        ElseIf e.ColumnIndex = grdPhucKhaoThi.Columns("Diem2").Index Then
            If grdPhucKhaoThi.CurrentCell.Value.ToString <> "" AndAlso Not IsNumeric(grdPhucKhaoThi.CurrentCell.Value) Then
                Thongbao("Bạn phải nhập điểm phúc khảo là số !")
                grdPhucKhaoThi.CurrentCell.Value = DBNull.Value
            End If
            If grdPhucKhaoThi.CurrentCell.Value.ToString <> "" AndAlso (grdPhucKhaoThi.CurrentCell.Value < 0 Or grdPhucKhaoThi.CurrentCell.Value > 100) Then
                Thongbao("Bạn phải nhập điểm phúc khảo là số từ 0 đến 100 !")
                grdPhucKhaoThi.CurrentCell.Value = DBNull.Value
            End If
        End If
    End Sub

    Private Sub grdPhucKhaoThi_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles grdPhucKhaoThi.DataError
        Try

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub frmESS_ToChucThiPhucKhao_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
End Class