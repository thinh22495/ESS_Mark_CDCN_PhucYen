'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/21/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSQuyen
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_quyen As Integer = 0
        Private mTen_quyen As String = ""
        Private mID_ph As Integer = 0
        Private mID_nhom_quyen As Integer = 0
        Private mPhan_he As String = ""
        Private mTen_nhom_quyen As String = ""
#End Region

#Region "Property"
        Public Property ID_quyen() As Integer
            Get
                Return mID_quyen
            End Get
            Set(ByVal Value As Integer)
                mID_quyen = Value
            End Set
        End Property
        Public Property Ten_quyen() As String
            Get
                Return mTen_quyen
            End Get
            Set(ByVal Value As String)
                mTen_quyen = Value
            End Set
        End Property
        Public Property ID_ph() As Integer
            Get
                Return mID_ph
            End Get
            Set(ByVal Value As Integer)
                mID_ph = Value
            End Set
        End Property
        Public Property ID_nhom_quyen() As Integer
            Get
                Return mID_nhom_quyen
            End Get
            Set(ByVal Value As Integer)
                mID_nhom_quyen = Value
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
        Public Property Ten_nhom_quyen() As String
            Get
                Return mTen_nhom_quyen
            End Get
            Set(ByVal Value As String)
                mTen_nhom_quyen = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
