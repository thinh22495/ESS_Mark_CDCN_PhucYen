'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/11/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSUsersQuyen
        Inherits ESSQuyen
#Region "Initialize"
#End Region

#Region "Var"
        Private mThem As Integer = 0
        Private mSua As Integer = 0
        Private mXoa As Integer = 0
        Private mUsersQuyen As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal quyen As ESSUsersQuyen)
            mUsersQuyen.Add(quyen)
        End Sub
        Public Sub Remove(ByVal idx_quyen As Integer)
            mUsersQuyen.RemoveAt(idx_quyen)
        End Sub
        Public Function Tim_idx(ByVal ID_quyen As Integer) As Integer
            For i As Integer = 0 To mUsersQuyen.Count - 1
                If CType(mUsersQuyen(i), ESSQuyen).ID_quyen = ID_quyen Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mUsersQuyen.Count
            End Get
        End Property
        Public Property Quyen(ByVal idx As Integer) As ESSUsersQuyen
            Get
                Return CType(mUsersQuyen(idx), ESSUsersQuyen)
            End Get
            Set(ByVal Value As ESSUsersQuyen)
                mUsersQuyen(idx) = Value
            End Set
        End Property
        Public Property Them() As Integer
            Get
                Return mThem
            End Get
            Set(ByVal Value As Integer)
                mThem = Value
            End Set
        End Property
        Public Property Sua() As Integer
            Get
                Return mSua
            End Get
            Set(ByVal Value As Integer)
                mSua = Value
            End Set
        End Property
        Public Property Xoa() As Integer
            Get
                Return mXoa
            End Get
            Set(ByVal Value As Integer)
                mXoa = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
