'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 07, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSQuyDinhSoTinChiSom
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_he As Integer = 0
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String
        Private mSo_hoc_trinh_min_bt As Integer = 0
        Private mSo_hoc_trinh_max_bt As Integer = 0
        Private mSo_hoc_trinh_option_bt As Integer = 0
        Private mKiemTra_So_hoc_trinh_min_bt As Boolean = 0
        Private mKiemTra_So_hoc_trinh_max_bt As Boolean = 0
        Private mSo_hoc_trinh_min_yeu As Integer = 0
        Private mSo_hoc_trinh_max_yeu As Integer = 0
        Private mSo_hoc_trinh_option_yeu As Integer = 0
        Private mKiemTra_So_hoc_trinh_min_yeu As Boolean = 0
        Private mKiemTra_So_hoc_trinh_max_yeu As Boolean = 0
        Private mTu_ngay As Object
        Private mDen_ngay As Object
        Private mTen_he As String
        Private mTen_khoa As String
#End Region

#Region "Property"
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
        Public Property So_hoc_trinh_min_bt() As Integer
            Get
                Return mSo_hoc_trinh_min_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_min_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_max_bt() As Integer
            Get
                Return mSo_hoc_trinh_max_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_max_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_option_bt() As Integer
            Get
                Return mSo_hoc_trinh_option_bt
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_option_bt = Value
            End Set
        End Property
        Public Property KiemTra_So_hoc_trinh_min_bt() As Boolean
            Get
                Return mKiemTra_So_hoc_trinh_min_bt
            End Get
            Set(ByVal Value As Boolean)
                mKiemTra_So_hoc_trinh_min_bt = Value
            End Set
        End Property
        Public Property KiemTra_So_hoc_trinh_max_bt() As Boolean
            Get
                Return mKiemTra_So_hoc_trinh_max_bt
            End Get
            Set(ByVal Value As Boolean)
                mKiemTra_So_hoc_trinh_max_bt = Value
            End Set
        End Property
        Public Property So_hoc_trinh_min_yeu() As Integer
            Get
                Return mSo_hoc_trinh_min_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_min_yeu = Value
            End Set
        End Property
        Public Property So_hoc_trinh_max_yeu() As Integer
            Get
                Return mSo_hoc_trinh_max_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_max_yeu = Value
            End Set
        End Property
        Public Property So_hoc_trinh_option_yeu() As Integer
            Get
                Return mSo_hoc_trinh_option_yeu
            End Get
            Set(ByVal Value As Integer)
                mSo_hoc_trinh_option_yeu = Value
            End Set
        End Property
        Public Property KiemTra_So_hoc_trinh_min_yeu() As Boolean
            Get
                Return mKiemTra_So_hoc_trinh_min_yeu
            End Get
            Set(ByVal Value As Boolean)
                mKiemTra_So_hoc_trinh_min_yeu = Value
            End Set
        End Property
        Public Property KiemTra_So_hoc_trinh_max_yeu() As Boolean
            Get
                Return mKiemTra_So_hoc_trinh_max_yeu
            End Get
            Set(ByVal Value As Boolean)
                mKiemTra_So_hoc_trinh_max_yeu = Value
            End Set
        End Property
        Public Property Tu_ngay() As Object
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Object)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Object
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Object)
                mDen_ngay = Value
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
#End Region

    End Class
End Namespace
