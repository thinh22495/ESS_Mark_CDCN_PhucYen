'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 08, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class He_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHe_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_He_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHe(ByVal obj As ESSHe) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_he", obj.Ma_he)
                para(1) = New SqlParameter("@Ten_he", obj.Ten_he)
                Return Connect.ExecuteSP("STU_He_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHe(ByVal obj As ESSHe, ByVal ID_he As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Ma_he", obj.Ma_he)
                para(2) = New SqlParameter("@Ten_he", obj.Ten_he)
                Return Connect.ExecuteSP("STU_He_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHe(ByVal ID_he As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_he", ID_he)
                Return Connect.ExecuteSP("STU_He_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_He(ByVal Ma_he As String) As Boolean
            Try
                Dim dt As New DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ma_he", Ma_he)
                dt = Connect.SelectTableSP("STU_He_KiemTraTonTai", para)
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

