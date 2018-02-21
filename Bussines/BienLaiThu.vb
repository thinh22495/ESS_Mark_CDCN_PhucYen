'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class BienLaiThu_Bussines
        Private arrBienLaiThu As New ArrayList
        Private dtDsThuChi As DataTable ' Bảng danh sách thu chi cua sinh viên (Dùng trong load Hồ sơ sinh viên)
        Private So_tien_mg_1_tc_50 As Integer = 20000
        Private So_tien_mg_1_tc_100 As Integer = 50000
        Private So_tien_mg_1_ky_50 As Integer = 0
        Private So_tien_mg_1_ky_100 As Integer = 0
#Region "Initialize"
        Sub New()

        End Sub
        ' Khởi tạo biên lại thu theo môn tin chỉ
        Sub New(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer)
            Dim dtBL, dtBLChiTiet As DataTable
            'Load biên lai
            dtBL = HienThi_ESSBienLaiThu_DanhSach(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            'Load biên lai chi tiết
            dtBLChiTiet = HienThi_ESSBienLaiThuChiChiTiet_DanhSach(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            For i As Integer = 0 To dtBL.Rows.Count - 1
                Dim objBL As New ESSBienLaiThu
                'Chhuyển datarow thành object
                objBL = MappingBienLaiThu(dtBL.Rows(i))
                For j As Integer = 0 To dtBLChiTiet.Rows.Count - 1
                    If objBL.ID_bien_lai = dtBLChiTiet.Rows(j)("ID_bien_lai") Then
                        Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                        'Chhuyển datarow thành object
                        objBLChiTiet = MappingBienLaiThuChiTiet(dtBLChiTiet.Rows(j))
                        'Add một object
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                'Add một object
                arrBienLaiThu.Add(objBL)
            Next
        End Sub
        Sub New(ByVal ID_bien_lai As Integer)
            Dim dtBL, dtBLChiTiet As DataTable
            'Load biên lai
            dtBL = HienThi_ESSBienLaiThu(ID_bien_lai)
            'Load biên lai chi tiết
            dtBLChiTiet = HienThi_ESSBienLaiThuChiChiTiet(ID_bien_lai)
            For i As Integer = 0 To dtBL.Rows.Count - 1
                Dim objBL As New ESSBienLaiThu
                'Chhuyển datarow thành object
                objBL = MappingBienLaiThu(dtBL.Rows(i))
                For j As Integer = 0 To dtBLChiTiet.Rows.Count - 1
                    If objBL.ID_bien_lai = dtBLChiTiet.Rows(j)("ID_bien_lai") Then
                        Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                        'Chhuyển datarow thành object
                        objBLChiTiet = MappingBienLaiThuChiTiet(dtBLChiTiet.Rows(j))
                        'Add một object
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                'Add một object
                arrBienLaiThu.Add(objBL)
            Next
        End Sub
        Sub New(ByVal ID_sv As Integer, ByVal Tong_hop As Integer)
            Dim dtBL, dtBLChiTiet As DataTable
            'Load biên lai
            dtBL = HienThi_ESSBienLaiThu_SV(ID_sv)
            'Load biên lai chi tiết
            dtBLChiTiet = HienThi_ESSBienLaiThuChiChiTiet_SV(ID_sv)
            For i As Integer = 0 To dtBL.Rows.Count - 1
                Dim objBL As New ESSBienLaiThu
                'Chhuyển datarow thành object
                objBL = MappingBienLaiThu(dtBL.Rows(i))
                For j As Integer = 0 To dtBLChiTiet.Rows.Count - 1
                    If objBL.ID_bien_lai = dtBLChiTiet.Rows(j)("ID_bien_lai") Then
                        Dim objBLChiTiet As New ESSBienLaiThuChiTiet
                        'Chhuyển datarow thành object
                        objBLChiTiet = MappingBienLaiThuChiTiet(dtBLChiTiet.Rows(j))
                        'Add một object
                        objBL.dsBienLaiChiTiet.Add(objBLChiTiet)
                    End If
                Next
                'Add một object
                arrBienLaiThu.Add(objBL)
            Next
        End Sub
        ' Khởi tạo danh sách thu chi (Dùng trong load Hồ sơ sinh viên)
        Sub New(ByVal ID_sv As Integer, ByVal Hoso As Boolean)
            Try
                Dim obj As New BienLaiThu_DataAccess
                dtDsThuChi = obj.HienThi_ESSDanhSach_ThuChi_DanhSach(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal CTDT As ESSBienLaiThu)
            arrBienLaiThu.Add(CTDT)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrBienLaiThu.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return arrBienLaiThu.Count
            End Get
        End Property
        Public Property ESSBienLaiThu(ByVal idx As Integer) As ESSBienLaiThu
            Get
                Return CType(arrBienLaiThu(idx), ESSBienLaiThu)
            End Get
            Set(ByVal Value As ESSBienLaiThu)
                arrBienLaiThu(idx) = Value
            End Set
        End Property
        Public Function Tim_idx(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                If CType(arrBienLaiThu(i), ESSBienLaiThu).ID_sv = ID_sv And CType(arrBienLaiThu(i), ESSBienLaiThu).Huy_phieu = False Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function DanhSachBienLaiThuHocPhan(ByVal ID_thu_chi As Integer, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByVal Huy_phieu As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim idx As Integer
            'Add thêm các cột về biên lai
            dtDanhSach.Columns.Add("idx_bl", GetType(Integer))
            dtDanhSach.Columns.Add("Dot_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Lan_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Nguoi_thu", GetType(String))
            dtDanhSach.Columns.Add("Huy_phieu", GetType(Boolean))
            dtDanhSach.Columns.Add("Ngoai_te", GetType(String))
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As ESSBienLaiThu = CType(arrBienLaiThu(i), ESSBienLaiThu)
                If objBL.ThuTheoHocPhan Then
                    Dim dr As DataRow = dtDanhSach.NewRow
                    dr("idx_bl") = i
                    dr("Dot_thu") = objBL.Dot_thu
                    dr("Lan_thu") = objBL.Lan_thu
                    dr("Nguoi_thu") = objBL.Nguoi_thu
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("Huy_phieu") = objBL.Huy_phieu
                    dr("Ngoai_te") = objBL.Ngoai_te
                    dr("So_phieu") = objBL.So_phieu
                    dr("Ma_sv") = objBL.Ma_sv
                    dr("Ho_ten") = objBL.Ho_ten
                    dr("So_phieu") = objBL.So_phieu
                    dr("So_tien") = objBL.So_tien
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("ID_bien_lai") = objBL.ID_bien_lai
                    If ID_mon > 0 Then
                        If Ky_hieu_lop_tc <> "" Then
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, ID_thu_chi, ID_mon, Ky_hieu_lop_tc)
                        Else
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, ID_thu_chi, ID_mon)
                        End If
                        If idx >= 0 Then
                            dr("So_tien") = objBL.dsBienLaiChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                    dr("Noi_dung") = objBL.Noi_dung
                    If dr("So_tien").ToString <> "" And dr("Huy_phieu") = Huy_phieu Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        Public Function DanhSachBienLaiThuHocKy(ByVal ID_thu_chi As Integer, ByVal Huy_phieu As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai
            dtDanhSach.Columns.Add("idx_bl", GetType(Integer))
            dtDanhSach.Columns.Add("Dot_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Lan_thu", GetType(Integer))
            dtDanhSach.Columns.Add("Nguoi_thu", GetType(String))
            dtDanhSach.Columns.Add("Huy_phieu", GetType(Boolean))
            dtDanhSach.Columns.Add("Ngoai_te", GetType(String))
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As ESSBienLaiThu = CType(arrBienLaiThu(i), ESSBienLaiThu)
                If Not objBL.ThuTheoHocPhan Then
                    Dim dr As DataRow = dtDanhSach.NewRow
                    dr("idx_bl") = i
                    dr("Dot_thu") = objBL.Dot_thu
                    dr("Lan_thu") = objBL.Lan_thu
                    dr("Nguoi_thu") = objBL.Nguoi_thu
                    dr("Ngay_thu") = objBL.Ngay_thu
                    dr("Huy_phieu") = objBL.Huy_phieu
                    dr("Ngoai_te") = objBL.Ngoai_te
                    dr("So_phieu") = objBL.So_phieu
                    dr("Ma_sv") = objBL.Ma_sv
                    dr("Ho_ten") = objBL.Ho_ten
                    dr("ID_bien_lai") = objBL.ID_bien_lai
                    So_tien = 0
                    For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                        If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                    Next
                    If So_tien > 0 Then
                        dr("So_tien") = So_tien
                    End If
                    dr("Noi_dung") = objBL.Noi_dung
                    If dr("So_tien").ToString <> "" And dr("Huy_phieu") = Huy_phieu Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
        Public Function DanhSach_KhoanNop_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.HienThi_ESSKhoanNop_HocKy_DanhSach(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền
            dtKhoanNop.Columns.Add("Tinh_chat", GetType(String))
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Nop_tien", GetType(Boolean))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Nhập trạng thái
            Dim clsSV As New ThongTinSinhVien_Bussines(ID_sv)
            Dim objInfo As ESSThongTinSinhVien = clsSV.ESSThongTinSinhVien
            Dim tinh_chat As String = ""
            If objInfo.Ngoai_ngan_sach Then
                tinh_chat = "Ngoài ngân sách"
            Else
                tinh_chat = "Học thường"
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("tinh_chat") = tinh_chat
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
                dtKhoanNop.Rows(i)("Nop_tien") = True
                If dtKhoanNop.Rows(i)("so_tien_da_nop").ToString <> "" Then dtKhoanNop.Rows(i)("Nop_tien") = True Else dtKhoanNop.Rows(i)("Nop_tien") = False
            Next
            Return dtKhoanNop
        End Function
        Public Function TongHop_KhoanNop_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.HienThi_ESSKhoanNop_HocKy_DanhSach(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền                        
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBLChiTiet As ESSBienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), ESSBienLaiThu).dsBienLaiChiTiet
                    Dim objBL As ESSBienLaiThu
                    objBL = CType(arrBienLaiThu(j), ESSBienLaiThu)
                    If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp
                        idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtKhoanNop.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtKhoanNop.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtKhoanNop.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtKhoanNop.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtKhoanNop.Rows
                Tong_tien += dr("So_tien")
                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                Tong_tien_nop += dr("So_tien_nop")
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
        'Chỉ Tổng hợp khoản nộp học phí theo kỳ
        Public Function TongHop_NopHocPhi_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ
            dtKhoanNop = obj.HienThi_ESSKhoanNop_HocKy_DanhSach(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền                        
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                If dtKhoanNop.Rows(i)("Hoc_phi") Then ' Nếu là nộp học phí
                    Dim Tong_So_tien_da_nop As Integer = 0
                    Dim Thieu_thua As Integer = 0
                    For j As Integer = 0 To arrBienLaiThu.Count - 1
                        Dim objBLChiTiet As ESSBienLaiThuChiTiet
                        objBLChiTiet = CType(arrBienLaiThu(j), ESSBienLaiThu).dsBienLaiChiTiet
                        Dim objBL As ESSBienLaiThu
                        objBL = CType(arrBienLaiThu(j), ESSBienLaiThu)
                        If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp
                            idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                            If idx >= 0 Then
                                Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                                Thieu_thua += dtKhoanNop.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            End If
                        End If
                    Next
                    dtKhoanNop.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                    dtKhoanNop.Rows(i)("Thieu_thua") = Thieu_thua
                End If
            Next
            dtKhoanNop.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtKhoanNop.Rows
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 And dr("Hoc_phi") Then
                    Tong_tien += dr("So_tien")
                    Tong_tien_mien_giam += dr("So_tien_mien_giam")
                    Tong_tien_nop += dr("So_tien_nop")
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function DanhSachHocPhanBienLaiThu(ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer, ByVal idx_bl As Integer, Optional ByVal Lan_thu As Integer = 0) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim idx As Integer
            Dim Phan_tram_MG As Double
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.HienThi_ESSBienLaiThu_MonDaThu_DanhSach(Hoc_ky, Nam_hoc, ID_sv, ID_thu_chi)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien") = So_tien
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("So_tien_nop") = So_tien - So_tien_mien_giam
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            If idx_bl >= 0 Then
                Dim objBLChiTiet As ESSBienLaiThuChiTiet
                objBLChiTiet = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu).dsBienLaiChiTiet
                Dim objBL As ESSBienLaiThu
                objBL = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu)
                If Lan_thu <> 1 Then
                    'Duyệt xóa học phần đã thu của lần khác
                    For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                        For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                            If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") And _
                                dtHocPhanDaThu.Rows(j)("Lan_thu") <> objBL.Lan_thu Then
                                dtHocPhanThu.Rows(i).Delete()
                                dtHocPhanThu.AcceptChanges()
                                Exit For
                            End If
                        Next
                    Next
                End If
                'Tích chọn số môn đã thu lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                    If idx >= 0 Then
                        dtHocPhanThu.Rows(i)("Chon") = True
                    End If
                Next
            Else
                'Duyệt xóa học phần đã thu của lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                        If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") Then
                            dtHocPhanThu.Rows(i).Delete()
                            dtHocPhanThu.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
            End If
            Return dtHocPhanThu
        End Function
        Public Function DanhSachHocPhanBienLaiThuThiLai(ByVal dtMucThiLai As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer, ByVal idx_bl As Integer, Optional ByVal Lan_thu As Integer = 0) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim idx As Integer
            Dim Don_gia As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.HienThi_ESSBienLaiThu_MonDaThu_DanhSach(Hoc_ky, Nam_hoc, ID_sv, ID_thu_chi)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucThiLai.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucThiLai.Rows.Count - 1
                        Don_gia = dtMucThiLai.Rows(j)("So_tien")
                        Tinh_chat_hoc_phi = "Thi lại"
                    Next
                End If
                dtHocPhanThu.Rows(i)("So_tien") = Don_gia
                dtHocPhanThu.Rows(i)("So_tien_nop") = Don_gia
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            If idx_bl >= 0 Then
                Dim objBLChiTiet As ESSBienLaiThuChiTiet
                objBLChiTiet = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu).dsBienLaiChiTiet
                Dim objBL As ESSBienLaiThu
                objBL = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu)
                If Lan_thu <> 1 Then
                    'Duyệt xóa học phần đã thu của lần khác
                    For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                        For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                            If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") And _
                                dtHocPhanDaThu.Rows(j)("Lan_thu") <> objBL.Lan_thu Then
                                dtHocPhanThu.Rows(i).Delete()
                                dtHocPhanThu.AcceptChanges()
                                Exit For
                            End If
                        Next
                    Next
                End If
                'Tích chọn số môn đã thu lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                    If idx >= 0 Then
                        dtHocPhanThu.Rows(i)("Chon") = True
                    End If
                Next
            Else
                'Duyệt xóa học phần đã thu của lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                        If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") Then
                            dtHocPhanThu.Rows(i).Delete()
                            dtHocPhanThu.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
            End If
            Return dtHocPhanThu
        End Function
        Public Function LoadBienLaiChiTiet(ByVal dtMucHocPhi_Nganh2 As DataTable, ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_bien_lai As Integer, ByVal Lop_chat_luong_cao As Boolean) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtBLChiTiet As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG As Double
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.Load_BienLaiThu_MonDangKy_List(Hoc_ky, Nam_hoc, 0, ID_sv)
            'Lấy danh sách các học phần sinh viên đã đóng
            dtBLChiTiet = obj.Load_BienLaiThuChiTiet(ID_bien_lai)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Loại các học phần không có trong biên lai
            For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                Dim dv As DataView = dtBLChiTiet.DefaultView
                dv.RowFilter = "ID_mon_tc=" & dtHocPhanThu.Rows(i)("ID_mon_tc")
                If dv.Count = 0 Then
                    dtHocPhanThu.Rows(i).Delete()
                    dtHocPhanThu.AcceptChanges()
                Else
                    dtHocPhanThu.Rows(i)("So_tien_nop") = dv(0)("so_tien")
                End If
            Next
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If Nganh2 Then
                    If dtMucHocPhi_Nganh2.Rows.Count > 0 Then
                        For j As Integer = 0 To dtMucHocPhi_Nganh2.Rows.Count - 1
                            Don_gia = dtMucHocPhi_Nganh2.Rows(j)("So_tien")
                            Tinh_chat_hoc_phi = dtMucHocPhi_Nganh2.Rows(j)("Tinh_chat")
                            If CType(dtMucHocPhi_Nganh2.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Lop_chat_luong_cao"), Boolean) = Lop_chat_luong_cao And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                                Don_gia = dtMucHocPhi_Nganh2.Rows(j)("So_tien")
                                Mien_giam = dtMucHocPhi_Nganh2.Rows(j)("Mien_giam")
                                Tinh_chat_hoc_phi = dtMucHocPhi_Nganh2.Rows(j)("Tinh_chat")
                                Exit For
                            End If
                        Next
                    End If
                Else
                    If dtMucHocPhi.Rows.Count > 0 Then
                        For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                                CType(dtMucHocPhi.Rows(j)("Lop_chat_luong_cao"), Boolean) = Lop_chat_luong_cao And _
                                CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                                CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                                Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                                Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                                Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                                Exit For
                            End If
                        Next
                    End If
                End If

                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                If Mien_giam And Phan_tram_MG > 0 Then
                    'So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                    If Phan_tram_MG = 50 Then
                        So_tien_mien_giam = So_tien_mg_1_tc_50 * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                    ElseIf Phan_tram_MG = 100 Then
                        So_tien_mien_giam = So_tien_mg_1_tc_100 * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                    End If
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("so_tien") = So_tien
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
                dtHocPhanThu.Rows(i)("Chon") = True
            Next
            Return dtHocPhanThu
        End Function
        Public Function LoadBienLaiThuThiLaiChiTiet(ByVal dtMucThiLai As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_bien_lai As Integer) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtBLChiTiet As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Don_gia As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(Hoc_ky, Nam_hoc, 0, ID_sv)
            'Lấy danh sách các học phần sinh viên đã đóng
            dtBLChiTiet = obj.HienThi_ESSBienLaiThuChiTiet(ID_bien_lai)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Loại các học phần không có trong biên lai
            For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                Dim dv As DataView = dtBLChiTiet.DefaultView
                dv.RowFilter = "ID_mon_tc=" & dtHocPhanThu.Rows(i)("ID_mon_tc")
                If dv.Count = 0 Then
                    dtHocPhanThu.Rows(i).Delete()
                    dtHocPhanThu.AcceptChanges()
                Else
                    dtHocPhanThu.Rows(i)("So_tien_nop") = dv(0)("so_tien")
                End If
            Next
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucThiLai.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucThiLai.Rows.Count - 1
                        Don_gia = dtMucThiLai.Rows(j)("So_tien")
                        Tinh_chat_hoc_phi = "Thi lại"
                        Exit For
                    Next
                End If
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                dtHocPhanThu.Rows(i)("so_tien") = Don_gia
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
                dtHocPhanThu.Rows(i)("Chon") = True
            Next
            Return dtHocPhanThu
        End Function
        Private Function DanhSachHocPhanBienLaiThu_TheoKy(ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG As Integer
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(Hoc_ky, Nam_hoc, 0, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.HienThi_ESSBienLaiThu_MonDaThu_DanhSach(Hoc_ky, Nam_hoc, ID_sv, ID_thu_chi)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien") = So_tien
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("So_tien_nop") = So_tien - So_tien_mien_giam
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            Return dtHocPhanThu
        End Function
        Public Function TongHop_HocPhi(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Boolean, ByVal ID_he As Integer, Optional ByVal ID_mon As Integer = 0) As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim dtTongHop As New DataTable
            Dim dtKy, dtMon, dtNop As New DataTable
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam, So_tien_tra_lai As Integer
            So_tien_tra_lai = 0
            Dim Phan_tram_MG As Double
            Dim fg As Boolean = False
            dtTongHop.Columns.Add("Hoc_ky", GetType(String))
            dtTongHop.Columns.Add("Nam_hoc", GetType(String))
            dtTongHop.Columns.Add("So_tien_phai_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_tra_lai", GetType(Integer))
            dtTongHop.Columns.Add("Thieu_thua", GetType(Integer))
            'Lấy các khoản phải nộp theo học kỳ
            dtKy = obj.TongHopThuHocKy(ID_sv)
            For i As Integer = 0 To dtKy.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtKy.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtKy.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + dtKy.Rows(i)("So_tien_phai_nop")
                        dtTongHop.Rows(j)("So_tien_mien_giam") += CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + dtKy.Rows(i)("So_tien_mien_giam")
                        dtTongHop.Rows(j)("So_tien_tra_lai") += CInt("0" + dtTongHop.Rows(j)("So_tien_tra_lai").ToString) + So_tien_tra_lai
                        dtTongHop.Rows(j)("So_tien_nop") = CInt("0" & dtTongHop.Rows(j)("So_tien_phai_nop")) - CInt("0" & dtTongHop.Rows(j)("So_tien_mien_giam"))
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtKy.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtKy.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = dtKy.Rows(i)("So_tien_phai_nop")
                    dr("So_tien_mien_giam") = dtKy.Rows(i)("So_tien_mien_giam")
                    dr("So_tien_tra_lai") = IIf(IsDBNull(dtKy.Rows(i)("So_tien_tra_lai")), 0, dtKy.Rows(i)("So_tien_tra_lai"))
                    dr("So_tien_nop") = CInt("0" & dtKy.Rows(i)("So_tien_phai_nop")) - CInt("0" & dtKy.Rows(i)("So_tien_mien_giam"))
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản phải nộp thông qua đăng ký học phần tín chỉ
            dtMon = obj.TongHopThuMonDangKy(ID_sv)
            Dim dv As DataView = dtMon.DefaultView
            If ID_mon > 0 Then dv.RowFilter = "id_mon=" & ID_mon
            For i As Integer = 0 To dv.Count - 1
                Dim dtMucHocPhi As DataTable = HienThi_ESSMucHocPhiTinChi_DanhSach(dv(i)("Hoc_ky"), dv(i)("Nam_hoc"), ID_he)
                Hoc_lai = CType(dv(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dv(i)("Chuyen_nganh2"), Boolean)
                Phan_tram_MG = dv(i)("Phan_tram_mien_giam")
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dv(i)("He_so") * dv(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dv(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dv(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + So_tien
                        dtTongHop.Rows(j)("So_tien_mien_giam") = CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + So_tien_mien_giam
                        dtTongHop.Rows(j)("So_tien_nop") = CInt("0" & dtTongHop.Rows(j)("So_tien_phai_nop")) - CInt("0" & dtTongHop.Rows(j)("So_tien_mien_giam"))
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dv(i)("Hoc_ky")
                    dr("Nam_hoc") = dv(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = So_tien
                    dr("So_tien_mien_giam") = So_tien_mien_giam
                    dr("So_tien_nop") = So_tien - So_tien_mien_giam
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản sinh viên đã nộp học phí 
            If ID_mon = 0 Then
                dtNop = obj.TongHopDaNopHocPhi(ID_sv)
            Else
                dtNop = obj.TongHopDaNopHocPhiTheoMon(ID_sv, ID_mon)
            End If
            For i As Integer = 0 To dtNop.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtNop.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtNop.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_da_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_da_nop").ToString) + dtNop.Rows(i)("So_tien_da_nop")
                        dtTongHop.Rows(j)("Thieu_thua") = CInt("0" + dtTongHop.Rows(j)("So_tien_nop")) - CInt("0" + dtTongHop.Rows(j)("So_tien_da_nop")) + CInt("0" + dtTongHop.Rows(j)("So_tien_tra_lai"))
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtNop.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtNop.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = 0
                    dr("So_tien_mien_giam") = 0
                    dr("So_tien_da_nop") = dtNop.Rows(i)("So_tien_da_nop")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                If dtTongHop.Rows(i)("So_tien_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_nop") = 0
                If dtTongHop.Rows(i)("So_tien_da_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_da_nop") = 0
                If dtTongHop.Rows(i)("So_tien_tra_lai").ToString = "" Then dtTongHop.Rows(i)("So_tien_tra_lai") = 0
                dtTongHop.Rows(i)("Thieu_thua") = CInt("0" & dtTongHop.Rows(i)("So_tien_nop")) - CInt("0" & dtTongHop.Rows(i)("So_tien_da_nop")) + CInt("0" & dtTongHop.Rows(i)("So_tien_tra_lai"))
            Next
            Return dtTongHop
        End Function
        Public Function TongHop_HocPhan_BienLaiThu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer, ByVal Dot_thu As Integer) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim idx As Integer
            Dim Phan_tram_MG As Double
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Add thêm cột số tiền                        
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Thieu_thua", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                If dtHocPhanThu.Rows(i)("Hoc_lai") = False And Phan_tram_MG > 0 Then
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = (dtHocPhanThu.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien_nop") = dtHocPhanThu.Rows(i)("So_tien") - dtHocPhanThu.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBLChiTiet As ESSBienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), ESSBienLaiThu).dsBienLaiChiTiet
                    Dim objBL As ESSBienLaiThu
                    objBL = CType(arrBienLaiThu(j), ESSBienLaiThu)
                    If objBL.Hoc_ky = Hoc_ky And objBL.Nam_hoc = Nam_hoc And objBL.ID_sv = ID_sv And objBL.Huy_phieu = False Then ' Nếu đã nộp                        
                        idx = objBL.dsBienLaiChiTiet.Tim_mon_tc(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon_tc"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtHocPhanThu.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtHocPhanThu.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtHocPhanThu.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtHocPhanThu.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            Dim row As DataRow
            Dim Tong_tien As Integer = 0
            Dim Tong_tien_mien_giam As Integer = 0
            Dim Tong_tien_nop As Integer = 0
            Dim Tong_tien_da_nop As Integer = 0
            Dim Tong_Thieu_thua As Integer = 0
            For Each dr As DataRow In dtHocPhanThu.Rows
                Tong_tien += dr("So_tien")
                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                Tong_tien_nop += dr("So_tien_nop")
                ' Nếu học kỳ và năm học đã có tiền nộp
                If dr("Hoc_ky") = Hoc_ky And dr("Nam_hoc") = Nam_hoc And IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                    Tong_tien_da_nop += dr("So_tien_da_nop")
                End If
            Next
            ' Tổng hợp số tiền nộp học phí theo kỳ
            Dim dtHP_Ky As DataTable
            dtHP_Ky = TongHop_NopHocPhi_HocKy(Hoc_ky, Nam_hoc, ID_sv)
            If dtHP_Ky.Rows.Count > 0 Then
                For Each r As DataRow In dtHP_Ky.Rows
                    Tong_tien += r("So_tien")
                    Tong_tien_mien_giam += r("So_tien_mien_giam")
                    Tong_tien_nop += r("So_tien_nop")
                    Tong_tien_da_nop += r("So_tien_da_nop")
                Next
            End If
            Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            row = dt.NewRow
            row("Hoc_ky") = Hoc_ky
            row("Nam_hoc") = Nam_hoc
            row("So_tien") = Tong_tien
            row("So_tien_mien_giam") = Tong_tien_mien_giam
            row("So_tien_nop") = Tong_tien_nop
            row("So_tien_da_nop") = Tong_tien_da_nop
            row("Thieu_thua") = Tong_Thieu_thua
            dt.Rows.Add(row)
            dt.AcceptChanges()
            Return dt
        End Function
        Public Function HienThi_ESSBienLaiThu(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThu(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThu_DanhSach(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSo_phieu() As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.getSo_phieu()
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_bien_lai(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal Lan_thu As Integer, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.getID_bien_lai(ID_sv, Hoc_ky, Nam_hoc, Dot_thu, Lan_thu, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getID_sv(ByVal Ma_sv As String) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.getID_sv(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiChiTiet(ByVal ID_bien_lai As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThuChiTiet(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiChiTiet_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal ID_thu_chi As Integer, ByVal Thu_chi As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThuChiTiet_DanhSach(Hoc_ky, Nam_hoc, dsID_lop, ID_thu_chi, Thu_chi)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBienLaiThu(ByVal objBienLaiThu As ESSBienLaiThu) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.ThemMoi_ESSBienLaiThu(objBienLaiThu)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThu(ByVal objBienLaiThu As ESSBienLaiThu, ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.CapNhat_ESSBienLaiThu(objBienLaiThu, ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThu_HuyPhieu(ByVal ID_bien_lai As Integer, ByVal Ly_do As String) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.CapNhat_ESSBienLaiThu_HuyPhieu(ID_bien_lai, Ly_do)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThu(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Xoa_ESSBienLaiThu(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSBienLaiThuChiTiet(ByVal objBienLaiThuChiTiet As ESSBienLaiThuChiTiet) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.ThemMoi_ESSBienLaiThuChiTiet(objBienLaiThuChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSBienLaiThuChiTiet(ByVal objBienLaiThuChiTiet As ESSBienLaiThuChiTiet, ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.CapNhat_ESSBienLaiThuChiTiet(objBienLaiThuChiTiet, ID_bien_lai_sub)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThuChiTiet(ByVal ID_bien_lai_sub As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Xoa_ESSBienLaiThuChiTiet(ID_bien_lai_sub)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSBienLaiThuChiTiet_IDBienLai(ByVal ID_bien_lai As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Xoa_ESSBienLaiThuChiTiet_IDBienLai(ID_bien_lai)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function MappingBienLaiThu(ByVal drBienLaiThu As DataRow) As ESSBienLaiThu
            Dim result As ESSBienLaiThu
            Try
                result = New ESSBienLaiThu
                result.Ma_sv = drBienLaiThu("Ma_sv").ToString()
                result.Ho_ten = drBienLaiThu("Ho_ten").ToString()
                result.Ten_lop = drBienLaiThu("Ten_lop").ToString()
                If drBienLaiThu("ID_bien_lai").ToString() <> "" Then result.ID_bien_lai = CType(drBienLaiThu("ID_bien_lai").ToString(), Integer)
                If drBienLaiThu("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drBienLaiThu("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drBienLaiThu("Nam_hoc").ToString()
                If drBienLaiThu("Dot_thu").ToString() <> "" Then result.Dot_thu = CType(drBienLaiThu("Dot_thu").ToString(), Integer)
                If drBienLaiThu("Lan_thu").ToString() <> "" Then result.Lan_thu = CType(drBienLaiThu("Lan_thu").ToString(), Integer)
                If drBienLaiThu("ID_sv").ToString() <> "" Then result.ID_sv = CType(drBienLaiThu("ID_sv").ToString(), Integer)
                result.Thu_chi = drBienLaiThu("Thu_chi").ToString()
                If drBienLaiThu("So_phieu").ToString() <> "" Then result.So_phieu = CType(drBienLaiThu("So_phieu").ToString(), Integer)
                If drBienLaiThu("Ngay_thu").ToString() <> "" Then result.Ngay_thu = CType(drBienLaiThu("Ngay_thu").ToString(), Date)
                result.Noi_dung = drBienLaiThu("Noi_dung").ToString()
                result.So_tien = drBienLaiThu("So_tien").ToString()
                result.So_tien_chu = drBienLaiThu("So_tien_chu").ToString()
                result.Ngoai_te = drBienLaiThu("Ngoai_te").ToString()
                result.Huy_phieu = drBienLaiThu("Huy_phieu").ToString()
                result.Ghi_chu = drBienLaiThu("Ghi_chu").ToString()
                result.Nguoi_thu = drBienLaiThu("Nguoi_thu").ToString()
                result.Printed = drBienLaiThu("Printed").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        Private Function MappingBienLaiThuChiTiet(ByVal drsvBienLaiThuChiTiet As DataRow) As ESSBienLaiThuChiTiet
            Dim result As ESSBienLaiThuChiTiet
            Try
                result = New ESSBienLaiThuChiTiet
                If drsvBienLaiThuChiTiet("ID_bien_lai_sub").ToString() <> "" Then result.ID_bien_lai_sub = CType(drsvBienLaiThuChiTiet("ID_bien_lai_sub").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_bien_lai").ToString() <> "" Then result.ID_bien_lai = CType(drsvBienLaiThuChiTiet("ID_bien_lai").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_thu_chi").ToString() <> "" Then result.ID_thu_chi = CType(drsvBienLaiThuChiTiet("ID_thu_chi").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_mon").ToString() <> "" Then result.ID_mon = CType(drsvBienLaiThuChiTiet("ID_mon").ToString(), Integer)
                If drsvBienLaiThuChiTiet("ID_mon_tc").ToString() <> "" Then result.ID_mon_tc = CType(drsvBienLaiThuChiTiet("ID_mon_tc").ToString(), Integer)
                result.Ky_hieu_lop_tc = drsvBienLaiThuChiTiet("Ky_hieu_lop_tc").ToString()
                If drsvBienLaiThuChiTiet("So_tien").ToString() <> "" Then result.So_tien = CType(drsvBienLaiThuChiTiet("So_tien").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
#Region "Tổng hợp các khoản thu khác"
        Public Function TongHop_DanhSachSv_Nop_HocKy(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal Toan_khoa As Boolean, ByVal ID_thu_chi As Integer) As DataTable
            Dim dtKhoanNop As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ của các sinh viên
            If Toan_khoa Then
                dtKhoanNop = obj.HienThi_ESSDanhSachSinhVienKhoanNop_HocKy_DanhSach(0, "", dsID_lop)
            Else
                dtKhoanNop = obj.HienThi_ESSDanhSachSinhVienKhoanNop_HocKy_DanhSach(Hoc_ky, Nam_hoc, dsID_lop)
            End If
            'Add thêm cột số tiền                        
            dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtKhoanNop.Columns.Add("Thieu_thua", GetType(Integer))
            ' Xóa bỏ những khoản phải nộp ngoài học kỳ tổng hợp nếu tổng hợp từ đầu khóa học đến kỳ được chọn
            For i As Integer = dtKhoanNop.Rows.Count - 1 To 0 Step -1
                If Toan_khoa Then
                    If dtKhoanNop.Rows(i)("Nam_hoc").ToString.Substring(5, 4) > Nam_hoc.Substring(5, 4) Then
                        dtKhoanNop.Rows(i).Delete()
                    ElseIf dtKhoanNop.Rows(i)("Nam_hoc").ToString.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                        If dtKhoanNop.Rows(i)("Hoc_ky") > Hoc_ky Then
                            dtKhoanNop.Rows(i).Delete()
                        End If
                    End If
                End If
            Next
            dtKhoanNop.AcceptChanges()
            'Tính các cột số tiền
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(dtKhoanNop.Rows(i)("Hoc_ky"), dtKhoanNop.Rows(i)("Nam_hoc"), CInt(dtKhoanNop.Rows(i)("ID_sv")))
                If clsMGHP.Count > 0 Then
                    Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
                Else
                    Phan_tram_MG = 0
                End If
                If dtKhoanNop.Rows(i)("Hoc_phi") And Phan_tram_MG > 0 Then
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = (dtKhoanNop.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtKhoanNop.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtKhoanNop.Rows(i)("So_tien_nop") = dtKhoanNop.Rows(i)("So_tien") - dtKhoanNop.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtKhoanNop.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBL As ESSBienLaiThu
                    objBL = CType(arrBienLaiThu(j), ESSBienLaiThu)
                    Dim objBLChiTiet As ESSBienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), ESSBienLaiThu).dsBienLaiChiTiet
                    If objBL.ID_sv = dtKhoanNop.Rows(i)("ID_sv") And objBL.Huy_phieu = False And objBL.Hoc_ky = dtKhoanNop.Rows(i)("Hoc_ky") And objBL.Nam_hoc = dtKhoanNop.Rows(i)("Nam_hoc") Then ' Nếu đã nộp
                        idx = objBL.dsBienLaiChiTiet.Tim_idx(objBL.ID_bien_lai, dtKhoanNop.Rows(i)("ID_thu_chi"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtKhoanNop.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtKhoanNop.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtKhoanNop.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtKhoanNop.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_thu_chi", GetType(Integer))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
            Dim row As DataRow
            Dim ID_sv As Integer = 0
            For Each r As DataRow In dtKhoanNop.Rows
                If ID_sv <> r("ID_sv") Then
                    Dim Tong_tien As Integer = 0
                    Dim Tong_tien_mien_giam As Integer = 0
                    Dim Tong_tien_nop As Integer = 0
                    Dim Tong_tien_da_nop As Integer = 0
                    Dim Tong_Thieu_thua As Integer = 0
                    Tinh_tien(dtKhoanNop, r, ID_thu_chi, Tong_tien, Tong_tien_mien_giam, Tong_tien_nop, Tong_tien_da_nop, Tong_Thieu_thua)
                    row = dt.NewRow
                    row("ID_sv") = r("ID_sv")
                    row("Ma_sv") = r("Ma_sv")
                    row("Ho_ten") = r("Ho_ten")
                    row("Ngay_sinh") = r("Ngay_sinh")
                    row("Ten_lop") = r("Ten_lop")
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    row("ID_thu_chi") = r("ID_thu_chi")
                    row("So_tien") = Tong_tien
                    row("So_tien_mien_giam") = Tong_tien_mien_giam
                    row("So_tien_nop") = Tong_tien_nop
                    row("So_tien_da_nop") = Tong_tien_da_nop
                    row("Thieu_thua") = Tong_Thieu_thua
                    If Tong_Thieu_thua <= 0 Then
                        row("Hoan_thanh_nop") = 1
                    Else
                        row("Hoan_thanh_nop") = 0
                    End If
                    If Tong_tien > 0 And Tong_tien_nop > 0 Then dt.Rows.Add(row) ' Nếu phải nộp tiền và sau khi miễn giảm vẫn phải nộp thêm thì add
                    ID_sv = r("ID_sv")
                End If
            Next
            dt.AcceptChanges()
            dt.DefaultView.AllowDelete = False
            dt.DefaultView.AllowEdit = False
            dt.DefaultView.AllowNew = False
            Return dt
        End Function
        Private Sub Tinh_tien(ByVal dtKhoanNop As DataTable, ByVal r As DataRow, ByVal ID_thu_chi As Integer, ByRef Tong_tien As Integer, ByRef Tong_tien_mien_giam As Integer, ByRef Tong_tien_nop As Integer, ByRef Tong_tien_da_nop As Integer, ByRef Tong_Thieu_thua As Integer)
            Try
                For Each dr As DataRow In dtKhoanNop.Rows
                    If ID_thu_chi > 0 Then
                        If dr("ID_sv") = r("ID_sv") And dr("ID_thu_chi") = ID_thu_chi Then
                            Tong_tien += dr("So_tien")
                            Tong_tien_mien_giam += dr("So_tien_mien_giam")
                            Tong_tien_nop += dr("So_tien_nop")
                            ' Nếu học kỳ và năm học đã có tiền nộp
                            If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                Tong_tien_da_nop += dr("So_tien_da_nop")
                            End If
                        End If
                    Else
                        If dr("ID_sv") = r("ID_sv") Then
                            Tong_tien += dr("So_tien")
                            Tong_tien_mien_giam += dr("So_tien_mien_giam")
                            Tong_tien_nop += dr("So_tien_nop")
                            ' Nếu học kỳ và năm học đã có tiền nộp
                            If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                Tong_tien_da_nop += dr("So_tien_da_nop")
                            End If
                        End If
                    End If
                Next
                Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function DanhSachBienLaiThuHocKy_SinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Toan_khoa As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai      
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("Ngay_sinh", GetType(Date))
            dtDanhSach.Columns.Add("Hoc_ky", GetType(Integer))
            dtDanhSach.Columns.Add("Nam_hoc", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As ESSBienLaiThu = CType(arrBienLaiThu(i), ESSBienLaiThu)
                Dim dr As DataRow = dtDanhSach.NewRow
                dr("Ma_sv") = objBL.Ma_sv
                dr("Ho_ten") = objBL.Ho_ten
                dr("Ngay_sinh") = objBL.Ngay_sinh
                dr("Hoc_ky") = objBL.Hoc_ky
                dr("Nam_hoc") = objBL.Nam_hoc
                dr("So_phieu") = objBL.So_phieu
                dr("Ngay_thu") = objBL.Ngay_thu
                dr("Noi_dung") = objBL.Noi_dung
                dr("ID_bien_lai") = objBL.ID_bien_lai
                So_tien = 0
                For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                    If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                Next
                If So_tien > 0 Then
                    dr("So_tien") = So_tien
                End If
                If Toan_khoa Then
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        If objBL.Nam_hoc.Substring(5, 4) < Nam_hoc.Substring(5, 4) Then
                            dtDanhSach.Rows.Add(dr)
                        ElseIf objBL.Nam_hoc.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                            If objBL.Hoc_ky <= Hoc_ky Then
                                dtDanhSach.Rows.Add(dr)
                            End If
                        End If
                    End If
                Else
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function
#End Region
#Region "Tổng hợp học phí"
        Public Function TongHop_DanhSachSv_Nop_HocPhi_1(ByVal dtSv As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal id_mon As String) As DataTable
            Try
                ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_thu_chi", GetType(Integer))
                dt.Columns.Add("So_tien", GetType(Double))
                dt.Columns.Add("So_tien_mien_giam", GetType(Double))
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("Thieu_thua", GetType(Double))
                dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
                Dim row As DataRow
                For Each r As DataRow In dtSv.Rows
                    Dim dt_th As DataTable = TongHop_HocPhi(r("ID_sv"), r("Ngoai_ngan_sach"), ID_he, id_mon)
                    Dim dv As DataView = dt_th.DefaultView
                    dv.RowFilter = "Hoc_ky=" & Hoc_ky & " AND Nam_hoc='" & Nam_hoc & "'"
                    row = dt.NewRow
                    row("ID_sv") = r("ID_sv")
                    row("Ma_sv") = r("Ma_sv")
                    row("Ho_ten") = r("Ho_ten")
                    row("Ngay_sinh") = r("Ngay_sinh")
                    row("Ten_lop") = r("Ten_lop")
                    row("ID_lop") = r("ID_lop")
                    row("Ten_khoa") = r("Ten_khoa")
                    row("Khoa_hoc") = r("Khoa_hoc")
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    If dv.Count > 0 Then
                        row("So_tien") = CInt("0" & dv(0)("So_tien_phai_nop"))
                        row("So_tien_mien_giam") = CInt("0" & dv(0)("So_tien_mien_giam"))
                        row("So_tien_nop") = CInt("0" & dv(0)("So_tien_nop"))
                        row("So_tien_da_nop") = CInt("0" & dv(0)("So_tien_da_nop"))
                        row("Thieu_thua") = dv(0)("Thieu_thua")
                        If id_mon >= 0 Then
                            row("Thieu_thua") = CInt(row("So_tien_nop")) - CInt(row("So_tien_da_nop"))
                        End If
                        If IIf(row("Thieu_thua").ToString = "", 0, row("Thieu_thua")) <= 0 Then
                            row("Hoan_thanh_nop") = 1
                        Else
                            row("Hoan_thanh_nop") = 0
                        End If
                    End If
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocPhi_2(ByVal dtSv As DataTable, ByVal ID_he As Integer) As DataTable
            Try
                ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("ID_thu_chi", GetType(Integer))
                dt.Columns.Add("So_tien", GetType(Double))
                dt.Columns.Add("So_tien_mien_giam", GetType(Double))
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("So_tien_tra_lai", GetType(Double))
                dt.Columns.Add("Thieu_thua", GetType(Double))
                dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
                Dim row As DataRow
                For Each r As DataRow In dtSv.Rows
                    Dim dt_th As DataTable = TongHop_HocPhi(r("ID_sv"), r("Ngoai_ngan_sach"), ID_he)
                    Dim dv As DataView = dt_th.DefaultView
                    row = dt.NewRow
                    row("ID_sv") = r("ID_sv")
                    row("Ma_sv") = r("Ma_sv")
                    row("Ho_ten") = r("Ho_ten")
                    row("Ngay_sinh") = r("Ngay_sinh")
                    row("Ten_lop") = r("Ten_lop")
                    row("ID_lop") = r("ID_lop")
                    row("Ten_khoa") = r("Ten_khoa")
                    row("Khoa_hoc") = r("Khoa_hoc")
                    row("So_tien") = 0
                    row("So_tien_mien_giam") = 0
                    row("So_tien_nop") = 0
                    row("So_tien_da_nop") = 0
                    row("So_tien_tra_lai") = 0
                    row("Thieu_thua") = 0
                    If dv.Count > 0 Then
                        For i As Integer = 0 To dv.Count - 1
                            row("So_tien") += CInt("0" & dv(i)("So_tien_phai_nop"))
                            row("So_tien_mien_giam") += CInt("0" & dv(i)("So_tien_mien_giam"))
                            row("So_tien_nop") += CInt("0" & dv(i)("So_tien_nop"))
                            row("So_tien_da_nop") += CInt("0" & dv(i)("So_tien_da_nop"))
                            row("So_tien_tra_lai") += CInt("0" & dv(i)("So_tien_tra_lai"))
                            row("Thieu_thua") += dv(i)("Thieu_thua")
                            If IIf(row("Thieu_thua").ToString = "", 0, row("Thieu_thua")) <= 0 Then
                                row("Hoan_thanh_nop") = 1
                            Else
                                row("Hoan_thanh_nop") = 0
                            End If
                        Next
                    End If
                    dt.Rows.Add(row)
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocPhi(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dsID_lop As String, ByVal Toan_khoa As Boolean, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByVal ID_he As Integer) As DataTable


            Dim dtHocPhanThu As New DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim Phan_tram_MG, idx As Integer
            'Lấy danh sách các khoản nộp trong học kỳ của các sinh viên
            If Toan_khoa Then
                dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKyDanhSach_DanhSach(0, "", 0, dsID_lop)
            Else
                dtHocPhanThu = obj.HienThi_ESSBienLaiThu_MonDangKyDanhSach_DanhSach(Hoc_ky, Nam_hoc, 0, dsID_lop)
            End If
            'Add thêm cột số tiền                        
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Thieu_thua", GetType(Integer))
            ' Xóa bỏ những khoản phải nộp ngoài học kỳ tổng hợp nếu tổng hợp từ đầu khóa học đến kỳ được chọn
            For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                If Toan_khoa Then
                    If dtHocPhanThu.Rows(i)("Nam_hoc").ToString.Substring(5, 4) > Nam_hoc.Substring(5, 4) Then
                        dtHocPhanThu.Rows(i).Delete()
                    ElseIf dtHocPhanThu.Rows(i)("Nam_hoc").ToString.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                        If dtHocPhanThu.Rows(i)("Hoc_ky") > Hoc_ky Then
                            dtHocPhanThu.Rows(i).Delete()
                        End If
                    End If
                End If
            Next
            dtHocPhanThu.AcceptChanges()
            'Lấy đơn giá

            'Hoc_lai = CType(dtMon.Rows(i)("Hoc_lai"), Boolean)
            'Nganh2 = CType(dtMon.Rows(i)("Chuyen_nganh2"), Boolean)
            'Phan_tram_MG = dtMon.Rows(i)("Phan_tram_mien_giam")
            ''Lấy đơn giá của tính chất học phần
            'Don_gia = 0
            'If dtMucHocPhi.Rows.Count > 0 Then
            '    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
            '        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
            '            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
            '            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
            '            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
            '            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
            '            Exit For
            '        End If
            '    Next
            'End If
            'Tính các cột số tiền
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(dtHocPhanThu.Rows(i)("Hoc_ky"), dtHocPhanThu.Rows(i)("Nam_hoc"), CInt(dtHocPhanThu.Rows(i)("ID_sv")))
                If clsMGHP.Count > 0 Then
                    Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
                Else
                    Phan_tram_MG = 0
                End If
                If dtHocPhanThu.Rows(i)("Hoc_lai") = False And Phan_tram_MG > 0 Then
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = (dtHocPhanThu.Rows(i)("So_tien") * Phan_tram_MG / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm 
                Else
                    dtHocPhanThu.Rows(i)("So_tien_mien_giam") = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien_nop") = dtHocPhanThu.Rows(i)("So_tien") - dtHocPhanThu.Rows(i)("So_tien_mien_giam")
            Next

            ' Tổng hợp các biên lai điền số tiền đã nộp vào các khoản nộp         
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                Dim Tong_So_tien_da_nop As Integer = 0
                Dim Thieu_thua As Integer = 0
                For j As Integer = 0 To arrBienLaiThu.Count - 1
                    Dim objBL As ESSBienLaiThu
                    objBL = CType(arrBienLaiThu(j), ESSBienLaiThu)
                    Dim objBLChiTiet As ESSBienLaiThuChiTiet
                    objBLChiTiet = CType(arrBienLaiThu(j), ESSBienLaiThu).dsBienLaiChiTiet
                    If objBL.ID_sv = dtHocPhanThu.Rows(i)("ID_sv") And objBL.Huy_phieu = False And objBL.Hoc_ky = dtHocPhanThu.Rows(i)("Hoc_ky") And objBL.Nam_hoc = dtHocPhanThu.Rows(i)("Nam_hoc") Then ' Nếu đã nộp
                        idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                        If idx >= 0 Then
                            Tong_So_tien_da_nop += objBLChiTiet.BienLaiChiTiet(idx).So_tien
                            Thieu_thua += dtHocPhanThu.Rows(i)("So_tien_nop") - objBLChiTiet.BienLaiChiTiet(idx).So_tien
                        End If
                    End If
                Next
                dtHocPhanThu.Rows(i)("So_tien_da_nop") = Tong_So_tien_da_nop
                dtHocPhanThu.Rows(i)("Thieu_thua") = Thieu_thua
            Next
            dtHocPhanThu.AcceptChanges()
            ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
            Dim dt As New DataTable
            dt.Columns.Add("ID_sv", GetType(Integer))
            dt.Columns.Add("Ma_sv", GetType(String))
            dt.Columns.Add("Ho_ten", GetType(String))
            dt.Columns.Add("Ngay_sinh", GetType(Date))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Hoc_ky", GetType(String))
            dt.Columns.Add("Nam_hoc", GetType(String))
            dt.Columns.Add("ID_thu_chi", GetType(Integer))
            dt.Columns.Add("So_tien", GetType(Integer))
            dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dt.Columns.Add("So_tien_nop", GetType(Integer))
            dt.Columns.Add("So_tien_da_nop", GetType(Integer))
            dt.Columns.Add("Thieu_thua", GetType(Integer))
            dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
            Dim row As DataRow
            Dim ID_sv As Integer = 0
            For Each r As DataRow In dtHocPhanThu.Rows
                If ID_sv <> r("ID_sv") Then
                    Dim Tong_tien As Integer = 0
                    Dim Tong_tien_mien_giam As Integer = 0
                    Dim Tong_tien_nop As Integer = 0
                    Dim Tong_tien_da_nop As Integer = 0
                    Dim Tong_Thieu_thua As Integer = 0
                    Tinh_tien_Hoc_phan(dtHocPhanThu, r, ID_mon, Ky_hieu_lop_tc, Tong_tien, Tong_tien_mien_giam, Tong_tien_nop, Tong_tien_da_nop, Tong_Thieu_thua)
                    ' Tổng hợp số tiền nộp học phí theo kỳ
                    Dim dtHP_Ky As DataTable
                    dtHP_Ky = TongHop_NopHocPhi_HocKy(r("Hoc_ky"), r("Nam_hoc"), ID_sv)
                    If dtHP_Ky.Rows.Count > 0 Then
                        For Each r1 As DataRow In dtHP_Ky.Rows
                            Tong_tien += r1("So_tien")
                            Tong_tien_mien_giam += r1("So_tien_mien_giam")
                            Tong_tien_nop += r1("So_tien_nop")
                            Tong_tien_da_nop += r1("So_tien_da_nop")
                        Next
                    End If
                    row = dt.NewRow
                    row("ID_sv") = r("ID_sv")
                    row("Ma_sv") = r("Ma_sv")
                    row("Ho_ten") = r("Ho_ten")
                    row("Ngay_sinh") = r("Ngay_sinh")
                    row("Ten_lop") = r("Ten_lop")
                    row("Hoc_ky") = Hoc_ky
                    row("Nam_hoc") = Nam_hoc
                    row("So_tien") = Tong_tien
                    row("So_tien_mien_giam") = Tong_tien_mien_giam
                    row("So_tien_nop") = Tong_tien_nop
                    row("So_tien_da_nop") = Tong_tien_da_nop
                    row("Thieu_thua") = Tong_Thieu_thua
                    If Tong_Thieu_thua <= 0 Then
                        row("Hoan_thanh_nop") = 1
                    Else
                        row("Hoan_thanh_nop") = 0
                    End If
                    If Tong_tien > 0 And Tong_tien_nop > 0 Then dt.Rows.Add(row) ' Nếu phải nộp tiền và sau khi miễn giảm vẫn phải nộp thêm thì add
                    ID_sv = r("ID_sv")
                End If
            Next
            dt.AcceptChanges()
            dt.DefaultView.AllowDelete = False
            dt.DefaultView.AllowEdit = False
            dt.DefaultView.AllowNew = False
            Return dt
        End Function
        Private Sub Tinh_tien_Hoc_phan(ByVal dtHocPhanThu As DataTable, ByVal r As DataRow, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByRef Tong_tien As Integer, ByRef Tong_tien_mien_giam As Integer, ByRef Tong_tien_nop As Integer, ByRef Tong_tien_da_nop As Integer, ByRef Tong_Thieu_thua As Integer)
            Try
                For Each dr As DataRow In dtHocPhanThu.Rows
                    If ID_mon > 0 Then
                        If dr("ID_sv") = r("ID_sv") And dr("ID_mon") = ID_mon Then
                            If Ky_hieu_lop_tc <> "" Then
                                If dr("Ky_hieu_lop_tc") = Ky_hieu_lop_tc Then
                                    Tong_tien += dr("So_tien")
                                    Tong_tien_mien_giam += dr("So_tien_mien_giam")
                                    Tong_tien_nop += dr("So_tien_nop")
                                    ' Nếu học kỳ và năm học đã có tiền nộp
                                    If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                        Tong_tien_da_nop += dr("So_tien_da_nop")
                                    End If
                                End If
                            Else
                                Tong_tien += dr("So_tien")
                                Tong_tien_mien_giam += dr("So_tien_mien_giam")
                                Tong_tien_nop += dr("So_tien_nop")
                                ' Nếu học kỳ và năm học đã có tiền nộp
                                If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                    Tong_tien_da_nop += dr("So_tien_da_nop")
                                End If
                            End If
                        End If
                    Else
                        If dr("ID_sv") = r("ID_sv") Then
                            Tong_tien += dr("So_tien")
                            Tong_tien_mien_giam += dr("So_tien_mien_giam")
                            Tong_tien_nop += dr("So_tien_nop")
                            ' Nếu học kỳ và năm học đã có tiền nộp
                            If IIf(dr("So_tien_da_nop").ToString = "", 0, dr("So_tien_da_nop")) <> 0 Then
                                Tong_tien_da_nop += dr("So_tien_da_nop")
                            End If
                        End If
                    End If
                Next
                Tong_Thieu_thua = Tong_tien_nop - Tong_tien_da_nop
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function DanhSachBienLaiThuHocPhiMon_SinhVien(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String, ByVal Toan_khoa As Boolean) As DataTable
            Dim dtDanhSach As New DataTable
            Dim So_tien As Integer
            'Add thêm các cột về biên lai      
            dtDanhSach.Columns.Add("Ma_sv", GetType(String))
            dtDanhSach.Columns.Add("Ho_ten", GetType(String))
            dtDanhSach.Columns.Add("Ngay_sinh", GetType(Date))
            dtDanhSach.Columns.Add("Hoc_ky", GetType(Integer))
            dtDanhSach.Columns.Add("Nam_hoc", GetType(String))
            dtDanhSach.Columns.Add("So_phieu", GetType(Integer))
            dtDanhSach.Columns.Add("Ngay_thu", GetType(Date))
            dtDanhSach.Columns.Add("So_tien", GetType(Integer))
            dtDanhSach.Columns.Add("Noi_dung", GetType(String))
            dtDanhSach.Columns.Add("ID_bien_lai", GetType(Integer))
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim objBL As ESSBienLaiThu = CType(arrBienLaiThu(i), ESSBienLaiThu)
                Dim dr As DataRow = dtDanhSach.NewRow
                dr("Ma_sv") = objBL.Ma_sv
                dr("Ho_ten") = objBL.Ho_ten
                dr("Ngay_sinh") = objBL.Ngay_sinh
                dr("Hoc_ky") = objBL.Hoc_ky
                dr("Nam_hoc") = objBL.Nam_hoc
                dr("So_phieu") = objBL.So_phieu
                dr("Ngay_thu") = objBL.Ngay_thu
                dr("Noi_dung") = objBL.Noi_dung
                dr("ID_bien_lai") = objBL.ID_bien_lai
                So_tien = 0
                For j As Integer = 0 To objBL.dsBienLaiChiTiet.Count - 1
                    If ID_mon > 0 Then ' Nếu theo môn chon
                        If Ky_hieu_lop_tc <> "" Then
                            If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = ID_mon And objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).Ky_hieu_lop_tc = Ky_hieu_lop_tc Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                        Else
                            If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon = ID_mon Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                        End If
                    Else ' Không theo môn chọn tổng hợp ra tất cả các môn
                        If objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).ID_mon <> 0 Then So_tien += objBL.dsBienLaiChiTiet.BienLaiChiTiet(j).So_tien
                    End If
                Next
                If So_tien > 0 Then
                    dr("So_tien") = So_tien
                End If
                If Toan_khoa Then
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        If objBL.Nam_hoc.Substring(5, 4) < Nam_hoc.Substring(5, 4) Then
                            dtDanhSach.Rows.Add(dr)
                        ElseIf objBL.Nam_hoc.Substring(5, 4) = Nam_hoc.Substring(5, 4) Then
                            If objBL.Hoc_ky <= Hoc_ky Then
                                dtDanhSach.Rows.Add(dr)
                            End If
                        End If
                    End If
                Else
                    If dr("So_tien").ToString <> "" And objBL.Huy_phieu = 0 And objBL.ID_sv = ID_sv Then
                        dtDanhSach.Rows.Add(dr)
                    End If
                End If
            Next
            Return dtDanhSach
        End Function

        ' Tổng hợp thu học phí theo lớp
        Public Function TongHop_HocPhi_TheoLop(ByVal ID_sv As Integer, ByVal Ngoai_ngan_sach As Boolean, ByVal ID_he As Integer) As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim dtTongHop As New DataTable
            Dim dtKy, dtMon, dtNop As New DataTable
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Phan_tram_MG As Double
            Dim fg As Boolean = False
            dtTongHop.Columns.Add("Hoc_ky", GetType(String))
            dtTongHop.Columns.Add("Nam_hoc", GetType(String))
            dtTongHop.Columns.Add("So_tien_phai_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_nop", GetType(Integer))
            dtTongHop.Columns.Add("So_tien_da_nop", GetType(Integer))
            dtTongHop.Columns.Add("Thieu_thua", GetType(Integer))
            dtTongHop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtTongHop.Columns.Add("Don_gia", GetType(Integer))
            dtTongHop.Columns.Add("Phan_tram_mien_giam", GetType(Double))
            'Lấy các khoản phải nộp theo học kỳ
            dtKy = obj.TongHopThuHocKy(ID_sv)
            For i As Integer = 0 To dtKy.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtKy.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtKy.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + dtKy.Rows(i)("So_tien_phai_nop")
                        dtTongHop.Rows(j)("So_tien_mien_giam") += CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + dtKy.Rows(i)("So_tien_mien_giam")
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtKy.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtKy.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = dtKy.Rows(i)("So_tien_phai_nop")
                    dr("So_tien_mien_giam") = dtKy.Rows(i)("So_tien_mien_giam")
                    dr("So_tien_nop") = dtKy.Rows(i)("So_tien_phai_nop") - dtKy.Rows(i)("So_tien_mien_giam")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản phải nộp thông qua đăng ký học phần tín chỉ
            dtMon = obj.TongHopThuMonDangKy(ID_sv)
            Dim So_hoc_trinh As Integer = 0
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim dtMucHocPhi As DataTable = HienThi_ESSMucHocPhiTinChi_DanhSach(dtMon.Rows(i)("Hoc_ky"), dtMon.Rows(i)("Nam_hoc"), ID_he)
                Hoc_lai = CType(dtMon.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtMon.Rows(i)("Chuyen_nganh2"), Boolean)
                Phan_tram_MG = dtMon.Rows(i)("Phan_tram_mien_giam")
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                If dtMucHocPhi.Rows.Count > 0 Then
                    For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                        If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                            CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                            CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                            Exit For
                        End If
                    Next
                End If
                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dtMon.Rows(i)("He_so") * dtMon.Rows(i)("So_hoc_trinh")
                If Mien_giam And Phan_tram_MG > 0 Then
                    So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                Else
                    So_tien_mien_giam = 0
                End If
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtMon.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtMon.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_phai_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_phai_nop").ToString) + So_tien
                        dtTongHop.Rows(j)("So_tien_mien_giam") = CInt("0" + dtTongHop.Rows(j)("So_tien_mien_giam").ToString) + So_tien_mien_giam
                        dtTongHop.Rows(j)("So_tien_nop") = dtTongHop.Rows(j)("So_tien_phai_nop") - dtTongHop.Rows(j)("So_tien_mien_giam")
                        fg = True
                    End If
                Next
                So_hoc_trinh += IIf(dtMon.Rows(i)("So_hoc_trinh").ToString = "", 0, dtMon.Rows(i)("So_hoc_trinh"))
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtMon.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtMon.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = So_tien
                    dr("So_tien_mien_giam") = So_tien_mien_giam
                    dr("So_tien_nop") = So_tien - So_tien_mien_giam
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            'Lấy các khoản sinh viên đã nộp học phí 
            Dim ID_mon As Integer = 0
            If ID_mon = 0 Then
                dtNop = obj.TongHopDaNopHocPhi(ID_sv)
            Else
                dtNop = obj.TongHopDaNopHocPhiTheoMon(ID_sv, ID_mon)
            End If
            For i As Integer = 0 To dtNop.Rows.Count - 1
                fg = False
                For j As Integer = 0 To dtTongHop.Rows.Count - 1
                    If dtNop.Rows(i)("Hoc_ky") = dtTongHop.Rows(j)("Hoc_ky") And dtNop.Rows(i)("Nam_hoc") = dtTongHop.Rows(j)("Nam_hoc") Then
                        dtTongHop.Rows(j)("So_tien_da_nop") = CInt("0" + dtTongHop.Rows(j)("So_tien_da_nop").ToString) + dtNop.Rows(i)("So_tien_da_nop")
                        dtTongHop.Rows(j)("Thieu_thua") = dtTongHop.Rows(j)("So_tien_nop") - dtTongHop.Rows(j)("So_tien_da_nop")

                        fg = True
                    End If
                Next
                If fg = False Then
                    Dim dr As DataRow = dtTongHop.NewRow
                    dr("Hoc_ky") = dtNop.Rows(i)("Hoc_ky")
                    dr("Nam_hoc") = dtNop.Rows(i)("Nam_hoc")
                    dr("So_tien_phai_nop") = 0
                    dr("So_tien_mien_giam") = 0
                    dr("So_tien_da_nop") = dtNop.Rows(i)("So_tien_da_nop")
                    dtTongHop.Rows.Add(dr)
                End If
            Next
            For i As Integer = 0 To dtTongHop.Rows.Count - 1
                If dtTongHop.Rows(i)("So_tien_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_nop") = 0
                If dtTongHop.Rows(i)("So_tien_da_nop").ToString = "" Then dtTongHop.Rows(i)("So_tien_da_nop") = 0
                dtTongHop.Rows(i)("Thieu_thua") = dtTongHop.Rows(i)("So_tien_nop") - dtTongHop.Rows(i)("So_tien_da_nop")
                dtTongHop.Rows(i)("Don_gia") = Don_gia
                dtTongHop.Rows(i)("Phan_tram_mien_giam") = Phan_tram_MG
                dtTongHop.Rows(i)("So_hoc_trinh") = So_hoc_trinh
            Next
            Return dtTongHop
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocPhi_TheoLop(ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim dtSv As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dtSv = obj.HienThi_ESSDanhSachSv(dsID_lop)
                ' Tính tổng tiền đã nộp trong học kỳ của các khoản đã nộp
                Dim dt As New DataTable
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("ID_lop", GetType(Integer))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("Khoa_hoc", GetType(Integer))
                dt.Columns.Add("Hoc_ky", GetType(String))
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("So_hoc_trinh", GetType(Integer))
                dt.Columns.Add("Don_gia", GetType(Double))
                dt.Columns.Add("So_tien", GetType(Double))
                dt.Columns.Add("Phan_tram_mien_giam", GetType(Double))
                dt.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("Thieu_thua", GetType(Integer))
                dt.Columns.Add("Hoan_thanh_nop", GetType(Byte))
                Dim row As DataRow
                For Each r As DataRow In dtSv.Rows
                    Dim dt_th As DataTable = TongHop_HocPhi_TheoLop(r("ID_sv"), r("Ngoai_ngan_sach"), ID_he)
                    If dt_th.Rows.Count > 0 Then
                        row = dt.NewRow
                        row("Ho_ten") = r("Ho_ten")
                        row("Ho_ten") = r("Ho_ten")
                        row("Ma_dt") = r("Ma_dt")
                        row("Ten_lop") = r("Ten_lop")
                        row("ID_lop") = r("ID_lop")
                        row("Ten_khoa") = r("Ten_khoa")
                        row("Khoa_hoc") = r("Khoa_hoc")
                        row("Hoc_ky") = Hoc_ky
                        row("Nam_hoc") = Nam_hoc
                        row("So_tien") = dt_th.Rows(0)("So_tien_phai_nop")
                        row("So_tien_mien_giam") = dt_th.Rows(0)("So_tien_mien_giam")
                        If IIf(dt_th.Rows(0)("So_tien_nop").ToString = "", 0, dt_th.Rows(0)("So_tien_nop")) > 0 Then row("So_tien_nop") = dt_th.Rows(0)("So_tien_nop")
                        If IIf(dt_th.Rows(0)("So_tien_da_nop").ToString = "", 0, dt_th.Rows(0)("So_tien_da_nop")) > 0 Then row("So_tien_da_nop") = dt_th.Rows(0)("So_tien_da_nop")
                        If IIf(dt_th.Rows(0)("Thieu_thua").ToString = "", 0, dt_th.Rows(0)("Thieu_thua")) > 0 Then row("Thieu_thua") = dt_th.Rows(0)("Thieu_thua")
                        If IIf(dt_th.Rows(0)("Thieu_thua").ToString = "", 0, dt_th.Rows(0)("Thieu_thua")) <= 0 Then
                            row("Hoan_thanh_nop") = 1
                        Else
                            row("Hoan_thanh_nop") = 0
                        End If
                        row("So_hoc_trinh") = dt_th.Rows(0)("So_hoc_trinh")
                        If IIf(dt_th.Rows(0)("Phan_tram_mien_giam").ToString = "", 0, dt_th.Rows(0)("Phan_tram_mien_giam")) > 0 Then row("Phan_tram_mien_giam") = dt_th.Rows(0)("Phan_tram_mien_giam")
                        If IIf(dt_th.Rows(0)("Don_gia").ToString = "", 0, dt_th.Rows(0)("Don_gia")) > 0 Then row("Don_gia") = dt_th.Rows(0)("Don_gia")
                        dt.Rows.Add(row)
                    End If
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowDelete = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowNew = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSLop_Khoa(ByVal Khoa_hoc As Integer) As DataTable
            Try
                Dim obj As New BienLaiThu_DataAccess
                Return obj.HienThi_ESSLop_Khoa(Khoa_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
#Region "Load tài chính Hồ Sơ sinh Viên"
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi(ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("So_tien_nop", GetType(Double))
                dt.Columns.Add("So_tien_hoan_tra", GetType(Double))
                dt.Columns.Add("So_tien_giam", GetType(Double))
                dt.Columns.Add("So_tien_da_nop", GetType(Double))
                dt.Columns.Add("So_tien_con_no", GetType(Double))
                Dim dr As DataRow
                Dim dtHP_Mon As New DataTable
                dtHP_Mon = DanhSachHocPhi_TheoMon(ID_sv, ID_thu_chi) ' Lấy danh sách nộp học phí theo môn               
                Dim dtHP_ky As DataTable
                dtHP_ky = DanhSachHocPhi_TheoHocKy(ID_sv) ' Lấy danh sách nộp học phí theo học kỳ
                Dim r As DataRow
                For i As Integer = 0 To dtHP_ky.Rows.Count - 1 ' Gộp 2 danh sách làm một
                    r = dtHP_Mon.NewRow
                    r("Nam_hoc") = dtHP_ky.Rows(i)("Nam_hoc")
                    r("So_tien_nop") = dtHP_ky.Rows(i)("So_tien_nop")
                    r("So_tien_mien_giam") = dtHP_ky.Rows(i)("So_tien_mien_giam")
                    dtHP_Mon.Rows.Add(r)
                Next
                Dim dtThuChi As DataTable
                dtThuChi = DanhSach_ThuChi() ' Danh sách thu chi
                Dim Nam_hoc As String = ""
                For i As Integer = 0 To dtHP_Mon.Rows.Count - 1 ' Tính toán dữ liêu của từng năm học
                    If Nam_hoc <> dtHP_Mon.Rows(i)("Nam_hoc") Then
                        dr = dt.NewRow
                        Dim So_tien_nop As Integer = 0
                        Dim So_tien_giam As Integer = 0
                        Dim So_tien_da_nop As Integer = 0
                        Dim So_tien_con_no As Integer = 0
                        Dim So_tien_hoan_tra As Integer = 0
                        For j As Integer = 0 To dtHP_Mon.Rows.Count - 1 ' Tính số tiền nộp và số tiền miễn giảm
                            If dtHP_Mon.Rows(i)("Nam_hoc") = dtHP_Mon.Rows(j)("Nam_hoc") Then
                                So_tien_nop += IIf(dtHP_Mon.Rows(j)("So_tien_nop").ToString = "", 0, dtHP_Mon.Rows(j)("So_tien_nop"))
                                So_tien_giam += IIf(dtHP_Mon.Rows(j)("So_tien_mien_giam").ToString = "", 0, dtHP_Mon.Rows(j)("So_tien_mien_giam"))
                            End If
                        Next
                        ' Lọc ra tiền nộp học phí của năm học
                        If dtThuChi.Rows.Count > 0 Then dtThuChi.DefaultView.RowFilter = "Thu_chi='Thu' And Hoc_phi=True And Nam_hoc='" & dtHP_Mon.Rows(i)("Nam_hoc") & "'"
                        If dtThuChi.DefaultView.Count > 0 Then
                            So_tien_da_nop = dtThuChi.DefaultView.Item(0)("So_tien")
                            So_tien_con_no = So_tien_nop - So_tien_da_nop
                            If So_tien_da_nop > So_tien_nop Then So_tien_hoan_tra = So_tien_da_nop - So_tien_nop
                        Else
                            So_tien_con_no = So_tien_nop
                        End If
                        dr("Nam_hoc") = dtHP_Mon.Rows(i)("Nam_hoc")
                        dr("So_tien_nop") = So_tien_nop
                        dr("So_tien_giam") = So_tien_giam
                        dr("So_tien_da_nop") = So_tien_da_nop
                        dr("So_tien_con_no") = So_tien_con_no
                        dr("So_tien_hoan_tra") = So_tien_hoan_tra
                        dt.Rows.Add(dr)
                        Nam_hoc = dtHP_Mon.Rows(i)("Nam_hoc")
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi_TheoMon(ByVal ID_sv As Integer, ByVal ID_thu_chi As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
                Dim dt As DataTable
                dt = obj.HienThi_ESSBienLaiThu_MonDangKy_DanhSach(0, "", -1, ID_sv)
                'Add thêm cột số tiền                
                Dim dtHocPhanThu As New DataTable
                dtHocPhanThu.Columns.Add("Hoc_ky", GetType(Integer))
                dtHocPhanThu.Columns.Add("Nam_hoc", GetType(String))
                dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(0, "", ID_sv)
                Dim dtMG As DataTable
                dtMG = clsMGHP.DanhSach_MG()
                'Tính các cột số tiền
                Dim r As DataRow
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim So_tien_mien_giam As Integer = 0
                    For j As Integer = 0 To dtMG.Rows.Count - 1
                        If dtMG.Rows(j)("Hoc_ky") = dt.Rows(i)("Hoc_ky") And dtMG.Rows(j)("Nam_hoc") = dt.Rows(i)("Nam_hoc") Then
                            So_tien_mien_giam += (dt.Rows(i)("So_tien") * dtMG.Rows(j)("Phan_tram") / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm                             
                        End If
                    Next
                    r = dtHocPhanThu.NewRow
                    r("Hoc_ky") = dt.Rows(i)("Hoc_ky")
                    r("Nam_hoc") = dt.Rows(i)("Nam_hoc")
                    r("So_tien_mien_giam") = So_tien_mien_giam
                    r("So_tien_nop") = dt.Rows(i)("So_tien") - So_tien_mien_giam
                    dtHocPhanThu.Rows.Add(r)
                Next
                Return dtHocPhanThu
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách khoản nộp học phí (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSachHocPhi_TheoHocKy(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                'Lấy danh sách các khoản nộp 
                Dim dt As DataTable
                dt = obj.HienThi_ESSKhoanNop_HocKy_DanhSach(0, "", ID_sv)
                'Add thêm cột số tiền     
                Dim dtKhoanNop As New DataTable
                dtKhoanNop.Columns.Add("Hoc_ky", GetType(Integer))
                dtKhoanNop.Columns.Add("Nam_hoc", GetType(String))
                dtKhoanNop.Columns.Add("So_tien_mien_giam", GetType(Integer))
                dtKhoanNop.Columns.Add("So_tien_nop", GetType(Integer))
                'Miễn giảm sinh viên
                Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(0, "", ID_sv)
                Dim dtMG As DataTable
                dtMG = clsMGHP.DanhSach_MG()
                'Tính các cột số tiền
                Dim r As DataRow
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    If dt.Rows(i)("Hoc_phi") Then
                        Dim So_tien_mien_giam As Integer = 0
                        For j As Integer = 0 To dtMG.Rows.Count - 1
                            If dtMG.Rows(j)("Hoc_ky") = dt.Rows(i)("Hoc_ky") And dtMG.Rows(j)("Nam_hoc") = dt.Rows(i)("Nam_hoc") Then
                                So_tien_mien_giam += (dt.Rows(i)("So_tien") * dtMG.Rows(j)("Phan_tram") / 100) ' Số tiền phải nộp * % miễn giảm / 100 = số tiền miễn giảm                             
                            End If
                        Next
                        r = dtKhoanNop.NewRow
                        r("Hoc_ky") = dt.Rows(i)("Hoc_ky")
                        r("Nam_hoc") = dt.Rows(i)("Nam_hoc")
                        r("So_tien_mien_giam") = So_tien_mien_giam
                        r("So_tien_nop") = dt.Rows(i)("So_tien") - So_tien_mien_giam
                        dtKhoanNop.Rows.Add(r)
                    End If
                Next
                dtKhoanNop.AcceptChanges()
                Return dtKhoanNop
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách thu chi của một sinh viên (Dùng cho load Hồ sơ sinh viên)
        Public Function DanhSach_ThuChi() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("Ten_thu_chi")
                dt.Columns.Add("So_tien", GetType(Integer))
                dt.Columns.Add("Thu_chi")
                dt.Columns.Add("Hoc_phi")
                Dim dr As DataRow
                Dim Nam_hoc As String = ""
                Dim Ten_thu_chi As String = ""
                Dim Thu_chi As Boolean = False
                For Each r As DataRow In dtDsThuChi.Rows
                    If Nam_hoc <> r("Nam_hoc") Or Ten_thu_chi <> r("Ten_thu_chi") Or Thu_chi <> r("Thu_chi") Then
                        dr = dt.NewRow
                        Dim So_tien As Integer = 0
                        For Each r1 As DataRow In dtDsThuChi.Rows
                            If r("Nam_hoc") = r1("Nam_hoc") And r("Ten_thu_chi") = r1("Ten_thu_chi") And r("Thu_chi") = r1("Thu_chi") Then
                                So_tien += r1("So_tien")
                            End If
                        Next
                        dr("Nam_hoc") = r("Nam_hoc")
                        dr("Ten_thu_chi") = r("Ten_thu_chi")
                        dr("So_tien") = So_tien
                        If r("Thu_chi") Then
                            dr("Thu_chi") = "Thu"
                        Else
                            dr("Thu_chi") = "Chi"
                        End If
                        dr("Hoc_phi") = r("Hoc_phi")
                        dt.Rows.Add(dr)
                        Nam_hoc = r("Nam_hoc")
                        Ten_thu_chi = r("Ten_thu_chi")
                        Thu_chi = r("Thu_chi")
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMucHocPhiTinChi_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim cls As New BienLaiThu_DataAccess
                Return cls.HienThi_ESSMucHocPhiTinChi_DanhSach(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSMucThiLai_DanhSach(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer) As DataTable
            Try
                Dim cls As New BienLaiThu_DataAccess
                Return cls.HienThi_ESSMucThiLai_DanhSach(Hoc_ky, Nam_hoc, ID_he)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region


        Public Sub AddHocPhi(ByRef dtDSSV As DataTable)
            Try
                dtDSSV.Columns.Add("Hoc_phi", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    dtDSSV.Rows(i)("Hoc_phi") = HocPhi_Ky(dtDSSV.Rows(i)("ID_sv"))
                Next
            Catch ex As Exception

            End Try
        End Sub
        Public Function HocPhi_Ky(ByVal id_sv As Integer) As String
            For i As Integer = 0 To arrBienLaiThu.Count - 1
                Dim obj As ESSBienLaiThu = CType(arrBienLaiThu(i), ESSBienLaiThu)
                If obj.ID_sv = id_sv Then
                    Return obj.So_tien.ToString
                End If
            Next
            Return ""
        End Function
        Public Function LoadBienLaiTheoID_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThu_ID_sv(ID_sv)
            Catch ex As Exception
                Return Nothing
            End Try
        End Function
        Public Function Search_BienLai(ByVal dsID_lop As String, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String) As DataTable
            Try
                Dim obj As New BienLaiThu_DataAccess
                Dim dt As DataTable
                dt = obj.Search_BienLai(dsID_lop, ID_mon, Ky_hieu_lop_tc)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Search_BienLai_Hoc_ky(ByVal dsID_lop As String) As DataTable
            Try
                Dim obj As New BienLaiThu_DataAccess
                Dim dt As DataTable
                dt = obj.Search_BienLai_Hoc_ky(dsID_lop)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_HocPhi_New(Optional ByVal TinhDenNgay As Object = "", Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal ID_mon_tc As Integer = 0, Optional ByVal Ky_hieu_lop_tc As String = "", Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_lops As String = "", Optional ByVal ID_sv As Integer = 0) As DataTable
            Try
                'Lấy và tính toán các khoản phải nộp thông qua đăng ký học phần tín chỉ
                Dim dt As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dt = obj.TongHopThuMonDangKy_New(CDate(TinhDenNgay), ID_he, Khoa_hoc, Ky_hieu_lop_tc, ID_mon_tc, Hoc_ky, Nam_hoc, ID_lops, ID_sv)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_HocPhi_New_ToanKhoa(Optional ByVal TinhDenNgay As Object = "", Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal ID_mon_tc As Integer = 0, Optional ByVal Ky_hieu_lop_tc As String = "", Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_lops As String = "", Optional ByVal ID_sv As Integer = 0) As DataTable
            Try
                'Lấy và tính toán các khoản phải nộp thông qua đăng ký học phần tín chỉ
                Dim dt As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dt = obj.TongHopThuMonDangKy_New_ToanKhoa(CDate(TinhDenNgay), ID_he, Khoa_hoc, Ky_hieu_lop_tc, ID_mon_tc, Hoc_ky, Nam_hoc, ID_lops, ID_sv)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Property BienLaiThu_ID_bien_lai(ByVal ID_bien_lai As Integer) As ESSBienLaiThu
            Get
                Dim BL As New ESSBienLaiThu
                For i As Integer = 0 To arrBienLaiThu.Count - 1
                    If CType(arrBienLaiThu(i), ESSBienLaiThu).ID_bien_lai = ID_bien_lai Then
                        BL = CType(arrBienLaiThu(i), ESSBienLaiThu)
                    End If
                Next
                Return BL
            End Get
            Set(ByVal Value As ESSBienLaiThu)
                For i As Integer = 0 To arrBienLaiThu.Count - 1
                    If CType(arrBienLaiThu(i), ESSBienLaiThu).ID_bien_lai = ID_bien_lai Then
                        arrBienLaiThu(i) = Value
                    End If
                Next
            End Set
        End Property
        Public Function TongHop_DanhSachSv_Nop_HocKy_New(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_lops As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_thu_chi As Integer = 0) As DataTable
            Try
                'Lấy và tính toán các khoản phải nộp thông qua đăng ký học phần tín chỉ
                Dim dt As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dt = obj.TongHop_DanhSachSv_Nop_HocKy_New(ID_he, Khoa_hoc, Hoc_ky, Nam_hoc, ID_lops, ID_sv, ID_thu_chi)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHop_DanhSachSv_Nop_HocKy_New_ToanKhoa(Optional ByVal ID_he As Integer = 0, Optional ByVal Khoa_hoc As Integer = 0, Optional ByVal Hoc_ky As Integer = 0, Optional ByVal Nam_hoc As String = "", Optional ByVal ID_lops As String = "", Optional ByVal ID_sv As Integer = 0, Optional ByVal ID_thu_chi As Integer = 0) As DataTable
            Try
                'Lấy và tính toán các khoản phải nộp thông qua đăng ký học phần tín chỉ
                Dim dt As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dt = obj.TongHop_DanhSachSv_Nop_HocKy_New_ToanKhoa(ID_he, Khoa_hoc, Hoc_ky, Nam_hoc, ID_lops, ID_sv, ID_thu_chi)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function DanhSach_BienLai_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As DataTable
                Dim obj As New BienLaiThu_DataAccess
                dt = obj.DanhSach_BienLai_SV(ID_sv)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThu_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThu_SV(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function HienThi_ESSBienLaiThuChiChiTiet_SV(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HienThi_ESSBienLaiThuChiTiet_SV(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function TongHopHocPhiSinhVien(ByVal ID_sv As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.TongHopHocPhiSinhVien(ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function Load_BienLaiThu_DanhSach_KhoanThu_TH(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_BienLaiThu_DanhSach_KhoanThu_TH(Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function BaoCao_DanhSach_CacKhoanThu_TheoSinHVien(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal dk As String) As DataTable
            Dim dtMain As DataTable = Load_BienLaiThu_DanhSachSV(Hoc_ky, Nam_hoc, dk)
            Dim dt_khoanthu As DataTable = Load_BienLaiThu_DanhSach_KhoanThu(Hoc_ky, Nam_hoc, dk)
            Dim dt_khoanthu_theosv As DataTable = Load_BienLaiThu_DanhSach_KhoanThuTheoSV(Hoc_ky, Nam_hoc, dk)
            For t As Integer = 0 To dtMain.Rows.Count - 1
                Dim Tong_tien As Integer = 0
                For i As Integer = 0 To dt_khoanthu.Rows.Count - 1
                    'Add them cot vao dtMain neu chua co
                    Dim col As New DataColumn()
                    col = New DataColumn("T" + dt_khoanthu.Rows(i)("ID_thu_chi").ToString)
                    If Not dtMain.Columns.Contains(col.ColumnName) Then
                        dtMain.Columns.Add(col)
                    End If
                    dt_khoanthu_theosv.DefaultView.RowFilter = "ID_sv=" & dtMain.Rows(t)("ID_SV") & " AND ID_thu_chi=" & dt_khoanthu.Rows(i)("ID_thu_chi")
                    If dt_khoanthu_theosv.DefaultView.Count > 0 Then
                        dtMain.Rows(t)("T" + dt_khoanthu.Rows(i)("ID_thu_chi").ToString) = dt_khoanthu_theosv.DefaultView.Item(0)("So_tien_thu")
                        Tong_tien = Tong_tien + dt_khoanthu_theosv.DefaultView.Item(0)("So_tien_thu")
                    End If
                Next
                dtMain.Rows(t)("Tong_tien_thu") = Tong_tien
            Next
            Return dtMain
        End Function

        Private Function Load_BienLaiThu_DanhSachSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_SVs As String) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_BienLaiThu_DanhSachSV(Hoc_ky, Nam_hoc, ID_SVs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Function Load_BienLaiThu_DanhSach_KhoanThu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_SVs As String) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_BienLaiThu_DanhSach_KhoanThu(Hoc_ky, Nam_hoc, ID_SVs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Load_BienLaiThu_DanhSach_KhoanThuTheoSV(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_SVs As String) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.Load_BienLaiThu_DanhSach_KhoanThuTheoSV(Hoc_ky, Nam_hoc, ID_SVs)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TongHopHocPhiSinhVien_SoDuCuoiKy(ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Dim dt As DataTable = obj.TongHopHocPhiSinhVien_SoDuCuoiKy(ID_sv)
                If dt.Rows.Count > 0 Then
                    Return IIf(dt.Rows(0)("So_tien").ToString = "", 0, dt.Rows(0)("So_tien"))
                Else
                    Return 0
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function Load_MucHocPhiTinChi_List(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal Kinh_te As Boolean) As DataTable
            Try
                Dim cls As New BienLaiThu_DataAccess
                Return cls.Load_MucHocPhiTinChi_List(Hoc_ky, Nam_hoc, ID_he, Khoa_hoc, Kinh_te)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Function ChuanHoa_SoPhieu(ByVal So_phieu As Integer) As String
            Return Right("0000000" & So_phieu.ToString, 7)
        End Function

        Function HocPhan_DangKy_SinhVien(ByVal ID_SV As Integer) As DataTable
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Return obj.HocPhan_DangKy_SinhVien(ID_SV)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getSo_phieu(ByVal Thu_chi As Integer, ByVal Gian_thu As Integer, ByVal ID_he As Integer) As Long
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Dim So_phieu As Long = 0
                So_phieu = obj.getSo_phieu(Thu_chi, Gian_thu, ID_he)
                Return So_phieu
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function DanhSachHocPhanBienLaiThu_(ByVal dtMucHocPhi_Nganh2 As DataTable, ByVal dtMucHocPhi As DataTable, ByVal Ngoai_ngan_sach As Boolean, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal Dot_thu As Integer, ByVal ID_sv As Integer, ByVal idx_bl As Integer, Optional ByVal Lan_thu As Integer = 0, Optional ByVal Lop_chat_luong_cao As Boolean = False) As DataTable
            Dim dtHocPhanThu As New DataTable
            Dim dtHocPhanDaThu As DataTable
            Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
            Dim idx As Integer
            Dim Phan_tram_MG As Double
            Dim Hoc_lai, Nganh2, Mien_giam As Boolean
            Dim Don_gia, So_tien, So_tien_mien_giam As Integer
            Dim Tinh_chat_hoc_phi As String
            'Lấy danh sách các học phần sinh viên đăng ký trong học kỳ
            dtHocPhanThu = obj.Load_BienLaiThu_MonDangKy_List(Hoc_ky, Nam_hoc, Dot_thu, ID_sv)
            'Load hoc phần đã thu của các lần khác
            dtHocPhanDaThu = obj.Load_BienLaiThu_MonDaThu_List(Hoc_ky, Nam_hoc, ID_sv)
            'Add thêm cột số tiền
            dtHocPhanThu.Columns.Add("Chon", GetType(Boolean))
            dtHocPhanThu.Columns.Add("Ten_lop_tc", GetType(String))
            dtHocPhanThu.Columns.Add("So_tien_mien_giam", GetType(Integer))
            dtHocPhanThu.Columns.Add("So_tien_nop", GetType(Integer))
            dtHocPhanThu.Columns.Add("Tinh_chat", GetType(String))
            dtHocPhanThu.Columns.Add("Don_gia", GetType(Integer))
            'Miễn giảm sinh viên
            Dim clsMGHP As New DanhSachMienGiamHocPhi_Bussines(Hoc_ky, Nam_hoc, ID_sv)
            If clsMGHP.Count > 0 Then
                Phan_tram_MG = clsMGHP.MienGiamHocPhi(0).Phan_tram
            Else
                Phan_tram_MG = 0
            End If
            'Tính các cột số tiền học phí tùy thuộc vào tính chất
            For i As Integer = 0 To dtHocPhanThu.Rows.Count - 1
                dtHocPhanThu.Rows(i)("Chon") = False
                dtHocPhanThu.Rows(i)("Ten_lop_tc") = dtHocPhanThu.Rows(i)("Ky_hieu_lop_tc").ToString + "." + dtHocPhanThu.Rows(i)("STT_lop").ToString
                Hoc_lai = CType(dtHocPhanThu.Rows(i)("Hoc_lai"), Boolean)
                Nganh2 = CType(dtHocPhanThu.Rows(i)("Chuyen_nganh2"), Boolean)
                'Lấy đơn giá của tính chất học phần
                Don_gia = 0
                Tinh_chat_hoc_phi = ""
                If Nganh2 Then
                    If dtMucHocPhi_Nganh2.Rows.Count > 0 Then
                        For j As Integer = 0 To dtMucHocPhi_Nganh2.Rows.Count - 1
                            Don_gia = dtMucHocPhi_Nganh2.Rows(j)("So_tien")
                            Tinh_chat_hoc_phi = dtMucHocPhi_Nganh2.Rows(j)("Tinh_chat")
                            If CType(dtMucHocPhi_Nganh2.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Lop_chat_luong_cao"), Boolean) = Lop_chat_luong_cao And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                                CType(dtMucHocPhi_Nganh2.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                                Don_gia = dtMucHocPhi_Nganh2.Rows(j)("So_tien")
                                Mien_giam = dtMucHocPhi_Nganh2.Rows(j)("Mien_giam")
                                Tinh_chat_hoc_phi = dtMucHocPhi_Nganh2.Rows(j)("Tinh_chat")
                                Exit For
                            End If
                        Next
                    End If
                Else
                    If dtMucHocPhi.Rows.Count > 0 Then
                        For j As Integer = 0 To dtMucHocPhi.Rows.Count - 1
                            Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                            Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                            If CType(dtMucHocPhi.Rows(j)("Ngoai_ngan_sach"), Boolean) = Ngoai_ngan_sach And _
                                CType(dtMucHocPhi.Rows(j)("Lop_chat_luong_cao"), Boolean) = Lop_chat_luong_cao And _
                                CType(dtMucHocPhi.Rows(j)("Nganh2"), Boolean) = Nganh2 And _
                                CType(dtMucHocPhi.Rows(j)("Hoc_lai"), Boolean) = Hoc_lai Then
                                Don_gia = dtMucHocPhi.Rows(j)("So_tien")
                                Mien_giam = dtMucHocPhi.Rows(j)("Mien_giam")
                                Tinh_chat_hoc_phi = dtMucHocPhi.Rows(j)("Tinh_chat")
                                Exit For
                            End If
                        Next
                    End If
                End If

                'Số tiền của 1 học phần được tính theo (Tính chất) * (Hệ số HP) * (Số tín chỉ)
                So_tien = Don_gia * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                If Mien_giam And Phan_tram_MG > 0 Then
                    'So_tien_mien_giam = (So_tien * Phan_tram_MG / 100)
                    If Phan_tram_MG = 50 Then
                        So_tien_mien_giam = So_tien_mg_1_tc_50 * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                    ElseIf Phan_tram_MG = 100 Then
                        So_tien_mien_giam = So_tien_mg_1_tc_100 * dtHocPhanThu.Rows(i)("He_so") * dtHocPhanThu.Rows(i)("So_tin_chi")
                    End If
                Else
                    So_tien_mien_giam = 0
                End If
                dtHocPhanThu.Rows(i)("So_tien") = So_tien
                dtHocPhanThu.Rows(i)("So_tien_mien_giam") = So_tien_mien_giam
                dtHocPhanThu.Rows(i)("So_tien_nop") = So_tien - So_tien_mien_giam
                dtHocPhanThu.Rows(i)("Tinh_chat") = Tinh_chat_hoc_phi
                dtHocPhanThu.Rows(i)("Don_gia") = Don_gia
            Next
            If idx_bl >= 0 Then
                Dim objBLChiTiet As ESSBienLaiThuChiTiet
                objBLChiTiet = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu).dsBienLaiChiTiet
                Dim objBL As ESSBienLaiThu
                objBL = CType(arrBienLaiThu(idx_bl), ESSBienLaiThu)
                If Lan_thu <> 1 Then
                    'Duyệt xóa học phần đã thu của lần khác
                    For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                        For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                            If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") And _
                                dtHocPhanDaThu.Rows(j)("Lan_thu") <> objBL.Lan_thu Then
                                dtHocPhanThu.Rows(i).Delete()
                                dtHocPhanThu.AcceptChanges()
                                Exit For
                            End If
                        Next
                    Next
                End If
                'Tích chọn số môn đã thu lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    idx = objBL.dsBienLaiChiTiet.Tim_mon(objBL.ID_bien_lai, dtHocPhanThu.Rows(i)("ID_mon"))
                    If idx >= 0 Then
                        dtHocPhanThu.Rows(i)("Chon") = True
                    End If
                Next
            Else
                'Duyệt xóa học phần đã thu của lần trước
                For i As Integer = dtHocPhanThu.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtHocPhanDaThu.Rows.Count - 1
                        If dtHocPhanThu.Rows(i)("ID_mon_tc") = dtHocPhanDaThu.Rows(j)("ID_mon_tc") Then
                            dtHocPhanThu.Rows(i).Delete()
                            dtHocPhanThu.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
            End If
            Return dtHocPhanThu
        End Function

        Public Function TongHop_GhiChu_DiemDanh_ToChucThi(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_mon As Integer) As String
            Try
                Dim obj As BienLaiThu_DataAccess = New BienLaiThu_DataAccess
                Dim dt As DataTable = obj.TongHop_GhiChu_DiemDanh_ToChucThi(ID_sv, Hoc_ky, Nam_hoc, ID_mon)
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)("Ghi_chu").ToString
                Else
                    Return ""
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
    End Class
End Namespace