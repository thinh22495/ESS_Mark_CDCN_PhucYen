Imports System.Drawing.Drawing2D
Imports ESS.Bussines
Imports ESS.Objects
Imports DevExpress.XtraGrid.Views.Base
Public Class cmbFieldGroup
    Private Loader As Boolean = False
    Private dv As DataView ' Các trường tìm kiếm
#Region "Form Event"
    Private Sub frmESS_TimKiemNangCao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If gobjUser.UserGroup = -1 Then
            btnEdit.Enabled = True
        Else
            btnEdit.Enabled = False
        End If
        cmbOperatorb1.SelectedIndex = 0
        cmbOperatorb2.SelectedIndex = 0
        cmbOperatorb3.SelectedIndex = 0
        Dim clsSearch As New TimKiemNangCao_Bussines
        Dim dt As DataTable
        ' Add trường hiển thị
        dt = clsSearch.getFieldGroup(2)
        ' Xóa bổ một số nhóm trường hiển thị chưa cần thiết
        For i As Integer = dt.Rows.Count - 1 To 0 Step -1
            If dt.Rows(i)("FieldGroup") <> 201 And dt.Rows(i)("FieldGroup") <> 202 And dt.Rows(i)("FieldGroup") <> 203 And dt.Rows(i)("FieldGroup") <> 204 And dt.Rows(i)("FieldGroup") <> 205 Then
                dt.Rows(i).Delete()
            End If
        Next
        FillCombo(cmbID_hien_thi, dt)
        'Default nhóm hiển thị là Lý lịch sinh viên
        If cmbID_hien_thi.Items.Count >= 2 Then
            cmbID_hien_thi.SelectedIndex = 2
        End If
        ' Load các trường tìm kiếm
        dv = clsSearch.getFieldSeach(2).DefaultView
        Loader = True
    End Sub
    Private Sub frmESS_TimKiemNangCao_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub frmESS_TimKiemNangCao_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        If e.KeyCode = Keys.Enter Then Call HandleNextTAB(Me)
        If e.KeyCode = Keys.Delete Then
            Call HandleCombo_Delkey(Me)
            If cmbOperatorb1.Focused Then cmbOperatorb1.SelectedIndex = 0
            If cmbOperatorb2.Focused Then cmbOperatorb2.SelectedIndex = 0
            If cmbOperatorb3.Focused Then cmbOperatorb3.SelectedIndex = 0
            If cmbID_hien_thi.Focused AndAlso cmbID_hien_thi.Items.Count > 0 Then cmbID_hien_thi.SelectedIndex = 0
        End If
    End Sub
