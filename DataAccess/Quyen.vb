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
Imports ESS.Objects
Namespace DataAccess
    Public Class Quyen_DataAccess
        Public Function HienThi_ESSQuyen_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("SYS_VaiTroQuyen_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhanHe_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("SYS_PhanHe_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSUsersQuyen_DanhSach(ByVal UserID As Integer, ByVal ID_Vai_Tro As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_Vai_Tro", ID_Vai_Tro)
                Return Connect.SelectTableSP("sp_htUsersQuyen1_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

