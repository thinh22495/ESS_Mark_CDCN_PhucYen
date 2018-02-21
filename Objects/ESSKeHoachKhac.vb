'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, December 29, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSKeHoachKhac
#Region "Initialize"
#End Region

#Region "Var"
        Private mID As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mID_nganh As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mTu_ngay As Date
        Private mDen_ngay As Date
        Private mKy_hieu As String = ""
        Private mHien_thi As Boolean = 0
        Private mKy_hieu1 As String = ""
        Private mTen_ky_hieu As String = ""
        Private mbgColor As Integer = 0
        Private mtxtColor As Integer = 0
        Private mMa_he As String = ""
        Private mTen_he As String = ""
        Private mMa_khoa As String = ""
        Private mTen_khoa As String = ""
        Private mMa_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mMa_chuyen_nganh As String = ""
        Private mChuyen_nganh As String = ""
#End Region

#Region "Property"
        Public Property ID() As Integer
            Get
                Return mID
            End Get
            Set(ByVal Value As Integer)
                mID = Value
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
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
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
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Hien_thi() As Boolean
            Get
                Return mHien_thi
            End Get
            Set(ByVal Value As Boolean)
                mHien_thi = Value
            End Set
        End Property
        Public Property Ky_hieu1() As String
            Get
                Return mKy_hieu1
            End Get
            Set(ByVal Value As String)
                mKy_hieu1 = Value
            End Set
        End Property
        Public Property Ten_ky_hieu() As String
            Get
                Return mTen_ky_hieu
            End Get
            Set(ByVal Value As String)
                mTen_ky_hieu = Value
            End Set
        End Property
        Public Property bgColor() As Integer
            Get
                Return mbgColor
            End Get
            Set(ByVal Value As Integer)
                mbgColor = Value
            End Set
        End Property
        Public Property txtColor() As Integer
            Get
                Return mtxtColor
            End Get
            Set(ByVal Value As Integer)
                mtxtColor = Value
            End Set
        End Property
        Public Property Ma_he() As String
            Get
                Return mMa_he
            End Get
            Set(ByVal Value As String)
                mMa_he = Value
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
        Public Property Ma_khoa() As String
            Get
                Return mMa_khoa
            End Get
            Set(ByVal Value As String)
                mMa_khoa = Value
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
        Public Property Ma_nganh() As String
            Get
                Return mMa_nganh
            End Get
            Set(ByVal Value As String)
                mMa_nganh = Value
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
        Public Property Ma_chuyen_nganh() As String
            Get
                Return mMa_chuyen_nganh
            End Get
            Set(ByVal Value As String)
                mMa_chuyen_nganh = Value
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
#End Region

    End Class
End Namespace
