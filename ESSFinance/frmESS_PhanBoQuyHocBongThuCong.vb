Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_PhanBoQuyHocBongThuCong
    Private mQuy_hb As New ESSQuyHocBong
    Private dvLop As DataView
    Private Loader As Boolean = False
    Public Sub New(ByVal quy_hb As ESSQuyHocBong)
        mQuy_hb = quy_hb
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmESS_PhanBoQuyHocBongThuCong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        SetUpDataGridView(grdViewLop)
        cmbHoc_ky.SelectedValue = mQuy_hb.Hoc_ky
        cmbNam_hoc.Text = mQuy_hb.Nam_hoc
        cmbID_he.SelectedValue = mQuy_hb.ID_he
        cmbID_quy.SelectedValue = mQuy_hb.ID_quy
        HienThi_ESSDataQuyHocBong(mQuy_hb)
        ' Danh sách lớp để phân
        Dim objLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        Dim dtLop As DataTable
        dtLop = objLop.Danh_sach_lop_dang_hoc()
        Dim obj_Bussines As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
        Dim objDSSV As New DanhSachSinhVien_Bussines(gobjUser.dsID_lop)
        Dim dtSv As DataTable
        dtSv = objDSSV.Danh_sach_sinh_vien()
        dvLop = obj_Bussines.Lop_Chua_PhanBo(dtLop, dtSv, mQuy_hb.Tu_khoa, mQuy_hb.Den_khoa).DefaultView ' Danh sách lớp để phân
        If cmbID_he.SelectedValue > 0 Then dvLop.RowFilter = "ID_he=" & cmbID_he.SelectedValue
        grdViewLop.DataSource = dvLop
        labSo_lop.Text = dvLop.Count
        SetQuyenTruyCap(cmdSave, , , )
        Loader = True
    End Sub
    Private Sub frmESS_PhanBoQuyHocBongThuCong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_PhanBoQuyHocBongThuCong_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim dv As New DataView
        dv = grdViewLop.DataSource
        If dv.Count = 0 Then Exit Sub
        Dim So_sv As Integer = -1
        For i As Integer = 0 To dv.Count - 1
            If dv.Item(i)("Chon") Then So_sv += dv.Item(i)("So_sv")
        Next
        If So_sv < 0 Then ' Nếu số sv = 0 (Không có lớp nào dược chọn)
            Thongbao("Bạn phải chọn lớp trên danh sách để phân bổ !")
            Exit Sub
        End If
        If Not CheckInputData() Then Exit Sub
        Dim obj As New ESSQuyHocBongPhanBo
        Dim obj_Bussines As New QuyHocBongPhanBo_Bussines(mQuy_hb.ID_hb)
        ' Thêm mới phân bổ
        obj.ID_hb = mQuy_hb.ID_hb
        obj.Phan_dac_biet = 1
        obj.Ten_phan_bo = txtDoi_tuong_phan_bo.Text
        obj.So_tien = txtSo_tien.Text
        obj.So_sv = So_sv
        Dim ID_Phan_bo As Integer
        ID_Phan_bo = obj_Bussines.ThemMoi_ESSQuyHocBongPhanBo(obj)
        obj.ID_phan_bo = ID_Phan_bo
        obj_Bussines.ThemMoi_ESSQuyHocBongPhanBo_Memory(obj)
        Dim dt As DataTable
        dt = obj_Bussines.DanhSach_QuyHocBongPhanBo()
        ' Số tiền đã cấp
        Dim SoTien_DaCap As Double = 0
        For i As Integer = 0 To dt.Rows.Count - 1
            SoTien_DaCap += dt.Rows(i)("So_tien")
        Next
        txtSotien_dacap.Text = Format(SoTien_DaCap, "###,##0")
        ' Số tiền còn lại
        txtSotien_conlai.Text = Format(txtSotien.Text - SoTien_DaCap, "###,##0")
        ' Cập nhật lóp đã phân và xóa trên danh sách             
        For i As Integer = dv.Count - 1 To 0 Step -1
            If dv.Item(i)("Chon") Then
                obj_Bussines.ThemMoi_ESSQuyHocBongPhanBoLop(ID_Phan_bo, dv.Item(i)("ID_lop"))
                dv.Item(i).Delete()
            End If
        Next
        dv.Table.AcceptChanges()
        dvLop = dv
        dv.Sort = "Ten_lop"
        labSo_lop.Text = dv.Count
        grdViewLop.DataSource = dv
        Thongbao("Bạn đã phân bổ thành công !")
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmbHoc_ky_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbHoc_ky.SelectedIndexChanged, cmbNam_hoc.SelectedIndexChanged, cmbID_he.SelectedIndexChanged, cmbID_quy.SelectedIndexChanged
        If Not Loader Then Exit Sub
        ' Load dữ liệu quỹ học bổng            
        Dim obj As New QuyHocBong_Bussines(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text)
        mQuy_hb = obj.HienThi_ESSQuyHocBong(cmbHoc_ky.SelectedValue, cmbNam_hoc.Text, cmbID_he.SelectedValue, cmbID_quy.SelectedValue)
        HienThi_ESSDataQuyHocBong(mQuy_hb)
    End Sub
    Private Sub txtSotien_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtSotien.TextChanged, txtSotien_conlai.TextChanged, txtSotien_dacap.TextChanged
        txtSotien_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien.Text, Long)) & " đồng )"
        txtSotien_dacap_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien_dacap.Text, Long)) & " đồng )"
        txtSotien_conlai_chu.Text = "(" & ChuyenChu(CType("0" & txtSotien_conlai.Text, Long)) & " đồng )"
    End Sub
    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged, cmbKhoa_hoc.SelectedIndexChanged, cmbID_Nganh.SelectedIndexChanged
        If Not Loader Then Exit Sub
        Dim dk As String = "1=1"
        If dvLop.Count = 0 Then Exit Sub
        Dim dt As DataTable
        dt = dvLop.Table.Copy
        If cmbID_he.SelectedValue > 0 Then dk += " And Ten_he='" & cmbID_he.Text & "'"
        If cmbID_khoa.SelectedValue > 0 Then dk += " And Ten_khoa='" & cmbID_khoa.Text & "'"
        If cmbKhoa_hoc.SelectedValue > 0 Then dk += " And Khoa_hoc='" & cmbKhoa_hoc.Text & "'"
        If cmbID_Nganh.SelectedValue > 0 Then dk += " And Ten_nganh='" & cmbID_Nganh.Text & "'"
        dt.DefaultView.RowFilter = dk
        labSo_lop.Text = dt.DefaultView.Count
        dt.DefaultView.Sort = "Ten_lop"
        dt.DefaultView.AllowNew = False
        grdViewLop.DataSource = dt.DefaultView
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub Fill_Combo()
        Add_Hocky(cmbHoc_ky)
        Add_Namhoc(cmbNam_hoc)
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable
        dt = clsDM.DanhMuc_Load("ACC_LoaiQuy", "ID_quy", "Loai_quy")
        FillCombo(cmbID_quy, dt)
        Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        dt = clsLop.He_dao_tao()
        FillCombo(cmbID_he, dt)
        dt = clsLop.Khoa()
        FillCombo(cmbID_khoa, dt)
        Dim dv As DataView
        dv = clsLop.Khoa_hoc().DefaultView
        dv.RowFilter = "Khoa_hoc>=" & mQuy_hb.Tu_khoa & " And Khoa_hoc<=" & mQuy_hb.Den_khoa
        FillCombo(cmbKhoa_hoc, dv)
        dt = clsLop.Nganh_dao_tao()
        FillCombo(cmbID_Nganh, dt)
    End Sub
    Private Sub HienThi_ESSDataQuyHocBong(ByVal quy_hb As ESSQuyHocBong)
        Try
            txtSotien.Text = Format(mQuy_hb.Sotien_ngansach + mQuy_hb.Sotien_khac, "###,##0")
            ' Load dữ liệu phân bổ quỹ học bổng thủ công
            Dim quy_hb_pb As New ESSQuyHocBongPhanBo
            Dim objPhanBo As New QuyHocBongPhanBo_Bussines(quy_hb.ID_hb)
            Dim dt As DataTable
            dt = objPhanBo.DanhSach_QuyHocBongPhanBo()
            ' Số tiền đã cấp
            Dim SoTien_DaCap As Double = 0
            For i As Integer = 0 To dt.Rows.Count - 1
                SoTien_DaCap += dt.Rows(i)("So_tien")
            Next
            txtSotien_dacap.Text = Format(SoTien_DaCap, "###,##0")
            ' Số tiền còn lại
            txtSotien_conlai.Text = Format(txtSotien.Text - SoTien_DaCap, "###,##0")
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra đối tượng phân bổ
        If txtDoi_tuong_phan_bo.Text = "" Then
            Call SetErrPro(txtDoi_tuong_phan_bo, ErrorProvider1, "Bạn hãy nhập tên đối tượng phân bổ !")
            If CtrlErr Is Nothing Then CtrlErr = txtDoi_tuong_phan_bo
        End If
        ' Kiểm tra số tiền nhập vào
        If txtSo_tien.Text = "" Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Bạn hãy nhập số tiền phân bổ !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf Not IsNumeric(txtSo_tien.Text) Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Nhập số tiền phân bổ là kiếu số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        ElseIf CDbl(txtSo_tien.Text) > CDbl(txtSotien_conlai.Text) Or CDbl(txtSo_tien.Text) = 0 Then
            Call SetErrPro(txtSo_tien, ErrorProvider1, "Số tiền phân bổ > Số tiền còn lại bạn không thể phân thêm !")
            If CtrlErr Is Nothing Then CtrlErr = txtSo_tien
        End If
        ' Kiểm tra đối tượng phân bổ
        If cmbID_he.SelectedValue < 0 Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbID_quy.SelectedValue < 0 Then
            Call SetErrPro(cmbID_quy, ErrorProvider1, "Bạn hãy chọn loại học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_quy
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
#End Region

    Private Sub chkAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAll.CheckedChanged
        Try
            Dim dv As New DataView
            dv = grdViewLop.DataSource
            If dv.Count = 0 Then Exit Sub
            For i As Integer = 0 To dv.Count - 1
                dv.Item(i).Row.Item("Chon") = chkAll.Checked
            Next
            grdViewLop.DataSource = dv
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class