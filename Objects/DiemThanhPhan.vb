'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Friday, May 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiemThanhPhan
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_thanh_phan As Integer = 0
        Private mID_diem As Integer = 0
        Private mDiem As Double = 0
        Private mLy_do As String = ""
        Private mTy_le As Integer = 0
        Private mHe_so As Integer = 0
        Private mNhom As Integer = 0
        Private mHash_code As Integer = 0
        Private mLocked As Integer = 0
        Private mDiemThanhPhan As New ArrayList

        Private mNam_hoc_TP As String = ""
        Private mHoc_ky_TP As Integer = 0
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal dTP As ESSDiemThanhPhan)
            mDiemThanhPhan.Add(dTP)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemThanhPhan.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_thanh_phan As Integer, Optional ByVal Hoc_ky_TP As Integer = 0, Optional ByVal Nam_hoc_TP As String = "") As Integer
            For i As Integer = 0 To mDiemThanhPhan.Count - 1
                If Hoc_ky_TP <> 0 And Nam_hoc_TP <> "" Then
                    If CType(mDiemThanhPhan(i), ESSDiemThanhPhan).ID_thanh_phan = ID_thanh_phan And CType(mDiemThanhPhan(i), ESSDiemThanhPhan).Hoc_ky_TP = Hoc_ky_TP And CType(mDiemThanhPhan(i), ESSDiemThanhPhan).Nam_hoc_TP = Nam_hoc_TP Then
                        Return i
                    End If
                Else
                    If CType(mDiemThanhPhan(i), ESSDiemThanhPhan).ID_thanh_phan = ID_thanh_phan Then
                        Return i
                    End If
                End If
            Next
            Return -1
        End Function

        Function Tim_idx_diem_TP(ByVal ID_diem As Integer, ByVal Hoc_ky_TP As Integer, ByVal Nam_hoc_TP As String) As Boolean
            For i As Integer = 0 To mDiemThanhPhan.Count - 1
                If CType(mDiemThanhPhan(i), ESSDiemThanhPhan).ID_diem = ID_diem And CType(mDiemThanhPhan(i), ESSDiemThanhPhan).Hoc_ky_TP = Hoc_ky_TP And CType(mDiemThanhPhan(i), ESSDiemThanhPhan).Nam_hoc_TP = Nam_hoc_TP Then
                    Return True
                End If
            Next
            Return False
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemThanhPhan.Count
            End Get
        End Property
        Public Property ESSDiemThanhPhan(ByVal idx As Integer) As ESSDiemThanhPhan
            Get
                Return CType(mDiemThanhPhan(idx), ESSDiemThanhPhan)
            End Get
            Set(ByVal Value As ESSDiemThanhPhan)
                mDiemThanhPhan(idx) = Value
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
        Public Property Diem() As Double
            Get
                Return mDiem
            End Get
            Set(ByVal Value As Double)
                mDiem = Value
            End Set
        End Property
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
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
        Public Property Hash_code() As Integer
            Get
                Return mHash_code
            End Get
            Set(ByVal Value As Integer)
                mHash_code = Value
            End Set
        End Property
        Public Property Locked() As Integer
            Get
                Return mLocked
            End Get
            Set(ByVal Value As Integer)
                mLocked = Value
            End Set
        End Property

        Public Property Hoc_ky_TP() As Integer
            Get
                Return mHoc_ky_TP
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky_TP = Value
            End Set
        End Property
        Public Property Nam_hoc_TP() As String
            Get
                Return mNam_hoc_TP
            End Get
            Set(ByVal Value As String)
                mNam_hoc_TP = Value
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
