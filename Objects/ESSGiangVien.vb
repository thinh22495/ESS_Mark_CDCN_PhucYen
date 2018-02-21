'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, June 26, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSGiangVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_cb As Integer = 0
        Private mMa_cb As String = ""
        Private mTen As String = ""
        Private mHo_ten As String = ""
        Private mID_gioi_tinh As Integer = 0
        Private mNgay_sinh As Object
        Private mID_khoa As Integer = 0
        Private mID_hoc_ham As Integer = 0
        Private mID_hoc_vi As Integer = 0
        Private mID_chuc_danh As Integer = 0
        Private mID_chuc_vu As Integer = 0
        Private mgioi_tinh As String = ""
        Private mMa_chuc_danh As String = ""
        Private mchuc_danh As String = ""
        Private mMa_chuc_vu As String = ""
        Private mChuc_vu As String = ""
        Private mMa_hoc_ham As String = ""
        Private mhoc_ham As String = ""
        Private mMa_hoc_vi As String = ""
        Private mhoc_vi As String = ""
        Private mma_khoa As String = ""
        Private mten_khoa As String = ""
        Private mBoMon As New ArrayList
        Private mMonDay As New ArrayList
#End Region

#Region "Property"
        Public Property ID_cb() As Integer
            Get
                Return mID_cb
            End Get
            Set(ByVal Value As Integer)
                mID_cb = Value
            End Set
        End Property
        Public Property Ma_cb() As String
            Get
                Return mMa_cb
            End Get
            Set(ByVal Value As String)
                mMa_cb = Value
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
        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal Value As String)
                mHo_ten = Value
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
        Public Property Ngay_sinh() As Object
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Object)
                mNgay_sinh = Value
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
        Public Property ID_hoc_ham() As Integer
            Get
                Return mID_hoc_ham
            End Get
            Set(ByVal Value As Integer)
                mID_hoc_ham = Value
            End Set
        End Property
        Public Property ID_hoc_vi() As Integer
            Get
                Return mID_hoc_vi
            End Get
            Set(ByVal Value As Integer)
                mID_hoc_vi = Value
            End Set
        End Property
        Public Property ID_chuc_danh() As Integer
            Get
                Return mID_chuc_danh
            End Get
            Set(ByVal Value As Integer)
                mID_chuc_danh = Value
            End Set
        End Property
        Public Property ID_chuc_vu() As Integer
            Get
                Return mID_chuc_vu
            End Get
            Set(ByVal Value As Integer)
                mID_chuc_vu = Value
            End Set
        End Property
        Public Property gioi_tinh() As String
            Get
                Return mgioi_tinh
            End Get
            Set(ByVal Value As String)
                mgioi_tinh = Value
            End Set
        End Property
        Public Property Ma_chuc_danh() As String
            Get
                Return mMa_chuc_danh
            End Get
            Set(ByVal Value As String)
                mMa_chuc_danh = Value
            End Set
        End Property
        Public Property chuc_danh() As String
            Get
                Return mchuc_danh
            End Get
            Set(ByVal Value As String)
                mchuc_danh = Value
            End Set
        End Property
        Public Property Ma_chuc_vu() As String
            Get
                Return mMa_chuc_vu
            End Get
            Set(ByVal Value As String)
                mMa_chuc_vu = Value
            End Set
        End Property
        Public Property Chuc_vu() As String
            Get
                Return mChuc_vu
            End Get
            Set(ByVal Value As String)
                mChuc_vu = Value
            End Set
        End Property
        Public Property Ma_hoc_ham() As String
            Get
                Return mMa_hoc_ham
            End Get
            Set(ByVal Value As String)
                mMa_hoc_ham = Value
            End Set
        End Property
        Public Property hoc_ham() As String
            Get
                Return mhoc_ham
            End Get
            Set(ByVal Value As String)
                mhoc_ham = Value
            End Set
        End Property
        Public Property Ma_hoc_vi() As String
            Get
                Return mMa_hoc_vi
            End Get
            Set(ByVal Value As String)
                mMa_hoc_vi = Value
            End Set
        End Property
        Public Property hoc_vi() As String
            Get
                Return mhoc_vi
            End Get
            Set(ByVal Value As String)
                mhoc_vi = Value
            End Set
        End Property
        Public Property ma_khoa() As String
            Get
                Return mma_khoa
            End Get
            Set(ByVal Value As String)
                mma_khoa = Value
            End Set
        End Property
        Public Property ten_khoa() As String
            Get
                Return mten_khoa
            End Get
            Set(ByVal Value As String)
                mten_khoa = Value
            End Set
        End Property
        Public Property dsBoMon() As ArrayList
            Get
                Return mBoMon
            End Get
            Set(ByVal value As ArrayList)
                mBoMon = value
            End Set
        End Property
        Public Property dsMonDay() As ArrayList
            Get
                Return mMonDay
            End Get
            Set(ByVal value As ArrayList)
                mMonDay = value
            End Set
        End Property
#End Region

    End Class
End Namespace


