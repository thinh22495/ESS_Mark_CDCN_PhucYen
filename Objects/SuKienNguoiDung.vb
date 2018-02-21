'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, 03 June, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSSuKienNguoiDung
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_su_kien As Integer = 0
        Private mID_phan_he As Integer = 0
        Private mPhan_he As String = ""
        Private mSu_kien As Integer = 0
        Private mChuc_nang As String = ""
        Private mNoi_dung As String = ""
        Private mThoi_diem As Date
        Private mMay_tram As String = ""
        Private mUserName As String = ""
#End Region

#Region "Property"
        Public Property ID_su_kien() As Integer
            Get
                Return mID_su_kien
            End Get
            Set(ByVal Value As Integer)
                mID_su_kien = Value
            End Set
        End Property
        Public Property ID_phan_he() As Integer
            Get
                Return mID_phan_he
            End Get
            Set(ByVal Value As Integer)
                mID_phan_he = Value
            End Set
        End Property
        Public Property Phan_he() As String
            Get
                Return mPhan_he
            End Get
            Set(ByVal Value As String)
                mPhan_he = Value
            End Set
        End Property
        Public Property Su_kien() As Integer
            Get
                Return mSu_kien
            End Get
            Set(ByVal Value As Integer)
                mSu_kien = Value
            End Set
        End Property
        Public Property Chuc_nang() As String
            Get
                Return mChuc_nang
            End Get
            Set(ByVal Value As String)
                mChuc_nang = Value
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
        Public Property Thoi_diem() As DateTime
            Get
                Return mThoi_diem
            End Get
            Set(ByVal Value As DateTime)
                mThoi_diem = Value
            End Set
        End Property
        Public Property May_tram() As String
            Get
                Return mMay_tram
            End Get
            Set(ByVal Value As String)
                mMay_tram = Value
            End Set
        End Property
        Public Property UserName() As String
            Get
                Return mUserName
            End Get
            Set(ByVal Value As String)
                mUserName = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
