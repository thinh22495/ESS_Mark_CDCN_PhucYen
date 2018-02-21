'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDoiTuongTroCap
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mID_dt_hb As Integer = 0
        Private mMa_dt_hb As String = ""
        Private mTen_dt_hb As String = ""
        Private mSotien_trocap As Integer = 0
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
        Public Property ID_dt_hb() As Integer
            Get
                Return mID_dt_hb
            End Get
            Set(ByVal Value As Integer)
                mID_dt_hb = Value
            End Set
        End Property
        Public Property Ma_dt_hb() As String
            Get
                Return mMa_dt_hb
            End Get
            Set(ByVal Value As String)
                mMa_dt_hb = Value
            End Set
        End Property
        Public Property Ten_dt_hb() As String
            Get
                Return mTen_dt_hb
            End Get
            Set(ByVal Value As String)
                mTen_dt_hb = Value
            End Set
        End Property
        Public Property Sotien_trocap() As Integer
            Get
                Return mSotien_trocap
            End Get
            Set(ByVal Value As Integer)
                mSotien_trocap = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
