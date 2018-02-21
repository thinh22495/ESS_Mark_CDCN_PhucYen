'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, August 06, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSLoaiHocBong
#Region "Initialize"
#End Region

#Region "Var"
        Private mMa_dt As String = ""
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mID_xep_loai_hb As Integer = 0
        Private mTen_xep_loai As String = ""
        Private mHB_HT As Integer = 0
#End Region

#Region "Property"
        Public Property Ma_dt() As String
            Get
                Return mMa_dt
            End Get
            Set(ByVal Value As String)
                mMa_dt = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal value As Integer)
                mID_he = value
            End Set
        End Property
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
            End Set
        End Property
        Public Property ID_xep_loai_hb() As Integer
            Get
                Return mID_xep_loai_hb
            End Get
            Set(ByVal value As Integer)
                mID_xep_loai_hb = value
            End Set
        End Property
        Public Property Ten_xep_loai() As String
            Get
                Return mTen_xep_loai
            End Get
            Set(ByVal Value As String)
                mTen_xep_loai = Value
            End Set
        End Property
        Public Property HB_HT() As Integer
            Get
                Return mHB_HT
            End Get
            Set(ByVal Value As Integer)
                mHB_HT = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
