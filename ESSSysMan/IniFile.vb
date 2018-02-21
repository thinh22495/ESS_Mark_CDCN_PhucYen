Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Public Class IniFile
    Public path As String
    <DllImport("kernel32")> Private Shared Function WritePrivateProfileString(ByVal section As String, ByVal key As String, ByVal val As String, ByVal filePath As String) As Long
    End Function
    <DllImport("kernel32")> Private Shared Function GetPrivateProfileString(ByVal section As String, ByVal key As String, ByVal def As String, ByVal retVal As StringBuilder, ByVal size As Integer, ByVal filePath As String) As Integer
    End Function

    Public Sub New(ByVal Path As String)
        Me.path = Path
    End Sub

    Public Sub WriteValue(ByVal section As String, ByVal key As String, ByVal value As String)
        WritePrivateProfileString(section, key, value, Me.path)
    End Sub

    Public Function ReadValue(ByVal section As String, ByVal key As String) As String
        Dim tmp As New StringBuilder(255)
        Dim i As Integer = GetPrivateProfileString(section, key, "", tmp, 255, Me.path)
        Return tmp.ToString()
    End Function
End Class
