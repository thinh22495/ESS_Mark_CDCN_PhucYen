Imports System
Namespace Objects
    Public Class ESSXepLoaiChungChi
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_xep_loai As Integer = 0
        Private mXep_loai As String = ""
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mXepLoaiChungChi As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal xeploai As ESSXepLoaiChungChi)
            mXepLoaiChungChi.Add(xeploai)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepLoaiChungChi.RemoveAt(idx)
        End Sub
        Public Function ESSXepLoaiChungChi(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiChungChi.Count - 1
                If CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).Tu_diem <= TBCHT And _
                    CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).Den_diem > TBCHT Then
                    Return CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).Xep_loai
                End If
            Next
            Return ""
        End Function
        Public Function IDXepLoaiChungChi(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiChungChi.Count - 1
                If CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).Tu_diem <= TBCHT And _
                    CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).Den_diem > TBCHT Then
                    Return CType(mXepLoaiChungChi(i), ESSXepLoaiChungChi).ID_xep_loai
                End If
            Next
            Return 0
        End Function
#End Region
#Region "Property"
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
#End Region
    End Class
End Namespace