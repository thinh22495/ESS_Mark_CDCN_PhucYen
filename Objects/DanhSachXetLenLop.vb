Imports System
Namespace Objects
    Public Class ESSDanhSachXetLenLop
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_qd As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mSo_qd As String = ""
        Private mNgay_qd As Date
        Private mLoai_qd As Integer = 0
        Private mLy_do As String = ""
        Private mID_lop_cu As Integer = 0
        Private mID_lop_moi As Integer = 0
        Private mTen_lop As String = ""
        Private mTen_khoa As String = ""
        Private mLop_moi As String = ""
#End Region

#Region "Property"
        Public Property ID_qd() As Integer
            Get
                Return mID_qd
            End Get
            Set(ByVal Value As Integer)
                mID_qd = Value
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
        Public Property Loai_qd() As Integer
            Get
                Return mLoai_qd
            End Get
            Set(ByVal Value As Integer)
                mLoai_qd = Value
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
        Public Property ID_lop_cu() As Integer
            Get
                Return mID_lop_cu
            End Get
            Set(ByVal Value As Integer)
                mID_lop_cu = Value
            End Set
        End Property
        Public Property ID_lop_moi() As Integer
            Get
                Return mID_lop_moi
            End Get
            Set(ByVal Value As Integer)
                mID_lop_moi = Value
            End Set
        End Property
        Public Property Lop_moi() As String
            Get
                Return mLop_moi
            End Get
            Set(ByVal Value As String)
                mLop_moi = Value
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
