Imports ThienAn.Entity.Entity
Public Class VaiTroQuyens
    Private mVaiTroQuyen As New ArrayList
    Public Sub Add(ByVal VaiTro As VaiTroQuyen)
        mVaiTroQuyen.Add(VaiTro)
    End Sub
    Public Sub Remove(ByVal idx_vai_tro As Integer)
        mVaiTroQuyen.RemoveAt(idx_vai_tro)
    End Sub
    Public ReadOnly Property Count() As Integer
        Get
            Return mVaiTroQuyen.Count
        End Get
    End Property
    Public Property VaiTroQuyen(ByVal idx As Integer) As VaiTroQuyen
        Get
            Return CType(mVaiTroQuyen(idx), VaiTroQuyen)
        End Get
        Set(ByVal Value As VaiTroQuyen)
            mVaiTroQuyen(idx) = Value
        End Set
    End Property
End Class
