Imports System
Namespace Objects
    Public Class DiemDanh
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_diem As Integer = 0
        Private mHoc_ky_DD As Integer = 0
        Private mNam_hoc_DD As String = ""
        Private mSo_tiet_nghi As Integer = 0
        Private mThieu_bai_thuc_hanh As Byte = 0
        Private mSo_tiet_nghi_co_phep As Integer = 0
        Private mSo_tiet_nghi_khong_phep As Integer = 0
        Private mHash_code As Integer = 0
        Private mLocked_dd As Integer = 0
        Private mGhi_chu As String = ""
        Private mDiemDanh As New ArrayList
#End Region
#Region "Function"
        Public Sub Add(ByVal dTP As DiemDanh)
            mDiemDanh.Add(dTP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemDanh.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_diem As Integer, ByVal Hoc_ky_DD As Integer, ByVal Nam_hoc_DD As String) As Integer
            For i As Integer = 0 To mDiemDanh.Count - 1
                If CType(mDiemDanh(i), DiemDanh).ID_diem = ID_diem And CType(mDiemDanh(i), DiemDanh).Hoc_ky_DD = Hoc_ky_DD And CType(mDiemDanh(i), DiemDanh).Nam_hoc_DD = Nam_hoc_DD Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemDanh.Count
            End Get
        End Property
        Public Property DiemDanh(ByVal idx As Integer) As DiemDanh
            Get
                Return CType(mDiemDanh(idx), DiemDanh)
            End Get
            Set(ByVal Value As DiemDanh)
                mDiemDanh(idx) = Value
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
        Public Property So_tiet_nghi_co_phep() As Double
            Get
                Return mSo_tiet_nghi_co_phep
            End Get
            Set(ByVal Value As Double)
                mSo_tiet_nghi_co_phep = Value
            End Set
        End Property
        Public Property So_tiet_nghi_khong_phep() As Double
            Get
                Return mSo_tiet_nghi_khong_phep
            End Get
            Set(ByVal Value As Double)
                mSo_tiet_nghi_khong_phep = Value
            End Set
        End Property
        Public Property Thieu_bai_thuc_hanh() As Byte
            Get
                Return mThieu_bai_thuc_hanh
            End Get
            Set(ByVal Value As Byte)
                mThieu_bai_thuc_hanh = Value
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
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked_dd() As Integer
            Get
                Return mLocked_dd
            End Get
            Set(ByVal Value As Integer)
                mLocked_dd = Value
            End Set
        End Property
        Public Property ID_diem() As Integer
            Get
                Return mID_diem
            End Get
            Set(ByVal Value As Integer)
                mID_diem = Value
            End Set
        End Property
#End Region
    End Class
End Namespace