'---------------------------------------------------------------------------
' Author : Đỗ Văn Lộc
' Company : Thiên An Technology
' Created Date : Tuesday, April 22, 2008
'---------------------------------------------------------------------------

Imports System
Namespace Entity
    Public Class DanToc
#Region "Constructor"
#End Region

#Region "Var"
        Private mID_dan_toc As Integer = 0
        Private mMa_dan_toc As String = ""
        Private mDan_toc As String = ""
#End Region

#Region "Property"
        Public Property ID_dan_toc() As Integer
            Get
                Return mID_dan_toc
            End Get
            Set(ByVal Value As Integer)
                mID_dan_toc = Value
            End Set
        End Property
        Public Property Ma_dan_toc() As String
            Get
                Return mMa_dan_toc
            End Get
            Set(ByVal Value As String)
                mMa_dan_toc = Value
            End Set
        End Property
        Public Property Dan_toc() As String
            Get
                Return mDan_toc
            End Get
            Set(ByVal Value As String)
                mDan_toc = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
