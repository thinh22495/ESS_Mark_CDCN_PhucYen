'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSGiaoVien
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            mTKB = New ESSTKB(Ngay_tuan, So_tiet_ngay)
        End Sub
#End Region

#Region "Var"
        Private mID_cb As Integer = 0
        Private mMa_cb As String = ""
        Private mTen As String = ""
        Private mHo_ten As String = ""
        Private mID_gioi_tinh As Integer = 0
        Private mNgay_sinh As Date
        Private mID_khoa As Integer = 0
        Private mID_hoc_ham As Integer = 0
        Private mID_hoc_vi As Integer = 0
        Private mID_chuc_danh As Integer = 0
        Private mID_chuc_vu As Integer = 0
        Private mID_bm As Integer = 0
        Private mBo_mon As String = ""
        Private mChuc_danh As String = ""
        Private mChuc_vu As String = ""
        Private mHoc_ham As String = ""
        Private mHoc_vi As String = ""
        Private mTiet_sang As Integer = 0
        Private mTiet_chieu As Integer = 0
        Private mTiet_toi As Integer = 0
        Private mMonDay As New ESSGiaoVienMonDay
        Private mTKB As ESSTKB
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
        Public Property Tiet_Sang() As Integer
            Get
                Return Me.mTiet_sang
            End Get
            Set(ByVal Value As Integer)
                Me.mTiet_sang = Value
            End Set
        End Property

        Public Property Tiet_Chieu() As Integer
            Get
                Return Me.mTiet_chieu
            End Get
            Set(ByVal Value As Integer)
                Me.mTiet_chieu = Value
            End Set
        End Property

        Public Property Tiet_Toi() As Integer
            Get
                Return Me.mTiet_toi
            End Get
            Set(ByVal Value As Integer)
                Me.mTiet_toi = Value
            End Set
        End Property

        Public Function Max_tiet() As Integer
            Dim max As Integer = 0
            If max < Tiet_Chieu Then max = Tiet_Chieu
            If max < Tiet_Sang Then max = Tiet_Sang
            Return max
        End Function
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
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
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
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
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
        Public Property Bo_mon() As String
            Get
                Return mBo_mon
            End Get
            Set(ByVal Value As String)
                mBo_mon = Value
            End Set
        End Property
        Public Property Chuc_danh() As String
            Get
                Return mChuc_danh
            End Get
            Set(ByVal Value As String)
                mChuc_danh = Value
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
        Public Property Hoc_ham() As String
            Get
                Return mHoc_ham
            End Get
            Set(ByVal Value As String)
                mHoc_ham = Value
            End Set
        End Property
        Public Property Hoc_vi() As String
            Get
                Return mHoc_vi
            End Get
            Set(ByVal Value As String)
                mHoc_vi = Value
            End Set
        End Property
        Public Property MonDay() As ESSGiaoVienMonDay
            Get
                Return mMonDay
            End Get
            Set(ByVal Value As ESSGiaoVienMonDay)
                mMonDay = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
