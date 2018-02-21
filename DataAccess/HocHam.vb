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
    Public Class HocHam_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHocHam(ByVal ID_hoc_ham As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                Return Connect.SelectTableSP("STU_HocHam_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHocHam_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_HocHam_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHocHam(ByVal obj As ESSHocHam) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_hoc_ham", obj.Ma_hoc_ham)
                para(1) = New SqlParameter("@Hoc_ham", obj.Hoc_ham)
                Return Connect.ExecuteSP("STU_HocHam_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHocHam(ByVal obj As ESSHocHam, ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                para(1) = New SqlParameter("@Ma_hoc_ham", obj.Ma_hoc_ham)
                para(2) = New SqlParameter("@Hoc_ham", obj.Hoc_ham)
                Return Connect.ExecuteSP("STU_HocHam_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHocHam(ByVal ID_hoc_ham As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_hoc_ham", ID_hoc_ham)
                Return Connect.ExecuteSP("STU_HocHam_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

