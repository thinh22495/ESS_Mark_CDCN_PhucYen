'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, May 04, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LoaiGiayTo_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLoaiGiayTo_DaNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_LoaiGiayTo_DaNop", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLoaiGiayTo_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_LoaiGiayTo_TC_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSLoaiGiayTo_DanhSach(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_LoaiGiayTo_TC_HienThi_DanhSach_By_He_Khoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSLoaiGiayTo(ByVal ID_giay_to As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.SelectTableSP("STU_LoaiGiayTo_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSLoaiGiayTo(ByVal obj As ESSLoaiGiayTo) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_giay_to", obj.Ma_giay_to)
                para(1) = New SqlParameter("@Ten_giay_to", obj.Ten_giay_to)
                Return Connect.ExecuteSP("STU_LoaiGiayTo_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiGiayTo(ByVal obj As ESSLoaiGiayTo, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                para(1) = New SqlParameter("@Ma_giay_to", obj.Ma_giay_to)
                para(2) = New SqlParameter("@Ten_giay_to", obj.Ten_giay_to)
                Return Connect.ExecuteSP("STU_LoaiGiayTo_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiGiayTo(ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteSP("STU_LoaiGiayTo_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDoiTuongGiayTo_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DoiTuongGiayTo_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteSP("STU_DoiTuongGiayTo_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteSP("STU_DoiTuongGiayTo_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteSP("STU_DoiTuongGiayTo_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_DoiTuongGiayTo(ByVal Ma_dt As String, ByVal ID_giay_to As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ma_dt", Ma_dt)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                If Connect.SelectTableSP("STU_DoiTuongGiayTo_KiemTraTonTai", para).Rows.Count > 0 Then
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

