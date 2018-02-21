Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_QuyHocBong
    Private mEdit As Boolean = False
    Private mHoc_ky As Integer = 0
    Private mNam_hoc As String = ""
    Private mIndex As Integer = 0
    Public Sub New(ByVal Edit As Boolean, ByVal Idx As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
        mEdit = Edit
        mIndex = Idx
        mHoc_ky = Hoc_ky
        mNam_hoc = Nam_hoc
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmESS_QuyHocBong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Fill_Combo()
        FillData()
        SetQuyenTruyCap(cmdSave, , , )
    End Sub
    Private Sub frmESS_QuyHocBong_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#Region "Button"
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If Not CheckInputData() Then Exit Sub
        Dim obj_Bussines As New QuyHocBong_Bussines(mHoc_ky, mNam_hoc)
        Dim obj As New ESSQuyHocBong
        If mEdit Then ' cập nhật     
            obj = obj_Bussines.QuyHocBong_Index(mIndex)
            obj.ID_quy = cmbID_quy.SelectedValue
            obj.ID_he = cmbID_he.SelectedValue
            obj.Hoc_ky = cmbHoc_ky.SelectedValue
            obj.Nam_hoc = cmbNam_hoc.Text
            obj.Tu_khoa = cmbTu_khoa.SelectedValue
            obj.Den_khoa = cmbDen_khoa.SelectedValue
            obj.Sotien_ngansach = txtSotien_ngansach.Text
            If txtSotien_khac.Text <> "" Then obj.Sotien_khac = txtSotien_khac.Text
            obj.Ghi_chu = txtGhi_chu.Text
            obj_Bussines.CapNhat_ESSQuyHocBong(obj, obj.ID_hb)
            Thongbao("Đã sửa thành công quỹ học bổng !")
        Else ' thêm mới
            obj.ID_quy = cmbID_quy.SelectedValue
            obj.ID_he = cmbID_he.SelectedValue
            obj.Hoc_ky = cmbHoc_ky.SelectedValue
            obj.Nam_hoc = cmbNam_hoc.Text
            obj.Tu_khoa = cmbTu_khoa.SelectedValue
            obj.Den_khoa = cmbDen_khoa.SelectedValue
            obj.Sotien_ngansach = txtSotien_ngansach.Text
            If txtSotien_khac.Text <> "" Then obj.Sotien_khac = txtSotien_khac.Text
            obj.Ghi_chu = txtGhi_chu.Text
            If obj_Bussines.CheckExist_QuyHocBong(cmbID_he.SelectedValue, obj.Hoc_ky, obj.Nam_hoc, obj.ID_quy) Then
                Thongbao("Quỹ học bổng đã tồn tại bạn không thể thêm mới !")
                Exit Sub
            Else
                obj_Bussines.ThemMoi_ESSQuyHocBong(obj)
                Thongbao("Đã thêm thành công quỹ học bổng !")
            End If
        End If
        Me.Close()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region "Functions And Subs"
    Private Sub FillData()
        Try
            If mEdit Then ' nếu là sửa
                Dim obj_Bussines As New QuyHocBong_Bussines(mHoc_ky, mNam_hoc)
                Dim obj As New ESSQuyHocBong
                obj = obj_Bussines.QuyHocBong_Index(mIndex)
                cmbHoc_ky.SelectedValue = obj.Hoc_ky
                cmbNam_hoc.Text = obj.Nam_hoc
                cmbID_quy.SelectedValue = obj.ID_quy
                cmbID_he.SelectedValue = obj.ID_he
                cmbTu_khoa.SelectedValue = obj.Tu_khoa
                cmbDen_khoa.SelectedValue = obj.Den_khoa
                txtSotien_ngansach.Text = obj.Sotien_ngansach
                txtSotien_khac.Text = obj.Sotien_khac
                txtGhi_chu.Text = obj.Ghi_chu
            Else ' thêm mới
                cmbID_quy.SelectedValue = -1
                cmbID_he.SelectedValue = -1
                cmbTu_khoa.SelectedValue = -1
                cmbDen_khoa.SelectedValue = -1
                txtSotien_ngansach.Text = ""
                txtSotien_khac.Text = ""
                txtGhi_chu.Text = ""
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

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
        dt = clsLop.Khoa_hoc()
        FillCombo(cmbTu_khoa, dt)
        Dim dt1 As DataTable
        dt1 = dt.Copy
        FillCombo(cmbDen_khoa, dt1)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra combo
        If cmbHoc_ky.SelectedValue Is Nothing Then
            Call SetErrPro(cmbHoc_ky, ErrorProvider1, "Bạn hãy chọn học kỳ !")
            If CtrlErr Is Nothing Then CtrlErr = cmbHoc_ky
        End If
        If cmbNam_hoc.SelectedValue Is Nothing Then
            Call SetErrPro(cmbNam_hoc, ErrorProvider1, "Bạn hãy chọn năm học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbNam_hoc
        End If
        If cmbID_quy.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_quy, ErrorProvider1, "Bạn hãy chọn quỹ học bổng !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_quy
        End If
        If cmbID_he.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ đào tạo !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        End If
        If cmbTu_khoa.SelectedValue Is Nothing Then
            Call SetErrPro(cmbTu_khoa, ErrorProvider1, "Bạn hãy chọn khóa học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbTu_khoa
        End If
        If cmbDen_khoa.SelectedValue Is Nothing Then
            Call SetErrPro(cmbDen_khoa, ErrorProvider1, "Bạn hãy chọn khóa học !")
            If CtrlErr Is Nothing Then CtrlErr = cmbDen_khoa
        End If
        If txtSotien_ngansach.Text = "" Then
            Call SetErrPro(txtSotien_ngansach, ErrorProvider1, "Bạn hãy nhập vào số tiền ngân sách !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_ngansach
        ElseIf Not IsNumeric(txtSotien_ngansach.Text) Then
            Call SetErrPro(txtSotien_ngansach, ErrorProvider1, "Số tiền ngân sách phải là dạng số !")
            If CtrlErr Is Nothing Then CtrlErr = txtSotien_ngansach
        End If
        If txtSotien_khac.Text <> "" Then
            If Not IsNumeric(txtSotien_khac.Text) Then
                Call SetErrPro(txtSotien_khac, ErrorProvider1, "Số tiền khác phải là dạng số !")
                If CtrlErr Is Nothing Then CtrlErr = txtSotien_khac
            End If
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

End Class