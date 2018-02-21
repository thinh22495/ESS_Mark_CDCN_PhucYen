'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/21/2011
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSVaiTroQuyen
        Inherits ESSQuyen
#Region "Initialize"
#End Region

#Region "Var"
        Private mThem As Integer = 0
        Private mSua As Integer = 0
        Private mXoa As Integer = 0
        Private mESSVaiTroQuyen As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal ESSVaiTro As ESSVaiTroQuyen)
            mESSVaiTroQuyen.Add(ESSVaiTro)
        End Sub
        Public Sub Remove(ByVal idx_vai_tro As Integer)
            mESSVaiTroQuyen.RemoveAt(idx_vai_tro)
        End Sub
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mESSVaiTroQuyen.Count
            End Get
        End Property
        Public Property ESSVaiTroQuyen(ByVal idx As Integer) As ESSVaiTroQuyen
            Get
                Return CType(mESSVaiTroQuyen(idx), ESSVaiTroQuyen)
            End Get
            Set(ByVal Value As ESSVaiTroQuyen)
                mESSVaiTroQuyen(idx) = Value
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
