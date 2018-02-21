'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, June 07, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSChucVu
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_chuc_vu As Integer = 0
        Private mMa_chuc_vu As String = ""
        Private mChuc_vu As String = ""
#End Region

#Region "Property"
        Public Property ID_chuc_vu() As Integer
            Get
                Return mID_chuc_vu
            End Get
            Set(ByVal Value As Integer)
                mID_chuc_vu = Value
            End Set
        End Property
        Public Property Ma_chuc_vu() As String
            Get
                Return mMa_chuc_vu
            End Get
            Set(ByVal Value As String)
                mMa_chuc_vu = Value
            End Set
        End Property
        Public Property Chuc_vu() As String
            Get
                Return mChuc_vu
            End Get
            Set(ByVal Value As String)
                mChuc_vu = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
