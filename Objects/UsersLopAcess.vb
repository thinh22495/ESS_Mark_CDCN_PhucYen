Public Class UsersLopAcess
    Private mUsersLopAcess As New ArrayList
    'Public Sub New()
    '    mUsersLopAcess = New ArrayList
    'End Sub
    Public Sub Add(ByVal ID_lop As Integer)
        mUsersLopAcess.Add(ID_lop)
    End Sub
    Public Sub Remove(ByVal idx_quyen As Integer)
        mUsersLopAcess.RemoveAt(idx_quyen)
    End Sub
    Public ReadOnly Property Count() As Integer
        Get
            Return mUsersLopAcess.Count
        End Get
    End Property
    Public Property UsersLopAcess(ByVal idx As Integer) As Integer
        Get
            Return CType(mUsersLopAcess(idx), Integer)
        End Get
        Set(ByVal Value As Integer)
            mUsersLopAcess(idx) = Value
        End Set
    End Property
End Class