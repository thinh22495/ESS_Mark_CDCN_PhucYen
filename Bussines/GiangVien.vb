'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 09, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Imports System.DirectoryServices
Namespace Bussines
    Public Class GiangVien_Bussines
        Inherits ESSGiangVien
        Private arrGiangVien As ArrayList
#Region "Initialize"
        Public Sub New(Optional ByVal ID_khoa As Integer = 0, Optional ByVal ID_bomon As Integer = 0)
            Try
                arrGiangVien = New ArrayList
                Dim objGiangVien_dal As New GiangVien_DataAccess
                Dim objBoMonGiangVien_dal As New BoMonGiangVien_DataAccess
                Dim objGiangVienMonDay_dal As New GiangVienMonDay_DataAccess
                Dim dt As DataTable = objGiangVien_dal.HienThi_ESSGiangVien_DanhSach()
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim objGiangVien As New ESSGiangVien
                        objGiangVien = MappingGiangVien(dt.Rows(i))
                        'Add danh sach bo mon
                        Dim dt1 As DataTable = objBoMonGiangVien_dal.HienThi_ESSBoMon(objGiangVien.ID_cb)
                        For j As Integer = 0 To dt1.Rows.Count - 1
                            Dim objBoMon As New ESSBoMon
                            objBoMon = MappingBoMon(dt1.Rows(j))
                            'Add danh sach mon day
                            Dim dt3 As DataTable = objGiangVienMonDay_dal.HienThi_ESSGiangVienMonDay(objGiangVien.ID_cb, objBoMon.ID_bm)
                            For k As Integer = 0 To dt3.Rows.Count - 1
                                Dim objGiangVienMonDay As New ESSGiangVienMonDay
                                objGiangVienMonDay = MappingMonHoc(dt3.Rows(k))
                                objGiangVien.dsMonDay.Add(objGiangVienMonDay)
                            Next
                            objGiangVien.dsBoMon.Add(objBoMon)
                        Next
                        arrGiangVien.Add(objGiangVien)
                    Next
                End If
            Catch ex As Exception
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Function DanhSachGiaoVienList() As DataTable
            'Dim dt As New DataTable
            'dt.Columns.Add("ID_cb", GetType(Integer))
            'dt.Columns.Add("Ho_ten", GetType(String))
            'For i As Integer = 0 To arrGiangVien.Count - 1
            '    Dim row As DataRow = dt.NewRow()
            '    Dim objGiaoVien As ESSGiaoVien = CType(arrGiangVien(i), ESSGiaoVien)
            '    row("ID_cb") = objGiaoVien.ID_cb
            '    row("Ho_ten") = objGiaoVien.Ho_ten
            '    dt.Rows.Add(row)
            'Next
            'Dim row1 As DataRow = dt.NewRow()
            'row1("ID_cb") = 0
            'row1("Ho_ten") = ""
            'dt.Rows.Add(row1)
            Dim objGiangVien_dal As New GiangVien_DataAccess
            Return objGiangVien_dal.HienThi_ESSGiangVien_DanhSach()
        End Function

        Public Function HienThi_ESSGiangVien_list(Optional ByVal ID_khoa As Integer = 0, Optional ByVal ID_bm As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ho_ten", GetType(String))

            If ID_bm = 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If objGiangVien.ID_khoa = ID_khoa Then
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ho_ten") = objGiangVien.Ho_ten
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm > 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If objGiangVien.ID_khoa = ID_khoa Or CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ho_ten") = objGiangVien.Ho_ten
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm = 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ho_ten") = objGiangVien.Ho_ten
                    dt.Rows.Add(row)
                Next
            ElseIf ID_bm > 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ho_ten") = objGiangVien.Ho_ten
                        dt.Rows.Add(row)
                    End If
                Next
            End If
            Dim row1 As DataRow = dt.NewRow()
            row1("ID_cb") = 0
            row1("Ho_ten") = ""
            dt.Rows.Add(row1)
            Return dt
        End Function

        Public Function DanhSachGiangVien(Optional ByVal ID_khoa As Integer = 0, Optional ByVal ID_bm As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))

            If ID_bm = 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If objGiangVien.ID_khoa = ID_khoa Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm > 0 And ID_khoa > 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If objGiangVien.ID_khoa = ID_khoa Or CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            ElseIf ID_bm = 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ten_khoa") = objGiangVien.ten_khoa
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    dt.Rows.Add(row)
                Next
            ElseIf ID_bm > 0 And ID_khoa = 0 Then
                For i As Integer = 0 To arrGiangVien.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                    If CheckExistBoMon(objGiangVien, ID_bm) Then
                        row("Chuc_danh") = objGiangVien.chuc_danh
                        row("Chuc_vu") = objGiangVien.Chuc_vu
                        row("Gioi_tinh") = objGiangVien.gioi_tinh
                        row("Ho_ten") = objGiangVien.Ho_ten
                        row("Hoc_ham") = objGiangVien.hoc_ham
                        row("Hoc_vi") = objGiangVien.hoc_vi
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                        row("ID_khoa") = objGiangVien.ID_khoa
                        dt.Rows.Add(row)
                    End If
                Next
            End If
            Dim row1 As DataRow = dt.NewRow()
            row1("ID_cb") = 0
            row1("Ho_ten") = ""
            dt.Rows.Add(row1)
            Return dt
        End Function
        Public Function DanhSachGiangVienTrongBoMon(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            For i As Integer = 0 To arrGiangVien.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                If CheckExistBoMon(objGiangVien, ID_bm) = True Then
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    row("ID_bm") = ID_bm
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachPhanGiaoVien(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            For i As Integer = 0 To arrGiangVien.Count - 1
                Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                If ID_bm > 0 Then
                    If CheckExistBoMon(objGiangVien, ID_bm) = True Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_cb") = objGiangVien.ID_cb
                        row("Ma_cb") = objGiangVien.Ma_cb
                        row("Ho_ten") = objGiangVien.Ho_ten
                        dt.Rows.Add(row)
                    End If
                Else
                    Dim row As DataRow = dt.NewRow()
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ma_cb") = objGiangVien.Ma_cb
                    row("Ho_ten") = objGiangVien.Ho_ten
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function DanhSachGiangVienNgoaiBoMon(ByVal ID_bm As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chuc_danh", GetType(String))
            dt.Columns.Add("Chuc_vu", GetType(String))
            dt.Columns.Add("Gioi_tinh", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Hoc_ham", GetType(String))
            dt.Columns.Add("Hoc_vi", GetType(String))
            dt.Columns.Add("ID_cb", GetType(Integer))
            dt.Columns.Add("Ten_khoa", GetType(String))
            dt.Columns.Add("Ma_cb", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("ID_khoa", GetType(Integer))
            dt.Columns.Add("ID_bm", GetType(Integer))
            For i As Integer = 0 To arrGiangVien.Count - 1
                Dim row As DataRow = dt.NewRow()
                Dim objGiangVien As ESSGiangVien = CType(arrGiangVien(i), ESSGiangVien)
                If CheckExistBoMon(objGiangVien, ID_bm) = False Then
                    row("Chuc_danh") = objGiangVien.chuc_danh
                    row("Chuc_vu") = objGiangVien.Chuc_vu
                    row("Gioi_tinh") = objGiangVien.gioi_tinh
                    row("Ho_ten") = objGiangVien.Ho_ten
                    row("Hoc_ham") = objGiangVien.hoc_ham
                    row("Hoc_vi") = objGiangVien.hoc_vi
                    row("ID_cb") = objGiangVien.ID_cb
                    row("Ma_cb") = objGiangVien.Ma_cb
                    If objGiangVien.Ngay_sinh.ToString <> "" Then row("Ngay_sinh") = objGiangVien.Ngay_sinh
                    row("ID_khoa") = objGiangVien.ID_khoa
                    row("ID_bm") = ID_bm
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function GetGiangVien(ByVal ID_cb As Integer) As ESSGiangVien
            Dim objGiangVien As New ESSGiangVien
            Dim idx As Integer = TimIdx(ID_cb)
            Return arrGiangVien(idx)
        End Function
        Public Function LoadMonDay(ByVal ID_cb As Integer, Optional ByVal ID_bm As Integer = 0) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_mon", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            Dim idx As Integer = TimIdx(ID_cb)
            If idx >= 0 Then
                Dim objGiangVien As New ESSGiangVien
                objGiangVien = CType(arrGiangVien(idx), ESSGiangVien)
                If ID_bm > 0 Then
                    For i As Integer = 0 To objGiangVien.dsMonDay.Count - 1
                        Dim objGiangvienMonDay As ESSGiangVienMonDay = CType(objGiangVien.dsMonDay(i), ESSGiangVienMonDay)
                        If objGiangvienMonDay.ID_bm = ID_bm Then
                            Dim row As DataRow = dt.NewRow()
                            row("ID_mon") = objGiangvienMonDay.ID_mon
                            row("Ky_hieu") = objGiangvienMonDay.Ky_hieu
                            row("Ten_mon") = objGiangvienMonDay.Ten_mon
                            dt.Rows.Add(row)
                        End If
                    Next
                Else
                    For i As Integer = 0 To objGiangVien.dsMonDay.Count - 1
                        Dim objGiangvienMonDay As ESSGiangVienMonDay = CType(objGiangVien.dsMonDay(i), ESSGiangVienMonDay)
                        Dim row As DataRow = dt.NewRow()
                        row("ID_mon") = objGiangvienMonDay.ID_mon
                        row("Ky_hieu") = objGiangvienMonDay.Ky_hieu
                        row("Ten_mon") = objGiangvienMonDay.Ten_mon
                        dt.Rows.Add(row)
                    Next
                End If
            End If
            Return dt
        End Function
        Public Function ThemMoi_ESSGiangVien(ByVal objGiangVien As ESSGiangVien, ByVal Mat_khau As String, ByVal ID_bomon As Integer) As Integer
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                Return obj.ThemMoi_ESSGiangVien(objGiangVien, XCrypto.MD5(Mat_khau), ID_bomon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSGiangVien(ByVal objGiangVien As ESSGiangVien) As Integer
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                Return obj.CapNhat_ESSGiangVien(objGiangVien)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSGiangVien(ByVal ID_cb As Integer) As Integer
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                Return obj.Xoa_ESSGiangVien(ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_IDGiangVien(ByVal ID_cb As Integer) As Boolean
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                obj.CheckExist_IDGiangVien(ID_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaGiangVien(ByVal Ma_cb As String) As Boolean
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                Return obj.CheckExist_MaGiangVien(Ma_cb)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function CheckExistBoMon(ByVal objGiangVien As ESSGiangVien, ByVal ID_bm As Integer) As Boolean
            For i As Integer = 0 To objGiangVien.dsBoMon.Count - 1
                If ID_bm = CType(objGiangVien.dsBoMon(i), ESSBoMon).ID_bm Then
                    Return True
                End If
            Next
            Return False
        End Function
        Public Function GetMaxID_GiangVien() As Integer
            Try
                Dim obj As GiangVien_DataAccess = New GiangVien_DataAccess
                Return obj.GetMaxID_GiangVien()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function MappingGiangVien(ByVal drGiangVien As DataRow) As ESSGiangVien
            Dim result As ESSGiangVien
            Try
                result = New ESSGiangVien
                If drGiangVien("ID_cb").ToString() <> "" Then result.ID_cb = CType(drGiangVien("ID_cb").ToString(), Integer)
                result.Ma_cb = drGiangVien("Ma_cb").ToString()
                result.Ten = drGiangVien("Ten").ToString()
                result.Ho_ten = drGiangVien("Ho_ten").ToString()
                If drGiangVien("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drGiangVien("ID_gioi_tinh").ToString(), Integer)
                If drGiangVien("Gioi_tinh").ToString() <> "" Then result.gioi_tinh = CType(drGiangVien("Gioi_tinh").ToString(), String)
                If drGiangVien("Ngay_sinh").ToString() <> "" Then
                    result.Ngay_sinh = CType(drGiangVien("Ngay_sinh").ToString(), Date)
                Else
                    result.Ngay_sinh = ""
                End If
                If drGiangVien("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drGiangVien("ID_khoa").ToString(), Integer)
                If drGiangVien("Ten_khoa").ToString() <> "" Then result.ten_khoa = CType(drGiangVien("Ten_khoa").ToString(), String)
                If drGiangVien("ID_hoc_ham").ToString() <> "" Then result.ID_hoc_ham = CType(drGiangVien("ID_hoc_ham").ToString(), Integer)
                If drGiangVien("Hoc_ham").ToString() <> "" Then result.hoc_ham = CType(drGiangVien("Hoc_ham").ToString(), String)
                If drGiangVien("ID_hoc_vi").ToString() <> "" Then result.ID_hoc_vi = CType(drGiangVien("ID_hoc_vi").ToString(), Integer)
                If drGiangVien("Hoc_vi").ToString() <> "" Then result.hoc_vi = CType(drGiangVien("Hoc_vi").ToString(), String)
                If drGiangVien("ID_chuc_danh").ToString() <> "" Then result.ID_chuc_danh = CType(drGiangVien("ID_chuc_danh").ToString(), Integer)
                If drGiangVien("Chuc_danh").ToString() <> "" Then result.chuc_danh = CType(drGiangVien("Chuc_danh").ToString(), String)
                If drGiangVien("ID_chuc_vu").ToString() <> "" Then result.ID_chuc_vu = CType(drGiangVien("ID_chuc_vu").ToString(), Integer)
                If drGiangVien("Chuc_vu").ToString() <> "" Then result.Chuc_vu = CType(drGiangVien("Chuc_vu").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingBoMon(ByVal drBomon As DataRow) As ESSBoMon
            Dim result As ESSBoMon
            Try
                result = New ESSBoMon
                If drBomon("ID_bm").ToString() <> "" Then result.ID_bm = CType(drBomon("ID_bm").ToString(), Integer)
                result.Ma_bo_mon = drBomon("Ma_bo_mon").ToString()
                result.Bo_mon = drBomon("Bo_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingMonHoc(ByVal drGiangVienMonDay As DataRow) As ESSGiangVienMonDay
            Dim result As ESSGiangVienMonDay
            Try
                result = New ESSGiangVienMonDay
                If drGiangVienMonDay("ID_mon").ToString() <> "" Then result.ID_mon = CType(drGiangVienMonDay("ID_mon").ToString(), Integer)
                If drGiangVienMonDay("ID_bm").ToString() <> "" Then result.ID_bm = CType(drGiangVienMonDay("ID_bm").ToString(), Integer)
                result.Ky_hieu = drGiangVienMonDay("Ky_hieu").ToString()
                result.Ten_mon = drGiangVienMonDay("Ten_mon").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function TimIdx(ByVal ID_cb As Integer) As Integer
            For i As Integer = 0 To arrGiangVien.Count - 1
                If CType(arrGiangVien(i), ESSGiangVien).ID_cb = ID_cb Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace
