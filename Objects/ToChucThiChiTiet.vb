'---------------------------------------------------------------------------
' Author : Education Solution Soft - ESS
' Company : Education Solution Soft - ESS
' Created Date : Saturday, May 03, 2010
'---------------------------------------------------------------------------

Imports System
Namespace Objects
    Public Class ESSTochucThiChiTiet
        Inherits ESSDanhSachSinhVien
#Region "Initialize"
#End Region

#Region "Var"
        Private mID_ds_thi As Integer = 0
        Private mID_thi As Integer = 0
        Private mID_phong_thi As Integer = 0
        Private mTen_phong As String = ""
        Private mSo_bao_danh As String = ""
        Private mSo_phach As Integer = 0
        Private mTui_so As Integer = 0
        Private mGhi_chu_thi As String = ""
        Private mOrderBy As String = ""
        Public strUnicode As String = "AÁÀẢẠÃaáàảạãĂẮẰẲẶẴăắằẳặẵÂẤẨẬẪâấầậẫBbCcDĐđEÉÈẺẼẸeéèẻẽẹÊẾỀỂỄỆêếềểễệFfGgHhIÍÌỈĨỊiíìỉĩịJjKkLlMmNnOÓÒỎÕỌoóòỏõọÔỐỒỔỖỘôốồổỗộƠỚỜỞỠỢơớờởỡợUÚÙỦŨỤuúùủũụƯỨỪỬỮỰưứừửựPpQqSsTtRrXxVvYÝỲỶỸỴyýỳỷỹỵ"
        Private mTochucThiChiTiet As New ArrayList
#End Region
#Region "Functions And Subs"
        Public Sub Add(ByVal thiChiTiet As ESSTochucThiChiTiet)
            mTochucThiChiTiet.Add(thiChiTiet)
        End Sub
        Public Sub Remove(ByVal idx As Integer)
            mTochucThiChiTiet.RemoveAt(idx)
        End Sub
        Private Function ConvertToNumber(ByVal strUnicode As String, ByVal strConvert As String) As String
            Dim i As Integer, str As String = ""
            Dim pos As Integer = InStrRev(strConvert, " ")
            If pos > 0 Then
                strConvert = Right(strConvert, Len(strConvert) - pos) + Left(strConvert, pos)
            End If
            For i = 1 To Len(strConvert)
                str = str & Right("00" & InStr(strUnicode, Mid(strConvert, i, 1)), 3)
            Next
            Return str
        End Function
#End Region
#Region "Property"
        Public ReadOnly Property Count() As Integer
            Get
                Return mTochucThiChiTiet.Count
            End Get
        End Property
        Public Property ESSTochucThiChiTiet(ByVal idx As Integer) As ESSTochucThiChiTiet
            Get
                Return CType(mTochucThiChiTiet(idx), ESSTochucThiChiTiet)
            End Get
            Set(ByVal Value As ESSTochucThiChiTiet)
                mTochucThiChiTiet(idx) = Value
            End Set
        End Property
        Public Function Tim_sinh_vien(ByVal ID_sv As Integer) As Integer
            For i As Integer = 0 To mTochucThiChiTiet.Count - 1
                If CType(mTochucThiChiTiet(i), ESSTochucThiChiTiet).ID_sv = ID_sv Then
                    Return i
                End If
            Next
            Return -1
        End Function
        Public Property ID_ds_thi() As Integer
            Get
                Return mID_ds_thi
            End Get
            Set(ByVal Value As Integer)
                mID_ds_thi = Value
            End Set
        End Property
        Public Property ID_thi() As Integer
            Get
                Return mID_thi
            End Get
            Set(ByVal Value As Integer)
                mID_thi = Value
            End Set
        End Property
        Public Property So_bao_danh() As String
            Get
                Return mSo_bao_danh
            End Get
            Set(ByVal Value As String)
                mSo_bao_danh = Value
            End Set
        End Property
        Public Property So_phach() As Integer
            Get
                Return mSo_phach
            End Get
            Set(ByVal Value As Integer)
                mSo_phach = Value
            End Set
        End Property
        Public Property Tui_so() As Integer
            Get
                Return mTui_so
            End Get
            Set(ByVal Value As Integer)
                mTui_so = Value
            End Set
        End Property
        Public Property ID_phong_thi() As Integer
            Get
                Return mID_phong_thi
            End Get
            Set(ByVal Value As Integer)
                mID_phong_thi = Value
            End Set
        End Property
        Public Property Ten_phong() As String
            Get
                Return mTen_phong
            End Get
            Set(ByVal Value As String)
                mTen_phong = Value
            End Set
        End Property
        Public Property Ghi_chu_thi() As String
            Get
                Return mGhi_chu_thi
            End Get
            Set(ByVal Value As String)
                mGhi_chu_thi = Value
            End Set
        End Property
        Public Property OrderBy() As String
            Get
                Return mOrderBy
            End Get
            Set(ByVal Value As String)
                mOrderBy = Value
            End Set
        End Property
        Public ReadOnly Property Ho_ten_order() As String
            Get
                Return ConvertToNumber(strUnicode, Ho_ten)
            End Get
        End Property
#End Region
    End Class
End Namespace
