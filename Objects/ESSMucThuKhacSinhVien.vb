'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSMucThuKhacSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_sv As Integer = 0
        Private mID_thu_chi As Integer = 0
        Private mTen_thu_chi As String = ""
        Private mSo_tien As Integer = 0
        Private mGhi_chu As String = ""
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
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
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
        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
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
        Public Property Ten_thu_chi() As String
            Get
                Return mTen_thu_chi
            End Get
            Set(ByVal Value As String)
                mTen_thu_chi = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
