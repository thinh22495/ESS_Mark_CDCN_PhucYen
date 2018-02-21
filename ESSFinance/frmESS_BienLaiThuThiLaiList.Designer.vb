<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_BienLaiThuThiLaiList
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdList = New System.Windows.Forms.ToolStripButton
        Me.cmdAdd = New System.Windows.Forms.ToolStripButton
        Me.cmdXemBienLai = New System.Windows.Forms.ToolStripButton
        Me.cmdEdit = New System.Windows.Forms.ToolStripButton
        Me.cmdCancel = New System.Windows.Forms.ToolStripButton
        Me.cmdPrint = New System.Windows.Forms.ToolStripButton
        Me.cmdExcel = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.cmbDot_thu = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpDen_ngay = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.dtpTu_ngay = New System.Windows.Forms.DateTimePicker
        Me.txtDen_so = New System.Windows.Forms.TextBox
        Me.txtTu_so = New System.Windows.Forms.TextBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtNguoi_thu = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.chkPhieu_huy = New System.Windows.Forms.CheckBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmbID_mon = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.lblVND = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbID_thu_chi = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbLan_thu = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblSo_phieu = New System.Windows.Forms.Label
        Me.cmbKy_hieu_lop = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.grdViewBienLai = New System.Windows.Forms.DataGridView
        Me.So_phieu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ngay_thu = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ma_sv = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Ho_ten = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.So_tien = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Noi_dung = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.trvLop = New ESSFinance.TreeViewLop
        Me.ToolStrip.SuspendLayout()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdList, Me.cmdAdd, Me.cmdXemBienLai, Me.cmdEdit, Me.cmdCancel, Me.cmdPrint, Me.cmdExcel, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(792, 25)
        Me.ToolStrip.TabIndex = 70
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdList
        '
        Me.cmdList.Image = Global.ESSFinance.My.Resources.Resources.Search
        Me.cmdList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdList.Name = "cmdList"
        Me.cmdList.Size = New System.Drawing.Size(109, 22)
        Me.cmdList.Text = "Liệt kê phiếu"
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.ESSFinance.My.Resources.Resources.Add
        Me.cmdAdd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(77, 22)
        Me.cmdAdd.Text = "Thu phí"
        '
        'cmdXemBienLai
        '
        Me.cmdXemBienLai.Image = Global.ESSFinance.My.Resources.Resources.View
        Me.cmdXemBienLai.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdXemBienLai.Name = "cmdXemBienLai"
        Me.cmdXemBienLai.Size = New System.Drawing.Size(76, 22)
        Me.cmdXemBienLai.Text = "Xem BL"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.ESSFinance.My.Resources.Resources.Edit
        Me.cmdEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(93, 22)
        Me.cmdEdit.Text = "Sửa phiếu"
        '
        'cmdCancel
        '
        Me.cmdCancel.Image = Global.ESSFinance.My.Resources.Resources.Cancel
        Me.cmdCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(91, 22)
        Me.cmdCancel.Text = "Huỷ phiếu"
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
        'cmbDot_thu
        '
        Me.cmbDot_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbDot_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDot_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbDot_thu.Location = New System.Drawing.Point(634, 29)
        Me.cmbDot_thu.MaxDropDownItems = 5
        Me.cmbDot_thu.Name = "cmbDot_thu"
        Me.cmbDot_thu.Size = New System.Drawing.Size(42, 24)
        Me.cmbDot_thu.TabIndex = 102
        Me.cmbDot_thu.Visible = False
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(347, 30)
        Me.cmbHoc_ky.MaxDropDownItems = 5
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(49, 24)
        Me.cmbHoc_ky.TabIndex = 100
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(478, 28)
        Me.cmbNam_hoc.MaxDropDownItems = 5
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(102, 24)
        Me.cmbNam_hoc.TabIndex = 101
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(269, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 24)
        Me.Label4.TabIndex = 103
        Me.Label4.Text = "Học kỳ:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(414, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 24)
        Me.Label5.TabIndex = 104
        Me.Label5.Text = "Năm học:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(596, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 24)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Đợt:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label7.Visible = False
        '
        'dtpDen_ngay
        '
        Me.dtpDen_ngay.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpDen_ngay.Checked = False
        Me.dtpDen_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpDen_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDen_ngay.Location = New System.Drawing.Point(556, 90)
        Me.dtpDen_ngay.Name = "dtpDen_ngay"
        Me.dtpDen_ngay.ShowCheckBox = True
        Me.dtpDen_ngay.Size = New System.Drawing.Size(111, 23)
        Me.dtpDen_ngay.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(477, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Đến ngày:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label9.Location = New System.Drawing.Point(258, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 23)
        Me.Label9.TabIndex = 108
        Me.Label9.Text = "Từ ngày:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtpTu_ngay
        '
        Me.dtpTu_ngay.Checked = False
        Me.dtpTu_ngay.CustomFormat = "dd/MM/yyyy"
        Me.dtpTu_ngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpTu_ngay.Location = New System.Drawing.Point(347, 90)
        Me.dtpTu_ngay.Name = "dtpTu_ngay"
        Me.dtpTu_ngay.ShowCheckBox = True
        Me.dtpTu_ngay.Size = New System.Drawing.Size(103, 23)
        Me.dtpTu_ngay.TabIndex = 106
        '
        'txtDen_so
        '
        Me.txtDen_so.Location = New System.Drawing.Point(472, 119)
        Me.txtDen_so.Name = "txtDen_so"
        Me.txtDen_so.Size = New System.Drawing.Size(44, 23)
        Me.txtDen_so.TabIndex = 111
        '
        'txtTu_so
        '
        Me.txtTu_so.Location = New System.Drawing.Point(347, 119)
        Me.txtTu_so.Name = "txtTu_so"
        Me.txtTu_so.Size = New System.Drawing.Size(44, 23)
        Me.txtTu_so.TabIndex = 110
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label16.Location = New System.Drawing.Point(396, 119)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(77, 23)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Đến phiếu:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label17.Location = New System.Drawing.Point(254, 119)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 23)
        Me.Label17.TabIndex = 112
        Me.Label17.Text = "Từ phiếu:"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtNguoi_thu
        '
        Me.txtNguoi_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNguoi_thu.Location = New System.Drawing.Point(677, 59)
        Me.txtNguoi_thu.Name = "txtNguoi_thu"
        Me.txtNguoi_thu.Size = New System.Drawing.Size(104, 23)
        Me.txtNguoi_thu.TabIndex = 116
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(543, 58)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(128, 23)
        Me.Label18.TabIndex = 117
        Me.Label18.Text = "Người thu, chi tiền:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'chkPhieu_huy
        '
        Me.chkPhieu_huy.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkPhieu_huy.BackColor = System.Drawing.Color.Transparent
        Me.chkPhieu_huy.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPhieu_huy.Location = New System.Drawing.Point(677, 90)
        Me.chkPhieu_huy.Name = "chkPhieu_huy"
        Me.chkPhieu_huy.Size = New System.Drawing.Size(104, 23)
        Me.chkPhieu_huy.TabIndex = 118
        Me.chkPhieu_huy.Text = "Phiếu huỷ"
        Me.chkPhieu_huy.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkPhieu_huy.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(263, 146)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(85, 24)
        Me.Label14.TabIndex = 126
        Me.Label14.Text = "Học phần:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_mon
        '
        Me.cmbID_mon.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_mon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_mon.Location = New System.Drawing.Point(347, 148)
        Me.cmbID_mon.MaxDropDownItems = 5
        Me.cmbID_mon.Name = "cmbID_mon"
        Me.cmbID_mon.Size = New System.Drawing.Size(170, 24)
        Me.cmbID_mon.TabIndex = 122
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label20.Location = New System.Drawing.Point(280, 178)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 24)
        Me.Label20.TabIndex = 132
        Me.Label20.Text = "Số phiếu:"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblVND
        '
        Me.lblVND.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVND.BackColor = System.Drawing.Color.Transparent
        Me.lblVND.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblVND.ForeColor = System.Drawing.Color.Brown
        Me.lblVND.Location = New System.Drawing.Point(653, 178)
        Me.lblVND.Name = "lblVND"
        Me.lblVND.Size = New System.Drawing.Size(128, 24)
        Me.lblVND.TabIndex = 131
        Me.lblVND.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(546, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 24)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "Tổng số tiền:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_thu_chi
        '
        Me.cmbID_thu_chi.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbID_thu_chi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_thu_chi.Location = New System.Drawing.Point(349, 60)
        Me.cmbID_thu_chi.MaxDropDownItems = 5
        Me.cmbID_thu_chi.Name = "cmbID_thu_chi"
        Me.cmbID_thu_chi.Size = New System.Drawing.Size(188, 24)
        Me.cmbID_thu_chi.TabIndex = 134
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(255, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 23)
        Me.Label1.TabIndex = 135
        Me.Label1.Text = "Loại thu, chi:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbLan_thu
        '
        Me.cmbLan_thu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbLan_thu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbLan_thu.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        Me.cmbLan_thu.Location = New System.Drawing.Point(729, 29)
        Me.cmbLan_thu.MaxDropDownItems = 5
        Me.cmbLan_thu.Name = "cmbLan_thu"
        Me.cmbLan_thu.Size = New System.Drawing.Size(42, 24)
        Me.cmbLan_thu.TabIndex = 136
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(691, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 24)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Lần:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSo_phieu
        '
        Me.lblSo_phieu.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_phieu.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblSo_phieu.ForeColor = System.Drawing.Color.Brown
        Me.lblSo_phieu.Location = New System.Drawing.Point(344, 178)
        Me.lblSo_phieu.Name = "lblSo_phieu"
        Me.lblSo_phieu.Size = New System.Drawing.Size(69, 24)
        Me.lblSo_phieu.TabIndex = 133
        Me.lblSo_phieu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbKy_hieu_lop
        '
        Me.cmbKy_hieu_lop.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmbKy_hieu_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKy_hieu_lop.Location = New System.Drawing.Point(653, 147)
        Me.cmbKy_hieu_lop.MaxDropDownItems = 5
        Me.cmbKy_hieu_lop.Name = "cmbKy_hieu_lop"
        Me.cmbKy_hieu_lop.Size = New System.Drawing.Size(128, 24)
        Me.cmbKy_hieu_lop.TabIndex = 138
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(546, 147)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 24)
        Me.Label8.TabIndex = 139
        Me.Label8.Text = "Lớp học phần:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.grdViewBienLai.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.So_phieu, Me.Ngay_thu, Me.Ma_sv, Me.Ho_ten, Me.So_tien, Me.Noi_dung})
        Me.grdViewBienLai.Location = New System.Drawing.Point(264, 205)
        Me.grdViewBienLai.Name = "grdViewBienLai"
        Me.grdViewBienLai.RowHeadersWidth = 25
        Me.grdViewBienLai.Size = New System.Drawing.Size(528, 360)
        Me.grdViewBienLai.TabIndex = 129
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
        DataGridViewCellStyle1.Format = "dd/MM/yyyy"
        Me.Ngay_thu.DefaultCellStyle = DataGridViewCellStyle1
        Me.Ngay_thu.HeaderText = "Ngày thu"
        Me.Ngay_thu.MinimumWidth = 100
        Me.Ngay_thu.Name = "Ngay_thu"
        Me.Ngay_thu.ReadOnly = True
        '
        'Ma_sv
        '
        Me.Ma_sv.DataPropertyName = "Ma_sv"
        Me.Ma_sv.HeaderText = "Mã SV"
        Me.Ma_sv.MinimumWidth = 100
        Me.Ma_sv.Name = "Ma_sv"
        Me.Ma_sv.ReadOnly = True
        '
        'Ho_ten
        '
        Me.Ho_ten.DataPropertyName = "Ho_ten"
        Me.Ho_ten.HeaderText = "Người nộp"
        Me.Ho_ten.MinimumWidth = 140
        Me.Ho_ten.Name = "Ho_ten"
        Me.Ho_ten.ReadOnly = True
        Me.Ho_ten.Width = 140
        '
        'So_tien
        '
        Me.So_tien.DataPropertyName = "So_tien"
        DataGridViewCellStyle2.Format = "###,###"
        Me.So_tien.DefaultCellStyle = DataGridViewCellStyle2
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
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(396, 30)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 24)
        Me.Label10.TabIndex = 140
        Me.Label10.Text = "(*)"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(771, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 24)
        Me.Label11.TabIndex = 141
        Me.Label11.Text = "(*)"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(676, 29)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 24)
        Me.Label12.TabIndex = 142
        Me.Label12.Text = "(*)"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label12.Visible = False
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Arial", 9.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(584, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(21, 24)
        Me.Label13.TabIndex = 143
        Me.Label13.Text = "(*)"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.trvLop.TabIndex = 128
        '
        'frmESS_BienLaiThuThiLaiList
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(792, 566)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.trvLop)
        Me.Controls.Add(Me.cmbID_thu_chi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbKy_hieu_lop)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbLan_thu)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblSo_phieu)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblVND)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbID_mon)
        Me.Controls.Add(Me.grdViewBienLai)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.chkPhieu_huy)
        Me.Controls.Add(Me.txtNguoi_thu)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.txtDen_so)
        Me.Controls.Add(Me.txtTu_so)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.dtpTu_ngay)
        Me.Controls.Add(Me.dtpDen_ngay)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbDot_thu)
        Me.Controls.Add(Me.cmbHoc_ky)
        Me.Controls.Add(Me.cmbNam_hoc)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.KeyPreview = True
        Me.Name = "frmESS_BienLaiThuThiLaiList"
        Me.Text = "Danh sách biên lai thu thi lại"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        CType(Me.grdViewBienLai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdList As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdAdd As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdEdit As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbDot_thu As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dtpDen_ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dtpTu_ngay As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDen_so As System.Windows.Forms.TextBox
    Friend WithEvents txtTu_so As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtNguoi_thu As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents chkPhieu_huy As System.Windows.Forms.CheckBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbID_mon As System.Windows.Forms.ComboBox
    Friend WithEvents trvLop As ESSFinance.TreeViewLop
    Friend WithEvents cmdExcel As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lblVND As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbID_thu_chi As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbLan_thu As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSo_phieu As System.Windows.Forms.Label
    Friend WithEvents cmbKy_hieu_lop As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents grdViewBienLai As System.Windows.Forms.DataGridView
    Friend WithEvents So_phieu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ngay_thu As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ma_sv As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ho_ten As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents So_tien As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Noi_dung As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmdXemBienLai As System.Windows.Forms.ToolStripButton
End Class
