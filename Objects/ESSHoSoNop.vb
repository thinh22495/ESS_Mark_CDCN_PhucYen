'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, May 27, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHoSoNop
        Inherits ESSLoaiGiayTo
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mGhi_chu_nop As String = ""
        Private mGhi_chu_tra As String = ""
        Private mDa_tra As Boolean = 0
        Private mBan_chinh As Boolean = 0
        Private mBan_sao As Boolean = 0
        Private mNgay_tra As Date = Nothing
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
        Public Property Ghi_chu_nop() As String
            Get
                Return mGhi_chu_nop
            End Get
            Set(ByVal Value As String)
                mGhi_chu_nop = Value
            End Set
        End Property
        Public Property Ghi_chu_tra() As String
            Get
                Return mGhi_chu_tra
            End Get
            Set(ByVal Value As String)
                mGhi_chu_tra = Value
            End Set
        End Property
        Public Property Da_tra() As Boolean
            Get
                Return mDa_tra
            End Get
            Set(ByVal Value As Boolean)
                mDa_tra = Value
            End Set
        End Property
        Public Property Ngay_tra() As Date
            Get
                Return mNgay_tra
            End Get
            Set(ByVal Value As Date)
                mNgay_tra = Value
            End Set
        End Property
        Public Property Ban_chinh() As Boolean
            Get
                Return mBan_chinh
            End Get
            Set(ByVal Value As Boolean)
                mBan_chinh = Value
            End Set
        End Property

        Public Property Ban_sao() As Boolean
            Get
                Return mBan_sao
            End Get
            Set(ByVal Value As Boolean)
                mBan_sao = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
