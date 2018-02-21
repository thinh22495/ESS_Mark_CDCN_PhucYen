'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Scheduling_Bussines
#Region "Variable"
        Private _Ky_dang_ky As Integer
        Private _Dot As Integer
        Private _Hoc_ky As Integer
        Private _Nam_hoc As String
        Private _Tu_ngay As Date
        Private _Den_ngay As Date
        Private sks As Sukiens
        Private sk_gv As SukienKhacs
        Private sk_ph As SukienKhacs
        Private sk_lp As SukienKhacs
        Private lps As LopTinChi_Bussines
        Private gvs As GiaoVien_Bussines
        Private phs As PhongHoc_Bussines
        Private _update As Boolean
        Private _TKB_change As Boolean
        Private _Thu_xep_TKB As New ArrayList()
        Private _Lop_xep_TKB As New ArrayList()
#End Region

#Region "construct"
        Public Sub New()

        End Sub
        Public Sub New(ByVal Ky_dang_ky As Integer)
            Try
                Me._Ky_dang_ky = Ky_dang_ky
                Dim clsDAL As New MonTinChi_DataAccess
                Dim dtKyDangKy As DataTable
                'Đọc tham số hệ thống
                Doc_tham_so_he_thong()
                'Load thời gian trong học kỳ
                dtKyDangKy = clsDAL.HienThi_ESSHocKyDangKy_DanhSach(Ky_dang_ky)
                If dtKyDangKy.Rows.Count > 0 Then
                    _Dot = dtKyDangKy.Rows(0)("Dot")
                    _Hoc_ky = dtKyDangKy.Rows(0)("Hoc_ky")
                    _Nam_hoc = dtKyDangKy.Rows(0)("Nam_hoc")
                    _Tu_ngay = dtKyDangKy.Rows(0)("Tu_ngay")
                    _Den_ngay = dtKyDangKy.Rows(0)("Den_ngay")
                End If
                'Đọc các tham số hệ thống
                Call Doc_tham_so_he_thong()

                lps = New LopTinChi_Bussines(_Ky_dang_ky)
                gvs = New GiaoVien_Bussines()
                phs = New PhongHoc_Bussines()
                sks = New Sukiens

                'Đọc các sự kiện đã có trong ESSTKB
                Read_from_sukien()

                'Đọc các sự kiện trong kế hoạch
                Read_from_kehoach()

                'Chia_tiet()

                Khoa_sk_thieu_dulieu()

                Doc_sk_gv()
                Doc_sk_lop()
                Doc_sk_phong()

                Tinh_suc_tai_GV()

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "DB"
        Public Sub SaveDB()
            Try
                Dim cls As New Scheduling_DLL
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).ID_phong = 116 Then
                        sks.Sukien(i).ID_phong = 116
                    End If
                    If sks.Sukien(i).Update Then
                        cls.SuKiensTinChi_UpdateDB(sks.Sukien(i))
                    Else
                        cls.SuKiensTinChi_InsertDB(sks.Sukien(i))
                    End If
                Next
                _TKB_change = False
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub DeleteDB()
            Try
                Dim cls As New Scheduling_DLL
                cls.SuKiensTinChi_DeleteDB(_Ky_dang_ky)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub SuKiensTinChi_InsertDB(ByVal sk As ESSSu_kien)
            Try
                Dim cls As New Scheduling_DLL
                cls.SuKiensTinChi_InsertDB(sk)
                'Add them su kien
                sks.Add(sk)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub SuKiensTinChi_Remove(ByVal idx_sk As Integer, ByVal ID As Integer)
            Try
                Dim cls As New Scheduling_DLL
                cls.SuKiensTinChi_Delete(ID)
                'Add them su kien
                sks.Remove(idx_sk)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub SuKiensTinChi_UpdateDB(ByVal idx_sk As Integer, ByVal So_tiet As Integer, ByVal Gan_so_tiet As Boolean)
            Try
                Dim sk As ESSSu_kien
                sk = CType(sks.Sukien(idx_sk), ESSSu_kien)
                If Gan_so_tiet Then
                    CType(sks.Sukien(idx_sk), ESSSu_kien).So_tiet = So_tiet
                End If
                Dim cls As New Scheduling_DLL
                If sk.ID <> -1 Then
                    cls.SuKiensTinChi_UpdateDB(sk)
                Else
                    cls.SuKiensTinChi_InsertDB(sk)
                End If

            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function SuKiensTinChi_Check(ByVal sk As ESSSu_kien) As Integer
            Try
                Dim cls As New Scheduling_DLL
                Return cls.SuKiensTinChi_Check(sk)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Private Sub Read_from_kehoach()
            Try
                Dim cls As New Scheduling_DLL
                Dim dt As DataTable
                dt = cls.SuKiensTinChi_Read_from_KHM(_Ky_dang_ky)
                If dt.Rows.Count > 0 Then
                    For i As Integer = 0 To dt.Rows.Count - 1
                        Dim sk As New ESSSu_kien
                        sk.ID_cb = CInt("0" + dt.Rows(i)("ID_cb").ToString)
                        sk.Ten = dt.Rows(i)("Ten").ToString()
                        sk.Hoten = dt.Rows(i)("Ho_ten").ToString()

                        sk.ID_lop_tc = CInt(dt.Rows(i)("ID_lop_tc"))

                        If dt.Rows(i)("ID_lop_lt") = 0 Then
                            sk.Ten_lop = dt.Rows(i)("Ky_hieu_lop_tc") + "." + dt.Rows(i)("STT_lop").ToString + "_LT"
                        Else
                            sk.Ten_lop = dt.Rows(i)("Ky_hieu_lop_tc") + "." + dt.Rows(i)("STT_lop").ToString + "_TH" + "." + dt.Rows(i)("STT_lop_lt").ToString
                        End If

                        sk.ID_phong = CInt("0" + dt.Rows(i)("ID_phong").ToString)
                        sk.Ten_phong = dt.Rows(i)("So_phong").ToString()

                        sk.ID_mon = CInt(dt.Rows(i)("ID_mon"))
                        sk.ID_bm = CInt(dt.Rows(i)("ID_bm"))
                        sk.Ten_mon = dt.Rows(i)("Ten_mon").ToString()
                        sk.Ky_hieu = dt.Rows(i)("Ky_hieu").ToString()

                        sk.So_tiet = CInt("0" + dt.Rows(i)("So_tiet_tuan").ToString)
                        If CInt("0" + dt.Rows(i)("ID_lop_lt").ToString) = 0 Then
                            sk.Loai_tiet = 0  'Lý thuyết
                        Else
                            sk.Loai_tiet = 1  'thực hành
                        End If
                        If dt.Rows(i)("Ca_hoc").ToString = "" Then
                            sk.Ca_hoc = eCA_HOC.KHONG_XAC_DINH
                        Else
                            sk.Ca_hoc = CInt(dt.Rows(i)("Ca_hoc"))
                        End If
                        sks.Add(sk)
                    Next
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Read_from_sukien()
            Try
                Dim cls As New Scheduling_DLL
                Dim dt As DataTable
                dt = cls.SuKiensTinChi_Read_from_sukien(_Ky_dang_ky)
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim row As DataRow = dt.Rows(i)
                    Dim sk As New ESSSu_kien
                    sk.ID = CLng(row("ID"))
                    sk.ID_lop_tc = CInt(row("ID_lop_tc"))
                    sk.ID_mon = CInt(row("ID_mon"))
                    sk.ID_bm = CInt(row("ID_bm"))
                    sk.ID_phong = CInt(row("ID_phong").ToString())
                    sk.ID_cb = CInt(row("ID_cb").ToString())
                    sk.So_tiet = CInt(row("So_tiet"))
                    sk.Ten = row("Ten").ToString()
                    sk.Hoten = row("Ho_ten").ToString()
                    If row("ID_lop_lt") = 0 Then
                        sk.Ten_lop = row("Ky_hieu_lop_tc") + "." + row("STT_lop").ToString + "_LT"
                    Else
                        sk.Ten_lop = row("Ky_hieu_lop_tc") + "." + row("STT_lop").ToString + "_TH" + "." + row("STT_lop_lt").ToString
                    End If
                    sk.Ky_hieu = row("Ky_hieu").ToString()
                    sk.Ten_mon = row("Ten_mon").ToString()
                    sk.Ten_phong = row("So_phong").ToString() + row("Ten_nha").ToString()
                    sk.Ca_hoc = CInt(row("Ca_hoc"))
                    sk.Thu = CInt(row("Thu"))
                    sk.Tiet = CInt(row("Tiet"))
                    sk.Loai_tiet = CInt(row("Loai_tiet"))
                    sk.Da_xep_lich = row("Da_xep_lich")
                    sk.Update = True
                    sk.Tu_ngay = row("Tu_ngay")
                    sk.Den_ngay = row("Den_ngay")
                    sks.Add(sk)
                Next
                FillData()
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Sub getNgay_kh_cb(ByVal idx_gv As Integer, ByRef Tu_ngay As String, ByRef Den_ngay As String)
            Tu_ngay = ""
            Den_ngay = ""
        End Sub
        Public Sub getNgay_kh_lop(ByVal idx_lop As Integer, ByRef Tu_ngay As String, ByRef Den_ngay As String)
            Tu_ngay = ""
            Den_ngay = ""
        End Sub
        Public Sub getNgay_kh_phong(ByVal idx_phong As Integer, ByRef Tu_ngay As String, ByRef Den_ngay As String)
            Tu_ngay = ""
            Den_ngay = ""
        End Sub
        Public Sub FillData()
            Dim idx_gv As Integer
            Dim idx_ph As Integer
            Dim idx_lp As Integer
            Dim i As Integer = 0
            Try
                For i = 0 To sks.Count - 1
                    If sks.Sukien(i).Thu <> eTHU.KHONG_XAC_DINH Then
                        idx_gv = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(i).ID_cb)
                        idx_ph = phs.Tim_chi_so(sks.Sukien(i).ID_phong)
                        idx_lp = lps.Tim_chi_so(sks.Sukien(i).ID_lop_tc)

                        If idx_gv <> -1 Then
                            For t As Integer = sks.Sukien(i).Tiet To sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet - 1
                                gvs.Giaovien(idx_gv).ESSTKB(CInt(sks.Sukien(i).Thu), t) = i
                            Next
                        End If

                        If idx_ph <> -1 Then
                            For t As Integer = sks.Sukien(i).Tiet To sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet - 1
                                phs.Phong_hoc(idx_ph).ESSTKB(CInt(sks.Sukien(i).Thu), t) = i
                            Next
                        End If

                        If idx_lp <> -1 Then
                            For t As Integer = sks.Sukien(i).Tiet To sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet - 1
                                lps.ESSLop(idx_lp).ESSTKB(CInt(sks.Sukien(i).Thu), t) = i
                            Next
                        End If
                    End If
                Next
            Catch ex As Exception
                Dim a As Integer = i
                Throw ex
            End Try
        End Sub
#End Region

