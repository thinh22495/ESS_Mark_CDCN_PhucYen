'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/21/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class VaiTro_DataAccess

#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSVaiTro_DanhSach(ByVal UserID As Integer) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@UserID", UserID)
                Return Connect.SelectTableSP("SYS_VaiTro_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSVaiTro(ByVal obj As ESSVaiTro) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@Ten_vai_tro", obj.Ten_vai_tro)
                para(1) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                Connect.ExecuteSP("SYS_VaiTro_ThemMoi", para)
                Return GetMaxID_VaiTro()
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSVaiTro(ByVal obj As ESSVaiTro, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                para(1) = New SqlParameter("@Ten_vai_tro", obj.Ten_vai_tro)
                para(2) = New SqlParameter("@Mo_ta", obj.Mo_ta)
                Return Connect.ExecuteSP("SYS_VaiTro_CapNhat", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSVaiTro(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Return Connect.ExecuteSP("SYS_VaiTro_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function GetMaxID_VaiTro() As Integer
            Try
                Dim dt As DataTable = Connect.SelectTable("SYS_VaiTro_GetMaxID")
                Return dt.Rows(0)(0)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_VaiTroQuyen(ByVal ID_vai_tro As Integer) As Boolean
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Dim dt As DataTable = Connect.SelectTableSP("SYS_VaiTroQuyen_KiemTraTonTai", para)
                If dt.Rows(0)(0) > 0 Then
                    Return True
                End If
                Return False
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

        Public Function ThemMoi_ESSVaiTroQuyen(ByVal obj As ESSVaiTroQuyen, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para(4) As SqlParameter
                para(0) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                para(1) = New SqlParameter("@ID_quyen", obj.ID_quyen)
                para(2) = New SqlParameter("@Them", obj.Them)
                para(3) = New SqlParameter("@Sua", obj.Sua)
                para(4) = New SqlParameter("@Xoa", obj.Xoa)
                Return Connect.ExecuteSP("SYS_VaiTroQuyen_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSVaiTroQuyen(ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Return Connect.ExecuteSP("SYS_VaiTroQuyen_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ThemMoi_ESSUsersVaiTro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Return Connect.ExecuteSP("SYS_NguoiDungVaiTro_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSUsersVaitro(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As Integer
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Return Connect.ExecuteSP("SYS_NguoiDungVaiTro_Xoa_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function



        Public Function HienThi_ESSUserQuyen(ByVal UserID As Integer, ByVal ID_vai_tro As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@UserID", UserID)
                para(1) = New SqlParameter("@ID_vai_tro", ID_vai_tro)
                Return Connect.SelectTableSP("SYS_NguoiDungVaiTro_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSPhanHe() As DataTable
            Try
                Return Connect.SelectTableSP("SYS_PhanHe_HienThi")
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSPhanHe_DanhSach(ByVal User As ESSUsers) As DataTable
            Try
                Dim para As SqlParameter
                para = New SqlParameter("@UserID", User.UserID)
                Return Connect.SelectTableSP("SYS_PhanHe_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

    End Class
End Namespace

