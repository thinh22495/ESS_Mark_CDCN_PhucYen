Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Imports System.IO
Namespace DataAccess
    Public Class ChuyenDuLieu_DataAccess
        Public Sub New()

        End Sub
        Public Function LoadHoSoTemp(ByVal UserID As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("STU_LoadHoSoSinhVienTemp", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadCauTrucHoSoSinhVien() As DataTable
            Try
                Return Connect.SelectTableSP("STU_LoadCauTrucHoSoSinhVien")
            Catch ex As Exception
                Throw ex
            End Try
        End Function '
        Public Function getDataSource(ByVal TableName As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@TableName", TableName)
                Return Connect.SelectTableSP("STU_GetDataSource", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDMTables(ByVal strFields As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@strFields", strFields)
                Return Connect.SelectTableSP("STU_getDMTables", para(0))
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Láy giá trị danh mục
        Public Function getDMValueTen(ByVal DTable As String, ByVal DFieldID As String, ByVal DFieldName As String, ByVal strValue As String) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@DFieldID", DFieldID)
                para(1) = New SqlParameter("@DFieldName", DFieldName)
                para(2) = New SqlParameter("@DTable", DTable)
                para(3) = New SqlParameter("@strValue", strValue)
                Return Connect.SelectTableSP("STU_GetDMValueTen", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDMValueMa(ByVal DTable As String, ByVal DFieldID As String, ByVal DFieldMa As String, ByVal DFieldName As String, ByVal strValue As String) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@DFieldID", DFieldID)
                para(1) = New SqlParameter("@DFieldName", DFieldName)
                para(2) = New SqlParameter("@DTable", DTable)
                para(3) = New SqlParameter("@strValue", strValue)
                para(4) = New SqlParameter("@DFieldMa", DFieldMa)
                Return Connect.SelectTableSP("STU_GetDMValueMa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getColumName_Ma(ByVal DTable As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@DTable", DTable)
                Return Connect.SelectTableSP("STU_GetColumName_Ma", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getColumName_ID(ByVal DTable As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@DTable", DTable)
                Return Connect.SelectTableSP("STU_GetColumName_ID", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


