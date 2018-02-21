'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, August 12, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class MonDangKy_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSMonDangKy(ByVal obj As ESSMonDangKy) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_mon", obj.ID_mon)
                para(4) = New SqlParameter("@So_hoc_trinh", obj.So_hoc_trinh)
                para(5) = New SqlParameter("@ID_dt", obj.ID_dt)
                Return Connect.ExecuteSP("PLAN_MonDangKy_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSMonDangKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("PLAN_MonDangKy_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

