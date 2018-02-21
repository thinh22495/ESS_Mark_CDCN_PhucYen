'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : 04/24/2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class BoMonMonHoc
        Inherits MonHoc

#Region "Constructor"

#End Region

#Region "Var"
        Private mID_bm As Integer = 0
#End Region

#Region "Property"
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
