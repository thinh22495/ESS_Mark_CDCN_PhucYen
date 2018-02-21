'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/21/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSVaiTro
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_vai_tro As Integer = 0
        Private mTen_vai_tro As String = ""
        Private mMo_ta As String = ""
        Private mESSVaiTroQuyen As New ESSVaiTroQuyen
        Private mESSVaiTro As New ArrayList
#End Region
        Public Sub Add(ByVal vaiTro As ESSVaiTro)
            mESSVaiTro.Add(vaiTro)
        End Sub
        Public Sub Remove(ByVal idx_vai_tro As Integer)
            mESSVaiTro.RemoveAt(idx_vai_tro)
        End Sub
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mESSVaiTro.Count
            End Get
        End Property
        Public Property ESSVaiTro(ByVal idx As Integer) As ESSVaiTro
            Get
                Return CType(mESSVaiTro(idx), ESSVaiTro)
            End Get
            Set(ByVal Value As ESSVaiTro)
                mESSVaiTro(idx) = Value
            End Set
        End Property
        Public Property ID_vai_tro() As Integer
            Get
                Return mID_vai_tro
            End Get
            Set(ByVal Value As Integer)
                mID_vai_tro = Value
            End Set
        End Property
        Public Property Ten_vai_tro() As String
            Get
                Return mTen_vai_tro
            End Get
            Set(ByVal Value As String)
                mTen_vai_tro = Value
            End Set
        End Property
        Public Property Mo_ta() As String
            Get
                Return mMo_ta
            End Get
            Set(ByVal Value As String)
                mMo_ta = Value
            End Set
        End Property
        Public Property ESSVaiTroQuyen() As ESSVaiTroQuyen
            Get
                Return mESSVaiTroQuyen
            End Get
            Set(ByVal Value As ESSVaiTroQuyen)
                mESSVaiTroQuyen = Value
            End Set
        End Property

        'Public Function DanhSachESSVaiTroQuyen() As DataTable
        '    Dim dt As New DataTable
        '    dt.Columns.Add("Chon", GetType(Boolean))
        '    dt.Columns.Add("ID_ph", GetType(Integer))
        '    dt.Columns.Add("ID_Quyen", GetType(Integer))
        '    dt.Columns.Add("Ten_Quyen", GetType(String))
        '    dt.Columns.Add("Them", GetType(Boolean))
        '    dt.Columns.Add("Sua", GetType(Boolean))
        '    dt.Columns.Add("Xoa", GetType(Boolean))
        '    For i As Integer = 0 To ESSVaiTroQuyen.Count - 1
        '        Dim gvaitroquyen As ESSVaiTroQuyen = CType(ESSVaiTroQuyen.ESSVaiTroQuyen(i), ESSVaiTroQuyen)
        '        Dim row As DataRow = dt.NewRow()
        '        row("Chon") = False
        '        row("ID_ph") = gvaitroquyen.ID_ph
        '        row("ID_Quyen") = gvaitroquyen.ID_quyen
        '        row("Ten_Quyen") = gvaitroquyen.Ten_quyen
        '        row("Them") = False
        '        row("Sua") = False
        '        row("Xoa") = False
        '        dt.Rows.Add(row)
        '    Next
        '    Return dt
        'End Function
#End Region
    End Class
End Namespace
