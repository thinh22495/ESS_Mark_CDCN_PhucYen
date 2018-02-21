Imports System
Namespace Objects
    Public Class ESSToChucThiDangKyCaiThienDiem
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_mon As Integer = 0
        Private mDuyet As Integer = 0
        Private mHinh_thuc As Integer = 0 ' 0: Cải thiện ; 1: Thi lại
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
        Public Property ID_mon() As Integer
            Get
                Return mID_mon
            End Get
            Set(ByVal Value As Integer)
                mID_mon = Value
            End Set
        End Property

        Public Property Hinh_thuc() As Integer
            Get
                Return mHinh_thuc
            End Get
            Set(ByVal Value As Integer)
                mHinh_thuc = Value
            End Set
        End Property

        Public Property Duyet() As Integer
            Get
                Return mDuyet
            End Get
            Set(ByVal Value As Integer)
                mDuyet = Value
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

#End Region

    End Class
End Namespace

