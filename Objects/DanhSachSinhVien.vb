Imports System
Namespace Objects
    Public Class ESSDanhSachSinhVien
#Region "Var"
        Private mLock As Boolean = False
        Private mID_sv As Integer = 0
        Private mID_lop As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_dt1 As Integer = 0
        Private mID_dt2 As Integer = 0
        Private mID_gioi_tinh As Integer = 0
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mHo_dem As String = ""
        Private mTen As String = ""
        Private mVanDau As String = ""
        Private mNgay_sinh As Date = Nothing
        Private mGioi_tinh As String = ""
        Private mNoi_sinh As String = ""
        Private mTen_lop As String = ""
        Private m_Ten_khoa As String = ""
        Private mNien_khoa As String = ""
        Private mMat_khau As String = ""
        Private mActive As Boolean = False
        Private mDa_tot_nghiep As Boolean = False
        Private mNgoai_ngan_sach As Boolean = 0
        Private mID_doi_tuong_TC As Integer = 0
        Private mID_doi_tuong_TS As Integer = 0
        Private mKhoa_hoc2 As Integer = 0
        Private mMa_nganh As String = ""
        Private mdia_chi_tt As String = ""
        Private mNgoai_ngu As String = ""
        Private mTong_diem As Double = 0
        Private mSbd As String = ""
        Private mCMND As String = ""
        Private mNoi_cap As String = ""
        Private mNgay_cap As Date = Nothing

        Private mCo_van_duyet As Boolean = False
        Private mSinh_vien_duyet As Boolean = False
        Private mTrang_thai_hoc As String = ""
        Private mTrang_thai_hoc2 As String = ""

        Private mID_he As Integer = 0
        Private mNam_thu As Integer = 0
        Private mQuy_che As Integer = 25
        Private mKhoa_hoc As Integer = 0
        Private mTen_he As String = ""
        Private mTen_nganh As String = ""
        Private mChuyen_nganh As String = ""
        Private mID_tinh_TT As String = ""
        Private mLop_chat_luong_cao As Boolean = False
