'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, June 01, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class KhenThuong_Bussines
        Private arrKhenThuong As New ArrayList
        Private dtSinhVienKT As DataTable  ' Danh sách sinh viên khen thưởng

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKhenThuong(ID_lops)
                Dim objKhenThuong As New ESSKhenThuong
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKhenThuong = Mapping(dr)
                    arrKhenThuong.Add(objKhenThuong)
                Next
                dtSinhVienKT = obj.HienThi_ESSSinhVienKhenThuong(ID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        ' Load Khen thuong sinh vien
        Public Function HienThi_ESSQDKhenThuong() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hinh_thuc", GetType(String))
                For i As Integer = 0 To arrKhenThuong.Count - 1
                    Dim kt As ESSKhenThuong = CType(arrKhenThuong(i), ESSKhenThuong)
                    Dim row As DataRow = dt.NewRow()
                    row("So_QD") = kt.So_QD
                    row("Ngay_QD") = kt.Ngay_QD 'Format(kt.Ngay_QD, "dd/MM/yyyy")
                    row("Hinh_thuc") = kt.Hinh_thuc
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh vien theo ID_khen_thuong
        Public Function HienThi_ESSSinhVienKhenThuong(ByVal ID_khen_thuong As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienKT.Rows.Count - 1
                    If dtSinhVienKT.Rows(i).Item("ID_khen_thuong") = ID_khen_thuong Then
                        row = dt.NewRow
                        row("Chon") = False
                        row("ID_sv") = dtSinhVienKT.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSinhVienKT.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSinhVienKT.Rows(i)("Ho_ten")
                        row("Ngay_sinh") = dtSinhVienKT.Rows(i)("Ngay_sinh") 'Format(dtSinhVienKT.Rows(i)("Ngay_sinh"), "dd/MM/yyyy")
                        row("Ten_lop") = dtSinhVienKT.Rows(i)("Ten_lop")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_khen_thuong", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(Date))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_loai_kt", GetType(Integer))
                dt.Columns.Add("Hinh_thuc", GetType(String))
                dt.Columns.Add("Ten_cap", GetType(String))
                For i As Integer = 0 To arrKhenThuong.Count - 1
                    Dim kt As ESSKhenThuong = CType(arrKhenThuong(i), ESSKhenThuong)
                    If kt.Hoc_ky = Hoc_ky And kt.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_khen_thuong") = kt.ID_khen_thuong
                        row("So_QD") = kt.So_QD
                        row("Ngay_QD") = kt.Ngay_QD '  Format(kt.Ngay_QD, "dd/MM/yyyy")
                        row("Hoc_ky") = kt.Hoc_ky
                        row("Nam_hoc") = kt.Nam_hoc
                        row("ID_loai_kt") = kt.ID_loai_kt
                        row("Hinh_thuc") = kt.Hinh_thuc
                        row("Ten_cap") = kt.Ten_cap
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKhenThuong(ByVal ID_khen_thuong As Integer) As ESSKhenThuong
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKhenThuong(ID_khen_thuong)
                Dim objKhenThuong As ESSKhenThuong = Nothing
                If dt.Rows.Count > 0 Then
                    objKhenThuong = Mapping(dt.Rows(0))
                End If
                Return objKhenThuong
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSKhenThuong(ByVal objKhenThuong As ESSKhenThuong) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.ThemMoi_ESSKhenThuong(objKhenThuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.ThemMoi_ESSKhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhenThuong(ByVal objKhenThuong As ESSKhenThuong, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.CapNhat_ESSKhenThuong(objKhenThuong, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.CapNhat_ESSKhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhenThuong(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.Xoa_ESSKhenThuong(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKhenThuongSinhVien(ByVal ID_khen_thuong As Integer) As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.Xoa_ESSKhenThuongSinhVien(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKhenThuong(ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                obj.CheckExist_KhenThuong(ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKhenThuongSinhVien(ByVal ID_sv As Integer, ByVal ID_khen_thuong As Integer) As Boolean
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.CheckExist_KhenThuongSinhVien(ID_sv, ID_khen_thuong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svKhenThuong() As Integer
            Try
                Dim obj As KhenThuong_DataAccess = New KhenThuong_DataAccess
                Return obj.GetMaxID_KhenThuong()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drKhenThuong As DataRow) As ESSKhenThuong
            Dim result As ESSKhenThuong
            Try
                result = New ESSKhenThuong
                If drKhenThuong("ID_khen_thuong").ToString() <> "" Then result.ID_khen_thuong = CType(drKhenThuong("ID_khen_thuong").ToString(), Integer)
                result.So_QD = drKhenThuong("So_QD").ToString()
                If drKhenThuong("Ngay_QD").ToString() <> "" Then result.Ngay_QD = CType(drKhenThuong("Ngay_QD").ToString(), Date)
                If drKhenThuong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKhenThuong("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKhenThuong("Nam_hoc").ToString()
                If drKhenThuong("ID_loai_kt").ToString() <> "" Then result.ID_loai_kt = CType(drKhenThuong("ID_loai_kt").ToString(), Integer)
                If drKhenThuong("ID_cap").ToString() <> "" Then result.ID_cap = CType(drKhenThuong("ID_cap").ToString(), Integer)
                result.Hinh_thuc = drKhenThuong("Hinh_thuc").ToString()
                If drKhenThuong("Ten_cap").ToString() <> "" Then result.Ten_cap = CType(drKhenThuong("Ten_cap").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddKhenThuong(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Khen_thuong", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    If CInt(dtDSSV.Rows(i)("ID_xep_loai")) > 0 And CInt(dtDSSV.Rows(i)("ID_xep_loai")) <= 3 Then
                        dtDSSV.Rows(i)("Khen_thuong") = "SV " & dtDSSV.Rows(i)("Xep_loai")
                    End If
                Next
            Catch ex As Exception
            End Try
        End Sub

#End Region
    End Class
End Namespace
