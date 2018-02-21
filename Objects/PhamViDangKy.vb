'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, July 21, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSPhamViDangKy
#Region "Initialize"
        Sub New()
            mPhamViDangKy = New ArrayList
        End Sub
#End Region

#Region "Var"
        Private mID_mon_tc As Integer = 0
        Private mID_he As Integer = 0
        Private mTen_he As String = 0
        Private mID_khoa As Integer = 0
        Private mTen_khoa As String = 0
        Private mKhoa_hoc As Integer = 0
        Private mID_nganh As Integer = 0
        Private mID_chuyen_nganh As Integer = 0
        Private mPhamViDangKy As ArrayList
#End Region
#Region "Functions"
        Public Sub Add(ByVal dk As ESSPhamViDangKy)
            mPhamViDangKy.Add(dk)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mPhamViDangKy.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_mon_tc As Integer) As Integer
            For i As Integer = 0 To mPhamViDangKy.Count - 1
                If CType(mPhamViDangKy(i), ESSPhamViDangKy).ID_mon_tc = ID_mon_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mPhamViDangKy.Count
            End Get
        End Property
        Public Property ESSPhamViDangKy(ByVal idx As Integer) As ESSPhamViDangKy
            Get
                Return CType(mPhamViDangKy(idx), ESSPhamViDangKy)
            End Get
            Set(ByVal Value As ESSPhamViDangKy)
                mPhamViDangKy(idx) = Value
            End Set
        End Property
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
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
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
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
        Public Property Ten_khoa() As String
            Get
                Return mTen_khoa
            End Get
            Set(ByVal Value As String)
                mTen_khoa = Value
            End Set
        End Property
        Public Property Khoa_hoc() As Integer
            Get
                Return mKhoa_hoc
            End Get
            Set(ByVal Value As Integer)
                mKhoa_hoc = Value
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
        Public Property ID_chuyen_nganh() As Integer
            Get
                Return mID_chuyen_nganh
            End Get
            Set(ByVal Value As Integer)
                mID_chuyen_nganh = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
