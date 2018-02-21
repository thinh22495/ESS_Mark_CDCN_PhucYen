'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, May 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSThanhPhanDiem
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_thanh_phan As Integer = 0
        Private mSTT As Integer = 0
        Private mKy_hieu As String = ""
        Private mTen_thanh_phan As String = ""
        Private mTy_le As Integer = 0
        Private mHe_so As Integer = 0
        Private mNhom As Integer = 0
        Private mChecked As Boolean = False
        Private mChuyen_can As Boolean = False
        Private mESSThanhPhanDiem As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal TP As ESSThanhPhanDiem)
            mESSThanhPhanDiem.Add(TP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mESSThanhPhanDiem.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_thanh_phan As Integer) As Integer
            For i As Integer = 0 To mESSThanhPhanDiem.Count - 1
                If CType(mESSThanhPhanDiem(i), ESSThanhPhanDiem).ID_thanh_phan = ID_thanh_phan Then
                    Return i
                End If
            Next
            Return -1
        End Function
        'Function Tim_idx_diem_TP(ByVal ID_diem As Integer, ByVal Hoc_ky_TP As Integer, ByVal Nam_hoc_TP As String) As Boolean
        '    For i As Integer = 0 To mESSThanhPhanDiem.Count - 1
        '        If CType(mESSThanhPhanDiem(i), ESSDiemThanhPhan).ID_diem = ID_diem And CType(mESSThanhPhanDiem(i), ESSDiemThanhPhan).Hoc_ky_TP = Hoc_ky_TP And CType(mESSThanhPhanDiem(i), ESSDiemThanhPhan).Nam_hoc_TP = Nam_hoc_TP Then
        '            Return True
        '        End If
        '    Next
        '    Return False
        'End Function


#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mESSThanhPhanDiem.Count
            End Get
        End Property
        Public Property ESSThanhPhanDiem(ByVal idx As Integer) As ESSThanhPhanDiem
            Get
                Return CType(mESSThanhPhanDiem(idx), ESSThanhPhanDiem)
            End Get
            Set(ByVal Value As ESSThanhPhanDiem)
                mESSThanhPhanDiem(idx) = Value
            End Set
        End Property
        Public Property ID_thanh_phan() As Integer
            Get
                Return mID_thanh_phan
            End Get
            Set(ByVal Value As Integer)
                mID_thanh_phan = Value
            End Set
        End Property
        Public Property STT() As Integer
            Get
                Return mSTT
            End Get
            Set(ByVal Value As Integer)
                mSTT = Value
            End Set
        End Property
        Public Property Ky_hieu() As String
            Get
                Return mKy_hieu
            End Get
            Set(ByVal Value As String)
                mKy_hieu = Value
            End Set
        End Property
        Public Property Ten_thanh_phan() As String
            Get
                Return mTen_thanh_phan
            End Get
            Set(ByVal Value As String)
                mTen_thanh_phan = Value
            End Set
        End Property
        Public Property Ty_le() As Integer
            Get
                Return mTy_le
            End Get
            Set(ByVal Value As Integer)
                mTy_le = Value
            End Set
        End Property
        Public Property He_so() As Integer
            Get
                Return mHe_so
            End Get
            Set(ByVal Value As Integer)
                mHe_so = Value
            End Set
        End Property
        Public Property Nhom() As Integer
            Get
                Return mNhom
            End Get
            Set(ByVal Value As Integer)
                mNhom = Value
            End Set
        End Property
        Public Property Checked() As Boolean
            Get
                Return mChecked
            End Get
            Set(ByVal Value As Boolean)
                mChecked = Value
            End Set
        End Property
        Public Property Chuyen_can() As Boolean
            Get
                Return mChuyen_can
            End Get
            Set(ByVal Value As Boolean)
                mChuyen_can = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
