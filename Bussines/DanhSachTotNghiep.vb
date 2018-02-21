'Tungnk

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachTotNghiep_Bussines
        Private mID_dv As String = ""
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachTotNghiep As New ArrayList
        Private arrDanhSachChuaTotNghiep As New ArrayList
        Private mID_dt As Integer = 0
#Region "Initialize"
        Sub New()
        End Sub
        Sub New(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal DanhSachSinhVien As DataTable, ByVal TotNghiep As Byte, ByVal ID_dt As Integer, ByVal Nganh2 As Boolean)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_dt = ID_dt

                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Dim objDanhsachTotNghiep As ESSDanhSachTotNghiep = Nothing
                Dim dr As DataRow = Nothing

                If TotNghiep = 1 Then 'Load danh sach da tot nghiep
                    Dim dt_TotNghiep As DataTable
                    If Nganh2 Then
                        dt_TotNghiep = obj.HienThi_ESSDanhSachTotNghiep_Nganh2_DanhSach(mID_dt)
                    Else
                        dt_TotNghiep = obj.HienThi_ESSDanhSachTotNghiep_DanhSach(dsID_lop)
                    End If
                    arrDanhSachTotNghiep = New ArrayList
                    For Each dr In dt_TotNghiep.Rows
                        objDanhsachTotNghiep = MappingTotNghiep(dr)
                        arrDanhSachTotNghiep.Add(objDanhsachTotNghiep)
                    Next
                Else 'Load chua tot nghiep
                    Dim dt_ChuaTotNghiep As DataTable
                    If Nganh2 Then
                        dt_ChuaTotNghiep = obj.HienThi_ESSDanhSachChuaTotNghiep_Nganh2_DanhSach(mID_dt)
                    Else
                        dt_ChuaTotNghiep = obj.HienThi_ESSDanhSachChuaTotNghiep_DanhSach(dsID_lop)
                    End If
                    arrDanhSachChuaTotNghiep = New ArrayList
                    For Each dr In dt_ChuaTotNghiep.Rows
                        objDanhsachTotNghiep = MappingChuaTotNghiep(dr)
                        arrDanhSachChuaTotNghiep.Add(objDanhsachTotNghiep)
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        Public Sub Add_TotNghiep(ByVal DSTN As ESSDanhSachTotNghiep)
            arrDanhSachTotNghiep.Add(DSTN)
        End Sub
        Public Sub Remove_TotNghiep(ByVal idx As Integer)
            arrDanhSachTotNghiep.RemoveAt(idx)
        End Sub
        Public Sub Add_ChuaTotNghiep(ByVal DSCTN As ESSDanhSachTotNghiep)
            arrDanhSachChuaTotNghiep.Add(DSCTN)
        End Sub
        Public Sub Remove_ChuaTotNghiep(ByVal idx As Integer)
            arrDanhSachChuaTotNghiep.RemoveAt(idx)
        End Sub
        Public Function Tim_idx_TotNghiep(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
                If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function Tim_idx_ChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrDanhSachChuaTotNghiep.Count - 1
                If CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Function dtDanhSachTotNghiep(ByVal Lan_thu As Integer, ByVal Nam_hoc As String) As DataTable
            'Dim dtDSTotNghiep As New DataTable
            'dtDSTotNghiep.Columns.Add("Lock", GetType(Boolean))
            'dtDSTotNghiep.Columns.Add("Chon", GetType(Boolean))
            'dtDSTotNghiep.Columns.Add("ID_sv", GetType(Integer))
            'dtDSTotNghiep.Columns.Add("Lan_thu", GetType(Integer))
            'dtDSTotNghiep.Columns.Add("So_bang", GetType(Integer))
            'dtDSTotNghiep.Columns.Add("TBCHT", GetType(Double))
            'dtDSTotNghiep.Columns.Add("TBCHT10", GetType(Double))
            'dtDSTotNghiep.Columns.Add("PhanTram_ThiLai", GetType(Double))
            'dtDSTotNghiep.Columns.Add("ID_xep_loai", GetType(Integer))
            'dtDSTotNghiep.Columns.Add("Ma_sv", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ho_ten", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ho_ten_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ngay_sinh", GetType(Date))
            'dtDSTotNghiep.Columns.Add("Ngay_sinh_chuan", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ngay_sinh_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_lop", GetType(String))
            'dtDSTotNghiep.Columns.Add("Xep_hang", GetType(String))
            'dtDSTotNghiep.Columns.Add("Xep_hang_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("Nam_hoc", GetType(String))
            'dtDSTotNghiep.Columns.Add("Chuyen_nganh", GetType(String))
            'dtDSTotNghiep.Columns.Add("Chuyen_nganh_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_nganh", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_nganh_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_khoa", GetType(String))
            'dtDSTotNghiep.Columns.Add("Khoa_hoc", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_he", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ten_he_En", GetType(String))
            'dtDSTotNghiep.Columns.Add("ID_he", GetType(Integer))
            'dtDSTotNghiep.Columns.Add("Ten_tinh", GetType(String))
            'dtDSTotNghiep.Columns.Add("Nien_khoa", GetType(String))
            'dtDSTotNghiep.Columns.Add("So_QD", GetType(String))
            'dtDSTotNghiep.Columns.Add("Ngay_QD", GetType(String))
            'dtDSTotNghiep.Columns.Add("Gioi_tinh", GetType(String))
            'dtDSTotNghiep.Columns.Add("So_hieu", GetType(String))
            'dtDSTotNghiep.Columns.Add("So_vao_so", GetType(String))
            'For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
            '    If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc = Nam_hoc Then
            '        Dim row As DataRow = dtDSTotNghiep.NewRow()
            '        row("Lock") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Lock
            '        row("Chon") = False
            '        row("ID_sv") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).ID_sv
            '        row("Lan_thu") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Lan_thu
            '        row("So_bang") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_bang
            '        row("TBCHT") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).TBCHT
            '        row("TBCHT10") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).TBCHT10
            '        row("PhanTram_ThiLai") = Math.Round(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).PhanTram_ThiLai, 3)
            '        row("ID_xep_loai") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).ID_xep_loai
            '        row("Ma_sv") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ma_sv
            '        row("Ho_ten") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper
            '        If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Gioi_tinh = "Nam" Then
            '            row("Ho_ten_En") = "Mr " & ChuyenSangKhongDau(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper)
            '        Else
            '            row("Ho_ten_En") = "Ms " & ChuyenSangKhongDau(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper)
            '        End If
            '        If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month > 2 Then
            '            If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day < 10 Then
            '                row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
            '            Else
            '                row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
            '            End If
            '        Else
            '            If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day < 10 Then
            '                row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
            '            Else
            '                row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
            '            End If
            '        End If
            '        row("Ngay_sinh") = Format(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh, "dd-MM-yyyy")
            '        row("Ngay_sinh_En") = Format(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh, "dd MMMM yyyy")
            '        row("Ten_lop") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_lop
            '        row("Xep_hang") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Xep_hang
            '        row("Xep_hang_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Xep_hang_En
            '        row("Nam_hoc") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc
            '        row("So_hieu") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_hieu
            '        row("So_vao_so") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_vao_so

            '        row("Chuyen_nganh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Chuyen_nganh
            '        row("Chuyen_nganh_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Chuyen_nganh_En
            '        row("Ten_nganh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_nganh
            '        row("Ten_nganh_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_nganh_En
            '        row("Ten_khoa") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_khoa
            '        row("Khoa_hoc") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Khoa_hoc
            '        row("Ten_he") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_he
            '        row("Ten_he_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_he_En
            '        row("Ten_tinh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_tinh
            '        row("Nien_khoa") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nien_khoa
            '        row("So_QD") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_QD
            '        row("Ngay_QD") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_QD
            '        row("Gioi_tinh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Gioi_tinh

            '        dtDSTotNghiep.Rows.Add(row)
            '    End If
            'Next
            'If Lan_thu > 0 Then dtDSTotNghiep.DefaultView.RowFilter = "Lan_thu=" & Lan_thu
            'dtDSTotNghiep.AcceptChanges()
            'Return dtDSTotNghiep

            Dim dtDSTotNghiep As New DataTable
            dtDSTotNghiep.Columns.Add("Lock", GetType(Boolean))
            dtDSTotNghiep.Columns.Add("Chon", GetType(Boolean))
            dtDSTotNghiep.Columns.Add("ID_sv", GetType(Integer))
            dtDSTotNghiep.Columns.Add("Lan_thu", GetType(Integer))
            dtDSTotNghiep.Columns.Add("So_bang", GetType(Integer))
            dtDSTotNghiep.Columns.Add("TBCHT", GetType(Double))
            dtDSTotNghiep.Columns.Add("TBCHT10", GetType(Double))
            dtDSTotNghiep.Columns.Add("PhanTram_ThiLai", GetType(Double))
            dtDSTotNghiep.Columns.Add("ID_xep_loai", GetType(Integer))
            dtDSTotNghiep.Columns.Add("Ma_sv", GetType(String))
            dtDSTotNghiep.Columns.Add("Ho_ten", GetType(String))
            dtDSTotNghiep.Columns.Add("Ho_ten_En", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_sinh", GetType(Date))
            dtDSTotNghiep.Columns.Add("Ngay_sinh_chuan", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_sinh_En", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_lop", GetType(String))
            dtDSTotNghiep.Columns.Add("Xep_hang", GetType(String))
            dtDSTotNghiep.Columns.Add("Xep_hang_En", GetType(String))
            dtDSTotNghiep.Columns.Add("Nam_hoc", GetType(String))
            dtDSTotNghiep.Columns.Add("Chuyen_nganh", GetType(String))
            dtDSTotNghiep.Columns.Add("Chuyen_nganh_En", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_nganh", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_nganh_En", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_khoa", GetType(String))
            dtDSTotNghiep.Columns.Add("Khoa_hoc", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_he", GetType(String))
            dtDSTotNghiep.Columns.Add("Ten_he_En", GetType(String))
            dtDSTotNghiep.Columns.Add("ID_he", GetType(Integer))
            dtDSTotNghiep.Columns.Add("Ten_tinh", GetType(String))
            dtDSTotNghiep.Columns.Add("Nien_khoa", GetType(String))
            dtDSTotNghiep.Columns.Add("So_QD", GetType(String))
            dtDSTotNghiep.Columns.Add("Ngay_QD", GetType(String))
            dtDSTotNghiep.Columns.Add("Gioi_tinh", GetType(String))
            dtDSTotNghiep.Columns.Add("So_hieu", GetType(String))
            dtDSTotNghiep.Columns.Add("So_vao_so", GetType(String))
            For i As Integer = 0 To arrDanhSachTotNghiep.Count - 1
                If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc = Nam_hoc Then
                    Dim row As DataRow = dtDSTotNghiep.NewRow()
                    row("Lock") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Lock
                    row("Chon") = False
                    row("ID_sv") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).ID_sv
                    row("Lan_thu") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Lan_thu
                    row("So_bang") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_bang
                    row("TBCHT") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).TBCHT
                    row("TBCHT10") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).TBCHT10
                    row("PhanTram_ThiLai") = Math.Round(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).PhanTram_ThiLai, 3)
                    row("ID_xep_loai") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).ID_xep_loai
                    row("Ma_sv") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ma_sv
                    row("Ho_ten") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper
                    If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Gioi_tinh = "Nam" Then
                        row("Ho_ten_En") = "Mr " & ChuyenSangKhongDau(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper)
                    Else
                        row("Ho_ten_En") = "Ms " & ChuyenSangKhongDau(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten.ToUpper)
                    End If
                    If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month > 2 Then
                        If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day < 10 Then
                            row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
                        Else
                            row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
                        End If
                    Else
                        If CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day < 10 Then
                            row("Ngay_sinh_chuan") = "0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
                        Else
                            row("Ngay_sinh_chuan") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Day & "-0" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Month & "-" & CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh.Year
                        End If
                    End If
                    row("Ngay_sinh") = Format(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh, "dd-MM-yyyy")
                    row("Ngay_sinh_En") = Format(CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh, "dd MMMM yyyy")
                    row("Ten_lop") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_lop
                    row("Xep_hang") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Xep_hang
                    row("Xep_hang_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Xep_hang_En
                    row("Nam_hoc") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc
                    row("So_hieu") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_hieu
                    row("So_vao_so") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_vao_so

                    row("Chuyen_nganh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Chuyen_nganh
                    row("Chuyen_nganh_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Chuyen_nganh_En
                    row("Ten_nganh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_nganh
                    row("Ten_nganh_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_nganh_En
                    row("Ten_khoa") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_khoa
                    row("Khoa_hoc") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Khoa_hoc
                    row("Ten_he") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_he
                    row("Ten_he_En") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_he_En
                    row("Ten_tinh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ten_tinh
                    row("Nien_khoa") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Nien_khoa
                    row("So_QD") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).So_QD
                    row("Ngay_QD") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Ngay_QD
                    row("Gioi_tinh") = CType(arrDanhSachTotNghiep(i), ESSDanhSachTotNghiep).Gioi_tinh

                    dtDSTotNghiep.Rows.Add(row)
                End If
            Next
            If Lan_thu > 0 Then dtDSTotNghiep.DefaultView.RowFilter = "Lan_thu=" & Lan_thu
            dtDSTotNghiep.AcceptChanges()
            Return dtDSTotNghiep
        End Function
        Private Function ChuyenSangKhongDau(ByVal mystr As String) As String
            Dim myChar() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ", "ÒÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ", "EÈÉẺẼẸÊỀẾỂỄỆ", "UÙÚỦŨỤƯỪỨỬỮỰ", "IÌÍỈĨỊ", "YỲÝỶỸỴ", "Đ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
            Dim myChar1() As String = {"a", "A", "O", "E", "U", "I", "Y", "D", "o", "e", "u", "i", "y", "d"}
            Dim str As String = mystr
            Dim strReturn As String = ""
            For i As Int32 = 0 To str.Length - 1
                Dim iStr As String = str.Substring(i, 1)
                Dim rStr As String = iStr

                For j As Int32 = 0 To myChar.Length - 1
                    If myChar(j).IndexOf(iStr) >= 0 Then
                        rStr = myChar1(j)
                        Exit For
                    End If
                Next
                strReturn += rStr
            Next
            Return strReturn
        End Function
        Function dtDanhSachChuaTotNghiep(ByVal Nam_hoc As String) As DataTable
            Dim dtDSChuaTotNghiep As New DataTable
            dtDSChuaTotNghiep.Columns.Add("ID_sv", GetType(Integer))
            dtDSChuaTotNghiep.Columns.Add("TBCHT1", GetType(Double))
            dtDSChuaTotNghiep.Columns.Add("ID_xep_loai1", GetType(Integer))
            dtDSChuaTotNghiep.Columns.Add("Ma_sv1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ho_ten1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ngay_sinh1", GetType(Date))
            dtDSChuaTotNghiep.Columns.Add("Ten_lop1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Xep_hang1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Nam_hoc1", GetType(String))
            dtDSChuaTotNghiep.Columns.Add("Ly_do", GetType(String))
            For i As Integer = 0 To arrDanhSachChuaTotNghiep.Count - 1
                If CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc = Nam_hoc Then
                    Dim row As DataRow = dtDSChuaTotNghiep.NewRow()
                    row("ID_sv") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).ID_sv
                    row("TBCHT1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).TBCHT
                    row("ID_xep_loai1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).ID_xep_loai
                    row("Ma_sv1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Ma_sv
                    row("Ho_ten1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Ho_ten
                    row("Ngay_sinh1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Ngay_sinh
                    row("Ten_lop1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Ten_lop
                    row("Xep_hang1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Xep_hang
                    row("Nam_hoc1") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Nam_hoc
                    row("Ly_do") = CType(arrDanhSachChuaTotNghiep(i), ESSDanhSachTotNghiep).Ly_do
                    dtDSChuaTotNghiep.Rows.Add(row)
                End If
            Next
            dtDSChuaTotNghiep.AcceptChanges()
            Return dtDSChuaTotNghiep
        End Function

        Public Sub XetTotNghiep(ByVal Nam_hoc As String, ByVal Lan_thu As Integer, ByVal ID_Bomon As Integer)
            Dim No_HT As String
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            Dim dtDiem As DataTable = clsDiem.TongHopDiemTinChiTichLuy_XetTotNghiep()
            Dim dt_check_dk_TN As DataTable = clsDiem.Check_SinhVien_DangKy_TotNghiep(mdsID_lop)
            dt_check_dk_TN.DefaultView.Sort = "ID_SV"

            'Neu tot nghiep thi xoa sv neu o bang chua tot nghiep; kiem tra xem neu ton tai -> Update chua thi Insert
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                If dtDiem.Rows(i)("ID_SV") = 157210 Then
                    dtDiem.Rows(i)("ID_SV") = 157210
                End If
                No_HT = ""
                dt_check_dk_TN.DefaultView.RowFilter = "ID_SV=" & dtDiem.Rows(i)("ID_sv")
                If dt_check_dk_TN.DefaultView.Count = 0 Then
                    If No_HT = "" Then
                        No_HT = "Sinh viên đăng ký chưa xét Tốt nghiệp"
                    Else
                        No_HT &= "Sinh viên đăng ký chưa xét Tốt nghiệp"
                    End If
                End If
                'No_CC = ""

                'Môn học có điểm F
                If dtDiem.Rows(i).Item("LyDo_no_mon").ToString <> "" Then No_HT = "Nợ học phần: " & dtDiem.Rows(i).Item("LyDo_no_mon")
                'Chưa học môn bắt buộc
                If dtDiem.Rows(i).Item("LyDo_mon_batbuoc").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = "Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                    Else
                        No_HT &= "-Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                    End If
                End If
                'Điểm tích luỹ không đạt < 2
                If dtDiem.Rows(i).Item("LyDo_TBCHT_TL").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                    Else
                        No_HT &= "-" & dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                    End If
                End If
                'Chưa đủ số tín chỉ tích luỹ so với CTĐT
                If dtDiem.Rows(i).Item("So_tinchi_tichluy").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = dtDiem.Rows(i).Item("So_tinchi_tichluy")
                    Else
                        No_HT &= "-" & dtDiem.Rows(i).Item("So_tinchi_tichluy")
                    End If
                End If

                'Check nợ môn chứng chỉ
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Dim dt_NoChungChi As DataTable = obj.HienThi_ESSDanhSachChungChiSinhVienNo(dtDiem.Rows(i).Item("ID_dt"), dtDiem.Rows(i).Item("ID_sv"))
                Dim NoCC As String = ""
                For c As Integer = 0 To dt_NoChungChi.Rows.Count - 1
                    If NoCC.Trim = "" Then
                        NoCC = "Nợ chứng chỉ: " & dt_NoChungChi.Rows(c).Item("Loai_chung_chi").ToString
                    Else
                        NoCC += "; " & dt_NoChungChi.Rows(c).Item("Loai_chung_chi").ToString
                    End If
                Next
                If NoCC.Trim <> "" Then
                    If No_HT.Trim = "" Then
                        No_HT = NoCC
                    Else
                        No_HT += "; " & NoCC
                    End If
                End If

                'Check nợ khác
                Dim dt_NoKhac As DataTable = obj.HienThi_ESSDanhSachNoKhac(dtDiem.Rows(i).Item("ID_sv"))
                Dim NoKhac As String = ""
                If dt_NoKhac.Rows.Count > 0 Then NoKhac = "Nợ khác: " & dt_NoKhac.Rows(0).Item("Ly_do").ToString
                If NoKhac.Trim <> "" Then
                    If No_HT.Trim = "" Then
                        No_HT = NoKhac
                    Else
                        No_HT += "; " & NoKhac
                    End If
                End If


                'Xoá sinh viên khỏi danh sách Tốt nghiệp và Bổ sung vào danh sách Nợ tốt nghiệp rơi vào 3 đk trên
                If No_HT.Trim <> "" Then
                    Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))

                    If idx >= 0 Then
                        Xoa_ESSDanhSachTotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                        Remove_TotNghiep(idx)
                    End If

                    Dim objChuaTN As New ESSDanhSachTotNghiep
                    objChuaTN.Nam_hoc = Nam_hoc
                    objChuaTN.Lan_thu = Lan_thu
                    objChuaTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                    objChuaTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                    objChuaTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                    objChuaTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                    objChuaTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                    objChuaTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                    objChuaTN.Ly_do = No_HT

                    Xoa_ESSDanhSachChuaTotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                    ThemMoi_ESSDanhSachChuaTotNghiep(objChuaTN)
                Else 'Tốt nghiệp
                    Xoa_ESSDanhSachChuaTotNghiep(dtDiem.Rows(i).Item("ID_SV"))

                    Dim objTN As New ESSDanhSachTotNghiep
                    objTN.Nam_hoc = Nam_hoc
                    objTN.Lan_thu = Lan_thu
                    objTN.ID_dt = mID_dt
                    objTN.So_bang = objTN.So_bang
                    objTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                    objTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                    objTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                    objTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                    objTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                    objTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                    objTN.TBCHT10 = IIf(dtDiem.Rows(i).Item("TBCHT10").ToString = "", 0, dtDiem.Rows(i).Item("TBCHT10"))
                    objTN.PhanTram_ThiLai = IIf(dtDiem.Rows(i).Item("PhanTram_ThiLai").ToString = "", 0, dtDiem.Rows(i).Item("PhanTram_ThiLai"))
                    objTN.Ly_do = dtDiem.Rows(i).Item("HaBac_TotNghiep").ToString

                    Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                    If idx >= 0 Then 'Update  
                        If CType(arrDanhSachTotNghiep(idx), ESSDanhSachTotNghiep).Lan_thu = Lan_thu Then
                            CapNhat_ESSDanhSachTotNghiep(objTN, dtDiem.Rows(i).Item("ID_SV"))
                        End If
                    Else ' Insert
                        ThemMoi_ESSDanhSachTotNghiep(objTN)
                    End If
                End If

                '

                'Loai những sinh viên nợ chứng chỉ

                'Loai những sinh viên nợ tốt nghiệp như giấy tờ, học phí, ktx, thư viện....

                'Load danh sách những sinh viên bị kỷ luật trong năm học xét tốt nghiệp

                'Loại sinh viên nợ học phí

            Next
        End Sub
        Public Sub XetTotNghiep_Nganh2(ByVal Nam_hoc As String, ByVal Lan_thu As Integer, ByVal ID_Bomon As Integer, ByVal ID_dt As Integer)
            Dim No_HT As String
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(0, "", 0, ID_dt, mdtDanhSachSinhVien)
            Dim dtDiem As DataTable = clsDiem.TongHopDiemTinChiTichLuy_XetTotNghiep()

            'Neu tot nghiep thi xoa sv neu o bang chua tot nghiep; kiem tra xem neu ton tai -> Update chua thi Insert
            For i As Integer = 0 To dtDiem.Rows.Count - 1
                No_HT = ""
                'Môn học có điểm F
                If dtDiem.Rows(i).Item("LyDo_no_mon").ToString <> "" Then No_HT = "Nợ học phần: " & dtDiem.Rows(i).Item("LyDo_no_mon")
                'Chưa học môn bắt buộc
                If dtDiem.Rows(i).Item("LyDo_mon_batbuoc").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = "Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                    Else
                        No_HT &= "-Môn bắt buộc: " & dtDiem.Rows(i).Item("LyDo_mon_batbuoc")
                    End If
                End If
                'Điểm tích luỹ không đạt < 2
                If dtDiem.Rows(i).Item("LyDo_TBCHT_TL").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                    Else
                        No_HT &= "-" & dtDiem.Rows(i).Item("LyDo_TBCHT_TL")
                    End If
                End If
                'Chưa đủ số tín chỉ tích luỹ so với CTĐT
                If dtDiem.Rows(i).Item("So_tinchi_tichluy").ToString <> "" Then
                    If No_HT = "" Then
                        No_HT = dtDiem.Rows(i).Item("So_tinchi_tichluy")
                    Else
                        No_HT &= "-" & dtDiem.Rows(i).Item("So_tinchi_tichluy")
                    End If
                End If

                'Check nợ môn chứng chỉ
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                'Check nợ khác
                Dim dt_NoKhac As DataTable = obj.HienThi_ESSDanhSachNoKhac(dtDiem.Rows(i).Item("ID_sv"))
                Dim NoKhac As String = ""
                If dt_NoKhac.Rows.Count > 0 Then NoKhac = "Nợ khác: " & dt_NoKhac.Rows(0).Item("Ly_do").ToString
                If NoKhac.Trim <> "" Then
                    If No_HT.Trim = "" Then
                        No_HT = NoKhac
                    Else
                        No_HT += "; " & NoKhac
                    End If
                End If


                'Xoá sinh viên khỏi danh sách Tốt nghiệp và Bổ sung vào danh sách Nợ tốt nghiệp rơi vào 3 đk trên
                If No_HT.Trim <> "" Then
                    Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))

                    If idx >= 0 Then
                        Xoa_ESSDanhSachTotNghiep_Nganh2(dtDiem.Rows(i).Item("ID_SV"))
                        Remove_TotNghiep(idx)
                    End If

                    Dim objChuaTN As New ESSDanhSachTotNghiep
                    objChuaTN.Nam_hoc = Nam_hoc
                    objChuaTN.Lan_thu = Lan_thu
                    objChuaTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                    objChuaTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                    objChuaTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                    objChuaTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                    objChuaTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                    objChuaTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                    objChuaTN.Ly_do = No_HT

                    Xoa_ESSDanhSachChuaTotNghiep_Nganh2(dtDiem.Rows(i).Item("ID_SV"))
                    ThemMoi_ESSDanhSachChuaTotNghiep_Nganh2(objChuaTN)
                Else 'Tốt nghiệp
                    Xoa_ESSDanhSachChuaTotNghiep_Nganh2(dtDiem.Rows(i).Item("ID_SV"))

                    Dim objTN As New ESSDanhSachTotNghiep
                    objTN.Nam_hoc = Nam_hoc
                    objTN.Lan_thu = Lan_thu
                    objTN.ID_dt = mID_dt
                    objTN.So_bang = objTN.So_bang
                    objTN.Ma_sv = dtDiem.Rows(i).Item("Ma_sv")
                    objTN.Ho_ten = dtDiem.Rows(i).Item("Ho_ten")
                    objTN.ID_sv = dtDiem.Rows(i).Item("ID_sv")
                    objTN.ID_xep_loai = dtDiem.Rows(i).Item("ID_xep_loai")
                    objTN.Xep_hang = dtDiem.Rows(i).Item("Xep_loai")
                    objTN.TBCHT = dtDiem.Rows(i).Item("TBCHT")
                    objTN.TBCHT10 = IIf(dtDiem.Rows(i).Item("TBCHT10").ToString = "", 0, dtDiem.Rows(i).Item("TBCHT10"))
                    objTN.PhanTram_ThiLai = IIf(dtDiem.Rows(i).Item("PhanTram_ThiLai").ToString = "", 0, dtDiem.Rows(i).Item("PhanTram_ThiLai"))
                    objTN.Ly_do = dtDiem.Rows(i).Item("HaBac_TotNghiep").ToString

                    Dim idx As Integer = Tim_idx_TotNghiep(dtDiem.Rows(i).Item("ID_SV"))
                    If idx >= 0 Then 'Update  
                        If CType(arrDanhSachTotNghiep(idx), ESSDanhSachTotNghiep).Lan_thu = Lan_thu Then
                            CapNhat_ESSDanhSachTotNghiep_Nganh2(objTN, dtDiem.Rows(i).Item("ID_SV"))
                        End If
                    Else ' Insert
                        ThemMoi_ESSDanhSachTotNghiep_Nganh2(objTN)
                    End If
                End If

                '

                'Loai những sinh viên nợ chứng chỉ

                'Loai những sinh viên nợ tốt nghiệp như giấy tờ, học phí, ktx, thư viện....

                'Load danh sách những sinh viên bị kỷ luật trong năm học xét tốt nghiệp

                'Loại sinh viên nợ học phí

            Next
        End Sub
        Public Sub CapNhat_ESSSoVB1(ByVal dv As DataView, ByVal Tu_so As Integer)
            For i As Integer = 0 To dv.Count - 1
                Dim objTN As New ESSDanhSachTotNghiep
                objTN.ID_sv = dv.Table.Rows(i).Item("ID_sv")
                objTN.Lan_thu = dv.Table.Rows(i).Item("Lan_thu")
                objTN.So_bang = i + Tu_so
                objTN.TBCHT = dv.Table.Rows(i).Item("TBCHT")
                objTN.ID_xep_loai = dv.Table.Rows(i).Item("ID_xep_loai")
                objTN.Nam_hoc = dv.Table.Rows(i).Item("Nam_hoc")
                CapNhat_ESSDanhSachTotNghiep(objTN, dv.Table.Rows(i).Item("ID_SV"))
            Next
        End Sub

        Public Function ThemMoi_ESSDanhSachTotNghiep(ByVal objDanhSachTotNghiep As ESSDanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachTotNghiep(objDanhSachTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachTotNghiep(ByVal objDanhSachTotNghiep As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_ESSDanhSachTotNghiep(objDanhSachTotNghiep, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachChuaTotNghiep(ByVal objDanhSachChuaTotNghiep As ESSDanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachChuaTotNghiep(objDanhSachChuaTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachChuaTotNghiep(ByVal objDanhSachChuaTotNghiep As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_ESSDanhSachChuaTotNghiep(objDanhSachChuaTotNghiep, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachChuaTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachChuaTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function MappingTotNghiep(ByVal drDanhSachTotNghiep As DataRow) As ESSDanhSachTotNghiep
            Dim result As ESSDanhSachTotNghiep
            Try
                result = New ESSDanhSachTotNghiep
                result.Lock = drDanhSachTotNghiep("Lock")
                If drDanhSachTotNghiep("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachTotNghiep("ID_sv").ToString(), Integer)
                If drDanhSachTotNghiep("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachTotNghiep("TBCHT").ToString(), Double)
                If drDanhSachTotNghiep("TBCHT10").ToString() <> "" Then result.TBCHT10 = CType(drDanhSachTotNghiep("TBCHT10").ToString(), Double)
                If drDanhSachTotNghiep("PhanTram_ThiLai").ToString() <> "" Then result.PhanTram_ThiLai = CType(drDanhSachTotNghiep("PhanTram_ThiLai").ToString(), Double)
                If drDanhSachTotNghiep("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachTotNghiep("ID_xep_loai").ToString(), Integer)
                If drDanhSachTotNghiep("So_bang").ToString() <> "" Then result.So_bang = CType(drDanhSachTotNghiep("So_bang").ToString(), Integer)
                If drDanhSachTotNghiep("Lan_thu").ToString() <> "" Then result.Lan_thu = CType(drDanhSachTotNghiep("Lan_thu").ToString(), Integer)

                result.Ma_sv = drDanhSachTotNghiep("Ma_sv").ToString()
                result.So_hieu = drDanhSachTotNghiep("So_hieu").ToString()
                result.So_vao_so = drDanhSachTotNghiep("So_vao_so").ToString()
                result.Ho_ten = drDanhSachTotNghiep("Ho_ten").ToString()
                If drDanhSachTotNghiep("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachTotNghiep("Ngay_sinh"), Date)
                If drDanhSachTotNghiep("Ngay_QD").ToString() <> "" Then result.Ngay_QD = CType(drDanhSachTotNghiep("Ngay_QD"), Date)
                result.So_QD = drDanhSachTotNghiep("So_QD").ToString()
                result.Ten_lop = drDanhSachTotNghiep("Ten_lop").ToString()
                result.Xep_hang = drDanhSachTotNghiep("Xep_hang").ToString()
                result.Xep_hang_En = drDanhSachTotNghiep("Xep_hang_En").ToString()
                result.Nam_hoc = drDanhSachTotNghiep("Nam_hoc").ToString()

                result.Chuyen_nganh = drDanhSachTotNghiep("Chuyen_nganh").ToString()
                result.Ten_nganh = drDanhSachTotNghiep("Ten_nganh").ToString()
                result.Chuyen_nganh_En = drDanhSachTotNghiep("Chuyen_nganh_En").ToString()
                result.Ten_nganh_En = drDanhSachTotNghiep("Ten_nganh_En").ToString()
                result.Ten_khoa = drDanhSachTotNghiep("Ten_khoa").ToString()
                result.Khoa_hoc = drDanhSachTotNghiep("Khoa_hoc").ToString()
                result.Ten_he = drDanhSachTotNghiep("Ten_he").ToString()
                result.Ten_he_En = drDanhSachTotNghiep("Ten_he_En").ToString()
                result.Ten_tinh = drDanhSachTotNghiep("Ten_tinh").ToString()
                result.Nien_khoa = drDanhSachTotNghiep("Nien_khoa").ToString()
                If drDanhSachTotNghiep("ID_gioi_tinh") = 0 Then
                    result.Gioi_tinh = "Nam"
                Else
                    result.Gioi_tinh = "Nữ"
                End If
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function MappingChuaTotNghiep(ByVal drDanhSachChuaTotNghiep As DataRow) As ESSDanhSachTotNghiep
            Dim result As ESSDanhSachTotNghiep
            Try
                result = New ESSDanhSachTotNghiep
                If drDanhSachChuaTotNghiep("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachChuaTotNghiep("ID_sv").ToString(), Integer)
                If drDanhSachChuaTotNghiep("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachChuaTotNghiep("TBCHT").ToString(), Double)
                If drDanhSachChuaTotNghiep("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachChuaTotNghiep("ID_xep_loai").ToString(), Integer)

                result.Ma_sv = drDanhSachChuaTotNghiep("Ma_sv").ToString()
                result.Ho_ten = drDanhSachChuaTotNghiep("Ho_ten").ToString()
                If drDanhSachChuaTotNghiep("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachChuaTotNghiep("Ngay_sinh"), Date)
                result.Ten_lop = drDanhSachChuaTotNghiep("Ten_lop").ToString()
                result.Xep_hang = drDanhSachChuaTotNghiep("Xep_hang").ToString()
                result.Nam_hoc = drDanhSachChuaTotNghiep("Nam_hoc").ToString()
                result.Ly_do = drDanhSachChuaTotNghiep("Ly_do").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function Lap_van_bang1(ByVal dv As DataView, ByVal Tu_so As Integer, ByRef Den_so As Integer) As DataView
            For i As Integer = 0 To dv.Count - 1

            Next
            Return dv
        End Function

        Public Function CapNhat_QuyetDinh(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_QuyetDinh(So_QD, Ngay_QD, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoHieu(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_SoHieu(So_hieu, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_SoVaoSo(So_vao_so, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_KHoa(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_KHoa(ID_sv, Lock)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Mark_TotNghiep_ThongKe() As DataTable
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.Mark_TotNghiep_ThongKe
            Catch ex As Exception
                Throw ex
            End Try
        End Function

         
        Public Function Xoa_ESSDanhSachTotNghiep_Nganh2(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachTotNghiep_Nganh2(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachChuaTotNghiep_Nganh2(ByVal objDanhSachChuaTotNghiep As ESSDanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachChuaTotNghiep_Nganh2(objDanhSachChuaTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSDanhSachChuaTotNghiep_Nganh2(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachChuaTotNghiep_Nganh2(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSDanhSachTotNghiep_Nganh2(ByVal objDanhSachTotNghiep As ESSDanhSachTotNghiep) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachTotNghiep_Nganh2(objDanhSachTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        'Function getDenSo_VB_Nganh2(ByVal Tu_so As Integer, ByVal dv_main As DataView, ByVal Nam_hoc As String) As Integer
        '    Dim DenSo_VB As Integer = Tu_so + dv_main.Count
        '    Dim dv As DataView = dtDanhSachTotNghiep_lapVB(Nam_hoc).DefaultView
        '    dv.RowFilter = "So_bang>=" & Tu_so & " AND So_bang<=" & DenSo_VB
        '    If dv.Count > 0 Then Return -1

        '    Return DenSo_VB
        'End Function

        Public Function CapNhat_QuyetDinh_Nganh2(ByVal So_QD As String, ByVal Ngay_QD As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_QuyetDinh_Nganh2(So_QD, Ngay_QD, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoHieu_Nganh2(ByVal So_hieu As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_SoHieu_Nganh2(So_hieu, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_SoVaoSo_Nganh2(ByVal So_vao_so As String, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_SoVaoSo_Nganh2(So_vao_so, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub CapNhat_ESSSoVB_Nganh2(ByVal dv As DataView, ByVal Tu_so As Integer)
            For i As Integer = 0 To dv.Count - 1
                Dim objTN As New ESSDanhSachTotNghiep
                objTN.ID_sv = dv.Table.Rows(i).Item("ID_sv")
                objTN.Lan_thu = dv.Table.Rows(i).Item("Lan_thu")
                objTN.So_bang = i + Tu_so
                objTN.TBCHT = dv.Table.Rows(i).Item("TBCHT")
                objTN.ID_xep_loai = dv.Table.Rows(i).Item("ID_xep_loai")
                objTN.Nam_hoc = dv.Table.Rows(i).Item("Nam_hoc")
                CapNhat_ESSDanhSachTotNghiep_Nganh2(objTN, dv.Table.Rows(i).Item("ID_SV"))
            Next
        End Sub

        Private Function CapNhat_ESSDanhSachTotNghiep_Nganh2(ByVal objDanhSachTotNghiep As ESSDanhSachTotNghiep, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_ESSDanhSachTotNghiep_Nganh2(objDanhSachTotNghiep, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CapNhat_KHoa_Nganh2(ByVal ID_sv As Integer, ByVal Lock As Boolean) As Integer
            Try
                Dim obj As DanhSachTotNghiep_DataAccess = New DanhSachTotNghiep_DataAccess
                Return obj.CapNhat_KHoa_Nganh2(ID_sv, Lock)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
