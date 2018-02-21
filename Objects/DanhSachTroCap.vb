'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSDanhSachTroCap
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mHoc_ky As Integer = 0
        Private mNam_hoc As String = ""
        Private mSotien_trocap As Integer = 0
        Private mGhi_chu As String = ""
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
        Public Property Sotien_trocap() As Integer
            Get
                Return mSotien_trocap
            End Get
            Set(ByVal Value As Integer)
                mSotien_trocap = Value
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
#End Region

    End Class
End Namespace
