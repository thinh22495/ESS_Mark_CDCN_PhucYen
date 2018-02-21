Imports System
Namespace Objects
    Public Class ESSDanhSachNganh2
        Inherits ESSDanhSachSinhVien

#Region "Initialize"
#End Region

#Region "Var"
        Private mID_dt As Integer = 0
        Private mID_mon As Integer = 0
        Private mID_mon_tuong_duong As Integer = 0
        Private mSo_hoc_trinh As Integer = 0
        Private mID_svs As String = ""
        Private mChuyen_nganh As String = ""
        Private mChuyen_nganh2 As String = ""
        Private mTen_nganh As String = ""
        Private mTen_mon As String = ""
        Private mTen_mon2 As String = ""
        Private mKy_hieu As String = ""
        Private mID_he As Integer = 0
        Private mKhoa_hoc As Integer = 0

        Private mID_cn1 As Integer = 0
        Private mID_cn2 As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mSo_qd As String = ""
        Private mNgay_QD As Date
        Private mNoi_dung As String = ""
        Private mNgung_hoc As Boolean = False
        Private mID_nganh As Integer = 0
        Private mID_diem As Integer = 0
        Private mDiem_chu As String = ""
        Private mTBCM As Double = 0
        Private mLan_thi As Integer = 0
        Private mGhi_chu As String = ""
        Private mTen_lop_N2 As String = ""
#End Region

#Region "Property"
        Public Property ID_diem() As Integer
            Get
                Return mID_diem
            End Get
            Set(ByVal Value As Integer)
                mID_diem = Value
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
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
            End Set
        End Property
        Public Property ID_chuyen_nganh1() As Integer
            Get
                Return mID_cn1
            End Get
            Set(ByVal Value As Integer)
                mID_cn1 = Value
            End Set
        End Property

        Public Property ID_svs() As String
            Get
                Return mID_svs
            End Get
            Set(ByVal Value As String)
                mID_svs = Value
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
        Public Property Chuyen_nganh2() As String
            Get
                Return mChuyen_nganh2
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh2 = Value
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
        Public Property ID_mon_tuong_duong() As Integer
            Get
                Return mID_mon_tuong_duong
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tuong_duong = Value
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
        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal Value As String)
                mTen_mon = Value
            End Set
        End Property
        Public Property Ten_mon2() As String
            Get
                Return mTen_mon2
            End Get
            Set(ByVal Value As String)
                mTen_mon2 = Value
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
        Public Property ID_chuyen_nganh2() As Integer
            Get
                Return mID_cn2
            End Get
            Set(ByVal Value As Integer)
                mID_cn2 = Value
            End Set
        End Property
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property Diem_chu() As String
            Get
                Return mDiem_chu
            End Get
            Set(ByVal Value As String)
                mDiem_chu = Value
            End Set
        End Property
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
        Public Property TBCM() As Double
            Get
                Return mTBCM
            End Get
            Set(ByVal Value As Double)
                mTBCM = Value
            End Set
        End Property
        Public Property Lan_thi() As Integer
            Get
                Return mLan_thi
            End Get
            Set(ByVal Value As Integer)
                mLan_thi = Value
            End Set
        End Property
        Public Property So_qd() As String
            Get
                Return mSo_qd
            End Get
            Set(ByVal Value As String)
                mSo_qd = Value
            End Set
        End Property
        Public Property Ngay_qd() As Date
            Get
                Return mNgay_QD
            End Get
            Set(ByVal Value As Date)
                mNgay_QD = Value
            End Set
        End Property
        Public Property Noi_dung() As String
            Get
                Return mNoi_dung
            End Get
            Set(ByVal Value As String)
                mNoi_dung = Value
            End Set
        End Property
        Public Property Ngung_hoc() As Boolean
            Get
                Return mNgung_hoc
            End Get
            Set(ByVal Value As Boolean)
                mNgung_hoc = Value
            End Set
        End Property

        Public Property Ten_lop_N2() As String
            Get
                Return mTen_lop_N2
            End Get
            Set(ByVal Value As String)
                mTen_lop_N2 = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
