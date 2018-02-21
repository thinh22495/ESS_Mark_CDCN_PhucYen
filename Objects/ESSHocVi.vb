'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, June 07, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHocVi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_hoc_vi As Integer = 0
        Private mMa_hoc_vi As String = ""
        Private mHoc_vi As String = ""
#End Region

#Region "Property"
        Public Property ID_hoc_vi() As Integer
            Get
                Return mID_hoc_vi
            End Get
            Set(ByVal Value As Integer)
                mID_hoc_vi = Value
            End Set
        End Property
        Public Property Ma_hoc_vi() As String
            Get
                Return mMa_hoc_vi
            End Get
            Set(ByVal Value As String)
                mMa_hoc_vi = Value
            End Set
        End Property
        Public Property Hoc_vi() As String
            Get
                Return mHoc_vi
            End Get
            Set(ByVal Value As String)
                mHoc_vi = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
