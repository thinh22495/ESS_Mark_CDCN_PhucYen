Namespace Objects
    Public Class ESSDanhSachTotNghiep
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region
#Region "Var"
        Private mNgay_QD As Date = Nothing
        Private mSo_QD As String = ""
        Private mSo_hieu As String = ""
        Private mSo_vao_so As String = ""

        Private mLan_thu As Integer = 0
        Private mID_dt As Integer = 0
        Private mSo_bang As Integer = 0
        Private mTBCHT As Double = -1
        Private mTBCHT10 As Double = -1

        Private mPhanTram_ThiLai As Double = 0
        Private mID_xep_loai As Integer = 0
        Private mXep_hang As String = ""
        Private mXep_hang_En As String = ""
        Private mNam_hoc As String = ""
        Private mLy_do As String = ""

        Private mChuyen_nganh As String = ""
        Private mChuyen_nganh_En As String = ""
        Private mTen_nganh As String = ""
        Private mTen_nganh_En As String = ""
        Private mTen_khoa As String = ""
        Private mKhoa_hoc As String = ""
        Private mTen_he As String = ""
        Private mTen_he_En As String = ""
        Private mTen_tinh As String = ""
        Private mNien_khoa As String = ""
#End Region
#Region "Property"
        Public Property Lan_thu() As Integer
            Get
                Return mLan_thu
            End Get
            Set(ByVal Value As Integer)
                mLan_thu = Value
            End Set
        End Property
        Public Property So_bang() As Integer
            Get
                Return mSo_bang
            End Get
            Set(ByVal Value As Integer)
                mSo_bang = Value
            End Set
        End Property
        Public Property TBCHT10() As Double
            Get
                Return mTBCHT10
            End Get
            Set(ByVal Value As Double)
                mTBCHT10 = Value
            End Set
        End Property

        Public Property PhanTram_ThiLai() As Double
            Get
                Return mPhanTram_ThiLai
            End Get
            Set(ByVal Value As Double)
                mPhanTram_ThiLai = Value
            End Set
        End Property
        Public Property TBCHT() As Double
            Get
                Return mTBCHT
            End Get
            Set(ByVal Value As Double)
                mTBCHT = Value
            End Set
        End Property
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
            End Set
        End Property
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
            End Set
        End Property
        Public Property Xep_hang_En() As String
            Get
                Return mXep_hang_En
            End Get
            Set(ByVal Value As String)
                mXep_hang_En = Value
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
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
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
        Public Property Chuyen_nganh_En() As String
            Get
                Return mChuyen_nganh_En
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh_En = Value
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
        Public Property Ten_nganh_En() As String
            Get
                Return mTen_nganh_En
            End Get
            Set(ByVal Value As String)
                mTen_nganh_En = Value
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
        Public Property Khoa_hoc() As String
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As String)
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
        Public Property Ten_he_En() As String
            Get
                Return mTen_he_En
            End Get
            Set(ByVal Value As String)
                mTen_he_En = Value
            End Set
        End Property
        Public Property Ten_tinh() As String
            Get
                Return mTen_tinh
            End Get
            Set(ByVal Value As String)
                mTen_tinh = Value
            End Set
        End Property

        Public Property So_QD() As String
            Get
                Return mSo_QD
            End Get
            Set(ByVal Value As String)
                mSo_QD = Value
            End Set
        End Property
        Public Property Ngay_QD() As Date
            Get
                Return mNgay_QD
            End Get
            Set(ByVal Value As Date)
                mNgay_QD = Value
            End Set
        End Property

        Public Property So_hieu() As String
            Get
                Return mSo_hieu
            End Get
            Set(ByVal Value As String)
                mSo_hieu = Value
            End Set
        End Property

        Public Property So_vao_so() As String
            Get
                Return mSo_vao_so
            End Get
            Set(ByVal Value As String)
                mSo_vao_so = Value
            End Set
        End Property
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
#End Region
    End Class
End Namespace