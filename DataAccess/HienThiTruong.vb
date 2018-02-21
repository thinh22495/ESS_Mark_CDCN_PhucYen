Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OracleClient
Imports ESSConnect
Imports ESS.Objects
Namespace DataAccess
    Public Class HienThiTruong_DataAccess
        Public Function HienThi_ESSNhomTruongHienThi_DanhSach(ByVal ID_phan_he As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_he", ID_phan_he)
                Return Connect.SelectTableSP("SYS_NhomTruongHienThi_HienThi_DanhSach", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTruongHienThiNguoiDung(ByVal ID_phan_he As Integer, ByVal ID_user As Integer) As DataTable
            Try
                Dim para(1) As SqlParameter
                para(0) = New SqlParameter("@ID_phan_he", ID_phan_he)
                para(1) = New SqlParameter("@ID_user", ID_user)
                Return Connect.SelectTableSP("SYS_TruongHienThiNguoiDung_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSTruongHienThiMacDinh(ByVal FieldGroup As Integer) As DataTable
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                Return Connect.SelectTableSP("SYS_TruongHienThiMacDinh_HienThi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSFielUser(ByVal ID_user As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@ID_user", ID_user)
                Return Connect.ExecuteSP("SYS_TruongHienThiNguoiDung_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSFielDefaul(ByVal FieldGroup As Integer) As Integer
            Try
                Dim para(0) As SqlParameter
                para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                Return Connect.ExecuteSP("SYS_TruongHienThiMacDinh_Xoa", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSFieldUser(ByVal ID_user As Integer, ByVal FieldID As String, ByVal FieldSize As Double, ByVal STT As Integer) As Integer
            Try
                Dim para(3) As SqlParameter
                para(0) = New SqlParameter("@ID_user", SqlDbType.Int)
                para(0).Value = ID_user
                para(1) = New SqlParameter("@FieldID", SqlDbType.NVarChar)
                para(1).Value = FieldID
                para(2) = New SqlParameter("@FieldSize", SqlDbType.Float)
                para(2).Value = FieldSize
                para(3) = New SqlParameter("@STT", SqlDbType.Int)
                para(3).Value = STT
                Return Connect.ExecuteSP("SYS_TruongHienThiNguoiDung_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSFieldDefault(ByVal FieldGroup As Integer, ByVal FieldID As String, ByVal STT As Integer) As Integer
            Try
                Dim para(2) As SqlParameter
                para(0) = New SqlParameter("@FieldGroup", FieldGroup)
                para(1) = New SqlParameter("@FieldID", FieldID)
                para(2) = New SqlParameter("@STT", STT)
                Return Connect.ExecuteSP("SYS_TruongHienThiMacDinh_ThemMoi", para)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace


