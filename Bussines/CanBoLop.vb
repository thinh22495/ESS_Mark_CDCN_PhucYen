'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class CanBoLop_Bussines
        Inherits ESSCanBoLop
        Private arrCanBoLop As New ArrayList
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                Dim obj As CanBoLop_DataAccess = New CanBoLop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSCanBoLop_DanhSach(ID_lops)
                Dim objCanBoLop As ESSCanBoLop = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objCanBoLop = Mapping(dt.Rows(i))
                    arrCanBoLop.Add(objCanBoLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSCanBoLop_ListID_svs(ByVal ID_sv As String) As DataTable
            Try
                Dim dtcb As New DataTable
                dtcb.Columns.Add("Chon", GetType(Boolean))
                dtcb.Columns.Add("ID_sv", GetType(Integer))
                dtcb.Columns.Add("Ma_sv", GetType(String))
                dtcb.Columns.Add("Ho_ten", GetType(String))
                dtcb.Columns.Add("Ngay_sinh", GetType(String))
                dtcb.Columns.Add("Gioi_tinh", GetType(String))
                dtcb.Columns.Add("Noi_sinh", GetType(String))
                dtcb.Columns.Add("Ten_lop", GetType(String))
                dtcb.Columns.Add("ID_chuc_danh", GetType(Integer))
                dtcb.Columns.Add("Chuc_danh", GetType(String))
                dtcb.Columns.Add("Chuc_danh_kiem", GetType(String))
                dtcb.Columns.Add("Nam_bat_dau", GetType(Integer))
                dtcb.Columns.Add("Nam_ket_thuc", GetType(Integer))
                Dim row As DataRow
                For i As Integer = 0 To arrCanBoLop.Count - 1
                    Dim obj As New ESSCanBoLop
                    obj = arrCanBoLop(i)
                    If obj.ID_sv = CInt(ID_sv) Then
                        row = dtcb.NewRow
                        row("Chon") = False
                        row("ID_sv") = obj.ID_sv
                        row("Ma_sv") = obj.Ma_sv
                        row("Ho_ten") = obj.Ho_ten
                        row("Ngay_sinh") = obj.Ngay_sinh
                        row("Gioi_tinh") = obj.Gioi_tinh
                        row("Noi_sinh") = ""
                        row("Ten_lop") = obj.Ten_lop
                        row("ID_chuc_danh") = obj.ID_chuc_danh
                        row("Chuc_danh") = obj.Chuc_danh
                        row("Chuc_danh_kiem") = obj.Chuc_danh_kiem
                        row("Nam_bat_dau") = obj.Nam_bat_dau
                        row("Nam_ket_thuc") = obj.Nam_ket_thuc
                        dtcb.Rows.Add(row)
                    End If
                Next
                Return dtcb
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSCanBoLop_DanhSach() As DataTable
            Try
                Dim dtcb As New DataTable
                dtcb.Columns.Add("Chon", GetType(Boolean))
                dtcb.Columns.Add("ID_sv", GetType(Integer))
                dtcb.Columns.Add("Ma_sv", GetType(String))
                dtcb.Columns.Add("Ho_ten", GetType(String))
                dtcb.Columns.Add("Ngay_sinh", GetType(Date))
                dtcb.Columns.Add("Gioi_tinh", GetType(String))
                dtcb.Columns.Add("Noi_sinh", GetType(String))
                dtcb.Columns.Add("Ten_lop", GetType(String))
                dtcb.Columns.Add("ID_chuc_danh", GetType(Integer))
                dtcb.Columns.Add("Chuc_danh", GetType(String))
                dtcb.Columns.Add("Chuc_danh_kiem", GetType(String))
                dtcb.Columns.Add("Nam_bat_dau", GetType(Integer))
                dtcb.Columns.Add("Nam_ket_thuc", GetType(Integer))
                Dim row As DataRow
                For i As Integer = 0 To arrCanBoLop.Count - 1
                    Dim obj As New ESSCanBoLop
                    obj = arrCanBoLop(i)
                    row = dtcb.NewRow
                    row("Chon") = False
                    row("ID_sv") = obj.ID_sv
                    row("Ma_sv") = obj.Ma_sv
                    row("Ho_ten") = obj.Ho_ten
                    row("Ngay_sinh") = CDate(obj.Ngay_sinh)
                    row("Gioi_tinh") = obj.Gioi_tinh
                    row("Noi_sinh") = ""
                    row("Ten_lop") = obj.Ten_lop
                    row("ID_chuc_danh") = obj.ID_chuc_danh
                    row("Chuc_danh") = obj.Chuc_danh
                    row("Chuc_danh_kiem") = obj.Chuc_danh_kiem
                    row("Nam_bat_dau") = obj.Nam_bat_dau
                    row("Nam_ket_thuc") = obj.Nam_ket_thuc
                    dtcb.Rows.Add(row)
                Next
                Return dtcb
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSCanBoLop(ByVal objCanBoLop As ESSCanBoLop) As Integer
            Try
                Dim obj As CanBoLop_DataAccess = New CanBoLop_DataAccess
                Return obj.ThemMoi_ESSCanBoLop(objCanBoLop)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSCanBoLop(ByVal objCanBoLop As ESSCanBoLop, ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As CanBoLop_DataAccess = New CanBoLop_DataAccess
                Return obj.CapNhat_ESSCanBoLop(objCanBoLop, ID_sv, Nam_bat_dau, ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSCanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Integer
            Try
                Dim obj As CanBoLop_DataAccess = New CanBoLop_DataAccess
                Return obj.Xoa_ESSCanBoLop(ID_sv, Nam_bat_dau, ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svCanBoLop(ByVal ID_sv As Integer, ByVal Nam_bat_dau As Integer, ByVal ID_chuc_danh As Integer) As Boolean
            Try
                Dim obj As CanBoLop_DataAccess = New CanBoLop_DataAccess
                Return obj.CheckExist_CanBoLop(ID_sv, Nam_bat_dau, ID_chuc_danh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drCanBoLop As DataRow) As ESSCanBoLop
            Dim result As ESSCanBoLop
            Try
                result = New ESSCanBoLop
                If drCanBoLop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drCanBoLop("ID_sv").ToString(), Integer)
                If drCanBoLop("Nam_bat_dau").ToString() <> "" Then result.Nam_bat_dau = CType(drCanBoLop("Nam_bat_dau").ToString(), Integer)
                If drCanBoLop("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drCanBoLop("ID_chuc_danh").ToString(), Integer)
                If drCanBoLop("Chuc_danh").ToString() <> "" Then result.Chuc_danh = drCanBoLop("Chuc_danh").ToString()
                If drCanBoLop("Chuc_danh_kiem").ToString() <> "" Then result.Chuc_danh_kiem = drCanBoLop("Chuc_danh_kiem").ToString()
                result.Chuc_danh_kiem = drCanBoLop("Chuc_danh_kiem").ToString()
                If drCanBoLop("Nam_ket_thuc").ToString() <> "" Then result.Nam_ket_thuc = CType(drCanBoLop("Nam_ket_thuc").ToString(), Integer)
                If drCanBoLop("Ma_sv").ToString() <> "" Then result.Ma_sv = drCanBoLop("Ma_sv").ToString()
                If drCanBoLop("Ho_ten").ToString() <> "" Then result.Ho_ten = drCanBoLop("Ho_ten").ToString()
                If drCanBoLop("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CDate(drCanBoLop("Ngay_sinh"))
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
