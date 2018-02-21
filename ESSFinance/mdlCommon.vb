Imports ESS.Objects
Imports ESS.Bussines
Imports System.Net
Module mdlCommon
#Region "Var"
    Public Const gUserName As String = "ESSAdmin"
    Public Const gPassWord As String = "ess10102010"
    Public Const gID_ph As Byte = 5
    Public gFunctionID As Integer = 0
    Public gobjUser As New ESSUsers
    Public gBgColor1 As Color = Color.FromArgb(227, 239, 255)
    Public gBgColor2 As Color = Color.FromArgb(227, 239, 255)
    Public Structure cboData
        Private Display_member As Object
        Private Value_member As Object
        Public Sub New(ByVal vValue As Object, ByVal vText As Object)
            Value_member = vValue
            Display_member = vText
        End Sub
        Public ReadOnly Property GetValue() As Object
            Get
                Return Value_member
            End Get
        End Property
        Public ReadOnly Property GetText() As Object
            Get
                Return Display_member
            End Get
        End Property
    End Structure
#End Region
#Region "FormatGridView"
    Public Sub SetUpDataGridView(ByVal myDataGridView As DataGridView)
        With myDataGridView
            .AutoGenerateColumns = False
            .AutoResizeColumns()
            ' Set DataGridView visual properties (Colors, Fonts, etc.)
            .ColumnHeadersDefaultCellStyle.BackColor = Color.PowderBlue
            .RowHeadersDefaultCellStyle.BackColor = Color.PowderBlue
            .ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Brown
            .ColumnHeadersDefaultCellStyle.Font = New Font("Arial", 10, FontStyle.Regular)

            .EditMode = DataGridViewEditMode.EditOnEnter
            .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
            .ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single
            .CellBorderStyle = DataGridViewCellBorderStyle.Single
            .GridColor = System.Drawing.Color.SandyBrown
            '.BackgroundColor = System.Drawing.Color.ControlDark
            .SelectionMode = DataGridViewSelectionMode.RowHeaderSelect
            .MultiSelect = False
        End With
    End Sub
#End Region    
#Region "Combobox"
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dt As DataTable)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()
            If dt.Columns.Count > 1 Then
                ComboboxName.ValueMember = dt.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dt.Columns(1).ColumnName.ToString
            Else
                ComboboxName.ValueMember = dt.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dt.Columns(0).ColumnName.ToString
            End If
            ComboboxName.DataSource = dt
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dv As DataView)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()
            If dv.Count > 1 Then
                ComboboxName.ValueMember = dv.Table.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dv.Table.Columns(1).ColumnName.ToString
            Else
                ComboboxName.ValueMember = dv.Table.Columns(0).ColumnName.ToString
                ComboboxName.DisplayMember = dv.Table.Columns(0).ColumnName.ToString
            End If
            ComboboxName.DataSource = dv.Table
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub FillCombo(ByVal ComboboxName As ComboBox, ByVal dt As DataTable, ByVal ValueMemberField As String, ByVal DisplayMemberField As String)
        Try
            ComboboxName.DataSource = Nothing
            ComboboxName.Items.Clear()

            ComboboxName.ValueMember = ValueMemberField
            ComboboxName.DisplayMember = DisplayMemberField

            ComboboxName.DataSource = dt
            ComboboxName.SelectedIndex = -1
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Sub Add_Hocky(ByVal ComboBoxName As ComboBox)
        Dim i As Integer
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = 1 To 2
                Arr.Add(New cboData(i, "0" & i))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                If Today.Month >= 9 Or Today.Month <= 1 Then
                    .SelectedValue = 1
                Else
                    .SelectedValue = 2
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub Add_Namhoc(ByVal ComboBoxName As ComboBox)
        Dim i As Integer
        Dim CurYear As Integer = Today.Year
        Dim Arr As New ArrayList
        Try
            If Not ComboBoxName.DataSource Is Nothing Then ComboBoxName.Items.Clear()
            For i = CurYear - 5 To CurYear + 5
                Arr.Add(New cboData(i, i & "-" & i + 1))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                If Today.Month >= 9 Then
                    .SelectedValue = CurYear
                Else
                    .SelectedValue = CurYear - 1
                End If
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Sub Add_LanThi(ByVal ComboBoxName As ComboBox, ByVal So_diem_thi As Integer)
        Dim i As Integer
        Dim Arr As New ArrayList
        Try
            ComboBoxName.DataSource = Nothing
            ComboBoxName.Items.Clear()
            For i = 1 To So_diem_thi
                Arr.Add(New cboData(i, "0" & i))
            Next
            With ComboBoxName
                .DataSource = Arr
                .DisplayMember = "GetText"
                .ValueMember = "GetValue"
                .SelectedValue = 1
            End With
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Function Ky2to10(ByVal Hoc_ky As Byte, ByVal Nam_hoc As String, ByVal Nien_khoa As String) As Integer
        Try
            If Nien_khoa <> "" And Nam_hoc <> "" Then
                Return (CInt(Left(Nam_hoc, 4)) - CInt(Left(Nien_khoa, 4))) * 2 + Hoc_ky
            Else
                Return -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Function
