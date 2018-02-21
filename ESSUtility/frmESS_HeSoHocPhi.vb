Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMHeSoHocPhi
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False

#Region "Khai bao Bien & Hang"
    Private Const Header As String = "Định Mức Học Phí Theo Hệ Đào Tạo"
    Private Const TableName As String = "ACC_HeSoHocPhi"
    Private Const TableParentName As String = "STU_He"
    Private Const FieldMa As String = "ID_he"
    Private Const FieldOption1 As String = "He_so_hoc_lai"
    Private Const FieldOption2 As String = "He_so_ngoai_ngan_sach"
    Private Const FieldOption3 As String = "He_so_nganh2"

    Private Const HeadMa As String = "Hệ đào tạo"
    Private Const HeadOption1 As String = "Học lại"
    Private Const HeadOption2 As String = "Ngoài ngân sách"
    Private Const HeadOption3 As String = "Ngành 2"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueMa As Integer = 0
    Dim ValueOption1 As Integer = 0
    Dim ValueOption2 As Integer = 0
    Dim ValueOption3 As Integer = 0
    Dim frmESS_Parrent As New frmESS_DMHeDaoTao

#End Region

#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'Hệ đào tạo
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = FieldMa
            .DataPropertyName = FieldMa
            .HeaderText = HeadMa
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        'Học lại
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldOption1
            .DataPropertyName = FieldOption1
            .HeaderText = HeadOption1
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'Ngoài ngân sách
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
        'Ngành 2
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldOption3
            .DataPropertyName = FieldOption3
            .HeaderText = HeadOption3
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col3)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        cmbOption0.SelectedValue = CInt(ValueMa)
        txtOption1.Text = ValueOption1.ToString
        txtOption2.Text = ValueOption2.ToString
        txtOption3.Text = ValueOption3.ToString
    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueMa = CInt(cmbOption0.SelectedValue)
        ValueOption1 = CInt(txtOption1.Text)
        ValueOption2 = CInt(txtOption2.Text)
        ValueOption3 = CInt(txtOption3.Text)
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
        If txtOption1.Text = "" Then
            Me.ErrorProvider1.SetError(txtOption1, "Bạn phải nhập dữ liệu!")
            txtOption1.Focus()
            ValidForm = False
        End If
        If txtOption2.Text = "" Then
            Me.ErrorProvider1.SetError(txtOption2, "Bạn phải nhập dữ liệu!")
            txtOption2.Focus()
            ValidForm = False
        End If
        If txtOption3.Text = "" Then
            Me.ErrorProvider1.SetError(txtOption3, "Bạn phải nhập dữ liệu!")
            txtOption3.Focus()
            ValidForm = False
        End If

        If txtOption1.Text.Length > 0 AndAlso Not IsNumeric(txtOption1.Text) Then
            Me.ErrorProvider1.SetError(txtOption1, "Phải nhập số!")
            txtOption1.Focus()
            ValidForm = False
        End If
        If txtOption2.Text.Length > 0 AndAlso Not IsNumeric(txtOption2.Text) Then
            Me.ErrorProvider1.SetError(txtOption2, "Phải nhập số!")
            txtOption2.Focus()
            ValidForm = False
        End If
        If txtOption3.Text.Length > 0 AndAlso Not IsNumeric(txtOption3.Text) Then
            Me.ErrorProvider1.SetError(txtOption3, "Phải nhập số!")
            txtOption3.Focus()
            ValidForm = False
        End If
    End Function
    Private Sub VisibleCmd(ByVal status As Boolean)
        cmdAdd.Visible = status
        cmdEdit.Visible = status
        cmdDelete.Visible = status
        ''cmdClose.Visible = status
        cmdSave.Visible = Not status
        cmdCancel.Visible = Not status
    End Sub
    Private Sub EnableTextBox(ByVal status As Boolean)
        cmbOption0.Enabled = status
        txtOption1.Enabled = status
        txtOption2.Enabled = status
        txtOption3.Enabled = status
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
            ValueMa = rowCurr.Cells(FieldMa).Value
            ValueOption1 = CInt("0" & rowCurr.Cells(FieldOption1).Value.ToString)
            ValueOption2 = CInt("0" & rowCurr.Cells(FieldOption2).Value.ToString)
            ValueOption3 = CInt("0" & rowCurr.Cells(FieldOption3).Value.ToString)
            SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckExist(ByVal Ma As String) As Boolean
        If cls.CheckExist_Ma(TableName, FieldMa, Ma) Then
            Thongbao("""" & cmbOption0.SelectedText & """ đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub FillComboBox()
        Dim dt1 As DataTable = cls.CatalogueLoad(TableParentName)
        Dim dt2 As New DataTable
        dt2.Columns.Add("ID", GetType(Integer))
        dt2.Columns.Add("Ten", GetType(String))
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim row As DataRow = dt2.NewRow()
            row("ID") = dt1.Rows(i)(0)
            row("Ten") = "(" & dt1.Rows(i)(1) & ") " & dt1.Rows(i)(2)
            dt2.Rows.Add(row)
        Next
        FillCombo(cmbOption0, dt2)
    End Sub
    Private Sub ShowCaption()
        Me.Text = Header
        Me.LabelOption0.Text = HeadMa
        Me.LabelOption1.Text = HeadOption1
        Me.LabelOption2.Text = HeadOption2
        Me.LabelOption3.Text = HeadOption3
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
            txtOption1.Text = ""
            txtOption2.Text = ""
            txtOption3.Text = ""
            add = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        Try
            If CheckSelectedGridView() = False Then Exit Sub
            EnableTextBox(True)
            VisibleCmd(False)
            DataGridViewDM.Enabled = False
            edit = True
        Catch ex As Exception
        End Try
    End Sub
    Private Sub cmdXoa_ESSClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Try
            If CheckSelectedGridView() Then
                If cls.CatalogueDelete(TableName, FieldMa, ValueMa) Then
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
                If Not CheckExist(ValueMa) Then
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtOption1.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtOption1.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldMa, ValueMa, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldMa, ValueMa, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
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
        If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region
End Class