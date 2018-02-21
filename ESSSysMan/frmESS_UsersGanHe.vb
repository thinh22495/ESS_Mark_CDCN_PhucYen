Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Public Class frmESS_VaiTroGanLop
#Region "Var"
    Private _users As Users_Bussines
    Private _data_load As Boolean = False
    Private dtlopAccess As New DataTable

#End Region
    Private mUserName As String = ""
#Region "Form Event"
    Private Sub frmESS_VaiTroGanLop_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_VaiTroGanLop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetUpDataGridView(Me.grdLopAccess)
        'HienThi_ESSData()
        Me.grdLopAccess.DataSource = _users.HienThi_ESSUsersHeAccessGan(mUserName).DefaultView
        Fill_Combo()
        _data_load = True
    End Sub
    Private Sub frmESS_VaiTroGanLop_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub

    Public Overloads Sub ShowDialog(ByVal UserName As String, ByVal users As Users_Bussines)
        mUserName = UserName
        _users = users
        Me.ShowDialog()
    End Sub
#End Region

#Region "Control Events"
    '' Thêm đi 1 lớp cho User
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Dim guser As ESSUsers = _users.Tim_UserName(mUserName)
        Dim UsersHe As New ESSUsersHeAcess
        UsersHe.ID_he = Me.cmbID_he.SelectedValue
        UsersHe.Ten_he = Me.cmbID_he.Text
        UsersHe.ID_khoa = Me.cmbID_khoa.SelectedValue
        UsersHe.Ten_khoa = Me.cmbID_khoa.Text
        UsersHe.Khoa_hoc = Me.cmbKhoa_hoc.SelectedValue
        UsersHe.ID_nganh = Me.cmbID_nganh.SelectedValue
        UsersHe.Ten_nganh = Me.cmbID_nganh.Text
        UsersHe.ID_chuyen_nganh = Me.cmbID_chuyen_nganh.SelectedValue
        UsersHe.Chuyen_nganh = Me.cmbID_chuyen_nganh.Text
        ''Kiểm tra xem lớp đó đã có chưa?
        If _users.KiemTra_UserLopAccess1(UsersHe, mUserName) Then
            Thongbao(" Đã tồn tại rồi", MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        guser.HeAccess.Add(UsersHe)
        Me.grdLopAccess.DataSource = _users.HienThi_ESSUsersHeAccessGan(mUserName).DefaultView
    End Sub

    '' Bớt đi 1 lớp cho User
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim guser As ESSUsers = _users.Tim_UserName(mUserName)
        If Thongbao("Bạn chắc chắn muốn xóa không ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
            guser.HeAccess.Remove(grdLopAccess.CurrentRow.Index)
            Me.grdLopAccess.DataSource = _users.HienThi_ESSUsersHeAccessGan(mUserName).DefaultView
        End If

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    ''Lưu lại các thay đổi
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            Dim dv As DataView = grdLopAccess.DataSource
            Dim dt As DataTable = dv.Table
            Dim i As Integer
            If Thongbao("Bạn thực sự muốn thay đôi chứ? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                Dim guser As ESSUsers = _users.Tim_UserName(mUserName)
                '' Remove các quyền của vai tro
                If Not guser.HeAccess Is Nothing Then
                    For i = guser.HeAccess.Count - 1 To 0 Step -1
                        guser.HeAccess.Remove(i)
                    Next
                End If

                _users.Xoa_ESSUsersHeAccess(guser.UserID)

                '' Add các vai tro cua User
                For i = 0 To dt.Rows.Count - 1
                    Dim usersHeAcess As New ESSUsersHeAcess
                    usersHeAcess.ID_he = CInt(dt.Rows(i)("ID_he"))
                    usersHeAcess.Ten_he = CStr(dt.Rows(i)("Ten_he"))
                    usersHeAcess.ID_khoa = CInt(dt.Rows(i)("ID_khoa"))
                    usersHeAcess.Ten_khoa = CStr(dt.Rows(i)("Ten_khoa"))
                    usersHeAcess.ID_nganh = CInt(dt.Rows(i)("ID_nganh"))
                    usersHeAcess.Ten_nganh = CStr(dt.Rows(i)("Ten_nganh"))
                    usersHeAcess.ID_chuyen_nganh = CInt(dt.Rows(i)("ID_chuyen_nganh"))
                    usersHeAcess.Chuyen_nganh = CStr(dt.Rows(i)("Chuyen_nganh"))
                    usersHeAcess.Khoa_hoc = CInt(dt.Rows(i)("Khoa_hoc"))
                    guser.HeAccess.Add(usersHeAcess)
                Next
                _users.ThemMoi_ESSUsersHeAccess(guser.UserName)
                Thongbao("Đã thay đổi thành công ! ", MsgBoxStyle.OkOnly)
            End If

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_nganh_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_nganh.SelectedIndexChanged
        'If _data_load = False Then Exit Sub
        'FillCombo(Me.cmbID_chuyen_nganh, _users.HienThi_ESSUsersChuyenNganh(gobjUser, cmbID_nganh.SelectedValue))
        Try

            If Not _data_load Then Exit Sub
            ' Load combo khoa
            Dim dvCN As DataView
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvCN = clsLop.Chuyen_nganh_dao_tao.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            If cmbID_nganh.SelectedValue > 0 Then dk += " and ID_nganh=" & cmbID_nganh.SelectedValue
            dvCN.RowFilter = dk
            FillCombo(cmbID_chuyen_nganh, dvCN)

            Dim dv As DataView = grdLopAccess.DataSource
            dv.RowFilter = dk

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbID_he_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_he.SelectedIndexChanged
        'If _data_load = False Then Exit Sub
        'Dim strFilter As String = ""
        'Dim dv As DataView = grdLopAccess.DataSource
        'If cmbID_he.Text <> "" Then
        '    strFilter = "ID_He=" & cmbID_he.SelectedValue
        'End If
        'If cmbID_khoa.Text <> "" Then
        '    If strFilter <> "" Then
        '        strFilter += " AND ID_khoa=" & cmbID_khoa.SelectedValue
        '    Else
        '        strFilter = "ID_khoa=" & cmbID_khoa.SelectedValue
        '    End If

        'End If
        'If cmbKhoa_hoc.Text <> "" Then
        '    If strFilter <> "" Then
        '        strFilter += " AND Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
        '    Else
        '        strFilter = "Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
        '    End If

        'End If
        'If cmbID_nganh.Text <> "" Then
        '    If strFilter <> "" Then
        '        strFilter += " AND ID_nganh=" & cmbID_nganh.SelectedValue
        '    Else
        '        strFilter = "ID_nganh=" & cmbID_nganh.SelectedValue

        '    End If
        'End If
        'If cmbID_chuyen_nganh.Text <> "" Then
        '    If strFilter <> "" Then
        '        strFilter += " AND ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
        '    Else
        '        strFilter = "ID_chuyen_nganh=" & cmbID_chuyen_nganh.SelectedValue
        '    End If

        'End If
        'dv.RowFilter = strFilter.ToString

        Try
            If Not _data_load Then Exit Sub

            ' Load combo khoa
            Dim dvKhoa As DataView
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvKhoa = clsLop.Khoa.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            dvKhoa.RowFilter = dk
            FillCombo(cmbID_khoa, dvKhoa)

            Dim dv As DataView = grdLopAccess.DataSource
            dv.RowFilter = dk


        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmbID_khoa_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_khoa.SelectedIndexChanged
        Try

            If Not _data_load Then Exit Sub
            ' Load combo khoa
            Dim dvKhoaHoc As DataView
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvKhoaHoc = clsLop.Khoa_hoc.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            dvKhoaHoc.RowFilter = dk
            FillCombo(cmbKhoa_hoc, dvKhoaHoc)

            Dim dv As DataView = grdLopAccess.DataSource
            dv.RowFilter = dk


        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmbKhoa_hoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKhoa_hoc.SelectedIndexChanged
        Try
            If Not _data_load Then Exit Sub
            ' Load combo khoa
            Dim dvN As DataView
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            dvN = clsLop.Nganh_dao_tao.DefaultView
            Dim dk As String = "1=1"
            If cmbID_he.SelectedValue > 0 Then dk += " and ID_he=" & cmbID_he.SelectedValue
            If cmbID_khoa.SelectedValue > 0 Then dk += " and ID_khoa=" & cmbID_khoa.SelectedValue
            If cmbKhoa_hoc.SelectedValue > 0 Then dk += " and Khoa_hoc=" & cmbKhoa_hoc.SelectedValue
            dvN.RowFilter = dk
            FillCombo(cmbID_nganh, dvN)

            Dim dv As DataView = grdLopAccess.DataSource
            dv.RowFilter = dk

        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub



#End Region

#Region "User Functions"
    'Private Sub Fill_Combo() '' Load dữ liệu vào các combobox
    '    FillCombo(Me.cmbID_he, _users.HienThi_ESSUsersHe(gobjUser))
    '    FillCombo(Me.cmbID_khoa, _users.HienThi_ESSUsersKhoa(gobjUser))
    '    FillCombo(Me.cmbID_nganh, _users.HienThi_ESSUsersNganh(gobjUser))
    '    FillCombo(Me.cmbID_chuyen_nganh, _users.HienThi_ESSUsersChuyenNganh(gobjUser))
    '    FillCombo(Me.cmbKhoa_hoc, _users.HienThi_ESSUsersKhoa_hoc(gobjUser))

    'End Sub

    Private Sub Fill_Combo()
        Try
            Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, -1, -1, 1)
            Dim dt As New DataTable
            'Load combobox Hệ đào tạo
            dt = clsLop.He_dao_tao()
            FillCombo(cmbID_he, dt)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub HienThi_ESSData() '' Load dữ liệu cho toàn bộ Form
        Fill_Combo()
        Me.grdLopAccess.DataSource = _users.HienThi_ESSUsersHeAccessGan(mUserName).DefaultView
    End Sub
#End Region





End Class