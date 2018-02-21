'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Tuesday, July 29, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSBienLaiThuChiTiet
        Inherits ESSMonHoc
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_bien_lai_sub As Integer = 0
        Private mID_bien_lai As Integer = 0
        Private mID_thu_chi As Integer = 0
        Private mID_mon_tc As Integer = 0
        Private mKy_hieu_lop_tc As String = ""
        Private mSo_tien As Integer = 0
        Private mBienLaiChiTiet As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal blCT As ESSBienLaiThuChiTiet)
            mBienLaiChiTiet.Add(blCT)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mBienLaiChiTiet.RemoveAt(idx)
        End Sub
        Public Function Tim_idx(ByVal ID_bien_lai As Integer, ByVal ID_thu_chi As Integer, ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                If CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_bien_lai = ID_bien_lai And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_thu_chi = ID_thu_chi And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx(ByVal ID_bien_lai As Integer, ByVal ID_thu_chi As Integer, ByVal ID_mon As Integer, ByVal Ky_hieu_lop_tc As String) As Integer
            For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                If CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_bien_lai = ID_bien_lai And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_thu_chi = ID_thu_chi And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_mon = ID_mon And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).Ky_hieu_lop_tc = Ky_hieu_lop_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_idx(ByVal ID_bien_lai As Integer, ByVal ID_thu_chi As Integer) As Integer
            For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                If CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_bien_lai = ID_bien_lai And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_thu_chi = ID_thu_chi Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_mon(ByVal ID_bien_lai As Integer, ByVal ID_mon As Integer) As Integer
            For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                If CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_bien_lai = ID_bien_lai And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_mon = ID_mon Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Function Tim_mon_tc(ByVal ID_bien_lai As Integer, ByVal ID_mon_tc As Integer) As Integer
            For i As Integer = 0 To mBienLaiChiTiet.Count - 1
                If CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_bien_lai = ID_bien_lai And _
                    CType(mBienLaiChiTiet(i), ESSBienLaiThuChiTiet).ID_mon_tc = ID_mon_tc Then
                    Return i
                End If
            Next
            Return -1
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mBienLaiChiTiet.Count
            End Get
        End Property
        Public Property BienLaiChiTiet(ByVal idx As Integer) As ESSBienLaiThuChiTiet
            Get
                Return CType(mBienLaiChiTiet(idx), ESSBienLaiThuChiTiet)
            End Get
            Set(ByVal Value As ESSBienLaiThuChiTiet)
                mBienLaiChiTiet(idx) = Value
            End Set
        End Property
        Public Property ID_bien_lai_sub() As Integer
            Get
                Return mID_bien_lai_sub
            End Get
            Set(ByVal Value As Integer)
                mID_bien_lai_sub = Value
            End Set
        End Property
        Public Property ID_bien_lai() As Integer
            Get
                Return mID_bien_lai
            End Get
            Set(ByVal Value As Integer)
                mID_bien_lai = Value
            End Set
        End Property
        Public Property ID_thu_chi() As Integer
            Get
                Return mID_thu_chi
            End Get
            Set(ByVal Value As Integer)
                mID_thu_chi = Value
            End Set
        End Property
        Public Property ID_mon_tc() As Integer
            Get
                Return mID_mon_tc
            End Get
            Set(ByVal Value As Integer)
                mID_mon_tc = Value
            End Set
        End Property
        Public Property Ky_hieu_lop_tc() As String
            Get
                Return mKy_hieu_lop_tc
            End Get
            Set(ByVal Value As String)
                mKy_hieu_lop_tc = Value
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
