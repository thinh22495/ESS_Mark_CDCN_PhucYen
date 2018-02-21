Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_HocPhan
    Private mThoat As Boolean
    Private mID_he As Integer = 0

    Dim LoaderCombobox As Boolean = False
    Property Thoat() As Boolean
        Get
            Return mThoat
        End Get
        Set(ByVal value As Boolean)
            mThoat = value
        End Set
    End Property




    Public Overloads Sub ShowDialog(ByVal ID_he As Integer)
        Try
            mID_he = ID_he
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Me.ShowDialog()
    End Sub

    Private Sub frmESS__Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        LoadCombox()
    End Sub
    Private Sub frmESS_MonHoc_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Public Function getValueFromUI() As ESSMonHoc
        Dim objMonHoc As ESSMonHoc = New ESSMonHoc
        Try
            objMonHoc.ID_he = cmbID_he.SelectedValue
            objMonHoc.ID_nhom = cmbID_nhom.SelectedValue
            objMonHoc.ID_bm = cmbID_bm.SelectedValue
            objMonHoc.Ky_hieu = txtKy_hieu.Text
            objMonHoc.Ten_mon = txtTen_mon.Text
            objMonHoc.Ten_tieng_anh = txtTen_tieng_anh.Text
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
        Return objMonHoc
    End Function
    Public Sub setValueToUI(ByVal objMonHoc As ESSMonHoc)
        Try
            LoadCombox()
            cmbID_he.SelectedValue = objMonHoc.ID_he
            cmbID_nhom.SelectedValue = objMonHoc.ID_nhom
            cmbID_bm.SelectedValue = objMonHoc.ID_bm
            txtKy_hieu.Text = objMonHoc.Ky_hieu
            txtTen_mon.Text = objMonHoc.Ten_mon
            txtTen_tieng_anh.Text = objMonHoc.Ten_tieng_anh
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Sub LoadCombox()
        If LoaderCombobox = True Then Exit Sub
        Dim objBoMon As New BoMon_Bussines
        FillCombo(cmbID_bm, objBoMon.DanhMucBoMon)
        Dim clsDM As New DanhMuc_Bussines
        Dim dt As DataTable
        If mID_he > 0 Then
            dt = clsDM.DanhMuc_Load("STU_He", "ID_he", "Ten_he", "ID_he", mID_he)
        Else
            dt = clsDM.DanhMuc_Load("STU_He", "ID_he", "Ten_he")
        End If
        FillCombo(cmbID_he, dt)
        dt = clsDM.DanhMuc_Load("PLAN_MonHocNhomHocPhan", "ID_nhom_hp", "Ten_nhom")
        FillCombo(cmbID_nhom, dt)
        LoaderCombobox = True
    End Sub

    Private Function CheckData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        'If cmbID_he.Text.Trim = "" Then
        '    Call SetErrPro(cmbID_he, ErrorProvider1, "Bạn hãy chọn hệ !")
        '    If CtrlErr Is Nothing Then CtrlErr = cmbID_he
        'End If
        'If cmbID_nhom.Text.Trim = "" Then
        '    Call SetErrPro(cmbID_nhom, ErrorProvider1, "Bạn hãy chọn nhóm học phần !")
        '    If CtrlErr Is Nothing Then CtrlErr = cmbID_nhom
        'End If
        If txtKy_hieu.Text.Trim = "" Then
            Call SetErrPro(txtKy_hieu, ErrorProvider1, "Bạn hãy nhập ký hiệu học phần !")
            If CtrlErr Is Nothing Then CtrlErr = txtKy_hieu
        End If
        If txtTen_mon.Text = "" Then
            Call SetErrPro(txtTen_mon, ErrorProvider1, "Bạn hãy nhập tên học phần !")
            If CtrlErr Is Nothing Then CtrlErr = txtTen_mon
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckData = False
        CtrlErr.Focus()
    End Function

    Private Sub cmdSave_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckData() Then
            Thoat = False
            Me.Close()
        End If
    End Sub

    Private Sub cmdThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThoat.Click
        Thoat = True
        Me.Close()
    End Sub
End Class