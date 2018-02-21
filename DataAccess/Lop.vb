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
    Public Class Lop_DataAccess

#Region "Initialize"
        Public Sub New()
            'Connect.SetConnectionString(".", "UniSoft_new", "UnisoftAdmin", "taUnisoft032003")
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function GetInFoSv(ByVal ID_sv As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_sv", ID_sv)
                Return Connect.SelectTableSP("STU_ThongTinSv", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSach_KhoaHoc(ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Lop_TC_HienThi_Khoa_hoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSach_He_KhoaHoc(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                Return Connect.SelectTableSP("STU_Lop_TC_HienThi_He_Khoa_hoc", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSach_He(ByVal ID_he As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                Return Connect.SelectTableSP("STU_Lop_TC_HienThi_He", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSachNganh2(ByVal dsID_lop_nganh2 As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop_nganh2", dsID_lop_nganh2)
                Return Connect.SelectTableSP("STU_Lop_TC_HienThi_DanhSachNganh2", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSach(ByVal dsID_lop As String, ByVal tinh_chat As Integer, ByVal Lop_chuyen_nganh As Integer, ByVal Lop_hanh_chinh As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@dsID_lop", dsID_lop)
                para(1) = New SqlParameter("@tinh_chat", tinh_chat)
                para(2) = New SqlParameter("@Lop_chuyen_nganh", Lop_chuyen_nganh)
                para(3) = New SqlParameter("@Lop_hanh_chinh", Lop_hanh_chinh)
                Return Connect.SelectTableSP("STU_Lop_TC_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_DanhSach(ByVal tinh_chat As Integer, ByVal Lop_chuyen_nganh As Integer, ByVal Lop_hanh_chinh As Integer) As DataTable
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@tinh_chat", tinh_chat)
                para(1) = New SqlParameter("@Lop_chuyen_nganh", Lop_chuyen_nganh)
                para(2) = New SqlParameter("@Lop_hanh_chinh", Lop_hanh_chinh)
                Return Connect.SelectTableSP("STU_Lop_HienThi_DanhSach_TatCa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhMucKhoaHoc() As DataTable
            Try
                Dim strSQL As String = "SELECT DISTINCT Khoa_hoc,Khoa_hoc FROM STU_LOP"
                Return Connect.SelectTable(strSQL)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_Exits(ByVal Ten_lop As String, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As Boolean
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@Ten_lop", Ten_lop)
                para(1) = New SqlParameter("@ID_khoa", ID_khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                If Connect.SelectTableSP("STU_Lop_KiemTraTonTai_TC", para).Rows.Count > 0 Then
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSLop(ByVal obj As ESSLop) As Integer
            Try
                Dim para(10) As SqlParameter
                para(0) = New SqlParameter("@Ten_lop", obj.Ten_lop) ' Tên lớp
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(3) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(4) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(5) = New SqlParameter("@Nien_khoa", obj.Nien_khoa)
                para(6) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(7) = New SqlParameter("@So_sv", obj.So_sv)
                para(8) = New SqlParameter("@Tinh_chat", obj.Tinh_chat)
                para(9) = New SqlParameter("@Lop_chuyen_nganh", obj.Lop_chuyen_nganh)
                para(10) = New SqlParameter("@Lop_hanh_chinh", obj.Lop_hanh_chinh)
                Return Connect.ExecuteSP("STU_Lop_TC_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLop(ByVal obj As ESSLop, ByVal ID_lop As Integer) As Integer
            Try
                Dim para(11) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                para(1) = New SqlParameter("@Ten_lop", obj.Ten_lop)
                para(2) = New SqlParameter("@ID_he", obj.ID_he)
                para(3) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(4) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                para(5) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(6) = New SqlParameter("@Nien_khoa", obj.Nien_khoa)
                para(7) = New SqlParameter("@ID_dt", obj.ID_dt)
                para(8) = New SqlParameter("@So_sv", obj.So_sv)
                para(9) = New SqlParameter("@Tinh_chat", obj.Tinh_chat)
                para(10) = New SqlParameter("@Lop_chuyen_nganh", obj.Lop_chuyen_nganh)
                para(11) = New SqlParameter("@Lop_hanh_chinh", obj.Lop_hanh_chinh)
                Return Connect.ExecuteSP("STU_Lop_TC_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLop_RaTruong(ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                para(1) = New SqlParameter("@Ra_truong", 1)
                Return Connect.ExecuteSP("STU_LopRaVaoTruong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLop_VaoTruong(ByVal ID_lop As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                para(1) = New SqlParameter("@Ra_truong", 0)
                Return Connect.ExecuteSP("STU_LopRaVaoTruong_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSLop(ByVal ID_lop As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_lop", ID_lop)
                Return Connect.ExecuteSP("STU_Lop_TC_Xoa", para)

            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSachNganh2_TreView() As DataTable
            Try
                Return Connect.SelectTableSP("STU_DanhSachNganh2_DanhSach_Treview")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace