'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LoaiPhong_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLoaiPhong_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_LoaiPhong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiPhong(ByVal obj As ESSLoaiPhong) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@Ma_loai", obj.Ma_loai)
                para(1) = New SqlParameter("@Ten_loai_phong", obj.Ten_loai_phong)
                para(2) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                Return Connect.ExecuteSP("PLAN_LoaiPhong_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiPhong(ByVal obj As ESSLoaiPhong, ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                para(1) = New SqlParameter("@Ma_loai", obj.Ma_loai)
                para(2) = New SqlParameter("@Ten_loai_phong", obj.Ten_loai_phong)
                para(3) = New SqlParameter("@Thuc_hanh", obj.Thuc_hanh)
                Return Connect.ExecuteSP("PLAN_LoaiPhong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiPhong(ByVal ID_loai_phong As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                Return Connect.ExecuteSP("PLAN_LoaiPhong_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiPhong(ByVal ID_loai_phong As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_loai_phong", ID_loai_phong)
                Return Connect.ExecuteScalar("PLAN_LoaiPhong_KiemTraTonTai", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

