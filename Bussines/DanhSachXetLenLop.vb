'Tungnk
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachXetLenLop_Bussines
        Private mID_dv As String = ""
        Private mdsID_lop As String = ""
        Private mdtDanhSachSinhVien As DataTable
        Private arrDanhSachXetLenLop As New ArrayList
        Private arrDanhSachXetLenLop_Nganh2 As New ArrayList
        Private mID_dt As Integer = 0
        Private mID_dts As String = "0"

#Region "Initialize"
        Sub New()

        End Sub
        Sub New(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_dt As Integer, ByVal DanhSachSinhVien As DataTable)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_dt = ID_dt

                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachTotNghiep_DanhSach(mdsID_lop, ID_he, Khoa_hoc, ID_khoa, Hoc_ky, Nam_hoc)
                Dim objsvDanhSachXetLenLop As ESSDanhSachXetLenLop = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachXetLenLop = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachXetLenLop = Mapping(dr)
                    arrDanhSachXetLenLop.Add(objsvDanhSachXetLenLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Sub New(ByVal ID_dv As String, ByVal dsID_lop As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_dts As String, ByVal DanhSachSinhVien As DataTable)
            Try
                mdtDanhSachSinhVien = DanhSachSinhVien
                mID_dv = ID_dv
                mdsID_lop = dsID_lop
                mID_dts = ID_dts

                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachTotNghiep_DanhSach(mdsID_lop, ID_he, Khoa_hoc, ID_khoa, Hoc_ky, Nam_hoc)
                Dim objsvDanhSachXetLenLop As ESSDanhSachXetLenLop = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachXetLenLop = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachXetLenLop = Mapping(dr)
                    arrDanhSachXetLenLop.Add(objsvDanhSachXetLenLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachHocTiepNganh2_DanhSach(ID_nganh)
                Dim objsvDanhSachXetLenLop As ESSDanhSachXetLenLop = Nothing
                Dim dr As DataRow = Nothing
                arrDanhSachXetLenLop_Nganh2 = New ArrayList
                For Each dr In dt.Rows
                    objsvDanhSachXetLenLop = Mapping_Nganh2(dr)
                    arrDanhSachXetLenLop_Nganh2.Add(objsvDanhSachXetLenLop)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        Function HienThi_ESSDanhSach_SoQD(ByVal So_QD As String) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(String))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("ID_QD", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Loai_QD", GetType(Integer))
            dt.Columns.Add("Ly_do2", GetType(String))
            dt.Columns.Add("ID_lop_cu", GetType(Integer))
            dt.Columns.Add("ID_lop_moi", GetType(Integer))
            dt.Columns.Add("Lop_moi", GetType(String))
            dt.Columns.Add("Ten_khoa", GetType(String))

            For i As Integer = 0 To arrDanhSachXetLenLop.Count - 1
                If CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).So_qd = So_QD Then
                    Dim row As DataRow = dt.NewRow()
                    row("ID_sv") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_sv
                    row("Ma_sv") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ma_sv
                    row("Ho_ten") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ho_ten
                    row("Ngay_sinh") = Format(CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ngay_sinh, "dd/MM/yyyy")
                    row("Ten_lop") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ten_lop
                    row("ID_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_qd
                    row("Hoc_ky") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Hoc_ky
                    row("Nam_hoc") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Nam_hoc
                    row("Ngay_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ngay_qd
                    row("Loai_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Loai_qd
                    row("Ly_do2") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ly_do
                    row("ID_lop_cu") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_lop_cu
                    row("ID_lop_moi") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_lop_moi
                    row("Lop_moi") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Lop_moi
                    row("Ten_khoa") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ten_khoa
                    row("Chon") = False
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Function HienThi_ESSDanhSach_QD_TrangThaiHoc(ByVal Loai_QD As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("ID_QD", GetType(Integer))
            dt.Columns.Add("Hoc_ky", GetType(Integer))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_QD", GetType(String))
            dt.Columns.Add("Ngay_QD", GetType(Date))
            dt.Columns.Add("Loai_QD", GetType(Integer))
            dt.Columns.Add("Ly_do", GetType(String))

            For i As Integer = 0 To arrDanhSachXetLenLop.Count - 1
                If CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Loai_qd = Loai_QD Then
                    dt.DefaultView.Sort = "ID_QD"
                    If dt.DefaultView.Find(CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_qd) < 0 Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).ID_qd
                        row("So_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).So_qd
                        row("Hoc_ky") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Hoc_ky
                        row("Nam_hoc") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Nam_hoc
                        row("Ngay_qd") = Format(CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ngay_qd, "dd/MM/yyyy")
                        row("Loai_qd") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Loai_qd
                        row("Ly_do") = CType(arrDanhSachXetLenLop(i), ESSDanhSachXetLenLop).Ly_do
                        dt.Rows.Add(row)
                    End If
                End If
            Next
            Return dt
        End Function

        Function Danh_sach_sinh_vien_chon(ByVal dv As DataView) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop_cu", GetType(Integer))
                For i As Integer = 0 To dv.Count - 1
                    If dv.Item(i)("Chon") Then
                        Dim row As DataRow = dt.NewRow()
                        row("ID_sv") = dv.Item(i)("ID_sv")
                        row("Ma_sv") = dv.Item(i)("Ma_sv")
                        row("Ho_ten") = dv.Item(i)("Ho_ten")
                        row("Ngay_sinh") = dv.Item(i)("Ngay_sinh")
                        row("ID_lop") = dv.Item(i)("ID_lop")
                        row("Ten_lop") = dv.Item(i)("Ten_lop")
                        row("ID_lop_cu") = 0
                        dt.Rows.Add(row)
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function HienThi_ESSDanhSachNgungHocThoiHoc_HienThi_DanhSach(ByVal ID_lops As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_khoa As Integer, ByVal Loai_qd As Integer) As DataTable
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.HienThi_ESSDanhSachNgungHocThoiHoc_HienThi_DanhSach(ID_lops, ID_he, Khoa_hoc, ID_khoa, Loai_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Public Function ThemMoi_ESSQuyetDinhThoiHoc(ByVal objQuyetDinhThoiHoc As ESSDanhSachXetLenLop) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.ThemMoi_ESSQuyetDinhThoiHoc(objQuyetDinhThoiHoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyetDinhThoiHoc(ByVal objQuyetDinhThoiHoc As ESSDanhSachXetLenLop, ByVal ID_qd As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.CapNhat_ESSQuyetDinhThoiHoc(objQuyetDinhThoiHoc, ID_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyetDinhThoiHoc(ByVal ID_qd As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.Xoa_ESSQuyetDinhThoiHoc(ID_qd)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        'Danh sach chi tiet
        Public Function ThemMoi_ESSQuyetDinhThoiHocChiTiet(ByVal objQuyetDinhThoiHocChiTiet As ESSDanhSachXetLenLop) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.ThemMoi_ESSQuyetDinhThoiHocChiTiet(objQuyetDinhThoiHocChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSQuyetDinhThoiHocChiTiet(ByVal objQuyetDinhThoiHocChiTiet As ESSDanhSachXetLenLop, ByVal ID_qd As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.CapNhat_ESSQuyetDinhThoiHocChiTiet(objQuyetDinhThoiHocChiTiet, ID_qd, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSQuyetDinhThoiHocChiTiet(ByVal ID_qd As Integer, ByVal ID_sv As Integer, ByVal ID_lop_cu As Integer, ByVal Loai_QD As Integer) As Integer
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.Xoa_ESSQuyetDinhThoiHocChiTiet(ID_qd, ID_sv, ID_lop_cu, Loai_QD)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        'Function XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Bomon As Integer) As DataTable
        '    Dim clsDiem As Diem_Bussines
        '    clsDiem = New Diem_Bussines(mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
        '    Dim dtDiem As DataTable = clsDiem.XetLenLop(Hoc_ky, Nam_hoc)
        '    Return dtDiem
        'End Function


        'Function XetLenLop_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Bomon As Integer) As DataTable
        '    Dim clsDiem As Diem_Bussines
        '    clsDiem = New Diem_Bussines(mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dts, mdtDanhSachSinhVien)
        '    Dim dtDiem As DataTable = clsDiem.XetLenLop(Hoc_ky, Nam_hoc)
        '    Return dtDiem
        'End Function


        Function XetLenLop_nganh2(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSDanhSachHocTiepNganh2_DanhSach(ID_nganh)
            dt.Columns.Add("Chon", GetType(Boolean))

            Dim clsDiem As Diem_Bussines
            Dim Ly_do As String = ""
            For i As Integer = 0 To dt.Rows.Count - 1
                Ly_do = ""
                'Check Nganh chinh TBCHT<2
                clsDiem = New Diem_Bussines(ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt1"))
                Dim dt_diemNganh As DataTable = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
                If dt_diemNganh.Rows.Count > 0 AndAlso IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, dt_diemNganh.Rows(0)("TBC_tich_luy")) < 2 Then
                    Ly_do = "Ngành chính xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy")
                End If
                'Check Nganh hoc thu 2 TBCHT<2
                clsDiem = New Diem_Bussines(ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt2"))
                dt_diemNganh = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
                If dt_diemNganh.Rows.Count > 0 AndAlso IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, dt_diemNganh.Rows(0)("TBC_tich_luy")) < 2 Then
                    If Ly_do.Trim = "" Then
                        Ly_do = "Ngành học thứ 2 xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy").ToString
                    Else
                        Ly_do += ", Ngành học thứ 2 xếp hạng học lực yếu: " & dt_diemNganh.Rows(0)("TBC_tich_luy").ToString
                    End If
                End If

                'Check thoi gian hoc nganh nay
                Dim cls As ChuongTrinhDaoTao_Bussines
                cls = New ChuongTrinhDaoTao_Bussines(dt.Rows(i).Item("ID_dt1"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dt.Rows(i).Item("ID_dt1"))
                Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
                Dim NienKhoa_Dau As Integer = CType(Left(dt.Rows(i).Item("Nien_khoa"), 4), Integer)
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1
                If So_ky_ToiDa < So_ky_hienTai Then
                    If Ly_do.Trim = "" Then
                        Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
                    Else
                        Ly_do += ", Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
                    End If
                End If

                dt.Rows(i).Item("Chon") = False
                dt.Rows(i).Item("Ly_do") = Ly_do
            Next

            dt.DefaultView.RowFilter = "Ly_do<>''"
            Return dt
        End Function

        Function XetLenLop_Load2nganh(ByVal ID_dv As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_nganh As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.HienThi_ESSDanhSachHocTiep2Nganh_DanhSach(ID_nganh)
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Xep_loai1", GetType(String))
            dt.Columns.Add("Xep_loai2", GetType(String))
            dt.Columns.Add("TBCHT1", GetType(Double))
            dt.Columns.Add("TBCHT2", GetType(Double))
            dt.Columns.Add("So_ky", GetType(String))

            Dim clsDiem As Diem_Bussines
            Dim Ly_do As String = ""
            For i As Integer = 0 To dt.Rows.Count - 1
                Ly_do = ""
                'Check Nganh chinh TBCHT<2
                clsDiem = New Diem_Bussines(ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt1"))
                Dim dt_diemNganh As DataTable = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
                If dt_diemNganh.Rows.Count > 0 Then
                    dt.Rows(i).Item("TBCHT1") = IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, Math.Round(dt_diemNganh.Rows(0)("TBC_tich_luy"), 2))
                    dt.Rows(i).Item("Xep_loai1") = dt_diemNganh.Rows(0)("Xep_hang_hoc_luc").ToString
                End If
                'Check Nganh hoc thu 2 TBCHT<2
                clsDiem = New Diem_Bussines(ID_dv, dt.Rows(i).Item("ID_SV"), dt.Rows(i).Item("ID_dt2"))
                dt_diemNganh = clsDiem.BangTongKetDiemSinhVien_TheoKyNamToanKhoaTamThoi(dt.Rows(i).Item("ID_SV"), 0, "")
                If dt_diemNganh.Rows.Count > 0 Then
                    dt.Rows(i).Item("TBCHT2") = IIf(IsDBNull(dt_diemNganh.Rows(0)("TBC_tich_luy")), 0, Math.Round(dt_diemNganh.Rows(0)("TBC_tich_luy"), 2))
                    dt.Rows(i).Item("Xep_loai2") = dt_diemNganh.Rows(0)("Xep_hang_hoc_luc").ToString
                End If

                'Check thoi gian hoc nganh nay
                Dim cls As ChuongTrinhDaoTao_Bussines
                cls = New ChuongTrinhDaoTao_Bussines(dt.Rows(i).Item("ID_dt1"))
                Dim So_ky_ToiDa As Integer = cls.Get_SoKyToiDa(dt.Rows(i).Item("ID_dt1"))
                Dim Nam As Integer = CType(Left(Nam_hoc, 4), Integer)
                Dim NienKhoa_Dau As Integer = CType(Left(dt.Rows(i).Item("Nien_khoa"), 4), Integer)
                Dim So_ky_hienTai As Integer = 2 * (Nam - NienKhoa_Dau + 1)
                If Hoc_ky = 1 Then So_ky_hienTai = So_ky_hienTai - 1
                If So_ky_ToiDa < So_ky_hienTai Then
                    If Ly_do.Trim = "" Then
                        Ly_do = "Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
                    Else
                        Ly_do += ", Đã học " & So_ky_hienTai & "/số kỳ tối đa hoàn thành CTĐT là " & So_ky_ToiDa
                    End If
                End If

                dt.Rows(i).Item("Chon") = False
                dt.Rows(i).Item("So_ky") = So_ky_hienTai & "/" & So_ky_ToiDa
            Next

            Return dt
        End Function
        Private Function Mapping(ByVal drDanhSachXetLenLop As DataRow) As ESSDanhSachXetLenLop
            Dim result As ESSDanhSachXetLenLop
            Try
                result = New ESSDanhSachXetLenLop
                If drDanhSachXetLenLop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachXetLenLop("ID_sv").ToString(), Integer)
                result.Ma_sv = drDanhSachXetLenLop("Ma_sv").ToString()
                result.Ho_ten = drDanhSachXetLenLop("Ho_ten").ToString()
                If drDanhSachXetLenLop("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachXetLenLop("Ngay_sinh").ToString(), Date)
                result.Ten_khoa = drDanhSachXetLenLop("Ten_khoa").ToString
                If drDanhSachXetLenLop("ID_qd").ToString() <> "" Then result.ID_qd = CType(drDanhSachXetLenLop("ID_qd").ToString(), Integer)
                If drDanhSachXetLenLop("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachXetLenLop("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhSachXetLenLop("Nam_hoc").ToString()
                result.So_qd = drDanhSachXetLenLop("So_qd").ToString()
                If drDanhSachXetLenLop("Ngay_qd").ToString() <> "" Then result.Ngay_qd = CType(drDanhSachXetLenLop("Ngay_qd").ToString(), Date)
                If drDanhSachXetLenLop("Loai_qd").ToString() <> "" Then result.Loai_qd = CType(drDanhSachXetLenLop("Loai_qd").ToString(), Integer)
                result.Ly_do = drDanhSachXetLenLop("Ly_do").ToString()
                If drDanhSachXetLenLop("ID_lop_cu").ToString() <> "" Then result.ID_lop_cu = CType(drDanhSachXetLenLop("ID_lop_cu").ToString(), Integer)
                If drDanhSachXetLenLop("ID_lop_moi").ToString() <> "" Then result.ID_lop_moi = CType(drDanhSachXetLenLop("ID_lop_moi").ToString(), Integer)
                result.Ten_lop = drDanhSachXetLenLop("Ten_lop").ToString()
                result.Lop_moi = drDanhSachXetLenLop("Lop_moi").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function Mapping_Nganh2(ByVal drDanhSachXetLenLop As DataRow) As ESSDanhSachXetLenLop
            Dim result As ESSDanhSachXetLenLop
            Try
                result = New ESSDanhSachXetLenLop
                If drDanhSachXetLenLop("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachXetLenLop("ID_sv").ToString(), Integer)
                result.Ma_sv = drDanhSachXetLenLop("Ma_sv").ToString()
                result.Ho_ten = drDanhSachXetLenLop("Ho_ten").ToString()
                If drDanhSachXetLenLop("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drDanhSachXetLenLop("Ngay_sinh").ToString(), Date)
                If drDanhSachXetLenLop("ID_dt1").ToString() <> "" Then result.ID_dt1 = CType(drDanhSachXetLenLop("ID_dt1").ToString(), Integer)
                If drDanhSachXetLenLop("ID_dt2").ToString() <> "" Then result.ID_dt2 = CType(drDanhSachXetLenLop("ID_dt2").ToString(), Integer)
                result.Nien_khoa = drDanhSachXetLenLop("Nien_khoa").ToString()
                result.Ly_do = drDanhSachXetLenLop("Ly_do").ToString()
                result.Ten_lop = drDanhSachXetLenLop("Ten_lop").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region

        'XET LEN LOP THEO CANH BAO LAN 1
        Function strID_SV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal ID_lops As String) As String
            Dim Dieu_kien As String = ""
            If Lan_canh_bao > 0 Then
                '------Loc theo lan canh bao-----------
                Dim Nam_Dau As Integer = CType(Left(Nam_hoc, 4), Integer)
                Dim Nam_Cuoi As Integer = CType(Right(Nam_hoc, 4), Integer)
                Dim mHoc_ky_truoc As Integer = 0

                If Hoc_ky = 2 Then mHoc_ky_truoc = 1
                If Hoc_ky = 1 Then
                    mHoc_ky_truoc = 2
                    Nam_Dau = Nam_Dau - 1
                    Nam_Cuoi = Nam_Cuoi - 1
                End If
                'Neu Lan canh bao la 1 thi loai sinh vien da bi canh bao lan 1 o ky truoc
                If Lan_canh_bao = 1 Then
                    Dieu_kien = "SELECT ID_SV FROM STU_HoSoSinhVien WHERE ID_SV IN " & _
                                       " (SELECT a.ID_SV FROM MARK_XetLenLop a " & _
                                     "INNER JOIN STU_DanhSach b ON a.ID_SV=b.ID_SV " & _
                                     "INNER JOIN STU_Lop c ON b.ID_lop=c.ID_lop " & _
                                     "Where Hoc_ky=" & Hoc_ky & " AND Nam_hoc='" & Nam_hoc & "' AND Lan_canh_bao=1 AND Duyet=1) "
                    Dieu_kien = Dieu_kien & " OR ID_SV in (SELECT a.ID_SV FROM Mark_XetLenLop a " & _
                    "INNER JOIN STU_DanhSach b ON a.ID_SV=b.ID_SV " & _
                    "INNER JOIN STU_Lop c ON b.ID_lop=c.ID_lop " & _
                    "Where Hoc_ky=" & mHoc_ky_truoc & " AND Nam_hoc='" & Nam_Dau & "-" & Nam_Cuoi & "' AND Lan_canh_bao=1 AND Duyet=1) "

                Else
                    Dieu_kien = " AND STU_DanhSach.ID_sv in (SELECT ID_sv FROM Mark_XetLenLop " & _
                                      "Where Hoc_ky=" & mHoc_ky_truoc & " AND Nam_hoc='" & Nam_Dau & "-" & Nam_Cuoi & "' AND Lan_canh_bao=1 AND Duyet=1)"
                    Dieu_kien = Dieu_kien & " AND STU_DanhSach.ID_sv not in " & _
                                                           " (SELECT ID_SV FROM Mark_XetLenLop " & _
                                                         "Where Hoc_ky=" & Hoc_ky & " AND Nam_hoc='" & Nam_hoc & "' AND Lan_canh_bao=1 AND Duyet=1) "
                End If
                'Neu Lan canh bao la 2 thi loai sinh vien da bi canh bao lan 1 o ky nay
                '----------------------------------------
            End If
            Return Dieu_kien
        End Function
        Function Load_DanhSachSinhVien_ID_SVs_HenThi_DanhSAch(ByVal ID_lops As String, ByVal ID_svs As String) As DataTable
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                Return obj.Load_DanhSachSinhVien_ID_SVs_HenThi_DanhSAch(ID_lops, ID_svs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function XetLenLop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Bomon As Integer, ByVal Lan_canh_bao As Integer, ByVal QuyCheMoi As Boolean) As DataTable
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            Dim dtDiem As DataTable

            dtDiem = clsDiem.XetLenLop(Hoc_ky, Nam_hoc)

            Return dtDiem
        End Function

        Function XetLenLop_SauCanhBao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_Bomon As Integer, ByVal Lan_canh_bao As Integer, ByVal mdsID_lop As String) As DataTable
            Dim clsDiem As Diem_Bussines
            clsDiem = New Diem_Bussines(mID_dv, ID_Bomon, 0, "", mdsID_lop, mID_dt, mdtDanhSachSinhVien)
            Dim dtDiem As DataTable = clsDiem.XetLenLop_ThoiHoc(Hoc_ky, Nam_hoc, Lan_canh_bao, mdsID_lop)
            Return dtDiem
        End Function

        Function DanhSachDaXet_LanCanhBao(ByVal dsID_lop As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Duyet As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.DanhSachDaXet_LanCanhBao_Duyet(ID_he, Khoa_hoc, ID_chuyen_nganh, dsID_lop, Hoc_ky, Nam_hoc, Duyet)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function

        Function DanhSachDaXet_TongHop(ByVal dsID_lop As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal Duyet As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.DanhSachDaXet_TongHop(ID_he, Khoa_hoc, ID_chuyen_nganh, dsID_lop, Hoc_ky, Nam_hoc, Lan_canh_bao, Duyet)
            dt.Columns.Add("Chon", GetType(Boolean))
            For i As Integer = 0 To dt.Rows.Count - 1
                dt.Rows(i)("Chon") = False
            Next
            Return dt
        End Function


        Public Sub Insert_XetLenLop_KhiTongHop(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer, ByVal Ly_do As String, ByVal So_TCTL As Double, ByVal TBCTL As Double, ByVal So_TCHT As Double, ByVal TBCHT_ky As Double, ByVal Duyet As Integer, ByVal XepHang_Nam_DaoTao As Integer, ByVal Ly_do_cac_ky As String)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                obj.Insert_XetLenLop_KhiTongHop(ID_sv, Hoc_ky, Nam_hoc, Lan_canh_bao, Ly_do, So_TCTL, TBCTL, So_TCHT, TBCHT_ky, 1, XepHang_Nam_DaoTao, Ly_do_cac_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Update_XetLenLop_KhiDuyet(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                obj.Update_XetLenLop_KhiDuyet(ID_sv, Hoc_ky, Nam_hoc, Lan_canh_bao)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub Delete_XetLenLop_DaDuyet(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                obj.Delete_XetLenLop_DaDuyet(ID_sv, Hoc_ky, Nam_hoc, Lan_canh_bao)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Delete_XetLenLop_KhiTongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Lan_canh_bao As Integer)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                obj.Delete_XetLenLop_KhiTongHop(Hoc_ky, Nam_hoc, Lan_canh_bao)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        '----------------------------------------------------
        Function DanhSachDaXet_LanCanhBao_Duyet(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal ID_lops As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Duyet As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Return obj.DanhSachDaXet_LanCanhBao_Duyet(ID_he, Khoa_hoc, ID_chuyen_nganh, ID_lops, Hoc_ky, Nam_hoc, Duyet)
        End Function

        Function DanhSach_DaXetThoiHoc(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Return obj.DanhSach_DaXetThoiHoc(ID_he, Khoa_hoc, ID_chuyen_nganh)
        End Function

        Function DanhSach_CacLanCanhBao_SinhVien(ByVal ID_SV As Integer, ByVal Nam_hoc As String) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Return obj.DanhSach_CacLanCanhBao_TheoSinhVien(ID_SV, Nam_hoc)
        End Function

        Public Sub Delete_XetLenLop_KhiTongHop_TheoSinhVien(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_lops As String)
            Try
                Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
                obj.Delete_XetLenLop_KhiTongHop_TheoSV(Hoc_ky, Nam_hoc, ID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Function getLan_canh_bao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByRef Ly_do_cu As String) As Integer
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Return obj.getLan_canh_bao(Hoc_ky, Nam_hoc, ID_sv, Ly_do_cu)
        End Function

        Function TongHop_LanCanhBao(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.TongHop_LanCanhBao(Hoc_ky, Nam_hoc, dk)
            Return dt
        End Function

        Function TongHop_LanCanhBao_Khoa(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.TongHop_LanCanhBao_Khoa(Hoc_ky, Nam_hoc, dk)
            Return dt
        End Function

        Function TongHop_LanCanhBao_Lop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Dim obj As DanhSachXetLenLop_DataAccess = New DanhSachXetLenLop_DataAccess
            Dim dt As DataTable = obj.TongHop_LanCanhBao_Lop(Hoc_ky, Nam_hoc, dk)
            Return dt
        End Function
    End Class
End Namespace
