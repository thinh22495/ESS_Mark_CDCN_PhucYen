Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class PortalLogin_DataAccess
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

        Public Function Login(ByVal UserName As String, ByVal Password As String) As Integer
            Try
                Dim dt As DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_sv", UserName)
                para(1) = New SqlParameter("@Mat_khau", Password)
                dt = Connect.SelectTableSP("SYS_Login", para)
                If dt.Rows.Count = 0 Then
                    Return 0
                Else
                    Return CInt(dt.Rows(0)(0))
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Change_Password(ByVal ID_sv As Integer, ByVal Mat_khau As String) As Integer
            Try
                Dim dt As DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Mat_khau", Mat_khau)
                dt = Connect.SelectTableSP("SYS_Change_Password", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function Change_Password_Canbo(ByVal UserName As String, ByVal Password As String) As Integer
            Try
                Dim dt As DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                para(1) = New SqlParameter("@Password", Password)
                dt = Connect.SelectTableSP("SYS_Change_Password_Canbo", para)
            Catch ex As Exception
            End Try
        End Function
        Public Function HienThi_ESSChuongTrinhDaoTao_DanhSach() As DataTable
            Try
                Dim dt As New DataTable
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class

End Namespace

