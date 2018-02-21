'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ThanhPhanXuatThan_Bussines
        Inherits ESSThanhPhanXuatThan

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load Danh mục Tỉnh
        Public Function HienThi_ESSThanhPhanXuatThan() As DataTable
            Try
                Dim obj As ThanhPhanXuatThan_DataAccess = New ThanhPhanXuatThan_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSThanhPhanXuatThan()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
