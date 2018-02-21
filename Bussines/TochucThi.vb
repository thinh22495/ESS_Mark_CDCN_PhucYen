'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, June 06, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class TochucThi_Bussines
        Private arrTochucThi As New ArrayList
        Private dsMonHoc As New ESSChuongTrinhDaoTaoChiTiet

#Region "Initialize"
        Sub New()

        End Sub
        Sub New(ByVal ID_thi As Integer, Optional ByVal isNangDiem As Boolean = False)
            Dim clsTCThi As New TochucThi_DataAccess
            Dim dtThi As DataTable = clsTCThi.HienThi_ESSTochucThi(ID_thi)
            If dtThi.Rows.Count > 0 Then
                'Add các lần tổ chức thi
                Dim objTCThi As New ESSTochucThi
                objTCThi = MappingToTocChucThi(dtThi.Rows(0))
                'Add phòng thi của lần tổ chức thi
                Dim dtPhong As DataTable = clsTCThi.HienThi_ESSDanhsachPhongThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtPhong.Rows.Count - 1
                    Dim objPhongThi As New ESSToChucThiPhong
                    objPhongThi = MappingToTocChucThiPhongThi(dtPhong.Rows(j))
                    objTCThi.dsPhongThi.Add(objPhongThi)
                Next
                'Add danh sách sinh viên của lần tổ chức thi
                Dim dtSinhVien As DataTable
                If isNangDiem Then
                    dtSinhVien = clsTCThi.HienThi_ESSDanhsachSinhVien_NangDiem(objTCThi.ID_thi)
                Else
                    dtSinhVien = clsTCThi.HienThi_ESSDanhsachSinhVien(objTCThi.ID_thi)
                End If

                For j As Integer = 0 To dtSinhVien.Rows.Count - 1
                    Dim obj As New ESSTochucThiChiTiet
                    obj = MappingToTocChucThiChiTiet(dtSinhVien.Rows(j))
                    objTCThi.dsChiTietSinhVien.Add(obj)
                Next
                arrTochucThi.Add(objTCThi)
                ' Add danh sách sinh viên phúc khảo của lần tổ chức thi
                Dim dtPhucKhao As DataTable = clsTCThi.HienThi_ESSToChucThiPhucKhao_DanhSach(objTCThi.ID_thi)
                For j As Integer = 0 To dtPhucKhao.Rows.Count - 1
                    Dim objPK As New ESSToChucThiPhucKhao
                    objPK = MappingToChucThiPhucKhao(dtPhucKhao.Rows(j))
                    objTCThi.dsPhucKhao.Add(objPK)
                Next
            End If
        End Sub
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, Optional ByVal ID_bm_chinh As Integer = 0, Optional ByVal ID_Khoa As Integer = 0)
            Dim clsTCThi As New TochucThi_DataAccess
            Dim dtThi As DataTable = clsTCThi.HienThi_ESSDanhsachTochucThi(Hoc_ky, Nam_hoc, ID_bm_chinh, ID_Khoa)
            For i As Integer = 0 To dtThi.Rows.Count - 1
                If dtThi.Rows(i)("ID_mon") = 978 And dtThi.Rows(i)("Lan_thi") = 2 Then
                    dtThi.Rows(i)("ID_mon") = 978
                End If
                'Add các lần tổ chức thi
                Dim objTCThi As New ESSTochucThi
                objTCThi = MappingToTocChucThi(dtThi.Rows(i))
                'Add phòng thi của lần tổ chức thi
                Dim dtPhong As DataTable = clsTCThi.HienThi_ESSDanhsachPhongThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtPhong.Rows.Count - 1
                    Dim objPhongThi As New ESSToChucThiPhong
                    objPhongThi = MappingToTocChucThiPhongThi(dtPhong.Rows(j))
                    objTCThi.dsPhongThi.Add(objPhongThi)
                Next
                Dim dtTuiThi As DataTable = clsTCThi.HienThi_ESSDanhsachTuiThi(objTCThi.ID_thi)
                For j As Integer = 0 To dtTuiThi.Rows.Count - 1
                    Dim objTuiThi As New ESSToChucThiDongTui
                    objTuiThi = MappingToTocChucThiDongTui(dtTuiThi.Rows(j))
                    objTCThi.dsTuiThi.Add(objTuiThi)
                Next
                arrTochucThi.Add(objTCThi)
            Next
        End Sub
