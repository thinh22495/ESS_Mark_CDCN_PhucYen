Imports ESS.Objects
Imports ESS.Bussines
Imports System.Net
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid
Module mdlCommon
    Public Const gUserName As String = "ESSAdmin"
    Public Const gPassWord As String = "ess10102012"
    Public Const gID_ph As Byte = 9
    Public gFunctionID As Integer = 0
    Public gobjUser As New ESSUsers
    Public gBgColor1 As Color = Color.FromArgb(247, 245, 241)
    Public gBgColor2 As Color = Color.FromArgb(247, 245, 241)

    Public Function GetFilteredDataView(ByVal grid As GridControl) As DataView
        'by anhnt: get dataview from GridControl when filter
        Dim colView As ColumnView = CType(grid.MainView, ColumnView)
        If colView Is Nothing Then
            Return Nothing
        End If
        If colView.ActiveFilter Is Nothing OrElse Not colView.ActiveFilterEnabled OrElse colView.ActiveFilter.Expression = "" Then
            Return TryCast(colView.DataSource, DataView)
        End If

        Dim table As DataTable = DirectCast(colView.DataSource, DataView).Table
        Dim filteredDataView As New DataView(table)
        filteredDataView.RowFilter = DevExpress.Data.Filtering.CriteriaToWhereClauseHelper.GetDataSetWhere(colView.ActiveFilterCriteria)
        Return filteredDataView
    End Function
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

    Public Sub FillCombo(ByRef ComboboxName As ComboBox, ByVal dt As DataTable)
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
            If dv.Table.Columns.Count > 1 Then
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
End Module
