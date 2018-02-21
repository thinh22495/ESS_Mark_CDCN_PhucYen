'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSThanhPhanXuatThan
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_thanh_phan As Integer = 0
        Private mTen_thanh_phan As String = ""
#End Region

#Region "Property"
        Public Property ID_thanh_phan() As Integer
            Get
                Return mID_thanh_phan
            End Get
            Set(ByVal Value As Integer)
                mID_thanh_phan = Value
            End Set
        End Property
        Public Property Ten_thanh_phan() As String
            Get
                Return mTen_thanh_phan
            End Get
            Set(ByVal Value As String)
                mTen_thanh_phan = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
