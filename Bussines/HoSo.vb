'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, April 17, 2010 
'---------------------------------------------------------------------------

Imports System
Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class HoSo_Bussines
        Private arrHoSo As ArrayList

#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_sv As String)
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHoSo_DanhSach(dsID_sv)
                Dim objsvHoSo As ESSHoSo = Nothing
                Dim dr As DataRow = Nothing
                arrHoSo = New ArrayList
                For Each dr In dt.Rows
                    objsvHoSo = Mapping(dr)
                    arrHoSo.Add(objsvHoSo)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal dsID_lop As String, ByVal HoSoXoa As Boolean)
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHoSoXoa_DanhSach()
                Dim objsvHoSo As ESSHoSo = Nothing
                Dim dr As DataRow = Nothing
                arrHoSo = New ArrayList
                For Each dr In dt.Rows
                    objsvHoSo = Mapping(dr)
                    arrHoSo.Add(objsvHoSo)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
#Region "FunctionSub"
        Public Function LoadDanhSach_HoSoXoa() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Byte))
                dt.Columns.Add("ID_sv")
                dt.Columns.Add("Ma_sv")
                dt.Columns.Add("Ho_ten")
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                Dim obj As New ESSHoSo
                Dim r As DataRow
                For i As Integer = 0 To arrHoSo.Count - 1
                    obj = arrHoSo(i)
                    r = dt.NewRow
                    r("Chon") = 0
                    r("ID_sv") = obj.ID_sv
                    r("Ma_sv") = obj.Ma_sv
                    r("Ho_ten") = obj.Ho_ten
                    r("Ngay_sinh") = CDate(obj.Ngay_sinh).Date
                    dt.Rows.Add(r)
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadHoSoSub(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As New HoSo_DataAccess
                Dim dt As DataTable = obj.LoadHoSoSub(ID_sv)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.ThemMoi_ESSHoSoSinhVienSub(dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoSinhVienSub(ByVal dt As DataTable) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CapNhat_ESSHoSoSinhVienSub(dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoSinhVienSub(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.Xoa_ESSHoSoSinhVienSub(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svHoSoSinhVienSub(ByVal ID_sv As Integer) As Boolean
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CheckExist_HoSoSinhVienSub(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#End Region

        Public Function LoadID_dt_nganh2(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As New HoSo_DataAccess
                Dim dt As DataTable = obj.LoadID_dt_nganh2(ID_sv)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("ID_dt")
                Else
                    Return -1
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Table ho so sinh viên dung trong in bao cao
        Public Function LoadDataHoSo() As DataTable
            Try
                Dim clsDM As New DanhMuc_Bussines
                Dim dvQT As New DataView
                dvQT = clsDM.DanhMuc_Load("STU_QuocTich", "ID_Quoc_tich", "Quoc_tich").DefaultView
                Dim dvDT As New DataView
                dvDT = clsDM.DanhMuc_Load("STU_DanToc", "ID_dan_toc", "Dan_toc").DefaultView

                Dim dt As New DataTable
                dt.Columns.Add("Anh", GetType(Byte()))
                dt.Columns.Add("Ho_ten", GetType(String))
                'Ngày sinh
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ngay1", GetType(String))
                dt.Columns.Add("Ngay2", GetType(String))
                dt.Columns.Add("Thang1", GetType(String))
                dt.Columns.Add("Thang2", GetType(String))
                dt.Columns.Add("Nam1", GetType(String))
                dt.Columns.Add("Nam2", GetType(String))

                ' Địa chỉ báo tin, Điện thoại nhà riêng
                dt.Columns.Add("Dia_chi_bao_tin", GetType(String))
                dt.Columns.Add("Dien_thoai_NR", GetType(String))

                dt.Columns.Add("ID_gioi_tinh", GetType(String))
                dt.Columns.Add("Dan_toc", GetType(String))
                dt.Columns.Add("Dia_chi_tt", GetType(String))
                dt.Columns.Add("Ton_giao", GetType(String))
                dt.Columns.Add("Thanh_phan_xuat_than", GetType(String))
                'Khu vực tuyển sinh
                dt.Columns.Add("KV1", GetType(String))
                dt.Columns.Add("KV2", GetType(String))
                dt.Columns.Add("Ma_kv", GetType(String))
                'Đối tượng dự thi
                dt.Columns.Add("DT_du_thi1", GetType(String))
                dt.Columns.Add("DT_du_thi2", GetType(String))
                dt.Columns.Add("Ten_doi_tuong", GetType(String))
                'Ký hiệu trường
                dt.Columns.Add("KHT1", GetType(String))
                dt.Columns.Add("KHT2", GetType(String))
                dt.Columns.Add("KHT3", GetType(String))
                'Ngành học
                dt.Columns.Add("NH1", GetType(String))
                dt.Columns.Add("NH2", GetType(String))
                dt.Columns.Add("NH3", GetType(String))

                dt.Columns.Add("SBD", GetType(String))
                dt.Columns.Add("Xep_loai_hoc_tap", GetType(String))
                dt.Columns.Add("Xep_loai_hanh_kiem", GetType(String))
                dt.Columns.Add("Xep_loai_tot_nghiep", GetType(String))

                dt.Columns.Add("Tong_diem", GetType(String))
                dt.Columns.Add("Diem1", GetType(String))
                dt.Columns.Add("Diem2", GetType(String))
                dt.Columns.Add("Diem3", GetType(String))

                dt.Columns.Add("Diem_thuong", GetType(String))
                dt.Columns.Add("Ly_do_thuong_diem", GetType(String))

                dt.Columns.Add("Ngay_vao_doan", GetType(String))
                dt.Columns.Add("Ngay_vao_dang", GetType(String))
                'Năm tốt nghiệp
                dt.Columns.Add("NTN1", GetType(String))
                dt.Columns.Add("NTN2", GetType(String))
                dt.Columns.Add("Khen_thuong_ky_luat", GetType(String))

                dt.Columns.Add("CMND", GetType(String))
                'Mã sinh viên
                dt.Columns.Add("m1", GetType(String))
                dt.Columns.Add("m2", GetType(String))
                dt.Columns.Add("m3", GetType(String))
                dt.Columns.Add("m4", GetType(String))
                dt.Columns.Add("m5", GetType(String))
                dt.Columns.Add("m6", GetType(String))
                dt.Columns.Add("m7", GetType(String))
                dt.Columns.Add("m8", GetType(String))
                dt.Columns.Add("m9", GetType(String))
                dt.Columns.Add("m10", GetType(String))

                dt.Columns.Add("Qua_trinh_HT_LD", GetType(String))

                dt.Columns.Add("Ho_ten_cha", GetType(String))
                dt.Columns.Add("Quoc_tich_cha", GetType(String))
                dt.Columns.Add("Dan_toc_cha", GetType(String))
                dt.Columns.Add("Ton_giao_cha", GetType(String))
                dt.Columns.Add("Ho_khau_tt_cha", GetType(String))
                dt.Columns.Add("Hoat_dong_XH_CT_cha", GetType(String))

                dt.Columns.Add("Ho_ten_me", GetType(String))
                dt.Columns.Add("Quoc_tich_me", GetType(String))
                dt.Columns.Add("Dan_toc_me", GetType(String))
                dt.Columns.Add("Ton_giao_me", GetType(String))
                dt.Columns.Add("Ho_khau_tt_me", GetType(String))
                dt.Columns.Add("Hoat_dong_XH_CT_me", GetType(String))

                dt.Columns.Add("Ho_ten_vo_chong", GetType(String))
                dt.Columns.Add("Quoc_tich_vo_chong", GetType(String))
                dt.Columns.Add("Dan_toc_vo_chong", GetType(String))
                dt.Columns.Add("Ton_giao_vo_chong", GetType(String))
                dt.Columns.Add("Ho_khau_tt_vo_chong", GetType(String))
                dt.Columns.Add("Hoat_dong_XH_CT_vo_chong", GetType(String))

                dt.Columns.Add("Ho_ten_nghe_nghiep_anh_em", GetType(String))

                Dim hs As ESSHoSo = CType(arrHoSo(0), ESSHoSo)
                Dim row As DataRow = dt.NewRow()

                If hs.Anh.Length > 0 Then row("Anh") = hs.Anh
                row("Ho_ten") = hs.Ho_ten.ToUpper
                If Day(hs.Ngay_sinh).ToString.Length = 1 Then
                    row("Ngay1") = 0
                    row("Ngay2") = Right(Day(hs.Ngay_sinh), 1)
                Else
                    row("Ngay1") = Left(Day(hs.Ngay_sinh), 1)
                    row("Ngay2") = Right(Day(hs.Ngay_sinh), 1)
                End If
                If Month(hs.Ngay_sinh).ToString.Length = 1 Then
                    row("Thang1") = 0
                    row("Thang2") = Right(Month(hs.Ngay_sinh), 1)
                Else
                    row("Thang1") = Left(Month(hs.Ngay_sinh), 1)
                    row("Thang2") = Right(Month(hs.Ngay_sinh), 1)
                End If
                row("Nam1") = Year(hs.Ngay_sinh).ToString.Substring(2, 1)
                row("Nam2") = Right(Year(hs.Ngay_sinh), 1)
                row("Ngay_sinh") = hs.Ngay_sinh
                row("Dia_chi_bao_tin") = hs.Dia_chi_bao_tin
                row("Dien_thoai_NR") = hs.Dien_thoai_NR
                row("ID_gioi_tinh") = hs.ID_gioi_tinh
                If hs.ID_dan_toc = 1 Then
                    row("Dan_toc") = 1
                Else
                    row("Dan_toc") = 0
                End If
                row("Dia_chi_tt") = hs.Dia_chi_tt
                row("Ton_giao") = hs.Ton_giao
                ' Thành phần xuất thân               
                If hs.ID_thanh_phan_xuat_than = 1 Then
                    row("Thanh_phan_xuat_than") = 1
                ElseIf hs.ID_thanh_phan_xuat_than = 2 Then
                    row("Thanh_phan_xuat_than") = 2
                Else
                    row("Thanh_phan_xuat_than") = 3
                End If
                ' khu vục tuyển sinh
                If hs.ID_khu_vuc_TS = 1 Or hs.ID_khu_vuc_TS = 2 Or hs.ID_khu_vuc_TS = 3 Then
                    row("KV1") = 0
                    row("KV2") = 1
                ElseIf hs.ID_khu_vuc_TS = 4 Or hs.ID_khu_vuc_TS = 5 Then
                    row("KV1") = 0
                    row("KV2") = 2
                ElseIf hs.ID_khu_vuc_TS = 6 Then
                    row("KV1") = 0
                    row("KV2") = 3
                Else ' Khu vực khó khăn 135
                    row("KV1") = "K"
                    row("KV2") = "K"
                End If
                Dim dvKV As New DataView
                dvKV = clsDM.DanhMuc_Load("STU_KhuVuc", "ID_kv", "Ma_kv").DefaultView
                dvKV.RowFilter = "ID_kv=" & hs.ID_khu_vuc_TS
                If dvKV.Count > 0 Then row("Ma_kv") = dvKV.Item(0)("Ma_kv").ToString
                ' Đối tượng dự thi  
                For j As Integer = 0 To hs.Doi_tuong_du_thi.Length - 1
                    Select Case j
                        Case 0 : row("DT_du_thi1") = hs.Doi_tuong_du_thi.ToString.Substring(0, 1)
                        Case 1 : row("DT_du_thi2") = hs.Doi_tuong_du_thi.ToString.Substring(1, 1)
                    End Select
                Next
                ' Nam tot nghiep               
                If hs.Nam_tot_nghiep.Length >= 4 Then
                    row("NTN1") = IIf(hs.Nam_tot_nghiep = "", "", hs.Nam_tot_nghiep.Substring(2, 1))
                    row("NTN2") = IIf(hs.Nam_tot_nghiep = "", "", hs.Nam_tot_nghiep.Substring(3, 1))
                End If
                ' Ma sinh viên
                For i As Integer = 0 To hs.Ma_sv.ToString.Length - 1
                    Select Case i
                        Case 0 : row("m1") = hs.Ma_sv.ToString.Substring(0, 1)
                        Case 1 : row("m2") = hs.Ma_sv.ToString.Substring(1, 1)
                        Case 2 : row("m3") = hs.Ma_sv.ToString.Substring(2, 1)
                        Case 3 : row("m4") = hs.Ma_sv.ToString.Substring(3, 1)
                        Case 4 : row("m5") = hs.Ma_sv.ToString.Substring(4, 1)
                        Case 5 : row("m6") = hs.Ma_sv.ToString.Substring(5, 1)
                        Case 6 : row("m7") = hs.Ma_sv.ToString.Substring(6, 1)
                        Case 7 : row("m8") = hs.Ma_sv.ToString.Substring(7, 1)
                        Case 8 : row("m9") = hs.Ma_sv.ToString.Substring(8, 1)
                        Case 9 : row("m10") = hs.Ma_sv.ToString.Substring(9, 1)
                    End Select
                Next
                'Ky hieu truong
                row("KHT1") = "D"
                row("KHT2") = "A"
                row("KHT3") = "N"
                'Nganh hoc
                For j As Integer = 0 To hs.Nganh_tuyen_sinh.Length - 1
                    Select Case j
                        Case 0 : row("NH1") = hs.Nganh_tuyen_sinh.ToString.Substring(0, 1)
                        Case 1 : row("NH2") = hs.Nganh_tuyen_sinh.ToString.Substring(1, 1)
                        Case 2 : row("NH3") = hs.Nganh_tuyen_sinh.ToString.Substring(2, 1)
                    End Select
                Next
                row("SBD") = hs.SBD
                row("Xep_loai_hoc_tap") = hs.Xep_loai_hoc_tap
                row("Xep_loai_hanh_kiem") = hs.Xep_loai_hanh_kiem
                row("Xep_loai_tot_nghiep") = hs.Xep_loai_tot_nghiep

                row("Tong_diem") = hs.Tong_diem
                row("Diem1") = hs.Diem1
                row("Diem2") = hs.Diem2
                row("Diem3") = hs.Diem3
                row("Diem_thuong") = hs.Diem_thuong
                row("Ly_do_thuong_diem") = hs.Ly_do_thuong_diem
                If hs.Ngay_vao_doan <> Nothing Then row("Ngay_vao_doan") = hs.Ngay_vao_doan
                If hs.Ngay_vao_dang <> Nothing Then row("Ngay_vao_dang") = hs.Ngay_vao_dang
                row("Khen_thuong_ky_luat") = hs.Khen_thuong_ky_luat
                row("CMND") = hs.CMND
                row("Qua_trinh_HT_LD") = hs.Qua_trinh_HT_LD

                row("Ho_ten_cha") = hs.Ho_ten_cha
                dvQT.RowFilter = "ID_quoc_tich=" & hs.ID_quoc_tich_cha
                If dvQT.Count > 0 Then
                    row("Quoc_tich_cha") = dvQT.Item(0).Item("Quoc_tich")
                Else
                    row("Quoc_tich_cha") = ""
                End If
                dvDT.RowFilter = "ID_dan_toc=" & hs.ID_dan_toc_cha
                If dvDT.Count > 0 Then
                    row("Dan_toc_cha") = dvDT.Item(0).Item("Dan_toc").ToString
                Else
                    row("Dan_toc_cha") = ""
                End If
                row("Ton_giao_cha") = hs.Ton_giao_cha
                row("Ho_khau_tt_cha") = hs.Ho_khau_TT_cha
                row("Hoat_dong_XH_CT_cha") = hs.Hoat_dong_XH_CT_cha

                row("Ho_ten_me") = hs.Ho_ten_me
                dvQT.RowFilter = "ID_quoc_tich=" & hs.ID_quoc_tich_me
                If dvQT.Count > 0 Then
                    row("Quoc_tich_me") = dvQT.Item(0).Item("Quoc_tich")
                Else
                    row("Quoc_tich_me") = ""
                End If
                dvDT.RowFilter = "ID_dan_toc=" & hs.ID_dan_toc_me
                If dvDT.Count > 0 Then
                    row("Dan_toc_me") = dvDT.Item(0).Item("Dan_toc").ToString
                Else
                    row("Dan_toc_me") = ""
                End If
                row("Ton_giao_me") = hs.Ton_giao_me
                row("Ho_khau_tt_me") = hs.Ho_khau_TT_me
                row("Hoat_dong_XH_CT_me") = hs.Hoat_dong_XH_CT_me

                row("Ho_ten_vo_chong") = hs.Ho_ten_vo_chong
                dvQT.RowFilter = "ID_quoc_tich=" & hs.ID_quoc_tich_vo_chong
                If dvQT.Count > 0 Then
                    row("Quoc_tich_vo_chong") = dvQT.Item(0).Item("Quoc_tich")
                Else
                    row("Quoc_tich_vo_chong") = ""
                End If
                dvDT.RowFilter = "ID_dan_toc=" & hs.ID_dan_toc_vo_chong
                If dvDT.Count > 0 Then
                    row("Dan_toc_vo_chong") = dvDT.Item(0).Item("Dan_toc").ToString
                Else
                    row("Dan_toc_vo_chong") = ""
                End If
                row("Ton_giao_vo_chong") = hs.Ton_giao_vo_chong
                row("Ho_khau_tt_vo_chong") = hs.Ho_khau_TT_vo_chong
                row("Hoat_dong_XH_CT_vo_chong") = hs.Hoat_dong_XH_CT_vo_chong
                row("Ho_ten_nghe_nghiep_anh_em") = hs.Ho_ten_nghe_nghiep_anh_em
                dt.Rows.Add(row)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Trả về một đối tượng hồ sơ theo chỉ số mảng
        Public Function HoSo_SinhVien_Index(ByVal idx As Integer) As ESSHoSo
            Try
                If idx > arrHoSo.Count - 1 Then idx = arrHoSo.Count - 1
                If idx < 0 Then idx = 0
                Dim hs_return As New ESSHoSo
                hs_return = arrHoSo(idx)
                Return hs_return
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_MaSinhVien(ByVal Ma_sv As String) As Boolean
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CheckExist_MaSinhVien(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetID_SV(ByVal Ma_sv As String) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.GetID_SV(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetImage(ByVal Ma_sv As String) As Byte()
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.GetImage(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSo(ByVal objHoSo As ESSHoSo) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.ThemMoi_ESSHoSo(objHoSo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoTemp(ByVal objHoSo As ESSHoSo) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.ThemMoi_ESSHoSoTemp(objHoSo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSo_KhoiPhuc(ByVal objHoSo As ESSHoSo) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.ThemMoi_ESSHoSo_KhoiPhuc(objHoSo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSHoSoXoa(ByVal objHoSo As ESSHoSo) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.ThemMoi_ESSHoSoXoa(objHoSo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSo(ByVal objHoSo As ESSHoSo, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CapNhat_ESSHoSo(objHoSo, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSo(ByVal strUpdate As String) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CapNhat_ESSHoSo(strUpdate)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoDTChinhSanh(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CapNhat_ESSHoSoDTChinhSanh(ID_dt, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSHoSoDTTroCap(ByVal ID_dt As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.CapNhat_ESSHoSoDTTroCap(ID_dt, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSo(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.Xoa_ESSHoSo(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoXoa(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.Xoa_ESSHoSoXoa(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoTemp(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.Xoa_ESSHoSoTemp(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSHoSoTempMa_sv(ByVal Ma_sv As String) As Integer
            Try
                Dim obj As HoSo_DataAccess = New HoSo_DataAccess
                Return obj.Xoa_ESSHoSoTempMa_sv(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSHoSo_Report_Load(ByVal ID_sv As Integer) As DataTable
            Dim obj As HoSo_DataAccess = New HoSo_DataAccess
            Return obj.HienThi_ESSHoSo_Report_Load(ID_sv)
        End Function

        Public Function HienThi_ESSHoSo_Report1_Load(ByVal Ma_sv As String) As DataTable
            Dim obj As HoSo_DataAccess = New HoSo_DataAccess
            Return obj.HienThi_ESSHoSo_Report_Load1(Ma_sv)
        End Function



        Public Function Mapping(ByVal drHoSo As DataRow) As ESSHoSo
            Dim result As ESSHoSo
            Dim ms As New MemoryStream
            Try
                result = New ESSHoSo
                If drHoSo("ID_sv").ToString() <> "" Then result.ID_sv = CType(drHoSo("ID_sv").ToString(), Integer)
                result.Anh = CType(IIf(IsDBNull(drHoSo("Anh")), ms.GetBuffer, drHoSo("Anh")), Byte())
                result.Ma_sv = drHoSo("Ma_sv").ToString()
                result.Ho_ten = drHoSo("Ho_ten").ToString()
                If drHoSo("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drHoSo("Ngay_sinh").ToString(), Date)
                If drHoSo("ID_gioi_tinh").ToString() <> "" Then result.ID_gioi_tinh = CType(drHoSo("ID_gioi_tinh").ToString(), Integer)
                If drHoSo("ID_dan_toc").ToString() <> "" Then result.ID_dan_toc = CType(drHoSo("ID_dan_toc").ToString(), Integer)
                If drHoSo("ID_quoc_tich").ToString() <> "" Then result.ID_quoc_tich = CType(drHoSo("ID_quoc_tich").ToString(), Integer)
                result.Ton_giao = drHoSo("Ton_giao").ToString()
                If drHoSo("ID_thanh_phan_xuat_than").ToString() <> "" Then result.ID_thanh_phan_xuat_than = CType(drHoSo("ID_thanh_phan_xuat_than").ToString(), Integer)
                If drHoSo("Ngay_vao_doan").ToString() <> "" Then result.Ngay_vao_doan = CType(drHoSo("Ngay_vao_doan").ToString(), Date)
                If drHoSo("Ngay_vao_dang").ToString() <> "" Then result.Ngay_vao_dang = CType(drHoSo("Ngay_vao_dang").ToString(), Date)
                result.Que_quan = drHoSo("Que_quan").ToString()
                If drHoSo("ID_tinh_ns").ToString() <> "" Then result.ID_tinh_ns = CType(drHoSo("ID_tinh_ns").ToString(), String)
                result.Dia_chi_tt = drHoSo("Dia_chi_tt").ToString()
                result.Xa_phuong_tt = drHoSo("Xa_phuong_tt").ToString()
                If drHoSo("ID_huyen_tt").ToString() <> "" Then result.ID_huyen_tt = CType(drHoSo("ID_huyen_tt").ToString(), String)
                If drHoSo("ID_tinh_tt").ToString() <> "" Then result.ID_tinh_tt = CType(drHoSo("ID_tinh_tt").ToString(), String)
                If drHoSo("ID_doi_tuong_TC").ToString() <> "" Then result.ID_doi_tuong_TC = CType(drHoSo("ID_doi_tuong_TC").ToString(), Integer)
                If drHoSo("ID_doi_tuong_TS").ToString() <> "" Then result.ID_doi_tuong_TS = CType(drHoSo("ID_doi_tuong_TS").ToString(), Integer)
                result.Dien_thoai_NR = drHoSo("Dien_thoai_NR").ToString()
                If drHoSo("ID_nhom_doi_tuong").ToString() <> "" Then result.ID_nhom_doi_tuong = CType(drHoSo("ID_nhom_doi_tuong").ToString(), Integer)
                result.Dia_chi_bao_tin = drHoSo("Dia_chi_bao_tin").ToString()
                If drHoSo("ID_khu_vuc_TS").ToString() <> "" Then result.ID_khu_vuc_TS = CType(drHoSo("ID_khu_vuc_TS").ToString(), Integer)
                result.Doi_tuong_du_thi = drHoSo("Doi_tuong_du_thi").ToString()
                If drHoSo("Diem1").ToString() <> "" Then result.Diem1 = CType(drHoSo("Diem1").ToString(), Double)
                If drHoSo("Diem2").ToString() <> "" Then result.Diem2 = CType(drHoSo("Diem2").ToString(), Double)
                If drHoSo("Diem3").ToString() <> "" Then result.Diem3 = CType(drHoSo("Diem3").ToString(), Double)
                If drHoSo("Diem4").ToString() <> "" Then result.Diem4 = CType(drHoSo("Diem4").ToString(), Double)
                If drHoSo("Tong_diem").ToString() <> "" Then result.Tong_diem = CType(drHoSo("Tong_diem").ToString(), Double)
                result.SBD = drHoSo("SBD").ToString().Trim
                result.Nganh_tuyen_sinh = drHoSo("Nganh_tuyen_sinh").ToString().Trim
                result.Khoi_thi = drHoSo("Khoi_thi").ToString()
                result.Xep_loai_hoc_tap = drHoSo("Xep_loai_hoc_tap").ToString()
                result.Xep_loai_hanh_kiem = drHoSo("Xep_loai_hanh_kiem").ToString()
                result.Xep_loai_tot_nghiep = drHoSo("Xep_loai_tot_nghiep").ToString()
                result.Nam_tot_nghiep = drHoSo("Nam_tot_nghiep").ToString().Trim
                If drHoSo("Diem_thuong").ToString() <> "" Then result.Diem_thuong = CType(drHoSo("Diem_thuong").ToString(), Double)
                result.Ly_do_thuong_diem = drHoSo("Ly_do_thuong_diem").ToString()
                result.Khen_thuong_ky_luat = drHoSo("Khen_thuong_ky_luat").ToString()
                result.Qua_trinh_HT_LD = drHoSo("Qua_trinh_HT_LD").ToString()
                result.Ho_ten_cha = drHoSo("Ho_ten_cha").ToString()
                If drHoSo("ID_quoc_tich_cha").ToString() <> "" Then result.ID_quoc_tich_cha = CType(drHoSo("ID_quoc_tich_cha").ToString(), Integer)
                If drHoSo("ID_dan_toc_cha").ToString() <> "" Then result.ID_dan_toc_cha = CType(drHoSo("ID_dan_toc_cha").ToString(), Integer)
                result.Ton_giao_cha = drHoSo("Ton_giao_cha").ToString()
                result.Ho_khau_TT_cha = drHoSo("Ho_khau_TT_cha").ToString()
                result.Hoat_dong_XH_CT_cha = drHoSo("Hoat_dong_XH_CT_cha").ToString()
                result.Ho_ten_me = drHoSo("Ho_ten_me").ToString()
                If drHoSo("ID_quoc_tich_me").ToString() <> "" Then result.ID_quoc_tich_me = CType(drHoSo("ID_quoc_tich_me").ToString(), Integer)
                If drHoSo("ID_dan_toc_me").ToString() <> "" Then result.ID_dan_toc_me = CType(IIf(drHoSo("ID_dan_toc_me").ToString() = "", 0, drHoSo("ID_dan_toc_me")), Integer)
                result.Ton_giao_me = drHoSo("Ton_giao_me").ToString()
                result.Ho_khau_TT_me = drHoSo("Ho_khau_TT_me").ToString()
                result.Hoat_dong_XH_CT_me = drHoSo("Hoat_dong_XH_CT_me").ToString()
                result.Ho_ten_vo_chong = drHoSo("Ho_ten_vo_chong").ToString()
                If drHoSo("ID_quoc_tich_vo_chong").ToString() <> "" Then result.ID_quoc_tich_vo_chong = CType(drHoSo("ID_quoc_tich_vo_chong").ToString(), Integer)
                If drHoSo("ID_dan_toc_vo_chong").ToString() <> "" Then result.ID_dan_toc_vo_chong = CType(drHoSo("ID_dan_toc_vo_chong").ToString(), Integer)
                result.Ton_giao_vo_chong = drHoSo("Ton_giao_vo_chong").ToString()
                result.Ho_khau_TT_vo_chong = drHoSo("Ho_khau_TT_vo_chong").ToString()
                result.Hoat_dong_XH_CT_vo_chong = drHoSo("Hoat_dong_XH_CT_vo_chong").ToString()
                result.Ho_ten_nghe_nghiep_anh_em = drHoSo("Ho_ten_nghe_nghiep_anh_em").ToString()
                If drHoSo("Dang_ky_hoc").ToString = "" Then
                    result.Dang_ky_hoc = False
                Else
                    result.Dang_ky_hoc = IIf(drHoSo("Dang_ky_hoc") = 0, False, True)
                End If
                result.Hoten_Order = drHoSo("Hoten_Order").ToString()
                result.Chuyen_nganh_dang_ky = drHoSo("Chuyen_nganh_dang_ky").ToString()
                result.Lop = drHoSo("Lop").ToString()
                result.Ngoai_ngu = drHoSo("Ngoai_ngu").ToString()
                If drHoSo("UserID").ToString() <> "" Then result.UserID = CType(drHoSo("UserID").ToString(), Integer)
                If drHoSo("Ngay_nhap_hoc").ToString() <> "" Then
                    result.Ngay_nhap_hoc = CType(drHoSo("Ngay_nhap_hoc").ToString(), Date)
                Else
                    result.Ngay_nhap_hoc = Now.Date
                End If
                If drHoSo("UserName_tiep_nhan").ToString() <> "" Then result.UserName_tiep_nhan = CType(drHoSo("UserName_tiep_nhan").ToString(), String)
                If drHoSo("UserID_tiep_nhan").ToString() <> "" Then result.UserID_tiep_nhan = CType(drHoSo("UserID_tiep_nhan").ToString(), Integer)
                result.CMND = drHoSo("CMND").ToString
                If drHoSo("Noi_cap").ToString() <> "" Then result.Noi_cap = CType(drHoSo("Noi_cap").ToString(), String)
                If drHoSo("Ngay_cap").ToString() <> "" Then result.Ngay_cap = CType(drHoSo("Ngay_cap").ToString(), Date)
                If drHoSo("Dienthoai_canhan").ToString() <> "" Then result.Dienthoai_canhan = CType(drHoSo("Dienthoai_canhan").ToString(), String)
                If drHoSo("Email").ToString() <> "" Then result.Email = CType(drHoSo("Email").ToString(), String)
                If drHoSo("NoiO_hiennay").ToString() <> "" Then result.NoiO_hiennay = CType(drHoSo("NoiO_hiennay").ToString(), String)
                If drHoSo("Namsinh_cha").ToString() <> "" Then result.Namsinh_cha = CType(drHoSo("Namsinh_cha").ToString().Trim, String)
                If drHoSo("Namsinh_me").ToString() <> "" Then result.Namsinh_me = CType(drHoSo("Namsinh_me").ToString().Trim, String)
                If drHoSo("IDCard").ToString() <> "" Then result.IDCard = CType(drHoSo("IDCard").ToString().Trim, String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function


#End Region
    End Class
End Namespace
