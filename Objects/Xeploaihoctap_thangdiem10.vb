Imports System
Namespace Objects
    Public Class ESSXeploaihoctap_thangdiem10
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_xep_loai As Integer = 0
        Private mXep_loai As String = ""
        Private mTu_diem As Double = 0
        Private mDen_diem As Double = 0
        Private mXepLoaiHocTap As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal xeploai As ESSXeploaihoctap_thangdiem10)
            mXepLoaiHocTap.Add(xeploai)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mXepLoaiHocTap.RemoveAt(idx)
        End Sub
        Public Function ESSXeploaihoctap_thangdiem10(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Den_diem > TBCHT Then
                    Return CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Xep_loai
                End If
            Next
            Return ""
        End Function
        Public Function IDXepLoaiHocTap_thangdiem10(ByVal TBCHT As Double) As String
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                If CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Tu_diem <= TBCHT And _
                    CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Den_diem > TBCHT Then
                    Return CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).ID_xep_loai
                End If
            Next
            Return 0
        End Function

        Function PhantramXeploaihoctap(ByVal dt As DataTable) As String
            Dim Xep_loais As String = ""
            For i As Integer = 0 To mXepLoaiHocTap.Count - 1
                dt.DefaultView.RowFilter = "1=1"
                dt.DefaultView.RowFilter = "ID_Xephang_hocluc=" & CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).mID_xep_loai
                If Xep_loais.Trim = "" Then
                    Xep_loais = "Kết quả PL: " & CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Xep_loai & ": " & dt.DefaultView.Count & " " & Math.Round(dt.DefaultView.Count / dt.Rows.Count * 100, 2) & " %"
                Else
                    Xep_loais += ";       " & CType(mXepLoaiHocTap(i), ESSXeploaihoctap_thangdiem10).Xep_loai & ": " & dt.DefaultView.Count & " " & Math.Round(dt.DefaultView.Count / dt.Rows.Count * 100, 2) & " %"
                End If
            Next
            Return Xep_loais
        End Function
#End Region
#Region "Property"
        Public Property ID_xep_loai() As Integer
            Get
                Return mID_xep_loai
            End Get
            Set(ByVal Value As Integer)
                mID_xep_loai = Value
            End Set
        End Property
        Public Property Xep_loai() As String
            Get
                Return mXep_loai
            End Get
            Set(ByVal Value As String)
                mXep_loai = Value
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
#End Region
    End Class
End Namespace