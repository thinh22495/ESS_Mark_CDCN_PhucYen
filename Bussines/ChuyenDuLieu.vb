Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports ESS.Objects
Imports ESS.DataAccess
Imports System.IO
Namespace Bussines
    Public Class ChuyenDuLieu_Bussines
        Inherits HoSo_Bussines
        Dim UVowels As String = ChrW(&HE1) & ChrW(&HE0) & ChrW(&H1EA3) & ChrW(&HE3) & ChrW(&H1EA1) & ChrW(&H103) & ChrW(&H1EAF) & ChrW(&H1EB1) & ChrW(&H1EB3) & ChrW(&H1EB5) & ChrW(&H1EB7) & ChrW(&HE2) & ChrW(&H1EA5) & ChrW(&H1EA7) & ChrW(&H1EA9) & ChrW(&H1EAB) & ChrW(&H1EAD) & ChrW(&HE9) & ChrW(&HE8) & ChrW(&H1EBB) & _
                                          ChrW(&H1EBD) & ChrW(&H1EB9) & ChrW(&HEA) & ChrW(&H1EBF) & ChrW(&H1EC1) & ChrW(&H1EC3) & ChrW(&H1EC5) & ChrW(&H1EC7) & ChrW(&HED) & ChrW(&HEC) & ChrW(&H1EC9) & ChrW(&H129) & ChrW(&H1ECB) & ChrW(&HF3) & ChrW(&HF2) & ChrW(&H1ECF) & ChrW(&HF5) & ChrW(&H1ECD) & ChrW(&HF4) & ChrW(&H1ED1) & _
                                          ChrW(&H1ED3) & ChrW(&H1ED5) & ChrW(&H1ED7) & ChrW(&H1ED9) & ChrW(&H1A1) & ChrW(&H1EDB) & ChrW(&H1EDD) & ChrW(&H1EDF) & ChrW(&H1EE1) & ChrW(&H1EE3) & ChrW(&HFA) & ChrW(&HF9) & ChrW(&H1EE7) & ChrW(&H169) & ChrW(&H1EE5) & ChrW(&H1B0) & ChrW(&H1EE9) & ChrW(&H1EEB) & ChrW(&H1EED) & ChrW(&H1EEF) & _
                                          ChrW(&H1EF1) & ChrW(&HFD) & ChrW(&H1EF3) & ChrW(&H1EF7) & ChrW(&H1EF9) & ChrW(&H1EF5) & ChrW(&H111) & ChrW(&HC1) & ChrW(&HC0) & ChrW(&H1EA2) & ChrW(&HC3) & ChrW(&H1EA0) & ChrW(&H102) & ChrW(&H1EAE) & ChrW(&H1EB0) & ChrW(&H1EB2) & ChrW(&H1EB4) & ChrW(&H1EB6) & ChrW(&HC2) & ChrW(&H1EA4) & _
                                          ChrW(&H1EA6) & ChrW(&H1EA8) & ChrW(&H1EAA) & ChrW(&H1EAC) & ChrW(&HC9) & ChrW(&HC8) & ChrW(&H1EBA) & ChrW(&H1EBC) & ChrW(&H1EB8) & ChrW(&HCA) & ChrW(&H1EBE) & ChrW(&H1EC0) & ChrW(&H1EC2) & ChrW(&H1EC4) & ChrW(&H1EC6) & ChrW(&HCD) & ChrW(&HCC) & ChrW(&H1EC8) & ChrW(&H128) & ChrW(&H1ECA) & _
                                          ChrW(&HD3) & ChrW(&HD2) & ChrW(&H1ECE) & ChrW(&HD5) & ChrW(&H1ECC) & ChrW(&HD4) & ChrW(&H1ED0) & ChrW(&H1ED2) & ChrW(&H1ED4) & ChrW(&H1ED6) & ChrW(&H1ED8) & ChrW(&H1A0) & ChrW(&H1EDA) & ChrW(&H1EDC) & ChrW(&H1EDE) & ChrW(&H1EE0) & ChrW(&H1EE2) & ChrW(&HDA) & ChrW(&HD9) & ChrW(&H1EE6) & _
                                          ChrW(&H168) & ChrW(&H1EE4) & ChrW(&H1AF) & ChrW(&H1EE8) & ChrW(&H1EEA) & ChrW(&H1EEC) & ChrW(&H1EEE) & ChrW(&H1EF0) & ChrW(&HDD) & ChrW(&H1EF2) & ChrW(&H1EF6) & ChrW(&H1EF8) & ChrW(&H1EF4) & ChrW(&H110)
        Public Sub New()

        End Sub

