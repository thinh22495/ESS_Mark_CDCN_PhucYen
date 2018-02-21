'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, August 10, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHocKyDangKy
#Region "Initialize"
#End Region

#Region "Var"
        Private mKy_dang_ky As Integer = 0
        Private mDot As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTu_ngay As Date
        Private mDen_ngay As Date
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
        Public Property Dot() As Integer
            Get
                Return mDot
            End Get
            Set(ByVal Value As Integer)
                mDot = Value
            End Set
        End Property
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
        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Date
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Date)
                mDen_ngay = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
