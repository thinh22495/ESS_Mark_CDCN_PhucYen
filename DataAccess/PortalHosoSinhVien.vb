'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class PortalHosoSinhVien_DataAccess
        Public Function HienThi_ESSThongTinSinhVien_Full(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_ThongTinSinhVienFull_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSThongTinSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_ThongTinSinhVien_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThongTinSinhVienNganh2(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_THONGTINSINHVIEN_NGANH2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

