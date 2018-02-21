'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DoiTuongTroCap_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSachTroCap(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("STU_DanhSachTroCap_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDoiTuongTroCap(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_DoiTuongHocBong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDoiTuong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuongHocBong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDoiTuongTroCap(ByVal obj As ESSDoiTuongTroCap) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt_hb", obj.Ma_dt_hb)
                para(1) = New SqlParameter("@Ten_dt_hb", obj.Ten_dt_hb)
                para(2) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                Return Connect.ExecuteSP("STU_DoiTuongHocBong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDoiTuongTroCap(ByVal obj As ESSDoiTuongTroCap, ByVal ID_dt_hb As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_dt_hb", ID_dt_hb)
                para(1) = New SqlParameter("@Ma_dt_hb", obj.Ma_dt_hb)
                para(2) = New SqlParameter("@Ten_dt_hb", obj.Ten_dt_hb)
                para(3) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                Return Connect.ExecuteSP("STU_DoiTuongHocBong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDoiTuongTroCap(ByVal ID_dt_hb As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_dt_hb", ID_dt_hb)
                Return Connect.ExecuteSP("STU_DoiTuongHocBong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_DoiTuongTroCap(ByVal Ma_dt_hb As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt_hb", Ma_dt_hb)
                If Connect.SelectTableSP("STU_DoiTuongHocBong_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#Region "Danh sách xác định tiền trợ cập"
        Public Function KiemTra_DanhSachTroCap(ByVal obj As ESSDanhSachTroCap) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                If Connect.SelectTableSP("STU_DanhSachTroCap_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachTroCap(ByVal obj As ESSDanhSachTroCap) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_DanhSachTroCap_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachTroCap(ByVal obj As ESSDanhSachTroCap) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@Sotien_trocap", obj.Sotien_trocap)
                para(4) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_DanhSachTroCap_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachTroCap(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.ExecuteSP("STU_DanhSachTroCap_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#End Region

    End Class
End Namespace

