'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, July 11, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhHieuThiDuaTapThe
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_lop As Integer = 0
        Private mID_danh_hieu As Integer = 0
        Private mLy_do As String = ""
        Private mID_cap As Integer = 0
#End Region

#Region "Property"
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property ID_lop() As Integer
            Get
                Return mID_lop
            End Get
            Set(ByVal Value As Integer)
                mID_lop = Value
            End Set
        End Property
        Public Property ID_danh_hieu() As Integer
            Get
                Return mID_danh_hieu
            End Get
            Set(ByVal Value As Integer)
                mID_danh_hieu = Value
            End Set
        End Property
        Public Property ID_cap() As Integer
            Get
                Return mID_cap
            End Get
            Set(ByVal Value As Integer)
                mID_cap = Value
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
