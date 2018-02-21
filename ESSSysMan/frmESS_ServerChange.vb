Imports System.Drawing.Drawing2D
Imports System.IO
Imports ESS.Bussines
Public Class frmESS_ServerChange
    Private Sub frmESS_ServerChange_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim strFileName As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower() & "\ESSoftSetup.ini"
        If File.Exists(strFileName) = True Then
            Try
                Dim ini As New IniFile(strFileName)
                txtServerName.Text = ini.ReadValue("ESSoft_SERVER", "ServerName").Trim
                txtDatabaseName.Text = ini.ReadValue("ESSoft_SERVER", "DatabaseName").Trim
                cmbdbType.SelectedIndex = CInt(ini.ReadValue("ESSoft_SERVER", "DBType").Trim)
                txtURL.Text = ini.ReadValue("ESSOFT_UPDATE", "URL").Trim
                If ini.ReadValue("ESSOFT_UPDATE", "No_Proxy").Trim = "0" Then
                    chkProxy.Checked = True
                    CheckStatus(True)
                Else
                    chkProxy.Checked = False
                    CheckStatus(False)
                End If
                txtAddress.Text = ini.ReadValue("ESSOFT_UPDATE", "Proxy_Name").Trim
                txtPort.Text = ini.ReadValue("ESSOFT_UPDATE", "Proxy_Port").Trim
                txtUsername.Text = ini.ReadValue("ESSOFT_UPDATE", "Proxy_Userid").Trim
                txtPass.Text = ini.ReadValue("ESSOFT_UPDATE", "Proxy_Pass").Trim
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Sub frmESS_Config_server_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheck.Click
        Dim cls As New Connect_data
        Dim strFileName As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower() & "\ESSoftSetup.ini"
        'Lưu lại cấu hình thiết lập
        LuuCauHinh(strFileName)
        If cls.ConnectDatabase() Then
            Thongbao("Kết nối thành công đến CSDL !")
            Me.Close()
        Else
            Thongbao("Không kết nối thành công đến CSDL, bạn kiểm tra lại: Tên máy chủ, Tên CSDL, Loại CSDL!", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim strFileName As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower() & "\ESSoftSetup.ini"
        If File.Exists(strFileName) = True Then
            'Lưu lại cấu hình thiết lập
            LuuCauHinh(strFileName)
        Else
            Thongbao("Không có file thiết lập cấu hình ESSoftSetup.ini", MsgBoxStyle.Critical)
        End If
        Thongbao("Đã lưu lại thiết lập cấu hình cài đặt !")
        Me.Close()
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub LuuCauHinh(ByVal strFileName As String)
        Try
            Dim ini As New IniFile(strFileName)
            ini.WriteValue("ESSoft_SERVER", "ServerName", txtServerName.Text)
            ini.WriteValue("ESSoft_SERVER", "DatabaseName", txtDatabaseName.Text)
            ini.WriteValue("ESSoft_SERVER", "DBType", cmbdbType.SelectedIndex)
            ini.WriteValue("ESSOFT_UPDATE", "URL", txtURL.Text)
            If chkProxy.Checked Then
                ini.WriteValue("ESSOFT_UPDATE", "No_Proxy", "0")
                ini.WriteValue("ESSOFT_UPDATE", "Proxy_Name", txtAddress.Text)
                ini.WriteValue("ESSOFT_UPDATE", "Proxy_Port", txtPort.Text)
                ini.WriteValue("ESSOFT_UPDATE", "Proxy_Userid", txtUsername.Text)
                ini.WriteValue("ESSOFT_UPDATE", "Proxy_Pass", txtPass.Text)
            Else
                ini.WriteValue("ESSOFT_UPDATE", "No_Proxy", "1")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProxy.CheckedChanged
        If chkProxy.Checked Then
            CheckStatus(True)
        Else
            CheckStatus(False)
        End If
    End Sub
    Private Sub CheckStatus(ByVal status As Boolean)
        txtAddress.Enabled = status
        txtPort.Enabled = status
        txtUsername.Enabled = status
        txtPass.Enabled = status
    End Sub
End Class