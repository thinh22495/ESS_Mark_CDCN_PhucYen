﻿'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Monday, June 09, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSGiangVienMonDay
        Inherits ESSMonHoc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_cb As Integer = 0
        Private mID_bm As Integer = 0
#End Region

#Region "Property"
        Public Property ID_cb() As Integer
            Get
                Return mID_cb
            End Get
            Set(ByVal Value As Integer)
                mID_cb = Value
            End Set
        End Property
        Public Property ID_bm() As Integer
            Get
                Return mID_bm
            End Get
            Set(ByVal Value As Integer)
                mID_bm = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
