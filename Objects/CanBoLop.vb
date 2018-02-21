'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, May 29, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSCanBoLop
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_sv As Integer = 0
        Private mNam_bat_dau As Integer = 0
        Private mID_chuc_danh As Integer = 0
        Private mChuc_danh_kiem As String = ""
        Private mChuc_danh As String = ""
        Private mNam_ket_thuc As Integer = 0
        Private mMa_sv As String = ""
        Private mHo_ten As String = ""
        Private mNgay_sinh As Date
        Private mGioi_tinh As String = ""
        Private mTen_lop As String = ""
#End Region

#Region "Property"
        Public Property ID_sv() As Integer
            Get
                Return mID_sv
            End Get
            Set(ByVal Value As Integer)
                mID_sv = Value
            End Set
        End Property
        Public Property Nam_bat_dau() As Integer
            Get
                Return mNam_bat_dau
            End Get
            Set(ByVal Value As Integer)
                mNam_bat_dau = Value
            End Set
        End Property
        Public Property ID_chuc_danh() As Integer
            Get
                Return mID_chuc_danh
            End Get
            Set(ByVal Value As Integer)
                mID_chuc_danh = Value
            End Set
        End Property
        Public Property Chuc_danh() As String
            Get
                Return mChuc_danh
            End Get
            Set(ByVal Value As String)
                mChuc_danh = Value
            End Set
        End Property
        Public Property Chuc_danh_kiem() As String
            Get
                Return mChuc_danh_kiem
            End Get
            Set(ByVal Value As String)
                mChuc_danh_kiem = Value
            End Set
        End Property
        Public Property Nam_ket_thuc() As Integer
            Get
                Return mNam_ket_thuc
            End Get
            Set(ByVal Value As Integer)
                mNam_ket_thuc = Value
            End Set
        End Property
        Public Property Ma_sv() As String
            Get
                Return mMa_sv
            End Get
            Set(ByVal Value As String)
                mMa_sv = Value
            End Set
        End Property
        Public Property Ho_ten() As String
            Get
                Return mHo_ten
            End Get
            Set(ByVal Value As String)
                mHo_ten = Value
            End Set
        End Property
        Public Property Ngay_sinh() As Date
            Get
                Return mNgay_sinh
            End Get
            Set(ByVal Value As Date)
                mNgay_sinh = Value
            End Set
        End Property
        Public Property Gioi_tinh() As String
            Get
                Return mGioi_tinh
            End Get
            Set(ByVal Value As String)
                mGioi_tinh = Value
            End Set
        End Property
        Public Property Ten_lop() As String
            Get
                Return mTen_lop
            End Get
            Set(ByVal Value As String)
                mTen_lop = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