#End Region
#Region "Cac thuc tuc xu ly Control"
    Public Sub HandleNextTAB(ByVal Obj As Object)
        Dim frmESS_Obj As Object
        Try
            For Each frmESS_Obj In Obj.Controls
                If (TypeOf frmESS_Obj Is TextBox) And frmESS_Obj.Focused Then
                    If Not frmESS_Obj.Multiline Then SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is ComboBox) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is CheckBox) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is RadioButton) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is DateTimePicker) And frmESS_Obj.Focused Then
                    SendKeys.Send("{TAB}")
                ElseIf (TypeOf frmESS_Obj Is Panel) Then
                    HandleNextTAB(frmESS_Obj)
                ElseIf (TypeOf frmESS_Obj Is TabControl) Then
                    HandleNextTAB(frmESS_Obj.TabPages(frmESS_Obj.SelectedIndex))
                ElseIf (TypeOf frmESS_Obj Is GroupBox) Then
                    HandleNextTAB(frmESS_Obj)
                End If
            Next frmESS_Obj
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Sub HandleCombo_Delkey(ByVal Obj As Object)
        Dim frmESS_Obj As Object
        Try
            For Each frmESS_Obj In Obj.Controls
                If (TypeOf frmESS_Obj Is ComboBox) And frmESS_Obj.Focused Then
                    If frmESS_Obj.DropDownStyle = ComboBoxStyle.DropDownList Then
                        frmESS_Obj.SelectedIndex = -1
                        frmESS_Obj.SelectedIndex = -1
                    End If
                ElseIf (TypeOf frmESS_Obj Is Panel) Then
                    HandleCombo_Delkey(frmESS_Obj)
                ElseIf (TypeOf frmESS_Obj Is TabControl) Then
                    HandleCombo_Delkey(frmESS_Obj.TabPages(frmESS_Obj.SelectedIndex))
                ElseIf (TypeOf frmESS_Obj Is GroupBox) Then
                    HandleCombo_Delkey(frmESS_Obj)
                End If
            Next frmESS_Obj
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub

    Public Function HandleNumberKey(ByVal eKeyChar As Char, Optional ByVal Str As String = "") As Boolean
        Try
            HandleNumberKey = False
            If Asc(eKeyChar) = 8 Then Return Nothing
            If Str = "" Then
Number:
                If Asc(eKeyChar) < 48 Or Asc(eKeyChar) > 57 Then HandleNumberKey = True
            ElseIf InStr(Str, eKeyChar, CompareMethod.Binary) > 0 Then
                Return Nothing
            Else
                GoTo Number
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Function
#End Region
#Region "SetErro"
    Public Sub SetErrPro(ByVal Obj As Object, ByVal ErrPro As ErrorProvider, Optional ByVal strMessage As String = "", Optional ByVal Align As ErrorIconAlignment = ErrorIconAlignment.MiddleLeft)
        ErrPro.SetIconAlignment(Obj, Align)
        ErrPro.BlinkStyle = ErrorBlinkStyle.NeverBlink
        ErrPro.SetError(Obj, strMessage)
    End Sub
