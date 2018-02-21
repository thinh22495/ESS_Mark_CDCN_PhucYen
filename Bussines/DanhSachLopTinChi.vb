'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------


Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Imports ESS.Bussines
Namespace Bussines
    Public Class DanhSachLopTinChi_Bussines
        Private arrDanhSach As ArrayList
        Private objSorted As New LapMa_Bussines
#Region "Initialize"
        Public Sub New()

        End Sub
        Public Sub New(ByVal mID_mon_tc As Integer, ByVal mID_lop_tc As Integer, Optional ByVal isHuyRut As Boolean = False)
            Try
                Dim clsLopTC As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Dim dt As DataTable
                If isHuyRut Then
                    dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_HuyRut_HienThi_DanhSach(mID_mon_tc, mID_lop_tc)
                Else
                    dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach(mID_mon_tc, mID_lop_tc)
                End If
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal mID_mon_tc As Integer, ByVal mID_lop_tc As Integer, ByVal UserName As String, ByVal ID_phong As Integer, Optional ByVal DaDuyet As Boolean = True)
            Try
                Dim clsLopTC As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Dim dt As DataTable
                If UserName.ToUpper = "DAOTAO" Or UserName.ToUpper = "ADMIN" Or ID_phong = 1 Then ' Cac don vi ko phai la giang vien
                    If DaDuyet Then
                        dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach(mID_mon_tc, mID_lop_tc)
                    Else
                        dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach_All(mID_mon_tc, mID_lop_tc)
                    End If
                Else
                    If DaDuyet Then
                        dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach(mID_mon_tc, mID_lop_tc, UserName)
                    Else
                        dt = clsLopTC.HienThi_ESSDanhSachSinhVienLopTinChi_DanhSach_All(mID_mon_tc, mID_lop_tc, UserName)
                    End If
                End If
                Dim objDanhSachSinhVien As ESSDanhSachSinhVien = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSach = New ArrayList
                For Each dr In dt.Rows
                    objDanhSachSinhVien = Mapping(dr)
                    arrDanhSach.Add(objDanhSachSinhVien)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        Public Function Danh_sach_sinh_vien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("ID_dt", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("Noi_sinh", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("ID_dt") = ds.ID_dt1
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = ds.Ngay_sinh
                    row("Gioi_tinh") = ds.Gioi_tinh
                    row("Noi_sinh") = ds.Noi_sinh
                    row("ID_lop") = ds.ID_lop
                    row("Ten_lop") = ds.Ten_lop
                    row("Ten_khoa") = ds.Ten_khoa
                    dt.Rows.Add(row)
                Next
                Return objSorted.TableSortHo_ten(dt, False).Table
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi(ByVal objDanhSachLopTinChi As ESSDanhSachLopTinChi) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.ThemMoi_ESSDanhSachLopTinChi(objDanhSachLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi_Nganh2(ByVal objDanhSachLopTinChi As ESSDanhSachLopTinChi) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.ThemMoi_ESSDanhSachLopTinChi_Nganh2(objDanhSachLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachLopTinChi_Import(ByVal objDanhSachLopTinChi As ESSDanhSachLopTinChi) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.ThemMoi_ESSDanhSachLopTinChi_Import(objDanhSachLopTinChi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSDanhSachLopTinChi(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer, ByVal Duyet As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSDanhSachLopTinChi(ID_sv, Ky_dang_ky, Duyet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChi_SinhVien(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Rut_huy As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChi_SinhVien(ID_sv, ID_lop_tc, Rut_huy)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function CapNhat_ESSLopTinChi_Chuyen(ByVal ID_sv As Integer, ByVal ID_lop_tc_tu As Integer, ByVal ID_lop_tc_den As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChi_Chuyen(ID_sv, ID_lop_tc_tu, ID_lop_tc_den)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachLopTinChi(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.Xoa_ESSDanhSachLopTinChi(ID_sv, dsKy_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachLopTinChi_Nganh1(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.Xoa_ESSDanhSachLopTinChi_Nganh1(ID_sv, dsKy_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachLopTinChi_Nganh2(ByVal ID_sv As Integer, ByVal dsKy_dang_ky As String) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.Xoa_ESSDanhSachLopTinChi_Nganh2(ID_sv, dsKy_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachLopTinChi_Mon(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.Xoa_ESSDanhSachLopTinChi_Mon(ID_sv, ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function




        Public Function CapNhat_ESSDuyetDK(ByVal ID_sv As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSDuyetDK(ID_sv, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDuyetDK_ChoNhieu(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Id_khoa As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSDuyetDK_ChoNhieu(ID_he, Khoa_hoc, Id_khoa, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_ESSHuyDuyetDK_ChoNhieu(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Id_khoa As Integer, ByVal Ky_dang_ky As Integer) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSHuyDuyetDK_ChoNhieu(ID_he, Khoa_hoc, Id_khoa, Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private Function Mapping(ByVal drDanhSachSinhVien As DataRow) As ESSDanhSachSinhVien
            Dim result As ESSDanhSachSinhVien
            Try
                result = New ESSDanhSachSinhVien
                If drDanhSachSinhVien("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachSinhVien("ID_sv").ToString(), Integer)
                If drDanhSachSinhVien("ID_dt").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachSinhVien("ID_dt").ToString(), Integer)
                If drDanhSachSinhVien("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhSachSinhVien("ID_lop").ToString(), Integer)
                If drDanhSachSinhVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drDanhSachSinhVien("ID_gioi_tinh").ToString(), Integer)
                result.Mat_khau = drDanhSachSinhVien("Mat_khau").ToString()
                result.Active = drDanhSachSinhVien("Active").ToString()
                result.Da_tot_nghiep = drDanhSachSinhVien("Da_tot_nghiep").ToString()
                result.Ten_lop = drDanhSachSinhVien("Ten_lop").ToString()
                result.Ten_khoa = drDanhSachSinhVien("Ten_khoa").ToString()
                result.Ma_sv = drDanhSachSinhVien("Ma_sv").ToString()
                result.Ho_ten = drDanhSachSinhVien("Ho_ten").ToString()
                result.Ngoai_ngu = drDanhSachSinhVien("Ngoai_ngu").ToString()
                If drDanhSachSinhVien("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachSinhVien("Ngay_sinh").ToString(), Date)
                result.Gioi_tinh = drDanhSachSinhVien("Gioi_tinh").ToString()
                result.Noi_sinh = drDanhSachSinhVien("Noi_sinh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function ThongTnLopTInChi_Select(ByVal ID_lop_tc As Integer) As DataTable
            Dim clsLopTC As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
            Dim dt As DataTable = clsLopTC.ThongTnLopTInChi_Select(ID_lop_tc)
            Return dt
        End Function
        Function DanhSachSinhVien_ToChucThi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                For i As Integer = 0 To arrDanhSach.Count - 1
                    Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                    Dim row As DataRow = dt.NewRow()
                    row("Chon") = False
                    row("ID_sv") = ds.ID_sv
                    row("Ma_sv") = ds.Ma_sv
                    row("Ho_ten") = ds.Ho_ten
                    row("Ngay_sinh") = ds.Ngay_sinh
                    row("Ten_lop") = ds.Ten_lop
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function DanhSachSinhVien_ToChucThi(ByVal dv As DataView, ByVal Ngoai_ngu As String, ByVal Ma_sv As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngoai_ngu", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                If Ngoai_ngu.ToUpper = "TIẾNG ANH" Then Ngoai_ngu = "A"
                If Ngoai_ngu.ToUpper = "TIẾNG NGA" Then Ngoai_ngu = "N"
                If Ngoai_ngu.ToUpper = "TIẾNG PHÁP" Then Ngoai_ngu = "P"
                If Not dv Is Nothing Then
                    dv.Sort = "ID_SV"
                    For i As Integer = 0 To arrDanhSach.Count - 1
                        Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                        If dv.Find(ds.ID_sv) < 0 Then
                            If Ngoai_ngu.Trim <> "" And Ma_sv.Trim <> "" Then
                                If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Ten_lop") = ds.Ten_lop
                                    dt.Rows.Add(row)
                                End If
                            ElseIf Ngoai_ngu.Trim <> "" And Ma_sv.Trim = "" Then
                                If ds.Ngoai_ngu = Ngoai_ngu Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Ten_lop") = ds.Ten_lop
                                    dt.Rows.Add(row)
                                End If
                            ElseIf Ngoai_ngu.Trim = "" And Ma_sv.Trim <> "" Then
                                If ds.Ma_sv = Ma_sv Then
                                    Dim row As DataRow = dt.NewRow()
                                    row("Chon") = False
                                    row("ID_sv") = ds.ID_sv
                                    row("Ma_sv") = ds.Ma_sv
                                    row("Ngoai_ngu") = ds.Ngoai_ngu
                                    row("Ho_ten") = ds.Ho_ten
                                    row("Ngay_sinh") = ds.Ngay_sinh
                                    row("Ten_lop") = ds.Ten_lop
                                    dt.Rows.Add(row)
                                End If
                            Else
                                Dim row As DataRow = dt.NewRow()
                                row("Chon") = False
                                row("ID_sv") = ds.ID_sv
                                row("Ma_sv") = ds.Ma_sv
                                row("Ngoai_ngu") = ds.Ngoai_ngu
                                row("Ho_ten") = ds.Ho_ten
                                row("Ngay_sinh") = ds.Ngay_sinh
                                row("Ten_lop") = ds.Ten_lop
                                dt.Rows.Add(row)
                            End If
                        End If
                    Next
                Else
                    For i As Integer = 0 To arrDanhSach.Count - 1
                        Dim ds As ESSDanhSachSinhVien = CType(arrDanhSach(i), ESSDanhSachSinhVien)
                        If Ngoai_ngu.Trim <> "" And Ma_sv.Trim <> "" Then
                            If ds.Ngoai_ngu = Ngoai_ngu And ds.Ma_sv = Ma_sv Then
                                Dim row As DataRow = dt.NewRow()
                                row("Chon") = False
                                row("ID_sv") = ds.ID_sv
                                row("Ma_sv") = ds.Ma_sv
                                row("Ngoai_ngu") = ds.Ngoai_ngu
                                row("Ho_ten") = ds.Ho_ten
                                row("Ngay_sinh") = ds.Ngay_sinh
                                row("Ten_lop") = ds.Ten_lop
                                dt.Rows.Add(row)
                            End If
                        ElseIf Ngoai_ngu.Trim <> "" And Ma_sv.Trim = "" Then
                            If ds.Ngoai_ngu = Ngoai_ngu Then
                                Dim row As DataRow = dt.NewRow()
                                row("Chon") = False
                                row("ID_sv") = ds.ID_sv
                                row("Ma_sv") = ds.Ma_sv
                                row("Ngoai_ngu") = ds.Ngoai_ngu
                                row("Ho_ten") = ds.Ho_ten
                                row("Ngay_sinh") = ds.Ngay_sinh
                                row("Ten_lop") = ds.Ten_lop
                                dt.Rows.Add(row)
                            End If
                        ElseIf Ngoai_ngu.Trim = "" And Ma_sv.Trim <> "" Then
                            If ds.Ma_sv = Ma_sv Then
                                Dim row As DataRow = dt.NewRow()
                                row("Chon") = False
                                row("ID_sv") = ds.ID_sv
                                row("Ma_sv") = ds.Ma_sv
                                row("Ngoai_ngu") = ds.Ngoai_ngu
                                row("Ho_ten") = ds.Ho_ten
                                row("Ngay_sinh") = ds.Ngay_sinh
                                row("Ten_lop") = ds.Ten_lop
                                dt.Rows.Add(row)
                            End If
                        Else
                            Dim row As DataRow = dt.NewRow()
                            row("Chon") = False
                            row("ID_sv") = ds.ID_sv
                            row("Ma_sv") = ds.Ma_sv
                            row("Ngoai_ngu") = ds.Ngoai_ngu
                            row("Ho_ten") = ds.Ho_ten
                            row("Ngay_sinh") = ds.Ngay_sinh
                            row("Ten_lop") = ds.Ten_lop
                            dt.Rows.Add(row)
                        End If
                    Next
                End If
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region

        Public Function CapNhat_RutBotHocPhan(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Rut_bot_hoc_phan As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChi_SinhVien(ID_sv, ID_lop_tc, Rut_bot_hoc_phan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSLopTinChi_SinhVien_Duyet(ByVal ID_sv As Integer, ByVal ID_lop_tc As Integer, ByVal Duyet As Boolean) As Integer
            Try
                Dim obj As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
                Return obj.CapNhat_ESSLopTinChi_SinhVien_Duyet(ID_sv, ID_lop_tc, Duyet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function DanhSachThiLai_ToChucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lop_tc As Integer) As DataTable
            Dim clsLopTC As DanhSachSinhVienLopTinChi_DataAccess = New DanhSachSinhVienLopTinChi_DataAccess
            Dim dt As New DataTable
            'dt.Columns.Add("Chon", GetType(Boolean))
            dt = clsLopTC.DanhSachThiLai_ToChucThi(Hoc_ky, Nam_hoc, ID_lop_tc)
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function
    End Class
End Namespace