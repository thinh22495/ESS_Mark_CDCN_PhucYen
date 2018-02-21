Imports ESS.Objects
Public Class UsersQuyens
    Private mUsersQuyen As ArrayList
    Public Sub New()
        mUsersQuyen = New ArrayList
    End Sub
    Public Sub Add(ByVal quyen As ESSUsersQuyen)
        mUsersQuyen.Add(quyen)
    End Sub
    Public Sub Remove(ByVal idx_quyen As Integer)
        mUsersQuyen.RemoveAt(idx_quyen)
    End Sub
    Public ReadOnly Property Count() As Integer
        Get
            Return mUsersQuyen.Count
        End Get
    End Property
    Public Property ESSUsersQuyen(ByVal idx As Integer) As ESSUsersQuyen
        Get
            Return CType(mUsersQuyen(idx), ESSUsersQuyen)
        End Get
        Set(ByVal Value As ESSUsersQuyen)
            mUsersQuyen(idx) = Value
        End Set
    End Property
End Class
