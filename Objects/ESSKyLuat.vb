'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, 04 June, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSKyLuat
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_ky_luat As Integer = 0
        Private mSo_qd As String = ""
        Private mNgay_qd As Date
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_hanh_vi As Integer = 0
        Private mHanh_vi As String = ""
        Private mID_xu_ly As Integer = 0
        Private mXu_ly As String = ""
        Private mNoi_dung As String = ""
        Private mID_cap As Integer = 0
        Private mTen_cap As String = ""
        Private mXoa_ky_luat As Boolean = 0
        Private mNgay_xoa As String = ""
        Private mLydo_xoa As String = ""
        Private mID_lop As Integer = 0
        Private mID_sv As Integer = 0
        Private mMuc_xu_ly As Integer = 0
#End Region

#Region "Property"
        Public Property Muc_xu_ly() As Integer
            Get
                Return mMuc_xu_ly
            End Get
            Set(ByVal Value As Integer)
                mMuc_xu_ly = Value
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
        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal Value As Integer)
                mID_lop = Value
            End Set
        End Property
        Public Property ID_ky_luat() As Integer
            Get
                Return mID_ky_luat
            End Get
            Set(ByVal Value As Integer)
                mID_ky_luat = Value
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
                Return mNgay_qd
            End Get
            Set(ByVal Value As Date)
                mNgay_qd = Value
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
        Public Property ID_hanh_vi() As Integer
            Get
                Return mID_hanh_vi
            End Get
            Set(ByVal Value As Integer)
                mID_hanh_vi = Value
            End Set
        End Property
        Public Property Hanh_vi() As String
            Get
                Return mHanh_vi
            End Get
            Set(ByVal Value As String)
                mHanh_vi = Value
            End Set
        End Property
        Public Property ID_xu_ly() As Integer
            Get
                Return mID_xu_ly
            End Get
            Set(ByVal Value As Integer)
                mID_xu_ly = Value
            End Set
        End Property
        Public Property Xu_ly() As String
            Get
                Return mXu_ly
            End Get
            Set(ByVal Value As String)
                mXu_ly = Value
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
        Public Property ID_cap() As Integer
            Get
                Return mID_cap
            End Get
            Set(ByVal Value As Integer)
                mID_cap = Value
            End Set
        End Property
        Public Property Ten_cap() As String
            Get
                Return mTen_cap
            End Get
            Set(ByVal Value As String)
                mTen_cap = Value
            End Set
        End Property
        Public Property Xoa_ky_luat() As Boolean
            Get
                Return mXoa_ky_luat
            End Get
            Set(ByVal Value As Boolean)
                mXoa_ky_luat = Value
            End Set
        End Property
        Public Property Ngay_xoa() As String
            Get
                Return mNgay_xoa
            End Get
            Set(ByVal Value As String)
                mNgay_xoa = Value
            End Set
        End Property
        Public Property Lydo_xoa() As String
            Get
                Return mLydo_xoa
            End Get
            Set(ByVal Value As String)
                mLydo_xoa = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
