Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms
Public Class frmESS_DMDiemKyHieu
    Dim add As Boolean = False
    Dim edit As Boolean = False
    Dim loaded As Boolean = False
#Region "Khai bao Bien & Hang"
    Private Const Header As String = "ĐIỂM KÝ HIỆU"
    Private Const TableName As String = "MARK_DiemKyHieu_TC"
    Private Const FieldMa As String = "Ky_hieu"
    Private Const FieldTen As String = "Ten_ky_hieu"
    Private Const FieldOption1 As String = "Hoc_lai"
    Private Const FieldOption2 As String = "Co_ly_do"
    Private Const FieldOption3 As String = "Khong_tinh_diem_thanh_phan"
    Private Const HeadMa As String = "Ký hiệu"
    Private Const HeadTen As String = "Ý nghĩa"
    Private Const HeadOption1 As String = "Học lại"
    Private Const HeadOption2 As String = "Có lý do"
    Private Const HeadOption3 As String = "Điểm TP không tính vào TBCMH"

    Dim cls As New clsDanh_muc
    Dim CurrentID As String = ""
    Dim Index As Integer = -1
    Dim ValueMa As String = ""
    Dim ValueTen As String = ""
    Dim ValueOption1 As Integer = 0
    Dim ValueOption2 As Integer = 0
    Dim ValueOption3 As Integer = 0


#End Region
#Region "User Functions"
    Private Sub FormatDataGridView()
        SetUpDataGridView(DataGridViewDM)
        DataGridViewDM.AllowUserToOrderColumns = False
        DataGridViewDM.AllowUserToAddRows = False
        'ký hiệu
        Dim col1 As New DataGridViewTextBoxColumn
        With col1
            .Name = FieldMa
            .DataPropertyName = FieldMa
            .HeaderText = HeadMa
            .Width = 50
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col1)
        'ý nghĩa
        Dim col2 As New DataGridViewTextBoxColumn
        With col2
            .Name = FieldTen
            .DataPropertyName = FieldTen
            .HeaderText = HeadTen
            .Width = 200
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col2)
        'Học lại
        Dim col3 As New DataGridViewCheckBoxColumn
        With col3
            .Name = FieldOption1
            .DataPropertyName = FieldOption1
            .HeaderText = HeadOption1
            .Width = 50
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col3)
        'Lý do
        Dim col4 As New DataGridViewCheckBoxColumn
        With col4
            .Name = FieldOption2
            .DataPropertyName = FieldOption2
            .HeaderText = HeadOption2
            .Width = 50
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col4)

        Dim col5 As New DataGridViewCheckBoxColumn
        With col5
            .Name = FieldOption3
            .DataPropertyName = FieldOption3
            .HeaderText = HeadOption3
            .Width = 100
            .TrueValue = 1
            .FalseValue = 0
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopCenter
            .HeaderCell.Style.Alignment = DataGridViewContentAlignment.TopCenter
            .ReadOnly = False
        End With
        DataGridViewDM.Columns.Add(col5)
    End Sub
    Private Sub SetValueFromUI()
        txtMa.Text = ValueMa
        txtTen.Text = ValueTen
        rdbOption1.Checked = CType(ValueOption1, Boolean)
        rdbOption2.Checked = CType(ValueOption2, Boolean)
        optKhongDiemTP.Checked = CType(ValueOption3, Boolean)
    End Sub
    Private Sub GetValueFromUI()
        ValueMa = txtMa.Text
        ValueTen = txtTen.Text
        ValueOption1 = Math.Abs(CInt(rdbOption1.Checked))
        ValueOption2 = Math.Abs(CInt(rdbOption2.Checked))
        ValueOption3 = Math.Abs(CInt(optKhongDiemTP.Checked))
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
        rdbOption1.Enabled = status
        rdbOption2.Enabled = status
        optKhongDiemTP.Enabled = status
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
            ValueTen = rowCurr.Cells(FieldTen).Value.ToString
            ValueOption1 = rowCurr.Cells(FieldOption1).Value
            ValueOption2 = rowCurr.Cells(FieldOption2).Value
            ValueOption3 = rowCurr.Cells(FieldOption3).Value
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
        Me.rdbOption1.Text = HeadOption1
        Me.rdbOption2.Text = HeadOption2
        Me.optKhongDiemTP.Text = HeadOption3
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
            SetQuyenTruyCap(cmdSave, cmdEdit, , cmdDelete)
            If gobjUser.ID_phong = 0 Then
                cmdSave.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
            End If
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
            rdbOption1.Checked = False
            rdbOption2.Checked = False
            optKhongDiemTP.Checked = False
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
                    cls.CatalogueInsert(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                    ReloadDataGridView()
                    add = False
                End If
            ElseIf edit Then
                'Kiểm tra xem có sửa mã không
                If ValueMa <> txtMa.Text Then
                    'Nếu đã sửa mã thì phải kiểm tra mã mới có tồn tại không
                    If Not CheckExist(txtMa.Text) Then
                        Call GetValueFromUI()
                        cls.CatalogueUpdate(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
                        ReloadDataGridView()
                        edit = False
                    End If
                Else
                    'Nếu không sửa mã thì Update luôn
                    Call GetValueFromUI()
                    cls.CatalogueUpdate(TableName, FieldMa, ValueMa, FieldTen, ValueTen, FieldOption1, ValueOption1, FieldOption2, ValueOption2, FieldOption3, ValueOption3)
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