'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, 11 June, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSHoatDongXaHoi
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_hd_xh As Integer = 0
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mNgay_thang As Date
        Private mNoi_dung As String = ""
        Private mKet_qua As String = ""
        Private mDiem_thuong As Integer = 0
#End Region

#Region "Property"
        Public Property ID_hd_xh() As Integer
            Get
                Return mID_hd_xh
            End Get
            Set(ByVal Value As Integer)
                mID_hd_xh = Value
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
        Public Property Ngay_thang() As Date
            Get
                Return mNgay_thang
            End Get
            Set(ByVal Value As Date)
                mNgay_thang = Value
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
        Public Property Ket_qua() As String
            Get
                Return mKet_qua
            End Get
            Set(ByVal Value As String)
                mKet_qua = Value
            End Set
        End Property
        Public Property Diem_thuong() As Integer
            Get
                Return mDiem_thuong
            End Get
            Set(ByVal Value As Integer)
                mDiem_thuong = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
