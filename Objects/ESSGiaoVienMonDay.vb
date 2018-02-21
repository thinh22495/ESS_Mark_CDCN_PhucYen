'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/24/2011
'---------------------------------------------------------------------------
Imports System
Namespace Objects
    Public Class ESSGiaoVienMonDay
        Inherits ESSMonHoc
        Private mMonHoc As New ArrayList
        Public Sub Add(ByVal mh As ESSMonHoc)
            mMonHoc.Add(mh)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mMonHoc.RemoveAt(idx)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mMonHoc.Count
            End Get
        End Property
        Public Property MonDay(ByVal idx As Integer) As ESSMonHoc
            Get
                Return CType(mMonHoc(idx), ESSMonHoc)
            End Get
            Set(ByVal Value As ESSMonHoc)
                mMonHoc(idx) = Value
            End Set
        End Property
    End Class
End Namespace