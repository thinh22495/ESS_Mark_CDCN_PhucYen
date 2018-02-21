Imports System
Namespace Objects
    Public Class ESSDiemKhongDuDieuKienThi
#Region "Constructor"
#End Region

#Region "Var"
        Private mHoc_ky_DD As Integer = 0
        Private mNam_hoc_DD As String = ""
        Private mKhong_du_dieu_kien_thi As Integer = 0
        Private mLy_do_khong_du_dieu_kien_thi As String = ""
        Private mDiemKDDKThi As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal kddkThi As ESSDiemKhongDuDieuKienThi)
            mDiemKDDKThi.Add(kddkThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemKDDKThi.RemoveAt(idx)
        End Sub
        Public Function Khong_du_dieu_kien_thi_lan(ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            For i As Integer = 0 To mDiemKDDKThi.Count - 1
                If CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Hoc_ky_DD = Hoc_ky_DD And CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Nam_hoc_DD = Nam_hoc_DD Then
                    Return CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Khong_du_dieu_kien_thi
                End If
            Next
            Return 0
        End Function
        Public Function Ly_do_khong_du_dieu_kien_thi_lan(ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As String
            For i As Integer = 0 To mDiemKDDKThi.Count - 1
                If CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Hoc_ky_DD = Hoc_ky_DD And CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Nam_hoc_DD = Nam_hoc_DD Then
                    Return CType(mDiemKDDKThi(i), ESSDiemKhongDuDieuKienThi).Ly_do_khong_du_dieu_kien_thi
                End If
            Next
            Return ""
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemKDDKThi.Count
            End Get
        End Property
        Public Property Khong_du_dieu_kien_thi() As Integer
            Get
                Return mKhong_du_dieu_kien_thi
            End Get
            Set(ByVal Value As Integer)
                mKhong_du_dieu_kien_thi = Value
            End Set
        End Property
        Public Property Ly_do_khong_du_dieu_kien_thi() As String
            Get
                Return mLy_do_khong_du_dieu_kien_thi
            End Get
            Set(ByVal Value As String)
                mLy_do_khong_du_dieu_kien_thi = Value
            End Set
        End Property

        Public Property Hoc_ky_DD() As Integer
            Get
                Return mHoc_ky_DD
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky_DD = Value
            End Set
        End Property
        Public Property Nam_hoc_DD() As String
            Get
                Return mNam_hoc_DD
            End Get
            Set(ByVal Value As String)
                mNam_hoc_DD = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
