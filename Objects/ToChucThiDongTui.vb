Imports System
Namespace Objects
    Public Class ESSToChucThiDongTui
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_thi As Integer = 0
        Private mTui_so As Integer = 0
        Private mSo_sv As Integer = 0
        Private mTochucThiTheoTui As New ArrayList
#End Region
        Public Sub Add(ByVal TuiThi As ESSToChucThiDongTui)
            mTochucThiTheoTui.Add(TuiThi)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mTochucThiTheoTui.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal Ten_phong As String) As Integer
            For i As Integer = 0 To mTochucThiTheoTui.Count - 1
                If CType(mTochucThiTheoTui(i), ESSToChucThiDongTui).Tui_so = Tui_so Then
                    Return i
                End If
            Next
            Return -1
        End Function
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mTochucThiTheoTui.Count
            End Get
        End Property
        Public Property TochucThiTui(ByVal idx As Integer) As ESSToChucThiDongTui
            Get
                Return CType(mTochucThiTheoTui(idx), ESSToChucThiDongTui)
            End Get
            Set(ByVal Value As ESSToChucThiDongTui)
                mTochucThiTheoTui(idx) = Value
            End Set
        End Property

        Public Property Tui_so() As Integer
            Get
                Return mTui_so
            End Get
            Set(ByVal Value As Integer)
                mTui_so = Value
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
        Public Property So_sv() As Integer
            Get
                Return mSo_sv
            End Get
            Set(ByVal Value As Integer)
                mSo_sv = Value
            End Set
        End Property
#End Region
    End Class
End Namespace
