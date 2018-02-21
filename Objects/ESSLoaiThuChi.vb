'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, August 29, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSLoaiThuChi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_thu_chi As Integer = 0
        Private mTen_thu_chi As String = ""
        Private mThu_chi As Boolean = 0
        Private mSo_tien As Integer
        Private mThu_bat_buoc As Boolean = 0
        Private mTheo_nien_khoa As Boolean = 0
        Private mHoc_phi As Boolean = 0
#End Region

#Region "Property"
        Public Property ID_thu_chi() As Integer
            Get
                Return mID_thu_chi
            End Get
            Set(ByVal Value As Integer)
                mID_thu_chi = Value
            End Set
        End Property
        Public Property Ten_thu_chi() As String
            Get
                Return mTen_thu_chi
            End Get
            Set(ByVal Value As String)
                mTen_thu_chi = Value
            End Set
        End Property
        Public Property Thu_chi() As Boolean
            Get
                Return mThu_chi
            End Get
            Set(ByVal Value As Boolean)
                mThu_chi = Value
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
        Public Property Thu_bat_buoc() As Boolean
            Get
                Return mThu_bat_buoc
            End Get
            Set(ByVal Value As Boolean)
                mThu_bat_buoc = Value
            End Set
        End Property
        Public Property Theo_nien_khoa() As Boolean
            Get
                Return mTheo_nien_khoa
            End Get
            Set(ByVal Value As Boolean)
                mTheo_nien_khoa = Value
            End Set
        End Property
        Public Property Hoc_phi() As Boolean
            Get
                Return mHoc_phi
            End Get
            Set(ByVal Value As Boolean)
                mHoc_phi = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
