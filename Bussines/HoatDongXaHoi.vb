'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, 11 June, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HoatDongXaHoi_Bussines
        Inherits ESSHoatDongXaHoi
#Region "Var"
        Private aHoatDongXaHois As ArrayList
#End Region

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_sv As Integer)
            Try
                aHoatDongXaHois = New ArrayList
                Dim obj As New HoatDongXaHoi_DataAccess
                Dim dtHoatDongXH As DataTable = obj.HienThi_ESSHoatDongXaHoiSv(ID_sv)
                Dim objHoatDongXH As New ESSHoatDongXaHoi
                Dim dr As DataRow = Nothing
                For Each dr In dtHoatDongXH.Rows
                    objHoatDongXH = MappingHDXH_SV(dr)
                    aHoatDongXaHois.Add(objHoatDongXH)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
        Public Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal ID_he As Integer = 0, Optional ByVal ID_khoa As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal ID_lop As Integer = 0)
            Try
                aHoatDongXaHois = New ArrayList
                Dim obj As New HoatDongXaHoi_DataAccess
                Dim dtHoatDongXH As DataTable = obj.HienThi_ESSHoatDongXaHoi(Hoc_ky, Nam_hoc, ID_he, ID_khoa, Khoa_hoc, ID_lop)
                Dim objHoatDongXH As New ESSHoatDongXaHoi
                Dim dr As DataRow = Nothing
                For Each dr In dtHoatDongXH.Rows
                    objHoatDongXH = Mapping(dr)
                    aHoatDongXaHois.Add(objHoatDongXH)
                Next
            Catch ex As Exception
                Throw (ex)
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSHoatDongXaHoi(ByVal ID_hd_xh As Integer) As ESSHoatDongXaHoi
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHoatDongXaHoi(ID_hd_xh)
                Dim objHoatDongXaHoi As ESSHoatDongXaHoi = Nothing
                If dt.Rows.Count > 0 Then
                    objHoatDongXaHoi = Mapping(dt.Rows(0))
                End If
                Return objHoatDongXaHoi
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoatDongXaHoi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_hd_xh", GetType(Integer))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Ngay_thang", GetType(Date))
                dt.Columns.Add("Ket_qua", GetType(String))
                dt.Columns.Add("Diem_thuong", GetType(Integer))
                dt.Columns.Add("Noi_dung", GetType(String))
                For i As Integer = 0 To aHoatDongXaHois.Count - 1
                    Dim row As DataRow = dt.NewRow
                    Dim objHoatDongXH As ESSHoatDongXaHoi = CType(aHoatDongXaHois(i), ESSHoatDongXaHoi)
                    row("ID_hd_xh") = objHoatDongXH.ID_hd_xh
                    row("ID_sv") = objHoatDongXH.ID_sv
                    row("Ma_sv") = objHoatDongXH.Ma_sv
                    row("Ho_ten") = objHoatDongXH.Ho_ten
                    row("Ngay_sinh") = Format(objHoatDongXH.Ngay_sinh.Date.ToString)
                    row("ID_lop") = objHoatDongXH.ID_lop
                    row("Ten_lop") = objHoatDongXH.Ten_lop
                    row("Hoc_ky") = objHoatDongXH.Hoc_ky
                    row("Nam_hoc") = objHoatDongXH.Nam_hoc
                    row("Ngay_thang") = Format(objHoatDongXH.Ngay_thang.Date.ToString)
                    row("Ket_qua") = objHoatDongXH.Ket_qua
                    row("Diem_thuong") = objHoatDongXH.Diem_thuong
                    row("Noi_dung") = objHoatDongXH.Noi_dung
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load Hoat dong xa hoi cua mot sinh viên
        Public Function HienThi_ESSHoatDongXaHoiSV() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ngay_thang", GetType(Date))
                dt.Columns.Add("Ket_qua", GetType(String))
                dt.Columns.Add("Diem_thuong", GetType(Integer))
                dt.Columns.Add("Noi_dung", GetType(String))
                For i As Integer = 0 To aHoatDongXaHois.Count - 1
                    Dim row As DataRow = dt.NewRow
                    Dim objHoatDongXH As ESSHoatDongXaHoi = CType(aHoatDongXaHois(i), ESSHoatDongXaHoi)
                    row("ID_sv") = objHoatDongXH.ID_sv
                    row("Ngay_thang") = Format(objHoatDongXH.Ngay_thang.Date.ToString)
                    row("Ket_qua") = objHoatDongXH.Ket_qua
                    row("Diem_thuong") = objHoatDongXH.Diem_thuong
                    row("Noi_dung") = objHoatDongXH.Noi_dung
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSHoatDongXaHoi_DanhSach() As ESSHoatDongXaHoi
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHoatDongXaHoi_DanhSach()
                Dim objHoatDongXaHoi As ESSHoatDongXaHoi = Nothing
                If dt.Rows.Count > 0 Then
                    objHoatDongXaHoi = Mapping(dt.Rows(0))
                End If
                Return objHoatDongXaHoi
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoatDongXaHoi(ByVal objHoatDongXaHoi As ESSHoatDongXaHoi) As Integer
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Return obj.ThemMoi_ESSHoatDongXaHoi(objHoatDongXaHoi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoatDongXaHoi(ByVal objHoatDongXaHoi As ESSHoatDongXaHoi) As Integer
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Return obj.CapNhat_ESSHoatDongXaHoi(objHoatDongXaHoi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoatDongXaHoi(ByVal ID_hd_xh As Integer) As Integer
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Return obj.Xoa_ESSHoatDongXaHoi(ID_hd_xh)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svHoatDongXaHoi(ByVal objHoatDongXaHoi As ESSHoatDongXaHoi) As Boolean
            Try
                Dim obj As HoatDongXaHoi_DataAccess = New HoatDongXaHoi_DataAccess
                Return obj.CheckExist_HoatDongXaHoi(objHoatDongXaHoi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function Mapping(ByVal drHoatDongXaHoi As DataRow) As ESSHoatDongXaHoi
            Dim result As ESSHoatDongXaHoi
            Try
                result = New ESSHoatDongXaHoi
                If drHoatDongXaHoi("ID_hd_xh").ToString() <> "" Then result.ID_hd_xh = CType(drHoatDongXaHoi("ID_hd_xh").ToString(), Integer)
                If drHoatDongXaHoi("ID_sv").ToString() <> "" Then result.ID_sv = CType(drHoatDongXaHoi("ID_sv").ToString(), Integer)
                result.Ma_sv = drHoatDongXaHoi("Ma_sv").ToString()
                result.Ho_ten = drHoatDongXaHoi("Ho_ten").ToString()
                If drHoatDongXaHoi("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drHoatDongXaHoi("Ngay_sinh").ToString(), Date)
                If drHoatDongXaHoi("ID_lop").ToString() <> "" Then result.ID_lop = CType(drHoatDongXaHoi("ID_lop").ToString(), Integer)
                result.Ten_lop = drHoatDongXaHoi("Ten_lop").ToString()
                If drHoatDongXaHoi("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drHoatDongXaHoi("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drHoatDongXaHoi("Nam_hoc").ToString()
                If drHoatDongXaHoi("Ngay_thang").ToString() <> "" Then result.Ngay_thang = CType(drHoatDongXaHoi("Ngay_thang").ToString(), Date)
                result.Noi_dung = drHoatDongXaHoi("Noi_dung").ToString()
                result.Ket_qua = drHoatDongXaHoi("Ket_qua").ToString()
                If drHoatDongXaHoi("Diem_thuong").ToString() <> "" Then result.Diem_thuong = CType(drHoatDongXaHoi("Diem_thuong").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingHDXH_SV(ByVal drHoatDongXaHoi As DataRow) As ESSHoatDongXaHoi
            Dim result As ESSHoatDongXaHoi
            Try
                result = New ESSHoatDongXaHoi
                If drHoatDongXaHoi("ID_sv").ToString() <> "" Then result.ID_sv = CType(drHoatDongXaHoi("ID_sv").ToString(), Integer)
                If drHoatDongXaHoi("Ngay_thang").ToString() <> "" Then result.Ngay_thang = CType(drHoatDongXaHoi("Ngay_thang").ToString(), Date)
                result.Noi_dung = drHoatDongXaHoi("Noi_dung").ToString()
                result.Ket_qua = drHoatDongXaHoi("Ket_qua").ToString()
                If drHoatDongXaHoi("Diem_thuong").ToString() <> "" Then result.Diem_thuong = CType(drHoatDongXaHoi("Diem_thuong").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
    End Class
End Namespace
