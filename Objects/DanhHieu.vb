'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 10, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhHieu
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_danh_hieu As Integer = 0
        Private mDanh_hieu As String = ""
        Private mTu_diem As Integer = 0
        Private mDen_diem As Integer = 0
#End Region

#Region "Property"
        Public Property ID_danh_hieu() As Integer
            Get
                Return mID_danh_hieu
            End Get
            Set(ByVal Value As Integer)
                mID_danh_hieu = Value
            End Set
        End Property
        Public Property Danh_hieu() As String
            Get
                Return mDanh_hieu
            End Get
            Set(ByVal Value As String)
                mDanh_hieu = Value
            End Set
        End Property
        Public Property Tu_diem() As Integer
            Get
                Return mTu_diem
            End Get
            Set(ByVal Value As Integer)
                mTu_diem = Value
            End Set
        End Property
        Public Property Den_diem() As Integer
            Get
                Return mDen_diem
            End Get
            Set(ByVal Value As Integer)
                mDen_diem = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
