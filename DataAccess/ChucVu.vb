'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 17, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ChucVu_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSChucVu(ByVal ID_chuc_vu As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                Return Connect.SelectTableSP("PLAN_ChucVu_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChucVu_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_ChucVu_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSChucVu(ByVal obj As ESSChucVu) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_chuc_vu", obj.Ma_chuc_vu)
                para(1) = New SqlParameter("@Chuc_vu", obj.Chuc_vu)
                Return Connect.ExecuteSP("PLAN_ChucVu_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChucVu(ByVal obj As ESSChucVu, ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                para(1) = New SqlParameter("@Ma_chuc_vu", obj.Ma_chuc_vu)
                para(2) = New SqlParameter("@Chuc_vu", obj.Chuc_vu)
                Return Connect.ExecuteSP("PLAN_ChucVu_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChucVu(ByVal ID_chuc_vu As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_chuc_vu", ID_chuc_vu)
                Return Connect.ExecuteSP("PLAN_ChucVu_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChucVu(ByVal Ma_chuc_vu As String) As Boolean
            Try
                Dim dt As New DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ma_chuc_vu", Ma_chuc_vu)
                dt = Connect.SelectTableSP("PLAN_ChucVu_KiemTraTonTai", para)
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

