'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 09, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class GiangVienMonDay_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSGiangVienMonDay(ByVal ID_cb As Integer, Optional ByVal ID_bm As Integer = 0, Optional ByVal ID_mon As Integer = 0) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", ID_mon)
                para(1) = New SqlParameter("@ID_bm", ID_bm)
                para(2) = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.SelectTableSP("PLAN_GiaoVienMonDay_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSGiangVienMonDay(ByVal obj As ESSGiangVienMonDay) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(1) = New SqlParameter("@ID_bm", obj.ID_bm)
                para(2) = New SqlParameter("@ID_cb", obj.ID_cb)
                Return Connect.ExecuteSP("PLAN_GiaoVienMonDay_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSGiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_bm", ID_bm)
                Return Connect.ExecuteSP("PLAN_GiaoVienMonDay_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_GiangVienMonDay(ByVal ID_cb As Integer, ByVal ID_mon As Integer, ByVal ID_bm As Integer) As Boolean
            Try
                Dim dt As DataTable
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                para(2) = New SqlParameter("@ID_bm", ID_bm)
                dt = Connect.SelectTableSP("PLAN_GiaoVienMonDay_KiemTraTonTai", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

