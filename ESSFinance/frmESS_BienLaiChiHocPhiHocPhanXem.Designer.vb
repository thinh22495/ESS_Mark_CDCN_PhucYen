<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BienLaiChiHocPhiHocPhanXem
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
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
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label22 = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_nop = New System.Windows.Forms.Label
        Me.lblSo_tien_chu_phai_nop = New System.Windows.Forms.Label
        Me.lblTong_thua_thieu = New System.Windows.Forms.Label
        Me.lblTong_da_nop = New System.Windows.Forms.Label
        Me.lblTong_phai_nop = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtSo_tien = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.chkPrint = New System.Windows.Forms.CheckBox
        Me.labTong_so_tien_nop = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.labHo_ten = New System.Windows.Forms.Label
        Me.labTen_lop = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNoi_dung = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.txtSo_phieu = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtpNgay_thu = New System.Windows.Forms.DateTimePicker
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbLoai_tien = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.grdThuChi = New System.Windows.Forms.DataGridView
        Me.Hoc_ky = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Nam_hoc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien_tra_lai = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cmbDot_thu = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbID_thu_chi = New System.Windows.Forms.ComboBox
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdPrint, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(866, 25)
        Me.ToolStrip.TabIndex = 70
        Me.ToolStrip.Text = "ToolStrip1"
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
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label22.ForeColor = System.Drawing.Color.Brown
        Me.Label22.Location = New System.Drawing.Point(848, 548)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(21, 24)
        Me.Label22.TabIndex = 221
        Me.Label22.Text = "đ"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_chu_nop
        '
        Me.lblSo_tien_chu_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_tien_chu_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_nop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_tien_chu_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_nop.Location = New System.Drawing.Point(449, 211)
        Me.lblSo_tien_chu_nop.Name = "lblSo_tien_chu_nop"
        Me.lblSo_tien_chu_nop.Size = New System.Drawing.Size(411, 16)
        Me.lblSo_tien_chu_nop.TabIndex = 220
        Me.lblSo_tien_chu_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblSo_tien_chu_phai_nop
        '
        Me.lblSo_tien_chu_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_chu_phai_nop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_tien_chu_phai_nop.ForeColor = System.Drawing.Color.Red
        Me.lblSo_tien_chu_phai_nop.Location = New System.Drawing.Point(7, 211)
        Me.lblSo_tien_chu_phai_nop.Name = "lblSo_tien_chu_phai_nop"
        Me.lblSo_tien_chu_phai_nop.Size = New System.Drawing.Size(360, 16)
        Me.lblSo_tien_chu_phai_nop.TabIndex = 219
        Me.lblSo_tien_chu_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_thua_thieu
        '
        Me.lblTong_thua_thieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_thua_thieu.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_thua_thieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_thua_thieu.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_thua_thieu.Location = New System.Drawing.Point(738, 548)
        Me.lblTong_thua_thieu.Name = "lblTong_thua_thieu"
        Me.lblTong_thua_thieu.Size = New System.Drawing.Size(108, 24)
        Me.lblTong_thua_thieu.TabIndex = 218
        Me.lblTong_thua_thieu.Text = "0"
        Me.lblTong_thua_thieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblTong_da_nop
        '
        Me.lblTong_da_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_da_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_da_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_da_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_da_nop.Location = New System.Drawing.Point(610, 548)
        Me.lblTong_da_nop.Name = "lblTong_da_nop"
        Me.lblTong_da_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_da_nop.TabIndex = 217
        Me.lblTong_da_nop.Text = "0"
        Me.lblTong_da_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTong_phai_nop
        '
        Me.lblTong_phai_nop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTong_phai_nop.BackColor = System.Drawing.Color.Transparent
        Me.lblTong_phai_nop.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblTong_phai_nop.ForeColor = System.Drawing.Color.Brown
        Me.lblTong_phai_nop.Location = New System.Drawing.Point(486, 548)
        Me.lblTong_phai_nop.Name = "lblTong_phai_nop"
        Me.lblTong_phai_nop.Size = New System.Drawing.Size(122, 24)
        Me.lblTong_phai_nop.TabIndex = 216
        Me.lblTong_phai_nop.Text = "0"
        Me.lblTong_phai_nop.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(379, 548)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 24)
        Me.Label21.TabIndex = 215
        Me.Label21.Text = "Tổng cộng:"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtSo_tien
        '
        Me.txtSo_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_tien.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_tien.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_tien.Location = New System.Drawing.Point(600, 184)
        Me.txtSo_tien.MaxLength = 20
        Me.txtSo_tien.Name = "txtSo_tien"
        Me.txtSo_tien.Size = New System.Drawing.Size(132, 22)
        Me.txtSo_tien.TabIndex = 214
        Me.txtSo_tien.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(473, 183)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(126, 24)
        Me.Label20.TabIndex = 213
        Me.Label20.Text = "Số tiền thực chi:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(846, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(21, 24)
        Me.Label19.TabIndex = 212
        Me.Label19.Text = "(*)"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(846, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(21, 24)
        Me.Label18.TabIndex = 211
        Me.Label18.Text = "(*)"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label17
        '
        Me.Label17.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(674, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(21, 24)
        Me.Label17.TabIndex = 210
        Me.Label17.Text = "(*)"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(445, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(21, 24)
        Me.Label15.TabIndex = 208
        Me.Label15.Text = "(*)"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(174, 31)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 207
        Me.Label13.Text = "(*)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkPrint
        '
        Me.chkPrint.AutoSize = True
        Me.chkPrint.BackColor = System.Drawing.Color.Transparent
        Me.chkPrint.Checked = True
        Me.chkPrint.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkPrint.Location = New System.Drawing.Point(10, 548)
        Me.chkPrint.Name = "chkPrint"
        Me.chkPrint.Size = New System.Drawing.Size(120, 20)
        Me.chkPrint.TabIndex = 206
        Me.chkPrint.Text = "In phiếu khi Lưu"
        Me.chkPrint.UseVisualStyleBackColor = False
        '
        'labTong_so_tien_nop
        '
        Me.labTong_so_tien_nop.BackColor = System.Drawing.Color.Transparent
        Me.labTong_so_tien_nop.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTong_so_tien_nop.ForeColor = System.Drawing.Color.Brown
        Me.labTong_so_tien_nop.Location = New System.Drawing.Point(192, 184)
        Me.labTong_so_tien_nop.Name = "labTong_so_tien_nop"
        Me.labTong_so_tien_nop.Size = New System.Drawing.Size(131, 24)
        Me.labTong_so_tien_nop.TabIndex = 204
        Me.labTong_so_tien_nop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(-24, 184)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(218, 24)
        Me.Label12.TabIndex = 203
        Me.Label12.Text = "Tổng số tiền sinh viên phải chi:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(765, 31)
        Me.cmbLan_thu.MaxDropDownItems = 5
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(81, 24)
        Me.cmbLan_thu.TabIndex = 199
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(653, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 200
        Me.Label1.Text = "Lần:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbHoc_ky.Location = New System.Drawing.Point(106, 31)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(62, 24)
        Me.cmbHoc_ky.TabIndex = 195
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNam_hoc.Location = New System.Drawing.Point(353, 31)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(91, 24)
        Me.cmbNam_hoc.TabIndex = 196
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 24)
        Me.Label8.TabIndex = 197
        Me.Label8.Text = "Học kỳ:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(281, 31)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 24)
        Me.Label9.TabIndex = 198
        Me.Label9.Text = "Năm học:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'labHo_ten
        '
        Me.labHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.labHo_ten.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labHo_ten.Location = New System.Drawing.Point(355, 91)
        Me.labHo_ten.Name = "labHo_ten"
        Me.labHo_ten.Size = New System.Drawing.Size(168, 24)
        Me.labHo_ten.TabIndex = 194
        Me.labHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'labTen_lop
        '
        Me.labTen_lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.labTen_lop.BackColor = System.Drawing.Color.Transparent
        Me.labTen_lop.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labTen_lop.Location = New System.Drawing.Point(721, 91)
        Me.labTen_lop.Name = "labTen_lop"
        Me.labTen_lop.Size = New System.Drawing.Size(139, 24)
        Me.labTen_lop.TabIndex = 193
        Me.labTen_lop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(642, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 24)
        Me.Label7.TabIndex = 192
        Me.Label7.Text = "Lớp:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(284, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 24)
        Me.Label6.TabIndex = 191
        Me.Label6.Text = "Họ tên:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNoi_dung
        '
        Me.txtNoi_dung.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNoi_dung.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoi_dung.Location = New System.Drawing.Point(177, 121)
        Me.txtNoi_dung.MaxLength = 200
        Me.txtNoi_dung.Multiline = True
        Me.txtNoi_dung.Name = "txtNoi_dung"
        Me.txtNoi_dung.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtNoi_dung.Size = New System.Drawing.Size(683, 59)
        Me.txtNoi_dung.TabIndex = 190
        Me.txtNoi_dung.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(32, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 56)
        Me.Label5.TabIndex = 189
        Me.Label5.Text = "Nội dung:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMa_sv.Location = New System.Drawing.Point(106, 91)
        Me.txtMa_sv.MaxLength = 20
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(132, 20)
        Me.txtMa_sv.TabIndex = 186
        Me.txtMa_sv.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSo_phieu
        '
        Me.txtSo_phieu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_phieu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSo_phieu.ForeColor = System.Drawing.Color.Brown
        Me.txtSo_phieu.Location = New System.Drawing.Point(588, 61)
        Me.txtSo_phieu.MaxLength = 10
        Me.txtSo_phieu.Name = "txtSo_phieu"
        Me.txtSo_phieu.ReadOnly = True
        Me.txtSo_phieu.Size = New System.Drawing.Size(85, 22)
        Me.txtSo_phieu.TabIndex = 183
        Me.txtSo_phieu.TabStop = False
        Me.txtSo_phieu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 24)
        Me.Label4.TabIndex = 184
        Me.Label4.Text = "Mã sv / SBD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpNgay_thu
        '
        Me.dtpNgay_thu.CustomFormat = "dd/MM/yyyy"
        Me.dtpNgay_thu.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpNgay_thu.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpNgay_thu.Location = New System.Drawing.Point(353, 61)
        Me.dtpNgay_thu.Name = "dtpNgay_thu"
        Me.dtpNgay_thu.Size = New System.Drawing.Size(91, 22)
        Me.dtpNgay_thu.TabIndex = 182
        Me.dtpNgay_thu.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(281, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 24)
        Me.Label3.TabIndex = 188
        Me.Label3.Text = "Ngày thu:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLoai_tien
        '
        Me.cmbLoai_tien.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLoai_tien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLoai_tien.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLoai_tien.Items.AddRange(New Object() {"VND", "USD"})
        Me.cmbLoai_tien.Location = New System.Drawing.Point(765, 60)
        Me.cmbLoai_tien.MaxDropDownItems = 5
        Me.cmbLoai_tien.Name = "cmbLoai_tien"
        Me.cmbLoai_tien.Size = New System.Drawing.Size(81, 24)
        Me.cmbLoai_tien.TabIndex = 181
        Me.cmbLoai_tien.TabStop = False
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(692, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(72, 24)
        Me.Label14.TabIndex = 187
        Me.Label14.Text = "Loại tiền:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(443, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 24)
        Me.Label2.TabIndex = 180
        Me.Label2.Text = "Số phiếu:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(675, 29)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(21, 24)
        Me.Label16.TabIndex = 226
        Me.Label16.Text = "(*)"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label16.Visible = False
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
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdThuChi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdThuChi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Hoc_ky, Me.Nam_hoc, Me.So_tien_phai_nop, Me.DataGridViewTextBoxColumn4, Me.Phai_nop, Me.Da_nop, Me.So_tien_tra_lai, Me.Thieu_thua})
        Me.grdThuChi.Location = New System.Drawing.Point(1, 230)
        Me.grdThuChi.Name = "grdThuChi"
        Me.grdThuChi.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdThuChi.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.grdThuChi.RowHeadersVisible = False
        Me.grdThuChi.Size = New System.Drawing.Size(868, 312)
        Me.grdThuChi.TabIndex = 227
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
        'cmbDot_thu
        '
        Me.cmbDot_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDot_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbDot_thu.Location = New System.Drawing.Point(615, 29)
        Me.cmbDot_thu.MaxDropDownItems = 5
        Me.cmbDot_thu.Name = "cmbDot_thu"
        Me.cmbDot_thu.Size = New System.Drawing.Size(58, 24)
        Me.cmbDot_thu.TabIndex = 224
        Me.cmbDot_thu.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(546, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 24)
        Me.Label10.TabIndex = 225
        Me.Label10.Text = "Đợt chi:"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(7, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(93, 23)
        Me.Label11.TabIndex = 229
        Me.Label11.Text = "Loại thu, chi:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_thu_chi
        '
        Me.cmbID_thu_chi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_thu_chi.Enabled = False
        Me.cmbID_thu_chi.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbID_thu_chi.Location = New System.Drawing.Point(106, 62)
        Me.cmbID_thu_chi.MaxDropDownItems = 5
        Me.cmbID_thu_chi.Name = "cmbID_thu_chi"
        Me.cmbID_thu_chi.Size = New System.Drawing.Size(164, 24)
        Me.cmbID_thu_chi.TabIndex = 228
        '
        'frmESS_BienLaiChiHocPhiHocPhanXem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(866, 577)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbID_thu_chi)
        Me.Controls.Add(Me.grdThuChi)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.cmbDot_thu)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lblSo_tien_chu_nop)
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
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chkPrint)
        Me.Controls.Add(Me.labTong_so_tien_nop)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cmbLan_thu)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmESS_BienLaiChiHocPhiHocPhanXem"
        Me.Text = "Biên lai chi học phí học phần"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdThuChi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_nop As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_chu_phai_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_thua_thieu As System.Windows.Forms.Label
    Friend WithEvents lblTong_da_nop As System.Windows.Forms.Label
    Friend WithEvents lblTong_phai_nop As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtSo_tien As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents chkPrint As System.Windows.Forms.CheckBox
    Friend WithEvents labTong_so_tien_nop As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents labHo_ten As System.Windows.Forms.Label
    Friend WithEvents labTen_lop As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNoi_dung As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents txtSo_phieu As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpNgay_thu As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbLoai_tien As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents grdThuChi As System.Windows.Forms.DataGridView
    Friend WithEvents Hoc_ky As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nam_hoc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien_tra_lai As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbDot_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents cmbID_thu_chi As System.Windows.Forms.ComboBox
End Class
