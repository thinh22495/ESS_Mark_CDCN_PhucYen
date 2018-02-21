Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class LapMa_Bussines
        Private strUnicode As String = "AÁÀẢẠÃaáàảạãĂẮẰẲẶẴăắằẳặẵÂẤẨẬẪâấầậẫBbCcDĐđEÉÈẺẼẸeéèẻẽẹÊẾỀỂỄỆêếềểễệFfGgHhIÍÌỈĨỊiíìỉĩịJjKkLlMmNnOÓÒỎÕỌoóòỏõọÔỐỒỔỖỘôốồổỗộƠỚỜỞỠỢơớờởỡợUÚÙỦŨỤuúùủũụƯỨỪỬỮỰưứừửựPpQqSsTtRrXxVvYÝỲỶỸỴyýỳỷỹỵ"
#Region "Initialize"
        Public Sub New()
        End Sub
#End Region

#Region "Functions And Subs"
        ' Chuyển đổi một xâu ký tụ về dạng số
        Public Function MappingToNumber(ByVal strUnicode As String, ByVal strMapping As String) As String
            Dim i As Integer, str As String = ""
            Dim pos As Object = InStrRev(strMapping, " ")
            If pos > 0 Then
                strMapping = Right(strMapping, Len(strMapping) - pos) + " " + Left(strMapping, pos)
            End If
            For i = 1 To Len(strMapping)
                str = str & Right("00" & InStr(strUnicode, Mid(strMapping, i, 1)), 3)
            Next
            Return str
        End Function
        ' Sắp xếp theo họ tên
        Public Function TableSortHo_ten(ByVal dt As DataTable, Optional ByVal Sorted As Boolean = False) As DataView
            Try
                If Sorted Then Return dt.DefaultView
                dt.Columns.Add("Sort", GetType(Object))
                For i As Integer = 0 To dt.Rows.Count - 1
                    dt.Rows(i).Item("Sort") = MappingToNumber(strUnicode, dt.Rows(i).Item("Ho_ten"))
                Next
                dt.DefaultView.Sort = "Sort"
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Sub UpdateMa_sv(ByVal ID_sv As Integer, ByVal Ma_sv As String)
            Try
                Dim obj As New LapMa_DataAccess
                obj.UpdateMa_sv(ID_sv, Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
        Public Function KiemTra_Ma_sv(ByVal Ma_sv As String) As Boolean
            Try
                Dim obj As New LapMa_DataAccess
                Return obj.KiemTra_Ma_sv(Ma_sv)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
