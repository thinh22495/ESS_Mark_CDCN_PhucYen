'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, May 03, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class DanhSach_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSDanhSach(ByVal ID_lop As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.SelectTableSP("STU_DanhSach_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhSach_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("sp_DanhSach_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSach(ByVal obj As ESSDanhSach) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", obj.ID_lop)
                para(1) = New SqlParameter("@Mat_khau", obj.Mat_khau)
                para(2) = New SqlParameter("@Active", SqlDbType.Bit)
                para(2).Value = obj.Active
                para(3) = New SqlParameter("@Da_tot_nghiep", SqlDbType.Bit)
                para(3).Value = obj.Da_tot_nghiep
                para(4) = New SqlParameter("@ID_sv", obj.ID_sv)
                Return Connect.ExecuteSP("STU_DanhSach_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function CapNhat_ESSDanhSach_NhapHoc(ByVal obj As ESSDanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_svs", ID_svs)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                para(2) = New SqlParameter("@ID_dt", 0)
                Return Connect.ExecuteSP("STU_DanhSach_ChuyenLop_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function CapNhat_ESSDanhSach(ByVal obj As ESSDanhSach, ByVal ID_svs As String, ByVal ID_lop As Integer) As Integer
            Try
                Dim ID_dt As Integer = getID_dt_ID_SVs(ID_lop)
                If ID_dt <= 0 Then ID_dt = 0
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_svs", ID_svs)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                para(2) = New SqlParameter("@ID_dt", ID_dt)
                Return Connect.ExecuteSP("STU_DanhSach_ChuyenLop_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function getID_dt_ID_SVs(ByVal ID_lop As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("PLAN_GetID_dts", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function Xoa_ESSDanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_DanhSach_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function KiemTra_DanhSach(ByVal ID_sv As Integer, ByVal ID_lop As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_lop", ID_lop)
                If Connect.SelectTableSP("STU_DanhSach_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSach_SinhVien(ByVal ID_lop As String) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_DanhSach_SinhVien_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
        Public Function KiemTra_TruocKhiXoa_SV(ByVal ID_sv As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                If Connect.SelectTableSP("STU_HoSoSinhVien_Xoa_Check", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace

