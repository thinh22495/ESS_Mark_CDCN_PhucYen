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
    Public Class DoiTuongChinhSach_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDoiTuongChinhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DoiTuongChinhSach_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDoiTuongChinhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuong_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DoiTuongChinhSach(ByVal ID_dt As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                If Connect.SelectTableSP("STU_DoiTuong_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Xoa_ESSDoiTuongChinhSach(ByVal ID_dt As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("STU_DoiTuong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

