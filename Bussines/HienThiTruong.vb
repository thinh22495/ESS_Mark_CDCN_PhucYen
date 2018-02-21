Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HienThiTruong_Bussines
#Region "Functions And Subs"
        ' Load nhớm trường hiển thị
        Public Function HienThi_ESSNhomTruongHienThi(ByVal ID_phan_he As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DataAccess
                Dim dt As DataTable
                dt = obj.HienThi_ESSNhomTruongHienThi_DanhSach(ID_phan_he)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load trường hiển thị người dùng
        Public Function HienThi_ESSTruongHienThiNguoiDung(ByVal ID_phan_he As Integer, ByVal ID_user As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DataAccess
                Dim dt As DataTable
                dt = obj.HienThi_ESSTruongHienThiNguoiDung(ID_phan_he, ID_user)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load trường hiển thị người dùng
        Public Function HienThi_ESSTruongHienThiMacDinh(ByVal FieldGroup As Integer) As DataTable
            Try
                Dim obj As New HienThiTruong_DataAccess
                Dim dt As DataTable
                dt = obj.HienThi_ESSTruongHienThiMacDinh(FieldGroup)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Delete Trường hiển thị người dùng
        Public Function Xoa_ESSFielUser(ByVal ID_user As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DataAccess
                Return obj.Xoa_ESSFielUser(ID_user)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Delete Trường hiển thị mặc định
        Public Function Xoa_ESSFielDefaul(ByVal FieldGroup As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DataAccess
                Return obj.Xoa_ESSFielDefaul(FieldGroup)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSFieldUser(ByVal ID_user As Integer, ByVal FieldID As String, ByVal FieldSize As Double, ByVal STT As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DataAccess
                Return obj.ThemMoi_ESSFieldUser(ID_user, FieldID, FieldSize, STT)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSFieldDefault(ByVal FieldGroup As Integer, ByVal FieldID As String, ByVal STT As Integer) As Integer
            Try
                Dim obj As New HienThiTruong_DataAccess
                Return obj.ThemMoi_ESSFieldDefault(FieldGroup, FieldID, STT)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region
    End Class
End Namespace