#Region "Su kien ngoai khoa"
        Private Sub Doc_sk_lop()
            Dim cls As New Scheduling_DLL
            Dim dt As DataTable
            Try
                dt = cls.SuKienKhacLopTinChi(_Ky_dang_ky)
                sk_lp = New SukienKhacs

                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim skk As New ESSSukien_lop
                    skk.ID = dt.Rows(i)("ID")
                    skk.ID_lop_tc = dt.Rows(i)("ID_lop_tc")
                    skk.Mo_ta = dt.Rows(i)("Mo_ta")
                    skk.So_tiet = dt.Rows(i)("So_tiet")
                    skk.Ten_lop = dt.Rows(i)("Ten_lop_tc")
                    skk.Thu = dt.Rows(i)("Thu")
                    skk.Tiet = dt.Rows(i)("Tiet")
                    sk_lp.Add(skk)
                    Dim stt As Integer = lps.Tim_chi_so(skk.ID_lop_tc)
                    If stt >= 0 Then
                        For t As Integer = skk.Tiet To skk.Tiet + skk.So_tiet - 1
                            lps.ESSLop(stt).ESSTKB(skk.Thu, t) = sk_lp.Count - 1
                            lps.ESSLop(stt).Loai_sk(skk.Thu, t) = eLOAI_SK.LK_LOP
                        Next
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Doc_sk_phong()
            Dim cls As New Scheduling_DLL
            Dim dt As DataTable
            Try
                sk_ph = New SukienKhacs
                dt = cls.SuKienKhacPhongTinChi()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim skk As New ESSSukien_phong
                    skk.ID = dt.Rows(i)("ID")
                    skk.ID_phong = dt.Rows(i)("ID_phong")
                    skk.Ten_phong = dt.Rows(i)("So_phong")
                    skk.Mo_ta = dt.Rows(i)("Mo_ta")
                    skk.So_tiet = dt.Rows(i)("So_tiet")
                    skk.Thu = dt.Rows(i)("Thu")
                    skk.Tiet = dt.Rows(i)("Tiet")
                    sk_ph.Add(skk)
                    Dim stt As Integer = phs.Tim_chi_so(skk.ID_phong)
                    If stt >= 0 Then
                        For t As Integer = skk.Tiet To skk.Tiet + skk.So_tiet - 1
                            phs.Phong_hoc(stt).ESSTKB(skk.Thu, t) = sk_ph.Count - 1
                            phs.Phong_hoc(stt).Loai_sk(skk.Thu, t) = eLOAI_SK.LK_PHONG
                        Next
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Private Sub Doc_sk_gv()
            Dim cls As New Scheduling_DLL
            Dim dt As DataTable
            Try
                sk_gv = New SukienKhacs
                dt = cls.SuKienKhacGiaoVienTinChi()
                For i As Integer = 0 To dt.Rows.Count - 1
                    Dim skk As New ESSSukien_gv
                    skk.ID = dt.Rows(i)("ID")
                    skk.ID_cb = dt.Rows(i)("ID_cb")
                    skk.Ten_gv = dt.Rows(i)("Ten")
                    skk.Mo_ta = dt.Rows(i)("Mo_ta")
                    skk.So_tiet = dt.Rows(i)("So_tiet")
                    skk.Thu = dt.Rows(i)("Thu")
                    skk.Tiet = dt.Rows(i)("Tiet")
                    sk_gv.Add(skk)
                    Dim stt As Integer = gvs.Tim_chi_so_theo_ID_cb(skk.ID_cb)
                    If stt >= 0 Then
                        For t As Integer = skk.Tiet To skk.Tiet + skk.So_tiet - 1
                            gvs.Giaovien(stt).ESSTKB(skk.Thu, t) = sk_gv.Count - 1
                            gvs.Giaovien(stt).Loai_sk(skk.Thu, t) = eLOAI_SK.LK_GV
                        Next
                    End If
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function Loai_sk_gv(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If gvs.Giaovien(stt).ESSTKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_GV
        End Function
        Public Sub dat_sk_nk_gv(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal So_tiet As Integer, ByVal mo_ta As String)
            If gvs.Giaovien(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                gvs.Giaovien(stt).ESSTKB(thu, tiet) > -1 Then
                Return
            End If

            If gvs.Giaovien(stt).ESSTKB(thu, tiet) >= 0 Then
                sk_gv.sk_gv(gvs.Giaovien(stt).ESSTKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    For t As Integer = tiet To tiet + So_tiet - 1
                        gvs.Giaovien(stt).Loai_sk(thu, t) = eLOAI_SK.LICH_HOC
                        gvs.Giaovien(stt).ESSTKB(thu, t) = -1
                    Next
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New ESSSukien_gv
                    skk.ID_cb = gvs.Giaovien(stt).ID_cb
                    skk.Ten_gv = gvs.Giaovien(stt).Ten
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    skk.So_tiet = So_tiet
                    ' Them no vao mang de quan ly
                    sk_gv.Add(skk)
                    For t As Integer = tiet To tiet + So_tiet - 1
                        gvs.Giaovien(stt).ESSTKB(thu, t) = sk_gv.Count - 1
                        gvs.Giaovien(stt).Loai_sk(thu, t) = eLOAI_SK.LK_GV
                    Next
                End If
            End If
            _TKB_change = True
        End Sub
        Public Function Loai_sk_phong(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If phs.Phong_hoc(stt).ESSTKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_PHONG
        End Function
        Public Sub dat_sk_nk_phong(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal So_tiet As Integer, ByVal mo_ta As String)
            If phs.Phong_hoc(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                phs.Phong_hoc(stt).ESSTKB(thu, tiet) > -1 Then
                Return
            End If

            If phs.Phong_hoc(stt).ESSTKB(thu, tiet) >= 0 Then
                sk_ph.sk_phong(phs.Phong_hoc(stt).ESSTKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    For t As Integer = tiet To tiet + So_tiet - 1
                        phs.Phong_hoc(stt).Loai_sk(thu, t) = eLOAI_SK.LICH_HOC
                        phs.Phong_hoc(stt).ESSTKB(thu, t) = -1
                    Next
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New ESSSukien_phong
                    skk.ID_phong = phs.Phong_hoc(stt).ID_phong
                    skk.Ten_phong = phs.Phong_hoc(stt).So_phong
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    skk.So_tiet = So_tiet
                    ' Them no vao mang de quan ly
                    sk_ph.Add(skk)
                    For t As Integer = tiet To tiet + So_tiet - 1
                        phs.Phong_hoc(stt).ESSTKB(thu, t) = sk_ph.Count - 1
                        phs.Phong_hoc(stt).Loai_sk(thu, t) = eLOAI_SK.LK_PHONG
                    Next
                End If
            End If
            _TKB_change = True
        End Sub
        Public Function Loai_sk_lop(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            If lps.ESSLop(stt).ESSTKB(thu, tiet) = -1 Then Return -1
            ' so hieu > -1
            If lps.ESSLop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                Return eLOAI_SK.LICH_HOC
            End If

            Return eLOAI_SK.LK_LOP
        End Function
        Public Sub dat_sk_nk_lop(ByVal stt As Integer, ByVal thu As Integer, ByVal tiet As Integer, ByVal So_tiet As Integer, ByVal mo_ta As String)
            If lps.ESSLop(stt).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC And _
                lps.ESSLop(stt).ESSTKB(thu, tiet) > -1 Then
                Return
            End If

            If lps.ESSLop(stt).ESSTKB(thu, tiet) >= 0 Then
                sk_lp.sk_lop(lps.ESSLop(stt).ESSTKB(thu, tiet)).Mo_ta = mo_ta
                If mo_ta = "" Then
                    For t As Integer = tiet To tiet + So_tiet - 1
                        lps.ESSLop(stt).ESSTKB(thu, t) = -1
                        lps.ESSLop(stt).Loai_sk(thu, t) = eLOAI_SK.LICH_HOC
                    Next
                End If
            Else
                ' Tao su kien moi
                If mo_ta.Trim() <> "" Then
                    Dim skk As New ESSSukien_lop
                    skk.ID_lop_tc = lps.ESSLop(stt).ID_lop_tc
                    skk.Ten_lop = lps.ESSLop(stt).Ten_lop_tc
                    skk.Mo_ta = mo_ta
                    skk.Thu = thu
                    skk.Tiet = tiet
                    skk.So_tiet = So_tiet
                    ' Them no vao mang de quan ly
                    sk_lp.Add(skk)
                    For t As Integer = tiet To tiet + So_tiet - 1
                        lps.ESSLop(stt).ESSTKB(thu, t) = sk_lp.Count - 1
                        lps.ESSLop(stt).Loai_sk(thu, t) = eLOAI_SK.LK_LOP
                    Next
                End If
            End If
            _TKB_change = True
        End Sub
        Public Sub SuKienNgoaiKhoa_Save()
            Try
                Dim cls As New Scheduling_DLL
                ' giao vien
                For i As Integer = 0 To sk_gv.Count - 1
                    Dim skk As ESSSukien_gv = sk_gv.sk_gv(i)
                    cls.SuKiensKhacGiaoVienTinChi_Save(skk)
                Next
                ' phong hoc
                For i As Integer = 0 To sk_ph.Count - 1
                    Dim skk As ESSSukien_phong = sk_ph.sk_phong(i)
                    cls.SuKiensKhacPhongTinChi_Save(skk)
                Next
                ' ESSLop hoc
                For i As Integer = 0 To sk_lp.Count - 1
                    Dim skk As ESSSukien_lop = sk_lp.sk_lop(i)
                    cls.SuKiensKhacLopTinChi_Save(skk)
                Next
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region

#Region "fonction"
        Private Sub Khoa_sk_thieu_dulieu()
            ' Các sự kiện không đủ dữ liệu sẽ không được sử lý
            For i As Integer = 0 To sks.Count - 1
                'If sks.Sukien(i).ID_cb <= 0 Then sks.Sukien(i).Thieu_dulieu = True
                If sks.Sukien(i).ID_phong <= 0 Then sks.Sukien(i).Thieu_dulieu = True
            Next
        End Sub

        Private Sub Phan_bo_phong_hoc_tu_dong()
            Dim idx_ph As Integer
            ' Các sự kiện chưa có phòng học thì sẽ tìm cho phòng học thích hợp
            For idx_lop As Integer = 0 To lps.Count - 1
                For idx_sk As Integer = 0 To sks.Count - 1
                    If sks.Sukien(idx_sk).ID_phong <= 0 Then
                        If sks.Sukien(idx_sk).ID_lop_tc = lps.ESSLop(idx_lop).ID_lop_tc Then
                            'Tìm phòng thích hợp
                            idx_ph = Tim_phong(idx_sk)
                            'Nếu có phòng thì sẽ gán phòng cho sự kiện
                            If idx_ph >= 0 Then
                                For i As Integer = 0 To sks.Count - 1
                                    If sks.Sukien(i).ID_lop_tc = lps.ESSLop(idx_lop).ID_lop_tc And sks.Sukien(i).ID_phong <= 0 Then
                                        sks.Sukien(i).ID_phong = phs.Phong_hoc(idx_ph).ID_phong
                                        sks.Sukien(i).Ten_phong = phs.Phong_hoc(idx_ph).Ten_phong
                                        If sks.Sukien(i).ID_cb > 0 Then sks.Sukien(idx_sk).Thieu_dulieu = False
                                    End If
                                Next
                            Else
                                sks.Sukien(idx_sk).Thieu_dulieu = True
                            End If
                        End If
                    End If
                Next
            Next
        End Sub
        Private Sub Phan_cong_giao_vien_tu_dong()
            ' Các sự kiện chưa có giáo viên thì sẽ tìm cho giáo viên thích hợp
            Dim idx_gv As Integer
            For idx_lop As Integer = 0 To lps.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).ID_cb <= 0 And lps.ESSLop(idx_lop).ID_lop_tc = sks.Sukien(i).ID_lop_tc Then
                        'Tìm giáo viên thích hợp
                        idx_gv = Tim_giaovien(i)
                        If idx_gv >= 0 Then
                            For j As Integer = 0 To sks.Count - 1
                                If sks.Sukien(i).ID_cb <= 0 And _
                                (lps.ESSLop(idx_lop).ID_lop_tc = sks.Sukien(j).ID_lop_tc Or _
                                lps.ESSLop(idx_lop).ID_lop_lt = sks.Sukien(j).ID_lop_tc) Then
                                    'And sks.Sukien(j).ID_mon = ID_mon
                                    sks.Sukien(j).ID_cb = gvs.Giaovien(idx_gv).ID_cb
                                    sks.Sukien(j).Hoten = gvs.Giaovien(idx_gv).Ho_ten
                                    sks.Sukien(j).Ten = gvs.Giaovien(idx_gv).Ten
                                    If sks.Sukien(j).ID_phong > 0 Then sks.Sukien(j).Thieu_dulieu = False
                                End If
                            Next
                        Else
                            sks.Sukien(i).Thieu_dulieu = True
                        End If
                    End If
                Next
            Next

        End Sub
        Private Function Tim_giaovien(ByVal idx_sk As Integer) As Integer
            'Sắp xếp giáo viên theo thứ tự tăng dần
            Dim idx() As Integer = Sap_xep_GV(sks.Sukien(idx_sk).Ca_hoc)
            Dim idx_gv As Integer
            For i As Integer = 0 To gvs.Count - 1
                idx_gv = idx(i)
                'Kiểm tra xem giáo viên này có khả năng dạy môn này hay không?
                For m As Integer = 0 To gvs.Giaovien(idx_gv).MonDay.Count - 1
                    If gvs.Giaovien(idx_gv).MonDay.MonDay(m).ID_mon = sks.Sukien(idx_sk).ID_mon Then
                        'Kiểm tra phòng đã xếp cho các sự kiện khác đã vượt quá số giờ mà phòng có thể đảm nhận 
                        If Count_giaovien(idx_gv, sks.Sukien(idx_sk).Ca_hoc) + 1 <= Tong_so_sk_tuan_ca / 2 Then
                            Return idx_gv
                        End If
                    End If
                Next
            Next
            Return -1
        End Function
        Private Function Tim_giao_vien_roi(ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Integer
            'Sắp xếp giáo viên theo mức độ căng của giáo viên
            Dim idx() As Integer = Sap_xep_GV()
            Dim idx_gv As Integer
            For i As Integer = 0 To idx.Length - 1
                idx_gv = idx(i)
                'If (Sched_Day_Giaovien(idx_gv, thu, tiet)) And gvs.Giaovien(idx_gv).ID_bm = sks.Sukien(idx_sk).ID_bm Then
                '    Return idx_gv
                'End If
            Next
            Return -1
        End Function

        Private Function Sap_xep_GV(ByVal Ca_hoc As Integer) As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các giáo viên theo thứ tự giảm dần 
            ' về độ căng giảng dạy (hay còn gọi một tên khác là sức tải của giáo viên)
            Dim idx(gvs.Count - 1) As Integer
            Dim tt As Integer
            For i As Integer = 0 To gvs.Count - 1
                idx(i) = i
            Next
            For i As Integer = 0 To gvs.Count - 2
                For j As Integer = i + 1 To gvs.Count - 1
                    If Count_giaovien(i, Ca_hoc) < Count_giaovien(j, Ca_hoc) Then
                        tt = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function
        Private Function Tim_phong(ByVal idx_sk As Integer) As Integer
            'Sắp xếp phòng học theo sức chứa từ nhỏ đến lớn
            Dim idx() As Integer = Sap_xep_phong_hoc()
            Dim idx_ph, idx_lop As Integer
            Dim So_sv As Integer
            idx_lop = lps.Tim_chi_so(sks.Sukien(idx_sk).ID_lop_tc)
            So_sv = lps.ESSLop(idx_lop).So_sv_max
            For i As Integer = 0 To idx.Length - 1
                idx_ph = idx(i)
                'Sức chứa của phòng đủ chỗ cho số sinh viên tối đa
                If phs.Phong_hoc(idx_ph).Suc_chua >= So_sv Then
                    'Kiểm tra phòng đã xếp cho các sự kiện khác đã vượt quá số giờ mà phòng có thể đảm nhận 
                    If Count_phong(idx_ph, sks.Sukien(idx_sk).Ca_hoc) + 1 <= Tong_so_sk_tuan_ca Then
                        Return idx_ph
                    End If
                End If
            Next
            Return -1
        End Function
        Private Function Tim_phong_roi(ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Integer
            ' cac phong cho tiet le trung toa nha
            'Sắp xếp phòng học theo sức chứa từ nhỏ đến lớn
            Dim idx() As Integer = Sap_xep_phong_hoc()
            Dim idx_ph As Integer
            For i As Integer = 0 To idx.Length - 1
                idx_ph = idx(i)
                If (Sched_Day_Phong(idx_ph, idx_sk, thu, tiet)) Then
                    Return idx_ph
                End If
            Next
            Return -1
        End Function

        Private Function Count_phong(ByVal idx_phong As Integer, ByVal Ca_hoc As Integer) As Integer
            Dim ID_phong As Integer = phs.Phong_hoc(idx_phong).ID_phong
            Dim Count As Integer = 0
            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).ID_phong = ID_phong And sks.Sukien(i).Ca_hoc = Ca_hoc Then
                    Count += 1
                End If
            Next
            Return Count
        End Function
        Private Function Count_giaovien(ByVal idx_gv As Integer, ByVal Ca_hoc As Integer) As Integer
            Dim ID_cb As Integer = gvs.Giaovien(idx_gv).ID_cb
            Dim Count As Integer = 0
            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).ID_cb = ID_cb And sks.Sukien(i).Ca_hoc = Ca_hoc Then
                    Count += 1
                End If
            Next
            Return Count
        End Function
        Private Function Sap_xep_phong_hoc() As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các phòng học theo thứ tự tăng dần 
            ' về sức chứa của phòng học 
            Dim idx(phs.Count - 1) As Integer

            For i As Integer = 0 To phs.Count - 1
                idx(i) = i
            Next

            For i As Integer = 0 To phs.Count - 2
                For j As Integer = i + 1 To phs.Count - 1
                    If phs.Phong_hoc(i).Suc_chua > phs.Phong_hoc(j).Suc_chua Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function

        Private Function Thongtin_gv(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            ' Tất cả các hàm đều sử dụng hàm này để lấy thông tin về giáo viên 
            ' bao gồm: Tên lớp ký hiệu tên phòng giảng.......
            If gvs.Giaovien(idx).ESSTKB(thu, tiet) = -1 Then Return ""
            If gvs.Giaovien(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then
                Dim skk As ESSSukien_gv = sk_gv.sk_gv(gvs.Giaovien(idx).ESSTKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As ESSSu_kien = CType(sks.Sukien(gvs.Giaovien(idx).ESSTKB(thu, tiet)), ESSSu_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ten_lop + vbCrLf + sk.Ten_phong & Chr(10)
                Else
                    Return sk.Ten_lop + vbCrLf + sk.Ten_phong
                End If
            End If
        End Function
        Private Function Thongtin_phong(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            If phs.Phong_hoc(idx).ESSTKB(thu, tiet) = -1 Then Return ""
            If phs.Phong_hoc(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then
                Dim skk As ESSSukien_phong = sk_ph.sk_phong(phs.Phong_hoc(idx).ESSTKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As ESSSu_kien = CType(sks.Sukien(phs.Phong_hoc(idx).ESSTKB(thu, tiet)), ESSSu_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Ten_lop & Chr(10)
                Else
                    Return sk.Ten_lop
                End If
            End If
        End Function
        Private Function Thongtin_lop(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As String
            If lps.ESSLop(idx).ESSTKB(thu, tiet) = -1 Then Return ""
            If lps.ESSLop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then
                Dim skk As ESSSukien_lop = sk_lp.sk_lop(lps.ESSLop(idx).ESSTKB(thu, tiet))
                Return skk.Mo_ta + vbCr
            Else
                Dim sk As ESSSu_kien = CType(sks.Sukien(lps.ESSLop(idx).ESSTKB(thu, tiet)), ESSSu_kien)
                If sk.Loai_tiet = eLOAI_TIET.THUC_HANH Then
                    Return sk.Hoten + vbCrLf + sk.Ten_phong & Chr(10)
                Else
                    Return sk.Hoten + vbCrLf + sk.Ten_phong
                End If
            End If
        End Function
        Private Function Thoi_gian_hoc(ByVal idx As Integer) As String
            Try
                Dim Thoi_gian As String = ""
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    For tiet As Integer = 0 To So_tiet_ngay - 1
                        If lps.ESSLop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LICH_HOC Then
                            If lps.ESSLop(idx).ESSTKB(thu, tiet) <> -1 Then
                                Dim sk As ESSSu_kien = CType(sks.Sukien(lps.ESSLop(idx).ESSTKB(thu, tiet)), ESSSu_kien)
                                If thu + 2 <= 7 Then
                                    Thoi_gian += "Thứ " + (sk.Thu + 2).ToString + "(T" + (sk.Tiet + 1).ToString + "-" + (sk.Tiet + sk.So_tiet).ToString + ")" + vbCrLf
                                Else
                                    Thoi_gian += "Chủ nhật" + "(T" + (sk.Tiet + 1).ToString + "-" + (sk.Tiet + sk.So_tiet).ToString + ")" + vbCrLf
                                End If
                                tiet += sk.So_tiet
                            End If
                        End If
                    Next
                Next
                'Bổ sung thêm ghi chú lớp
                For i As Integer = 0 To sk_lp.Count - 1
                    Dim skk As New ESSSukien_lop
                    skk = sk_lp.sk_lop(i)
                    If skk.ID_lop_tc = lps.ESSLop(idx).ID_lop_tc Then
                        Thoi_gian += skk.Mo_ta
                    End If
                Next
                Return Thoi_gian
            Catch ex As Exception
                Throw ex
            End Try
            Return ""
        End Function

        Private Function CalCol(ByVal thu As Integer, ByVal tiet As Integer, ByVal offset As Integer) As Integer
            ' Sẽ làm nhiệm vụ tính cột thứ bao 
            ' nhiêu đối với việc sinh ESSTKB tổng hợp
            Return thu * So_tiet_ngay + tiet + offset
        End Function
        'Private Sub Chia_tiet()
        '    ' Chia nhóm tiết 
        '    ' Ban đầu các sự kiện có số nhóm tiết là số tiết / tuần
        '    ' sau đó chúng ta sẽ chia ra các SK có số tiết = nhóm tiết đơn vị
        '    ' Còn thừa lại ta không sử lý
        '    Dim i As Integer = 0
        '    Do While i <= sks.Count - 1

        '        If sks.Sukien(i).So_tiet > So_tiet_min Then
        '            Dim skn As ESSSu_kien = sks.Sukien(i).Clone()
        '            Select Case sks.Sukien(i).So_tiet
        '                Case 4, 5
        '                    sks.Sukien(i).So_tiet = 2
        '                    skn.So_tiet -= 2
        '                Case 6
        '                    sks.Sukien(i).So_tiet = 3
        '                    skn.So_tiet -= 3
        '                Case Else
        '                    sks.Sukien(i).So_tiet = So_tiet_min
        '                    skn.So_tiet -= So_tiet_min

        '            End Select
        '            sks.Add(skn)
        '        End If
        '        i += 1
        '    Loop
        'End Sub
        Public Function Able_to_Sched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            ' Tính toán xem có thể xếp lịch vào thời điểm này không
            ' giá trị trả về là có hoặc không
            ' = -2 không thể xếp lịch vì trái ca
            ' = -3 Đã xếp lịch ngoại khoá
            ' > 0 đã xếp lịch tại ô này
            ' = -1 chưa xếp lịch
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then
                If tiet >= So_tiet_ca Then Return -2
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then
                If Not (tiet >= So_tiet_ca And tiet < So_tiet_ca * 2) Then Return -2
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then
                If tiet < So_tiet_ca * 2 Then Return -2
            End If
            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
            'Đã xếp lịch ngoại khoá của lớp
            If idx_lop <> -1 Then
                If lps.ESSLop(idx_lop).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then Return -3
                If lps.ESSLop(idx_lop).ESSTKB(thu, tiet) <> -1 Then Return lps.ESSLop(idx_lop).ESSTKB(thu, tiet)

                'Kiểm tra ràng buộc giưã lớp lý thuyết và lớp thực hành
                If sks.Sukien(idx).Loai_tiet = eLOAI_TIET.LY_THUYET Then
                    'Kiem tra cac ESSLop ly thuyet này có bị trùng lịch vào lớp thực hành không
                    For i As Integer = 0 To lps.Count - 1
                        If lps.ESSLop(i).ID_lop_lt = sks.Sukien(idx).ID_lop_tc Then
                            If lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then Return lps.ESSLop(i).ESSTKB(thu, tiet)
                        End If
                    Next
                Else
                    'Kiem tra cac ESSLop thuc hanh có trùng vào lịch lý thuyết không
                    Dim idx_lop1 As Integer = Tim_idx_lop(sks.Sukien(idx).ID_lop_tc)
                    'Lay ESSLop ly thuyet cua ESSLop thuc hanh nay
                    Dim ID_lop_lt As Integer = lps.ESSLop(idx_lop1).ID_lop_lt
                    For i As Integer = 0 To lps.Count - 1
                        If ID_lop_lt = lps.ESSLop(i).ID_lop_tc Then
                            If lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then Return lps.ESSLop(i).ESSTKB(thu, tiet)
                        End If
                    Next
                End If
            End If

            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            'Đã xếp lịch ngoại khoá của giáo viên
            If idx_gv <> -1 Then
                If gvs.Giaovien(idx_gv).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then Return -3
                If gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) <> -1 Then Return gvs.Giaovien(idx_gv).ESSTKB(thu, tiet)
            End If
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            'Đã xếp lịch ngoại khoá của phòng học
            If idx_ph <> -1 Then
                If phs.Phong_hoc(idx_ph).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then Return -3
                If phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) <> -1 Then Return phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet)
            End If
            Return (-1)
        End Function
        Public Sub UnSched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer)
            ' Huỷ lịch của 1 sự kiện phải huỷ theo 3 chiều
            ' lớp, giáo viên, phòng.
            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
            If idx_lop <> -1 Then lps.ESSLop(idx_lop).ESSTKB(thu, tiet) = -1

            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            If idx_gv <> -1 Then gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) = -1

            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            If idx_ph <> -1 Then phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) = -1

            sks.Sukien(idx).Thu = -1
            sks.Sukien(idx).Tiet = -1
            sks.Sukien(idx).Da_xep_lich = False
            _TKB_change = True
        End Sub
        Public Function UnSched_gv(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            ' Huỷ theo từng chiều ở đây là giáo viên
            ' idx là số thứ tự của giáo viên
            If gvs.Giaovien(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_GV Then Return False
            Dim idx_sk As Integer = gvs.Giaovien(idx).ESSTKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function
        Public Function UnSched_phong(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            If phs.Phong_hoc(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_PHONG Then Return False
            Dim idx_sk As Integer = phs.Phong_hoc(idx).ESSTKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function
        Public Function UnSched_lop(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            If lps.ESSLop(idx).Loai_sk(thu, tiet) = eLOAI_SK.LK_LOP Then Return False
            Dim idx_sk As Integer = lps.ESSLop(idx).ESSTKB(thu, tiet)
            If idx_sk = -1 Then Return False
            UnSched(idx_sk, thu, tiet)
            _TKB_change = True
            Return True
        End Function

        Public Sub Sched(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer)
            ' Xếp lịhc cho một sự kiện có số thứ tự là idx
            If sks.Sukien(idx).Thieu_dulieu Then Return

            Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
            If idx_lop >= 0 Then
                If lps.ESSLop(idx_lop).ESSTKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá lớp")
                Else
                    For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                        lps.ESSLop(idx_lop).ESSTKB(thu, t) = idx
                    Next
                End If
            End If
            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            If idx_gv >= 0 Then
                If gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá giáo viên")
                Else
                    For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                        gvs.Giaovien(idx_gv).ESSTKB(thu, t) = idx
                    Next
                End If
            End If
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            If idx_ph >= 0 Then
                If phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) <> -1 Then
                    'Throw New Exception("Trùng lịch ngoại khoá phòng học")
                Else
                    For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                        phs.Phong_hoc(idx_ph).ESSTKB(thu, t) = idx
                    Next
                End If
            End If
            sks.Sukien(idx).Thu = thu
            sks.Sukien(idx).Tiet = tiet
            sks.Sukien(idx).Da_xep_lich = True
            _TKB_change = True

        End Sub

        Private Function Sched_Day_Giaovien(ByVal idx_gv As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) <> -1 Then Return False
            Return True
        End Function

        Private Function Sched_Day_Phong(ByVal idx_ph As Integer, ByVal idx_sk As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If idx_sk <> -1 Then
                Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx_sk).ID_lop_tc)
                If phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) <> -1 Or phs.Phong_hoc(idx_ph).Suc_chua < lps.ESSLop(idx_lop).So_sv_max Then Return False
            End If
            Return True
        End Function

        Private Function Sched_Day_Lop(ByVal idx_lop As Integer, ByVal thu As eTHU, ByVal tiet As Integer) As Boolean
            If lps.ESSLop(idx_lop).ESSTKB(thu, tiet) <> -1 Then Return False
            Return True
        End Function

        Public Function UpdateTKB(ByVal idx_sk As Integer, ByVal Ca_hoc As Integer, ByVal Thu As Integer, ByVal Tu_tiet As Integer, ByVal Den_tiet As Integer, ByVal ID_phong As Integer, ByVal ID_cb As Integer) As Integer
            If idx_sk >= 0 Then
                sks.Sukien(idx_sk).Ca_hoc = Ca_hoc
                sks.Sukien(idx_sk).Thu = Thu
                sks.Sukien(idx_sk).Tiet = Tu_tiet
                sks.Sukien(idx_sk).So_tiet = (Den_tiet - Tu_tiet) + 1
                sks.Sukien(idx_sk).ID_phong = ID_phong
                sks.Sukien(idx_sk).ID_cb = ID_cb
            End If
        End Function

        Public Function UpdateTKB_Phong(ByVal idx_sk As Integer, ByVal ID_phong As Integer) As Integer
            If idx_sk >= 0 Then
                sks.Sukien(idx_sk).ID_phong = ID_phong
            End If
        End Function


        Public Function UpdateTKB_CanBo(ByVal idx_sk As Integer, ByVal ID_cb As Integer) As Integer
            If idx_sk >= 0 Then
                sks.Sukien(idx_sk).ID_cb = ID_cb
            End If
        End Function



        Public Function KiemTraTKB(ByVal idx_sk As Integer, ByVal Ca_hoc As Integer, ByVal Thu As Integer, ByVal Tu_tiet As Integer, ByVal Den_tiet As Integer, ByVal ID_phong As Integer, ByVal ID_cb As Integer, ByRef sThongBaoTrung As String) As Integer
            If Ca_hoc >= 0 And Thu >= 0 And Tu_tiet >= 0 Then
                For i As Integer = 0 To sks.Count - 1
                    If i <> idx_sk Then
                        'Kiem tra phong hoc
                        If ID_phong > 0 Then
                            'If sks.Sukien(i).ID_phong = 116 Then
                            '    ID_phong = 116
                            'End If
                            'If ID_phong = 173 And sks.Sukien(i).Ca_hoc = 0 And sks.Sukien(i).Thu = 0 Then
                            '    ID_phong = 173
                            'End If
                            If Ca_hoc = sks.Sukien(i).Ca_hoc And _
                               Thu = sks.Sukien(i).Thu And _
                               (sks.Sukien(i).Tiet <= Tu_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Tu_tiet Or _
                              sks.Sukien(i).Tiet >= Tu_tiet And sks.Sukien(i).Tiet <= Den_tiet Or _
                              sks.Sukien(i).Tiet <= Den_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Den_tiet Or _
                              sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Tu_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet <= Den_tiet) And _
                               ID_phong = sks.Sukien(i).ID_phong And _
                                (sks.Sukien(i).Tu_ngay <= Tu_ngay And sks.Sukien(i).Den_ngay >= Tu_ngay Or _
                                sks.Sukien(i).Tu_ngay <= Den_ngay And sks.Sukien(i).Den_ngay >= Den_ngay Or _
                                Tu_ngay <= sks.Sukien(i).Tu_ngay And Den_ngay >= sks.Sukien(i).Tu_ngay Or _
                                Tu_ngay <= sks.Sukien(i).Den_ngay And Den_ngay >= sks.Sukien(i).Den_ngay) Then
                                If MsgBox("Trùng phòng học: Tại thời điểm này phòng học đã được sử dụng ở lớp: " + sks.Sukien(i).Ten_lop + ", Bạn có cho phép không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                    sThongBaoTrung = "Trùng phòng học"
                                    Return 1
                                End If
                            End If
                        End If
                        'Kiem tra can bo
                        If ID_cb > 0 Then
                            If Ca_hoc = sks.Sukien(i).Ca_hoc And _
                              Thu = sks.Sukien(i).Thu And _
                              (sks.Sukien(i).Tiet <= Tu_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Tu_tiet Or _
                              sks.Sukien(i).Tiet >= Tu_tiet And sks.Sukien(i).Tiet <= Den_tiet Or _
                              sks.Sukien(i).Tiet <= Den_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Den_tiet Or _
                              sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet > Tu_tiet And sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet <= Den_tiet) And _
                              ID_cb = sks.Sukien(i).ID_cb And _
                               (sks.Sukien(i).Tu_ngay <= Tu_ngay And sks.Sukien(i).Den_ngay >= Tu_ngay Or _
                               sks.Sukien(i).Tu_ngay <= Den_ngay And sks.Sukien(i).Den_ngay >= Den_ngay Or _
                               Tu_ngay <= sks.Sukien(i).Tu_ngay And Den_ngay >= sks.Sukien(i).Tu_ngay Or _
                               Tu_ngay <= sks.Sukien(i).Den_ngay And Den_ngay >= sks.Sukien(i).Den_ngay) Then
                                If MsgBox("Trùng giáo viên: Tại thời điểm này giáo viên đã được sử dụng ở lớp: " + sks.Sukien(i).Ten_lop + ", Bạn có cho phép không ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                                    sThongBaoTrung = "Trùng phòng học"
                                    Return 2
                                End If
                                'sThongBaoTrung = "Trùng giáo viên: Tại thời điểm này giáo viên đã được sử dụng ở lớp: " + sks.Sukien(i).Ten_lop
                                'Return 2
                            End If
                        End If
                    End If
                Next
            End If
            sThongBaoTrung = ""
            Return 0
        End Function
        Public Function KiemTraTKB(ByVal ID_sk As Integer) As Integer
            Dim max As Integer
            Dim min As Integer
            Dim flag As Integer
            Dim idx As Integer
            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).ID = ID_sk Then
                    idx = i
                    Exit For
                End If
            Next
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' chieu
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    'Duyệt từ tiết bắt đầu đến số tiết của sự kiện
                    flag = 0
                    For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                        flag = KiemTraGiaoVien_PhongHoc(idx, thu, t)
                        If flag <> -1 Then
                            Return flag
                        End If
                    Next
                Next
            Next
        End Function

        Private Function KiemTraGiaoVien_PhongHoc(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Integer
            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            'Đã xếp lịch ngoại khoá của giáo viên
            If idx_gv <> -1 Then
                If gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) <> -1 And gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) <> idx Then
                    Return 2
                End If
            End If
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            'Đã xếp lịch ngoại khoá của phòng học
            If idx_ph <> -1 Then
                If phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) <> -1 And phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) <> idx Then
                    Return 1
                End If
            End If
            Return (-1)
        End Function

        Private Function Auto_Sched(ByVal idx As Integer) As Boolean
            ' Tự động tìm ô trống cho 1 sự kiện 
            ' và xếp 1 sự kiện này. idx là số thứ tự sự kiện
            Dim max As Integer
            Dim min As Integer
            Dim flag As Boolean
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' chieu
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                For tiet As Integer = min To max
                    Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
                    If Accept_thu(thu) And Accept_lop(idx_lop) Then
                        'Duyệt từ tiết bắt đầu đến số tiết của sự kiện
                        flag = False
                        For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                            If Able_to_Sched(idx, thu, t) = -1 Then
                                flag = True
                            Else
                                flag = False
                                Exit For
                            End If
                        Next
                        'Nếu tất cả các tiết rỗi thì cho phép xếp
                        If flag And (tiet = 0 Or tiet + sks.Sukien(idx).So_tiet - 1 = max) Then
                            Sched(idx, thu, tiet)
                            Return True
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Private Function Auto_Sched0(ByVal idx As Integer) As Boolean
            ' Nếu cả giáo viên và lớp cùng rỗi tại thời điểm này
            ' thì chúng ta sẽ xếp lịch cho nó. còn không thì
            Dim max As Integer
            Dim min As Integer
            Dim flag As Boolean
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' chieu
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
                    If Accept_thu(thu) And Accept_lop(idx_lop) Then
                        'Duyệt từ tiết bắt đầu đến số tiết của sự kiện
                        flag = False
                        For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                            If Able_to_Sched(idx, thu, t) = -1 And Accept_nhom_dang_ky(idx_lop, thu, t) Then
                                flag = True
                            Else
                                flag = False
                                Exit For
                            End If
                        Next
                        'Nếu tất cả các tiết rỗi thì cho phép xếp
                        If flag And (tiet = 0 Or tiet + sks.Sukien(idx).So_tiet - 1 = max) Then
                            Sched(idx, thu, tiet)
                            Return True
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Private Function Auto_Sched1(ByVal idx As Integer) As Boolean
            'Tìm giáo viên và phòng học thích hợp để xếp cho sự kiện này
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' toi
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            Dim idx_phong, idx_gv As Integer
            For tiet As Integer = min To max
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    Dim idx_lop As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
                    If Sched_Day_Lop(idx_lop, thu, tiet) Then
                        'Tìm phòng khác rỗi tại thời điểm này để gán cho sự kiện
                        If sks.Sukien(idx).ID_phong > 0 Then
                            idx_phong = Tim_idx_phong(sks.Sukien(idx).ID_phong)
                            If idx_phong <> -1 Then
                                If Not Sched_Day_Phong(idx_phong, idx, thu, tiet) Then
                                    idx_phong = Tim_phong_roi(idx, thu, tiet)
                                End If
                            End If
                        Else
                            idx_phong = Tim_phong_roi(idx, thu, tiet)
                        End If
                        'Tìm giáo viên khác rỗi tại thời điểm này để gán cho sự kiện
                        If sks.Sukien(idx).ID_cb > 0 Then
                            idx_gv = Tim_idx_gv(sks.Sukien(idx).ID_cb)
                            If idx_gv <> -1 Then
                                If Not Sched_Day_Giaovien(idx_gv, thu, tiet) Then
                                    idx_gv = Tim_giao_vien_roi(idx, thu, tiet)
                                End If
                            End If
                        Else
                            idx_gv = Tim_giao_vien_roi(idx, thu, tiet)
                        End If
                        If idx_phong <> -1 And idx_gv <> -1 Then
                            sks.Sukien(idx).ID_phong = phs.Phong_hoc(idx_phong).ID_phong
                            sks.Sukien(idx).ID_cb = gvs.Giaovien(idx_gv).ID_cb
                            sks.Sukien(idx).Thieu_dulieu = False
                            Sched(idx, thu, tiet)
                            Return True
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Public Sub Xep_tu_dong_ly_thuyet()
            'Phân bổ phòng học tự động
            'Phan_bo_phong_hoc_tu_dong()
            'Phân bổ giáo viên tự động
            'Phan_cong_giao_vien_tu_dong()

            'Thuật toán xếp lịch
            'Sắp xếp thứ tự ưu tiên giáo viên cần xếp lịch trước
            Dim idx() As Integer = Sap_xep_nhom_dang_ky()
            '======================================================
            'Thực hiện xếp lịch cho từng giáo viên
            'idx sẽ chứa số thứ tự của giáo viên từ giáo viên 
            'Khó xếp nhất đến gv dễ xếp lịch nhất
            '======================================================
            'Thực hiện xếp giãn cách các môn học, tránh các môn liền tiết, liền thứ
            For i As Integer = 0 To idx.Length - 1
                For j As Integer = 0 To sks.Count - 1
                    With sks.Sukien(j)
                        If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.LY_THUYET Then
                            If .ID_lop_tc = lps.ESSLop(idx(i)).ID_lop_tc Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched0(j)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            'Tiếp tục xếp tiếp các sự kiện còn lại vẫn theo thiều ưu tiên của giáo viên
            For i As Integer = 0 To idx.Length - 1
                For j As Integer = 0 To sks.Count - 1
                    With sks.Sukien(j)
                        If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.LY_THUYET Then
                            If .ID_lop_tc = lps.ESSLop(idx(i)).ID_lop_tc Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched(j)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            '======================================================
            'Tất cả những sự kiện không xếp được lịch sẽ sử dụng tiếp thuật toán khác
            'Thuật toán 2: Tìm và đổi chỗ cho nhau
            '======================================================
            'Xep_tu_dong2_ly_thuyet()
        End Sub
        Public Sub Xep_tu_dong_thuc_hanh()
            'Thuật toán xếp lịch
            'Sắp xếp thứ tự ưu tiên giáo viên cần xếp lịch trước
            Dim idx() As Integer = Sap_xep_GV()
            '======================================================
            'Thực hiện xếp lịch cho từng giáo viên
            'idx sẽ chứa số thứ tự của giáo viên từ giáo viên 
            'Khó xếp nhất đến gv dễ xếp lịch nhất
            '======================================================
            'Thực hiện xếp giãn cách các môn học, tránh các môn liền tiết, liền thứ
            For j As Integer = 0 To gvs.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    With sks.Sukien(i)
                        If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.THUC_HANH Then
                            If .ID_cb = gvs.Giaovien(idx(j)).ID_cb Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched(i)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            'Tiếp tục xếp tiếp các sự kiện còn lại vẫn theo thiều ưu tiên của giáo viên
            For j As Integer = 0 To gvs.Count - 1
                For i As Integer = 0 To sks.Count - 1
                    With sks.Sukien(i)
                        If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.THUC_HANH Then
                            If .ID_cb = gvs.Giaovien(idx(j)).ID_cb Then
                                If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                                    (.So_tiet > 1) Then
                                    Auto_Sched(i)
                                End If
                            End If
                        End If
                    End With
                Next
            Next
            '======================================================
            'Tất cả những sự kiện không xếp được lịch sẽ sử dụng tiếp thuật toán khác
            'Thuật toán 2: Tìm và đổi chỗ cho nhau
            '======================================================
            'Xep_tu_dong2_thuc_hanh()
        End Sub

        Public Sub Xep_tu_dong2_ly_thuyet()
            ' Tìm kiếm các sự kiện lân cận đổi chỗ cho nhau
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.LY_THUYET Then
                        If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                            (.So_tiet > 1) Then
                            find_xchange(i)
                        End If
                    End If
                End With
            Next
        End Sub

        Public Sub Xep_tu_dong2_thuc_hanh()
            ' Tìm kiếm các sự kiện lân cận đổi chỗ cho nhau
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If Not .Thieu_dulieu And .Loai_tiet = eLOAI_TIET.THUC_HANH Then
                        If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                            (.So_tiet > 1) Then
                            find_xchange(i)
                        End If
                    End If
                End With
            Next
        End Sub

        Public Sub Xep_tu_dong3()
            'Tìm các sự kiện không xếp được để đổi phòng học, giáo viên khác
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If (.Thu = eTHU.KHONG_XAC_DINH) And (.Tiet = -1) And _
                        (.So_tiet > 1) Then
                        Auto_Sched(i)
                    End If
                End With
            Next
        End Sub

        Private Function Sap_xep_GV() As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các giáo viên theo thứ tự giảm dần 
            ' về độ căng giảng dạy (hay còn gọi một tên khác là sức tải của giáo viên)
            Dim idx(gvs.Count - 1) As Integer
            For i As Integer = 0 To gvs.Count - 1
                idx(i) = i
            Next
            For i As Integer = 0 To gvs.Count - 2
                For j As Integer = i + 1 To gvs.Count - 1
                    If gvs.Giaovien(idx(i)).Max_tiet > gvs.Giaovien(idx(j)).Max_tiet Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function

        Private Function Sap_xep_nhom_dang_ky() As Integer()
            ' Hàm này sau khi thực hiện sẽ cho chúng ta 
            ' chỉ số các giáo viên theo thứ tự giảm dần 
            ' về độ căng giảng dạy (hay còn gọi một tên khác là sức tải của giáo viên)
            Dim idx(lps.Count - 1) As Integer
            For i As Integer = 0 To lps.Count - 1
                idx(i) = i
            Next
            For i As Integer = 0 To lps.Count - 2
                For j As Integer = i + 1 To lps.Count - 1
                    If lps.ESSLop(idx(i)).Nhom_dang_ky = lps.ESSLop(idx(j)).Nhom_dang_ky Then
                        Dim tt As Integer = idx(i)
                        idx(i) = idx(j)
                        idx(j) = tt
                    End If
                Next
            Next
            Return idx
        End Function


        Private Sub Tinh_suc_tai_GV()
            For j As Integer = 0 To sks.Count - 1
                Dim sk As ESSSu_kien = sks.Sukien(j)
                Dim idx As Integer = gvs.Tim_chi_so_theo_ID_cb(sk.ID_cb)
                If idx <> -1 Then
                    If sk.Ca_hoc = eCA_HOC.SANG Then
                        gvs.Giaovien(idx).Tiet_Sang += 1
                    End If
                    If sk.Ca_hoc = eCA_HOC.CHIEU Then
                        gvs.Giaovien(idx).Tiet_Chieu += 1
                    End If
                End If
            Next
        End Sub

        Private Function blowup(ByVal idx As Integer, ByVal thu As Integer, ByVal tiet As Integer) As ArrayList
            'Huỷ tất cả các sự kiện liên quan đến sự kiện idx như cùng giáo viên, cùng lớp, cùng phòng học
            Dim a As New ArrayList
            'Duyệt 4 lần để kiểm tra: Trái ca, Lớp học, Giáo viên, Phòng học
            For i As Integer = 0 To 3
                Dim id As Integer = Able_to_Sched(idx, thu, tiet)
                If id = -2 Or id = -3 Then Return Nothing
                If id > 0 Then
                    UnSched(id, thu, tiet)
                    a.Add(id)
                End If
            Next
            Return a
        End Function

        Private Sub setback(ByVal a As ArrayList, ByVal thu As Integer, ByVal tiet As Integer)
            For i As Integer = 0 To a.Count - 1
                Dim idx As Integer = CInt(a(i))
                If sks.Sukien(idx).Da_xep_lich Then
                    UnSched(idx, sks.Sukien(idx).Thu, sks.Sukien(idx).Tiet)
                End If
            Next
            For i As Integer = 0 To a.Count - 1
                Sched(CInt(a(i)), thu, tiet)
            Next
        End Sub

        Private Function fillok(ByVal a As ArrayList) As Boolean
            For i As Integer = 0 To a.Count - 1
                If Not Auto_Sched(CInt(a(i))) Then Return False
            Next
            Return True
        End Function

        Private Function find_xchange(ByVal idx As Integer) As Boolean
            Dim max As Integer
            Dim min As Integer
            If sks.Sukien(idx).Ca_hoc = eCA_HOC.SANG Then 'sang
                min = 0
                max = So_tiet_ca - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.CHIEU Then  ' chieu
                min = So_tiet_ca
                max = So_tiet_ca * 2 - 1
            ElseIf sks.Sukien(idx).Ca_hoc = eCA_HOC.TOI Then   ' toi
                min = So_tiet_ca * 2
                max = So_tiet_ngay - 1
            Else  'tat ca cac ca
                min = 0
                max = So_tiet_ngay - 1
            End If
            Dim thu, tiet As Integer
            For thu = Thu_bat_dau To Thu_ket_thuc
                For tiet = min To max
                    'Tim tat ca nhung su kien lien quan den su kien nay nhu giao vien, phong hoc, ESSLop de huy di
                    Dim a As ArrayList = blowup(idx, thu, tiet)
                    If Not a Is Nothing Then
                        If a.Count > 0 Then
                            Sched(idx, thu, tiet)
                            'Tim xep cho nhung su kien bi ro ra xep vao cho khac
                            If fillok(a) Then
                                Return True 'Neu thanh cong thi se giai quyet dc tat ca cac su kien
                            Else
                                'Neu khong thi se khoi phuc lai ket qua truoc do
                                UnSched(idx, thu, tiet)
                                setback(a, thu, tiet)
                            End If
                        End If
                    End If
                Next
            Next
            Return False
        End Function

        Public Sub Huy_lich()
            ' Huỷ tất cả các lịch
            For i As Integer = 0 To sks.Count - 1
                With sks.Sukien(i)
                    If .Thu <> eTHU.KHONG_XAC_DINH _
                        And .Tiet <> -1 Then
                        UnSched(i, .Thu, .Tiet)
                    End If
                End With
            Next
        End Sub

        Public Sub Set_sukien(ByVal idx_sk As Integer, ByVal idx_gv As Integer, ByVal Ten_gv As String, ByVal idx_phong As Integer, ByVal Ten_phong As String, ByVal Ca_hoc As eCA_HOC)
            sks.Sukien(idx_sk).ID_cb = idx_gv
            sks.Sukien(idx_sk).Ten = Ten_gv
            sks.Sukien(idx_sk).ID_phong = idx_phong
            sks.Sukien(idx_sk).Ten_phong = Ten_phong
            sks.Sukien(idx_sk).Ca_hoc = Ca_hoc
            If sks.Sukien(idx_sk).ID_cb > 0 And sks.Sukien(idx_sk).ID_phong > 0 And sks.Sukien(idx_sk).Ca_hoc <> eCA_HOC.KHONG_XAC_DINH Then
                sks.Sukien(idx_sk).Thieu_dulieu = False
            End If
        End Sub

        Public Function Move_gv(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = gvs.Giaovien(idx).ESSTKB(thu1, tiet1)
            Dim idx2 As Integer = gvs.Giaovien(idx).ESSTKB(thu2, tiet2)

            Dim sk1 As ESSSu_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As ESSSu_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function

        Public Function Move_lp(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = lps.ESSLop(idx).ESSTKB(thu1, tiet1)
            Dim idx2 As Integer = lps.ESSLop(idx).ESSTKB(thu2, tiet2)

            Dim sk1 As ESSSu_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As ESSSu_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function

        Public Function Move_ph(ByVal idx As Integer, ByVal thu1 As Integer, ByVal tiet1 As Integer, ByVal thu2 As Integer, ByVal tiet2 As Integer) As Boolean
            ' Chung ta mac dinh rang sk1 la da xep lich, sk2 co the la su kien trong
            Dim idx1 As Integer = phs.Phong_hoc(idx).ESSTKB(thu1, tiet1)
            Dim idx2 As Integer = phs.Phong_hoc(idx).ESSTKB(thu2, tiet2)

            Dim sk1 As ESSSu_kien = sks.Sukien(idx1)
            If idx2 = -1 Then
                UnSched(idx1, thu1, tiet1)
                If Able_to_Sched(idx1, thu2, tiet2) = -1 Then
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If
                Sched(idx1, thu1, tiet1)
            Else ' chuyen doi 2 sk da xep lich
                Dim sk2 As ESSSu_kien = sks.Sukien(idx2)
                UnSched(idx2, thu2, tiet2)
                UnSched(idx1, thu1, tiet1)

                If Able_to_Sched(idx1, thu2, tiet2) = -1 And _
                    Able_to_Sched(idx2, thu1, tiet1) = -1 Then
                    Sched(idx2, thu1, tiet1)
                    Sched(idx1, thu2, tiet2)
                    Return True
                End If

                Sched(idx2, thu2, tiet2)
                Sched(idx1, thu1, tiet1)
            End If
            ' bo tay khong xep lich duoc 
            Return False
        End Function

        Public Function List_free_cell(ByVal idx As Integer) As ArrayList
            Dim mask As New ArrayList

            For tiet As Integer = 0 To So_tiet_ngay - 1
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    'For t As Integer = tiet To tiet + sks.Sukien(idx).So_tiet - 1
                    If Able_to_Sched(idx, thu, tiet) = -1 Then
                        mask.Add(New Point(thu, tiet))
                    End If
                    'Next
                Next
            Next
            Return mask
        End Function

        Private Function Trung(ByVal idx As Integer) As Boolean
            Dim idx_gv As Integer = gvs.Tim_chi_so_theo_ID_cb(sks.Sukien(idx).ID_cb)
            Dim idx_ph As Integer = phs.Tim_chi_so(sks.Sukien(idx).ID_phong)
            Dim idx_lp As Integer = lps.Tim_chi_so(sks.Sukien(idx).ID_lop_tc)
            For thu As Integer = 0 To Ngay_tuan - 1
                For tiet As Integer = 0 To So_tiet_ngay - 1
                    If thu <> sks.Sukien(idx).Thu And tiet <> sks.Sukien(idx).Tiet Then
                        If idx = gvs.Giaovien(idx_gv).ESSTKB(thu, tiet) Then Return True
                        If idx = phs.Phong_hoc(idx_ph).ESSTKB(thu, tiet) Then Return True
                        If idx = lps.ESSLop(idx_lp).ESSTKB(thu, tiet) Then Return True
                    End If
                Next
            Next
            Return False
        End Function

        Public Function Cac_sukien_trung() As String
            Dim s As String = ""
            For i As Integer = 0 To sks.Count - 1
                If Trung(i) Then s = s + i.ToString() + "."
            Next
            Return s
        End Function

        Public Function Tim_idx_gv(ByVal ID_cb As Integer) As Integer
            Return gvs.Tim_chi_so_theo_ID_cb(ID_cb)
        End Function
        Public Function Tim_idx_lop(ByVal ID_lop As Integer) As Integer
            Return lps.Tim_chi_so(ID_lop)
        End Function
        Public Function Tim_idx_phong(ByVal ID_phong As Integer) As Integer
            Return phs.Tim_chi_so(ID_phong)
        End Function

        Private Function Accept_mon_tiet(ByVal idx_sk As Integer, ByVal idx_lop As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            Dim tiet1 As Integer
            Select Case tiet
                Case 1
                    tiet1 = 2
                Case 2
                    tiet1 = 1
                Case 3
                    tiet1 = 2
            End Select
            If lps.ESSLop(idx_lop).ESSTKB(thu, tiet1) <> -1 Then
                Dim idx As Integer = lps.ESSLop(idx_lop).ESSTKB(thu, tiet1)
                If idx > -1 Then If sks.Sukien(idx_sk).ID_mon = sks.Sukien(idx).ID_mon Then Return False
            End If
            Return True
        End Function

        Private Function Accept_nhom_dang_ky(ByVal idx_lop As Integer, ByVal thu As Integer, ByVal tiet As Integer) As Boolean
            For i As Integer = 0 To lps.Count - 1
                If (lps.ESSLop(i).ID_mon_tc <> lps.ESSLop(idx_lop).ID_mon_tc) And _
                   (lps.ESSLop(i).Nhom_dang_ky = lps.ESSLop(idx_lop).Nhom_dang_ky) And lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then
                    Return False
                End If
            Next
            Return True
        End Function
        Private Function Accept_thu(ByVal thu As Integer) As Boolean
            If Thu_xep_TKB.Count = 0 Then
                Return True
            Else
                For i As Integer = 0 To Thu_xep_TKB.Count - 1
                    If Thu_xep_TKB(i) = thu Then
                        Return True
                    End If
                Next
            End If
            Return False
        End Function
        Private Function Accept_lop(ByVal idx_lop As Integer) As Boolean
            If Lop_xep_TKB.Count = 0 Or Lop_xep_TKB.Count = lps.Count Then
                Return True
            Else
                For i As Integer = 0 To Lop_xep_TKB.Count - 1
                    If Lop_xep_TKB(i) = idx_lop Then
                        Return True
                    End If
                Next
            End If
            Return False
        End Function
#End Region

#Region "Property"
        Public Property Lop_xep_TKB() As ArrayList
            Get
                Return Me._Lop_xep_TKB
            End Get
            Set(ByVal Value As ArrayList)
                Me._Lop_xep_TKB = Value
            End Set
        End Property
        Public Property Thu_xep_TKB() As ArrayList
            Get
                Return Me._Thu_xep_TKB
            End Get
            Set(ByVal Value As ArrayList)
                Me._Thu_xep_TKB = Value
            End Set
        End Property
        Public ReadOnly Property So_su_kien() As Integer
            Get
                Return sks.Count
            End Get
        End Property

        Public ReadOnly Property So_su_kien_chua_xep_lich() As Integer
            Get
                Dim no As Integer = 0
                For i As Integer = 0 To sks.Count - 1
                    If sks.Sukien(i).Thu = eTHU.KHONG_XAC_DINH Then no += 1
                Next
                Return no
            End Get
        End Property


        Public ReadOnly Property ds_sukiens() As Sukiens
            Get
                Return Me.sks
            End Get
        End Property

        Public Property TKB_change() As Boolean
            Get
                Return Me._TKB_change
            End Get
            Set(ByVal Value As Boolean)
                Me._TKB_change = Value
            End Set
        End Property
        Public Property Ky_dang_ky() As Integer
            Get
                Return _Ky_dang_ky
            End Get
            Set(ByVal Value As Integer)
                _Ky_dang_ky = Value
            End Set
        End Property
        Public Property Dot() As Integer
            Get
                Return _Dot
            End Get
            Set(ByVal Value As Integer)
                _Dot = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return _Hoc_ky
            End Get
            Set(ByVal Value As Integer)
                _Hoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return _Nam_hoc
            End Get
            Set(ByVal Value As String)
                _Nam_hoc = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return _Tu_ngay
            End Get
            Set(ByVal Value As Date)
                _Tu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return _Den_ngay
            End Get
            Set(ByVal Value As Date)
                _Den_ngay = Value
            End Set
        End Property
#End Region

#Region "Report"
        ' Các hàm trong report được sử dụng để hiển thị dữ liệu trên giao diện
        ' Hầu hết các hàm đều trả về DataTable để dễ hiển thị trên C1Flexgrid.
        ' Các đối tượng được tổ chức theo dạng gần giống với cơ sở dữ liệu quan hệ
        ' Tức là có các đối tượng đơn. Sau đó các đối tượng đơn được nhóm lại bởi
        ' arraylist. Và coi cả nhóm này là một đối tượng mới. Unisched lại tiếp 
        ' tục nhóm các đối tượng lớn này để quản lý chung. Khi truy cập hầu hết
        ' các truy cập được sử dụng thông qua các chỉ số. Trong các đối tượng chúng
        ' ta còn phải lưu thêm cả ID của các đối tượng đó, để tiện cho việc thực hiện
        ' thao tác với CSDL.
        Public Function List_su_kien() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ca", GetType(String))
            dt.Columns.Add("Thu", GetType(String))
            dt.Columns.Add("Tiet", GetType(String))
            dt.Columns.Add("So_tiet", GetType(Integer))
            dt.Columns.Add("Loai_tiet", GetType(String))

            For i As Integer = 0 To sks.Count - 1
                If sks.Sukien(i).Thu = eTHU.KHONG_XAC_DINH Then
                    Dim sk As ESSSu_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_phong") = sk.Ten_phong
                    row("Ky_hieu") = sk.Ky_hieu
                    row("Ten_mon") = sk.Ten_mon
                    row("Ten_giaovien") = sk.Hoten
                    row("Ten_lop") = sk.Ten_lop
                    row("Thu") = sk.Thu
                    row("Tiet") = sk.Tiet
                    row("Ca") = sk.Ca_hoc
                    row("So_tiet") = sk.So_tiet
                    row("Loai_tiet") = sk.Loai_tiet
                    dt.Rows.Add(row)
                End If
            Next

            Return dt
        End Function
        Public Function Baocao_TKB_Lop(Optional ByVal ID_mon_tc As Object = Nothing) As DataTable
            Dim dtLop As New DataTable
            Dim Ngay_dau, Ngay_cuoi As Date
            Dim Tuan_thu As Integer
            Dim phs As New PhongHoc_Bussines()
            Dim gvs As New GiaoVien_Bussines()
            Dim idx As Integer
            Dim Ky_hieu As String = ""
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("Ten_nganh", GetType(String))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("Chuyen_nganh", GetType(String))
            dtLop.Columns.Add("ID_bm", GetType(Integer))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(String))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ly_thuyet", GetType(Integer))
            dtLop.Columns.Add("Thuc_hanh", GetType(Integer))
            dtLop.Columns.Add("Bai_tap", GetType(Integer))
            dtLop.Columns.Add("Bai_tap_lon", GetType(Integer))
            dtLop.Columns.Add("Tong_tiet", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Giao_vien", GetType(String))
            dtLop.Columns.Add("Phong_hoc", GetType(String))
            dtLop.Columns.Add("Thoi_gian", GetType(String))
            'Load kế hoạch khác
            Dim mdtKeHoachKhac As DataTable
            Dim clsDAL As New MonTinChi_DataAccess
            mdtKeHoachKhac = clsDAL.HienThi_ESSKeHoachKhac_DanhSach(Hoc_ky, Nam_hoc)
            'Add các cột tuần trong kỳ đăng ký
            Tuan_thu = DatePart(DateInterval.WeekOfYear, Tu_ngay)
            Ngay_dau = Tu_ngay
            Ngay_cuoi = Ngay_dau.AddDays(1)
            Do While Ngay_cuoi <= Den_ngay
                If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                    dtLop.Columns.Add("T" + Tuan_thu.ToString)
                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                    Ngay_dau = Ngay_cuoi
                    Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                End If
                Ngay_cuoi = Ngay_cuoi.AddDays(1)
            Loop

            'Gán dữ liệu lớp
            For i As Integer = 0 To lps.Count - 1
                Dim dr As DataRow = dtLop.NewRow()
                dr("ID_he") = lps.ESSLop(i).ID_he
                dr("Ten_he") = lps.ESSLop(i).Ten_he
                dr("Khoa_hoc") = lps.ESSLop(i).Khoa_hoc
                dr("ID_khoa") = lps.ESSLop(i).ID_khoa
                dr("Ten_khoa") = lps.ESSLop(i).Ten_khoa
                dr("ID_nganh") = lps.ESSLop(i).ID_nganh
                dr("Ten_nganh") = lps.ESSLop(i).Ten_nganh
                dr("ID_chuyen_nganh") = lps.ESSLop(i).ID_chuyen_nganh
                dr("Chuyen_nganh") = lps.ESSLop(i).Chuyen_nganh
                dr("ID_BM") = lps.ESSLop(i).ID_BM
                dr("ID_mon_tc") = lps.ESSLop(i).ID_mon_tc
                dr("idx_lop") = i
                dr("Ky_hieu") = lps.ESSLop(i).Ky_hieu
                dr("Ten_mon") = lps.ESSLop(i).Ten_mon
                dr("So_hoc_trinh") = lps.ESSLop(i).So_hoc_trinh
                dr("Ly_thuyet") = lps.ESSLop(i).Ly_thuyet
                dr("Thuc_hanh") = lps.ESSLop(i).Thuc_hanh
                dr("Bai_tap") = lps.ESSLop(i).Bai_tap
                dr("Bai_tap_lon") = lps.ESSLop(i).Bai_tap_lon
                dr("Tong_tiet") = lps.ESSLop(i).Ly_thuyet + lps.ESSLop(i).Thuc_hanh + lps.ESSLop(i).Bai_tap + lps.ESSLop(i).Bai_tap_lon
                'Thông tin lớp
                dr("Ky_hieu_lop_tc") = lps.ESSLop(i).Ky_hieu_lop_tc
                dr("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc
                dr("So_sv_min") = lps.ESSLop(i).So_sv_min
                dr("So_sv_max") = lps.ESSLop(i).So_sv_max
                dr("So_tiet_tuan") = lps.ESSLop(i).So_tiet_tuan
                dr("Ca_hoc") = lps.ESSLop(i).Ten_ca_hoc
                dr("Giao_vien") = lps.ESSLop(i).Ho_ten_gv
                dr("Phong_hoc") = lps.ESSLop(i).Ten_phong
                idx = gvs.Tim_chi_so_theo_ID_cb(lps.ESSLop(i).ID_cb)
                If idx >= 0 Then dr("Giao_vien") = gvs.Giaovien(idx).Ho_ten
                idx = phs.Tim_chi_so(lps.ESSLop(i).ID_phong)
                If idx >= 0 Then dr("Phong_hoc") = phs.Phong_hoc(idx).Ten_phong
                dr("Thoi_gian") = Thoi_gian_hoc(i)
                dr("Tu_ngay") = lps.ESSLop(i).Tu_ngay
                dr("Den_ngay") = lps.ESSLop(i).Den_ngay

                'Add thông tin thời gian học của từng lớp
                Tuan_thu = DatePart(DateInterval.WeekOfYear, lps.ESSLop(i).Tu_ngay)
                Ngay_dau = lps.ESSLop(i).Tu_ngay
                Ngay_cuoi = Ngay_dau.AddDays(1)
                Do While Ngay_cuoi <= lps.ESSLop(i).Den_ngay
                    If Tuan_thu <> DatePart(DateInterval.WeekOfYear, Ngay_cuoi) And Ngay_cuoi.DayOfWeek = DayOfWeek.Sunday Then
                        'Kiểm tra xem tuần này có kế hoạch khác không?
                        Ky_hieu = CheckKeHoachKhac(mdtKeHoachKhac, Tuan_thu, dr("ID_he"), dr("ID_khoa"), dr("Khoa_hoc"), dr("ID_nganh"), dr("ID_chuyen_nganh"))
                        If Ky_hieu <> "" Then
                            dr("T" + Tuan_thu.ToString) = Ky_hieu
                        Else
                            dr("T" + Tuan_thu.ToString) = "H"
                        End If
                        Ngay_cuoi = Ngay_cuoi.AddDays(1)
                        Ngay_dau = Ngay_cuoi
                        Tuan_thu = DatePart(DateInterval.WeekOfYear, Ngay_cuoi)
                    End If
                    Ngay_cuoi = Ngay_cuoi.AddDays(1)
                Loop
                dtLop.Rows.Add(dr)
            Next
            dtLop.DefaultView.Sort = "Ten_mon"
            Return dtLop
        End Function

        Public Function Baocao_TKB_Lop_View(Optional ByVal ID_mon_tc As Object = Nothing) As DataTable
            Dim dtLop As New DataTable
            Dim phs As New PhongHoc_Bussines()
            Dim gvs As New GiaoVien_Bussines()
            Dim idx As Integer
            Dim Ky_hieu As String = ""
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("ID_he", GetType(Integer))
            dtLop.Columns.Add("Ten_he", GetType(String))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("Ten_khoa", GetType(String))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("Ten_nganh", GetType(String))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("Chuyen_nganh", GetType(String))
            dtLop.Columns.Add("ID_bm", GetType(Integer))
            dtLop.Columns.Add("Khoa_hoc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("idx_lop", GetType(String))
            dtLop.Columns.Add("Ky_hieu", GetType(String))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("So_hoc_trinh", GetType(Integer))
            dtLop.Columns.Add("Ly_thuyet", GetType(Integer))
            dtLop.Columns.Add("Thuc_hanh", GetType(Integer))
            dtLop.Columns.Add("Bai_tap", GetType(Integer))
            dtLop.Columns.Add("Bai_tap_lon", GetType(Integer))
            dtLop.Columns.Add("Tong_tiet", GetType(Integer))
            dtLop.Columns.Add("Ky_hieu_lop_tc", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("Giao_vien", GetType(String))
            dtLop.Columns.Add("Phong_hoc", GetType(String))
            dtLop.Columns.Add("Thoi_gian", GetType(String))
            'Load kế hoạch khác
            Dim mdtKeHoachKhac As DataTable
            Dim clsDAL As New MonTinChi_DataAccess
            mdtKeHoachKhac = clsDAL.HienThi_ESSKeHoachKhac_DanhSach(Hoc_ky, Nam_hoc)

            'Gán dữ liệu lớp
            For i As Integer = 0 To lps.Count - 1
                Dim dr As DataRow = dtLop.NewRow()
                dr("ID_he") = lps.ESSLop(i).ID_he
                dr("Ten_he") = lps.ESSLop(i).Ten_he
                dr("Khoa_hoc") = lps.ESSLop(i).Khoa_hoc
                dr("ID_khoa") = lps.ESSLop(i).ID_khoa
                dr("Ten_khoa") = lps.ESSLop(i).Ten_khoa
                dr("ID_nganh") = lps.ESSLop(i).ID_nganh
                dr("Ten_nganh") = lps.ESSLop(i).Ten_nganh
                dr("ID_chuyen_nganh") = lps.ESSLop(i).ID_chuyen_nganh
                dr("Chuyen_nganh") = lps.ESSLop(i).Chuyen_nganh
                dr("ID_BM") = lps.ESSLop(i).ID_BM
                dr("ID_mon_tc") = lps.ESSLop(i).ID_mon_tc
                dr("idx_lop") = i
                dr("Ky_hieu") = lps.ESSLop(i).Ky_hieu
                dr("Ten_mon") = lps.ESSLop(i).Ten_mon
                dr("So_hoc_trinh") = lps.ESSLop(i).So_hoc_trinh
                dr("Ly_thuyet") = lps.ESSLop(i).Ly_thuyet
                dr("Thuc_hanh") = lps.ESSLop(i).Thuc_hanh
                dr("Bai_tap") = lps.ESSLop(i).Bai_tap
                dr("Bai_tap_lon") = lps.ESSLop(i).Bai_tap_lon
                dr("Tong_tiet") = lps.ESSLop(i).Ly_thuyet + lps.ESSLop(i).Thuc_hanh + lps.ESSLop(i).Bai_tap + lps.ESSLop(i).Bai_tap_lon
                'Thông tin lớp
                dr("Ky_hieu_lop_tc") = lps.ESSLop(i).Ky_hieu_lop_tc
                dr("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc
                dr("So_sv_min") = lps.ESSLop(i).So_sv_min
                dr("So_sv_max") = lps.ESSLop(i).So_sv_max
                dr("So_tiet_tuan") = lps.ESSLop(i).So_tiet_tuan
                dr("Ca_hoc") = lps.ESSLop(i).Ten_ca_hoc
                dr("Giao_vien") = lps.ESSLop(i).Ho_ten_gv
                dr("Phong_hoc") = lps.ESSLop(i).Ten_phong
                idx = gvs.Tim_chi_so_theo_ID_cb(lps.ESSLop(i).ID_cb)
                If idx >= 0 Then dr("Giao_vien") = gvs.Giaovien(idx).Ho_ten
                idx = phs.Tim_chi_so(lps.ESSLop(i).ID_phong)
                If idx >= 0 Then dr("Phong_hoc") = phs.Phong_hoc(idx).Ten_phong
                dr("Thoi_gian") = Thoi_gian_hoc(i)
                dr("Tu_ngay") = lps.ESSLop(i).Tu_ngay
                dr("Den_ngay") = lps.ESSLop(i).Den_ngay

                dtLop.Rows.Add(dr)
            Next
            dtLop.DefaultView.Sort = "Ten_mon"
            Return dtLop
        End Function

        Public Function DanhSachNhomTinChi(ByVal ID_lop_tc As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("idx_sk", GetType(Integer))
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_cb", GetType(Integer))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            For l As Integer = 0 To lps.Count - 1
                If lps.ESSLop(l).ID_lop_lt = ID_lop_tc Then
                    For i As Integer = 0 To sks.Count - 1
                        If lps.ESSLop(l).ID_lop_tc = sks.Sukien(i).ID_lop_tc Then
                            Dim dr As DataRow = dtLop.NewRow
                            'ESSLop tin chi
                            dr("Chon") = False
                            dr("ID_lop_tc") = lps.ESSLop(l).ID_lop_tc
                            dr("STT_lop") = lps.ESSLop(l).STT_lop
                            dr("So_sv_min") = lps.ESSLop(l).So_sv_min
                            dr("So_sv_max") = lps.ESSLop(l).So_sv_max
                            dr("So_tiet_tuan") = lps.ESSLop(l).So_tiet_tuan
                            dr("Tu_ngay") = lps.ESSLop(l).Tu_ngay
                            dr("Den_ngay") = lps.ESSLop(l).Den_ngay
                            'ESSTKB
                            dr("idx_sk") = i
                            dr("ID") = sks.Sukien(i).ID
                            dr("CaID") = sks.Sukien(i).Ca_hoc
                            dr("ID_phong") = sks.Sukien(i).ID_phong
                            dr("ID_cb") = sks.Sukien(i).ID_cb
                            If sks.Sukien(i).Thu <> ESS.EnumNConst.eTHU.KHONG_XAC_DINH Then

                                dr("Thu") = sks.Sukien(i).Thu + 2
                            End If
                            If sks.Sukien(i).Tiet >= 0 Then
                                dr("Tu_tiet") = sks.Sukien(i).Tiet + 1
                                dr("Den_tiet") = sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet
                            End If
                            dtLop.Rows.Add(dr)
                        End If
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "STT_lop"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi(ByVal ID_mon_tc As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("idx_sk", GetType(Integer))
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_cb", GetType(Integer))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            dtLop.Columns.Add("So_tiet", GetType(Integer))
            For l As Integer = 0 To lps.Count - 1
                If lps.ESSLop(l).ID_mon_tc = ID_mon_tc And lps.ESSLop(l).ID_lop_lt = 0 Then
                    For i As Integer = 0 To sks.Count - 1
                        If lps.ESSLop(l).ID_lop_tc = sks.Sukien(i).ID_lop_tc Then
                            Dim dr As DataRow = dtLop.NewRow
                            'ESSLop tin chi
                            dr("Chon") = False
                            dr("ID_lop_tc") = lps.ESSLop(l).ID_lop_tc
                            dr("STT_lop") = lps.ESSLop(l).STT_lop
                            dr("So_sv_min") = lps.ESSLop(l).So_sv_min
                            dr("So_sv_max") = lps.ESSLop(l).So_sv_max
                            dr("So_tiet_tuan") = lps.ESSLop(l).So_tiet_tuan
                            dr("Tu_ngay") = lps.ESSLop(l).Tu_ngay
                            dr("Den_ngay") = lps.ESSLop(l).Den_ngay
                            'ESSTKB
                            dr("idx_sk") = i
                            dr("ID") = sks.Sukien(i).ID
                            dr("CaID") = sks.Sukien(i).Ca_hoc
                            dr("ID_phong") = sks.Sukien(i).ID_phong
                            dr("ID_cb") = sks.Sukien(i).ID_cb
                            If sks.Sukien(i).Thu <> EnumNConst.eTHU.KHONG_XAC_DINH Then
                                dr("Thu") = sks.Sukien(i).Thu + 2
                            End If
                            If sks.Sukien(i).Tiet >= 0 Then
                                dr("Tu_tiet") = sks.Sukien(i).Tiet + 1
                                dr("Den_tiet") = sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet
                            End If
                            dr("So_tiet") = sks.Sukien(i).So_tiet
                            dtLop.Rows.Add(dr)
                        End If
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "STT_lop"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChi(ByVal ID_he As Integer, ByVal Khoa_hoc As Integer) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("idx_sk", GetType(Integer))
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_CB", GetType(Integer))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_lop_lt", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            For l As Integer = 0 To lps.Count - 1
                If lps.ESSLop(l).ID_he = ID_he And lps.ESSLop(l).Khoa_hoc = Khoa_hoc Then
                    For i As Integer = 0 To sks.Count - 1
                        If lps.ESSLop(l).ID_lop_tc = sks.Sukien(i).ID_lop_tc Then
                            Dim dr As DataRow = dtLop.NewRow
                            'ESSLop tin chi
                            dr("Chon") = False
                            dr("STT_lop") = lps.ESSLop(l).STT_lop
                            dr("ID_lop_tc") = lps.ESSLop(l).ID_lop_tc
                            dr("ID_mon_tc") = lps.ESSLop(l).ID_mon_tc
                            dr("Ten_mon") = lps.ESSLop(l).Ten_mon
                            dr("Ten_lop_tc") = lps.ESSLop(l).Ten_lop_tc
                            dr("So_sv_min") = lps.ESSLop(l).So_sv_min
                            dr("So_sv_max") = lps.ESSLop(l).So_sv_max
                            dr("So_tiet_tuan") = lps.ESSLop(l).So_tiet_tuan
                            dr("Tu_ngay") = lps.ESSLop(l).Tu_ngay
                            dr("Den_ngay") = lps.ESSLop(l).Den_ngay
                            dr("ID_khoa") = lps.ESSLop(l).ID_khoa
                            dr("ID_nganh") = lps.ESSLop(l).ID_nganh
                            dr("ID_chuyen_nganh") = lps.ESSLop(l).ID_chuyen_nganh
                            dr("ID_lop_lt") = lps.ESSLop(l).ID_lop_lt
                            'ESSTKB
                            dr("idx_sk") = i
                            dr("ID") = sks.Sukien(i).ID
                            dr("CaID") = sks.Sukien(i).Ca_hoc
                            dr("ID_phong") = sks.Sukien(i).ID_phong
                            dr("ID_cb") = sks.Sukien(i).ID_cb
                            If sks.Sukien(i).Thu <> EnumNConst.eTHU.KHONG_XAC_DINH Then
                                dr("Thu") = sks.Sukien(i).Thu + 2
                            End If
                            If sks.Sukien(i).Tiet >= 0 Then
                                dr("Tu_tiet") = sks.Sukien(i).Tiet + 1
                                dr("Den_tiet") = sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet
                            End If
                            dtLop.Rows.Add(dr)
                        End If
                    Next
                End If
            Next
            dtLop.DefaultView.Sort = "Ten_mon, STT_lop, ID_lop_lt"
            Return dtLop
        End Function

        Public Function DanhSachLopTinChiGanLopHanhChinh(ByVal dtLopGan As DataTable) As DataTable
            Dim dtLop As New DataTable
            dtLop.Columns.Add("Chon", GetType(Boolean))
            dtLop.Columns.Add("idx_sk", GetType(Integer))
            dtLop.Columns.Add("ID", GetType(Integer))
            dtLop.Columns.Add("ID_lop_tc", GetType(Integer))
            dtLop.Columns.Add("ID_mon_tc", GetType(Integer))
            dtLop.Columns.Add("Ten_mon", GetType(String))
            dtLop.Columns.Add("Ten_lop_tc", GetType(String))
            dtLop.Columns.Add("So_sv_min", GetType(Integer))
            dtLop.Columns.Add("So_sv_max", GetType(Integer))
            dtLop.Columns.Add("So_tiet_tuan", GetType(Integer))
            dtLop.Columns.Add("CaID", GetType(Integer))
            dtLop.Columns.Add("Ca_hoc", GetType(String))
            dtLop.Columns.Add("ID_phong", GetType(Integer))
            dtLop.Columns.Add("ID_CB", GetType(Integer))
            dtLop.Columns.Add("Ho_ten", GetType(String))
            dtLop.Columns.Add("Tu_ngay", GetType(Date))
            dtLop.Columns.Add("Den_ngay", GetType(Date))
            dtLop.Columns.Add("Thu", GetType(Integer))
            dtLop.Columns.Add("Tu_tiet", GetType(Integer))
            dtLop.Columns.Add("Den_tiet", GetType(Integer))
            dtLop.Columns.Add("ID_khoa", GetType(Integer))
            dtLop.Columns.Add("ID_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_chuyen_nganh", GetType(Integer))
            dtLop.Columns.Add("ID_lop_lt", GetType(Integer))
            dtLop.Columns.Add("STT_lop", GetType(Integer))
            For g As Integer = 0 To dtLopGan.Rows.Count - 1
                For l As Integer = 0 To lps.Count - 1
                    If dtLopGan.Rows(g)("ID_lop_tc") = lps.ESSLop(l).ID_lop_tc Then
                        For i As Integer = 0 To sks.Count - 1
                            If lps.ESSLop(l).ID_lop_tc = sks.Sukien(i).ID_lop_tc Then
                                Dim dr As DataRow = dtLop.NewRow
                                'ESSLop tin chi
                                dr("Chon") = False
                                dr("STT_lop") = lps.ESSLop(l).STT_lop
                                dr("ID_lop_tc") = lps.ESSLop(l).ID_lop_tc
                                dr("ID_mon_tc") = lps.ESSLop(l).ID_mon_tc
                                dr("Ten_mon") = lps.ESSLop(l).Ten_mon
                                dr("Ten_lop_tc") = lps.ESSLop(l).Ten_lop_tc
                                dr("So_sv_min") = lps.ESSLop(l).So_sv_min
                                dr("So_sv_max") = lps.ESSLop(l).So_sv_max
                                dr("So_tiet_tuan") = lps.ESSLop(l).So_tiet_tuan
                                dr("Tu_ngay") = lps.ESSLop(l).Tu_ngay
                                dr("Den_ngay") = lps.ESSLop(l).Den_ngay
                                dr("ID_khoa") = lps.ESSLop(l).ID_khoa
                                dr("ID_nganh") = lps.ESSLop(l).ID_nganh
                                dr("ID_chuyen_nganh") = lps.ESSLop(l).ID_chuyen_nganh
                                dr("ID_lop_lt") = lps.ESSLop(l).ID_lop_lt
                                'ESSTKB
                                dr("idx_sk") = i
                                dr("ID") = sks.Sukien(i).ID
                                dr("CaID") = sks.Sukien(i).Ca_hoc
                                dr("ID_phong") = sks.Sukien(i).ID_phong
                                dr("ID_cb") = sks.Sukien(i).ID_cb
                                If sks.Sukien(i).Thu <> EnumNConst.eTHU.KHONG_XAC_DINH Then
                                    dr("Thu") = sks.Sukien(i).Thu + 2
                                End If
                                If sks.Sukien(i).Tiet >= 0 Then
                                    dr("Tu_tiet") = sks.Sukien(i).Tiet + 1
                                    dr("Den_tiet") = sks.Sukien(i).Tiet + sks.Sukien(i).So_tiet
                                End If
                                dtLop.Rows.Add(dr)
                            End If
                        Next
                    End If
                Next
            Next
            dtLop.DefaultView.Sort = "Ten_mon, STT_lop, ID_lop_lt"
            Return dtLop
        End Function

        Public Sub CapNhat_ESSTKB_Lop_TinChi(ByRef dtLopTinChi As DataTable)
            Try
                Dim row As Integer = 0
                Dim idx_sk As Integer
                Dim dr As DataRow
                If Not dtLopTinChi Is Nothing Then
                    For i As Integer = 0 To dtLopTinChi.Rows.Count - 1
                        For j As Integer = 0 To lps.Count - 1
                            If dtLopTinChi.Rows(i)("ID_lop_tc") = lps.ESSLop(j).ID_lop_tc Then
                                row = 0
                                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                                    For tiet As Integer = 0 To So_tiet_ngay - 1
                                        idx_sk = lps.ESSLop(j).ESSTKB(thu, tiet)
                                        If idx_sk <> -1 Then
                                            If row = 0 Then
                                                dtLopTinChi.Rows(i)("ID") = sks.Sukien(idx_sk).ID
                                                dtLopTinChi.Rows(i)("Thu") = thu + 2
                                                dtLopTinChi.Rows(i)("Tu_tiet") = tiet + 1
                                                dtLopTinChi.Rows(i)("Den_tiet") = (tiet + lps.ESSLop(j).So_tiet_tuan)
                                            Else
                                                dr = dtLopTinChi.NewRow
                                                dr.ItemArray = dtLopTinChi.Rows(i).ItemArray
                                                dr("ID") = sks.Sukien(idx_sk).ID
                                                dr("Thu") = thu + 2
                                                dr("Tu_tiet") = tiet + 1
                                                dr("Den_tiet") = (tiet + lps.ESSLop(j).So_tiet_tuan)
                                                dtLopTinChi.Rows.Add(dr)
                                            End If
                                            row += 1
                                            Exit For
                                        End If
                                    Next
                                Next
                            End If
                        Next
                    Next
                End If
                dtLopTinChi.AcceptChanges()
            Catch ex As Exception

            End Try
        End Sub

        Public Function Baocao_TKB_Lop_TinChi() As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_lop_tc", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                If i Mod 2 = 0 Then
                    row("Ky_hieu") = lps.ESSLop(i).Ky_hieu
                    row("Ten_mon") = lps.ESSLop(i).Ten_mon
                    row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc
                Else
                    row("Ky_hieu") = lps.ESSLop(i).Ky_hieu + " "
                    row("Ten_mon") = lps.ESSLop(i).Ten_mon + " "
                    row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc + " "
                End If
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    For tiet As Integer = 0 To So_tiet_ngay - 1
                        If lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then
                            col = CalCol(thu, tiet, 4)
                            row(col) = Thongtin_lop(i, thu, tiet)
                        End If
                    Next
                Next
                dt.Rows.Add(row)
            Next
            dt.DefaultView.Sort = "Ten_mon"
            Return dt
        End Function

        Public Function Baocao_TKB_Lop_TinChi(ByVal dvMon As DataView) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_lop_tc", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next
            For k As Integer = 0 To dvMon.Count - 1
                For i As Integer = 0 To lps.Count - 1
                    If dvMon.Item(k)("Ky_hieu_lop_tc").ToString = lps.ESSLop(i).Ky_hieu_lop_tc Then
                        Dim row As DataRow = dt.NewRow()
                        row("STT") = i
                        If i Mod 2 = 0 Then
                            row("Ky_hieu") = lps.ESSLop(i).Ky_hieu
                            row("Ten_mon") = lps.ESSLop(i).Ten_mon
                            row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc
                        Else
                            row("Ky_hieu") = lps.ESSLop(i).Ky_hieu + " "
                            row("Ten_mon") = lps.ESSLop(i).Ten_mon + " "
                            row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc + " "
                        End If
                        For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                            For tiet As Integer = 0 To So_tiet_ngay - 1
                                If lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then
                                    col = CalCol(thu, tiet, 4)
                                    row(col) = Thongtin_lop(i, thu, tiet)
                                End If
                            Next
                        Next
                        dt.Rows.Add(row)
                    End If

                Next
            Next
            dt.DefaultView.Sort = "Ten_mon"
            Return dt
        End Function


        Public Function Baocao_TKB_Lop_TinChi(ByVal Ky_hieu_lop_tc As String) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ky_hieu", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Ten_lop_tc", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next
            For i As Integer = 0 To lps.Count - 1
                If Ky_hieu_lop_tc = lps.ESSLop(i).Ky_hieu_lop_tc Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    If i Mod 2 = 0 Then
                        row("Ky_hieu") = lps.ESSLop(i).Ky_hieu
                        row("Ten_mon") = lps.ESSLop(i).Ten_mon
                        row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc
                    Else
                        row("Ky_hieu") = lps.ESSLop(i).Ky_hieu + " "
                        row("Ten_mon") = lps.ESSLop(i).Ten_mon + " "
                        row("Ten_lop_tc") = lps.ESSLop(i).Ten_lop_tc + " "
                    End If
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If lps.ESSLop(i).ESSTKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 4)
                                row(col) = Thongtin_lop(i, thu, tiet)
                            End If
                        Next
                    Next
                    dt.Rows.Add(row)
                End If
            Next
            dt.DefaultView.Sort = "Ten_mon"
            Return dt
        End Function

        Public Function Baocao_TKB_giaovien(Optional ByVal ID_bm As Object = Nothing) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next
            For i As Integer = 0 To gvs.Count - 1
                If (ID_bm Is Nothing) Or (Not ID_bm Is Nothing AndAlso gvs.Giaovien(i).ID_bm = ID_bm) Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    If i Mod 2 = 0 Then
                        row("Ten_giaovien") = gvs.Giaovien(i).Ho_ten
                    Else
                        row("Ten_giaovien") = gvs.Giaovien(i).Ho_ten + " "
                    End If
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If gvs.Giaovien(i).ESSTKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_gv(i, thu, tiet)
                            End If
                        Next
                    Next
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Baocao_TKB_TheoPhong(ByVal ID_phong As Integer) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To phs.Count - 1
                If phs.Phong_hoc(i).ID_phong = ID_phong Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If phs.Phong_hoc(i).ESSTKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_phong(i, thu, tiet)
                            End If
                        Next
                    Next
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Baocao_TKB_phong() As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To phs.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                    For tiet As Integer = 0 To So_tiet_ngay - 1
                        If phs.Phong_hoc(i).ESSTKB(thu, tiet) <> -1 Then
                            col = CalCol(thu, tiet, 2)
                            row(col) = Thongtin_phong(i, thu, tiet)
                        End If
                    Next
                Next
                dt.Rows.Add(row)
            Next
            Return dt
        End Function

        Public Function Baocao_TKB_Nha(ByVal ID_Nha As Integer) As DataTable
            Dim dt As New DataTable
            Dim col As Integer
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = Thu_bat_dau To Thu_ket_thuc
                For j As Integer = 0 To So_tiet_ngay - 1
                    dt.Columns.Add(i.ToString() + "." + j.ToString(), GetType(String))
                Next
            Next

            For i As Integer = 0 To phs.Count - 1
                If phs.Phong_hoc(i).ID_nha = ID_Nha Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                    For thu As Integer = Thu_bat_dau To Thu_ket_thuc
                        For tiet As Integer = 0 To So_tiet_ngay - 1
                            If phs.Phong_hoc(i).ESSTKB(thu, tiet) <> -1 Then
                                col = CalCol(thu, tiet, 2)
                                row(col) = Thongtin_phong(i, thu, tiet)
                            End If
                        Next
                    Next
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function


        Public Function Danhsach_giaovien() As DataTable
            Dim dt As New DataTable
            Dim Flag As Boolean
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_cb", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            For i As Integer = 0 To gvs.Count - 1
                'Kiểm tra xem giáo viên có sự kiện không?
                Flag = False
                For j As Integer = 0 To sks.Count - 1
                    If sks.Sukien(j).ID_cb = gvs.Giaovien(i).ID_cb Then
                        Flag = True
                        Exit For
                    End If
                Next
                If Flag Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("ID_cb") = gvs.Giaovien(i).ID_cb
                    row("Ten_giaovien") = gvs.Giaovien(i).Ho_ten
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Danhsach_lop() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_lop", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("ID_lop") = lps.ESSLop(i).ID_lop_tc
                row("Ten_lop") = lps.ESSLop(i).Ten_lop_tc
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Danhsach_phong() As DataTable
            Dim dt As New DataTable
            Dim Flag As Boolean
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("ID_phong", GetType(Integer))
            dt.Columns.Add("Ten_phong", GetType(String))
            For i As Integer = 0 To phs.Count - 1
                Flag = False
                'Kiểm tra xem phòng có sự kiện không?
                For j As Integer = 0 To sks.Count - 1
                    If sks.Sukien(j).ID_phong = phs.Phong_hoc(i).ID_phong Then
                        Flag = True
                        Exit For
                    End If
                Next
                If Flag Then
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("ID_phong") = phs.Phong_hoc(i).ID_phong
                    row("Ten_phong") = phs.Phong_hoc(i).Ten_phong
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function

        Public Function Lich_giaovien(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_gv(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_lop(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_lop(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_mon(ByVal ID_mon_tc As Integer) As DataTable
            Dim thu, tiet As Integer
            Dim strLich As String
            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    For l As Integer = 0 To lps.Count - 1
                        If lps.ESSLop(l).ID_mon_tc = ID_mon_tc Then
                            strLich = Thongtin_lop(l, thu, tiet)
                            If strLich <> "" Then row(thu) = strLich
                        End If
                    Next
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function
        Public Function Lich_phong(ByVal idx As Integer) As DataTable
            Dim thu, tiet As Integer

            Dim dt As New DataTable
            For thu = Thu_bat_dau To Thu_ket_thuc
                dt.Columns.Add(thu.ToString(), GetType(String))
            Next

            For tiet = 0 To So_tiet_ngay - 1
                Dim row As DataRow = dt.NewRow()
                For thu = Thu_bat_dau To Thu_ket_thuc
                    row(thu) = Thongtin_phong(idx, thu, tiet)
                Next
                dt.Rows.Add(row)
            Next

            Return dt
        End Function

        Public Function List_sukien_chua_xeplich_giaovien(ByVal idx As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Loai_tiet", GetType(String))
            For i As Integer = 0 To sks.Count - 1
                If (Not sks.Sukien(i).Da_xep_lich) And _
                (sks.Sukien(i).ID_cb = gvs.Giaovien(idx).ID_cb) And _
                (sks.Sukien(i).So_tiet >= 2) Then
                    Dim sk As ESSSu_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = sk.Ten_lop
                    row("Ten_phong") = sk.Ten_phong
                    row("Ten_mon") = sk.Ten_mon
                    row("Loai_tiet") = sk.Loai_tiet
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function List_sukien_chua_xeplich_lop(ByVal ID_mon_tc As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("idx_lop", GetType(Integer))
            dt.Columns.Add("Chon", GetType(Boolean))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("So_tiet", GetType(Integer))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_phong", GetType(String))
            dt.Columns.Add("Loai_tiet", GetType(String))
            dt.Columns.Add("thu", GetType(Integer))
            dt.Columns.Add("tiet", GetType(Integer))
            For l As Integer = 0 To lps.Count - 1
                If lps.ESSLop(l).ID_mon_tc = ID_mon_tc Then
                    For i As Integer = 0 To sks.Count - 1
                        If (sks.Sukien(i).ID_lop_tc = lps.ESSLop(l).ID_lop_tc) And _
                        (sks.Sukien(i).So_tiet >= 1) Then
                            Dim sk As ESSSu_kien = sks.Sukien(i)
                            Dim row As DataRow = dt.NewRow()
                            row("STT") = i
                            row("idx_lop") = l
                            row("Chon") = False
                            row("Ten_lop") = sk.Ten_lop
                            row("So_tiet") = sk.So_tiet
                            row("Ten_giaovien") = sk.Ten
                            row("Ten_phong") = sk.Ten_phong
                            row("Loai_tiet") = sk.Loai_tiet
                            If sk.Thu >= 0 Then row("thu") = sk.Thu + 2
                            If sk.Tiet >= 0 Then row("tiet") = sk.Tiet + 1
                            dt.Rows.Add(row)
                        End If
                    Next
                End If
            Next
            Return dt
        End Function
        Public Function List_sukien_chua_xeplich_phong(ByVal idx As Integer) As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_lop", GetType(String))
            dt.Columns.Add("Ten_giaovien", GetType(String))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("Loai_tiet", GetType(String))
            For i As Integer = 0 To sks.Count - 1
                If (Not sks.Sukien(i).Da_xep_lich) And _
                (sks.Sukien(i).ID_phong = phs.Phong_hoc(idx).ID_phong) And _
                (sks.Sukien(i).So_tiet >= 2) Then
                    Dim sk As ESSSu_kien = sks.Sukien(i)
                    Dim row As DataRow = dt.NewRow()
                    row("STT") = i
                    row("Ten_lop") = sk.Ten_lop
                    row("Ten_giaovien") = sk.Ten
                    row("Ten_mon") = sk.Ten_mon
                    row("Loai_tiet") = sk.Loai_tiet
                    dt.Rows.Add(row)
                End If
            Next
            Return dt
        End Function
        Public Function Thongke_Sotiet_lop() As DataTable
            Dim s(lps.Count - 1) As Integer
            Dim c(lps.Count - 1) As Integer
            Dim t(lps.Count - 1) As Integer
            For i As Integer = 0 To lps.Count - 1
                For j As Integer = 0 To sks.Count - 1
                    Dim sk As ESSSu_kien = sks.Sukien(j)
                    If sk.ID_lop_tc = lps.ESSLop(i).ID_lop_tc Then
                        If sk.Ca_hoc = eCA_HOC.SANG Then s(i) += 1
                        If sk.Ca_hoc = eCA_HOC.CHIEU Then c(i) += 1
                        If sk.Ca_hoc = eCA_HOC.TOI Then t(i) += 1
                    End If
                Next
            Next

            Dim dt As New DataTable
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("STT_lop", GetType(String))
            dt.Columns.Add("Sang", GetType(String))
            dt.Columns.Add("Chieu", GetType(String))
            dt.Columns.Add("Toi", GetType(String))
            dt.Columns.Add("Tong", GetType(String))
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("Ten_mon") = lps.ESSLop(i).Ten_mon
                row("STT_lop") = lps.ESSLop(i).STT_lop
                If s(i) > 0 Then row("Sang") = s(i)
                If c(i) > 0 Then row("Chieu") = c(i)
                If t(i) > 0 Then row("Toi") = t(i)
                If s(i) + c(i) + t(i) > 0 Then row("Tong") = s(i) + c(i) + t(i)
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Public Function Thongke_Sotiet_giaovien() As DataTable
            Return gvs.Muc_do_cang()
        End Function
        Public Function Thongke_lop_tin_chi() As DataTable
            Dim dt As New DataTable
            dt.Columns.Add("STT", GetType(Integer))
            dt.Columns.Add("Ten_mon", GetType(String))
            dt.Columns.Add("STT_lop", GetType(String))
            dt.Columns.Add("So_sv_min", GetType(String))
            dt.Columns.Add("So_sv_max", GetType(String))
            For i As Integer = 0 To lps.Count - 1
                Dim row As DataRow = dt.NewRow()
                row("STT") = i
                row("Ten_mon") = lps.ESSLop(i).Ten_lop_tc
                row("STT_lop") = lps.ESSLop(i).STT_lop
                row("So_sv_min") = lps.ESSLop(i).So_sv_min
                row("So_sv_max") = lps.ESSLop(i).So_sv_max
                dt.Rows.Add(row)
            Next
            Return dt
        End Function
        Private Function CheckKeHoachKhac(ByVal dtKeHoachKhac As DataTable, ByVal Tuan_thu As Integer, ByVal ID_he As Integer, ByVal ID_khoa As Integer, ByVal Khoa_hoc As Integer, ByVal ID_nganh As Integer, ByVal ID_chuyen_nganh As Integer) As String
            Dim Ky_hieu As String = ""
            For i As Integer = 0 To dtKeHoachKhac.Rows.Count - 1
                If (dtKeHoachKhac.Rows(i)("ID_he") = 0 Or (dtKeHoachKhac.Rows(i)("ID_he") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_he") = ID_he)) And _
                    (dtKeHoachKhac.Rows(i)("ID_khoa") = 0 Or (dtKeHoachKhac.Rows(i)("ID_khoa") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_khoa") = ID_khoa)) And _
                    (dtKeHoachKhac.Rows(i)("Khoa_hoc") = 0 Or (dtKeHoachKhac.Rows(i)("Khoa_hoc") > 0 AndAlso dtKeHoachKhac.Rows(i)("Khoa_hoc") = Khoa_hoc)) And _
                    (dtKeHoachKhac.Rows(i)("ID_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_nganh") = ID_nganh)) And _
                    (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = 0 Or (dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") > 0 AndAlso dtKeHoachKhac.Rows(i)("ID_chuyen_nganh") = ID_chuyen_nganh)) Then
                    If DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Tu_ngay")) <= Tuan_thu And _
                        DatePart(DateInterval.WeekOfYear, dtKeHoachKhac.Rows(i)("Den_ngay")) > Tuan_thu Then
                        Ky_hieu = dtKeHoachKhac.Rows(i)("Ky_hieu")
                    End If
                End If
            Next
            Return Ky_hieu
        End Function
#End Region
        Function Load_CapTiet_LopTinChi(ByVal ID_lop_tc As Integer) As DataTable
            Dim clsDAL As New MonTinChi_DataAccess
            Return clsDAL.Load_CapTiet_LopTinChi(ID_lop_tc)
        End Function
    End Class
End Namespace
