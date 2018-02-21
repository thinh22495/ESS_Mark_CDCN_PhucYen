'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class KhuVuc
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_kv As Integer = 0
        Private mMa_kv As String = ""
        Private mTen_kv As String = ""
#End Region

#Region "Property"
        Public Property ID_kv() As Integer
            Get
                Return mID_kv
            End Get
            Set(ByVal Value As Integer)
                mID_kv = Value
            End Set
        End Property
        Public Property Ma_kv() As String
            Get
                Return mMa_kv
            End Get
            Set(ByVal Value As String)
                mMa_kv = Value
            End Set
        End Property
        Public Property Ten_kv() As String
            Get
                Return mTen_kv
            End Get
            Set(ByVal Value As String)
                mTen_kv = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
