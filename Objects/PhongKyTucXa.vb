
'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/25/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSPhongKyTucXa
#Region "Initialize"
        Public Sub New()
        End Sub

#End Region

#Region "Var"
        Private mID_phong_ktx As Integer = 0
        Private mID_nha_ktx As Integer = 0
        Private mID_tang As Integer = 0
        Private mSo_phong_ktx As String = ""
        Private mTen_phong As String = ""
        Private mSuc_chua As Integer = 0
        Private mThiet_bi As String = ""
        Private mTen_nha As String = ""
        Private mTen_tang As String = ""
        Private mID_co_so As Integer = 0
        Private mTen_co_so As String = ""
#End Region

#Region "Property"

        Public Property ID_phong_ktx() As Integer
            Get
                Return mID_phong_ktx
            End Get
            Set(ByVal Value As Integer)
                mID_phong_ktx = Value
            End Set
        End Property
        Public Property ID_nha_ktx() As Integer
            Get
                Return mID_nha_ktx
            End Get
            Set(ByVal Value As Integer)
                mID_nha_ktx = Value
            End Set
        End Property
        Public Property ID_tang() As Integer
            Get
                Return mID_tang
            End Get
            Set(ByVal Value As Integer)
                mID_tang = Value
            End Set
        End Property
        Public Property So_phong_ktx() As String
            Get
                Return mSo_phong_ktx
            End Get
            Set(ByVal Value As String)
                mSo_phong_ktx = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property
        Public Property Suc_chua() As Integer
            Get
                Return mSuc_chua
            End Get
            Set(ByVal Value As Integer)
                mSuc_chua = Value
            End Set
        End Property

        Public Property Thiet_bi() As String
            Get
                Return mThiet_bi
            End Get
            Set(ByVal Value As String)
                mThiet_bi = Value
            End Set
        End Property
        Public Property Ten_nha() As String
            Get
                Return mTen_nha
            End Get
            Set(ByVal Value As String)
                mTen_nha = Value
            End Set
        End Property
        Public Property Ten_tang() As String
            Get
                Return mTen_tang
            End Get
            Set(ByVal Value As String)
                mTen_tang = Value
            End Set
        End Property

        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal Value As Integer)
                mID_co_so = Value
            End Set
        End Property
        Public Property Ten_co_so() As String
            Get
                Return mTen_co_so
            End Get
            Set(ByVal Value As String)
                mTen_co_so = Value
            End Set
        End Property


#End Region
    End Class
End Namespace
