'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Sunday, 25 May, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSNoiNgoaiTru
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mTu_ngay As Date = Nothing
        Private mDen_ngay As Object
        Private mID_phong_ktx As Integer = 0
        Private mSo_phong_KTX As String = ""
        Private mID_nha_KTX As Integer = 0
        Private mTen_nha As String = ""
        Private mID_tang As Integer = 0
        Private mTen_tang As String = ""
        Private mDia_chi As String = ""
        Private mDien_thoai As String = ""
        Private mTen_chu_ho As String = ""
        Private mGhi_chu As String = ""
        Private mNoi_o As String = ""
        Private mTrang_thai As Integer = -1
        Private mID_phuong As Integer = 0
        Private mTen_phuong As String = ""
#End Region

#Region "Property"

        Public Property Tu_ngay() As Date
            Get
                Return mTu_ngay
            End Get
            Set(ByVal Value As Date)
                mTu_ngay = Value
            End Set
        End Property
        Public Property Den_ngay() As Object
            Get
                Return mDen_ngay
            End Get
            Set(ByVal Value As Object)
                mDen_ngay = Value
            End Set
        End Property
        Public Property ID_phong_ktx() As Integer
            Get
                Return mID_phong_ktx
            End Get
            Set(ByVal Value As Integer)
                mID_phong_ktx = Value
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
        Public Property ID_nha_KTX() As Integer
            Get
                Return mID_nha_KTX
            End Get
            Set(ByVal Value As Integer)
                mID_nha_KTX = Value
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
        Public Property ID_tang() As Integer
            Get
                Return mID_tang
            End Get
            Set(ByVal Value As Integer)
                mID_tang = Value
            End Set
        End Property
        Public Property So_phong_KTX() As String
            Get
                Return mSo_phong_KTX
            End Get
            Set(ByVal Value As String)
                mSo_phong_KTX = Value
            End Set
        End Property
        Public Property Dia_chi() As String
            Get
                Return mDia_chi
            End Get
            Set(ByVal Value As String)
                mDia_chi = Value
            End Set
        End Property
        Public Property Dien_thoai() As String
            Get
                Return mDien_thoai
            End Get
            Set(ByVal Value As String)
                mDien_thoai = Value
            End Set
        End Property
        Public Property Ten_chu_ho() As String
            Get
                Return mTen_chu_ho
            End Get
            Set(ByVal Value As String)
                mTen_chu_ho = Value
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
        Public Property Noi_o() As String
            Get
                Return mNoi_o
            End Get
            Set(ByVal Value As String)
                mNoi_o = Value
            End Set
        End Property
        Public Property Trang_thai() As Integer
            Get
                Return mTrang_thai
            End Get
            Set(ByVal Value As Integer)
                mTrang_thai = Value
            End Set
        End Property
        Public Property ID_phuong() As Integer
            Get
                Return mID_phuong
            End Get
            Set(ByVal Value As Integer)
                mID_phuong = Value
            End Set
        End Property
        Public Property Ten_phuong() As String
            Get
                Return mTen_phuong
            End Get
            Set(ByVal Value As String)
                mTen_phuong = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
