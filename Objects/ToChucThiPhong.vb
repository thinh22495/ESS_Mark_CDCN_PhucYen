'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, June 06, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSToChucThiPhong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_phong_thi As Integer = 0
        Private mID_thi As Integer = 0
        Private mID_lop_tc As Integer = 0
        Private mID_phong As Integer = 0
        Private mTen_phong As String = ""
        Private mSo_sv As Integer = 0
        'Private mGio_thi As String = ""
        Private mTochucThiPhong As New ArrayList

        Private mNhom_tiet_phong As Integer = 0
        Private mCa_thi_Phong As Integer = 0
        Private mNgay_thi_Phong As Date
        Private mGio_thi_Phong As String = ""

#End Region
        Public Sub Add(ByVal PhongThi As ESSToChucThiPhong)
            mTochucThiPhong.Add(PhongThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mTochucThiPhong.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal Ten_phong As String) As Integer
            For i As Integer = 0 To mTochucThiPhong.Count - 1
                If CType(mTochucThiPhong(i), ESSToChucThiPhong).Ten_phong = Ten_phong Then
                    Return i
                End If
            Next
            Return -1
        End Function
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mTochucThiPhong.Count
            End Get
        End Property
        Public Property ESSToChucThiPhong(ByVal idx As Integer) As ESSToChucThiPhong
            Get
                Return CType(mTochucThiPhong(idx), ESSToChucThiPhong)
            End Get
            Set(ByVal Value As ESSToChucThiPhong)
                mTochucThiPhong(idx) = Value
            End Set
        End Property

        Public Property ID_phong_thi() As Integer
            Get
                Return mID_phong_thi
            End Get
            Set(ByVal Value As Integer)
                mID_phong_thi = Value
            End Set
        End Property
        Public Property ID_thi() As Integer
            Get
                Return mID_thi
            End Get
            Set(ByVal Value As Integer)
                mID_thi = Value
            End Set
        End Property
        Public Property ID_phong() As Integer
            Get
                Return mID_phong
            End Get
            Set(ByVal Value As Integer)
                mID_phong = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
        Public Property ID_lop_tc() As Integer
            Get
                Return mID_lop_tc
            End Get
            Set(ByVal Value As Integer)
                mID_lop_tc = Value
            End Set
        End Property
        Public Property Gio_thi_Phong() As String
            Get
                Return mGio_thi_Phong
            End Get
            Set(ByVal Value As String)
                mGio_thi_Phong = Value
            End Set
        End Property
        Public Property Ngay_thi_Phong() As Date
            Get
                Return mNgay_thi_Phong
            End Get
            Set(ByVal Value As Date)
                mNgay_thi_Phong = Value
            End Set
        End Property
        Public Property Nhom_tiet_phong() As Integer
            Get
                Return mNhom_tiet_phong
            End Get
            Set(ByVal Value As Integer)
                mNhom_tiet_phong = Value
            End Set
        End Property
        Public Property Ca_thi_Phong() As Integer
            Get
                Return mCa_thi_Phong
            End Get
            Set(ByVal Value As Integer)
                mCa_thi_Phong = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
