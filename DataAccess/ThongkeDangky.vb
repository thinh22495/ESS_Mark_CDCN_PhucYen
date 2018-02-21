'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ThongkeDangky_DataAccess
        Public Function ThongkeSinhvienDangkyTheoLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                para(7) = New SqlParameter("@Dot", Dot)
                Return Connect.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoLop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienDangkyTheoHocPhan(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@Dot", Dot)
                Return Connect.SelectTableSP("PLAN_ThongkeSinhvienDangkyTheoHocphan", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienChuaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                para(7) = New SqlParameter("@Dot", Dot)
                Return Connect.SelectTableSP("PLAN_ThongkeSinhvienChuaDangky", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienDaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_he", ID_he)
                para(3) = New SqlParameter("@ID_khoa", ID_khoa)
                para(4) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(5) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                para(6) = New SqlParameter("@ID_lops", ID_lops)
                para(7) = New SqlParameter("@Dot", Dot)
                Return Connect.SelectTableSP("PLAN_ThongkeSinhvienDaDangky", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

