'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class Tang_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSTang_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_Tang_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSTang(ByVal obj As ESSTang) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_tang", obj.Ma_tang)
                para(1) = New SqlParameter("@Ten_tang", obj.Ten_tang)
                Return Connect.ExecuteSP("PLAN_Tang_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTang(ByVal obj As ESSTang, ByVal ID_TANG As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_TANG", ID_TANG)
                para(1) = New SqlParameter("@Ma_tang", obj.Ma_tang)
                para(2) = New SqlParameter("@Ten_tang", obj.Ten_tang)
                Return Connect.ExecuteSP("PLAN_Tang_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSTang(ByVal ID_TANG As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_TANG", ID_TANG)
                Return Connect.ExecuteSP("PLAN_Tang_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Tang(ByVal Ma_TANG As Integer) As Boolean
            Try
                Dim dt As New DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ma_TANG", Ma_TANG)
                dt = Connect.SelectTableSP("PLAN_Tang_KiemTraTonTai", para)
                If dt.Rows.Count = 0 Then
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

