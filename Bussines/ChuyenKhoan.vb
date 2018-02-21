Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ChuyenKhoan_BLL
#Region "Constructor"
        Sub New()
        End Sub
#End Region
#Region "Function"
        Public Function Check_ChuyenKhoan(ByVal Ngay_giao_dich As Date) As Boolean
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.CheckExist_ChuyenKhoan(Ngay_giao_dich)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function Update_ChuyenKhoan(ByVal So_tai_khoan As String, ByVal IDSV As String, ByVal Ngay_giao_dich As Date) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Update_svChuyenKhoan(So_tai_khoan, IDSV, Ngay_giao_dich)
            Catch ex As Exception
            End Try
        End Function
        Public Sub getSVInfor_TheoSoTaiKhoan(ByVal So_tai_khoan As String, ByRef ID_SV As Long, ByRef Ngoai_ngan_sach As Integer, ByRef Lop_Chat_Luong_Cao As Integer, ByRef ID_he As Integer, ByRef Khoa_hoc As Integer)
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                obj.getSVInfor_TheoSoTaiKhoan(So_tai_khoan, ID_SV, Ngoai_ngan_sach, Lop_Chat_Luong_Cao, ID_he, Khoa_hoc)
            Catch ex As Exception
            End Try
        End Sub

        Function Load_ChuyenKhoan_ChiTiet(ByVal Tu_ngay As Date, ByVal Den_ngay As Date, ByVal ID_he As String) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_ChuyenKhoanChiTiet_SV(Tu_ngay, Den_ngay, ID_he)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function Insert_ChuyenKhoan(ByVal ID_bien_lai As Long, ByVal So_tai_khoan As String, ByVal Ma_sv As String, ByVal Ngay_giao_dich As Date, ByVal So_tien As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Insert_ChuyenKhoan(ID_bien_lai, So_tai_khoan, Ma_sv, Ngay_giao_dich, So_tien)
            Catch ex As Exception
            End Try
        End Function
        Public Function GetSoTienChuyenKhoanChuaLapBienLai(ByVal So_tai_khoan As String) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.sp_svChuyenKhoan_GetSoTienChuaLapBienLai(So_tai_khoan)
            Catch ex As Exception
            End Try
        End Function
        Public Function ChuyenKhoan_Update_ID_bien_lai(ByVal So_tai_khoan As String, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.sp_svChuyenKhoan_Update_Id_bien_lai(So_tai_khoan, ID_bien_lai)
            Catch ex As Exception
            End Try
        End Function
        Public Function ChuyenKhoan_Update_ID_bien_lai(ByVal So_tai_khoan As String, ByVal Ngay_giao_dich As Date, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.sp_svChuyenKhoan_Update_Id_bien_lai(So_tai_khoan, Ngay_giao_dich, ID_bien_lai)
            Catch ex As Exception
            End Try
        End Function
        Public Function ChuyenKhoan_Get_SoDu(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.sp_svChuyenKhoan_Get_SoDu(ID_sv)
            Catch ex As Exception
            End Try
        End Function

        Function Load_ChuyenKhoan_Loi(ByVal Tu_ngay As Date, ByVal Den_ngay As Date, ByVal ID_he As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_ChuyenKhoan_Loi(Tu_ngay, Den_ngay, ID_he)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
#End Region
    End Class
End Namespace