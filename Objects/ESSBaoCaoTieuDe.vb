'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, June 21, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSBaoCaoTieuDe
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_dv As String = ""
        Private mUserID As Integer = 0
        Private mTieu_de_ten_bo As String = ""
        Private mTieu_de_Ten_truong As String = ""
        Private mTieu_de_chuc_danh1 As String = ""
        Private mTieu_de_chuc_danh2 As String = ""
        Private mTieu_de_chuc_danh3 As String = ""
        Private mTieu_de_chuc_danh4 As String = ""
        Private mTieu_de_nguoi_ky1 As String = ""
        Private mTieu_de_nguoi_ky2 As String = ""
        Private mTieu_de_nguoi_ky3 As String = ""
        Private mTieu_de_nguoi_ky4 As String = ""
        Private mTieu_de_noi_ky As String = ""
#End Region

#Region "Property"
        Public Property ID_dv() As String
            Get
                Return mID_dv
            End Get
            Set(ByVal Value As String)
                mID_dv = Value
            End Set
        End Property

        Public Property UserID() As Integer
            Get
                Return mUserID
            End Get
            Set(ByVal value As Integer)
                mUserID = value
            End Set
        End Property
        Public Property Tieu_de_ten_bo() As String
            Get
                Return mTieu_de_ten_bo
            End Get
            Set(ByVal Value As String)
                mTieu_de_ten_bo = Value
            End Set
        End Property
        Public Property Tieu_de_Ten_truong() As String
            Get
                Return mTieu_de_Ten_truong
            End Get
            Set(ByVal Value As String)
                mTieu_de_Ten_truong = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh1() As String
            Get
                Return mTieu_de_chuc_danh1
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh1 = Value
            End Set
        End Property

        Public Property Tieu_de_chuc_danh2() As String
            Get
                Return mTieu_de_chuc_danh2
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh2 = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh3() As String
            Get
                Return mTieu_de_chuc_danh3
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh3 = Value
            End Set
        End Property
        Public Property Tieu_de_chuc_danh4() As String
            Get
                Return mTieu_de_chuc_danh4
            End Get
            Set(ByVal Value As String)
                mTieu_de_chuc_danh4 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky1() As String
            Get
                Return mTieu_de_nguoi_ky1
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky1 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky2() As String
            Get
                Return mTieu_de_nguoi_ky2
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky2 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky3() As String
            Get
                Return mTieu_de_nguoi_ky3
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky3 = Value
            End Set
        End Property
        Public Property Tieu_de_nguoi_ky4() As String
            Get
                Return mTieu_de_nguoi_ky4
            End Get
            Set(ByVal Value As String)
                mTieu_de_nguoi_ky4 = Value
            End Set
        End Property
        Public Property Tieu_de_noi_ky() As String
            Get
                Return mTieu_de_noi_ky
            End Get
            Set(ByVal Value As String)
                mTieu_de_noi_ky = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
