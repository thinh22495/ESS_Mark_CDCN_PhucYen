'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, 05 June, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiemRenLuyen
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_diem_rl As Integer = 0
        Private mDiem As Integer = 0
        Private mID_loai_rl As Integer = 0
        Private mTen_loai As String = ""
        Private mDiemLoairl As Integer = 0
        Private mID_cap_rl As Integer = 0
        Private mTen_cap As String = ""
        Private mDiemCaprl As Integer = 0
        Private mLocked As Boolean = False
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
        Public Property ID_diem_rl() As Integer
            Get
                Return mID_diem_rl
            End Get
            Set(ByVal Value As Integer)
                mID_diem_rl = Value
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
        Public Property ID_loai_rl() As Integer
            Get
                Return mID_loai_rl
            End Get
            Set(ByVal Value As Integer)
                mID_loai_rl = Value
            End Set
        End Property
        Public Property Ten_loai() As String
            Get
                Return mTen_loai
            End Get
            Set(ByVal Value As String)
                mTen_loai = Value
            End Set
        End Property
        Public Property DiemLoairl() As Integer
            Get
                Return mDiemLoairl
            End Get
            Set(ByVal Value As Integer)
                mDiemLoairl = Value
            End Set
        End Property
        Public Property ID_cap_rl() As Integer
            Get
                Return mID_cap_rl
            End Get
            Set(ByVal Value As Integer)
                mID_cap_rl = Value
            End Set
        End Property
        Public Property Ten_cap() As String
            Get
                Return mTen_cap
            End Get
            Set(ByVal Value As String)
                mTen_cap = Value
            End Set
        End Property
        Public Property DiemCaprl() As Integer
            Get
                Return mDiemCaprl
            End Get
            Set(ByVal Value As Integer)
                mDiemCaprl = Value
            End Set
        End Property

        Public Property Locked() As Boolean
            Get
                Return mLocked
            End Get
            Set(ByVal Value As Boolean)
                mLocked = Value
            End Set
        End Property


#End Region

    End Class
End Namespace
