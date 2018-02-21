'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : 14/04/2010
'---------------------------------------------------------------------------
Imports System
Namespace Objects
    Public Class ESSTKB
        Private _Tkb(,) As Integer
        Private _Loai_sk(,) As eLOAI_SK
        Public Sub New(ByVal Ngay_tuan As Integer, ByVal So_tiet_ngay As Integer)
            ReDim _Tkb(Ngay_tuan - 1, So_tiet_ngay - 1)
            ReDim _Loai_sk(Ngay_tuan - 1, So_tiet_ngay - 1)
            For i As Integer = 0 To Ngay_tuan - 1
                For j As Integer = 0 To So_tiet_ngay - 1
                    _Tkb(i, j) = -1
                    _Loai_sk(i, j) = eLOAI_SK.LICH_HOC
                Next
            Next
        End Sub
        Public Property ESSTKB(ByVal thu As Integer, ByVal tiet As Integer) As Integer
            Get
                Return _Tkb(thu, tiet)
            End Get
            Set(ByVal Value As Integer)
                _Tkb(thu, tiet) = Value
            End Set
        End Property
        Public Property Loai_sk(ByVal thu As Integer, ByVal tiet As Integer) As eLOAI_SK
            Get
                Return _Loai_sk(thu, tiet)
            End Get
            Set(ByVal Value As eLOAI_SK)
                _Loai_sk(thu, tiet) = Value
            End Set
        End Property
    End Class
End Namespace