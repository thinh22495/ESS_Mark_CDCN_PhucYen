'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDoiTuongChinhSach
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mID_dt As Integer = 0
        Private mMa_dt As String = ""
        Private mTen_dt As String = ""
        Private mMien_giam As String = ""
        Private mSotien_miengiam As Integer = 0
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
        Public Property ID_dt() As Integer
            Get
                Return mID_dt
            End Get
            Set(ByVal Value As Integer)
                mID_dt = Value
            End Set
        End Property
        Public Property Ma_dt() As String
            Get
                Return mMa_dt
            End Get
            Set(ByVal Value As String)
                mMa_dt = Value
            End Set
        End Property
        Public Property Ten_dt() As String
            Get
                Return mTen_dt
            End Get
            Set(ByVal Value As String)
                mTen_dt = Value
            End Set
        End Property
        Public Property Mien_giam() As String
            Get
                Return mMien_giam
            End Get
            Set(ByVal Value As String)
                mMien_giam = Value
            End Set
        End Property
        Public Property Sotien_miengiam() As Integer
            Get
                Return mSotien_miengiam
            End Get
            Set(ByVal Value As Integer)
                mSotien_miengiam = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
