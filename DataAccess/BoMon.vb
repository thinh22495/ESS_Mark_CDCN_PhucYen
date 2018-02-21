'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, June 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class BoMon_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSBoMon(ByVal ID_bm As Integer) As DataTable
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return Connect.SelectTableSP("PLAN_BoMon_HienThi", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return Connect.SelectTableSP("PLAN_BoMon_HienThi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBoMon_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_BoMon_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBoMon(ByVal obj As ESSBoMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(1) As SqlParameter
                    para(0) = New SqlParameter("@Ma_bo_mon", obj.Ma_bo_mon)
                    para(1) = New SqlParameter("@Bo_mon", obj.Bo_mon)
                    Return Connect.ExecuteSP("PLAN_BoMon_ThemMoi", para)
                Else
                    Dim para(1) As OracleParameter
                    para(0) = New OracleParameter(":Ma_bo_mon", obj.Ma_bo_mon)
                    para(1) = New OracleParameter(":Bo_mon", obj.Bo_mon)
                    Return Connect.ExecuteSP("PLAN_BoMon_ThemMoi", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBoMon(ByVal obj As ESSBoMon) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para(2) As SqlParameter
                    para(0) = New SqlParameter("@ID_bm", obj.ID_bm)
                    para(1) = New SqlParameter("@Ma_bo_mon", obj.Ma_bo_mon)
                    para(2) = New SqlParameter("@Bo_mon", obj.Bo_mon)
                    Return Connect.ExecuteSP("PLAN_BoMon_CapNhat", para)
                Else
                    Dim para(2) As OracleParameter
                    para(0) = New OracleParameter(":ID_bm", obj.ID_bm)
                    para(1) = New OracleParameter(":Ma_bo_mon", obj.Ma_bo_mon)
                    para(2) = New OracleParameter(":Bo_mon", obj.Bo_mon)
                    Return Connect.ExecuteSP("PLAN_BoMon_CapNhat", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBoMon(ByVal ID_bm As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return Connect.ExecuteSP("PLAN_BoMon_Xoa", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return Connect.ExecuteSP("PLAN_BoMon_Xoa", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMon(ByVal ID_bm As Integer) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    dt = Connect.SelectTableSP("PLAN_BoMon_KiemTraTonTai", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    dt = Connect.SelectTableSP("PLAN_BoMon_KiemTraTonTai", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_BoMon(ByVal Ma_bo_mon As String) As Boolean
            Try
                Dim dt As DataTable
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@Ma_bo_mon", Ma_bo_mon)
                    dt = Connect.SelectTableSP("PLAN_BoMon_KiemTraTonTai_MaBoMon", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":Ma_bo_mon", Ma_bo_mon)
                    dt = Connect.SelectTableSP("PLAN_BoMon_KiemTraTonTai_MaBoMon", para)
                End If
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_BoMon(ByVal ID_bm As Integer) As Integer
            Try
                If gDBType = DatabaseType.SQLServer Then
                    Dim para As SqlParameter
                    para = New SqlParameter("@ID_bm", ID_bm)
                    Return Connect.ExecuteScalar("PLAN_BoMon_GetMaxID", para)
                Else
                    Dim para As OracleParameter
                    para = New OracleParameter(":ID_bm", ID_bm)
                    Return Connect.ExecuteScalar("PLAN_BoMon_GetMaxID", para)
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

