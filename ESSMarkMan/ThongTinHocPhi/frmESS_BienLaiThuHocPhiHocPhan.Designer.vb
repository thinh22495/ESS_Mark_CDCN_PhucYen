Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BienLaiThuHocPhiHocPhan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmESS_BienLaiThuHocPhiHocPhan))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle25 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle26 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle32 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle27 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle28 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle29 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle30 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle31 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmdSetup = New System.Windows.Forms.ToolStripButton
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
        Me.Ten_lop_tc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_mon = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tinh_chat = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tin_chi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.He_so = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_mien_giam = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Chon = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.labTen_lop = New System.Windows.Forms.Label
        Me.labHo_ten = New System.Windows.Forms.Label
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbDot_thu = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbID_thu_chi = New System.Windows.Forms.ComboBox
        Me.labTong_so_tien_nop = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.grdThuChi = New System.Windows.Forms.DataGridView
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_tra_lai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Tong_so_tin_chi = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkSelectAll = New System.Windows.Forms.CheckBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtSo_tien = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblTong_phai_nop = New System.Windows.Forms.Label
        Me.lblTong_da_nop = New System.Windows.Forms.Label
        Me.lblTong_thua_thieu = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_phai_nop = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_nop = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.labTong_so_tien_nop_tru_mien_giam = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtGhi_chu = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbGian_thu = New System.Windows.Forms.ComboBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.lblSo_du_ck = New System.Windows.Forms.Label
        Me.Label27 = New System.Windows.Forms.Label
        Me.btnLoc_sv = New System.Windows.Forms.Button
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdMonThu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.cmdClose, Me.cmdSetup})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(879, 25)
        Me.ToolStrip.TabIndex = 69
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ESSMarkMan.My.Resources.Resources.Import
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripButton1.Text = "Xem chi tiết học phần đã nộp"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'cmdSetup
        '
        Me.cmdSetup.Image = CType(resources.GetObject("cmdSetup.Image"), System.Drawing.Image)
        Me.cmdSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSetup.Name = "cmdSetup"
        Me.cmdSetup.Size = New System.Drawing.Size(141, 22)
        Me.cmdSetup.Text = "Thiết lập số phiếu"
        Me.cmdSetup.Visible = False
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa_sv.Location = New System.Drawing.Point(102, 84)
        Me.txtMa_sv.MaxLength = 20
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(132, 23)
        Me.txtMa_sv.TabIndex = 136
        Me.txtMa_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_phieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_phieu.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_phieu.Location = New System.Drawing.Point(598, 56)
        Me.txtSo_phieu.MaxLength = 10
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.ReadOnly = True
        Me.txtSo_phieu.Size = New System.Drawing.Size(85, 23)
        Me.txtSo_phieu.TabIndex = 133
        Me.txtSo_phieu.TabStop = False
        Me.txtSo_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(4, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Mã sv / SBD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thu
        '
        Me.dtpNgay_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpNgay_thu.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thu.Location = New System.Drawing.Point(428, 56)
        Me.dtpNgay_thu.Name = "dtpNgay_thu"
        Me.dtpNgay_thu.Size = New System.Drawing.Size(91, 23)
        Me.dtpNgay_thu.TabIndex = 132
        Me.dtpNgay_thu.TabStop = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(355, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Ngày thu:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_tien
        '
        Me.cmbLoai_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoai_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_tien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoai_tien.Items.AddRange(New Object() {"VND", "USD", "EUR"})
        Me.cmbLoai_tien.Location = New System.Drawing.Point(777, 55)
        Me.cmbLoai_tien.MaxDropDownItems = 5
        Me.cmbLoai_tien.Name = "cmbLoai_tien"
        Me.cmbLoai_tien.Size = New System.Drawing.Size(81, 24)
        Me.cmbLoai_tien.TabIndex = 131
        Me.cmbLoai_tien.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(703, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 137
        Me.Label14.Text = "Loại tiền:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(517, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 129
        Me.Label2.Text = "Số phiếu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoi_dung
        '
        Me.txtNoi_dung.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoi_dung.Location = New System.Drawing.Point(102, 111)
        Me.txtNoi_dung.MaxLength = 1000
        Me.txtNoi_dung.Name = "txtNoi_dung"
        Me.txtNoi_dung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoi_dung.Size = New System.Drawing.Size(756, 23)
        Me.txtNoi_dung.TabIndex = 141
        Me.txtNoi_dung.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(28, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 23)
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
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle17.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdMonThu.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grdMonThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdMonThu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Ten_lop_tc, Me.Ten_mon, Me.Tinh_chat, Me.So_tin_chi, Me.He_so, Me.So_tien, Me.So_tien_mien_giam, Me.So_tien_nop, Me.Chon})
        Me.grdMonThu.Location = New System.Drawing.Point(0, 227)
        Me.grdMonThu.Name = "grdMonThu"
        DataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle25.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle25.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle25.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle25.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle25.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle25.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdMonThu.RowHeadersDefaultCellStyle = DataGridViewCellStyle25
        Me.grdMonThu.RowHeadersVisible = False
        Me.grdMonThu.Size = New System.Drawing.Size(879, 169)
        Me.grdMonThu.TabIndex = 142
        '
        'Ten_lop_tc
        '
        Me.Ten_lop_tc.DataPropertyName = "Ten_lop_tc"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_lop_tc.DefaultCellStyle = DataGridViewCellStyle18
        Me.Ten_lop_tc.HeaderText = "Lớp tín chỉ"
        Me.Ten_lop_tc.Name = "Ten_lop_tc"
        Me.Ten_lop_tc.ReadOnly = True
        Me.Ten_lop_tc.Width = 88
        '
        'Ten_mon
        '
        Me.Ten_mon.DataPropertyName = "Ten_mon"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.Ten_mon.DefaultCellStyle = DataGridViewCellStyle19
        Me.Ten_mon.HeaderText = "Tên học phần"
        Me.Ten_mon.Name = "Ten_mon"
        Me.Ten_mon.ReadOnly = True
        Me.Ten_mon.Width = 88
        '
        'Tinh_chat
        '
        Me.Tinh_chat.DataPropertyName = "Tinh_chat"
        Me.Tinh_chat.HeaderText = "Tính chất"
        Me.Tinh_chat.Name = "Tinh_chat"
        Me.Tinh_chat.ReadOnly = True
        Me.Tinh_chat.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Tinh_chat.Width = 88
        '
        'So_tin_chi
        '
        Me.So_tin_chi.DataPropertyName = "So_tin_chi"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.So_tin_chi.DefaultCellStyle = DataGridViewCellStyle20
        Me.So_tin_chi.HeaderText = "Số TC"
        Me.So_tin_chi.Name = "So_tin_chi"
        Me.So_tin_chi.ReadOnly = True
        Me.So_tin_chi.Width = 88
        '
        'He_so
        '
        Me.He_so.DataPropertyName = "He_so"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.He_so.DefaultCellStyle = DataGridViewCellStyle21
        Me.He_so.HeaderText = "Hệ số"
        Me.He_so.Name = "He_so"
        Me.He_so.ReadOnly = True
        Me.He_so.Width = 87
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle22
        Me.So_tien.HeaderText = "Số tiền phải nộp"
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Width = 88
        '
        'So_tien_mien_giam
        '
        Me.So_tien_mien_giam.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "###,###"
        Me.So_tien_mien_giam.DefaultCellStyle = DataGridViewCellStyle23
        Me.So_tien_mien_giam.HeaderText = "Số tiền m.giảm"
        Me.So_tien_mien_giam.Name = "So_tien_mien_giam"
        Me.So_tien_mien_giam.ReadOnly = True
        Me.So_tien_mien_giam.Width = 88
        '
        'So_tien_nop
        '
        Me.So_tien_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle24.Format = "###,###"
        Me.So_tien_nop.DefaultCellStyle = DataGridViewCellStyle24
        Me.So_tien_nop.HeaderText = "Số tiền nộp"
        Me.So_tien_nop.Name = "So_tien_nop"
        Me.So_tien_nop.ReadOnly = True
        Me.So_tien_nop.Width = 88
        '
        'Chon
        '
        Me.Chon.DataPropertyName = "Chon"
        Me.Chon.HeaderText = "Nộp tiền"
        Me.Chon.Name = "Chon"
        Me.Chon.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Chon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Chon.Width = 88
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(365, 84)
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
        Me.Label7.Location = New System.Drawing.Point(654, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Lớp:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labTen_lop
        '
        Me.labTen_lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTen_lop.BackColor = System.Drawing.Color.Transparent
        Me.labTen_lop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTen_lop.Location = New System.Drawing.Point(731, 84)
        Me.labTen_lop.Name = "labTen_lop"
        Me.labTen_lop.Size = New System.Drawing.Size(139, 24)
        Me.labTen_lop.TabIndex = 146
        Me.labTen_lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHo_ten
        '
        Me.labHo_ten.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.labHo_ten.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labHo_ten.Location = New System.Drawing.Point(436, 84)
        Me.labHo_ten.Name = "labHo_ten"
        Me.labHo_ten.Size = New System.Drawing.Size(237, 24)
        Me.labHo_ten.TabIndex = 147
        Me.labHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(777, 28)
        Me.cmbLan_thu.MaxDropDownItems = 5
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(81, 24)
        Me.cmbLan_thu.TabIndex = 154
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(736, 28)
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
        Me.cmbDot_thu.Location = New System.Drawing.Point(269, 29)
        Me.cmbDot_thu.MaxDropDownItems = 5
        Me.cmbDot_thu.Name = "cmbDot_thu"
        Me.cmbDot_thu.Size = New System.Drawing.Size(58, 24)
        Me.cmbDot_thu.TabIndex = 150
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
        Me.cmbNam_hoc.Location = New System.Drawing.Point(428, 28)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(91, 24)
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
        Me.Label9.Location = New System.Drawing.Point(357, 28)
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
        Me.Label10.Location = New System.Drawing.Point(200, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 153
        Me.Label10.Text = "Đợt thu:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 56)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 23)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Loại thu, chi:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_thu_chi
        '
        Me.cmbID_thu_chi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_thu_chi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_thu_chi.Enabled = False
        Me.cmbID_thu_chi.Location = New System.Drawing.Point(102, 56)
        Me.cmbID_thu_chi.MaxDropDownItems = 5
        Me.cmbID_thu_chi.Name = "cmbID_thu_chi"
        Me.cmbID_thu_chi.Size = New System.Drawing.Size(251, 24)
        Me.cmbID_thu_chi.TabIndex = 156
        '
        'labTong_so_tien_nop
        '
        Me.labTong_so_tien_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTong_so_tien_nop.BackColor = System.Drawing.Color.Transparent
        Me.labTong_so_tien_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTong_so_tien_nop.ForeColor = System.Drawing.Color.Brown
        Me.labTong_so_tien_nop.Location = New System.Drawing.Point(217, 185)
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
        Me.Label12.Location = New System.Drawing.Point(-1, 185)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(218, 24)
        Me.Label12.TabIndex = 158
        Me.Label12.Text = "Tổng số tiền sinh viên phải nộp:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        DataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle26.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle26.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle26
        Me.grdThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThuChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nam_hoc, Me.Hoc_ky, Me.Phai_nop, Me.Da_nop, Me.So_tien_tra_lai, Me.Thieu_thua, Me.Tong_so_tin_chi})
        Me.grdThuChi.Location = New System.Drawing.Point(0, 402)
        Me.grdThuChi.Name = "grdThuChi"
        Me.grdThuChi.ReadOnly = True
        DataGridViewCellStyle32.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle32.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle32.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle32.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle32.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle32.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle32.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.RowHeadersDefaultCellStyle = DataGridViewCellStyle32
        Me.grdThuChi.RowHeadersVisible = False
        Me.grdThuChi.Size = New System.Drawing.Size(879, 132)
        Me.grdThuChi.TabIndex = 162
        '
        'Nam_hoc
        '
        Me.Nam_hoc.DataPropertyName = "Nam_hoc"
        DataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nam_hoc.DefaultCellStyle = DataGridViewCellStyle27
        Me.Nam_hoc.HeaderText = "Năm học"
        Me.Nam_hoc.MinimumWidth = 95
        Me.Nam_hoc.Name = "Nam_hoc"
        Me.Nam_hoc.ReadOnly = True
        Me.Nam_hoc.Width = 95
        '
        'Hoc_ky
        '
        Me.Hoc_ky.DataPropertyName = "Hoc_ky"
        DataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hoc_ky.DefaultCellStyle = DataGridViewCellStyle28
        Me.Hoc_ky.HeaderText = "Học kỳ"
        Me.Hoc_ky.MinimumWidth = 80
        Me.Hoc_ky.Name = "Hoc_ky"
        Me.Hoc_ky.ReadOnly = True
        Me.Hoc_ky.Width = 80
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle29.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle29.Format = "###,###"
        Me.Phai_nop.DefaultCellStyle = DataGridViewCellStyle29
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 120
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        Me.Phai_nop.Width = 120
        '
        'Da_nop
        '
        Me.Da_nop.DataPropertyName = "So_tien_da_nop"
        DataGridViewCellStyle30.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle30.Format = "###,###"
        Me.Da_nop.DefaultCellStyle = DataGridViewCellStyle30
        Me.Da_nop.HeaderText = "Đã nộp"
        Me.Da_nop.MinimumWidth = 120
        Me.Da_nop.Name = "Da_nop"
        Me.Da_nop.ReadOnly = True
        Me.Da_nop.Width = 120
        '
        'So_tien_tra_lai
        '
        Me.So_tien_tra_lai.DataPropertyName = "So_tien_tra_lai"
        Me.So_tien_tra_lai.HeaderText = "Đã hoàn trả"
        Me.So_tien_tra_lai.Name = "So_tien_tra_lai"
        Me.So_tien_tra_lai.ReadOnly = True
        '
        'Thieu_thua
        '
        Me.Thieu_thua.DataPropertyName = "Thieu_thua"
        DataGridViewCellStyle31.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle31.Format = "###,###"
        Me.Thieu_thua.DefaultCellStyle = DataGridViewCellStyle31
        Me.Thieu_thua.HeaderText = "Thiếu thừa"
        Me.Thieu_thua.MinimumWidth = 120
        Me.Thieu_thua.Name = "Thieu_thua"
        Me.Thieu_thua.ReadOnly = True
        Me.Thieu_thua.Width = 120
        '
        'Tong_so_tin_chi
        '
        Me.Tong_so_tin_chi.DataPropertyName = "Tong_so_tin_chi"
        Me.Tong_so_tin_chi.HeaderText = "Số tín chỉ kỳ"
        Me.Tong_so_tin_chi.Name = "Tong_so_tin_chi"
        Me.Tong_so_tin_chi.ReadOnly = True
        '
        'chkSelectAll
        '
        Me.chkSelectAll.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkSelectAll.AutoSize = True
        Me.chkSelectAll.BackColor = System.Drawing.Color.Transparent
        Me.chkSelectAll.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkSelectAll.Location = New System.Drawing.Point(765, 166)
        Me.chkSelectAll.Name = "chkSelectAll"
        Me.chkSelectAll.Size = New System.Drawing.Size(91, 20)
        Me.chkSelectAll.TabIndex = 163
        Me.chkSelectAll.Text = "Nộp tất cả"
        Me.chkSelectAll.UseVisualStyleBackColor = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(170, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 165
        Me.Label13.Text = "(*)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(526, 28)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 166
        Me.Label15.Text = "(*)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(329, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(686, 55)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 168
        Me.Label17.Text = "(*)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(858, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 169
        Me.Label18.Text = "(*)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(858, 55)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 24)
        Me.Label19.TabIndex = 170
        Me.Label19.Text = "(*)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSo_tien
        '
        Me.txtSo_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_tien.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_tien.Location = New System.Drawing.Point(610, 166)
        Me.txtSo_tien.MaxLength = 20
        Me.txtSo_tien.Name = "txtSo_tien"
        Me.txtSo_tien.Size = New System.Drawing.Size(132, 23)
        Me.txtSo_tien.TabIndex = 172
        Me.txtSo_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Location = New System.Drawing.Point(483, 165)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 24)
        Me.Label20.TabIndex = 171
        Me.Label20.Text = "Số tiền thực nộp:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(457, 541)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 24)
        Me.Label21.TabIndex = 173
        Me.Label21.Text = "Tổng cộng:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_phai_nop
        '
        Me.lblTong_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_phai_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_phai_nop.Location = New System.Drawing.Point(569, 541)
        Me.lblTong_phai_nop.Name = "lblTong_phai_nop"
        Me.lblTong_phai_nop.Size = New System.Drawing.Size(97, 24)
        Me.lblTong_phai_nop.TabIndex = 174
        Me.lblTong_phai_nop.Text = "0"
        Me.lblTong_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_da_nop
        '
        Me.lblTong_da_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_da_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_da_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_da_nop.Location = New System.Drawing.Point(670, 541)
        Me.lblTong_da_nop.Name = "lblTong_da_nop"
        Me.lblTong_da_nop.Size = New System.Drawing.Size(97, 24)
        Me.lblTong_da_nop.TabIndex = 175
        Me.lblTong_da_nop.Text = "0"
        Me.lblTong_da_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_thua_thieu
        '
        Me.lblTong_thua_thieu.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_thua_thieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_thua_thieu.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_thua_thieu.Location = New System.Drawing.Point(774, 541)
        Me.lblTong_thua_thieu.Name = "lblTong_thua_thieu"
        Me.lblTong_thua_thieu.Size = New System.Drawing.Size(83, 24)
        Me.lblTong_thua_thieu.TabIndex = 176
        Me.lblTong_thua_thieu.Text = "0"
        Me.lblTong_thua_thieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_tien_chu_phai_nop
        '
        Me.lblSo_tien_chu_phai_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_tien_chu_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSo_tien_chu_phai_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_phai_nop.Location = New System.Drawing.Point(81, 210)
        Me.lblSo_tien_chu_phai_nop.Name = "lblSo_tien_chu_phai_nop"
        Me.lblSo_tien_chu_phai_nop.Size = New System.Drawing.Size(360, 16)
        Me.lblSo_tien_chu_phai_nop.TabIndex = 177
        Me.lblSo_tien_chu_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSo_tien_chu_nop
        '
        Me.lblSo_tien_chu_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_tien_chu_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_nop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.lblSo_tien_chu_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_nop.Location = New System.Drawing.Point(447, 210)
        Me.lblSo_tien_chu_nop.Name = "lblSo_tien_chu_nop"
        Me.lblSo_tien_chu_nop.Size = New System.Drawing.Size(411, 16)
        Me.lblSo_tien_chu_nop.TabIndex = 178
        Me.lblSo_tien_chu_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Brown
        Me.Label22.Location = New System.Drawing.Point(857, 541)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 24)
        Me.Label22.TabIndex = 179
        Me.Label22.Text = "đ"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTong_so_tien_nop_tru_mien_giam
        '
        Me.labTong_so_tien_nop_tru_mien_giam.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTong_so_tien_nop_tru_mien_giam.BackColor = System.Drawing.Color.Transparent
        Me.labTong_so_tien_nop_tru_mien_giam.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTong_so_tien_nop_tru_mien_giam.ForeColor = System.Drawing.Color.Brown
        Me.labTong_so_tien_nop_tru_mien_giam.Location = New System.Drawing.Point(328, 162)
        Me.labTong_so_tien_nop_tru_mien_giam.Name = "labTong_so_tien_nop_tru_mien_giam"
        Me.labTong_so_tien_nop_tru_mien_giam.Size = New System.Drawing.Size(131, 24)
        Me.labTong_so_tien_nop_tru_mien_giam.TabIndex = 181
        Me.labTong_so_tien_nop_tru_mien_giam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label24.Location = New System.Drawing.Point(-7, 162)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(334, 24)
        Me.Label24.TabIndex = 180
        Me.Label24.Text = "Tổng số tiền sinh viên phải nộp(trừ đi miễn giảm):"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtGhi_chu
        '
        Me.txtGhi_chu.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGhi_chu.Location = New System.Drawing.Point(102, 138)
        Me.txtGhi_chu.MaxLength = 200
        Me.txtGhi_chu.Name = "txtGhi_chu"
        Me.txtGhi_chu.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtGhi_chu.Size = New System.Drawing.Size(756, 23)
        Me.txtGhi_chu.TabIndex = 201
        Me.txtGhi_chu.TabStop = False
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Location = New System.Drawing.Point(28, 138)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 23)
        Me.Label23.TabIndex = 200
        Me.Label23.Text = "Ghi chú:"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbGian_thu
        '
        Me.cmbGian_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbGian_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbGian_thu.Items.AddRange(New Object() {"Trực tiếp", "Gián thu"})
        Me.cmbGian_thu.Location = New System.Drawing.Point(598, 28)
        Me.cmbGian_thu.MaxDropDownItems = 5
        Me.cmbGian_thu.Name = "cmbGian_thu"
        Me.cmbGian_thu.Size = New System.Drawing.Size(85, 24)
        Me.cmbGian_thu.TabIndex = 204
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Location = New System.Drawing.Point(562, 28)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 24)
        Me.Label25.TabIndex = 205
        Me.Label25.Text = "Loại:"
        Me.Label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label26.ForeColor = System.Drawing.Color.Red
        Me.Label26.Location = New System.Drawing.Point(684, 27)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(21, 24)
        Me.Label26.TabIndex = 206
        Me.Label26.Text = "(*)"
        Me.Label26.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_du_ck
        '
        Me.lblSo_du_ck.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_du_ck.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_du_ck.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_du_ck.Location = New System.Drawing.Point(296, 542)
        Me.lblSo_du_ck.Name = "lblSo_du_ck"
        Me.lblSo_du_ck.Size = New System.Drawing.Size(90, 24)
        Me.lblSo_du_ck.TabIndex = 208
        Me.lblSo_du_ck.Text = "0"
        Me.lblSo_du_ck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label27
        '
        Me.Label27.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.BackColor = System.Drawing.Color.Transparent
        Me.Label27.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(217, 542)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(79, 24)
        Me.Label27.TabIndex = 207
        Me.Label27.Text = "Số dư CK:"
        Me.Label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnLoc_sv
        '
        Me.btnLoc_sv.BackColor = System.Drawing.Color.Transparent
        Me.btnLoc_sv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoc_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc_sv.ForeColor = System.Drawing.Color.Brown
        Me.btnLoc_sv.Image = Global.ESSMarkMan.My.Resources.Resources.Search
        Me.btnLoc_sv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoc_sv.Location = New System.Drawing.Point(240, 84)
        Me.btnLoc_sv.Name = "btnLoc_sv"
        Me.btnLoc_sv.Size = New System.Drawing.Size(26, 23)
        Me.btnLoc_sv.TabIndex = 135
        Me.btnLoc_sv.UseVisualStyleBackColor = False
        '
        'frmESS_BienLaiThuHocPhiHocPhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 566)
        Me.Controls.Add(Me.lblSo_du_ck)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.cmbGian_thu)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.txtGhi_chu)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.labTong_so_tien_nop_tru_mien_giam)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblSo_tien_chu_nop)
        Me.Controls.Add(Me.grdMonThu)
        Me.Controls.Add(Me.lblSo_tien_chu_phai_nop)
        Me.Controls.Add(Me.lblTong_thua_thieu)
        Me.Controls.Add(Me.lblTong_da_nop)
        Me.Controls.Add(Me.lblTong_phai_nop)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtSo_tien)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkSelectAll)
        Me.Controls.Add(Me.grdThuChi)
        Me.Controls.Add(Me.labTong_so_tien_nop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbID_thu_chi)
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
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmESS_BienLaiThuHocPhiHocPhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIÊN LAI THU THEO TÍN CHỈ"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdMonThu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
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
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbID_thu_chi As System.Windows.Forms.ComboBox
    Friend WithEvents labTong_so_tien_nop As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents grdThuChi As System.Windows.Forms.DataGridView
    Friend WithEvents chkSelectAll As System.Windows.Forms.CheckBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtSo_tien As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTong_phai_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_da_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_thua_thieu As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_phai_nop As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_nop As System.Windows.Forms.Label
    Friend WithEvents Ten_lop_tc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_mon As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tinh_chat As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tin_chi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents He_so As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_mien_giam As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Chon As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents labTong_so_tien_nop_tru_mien_giam As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtGhi_chu As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cmbGian_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents lblSo_du_ck As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_tra_lai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tong_so_tin_chi As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmdSetup As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
