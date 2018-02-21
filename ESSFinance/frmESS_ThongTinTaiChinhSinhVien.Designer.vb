Imports System.Drawing.Drawing2D
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_ThongTinTaiChinhSinhVien
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdXemBienLai = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.labTen_lop = New System.Windows.Forms.Label
        Me.labHo_ten = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbID_thu_chi = New System.Windows.Forms.ComboBox
        Me.labTong_so_tien_nop = New System.Windows.Forms.Label
        Me.grdThuChi = New System.Windows.Forms.DataGridView
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_tra_lai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.lblTong_phai_nop = New System.Windows.Forms.Label
        Me.lblTong_da_nop = New System.Windows.Forms.Label
        Me.lblTong_thua_thieu = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_phai_nop = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.btnLoc_sv = New System.Windows.Forms.Button
        Me.grdViewBienLai = New System.Windows.Forms.DataGridView
        Me.So_phieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_thu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nguoi_thu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Hoc_ky_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc_ = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Lan_thu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_dung = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thu_chi = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.Huy_phieu = New System.Windows.Forms.DataGridViewCheckBoxColumn
        Me.labTong_so_tien_nop_tru_mien_giam = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdXemBienLai, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(961, 25)
        Me.ToolStrip.TabIndex = 69
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdXemBienLai
        '
        Me.cmdXemBienLai.Image = Global.ESSFinance.My.Resources.Resources.View
        Me.cmdXemBienLai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXemBienLai.Name = "cmdXemBienLai"
        Me.cmdXemBienLai.Size = New System.Drawing.Size(104, 22)
        Me.cmdXemBienLai.Text = "Xem biên lai"
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
        Me.txtMa_sv.Location = New System.Drawing.Point(101, 26)
        Me.txtMa_sv.MaxLength = 20
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(132, 23)
        Me.txtMa_sv.TabIndex = 136
        Me.txtMa_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(3, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Mã sv / SBD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(286, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 144
        Me.Label6.Text = "Họ tên:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(532, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 24)
        Me.Label7.TabIndex = 145
        Me.Label7.Text = "Lớp:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labTen_lop
        '
        Me.labTen_lop.BackColor = System.Drawing.Color.Transparent
        Me.labTen_lop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTen_lop.Location = New System.Drawing.Point(587, 25)
        Me.labTen_lop.Name = "labTen_lop"
        Me.labTen_lop.Size = New System.Drawing.Size(348, 24)
        Me.labTen_lop.TabIndex = 146
        Me.labTen_lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labHo_ten
        '
        Me.labHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.labHo_ten.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labHo_ten.Location = New System.Drawing.Point(351, 25)
        Me.labHo_ten.Name = "labHo_ten"
        Me.labHo_ten.Size = New System.Drawing.Size(192, 24)
        Me.labHo_ten.TabIndex = 147
        Me.labHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label11.Location = New System.Drawing.Point(3, 52)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 23)
        Me.Label11.TabIndex = 157
        Me.Label11.Text = "Loại thu, chi:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label11.Visible = False
        '
        'cmbID_thu_chi
        '
        Me.cmbID_thu_chi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_thu_chi.Enabled = False
        Me.cmbID_thu_chi.Location = New System.Drawing.Point(102, 52)
        Me.cmbID_thu_chi.MaxDropDownItems = 5
        Me.cmbID_thu_chi.Name = "cmbID_thu_chi"
        Me.cmbID_thu_chi.Size = New System.Drawing.Size(301, 24)
        Me.cmbID_thu_chi.TabIndex = 156
        Me.cmbID_thu_chi.Visible = False
        '
        'labTong_so_tien_nop
        '
        Me.labTong_so_tien_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTong_so_tien_nop.BackColor = System.Drawing.Color.Transparent
        Me.labTong_so_tien_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.labTong_so_tien_nop.ForeColor = System.Drawing.Color.Brown
        Me.labTong_so_tien_nop.Location = New System.Drawing.Point(299, 179)
        Me.labTong_so_tien_nop.Name = "labTong_so_tien_nop"
        Me.labTong_so_tien_nop.Size = New System.Drawing.Size(131, 24)
        Me.labTong_so_tien_nop.TabIndex = 159
        Me.labTong_so_tien_nop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThuChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hoc_ky, Me.Nam_hoc, Me.So_tien_phai_nop, Me.DataGridViewTextBoxColumn4, Me.Phai_nop, Me.Da_nop, Me.So_tien_tra_lai, Me.Thieu_thua})
        Me.grdThuChi.Location = New System.Drawing.Point(0, 402)
        Me.grdThuChi.Name = "grdThuChi"
        Me.grdThuChi.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdThuChi.RowHeadersVisible = False
        Me.grdThuChi.Size = New System.Drawing.Size(961, 137)
        Me.grdThuChi.TabIndex = 162
        '
        'Hoc_ky
        '
        Me.Hoc_ky.DataPropertyName = "Hoc_ky"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Hoc_ky.DefaultCellStyle = DataGridViewCellStyle2
        Me.Hoc_ky.HeaderText = "Học kỳ"
        Me.Hoc_ky.MinimumWidth = 80
        Me.Hoc_ky.Name = "Hoc_ky"
        Me.Hoc_ky.ReadOnly = True
        Me.Hoc_ky.Width = 80
        '
        'Nam_hoc
        '
        Me.Nam_hoc.DataPropertyName = "Nam_hoc"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.Nam_hoc.DefaultCellStyle = DataGridViewCellStyle3
        Me.Nam_hoc.HeaderText = "Năm học"
        Me.Nam_hoc.MinimumWidth = 95
        Me.Nam_hoc.Name = "Nam_hoc"
        Me.Nam_hoc.ReadOnly = True
        Me.Nam_hoc.Width = 95
        '
        'So_tien_phai_nop
        '
        Me.So_tien_phai_nop.DataPropertyName = "So_tien_phai_nop"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "###,###"
        Me.So_tien_phai_nop.DefaultCellStyle = DataGridViewCellStyle4
        Me.So_tien_phai_nop.HeaderText = "Mức học phí"
        Me.So_tien_phai_nop.MinimumWidth = 120
        Me.So_tien_phai_nop.Name = "So_tien_phai_nop"
        Me.So_tien_phai_nop.ReadOnly = True
        Me.So_tien_phai_nop.Width = 120
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "###,###"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn4.HeaderText = "Miễn giảm"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 120
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "###,###"
        Me.Phai_nop.DefaultCellStyle = DataGridViewCellStyle6
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 120
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        Me.Phai_nop.Width = 120
        '
        'Da_nop
        '
        Me.Da_nop.DataPropertyName = "So_tien_da_nop"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "###,###"
        Me.Da_nop.DefaultCellStyle = DataGridViewCellStyle7
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "###,###"
        Me.Thieu_thua.DefaultCellStyle = DataGridViewCellStyle8
        Me.Thieu_thua.HeaderText = "Thiếu thừa"
        Me.Thieu_thua.MinimumWidth = 120
        Me.Thieu_thua.Name = "Thieu_thua"
        Me.Thieu_thua.ReadOnly = True
        Me.Thieu_thua.Width = 120
        '
        'chkPrint
        '
        Me.chkPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkPrint.AutoSize = True
        Me.chkPrint.BackColor = System.Drawing.Color.Transparent
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Location = New System.Drawing.Point(6, 545)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(128, 20)
        Me.chkPrint.TabIndex = 164
        Me.chkPrint.Text = "In phiếu khi Lưu"
        Me.chkPrint.UseVisualStyleBackColor = False
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(390, 541)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 24)
        Me.Label21.TabIndex = 173
        Me.Label21.Text = "Tổng cộng:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_phai_nop
        '
        Me.lblTong_phai_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTong_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_phai_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_phai_nop.Location = New System.Drawing.Point(495, 541)
        Me.lblTong_phai_nop.Name = "lblTong_phai_nop"
        Me.lblTong_phai_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_phai_nop.TabIndex = 174
        Me.lblTong_phai_nop.Text = "0"
        Me.lblTong_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_da_nop
        '
        Me.lblTong_da_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTong_da_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_da_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_da_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_da_nop.Location = New System.Drawing.Point(620, 541)
        Me.lblTong_da_nop.Name = "lblTong_da_nop"
        Me.lblTong_da_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_da_nop.TabIndex = 175
        Me.lblTong_da_nop.Text = "0"
        Me.lblTong_da_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_thua_thieu
        '
        Me.lblTong_thua_thieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTong_thua_thieu.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_thua_thieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_thua_thieu.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_thua_thieu.Location = New System.Drawing.Point(748, 541)
        Me.lblTong_thua_thieu.Name = "lblTong_thua_thieu"
        Me.lblTong_thua_thieu.Size = New System.Drawing.Size(108, 24)
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
        Me.lblSo_tien_chu_phai_nop.Location = New System.Drawing.Point(163, 208)
        Me.lblSo_tien_chu_phai_nop.Name = "lblSo_tien_chu_phai_nop"
        Me.lblSo_tien_chu_phai_nop.Size = New System.Drawing.Size(360, 16)
        Me.lblSo_tien_chu_phai_nop.TabIndex = 177
        Me.lblSo_tien_chu_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
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
        'btnLoc_sv
        '
        Me.btnLoc_sv.BackColor = System.Drawing.Color.Transparent
        Me.btnLoc_sv.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLoc_sv.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoc_sv.ForeColor = System.Drawing.Color.Brown
        Me.btnLoc_sv.Image = Global.ESSFinance.My.Resources.Resources.Search
        Me.btnLoc_sv.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLoc_sv.Location = New System.Drawing.Point(239, 26)
        Me.btnLoc_sv.Name = "btnLoc_sv"
        Me.btnLoc_sv.Size = New System.Drawing.Size(26, 23)
        Me.btnLoc_sv.TabIndex = 135
        Me.btnLoc_sv.UseVisualStyleBackColor = False
        '
        'grdViewBienLai
        '
        Me.grdViewBienLai.AllowUserToAddRows = False
        Me.grdViewBienLai.AllowUserToDeleteRows = False
        Me.grdViewBienLai.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdViewBienLai.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdViewBienLai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdViewBienLai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.So_phieu, Me.Ngay_thu, Me.Nguoi_thu, Me.Hoc_ky_, Me.Nam_hoc_, Me.Lan_thu, Me.So_tien, Me.Noi_dung, Me.Thu_chi, Me.Huy_phieu})
        Me.grdViewBienLai.Location = New System.Drawing.Point(0, 82)
        Me.grdViewBienLai.Name = "grdViewBienLai"
        Me.grdViewBienLai.RowHeadersWidth = 25
        Me.grdViewBienLai.Size = New System.Drawing.Size(962, 314)
        Me.grdViewBienLai.TabIndex = 180
        '
        'So_phieu
        '
        Me.So_phieu.DataPropertyName = "So_phieu"
        Me.So_phieu.HeaderText = "Số phiếu"
        Me.So_phieu.MinimumWidth = 100
        Me.So_phieu.Name = "So_phieu"
        Me.So_phieu.ReadOnly = True
        '
        'Ngay_thu
        '
        Me.Ngay_thu.DataPropertyName = "Ngay_thu"
        DataGridViewCellStyle10.Format = "dd/MM/yyyy"
        Me.Ngay_thu.DefaultCellStyle = DataGridViewCellStyle10
        Me.Ngay_thu.HeaderText = "Ngày thu"
        Me.Ngay_thu.MinimumWidth = 100
        Me.Ngay_thu.Name = "Ngay_thu"
        Me.Ngay_thu.ReadOnly = True
        '
        'Nguoi_thu
        '
        Me.Nguoi_thu.DataPropertyName = "Nguoi_thu"
        Me.Nguoi_thu.HeaderText = "Người thu"
        Me.Nguoi_thu.MinimumWidth = 140
        Me.Nguoi_thu.Name = "Nguoi_thu"
        Me.Nguoi_thu.ReadOnly = True
        Me.Nguoi_thu.Width = 140
        '
        'Hoc_ky_
        '
        Me.Hoc_ky_.DataPropertyName = "Hoc_ky"
        Me.Hoc_ky_.HeaderText = "Học kỳ"
        Me.Hoc_ky_.Name = "Hoc_ky_"
        Me.Hoc_ky_.ReadOnly = True
        '
        'Nam_hoc_
        '
        Me.Nam_hoc_.DataPropertyName = "Nam_hoc"
        Me.Nam_hoc_.HeaderText = "Năm học"
        Me.Nam_hoc_.Name = "Nam_hoc_"
        Me.Nam_hoc_.ReadOnly = True
        '
        'Lan_thu
        '
        Me.Lan_thu.DataPropertyName = "Lan_thu"
        Me.Lan_thu.HeaderText = "Lần thu"
        Me.Lan_thu.Name = "Lan_thu"
        Me.Lan_thu.ReadOnly = True
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        DataGridViewCellStyle11.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle11
        Me.So_tien.HeaderText = "Số tiền"
        Me.So_tien.MinimumWidth = 90
        Me.So_tien.Name = "So_tien"
        Me.So_tien.ReadOnly = True
        Me.So_tien.Width = 90
        '
        'Noi_dung
        '
        Me.Noi_dung.DataPropertyName = "Noi_dung"
        Me.Noi_dung.HeaderText = "Nội dung"
        Me.Noi_dung.MinimumWidth = 200
        Me.Noi_dung.Name = "Noi_dung"
        Me.Noi_dung.ReadOnly = True
        Me.Noi_dung.Width = 200
        '
        'Thu_chi
        '
        Me.Thu_chi.DataPropertyName = "Thu_chi"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle12.NullValue = "False"
        Me.Thu_chi.DefaultCellStyle = DataGridViewCellStyle12
        Me.Thu_chi.FalseValue = "0"
        Me.Thu_chi.HeaderText = "Thu chi"
        Me.Thu_chi.Name = "Thu_chi"
        Me.Thu_chi.ReadOnly = True
        Me.Thu_chi.TrueValue = "1"
        '
        'Huy_phieu
        '
        Me.Huy_phieu.DataPropertyName = "Huy_phieu"
        Me.Huy_phieu.HeaderText = "Phiếu hủy"
        Me.Huy_phieu.Name = "Huy_phieu"
        Me.Huy_phieu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Huy_phieu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'labTong_so_tien_nop_tru_mien_giam
        '
        Me.labTong_so_tien_nop_tru_mien_giam.AutoSize = True
        Me.labTong_so_tien_nop_tru_mien_giam.Location = New System.Drawing.Point(239, 546)
        Me.labTong_so_tien_nop_tru_mien_giam.Name = "labTong_so_tien_nop_tru_mien_giam"
        Me.labTong_so_tien_nop_tru_mien_giam.Size = New System.Drawing.Size(0, 16)
        Me.labTong_so_tien_nop_tru_mien_giam.TabIndex = 181
        Me.labTong_so_tien_nop_tru_mien_giam.Visible = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(642, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 24)
        Me.Label9.TabIndex = 152
        Me.Label9.Text = "Năm học:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label9.Visible = False
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(852, 56)
        Me.cmbLan_thu.MaxDropDownItems = 5
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(81, 24)
        Me.cmbLan_thu.TabIndex = 154
        Me.cmbLan_thu.Visible = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(811, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Lần:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Visible = False
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(715, 55)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(91, 24)
        Me.cmbNam_hoc.TabIndex = 149
        Me.cmbNam_hoc.Visible = False
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(574, 57)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(62, 24)
        Me.cmbHoc_ky.TabIndex = 148
        Me.cmbHoc_ky.Visible = False
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(489, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 151
        Me.Label8.Text = "Học kỳ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label8.Visible = False
        '
        'frmESS_ThongTinTaiChinhSinhVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(961, 566)
        Me.Controls.Add(Me.grdViewBienLai)
        Me.Controls.Add(Me.labTong_so_tien_nop_tru_mien_giam)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblSo_tien_chu_phai_nop)
        Me.Controls.Add(Me.lblTong_thua_thieu)
        Me.Controls.Add(Me.lblTong_da_nop)
        Me.Controls.Add(Me.lblTong_phai_nop)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.grdThuChi)
        Me.Controls.Add(Me.labTong_so_tien_nop)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbID_thu_chi)
        Me.Controls.Add(Me.cmbLan_thu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.labTen_lop)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnLoc_sv)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.labHo_ten)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmESS_ThongTinTaiChinhSinhVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Thông tin tài chính sinh viên"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdXemBienLai As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnLoc_sv As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents labTen_lop As System.Windows.Forms.Label
    Friend WithEvents labHo_ten As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbID_thu_chi As System.Windows.Forms.ComboBox
    Friend WithEvents labTong_so_tien_nop As System.Windows.Forms.Label
    Friend WithEvents grdThuChi As System.Windows.Forms.DataGridView
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lblTong_phai_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_da_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_thua_thieu As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_phai_nop As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_tra_lai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grdViewBienLai As System.Windows.Forms.DataGridView
    Friend WithEvents labTong_so_tien_nop_tru_mien_giam As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents So_phieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_thu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nguoi_thu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Hoc_ky_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc_ As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Lan_thu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_dung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thu_chi As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Huy_phieu As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