#End Region
#Region "Functions And Subs"

        Public Sub Update(ByVal ID_thi As Integer, ByVal Ca_thi As Integer, ByVal Ngay_thi As String, ByVal Nhom_tiet As Integer, ByVal Gio_thi As String)
            Dim midx As Integer = Tim_idx(ID_thi)
            If midx <= 0 Then midx = 0

            CType(arrTochucThi(midx), ESSTochucThi).Ca_thi = Ca_thi
            CType(arrTochucThi(midx), ESSTochucThi).Ngay_thi = Ngay_thi
            CType(arrTochucThi(midx), ESSTochucThi).Nhom_tiet = Nhom_tiet
            CType(arrTochucThi(midx), ESSTochucThi).Gio_thi = Gio_thi
        End Sub
        Public Sub Add(ByVal TCThi As ESSTochucThi)
            arrTochucThi.Add(TCThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrTochucThi.RemoveAt(idx)
        End Sub
        Public Function DanhSachMonDaToChucThi() As DataTable
            Dim dtThi As New DataTable
            dtThi.Columns.Add("ID_thi", GetType(Integer))
            dtThi.Columns.Add("ID_mon", GetType(Integer))
            dtThi.Columns.Add("Ky_hieu", GetType(String))
            dtThi.Columns.Add("Ten_mon", GetType(String))
            dtThi.Columns.Add("Lan_thi", GetType(Integer))
            dtThi.Columns.Add("Dot_thi", GetType(Integer))
            dtThi.Columns.Add("Ngay_thi", GetType(Date))
            dtThi.Columns.Add("Ca_thi", GetType(String))
            dtThi.Columns.Add("Nhom_tiet", GetType(String))
            dtThi.Columns.Add("Gio_thi", GetType(String))
            For i As Integer = 0 To arrTochucThi.Count - 1
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(i), ESSTochucThi)
                Dim dr As DataRow
                dr = dtThi.NewRow
                dr("ID_thi") = objTCThi.ID_thi
                dr("ID_mon") = objTCThi.ID_mon
                dr("Ky_hieu") = objTCThi.Ky_hieu
                dr("Ten_mon") = objTCThi.Ten_mon
                dr("Lan_thi") = objTCThi.Lan_thi
                dr("Dot_thi") = objTCThi.Dot_thi
                dr("Ngay_thi") = objTCThi.Ngay_thi.ToShortDateString
                If objTCThi.Ca_thi = 0 Then
                    dr("Ca_thi") = "Ca Sáng"
                ElseIf objTCThi.Ca_thi = 1 Then
                    dr("Ca_thi") = "Ca Chiều"
                Else
                    dr("Ca_thi") = "Ca Tối"
                End If
                dr("Nhom_tiet") = objTCThi.Nhom_tiet + 1
                dr("Gio_thi") = objTCThi.Gio_thi
                dtThi.Rows.Add(dr)
            Next
            Return dtThi
        End Function
        Public Function DanhSachPhongThiTheoMonThi(ByVal ID_thi As Integer) As DataTable
            Dim dtPhongThi As New DataTable
            dtPhongThi.Columns.Add("ID_phong_thi", GetType(Integer))
            dtPhongThi.Columns.Add("Ten_phong", GetType(String))
            dtPhongThi.Columns.Add("So_sv", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                    Dim dr As DataRow
                    dr = dtPhongThi.NewRow
                    With objTCThi.dsPhongThi.ESSToChucThiPhong(i)
                        dr("ID_phong_thi") = .ID_phong_thi
                        dr("Ten_phong") = .Ten_phong
                        dr("So_sv") = .So_sv
                    End With
                    dtPhongThi.Rows.Add(dr)
                Next
            End If
            dtPhongThi.AcceptChanges()
            Return dtPhongThi
        End Function
        Public Function DanhSachMonToChucThi() As DataTable
            Dim dtThi As New DataTable
            dtThi.Columns.Add("ID_thi", GetType(Integer))
            dtThi.Columns.Add("ID_he", GetType(Integer))
            dtThi.Columns.Add("Ten_he", GetType(String))
            dtThi.Columns.Add("ID_khoa", GetType(Integer))
            dtThi.Columns.Add("Ten_khoa", GetType(String))
            dtThi.Columns.Add("ID_mon", GetType(Integer))
            dtThi.Columns.Add("Ten_mon", GetType(String))
            dtThi.Columns.Add("Ky_hieu", GetType(String))
            dtThi.Columns.Add("Lan_thi", GetType(Integer))
            dtThi.Columns.Add("Dot_thi", GetType(Integer))
            dtThi.Columns.Add("Ngay_thi", GetType(Date))
            dtThi.Columns.Add("ID_phong_thi", GetType(Integer))
            dtThi.Columns.Add("Ten_phong", GetType(String))
            dtThi.Columns.Add("Ca_thi", GetType(String))
            dtThi.Columns.Add("Tui_so", GetType(Integer))
            dtThi.Columns.Add("Nhom_tiet", GetType(String))
            dtThi.Columns.Add("Gio_thi", GetType(String))

            dtThi.Columns.Add("Nhom_tiet_Phong", GetType(String))
            dtThi.Columns.Add("Ngay_thi_phong", GetType(Date))
            dtThi.Columns.Add("Ca_thi_Phong", GetType(String))
            dtThi.Columns.Add("Gio_thi_Phong", GetType(String))

            For i As Integer = 0 To arrTochucThi.Count - 1
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(i), ESSTochucThi)
                For j As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                    Dim dr As DataRow
                    dr = dtThi.NewRow
                    dr("ID_thi") = objTCThi.ID_thi
                    dr("ID_he") = objTCThi.ID_he
                    dr("Ten_he") = objTCThi.Ten_he
                    dr("ID_khoa") = objTCThi.ID_khoa
                    dr("Ten_khoa") = objTCThi.Ten_khoa
                    dr("ID_mon") = objTCThi.ID_mon
                    dr("Ten_mon") = objTCThi.Ten_mon
                    dr("Ky_hieu") = objTCThi.Ky_hieu
                    dr("Lan_thi") = objTCThi.Lan_thi
                    dr("Dot_thi") = objTCThi.Dot_thi
                    dr("Ngay_thi") = objTCThi.Ngay_thi
                    dr("Ca_thi") = objTCThi.Ca_thi
                    dr("Tui_so") = objTCThi.dsChiTietSinhVien.Tui_so
                    dr("Nhom_tiet") = objTCThi.Nhom_tiet
                    dr("Gio_thi") = objTCThi.Gio_thi
                    dr("ID_phong_thi") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).ID_phong_thi
                    dr("Ten_phong") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).Ten_phong

                    dr("Nhom_tiet_phong") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).Nhom_tiet_phong
                    dr("Ca_thi_Phong") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).Ca_thi_Phong
                    dr("Ngay_thi_Phong") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).Ngay_thi_Phong
                    dr("Gio_thi_Phong") = objTCThi.dsPhongThi.ESSToChucThiPhong(j).Gio_thi_Phong
                    dtThi.Rows.Add(dr)
                Next
            Next
            Return dtThi
        End Function

        Public Function DanhSachMonToChucThi_TheoTui() As DataTable
            Dim dtThi As New DataTable
            dtThi.Columns.Add("ID_thi", GetType(Integer))
            dtThi.Columns.Add("ID_he", GetType(Integer))
            dtThi.Columns.Add("Ten_he", GetType(String))
            dtThi.Columns.Add("ID_khoa", GetType(Integer))
            dtThi.Columns.Add("Ten_khoa", GetType(String))
            dtThi.Columns.Add("ID_mon", GetType(Integer))
            dtThi.Columns.Add("Ten_mon", GetType(String))
            dtThi.Columns.Add("Lan_thi", GetType(Integer))
            dtThi.Columns.Add("Dot_thi", GetType(Integer))
            dtThi.Columns.Add("Ngay_thi", GetType(Date))
            dtThi.Columns.Add("Ca_thi", GetType(String))
            dtThi.Columns.Add("Tui_so", GetType(Integer))
            dtThi.Columns.Add("Nhom_tiet", GetType(String))
            For i As Integer = 0 To arrTochucThi.Count - 1
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(i), ESSTochucThi)
                For j As Integer = 0 To objTCThi.dsTuiThi.Count - 1
                    Dim dr As DataRow
                    dr = dtThi.NewRow
                    dr("ID_thi") = objTCThi.ID_thi
                    dr("ID_he") = objTCThi.ID_he
                    dr("Ten_he") = objTCThi.Ten_he
                    dr("ID_khoa") = objTCThi.ID_khoa
                    dr("Ten_khoa") = objTCThi.Ten_khoa
                    dr("ID_mon") = objTCThi.ID_mon
                    dr("Ten_mon") = objTCThi.Ten_mon
                    dr("Lan_thi") = objTCThi.Lan_thi
                    dr("Dot_thi") = objTCThi.Dot_thi
                    dr("Ngay_thi") = objTCThi.Ngay_thi
                    dr("Ca_thi") = objTCThi.Ca_thi
                    dr("Tui_so") = objTCThi.dsTuiThi.TochucThiTui(j).Tui_so
                    dr("Nhom_tiet") = objTCThi.Nhom_tiet
                    dtThi.Rows.Add(dr)
                Next
            Next
            Return dtThi
        End Function
        Function DanhSachKDDK_DuThi(ByVal ID_thi As Integer) As DataTable
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            Dim dt_KhongThi As DataTable
            If idx_thi >= 0 Then
                'Loai nhung sinh vien khong du dieu kien du thi
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                Dim clsTCThi As New TochucThi_DataAccess
                dt_KhongThi = clsTCThi.HienThi_ESSSinhVien_KDDKDuThi(objTCThi.ID_mon, objTCThi.Hoc_ky, objTCThi.Nam_hoc)
            End If
            Return dt_KhongThi
        End Function
        Public Function DanhSachSinhVienTheoDotThi(ByVal ID_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten_order", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("ID_khoa", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_nganh", GetType(String))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("Ten_khoa", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                'Loai nhung sinh vien khong du dieu kien du thi
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)

                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    Dim dr As DataRow
                    dr = dtSinhVien.NewRow
                    With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                        dr("Chon") = 0
                        dr("ID_ds_thi") = .ID_ds_thi
                        dr("ID_sv") = .ID_sv
                        dr("ID_dt") = .ID_dt1
                        dr("So_bao_danh") = .So_bao_danh
                        dr("So_phach") = .So_phach
                        dr("Ma_sv") = .Ma_sv
                        dr("Ho_ten") = .Ho_ten
                        dr("Ho_ten_order") = .Ho_ten_order
                        If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                        dr("ID_lop") = .ID_lop
                        dr("ID_khoa") = .ID_khoa
                        dr("Ten_khoa") = .Ten_khoa
                        dr("Ma_nganh") = .Ma_nganh
                        dr("Ten_lop") = .Ten_lop
                        dr("Ten_phong") = .Ten_phong
                        dr("Ngoai_ngu") = .Ngoai_ngu
                        dr("Ghi_chu_thi") = .Ghi_chu_thi
                        dr("OrderBy") = .OrderBy
                    End With
                    dtSinhVien.Rows.Add(dr)
                Next
            End If
            dtSinhVien.DefaultView.Sort = "OrderBy"
            Return dtSinhVien
        End Function

        Public Function DanhSachSBDSoPhachTheoPhongThi(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                            dr("Ten_phong") = .Ten_phong
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienTheoTuiThi_HuongDan(ByVal ID_thi As Integer, ByVal Tui_so As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = Tui_so Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Tui_so") = .Tui_so
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                            dr("ID_lop") = .ID_lop
                            dr("Ten_lop") = .Ten_lop
                            dr("Ten_phong") = .Ten_phong
                            dr("Ngoai_ngu") = .Ngoai_ngu
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "Ten_phong,So_bao_danh"
            Return dtSinhVien
        End Function

        'Public Function DanhSachSinhVienTheoTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer) As DataTable
        '    Dim dtSinhVien As New DataTable
        '    dtSinhVien.Columns.Add("Chon", GetType(Boolean))
        '    dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
        '    dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
        '    dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
        '    dtSinhVien.Columns.Add("So_phach", GetType(Integer))
        '    dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
        '    dtSinhVien.Columns.Add("Ma_sv", GetType(String))
        '    dtSinhVien.Columns.Add("Ho_ten", GetType(String))
        '    dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
        '    dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
        '    dtSinhVien.Columns.Add("Ten_lop", GetType(String))
        '    dtSinhVien.Columns.Add("Ten_phong", GetType(String))
        '    dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
        '    dtSinhVien.Columns.Add("OrderBy", GetType(String))
        '    Dim idx_thi As Integer = 0
        '    idx_thi = Tim_idx(ID_thi)
        '    If idx_thi >= 0 Then
        '        Dim objTCThi As New ESSTochucThi
        '        objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
        '        For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
        '            If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = Tui_so Then
        '                Dim dr As DataRow
        '                dr = dtSinhVien.NewRow
        '                With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
        '                    dr("Chon") = 0
        '                    dr("ID_sv") = .ID_sv
        '                    dr("ID_dt") = .ID_dt1
        '                    dr("So_bao_danh") = .So_bao_danh
        '                    dr("So_phach") = .So_phach
        '                    dr("Tui_so") = .Tui_so
        '                    dr("Ma_sv") = .Ma_sv
        '                    dr("Ho_ten") = .Ho_ten
        '                    dr("Ngay_sinh") = .Ngay_sinh
        '                    dr("ID_lop") = .ID_lop
        '                    dr("Ten_lop") = .Ten_lop
        '                    dr("Ten_phong") = .Ten_phong
        '                    dr("Ghi_chu_thi") = .Ghi_chu_thi
        '                    dr("OrderBy") = .OrderBy
        '                End With
        '                dtSinhVien.Rows.Add(dr)
        '            End If
        '        Next
        '    End If
        '    dtSinhVien.DefaultView.Sort = "Ten_phong,So_bao_danh"
        '    Return dtSinhVien
        'End Function
        Public Function DanhSachSinhVienChuaDongTui(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                If ID_phong_thi > 0 Then
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = 0 _
                            And objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                            Dim dr As DataRow
                            dr = dtSinhVien.NewRow
                            With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                                dr("Chon") = 0
                                dr("ID_ds_thi") = .ID_ds_thi
                                dr("ID_sv") = .ID_sv
                                dr("ID_dt") = .ID_dt1
                                dr("So_bao_danh") = .So_bao_danh
                                dr("So_phach") = .So_phach
                                dr("Tui_so") = .Tui_so
                                dr("Ma_sv") = .Ma_sv
                                dr("Ho_ten") = .Ho_ten
                                If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                                dr("ID_lop") = .ID_lop
                                dr("Ten_lop") = .Ten_lop
                                dr("ID_phong_thi") = .ID_phong_thi
                                dr("Ten_phong") = .Ten_phong
                                dr("Ngoai_ngu") = .Ngoai_ngu
                                dr("Ghi_chu_thi") = .Ghi_chu_thi
                                dr("OrderBy") = .OrderBy
                            End With
                            dtSinhVien.Rows.Add(dr)
                        End If
                    Next
                Else
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = 0 Then
                            Dim dr As DataRow
                            dr = dtSinhVien.NewRow
                            With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                                dr("Chon") = 0
                                dr("ID_ds_thi") = .ID_ds_thi
                                dr("ID_sv") = .ID_sv
                                dr("ID_dt") = .ID_dt1
                                dr("So_bao_danh") = .So_bao_danh
                                dr("So_phach") = .So_phach
                                dr("Tui_so") = .Tui_so
                                dr("Ma_sv") = .Ma_sv
                                dr("Ho_ten") = .Ho_ten
                                If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                                dr("ID_lop") = .ID_lop
                                dr("Ten_lop") = .Ten_lop
                                dr("ID_phong_thi") = .ID_phong_thi
                                dr("Ten_phong") = .Ten_phong
                                dr("Ghi_chu_thi") = .Ghi_chu_thi
                                dr("OrderBy") = .OrderBy
                            End With
                            dtSinhVien.Rows.Add(dr)
                        End If
                    Next
                End If
            End If
            dtSinhVien.DefaultView.Sort = "OrderBy"
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienDongTuiThi(ByVal ID_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    Dim dr As DataRow
                    dr = dtSinhVien.NewRow
                    With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                        dr("Chon") = 0
                        dr("ID_ds_thi") = .ID_ds_thi
                        dr("ID_sv") = .ID_sv
                        dr("ID_dt") = .ID_dt1
                        dr("So_bao_danh") = .So_bao_danh
                        dr("So_phach") = .So_phach
                        dr("Tui_so") = .Tui_so
                        dr("Ma_sv") = .Ma_sv
                        dr("Ho_ten") = .Ho_ten
                        If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                        dr("ID_lop") = .ID_lop
                        dr("Ten_lop") = .Ten_lop
                        dr("ID_phong_thi") = .ID_phong_thi
                        dr("Ten_phong") = .Ten_phong
                        dr("Ngoai_ngu") = .Ngoai_ngu
                        dr("Ghi_chu_thi") = .Ghi_chu_thi
                        dr("OrderBy") = .OrderBy
                    End With
                    dtSinhVien.Rows.Add(dr)
                Next
            End If
            dtSinhVien.DefaultView.Sort = "OrderBy"
            Return dtSinhVien
        End Function
        Public Function DanhSachSinhVienTheoPhongThi(ByVal ID_thi As Integer, ByVal ID_phong_thi As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("ID_khoa", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("Ma_nganh", GetType(String))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("Ten_khoa", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_phong_thi = ID_phong_thi Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_sv") = .ID_sv
                            dr("ID_ds_thi") = .ID_ds_thi
                            dr("ID_dt") = .ID_dt1
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                            dr("ID_lop") = .ID_lop
                            dr("ID_khoa") = .ID_khoa
                            dr("Ten_khoa") = .Ten_khoa
                            dr("Ten_lop") = .Ten_lop
                            dr("Ma_nganh") = .Ma_nganh
                            dr("Ten_phong") = .Ten_phong
                            dr("Ngoai_ngu") = .Ngoai_ngu
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "So_bao_danh,OrderBy"
            Return dtSinhVien
        End Function

        Public Function CheckTrungSBDSinhVienTheoPhongThi(ByVal So_bao_danh As String, ByVal ID_ds_thi As Integer, ByVal ID_thi As Integer) As Integer
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_ds_thi <> ID_ds_thi AndAlso objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).So_bao_danh = So_bao_danh Then
                        Return 1
                    End If
                Next
            End If
            Return 0
        End Function
        Public Function DanhSachSinhVienTheoTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer) As DataTable
            Dim dtSinhVien As New DataTable
            dtSinhVien.Columns.Add("Chon", GetType(Boolean))
            dtSinhVien.Columns.Add("ID_ds_thi", GetType(Integer))
            dtSinhVien.Columns.Add("ID_sv", GetType(Integer))
            dtSinhVien.Columns.Add("ID_dt", GetType(Integer))
            dtSinhVien.Columns.Add("So_bao_danh", GetType(String))
            dtSinhVien.Columns.Add("So_phach", GetType(Integer))
            dtSinhVien.Columns.Add("Ma_sv", GetType(String))
            dtSinhVien.Columns.Add("Ho_ten", GetType(String))
            dtSinhVien.Columns.Add("Ngay_sinh", GetType(Date))
            dtSinhVien.Columns.Add("ID_lop", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_lop", GetType(String))
            dtSinhVien.Columns.Add("ID_phong_thi", GetType(Integer))
            dtSinhVien.Columns.Add("Ten_phong", GetType(String))
            dtSinhVien.Columns.Add("Tui_so", GetType(Integer))
            dtSinhVien.Columns.Add("Ngoai_ngu", GetType(String))
            dtSinhVien.Columns.Add("Ghi_chu_thi", GetType(String))
            dtSinhVien.Columns.Add("OrderBy", GetType(String))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = Tui_so Then
                        Dim dr As DataRow
                        dr = dtSinhVien.NewRow
                        With objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i)
                            dr("Chon") = 0
                            dr("ID_ds_thi") = .ID_ds_thi
                            dr("ID_sv") = .ID_sv
                            dr("ID_dt") = .ID_dt1
                            dr("So_bao_danh") = .So_bao_danh
                            dr("So_phach") = .So_phach
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            If .Ngay_sinh.ToString <> "" Then dr("Ngay_sinh") = .Ngay_sinh
                            dr("ID_lop") = .ID_lop
                            dr("Tui_so") = .Tui_so
                            dr("Ten_lop") = .ID_lop
                            dr("ID_phong_thi") = .ID_phong_thi
                            dr("Ten_phong") = .Ten_phong
                            dr("Ngoai_ngu") = .Ngoai_ngu
                            dr("Ghi_chu_thi") = .Ghi_chu_thi
                            dr("OrderBy") = .OrderBy
                        End With
                        dtSinhVien.Rows.Add(dr)
                    End If
                Next
            End If
            dtSinhVien.DefaultView.Sort = "OrderBy"
            Return dtSinhVien
        End Function
        Public Function DanhSachTuiThi(ByVal ID_thi As Integer) As DataTable
            Dim dtTuiThi As New DataTable
            dtTuiThi.Columns.Add("Tui_so", GetType(Integer))
            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                    dtTuiThi.DefaultView.Sort = "Tui_so"
                    If dtTuiThi.DefaultView.Find(objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so) < 0 Then
                        Dim dr As DataRow
                        dr = dtTuiThi.NewRow
                        dr("Tui_so") = objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so
                        dtTuiThi.Rows.Add(dr)
                    End If
                Next
            End If
            dtTuiThi.AcceptChanges()
            Return dtTuiThi
        End Function
        Public Function DanhSachPhongThi(ByVal ID_thi As Integer) As DataTable
            Dim dtPhongThi As New DataTable
            dtPhongThi.Columns.Add("ID_phong_thi", GetType(Integer))
            dtPhongThi.Columns.Add("ID_thi", GetType(Integer))
            dtPhongThi.Columns.Add("ID_phong", GetType(Integer))
            'dtPhongThi.Columns.Add("ID_lop_tc", GetType(Integer))
            dtPhongThi.Columns.Add("Ten_phong", GetType(String))
            dtPhongThi.Columns.Add("So_sv", GetType(Integer))
            dtPhongThi.Columns.Add("Dot_thi", GetType(Integer))
            dtPhongThi.Columns.Add("Ngay_thi", GetType(String))
            dtPhongThi.Columns.Add("Ca_thi", GetType(String))
            dtPhongThi.Columns.Add("Nhom_tiet", GetType(Integer))
            dtPhongThi.Columns.Add("Gio_thi", GetType(String))
            'dtPhongThi.Columns.Add("Ten_lop_tc", GetType(String))

            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                    Dim dr As DataRow
                    dr = dtPhongThi.NewRow
                    With objTCThi.dsPhongThi.ESSToChucThiPhong(i)
                        dr("ID_phong_thi") = .ID_phong_thi
                        dr("ID_thi") = .ID_thi
                        dr("ID_phong") = .ID_phong
                        dr("Ten_phong") = .Ten_phong
                        dr("So_sv") = .So_sv
                        dr("Gio_thi") = .Gio_thi_Phong
                        dr("Ngay_thi") = .Ngay_thi_Phong
                        dr("Nhom_tiet") = .Nhom_tiet_phong
                        dr("Ca_thi") = .Ca_thi_Phong
                    End With
                    dtPhongThi.Rows.Add(dr)
                Next
            End If
            dtPhongThi.AcceptChanges()
            Return dtPhongThi
        End Function

        Public Function CheckExist_svTochucThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal ID_mon As Integer, ByVal Lan_thi As Integer, ByVal Dot_thi As Integer) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.KiemTra_svTochucThi(Hoc_ky, Nam_hoc, ID_he, ID_khoa, ID_mon, Lan_thi, Dot_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ValidateTrungPhong(ByVal ID_phong As Integer, ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer) As Boolean
            'Danh sách các lần tổ chức thi trong kỳ
            For i As Integer = 0 To Count - 1
                If ToChucThi(i).Ngay_thi.ToShortDateString = Ngay_thi.ToShortDateString _
                    And ToChucThi(i).Ca_thi = Ca_thi _
                    And ToChucThi(i).Nhom_tiet = Nhom_tiet Then
                    'Danh sách các phòng tổ chức thi
                    For j As Integer = 0 To ToChucThi(i).dsPhongThi.Count - 1
                        If ToChucThi(i).dsPhongThi.ESSToChucThiPhong(j).ID_phong = ID_phong Then
                            Return False
                        End If
                    Next
                End If
            Next
            Return True
        End Function
        Public Function CheckTrungLichThi_SinhVien(ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal dsID_lop_tc As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CheckTrungLichThi_SinhVien(Ngay_thi, Ca_thi, Nhom_tiet, dsID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub TaoDanhSachPhongThi(ByVal idx_thi As Integer, ByVal So_sv As Integer, ByVal dt_phong As DataTable)
            Dim objTCThi As New ESSTochucThi
            objTCThi = arrTochucThi(idx_thi)
            For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                objTCThi.dsPhongThi.Remove(0)
            Next
            For i As Integer = 0 To dt_phong.Rows.Count - 1
                If dt_phong.Rows(i).Item("Chon") Then
                    Dim objPhongThi As New ESSToChucThiPhong
                    objPhongThi.ID_phong = dt_phong.Rows(i).Item("ID_phong")
                    objPhongThi.ID_phong_thi = dt_phong.Rows(i).Item("ID_phong_thi")
                    objPhongThi.So_sv = dt_phong.Rows(i).Item("So_sv")
                    objPhongThi.Ten_phong = dt_phong.Rows(i).Item("Ten_phong_main").ToString
                    objTCThi.dsPhongThi.Add(objPhongThi)
                End If
            Next
        End Sub
        'Public Sub TaoDanhSachPhongThi(ByVal idx_thi As Integer, ByVal ID_thi As Integer, ByVal So_sv As Integer, ByVal So_phong_thi As Integer)
        '    Dim objTCThi As New ESSTochucThi
        '    objTCThi = arrTochucThi(idx_thi)
        '    Dim So_sv_phong As Integer = So_sv / So_phong_thi   'Tinh so sinh vien / phong thi
        '    Dim So_du As Integer = So_sv Mod So_phong_thi
        '    If objTCThi.TongSoSVPhongThi < So_sv Or objTCThi.dsPhongThi.Count <> So_phong_thi Then
        '        'Xoá phòng cũ đã tồn tại để tạo lại danh sách phòng mới
        '        'For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
        '        '    'objTCThi.dsPhongThi.ESSTochucThiPhong(i).Remove(i)
        '        '    objTCThi.dsPhongThi.Remove(i)
        '        'Next

        '        Dim iCount As Integer = objTCThi.dsPhongThi.Count
        '        For i As Integer = iCount - 1 To 0 Step -1
        '            objTCThi.dsPhongThi.Remove(i)
        '        Next

        '    End If
        '    If objTCThi.dsPhongThi.Count = 0 Then
        '        'Tạo danh sách phòng thi tương ứng với số phòng thi
        '        For i As Integer = 1 To So_phong_thi
        '            Dim objPhongThi As New ESSTochucThiPhong
        '            If i = So_phong_thi Then
        '                'Cong them so du vao phong thi cuoi cung
        '                objPhongThi.So_sv = So_sv_phong + So_du
        '            Else
        '                objPhongThi.So_sv = So_sv_phong
        '            End If
        '            objPhongThi.Ten_phong = "P" + i.ToString
        '            objTCThi.dsPhongThi.Add(objPhongThi)
        '        Next
        '    End If
        'End Sub

        Private Sub CapNhat_ESSGhiChuThi(ByVal dv1 As DataView)

        End Sub

        Public Sub TocChucThi(ByVal idx_thi As Integer, ByVal Ngay_thi As Date, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Gio_thi As String, ByVal So_phong_thi As Integer, ByVal So_sv As Integer, ByVal OrderBy As Integer, ByVal ID_thi_tmp As Integer, ByVal Edit As Boolean, ByVal dt_phong As DataTable)
            Dim objTCThi As New ESSTochucThi
            objTCThi = arrTochucThi(idx_thi)
            Dim dvSinhVien As DataView = DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
            Dim idx_sv As Integer = 0
            Dim ID_thi As Integer

            'Sắp xếp danh sách sinh viên
            If OrderBy <= 2 Then
                For i As Integer = 0 To dvSinhVien.Table.Rows.Count - 1
                    Select Case OrderBy
                        Case 0  'Theo họ và tên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ho_ten_order").ToString
                        Case 1  'Theo mã sinh viên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                        Case 2  'Theo lớp - mã sinh viên
                            dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ten_lop").ToString + dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                    End Select
                Next
                dvSinhVien.Sort = "OrderBy"
            End If
            'Kiem tra xem da to chuc thi chua?

            ID_thi = ID_thi_tmp
            If ID_thi <= 0 Then
                'Insert to chuc thi
                ID_thi = ThemMoi_ESSTochucThi(objTCThi)
            Else
                'Xoa du lieu da to chuc thi
                Dim ID_phong_this As String = "0"
                For i As Integer = 0 To dt_phong.Rows.Count - 1
                    If dt_phong.Rows(i)("Khong_thay_doi") Then ID_phong_this += "," & dt_phong.Rows(i)("ID_phong_thi")
                Next
                Xoa_ESSToChucThiTheoPhong(ID_thi, ID_phong_this)
                Xoa_ESSTochucThiChiTiet(ID_thi)

                Dim midx As Integer = Tim_idx(ID_thi)
                If midx >= 0 AndAlso Edit Then
                    CapNhat_ESSTochucThi(objTCThi, ID_thi)
                End If
            End If
            'Tạo danh sách phòng thi tương ứng với số phòng thi
            TaoDanhSachPhongThi(idx_thi, So_sv, dt_phong)
            'Duyệt danh sách phong thi
            For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                'Insert phong thi
                If idx_sv <= dvSinhVien.Count - 1 Then
                    Dim ID_phong_thi As Integer = objTCThi.dsPhongThi.ESSToChucThiPhong(i).ID_phong_thi
                    If ID_phong_thi <> 0 Then
                        For k As Integer = 0 To dt_phong.Rows.Count - 1
                            If dt_phong.Rows(k)("ID_phong_thi") = ID_phong_thi AndAlso dt_phong.Rows(k)("Khong_thay_doi") = False Then
                                For j As Integer = 1 To objTCThi.dsPhongThi.ESSToChucThiPhong(i).So_sv
                                    If idx_sv <= dvSinhVien.Count - 1 Then
                                        'Insert sinh vien
                                        Dim objTCThiChiTiet As New ESSTochucThiChiTiet
                                        objTCThiChiTiet.ID_sv = dvSinhVien.Item(idx_sv)("ID_sv")
                                        objTCThiChiTiet.So_bao_danh = dvSinhVien.Item(idx_sv)("So_bao_danh").ToString
                                        objTCThiChiTiet.OrderBy = dvSinhVien.Item(idx_sv)("OrderBy").ToString
                                        objTCThiChiTiet.ID_thi = ID_thi
                                        objTCThiChiTiet.ID_phong_thi = ID_phong_thi
                                        objTCThiChiTiet.Ghi_chu_thi = dvSinhVien.Item(idx_sv)("Ghi_chu_thi").ToString
                                        ThemMoi_ESSTochucThiChiTiet(objTCThiChiTiet)
                                        idx_sv += 1
                                    Else
                                        Exit Sub
                                    End If
                                Next
                            End If
                        Next
                    Else
                        objTCThi.dsPhongThi.ESSToChucThiPhong(i).Nhom_tiet_phong = Nhom_tiet
                        objTCThi.dsPhongThi.ESSToChucThiPhong(i).Ca_thi_Phong = Ca_thi
                        objTCThi.dsPhongThi.ESSToChucThiPhong(i).Ngay_thi_Phong = Ngay_thi
                        objTCThi.dsPhongThi.ESSToChucThiPhong(i).Gio_thi_Phong = Gio_thi
                        ID_phong_thi = ThemMoi_ESSToChucThiPhong_(objTCThi.dsPhongThi.ESSToChucThiPhong(i))
                        'Duyệt số sinh viên của phòng thi
                        For j As Integer = 1 To objTCThi.dsPhongThi.ESSToChucThiPhong(i).So_sv
                            If idx_sv <= dvSinhVien.Count - 1 Then
                                'Insert sinh vien
                                Dim objTCThiChiTiet As New ESSTochucThiChiTiet
                                objTCThiChiTiet.ID_sv = dvSinhVien.Item(idx_sv)("ID_sv")
                                objTCThiChiTiet.So_bao_danh = dvSinhVien.Item(idx_sv)("So_bao_danh").ToString
                                objTCThiChiTiet.OrderBy = dvSinhVien.Item(idx_sv)("OrderBy").ToString
                                objTCThiChiTiet.ID_thi = ID_thi
                                objTCThiChiTiet.ID_phong_thi = ID_phong_thi
                                objTCThiChiTiet.Ghi_chu_thi = dvSinhVien.Item(idx_sv)("Ghi_chu_thi").ToString
                                ThemMoi_ESSTochucThiChiTiet(objTCThiChiTiet)
                                idx_sv += 1
                            Else
                                Exit Sub
                            End If
                        Next
                    End If
                Else
                    Exit Sub
                End If
            Next
        End Sub

        Public Function HienThi_ESSDS_dangkyThiLai(ByVal ID_mon As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Hinh_thuc As Integer) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDS_dangkyThiLai(ID_mon, Hoc_ky, Nam_hoc, Hinh_thuc)
                dt.Columns.Add("Chon", GetType(Boolean))
                For i As Integer = 0 To dt.Rows.Count - 1
                    If dt.Rows(i)("Duyet") = 1 Then
                        dt.Rows(i)("Chon") = True
                    Else
                        dt.Rows(i)("Chon") = False
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Sub TocChucThi(ByVal idx_thi As Integer, ByVal dvLopTinChi As DataView)
            'Dim objTCThi As New ESSTochucThi
            'Dim ID_thi As Integer = 0
            'Dim dvSinhVien As DataView
            'Dim clsLopTC As New DanhSachLopTinChi_Bussines
            'Dim ID_lop_tc, ID_phong_thi, So_sv_phong, So_du, idx_sv, Phong_thu As Integer
            'objTCThi = arrTochucThi(idx_thi)
            ''Insert to chuc thi
            'ID_thi = ThemMoi_ESSTochucThi(objTCThi)
            ''Duyệt danh sách lớp tín chỉ để tạo phòng thi
            'Phong_thu = 1
            'For i As Integer = 0 To dvLopTinChi.Count - 1
            '    If dvLopTinChi.Item(i)("Chon") = 1 Then
            '        'Load danh sách sinh viên lớp tín chỉ
            '        ID_lop_tc = dvLopTinChi.Item(i)("ID_lop_tc")
            '        clsLopTC = New DanhSachLopTinChi_Bussines(0, ID_lop_tc)
            '        dvSinhVien = clsLopTC.DanhSachSinhVien_ToChucThi.DefaultView
            '        'Duyệt số phòng thi/lớp tín chỉ
            '        So_du = dvSinhVien.Count Mod dvLopTinChi.Item(i)("So_phong")
            '        So_sv_phong = (dvSinhVien.Count - So_du) / dvLopTinChi.Item(i)("So_phong")
            '        idx_sv = 0
            '        For p As Integer = 1 To dvLopTinChi.Item(i)("So_phong")
            '            'Insert phòng thi
            '            Dim objPhongThi As New ESSToChucThiPhong
            '            objPhongThi.ID_thi = ID_thi
            '            objPhongThi.ID_lop_tc = ID_lop_tc
            '            objPhongThi.Gio_thi = objTCThi.Gio_thi
            '            If p = dvLopTinChi.Item(i)("So_phong") Then
            '                'Cong them so du vao phong thi cuoi cung
            '                objPhongThi.So_sv = So_sv_phong + So_du
            '            Else
            '                objPhongThi.So_sv = So_sv_phong
            '            End If
            '            objPhongThi.Ten_phong = "P" + Phong_thu.ToString
            '            Phong_thu += 1
            '            ID_phong_thi = ThemMoi_ESSToChucThiPhong(objPhongThi)
            '            'Insert sinh viên
            '            'Duyệt số sinh viên của phòng thi
            '            For j As Integer = 1 To objPhongThi.So_sv
            '                If idx_sv <= dvSinhVien.Count - 1 Then
            '                    'Insert sinh vien
            '                    Dim objTCThiChiTiet As New ESSTochucThiChiTiet
            '                    objTCThiChiTiet.ID_sv = dvSinhVien.Item(idx_sv)("ID_sv")
            '                    objTCThiChiTiet.ID_thi = ID_thi
            '                    objTCThiChiTiet.ID_phong_thi = ID_phong_thi
            '                    objTCThiChiTiet.ID_lop = ID_lop_tc
            '                    ThemMoi_ESSTochucThiChiTiet(objTCThiChiTiet)
            '                    idx_sv += 1
            '                Else
            '                    Exit For
            '                End If
            '            Next
            '        Next
            '    End If
            'Next
        End Sub
        Public Sub LapSoBaoDanh(ByVal idx_thi As Integer, ByVal Tu_so As Integer, ByVal OrderBy As Integer)
            Try
                If arrTochucThi.Count > 0 Then
                    Dim objTCThi As New ESSTochucThi
                    Dim So_sv As Integer = 0
                    Dim SoBD As String = ""
                    Dim ID_sv, idx_sv As Integer
                    objTCThi = arrTochucThi(idx_thi)
                    So_sv = objTCThi.dsChiTietSinhVien.Count
                    'Sắp xếp danh sách sinh viên
                    Dim dvSinhVien As DataView = DanhSachSinhVienTheoDotThi(objTCThi.ID_thi).DefaultView
                    If OrderBy <= 2 Then
                        For i As Integer = 0 To dvSinhVien.Table.Rows.Count - 1
                            Select Case OrderBy
                                Case 0  'Theo họ và tên
                                    dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ho_ten_order").ToString
                                Case 1  'Theo mã sinh viên
                                    dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                                Case 2  'Theo lớp - mã sinh viên
                                    dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ten_lop").ToString + dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                                Case 3  'Theo ngành - lớp - mã sinh viên
                                    dvSinhVien.Table.Rows(i)("OrderBy") = dvSinhVien.Table.Rows(i)("Ma_nganh").ToString + dvSinhVien.Table.Rows(i)("Ten_lop").ToString + dvSinhVien.Table.Rows(i)("Ma_sv").ToString
                            End Select
                        Next
                        dvSinhVien.Sort = "OrderBy"
                    End If
                    For i As Integer = 0 To dvSinhVien.Count - 1
                        'Đưa số 0 vào trước số VD 001, 002
                        SoBD = "0000" + (Tu_so + i).ToString
                        'Tính độ dài của số báo danh
                        SoBD = Right(SoBD, (So_sv + Tu_so).ToString.Length)
                        ID_sv = dvSinhVien.Item(i)("ID_sv")
                        idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(ID_sv)
                        If idx_sv >= 0 Then
                            objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(idx_sv).So_bao_danh = SoBD
                        End If
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub Fill_GhiChu(ByVal dv As DataView, ByVal ID_thi As Integer)
            Try
                Dim idx_thi As Integer = 0
                idx_thi = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    Dim objTCThi As New ESSTochucThi
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        For j As Integer = 0 To dv.Count - 1
                            If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_sv = dv.Item(j)("ID_sv") Then
                                objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Ghi_chu_thi = dv.Item(j)("Ghi_chu_thi").ToString
                            End If
                        Next
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub GanTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal ID_sv As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim idx_sv As Integer
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    idx_sv = objTCThi.dsChiTietSinhVien.Tim_sinh_vien(ID_sv)
                    If idx_sv >= 0 Then
                        objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(idx_sv).Tui_so = Tui_so
                        'Update vào CSDL
                        CapNhat_ESSTochucThiChiTiet(objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(idx_sv), objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(idx_sv).ID_ds_thi)
                    End If
                End If
            End If
        End Sub
        Public Sub XoaTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = Tui_so Then
                            objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = 0
                            objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).So_phach = 0
                            'Update vào CSDL
                            CapNhat_ESSTochucThiChiTiet(objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_ds_thi)
                        End If
                    Next
                End If
            End If
        End Sub
        Public Function KiemTraSoPhach(ByVal ID_thi As Integer, ByVal So_phach_tu As Integer, ByVal So_sv As Integer) As Boolean
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For So_phach As Integer = So_phach_tu To So_phach_tu + So_sv
                        For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                            If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).So_phach = So_phach Then
                                Return False
                            End If
                        Next
                    Next
                End If
            End If
            Return True
        End Function
        Public Sub LapSoPhach(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal So_phach_tu As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim so_phach As Integer = 0
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        If objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).Tui_so = Tui_so Then
                            objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).So_phach = So_phach_tu + so_phach
                            so_phach += 1
                            'Update vào CSDL
                            CapNhat_ESSTochucThiChiTiet(objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_ds_thi)
                        End If
                    Next
                End If
            End If
        End Sub
        Public Function Tim_idx(ByVal ID_thi As Integer) As Integer
            For i As Integer = 0 To arrTochucThi.Count - 1
                If CType(arrTochucThi(i), ESSTochucThi).ID_thi = ID_thi Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function HienThi_ESSDanhsachMonThi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Ngay_thi As Date) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachMonThi(Hoc_ky, Nam_hoc, Ngay_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhsachMonThiDungNgay(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Ngay_thi As Date) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachMonThiDungNgay(Hoc_ky, Nam_hoc, Ngay_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhsachLopTinChi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ngay_thi As Date) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachLopTinChi(Hoc_ky, Nam_hoc, ID_mon, Ngay_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhsachThi_DiemThi(ByVal ID_thi As Integer, ByVal Lan_thi As Integer) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachThi_DiemThi(ID_thi, Lan_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhsachLopTinChi_dungngay(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ngay_thi As Date) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachLopTinChi_dungngay(Hoc_ky, Nam_hoc, ID_mon, Ngay_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDanhsachLopTinChi(ByVal ID_thi As Integer) As DataTable
            Try
                Dim dtLopTC As New DataTable
                dtLopTC.Columns.Add("ID_lop_tc", GetType(Integer))

                Dim idx_thi As Integer = 0
                idx_thi = Tim_idx(ID_thi)
                If idx_thi >= 0 Then
                    Dim objTCThi As New ESSTochucThi
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For i As Integer = 0 To objTCThi.dsPhongThi.Count - 1
                        Dim dr As DataRow
                        Dim ID_lop_tc As Integer = objTCThi.dsPhongThi.ESSToChucThiPhong(i).ID_lop_tc
                        Dim dv As DataView = dtLopTC.DefaultView
                        dv.RowFilter = "ID_lop_tc=" & ID_lop_tc
                        If dv.Count = 0 Then
                            dr = dtLopTC.NewRow
                            dr("ID_lop_tc") = ID_lop_tc
                            dtLopTC.Rows.Add(dr)
                            dtLopTC.AcceptChanges()
                        End If
                    Next
                End If
                Return dtLopTC
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSTochucThi(ByVal objTochucThi As ESSTochucThi) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.ThemMoi_ESSTochucThi(objTochucThi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThi(ByVal objTochucThi As ESSTochucThi, ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSTochucThi(objTochucThi, ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSTochucThi(ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSTochucThi(ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSToChucThiPhong_(ByVal objToChucThiPhong As ESSToChucThiPhong) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.ThemMoi_ESSToChucThiPhong_(objToChucThiPhong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhong(ByVal objToChucThiPhong As ESSToChucThiPhong, ByVal ID_phong_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSToChucThiPhong(objToChucThiPhong, ID_phong_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhong(ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSToChucThiPhong(ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSTochucThiChiTiet(ByVal objTochucThiChiTiet As ESSTochucThiChiTiet) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.ThemMoi_ESSTochucThiChiTiet(objTochucThiChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThiChiTiet(ByVal objTochucThiChiTiet As ESSTochucThiChiTiet, ByVal ID_ds_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSTochucThiChiTiet(objTochucThiChiTiet, ID_ds_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThiChiTiet_SBD(ByVal So_bao_danh As String, ByVal ID_ds_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSTochucThiChiTiet_SBD(So_bao_danh, ID_ds_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSTochucThiChiTiet_GhiChu(ByVal Ghi_chu_thi As String, ByVal ID_ds_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSTochucThiChiTiet_GhiChu(Ghi_chu_thi, ID_ds_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        'Public Function Xoa_ESSTochucThiChiTiet(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
        '    Try
        '        Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
        '        Return obj.Xoa_ESSTochucThiChiTiet(ID_thi, ID_sv)
        '    Catch ex As Exception
        '        Throw ex
        '    End Try
        'End Function

        Public Function Xoa_ESSToChucThiTheoPhong(ByVal ID_thi As Integer, ByVal ID_phong_this As String) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSToChucThiTheoPhong(ID_thi, ID_phong_this)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSTochucThiChiTiet(ByVal ID_thi As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSTochucThiChiTiet(ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Xoa_ESSTochucThiChiTiet_SV(ByVal ID_thi As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSTochucThiChiTiet_SV(ID_thi, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Private Function MappingToTocChucThi(ByVal dr As DataRow) As ESSTochucThi
            Dim objTCThi As New ESSTochucThi
            objTCThi.ID_thi = dr("ID_thi")
            objTCThi.Hoc_ky = dr("Hoc_ky")
            objTCThi.Nam_hoc = dr("Nam_hoc")
            objTCThi.ID_he = dr("ID_he")
            objTCThi.Ten_he = dr("Ten_he").ToString
            objTCThi.ID_khoa = dr("ID_khoa")
            objTCThi.Ten_khoa = dr("Ten_khoa").ToString
            objTCThi.ID_mon = dr("ID_mon")
            objTCThi.Ten_mon = dr("Ten_mon")
            objTCThi.Ky_hieu = dr("Ky_hieu")
            objTCThi.Lan_thi = dr("Lan_thi")
            objTCThi.Dot_thi = dr("Dot_thi")
            objTCThi.Ngay_thi = dr("Ngay_thi")
            objTCThi.Ca_thi = IIf(IsDBNull(dr("Ca_thi")), 0, dr("Ca_thi"))
            objTCThi.Nhom_tiet = IIf(IsDBNull(dr("Nhom_tiet")), 0, dr("Nhom_tiet"))
            objTCThi.Gio_thi = dr("Gio_thi").ToString
            Return objTCThi
        End Function
        Private Function MappingToTocChucThiPhongThi(ByVal dr As DataRow) As ESSToChucThiPhong
            Dim objPhongThi As New ESSToChucThiPhong
            objPhongThi.ID_phong_thi = dr("ID_phong_thi")
            objPhongThi.ID_thi = dr("ID_thi")
            objPhongThi.ID_lop_tc = dr("ID_lop_tc")
            objPhongThi.ID_phong = dr("ID_phong")
            objPhongThi.Ten_phong = dr("Ten_phong").ToString
            objPhongThi.So_sv = dr("So_sv")
            objPhongThi.Gio_thi_Phong = dr("Gio_thi").ToString
            If dr("Ngay_thi").ToString <> "" Then objPhongThi.Ngay_thi_Phong = dr("Ngay_thi")
            objPhongThi.Nhom_tiet_phong = IIf(dr("Nhom_tiet").ToString = "", 0, dr("Nhom_tiet"))
            objPhongThi.Ca_thi_Phong = IIf(dr("Ca_thi").ToString = "", 0, dr("Ca_thi"))
            Return objPhongThi
        End Function
        Private Function MappingToTocChucThiDongTui(ByVal dr As DataRow) As ESSToChucThiDongTui
            Dim obj As New ESSToChucThiDongTui
            obj.Tui_so = dr("Tui_so")
            obj.ID_thi = dr("ID_thi")
            Return obj
        End Function
        Private Function MappingToTocChucThiChiTiet(ByVal dr As DataRow) As ESSTochucThiChiTiet
            Dim obj As New ESSTochucThiChiTiet
            obj.ID_ds_thi = dr("ID_ds_thi")
            obj.ID_thi = dr("ID_thi")
            obj.ID_sv = dr("ID_sv")
            obj.Ma_sv = dr("Ma_sv")
            obj.Ho_ten = dr("Ho_ten")
            obj.Ma_nganh = dr("Ma_nganh")
            If Not IsDBNull(dr("Ngay_sinh")) AndAlso dr("Ngay_sinh").ToString.Trim <> "" Then
                obj.Ngay_sinh = dr("Ngay_sinh")
                'Else
                '    obj.Ngay_sinh = Nothing
            End If

            obj.ID_lop = dr("ID_lop")
            obj.ID_khoa = dr("ID_khoa")
            obj.Ten_khoa = dr("Ten_khoa").ToString
            obj.Ten_lop = dr("Ten_lop").ToString
            obj.ID_dt1 = dr("ID_dt")
            obj.So_bao_danh = dr("So_bao_danh").ToString
            obj.So_phach = dr("So_phach")
            obj.Tui_so = dr("Tui_so")
            obj.ID_phong_thi = dr("ID_phong_thi")
            obj.Ten_phong = dr("Ten_phong").ToString
            obj.Ngoai_ngu = dr("Ngoai_ngu").ToString
            obj.Ghi_chu_thi = dr("Ghi_chu_thi").ToString
            obj.OrderBy = dr("OrderBy").ToString
            Return obj
        End Function

        Function HienThi_ESSDotThi(ByVal ID_he As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thi As Integer) As DataTable
            Dim clsTCThi As New TochucThi_DataAccess
            Dim dt As DataTable = clsTCThi.HienThi_ESSDotThi(ID_he, Hoc_ky, Nam_hoc, Dot_thi)
            Dim dtMain As New DataTable

            dtMain.Columns.Add("ID_thi", GetType(Integer))
            dtMain.Columns.Add("Ngay_thi", GetType(Date))
            dtMain.Columns.Add("Thoi_gian", GetType(String))
            dtMain.Columns.Add("Ten_mon", GetType(String))
            dtMain.Columns.Add("Ten_he", GetType(String))
            dtMain.Columns.Add("Ten_phong", GetType(String))
            dtMain.Columns.Add("Tieu_de_ten_bo", GetType(String))
            dtMain.Columns.Add("Tieu_de_Ten_truong", GetType(String))
            dtMain.Columns.Add("Tieu_de1", GetType(String))
            dtMain.Columns.Add("Tieu_de2", GetType(String))
            dtMain.Columns.Add("Ghi_chu", GetType(String))

            For i As Integer = 0 To dt.Rows.Count - 1
                dtMain.DefaultView.Sort = "ID_thi"
                If dtMain.DefaultView.Find(dt.Rows(i).Item("ID_thi")) < 0 Then
                    Dim dr As DataRow
                    dr = dtMain.NewRow
                    dr("ID_thi") = dt.Rows(i).Item("ID_thi")
                    dr("Ngay_thi") = dt.Rows(i).Item("Ngay_thi")
                    dr("Thoi_gian") = "Nhóm tiết " & dt.Rows(i).Item("Thoi_gian")
                    dr("Ten_mon") = dt.Rows(i).Item("Ten_mon")
                    dr("Ten_he") = dt.Rows(i).Item("Ten_he")
                    dtMain.Rows.Add(dr)
                End If
            Next

            For i As Integer = 0 To dtMain.Rows.Count - 1
                Dim Hoi_truong As String = ""
                dt.DefaultView.RowFilter = "1=1"
                dt.DefaultView.RowFilter = "ID_thi=" & dtMain.Rows(i).Item("ID_thi")
                For j As Integer = 0 To dt.DefaultView.Count - 1
                    If Hoi_truong.Trim <> "" Then
                        Hoi_truong += ", " & dt.DefaultView.Item(j)("Ten_phong").ToString
                    Else
                        Hoi_truong = dt.DefaultView.Item(j)("Ten_phong").ToString
                    End If
                Next
                dtMain.Rows(i).Item("Ten_phong") = Hoi_truong.Trim
            Next

            Return dtMain
        End Function

        '-----------------Dong tui thi-------------------

        Private Function CheckExist_svDuTuiThi(ByVal ID_thi As Integer, ByVal Tui_so As Integer, ByVal SoSV_Max As Integer) As Boolean
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Dim dt As DataTable = obj.KiemTra_SosvDuTuiThi(ID_thi, Tui_so, SoSV_Max)
                If dt.Rows.Count > 0 Then
                    Return False
                Else
                    Return True
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub DongTuiThi(ByVal dt_phong As DataTable, ByVal dt_dsthi As DataTable, ByVal ID_thi As Integer, ByVal SoSvMotTui_Max As Integer, ByVal SoSV_LanChia_TuiThi As Integer, ByVal So_phach_tu As Integer)
            Try
                Dim i, j, s As Integer
                Dim TongSoSV As Integer = dt_dsthi.Rows.Count
                Dim SoSV_PhongThi_DaChia As Integer = 0
                Dim SoSV_PhongThi_DaChia_tmp As Integer = 0
                dt_dsthi.DefaultView.Sort = "ID_phong_thi"
                Dim SoSvMotTui_Max_tmp As Integer = SoSvMotTui_Max

                Dim SoSV_ConDu As Integer = TongSoSV Mod SoSvMotTui_Max
                Dim SoTui As Integer = (TongSoSV - SoSV_ConDu) / SoSvMotTui_Max
                If SoSV_ConDu > 0 Then SoTui += 1
                Dim f As Boolean = True
                For i = 0 To dt_phong.Rows.Count - 1 'Liet ke voi moi Phong thi de do sinh vien vao Tui thi theo so sv cua lan chia cho tui-Tham so he thong
VetCan:             For j = 1 To SoTui ' Insert sinh vien vao tung tui thi
                        dt_dsthi.DefaultView.RowFilter = "1=1"
                        dt_dsthi.DefaultView.RowFilter = "Tui_so=" & j
                        SoSvMotTui_Max = SoSvMotTui_Max_tmp
                        ' Truong hop la tui cuoi cung co so sv le ko du 1 lan chia
                        If j = SoTui And SoSV_ConDu > 0 Then SoSvMotTui_Max = SoSV_ConDu
                        If dt_dsthi.DefaultView.Count < SoSvMotTui_Max Then 'Chua du so sinh vien cua Tui thi thi insert vao tui thi
                            If SoSV_PhongThi_DaChia < dt_phong.Rows(i).Item("So_sv") Then 'Neu So sinh vien cua phong thi con
                                Dim tmp As Integer = SoSV_PhongThi_DaChia
                                If dt_phong.Rows(i).Item("So_sv") - SoSV_PhongThi_DaChia > SoSV_LanChia_TuiThi Then 'Neu so sinh vien cua phong thi con du chia theo so lan chia vao tui thi
                                    For s = tmp + SoSV_PhongThi_DaChia_tmp To tmp + SoSV_PhongThi_DaChia_tmp + SoSV_LanChia_TuiThi - 1
                                        'Insert tung sinh vien vao tui thi tuong ung

                                        dt_dsthi.Rows(s).Item("Tui_so") = j
                                        SoSV_PhongThi_DaChia += 1
                                        If dt_dsthi.DefaultView.Count = SoSvMotTui_Max Then Exit For
                                    Next
                                Else 'Neu so sinh vien cua phong thi khong con du chia cho lan chia vao tui thi
                                    For s = tmp + SoSV_PhongThi_DaChia_tmp To dt_phong.Rows(i).Item("So_sv") + SoSV_PhongThi_DaChia_tmp - 1
                                        'Insert tung sinh vien vao tui thi tuong ung

                                        dt_dsthi.Rows(s).Item("Tui_so") = j
                                        SoSV_PhongThi_DaChia += 1
                                        If dt_dsthi.DefaultView.Count = SoSvMotTui_Max Then Exit For
                                    Next
                                    If SoSV_PhongThi_DaChia = dt_phong.Rows(i).Item("So_sv") Then
                                        SoSV_PhongThi_DaChia_tmp += SoSV_PhongThi_DaChia
                                        SoSV_PhongThi_DaChia = 0
                                        Exit For
                                    End If
                                End If
                                If SoSV_PhongThi_DaChia < dt_phong.Rows(i).Item("So_sv") Then GoTo VetCan
                            End If
                        End If
                    Next
                Next
                dt_dsthi.DefaultView.Sort = "Tui_so,So_bao_danh"
                dt_dsthi.DefaultView.RowFilter = "1=1"

                Dim so_phach As Integer = 0
                For i = 0 To dt_dsthi.DefaultView.Count - 1
                    Dim objTochucThiChiTiet As New ESSTochucThiChiTiet
                    objTochucThiChiTiet.ID_ds_thi = dt_dsthi.DefaultView.Item(i)("ID_ds_thi")
                    objTochucThiChiTiet.ID_thi = ID_thi
                    objTochucThiChiTiet.ID_sv = dt_dsthi.DefaultView.Item(i)("ID_SV")
                    objTochucThiChiTiet.ID_phong_thi = dt_dsthi.DefaultView.Item(i)("ID_phong_thi")
                    objTochucThiChiTiet.So_bao_danh = dt_dsthi.DefaultView.Item(i)("So_bao_danh")
                    objTochucThiChiTiet.So_phach = so_phach + So_phach_tu
                    objTochucThiChiTiet.Tui_so = dt_dsthi.DefaultView.Item(i)("Tui_so")
                    objTochucThiChiTiet.Ghi_chu_thi = dt_dsthi.DefaultView.Item(i)("Ghi_chu_thi")
                    objTochucThiChiTiet.OrderBy = dt_dsthi.DefaultView.Item(i)("OrderBy")

                    CapNhat_ESSTochucThiChiTiet(objTochucThiChiTiet, dt_dsthi.DefaultView.Item(i)("ID_ds_thi"))
                    so_phach += 1
                Next
            Catch ex As Exception
            End Try
        End Sub

        Public Sub LapSoPhach_DongTuiThi(ByVal ID_thi As Integer, ByVal So_phach_tu As Integer)
            If arrTochucThi.Count > 0 Then
                Dim objTCThi As New ESSTochucThi
                Dim idx_thi As Integer = Tim_idx(ID_thi)
                Dim so_phach As Integer = 0
                If idx_thi >= 0 Then
                    objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                    For i As Integer = 0 To objTCThi.dsChiTietSinhVien.Count - 1
                        objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).So_phach = So_phach_tu + so_phach
                        so_phach += 1
                        'Update vào CSDL
                        CapNhat_ESSTochucThiChiTiet(objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i), objTCThi.dsChiTietSinhVien.ESSTochucThiChiTiet(i).ID_ds_thi)
                    Next
                End If
            End If
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return arrTochucThi.Count
            End Get
        End Property
        Public Property ToChucThi(ByVal idx As Integer) As ESSTochucThi
            Get
                Return CType(arrTochucThi(idx), ESSTochucThi)
            End Get
            Set(ByVal Value As ESSTochucThi)
                arrTochucThi(idx) = Value
            End Set
        End Property
#End Region

        Public Function HienThi_ESSToChucThi_TongHop(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSToChucThi_TongHop(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSDSSV_ChuaToChuc(ByVal ID_lop_tc As Integer) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDSSV_ChuaToChuc(ID_lop_tc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function UpdateLai_TochucThi(ByVal Ngay_thi As Date, ByVal Dot_thi As Integer, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Thoi_gian As String, ByVal ID_thi As Integer) As Integer
            Try
                Dim objTCThi As New ESSTochucThi
                objTCThi = arrTochucThi(0)
                objTCThi.Ngay_thi = Ngay_thi
                objTCThi.Nhom_tiet = Nhom_tiet
                objTCThi.Gio_thi = Thoi_gian
                objTCThi.Dot_thi = Dot_thi
                objTCThi.Ca_thi = Ca_thi

                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSTochucThi(objTCThi, ID_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function CheckExist_TheoSinhVien_svTochucThi(ByVal ID_thi As Integer, ByVal Ca_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Ngay_thi As Date, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.KiemTra_TheoSinhVien_svTochucThi(ID_thi, Ca_thi, Nhom_tiet, Ngay_thi, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSDanhsachTheoPhong_Main(ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Ten_khoa As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhsachTheoPhong(ID_khoa, ID_nganh, Hoc_ky, Nam_hoc)
                Dim dt_mon As DataTable = HienThi_ESSDanhsachTheoMon(ID_khoa, ID_nganh, Hoc_ky, Nam_hoc)

                Dim dt_mon_main As New DataTable
                dt_mon_main.Columns.Add("ID_mon", GetType(Integer))
                dt_mon_main.Columns.Add("Ky_hieu", GetType(String))

                dt_mon_main.DefaultView.Sort = "ID_mon"
                For i As Integer = 0 To dt_mon.Rows.Count - 1
                    If dt_mon_main.DefaultView.Find(dt_mon.Rows(i).Item("ID_mon")) < 0 Then
                        Dim dr As DataRow = dt_mon_main.NewRow
                        dr("ID_mon") = dt_mon.Rows(i).Item("ID_mon")
                        dr("Ky_hieu") = dt_mon.Rows(i).Item("Ky_hieu").ToString
                        dt_mon_main.Rows.Add(dr)
                    End If
                Next

                dt.Columns.Add("Tieu_de", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines("P1")
                Dim ViTri As Integer = 0

                For i As Integer = 0 To dt.Rows.Count - 1
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    End If
                    dt.Rows(i).Item("Tieu_de") = "DANH SÁCH SINH VIÊN THEO PHÒNG THI HK " & Hoc_ky & " NĂM HỌC " & Nam_hoc
                    dt.Rows(i).Item("Hoc_ky") = Hoc_ky
                    dt.Rows(i).Item("Ten_khoa") = Ten_khoa
                    dt.Rows(i).Item("Nam_hoc") = Nam_hoc
                    dt_mon.DefaultView.RowFilter = "ID_SV=" & dt.Rows(i).Item("ID_SV")
                    For j As Integer = 0 To dt_mon_main.Rows.Count - 1
                        dt.Rows(i).Item("M" & j + 1) = dt_mon_main.Rows(j)("Ky_hieu").ToString
                    Next
                    If dt_mon.DefaultView.Count > 0 Then
                        ViTri = TimIndex(dt_mon_main, dt_mon.DefaultView.Item(0)("ID_mon")) + 1

                        dt.Rows(i).Item("P" & ViTri) = dt_mon.DefaultView.Item(0)("Ten_phong").ToString
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function HienThi_ESSThongKeTheoPhong(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSThongKeTheoPhong(Hoc_ky, Nam_hoc)

                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Tieu_de_ten_bo")
                dt.Columns.Add("Tieu_de_Ten_truong")

                Dim objBaoCaoTieuDe As New BaoCaoTieuDe_Bussines("P1")
                Dim ViTri As Integer = 0

                For i As Integer = 0 To dt.Rows.Count - 1
                    If objBaoCaoTieuDe.Count > 0 Then
                        dt.Rows(i).Item("Tieu_de_ten_bo") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_ten_bo
                        dt.Rows(i).Item("Tieu_de_Ten_truong") = objBaoCaoTieuDe.ESSBaoCaoTieuDe(0).Tieu_de_Ten_truong
                    End If
                    dt.Rows(i).Item("Hoc_ky") = Hoc_ky
                    dt.Rows(i).Item("Nam_hoc") = Nam_hoc
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function TimIndex(ByVal dt As DataTable, ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To dt.Rows.Count - 1
                If dt.Rows(i).Item("ID_mon") = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function HienThi_ESSDanhsachTheoMon(ByVal ID_khoa As Integer, ByVal ID_nganh As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSDanhsachTheoMon(ID_khoa, ID_nganh, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

#Region "Function PhucKhao"

        Public Function DanhSachSinhVienPhucKhao(ByVal ID_thi As Integer) As DataTable
            Dim dtPhucKhao As New DataTable
            dtPhucKhao.Columns.Add("Chon", GetType(Boolean))
            dtPhucKhao.Columns.Add("ID_sv", GetType(Integer))
            dtPhucKhao.Columns.Add("So_bao_danh", GetType(String))
            dtPhucKhao.Columns.Add("Ma_sv", GetType(String))
            dtPhucKhao.Columns.Add("Ho_ten", GetType(String))
            dtPhucKhao.Columns.Add("Ngay_sinh", GetType(Date))
            'dtPhucKhao.Columns.Add("ID_he", GetType(Integer))
            'dtPhucKhao.Columns.Add("Ten_he", GetType(String))
            dtPhucKhao.Columns.Add("ID_khoa", GetType(Integer))
            dtPhucKhao.Columns.Add("Ten_khoa", GetType(String))
            'dtPhucKhao.Columns.Add("ID_lop", GetType(Integer))
            dtPhucKhao.Columns.Add("Ten_lop", GetType(String))
            dtPhucKhao.Columns.Add("ID_mon", GetType(Integer))
            'dtPhucKhao.Columns.Add("Ky_hieu", GetType(String))
            dtPhucKhao.Columns.Add("Ten_mon", GetType(String))
            dtPhucKhao.Columns.Add("ID_phuc_khao", GetType(Integer))
            dtPhucKhao.Columns.Add("ID_thi", GetType(Integer))
            dtPhucKhao.Columns.Add("ID_ds_thi", GetType(Integer))
            dtPhucKhao.Columns.Add("Diem1", GetType(Double))
            dtPhucKhao.Columns.Add("Diem2", GetType(Double))
            dtPhucKhao.Columns.Add("Ghi_chu", GetType(String))


            Dim idx_thi As Integer = 0
            idx_thi = Tim_idx(ID_thi)
            If idx_thi >= 0 Then
                Dim objTCThi As New ESSTochucThi
                objTCThi = CType(arrTochucThi(idx_thi), ESSTochucThi)
                For i As Integer = 0 To objTCThi.dsPhucKhao.Count - 1
                    If objTCThi.dsPhucKhao.ESSToChucThiPhucKhao(i).ID_thi = ID_thi Then
                        Dim dr As DataRow
                        dr = dtPhucKhao.NewRow
                        With objTCThi.dsPhucKhao.ESSToChucThiPhucKhao(i)
                            dr("Chon") = False
                            dr("ID_sv") = .ID_sv
                            dr("So_bao_danh") = .So_bao_danh
                            dr("Ma_sv") = .Ma_sv
                            dr("Ho_ten") = .Ho_ten
                            dr("Ngay_sinh") = .Ngay_sinh
                            'dr("ID_he") = .ID_he
                            'dr("Ten_he") = .Ten_he
                            dr("ID_khoa") = .ID_khoa
                            dr("Ten_khoa") = .Ten_khoa
                            'dr("ID_lop") = .ID_lop
                            dr("Ten_lop") = .Ten_lop
                            dr("ID_mon") = .ID_mon
                            'dr("Ky_hieu") = .Ky_hieu
                            dr("Ten_mon") = .Ten_mon
                            dr("ID_phuc_khao") = .ID_phuc_khao
                            dr("ID_thi") = .ID_thi
                            dr("ID_ds_thi") = .ID_ds_thi
                            dr("Diem1") = .Diem1
                            dr("Diem2") = .Diem2
                            dr("Ghi_chu") = .Ghi_chu
                        End With
                        dtPhucKhao.Rows.Add(dr)
                    End If
                Next
            End If
            Return dtPhucKhao
        End Function

        Public Function HienThi_ESSToChucThiPhucKhao_DanhSach_All(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.HienThi_ESSToChucThiPhucKhao_DanhSach_All(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSToChucThiPhucKhao(ByVal objToChucThiPhucKhao As ESSToChucThiPhucKhao) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.ThemMoi_ESSToChucThiPhucKhao(objToChucThiPhucKhao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSToChucThiPhucKhao(ByVal objToChucThiPhucKhao As ESSToChucThiPhucKhao, ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSToChucThiPhucKhao(objToChucThiPhucKhao, ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.Xoa_ESSToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Boolean
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                obj.CheckExist_ToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function GetMaxID_svToChucThiPhucKhao(ByVal ID_phuc_khao As Integer) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                obj.GetMaxID_ToChucThiPhucKhao(ID_phuc_khao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function MappingToChucThiPhucKhao(ByVal drToChucThiPhucKhao As DataRow) As ESSToChucThiPhucKhao
            Dim result As ESSToChucThiPhucKhao
            Try
                result = New ESSToChucThiPhucKhao
                If drToChucThiPhucKhao("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drToChucThiPhucKhao("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drToChucThiPhucKhao("Nam_hoc").ToString()
                If drToChucThiPhucKhao("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drToChucThiPhucKhao("ID_khoa").ToString(), Integer)
                result.Ten_khoa = drToChucThiPhucKhao("Ten_khoa").ToString()
                If drToChucThiPhucKhao("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drToChucThiPhucKhao("ID_chuyen_nganh").ToString(), Integer)
                result.Chuyen_nganh = drToChucThiPhucKhao("Chuyen_nganh").ToString()
                If drToChucThiPhucKhao("ID_lop").ToString() <> "" Then result.ID_lop = CType(drToChucThiPhucKhao("ID_lop").ToString(), Integer)
                result.Ten_lop = drToChucThiPhucKhao("Ten_lop").ToString()

                If drToChucThiPhucKhao("ID_sv").ToString() <> "" Then result.ID_sv = CType(drToChucThiPhucKhao("ID_sv").ToString(), Integer)
                result.So_bao_danh = drToChucThiPhucKhao("So_bao_danh").ToString()
                result.Ma_sv = drToChucThiPhucKhao("Ma_sv").ToString()
                result.Ho_ten = drToChucThiPhucKhao("Ho_ten").ToString()
                If drToChucThiPhucKhao("Ngay_sinh").ToString() <> "" Then result.Ngay_sinh = CType(drToChucThiPhucKhao("Ngay_sinh"), Date)
                If drToChucThiPhucKhao("ID_mon").ToString() <> "" Then result.ID_mon = CType(drToChucThiPhucKhao("ID_mon").ToString(), Integer)
                result.Ky_hieu = drToChucThiPhucKhao("Ky_hieu").ToString()
                result.Ten_mon = drToChucThiPhucKhao("Ten_mon").ToString()
                If drToChucThiPhucKhao("Ngay_thi").ToString() <> "" Then result.Ngay_thi = CType(drToChucThiPhucKhao("Ngay_thi"), Date)
                If drToChucThiPhucKhao("ID_phuc_khao").ToString() <> "" Then result.ID_phuc_khao = CType(drToChucThiPhucKhao("ID_phuc_khao").ToString(), Integer)
                If drToChucThiPhucKhao("ID_thi").ToString() <> "" Then result.ID_thi = CType(drToChucThiPhucKhao("ID_thi").ToString(), Integer)
                If drToChucThiPhucKhao("ID_ds_thi").ToString() <> "" Then result.ID_ds_thi = CType(drToChucThiPhucKhao("ID_ds_thi").ToString(), Integer)
                If drToChucThiPhucKhao("Lan").ToString() <> "" Then result.Lan = CType(drToChucThiPhucKhao("Lan").ToString(), Integer)
                If drToChucThiPhucKhao("Diem1").ToString() <> "" Then result.Diem1 = CType(drToChucThiPhucKhao("Diem1").ToString(), Double)
                If drToChucThiPhucKhao("Diem2").ToString() <> "" Then result.Diem2 = CType(drToChucThiPhucKhao("Diem2").ToString(), Double)
                result.Ghi_chu = drToChucThiPhucKhao("Ghi_chu").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

#End Region
        Public Function CapNhat_ESSToChucThiPhong_ThongTin(ByVal ID_phong_thi As Integer, ByVal Nhom_tiet As Integer, ByVal Ca_thi As Integer, ByVal Gio_thi As String, ByVal Ngay_thi As Date, ByVal ID_phong As Integer, ByVal Ten_phong As String) As Integer
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                Return obj.CapNhat_ESSToChucThiPhong_ThongTin(ID_phong_thi, Nhom_tiet, Ca_thi, Gio_thi, Ngay_thi, ID_phong, Ten_phong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function CatSoVanBang(ByVal So_van_bang As String, ByVal Do_dai As Integer) As String
            So_van_bang = Right(So_van_bang, Do_dai)
            Return So_van_bang
        End Function

        Public Sub CapNhat_GhiChu_NoHP(ByVal ID_ds_thi As Integer, ByVal Ghi_chu_thi As String)
            Try
                Dim obj As TochucThi_DataAccess = New TochucThi_DataAccess
                obj.CapNhat_GhiChuThi(ID_ds_thi, Ghi_chu_thi)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
    End Class
End Namespace
