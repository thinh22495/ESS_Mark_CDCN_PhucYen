'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ToaNha_Bussines
        Private arrToaNha As ArrayList

#Region "Initialize"
        Public Sub New()
            'Add tat ca Chuc vu
            Try
                arrToaNha = New ArrayList
                Dim objToaNha_dal As New ToaNha_DataAccess
                Dim dt As DataTable = objToaNha_dal.HienThi_ESSToaNha_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objToaNha As New ESSToaNha
                        objToaNha = Mapping(dt.Rows(i))
                        arrToaNha.Add(objToaNha)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhMucToaNha() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_nha", GetType(Integer))
                dt.Columns.Add("Ten_nha", GetType(String))
                For i As Integer = 0 To arrToaNha.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objToaNha As ESSToaNha = CType(arrToaNha(i), ESSToaNha)
                    row("ID_nha") = objToaNha.ID_nha
                    row("Ten_nha") = objToaNha.Ten_nha
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSToaNha(ByVal objToaNha As ESSToaNha) As Integer
            Try
                Dim obj As ToaNha_DataAccess = New ToaNha_DataAccess
                Return obj.ThemMoi_ESSToaNha(objToaNha)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToaNha(ByVal ID_nha As Integer) As Integer
            Try
                Dim obj As ToaNha_DataAccess = New ToaNha_DataAccess
                Return obj.Xoa_ESSToaNha(ID_nha)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drToaNha As DataRow) As ESSToaNha
            Dim result As ESSToaNha
            Try
                result = New ESSToaNha
                If drToaNha("ID_nha").ToString() <> "" Then result.ID_nha = CType(drToaNha("ID_nha").ToString(), Integer)
                If drToaNha("ID_co_so").ToString() <> "" Then result.ID_co_so = CType(drToaNha("ID_co_so").ToString(), Integer)
                result.Ma_nha = drToaNha("Ma_nha").ToString()
                result.Ten_nha = drToaNha("Ten_nha").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
