'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, August 01, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class QuyHocBongPhanBo_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSQuyHocBongPhanBo_DanhSach(ByVal ID_hb As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_hb", ID_hb)
                Return Connect.SelectTableSP("STU_QuyHocBongPhanBo_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSQuyHocBongPhanBoLop_DanhSach(ByVal ID_hb As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_hb", ID_hb)
                Return Connect.SelectTableSP("STU_QuyHocBongPhanBoLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSQuyHocBongPhanBoLop_DanhSach(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.SelectTableSP("STU_QuyHocBongPhanBoLop_KiemTraTonTai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSQuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_QuyHocBongPhanBoLop_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSQuyHocBongPhanBo(ByVal obj As ESSQuyHocBongPhanBo) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Ten_phan_bo", obj.Ten_phan_bo)
                para(1) = New SqlParameter("@ID_hb", obj.ID_hb)
                para(2) = New SqlParameter("@So_sv", obj.So_sv)
                para(3) = New SqlParameter("@So_tien", obj.So_tien)
                para(4) = New SqlParameter("@Phan_dac_biet", obj.Phan_dac_biet)
                Return Connect.ExecuteSP("STU_QuyHocBongPhanBo_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyHocBongPhanBo(ByVal obj As ESSQuyHocBongPhanBo, ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                para(1) = New SqlParameter("@Ten_phan_bo", obj.Ten_phan_bo)
                para(2) = New SqlParameter("@ID_hb", obj.ID_hb)
                para(3) = New SqlParameter("@So_sv", obj.So_sv)
                para(4) = New SqlParameter("@So_tien", obj.So_tien)
                para(5) = New SqlParameter("@Phan_dac_biet", obj.Phan_dac_biet)
                Return Connect.ExecuteSP("STU_QuyHocBongPhanBo_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyHocBongPhanBoLop(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                Return Connect.ExecuteSP("STU_QuyHocBongPhanBoLop_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyHocBongPhanBo(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_bo", ID_phan_bo)
                Return Connect.ExecuteSP("STU_QuyHocBongPhanBo_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