#End Region
#Region "Button"
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Try
            If Not CheckInputData() Then Exit Sub
            Me.Cursor = Cursors.WaitCursor
            Dim clsSearch As New TimKiemNangCao_Bussines
            'Add các điều kiện tìm kiếm
            If cmbValue1.Text.Trim <> "" Then
                Dim Value As Object
                If cmbValue1.DropDownStyle = ComboBoxStyle.DropDownList Then
                    Value = cmbValue1.SelectedValue
                Else
                    Value = cmbValue1.Text
                End If
                clsSearch.AddFieldSearch(cmbField1.SelectedValue, cmbOperator1.SelectedValue, cmbOperatorb3.Text, Value, "")
            End If
            If cmbValue2.Text.Trim <> "" Then
                Dim Value As Object
                If cmbValue2.DropDownStyle = ComboBoxStyle.DropDownList Then
                    Value = cmbValue2.SelectedValue
                Else
                    Value = cmbValue2.Text
                End If
                clsSearch.AddFieldSearch(cmbField2.SelectedValue, cmbOperator2.SelectedValue, cmbOperatorb1.Text, Value, "")
            End If
            If cmbValue3.Text.Trim <> "" Then
                Dim Value As Object
                If cmbValue3.DropDownStyle = ComboBoxStyle.DropDownList Then
                    Value = cmbValue3.SelectedValue
                Else
                    Value = cmbValue3.Text
                End If
                clsSearch.AddFieldSearch(cmbField3.SelectedValue, cmbOperator3.SelectedValue, cmbOperatorb2.Text, Value, "")
            End If
            If cmbValue4.Text.Trim <> "" Then
                Dim Value As Object
                If cmbValue4.DropDownStyle = ComboBoxStyle.DropDownList Then
                    Value = cmbValue4.SelectedValue
                Else
                    Value = cmbValue4.Text
                End If
                clsSearch.AddFieldSearch(cmbField4.SelectedValue, cmbOperator4.SelectedValue, cmbOperatorb3.Text, Value, "")
            End If
            'Add kết quả hiện thị
            clsSearch.AddFieldShow(cmbID_hien_thi.SelectedValue, gobjUser.UserID, gID_ph)
            ''Format kết quả trên DataGridView
            'SetUpDataGridView(Me.grViewKetQua)
            'Me.grViewKetQua.Columns.Clear()
            'For i As Integer = 0 To clsSearch.FieldShow.Count - 1
            '    Dim col As New DataGridViewTextBoxColumn
            '    With clsSearch.FieldShow.FieldShow(i)
            '        col.Name = .FieldID
            '        Dim arr() As String
            '        arr = .FieldID.Split(" ")
            '        If arr.Length > 1 Then
            '            col.DataPropertyName = arr(arr.Length - 1).ToString
            '        Else
            '            col.DataPropertyName = .FieldID
            '        End If
            '        col.HeaderText = .FieldName
            '        col.Width = .FieldSize * 40
            '        col.DefaultCellStyle.Alignment = .Align
            '        col.DefaultCellStyle.NullValue = ""
            '    End With
            '    Me.grViewKetQua.Columns.Add(col)
            'Next
            ''Hiển thị Kết quả tìm kiếm
            'Me.grViewKetQua.DataSource = clsSearch.KetQuaTimKiem(0, "").DefaultView

            Dim view As ColumnView = CType(grcDanhSach.MainView, ColumnView)
            view.Columns.Clear()
            For i As Integer = 0 To clsSearch.FieldShow.Count - 1
                Dim coll As New DevExpress.XtraGrid.Columns.GridColumn

                With clsSearch.FieldShow.FieldShow(i)
                    coll.Name = .FieldID
                    Dim arr() As String
                    arr = .FieldID.Split(" ")
                    If arr.Length > 1 Then
                        coll.FieldName = arr(arr.Length - 1).ToString
                    Else
                        coll.FieldName = .FieldID
                    End If
                    coll.Caption = .FieldName
                    coll.Width = .FieldSize * 40
                    coll.OptionsColumn.ReadOnly = True
                    coll.Visible = True
                    coll.VisibleIndex = i
                End With
                view.Columns.Add(coll)
            Next

            grcDanhSach.DataSource = clsSearch.KetQuaTimKiem(0, "").DefaultView
            Me.lblSo_sv.Text = grvDanhSach.DataSource.Count
            Me.Cursor = Cursors.Default
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdView_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdView.Click
        ' Danh sach ID_sv
        Dim dv As New DataView
        dv = grvDanhSach.DataSource
        If dv Is Nothing Then Exit Sub
        If dv.Count = 0 Then Exit Sub
        Dim arrID_sv As New ArrayList
        For i As Integer = 0 To dv.Count - 1
            arrID_sv.Add(dv.Item(i).Item("ID_sv"))
        Next
        Dim idx As Integer = grvDanhSach.FocusedRowHandle  'grvDanhSach.GetSelectedRows.GetValue(0)
        Dim ID_lops As String = gobjUser.dsID_lop
        Dim frmESS_ As New frmESS_HoSoSinhVien(arrID_sv, idx, ID_lops)
        frmESS_.MdiParent = frmESS_Main
        frmESS_.StartPosition = FormStartPosition.CenterScreen
        frmESS_.Show()
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        Me.Close()
    End Sub
    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim frmESS_ As New frmESS_ChonTruongHienThi(cmbID_hien_thi.SelectedValue)
        frmESS_.ShowDialog()
    End Sub
    Private Sub cmdExportExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExport.Click
        Try
            If grvDanhSach.DataSource Is Nothing Then
                Thongbao("Không có dữ liệu !")
                Exit Sub
            End If
            Dim clsEx As New ESSUtility.ExportCommon
            clsEx.ExportFromDevGridViewToExcel(grvDanhSach)
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region " Change"
    Private Sub FillGroup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillGroup.SelectedIndexChanged
        If Not Loader Then Exit Sub
        ' Load các trường tìm kiếm vào combo
        Call LoadFields_search(FillGroup.SelectedIndex)
    End Sub
    Private Sub cmbField_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbField1.SelectedIndexChanged, cmbField2.SelectedIndexChanged, cmbField3.SelectedIndexChanged, cmbField4.SelectedIndexChanged
        If Not Loader Then Exit Sub
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()
        Dim ID As Long = 0, FieldID, DTableName, DFieldID, DFieldName As String
        Dim FieldType As Byte
        Dim Find As Long
        'Lấy ra các mục: Kiểu dữ liệu,Tên bảng, mã trường danh mục,Tên trường  của trường được chọn trong Combo
        ID = sender.SelectedValue
        If ID > 0 Then
            Find = Rec_idx(ID, "ID", dv.Table)
            If Find < 0 Then Exit Sub
            FieldID = dv.Table.Rows(Find).Item("FieldID")
            FieldType = dv.Table.Rows(Find).Item("FieldType")
            DTableName = dv.Table.Rows(Find).Item("DTable")
            DFieldID = dv.Table.Rows(Find).Item("DFieldID")
            DFieldName = dv.Table.Rows(Find).Item("DFieldName")
            'Thực hiện Load dữ liệu lên Combo FieldOperator
            If sender.focus Then
                Dim cmb As ComboBox = CType(sender, ComboBox)
                Dim str As String = cmb.SelectedValue
                If sender.Name = "cmbField1" Then ChangeFields(cmbOperator1, cmbValue1, str, FieldType, DTableName, DFieldID, DFieldName)
                If sender.Name = "cmbField2" Then ChangeFields(cmbOperator2, cmbValue2, str, FieldType, DTableName, DFieldID, DFieldName)
                If sender.Name = "cmbField3" Then ChangeFields(cmbOperator3, cmbValue3, str, FieldType, DTableName, DFieldID, DFieldName)
                If sender.Name = "cmbField4" Then ChangeFields(cmbOperator4, cmbValue4, str, FieldType, DTableName, DFieldID, DFieldName)
            End If
        End If
    End Sub
    Private Sub cmbOperator_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOperator1.SelectedIndexChanged, cmbOperator2.SelectedIndexChanged, cmbOperator3.SelectedIndexChanged, cmbOperator4.SelectedIndexChanged
        If sender.Name = "cmbOperator1" Then Call ChangeOperator(txtValue1, cmbOperator1.Text)
        If sender.Name = "cmbOperator2" Then Call ChangeOperator(txtValue2, cmbOperator2.Text)
        If sender.Name = "cmbOperator3" Then Call ChangeOperator(txtValue3, cmbOperator3.Text)
        If sender.Name = "cmbOperator4" Then Call ChangeOperator(txtValue4, cmbOperator4.Text)
    End Sub
    Private Sub cmbID_hien_thi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbID_hien_thi.SelectedIndexChanged
        Try
            If Not Loader Then Exit Sub
            If cmbID_hien_thi.SelectedValue = gID_ph * 100 + 1 Then
                btnEdit.Enabled = True
            ElseIf gobjUser.UserGroup <> -1 Then
                btnEdit.Enabled = False
            Else
                btnEdit.Enabled = True
            End If
        Catch ex As Exception
            Thongbao(ex.Message)
        End Try
    End Sub
