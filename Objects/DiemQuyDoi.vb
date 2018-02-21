'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 01, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDiemQuyDoi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_xep_loai As Integer = 0
        Private mXep_loai As String = ""
        Private mDiem_chu As String = ""
        Private mDiem_so As Double = 0
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mTich_luy As Boolean = 0
        Private mDiemQuyDoi As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal ESSDiemQuyDoi As ESSDiemQuyDoi)
            mDiemQuyDoi.Add(ESSDiemQuyDoi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mDiemQuyDoi.RemoveAt(idx)
        End Sub
        Public Function QuyDoiDiemChu(ByVal TBCMH As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If Math.Round(CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Tu_diem, 2) <= TBCMH And _
                    Math.Round(CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Den_diem, 2) >= TBCMH Then
                    Return CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Diem_chu
                End If
            Next
            Return ""
        End Function
        Public Function TichLuy(ByVal Diem_chu As String) As Boolean
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Diem_chu = Diem_chu Then
                    Return CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Tich_luy
                End If
            Next
            Return False
        End Function

        Public Function IDXepLoaiDiemQuyDoi(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Tu_diem <= TBCHT And _
                    CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Den_diem > TBCHT Then
                    Return CType(mDiemQuyDoi(i), ESSDiemQuyDoi).ID_xep_loai
                End If
            Next
            Return 0
        End Function

        Public Function IDXepLoaiDiemQuyDoiDiemSo(ByVal TBCMH As Double) As String
            For i As Integer = 0 To mDiemQuyDoi.Count - 1
                If CType(mDiemQuyDoi(i), ESSDiemQuyDoi).Diem_so = TBCMH Then
                    Return CType(mDiemQuyDoi(i), ESSDiemQuyDoi).ID_xep_loai
                End If
            Next
            Return 0
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mDiemQuyDoi.Count
            End Get
        End Property
        Public Property ESSDiemQuyDoi(ByVal idx As Integer) As ESSDiemQuyDoi
            Get
                Return CType(mDiemQuyDoi(idx), ESSDiemQuyDoi)
            End Get
            Set(ByVal Value As ESSDiemQuyDoi)
                mDiemQuyDoi(idx) = Value
            End Set
        End Property
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
            End Set
        End Property
        Public Property Xep_loai() As String
            Get
                Return mXep_loai
            End Get
            Set(ByVal Value As String)
                mXep_loai = Value
            End Set
        End Property
        Public Property Diem_chu() As String
            Get
                Return mDiem_chu
            End Get
            Set(ByVal Value As String)
                mDiem_chu = Value
            End Set
        End Property
        Public Property Diem_so() As Double
            Get
                Return mDiem_so
            End Get
            Set(ByVal Value As Double)
                mDiem_so = Value
            End Set
        End Property
        Public Property Tu_diem() As Double
            Get
                Return mTu_diem
            End Get
            Set(ByVal Value As Double)
                mTu_diem = Value
            End Set
        End Property
        Public Property Den_diem() As Double
            Get
                Return mDen_diem
            End Get
            Set(ByVal Value As Double)
                mDen_diem = Value
            End Set
        End Property
        Public Property Tich_luy() As Boolean
            Get
                Return mTich_luy
            End Get
            Set(ByVal Value As Boolean)
                mTich_luy = Value
            End Set
        End Property
#End Region
    End Class
End Namespace