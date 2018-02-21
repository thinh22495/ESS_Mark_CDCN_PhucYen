'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 04/02/2010
'---------------------------------------------------------------------------
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class Sukiens
        Private mSukien As ArrayList
        Public Sub New()
            mSukien = New ArrayList
        End Sub
        Public Sub Add(ByVal sk As ESSSu_kien)
            mSukien.Add(sk)
        End Sub
        Public Sub Remove(ByVal idx_sk As Integer)
            mSukien.RemoveAt(idx_sk)
        End Sub
        Public ReadOnly Property Count() As Integer
            Get
                Return mSukien.Count
            End Get
        End Property
        Public Property Sukien(ByVal idx As Integer) As ESSSu_kien
            Get
                Return CType(mSukien(idx), ESSSu_kien)
            End Get
            Set(ByVal Value As ESSSu_kien)
                mSukien(idx) = Value
            End Set
        End Property
    End Class
End Namespace