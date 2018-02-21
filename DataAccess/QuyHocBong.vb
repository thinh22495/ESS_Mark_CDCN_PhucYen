'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class QuyHocBong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSQuyHocBong_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                Return Connect.SelectTableSP("STU_QuyHocBong_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSQuyHocBong(ByVal obj As ESSQuyHocBong) As Integer
            Try
                Dim para(8) As SqlParameter
                para(0) = New SqlParameter("@ID_quy", obj.ID_quy)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(3) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(4) = New SqlParameter("@Tu_khoa", obj.Tu_khoa)
                para(5) = New SqlParameter("@Den_khoa", obj.Den_khoa)
                para(6) = New SqlParameter("@Sotien_ngansach", obj.Sotien_ngansach)
                para(7) = New SqlParameter("@Sotien_khac", obj.Sotien_khac)
                para(8) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_QuyHocBong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyHocBong(ByVal obj As ESSQuyHocBong, ByVal ID_hb As Integer) As Integer
            Try
                Dim para(9) As SqlParameter
                para(0) = New SqlParameter("@ID_hb", ID_hb)
                para(1) = New SqlParameter("@ID_quy", obj.ID_quy)
                para(2) = New SqlParameter("@ID_he", obj.ID_he)
                para(3) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(4) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(5) = New SqlParameter("@Tu_khoa", obj.Tu_khoa)
                para(6) = New SqlParameter("@Den_khoa", obj.Den_khoa)
                para(7) = New SqlParameter("@Sotien_ngansach", obj.Sotien_ngansach)
                para(8) = New SqlParameter("@Sotien_khac", obj.Sotien_khac)
                para(9) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_QuyHocBong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyHocBong(ByVal ID_hb As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_hb", ID_hb)
                Return Connect.ExecuteSP("STU_QuyHocBong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_QuyHocBong(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_quy As Integer) As Boolean
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", Nam_hoc)
                para(2) = New SqlParameter("@ID_quy", ID_quy)
                para(3) = New SqlParameter("@ID_he", ID_he)
                If Connect.SelectTableSP("STU_QuyHocBong_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

#Region "Function Loại quỹ học bổng"
        Public Function HienThi_ESSLoaiQuy_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_LoaiQuy_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiQuy(ByVal obj As ESSLoaiQuy) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Loai_quy", obj.Loai_quy)
                para(1) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_LoaiQuy_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiQuy(ByVal obj As ESSLoaiQuy) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_quy", obj.ID_quy)
                para(1) = New SqlParameter("@Loai_quy", obj.Loai_quy)
                para(2) = New SqlParameter("@Ghi_chu", obj.Ghi_chu)
                Return Connect.ExecuteSP("STU_LoaiQuy_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiQuy(ByVal ID_quy As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_quy", ID_quy)
                Return Connect.ExecuteSP("STU_LoaiQuy_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiQuy(ByVal Loai_quy As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Loai_quy", Loai_quy)
                If Connect.SelectTableSP("STU_LoaiQuy_KiemTraTonTai", para).Rows.Count > 0 Then
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

