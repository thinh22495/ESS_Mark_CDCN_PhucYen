Imports System.Drawing.Drawing2D
Imports ESS.Objects
Imports ESS.Bussines
Imports ESSUtility

Public Class frmESS_Users
#Region " Var1"
    Private _users As Users_Bussines
    Private _data_load As Boolean
    Private Pass_old As String = ""
#End Region
    Private mUserName As String = ""
#Region " Form Event"
    Public Overloads Sub ShowDialog(ByVal UserName As String, ByVal users As Users_Bussines)
        mUserName = UserName
        _users = users
        Me.ShowDialog()
    End Sub

    Private Sub frmESS_Users_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete Then Call HandleCombo_Delkey(Me)
    End Sub
    Private Sub frmESS_Users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Tag = 1 Then
            HienThi_ESSdata()
            Dim guser As ESSUsers = _users.Tim_UserName(mUserName)
            Me.txtFullname.Text = guser.FullName.ToString
            Me.txtUserName.Text = guser.UserName.ToString
            Me.txtPassWord.Text = guser.PassWord.ToString
            Pass_old = txtPassWord.Text.Trim
            Me.txtPassWordTry.Text = guser.PassWord.ToString
            Me.txtDien_Thoai.Text = guser.Dien_thoai.ToString
            Me.txtIP.Text = guser.May_tram.ToString
            Me.txtMAC.Text = guser.MAC.ToString
            Me.txtEmail.Text = guser.Email.ToString
            Me.cmbNhom.SelectedIndex = guser.UserGroup
            If guser.Active = 1 Then
                rbKich_hoat.Checked = True
                rbKhong_Kich_Hoat.Checked = False
            Else
                rbKich_hoat.Checked = False
                rbKhong_Kich_Hoat.Checked = True
            End If
            If CInt(guser.ID_phong) > 0 Then
                optPhong.Checked = True
                Me.cmbID_phong.Enabled = True
                Me.cmbID_phong.SelectedValue = guser.ID_phong
            End If
            If CInt(guser.ID_khoa) > 0 Then
                optKhoa.Checked = True
                Me.cmbID_khoa.Enabled = True
                Me.cmbID_khoa.SelectedValue = guser.ID_khoa
            End If
            If CInt(guser.ID_Bomon) > 0 Then
                'optBo_mon.Checked = True
                'Me.cmbID_bm.Enabled = True
                Me.cmbID_bm.SelectedValue = guser.ID_Bomon
            End If
        ElseIf Tag = 0 Then
            HienThi_ESSdata()
            Me.txtFullname.Text = ""
            Me.txtUserName.Text = ""
            Me.txtPassWord.Text = "123"
            Me.txtPassWordTry.Text = "123"
            Me.txtDien_Thoai.Text = ""
            Me.txtEmail.Text = ""
            Me.txtIP.Text = ""
            Me.txtMAC.Text = ""
            If optPhong.Checked Then
                Me.cmbID_phong.Text = ""
                Me.cmbID_phong.Enabled = True
            End If
            rbKich_hoat.Checked = False
            rbKhong_Kich_Hoat.Checked = False
        End If

    End Sub
    Private Sub frmESS_Users_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
