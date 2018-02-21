'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, October 12, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ToChucThiPhucKhao_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.SelectTableSP("MARK_ToChucThiPhucKhao_TC_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSToChucThiPhucKhao_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_ToChucThiPhucKhao_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSToChucThiPhucKhao(ByVal obj As ESSToChucThiPhucKhao) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_thi", obj.ID_thi)
                para(1) = New SqlParameter("@ID_ds_thi", obj.ID_ds_thi)
                para(2) = New SqlParameter("@Lan", obj.Lan)
                para(3) = New SqlParameter("@Diem1", obj.Diem1)
                para(4) = New SqlParameter("@Diem2", obj.Diem2)
                para(5) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhucKhao(ByVal obj As ESSToChucThiPhucKhao, ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                para(1) = New SqlParameter("@ID_thi", obj.ID_thi)
                para(2) = New SqlParameter("@ID_ds_thi", obj.ID_ds_thi)
                para(3) = New SqlParameter("@Lan", obj.Lan)
                para(4) = New SqlParameter("@Diem1", obj.Diem1)
                para(5) = New SqlParameter("@Diem2", obj.Diem2)
                para(6) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteSP("MARK_ToChucThiPhucKhao_TC_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteScalar("MARK_ToChucThiPhucKhao_TC_KiemTraTonTai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_ToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phuc_khao", ID_phuc_khao)
                Return Connect.ExecuteScalar("MARK_ToChucThiPhucKhao_TC_GetMaxID", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