#End Region
#Region "Property"
        Public Property Quy_che() As Integer
            Get
                Return mQuy_che
            End Get
            Set(ByVal Value As Integer)
                mQuy_che = Value
            End Set
        End Property
        Public Property ID_tinh_TT() As String
            Get
                Return mID_tinh_TT
            End Get
            Set(ByVal Value As String)
                mID_tinh_TT = Value
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
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
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
        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh = Value
            End Set
        End Property
        Public Property Nam_thu() As Integer
            Get
                Return mNam_thu
            End Get
            Set(ByVal Value As Integer)
                mNam_thu = Value
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

        Public Property Lock() As Boolean
            Get
                Return mLock
            End Get
            Set(ByVal Value As Boolean)
                mLock = Value
            End Set
        End Property
        Public Property ID_doi_tuong_TS() As Integer
            Get
                Return mID_doi_tuong_TS
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TS = Value
            End Set
        End Property
        Public Property ID_doi_tuong_TC() As Integer
            Get
                Return mID_doi_tuong_TC
            End Get
            Set(ByVal Value As Integer)
                mID_doi_tuong_TC = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property ID_gioi_tinh() As Integer
            Get
                Return mID_gioi_tinh
            End Get
            Set(ByVal Value As Integer)
                mID_gioi_tinh = Value
            End Set
        End Property
        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal Value As Integer)
                mID_lop = Value
            End Set
        End Property
        Public Property Ma_nganh() As String
            Get
                Return mMa_nganh
            End Get
            Set(ByVal Value As String)
                mMa_nganh = Value
            End Set
        End Property
        Public Property ID_dt1() As Integer
            Get
                Return mID_dt1
            End Get
            Set(ByVal Value As Integer)
                mID_dt1 = Value
            End Set
        End Property
        Public Property ID_dt2() As Integer
            Get
                Return mID_dt2
            End Get
            Set(ByVal Value As Integer)
                mID_dt2 = Value
            End Set
        End Property
        Public Property Ma_sv() As String
            Get
                Return mMa_sv
            End Get
            Set(ByVal Value As String)
                mMa_sv = Value
            End Set
        End Property
        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal Value As String)
                mHo_ten = Value
            End Set
        End Property
        Public Property Ho_Dem() As String
            Get
                Return mHo_Dem
            End Get
            Set(ByVal Value As String)
                mHo_Dem = Value
            End Set
        End Property
        Public Property Ten() As String
            Get
                Return mTen
            End Get
            Set(ByVal Value As String)
                mTen = Value
            End Set
        End Property
        Public Property VanDau() As String
            Get
                Return mVanDau
            End Get
            Set(ByVal Value As String)
                mVanDau = Value
            End Set
        End Property
        Public Property Ngoai_ngu() As String
            Get
                Return mNgoai_ngu
            End Get
            Set(ByVal Value As String)
                mNgoai_ngu = Value
            End Set
        End Property
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
                mNgay_sinh = Value
            End Set
        End Property
        Public Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal Value As String)
                mGioi_tinh = Value
            End Set
        End Property
        Public Property Noi_sinh() As String
            Get
                Return mNoi_sinh
            End Get
            Set(ByVal Value As String)
                mNoi_sinh = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
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
                Return m_Ten_khoa
            End Get
            Set(ByVal Value As String)
                m_Ten_khoa = Value
            End Set
        End Property
        Public Property Mat_khau() As String
            Get
                Return mMat_khau
            End Get
            Set(ByVal Value As String)
                mMat_khau = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return mActive
            End Get
            Set(ByVal Value As Boolean)
                mActive = Value
            End Set
        End Property
        Public Property Da_tot_nghiep() As Boolean
            Get
                Return mDa_tot_nghiep
            End Get
            Set(ByVal Value As Boolean)
                mDa_tot_nghiep = Value
            End Set
        End Property
        Public Property Ngoai_ngan_sach() As Boolean
            Get
                Return mNgoai_ngan_sach
            End Get
            Set(ByVal Value As Boolean)
                mNgoai_ngan_sach = Value
            End Set
        End Property
        Public Property Nien_khoa() As String
            Get
                Return mNien_khoa
            End Get
            Set(ByVal Value As String)
                mNien_khoa = Value
            End Set
        End Property
        Public Property SBD() As String
            Get
                Return mSbd
            End Get
            Set(ByVal Value As String)
                mSbd = Value
            End Set
        End Property
        Public Property Dia_chi_tt() As String
            Get
                Return mdia_chi_tt
            End Get
            Set(ByVal Value As String)
                mdia_chi_tt = Value
            End Set
        End Property
        Public Property Tong_diem() As Double
            Get
                Return mTong_diem
            End Get
            Set(ByVal Value As Double)
                mTong_diem = Value
            End Set
        End Property

        Public Property CMND() As String
            Get
                Return mCMND
            End Get
            Set(ByVal Value As String)
                mCMND = Value
            End Set
        End Property
        Public Property Noi_cap() As String
            Get
                Return mNoi_cap
            End Get
            Set(ByVal Value As String)
                mNoi_cap = Value
            End Set
        End Property
        Public Property Trang_thai_hoc() As String
            Get
                Return mTrang_thai_hoc
            End Get
            Set(ByVal Value As String)
                mTrang_thai_hoc = Value
            End Set
        End Property
        Public Property Trang_thai_hoc2() As String
            Get
                Return mTrang_thai_hoc2
            End Get
            Set(ByVal Value As String)
                mTrang_thai_hoc2 = Value
            End Set
        End Property
        Public Property Ngay_cap() As Date
            Get
                Return mNgay_cap
            End Get
            Set(ByVal Value As Date)
                mNgay_cap = Value
            End Set
        End Property

        Public Property CoVan_duyet() As Boolean
            Get
                Return mCo_van_duyet
            End Get
            Set(ByVal Value As Boolean)
                mCo_van_duyet = Value
            End Set
        End Property
        Public Property SinhVien_duyet() As Boolean
            Get
                Return mSinh_vien_duyet
            End Get
            Set(ByVal Value As Boolean)
                mSinh_vien_duyet = Value
            End Set
        End Property
        Public Property Khoa_hoc2() As Integer
            Get
                Return mKhoa_hoc2
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc2 = Value
            End Set
        End Property
        Public Property Lop_chat_luong_cao() As Boolean
            Get
                Return mLop_chat_luong_cao
            End Get
            Set(ByVal Value As Boolean)
                mLop_chat_luong_cao = Value
            End Set
        End Property
#End Region


    End Class
End Namespace