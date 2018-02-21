Imports System
Imports System.Net
Imports System.IO
Module mdlCheckVersion
    Function UCheckVersion() As String
        Dim URL, VersionID_old, VersionID_new As String
        Dim No_Proxy, Proxy_Name, Proxy_Port, Proxy_UserID, Proxy_Pass As String
        Dim f_server As String = AppDomain.CurrentDomain.BaseDirectory + "ESSoftSetupServer.ini"
        Dim f_client As String = AppDomain.CurrentDomain.BaseDirectory + "ESSSoftSetup.ini"
        Try
            Dim ini1 As New IniFile(f_client)
            URL = ini1.ReadValue("ESSOFT_UPDATE", "URL")
            VersionID_old = ini1.ReadValue("ESSOFT_UPDATE", "VersionID")
            'Get Proxy Infor
            No_Proxy = ini1.ReadValue("ESSOFT_UPDATE", "No_Proxy")
            Proxy_Name = ini1.ReadValue("ESSOFT_UPDATE", "Proxy_Name")
            Proxy_Port = ini1.ReadValue("ESSOFT_UPDATE", "Proxy_Port")
            Proxy_UserID = ini1.ReadValue("ESSOFT_UPDATE", "Proxy_UserID")
            Proxy_Pass = ini1.ReadValue("ESSOFT_UPDATE", "Proxy_Pass")

            Dim dl As New HttpDownload.HttpDownload(URL + "/ESSoftSetupServer.ini", f_server, No_Proxy, Proxy_Name, Proxy_Port, Proxy_UserID, Proxy_Pass)
            Do
                dl.Download()
            Loop Until dl.Download_complete
            Dim ini2 As New IniFile(f_server)
            VersionID_new = ini2.ReadValue("ESSOFT_UPDATE", "VersionID")
            File.Delete(f_server)
            If CType("0" + VersionID_new, Integer) > CType("0" + VersionID_old, Integer) Then
                Shell(AppDomain.CurrentDomain.BaseDirectory.ToString + "ESSAutoUpdate.exe", AppWinStyle.NormalFocus)
                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            Return ex.Message()
        End Try
    End Function
End Module

