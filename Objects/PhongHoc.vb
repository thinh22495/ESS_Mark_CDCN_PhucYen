'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSPhongHoc
#Region "Initialize"
        Public Sub New()
        End Sub
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            mTKB = New ESSTKB(Ngay_tuan, So_tiet_ngay)
        End Sub
#End Region

#Region "Var"
        Private mID_phong As Integer = 0
        Private mID_nha As Integer = 0
        Private mID_tang As Integer = 0
        Private mKhong_ToChucThi As Integer = 0
        Private mSo_phong As String = ""
        Private mTen_phong As String = ""
        Private mSuc_chua As Integer = 0
        Private mSo_sv As Integer = 0
        Private mID_loai_phong As Integer = 0
        Private mThiet_bi As String = ""
        Private mTen_nha As String = ""
        Private mTen_tang As String = ""
        Private mThuc_hanh As Boolean = 0
        Private mTen_loai_phong As String = ""
        Private mID_co_so As Integer = 0
        Private mTen_co_so As String = ""
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
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal Value As Integer)
                mID_phong = Value
            End Set
        End Property
        Public Property ID_nha() As Integer
            Get
                Return mID_nha
            End Get
            Set(ByVal Value As Integer)
                mID_nha = Value
            End Set
        End Property
        Public Property ID_tang() As Integer
            Get
                Return mID_tang
            End Get
            Set(ByVal Value As Integer)
                mID_tang = Value
            End Set
        End Property
        Public Property So_phong() As String
            Get
                Return mSo_phong
            End Get
            Set(ByVal Value As String)
                mSo_phong = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property
        Public Property Suc_chua() As Integer
            Get
                Return mSuc_chua
            End Get
            Set(ByVal Value As Integer)
                mSuc_chua = Value
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
        Public Property ID_loai_phong() As Integer
            Get
                Return mID_loai_phong
            End Get
            Set(ByVal Value As Integer)
                mID_loai_phong = Value
            End Set
        End Property
        Public Property Thiet_bi() As String
            Get
                Return mThiet_bi
            End Get
            Set(ByVal Value As String)
                mThiet_bi = Value
            End Set
        End Property
        Public Property Ten_nha() As String
            Get
                Return mTen_nha
            End Get
            Set(ByVal Value As String)
                mTen_nha = Value
            End Set
        End Property
        Public Property Ten_tang() As String
            Get
                Return mTen_tang
            End Get
            Set(ByVal Value As String)
                mTen_tang = Value
            End Set
        End Property
        Public Property Thuc_hanh() As Boolean
            Get
                Return mThuc_hanh
            End Get
            Set(ByVal Value As Boolean)
                mThuc_hanh = Value
            End Set
        End Property
        Public Property Ten_loai_phong() As String
            Get
                Return mTen_loai_phong
            End Get
            Set(ByVal Value As String)
                mTen_loai_phong = Value
            End Set
        End Property
        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal Value As Integer)
                mID_co_so = Value
            End Set
        End Property
        Public Property Ten_co_so() As String
            Get
                Return mTen_co_so
            End Get
            Set(ByVal Value As String)
                mTen_co_so = Value
            End Set
        End Property

        Public Property Khong_ToChucThi() As Integer
            Get
                Return mKhong_ToChucThi
            End Get
            Set(ByVal Value As Integer)
                mKhong_ToChucThi = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
