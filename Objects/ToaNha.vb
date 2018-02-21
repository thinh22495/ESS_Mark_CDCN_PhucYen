'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSToaNha
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_nha As Integer = 0
        Private mID_co_so As Integer = 0
        Private mMa_nha As String = ""
        Private mTen_nha As String = ""
#End Region

#Region "Property"
        Public Property ID_nha() As Integer
            Get
                Return mID_nha
            End Get
            Set(ByVal Value As Integer)
                mID_nha = Value
            End Set
        End Property
        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal Value As Integer)
                mID_co_so = Value
            End Set
        End Property
        Public Property Ma_nha() As String
            Get
                Return mMa_nha
            End Get
            Set(ByVal Value As String)
                mMa_nha = Value
            End Set
        End Property
        Public Property Ten_nha() As String
            Get
                Return mTen_nha
            End Get
            Set(ByVal Value As String)
                mTen_nha = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
