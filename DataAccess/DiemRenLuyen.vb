'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects

Namespace DataAccess
    Public Class DiemRenLuyen_DataAccess
#Region "Initialize"
        Public Sub New()

        End Sub
#End Region
#Region "Functions And Subs"
        Public Function HienThi_ESSXLRenLuyen() As DataTable
            Try
                Return Connect.SelectTableSP("STU_XLRenLuyen_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemRenLuyen_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("MARK_DiemRenLuyen_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemRenLuyenLop(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("MARK_DiemRenLuyen_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSSVRenLuyenLop(ByVal ID_lops As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lops", ID_lops)
                Return Connect.SelectTableSP("STU_SinhVienRenLuyen_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDiemLoaiRenLuyen(ByVal ID_Loai_rl As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_Loai_rl", ID_Loai_rl)
                Return Connect.SelectTableSP("STU_LoaiRenLuyen_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDiemRenLuyen(ByVal obj As ESSDiemRenLuyen) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Diem", obj.Diem)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                Return Connect.ExecuteSP("MARK_DiemRenLuyen_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDiemRenLuyen(ByVal obj As ESSDiemRenLuyen) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                para(1) = New SqlParameter("@Diem", obj.Diem)
                Return Connect.ExecuteSP("MARK_DiemRenLuyen_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function KhoaMo_DiemRenLuyen(ByVal Lock As Boolean, ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                para(1) = New SqlParameter("@Locked", Lock)
                Return Connect.ExecuteSP("MARK_DiemRenLuyen_KhoaMo", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function CapNhat_ESSDiemRenLuyenExcel(ByVal obj As ESSDiemRenLuyen) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@Diem", obj.Diem)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                Return Connect.ExecuteSP("MARK_DiemRenLuyenExcel_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemRenLuyenExcel(ByVal obj As ESSDiemRenLuyen) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(3) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                Return Connect.ExecuteSP("MARK_DiemRenLuyenExcel_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDiemRenLuyen(ByVal ID_diem_rl As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", ID_diem_rl)
                Return Connect.ExecuteSP("MARK_DiemRenLuyen_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_DiemRenLuyen(ByVal obj As ESSDiemRenLuyen) As Boolean
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_diem_rl", obj.ID_diem_rl)
                para(1) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(2) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(3) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(4) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                If Connect.SelectTableSP("MARK_DiemRenLuyen_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_DiemRenLuyenExcel(ByVal obj As ESSDiemRenLuyen) As Boolean
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Hoc_ky", obj.Hoc_ky)
                para(1) = New SqlParameter("@Nam_hoc", obj.Nam_hoc)
                para(2) = New SqlParameter("@Ma_sv", obj.Ma_sv)
                para(3) = New SqlParameter("@ID_loai_rl", obj.ID_loai_rl)
                If Connect.SelectTableSP("MARK_DiemRenLuyenExcel_KiemTraTonTai", para).Rows.Count > 0 Then
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