#End Region
#Region " Control Events"
    Private Sub optKhoa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optKhoa.CheckedChanged, optPhong.CheckedChanged
        If optKhoa.Checked Then
            Me.cmbID_khoa.Enabled = True
        Else
            Me.cmbID_khoa.Enabled = False
        End If
        'If optBo_mon.Checked Then
        '    Me.cmbID_bm.Enabled = True
        'Else
        '    Me.cmbID_bm.Enabled = False
        'End If
        If optPhong.Checked Then
            Me.cmbID_phong.Enabled = True
        Else
            Me.cmbID_phong.Enabled = False
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If Tag = 1 Then
                Dim guser As ESSUsers = _users.Tim_UserName(mUserName)

                guser.UserName = Me.txtUserName.Text
                guser.FullName = Me.txtFullname.Text
                If Pass_old = txtPassWord.Text.Trim Then
                    guser.PassWord = Pass_old
                Else
                    guser.PassWord = XCrypto.MD5(Me.txtPassWord.Text)
                End If
                If cmbID_khoa.Enabled Then
                    guser.ID_khoa = Me.cmbID_khoa.SelectedValue
                Else
                    guser.ID_khoa = 0
                End If
                If cmbID_phong.Enabled Then
                    guser.ID_phong = Me.cmbID_phong.SelectedValue
                Else
                    guser.ID_phong = 0
                End If
                If cmbID_bm.Enabled Then
                    guser.ID_Bomon = Me.cmbID_bm.SelectedValue
                Else
                    guser.ID_Bomon = 0
                End If
                guser.UserGroup = Me.cmbNhom.SelectedIndex
                guser.Dien_thoai = Me.txtDien_Thoai.Text
                guser.Email = Me.txtEmail.Text
                guser.May_tram = Me.txtIP.Text
                guser.MAC = Me.txtMAC.Text
                If rbKich_hoat.Checked Then
                    guser.Active = 1
                Else
                    guser.Active = 0
                End If
                If Check_Values(guser) = False Then Exit Sub
                If Thongbao("Bạn chắc chắn muốn thay đổi User " & guser.UserName & " không? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    _users.CapNhat_ESSUsers(guser, guser.UserID)
                    Thongbao("Đã thay đổi thành công", MsgBoxStyle.OkOnly)
                End If

            ElseIf Tag = 0 Then
                Dim guser As New ESSUsers

                guser.UserName = Me.txtUserName.Text
                guser.FullName = Me.txtFullname.Text
                guser.PassWord = XCrypto.MD5(Me.txtPassWord.Text)
                guser.ID_khoa = Me.cmbID_khoa.SelectedValue
                guser.ID_phong = Me.cmbID_phong.SelectedValue
                guser.ID_Bomon = Me.cmbID_bm.SelectedValue
                guser.UserGroup = CInt(Me.cmbNhom.SelectedIndex)
                guser.Dien_thoai = Me.txtDien_Thoai.Text
                guser.Email = Me.txtEmail.Text
                guser.May_tram = Me.txtIP.Text
                guser.MAC = Me.txtMAC.Text
                If rbKich_hoat.Checked Then
                    guser.Active = 1
                Else
                    guser.Active = 0
                End If
                If Check_Values(guser) = False Then Exit Sub
                If Thongbao("Bạn chắc chắn muốn thêm User " & guser.UserName & " không? ", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    guser.UserID = _users.ThemMoi_ESSUsers(guser)
                    _users.Add(guser)
                    Thongbao("Đã thêm mới thành công", MsgBoxStyle.OkOnly)
                End If
            End If
            Me.Close()
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try

    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
#End Region
#Region " User Functions"

    Sub HienThi_ESSdata()
        FillCombo(Me.cmbID_khoa, _users.HienThi_ESSUsersKhoa(gobjUser))
        FillCombo(Me.cmbID_phong, _users.HienThi_ESSPhong_DanhSach(gobjUser))
        FillCombo(Me.cmbID_bm, _users.HienThi_ESSBomon_DanhSach(gobjUser))
    End Sub

    Private Function Check_Text() As Boolean
        If Me.txtUserName.Text.Trim = "" Then
            Return False
        End If
        If Me.txtPassWord.Text.Trim = "" Then
            Return False
        End If
        If Me.txtPassWordTry.Text.Trim = "" Then
            Return False
        End If
        If Me.txtFullname.Text.Trim = "" Then
            Return False
        End If
        If Me.cmbNhom.Text.Trim = "" Then
            Return False
        End If
        If Me.cmbID_phong.Text.Trim = "" And Me.cmbID_khoa.Text.Trim = "" And Me.cmbID_bm.Text.Trim = "" Then
            Return False
        End If
        If Me.rbKich_hoat.Checked = False And Me.rbKhong_Kich_Hoat.Checked = False Then
            Return False
        End If
        Return True
    End Function
    Private Function Check_Exist_Insert(ByVal UserName As String) As Boolean
        If _users.CheckExist_Users(UserName) Then
            Return True
        End If
        Return False
    End Function
    Private Function Check_Exist_Update(ByVal UserName As String, ByVal UserID As Integer) As Boolean
        If _users.CheckExist_Users(UserName, UserID) Then
            Return True
        End If
        Return False
    End Function
    Private Function Check_Values(ByVal User As ESSUsers) As Boolean
        If Check_Text() = False Then
            Thongbao("Bạn cần nhập đầy đủ thông tin ở các ô đánh dấu đỏ", MsgBoxStyle.Information)
            Return False
        End If
        If Me.txtPassWord.Text.Trim <> Me.txtPassWordTry.Text.Trim Then
            Thongbao("Mật khẩu xác nhận chưa đúng", MsgBoxStyle.Information)
            Return False
        End If
        Select Case Tag.ToString
            Case 0
                If Check_Exist_Insert(User.UserName) Then
                    Thongbao("UserName nay đã tồn tại rồi", MsgBoxStyle.Information)
                    Return False
                End If
            Case 1
                If Check_Exist_Update(User.UserName, User.UserID) Then
                    Thongbao("UserName nay đã tồn tại rồi", MsgBoxStyle.Information)
                    Return False
                End If
        End Select
        Return True
    End Function
#End Region


    Private Sub txtIP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIP.Leave
        Try
            If txtIP.Text.Trim.Length <= 10 Then Exit Sub
            txtMAC.Text = GetMacAddress(txtIP.Text.Trim)
        Catch ex As Exception
        End Try
    End Sub
    Private Function GetMacAddress(ByVal IP As String) As String
        Dim MacAddress As String
        Try
            Dim temp As String = ""
            Dim info As New ProcessStartInfo
            Dim process1 As New Process
            info.FileName = "nbtstat"
            info.RedirectStandardInput = False
            info.RedirectStandardOutput = True
            info.Arguments = "-A " + IP
            info.UseShellExecute = False
            process1 = Process.Start(info)
            Dim num As Integer = -1
            While (num <= -1)
                num = temp.Trim().ToLower().IndexOf("mac address", 0)
                If num > -1 Then
                    Exit While
                End If
                temp = process1.StandardOutput.ReadLine()
            End While
            process1.WaitForExit()
            MacAddress = temp.Trim()
            Return MacAddress.Substring(14, 17)
        Catch ex As Exception
            Thongbao("Hãy kiểm tra địa chỉ IP !", MsgBoxStyle.Exclamation)
        End Try
    End Function
End Class