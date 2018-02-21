'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/05/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class Users_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub ChangePassword(ByVal UserID As Integer, ByVal NewPassword As String)
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@NewPassword", NewPassword)
                Connect.ExecuteSP("SYS_ChangePassword", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function HienThi_ESSUsers(ByVal UserName As String) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                Return Connect.SelectTableSP("SYS_NguoiDung_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSVaiTroQuyen(ByVal ID_Vai_Tro As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_Vai_Tro", ID_Vai_Tro)
                Return Connect.SelectTableSP("SYS_VaiTroQuyen_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhong(ByVal ID_Phong As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_Phong", ID_Phong)
                Return Connect.SelectTableSP("SYS_Phong_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhong_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("SYS_Phong_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSBomon_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("PLAN_BoMon_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSUsers_DanhSach(ByVal UserID As Integer, ByVal ID_Khoa As Integer, ByVal ID_Bomon As Integer, ByVal ID_Phong As Integer) As DataTable
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_Khoa", ID_Khoa)
                para(2) = New SqlParameter("@ID_Bomon", ID_Bomon)
                para(3) = New SqlParameter("@ID_Phong", ID_Phong)
                Return Connect.SelectTableSP("SYS_NguoiDung_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSUsersQuyen_DanhSach(ByVal ID_ph As Integer, ByVal UserID As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_ph", ID_ph)
                para(1) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("SYS_NguoiDungQuyen_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSUsersHeAccess_DanhSach(ByVal UserID As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("SYS_NguoiDungAccessHe_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSUsersLopAccess_DanhSach(ByVal ID_he As Integer, ByVal ID_Khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_he", ID_he)
                para(1) = New SqlParameter("@ID_khoa", ID_Khoa)
                para(2) = New SqlParameter("@Khoa_hoc", Khoa_hoc)
                para(3) = New SqlParameter("@ID_nganh", ID_nganh)
                para(4) = New SqlParameter("@ID_chuyen_nganh", ID_chuyen_nganh)
                Return Connect.SelectTableSP("SYS_NguoiDungAccessLop_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHe_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_He_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhoa_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_Khoa_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhoaHoc_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_KhoaHoc_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSNganh_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_Nganh_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSChuyenNganh_DanhSach() As DataTable
            Try
                Return Connect.SelectTableSP("STU_ChuyenNganh_HienThi_DanhSach")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSUsers(ByVal obj As ESSUsers) As Integer
            Try
                Dim para(13) As SqlParameter
                para(0) = New SqlParameter("@UserName", obj.UserName)
                para(1) = New SqlParameter("@PassWord", obj.PassWord)
                para(2) = New SqlParameter("@FullName", obj.FullName)
                para(3) = New SqlParameter("@UserGroup", obj.UserGroup)
                para(4) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(5) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(6) = New SqlParameter("@ID_Bomon", obj.ID_Bomon)
                para(7) = New SqlParameter("@Active", obj.Active)
                para(8) = New SqlParameter("@May_tram", obj.May_tram)
                para(9) = New SqlParameter("@UserNameLDAP", obj.UserNameLDAP)
                para(10) = New SqlParameter("@adsPathLDAP", obj.adsPathLDAP)
                para(11) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                para(12) = New SqlParameter("@Email", obj.Email)
                para(13) = New SqlParameter("@MAC", obj.MAC)
                Connect.ExecuteSP("SYS_NguoiDung_ThemMoi", para)
                Return GetMaxID_Users()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSUserVaiTro(ByVal obj As ESSVaiTro, ByVal UserID As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_vai_tro", obj.ID_vai_tro)
                para(1) = New SqlParameter("@UserID", UserID)
                Return Connect.ExecuteSP("SYS_NguoiDungVaiTro_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSUsers(ByVal obj As ESSUsers, ByVal UserID As Integer) As Integer
            Try
                Dim para(14) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@UserName", obj.UserName)
                para(2) = New SqlParameter("@PassWord", obj.PassWord)
                para(3) = New SqlParameter("@FullName", obj.FullName)
                para(4) = New SqlParameter("@UserGroup", obj.UserGroup)
                para(5) = New SqlParameter("@Active", obj.Active)
                para(6) = New SqlParameter("@ID_phong", obj.ID_phong)
                para(7) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(8) = New SqlParameter("@ID_Bomon", obj.ID_Bomon)
                para(9) = New SqlParameter("@May_tram", obj.May_tram)
                para(10) = New SqlParameter("@UserNameLDAP", obj.UserNameLDAP)
                para(11) = New SqlParameter("@adsPathLDAP", obj.adsPathLDAP)
                para(12) = New SqlParameter("@Dien_thoai", obj.Dien_thoai)
                para(13) = New SqlParameter("@Email", obj.Email)
                para(14) = New SqlParameter("@MAC", obj.MAC)
                Return Connect.ExecuteSP("SYS_NguoiDung_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSUsersAccessHe(ByVal obj As ESSUsersHeAcess, ByVal UserID As Integer) As Integer
            Try
                Dim para(5) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_he", obj.ID_he)
                para(2) = New SqlParameter("@ID_khoa", obj.ID_khoa)
                para(3) = New SqlParameter("@Khoa_hoc", obj.Khoa_hoc)
                para(4) = New SqlParameter("@ID_nganh", obj.ID_nganh)
                para(5) = New SqlParameter("@ID_chuyen_nganh", obj.ID_chuyen_nganh)
                Return Connect.ExecuteSP("SYS_NguoiDungAccessHe_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSUsersAccessHe(ByVal UserID As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.ExecuteSP("SYS_NguoiDungAccessHe_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSUsers(ByVal UserID As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.ExecuteSP("SYS_NguoiDung_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSUserVaiTro(ByVal UserID As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Return Connect.ExecuteSP("SYS_NguoiDungVaiTro_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_Users(ByVal UserName As String) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDung_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_Users(ByVal UserName As String, ByVal UserID As Integer) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserName", UserName)
                para(1) = New SqlParameter("@UserID", UserID)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDung_KiemTraTonTaiKhac", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function KiemTra_UsersVaiTro(ByVal UserID As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDungVaiTro_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_UsersAccessHe(ByVal UserID As Integer) As Boolean
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDungAccessHe_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMaxID_Users() As Integer
            Try
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDung_GetMaxID")
                Return dt.Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_IP(ByVal UserID As Integer, ByVal IP As String) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@IP", IP)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDungCheckIP_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function KiemTra_Mac(ByVal UserID As Integer, ByVal MAC As String) As Boolean
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@MAC", MAC)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_NguoiDungCheckMAC_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

    End Class
End Namespace

