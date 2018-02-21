'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Wednesday, July 02, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSXepHangTotNghiep
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_xep_hang As Integer = 0
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mXep_hang As String = ""
        Private mXep_hang_En As String = ""
        Private mXepHangTotNghiep As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal xephang As ESSXepHangTotNghiep)
            mXepHangTotNghiep.Add(xephang)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepHangTotNghiep.RemoveAt(idx)
        End Sub
        Public Function ESSXepHangTotNghiep(ByVal TBCHT As Double, ByVal Ha_XepLoai As Boolean) As String
            For i As Integer = 0 To mXepHangTotNghiep.Count - 1
                If Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Tu_diem, 2) <= TBCHT And _
                    Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Den_diem, 2) > TBCHT Then
                    If Ha_XepLoai AndAlso (i <= 1 And i < mXepHangTotNghiep.Count - 1) Then
                        'Nếu sinh viên vi phạm 2 điều: Quá số tín chỉ thi lại cho phép và Kỷ luật trên mức cảnh cáo 
                        'Chi ap dung cho 2 xep loai dau tien: Gioi va Xuat sac
                        Return CType(mXepHangTotNghiep(i + 1), ESSXepHangTotNghiep).Xep_hang
                    Else
                        Return CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Xep_hang
                    End If
                End If
            Next
            Return ""
        End Function

        Public Function XepHangTotNghiep_En(ByVal TBCHT As Double, ByVal Ha_XepLoai As Boolean) As String
            For i As Integer = 0 To mXepHangTotNghiep.Count - 1
                If Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Tu_diem, 2) <= TBCHT And _
                    Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Den_diem, 2) > TBCHT Then
                    If Ha_XepLoai AndAlso (i <= 1 And i < mXepHangTotNghiep.Count - 1) Then
                        'Nếu sinh viên vi phạm 2 điều: Quá số tín chỉ thi lại cho phép và Kỷ luật trên mức cảnh cáo 
                        'Chi ap dung cho 2 xep loai dau tien: Gioi va Xuat sac
                        Return CType(mXepHangTotNghiep(i + 1), ESSXepHangTotNghiep).Xep_hang_En
                    Else
                        Return CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Xep_hang_En
                    End If
                End If
            Next
            Return ""
        End Function

        Function ID_XepHangTotNghiep(ByVal TBCHT As Double, ByVal Ha_XepLoai As Boolean) As Integer
            For i As Integer = 0 To mXepHangTotNghiep.Count - 1
                If Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Tu_diem, 2) <= TBCHT And _
                   Math.Round(CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).Den_diem, 2) > TBCHT Then
                    If Ha_XepLoai AndAlso (i <= 1 And i < mXepHangTotNghiep.Count - 1) Then
                        'Nếu sinh viên vi phạm 2 điều: Quá số tín chỉ thi lại cho phép và Kỷ luật trên mức cảnh cáo
                        'Chi ap dung cho 2 xep loai dau tien: Gioi va Xuat sac
                        Return CType(mXepHangTotNghiep(i + 1), ESSXepHangTotNghiep).ID_xep_hang
                    Else
                        Return CType(mXepHangTotNghiep(i), ESSXepHangTotNghiep).ID_xep_hang
                    End If
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
        Public Property Xep_hang_En() As String
            Get
                Return mXep_hang_En
            End Get
            Set(ByVal Value As String)
                mXep_hang_En = Value
            End Set
        End Property
#End Region

    End Class
End Namespace
