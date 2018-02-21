Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMMucHocPhiTinChi
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False


#Region "Khai bao Bien & Hang"
    Private Const Header As String = "ĐỊNH MỨC HỌC PHÍ TÍN CHỈ"
    Private Const TableName As String = "ACC_MucHocPhiTinChi"
    Private Const TableParentName As String = "STU_He"
    Private Const FieldOption0 As String = "Hoc_ky"
    Private Const FieldOption1 As String = "Nam_hoc"
    Private Const FieldOption2 As String = "ID_he"
    Private Const FieldOption3 As String = "Ngoai_ngan_sach"
    Private Const FieldOption4 As String = "Nganh2"
    Private Const FieldOption5 As String = "Hoc_lai"
    Private Const FieldOption6 As String = "Mien_giam"
    Private Const FieldOption7 As String = "Tinh_chat"
    Private Const FieldOption8 As String = "So_tien"

    Private Const HeadOption0 As String = "Học kỳ"
    Private Const HeadOption1 As String = "Năm học"
    Private Const HeadOption2 As String = "Hệ"
    Private Const HeadOption3 As String = "Ngoài ngân sách"
    Private Const HeadOption4 As String = "Học chương trình 2"
    Private Const HeadOption5 As String = "Học lại"
    Private Const HeadOption6 As String = "Miễm giảm"
    Private Const HeadOption7 As String = "Tính chất"
    Private Const HeadOption8 As String = "Số tiền/1 tín chỉ"

    Dim cls As New clsDanh_muc
    Dim ValueOption0 As Integer = 0
    Dim ValueOption1 As String = ""
    Dim ValueOption2 As Integer = 0
    Dim ValueOption3 As Integer = 0
    Dim ValueOption4 As Integer = 0
    Dim ValueOption5 As Integer = 0
    Dim ValueOption6 As Integer = 0
    Dim ValueOption7 As String = ""
    Dim ValueOption8 As Integer = 0
    Dim frmESS_Parrent As New frmESS_DMHeDaoTao

#End Region

