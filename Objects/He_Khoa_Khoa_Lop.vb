Imports System
Namespace Entity
    Public Class He_Khoa_Khoa_Lop
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_he As Integer = 0
        Private mTen_he As String = ""
        Private mID_chuyen_nganh As Integer = 0
        Private mChuyen_nganh As String = ""
        Private mTen_nganh As String = ""
        Private mID_nganh As Integer = 0
        Private mTen_co_so As String = ""
        Private mID_co_so As Integer = 0
        Private mTen_khoa As String = ""
        Private mID_khoa As Integer = 0
        Private mKhoa_hoc As Integer = 0
#End Region

#Region "Property"
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property Ten_he() As String
            Get
                Return mTen_he
            End Get
            Set(ByVal Value As String)
                mTen_he = Value
            End Set
        End Property
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
            End Set
        End Property
        Public Property Chuyen_nganh() As String
            Get
                Return mChuyen_nganh
            End Get
            Set(ByVal Value As String)
                mChuyen_nganh = Value
            End Set
        End Property
        Public Property Ten_nganh() As String
            Get
                Return mTen_nganh
            End Get
            Set(ByVal Value As String)
                mTen_nganh = Value
            End Set
        End Property
        Public Property ID_nganh() As Integer
            Get
                Return mID_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_nganh = Value
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
        Public Property ID_co_so() As Integer
            Get
                Return mID_co_so
            End Get
            Set(ByVal Value As Integer)
                mID_co_so = Value
            End Set
        End Property
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
        Public Property ID_khoa() As Integer
            Get
                Return mID_khoa
            End Get
            Set(ByVal Value As Integer)
                mID_khoa = Value
            End Set
        End Property

        Public Property Khoa_Hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
            End Set
        End Property
#End Region

    End Class
End Namespace