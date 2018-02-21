Namespace Objects
    Public Class ESSDanhSachThuctap
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_noi_thuc_tap As Integer = 0
        Private mMa_noi_thuc_tap As String = ""
        Private mTen_noi_thuc_tap As String = ""
        Private mDia_chi_thuc_tap As String = ""

#End Region

#Region "Property"

        Public Property ID_noi_thuc_tap() As Integer
            Get
                Return mID_noi_thuc_tap
            End Get
            Set(ByVal Value As Integer)
                mID_noi_thuc_tap = Value
            End Set
        End Property

        Public Property Ma_noi_thuc_tap() As String
            Get
                Return mMa_noi_thuc_tap
            End Get
            Set(ByVal Value As String)
                mMa_noi_thuc_tap = Value
            End Set
        End Property

        Public Property Ten_noi_thuc_tap() As String
            Get
                Return mTen_noi_thuc_tap
            End Get
            Set(ByVal Value As String)
                mTen_noi_thuc_tap = Value
            End Set
        End Property

        Public Property Dia_chi_thuc_tap() As String
            Get
                Return mDia_chi_thuc_tap
            End Get
            Set(ByVal Value As String)
                mDia_chi_thuc_tap = Value
            End Set
        End Property



#End Region
    End Class
End Namespace