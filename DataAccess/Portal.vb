Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Namespace DataAccess
    Public Class Portal_DataAccess

        Public Function HienThi_ESSDiemRenLuyenSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("MARK_DiemRenLuyen_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSLichThiSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("MARK_LichThi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemThanhPhan(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemThanhPhan_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDiemThi(ByVal ID_sv As Integer, ByVal ID_mon As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_mon", ID_mon)
                Return Connect.SelectTableSP("MARK_DiemThi_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

    End Class
End Namespace