#End Region
#Region "Convert Tiền số sang chữ "
    Function MC(ByVal Tien As String) As String
        Dim Motchu(10) As String
        'Chuyển một số thành chữ
        Motchu(0) = "không "
        Motchu(1) = "một "
        Motchu(2) = "hai "
        Motchu(3) = "ba "
        Motchu(4) = "bốn "
        Motchu(5) = "năm "
        Motchu(6) = "sáu "
        Motchu(7) = "bảy "
        Motchu(8) = "tám "
        Motchu(9) = "chín "
        MC = Motchu(Tien)
    End Function
    Function MC2(ByVal Tien As String) As String
        Dim Motchu(10) As String
        Motchu(0) = "không "
        Motchu(1) = "mốt "
        Motchu(2) = "hai "
        Motchu(3) = "ba "
        Motchu(4) = "bốn "
        Motchu(5) = "lăm "
        Motchu(6) = "sáu "
        Motchu(7) = "bảy "
        Motchu(8) = "tám "
        Motchu(9) = "chín "
        MC2 = Motchu(Tien)
    End Function

    Function SoNhom(ByVal Tien As String) As Byte
        Dim Sodu As Byte
        'Tinh so nhãm 3 cña tiÒn
        Sodu = Len(Tien.ToString) Mod 3
        If Sodu = 0 Then Sodu = 0 Else Sodu = 1
        SoNhom = Len(Tien.ToString) \ 3 + Sodu
    End Function

    Function TachNhom(ByVal Tien As String, ByVal i As Byte) As String
        If SoNhom(Tien) = i Then
            If Len(Tien.ToString) Mod 3 = 0 Then
                TachNhom = Left(Tien.ToString, 3)  'VÝ dô: 900.200
            Else
                TachNhom = Left(Tien.ToString, Len(Tien.ToString) Mod 3)  'VÝ dô: 90.200
            End If
        Else
            TachNhom = Mid(Tien.ToString, Len(Tien.ToString) - i * 3 + 1, 3)
        End If
    End Function

    Function XetSo(ByVal Tien As String) As Byte
        Dim So1, So2, So3 As Byte
        So1 = CType(Left(Tien.ToString, 1), Byte)
        So2 = CType(Mid(Tien.ToString, 2, 1), Byte)
        So3 = CType(Right(Tien.ToString, 1), Byte)
        If Tien = 0 Then XetSo = 0
        If So1 = 0 And So2 = 0 And So3 > 0 Then XetSo = 1
        If So1 = 0 And So2 = 1 And So3 > 0 Then XetSo = 2
        If So1 = 0 And So2 = 1 And So3 = 0 Then XetSo = 3
        If So1 > 0 And So2 = 1 And So3 = 0 Then XetSo = 4
        If So1 > 0 And So2 = 1 And So3 > 0 Then XetSo = 5
        If So1 > 0 And So2 > 1 And So3 = 0 Then XetSo = 6
        If So1 > 0 And So2 > 1 And So3 > 0 Then XetSo = 7
        If So1 > 0 And So2 = 0 And So3 = 0 Then XetSo = 8
        If So1 > 0 And So2 = 0 And So3 > 0 Then XetSo = 9
        If So1 = 0 And So2 > 1 And So3 = 0 Then XetSo = 10
        If So1 = 0 And So2 > 1 And So3 > 0 Then XetSo = 11
    End Function

    Function XetSoMot(ByVal Tien As String) As Byte
        Dim So1, So2, So3 As Byte
        So1 = Left(Tien.ToString, 1)
        So2 = Mid(Tien.ToString, 2, 1)
        So3 = Right(Tien.ToString, 1)
        If So1 > 0 And So2 = 1 And So3 = 0 Then XetSoMot = 4
        If So1 > 0 And So2 = 1 And So3 > 0 Then XetSoMot = 5
        If So1 > 0 And So2 > 1 And So3 = 0 Then XetSoMot = 6
        If So1 > 0 And So2 > 1 And So3 > 0 Then XetSoMot = 7
        If So1 > 0 And So2 = 0 And So3 = 0 Then XetSoMot = 8
        If So1 > 0 And So2 = 0 And So3 > 0 Then XetSoMot = 9
    End Function

    Function BaChuMot(ByVal Tien As String) As String 'Sè ch÷ cña tiÒn <=3
        Dim Temp As String = ""
        Dim i, j As Byte
        i = Len(Tien.ToString)
        If Tien = 0 Then Temp = "Không"
        If i = 1 Then
            Temp = MC(Tien)
        Else
            If i = 2 Then
                If Left(Tien.ToString, 1) = 1 Then
                    If Right(Tien.ToString, 1) = 0 Then
                        Temp = "mười "
                    Else
                        If Right(Tien.ToString, 1) = 1 Then
                            Temp = "mười " & MC(Right(Tien.ToString, 1))
                        Else
                            Temp = "mười " & MC2(Right(Tien.ToString, 1))
                        End If
                    End If
                Else
                    If Right(Tien.ToString, 1) = 0 Then
                        Temp = MC(Left(Tien.ToString, 1)) & "mươi "
                    Else
                        Temp = MC(Left(Tien.ToString, 1)) & "mươi " & MC2(Right(Tien.ToString, 1))
                    End If
                End If
                If Left(Tien.ToString, 1) > 1 And Right(Tien.ToString, 1) > 0 Then Temp = MC(Left(Tien.ToString, 1)) & "mươi " & MC2(Right(Tien.ToString, 1))
            Else
                j = XetSoMot(Tien)
                If j = 4 Then Temp = MC(Left(Tien.ToString, 1)) & "trăm mười "
                If j = 5 And Right(Tien.ToString, 1) = 5 Then
                    Temp = MC(Left(Tien.ToString, 1)) & "trăm mười " & MC2(Right(Tien.ToString, 1))
                ElseIf j <> 4 Then
                    Temp = MC(Left(Tien.ToString, 1)) & "trăm mười " & MC(Right(Tien.ToString, 1))
                End If
                If j = 6 Then Temp = MC(Left(Tien.ToString, 1)) & "trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi "
                If j = 7 Then Temp = MC(Left(Tien.ToString, 1)) & "trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi " & MC2(Right(Tien.ToString, 1))
                If j = 8 Then Temp = MC(Left(Tien.ToString, 1)) & "trăm "
                If j = 9 Then Temp = MC(Left(Tien.ToString, 1)) & "trăm linh " & MC(Right(Tien.ToString, 1))
            End If
        End If
        Return Temp
    End Function

    Function BaChuHai(ByVal Tien As String) As String
        Dim Temp As String = ""
        Dim j As Byte
        j = XetSo(Tien)
        Select Case j
            Case 0
                Temp = ""
            Case 1
                Temp = "không trăm linh " & MC(Right(Tien.ToString, 1))
            Case 2
                If Right(Tien.ToString, 1) = 1 Then
                    Temp = "không trăm mười " & MC(Right(Tien.ToString, 1))
                Else
                    Temp = "không trăm mười " & MC2(Right(Tien.ToString, 1))
                End If
            Case 3
                Temp = "không trăm mười "
            Case 4
                Temp = MC(Left(Tien.ToString, 1)) & "trăm mười "
            Case 5
                If Right(Tien.ToString, 1) = 1 Then
                    Temp = MC(Left(Tien.ToString, 1)) & "trăm mười " & MC(Right(Tien.ToString, 1))
                Else
                    Temp = MC(Left(Tien.ToString, 1)) & "trăm mười " & MC2(Right(Tien.ToString, 1))
                End If
            Case 6
                Temp = MC(Left(Tien.ToString, 1)) & "trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi "
            Case 7
                Temp = MC(Left(Tien.ToString, 1)) & "trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi " & MC2(Right(Tien.ToString, 1))
            Case 8
                Temp = MC(Left(Tien.ToString, 1)) & "trăm "
            Case 9
                Temp = MC(Left(Tien.ToString, 1)) & "trăm linh " & MC(Right(Tien.ToString, 1))
            Case 10
                Temp = "không trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi "
            Case 11
                Temp = "không trăm " & MC(Mid(Tien.ToString, 2, 1)) & "mươi " & MC2(Right(Tien.ToString, 1))
        End Select
        Return Temp
    End Function
    Function NT(ByVal Tien As String, ByVal j As Byte) As String
        Dim Temp As String = ""
        If Tien = 0 Then
            Temp = ""
        Else
            Select Case j
                Case 2
                    Temp = "nghìn "
                Case 3
                    Temp = "triệu "
                Case 4
                    Temp = "tỷ "
            End Select
        End If
        Return Temp
    End Function
    Function ChuyenChu(ByVal Tien As String) As String
        Dim Temp As String = ""
        If Tien = "" Then Tien &= "0"
        Tien = Math.Abs(CType(Tien, Long))
        Select Case SoNhom(Tien)
            Case 1
                Temp = BaChuMot(Tien)
            Case 2
                Temp = BaChuMot(Int((TachNhom(Tien, 2)))) & NT(TachNhom(Tien, 2), 2) & BaChuHai(TachNhom(Tien, 1))
            Case 3
                Temp = BaChuMot(Int((TachNhom(Tien, 3)))) & NT(TachNhom(Tien, 3), 3) & BaChuHai((TachNhom(Tien, 2))) & NT(TachNhom(Tien, 2), 2) & BaChuHai(TachNhom(Tien, 1))
            Case 4
                Temp = BaChuMot(Int((TachNhom(Tien, 4)))) & NT(TachNhom(Tien, 4), 4) & BaChuHai((TachNhom(Tien, 3))) & NT(TachNhom(Tien, 3), 3) & BaChuHai((TachNhom(Tien, 2))) & NT(TachNhom(Tien, 2), 2) & BaChuHai(TachNhom(Tien, 1))
            Case Is > 4
                Temp = "không chuyển được vì số đã có vựơt quá phạm vi cho phép"
        End Select
        If Trim(Temp) <> "" Then
            Temp = Temp.Substring(0, 1).ToUpper & Temp.Substring(1, Temp.Length - 1)
        End If
        Return Temp
    End Function

    Function SoTp(ByVal Tien As String) As String
        Dim i As Byte
        'Tien = Int(Tien)
        i = Len(Tien.ToString)
        If i = Len(Tien.ToString) Then
            Tien = 0
        Else
            Tien = CType(Mid(Tien.ToString, i + 2, 2), Long)
        End If
        SoTp = BaChuMot(Tien)
    End Function

    Function DVNgoai_te(ByVal strNgoai_te As String) As String
        Select Case strNgoai_te.ToUpper
            Case "USD"
                Return "đô la"
            Case Else
                Return "đồng"
        End Select
    End Function
