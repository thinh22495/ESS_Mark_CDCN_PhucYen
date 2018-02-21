'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSLopTinChi
#Region "Initialize"
        Public Sub New()
            mLopTinChi = New ArrayList
        End Sub
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            mTKB = New ESSTKB(Ngay_tuan, So_tiet_ngay)
        End Sub
#End Region

#Region "Var"
        Private mID_lop_tc As Integer = 0
        Private mID_lop_lt As Integer = 0
        Private mSTT_lop_lt As Integer = 0
        Private mID_mon_tc As Integer = 0
        Private mID_mon As Integer = 0
        Private mKy_hieu_lop_tc As String = ""
        Private mKy_hieu As String = ""
        Private mTen_mon As String = ""
        Private mSTT_lop As Integer = 0
        Private mSo_sv_min As Integer = 0
        Private mSo_sv_max As Integer = 0
        Private mSo_tiet_tuan As Integer = 0
        Private mSo_hoc_trinh As Integer = 0
        Private mLy_thuyet As Integer = 0
        Private mThuc_hanh As Integer = 0
        Private mBai_tap As Integer = 0
        Private mBai_tap_lon As Integer = 0
        Private mID_phong As Integer = 0
        Private mTen_phong As String = ""
        Private mID_cb As Integer = 0
        Private mHo_Ten_gv As String = ""
        Private mTu_ngay As Date
        Private mDen_ngay As Date
        Private mCa_hoc As Integer = 0
        Private mTen_ca_hoc As String = ""
        Private mHuy_lop As Boolean = 0
        Private mLy_do As String = ""
        Private mNhom_dang_ky As String = ""
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mKhoa_hoc As Integer = 0
        Private mID_khoa As Integer = 0
        Private mTen_khoa As String = ""
        Private mID_nganh As Integer = 0
        Private mTen_nganh As String = ""
        Private mID_chuyen_nganh As Integer = 0
        Private mChuyen_nganh As String = ""
        Private mLopTinChi As ArrayList
        Private mTKB As ESSTKB
        Private mID_bm As Integer = 0
#End Region

#Region "Functions"

        Public Sub Add(ByVal ESSLop As ESSLopTinChi)
            mLopTinChi.Add(ESSLop)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mLopTinChi.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_lop_tc As Integer) As Integer
            For i As Integer = 0 To mLopTinChi.Count - 1
                If CType(mLopTinChi(i), ESSLopTinChi).ID_lop_tc = ID_lop_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region

