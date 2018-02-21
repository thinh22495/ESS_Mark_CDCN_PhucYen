'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, June 01, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSKhenThuong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_khen_thuong As Integer = 0
        Private mSo_QD As String = ""
        Private mNgay_QD As Date
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_loai_kt As Integer = 0
        Private mHinh_thuc As String = ""
        Private mTen_cap As String = ""
        Private mID_cap As Integer = 0
#End Region

#Region "Property"
        Public Property ID_khen_thuong() As Integer
            Get
                Return mID_khen_thuong
            End Get
            Set(ByVal Value As Integer)
                mID_khen_thuong = Value
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
        Public Property So_QD() As String
            Get
                Return mSo_QD
            End Get
            Set(ByVal Value As String)
                mSo_QD = Value
            End Set
        End Property
        Public Property Ngay_QD() As Date
            Get
                Return mNgay_QD
            End Get
            Set(ByVal Value As Date)
                mNgay_QD = Value
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
        Public Property ID_loai_kt() As Integer
            Get
                Return mID_loai_kt
            End Get
            Set(ByVal Value As Integer)
                mID_loai_kt = Value
            End Set
        End Property
        Public Property Hinh_thuc() As String
            Get
                Return mHinh_thuc
            End Get
            Set(ByVal Value As String)
                mHinh_thuc = Value
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
#End Region

    End Class
End Namespace
