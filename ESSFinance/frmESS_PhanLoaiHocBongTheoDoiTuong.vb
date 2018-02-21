Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_PhanLoaiHocBongTheoDoiTuong
    Private Loader As Boolean = False
    Private Edit As Boolean = False
    Private Sub frmESS_PhanLoaiHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(grdViewDoiTuongHB)
        SetUpDataGridView(grdViewLoaiHB)
        ' Fill com bo
        Fill_Combo()
        ' Load danh sách đối tượng học bổng
        Dim obj_Bussines As New LoaiHocBong_Bussines()
        Dim dv As DataView
        dv = obj_Bussines.HienThi_ESSDoiTuongHocBong().DefaultView
        grdViewDoiTuongHB.DataSource = dv
        SetQuyenTruyCap(cmdSave, cmdAdd, cmdEdit, cmdDelete)
        Loader = True
    End Sub
    Private Sub frmESS_PhanBoQuyHocBongThuCong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Button"
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Lock_Control(1)
        cmbLoai_HB.SelectedIndex = -1
        cmbID_he.SelectedValue = -1
        txtSo_tien.Text = ""
        Edit = False
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Lock_Control(1)
        Edit = True
    End Sub

    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim dv As New DataView
        dv = grdViewLoaiHB.DataSource
        If dv.Count = 0 Then Exit Sub
        If Thongbao("Bạn có muốn xóa loại học bổng này không !", MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Dim idx As Integer = 0
        idx = grdViewLoaiHB.CurrentRow.Index
        Dim obj_Bussines As New LoaiHocBong_Bussines
        obj_Bussines.Xoa_ESSLoaiHocBong(dv.Item(idx)("Ma_dt"), dv.Item(idx)("ID_he"), dv.Item(idx)("ID_xep_loai_hb"))
        ' Xóa trên dv
        dv.Item(idx).Delete()
        dv.Table.AcceptChanges()
        grdViewLoaiHB.DataSource = dv
        Thongbao("Bạn đã xóa thành công !")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not CheckInputData() Then Exit Sub
        Dim dv1 As New DataView
        dv1 = grdViewLoaiHB.DataSource
        Dim obj As New ESSLoaiHocBong
        obj.ID_he = cmbID_he.SelectedValue
        obj.Ten_he = cmbID_he.Text
        obj.ID_xep_loai_hb = cmbLoai_HB.SelectedValue
        obj.Ten_xep_loai = cmbLoai_HB.Text
        obj.HB_HT = CInt(txtSo_tien.Text)
        Dim obj_Bussines As New LoaiHocBong_Bussines()
        If Edit Then ' Nếu sửa            
            Dim idx As Integer = 0
            idx = grdViewLoaiHB.CurrentRow.Index
            obj.Ma_dt = dv1.Item(idx)("Ma_dt")
            obj_Bussines.CapNhat_ESSLoaiHocBong(obj)
            ' Update dv
            dv1.Item(idx)("Ma_dt") = obj.Ma_dt
            dv1.Item(idx)("ID_he") = obj.ID_he
            dv1.Item(idx)("Ten_he") = obj.Ten_he
            dv1.Item(idx)("ID_xep_loai_hb") = obj.ID_xep_loai_hb
            dv1.Item(idx)("Ten_xep_loai") = obj.Ten_xep_loai
            dv1.Item(idx)("HB_HT") = Format(obj.HB_HT, "###,##0")
        Else ' Nếu thêm mới
            Dim dv As New DataView
            dv = grdViewDoiTuongHB.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewDoiTuongHB.CurrentRow.Index
            obj.Ma_dt = dv.Item(idx)("Ma_dt_hb")
            If Not obj_Bussines.CheckExist_LoaiHocBong(obj.Ma_dt, obj.ID_he, obj.ID_xep_loai_hb) Then
                obj_Bussines.ThemMoi_ESSLoaiHocBong(obj)
            Else
                Thongbao("Loại học bổng đã tồn tại bạn không thể thêm mới !")
            End If
            ' Insert dv
            Dim dr As DataRow
            dr = dv1.Table.NewRow
            dr("Ma_dt") = obj.Ma_dt
            dr("ID_he") = obj.ID_he
            dr("Ten_he") = obj.Ten_he
            dr("ID_xep_loai_hb") = obj.ID_xep_loai_hb
            dr("Ten_xep_loai") = obj.Ten_xep_loai
            dr("HB_HT") = Format(obj.HB_HT, "###,##0")
            dv1.Table.Rows.Add(dr)
        End If
        dv1.Table.AcceptChanges()
        grdViewLoaiHB.DataSource = dv1
        Lock_Control(0)
        Thongbao("Đã cập nhật thành công !")
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Lock_Control(0)
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Try
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable
            dt = cls.DanhMuc_Load("STU_XepLoaiHocBong", "ID_xep_loai_hb", "Ten_xep_loai")
            FillCombo(cmbLoai_HB, dt)
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra         
        If txtSo_tien.Text = "" Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập số tiền học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf Not IsNumeric(txtSo_tien.Text) Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập số tiền là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        End If
        If cmbID_he.SelectedValue < 0 Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbLoai_HB.SelectedValue < 0 Then
            Call SetErrPro(cmbLoai_HB, ErrorProvider1, "Bạn hãy chọn loại học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = cmbLoai_HB
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
    Private Sub Lock_Control(ByVal Edit As Integer)
        If Edit = 1 Then ' Nếu là sửa
            cmbID_he.Enabled = True
            cmbLoai_HB.Enabled = True
            txtSo_tien.Enabled = True
            cmdAdd.Visible = False
            cmdEdit.Visible = False
            cmdDelete.Visible = False
            cmdSave.Visible = True
            cmdCancel.Visible = True
        Else ' Nếu là hủy
            cmbID_he.Enabled = False
            cmbLoai_HB.Enabled = False
            txtSo_tien.Enabled = False
            cmdAdd.Visible = True
            cmdEdit.Visible = True
            cmdDelete.Visible = True
            cmdSave.Visible = False
            cmdCancel.Visible = False
        End If
    End Sub
    Private Sub Fill_Data()
        Try
            Dim dv As New DataView
            dv = grdViewLoaiHB.DataSource
            If dv Is Nothing Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewLoaiHB.CurrentRow.Index
            cmbID_he.SelectedValue = dv.Item(idx)("ID_he")
            cmbLoai_HB.SelectedValue = dv.Item(idx)("ID_xep_loai_hb")
            txtSo_tien.Text = dv.Item(idx)("HB_HT")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub HienThi_ESSData()
        Try
            Dim obj_Bussines As New LoaiHocBong_Bussines()
            Dim dv As New DataView
            dv = grdViewDoiTuongHB.DataSource
            If dv.Count = 0 Then Exit Sub
            Dim idx As Integer = 0
            idx = grdViewDoiTuongHB.CurrentRow.Index
            Dim dv1 As New DataView
            dv1 = obj_Bussines.HienThi_ESSLoaiHocBong(dv.Item(idx)("Ma_dt_hb")).DefaultView
            grdViewLoaiHB.DataSource = dv1
        Catch ex As Exception

        End Try
    End Sub
#End Region
#Region "Change"
    Private Sub grdViewLoaiHB_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewLoaiHB.CurrentCellChanged
        If Not Loader Then Exit Sub
        Fill_Data()
    End Sub

    Private Sub grdViewDoiTuongHB__CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdViewDoiTuongHB.CurrentCellChanged
        If Not Loader Then Exit Sub
        HienThi_ESSData()
    End Sub
#End Region

    Private Sub lblHoc_ky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblHoc_ky.Click
        'Try
        '    Dim cls As New DanhMuc_Bussines
        '    Dim dtDT As DataTable
        '    dtDT = cls.LoadDanhMuc("select * from  STU_DoiTuongHocbong")
        '    Dim dvHe As DataView
        '    dvHe = cls.LoadDanhMuc("select * from  STU_He").DefaultView
        '    ' Xóa danh mục
        '    Dim strSQL As String = "delete svLoaiHocBong"
        '    cls.ExcecuteDM(strSQL)
        '    For k As Integer = 1 To 3
        '        For i As Integer = 0 To dvHe.Count - 1
        '            For j As Integer = 0 To dtDT.Rows.Count - 1
        '                Dim HB_HT As Integer
        '                ' Cac hẹ con lai  mac dinh luc dau gong nhu hẹ dai hoc chinh quy
        '                If k = 1 Then HB_HT = 2000000
        '                If k = 2 Then HB_HT = 1500000
        '                If k = 3 Then HB_HT = 900000
        '                ' Hệ DH chinh quy
        '                If k = 1 And dvHe.Item(i)("ID_he") = 1 Then HB_HT = 2000000
        '                If k = 2 And dvHe.Item(i)("ID_he") = 1 Then HB_HT = 1500000
        '                If k = 3 And dvHe.Item(i)("ID_he") = 1 Then HB_HT = 900000
        '                ' He cao dang chinh quy
        '                If k = 1 And dvHe.Item(i)("ID_he") = 2 Then HB_HT = 1750000
        '                If k = 2 And dvHe.Item(i)("ID_he") = 2 Then HB_HT = 1250000
        '                If k = 3 And dvHe.Item(i)("ID_he") = 2 Then HB_HT = 750000
        '                Dim str As String = ""
        '                str = " Insert into svLoaiHocBong(Ma_dt,ID_he,ID_xep_loai_hb,HB_HT) Values(N'" & dtDT.Rows(j)("Ma_dt_hb") & "'," & dvHe.Item(i)("ID_he") & "," & k & "," & HB_HT & ")"
        '                cls.ExcecuteDM(str)
        '            Next
        '        Next
        '    Next
        'Catch ex As Exception
        '    Thongbao(ex.Message)
        'End Try
    End Sub
End Class