'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Thursday, July 31, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSMucHocPhiTinChi
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mID_he As Integer = 0
        Private mSo_tien As Integer = 0
#End Region

#Region "Property"
        Public Property Hoc_ky() As Integer
            Get
                Return mHoc_ky
            End Get
            Set(ByVal Value As Integer)
                mHoc_ky = Value
            End Set
        End Property
        Public Property Nam_hoc() As String
            Get
                Return mNam_hoc
            End Get
            Set(ByVal Value As String)
                mNam_hoc = Value
            End Set
        End Property
        Public Property ID_he() As Integer
            Get
                Return mID_he
            End Get
            Set(ByVal Value As Integer)
                mID_he = Value
            End Set
        End Property
        Public Property So_tien() As Integer
            Get
                Return mSo_tien
            End Get
            Set(ByVal Value As Integer)
                mSo_tien = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