#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'Học kỳ
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = FieldOption0
            .DataPropertyName = FieldOption0
            .HeaderText = HeadOption0
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        'Năm học
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldOption1
            .DataPropertyName = FieldOption1
            .HeaderText = HeadOption1
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'Hệ
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldOption2
            .DataPropertyName = FieldOption2
            .HeaderText = HeadOption2
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'tính chất
        Dim col7 As New DataGridViewTextBoxColumn
        With col7
            .Name = FieldOption7
            .DataPropertyName = FieldOption7
            .HeaderText = HeadOption7
            .Width = 230
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col7)
        'ngoài ngân sách
        Dim col3 As New DataGridViewCheckBoxColumn
        With col3
            .Name = FieldOption3
            .DataPropertyName = FieldOption3
            .HeaderText = HeadOption3
            .Width = 60
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col3)
        'Học ngành 2
        Dim col4 As New DataGridViewCheckBoxColumn
        With col4
            .Name = FieldOption4
            .DataPropertyName = FieldOption4
            .HeaderText = HeadOption4
            .Width = 60
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col4)
        'Học lại
        Dim col5 As New DataGridViewCheckBoxColumn
        With col5
            .Name = FieldOption5
            .DataPropertyName = FieldOption5
            .HeaderText = HeadOption5
            .Width = 60
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col5)
        'Miễn giảm
        Dim col6 As New DataGridViewCheckBoxColumn
        With col6
            .Name = FieldOption6
            .DataPropertyName = FieldOption6
            .HeaderText = HeadOption6
            .Width = 60
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col6)

        'Số tiền
        Dim col8 As New DataGridViewTextBoxColumn
        With col8
            .Name = FieldOption8
            .DataPropertyName = FieldOption8
            .HeaderText = HeadOption8
            .Width = 60
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = True
        End With
        DataGridViewDM.Columns.Add(col8)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        cmbOption0.Text = ValueOption0
        cmbOption1.Text = ValueOption1
        cmbOption2.SelectedValue = CInt(ValueOption2)
        chkOption3.Checked = CType(ValueOption3, Boolean)
        chkOption4.Checked = CType(ValueOption4, Boolean)
        chkOption5.Checked = CType(ValueOption5, Boolean)
        chkOption6.Checked = CType(ValueOption6, Boolean)
        txtOption7.Text = ValueOption7.ToString
        txtOption8.Text = ValueOption8.ToString
    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueOption0 = CInt(cmbOption0.Text)
        ValueOption1 = cmbOption1.Text
        ValueOption2 = CInt(cmbOption2.SelectedValue)
        ValueOption3 = Math.Abs(CInt(chkOption3.Checked))
        ValueOption4 = Math.Abs(CInt(chkOption4.Checked))
        ValueOption5 = Math.Abs(CInt(chkOption5.Checked))
        ValueOption6 = Math.Abs(CInt(chkOption6.Checked))
        ValueOption7 = txtOption7.Text
        ValueOption8 = CInt(txtOption8.Text)
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If cmbOption0.Text = "" Then
            Me.ErrorProvider1.SetError(cmbOption0, "Bạn phải chọn dữ liệu!")
            cmbOption0.Focus()
            ValidForm = False
        End If
        If cmbOption1.Text = "" Then
            Me.ErrorProvider1.SetError(cmbOption1, "Bạn phải chọn dữ liệu!")
            cmbOption1.Focus()
            ValidForm = False
        End If
        If cmbOption2.Text = "" Then
            Me.ErrorProvider1.SetError(cmbOption2, "Bạn phải chọn dữ liệu!")
            cmbOption2.Focus()
            ValidForm = False
        End If
        If txtOption7.Text = "" Then
            Me.ErrorProvider1.SetError(txtOption7, "Bạn phải chọn dữ liệu!")
            txtOption7.Focus()
            ValidForm = False
        End If
        If txtOption8.Text = "" Then
            Me.ErrorProvider1.SetError(txtOption8, "Bạn phải chọn dữ liệu!")
            txtOption8.Focus()
            ValidForm = False
        End If

        If txtOption8.Text.Length > 0 AndAlso Not IsNumeric(txtOption8.Text) Then
            Me.ErrorProvider1.SetError(txtOption8, "Phải nhập số!")
            txtOption8.Focus()
            ValidForm = False
        End If

        'If Not chkOption3.Checked And Not chkOption4.Checked And Not chkOption5.Checked And Not chkOption6.Checked Then
        '    Me.ErrorProvider1.SetError(chkOption3, "Phải chọn ít nhất 1 trong các tham số này!")
        '    Me.ErrorProvider1.SetError(chkOption4, "Phải chọn ít nhất 1 trong các tham số này!")
        '    Me.ErrorProvider1.SetError(chkOption5, "Phải chọn ít nhất 1 trong các tham số này!")
        '    Me.ErrorProvider1.SetError(chkOption6, "Phải chọn ít nhất 1 trong các tham số này!")
        '    ValidForm = False
        'End If
    End Function
    Private Sub VisibleCmd(ByVal status As Boolean)
        cmdAdd.Visible = status
        cmdEdit.Visible = status
        cmdDelete.Visible = status
        'cmdClose.Visible = status
        cmdSave.Visible = Not status
        cmdCancel.Visible = Not status
    End Sub
    Private Sub EnableTextBox(ByVal status As Boolean)
        cmbOption0.Enabled = status
        cmbOption1.Enabled = status
        cmbOption2.Enabled = status
        chkOption3.Enabled = status
        chkOption4.Enabled = status
        chkOption5.Enabled = status
        chkOption6.Enabled = status
        txtOption7.Enabled = status
        txtOption8.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.CatalogueLoad(TableName).DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Dim rowCurr As DataGridViewRow = DataGridViewDM.CurrentRow
        If Not rowCurr Is Nothing Then
            ValueOption0 = CInt("0" & rowCurr.Cells(FieldOption0).Value.ToString)
            ValueOption1 = rowCurr.Cells(FieldOption1).Value.ToString
            ValueOption2 = CInt("0" & rowCurr.Cells(FieldOption2).Value.ToString)
            ValueOption3 = rowCurr.Cells(FieldOption3).Value
            ValueOption4 = rowCurr.Cells(FieldOption4).Value
            ValueOption5 = rowCurr.Cells(FieldOption5).Value
            ValueOption6 = rowCurr.Cells(FieldOption6).Value
            ValueOption7 = rowCurr.Cells(FieldOption7).Value
            ValueOption8 = rowCurr.Cells(FieldOption8).Value
            SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckExist(ByVal Option0 As String, ByVal Option1 As String, ByVal Option2 As String, ByVal Option3 As String, ByVal Option4 As String, ByVal Option5 As String, ByVal Option6 As String) As Boolean
        If cls.CheckExist_Options(TableName, FieldOption0, Option0, FieldOption1, Option1, FieldOption2, Option2, FieldOption3, Option3, FieldOption4, Option4, FieldOption5, Option5) Then
            Thongbao("Dữ liệu đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub FillComboBox()
        FillComboNamhoc(cmbOption1)
        Dim dt1 As DataTable = cls.CatalogueLoad(TableParentName)
        Dim dt2 As New DataTable
        dt2.Columns.Add("ID", GetType(Integer))
        dt2.Columns.Add("Ten", GetType(String))
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim row As DataRow = dt2.NewRow()
            row("ID") = dt1.Rows(i)(0)
            row("Ten") = dt1.Rows(i)(2)
            dt2.Rows.Add(row)
        Next
        FillCombo(cmbOption2, dt2)
    End Sub
    Private Sub ShowCaption()
        Me.Text = Header
        'Me.LabelOption0.Text = HeadMa
        'Me.LabelOption1.Text = HeadOption1
        'Me.LabelOption2.Text = HeadOption2
        'Me.LabelOption3.Text = HeadOption3
    End Sub
#End Region
#Region "Form Event"
    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ShowCaption()
            FillComboBox()
            FormatDataGridView()
            ReloadDataGridView()
            VisibleCmd(True)
            loaded = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub frmESS_DM_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Dim brush As Brush = New LinearGradientBrush(New Rectangle(0, 0, Width, Height), gBgColor1, gBgColor2, 90.0F)
        e.Graphics.FillRectangle(brush, 0, 0, Width, Height)
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Try
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            cmbOption0.SelectedText = ""
            cmbOption1.SelectedText = ""
            cmbOption2.SelectedText = ""
            chkOption3.Checked = False
            chkOption4.Checked = False
            chkOption5.Checked = False
            chkOption6.Checked = False
            txtOption7.Text = ""
            txtOption8.Text = ""
            add = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If CheckSelectedGridView() = False Then Exit Sub
            EnableTextBox(True)
            cmbOption0.Enabled = False
            cmbOption1.Enabled = False
            cmbOption2.Enabled = False
            chkOption3.Enabled = False
            chkOption4.Enabled = False
            chkOption5.Enabled = False
            chkOption6.Enabled = False
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            edit = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If CheckSelectedGridView() Then
                If cls.CatalogueXoa_ESSOptions(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3, FieldOption4, ValueOption4, FieldOption5, ValueOption5, FieldOption6, ValueOption6) Then
                    ReloadDataGridView()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If ValidForm() = False Then Exit Sub
            If add Then
                'Gán giá trị co đối tượng
                Call GetValueFromUI()
                If Not CheckExist(ValueOption0, ValueOption1, ValueOption2, ValueOption3, ValueOption4, ValueOption5, ValueOption6) Then
                    cls.CatalogueThemMoi_ESSOptions(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3, FieldOption4, ValueOption4, FieldOption5, ValueOption5, FieldOption6, ValueOption6, FieldOption7, ValueOption7, FieldOption8, ValueOption8)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueOption0 <> cmbOption1.SelectedValue Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(cmbOption0.SelectedValue, cmbOption0.SelectedValue, cmbOption0.SelectedValue, cmbOption0.SelectedValue, cmbOption0.SelectedValue, cmbOption0.SelectedValue, cmbOption0.SelectedValue) Then
                        Call GetValueFromUI()
                        cls.CatalogueCapNhat_ESSOption(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3, FieldOption4, ValueOption4, FieldOption5, ValueOption5, FieldOption6, ValueOption6, , , , , FieldOption7, ValueOption7, FieldOption8, ValueOption8)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueCapNhat_ESSOption(TableName, FieldOption0, ValueOption0, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3, FieldOption4, ValueOption4, FieldOption5, ValueOption5, FieldOption6, ValueOption6, , , , , FieldOption7, ValueOption7, FieldOption8, ValueOption8)
                    ReloadDataGridView()
                    edit = False
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        ReloadDataGridView()
        edit = False
        add = False
    End Sub
    Private Sub cmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
    Private Sub cmbParentsID_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbOption0.MouseDoubleClick
        If loaded = False Then Exit Sub
        frmESS_Parrent.ShowDialog()
        FillComboBox()
    End Sub
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.SelectionChanged
        'If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region

    Private Sub cmb_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbOption0.SelectedIndexChanged, cmbOption1.SelectedIndexChanged, cmbOption2.SelectedIndexChanged
        CreatTinhChat()
    End Sub
    Private Sub chkOption3_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chkOption3.CheckedChanged, chkOption4.CheckedChanged, chkOption5.CheckedChanged, chkOption6.CheckedChanged
        CreatTinhChat()
    End Sub
    Private Sub CreatTinhChat()
        Dim strTinhChat As String = ""
        'strTinhChat = cmbOption2.Text & "(Kỳ:" & cmbOption0.Text & ",Năm:" & cmbOption1.Text & ")"
        If chkOption3.Checked Then strTinhChat &= "Ngoài ngân sách "
        If chkOption4.Checked Then strTinhChat &= "Học chương trình 2 "
        If chkOption5.Checked Then strTinhChat &= "Học lại "
        If chkOption6.Checked Then strTinhChat &= "Miễn giảm "
        txtOption7.Text = strTinhChat
    End Sub
End Class
