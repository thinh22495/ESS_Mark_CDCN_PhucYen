'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, July 11, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhHieuThiDuaCaNhan
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTBCHT As Double = 0
        Private mDRL As Double = 0
        Private mTBCMR As Double = 0
        Private mID_danh_hieu As Integer = 0
#End Region

#Region "Property"
        Public Overloads Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
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
        Public Property TBCHT() As Double
            Get
                Return mTBCHT
            End Get
            Set(ByVal Value As Double)
                mTBCHT = Value
            End Set
        End Property
        Public Property DRL() As Double
            Get
                Return mDRL
            End Get
            Set(ByVal Value As Double)
                mDRL = Value
            End Set
        End Property
        Public Property TBCMR() As Double
            Get
                Return mTBCMR
            End Get
            Set(ByVal Value As Double)
                mTBCMR = Value
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
#End Region

    End Class
End Namespace
