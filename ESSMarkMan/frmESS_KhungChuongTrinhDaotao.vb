Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects

Public Class frmESS_KhungChuongTrinhDaotao
    Private mID_dt_new As Integer
    Private mclsCTDT As ChuongTrinhDaoTao_Bussines
    Private clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
    Private Loader As Boolean = False
    Public Overloads Sub ShowDialog(ByVal clsCTDT As ChuongTrinhDaoTao_Bussines)
        mclsCTDT = clsCTDT
        Me.ShowDialog()
    End Sub
    Private Sub LoadComboBox()
        Try
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)

            ''Load combobox khoa đào tạo
            'dt = clsLop.Khoa()
            'FillCombo(cmbID_khoa, dt)

            ''Load combobox khoa đào tạo
            'dt = clsLop.Khoa_hoc_By_He
            'FillCombo(cmbKhoa_hoc, dt)

            ''Load combobox chuyên ngành đào tạo
            'dt = clsLop.Chuyen_nganh_dao_tao()
            'FillCombo(cmbID_chuyen_nganh, dt)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Function CheckValidate() As Boolean
        If cmbID_he.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn hệ đào tạo")
            cmbID_he.Focus()
            Return False
        End If
        If cmbID_khoa.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoa đào tạo")
            cmbID_khoa.Focus()
            Return False
        End If
        If cmbKhoa_hoc.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn khoá đào tạo")
            cmbKhoa_hoc.Focus()
            Return False
        End If
        If cmbID_chuyen_nganh.SelectedValue = 0 Then
            Thongbao("Bạn phải chọn chuyên ngành đào tạo")
            cmbID_chuyen_nganh.Focus()
            Return False
        End If
        Return True
    End Function


    Private Sub frmESS_ChuongTrinhDaotaoSaoChep_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load dữ liệu vào ComboBox
        LoadComboBox()
        'Set quyền truy cập chức năng
        SetQuyenTruyCap(cmdSave)
        Loader = True
    End Sub
    Private Sub frmESS_ChuongTrinhDaotaoAdd_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Public ReadOnly Property ID_dt_new() As Integer
        Get
            Return mID_dt_new
        End Get
    End Property
    Public ReadOnly Property ID_he() As Integer
        Get
            Return cmbID_he.SelectedValue
        End Get
    End Property

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged

        Try
            If Not Loader Then Exit Sub
            Dim dvKhoa As DataView
            dvKhoa = clsLop.Khoa().DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            dvKhoa.RowFilter = dk
            FillCombo(cmbID_khoa, dvKhoa)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            Dim dvKhoaHoc As DataView
            dvKhoaHoc = clsLop.Khoa_hoc.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            dvKhoaHoc.RowFilter = dk
            FillCombo(cmbKhoa_hoc, dvKhoaHoc)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            Dim dvCN As DataView
            dvCN = clsLop.Chuyen_nganh_dao_tao().DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbID_chuyen_nganh.SelectedValue > 0 Then dk += " and ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
            dvCN.RowFilter = dk
            FillCombo(cmbID_chuyen_nganh, dvCN)

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub


    Private Sub mnuClose_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)

    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If CheckValidate() Then
            If mclsCTDT.CheckExist_ChuongTrinhDaoTao(cmbID_he.SelectedValue, cmbID_khoa.SelectedValue, cmbKhoa_hoc.SelectedValue, cmbID_chuyen_nganh.SelectedValue, cmbSo.SelectedValue) = 0 Then
                Dim objCTDT As New ESSChuongTrinhDaoTao
                objCTDT.ID_he = cmbID_he.SelectedValue
                objCTDT.ID_khoa = cmbID_khoa.SelectedValue
                objCTDT.Khoa_hoc = cmbKhoa_hoc.SelectedValue
                objCTDT.ID_chuyen_nganh = cmbID_chuyen_nganh.SelectedValue

                objCTDT.Ten_he = cmbID_he.Text
                objCTDT.Ten_khoa = cmbID_khoa.Text
                objCTDT.Chuyen_nganh = cmbID_chuyen_nganh.Text
                objCTDT.So = cmbSo.Text

                'Insert vao Database
                mID_dt_new = mclsCTDT.ThemMoi_ESSChuongTrinhDaoTao(objCTDT)
                'Insert vao object
                objCTDT.ID_dt = ID_dt_new
                mclsCTDT.Add(objCTDT)
                Me.Tag = "1"
                Me.Close()
            Else
                Thongbao("Chương trình đào tạo này đã tồn tại, bạn không thể tạo được")
            End If
        End If
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Tag = "0"
        Me.Close()
    End Sub
End Class