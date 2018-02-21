'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, June 04, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class BoMonGiangVien_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function ThemMoi_ESSBoMonGiangVien(ByVal obj As ESSBoMonGiangVien) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", obj.ID_cb)
                para(1) = New SqlParameter("@ID_bm", obj.ID_bm)
                Return Connect.ExecuteSP("PLAN_BoMonGiangVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_bm", ID_bm)
                para(1) = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.ExecuteSP("PLAN_BoMonGiangVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSGiangVien(ByVal ID_bm As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_bm", ID_bm)
                Return Connect.SelectTableSP("PLAN_BoMonGiangVien_HienThi_GiangVien", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBoMon(ByVal ID_cb As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.SelectTableSP("PLAN_BoMonGiangVien_HienThi_BoMon", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMonGiangVien(ByVal ID_bm As Integer, ByVal ID_cb As Integer) As Boolean
            Try
                Dim dt As DataTable
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_bm", ID_bm)
                para(1) = New SqlParameter("@ID_cb", ID_cb)
                dt = Connect.SelectTableSP("PLAN_BoMonGiangVien_KiemTraTonTai", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

