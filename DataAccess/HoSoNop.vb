'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, May 27, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class HoSoNop_DataAccess
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSTableHoSoNop(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_TableHoSoNop_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.SelectTableSP("STU_HoSoNop_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoSoNop_DanhSach(ByVal dsID_lop As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                Return Connect.SelectTableSP("STU_HoSoNop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoNop(ByVal obj As ESSHoSoNop) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_giay_to", obj.ID_giay_to)
                para(1) = New SqlParameter("@Ghi_chu_nop", obj.Ghi_chu_nop)
                para(2) = New SqlParameter("@Ghi_chu_tra", obj.Ghi_chu_tra)
                para(3) = New SqlParameter("@Da_tra", obj.Da_tra)
                If obj.Ngay_tra = Nothing Then
                    para(4) = New SqlParameter("@Ngay_tra", DBNull.Value)
                Else
                    para(4) = New SqlParameter("@Ngay_tra", obj.Ngay_tra)
                End If
                para(5) = New SqlParameter("@Ban_chinh", obj.Ban_chinh)
                para(6) = New SqlParameter("@Ban_sao", obj.Ban_sao)
                para(7) = New SqlParameter("@ID_sv", obj.ID_sv)
                Return Connect.ExecuteSP("STU_HoSoNop_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoNop(ByVal obj As ESSHoSoNop) As Integer
            Try
                Dim para(7) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", obj.ID_sv)
                para(1) = New SqlParameter("@ID_giay_to", obj.ID_giay_to)
                para(2) = New SqlParameter("@Ghi_chu_nop", obj.Ghi_chu_nop)
                para(3) = New SqlParameter("@Ghi_chu_tra", obj.Ghi_chu_tra)
                para(4) = New SqlParameter("@Da_tra", obj.Da_tra)
                If obj.Ngay_tra = Nothing Then
                    para(5) = New SqlParameter("@Ngay_tra", DBNull.Value)
                Else
                    para(5) = New SqlParameter("@Ngay_tra", obj.Ngay_tra)
                End If
                para(6) = New SqlParameter("@Ban_chinh", obj.Ban_chinh)
                para(7) = New SqlParameter("@Ban_sao", obj.Ban_sao)
                Return Connect.ExecuteSP("STU_HoSoNop_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteSP("STU_HoSoNop_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoNop(ByVal ID_sv As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.ExecuteSP("STU_HoSoNopSV_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                If Connect.SelectTableSP("STU_HoSoNop_KiemTraTonTai", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_HoSoNop(ByVal ID_sv As Integer, ByVal ID_giay_to As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                para(1) = New SqlParameter("@ID_giay_to", ID_giay_to)
                Return Connect.ExecuteScalar("STU_HoSoNop_GetMaxID", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

