'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSQuyHocBong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_hb As Integer = 0
        Private mID_quy As Integer = 0
        Private mID_he As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mTu_khoa As Integer = 0
        Private mDen_khoa As Integer = 0
        Private mSotien_ngansach As Double
        Private mSotien_khac As Double
        Private mGhi_chu As String = ""
        Private mLoai_quy As String = ""
#End Region

#Region "Property"
        Public Property ID_hb() As Integer
            Get
                Return mID_hb
            End Get
            Set(ByVal Value As Integer)
                mID_hb = Value
            End Set
        End Property
        Public Property ID_quy() As Integer
            Get
                Return mID_quy
            End Get
            Set(ByVal Value As Integer)
                mID_quy = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
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
        Public Property Tu_khoa() As Integer
            Get
                Return mTu_khoa
            End Get
            Set(ByVal Value As Integer)
                mTu_khoa = Value
            End Set
        End Property
        Public Property Den_khoa() As Integer
            Get
                Return mDen_khoa
            End Get
            Set(ByVal Value As Integer)
                mDen_khoa = Value
            End Set
        End Property
        Public Property Sotien_ngansach() As Double
            Get
                Return mSotien_ngansach
            End Get
            Set(ByVal Value As Double)
                mSotien_ngansach = Value
            End Set
        End Property
        Public Property Sotien_khac() As Double
            Get
                Return mSotien_khac
            End Get
            Set(ByVal Value As Double)
                mSotien_khac = Value
            End Set
        End Property
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
        Public Property Loai_quy() As String
            Get
                Return mLoai_quy
            End Get
            Set(ByVal Value As String)
                mLoai_quy = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
