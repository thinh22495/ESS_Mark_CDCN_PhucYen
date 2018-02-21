Namespace Objects
    Public Class ESSNoKhacKhiXetTotNghiep
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mLy_do As String = ""
#End Region

#Region "Property"
        Public Property Ly_do() As String
            Get
                Return mLy_do
            End Get
            Set(ByVal Value As String)
                mLy_do = Value
            End Set
        End Property
#End Region
    End Class
End Namespace