#End Region
#Region " Quyền truy cập , log"
    Public Sub SetQuyenTruyCap(Optional ByVal cmdSave As Object = Nothing, Optional ByVal cmdAdd As Object = Nothing, Optional ByVal cmdEdit As Object = Nothing, Optional ByVal cmdDelete As Object = Nothing)
        Dim idx_quyen As Integer
        idx_quyen = gobjUser.ESSQuyen.Tim_idx(gFunctionID)
        If idx_quyen >= 0 Then
            If gobjUser.ESSQuyen.Quyen(idx_quyen).Them = 0 Then
                If Not cmdAdd Is Nothing Then cmdAdd.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.ESSQuyen.Quyen(idx_quyen).Sua = 0 Then
                If Not cmdEdit Is Nothing Then cmdEdit.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
            If gobjUser.ESSQuyen.Quyen(idx_quyen).Xoa = 0 Then
                If Not cmdDelete Is Nothing Then cmdDelete.Enabled = False
                If Not cmdSave Is Nothing Then cmdSave.Enabled = False
            End If
        End If
    End Sub
    Public Sub SaveLog(ByVal Su_kien As LoaiSuKien, ByVal Noi_dung As String)
        Dim objSuKien As New ESSSuKienNguoiDung
        Dim clsSuKien As New SuKienNguoiDung_Bussines
        Dim May_tram As String
        'Get IP Address
        Dim h As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
        May_tram = CType(h.AddressList.GetValue(0), IPAddress).ToString
        objSuKien.ID_phan_he = gID_ph
        objSuKien.Su_kien = Su_kien
        objSuKien.UserName = gobjUser.UserName
        objSuKien.Thoi_diem = Now
        objSuKien.May_tram = May_tram
        objSuKien.Noi_dung = Noi_dung
        objSuKien.Chuc_nang = gFunctionID
        clsSuKien.ThemMoi_ESSSuKienNguoiDung(objSuKien)
    End Sub
#End Region
End Module
