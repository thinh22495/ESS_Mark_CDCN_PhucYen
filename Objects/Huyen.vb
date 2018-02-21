'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class Huyen
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_huyen As Integer = 0
        Private mID_tinh As String = ""
        Private mTen_huyen As String = ""
#End Region

#Region "Property"
        Public Property ID_huyen() As Integer
            Get
                Return mID_huyen
            End Get
            Set(ByVal Value As Integer)
                mID_huyen = Value
            End Set
        End Property
        Public Property ID_tinh() As String
            Get
                Return mID_tinh
            End Get
            Set(ByVal Value As String)
                mID_tinh = Value
            End Set
        End Property
        Public Property Ten_huyen() As String
            Get
                Return mTen_huyen
            End Get
            Set(ByVal Value As String)
                mTen_huyen = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
