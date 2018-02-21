'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 10, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class GiangVienMonDay_Bussines
        Inherits ESSGiangVienMonDay

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSGiangVienMonDay(ByVal objGiangVienMonDay As ESSGiangVienMonDay) As Integer
            Try
                Dim obj As GiangVienMonDay_DataAccess = New GiangVienMonDay_DataAccess
                Return obj.ThemMoi_ESSGiangVienMonDay(objGiangVienMonDay)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSGiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Integer
            Try
                Dim obj As GiangVienMonDay_DataAccess = New GiangVienMonDay_DataAccess
                Return obj.Xoa_ESSGiangVienMonDay(ID_cb, ID_mon, ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Boolean
            Try
                Dim obj As GiangVienMonDay_DataAccess = New GiangVienMonDay_DataAccess
                Return obj.CheckExist_GiangVienMonDay(ID_cb, ID_mon, ID_bm)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drGiangVienMonDay As DataRow) As ESSGiangVienMonDay
            Dim result As ESSGiangVienMonDay
            Try
                result = New ESSGiangVienMonDay
                If drGiangVienMonDay("ID_cb").ToString() <> "" Then result.ID_cb = CType(drGiangVienMonDay("ID_cb").ToString(), Integer)
                If drGiangVienMonDay("ID_mon").ToString() <> "" Then result.ID_mon = CType(drGiangVienMonDay("ID_mon").ToString(), Integer)
                If drGiangVienMonDay("ID_bm").ToString() <> "" Then result.ID_bm = CType(drGiangVienMonDay("ID_bm").ToString(), Integer)
                result.Ky_hieu = drGiangVienMonDay("Ky_hieu").ToString()
                result.Ten_mon = drGiangVienMonDay("Ten_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
