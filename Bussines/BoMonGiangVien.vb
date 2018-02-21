'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, June 05, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BoMonGiangVIen_Bussines

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSBoMonGiangVien(ByVal objBoMonGiangVien As ESSBoMonGiangVien) As Integer
            Try
                Dim obj As BoMonGiangVien_DataAccess = New BoMonGiangVien_DataAccess
                Return obj.ThemMoi_ESSBoMonGiangVien(objBoMonGiangVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As BoMonGiangVien_DataAccess = New BoMonGiangVien_DataAccess
                Return obj.Xoa_ESSBoMonGiangVien(ID_bm, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Boolean
            Try
                Dim obj As BoMonGiangVien_DataAccess = New BoMonGiangVien_DataAccess
                Return obj.CheckExist_BoMonGiangVien(ID_bm, ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