#Region "Property"
        Public Property ESSTKB(ByVal thu As Integer, ByVal tiet As Integer) As Integer
            Get
                Return mTKB.ESSTKB(thu, tiet)
            End Get
            Set(ByVal Value As Integer)
                mTKB.ESSTKB(thu, tiet) = Value
            End Set
        End Property
        Public Property Loai_sk(ByVal thu As Integer, ByVal tiet As Integer) As eLOAI_SK
            Get
                Return mTKB.Loai_sk(thu, tiet)
            End Get
            Set(ByVal Value As eLOAI_SK)
                mTKB.Loai_sk(thu, tiet) = Value
            End Set
        End Property
        Public ReadOnly Property Count() As Integer
            Get
                Return mLopTinChi.Count
            End Get
        End Property
        Public Property ESSLopTinChi(ByVal idx As Integer) As ESSLopTinChi
            Get
                Return CType(mLopTinChi(idx), ESSLopTinChi)
            End Get
            Set(ByVal Value As ESSLopTinChi)
                mLopTinChi(idx) = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return mID_lop_tc
            End Get
            Set(ByVal Value As Integer)
                mID_lop_tc = Value
            End Set
        End Property
        Public Property Ten_lop_tc() As String
            Get
                If ID_lop_lt = 0 Then
                    Return Ky_hieu_lop_tc + ".LT" + STT_lop.ToString
                Else
                    Return Ky_hieu_lop_tc + ".LT-" + STT_lop_lt.ToString + ".TH-" + STT_lop.ToString
                End If
            End Get
            Set(ByVal Value As String)
                Ky_hieu_lop_tc = Value
            End Set
        End Property
        Public Property ID_lop_lt() As Integer
            Get
                Return mID_lop_lt
            End Get
            Set(ByVal Value As Integer)
                mID_lop_lt = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal Value As String)
                mTen_mon = Value
            End Set
        End Property
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property
        Public Property Ky_hieu_lop_tc() As String
            Get
                Return mKy_hieu_lop_tc
            End Get
            Set(ByVal Value As String)
                mKy_hieu_lop_tc = Value
            End Set
        End Property
        Public Property STT_lop() As Integer
            Get
                Return mSTT_lop
            End Get
            Set(ByVal Value As Integer)
                mSTT_lop = Value
            End Set
        End Property
        Public Property STT_lop_lt() As Integer
            Get
                Return mSTT_lop_lt
            End Get
            Set(ByVal Value As Integer)
                mSTT_lop_lt = Value
            End Set
        End Property
        Public Property So_hoc_trinh() As Integer
            Get
                Return mSo_hoc_trinh
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh = Value
            End Set
        End Property
        Public Property Ly_thuyet() As Integer
            Get
                Return mLy_thuyet
            End Get
            Set(ByVal Value As Integer)
                mLy_thuyet = Value
            End Set
        End Property
        Public Property Bai_tap() As Integer
            Get
                Return mBai_tap
            End Get
            Set(ByVal Value As Integer)
                mBai_tap = Value
            End Set
        End Property
        Public Property Bai_tap_lon() As Integer
            Get
                Return mBai_tap_lon
            End Get
            Set(ByVal Value As Integer)
                mBai_tap_lon = Value
            End Set
        End Property
        Public Property Thuc_hanh() As Integer
            Get
                Return mThuc_hanh
            End Get
            Set(ByVal Value As Integer)
                mThuc_hanh = Value
            End Set
        End Property

        Public Property So_sv_min() As Integer
            Get
                Return mSo_sv_min
            End Get
            Set(ByVal Value As Integer)
                mSo_sv_min = Value
            End Set
        End Property
        Public Property So_sv_max() As Integer
            Get
                Return mSo_sv_max
            End Get
            Set(ByVal Value As Integer)
                mSo_sv_max = Value
            End Set
        End Property
        Public Property So_tiet_tuan() As Integer
            Get
                Return mSo_tiet_tuan
            End Get
            Set(ByVal Value As Integer)
                mSo_tiet_tuan = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal Value As Integer)
                mID_phong = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property
        Public Property ID_cb() As Integer
            Get
                Return mID_cb
            End Get
            Set(ByVal Value As Integer)
                mID_cb = Value
            End Set
        End Property
        Public Property Ho_ten_gv() As String
            Get
                Return mHo_Ten_gv
            End Get
            Set(ByVal Value As String)
                mHo_Ten_gv = Value
            End Set
        End Property
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
            End Set
        End Property
        Public Property Ca_hoc() As Integer
            Get
                Return mCa_hoc
            End Get
            Set(ByVal Value As Integer)
                mCa_hoc = Value
            End Set
        End Property
        Public Property Ten_ca_hoc() As String
            Get
                Return mTen_ca_hoc
            End Get
            Set(ByVal Value As String)
                mTen_ca_hoc = Value
            End Set
        End Property
        Public Property Huy_lop() As Boolean
            Get
                Return mHuy_lop
            End Get
            Set(ByVal Value As Boolean)
                mHuy_lop = Value
            End Set
        End Property
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
            End Set
        End Property
        Public Property Nhom_dang_ky() As String
            Get
                Return mNhom_dang_ky
            End Get
            Set(ByVal Value As String)
                mNhom_dang_ky = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
            End Set
        End Property
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
            End Set
        End Property
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property

        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
            End Set
        End Property

        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
            End Set
        End Property


        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
            End Set
        End Property
        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh = Value
            End Set
        End Property

        Public Property ID_BM() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
#End Region

        Function XuLyLeft(ByVal s As String, ByVal Do_dai As Integer) As String
            Return Left(s, Do_dai)
        End Function
    End Class
End Namespace
