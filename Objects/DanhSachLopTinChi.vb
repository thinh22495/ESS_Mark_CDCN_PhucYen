'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, August 10, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhSachLopTinChi
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID As Integer = 0
        Private mID_lop_tc As Integer = 0
        Private mHoc_lai As Integer = 0
        Private mHuy_dang_ky As Boolean = 0
        Private mRut_bot_hoc_phan As Boolean = 0
        Private mChuyen_nganh2 As Boolean = 0
        Private mLy_do As String = ""
#End Region

#Region "Property"
        Public Property ID() As Integer
            Get
                Return mID
            End Get
            Set(ByVal Value As Integer)
                mID = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return mID_lop_tc
            End Get
            Set(ByVal Value As Integer)
                mID_lop_tc = Value
            End Set
        End Property
        Public Property Hoc_lai() As Integer
            Get
                Return mHoc_lai
            End Get
            Set(ByVal Value As Integer)
                mHoc_lai = Value
            End Set
        End Property
        Public Property Huy_dang_ky() As Boolean
            Get
                Return mHuy_dang_ky
            End Get
            Set(ByVal Value As Boolean)
                mHuy_dang_ky = Value
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

        Public Property Rut_bot_hoc_phan() As Boolean
            Get
                Return mRut_bot_hoc_phan
            End Get
            Set(ByVal Value As Boolean)
                mRut_bot_hoc_phan = Value
            End Set
        End Property

        Public Property Chuyen_nganh2() As Boolean
            Get
                Return mChuyen_nganh2
            End Get
            Set(ByVal Value As Boolean)
                mChuyen_nganh2 = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
