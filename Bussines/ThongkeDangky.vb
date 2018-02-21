'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ThongkeDangky_Bussines
        Public Function ThongkeSinhvienDangkyTheoLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim obj As ThongkeDangky_DataAccess = New ThongkeDangky_DataAccess
                Dim dt As DataTable = obj.ThongkeSinhvienDangkyTheoLop(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops, Dot)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienDangkyTheoHocPhan(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim obj As ThongkeDangky_DataAccess = New ThongkeDangky_DataAccess
                Dim dt As DataTable = obj.ThongkeSinhvienDangkyTheoHocPhan(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, Dot)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongkeSinhvienChuaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0) As DataTable
            Try
                Dim obj As ThongkeDangky_DataAccess = New ThongkeDangky_DataAccess
                Dim dt As DataTable = obj.ThongkeSinhvienChuaDangky(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops, Dot)
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i)("STT") = i + 1
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThongkeSinhvienDaDangky(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, Optional ByVal Dot As Integer = 0, Optional ByVal So_hoc_trinh As Integer = 0) As DataTable
            Try
                Dim obj As ThongkeDangky_DataAccess = New ThongkeDangky_DataAccess
                Dim dt As DataTable = obj.ThongkeSinhvienDaDangky(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, ID_lops, Dot)
                dt.DefaultView.RowFilter = "So_hoc_trinh<=" & So_hoc_trinh
                For i As Integer = 0 To dt.DefaultView.Count - 1
                    dt.DefaultView.Item(i)("STT") = i + 1
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace
