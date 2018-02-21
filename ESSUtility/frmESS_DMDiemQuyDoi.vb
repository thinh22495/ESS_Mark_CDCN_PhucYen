Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMDiemQuyDoi
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False
#Region "Khai bao Bien & Hang"
    Private Const Header As String = "ĐIỂM QUY ĐỔI"
    Private Const TableName As String = "MARK_DiemQuyDoi_TC_09"
    Private Const FieldID As String = "ID_xep_loai"
    Private Const FieldMa As String = "Xep_loai"
    Private Const FieldTen As String = "Diem_chu"
    Private Const FieldOther As String = "Diem_so"
    Private Const FieldOther1 As String = "Tu_diem"
    Private Const FieldOther2 As String = "Den_diem"
    Private Const FieldOther3 As String = "Tich_luy"
    Private Const HeadMa As String = "Xếp loại"
    Private Const HeadTen As String = "Điểm chữ "
    Private Const HeadOther As String = "Điểm số"
    Private Const HeadOther1 As String = "Từ điểm "
    Private Const HeadOther2 As String = "Đến diểm "
    Private Const HeadOther3 As String = "Tích lũy"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueOther As String = ""
    Dim ValueOther1 As String = ""
    Dim ValueOther2 As String = ""
    Dim ValueOther3 As String = "0"

#End Region
#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'ID
        Dim col0 As New DataGridViewTextBoxColumn
        With col0
            .Name = FieldID
            .DataPropertyName = FieldID
            .HeaderText = "id"
            .Width = 10
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col0)
        'Mã
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldMa
            .DataPropertyName = FieldMa
            .HeaderText = HeadMa
            .Width = 150
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'Tên
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldTen
            .DataPropertyName = FieldTen
            .HeaderText = HeadTen
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        '0ther
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldOther
            .DataPropertyName = FieldOther
            .HeaderText = HeadOther
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        '0ther1
        Dim col4 As New DataGridViewTextBoxColumn
        With col4
            .Name = FieldOther1
            .DataPropertyName = FieldOther1
            .HeaderText = HeadOther1
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col4)
        '0ther2
        Dim col5 As New DataGridViewTextBoxColumn
        With col5
            .Name = FieldOther2
            .DataPropertyName = FieldOther2
            .HeaderText = HeadOther2
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col5)
        '0ther3
        Dim col6 As New DataGridViewCheckBoxColumn
        With col6
            .Name = FieldOther3
            .DataPropertyName = FieldOther3
            .HeaderText = HeadOther3
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col6)
    End Sub
    Private Sub SetValueFromUI()
        txtMa.Text = ValueMa
        txtTen.Text = ValueTen
        txtOther.Text = ValueOther
        txtOther1.Text = ValueOther1
        txtOther2.Text = ValueOther2
        chkOther3.Checked = CInt(ValueOther3)
    End Sub
    Private Sub GetValueFromUI()
        ValueMa = txtMa.Text
        ValueTen = txtTen.Text
        ValueOther = txtOther.Text
        ValueOther1 = txtOther1.Text
        ValueOther2 = txtOther2.Text
        ValueOther3 = Math.Abs(CInt(chkOther3.Checked)).ToString
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If txtMa.Text = "" Then
            Me.ErrorProvider1.SetError(txtMa, "Bạn phải nhập dữ liệu!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text = "" Then
            Me.ErrorProvider1.SetError(txtTen, "Bạn phải nhập dữ liệu!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtOther.Text = "" Then
            Me.ErrorProvider1.SetError(txtOther, "Bạn phải nhập dữ liệu!")
            txtOther.Focus()
            ValidForm = False
        End If
        If txtOther1.Text = "" Then
            Me.ErrorProvider1.SetError(txtOther1, "Bạn phải nhập dữ liệu!")
            txtOther1.Focus()
            ValidForm = False
        End If
        If txtOther2.Text = "" Then
            Me.ErrorProvider1.SetError(txtOther2, "Bạn phải nhập dữ liệu!")
            txtOther2.Focus()
            ValidForm = False
        End If
        If txtMa.Text.Length > 50 Then
            Me.ErrorProvider1.SetError(txtMa, "Không được nhập quá " & 50 & " ký tự!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text.Length > 2 Then
            Me.ErrorProvider1.SetError(txtTen, "Không được nhập quá " & 2 & " ký tự!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtOther.Text.Length > 0 AndAlso Not IsNumeric(txtOther.Text) Then
            Me.ErrorProvider1.SetError(txtOther, "Phải nhập số!")
            txtOther.Focus()
            ValidForm = False
        End If
        Dim a As Boolean = False
        If txtOther1.Text.Length > 0 AndAlso Not IsNumeric(txtOther1.Text) Then
            Me.ErrorProvider1.SetError(txtOther1, "Phải nhập số!")
            txtOther1.Focus()
            ValidForm = False
        Else
            a = True
        End If
        Dim b As Boolean = False
        If txtOther2.Text.Length > 0 AndAlso Not IsNumeric(txtOther2.Text) Then
            Me.ErrorProvider1.SetError(txtOther2, "Phải nhập số!")
            txtOther2.Focus()
            ValidForm = False
        Else
            b = True
        End If
        If (a = True And b = True) AndAlso CType(txtOther1.Text, Double) >= CType(txtOther2.Text, Double) Then
            Me.ErrorProvider1.SetError(txtOther1, "Giá trị 1 phải nhỏ hơn giá trị 2!")
            Me.ErrorProvider1.SetError(txtOther2, "Giá trị 1 phải nhỏ hơn giá trị 2!")
            txtOther2.Focus()
            ValidForm = False
        End If
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
        txtMa.Enabled = status
        txtTen.Enabled = status
        txtOther.Enabled = status
        txtOther1.Enabled = status
        txtOther2.Enabled = status
        chkOther3.Enabled = status
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
            ValueID = rowCurr.Cells(FieldID).Value
            ValueMa = rowCurr.Cells(FieldMa).Value.ToString
            ValueTen = rowCurr.Cells(FieldTen).Value.ToString
            ValueOther = rowCurr.Cells(FieldOther).Value.ToString
            ValueOther1 = rowCurr.Cells(FieldOther1).Value.ToString
            ValueOther2 = rowCurr.Cells(FieldOther2).Value.ToString
            ValueOther3 = CType(rowCurr.Cells(FieldOther3).Value, Double).ToString
            SetValueFromUI()
            Return True
        Else
            Thongbao("Bạn chưa chọn bản ghi nào !", MsgBoxStyle.OkOnly)
            Return False
        End If
    End Function
    Private Function CheckExist(ByVal Ma As String) As Boolean
        If cls.CheckExist_Ma(TableName, FieldMa, Ma) Then
            Thongbao("""" & Ma & """ đã tồn tại!")
            Return True
        Else
            Return False
        End If
    End Function
    Private Sub ShowCaption()
        Me.Text = Header
        Me.LabelMa.Text = HeadMa
        Me.LabelTen.Text = HeadTen
        Me.LabelOther.Text = HeadOther
        Me.LabelOther1.Text = HeadOther1
        Me.LabelOther2.Text = HeadOther2
        Me.chkOther3.Text = HeadOther3
    End Sub
#End Region
#Region "Form Event"
    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            ShowCaption()
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
            txtMa.Text = ""
            txtTen.Text = ""
            txtOther1.Text = ""
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
                If cls.CatalogueDelete(TableName, FieldID, ValueID) Then
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
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther, FieldOther1, ValueOther1, FieldOther2, ValueOther2, FieldOther3, ValueOther3)

                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther, FieldOther1, ValueOther1, FieldOther2, ValueOther2, FieldOther3, ValueOther3)

                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther, FieldOther1, ValueOther1, FieldOther2, ValueOther2, FieldOther3, ValueOther3)

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
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.SelectionChanged
        If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region
End Class