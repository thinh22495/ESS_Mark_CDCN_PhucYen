'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, June 17, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class BienLaiThuChiTiet
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_bien_lai As Integer = 0
        Private mID_thu_chi As Integer = 0
        Private mDot_thu As Integer = 0
        Private mLan_thu As Integer = 0
        Private mNoi_dung As String = ""
        Private mSo_tien As Integer = 0
#End Region

#Region "Property"
        Public Property ID_bien_lai() As Integer
            Get
                Return mID_bien_lai
            End Get
            Set(ByVal Value As Integer)
                mID_bien_lai = Value
            End Set
        End Property
        Public Property ID_thu_chi() As Integer
            Get
                Return mID_thu_chi
            End Get
            Set(ByVal Value As Integer)
                mID_thu_chi = Value
            End Set
        End Property
        Public Property Dot_thu() As Integer
            Get
                Return mDot_thu
            End Get
            Set(ByVal Value As Integer)
                mDot_thu = Value
            End Set
        End Property
        Public Property Lan_thu() As Integer
            Get
                Return mLan_thu
            End Get
            Set(ByVal Value As Integer)
                mLan_thu = Value
            End Set
        End Property
        Public Property Noi_dung() As String
            Get
                Return mNoi_dung
            End Get
            Set(ByVal Value As String)
                mNoi_dung = Value
            End Set
        End Property
        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
