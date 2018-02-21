Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_SearchSinhVien
    Public mID_sv As Integer = 0
    Private Idx As Integer = 0
    Private loader As Boolean = False

    Private Sub frmESS_SearchSinhVien_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadCombo()
        SetUpDataGridView(grdDanhSachSinhVien)
    End Sub
    Private Sub frmESS_SearchSinhVien_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        If Not CheckInputData() Then Exit Sub
        loader = False
        Dim Ho_ten As String = ""
        Dim Ma_sv As String = ""
        Dim SBD As String = ""
        Dim Ngay_sinh As String = ""
        Ho_ten = txtHo_ten.Text
        Ma_sv = txtMa_sv.Text
        SBD = txtSo_BD.Text
        If dtpNgay_sinh.Checked Then Ngay_sinh = dtpNgay_sinh.Value

        ' Lọc ra các lớp theo điều kiện
        Dim dk As String = "1=1"
        Dim objLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        Dim dvLop As DataView
        dvLop = objLop.Danh_sach_lop_dang_hoc().DefaultView
        If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
        If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
        If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
        dvLop.RowFilter = dk

        Dim dsID_lops As String = "0"
        For j As Integer = 0 To dvLop.Count - 1
            dsID_lops += "," & dvLop.Item(j).Item("ID_lop").ToString
        Next

        Dim obj As New DanhSachSinhVien_Bussines(dsID_lops)
        Dim dv As DataView = obj.Danh_sach_sinh_vien().DefaultView
        Dim dk1 As String = "1=1"
        If Ho_ten <> "" Then dk1 += " and Ho_ten like'%" & Ho_ten & "%'"
        If Ngay_sinh <> "" Then dk1 += " and Ngay_sinh ='" & Ngay_sinh & "'"
        If Ma_sv <> "" Then dk1 += " and Ma_sv like'%" & Ma_sv & "%'"
        If SBD <> "" Then dk1 += " and SBD like'%" & SBD & "%'"
        dv.RowFilter = dk1
        grdDanhSachSinhVien.DataSource = dv
        labSoSv.Text = dv.Count
        loader = True
    End Sub

    Private Sub cmdChose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChose.Click
        Dim dv As New DataView
        dv = grdDanhSachSinhVien.DataSource
        If dv Is Nothing Then Exit Sub
        Tag = 1
        mID_sv = dv.Item(Idx)("ID_sv")
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Tag = 0
        Me.Close()
    End Sub
    Private Function CheckDate(ByVal strDate As Date) As Boolean
        If strDate.GetDateTimeFormats().ToString().Equals("MM/dd/yyyy") Then
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub LoadCombo()
        Dim obj As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
        Dim dt As DataTable
        dt = obj.He_dao_tao()
        FillCombo(cmbID_he, dt)
        dt = obj.Khoa()
        FillCombo(cmbID_khoa, dt)
        dt = obj.Khoa_hoc()
        FillCombo(cmbKhoa_hoc, dt)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra 
        If cmbID_he.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbID_he.SelectedValue < 0 Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If


        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function

    Private Sub grdDanhSachSinhVien_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdDanhSachSinhVien.CurrentCellChanged
        Try
            Idx = grdDanhSachSinhVien.CurrentRow.Index
        Catch ex As Exception

        End Try
    End Sub
End Class