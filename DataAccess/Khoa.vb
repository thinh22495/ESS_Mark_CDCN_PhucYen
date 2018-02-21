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
    Public Class Khoa_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSKhoa_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_Khoa_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKhoa(ByVal obj As ESSKhoa) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_khoa", obj.Ma_khoa)
                para(1) = New SqlParameter("@Ten_khoa", obj.Ten_khoa)
                Return Connect.ExecuteSP("STU_Khoa_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhoa(ByVal obj As ESSKhoa, ByVal ID_khoa As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_khoa", ID_khoa)
                para(1) = New SqlParameter("@Ma_khoa", obj.Ma_khoa)
                para(2) = New SqlParameter("@Ten_khoa", obj.Ten_khoa)
                Return Connect.ExecuteSP("STU_Khoa_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhoa(ByVal ID_khoa As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_khoa", ID_khoa)
                Return Connect.ExecuteSP("STU_Khoa_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_Khoa(ByVal Ma_khoa As String) As Boolean
            Try
                Dim dt As New DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ma_khoa", Ma_khoa)
                dt = Connect.SelectTableSP("STU_Khoa_KiemTraTonTai", para)
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

