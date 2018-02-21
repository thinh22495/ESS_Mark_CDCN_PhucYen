Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Namespace Bussines
    Public Class PhanLop_Bussines
#Region "Var"
        ''' <summary>
        ''' ''''''
        ''' </summary>
        ''' <remarks></remarks>
        Private mFiledID As String
        Private mOperator As String
        Private mValue As String
        Private mUserGroup As Integer = 0
        Private mUserID As Integer = 0
        Private mdtSinhVien As DataTable
        Private mType As Boolean = False
        Private strUnicode As String = "AÁÀẢẠÃaáàảạãĂẮẰẲẶẴăắằẳặẵÂẤẨẬẪâấầậẫBbCcDĐđEÉÈẺẼẸeéèẻẽẹÊẾỀỂỄỆêếềểễệFfGgHhIÍÌỈĨỊiíìỉĩịJjKkLlMmNnOÓÒỎÕỌoóòỏõọÔỐỒỔỖỘôốồổỗộƠỚỜỞỠỢơớờởỡợUÚÙỦŨỤuúùủũụƯỨỪỬỮỰưứừửựPpQqSsTtRrXxVvYÝỲỶỸỴyýỳỷỹỵ"
#End Region
#Region "Contructor"
        Public Sub New()

        End Sub
        Public Sub New(ByVal FiledID As String, ByVal Opera As String, ByVal Value As String, ByVal UserID As Integer, ByVal Type As Boolean)
            Try
                mFiledID = FiledID
                mOperator = Opera
                mValue = Value
                mUserID = UserID
                mType = Type
                Dim obj As New PhanLop_DataAccess
                mdtSinhVien = obj.DanhSachSinhVien(mUserID, mUserGroup)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub
#End Region
#Region "Functions And Subs"
        ' Danh sách sinh viên theo điều kiện
        Public Function DanhSachSinhVienLoc() As DataView
            Try
                Dim dv As DataView
                dv = mdtSinhVien.Copy.DefaultView
                Dim dk As String = "1=1"
                If dv.Count <= 0 Then
                    Return dv
                    Exit Function
                End If
                If mFiledID <> "" Then
                    If mOperator <> "like" Then
                        If mType Then ' Nếu kiểu dữ liệu tìm kiếm là kiểu boolean
                            dk += " and " & mFiledID & " " & mOperator & CInt(mValue)
                        Else
                            dk += " and " & mFiledID & " " & mOperator & " '" & mValue & "'"
                        End If
                    Else
                        dk += " and " & mFiledID & " " & mOperator & " '%" & mValue & "%'"
                    End If
                End If
                dv.RowFilter = dk
                Return dv
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Các trường sắp xếp hồ sơ Fix
        Public Function TableHoSoSapXep() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("Chon", GetType(Integer))
                dt.Columns.Add("FieldID", GetType(String))
                dt.Columns.Add("FieldName", GetType(String))

                Dim row As DataRow = dt.NewRow()
                row = dt.NewRow
                row("Chon") = 0
                row("FieldID") = "Ho_ten"
                row("FieldName") = "Họ tên"
                dt.Rows.Add(row)
                'row = dt.NewRow
                'row("Chon") = 0
                'row("FieldID") = "Ngay_sinh"
                'row("FieldName") = "Ngày sinh"
                'dt.Rows.Add(row)
                row = dt.NewRow
                row("Chon") = 0
                row("FieldID") = "ID_gioi_tinh"
                row("FieldName") = "Giới tính"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("Chon") = 0
                row("FieldID") = "Nganh_tuyen_sinh"
                row("FieldName") = "Ngành TS"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("Chon") = 0
                row("FieldID") = "Tong_diem"
                row("FieldName") = "Tổng điểm"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("Chon") = 0
                row("FieldID") = "Khoi_thi"
                row("FieldName") = "Khối thi"
                dt.Rows.Add(row)

                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Các trường điều kiện tìm kiếm
        Public Function TableHoSoTimKiem() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("FieldID", GetType(String))
                dt.Columns.Add("FieldName", GetType(String))
                Dim row As DataRow = dt.NewRow()
                'row("FieldID") = "Ma_sv"
                'row("FieldName") = "Mã sinh viên"
                'dt.Rows.Add(row)
                'row = dt.NewRow
                row("FieldID") = "Ho_ten"
                row("FieldName") = "Họ tên"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "ID_gioi_tinh"
                row("FieldName") = "Giới tính"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "Lop"
                row("FieldName") = "Tên lớp"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "SBD"
                row("FieldName") = "Số báo danh"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "Dang_ky_hoc"
                row("FieldName") = "Nhập học"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "Nganh_tuyen_sinh"
                row("FieldName") = "Ngành tuyển sinh"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "Tong_diem"
                row("FieldName") = "Tổng điểm TS"
                dt.Rows.Add(row)
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Bảng toán tử  (!= =)
        Public Function TableOperator() As DataView
            Try
                Dim dt As New DataTable
                dt.Columns.Add("ID", GetType(Integer))
                dt.Columns.Add("Name", GetType(String))
                For i As Integer = 1 To 7
                    Dim row As DataRow = dt.NewRow()
                    row("ID") = i
                    If i = 1 Then row("Name") = "="
                    If i = 2 Then row("Name") = "!="
                    If i = 3 Then row("Name") = ">"
                    If i = 4 Then row("Name") = ">="
                    If i = 5 Then row("Name") = "<"
                    If i = 6 Then row("Name") = "<="
                    If i = 7 Then row("Name") = "like"
                    dt.Rows.Add(row)
                Next
                Return dt.DefaultView
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TableGioiTinh() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("FieldID", GetType(String))
                dt.Columns.Add("FieldName", GetType(String))
                Dim row As DataRow = dt.NewRow()
                row("FieldID") = "0"
                row("FieldName") = "Nam"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "1"
                row("FieldName") = "Nữ"
                dt.Rows.Add(row)
                row = dt.NewRow
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function TableNhapHoc() As DataTable
            Try
                Dim dt As New DataTable
                dt.Columns.Add("FieldID", GetType(String))
                dt.Columns.Add("FieldName", GetType(String))
                Dim row As DataRow = dt.NewRow()
                row("FieldID") = "0"
                row("FieldName") = "Không"
                dt.Rows.Add(row)
                row = dt.NewRow
                row("FieldID") = "1"
                row("FieldName") = "Có"
                dt.Rows.Add(row)
                row = dt.NewRow
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Danh sach sinh viên theo các truong đã chọn
        Public Function DanhSachSV_SapXep(ByVal dvSinhVien As DataView, ByVal OrderBy As String) As DataView
            Try
                If OrderBy <> "" Then
                    Dim arr() As String
                    arr = OrderBy.Split(",")
                    For i As Integer = 0 To dvSinhVien.Count - 1
                        Dim ValueOrder As String = ""
                        For j As Integer = 0 To arr.Length - 1
                            If Not IsNumeric(dvSinhVien.Table.Rows(i).Item(arr(j)).ToString) Then ' Nếu không phải là dạng số
                                ValueOrder += MappingToNumber(strUnicode, dvSinhVien.Table.Rows(i).Item(arr(j)).ToString)
                            Else
                                ValueOrder += dvSinhVien.Table.Rows(i).Item(arr(j)).ToString
                            End If
                        Next
                        dvSinhVien.Table.Rows(i).Item("Orderby") = ValueOrder
                    Next
                    dvSinhVien.Sort = "Orderby"
                End If
                Return dvSinhVien
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Chuyển đổi một xâu ký tụ về dạng số duc ga
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
#End Region
    End Class
End Namespace
