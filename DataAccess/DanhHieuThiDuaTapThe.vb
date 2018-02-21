'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, July 11, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhHieuThiDuaTapThe_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhHieuThiDuaTapThe_DanhSach(ByVal dsID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lops", dsID_lops)
                Return Connect.SelectTableSP("STU_DanhHieuThiDuaTapThe_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhHieuThiDuaTapThe(ByVal obj As ESSDanhHieuThiDuaTapThe) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                para(3) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                para(5) = New SqlParameter("@ID_cap", obj.ID_cap)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaTapThe_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieuThiDuaTapThe(ByVal obj As ESSDanhHieuThiDuaTapThe) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_lop", obj.ID_lop)
                para(3) = New SqlParameter("@ID_danh_hieu", obj.ID_danh_hieu)
                para(4) = New SqlParameter("@Ly_do", obj.Ly_do)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaTapThe_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_DanhHieuThiDuaTapThe_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DanhHieuThiDuaTapThe(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_lop", ID_lop)
                If Connect.SelectTableSP("STU_DanhHieuThiDuaTapThe_KiemTraTonTai", para).Rows.Count > 0 Then
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

