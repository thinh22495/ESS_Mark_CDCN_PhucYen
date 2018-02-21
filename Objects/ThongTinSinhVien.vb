'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, August 07, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSThongTinSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date
        Private mGioi_tinh As String
        Private mNoi_sinh As String
        Private mID_lop As Integer = 0
        Private mTen_lop As String = ""
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mID_khoa As Integer = 0
        Private mTen_khoa As String = ""
        Private mID_nganh As Integer = 0
        Private mTen_nganh As String = ""
        Private mID_chuyen_nganh As Integer = 0
        Private mChuyen_nganh As String = ""
        Private mID_chuyen_nganh2 As Integer = 0
        Private mChuyen_nganh2 As String = ""
        Private mKhoa_hoc As Integer = 0
        Private mNien_khoa As String = ""
        Private mID_dt As Integer = 0
        Private mID_dt2 As Integer = 0
        Private mCo_van_hoc_tap As String = ""
        Private mNgoai_ngan_sach As Boolean = False
        Private mLop_chat_luong_cao As Boolean = False
        Private mKy_thuat As Boolean = False
        Private mKy_thuat2 As Boolean = False
#End Region

#Region "Property"
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
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
                mNgay_sinh = Value
            End Set
        End Property
        Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal value As String)
                mGioi_tinh = value
            End Set
        End Property
        Property Noi_sinh() As String
            Get
                Return mNoi_sinh
            End Get
            Set(ByVal value As String)
                mNoi_sinh = value
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
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
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
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
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
        Public Property Nien_khoa() As String
            Get
                Return mNien_khoa
            End Get
            Set(ByVal Value As String)
                mNien_khoa = Value
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
        Public Property ID_chuyen_nganh2() As Integer
            Get
                Return mID_chuyen_nganh2
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh2 = Value
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
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
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
        Public Property Co_van_hoc_tap() As String
            Get
                Return mCo_van_hoc_tap
            End Get
            Set(ByVal Value As String)
                mCo_van_hoc_tap = Value
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

        Public Property Ky_thuat() As Boolean
            Get
                Return mKy_thuat
            End Get
            Set(ByVal Value As Boolean)
                mKy_thuat = Value
            End Set
        End Property

        Public Property Ky_thuat_Nganh2() As Boolean
            Get
                Return mKy_thuat2
            End Get
            Set(ByVal Value As Boolean)
                mKy_thuat2 = Value
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
