<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmESS_XetHocNganh2
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
        Me.components = New System.ComponentModel.Container
        Me.ToolStrip = New System.Windows.Forms.ToolStrip
        Me.cmdSave = New System.Windows.Forms.ToolStripButton
        Me.cmdClose = New System.Windows.Forms.ToolStripButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbNam_hoc = New System.Windows.Forms.ComboBox
        Me.cmbHoc_ky = New System.Windows.Forms.ComboBox
        Me.lblLan_cap = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtMa_sv = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.cmbKhoa_hoc = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbID_chuyen_nganh = New System.Windows.Forms.ComboBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLy_do = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.dtmNgay_qd = New System.Windows.Forms.DateTimePicker
        Me.txtSo_QD = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblHo_ten = New System.Windows.Forms.Label
        Me.lblTen_nganh = New System.Windows.Forms.Label
        Me.lblChuyen_nganh = New System.Windows.Forms.Label
        Me.lblSo_ky_tich_luy = New System.Windows.Forms.Label
        Me.lblXep_hang_hoc_luc = New System.Windows.Forms.Label
        Me.cmdTimSV = New System.Windows.Forms.Button
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label19 = New System.Windows.Forms.Label
        Me.cmbID_lop = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.ToolStrip.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip
        '
        Me.ToolStrip.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ToolStrip.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmdSave, Me.cmdClose})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.ToolStrip.Size = New System.Drawing.Size(604, 25)
        Me.ToolStrip.TabIndex = 101
        Me.ToolStrip.Text = "ToolStrip1"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.ESSMarkMan.My.Resources.Resources.Save
        Me.cmdSave.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 22)
        Me.cmdSave.Text = "Lưu QĐ"
        Me.cmdSave.ToolTipText = "Xét tiêu chí"
        '
        'cmdClose
        '
        Me.cmdClose.Image = Global.ESSMarkMan.My.Resources.Resources.Close
        Me.cmdClose.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(65, 22)
        Me.cmdClose.Text = "Thoát"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(263, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 24)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Năm học:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbNam_hoc
        '
        Me.cmbNam_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNam_hoc.Location = New System.Drawing.Point(378, 22)
        Me.cmbNam_hoc.Name = "cmbNam_hoc"
        Me.cmbNam_hoc.Size = New System.Drawing.Size(108, 24)
        Me.cmbNam_hoc.TabIndex = 105
        '
        'cmbHoc_ky
        '
        Me.cmbHoc_ky.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbHoc_ky.Location = New System.Drawing.Point(95, 22)
        Me.cmbHoc_ky.Name = "cmbHoc_ky"
        Me.cmbHoc_ky.Size = New System.Drawing.Size(53, 24)
        Me.cmbHoc_ky.TabIndex = 103
        '
        'lblLan_cap
        '
        Me.lblLan_cap.BackColor = System.Drawing.Color.Transparent
        Me.lblLan_cap.Location = New System.Drawing.Point(24, 22)
        Me.lblLan_cap.Name = "lblLan_cap"
        Me.lblLan_cap.Size = New System.Drawing.Size(65, 24)
        Me.lblLan_cap.TabIndex = 102
        Me.lblLan_cap.Text = "Học kỳ:"
        Me.lblLan_cap.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(5, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 24)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Mã sinh viên:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMa_sv
        '
        Me.txtMa_sv.Location = New System.Drawing.Point(121, 38)
        Me.txtMa_sv.MaxLength = 30
        Me.txtMa_sv.Name = "txtMa_sv"
        Me.txtMa_sv.Size = New System.Drawing.Size(104, 23)
        Me.txtMa_sv.TabIndex = 107
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.cmbID_lop)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbKhoa_hoc)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.cmbID_chuyen_nganh)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtLy_do)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtmNgay_qd)
        Me.GroupBox1.Controls.Add(Me.txtSo_QD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmbNam_hoc)
        Me.GroupBox1.Controls.Add(Me.lblLan_cap)
        Me.GroupBox1.Controls.Add(Me.cmbHoc_ky)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(39, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(521, 267)
        Me.GroupBox1.TabIndex = 108
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nhập quyết định ngành 2"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(492, 57)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(23, 16)
        Me.Label17.TabIndex = 152
        Me.Label17.Text = "(*)"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Location = New System.Drawing.Point(0, 54)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(158, 24)
        Me.Label18.TabIndex = 150
        Me.Label18.Text = "Khóa học Ngành 2:"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbKhoa_hoc
        '
        Me.cmbKhoa_hoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbKhoa_hoc.Location = New System.Drawing.Point(164, 54)
        Me.cmbKhoa_hoc.Name = "cmbKhoa_hoc"
        Me.cmbKhoa_hoc.Size = New System.Drawing.Size(208, 24)
        Me.cmbKhoa_hoc.TabIndex = 151
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(492, 87)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(23, 16)
        Me.Label13.TabIndex = 149
        Me.Label13.Text = "(*)"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(7, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(82, 24)
        Me.Label12.TabIndex = 147
        Me.Label12.Text = "C.Ngành 2:"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_chuyen_nganh
        '
        Me.cmbID_chuyen_nganh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_chuyen_nganh.Location = New System.Drawing.Point(95, 84)
        Me.cmbID_chuyen_nganh.Name = "cmbID_chuyen_nganh"
        Me.cmbID_chuyen_nganh.Size = New System.Drawing.Size(391, 24)
        Me.cmbID_chuyen_nganh.TabIndex = 148
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(492, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(23, 16)
        Me.Label9.TabIndex = 145
        Me.Label9.Text = "(*)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(183, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 16)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "(*)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(154, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(23, 16)
        Me.Label5.TabIndex = 143
        Me.Label5.Text = "(*)"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(273, 140)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Ngày QĐ:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtLy_do
        '
        Me.txtLy_do.Location = New System.Drawing.Point(95, 169)
        Me.txtLy_do.MaxLength = 500
        Me.txtLy_do.Multiline = True
        Me.txtLy_do.Name = "txtLy_do"
        Me.txtLy_do.Size = New System.Drawing.Size(391, 91)
        Me.txtLy_do.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(21, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 91)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "Nội dung:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtmNgay_qd
        '
        Me.dtmNgay_qd.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtmNgay_qd.Location = New System.Drawing.Point(378, 140)
        Me.dtmNgay_qd.Name = "dtmNgay_qd"
        Me.dtmNgay_qd.ShowCheckBox = True
        Me.dtmNgay_qd.Size = New System.Drawing.Size(108, 23)
        Me.dtmNgay_qd.TabIndex = 139
        '
        'txtSo_QD
        '
        Me.txtSo_QD.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSo_QD.Location = New System.Drawing.Point(95, 140)
        Me.txtSo_QD.MaxLength = 30
        Me.txtSo_QD.Name = "txtSo_QD"
        Me.txtSo_QD.Size = New System.Drawing.Size(82, 23)
        Me.txtSo_QD.TabIndex = 138
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(21, 140)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 22)
        Me.Label6.TabIndex = 137
        Me.Label6.Text = "Số QĐ:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(492, 143)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 16)
        Me.Label10.TabIndex = 146
        Me.Label10.Text = "(*)"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(5, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 24)
        Me.Label8.TabIndex = 109
        Me.Label8.Text = "Họ và tên:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(6, 134)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(110, 24)
        Me.Label11.TabIndex = 110
        Me.Label11.Text = "C.Ngành chính:"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(5, 161)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(110, 24)
        Me.Label14.TabIndex = 111
        Me.Label14.Text = "Số kỳ tích luỹ:"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Location = New System.Drawing.Point(286, 161)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 24)
        Me.Label15.TabIndex = 112
        Me.Label15.Text = "Xếp hạng học lực:"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Location = New System.Drawing.Point(5, 104)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(110, 24)
        Me.Label16.TabIndex = 113
        Me.Label16.Text = "Ngành chính:"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblHo_ten
        '
        Me.lblHo_ten.BackColor = System.Drawing.Color.Transparent
        Me.lblHo_ten.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHo_ten.Location = New System.Drawing.Point(121, 72)
        Me.lblHo_ten.Name = "lblHo_ten"
        Me.lblHo_ten.Size = New System.Drawing.Size(408, 24)
        Me.lblHo_ten.TabIndex = 114
        Me.lblHo_ten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTen_nganh
        '
        Me.lblTen_nganh.BackColor = System.Drawing.Color.Transparent
        Me.lblTen_nganh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTen_nganh.Location = New System.Drawing.Point(121, 104)
        Me.lblTen_nganh.Name = "lblTen_nganh"
        Me.lblTen_nganh.Size = New System.Drawing.Size(477, 24)
        Me.lblTen_nganh.TabIndex = 115
        Me.lblTen_nganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblChuyen_nganh
        '
        Me.lblChuyen_nganh.BackColor = System.Drawing.Color.Transparent
        Me.lblChuyen_nganh.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChuyen_nganh.Location = New System.Drawing.Point(121, 134)
        Me.lblChuyen_nganh.Name = "lblChuyen_nganh"
        Me.lblChuyen_nganh.Size = New System.Drawing.Size(489, 24)
        Me.lblChuyen_nganh.TabIndex = 116
        Me.lblChuyen_nganh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSo_ky_tich_luy
        '
        Me.lblSo_ky_tich_luy.BackColor = System.Drawing.Color.Transparent
        Me.lblSo_ky_tich_luy.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSo_ky_tich_luy.Location = New System.Drawing.Point(121, 161)
        Me.lblSo_ky_tich_luy.Name = "lblSo_ky_tich_luy"
        Me.lblSo_ky_tich_luy.Size = New System.Drawing.Size(159, 24)
        Me.lblSo_ky_tich_luy.TabIndex = 117
        Me.lblSo_ky_tich_luy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblXep_hang_hoc_luc
        '
        Me.lblXep_hang_hoc_luc.BackColor = System.Drawing.Color.Transparent
        Me.lblXep_hang_hoc_luc.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblXep_hang_hoc_luc.Location = New System.Drawing.Point(409, 161)
        Me.lblXep_hang_hoc_luc.Name = "lblXep_hang_hoc_luc"
        Me.lblXep_hang_hoc_luc.Size = New System.Drawing.Size(183, 24)
        Me.lblXep_hang_hoc_luc.TabIndex = 118
        Me.lblXep_hang_hoc_luc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmdTimSV
        '
        Me.cmdTimSV.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTimSV.Location = New System.Drawing.Point(225, 37)
        Me.cmdTimSV.Name = "cmdTimSV"
        Me.cmdTimSV.Size = New System.Drawing.Size(28, 24)
        Me.cmdTimSV.TabIndex = 119
        Me.cmdTimSV.Text = "..."
        Me.cmdTimSV.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Location = New System.Drawing.Point(-1, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(158, 24)
        Me.Label19.TabIndex = 153
        Me.Label19.Text = "Lớp Ngành 2:"
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbID_lop
        '
        Me.cmbID_lop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbID_lop.Location = New System.Drawing.Point(163, 110)
        Me.cmbID_lop.Name = "cmbID_lop"
        Me.cmbID_lop.Size = New System.Drawing.Size(208, 24)
        Me.cmbID_lop.TabIndex = 154
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.BackColor = System.Drawing.Color.Transparent
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(492, 114)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(23, 16)
        Me.Label20.TabIndex = 155
        Me.Label20.Text = "(*)"
        '
        'frmESS_XetHocNganh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 465)
        Me.Controls.Add(Me.cmdTimSV)
        Me.Controls.Add(Me.lblXep_hang_hoc_luc)
        Me.Controls.Add(Me.lblSo_ky_tich_luy)
        Me.Controls.Add(Me.lblChuyen_nganh)
        Me.Controls.Add(Me.lblTen_nganh)
        Me.Controls.Add(Me.lblHo_ten)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtMa_sv)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.MaximizeBox = False
        Me.Name = "frmESS_XetHocNganh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xét ngành học 2"
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents cmdClose As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNam_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents cmbHoc_ky As System.Windows.Forms.ComboBox
    Friend WithEvents lblLan_cap As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMa_sv As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents txtLy_do As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtmNgay_qd As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtSo_QD As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbID_chuyen_nganh As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblHo_ten As System.Windows.Forms.Label
    Friend WithEvents lblTen_nganh As System.Windows.Forms.Label
    Friend WithEvents lblChuyen_nganh As System.Windows.Forms.Label
    Friend WithEvents lblSo_ky_tich_luy As System.Windows.Forms.Label
    Friend WithEvents lblXep_hang_hoc_luc As System.Windows.Forms.Label
    Friend WithEvents cmdTimSV As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmbKhoa_hoc As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmbID_lop As System.Windows.Forms.ComboBox
End Class
