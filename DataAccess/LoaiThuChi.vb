'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, August 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class LoaiThuChi_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSLoaiThuChi_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("ACC_LoaiThuChi_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLoaiThuChi(ByVal obj As ESSLoaiThuChi) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@Ten_thu_chi", obj.Ten_thu_chi)
                para(1) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                para(2) = New SqlParameter("@So_tien", obj.So_tien)
                para(3) = New SqlParameter("@Thu_bat_buoc", obj.Thu_bat_buoc)
                para(4) = New SqlParameter("@Theo_nien_khoa", obj.Theo_nien_khoa)
                para(5) = New SqlParameter("@Hoc_phi", obj.Hoc_phi)
                Return Connect.ExecuteSP("ACC_LoaiThuChi_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLoaiThuChi(ByVal obj As ESSLoaiThuChi) As Integer
            Try
                Dim para(6) As SqlParameter
                para(0) = New SqlParameter("@ID_thu_chi", obj.ID_thu_chi)
                para(1) = New SqlParameter("@Ten_thu_chi", obj.Ten_thu_chi)
                para(2) = New SqlParameter("@Thu_chi", obj.Thu_chi)
                para(3) = New SqlParameter("@So_tien", obj.So_tien)
                para(4) = New SqlParameter("@Thu_bat_buoc", obj.Thu_bat_buoc)
                para(5) = New SqlParameter("@Theo_nien_khoa", obj.Theo_nien_khoa)
                para(6) = New SqlParameter("@Hoc_phi", obj.Hoc_phi)
                Return Connect.ExecuteSP("ACC_LoaiThuChi_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLoaiThuChi(ByVal ID_thu_chi As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_thu_chi", ID_thu_chi)
                Return Connect.ExecuteSP("ACC_LoaiThuChi_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_LoaiThuChi(ByVal Ten_thu_chi As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Ten_thu_chi", Ten_thu_chi)
                If Connect.SelectTableSP("ACC_LoaiThuChi_KiemTraTonTai", para).Rows.Count > 0 Then
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

