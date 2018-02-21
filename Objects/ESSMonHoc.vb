'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSMonHoc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_mon As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_mon As String = ""
        Private mTen_tieng_anh As String = ""
        Private mID_bm As Integer = 0
        Private mID_nhom As Integer = 0
        Private mID_he As Integer = 0
#End Region

#Region "Property"
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property ID_nhom() As Integer
            Get
                Return mID_nhom
            End Get
            Set(ByVal Value As Integer)
                mID_nhom = Value
            End Set
        End Property
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_mon() As String
            Get
                Return mTen_mon
            End Get
            Set(ByVal Value As String)
                mTen_mon = Value
            End Set
        End Property
        Public Property Ten_tieng_anh() As String
            Get
                Return mTen_tieng_anh
            End Get
            Set(ByVal Value As String)
                mTen_tieng_anh = Value
            End Set
        End Property
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
