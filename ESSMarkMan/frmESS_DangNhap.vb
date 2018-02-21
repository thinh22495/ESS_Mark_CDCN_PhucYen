Imports System.Management
Imports System.Net
Imports System.Drawing.Drawing2D
Imports DevExpress.XtraBars.Ribbon
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_DangNhap


#Region "Form Event"
    Private Sub frmESS_Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtUserName.Focus()
    End Sub
    Private Sub frmESS_Login_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_Login_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then Call HandleNextTAB(Me)
    End Sub
#End Region
    Public Sub gUser(ByVal u As ESSUsers)
        gobjUser = u
    End Sub
#Region "ToolBar Event"

    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click
        Try
            If txtUserName.Text.Trim().Equals("") Then
                Thongbao("Bạn phải nhập tên đăng nhập !")
                Me.txtUserName.Focus()
            ElseIf txtPassWord.Text.Trim().Equals("") Then
                Thongbao("Bạn phải nhập mật khẩu !")
                Me.txtPassWord.Focus()
            Else
                Dim UserName, PassWord As String
                UserName = txtUserName.Text
                PassWord = txtPassWord.Text

                'Kết nối CSDL
                Dim clsConnect As New Connect_data()
                If clsConnect.ConnectDatabase Then
                    Dim ldapCheck As Boolean = False
                    'Load User
                    Dim clsUser As New Users_Bussines(gID_ph, UserName)
                    'Gán object User vào biến toàn cục gobjUser
                    If clsUser.Count > 0 Then
                        gobjUser = clsUser.Users(0)
                    End If
                    If gobjUser.UserID > 0 Then
                        If Not clsUser.CheckUser(ldapCheck, gobjUser, PassWord) Then
                            Thongbao("Mật khẩu không đúng, nhập mật khẩu khác !")
                        Else
                            'If Not clsUser.CheckMyComputer(gobjUser.UserID, GetIPAddress, GetMacAddress) Then
                            '    Thongbao("Địa chỉ IP hoặc địa chỉ Mac không phù hợp !", MsgBoxStyle.OkOnly)
                            '    Exit Sub
                            'End If
                            Me.Tag = 1
                            'Save Log 
                            Dim Noi_dung_Add As String = ""
                            Noi_dung_Add = "Người dùng: " & gobjUser.UserName & " - đăng nhập vào hệ thống "
                            SaveLog(LoaiSuKien.Them, Noi_dung_Add)
                            GetReportHeader()
                            Me.Close()
                        End If
                    Else
                        Thongbao("Không tồn tại tên đăng nhập này, hãy nhập tên đăng nhập khác !")
                    End If
                Else
                    Thongbao("Không kết nối được đến CSDL, bạn hãy thiết lập lại kết nối !", MsgBoxStyle.Critical)
                End If
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Private Sub cmdClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub cmdConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdConfig.Click
        Dim frmESS_ As New frmESS_CauHinhKetNoi
        frmESS_.ShowDialog()
    End Sub




    Private Function GetMacAddress() As String
        Try
            Dim strMACAddress As String = ""
            Dim strQuery As String = "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"

            Dim query As ManagementObjectSearcher = New ManagementObjectSearcher(strQuery)
            Dim queryCollection As ManagementObjectCollection = query.Get()
            Dim mo As ManagementObject

            For Each mo In queryCollection
                strMACAddress = mo("MacAddress").ToString().Replace(":", "-")
                Exit For
            Next
            Return strMACAddress.Trim

        Catch ex As Exception
            Return ""
        End Try
    End Function
    Private Function GetIPAddress() As String
        Dim IP_Address As String
        Try
            Dim h As IPHostEntry = Dns.GetHostByName(System.Net.Dns.GetHostName)
            IP_Address = CType(h.AddressList.GetValue(0), IPAddress).ToString
            Return IP_Address
        Catch ex As Exception
        End Try
    End Function
#End Region
#Region "Control Event"
    Private Sub txtPassWord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassWord.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.cmdLogin_Click(cmdLogin, e)
    End Sub
#End Region



End Class