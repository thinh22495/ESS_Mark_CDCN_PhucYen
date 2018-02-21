'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Namespace DataAccess
    Public Class ReportView_DataAccess
        Public Function HienThi_ESSReport_Note(ByVal ReportName As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ReportName", ReportName)
                Return Connect.SelectTableSP("SYS_BaoCao_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

