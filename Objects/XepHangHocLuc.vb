'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, July 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSXepHangHocLuc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_xep_hang As Integer = 0
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mXep_hang As String = ""
        Private mXepHangHocLuc As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal xephang As ESSXepHangHocLuc)
            mXepHangHocLuc.Add(xephang)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepHangHocLuc.RemoveAt(idx)
        End Sub
        Public Function ESSXepHangHocLuc(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepHangHocLuc.Count - 1
                If CType(mXepHangHocLuc(i), ESSXepHangHocLuc).Tu_diem <= TBCHT And _
                    CType(mXepHangHocLuc(i), ESSXepHangHocLuc).Den_diem > TBCHT Then
                    Return CType(mXepHangHocLuc(i), ESSXepHangHocLuc).Xep_hang
                End If
            Next
            Return ""
        End Function
        Public Function IDXepHangHocLuc(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepHangHocLuc.Count - 1
                If CType(mXepHangHocLuc(i), ESSXepHangHocLuc).Tu_diem <= TBCHT And _
                    CType(mXepHangHocLuc(i), ESSXepHangHocLuc).Den_diem > TBCHT Then
                    Return CType(mXepHangHocLuc(i), ESSXepHangHocLuc).ID_xep_hang
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public Property ID_xep_hang() As Integer
            Get
                Return mID_xep_hang
            End Get
            Set(ByVal Value As Integer)
                mID_xep_hang = Value
            End Set
        End Property
        Public Property Tu_diem() As Double
            Get
                Return mTu_diem
            End Get
            Set(ByVal Value As Double)
                mTu_diem = Value
            End Set
        End Property
        Public Property Den_diem() As Double
            Get
                Return mDen_diem
            End Get
            Set(ByVal Value As Double)
                mDen_diem = Value
            End Set
        End Property
        Public Property Xep_hang() As String
            Get
                Return mXep_hang
            End Get
            Set(ByVal Value As String)
                mXep_hang = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
