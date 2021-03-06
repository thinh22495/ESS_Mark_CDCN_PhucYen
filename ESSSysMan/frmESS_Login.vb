﻿Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Public Class frmESS_Login
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

#Region "ToolBar Event"
    Private Sub cmdDangNhap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDangNhap.Click
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
                            Me.Tag = 1
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

    Private Sub cmdThietLap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdThietLap.Click
        Dim frmESS_ As New frmESS_ServerChange
        frmESS_.ShowDialog()
    End Sub

    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Closed, cmdClose.Click
        'Thoát khỏi chương trình
        Close()
    End Sub
    Public Sub gUser(ByVal u As ESSUsers)
        gobjUser = u
    End Sub
#End Region
#Region "Control Event"
    Private Sub txtPassWord_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassWord.KeyPress
        If Asc(e.KeyChar) = 13 Then Me.cmdDangNhap_Click(cmdDangNhap, e)
    End Sub
#End Region
End Class