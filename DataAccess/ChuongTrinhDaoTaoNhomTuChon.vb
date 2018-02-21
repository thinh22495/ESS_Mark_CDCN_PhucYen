Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class ChuongTrinhDaoTaoNhomTuChon_DataAccess
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region
#Region "Functions And Subs"
        Public Function HienThi_ESSChuongTrinhDaoTaoNhomTuChon_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietNhomMonChon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSChuongTrinhDaoTaoNhomTuChon(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_NhomTuChon_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSChuongTrinhDaoTaoNotNhomTuChon_DanhSach(ByVal ID_dt As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_ChiTietNotNhomMonChon_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(ByVal obj As ESSChuongTrinhDaoTaoNhomTuChon) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(1) = New SqlParameter("@Nhom_tu_chon", obj.Nhom_tu_chon)
                para(2) = New SqlParameter("@So_mon_tu_chon", obj.So_mon_tu_chon)
                para(3) = New SqlParameter("@So_mon_dang_ky", obj.So_mon_dang_ky)
                Dim dt As DataTable = Connect.SelectTableSP("PLAN_ChuongTrinhDaoTao_TC_NhomTuChon_ThemMoi", para)
                If dt.Rows.Count > 0 Then
                    Return CInt("0" + dt.Rows(0)(0).ToString())
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTaoNhomTuChon(ByVal ID_dt As Integer, ByVal Nhom_tu_chon As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_dt", ID_dt)
                para(1) = New SqlParameter("@Nhom_tu_chon", Nhom_tu_chon)
                Return Connect.ExecuteSP("PLAN_ChuongTrinhDaoTao_TC_NhomTuChon_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

