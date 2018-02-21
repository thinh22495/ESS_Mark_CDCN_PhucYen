Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMLoaiKhenThuong
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False

#Region "Khai bao Bien & Hang"
    Private Const Header As String = "LOẠI KHEN THƯỞNG"
    Private Const TableName As String = "STU_LoaiKhenThuong"
    Private Const TableParentName As String = "STU_CapKhenThuongKyLuat"
    Private Const FieldID As String = "ID_loai_kt"
    Private Const FieldMa As String = "Loai_khen_thuong"
    Private Const FieldTen As String = "Diem_thuong"
    Private Const FieldParentID As String = "ID_cap"
    Private Const HeadMa As String = "Loại khen thưởng"
    Private Const HeadTen As String = "Điểm thưởng"
    Private Const HeadParent As String = "Cấp khen thưởng"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueID As Integer = 0
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueParentID As Integer = 0
    Dim frmESS_Parrent As New frmESS_DMCapKhenThuongKyLuat

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
            .Width = 300
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
            .Width = 100
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'ID Parent
        Dim col3 As New DataGridViewTextBoxColumn
        With col3
            .Name = FieldParentID
            .DataPropertyName = FieldParentID
            .HeaderText = HeadParent
            .Width = 400
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
            .Visible = False
        End With
        DataGridViewDM.Columns.Add(col3)
    End Sub
    Private Sub SetValueFromUI()
        If loaded = False Then Exit Sub
        txtMa.Text = ValueMa
        txtTen.Text = ValueTen
        cmbParentsID.SelectedValue = ValueParentID
    End Sub
    Private Sub GetValueFromUI()
        If loaded = False Then Exit Sub
        ValueMa = txtMa.Text
        ValueTen = txtTen.Text
        ValueParentID = cmbParentsID.SelectedValue
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
        If txtMa.Text.Length > 50 Then
            Me.ErrorProvider1.SetError(txtMa, "Không được nhập quá " & 50 & " ký tự!")
            txtMa.Focus()
            ValidForm = False
        End If
        If txtTen.Text.Length > 0 AndAlso Not IsNumeric(txtTen.Text) Then
            Me.ErrorProvider1.SetError(txtTen, "Bạn phải nhập số!")
            txtTen.Focus()
            ValidForm = False
        End If
        If cmbParentsID.Text = "" Then
            Me.ErrorProvider1.SetError(cmbParentsID, "Bạn phải chọn dữ liệu!")
            cmbParentsID.Focus()
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
        cmbParentsID.Enabled = status
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
            ValueParentID = CInt("0" & rowCurr.Cells(FieldParentID).Value.ToString)
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
    Private Sub FillComboBox()
        Dim dt1 As DataTable = cls.CatalogueLoad(TableParentName)
        Dim dt2 As New DataTable
        dt2.Columns.Add("ID", GetType(Integer))
        dt2.Columns.Add("Ten", GetType(String))
        For i As Integer = 0 To dt1.Rows.Count - 1
            Dim row As DataRow = dt2.NewRow()
            row("ID") = dt1.Rows(i)(0)
            row("Ten") = dt1.Rows(i)(1)
            dt2.Rows.Add(row)
        Next
        FillCombo(cmbParentsID, dt2)
    End Sub
    Private Sub ShowCaption()
        Me.Text = Header
        Me.LabelMa.Text = HeadMa
        Me.LabelTen.Text = HeadTen
        Me.LabelParent.Text = HeadParent
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
            txtMa.Text = ""
            txtTen.Text = ""
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
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldParentID, ValueParentID)

                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldParentID, ValueParentID)

                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldID, ValueID, FieldMa, ValueMa, FieldTen, ValueTen, FieldParentID, ValueParentID)

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
    Private Sub cmbParentsID_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles cmbParentsID.MouseDoubleClick
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