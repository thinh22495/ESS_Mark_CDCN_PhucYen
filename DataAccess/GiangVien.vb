'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 09, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class GiangVien_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSGiangVien(ByVal ID_cb As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.SelectTableSP("PLAN_GiaoVien_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSGiangVien_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_GiaoVien_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSGiangVien(ByVal obj As ESSGiangVien, ByVal Mat_khau As String, ByVal ID_bomon As Integer) As Integer
            Try
                Dim para(11) As SqlParameter
                para(0) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                para(1) = New SqlParameter("@Ten", obj.Ten)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                para(3) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(4) = New SqlParameter("@Ngay_sinh", SqlDbType.DateTime)
                If obj.Ngay_sinh.ToString = "" Then
                    para(4).Value = DBNull.Value
                Else
                    para(4).Value = CDate(obj.Ngay_sinh)
                End If
                para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(6) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                para(7) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                para(8) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                para(9) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                para(10) = New SqlParameter("@Mat_khau", Mat_khau)
                para(11) = New SqlParameter("@ID_bomon", ID_bomon)
                Return Connect.ExecuteSP("PLAN_GiaoVien_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSGiangVien(ByVal obj As ESSGiangVien) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@Ma_cb", obj.Ma_cb)
                para(1) = New SqlParameter("@Ten", obj.Ten)
                para(2) = New SqlParameter("@Ho_ten", obj.Ho_ten)
                para(3) = New SqlParameter("@ID_gioi_tinh", obj.ID_gioi_tinh)
                para(4) = New SqlParameter("@Ngay_sinh", SqlDbType.DateTime)
                If obj.Ngay_sinh.ToString = "" Then
                    para(4).Value = DBNull.Value
                Else
                    para(4).Value = CDate(obj.Ngay_sinh)
                End If
                para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(6) = New SqlParameter("@ID_hoc_ham", obj.ID_hoc_ham)
                para(7) = New SqlParameter("@ID_hoc_vi", obj.ID_hoc_vi)
                para(8) = New SqlParameter("@ID_chuc_danh", obj.ID_chuc_danh)
                para(9) = New SqlParameter("@ID_chuc_vu", obj.ID_chuc_vu)
                para(10) = New SqlParameter("@ID_cb", obj.ID_cb)
                Return Connect.ExecuteSP("PLAN_GiaoVien_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSGiangVien(ByVal ID_cb As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_cb", ID_cb)
                Return Connect.ExecuteSP("PLAN_GiaoVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_IDGiangVien(ByVal ID_cb As Integer) As Boolean
            Try
                Dim dt As DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@ID_cb", ID_cb)
                dt = Connect.SelectTableSP("PLAN_GiaoVien_KiemTraTonTaiID", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaGiangVien(ByVal Ma_cb As String) As Boolean
            Try
                Dim dt As DataTable
                Dim para As SqlParameter
                para = New SqlParameter("@Ma_cb", Ma_cb)
                dt = Connect.SelectTableSP("PLAN_GiaoVien_KiemTraTonTai_Ma", para)
                If CInt(dt.Rows(0)(0)) = 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_GiangVien() As Integer
            Try
                Return Connect.ExecuteScalar("PLAN_GiaoVien_GetMaxID")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