#Region "Function "
        ' Chuyển tù bảng nguồn sang bảng dữ liệu mới ( bảng hồ sơ )
        Public Function ChuyenSrcToDes(ByVal dtSrc As DataTable, ByVal strFields As String, ByVal ArrGoal() As String, ByVal ArrSource(,) As String, ByVal ArrGoalType() As String, ByVal ArrGoalSize() As String, ByVal numColumn As Integer, ByVal UserID As Integer, ByRef dtError As DataTable) As DataTable
            Try
                Dim Result As Object
                Dim dtGoal As New DataTable
                ' Cấu trúc bảng HoSo rỗng
                dtGoal = LoadCauTrucHoSoSinhVien()
                Dim dr As DataRow
                Dim k As Integer = 0
                Dim i As Integer = 0
                Dim j As Integer = 0
                Dim StrTemp As String = ""
                ' Bảng thông báo dữ liệu bị lỗi   
                dtError = New DataTable
                Dim drError As DataRow
                dtError.Columns.Add("Row")
                dtError.Columns.Add("Field")
                dtError.Columns.Add("DTable")
                dtError.Columns.Add("Error")
                dtError.Columns.Add("Value")
                ' Bang danh mục theo các trường dữ liệu truyền vào
                Dim dvDM As New DataView
                'strFields = "'" & strFields & "'"
                'dvDM = getDMTables(strFields).DefaultView
                strFields = strFields.Replace("''", "'")
                Dim cls As New DanhMuc_Bussines
                Dim str As String = "SELECT DISTINCT FieldID,DTable,DFieldID,DFieldName " & _
                                    "FROM SYS_TimKiemTruong " & _
                                    "WHERE Fieldgroup=203 AND DTable<>''  " & _
                                    "AND FieldID IN (" & strFields & ")"
                dvDM = cls.LoadDanhMuc(str).DefaultView
                ' Xác định các cột                
                For i = 0 To dtSrc.Rows.Count - 1
                    dr = dtGoal.NewRow
                    With dtSrc.Rows(i)
                        For j = 0 To ArrGoal.Length - 1
                            If Not ArrGoal(j) Is Nothing Then
                                StrTemp = ""
                                For k = 0 To numColumn
                                    If IsDBNull(ArrSource(j, k)) Or ArrSource(j, k) Is Nothing Then Exit For
                                    StrTemp = StrTemp.Trim & " " & .Item(ArrSource(j, k)).ToString.Trim
                                Next
                                k = 0
                                'Kiem tra viec trung lap du lieu thong qua cac truong da chon
                                If ArrGoal(j).ToUpper <> "HOTEN_ORDER" Then
                                    Dim MsgErr As String = ""
                                    Dim DTable As String = ""
                                    Result = MappingData(ArrGoal(j), ArrGoalType(j), ArrGoalSize(j), StrTemp, dvDM, DTable, MsgErr)
                                    If Result Is DBNull.Value Then
                                        If StrTemp.Trim <> "" Then
                                            drError = dtError.NewRow
                                            drError("Row") = i
                                            drError("Error") = MsgErr
                                            drError("Field") = ArrGoal(j)
                                            drError("DTable") = DTable
                                            drError("Value") = StrTemp
                                            dtError.Rows.Add(drError)
                                        End If
                                    Else
                                        dr.Item(ArrGoal(j)) = Result
                                    End If
                                End If
                            End If
                        Next
                    End With
                    dr.Item("UserID") = UserID
                    dtGoal.Rows.Add(dr)
                Next
                dtGoal.DefaultView.AllowNew = False
                dtGoal.DefaultView.AllowEdit = True
                dtGoal.DefaultView.AllowDelete = True
                Return dtGoal
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        ' Mapping dữ liệu
        Public Function MappingData(ByVal FieldID As String, ByVal FieldType As String, ByVal FieldSize As Long, ByVal strValue As String, ByVal dv As DataView, ByRef DTable As String, ByRef MsgErr As String) As Object
            Try
                Dim Result As Object
                Select Case FieldID.ToUpper
                    Case "ID_GIOI_TINH", "GIOI_TINH" 'Kieu gioi tinh
                        Result = getGioi_tinh(strValue.Trim)
                    Case Else 'Kieu danh muc                        
                        If dv Is Nothing Then Result = System.DBNull.Value
                        dv.Sort = "FieldID"
                        dv.RowFilter = "FieldID='" & FieldID & "' "
                        If dv.Count > 0 Then
                            strValue = strValue.Replace(".", " ")
                            strValue = DisposeStr(strValue) 'Xoá dấu cách vô nghĩa
                            strValue = strValue.Trim
                            DTable = dv.Item(0).Item("DTable")
                            Result = getDMValue(dv.Item(0).Item("DTable"), dv.Item(0).Item("DFieldID"), dv.Item(0).Item("DFieldName"), strValue.Trim)
                            If Result = "" Then MsgErr = """" + strValue + """" + " không có trong bảng danh mục " + """" + dv.Item(0).Item("DTable").ToString + """"
                        Else 'Cac kieu du lieu khac
                            Select Case FieldType
                                Case "float", "decimal", "int", "money", "real", "smallint", "tinyint" 'Kieu du lieu so
                                    If IsNumeric(strValue) Then
                                        Result = strValue
                                    Else
                                        MsgErr = "Dữ liệu không đúng kiểu số !"
                                        Result = System.DBNull.Value
                                    End If
                                Case "datetime", "date" 'Kieu du lieu ngay thang
                                    'Xu ly truong ngay thang
                                    If strValue.Trim <> "" Then
                                        strValue = strValue.Replace(".", "/").Replace("-", "/")
                                        If IsDate(strValue) Then
                                            Result = strValue
                                        ElseIf strValue.Trim.Length = 6 AndAlso strValue.Trim.Replace(".", "").Replace("-", "").Replace("/", "").Length = 6 Then
                                            Dim Ngay_sinh As String = strValue.Trim.Replace(".", "").Replace("-", "").Replace("/", "")
                                            Result = Left(Ngay_sinh, 2) & "/" & Ngay_sinh.Substring(2, 2) & "/19" & Right(Ngay_sinh, 2)
                                        Else
                                            MsgErr = "Dữ liệu không đúng kiểu ngày tháng !"
                                            Result = System.DBNull.Value
                                        End If
                                    Else
                                        MsgErr = "Không đọc được dữ liệu kiểu ngày tháng !"
                                        Result = System.DBNull.Value
                                    End If
                                Case Else 'Kieu du lieu Text
                                    If strValue.Length > FieldSize Then
                                        strValue = strValue.Substring(0, FieldSize)
                                        MsgErr = "Dữ liệu dài quá phải mở rộng trường dữ liệu"
                                    End If
                                    If InStr(FieldID, "ho_ten", CompareMethod.Text) > 0 Then
                                        Result = StandStr(strValue.Trim, " ")
                                    Else
                                        Result = strValue.Trim
                                    End If
                            End Select
                        End If
                End Select
                If Result.ToString = "" Then Result = DBNull.Value
                Return Result
            Catch ex As Exception
                Return DBNull.Value
            End Try
        End Function
        Public Function DisposeStr(ByVal Str As String) As String
            Dim i As Integer
            Dim St As Object = ""
            If Str = "" Or IsDBNull(Str) Then Return ""
            Str = Str.Trim(" ")
            Str = Str.Replace("""", """").Replace("'", "''") 'Replace " -> "", ' -> ''
            If Len(Str) > 0 Then
                For i = 1 To Len(Str)
                    If i = 1 Then
                        St = UpperUniChar(Left(Str, 1))
                    ElseIf Mid(Str, i - 1, 1) = " " And Mid(Str, i, 1) = " " Then
                    ElseIf Mid(Str, i - 1, 1) = " " And Mid(Str, i, 1) <> "" Then
                        St = St + UpperUniChar(Mid(Str, i, 1))
                    Else
                        St = St + Mid(Str, i, 1)
                    End If
                Next
            End If
            Return St
        End Function
        Private Function UpperUniChar(ByVal ch As Object) As String
            ' Return the Uppercase for a given vowel or dd
            Dim pos As Integer   ' Position of character in Unicode vowel list
            ' Locate the character in list of Unicode vowels
            pos = InStr(UVowels, ch)
            If (pos > 67) Then
                UpperUniChar = ch  ' It's already uppercase - leave it alone
            ElseIf (pos > 0) Then
                ' It's a Lowercase Unicode Vowel - so get the corresponding Uppercase vowel in the list
                UpperUniChar = Mid(UVowels, pos + 67, 1)
            Else
                ' It's just a normal ANSI character
                UpperUniChar = UCase(ch)
            End If
        End Function
        ' Chuyển đổi kiểu dũ liệu giới tính
        Private Function getGioi_tinh(ByVal StrValue As String) As Integer
            Select Case StrValue.ToUpper
                Case "0", "T", "NAM", "TRUE"
                    Return 0
                Case Else
                    Return 1
            End Select
        End Function
        ' Chuẩn hoá một xâu bất kỳ, (Cắt các ký tự trắng dư thừa)
        Public Function StandStr(ByVal Xau_ky_tu As String, ByVal Ky_tu_phan_cach As Char) As String
            Dim s As String = Trim(Xau_ky_tu)
            Dim sk As String = Ky_tu_phan_cach & Ky_tu_phan_cach
            If s = "" Then Return s
            While InStr(s, sk, CompareMethod.Binary) > 0
                s = Replace(s, sk, Ky_tu_phan_cach)
            End While
            If s.PadLeft(1) = Ky_tu_phan_cach Then s = s.Substring(1, s.Length - 1)
            If s.PadRight(1) = Ky_tu_phan_cach Then s = s.Substring(0, s.Length - 1)
            Return s
        End Function

        Public Function LoadHoSoTemp(ByVal UserID As Integer) As DataTable
            Try
                Dim dt As DataTable
                Dim obj As New ChuyenDuLieu_DataAccess
                dt = obj.LoadHoSoTemp(UserID)
                dt.Columns.Add("Chon", GetType(Boolean))
                For Each r As DataRow In dt.Rows
                    If r("ID_gioi_tinh") = 0 Then
                        r("Gioi_tinh") = "Nam"
                    Else
                        r("Gioi_tinh") = "Nữ"
                    End If
                    r("Chon") = False
                Next
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function LoadCauTrucHoSoSinhVien() As DataTable
            Try
                Dim dt As DataTable
                Dim obj As New ChuyenDuLieu_DataAccess
                dt = obj.LoadCauTrucHoSoSinhVien()
                Return dt
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDataSource(ByVal TableName As String) As DataTable
            Try
                Dim obj As New ChuyenDuLieu_DataAccess
                Dim dtDL As DataTable = obj.getDataSource(TableName)
                'dtDL.Columns.Add("NameVietNam", GetType(String))
                'For i As Integer = 0 To dtDL.Rows.Count - 1
                '    If i = 0 Then dtDL.Rows(i).Item("NameVietNam") = "ID_sv"
                '    If i = 1 Then dtDL.Rows(i).Item("NameVietNam") = "Ảnh"
                '    If i = 2 Then dtDL.Rows(i).Item("NameVietNam") = "Mã sinh viên"
                '    If i = 3 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên"
                '    If i = 4 Then dtDL.Rows(i).Item("NameVietNam") = "Ngày sinh"
                '    If i = 5 Then dtDL.Rows(i).Item("NameVietNam") = "Giới tinh"
                '    If i = 6 Then dtDL.Rows(i).Item("NameVietNam") = "Dân tộc"
                '    If i = 7 Then dtDL.Rows(i).Item("NameVietNam") = "Quốc tịch"
                '    If i = 8 Then dtDL.Rows(i).Item("NameVietNam") = "Tôn giáo"
                '    If i = 9 Then dtDL.Rows(i).Item("NameVietNam") = "Thành phần XT"
                '    If i = 10 Then dtDL.Rows(i).Item("NameVietNam") = "Ngày vào đoàn"
                '    If i = 11 Then dtDL.Rows(i).Item("NameVietNam") = "Ngày vào đảng"
                '    If i = 12 Then dtDL.Rows(i).Item("NameVietNam") = "Quê quán"
                '    If i = 13 Then dtDL.Rows(i).Item("NameVietNam") = "Tỉnh nơi sinh"
                '    If i = 14 Then dtDL.Rows(i).Item("NameVietNam") = "Địa chỉ TT"
                '    If i = 15 Then dtDL.Rows(i).Item("NameVietNam") = "Xã phường TT"

                '    If i = 16 Then dtDL.Rows(i).Item("NameVietNam") = "Huyện TT"
                '    If i = 17 Then dtDL.Rows(i).Item("NameVietNam") = "Tỉnh TT"
                '    If i = 18 Then dtDL.Rows(i).Item("NameVietNam") = "Đối tượng TC"
                '    If i = 19 Then dtDL.Rows(i).Item("NameVietNam") = "Đối tượng TS"
                '    If i = 20 Then dtDL.Rows(i).Item("NameVietNam") = "Điện thoại NR"
                '    If i = 21 Then dtDL.Rows(i).Item("NameVietNam") = "Nhóm ĐT"
                '    If i = 22 Then dtDL.Rows(i).Item("NameVietNam") = "Địa chỉ BT"
                '    If i = 23 Then dtDL.Rows(i).Item("NameVietNam") = "Khu vực TS"
                '    If i = 24 Then dtDL.Rows(i).Item("NameVietNam") = "Đối tượng DT"
                '    If i = 25 Then dtDL.Rows(i).Item("NameVietNam") = "Điểm 1"
                '    If i = 26 Then dtDL.Rows(i).Item("NameVietNam") = "Điểm 2"
                '    If i = 27 Then dtDL.Rows(i).Item("NameVietNam") = "Điểm 3"
                '    If i = 28 Then dtDL.Rows(i).Item("NameVietNam") = "Điểm 4"
                '    If i = 29 Then dtDL.Rows(i).Item("NameVietNam") = "Tổng điểm"
                '    If i = 30 Then dtDL.Rows(i).Item("NameVietNam") = "SBD"
                '    If i = 31 Then dtDL.Rows(i).Item("NameVietNam") = "Ngành TS"

                '    If i = 32 Then dtDL.Rows(i).Item("NameVietNam") = "Khối thi"
                '    If i = 33 Then dtDL.Rows(i).Item("NameVietNam") = "Xếp loại HT"
                '    If i = 34 Then dtDL.Rows(i).Item("NameVietNam") = "Xếp loại HK"
                '    If i = 35 Then dtDL.Rows(i).Item("NameVietNam") = "Xếp loại TN"
                '    If i = 36 Then dtDL.Rows(i).Item("NameVietNam") = "Năm TN"
                '    If i = 37 Then dtDL.Rows(i).Item("NameVietNam") = "Điểm thưởng"
                '    If i = 38 Then dtDL.Rows(i).Item("NameVietNam") = "Lý do thưởng"
                '    If i = 39 Then dtDL.Rows(i).Item("NameVietNam") = "Khen thưởng kỷ luật"
                '    If i = 40 Then dtDL.Rows(i).Item("NameVietNam") = "Quá trình HTLD"
                '    If i = 41 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên cha"
                '    If i = 42 Then dtDL.Rows(i).Item("NameVietNam") = "Quốc tịch cha"
                '    If i = 43 Then dtDL.Rows(i).Item("NameVietNam") = "Dân tộc cha"
                '    If i = 44 Then dtDL.Rows(i).Item("NameVietNam") = "Tôn giáo cha"
                '    If i = 45 Then dtDL.Rows(i).Item("NameVietNam") = "Hộ khẩu cha"
                '    If i = 46 Then dtDL.Rows(i).Item("NameVietNam") = "Hoạt động CT cha"
                '    If i = 47 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên mẹ"
                '    If i = 48 Then dtDL.Rows(i).Item("NameVietNam") = "Quốc tịch mẹ"
                '    If i = 49 Then dtDL.Rows(i).Item("NameVietNam") = "Dân tộc mẹ"
                '    If i = 50 Then dtDL.Rows(i).Item("NameVietNam") = "Tôn giáo mẹ"
                '    If i = 51 Then dtDL.Rows(i).Item("NameVietNam") = "Hộ khẩu mẹ"
                '    If i = 52 Then dtDL.Rows(i).Item("NameVietNam") = "Hoạt động CT mẹ"

                '    If i = 53 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên VC"
                '    If i = 54 Then dtDL.Rows(i).Item("NameVietNam") = "Quốc tịch VC"
                '    If i = 55 Then dtDL.Rows(i).Item("NameVietNam") = "Dân tộc VC"
                '    If i = 56 Then dtDL.Rows(i).Item("NameVietNam") = "Tôn giáo VC"
                '    If i = 57 Then dtDL.Rows(i).Item("NameVietNam") = "Hộ khẩu VC"
                '    If i = 58 Then dtDL.Rows(i).Item("NameVietNam") = "Hoạt động CTVC"

                '    If i = 59 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên NN anh em"
                '    If i = 60 Then dtDL.Rows(i).Item("NameVietNam") = "Đăng ký học"
                '    If i = 61 Then dtDL.Rows(i).Item("NameVietNam") = "Họ tên SX"
                '    If i = 62 Then dtDL.Rows(i).Item("NameVietNam") = "Chuyên ngành"
                '    If i = 63 Then dtDL.Rows(i).Item("NameVietNam") = "Lớp"
                '    If i = 64 Then dtDL.Rows(i).Item("NameVietNam") = "Ngoại ngữ"

                '    If i = 65 Then dtDL.Rows(i).Item("NameVietNam") = "UserID"
                '    If i = 66 Then dtDL.Rows(i).Item("NameVietNam") = "Ngày nhập học"
                '    If i = 67 Then dtDL.Rows(i).Item("NameVietNam") = "UserID nhập học"
                '    If i = 68 Then dtDL.Rows(i).Item("NameVietNam") = "UserID tiếp nhận"
                'Next
                Return dtDL
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function getDataStruct(ByVal TableName As String) As DataTable
            Try
                Dim obj As New ChuyenDuLieu_DataAccess
                Dim dtDL As DataTable = obj.getDataSource(TableName)
                Return dtDL
            Catch ex As Exception
                Throw ex
            End Try
        End Function
        Public Function getDMTables(ByVal strFields As String) As DataTable
            Try
                Dim obj As New ChuyenDuLieu_DataAccess
                Return obj.getDMTables(strFields)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        ' Láy giá trị danh mục 
        Public Function getDMValue(ByVal DTable As String, ByVal DFieldID As String, ByVal DFieldName As String, ByVal strValue As String) As String
            Try
                If strValue = "" Then Return ""
                Dim obj As New ChuyenDuLieu_DataAccess
                Dim dt As DataTable = obj.getDMValueTen(DTable, DFieldID, DFieldName, strValue)
                If dt.Rows.Count <= 0 Then
                    Dim dtma As DataTable
                    dtma = obj.getColumName_Ma(DTable)
                    Dim DFieldMa As String = ""
                    If dtma.Rows.Count > 0 Then DFieldMa = dtma.Rows(0)("name")
                    If DFieldMa <> "" Then
                        dt = obj.getDMValueMa(DTable, DFieldID, DFieldMa, DFieldName, strValue)
                    Else
                        Dim dtID As DataTable
                        dtID = obj.getColumName_ID(DTable)
                        If dtID.Rows.Count > 0 Then DFieldMa = dtID.Rows(0)("name")
                        dt = obj.getDMValueMa(DTable, DFieldID, DFieldMa, DFieldName, strValue)
                    End If
                End If
                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0).Item(0).ToString
                Else
                    Return ""
                End If
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace
