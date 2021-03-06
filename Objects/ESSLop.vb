'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/15/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSLop
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_lop As Integer = 0
        Private mTen_lop As String = ""
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mTen_he As String = ""
        Private mTen_khoa As String = ""
        Private mChuyen_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mNien_khoa As String = ""
        Private mID_dt As Integer = 0
        Private mSo_sv As Integer = 0
        Private mRa_truong As Boolean = 0
        Private mID_nganh As Integer = 0
        Private mTinh_chat As Integer = 0
        Private mLop_chuyen_nganh As Integer = 0
        Private mLop_hanh_chinh As Integer = 0
#End Region

#Region "Property"
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
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
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
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
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
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
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
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
        Public Property Ra_truong() As Boolean
            Get
                Return mRa_truong
            End Get
            Set(ByVal Value As Boolean)
                mRa_truong = Value
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

        Public Property Tinh_chat() As Integer
            Get
                Return mTinh_chat
            End Get
            Set(ByVal Value As Integer)
                mTinh_chat = Value
            End Set
        End Property

        Public Property Lop_chuyen_nganh() As Integer
            Get
                Return mLop_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mLop_chuyen_nganh = Value
            End Set
        End Property


        Public Property Lop_hanh_chinh() As Integer
            Get
                Return mLop_hanh_chinh
            End Get
            Set(ByVal Value As Integer)
                mLop_hanh_chinh = Value
            End Set
        End Property

#End Region

    End Class
End Namespace
