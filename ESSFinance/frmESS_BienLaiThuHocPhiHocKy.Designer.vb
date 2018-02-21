Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BienLaiThuHocPhiHocKy
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.txtSo_phieu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpNgay_thu = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLoai_tien = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNoi_dung = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.grdMonThu = New System.Windows.Forms.DataGridView
        Me.Ten_thu_chi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_mien_giam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nop_tien = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.labTen_lop = New System.Windows.Forms.Label
        Me.labHo_ten = New System.Windows.Forms.Label
        Me.btnLoc_sv = New System.Windows.Forms.Button
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDot_thu = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.labTong_so_tien_nop = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_phai_nop = New System.Windows.Forms.Label
        Me.lblTong_thua_thieu = New System.Windows.Forms.Label
        Me.lblTong_da_nop = New System.Windows.Forms.Label
        Me.lblTong_phai_nop = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.grdThuChi = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.so_tien_tra_lai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.lblSo_tien_chu_thuc_nop = New System.Windows.Forms.Label
        Me.txtSo_tien_da_nop = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.chkAll = New System.Windows.Forms.CheckBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdMonThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 69
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSFinance.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(92, 22)
        Me.cmdSave.Text = "Lưu phiếu"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrint.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(78, 22)
        Me.cmdPrint.Text = "In phiếu"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSFinance.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa_sv.Location = New System.Drawing.Point(102, 88)
        Me.txtMa_sv.MaxLength = 20
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(132, 23)
        Me.txtMa_sv.TabIndex = 136
        Me.txtMa_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_phieu.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_phieu.Location = New System.Drawing.Point(351, 58)
        Me.txtSo_phieu.MaxLength = 10
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.ReadOnly = True
        Me.txtSo_phieu.Size = New System.Drawing.Size(111, 23)
        Me.txtSo_phieu.TabIndex = 133
        Me.txtSo_phieu.TabStop = False
        Me.txtSo_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(4, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Mã sv / SBD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thu
        '
        Me.dtpNgay_thu.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thu.Location = New System.Drawing.Point(102, 57)
        Me.dtpNgay_thu.Name = "dtpNgay_thu"
        Me.dtpNgay_thu.Size = New System.Drawing.Size(111, 23)
        Me.dtpNgay_thu.TabIndex = 132
        Me.dtpNgay_thu.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(29, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Ngày thu:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_tien
        '
        Me.cmbLoai_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_tien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoai_tien.Items.AddRange(New Object() {"VND", "USD"})
        Me.cmbLoai_tien.Location = New System.Drawing.Point(684, 57)
        Me.cmbLoai_tien.MaxDropDownItems = 5
        Me.cmbLoai_tien.Name = "cmbLoai_tien"
        Me.cmbLoai_tien.Size = New System.Drawing.Size(81, 24)
        Me.cmbLoai_tien.TabIndex = 131
        Me.cmbLoai_tien.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(599, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 24)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Loại tiền:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(272, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Số phiếu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoi_dung
        '
        Me.txtNoi_dung.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoi_dung.Location = New System.Drawing.Point(102, 118)
        Me.txtNoi_dung.MaxLength = 200
        Me.txtNoi_dung.Multiline = True
        Me.txtNoi_dung.Name = "txtNoi_dung"
        Me.txtNoi_dung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoi_dung.Size = New System.Drawing.Size(683, 59)
        Me.txtNoi_dung.TabIndex = 141
        Me.txtNoi_dung.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 118)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 56)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Nội dung:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdMonThu
        '
        Me.grdMonThu.AllowUserToAddRows = False
        Me.grdMonThu.AllowUserToDeleteRows = False
        Me.grdMonThu.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdMonThu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdMonThu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdMonThu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdMonThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMonThu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_thu_chi, Me.So_tien, Me.So_tien_mien_giam, Me.So_tien_nop, Me.So_tien_da_nop, Me.Nop_tien})
        Me.grdMonThu.Location = New System.Drawing.Point(0, 229)
        Me.grdMonThu.Name = "grdMonThu"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdMonThu.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.grdMonThu.RowHeadersVisible = False
        Me.grdMonThu.Size = New System.Drawing.Size(792, 150)
        Me.grdMonThu.TabIndex = 142
        '
        'Ten_thu_chi
        '
        Me.Ten_thu_chi.DataPropertyName = "Ten_thu_chi"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_thu_chi.DefaultCellStyle = DataGridViewCellStyle2
        Me.Ten_thu_chi.HeaderText = "Khoản nộp"
        Me.Ten_thu_chi.MinimumWidth = 250
        Me.Ten_thu_chi.Name = "Ten_thu_chi"
        Me.Ten_thu_chi.ReadOnly = True
        Me.Ten_thu_chi.Width = 250
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle3
        Me.So_tien.HeaderText = "Số tiền phải nộp"
        Me.So_tien.MinimumWidth = 100
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        '
        'So_tien_mien_giam
        '
        Me.So_tien_mien_giam.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "###,###"
        Me.So_tien_mien_giam.DefaultCellStyle = DataGridViewCellStyle4
        Me.So_tien_mien_giam.HeaderText = "Số tiền miễn giảm"
        Me.So_tien_mien_giam.MinimumWidth = 100
        Me.So_tien_mien_giam.Name = "So_tien_mien_giam"
        Me.So_tien_mien_giam.ReadOnly = True
        '
        'So_tien_nop
        '
        Me.So_tien_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "###,###"
        Me.So_tien_nop.DefaultCellStyle = DataGridViewCellStyle5
        Me.So_tien_nop.HeaderText = "Số tiền phải nộp"
        Me.So_tien_nop.MinimumWidth = 100
        Me.So_tien_nop.Name = "So_tien_nop"
        Me.So_tien_nop.ReadOnly = True
        '
        'So_tien_da_nop
        '
        Me.So_tien_da_nop.DataPropertyName = "So_tien_da_nop"
        Me.So_tien_da_nop.HeaderText = "Số tiền nộp"
        Me.So_tien_da_nop.MinimumWidth = 100
        Me.So_tien_da_nop.Name = "So_tien_da_nop"
        '
        'Nop_tien
        '
        Me.Nop_tien.DataPropertyName = "Nop_tien"
        Me.Nop_tien.FalseValue = "false"
        Me.Nop_tien.HeaderText = "Nộp tiền"
        Me.Nop_tien.MinimumWidth = 90
        Me.Nop_tien.Name = "Nop_tien"
        Me.Nop_tien.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Nop_tien.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Nop_tien.TrueValue = "True"
        Me.Nop_tien.Width = 90
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(280, 88)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Họ tên:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(567, 88)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Lớp:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labTen_lop
        '
        Me.labTen_lop.BackColor = System.Drawing.Color.Transparent
        Me.labTen_lop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTen_lop.Location = New System.Drawing.Point(646, 88)
        Me.labTen_lop.Name = "labTen_lop"
        Me.labTen_lop.Size = New System.Drawing.Size(139, 24)
        Me.labTen_lop.TabIndex = 146
        Me.labTen_lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHo_ten
        '
        Me.labHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.labHo_ten.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labHo_ten.Location = New System.Drawing.Point(351, 88)
        Me.labHo_ten.Name = "labHo_ten"
        Me.labHo_ten.Size = New System.Drawing.Size(168, 24)
        Me.labHo_ten.TabIndex = 147
        Me.labHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLoc_sv
        '
        Me.btnLoc_sv.BackColor = System.Drawing.Color.Transparent
        Me.btnLoc_sv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoc_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc_sv.ForeColor = System.Drawing.Color.Brown
        Me.btnLoc_sv.Image = Global.ESSFinance.My.Resources.Resources.Search
        Me.btnLoc_sv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoc_sv.Location = New System.Drawing.Point(239, 88)
        Me.btnLoc_sv.Name = "btnLoc_sv"
        Me.btnLoc_sv.Size = New System.Drawing.Size(25, 23)
        Me.btnLoc_sv.TabIndex = 135
        Me.btnLoc_sv.UseVisualStyleBackColor = False
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Enabled = False
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(684, 28)
        Me.cmbLan_thu.MaxDropDownItems = 5
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(81, 24)
        Me.cmbLan_thu.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(640, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Lần:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbDot_thu
        '
        Me.cmbDot_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDot_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbDot_thu.Location = New System.Drawing.Point(544, 29)
        Me.cmbDot_thu.MaxDropDownItems = 5
        Me.cmbDot_thu.Name = "cmbDot_thu"
        Me.cmbDot_thu.Size = New System.Drawing.Size(64, 24)
        Me.cmbDot_thu.TabIndex = 150
        Me.cmbDot_thu.Visible = False
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(102, 28)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(62, 24)
        Me.cmbHoc_ky.TabIndex = 148
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(351, 28)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(111, 24)
        Me.cmbNam_hoc.TabIndex = 149
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(17, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Học kỳ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(278, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 24)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Năm học:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(498, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 24)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Đợt:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'labTong_so_tien_nop
        '
        Me.labTong_so_tien_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTong_so_tien_nop.BackColor = System.Drawing.Color.Transparent
        Me.labTong_so_tien_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTong_so_tien_nop.ForeColor = System.Drawing.Color.Brown
        Me.labTong_so_tien_nop.Location = New System.Drawing.Point(219, 180)
        Me.labTong_so_tien_nop.Name = "labTong_so_tien_nop"
        Me.labTong_so_tien_nop.Size = New System.Drawing.Size(131, 24)
        Me.labTong_so_tien_nop.TabIndex = 159
        Me.labTong_so_tien_nop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label12.Location = New System.Drawing.Point(1, 180)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(218, 24)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Tổng số tiền sinh viên phải nộp:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(170, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 160
        Me.Label11.Text = "(*)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(468, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 161
        Me.Label13.Text = "(*)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(614, 29)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "(*)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label15.Visible = False
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(764, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 163
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(764, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 164
        Me.Label17.Text = "(*)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(219, 57)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 165
        Me.Label18.Text = "(*)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(468, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 24)
        Me.Label19.TabIndex = 166
        Me.Label19.Text = "(*)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(269, 88)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(21, 24)
        Me.Label20.TabIndex = 167
        Me.Label20.Text = "(*)"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_chu_phai_nop
        '
        Me.lblSo_tien_chu_phai_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_tien_chu_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSo_tien_chu_phai_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_phai_nop.Location = New System.Drawing.Point(1, 204)
        Me.lblSo_tien_chu_phai_nop.Name = "lblSo_tien_chu_phai_nop"
        Me.lblSo_tien_chu_phai_nop.Size = New System.Drawing.Size(360, 22)
        Me.lblSo_tien_chu_phai_nop.TabIndex = 179
        Me.lblSo_tien_chu_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_thua_thieu
        '
        Me.lblTong_thua_thieu.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_thua_thieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_thua_thieu.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_thua_thieu.Location = New System.Drawing.Point(669, 540)
        Me.lblTong_thua_thieu.Name = "lblTong_thua_thieu"
        Me.lblTong_thua_thieu.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_thua_thieu.TabIndex = 184
        Me.lblTong_thua_thieu.Text = "0"
        Me.lblTong_thua_thieu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_da_nop
        '
        Me.lblTong_da_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_da_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_da_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_da_nop.Location = New System.Drawing.Point(541, 540)
        Me.lblTong_da_nop.Name = "lblTong_da_nop"
        Me.lblTong_da_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_da_nop.TabIndex = 183
        Me.lblTong_da_nop.Text = "0"
        Me.lblTong_da_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_phai_nop
        '
        Me.lblTong_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_phai_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_phai_nop.Location = New System.Drawing.Point(417, 540)
        Me.lblTong_phai_nop.Name = "lblTong_phai_nop"
        Me.lblTong_phai_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_phai_nop.TabIndex = 182
        Me.lblTong_phai_nop.Text = "0"
        Me.lblTong_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(297, 540)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 24)
        Me.Label21.TabIndex = 181
        Me.Label21.Text = "Tổng cộng:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.BackColor = System.Drawing.Color.Transparent
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Location = New System.Drawing.Point(12, 544)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(128, 20)
        Me.chkPrint.TabIndex = 180
        Me.chkPrint.Text = "In phiếu khi Lưu"
        Me.chkPrint.UseVisualStyleBackColor = False
        '
        'grdThuChi
        '
        Me.grdThuChi.AllowUserToAddRows = False
        Me.grdThuChi.AllowUserToDeleteRows = False
        Me.grdThuChi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdThuChi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdThuChi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.grdThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThuChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.So_tien_phai_nop, Me.DataGridViewTextBoxColumn4, Me.Phai_nop, Me.Da_nop, Me.so_tien_tra_lai, Me.Thieu_thua})
        Me.grdThuChi.Location = New System.Drawing.Point(0, 384)
        Me.grdThuChi.Name = "grdThuChi"
        Me.grdThuChi.ReadOnly = True
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.RowHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.grdThuChi.RowHeadersVisible = False
        Me.grdThuChi.Size = New System.Drawing.Size(792, 153)
        Me.grdThuChi.TabIndex = 186
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Hoc_ky"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn1.HeaderText = "Học kỳ"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 80
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nam_hoc"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn2.HeaderText = "Năm học"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 95
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 95
        '
        'So_tien_phai_nop
        '
        Me.So_tien_phai_nop.DataPropertyName = "So_tien_phai_nop"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "###,###"
        Me.So_tien_phai_nop.DefaultCellStyle = DataGridViewCellStyle10
        Me.So_tien_phai_nop.HeaderText = "Mức học phí"
        Me.So_tien_phai_nop.MinimumWidth = 100
        Me.So_tien_phai_nop.Name = "So_tien_phai_nop"
        Me.So_tien_phai_nop.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "###,###"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn4.HeaderText = "Miễn giảm"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "###,###"
        Me.Phai_nop.DefaultCellStyle = DataGridViewCellStyle12
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 100
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        '
        'Da_nop
        '
        Me.Da_nop.DataPropertyName = "So_tien_da_nop"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "###,###"
        Me.Da_nop.DefaultCellStyle = DataGridViewCellStyle13
        Me.Da_nop.HeaderText = "Đã nộp"
        Me.Da_nop.MinimumWidth = 100
        Me.Da_nop.Name = "Da_nop"
        Me.Da_nop.ReadOnly = True
        '
        'so_tien_tra_lai
        '
        Me.so_tien_tra_lai.DataPropertyName = "So_tien_tra_lai"
        Me.so_tien_tra_lai.HeaderText = "Số tiền hoàn trả"
        Me.so_tien_tra_lai.MinimumWidth = 100
        Me.so_tien_tra_lai.Name = "so_tien_tra_lai"
        Me.so_tien_tra_lai.ReadOnly = True
        '
        'Thieu_thua
        '
        Me.Thieu_thua.DataPropertyName = "Thieu_thua"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "###,###"
        Me.Thieu_thua.DefaultCellStyle = DataGridViewCellStyle14
        Me.Thieu_thua.HeaderText = "Thiếu thừa"
        Me.Thieu_thua.MinimumWidth = 100
        Me.Thieu_thua.Name = "Thieu_thua"
        Me.Thieu_thua.ReadOnly = True
        '
        'lblSo_tien_chu_thuc_nop
        '
        Me.lblSo_tien_chu_thuc_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_tien_chu_thuc_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_thuc_nop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSo_tien_chu_thuc_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_thuc_nop.Location = New System.Drawing.Point(425, 205)
        Me.lblSo_tien_chu_thuc_nop.Name = "lblSo_tien_chu_thuc_nop"
        Me.lblSo_tien_chu_thuc_nop.Size = New System.Drawing.Size(360, 21)
        Me.lblSo_tien_chu_thuc_nop.TabIndex = 192
        Me.lblSo_tien_chu_thuc_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtSo_tien_da_nop
        '
        Me.txtSo_tien_da_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_tien_da_nop.Enabled = False
        Me.txtSo_tien_da_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien_da_nop.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_tien_da_nop.Location = New System.Drawing.Point(534, 180)
        Me.txtSo_tien_da_nop.MaxLength = 20
        Me.txtSo_tien_da_nop.Name = "txtSo_tien_da_nop"
        Me.txtSo_tien_da_nop.Size = New System.Drawing.Size(132, 23)
        Me.txtSo_tien_da_nop.TabIndex = 191
        Me.txtSo_tien_da_nop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Location = New System.Drawing.Point(404, 180)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(126, 23)
        Me.Label22.TabIndex = 190
        Me.Label22.Text = "Số tiền thực nộp:"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkAll
        '
        Me.chkAll.AutoSize = True
        Me.chkAll.BackColor = System.Drawing.Color.Transparent
        Me.chkAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkAll.Location = New System.Drawing.Point(694, 180)
        Me.chkAll.Name = "chkAll"
        Me.chkAll.Size = New System.Drawing.Size(91, 20)
        Me.chkAll.TabIndex = 193
        Me.chkAll.Text = "Nộp tất cả"
        Me.chkAll.UseVisualStyleBackColor = False
        '
        'frmESS_BienLaiThuHocPhiHocKy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.chkAll)
        Me.Controls.Add(Me.lblSo_tien_chu_thuc_nop)
        Me.Controls.Add(Me.txtSo_tien_da_nop)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.grdThuChi)
        Me.Controls.Add(Me.lblTong_thua_thieu)
        Me.Controls.Add(Me.lblTong_da_nop)
        Me.Controls.Add(Me.lblTong_phai_nop)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.lblSo_tien_chu_phai_nop)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.labTong_so_tien_nop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbLan_thu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbDot_thu)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.labHo_ten)
        Me.Controls.Add(Me.labTen_lop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.grdMonThu)
        Me.Controls.Add(Me.txtNoi_dung)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.txtSo_phieu)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dtpNgay_thu)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbLoai_tien)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.btnLoc_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaximizeBox = False
        Me.Name = "frmESS_BienLaiThuHocPhiHocKy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Biên lai thu học phí học kỳ"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdMonThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_phieu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_thu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLoai_tien As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnLoc_sv As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNoi_dung As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents grdMonThu As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labTen_lop As System.Windows.Forms.Label
    Friend WithEvents labHo_ten As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbDot_thu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents labTong_so_tien_nop As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_phai_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_thua_thieu As System.Windows.Forms.Label
    Friend WithEvents lblTong_da_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_phai_nop As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents grdThuChi As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents so_tien_tra_lai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblSo_tien_chu_thuc_nop As System.Windows.Forms.Label
    Friend WithEvents txtSo_tien_da_nop As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents chkAll As System.Windows.Forms.CheckBox
    Friend WithEvents Ten_thu_chi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_mien_giam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nop_tien As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
