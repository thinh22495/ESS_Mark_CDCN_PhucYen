'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, August 06, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LoaiHocBong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDoiTuongHocBong() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuongHocBong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLoaiHocBong_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_LoaiHocBong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiHocBong(ByVal obj As ESSLoaiHocBong) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", obj.Ma_dt)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                Return Connect.ExecuteSP("STU_LoaiHocBong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiHocBong(ByVal obj As ESSLoaiHocBong) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", obj.Ma_dt)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_xep_loai_hb", obj.ID_xep_loai_hb)
                para(3) = New SqlParameter("@HB_HT", obj.HB_HT)
                Return Connect.ExecuteSP("STU_LoaiHocBong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_xep_loai_hb", ID_xep_loai_hb)
                Return Connect.ExecuteSP("STU_LoaiHocBong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiHocBong(ByVal Ma_dt As String, ByVal ID_he As Integer, ByVal ID_xep_loai_hb As Integer) As Boolean
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_he", ID_he)
                para(2) = New SqlParameter("@ID_xep_loai_hb", ID_xep_loai_hb)
                If Connect.SelectTableSP("STU_LoaiHocBong_KiemTraTonTai", para).Rows.Count Then
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

