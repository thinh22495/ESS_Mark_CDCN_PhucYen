'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, August 21, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDuyetDangKySinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mKy_dang_ky As Integer = 0
        Private mID_sv As Integer = 0
        Private mDuyet As Boolean = 0
        Private mLy_do As String = 0
#End Region

#Region "Property"
        Public Property Ky_dang_ky() As Integer
            Get
                Return mKy_dang_ky
            End Get
            Set(ByVal Value As Integer)
                mKy_dang_ky = Value
            End Set
        End Property
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Duyet() As Boolean
            Get
                Return mDuyet
            End Get
            Set(ByVal Value As Boolean)
                mDuyet = Value
            End Set
        End Property
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
