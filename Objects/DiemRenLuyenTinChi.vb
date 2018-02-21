'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, November 03, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiemRenLuyenTinChi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_diem_rl As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_sv As Integer = 0
        Private mID_mon_tc As Integer = 0
        Private mDiem As Integer = 0
#End Region

#Region "Property"
        Public Property ID_diem_rl() As Integer
            Get
                Return mID_diem_rl
            End Get
            Set(ByVal Value As Integer)
                mID_diem_rl = Value
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
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
            End Set
        End Property
        Public Property Diem() As Integer
            Get
                Return mDiem
            End Get
            Set(ByVal Value As Integer)
                mDiem = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
