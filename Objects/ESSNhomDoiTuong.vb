'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, April 22, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSNhomDoiTuong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_nhom_dt As Integer = 0
        Private mMa_nhom As String = ""
        Private mTen_nhom As String = ""
#End Region

#Region "Property"
        Public Property ID_nhom_dt() As Integer
            Get
                Return mID_nhom_dt
            End Get
            Set(ByVal Value As Integer)
                mID_nhom_dt = Value
            End Set
        End Property
        Public Property Ma_nhom() As String
            Get
                Return mMa_nhom
            End Get
            Set(ByVal Value As String)
                mMa_nhom = Value
            End Set
        End Property
        Public Property Ten_nhom() As String
            Get
                Return mTen_nhom
            End Get
            Set(ByVal Value As String)
                mTen_nhom = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
