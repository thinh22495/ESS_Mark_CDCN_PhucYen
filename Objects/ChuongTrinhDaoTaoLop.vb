'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSChuongTrinhDaoTaoLop
        Inherits ESSLop
#Region "Var"
        Private mChuongTrinhDaoTaoLop As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal l As ESSLop)
            mChuongTrinhDaoTaoLop.Add(l)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mChuongTrinhDaoTaoLop.RemoveAt(idx)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mChuongTrinhDaoTaoLop.Count
            End Get
        End Property
        Public Property ESSChuongTrinhDaoTaoLop(ByVal idx As Integer) As ESSLop
            Get
                Return CType(mChuongTrinhDaoTaoLop(idx), ESSLop)
            End Get
            Set(ByVal Value As ESSLop)
                mChuongTrinhDaoTaoLop(idx) = Value
            End Set
        End Property
        Public Function Tim_idx(ByVal ID_lop As Integer) As Integer
            For i As Integer = 0 To mChuongTrinhDaoTaoLop.Count - 1
                If CType(mChuongTrinhDaoTaoLop(i), ESSLop).ID_lop = ID_lop Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
    End Class
End Namespace