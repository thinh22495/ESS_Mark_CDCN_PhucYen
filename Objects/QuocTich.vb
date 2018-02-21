'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Monday, April 21, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class QuocTich
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_quoc_tich As Integer = 0
        Private mMa_quoc_tich As String = ""
        Private mQuoc_tich As String = ""
#End Region

#Region "Property"
        Public Property ID_quoc_tich() As Integer
            Get
                Return mID_quoc_tich
            End Get
            Set(ByVal Value As Integer)
                mID_quoc_tich = Value
            End Set
        End Property
        Public Property Ma_quoc_tich() As String
            Get
                Return mMa_quoc_tich
            End Get
            Set(ByVal Value As String)
                mMa_quoc_tich = Value
            End Set
        End Property
        Public Property Quoc_tich() As String
            Get
                Return mQuoc_tich
            End Get
            Set(ByVal Value As String)
                mQuoc_tich = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
