<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_LapDanhSachMienGiamHocPhi
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdRemove = New System.Windows.Forms.ToolStripButton
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmbCopy = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.optGiay_to = New System.Windows.Forms.CheckBox
        Me.optAll = New System.Windows.Forms.CheckBox
        Me.txtPhan_tram = New System.Windows.Forms.TextBox
        Me.lblSo_tien = New System.Windows.Forms.Label
        Me.cmbMa_dt = New System.Windows.Forms.ComboBox
        Me.lblMa_dt = New System.Windows.Forms.Label
        Me.optAll1 = New System.Windows.Forms.CheckBox
        Me.labSo_miengiam = New System.Windows.Forms.Label
        Me.lblSo_sv = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.grdViewDanhSach = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grdViewMienGiam = New System.Windows.Forms.DataGridView
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phan_tram = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.trvLop = New ESSFinance.TreeViewLop
        Me.cmbID_doituong_tc = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewMienGiam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdAdd, Me.cmdRemove, Me.cmdSave, Me.cmbCopy, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 130
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESSFinance.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(82, 22)
        Me.cmdAdd.Text = "Thêm sv"
        '
        'cmdRemove
        '
        Me.cmdRemove.Image = Global.ESSFinance.My.Resources.Resources.Remove
        Me.cmdRemove.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdRemove.Name = "cmdRemove"
        Me.cmdRemove.Size = New System.Drawing.Size(70, 22)
        Me.cmdRemove.Text = "Xóa sv"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(53, 22)
        Me.cmdSave.Text = "Lưu"
        '
        'cmbCopy
        '
        Me.cmbCopy.Image = Global.ESSFinance.My.Resources.Resources.DanhMuc
        Me.cmbCopy.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmbCopy.Name = "cmbCopy"
        Me.cmbCopy.Size = New System.Drawing.Size(226, 22)
        Me.cmbCopy.Text = "Sao chép danh sách miễn giảm"
        Me.cmbCopy.Visible = False
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(109, 22)
        Me.cmdPrint.Text = "In danh sách"
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
        'optGiay_to
        '
        Me.optGiay_to.BackColor = System.Drawing.Color.Transparent
        Me.optGiay_to.ForeColor = System.Drawing.Color.Brown
        Me.optGiay_to.Location = New System.Drawing.Point(415, 115)
        Me.optGiay_to.Name = "optGiay_to"
        Me.optGiay_to.Size = New System.Drawing.Size(365, 21)
        Me.optGiay_to.TabIndex = 135
        Me.optGiay_to.Text = "Nếu thiếu giấy tờ liên quan sẽ không được miễn giảm"
        Me.optGiay_to.UseVisualStyleBackColor = False
        '
        'optAll
        '
        Me.optAll.BackColor = System.Drawing.Color.Transparent
        Me.optAll.Location = New System.Drawing.Point(270, 116)
        Me.optAll.Name = "optAll"
        Me.optAll.Size = New System.Drawing.Size(103, 21)
        Me.optAll.TabIndex = 133
        Me.optAll.Text = "Chọn tất cả"
        Me.optAll.UseVisualStyleBackColor = False
        '
        'txtPhan_tram
        '
        Me.txtPhan_tram.Location = New System.Drawing.Point(746, 59)
        Me.txtPhan_tram.MaxLength = 9
        Me.txtPhan_tram.Name = "txtPhan_tram"
        Me.txtPhan_tram.Size = New System.Drawing.Size(34, 23)
        Me.txtPhan_tram.TabIndex = 132
        Me.txtPhan_tram.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblSo_tien
        '
        Me.lblSo_tien.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien.Location = New System.Drawing.Point(594, 60)
        Me.lblSo_tien.Name = "lblSo_tien"
        Me.lblSo_tien.Size = New System.Drawing.Size(155, 23)
        Me.lblSo_tien.TabIndex = 136
        Me.lblSo_tien.Text = "Phần trăm miễn giảm:"
        Me.lblSo_tien.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbMa_dt
        '
        Me.cmbMa_dt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbMa_dt.Location = New System.Drawing.Point(381, 59)
        Me.cmbMa_dt.Name = "cmbMa_dt"
        Me.cmbMa_dt.Size = New System.Drawing.Size(221, 24)
        Me.cmbMa_dt.TabIndex = 131
        '
        'lblMa_dt
        '
        Me.lblMa_dt.BackColor = System.Drawing.Color.Transparent
        Me.lblMa_dt.Location = New System.Drawing.Point(273, 59)
        Me.lblMa_dt.Name = "lblMa_dt"
        Me.lblMa_dt.Size = New System.Drawing.Size(106, 24)
        Me.lblMa_dt.TabIndex = 134
        Me.lblMa_dt.Text = "Đối tượng TS:"
        Me.lblMa_dt.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optAll1
        '
        Me.optAll1.BackColor = System.Drawing.Color.Transparent
        Me.optAll1.Location = New System.Drawing.Point(270, 330)
        Me.optAll1.Name = "optAll1"
        Me.optAll1.Size = New System.Drawing.Size(103, 20)
        Me.optAll1.TabIndex = 142
        Me.optAll1.Text = "Chọn tất cả"
        Me.optAll1.UseVisualStyleBackColor = False
        '
        'labSo_miengiam
        '
        Me.labSo_miengiam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labSo_miengiam.BackColor = System.Drawing.Color.Transparent
        Me.labSo_miengiam.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labSo_miengiam.ForeColor = System.Drawing.Color.Brown
        Me.labSo_miengiam.Location = New System.Drawing.Point(722, 329)
        Me.labSo_miengiam.Name = "labSo_miengiam"
        Me.labSo_miengiam.Size = New System.Drawing.Size(70, 20)
        Me.labSo_miengiam.TabIndex = 144
        Me.labSo_miengiam.Text = "0"
        Me.labSo_miengiam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_sv
        '
        Me.lblSo_sv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_sv.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_sv.Location = New System.Drawing.Point(559, 329)
        Me.lblSo_sv.Name = "lblSo_sv"
        Me.lblSo_sv.Size = New System.Drawing.Size(157, 20)
        Me.lblSo_sv.TabIndex = 143
        Me.lblSo_sv.Text = "Tổng số sv miễn giảm:"
        Me.lblSo_sv.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(381, 28)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(49, 24)
        Me.cmbHoc_ky.TabIndex = 145
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(669, 29)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(111, 24)
        Me.cmbNam_hoc.TabIndex = 146
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(297, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 147
        Me.Label4.Text = "Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(596, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 148
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdViewDanhSach
        '
        Me.grdViewDanhSach.AllowUserToAddRows = False
        Me.grdViewDanhSach.AllowUserToDeleteRows = False
        Me.grdViewDanhSach.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdViewDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.grdViewDanhSach.Location = New System.Drawing.Point(264, 134)
        Me.grdViewDanhSach.Name = "grdViewDanhSach"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.grdViewDanhSach.RowHeadersVisible = False
        Me.grdViewDanhSach.Size = New System.Drawing.Size(528, 192)
        Me.grdViewDanhSach.TabIndex = 149
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
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
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
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 120
        '
        'grdViewMienGiam
        '
        Me.grdViewMienGiam.AllowUserToAddRows = False
        Me.grdViewMienGiam.AllowUserToDeleteRows = False
        Me.grdViewMienGiam.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewMienGiam.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewMienGiam.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewMienGiam.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.grdViewMienGiam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewMienGiam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.Phan_tram})
        Me.grdViewMienGiam.Location = New System.Drawing.Point(264, 356)
        Me.grdViewMienGiam.Name = "grdViewMienGiam"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdViewMienGiam.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdViewMienGiam.RowHeadersVisible = False
        Me.grdViewMienGiam.Size = New System.Drawing.Size(528, 198)
        Me.grdViewMienGiam.TabIndex = 150
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.Format = "dd/MM/yyyy"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn6.HeaderText = "Ngày sinh"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 110
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 110
        '
        'Phan_tram
        '
        Me.Phan_tram.DataPropertyName = "Phan_tram"
        Me.Phan_tram.HeaderText = "Phần trăm miễn giảm"
        Me.Phan_tram.MinimumWidth = 200
        Me.Phan_tram.Name = "Phan_tram"
        Me.Phan_tram.ReadOnly = True
        Me.Phan_tram.Width = 200
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(0, 28)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 537)
        Me.trvLop.TabIndex = 137
        '
        'cmbID_doituong_tc
        '
        Me.cmbID_doituong_tc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_doituong_tc.Location = New System.Drawing.Point(381, 89)
        Me.cmbID_doituong_tc.Name = "cmbID_doituong_tc"
        Me.cmbID_doituong_tc.Size = New System.Drawing.Size(221, 24)
        Me.cmbID_doituong_tc.TabIndex = 151
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(258, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 24)
        Me.Label1.TabIndex = 152
        Me.Label1.Text = "Đối tượng trợ cấp:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmESS_LapDanhSachMienGiamHocPhi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.cmbID_doituong_tc)
        Me.Controls.Add(Me.grdViewMienGiam)
        Me.Controls.Add(Me.grdViewDanhSach)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.labSo_miengiam)
        Me.Controls.Add(Me.lblSo_sv)
        Me.Controls.Add(Me.optAll1)
        Me.Controls.Add(Me.cmbMa_dt)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.optGiay_to)
        Me.Controls.Add(Me.optAll)
        Me.Controls.Add(Me.txtPhan_tram)
        Me.Controls.Add(Me.lblMa_dt)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.lblSo_tien)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_LapDanhSachMienGiamHocPhi"
        Me.Text = "Lập danh sách miễn giảm"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewMienGiam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents optGiay_to As System.Windows.Forms.CheckBox
    Friend WithEvents optAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtPhan_tram As System.Windows.Forms.TextBox
    Friend WithEvents lblSo_tien As System.Windows.Forms.Label
    Friend WithEvents cmbMa_dt As System.Windows.Forms.ComboBox
    Friend WithEvents lblMa_dt As System.Windows.Forms.Label
    Friend WithEvents trvLop As ESSFinance.TreeViewLop
    Friend WithEvents optAll1 As System.Windows.Forms.CheckBox
    Friend WithEvents labSo_miengiam As System.Windows.Forms.Label
    Friend WithEvents lblSo_sv As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdViewDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents grdViewMienGiam As System.Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdRemove As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewCheckBoxColumn1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phan_tram As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbID_doituong_tc As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCopy As System.Windows.Forms.ToolStripButton
End Class
