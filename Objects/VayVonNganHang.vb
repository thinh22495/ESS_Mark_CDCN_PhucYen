Imports System
Namespace Objects
    Public Class ESSVayVonNganHang

#Region "Initialize"
#End Region

#Region "Var"
        Private mID_vay_von As Integer = 0
        Private mID_sv As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mSo_tien As Integer = 0
        Private mNgay_vay As Date
        Private mID_Ngan_hang As Integer = 0
#End Region


#Region "Property"
        Public Property ID_vay_von() As Integer
            Get
                Return mID_vay_von
            End Get
            Set(ByVal Value As Integer)
                mID_vay_von = Value
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
        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
            End Set
        End Property
        Public Property Ngay_vay() As Date
            Get
                Return mNgay_vay
            End Get
            Set(ByVal Value As Date)
                mNgay_vay = Value
            End Set
        End Property
        Public Property ID_Ngan_hang() As Integer
            Get
                Return mID_Ngan_hang
            End Get
            Set(ByVal Value As Integer)
                mID_Ngan_hang = Value
            End Set
        End Property
#End Region

    End Class
End Namespace

