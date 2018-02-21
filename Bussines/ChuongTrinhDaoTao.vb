'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class ChuongTrinhDaoTao_Bussines
        Private arrChuongTrinhDaoTao As New ArrayList
#Region "Initialize"
        Public Sub New(ByVal dsID_dt As String)
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSChuongTrinhDaoTao_DanhSach(dsID_dt)
                Dim objsvChuongTrinhDaoTao As ESSChuongTrinhDaoTao = Nothing
                Dim dr As DataRow = Nothing
                arrChuongTrinhDaoTao = New ArrayList
                For Each dr In dt.Rows
                    objsvChuongTrinhDaoTao = Mapping(dr)
                    arrChuongTrinhDaoTao.Add(objsvChuongTrinhDaoTao)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Sub New(ByVal dsID_dt As String, ByVal ID_bm As Integer)
            Dim dtMon As DataTable
            Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
            'Load các học phần thuộc các chương trình đào
            dtMon = clsDAL.HienThi_ESSMonHocTrongCTDT(dsID_dt, ID_bm)
            For i As Integer = 0 To dtMon.Rows.Count - 1
                Dim objCTDT As New ESSChuongTrinhDaoTaoChiTiet
                objCTDT.ID_dt = dtMon.Rows(i)("ID_dt")
                objCTDT.ID_bm = dtMon.Rows(i)("ID_bm")
                objCTDT.ID_mon = dtMon.Rows(i)("ID_mon")
                objCTDT.Ky_hieu = dtMon.Rows(i)("Ky_hieu")
                objCTDT.Ten_mon = dtMon.Rows(i)("Ten_mon")
                objCTDT.So_hoc_trinh = dtMon.Rows(i)("So_hoc_trinh")
                objCTDT.Ky_thu = dtMon.Rows(i)("Ky_thu")
                'Load cac rang buoc học phan

                arrChuongTrinhDaoTao.Add(objCTDT)
            Next
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub Add(ByVal CTDT As ESSChuongTrinhDaoTao)
            arrChuongTrinhDaoTao.Add(CTDT)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            arrChuongTrinhDaoTao.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return Me.arrChuongTrinhDaoTao.Count
            End Get
        End Property
        Public Property ESSChuongTrinhDaoTao(ByVal idx As Integer) As ESSChuongTrinhDaoTao
            Get
                Return CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)
            End Get
            Set(ByVal Value As ESSChuongTrinhDaoTao)
                arrChuongTrinhDaoTao(idx) = Value
            End Set
        End Property

        Public Function GetChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer) As ESSChuongTrinhDaoTao
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim objctdt As ESSChuongTrinhDaoTao = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao)
                If objctdt.ID_he = ID_he And objctdt.ID_khoa = ID_khoa And objctdt.Khoa_hoc = Khoa_hoc And objctdt.ID_chuyen_nganh = ID_chuyen_nganh Then
                    Return objctdt
                End If
            Next
            Return Nothing
        End Function

        Public Sub HienThi_ESSCTDTChiTiet(ByVal ID_dt As Integer)
            Dim idx As Integer
            idx = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objCTDT As New ESSChuongTrinhDaoTao
                Dim clsDAL As New ChuongTrinhDaoTao_DataAccess
                objCTDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)
                'Nếu chưa load chương trình đào tạo chi tiết thì load từ database vào
                If objCTDT.ESSChuongTrinhDaoTaoChiTiet.Count = 0 Then
                    'Load các học phần thuộc chương trình đào tạo
                    Dim dtCTDTChiTiet As DataTable
                    '- ------ - ---------------
                    dtCTDTChiTiet = clsDAL.HienThi_ESSChuongTrinhDaoTaoChiTiet_DanhSach(ID_dt)
                    For i As Integer = 0 To dtCTDTChiTiet.Rows.Count - 1
                        Dim objCTDTChiTiet As New ESSChuongTrinhDaoTaoChiTiet
                        objCTDTChiTiet.ID_dt_mon = dtCTDTChiTiet.Rows(i)("ID_dt_mon")
                        objCTDTChiTiet.ID_dt = dtCTDTChiTiet.Rows(i)("ID_dt")
                        objCTDTChiTiet.ID_mon = dtCTDTChiTiet.Rows(i)("ID_mon")
                        objCTDTChiTiet.Ky_hieu = dtCTDTChiTiet.Rows(i)("Ky_hieu")
                        objCTDTChiTiet.Ten_mon = dtCTDTChiTiet.Rows(i)("Ten_mon")
                        objCTDTChiTiet.So_hoc_trinh = dtCTDTChiTiet.Rows(i)("So_hoc_trinh")
                        objCTDTChiTiet.Ky_thu = dtCTDTChiTiet.Rows(i)("Ky_thu")
                        objCTDTChiTiet.Ly_thuyet = dtCTDTChiTiet.Rows(i)("Ly_thuyet")
                        objCTDTChiTiet.Thuc_hanh = dtCTDTChiTiet.Rows(i)("Thuc_hanh")
                        objCTDTChiTiet.Bai_tap = dtCTDTChiTiet.Rows(i)("Bai_tap")
                        objCTDTChiTiet.Bai_tap_lon = dtCTDTChiTiet.Rows(i)("Bai_tap_lon")
                        objCTDTChiTiet.Thuc_tap = dtCTDTChiTiet.Rows(i)("Thuc_tap")
                        objCTDTChiTiet.Tu_chon = dtCTDTChiTiet.Rows(i)("Tu_chon")
                        objCTDTChiTiet.STT_mon = dtCTDTChiTiet.Rows(i)("STT_mon")
                        objCTDTChiTiet.He_so = dtCTDTChiTiet.Rows(i)("He_so")
                        objCTDTChiTiet.Kien_thuc = dtCTDTChiTiet.Rows(i)("Kien_thuc")
                        objCTDTChiTiet.Ten_kien_thuc = dtCTDTChiTiet.Rows(i)("Ten_kien_thuc").ToString
                        objCTDTChiTiet.Chon = dtCTDTChiTiet.Rows(i)("Chon")
                        objCTDTChiTiet.Khong_tinh_TBCHT = dtCTDTChiTiet.Rows(i)("Khong_tinh_TBCHT")
                        objCTDTChiTiet.Mon_tot_nghiep = dtCTDTChiTiet.Rows(i)("Mon_tot_nghiep")
                        objCTDTChiTiet.Nhom_tu_chon = dtCTDTChiTiet.Rows(i)("Nhom_tu_chon")
                        objCTDTChiTiet.Tu_hoc = dtCTDTChiTiet.Rows(i)("Tu_hoc")
                        objCTDTChiTiet.So_hoc_trinh_tien_quyet = dtCTDTChiTiet.Rows(i)("So_hoc_trinh_tien_quyet")
                        objCTDTChiTiet.Ma_khoa_phu_trach = dtCTDTChiTiet.Rows(i)("Ma_khoa_phu_trach").ToString
                        objCTDTChiTiet.Ty_le_ly_thuyet = dtCTDTChiTiet.Rows(i)("Ty_le_ly_thuyet")
                        objCTDTChiTiet.Ty_le_thuc_hanh = dtCTDTChiTiet.Rows(i)("Ty_le_thuc_hanh")
                        objCTDTChiTiet.HP_tuong_duong = dtCTDTChiTiet.Rows(i)("HP_tuong_duong")
                        objCTDTChiTiet.So_tien_tai_lieu = dtCTDTChiTiet.Rows(i)("So_tien_tai_lieu")
                        objCTDTChiTiet.HocPhan_DaiCuong = dtCTDTChiTiet.Rows(i)("HocPhan_DaiCuong")
                        'Load rang buoc mon hoc
                        objCTDT.ESSChuongTrinhDaoTaoChiTiet.Add(objCTDTChiTiet)
                    Next
                End If
                'Load lớp thuộc chương trình đào tạo
                If objCTDT.ESSChuongTrinhDaoTaoLop.Count = 0 Then
                    Dim dtLop As New DataTable
                    dtLop = clsDAL.HienThi_ESSChuongTrinhDaoTao_Lop_DanhSach(ID_dt)
                    For i As Integer = 0 To dtLop.Rows.Count - 1
                        Dim l As New ESSLop
                        l.ID_lop = dtLop.Rows(i)("ID_lop")
                        objCTDT.ESSChuongTrinhDaoTaoLop.Add(l)
                    Next
                End If

                'Load môn ràng buộc
                If objCTDT.ChuongTrinhDaoTaoRangBuoc.Count = 0 Then
                    Dim dtCTDT_MonRangBuoc As DataTable
                    dtCTDT_MonRangBuoc = clsDAL.HienThi_ESSChuongTrinhDaoTaoMonRangBuoc_DanhSach(ID_dt)
                    For i As Integer = 0 To dtCTDT_MonRangBuoc.Rows.Count - 1
                        Dim objRB As New ESSChuongTrinhDaoTaoMonHocRangBuoc
                        objRB.ID_rb = dtCTDT_MonRangBuoc.Rows(i)("ID_rb")
                        objRB.ID_mon = dtCTDT_MonRangBuoc.Rows(i)("ID_mon")
                        objRB.Ky_hieu = dtCTDT_MonRangBuoc.Rows(i)("Ky_hieu1")
                        objRB.Ten_mon = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon1")
                        objRB.ID_mon_rb = dtCTDT_MonRangBuoc.Rows(i)("ID_mon_rb")
                        objRB.ID_dt = dtCTDT_MonRangBuoc.Rows(i)("id_dt")
                        objRB.Ten_mon1 = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon2")
                        objRB.Loai_rang_buoc = dtCTDT_MonRangBuoc.Rows(i)("Loai_rang_buoc")
                        objRB.Ten_rang_buoc = dtCTDT_MonRangBuoc.Rows(i)("Ten_rang_buoc")
                        objRB.Ten_mon_rb = dtCTDT_MonRangBuoc.Rows(i)("Ten_mon_rb")

                        'Load rang buoc mon hoc
                        objCTDT.ChuongTrinhDaoTaoRangBuoc.Add(objRB)
                    Next
                End If

                ' Load nhóm tự chọn
                If objCTDT.ESSChuongTrinhDaoTaoNhomTuChon.Count = 0 Then
                    Dim clsNhomTuChon_DataAccess As New ChuongTrinhDaoTaoNhomTuChon_DataAccess
                    Dim dtCTDTNhomChon As DataTable
                    dtCTDTNhomChon = clsNhomTuChon_DataAccess.HienThi_ESSChuongTrinhDaoTaoNhomTuChon(ID_dt)
                    For j As Integer = 0 To dtCTDTNhomChon.Rows.Count - 1
                        Dim objNTC As New ESSChuongTrinhDaoTaoNhomTuChon
                        If dtCTDTNhomChon.Rows(j)("ID_dt").ToString() <> "" Then objNTC.ID_dt = CType(dtCTDTNhomChon.Rows(j)("ID_dt").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("Nhom_tu_chon").ToString() <> "" Then objNTC.Nhom_tu_chon = CType(dtCTDTNhomChon.Rows(j)("Nhom_tu_chon").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("So_mon_dang_ky").ToString() <> "" Then objNTC.So_mon_dang_ky = CType(dtCTDTNhomChon.Rows(j)("So_mon_dang_ky").ToString(), Integer)
                        If dtCTDTNhomChon.Rows(j)("So_mon_tu_chon").ToString() <> "" Then objNTC.So_mon_tu_chon = CType(dtCTDTNhomChon.Rows(j)("So_mon_tu_chon").ToString(), Integer)
                        objCTDT.ESSChuongTrinhDaoTaoNhomTuChon.Add(objNTC)
                    Next
                End If

            End If
        End Sub

        Public Function DanhSachMonHoc() As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon")
            dtMon.Columns.Add("Ten_mon")
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim row As DataRow = dtMon.NewRow()
                row("ID_mon") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).ID_mon
                row("Ten_mon") = "Kỳ thứ: " & CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ky_thu.ToString & " - " & CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ten_mon & " (" & CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ky_hieu & ")"
                dtMon.Rows.Add(row)
            Next
            dtMon.DefaultView.Sort = "Ten_mon"
            Return dtMon
        End Function
        Public Function DanhSachMonHoc(ByVal Ky_thu As Integer) As DataTable
            Dim dtMon As New DataTable
            dtMon.Columns.Add("ID_mon")
            dtMon.Columns.Add("Ten_mon")
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                If CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ky_thu = Ky_thu Then
                    Dim row As DataRow = dtMon.NewRow()
                    row("ID_mon") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).ID_mon
                    row("Ten_mon") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ten_mon & "|" & CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).Ky_hieu & "|" & CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTaoChiTiet).So_hoc_trinh.ToString
                    dtMon.Rows.Add(row)
                End If
            Next
            dtMon.DefaultView.Sort = "Ten_mon"
            Return dtMon
        End Function

        Public Function DanhSachChuongTrinhDaoTao() As DataTable
            Dim dtCTDT As New DataTable
            dtCTDT.Columns.Add("ID_dt", GetType(Integer))
            dtCTDT.Columns.Add("ID_he", GetType(Integer))
            dtCTDT.Columns.Add("ID_khoa", GetType(Integer))
            dtCTDT.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtCTDT.Columns.Add("Ten_he", GetType(String))
            dtCTDT.Columns.Add("Ten_khoa", GetType(String))
            dtCTDT.Columns.Add("Khoa_hoc", GetType(Integer))
            dtCTDT.Columns.Add("Ten_chuyen_nganh", GetType(String))
            dtCTDT.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtCTDT.Columns.Add("So_ky_hoc", GetType(Integer))
            dtCTDT.Columns.Add("So", GetType(Integer))
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                Dim row As DataRow = dtCTDT.NewRow()
                row("ID_dt") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_dt
                row("ID_he") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_he
                row("ID_khoa") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_khoa
                row("ID_chuyen_nganh") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_chuyen_nganh
                row("Khoa_hoc") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).Khoa_hoc
                row("Ten_he") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).Ten_he
                row("Ten_khoa") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).Ten_khoa
                row("Khoa_hoc") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).Khoa_hoc
                row("Ten_chuyen_nganh") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).Chuyen_nganh
                row("So_hoc_trinh") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).So_hoc_trinh
                row("So_ky_hoc") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).So_ky_hoc
                row("So") = CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).So
                dtCTDT.Rows.Add(row)
            Next
            dtCTDT.AcceptChanges()
            Return dtCTDT
        End Function

        Function Get_SoKyToiDa(ByVal ID_dt As Integer) As Integer
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                If CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_dt = ID_dt Then
                    Return CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).So_ky_hoc
                End If
            Next
            Return 0
        End Function

        Public Function ESSChuongTrinhDaoTaoChiTietDangKy(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("ID_mon_tc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_mon_rb", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Loai_rang_buoc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_mon_rb", GetType(String))
            dtCTDTChiTiet.Columns.Add("ID_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("STT_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ky_thu", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("He_so", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Bat_buoc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Rang_buoc", GetType(String))
            dtCTDTChiTiet.Columns.Add("So_tien_nop", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Con_trong", GetType(Integer))
            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ESSChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(i)
                        row("ID_mon") = 0
                        row("ID_mon") = .ID_mon
                        row("STT_mon") = .STT_mon
                        row("Ky_hieu") = .Ky_hieu
                        row("Ten_mon") = .Ten_mon
                        row("Ky_thu") = .Ky_thu
                        row("Nhom_tu_chon") = .Nhom_tu_chon
                        row("So_hoc_trinh") = .So_hoc_trinh
                        If .Tu_chon = False Then
                            row("Bat_buoc") = "X"
                        End If
                        row("He_so") = .He_so
                        row("Ten_kien_thuc") = .Ten_kien_thuc
                        For j As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                            With objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(j)
                                If row("ID_mon") = .ID_mon Then
                                    row("ID_mon_rb") = .ID_mon_rb
                                    row("Loai_rang_buoc") = .Loai_rang_buoc
                                    row("Ten_mon_rb") = .Ten_mon_rb
                                    row("Rang_buoc") += .Ten_mon_rb + vbCrLf
                                End If
                            End With
                        Next
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            Return dtCTDTChiTiet
        End Function

        Public Function DanhSachChuongTrinhDaoTaoChiTiet(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("ID_dt_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_dt", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("ID_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("STT_mon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ky_thu", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ly_thuyet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Thuc_hanh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Bai_tap", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Bai_tap_lon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tu_hoc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Thuc_tap", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tong_so_tiet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Tu_chon", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("He_so", GetType(Double))
            dtCTDTChiTiet.Columns.Add("Kien_thuc", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))
            dtCTDTChiTiet.Columns.Add("Chon", GetType(String))
            dtCTDTChiTiet.Columns.Add("Khong_tinh_TBCHT", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("HP_tuong_duong", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("Mon_tot_nghiep", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh_tien_quyet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ma_khoa_phu_trach", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ty_le_ly_thuyet", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ty_le_thuc_hanh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("So_tien_tai_lieu", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("HocPhan_DaiCuong", GetType(Boolean))
            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ESSChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(i)
                        row("ID_dt_mon") = .ID_dt_mon
                        row("ID_dt") = .ID_dt
                        row("ID_mon") = .ID_mon
                        row("STT_mon") = .STT_mon
                        row("Ky_hieu") = .Ky_hieu
                        row("Ten_mon") = .Ten_mon
                        row("Ky_thu") = .Ky_thu
                        row("So_hoc_trinh") = .So_hoc_trinh
                        row("Ly_thuyet") = .Ly_thuyet
                        row("Thuc_hanh") = .Thuc_hanh
                        row("Bai_tap") = .Bai_tap
                        row("Bai_tap_lon") = .Bai_tap_lon
                        row("Tu_hoc") = .Tu_hoc
                        row("Thuc_tap") = .Thuc_tap
                        row("Tong_so_tiet") = .Ly_thuyet + .Thuc_hanh + .Bai_tap + .Bai_tap_lon
                        row("Tu_chon") = .Tu_chon
                        row("He_so") = .He_so
                        row("Kien_thuc") = .Kien_thuc
                        row("Nhom_tu_chon") = .Nhom_tu_chon
                        row("Ten_kien_thuc") = .Ten_kien_thuc
                        row("Chon") = .Chon
                        row("Khong_tinh_TBCHT") = .Khong_tinh_TBCHT
                        row("Mon_tot_nghiep") = .Mon_tot_nghiep
                        row("So_hoc_trinh_tien_quyet") = .So_hoc_trinh_tien_quyet
                        row("Ma_khoa_phu_trach") = .Ma_khoa_phu_trach
                        row("Ty_le_ly_thuyet") = .Ty_le_ly_thuyet
                        row("Ty_le_thuc_hanh") = .Ty_le_thuc_hanh
                        row("HP_tuong_duong") = .HP_tuong_duong
                        row("So_tien_tai_lieu") = .So_tien_tai_lieu
                        row("HocPhan_DaiCuong") = .HocPhan_DaiCuong
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            Return dtCTDTChiTiet
        End Function


        Public Function DanhSachMonTuChonChuongTrinhDaoTaoChiTiet(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDTChiTiet As New DataTable
            dtCTDTChiTiet.Columns.Add("Chon", GetType(Boolean))
            dtCTDTChiTiet.Columns.Add("ID_dt", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Nhom_tu_chon", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ky_hieu", GetType(String))
            dtCTDTChiTiet.Columns.Add("Ten_mon", GetType(String))
            dtCTDTChiTiet.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtCTDTChiTiet.Columns.Add("Ten_kien_thuc", GetType(String))

            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ESSChuongTrinhDaoTaoChiTiet.Count - 1
                    Dim row As DataRow = dtCTDTChiTiet.NewRow()
                    With objTCDT.ESSChuongTrinhDaoTaoChiTiet.ESSChuongTrinhDaoTaoChiTiet(i)
                        If .Tu_chon Then
                            row("Chon") = False
                            row("ID_dt") = .ID_dt
                            row("Nhom_tu_chon") = .Nhom_tu_chon
                            row("Ky_hieu") = .Ky_hieu
                            row("Ten_mon") = .Ten_mon
                            row("So_hoc_trinh") = .So_hoc_trinh
                            row("Ten_kien_thuc") = .Ten_kien_thuc
                        End If
                    End With
                    dtCTDTChiTiet.Rows.Add(row)
                Next
            End If
            dtCTDTChiTiet.AcceptChanges()
            Return dtCTDTChiTiet
        End Function

        Public Function DanhSach_MonRangBuoc(ByVal ID_dt As Integer) As DataTable
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim dtCTDT_MonRangBuoc As New DataTable
            dtCTDT_MonRangBuoc.Columns.Add("idx_rb", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_dt", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_mon", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("ID_mon_rb", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("Loai_rang_buoc", GetType(Integer))
            dtCTDT_MonRangBuoc.Columns.Add("Ky_hieu1", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon1", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon2", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_rang_buoc", GetType(String))
            dtCTDT_MonRangBuoc.Columns.Add("Ten_mon_RB", GetType(String))
            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    Dim row As DataRow = dtCTDT_MonRangBuoc.NewRow()
                    With objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i)
                        row("idx_rb") = i
                        row("ID_mon_rb") = .ID_mon_rb
                        row("ID_dt") = .ID_dt
                        row("ID_mon") = .ID_mon
                        row("Loai_rang_buoc") = .Loai_rang_buoc
                        row("Ten_rang_buoc") = .Ten_rang_buoc
                        row("Ky_hieu1") = .Ky_hieu
                        row("Ten_mon1") = .Ten_mon
                        row("Ten_mon2") = .Ten_mon1
                        row("Ten_mon_rb") = .Ten_mon_rb
                    End With
                    dtCTDT_MonRangBuoc.Rows.Add(row)
                Next
            End If
            dtCTDT_MonRangBuoc.AcceptChanges()
            Return dtCTDT_MonRangBuoc
        End Function
        Public Sub GanMonRangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer, ByVal Loai_rang_buoc As Integer, ByVal Ky_hieu1 As String, ByVal Ten_mon1 As String, ByVal Ten_mon2 As String, ByVal Ten_rang_buoc As String)
            If Not Check_idx_RangBuoc(ID_dt, ID_mon, ID_mon_rb) Then
                Dim idx As Integer = Tim_idx(ID_dt)
                If idx >= 0 Then
                    Dim objTCDT As New ESSChuongTrinhDaoTao
                    Dim objMonRB As New ESSChuongTrinhDaoTaoMonHocRangBuoc
                    objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)
                    With objMonRB
                        .ID_dt = ID_dt
                        .ID_mon = ID_mon
                        .ID_mon_rb = ID_mon_rb
                        .Ky_hieu = Ky_hieu1
                        .Loai_rang_buoc = Loai_rang_buoc
                        .Ten_mon1 = Ten_mon2
                        .Ten_mon = Ten_mon1
                        .Ten_rang_buoc = Ten_rang_buoc
                    End With
                    objTCDT.ChuongTrinhDaoTaoRangBuoc.Add(objMonRB)
                    'Update vào CSDL
                    Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                    obj.ThemMoi_ESSChuongTrinhDaoTaoRangBuoc(objMonRB)
                End If
            End If
        End Sub
        Public Sub XoaMonRangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer)
            Dim idx As Integer = Tim_idx(ID_dt)
            Dim idx_rb As Integer = Tim_idx_RangBuoc(ID_dt, ID_mon, ID_mon_rb)
            If idx_rb >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                Dim objMonRB As New ESSChuongTrinhDaoTaoMonHocRangBuoc
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)
                objTCDT.ChuongTrinhDaoTaoRangBuoc.Remove(idx_rb)
                'Xoá khỏi CSDL
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                obj.Xoa_ESSChuongTrinhDaoTaoRangBuoc(ID_dt, ID_mon, ID_mon_rb)
            End If
        End Sub

        Public Sub XoaNhomTuChon(ByVal ID_dt As Integer, ByVal Nhom_tu_chon As Integer)
            'Xoá khỏi CSDL
            Dim obj As ChuongTrinhDaoTaoNhomTuChon_DataAccess = New ChuongTrinhDaoTaoNhomTuChon_DataAccess
            obj.Xoa_ESSChuongTrinhDaoTaoNhomTuChon(ID_dt, Nhom_tu_chon)
        End Sub


        Public Function CapNhat_ESSChuongTrinhDaoTaoRangBuoc(ByVal objChuongTrinhDaoTao As ESSChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CapNhat_ESSChuongTrinhDaoTao(objChuongTrinhDaoTao, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoRangBuoc(ByVal objChuongTrinhDaoTaoRangBuoc As ESSChuongTrinhDaoTaoMonHocRangBuoc) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.ThemMoi_ESSChuongTrinhDaoTaoRangBuoc(objChuongTrinhDaoTaoRangBuoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(ByVal objChuongTrinhDaoNhomTuChon As ESSChuongTrinhDaoTaoNhomTuChon) As Integer
            Try
                Dim obj As ChuongTrinhDaoTaoNhomTuChon_DataAccess = New ChuongTrinhDaoTaoNhomTuChon_DataAccess
                Return obj.ThemMoi_ESSChuongTrinhDaoTaoNhomTuChon(objChuongTrinhDaoNhomTuChon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private Function Check_idx_RangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Boolean
            Dim idx As Integer = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    If objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon = ID_mon _
                    And objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon_rb = ID_mon_rb Then
                        Return True
                    End If
                Next
                Return False
            End If
            Return False
        End Function

        Private Function Tim_idx_RangBuoc(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_rb As Integer) As Integer
            Dim idx As Integer = Tim_idx(ID_dt)
            If idx >= 0 Then
                Dim objTCDT As New ESSChuongTrinhDaoTao
                objTCDT = CType(arrChuongTrinhDaoTao(idx), ESSChuongTrinhDaoTao)

                For i As Integer = 0 To objTCDT.ChuongTrinhDaoTaoRangBuoc.Count - 1
                    If objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon = ID_mon _
                    And objTCDT.ChuongTrinhDaoTaoRangBuoc.ChuongTrinhDaoTaoRangBuoc(i).ID_mon_rb = ID_mon_rb Then
                        Return i
                    End If
                Next
                Return -1
            End If
            Return -1
        End Function

        Public Function Tim_idx(ByVal ID_dt As Integer) As Integer
            For i As Integer = 0 To arrChuongTrinhDaoTao.Count - 1
                If CType(arrChuongTrinhDaoTao(i), ESSChuongTrinhDaoTao).ID_dt = ID_dt Then
                    Return i
                End If
            Next
            Return -1
        End Function

        Public Function ThemMoi_ESSChuongTrinhDaoTao(ByVal objChuongTrinhDaoTao As ESSChuongTrinhDaoTao) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.ThemMoi_ESSChuongTrinhDaoTao(objChuongTrinhDaoTao)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTao(ByVal objChuongTrinhDaoTao As ESSChuongTrinhDaoTao, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CapNhat_ESSChuongTrinhDaoTao(objChuongTrinhDaoTao, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTao_Lop(ByVal ID_lop As Integer, ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CapNhat_ESSChuongTrinhDaoTao_Lop(ID_lop, ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTao(ByVal ID_dt As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.Xoa_ESSChuongTrinhDaoTao(ID_dt)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao(ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_chuyen_nganh As Integer, ByVal So As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CheckExist_ChuongTrinhDaoTao(ID_he, ID_khoa, Khoa_hoc, ID_chuyen_nganh, So)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_ChuongTrinhDaoTao_Diem(ByVal ID_dt As Integer, Optional ByVal ID_mon As Integer = 0) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CheckExist_ChuongTrinhDaoTao_Diem(ID_dt, ID_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSChuongTrinhDaoTaoChiTiet(ByVal objsvChuongTrinhDaoTaoChiTiet As ESSChuongTrinhDaoTaoChiTiet) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.ThemMoi_ESSChuongTrinhDaoTaoChiTiet(objsvChuongTrinhDaoTaoChiTiet)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSChuongTrinhDaoTaoChiTiet(ByVal objsvChuongTrinhDaoTaoChiTiet As ESSChuongTrinhDaoTaoChiTiet, ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.CapNhat_ESSChuongTrinhDaoTaoChiTiet(objsvChuongTrinhDaoTaoChiTiet, ID_dt_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTaoChiTiet(ByVal ID_dt_mon As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.Xoa_ESSChuongTrinhDaoTaoChiTiet(ID_dt_mon)
            Catch ex As Exception
                Throw ex
            End Try
        End Function


        Private Function Mapping(ByVal drChuongTrinhDaoTao As DataRow) As ESSChuongTrinhDaoTao
            Dim result As ESSChuongTrinhDaoTao
            Try
                result = New ESSChuongTrinhDaoTao
                If drChuongTrinhDaoTao("ID_dt").ToString() <> "" Then result.ID_dt = CType(drChuongTrinhDaoTao("ID_dt").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_he").ToString() <> "" Then result.ID_he = CType(drChuongTrinhDaoTao("ID_he").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_khoa").ToString() <> "" Then result.ID_khoa = CType(drChuongTrinhDaoTao("ID_khoa").ToString(), Integer)
                If drChuongTrinhDaoTao("Khoa_hoc").ToString() <> "" Then result.Khoa_hoc = CType(drChuongTrinhDaoTao("Khoa_hoc").ToString(), Integer)
                If drChuongTrinhDaoTao("ID_chuyen_nganh").ToString() <> "" Then result.ID_chuyen_nganh = CType(drChuongTrinhDaoTao("ID_chuyen_nganh").ToString(), Integer)
                If drChuongTrinhDaoTao("So_hoc_trinh").ToString() <> "" Then result.So_hoc_trinh = CType(drChuongTrinhDaoTao("So_hoc_trinh").ToString(), Integer)
                If drChuongTrinhDaoTao("So_ky_hoc").ToString() <> "" Then result.So_ky_hoc = CType(drChuongTrinhDaoTao("So_ky_hoc").ToString(), Integer)
                If drChuongTrinhDaoTao("So").ToString() <> "" Then result.So = CType(drChuongTrinhDaoTao("So").ToString(), Integer)

                result.Ten_he = drChuongTrinhDaoTao("Ten_he").ToString()
                result.Ten_khoa = drChuongTrinhDaoTao("Ten_khoa").ToString()
                result.Ten_nganh = drChuongTrinhDaoTao("Ten_nganh").ToString()
                result.Chuyen_nganh = drChuongTrinhDaoTao("Chuyen_nganh").ToString()
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function

        Function PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(ByVal ID_dt As Integer) As DataTable
            Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
            Return obj.PLAN_ChuongTrinhDaoTao_TuongDuong_HienThi(ID_dt)
        End Function
        Public Function ThemMoi_ESSChuongTrinhDaoTao_MonTuongDuong(ByVal ID_dt As Integer, ByVal ID_mon As Integer, ByVal ID_mon_tuong_duong As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.ThemMoi_ESSChuongTrinhDaoTao_MonTuongDuong(ID_dt, ID_mon, ID_mon_tuong_duong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSChuongTrinhDaoTao_MonTuongDuongBuoc(ByVal ID_tuong_duong As Integer) As Integer
            Try
                Dim obj As ChuongTrinhDaoTao_DataAccess = New ChuongTrinhDaoTao_DataAccess
                Return obj.Xoa_ESSChuongTrinhDaoTao_MonTuongDuongBuoc(ID_tuong_duong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
