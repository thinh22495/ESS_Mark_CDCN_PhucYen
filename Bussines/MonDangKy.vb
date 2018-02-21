'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, August 12, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class MonDangKy_Bussines
        Private arrMonDangKy As ArrayList
#Region "Initialize"
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSMonDangKy(ByVal objMonDangKy As ESSMonDangKy) As Integer
            Try
                Dim obj As MonDangKy_DataAccess = New MonDangKy_DataAccess
                Return obj.ThemMoi_ESSMonDangKy(objMonDangKy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSMonDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As MonDangKy_DataAccess = New MonDangKy_DataAccess
                Return obj.Xoa_ESSMonDangKy(Hoc_ky, Nam_hoc, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
