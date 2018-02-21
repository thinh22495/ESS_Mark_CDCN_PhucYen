'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 08, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHe
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_he As Integer = 0
        Private mMa_he As String = ""
        Private mTen_he As String = ""
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
        Public Property Ma_he() As String
            Get
                Return mMa_he
            End Get
            Set(ByVal Value As String)
                mMa_he = Value
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
#End Region

    End Class
End Namespace
