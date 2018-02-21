'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class CanBoLop_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSCanBoLop_DanhSach(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_CanBoLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSCanBoLop(ByVal obj As ESSCanBoLop) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Nam_bat_dau", obj.Nam_bat_dau)
                para(2) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                para(3) = New SqlParameter("@Chuc_danh_kiem", obj.Chuc_danh_kiem)
                para(4) = New SqlParameter("@Nam_ket_thuc", obj.Nam_ket_thuc)
                Return Connect.ExecuteSP("STU_CanBoLop_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSCanBoLop(ByVal obj As ESSCanBoLop, ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                para(3) = New SqlParameter("@Chuc_danh_kiem", obj.Chuc_danh_kiem)
                para(4) = New SqlParameter("@Nam_ket_thuc", obj.Nam_ket_thuc)
                Return Connect.ExecuteSP("STU_CanBoLop_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSCanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                Return Connect.ExecuteSP("STU_CanBoLop_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_CanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Nam_bat_dau", Nam_bat_dau)
                para(2) = New SqlParameter("@ID_chuc_danh", ID_chuc_danh)
                If Connect.SelectTableSP("STU_CanBoLop_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

