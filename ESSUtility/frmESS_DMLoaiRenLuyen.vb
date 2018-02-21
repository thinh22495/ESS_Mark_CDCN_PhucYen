Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMLoaiRenLuyen
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False
#Region "Khai bao Bien & Hang"
    Private Const Header As String = "LOẠI RÈN LUYỆN"
    Private Const TableName As String = "STU_LoaiRenLuyen"
    Private Const FieldID_Cap_rl As String = "ID_cap_rl"
    Private Const FieldID As String = "ID_loai_rl"
    Private Const FieldMa As String = "Ky_hieu"
    Private Const FieldTen As String = "Ten_loai"
    Private Const FieldOther As String = "Diem"
    Private Const HeadMa As String = "Ký hiệu"
    Private Const HeadTen As String = "Tên loại RL"
    Private Const HeadOther As String = "Điểm tối đa"
    Private Const HeadCap As String = "Cấp rèn luyện"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID_Cap_rl As Integer = 0
    Dim ValueID As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueOther As String = ""

#End Region
#Region "User Functions"
    Private Sub txtKhoa_hoc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOther.KeyPress
        e.Handled = HandleNumberKey(e.KeyChar, "-")
    End Sub
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
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Tên
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldOther
            .DataPropertyName = FieldOther
            .HeaderText = HeadOther
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        txtMa.Text = ValueMa
        txtTen.Text = ValueTen
        txtOther.Text = ValueOther
        cmbCap.SelectedValue = ValueID_Cap_rl
    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueMa = txtMa.Text
        ValueTen = txtTen.Text
        ValueOther = txtOther.Text
        ValueID_Cap_rl = cmbCap.SelectedValue
    End Sub
    Private Function ValidForm() As Boolean
        Dim msgValid As String = ""
        ValidForm = True
        ErrorProvider1.Dispose()
        If txtMa.Text = "" Then
            Me.ErrorProvider1.SetError(txtMa, "Bạn phải nhập mã!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text = "" Then
            Me.ErrorProvider1.SetError(txtTen, "Bạn phải nhập tên!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtMa.Text.Length > 5 Then
            Me.ErrorProvider1.SetError(txtMa, "Mã quá dài, chỉ được nhập " & 5 & " ký tự!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text.Length > 200 Then
            Me.ErrorProvider1.SetError(txtTen, "Tên quá dài, chỉ được nhập " & 200 & " ký tự!")
            txtTen.Focus()
            ValidForm = False
        End If
        If txtOther.Text.Length > 0 AndAlso Not IsNumeric(txtOther.Text) Then
            Me.ErrorProvider1.SetError(txtOther, "Phải nhập số!")
            txtOther.Focus()
            ValidForm = False
        End If
        If cmbCap.SelectedValue < 0 Then
            Me.ErrorProvider1.SetError(cmbCap, "Phải chọn cấp rèn luyện!")
            txtOther.Focus()
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
        cmbCap.Enabled = status
    End Sub
    Private Sub ReloadDataGridView()
        DataGridViewDM.DataSource = cls.CatalogueLoad(TableName).DefaultView
        VisibleCmd(True)
        EnableTextBox(False)
        DataGridViewDM.Enabled = True
        SetValueFromUI()
    End Sub
    Private Function CheckSelectedGridView() As Boolean
        Try
            Dim dv As DataView
            dv = DataGridViewDM.DataSource
            If dv.Count = 0 Then
                Return False
                Exit Function
            Else
                Dim idx As Integer = 0
                idx = DataGridViewDM.CurrentRow.Index
                ValueID_Cap_rl = CInt("0" & dv.Item(idx)(FieldID_Cap_rl).ToString)
                ValueID = dv.Item(idx)(FieldID)
                ValueMa = dv.Item(idx)(FieldMa).ToString
                ValueTen = dv.Item(idx)(FieldTen).ToString
                ValueOther = dv.Item(idx)(FieldOther).ToString
                SetValueFromUI()
                Return True
            End If
        Catch ex As Exception
        End Try
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
        Me.lblCap.Text = HeadCap
    End Sub
#End Region
#Region "Form Event"
    Private Sub frmESS_DM_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            Dim cls As New clsDanh_muc
            Dim dtCap As DataTable = cls.CatalogueLoad("STU_CapRenLuyen")
            Dim dt As New DataTable
            dt.Columns.Add("ID_cap_rl")
            dt.Columns.Add("Ten_cap")
            Dim dr As DataRow
            For Each r As DataRow In dtCap.Rows
                dr = dt.NewRow
                dr("ID_cap_rl") = r("ID_cap_rl")
                dr("Ten_cap") = r("Ten_cap")
                dt.Rows.Add(dr)
            Next
            FillCombo(cmbCap, dt)
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
            txtOther.Text = ""
            cmbCap.SelectedValue = -1
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
            Thongbao(ex.Message)
        End Try
    End Sub
    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Try
            If ValidForm() = False Then Exit Sub
            If add Then
                'Gán giá trị co đối tượng
                Call GetValueFromUI()
                If Not CheckExist(ValueMa) Then
                    cls.CatalogueInsert(TableName, FieldID_Cap_rl, ValueID_Cap_rl, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldOther, ValueOther)
                    ReloadDataGridView()
                    edit = False
                End If
            End If
            Thongbao("Bạn đã cập nhật thành công !")
        Catch ex As Exception
            Thongbao(ex.Message)
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
    Private Sub DataGridViewDM_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGridViewDM.CurrentCellChanged
        If loaded = False Then Exit Sub
        CheckSelectedGridView()
    End Sub
#End Region
End Class