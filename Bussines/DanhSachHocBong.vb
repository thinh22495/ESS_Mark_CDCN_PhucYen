'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, August 09, 2010
'---------------------------------------------------------------------------

Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhSachHocBong_Bussines

        Private arrDanhSachHB As New ArrayList
        Private mdtDoiTuongHB As DataTable
        Private mdtDsTroCap As DataTable ' Danh sách sinh viên xác định tiền trợ cấp
        Private arrHBSinhVien As New ArrayList ' Thông tin học bổng của một sinh viên
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_lop As String, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            mHoc_ky = Hoc_ky
            mNam_hoc = Nam_hoc
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhSachHocBong_DanhSach(dsID_lop)
                Dim objDanhSachHocBong As ESSDanhSachHocBong = Nothing
                For Each dr As DataRow In dt.Rows
                    objDanhSachHocBong = New ESSDanhSachHocBong
                    objDanhSachHocBong = Mapping(dr)
                    arrDanhSachHB.Add(objDanhSachHocBong)
                Next
                mdtDoiTuongHB = obj.HienThi_ESSDoiTuongHocBong()
                mdtDsTroCap = obj.HienThi_ESSDanhSachTroCap(mHoc_ky, mNam_hoc, dsID_lop)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub New(ByVal ID_sv As Integer) ' Load học bổng của một sinh viên (dùng load hồ sơ sinh viên)
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSHocBongSinhVien(ID_sv)
                Dim objDanhSachHocBong As ESSDanhSachHocBong = Nothing
                For Each dr As DataRow In dt.Rows
                    objDanhSachHocBong = New ESSDanhSachHocBong
                    objDanhSachHocBong = MappingQHBSinhVien(dr)
                    arrHBSinhVien.Add(objDanhSachHocBong)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "Functions And Subs"
        Public Sub AddHocBong(ByRef dtDSSV As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String)
            Try
                dtDSSV.Columns.Add("Hoc_bong", GetType(String))
                dtDSSV.Columns.Add("Hoc_bong_cs", GetType(String))
                dtDSSV.Columns.Add("Tong_hoc_bong", GetType(String))
                For i As Integer = 0 To dtDSSV.Rows.Count - 1
                    Dim Hoc_bong As String = ""
                    Dim Hoc_bong_cs As String = ""
                    HocBong_Ky(dtDSSV.Rows(i)("ID_sv"), Hoc_ky, Nam_hoc, Hoc_bong, Hoc_bong_cs)
                    If Hoc_bong <> "" Then dtDSSV.Rows(i)("Hoc_bong") = Format(CDbl(Hoc_bong), "###,###")
                    If Hoc_bong_cs <> "" Then dtDSSV.Rows(i)("Hoc_bong_cs") = Format(CDbl(Hoc_bong_cs), "###,###")
                    Dim Tong_hoc_bong As Double = 0
                    Tong_hoc_bong = CDbl(IIf(Hoc_bong.ToString = "", 0, Hoc_bong)) + CDbl(IIf(Hoc_bong_cs.ToString = "", 0, Hoc_bong_cs))
                    If Tong_hoc_bong <> 0 Then dtDSSV.Rows(i)("Tong_hoc_bong") = Format(CDbl(Tong_hoc_bong), "###,###")
                Next
            Catch ex As Exception
            End Try
        End Sub
        Public Sub HocBong_Ky(ByVal id_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByRef HB_HT As String, ByRef HB_CS As String)
            For i As Integer = 0 To arrDanhSachHB.Count - 1
                Dim obj As ESSDanhSachHocBong = CType(arrDanhSachHB(i), ESSDanhSachHocBong)
                If obj.ID_sv = id_sv And obj.Hoc_ky = Hoc_ky And obj.Nam_hoc = Nam_hoc Then
                    HB_HT = obj.HB_HT.ToString
                    HB_CS = obj.HB_CS.ToString
                End If
            Next

        End Sub

        ' Học bổng của một sinh viên (dùng load trong hồ sơ sinh viên)
        Public Function HocBongSinhVien() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Hoc_ky1")
                dt.Columns.Add("Hoc_ky2")
                dt.Columns.Add("Nam_hoc")
                dt.Columns.Add("HBHT1", GetType(Integer))
                dt.Columns.Add("HBHT2", GetType(Integer))
                dt.Columns.Add("HBCS1", GetType(Integer))
                dt.Columns.Add("HBCS2", GetType(Integer))
                dt.Columns.Add("Tong_cong", GetType(Integer))
                Dim r As DataRow
                Dim Hoc_ky As Integer = 0
                Dim Nam_hoc As String = ""
                Dim obj As New ESSDanhSachHocBong
                For i As Integer = 0 To arrHBSinhVien.Count - 1
                    obj = arrHBSinhVien(i)
                    If obj.Nam_hoc <> Nam_hoc Or obj.Hoc_ky <> Hoc_ky Then
                        Dim HBHT1, HBHT2 As Integer
                        Dim HBCS1, HBCS2 As Integer
                        Dim obj1 As ESSDanhSachHocBong
                        For j As Integer = 0 To arrHBSinhVien.Count - 1
                            obj1 = arrHBSinhVien(j)
                            If obj.Hoc_ky = obj1.Hoc_ky And obj.Nam_hoc = obj1.Nam_hoc Then
                                If obj1.Hoc_ky = 1 Then
                                    HBHT1 += obj1.HB_HT
                                    HBCS1 += obj1.HB_CS
                                ElseIf obj1.Hoc_ky = 2 Then
                                    HBHT2 += obj1.HB_HT
                                    HBCS2 += obj1.HB_CS
                                End If
                            End If
                        Next
                        r = dt.NewRow
                        If obj.Hoc_ky = 1 Then
                            r("Hoc_ky1") = obj.Hoc_ky
                        Else
                            r("Hoc_ky2") = obj.Hoc_ky
                        End If
                        r("Nam_hoc") = obj.Nam_hoc
                        If HBHT1 > 0 Then r("HBHT1") = HBHT1
                        If HBHT2 > 0 Then r("HBHT2") = HBHT2
                        If HBCS1 > 0 Then r("HBCS1") = HBCS1
                        If HBCS2 > 0 Then r("HBCS2") = HBCS2
                        Dim Tong_cong As Integer = HBHT1 + HBHT2 + HBCS1 + HBCS2
                        If Tong_cong > 0 Then r("Tong_cong") = Tong_cong
                        dt.Rows.Add(r)
                        Hoc_ky = obj.Hoc_ky
                        Nam_hoc = obj.Nam_hoc
                    End If
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đủ điều kiện xét học bổng
        Public Function DanhSachSV_XetHocBong(ByVal dtSinhVien As DataTable, ByVal dtDiemSinhVien As DataTable, ByVal dtKl As DataTable, ByVal dtRLSinhVien As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByRef TongTien_HB_CS As Integer) As DataTable
            Try
                Dim objDM As New DanhMuc_Bussines
                Dim XepLoaiXS As String = objDM.LoadXepLoai_HocBong(1)
                Dim XepLoaiGioi As String = objDM.LoadXepLoai_HocBong(2)
                Dim XepLoaiKha As String = objDM.LoadXepLoai_HocBong(3)
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_xep_loai_HT", GetType(Integer))
                dt.Columns.Add("Xep_loai_HT", GetType(String))
                dt.Columns.Add("ID_xep_loai_RL", GetType(Integer))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("ID_xep_loai_HB", GetType(Integer))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("TBCHT10", GetType(Double))
                dt.Columns.Add("Tong_diem_rl", GetType(Integer))
                dt.Columns.Add("Xep_loai_HB", GetType(String))
                dt.Columns.Add("HB_HT", GetType(Double))
                dt.Columns.Add("HB_CS", GetType(Double))
                dt.Columns.Add("Tong_tien", GetType(Double))
                dt.Columns.Add("Xu_ly_ky_luat", GetType(String))
                dt.Columns.Add("So_mon_no", GetType(Integer))
                dt.Columns.Add("Tong_sv_hb")
                dt.Columns.Add("Tong_sv_xs")
                dt.Columns.Add("Tong_sv_gioi")
                dt.Columns.Add("Tong_sv_kha")
                dt.Columns.Add("Diem_hb", GetType(Double))
                dt.Columns.Add("Label_HBCS") ' Nhãn học bổng chính sách 5 tháng 7 tháng
                Dim row As DataRow
                For i As Integer = 0 To dtDiemSinhVien.Rows.Count - 1
                    For j As Integer = 0 To dtSinhVien.Rows.Count - 1
                        If dtSinhVien.Rows(j)("ID_sv") = dtDiemSinhVien.Rows(i)("ID_sv") Then
                            row = dt.NewRow
                            row("ID_sv") = dtSinhVien.Rows(j)("ID_sv")
                            row("Ma_sv") = dtSinhVien.Rows(j).Item("Ma_sv").ToString
                            row("Ho_ten") = dtSinhVien.Rows(j).Item("Ho_ten").ToString
                            row("Ngay_sinh") = dtSinhVien.Rows(j).Item("Ngay_sinh")
                            row("Ten_lop") = dtSinhVien.Rows(j).Item("Ten_lop")

                            ' Lọc sinh viên kỷ luật
                            dtKl.DefaultView.RowFilter = "ID_sv=" & dtSinhVien.Rows(j)("ID_sv")
                            ' Lọc điểm rèn luyện của sinh viên
                            dtRLSinhVien.DefaultView.RowFilter = "ID_sv=" & dtDiemSinhVien.Rows(i)("ID_sv")
                            Try
                                row("TBCHT") = IIf(dtDiemSinhVien.Rows(i).Item("TBCHT").ToString = "", 0, dtDiemSinhVien.Rows(i).Item("TBCHT"))
                                row("TBCHT10") = IIf(dtDiemSinhVien.Rows(i).Item("TBCHT10").ToString = "", 0, dtDiemSinhVien.Rows(i).Item("TBCHT10"))
                                If dtRLSinhVien.DefaultView.Count > 0 Then row("Tong_diem_rl") = IIf(IsDBNull(dtRLSinhVien.DefaultView.Item(0)("Tong_diem")), 0, dtRLSinhVien.DefaultView.Item(0)("Tong_diem"))
                                row("ID_xep_loai_HT") = IIf(dtDiemSinhVien.Rows(i).Item("ID_xep_loai").ToString = "", -1, dtDiemSinhVien.Rows(i).Item("ID_xep_loai"))
                                row("Xep_loai_HT") = dtDiemSinhVien.Rows(i).Item("Xep_loai").ToString
                                If dtRLSinhVien.DefaultView.Count > 0 Then row("ID_xep_loai_RL") = IIf(dtRLSinhVien.DefaultView.Item(0)("ID_xep_loai").ToString = "", -1, dtRLSinhVien.DefaultView.Item(0)("ID_xep_loai"))
                                If dtRLSinhVien.DefaultView.Count > 0 Then row("Xep_loai_RL") = dtRLSinhVien.DefaultView.Item(0)("Xep_loai").ToString
                                row("ID_doi_tuong_TC") = IIf(dtSinhVien.Rows(j)("ID_doi_tuong_TC").ToString = "", -1, dtSinhVien.Rows(j)("ID_doi_tuong_TC"))
                            Catch ex As Exception
                                Throw ex
                            End Try
                            Try
                                mdtDoiTuongHB.DefaultView.RowFilter = "ID_dt_hb=" & dtSinhVien.Rows(j)("ID_doi_tuong_TC")
                                If mdtDoiTuongHB.DefaultView.Count > 0 Then ' Nếu sinh viên đã xác định đối tượng học bổng
                                    row("Ma_dt") = mdtDoiTuongHB.DefaultView.Item(0)("Ma_dt_hb")
                                    row("Ten_dt") = mdtDoiTuongHB.DefaultView.Item(0)("Ten_dt_hb")
                                    'Hoc bong tro cap
                                    mdtDsTroCap.DefaultView.RowFilter = "ID_sv=" & row("ID_sv")
                                    If mdtDsTroCap.DefaultView.Count > 0 Then ' Nếu sinh viên đã xác định số tiền trợ cấp trong học kỳ
                                        row("HB_CS") = mdtDoiTuongHB.DefaultView.Item(0)("Sotien_trocap")
                                        TongTien_HB_CS += row("HB_CS")
                                    End If
                                    'row("HB_CS") = mdtDoiTuongHB.DefaultView.Item(0)("Sotien_trocap")
                                    'TongTien_HB_CS += row("HB_CS")
                                    'row("HB_CS") = 0
                                    'TongTien_HB_CS += 0
                                End If
                            Catch ex As Exception
                                Throw ex
                            End Try
                            ' Không nợ môn và phải không bị kỷ luật và ID_xep_loai >=1 and ID_xep_loai <= 3(từ khá trở lên) và xếp loại rèn luyện từ khá trở lên ID_xep_loai >=1 ID_xep_loai <=3 từ khá trở lên
                            If IIf(IsDBNull(dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")), 0, dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")) = 0 And dtKl.DefaultView.Count <= 0 And dtRLSinhVien.DefaultView.Count > 0 Then
                                Try
                                    ' Xếp loại hb xuất sắc
                                    If dtDiemSinhVien.Rows(i).Item("ID_xep_loai") = 1 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") = 1 Then
                                        row("ID_xep_loai_HB") = 1
                                        row("Xep_loai_HB") = XepLoaiXS
                                    ElseIf dtDiemSinhVien.Rows(i).Item("ID_xep_loai") <= 2 And dtDiemSinhVien.Rows(i).Item("ID_xep_loai") > 0 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") <= 2 Then ' Xếp loại hb giỏi
                                        row("ID_xep_loai_HB") = 2
                                        row("Xep_loai_HB") = XepLoaiGioi
                                    ElseIf dtDiemSinhVien.Rows(i).Item("ID_xep_loai") <= 3 And dtDiemSinhVien.Rows(i).Item("ID_xep_loai") > 0 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") <= 3 Then ' Xếp loại hb khá
                                        row("ID_xep_loai_HB") = 3
                                        row("Xep_loai_HB") = XepLoaiKha
                                    Else ' Khong duoc xep loai hoc bong
                                        row("ID_xep_loai_HB") = 4
                                        row("Xep_loai_HB") = "Không xếp loại"
                                    End If
                                Catch ex As Exception
                                    Throw ex
                                End Try
                            Else ' Neu vi pham no mon, ky luat
                                Try
                                    If dtKl.DefaultView.Count > 0 Then row("Xu_ly_ky_luat") = dtKl.DefaultView.Item(0)("Xu_ly").ToString
                                    If IIf(IsDBNull(dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")), 0, dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")) > 0 Then row("So_mon_no") = dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")
                                    ' Khong duoc xep loai hoc bong
                                    row("ID_xep_loai_HB") = 4
                                    row("Xep_loai_HB") = "Không xếp loại"
                                Catch ex As Exception
                                    Throw ex
                                End Try
                            End If
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                dt.AcceptChanges()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đã xết học bổng
        Public Function DanhSachSV_DaXet(ByVal dtDanhSachSV As DataTable, ByVal ID_phan_bo As Integer, ByRef So_tien_da_xet As Integer, ByRef So_tien_tro_cap As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_xep_loai_HT", GetType(Integer))
                dt.Columns.Add("Xep_loai_HT", GetType(String))
                dt.Columns.Add("ID_xep_loai_RL", GetType(Integer))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("ID_xep_loai_HB", GetType(Integer))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("TBCHT10", GetType(Double))
                dt.Columns.Add("Tong_diem_rl", GetType(Integer))
                dt.Columns.Add("Xep_loai_HB", GetType(String))
                dt.Columns.Add("HB_HT")
                dt.Columns.Add("HB_CS")
                dt.Columns.Add("Tong_tien")
                Dim dr As DataRow
                Dim obj As ESSDanhSachHocBong
                For Each r As DataRow In dtDanhSachSV.Rows
                    For i As Integer = 0 To arrDanhSachHB.Count - 1
                        obj = arrDanhSachHB(i)
                        If obj.ID_phan_bo = ID_phan_bo And obj.ID_sv = r("ID_sv") Then
                            dr = dt.NewRow
                            dr("Chon") = False
                            dr("ID_sv") = obj.ID_sv
                            dr("Ma_sv") = r("Ma_sv")
                            dr("Ho_ten") = r("Ho_ten")
                            dr("Ngay_sinh") = r("Ngay_sinh")
                            dr("Ten_lop") = r("Ten_lop")
                            dr("ID_xep_loai_HT") = r("ID_xep_loai_HT")
                            dr("Xep_loai_HT") = r("Xep_loai_HT")
                            dr("ID_xep_loai_RL") = r("ID_xep_loai_RL")
                            dr("Xep_loai_RL") = r("Xep_loai_RL")
                            dr("ID_doi_tuong_TC") = r("ID_doi_tuong_TC")
                            dr("Ma_dt") = r("Ma_dt")
                            dr("Ten_dt") = r("Ten_dt")
                            dr("ID_xep_loai_HB") = r("ID_xep_loai_HB")
                            dr("TBCHT") = r("TBCHT")
                            dr("TBCHT10") = r("TBCHT10")
                            dr("Tong_diem_rl") = r("Tong_diem_rl")
                            dr("Xep_loai_HB") = r("Xep_loai_HB")
                            dr("HB_HT") = Format(obj.HB_HT, "###,###")
                            dr("HB_CS") = Format(obj.HB_CS, "###,###")
                            dr("Tong_tien") = Format(obj.HB_CS + obj.HB_HT, "###,###")
                            dt.Rows.Add(dr)
                            So_tien_da_xet += obj.HB_HT
                            So_tien_tro_cap += obj.HB_CS
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowDelete = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên đã xết học bổng
        Public Function DanhSachSV_DaXet_DiemDuocHB(ByVal dtDanhSachSV As DataTable) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("ID_xep_loai_HT", GetType(Integer))
                dt.Columns.Add("Xep_loai_HT", GetType(String))
                dt.Columns.Add("ID_xep_loai_RL", GetType(Integer))
                dt.Columns.Add("Xep_loai_RL", GetType(String))
                dt.Columns.Add("ID_doi_tuong_TC", GetType(Integer))
                dt.Columns.Add("Ma_dt", GetType(String))
                dt.Columns.Add("Ten_dt", GetType(String))
                dt.Columns.Add("ID_xep_loai_HB", GetType(Integer))
                dt.Columns.Add("TBCHT", GetType(Double))
                'dt.Columns.Add("TBCHK_10", GetType(Double))
                dt.Columns.Add("Tong_diem_rl", GetType(Integer))
                dt.Columns.Add("Xep_loai_HB", GetType(String))
                dt.Columns.Add("HB_HT")
                dt.Columns.Add("HB_CS")
                Dim dr As DataRow
                Dim obj As ESSDanhSachHocBong
                For Each r As DataRow In dtDanhSachSV.Rows
                    For i As Integer = 0 To arrDanhSachHB.Count - 1
                        obj = arrDanhSachHB(i)
                        If obj.ID_sv = r("ID_sv") Then
                            dr = dt.NewRow
                            dr("ID_sv") = obj.ID_sv
                            dr("Ma_sv") = r("Ma_sv")
                            dr("Ho_ten") = r("Ho_ten")
                            dr("Ngay_sinh") = r("Ngay_sinh")
                            dr("Ten_lop") = r("Ten_lop")
                            dr("ID_xep_loai_HT") = r("ID_xep_loai_HT")
                            dr("Xep_loai_HT") = r("Xep_loai_HT")
                            dr("ID_xep_loai_RL") = r("ID_xep_loai_RL")
                            dr("Xep_loai_RL") = r("Xep_loai_RL")
                            dr("ID_doi_tuong_TC") = r("ID_doi_tuong_TC")
                            dr("Ma_dt") = r("Ma_dt")
                            dr("Ten_dt") = r("Ten_dt")
                            dr("ID_xep_loai_HB") = r("ID_xep_loai_HB")
                            dr("TBCHT") = r("TBCHT")
                            'dr("TBCHK_10") = r("TBCHK_10")
                            dr("Tong_diem_rl") = r("Tong_diem_rl")
                            dr("Xep_loai_HB") = r("Xep_loai_HB")
                            dr("HB_HT") = Format(obj.HB_HT, "###,###")
                            dr("HB_CS") = Format(obj.HB_CS, "###,###")
                            dt.Rows.Add(dr)
                        End If
                    Next
                Next
                dt.AcceptChanges()
                dt.DefaultView.AllowNew = False
                dt.DefaultView.AllowEdit = False
                dt.DefaultView.AllowDelete = False
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Xét học bổng
        Public Function XetHocBong(ByVal ID_he As Integer, ByVal dtDanhSach As DataTable, ByVal dtLoaiHB As DataTable, ByRef So_tien_da_xet As Integer, ByVal So_tien_xet As Integer) As DataTable
            Try
                So_tien_da_xet = 0
                Dim dv As DataView
                dv = dtDanhSach.DefaultView
                ' Xet sinh vien xuat sac truoc
                dv.RowFilter = "ID_xep_loai_hb=1 And ID_xep_loai_hb<>4 "
                dv.Sort = "TBCHT10,Tong_diem_rl" ' Sap xep loc uu tien ESSDiem TBCHT, sau do ESSDiem ren luyen
                For i As Integer = dv.Count - 1 To 0 Step -1
                    With dtLoaiHB.DefaultView
                        .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                        If .Count > 0 Then
                            If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT"))
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= So_tien_xet
                                Exit For
                            End If
                            dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                            So_tien_da_xet += dv.Item(i)("HB_HT")
                            So_tien_xet -= dv.Item(i)("HB_HT")
                        Else  'Chưa có phân loại học bổng theo đối tượng
                            dv.Item(i)("HB_HT") = 0
                        End If
                    End With
                Next

                ' Xet sinh vien giỏi
                If So_tien_xet > 0 Then
                    dv.RowFilter = "ID_xep_loai_hb=2 And ID_xep_loai_hb<>4 "
                    dv.Sort = "ID_xep_loai_hb,TBCHT10,Tong_diem_rl ASC" ' Sap xep loc uu tien ESSDiem TBCHT, sau do ESSDiem ren luyen
                    For i As Integer = dv.Count - 1 To 0 Step -1
                        'If dv.Item(i)("ID_sv") = 2077 Then
                        '    dv.Item(i)("ID_sv") = 2077
                        'End If
                        With dtLoaiHB.DefaultView
                            .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                            If .Count > 0 Then
                                If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                    ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                    dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT"))
                                    So_tien_da_xet += dv.Item(i)("HB_HT")
                                    So_tien_xet -= So_tien_xet
                                    Exit For
                                End If
                                dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= dv.Item(i)("HB_HT")
                            Else  'Chưa có phân loại học bổng theo đối tượng
                                dv.Item(i)("HB_HT") = 0
                            End If
                        End With
                    Next
                End If

                ' Xet sinh vien kha
                If So_tien_xet > 0 Then
                    dv.RowFilter = "ID_xep_loai_hb=3 And ID_xep_loai_hb<>4 "
                    dv.Sort = "ID_xep_loai_hb,TBCHT10,Tong_diem_rl ASC" ' Sap xep loc uu tien ESSDiem TBCHT, sau do ESSDiem ren luyen
                    For i As Integer = dv.Count - 1 To 0 Step -1
                        With dtLoaiHB.DefaultView
                            .RowFilter = "Ma_dt='" & dv.Item(i)("Ma_dt") & "' And ID_xep_loai_hb=" & dv.Item(i)("ID_xep_loai_hb") & " And ID_he=" & ID_he
                            If .Count > 0 Then
                                If CInt("0" + .Item(0).Item("HB_HT")) > So_tien_xet Then
                                    ' Số tiền còn lại gán nốt cho sinh viên cuối cùng được hưởng
                                    dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT"))
                                    So_tien_da_xet += dv.Item(i)("HB_HT")
                                    So_tien_xet -= So_tien_xet
                                    Exit For
                                End If
                                dv.Item(i)("HB_HT") = CInt("0" + .Item(0).Item("HB_HT")) ' Nhân với 6 thang trong 1 học kỳ
                                So_tien_da_xet += dv.Item(i)("HB_HT")
                                So_tien_xet -= dv.Item(i)("HB_HT")
                            Else  'Chưa có phân loại học bổng theo đối tượng
                                dv.Item(i)("HB_HT") = 0
                            End If
                        End With
                    Next
                End If

                ' Xóa những sinh viên không có học bổng học tập, học bổng chính sách    
                For i As Integer = dv.Table.Rows.Count - 1 To 0 Step -1
                    If IIf(IsDBNull(dv.Table.Rows(i)("HB_HT")), 0, dv.Table.Rows(i)("HB_HT")) = 0 And IIf(IsDBNull(dv.Table.Rows(i)("HB_CS")), 0, dv.Table.Rows(i)("HB_CS")) = 0 Then dv.Table.Rows(i).Delete()
                Next
                dv.Table.AcceptChanges()
                Return dv.Table
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách sinh viên chưa xét học bổng ( Lọc từ danh sách sinh viên đủ điều kiên xét học bổng)
        Public Function DanhSachSV_Chua_XetHocBong(ByVal dtDanhSachSv As DataTable, ByVal dtDaXet As DataTable) As DataTable
            Try
                For i As Integer = dtDanhSachSv.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtDaXet.Rows.Count - 1
                        If dtDanhSachSv.Rows(i)("ID_sv") = dtDaXet.Rows(j)("ID_sv") Then ' Loại những sinh viên đã xét học bổng
                            dtDanhSachSv.Rows(i).Delete()
                            Exit For
                        End If
                    Next
                Next
                dtDanhSachSv.AcceptChanges()
                dtDanhSachSv.DefaultView.AllowNew = False
                dtDanhSachSv.DefaultView.AllowEdit = False
                dtDanhSachSv.DefaultView.AllowDelete = False
                Return dtDanhSachSv
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Bảng tổng hợp xét học bổng (in bc tổng hợp)
        Public Function BaoCao_TongHop(ByVal dtDaXet As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dtDT As New DataTable
                dtDT.Columns.Add("Hoc_ky", GetType(Integer))
                dtDT.Columns.Add("Nam_hoc", GetType(String))
                dtDT.Columns.Add("Ma_dt", GetType(String))
                dtDT.Columns.Add("Ten_dt", GetType(String))
                dtDT.Columns.Add("Tong_sv", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_xs", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_xs", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_gioi", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_gioi", GetType(Integer))
                dtDT.Columns.Add("Tong_sv_kha", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_kha", GetType(Integer))
                dtDT.Columns.Add("Tong_Tien_Doi_Tuong", GetType(Integer)) ' Tổng số tiền HB theo đối tượng
                Dim Ma_dt As String = ""
                Dim r1 As DataRow
                Dim dv As DataView = dtDaXet.DefaultView
                dv.Sort = "Ma_dt"
                For i As Integer = 0 To dv.Count - 1 ' Lấy ra các đối tượng được học bổng
                    If Ma_dt <> dv.Item(i)("Ma_dt") Then
                        r1 = dtDT.NewRow
                        r1("Ma_dt") = dv.Item(i)("Ma_dt")
                        r1("Ten_dt") = dv.Item(i)("Ten_dt")
                        r1("Hoc_ky") = Hoc_ky
                        r1("Nam_hoc") = Nam_hoc
                        r1("Ma_dt") = dv.Item(i)("Ma_dt")
                        r1("Ten_dt") = dv.Item(i)("Ten_dt")
                        dtDT.Rows.Add(r1)
                        Ma_dt = dv.Item(i)("Ma_dt")
                    End If
                Next
                For Each dr As DataRow In dtDT.Rows ' Tính tổng sinh viên và tổng tiền của từng loại đối tượng
                    Dim Tong_sv As Integer = 0
                    Dim Tong_sv_xs As Integer = 0
                    Dim Tong_Tien_xs As Integer = 0
                    Dim Tong_sv_gioi As Integer = 0
                    Dim Tong_Tien_gioi As Integer = 0
                    Dim Tong_sv_kha As Integer = 0
                    Dim Tong_Tien_kha As Integer = 0
                    Dim Tong_Tien_Doi_Tuong As Integer = 0
                    For Each dr1 As DataRow In dtDaXet.Rows
                        If dr("Ma_dt") = dr1("Ma_dt") Then Tong_sv += 1
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 1 Then ' Tính tổng sv Xuất sắc và tổng tiền Xuất sắc
                            Tong_sv_xs += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_xs += dr1("HB_CS")
                            Else
                                Tong_Tien_xs += dr1("HB_HT")
                            End If
                        End If
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 2 Then ' Tính tổng sv Giỏi và tổng tiền Giỏi                            
                            Tong_sv_gioi += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_gioi += dr1("HB_CS")
                            Else
                                Tong_Tien_gioi += dr1("HB_HT")
                            End If
                        End If
                        If dr("Ma_dt") = dr1("Ma_dt") And dr1("ID_xep_loai_HB") = 3 Then ' Tính tổng sv Khá và tổng tiền Khá
                            Tong_sv_kha += 1
                            If dr1("HB_HT") = 0 Then ' Nếu HBHT = 0 thì điền HBCS
                                Tong_Tien_kha += dr1("HB_CS")
                            Else
                                Tong_Tien_kha += dr1("HB_HT")
                            End If
                        End If
                    Next
                    Tong_Tien_Doi_Tuong = Tong_Tien_xs + Tong_Tien_gioi + Tong_Tien_kha
                    If Tong_sv <> 0 Then dr("Tong_sv") = Tong_sv
                    If Tong_sv_xs <> 0 Then dr("Tong_sv_xs") = Tong_sv_xs
                    If Tong_Tien_xs <> 0 Then dr("Tong_Tien_xs") = Tong_Tien_xs
                    If Tong_sv_gioi <> 0 Then dr("Tong_sv_gioi") = Tong_sv_gioi
                    If Tong_Tien_gioi <> 0 Then dr("Tong_Tien_gioi") = Tong_Tien_gioi
                    If Tong_sv_kha <> 0 Then dr("Tong_sv_kha") = Tong_sv_kha
                    If Tong_Tien_kha <> 0 Then dr("Tong_Tien_kha") = Tong_Tien_kha
                    If Tong_Tien_Doi_Tuong <> 0 Then dr("Tong_Tien_Doi_Tuong") = Tong_Tien_Doi_Tuong
                Next
                dtDT.AcceptChanges()
                dtDT.DefaultView.AllowNew = False
                dtDT.DefaultView.AllowEdit = False
                dtDT.DefaultView.AllowDelete = False
                Return dtDT
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhSachHocBong(ByVal objDanhSachHocBong As ESSDanhSachHocBong) As Integer
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Return obj.ThemMoi_ESSDanhSachHocBong(objDanhSachHocBong)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhSachHocBong(ByVal objDanhSachHocBong As ESSDanhSachHocBong, ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Return obj.CapNhat_ESSDanhSachHocBong(objDanhSachHocBong, ID_phan_bo, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachHocBong(ByVal ID_phan_bo As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Return obj.Xoa_ESSDanhSachHocBong(ID_phan_bo)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhSachHocBong_SinhVien(ByVal ID_phan_bo As Integer, ByVal ID_sv As Integer) As Integer
            Try
                Dim obj As DanhSachHocBong_DataAccess = New DanhSachHocBong_DataAccess
                Return obj.Xoa_ESSDanhSachHocBong_SinhVien(ID_phan_bo, ID_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhSachHocBong As DataRow) As ESSDanhSachHocBong
            Dim result As ESSDanhSachHocBong
            Try
                result = New ESSDanhSachHocBong
                If drDanhSachHocBong("ID_phan_bo").ToString() <> "" Then result.ID_phan_bo = CType(drDanhSachHocBong("ID_phan_bo").ToString(), Integer)
                If drDanhSachHocBong("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachHocBong("ID_sv").ToString(), Integer)
                If drDanhSachHocBong("ID_xep_loai_hb").ToString() <> "" Then result.ID_xep_loai_hb = CType(drDanhSachHocBong("ID_xep_loai_hb").ToString(), Integer)
                If drDanhSachHocBong("HB_HT").ToString() <> "" Then result.HB_HT = CType(drDanhSachHocBong("HB_HT").ToString(), Integer)
                If drDanhSachHocBong("HB_CS").ToString() <> "" Then result.HB_CS = CType(drDanhSachHocBong("HB_CS").ToString(), Integer)
                If drDanhSachHocBong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachHocBong("Hoc_ky").ToString(), Integer)
                If drDanhSachHocBong("Nam_hoc").ToString() <> "" Then result.Nam_hoc = CType(drDanhSachHocBong("Nam_hoc").ToString(), String)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
        ' Conver ra object quỹ học bỏng của một sinh viên
        Private Function MappingQHBSinhVien(ByVal drDanhSachHocBong As DataRow) As ESSDanhSachHocBong
            Dim result As ESSDanhSachHocBong
            Try
                result = New ESSDanhSachHocBong
                If drDanhSachHocBong("Nam_hoc").ToString() <> "" Then result.Nam_hoc = drDanhSachHocBong("Nam_hoc").ToString()
                If drDanhSachHocBong("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhSachHocBong("Hoc_ky").ToString(), Integer)
                If drDanhSachHocBong("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhSachHocBong("ID_sv").ToString(), Integer)
                If drDanhSachHocBong("HB_HT").ToString() <> "" Then result.HB_HT = CType(drDanhSachHocBong("HB_HT").ToString(), Integer)
                If drDanhSachHocBong("HB_CS").ToString() <> "" Then result.HB_CS = CType(drDanhSachHocBong("HB_CS").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace
