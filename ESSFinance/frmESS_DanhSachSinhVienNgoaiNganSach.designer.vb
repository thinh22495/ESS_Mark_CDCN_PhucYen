<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_DanhSachSinhVienNgoaiNganSach
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.labSoSv_thu = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.grdViewSinhVienDaChon = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_sinh1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_sinh = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Dia_chi_TT = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.trvLop = New ESSFinance.TreeViewLop
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnDel = New System.Windows.Forms.Button
        Me.txtHo_ten = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnLoc = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.dtpNS = New System.Windows.Forms.DateTimePicker
        CType(Me.grdViewSinhVienDaChon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'labSoSv_thu
        '
        Me.labSoSv_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSoSv_thu.BackColor = System.Drawing.Color.Transparent
        Me.labSoSv_thu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSoSv_thu.ForeColor = System.Drawing.Color.Brown
        Me.labSoSv_thu.Location = New System.Drawing.Point(585, 289)
        Me.labSoSv_thu.Name = "labSoSv_thu"
        Me.labSoSv_thu.Size = New System.Drawing.Size(57, 20)
        Me.labSoSv_thu.TabIndex = 160
        Me.labSoSv_thu.Text = "0"
        Me.labSoSv_thu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Location = New System.Drawing.Point(387, 289)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(198, 20)
        Me.lblSo_sv.TabIndex = 159
        Me.lblSo_sv.Text = "Tổng số sv ngoài ngân sách:"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(284, 289)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(103, 20)
        Me.optAll1.TabIndex = 158
        Me.optAll1.Text = "Chọn tất cả"
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'grdViewSinhVienDaChon
        '
        Me.grdViewSinhVienDaChon.AllowUserToAddRows = False
        Me.grdViewSinhVienDaChon.AllowUserToDeleteRows = False
        Me.grdViewSinhVienDaChon.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewSinhVienDaChon.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewSinhVienDaChon.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewSinhVienDaChon.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewSinhVienDaChon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewSinhVienDaChon.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Ten_lop, Me.Noi_sinh1})
        Me.grdViewSinhVienDaChon.Location = New System.Drawing.Point(262, 313)
        Me.grdViewSinhVienDaChon.Name = "grdViewSinhVienDaChon"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewSinhVienDaChon.RowHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdViewSinhVienDaChon.RowHeadersVisible = False
        Me.grdViewSinhVienDaChon.Size = New System.Drawing.Size(528, 253)
        Me.grdViewSinhVienDaChon.TabIndex = 170
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.DataPropertyName = "Chon"
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Chọn"
        Me.DataGridViewCheckBoxColumn2.MinimumWidth = 70
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        Me.DataGridViewCheckBoxColumn2.TrueValue = "True"
        Me.DataGridViewCheckBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.HeaderText = "Mã sv"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 110
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 140
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Ten_lop.DefaultCellStyle = DataGridViewCellStyle4
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 200
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        Me.Ten_lop.Width = 200
        '
        'Noi_sinh1
        '
        Me.Noi_sinh1.DataPropertyName = "Noi_sinh"
        Me.Noi_sinh1.HeaderText = "Nơi sinh"
        Me.Noi_sinh1.MinimumWidth = 100
        Me.Noi_sinh1.Name = "Noi_sinh1"
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Noi_sinh, Me.Dia_chi_TT})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(262, 54)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdViewDanhSach.RowHeadersVisible = False
        Me.grdViewDanhSach.Size = New System.Drawing.Size(528, 227)
        Me.grdViewDanhSach.TabIndex = 169
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Chon"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Chọn"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 70
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.TrueValue = "True"
        Me.DataGridViewCheckBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã sv"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 110
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 200
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 200
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Ngay_sinh"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'Noi_sinh
        '
        Me.Noi_sinh.DataPropertyName = "Noi_sinh"
        Me.Noi_sinh.HeaderText = "Nơi sinh"
        Me.Noi_sinh.MinimumWidth = 100
        Me.Noi_sinh.Name = "Noi_sinh"
        '
        'Dia_chi_TT
        '
        Me.Dia_chi_TT.DataPropertyName = "Dia_chi_TT"
        Me.Dia_chi_TT.HeaderText = "Địa chỉ thường trú"
        Me.Dia_chi_TT.MinimumWidth = 130
        Me.Dia_chi_TT.Name = "Dia_chi_TT"
        Me.Dia_chi_TT.Width = 130
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(0, 29)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 537)
        Me.trvLop.TabIndex = 157
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 155
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdExcel
        '
        Me.cmdExcel.Image = Global.ESSFinance.My.Resources.Resources.Excel
        Me.cmdExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdExcel.Name = "cmdExcel"
        Me.cmdExcel.Size = New System.Drawing.Size(93, 22)
        Me.cmdExcel.Text = "Xuất Excel"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(284, 28)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(103, 21)
        Me.optAll.TabIndex = 156
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Brown
        Me.btnAdd.Image = Global.ESSFinance.My.Resources.Resources.Add
        Me.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdd.Location = New System.Drawing.Point(665, 287)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(65, 25)
        Me.btnAdd.TabIndex = 172
        Me.btnAdd.Text = "Thêm"
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDel.BackColor = System.Drawing.Color.Transparent
        Me.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDel.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Brown
        Me.btnDel.Image = Global.ESSFinance.My.Resources.Resources.Remove
        Me.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDel.Location = New System.Drawing.Point(732, 287)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(58, 25)
        Me.btnDel.TabIndex = 171
        Me.btnDel.Text = "Xoá"
        Me.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'txtHo_ten
        '
        Me.txtHo_ten.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHo_ten.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtHo_ten.Location = New System.Drawing.Point(468, 28)
        Me.txtHo_ten.MaxLength = 200
        Me.txtHo_ten.Name = "txtHo_ten"
        Me.txtHo_ten.Size = New System.Drawing.Size(138, 23)
        Me.txtHo_ten.TabIndex = 173
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(387, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 20)
        Me.Label1.TabIndex = 174
        Me.Label1.Text = "Họ và tên:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLoc
        '
        Me.btnLoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoc.BackColor = System.Drawing.Color.Transparent
        Me.btnLoc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoc.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc.ForeColor = System.Drawing.Color.Brown
        Me.btnLoc.Image = Global.ESSFinance.My.Resources.Resources.Search
        Me.btnLoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoc.Location = New System.Drawing.Point(737, 27)
        Me.btnLoc.Name = "btnLoc"
        Me.btnLoc.Size = New System.Drawing.Size(55, 25)
        Me.btnLoc.TabIndex = 175
        Me.btnLoc.Text = "&Lọc"
        Me.btnLoc.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLoc.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(610, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 20)
        Me.Label2.TabIndex = 176
        Me.Label2.Text = "NS:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNS
        '
        Me.dtpNS.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNS.Checked = False
        Me.dtpNS.CustomFormat = "dd/MM/yy"
        Me.dtpNS.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNS.Location = New System.Drawing.Point(639, 28)
        Me.dtpNS.Name = "dtpNS"
        Me.dtpNS.ShowCheckBox = True
        Me.dtpNS.Size = New System.Drawing.Size(92, 23)
        Me.dtpNS.TabIndex = 177
        '
        'frmESS_DanhSachSinhVienNgoaiNganSach
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dtpNS)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLoc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtHo_ten)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnDel)
        Me.Controls.Add(Me.labSoSv_thu)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.grdViewSinhVienDaChon)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.optAll)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_DanhSachSinhVienNgoaiNganSach"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Danh sách sinh viên ngoài ngân sách"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdViewSinhVienDaChon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents labSoSv_thu As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents grdViewSinhVienDaChon As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents trvLop As ESSFinance.TreeViewLop
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnDel As System.Windows.Forms.Button
    Friend WithEvents btnLoc As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtHo_ten As System.Windows.Forms.TextBox
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_sinh1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_sinh As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Dia_chi_TT As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dtpNS As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
