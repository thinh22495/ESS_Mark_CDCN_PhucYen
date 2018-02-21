'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, August 09, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhSachHocBong
        Inherits ESSQuyHocBong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_phan_bo As Integer = 0
        Private mID_sv As Integer = 0
        Private mID_xep_loai_hb As Integer = 0
        Private mHB_HT As Integer = 0
        Private mHB_CS As Integer = 0
#End Region

#Region "Property"
        Public Property ID_phan_bo() As Integer
            Get
                Return mID_phan_bo
            End Get
            Set(ByVal Value As Integer)
                mID_phan_bo = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property ID_xep_loai_hb() As Integer
            Get
                Return mID_xep_loai_hb
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai_hb = Value
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
        Public Property HB_CS() As Integer
            Get
                Return mHB_CS
            End Get
            Set(ByVal Value As Integer)
                mHB_CS = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
