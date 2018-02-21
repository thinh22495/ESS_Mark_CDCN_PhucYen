'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, 02 June, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSThamSoHeThong
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_tham_so As String = ""
        Private mTen_tham_so As String = ""
        Private mID_ph As Integer = 0
        Private mGia_tri As String = ""
        Private mGhi_chu As String = ""
        Private mActive As Boolean = 0
#End Region
#Region "Functions And Subs"

#End Region
#Region "Property"
        Public Property ID_tham_so() As String
            Get
                Return mID_tham_so
            End Get
            Set(ByVal Value As String)
                mID_tham_so = Value
            End Set
        End Property
        Public Property Ten_tham_so() As String
            Get
                Return mTen_tham_so
            End Get
            Set(ByVal Value As String)
                mTen_tham_so = Value
            End Set
        End Property
        Public Property ID_ph() As Integer
            Get
                Return mID_ph
            End Get
            Set(ByVal Value As Integer)
                mID_ph = Value
            End Set
        End Property
        Public Property Gia_tri() As String
            Get
                Return mGia_tri
            End Get
            Set(ByVal Value As String)
                mGia_tri = Value
            End Set
        End Property
        Public Property Ghi_chu() As String
            Get
                Return mGhi_chu
            End Get
            Set(ByVal Value As String)
                mGhi_chu = Value
            End Set
        End Property
        Public Property Active() As Boolean
            Get
                Return mActive
            End Get
            Set(ByVal Value As Boolean)
                mActive = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
