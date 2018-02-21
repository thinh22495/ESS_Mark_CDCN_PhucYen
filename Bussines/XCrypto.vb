Imports System.Security
Imports System.Security.Cryptography
Namespace Bussines
    Public Class XCrypto
        Private Shared Function HashData(ByVal algo As HashAlgorithm, ByVal data As String) As String
            Dim rawData As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(data)
            Dim result As Byte() = algo.ComputeHash(rawData)
            Return System.Convert.ToBase64String(result, 0, result.Length)
        End Function
        Public Shared Function SHA(ByVal txt As String) As String
            Dim _sha As New SHA1CryptoServiceProvider
            Return HashData(_sha, txt)
        End Function
        Public Shared Function MD5(ByVal txt As String) As String
            Dim _md5 As New MD5CryptoServiceProvider
            Return HashData(_md5, txt)
        End Function
        Public Shared Function SHA256(ByVal txt As String) As String
            Dim _sha256 As New SHA256Managed
            Return HashData(_sha256, txt)
        End Function
        Public Shared Function SHA384(ByVal txt As String) As String
            Dim _sha384 As New SHA384Managed
            Return HashData(_sha384, txt)
        End Function
        Public Shared Function SHA512(ByVal txt As String) As String
            Dim _sha512 As New SHA512Managed
            Return HashData(_sha512, txt)
        End Function
    End Class
End Namespace


