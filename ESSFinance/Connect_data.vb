'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 14/04/2010
'---------------------------------------------------------------------------
Imports System.IO
Imports ESS.Bussines
Public Class Connect_data
    Function ConnectDatabase() as Boolean 
        Try
            Dim strFileName As String = Path.GetDirectoryName(Application.ExecutablePath).ToLower() & "\ESSSoftSetup.ini"
            If File.Exists(strFileName) = True Then
                Dim ini As New IniFile(strFileName)
                Dim ServerName, DatabaseName As String
                Dim sConnString As String
                Dim DBType As Integer
                DBType = ini.ReadValue("ESSSoft_SERVER", "DBType").Trim
                ServerName = ini.ReadValue("ESSSoft_SERVER", "ServerName").Trim
                DatabaseName = ini.ReadValue("ESSSoft_SERVER", "DatabaseName").Trim
                If DBType = DatabaseType.SQLServer Then
                    sConnString = "Data Source=" + ServerName + ";" _
                                + "Initial Catalog=" + DatabaseName + ";" _
                                + "User Id=" + gUserName + ";" _
                                + "Password=" + gPassWord
                Else
                    sConnString = "Data Source=" + ServerName + ";User Id=" + DatabaseName + ";Password=" + gPassWord
                End If
                'Ket noi CSDL
                Dim objConnect As New Connect_data_Bussines()
                If Not objConnect.ConnectDatabase(sConnString, DBType) Then
                    Return False
                End If
            Else
                Thongbao("Không tìm thấy file ESSSoftSetup.ini trong thư mục chạy", MsgBoxStyle.Critical)
                Return False
            End If
            Return True
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
End Class
