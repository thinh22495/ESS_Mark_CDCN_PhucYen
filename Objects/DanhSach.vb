'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, May 03, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhSach
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mID_lop As Integer = 0
        Private mMat_khau As String = ""
        Private mActive As Boolean = 0
        Private mDa_tot_nghiep As Boolean = 0
        Private mNgoai_ngan_sach As Boolean = 0
        Private mMa_sv As String = ""
#End Region

#Region "Property"
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Ma_sv() As Integer
            Get
                Return mMa_sv
            End Get
            Set(ByVal Value As Integer)
                mMa_sv = Value
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
        Public Property Mat_khau() As String
            Get
                Return mMat_khau
            End Get
            Set(ByVal Value As String)
                mMat_khau = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return mActive
            End Get
            Set(ByVal Value As Boolean)
                mActive = Value
            End Set
        End Property
        Public Property Da_tot_nghiep() As Boolean
            Get
                Return mDa_tot_nghiep
            End Get
            Set(ByVal Value As Boolean)
                mDa_tot_nghiep = Value
            End Set
        End Property
        Public Property Ngoai_ngan_sach() As Boolean
            Get
                Return mNgoai_ngan_sach
            End Get
            Set(ByVal Value As Boolean)
                mNgoai_ngan_sach = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
