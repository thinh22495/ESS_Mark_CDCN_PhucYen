'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, 04 June, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class KyLuat_Bussines
        Inherits ESSKyLuat
#Region "Var"
        Private arrKyLuat As ArrayList
        Private dtSinhVienKL As DataTable
#End Region
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal ID_lops As String)
            Try
                arrKyLuat = New ArrayList
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKyLuatLop(ID_lops)
                Dim objKyLuat As New ESSKyLuat
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKyLuat = Mapping(dr)
                    arrKyLuat.Add(objKyLuat)
                Next
                dtSinhVienKL = obj.HienThi_ESSSinhVienKyLuat(ID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        ' Danh sach ky luat của một sinh viên f
        Public Sub New(ByVal ID_sv As Integer)
            Try
                arrKyLuat = New ArrayList
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKyLuatSV(ID_sv)
                Dim objKyLuat As New ESSKyLuat
                Dim dr As DataRow = Nothing
                For Each dr In dt.Rows
                    objKyLuat = Mapping(dr)
                    arrKyLuat.Add(objKyLuat)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function HienThi_ESSKyLuat_SQD(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa")
                dt.Columns.Add("Lydo_xoa")
                dt.Columns.Add("Noi_dung")
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As ESSKyLuat = CType(arrKyLuat(i), ESSKyLuat)
                    If kl.Hoc_ky = Hoc_ky And kl.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_ky_luat") = kl.ID_ky_luat
                        row("So_QD") = kl.So_qd
                        row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                        row("Ngay_xoa") = kl.Ngay_xoa
                        row("ID_hanh_vi") = kl.ID_hanh_vi
                        row("Hanh_vi") = kl.Hanh_vi
                        row("ID_xu_ly") = kl.ID_xu_ly
                        row("Xu_ly") = kl.Xu_ly
                        row("Xoa_ky_luat") = kl.Xoa_ky_luat
                        row("Lydo_xoa") = kl.Lydo_xoa
                        row("Noi_dung") = kl.Noi_dung
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sach ky luat cua một sinh viên
        Public Function LoadKyLuatSinhVien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Xu_ly", GetType(String))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As ESSKyLuat = CType(arrKyLuat(i), ESSKyLuat)
                    Dim row As DataRow = dt.NewRow()
                    row("So_QD") = kl.So_qd
                    row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                    row("Hanh_vi") = kl.Hanh_vi
                    row("Xu_ly") = kl.Xu_ly
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Load danh sách sinh vien theo ID_ky_luat ffff
        Public Function HienThi_ESSSinhVienKyLuat(ByVal ID_ky_luat As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop")
                dt.Columns.Add("ID_lop")
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                Dim row As DataRow
                For i As Integer = 0 To dtSinhVienKL.Rows.Count - 1
                    If dtSinhVienKL.Rows(i).Item("ID_ky_luat") = ID_ky_luat Then
                        row = dt.NewRow
                        row("Chon") = False
                        row("ID_sv") = dtSinhVienKL.Rows(i)("ID_sv")
                        row("Ma_sv") = dtSinhVienKL.Rows(i)("Ma_sv")
                        row("Ho_ten") = dtSinhVienKL.Rows(i)("Ho_ten")
                        row("Ngay_sinh") = dtSinhVienKL.Rows(i)("Ngay_sinh")
                        row("Ten_lop") = dtSinhVienKL.Rows(i)("Ten_lop")
                        row("Xoa_ky_luat") = dtSinhVienKL.Rows(i)("Xoa_ky_luat")
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKyLuat(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Noi_dung", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("ID_cap", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa", GetType(String))
                dt.Columns.Add("Lydo_xoa", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Muc_xu_ly", GetType(Integer))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As ESSKyLuat = CType(arrKyLuat(i), ESSKyLuat)
                    If kl.Hoc_ky = Hoc_ky And kl.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = kl.ID_sv
                        row("ID_ky_luat") = kl.ID_ky_luat
                        row("So_QD") = kl.So_qd
                        row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                        row("Hoc_ky") = kl.Hoc_ky
                        row("Nam_hoc") = kl.Nam_hoc
                        row("ID_hanh_vi") = kl.ID_hanh_vi
                        row("Hanh_vi") = kl.Hanh_vi
                        row("ID_xu_ly") = kl.ID_xu_ly
                        row("Xu_ly") = kl.Xu_ly
                        row("Xoa_ky_luat") = kl.Xoa_ky_luat
                        row("ID_cap") = kl.ID_cap
                        row("Ten_cap") = kl.Ten_cap
                        row("Noi_dung") = kl.Noi_dung
                        row("Ngay_xoa") = kl.Ngay_xoa
                        row("Lydo_xoa") = kl.Lydo_xoa
                        row("ID_lop") = kl.ID_lop
                        row("Muc_xu_ly") = kl.Muc_xu_ly
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKyLuat_NamHoc(ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_ky_luat", GetType(Integer))
                dt.Columns.Add("So_QD", GetType(String))
                dt.Columns.Add("Ngay_QD", GetType(DateTime))
                dt.Columns.Add("Hoc_ky", GetType(Integer))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_hanh_vi", GetType(Integer))
                dt.Columns.Add("Hanh_vi", GetType(String))
                dt.Columns.Add("Noi_dung", GetType(String))
                dt.Columns.Add("ID_xu_ly", GetType(Integer))
                dt.Columns.Add("Xu_ly", GetType(String))
                dt.Columns.Add("ID_cap", GetType(Integer))
                dt.Columns.Add("Ten_cap", GetType(String))
                dt.Columns.Add("Xoa_ky_luat", GetType(Boolean))
                dt.Columns.Add("Ngay_xoa", GetType(String))
                dt.Columns.Add("Lydo_xoa", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Muc_xu_ly", GetType(Integer))
                For i As Integer = 0 To arrKyLuat.Count - 1
                    Dim kl As ESSKyLuat = CType(arrKyLuat(i), ESSKyLuat)
                    If kl.Nam_hoc = Nam_hoc Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = kl.ID_sv
                        row("ID_ky_luat") = kl.ID_ky_luat
                        row("So_QD") = kl.So_qd
                        row("Ngay_QD") = Format(kl.Ngay_qd, "dd/MM/yyyy")
                        row("Hoc_ky") = kl.Hoc_ky
                        row("Nam_hoc") = kl.Nam_hoc
                        row("ID_hanh_vi") = kl.ID_hanh_vi
                        row("Hanh_vi") = kl.Hanh_vi
                        row("ID_xu_ly") = kl.ID_xu_ly
                        row("Xu_ly") = kl.Xu_ly
                        row("Xoa_ky_luat") = kl.Xoa_ky_luat
                        row("ID_cap") = kl.ID_cap
                        row("Ten_cap") = kl.Ten_cap
                        row("Noi_dung") = kl.Noi_dung
                        row("Ngay_xoa") = kl.Ngay_xoa
                        row("Lydo_xoa") = kl.Lydo_xoa
                        row("ID_lop") = kl.ID_lop
                        row("Muc_xu_ly") = kl.Muc_xu_ly
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKyLuat(ByVal ID_ky_luat As Integer) As ESSKyLuat
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKyLuat(ID_ky_luat)
                Dim objKyLuat As New ESSKyLuat
                If dt.Rows.Count > 0 Then
                    objKyLuat = Mapping(dt.Rows(0))
                End If
                Return objKyLuat
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSKyLuat_Sinhvien(ByVal ID_ky_luat As Integer) As ESSKyLuat
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSKyLuat(ID_ky_luat)
                Dim objKyLuat As New ESSKyLuat
                If dt.Rows.Count > 0 Then
                    objKyLuat = Mapping(dt.Rows(0))
                End If
                Return objKyLuat
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKyLuat(ByVal objKyLuat As ESSKyLuat) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.ThemMoi_ESSKyLuat(objKyLuat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSKyLuatSinhvien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.ThemMoi_ESSKyLuatSinhvien(ID_sv, ID_ky_luat, Xoa_ky_luat, Ngay_xoa, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSKyLuat(ByVal objKyLuat As ESSKyLuat, ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.CapNhat_ESSKyLuat(objKyLuat, ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSKyLuatSinhvien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer, ByVal Xoa_ky_luat As Integer, ByVal Ngay_xoa As Date, ByVal Ly_do As String) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.CapNhat_ESSKyLuatSinhVien(ID_sv, ID_ky_luat, Xoa_ky_luat, Ngay_xoa, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSKyLuat(ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.Xoa_ESSKyLuat(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSKyLuatSinhvien(ByVal ID_ky_luat As Integer) As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.Xoa_ESSKyLuatSinhVien(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKyLuat(ByVal ID_ky_luat As Integer) As Boolean
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                obj.CheckExist_svKyLuat(ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svKyLuatSinhVien(ByVal ID_sv As Integer, ByVal ID_ky_luat As Integer) As Boolean
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.CheckExist_svKyLuatSinhVien(ID_sv, ID_ky_luat)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svKyLuat() As Integer
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.GetMaxID_svKyLuat()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drKyLuat As DataRow) As ESSKyLuat
            Dim result As ESSKyLuat
            Try
                result = New ESSKyLuat
                result.ID_sv = drKyLuat("ID_sv")
                If drKyLuat("ID_ky_luat").ToString() <> "" Then result.ID_ky_luat = CType(drKyLuat("ID_ky_luat").ToString(), Integer)
                result.So_qd = drKyLuat("So_qd").ToString()
                If drKyLuat("Ngay_qd").ToString() <> "" Then result.Ngay_qd = CType(drKyLuat("Ngay_qd").ToString(), Date)
                If drKyLuat("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drKyLuat("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drKyLuat("Nam_hoc").ToString()
                If drKyLuat("ID_hanh_vi").ToString() <> "" Then result.ID_hanh_vi = CType(drKyLuat("ID_hanh_vi").ToString(), Integer)
                result.Hanh_vi = drKyLuat("Hanh_vi").ToString()
                If drKyLuat("ID_xu_ly").ToString() <> "" Then result.ID_xu_ly = CType(drKyLuat("ID_xu_ly").ToString(), Integer)
                result.Xu_ly = drKyLuat("Xu_ly").ToString()
                If drKyLuat("ID_cap").ToString() <> "" Then result.ID_cap = CType(drKyLuat("ID_cap").ToString(), Integer)
                result.Ten_cap = drKyLuat("Ten_cap").ToString()
                result.Noi_dung = drKyLuat("Noi_dung").ToString()
                result.Xoa_ky_luat = drKyLuat("Xoa_ky_luat").ToString()
                result.Ngay_xoa = drKyLuat("Ngay_xoa").ToString()
                result.Lydo_xoa = drKyLuat("Lydo_xoa").ToString()
                result.ID_lop = drKyLuat("ID_lop").ToString()
                If drKyLuat("Muc_xu_ly").ToString() <> "" Then result.Muc_xu_ly = CType(drKyLuat("Muc_xu_ly"), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Public Sub AddKyLuat(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Ky_luat", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Ky_luat") = KyLuat_ky(dtDSSV.Rows(i)("ID_sv"), Hoc_ky, Nam_hoc)
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Function KyLuat_ky(ByVal id_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As String
            For i As Integer = 0 To arrKyLuat.Count - 1
                Dim obj As ESSKyLuat = CType(arrKyLuat(i), ESSKyLuat)
                If obj.ID_sv = id_sv And obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                    Return obj.Hanh_vi
                End If
            Next
            Return ""
        End Function

#End Region

#Region "Ngừng học, thôi học"
        Public Function DanhSachThoiHocNgungHoc(ByVal ID_lops As String) As DataTable
            Try
                Dim obj As KyLuat_DataAccess = New KyLuat_DataAccess
                Return obj.DanhSachSinhVienXoa_Load(ID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
