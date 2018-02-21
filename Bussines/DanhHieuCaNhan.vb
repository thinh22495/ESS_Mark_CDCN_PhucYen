Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class DanhHieuThiDuaCaNhan_Bussines
        Private arrDanhHieuCaNhan As New ArrayList
        Private dsXepLoaiHocTap As ESSXepLoaiHocTap
        Private dsXepLoaiHocTap_thangdiem10 As New ESSXeploaihoctap_thangdiem10
        Private dtXLRL As DataTable
        Private clsDanhHieu As DanhHieu_Bussines
        Private mdtDsSinhVien As DataTable
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal dsID_lops As String)
            Try
                ' Danh hiệu cá nhân
                clsDanhHieu = New DanhHieu_Bussines
                ' Xếp loại ht và rèn luyện
                Dim clsXepLoaiHT As New ESSXepLoaiHocTap
                Dim clsDHCN As New DanhHieuThiDuaCaNhan_DataAccess
                dtXLRL = clsDHCN.HienThi_ESSXLRenLuyen()
                Dim dtXLHT As DataTable = clsDHCN.HienThi_ESSXepLoaiHocTap()
                dsXepLoaiHocTap = New ESSXepLoaiHocTap
                For i As Integer = 0 To dtXLHT.Rows.Count - 1
                    Dim objXepLoaiHocTap As New ESSXepLoaiHocTap
                    objXepLoaiHocTap.ID_xep_loai = dtXLHT.Rows(i)("ID_xep_loai")
                    objXepLoaiHocTap.Tu_diem = dtXLHT.Rows(i)("Tu_diem")
                    objXepLoaiHocTap.Den_diem = dtXLHT.Rows(i)("Den_diem")
                    objXepLoaiHocTap.Xep_loai = dtXLHT.Rows(i)("Xep_loai")
                    dsXepLoaiHocTap.Add(objXepLoaiHocTap)
                Next
                'Load xep lai hoc tap thang ESSDiem 10
                HienThi_ESSXepLoaiHocTap_Thangdiem10()
                Dim obj As DanhHieuThiDuaCaNhan_DataAccess = New DanhHieuThiDuaCaNhan_DataAccess
                Dim dt As DataTable = obj.HienThi_ESSDanhHieuThiDuaCaNhan_DanhSach(dsID_lops)
                Dim objDanhHieuThiDuaCaNhan As ESSDanhHieuThiDuaCaNhan = Nothing
                For i As Integer = 0 To dt.Rows.Count - 1
                    objDanhHieuThiDuaCaNhan = New ESSDanhHieuThiDuaCaNhan
                    objDanhHieuThiDuaCaNhan = Mapping(dt.Rows(i))
                    arrDanhHieuCaNhan.Add(objDanhHieuThiDuaCaNhan)
                Next
                mdtDsSinhVien = obj.HienThi_ESSDSSV_DanhSach(dsID_lops)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        Function LoadDanhHieu_ID_Danhhieu(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String, ByVal ID_he As Integer, ByVal Khoa_hoc As Integer, ByVal ID_danh_hieu As Integer) As DataTable
            Dim clsDHCN As New DanhHieuThiDuaCaNhan_DataAccess
            Return clsDHCN.HienThi_ESSDanhHieuThiDua(Hoc_ky, Nam_hoc, ID_he, Khoa_hoc, ID_danh_hieu)
        End Function
        Private Sub HienThi_ESSXepLoaiHocTap_Thangdiem10()
            Dim dtXepLoaiHocTap_Thangdiem10 As DataTable
            Dim clsDAL As New Diem_DataAccess
            'Load các học phần thuộc các chương trình đào tạo
            dtXepLoaiHocTap_Thangdiem10 = clsDAL.HienThi_ESSXepLoaiHocTap_thangdiem10()
            For i As Integer = 0 To dtXepLoaiHocTap_Thangdiem10.Rows.Count - 1
                Dim objXepLoaiHocTap As New ESSXeploaihoctap_thangdiem10
                objXepLoaiHocTap.ID_xep_loai = dtXepLoaiHocTap_Thangdiem10.Rows(i)("ID_xep_loai")
                objXepLoaiHocTap.Tu_diem = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Tu_diem")
                objXepLoaiHocTap.Den_diem = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Den_diem")
                objXepLoaiHocTap.Xep_loai = dtXepLoaiHocTap_Thangdiem10.Rows(i)("Xep_loai")
                dsXepLoaiHocTap_thangdiem10.Add(objXepLoaiHocTap)
            Next
        End Sub

        ' Load danh sách sinh viên đủ điều kiện xét danh hiệu thi đua
        Public Function DanhSach_XetDanhHieu(ByVal dtSinhVien As DataTable, ByVal dtDiemSinhVien As DataTable, ByVal dtKl As DataTable, ByVal dtRLSinhVien As DataTable, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataView
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Gioi_tinh", GetType(String))
                dt.Columns.Add("ID_quoc_tich", GetType(Integer))
                dt.Columns.Add("Quoc_tich", GetType(String))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("Ten_khoa", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_loai_ht", GetType(String))
                dt.Columns.Add("Tong_diem_rl", GetType(Double))
                dt.Columns.Add("Xep_loai_rl", GetType(String))
                dt.Columns.Add("DiemRLQD", GetType(Double))
                dt.Columns.Add("TBCMR", GetType(Double))
                dt.Columns.Add("Danh_hieu", GetType(String))
                dt.Columns.Add("ID_danh_hieu", GetType(Integer))
                dt.Columns.Add("DT", GetType(String))
                dt.Columns.Add("Ten_DT", GetType(String))
                Dim row As DataRow
                For i As Integer = 0 To dtDiemSinhVien.Rows.Count - 1
                    For j As Integer = 0 To mdtDsSinhVien.Rows.Count - 1
                        If dtDiemSinhVien.Rows(i)("ID_sv") = mdtDsSinhVien.Rows(j)("ID_sv") Then
                            ' Lọc sinh viên kỷ luật
                            dtKl.DefaultView.RowFilter = "ID_sv=" & mdtDsSinhVien.Rows(j)("ID_sv")
                            'If dtKl.DefaultView.Count > 0 Then Exit For
                            ' Lọc điểm rèn luyện của sinh viên
                            dtRLSinhVien.DefaultView.RowFilter = "ID_sv=" & mdtDsSinhVien.Rows(j)("ID_sv")
                            If dtRLSinhVien.DefaultView.Count <= 0 Then Exit For
                            ' Không nợ môn và phải không bị kỷ luật và ID_xep_loai >=1 and ID_xep_loai <= 3(từ khá trở lên) và tổng  điểm ID_xep_loai >=1 ID_xep_loai <=3 từ khá trở lên
                            If IIf(IsDBNull(dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")), 0, dtDiemSinhVien.Rows(i)("So_mon_no_xet_hoc_bong")) = 0 And dtKl.DefaultView.Count <= 0 And dtDiemSinhVien.Rows(i)("ID_xep_loai") >= 1 And dtDiemSinhVien.Rows(i)("ID_xep_loai") <= 3 And IIf(dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai").ToString = "", 0, dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")) >= 1 And IIf(dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai").ToString = "", 0, dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai")) <= 3 Then
                                row = dt.NewRow
                                row("Chon") = False
                                row("ID_sv") = mdtDsSinhVien.Rows(j)("ID_sv")
                                row("Ma_sv") = mdtDsSinhVien.Rows(j)("Ma_sv").ToString
                                row("Ho_ten") = mdtDsSinhVien.Rows(j)("Ho_ten").ToString
                                row("Ngay_sinh") = mdtDsSinhVien.Rows(j)("Ngay_sinh")
                                row("Gioi_tinh") = mdtDsSinhVien.Rows(j)("Gioi_tinh")
                                row("ID_quoc_tich") = mdtDsSinhVien.Rows(j)("ID_quoc_tich")
                                row("Quoc_tich") = mdtDsSinhVien.Rows(j)("Quoc_tich")
                                row("Ten_lop") = mdtDsSinhVien.Rows(j)("Ten_lop")
                                row("Ten_khoa") = mdtDsSinhVien.Rows(j)("Ten_khoa")
                                row("TBCHT") = CDbl(dtDiemSinhVien.Rows(i)("TBCHT10"))
                                row("Xep_loai_ht") = dtDiemSinhVien.Rows(i)("Xep_loai")
                                row("DT") = mdtDsSinhVien.Rows(j)("Ma_dt").ToString
                                row("Ten_DT") = mdtDsSinhVien.Rows(j)("Ten_dt").ToString
                                If dtRLSinhVien.DefaultView.Count > 0 Then
                                    row("DiemRLQD") = CDbl(dtRLSinhVien.DefaultView.Item(0).Item("Diem_quy_doi"))
                                    row("Tong_diem_rl") = CDbl(dtRLSinhVien.DefaultView.Item(0).Item("Tong_diem"))
                                    row("Xep_loai_rl") = dtRLSinhVien.DefaultView.Item(0).Item("Xep_loai").ToString
                                Else
                                    row("DiemRLQD") = 0
                                    row("Tong_diem_rl") = 0
                                    row("Xep_loai_rl") = ""
                                End If
                                row("TBCMR") = CDbl(IIf(row("TBCHT").ToString = "", 0, row("TBCHT")) + IIf(row("DiemRLQD").ToString = "", 0, row("DiemRLQD")))
                                ' Xếp loại ren luyen
                                If dtDiemSinhVien.Rows(i)("ID_xep_loai") = 1 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") = 1 Then
                                    row("Danh_hieu") = clsDanhHieu.Danh_hieu(1).ToString
                                    row("ID_danh_hieu") = 1
                                ElseIf dtDiemSinhVien.Rows(i)("ID_xep_loai") <= 2 And dtDiemSinhVien.Rows(i)("ID_xep_loai") > 0 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") <= 2 Then ' Xếp loại hb giỏi
                                    row("Danh_hieu") = clsDanhHieu.Danh_hieu(2).ToString
                                    row("ID_danh_hieu") = 2
                                ElseIf dtDiemSinhVien.Rows(i)("ID_xep_loai") <= 3 And dtDiemSinhVien.Rows(i)("ID_xep_loai") > 0 And dtRLSinhVien.DefaultView.Item(0).Item("ID_xep_loai") <= 3 Then ' Xếp loại hb khá
                                    row("Danh_hieu") = clsDanhHieu.Danh_hieu(3).ToString
                                    row("ID_danh_hieu") = 3
                                End If
                                dt.Rows.Add(row)
                            End If
                        End If
                    Next
                Next
                ' Loại bỏ danh sách đã xét
                Dim dtDaXet As DataTable
                dtDaXet = DanhSach_DaXet(Hoc_ky, Nam_hoc)
                For i As Integer = dt.Rows.Count - 1 To 0 Step -1
                    For j As Integer = 0 To dtDaXet.Rows.Count - 1
                        If dt.Rows(i)("ID_sv") = dtDaXet.Rows(j)("ID_sv") Then
                            dt.Rows(i).Delete()
                            dt.AcceptChanges()
                            Exit For
                        End If
                    Next
                Next
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sách các sinh viên đã được xết danh hiệu thi đua
        Public Function DanhSach_DaXet(ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Boolean))
                dt.Columns.Add("ID_sv", GetType(Integer))
                dt.Columns.Add("Ma_sv", GetType(String))
                dt.Columns.Add("Ho_ten", GetType(String))
                dt.Columns.Add("Ngay_sinh", GetType(Date))
                dt.Columns.Add("Ten_lop", GetType(String))
                dt.Columns.Add("TBCHT", GetType(Double))
                dt.Columns.Add("Xep_loai_ht", GetType(String))
                dt.Columns.Add("Tong_diem_rl", GetType(Double))
                dt.Columns.Add("Xep_loai_rl", GetType(String))
                dt.Columns.Add("DiemRLQD", GetType(Double))
                dt.Columns.Add("TBCMR", GetType(Double))
                dt.Columns.Add("Danh_hieu", GetType(String))
                dt.Columns.Add("ID_danh_hieu", GetType(Integer))
                dt.Columns.Add("ID_lop", GetType(Integer))
                Dim row As DataRow
                Dim DH As New ESSDanhHieuThiDuaCaNhan
                For i As Integer = 0 To mdtDsSinhVien.Rows.Count - 1
                    For j As Integer = 0 To arrDanhHieuCaNhan.Count - 1
                        DH = arrDanhHieuCaNhan(j)
                        If mdtDsSinhVien.Rows(i)("ID_sv") = DH.ID_sv And DH.Hoc_ky = Hoc_ky And DH.Nam_hoc = Nam_hoc Then
                            row = dt.NewRow
                            row("Chon") = False
                            row("ID_sv") = DH.ID_sv
                            row("Ma_sv") = mdtDsSinhVien.Rows(i)("Ma_sv")
                            row("Ho_ten") = mdtDsSinhVien.Rows(i)("Ho_ten")
                            row("Ngay_sinh") = mdtDsSinhVien.Rows(i)("Ngay_sinh")
                            row("Ten_lop") = mdtDsSinhVien.Rows(i)("Ten_lop")
                            row("TBCHT") = DH.TBCHT
                            row("Xep_loai_ht") = dsXepLoaiHocTap_thangdiem10.ESSXeploaihoctap_thangdiem10(DH.TBCHT)
                            row("DiemRLQD") = DH.DRL
                            row("Tong_diem_rl") = DH.DRL * 100
                            Dim Xep_loai_rl As String = ""
                            For k As Integer = 0 To dtXLRL.Rows.Count - 1
                                If row("Tong_diem_rl") >= dtXLRL.Rows(k).Item("Tu_diem") And row("Tong_diem_rl") <= dtXLRL.Rows(k).Item("Den_diem") Then
                                    Xep_loai_rl = dtXLRL.Rows(k).Item("Xep_loai")
                                End If
                            Next
                            row("Xep_loai_rl") = Xep_loai_rl
                            row("TBCMR") = DH.TBCMR
                            row("ID_danh_hieu") = DH.ID_danh_hieu
                            row("Danh_hieu") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                            row("ID_lop") = DH.ID_lop
                            dt.Rows.Add(row)
                        End If
                    Next
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh hieu thi dua ca nhan cua 1 sinh vien (Dung load trong ho so)
        Public Function DanhHieuCaNhan(ByVal ID_sv As Integer) As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Nam_hoc", GetType(String))
                dt.Columns.Add("Hoc_ky1", GetType(String))
                dt.Columns.Add("Hoc_ky2", GetType(String))
                dt.Columns.Add("Ca_nam", GetType(String))
                Dim row As DataRow
                Dim DH As New ESSDanhHieuThiDuaCaNhan
                For j As Integer = 0 To arrDanhHieuCaNhan.Count - 1
                    DH = arrDanhHieuCaNhan(j)
                    If DH.ID_sv = ID_sv Then
                        row = dt.NewRow
                        row("Nam_hoc") = DH.Nam_hoc
                        If DH.Hoc_ky = 1 Then row("Hoc_ky1") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                        If DH.Hoc_ky = 2 Then
                            row("Hoc_ky2") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                            row("Ca_nam") = clsDanhHieu.Danh_hieu(DH.ID_danh_hieu).ToString
                        End If
                        dt.Rows.Add(row)
                    End If
                Next
                Dim dt1 As New DataTable
                dt1.Columns.Add("Nam_hoc")
                dt1.Columns.Add("Hoc_ky1")
                dt1.Columns.Add("Hoc_ky2")
                dt1.Columns.Add("Ca_nam")
                Dim dr As DataRow
                Dim Temp As String = ""
                For Each r As DataRow In dt.Rows
                    If Temp <> r("Nam_hoc") Then
                        dr = dt1.NewRow
                        dr("Nam_hoc") = r("Nam_hoc")
                        Dim Hoc_ky1 As String = ""
                        Dim Hoc_ky2 As String = ""
                        Dim Ca_nam As String = ""
                        For Each r1 As DataRow In dt.Rows
                            If r1("Nam_hoc") = r("Nam_hoc") Then
                                Hoc_ky1 += r1("Hoc_ky1").ToString
                                Hoc_ky2 += r1("Hoc_ky2").ToString
                                Ca_nam += r1("Ca_nam").ToString
                            End If
                        Next
                        dr("Hoc_ky1") = Hoc_ky1
                        dr("Hoc_ky2") = Hoc_ky2
                        dr("Ca_nam") = Ca_nam
                        dt1.Rows.Add(dr)
                        Temp = r("Nam_hoc")
                    End If
                Next
                Return dt1
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function ThemMoi_ESSDanhHieuThiDuaCaNhan(ByVal objDanhHieuThiDuaCaNhan As ESSDanhHieuThiDuaCaNhan) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DataAccess = New DanhHieuThiDuaCaNhan_DataAccess
                Return obj.ThemMoi_ESSDanhHieuThiDuaCaNhan(objDanhHieuThiDuaCaNhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CapNhat_ESSDanhHieuThiDuaCaNhan(ByVal objDanhHieuThiDuaCaNhan As ESSDanhHieuThiDuaCaNhan) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DataAccess = New DanhHieuThiDuaCaNhan_DataAccess
                Return obj.CapNhat_ESSDanhHieuThiDuaCaNhan(objDanhHieuThiDuaCaNhan)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function Xoa_ESSDanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Integer
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DataAccess = New DanhHieuThiDuaCaNhan_DataAccess
                Return obj.Xoa_ESSDanhHieuThiDuaCaNhan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function CheckExist_svDanhHieuThiDuaCaNhan(ByVal ID_sv As Integer, ByVal Hoc_ky As Integer, ByVal Nam_hoc As String) As Boolean
            Try
                Dim obj As DanhHieuThiDuaCaNhan_DataAccess = New DanhHieuThiDuaCaNhan_DataAccess
                Return obj.CheckExist_DanhHieuThiDuaCaNhan(ID_sv, Hoc_ky, Nam_hoc)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Function Mapping(ByVal drDanhHieuThiDuaCaNhan As DataRow) As ESSDanhHieuThiDuaCaNhan
            Dim result As ESSDanhHieuThiDuaCaNhan
            Try
                result = New ESSDanhHieuThiDuaCaNhan
                If drDanhHieuThiDuaCaNhan("ID_sv").ToString() <> "" Then result.ID_sv = CType(drDanhHieuThiDuaCaNhan("ID_sv").ToString(), Integer)
                If drDanhHieuThiDuaCaNhan("Hoc_ky").ToString() <> "" Then result.Hoc_ky = CType(drDanhHieuThiDuaCaNhan("Hoc_ky").ToString(), Integer)
                result.Nam_hoc = drDanhHieuThiDuaCaNhan("Nam_hoc").ToString()
                If drDanhHieuThiDuaCaNhan("TBCHT").ToString() <> "" Then result.TBCHT = CType(drDanhHieuThiDuaCaNhan("TBCHT").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("DRL").ToString() <> "" Then result.DRL = CType(drDanhHieuThiDuaCaNhan("DRL").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("TBCMR").ToString() <> "" Then result.TBCMR = CType(drDanhHieuThiDuaCaNhan("TBCMR").ToString(), Double)
                If drDanhHieuThiDuaCaNhan("ID_danh_hieu").ToString() <> "" Then result.ID_danh_hieu = CType(drDanhHieuThiDuaCaNhan("ID_danh_hieu").ToString(), Integer)
                If drDanhHieuThiDuaCaNhan("ID_lop").ToString() <> "" Then result.ID_lop = CType(drDanhHieuThiDuaCaNhan("ID_lop").ToString(), Integer)
            Catch ex As Exception
                Throw ex
            End Try
            Return result
        End Function
#End Region
    End Class
End Namespace

