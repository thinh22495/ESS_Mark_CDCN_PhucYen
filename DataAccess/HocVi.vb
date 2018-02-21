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
    Public Class HocVi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHocVi(ByVal ID_hoc_vi As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                Return Connect.SelectTableSP("STU_HocVi_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHocVi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_HocVi_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHocVi(ByVal obj As ESSHocVi) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_hoc_vi", obj.Ma_hoc_vi)
                para(1) = New SqlParameter("@Hoc_vi", obj.Hoc_vi)
                Return Connect.ExecuteSP("STU_HocVi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocVi(ByVal obj As ESSHocVi, ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                para(1) = New SqlParameter("@Ma_hoc_vi", obj.Ma_hoc_vi)
                para(2) = New SqlParameter("@Hoc_vi", obj.Hoc_vi)
                Return Connect.ExecuteSP("STU_HocVi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocVi(ByVal ID_hoc_vi As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_vi", ID_hoc_vi)
                Return Connect.ExecuteSP("STU_HocVi_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

