'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 30, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSLoaiPhong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_loai_phong As Integer = 0
        Private mMa_loai As String = ""
        Private mTen_loai_phong As String = ""
        Private mThuc_hanh As Boolean = 0
#End Region

#Region "Property"
        Public Property ID_loai_phong() As Integer
            Get
                Return mID_loai_phong
            End Get
            Set(ByVal Value As Integer)
                mID_loai_phong = Value
            End Set
        End Property
        Public Property Ma_loai() As String
            Get
                Return mMa_loai
            End Get
            Set(ByVal Value As String)
                mMa_loai = Value
            End Set
        End Property
        Public Property Ten_loai_phong() As String
            Get
                Return mTen_loai_phong
            End Get
            Set(ByVal Value As String)
                mTen_loai_phong = Value
            End Set
        End Property
        Public Property Thuc_hanh() As Boolean
            Get
                Return mThuc_hanh
            End Get
            Set(ByVal Value As Boolean)
                mThuc_hanh = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
