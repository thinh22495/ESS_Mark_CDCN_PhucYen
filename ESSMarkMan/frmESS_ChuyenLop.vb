Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_ChuyenLop
    Private mID_he As Integer = 0
    Private mKhoa_hoc As Integer = 0
    Private mID_sv As String = 0
    Private loader As Boolean = False
    Sub New(ByVal Khoa_hoc As Integer, ByVal ID_sv As String, ByVal ID_he As Integer)
        mKhoa_hoc = Khoa_hoc
        mID_sv = ID_sv
        mID_he = ID_he
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Dim objDanhSach As New ESSDanhSach
            objDanhSach.ID_lop = cmbID_lop.SelectedValue
            'objDanhSach.ID_svs = mID_sv
            Dim objDanhSach_Bussines As New DanhSach_Bussines
            objDanhSach_Bussines.CapNhat_ESSDanhSach(objDanhSach, mID_sv.ToString, cmbID_lop.SelectedValue)
            Dim Noi_dung As String = ""
            Noi_dung = "Các sinh viên có ID_sv: " & mID_sv & " được chuyển đến lớp " & cmbID_lop.Text.Trim
            SaveLog(LoaiSuKien.Sua, Noi_dung)
            Thongbao("Đã chuyển lớp thành công !")
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub frmESS_ChuyenLopHoc_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_ChuyenLopHoc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Dim dt As DataTable = objLop_Bussines.Danh_sach_lop_khoa_hoc(mKhoa_hoc)
        Dim dtSV As DataTable
        Dim cls As New DanhMuc_Bussines
        Dim strSQL As String = "SELECT a.Ma_sv,a.Ho_ten,a.Ngay_sinh,c.Ten_lop FROM STU_HoSoSinhVien  a INNER JOIN STU_DanhSach b ON b.ID_sv=a.ID_sv" & _
        " INNER JOIN STU_Lop c ON b.ID_lop=c.ID_lop WHERE a.ID_sv in (" & mID_sv & ")"
        dtSV = cls.DanhMuc_Load(strSQL)
        grcDanhSach.DataSource = dtSV.DefaultView

        Dim dtKhoa As DataTable
        dtKhoa = cls.LoadDanhMuc("select distinct k.ID_khoa,k.Ten_khoa from STU_Khoa k inner join STU_Lop l on k.ID_khoa=l.ID_khoa where l.ID_he =" & mID_he)
        FillCombo(cmbID_khoa, dtKhoa)
        SetQuyenTruyCap(cmdSave, , , )
        loader = True
    End Sub
    Private Sub frmESS_ChuyenLopHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        Dim objHoSo_Bussines As New HoSo_Bussines
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        ' Kiểm tra lớp
        If cmbID_lop Is Nothing Then
            Call SetErrPro(cmbID_lop, ErrorProvider1, "Bạn hãy chọn lớp học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_lop
        ElseIf cmbID_lop.SelectedValue < 0 Then
            Call SetErrPro(cmbID_lop, ErrorProvider1, "Bạn hãy chọn lớp học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_lop
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Not loader Then Exit Sub
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable
            Dim dk As String = "1=1"
            If Not cmbID_khoa.SelectedValue Is Nothing Then dk += " And ID_khoa=" & cmbID_khoa.SelectedValue
            If Not cmbKhoa_hoc.SelectedValue Is Nothing Then dk += " And Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            dt = cls.LoadDanhMuc("Select ID_lop,Ten_lop from STU_Lop where " & dk)
            FillCombo(cmbID_lop, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            Dim cls As New DanhMuc_Bussines
            Dim dt As DataTable
            Dim dk As String = "1=1"
            If mID_he <> 0 Then dk += " And ID_he=" & mID_he
            If Not cmbID_khoa.SelectedValue Is Nothing Then dk += " And ID_khoa=" & cmbID_khoa.SelectedValue
            dt = cls.LoadDanhMuc("Select distinct Khoa_hoc,Khoa_hoc from STU_Lop where " & dk)
            FillCombo(cmbKhoa_hoc, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
End Class