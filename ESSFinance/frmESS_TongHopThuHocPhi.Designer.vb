<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_TongHopThuHocPhi
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
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdTongHop = New System.Windows.Forms.ToolStripButton
        Me.cmdViewChiTiet = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.cmdPrintTH_HV = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbKy_hieu_lop = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbID_mon_tc = New System.Windows.Forms.ComboBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.optNop_du = New System.Windows.Forms.RadioButton
        Me.optNop_thieu = New System.Windows.Forms.RadioButton
        Me.chkToanKhoa = New System.Windows.Forms.CheckBox
        Me.lblSo_SV = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSo_tien_con_lai = New System.Windows.Forms.Label
        Me.lblSo_tien_mien_giam = New System.Windows.Forms.Label
        Me.lblSo_tien_da_thu = New System.Windows.Forms.Label
        Me.lblSo_tien_phai_thu = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.grdDanhSach = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ten_lop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Phai_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Da_nop = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Thieu_thua = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.chkRemove = New System.Windows.Forms.CheckBox
        Me.cmbDot = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTinhDenNgay = New System.Windows.Forms.DateTimePicker
        Me.trvLop = New ESSFinance.TreeViewLop
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdTongHop, Me.cmdViewChiTiet, Me.ToolStripButton2, Me.ToolStripButton1, Me.cmdPrintTH_HV, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 130
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdTongHop
        '
        Me.cmdTongHop.Image = Global.ESSFinance.My.Resources.Resources.Import
        Me.cmdTongHop.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdTongHop.Name = "cmdTongHop"
        Me.cmdTongHop.Size = New System.Drawing.Size(90, 22)
        Me.cmdTongHop.Text = "Tổng hợp"
        '
        'cmdViewChiTiet
        '
        Me.cmdViewChiTiet.Image = Global.ESSFinance.My.Resources.Resources.DanhMuc
        Me.cmdViewChiTiet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdViewChiTiet.Name = "cmdViewChiTiet"
        Me.cmdViewChiTiet.Size = New System.Drawing.Size(103, 22)
        Me.cmdViewChiTiet.Text = "Xem Chi tiết"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(100, 22)
        Me.ToolStripButton2.Text = "In tổng hợp"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(135, 22)
        Me.ToolStripButton1.Text = "In tổng hợp khóa"
        '
        'cmdPrintTH_HV
        '
        Me.cmdPrintTH_HV.Image = Global.ESSFinance.My.Resources.Resources.Print
        Me.cmdPrintTH_HV.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdPrintTH_HV.Name = "cmdPrintTH_HV"
        Me.cmdPrintTH_HV.Size = New System.Drawing.Size(157, 22)
        Me.cmdPrintTH_HV.Text = "In tổng hợp học viện"
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
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(352, 32)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(49, 24)
        Me.cmbHoc_ky.TabIndex = 132
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(512, 30)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(120, 24)
        Me.cmbNam_hoc.TabIndex = 133
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(267, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(436, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 24)
        Me.Label5.TabIndex = 135
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKy_hieu_lop
        '
        Me.cmbKy_hieu_lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu_lop.Location = New System.Drawing.Point(669, 61)
        Me.cmbKy_hieu_lop.MaxDropDownItems = 5
        Me.cmbKy_hieu_lop.Name = "cmbKy_hieu_lop"
        Me.cmbKy_hieu_lop.Size = New System.Drawing.Size(111, 24)
        Me.cmbKy_hieu_lop.TabIndex = 142
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(562, 60)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "Lớp học phần:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon_tc
        '
        Me.cmbID_mon_tc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon_tc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon_tc.Location = New System.Drawing.Point(352, 62)
        Me.cmbID_mon_tc.MaxDropDownItems = 5
        Me.cmbID_mon_tc.Name = "cmbID_mon_tc"
        Me.cmbID_mon_tc.Size = New System.Drawing.Size(204, 24)
        Me.cmbID_mon_tc.TabIndex = 140
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(261, 62)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 24)
        Me.Label14.TabIndex = 141
        Me.Label14.Text = "Học phần:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'optNop_du
        '
        Me.optNop_du.BackColor = System.Drawing.Color.Transparent
        Me.optNop_du.Checked = True
        Me.optNop_du.Location = New System.Drawing.Point(352, 92)
        Me.optNop_du.Name = "optNop_du"
        Me.optNop_du.Size = New System.Drawing.Size(176, 23)
        Me.optNop_du.TabIndex = 144
        Me.optNop_du.TabStop = True
        Me.optNop_du.Text = "Đã hoàn thành nộp tiền"
        Me.optNop_du.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNop_du.UseVisualStyleBackColor = False
        '
        'optNop_thieu
        '
        Me.optNop_thieu.BackColor = System.Drawing.Color.Transparent
        Me.optNop_thieu.Location = New System.Drawing.Point(585, 91)
        Me.optNop_thieu.Name = "optNop_thieu"
        Me.optNop_thieu.Size = New System.Drawing.Size(195, 23)
        Me.optNop_thieu.TabIndex = 145
        Me.optNop_thieu.Text = "Chưa hoàn thành nộp tiền"
        Me.optNop_thieu.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.optNop_thieu.UseVisualStyleBackColor = False
        '
        'chkToanKhoa
        '
        Me.chkToanKhoa.AutoSize = True
        Me.chkToanKhoa.BackColor = System.Drawing.Color.Transparent
        Me.chkToanKhoa.Location = New System.Drawing.Point(268, 204)
        Me.chkToanKhoa.Name = "chkToanKhoa"
        Me.chkToanKhoa.Size = New System.Drawing.Size(314, 20)
        Me.chkToanKhoa.TabIndex = 146
        Me.chkToanKhoa.Text = "Tổng hợp từ đầu khoá học đến kỳ được chọn"
        Me.chkToanKhoa.UseVisualStyleBackColor = False
        '
        'lblSo_SV
        '
        Me.lblSo_SV.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSo_SV.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_SV.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_SV.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_SV.Location = New System.Drawing.Point(711, 204)
        Me.lblSo_SV.Name = "lblSo_SV"
        Me.lblSo_SV.Size = New System.Drawing.Size(69, 20)
        Me.lblSo_SV.TabIndex = 148
        Me.lblSo_SV.Text = "0"
        Me.lblSo_SV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(609, 204)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 20)
        Me.Label20.TabIndex = 147
        Me.Label20.Text = "Tổng số SV:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.lblSo_tien_con_lai)
        Me.GroupBox1.Controls.Add(Me.lblSo_tien_mien_giam)
        Me.GroupBox1.Controls.Add(Me.lblSo_tien_da_thu)
        Me.GroupBox1.Controls.Add(Me.lblSo_tien_phai_thu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(264, 133)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 65)
        Me.GroupBox1.TabIndex = 150
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tổng hợp thu"
        '
        'lblSo_tien_con_lai
        '
        Me.lblSo_tien_con_lai.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_con_lai.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_tien_con_lai.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_tien_con_lai.Location = New System.Drawing.Point(131, 43)
        Me.lblSo_tien_con_lai.Name = "lblSo_tien_con_lai"
        Me.lblSo_tien_con_lai.Size = New System.Drawing.Size(114, 20)
        Me.lblSo_tien_con_lai.TabIndex = 152
        Me.lblSo_tien_con_lai.Text = "0"
        Me.lblSo_tien_con_lai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_mien_giam
        '
        Me.lblSo_tien_mien_giam.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_mien_giam.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_tien_mien_giam.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_tien_mien_giam.Location = New System.Drawing.Point(402, 16)
        Me.lblSo_tien_mien_giam.Name = "lblSo_tien_mien_giam"
        Me.lblSo_tien_mien_giam.Size = New System.Drawing.Size(115, 20)
        Me.lblSo_tien_mien_giam.TabIndex = 151
        Me.lblSo_tien_mien_giam.Text = "0"
        Me.lblSo_tien_mien_giam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_da_thu
        '
        Me.lblSo_tien_da_thu.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_da_thu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_tien_da_thu.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_tien_da_thu.Location = New System.Drawing.Point(402, 43)
        Me.lblSo_tien_da_thu.Name = "lblSo_tien_da_thu"
        Me.lblSo_tien_da_thu.Size = New System.Drawing.Size(145, 20)
        Me.lblSo_tien_da_thu.TabIndex = 150
        Me.lblSo_tien_da_thu.Text = "0"
        Me.lblSo_tien_da_thu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_tien_phai_thu
        '
        Me.lblSo_tien_phai_thu.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_tien_phai_thu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_tien_phai_thu.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_tien_phai_thu.Location = New System.Drawing.Point(131, 16)
        Me.lblSo_tien_phai_thu.Name = "lblSo_tien_phai_thu"
        Me.lblSo_tien_phai_thu.Size = New System.Drawing.Size(145, 20)
        Me.lblSo_tien_phai_thu.TabIndex = 149
        Me.lblSo_tien_phai_thu.Text = "0"
        Me.lblSo_tien_phai_thu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-3, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Số tiền còn phải thu :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(265, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Số tiền đã thu:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(265, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Số tiền miễn giảm:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(20, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số tiền phải thu:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'grdDanhSach
        '
        Me.grdDanhSach.AllowUserToAddRows = False
        Me.grdDanhSach.AllowUserToDeleteRows = False
        Me.grdDanhSach.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdDanhSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grdDanhSach.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.grdDanhSach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.CadetBlue
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.grdDanhSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDanhSach.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.Ten_lop, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Phai_nop, Me.Da_nop, Me.Thieu_thua})
        Me.grdDanhSach.Location = New System.Drawing.Point(259, 224)
        Me.grdDanhSach.Name = "grdDanhSach"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Red
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 10.0!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdDanhSach.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.grdDanhSach.RowHeadersVisible = False
        Me.grdDanhSach.Size = New System.Drawing.Size(528, 340)
        Me.grdDanhSach.TabIndex = 151
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Ma_sv"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn1.HeaderText = "Mã sv"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 100
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ho_ten"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Họ và tên"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 150
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'Ten_lop
        '
        Me.Ten_lop.DataPropertyName = "Ten_lop"
        Me.Ten_lop.HeaderText = "Tên lớp"
        Me.Ten_lop.MinimumWidth = 130
        Me.Ten_lop.Name = "Ten_lop"
        Me.Ten_lop.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "So_tien_phai_nop"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "###,###"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn3.HeaderText = "Số tiền phải nộp"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 140
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "So_tien_mien_giam"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "###,###"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn4.HeaderText = "Miễn giảm"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 120
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'Phai_nop
        '
        Me.Phai_nop.DataPropertyName = "So_tien_nop"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "###,###"
        Me.Phai_nop.DefaultCellStyle = DataGridViewCellStyle5
        Me.Phai_nop.HeaderText = "Phải nộp"
        Me.Phai_nop.MinimumWidth = 120
        Me.Phai_nop.Name = "Phai_nop"
        Me.Phai_nop.ReadOnly = True
        '
        'Da_nop
        '
        Me.Da_nop.DataPropertyName = "So_tien_da_nop"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "###,###"
        Me.Da_nop.DefaultCellStyle = DataGridViewCellStyle6
        Me.Da_nop.HeaderText = "Đã nộp"
        Me.Da_nop.MinimumWidth = 120
        Me.Da_nop.Name = "Da_nop"
        Me.Da_nop.ReadOnly = True
        '
        'Thieu_thua
        '
        Me.Thieu_thua.DataPropertyName = "Thieu_thua"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "###,###"
        Me.Thieu_thua.DefaultCellStyle = DataGridViewCellStyle7
        Me.Thieu_thua.HeaderText = "Thiếu thừa"
        Me.Thieu_thua.MinimumWidth = 120
        Me.Thieu_thua.Name = "Thieu_thua"
        Me.Thieu_thua.ReadOnly = True
        '
        'chkRemove
        '
        Me.chkRemove.AutoSize = True
        Me.chkRemove.BackColor = System.Drawing.Color.Transparent
        Me.chkRemove.Location = New System.Drawing.Point(351, 114)
        Me.chkRemove.Name = "chkRemove"
        Me.chkRemove.Size = New System.Drawing.Size(242, 20)
        Me.chkRemove.TabIndex = 152
        Me.chkRemove.Text = "Loại bỏ sinh viên miễn giảm 100%"
        Me.chkRemove.UseVisualStyleBackColor = False
        '
        'cmbDot
        '
        Me.cmbDot.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot.Location = New System.Drawing.Point(714, 28)
        Me.cmbDot.MaxDropDownItems = 5
        Me.cmbDot.Name = "cmbDot"
        Me.cmbDot.Size = New System.Drawing.Size(64, 24)
        Me.cmbDot.TabIndex = 153
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(669, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 24)
        Me.Label7.TabIndex = 154
        Me.Label7.Text = "Đợt:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(589, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 155
        Me.Label9.Text = "Tính đến ngày"
        '
        'dtpTinhDenNgay
        '
        Me.dtpTinhDenNgay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpTinhDenNgay.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpTinhDenNgay.Location = New System.Drawing.Point(690, 109)
        Me.dtpTinhDenNgay.Name = "dtpTinhDenNgay"
        Me.dtpTinhDenNgay.Size = New System.Drawing.Size(91, 23)
        Me.dtpTinhDenNgay.TabIndex = 156
        '
        'trvLop
        '
        Me.trvLop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.trvLop.BackColor = System.Drawing.Color.Transparent
        Me.trvLop.dtLop = Nothing
        Me.trvLop.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.trvLop.Location = New System.Drawing.Point(-2, 30)
        Me.trvLop.Name = "trvLop"
        Me.trvLop.Size = New System.Drawing.Size(264, 537)
        Me.trvLop.TabIndex = 129
        '
        'frmESS_TongHopThuHocPhi
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.dtpTinhDenNgay)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbDot)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.chkRemove)
        Me.Controls.Add(Me.grdDanhSach)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblSo_SV)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.chkToanKhoa)
        Me.Controls.Add(Me.optNop_thieu)
        Me.Controls.Add(Me.optNop_du)
        Me.Controls.Add(Me.cmbKy_hieu_lop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbID_mon_tc)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.trvLop)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_TongHopThuHocPhi"
        Me.Text = "Tổng hợp thu học phí"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.grdDanhSach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trvLop As ESSFinance.TreeViewLop
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdTongHop As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdViewChiTiet As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu_lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon_tc As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents optNop_du As System.Windows.Forms.RadioButton
    Friend WithEvents optNop_thieu As System.Windows.Forms.RadioButton
    Friend WithEvents chkToanKhoa As System.Windows.Forms.CheckBox
    Friend WithEvents lblSo_SV As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_con_lai As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_mien_giam As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_da_thu As System.Windows.Forms.Label
    Friend WithEvents lblSo_tien_phai_thu As System.Windows.Forms.Label
    Friend WithEvents grdDanhSach As System.Windows.Forms.DataGridView
    Friend WithEvents chkRemove As System.Windows.Forms.CheckBox
    Friend WithEvents cmdPrintTH_HV As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ten_lop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Phai_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Da_nop As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Thieu_thua As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbDot As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTinhDenNgay As System.Windows.Forms.DateTimePicker
End Class
