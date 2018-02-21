'Tungk
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachLuanVanThiNoTotNghiep_Bussines
        Private arrDanhSachLuanVanThiNoTotNghiep As ArrayList
        Private mID_dv As String = ""
        Private mID_bomon As Integer = 0
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachLuanVan As New ArrayList
        Private arrDanhSachThiTotNghiep As New ArrayList
        Private arrDanhSachNoTotNghiep As New ArrayList
        Private mID_dt As Integer = 0

#Region "Initialize"
        Sub New()

        End Sub
        Sub New(ByVal ID_dv As String, ByVal ID_bomon As Integer, ByVal dsID_lop As String, ByVal ID_dt As Integer, ByVal DanhSachSinhVien As DataTable)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_bomon = ID_bomon
                mID_dt = ID_dt

                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess

                Dim dt As DataTable = obj.HienThi_ESSDanhSachLuanVan_DanhSach(mdsID_lop)
                Dim objsvDanhSachLuanVan As ESSDanhSachLuanVanThiNoTotNghiep = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachLuanVan = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = Mapping(dr)
                    arrDanhSachLuanVan.Add(objsvDanhSachLuanVan)
                Next

                dt = obj.HienThi_ESSDanhSachThiTotNghiep_DanhSach(mdsID_lop)
                objsvDanhSachLuanVan = Nothing
                dr = Nothing
                arrDanhSachThiTotNghiep = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = Mapping(dr)
                    arrDanhSachThiTotNghiep.Add(objsvDanhSachLuanVan)
                Next

                dt = obj.HienThi_ESSDanhSachNoTotNghiep_DanhSach(mdsID_lop)
                objsvDanhSachLuanVan = Nothing
                dr = Nothing
                arrDanhSachNoTotNghiep = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachLuanVan = MappingNoTotNghiep(dr)
                    arrDanhSachNoTotNghiep.Add(objsvDanhSachLuanVan)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Function HienThi_ESSDanhSach_LuanVan() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon1", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("TBCHT", GetType(Double))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_hang", GetType(String))
            dt.Columns.Add("So_tin_chi", GetType(Double))
            dt.Columns.Add("SinhVien_duyet", GetType(Boolean))
            dt.Columns.Add("CoVan_duyet", GetType(Boolean))

            For i As Integer = 0 To arrDanhSachLuanVan.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("Chon1") = False
                row("ID_sv") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_sv
                row("Ma_sv") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).Ma_sv
                row("Ho_ten") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).Ho_ten
                row("Ngay_sinh") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                row("Ten_lop") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).Ten_lop
                row("TBCHT") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).TBCHT
                row("ID_xep_loai") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                row("Xep_hang") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).Xep_hang
                row("So_tin_chi") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).So_tin_chi
                row("SinhVien_duyet") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).SinhVien_duyet
                row("CoVan_duyet") = CType(arrDanhSachLuanVan(i), ESSDanhSachLuanVanThiNoTotNghiep).CoVan_duyet
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Function HienThi_ESSDanhSach_ThiTotNghiep() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon2", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv2", GetType(String))
                dt.Columns.Add("Ho_ten2", GetType(String))
                dt.Columns.Add("Ngay_sinh2", GetType(Date))
                dt.Columns.Add("Ten_lop2", GetType(String))
                dt.Columns.Add("TBCHT2", GetType(Double))
                dt.Columns.Add("ID_xep_loai", GetType(Integer))
                dt.Columns.Add("Xep_hang2", GetType(String))
                'dt.Columns.Add("Sinh_vien_duyet", GetType(Boolean))
                'dt.Columns.Add("Co_van_duyet", GetType(Boolean))

                For i As Integer = 0 To arrDanhSachThiTotNghiep.Count - 1
                    Dim row As DataRow = dt.NewRow()
                    row("Chon2") = False
                    row("ID_sv") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_sv
                    row("Ma_sv2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ma_sv
                    row("Ho_ten2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ho_ten
                    row("Ngay_sinh2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                    row("Ten_lop2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ten_lop
                    row("TBCHT2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).TBCHT
                    row("ID_xep_loai") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                    row("Xep_hang2") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Xep_hang
                    'row("Sinh_vien_duyet") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Sinh_vien_duyet
                    'row("Co_van_duyet") = CType(arrDanhSachThiTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Co_van_duyet
                    dt.Rows.Add(row)
                Next
                Return dt
            Catch ex As Exception
            End Try
        End Function

        Function HienThi_ESSDanhSach_NoTotNghiep() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv3", GetType(String))
            dt.Columns.Add("Ho_ten3", GetType(String))
            dt.Columns.Add("Ngay_sinh3", GetType(Date))
            dt.Columns.Add("Ten_lop3", GetType(String))
            dt.Columns.Add("TBCHT3", GetType(Double))
            dt.Columns.Add("ID_xep_loai", GetType(Integer))
            dt.Columns.Add("Xep_hang3", GetType(String))
            dt.Columns.Add("Ly_do", GetType(String))

            For i As Integer = 0 To arrDanhSachNoTotNghiep.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("ID_sv") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_sv
                row("Ma_sv3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ma_sv
                row("Ho_ten3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ho_ten
                row("Ngay_sinh3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ngay_sinh
                row("Ten_lop3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ten_lop
                row("TBCHT3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).TBCHT
                row("ID_xep_loai") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).ID_xep_loai
                row("Xep_hang3") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Xep_hang
                row("Ly_do") = CType(arrDanhSachNoTotNghiep(i), ESSDanhSachLuanVanThiNoTotNghiep).Ly_do
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Sub XetLuanVan(ByVal TBCHT As Double, ByVal So_tc_tich_luy As Double, ByRef dt_LuanVan As DataTable, ByRef dt_thiTN As DataTable, ByRef dt_NoThiTN As DataTable)
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(mID_dv, mID_bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            dt_LuanVan = clsDiem.XetLuanVan(TBCHT, So_tc_tich_luy)
            Dim dt_tonghop As DataTable = clsDiem.TongHop_XetThiNoThiTotNghiep
            XetThi_NoThiTotNghiep(So_tc_tich_luy, dt_LuanVan, dt_tonghop, dt_thiTN, dt_NoThiTN)
            InsertLuanVan(dt_LuanVan)
            InsertThiTotNghiep(dt_thiTN)
            InsertNoThiTotNghiep(dt_NoThiTN)
        End Sub

        Public Sub XetThiTotNghiep_BoSung(ByVal So_tc_tich_luy As Double, ByVal dt_LuanVan As DataTable, ByRef dt_thiTN As DataTable, ByRef dt_NoThiTN As DataTable)
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(mID_dv, mID_bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            Dim dt_tonghop As DataTable = clsDiem.TongHop_XetThiNoThiTotNghiep
            XetThi_NoThiTotNghiep(So_tc_tich_luy, dt_LuanVan, dt_tonghop, dt_thiTN, dt_NoThiTN)
            InsertThiTotNghiep(dt_thiTN)
            InsertNoThiTotNghiep(dt_NoThiTN)
        End Sub
        Private Sub XetThi_NoThiTotNghiep(ByVal So_tc_tich_luy As Double, ByVal dt_LuanVan As DataTable, ByVal dt_tonghop As DataTable, ByRef dt_thiTN As DataTable, ByRef dt_NoThiTN As DataTable)
            Dim dt_Thi, dt_NoThi As New DataTable
            Dim dt As DataTable = dt_tonghop
            'dt_LuuDiemKy.DefaultView.Count - 1
            'Khoi tao danh sach sinh vien phai Thi tot nghiep
            dt_Thi.Columns.Add("Chon2", GetType(Boolean))
            dt_Thi.Columns.Add("ID_SV", GetType(Integer))
            dt_Thi.Columns.Add("Ho_ten2", GetType(String))
            dt_Thi.Columns.Add("Ngay_sinh2", GetType(Date))
            dt_Thi.Columns.Add("Ten_lop2", GetType(String))
            dt_Thi.Columns.Add("TBCHT2", GetType(Double))
            dt_Thi.Columns.Add("ID_xep_loai2", GetType(Integer))
            dt_Thi.Columns.Add("Xep_hang2", GetType(String))
            dt_Thi.Columns.Add("So_hoc_trinh2", GetType(Integer))
            dt_Thi.Columns.Add("Sinh_vien_duyet", GetType(Boolean))
            dt_Thi.Columns.Add("Co_van_duyet", GetType(Boolean))


            'Khoi tao danh sach sinh vien phai No thi tot nghiep
            dt_NoThi.Columns.Add("Chon3", GetType(Boolean))
            dt_NoThi.Columns.Add("ID_SV", GetType(Integer))
            dt_NoThi.Columns.Add("Ho_ten3", GetType(String))
            dt_NoThi.Columns.Add("Ngay_sinh3", GetType(Date))
            dt_NoThi.Columns.Add("Ten_lop3", GetType(String))
            dt_NoThi.Columns.Add("TBCHT3", GetType(Double))
            dt_NoThi.Columns.Add("Ly_do", GetType(String))
            dt_NoThi.Columns.Add("So_hoc_trinh3", GetType(Integer))
            dt_NoThi.Columns.Add("ID_xep_loai3", GetType(Integer))
            dt_NoThi.Columns.Add("Xep_hang3", GetType(String))



            Dim dr As DataRow

            For i As Integer = 0 To dt.Rows.Count - 1
                dt_LuanVan.DefaultView.Sort = "ID_SV"
                If dt_LuanVan.DefaultView.Find(dt.Rows(i).Item("ID_SV")) < 0 Then
                    If dt.Rows(i).Item("Ly_do").ToString.Trim = "" AndAlso dt.Rows(i).Item("So_hoc_trinh") >= So_tc_tich_luy Then 'Thi tot nghiep
                        'Tao dt danh sach sinh vien phai thi tot nghiep
                        dr = dt_Thi.NewRow
                        dr("Chon2") = False
                        dr("ID_SV") = dt.Rows(i).Item("ID_SV")
                        dr("Ho_ten2") = dt.Rows(i).Item("Ho_ten")
                        dr("Ngay_sinh2") = dt.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop2") = dt.Rows(i).Item("Ten_lop")
                        dr("TBCHT2") = dt.Rows(i).Item("TBCHT")
                        dr("ID_xep_loai2") = dt.Rows(i).Item("ID_xep_loai")
                        dr("Xep_hang2") = dt.Rows(i).Item("Xep_hang")
                        dr("So_hoc_trinh2") = dt.Rows(i).Item("So_hoc_trinh")
                        dr("Co_van_duyet") = False
                        dr("Sinh_vien_duyet") = False
                        dt_Thi.Rows.Add(dr)

                        'Insert vao bang Thi tot nghiep; xoa sv nay ben No thi TN

                    Else 'No thi tot nghiep
                        'Tao dt danh sach sinh vien No thi tot nghiep kem Ly do
                        dr = dt_NoThi.NewRow
                        dr("Chon3") = False
                        dr("ID_SV") = dt.Rows(i).Item("ID_SV")
                        dr("Ho_ten3") = dt.Rows(i).Item("Ho_ten")
                        dr("Ngay_sinh3") = dt.Rows(i).Item("Ngay_sinh")
                        dr("Ten_lop3") = dt.Rows(i).Item("Ten_lop")
                        dr("TBCHT3") = dt.Rows(i).Item("TBCHT")
                        dr("ID_xep_loai3") = dt.Rows(i).Item("ID_xep_loai")
                        dr("Xep_hang3") = dt.Rows(i).Item("Xep_hang")
                        If dt.Rows(i).Item("So_hoc_trinh") < So_tc_tich_luy Then
                            If dt.Rows(i).Item("Ly_do").ToString <> "" Then
                                dt.Rows(i).Item("Ly_do") = dt.Rows(i).Item("Ly_do") & ", Chưa đủ số tín chỉ Tích lũy"
                            Else
                                dt.Rows(i).Item("Ly_do") = "Chưa đủ số tín chỉ Tích lũy"
                            End If
                        End If
                        dr("Ly_do") = dt.Rows(i).Item("Ly_do")
                        dr("So_hoc_trinh3") = dt.Rows(i).Item("So_hoc_trinh")
                        'dr("Co_van_duyet") = False
                        'dr("Sinh_vien_duyet") = False
                        dt_NoThi.Rows.Add(dr)

                        'Insert vao bang No thi tot nghiep; xoa sv nay ben Thi TN
                    End If
                End If
            Next
            dt_thiTN = dt_Thi
            dt_NoThiTN = dt_NoThi
        End Sub

        Private Sub InsertLuanVan(ByVal dt As DataTable)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Xoa_ESSDanhSachLuanVan(dt.DefaultView.Item(i)("ID_SV"))

                Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT")), 0, dt.DefaultView.Item(i)("TBCHT"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai")), 0, dt.DefaultView.Item(i)("ID_xep_loai"))
                obj.So_tin_chi = IIf(IsDBNull(dt.DefaultView.Item(i)("So_tin_chi")), 0, dt.DefaultView.Item(i)("So_tin_chi"))
                'obj.Co_van_duyet = IIf(dt.DefaultView.Item(i)("Co_van_duyet").ToString = "", False, dt.DefaultView.Item(i)("Co_van_duyet"))
                'obj.Sinh_vien_duyet = IIf(dt.DefaultView.Item(i)("Sinh_vien_duyet").ToString = "", False, dt.DefaultView.Item(i)("Sinh_vien_duyet"))
                ThemMoi_ESSDanhSachLuanVan(obj)
            Next
        End Sub
        Private Sub InsertThiTotNghiep(ByVal dt As DataTable)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Xoa_ESSDanhSachThiTotNghiep(dt.DefaultView.Item(i)("ID_SV"))

                Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT2")), 0, dt.DefaultView.Item(i)("TBCHT2"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai2")), 0, dt.DefaultView.Item(i)("ID_xep_loai2"))
                'obj.Co_van_duyet = dt.DefaultView.Item(i)("Co_van_duyet")
                'obj.Sinh_vien_duyet = dt.DefaultView.Item(i)("Sinh_vien_duyet")
                ThemMoi_ESSDanhSachThiTotNghiep(obj)
            Next
        End Sub
        Private Sub InsertNoThiTotNghiep(ByVal dt As DataTable)
            For i As Integer = 0 To dt.DefaultView.Count - 1
                Xoa_ESSDanhSachNoTotNghiep(dt.DefaultView.Item(i)("ID_SV"))

                Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
                obj.ID_sv = dt.DefaultView.Item(i)("ID_SV")
                obj.TBCHT = IIf(IsDBNull(dt.DefaultView.Item(i)("TBCHT3")), 0, dt.DefaultView.Item(i)("TBCHT3"))
                obj.ID_xep_loai = IIf(IsDBNull(dt.DefaultView.Item(i)("ID_xep_loai3")), 0, dt.DefaultView.Item(i)("ID_xep_loai3"))
                obj.Ly_do = dt.DefaultView.Item(i)("Ly_do")
                ThemMoi_ESSDanhSachNoTotNghiep(obj)
            Next
        End Sub

        Public Sub ChuyenThiTotNghiep(ByVal dv As DataView)
            'Dim clsDiem As Diem_Bussines
            'clsDiem = New Diem_Bussines(mID_dv, mID_bomon, 0, "", mdsID_lop, mdtDanhSachSinhVien)
            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon1") = True Then
                    Xoa_ESSDanhSachLuanVan(dv.Item(i)("ID_SV"))

                    'Dim dt_th As DataTable = clsDiem.ChuyenThi_LuanVan(dv.Item(i)("ID_SV"))

                    Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
                    obj.ID_sv = dv.Item(i)("ID_SV")
                    obj.TBCHT = IIf(IsDBNull(dv.Item(i)("TBCHT")), 0, dv.Item(i)("TBCHT"))
                    obj.ID_xep_loai = IIf(IsDBNull(dv.Item(i)("ID_xep_loai")), 0, dv.Item(i)("ID_xep_loai"))
                    ThemMoi_ESSDanhSachThiTotNghiep(obj)
                End If
            Next
        End Sub
        Public Sub ChuyenLamLuanVan(ByVal dv As DataView)

            For i As Integer = 0 To dv.Count - 1
                If dv.Table.Rows(i).Item("Chon2") = True Then
                    Xoa_ESSDanhSachThiTotNghiep(dv.Item(i)("ID_SV"))

                    ''Lay lai ESSDiem va xep loai lan 1 phu hop khi xet luan van
                    'Dim dt_th As DataTable = clsDiem.ChuyenThi_LuanVan(dv.Item(i)("ID_SV"))

                    Dim obj As New ESSDanhSachLuanVanThiNoTotNghiep
                    obj.ID_sv = dv.Item(i)("ID_SV")
                    obj.TBCHT = IIf(IsDBNull(dv.Item(i)("TBCHT2")), 0, dv.Item(i)("TBCHT2"))
                    obj.ID_xep_loai = IIf(IsDBNull(dv.Item(i)("ID_xep_loai")), 0, dv.Item(i)("ID_xep_loai"))
                    ThemMoi_ESSDanhSachLuanVan(obj)
                End If
            Next
        End Sub

        Private Function ThemMoi_ESSDanhSachLuanVan(ByVal objDanhSachLuanVanThiNoTotNghiep As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachLuanVan(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Xoa_ESSDanhSachLuanVan(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachLuanVan(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function ThemMoi_ESSDanhSachThiTotNghiep(ByVal objDanhSachLuanVanThiNoTotNghiep As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachThiTotNghiep(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Xoa_ESSDanhSachThiTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachThiTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function ThemMoi_ESSDanhSachNoTotNghiep(ByVal objDanhSachLuanVanThiNoTotNghiep As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.ThemMoi_ESSDanhSachNoTotNghiep(objDanhSachLuanVanThiNoTotNghiep)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Xoa_ESSDanhSachNoTotNghiep(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.Xoa_ESSDanhSachNoTotNghiep(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        'Function CapNhat_ESSDanhSachThiTotNghiep(ByVal obj_ As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
        '    Try
        '        Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
        '        Return obj.CapNhat_ESSDanhSachThiTotNghiep(obj_)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function
        Function CapNhat_ESSDanhSachLuanVan_SangThi(ByVal obj_ As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.CapNhat_ESSDanhSachLuanVan_SangThi(obj_)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function CapNhat_XetTotNghiep_DangKy_Them(ByVal obj_ As ESSDanhSachLuanVanThiNoTotNghiep) As Integer
            Try
                Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
                Return obj.CapNhat_XetTotNghiep_DangKy_Them(obj_)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhSachLuanVan As DataRow) As ESSDanhSachLuanVanThiNoTotNghiep
            Dim result As ESSDanhSachLuanVanThiNoTotNghiep
            Try
                result = New ESSDanhSachLuanVanThiNoTotNghiep
                If drDanhSachLuanVan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachLuanVan("ID_sv").ToString(), Integer)
                If drDanhSachLuanVan("So_tin_chi").ToString() <> "" Then result.So_tin_chi = CType(drDanhSachLuanVan("So_tin_chi").ToString(), Double)
                If drDanhSachLuanVan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachLuanVan("TBCHT").ToString(), Double)
                If drDanhSachLuanVan("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachLuanVan("ID_xep_loai").ToString(), Integer)
                result.Ma_sv = drDanhSachLuanVan("Ma_sv").ToString()
                result.Ho_ten = drDanhSachLuanVan("Ho_ten").ToString()
                result.Ten_lop = drDanhSachLuanVan("Ten_lop").ToString()
                If drDanhSachLuanVan("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachLuanVan("Ngay_sinh").ToString(), Date)
                result.Xep_hang = drDanhSachLuanVan("Xep_hang").ToString()
                result.CoVan_duyet = drDanhSachLuanVan("CoVan_duyet")
                result.SinhVien_duyet = drDanhSachLuanVan("SinhVien_duyet")
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Private Function MappingNoTotNghiep(ByVal drDanhSachLuanVan As DataRow) As ESSDanhSachLuanVanThiNoTotNghiep
            Dim result As ESSDanhSachLuanVanThiNoTotNghiep
            Try
                result = New ESSDanhSachLuanVanThiNoTotNghiep
                If drDanhSachLuanVan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachLuanVan("ID_sv").ToString(), Integer)
                If drDanhSachLuanVan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhSachLuanVan("TBCHT").ToString(), Double)
                If drDanhSachLuanVan("ID_xep_loai").ToString() <> "" Then result.ID_xep_loai = CType(drDanhSachLuanVan("ID_xep_loai").ToString(), Integer)
                result.Ma_sv = drDanhSachLuanVan("Ma_sv").ToString()
                result.Ho_ten = drDanhSachLuanVan("Ho_ten").ToString()
                result.Ten_lop = drDanhSachLuanVan("Ten_lop").ToString()
                If drDanhSachLuanVan("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachLuanVan("Ngay_sinh").ToString(), Date)
                result.Ly_do = drDanhSachLuanVan("Ly_do").ToString()
                result.Xep_hang = drDanhSachLuanVan("Xep_hang").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

        Function Load_TotNghiep_DangKy_Load(ByVal dk_lop As String) As DataTable
            Dim obj As DanhSachLuanVanThiNoTotNghiep_DataAccess = New DanhSachLuanVanThiNoTotNghiep_DataAccess
            Dim dt As DataTable = obj.HienThi_TotNghiep_DangKy(dk_lop)
            dt.Columns.Add("SinhVien_duyet", GetType(Boolean))
            dt.Columns.Add("CoVan_duyet", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i)("CoVanduyet") = 1 Or dt.Rows(i)("CoVanduyet") = True Then
                    dt.Rows(i)("CoVan_duyet") = True
                Else
                    dt.Rows(i)("CoVan_duyet") = False
                End If
                If dt.Rows(i)("SinhVienDuyet") = 1 Or dt.Rows(i)("SinhVienDuyet") = True Then
                    dt.Rows(i)("SinhVien_duyet") = True
                Else
                    dt.Rows(i)("SinhVien_duyet") = False
                End If
            Next
            Return dt
        End Function
    End Class
End Namespace