#End Region
#Region "Functions And Subs"
    Sub ChangeOperator(ByVal txtValue As TextBox, ByVal str As String)
        txtValue.Text = ""
        If str.ToUpper.Trim = "BETWEEN" Then
            txtValue.Enabled = True
        Else
            txtValue.Enabled = False
        End If
    End Sub
    Sub ChangeFields(ByVal cmbOperator As ComboBox, ByVal cmbValue As ComboBox, ByVal str As String, ByVal Kieu_truong As Byte, ByVal TableName As String, ByVal FieldID As String, ByVal FieldName As String)
        Try
            If str.Trim <> "" Then
                Dim cls As New TimKiemNangCao_Bussines
                'Load dữ liệu cho Combo Toán tử theo tham số kiểu trường kiểu trường 
                cmbOperator.Enabled = True
                Dim dt As DataTable
                dt = cls.getOperator(Kieu_truong)
                FillCombo(cmbOperator, dt)
                cmbOperator.SelectedIndex = 0
                'Nếu kiểu trường là 4 (Đây là kiểu danh mục) thì ta Load các giá trị danh mục vào Combo Value
                cmbValue.Enabled = True
                If Kieu_truong = 4 Or Kieu_truong = 5 Then
                    Dim dtDM As New DataTable
                    Dim clsLop As New Lop_Bussines(gobjUser.dsID_lop, 0, -1, 1)
                    If FieldID = "ID_he" Then
                        dtDM = clsLop.He_dao_tao() 'Load combobox Hệ đào tạo
                        cmbValue.DropDownStyle = ComboBoxStyle.DropDownList
                    ElseIf FieldID = "ID_khoa" Then
                        dtDM = clsLop.Khoa() 'Load combobox khoa
                        cmbValue.DropDownStyle = ComboBoxStyle.DropDownList
                    ElseIf FieldID = "ID_cn" Then
                        dtDM = clsLop.Chuyen_nganh_dao_tao() 'Load combobox chuyên ngành
                        cmbValue.DropDownStyle = ComboBoxStyle.DropDownList
                    ElseIf FieldID = "ID_lop" Then
                        dtDM = clsLop.Lop() 'Load combobox Lớp  
                        cmbValue.DropDownStyle = ComboBoxStyle.DropDownList
                    Else
                        Dim clsDM As New DanhMuc_Bussines
                        dtDM = clsDM.DanhMuc_Load(TableName, FieldID, FieldName)
                        cmbValue.DropDownStyle = ComboBoxStyle.DropDownList
                    End If
                    FillCombo(cmbValue, dtDM)
                Else
                    cmbValue.DropDownStyle = ComboBoxStyle.Simple
                    cmbValue.SelectedIndex = -1
                    cmbValue.Text = ""
                End If
            Else
                'Huỷ bỏ tất cả các chức liên quan đến Combo này
                cmbOperator.Enabled = False
                cmbOperator.SelectedIndex = -1
                cmbOperator.SelectedIndex = -1

                cmbValue.Enabled = False
                cmbValue.SelectedIndex = -1
                cmbValue.SelectedIndex = -1
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Function Rec_idx(ByVal fValue As Object, ByVal fField As String, ByVal fTable As DataTable) As Long
        Dim i As Integer, dt As DataTable = fTable.Copy
        For i = 0 To dt.Rows.Count - 1
            If dt.Rows(i).RowState <> DataRowState.Deleted AndAlso (Not IsDBNull(dt.Rows(i)(fField))) AndAlso dt.Rows(i)(fField) = fValue Then
                Return i
            End If
        Next
        Return -1
    End Function
    Private Sub LoadFields_search(ByVal FieldGroup As Integer)
        If FieldGroup < 0 Then Exit Sub
        Dim cls As New TimKiemNangCao_Bussines
        Dim dt As New DataTable
        If FieldGroup = 0 Then dt = cls.getFieldSeach_Group(202) ' Load theo ngành đào tạo FieldGrop=202
        If FieldGroup = 1 Then dt = cls.getFieldSeach_Group(203) ' Load theo lý lịch sinh viên FieldGrop=203
        If FieldGroup = 2 Then dt = cls.getFieldSeach_Group(204) ' Load theo khen thưởng FieldGrop=204
        If FieldGroup = 3 Then dt = cls.getFieldSeach_Group(205) ' Load theo kỷ luật FieldGrop=205
        If cmbField1.SelectedIndex < 0 Then FillCombo(cmbField1, dt.Copy)
        If cmbField2.SelectedIndex < 0 Then FillCombo(cmbField2, dt.Copy)
        If cmbField3.SelectedIndex < 0 Then FillCombo(cmbField3, dt.Copy)
        If cmbField4.SelectedIndex < 0 Then FillCombo(cmbField4, dt.Copy)
    End Sub
    Private Function CheckInputData() As Boolean
        Dim CtrlErr As Control = Nothing
        If Not ErrorProvider1 Is Nothing Then ErrorProvider1.Dispose()

        ' Kiểm tra nhóm hiển thị
        If cmbID_hien_thi.SelectedValue Is Nothing Then
            Call SetErrPro(cmbID_hien_thi, ErrorProvider1, "Bạn hãy chọn nhóm hiển thị !")
            If CtrlErr Is Nothing Then CtrlErr = cmbID_hien_thi
        End If
        If cmbField1.SelectedValue Is Nothing Then
            Call SetErrPro(cmbField1, ErrorProvider1, "Bạn hãy chọn ít nhất một điều kiện tìm kiếm !")
            If CtrlErr Is Nothing Then CtrlErr = cmbField1
        End If

        If Not CtrlErr Is Nothing Then GoTo QUIT
        CheckInputData = True
        Exit Function
QUIT:   Beep()
        Thongbao("Hãy nhập lại các thông tin trong hộp có dấu đỏ bên cạnh", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        CheckInputData = False
        CtrlErr.Focus()
    End Function
#End Region
End Class