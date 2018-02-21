Imports System
Namespace Objects
    Public Class ESSDanhSachLuanVanThiNoTotNghiep
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mTBCHT As Double = 0
        Private mID_xep_loai As Integer = 0
        Private mSo_tin_chi As Integer = 0
        Private mLy_do As String = ""
        Private mXep_hang As String = ""
#End Region

#Region "Property"
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
        Public Property So_tin_chi() As Integer
            Get
                Return mSo_tin_chi
            End Get
            Set(ByVal Value As Integer)
                mSo_tin_chi = Value
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
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
            End Set
        End Property
#End Region

    End Class
End Namespace